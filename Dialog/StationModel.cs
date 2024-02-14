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
using TransportReservationSystem.Pages.Trips;

namespace TransportReservationSystem.Dialog
{
    public partial class StationModel : Form
    {
        ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
        public StationModel()
        {
            InitializeComponent();
        }

        public string StationName {
            get { return StationNameTBOX.Text; }
            set { StationNameTBOX.Text = value; }
        }

        private void ModalTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                ModalTimer.Stop();
            }
            else
            {
                Opacity += 0.03;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitStationForm_CreateBtn_Click(object sender, EventArgs e)
        {
            string stationName = StationName;

            FrmValidationDialog frmValidationDialog = new FrmValidationDialog();

            if (string.IsNullOrEmpty(stationName))
            {
                frmValidationDialog.showAlert("Please enter a station name.", FrmValidationDialog.enmType.Warning);
                return;
            }
            else //valid
            {
                if (applicaitonDbContext.Stations.Any(x => x.Name.Trim().ToLower() == stationName.Trim().ToLower() && !x.IsDeleted))
                {
                    frmValidationDialog.showAlert("This station already exists.", FrmValidationDialog.enmType.Warning);
                    return;
                }
                else
                {
                    Station station = new Station
                    {
                        Name = stationName,
                    };

                    applicaitonDbContext.Stations.Add(station);
                    applicaitonDbContext.SaveChanges();
                    this.Close();

                }

            }
        }
    }
}
