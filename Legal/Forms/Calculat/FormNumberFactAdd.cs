using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Calculat
{
    public partial class FormNumberFactAdd : FormLbr.FormBase
    {
        public FormNumberFactAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dsCalc1.tG_NumberFact.Rows.Add();
            dsCalc1.tG_NumberFact.Rows[0]["Period_Year"] = cbYear.Text;
            dsCalc1.tG_NumberFact.Rows[0]["Period_Month"] = cbMonth.Text;
            dsCalc1.tG_NumberFact.Rows[0]["Number_Max"] = txtNumberMax.Value ;
            dsCalc1.tG_NumberFact.Rows[0]["Number_Min"] = txtNumberMin.Value;
            if (txtNumberCurrent.Value != 0)
                dsCalc1.tG_NumberFact.Rows[0]["NumberFact"] = txtNumberCurrent.Value;
            InsertSqlData(dsCalc1, dsCalc1.tG_NumberFact);
            this.Close();
        }

        private void FormNumberFactAdd_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsCalc1, dsCalc1.tG_PeriodCalc, true);

            cbMonth.Text = dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"].ToString();
            cbYear.Text = dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"].ToString();
        }

        private void txtNumberMin_ValueChanged(object sender, EventArgs e)
        {
            txtNumberCurrent.Value = txtNumberMin.Value - 1;
        }

    }
}
