using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.Globally;
using GlobalNewsNetwork.UserCTRls;
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GlobalNewsNetwork.StartForms
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

     

        private void lblbtnSignIn_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void lblbtnSignIn_MouseEnter(object sender, EventArgs e)
        {
            lblbtnSignIn.ForeColor = clsColorSettings.Red; 

        }

        private void lblbtnSignIn_MouseLeave(object sender, EventArgs e)
        {
            lblbtnSignIn.ForeColor = clsColorSettings.White;
        }

        private void frmCreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void _LoadCTRLsCatagoriesInFLP()
        {
            DataTable AllCatagories = clsCategory.GetAllCategories();

            flpCatagories.Controls.Clear();

            int Count = -1;

            foreach(DataRow r in AllCatagories.Rows)
            {
                ++Count;

                ctrlCategory ctrl = new ctrlCategory();

                ctrl.LoadCategoryInfo(r);

                flpCatagories.Controls.Add(ctrl);

                flpCatagories.Controls[Count].Size = new Size(217, 120); // 217, 120
            }
        }
        private void _LoadCountriesData()
        {
            DataTable dt = clsCountries.GetAllCountries();

            foreach (DataRow r in dt.Rows)
            {
                cmbbCountry.Items.Add(r["CountryName"]);
            }
        }
        private void _SetMaxMiniBarthofDate()
        {
            // اصغر عمر يمكن 
            dtpBarthofDate.MaxDate = DateTime.Now.AddYears(-18);
            // اكبر عمر يكمن
            dtpBarthofDate.MinDate = DateTime.Now.AddYears(-100);
        }
        private void _LoadDefaultUserImage()
        {
            try
            {
                picbUserImage.ImageLocation = @"D:\Global News Network Project\icons of project\UserPic.png";
            }
            catch { }
        }

        private async void frmCreateAccount_Load(object sender, EventArgs e)
        {
            Task thLoadCatagories = new Task(_LoadCTRLsCatagoriesInFLP);
            thLoadCatagories.Start();

            _LoadCountriesData();
            _SetMaxMiniBarthofDate();
            _LoadDefaultUserImage();

            await thLoadCatagories;
        }

        private void txtbFirstName_MouseEnter(object sender, EventArgs e)
        {
            tltpInputInfo.SetToolTip((Control)sender, "ارقام او مسافة بدون اسم ادخل");
        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = @"C:\";
            dlg.Filter = "PNG Files (*.png)|*.png | JPEG Files (*.jpg)|*.jpg";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                picbUserImage.ImageLocation = dlg.FileName;
            }

        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            picbUserImage.Image = Image.FromFile(@"D:\Global News Network Project\icons of project\UserPic.png");
        
        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {
            clsSecurity.enPasswordStrength Strength = clsSecurity.CheckPasswordStrength(txtbPassword.Text);

            if (Strength == clsSecurity.enPasswordStrength.Strong)
                txtbPassword.ForeColor = Color.Green;
            else if (Strength == clsSecurity.enPasswordStrength.Medium)
                txtbPassword.ForeColor = Color.Yellow;
            else if (Strength == clsSecurity.enPasswordStrength.Weak)
                txtbPassword.ForeColor = Color.Red;
        }

        private void txtbSurePassword_TextChanged(object sender, EventArgs e)
        {
            clsSecurity.enPasswordStrength Strength = clsSecurity.CheckPasswordStrength(txtbSurePassword.Text);

            if (Strength == clsSecurity.enPasswordStrength.Strong)
                txtbSurePassword.ForeColor = Color.Green;
            else if (Strength == clsSecurity.enPasswordStrength.Medium)
                txtbSurePassword.ForeColor = Color.Yellow;
            else if (Strength == clsSecurity.enPasswordStrength.Weak)
                txtbSurePassword.ForeColor = Color.Red;
        }

        private void picbPasswordInfo_MouseEnter(object sender, EventArgs e)
        {
            StringBuilder Message = new StringBuilder();
            Message.AppendLine("لكتابة كلمة سر قوية يجب مراعاة الآتي : ");
            Message.AppendLine("- أن تكون اكثر من 12 حرف");
            Message.AppendLine("- أن تحتوي على أحرف صغيرة و كبيرة (a/A)");
            Message.AppendLine("- أن تحتوي على أرقام");
            Message.AppendLine("- أن تحتوي على رموز (# , @ , & , ets)");

            tltpInputInfo.IsBalloon = true;

            tltpInputInfo.SetToolTip((Control)sender, Message.ToString());
        }

        private void chkbAgreeTermsUser_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbAgreeTermsUser.Checked)
            {
                btnCreateTheAccount.Enabled = true;
            }
            else
            {
                btnCreateTheAccount.Enabled = false;
            }
        }

        private bool HideShow_Pass = false;
        private void picbtnShowPassword_Click(object sender, EventArgs e)
        {
            HideShow_Pass = (!HideShow_Pass) ? true : false;

            if(HideShow_Pass)
            {
                txtbPassword.PasswordChar = '\0';
                picbtnShowPassword.Image = Image.FromFile(@"D:\Global News Network Project\icons of project\eye.png");
            }
            else
            {
                txtbPassword.PasswordChar = '*';
                picbtnShowPassword.Image = Image.FromFile(@"D:\Global News Network Project\icons of project\icons8-invisible-48.png");
            }

        }


        private bool HideShow_SurePass = false;
        private void picbtnShowSurePassword_Click(object sender, EventArgs e)
        {
            HideShow_SurePass = (!HideShow_SurePass) ? true : false;

            if (HideShow_SurePass)
            {
                txtbSurePassword.PasswordChar = '\0';
                picbtnShowSurePassword.Image = Image.FromFile(@"D:\Global News Network Project\icons of project\eye.png");
            }
            else
            {
                txtbSurePassword.PasswordChar = '*';
                picbtnShowSurePassword.Image = Image.FromFile(@"D:\Global News Network Project\icons of project\icons8-invisible-48.png");
            }
        }



        //*-*-

        enum enInvalidTypes {FirstNameInvalid , LastNameInvalid, CountryInvalid , EmailInvalid , PasswordInvalid , PasswordNotMatch}
        private string GetMessageErrorOfInvalid(enInvalidTypes Type)
        {
            switch (Type)
            {
                case enInvalidTypes.FirstNameInvalid:
                    return "يرجى إدخال الأسم الأول بشكل صحيح";
                case enInvalidTypes.LastNameInvalid:
                    return "يرجى إدخال الأسم الأخير بشكل صحيح";
                case enInvalidTypes.CountryInvalid:
                    return "اختر بلد";
                case enInvalidTypes.EmailInvalid:
                    return "الايميل غير صالح";
                case enInvalidTypes.PasswordInvalid:
                    return "كلمة السر غير صالحة";
                case enInvalidTypes.PasswordNotMatch:
                    return "كلمة السر غير متطابقة";
                default:
                    return "قيمة غير صالحة";
            }
        }

        private bool ValidationOfPersonalInfoTab(ref enInvalidTypes Type)
        {
            if (!txtbFirstName.IsValid())
            {
                Type = enInvalidTypes.FirstNameInvalid;
                return false; 
            }
            if (!txtbLastName.IsValid())
            {
                Type = enInvalidTypes.LastNameInvalid;
                return false;
            }
            if(cmbbCountry.SelectedIndex == -1)
            {
                Type = enInvalidTypes.CountryInvalid;
                return false;
            }

            return true;
        }

        private bool ValidationOfAccountInfoTab(ref enInvalidTypes Type)
        {
            if (!txtbEmail.IsValid())
            {
                Type = enInvalidTypes.EmailInvalid;
                return false ;
            }
            if (!txtbPassword.IsValid())
            {
                Type = enInvalidTypes.PasswordInvalid;
                return false;
            }
            if(!txtbSurePassword.IsValid())
            {
                Type = enInvalidTypes.PasswordInvalid;
                return false;
            }
            if(txtbPassword.Text != txtbSurePassword.Text)
            {
                Type = enInvalidTypes.PasswordNotMatch;
                return false;
            }

            return true;
        }
                
        private void tabctrlCreateAccount_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabctrlCreateAccount.SelectedIndex == 0)
            {
                enInvalidTypes invalidTypes = new enInvalidTypes();
                if (!ValidationOfPersonalInfoTab(ref invalidTypes))
                {
                    MessageBox.Show(GetMessageErrorOfInvalid(invalidTypes) , "");
                    e.Cancel = true;
                    return;
                }
            }
            if (tabctrlCreateAccount.SelectedIndex == 1)
            {
                enInvalidTypes invalidTypes = new enInvalidTypes();
                if (!ValidationOfAccountInfoTab(ref invalidTypes))
                {
                    MessageBox.Show(GetMessageErrorOfInvalid(invalidTypes));
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void btnCreateTheAccount_Click(object sender, EventArgs e)
        {
            if (clsPeople.EmailIsUsed(txtbEmail.Text))
            {
                DialogResult Result = MessageBox.Show("الايميل مستخدم بالفعل ، هل تود تسجيل الدخول ؟",
                    "الايميل مسنخدم", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == Result)
                {
                    frmLogin frm = new frmLogin();
                    frm.Email = txtbEmail.Text;
                    this.Hide();
                    frm.ShowDialog();
                    return;
                }
                else if (DialogResult.No == Result)
                {
                    tabctrlCreateAccount.SelectedIndex = 1;
                    txtbEmail.Focus();
                    return;
                }
                return;
            }

            int CategoreisNumber = 0;
            foreach (Control c in flpCatagories.Controls)
            {
                ctrlCategory ctrl = (ctrlCategory)c;
                if (!ctrl.SelectedCategory) continue;
                CategoreisNumber = CategoreisNumber + ctrl.CategoryInfo.Category_BinaryN;
            }
            // now we have a Categories of Users /\


            string EncryptedPassword = clsSecurity.GetEncryptionPassword(txtbPassword.Text);

            string ImagePath = "";
          
            if (picbUserImage.ImageLocation != null)
                 ImagePath = clsSecurity.StoreAndEncryptionImage(clsSecurity.enImageType.PersonalImage, picbUserImage.ImageLocation);

            int CountryID = clsCountries.FindCountry(cmbbCountry.SelectedItem.ToString()).CountryID;


            if (!clsUsers.CreateAccoutn(txtbFirstName.Text, txtbLastName.Text, rbtnMale.Checked,
                dtpBarthofDate.Value, CountryID,
                txtbEmail.Text, EncryptedPassword, ImagePath, CategoreisNumber))
            {
                MessageBox.Show("عذرا ، خطأ في إنشاء الحساب ، حاول مجددا", "خطأ في إنشاء الحساب");
                return;
            }
            
            frmDoneCreateAccount form = new frmDoneCreateAccount();
            this.Hide();
            form.Show();
            return;
        }
    }
}
