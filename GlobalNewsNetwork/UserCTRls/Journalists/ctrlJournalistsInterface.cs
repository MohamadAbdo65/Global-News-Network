using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.Globally;
using System;
using System.Windows.Forms;

namespace GlobalNewsNetwork.UserCTRls.Journalists
{
    public partial class ctrlJournalistsInterface : UserControl
    {
        public ctrlJournalistsInterface()
        {
            InitializeComponent();
        }

        private void ctrlJournalistsInterface_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = clsColorSettings.Heavenly;
        }

        private void ctrlJournalistsInterface_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = clsColorSettings.Navy;
        }

        private clsJournalists _JournalistsInfo;

        public clsJournalists JournalistInfo
        {
            get { return _JournalistsInfo; }
            set { _JournalistsInfo = value; }
        }


        public void LoadJournalistData(clsJournalists Journalist)
        {
            if (Journalist == null) return;

            JournalistInfo = Journalist;

           // lblJournalistName.Text = JournalistInfo.JournalistFullName;
            try { picbPersonImage.ImageLocation = JournalistInfo.UserInfo.PersonInfo.Image; } catch { }



        }

    }
}
