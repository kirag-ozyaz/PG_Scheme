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
    /// Отчет по работам (плановым, ремонтным в электросетях)
    /// </summary>
    public partial class FormReportToPlanned : FormLbr.FormBase
    {
        private DateTimePicker dateTimePickerBegin;
        private DateTimePicker dateTimePickerEnd;
        private ToolStripLabel lInterval;
        private ToolStripTextBox tbInterval;

        private const int ODS_DIVISION = 920;
        private const int PL_DIVISION = 921;
        private const int NO_DIVISION = 1665;

        DateTime DataBeg;
        DateTime DataEnd;
        int Interval;
        int IntervalCrash;

        StatementsToPlanned rpt;

        public FormReportToPlanned()
        {
            InitializeComponent();
           
        }
        private void dateTimePickerBegin_ValueChanged(object sender, EventArgs e)
        {
            DataBeg = ((DateTimePicker)sender).Value;
            rpt.DataBeg = DataBeg;
            //
            // PeriodToBeginDay = DataEnd.Subtract(DataBeg).Days;
            // MessageBox.Show(DataEnd.Subtract(DataBeg).Days.ToString());
            //var z = (DataEnd - DataBeg).Duration();
            //MessageBox.Show("1. " + z.ToString());
            //MessageBox.Show("2. " + z.TotalDays.ToString());
        }
        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            DataEnd = ((DateTimePicker)sender).Value;
            rpt.DataEnd = DataEnd;
            //
            this.tbInterval.Text = (DataEnd.Subtract(DataBeg).Days + 1).ToString();
            //MessageBox.Show(DataEnd.Subtract(DataBeg).Days.ToString());
        }
        ///// <summary>
        ///// выборка аварийных и плановых работ
        ///// </summary>
        //private bool isCrash;
        //private int idDivision;
        private void FillReport()
        {
            Library.Security security = new Library.Security();
            security.SqlSettings = SqlSettings;
            string CurrentUsers = security.GetCurrentUser();

            rpt.DataBeg = DataBeg;
            rpt.DataEnd = DataEnd;//.Date.AddDays(1).AddMilliseconds(-1);
            rpt.Interval = Interval;
            rpt.IntervalCrash = IntervalCrash;

            this.rptViewer.Reset();

            this.rptViewer.LocalReport.ReportEmbeddedResource = rpt.ReportMaket;

            this.rptViewer.LocalReport.SetParameters(new ReportParameter("DateBegin", DataBeg.AddDays(IntervalCrash).ToLongDateString()));
            this.rptViewer.LocalReport.SetParameters(new ReportParameter("DateEnd",  DataEnd.ToLongDateString()));
            //this.rptViewer.LocalReport.SetParameters(new ReportParameter("isCrash", this.isCrash.ToString()));

            DataTable tableDamage = rpt.LoadData();

            this.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetRepairDaily", tableDamage));
            this.rptViewer.RefreshReport();
            // надо удалить последнюю страницу, она пустая
            //this.rptViewer.LocalReport.
        }
    
        private void FormReportToManager_Load(object sender, EventArgs e)
        {
            rpt = new StatementsToPlanned();
            rpt.SqlSettings = this.SqlSettings;

            DataBeg = rpt.DataBeg;
            DataEnd = rpt.DataEnd;
            Interval = rpt.Interval;
            IntervalCrash = rpt.IntervalCrash;

            this.dateTimePickerBegin = new DateTimePicker();
            this.dateTimePickerBegin.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBegin.Value = DataBeg;
            this.dateTimePickerBegin.ValueChanged += new System.EventHandler(dateTimePickerBegin_ValueChanged);
            this.toolStrip.Items.Insert(1, new ToolStripControlHost(this.dateTimePickerBegin));

            this.dateTimePickerEnd = new DateTimePicker();
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerEnd.Value = DataEnd;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            this.toolStrip.Items.Insert(3, new ToolStripControlHost(this.dateTimePickerEnd));


            this.lInterval = new System.Windows.Forms.ToolStripLabel
            {
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                Name = "lInterval",
                Size = new System.Drawing.Size(60, 22),
                Text = "Интервал"
            };


            this.tbInterval = new System.Windows.Forms.ToolStripTextBox
            {
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                MaxLength = 100,
                Name = "tsbInterval",
                Size = new System.Drawing.Size(35, 25),
                Text = Interval.ToString()
            };
            this.tbInterval.TextChanged += new EventHandler(tbPeriodToBeginDay_TextChanged);
            this.tbInterval.ReadOnly = true;

            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lInterval,
            this.tbInterval});

            this.rptViewer.ShowExportButton = true;

            //this.FillReport();
        }

        private void tbPeriodToBeginDay_TextChanged(object sender, EventArgs e)
        {
            //PeriodToBeginDay = Convert.ToInt32(((ToolStripTextBox)sender).Text);
            //rpt.PeriodToBeginDay = PeriodToBeginDay;
            // 
            //DataEnd = DataBeg.AddDays(PeriodToBeginDay);
            //rpt.DataEnd = DataEnd;
        }

        private void toolBtnLoad_Click(object sender, EventArgs e)
        {
            this.FillReport();
            DataTable tableDamage = rpt.LoadData();
        }
        private void toolBtnSend_Click(object sender, EventArgs e)
        {
            rpt.Send();
            this.FillReport();
        }

        private void rptViewer_ReportRefresh(object sender, CancelEventArgs e)
        {
            this.FillReport();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rpt.CreateExcel();
            this.FillReport();
        }
    }
}
