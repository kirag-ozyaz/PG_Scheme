using System;
using System.ComponentModel;

namespace StatementsForME
{
    partial class FormReportRepairPlanned
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolBtnLoad = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSend = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.DataSetStatement = new StatementsForME.DataSetStatement();
            this.bsReportToManager = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvResultat = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilterN();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReportToManager)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolBtnLoad,
            this.toolBtnSend,
            this.toolStripButton2});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(923, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel1.Text = "Выбор даты от";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel2.Text = "до";
            // 
            // toolBtnLoad
            // 
            this.toolBtnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnLoad.Name = "toolBtnLoad";
            this.toolBtnLoad.Size = new System.Drawing.Size(95, 22);
            this.toolBtnLoad.Text = "Сформировать";
            this.toolBtnLoad.Click += new System.EventHandler(this.toolBtnLoad_Click);
            // 
            // toolBtnSend
            // 
            this.toolBtnSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSend.Name = "toolBtnSend";
            this.toolBtnSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolBtnSend.Size = new System.Drawing.Size(140, 22);
            this.toolBtnSend.Text = "Создать файл выгрузки";
            this.toolBtnSend.Click += new System.EventHandler(this.toolBtnSend_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(99, 22);
            this.toolStripButton2.Text = "Экспорт на сайт";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // DataSetStatement
            // 
            this.DataSetStatement.DataSetName = "DataSetStatement";
            this.DataSetStatement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvResultat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(923, 468);
            this.splitContainer1.SplitterDistance = 474;
            this.splitContainer1.TabIndex = 3;
            // 
            // dgvResultat
            // 
            this.dgvResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultat.Location = new System.Drawing.Point(0, 0);
            this.dgvResultat.Name = "dgvResultat";
            this.dgvResultat.Size = new System.Drawing.Size(474, 468);
            this.dgvResultat.TabIndex = 0;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(445, 468);
            this.webBrowser.TabIndex = 0;
            // 
            // FormReportRepairPlanned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 493);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormReportRepairPlanned";
            this.Text = "Формирование выгрузки плановых и ремонтных работ";
            this.Load += new System.EventHandler(this.FormReportRepairPlanned_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReportToManager)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolBtnLoad;
        private System.Windows.Forms.ToolStripButton toolBtnSend;
        private System.Windows.Forms.BindingSource bsReportToManager;
        //private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private DataSetStatement DataSetStatement;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser;
        // private System.Windows.Forms.DataGridView dgvResultat;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilterN dgvResultat;
    }
}