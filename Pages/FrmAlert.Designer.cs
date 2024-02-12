namespace TransportReservationSystem.Pages
{
    partial class FrmAlert
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
            lblMsg = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.ForeColor = Color.White;
            lblMsg.Location = new Point(80, 33);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(116, 21);
            lblMsg.TabIndex = 0;
            lblMsg.Text = "Message Text";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.success;
            pictureBox1.Location = new Point(12, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_cancel_25px;
            pictureBox2.Location = new Point(313, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmAlert
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(352, 86);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblMsg);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmAlert";
            Text = "FrmAlert";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMsg;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
    }
}