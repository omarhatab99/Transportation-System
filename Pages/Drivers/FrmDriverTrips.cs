using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Core.ViewModels;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Dialog;
using TransportReservationSystem.Rows;

namespace TransportReservationSystem.Pages.Drivers
{


    public partial class FrmDriverTrips : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

        public FrmDriverTrips()
        {
            InitializeComponent();
        }

        public int DriverId { get; set; }

        private void FrmDriverTrips_Load(object sender, EventArgs e)
        {
            GetAllData();

            List<Trip> trips = applicaitonDbContext.Trips.Where(x => x.DriverId == DriverId && !x.Done && !x.IsDeleted).ToList();
            Driver driver = applicaitonDbContext.Drivers.Where(x => x.Id == DriverId).FirstOrDefault()!;



            var bounsTrip = 0;
            if (driver.WorkedTrip > 50)
            {
                bounsTrip = (driver.WorkedTrip - 50);
            }

            var calcBouns = bounsTrip * 200;
            var neTSalary = driver.Salary + calcBouns;


            WorkedLabel.Text = driver.WorkedTrip.ToString();
            SalaryLabel.Text = driver.Salary.ToString();
            BounsLabel.Text = calcBouns.ToString();
            NetSalaryLabel.Text = neTSalary.ToString();



        }
        private void FLBTrips_SizeChanged(object sender, EventArgs e)
        {
            FLBTrips.SuspendLayout();
            foreach (Control ctrl in FLBTrips.Controls)
            {
                if (ctrl is UserControl) ctrl.Width = FLBTrips.ClientSize.Width;
            }
            FLBTrips.ResumeLayout();
        }

        private void GetAllData()
        {
            List<Trip> tripList = applicaitonDbContext.Trips.Where(x => !x.IsDeleted && !x.Done && x.DriverId == DriverId).ToList();


            List<TripVm> trips = tripList.Select(x => new TripVm
            {
                Id = x.Id,
                TripNo = x.TripNo,
                Source = x.Source,
                Destination = x.Destination,
                DepatureDate = x.DepatureDate,

            }).ToList();

            FLBTrips.Controls.Clear();

            foreach (var trip in trips)
            {
                UCDriverTrips uCDriverTrips = new UCDriverTrips();

                uCDriverTrips.TripId = (int)trip.Id;
                uCDriverTrips.DriverId = DriverId;
                uCDriverTrips.TripNo = trip.TripNo;
                uCDriverTrips.Source = trip.Source;
                uCDriverTrips.Destination = trip.Destination;
                uCDriverTrips.Depature = trip.DepatureDate;



                uCDriverTrips.Width = uCDriverTrips.Width;
                FLBTrips.Controls.Add(uCDriverTrips);
            }
        }





        private void ComboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker_Trips_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CustomCheckBoxAvailabelSearch_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitDriverForm_CreateBtn_Click(object sender, EventArgs e)
        {
            FrmConfirmationDialog frmConfirmationDialog = new FrmConfirmationDialog();
            frmConfirmationDialog.DriverId = Convert.ToInt16(DriverId);
            frmConfirmationDialog.Collection = "HOME";
            frmConfirmationDialog.ShowDialog();
        }

        private void FLBTrips_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBoxSource_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void WorkedLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
