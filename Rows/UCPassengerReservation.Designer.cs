namespace TransportReservationSystem.Rows
{
    partial class UCPassengerReservation
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
            CancellationReservationBtn = new CustomControls.RJControls.RJButton();
            LblTripNo = new Label();
            LblPassengerName = new Label();
            LblNoOFSeats = new Label();
            LblTotalCost = new Label();
            LblStatus = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CancellationReservationBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(704, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 43);
            panel1.TabIndex = 5;
            // 
            // CancellationReservationBtn
            // 
            CancellationReservationBtn.BackColor = Color.FromArgb(192, 0, 0);
            CancellationReservationBtn.BackgroundColor = Color.FromArgb(192, 0, 0);
            CancellationReservationBtn.BorderColor = Color.PaleVioletRed;
            CancellationReservationBtn.BorderRadius = 4;
            CancellationReservationBtn.BorderSize = 0;
            CancellationReservationBtn.FlatAppearance.BorderSize = 0;
            CancellationReservationBtn.FlatStyle = FlatStyle.Flat;
            CancellationReservationBtn.ForeColor = Color.White;
            CancellationReservationBtn.Location = new Point(13, 9);
            CancellationReservationBtn.Name = "CancellationReservationBtn";
            CancellationReservationBtn.Size = new Size(132, 25);
            CancellationReservationBtn.TabIndex = 0;
            CancellationReservationBtn.Text = "CancelReservation";
            CancellationReservationBtn.TextColor = Color.White;
            CancellationReservationBtn.UseVisualStyleBackColor = false;
            CancellationReservationBtn.Click += CancellationReservationBtn_Click;
            // 
            // LblTripNo
            // 
            LblTripNo.AutoSize = true;
            LblTripNo.Dock = DockStyle.Fill;
            LblTripNo.Location = new Point(3, 0);
            LblTripNo.Name = "LblTripNo";
            LblTripNo.Size = new Size(133, 49);
            LblTripNo.TabIndex = 0;
            LblTripNo.Text = "Trip No";
            LblTripNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblPassengerName
            // 
            LblPassengerName.AutoSize = true;
            LblPassengerName.Dock = DockStyle.Fill;
            LblPassengerName.Location = new Point(142, 0);
            LblPassengerName.Name = "LblPassengerName";
            LblPassengerName.Size = new Size(139, 49);
            LblPassengerName.TabIndex = 1;
            LblPassengerName.Text = "Passenger Name";
            LblPassengerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblNoOFSeats
            // 
            LblNoOFSeats.AutoSize = true;
            LblNoOFSeats.Dock = DockStyle.Fill;
            LblNoOFSeats.Location = new Point(287, 0);
            LblNoOFSeats.Name = "LblNoOFSeats";
            LblNoOFSeats.Size = new Size(133, 49);
            LblNoOFSeats.TabIndex = 2;
            LblNoOFSeats.Text = "Number of Seats";
            LblNoOFSeats.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblTotalCost
            // 
            LblTotalCost.AutoSize = true;
            LblTotalCost.Dock = DockStyle.Fill;
            LblTotalCost.Location = new Point(426, 0);
            LblTotalCost.Name = "LblTotalCost";
            LblTotalCost.Size = new Size(133, 49);
            LblTotalCost.TabIndex = 3;
            LblTotalCost.Text = "Total Cost";
            LblTotalCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Dock = DockStyle.Fill;
            LblStatus.Location = new Point(565, 0);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(133, 49);
            LblStatus.TabIndex = 4;
            LblStatus.Text = "Status";
            LblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.17129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.8795872F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1712856F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1712856F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1712856F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.4352665F));
            tableLayoutPanel1.Controls.Add(LblStatus, 4, 0);
            tableLayoutPanel1.Controls.Add(LblTotalCost, 3, 0);
            tableLayoutPanel1.Controls.Add(LblNoOFSeats, 2, 0);
            tableLayoutPanel1.Controls.Add(LblPassengerName, 1, 0);
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
            tableLayoutPanel1.TabIndex = 4;
            // 
            // UCPassengerReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UCPassengerReservation";
            Size = new Size(860, 49);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomControls.RJControls.RJButton CancellationReservationBtn;
        private Label LblTripNo;
        private Label LblPassengerName;
        private Label LblNoOFSeats;
        private Label LblTotalCost;
        private Label LblStatus;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
