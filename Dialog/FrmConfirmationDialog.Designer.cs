namespace TransportReservationSystem.Dialog
{
    partial class FrmConfirmationDialog
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
            iconCancelTop = new PictureBox();
            CancelBtn = new CustomControls.RJControls.RJButton();
            label1 = new Label();
            panel2 = new Panel();
            LblMsg = new Label();
            OkBtn = new CustomControls.RJControls.RJButton();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCancelTop).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(iconCancelTop);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 29);
            panel1.TabIndex = 5;
            // 
            // iconCancelTop
            // 
            iconCancelTop.BackColor = Color.DarkViolet;
            iconCancelTop.Cursor = Cursors.Hand;
            iconCancelTop.Image = Properties.Resources.icons8_cancel_25px;
            iconCancelTop.Location = new Point(334, 0);
            iconCancelTop.Name = "iconCancelTop";
            iconCancelTop.Size = new Size(23, 29);
            iconCancelTop.SizeMode = PictureBoxSizeMode.Zoom;
            iconCancelTop.TabIndex = 0;
            iconCancelTop.TabStop = false;
            iconCancelTop.Click += iconCancelTop_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.Silver;
            CancelBtn.BackgroundColor = Color.Silver;
            CancelBtn.BorderColor = Color.DarkViolet;
            CancelBtn.BorderRadius = 4;
            CancelBtn.BorderSize = 0;
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.ForeColor = Color.Black;
            CancelBtn.Location = new Point(189, 155);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(80, 26);
            CancelBtn.TabIndex = 15;
            CancelBtn.Text = "Cancel";
            CancelBtn.TextColor = Color.Black;
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(-2, 110);
            label1.Name = "label1";
            label1.Size = new Size(369, 30);
            label1.TabIndex = 14;
            label1.Text = "Not able to restore it again";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(LblMsg);
            panel2.Location = new Point(1, 80);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(369, 30);
            panel2.TabIndex = 13;
            // 
            // LblMsg
            // 
            LblMsg.Dock = DockStyle.Fill;
            LblMsg.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblMsg.ForeColor = Color.FromArgb(64, 64, 64);
            LblMsg.Location = new Point(0, 0);
            LblMsg.Name = "LblMsg";
            LblMsg.Size = new Size(369, 30);
            LblMsg.TabIndex = 2;
            LblMsg.Text = "Are you sure want delete this item";
            LblMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OkBtn
            // 
            OkBtn.BackColor = Color.FromArgb(255, 128, 0);
            OkBtn.BackgroundColor = Color.FromArgb(255, 128, 0);
            OkBtn.BorderColor = Color.DarkViolet;
            OkBtn.BorderRadius = 4;
            OkBtn.BorderSize = 0;
            OkBtn.Cursor = Cursors.Hand;
            OkBtn.FlatAppearance.BorderSize = 0;
            OkBtn.FlatStyle = FlatStyle.Flat;
            OkBtn.ForeColor = Color.Black;
            OkBtn.Location = new Point(89, 155);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(80, 26);
            OkBtn.TabIndex = 12;
            OkBtn.Text = "Ok";
            OkBtn.TextColor = Color.Black;
            OkBtn.UseVisualStyleBackColor = false;
            OkBtn.Click += OkBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.attention;
            pictureBox2.Location = new Point(135, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // FrmConfirmationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(369, 204);
            Controls.Add(CancelBtn);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(OkBtn);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConfirmationDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConfirmationDialog";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCancelTop).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox iconCancelTop;
        private CustomControls.RJControls.RJButton CancelBtn;
        private Label label1;
        private Panel panel2;
        private Label LblMsg;
        private CustomControls.RJControls.RJButton OkBtn;
        private PictureBox pictureBox2;
    }
}