namespace GlobalNewsNetwork.MainForms
{
    partial class frmHomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.tabctrlHomePage = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.flpNews = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.tabFavorates = new System.Windows.Forms.TabPage();
            this.btnSaveChanges = new Guna.UI2.WinForms.Guna2Button();
            this.flpFavoriteUser = new System.Windows.Forms.FlowLayoutPanel();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.flpProfile = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSaveUpdates = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbEmail = new GlobalNewsNetwork.CstmCTRLs.cstmTextBox();
            this.txtbFirstName = new GlobalNewsNetwork.CstmCTRLs.cstmTextBox();
            this.txtbLastName = new GlobalNewsNetwork.CstmCTRLs.cstmTextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbbCountry = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRemoveImage = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetImage = new Guna.UI2.WinForms.Guna2Button();
            this.picbUserImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.rbtnFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtpBarthofDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabBookmark = new System.Windows.Forms.TabPage();
            this.flpBookmarkNews = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flpJournalists = new System.Windows.Forms.FlowLayoutPanel();
            this.ctrlJournalistsInterface1 = new GlobalNewsNetwork.UserCTRls.Journalists.ctrlJournalistsInterface();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.imglstTabctrlMainpage = new System.Windows.Forms.ImageList(this.components);
            this.picPersonalImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblPersonalName = new System.Windows.Forms.Label();
            this.btnNotices = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSearshNews = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtbSearchNews = new GlobalNewsNetwork.CstmCTRLs.cstmTextBox();
            this.tabctrlHomePage.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabFavorates.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.flpProfile.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbUserImage)).BeginInit();
            this.tabBookmark.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flpJournalists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlHomePage
            // 
            this.tabctrlHomePage.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabctrlHomePage.Controls.Add(this.tabHome);
            this.tabctrlHomePage.Controls.Add(this.tabFavorates);
            this.tabctrlHomePage.Controls.Add(this.tabProfile);
            this.tabctrlHomePage.Controls.Add(this.tabBookmark);
            this.tabctrlHomePage.Controls.Add(this.tabPage2);
            this.tabctrlHomePage.Controls.Add(this.tabPage3);
            this.tabctrlHomePage.Controls.Add(this.tabPage4);
            this.tabctrlHomePage.Controls.Add(this.tabPage5);
            this.tabctrlHomePage.Controls.Add(this.tabPage6);
            this.tabctrlHomePage.Controls.Add(this.tabPage7);
            this.tabctrlHomePage.Controls.Add(this.tabPage8);
            this.tabctrlHomePage.Controls.Add(this.tabPage9);
            this.tabctrlHomePage.Controls.Add(this.tabPage10);
            this.tabctrlHomePage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabctrlHomePage.Font = new System.Drawing.Font("AlArabiya", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctrlHomePage.ImageList = this.imglstTabctrlMainpage;
            this.tabctrlHomePage.ItemSize = new System.Drawing.Size(160, 60);
            this.tabctrlHomePage.Location = new System.Drawing.Point(0, 99);
            this.tabctrlHomePage.Name = "tabctrlHomePage";
            this.tabctrlHomePage.SelectedIndex = 0;
            this.tabctrlHomePage.Size = new System.Drawing.Size(1420, 787);
            this.tabctrlHomePage.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabctrlHomePage.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabctrlHomePage.TabButtonHoverState.Font = new System.Drawing.Font("Alarabiya Font", 13F);
            this.tabctrlHomePage.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabctrlHomePage.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabctrlHomePage.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabctrlHomePage.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(81)))));
            this.tabctrlHomePage.TabButtonIdleState.Font = new System.Drawing.Font("Alarabiya Font", 13F);
            this.tabctrlHomePage.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabctrlHomePage.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(81)))));
            this.tabctrlHomePage.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabctrlHomePage.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(81)))));
            this.tabctrlHomePage.TabButtonSelectedState.Font = new System.Drawing.Font("Alarabiya Font", 13F);
            this.tabctrlHomePage.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabctrlHomePage.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.tabctrlHomePage.TabButtonSize = new System.Drawing.Size(160, 60);
            this.tabctrlHomePage.TabIndex = 1;
            this.tabctrlHomePage.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabctrlHomePage.SelectedIndexChanged += new System.EventHandler(this.tabctrlCreateAccount_SelectedIndexChanged);
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabHome.Controls.Add(this.flpNews);
            this.tabHome.Controls.Add(this.flpCategories);
            this.tabHome.Font = new System.Drawing.Font("AlArabiya", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHome.ImageKey = "Home.png";
            this.tabHome.Location = new System.Drawing.Point(164, 4);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1252, 779);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "الصفحة الرئيسية";
            // 
            // flpNews
            // 
            this.flpNews.AllowDrop = true;
            this.flpNews.AutoScroll = true;
            this.flpNews.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpNews.Location = new System.Drawing.Point(3, 102);
            this.flpNews.Margin = new System.Windows.Forms.Padding(10);
            this.flpNews.Name = "flpNews";
            this.flpNews.Padding = new System.Windows.Forms.Padding(5);
            this.flpNews.Size = new System.Drawing.Size(1246, 674);
            this.flpNews.TabIndex = 1;
            // 
            // flpCategories
            // 
            this.flpCategories.AllowDrop = true;
            this.flpCategories.AutoScroll = true;
            this.flpCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.flpCategories.Location = new System.Drawing.Point(6, 6);
            this.flpCategories.Name = "flpCategories";
            this.flpCategories.Size = new System.Drawing.Size(1238, 90);
            this.flpCategories.TabIndex = 0;
            this.flpCategories.WrapContents = false;
            // 
            // tabFavorates
            // 
            this.tabFavorates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabFavorates.Controls.Add(this.btnSaveChanges);
            this.tabFavorates.Controls.Add(this.flpFavoriteUser);
            this.tabFavorates.ImageKey = "Star.png";
            this.tabFavorates.Location = new System.Drawing.Point(164, 4);
            this.tabFavorates.Name = "tabFavorates";
            this.tabFavorates.Padding = new System.Windows.Forms.Padding(3);
            this.tabFavorates.Size = new System.Drawing.Size(1252, 779);
            this.tabFavorates.TabIndex = 1;
            this.tabFavorates.Text = "اهتماماتك";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Animated = true;
            this.btnSaveChanges.BorderRadius = 15;
            this.btnSaveChanges.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveChanges.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveChanges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveChanges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveChanges.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.btnSaveChanges.Font = new System.Drawing.Font("AlArabiya", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(511, 719);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(231, 45);
            this.btnSaveChanges.TabIndex = 9;
            this.btnSaveChanges.Text = "حفظ التغييرات";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // flpFavoriteUser
            // 
            this.flpFavoriteUser.AutoScroll = true;
            this.flpFavoriteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.flpFavoriteUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpFavoriteUser.Location = new System.Drawing.Point(3, 3);
            this.flpFavoriteUser.Name = "flpFavoriteUser";
            this.flpFavoriteUser.Size = new System.Drawing.Size(1246, 699);
            this.flpFavoriteUser.TabIndex = 0;
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabProfile.Controls.Add(this.flpProfile);
            this.tabProfile.ImageKey = "Profile.png";
            this.tabProfile.Location = new System.Drawing.Point(164, 4);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(1252, 779);
            this.tabProfile.TabIndex = 3;
            this.tabProfile.Text = "الملف الشخصي";
            // 
            // flpProfile
            // 
            this.flpProfile.AutoScroll = true;
            this.flpProfile.Controls.Add(this.pnlProfile);
            this.flpProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProfile.Location = new System.Drawing.Point(3, 3);
            this.flpProfile.Name = "flpProfile";
            this.flpProfile.Size = new System.Drawing.Size(1246, 773);
            this.flpProfile.TabIndex = 0;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.pnlProfile.Controls.Add(this.btnSaveUpdates);
            this.pnlProfile.Controls.Add(this.btnDeleteAccount);
            this.pnlProfile.Controls.Add(this.guna2HtmlLabel2);
            this.pnlProfile.Controls.Add(this.txtbEmail);
            this.pnlProfile.Controls.Add(this.txtbFirstName);
            this.pnlProfile.Controls.Add(this.txtbLastName);
            this.pnlProfile.Controls.Add(this.guna2HtmlLabel5);
            this.pnlProfile.Controls.Add(this.cmbbCountry);
            this.pnlProfile.Controls.Add(this.btnRemoveImage);
            this.pnlProfile.Controls.Add(this.btnSetImage);
            this.pnlProfile.Controls.Add(this.picbUserImage);
            this.pnlProfile.Controls.Add(this.rbtnFemale);
            this.pnlProfile.Controls.Add(this.rbtnMale);
            this.pnlProfile.Controls.Add(this.dtpBarthofDate);
            this.pnlProfile.Controls.Add(this.label3);
            this.pnlProfile.Controls.Add(this.label2);
            this.pnlProfile.Controls.Add(this.guna2HtmlLabel1);
            this.pnlProfile.Controls.Add(this.guna2HtmlLabel4);
            this.pnlProfile.Location = new System.Drawing.Point(3, 3);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(1240, 764);
            this.pnlProfile.TabIndex = 0;
            // 
            // btnSaveUpdates
            // 
            this.btnSaveUpdates.Animated = true;
            this.btnSaveUpdates.BorderRadius = 15;
            this.btnSaveUpdates.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveUpdates.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveUpdates.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveUpdates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveUpdates.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.btnSaveUpdates.Font = new System.Drawing.Font("Hacen Tunisia", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveUpdates.ForeColor = System.Drawing.Color.White;
            this.btnSaveUpdates.Location = new System.Drawing.Point(518, 682);
            this.btnSaveUpdates.Name = "btnSaveUpdates";
            this.btnSaveUpdates.Size = new System.Drawing.Size(202, 43);
            this.btnSaveUpdates.TabIndex = 43;
            this.btnSaveUpdates.Text = "حفظ التعديلات";
            this.btnSaveUpdates.Click += new System.EventHandler(this.btnSaveUpdates_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Animated = true;
            this.btnDeleteAccount.BorderRadius = 15;
            this.btnDeleteAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.btnDeleteAccount.Font = new System.Drawing.Font("Hacen Tunisia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(1127, 7);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(106, 31);
            this.btnDeleteAccount.TabIndex = 42;
            this.btnDeleteAccount.Text = "حذف الحساب";
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Enabled = false;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Hacen Tunisia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(510, 504);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(73, 40);
            this.guna2HtmlLabel2.TabIndex = 39;
            this.guna2HtmlLabel2.Text = ": الإيميل";
            // 
            // txtbEmail
            // 
            this.txtbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtbEmail.BorderRadius = 15;
            this.txtbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbEmail.DefaultText = "";
            this.txtbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbEmail.EnableSpace = false;
            this.txtbEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbEmail.InputType = GlobalNewsNetwork.CstmCTRLs.cstmTextBox.enInputType.Email;
            this.txtbEmail.Location = new System.Drawing.Point(177, 547);
            this.txtbEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.PasswordChar = '\0';
            this.txtbEmail.PlaceholderText = "";
            this.txtbEmail.Required = true;
            this.txtbEmail.SelectedText = "";
            this.txtbEmail.Size = new System.Drawing.Size(415, 53);
            this.txtbEmail.TabIndex = 41;
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtbFirstName.BorderRadius = 15;
            this.txtbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbFirstName.DefaultText = "";
            this.txtbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbFirstName.EnableSpace = false;
            this.txtbFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbFirstName.Font = new System.Drawing.Font("Hacen Tunisia", 14.25F);
            this.txtbFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbFirstName.InputType = GlobalNewsNetwork.CstmCTRLs.cstmTextBox.enInputType.Text;
            this.txtbFirstName.Location = new System.Drawing.Point(638, 278);
            this.txtbFirstName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.PasswordChar = '\0';
            this.txtbFirstName.PlaceholderText = "";
            this.txtbFirstName.Required = true;
            this.txtbFirstName.SelectedText = "";
            this.txtbFirstName.Size = new System.Drawing.Size(415, 53);
            this.txtbFirstName.TabIndex = 37;
            // 
            // txtbLastName
            // 
            this.txtbLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtbLastName.BorderRadius = 15;
            this.txtbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbLastName.DefaultText = "";
            this.txtbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbLastName.EnableSpace = false;
            this.txtbLastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbLastName.Font = new System.Drawing.Font("Hacen Tunisia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbLastName.InputType = GlobalNewsNetwork.CstmCTRLs.cstmTextBox.enInputType.Text;
            this.txtbLastName.Location = new System.Drawing.Point(177, 278);
            this.txtbLastName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.PasswordChar = '\0';
            this.txtbLastName.PlaceholderText = "";
            this.txtbLastName.Required = true;
            this.txtbLastName.SelectedText = "";
            this.txtbLastName.Size = new System.Drawing.Size(415, 53);
            this.txtbLastName.TabIndex = 36;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Enabled = false;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Hacen Tunisia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(994, 506);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(44, 36);
            this.guna2HtmlLabel5.TabIndex = 35;
            this.guna2HtmlLabel5.Text = ": البلد";
            // 
            // cmbbCountry
            // 
            this.cmbbCountry.BackColor = System.Drawing.Color.Transparent;
            this.cmbbCountry.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbbCountry.BorderRadius = 15;
            this.cmbbCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbCountry.DropDownHeight = 300;
            this.cmbbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbCountry.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbbCountry.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbCountry.Font = new System.Drawing.Font("Hacen Tunisia", 15.75F);
            this.cmbbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.cmbbCountry.IntegralHeight = false;
            this.cmbbCountry.ItemHeight = 45;
            this.cmbbCountry.Location = new System.Drawing.Point(686, 548);
            this.cmbbCountry.MaxDropDownItems = 4;
            this.cmbbCountry.Name = "cmbbCountry";
            this.cmbbCountry.Size = new System.Drawing.Size(367, 51);
            this.cmbbCountry.TabIndex = 34;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Animated = true;
            this.btnRemoveImage.BorderRadius = 15;
            this.btnRemoveImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnRemoveImage.Font = new System.Drawing.Font("Hacen Tunisia", 17.25F);
            this.btnRemoveImage.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveImage.Location = new System.Drawing.Point(300, 121);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(176, 36);
            this.btnRemoveImage.TabIndex = 33;
            this.btnRemoveImage.Text = "إزالة الصورة";
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnSetImage
            // 
            this.btnSetImage.Animated = true;
            this.btnSetImage.BorderRadius = 15;
            this.btnSetImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(159)))));
            this.btnSetImage.Font = new System.Drawing.Font("Hacen Tunisia", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetImage.ForeColor = System.Drawing.Color.White;
            this.btnSetImage.Location = new System.Drawing.Point(300, 67);
            this.btnSetImage.Name = "btnSetImage";
            this.btnSetImage.Size = new System.Drawing.Size(176, 36);
            this.btnSetImage.TabIndex = 32;
            this.btnSetImage.Text = "تعيين صورة";
            this.btnSetImage.Click += new System.EventHandler(this.btnSetImage_Click);
            // 
            // picbUserImage
            // 
            this.picbUserImage.ImageRotate = 0F;
            this.picbUserImage.Location = new System.Drawing.Point(542, 33);
            this.picbUserImage.Name = "picbUserImage";
            this.picbUserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picbUserImage.Size = new System.Drawing.Size(155, 155);
            this.picbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbUserImage.TabIndex = 31;
            this.picbUserImage.TabStop = false;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.rbtnFemale.CheckedState.BorderThickness = 0;
            this.rbtnFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.rbtnFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnFemale.CheckedState.InnerOffset = -4;
            this.rbtnFemale.Font = new System.Drawing.Font("Hacen Tunisia", 17F);
            this.rbtnFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.rbtnFemale.Location = new System.Drawing.Point(759, 417);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnFemale.Size = new System.Drawing.Size(72, 41);
            this.rbtnFemale.TabIndex = 30;
            this.rbtnFemale.Text = "أنثى";
            this.rbtnFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(81)))));
            this.rbtnFemale.UncheckedState.BorderThickness = 2;
            this.rbtnFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.rbtnMale.CheckedState.BorderThickness = 0;
            this.rbtnMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.rbtnMale.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(81)))));
            this.rbtnMale.CheckedState.InnerOffset = -4;
            this.rbtnMale.Font = new System.Drawing.Font("Hacen Tunisia", 17F);
            this.rbtnMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.rbtnMale.Location = new System.Drawing.Point(859, 417);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnMale.Size = new System.Drawing.Size(67, 41);
            this.rbtnMale.TabIndex = 29;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "ذكر";
            this.rbtnMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(81)))));
            this.rbtnMale.UncheckedState.BorderThickness = 2;
            this.rbtnMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // dtpBarthofDate
            // 
            this.dtpBarthofDate.BorderRadius = 15;
            this.dtpBarthofDate.Checked = true;
            this.dtpBarthofDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dtpBarthofDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBarthofDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dtpBarthofDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBarthofDate.Location = new System.Drawing.Point(184, 411);
            this.dtpBarthofDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBarthofDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBarthofDate.Name = "dtpBarthofDate";
            this.dtpBarthofDate.Size = new System.Drawing.Size(277, 44);
            this.dtpBarthofDate.TabIndex = 28;
            this.dtpBarthofDate.Value = new System.DateTime(2024, 11, 10, 20, 4, 11, 476);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hacen Tunisia", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(467, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 38);
            this.label3.TabIndex = 27;
            this.label3.Text = "تاريخ الميلاد :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hacen Tunisia", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(957, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "الجنس :";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Enabled = false;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Hacen Tunisia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(478, 233);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(99, 36);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = ": الاخير الاسم";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Enabled = false;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Hacen Tunisia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(942, 233);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(96, 36);
            this.guna2HtmlLabel4.TabIndex = 25;
            this.guna2HtmlLabel4.Text = ": الاول الاسم";
            // 
            // tabBookmark
            // 
            this.tabBookmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabBookmark.Controls.Add(this.flpBookmarkNews);
            this.tabBookmark.ImageKey = "Bookmark.png";
            this.tabBookmark.Location = new System.Drawing.Point(164, 4);
            this.tabBookmark.Name = "tabBookmark";
            this.tabBookmark.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookmark.Size = new System.Drawing.Size(1252, 779);
            this.tabBookmark.TabIndex = 4;
            this.tabBookmark.Text = "الإشارات المرجعية";
            // 
            // flpBookmarkNews
            // 
            this.flpBookmarkNews.AllowDrop = true;
            this.flpBookmarkNews.AutoScroll = true;
            this.flpBookmarkNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBookmarkNews.Location = new System.Drawing.Point(3, 3);
            this.flpBookmarkNews.Margin = new System.Windows.Forms.Padding(10);
            this.flpBookmarkNews.Name = "flpBookmarkNews";
            this.flpBookmarkNews.Padding = new System.Windows.Forms.Padding(5);
            this.flpBookmarkNews.Size = new System.Drawing.Size(1246, 773);
            this.flpBookmarkNews.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabPage2.Controls.Add(this.flpJournalists);
            this.tabPage2.ImageKey = "Journalist.png";
            this.tabPage2.Location = new System.Drawing.Point(164, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1252, 779);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "الصحفيين";
            // 
            // flpJournalists
            // 
            this.flpJournalists.Controls.Add(this.ctrlJournalistsInterface1);
            this.flpJournalists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpJournalists.Location = new System.Drawing.Point(3, 3);
            this.flpJournalists.Name = "flpJournalists";
            this.flpJournalists.Size = new System.Drawing.Size(1246, 773);
            this.flpJournalists.TabIndex = 0;
            // 
            // ctrlJournalistsInterface1
            // 
            this.ctrlJournalistsInterface1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(81)))));
            this.ctrlJournalistsInterface1.JournalistInfo = null;
            this.ctrlJournalistsInterface1.Location = new System.Drawing.Point(861, 5);
            this.ctrlJournalistsInterface1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ctrlJournalistsInterface1.Name = "ctrlJournalistsInterface1";
            this.ctrlJournalistsInterface1.Size = new System.Drawing.Size(382, 254);
            this.ctrlJournalistsInterface1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabPage3.ImageKey = "News Agency.png";
            this.tabPage3.Location = new System.Drawing.Point(164, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1252, 779);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "وكالات الأنباء";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabPage4.ImageKey = "Join.png";
            this.tabPage4.Location = new System.Drawing.Point(164, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1252, 779);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "انضم للشبكة";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabPage5.ImageKey = "Applications.png";
            this.tabPage5.Location = new System.Drawing.Point(164, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1252, 779);
            this.tabPage5.TabIndex = 8;
            this.tabPage5.Text = "إدارة الطلبات";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabPage6.ImageKey = "Users.png";
            this.tabPage6.Location = new System.Drawing.Point(164, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1252, 779);
            this.tabPage6.TabIndex = 9;
            this.tabPage6.Text = "إدارة المستخدمين";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabPage7.ImageKey = "Journalist.png";
            this.tabPage7.Location = new System.Drawing.Point(164, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1252, 779);
            this.tabPage7.TabIndex = 10;
            this.tabPage7.Text = "إدارة الصحفيين";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabPage8.ImageKey = "Admins.png";
            this.tabPage8.Location = new System.Drawing.Point(164, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1252, 779);
            this.tabPage8.TabIndex = 11;
            this.tabPage8.Text = "إدارة المشرفين";
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabPage9.ImageIndex = 11;
            this.tabPage9.Location = new System.Drawing.Point(164, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1252, 779);
            this.tabPage9.TabIndex = 12;
            this.tabPage9.Text = "إدارة التقنيين";
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabPage10.ImageKey = "icons8-event-96.png";
            this.tabPage10.Location = new System.Drawing.Point(164, 4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1252, 779);
            this.tabPage10.TabIndex = 13;
            this.tabPage10.Text = "إدارة الأحداث";
            // 
            // imglstTabctrlMainpage
            // 
            this.imglstTabctrlMainpage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTabctrlMainpage.ImageStream")));
            this.imglstTabctrlMainpage.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTabctrlMainpage.Images.SetKeyName(0, "Home.png");
            this.imglstTabctrlMainpage.Images.SetKeyName(1, "Star.png");
            this.imglstTabctrlMainpage.Images.SetKeyName(2, "Profile.png");
            this.imglstTabctrlMainpage.Images.SetKeyName(3, "Bookmark.png");
            this.imglstTabctrlMainpage.Images.SetKeyName(4, "Journalist.png");
            this.imglstTabctrlMainpage.Images.SetKeyName(5, "News Agency.png");
            this.imglstTabctrlMainpage.Images.SetKeyName(6, "Join.png");
            this.imglstTabctrlMainpage.Images.SetKeyName(7, "Applications.png");
            this.imglstTabctrlMainpage.Images.SetKeyName(8, "Users.png");
            this.imglstTabctrlMainpage.Images.SetKeyName(9, "Journalist.png");
            this.imglstTabctrlMainpage.Images.SetKeyName(10, "Admins.png");
            this.imglstTabctrlMainpage.Images.SetKeyName(11, "Tech.png");
            this.imglstTabctrlMainpage.Images.SetKeyName(12, "icons8-event-96.png");
            // 
            // picPersonalImage
            // 
            this.picPersonalImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPersonalImage.Image = ((System.Drawing.Image)(resources.GetObject("picPersonalImage.Image")));
            this.picPersonalImage.ImageRotate = 0F;
            this.picPersonalImage.Location = new System.Drawing.Point(50, 8);
            this.picPersonalImage.Name = "picPersonalImage";
            this.picPersonalImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picPersonalImage.Size = new System.Drawing.Size(55, 55);
            this.picPersonalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonalImage.TabIndex = 2;
            this.picPersonalImage.TabStop = false;
            this.picPersonalImage.Click += new System.EventHandler(this.picPersonalImage_Click);
            // 
            // lblPersonalName
            // 
            this.lblPersonalName.AutoSize = true;
            this.lblPersonalName.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonalName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPersonalName.Font = new System.Drawing.Font("Hacen Tunisia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalName.Location = new System.Drawing.Point(51, 65);
            this.lblPersonalName.Name = "lblPersonalName";
            this.lblPersonalName.Size = new System.Drawing.Size(53, 31);
            this.lblPersonalName.TabIndex = 3;
            this.lblPersonalName.Text = "محمد";
            this.lblPersonalName.Click += new System.EventHandler(this.picPersonalImage_Click);
            // 
            // btnNotices
            // 
            this.btnNotices.BackColor = System.Drawing.Color.Transparent;
            this.btnNotices.CheckedState.ImageSize = new System.Drawing.Size(47, 47);
            this.btnNotices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotices.HoverState.ImageSize = new System.Drawing.Size(46, 46);
            this.btnNotices.Image = ((System.Drawing.Image)(resources.GetObject("btnNotices.Image")));
            this.btnNotices.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNotices.ImageRotate = 0F;
            this.btnNotices.ImageSize = new System.Drawing.Size(45, 45);
            this.btnNotices.Location = new System.Drawing.Point(1364, 28);
            this.btnNotices.Name = "btnNotices";
            this.btnNotices.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.btnNotices.ShadowDecoration.BorderRadius = 5;
            this.btnNotices.ShadowDecoration.Depth = 3;
            this.btnNotices.ShadowDecoration.Enabled = true;
            this.btnNotices.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNotices.Size = new System.Drawing.Size(45, 45);
            this.btnNotices.TabIndex = 4;
            // 
            // btnSearshNews
            // 
            this.btnSearshNews.BackColor = System.Drawing.Color.Transparent;
            this.btnSearshNews.CheckedState.ImageSize = new System.Drawing.Size(47, 47);
            this.btnSearshNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearshNews.HoverState.ImageSize = new System.Drawing.Size(46, 46);
            this.btnSearshNews.Image = ((System.Drawing.Image)(resources.GetObject("btnSearshNews.Image")));
            this.btnSearshNews.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearshNews.ImageRotate = 0F;
            this.btnSearshNews.ImageSize = new System.Drawing.Size(45, 45);
            this.btnSearshNews.Location = new System.Drawing.Point(429, 28);
            this.btnSearshNews.Name = "btnSearshNews";
            this.btnSearshNews.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.btnSearshNews.ShadowDecoration.BorderRadius = 5;
            this.btnSearshNews.ShadowDecoration.Depth = 3;
            this.btnSearshNews.ShadowDecoration.Enabled = true;
            this.btnSearshNews.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearshNews.Size = new System.Drawing.Size(45, 45);
            this.btnSearshNews.TabIndex = 6;
            this.btnSearshNews.Click += new System.EventHandler(this.btnSearshNews_Click);
            // 
            // txtbSearchNews
            // 
            this.txtbSearchNews.BorderRadius = 8;
            this.txtbSearchNews.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbSearchNews.DefaultText = "";
            this.txtbSearchNews.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbSearchNews.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbSearchNews.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbSearchNews.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbSearchNews.EnableSpace = false;
            this.txtbSearchNews.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtbSearchNews.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearchNews.Font = new System.Drawing.Font("Alarabiya Font", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtbSearchNews.ForeColor = System.Drawing.Color.White;
            this.txtbSearchNews.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearchNews.InputType = GlobalNewsNetwork.CstmCTRLs.cstmTextBox.enInputType.Normal;
            this.txtbSearchNews.Location = new System.Drawing.Point(490, 28);
            this.txtbSearchNews.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbSearchNews.Name = "txtbSearchNews";
            this.txtbSearchNews.PasswordChar = '\0';
            this.txtbSearchNews.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(81)))));
            this.txtbSearchNews.PlaceholderText = "";
            this.txtbSearchNews.Required = false;
            this.txtbSearchNews.SelectedText = "";
            this.txtbSearchNews.Size = new System.Drawing.Size(601, 45);
            this.txtbSearchNews.TabIndex = 5;
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1420, 886);
            this.Controls.Add(this.btnSearshNews);
            this.Controls.Add(this.txtbSearchNews);
            this.Controls.Add(this.btnNotices);
            this.Controls.Add(this.lblPersonalName);
            this.Controls.Add(this.picPersonalImage);
            this.Controls.Add(this.tabctrlHomePage);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmHomePage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الصفحة الرئيسية";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHomePage_FormClosed);
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHomePage_KeyDown);
            this.tabctrlHomePage.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabFavorates.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.flpProfile.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbUserImage)).EndInit();
            this.tabBookmark.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flpJournalists.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPersonalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HshctgMostViews_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabctrlHomePage;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabFavorates;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabBookmark;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.ImageList imglstTabctrlMainpage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picPersonalImage;
        private System.Windows.Forms.Label lblPersonalName;
        private Guna.UI2.WinForms.Guna2ImageButton btnNotices;
        private CstmCTRLs.cstmTextBox txtbSearchNews;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearshNews;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private System.Windows.Forms.FlowLayoutPanel flpNews;
        private System.Windows.Forms.FlowLayoutPanel flpFavoriteUser;
        private Guna.UI2.WinForms.Guna2Button btnSaveChanges;
        private System.Windows.Forms.FlowLayoutPanel flpProfile;
        private Guna.UI2.WinForms.Guna2Panel pnlProfile;
        private CstmCTRLs.cstmTextBox txtbFirstName;
        private CstmCTRLs.cstmTextBox txtbLastName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbbCountry;
        private Guna.UI2.WinForms.Guna2Button btnRemoveImage;
        private Guna.UI2.WinForms.Guna2Button btnSetImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picbUserImage;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnFemale;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnMale;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBarthofDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private CstmCTRLs.cstmTextBox txtbEmail;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAccount;
        private Guna.UI2.WinForms.Guna2Button btnSaveUpdates;
        private System.Windows.Forms.FlowLayoutPanel flpBookmarkNews;
        private System.Windows.Forms.FlowLayoutPanel flpJournalists;
        private UserCTRls.Journalists.ctrlJournalistsInterface ctrlJournalistsInterface1;
    }
}