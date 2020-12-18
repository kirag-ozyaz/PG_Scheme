using ControlsLbr.ReportViewerRus;
using Microsoft.Reporting.WinForms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormReportDailyLV : FormLbr.FormBase
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
        ComponentResourceManager resource = new ComponentResourceManager(typeof(FormReportDailyLV));
        ReportDataSource DataSetReport = new ReportDataSource();
        ReportDataSource DataSetTemperature = new ReportDataSource();
        this.bsReportDailyLV = new BindingSource(this.components);
        this.dsDamage = new DailyReportN.DataSet.dsDamage();
        this.bsTemperature = new BindingSource(this.components);
        this.toolStrip = new ToolStrip();
        this.toolStripLabel1 = new ToolStripLabel();
        this.toolBtnLoad = new ToolStripButton();
        this.rptViewer = new ReportViewerRus();
        ((ISupportInitialize)this.bsReportDailyLV).BeginInit();
        ((ISupportInitialize)this.dsDamage).BeginInit();
        ((ISupportInitialize)this.bsTemperature).BeginInit();
        this.toolStrip.SuspendLayout();
        base.SuspendLayout();
        this.bsReportDailyLV.DataMember = "ReportDailyLV";
        this.bsReportDailyLV.DataSource = this.dsDamage;
        this.dsDamage.DataSetName = "DataSetDamage";
        this.dsDamage.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.bsTemperature.DataMember = "vJ_Temperature";
        this.bsTemperature.DataSource = this.dsDamage;
        this.toolStrip.Items.AddRange(new ToolStripItem[]
        {
            this.toolStripLabel1,
            this.toolBtnLoad
        });
        this.toolStrip.Location = new Point(0, 0);
        this.toolStrip.Name = "toolStrip";
        this.toolStrip.Size = new Size(751, 25);
        this.toolStrip.TabIndex = 0;
        this.toolStrip.Text = "toolStrip1";
        this.toolStripLabel1.Name = "toolStripLabel1";
        this.toolStripLabel1.Size = new Size(73, 22);
        this.toolStripLabel1.Text = "Выбор даты";
        this.toolBtnLoad.DisplayStyle = ToolStripItemDisplayStyle.Text;
        this.toolBtnLoad.Image = (Image)global::DailyReportN.Properties.Resources.Load;
        this.toolBtnLoad.ImageTransparentColor = Color.Magenta;
        this.toolBtnLoad.Name = "toolBtnLoad";
        this.toolBtnLoad.Size = new Size(74, 22);
        this.toolBtnLoad.Text = "Применить";
        this.toolBtnLoad.Click +=new System.EventHandler (this.toolBtnLoad_Click);
        this.rptViewer.Dock = DockStyle.Fill;
        DataSetReport.Name = "DataSetReport";
        DataSetReport.Value = this.bsReportDailyLV;
        DataSetTemperature.Name = "DataSetTemperature";
        DataSetTemperature.Value = this.bsTemperature;
        this.rptViewer.LocalReport.DataSources.Add(DataSetReport);
        this.rptViewer.LocalReport.DataSources.Add(DataSetTemperature);
        this.rptViewer.LocalReport.ReportEmbeddedResource = "DailyReportN.Reports.ReportDailyLV.rdlc";
        this.rptViewer.Location = new Point(0, 25);
        this.rptViewer.Name = "rptViewer";
        this.rptViewer.Size = new Size(751, 488);
        this.rptViewer.TabIndex = 1;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new Size(751, 513);
        base.Controls.Add(this.rptViewer);
        base.Controls.Add(this.toolStrip);
        base.Name = "FormReportDailyLV";
        this.Text = "Суточный рапорт в сетях 0,4 кВ (ОДС)";
        base.Load +=new System.EventHandler( this.FormReportDailyLV_Load);
        ((ISupportInitialize)this.bsReportDailyLV).EndInit();
        ((ISupportInitialize)this.dsDamage).EndInit();
        ((ISupportInitialize)this.bsTemperature).EndInit();
        this.toolStrip.ResumeLayout(false);
        this.toolStrip.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }



    private ToolStrip toolStrip;

    private ToolStripLabel toolStripLabel1;

    private ToolStripButton toolBtnLoad;

    private ReportViewerRus rptViewer;

    private BindingSource bsReportDailyLV;

    private DailyReportN.DataSet.dsDamage dsDamage;

    private BindingSource bsTemperature;

}
