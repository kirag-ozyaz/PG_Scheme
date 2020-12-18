namespace Legal.Forms.FormRep
{
    partial class FormInvPrint
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
            this.dsCntVal = new Legal.DataSet.dsCntVal();
            this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.vGSchetFactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGSchetFactBindingSource)).BeginInit();
            this.SuspendLayout();
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
            reportDataSource1.Value = this.vGSchetFactBindingSource;
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportInv.rdlc";
            this.reportViewerRus1.Location = new System.Drawing.Point(0, 0);
            this.reportViewerRus1.Name = "reportViewerRus1";
            this.reportViewerRus1.Size = new System.Drawing.Size(694, 481);
            this.reportViewerRus1.TabIndex = 0;
            // 
            // vGSchetFactBindingSource
            // 
            this.vGSchetFactBindingSource.DataMember = "vG_SchetFact";
            this.vGSchetFactBindingSource.DataSource = this.dsCntVal;
            // 
            // FormInvPrint
            // 
            this.ClientSize = new System.Drawing.Size(694, 481);
            this.Controls.Add(this.reportViewerRus1);
            this.Name = "FormInvPrint";
            this.Load += new System.EventHandler(this.FormInvPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGSchetFactBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
        private DataSet.dsCntVal dsCntVal;
        private System.Windows.Forms.BindingSource vGSchetFactBindingSource;
    }
}
