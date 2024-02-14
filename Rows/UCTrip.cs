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
using TransportReservationSystem.Pages.Passengers;
using TransportReservationSystem.Pages.Trips;

namespace TransportReservationSystem.Rows
{
    public partial class UCTrip : UserControl
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
        public UCTrip()
        {
            InitializeComponent();
        }

        public int Id { get; set; }

        public int TripNo
        {
            get { return Convert.ToInt32(LblTripNo); }
            set { LblTripNo.Text = Convert.ToString(value); }
        }

        public string Source
        {
            get { return LblSource.Text; }
            set { LblSource.Text = value; }
        }
        public string Destination
        {
            get { return LblDestination.Text; }
            set { LblDestination.Text = value; }
        }
        public DateTime Depature
        {
            get { return Convert.ToDateTime(LblDepature.Text); }
            set { LblDepature.Text = Convert.ToString(value); }
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            Trip trip = applicaitonDbContext.Trips.FirstOrDefault(x => x.Id == Id)!;

            DateTime date1 = DateTime.Parse(trip.DepatureDate.ToString());
            DateTime date2 = DateTime.Now;

            if (trip.Done)
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Trip is Done", FrmValidationDialog.enmType.Warning);
                return;
            }
            else if (date2 > date1)
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Trip is Already Started..!!", FrmValidationDialog.enmType.Warning);
                return;
            }
            else if (trip.Reservations.Count > 0)
            {
                FrmValidationDialog frmValidationDialog = new FrmValidationDialog();
                frmValidationDialog.showAlert("Cant Edit Trip Has Reservation..!!", FrmValidationDialog.enmType.Warning);
                return;
            }
            else
            {
                FrmTripCrud frmTripCrud = new FrmTripCrud();
                frmTripCrud.Id = trip.Id;
                frmTripCrud.SubmitTripForm_CreateBtn.BackColor = Color.Orange;
                frmTripCrud.SubmitTripForm_CreateBtn.Text = "Edit";

                frmTripCrud.Update = true;
                frmTripCrud.ShowDialog();

            }







        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            FrmConfirmationDialog frmConfirmationDialog = new FrmConfirmationDialog();
            frmConfirmationDialog.Id = Convert.ToInt32(Id);
            frmConfirmationDialog.Collection = "TRIP";
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

        private void resservationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void passengersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
