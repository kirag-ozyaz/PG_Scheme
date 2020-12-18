using ControlsLbr;
//using Documents.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Documents.Forms.Measurement
{
    partial class FormAddEditMeasLowVoltage
    {
        private IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditMeasLowVoltage));
            this.tableLayoutPanel_0 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip_1 = new System.Windows.Forms.ToolStrip();
            this.tssbAddMissingCells = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiMeasCableDelAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_5 = new System.Windows.Forms.ToolStripButton();
            this.lbSerialNumber = new System.Windows.Forms.Label();
            this.label_15 = new System.Windows.Forms.Label();
            this.dgvAbnObj = new System.Windows.Forms.DataGridView();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSchmObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_11 = new System.Windows.Forms.BindingSource(this.components);
            this.dsMeasLowVoltage = new Documents.DataSets.DataSetMeasurementN();
            this.dgvMeasCable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTransfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldCellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSchmAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wiresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crossSectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisAmperageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOldMeasurementCableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsMeasCable = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_1 = new System.Windows.Forms.ComboBox();
            this.bsBusesTransf = new System.Windows.Forms.BindingSource(this.components);
            this.label_6 = new System.Windows.Forms.Label();
            this.groupBox_0 = new System.Windows.Forms.GroupBox();
            this.toolStrip_2 = new System.Windows.Forms.ToolStrip();
            this.toolBtnImportTemperature = new System.Windows.Forms.ToolStripButton();
            this.label_16 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.bsMeasurement = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDateN = new ControlsLbr.NullableDateTimePicker();
            this.dtpDateD = new ControlsLbr.NullableDateTimePicker();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.components);
            this.nudTemperatureN = new System.Windows.Forms.NumericUpDown();
            this.nudTemperatureD = new System.Windows.Forms.NumericUpDown();
            this.label_0 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.panel_0 = new System.Windows.Forms.Panel();
            this.label_13 = new System.Windows.Forms.Label();
            this.label_14 = new System.Windows.Forms.Label();
            this.label_7 = new System.Windows.Forms.Label();
            this.label_8 = new System.Windows.Forms.Label();
            this.label_9 = new System.Windows.Forms.Label();
            this.label_10 = new System.Windows.Forms.Label();
            this.label_11 = new System.Windows.Forms.Label();
            this.label_12 = new System.Windows.Forms.Label();
            this.tbUcon = new System.Windows.Forms.TextBox();
            this.bindingSource_2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbUcan = new System.Windows.Forms.TextBox();
            this.tbUbcn = new System.Windows.Forms.TextBox();
            this.tbUbon = new System.Windows.Forms.TextBox();
            this.tbUcod = new System.Windows.Forms.TextBox();
            this.tbUbod = new System.Windows.Forms.TextBox();
            this.tbUaon = new System.Windows.Forms.TextBox();
            this.tbUabn = new System.Windows.Forms.TextBox();
            this.tbUcad = new System.Windows.Forms.TextBox();
            this.tbUaod = new System.Windows.Forms.TextBox();
            this.tbUbcd = new System.Windows.Forms.TextBox();
            this.tbUabd = new System.Windows.Forms.TextBox();
            this.toolStrip_0 = new System.Windows.Forms.ToolStrip();
            this.tsbMeasAbnObjAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_1 = new System.Windows.Forms.ToolStripButton();
            this.tsbMeasAbnObjDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_0 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMeasAbnObjRefresh = new System.Windows.Forms.ToolStripButton();
            this.comboBox_2 = new System.Windows.Forms.ComboBox();
            this.bindingSource_13 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel_1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.bsCellByTransf = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_8 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_9 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_15 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_10 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_14 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_4 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_5 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_6 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel_0.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasLowVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasCable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasCable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBusesTransf)).BeginInit();
            this.groupBox_0.SuspendLayout();
            this.toolStrip_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatureN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatureD)).BeginInit();
            this.panel_0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_2)).BeginInit();
            this.toolStrip_0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_13)).BeginInit();
            this.tableLayoutPanel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCellByTransf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_6)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_0
            // 
            this.tableLayoutPanel_0.ColumnCount = 6;
            this.tableLayoutPanel_0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel_0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel_0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel_0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel_0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel_0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_0.Controls.Add(this.toolStrip_1, 0, 3);
            this.tableLayoutPanel_0.Controls.Add(this.lbSerialNumber, 3, 1);
            this.tableLayoutPanel_0.Controls.Add(this.label_15, 4, 1);
            this.tableLayoutPanel_0.Controls.Add(this.dgvAbnObj, 0, 6);
            this.tableLayoutPanel_0.Controls.Add(this.dgvMeasCable, 0, 4);
            this.tableLayoutPanel_0.Controls.Add(this.comboBox_1, 1, 1);
            this.tableLayoutPanel_0.Controls.Add(this.label_6, 0, 1);
            this.tableLayoutPanel_0.Controls.Add(this.groupBox_0, 0, 0);
            this.tableLayoutPanel_0.Controls.Add(this.panel_0, 0, 2);
            this.tableLayoutPanel_0.Controls.Add(this.toolStrip_0, 0, 5);
            this.tableLayoutPanel_0.Controls.Add(this.comboBox_2, 5, 1);
            this.tableLayoutPanel_0.Controls.Add(this.tableLayoutPanel_1, 0, 7);
            this.tableLayoutPanel_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_0.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_0.Name = "tableLayoutPanel_0";
            this.tableLayoutPanel_0.RowCount = 8;
            this.tableLayoutPanel_0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel_0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel_0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel_0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel_0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel_0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel_0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel_0.Size = new System.Drawing.Size(698, 562);
            this.tableLayoutPanel_0.TabIndex = 0;
            // 
            // toolStrip_1
            // 
            this.tableLayoutPanel_0.SetColumnSpan(this.toolStrip_1, 12);
            this.toolStrip_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbAddMissingCells,
            this.toolStripSeparator3,
            this.toolStripSplitButton1,
            this.toolStripSeparator_3,
            this.toolStripButton_5});
            this.toolStrip_1.Location = new System.Drawing.Point(0, 167);
            this.toolStrip_1.Name = "toolStrip_1";
            this.toolStrip_1.Size = new System.Drawing.Size(698, 24);
            this.toolStrip_1.TabIndex = 7;
            this.toolStrip_1.Text = "toolStrip1";
            // 
            // tssbAddMissingCells
            // 
            this.tssbAddMissingCells.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbAddMissingCells.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbAddMissingCells.Name = "tssbAddMissingCells";
            this.tssbAddMissingCells.Size = new System.Drawing.Size(23, 21);
            this.tssbAddMissingCells.Text = "Добавление недостающих кабельных линий";
            this.tssbAddMissingCells.Click += new System.EventHandler(this.tssbAddMissingCells_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMeasCableDelAddress,
            this.toolStripMenuItem_1,
            this.toolStripSeparator_1,
            this.toolStripMenuItem_2});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 21);
            // 
            // tsmiMeasCableDelAddress
            // 
            this.tsmiMeasCableDelAddress.Name = "tsmiMeasCableDelAddress";
            this.tsmiMeasCableDelAddress.Size = new System.Drawing.Size(249, 22);
            this.tsmiMeasCableDelAddress.Text = "Удалить адрес объекта";
            this.tsmiMeasCableDelAddress.Click += new System.EventHandler(this.tsmiMeasCableDelAddress_Click);
            // 
            // toolStripMenuItem_1
            // 
            this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
            this.toolStripMenuItem_1.Size = new System.Drawing.Size(249, 22);
            this.toolStripMenuItem_1.Text = "Удалить наименование объекта";
            this.toolStripMenuItem_1.Click += new System.EventHandler(this.toolStripMenuItem_1_Click);
            // 
            // toolStripSeparator_1
            // 
            this.toolStripSeparator_1.Name = "toolStripSeparator_1";
            this.toolStripSeparator_1.Size = new System.Drawing.Size(246, 6);
            // 
            // toolStripMenuItem_2
            // 
            this.toolStripMenuItem_2.Name = "toolStripMenuItem_2";
            this.toolStripMenuItem_2.Size = new System.Drawing.Size(249, 22);
            this.toolStripMenuItem_2.Text = "Удалить строку";
            this.toolStripMenuItem_2.Click += new System.EventHandler(this.toolStripMenuItem_2_Click);
            // 
            // toolStripSeparator_3
            // 
            this.toolStripSeparator_3.Name = "toolStripSeparator_3";
            this.toolStripSeparator_3.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripButton_5
            // 
            this.toolStripButton_5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_5.Name = "toolStripButton_5";
            this.toolStripButton_5.Size = new System.Drawing.Size(23, 21);
            this.toolStripButton_5.Text = "Cправочник кабеля";
            this.toolStripButton_5.Click += new System.EventHandler(this.OpenReferenceCable_Click);
            // 
            // lbSerialNumber
            // 
            this.lbSerialNumber.AutoSize = true;
            this.lbSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSerialNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSerialNumber.Location = new System.Drawing.Point(253, 79);
            this.lbSerialNumber.Name = "lbSerialNumber";
            this.lbSerialNumber.Size = new System.Drawing.Size(81, 21);
            this.lbSerialNumber.TabIndex = 3;
            this.lbSerialNumber.Text = "Заводской № ";
            this.lbSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_15
            // 
            this.label_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_15.Location = new System.Drawing.Point(428, 79);
            this.label_15.Name = "label_15";
            this.label_15.Size = new System.Drawing.Size(158, 21);
            this.label_15.TabIndex = 4;
            this.label_15.Text = "Положение перекл. напр.";
            this.label_15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvAbnObj
            // 
            this.dgvAbnObj.AllowUserToAddRows = false;
            this.dgvAbnObj.AllowUserToDeleteRows = false;
            this.dgvAbnObj.AllowUserToOrderColumns = true;
            this.dgvAbnObj.AllowUserToResizeRows = false;
            this.dgvAbnObj.AutoGenerateColumns = false;
            this.dgvAbnObj.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbnObj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAbnObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbnObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.streetDataGridViewTextBoxColumn,
            this.idSchmObjDataGridViewTextBoxColumn,
            this.typeDocDgvColumn,
            this.houseDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.codeAbonent,
            this.dgvcIds});
            this.tableLayoutPanel_0.SetColumnSpan(this.dgvAbnObj, 6);
            this.dgvAbnObj.DataSource = this.bindingSource_11;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbnObj.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAbnObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbnObj.Location = new System.Drawing.Point(3, 392);
            this.dgvAbnObj.Name = "dgvAbnObj";
            this.dgvAbnObj.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbnObj.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAbnObj.RowHeadersVisible = false;
            this.dgvAbnObj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbnObj.Size = new System.Drawing.Size(692, 128);
            this.dgvAbnObj.TabIndex = 10;
            this.dgvAbnObj.VirtualMode = true;
            this.dgvAbnObj.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_1_CellFormatting);
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.Width = 180;
            // 
            // idSchmObjDataGridViewTextBoxColumn
            // 
            this.idSchmObjDataGridViewTextBoxColumn.DataPropertyName = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.HeaderText = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.Name = "idSchmObjDataGridViewTextBoxColumn";
            this.idSchmObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSchmObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDocDgvColumn
            // 
            this.typeDocDgvColumn.DataPropertyName = "TypeDoc";
            this.typeDocDgvColumn.HeaderText = "TypeDoc";
            this.typeDocDgvColumn.Name = "typeDocDgvColumn";
            this.typeDocDgvColumn.ReadOnly = true;
            this.typeDocDgvColumn.Visible = false;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            this.houseDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeAbonent
            // 
            this.codeAbonent.DataPropertyName = "codeAbonent";
            this.codeAbonent.HeaderText = "Номер договора";
            this.codeAbonent.Name = "codeAbonent";
            this.codeAbonent.ReadOnly = true;
            this.codeAbonent.Width = 120;
            // 
            // dgvcIds
            // 
            this.dgvcIds.DataPropertyName = "ids";
            this.dgvcIds.HeaderText = "ids";
            this.dgvcIds.Name = "dgvcIds";
            this.dgvcIds.ReadOnly = true;
            this.dgvcIds.Visible = false;
            // 
            // bindingSource_11
            // 
            this.bindingSource_11.DataMember = "vJ_MeasAbnObj";
            this.bindingSource_11.DataSource = this.dsMeasLowVoltage;
            this.bindingSource_11.Sort = "";
            // 
            // dsMeasLowVoltage
            // 
            this.dsMeasLowVoltage.DataSetName = "DataSetMeasurementN";
            this.dsMeasLowVoltage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvMeasCable
            // 
            this.dgvMeasCable.AllowUserToAddRows = false;
            this.dgvMeasCable.AllowUserToDeleteRows = false;
            this.dgvMeasCable.AllowUserToResizeRows = false;
            this.dgvMeasCable.AutoGenerateColumns = false;
            this.dgvMeasCable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasCable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMeasCable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasCable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idMeasurementDataGridViewTextBoxColumn,
            this.idBusDataGridViewTextBoxColumn,
            this.idTransfDataGridViewTextBoxColumn,
            this.idCellDataGridViewTextBoxColumn,
            this.nameCellDataGridViewTextBoxColumn,
            this.oldCellDataGridViewTextBoxColumn,
            this.idCableDataGridViewTextBoxColumn,
            this.nameCableDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.idSchmAbnDataGridViewTextBoxColumn,
            this.makeupDataGridViewTextBoxColumn,
            this.voltageDataGridViewTextBoxColumn,
            this.wiresDataGridViewTextBoxColumn,
            this.crossSectionDataGridViewTextBoxColumn,
            this.permisAmperageDataGridViewTextBoxColumn,
            this.iadDataGridViewTextBoxColumn,
            this.ianDataGridViewTextBoxColumn,
            this.ibdDataGridViewTextBoxColumn,
            this.ibnDataGridViewTextBoxColumn,
            this.icdDataGridViewTextBoxColumn,
            this.icnDataGridViewTextBoxColumn,
            this.iodDataGridViewTextBoxColumn,
            this.ionDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.idOldMeasurementCableDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.tableLayoutPanel_0.SetColumnSpan(this.dgvMeasCable, 6);
            this.dgvMeasCable.DataSource = this.bsMeasCable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeasCable.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMeasCable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeasCable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMeasCable.Location = new System.Drawing.Point(3, 194);
            this.dgvMeasCable.MultiSelect = false;
            this.dgvMeasCable.Name = "dgvMeasCable";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasCable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMeasCable.RowHeadersVisible = false;
            this.dgvMeasCable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeasCable.Size = new System.Drawing.Size(692, 168);
            this.dgvMeasCable.TabIndex = 8;
            this.dgvMeasCable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_0_CellBeginEdit);
            this.dgvMeasCable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_0_CellEndEdit);
            this.dgvMeasCable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_0_ColumnHeaderMouseClick);
            this.dgvMeasCable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_0_DataError);
            this.dgvMeasCable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_0_RowsAdded);
            this.dgvMeasCable.SelectionChanged += new System.EventHandler(this.dataGridView_0_SelectionChanged);
            this.dgvMeasCable.Sorted += new System.EventHandler(this.dataGridView_0_Sorted);
            this.dgvMeasCable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_0_KeyPress);
            this.dgvMeasCable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_0_MouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // idTransfDataGridViewTextBoxColumn
            // 
            this.idTransfDataGridViewTextBoxColumn.DataPropertyName = "idTransf";
            this.idTransfDataGridViewTextBoxColumn.HeaderText = "idTransf";
            this.idTransfDataGridViewTextBoxColumn.Name = "idTransfDataGridViewTextBoxColumn";
            this.idTransfDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCellDataGridViewTextBoxColumn
            // 
            this.idCellDataGridViewTextBoxColumn.DataPropertyName = "idCell";
            this.idCellDataGridViewTextBoxColumn.HeaderText = "№ руб.";
            this.idCellDataGridViewTextBoxColumn.Name = "idCellDataGridViewTextBoxColumn";
            this.idCellDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idCellDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameCellDataGridViewTextBoxColumn
            // 
            this.nameCellDataGridViewTextBoxColumn.DataPropertyName = "NameCell";
            this.nameCellDataGridViewTextBoxColumn.HeaderText = "NameCell";
            this.nameCellDataGridViewTextBoxColumn.Name = "nameCellDataGridViewTextBoxColumn";
            this.nameCellDataGridViewTextBoxColumn.Visible = false;
            // 
            // oldCellDataGridViewTextBoxColumn
            // 
            this.oldCellDataGridViewTextBoxColumn.DataPropertyName = "OldCell";
            this.oldCellDataGridViewTextBoxColumn.HeaderText = "№ ст. руб.";
            this.oldCellDataGridViewTextBoxColumn.Name = "oldCellDataGridViewTextBoxColumn";
            this.oldCellDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.oldCellDataGridViewTextBoxColumn.Width = 50;
            // 
            // idCableDataGridViewTextBoxColumn
            // 
            this.idCableDataGridViewTextBoxColumn.DataPropertyName = "idCable";
            this.idCableDataGridViewTextBoxColumn.HeaderText = "Кабель";
            this.idCableDataGridViewTextBoxColumn.Name = "idCableDataGridViewTextBoxColumn";
            this.idCableDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idCableDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameCableDataGridViewTextBoxColumn
            // 
            this.nameCableDataGridViewTextBoxColumn.DataPropertyName = "NameCable";
            this.nameCableDataGridViewTextBoxColumn.HeaderText = "NameCable";
            this.nameCableDataGridViewTextBoxColumn.Name = "nameCableDataGridViewTextBoxColumn";
            this.nameCableDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес объекта";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Наименование объекта";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idSchmAbnDataGridViewTextBoxColumn
            // 
            this.idSchmAbnDataGridViewTextBoxColumn.DataPropertyName = "idSchmAbn";
            this.idSchmAbnDataGridViewTextBoxColumn.HeaderText = "idSchmAbn";
            this.idSchmAbnDataGridViewTextBoxColumn.Name = "idSchmAbnDataGridViewTextBoxColumn";
            this.idSchmAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // makeupDataGridViewTextBoxColumn
            // 
            this.makeupDataGridViewTextBoxColumn.DataPropertyName = "Makeup";
            this.makeupDataGridViewTextBoxColumn.HeaderText = "Марка кабеля";
            this.makeupDataGridViewTextBoxColumn.Name = "makeupDataGridViewTextBoxColumn";
            this.makeupDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.makeupDataGridViewTextBoxColumn.Width = 70;
            // 
            // voltageDataGridViewTextBoxColumn
            // 
            this.voltageDataGridViewTextBoxColumn.DataPropertyName = "Voltage";
            this.voltageDataGridViewTextBoxColumn.HeaderText = "Напр.";
            this.voltageDataGridViewTextBoxColumn.Name = "voltageDataGridViewTextBoxColumn";
            this.voltageDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.voltageDataGridViewTextBoxColumn.Width = 70;
            // 
            // wiresDataGridViewTextBoxColumn
            // 
            this.wiresDataGridViewTextBoxColumn.DataPropertyName = "Wires";
            this.wiresDataGridViewTextBoxColumn.HeaderText = "Кол-во жил";
            this.wiresDataGridViewTextBoxColumn.Name = "wiresDataGridViewTextBoxColumn";
            this.wiresDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.wiresDataGridViewTextBoxColumn.Width = 40;
            // 
            // crossSectionDataGridViewTextBoxColumn
            // 
            this.crossSectionDataGridViewTextBoxColumn.DataPropertyName = "CrossSection";
            this.crossSectionDataGridViewTextBoxColumn.HeaderText = "Сечение";
            this.crossSectionDataGridViewTextBoxColumn.Name = "crossSectionDataGridViewTextBoxColumn";
            this.crossSectionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.crossSectionDataGridViewTextBoxColumn.Width = 50;
            // 
            // permisAmperageDataGridViewTextBoxColumn
            // 
            this.permisAmperageDataGridViewTextBoxColumn.DataPropertyName = "PermisAmperage";
            this.permisAmperageDataGridViewTextBoxColumn.HeaderText = "Допуст. нагр., А";
            this.permisAmperageDataGridViewTextBoxColumn.Name = "permisAmperageDataGridViewTextBoxColumn";
            this.permisAmperageDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.permisAmperageDataGridViewTextBoxColumn.Width = 60;
            // 
            // iadDataGridViewTextBoxColumn
            // 
            this.iadDataGridViewTextBoxColumn.DataPropertyName = "Iad";
            this.iadDataGridViewTextBoxColumn.HeaderText = "А дн.";
            this.iadDataGridViewTextBoxColumn.Name = "iadDataGridViewTextBoxColumn";
            this.iadDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.iadDataGridViewTextBoxColumn.Width = 35;
            // 
            // ianDataGridViewTextBoxColumn
            // 
            this.ianDataGridViewTextBoxColumn.DataPropertyName = "Ian";
            this.ianDataGridViewTextBoxColumn.HeaderText = "А вч.";
            this.ianDataGridViewTextBoxColumn.Name = "ianDataGridViewTextBoxColumn";
            this.ianDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ianDataGridViewTextBoxColumn.Width = 35;
            // 
            // ibdDataGridViewTextBoxColumn
            // 
            this.ibdDataGridViewTextBoxColumn.DataPropertyName = "Ibd";
            this.ibdDataGridViewTextBoxColumn.HeaderText = "В дн.";
            this.ibdDataGridViewTextBoxColumn.Name = "ibdDataGridViewTextBoxColumn";
            this.ibdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ibdDataGridViewTextBoxColumn.Width = 35;
            // 
            // ibnDataGridViewTextBoxColumn
            // 
            this.ibnDataGridViewTextBoxColumn.DataPropertyName = "Ibn";
            this.ibnDataGridViewTextBoxColumn.HeaderText = "В вч.";
            this.ibnDataGridViewTextBoxColumn.Name = "ibnDataGridViewTextBoxColumn";
            this.ibnDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ibnDataGridViewTextBoxColumn.Width = 35;
            // 
            // icdDataGridViewTextBoxColumn
            // 
            this.icdDataGridViewTextBoxColumn.DataPropertyName = "Icd";
            this.icdDataGridViewTextBoxColumn.HeaderText = "С дн.";
            this.icdDataGridViewTextBoxColumn.Name = "icdDataGridViewTextBoxColumn";
            this.icdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.icdDataGridViewTextBoxColumn.Width = 35;
            // 
            // icnDataGridViewTextBoxColumn
            // 
            this.icnDataGridViewTextBoxColumn.DataPropertyName = "Icn";
            this.icnDataGridViewTextBoxColumn.HeaderText = "С вч.";
            this.icnDataGridViewTextBoxColumn.Name = "icnDataGridViewTextBoxColumn";
            this.icnDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.icnDataGridViewTextBoxColumn.Width = 35;
            // 
            // iodDataGridViewTextBoxColumn
            // 
            this.iodDataGridViewTextBoxColumn.DataPropertyName = "Iod";
            this.iodDataGridViewTextBoxColumn.HeaderText = "0 дн.";
            this.iodDataGridViewTextBoxColumn.Name = "iodDataGridViewTextBoxColumn";
            this.iodDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.iodDataGridViewTextBoxColumn.Width = 35;
            // 
            // ionDataGridViewTextBoxColumn
            // 
            this.ionDataGridViewTextBoxColumn.DataPropertyName = "Ion";
            this.ionDataGridViewTextBoxColumn.HeaderText = "0 вч.";
            this.ionDataGridViewTextBoxColumn.Name = "ionDataGridViewTextBoxColumn";
            this.ionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ionDataGridViewTextBoxColumn.Width = 35;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idOldMeasurementCableDataGridViewTextBoxColumn
            // 
            this.idOldMeasurementCableDataGridViewTextBoxColumn.DataPropertyName = "idOldMeasurementCable";
            this.idOldMeasurementCableDataGridViewTextBoxColumn.HeaderText = "idOldMeasurementCable";
            this.idOldMeasurementCableDataGridViewTextBoxColumn.Name = "idOldMeasurementCableDataGridViewTextBoxColumn";
            this.idOldMeasurementCableDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // bsMeasCable
            // 
            this.bsMeasCable.DataMember = "tJ_MeasCable";
            this.bsMeasCable.DataSource = this.dsMeasLowVoltage;
            this.bsMeasCable.CurrentChanged += new System.EventHandler(this.bindingSource_3_CurrentChanged);
            // 
            // comboBox_1
            // 
            this.comboBox_1.DataSource = this.bsBusesTransf;
            this.comboBox_1.DisplayMember = "NameBusTransf";
            this.comboBox_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new System.Drawing.Point(144, 79);
            this.comboBox_1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.comboBox_1.Name = "comboBox_1";
            this.comboBox_1.Size = new System.Drawing.Size(95, 21);
            this.comboBox_1.TabIndex = 2;
            this.comboBox_1.ValueMember = "idBus";
            // 
            // bsBusesTransf
            // 
            this.bsBusesTransf.DataMember = "dtBusesTransf";
            this.bsBusesTransf.DataSource = this.dsMeasLowVoltage;
            this.bsBusesTransf.Sort = "NameBusTransf";
            // 
            // label_6
            // 
            this.label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_6.Location = new System.Drawing.Point(3, 79);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(135, 21);
            this.label_6.TabIndex = 1;
            this.label_6.Text = "Секция шин (тр-р) №";
            this.label_6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox_0
            // 
            this.tableLayoutPanel_0.SetColumnSpan(this.groupBox_0, 6);
            this.groupBox_0.Controls.Add(this.toolStrip_2);
            this.groupBox_0.Controls.Add(this.label_16);
            this.groupBox_0.Controls.Add(this.cbYear);
            this.groupBox_0.Controls.Add(this.dtpDateN);
            this.groupBox_0.Controls.Add(this.dtpDateD);
            this.groupBox_0.Controls.Add(this.cbWorker);
            this.groupBox_0.Controls.Add(this.nudTemperatureN);
            this.groupBox_0.Controls.Add(this.nudTemperatureD);
            this.groupBox_0.Controls.Add(this.label_0);
            this.groupBox_0.Controls.Add(this.label_1);
            this.groupBox_0.Controls.Add(this.label_2);
            this.groupBox_0.Controls.Add(this.label_3);
            this.groupBox_0.Controls.Add(this.label_4);
            this.groupBox_0.Controls.Add(this.label_5);
            this.groupBox_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_0.Location = new System.Drawing.Point(3, 3);
            this.groupBox_0.Name = "groupBox_0";
            this.groupBox_0.Size = new System.Drawing.Size(692, 73);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "Параметры замера";
            // 
            // toolStrip_2
            // 
            this.toolStrip_2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnImportTemperature});
            this.toolStrip_2.Location = new System.Drawing.Point(373, 44);
            this.toolStrip_2.Name = "toolStrip_2";
            this.toolStrip_2.Size = new System.Drawing.Size(35, 25);
            this.toolStrip_2.TabIndex = 7;
            this.toolStrip_2.Text = "toolStrip1";
            // 
            // toolBtnImportTemperature
            // 
            this.toolBtnImportTemperature.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnImportTemperature.Image = global::Properties.Resources.Pogoda1;
            this.toolBtnImportTemperature.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnImportTemperature.Name = "toolBtnImportTemperature";
            this.toolBtnImportTemperature.Size = new System.Drawing.Size(23, 22);
            this.toolBtnImportTemperature.Text = "Загрузка из реестра температур";
            this.toolBtnImportTemperature.Click += new System.EventHandler(this.toolBtnImportTemperature_Click);
            // 
            // label_16
            // 
            this.label_16.AutoSize = true;
            this.label_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_16.Location = new System.Drawing.Point(9, 21);
            this.label_16.Name = "label_16";
            this.label_16.Size = new System.Drawing.Size(48, 13);
            this.label_16.TabIndex = 0;
            this.label_16.Text = "Период:";
            this.label_16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbYear
            // 
            this.cbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbYear.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMeasurement, "Year", true));
            this.cbYear.DisplayMember = "Id";
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(9, 44);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(78, 21);
            this.cbYear.TabIndex = 1;
            this.cbYear.ValueMember = "Id";
            this.cbYear.SelectedValueChanged += new System.EventHandler(this.comboBox_3_SelectedValueChanged);
            // 
            // bsMeasurement
            // 
            this.bsMeasurement.DataMember = "tJ_Measurement";
            this.bsMeasurement.DataSource = this.dsMeasLowVoltage;
            // 
            // dtpDateN
            // 
            this.dtpDateN.CustomFormat = "ddMMMMyyyy г. HH:mm";
            this.dtpDateN.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMeasurement, "DateN", true));
            this.dtpDateN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateN.Location = new System.Drawing.Point(144, 45);
            this.dtpDateN.Name = "dtpDateN";
            this.dtpDateN.Size = new System.Drawing.Size(166, 20);
            this.dtpDateN.TabIndex = 5;
            this.dtpDateN.Value = new System.DateTime(2013, 8, 29, 10, 49, 16, 759);
            // 
            // dtpDateD
            // 
            this.dtpDateD.CustomFormat = "ddMMMMyyyy г. HH:mm";
            this.dtpDateD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMeasurement, "DateD", true));
            this.dtpDateD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateD.Location = new System.Drawing.Point(144, 20);
            this.dtpDateD.Name = "dtpDateD";
            this.dtpDateD.Size = new System.Drawing.Size(166, 20);
            this.dtpDateD.TabIndex = 4;
            this.dtpDateD.Value = new System.DateTime(2013, 8, 29, 10, 49, 16, 759);
            // 
            // cbWorker
            // 
            this.cbWorker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMeasurement, "idWorker", true));
            this.cbWorker.DataSource = this.bindingSource_0;
            this.cbWorker.DisplayMember = "FIO";
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(525, 44);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(154, 21);
            this.cbWorker.TabIndex = 13;
            this.cbWorker.ValueMember = "Id";
            // 
            // bindingSource_0
            // 
            this.bindingSource_0.DataMember = "vP_Worker";
            this.bindingSource_0.DataSource = this.dsMeasLowVoltage;
            this.bindingSource_0.Sort = "FIO";
            // 
            // nudTemperatureN
            // 
            this.nudTemperatureN.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMeasurement, "TemperatureN", true));
            this.nudTemperatureN.Location = new System.Drawing.Point(459, 45);
            this.nudTemperatureN.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudTemperatureN.Name = "nudTemperatureN";
            this.nudTemperatureN.Size = new System.Drawing.Size(48, 20);
            this.nudTemperatureN.TabIndex = 11;
            // 
            // nudTemperatureD
            // 
            this.nudTemperatureD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMeasurement, "TemperatureD", true));
            this.nudTemperatureD.Location = new System.Drawing.Point(459, 18);
            this.nudTemperatureD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudTemperatureD.Name = "nudTemperatureD";
            this.nudTemperatureD.Size = new System.Drawing.Size(48, 20);
            this.nudTemperatureD.TabIndex = 9;
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Location = new System.Drawing.Point(419, 47);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(37, 13);
            this.label_0.TabIndex = 10;
            this.label_0.Text = "Вечер";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(101, 47);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(37, 13);
            this.label_1.TabIndex = 3;
            this.label_1.Text = "Вечер";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_2.Location = new System.Drawing.Point(522, 20);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(102, 13);
            this.label_2.TabIndex = 12;
            this.label_2.Text = "Замеры проводил:";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_3.Location = new System.Drawing.Point(324, 21);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(87, 15);
            this.label_3.TabIndex = 6;
            this.label_3.Text = "Температура:";
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Location = new System.Drawing.Point(422, 20);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(34, 13);
            this.label_4.TabIndex = 8;
            this.label_4.Text = "День";
            // 
            // label_5
            // 
            this.label_5.AutoSize = true;
            this.label_5.Location = new System.Drawing.Point(101, 23);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(34, 13);
            this.label_5.TabIndex = 2;
            this.label_5.Text = "День";
            // 
            // panel_0
            // 
            this.tableLayoutPanel_0.SetColumnSpan(this.panel_0, 6);
            this.panel_0.Controls.Add(this.label_13);
            this.panel_0.Controls.Add(this.label_14);
            this.panel_0.Controls.Add(this.label_7);
            this.panel_0.Controls.Add(this.label_8);
            this.panel_0.Controls.Add(this.label_9);
            this.panel_0.Controls.Add(this.label_10);
            this.panel_0.Controls.Add(this.label_11);
            this.panel_0.Controls.Add(this.label_12);
            this.panel_0.Controls.Add(this.tbUcon);
            this.panel_0.Controls.Add(this.tbUcan);
            this.panel_0.Controls.Add(this.tbUbcn);
            this.panel_0.Controls.Add(this.tbUbon);
            this.panel_0.Controls.Add(this.tbUcod);
            this.panel_0.Controls.Add(this.tbUbod);
            this.panel_0.Controls.Add(this.tbUaon);
            this.panel_0.Controls.Add(this.tbUabn);
            this.panel_0.Controls.Add(this.tbUcad);
            this.panel_0.Controls.Add(this.tbUaod);
            this.panel_0.Controls.Add(this.tbUbcd);
            this.panel_0.Controls.Add(this.tbUabd);
            this.panel_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_0.Location = new System.Drawing.Point(3, 103);
            this.panel_0.Name = "panel_0";
            this.panel_0.Size = new System.Drawing.Size(692, 61);
            this.panel_0.TabIndex = 6;
            // 
            // label_13
            // 
            this.label_13.AutoSize = true;
            this.label_13.Location = new System.Drawing.Point(28, 40);
            this.label_13.Name = "label_13";
            this.label_13.Size = new System.Drawing.Size(37, 13);
            this.label_13.TabIndex = 13;
            this.label_13.Text = "Вечер";
            // 
            // label_14
            // 
            this.label_14.AutoSize = true;
            this.label_14.Location = new System.Drawing.Point(31, 14);
            this.label_14.Name = "label_14";
            this.label_14.Size = new System.Drawing.Size(34, 13);
            this.label_14.TabIndex = 0;
            this.label_14.Text = "День";
            // 
            // label_7
            // 
            this.label_7.AutoSize = true;
            this.label_7.Location = new System.Drawing.Point(362, 14);
            this.label_7.Name = "label_7";
            this.label_7.Size = new System.Drawing.Size(30, 13);
            this.label_7.TabIndex = 7;
            this.label_7.Text = "Ua-o";
            // 
            // label_8
            // 
            this.label_8.AutoSize = true;
            this.label_8.Location = new System.Drawing.Point(459, 14);
            this.label_8.Name = "label_8";
            this.label_8.Size = new System.Drawing.Size(30, 13);
            this.label_8.TabIndex = 9;
            this.label_8.Text = "Ub-o";
            // 
            // label_9
            // 
            this.label_9.AutoSize = true;
            this.label_9.Location = new System.Drawing.Point(270, 14);
            this.label_9.Name = "label_9";
            this.label_9.Size = new System.Drawing.Size(27, 13);
            this.label_9.TabIndex = 5;
            this.label_9.Text = "Uca";
            // 
            // label_10
            // 
            this.label_10.AutoSize = true;
            this.label_10.Location = new System.Drawing.Point(177, 14);
            this.label_10.Name = "label_10";
            this.label_10.Size = new System.Drawing.Size(27, 13);
            this.label_10.TabIndex = 3;
            this.label_10.Text = "Ubc";
            // 
            // label_11
            // 
            this.label_11.AutoSize = true;
            this.label_11.Location = new System.Drawing.Point(555, 14);
            this.label_11.Name = "label_11";
            this.label_11.Size = new System.Drawing.Size(30, 13);
            this.label_11.TabIndex = 11;
            this.label_11.Text = "Uc-o";
            // 
            // label_12
            // 
            this.label_12.AutoSize = true;
            this.label_12.Location = new System.Drawing.Point(86, 14);
            this.label_12.Name = "label_12";
            this.label_12.Size = new System.Drawing.Size(27, 13);
            this.label_12.TabIndex = 1;
            this.label_12.Text = "Uab";
            // 
            // tbUcon
            // 
            this.tbUcon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_2, "Ucon", true));
            this.tbUcon.Location = new System.Drawing.Point(591, 37);
            this.tbUcon.Name = "tbUcon";
            this.tbUcon.Size = new System.Drawing.Size(44, 20);
            this.tbUcon.TabIndex = 19;
            this.tbUcon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_11_KeyPress);
            // 
            // bindingSource_2
            // 
            this.bindingSource_2.DataMember = "tJ_MeasVoltageTransf";
            this.bindingSource_2.DataSource = this.dsMeasLowVoltage;
            // 
            // tbUcan
            // 
            this.tbUcan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_2, "Ucan", true));
            this.tbUcan.Location = new System.Drawing.Point(303, 38);
            this.tbUcan.Name = "tbUcan";
            this.tbUcan.Size = new System.Drawing.Size(44, 20);
            this.tbUcan.TabIndex = 16;
            this.tbUcan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_11_KeyPress);
            // 
            // tbUbcn
            // 
            this.tbUbcn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_2, "Ubcn", true));
            this.tbUbcn.Location = new System.Drawing.Point(210, 37);
            this.tbUbcn.Name = "tbUbcn";
            this.tbUbcn.Size = new System.Drawing.Size(44, 20);
            this.tbUbcn.TabIndex = 15;
            this.tbUbcn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_11_KeyPress);
            // 
            // tbUbon
            // 
            this.tbUbon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_2, "Ubon", true));
            this.tbUbon.Location = new System.Drawing.Point(495, 37);
            this.tbUbon.Name = "tbUbon";
            this.tbUbon.Size = new System.Drawing.Size(44, 20);
            this.tbUbon.TabIndex = 18;
            this.tbUbon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_11_KeyPress);
            // 
            // tbUcod
            // 
            this.tbUcod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_2, "Ucod", true));
            this.tbUcod.Location = new System.Drawing.Point(591, 11);
            this.tbUcod.Name = "tbUcod";
            this.tbUcod.Size = new System.Drawing.Size(44, 20);
            this.tbUcod.TabIndex = 12;
            this.tbUcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_11_KeyPress);
            // 
            // tbUbod
            // 
            this.tbUbod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_2, "Ubod", true));
            this.tbUbod.Location = new System.Drawing.Point(495, 11);
            this.tbUbod.Name = "tbUbod";
            this.tbUbod.Size = new System.Drawing.Size(44, 20);
            this.tbUbod.TabIndex = 10;
            this.tbUbod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_11_KeyPress);
            // 
            // tbUaon
            // 
            this.tbUaon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_2, "Uaon", true));
            this.tbUaon.Location = new System.Drawing.Point(398, 37);
            this.tbUaon.Name = "tbUaon";
            this.tbUaon.Size = new System.Drawing.Size(44, 20);
            this.tbUaon.TabIndex = 17;
            this.tbUaon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_11_KeyPress);
            // 
            // tbUabn
            // 
            this.tbUabn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_2, "Uabn", true));
            this.tbUabn.Location = new System.Drawing.Point(119, 37);
            this.tbUabn.Name = "tbUabn";
            this.tbUabn.Size = new System.Drawing.Size(44, 20);
            this.tbUabn.TabIndex = 14;
            this.tbUabn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_11_KeyPress);
            // 
            // tbUcad
            // 
            this.tbUcad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_2, "Ucad", true));
            this.tbUcad.Location = new System.Drawing.Point(303, 11);
            this.tbUcad.Name = "tbUcad";
            this.tbUcad.Size = new System.Drawing.Size(44, 20);
            this.tbUcad.TabIndex = 6;
            this.tbUcad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_11_KeyPress);
            // 
            // tbUaod
            // 
            this.tbUaod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_2, "Uaod", true));
            this.tbUaod.Location = new System.Drawing.Point(398, 11);
            this.tbUaod.Name = "tbUaod";
            this.tbUaod.Size = new System.Drawing.Size(44, 20);
            this.tbUaod.TabIndex = 8;
            this.tbUaod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_11_KeyPress);
            // 
            // tbUbcd
            // 
            this.tbUbcd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_2, "Ubcd", true));
            this.tbUbcd.Location = new System.Drawing.Point(210, 11);
            this.tbUbcd.Name = "tbUbcd";
            this.tbUbcd.Size = new System.Drawing.Size(44, 20);
            this.tbUbcd.TabIndex = 4;
            this.tbUbcd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_11_KeyPress);
            // 
            // tbUabd
            // 
            this.tbUabd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_2, "Uabd", true));
            this.tbUabd.Location = new System.Drawing.Point(119, 11);
            this.tbUabd.Name = "tbUabd";
            this.tbUabd.Size = new System.Drawing.Size(44, 20);
            this.tbUabd.TabIndex = 2;
            this.tbUabd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_11_KeyPress);
            // 
            // toolStrip_0
            // 
            this.tableLayoutPanel_0.SetColumnSpan(this.toolStrip_0, 6);
            this.toolStrip_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip_0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMeasAbnObjAdd,
            this.toolStripButton_1,
            this.tsbMeasAbnObjDelete,
            this.toolStripSeparator_0,
            this.tsbMeasAbnObjRefresh});
            this.toolStrip_0.Location = new System.Drawing.Point(0, 365);
            this.toolStrip_0.Name = "toolStrip_0";
            this.toolStrip_0.Size = new System.Drawing.Size(698, 24);
            this.toolStrip_0.TabIndex = 9;
            this.toolStrip_0.Text = "toolStrip1";
            // 
            // tsbMeasAbnObjAdd
            // 
            this.tsbMeasAbnObjAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMeasAbnObjAdd.Image = global::Properties.Resources.Add;
            this.tsbMeasAbnObjAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMeasAbnObjAdd.Name = "tsbMeasAbnObjAdd";
            this.tsbMeasAbnObjAdd.Size = new System.Drawing.Size(23, 21);
            this.tsbMeasAbnObjAdd.Text = "Добавить";
            this.tsbMeasAbnObjAdd.Click += new System.EventHandler(this.tsbMeasAbnObjAdd_Click);
            // 
            // toolStripButton_1
            // 
            this.toolStripButton_1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = global::Properties.Resources.Edit;
            this.toolStripButton_1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_1.Name = "toolStripButton_1";
            this.toolStripButton_1.Size = new System.Drawing.Size(23, 21);
            this.toolStripButton_1.Text = "Редактировать";
            this.toolStripButton_1.Visible = false;
            // 
            // tsbMeasAbnObjDelete
            // 
            this.tsbMeasAbnObjDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMeasAbnObjDelete.Image = global::Properties.Resources.Delete;
            this.tsbMeasAbnObjDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMeasAbnObjDelete.Name = "tsbMeasAbnObjDelete";
            this.tsbMeasAbnObjDelete.Size = new System.Drawing.Size(23, 21);
            this.tsbMeasAbnObjDelete.Text = "Удалить";
            this.tsbMeasAbnObjDelete.Click += new System.EventHandler(this.tsbMeasAbnObjDelete_Click);
            // 
            // toolStripSeparator_0
            // 
            this.toolStripSeparator_0.Name = "toolStripSeparator_0";
            this.toolStripSeparator_0.Size = new System.Drawing.Size(6, 24);
            // 
            // tsbMeasAbnObjRefresh
            // 
            this.tsbMeasAbnObjRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMeasAbnObjRefresh.Image = global::Properties.Resources.Refresh;
            this.tsbMeasAbnObjRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMeasAbnObjRefresh.Name = "tsbMeasAbnObjRefresh";
            this.tsbMeasAbnObjRefresh.Size = new System.Drawing.Size(23, 21);
            this.tsbMeasAbnObjRefresh.Text = "Обновить";
            this.tsbMeasAbnObjRefresh.Click += new System.EventHandler(this.tsbMeasAbnObjRefresh_Click);
            // 
            // comboBox_2
            // 
            this.comboBox_2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource_2, "idSwitchPosition", true));
            this.comboBox_2.DataSource = this.bindingSource_13;
            this.comboBox_2.DisplayMember = "Name";
            this.comboBox_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_2.FormattingEnabled = true;
            this.comboBox_2.Location = new System.Drawing.Point(592, 79);
            this.comboBox_2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.comboBox_2.Name = "comboBox_2";
            this.comboBox_2.Size = new System.Drawing.Size(90, 21);
            this.comboBox_2.TabIndex = 5;
            this.comboBox_2.ValueMember = "Id";
            // 
            // bindingSource_13
            // 
            this.bindingSource_13.DataMember = "tR_Classifier";
            this.bindingSource_13.DataSource = this.dsMeasLowVoltage;
            this.bindingSource_13.Filter = "ParentKey = \';Measurement;Switch;\'";
            this.bindingSource_13.Sort = "Name";
            // 
            // tableLayoutPanel_1
            // 
            this.tableLayoutPanel_1.ColumnCount = 2;
            this.tableLayoutPanel_0.SetColumnSpan(this.tableLayoutPanel_1, 6);
            this.tableLayoutPanel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel_1.Controls.Add(this.button_0, 1, 0);
            this.tableLayoutPanel_1.Controls.Add(this.button_1, 0, 0);
            this.tableLayoutPanel_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_1.Location = new System.Drawing.Point(3, 526);
            this.tableLayoutPanel_1.Name = "tableLayoutPanel_1";
            this.tableLayoutPanel_1.RowCount = 1;
            this.tableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_1.Size = new System.Drawing.Size(692, 33);
            this.tableLayoutPanel_1.TabIndex = 11;
            // 
            // button_0
            // 
            this.button_0.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_0.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_0.Location = new System.Drawing.Point(586, 3);
            this.button_0.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(75, 27);
            this.button_0.TabIndex = 1;
            this.button_0.Text = "Отмена";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_1
            // 
            this.button_1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_1.Location = new System.Drawing.Point(467, 3);
            this.button_1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(99, 27);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "Применить";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // bsCellByTransf
            // 
            this.bsCellByTransf.DataMember = "vJ_CellByBus";
            this.bsCellByTransf.DataSource = this.dsMeasLowVoltage;
            this.bsCellByTransf.Sort = "";
            this.bsCellByTransf.CurrentChanged += new System.EventHandler(this.bsCellByTransf_CurrentChanged);
            // 
            // bindingSource_8
            // 
            this.bindingSource_8.DataMember = "tR_CableMakeup";
            this.bindingSource_8.DataSource = this.dsMeasLowVoltage;
            this.bindingSource_8.Filter = "";
            this.bindingSource_8.Sort = "CableMakeup";
            // 
            // bindingSource_9
            // 
            this.bindingSource_9.DataMember = "tR_CableVoltage";
            this.bindingSource_9.DataSource = this.dsMeasLowVoltage;
            this.bindingSource_9.Filter = "";
            this.bindingSource_9.Sort = "Name";
            // 
            // bindingSource_15
            // 
            this.bindingSource_15.DataMember = "tR_CableWires";
            this.bindingSource_15.DataSource = this.dsMeasLowVoltage;
            this.bindingSource_15.Sort = "Wires";
            // 
            // bindingSource_10
            // 
            this.bindingSource_10.DataMember = "tR_CrossSection";
            this.bindingSource_10.DataSource = this.dsMeasLowVoltage;
            this.bindingSource_10.Filter = "";
            this.bindingSource_10.Sort = "CrossSection";
            // 
            // bindingSource_14
            // 
            this.bindingSource_14.DataMember = "tR_CableAmperage";
            this.bindingSource_14.DataSource = this.dsMeasLowVoltage;
            this.bindingSource_14.Sort = "Amperage";
            // 
            // bindingSource_4
            // 
            this.bindingSource_4.DataMember = "tJ_MeasAmperageTransf";
            this.bindingSource_4.DataSource = this.dsMeasLowVoltage;
            // 
            // bindingSource_5
            // 
            this.bindingSource_5.DataMember = "vJ_MeasTransfPassport";
            this.bindingSource_5.DataSource = this.dsMeasLowVoltage;
            // 
            // bindingSource_6
            // 
            this.bindingSource_6.DataMember = "tP_ValueLists";
            this.bindingSource_6.DataSource = this.dsMeasLowVoltage;
            this.bindingSource_6.Sort = "Name";
            // 
            // FormAddEditMeasLowVoltage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 562);
            this.Controls.Add(this.tableLayoutPanel_0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddEditMeasLowVoltage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddEditMeasTransfVoltage";
            this.Load += new System.EventHandler(this.FormAddEditMeasLowVoltage_Load);
            this.tableLayoutPanel_0.ResumeLayout(false);
            this.tableLayoutPanel_0.PerformLayout();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMeasLowVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasCable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasCable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBusesTransf)).EndInit();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.toolStrip_2.ResumeLayout(false);
            this.toolStrip_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatureN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatureD)).EndInit();
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_2)).EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_13)).EndInit();
            this.tableLayoutPanel_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsCellByTransf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_6)).EndInit();
            this.ResumeLayout(false);

        }

        private BindingSource bindingSource_0;
        private BindingSource bsMeasurement;
        private BindingSource bindingSource_10;
        private BindingSource bindingSource_11;
        private BindingSource bsBusesTransf;
        private BindingSource bindingSource_13;
        private BindingSource bindingSource_14;
        private BindingSource bindingSource_15;
        private BindingSource bindingSource_2;
        private BindingSource bsMeasCable;
        private BindingSource bindingSource_4;
        private BindingSource bindingSource_5;
        private BindingSource bindingSource_6;
        private BindingSource bsCellByTransf;
        private BindingSource bindingSource_8;
        private BindingSource bindingSource_9;

        private Button button_0;
        private Button button_1;
        private ComboBox cbWorker;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private ComboBox cbYear;
        private DataGridView dgvMeasCable;
        private DataGridView dgvAbnObj;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_3;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;
        private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSchmObjDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        //private DataSetGES dataSetGES_0;
        private Documents.DataSets.DataSetMeasurementN dsMeasLowVoltage;
        private GroupBox groupBox_0;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label label_11;
        private Label label_12;
        private Label label_13;
        private Label label_14;
        private Label label_15;
        private Label label_16;
        private Label lbSerialNumber;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        
        private NullableDateTimePicker dtpDateN;
        private NullableDateTimePicker dtpDateD;
        private NumericUpDown nudTemperatureN;
        private NumericUpDown nudTemperatureD;
        private Panel panel_0;
        private TableLayoutPanel tableLayoutPanel_0;
        private TableLayoutPanel tableLayoutPanel_1;
        private TextBox tbUcon;
        private TextBox tbUcan;
        private TextBox tbUbcd;
        private TextBox tbUabd;
        private TextBox tbUbcn;
        private TextBox tbUbon;
        private TextBox tbUcod;
        private TextBox tbUbod;
        private TextBox tbUaon;
        private TextBox tbUabn;
        private TextBox tbUcad;
        private TextBox tbUaod;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStrip toolStrip_2;
        private ToolStripButton tsbMeasAbnObjAdd;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton tsbMeasAbnObjDelete;
        private ToolStripButton tsbMeasAbnObjRefresh;
        private ToolStripButton tssbAddMissingCells;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolBtnImportTemperature;
        private ToolStripMenuItem tsmiMeasCableDelAddress;
        private ToolStripMenuItem toolStripMenuItem_1;
        private ToolStripMenuItem toolStripMenuItem_2;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator_3;
        private ToolStripSplitButton toolStripSplitButton1;
        private DataGridViewTextBoxColumn typeDocDgvColumn;
        private DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeAbonent;
        private DataGridViewTextBoxColumn dgvcIds;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idMeasurementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idBusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTransfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oldCellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCableDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCableDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSchmAbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn makeupDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wiresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn crossSectionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn permisAmperageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ianDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ibdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ibnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn icdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn icnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idOldMeasurementCableDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
    }
}
