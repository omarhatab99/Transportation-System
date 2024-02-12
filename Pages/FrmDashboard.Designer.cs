namespace TransportReservationSystem
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            panel8 = new Panel();
            LogoutBtn = new PictureBox();
            LogoutBtnShape = new PictureBox();
            panel9 = new Panel();
            UsersBtn = new Button();
            panel3 = new Panel();
            PassengersBtn = new Button();
            panel7 = new Panel();
            ReservationBtn = new Button();
            panel6 = new Panel();
            VehicleBtn = new Button();
            panel5 = new Panel();
            DriversBtn = new Button();
            panel4 = new Panel();
            DashboardBtn = new Button();
            panel2 = new Panel();
            MenuBtn = new PictureBox();
            pictureBox3 = new PictureBox();
            Sidebar = new FlowLayoutPanel();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            MainPanel = new Panel();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtnShape).BeginInit();
            panel9.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // SidebarTimer
            // 
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // panel8
            // 
            panel8.Controls.Add(LogoutBtn);
            panel8.Controls.Add(LogoutBtnShape);
            panel8.Location = new Point(3, 423);
            panel8.Name = "panel8";
            panel8.Size = new Size(208, 229);
            panel8.TabIndex = 5;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.DarkViolet;
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.Image = Properties.Resources.sign_out_alt1;
            LogoutBtn.Location = new Point(9, 169);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(54, 26);
            LogoutBtn.SizeMode = PictureBoxSizeMode.Zoom;
            LogoutBtn.TabIndex = 5;
            LogoutBtn.TabStop = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // LogoutBtnShape
            // 
            LogoutBtnShape.Image = Properties.Resources.shape_menu;
            LogoutBtnShape.Location = new Point(-65, 152);
            LogoutBtnShape.Name = "LogoutBtnShape";
            LogoutBtnShape.Size = new Size(226, 65);
            LogoutBtnShape.SizeMode = PictureBoxSizeMode.Zoom;
            LogoutBtnShape.TabIndex = 7;
            LogoutBtnShape.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(UsersBtn);
            panel9.Location = new Point(3, 376);
            panel9.Name = "panel9";
            panel9.Size = new Size(208, 41);
            panel9.TabIndex = 5;
            // 
            // UsersBtn
            // 
            UsersBtn.BackColor = Color.DarkViolet;
            UsersBtn.Cursor = Cursors.Hand;
            UsersBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 39, 176);
            UsersBtn.FlatStyle = FlatStyle.Flat;
            UsersBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsersBtn.ForeColor = Color.White;
            UsersBtn.Image = Properties.Resources.user_gear;
            UsersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            UsersBtn.Location = new Point(-16, -18);
            UsersBtn.Name = "UsersBtn";
            UsersBtn.Padding = new Padding(30, 0, 0, 0);
            UsersBtn.Size = new Size(240, 72);
            UsersBtn.TabIndex = 3;
            UsersBtn.Text = "                Users";
            UsersBtn.TextAlign = ContentAlignment.MiddleLeft;
            UsersBtn.UseVisualStyleBackColor = false;
            UsersBtn.Click += UsersBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(PassengersBtn);
            panel3.Location = new Point(3, 329);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 41);
            panel3.TabIndex = 4;
            // 
            // PassengersBtn
            // 
            PassengersBtn.BackColor = Color.DarkViolet;
            PassengersBtn.Cursor = Cursors.Hand;
            PassengersBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 39, 176);
            PassengersBtn.FlatStyle = FlatStyle.Flat;
            PassengersBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PassengersBtn.ForeColor = Color.White;
            PassengersBtn.Image = Properties.Resources.user;
            PassengersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            PassengersBtn.Location = new Point(-16, -17);
            PassengersBtn.Name = "PassengersBtn";
            PassengersBtn.Padding = new Padding(30, 0, 0, 0);
            PassengersBtn.Size = new Size(240, 72);
            PassengersBtn.TabIndex = 3;
            PassengersBtn.Text = "                Passengers";
            PassengersBtn.TextAlign = ContentAlignment.MiddleLeft;
            PassengersBtn.UseVisualStyleBackColor = false;
            PassengersBtn.Click += PassengersBtn_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(ReservationBtn);
            panel7.Location = new Point(3, 282);
            panel7.Name = "panel7";
            panel7.Size = new Size(208, 41);
            panel7.TabIndex = 5;
            // 
            // ReservationBtn
            // 
            ReservationBtn.BackColor = Color.DarkViolet;
            ReservationBtn.Cursor = Cursors.Hand;
            ReservationBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 39, 176);
            ReservationBtn.FlatStyle = FlatStyle.Flat;
            ReservationBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReservationBtn.ForeColor = Color.White;
            ReservationBtn.Image = Properties.Resources.ticket;
            ReservationBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ReservationBtn.Location = new Point(-16, -17);
            ReservationBtn.Name = "ReservationBtn";
            ReservationBtn.Padding = new Padding(30, 0, 0, 0);
            ReservationBtn.Size = new Size(240, 72);
            ReservationBtn.TabIndex = 3;
            ReservationBtn.Text = "                Reservations";
            ReservationBtn.TextAlign = ContentAlignment.MiddleLeft;
            ReservationBtn.UseVisualStyleBackColor = false;
            ReservationBtn.Click += ReservationBtn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(VehicleBtn);
            panel6.Location = new Point(3, 235);
            panel6.Name = "panel6";
            panel6.Size = new Size(208, 41);
            panel6.TabIndex = 5;
            // 
            // VehicleBtn
            // 
            VehicleBtn.BackColor = Color.DarkViolet;
            VehicleBtn.Cursor = Cursors.Hand;
            VehicleBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 39, 176);
            VehicleBtn.FlatStyle = FlatStyle.Flat;
            VehicleBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VehicleBtn.ForeColor = Color.White;
            VehicleBtn.Image = Properties.Resources.bus;
            VehicleBtn.ImageAlign = ContentAlignment.MiddleLeft;
            VehicleBtn.Location = new Point(-16, -17);
            VehicleBtn.Name = "VehicleBtn";
            VehicleBtn.Padding = new Padding(30, 0, 0, 0);
            VehicleBtn.Size = new Size(240, 72);
            VehicleBtn.TabIndex = 3;
            VehicleBtn.Text = "               Vehicles";
            VehicleBtn.TextAlign = ContentAlignment.MiddleLeft;
            VehicleBtn.UseVisualStyleBackColor = false;
            VehicleBtn.Click += VehicleBtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(DriversBtn);
            panel5.Location = new Point(3, 188);
            panel5.Name = "panel5";
            panel5.Size = new Size(208, 41);
            panel5.TabIndex = 5;
            // 
            // DriversBtn
            // 
            DriversBtn.BackColor = Color.DarkViolet;
            DriversBtn.Cursor = Cursors.Hand;
            DriversBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 39, 176);
            DriversBtn.FlatStyle = FlatStyle.Flat;
            DriversBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DriversBtn.ForeColor = Color.White;
            DriversBtn.Image = Properties.Resources.driver_man;
            DriversBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DriversBtn.Location = new Point(-16, -17);
            DriversBtn.Name = "DriversBtn";
            DriversBtn.Padding = new Padding(30, 0, 0, 0);
            DriversBtn.Size = new Size(240, 72);
            DriversBtn.TabIndex = 3;
            DriversBtn.Text = "               Drivers";
            DriversBtn.TextAlign = ContentAlignment.MiddleLeft;
            DriversBtn.UseVisualStyleBackColor = false;
            DriversBtn.Click += DriversBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(DashboardBtn);
            panel4.Location = new Point(3, 141);
            panel4.Name = "panel4";
            panel4.Size = new Size(208, 41);
            panel4.TabIndex = 6;
            // 
            // DashboardBtn
            // 
            DashboardBtn.BackColor = Color.DarkViolet;
            DashboardBtn.Cursor = Cursors.Hand;
            DashboardBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 39, 176);
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardBtn.ForeColor = Color.White;
            DashboardBtn.Image = Properties.Resources.home_icon1;
            DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.Location = new Point(-14, -18);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Padding = new Padding(30, 0, 0, 0);
            DashboardBtn.Size = new Size(240, 72);
            DashboardBtn.TabIndex = 3;
            DashboardBtn.Text = "              Dashboard";
            DashboardBtn.TextAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.UseVisualStyleBackColor = false;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(MenuBtn);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 132);
            panel2.TabIndex = 6;
            panel2.Click += panel2_Click;
            // 
            // MenuBtn
            // 
            MenuBtn.BackColor = Color.DarkViolet;
            MenuBtn.Cursor = Cursors.Hand;
            MenuBtn.Image = Properties.Resources.apps1;
            MenuBtn.Location = new Point(3, 20);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(60, 26);
            MenuBtn.SizeMode = PictureBoxSizeMode.Zoom;
            MenuBtn.TabIndex = 5;
            MenuBtn.TabStop = false;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.shape_menu;
            pictureBox3.Location = new Point(-65, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(226, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.FromArgb(3, 6, 55);
            Sidebar.Controls.Add(panel2);
            Sidebar.Controls.Add(panel4);
            Sidebar.Controls.Add(panel5);
            Sidebar.Controls.Add(panel6);
            Sidebar.Controls.Add(panel7);
            Sidebar.Controls.Add(panel3);
            Sidebar.Controls.Add(panel9);
            Sidebar.Controls.Add(panel8);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(215, 652);
            Sidebar.MinimumSize = new Size(65, 652);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(215, 652);
            Sidebar.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(215, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(978, 652);
            MainPanel.TabIndex = 1;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1193, 652);
            Controls.Add(MainPanel);
            Controls.Add(Sidebar);
            IsMdiContainer = true;
            MaximumSize = new Size(1209, 691);
            MinimumSize = new Size(230, 691);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDashboard";
            Load += FrmDashboard_Load;
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtnShape).EndInit();
            panel9.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MenuBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer SidebarTimer;
        private Panel panel8;
        private PictureBox LogoutBtn;
        private PictureBox LogoutBtnShape;
        private Panel panel9;
        private Button UsersBtn;
        private Panel panel3;
        private Button PassengersBtn;
        private Panel panel7;
        private Button ReservationBtn;
        private Panel panel6;
        private Button VehicleBtn;
        private Panel panel5;
        private Button DriversBtn;
        private Panel panel4;
        private Button DashboardBtn;
        private Panel panel2;
        private PictureBox MenuBtn;
        private PictureBox pictureBox3;
        private FlowLayoutPanel Sidebar;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        public Panel MainPanel;
    }
}