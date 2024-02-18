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
    public partial class UCPassengerReservation : UserControl
    {
        public UCPassengerReservation()
        {
            InitializeComponent();
        }

        public int PassengerId { get; set; }
        public int ReservationId { get; set; }
        public int TripNo
        {
            get { return Convert.ToInt32(LblTripNo); }
            set { LblTripNo.Text = Convert.ToString(value); }
        }

        public string PassengerName
        {
            get { return LblPassengerName.Text; }
            set { LblPassengerName.Text = value; }
        }
        public string NOOFSeat
        {
            get { return LblNoOFSeats.Text; }
            set { LblNoOFSeats.Text = value; }
        }
        public string TotalCost
        {
            get { return LblTotalCost.Text; }
            set { LblTotalCost.Text = value; }
        }
        public string Status
        {
            get { return LblStatus.Text; }
            set { LblStatus.Text = value; }
        }

        private void CancellationReservationBtn_Click(object sender, EventArgs e)
        {
            FrmConfirmationDialog frmConfirmationDialog = new FrmConfirmationDialog();
            frmConfirmationDialog.PassengerId = Convert.ToInt32(PassengerId);
            frmConfirmationDialog.Id = Convert.ToInt32(ReservationId);
            frmConfirmationDialog.Collection = "CANCELLATION";
            frmConfirmationDialog.ShowDialog();
        }
    }
}
