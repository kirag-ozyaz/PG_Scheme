using Microsoft.Reporting.WinForms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormReportInterruptLV : FormLbr.FormBase
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
        ReportDataSource reportDataSource = new ReportDataSource();
        this.bsReportIterruptLV = new BindingSource(this.components);
        this.dsDamage = new DailyReportN.DataSet.dsDamage();
        this.dtpBegin = new DateTimePicker();
        this.dtpEnd = new DateTimePicker();
        this.label1 = new Label();
        this.label2 = new Label();
        this.panel1 = new Panel();
        this.btnApply = new Button();
        this.checkBoxApprove = new CheckBox();
        this.rViewerDoc = new ReportViewer();
        this.txtFIO = new TextBox();
        this.txtPost = new TextBox();
        this.label4 = new Label();
        this.label3 = new Label();
        ((ISupportInitialize)this.bsReportIterruptLV).BeginInit();
        ((ISupportInitialize)this.dsDamage).BeginInit();
        this.panel1.SuspendLayout();
        base.SuspendLayout();
        this.bsReportIterruptLV.DataMember = "tReportIterruptLV";
        this.bsReportIterruptLV.DataSource = this.dsDamage;
        this.dsDamage.DataSetName = "DataSetDamage";
        this.dsDamage.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.dtpBegin.Anchor = AnchorStyles.Top;
        this.dtpBegin.Location = new Point(342, 8);
        this.dtpBegin.Name = "dtpBegin";
        this.dtpBegin.Size = new Size(131, 20);
        this.dtpBegin.TabIndex = 0;
        this.dtpBegin.ValueChanged +=new System.EventHandler( this.dtpBegin_ValueChanged);
        this.dtpEnd.Anchor = AnchorStyles.Top;
        this.dtpEnd.Location = new Point(523, 8);
        this.dtpEnd.Name = "dtpEnd";
        this.dtpEnd.Size = new Size(131, 20);
        this.dtpEnd.TabIndex = 1;
        this.dtpEnd.ValueChanged +=new System.EventHandler(this.dtpEnd_ValueChanged);
        this.label1.Anchor = AnchorStyles.Top;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(282, 14);
        this.label1.Name = "label1";
        this.label1.Size = new Size(54, 13);
        this.label1.TabIndex = 2;
        this.label1.Text = "Период с";
        this.label2.Anchor = AnchorStyles.Top;
        this.label2.AutoSize = true;
        this.label2.Location = new Point(498, 14);
        this.label2.Name = "label2";
        this.label2.Size = new Size(19, 13);
        this.label2.TabIndex = 3;
        this.label2.Text = "по";
        this.panel1.Controls.Add(this.txtFIO);
        this.panel1.Controls.Add(this.btnApply);
        this.panel1.Controls.Add(this.txtPost);
        this.panel1.Controls.Add(this.checkBoxApprove);
        this.panel1.Controls.Add(this.label4);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.label3);
        this.panel1.Controls.Add(this.dtpBegin);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.dtpEnd);
        this.panel1.Dock = DockStyle.Top;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(890, 90);
        this.panel1.TabIndex = 5;
        this.btnApply.Anchor = AnchorStyles.Top;
        this.btnApply.Location = new Point(669, 5);
        this.btnApply.Name = "btnApply";
        this.btnApply.Size = new Size(75, 23);
        this.btnApply.TabIndex = 5;
        this.btnApply.Text = "Применить";
        this.btnApply.UseVisualStyleBackColor = true;
        this.btnApply.Click +=new System.EventHandler( this.btnApply_Click);
        this.checkBoxApprove.AutoSize = true;
        this.checkBoxApprove.Location = new Point(12, 13);
        this.checkBoxApprove.Name = "checkBoxApprove";
        this.checkBoxApprove.Size = new Size(160, 17);
        this.checkBoxApprove.TabIndex = 4;
        this.checkBoxApprove.Text = "Показать \"УТВЕРЖДАЮ\"";
        this.checkBoxApprove.UseVisualStyleBackColor = true;
        this.checkBoxApprove.CheckedChanged +=new System.EventHandler( this.checkBoxcheckBoxApprove_CheckedChanged);
        this.rViewerDoc.Dock = DockStyle.Fill;
        reportDataSource.Name = "dsReport";
        reportDataSource.Value = this.bsReportIterruptLV;
        this.rViewerDoc.LocalReport.DataSources.Add(reportDataSource);
        this.rViewerDoc.LocalReport.ReportEmbeddedResource = "DailyReportN.Reports.reportInterruptLV.rdlc";
        this.rViewerDoc.Location = new Point(0, 90);
        this.rViewerDoc.Name = "rViewerDoc";
        this.rViewerDoc.Size = new Size(890, 454);
        this.rViewerDoc.TabIndex = 6;
        this.txtFIO.Location = new Point(86, 62);
        this.txtFIO.Name = "txtFIO";
        this.txtFIO.Size = new Size(302, 20);
        this.txtFIO.TabIndex = 3;
        this.txtFIO.Leave +=new System.EventHandler( this.txtFIO_Leave);
        this.txtPost.Location = new Point(86, 36);
        this.txtPost.Name = "txtPost";
        this.txtPost.Size = new Size(302, 20);
        this.txtPost.TabIndex = 2;
        this.txtPost.Leave +=new System.EventHandler( this.txtPost_Leave);
        this.label4.AutoSize = true;
        this.label4.Location = new Point(12, 63);
        this.label4.Name = "label4";
        this.label4.Size = new Size(37, 13);
        this.label4.TabIndex = 1;
        this.label4.Text = "ФИО:";
        this.label3.AutoSize = true;
        this.label3.Location = new Point(12, 39);
        this.label3.Name = "label3";
        this.label3.Size = new Size(68, 13);
        this.label3.TabIndex = 0;
        this.label3.Text = "Должность:";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(890, 544);
        base.Controls.Add(this.rViewerDoc);
        base.Controls.Add(this.panel1);
        base.Name = "FormReportInterruptLV";
        this.Text = "Бюллетень перерывов электроснабжения в сетях 0,4 кВ";
        base.FormClosed +=new FormClosedEventHandler (this.FormReportInterruptLV_FormClosed);
        base.Load +=new System.EventHandler (this.FormReportInterruptLV_Load);
        ((ISupportInitialize)this.bsReportIterruptLV).EndInit();
        ((ISupportInitialize)this.dsDamage).EndInit();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        base.ResumeLayout(false);
    }


    private DateTimePicker dtpBegin;
    private DateTimePicker dtpEnd;
    private Label label1;
    private Label label2;
    private Panel panel1;
    private ReportViewer rViewerDoc;
    private BindingSource bsReportIterruptLV;
    private DailyReportN.DataSet.dsDamage dsDamage;
    private TextBox txtFIO;
    private TextBox txtPost;
    private Label label4;
    private Label label3;
    private CheckBox checkBoxApprove;
    private Button btnApply;
}
