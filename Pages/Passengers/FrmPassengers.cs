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
using TransportReservationSystem.Rows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TransportReservationSystem.Pages.Passengers
{
    public partial class FrmPassengers : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();


        public FrmPassengers()
        {
            InitializeComponent();
        }

        private void FrmPassengers_Load(object sender, EventArgs e)
        {
            List<Passenger> passengerList = applicaitonDbContext.Passengers.ToList();


            List<PassengerVm> passengers = passengerList.Select(x => new PassengerVm
            {
                Id = x.Id,
                Username = x.Username,
                Email = x.Email,
                Phone = x.Phone,
                Gender = x.Gender,
                Address = x.Address,
                Role = x.Role,

            }).ToList();


            FLBPassengers.Controls.Clear();

            foreach (var passenger in passengers)
            {
                UCPassenger uCPassenger = new UCPassenger();

                uCPassenger.Id = (int)passenger.Id;
                uCPassenger.Username = passenger.Username;
                uCPassenger.Email = passenger.Email;
                uCPassenger.Phone = passenger.Phone;
                uCPassenger.Gender = passenger.Gender;

                uCPassenger.Width = FLBPassengers.Width;
                FLBPassengers.Controls.Add(uCPassenger);
            }
        }


        private void FrmPassengers_SizeChanged(object sender, EventArgs e)
        {
            FLBPassengers.SuspendLayout();
            foreach (Control ctrl in FLBPassengers.Controls)
            {
                if (ctrl is UserControl) ctrl.Width = FLBPassengers.ClientSize.Width;
            }
            FLBPassengers.ResumeLayout();
        }

        private void CreatePassengerBtn_Click(object sender, EventArgs e)
        {

            FrmPassengerCrud frmPassengerCrud = new FrmPassengerCrud();

            frmPassengerCrud.ShowDialog();

        }

        private void PassengerSearchInput_KeyUp(object sender, KeyEventArgs e)
        {
            string trim = PassengerSearchInput.Text.ToLower().Trim().ToLower();

            List<Passenger> passengerList = applicaitonDbContext.Passengers.Where(x => !x.IsDeleted).ToList();

            List<PassengerVm> passengers = passengerList.Select(x => new PassengerVm
            {

                Id = x.Id,
                Username = x.Username,
                Email = x.Email,
                Phone = x.Phone,
                Gender = x.Gender,
                Address = x.Address,
                Role = x.Role,

            }).Where(x => x.Username.ToString().ToLower().Trim().Contains(trim) ||
                x.Email.ToLower().Contains(trim) || x.Phone.Contains(trim)).ToList();

            FLBPassengers.Controls.Clear();

            foreach (var passenger in passengers)
            {
                UCPassenger uCPassenger = new UCPassenger();

                uCPassenger.Id = (int)passenger.Id;
                uCPassenger.Username = passenger.Username;
                uCPassenger.Email = passenger.Email;
                uCPassenger.Phone = passenger.Phone;
                uCPassenger.Gender = passenger.Gender;

                uCPassenger.Width = FLBPassengers.Width;
                FLBPassengers.Controls.Add(uCPassenger);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
