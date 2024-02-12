namespace TransportReservationSystem.Dialog
{
    partial class FrmValidationDialog
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
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            OkBtn = new CustomControls.RJControls.RJButton();
            LblMsg = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkViolet;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_cancel_25px;
            pictureBox1.Location = new Point(313, 0);
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
            panel1.Size = new Size(339, 29);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.warning;
            pictureBox2.Location = new Point(116, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // OkBtn
            // 
            OkBtn.BackColor = Color.DarkViolet;
            OkBtn.BackgroundColor = Color.DarkViolet;
            OkBtn.BorderColor = Color.DarkViolet;
            OkBtn.BorderRadius = 4;
            OkBtn.BorderSize = 0;
            OkBtn.Cursor = Cursors.Hand;
            OkBtn.FlatAppearance.BorderSize = 0;
            OkBtn.FlatStyle = FlatStyle.Flat;
            OkBtn.ForeColor = Color.White;
            OkBtn.Location = new Point(137, 135);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(63, 26);
            OkBtn.TabIndex = 3;
            OkBtn.Text = "Ok";
            OkBtn.TextColor = Color.White;
            OkBtn.UseVisualStyleBackColor = false;
            OkBtn.Click += OkBtn_Click;
            // 
            // LblMsg
            // 
            LblMsg.Dock = DockStyle.Fill;
            LblMsg.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblMsg.ForeColor = Color.Black;
            LblMsg.Location = new Point(0, 0);
            LblMsg.Name = "LblMsg";
            LblMsg.Size = new Size(336, 30);
            LblMsg.TabIndex = 2;
            LblMsg.Text = "Message Text";
            LblMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(LblMsg);
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(336, 30);
            panel2.TabIndex = 4;
            // 
            // FrmValidationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(339, 173);
            Controls.Add(panel2);
            Controls.Add(OkBtn);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmValidationDialog";
            Text = "FrmValidationDialog";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private CustomControls.RJControls.RJButton OkBtn;
        private Label LblMsg;
        private Panel panel2;
    }
}