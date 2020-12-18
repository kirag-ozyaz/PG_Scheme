using Measurement.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Documents.Measurement
{
    partial class FormAddEditMeasHighVoltage
    {
        private System.ComponentModel.IContainer components =null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_10 = new System.Windows.Forms.Label();
            this.cbDispatcher = new System.Windows.Forms.ComboBox();
            this.bsMeasurement = new System.Windows.Forms.BindingSource(this.components);
            this.dsMeasHighVoltage = new DataSetMeasurementN();
            this.bsDispatcher = new System.Windows.Forms.BindingSource(this.components);
            this.lbSerialNumber = new System.Windows.Forms.Label();
            this.dgvMeasCable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsCells = new System.Windows.Forms.BindingSource(this.components);
            this.permissAmperageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsMeasCell = new System.Windows.Forms.BindingSource(this.components);
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label_8 = new System.Windows.Forms.Label();
            this.dtpDateD = new ControlsLbr.NullableDateTimePicker();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.bsWorker = new System.Windows.Forms.BindingSource(this.components);
            this.label_5 = new System.Windows.Forms.Label();
            this.cbBuses = new System.Windows.Forms.ComboBox();
            this.bsBusesTransfSchema = new System.Windows.Forms.BindingSource(this.components);
            this.label_6 = new System.Windows.Forms.Label();
            this.label_0 = new System.Windows.Forms.Label();
            this.label_7 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.nudTemperatureD = new System.Windows.Forms.NumericUpDown();
            this.label_4 = new System.Windows.Forms.Label();
            this.tbUbcd = new System.Windows.Forms.TextBox();
            this.bsMeasAmperageTransf = new System.Windows.Forms.BindingSource(this.components);
            this.tbUcad = new System.Windows.Forms.TextBox();
            this.tbUaod = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tsCells = new System.Windows.Forms.ToolStrip();
            this.tssbAddMissingCells = new System.Windows.Forms.ToolStripButton();
            this.tssbCellsDeleted = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.label_2 = new System.Windows.Forms.Label();
            this.toolStripTemperature = new System.Windows.Forms.ToolStrip();
            this.toolBtnImportTemperature = new System.Windows.Forms.ToolStripButton();
            this.bsTransf = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasHighVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDispatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasCable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBusesTransfSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatureD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasAmperageTransf)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tsCells.SuspendLayout();
            this.toolStripTemperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransf)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 14;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label_10, 11, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbDispatcher, 12, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbSerialNumber, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvMeasCable, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbYear, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpDateD, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbWorker, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_5, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbBuses, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_6, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_7, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_1, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudTemperatureD, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbUbcd, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbUcad, 9, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbUaod, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tsCells, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteData, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_2, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStripTemperature, 7, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 377);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label_10
            // 
            this.label_10.AutoSize = true;
            this.label_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_10.Location = new System.Drawing.Point(611, 38);
            this.label_10.Name = "label_10";
            this.label_10.Size = new System.Drawing.Size(72, 25);
            this.label_10.TabIndex = 37;
            this.label_10.Text = "Диспетчер:";
            this.label_10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDispatcher
            // 
            this.cbDispatcher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDispatcher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel1.SetColumnSpan(this.cbDispatcher, 2);
            this.cbDispatcher.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMeasurement, "idWorkerCheck", true));
            this.cbDispatcher.DataSource = this.bsDispatcher;
            this.cbDispatcher.DisplayMember = "FIO";
            this.cbDispatcher.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbDispatcher.FormattingEnabled = true;
            this.cbDispatcher.Location = new System.Drawing.Point(689, 41);
            this.cbDispatcher.Name = "cbDispatcher";
            this.cbDispatcher.Size = new System.Drawing.Size(138, 21);
            this.cbDispatcher.TabIndex = 36;
            this.cbDispatcher.ValueMember = "Id";
            // 
            // bsMeasurement
            // 
            this.bsMeasurement.DataMember = "tJ_Measurement";
            this.bsMeasurement.DataSource = this.dsMeasHighVoltage;
            // 
            // dsMeasHighVoltage
            // 
            this.dsMeasHighVoltage.DataSetName = "DataSetGES";
            this.dsMeasHighVoltage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsDispatcher
            // 
            this.bsDispatcher.DataMember = "vP_Worker";
            this.bsDispatcher.DataSource = this.dsMeasHighVoltage;
            this.bsDispatcher.Filter = "ParentKey = \';GroupWorker;MeasDispatchers;\' OR ParentKey = \'\'";
            this.bsDispatcher.Sort = "FIO";
            // 
            // lbSerialNumber
            // 
            this.lbSerialNumber.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbSerialNumber, 5);
            this.lbSerialNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSerialNumber.Location = new System.Drawing.Point(316, 63);
            this.lbSerialNumber.Name = "lbSerialNumber";
            this.lbSerialNumber.Size = new System.Drawing.Size(79, 25);
            this.lbSerialNumber.TabIndex = 33;
            this.lbSerialNumber.Text = "Заводской № ";
            this.lbSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMeasCable
            // 
            this.dgvMeasCable.AllowUserToAddRows = false;
            this.dgvMeasCable.AllowUserToDeleteRows = false;
            this.dgvMeasCable.AllowUserToResizeRows = false;
            this.dgvMeasCable.AutoGenerateColumns = false;
            this.dgvMeasCable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasCable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMeasCable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasCable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idMeasurementDataGridViewTextBoxColumn,
            this.idBusDataGridViewTextBoxColumn,
            this.idCellDataGridViewTextBoxColumn,
            this.permissAmperageDataGridViewTextBoxColumn,
            this.iadDataGridViewTextBoxColumn,
            this.ianDataGridViewTextBoxColumn,
            this.ibdDataGridViewTextBoxColumn,
            this.ibnDataGridViewTextBoxColumn,
            this.icdDataGridViewTextBoxColumn,
            this.icnDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvMeasCable, 14);
            this.dgvMeasCable.DataSource = this.bsMeasCell;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeasCable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMeasCable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeasCable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMeasCable.Location = new System.Drawing.Point(3, 149);
            this.dgvMeasCable.MultiSelect = false;
            this.dgvMeasCable.Name = "dgvMeasCable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasCable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMeasCable.RowHeadersVisible = false;
            this.dgvMeasCable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeasCable.Size = new System.Drawing.Size(900, 185);
            this.dgvMeasCable.TabIndex = 31;
            this.dgvMeasCable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeasCable_CellEndEdit);
            this.dgvMeasCable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMeasCable_DataError);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMeasurementDataGridViewTextBoxColumn
            // 
            this.idMeasurementDataGridViewTextBoxColumn.DataPropertyName = "idMeasurement";
            this.idMeasurementDataGridViewTextBoxColumn.HeaderText = "idMeasurement";
            this.idMeasurementDataGridViewTextBoxColumn.Name = "idMeasurementDataGridViewTextBoxColumn";
            this.idMeasurementDataGridViewTextBoxColumn.Visible = false;
            // 
            // idBusDataGridViewTextBoxColumn
            // 
            this.idBusDataGridViewTextBoxColumn.DataPropertyName = "idBus";
            this.idBusDataGridViewTextBoxColumn.HeaderText = "idBus";
            this.idBusDataGridViewTextBoxColumn.Name = "idBusDataGridViewTextBoxColumn";
            this.idBusDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCellDataGridViewTextBoxColumn
            // 
            this.idCellDataGridViewTextBoxColumn.DataPropertyName = "idCell";
            this.idCellDataGridViewTextBoxColumn.DataSource = this.bsCells;
            this.idCellDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.idCellDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.idCellDataGridViewTextBoxColumn.HeaderText = "№ руб.";
            this.idCellDataGridViewTextBoxColumn.Name = "idCellDataGridViewTextBoxColumn";
            this.idCellDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCellDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idCellDataGridViewTextBoxColumn.ValueMember = "id";
            this.idCellDataGridViewTextBoxColumn.Width = 50;
            // 
            // bsCells
            // 
            this.bsCells.DataMember = "dtCells";
            this.bsCells.DataSource = this.dsMeasHighVoltage;
            // 
            // permissAmperageDataGridViewTextBoxColumn
            // 
            this.permissAmperageDataGridViewTextBoxColumn.DataPropertyName = "PermissAmperage";
            this.permissAmperageDataGridViewTextBoxColumn.HeaderText = "Допуст. нагр., А";
            this.permissAmperageDataGridViewTextBoxColumn.Name = "permissAmperageDataGridViewTextBoxColumn";
            this.permissAmperageDataGridViewTextBoxColumn.Width = 80;
            // 
            // iadDataGridViewTextBoxColumn
            // 
            this.iadDataGridViewTextBoxColumn.DataPropertyName = "Iad";
            this.iadDataGridViewTextBoxColumn.HeaderText = "А дн.";
            this.iadDataGridViewTextBoxColumn.Name = "iadDataGridViewTextBoxColumn";
            this.iadDataGridViewTextBoxColumn.Width = 60;
            // 
            // ianDataGridViewTextBoxColumn
            // 
            this.ianDataGridViewTextBoxColumn.DataPropertyName = "Ian";
            this.ianDataGridViewTextBoxColumn.HeaderText = "А вч.";
            this.ianDataGridViewTextBoxColumn.Name = "ianDataGridViewTextBoxColumn";
            this.ianDataGridViewTextBoxColumn.Width = 60;
            // 
            // ibdDataGridViewTextBoxColumn
            // 
            this.ibdDataGridViewTextBoxColumn.DataPropertyName = "Ibd";
            this.ibdDataGridViewTextBoxColumn.HeaderText = "В дн.";
            this.ibdDataGridViewTextBoxColumn.Name = "ibdDataGridViewTextBoxColumn";
            this.ibdDataGridViewTextBoxColumn.Width = 60;
            // 
            // ibnDataGridViewTextBoxColumn
            // 
            this.ibnDataGridViewTextBoxColumn.DataPropertyName = "Ibn";
            this.ibnDataGridViewTextBoxColumn.HeaderText = "В вч.";
            this.ibnDataGridViewTextBoxColumn.Name = "ibnDataGridViewTextBoxColumn";
            this.ibnDataGridViewTextBoxColumn.Width = 60;
            // 
            // icdDataGridViewTextBoxColumn
            // 
            this.icdDataGridViewTextBoxColumn.DataPropertyName = "Icd";
            this.icdDataGridViewTextBoxColumn.HeaderText = "С дн.";
            this.icdDataGridViewTextBoxColumn.Name = "icdDataGridViewTextBoxColumn";
            this.icdDataGridViewTextBoxColumn.Width = 60;
            // 
            // icnDataGridViewTextBoxColumn
            // 
            this.icnDataGridViewTextBoxColumn.DataPropertyName = "Icn";
            this.icnDataGridViewTextBoxColumn.HeaderText = "С вч.";
            this.icnDataGridViewTextBoxColumn.Name = "icnDataGridViewTextBoxColumn";
            this.icnDataGridViewTextBoxColumn.Width = 60;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // bsMeasCell
            // 
            this.bsMeasCell.DataMember = "tJ_MeasCell";
            this.bsMeasCell.DataSource = this.dsMeasHighVoltage;
            // 
            // cbYear
            // 
            this.cbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbYear.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMeasurement, "Year", true));
            this.cbYear.DisplayMember = "Id";
            this.cbYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(144, 16);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(114, 21);
            this.cbYear.TabIndex = 30;
            this.cbYear.ValueMember = "Id";
            this.cbYear.SelectedValueChanged += new System.EventHandler(this.cbYear_SelectedValueChanged);
            // 
            // label_8
            // 
            this.label_8.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_8, 2);
            this.label_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_8.Location = new System.Drawing.Point(20, 13);
            this.label_8.Name = "label_8";
            this.label_8.Size = new System.Drawing.Size(118, 25);
            this.label_8.TabIndex = 29;
            this.label_8.Text = "Период:";
            this.label_8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDateD
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dtpDateD, 3);
            this.dtpDateD.CustomFormat = "ddMMMMyyyy г. HH:mm";
            this.dtpDateD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMeasurement, "DateD", true));
            this.dtpDateD.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpDateD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateD.Location = new System.Drawing.Point(144, 41);
            this.dtpDateD.Name = "dtpDateD";
            this.dtpDateD.Size = new System.Drawing.Size(163, 20);
            this.dtpDateD.TabIndex = 4;
            //this.dtpDateD.Value = new System.DateTime(2020, 2, 21, 16, 21, 17, 340);
            this.dtpDateD.ValueChanged += new System.EventHandler(this.nullableDateTimePicker_0_ValueChanged);
            // 
            // cbWorker
            // 
            this.cbWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMeasurement, "idWorker", true));
            this.cbWorker.DataSource = this.bsWorker;
            this.cbWorker.DisplayMember = "FIO";
            this.cbWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(465, 41);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(131, 21);
            this.cbWorker.TabIndex = 3;
            this.cbWorker.ValueMember = "Id";
            // 
            // bsWorker
            // 
            this.bsWorker.DataMember = "vP_Worker";
            this.bsWorker.DataSource = this.dsMeasHighVoltage;
            this.bsWorker.Filter = "ParentKey = \';GroupWorker;Meas;\' OR ParentKey = \'\'";
            this.bsWorker.Sort = "FIO";
            // 
            // label_5
            // 
            this.label_5.AutoSize = true;
            this.label_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_5.Location = new System.Drawing.Point(438, 88);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(21, 25);
            this.label_5.TabIndex = 22;
            this.label_5.Text = "С";
            this.label_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBuses
            // 
            this.cbBuses.DataSource = this.bsBusesTransfSchema;
            this.cbBuses.DisplayMember = "nameBusTransf";
            this.cbBuses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuses.FormattingEnabled = true;
            this.cbBuses.Location = new System.Drawing.Point(144, 66);
            this.cbBuses.Name = "cbBuses";
            this.cbBuses.Size = new System.Drawing.Size(114, 21);
            this.cbBuses.TabIndex = 12;
            this.cbBuses.ValueMember = "idBus";
            // 
            // bsBusesTransfSchema
            // 
            this.bsBusesTransfSchema.DataMember = "vJ_BusesTransfSchema";
            this.bsBusesTransfSchema.DataSource = this.dsMeasHighVoltage;
            this.bsBusesTransfSchema.CurrentChanged += new System.EventHandler(this.bsBusesTransfSchema_CurrentChanged);
            // 
            // label_6
            // 
            this.label_6.AutoSize = true;
            this.label_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_6.Location = new System.Drawing.Point(264, 88);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(19, 25);
            this.label_6.TabIndex = 24;
            this.label_6.Text = "В";
            this.label_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_0
            // 
            this.label_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.label_0, 2);
            this.label_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_0.Location = new System.Drawing.Point(20, 63);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(118, 25);
            this.label_0.TabIndex = 11;
            this.label_0.Text = "Секция шин (тр-р) №";
            this.label_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_7
            // 
            this.label_7.AutoSize = true;
            this.label_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_7.Location = new System.Drawing.Point(122, 88);
            this.label_7.Name = "label_7";
            this.label_7.Size = new System.Drawing.Size(16, 25);
            this.label_7.TabIndex = 19;
            this.label_7.Text = "А";
            this.label_7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_1, 3);
            this.label_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_1.Location = new System.Drawing.Point(316, 38);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(143, 25);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "Замеры проводил:";
            this.label_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_3, 2);
            this.label_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_3.Location = new System.Drawing.Point(20, 38);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(118, 25);
            this.label_3.TabIndex = 0;
            this.label_3.Text = "Дата/Время:";
            this.label_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTemperatureD
            // 
            this.nudTemperatureD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMeasurement, "TemperatureD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudTemperatureD.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudTemperatureD.Location = new System.Drawing.Point(465, 16);
            this.nudTemperatureD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudTemperatureD.Name = "nudTemperatureD";
            this.nudTemperatureD.Size = new System.Drawing.Size(48, 20);
            this.nudTemperatureD.TabIndex = 2;
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_4.Location = new System.Drawing.Point(20, 88);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(96, 25);
            this.label_4.TabIndex = 25;
            this.label_4.Text = "Ток нагрузки";
            this.label_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUbcd
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbUbcd, 2);
            this.tbUbcd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasAmperageTransf, "Ib", true));
            this.tbUbcd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUbcd.Location = new System.Drawing.Point(289, 91);
            this.tbUbcd.Name = "tbUbcd";
            this.tbUbcd.Size = new System.Drawing.Size(123, 20);
            this.tbUbcd.TabIndex = 11;
            // 
            // bsMeasAmperageTransf
            // 
            this.bsMeasAmperageTransf.DataMember = "tJ_MeasAmperageTransf";
            this.bsMeasAmperageTransf.DataSource = this.dsMeasHighVoltage;
            // 
            // tbUcad
            // 
            this.tbUcad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasAmperageTransf, "Ic", true));
            this.tbUcad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUcad.Location = new System.Drawing.Point(465, 91);
            this.tbUcad.Name = "tbUcad";
            this.tbUcad.Size = new System.Drawing.Size(131, 20);
            this.tbUcad.TabIndex = 7;
            // 
            // tbUaod
            // 
            this.tbUaod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasAmperageTransf, "Ia", true));
            this.tbUaod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUaod.Location = new System.Drawing.Point(144, 91);
            this.tbUaod.Name = "tbUaod";
            this.tbUaod.Size = new System.Drawing.Size(114, 20);
            this.tbUaod.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 14);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnAccept, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 340);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(900, 34);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAccept.Location = new System.Drawing.Point(693, 6);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 6, 10, 6);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(99, 22);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Применить";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(812, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 6, 3, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tsCells
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tsCells, 13);
            this.tsCells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsCells.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbAddMissingCells,
            this.tssbCellsDeleted});
            this.tsCells.Location = new System.Drawing.Point(0, 122);
            this.tsCells.Name = "tsCells";
            this.tsCells.Size = new System.Drawing.Size(771, 24);
            this.tsCells.TabIndex = 34;
            this.tsCells.Text = "toolStrip1";
            // 
            // tssbAddMissingCells
            // 
            this.tssbAddMissingCells.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbAddMissingCells.Image = global::Measurement.Properties.Resources.Add;
            this.tssbAddMissingCells.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbAddMissingCells.Name = "tssbAddMissingCells";
            this.tssbAddMissingCells.Size = new System.Drawing.Size(23, 21);
            this.tssbAddMissingCells.Text = "Загрузить недостающие ячейки";
            this.tssbAddMissingCells.Visible = false;
            this.tssbAddMissingCells.Click += new System.EventHandler(this.tssbAddMissingCells_Click);
            // 
            // tssbCellsDeleted
            // 
            this.tssbCellsDeleted.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbCellsDeleted.Image = global::Measurement.Properties.Resources.Delete;
            this.tssbCellsDeleted.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbCellsDeleted.Name = "tssbCellsDeleted";
            this.tssbCellsDeleted.Size = new System.Drawing.Size(23, 21);
            this.tssbCellsDeleted.Text = "Удалить строку";
            this.tssbCellsDeleted.Click += new System.EventHandler(this.tssbCellsDeleted_Click);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteData.Image = global::Measurement.Properties.Resources.Delete;
            this.btnDeleteData.Location = new System.Drawing.Point(261, 65);
            this.btnDeleteData.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(25, 23);
            this.btnDeleteData.TabIndex = 35;
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Visible = false;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_2.Location = new System.Drawing.Point(316, 13);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(96, 25);
            this.label_2.TabIndex = 0;
            this.label_2.Text = "Температура:";
            this.label_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripTemperature
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStripTemperature, 2);
            this.toolStripTemperature.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTemperature.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTemperature.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnImportTemperature});
            this.toolStripTemperature.Location = new System.Drawing.Point(415, 13);
            this.toolStripTemperature.Name = "toolStripTemperature";
            this.toolStripTemperature.Size = new System.Drawing.Size(26, 25);
            this.toolStripTemperature.TabIndex = 38;
            this.toolStripTemperature.Text = "toolStripTemperature";
            // 
            // toolBtnImportTemperature
            // 
            this.toolBtnImportTemperature.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnImportTemperature.Image = global::Measurement.Properties.Resources.Pogoda1;
            this.toolBtnImportTemperature.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnImportTemperature.Name = "toolBtnImportTemperature";
            this.toolBtnImportTemperature.Size = new System.Drawing.Size(23, 22);
            this.toolBtnImportTemperature.Text = "Загрузка из реестра температур";
            this.toolBtnImportTemperature.Click += new System.EventHandler(this.toolBtnImportTemperature_Click);
            // 
            // bsTransf
            // 
            this.bsTransf.DataMember = "tSchm_ObjList";
            this.bsTransf.DataSource = this.dsMeasHighVoltage;
            this.bsTransf.Sort = "Name";
            // 
            // FormAddEditMeasHighVoltage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 377);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAddEditMeasHighVoltage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddEditMeasHighVoltage_FormClosing);
            this.Load += new System.EventHandler(this.FormAddEditMeasHighVoltage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasHighVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDispatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasCable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBusesTransfSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatureD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasAmperageTransf)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tsCells.ResumeLayout(false);
            this.tsCells.PerformLayout();
            this.toolStripTemperature.ResumeLayout(false);
            this.toolStripTemperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransf)).EndInit();
            this.ResumeLayout(false);

        }











        private BindingSource bsTransf;
        private BindingSource bsMeasAmperageTransf;
        private BindingSource bsMeasurement;
        private BindingSource bsWorker;
        private BindingSource bsMeasCell;
        private BindingSource bsBusesTransfSchema;
        private BindingSource bsCells;
        private BindingSource bsDispatcher;
        private Button btnAccept;
        private Button btnCancel;
        private Button btnDeleteData;
        
        private ComboBox cbWorker;
        private ComboBox cbBuses;
        private ComboBox cbYear;
        private ComboBox cbDispatcher;
        private DataGridView dgvMeasCable;
        private DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private DataGridViewComboBoxColumn idCellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idMeasurementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idBusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn permissAmperageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ianDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ibdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ibnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn icdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn icnDataGridViewTextBoxColumn;
        private DataSetMeasurementN dsMeasHighVoltage;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label lbSerialNumber;

        private ControlsLbr.NullableDateTimePicker dtpDateD;
        private NumericUpDown nudTemperatureD;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbUcad;
        private TextBox tbUaod;
        private TextBox tbUbcd;
        private ToolStrip tsCells;
        private ToolStrip toolStripTemperature;
        private ToolStripButton tssbAddMissingCells;
        private ToolStripButton tssbCellsDeleted;
        private ToolStripButton toolBtnImportTemperature;

    }

}
