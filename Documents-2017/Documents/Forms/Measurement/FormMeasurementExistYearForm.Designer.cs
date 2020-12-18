using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Documents.Forms.Measurement
{
    partial class FormMeasurementExistYearForm
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
            this.components = new System.ComponentModel.Container();
            this.dataSet = new System.Data.DataSet();
            this.dtMeasExistTable = new System.Data.DataTable();
            this.tpname = new System.Data.DataColumn();
            this.transname = new System.Data.DataColumn();
            this.type = new System.Data.DataColumn();
            this.dt_tJ_Measurement = new System.Data.DataTable();
            this.year = new System.Data.DataColumn();
            this.dataGridViewExcelFilterMeasExist = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.tpnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasExistTable = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxFromYear = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxToYear = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonToExcel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMeasExistTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_tJ_Measurement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelFilterMeasExist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasExistTable)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dtMeasExistTable,
            this.dt_tJ_Measurement});
            // 
            // dtMeasExistTable
            // 
            this.dtMeasExistTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.tpname,
            this.transname,
            this.type});
            this.dtMeasExistTable.TableName = "MeasExistTable";
            // 
            // tpname
            // 
            this.tpname.ColumnName = "tpname";
            // 
            // transname
            // 
            this.transname.ColumnName = "transname";
            // 
            // type
            // 
            this.type.ColumnName = "type";
            // 
            // dt_tJ_Measurement
            // 
            this.dt_tJ_Measurement.Columns.AddRange(new System.Data.DataColumn[] {
            this.year});
            this.dt_tJ_Measurement.TableName = "tJ_Measurement";
            // 
            // year
            // 
            this.year.ColumnName = "year";
            this.year.DataType = typeof(int);
            // 
            // dataGridViewExcelFilterMeasExist
            // 
            this.dataGridViewExcelFilterMeasExist.AllowUserToAddRows = false;
            this.dataGridViewExcelFilterMeasExist.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilterMeasExist.AutoGenerateColumns = false;
            this.dataGridViewExcelFilterMeasExist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExcelFilterMeasExist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcelFilterMeasExist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tpnameDataGridViewTextBoxColumn,
            this.transnameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridViewExcelFilterMeasExist.DataSource = this.MeasExistTable;
            this.dataGridViewExcelFilterMeasExist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExcelFilterMeasExist.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewExcelFilterMeasExist.MultiSelect = false;
            this.dataGridViewExcelFilterMeasExist.Name = "dataGridViewExcelFilterMeasExist";
            this.dataGridViewExcelFilterMeasExist.ReadOnly = true;
            this.dataGridViewExcelFilterMeasExist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilterMeasExist.Size = new System.Drawing.Size(610, 326);
            this.dataGridViewExcelFilterMeasExist.TabIndex = 0;
            this.dataGridViewExcelFilterMeasExist.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilterMeasExist_CellFormatting);
            // 
            // tpnameDataGridViewTextBoxColumn
            // 
            this.tpnameDataGridViewTextBoxColumn.DataPropertyName = "tpname";
            this.tpnameDataGridViewTextBoxColumn.HeaderText = "tpname";
            this.tpnameDataGridViewTextBoxColumn.Name = "tpnameDataGridViewTextBoxColumn";
            this.tpnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transnameDataGridViewTextBoxColumn
            // 
            this.transnameDataGridViewTextBoxColumn.DataPropertyName = "transname";
            this.transnameDataGridViewTextBoxColumn.HeaderText = "transname";
            this.transnameDataGridViewTextBoxColumn.Name = "transnameDataGridViewTextBoxColumn";
            this.transnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MeasExistTable
            // 
            this.MeasExistTable.DataMember = "MeasExistTable";
            this.MeasExistTable.DataSource = this.dataSet;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRefresh,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripComboBoxFromYear,
            this.toolStripLabel2,
            this.toolStripComboBoxToYear,
            this.toolStripSeparator2,
            this.toolStripButtonToExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(610, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::Properties.Resources.Refresh;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Обновить";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel1.Text = "Период:";
            // 
            // toolStripComboBoxFromYear
            // 
            this.toolStripComboBoxFromYear.Name = "toolStripComboBoxFromYear";
            this.toolStripComboBoxFromYear.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBoxFromYear.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFromYear_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(18, 22);
            this.toolStripLabel2.Text = " - ";
            // 
            // toolStripComboBoxToYear
            // 
            this.toolStripComboBoxToYear.Name = "toolStripComboBoxToYear";
            this.toolStripComboBoxToYear.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBoxToYear.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxToYear_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonToExcel
            // 
            this.toolStripButtonToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonToExcel.Image = global::Properties.Resources.Excel;
            this.toolStripButtonToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonToExcel.Name = "toolStripButtonToExcel";
            this.toolStripButtonToExcel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonToExcel.Text = "Экспорт в Excel";
            this.toolStripButtonToExcel.Click += new System.EventHandler(this.toolStripButtonToExcel_Click);
            // 
            // FormMeasurementExistYearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 351);
            this.Controls.Add(this.dataGridViewExcelFilterMeasExist);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "FormMeasurementExistYearForm";
            this.Text = "Наличие замеров";
            this.Load += new System.EventHandler(this.FormMeasurementExistYearForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMeasExistTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_tJ_Measurement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelFilterMeasExist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasExistTable)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeasurementExistYearForm));
        //    this.dataSet = new DataSet();
        //    this.dtMeasExistTable = new DataTable();
        //    this.tpname = new DataColumn();
        //    this.transname = new DataColumn();
        //    this.type = new DataColumn();
        //    this.dt_tJ_Measurement = new DataTable();
        //    this.year = new DataColumn();
        //    this.dataGridViewExcelFilterMeasExist = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        //    this.tpnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        //    this.transnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        //    this.typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        //    this.MeasExistTable = new BindingSource(this.components);
        //    this.toolStrip1 = new ToolStrip();
        //    this.toolStripButtonRefresh = new ToolStripButton();
        //    this.toolStripSeparator1 = new ToolStripSeparator();
        //    this.toolStripLabel1 = new ToolStripLabel();
        //    this.toolStripComboBoxFromYear = new ToolStripComboBox();
        //    this.toolStripLabel2 = new ToolStripLabel();
        //    this.toolStripComboBoxToYear = new ToolStripComboBox();
        //    this.toolStripSeparator2 = new ToolStripSeparator();
        //    this.toolStripButtonToExcel = new ToolStripButton();
        //    this.dataSet.BeginInit();
        //    this.dtMeasExistTable.BeginInit();
        //    this.dt_tJ_Measurement.BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)this.dataGridViewExcelFilterMeasExist).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)this.MeasExistTable).BeginInit();
        //    this.toolStrip1.SuspendLayout();
        //    base.SuspendLayout();
        //    this.dataSet.DataSetName = "NewDataSet";
        //    DataTable[] tables = new DataTable[] { this.dtMeasExistTable, this.dt_tJ_Measurement };
        //    this.dataSet.Tables.AddRange(tables);
        //    DataColumn[] columns = new DataColumn[] { this.tpname, this.transname, this.type };
        //    this.dtMeasExistTable.Columns.AddRange(columns);
        //    this.dtMeasExistTable.TableName = "MeasExistTable";
        //    this.tpname.ColumnName = "tpname";
        //    this.transname.ColumnName = "transname";
        //    this.type.ColumnName = "type";
        //    DataColumn[] columnArray2 = new DataColumn[] { this.year };
        //    this.dt_tJ_Measurement.Columns.AddRange(columnArray2);
        //    this.dt_tJ_Measurement.TableName = "tJ_Measurement";
        //    this.year.ColumnName = "year";
        //    this.year.DataType = typeof(int);
        //    this.dataGridViewExcelFilterMeasExist.AllowUserToAddRows = false;
        //    this.dataGridViewExcelFilterMeasExist.AllowUserToDeleteRows = false;
        //    this.dataGridViewExcelFilterMeasExist.AutoGenerateColumns = false;
        //    this.dataGridViewExcelFilterMeasExist.BackgroundColor = Color.White;
        //    this.dataGridViewExcelFilterMeasExist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //    DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.tpnameDataGridViewTextBoxColumn, this.transnameDataGridViewTextBoxColumn, this.typeDataGridViewTextBoxColumn };
        //    this.dataGridViewExcelFilterMeasExist.Columns.AddRange(dataGridViewColumns);
        //    this.dataGridViewExcelFilterMeasExist.DataSource = this.MeasExistTable;
        //    this.dataGridViewExcelFilterMeasExist.Dock = DockStyle.Fill;
        //    this.dataGridViewExcelFilterMeasExist.Location = new Point(0, 0x19);
        //    this.dataGridViewExcelFilterMeasExist.MultiSelect = false;
        //    this.dataGridViewExcelFilterMeasExist.Name = "dataGridViewExcelFilterMeasExist";
        //    this.dataGridViewExcelFilterMeasExist.ReadOnly = true;
        //    this.dataGridViewExcelFilterMeasExist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    this.dataGridViewExcelFilterMeasExist.Size = new Size(610, 0x146);
        //    this.dataGridViewExcelFilterMeasExist.TabIndex = 0;
        //    this.dataGridViewExcelFilterMeasExist.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilterMeasExist_CellFormatting);
        //    this.tpnameDataGridViewTextBoxColumn.DataPropertyName = "tpname";
        //    this.tpnameDataGridViewTextBoxColumn.HeaderText = "tpname";
        //    this.tpnameDataGridViewTextBoxColumn.Name = "tpnameDataGridViewTextBoxColumn";
        //    this.tpnameDataGridViewTextBoxColumn.ReadOnly = true;
        //    this.transnameDataGridViewTextBoxColumn.DataPropertyName = "transname";
        //    this.transnameDataGridViewTextBoxColumn.HeaderText = "transname";
        //    this.transnameDataGridViewTextBoxColumn.Name = "transnameDataGridViewTextBoxColumn";
        //    this.transnameDataGridViewTextBoxColumn.ReadOnly = true;
        //    this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
        //    this.typeDataGridViewTextBoxColumn.HeaderText = "type";
        //    this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
        //    this.typeDataGridViewTextBoxColumn.ReadOnly = true;
        //    this.MeasExistTable.DataMember = "MeasExistTable";
        //    this.MeasExistTable.DataSource = this.dataSet;
        //    ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButtonRefresh, this.toolStripSeparator1, this.toolStripLabel1, this.toolStripComboBoxFromYear, this.toolStripLabel2, this.toolStripComboBoxToYear, this.toolStripSeparator2, this.toolStripButtonToExcel };
        //    this.toolStrip1.Items.AddRange(toolStripItems);
        //    this.toolStrip1.Location = new Point(0, 0);
        //    this.toolStrip1.Name = "toolStrip1";
        //    this.toolStrip1.Size = new Size(610, 0x19);
        //    this.toolStrip1.TabIndex = 1;
        //    this.toolStrip1.Text = "toolStrip1";
        //    this.toolStripButtonRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButtonRefresh.Image = global::Properties.Resources.Refresh;
        //    this.toolStripButtonRefresh.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
        //    this.toolStripButtonRefresh.Size = new Size(0x17, 0x16);
        //    this.toolStripButtonRefresh.Text = "Обновить";
        //    this.toolStripButtonRefresh.Click += new EventHandler(this.toolStripButtonRefresh_Click);
        //    this.toolStripSeparator1.Name = "toolStripSeparator1";
        //    this.toolStripSeparator1.Size = new Size(6, 0x19);
        //    this.toolStripLabel1.Name = "toolStripLabel1";
        //    this.toolStripLabel1.Size = new Size(0x34, 0x16);
        //    this.toolStripLabel1.Text = "Период:";
        //    this.toolStripComboBoxFromYear.Name = "toolStripComboBoxFromYear";
        //    this.toolStripComboBoxFromYear.Size = new Size(0x4b, 0x19);
        //    this.toolStripComboBoxFromYear.SelectedIndexChanged += new EventHandler(this.toolStripComboBoxFromYear_SelectedIndexChanged);
        //    this.toolStripLabel2.Name = "toolStripLabel2";
        //    this.toolStripLabel2.Size = new Size(0x12, 0x16);
        //    this.toolStripLabel2.Text = " - ";
        //    this.toolStripComboBoxToYear.Name = "toolStripComboBoxToYear";
        //    this.toolStripComboBoxToYear.Size = new Size(0x4b, 0x19);
        //    this.toolStripComboBoxToYear.SelectedIndexChanged += new EventHandler(this.toolStripComboBoxToYear_SelectedIndexChanged);
        //    this.toolStripSeparator2.Name = "toolStripSeparator2";
        //    this.toolStripSeparator2.Size = new Size(6, 0x19);
        //    this.toolStripButtonToExcel.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButtonToExcel.Image = global::Properties.Resources.Excel;
        //    this.toolStripButtonToExcel.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButtonToExcel.Name = "toolStripButtonToExcel";
        //    this.toolStripButtonToExcel.Size = new Size(0x17, 0x16);
        //    this.toolStripButtonToExcel.Text = "Экспорт в Excel";
        //    this.toolStripButtonToExcel.Click += new EventHandler(this.toolStripButtonToExcel_Click);
        //    base.AutoScaleDimensions = new SizeF(6f, 13f);
        //    base.AutoScaleMode = AutoScaleMode.Font;
        //    base.ClientSize = new Size(610, 0x15f);
        //    base.Controls.Add(this.dataGridViewExcelFilterMeasExist);
        //    base.Controls.Add(this.toolStrip1);
        //    base.Icon = (Icon)resources.GetObject("$this.Icon");
        //    base.MinimizeBox = false;
        //    base.Name = "MeasurementExistYearForm";
        //    this.Text = "Наличие замеров";
        //    base.Load += new EventHandler(this.FormMeasurementExistYearForm_Load);
        //    this.dataSet.EndInit();
        //    this.dtMeasExistTable.EndInit();
        //    this.dt_tJ_Measurement.EndInit();
        //    ((System.ComponentModel.ISupportInitialize)this.dataGridViewExcelFilterMeasExist).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)this.MeasExistTable).EndInit();
        //    this.toolStrip1.ResumeLayout(false);
        //    this.toolStrip1.PerformLayout();
        //    base.ResumeLayout(false);
        //    base.PerformLayout();
        //}


        private BindingSource MeasExistTable;
        private DataColumn tpname;
        private DataColumn transname;
        private DataColumn type;
        private DataColumn year;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilterMeasExist;
        private DataGridViewTextBoxColumn tpnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataSet dataSet;
        private DataTable dtMeasExistTable;
        private DataTable dt_tJ_Measurement;
        
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonRefresh;
        private ToolStripButton toolStripButtonToExcel;
        private ToolStripComboBox toolStripComboBoxFromYear;
        private ToolStripComboBox toolStripComboBoxToYear;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
    }
}
