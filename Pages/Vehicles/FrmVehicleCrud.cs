using Castle.DynamicProxy;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Core.Constants;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Core.ViewModels;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Dialog;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TransportReservationSystem.Pages.Vehicles
{
    public partial class FrmVehicleCrud : Form
    {

        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

        public bool Update { get; set; } = false;

        public int Id { get; set; }
        public long LicensePlate
        {
            get { return Convert.ToInt64(LblLicensePlate.Text); }
            set { LblLicensePlate.Text = Convert.ToString(value); }
        }

        public string Category
        {
            get { return CbBoxCategory.Text; }
            set { CbBoxCategory.Text = value; }
        }
        public string Model
        {
            get { return ModelTBOX.Text; }
            set { ModelTBOX.Text = value; }
        }
        public string Brand
        {
            get { return BrandTBOX.Text; }
            set { BrandTBOX.Text = value; }
        }
        public string Colors
        {
            get { return ColorsTBOX.Text; }
            set { ColorsTBOX.Text = value; }
        }
        public int Year
        {
            get { return Convert.ToInt16(YearTBOX.Text); }
            set { YearTBOX.Text = Convert.ToString(value); }
        }

        public FrmVehicleCrud()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmVehicleCrud_Load(object sender, EventArgs e)
        {
            List<Vehicle> vehicles = applicaitonDbContext.Vehicles.ToList();

            List<VehicleVm> vehicleVModels = vehicles.Select(x => new VehicleVm
            {
                Id = x.Id,
                LicensePlate = x.LicensePlate,
                Category = x.Category.Name,
                Model = x.Model,
                Brand = x.Brand,
                Year = x.Year,
                VehicleNo = x.VehicleNo,
                IsAvailable = x.IsAvailable,
                Trips = x.Trips?.Count(),
                Maintenances = x.Maintenances?.Count(),
                HasMaintenance = x.HasMaintenance,
                HasScheduledMaintenance = x.HasScheduledMaintenance,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
                Color = x.Color,
                IsDeleted = x.IsDeleted,
                CurrentStation = x.CurrentStation

            }).ToList();

            dataGridView2.DataSource = vehicleVModels;


            //Set items to combobox.
            List<Category> categories = applicaitonDbContext.Categories.ToList();

            foreach (var category in categories)
            {
                CbBoxCategory.DataSource = new BindingSource(categories, null);
                CbBoxCategory.DisplayMember = "Name";
                CbBoxCategory.ValueMember = "Id";
                
            }

            if(Update == true)
            {
                Vehicle vehicle = applicaitonDbContext.Vehicles.FirstOrDefault(x => x.Id == Id);

                CbBoxCategory.SelectedIndex = categories.FindIndex(x => x.Id == vehicle.Category.Id);

            }


        }

        private void SubmitVehicleForm_CreateBtn_Click(object sender, EventArgs e)
        {


            //Get Data From Form
            var category = CbBoxCategory.Items[CbBoxCategory.SelectedIndex] as Category;
            var categoryId = (object)category.Id;
            string model = ModelTBOX.Text;
            string brand = BrandTBOX.Text;
            string colors = ColorsTBOX.Text;
            long licencePlate = 0;
            int year = 0;

            if (long.TryParse(LblLicensePlate.Text, out long result1))
            {

                licencePlate = result1;

            }

            if (int.TryParse(YearTBOX.Text, out int result2))
            {

                year = result2;

            }

            //Get Object From DriverVm
            VehicleVm vehicleVm = new VehicleVm()
            {
                LicensePlate = licencePlate,
                CategoryId = (int)categoryId,
                Model = model,
                Brand = brand,
                Color = colors,
                Year = year,
            };

            //Validation

            ValidationResult validationResult = Validation.VehicleValidation(vehicleVm);
            if (validationResult.IsValid)
            {
                //check if email not existed.

                Vehicle isExisted = applicaitonDbContext.Vehicles.FirstOrDefault(x => x.LicensePlate == licencePlate);

                bool isValid = isExisted == null || isExisted.Id == Id;

                if (isValid)
                {

                    //check updated
                    if (Update) //update
                    {
                        try
                        {
                            //Create Object From Driver
                            Vehicle vehicle = applicaitonDbContext.Vehicles.Find(Id);

                            if (vehicle != null)
                            {

                                vehicle.LicensePlate = (long)vehicleVm.LicensePlate;
                                vehicle.CategoryId = (int)vehicleVm.CategoryId; //proplem
                                vehicle.Model = vehicleVm.Model;
                                vehicle.Brand = vehicleVm.Brand;
                                vehicle.Year = (int)vehicleVm.Year;
                                vehicle.UpdatedAt = new DateTime();



                                //Save Object in Database.
                                applicaitonDbContext.Vehicles.Update(vehicle);
                                applicaitonDbContext.SaveChanges();


                                //Refresh dataGridView
                                FrmVehicleCrud_Load(sender, e);

                                //Refresh Main Table.
                                FrmVehicles frmVehicles = new FrmVehicles();
                                LoadForm(frmVehicles);

                            }
                            else
                            {
                                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                                frmValidationDialog.showAlert("Something is wrong try again..!!", FrmValidationDialog.enmType.Error);
                            }


                        }
                        catch (Exception ex)
                        {

                            FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                            frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Error);
                        }

                    }
                    else
                    { //create

                        try
                        {

                            //Create Object From Driver
                            Vehicle vehicle = new Vehicle
                            {
                                LicensePlate = (long)vehicleVm.LicensePlate,
                                CategoryId = (int)vehicleVm.CategoryId, //proplem
                                Model = vehicleVm.Model,
                                Brand = vehicleVm.Brand,
                                Year = (int)vehicleVm.Year,
                                Color = Colors,
                            };

                            Random rnd = new Random();
                            vehicle.VehicleNo = rnd.Next();
                            //vehicle number


                            //Save Object in Database.
                            applicaitonDbContext.Vehicles.Add(vehicle);
                            applicaitonDbContext.SaveChanges();


                            //Refresh dataGridView
                            FrmVehicleCrud_Load(sender, e);

                            //Refresh Main Table.
                            FrmVehicles frmVehicles = new FrmVehicles();
                            LoadForm(frmVehicles);
                        }
                        catch (Exception ex)
                        {

                            FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                            frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Error);
                        }

                    }



                }
                else
                {
                    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    frmValidationDialog.showAlert("Email or Licence or Phone is already Existed", FrmValidationDialog.enmType.Error);
                }


            }
            else
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert(validationResult.MessageError, FrmValidationDialog.enmType.Warning);
            }
        }


        public void LoadForm(Form applicationForm)
        {
            var x = Application.OpenForms["FrmDashboard"] as FrmDashboard;

            if (x.MainPanel.Controls.Count > 0)
                x.MainPanel.Controls.RemoveAt(0);
            applicationForm.FormBorderStyle = FormBorderStyle.None;
            applicationForm.TopLevel = false;
            applicationForm.Dock = DockStyle.Fill;
            x.MainPanel.Controls.Add(applicationForm);
            applicationForm.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridView2.CurrentRow.Cells[0].Value;

            if (Update)
            {
                Vehicle vehicle = applicaitonDbContext.Vehicles.Find(id);
                List<Category> categories = applicaitonDbContext.Categories.ToList();
                if (vehicle != null)
                {
                    Id = (int)id;
                    LicensePlate = (long)vehicle.LicensePlate;
                    Model = vehicle.Model;
                    Brand = vehicle.Brand;
                    Year = vehicle.Year;
                    Colors = vehicle.Color;

                    CbBoxCategory.SelectedIndex = categories.FindIndex(x => x.Id == vehicle.Category.Id);
                }
                {
                    return;
                }


            }
            else
            {
                return;
            }

        }
    }
}
