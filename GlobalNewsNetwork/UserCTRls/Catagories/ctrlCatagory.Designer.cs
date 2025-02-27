namespace GlobalNewsNetwork.UserCTRls
{
    partial class ctrlCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlCategory));
            this.chkbSeletc = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkbSeletc
            // 
            this.chkbSeletc.AutoSize = true;
            this.chkbSeletc.BackColor = System.Drawing.Color.Transparent;
            this.chkbSeletc.Font = new System.Drawing.Font("AlArabiya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkbSeletc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.chkbSeletc.Location = new System.Drawing.Point(48, 29);
            this.chkbSeletc.Name = "chkbSeletc";
            this.chkbSeletc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkbSeletc.Size = new System.Drawing.Size(93, 46);
            this.chkbSeletc.TabIndex = 0;
            this.chkbSeletc.Text = "إقتصاد";
            this.chkbSeletc.UseVisualStyleBackColor = false;
            this.chkbSeletc.CheckedChanged += new System.EventHandler(this.chkbSeletc_CheckedChanged);
            // 
            // ctrlCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.chkbSeletc);
            this.Name = "ctrlCategory";
            this.Size = new System.Drawing.Size(217, 120);
            this.Click += new System.EventHandler(this.ctrlCatagory_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbSeletc;
    }
}
