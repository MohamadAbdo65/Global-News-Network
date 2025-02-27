using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.Globally;
using GlobalNewsNetwork.UserCTRls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalNewsNetwork.MainForms
{
    // Fav Tab
    public partial class frmHomePage
    {
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            int NewCategoriesNumebr = 0;

            foreach (ctrlCategory CTRL in flpFavoriteUser.Controls)
            {
                if (CTRL.SelectedCategory) NewCategoriesNumebr += CTRL.CategoryInfo.Category_BinaryN;
            }

            clsCurrentUser.User.Catagories_Binary = NewCategoriesNumebr;

            if (clsCurrentUser.User.Save()) MessageBox.Show("تم حفظ التغييرات");
            else MessageBox.Show("خطأ في حفظ التغييرات");
        }

        private void _LoadCategories()
        {
            System.Drawing.Size CategorySize = new System.Drawing.Size(300, 110);

            int UserCategories = clsCurrentUser.User.Catagories_Binary;

            flpFavoriteUser.Controls.Clear();

            DataTable FavoriteCategories = clsCategory.GetFavoriteCategories(UserCategories);

            foreach (DataRow FavCategory in FavoriteCategories.Rows)
            {
                ctrlCategory ctrlcategory = new ctrlCategory();

                ctrlcategory.LoadCategoryInfo(FavCategory);

                ctrlcategory.SelectedCategory = true;
                ctrlcategory.Size = CategorySize;

                flpFavoriteUser.Controls.Add(ctrlcategory);
            }

            DataTable UnFavoriteCategories = clsCategory.GetUnfavoriteCategoties(UserCategories);

            foreach (DataRow UnFavCategory in UnFavoriteCategories.Rows)
            {
                ctrlCategory ctrlcategory = new ctrlCategory();

                ctrlcategory.LoadCategoryInfo(UnFavCategory);

                ctrlcategory.Size = CategorySize;

                flpFavoriteUser.Controls.Add(ctrlcategory);
            }


        }


        // Overview :

        private void _LoadFavoriteTab()
        {
            _LoadCategories();
        }


    }
}
