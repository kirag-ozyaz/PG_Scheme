namespace Legal.Forms
{
    partial class FormSchetPrint
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vG_SchetPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCntVal = new Legal.DataSet.dsCntVal();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vGSchetPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.vG_SchetPrintTariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vG_SchetPrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGSchetPrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vG_SchetPrintTariffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vG_SchetPrintBindingSource
            // 
            this.vG_SchetPrintBindingSource.DataMember = "vG_SchetPrint";
            this.vG_SchetPrintBindingSource.DataSource = this.dsCntVal;
            this.vG_SchetPrintBindingSource.Sort = "";
            // 
            // dsCntVal
            // 
            this.dsCntVal.DataSetName = "dsCntVal";
            this.dsCntVal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vG_SchetPrintTariff";
            this.bindingSource1.DataSource = this.dsCntVal;
            // 
            // vGSchetPrintBindingSource
            // 
            this.vGSchetPrintBindingSource.DataMember = "vG_SchetPrint";
            this.vGSchetPrintBindingSource.DataSource = this.dsCntVal;
            // 
            // reportViewerRus1
            // 
            this.reportViewerRus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerRus1.DocumentMapWidth = 20;
            reportDataSource1.Name = "dsSchetPrint";
            reportDataSource1.Value = this.vG_SchetPrintBindingSource;
            reportDataSource2.Name = "dsSchetPrintTariff";
            reportDataSource2.Value = this.bindingSource1;
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerRus1.LocalReport.DisplayName = "Счет для оплаты";
            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportSchet.rdlc";
            this.reportViewerRus1.Location = new System.Drawing.Point(0, 0);
            this.reportViewerRus1.Name = "reportViewerRus1";
            this.reportViewerRus1.Size = new System.Drawing.Size(702, 515);
            this.reportViewerRus1.TabIndex = 1;
            // 
            // vG_SchetPrintTariffBindingSource
            // 
            this.vG_SchetPrintTariffBindingSource.DataMember = "vG_SchetPrintTariff";
            this.vG_SchetPrintTariffBindingSource.DataSource = this.dsCntVal;
            // 
            // FormSchetPrint
            // 
            this.ClientSize = new System.Drawing.Size(702, 515);
            this.Controls.Add(this.reportViewerRus1);
            this.Name = "FormSchetPrint";
            this.Load += new System.EventHandler(this.FormSchetPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vG_SchetPrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGSchetPrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vG_SchetPrintTariffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet.dsCntVal dsCntVal;
        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
        private System.Windows.Forms.BindingSource vGSchetPrintBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource vG_SchetPrintBindingSource;
        private System.Windows.Forms.BindingSource vG_SchetPrintTariffBindingSource;
    }
}
