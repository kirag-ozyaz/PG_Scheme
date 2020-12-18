using ControlsLbr.ReportViewerRus;
using Microsoft.Reporting.WinForms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormReportDailyHV : FormLbr.FormBase
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	private System.ComponentModel.IContainer components=null;
    private void InitializeComponent()
    {
        this.components = new Container();
        ComponentResourceManager resource = new ComponentResourceManager(typeof(FormReportDailyHV));
        ReportDataSource reportDataSource = new ReportDataSource();
        this.bsReportDailyHV = new BindingSource(this.components);
        this.dsDamage = new DailyReportN.DataSet.dsDamage();
        this.toolStrip = new ToolStrip();
        this.toolStripLabel1 = new ToolStripLabel();
        this.toolStripLabel2 = new ToolStripLabel();
        this.toolBtnLoad = new ToolStripButton();
        this.rptViewer = new ReportViewerRus();
        ((ISupportInitialize)this.bsReportDailyHV).BeginInit();
        ((ISupportInitialize)this.dsDamage).BeginInit();
        this.toolStrip.SuspendLayout();
        base.SuspendLayout();
        this.bsReportDailyHV.DataMember = "ReportDailyHV";
        this.bsReportDailyHV.DataSource = this.dsDamage;
        this.dsDamage.DataSetName = "DataSetDamage";
        this.dsDamage.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.toolStrip.Items.AddRange(new ToolStripItem[]
        {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolBtnLoad
        });
        this.toolStrip.Location = new Point(0, 0);
        this.toolStrip.Name = "toolStrip";
        this.toolStrip.Size = new Size(810, 25);
        this.toolStrip.TabIndex = 1;
        this.toolStrip.Text = "toolStrip1";
        this.toolStripLabel1.Name = "toolStripLabel1";
        this.toolStripLabel1.Size = new Size(88, 22);
        this.toolStripLabel1.Text = "Выбор даты от";
        this.toolStripLabel2.Name = "toolStripLabel2";
        this.toolStripLabel2.Size = new Size(20, 22);
        this.toolStripLabel2.Text = "до";
        this.toolBtnLoad.DisplayStyle = ToolStripItemDisplayStyle.Text;
        this.toolBtnLoad.Image = (Image)global::DailyReportN.Properties.Resources.Load;
        this.toolBtnLoad.ImageTransparentColor = Color.Magenta;
        this.toolBtnLoad.Name = "toolBtnLoad";
        this.toolBtnLoad.Size = new Size(74, 22);
        this.toolBtnLoad.Text = "Применить";
        this.toolBtnLoad.Click +=new System.EventHandler( this.toolBtnLoad_Click);
        this.rptViewer.Dock = DockStyle.Fill;
        reportDataSource.Name = "DataSetReport";
        reportDataSource.Value = this.bsReportDailyHV;
        this.rptViewer.LocalReport.DataSources.Add(reportDataSource);
        this.rptViewer.LocalReport.ReportEmbeddedResource = "DailyReportN.Reports.ReportDailyHV.rdlc";
        this.rptViewer.Location = new Point(0, 25);
        this.rptViewer.Name = "rptViewer";
        this.rptViewer.Size = new Size(810, 480);
        this.rptViewer.TabIndex = 2;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new Size(810, 505);
        base.Controls.Add(this.rptViewer);
        base.Controls.Add(this.toolStrip);
        base.Name = "FormReportDailyHV";
        this.Text = "Суточный рапорт в сетях 10/6 кВ";
        base.Load +=new System.EventHandler( this.FormReportDailyHV_Load);
        ((ISupportInitialize)this.bsReportDailyHV).EndInit();
        ((ISupportInitialize)this.dsDamage).EndInit();
        this.toolStrip.ResumeLayout(false);
        this.toolStrip.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }



    private ToolStrip toolStrip;

    private ToolStripLabel toolStripLabel1;

    private ToolStripButton toolBtnLoad;

    private ReportViewerRus rptViewer;

    private ToolStripLabel toolStripLabel2;

    private DailyReportN.DataSet.dsDamage dsDamage;

    private BindingSource bsReportDailyHV;
}
