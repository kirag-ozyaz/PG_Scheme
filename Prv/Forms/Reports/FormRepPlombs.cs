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
    internal partial class FormRepPlombs : Form
    {
        public FormRepPlombs(DataSets.DataSetPlomb ds, DateTime d_beg, DateTime d_end, int typeRdlc)
        {
            InitializeComponent();

            switch (typeRdlc)
            {
                case 1:
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportPlombsGive.rdlc";
                    break;
                case 2:
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportPlombsAny.rdlc";
                    break;
                case 3:
                    break;
            }

            Microsoft.Reporting.WinForms.ReportParameter p =
                new Microsoft.Reporting.WinForms.ReportParameter("DateBeg", d_beg.ToString());
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p });
            p = new Microsoft.Reporting.WinForms.ReportParameter("DateEnd", d_end.ToString());
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p });

            for (int i = 0; i < ds.vPlombStatus.Rows.Count; i++)
			{
                dataSetPlomb.vPlombStatus.ImportRow(ds.vPlombStatus.Rows[i]);
			}
        }

        private void FormRepPlombs_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
