namespace TransportReservationSystem.Rows
{
    partial class UCReservation
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
            tableLayoutPanel1 = new TableLayoutPanel();
            LblStatus = new Label();
            LblTotalCost = new Label();
            LblNoOFSeats = new Label();
            LblPassengerName = new Label();
            LblTripNo = new Label();
            panel1 = new Panel();
            DetailsBtn = new CustomControls.RJControls.RJButton();
            DeleteBtn = new CustomControls.RJControls.RJButton();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.TabIndex = 3;
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
            // panel1
            // 
            panel1.Controls.Add(DetailsBtn);
            panel1.Controls.Add(DeleteBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(704, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 43);
            panel1.TabIndex = 5;
            // 
            // DetailsBtn
            // 
            DetailsBtn.BackColor = Color.Teal;
            DetailsBtn.BackgroundColor = Color.Teal;
            DetailsBtn.BorderColor = Color.PaleVioletRed;
            DetailsBtn.BorderRadius = 4;
            DetailsBtn.BorderSize = 0;
            DetailsBtn.FlatAppearance.BorderSize = 0;
            DetailsBtn.FlatStyle = FlatStyle.Flat;
            DetailsBtn.ForeColor = Color.White;
            DetailsBtn.Location = new Point(21, 9);
            DetailsBtn.Name = "DetailsBtn";
            DetailsBtn.Size = new Size(56, 25);
            DetailsBtn.TabIndex = 1;
            DetailsBtn.Text = "Details";
            DetailsBtn.TextColor = Color.White;
            DetailsBtn.UseVisualStyleBackColor = false;
            DetailsBtn.Click += DetailsBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(192, 0, 0);
            DeleteBtn.BackgroundColor = Color.FromArgb(192, 0, 0);
            DeleteBtn.BorderColor = Color.PaleVioletRed;
            DeleteBtn.BorderRadius = 4;
            DeleteBtn.BorderSize = 0;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(83, 9);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(56, 25);
            DeleteBtn.TabIndex = 0;
            DeleteBtn.Text = "Delete";
            DeleteBtn.TextColor = Color.White;
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UCReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UCReservation";
            Size = new Size(860, 49);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label LblStatus;
        private Label LblTotalCost;
        private Label LblNoOFSeats;
        private Label LblPassengerName;
        private Label LblTripNo;
        private Panel panel1;
        private CustomControls.RJControls.RJButton DetailsBtn;
        private CustomControls.RJControls.RJButton DeleteBtn;
    }
}
