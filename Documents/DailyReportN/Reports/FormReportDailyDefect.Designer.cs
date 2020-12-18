using ControlsLbr.ReportViewerRus;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormReportDailyDefect : FormLbr.FormBase
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	private System.ComponentModel.IContainer components = null;
    private void InitializeComponent()
    {
        this.components = new Container();
        ReportDataSource reportDataSource = new ReportDataSource();
        this.bsDailyDefect = new BindingSource(this.components);
        this.dsDamage = new DailyReportN.DataSet.dsDamage();
        this.panel1 = new Panel();
        this.chkListBoxDivision = new CheckedListBox();
        this.buttonLoad = new Button();
        this.dtpEnd = new DateTimePicker();
        this.label5 = new Label();
        this.dtpBeg = new DateTimePicker();
        this.label4 = new Label();
        this.label3 = new Label();
        this.label2 = new Label();
        this.label1 = new Label();
        this.txtForWhom = new TextBox();
        this.txt2 = new TextBox();
        this.txt1 = new TextBox();
        this.rptViewer = new ReportViewerRus();
        this.chkFullReport = new CheckBox();
        this.chkNotApply = new CheckBox();
        this.chkDefectLocation = new CheckBox();
        ((ISupportInitialize)this.bsDailyDefect).BeginInit();
        ((ISupportInitialize)this.dsDamage).BeginInit();
        this.panel1.SuspendLayout();
        base.SuspendLayout();
        this.bsDailyDefect.DataMember = "ReportDailyDefect";
        this.bsDailyDefect.DataSource = this.dsDamage;
        this.dsDamage.DataSetName = "dsDamage";
        this.dsDamage.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.panel1.Controls.Add(this.chkListBoxDivision);
        this.panel1.Controls.Add(this.buttonLoad);
        this.panel1.Controls.Add(this.dtpEnd);
        this.panel1.Controls.Add(this.label5);
        this.panel1.Controls.Add(this.dtpBeg);
        this.panel1.Controls.Add(this.label4);
        this.panel1.Controls.Add(this.label3);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.txtForWhom);
        this.panel1.Controls.Add(this.txt2);
        this.panel1.Controls.Add(this.txt1);
        this.panel1.Dock = DockStyle.Top;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(798, 100);
        this.panel1.TabIndex = 0;
        this.chkListBoxDivision.CheckOnClick = true;
        this.chkListBoxDivision.FormattingEnabled = true;
        this.chkListBoxDivision.Location = new Point(369, 12);
        this.chkListBoxDivision.Name = "chkListBoxDivision";
        this.chkListBoxDivision.Size = new Size(165, 79);
        this.chkListBoxDivision.TabIndex = 11;
        this.buttonLoad.Location = new Point(540, 64);
        this.buttonLoad.Name = "buttonLoad";
        this.buttonLoad.Size = new Size(75, 23);
        this.buttonLoad.TabIndex = 10;
        this.buttonLoad.Text = "Применить";
        this.buttonLoad.UseVisualStyleBackColor = true;
        this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
        this.dtpEnd.Location = new Point(632, 38);
        this.dtpEnd.Name = "dtpEnd";
        this.dtpEnd.Size = new Size(152, 20);
        this.dtpEnd.TabIndex = 9;
        this.label5.AutoSize = true;
        this.label5.Location = new Point(537, 41);
        this.label5.Name = "label5";
        this.label5.Size = new Size(89, 13);
        this.label5.TabIndex = 8;
        this.label5.Text = "Дата окончания";
        this.dtpBeg.Location = new Point(631, 12);
        this.dtpBeg.Name = "dtpBeg";
        this.dtpBeg.Size = new Size(152, 20);
        this.dtpBeg.TabIndex = 7;
        this.label4.AutoSize = true;
        this.label4.Location = new Point(537, 15);
        this.label4.Name = "label4";
        this.label4.Size = new Size(71, 13);
        this.label4.TabIndex = 6;
        this.label4.Text = "Дата начала";
        this.label3.AutoSize = true;
        this.label3.Location = new Point(12, 67);
        this.label3.Name = "label3";
        this.label3.Size = new Size(54, 13);
        this.label3.TabIndex = 5;
        this.label3.Text = "Для кого";
        this.label2.AutoSize = true;
        this.label2.Location = new Point(12, 41);
        this.label2.Name = "label2";
        this.label2.Size = new Size(49, 13);
        this.label2.TabIndex = 4;
        this.label2.Text = "Шапка 2";
        this.label1.AutoSize = true;
        this.label1.Location = new Point(12, 15);
        this.label1.Name = "label1";
        this.label1.Size = new Size(49, 13);
        this.label1.TabIndex = 3;
        this.label1.Text = "Шапка 1";
        this.txtForWhom.Location = new Point(72, 64);
        this.txtForWhom.Name = "txtForWhom";
        this.txtForWhom.Size = new Size(279, 20);
        this.txtForWhom.TabIndex = 2;
        this.txtForWhom.Leave +=new System.EventHandler (this.txt1_Leave);
        this.txt2.Location = new Point(72, 38);
        this.txt2.Name = "txt2";
        this.txt2.Size = new Size(279, 20);
        this.txt2.TabIndex = 1;
        this.txt2.Leave += new System.EventHandler(this.txt1_Leave);
        this.txt1.Location = new Point(72, 12);
        this.txt1.Name = "txt1";
        this.txt1.Size = new Size(279, 20);
        this.txt1.TabIndex = 0;
        this.txt1.Leave += new System.EventHandler(this.txt1_Leave);
        this.rptViewer.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        reportDataSource.Name = "DataSetReportDailyDefect";
        reportDataSource.Value = this.bsDailyDefect;
        this.rptViewer.LocalReport.DataSources.Add(reportDataSource);
        this.rptViewer.LocalReport.ReportEmbeddedResource = "DailyReportN.Reports.ReportDailyDefect.rdlc";
        this.rptViewer.Location = new Point(0, 100);
        this.rptViewer.Name = "reportViewerRus1";
        this.rptViewer.Size = new Size(798, 419);
        this.rptViewer.TabIndex = 1;
        this.chkFullReport.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        this.chkFullReport.AutoSize = true;
        this.chkFullReport.Location = new Point(12, 525);
        this.chkFullReport.Name = "chkFullReport";
        this.chkFullReport.Size = new Size(123, 17);
        this.chkFullReport.TabIndex = 2;
        this.chkFullReport.Text = "Развернутый отчет";
        this.chkFullReport.UseVisualStyleBackColor = true;
        this.chkFullReport.CheckedChanged += this.chkFullReport_CheckedChanged;
        this.chkNotApply.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        this.chkNotApply.AutoSize = true;
        this.chkNotApply.Location = new Point(141, 525);
        this.chkNotApply.Name = "chkNotApply";
        this.chkNotApply.Size = new Size(110, 17);
        this.chkNotApply.TabIndex = 3;
        this.chkNotApply.Text = "Невыполненные";
        this.chkNotApply.UseVisualStyleBackColor = true;
        this.chkNotApply.CheckedChanged += new System.EventHandler(this.chkNotApply_CheckedChanged);
        this.chkDefectLocation.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        this.chkDefectLocation.AutoSize = true;
        this.chkDefectLocation.Checked = true;
        this.chkDefectLocation.CheckState = CheckState.Checked;
        this.chkDefectLocation.Location = new Point(257, 525);
        this.chkDefectLocation.Name = "chkDefectLocation";
        this.chkDefectLocation.Size = new Size(180, 17);
        this.chkDefectLocation.TabIndex = 4;
        this.chkDefectLocation.Text = "Показать место повреждения";
        this.chkDefectLocation.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(798, 550);
        base.Controls.Add(this.chkDefectLocation);
        base.Controls.Add(this.chkNotApply);
        base.Controls.Add(this.chkFullReport);
        base.Controls.Add(this.rptViewer);
        base.Controls.Add(this.panel1);
        base.Name = "FormReportDailyDefect";
        this.Text = "Суточный рапорт по дефектам";
        base.FormClosing +=new FormClosingEventHandler( this.FormReportDailyDefect_FormClosing);
        base.Load += new System.EventHandler(this.FormReportDailyDefect_Load);
        ((ISupportInitialize)this.bsDailyDefect).EndInit();
        ((ISupportInitialize)this.dsDamage).EndInit();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private DataTable dataTableSettings;

    private List<int> ListDivision;

    private Panel panel1;

    private Button buttonLoad;

    private DateTimePicker dtpEnd;

    private Label label5;

    private DateTimePicker dtpBeg;

    private Label label4;

    private Label label3;

    private Label label2;

    private Label label1;

    private TextBox txtForWhom;

    private TextBox txt2;

    private TextBox txt1;

    private ReportViewerRus rptViewer;

    private BindingSource bsDailyDefect;

    private DailyReportN.DataSet.dsDamage dsDamage;

    private CheckedListBox chkListBoxDivision;

    private CheckBox chkFullReport;

    private CheckBox chkNotApply;

    private CheckBox chkDefectLocation;
}
