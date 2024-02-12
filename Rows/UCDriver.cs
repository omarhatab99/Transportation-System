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

namespace TransportReservationSystem.Rows
{
    public partial class UCDriver : UserControl
    {
        public UCDriver()
        {
            InitializeComponent();
        }

        public int Id { get; set; }

        public string License
        {
            get { return LblLicense.Text; }
            set { LblLicense.Text = value; }
        }

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
        public string Salary
        {
            get { return LblSalary.Text; }
            set { LblSalary.Text = value; }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            FrmConfirmationDialog frmConfirmationDialog = new FrmConfirmationDialog();
            frmConfirmationDialog.Id = Convert.ToInt16(Id);
            frmConfirmationDialog.Collection = "DRIVER";
            frmConfirmationDialog.ShowDialog();

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ApplicaitonDbContext applicaitonDbContext = new ApplicaitonDbContext();
            Driver driver = applicaitonDbContext.Drivers.FirstOrDefault(x => x.License == Convert.ToInt64(License) && x.Email == Email);

            FrmDriverCrud frmDriverCrud = new FrmDriverCrud();
            frmDriverCrud.Id = driver.Id;
            frmDriverCrud.Username = driver.Username;
            frmDriverCrud.Email = driver.Email;
            frmDriverCrud.Password = driver.Password;
            frmDriverCrud.Phone = driver.Phone;
            frmDriverCrud.Salary = Convert.ToInt64(driver.Salary);
            frmDriverCrud.License = Convert.ToInt64(driver.License);
            frmDriverCrud.SubmitDriverForm_CreateBtn.BackColor = Color.Orange;
            frmDriverCrud.SubmitDriverForm_CreateBtn.Text = "Edit";

            frmDriverCrud.Update = true;

            frmDriverCrud.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBtn_Click(sender, e);
        }

        private void tripsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBtn_Click(sender, e);
        }
    }
}
