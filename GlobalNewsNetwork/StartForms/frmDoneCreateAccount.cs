using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalNewsNetwork.StartForms
{
    public partial class frmDoneCreateAccount : Form
    {
        public frmDoneCreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreateTheAccount_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();  
            this.Hide();
            frm.Show();
            return;
        }
    }
}
