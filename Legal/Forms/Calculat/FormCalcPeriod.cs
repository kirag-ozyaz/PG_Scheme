using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Calculat
{
    public partial class FormCalcPeriod : FormLbr.FormBase
    {
        public FormCalcPeriod()
        {
            InitializeComponent();
        }

        private void FormCalcPeriod_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsCntVal1, dsCntVal1.tG_PeriodCalc, true);
            if (dsCntVal1.tG_PeriodCalc.Rows.Count > 0)
            {
                cbMonth.SelectedIndex = (Int32)dsCntVal1.tG_PeriodCalc[0]["MonthCalc"] - 1;
                cbYear.Text = dsCntVal1.tG_PeriodCalc[0]["YearCalc"].ToString();
            }
            else
            {
                DataRow r = dsCntVal1.tG_PeriodCalc.NewRow();
                cbMonth.SelectedIndex = DateTime.Now.Month - 1;
                r["id"] = 1;
                r["MonthCalc"] = cbMonth.SelectedIndex + 1; ;
                r["YearCalc"] = cbYear.Text = DateTime.Now.Year.ToString();
                dsCntVal1.tG_PeriodCalc.Rows.Add(r);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dsCntVal1.tG_PeriodCalc[0]["MonthCalc"] = cbMonth.SelectedIndex + 1;
            dsCntVal1.tG_PeriodCalc[0]["YearCalc"] = cbYear.Text;
            InsertSqlData(dsCntVal1, dsCntVal1.tG_PeriodCalc);
            UpdateSqlData(dsCntVal1, dsCntVal1.tG_PeriodCalc);
        }
    }
}
