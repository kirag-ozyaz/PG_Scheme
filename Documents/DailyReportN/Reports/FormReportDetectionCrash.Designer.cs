//using DailyReport.Reports;
using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormReportDetectionCrash : FormLbr.FormBase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkLV = new System.Windows.Forms.CheckBox();
            this.chkHV = new System.Windows.Forms.CheckBox();
            this.chkInfoExtended = new System.Windows.Forms.CheckBox();
            this.grpAct = new System.Windows.Forms.GroupBox();
            this.rBtnCrashAct = new System.Windows.Forms.RadioButton();
            this.rBtnAllAct = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rBtnPeriod = new System.Windows.Forms.RadioButton();
            this.rBtnYear = new System.Windows.Forms.RadioButton();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsBtnAddFilter = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelFilter = new System.Windows.Forms.ToolStripButton();
            this.rptView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.grpAct.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkLV);
            this.panel1.Controls.Add(this.chkHV);
            this.panel1.Controls.Add(this.chkInfoExtended);
            this.panel1.Controls.Add(this.grpAct);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grpDate);
            this.panel1.Controls.Add(this.tsMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(200, 571);
            this.panel1.TabIndex = 0;
            // 
            // chkLV
            // 
            this.chkLV.AutoSize = true;
            this.chkLV.Location = new System.Drawing.Point(12, 399);
            this.chkLV.Name = "chkLV";
            this.chkLV.Size = new System.Drawing.Size(129, 17);
            this.chkLV.TabIndex = 12;
            this.chkLV.Text = "Низкое напряжение";
            this.chkLV.UseVisualStyleBackColor = true;
            // 
            // chkHV
            // 
            this.chkHV.AutoSize = true;
            this.chkHV.Location = new System.Drawing.Point(12, 375);
            this.chkHV.Name = "chkHV";
            this.chkHV.Size = new System.Drawing.Size(136, 17);
            this.chkHV.TabIndex = 11;
            this.chkHV.Text = "Высокое напряжение";
            this.chkHV.UseVisualStyleBackColor = true;
            // 
            // chkInfoExtended
            // 
            this.chkInfoExtended.AutoSize = true;
            this.chkInfoExtended.Location = new System.Drawing.Point(12, 341);
            this.chkInfoExtended.Name = "chkInfoExtended";
            this.chkInfoExtended.Size = new System.Drawing.Size(156, 17);
            this.chkInfoExtended.TabIndex = 10;
            this.chkInfoExtended.Text = "Развернутый отчет (2020)";
            this.chkInfoExtended.UseVisualStyleBackColor = true;
            // 
            // grpAct
            // 
            this.grpAct.Controls.Add(this.rBtnCrashAct);
            this.grpAct.Controls.Add(this.rBtnAllAct);
            this.grpAct.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAct.Location = new System.Drawing.Point(3, 266);
            this.grpAct.Name = "grpAct";
            this.grpAct.Size = new System.Drawing.Size(194, 68);
            this.grpAct.TabIndex = 1;
            this.grpAct.TabStop = false;
            this.grpAct.Text = "Акты";
            // 
            // rBtnCrashAct
            // 
            this.rBtnCrashAct.AutoSize = true;
            this.rBtnCrashAct.Location = new System.Drawing.Point(9, 42);
            this.rBtnCrashAct.Name = "rBtnCrashAct";
            this.rBtnCrashAct.Size = new System.Drawing.Size(110, 17);
            this.rBtnCrashAct.TabIndex = 8;
            this.rBtnCrashAct.TabStop = true;
            this.rBtnCrashAct.Text = "Аварийные акты";
            this.rBtnCrashAct.UseVisualStyleBackColor = true;
            // 
            // rBtnAllAct
            // 
            this.rBtnAllAct.AutoSize = true;
            this.rBtnAllAct.Checked = true;
            this.rBtnAllAct.Location = new System.Drawing.Point(9, 19);
            this.rBtnAllAct.Name = "rBtnAllAct";
            this.rBtnAllAct.Size = new System.Drawing.Size(72, 17);
            this.rBtnAllAct.TabIndex = 7;
            this.rBtnAllAct.TabStop = true;
            this.rBtnAllAct.Text = "Все акты";
            this.rBtnAllAct.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtPost);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 176);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(194, 90);
            this.panel2.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Location = new System.Drawing.Point(0, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 20);
            this.txtName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 43);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // txtPost
            // 
            this.txtPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPost.Location = new System.Drawing.Point(0, 23);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(194, 20);
            this.txtPost.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Должность";
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.cmbYear);
            this.grpDate.Controls.Add(this.dtpDateEnd);
            this.grpDate.Controls.Add(this.dtpDateBegin);
            this.grpDate.Controls.Add(this.label3);
            this.grpDate.Controls.Add(this.label2);
            this.grpDate.Controls.Add(this.rBtnPeriod);
            this.grpDate.Controls.Add(this.rBtnYear);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDate.Location = new System.Drawing.Point(3, 28);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(194, 148);
            this.grpDate.TabIndex = 0;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Дата";
            // 
            // cmbYear
            // 
            this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(9, 41);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(179, 21);
            this.cmbYear.TabIndex = 1;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Enabled = false;
            this.dtpDateEnd.Location = new System.Drawing.Point(34, 117);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(154, 20);
            this.dtpDateEnd.TabIndex = 4;
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.dtpDateEnd_ValueChanged);
            // 
            // dtpDateBegin
            // 
            this.dtpDateBegin.Enabled = false;
            this.dtpDateBegin.Location = new System.Drawing.Point(34, 91);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.Size = new System.Drawing.Size(154, 20);
            this.dtpDateBegin.TabIndex = 3;
            this.dtpDateBegin.ValueChanged += new System.EventHandler(this.dtpDateBegin_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "по:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "с:";
            // 
            // rBtnPeriod
            // 
            this.rBtnPeriod.AutoSize = true;
            this.rBtnPeriod.Location = new System.Drawing.Point(9, 68);
            this.rBtnPeriod.Name = "rBtnPeriod";
            this.rBtnPeriod.Size = new System.Drawing.Size(63, 17);
            this.rBtnPeriod.TabIndex = 2;
            this.rBtnPeriod.TabStop = true;
            this.rBtnPeriod.Text = "Период";
            this.rBtnPeriod.UseVisualStyleBackColor = true;
            // 
            // rBtnYear
            // 
            this.rBtnYear.AutoSize = true;
            this.rBtnYear.Checked = true;
            this.rBtnYear.Location = new System.Drawing.Point(9, 19);
            this.rBtnYear.Name = "rBtnYear";
            this.rBtnYear.Size = new System.Drawing.Size(43, 17);
            this.rBtnYear.TabIndex = 0;
            this.rBtnYear.TabStop = true;
            this.rBtnYear.Text = "Год";
            this.rBtnYear.UseVisualStyleBackColor = true;
            this.rBtnYear.CheckedChanged += new System.EventHandler(this.rBtnYear_CheckedChanged);
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAddFilter,
            this.tsBtnDelFilter});
            this.tsMain.Location = new System.Drawing.Point(3, 3);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(194, 25);
            this.tsMain.TabIndex = 9;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsBtnAddFilter
            // 
            this.tsBtnAddFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnAddFilter.Image = global::DailyReportN.Properties.Resources.filter;
            this.tsBtnAddFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAddFilter.Name = "tsBtnAddFilter";
            this.tsBtnAddFilter.Size = new System.Drawing.Size(23, 22);
            this.tsBtnAddFilter.Text = "Применить фильтр";
            this.tsBtnAddFilter.Click += new System.EventHandler(this.tsBtnAddFilter_Click);
            // 
            // tsBtnDelFilter
            // 
            this.tsBtnDelFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDelFilter.Image = global::DailyReportN.Properties.Resources.filter_delete;
            this.tsBtnDelFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelFilter.Name = "tsBtnDelFilter";
            this.tsBtnDelFilter.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDelFilter.Text = "Сбросить фильтр";
            this.tsBtnDelFilter.Click += new System.EventHandler(this.tsBtnDelFilter_Click);
            // 
            // rptView
            // 
            this.rptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptView.Location = new System.Drawing.Point(200, 0);
            this.rptView.Name = "rView";
            this.rptView.Size = new System.Drawing.Size(625, 571);
            this.rptView.TabIndex = 1;
            // 
            // FormReportDetectionCrash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 571);
            this.Controls.Add(this.rptView);
            this.Controls.Add(this.panel1);
            this.Name = "FormReportDetectionCrash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бюллетень аварийных отключений (N)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReportDetectionCrash_FormClosing);
            this.Load += new System.EventHandler(this.FormReportDetectionCrash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpAct.ResumeLayout(false);
            this.grpAct.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);

    }



    private Panel panel1;

    private ReportViewer rptView;

    private GroupBox grpAct;

    private RadioButton rBtnCrashAct;

    private RadioButton rBtnAllAct;

    private Panel panel2;

    private TextBox txtName;

    private Label label1;

    private GroupBox grpDate;

    private DateTimePicker dtpDateEnd;

    private DateTimePicker dtpDateBegin;

    private Label label3;

    private Label label2;

    private RadioButton rBtnPeriod;

    private RadioButton rBtnYear;

    private ToolStrip tsMain;

    private ToolStripButton tsBtnAddFilter;

    private ToolStripButton tsBtnDelFilter;

    private ComboBox cmbYear;

    private TextBox txtPost;

    private Label label4;
    private CheckBox chkInfoExtended;
    private CheckBox chkLV;
    private CheckBox chkHV;
}
