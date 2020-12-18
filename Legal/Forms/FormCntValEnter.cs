using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormCntValEnter : FormLbr.FormBase
    {
        
        private int VAL = -1;

        public FormCntValEnter()
        {
            InitializeComponent();
        }

        public FormCntValEnter(int val)
        {
            InitializeComponent();
            VAL = val;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FormCntVal frm = (FormCntVal)this.Owner;
            if (tbEnter.Text != "")
                frm.valQuantity = Convert.ToInt32(tbEnter.Text);
            else
                frm.valQuantity = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormCntValEnter_Load(object sender, EventArgs e)
        {
            if (VAL == 0)
                tbEnter.Text = "0";
            else
                tbEnter.Text = VAL.ToString();

        }
    }
}
