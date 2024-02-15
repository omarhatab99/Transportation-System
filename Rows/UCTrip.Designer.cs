namespace TransportReservationSystem.Rows
{
    partial class UCTrip
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            resservationToolStripMenuItem = new ToolStripMenuItem();
            passengersToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            LblDepature = new Label();
            LblDestination = new Label();
            LblSource = new Label();
            LblTripNo = new Label();
            panel1 = new Panel();
            EditBtn = new CustomControls.RJControls.RJButton();
            DeleteBtn = new CustomControls.RJControls.RJButton();
            contextMenuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem, resservationToolStripMenuItem, passengersToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 114);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // resservationToolStripMenuItem
            // 
            resservationToolStripMenuItem.Name = "resservationToolStripMenuItem";
            resservationToolStripMenuItem.Size = new Size(180, 22);
            resservationToolStripMenuItem.Text = "Reservation";
            resservationToolStripMenuItem.Click += resservationToolStripMenuItem_Click;
            // 
            // passengersToolStripMenuItem
            // 
            passengersToolStripMenuItem.Name = "passengersToolStripMenuItem";
            passengersToolStripMenuItem.Size = new Size(180, 22);
            passengersToolStripMenuItem.Text = "Passengers";
            passengersToolStripMenuItem.Click += passengersToolStripMenuItem_Click;
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
            tableLayoutPanel1.TabIndex = 4;
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
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(DeleteBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(695, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 43);
            panel1.TabIndex = 5;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(255, 128, 0);
            EditBtn.BackgroundColor = Color.FromArgb(255, 128, 0);
            EditBtn.BorderColor = Color.PaleVioletRed;
            EditBtn.BorderRadius = 4;
            EditBtn.BorderSize = 0;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(25, 9);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(56, 25);
            EditBtn.TabIndex = 1;
            EditBtn.Text = "Edit";
            EditBtn.TextColor = Color.White;
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
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
            DeleteBtn.Location = new Point(87, 9);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(56, 25);
            DeleteBtn.TabIndex = 0;
            DeleteBtn.Text = "Delete";
            DeleteBtn.TextColor = Color.White;
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UCTrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(tableLayoutPanel1);
            Name = "UCTrip";
            Size = new Size(860, 49);
            contextMenuStrip1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem resservationToolStripMenuItem;
        private ToolStripMenuItem passengersToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LblDepature;
        private Label LblDestination;
        private Label LblSource;
        private Label LblTripNo;
        private Panel panel1;
        private CustomControls.RJControls.RJButton EditBtn;
        private CustomControls.RJControls.RJButton DeleteBtn;
    }
}
