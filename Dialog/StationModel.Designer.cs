namespace TransportReservationSystem.Dialog
{
    partial class StationModel
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
            ModalTimer = new System.Windows.Forms.Timer(components);
            StationNameTBOX = new TextBox();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            SubmitStationForm_CreateBtn = new CustomControls.RJControls.RJButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ModalTimer
            // 
            ModalTimer.Enabled = true;
            ModalTimer.Interval = 1;
            ModalTimer.Tick += ModalTimer_Tick;
            // 
            // StationNameTBOX
            // 
            StationNameTBOX.BorderStyle = BorderStyle.None;
            StationNameTBOX.ForeColor = Color.DimGray;
            StationNameTBOX.Location = new Point(65, 144);
            StationNameTBOX.Name = "StationNameTBOX";
            StationNameTBOX.Size = new Size(245, 16);
            StationNameTBOX.TabIndex = 12;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.StationInput;
            pictureBox7.Location = new Point(12, 108);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(381, 77);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 14;
            label1.Text = "Create new station";
            // 
            // SubmitStationForm_CreateBtn
            // 
            SubmitStationForm_CreateBtn.BackColor = Color.DarkOrchid;
            SubmitStationForm_CreateBtn.BackgroundColor = Color.DarkOrchid;
            SubmitStationForm_CreateBtn.BorderColor = Color.PaleVioletRed;
            SubmitStationForm_CreateBtn.BorderRadius = 5;
            SubmitStationForm_CreateBtn.BorderSize = 0;
            SubmitStationForm_CreateBtn.Cursor = Cursors.Hand;
            SubmitStationForm_CreateBtn.FlatAppearance.BorderSize = 0;
            SubmitStationForm_CreateBtn.FlatStyle = FlatStyle.Flat;
            SubmitStationForm_CreateBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitStationForm_CreateBtn.ForeColor = Color.White;
            SubmitStationForm_CreateBtn.Location = new Point(260, 208);
            SubmitStationForm_CreateBtn.Name = "SubmitStationForm_CreateBtn";
            SubmitStationForm_CreateBtn.Size = new Size(116, 40);
            SubmitStationForm_CreateBtn.TabIndex = 15;
            SubmitStationForm_CreateBtn.Text = "Create";
            SubmitStationForm_CreateBtn.TextColor = Color.White;
            SubmitStationForm_CreateBtn.UseVisualStyleBackColor = false;
            SubmitStationForm_CreateBtn.Click += SubmitStationForm_CreateBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkViolet;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_cancel_25px;
            pictureBox1.Location = new Point(379, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 29);
            panel1.TabIndex = 1;
            // 
            // StationModel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(405, 260);
            Controls.Add(SubmitStationForm_CreateBtn);
            Controls.Add(label1);
            Controls.Add(StationNameTBOX);
            Controls.Add(pictureBox7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StationModel";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StationModel";
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer ModalTimer;
        private TextBox StationNameTBOX;
        private PictureBox pictureBox7;
        private Label label1;
        public CustomControls.RJControls.RJButton SubmitStationForm_CreateBtn;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}