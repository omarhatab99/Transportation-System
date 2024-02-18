using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Core.Constants;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Core.ViewModels;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Dialog;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TransportReservationSystem.Pages
{
    public partial class FrmRegister : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //Get Data From Form
            string email = EmailInput.Text.ToString().Trim();
            string password = PasswordInput.Text.ToString().Trim();
            string gender = CBGender?.SelectedItem?.ToString();
            string phone = PhoneInput.Text;
            string username = email?.Split('@')?.FirstOrDefault() ?? "Known";



            PassengerVm passengerVm = new PassengerVm()
            {
                Username = username,
                Email = email,
                Password = password,
                Gender = gender,
                Phone = phone,
            };

            // Check if passenger with the same email already exists
            Passenger existingPassenger = applicaitonDbContext.Passengers.FirstOrDefault(p => p.Email == email || p.Phone == phone);
            if (existingPassenger != null)
            {
                // Passenger with the same email already exists
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("User with the same email or Phone already exist.", FrmValidationDialog.enmType.Warning);
                return;
            }

            ValidationResult validationResult = Validation.PassengerValidation(passengerVm);

            if (validationResult.IsValid)
            {
                Passenger passenger = new Passenger()
                {
                    Username = passengerVm.Username,
                    Email = passengerVm.Email,
                    Password = passengerVm.Password,
                    Gender = passengerVm.Gender,
                    Phone = passengerVm.Phone,
                    Address = passengerVm.Address,
                    Role = Role.PASSENGER.ToString()

                };

                applicaitonDbContext.Passengers.Add(passenger);
                applicaitonDbContext.SaveChanges();

                LoginBtn_Click(sender, e);
            }
            else
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert(validationResult.MessageError, FrmValidationDialog.enmType.Warning);
            }

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(OpenLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void OpenLogin()
        {
            Application.Run(new FrmLogin());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
