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
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Pages;
using TransportReservationSystem.Pages.Drivers;
using TransportReservationSystem.Pages.Passengers;
using TransportReservationSystem.Pages.Trips;

namespace TransportReservationSystem
{
    public partial class FrmDashboard : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
       
        public string Role { get; set; }
        public int Id { get; set; }

        public static Form ActivatedForm = new Form();

        bool sidebarExpanded = true;

        public FrmDashboard(string role, int id)
        {
            InitializeComponent();
            Role = role;
            Id = id;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            Permission(Role, Id);
            FrmHome frmHome = new FrmHome();
            LoadForm(frmHome);

        }

        //Permission 
        private void Permission(string role, int id)
        {
            if (role == "STAFF")
            {
                Staff staff = applicaitonDbContext.Staff.FirstOrDefault(x => x.Id == id);
                if (staff.Role == "USER")
                {
                    UserSide.Hide();
                }
            }
            else if (role == "DRIVER")
            {
                Driver driver = applicaitonDbContext.Drivers.FirstOrDefault(x => x.Id == id);
                DriverSide.Hide();
                UserSide.Hide();
                PassengerSide.Hide();
                ReservationSide.Hide();
                VehicleSide.Hide();
                DashboardSide.Hide();
                //TripSide.Hide();
            }
            else if (role == "PASSENGER")
            {
                Passenger passenger = applicaitonDbContext.Passengers.FirstOrDefault(x => x.Id == id);
                DriverSide.Hide();
                UserSide.Hide();
                PassengerSide.Hide();
                //ReservationSide.Hide();
                VehicleSide.Hide();
                DashboardSide.Hide();
                //TripSide.Hide();
            }
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            //set time interval to make it smooter
            SidebarTimer.Interval = 20;
            SidebarTimer.Start();
        }

        private void SidebarTimer_Tick(object sender, EventArgs e) //sidebar timer .
        {
            if (sidebarExpanded)
            {
                //if sidebar is expanded.
                FrmOverlay frmOverlay = new FrmOverlay();
                LoadForm(frmOverlay);
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarExpanded = false;
                    SidebarTimer.Stop();
                    LoadForm(ActivatedForm);
                }
            }
            else
            {
                //if sidebar is not expanded.
                FrmOverlay frmOverlay = new FrmOverlay();
                LoadForm(frmOverlay);
                Sidebar.Width += 10;

                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpanded = true;
                    SidebarTimer.Stop();
                    LoadForm(ActivatedForm);

                }
            }
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();

            //Change Background To Active
            ButtonColorChangeByClick(DashboardBtn);

            //switch
            LoadForm(frmHome);
        }

        private void DriversBtn_Click(object sender, EventArgs e)
        {
            FrmDrivers frmDrivers = new FrmDrivers();

            ActivatedForm = frmDrivers;

            //Change Background To Active
            ButtonColorChangeByClick(DriversBtn);

            //switch
            LoadForm(frmDrivers);

        }

        private void VehicleBtn_Click(object sender, EventArgs e)
        {
            FrmVehicles frmVehicles = new FrmVehicles();

            ActivatedForm = frmVehicles;

            //Change Background To Active
            ButtonColorChangeByClick(VehicleBtn);


            //switch
            LoadForm(frmVehicles);
        }

        private void ReservationBtn_Click(object sender, EventArgs e)
        {


            if (Role == "PASSENGER")
            {
                FrmPassengerReservation FrmPassengerReservation = new FrmPassengerReservation();
                FrmPassengerReservation.PassengerId = Id;
                ActivatedForm = FrmPassengerReservation;

                LoadForm(FrmPassengerReservation);

            }
            else
            {
                FrmReservations frmReservations = new FrmReservations();

                ActivatedForm = frmReservations;


                //Change Background To Active
                ButtonColorChangeByClick(ReservationBtn);

                LoadForm(frmReservations);


            }

            //Change Background To Active
            ButtonColorChangeByClick(ReservationBtn);

            //switch

        }

        private void PassengersBtn_Click(object sender, EventArgs e)
        {
            FrmPassengers frmPassengers = new FrmPassengers();

            ActivatedForm = frmPassengers;


            //Change Background To Active
            ButtonColorChangeByClick(PassengersBtn);

            //switch
            LoadForm(frmPassengers);
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            FrmUsers frmUsers = new FrmUsers();

            ActivatedForm = frmUsers;


            //Change Background To Active
            ButtonColorChangeByClick(UsersBtn);

            //switch
            LoadForm(frmUsers);

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            void OpenNewForm()
            {
                Application.Run(new FrmLogin());
            }


            Thread thread = new Thread(OpenNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void ButtonColorChangeByClick(Button activeBtn)
        {
            DashboardBtn.BackColor = Color.DarkViolet;
            PassengersBtn.BackColor = Color.DarkViolet;
            DriversBtn.BackColor = Color.DarkViolet;
            ReservationBtn.BackColor = Color.DarkViolet;
            VehicleBtn.BackColor = Color.DarkViolet;
            UsersBtn.BackColor = Color.DarkViolet;
            TripsBtn.BackColor = Color.DarkViolet;
            activeBtn.BackColor = Color.FromArgb(169, 39, 176);

        }

        public void LoadForm(Form applicationForm)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            applicationForm.FormBorderStyle = FormBorderStyle.None;
            applicationForm.TopLevel = false;
            applicationForm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(applicationForm);
            applicationForm.Show();
        }

        private void TripsBtn_Click(object sender, EventArgs e)
        {
            if(Role == "PASSENGER")
            {
                FrmPassengerTrips frmPassengerTrips = new FrmPassengerTrips();
                frmPassengerTrips.PassengerId = Id;
                ActivatedForm = frmPassengerTrips;

                LoadForm(frmPassengerTrips);

            }
            else if(Role == "DRIVER")
            {
                FrmDriverTrips frmDriverTrips = new FrmDriverTrips();
                frmDriverTrips.DriverId = Id; 
                ActivatedForm = frmDriverTrips;

                LoadForm(frmDriverTrips);

            }
            else
            {
                FrmTrips frmTrips = new FrmTrips();

                ActivatedForm = frmTrips;

                LoadForm(frmTrips);
            }



            ButtonColorChangeByClick(TripsBtn);

            //switch
        }
    }
}
