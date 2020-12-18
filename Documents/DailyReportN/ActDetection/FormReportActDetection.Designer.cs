using System.Windows.Forms;

namespace DailyReportN.JournalActDetection
{
    partial class FormReportActDetection
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
            this.dataSetDamage = new DailyReportN.DataSet.dsDamage();
            this.bsDamage = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetDamage
            // 
            this.dataSetDamage.DataSetName = "DataSetDamage";
            this.dataSetDamage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsDamage
            // 
            this.bsDamage.DataMember = "tJ_Damage";
            this.bsDamage.DataSource = this.dataSetDamage;
            // 
            // FormReportActDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 419);
            this.Name = "FormReportActDetection";
            this.Text = "Акт расследования причин аварии, произошедшей";
            this.Load += new System.EventHandler(this.FormReportActDetection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet.dsDamage dataSetDamage;
        private BindingSource bsDamage;
    }
}