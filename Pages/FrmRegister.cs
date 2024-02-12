using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportReservationSystem.Pages
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(OpenLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void OpenLogin()
        {
            Application.Run(new FrmLogin());
        }
    }
}
