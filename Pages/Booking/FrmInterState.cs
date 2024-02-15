using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportReservationSystem.Pages.Booking
{
    public partial class FrmInterState : Form
    {
        public int PassengerId { get; set; }
        public int TripId { get; set; }
        public FrmInterState()
        {
            InitializeComponent();
        }

        private void rjButton10_Click(object sender, EventArgs e)
        {

        }

        private bool s1 = false;
        private void S1_Click(object sender, EventArgs e)
        {
            s1 = !s1;
            if (s1) //Reserved
            {
                S1.BackColor = Color.DarkRed;
            }
            else //Free
            {
                S1.BackColor = Color.Green;
            }

        }

        private bool s2 = false;
        private void S2_Click(object sender, EventArgs e)
        {
            s2 = !s2;
            if (s2) //Reserved
            {
                S2.BackColor = Color.DarkRed;
            }
            else //Free
            {
                S2.BackColor = Color.Green;
            }

        }
    }
}
