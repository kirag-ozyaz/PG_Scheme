namespace Legal.Forms.FormRep
{
    partial class FormRegisterPrint
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
            this.vG_RegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCntVal = new Legal.DataSet.dsCntVal();
            this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.vGRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vG_RegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGRegisterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vG_RegisterBindingSource
            // 
            this.vG_RegisterBindingSource.DataMember = "vG_Register";
            this.vG_RegisterBindingSource.DataSource = this.dsCntVal;
            // 
            // dsCntVal
            // 
            this.dsCntVal.DataSetName = "dsCntVal";
            this.dsCntVal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerRus1
            // 
            this.reportViewerRus1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsRegister";
            reportDataSource1.Value = this.vGRegisterBindingSource;
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportRegister.rdlc";
            this.reportViewerRus1.Location = new System.Drawing.Point(0, 0);
            this.reportViewerRus1.Name = "reportViewerRus1";
            this.reportViewerRus1.Size = new System.Drawing.Size(678, 413);
            this.reportViewerRus1.TabIndex = 0;
            // 
            // vGRegisterBindingSource
            // 
            this.vGRegisterBindingSource.DataMember = "vG_Register";
            this.vGRegisterBindingSource.DataSource = this.dsCntVal;
            // 
            // FormRegisterPrint
            // 
            this.ClientSize = new System.Drawing.Size(678, 413);
            this.Controls.Add(this.reportViewerRus1);
            this.Name = "FormRegisterPrint";
            this.Text = "Реестры платежных требований";
            this.Load += new System.EventHandler(this.FormRegisterPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vG_RegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGRegisterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
        private DataSet.dsCntVal dsCntVal;
        private System.Windows.Forms.BindingSource vG_RegisterBindingSource;
        private System.Windows.Forms.BindingSource vGRegisterBindingSource;
    }
}
