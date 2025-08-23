using Data_GlobalNewsNetwork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_GlobalNewsNetwork
{
    public class clsCategory
    {

        enum enMode { Add , Update}
        enMode Mode;

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int Category_BinaryN { get; set; }
        public string ImagePath { get; set; }

        public  clsCategory() 
        {
            Mode = enMode.Add;

            this.CategoryID = -1;
            this.CategoryName = string.Empty;
            this.Category_BinaryN = -1;
            this.ImagePath = string.Empty;
        }

        private clsCategory(int categoryID , string categoryName , int categoryNumebr , string imagePath)
        {
            Mode = enMode.Update;

            this.CategoryID = categoryID;
            this.CategoryName = categoryName;
            this.Category_BinaryN = categoryNumebr;
            this.ImagePath = imagePath;
        }

        public static DataTable GetAllCategories()
        {
            return clsDataCatagories.GetAllCategories();
        }

        public static clsCategory Find(int CategoryID)
        {
            int Category_BinaryN = 0;
            string Name = "", ImagePath = "";

            if(clsDataCatagories.FindCategoriesByCategoryID(CategoryID , ref Name , ref Category_BinaryN , ref ImagePath))
            {
                return new clsCategory(CategoryID , Name , Category_BinaryN , ImagePath);
            }
            return null;
        }


        public static DataTable GetFavoriteCategories(int UserCategories)
        {
            return clsDataCatagories.GetAllCategoriesUserFavorites(UserCategories);
        }

        public static DataTable GetUnfavoriteCategoties(int UserCategories)
        {
            return clsDataCatagories.GetAllCategoriesUserUnfavorite (UserCategories);
        }

    }
}
