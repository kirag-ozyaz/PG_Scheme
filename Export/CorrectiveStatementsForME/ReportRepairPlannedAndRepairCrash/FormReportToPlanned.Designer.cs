namespace StatementsForME
{
    partial class FormReportToPlanned
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportToPlanned));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolBtnLoad = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSend = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.bsReportToManager = new System.Windows.Forms.BindingSource(this.components);
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetStatement = new StatementsForME.DataSetStatement();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReportToManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatement)).BeginInit();
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
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
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
            this.toolBtnSend.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSend.Image")));
            this.toolBtnSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSend.Name = "toolBtnSend";
            this.toolBtnSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolBtnSend.Size = new System.Drawing.Size(69, 22);
            this.toolBtnSend.Text = "Отправить";
            this.toolBtnSend.Click += new System.EventHandler(this.toolBtnSend_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(105, 22);
            this.toolStripButton2.Text = "Экспорт в эксель";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewer.Location = new System.Drawing.Point(0, 25);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ShowExportButton = false;
            this.rptViewer.Size = new System.Drawing.Size(800, 425);
            this.rptViewer.TabIndex = 3;
            this.rptViewer.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.rptViewer_ReportRefresh);
            // 
            // DataSetStatement
            // 
            this.DataSetStatement.DataSetName = "DataSetStatement";
            this.DataSetStatement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormReportToPlanned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptViewer);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormReportToPlanned";
            this.Text = "Отчет по ремонтным работам";
            this.Load += new System.EventHandler(this.FormReportToManager_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReportToManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStatement)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private DataSetStatement DataSetStatement;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}