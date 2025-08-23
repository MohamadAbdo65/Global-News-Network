namespace GlobalNewsNetwork.UserCTRls.Catagories
{
    partial class ctrlHashCategory
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
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryName.ForeColor = System.Drawing.Color.White;
            this.lblCategoryName.Location = new System.Drawing.Point(0, 0);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCategoryName.Size = new System.Drawing.Size(118, 44);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "# آخر الأخبار";
            this.lblCategoryName.Click += new System.EventHandler(this.lblCategoryName_Click);
            this.lblCategoryName.MouseEnter += new System.EventHandler(this.lblCategoryName_MouseEnter);
            this.lblCategoryName.MouseLeave += new System.EventHandler(this.lblCategoryName_MouseLeave);
            // 
            // ctrlHashCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.lblCategoryName);
            this.Font = new System.Drawing.Font("Alarabiya Font", 21.75F);
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Name = "ctrlHashCategory";
            this.Size = new System.Drawing.Size(60, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryName;
    }
}
