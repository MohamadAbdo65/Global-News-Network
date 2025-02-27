using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.Globally;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalNewsNetwork.UserCTRls
{
    public partial class ctrlCategory : UserControl
    {
        public ctrlCategory()
        {
            InitializeComponent();
        }

        public bool SelectedCategory
        { 
            get { return chkbSeletc.Checked; }
            set { chkbSeletc.Checked = value; }
        }

        private clsCategory _Category = new clsCategory();
        public clsCategory CategoryInfo
        { get { return _Category; } set { _Category = value; } }


        /// <summary>
        /// Send the row you Get from the database
        /// </summary>
        public void LoadCategoryInfo(DataRow CategoryRow)
        {
            _Category.CategoryID = (int)CategoryRow["CategoryID"];
            _Category.CategoryName = (string)CategoryRow["CategoryName"];
            _Category.Category_BinaryN = (int)CategoryRow["Category_BinaryN"];
            _Category.ImagePath = (string)CategoryRow["ImagePath"];

            

            chkbSeletc.Text = CategoryInfo.CategoryName;
            try { this.BackgroundImage = Image.FromFile(CategoryInfo.ImagePath); } catch { }
        }


        private void chkbSeletc_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbSeletc.Checked)
            {
                chkbSeletc.ForeColor = clsColorSettings.Red;
            }
            else { chkbSeletc.ForeColor = clsColorSettings.White;}
        }

        private void ctrlCatagory_Click(object sender, EventArgs e)
        {
            if (chkbSeletc.Checked)
                chkbSeletc.Checked = false;
            else 
                chkbSeletc.Checked = true;
        }
    }
}
