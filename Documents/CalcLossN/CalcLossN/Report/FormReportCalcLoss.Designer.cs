using ControlsLbr.ReportViewerRus;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


	public partial class FormReportCalcLoss
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
            this.reportViewer1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.dsCalcN = new CalcLossN.DataSet.DataSetCalc();
            this.panelIsp = new System.Windows.Forms.Panel();
            this.txtFIOBoss = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitleJob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FIOPerformer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalcN)).BeginInit();
            this.panelIsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalcLossN.Report.ReportKL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(816, 440);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsCalcN
            // 
            this.dsCalcN.DataSetName = "dsCalc";
            this.dsCalcN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelIsp
            // 
            this.panelIsp.Controls.Add(this.txtFIOBoss);
            this.panelIsp.Controls.Add(this.label5);
            this.panelIsp.Controls.Add(this.txtTitleJob);
            this.panelIsp.Controls.Add(this.label4);
            this.panelIsp.Controls.Add(this.dateTimePicker);
            this.panelIsp.Controls.Add(this.label3);
            this.panelIsp.Controls.Add(this.txtPhone);
            this.panelIsp.Controls.Add(this.label2);
            this.panelIsp.Controls.Add(this.FIOPerformer);
            this.panelIsp.Controls.Add(this.label1);
            this.panelIsp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIsp.Location = new System.Drawing.Point(0, 440);
            this.panelIsp.Name = "panelIsp";
            this.panelIsp.Size = new System.Drawing.Size(816, 95);
            this.panelIsp.TabIndex = 1;
            // 
            // txtFIOBoss
            // 
            this.txtFIOBoss.Location = new System.Drawing.Point(283, 19);
            this.txtFIOBoss.Name = "txtFIOBoss";
            this.txtFIOBoss.Size = new System.Drawing.Size(174, 20);
            this.txtFIOBoss.TabIndex = 9;
            this.txtFIOBoss.Text = "Гулько И.А.";
            this.txtFIOBoss.TextChanged += new System.EventHandler(this.txtFIOBoss_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ФИО";
            // 
            // txtTitleJob
            // 
            this.txtTitleJob.Location = new System.Drawing.Point(12, 19);
            this.txtTitleJob.Name = "txtTitleJob";
            this.txtTitleJob.Size = new System.Drawing.Size(251, 20);
            this.txtTitleJob.TabIndex = 7;
            this.txtTitleJob.Text = "Начальник СКиУЭЭ";
            this.txtTitleJob.TextChanged += new System.EventHandler(this.txtTitleJob_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Должность";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(495, 62);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(283, 62);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(174, 20);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон";
            // 
            // FIOPerformer
            // 
            this.FIOPerformer.Location = new System.Drawing.Point(12, 62);
            this.FIOPerformer.Name = "FIOPerformer";
            this.FIOPerformer.Size = new System.Drawing.Size(251, 20);
            this.FIOPerformer.TabIndex = 1;
            this.FIOPerformer.TextChanged += new System.EventHandler(this.txtFIO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исполнитель";
            // 
            // FormReportCalcLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 535);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelIsp);
            this.Name = "FormReportCalcLoss";
            this.Text = "Печать расчета потерь (кабельные/воздушные линии)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReportCalcLoss_FormClosing);
            this.Load += new System.EventHandler(this.FormReportCalcLoss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCalcN)).EndInit();
            this.panelIsp.ResumeLayout(false);
            this.panelIsp.PerformLayout();
            this.ResumeLayout(false);

        }

        private ReportViewerRus reportViewer1;
        private CalcLossN.DataSet.DataSetCalc dsCalcN;
        private Panel panelIsp;
        private DateTimePicker dateTimePicker;
        private Label label3;
        private TextBox txtPhone;
        private Label label2;
        private TextBox FIOPerformer;
        private Label label1;
        private TextBox txtFIOBoss;
        private Label label5;
        private TextBox txtTitleJob;
        private Label label4;
    }

