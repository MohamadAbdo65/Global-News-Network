using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.Globally;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalNewsNetwork.MainForms.HomePage
{
    public partial class frmNewsInfo : Form
    {
        public frmNewsInfo(clsNews news)
        {
            InitializeComponent();
            News = news;
            this.Text = News.NewsTitle;
        }

        private clsNews _News;
        public clsNews News
        {
            get { return  _News; }
            set { _News = value; }
        }



        private void frmNewsInfo_Load(object sender, EventArgs e)
        {
            lblNewsTitle.Text = News.NewsTitle;
            lblLocation.Text = clsCountries.FindCountry(News.CountryID).CountryName;
            lblJournalistName.Text = clsJournalists.FindByJournalistID(News.JournalistID).UserInfo.PersonInfo.FullName;
            lblPublishTime.Text = clsGlobalMethods.GetDifferenceBetweemDates(News.PublishDateTime , DateTime.Now);
            try { picbNEwsImage.ImageLocation = News.Image; } catch { }
            lblNewsContent.Text = News.NewsContent;


            News.CountaView();
        }
    }
}
