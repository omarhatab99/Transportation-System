namespace TransportReservationSystem
{
    partial class FrmVehicles
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
            panel1 = new Panel();
            CreateVehicleBtn = new CustomControls.RJControls.RJButton();
            CreateDriverBtn = new CustomControls.RJControls.RJButton();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel10 = new Panel();
            VehicleSearchInput = new TextBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            FLBVehicles = new FlowLayoutPanel();
            panel9 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CreateVehicleBtn);
            panel1.Controls.Add(CreateDriverBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(960, 84);
            panel1.TabIndex = 1;
            // 
            // CreateVehicleBtn
            // 
            CreateVehicleBtn.Anchor = AnchorStyles.Right;
            CreateVehicleBtn.BackColor = Color.DarkOrchid;
            CreateVehicleBtn.BackgroundColor = Color.DarkOrchid;
            CreateVehicleBtn.BorderColor = Color.PaleVioletRed;
            CreateVehicleBtn.BorderRadius = 5;
            CreateVehicleBtn.BorderSize = 0;
            CreateVehicleBtn.Cursor = Cursors.Hand;
            CreateVehicleBtn.FlatAppearance.BorderSize = 0;
            CreateVehicleBtn.FlatStyle = FlatStyle.Flat;
            CreateVehicleBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateVehicleBtn.ForeColor = Color.White;
            CreateVehicleBtn.Location = new Point(858, 25);
            CreateVehicleBtn.Name = "CreateVehicleBtn";
            CreateVehicleBtn.Size = new Size(71, 30);
            CreateVehicleBtn.TabIndex = 3;
            CreateVehicleBtn.Text = "Create";
            CreateVehicleBtn.TextColor = Color.White;
            CreateVehicleBtn.UseVisualStyleBackColor = false;
            CreateVehicleBtn.Click += CreateVehicleBtn_Click;
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
            CreateDriverBtn.Location = new Point(1616, 21);
            CreateDriverBtn.Name = "CreateDriverBtn";
            CreateDriverBtn.Size = new Size(71, 30);
            CreateDriverBtn.TabIndex = 2;
            CreateDriverBtn.Text = "Create";
            CreateDriverBtn.TextColor = Color.White;
            CreateDriverBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.VehicleHeading2;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(950, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MintCream;
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 84);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50, 80, 50, 30);
            panel2.Size = new Size(960, 529);
            panel2.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(VehicleSearchInput);
            panel10.Controls.Add(pictureBox2);
            panel10.Location = new Point(50, 9);
            panel10.Name = "panel10";
            panel10.Size = new Size(860, 65);
            panel10.TabIndex = 5;
            // 
            // VehicleSearchInput
            // 
            VehicleSearchInput.BorderStyle = BorderStyle.None;
            VehicleSearchInput.Location = new Point(142, 31);
            VehicleSearchInput.Name = "VehicleSearchInput";
            VehicleSearchInput.Size = new Size(569, 16);
            VehicleSearchInput.TabIndex = 2;
            VehicleSearchInput.KeyUp += VehicleSearchInput_KeyUp;
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
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(50, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(860, 419);
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
            panel7.Size = new Size(860, 419);
            panel7.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(FLBVehicles);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 62);
            panel8.Name = "panel8";
            panel8.Size = new Size(860, 357);
            panel8.TabIndex = 1;
            // 
            // FLBVehicles
            // 
            FLBVehicles.AutoScroll = true;
            FLBVehicles.Dock = DockStyle.Fill;
            FLBVehicles.Location = new Point(0, 0);
            FLBVehicles.Name = "FLBVehicles";
            FLBVehicles.Size = new Size(860, 357);
            FLBVehicles.TabIndex = 1;
            FLBVehicles.SizeChanged += FLBVehicles_SizeChanged;
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
            label2.Text = "VechileNo";
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
            Label4.Text = "Brand";
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
            Label3.Text = "Model";
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
            label7.Text = "Category";
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
            // FrmVehicles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(960, 613);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmVehicles";
            Text = "FrmVehicles";
            Load += FrmVehicles_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomControls.RJControls.RJButton CreateDriverBtn;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel10;
        private TextBox VehicleSearchInput;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel7;
        private Panel panel8;
        private FlowLayoutPanel FLBVehicles;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label Label4;
        private Label Label3;
        private Label label7;
        private Label label8;
        private CustomControls.RJControls.RJButton CreateVehicleBtn;
    }
}