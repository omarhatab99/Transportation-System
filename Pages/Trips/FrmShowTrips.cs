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
using TransportReservationSystem.Rows;

namespace TransportReservationSystem.Pages.Trips
{
    public partial class FrmShowTrips : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
        public int Id { get; set; }
        public string Show { get; set; }
        public FrmShowTrips()
        {
            InitializeComponent();
        }


        private void FrmShowTrips_Load(object sender, EventArgs e)
        {
            GetAllData();

            changeSourceComboBox();
            changeDestinationComboBox();
        }





        public void changeSourceComboBox()
        {
            ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

            //Set items to combobox for vehicle.
            List<Station> stations = applicaitonDbContext.Stations.Where(x => !x.IsDeleted).ToList();
            //driver set isAvailable true when done trip
            foreach (var station in stations)
            {
                ComboBoxSource.DataSource = new BindingSource(stations, null);
                ComboBoxSource.DisplayMember = "Name";
                ComboBoxSource.ValueMember = "Id";
            }
        }
        public void changeDestinationComboBox()
        {
            ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

            //Set items to combobox for vehicle.
            List<Station> stations = applicaitonDbContext.Stations.Where(x => !x.IsDeleted).ToList();
            //driver set isAvailable true when done trip
            foreach (var station in stations)
            {
                ComboBoxDestination.DataSource = new BindingSource(stations, null);
                ComboBoxDestination.DisplayMember = "Name";
                ComboBoxDestination.ValueMember = "Id";
            }

            ComboBoxDestination.SelectedIndex = 1;
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

        private void DateTimePicker_Trips_ValueChanged(object sender, EventArgs e)
        {
            GetDataFilter();
            FLBTrips_SizeChanged(sender, e);

        }

        private void ComboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomCheckBoxAvailabelSearch.Checked)
            {

                GetDataFilter();
                FLBTrips_SizeChanged(sender, e);
            }

        }

        private void ComboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomCheckBoxAvailabelSearch.Checked)
            {

                GetDataFilter();
                FLBTrips_SizeChanged(sender, e);
            }

        }
        private void GetDataFilter()
        {
            var source = ComboBoxSource.SelectedItem as Station;
            var sourceName = source?.Name.Trim().ToUpper();
            var destination = ComboBoxDestination.SelectedItem as Station;
            var destinationName = destination?.Name.Trim().ToUpper();
            var triptTimePicker = DateTimePicker_Trips.Value.ToShortDateString();

            List<Trip> trips = new List<Trip>();

            if (Show == "VEHICLE")
            {
                trips = applicaitonDbContext.Trips.Where(x => !x.IsDeleted && x.Source.Trim().ToUpper() == sourceName && x.Destination.Trim().ToUpper() == destinationName && x.VehicleId == Id && !x.Done).ToList();
            }
            else if (Show == "PASSENGER")
            {
                List<Reservation> reservationList = applicaitonDbContext.Reservations.Where(x => !x.IsDeleted && x.PassengerId == Id).ToList();
                trips = reservationList.Select(x => x.Trip).Where(x => !x.IsDeleted && x.Source.Trim().ToUpper() == sourceName && x.Destination.Trim().ToUpper() == destinationName && !x.Done).ToList();
            }
            else if (Show == "DRIVER")
            {
                trips = applicaitonDbContext.Trips.Where(x => !x.IsDeleted && x.Source.Trim().ToUpper() == sourceName && x.Destination.Trim().ToUpper() == destinationName && x.DriverId == Id && !x.Done).ToList();
            }


            FLBTrips.Controls.Clear();

            foreach (var trip in trips)
            {
                var depatureDate = trip.DepatureDate.ToShortDateString().ToString();

                if (depatureDate == triptTimePicker)
                {
                    UCTrip uCTrip = new UCTrip();

                    uCTrip.Id = (int)trip.Id;
                    uCTrip.TripNo = trip.TripNo;
                    uCTrip.Source = trip.Source;
                    uCTrip.Destination = trip.Destination;
                    uCTrip.Depature = trip.DepatureDate;



                    uCTrip.Width = uCTrip.Width;
                    FLBTrips.Controls.Add(uCTrip);
                }


            }
        }

        private void CustomCheckBoxAvailabelSearch_Click(object sender, EventArgs e)
        {
            if (CustomCheckBoxAvailabelSearch.Checked)
            {
                ComboBoxSource.Enabled = true;
                ComboBoxDestination.Enabled = true;
                DateTimePicker_Trips.Enabled = true;
                GetDataFilter();
                FLBTrips_SizeChanged(sender, e);

            }
            else
            {
                ComboBoxSource.Enabled = false;
                ComboBoxDestination.Enabled = false;
                DateTimePicker_Trips.Enabled = false;
                GetAllData();
                FLBTrips_SizeChanged(sender, e);
            }
        }

        private void GetAllData()
        {
            List<Trip> tripList = new List<Trip>();

            if(Show == "VEHICLE")
            {
                tripList = applicaitonDbContext.Trips.Where(x => !x.IsDeleted && x.VehicleId == Id && !x.Done).ToList();
            }
            else if(Show == "PASSENGER")
            {
                List<Reservation> reservationList = applicaitonDbContext.Reservations.Where(x => !x.IsDeleted && x.PassengerId == Id).ToList();
                tripList = reservationList.Select(x => x.Trip).Where(x => !x.IsDeleted && !x.Done).ToList();
            }
            else if(Show == "DRIVER")
            { 
                tripList = applicaitonDbContext.Trips.Where(x => !x.IsDeleted && x.DriverId == Id && !x.Done).ToList();
            }


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
                UCTrip uCTrip = new UCTrip();

                uCTrip.Id = (int)trip.Id;
                uCTrip.TripNo = trip.TripNo;
                uCTrip.Source = trip.Source;
                uCTrip.Destination = trip.Destination;
                uCTrip.Depature = trip.DepatureDate;



                uCTrip.Width = uCTrip.Width;
                FLBTrips.Controls.Add(uCTrip);
            }
        }


    }
}
