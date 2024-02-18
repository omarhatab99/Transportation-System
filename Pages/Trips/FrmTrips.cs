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
using TransportReservationSystem.Pages.Passengers;
using TransportReservationSystem.Rows;

namespace TransportReservationSystem.Pages.Trips
{
    public partial class FrmTrips : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
        public FrmTrips()
        {
            InitializeComponent();
        }

        private void FrmTrips_Load(object sender, EventArgs e)
        {

            GetAllData();

            changeSourceComboBox();
            changeDestinationComboBox();

        }


        public void changeSourceComboBox()
        {
            ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

            //Set items to combobox for vehicle.
            List<Station> stations = applicaitonDbContext.Stations.ToList();

            ComboBoxSource.DataSource = new BindingSource(stations, null);
            ComboBoxSource.DisplayMember = "Name";
            ComboBoxSource.ValueMember = "Id";
        }
        public void changeDestinationComboBox()
        {
            ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

            //Set items to combobox for vehicle.
            List<Station> stations = applicaitonDbContext.Stations.ToList();
            //driver set isAvailable true when done trip
            ComboBoxDestination.DataSource = new BindingSource(stations, null);
            ComboBoxDestination.DisplayMember = "Name";
            ComboBoxDestination.ValueMember = "Id";

            if(ComboBoxDestination.Items.Count > 1)
            {
                ComboBoxDestination.SelectedIndex = 1;
            }
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
        private void CreateTripsBtn_Click(object sender, EventArgs e)
        {
            FrmTripCrud frmTripCrud = new FrmTripCrud();

            frmTripCrud.ShowDialog();
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

            List<Trip> trips = applicaitonDbContext.Trips.
                Where(x => !x.IsDeleted && x.Source.Trim().ToUpper() == sourceName && x.Destination.Trim().ToUpper() == destinationName).ToList();


            FLBTrips.Controls.Clear();

            foreach (var trip in trips)
            {
                var depatureDate = trip.DepatureDate.ToShortDateString().ToString();

                if(depatureDate == triptTimePicker)
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
        private void GetAllData()
        {

            DateTimePicker_Trips.Value = DateTime.Now;

            List<Trip> tripList = applicaitonDbContext.Trips.ToList();
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
