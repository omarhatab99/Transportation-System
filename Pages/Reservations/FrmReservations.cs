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
using TransportReservationSystem.Pages.Booking;
using TransportReservationSystem.Rows;

namespace TransportReservationSystem
{
    public partial class FrmReservations : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

        public int Id {  get; set; }
        public string Show {  get; set; }
        public FrmReservations()
        {
            InitializeComponent();
        }

        private void FrmReservations_Load(object sender, EventArgs e)
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

        private void CreateReservationBrn_Click(object sender, EventArgs e)
        {
            FrmBooking frmBooking = new FrmBooking();
            if(Id != 0 && Show == "PASSENGER")
            {
               frmBooking.PassengerBookingId = Id;
            }
            frmBooking.ShowDialog();
        }

        private void ComboBoxTripNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomCheckBoxAvailabelSearch.Checked)
            {
                GetDataFilter();
            }
        }

        public void changeTripComboBox()
        {
            ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

            //Set items to combobox for vehicle.
            List<Trip> trips = applicaitonDbContext.Trips.Where(x => !x.IsDeleted && x.AvailableSeats > 0 && !x.Done).ToList();
            //driver set isAvailable true when done trip
            ComboBoxTripNo.DataSource = new BindingSource(trips, null);
            ComboBoxTripNo.DisplayMember = "TripNo";
            ComboBoxTripNo.ValueMember = "Id";

            //clear ReservedSeats

        }

        private void GetDataFilter()
        {
            ComboBoxTripNo.Enabled = true;

            if(Id != 0 && Show == "TRIP")
            {
                ComboBoxTripNo.SelectedIndex = applicaitonDbContext.Trips.ToList().FindIndex(x => x.Id == Id);
            }

            var trip = ComboBoxTripNo.Items[ComboBoxTripNo.SelectedIndex] as Trip;
            List<Reservation> reservationList = new List<Reservation>();


            if (Id != 0 && Show == "PASSENGER")
            {
                reservationList = applicaitonDbContext.Reservations.Where(x => !x.IsDeleted && !x.Trip.Done && x.TripId == trip.Id && x.PassengerId == Id).ToList();
            }
            else
            {
                reservationList = applicaitonDbContext.Reservations.Where(x => !x.IsDeleted && !x.Trip.Done && x.TripId == trip.Id).ToList();
            }

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
                UCReservation uCReservation = new UCReservation();
                uCReservation.TripNo = reservation.TripNo;
                uCReservation.NOOFSeat = reservation.NumberOfSeats.ToString();
                uCReservation.TotalCost = reservation.TotalCost.ToString();
                uCReservation.Status = (reservation.Status) ? "Available" : "Cancellation";

                uCReservation.Width = FLBReservations.Width;
                FLBReservations.Controls.Add(uCReservation);
            }

        }
        private void GetAllData()
        {
            List<Reservation> reservationList = new List<Reservation>();

            if (Id != 0 && Show == "PASSENGER")
            {
                reservationList = applicaitonDbContext.Reservations.Where(x => !x.IsDeleted && x.PassengerId == Id && !x.Trip.Done).ToList();
            }
            else if (Id != 0 && Show == "TRIP")
            {
                reservationList = applicaitonDbContext.Reservations.Where(x => !x.IsDeleted && !x.Trip.Done && x.TripId == Id).ToList();
            }
            else
            {
                reservationList = applicaitonDbContext.Reservations.Where(x => !x.IsDeleted && !x.Trip.Done).ToList();
            }

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
                UCReservation uCReservation = new UCReservation();
                uCReservation.Id = reservation.TripId;
                uCReservation.ReservationId = reservation.ReservationId;
                uCReservation.TripNo = reservation.TripNo;
                uCReservation.NOOFSeat = reservation.NumberOfSeats.ToString();
                uCReservation.TotalCost = reservation.TotalCost.ToString();
                uCReservation.Status = (reservation.Status) ? "Available" : "Cancellation";

                uCReservation.Width = FLBReservations.Width;
                FLBReservations.Controls.Add(uCReservation);
            }

        }
        private void CustomCheckBoxAvailabelSearch_Click(object sender, EventArgs e)
        {
            if(CustomCheckBoxAvailabelSearch.Checked)
            {

                GetDataFilter();


            }
            else
            {

                ComboBoxTripNo.Enabled = true;
                GetAllData();
            }
        }
    }
}
