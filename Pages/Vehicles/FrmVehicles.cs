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
using TransportReservationSystem.Pages;
using TransportReservationSystem.Pages.Vehicles;
using TransportReservationSystem.Rows;

namespace TransportReservationSystem
{
    public partial class FrmVehicles : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();

        public int Id {  get; set; }
        public FrmVehicles()
        {
            InitializeComponent();
        }

        private void FrmVehicles_Load(object sender, EventArgs e)
        {
            List<Vehicle> vehicleList = applicaitonDbContext.Vehicles.ToList();


            List<VehicleVm> vehicles = vehicleList.Select(x => new VehicleVm
            {
                Id = x.Id,
                LicensePlate = x.LicensePlate,
                Model = x.Model,
                Brand = x.Brand,
                Category = x.Category?.Name,
                VehicleNo = x.VehicleNo,
                IsAvailable = x.IsAvailable

            }).ToList();


            FLBVehicles.Controls.Clear();

            foreach (var vehicle in vehicles)
            {
                UCVehicle uCVehicle = new UCVehicle();

                uCVehicle.Id = (int)vehicle.Id!;
                uCVehicle.LicensePlate = (long)vehicle.LicensePlate!;
                uCVehicle.Category = vehicle.Category!;
                uCVehicle.VehicleNo = vehicle.VehicleNo?.ToString()!;

                if (vehicle.Model?.Length > 14)
                {
                    uCVehicle.Model = vehicle.Model.ToString().Substring(0, 14);
                }
                else
                {
                    uCVehicle.Model = vehicle.Model!;
                }

                if (vehicle.Brand?.Length > 14)
                {
                    uCVehicle.Brand = vehicle.Brand.ToString().Substring(0, 14);

                }
                else
                {
                    uCVehicle.Brand = vehicle.Brand!;
                }


                if (vehicle.IsAvailable)
                {
                    uCVehicle.tableLayoutPanel1.BackColor = Color.FromArgb(192, 255, 192);
                    uCVehicle.panel1.BackColor = Color.FromArgb(192, 255, 192);
                }


                uCVehicle.Width = FLBVehicles.Width;
                FLBVehicles.Controls.Add(uCVehicle);
            }

        }

        private void FLBVehicles_SizeChanged(object sender, EventArgs e)
        {
            FLBVehicles.SuspendLayout();
            foreach (Control ctrl in FLBVehicles.Controls)
            {
                if (ctrl is UserControl) ctrl.Width = FLBVehicles.ClientSize.Width;
            }
            FLBVehicles.ResumeLayout();
        }

        private void VehicleSearchInput_KeyUp(object sender, KeyEventArgs e)
        {
            string trim = VehicleSearchInput.Text.ToLower().Trim().ToLower();

            List<Vehicle> vehicleList = applicaitonDbContext.Vehicles.ToList();

            List<VehicleVm> Vehicles = vehicleList.Select(x => new VehicleVm
            {

                Id = x.Id,
                LicensePlate = x.LicensePlate,
                Model = x.Model,
                Brand = x.Brand,
                Category = x.Category?.Name,
                VehicleNo = x.VehicleNo,
                IsAvailable = x.IsAvailable

            }).Where(x => x.VehicleNo.ToString()!.ToLower().Trim().Contains(trim) ||
                x.Category!.ToLower().Contains(trim) || x.Brand!.ToLower().Contains(trim) || x.Model!.ToLower().Contains(trim)).ToList();

            FLBVehicles.Controls.Clear();

            foreach (var vehicle in Vehicles)
            {
                UCVehicle uCVehicle = new UCVehicle();

                uCVehicle.Id = (int)vehicle.Id!;
                uCVehicle.LicensePlate = (long)vehicle.LicensePlate!;
                uCVehicle.Category = vehicle.Category!;
                uCVehicle.VehicleNo = vehicle.VehicleNo?.ToString()!;

                if (vehicle.Model?.Length > 14)
                {
                    uCVehicle.Model = vehicle.Model.ToString().Substring(0, 14);
                }
                else
                {
                    uCVehicle.Model = vehicle.Model!;
                }

                if (vehicle.Brand?.Length > 14)
                {
                    uCVehicle.Brand = vehicle.Brand.ToString().Substring(0, 14);

                }
                else
                {
                    uCVehicle.Brand = vehicle.Brand!;
                }

                if (vehicle.IsAvailable)
                {
                    uCVehicle.tableLayoutPanel1.BackColor = Color.FromArgb(192, 255, 192);
                    uCVehicle.panel1.BackColor = Color.FromArgb(192, 255, 192);
                }


                uCVehicle.Width = FLBVehicles.Width;
                FLBVehicles.Controls.Add(uCVehicle);
            }
        }

        private void CreateVehicleBtn_Click(object sender, EventArgs e)
        {
            //set time interval to make it smooter            
            FrmVehicleCrud frmVehicleCrud = new FrmVehicleCrud();
            frmVehicleCrud.ShowDialog();
        }
    }
}
