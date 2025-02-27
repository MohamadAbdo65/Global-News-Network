using Business_GlobalNewsNetwork;
using GlobalNewsNetwork.Globally;
using GlobalNewsNetwork.MainForms;
using GlobalNewsNetwork.StartForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalNewsNetwork
{
    public partial class frmLogin : Form
    {
        public string Email
        {
            get { return txtbEmail.Text; }
            set { txtbEmail.Text = value;}
        }

        public static frmHomePage FormHome;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check if text boxes (Email , Password) not Empty
        /// </summary>
        /// <returns>Empty = True , Fill = false</returns>
        bool _CheckTextBoxesIsEmpty()
        {
            if (txtbEmail.Text == string.Empty)
            {
                MessageBox.Show("يرجى ادخال الإيميل");
                return true;
            }
            if (txtbPassword.Text == string.Empty)
            {
                MessageBox.Show("يرجى ادخال كلمة السر");
                return true;
            }
            return false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (_CheckTextBoxesIsEmpty())
                return;

            string Email = txtbEmail.Text;
            string Password = clsSecurity.GetEncryptionPassword(txtbPassword.Text);

            clsTechnicians T = new clsTechnicians();
            clsJournalists J = new clsJournalists();
            clsAdmins A = new clsAdmins();
            clsUsers U = new clsUsers();
            clsPeople P = new clsPeople();

            if(!clsPeople.Login(Email, Password , ref P , ref U , ref J  , ref A , ref T))
            {
                MessageBox.Show("الايميل او كلمة السر خطأ", "خطأ في تسجيل الدخول");
                return;
            }

            clsCurrentUser.LogIn(P, U, T, A, J);

            frmHomePage frm = new frmHomePage();
            FormHome =  frm;
            this .Hide();
            frm.Show();
            return;
        }

        private void lblbtnForgetPassword_MouseEnter(object sender, EventArgs e)
        {
            lblbtnForgetPassword.ForeColor = clsColorSettings.Red;
        }

        private void lblbtnForgetPassword_MouseLeave(object sender, EventArgs e)
        {
            lblbtnForgetPassword.ForeColor = clsColorSettings.White;
        }

        private void lblbtnForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("قريبا ...");
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btnSignIn_Click(sender, e);
            }
        }

        private void lblbtnCreateAccount_MouseEnter(object sender, EventArgs e)
        {
            lblbtnCreateAccount.ForeColor = clsColorSettings.Red;
        }

        private void lblbtnCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            lblbtnCreateAccount.ForeColor = clsColorSettings.White;

        }

        private void lblbtnCreateAccount_Click(object sender, EventArgs e)
        {
            frmCreateAccount frm = new frmCreateAccount();
            this.Hide();
            frm.ShowDialog();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private bool HideShow_Pass = false;
        private void picbtnShowPassword_Click(object sender, EventArgs e)
        {
            HideShow_Pass = (!HideShow_Pass) ? true : false;

            if (HideShow_Pass)
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
    }
}
