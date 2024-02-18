using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Dialog;

namespace TransportReservationSystem.Rows
{
    public partial class UCDriverTrips : UserControl
    {
        public UCDriverTrips()
        {
            InitializeComponent();
        }

        public int DriverId { get; set; }
        public int TripId { get; set; }

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


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            FrmConfirmationDialog frmConfirmationDialog = new FrmConfirmationDialog();
            frmConfirmationDialog.Id = Convert.ToInt16(TripId);
            frmConfirmationDialog.DriverId = Convert.ToInt16(DriverId);
            frmConfirmationDialog.Collection = "DONE";
            frmConfirmationDialog.ShowDialog();
        }
    }
}
