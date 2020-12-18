using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Documents.Forms.JournalRequest
{
    public partial class FormReportRequest : FormLbr.FormBase
    {
        int idR = -1;
        public FormReportRequest(int id)
        {
            InitializeComponent();
            idR = id;
        }

        private void FormReportRequest_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsGES, dsGES.vJ_Request, true, " where id = " + idR.ToString());
            this.SelectSqlData(dsGES, dsGES.tJ_RequestDoc, true, "where idRequest = " + idR.ToString());
            
            /*Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "DataSetGES";
            reportDataSource1.Value = dsGES;
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource1);*/
            this.reportViewerRus1.RefreshReport();
        }
    }
}
