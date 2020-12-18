namespace Legal.Forms.FormRep
{
    partial class FormActPrint_Correct
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
            this.vGSchetFactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            ((System.ComponentModel.ISupportInitialize)(this.vG_SchetFactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGSchetFactBindingSource)).BeginInit();
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
            // vGSchetFactBindingSource
            // 
            this.vGSchetFactBindingSource.DataMember = "vG_SchetFact";
            this.vGSchetFactBindingSource.DataSource = this.dsCntVal;
            // 
            // reportViewerRus1
            // 
            this.reportViewerRus1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsSchetFact";
            reportDataSource1.Value = this.vG_SchetFactBindingSource;
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportAct_Correct.rdlc";
            this.reportViewerRus1.Location = new System.Drawing.Point(0, 0);
            this.reportViewerRus1.Name = "reportViewerRus1";
            this.reportViewerRus1.Size = new System.Drawing.Size(702, 515);
            this.reportViewerRus1.TabIndex = 0;
            // 
            // FormActPrint_Correct
            // 
            this.ClientSize = new System.Drawing.Size(702, 515);
            this.Controls.Add(this.reportViewerRus1);
            this.Name = "FormActPrint_Correct";
            this.Text = "Акт оказания услуг для сторнированных документов";
            this.Load += new System.EventHandler(this.FormActPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vG_SchetFactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGSchetFactBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet.dsCntVal dsCntVal;
        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
        private System.Windows.Forms.BindingSource vGSchetFactBindingSource;
        private System.Windows.Forms.BindingSource vG_SchetFactBindingSource;
    }
}
