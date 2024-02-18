using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Core.ViewModels;
using TransportReservationSystem.Data.Context;
using TransportReservationSystem.Pages;
using TransportReservationSystem.Rows;

namespace TransportReservationSystem
{
    public partial class FrmDrivers : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

        public FrmDrivers()
        {
            InitializeComponent();
        }

        public void FrmDrivers_Load(object sender, EventArgs e)
        {

            List<Driver> driverList = applicaitonDbContext.Drivers.ToList();


            List<DriverVm> drivers = driverList.Select(x => new DriverVm
            {
                Id = x.Id,
                License = x.License,
                Username = x.Username,
                Phone = x.Phone,
                Email = x.Email,
                Salary = x.Salary,
                IsAvailable = x.IsAvailable

            }).ToList();

            FLBDrivers.Controls.Clear();

            foreach (var driver in drivers)
            {
                UCDriver uCDriver = new UCDriver();
                uCDriver.Id = (int)driver.Id!;
                uCDriver.Email = driver.Email!;
                uCDriver.License = driver.License.ToString()!;
                uCDriver.Username = driver.Username?.ToString()!;
                uCDriver.Phone = driver.Phone?.ToString()!;
                uCDriver.Salary = driver.Salary.ToString()!;
                uCDriver.Width = FLBDrivers.Width;

                Trip trip = applicaitonDbContext.Trips.FirstOrDefault(x => x.DriverId == driver.Id)!;

                if (driver.IsAvailable)
                {
                    uCDriver.tableLayoutPanel1.BackColor = Color.FromArgb(192, 255, 192);
                    uCDriver.panel1.BackColor = Color.FromArgb(192, 255, 192);
                }
                else
                {
                    uCDriver.panel1.BackColor = Color.FromArgb(224, 224, 224);
                }

                FLBDrivers.Controls.Add(uCDriver);
            }



        }



        private void FLBDrivers_SizeChanged(object sender, EventArgs e)
        {
            FLBDrivers.SuspendLayout();
            foreach (Control ctrl in FLBDrivers.Controls)
            {
                if (ctrl is UserControl) ctrl.Width = FLBDrivers.ClientSize.Width;
            }
            FLBDrivers.ResumeLayout();
        }

        private void DriverSearchInput_KeyUp(object sender, KeyEventArgs e)
        {
            string trim = DriverSearchInput.Text.Trim().ToLower();

            List<Driver> driverList = applicaitonDbContext.Drivers.ToList();

            List<DriverVm> drivers = driverList.Select(x => new DriverVm
            {
                Id = x.Id,
                License = x.License,
                Username = x.Username,
                Phone = x.Phone,
                Email = x.Email,
                Salary = x.Salary

            }).Where(x => x.Username!.ToLower().Trim().Contains(trim)).ToList();

            FLBDrivers.Controls.Clear();


            foreach (var driver in drivers)
            {
                UCDriver uCDriver = new UCDriver();
                uCDriver.Id = (int)driver.Id!;
                uCDriver.Email = driver.Email!;
                uCDriver.License = driver.License.ToString()!;
                uCDriver.Username = driver.Username?.ToString()!;
                uCDriver.Phone = driver.Phone?.ToString()!;
                uCDriver.Salary = driver.Salary.ToString()!;
                uCDriver.Width = FLBDrivers.Width;

                Trip trip = applicaitonDbContext.Trips.FirstOrDefault(x => x.DriverId == driver.Id)!;

                if (driver.IsAvailable)
                {
                    uCDriver.tableLayoutPanel1.BackColor = Color.FromArgb(192, 255, 192);
                    uCDriver.panel1.BackColor = Color.FromArgb(192, 255, 192);
                }
                else
                {
                    uCDriver.panel1.BackColor = Color.FromArgb(224, 224, 224);
                }

                FLBDrivers.Controls.Add(uCDriver);
            }
        }

        private void CreateDriverBtn_Click(object sender, EventArgs e)
        {
            //set time interval to make it smooter            
            FrmDriverCrud frmDriverCrud = new FrmDriverCrud();
            frmDriverCrud.ShowDialog();

        }
    }
}
