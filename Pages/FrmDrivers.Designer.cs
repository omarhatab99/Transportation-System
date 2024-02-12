namespace TransportReservationSystem
{
    partial class FrmDrivers
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            Label5 = new Label();
            SwitchTimer = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            FLBDrivers = new FlowLayoutPanel();
            panel9 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel10 = new Panel();
            DriverSearchInput = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            CreateDriverBtn = new CustomControls.RJControls.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CreateDriverBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(960, 94);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.DriverHeading1;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(950, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(68, 11, 91);
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.17129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.8795872F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1712856F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1712856F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1712856F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.4352665F));
            tableLayoutPanel1.Controls.Add(label6, 5, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(164, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 100);
            label6.TabIndex = 5;
            label6.Text = "Actions";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Dock = DockStyle.Fill;
            Label5.Location = new Point(132, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(26, 100);
            Label5.TabIndex = 4;
            Label5.Text = "Salary";
            Label5.TextAlign = ContentAlignment.MiddleCenter;
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
            panel8.Controls.Add(FLBDrivers);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 62);
            panel8.Name = "panel8";
            panel8.Size = new Size(860, 347);
            panel8.TabIndex = 1;
            // 
            // FLBDrivers
            // 
            FLBDrivers.AutoScroll = true;
            FLBDrivers.Dock = DockStyle.Fill;
            FLBDrivers.Location = new Point(0, 0);
            FLBDrivers.Name = "FLBDrivers";
            FLBDrivers.Size = new Size(860, 347);
            FLBDrivers.TabIndex = 1;
            FLBDrivers.SizeChanged += FLBDrivers_SizeChanged;
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
            label2.Text = "Salary";
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
            Label4.Text = "Email";
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
            Label3.Text = "Phone";
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
            label7.Text = "Username";
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
            label8.Text = "Licenece";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.Controls.Add(DriverSearchInput);
            panel10.Controls.Add(pictureBox2);
            panel10.Location = new Point(50, 9);
            panel10.Name = "panel10";
            panel10.Size = new Size(860, 65);
            panel10.TabIndex = 5;
            // 
            // DriverSearchInput
            // 
            DriverSearchInput.BorderStyle = BorderStyle.None;
            DriverSearchInput.Location = new Point(142, 31);
            DriverSearchInput.Name = "DriverSearchInput";
            DriverSearchInput.Size = new Size(569, 22);
            DriverSearchInput.TabIndex = 2;
            DriverSearchInput.KeyUp += DriverSearchInput_KeyUp;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.SearchInput;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(860, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
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
            panel2.TabIndex = 1;
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
            CreateDriverBtn.Location = new Point(861, 29);
            CreateDriverBtn.Name = "CreateDriverBtn";
            CreateDriverBtn.Size = new Size(71, 30);
            CreateDriverBtn.TabIndex = 2;
            CreateDriverBtn.Text = "Create";
            CreateDriverBtn.TextColor = Color.White;
            CreateDriverBtn.UseVisualStyleBackColor = false;
            CreateDriverBtn.Click += CreateDriverBtn_Click;
            // 
            // FrmDrivers
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(960, 613);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FrmDrivers";
            Text = "FrmDrivers";
            Load += FrmDrivers_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label Label5;
        private System.Windows.Forms.Timer SwitchTimer;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel7;
        private Panel panel8;
        private FlowLayoutPanel FLBDrivers;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label Label4;
        private Label Label3;
        private Label label7;
        private Label label8;
        private Panel panel10;
        private TextBox DriverSearchInput;
        private PictureBox pictureBox2;
        private Panel panel2;
        private CustomControls.RJControls.RJButton CreateDriverBtn;
    }
}