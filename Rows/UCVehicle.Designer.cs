namespace TransportReservationSystem.Rows
{
    partial class UCVehicle
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
            tripsToolStripMenuItem = new ToolStripMenuItem();
            toggleStatusToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            LblVehicleNo = new Label();
            LblBrand = new Label();
            LblModel = new Label();
            LblCategory = new Label();
            LblLicensePlate = new Label();
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
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem, tripsToolStripMenuItem, toggleStatusToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(145, 92);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(144, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(144, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // tripsToolStripMenuItem
            // 
            tripsToolStripMenuItem.Name = "tripsToolStripMenuItem";
            tripsToolStripMenuItem.Size = new Size(144, 22);
            tripsToolStripMenuItem.Text = "Trips";
            tripsToolStripMenuItem.Click += tripsToolStripMenuItem_Click;
            // 
            // toggleStatusToolStripMenuItem
            // 
            toggleStatusToolStripMenuItem.Name = "toggleStatusToolStripMenuItem";
            toggleStatusToolStripMenuItem.Size = new Size(144, 22);
            toggleStatusToolStripMenuItem.Text = "Toggle Status";
            toggleStatusToolStripMenuItem.Click += toggleStatusVehicleToolStripMenuItem_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.17129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.8795872F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1712856F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1712856F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1712856F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.4352665F));
            tableLayoutPanel1.Controls.Add(LblVehicleNo, 4, 0);
            tableLayoutPanel1.Controls.Add(LblBrand, 3, 0);
            tableLayoutPanel1.Controls.Add(LblModel, 2, 0);
            tableLayoutPanel1.Controls.Add(LblCategory, 1, 0);
            tableLayoutPanel1.Controls.Add(LblLicensePlate, 0, 0);
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
            tableLayoutPanel1.TabIndex = 7;
            // 
            // LblVehicleNo
            // 
            LblVehicleNo.AutoSize = true;
            LblVehicleNo.BackColor = Color.Transparent;
            LblVehicleNo.Dock = DockStyle.Fill;
            LblVehicleNo.Location = new Point(565, 0);
            LblVehicleNo.Name = "LblVehicleNo";
            LblVehicleNo.Size = new Size(133, 49);
            LblVehicleNo.TabIndex = 4;
            LblVehicleNo.Text = "VehicleNo";
            LblVehicleNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblBrand
            // 
            LblBrand.AutoSize = true;
            LblBrand.BackColor = Color.Transparent;
            LblBrand.Dock = DockStyle.Fill;
            LblBrand.Location = new Point(426, 0);
            LblBrand.Name = "LblBrand";
            LblBrand.Size = new Size(133, 49);
            LblBrand.TabIndex = 3;
            LblBrand.Text = "Brand";
            LblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblModel
            // 
            LblModel.AutoSize = true;
            LblModel.BackColor = Color.Transparent;
            LblModel.Dock = DockStyle.Fill;
            LblModel.Location = new Point(287, 0);
            LblModel.Name = "LblModel";
            LblModel.Size = new Size(133, 49);
            LblModel.TabIndex = 2;
            LblModel.Text = "Model";
            LblModel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblCategory
            // 
            LblCategory.AutoSize = true;
            LblCategory.BackColor = Color.Transparent;
            LblCategory.Dock = DockStyle.Fill;
            LblCategory.Location = new Point(142, 0);
            LblCategory.Name = "LblCategory";
            LblCategory.Size = new Size(139, 49);
            LblCategory.TabIndex = 1;
            LblCategory.Text = "Category";
            LblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblLicensePlate
            // 
            LblLicensePlate.AutoSize = true;
            LblLicensePlate.BackColor = Color.Transparent;
            LblLicensePlate.Dock = DockStyle.Fill;
            LblLicensePlate.Location = new Point(3, 0);
            LblLicensePlate.Name = "LblLicensePlate";
            LblLicensePlate.Size = new Size(133, 49);
            LblLicensePlate.TabIndex = 0;
            LblLicensePlate.Text = "License";
            LblLicensePlate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(DeleteBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(704, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 43);
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
            EditBtn.Location = new Point(17, 9);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(56, 25);
            EditBtn.TabIndex = 3;
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
            DeleteBtn.Location = new Point(79, 9);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(56, 25);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "Delete";
            DeleteBtn.TextColor = Color.White;
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UCVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(tableLayoutPanel1);
            Name = "UCVehicle";
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
        private ToolStripMenuItem tripsToolStripMenuItem;
        private ToolStripMenuItem toggleStatusToolStripMenuItem;
        public TableLayoutPanel tableLayoutPanel1;
        private Label LblVehicleNo;
        private Label LblBrand;
        private Label LblModel;
        private Label LblCategory;
        private Label LblLicensePlate;
        public Panel panel1;
        private CustomControls.RJControls.RJButton EditBtn;
        private CustomControls.RJControls.RJButton DeleteBtn;
    }
}
