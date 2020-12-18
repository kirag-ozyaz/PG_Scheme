using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Calculat
{
    public partial class FormPassword : FormLbr.FormBase
    {
        public bool PasswordTrue = false;
        private string PASSWORD;

        public FormPassword()
        {
            InitializeComponent();
        }

        public FormPassword(string Password)
        {
            InitializeComponent();
            PASSWORD = Password;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.ToString() == PASSWORD)
            {
                PasswordTrue = true;
                this.DialogResult = DialogResult.OK;
            }
            else
                PasswordTrue = false;
        }
    }
}
