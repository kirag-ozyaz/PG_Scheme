using ControlsLbr.ReportViewerRus;
using Documents.DataSets;
using FormLbr;
using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form41 : FormBase
{
    private BindingSource bindingSource_0;
    private BindingSource bindingSource_1;
    private DataSetGES dataSetGES_0;
    private IContainer icontainer_0;
    private int int_0 = -1;
    private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus_0;

    public Form41(int int_1)
    {
        this.method_0();
        this.int_0 = int_1;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form41_Load(object sender, EventArgs e)
    {
        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_Request, true, " where id = " + this.int_0.ToString());
        base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestDoc, true, "where idRequest = " + this.int_0.ToString());
        this.reportViewerRus_0.RefreshReport();
    }

    private void method_0()
    {
        this.icontainer_0 = new Container();
        ReportDataSource item = new ReportDataSource();
        ReportDataSource source2 = new ReportDataSource();
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.dataSetGES_0 = new DataSetGES();
        this.reportViewerRus_0 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
        this.bindingSource_1 = new BindingSource(this.icontainer_0);
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.dataSetGES_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_1).BeginInit();
        base.SuspendLayout();
        this.bindingSource_0.DataMember = "vJ_Request";
        this.bindingSource_0.DataSource = this.dataSetGES_0;
        this.dataSetGES_0.DataSetName = "DataSetGES";
        this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.reportViewerRus_0.Dock = DockStyle.Fill;
        item.Name = "DataSetGES";
        item.Value = this.bindingSource_0;
        source2.Name = "DataSetDoc";
        source2.Value = this.bindingSource_1;
        this.reportViewerRus_0.LocalReport.DataSources.Add(item);
        this.reportViewerRus_0.LocalReport.DataSources.Add(source2);
        this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalRequest.ReportRequest.rdlc";
        this.reportViewerRus_0.Location = new Point(0, 0);
        this.reportViewerRus_0.Name = "reportViewerRus1";
        this.reportViewerRus_0.Size = new Size(0x198, 0x106);
        this.reportViewerRus_0.TabIndex = 0;
        this.bindingSource_1.DataMember = "tJ_RequestDoc";
        this.bindingSource_1.DataSource = this.dataSetGES_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x198, 0x106);
        base.Controls.Add(this.reportViewerRus_0);
        base.Name = "FormReportRequest";
        this.Text = "Печать задлачи";
        base.Load += new EventHandler(this.Form41_Load);
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.dataSetGES_0.EndInit();
        ((ISupportInitialize) this.bindingSource_1).EndInit();
        base.ResumeLayout(false);
    }
}

