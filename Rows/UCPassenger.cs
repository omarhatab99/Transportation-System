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
using TransportReservationSystem.Dialog;
using TransportReservationSystem.Pages;
using TransportReservationSystem.Pages.Passengers;
using TransportReservationSystem.Pages.Vehicles;

namespace TransportReservationSystem.Rows
{
    public partial class UCPassenger : UserControl
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
        public UCPassenger()
        {
            InitializeComponent();
        }

        public int Id { get; set; }


        public string Username
        {
            get { return LblUsername.Text; }
            set { LblUsername.Text = value; }
        }

        public string Email
        {
            get { return LblEmail.Text; }
            set { LblEmail.Text = value; }
        }

        public string Phone
        {
            get { return LblPhone.Text; }
            set { LblPhone.Text = value; }
        }

        public string Gender
        {
            get { return LblGender.Text; }
            set { LblGender.Text = value; }
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            Passenger passenger = applicaitonDbContext.Passengers.FirstOrDefault(x => x.Id == Id)!;

            FrmPassengerCrud frmPassengerCrud = new FrmPassengerCrud();
            frmPassengerCrud.Id = passenger.Id;
            frmPassengerCrud.Username = passenger.Username;
            frmPassengerCrud.Email = passenger.Email;
            frmPassengerCrud.Password = passenger.Password;
            frmPassengerCrud.Phone = passenger.Phone;
            frmPassengerCrud.CBGender.SelectedIndex = (passenger.Gender == "Male") ? 0 : 1;
            frmPassengerCrud.Address = passenger.Address;
            frmPassengerCrud.SubmitPassengerForm_CreateBtn.BackColor = Color.Orange;
            frmPassengerCrud.SubmitPassengerForm_CreateBtn.Text = "Edit";


            frmPassengerCrud.Update = true;

            frmPassengerCrud.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            FrmConfirmationDialog frmConfirmationDialog = new FrmConfirmationDialog();
            frmConfirmationDialog.Id = Convert.ToInt16(Id);
            frmConfirmationDialog.Collection = "PASSENGER";
            frmConfirmationDialog.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBtn_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBtn_Click(sender, e);
        }

        private void tripsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookTripToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
