namespace Legal.Forms.FormRep
{
    partial class FormRepOrder
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerOrder = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.dsAbnDocum1 = new Legal.DataSet.dsAbnDocum();
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            this.bsOrder = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerOrder
            // 
            this.reportViewerOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GraphicPointOrder";
            reportDataSource1.Value = this.bsOrder;
            this.reportViewerOrder.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerOrder.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportGraphicOrder.rdlc";
            this.reportViewerOrder.Location = new System.Drawing.Point(0, 0);
            this.reportViewerOrder.Name = "reportViewerOrder";
            this.reportViewerOrder.Size = new System.Drawing.Size(686, 477);
            this.reportViewerOrder.TabIndex = 1;
            // 
            // dsAbnDocum1
            // 
            this.dsAbnDocum1.DataSetName = "dsAbnDocum";
            this.dsAbnDocum1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsOrder
            // 
            this.bsOrder.DataMember = "GraphicPointOrder";
            this.bsOrder.DataSource = this.dsAbn;
            // 
            // FormRepOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 477);
            this.Controls.Add(this.reportViewerOrder);
            this.Name = "FormRepOrder";
            this.Text = "Распоряжение на обследование";
            this.Load += new System.EventHandler(this.FormRepOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerOrder;
        private DataSet.dsAbnDocum dsAbnDocum1;
        private DataSet.DataSetAbn dsAbn;
        private System.Windows.Forms.BindingSource bsOrder;
    }
}