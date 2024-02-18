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

namespace TransportReservationSystem.Pages.Passengers
{
    public partial class FrmPassengerReservation : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

        public int PassengerId { get; set; }
        public string Show { get; set; }


        public FrmPassengerReservation()
        {
            InitializeComponent();
        }

        private void ComboBoxTripNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomCheckBoxAvailabelSearch.Checked)
            {
                GetDataFilter();
            }
        }

        private void FrmPassengerReservation_Load(object sender, EventArgs e)
        {
            GetAllData();
            changeTripComboBox();
        }


        private void FLBReservations_SizeChanged(object sender, EventArgs e)
        {
            FLBReservations.SuspendLayout();
            foreach (Control ctrl in FLBReservations.Controls)
            {
                if (ctrl is UserControl) ctrl.Width = FLBReservations.ClientSize.Width;
            }
            FLBReservations.ResumeLayout();
        }


        public void changeTripComboBox()
        {
            ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

            //Set items to combobox for vehicle.
            List<Trip> trips = applicaitonDbContext.Trips.Where(x =>x.AvailableSeats > 0 && !x.Done).ToList();
            //driver set isAvailable true when done trip
            ComboBoxTripNo.DataSource = new BindingSource(trips, null);
            ComboBoxTripNo.DisplayMember = "TripNo";
            ComboBoxTripNo.ValueMember = "Id";

            //clear ReservedSeats

        }

        private void GetDataFilter()
        {
            ComboBoxTripNo.Enabled = true;

            var trip = ComboBoxTripNo.Items[ComboBoxTripNo.SelectedIndex] as Trip;
            List<Reservation> reservationList = new List<Reservation>();
            reservationList = applicaitonDbContext.Reservations.Where(x => !x.IsDeleted && x.TripId == trip.Id && !x.Trip.Done && x.PassengerId == PassengerId).ToList();

            List<ReservationVm> reservations = reservationList.Select(x => new ReservationVm
            {
                TripNo = applicaitonDbContext.Trips.FirstOrDefault(m => m.Id == x.TripId).TripNo,
                PassengerName = x.Passenger.Username,
                NumberOfSeats = x.Seats.Count,
                TotalCost = x.TotalCost,
                Status = x.Status

            }).ToList();


            FLBReservations.Controls.Clear();

            foreach (var reservation in reservations)
            {
                UCPassengerReservation uCReservation = new UCPassengerReservation();
                uCReservation.TripNo = reservation.TripNo;
                uCReservation.PassengerId = PassengerId;
                uCReservation.NOOFSeat = reservation.NumberOfSeats.ToString();
                uCReservation.TotalCost = reservation.TotalCost.ToString();
                uCReservation.Status = (reservation.Status) ? "Available" : "Cancellation";

                uCReservation.Width = FLBReservations.Width;
                FLBReservations.Controls.Add(uCReservation);
            }

        }

        private void CustomCheckBoxAvailabelSearch_Click(object sender, EventArgs e)
        {
            if (CustomCheckBoxAvailabelSearch.Checked)
            {

                GetDataFilter();


            }
            else
            {

                ComboBoxTripNo.Enabled = true;
                GetAllData();
            }
        }

        private void GetAllData()
        {
            List<Reservation> reservationList = new List<Reservation>();

            reservationList = applicaitonDbContext.Reservations.Where(x => !x.Trip.Done && x.PassengerId == PassengerId).ToList();

            List<ReservationVm> reservations = reservationList.Select(x => new ReservationVm
            {
                TripId = x.TripId,
                ReservationId = x.Id,
                TripNo = applicaitonDbContext.Trips.FirstOrDefault(m => m.Id == x.TripId).TripNo,
                PassengerName = x.Passenger.Username,
                NumberOfSeats = x.Seats.Count,
                TotalCost = x.TotalCost,
                Status = x.Status

            }).ToList();


            FLBReservations.Controls.Clear();

            foreach (var reservation in reservations)
            {
                UCPassengerReservation uCReservation = new UCPassengerReservation();
                uCReservation.PassengerId = PassengerId;
                uCReservation.PassengerName = reservation.PassengerName;
                uCReservation.ReservationId = reservation.ReservationId;
                uCReservation.TripNo = reservation.TripNo;
                uCReservation.NOOFSeat = reservation.NumberOfSeats.ToString();
                uCReservation.TotalCost = reservation.TotalCost.ToString();
                uCReservation.Status = (reservation.Status) ? "Available" : "Cancellation";

                uCReservation.Width = FLBReservations.Width;
                FLBReservations.Controls.Add(uCReservation);
            }

        }

    }
}
