using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.Globally;
using GlobalNewsNetwork.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalNewsNetwork.UserCTRls.Catagories
{
    public partial class ctrlHashCategory : UserControl
    {
        public ctrlHashCategory()
        {
            InitializeComponent();
        }
        
   
        
        public enum enCategoryType { MainCategories , UserCategories }

        private enCategoryType _CategoryType = enCategoryType.MainCategories;
        public enCategoryType CategoryType
        {
            get { return _CategoryType; }
        }



        public enum enMethodType { Last , MostView }

        private enMethodType _MethodType;
        [Category("CTRL Settings") , Description("Method Type")]
        public enMethodType MethodType
        {
            get { return _MethodType; }
            set 
            {
                _CategoryType = enCategoryType.MainCategories;
                _MethodType = value;

                if (_MethodType == enMethodType.Last)
                    lblCategoryName.Text = "# آخر الأخبار";
                else if (_MethodType == enMethodType.MostView)
                    lblCategoryName.Text = "# الأكثر مشاهدة";
                else
                    lblCategoryName.Text = "اسم التصنيف";


                HandleCTRLSize();
            }
        }


        private bool _Selected;
        [Category("CTRL Settings"), Description("Selected")]
        public bool Selected
        {
            get { return _Selected; }
            set 
            {
                _Selected = value;

                if (_Selected)
                {
                    lblCategoryName.ForeColor = clsColorSettings.Red;

                }
                else
                {
                    lblCategoryName.ForeColor = clsColorSettings.White;
                }

            }
        }




        private clsCategory _Category = new clsCategory();
        public clsCategory Category
        {
            get { return _Category; }
            set { _Category = value; }
        }
        public void LoadCategoryInfo(clsCategory category)
        {
            _CategoryType = enCategoryType.UserCategories;

            Category = category;

            lblCategoryName.Text = "# " + Category.CategoryName;

            HandleCTRLSize();
        }

        private void HandleCTRLSize()
        {
            if (this.Size.Width <= lblCategoryName.Size.Width)
            {
                this.Size = new Size(lblCategoryName.Width, this.Size.Height);
            }

        }

        private void lblCategoryName_MouseEnter(object sender, EventArgs e)
        {
            if(!Selected)
            lblCategoryName.ForeColor = clsColorSettings.Heavenly;
        }

        private void lblCategoryName_MouseLeave(object sender, EventArgs e)
        {
            if(!Selected)
            lblCategoryName.ForeColor = clsColorSettings.White;
        }


        private void lblCategoryName_Click(object sender, EventArgs e)
        {
            Selected = (!Selected) ? true : false;      

            frmLogin.FormHome.HashCategory_Click(this, e);

        }
    }
}
