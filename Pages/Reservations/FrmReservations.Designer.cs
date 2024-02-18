namespace TransportReservationSystem
{
    partial class FrmReservations
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            panel10 = new Panel();
            label5 = new Label();
            CustomCheckBoxAvailabelSearch = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            label6 = new Label();
            ComboBoxTripNo = new Guna.UI2.WinForms.Guna2ComboBox();
            panel3 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            FLBReservations = new FlowLayoutPanel();
            panel9 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            CreateDriverBtn = new CustomControls.RJControls.RJButton();
            CreateReservationBrn = new CustomControls.RJControls.RJButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MintCream;
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50, 80, 50, 30);
            panel2.Size = new Size(960, 519);
            panel2.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(label5);
            panel10.Controls.Add(CustomCheckBoxAvailabelSearch);
            panel10.Controls.Add(label6);
            panel10.Controls.Add(ComboBoxTripNo);
            panel10.Location = new Point(50, 9);
            panel10.Name = "panel10";
            panel10.Size = new Size(860, 65);
            panel10.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(408, 7);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 32;
            label5.Text = "Enable Search";
            // 
            // CustomCheckBoxAvailabelSearch
            // 
            CustomCheckBoxAvailabelSearch.CheckedState.BorderColor = Color.GreenYellow;
            CustomCheckBoxAvailabelSearch.CheckedState.BorderRadius = 2;
            CustomCheckBoxAvailabelSearch.CheckedState.BorderThickness = 0;
            CustomCheckBoxAvailabelSearch.CheckedState.FillColor = Color.GreenYellow;
            CustomCheckBoxAvailabelSearch.CustomizableEdges = customizableEdges1;
            CustomCheckBoxAvailabelSearch.Location = new Point(406, 35);
            CustomCheckBoxAvailabelSearch.Name = "CustomCheckBoxAvailabelSearch";
            CustomCheckBoxAvailabelSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CustomCheckBoxAvailabelSearch.Size = new Size(37, 18);
            CustomCheckBoxAvailabelSearch.TabIndex = 30;
            CustomCheckBoxAvailabelSearch.Text = "CustomCheckBoxSearch";
            CustomCheckBoxAvailabelSearch.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            CustomCheckBoxAvailabelSearch.UncheckedState.BorderRadius = 2;
            CustomCheckBoxAvailabelSearch.UncheckedState.BorderThickness = 0;
            CustomCheckBoxAvailabelSearch.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            CustomCheckBoxAvailabelSearch.Click += CustomCheckBoxAvailabelSearch_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(24, 7);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 29;
            label6.Text = "Select Trip Number";
            // 
            // ComboBoxTripNo
            // 
            ComboBoxTripNo.BackColor = Color.Transparent;
            ComboBoxTripNo.BorderRadius = 5;
            ComboBoxTripNo.CustomizableEdges = customizableEdges3;
            ComboBoxTripNo.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBoxTripNo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTripNo.Enabled = false;
            ComboBoxTripNo.FocusedColor = Color.FromArgb(94, 148, 255);
            ComboBoxTripNo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ComboBoxTripNo.Font = new Font("Segoe UI", 10F);
            ComboBoxTripNo.ForeColor = Color.FromArgb(68, 88, 112);
            ComboBoxTripNo.ItemHeight = 30;
            ComboBoxTripNo.Location = new Point(24, 25);
            ComboBoxTripNo.Name = "ComboBoxTripNo";
            ComboBoxTripNo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ComboBoxTripNo.Size = new Size(328, 36);
            ComboBoxTripNo.TabIndex = 2;
            ComboBoxTripNo.SelectedIndexChanged += ComboBoxTripNo_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(50, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(860, 409);
            panel3.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel9);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(860, 409);
            panel7.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(FLBReservations);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 62);
            panel8.Name = "panel8";
            panel8.Size = new Size(860, 347);
            panel8.TabIndex = 1;
            // 
            // FLBReservations
            // 
            FLBReservations.AutoScroll = true;
            FLBReservations.Dock = DockStyle.Fill;
            FLBReservations.Location = new Point(0, 0);
            FLBReservations.Name = "FLBReservations";
            FLBReservations.Size = new Size(860, 347);
            FLBReservations.TabIndex = 1;
            FLBReservations.SizeChanged += FLBReservations_SizeChanged;
            // 
            // panel9
            // 
            panel9.Controls.Add(tableLayoutPanel2);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(860, 62);
            panel9.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(68, 11, 91);
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.17129F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.8795872F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1712856F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1712856F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1712856F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.4352665F));
            tableLayoutPanel2.Controls.Add(label1, 5, 0);
            tableLayoutPanel2.Controls.Add(label2, 4, 0);
            tableLayoutPanel2.Controls.Add(Label4, 3, 0);
            tableLayoutPanel2.Controls.Add(Label3, 2, 0);
            tableLayoutPanel2.Controls.Add(label7, 1, 0);
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.ForeColor = Color.White;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(860, 62);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(704, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 62);
            label1.TabIndex = 5;
            label1.Text = "Actions";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(565, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 62);
            label2.TabIndex = 4;
            label2.Text = "Status";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Dock = DockStyle.Fill;
            Label4.Location = new Point(426, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(133, 62);
            Label4.TabIndex = 3;
            Label4.Text = "Total Cost";
            Label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Dock = DockStyle.Fill;
            Label3.Location = new Point(287, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(133, 62);
            Label3.TabIndex = 2;
            Label3.Text = "No of Seats";
            Label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(142, 0);
            label7.Name = "label7";
            label7.Size = new Size(139, 62);
            label7.TabIndex = 1;
            label7.Text = "Passenger Name";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(133, 62);
            label8.TabIndex = 0;
            label8.Text = "TripNo";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateDriverBtn
            // 
            CreateDriverBtn.Anchor = AnchorStyles.Right;
            CreateDriverBtn.BackColor = Color.DarkOrchid;
            CreateDriverBtn.BackgroundColor = Color.DarkOrchid;
            CreateDriverBtn.BorderColor = Color.PaleVioletRed;
            CreateDriverBtn.BorderRadius = 5;
            CreateDriverBtn.BorderSize = 0;
            CreateDriverBtn.Cursor = Cursors.Hand;
            CreateDriverBtn.FlatAppearance.BorderSize = 0;
            CreateDriverBtn.FlatStyle = FlatStyle.Flat;
            CreateDriverBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateDriverBtn.ForeColor = Color.White;
            CreateDriverBtn.Location = new Point(1616, 26);
            CreateDriverBtn.Name = "CreateDriverBtn";
            CreateDriverBtn.Size = new Size(71, 30);
            CreateDriverBtn.TabIndex = 2;
            CreateDriverBtn.Text = "Create";
            CreateDriverBtn.TextColor = Color.White;
            CreateDriverBtn.UseVisualStyleBackColor = false;
            // 
            // CreateReservationBrn
            // 
            CreateReservationBrn.Anchor = AnchorStyles.Right;
            CreateReservationBrn.BackColor = Color.DarkOrchid;
            CreateReservationBrn.BackgroundColor = Color.DarkOrchid;
            CreateReservationBrn.BorderColor = Color.PaleVioletRed;
            CreateReservationBrn.BorderRadius = 5;
            CreateReservationBrn.BorderSize = 0;
            CreateReservationBrn.Cursor = Cursors.Hand;
            CreateReservationBrn.FlatAppearance.BorderSize = 0;
            CreateReservationBrn.FlatStyle = FlatStyle.Flat;
            CreateReservationBrn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateReservationBrn.ForeColor = Color.White;
            CreateReservationBrn.Location = new Point(856, 32);
            CreateReservationBrn.Name = "CreateReservationBrn";
            CreateReservationBrn.Size = new Size(71, 30);
            CreateReservationBrn.TabIndex = 3;
            CreateReservationBrn.Text = "Create";
            CreateReservationBrn.TextColor = Color.White;
            CreateReservationBrn.UseVisualStyleBackColor = false;
            CreateReservationBrn.Click += CreateReservationBrn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(CreateReservationBrn);
            panel1.Controls.Add(CreateDriverBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(960, 94);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.ReservationHeading;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(950, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FrmReservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(960, 613);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmReservations";
            Text = "FrmReservations";
            Load += FrmReservations_Load;
            panel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel10;
        private Panel panel3;
        private Panel panel7;
        private Panel panel8;
        private FlowLayoutPanel FLBReservations;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label Label4;
        private Label Label3;
        private Label label7;
        private Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxTripNo;
        private Label label6;
        private Guna.UI2.WinForms.Guna2CustomCheckBox CustomCheckBoxAvailabelSearch;
        private Label label5;
        private CustomControls.RJControls.RJButton CreateDriverBtn;
        private CustomControls.RJControls.RJButton CreateReservationBrn;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}