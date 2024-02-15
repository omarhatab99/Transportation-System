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
using TransportReservationSystem.Pages.Passengers;
using TransportReservationSystem.Pages.Trips;

namespace TransportReservationSystem.Dialog
{
    public partial class FrmConfirmationDialog : Form
    {
        public int Id {  get; set; }
        public string Collection {  get; set; }
        public FrmConfirmationDialog()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

            if(Collection == "VEHICLE")
            {
                Vehicle vehicle = applicaitonDbContext.Vehicles.FirstOrDefault(x => x.Id == Id);
                try
                {

                    applicaitonDbContext.Vehicles.Remove(vehicle);
                    applicaitonDbContext.SaveChanges();

                    FrmVehicles frmVehicles = new FrmVehicles();

                    LoadForm(frmVehicles);

                    this.Close();
                }
                catch (Exception ex)
                {

                    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Error);
                }
            }
            else if(Collection == "DRIVER")
            {

                Driver driver = applicaitonDbContext.Drivers.FirstOrDefault(x => x.Id == Id);
                try
                {

                    applicaitonDbContext.Drivers.Remove(driver);
                    applicaitonDbContext.SaveChanges();

                    FrmDrivers frmDrivers = new FrmDrivers();

                    LoadForm(frmDrivers);

                    this.Close();
                }
                catch (Exception ex)
                {

                    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Error);
                }
            }
            else if (Collection == "PASSENGER")
            {

                Passenger passenger = applicaitonDbContext.Passengers.FirstOrDefault(x => x.Id == Id)!;
                try
                {

                    applicaitonDbContext.Passengers.Remove(passenger);
                    applicaitonDbContext.SaveChanges();

                    FrmPassengers frmPassengers = new FrmPassengers();

                    LoadForm(frmPassengers);

                    this.Close();
                }
                catch (Exception ex)
                {

                    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Error);
                }
            }
            else if (Collection == "TRIP")
            {

                Trip trip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == Id)!;
                try
                {
                    DateTime date1 = DateTime.Parse(trip.DepatureDate.ToString());
                    DateTime date2 = DateTime.Now;

                    if (date2 > date1)
                    {
                        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                        frmValidationDialog.showAlert("Trip is Already Started..!!", FrmValidationDialog.enmType.Warning);
                        return;
                    }
                    else
                    {
                        if (trip.Reservations.Count > 0)
                        {
                            foreach (var reserve in trip.Reservations)
                            {
                                applicaitonDbContext.Reservations.Remove(reserve);
                                applicaitonDbContext.SaveChanges();
                            }
                        }

                        if (trip.HomeAndAway > 0)
                        {
                            Trip HomeAndAway = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == trip.HomeAndAway)!;
                            DateTime homeTrip = DateTime.Parse(trip.DepatureDate.ToString());
                            DateTime awayTrip = DateTime.Parse(HomeAndAway.DepatureDate.ToString());
                            if (awayTrip > homeTrip)
                            {
                                foreach (var reserve in HomeAndAway.Reservations)
                                {
                                    applicaitonDbContext.Reservations.Remove(reserve);
                                    applicaitonDbContext.SaveChanges();
                                }

                                applicaitonDbContext.Trips.Remove(HomeAndAway);
                                applicaitonDbContext.SaveChanges();
                            }
                        }

                        applicaitonDbContext.Trips.Remove(trip);
                        applicaitonDbContext.SaveChanges();

                        FrmTrips frmTrips = new FrmTrips();

                        LoadForm(frmTrips);

                        this.Close();
                    }

                }
                catch (Exception ex)
                {

                    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Error);
                }
            }
            else if (Collection == "RESERVATION")
            {

                Reservation reservation = applicaitonDbContext.Reservations.FirstOrDefault(x => x.Id == Id)!;
                try
                {
                    Trip trip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == reservation.TripId)!;

                    DateTime date1 = DateTime.Parse(trip.DepatureDate.ToString());
                    DateTime date2 = DateTime.Now;

                    if(date2 > date1  && !trip.Done)
                    {
                        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                        frmValidationDialog.showAlert("Trip is Already Started..!!", FrmValidationDialog.enmType.Warning);
                    }
                    else if(date1 > date2 && !trip.Done)
                    {
                        int numberOfSeats = reservation.SeatsNumber;
                        applicaitonDbContext.Reservations.Remove(reservation);
                        int result = applicaitonDbContext.SaveChanges();
                        if(result != 0)
                        {
                            trip.AvailableSeats += numberOfSeats;
                            applicaitonDbContext.Trips.Update(trip);
                            applicaitonDbContext.SaveChanges();
                        }
                    }
                    else
                    {
                        applicaitonDbContext.Reservations.Remove(reservation);
                        applicaitonDbContext.SaveChanges();
                    }


                    FrmReservations frmReservations = new FrmReservations();

                    LoadForm(frmReservations);

                    this.Close();


                }
                catch (Exception ex)
                {

                    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Error);
                }
            }
        }




        private void iconCancelTop_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
