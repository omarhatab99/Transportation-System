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
            UserSide = new Panel();
            UsersBtn = new Button();
            PassengerSide = new Panel();
            PassengersBtn = new Button();
            ReservationSide = new Panel();
            ReservationBtn = new Button();
            VehicleSide = new Panel();
            VehicleBtn = new Button();
            DriverSide = new Panel();
            DriversBtn = new Button();
            panel2 = new Panel();
            MenuBtn = new PictureBox();
            pictureBox3 = new PictureBox();
            Sidebar = new FlowLayoutPanel();
            DashboardSide = new Panel();
            DashboardBtn = new Button();
            TripSide = new Panel();
            TripsBtn = new Button();
            panel8 = new Panel();
            LogoutBtn = new PictureBox();
            LogoutBtnShape = new PictureBox();
            MainPanel = new Panel();
            UserSide.SuspendLayout();
            PassengerSide.SuspendLayout();
            ReservationSide.SuspendLayout();
            VehicleSide.SuspendLayout();
            DriverSide.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Sidebar.SuspendLayout();
            DashboardSide.SuspendLayout();
            TripSide.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtnShape).BeginInit();
            SuspendLayout();
            // 
            // SidebarTimer
            // 
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // UserSide
            // 
            UserSide.Controls.Add(UsersBtn);
            UserSide.Location = new Point(3, 423);
            UserSide.Name = "UserSide";
            UserSide.Size = new Size(208, 41);
            UserSide.TabIndex = 5;
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
            UsersBtn.Location = new Point(-12, -12);
            UsersBtn.Name = "UsersBtn";
            UsersBtn.Padding = new Padding(30, 0, 0, 0);
            UsersBtn.Size = new Size(227, 63);
            UsersBtn.TabIndex = 3;
            UsersBtn.Text = "                Users";
            UsersBtn.TextAlign = ContentAlignment.MiddleLeft;
            UsersBtn.UseVisualStyleBackColor = false;
            UsersBtn.Click += UsersBtn_Click;
            // 
            // PassengerSide
            // 
            PassengerSide.Controls.Add(PassengersBtn);
            PassengerSide.Location = new Point(3, 329);
            PassengerSide.Name = "PassengerSide";
            PassengerSide.Size = new Size(208, 41);
            PassengerSide.TabIndex = 4;
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
            PassengersBtn.Location = new Point(-15, -15);
            PassengersBtn.Name = "PassengersBtn";
            PassengersBtn.Padding = new Padding(30, 0, 0, 0);
            PassengersBtn.Size = new Size(240, 72);
            PassengersBtn.TabIndex = 3;
            PassengersBtn.Text = "                Passengers";
            PassengersBtn.TextAlign = ContentAlignment.MiddleLeft;
            PassengersBtn.UseVisualStyleBackColor = false;
            PassengersBtn.Click += PassengersBtn_Click;
            // 
            // ReservationSide
            // 
            ReservationSide.Controls.Add(ReservationBtn);
            ReservationSide.Location = new Point(3, 376);
            ReservationSide.Name = "ReservationSide";
            ReservationSide.Size = new Size(208, 41);
            ReservationSide.TabIndex = 5;
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
            ReservationBtn.Location = new Point(-13, -8);
            ReservationBtn.Name = "ReservationBtn";
            ReservationBtn.Padding = new Padding(30, 0, 0, 0);
            ReservationBtn.Size = new Size(240, 56);
            ReservationBtn.TabIndex = 3;
            ReservationBtn.Text = "                Reservations";
            ReservationBtn.TextAlign = ContentAlignment.MiddleLeft;
            ReservationBtn.UseVisualStyleBackColor = false;
            ReservationBtn.Click += ReservationBtn_Click;
            // 
            // VehicleSide
            // 
            VehicleSide.Controls.Add(VehicleBtn);
            VehicleSide.Location = new Point(3, 235);
            VehicleSide.Name = "VehicleSide";
            VehicleSide.Size = new Size(208, 41);
            VehicleSide.TabIndex = 5;
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
            VehicleBtn.Location = new Point(-14, -17);
            VehicleBtn.Name = "VehicleBtn";
            VehicleBtn.Padding = new Padding(30, 0, 0, 0);
            VehicleBtn.Size = new Size(240, 74);
            VehicleBtn.TabIndex = 3;
            VehicleBtn.Text = "               Vehicles";
            VehicleBtn.TextAlign = ContentAlignment.MiddleLeft;
            VehicleBtn.UseVisualStyleBackColor = false;
            VehicleBtn.Click += VehicleBtn_Click;
            // 
            // DriverSide
            // 
            DriverSide.Controls.Add(DriversBtn);
            DriverSide.Location = new Point(3, 188);
            DriverSide.Name = "DriverSide";
            DriverSide.Size = new Size(208, 41);
            DriverSide.TabIndex = 5;
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
            DriversBtn.Size = new Size(240, 70);
            DriversBtn.TabIndex = 3;
            DriversBtn.Text = "               Drivers";
            DriversBtn.TextAlign = ContentAlignment.MiddleLeft;
            DriversBtn.UseVisualStyleBackColor = false;
            DriversBtn.Click += DriversBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(MenuBtn);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 132);
            panel2.TabIndex = 6;
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
            Sidebar.Controls.Add(DashboardSide);
            Sidebar.Controls.Add(DriverSide);
            Sidebar.Controls.Add(VehicleSide);
            Sidebar.Controls.Add(TripSide);
            Sidebar.Controls.Add(PassengerSide);
            Sidebar.Controls.Add(ReservationSide);
            Sidebar.Controls.Add(UserSide);
            Sidebar.Controls.Add(panel8);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(215, 652);
            Sidebar.MinimumSize = new Size(65, 652);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(215, 652);
            Sidebar.TabIndex = 0;
            // 
            // DashboardSide
            // 
            DashboardSide.Controls.Add(DashboardBtn);
            DashboardSide.Location = new Point(3, 141);
            DashboardSide.Name = "DashboardSide";
            DashboardSide.Size = new Size(208, 41);
            DashboardSide.TabIndex = 6;
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
            DashboardBtn.Size = new Size(240, 74);
            DashboardBtn.TabIndex = 3;
            DashboardBtn.Text = "              Dashboard";
            DashboardBtn.TextAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.UseVisualStyleBackColor = false;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // TripSide
            // 
            TripSide.Controls.Add(TripsBtn);
            TripSide.Location = new Point(3, 282);
            TripSide.Name = "TripSide";
            TripSide.Size = new Size(208, 41);
            TripSide.TabIndex = 9;
            // 
            // TripsBtn
            // 
            TripsBtn.BackColor = Color.DarkViolet;
            TripsBtn.Cursor = Cursors.Hand;
            TripsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(169, 39, 176);
            TripsBtn.FlatStyle = FlatStyle.Flat;
            TripsBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TripsBtn.ForeColor = Color.White;
            TripsBtn.Image = Properties.Resources.car_journey1;
            TripsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            TripsBtn.Location = new Point(-13, -13);
            TripsBtn.Name = "TripsBtn";
            TripsBtn.Padding = new Padding(30, 0, 0, 0);
            TripsBtn.Size = new Size(228, 69);
            TripsBtn.TabIndex = 3;
            TripsBtn.Text = "               Trips";
            TripsBtn.TextAlign = ContentAlignment.MiddleLeft;
            TripsBtn.UseVisualStyleBackColor = false;
            TripsBtn.Click += TripsBtn_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(LogoutBtn);
            panel8.Controls.Add(LogoutBtnShape);
            panel8.Location = new Point(3, 470);
            panel8.Name = "panel8";
            panel8.Size = new Size(208, 173);
            panel8.TabIndex = 5;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.DarkViolet;
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.Image = Properties.Resources.sign_out_alt1;
            LogoutBtn.Location = new Point(14, 125);
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
            LogoutBtnShape.Location = new Point(-65, 105);
            LogoutBtnShape.Name = "LogoutBtnShape";
            LogoutBtnShape.Size = new Size(226, 65);
            LogoutBtnShape.SizeMode = PictureBoxSizeMode.Zoom;
            LogoutBtnShape.TabIndex = 7;
            LogoutBtnShape.TabStop = false;
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
            UserSide.ResumeLayout(false);
            PassengerSide.ResumeLayout(false);
            ReservationSide.ResumeLayout(false);
            VehicleSide.ResumeLayout(false);
            DriverSide.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MenuBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Sidebar.ResumeLayout(false);
            DashboardSide.ResumeLayout(false);
            TripSide.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtnShape).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer SidebarTimer;
        private Panel UserSide;
        private Panel PassengerSide;
        private Button PassengersBtn;
        private Panel ReservationSide;
        private Button ReservationBtn;
        private Panel VehicleSide;
        private Button VehicleBtn;
        private Panel DriverSide;
        private Button DriversBtn;
        private Panel panel2;
        private PictureBox MenuBtn;
        private PictureBox pictureBox3;
        private FlowLayoutPanel Sidebar;
        public Panel MainPanel;
        private Button UsersBtn;
        private Panel DashboardSide;
        private Button DashboardBtn;
        private Panel TripSide;
        private Button TripsBtn;
        private Panel panel8;
        private PictureBox LogoutBtn;
        private PictureBox LogoutBtnShape;
    }
}