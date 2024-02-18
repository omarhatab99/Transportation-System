namespace TransportReservationSystem.Rows
{
    partial class UCDriverTrips
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
            LblDepature = new Label();
            LblDestination = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            LblSource = new Label();
            LblTripNo = new Label();
            panel1 = new Panel();
            DoneBtn = new CustomControls.RJControls.RJButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LblDepature
            // 
            LblDepature.AutoSize = true;
            LblDepature.Dock = DockStyle.Fill;
            LblDepature.Location = new Point(117, 0);
            LblDepature.Name = "LblDepature";
            LblDepature.Size = new Size(39, 100);
            LblDepature.TabIndex = 3;
            LblDepature.Text = "Depature Date";
            LblDepature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblDestination
            // 
            LblDestination.AutoSize = true;
            LblDestination.Dock = DockStyle.Fill;
            LblDestination.Location = new Point(73, 0);
            LblDestination.Name = "LblDestination";
            LblDestination.Size = new Size(38, 100);
            LblDestination.TabIndex = 2;
            LblDestination.Text = "Destination";
            LblDestination.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.8527412F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.9298763F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2680969F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.71775F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.2315388F));
            tableLayoutPanel2.Controls.Add(label1, 3, 0);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(LblSource, 1, 0);
            tableLayoutPanel2.Controls.Add(LblTripNo, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 5, 0);
            tableLayoutPanel2.Cursor = Cursors.Hand;
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.ForeColor = Color.Black;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(860, 49);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(500, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 49);
            label1.TabIndex = 3;
            label1.Text = "Depature Date";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(309, 0);
            label2.Name = "label2";
            label2.Size = new Size(185, 49);
            label2.TabIndex = 2;
            label2.Text = "Destination";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            // panel1
            // 
            panel1.Controls.Add(DoneBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(695, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 43);
            panel1.TabIndex = 5;
            // 
            // DoneBtn
            // 
            DoneBtn.BackColor = Color.FromArgb(0, 192, 192);
            DoneBtn.BackgroundColor = Color.FromArgb(0, 192, 192);
            DoneBtn.BorderColor = Color.PaleVioletRed;
            DoneBtn.BorderRadius = 4;
            DoneBtn.BorderSize = 0;
            DoneBtn.FlatAppearance.BorderSize = 0;
            DoneBtn.FlatStyle = FlatStyle.Flat;
            DoneBtn.ForeColor = Color.White;
            DoneBtn.Location = new Point(37, 9);
            DoneBtn.Name = "DoneBtn";
            DoneBtn.Size = new Size(97, 25);
            DoneBtn.TabIndex = 1;
            DoneBtn.Text = "Done";
            DoneBtn.TextColor = Color.White;
            DoneBtn.UseVisualStyleBackColor = false;
            DoneBtn.Click += DoneBtn_Click;
            // 
            // UCDriverTrips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "UCDriverTrips";
            Size = new Size(860, 49);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label LblDepature;
        private Label LblDestination;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label LblSource;
        private Label LblTripNo;
        private Panel panel1;
        private CustomControls.RJControls.RJButton DoneBtn;
    }
}
