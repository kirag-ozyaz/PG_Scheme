using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms
{
    public partial class FormMeterEnter : FormLbr.FormBase
    {
        private decimal VAL = -1;

        public FormMeterEnter()
        {
            InitializeComponent();
        }
        
        public FormMeterEnter(decimal val)
        {
            InitializeComponent();
            VAL = val;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FormCntValMeter frm = (FormCntValMeter)this.Owner;

            if (mtbValue.Text == String.Empty)
                frm.valMetering = -1;
            else
                frm.valMetering = Convert.ToDecimal(mtbValue.Text);
            if (mtbSize.Text == String.Empty)
                frm.valSize = -1;
            else
                frm.valSize = Convert.ToInt32(mtbSize.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormMeterEnter_Load(object sender, EventArgs e)
        {
            if (VAL == 0)
                mtbValue.Text = "";
            else
                mtbValue.Text = VAL.ToString();
        }

        private void FormMeterEnter_Shown(object sender, EventArgs e)
        {
            mtbValue.Focus();
        }

        private void mtbValue_Enter_1(object sender, EventArgs e)
        {
            this.mtbValue.SelectionStart = 0;
            this.mtbValue.SelectionLength = this.mtbValue.Text.Length;
            this.mtbValue.SelectAll();
        }
    }
}
