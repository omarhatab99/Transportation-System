using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using TransportReservationSystem.Rows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TransportReservationSystem.Pages.Passengers
{
    public partial class FrmPassengerCrud : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

        public bool Update { get; set; } = false;

        public int Id { get; set; }

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

        public string Gender
        {
            get { return CBGender.Text; }
            set { CBGender.Text = value; }
        }

        public string Address
        {
            get { return AddressTBOX.Text; }
            set { AddressTBOX.Text = value; }
        }
        public FrmPassengerCrud()
        {
            InitializeComponent();
        }


        private void FrmPassengerCrud_Load(object sender, EventArgs e)
        {
            List<Passenger> passengerList = applicaitonDbContext.Passengers.ToList();

            List<PassengerVm> passengersVModels = passengerList.Select(x => new PassengerVm
            {
                Id = x.Id,
                Username = x.Username,
                Email = x.Email,
                Phone = x.Phone,
                Gender = x.Gender,
                Address = x.Address,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
                IsDeleted = x.IsDeleted,
                Role = x.Role,
            }).ToList();

            CBGender.SelectedIndex = 0;
            PassengerDataGrid.DataSource = passengersVModels;

        }

        private void SubmitPassengerForm_CreateBtn_Click(object sender, EventArgs e)
        {
            string username = Username;
            string email = Email;
            string password = Password;
            string phone = Phone;
            string address = Address;
            string gender = CBGender.Items[CBGender.SelectedIndex]?.ToString()!;


            PassengerVm passengerVm = new PassengerVm()
            {
                Username = username,
                Email = email,
                Password = password,
                Gender = gender,
                Phone = phone,
                Address = address
            };



            ValidationResult validationResult = Validation.PassengerValidation(passengerVm);
            if (validationResult.IsValid)
            {
                // Check if passenger with the same email already exists
                Passenger isExisted = applicaitonDbContext.Passengers.FirstOrDefault(x => x.Email == Email || x.Phone == Phone)!;
                bool isValid = isExisted == null || isExisted.Id == Id;

                if (isValid)
                {
                    //Check is update
                    if (Update)
                    {
                        try
                        {
                            //Create Object From Driver
                            Passenger passenger = applicaitonDbContext.Passengers.Find(Id)!;
                            if (passenger != null)
                            {
                                passenger.Username = Username;
                                passenger.Email = Email;
                                passenger.Password = Password;
                                passenger.Phone = Phone;
                                passenger.Address = Address;
                                passenger.Gender = CBGender.Items[CBGender.SelectedIndex]?.ToString()!;


                                //Save Object in Database.
                                applicaitonDbContext.Passengers.Update(passenger);
                                applicaitonDbContext.SaveChanges();


                                //Refresh dataGridView
                                FrmPassengerCrud_Load(sender, e);

                                //Refresh Main Table.
                                FrmPassengers frmPassengers = new FrmPassengers();
                                LoadForm(frmPassengers);
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
                    else //Create
                    {
                        try
                        {
                            Passenger passenger = new Passenger
                            {
                                Username = Username,
                                Email = Email,
                                Password = Password,
                                Phone = Phone,
                                Address = Address,
                                Gender = CBGender.Items[CBGender.SelectedIndex]?.ToString()!,
                                Role = Role.PASSENGER.ToString()
                            };

                            //Save Object in Database.
                            applicaitonDbContext.Passengers.Add(passenger);
                            applicaitonDbContext.SaveChanges();


                            //Refresh dataGridView
                            FrmPassengerCrud_Load(sender, e);

                            //Refresh Main Table.
                            FrmPassengers frmPassengers = new FrmPassengers();
                            LoadForm(frmPassengers);

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
                    frmValidationDialog.showAlert("Email or Phone is already Existed", FrmValidationDialog.enmType.Error);
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

        private void PassengerDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = PassengerDataGrid.CurrentRow.Cells[0].Value;

            if (Update)
            {
                Passenger passenger = applicaitonDbContext.Passengers.Find(id);
                if (passenger != null)
                {
                    Id = (int)id;
                    Username = passenger.Username;
                    Email = passenger.Email;
                    Phone = passenger.Phone;
                    Password = passenger.Password;
                    Address = passenger.Address;
                    CBGender.SelectedIndex = (passenger.Gender == "Male") ? 0 : 1;
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
