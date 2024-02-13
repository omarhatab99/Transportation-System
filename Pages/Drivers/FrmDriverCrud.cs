using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Core.Constants;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Core.ViewModels;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Dialog;
using TransportReservationSystem.Core.Constants;
using ValidationResult = TransportReservationSystem.Core.Constants.ValidationResult;

namespace TransportReservationSystem.Pages
{
    public partial class FrmDriverCrud : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

        public bool Update { get; set; } = false;

        public int Id { get; set; }
        public long License
        {
            get { return Convert.ToInt64(LicenceTBOX.Text); }
            set { LicenceTBOX.Text = Convert.ToString(value); }
        }

        public string Username
        {
            get { return UsernameTBOX.Text; }
            set { UsernameTBOX.Text = value; }
        }
        public string Email
        {
            get { return EmailTBOX.Text; }
            set { EmailTBOX.Text = value; }
        }
        public string Password
        {
            get { return PasswordTBOX.Text; }
            set { PasswordTBOX.Text = value; }
        }
        public string Phone
        {
            get { return PhoneTBOX.Text; }
            set { PhoneTBOX.Text = value; }
        }
        public decimal Salary
        {
            get { return Convert.ToDecimal(SalaryTBOX.Text); }
            set { SalaryTBOX.Text = Convert.ToString(value); }
        }
        public FrmDriverCrud()
        {
            InitializeComponent();
        }

        private void FrmDriverCrud_Load(object sender, EventArgs e)
        {

            List<Driver> drivers = applicaitonDbContext.Drivers.ToList();

            List<DriverVm> driversVModels = drivers.Select(x => new DriverVm
            {
                Id = x.Id,
                License = x.License,
                Username = x.Username,
                Email = x.Email,
                Phone = x.Phone,
                Salary = x.Salary,
                HasBouns = x.HasBouns,
                CurrentStation = x.CurrentStation,
                Trips = x.Trips?.Count(),
                Maintenances = x.Maintenances?.Count(),
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
                IsDeleted = x.IsDeleted,

            }).ToList();

            dataGridView1.DataSource = driversVModels;


        }



        private void SubmitDriverForm_CreateBtn_Click(object sender, EventArgs e)
        {

            //Get Data From Form
            string username = UsernameTBOX.Text;
            string email = EmailTBOX.Text;
            string password = PasswordTBOX.Text;
            string phone = PhoneTBOX.Text;
            decimal salary = 0;
            long licence = 0;

            if (long.TryParse(LicenceTBOX.Text, out long result1))
            {

                licence = result1;

            }

            if (decimal.TryParse(SalaryTBOX.Text, out decimal result2))
            {

                salary = result2;

            }

            //Get Object From DriverVm
            DriverVm driverVm = new DriverVm()
            {
                License = licence,
                Username = username,
                Email = email,
                Phone = phone,
                Password = password,
                Salary = salary,
                Role = Role.DRIVER.ToString()
            };

            //Validation

            ValidationResult validationResult = Validation.DriverValidation(driverVm);
            if (validationResult.IsValid)
            {
                //check if email not existed.

                Driver isExisted = applicaitonDbContext.Drivers.FirstOrDefault(x => x.Email == email || x.License == licence || x.Phone == phone);

                bool isValid = isExisted == null || isExisted.Id == Id;

                if (isValid)
                {

                    //check updated
                    if (Update) //update
                    {
                        try
                        {
                            //Create Object From Driver
                            Driver driver = applicaitonDbContext.Drivers.Find(Id);

                            if (driver != null)
                            {

                                driver.License = (long)driverVm.License;
                                driver.Username = driverVm.Username;
                                driver.Email = driverVm.Email;
                                driver.Phone = driverVm.Phone;
                                driver.Password = driverVm.Password;
                                driver.Salary = (decimal)driverVm.Salary;
                                driver.Role = Role.DRIVER.ToString();
                                driver.UpdatedAt = new DateTime();


                                //Save Object in Database.
                                applicaitonDbContext.Drivers.Update(driver);
                                applicaitonDbContext.SaveChanges();


                                //Refresh dataGridView
                                FrmDriverCrud_Load(sender, e);

                                //Refresh Main Table.
                                FrmDrivers frmDrivers = new FrmDrivers();
                                LoadForm(frmDrivers);

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
                            Driver driver = new Driver
                            {
                                License = (long)driverVm.License,
                                Username = driverVm.Username,
                                Email = driverVm.Email,
                                Phone = driverVm.Phone,
                                Password = driverVm.Password,
                                Salary = (decimal)driverVm.Salary,
                                Role = Role.DRIVER.ToString()
                            };

                            //Save Object in Database.
                            applicaitonDbContext.Drivers.Add(driver);
                            applicaitonDbContext.SaveChanges();


                            //Refresh dataGridView
                            FrmDriverCrud_Load(sender, e);

                            //Refresh Main Table.
                            FrmDrivers frmDrivers = new FrmDrivers();
                            LoadForm(frmDrivers);
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridView1.CurrentRow.Cells[0].Value;
            
            if(Update)
            {
                Driver driver = applicaitonDbContext.Drivers.Find(id);

                if(driver != null)
                {
                    Id = (int)id;
                    License = (long)driver.License;
                    Username = driver.Username;
                    Email = driver.Email;
                    Phone = driver.Phone;
                    Password = driver.Password;
                    Salary = (decimal)driver.Salary;
                }
                {
                    return;
                }


            }else
            {
                return;
            }

        }
    }
}
