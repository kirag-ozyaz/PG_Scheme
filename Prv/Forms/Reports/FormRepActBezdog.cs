using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prv.Forms.Reports
{
    public partial class FormRepActBezdog : FormLbr.FormBase
    {
        private DateTime DateAct, DateActBeg, DateActEnd;

        public FormRepActBezdog()
        {
            InitializeComponent();
            comboBoxYear.Items.Add("Все");
            for (int i = 2009; i <= 2050; i++)
                comboBoxYear.Items.Add(i);
            comboBoxYear.SelectedIndex = comboBoxYear.FindString(DateTime.Today.Year.ToString());

            for (DateTime d_c = System.DateTime.Now; d_c >= new DateTime(2007, 01, 01);
            d_c = d_c.AddMonths(-1))
                cBoxPeriod.Items.Add(d_c);
            cBoxPeriod.SelectedIndex = 0;
        }

        private void btkCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            DateAct = Convert.ToDateTime(cBoxPeriod.SelectedItem);
            DateActBeg = new DateTime(DateAct.Year, DateAct.Month, 1);
            DateActEnd = new DateTime(DateAct.Year, DateAct.Month, DateTime.DaysInMonth(DateAct.Year, DateAct.Month));

            SelectSqlData(dsRep, dsRep.vDocActBezuch, true, "where idDocType = " + ((int)Constants.DocType.ActBezdog).ToString() +
                          " and year(DateAct) = " + comboBoxYear.SelectedItem.ToString() + " " +
                          " and DateIn >= '" + DateActBeg.ToString("yyyyMMdd") + "' and  DateIn <= '" + DateActEnd.ToString("yyyyMMdd") + "' order by DateAct desc");

            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("DataBegin", DateActBeg.ToString());
            this.RWRepActBezuch.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p1 });
            Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataEnd", DateActEnd.ToString());
            this.RWRepActBezuch.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p2 });
            Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Year", comboBoxYear.SelectedItem.ToString());
            this.RWRepActBezuch.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p3 });

            this.RWRepActBezuch.RefreshReport();
        }

        private void FormRepActBezdog_Load(object sender, EventArgs e)
        {

        }
    }
}
