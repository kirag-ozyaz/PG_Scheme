using ControlsLbr.ReportViewerRus;
using DailyReport.DataSets;
using FormLbr;
using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
/// <summary>
/// Суточный рапорт в сетях 0,4 кВ (ОДС)
/// </summary>
internal class FormReportDailyLV : FormBase
{
    private BindingSource bindingSource_0;
    private BindingSource bindingSource_1;
    private CheckBox checkBox_0;
    private dsDamage dataSetDamage_0;
    private DateTimePicker dateTimePicker_0;
    private IContainer components=null;
    private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
    private ToolStrip toolStrip_0;
    private ToolStripButton toolBtnLoad;
    private ToolStripLabel toolStripLabel_0;

    internal FormReportDailyLV()
    {
        this.InitializeComponent();
        this.dateTimePicker_0 = new DateTimePicker();
        this.dateTimePicker_0.Value = DateTime.Now.Date;
        this.toolStrip_0.Items.Insert(1, new ToolStripControlHost(this.dateTimePicker_0));
        this.checkBox_0 = new CheckBox();
        this.checkBox_0.Text = "Разбить по районам";
        this.toolStrip_0.Items.Insert(2, new ToolStripControlHost(this.checkBox_0));
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FormReportDailyLV_Load(object sender, EventArgs e)
    {
        this.method_0();
    }

    private void method_0()
    {
        this.dataSetDamage_0.ReportDailyLV.Clear();
        this.dataSetDamage_0.vJ_Temperature.Clear();
        this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Documents.Forms.DailyReport.Reports.ReportDailyLV.rdlc";
        this.reportViewerRus1.LocalReport.SetParameters(new ReportParameter("dateReport", this.dateTimePicker_0.Value.ToString()));
        bool flag = !this.checkBox_0.Checked;
        this.reportViewerRus1.LocalReport.SetParameters(new ReportParameter("GroupNetRegion", flag.ToString()));
        using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT t.[id],t.[DateTemp],t.[NightDown],t.[NightUp],t.[DayDown],t.[DayUp],t.[TempAverage],t.[Wind]\r\n                                            ,c.name as windname,t.[SpeedDown],t.[SpeedUp],t.[Comment],t.[DateOwner],t.[idOwner],t.[Owner]\r\n                                    FROM [tJ_Temperature] t\r\n                                             LEFT JOIN tr_Classifier c on c.id = t.wind\r\n                                    WHERE t.dateTEmp = @date", connection))
                {
                    command.CommandTimeout = 0;
                    command.Transaction = transaction;
                    command.Parameters.Add("date", SqlDbType.DateTime).Value = this.dateTimePicker_0.Value.Date;
                    new SqlDataAdapter(command).Fill(this.dataSetDamage_0.vJ_Temperature);
                }
                if (this.dataSetDamage_0.vJ_Temperature.Rows.Count > 0)
                {
                    using (SqlCommand command2 = new SqlCommand(Library.ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.ReportDailyLV.sql"), connection))
                    {
                        command2.CommandTimeout = 0;
                        command2.Transaction = transaction;
                        command2.Parameters.Add("date", SqlDbType.DateTime).Value = this.dateTimePicker_0.Value.Date;
                        new SqlDataAdapter(command2).Fill(this.dataSetDamage_0.ReportDailyLV);
                    }
                    using (SqlCommand command3 = new SqlCommand("select isnull(w.fio, u.name) as name from tuser u\r\n\t                                left join vr_worker w on u.idWorker = w.id\r\n                                    where login = SYSTEM_USER", connection))
                    {
                        command3.CommandTimeout = 0;
                        command3.Transaction = transaction;
                        DataTable dataTable = new DataTable();
                        new SqlDataAdapter(command3).Fill(dataTable);
                        if ((dataTable.Rows.Count > 0) && (dataTable.Rows[0]["name"] != DBNull.Value))
                        {
                            this.reportViewerRus1.LocalReport.SetParameters(new ReportParameter("reportUser", dataTable.Rows[0]["name"].ToString()));
                        }
                        goto Label_027E;
                    }
                }
                this.reportViewerRus1.LocalReport.ReportEmbeddedResource = null;
                MessageBox.Show("На данную дату не введены показания температуры");
            Label_027E:
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FormReportDailyLV));
        ReportDataSource item = new ReportDataSource();
        ReportDataSource source2 = new ReportDataSource();
        this.bindingSource_0 = new BindingSource(this.components);
        this.dataSetDamage_0 = new dsDamage();
        this.bindingSource_1 = new BindingSource(this.components);
        this.toolStrip_0 = new ToolStrip();
        this.toolStripLabel_0 = new ToolStripLabel();
        this.toolBtnLoad = new ToolStripButton();
        this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.dataSetDamage_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_1).BeginInit();
        this.toolStrip_0.SuspendLayout();
        base.SuspendLayout();
        this.bindingSource_0.DataMember = "ReportDailyLV";
        this.bindingSource_0.DataSource = this.dataSetDamage_0;
        this.dataSetDamage_0.DataSetName = "DataSetDamage";
        this.dataSetDamage_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.bindingSource_1.DataMember = "vJ_Temperature";
        this.bindingSource_1.DataSource = this.dataSetDamage_0;
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripLabel_0, this.toolBtnLoad };
        this.toolStrip_0.Items.AddRange(toolStripItems);
        this.toolStrip_0.Location = new Point(0, 0);
        this.toolStrip_0.Name = "toolStrip";
        this.toolStrip_0.Size = new Size(0x2ef, 0x19);
        this.toolStrip_0.TabIndex = 0;
        this.toolStrip_0.Text = "toolStrip1";
        this.toolStripLabel_0.Name = "toolStripLabel1";
        this.toolStripLabel_0.Size = new Size(0x49, 0x16);
        this.toolStripLabel_0.Text = "Выбор даты";
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
        source2.Name = "DataSetTemperature";
        source2.Value = this.bindingSource_1;
        this.reportViewerRus1.LocalReport.DataSources.Add(item);
        this.reportViewerRus1.LocalReport.DataSources.Add(source2);
        this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Documents.Forms.DailyReport.Reports.ReportDailyLV.rdlc";
        this.reportViewerRus1.Location = new Point(0, 0x19);
        this.reportViewerRus1.Name = "reportViewerRus1";
        this.reportViewerRus1.Size = new Size(0x2ef, 0x1e8);
        this.reportViewerRus1.TabIndex = 1;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x2ef, 0x201);
        base.Controls.Add(this.reportViewerRus1);
        base.Controls.Add(this.toolStrip_0);
        base.Name = "FormReportDailyLV";
        this.Text = "Суточный рапорт в сетях 0,4 кВ (ОДС)";
        base.Load += new EventHandler(this.FormReportDailyLV_Load);
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.dataSetDamage_0.EndInit();
        ((ISupportInitialize) this.bindingSource_1).EndInit();
        this.toolStrip_0.ResumeLayout(false);
        this.toolStrip_0.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void toolBtnLoad_Click(object sender, EventArgs e)
    {
        this.method_0();
    }
}

