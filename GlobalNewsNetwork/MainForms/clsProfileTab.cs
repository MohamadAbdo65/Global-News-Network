using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.Globally;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalNewsNetwork.MainForms
{
    // Profile tab
    public partial class frmHomePage
    {
        private void _LoadCountries()
        {
            DataTable dt = clsCountries.GetAllCountries();

            foreach (DataRow r in dt.Rows)
            {
                cmbbCountry.Items.Add(r["CountryName"]);
            }

        }

        private void _LoadProfileInfoTab()
        {
            _LoadCountries();

            try { picbUserImage.Image = clsSecurity.GetDectyptionImage(clsCurrentUser.Person.Image); } catch { }
            txtbFirstName.Text = clsCurrentUser.Person.FirstName;
            txtbLastName.Text = clsCurrentUser.Person.LastName;
            dtpBarthofDate.Value = clsCurrentUser.Person.DateOfBirth;
            if (!clsCurrentUser.Person.Gender) rbtnFemale.Checked = true;
            cmbbCountry.SelectedItem = clsCurrentUser.Person.CountryInfo.CountryName;
            txtbEmail.Text = clsCurrentUser.Person.Email;

        }


        private void btnSetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = @"C:\";
            dlg.Filter = "PNG Files (*.png)|*.png | JPEG Files (*.jpg)|*.jpg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picbUserImage.ImageLocation = dlg.FileName;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            picbUserImage.Image = System.Drawing.Image.FromFile(@"D:\Global News Network Project\icons of project\UserPic.png");

        }


        public class NewPersonInfoEvetnArgs : EventArgs
        {
            public clsPeople Person { get; set; }

            public NewPersonInfoEvetnArgs(clsPeople person)
            {
                Person = person;
            }
        }

        public delegate void UpdatedPersonInfoEventHandler(object sender, NewPersonInfoEvetnArgs e);

        public event UpdatedPersonInfoEventHandler UpdatedPersonInfo;

        protected virtual void OnUpdatePersonInfo(clsPeople NewPersonInfo) 
        { 
            UpdatedPersonInfo?.Invoke(this , new NewPersonInfoEvetnArgs (NewPersonInfo));
        }

        private void btnSaveUpdates_Click(object sender, EventArgs e)
        {
            // Temp person if save failed !
            clsPeople TempPerson = clsCurrentUser.Person;

            TempPerson.FirstName = txtbFirstName.Text;
            TempPerson.LastName = txtbLastName.Text;
            TempPerson.DateOfBirth = dtpBarthofDate.Value;
            TempPerson.Gender = rbtnMale.Checked;
            TempPerson.Email = txtbEmail.Text;

            string ImagePath = TempPerson.Image;
            if (picbUserImage.ImageLocation != null)
            { 
                ImagePath = clsSecurity.StoreAndEncryptionImage(clsSecurity.enImageType.PersonalImage, picbUserImage.ImageLocation); 
            }

            int CountryID = clsCountries.FindCountry(cmbbCountry.SelectedItem.ToString()).CountryID;

            TempPerson.CountryID = CountryID;
            TempPerson.Image = ImagePath;


            if (MessageBox.Show("هل تود الحفظ بالفعل ؟" , "حفظ معلومات الحساب" , MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            if (TempPerson.Save())
            {
                clsCurrentUser.Person = TempPerson;
                OnUpdatePersonInfo(clsCurrentUser.Person);
                MessageBox.Show("تم حفط التعديلات", "حفظ معلومات الحساب");
                return;
            }

            MessageBox.Show("خطأ في حفظ التعديلات", "حفظ معلومات الحساب");

        }


        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل متأكد من حذف الحساب ؟" , "حذف الحساب" , MessageBoxButtons.YesNo) != DialogResult.Yes)
                return ;


            if (clsCurrentUser.DeleteAccount())
            {
                clsCurrentUser.LogOut();
                MessageBox.Show("تم حذف الحساب بنجاح", "حذف الحساب");
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
            else
            {
                MessageBox.Show("خطأ في حذف الحساب", "حذف الحساب");
            }
        }
    }
}
