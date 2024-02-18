using TransportReservationSystem.Core.Constants;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Dialog;
using TransportReservationSystem.Pages;

namespace TransportReservationSystem
{

    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            SeedingAdmin.SeedingAdminWithLoginFormStart(); //seeding admin if not found
        }

        private void FrmLogin_Activated(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            ApplicaitonDbContext applicationDbContext = new ApplicaitonDbContext();
            FrmValidationDialog frmValidationDialog = new FrmValidationDialog();

            string email = EmailInput.Text.ToString().Trim();
            string password = PasswordInput.Text.ToString().Trim();
            bool isPassenger = PassengerRBtn.Checked;
            bool isStaff = StaffRBtn.Checked;
            bool isDriver = DriverRBtn.Checked;

            //void OpenDashboard()
            //{
            //    Application.Run(new FrmDashboard("STAFF", 1));
            //}
            //Thread thread = new Thread(OpenDashboard);
            //thread.SetApartmentState(ApartmentState.STA);
            //thread.Start();
            //this.Close();

            if (string.IsNullOrEmpty(email))
            {
                frmValidationDialog.showAlert("Email must be required ..!!", FrmValidationDialog.enmType.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                frmValidationDialog.showAlert("Password must be required ..!!", FrmValidationDialog.enmType.Warning);
                return;
            }

            if (!isPassenger && !isStaff && !isDriver)
            {
                // If no role is selected, show error message and return
                frmValidationDialog.showAlert("Please select a role.", FrmValidationDialog.enmType.Warning);
                return;
            }

            bool isAuthenticated = false;

            if (isPassenger)
            {
                Passenger existingPassenger = applicationDbContext.Passengers.FirstOrDefault(p => p.Email == email)!;
                if (existingPassenger != null && existingPassenger.Password == password)
                {
                    isAuthenticated = true;
                    void OpenDashboard()
                    {
                        Application.Run(new FrmDashboard("PASSENGER", existingPassenger.Id));
                    }
                    Thread thread = new Thread(OpenDashboard);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    this.Close();
                }
            }
            else if (isStaff)
            {
                Staff existingStaff = applicationDbContext.Staff.FirstOrDefault(s => s.Email == email)!;
                if (existingStaff != null && existingStaff.Password == password)
                {
                    isAuthenticated = true;
                    void OpenDashboard()
                    {
                        Application.Run(new FrmDashboard("STAFF", existingStaff.Id));
                    }
                    Thread thread = new Thread(OpenDashboard);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    this.Close();
                }
            }
            else if (isDriver)
            {
                Driver existingDriver = applicationDbContext.Drivers.FirstOrDefault(d => d.Email == email)!;
                if (existingDriver != null && existingDriver.Password == password)
                {
                    isAuthenticated = true;
                    void OpenDashboard()
                    {
                        Application.Run(new FrmDashboard("DRIVER", existingDriver.Id));
                    }
                    Thread thread = new Thread(OpenDashboard);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    this.Close();
                }
            }

            if (!isAuthenticated)
            {


                frmValidationDialog.showAlert("Incorrect email or password.", FrmValidationDialog.enmType.Warning);
            }



            ////Get Data Form
            //string Email = EmailInput.Text.ToString().Trim();
            //string Password = PasswordInput.Text.ToString().Trim();

            ////validation
            //ValidationResult validationResult = Constants.AuthenticationValidation(Email, Password);
            //if (validationResult.IsValid)
            //{
            //    Thread thread = new Thread(OpenDashboard);
            //    thread.SetApartmentState(ApartmentState.STA);
            //    thread.Start();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show(validationResult.MessageError, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(OpenRegister);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void ShowPasswordBtn_CheckedChanged(object sender, EventArgs e)
        {
            PasswordInput.PasswordChar = ShowPasswordBtn.Checked ? '\0' : '*';
        }



        private void OpenRegister()
        {
            Application.Run(new FrmRegister());
        }


    }
}
