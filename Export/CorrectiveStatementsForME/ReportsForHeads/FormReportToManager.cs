using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatementsForME
{
    /// <summary>
    /// Утренний отчет руководителю
    /// </summary>
    public partial class FormReportToManager : FormLbr.FormBase
    {
        private DateTimePicker dateTimePickerBegin;
        private DateTimePicker dateTimePickerEnd;

        TimeSpan timeBeg;
        TimeSpan timeEnd;
        DateTime DataBeg;
        DateTime DataEnd;

        StatementsToHead rpt;

        public FormReportToManager()
        {
            InitializeComponent();
        }
        private void dateTimePickerBegin_ValueChanged(object sender, EventArgs e)
        {
            DataBeg = ((DateTimePicker)sender).Value;
            timeBeg = ((DateTimePicker)sender).Value.TimeOfDay;
            rpt.TimeBeg = timeBeg;
            rpt.DataBeg = DataBeg;
        }
        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            DataEnd = ((DateTimePicker)sender).Value;
            timeEnd = ((DateTimePicker)sender).Value.TimeOfDay;
            rpt.DataEnd = DataEnd;
            rpt.TimeEnd = timeEnd;
        }

        private void FillReport()
        {
            rpt.DataBeg = DataBeg;
            rpt.DataEnd = DataEnd;
            rpt.TimeBeg = timeBeg;
            rpt.TimeEnd = timeEnd;

            this.rptViewer.Reset();

            this.rptViewer.LocalReport.ReportEmbeddedResource = "StatementsForME.ReportsForHeads.ReportToManager.rdlc";
            string dateReport = DateTime.Now.ToString("dd.MM.yyyy");
            string Period = "( c " + DataBeg.ToLongDateString() + " " + timeBeg.Hours.ToString("D2") + ":" + timeBeg.Minutes.ToString("D2") + " по " + DataEnd.ToLongDateString() + " " + timeEnd.Hours.ToString("D2") + ":" + timeEnd.Minutes.ToString("D2") + " " + ")";

            this.rptViewer.LocalReport.SetParameters(new ReportParameter("dateReport", dateReport));
            this.rptViewer.LocalReport.SetParameters(new ReportParameter("User", rpt.GetCurrentUser()));
            this.rptViewer.LocalReport.SetParameters(new ReportParameter("dateEnd", DataEnd.ToLongDateString()));
            this.rptViewer.LocalReport.SetParameters(new ReportParameter("Period", Period));


            DataTable tableDamage = rpt.LoadData();

            this.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetReportToManager", tableDamage));
            this.rptViewer.RefreshReport();
        }
    
        private void FormReportToManager_Load(object sender, EventArgs e)
        {
            rpt = new StatementsToHead();
            rpt.SqlSettings = this.SqlSettings;
            timeBeg = rpt.TimeBeg;
            timeEnd = rpt.TimeEnd;
            DataBeg = rpt.DataBeg;
            DataEnd = rpt.DataEnd;

            this.dateTimePickerBegin = new DateTimePicker();
            this.dateTimePickerBegin.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBegin.Value = DataBeg + timeBeg;
            this.dateTimePickerBegin.ValueChanged += new System.EventHandler(dateTimePickerBegin_ValueChanged);
            this.toolStrip.Items.Insert(1, new ToolStripControlHost(this.dateTimePickerBegin));

            this.dateTimePickerEnd = new DateTimePicker();
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerEnd.Value = DataEnd + timeEnd;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);

            this.toolStrip.Items.Insert(3, new ToolStripControlHost(this.dateTimePickerEnd));

            this.FillReport();
        }
        private void toolBtnLoad_Click(object sender, EventArgs e)
        {
            this.FillReport();
        }
        private void toolBtnSend_Click(object sender, EventArgs e)
        {
             rpt.Send();
        }

        private void rptViewer_ReportRefresh(object sender, CancelEventArgs e)
        {
            this.FillReport();
        }

        /// <summary>
        /// отпрвка формата xml = эксперимент
        /// Экспорт excel (xml)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Library.ExportToExcel.Create(rpt.LoadData(), DataBeg, DataEnd);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rpt.CreateExcel();
        }
    }
}
