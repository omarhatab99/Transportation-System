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

namespace TransportReservationSystem.Pages.Booking
{
    public partial class FrmBooking : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
        public static FrmBooking Booking {  get; set; }
        public List<string> Seats {  get; set; }
        public int Id { get; set; }

        public int PassengerBookingId {  get; set; }
        public FrmBooking()
        {
            InitializeComponent();
            Booking = this;
            Seats = new List<string>();
        }

        private void FrmBooking_Load(object sender, EventArgs e)
        {
            changePassengerComboBox();
            changeTripComboBox();

            GetPassengerDate();

            if(PassengerBookingId != 0)
            {
                CBPassenger.SelectedIndex = applicaitonDbContext.Passengers.ToList().FindIndex(x => x.Id == PassengerBookingId);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Application.OpenForms["FrmBooking"].
        }

        private void ConfirmReservationBtn_Click(object sender, EventArgs e)
        {
            //Get Selected Items 
            if(CBTrip.Items.Count <= 0)
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Not have any trip selected", FrmValidationDialog.enmType.Warning);
                return;
            }

            if (CBPassenger.Items.Count <= 0)
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Not have any Passenger selected", FrmValidationDialog.enmType.Warning);
                return;
            }


            var trip = CBTrip.Items[CBTrip.SelectedIndex] as Trip;
            var passenger = CBPassenger.Items[CBPassenger.SelectedIndex] as Passenger;

            //New object from Reservatation Vm
            ReservationVm reservationVm = new ReservationVm()
            {
                PassengerId = passenger.Id,
                TripId = trip.Id,
                Seats = Seats,
                TotalCost = GetTotalCost(),
                Status = true,
                
            };

            Reservation rs = applicaitonDbContext.Reservations.FirstOrDefault(x => x.PassengerId == reservationVm.PassengerId && x.TripId == reservationVm.TripId)!; 

            if(rs != null)
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Reservation is Already Existed..!!", FrmValidationDialog.enmType.Warning);
                return;
            }

            //Validation
            if(reservationVm.Seats.Count <= 0)
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Please select your seats..!!", FrmValidationDialog.enmType.Warning);
                return;
            }


            Reservation reservation = new Reservation()
            {
                PassengerId = reservationVm.PassengerId,
                TripId = reservationVm.TripId,
                TotalCost = reservationVm.TotalCost,
                Status = reservationVm.Status,
                Seats = reservationVm.Seats,
                SeatsNumber = Seats.Count()
            };

            if((trip.AvailableSeats - reservation.SeatsNumber) < 0)
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Sorry we have a proplem..!!", FrmValidationDialog.enmType.Error);
                return;
            }
            else
            {

                applicaitonDbContext.Reservations.Add(reservation);
                int result = applicaitonDbContext.SaveChanges();
                if(result != 0)
                {
                    trip.AvailableSeats -= reservation.SeatsNumber;
                    applicaitonDbContext.Trips.Update(trip);
                    applicaitonDbContext.SaveChanges();
                    this.Close();
                }
            }


            //Refresh Main Table.
            FrmReservations frmReservations = new FrmReservations();
            LoadForm(frmReservations);

            return;
            



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


        private decimal GetTotalCost()
        {
            var trip = CBTrip.Items[CBTrip.SelectedIndex] as Trip;
            return Seats.Count * trip.Fare;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmSeatsBtn_Click(object sender, EventArgs e)
        {
            //check category of Vehicle
            var passenger = CBPassenger.Items[CBPassenger.SelectedIndex] as Passenger;
            var trip = CBTrip.Items[CBTrip.SelectedIndex] as Trip;

            Category category = trip.Vehicle.Category;

            if(category.Capacity == 16)
            {
                FrmTouristSeats frmTouristSeats = new FrmTouristSeats();
                frmTouristSeats.TripId = trip.Id;
                frmTouristSeats.PassengerId = passenger.Id;
                frmTouristSeats.ShowDialog();
            }
            else if(category.Capacity == 32)
            {
                FrmsemiLowFloorSeats frmsemiLowFloorSeats = new FrmsemiLowFloorSeats();
                frmsemiLowFloorSeats.TripId = trip.Id;
                frmsemiLowFloorSeats.PassengerId = passenger.Id;
                frmsemiLowFloorSeats.SelectedSeats.Clear();
                frmsemiLowFloorSeats.ShowDialog();
            }
            else
            {
                FrmInterState frmInterState = new FrmInterState();
                frmInterState.TripId = trip.Id;
                frmInterState.PassengerId = passenger.Id;
                frmInterState.ShowDialog();
            }
        }

        private void CBPassenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToggleReservationSearch.Checked)
            {
                GetDataFilter();
            }
            else
            {
                //clear ReservedSeats
                Seats.Clear();
            }
        }

        private void CBTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToggleReservationSearch.Checked)
            {
                GetDataFilter();
            }
            else
            {
                //clear ReservedSeats
                Seats.Clear();
            }
        }

        private void GetDataFilter()
        {
            var trip = CBTrip.Items[CBTrip.SelectedIndex] as Trip;
            TripNumberInput.Text = trip.TripNo.ToString();
            DepatureInput.Text = trip.DepatureDate.ToString();
            ArrivalInput.Text = trip.ArrivalDate.ToString();
            SourceInput.Text = trip.Source.ToString();
            DestinationInput.Text = trip.Destination.ToString();
            FareInput.Text = trip.Fare.ToString();
            DriverNameInput.Text = trip.Driver.Username.ToString();
            DriverPhoneInput.Text = trip.Driver.Phone.ToString();
            DriverLicenseInput.Text = trip.Driver.License.ToString();
            VehicleNumberInput.Text = trip.Vehicle.VehicleNo.ToString();
            VehicleModel.Text = trip.Vehicle.Model.ToString();
            VehicleBrandInput.Text = trip.Vehicle.Brand.ToString();
        }

        private void GetPassengerDate()
        {
            if (Id > 0)
            {
                Passenger passenger = applicaitonDbContext.Passengers.FirstOrDefault(x => x.Id == Id)!;

                CBPassenger.SelectedIndex = applicaitonDbContext.Passengers.ToList().FindIndex(x => x.Id == passenger.Id);

                CBTrip.SelectedIndex = 0;
            }
            else
            {
                GetDataFilter();
            }
        }
        public void changePassengerComboBox()
        {
            ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

            //Set items to combobox for vehicle.
            List<Passenger> passengers = applicaitonDbContext.Passengers.Where(x => !x.IsDeleted).ToList();
            //driver set isAvailable true when done trip
            CBPassenger.DataSource = new BindingSource(passengers, null);
            CBPassenger.DisplayMember = "Username";
            CBPassenger.ValueMember = "Id";

            //clear ReservedSeats
            Seats.Clear();

        }
        public void changeTripComboBox()
        {
            ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

            //Set items to combobox for vehicle.
            List<Trip> trips = applicaitonDbContext.Trips.Where(x => !x.IsDeleted && x.AvailableSeats > 0 && !x.Done).ToList();
            //driver set isAvailable true when done trip
            CBTrip.DataSource = new BindingSource(trips, null);
            CBTrip.DisplayMember = "TripNo";
            CBTrip.ValueMember = "Id";

            //clear ReservedSeats
            Seats.Clear();
        }

        private void ToggleReservationSearch_CheckedChanged(object sender, EventArgs e)
        {
            if(ToggleReservationSearch.Checked)
            {
                GetDataFilter();
            }
        }
    }
}
