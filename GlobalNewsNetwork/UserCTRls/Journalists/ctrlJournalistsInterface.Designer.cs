namespace GlobalNewsNetwork.UserCTRls.Journalists
{
    partial class ctrlJournalistsInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlJournalistsInterface));
            this.picbPersonImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblJournalistName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picbPersonImage
            // 
            this.picbPersonImage.Image = ((System.Drawing.Image)(resources.GetObject("picbPersonImage.Image")));
            this.picbPersonImage.ImageRotate = 0F;
            this.picbPersonImage.Location = new System.Drawing.Point(145, 14);
            this.picbPersonImage.Name = "picbPersonImage";
            this.picbPersonImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picbPersonImage.Size = new System.Drawing.Size(117, 80);
            this.picbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbPersonImage.TabIndex = 0;
            this.picbPersonImage.TabStop = false;
            this.picbPersonImage.MouseEnter += new System.EventHandler(this.ctrlJournalistsInterface_MouseEnter);
            this.picbPersonImage.MouseLeave += new System.EventHandler(this.ctrlJournalistsInterface_MouseLeave);
            // 
            // lblJournalistName
            // 
            this.lblJournalistName.AutoSize = true;
            this.lblJournalistName.Font = new System.Drawing.Font("AlArabiya", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJournalistName.ForeColor = System.Drawing.Color.White;
            this.lblJournalistName.Location = new System.Drawing.Point(35, 109);
            this.lblJournalistName.Name = "lblJournalistName";
            this.lblJournalistName.Size = new System.Drawing.Size(330, 61);
            this.lblJournalistName.TabIndex = 1;
            this.lblJournalistName.Text = "محمد علي - صحفي مستقل";
            this.lblJournalistName.MouseEnter += new System.EventHandler(this.ctrlJournalistsInterface_MouseEnter);
            this.lblJournalistName.MouseLeave += new System.EventHandler(this.ctrlJournalistsInterface_MouseLeave);
            // 
            // ctrlJournalistsInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.lblJournalistName);
            this.Controls.Add(this.picbPersonImage);
            this.Name = "ctrlJournalistsInterface";
            this.Size = new System.Drawing.Size(419, 207);
            this.MouseEnter += new System.EventHandler(this.ctrlJournalistsInterface_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ctrlJournalistsInterface_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox picbPersonImage;
        private System.Windows.Forms.Label lblJournalistName;
    }
}
