using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Calculat
{
    public partial class FormPowerEnter : FormLbr.FormBase
    {
        private int VAL = -1;

        public FormPowerEnter()
        {
            InitializeComponent();
        }
        
        
        public FormPowerEnter(int val, decimal pow, int reg, int en)
        {
            InitializeComponent();
            VAL = val;
            this.tbPower.Text = pow.ToString();
            this.tbRegime.Text = reg.ToString();
            this.tbCalc.Text = en.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tbEnter.Text = tbCalc.Text;
            FormCntVal frm = (FormCntVal)this.Owner;
            if (tbEnter.Text != "")
                frm.valQuantity = Convert.ToInt32(tbEnter.Text);
            else
                frm.valQuantity = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormPowerEnter_Load(object sender, EventArgs e)
        {
            if (VAL == 0)
                tbEnter.Text = "0";
            else
                tbEnter.Text = VAL.ToString();
        }
    }
}
