using Microsoft.Reporting.WinForms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormReportRequestForRepair
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	private System.ComponentModel.IContainer components =null;
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportRequestForRepair));
            this.bsJRequestForRepair = new System.Windows.Forms.BindingSource(this.components);
            this.dsReport = new RequestForRepairN.DataSets.DataSetDamage();
            this.bsJRequestForRepairDaily = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerRus = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnSettings = new System.Windows.Forms.ToolStripButton();
            this.cmdDivision = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBoxSR = new System.Windows.Forms.CheckedListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAplly = new System.Windows.Forms.Button();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxShowAdresses = new System.Windows.Forms.CheckBox();
            this.checkBoxIsAgreed = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBeg = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsJRequestForRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJRequestForRepairDaily)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsJRequestForRepair
            // 
            this.bsJRequestForRepair.DataMember = "vJ_RequestForRepair";
            this.bsJRequestForRepair.DataSource = this.dsReport;
            // 
            // dsReport
            // 
            this.dsReport.DataSetName = "DataSetGES";
            this.dsReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsJRequestForRepairDaily
            // 
            this.bsJRequestForRepairDaily.DataMember = "vJ_RequestForRepairDaily";
            this.bsJRequestForRepairDaily.DataSource = this.dsReport;
            // 
            // reportViewerRus
            // 
            this.reportViewerRus.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetGES";
            reportDataSource1.Value = this.bsJRequestForRepair;
            reportDataSource2.Name = "DataSetDaily";
            reportDataSource2.Value = this.bsJRequestForRepairDaily;
            this.reportViewerRus.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRus.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerRus.LocalReport.ReportEmbeddedResource = "RequestForRepairN.Documents.Reports.ReportrequestForRepairFull.rdlc";
            this.reportViewerRus.Location = new System.Drawing.Point(211, 0);
            this.reportViewerRus.Name = "reportViewerRus1";
            this.reportViewerRus.Size = new System.Drawing.Size(485, 494);
            this.reportViewerRus.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip);
            this.panel1.Controls.Add(this.cmdDivision);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkedListBoxSR);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonAplly);
            this.panel1.Controls.Add(this.txtObject);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBoxShowAdresses);
            this.panel1.Controls.Add(this.checkBoxIsAgreed);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePickerEnd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePickerBeg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 494);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnSettings});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(211, 25);
            this.toolStrip.TabIndex = 16;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolBtnSettings
            // 
            this.toolBtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSettings.Image = global::RequestForRepairN.Properties.Resources.Setting;
            this.toolBtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSettings.Name = "toolBtnSettings";
            this.toolBtnSettings.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSettings.Text = "Настройки";
            this.toolBtnSettings.Click += new System.EventHandler(this.toolBtnSettings_Click);
            // 
            // cmdDivision
            // 
            this.cmdDivision.FormattingEnabled = true;
            this.cmdDivision.Location = new System.Drawing.Point(9, 237);
            this.cmdDivision.Name = "cmdDivision";
            this.cmdDivision.Size = new System.Drawing.Size(199, 21);
            this.cmdDivision.TabIndex = 15;
            this.cmdDivision.SelectionChangeCommitted += new System.EventHandler(this.cmdDivision_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Подразделения";
            // 
            // checkedListBoxSR
            // 
            this.checkedListBoxSR.CheckOnClick = true;
            this.checkedListBoxSR.FormattingEnabled = true;
            this.checkedListBoxSR.Location = new System.Drawing.Point(9, 124);
            this.checkedListBoxSR.Name = "checkedListBoxSR";
            this.checkedListBoxSR.Size = new System.Drawing.Size(199, 94);
            this.checkedListBoxSR.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(114, 466);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(94, 25);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAplly
            // 
            this.buttonAplly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAplly.Location = new System.Drawing.Point(9, 466);
            this.buttonAplly.Name = "buttonAplly";
            this.buttonAplly.Size = new System.Drawing.Size(96, 25);
            this.buttonAplly.TabIndex = 11;
            this.buttonAplly.Text = "Сформировать";
            this.buttonAplly.UseVisualStyleBackColor = true;
            this.buttonAplly.Click += new System.EventHandler(this.buttonAplly_Click);
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(9, 323);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(199, 20);
            this.txtObject.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Отключаемы объект";
            // 
            // checkBoxShowAdresses
            // 
            this.checkBoxShowAdresses.AutoSize = true;
            this.checkBoxShowAdresses.Location = new System.Drawing.Point(9, 287);
            this.checkBoxShowAdresses.Name = "checkBoxShowAdresses";
            this.checkBoxShowAdresses.Size = new System.Drawing.Size(115, 17);
            this.checkBoxShowAdresses.TabIndex = 8;
            this.checkBoxShowAdresses.Text = "Выводить адреса";
            this.checkBoxShowAdresses.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsAgreed
            // 
            this.checkBoxIsAgreed.AutoSize = true;
            this.checkBoxIsAgreed.Location = new System.Drawing.Point(9, 264);
            this.checkBoxIsAgreed.Name = "checkBoxIsAgreed";
            this.checkBoxIsAgreed.Size = new System.Drawing.Size(155, 17);
            this.checkBoxIsAgreed.TabIndex = 7;
            this.checkBoxIsAgreed.Text = "Учитывать согласование";
            this.checkBoxIsAgreed.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сетевые районы";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(31, 76);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(177, 20);
            this.dateTimePickerEnd.TabIndex = 4;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "по";
            // 
            // dateTimePickerBeg
            // 
            this.dateTimePickerBeg.Location = new System.Drawing.Point(31, 50);
            this.dateTimePickerBeg.Name = "dateTimePickerBeg";
            this.dateTimePickerBeg.Size = new System.Drawing.Size(177, 20);
            this.dateTimePickerBeg.TabIndex = 2;
            this.dateTimePickerBeg.ValueChanged += new System.EventHandler(this.dateTimePickerBeg_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "с";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Период";
            // 
            // FormReportRequestForRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 494);
            this.Controls.Add(this.reportViewerRus);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FormReportRequestForRepair";
            this.Text = "Отчет заявок на ремонт оборудования";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReportRequestForRepair_FormClosed);
            this.Load += new System.EventHandler(this.FormReportRequestForRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsJRequestForRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJRequestForRepairDaily)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

    }



    private RequestForRepairN.DataSets.DataSetDamage dsReport;

    private BindingSource bsJRequestForRepair;

    private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus;

    private Panel panel1;

    private Button buttonClose;

    private Button buttonAplly;

    private TextBox txtObject;

    private Label label5;

    private CheckBox checkBoxShowAdresses;

    private CheckBox checkBoxIsAgreed;

    private Label label4;

    private DateTimePicker dateTimePickerEnd;

    private Label label3;

    private DateTimePicker dateTimePickerBeg;

    private Label label2;

    private Label label1;

    private BindingSource bsJRequestForRepairDaily;

    private CheckedListBox checkedListBoxSR;

    private ComboBox cmdDivision;

    private Label label6;

    private ToolStrip toolStrip;

    private ToolStripButton toolBtnSettings;

}
