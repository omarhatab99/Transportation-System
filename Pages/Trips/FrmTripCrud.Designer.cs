namespace TransportReservationSystem.Pages.Trips
{
    partial class FrmTripCrud
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            panel5 = new Panel();
            ToggleButtonHomaAndAway = new CustomControls.RJControls.RJToggleButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DateTimePicker_Arrival = new DateTimePicker();
            DateTimePicker_Depature = new DateTimePicker();
            CreateDriverBtn = new CustomControls.RJControls.RJButton();
            CreateStationBtn = new CustomControls.RJControls.RJButton();
            CBVehicle = new ComboBox();
            CBDriver = new ComboBox();
            CBDestination = new ComboBox();
            CBSource = new ComboBox();
            pictureBox9 = new PictureBox();
            pictureBox4 = new PictureBox();
            FareTBOX = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            SubmitTripForm_CreateBtn = new CustomControls.RJControls.RJButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 74);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.TripsPassengerHeading1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(960, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 74);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(30, 15, 30, 10);
            panel4.Size = new Size(960, 231);
            panel4.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.MintCream;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.GridColor = Color.FromArgb(192, 0, 192);
            dataGridView2.Location = new Point(30, 15);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Purple;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Size = new Size(900, 206);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MintCream;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Purple;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.GridColor = Color.FromArgb(192, 0, 192);
            dataGridView1.Location = new Point(30, 15);
            dataGridView1.Margin = new Padding(30, 3, 30, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Purple;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(900, 206);
            dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 305);
            panel3.Name = "panel3";
            panel3.Size = new Size(960, 308);
            panel3.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MintCream;
            panel5.Controls.Add(ToggleButtonHomaAndAway);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(DateTimePicker_Arrival);
            panel5.Controls.Add(DateTimePicker_Depature);
            panel5.Controls.Add(CreateDriverBtn);
            panel5.Controls.Add(CreateStationBtn);
            panel5.Controls.Add(CBVehicle);
            panel5.Controls.Add(CBDriver);
            panel5.Controls.Add(CBDestination);
            panel5.Controls.Add(CBSource);
            panel5.Controls.Add(pictureBox9);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(FareTBOX);
            panel5.Controls.Add(pictureBox7);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(SubmitTripForm_CreateBtn);
            panel5.Location = new Point(8, 8);
            panel5.Name = "panel5";
            panel5.Size = new Size(960, 308);
            panel5.TabIndex = 2;
            // 
            // ToggleButtonHomaAndAway
            // 
            ToggleButtonHomaAndAway.AutoSize = true;
            ToggleButtonHomaAndAway.Location = new Point(604, 15);
            ToggleButtonHomaAndAway.MinimumSize = new Size(45, 22);
            ToggleButtonHomaAndAway.Name = "ToggleButtonHomaAndAway";
            ToggleButtonHomaAndAway.OffBackColor = Color.Gray;
            ToggleButtonHomaAndAway.OffToggleColor = Color.Gainsboro;
            ToggleButtonHomaAndAway.OnBackColor = Color.Green;
            ToggleButtonHomaAndAway.OnToggleColor = Color.White;
            ToggleButtonHomaAndAway.Size = new Size(45, 22);
            ToggleButtonHomaAndAway.TabIndex = 31;
            ToggleButtonHomaAndAway.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(655, 18);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 29;
            label3.Text = "Make Trip Home and Away";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(305, 215);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 27;
            label2.Text = "Arrival Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(41, 214);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 26;
            label1.Text = "Depature Date";
            // 
            // DateTimePicker_Arrival
            // 
            DateTimePicker_Arrival.CalendarTitleBackColor = SystemColors.ControlText;
            DateTimePicker_Arrival.CalendarTitleForeColor = SystemColors.ButtonHighlight;
            DateTimePicker_Arrival.Format = DateTimePickerFormat.Time;
            DateTimePicker_Arrival.Location = new Point(305, 233);
            DateTimePicker_Arrival.Name = "DateTimePicker_Arrival";
            DateTimePicker_Arrival.Size = new Size(257, 23);
            DateTimePicker_Arrival.TabIndex = 7;
            // 
            // DateTimePicker_Depature
            // 
            DateTimePicker_Depature.CalendarTitleBackColor = SystemColors.ControlText;
            DateTimePicker_Depature.CalendarTitleForeColor = SystemColors.ButtonHighlight;
            DateTimePicker_Depature.Format = DateTimePickerFormat.Time;
            DateTimePicker_Depature.Location = new Point(42, 233);
            DateTimePicker_Depature.Name = "DateTimePicker_Depature";
            DateTimePicker_Depature.Size = new Size(257, 23);
            DateTimePicker_Depature.TabIndex = 6;
            // 
            // CreateDriverBtn
            // 
            CreateDriverBtn.BackColor = Color.FromArgb(0, 64, 64);
            CreateDriverBtn.BackgroundColor = Color.FromArgb(0, 64, 64);
            CreateDriverBtn.BorderColor = Color.PaleVioletRed;
            CreateDriverBtn.BorderRadius = 5;
            CreateDriverBtn.BorderSize = 0;
            CreateDriverBtn.Cursor = Cursors.Hand;
            CreateDriverBtn.FlatAppearance.BorderSize = 0;
            CreateDriverBtn.FlatStyle = FlatStyle.Flat;
            CreateDriverBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateDriverBtn.ForeColor = Color.White;
            CreateDriverBtn.Location = new Point(354, 7);
            CreateDriverBtn.Name = "CreateDriverBtn";
            CreateDriverBtn.Size = new Size(150, 40);
            CreateDriverBtn.TabIndex = 25;
            CreateDriverBtn.Text = "Create Driver";
            CreateDriverBtn.TextColor = Color.White;
            CreateDriverBtn.UseVisualStyleBackColor = false;
            CreateDriverBtn.Click += CreateDriverBtn_Click;
            // 
            // CreateStationBtn
            // 
            CreateStationBtn.BackColor = Color.FromArgb(0, 64, 64);
            CreateStationBtn.BackgroundColor = Color.FromArgb(0, 64, 64);
            CreateStationBtn.BorderColor = Color.PaleVioletRed;
            CreateStationBtn.BorderRadius = 5;
            CreateStationBtn.BorderSize = 0;
            CreateStationBtn.Cursor = Cursors.Hand;
            CreateStationBtn.FlatAppearance.BorderSize = 0;
            CreateStationBtn.FlatStyle = FlatStyle.Flat;
            CreateStationBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateStationBtn.ForeColor = Color.White;
            CreateStationBtn.Location = new Point(198, 7);
            CreateStationBtn.Name = "CreateStationBtn";
            CreateStationBtn.Size = new Size(150, 40);
            CreateStationBtn.TabIndex = 24;
            CreateStationBtn.Text = "Create Station";
            CreateStationBtn.TextColor = Color.White;
            CreateStationBtn.UseVisualStyleBackColor = false;
            CreateStationBtn.Click += CreateStationBtn_Click;
            // 
            // CBVehicle
            // 
            CBVehicle.FlatStyle = FlatStyle.Flat;
            CBVehicle.FormattingEnabled = true;
            CBVehicle.Location = new Point(346, 160);
            CBVehicle.Name = "CBVehicle";
            CBVehicle.Size = new Size(192, 23);
            CBVehicle.TabIndex = 5;
            // 
            // CBDriver
            // 
            CBDriver.FlatStyle = FlatStyle.Flat;
            CBDriver.FormattingEnabled = true;
            CBDriver.Location = new Point(83, 158);
            CBDriver.Name = "CBDriver";
            CBDriver.Size = new Size(192, 23);
            CBDriver.TabIndex = 4;
            // 
            // CBDestination
            // 
            CBDestination.FlatStyle = FlatStyle.Flat;
            CBDestination.FormattingEnabled = true;
            CBDestination.Location = new Point(346, 93);
            CBDestination.Name = "CBDestination";
            CBDestination.Size = new Size(192, 23);
            CBDestination.TabIndex = 2;
            CBDestination.DropDown += CBDestination_DropDown;
            // 
            // CBSource
            // 
            CBSource.FlatStyle = FlatStyle.Flat;
            CBSource.FormattingEnabled = true;
            CBSource.Location = new Point(86, 92);
            CBSource.Name = "CBSource";
            CBSource.Size = new Size(192, 23);
            CBSource.TabIndex = 1;
            CBSource.DropDown += CBSource_DropDown;
            CBSource.SelectedIndexChanged += CBSource_SelectedIndexChanged;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.VehicleInput;
            pictureBox9.Location = new Point(305, 121);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(257, 83);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 14;
            pictureBox9.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.DriverInput;
            pictureBox4.Location = new Point(42, 121);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(257, 83);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // FareTBOX
            // 
            FareTBOX.BorderStyle = BorderStyle.None;
            FareTBOX.ForeColor = Color.DimGray;
            FareTBOX.Location = new Point(609, 93);
            FareTBOX.Name = "FareTBOX";
            FareTBOX.Size = new Size(195, 16);
            FareTBOX.TabIndex = 3;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.FareInput;
            pictureBox7.Location = new Point(568, 53);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(257, 83);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.DestinationInput;
            pictureBox6.Location = new Point(305, 53);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(257, 83);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Source;
            pictureBox2.Location = new Point(42, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // SubmitTripForm_CreateBtn
            // 
            SubmitTripForm_CreateBtn.BackColor = Color.DarkOrchid;
            SubmitTripForm_CreateBtn.BackgroundColor = Color.DarkOrchid;
            SubmitTripForm_CreateBtn.BorderColor = Color.PaleVioletRed;
            SubmitTripForm_CreateBtn.BorderRadius = 5;
            SubmitTripForm_CreateBtn.BorderSize = 0;
            SubmitTripForm_CreateBtn.Cursor = Cursors.Hand;
            SubmitTripForm_CreateBtn.FlatAppearance.BorderSize = 0;
            SubmitTripForm_CreateBtn.FlatStyle = FlatStyle.Flat;
            SubmitTripForm_CreateBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitTripForm_CreateBtn.ForeColor = Color.White;
            SubmitTripForm_CreateBtn.Location = new Point(42, 6);
            SubmitTripForm_CreateBtn.Name = "SubmitTripForm_CreateBtn";
            SubmitTripForm_CreateBtn.Size = new Size(150, 40);
            SubmitTripForm_CreateBtn.TabIndex = 0;
            SubmitTripForm_CreateBtn.Text = "Create";
            SubmitTripForm_CreateBtn.TextColor = Color.White;
            SubmitTripForm_CreateBtn.UseVisualStyleBackColor = false;
            SubmitTripForm_CreateBtn.Click += SubmitTripForm_CreateBtn_Click;
            // 
            // FrmTripCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(960, 613);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Name = "FrmTripCrud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTripCrud";
            Load += FrmTripCrud_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel panel5;
        private TextBox FareTBOX;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        public CustomControls.RJControls.RJButton SubmitTripForm_CreateBtn;
        private PictureBox pictureBox9;
        private PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private TextBox LicenseTBOX;
        public CustomControls.RJControls.RJButton CreateStationBtn;
        public CustomControls.RJControls.RJButton CreateDriverBtn;
        public ComboBox CBDestination;
        public ComboBox CBSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private CustomControls.RJControls.RJToggleButton ToggleButtonHomaAndAway;
        public DateTimePicker DateTimePicker_Depature;
        public DateTimePicker DateTimePicker_Arrival;
        public ComboBox CBVehicle;
        public ComboBox CBDriver;
    }
}