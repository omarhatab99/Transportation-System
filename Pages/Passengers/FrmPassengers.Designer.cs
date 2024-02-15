namespace TransportReservationSystem.Pages.Passengers
{
    partial class FrmPassengers
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
            CreateDriverBtn = new CustomControls.RJControls.RJButton();
            pictureBox1 = new PictureBox();
            CreateVehicleBtn = new CustomControls.RJControls.RJButton();
            CreatePassengerBtn = new CustomControls.RJControls.RJButton();
            panel1 = new Panel();
            panel3 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            FLBPassengers = new FlowLayoutPanel();
            panel9 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel10 = new Panel();
            PassengerSearchInput = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            CreateDriverBtn.Location = new Point(2371, 25);
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
            pictureBox1.Image = Properties.Resources.PassengerHeading;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(950, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            CreateVehicleBtn.Location = new Point(1612, 27);
            CreateVehicleBtn.Name = "CreateVehicleBtn";
            CreateVehicleBtn.Size = new Size(71, 30);
            CreateVehicleBtn.TabIndex = 4;
            CreateVehicleBtn.Text = "Create";
            CreateVehicleBtn.TextColor = Color.White;
            CreateVehicleBtn.UseVisualStyleBackColor = false;
            // 
            // CreatePassengerBtn
            // 
            CreatePassengerBtn.Anchor = AnchorStyles.Right;
            CreatePassengerBtn.BackColor = Color.DarkOrchid;
            CreatePassengerBtn.BackgroundColor = Color.DarkOrchid;
            CreatePassengerBtn.BorderColor = Color.PaleVioletRed;
            CreatePassengerBtn.BorderRadius = 5;
            CreatePassengerBtn.BorderSize = 0;
            CreatePassengerBtn.Cursor = Cursors.Hand;
            CreatePassengerBtn.FlatAppearance.BorderSize = 0;
            CreatePassengerBtn.FlatStyle = FlatStyle.Flat;
            CreatePassengerBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePassengerBtn.ForeColor = Color.White;
            CreatePassengerBtn.Location = new Point(859, 32);
            CreatePassengerBtn.Name = "CreatePassengerBtn";
            CreatePassengerBtn.Size = new Size(71, 30);
            CreatePassengerBtn.TabIndex = 5;
            CreatePassengerBtn.Text = "Create";
            CreatePassengerBtn.TextColor = Color.White;
            CreatePassengerBtn.UseVisualStyleBackColor = false;
            CreatePassengerBtn.Click += CreatePassengerBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(CreatePassengerBtn);
            panel1.Controls.Add(CreateVehicleBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(CreateDriverBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(960, 97);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(50, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(860, 406);
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
            panel7.Size = new Size(860, 406);
            panel7.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(FLBPassengers);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 62);
            panel8.Name = "panel8";
            panel8.Size = new Size(860, 344);
            panel8.TabIndex = 1;
            // 
            // FLBPassengers
            // 
            FLBPassengers.AutoScroll = true;
            FLBPassengers.Dock = DockStyle.Fill;
            FLBPassengers.Location = new Point(0, 0);
            FLBPassengers.Name = "FLBPassengers";
            FLBPassengers.Size = new Size(860, 344);
            FLBPassengers.TabIndex = 1;
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
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5985622F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0019531F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5985584F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5985584F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2023621F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label1, 4, 0);
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
            label1.Location = new Point(677, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 62);
            label1.TabIndex = 5;
            label1.Text = "Actions";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Dock = DockStyle.Fill;
            Label4.Location = new Point(518, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(153, 62);
            Label4.TabIndex = 3;
            Label4.Text = "Gender";
            Label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Dock = DockStyle.Fill;
            Label3.Location = new Point(359, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(153, 62);
            Label3.TabIndex = 2;
            Label3.Text = "Phone";
            Label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(162, 0);
            label7.Name = "label7";
            label7.Size = new Size(191, 62);
            label7.TabIndex = 1;
            label7.Text = "Email";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(153, 62);
            label8.TabIndex = 0;
            label8.Text = "Username";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.Controls.Add(PassengerSearchInput);
            panel10.Controls.Add(pictureBox2);
            panel10.Location = new Point(50, 9);
            panel10.Name = "panel10";
            panel10.Size = new Size(860, 65);
            panel10.TabIndex = 5;
            // 
            // PassengerSearchInput
            // 
            PassengerSearchInput.BorderStyle = BorderStyle.None;
            PassengerSearchInput.Location = new Point(142, 34);
            PassengerSearchInput.Name = "PassengerSearchInput";
            PassengerSearchInput.Size = new Size(569, 16);
            PassengerSearchInput.TabIndex = 3;
            PassengerSearchInput.TextChanged += PassengerSearchInput_TextChanged;
            PassengerSearchInput.KeyUp += PassengerSearchInput_KeyUp;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.SearchInput;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(860, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MintCream;
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 97);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50, 80, 50, 30);
            panel2.Size = new Size(960, 516);
            panel2.TabIndex = 3;
            // 
            // FrmPassengers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(960, 613);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmPassengers";
            Text = "FrmPassenger";
            Load += FrmPassengers_Load;
            SizeChanged += FrmPassengers_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
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
        private CustomControls.RJControls.RJButton CreateDriverBtn;
        private PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton CreateVehicleBtn;
        private CustomControls.RJControls.RJButton CreatePassengerBtn;
        private Panel panel1;
        private Panel panel3;
        private Panel panel7;
        private Panel panel8;
        private FlowLayoutPanel FLBPassengers;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label Label4;
        private Label Label3;
        private Label label7;
        private Label label8;
        private Panel panel10;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox PassengerSearchInput;
    }
}