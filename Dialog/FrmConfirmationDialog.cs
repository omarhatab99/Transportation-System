using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Core.Constants;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Pages.Drivers;
using TransportReservationSystem.Pages.Passengers;
using TransportReservationSystem.Pages.Trips;

namespace TransportReservationSystem.Dialog
{
    public partial class FrmConfirmationDialog : Form
    {
        public int Id {  get; set; }
        public int PassengerId {  get; set; }
        public int DriverId {  get; set; }
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
                Vehicle vehicle = applicaitonDbContext.Vehicles.FirstOrDefault(x => x.Id == Id)!;
                try
                {
                    //Trip belong to driver and not done also
                    Trip trip = applicaitonDbContext.Trips.FirstOrDefault(x => x.VehicleId == Id)!;


                    if (trip != null)
                    {
                        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                        frmValidationDialog.showAlert(Constants.VehicleHasTripsMessageError, FrmValidationDialog.enmType.Error);
                        return;
                    }
                    else
                    {
                        applicaitonDbContext.Vehicles.Remove(vehicle);
                        applicaitonDbContext.SaveChanges();

                        FrmVehicles frmVehicles = new FrmVehicles();

                        LoadForm(frmVehicles);

                        this.Close();
                    }

                  
                }
                catch (Exception ex)
                {

                    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Error);
                }
            }
            else if(Collection == "DRIVER")
            {

                Driver driver = applicaitonDbContext.Drivers.FirstOrDefault(x => x.Id == Id)!;
                try
                {   //Trip belong to driver and not done also
                    Trip trip = applicaitonDbContext.Trips.FirstOrDefault(x => x.DriverId == Id)!;
                    if(trip != null)
                    {
                        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                        frmValidationDialog.showAlert(Constants.DriverHasTripsMessageError, FrmValidationDialog.enmType.Error);
                        return;
                    }
                    else
                    {
                        //Remove Driver From Database..
                        applicaitonDbContext.Drivers.Remove(driver);
                        applicaitonDbContext.SaveChanges();

                        FrmDrivers frmDrivers = new FrmDrivers();

                        LoadForm(frmDrivers);

                        this.Close();
                    }

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
                    if(passenger.Reservations.Count() > 0)
                    {
                        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                        frmValidationDialog.showAlert("This Passenger Has Reservations Please Delete it", FrmValidationDialog.enmType.Warning);
                        return;
                    }
                    else
                    {
                        applicaitonDbContext.Passengers.Remove(passenger);
                        applicaitonDbContext.SaveChanges();

                        FrmPassengers frmPassengers = new FrmPassengers();

                        LoadForm(frmPassengers);

                        this.Close();
                    }


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
                            FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                            frmValidationDialog.showAlert(Constants.HasReservationsMessageError, FrmValidationDialog.enmType.Warning);
                            return;
                        }
                        else
                        {
                            if (trip.HomeAndAway > 0)
                            {
                                Trip HomeAndAway = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == trip.HomeAndAway)!;
                                if (HomeAndAway != null)
                                {
                                    DateTime homeTrip = DateTime.Parse(trip.DepatureDate.ToString());
                                    DateTime awayTrip = DateTime.Parse(HomeAndAway.DepatureDate.ToString());
                                    if (awayTrip > homeTrip) //First Trip
                                    {
                                        if(HomeAndAway.Reservations.Count() > 0)
                                        {
                                            FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                                            frmValidationDialog.showAlert($"Away Trip {HomeAndAway.TripNo} Has Reservation..!!", FrmValidationDialog.enmType.Warning);
                                            return;
                                        }
                                        else
                                        {
                                            trip.Vehicle.IsAvailable = true;
                                            trip.Driver.IsAvailable = true;

                                            applicaitonDbContext.Vehicles.Update(trip.Vehicle);
                                            applicaitonDbContext.Drivers.Update(trip.Driver);

                                            applicaitonDbContext.Trips.Remove(trip);
                                            applicaitonDbContext.Trips.Remove(HomeAndAway);

                                            applicaitonDbContext.SaveChanges();
                                        }

                                    }
                                    else //Second Trip
                                    {
                                        HomeAndAway.HomeAndAway = 0;
                                        applicaitonDbContext.Trips.Remove(trip);
                                        applicaitonDbContext.SaveChanges();
                                    }
                                }
                                else
                                {
                                    HomeAndAway.HomeAndAway = 0;
                                    applicaitonDbContext.Trips.Remove(trip);
                                    applicaitonDbContext.SaveChanges();
                                }

                            }
                            else
                            {
                                trip.Vehicle.IsAvailable = true;
                                trip.Driver.IsAvailable = true;

                                applicaitonDbContext.Vehicles.Update(trip.Vehicle);
                                applicaitonDbContext.Drivers.Update(trip.Driver);

                                applicaitonDbContext.Trips.Remove(trip);
                                applicaitonDbContext.SaveChanges();
                            }
                        }


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
            else if (Collection == "RESERVATION" || Collection == "CANCELLATION")
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


                    if(Collection == "CANCELLATION")
                    {
                        FrmPassengerReservation frmPassengerReservation = new FrmPassengerReservation();

                        frmPassengerReservation.PassengerId = PassengerId;

                        LoadForm(frmPassengerReservation);
                    }
                    else
                    {

                        FrmReservations frmReservations = new FrmReservations();

                        LoadForm(frmReservations);
                    }


                    this.Close();


                }
                catch (Exception ex)
                {

                    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Error);
                }
            }
            else if(Collection == "DONE")
            {
                Trip trip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == Id)!;

                try
                {
                    DateTime date1 = DateTime.Parse(trip.DepatureDate.ToString());
                    DateTime date2 = DateTime.Now;

                    //if(date1 > date2)
                    //{
                    //    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    //    frmValidationDialog.showAlert("Depature time Not Started..!!", FrmValidationDialog.enmType.Error);
                    //    return;
                    //}
                    

                    trip.Done = true;

                    Driver driver = applicaitonDbContext.Drivers.FirstOrDefault(x => x.Id == DriverId)!;

                    trip.Vehicle.CurrentStation = trip.Destination.Trim().ToUpper();
                    driver.CurrentStation = trip.Destination.Trim().ToUpper();
                    trip.Vehicle.IsAvailable = true;
                    driver.WorkedTrip = driver.WorkedTrip + 1;

                    applicaitonDbContext.Drivers.Update(driver);
                    applicaitonDbContext.Vehicles.Update(trip.Vehicle);

                    applicaitonDbContext.SaveChanges();

                    Analatycal analatycal = new Analatycal();
                    analatycal.NumberOfTrips = 1;

                    foreach (var reservation in trip.Reservations)
                    {
                        analatycal.TotalGain += reservation.TotalCost;
                        applicaitonDbContext.Remove(reservation);
                    }

                    applicaitonDbContext.Analatycals.Add(analatycal);
                    applicaitonDbContext.Trips.Remove(trip);

                    if(!driver.Trips.Any(x => !x.Done))
                    {
                        driver.IsAvailable = true;
                        applicaitonDbContext.Drivers.Update(driver);
                    }

                    applicaitonDbContext.SaveChanges();

                }
                catch (Exception ex)
                {
                    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Error);
                    return;
                }

                FrmDriverTrips frmDriverTrips = new FrmDriverTrips();
                frmDriverTrips.DriverId = DriverId;
                LoadForm(frmDriverTrips);

                this.Close();

            }
            else if (Collection == "HOME")
            {
                Driver driver = applicaitonDbContext.Drivers.FirstOrDefault(x => x.Id == DriverId)!;

                try
                {
                    List<Trip> trips = applicaitonDbContext.Trips.Where(x => x.DriverId == DriverId && !x.Done).ToList();
                    Vehicle vehicle = trips.LastOrDefault()?.Vehicle;

                    if(trips.Any())
                    {
                        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                        frmValidationDialog.showAlert("Some Trips not Done yet..!!", FrmValidationDialog.enmType.Error);
                        return;
                    }
                    else
                    {

                        if(driver != null && vehicle != null)
                        {
                            driver.CurrentStation = "FREE";
                            vehicle.CurrentStation = "FREE";

                            applicaitonDbContext.Drivers.Update(driver);
                            applicaitonDbContext.Vehicles.Update(vehicle);

                            applicaitonDbContext.SaveChanges();
                        }




                    }


                }
                catch (Exception ex)
                {
                    FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                    frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Error);
                    return;
                }

                FrmDriverTrips frmDriverTrips = new FrmDriverTrips();
                frmDriverTrips.DriverId = DriverId;
                LoadForm(frmDriverTrips);

                this.Close();

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
