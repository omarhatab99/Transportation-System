using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Pages;
using TransportReservationSystem.Pages.Vehicles;
using TransportReservationSystem.Dialog;
using TransportReservationSystem.Pages.Trips;
using TransportReservationSystem.Pages.Booking;

namespace TransportReservationSystem.Rows
{
    public partial class UCVehicle : UserControl
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

        public UCVehicle()
        {
            InitializeComponent();
        }

        public int Id { get; set; }

        public long LicensePlate
        {
            get { return Convert.ToInt64(LblLicensePlate.Text); }
            set { LblLicensePlate.Text = Convert.ToString(value); }
        }

        public string Category
        {
            get { return LblCategory.Text; }
            set { LblCategory.Text = value; }
        }
        public string Model
        {
            get { return LblModel.Text; }
            set { LblModel.Text = value; }
        }
        public string Brand
        {
            get { return LblBrand.Text; }
            set { LblBrand.Text = value; }
        }
        public string IsAvailable
        {
            get { return LblAvailable.Text; }
            set { LblAvailable.Text = value; }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = applicaitonDbContext.Vehicles.FirstOrDefault(x => x.Id == Id && x.LicensePlate == LicensePlate);

            FrmVehicleCrud frmVehicleCrud = new FrmVehicleCrud();
            frmVehicleCrud.Id = vehicle.Id;
            frmVehicleCrud.Model = vehicle.Model;
            frmVehicleCrud.Brand = vehicle.Brand;
            frmVehicleCrud.Colors = vehicle.Color;
            frmVehicleCrud.Year = Convert.ToInt16(vehicle.Year);
            frmVehicleCrud.LicensePlate = Convert.ToInt64(vehicle.LicensePlate);
            frmVehicleCrud.SubmitVehicleForm_CreateBtn.BackColor = Color.Orange;
            frmVehicleCrud.SubmitVehicleForm_CreateBtn.Text = "Edit";

            //handle combobox
            //Set items to combobox.
            List<Category> categories = applicaitonDbContext.Categories.ToList();

            foreach (var category in categories)
            {
                frmVehicleCrud.CbBoxCategory.DataSource = new BindingSource(categories, null);
                frmVehicleCrud.CbBoxCategory.DisplayMember = "Name";
                frmVehicleCrud.CbBoxCategory.ValueMember = "Id";
            }


            frmVehicleCrud.Update = true;

            frmVehicleCrud.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            FrmConfirmationDialog frmConfirmationDialog = new FrmConfirmationDialog();
            frmConfirmationDialog.Id = Convert.ToInt16(Id);
            frmConfirmationDialog.Collection = "VEHICLE";
            frmConfirmationDialog.ShowDialog();
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBtn_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBtn_Click(sender, e);
        }

        private void toggleStatusVehicleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Vehicle vehicle = applicaitonDbContext.Vehicles.FirstOrDefault(x => x.Id == Id && x.LicensePlate == LicensePlate);

            Trip trips = applicaitonDbContext.Trips.FirstOrDefault(x => x.VehicleId == Id && !x.Done)!; 

            if (trips != null)
            {

                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("This Vehicle Has Trips Not Done Edit it firstly..!!", FrmValidationDialog.enmType.Error);
                return;
            }
            else
            {
                vehicle.IsAvailable = !vehicle.IsAvailable;

                applicaitonDbContext.Vehicles.Update(vehicle);

                applicaitonDbContext.SaveChanges();

                FrmVehicles frmVehicles = new FrmVehicles();

                LoadForm(frmVehicles);
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

        private void tripsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowTrips frmShowTrips = new FrmShowTrips();
            frmShowTrips.Id = Id;
            frmShowTrips.Show = "VEHICLE";
            frmShowTrips.StartPosition = FormStartPosition.CenterScreen;
            frmShowTrips.ShowDialog();
        }
    }
}
