using ControlsLbr.ReportViewerRus;
using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


	public partial class FormReportCalcLossTrans 
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
            this.dtSourceBindingSource = new BindingSource(this.components);
            this.dsCalcN = new CalcLossN.DataSet.DataSetCalc();
            this.reportViewer1 = new ReportViewerRus();
            this.panelIsp = new Panel();
            this.txtFIOBoss = new TextBox();
            this.label5 = new Label();
            this.txtTitleJob = new TextBox();
            this.label4 = new Label();
            this.dateTimePicker = new DateTimePicker();
            this.label3 = new Label();
            this.txtPhone = new TextBox();
            this.label2 = new Label();
            this.txtFIO = new TextBox();
            this.label1 = new Label();
            ((ISupportInitialize)this.dtSourceBindingSource).BeginInit();
            ((ISupportInitialize)this.dsCalcN).BeginInit();
            this.panelIsp.SuspendLayout();
            base.SuspendLayout();
            this.dtSourceBindingSource.DataMember = "dtSource";
            this.dtSourceBindingSource.DataSource = this.dsCalcN;
            this.dsCalcN.DataSetName = "dsCalc";
            this.dsCalcN.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.reportViewer1.Dock = DockStyle.Fill;
            reportDataSource.Name = "dsSource";
            reportDataSource.Value = this.dtSourceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalcLossN.Report.ReportTransHH.rdlc";
            this.reportViewer1.Location = new Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new Size(813, 440);
            this.reportViewer1.TabIndex = 0;
            this.panelIsp.Controls.Add(this.txtFIOBoss);
            this.panelIsp.Controls.Add(this.label5);
            this.panelIsp.Controls.Add(this.txtTitleJob);
            this.panelIsp.Controls.Add(this.label4);
            this.panelIsp.Controls.Add(this.dateTimePicker);
            this.panelIsp.Controls.Add(this.label3);
            this.panelIsp.Controls.Add(this.txtPhone);
            this.panelIsp.Controls.Add(this.label2);
            this.panelIsp.Controls.Add(this.txtFIO);
            this.panelIsp.Controls.Add(this.label1);
            this.panelIsp.Dock = DockStyle.Bottom;
            this.panelIsp.Location = new Point(0, 440);
            this.panelIsp.Name = "panelIsp";
            this.panelIsp.Size = new Size(813, 95);
            this.panelIsp.TabIndex = 1;
            this.txtFIOBoss.Location = new Point(283, 19);
            this.txtFIOBoss.Name = "txtFIOBoss";
            this.txtFIOBoss.Size = new Size(174, 20);
            this.txtFIOBoss.TabIndex = 9;
            this.txtFIOBoss.Text = "Гулько И.А.";
            this.txtFIOBoss.TextChanged += new EventHandler(this.txtFIOBoss_TextChanged);
            this.label5.AutoSize = true;
            this.label5.Location = new Point(280, 3);
            this.label5.Name = "label5";
            this.label5.Size = new Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ФИО";
            this.txtTitleJob.Location = new Point(12, 19);
            this.txtTitleJob.Name = "txtTitleJob";
            this.txtTitleJob.Size = new Size(251, 20);
            this.txtTitleJob.TabIndex = 7;
            this.txtTitleJob.Text = "Начальник СКиУЭЭ";
            this.txtTitleJob.TextChanged += new EventHandler(this.txtTitleJob_TextChanged);
            this.label4.AutoSize = true;
            this.label4.Location = new Point(12, 3);
            this.label4.Name = "label4";
            this.label4.Size = new Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Должность";
            this.dateTimePicker.Location = new Point(495, 62);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new Size(146, 20);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.ValueChanged += new EventHandler(this.dateTimePicker_ValueChanged);
            this.label3.AutoSize = true;
            this.label3.Location = new Point(492, 46);
            this.label3.Name = "label3";
            this.label3.Size = new Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата";
            this.txtPhone.Location = new Point(283, 62);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new Size(174, 20);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextChanged += new EventHandler(this.txtPhone_TextChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new Point(280, 46);
            this.label2.Name = "label2";
            this.label2.Size = new Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон";
            this.txtFIO.Location = new Point(12, 62);
            this.txtFIO.Name = "txtFIO";
            this.txtFIO.Size = new Size(251, 20);
            this.txtFIO.TabIndex = 1;
            this.txtFIO.TextChanged += new EventHandler(this.txtFIO_TextChanged);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исполнитель";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(813, 535);
            base.Controls.Add(this.reportViewer1);
            base.Controls.Add(this.panelIsp);
            base.Name = "FormReportCalcLossTrans";
            this.Text = "Печать расчета потерь (трансформаторы)";
            base.FormClosing += new FormClosingEventHandler(this.FormReportCalcLossTrans_FormClosing);
            base.Load += new EventHandler(this.FormReportCalcLossTrans_Load);
            ((ISupportInitialize)this.dtSourceBindingSource).EndInit();
            ((ISupportInitialize)this.dsCalcN).EndInit();
            this.panelIsp.ResumeLayout(false);
            this.panelIsp.PerformLayout();
            base.ResumeLayout(false);
        }
        private ReportViewerRus reportViewer1;
        private CalcLossN.DataSet.DataSetCalc dsCalcN;
        private Panel panelIsp;
        private DateTimePicker dateTimePicker;
        private Label label3;
        private TextBox txtPhone;
        private Label label2;
        private TextBox txtFIO;
        private Label label1;
        private TextBox txtFIOBoss;
        private Label label5;
        private TextBox txtTitleJob;
        private Label label4;
        private BindingSource dtSourceBindingSource;

    }

