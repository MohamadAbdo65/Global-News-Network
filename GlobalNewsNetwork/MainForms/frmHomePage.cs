using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.Globally;
using GlobalNewsNetwork.UserCTRls.Catagories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalNewsNetwork.MainForms
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }
        private void frmHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void _UpdatePersonInfo(object sender , NewPersonInfoEvetnArgs e)
        {
            picPersonalImage.Image = clsSecurity.GetDectyptionImage(e.Person.Image);
            lblPersonalName.Text = e.Person.FirstName;
        }

        private void _LoadPersonalInfo()
        {
            UpdatedPersonInfo += _UpdatePersonInfo;

            string ImagePath = "";
            string PersonName = "";

            Parallel.Invoke(
                () => {  ImagePath = clsCurrentUser.Person.Image.ToString(); },
                () => {  PersonName = clsCurrentUser.Person.FirstName; }   );

            picPersonalImage.Image = clsSecurity.GetDectyptionImage(ImagePath);
            lblPersonalName.Text = PersonName;
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            _LoadPersonalInfo();

            // this tab for all users
            _LoadHomeTab();
        }

        private void btnSearshNews_Click(object sender, EventArgs e)
        {
            tabctrlHomePage.SelectedIndex = 0;
            _LoadNews(clsNews.GetAllNews(txtbSearchNews.Text));
            foreach (var CTRL in flpCategories.Controls)
            {
                ctrlHashCategory Hashcategory = (ctrlHashCategory)CTRL;
                Hashcategory.Selected = false;
            }
        }

        private void frmHomePage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearshNews_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }



        // when change tab : 
        private void tabctrlCreateAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrlHomePage.SelectedIndex == 0)
                _LoadHomeTab();

            else if (tabctrlHomePage.SelectedIndex == 1)
                _LoadFavoriteTab();

            else if (tabctrlHomePage.SelectedIndex == 2)
                _LoadProfileInfoTab();

            else if (tabctrlHomePage.SelectedIndex == 3)
                _LoadBookmarkNewsTab();

            else if (tabctrlHomePage.SelectedIndex == 4)
                _LoadJournalistsTab();



        }

        private void picPersonalImage_Click(object sender, EventArgs e)
        {
            tabctrlHomePage.SelectedIndex = 2;
        }

    }
}
