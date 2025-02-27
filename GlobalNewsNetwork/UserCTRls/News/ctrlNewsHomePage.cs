using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.Globally;
using GlobalNewsNetwork.MainForms.HomePage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalNewsNetwork.UserCTRls.News
{
    public partial class ctrlNewsHomePage : UserControl
    {
        public ctrlNewsHomePage()
        {
            InitializeComponent();
        }

        clsNews _News = new clsNews();
        public clsNews News
        { 
            get { return _News; } 
            set { _News = value; }
        }


        public void LoadNewsInfo(clsNews news)
        {
            if (news == null) return;

            News = news;

            lblTitle.Text = News.NewsTitle;
            lblLocation.Text = clsCountries.FindCountry(News.CountryID).CountryName; 
            lblViews.Text = News.CountView.ToString() + " مشاهد";
            lblPublishTime.Text = clsGlobalMethods.GetDifferenceBetweemDates(News.PublishDateTime, DateTime.Now);

            if (clsBookmarks.BookmarkIsExist(clsCurrentUser.User.UserID , News.NewsID))
                btnAddBookmark.Image = Image.FromFile
                    (@"D:\Global News Network Project\icons of project\Bookmark Red.png");


            try { picbNewsImage.ImageLocation = News.Image; } catch { }

        }


        bool _AddRemove_Bookmark = false;

        private void btnAddBookmark_Click(object sender, EventArgs e)
        {
            if(clsBookmarks.BookmarkIsExist(clsCurrentUser.User.UserID , this.News.NewsID))
                _AddRemove_Bookmark = true;

            if (!_AddRemove_Bookmark)
            {
                if (clsBookmarks.AddBookmark(clsCurrentUser.User.UserID, this.News.NewsID) != -1)
                {
                    btnAddBookmark.Image = Image.FromFile(@"D:\Global News Network Project\icons of project\Bookmark Red.png");
                    _AddRemove_Bookmark = false ;
                }
            }
            else
            {
                if (clsBookmarks.DeleteBookmark(clsCurrentUser.User.UserID, this.News.NewsID))
                {
                    btnAddBookmark.Image = Image.FromFile(@"D:\Global News Network Project\icons of project\icons8-bookmark-96 (1).png");
                    _AddRemove_Bookmark = true  ;
                }
            }
        }

        private void ctrlNewsHomePage_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(80,80,80);
        }

        private void ctrlNewsHomePage_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void ctrlNewsHomePage_Click(object sender, EventArgs e)
        {

            frmNewsInfo frm = new frmNewsInfo(News);
            frm.Show();
        }
    }
}
