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
	internal partial class FormRepKO : Form
	{
		public FormRepKO()
		{
			InitializeComponent();
		}

		public FormRepKO(DataSets.DataSetRep ds, DateTime d_beg, DateTime d_end, bool isDetail)
		{
			InitializeComponent();

			if (!isDetail)
				this.reportViewer1.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportKOItog.rdlc";
			else
				this.reportViewer1.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportKO.rdlc";

			Microsoft.Reporting.WinForms.ReportParameter p = 
				new Microsoft.Reporting.WinForms.ReportParameter("date_Begin", d_beg.ToString());
			this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p });
			p = new Microsoft.Reporting.WinForms.ReportParameter("date_End", d_end.ToString());
			this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p });

			this.reportViewer1.RefreshReport();


			for (int i = 0; i < ds.RepActKO.Rows.Count; i++)
			{
                dsRep.RepActKO.ImportRow(ds.RepActKO.Rows[i]);
			}
		}

		private void RepKO_Load(object sender, EventArgs e)
		{
			this.reportViewer1.RefreshReport();
		}
	}
}
