﻿namespace TransportReservationSystem.Pages.Booking
{
    partial class FrmPassengerBooking
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
            panel10 = new Panel();
            CBTrip = new ComboBox();
            pictureBox4 = new PictureBox();
            CBPassenger = new ComboBox();
            label18 = new Label();
            label19 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label16 = new Label();
            VehicleBrandInput = new TextBox();
            VehicleModel = new TextBox();
            VehicleNumberInput = new TextBox();
            DriverLicenseInput = new TextBox();
            DriverPhoneInput = new TextBox();
            FareInput = new TextBox();
            DestinationInput = new TextBox();
            SourceInput = new TextBox();
            DriverNameInput = new TextBox();
            ArrivalInput = new TextBox();
            DepatureInput = new TextBox();
            TripNumberInput = new TextBox();
            panel1 = new Panel();
            SeatsBtn = new CustomControls.RJControls.RJButton();
            ReserveBtn = new CustomControls.RJControls.RJButton();
            ConfirmSeatsBtn = new CustomControls.RJControls.RJButton();
            ConfirmReservationBtn = new CustomControls.RJControls.RJButton();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            label1 = new Label();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(224, 224, 224);
            panel10.Controls.Add(CBTrip);
            panel10.Controls.Add(pictureBox4);
            panel10.Controls.Add(CBPassenger);
            panel10.Controls.Add(label18);
            panel10.Controls.Add(label19);
            panel10.Controls.Add(pictureBox1);
            panel10.Controls.Add(textBox1);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(944, 89);
            panel10.TabIndex = 42;
            // 
            // CBTrip
            // 
            CBTrip.FlatStyle = FlatStyle.Flat;
            CBTrip.FormattingEnabled = true;
            CBTrip.Location = new Point(242, 37);
            CBTrip.Name = "CBTrip";
            CBTrip.Size = new Size(185, 23);
            CBTrip.TabIndex = 14;
            CBTrip.SelectedIndexChanged += CBTrip_SelectedIndexChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.General2;
            pictureBox4.Location = new Point(233, 20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(208, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            // 
            // CBPassenger
            // 
            CBPassenger.FlatStyle = FlatStyle.Flat;
            CBPassenger.FormattingEnabled = true;
            CBPassenger.Location = new Point(24, 37);
            CBPassenger.Name = "CBPassenger";
            CBPassenger.Size = new Size(185, 23);
            CBPassenger.TabIndex = 13;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.DimGray;
            label18.Location = new Point(236, 4);
            label18.Name = "label18";
            label18.Size = new Size(129, 15);
            label18.TabIndex = 29;
            label18.Text = "Select Trip For Booking";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.DimGray;
            label19.Location = new Point(14, 4);
            label19.Name = "label19";
            label19.Size = new Size(95, 15);
            label19.TabIndex = 28;
            label19.Text = "Select Passenger";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.General2;
            pictureBox1.Location = new Point(15, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(24, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 36);
            textBox1.TabIndex = 37;
            textBox1.UseWaitCursor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(12, 104);
            label16.Name = "label16";
            label16.Size = new Size(281, 40);
            label16.TabIndex = 43;
            label16.Text = "Reservation Details";
            label16.Click += label16_Click;
            // 
            // VehicleBrandInput
            // 
            VehicleBrandInput.BackColor = Color.FromArgb(224, 224, 224);
            VehicleBrandInput.BorderStyle = BorderStyle.None;
            VehicleBrandInput.Enabled = false;
            VehicleBrandInput.Location = new Point(665, 451);
            VehicleBrandInput.Name = "VehicleBrandInput";
            VehicleBrandInput.Size = new Size(198, 16);
            VehicleBrandInput.TabIndex = 72;
            // 
            // VehicleModel
            // 
            VehicleModel.BackColor = Color.FromArgb(224, 224, 224);
            VehicleModel.BorderStyle = BorderStyle.None;
            VehicleModel.Enabled = false;
            VehicleModel.Location = new Point(373, 451);
            VehicleModel.Name = "VehicleModel";
            VehicleModel.Size = new Size(198, 16);
            VehicleModel.TabIndex = 69;
            // 
            // VehicleNumberInput
            // 
            VehicleNumberInput.BackColor = Color.FromArgb(224, 224, 224);
            VehicleNumberInput.BorderStyle = BorderStyle.None;
            VehicleNumberInput.Enabled = false;
            VehicleNumberInput.Location = new Point(68, 451);
            VehicleNumberInput.Name = "VehicleNumberInput";
            VehicleNumberInput.Size = new Size(198, 16);
            VehicleNumberInput.TabIndex = 67;
            // 
            // DriverLicenseInput
            // 
            DriverLicenseInput.BackColor = Color.FromArgb(224, 224, 224);
            DriverLicenseInput.BorderStyle = BorderStyle.None;
            DriverLicenseInput.Enabled = false;
            DriverLicenseInput.Location = new Point(665, 369);
            DriverLicenseInput.Name = "DriverLicenseInput";
            DriverLicenseInput.Size = new Size(198, 16);
            DriverLicenseInput.TabIndex = 65;
            // 
            // DriverPhoneInput
            // 
            DriverPhoneInput.BackColor = Color.FromArgb(224, 224, 224);
            DriverPhoneInput.BorderStyle = BorderStyle.None;
            DriverPhoneInput.Enabled = false;
            DriverPhoneInput.Location = new Point(369, 369);
            DriverPhoneInput.Name = "DriverPhoneInput";
            DriverPhoneInput.Size = new Size(198, 16);
            DriverPhoneInput.TabIndex = 64;
            // 
            // FareInput
            // 
            FareInput.BackColor = Color.FromArgb(224, 224, 224);
            FareInput.BorderStyle = BorderStyle.None;
            FareInput.Enabled = false;
            FareInput.Location = new Point(665, 289);
            FareInput.Name = "FareInput";
            FareInput.Size = new Size(198, 16);
            FareInput.TabIndex = 61;
            // 
            // DestinationInput
            // 
            DestinationInput.BackColor = Color.FromArgb(224, 224, 224);
            DestinationInput.BorderStyle = BorderStyle.None;
            DestinationInput.Enabled = false;
            DestinationInput.Location = new Point(370, 289);
            DestinationInput.Name = "DestinationInput";
            DestinationInput.Size = new Size(198, 16);
            DestinationInput.TabIndex = 60;
            // 
            // SourceInput
            // 
            SourceInput.BackColor = Color.FromArgb(224, 224, 224);
            SourceInput.BorderStyle = BorderStyle.None;
            SourceInput.Enabled = false;
            SourceInput.Location = new Point(68, 289);
            SourceInput.Name = "SourceInput";
            SourceInput.Size = new Size(198, 16);
            SourceInput.TabIndex = 59;
            // 
            // DriverNameInput
            // 
            DriverNameInput.BackColor = Color.FromArgb(224, 224, 224);
            DriverNameInput.BorderStyle = BorderStyle.None;
            DriverNameInput.Enabled = false;
            DriverNameInput.Location = new Point(68, 369);
            DriverNameInput.Name = "DriverNameInput";
            DriverNameInput.Size = new Size(198, 16);
            DriverNameInput.TabIndex = 62;
            // 
            // ArrivalInput
            // 
            ArrivalInput.BackColor = Color.FromArgb(224, 224, 224);
            ArrivalInput.BorderStyle = BorderStyle.None;
            ArrivalInput.Enabled = false;
            ArrivalInput.Location = new Point(665, 207);
            ArrivalInput.Name = "ArrivalInput";
            ArrivalInput.Size = new Size(198, 16);
            ArrivalInput.TabIndex = 58;
            // 
            // DepatureInput
            // 
            DepatureInput.BackColor = Color.FromArgb(224, 224, 224);
            DepatureInput.BorderStyle = BorderStyle.None;
            DepatureInput.Enabled = false;
            DepatureInput.Location = new Point(373, 207);
            DepatureInput.Name = "DepatureInput";
            DepatureInput.Size = new Size(198, 16);
            DepatureInput.TabIndex = 57;
            // 
            // TripNumberInput
            // 
            TripNumberInput.BackColor = Color.FromArgb(224, 224, 224);
            TripNumberInput.BorderStyle = BorderStyle.None;
            TripNumberInput.Enabled = false;
            TripNumberInput.Location = new Point(68, 206);
            TripNumberInput.Name = "TripNumberInput";
            TripNumberInput.Size = new Size(198, 16);
            TripNumberInput.TabIndex = 56;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(SeatsBtn);
            panel1.Controls.Add(ReserveBtn);
            panel1.Controls.Add(ConfirmSeatsBtn);
            panel1.Controls.Add(ConfirmReservationBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 503);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 71);
            panel1.TabIndex = 93;
            // 
            // SeatsBtn
            // 
            SeatsBtn.Anchor = AnchorStyles.Right;
            SeatsBtn.BackColor = Color.DarkSlateGray;
            SeatsBtn.BackgroundColor = Color.DarkSlateGray;
            SeatsBtn.BorderColor = Color.PaleVioletRed;
            SeatsBtn.BorderRadius = 5;
            SeatsBtn.BorderSize = 0;
            SeatsBtn.Cursor = Cursors.Hand;
            SeatsBtn.FlatAppearance.BorderSize = 0;
            SeatsBtn.FlatStyle = FlatStyle.Flat;
            SeatsBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SeatsBtn.ForeColor = Color.White;
            SeatsBtn.Image = Properties.Resources.seat_airline__1_;
            SeatsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SeatsBtn.Location = new Point(475, 22);
            SeatsBtn.Name = "SeatsBtn";
            SeatsBtn.Padding = new Padding(15, 0, 0, 0);
            SeatsBtn.Size = new Size(218, 37);
            SeatsBtn.TabIndex = 10;
            SeatsBtn.Text = "Seats";
            SeatsBtn.TextColor = Color.White;
            SeatsBtn.UseVisualStyleBackColor = false;
            SeatsBtn.Click += ConfirmSeatsBtn_Click;
            // 
            // ReserveBtn
            // 
            ReserveBtn.Anchor = AnchorStyles.Right;
            ReserveBtn.BackColor = Color.DarkOrchid;
            ReserveBtn.BackgroundColor = Color.DarkOrchid;
            ReserveBtn.BorderColor = Color.PaleVioletRed;
            ReserveBtn.BorderRadius = 5;
            ReserveBtn.BorderSize = 0;
            ReserveBtn.Cursor = Cursors.Hand;
            ReserveBtn.FlatAppearance.BorderSize = 0;
            ReserveBtn.FlatStyle = FlatStyle.Flat;
            ReserveBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReserveBtn.ForeColor = Color.White;
            ReserveBtn.Location = new Point(699, 22);
            ReserveBtn.Name = "ReserveBtn";
            ReserveBtn.Size = new Size(218, 37);
            ReserveBtn.TabIndex = 9;
            ReserveBtn.Text = "Confirm Reservation";
            ReserveBtn.TextColor = Color.White;
            ReserveBtn.UseVisualStyleBackColor = false;
            ReserveBtn.Click += ConfirmReservationBtn_Click;
            // 
            // ConfirmSeatsBtn
            // 
            ConfirmSeatsBtn.Anchor = AnchorStyles.Right;
            ConfirmSeatsBtn.BackColor = Color.DarkSlateGray;
            ConfirmSeatsBtn.BackgroundColor = Color.DarkSlateGray;
            ConfirmSeatsBtn.BorderColor = Color.PaleVioletRed;
            ConfirmSeatsBtn.BorderRadius = 5;
            ConfirmSeatsBtn.BorderSize = 0;
            ConfirmSeatsBtn.Cursor = Cursors.Hand;
            ConfirmSeatsBtn.FlatAppearance.BorderSize = 0;
            ConfirmSeatsBtn.FlatStyle = FlatStyle.Flat;
            ConfirmSeatsBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmSeatsBtn.ForeColor = Color.White;
            ConfirmSeatsBtn.Image = Properties.Resources.seat_airline__1_;
            ConfirmSeatsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ConfirmSeatsBtn.Location = new Point(1180, 7);
            ConfirmSeatsBtn.Name = "ConfirmSeatsBtn";
            ConfirmSeatsBtn.Padding = new Padding(15, 0, 0, 0);
            ConfirmSeatsBtn.Size = new Size(218, 37);
            ConfirmSeatsBtn.TabIndex = 8;
            ConfirmSeatsBtn.Text = "Seats";
            ConfirmSeatsBtn.TextColor = Color.White;
            ConfirmSeatsBtn.UseVisualStyleBackColor = false;
            // 
            // ConfirmReservationBtn
            // 
            ConfirmReservationBtn.Anchor = AnchorStyles.Right;
            ConfirmReservationBtn.BackColor = Color.DarkOrchid;
            ConfirmReservationBtn.BackgroundColor = Color.DarkOrchid;
            ConfirmReservationBtn.BorderColor = Color.PaleVioletRed;
            ConfirmReservationBtn.BorderRadius = 5;
            ConfirmReservationBtn.BorderSize = 0;
            ConfirmReservationBtn.Cursor = Cursors.Hand;
            ConfirmReservationBtn.FlatAppearance.BorderSize = 0;
            ConfirmReservationBtn.FlatStyle = FlatStyle.Flat;
            ConfirmReservationBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmReservationBtn.ForeColor = Color.White;
            ConfirmReservationBtn.Location = new Point(1404, 7);
            ConfirmReservationBtn.Name = "ConfirmReservationBtn";
            ConfirmReservationBtn.Size = new Size(218, 37);
            ConfirmReservationBtn.TabIndex = 7;
            ConfirmReservationBtn.Text = "Confirm Reservation";
            ConfirmReservationBtn.TextColor = Color.White;
            ConfirmReservationBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.ReserveInput;
            pictureBox12.Location = new Point(651, 428);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(232, 57);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 92;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.ReserveInput;
            pictureBox13.Location = new Point(355, 428);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(232, 57);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 91;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.ReserveInput;
            pictureBox14.Location = new Point(51, 428);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(232, 57);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 90;
            pictureBox14.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(654, 326);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 89;
            label1.Text = "Driver License";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.ReserveInput;
            pictureBox11.Location = new Point(651, 346);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(232, 57);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 88;
            pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.ReserveInput;
            pictureBox10.Location = new Point(355, 346);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(232, 57);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 87;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.ReserveInput;
            pictureBox9.Location = new Point(51, 346);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(232, 57);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 86;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.ReserveInput;
            pictureBox8.Location = new Point(651, 266);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(232, 57);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 85;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.ReserveInput;
            pictureBox7.Location = new Point(355, 266);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(232, 57);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 84;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.ReserveInput;
            pictureBox6.Location = new Point(52, 266);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(232, 57);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 83;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.ReserveInput;
            pictureBox5.Location = new Point(355, 185);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(232, 57);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 82;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ReserveInput;
            pictureBox3.Location = new Point(651, 185);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(232, 57);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 81;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ReserveInput;
            pictureBox2.Location = new Point(51, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 80;
            pictureBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(654, 408);
            label11.Name = "label11";
            label11.Size = new Size(89, 17);
            label11.TabIndex = 79;
            label11.Text = "Vehicle Brand";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(358, 408);
            label12.Name = "label12";
            label12.Size = new Size(91, 17);
            label12.TabIndex = 78;
            label12.Text = "Vehicle Model";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(54, 408);
            label13.Name = "label13";
            label13.Size = new Size(103, 17);
            label13.TabIndex = 77;
            label13.Text = "Vehicle Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(658, 205);
            label8.Name = "label8";
            label8.Size = new Size(91, 17);
            label8.TabIndex = 76;
            label8.Text = "Driver License";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(355, 326);
            label9.Name = "label9";
            label9.Size = new Size(87, 17);
            label9.TabIndex = 75;
            label9.Text = "Driver Phone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(54, 326);
            label10.Name = "label10";
            label10.Size = new Size(84, 17);
            label10.TabIndex = 74;
            label10.Text = "Driver Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(654, 246);
            label7.Name = "label7";
            label7.Size = new Size(34, 17);
            label7.TabIndex = 73;
            label7.Text = "Fare";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(358, 246);
            label6.Name = "label6";
            label6.Size = new Size(77, 17);
            label6.TabIndex = 71;
            label6.Text = "Destination";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(55, 246);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 70;
            label5.Text = "Source";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(651, 162);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 68;
            label4.Text = "Arrival Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(358, 165);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 66;
            label3.Text = "Depature Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(54, 165);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 63;
            label2.Text = "Trip Number";
            // 
            // FrmPassengerBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(944, 574);
            Controls.Add(VehicleBrandInput);
            Controls.Add(VehicleModel);
            Controls.Add(VehicleNumberInput);
            Controls.Add(DriverLicenseInput);
            Controls.Add(DriverPhoneInput);
            Controls.Add(FareInput);
            Controls.Add(DestinationInput);
            Controls.Add(SourceInput);
            Controls.Add(DriverNameInput);
            Controls.Add(ArrivalInput);
            Controls.Add(DepatureInput);
            Controls.Add(TripNumberInput);
            Controls.Add(panel1);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox14);
            Controls.Add(label1);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label16);
            Controls.Add(panel10);
            Name = "FrmPassengerBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPassengerBooking";
            Load += FrmPassengerBooking_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel10;
        public ComboBox CBTrip;
        private PictureBox pictureBox4;
        public ComboBox CBPassenger;
        private Label label18;
        private Label label19;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label16;
        private TextBox VehicleBrandInput;
        private TextBox VehicleModel;
        private TextBox VehicleNumberInput;
        private TextBox DriverLicenseInput;
        private TextBox DriverPhoneInput;
        private TextBox FareInput;
        private TextBox DestinationInput;
        private TextBox SourceInput;
        private TextBox DriverNameInput;
        private TextBox ArrivalInput;
        private TextBox DepatureInput;
        private TextBox TripNumberInput;
        private Panel panel1;
        private CustomControls.RJControls.RJButton ConfirmSeatsBtn;
        private CustomControls.RJControls.RJButton ConfirmReservationBtn;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private Label label1;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CustomControls.RJControls.RJButton SeatsBtn;
        private CustomControls.RJControls.RJButton ReserveBtn;
    }
}