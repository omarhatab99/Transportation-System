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

namespace TransportReservationSystem.Dialog
{
    public partial class FrmReservationDetails : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
        public int Id {  get; set; }
        public FrmReservationDetails()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReservationDetails_Load(object sender, EventArgs e)
        {
            GetDataFilter();
        }

        private void GetDataFilter()
        {
            var trip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == Id);
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



    }
}
