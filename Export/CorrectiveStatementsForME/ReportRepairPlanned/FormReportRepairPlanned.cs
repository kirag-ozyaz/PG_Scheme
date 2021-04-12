using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
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
    /// Выгрузка на сайт по работам (плановым, ремонтным в электросетях)
    /// </summary>
    public partial class FormReportRepairPlanned : FormBase
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

        StatementsPlannedToSite rpt;

        public FormReportRepairPlanned()
        {
            InitializeComponent();
        }
        private void FormReportRepairPlanned_Load(object sender, EventArgs e)
        {

            rpt = new StatementsPlannedToSite();
            rpt.SqlSettings = this.SqlSettings;
            DataBeg = rpt.DataBeg;
            DataEnd = rpt.DataEnd;
            Interval = rpt.Interval;

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
            //this.tbInterval.TextChanged += new EventHandler(tbPeriodToBeginDay_TextChanged);
            this.tbInterval.ReadOnly = true;

            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lInterval,
            this.tbInterval});
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            DataEnd = ((DateTimePicker)sender).Value;
            rpt.DataEnd = DataEnd;
            //
            this.tbInterval.Text = (DataEnd.Subtract(DataBeg).Days + 1).ToString();
        }

        private void dateTimePickerBegin_ValueChanged(object sender, EventArgs e)
        {
            DataBeg = ((DateTimePicker)sender).Value;
            rpt.DataBeg = DataBeg;
        }

        private void toolBtnLoad_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            DataTable tableResult = rpt.LoadData();
            foreach (DataColumn col in tableResult.Columns)
            {
                DataGridViewFilterTextBoxColumn columnDgv = new DataGridViewFilterTextBoxColumn();
                columnDgv.Name = col.ColumnName;
                columnDgv.HeaderText = col.ColumnName;
                columnDgv.DataPropertyName = col.ColumnName;

                dgvResultat.Columns.Add(columnDgv);

            }
            BindingSource bsResult = new BindingSource();
            bsResult.DataSource = tableResult;
            dgvResultat.DataSource = bsResult;
        }

        private void toolBtnSend_Click(object sender, EventArgs e)
        {
            rpt.ToPHP();
            if (rpt.PathName.Length > 0 && rpt.PathName[rpt.PathName.Length - 1] != '\\')
            {
                rpt.PathName += "\\";
            }
            webBrowser.Url = new Uri(rpt.PathName + rpt.FileName);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rpt.ToPHP();
            rpt.UploadFileToFTP();
            // надо отработать выгрузку событий СЭСНО
            // rpt.UploadFileToFTP(IdSESNO);
        }

        private void rptViewer_ReportRefresh(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
