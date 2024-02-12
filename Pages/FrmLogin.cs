using TransportReservationSystem.Core.Constants;
using TransportReservationSystem.Core.Models;
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

            Thread thread = new Thread(OpenDashboard);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();

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

        private void OpenDashboard()
        {
            Application.Run(new FrmDashboard());
        }

        private void OpenRegister()
        {
            Application.Run(new FrmRegister());
        }


    }
}
