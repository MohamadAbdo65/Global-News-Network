using Data_GlobalNewsNetwork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_GlobalNewsNetwork
{
    public class clsNews
    {
        enum enMode { AddMode, UpdateMode }
        enMode Mode;

        public System.Int32 NewsID { get; set; }
        public System.String NewsTitle { get; set; }
        public System.String NewsContent { get; set; }
        public System.Int32 NewsCatagories_Binary { get; set; }
        public System.DateTime PublishDateTime { get; set; }
        public System.Int32 JournalistID { get; set; }
        public System.Int32 CountryID { get; set; }
        public System.Int32 CountView { get; set; }
        public System.String Image { get; set; }



        public clsNews()
        {
            Mode = enMode.AddMode;

            this.NewsID = 0;
            this.NewsTitle = string.Empty;
            this.NewsContent = string.Empty;
            this.NewsCatagories_Binary = 0;
            this.PublishDateTime = new DateTime(1900, 1, 1);
            this.JournalistID = 0;
            this.CountryID = 0;
            this.CountView = 0;
            this.Image = string.Empty;

        }

        private clsNews(System.Int32 NewsID, System.String NewsTitle, System.String NewsContent,
            System.Int32 NewsCatagories_Binary, System.DateTime PublishDateTime, System.Int32 JournalistID, 
            int CountryID , System.Int32 CountView, System.String Image)
        {
            Mode = enMode.UpdateMode;

            this.NewsID = NewsID;
            this.NewsTitle = NewsTitle;
            this.NewsContent = NewsContent;
            this.NewsCatagories_Binary = NewsCatagories_Binary;
            this.PublishDateTime = PublishDateTime;
            this.JournalistID = JournalistID;
            this.CountryID = CountryID;
            this.CountView = CountView;
            this.Image = Image;



        }


        /// <summary>
        /// Get All News by categories number of user , if you want to get all news by VIEWS send -1
        /// </summary>
        public static DataTable GetAllNews(int UserCategories , int PageNumber)
        {
            if (UserCategories == -1) 
                return clsDataNews.GetAllNewsByViews();

            return clsDataNews.GetAllNewsByCategories(UserCategories , PageNumber);
        }

        public static DataTable GetAllNews(string TextSearch)
        {
            return clsDataNews.GetAllNewsBySearch(TextSearch);
        }

        public static bool CountaView(int NewsID)
        {
            return clsDataNews.CountView(NewsID);
        }

        public bool CountaView() 
        { 
            return clsNews.CountaView(this.NewsID);
        }


        // fix this method : !!
        private bool Save()
        {
            if (Mode == enMode.AddMode)
            {
                if (_AddNewUser())
                {
                    Mode = enMode.UpdateMode;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (Mode == enMode.UpdateMode)
            {

                return _UpdateUser();
            }
            return false;
        }

        bool _AddNewUser()
        {
            return true;
        }

        bool _UpdateUser()
        {
            return true;
        }

    }
}
