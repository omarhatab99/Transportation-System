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
    public partial class FrmPassengerTrips : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
         
        public int PassengerId {  get; set; }
        public FrmPassengerTrips()
        {
            InitializeComponent();
        }

        private void FrmPassengerTrips_Load(object sender, EventArgs e)
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
            List<Trip> validTrips = new List<Trip>();
            List<Trip> listTrip = applicaitonDbContext.Trips.ToList();
            foreach (var trip in listTrip)
            {
                DateTime date1 = DateTime.Parse(trip.DepatureDate.ToString());
                DateTime date2 = DateTime.Now;

                if ((date1 > date2) && trip.AvailableSeats > 0 && !trip.Done)
                {
                    validTrips.Add(trip);
                }
            }

            var source = ComboBoxSource.SelectedItem as Station;
            var sourceName = source?.Name.Trim().ToUpper();
            var destination = ComboBoxDestination.SelectedItem as Station;
            var destinationName = destination?.Name.Trim().ToUpper();
            var triptTimePicker = DateTimePicker_Trips.Value.ToShortDateString();

            List<Trip> trips = validTrips.
                Where(x => x.Source.Trim().ToUpper() == sourceName && x.Destination.Trim().ToUpper() == destinationName).ToList();


            FLBTrips.Controls.Clear();

            foreach (var trip in trips)
            {
                var depatureDate = trip.DepatureDate.ToShortDateString().ToString();

                if (depatureDate == triptTimePicker)
                {
                    UCPassengerTrips uCPassengerTrips = new UCPassengerTrips();

                    uCPassengerTrips.Id = (int)trip.Id;
                    uCPassengerTrips.PassengerId = PassengerId;
                    uCPassengerTrips.TripNo = trip.TripNo;
                    uCPassengerTrips.Source = trip.Source;
                    uCPassengerTrips.Destination = trip.Destination;
                    uCPassengerTrips.Depature = trip.DepatureDate;



                    uCPassengerTrips.Width = uCPassengerTrips.Width;
                    FLBTrips.Controls.Add(uCPassengerTrips);
                }


            }
        }

        private void GetAllData()
        {

            List<Trip> validTrips = new List<Trip>();
            List<Trip> listTrip = applicaitonDbContext.Trips.ToList();
            foreach (var trip in listTrip)
            {
                DateTime date1 = DateTime.Parse(trip.DepatureDate.ToString());
                DateTime date2 = DateTime.Now;

                if ((date1 > date2) && trip.AvailableSeats > 0 && !trip.Done)
                {
                    validTrips.Add(trip);
                }
            }
            List<Trip> tripList = validTrips;


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
                UCPassengerTrips uCPassengerTrips = new UCPassengerTrips();

                uCPassengerTrips.Id = (int)trip.Id;
                uCPassengerTrips.PassengerId = PassengerId;
                uCPassengerTrips.TripNo = trip.TripNo;
                uCPassengerTrips.Source = trip.Source;
                uCPassengerTrips.Destination = trip.Destination;
                uCPassengerTrips.Depature = trip.DepatureDate;



                uCPassengerTrips.Width = uCPassengerTrips.Width;
                FLBTrips.Controls.Add(uCPassengerTrips);
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
    }
}
