using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Data.Context;

namespace TransportReservationSystem.Pages.Booking
{
    public partial class FrmsemiLowFloorSeats : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();


        public int PassengerId { get; set; }
        public int TripId { get; set; }
        public List<string> SelectedSeats {  get; set; }
        public FrmsemiLowFloorSeats()
        {
            InitializeComponent();
            SelectedSeats = new List<string>();
        }

        private void FrmsemiLowFloorSeats_Load(object sender, EventArgs e)
        {
            Trip trip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == TripId)!;
            Passenger passenger = applicaitonDbContext.Passengers.FirstOrDefault(x => x.Id == PassengerId)!;
            PassengerNameInput.Text = passenger.Username;
            TripNumberInput.Text = Convert.ToString(trip.TripNo);
            AvailableSeats.Text = Convert.ToString(trip.AvailableSeats);
            Capacity.Text = Convert.ToString(trip.Vehicle.Category.Capacity);

            SelectedSeats.Clear();


            List<Reservation> reservations = applicaitonDbContext.Reservations.Where(x => x.TripId == trip.Id).ToList();
            List<string> seats = reservations.SelectMany(x => x.Seats).ToList();

            foreach (var button in this.Controls.OfType<Button>())
            {
                var isReserverd = seats.FirstOrDefault(x => x == button.Name);
                if(isReserverd != null)
                {

                    button.BackColor = Color.DarkRed;
                    button.ForeColor = Color.White;
                    button.Enabled = false;
                }

                if (button.Name.StartsWith("S"))
                {
                    button.Click += reserveSetButton_Click;

                }




            }
        }


        private void reserveSetButton_Click(object? sender, EventArgs e)
        {

            var currentButton = sender as Button;
            Trip trip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == TripId)!;
            List<Reservation> reservations = applicaitonDbContext.Reservations.Where(x => x.TripId == trip.Id).ToList();
            List<string> ReservedSeats = reservations.SelectMany(x => x.Seats).ToList();
            var isReserverd = ReservedSeats.FirstOrDefault(x => x.Trim().ToLower() == currentButton.Name.Trim().ToLower());
          
            if (isReserverd == null)
            {
                if (currentButton.BackColor == Color.Green) //Reserved
                {
                    currentButton.BackColor = Color.DarkRed;
                    currentButton.ForeColor = Color.White;

                    if (trip.AvailableSeats > 0)
                    {
                        SelectedSeats.Add(currentButton.Name);
                        AvailableSeats.Text = Convert.ToString((Convert.ToInt32(AvailableSeats.Text) - 1));

                    }
                    return;
                }
                else //Free
                {
                    currentButton.BackColor = Color.Green;
                    currentButton.ForeColor = Color.Black;

                    SelectedSeats.Remove(currentButton.Name);
                    AvailableSeats.Text = Convert.ToString((Convert.ToInt32(AvailableSeats.Text) + 1));

                    return;
                }
            }
        }

        private void SubmitSeatsFormBtn_Click(object sender, EventArgs e)
        {
            FrmBooking.Booking.Seats = SelectedSeats;
            this.Close();
        }
    }
}
