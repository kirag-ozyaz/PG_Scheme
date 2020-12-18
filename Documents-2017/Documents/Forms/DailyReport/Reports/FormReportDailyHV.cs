using ControlsLbr.ReportViewerRus;
using Documents.Forms.DailyReport.DataSets;
using FormLbr;
using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
/// <summary>
/// Суточный рапорт в сетях 10/6 кВ
/// </summary>
internal class FormReportDailyHV : FormBase
{
    private BindingSource bindingSource_0;
    private CheckBox checkBox_0;
    private DataSetDamage dataSetDamage;
    private DateTimePicker dateTimePicker_0;
    private DateTimePicker dateTimePicker_1;
    private IContainer components=null;
    private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
    private ToolStrip toolStrip;
    private ToolStripButton toolBtnLoad;
    private ToolStripLabel toolStripLabel1;
    private ToolStripLabel toolStripLabel2;

    internal FormReportDailyHV()
    {
        this.InitializeComponent();
        this.dateTimePicker_0 = new DateTimePicker();
        this.dateTimePicker_0.Value = DateTime.Now.Date;
        this.toolStrip.Items.Insert(1, new ToolStripControlHost(this.dateTimePicker_0));
        this.dateTimePicker_1 = new DateTimePicker();
        this.dateTimePicker_1.Value = DateTime.Now.Date;
        this.toolStrip.Items.Insert(3, new ToolStripControlHost(this.dateTimePicker_1));
        this.checkBox_0 = new CheckBox();
        this.checkBox_0.Text = "Показать состав дежурных";
        this.checkBox_0.Checked = false;
        this.toolStrip.Items.Insert(4, new ToolStripControlHost(this.checkBox_0));
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FormReportDailyHV_Load(object sender, EventArgs e)
    {
        this.method_0();
    }

    private void method_0()
    {
        this.dataSetDamage.ReportDailyHV.Clear();
        this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Documents.Forms.DailyReport.Reports.ReportDailyHV.rdlc";
        string str = this.dateTimePicker_0.Value.ToString("dd.MM.yyyy");
        if (this.dateTimePicker_0.Value != this.dateTimePicker_1.Value)
        {
            str = this.dateTimePicker_0.Value.ToString("dd.MM.yyyy") + " - " + this.dateTimePicker_1.Value.ToString("dd.MM.yyyy");
        }
        this.reportViewerRus1.LocalReport.SetParameters(new ReportParameter("dateReport", str));
        this.reportViewerRus1.LocalReport.SetParameters(new ReportParameter("ShowDispatcher", this.checkBox_0.Checked.ToString()));
        using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                using (SqlCommand command = new SqlCommand(ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.ReportDailyHV.sql"), connection))
                {
                    command.CommandTimeout = 0;
                    command.Transaction = transaction;
                    command.Parameters.Add("dateBeg", SqlDbType.DateTime).Value = this.dateTimePicker_0.Value.Date;
                    command.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = this.dateTimePicker_1.Value.Date.AddDays(1.0).AddMilliseconds(-1.0);
                    new SqlDataAdapter(command).Fill(this.dataSetDamage.ReportDailyHV);
                }
                using (SqlCommand command2 = new SqlCommand("select isnull(w.fio, u.name) as name from tuser u\r\n\t                                left join vr_worker w on u.idWorker = w.id\r\n                                    where login = SYSTEM_USER", connection))
                {
                    command2.CommandTimeout = 0;
                    command2.Transaction = transaction;
                    DataTable dataTable = new DataTable();
                    new SqlDataAdapter(command2).Fill(dataTable);
                    if ((dataTable.Rows.Count > 0) && (dataTable.Rows[0]["name"] != DBNull.Value))
                    {
                        this.reportViewerRus1.LocalReport.SetParameters(new ReportParameter("reportUser", dataTable.Rows[0]["name"].ToString()));
                    }
                }
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                MessageBox.Show(exception.Message, exception.Source);
            }
            finally
            {
                if (transaction != null)
                {
                    transaction.Dispose();
                }
            }
        }
        this.reportViewerRus1.RefreshReport();
    }

    private void InitializeComponent()
    {
        this.components = new Container();
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FormReportDailyHV));
        ReportDataSource item = new ReportDataSource();
        this.bindingSource_0 = new BindingSource(this.components);
        this.dataSetDamage = new DataSetDamage();
        this.toolStrip = new ToolStrip();
        this.toolStripLabel1 = new ToolStripLabel();
        this.toolStripLabel2 = new ToolStripLabel();
        this.toolBtnLoad = new ToolStripButton();
        this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.dataSetDamage.BeginInit();
        this.toolStrip.SuspendLayout();
        base.SuspendLayout();
        this.bindingSource_0.DataMember = "ReportDailyHV";
        this.bindingSource_0.DataSource = this.dataSetDamage;
        this.dataSetDamage.DataSetName = "DataSetDamage";
        this.dataSetDamage.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripLabel1, this.toolStripLabel2, this.toolBtnLoad };
        this.toolStrip.Items.AddRange(toolStripItems);
        this.toolStrip.Location = new Point(0, 0);
        this.toolStrip.Name = "toolStrip";
        this.toolStrip.Size = new Size(810, 0x19);
        this.toolStrip.TabIndex = 1;
        this.toolStrip.Text = "toolStrip1";
        this.toolStripLabel1.Name = "toolStripLabel1";
        this.toolStripLabel1.Size = new Size(0x58, 0x16);
        this.toolStripLabel1.Text = "Выбор даты от";
        this.toolStripLabel2.Name = "toolStripLabel2";
        this.toolStripLabel2.Size = new Size(20, 0x16);
        this.toolStripLabel2.Text = "до";
        this.toolBtnLoad.DisplayStyle = ToolStripItemDisplayStyle.Text;
        this.toolBtnLoad.Image = (Image) resources.GetObject("toolBtnLoad.Image");
        this.toolBtnLoad.ImageTransparentColor = Color.Magenta;
        this.toolBtnLoad.Name = "toolBtnLoad";
        this.toolBtnLoad.Size = new Size(0x4a, 0x16);
        this.toolBtnLoad.Text = "Применить";
        this.toolBtnLoad.Click += new EventHandler(this.toolBtnLoad_Click);
        this.reportViewerRus1.Dock = DockStyle.Fill;
        item.Name = "DataSetReport";
        item.Value = this.bindingSource_0;
        this.reportViewerRus1.LocalReport.DataSources.Add(item);
        this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Documents.Forms.DailyReport.Reports.ReportDailyHV.rdlc";
        this.reportViewerRus1.Location = new Point(0, 0x19);
        this.reportViewerRus1.Name = "reportViewerRus1";
        this.reportViewerRus1.Size = new Size(810, 480);
        this.reportViewerRus1.TabIndex = 2;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(810, 0x1f9);
        base.Controls.Add(this.reportViewerRus1);
        base.Controls.Add(this.toolStrip);
        base.Name = "FormReportDailyHV";
        this.Text = "Суточный рапорт в сетях 10/6 кВ";
        base.Load += new EventHandler(this.FormReportDailyHV_Load);
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.dataSetDamage.EndInit();
        this.toolStrip.ResumeLayout(false);
        this.toolStrip.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void toolBtnLoad_Click(object sender, EventArgs e)
    {
        this.method_0();
    }
}

