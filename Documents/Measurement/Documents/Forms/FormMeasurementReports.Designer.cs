using Measurement.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Windows.Forms;

namespace Documents.Measurement
{

    partial class FormMeasurementReports
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rpGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsMeasurementN = new DataSetMeasurementN();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chbWitnName = new System.Windows.Forms.CheckBox();
            this.chbHideNameObj = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasurementN)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpGeneral
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rpGeneral, 2);
            this.rpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpGeneral.Location = new System.Drawing.Point(3, 32);
            this.rpGeneral.Name = "rwGeneral";
            this.rpGeneral.Size = new System.Drawing.Size(659, 475);
            this.rpGeneral.TabIndex = 0;
            // 
            // dsMeasurementN
            // 
            this.dsMeasurementN.DataSetName = "DataSetMeasurementN";
            this.dsMeasurementN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rpGeneral, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chbWitnName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chbHideNameObj, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(665, 510);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chbWitnName
            // 
            this.chbWitnName.AutoSize = true;
            this.chbWitnName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbWitnName.Location = new System.Drawing.Point(15, 3);
            this.chbWitnName.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.chbWitnName.Name = "chbWitnName";
            this.chbWitnName.Size = new System.Drawing.Size(192, 23);
            this.chbWitnName.TabIndex = 1;
            this.chbWitnName.Text = "с наименованием";
            this.chbWitnName.UseVisualStyleBackColor = true;
            this.chbWitnName.CheckedChanged += new System.EventHandler(this.chbWitnName_CheckedChanged);
            // 
            // chbHideNameObj
            // 
            this.chbHideNameObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbHideNameObj.Location = new System.Drawing.Point(213, 3);
            this.chbHideNameObj.Name = "chbHideNameObj";
            this.chbHideNameObj.Size = new System.Drawing.Size(449, 23);
            this.chbHideNameObj.TabIndex = 2;
            this.chbHideNameObj.Text = "Скрыть столбец \"Наименование\" объекта";
            this.chbHideNameObj.UseVisualStyleBackColor = true;
            this.chbHideNameObj.CheckedChanged += new System.EventHandler(this.chbHideNameObj_CheckedChanged);
            // 
            // FormMeasurementReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMeasurementReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMeasurementReports";
            this.Load += new System.EventHandler(this.FormMeasurementReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasurementN)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.CheckBox chbWitnName;
        private System.Windows.Forms.CheckBox chbHideNameObj;
        private DataSetMeasurementN dsMeasurementN;
        private Microsoft.Reporting.WinForms.ReportViewer rpGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
