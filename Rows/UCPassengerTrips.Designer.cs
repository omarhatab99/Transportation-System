namespace TransportReservationSystem.Rows
{
    partial class UCPassengerTrips
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ReserveBtn = new CustomControls.RJControls.RJButton();
            LblTripNo = new Label();
            LblSource = new Label();
            LblDestination = new Label();
            LblDepature = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ReserveBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(695, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 43);
            panel1.TabIndex = 5;
            // 
            // ReserveBtn
            // 
            ReserveBtn.BackColor = Color.FromArgb(0, 192, 0);
            ReserveBtn.BackgroundColor = Color.FromArgb(0, 192, 0);
            ReserveBtn.BorderColor = Color.PaleVioletRed;
            ReserveBtn.BorderRadius = 4;
            ReserveBtn.BorderSize = 0;
            ReserveBtn.FlatAppearance.BorderSize = 0;
            ReserveBtn.FlatStyle = FlatStyle.Flat;
            ReserveBtn.ForeColor = Color.White;
            ReserveBtn.Location = new Point(38, 9);
            ReserveBtn.Name = "ReserveBtn";
            ReserveBtn.Size = new Size(96, 25);
            ReserveBtn.TabIndex = 1;
            ReserveBtn.Text = "Reserve";
            ReserveBtn.TextColor = Color.White;
            ReserveBtn.UseVisualStyleBackColor = false;
            ReserveBtn.Click += ReserveBtn_Click;
            // 
            // LblTripNo
            // 
            LblTripNo.AutoSize = true;
            LblTripNo.Dock = DockStyle.Fill;
            LblTripNo.Location = new Point(3, 0);
            LblTripNo.Name = "LblTripNo";
            LblTripNo.Size = new Size(95, 49);
            LblTripNo.TabIndex = 0;
            LblTripNo.Text = "TripNo";
            LblTripNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblSource
            // 
            LblSource.AutoSize = true;
            LblSource.Dock = DockStyle.Fill;
            LblSource.Location = new Point(104, 0);
            LblSource.Name = "LblSource";
            LblSource.Size = new Size(199, 49);
            LblSource.TabIndex = 1;
            LblSource.Text = "Source";
            LblSource.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblDestination
            // 
            LblDestination.AutoSize = true;
            LblDestination.Dock = DockStyle.Fill;
            LblDestination.Location = new Point(309, 0);
            LblDestination.Name = "LblDestination";
            LblDestination.Size = new Size(185, 49);
            LblDestination.TabIndex = 2;
            LblDestination.Text = "Destination";
            LblDestination.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblDepature
            // 
            LblDepature.AutoSize = true;
            LblDepature.Dock = DockStyle.Fill;
            LblDepature.Location = new Point(500, 0);
            LblDepature.Name = "LblDepature";
            LblDepature.Size = new Size(189, 49);
            LblDepature.TabIndex = 3;
            LblDepature.Text = "Depature Date";
            LblDepature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.8527412F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.9298763F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2680969F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.71775F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.2315388F));
            tableLayoutPanel1.Controls.Add(LblDepature, 3, 0);
            tableLayoutPanel1.Controls.Add(LblDestination, 2, 0);
            tableLayoutPanel1.Controls.Add(LblSource, 1, 0);
            tableLayoutPanel1.Controls.Add(LblTripNo, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 5, 0);
            tableLayoutPanel1.Cursor = Cursors.Hand;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.ForeColor = Color.Black;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(860, 49);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // UCPassengerTrips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UCPassengerTrips";
            Size = new Size(860, 49);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomControls.RJControls.RJButton ReserveBtn;
        private Label LblTripNo;
        private Label LblSource;
        private Label LblDestination;
        private Label LblDepature;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
