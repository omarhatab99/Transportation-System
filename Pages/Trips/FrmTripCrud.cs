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
using TransportReservationSystem.Core.ViewModels;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Dialog;

namespace TransportReservationSystem.Pages.Trips
{
    public partial class FrmTripCrud : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

        public static int parentX, parentY;
        public bool Update { get; set; } = false;

        public int Id { get; set; }

        public string Source
        {
            get { return CBSource.Text; }
            set { CBSource.Text = value; }
        }
        public string Destination
        {
            get { return CBDestination.Text; }
            set { CBDestination.Text = value; }
        }

        public string Vehicle
        {
            get { return CBVehicle.Text; }
            set { CBVehicle.Text = value; }
        }

        public string Driver
        {
            get { return CBDriver.Text; }
            set { CBDriver.Text = value; }
        }
        public DateTime Depature
        {
            get { return Convert.ToDateTime(DateTimePicker_Depature.Value); }
            set { DateTimePicker_Depature.Value = value; }
        }

        public DateTime Arrival
        {
            get { return Convert.ToDateTime(DateTimePicker_Arrival.Value); }
            set { DateTimePicker_Arrival.Value = value; }
        }

        public string Fare
        {
            get { return Convert.ToString(FareTBOX.Text); }
            set { FareTBOX.Text = Convert.ToString(value); }
        }

        public FrmTripCrud()
        {
            InitializeComponent();
        }

        private void SubmitTripForm_CreateBtn_Click(object sender, EventArgs e)
        {
            if (CBDriver.Items.Count <= 0)
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Not have any Driver Free or in Station", FrmValidationDialog.enmType.Warning);
                return;
            }


