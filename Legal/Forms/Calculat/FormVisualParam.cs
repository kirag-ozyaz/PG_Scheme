using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Calculat
{
    public partial class FormVisualParam : FormLbr.FormBase
    {
        private int valPercentMinus;
        private int valPercentPlus;
        private int valCountMonth;

        public FormVisualParam()
        {
            InitializeComponent();
        }

        public FormVisualParam(int PercentMinus, int PercentPlus, int CountMonth)
        {
            InitializeComponent();
            valPercentMinus = PercentMinus;
            valPercentPlus = PercentPlus;
            valCountMonth = CountMonth;
        }

        private void FormVisualParam_Load(object sender, EventArgs e)
        {
            tbPercentMinus.Text = valPercentMinus.ToString();
            tbPercentPlus.Text = valPercentPlus.ToString();
            tbCountMonth.Text = valCountMonth.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FormCntVal frm = (FormCntVal)this.Owner;
            frm.PercentMinus = Convert.ToInt32(tbPercentMinus.Text);
            frm.PercentPlus = Convert.ToInt32(tbPercentPlus.Text);
            frm.CountMonth = Convert.ToInt32(tbCountMonth.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
