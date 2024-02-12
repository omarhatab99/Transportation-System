using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportReservationSystem.Pages;
using TransportReservationSystem.Properties;

namespace TransportReservationSystem.Dialog
{
    public partial class FrmValidationDialog : Form
    {
        public FrmValidationDialog()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private FrmValidationDialog.enmAction action;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int x, y;


        public void showAlert(string msg, enmType type)
        {
            this.StartPosition = FormStartPosition.CenterParent;

            switch (type)
            {
                case enmType.Success:
                    this.pictureBox2.Image = Resources.success;
                    this.BackColor = Color.FromArgb(192, 255, 192);
                    this.OkBtn.BackColor = Color.DarkGreen;
                    this.LblMsg.ForeColor = Color.Green;
                    break;
                case enmType.Error:
                    this.pictureBox2.Image = Resources.error;
                    this.BackColor = Color.FromArgb(255, 220, 220);
                    this.OkBtn.BackColor = Color.Red;
                    this.LblMsg.ForeColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pictureBox2.Image = Resources.info;
                    break;
                case enmType.Warning:
                    this.pictureBox2.Image = Resources.warning;
                    this.BackColor = Color.FromArgb(255, 255, 192);
                    this.OkBtn.BackColor = Color.Orange;
                    this.LblMsg.ForeColor = Color.Black;
                    break;
            }


            this.LblMsg.Text = msg;
            this.ShowDialog();

        }
    }
}
