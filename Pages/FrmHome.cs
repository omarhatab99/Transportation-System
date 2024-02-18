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

namespace TransportReservationSystem
{
    public partial class FrmHome : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

            List<Driver> drivers = applicaitonDbContext.Drivers.ToList();
            List<Vehicle> vehicles = applicaitonDbContext.Vehicles.ToList();
            List<Analatycal> analatycals = applicaitonDbContext.Analatycals.ToList();

            DriverNumber.Text = drivers.Count().ToString();
            VehiclesNumber.Text = vehicles.Count().ToString();
            TotalGain.Text = CalcTotalGain(analatycals).ToString();


        }


        private decimal CalcTotalGain(List<Analatycal> analatycals)
        {
            decimal totalGain = 0;
            foreach (var analatyical in analatycals)
            {
                totalGain += analatyical.TotalGain;
            }

            return totalGain;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DriverNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
