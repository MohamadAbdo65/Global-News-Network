using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.Globally;
using GlobalNewsNetwork.UserCTRls.Catagories;
using GlobalNewsNetwork.UserCTRls.News;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace GlobalNewsNetwork.MainForms
{
    // Homae Tab 
    public partial class frmHomePage
    {
       
        public void HashCategory_Click(object sender , EventArgs e)
        {
            foreach (ctrlHashCategory ctrl in flpCategories.Controls)
            {
                ctrl.Selected = false;
            }

            ctrlHashCategory hashCategory = (ctrlHashCategory)sender;
            
            hashCategory.Selected = true;

            if (hashCategory.CategoryType == ctrlHashCategory.enCategoryType.UserCategories)
                _LoadNews(clsNews.GetAllNews(hashCategory.Category.Category_BinaryN , 0));
            else if (hashCategory.CategoryType == ctrlHashCategory.enCategoryType.MainCategories)
            {
                if (hashCategory.MethodType == ctrlHashCategory.enMethodType.Last)
                    _LoadNews(clsNews.GetAllNews(clsCurrentUser.User.Catagories_Binary, 0));
                else if (hashCategory.MethodType == ctrlHashCategory.enMethodType.MostView)
                    _LoadNews(clsNews.GetAllNews(-1 , 0));
            }
        }

        private void _LoadMainCategory()
        {
            ctrlHashCategory LastNews = new ctrlHashCategory();
            LastNews.MethodType = ctrlHashCategory.enMethodType.Last;
            LastNews.Selected = true;

            ctrlHashCategory MostViewsNews = new ctrlHashCategory();
            MostViewsNews.MethodType = ctrlHashCategory.enMethodType.MostView;

            flpCategories.Controls.Add(LastNews);
            flpCategories.Controls.Add(MostViewsNews);
        }

        private void _LoadHashCategories()
        {
            flpCategories.Controls.Clear();

            _LoadMainCategory();

            int UserCategoriesNumebr = clsCurrentUser.User.Catagories_Binary;

            DataTable AllCategories = clsCategory.GetAllCategories();


            int CurrentCategory = 0;
                        

            foreach(DataRow RowCategory in AllCategories.Rows)
            {
                CurrentCategory = (int)RowCategory["Category_BinaryN"];

                if ((UserCategoriesNumebr & CurrentCategory) == CurrentCategory)
                {
                    clsCategory ObjCategory = new clsCategory();
                    ObjCategory.CategoryID       = (int)RowCategory["CategoryID"];
                    ObjCategory.CategoryName     = (string)RowCategory["CategoryName"];
                    ObjCategory.Category_BinaryN = (int)RowCategory["Category_BinaryN"];
                    ObjCategory.ImagePath        = (string)RowCategory["ImagePath"];

                    if (ObjCategory != null)
                    {
                        ctrlHashCategory ctrlHash = new ctrlHashCategory();

                        ctrlHash.LoadCategoryInfo(ObjCategory);

                        ctrlHash.Click += HashCategory_Click;

                        flpCategories.Controls.Add(ctrlHash);
                    }
                }
            }
        }


        // News : 
                

        private void _NotNewsExist()
        {
            Label label = new Label();

            label.AutoSize = true;
            label.Font = new System.Drawing.Font("AlArabiya", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(34, 5);
            label.Name = "label1";
            label.Size = new System.Drawing.Size(1199, 78);
            label.TabIndex = 0;
            label.Text = "نحن نعمل على جلب آخر الأخبار لك. لا يوجد شيء جديد الآن، لكن ابقَ على اطلاع.\r\n";


            flpNews.Controls.Add(label);

        }

        private void _LoadNews(DataTable _News)
        {
            flpNews.Controls.Clear();

            _NotNewsExist();

            DataTable NewsTable = _News;

            if (NewsTable == null || NewsTable.Rows.Count <= 0) return;

            flpNews.Controls.Clear();

            foreach(DataRow NewsRow in NewsTable.Rows)
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
                
                flpNews.Controls.Add(ctrlNews);

            }

        }


        // Overview :

        private void _LoadHomeTab()
        {
            _LoadHashCategories();

            int Categories = clsCurrentUser.User.Catagories_Binary;
            _LoadNews(clsNews.GetAllNews(Categories, 0));
        }


    }
}
