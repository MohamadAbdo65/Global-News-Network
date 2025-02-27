using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.UserCTRls.News;
using System;
using System.Data;
using System.Windows.Forms;

namespace GlobalNewsNetwork.MainForms
{
    // bookmark tab
    public partial class frmHomePage
    {
        private void _LoadBookmarkNewsTab()
        {
            _LoadBookmarksNews();
        }

        private void _NotBookmarkExist()
        {
            Label label = new Label();

            label.AutoSize = true;
            label.Font = new System.Drawing.Font("AlArabiya", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(34, 5);
            label.Name = "label1";
            label.Size = new System.Drawing.Size(1199, 78);
            label.TabIndex = 0;
            label.Text = "لا توجد إشارات مرجعية حتى الآن ، يمكنك حفظ الأخبار التي تهمك هنا للوصول إليها بسهولة لاحقًا.\r\n";

            flpBookmarkNews.Controls.Add(label);
        }

        private void _LoadBookmarksNews() 
        {
            flpBookmarkNews.Controls.Clear();

            _NotBookmarkExist();

            DataTable NewsTable = clsBookmarks.GetAllBookmarksForUser(clsCurrentUser.User.UserID);

            if (NewsTable == null || NewsTable.Rows.Count <= 0) return;

            flpBookmarkNews.Controls.Clear();

            foreach (DataRow NewsRow in NewsTable.Rows)
            {
                clsNews news = new clsNews();

                news.NewsID = (int)NewsRow["NewsID"];
                news.NewsTitle = (string)NewsRow["NewsTitle"];
                news.NewsContent = (string)NewsRow["NewsContent"];
                news.NewsCatagories_Binary = (int)NewsRow["NewsCatagories_Binary"];
                news.PublishDateTime = (DateTime)NewsRow["PublishDateTime"];
                news.JournalistID = (int)NewsRow["JournalistID"];
                news.CountryID = (int)NewsRow["CountryID"];
                news.CountView = (int)NewsRow["CountView"];
                news.Image = (string)NewsRow["Image"];


                ctrlNewsHomePage ctrlNews = new ctrlNewsHomePage();

                ctrlNews.LoadNewsInfo(news);

                ctrlNews.Size = new System.Drawing.Size(1222, 120);
                ctrlNews.Margin = new Padding(3);

                flpBookmarkNews.Controls.Add(ctrlNews);

            }

        }

    }
}