            if (CBVehicle.Items.Count <= 0)
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Not have any Vehicles Free or in Station", FrmValidationDialog.enmType.Warning);
                return;
            }

            string source = Source;
            string destination = Destination;
            DateTime depature = DateTime.Parse(Depature.ToString());
            DateTime arrival = DateTime.Parse(Arrival.ToString());
            Driver driver = CBDriver.Items[CBDriver.SelectedIndex] as Driver;
            var driverId = (int)driver.Id;
            Vehicle vehicle = CBVehicle.Items[CBVehicle.SelectedIndex] as Vehicle;
            var vehicleId = (int)vehicle.Id;
            decimal fare = 0;


            if (decimal.TryParse(Fare.ToString(), out decimal result))
            {
                fare = result;
            }

            //get object from Vm
            TripVm tripVm = new TripVm
            {
                Source = source,
                Destination = destination,
                DepatureDate = depature,
                ArrivalDate = arrival,
                Fare = fare,
                DriverId = driverId,
                VehicleId = vehicleId,

            };

            //validation
            ValidationResult validationResult = Validation.TripValidation(tripVm);

            Vehicle vehicleT = applicaitonDbContext.Vehicles.FirstOrDefault(x => x.Id == tripVm.VehicleId);
            Driver driverT = applicaitonDbContext.Drivers.FirstOrDefault(x => x.Id == tripVm.DriverId);

            if (validationResult.IsValid)
            {

                if (Update)//update
                {

                    Trip updatedTrip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == Id)!;

                    updatedTrip.Vehicle.IsAvailable = true;
                    updatedTrip.Vehicle.CurrentStation = updatedTrip.Source.ToUpper();
                    updatedTrip.Driver.IsAvailable = true;
                    updatedTrip.Driver.CurrentStation = updatedTrip.Source.ToUpper();
                    //GET Away Trip From Trip
                    //Check if this trip has away trip
                    

                    updatedTrip.Source = tripVm.Source;
                    updatedTrip.Destination = tripVm.Destination;
                    updatedTrip.DepatureDate = tripVm.DepatureDate;
                    updatedTrip.ArrivalDate = tripVm.ArrivalDate;
                    updatedTrip.Fare = tripVm.Fare;
                    updatedTrip.DriverId = tripVm.DriverId;
                    updatedTrip.VehicleId = tripVm.VehicleId;

                    if (updatedTrip.HomeAndAway > 0)
                    {
                        Trip HomeAndAway = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == updatedTrip.HomeAndAway)!;
                        HomeAndAway.VehicleId = tripVm.VehicleId;
                        HomeAndAway.DriverId = tripVm.DriverId;
                        //TODO::HERE
                        applicaitonDbContext.Trips.Update(HomeAndAway);
                        applicaitonDbContext.SaveChanges();
                    }

                    try
                    {
                        applicaitonDbContext.Trips.Update(updatedTrip);

                        vehicleT.IsAvailable = false;
                        vehicleT.CurrentStation = tripVm.Destination.ToUpper();
                        driverT.IsAvailable = false;
                        driverT.CurrentStation = tripVm.Destination.ToUpper();
                        applicaitonDbContext.Drivers.Update(driverT);
                        applicaitonDbContext.Vehicles.Update(vehicleT);
                        applicaitonDbContext.SaveChanges();

                        //refresh Combobox
                        FrmTripCrud_Load(sender, e);
                        changeDriversComboBox();
                        changeVehicleComboBox();

                        //Refresh Main Table.
                        FrmTrips frmTrips = new FrmTrips();
                        LoadForm(frmTrips);

                        return;

                    }
                    catch (Exception ex)
                    {
                        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                        frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Warning);
                    }

                }
                else //create
                {
                    try
                    {
                        if (ToggleButtonHomaAndAway.Checked)
                        {

                            //Get object from Trip 
                            Trip trip1 = new Trip()
                            {
                                Source = tripVm.Source,
                                Destination = tripVm.Destination,
                                DepatureDate = tripVm.DepatureDate,
                                ArrivalDate = tripVm.ArrivalDate,
                                Fare = tripVm.Fare,
                                DriverId = tripVm.DriverId,
                                VehicleId = tripVm.VehicleId,
                                AvailableSeats = vehicle.Category.Capacity,
                                Done = false,

                            };

                            var hour = Math.Round(((decimal)arrival.Hour - (decimal)depature.Hour));

                            //Get object from Trip 
                            Trip trip2 = new Trip()
                            {
                                Source = tripVm.Destination,
                                Destination = tripVm.Source,
                                DepatureDate = tripVm.ArrivalDate,
                                ArrivalDate = tripVm.ArrivalDate.AddHours((double)hour),
                                Fare = tripVm.Fare,
                                DriverId = tripVm.DriverId,
                                VehicleId = tripVm.VehicleId,
                                AvailableSeats = vehicle.Category.Capacity,
                                Done = false,
                            };

                            applicaitonDbContext.Trips.Add(trip1);
                            applicaitonDbContext.Trips.Add(trip2);
                            applicaitonDbContext.SaveChanges();
                            trip1.HomeAndAway = trip2.Id;
                            trip2.HomeAndAway = trip1.Id;
                            applicaitonDbContext.Trips.Update(trip1);
                            applicaitonDbContext.Trips.Update(trip2);
                            applicaitonDbContext.SaveChanges();

                        }
                        else
                        {
                            //Get object from Trip 
                            Trip trip1 = new Trip()
                            {
                                Source = tripVm.Source,
                                Destination = tripVm.Destination,
                                DepatureDate = tripVm.DepatureDate,
                                ArrivalDate = tripVm.ArrivalDate,
                                Fare = tripVm.Fare,
                                DriverId = tripVm.DriverId,
                                VehicleId = tripVm.VehicleId,
                                AvailableSeats = vehicle.Category.Capacity,
                                Done = false,

                            };
                            applicaitonDbContext.Trips.Add(trip1);
                        }


                        vehicleT.IsAvailable = false;
                        vehicleT.CurrentStation = tripVm.Destination.ToUpper();
                        driverT.IsAvailable = false;
                        driverT.CurrentStation = tripVm.Destination.ToUpper();
                        applicaitonDbContext.Drivers.Update(driverT);
                        applicaitonDbContext.Vehicles.Update(vehicleT);
                        applicaitonDbContext.SaveChanges();

                        //refresh Combobox
                        FrmTripCrud_Load(sender, e);
                        changeDriversComboBox();
                        changeVehicleComboBox();


                        //Refresh Main Table.
                        FrmTrips frmTrips = new FrmTrips();
                        LoadForm(frmTrips);

                        return;

                    }
                    catch (Exception ex)
                    {
                        FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                        frmValidationDialog.showAlert(ex.Message, FrmValidationDialog.enmType.Warning);
                    }

                    return;


                }




            }
            else
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert(validationResult.MessageError, FrmValidationDialog.enmType.Warning);
                return;
            }
        }

        private void FrmTripCrud_Load(object sender, EventArgs e)
        {

            List<Trip> trips = applicaitonDbContext.Trips.ToList();

            List<TripVm> tripsVModels = applicaitonDbContext.Trips.Select(x => new TripVm
            {
                Id = x.Id,
                TripNo = x.TripNo,
                Source = x.Source,
                Destination = x.Destination,
                DepatureDate = x.DepatureDate,
                ArrivalDate = x.ArrivalDate,
                Driver = x.Driver.Username,
                Vehicle = $"{x.Vehicle.Model}-{x.Vehicle.Brand}",
                VehicleId = x.VehicleId,
                DriverId = x.DriverId,
                VehicleNo = x.Vehicle.VehicleNo,
                Reservation = x.Reservations.Count(),
                AvailabelSeats = x.AvailableSeats,
                NumberOfSeats = x.Vehicle.Category.Capacity,
                Fare = x.Fare,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
                Done = x.Done,
                IsDeleted = x.IsDeleted


                //TODO :: time for start here

            }).ToList();

            dataGridView2.DataSource = tripsVModels;


            if(Update)
            {
                Trip updateTrip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == Id)!;
                ToggleButtonHomaAndAway.Hide();
                Fare = Convert.ToString(updateTrip.Fare);
                Depature = updateTrip.DepatureDate;
                Arrival = updateTrip.ArrivalDate;

            }



            //Set items to combobox for source.
            changeSourceComboBox();
            //Set items to combobox for Destination.
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
                CBSource.DataSource = new BindingSource(stations, null);
                CBSource.DisplayMember = "Name";
                CBSource.ValueMember = "Id";
            }
            if (Update == true)
            {
                Trip updateTrip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == Id)!;

                CBSource.SelectedIndex = applicaitonDbContext.Stations.ToList().FindIndex(x => x.Name == updateTrip.Source);

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
                CBDestination.DataSource = new BindingSource(stations, null);
                CBDestination.DisplayMember = "Name";
                CBDestination.ValueMember = "Id";
            }

            if (Update == true)
            {
                Trip updateTrip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == Id)!;

                CBDestination.SelectedIndex = applicaitonDbContext.Stations.ToList().FindIndex(x => x.Name == updateTrip.Destination);

            }
        }
        public void changeDriversComboBox()
        {
            ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

            //Set items to combobox for Driver.
            List<Driver> drivers = applicaitonDbContext.Drivers.Where(x => !x.IsDeleted && x.IsAvailable && (x.CurrentStation.ToUpper() == Source.ToUpper() || x.CurrentStation == "FREE")).ToList();
            //driver set isAvailable true when done trip

            if (Update == true)
            {
                Trip updateTrip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == Id)!;

                drivers.Insert(0, updateTrip.Driver);


                CBDriver.DataSource = new BindingSource(drivers, null);
                CBDriver.DisplayMember = "Username";
                CBDriver.ValueMember = "Id";
                CBDriver.SelectedIndex = 0;
            }
            else
            {
                CBDriver.DataSource = new BindingSource(drivers, null);
                CBDriver.DisplayMember = "Username";
                CBDriver.ValueMember = "Id";
            }
        }
        public void changeVehicleComboBox()
        {
            ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

            //Set items to combobox for vehicle.
            List<Vehicle> vehicles = applicaitonDbContext.Vehicles.Where(x => !x.IsDeleted && x.IsAvailable && (x.CurrentStation.ToUpper() == Source.ToUpper() || x.CurrentStation == "FREE")).ToList();



            if (Update == true)
            {
                Trip updateTrip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == Id)!;

                vehicles.Insert(0, updateTrip.Vehicle);


                CBVehicle.DataSource = new BindingSource(vehicles, null);
                CBVehicle.DisplayMember = "Brand";
                CBVehicle.ValueMember = "Id";
                CBVehicle.SelectedIndex = 0;

            }
            else
            {
                CBVehicle.DataSource = new BindingSource(vehicles, null);
                CBVehicle.DisplayMember = "Brand";
                CBVehicle.ValueMember = "Id";
            }
        }
        private void CreateStationBtn_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (StationModel stationModel = new StationModel())
            {
                modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Size = this.Size;
                modalBackground.BackColor = Color.Black;
                modalBackground.Opacity = 0.8d;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                stationModel.Owner = modalBackground;
                stationModel.ShowDialog();
                modalBackground.Dispose();

            }
        }

        private void CreateDriverBtn_Click(object sender, EventArgs e)
        {
            //set time interval to make it smooter            
            FrmDriverCrud frmDriverCrud = new FrmDriverCrud();
            frmDriverCrud.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CBSource_DropDown(object sender, EventArgs e)
        {
            changeSourceComboBox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CBSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeDriversComboBox();
            changeVehicleComboBox();
        }

        private void CBVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {

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
