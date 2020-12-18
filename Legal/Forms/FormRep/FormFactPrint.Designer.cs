namespace Legal.Forms.FormRep
{
    partial class FormFactPrint
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vG_SchetFactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCntVal = new Legal.DataSet.dsCntVal();
            this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            ((System.ComponentModel.ISupportInitialize)(this.vG_SchetFactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).BeginInit();
            this.SuspendLayout();
            // 
            // vG_SchetFactBindingSource
            // 
            this.vG_SchetFactBindingSource.DataMember = "vG_SchetFact";
            this.vG_SchetFactBindingSource.DataSource = this.dsCntVal;
            // 
            // dsCntVal
            // 
            this.dsCntVal.DataSetName = "dsCntVal";
            this.dsCntVal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerRus1
            // 
            this.reportViewerRus1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsSchetFact";
            reportDataSource1.Value = this.vG_SchetFactBindingSource;
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportFact.rdlc";
            this.reportViewerRus1.Location = new System.Drawing.Point(0, 0);
            this.reportViewerRus1.Name = "reportViewerRus1";
            this.reportViewerRus1.Size = new System.Drawing.Size(702, 515);
            this.reportViewerRus1.TabIndex = 0;
            // 
            // FormFactPrint
            // 
            this.ClientSize = new System.Drawing.Size(702, 515);
            this.Controls.Add(this.reportViewerRus1);
            this.Name = "FormFactPrint";
            this.Load += new System.EventHandler(this.FormFactPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vG_SchetFactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
        private DataSet.dsCntVal dsCntVal;
        private System.Windows.Forms.BindingSource vG_SchetFactBindingSource;
    }
}
