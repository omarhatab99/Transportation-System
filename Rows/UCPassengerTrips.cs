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
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Pages.Booking;

namespace TransportReservationSystem.Rows
{
    public partial class UCPassengerTrips : UserControl
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
        public UCPassengerTrips()
        {
            InitializeComponent();
        }
        public int Id { get; set; }
        public int PassengerId { get; set; }

        public int TripNo
        {
            get { return Convert.ToInt32(LblTripNo); }
            set { LblTripNo.Text = Convert.ToString(value); }
        }

        public string Source
        {
            get { return LblSource.Text; }
            set { LblSource.Text = value; }
        }
        public string Destination
        {
            get { return LblDestination.Text; }
            set { LblDestination.Text = value; }
        }
        public DateTime Depature
        {
            get { return Convert.ToDateTime(LblDepature.Text); }
            set { LblDepature.Text = Convert.ToString(value); }
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {

            FrmPassengerBooking frmPassengerBooking = new FrmPassengerBooking();
            frmPassengerBooking.PassengerId = PassengerId;
            frmPassengerBooking.ShowDialog();
            //FrmBooking frmBooking = new FrmBooking();
            //frmBooking.PassengerBookingId = PassengerId;
            //List<Passenger> passengers = applicaitonDbContext.Passengers.Where(x => !x.IsDeleted && x.Id == PassengerId).ToList();
            ////driver set isAvailable true when done trip
            //frmBooking.CBPassenger.DataSource = new BindingSource(passengers, null);
            //frmBooking.CBPassenger.DisplayMember = "Username";
            //frmBooking.CBPassenger.ValueMember = "Id";
            //frmBooking.CBPassenger.Enabled = true;
            //frmBooking.ToggleReservationSearch.Hide();
            //frmBooking.label14.Hide();
            //frmBooking.ShowDialog();
        }
    }
}
