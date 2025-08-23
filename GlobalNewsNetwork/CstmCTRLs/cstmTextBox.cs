using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalNewsNetwork.CstmCTRLs
{
    public partial class cstmTextBox : Guna.UI2.WinForms.Guna2TextBox
    {
        public cstmTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public enum enInputType { Normal, Number, Text, Email, Password }
        [Category("Input Validation"), Description("Input Type")]
        public enInputType InputType { get; set; }


        [Category("Input Validation"), Description("Enable Space")]
        public bool EnableSpace { get; set; }

        [Category("Input Validation"), Description("Required")]
        public bool Required { get; set; }



        private bool IsInputHasSpace()
        {
            foreach (char c in this.Text)
            {
                if (c == ' ')
                    return true;
            }
            return false;
        }
        private bool InputIsNumber()
        {
            if (decimal.TryParse(this.Text, out _))
            {
                return true;
            }
            return false;
        }
        private bool InputIsEmail()
        {
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            return Regex.IsMatch(this.Text, emailPattern);
        }
        private bool InputIsPassword()
        {
            if (Regex.IsMatch(this.Text, @"^[a-zA-Z0-9!@#$%^&+-]+$"))
                return true;

            return false;
        }
        private bool InputIsText()
        {
            if (Regex.IsMatch(this.Text, @"^[\p{L}\s]+$"))
                return true;

            return false;
        }

        public bool IsValid()
        {
            if (Required)
            {
                if (string.IsNullOrEmpty(this.Text))
                    return false;
            }

            if (!EnableSpace)
            {
                if (IsInputHasSpace())
                    return false;
            }

            if (InputType == enInputType.Number)
            {
                if (!InputIsNumber()) return false;
            }
            else if (InputType == enInputType.Text)
            {
                if (!InputIsText()) return false;
            }
            else if (InputType == enInputType.Email)
            {
                if (!InputIsEmail()) return false;
            }
            else if (InputType == enInputType.Password)
            {
                if (!InputIsPassword()) return false;
            }


            return true;
        }



    }
}
