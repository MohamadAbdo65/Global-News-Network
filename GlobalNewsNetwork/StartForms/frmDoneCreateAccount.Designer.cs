namespace GlobalNewsNetwork.StartForms
{
    partial class frmDoneCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoneCreateAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateTheAccount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alarabiya Font", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "!  حسابك جاهز للاستخدام ";
            // 
            // btnCreateTheAccount
            // 
            this.btnCreateTheAccount.Animated = true;
            this.btnCreateTheAccount.BorderRadius = 15;
            this.btnCreateTheAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateTheAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateTheAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateTheAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateTheAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.btnCreateTheAccount.Font = new System.Drawing.Font("AlArabiya", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTheAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateTheAccount.Location = new System.Drawing.Point(274, 503);
            this.btnCreateTheAccount.Name = "btnCreateTheAccount";
            this.btnCreateTheAccount.Size = new System.Drawing.Size(293, 49);
            this.btnCreateTheAccount.TabIndex = 9;
            this.btnCreateTheAccount.Text = "سجل دخول الان";
            this.btnCreateTheAccount.Click += new System.EventHandler(this.btnCreateTheAccount_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 115);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(840, 336);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmDoneCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(839, 597);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnCreateTheAccount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoneCreateAccount";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoneCreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCreateTheAccount;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}