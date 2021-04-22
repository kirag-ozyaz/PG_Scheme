using ControlsLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace JournalOrder
{
    internal partial class FormJournalOrderAddEdit
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumOrder = new System.Windows.Forms.TextBox();
            this.dataSetOrder = new JournalOrder.DataSet.DataSetOrder();
            this.labelDateBegin = new System.Windows.Forms.Label();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.richTxtInstruction = new System.Windows.Forms.RichTextBox();
            this.labelSR = new System.Windows.Forms.Label();
            this.cmbSR = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAccept = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMaker = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTxtOtrherInstructions = new System.Windows.Forms.RichTextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.cmbAcceptWorker = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateBegin = new ControlsLbr.NullableDateTimePicker();
            this.dateTimePickerDateEnd = new ControlsLbr.NullableDateTimePicker();
            this.cmbHeadWorker = new System.Windows.Forms.ComboBox();
            this.cmbWatchWorker = new System.Windows.Forms.ComboBox();
            this.cmbMakerWorker = new System.Windows.Forms.ComboBox();
            this.cmbOutputWorker = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateOutput = new ControlsLbr.NullableDateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.dgvBrigade = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brigadeWorkerColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GroupElectricalTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJobTitleDgvColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isUnderstudyDgvColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvInstruction = new System.Windows.Forms.DataGridView();
            this.dgvResolution = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerResolutionColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbWorkerResolution = new System.Windows.Forms.ComboBox();
            this.dateTimePickerResolution = new ControlsLbr.NullableDateTimePicker();
            this.buttonResolution = new System.Windows.Forms.Button();
            this.buttonCloseOrder = new System.Windows.Forms.Button();
            this.dateTimePickerClose = new ControlsLbr.NullableDateTimePicker();
            this.cmbCloseWorker = new System.Windows.Forms.ComboBox();
            this.toolStripReport = new System.Windows.Forms.ToolStrip();
            this.toolBtnReport = new System.Windows.Forms.ToolStripButton();
            this.toolBtnCopyOrder = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.labelOutputDate = new System.Windows.Forms.Label();
            this.panelExtension = new System.Windows.Forms.Panel();
            this.buttonExtension = new System.Windows.Forms.Button();
            this.dateTimePickerDateEndExt = new ControlsLbr.NullableDateTimePicker();
            this.cmbExtWorker = new ControlsLbr.MultiColumnComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutputWorker = new System.Windows.Forms.TextBox();
            this.toolStripScheme = new System.Windows.Forms.ToolStrip();
            this.toolBtnLinkSchmObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelSchmObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnViewSChmObj = new System.Windows.Forms.ToolStripButton();
            this.listBoxLinkScmObjects = new System.Windows.Forms.ListBox();
            this.labelDivision = new System.Windows.Forms.Label();
            this.cmbDivision = new ControlsLbr.ComboBoxReadOnly();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMakerWorker = new System.Windows.Forms.TextBox();
            this.txtWatchWorker = new System.Windows.Forms.TextBox();
            this.txtAcceptWorker = new System.Windows.Forms.TextBox();
            this.txtHeadWorker = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrderDgvColumnInstruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsolatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrigade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstruction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResolution)).BeginInit();
            this.toolStripReport.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelExtension.SuspendLayout();
            this.toolStripScheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наряд-допуск №";
            // 
            // txtNumOrder
            // 
            this.txtNumOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumOrder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetOrder, "tJ_Order.num", true));
            this.txtNumOrder.Location = new System.Drawing.Point(110, 34);
            this.txtNumOrder.Name = "txtNumOrder";
            this.txtNumOrder.ReadOnly = true;
            this.txtNumOrder.Size = new System.Drawing.Size(102, 20);
            this.txtNumOrder.TabIndex = 1;
            // 
            // dataSetOrder
            // 
            this.dataSetOrder.DataSetName = "DataSetOrder";
            this.dataSetOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelDateBegin
            // 
            this.labelDateBegin.AutoSize = true;
            this.labelDateBegin.Location = new System.Drawing.Point(13, 77);
            this.labelDateBegin.Name = "labelDateBegin";
            this.labelDateBegin.Size = new System.Drawing.Size(84, 13);
            this.labelDateBegin.TabIndex = 2;
            this.labelDateBegin.Text = "Начало работы";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(13, 99);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(102, 13);
            this.labelDateEnd.TabIndex = 3;
            this.labelDateEnd.Text = "Окончание работы";
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstruction.Location = new System.Drawing.Point(13, 123);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(87, 17);
            this.labelInstruction.TabIndex = 6;
            this.labelInstruction.Text = "Поручается";
            // 
            // richTxtInstruction
            // 
            this.richTxtInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtInstruction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetOrder, "tJ_Order.instruction", true));
            this.richTxtInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTxtInstruction.Location = new System.Drawing.Point(16, 143);
            this.richTxtInstruction.Name = "richTxtInstruction";
            this.richTxtInstruction.Size = new System.Drawing.Size(230, 86);
            this.richTxtInstruction.TabIndex = 7;
            this.richTxtInstruction.Text = "";
            this.richTxtInstruction.TextChanged += new System.EventHandler(this.richTxtInstruction_TextChanged);
            // 
            // labelSR
            // 
            this.labelSR.AutoSize = true;
            this.labelSR.Location = new System.Drawing.Point(44, 17);
            this.labelSR.Name = "labelSR";
            this.labelSR.Size = new System.Drawing.Size(82, 13);
            this.labelSR.TabIndex = 8;
            this.labelSR.Text = "Сетевой район";
            // 
            // cmbSR
            // 
            this.cmbSR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSR.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetOrder, "tJ_Order.idSR", true));
            this.cmbSR.DataSource = this.dataSetOrder;
            this.cmbSR.DisplayMember = "tR_Classifier.Name";
            this.cmbSR.FormattingEnabled = true;
            this.cmbSR.Location = new System.Drawing.Point(132, 14);
            this.cmbSR.Name = "cmbSR";
            this.cmbSR.Size = new System.Drawing.Size(158, 21);
            this.cmbSR.TabIndex = 9;
            this.cmbSR.ValueMember = "tR_Classifier.Id";
            this.cmbSR.SelectedValueChanged += new System.EventHandler(this.cmbSR_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Руководитель работ";
            // 
            // labelAccept
            // 
            this.labelAccept.AutoSize = true;
            this.labelAccept.Location = new System.Drawing.Point(44, 95);
            this.labelAccept.Name = "labelAccept";
            this.labelAccept.Size = new System.Drawing.Size(80, 13);
            this.labelAccept.TabIndex = 11;
            this.labelAccept.Text = "Допускающий";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Наблюдающий";
            // 
            // labelMaker
            // 
            this.labelMaker.AutoSize = true;
            this.labelMaker.Location = new System.Drawing.Point(6, 152);
            this.labelMaker.Name = "labelMaker";
            this.labelMaker.Size = new System.Drawing.Size(118, 13);
            this.labelMaker.TabIndex = 13;
            this.labelMaker.Text = "Производитель работ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Члены бригады";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Отдельные указания";
            // 
            // richTxtOtrherInstructions
            // 
            this.richTxtOtrherInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtOtrherInstructions.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetOrder, "tJ_Order.otherInstruction", true));
            this.richTxtOtrherInstructions.Location = new System.Drawing.Point(16, 248);
            this.richTxtOtrherInstructions.Name = "richTxtOtrherInstructions";
            this.richTxtOtrherInstructions.Size = new System.Drawing.Size(230, 85);
            this.richTxtOtrherInstructions.TabIndex = 16;
            this.richTxtOtrherInstructions.Text = "";
            // 
            // labelOutput
            // 
            this.labelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(13, 408);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(74, 13);
            this.labelOutput.TabIndex = 17;
            this.labelOutput.Text = "Наряд выдал";
            // 
            // cmbAcceptWorker
            // 
            this.cmbAcceptWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAcceptWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAcceptWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetOrder, "tJ_Order.acceptworker", true));
            this.cmbAcceptWorker.DisplayMember = "FIO";
            this.cmbAcceptWorker.FormattingEnabled = true;
            this.cmbAcceptWorker.Location = new System.Drawing.Point(132, 92);
            this.cmbAcceptWorker.Name = "cmbAcceptWorker";
            this.cmbAcceptWorker.Size = new System.Drawing.Size(133, 21);
            this.cmbAcceptWorker.TabIndex = 21;
            this.cmbAcceptWorker.ValueMember = "id";
            this.cmbAcceptWorker.SelectedIndexChanged += new System.EventHandler(this.cmbAcceptWorker_SelectedIndexChanged);
            this.cmbAcceptWorker.SelectedValueChanged += new System.EventHandler(this.cmbAcceptWorker_SelectedValueChanged);
            this.cmbAcceptWorker.TextChanged += new System.EventHandler(this.cmbAcceptWorker_TextChanged);
            // 
            // dateTimePickerDateBegin
            // 
            this.dateTimePickerDateBegin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateBegin.CustomFormat = "dd:MM:yyyy HH:mm";
            this.dateTimePickerDateBegin.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetOrder, "tJ_Order.dateBegin", true));
            this.dateTimePickerDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateBegin.Location = new System.Drawing.Point(115, 71);
            this.dateTimePickerDateBegin.Name = "dateTimePickerDateBegin";
            this.dateTimePickerDateBegin.Size = new System.Drawing.Size(131, 20);
            this.dateTimePickerDateBegin.TabIndex = 24;
            this.dateTimePickerDateBegin.Value = new System.DateTime(2012, 6, 5, 9, 25, 13, 282);
            this.dateTimePickerDateBegin.ValueChanged += new System.EventHandler(this.dateTimePickerDateBegin_ValueChanged);
            // 
            // dateTimePickerDateEnd
            // 
            this.dateTimePickerDateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateEnd.CustomFormat = "dd:MM:yyyy HH:mm";
            this.dateTimePickerDateEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetOrder, "tJ_Order.dateEnd", true));
            this.dateTimePickerDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateEnd.Location = new System.Drawing.Point(115, 93);
            this.dateTimePickerDateEnd.Name = "dateTimePickerDateEnd";
            this.dateTimePickerDateEnd.Size = new System.Drawing.Size(131, 20);
            this.dateTimePickerDateEnd.TabIndex = 25;
            this.dateTimePickerDateEnd.Value = new System.DateTime(2012, 6, 5, 9, 28, 51, 995);
            this.dateTimePickerDateEnd.ValueChanged += new System.EventHandler(this.dateTimePickerDateEnd_ValueChanged);
            // 
            // cmbHeadWorker
            // 
            this.cmbHeadWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHeadWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHeadWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetOrder, "tJ_Order.headworker", true));
            this.cmbHeadWorker.DisplayMember = "FIO";
            this.cmbHeadWorker.FormattingEnabled = true;
            this.cmbHeadWorker.Location = new System.Drawing.Point(132, 64);
            this.cmbHeadWorker.Name = "cmbHeadWorker";
            this.cmbHeadWorker.Size = new System.Drawing.Size(133, 21);
            this.cmbHeadWorker.TabIndex = 26;
            this.cmbHeadWorker.ValueMember = "id";
            this.cmbHeadWorker.SelectedIndexChanged += new System.EventHandler(this.cmbHeadWorker_SelectedIndexChanged);
            this.cmbHeadWorker.TextChanged += new System.EventHandler(this.cmbHeadWorker_TextChanged);
            // 
            // cmbWatchWorker
            // 
            this.cmbWatchWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWatchWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWatchWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetOrder, "tJ_Order.watchWorker", true));
            this.cmbWatchWorker.DisplayMember = "FIO";
            this.cmbWatchWorker.FormattingEnabled = true;
            this.cmbWatchWorker.Location = new System.Drawing.Point(132, 121);
            this.cmbWatchWorker.Name = "cmbWatchWorker";
            this.cmbWatchWorker.Size = new System.Drawing.Size(133, 21);
            this.cmbWatchWorker.TabIndex = 27;
            this.cmbWatchWorker.ValueMember = "id";
            this.cmbWatchWorker.SelectedIndexChanged += new System.EventHandler(this.cmbWatchWorker_SelectedIndexChanged);
            this.cmbWatchWorker.TextChanged += new System.EventHandler(this.cmbWatchWorker_TextChanged);
            // 
            // cmbMakerWorker
            // 
            this.cmbMakerWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMakerWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMakerWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetOrder, "tJ_Order.makerWorker", true));
            this.cmbMakerWorker.DisplayMember = "FIO";
            this.cmbMakerWorker.FormattingEnabled = true;
            this.cmbMakerWorker.Location = new System.Drawing.Point(132, 149);
            this.cmbMakerWorker.Name = "cmbMakerWorker";
            this.cmbMakerWorker.Size = new System.Drawing.Size(133, 21);
            this.cmbMakerWorker.TabIndex = 28;
            this.cmbMakerWorker.ValueMember = "id";
            this.cmbMakerWorker.SelectedIndexChanged += new System.EventHandler(this.cmbMakerWorker_SelectedIndexChanged);
            this.cmbMakerWorker.SelectedValueChanged += new System.EventHandler(this.cmbMakerWorker_SelectedValueChanged);
            this.cmbMakerWorker.TextChanged += new System.EventHandler(this.cmbMakerWorker_TextChanged);
            // 
            // cmbOutputWorker
            // 
            this.cmbOutputWorker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOutputWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOutputWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOutputWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetOrder, "tJ_Order.outputWorker", true));
            this.cmbOutputWorker.DisplayMember = "FIO";
            this.cmbOutputWorker.FormattingEnabled = true;
            this.cmbOutputWorker.Location = new System.Drawing.Point(93, 405);
            this.cmbOutputWorker.Name = "cmbOutputWorker";
            this.cmbOutputWorker.Size = new System.Drawing.Size(124, 21);
            this.cmbOutputWorker.TabIndex = 29;
            this.cmbOutputWorker.ValueMember = "id";
            this.cmbOutputWorker.SelectedIndexChanged += new System.EventHandler(this.cmbOutputWorker_SelectedIndexChanged);
            this.cmbOutputWorker.SelectedValueChanged += new System.EventHandler(this.cmbOutputWorker_SelectedValueChanged);
            this.cmbOutputWorker.TextChanged += new System.EventHandler(this.cmbOutputWorker_TextChanged);
            // 
            // dateTimePickerDateOutput
            // 
            this.dateTimePickerDateOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateOutput.CustomFormat = "dd:MM:yyyy HH:mm";
            this.dateTimePickerDateOutput.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetOrder, "tJ_Order.dateOutput", true));
            this.dateTimePickerDateOutput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOutput.Location = new System.Drawing.Point(93, 431);
            this.dateTimePickerDateOutput.Name = "dateTimePickerDateOutput";
            this.dateTimePickerDateOutput.Size = new System.Drawing.Size(152, 20);
            this.dateTimePickerDateOutput.TabIndex = 30;
            this.dateTimePickerDateOutput.Value = new System.DateTime(2012, 6, 5, 9, 28, 51, 995);
            this.dateTimePickerDateOutput.ValueChanged += new System.EventHandler(this.dateTimePickerDateOutput_ValueChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(16, 517);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRegister.Location = new System.Drawing.Point(97, 517);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(114, 23);
            this.buttonRegister.TabIndex = 32;
            this.buttonRegister.Text = "Зарегистрировать";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // dgvBrigade
            // 
            this.dgvBrigade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBrigade.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrigade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBrigade.ColumnHeadersVisible = false;
            this.dgvBrigade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idOrderDataGridViewTextBoxColumn,
            this.brigadeWorkerColumn,
            this.GroupElectricalTxtColumn,
            this.idJobTitleDgvColumn,
            this.isUnderstudyDgvColumn});
            this.dgvBrigade.DataMember = "tJ_OrderBrigade";
            this.dgvBrigade.DataSource = this.dataSetOrder;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrigade.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBrigade.Location = new System.Drawing.Point(296, 36);
            this.dgvBrigade.Name = "dgvBrigade";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrigade.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBrigade.RowHeadersWidth = 30;
            this.dgvBrigade.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBrigade.Size = new System.Drawing.Size(310, 134);
            this.dgvBrigade.TabIndex = 33;
            this.dgvBrigade.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrigade_CellEndEdit);
            this.dgvBrigade.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrigade_CellValueChanged);
            this.dgvBrigade.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            this.dgvBrigade.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBrigade_EditingControlShowing);
            this.dgvBrigade.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvBrigade_RowsAdded);
            this.dgvBrigade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBrigade_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idOrderDataGridViewTextBoxColumn
            // 
            this.idOrderDataGridViewTextBoxColumn.DataPropertyName = "idOrder";
            this.idOrderDataGridViewTextBoxColumn.HeaderText = "idOrder";
            this.idOrderDataGridViewTextBoxColumn.Name = "idOrderDataGridViewTextBoxColumn";
            this.idOrderDataGridViewTextBoxColumn.Visible = false;
            // 
            // brigadeWorkerColumn
            // 
            this.brigadeWorkerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brigadeWorkerColumn.DataPropertyName = "idWorker";
            this.brigadeWorkerColumn.HeaderText = "idWorker";
            this.brigadeWorkerColumn.Name = "brigadeWorkerColumn";
            this.brigadeWorkerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.brigadeWorkerColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GroupElectricalTxtColumn
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.GroupElectricalTxtColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.GroupElectricalTxtColumn.HeaderText = "Гр";
            this.GroupElectricalTxtColumn.Name = "GroupElectricalTxtColumn";
            this.GroupElectricalTxtColumn.ReadOnly = true;
            this.GroupElectricalTxtColumn.Width = 25;
            // 
            // idJobTitleDgvColumn
            // 
            this.idJobTitleDgvColumn.DataPropertyName = "idJobTitle";
            this.idJobTitleDgvColumn.HeaderText = "должн.";
            this.idJobTitleDgvColumn.Name = "idJobTitleDgvColumn";
            // 
            // isUnderstudyDgvColumn
            // 
            this.isUnderstudyDgvColumn.DataPropertyName = "isUnderstudy";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.NullValue = false;
            this.isUnderstudyDgvColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.isUnderstudyDgvColumn.HeaderText = "дублер";
            this.isUnderstudyDgvColumn.Name = "isUnderstudyDgvColumn";
            this.isUnderstudyDgvColumn.Width = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(147, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Меры по подготовке рабочих мест";
            // 
            // dgvInstruction
            // 
            this.dgvInstruction.AllowDrop = true;
            this.dgvInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInstruction.AutoGenerateColumns = false;
            this.dgvInstruction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstruction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInstruction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstruction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.idOrderDgvColumnInstruction,
            this.nameObjDataGridViewTextBoxColumn,
            this.instructionDataGridViewTextBoxColumn,
            this.recnumDataGridViewTextBoxColumn,
            this.IsolatedDataGridViewTextBoxColumn});
            this.dgvInstruction.DataMember = "tJ_OrderInstruction";
            this.dgvInstruction.DataSource = this.dataSetOrder;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInstruction.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInstruction.Location = new System.Drawing.Point(9, 193);
            this.dgvInstruction.Name = "dgvInstruction";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstruction.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstruction.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInstruction.RowTemplate.Height = 44;
            this.dgvInstruction.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstruction.Size = new System.Drawing.Size(597, 169);
            this.dgvInstruction.TabIndex = 35;
            this.dgvInstruction.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstruction_CellDoubleClick);
            this.dgvInstruction.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstruction_CellValueChanged);
            this.dgvInstruction.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvInstruction_DataError);
            // 
            // dgvResolution
            // 
            this.dgvResolution.AllowUserToAddRows = false;
            this.dgvResolution.AllowUserToDeleteRows = false;
            this.dgvResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResolution.AutoGenerateColumns = false;
            this.dgvResolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResolution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.idOrderDataGridViewTextBoxColumn1,
            this.workerResolutionColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn});
            this.dgvResolution.DataMember = "tJ_OrderResolution";
            this.dgvResolution.DataSource = this.dataSetOrder;
            this.dgvResolution.Location = new System.Drawing.Point(9, 381);
            this.dgvResolution.Name = "dgvResolution";
            this.dgvResolution.ReadOnly = true;
            this.dgvResolution.RowHeadersVisible = false;
            this.dgvResolution.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResolution.Size = new System.Drawing.Size(421, 117);
            this.dgvResolution.TabIndex = 36;
            this.dgvResolution.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // idOrderDataGridViewTextBoxColumn1
            // 
            this.idOrderDataGridViewTextBoxColumn1.DataPropertyName = "idOrder";
            this.idOrderDataGridViewTextBoxColumn1.HeaderText = "idOrder";
            this.idOrderDataGridViewTextBoxColumn1.Name = "idOrderDataGridViewTextBoxColumn1";
            this.idOrderDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idOrderDataGridViewTextBoxColumn1.Visible = false;
            // 
            // workerResolutionColumn
            // 
            this.workerResolutionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workerResolutionColumn.DataPropertyName = "idWorker";
            this.workerResolutionColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.workerResolutionColumn.FillWeight = 40F;
            this.workerResolutionColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.workerResolutionColumn.HeaderText = "Выдал";
            this.workerResolutionColumn.Name = "workerResolutionColumn";
            this.workerResolutionColumn.ReadOnly = true;
            this.workerResolutionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateBeginDataGridViewTextBoxColumn
            // 
            this.dateBeginDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn.FillWeight = 30F;
            this.dateBeginDataGridViewTextBoxColumn.HeaderText = "Начало работ";
            this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
            this.dateBeginDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateBeginDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.FillWeight = 30F;
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "Работа закончена";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateEndDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmbWorkerResolution
            // 
            this.cmbWorkerResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWorkerResolution.Enabled = false;
            this.cmbWorkerResolution.FormattingEnabled = true;
            this.cmbWorkerResolution.Location = new System.Drawing.Point(436, 381);
            this.cmbWorkerResolution.Name = "cmbWorkerResolution";
            this.cmbWorkerResolution.Size = new System.Drawing.Size(170, 21);
            this.cmbWorkerResolution.TabIndex = 37;
            this.cmbWorkerResolution.SelectedIndexChanged += new System.EventHandler(this.cmbWorkerResolution_SelectedIndexChanged);
            // 
            // dateTimePickerResolution
            // 
            this.dateTimePickerResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerResolution.CustomFormat = "dd:MM:yyyy HH:mm";
            this.dateTimePickerResolution.Enabled = false;
            this.dateTimePickerResolution.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerResolution.Location = new System.Drawing.Point(436, 408);
            this.dateTimePickerResolution.Name = "dateTimePickerResolution";
            this.dateTimePickerResolution.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerResolution.TabIndex = 38;
            this.dateTimePickerResolution.Value = new System.DateTime(2012, 6, 5, 9, 28, 51, 995);
            // 
            // buttonResolution
            // 
            this.buttonResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResolution.Enabled = false;
            this.buttonResolution.Location = new System.Drawing.Point(472, 434);
            this.buttonResolution.Name = "buttonResolution";
            this.buttonResolution.Size = new System.Drawing.Size(134, 23);
            this.buttonResolution.TabIndex = 39;
            this.buttonResolution.Text = "Выдать разрешение";
            this.buttonResolution.UseVisualStyleBackColor = true;
            this.buttonResolution.Click += new System.EventHandler(this.buttonResolution_Click);
            // 
            // buttonCloseOrder
            // 
            this.buttonCloseOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseOrder.Enabled = false;
            this.buttonCloseOrder.Location = new System.Drawing.Point(472, 517);
            this.buttonCloseOrder.Name = "buttonCloseOrder";
            this.buttonCloseOrder.Size = new System.Drawing.Size(134, 23);
            this.buttonCloseOrder.TabIndex = 42;
            this.buttonCloseOrder.Text = "Закрыть наряд";
            this.buttonCloseOrder.UseVisualStyleBackColor = true;
            this.buttonCloseOrder.Click += new System.EventHandler(this.buttonCloseOrder_Click);
            // 
            // dateTimePickerClose
            // 
            this.dateTimePickerClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerClose.CustomFormat = "dd:MM:yyyy HH:mm";
            this.dateTimePickerClose.Enabled = false;
            this.dateTimePickerClose.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerClose.Location = new System.Drawing.Point(260, 520);
            this.dateTimePickerClose.Name = "dateTimePickerClose";
            this.dateTimePickerClose.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerClose.TabIndex = 41;
            this.dateTimePickerClose.Value = new System.DateTime(2012, 6, 5, 9, 28, 51, 995);
            // 
            // cmbCloseWorker
            // 
            this.cmbCloseWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCloseWorker.Enabled = false;
            this.cmbCloseWorker.FormattingEnabled = true;
            this.cmbCloseWorker.Location = new System.Drawing.Point(84, 519);
            this.cmbCloseWorker.Name = "cmbCloseWorker";
            this.cmbCloseWorker.Size = new System.Drawing.Size(170, 21);
            this.cmbCloseWorker.TabIndex = 40;
            this.cmbCloseWorker.SelectedIndexChanged += new System.EventHandler(this.cmbCloseWorker_SelectedIndexChanged);
            // 
            // toolStripReport
            // 
            this.toolStripReport.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnReport,
            this.toolBtnCopyOrder});
            this.toolStripReport.Location = new System.Drawing.Point(0, 0);
            this.toolStripReport.Name = "toolStripReport";
            this.toolStripReport.Size = new System.Drawing.Size(252, 25);
            this.toolStripReport.TabIndex = 43;
            this.toolStripReport.Text = "toolStrip1";
            // 
            // toolBtnReport
            // 
            this.toolBtnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReport.Enabled = false;
            this.toolBtnReport.Image = global::JournalOrder.Properties.Resources.microsoftoffice2007excel_7581;
            this.toolBtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReport.Text = "Печать наряда";
            this.toolBtnReport.Click += new System.EventHandler(this.toolBtnReport_Click);
            // 
            // toolBtnCopyOrder
            // 
            this.toolBtnCopyOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnCopyOrder.Enabled = false;
            this.toolBtnCopyOrder.Image = global::JournalOrder.Properties.Resources.CopyBuffer;
            this.toolBtnCopyOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnCopyOrder.Name = "toolBtnCopyOrder";
            this.toolBtnCopyOrder.Size = new System.Drawing.Size(23, 22);
            this.toolBtnCopyOrder.Text = "Копировать наряд";
            this.toolBtnCopyOrder.Click += new System.EventHandler(this.toolBtnCopyOrder_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.labelOutputDate);
            this.splitContainer.Panel1.Controls.Add(this.panelExtension);
            this.splitContainer.Panel1.Controls.Add(this.txtOutputWorker);
            this.splitContainer.Panel1.Controls.Add(this.toolStripScheme);
            this.splitContainer.Panel1.Controls.Add(this.listBoxLinkScmObjects);
            this.splitContainer.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer.Panel1.Controls.Add(this.toolStripReport);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.txtNumOrder);
            this.splitContainer.Panel1.Controls.Add(this.labelDateBegin);
            this.splitContainer.Panel1.Controls.Add(this.labelDateEnd);
            this.splitContainer.Panel1.Controls.Add(this.labelInstruction);
            this.splitContainer.Panel1.Controls.Add(this.richTxtInstruction);
            this.splitContainer.Panel1.Controls.Add(this.label11);
            this.splitContainer.Panel1.Controls.Add(this.richTxtOtrherInstructions);
            this.splitContainer.Panel1.Controls.Add(this.labelOutput);
            this.splitContainer.Panel1.Controls.Add(this.dateTimePickerDateBegin);
            this.splitContainer.Panel1.Controls.Add(this.dateTimePickerDateEnd);
            this.splitContainer.Panel1.Controls.Add(this.buttonRegister);
            this.splitContainer.Panel1.Controls.Add(this.cmbOutputWorker);
            this.splitContainer.Panel1.Controls.Add(this.dateTimePickerDateOutput);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.labelDivision);
            this.splitContainer.Panel2.Controls.Add(this.cmbDivision);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.txtMakerWorker);
            this.splitContainer.Panel2.Controls.Add(this.txtWatchWorker);
            this.splitContainer.Panel2.Controls.Add(this.txtAcceptWorker);
            this.splitContainer.Panel2.Controls.Add(this.txtHeadWorker);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.dgvBrigade);
            this.splitContainer.Panel2.Controls.Add(this.buttonCloseOrder);
            this.splitContainer.Panel2.Controls.Add(this.labelSR);
            this.splitContainer.Panel2.Controls.Add(this.dateTimePickerClose);
            this.splitContainer.Panel2.Controls.Add(this.cmbSR);
            this.splitContainer.Panel2.Controls.Add(this.cmbCloseWorker);
            this.splitContainer.Panel2.Controls.Add(this.label6);
            this.splitContainer.Panel2.Controls.Add(this.buttonResolution);
            this.splitContainer.Panel2.Controls.Add(this.labelAccept);
            this.splitContainer.Panel2.Controls.Add(this.dateTimePickerResolution);
            this.splitContainer.Panel2.Controls.Add(this.label8);
            this.splitContainer.Panel2.Controls.Add(this.cmbWorkerResolution);
            this.splitContainer.Panel2.Controls.Add(this.labelMaker);
            this.splitContainer.Panel2.Controls.Add(this.dgvResolution);
            this.splitContainer.Panel2.Controls.Add(this.label10);
            this.splitContainer.Panel2.Controls.Add(this.dgvInstruction);
            this.splitContainer.Panel2.Controls.Add(this.cmbAcceptWorker);
            this.splitContainer.Panel2.Controls.Add(this.label13);
            this.splitContainer.Panel2.Controls.Add(this.cmbHeadWorker);
            this.splitContainer.Panel2.Controls.Add(this.cmbWatchWorker);
            this.splitContainer.Panel2.Controls.Add(this.cmbMakerWorker);
            this.splitContainer.Size = new System.Drawing.Size(876, 543);
            this.splitContainer.SplitterDistance = 252;
            this.splitContainer.TabIndex = 44;
            // 
            // labelOutputDate
            // 
            this.labelOutputDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOutputDate.AutoSize = true;
            this.labelOutputDate.Location = new System.Drawing.Point(13, 437);
            this.labelOutputDate.Name = "labelOutputDate";
            this.labelOutputDate.Size = new System.Drawing.Size(77, 13);
            this.labelOutputDate.TabIndex = 50;
            this.labelOutputDate.Text = "Дата и время";
            // 
            // panelExtension
            // 
            this.panelExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExtension.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelExtension.Controls.Add(this.buttonExtension);
            this.panelExtension.Controls.Add(this.dateTimePickerDateEndExt);
            this.panelExtension.Controls.Add(this.cmbExtWorker);
            this.panelExtension.Controls.Add(this.label3);
            this.panelExtension.Enabled = false;
            this.panelExtension.Location = new System.Drawing.Point(13, 457);
            this.panelExtension.Name = "panelExtension";
            this.panelExtension.Size = new System.Drawing.Size(233, 54);
            this.panelExtension.TabIndex = 49;
            // 
            // buttonExtension
            // 
            this.buttonExtension.Location = new System.Drawing.Point(6, 27);
            this.buttonExtension.Name = "buttonExtension";
            this.buttonExtension.Size = new System.Drawing.Size(75, 23);
            this.buttonExtension.TabIndex = 32;
            this.buttonExtension.Text = "Продлить";
            this.buttonExtension.UseVisualStyleBackColor = true;
            this.buttonExtension.Click += new System.EventHandler(this.buttonExtension_Click);
            // 
            // dateTimePickerDateEndExt
            // 
            this.dateTimePickerDateEndExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateEndExt.CustomFormat = "dd:MM:yyyy HH:mm";
            this.dateTimePickerDateEndExt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetOrder, "tJ_Order.dateEndExt", true));
            this.dateTimePickerDateEndExt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateEndExt.Location = new System.Drawing.Point(93, 30);
            this.dateTimePickerDateEndExt.Name = "dateTimePickerDateEndExt";
            this.dateTimePickerDateEndExt.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerDateEndExt.TabIndex = 31;
            this.dateTimePickerDateEndExt.Value = new System.DateTime(2012, 6, 5, 9, 28, 51, 995);
            // 
            // cmbExtWorker
            // 
            this.cmbExtWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExtWorker.AutoComplete = false;
            this.cmbExtWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbExtWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbExtWorker.AutoDropdown = false;
            this.cmbExtWorker.BackColorEven = System.Drawing.Color.White;
            this.cmbExtWorker.BackColorOdd = System.Drawing.Color.White;
            this.cmbExtWorker.ColumnNames = "";
            this.cmbExtWorker.ColumnWidthDefault = 75;
            this.cmbExtWorker.ColumnWidths = "0;120;0;30";
            this.cmbExtWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetOrder, "tJ_Order.extWorker", true));
            this.cmbExtWorker.DisplayMember = "id";
            this.cmbExtWorker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbExtWorker.FormattingEnabled = true;
            this.cmbExtWorker.LinkedColumnIndex = 0;
            this.cmbExtWorker.LinkedTextBox = null;
            this.cmbExtWorker.Location = new System.Drawing.Point(93, 3);
            this.cmbExtWorker.Name = "cmbExtWorker";
            this.cmbExtWorker.Size = new System.Drawing.Size(137, 21);
            this.cmbExtWorker.TabIndex = 30;
            this.cmbExtWorker.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Наряд продлил";
            // 
            // txtOutputWorker
            // 
            this.txtOutputWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputWorker.Location = new System.Drawing.Point(218, 405);
            this.txtOutputWorker.Name = "txtOutputWorker";
            this.txtOutputWorker.ReadOnly = true;
            this.txtOutputWorker.Size = new System.Drawing.Size(27, 20);
            this.txtOutputWorker.TabIndex = 48;
            // 
            // toolStripScheme
            // 
            this.toolStripScheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStripScheme.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripScheme.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripScheme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnLinkSchmObj,
            this.toolBtnDelSchmObj,
            this.toolBtnViewSChmObj});
            this.toolStripScheme.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripScheme.Location = new System.Drawing.Point(16, 331);
            this.toolStripScheme.Name = "toolStripScheme";
            this.toolStripScheme.Size = new System.Drawing.Size(24, 71);
            this.toolStripScheme.TabIndex = 46;
            this.toolStripScheme.Text = "toolStrip1";
            // 
            // toolBtnLinkSchmObj
            // 
            this.toolBtnLinkSchmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnLinkSchmObj.Image = global::JournalOrder.Properties.Resources.ElementAdd;
            this.toolBtnLinkSchmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnLinkSchmObj.Name = "toolBtnLinkSchmObj";
            this.toolBtnLinkSchmObj.Size = new System.Drawing.Size(22, 20);
            this.toolBtnLinkSchmObj.Text = "Привязать к схеме";
            this.toolBtnLinkSchmObj.Click += new System.EventHandler(this.toolBtnLinkSchmObj_Click);
            // 
            // toolBtnDelSchmObj
            // 
            this.toolBtnDelSchmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelSchmObj.Image = global::JournalOrder.Properties.Resources.ElementDel;
            this.toolBtnDelSchmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelSchmObj.Name = "toolBtnDelSchmObj";
            this.toolBtnDelSchmObj.Size = new System.Drawing.Size(22, 20);
            this.toolBtnDelSchmObj.Text = "Удалить";
            this.toolBtnDelSchmObj.Click += new System.EventHandler(this.toolBtnDelSchmObj_Click);
            // 
            // toolBtnViewSChmObj
            // 
            this.toolBtnViewSChmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnViewSChmObj.Enabled = false;
            this.toolBtnViewSChmObj.Image = global::JournalOrder.Properties.Resources.ElementInformation;
            this.toolBtnViewSChmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnViewSChmObj.Name = "toolBtnViewSChmObj";
            this.toolBtnViewSChmObj.Size = new System.Drawing.Size(22, 20);
            this.toolBtnViewSChmObj.Text = "Показать на схеме";
            this.toolBtnViewSChmObj.Click += new System.EventHandler(this.toolBtnViewSChmObj_Click);
            // 
            // listBoxLinkScmObjects
            // 
            this.listBoxLinkScmObjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLinkScmObjects.FormattingEnabled = true;
            this.listBoxLinkScmObjects.Location = new System.Drawing.Point(42, 333);
            this.listBoxLinkScmObjects.Name = "listBoxLinkScmObjects";
            this.listBoxLinkScmObjects.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxLinkScmObjects.Size = new System.Drawing.Size(203, 69);
            this.listBoxLinkScmObjects.Sorted = true;
            this.listBoxLinkScmObjects.TabIndex = 45;
            // 
            // labelDivision
            // 
            this.labelDivision.AutoSize = true;
            this.labelDivision.Location = new System.Drawing.Point(39, 43);
            this.labelDivision.Name = "labelDivision";
            this.labelDivision.Size = new System.Drawing.Size(87, 13);
            this.labelDivision.TabIndex = 50;
            this.labelDivision.Text = "Подразделение";
            // 
            // cmbDivision
            // 
            this.cmbDivision.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDivision.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetOrder, "tJ_Order.idDivision", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDivision.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(132, 40);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.ReadOnly = true;
            this.cmbDivision.ReadOnlyBackColor = System.Drawing.SystemColors.Window;
            this.cmbDivision.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDivision.Size = new System.Drawing.Size(158, 21);
            this.cmbDivision.TabIndex = 49;
            this.cmbDivision.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Дублер";
            // 
            // txtMakerWorker
            // 
            this.txtMakerWorker.Location = new System.Drawing.Point(263, 149);
            this.txtMakerWorker.Name = "txtMakerWorker";
            this.txtMakerWorker.ReadOnly = true;
            this.txtMakerWorker.Size = new System.Drawing.Size(27, 20);
            this.txtMakerWorker.TabIndex = 47;
            // 
            // txtWatchWorker
            // 
            this.txtWatchWorker.Location = new System.Drawing.Point(263, 121);
            this.txtWatchWorker.Name = "txtWatchWorker";
            this.txtWatchWorker.ReadOnly = true;
            this.txtWatchWorker.Size = new System.Drawing.Size(27, 20);
            this.txtWatchWorker.TabIndex = 46;
            // 
            // txtAcceptWorker
            // 
            this.txtAcceptWorker.Location = new System.Drawing.Point(263, 92);
            this.txtAcceptWorker.Name = "txtAcceptWorker";
            this.txtAcceptWorker.ReadOnly = true;
            this.txtAcceptWorker.Size = new System.Drawing.Size(27, 20);
            this.txtAcceptWorker.TabIndex = 45;
            // 
            // txtHeadWorker
            // 
            this.txtHeadWorker.Location = new System.Drawing.Point(263, 64);
            this.txtHeadWorker.Name = "txtHeadWorker";
            this.txtHeadWorker.ReadOnly = true;
            this.txtHeadWorker.Size = new System.Drawing.Size(27, 20);
            this.txtHeadWorker.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Разрешение на подготовку рабочих мест и на допуск к выполнению работ";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idOrderDgvColumnInstruction
            // 
            this.idOrderDgvColumnInstruction.DataPropertyName = "idOrder";
            this.idOrderDgvColumnInstruction.HeaderText = "idOrder";
            this.idOrderDgvColumnInstruction.Name = "idOrderDgvColumnInstruction";
            this.idOrderDgvColumnInstruction.Visible = false;
            // 
            // nameObjDataGridViewTextBoxColumn
            // 
            this.nameObjDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameObjDataGridViewTextBoxColumn.DataPropertyName = "NameObj";
            this.nameObjDataGridViewTextBoxColumn.FillWeight = 35F;
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "Наименование электроустановок";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            this.nameObjDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // instructionDataGridViewTextBoxColumn
            // 
            this.instructionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.instructionDataGridViewTextBoxColumn.DataPropertyName = "Instruction";
            this.instructionDataGridViewTextBoxColumn.FillWeight = 50F;
            this.instructionDataGridViewTextBoxColumn.HeaderText = "Что должно быть отключено и где заземлено";
            this.instructionDataGridViewTextBoxColumn.Name = "instructionDataGridViewTextBoxColumn";
            this.instructionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // recnumDataGridViewTextBoxColumn
            // 
            this.recnumDataGridViewTextBoxColumn.DataPropertyName = "rec_num";
            this.recnumDataGridViewTextBoxColumn.HeaderText = "rec_num";
            this.recnumDataGridViewTextBoxColumn.Name = "recnumDataGridViewTextBoxColumn";
            this.recnumDataGridViewTextBoxColumn.Visible = false;
            // 
            // IsolatedDataGridViewTextBoxColumn
            // 
            this.IsolatedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IsolatedDataGridViewTextBoxColumn.DataPropertyName = "Isolated";
            this.IsolatedDataGridViewTextBoxColumn.FillWeight = 50F;
            this.IsolatedDataGridViewTextBoxColumn.HeaderText = "Что должно быть изолировано (ограждено)";
            this.IsolatedDataGridViewTextBoxColumn.Name = "IsolatedDataGridViewTextBoxColumn";
            this.IsolatedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormJournalOrderAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 543);
            this.Controls.Add(this.splitContainer);
            this.KeyPreview = true;
            this.Name = "FormJournalOrderAddEdit";
            this.Text = "FormJournalOrderAddEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJournalOrderAddEdit_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJournalOrderAddEdit_FormClosed);
            this.Load += new System.EventHandler(this.FormJournalOrderAddEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormJournalOrderAddEdit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrigade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstruction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResolution)).EndInit();
            this.toolStripReport.ResumeLayout(false);
            this.toolStripReport.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            this.splitContainer.ResumeLayout(false);
            this.panelExtension.ResumeLayout(false);
            this.panelExtension.PerformLayout();
            this.toolStripScheme.ResumeLayout(false);
            this.toolStripScheme.PerformLayout();
            this.ResumeLayout(false);

        }



        private Label label1;
        private TextBox txtNumOrder;
        private Label labelDateBegin;
        private Label labelDateEnd;
        private Label labelInstruction;
        private RichTextBox richTxtInstruction;
        private Label labelSR;
        private ComboBox cmbSR;
        private Label label6;
        private Label labelAccept;
        private Label label8;
        private Label labelMaker;
        private Label label10;
        private Label label11;
        private RichTextBox richTxtOtrherInstructions;
        private Label labelOutput;
        private ComboBox cmbAcceptWorker;
        private DataSet.DataSetOrder dataSetOrder;
        private NullableDateTimePicker dateTimePickerDateBegin;
        private NullableDateTimePicker dateTimePickerDateEnd;
        private ComboBox cmbHeadWorker;
        private ComboBox cmbWatchWorker;
        private ComboBox cmbMakerWorker;
        private ComboBox cmbOutputWorker;
        private NullableDateTimePicker dateTimePickerDateOutput;
        private Button buttonSave;
        private Button buttonRegister;
        private DataGridView dgvBrigade;
        private Label label13;
        private DataGridView dgvInstruction;
        private DataGridView dgvResolution;
        private ComboBox cmbWorkerResolution;
        private NullableDateTimePicker dateTimePickerResolution;
        private Button buttonResolution;
        private Button buttonCloseOrder;
        private NullableDateTimePicker dateTimePickerClose;
        private ComboBox cmbCloseWorker;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn1;
        private DataGridViewComboBoxColumn workerResolutionColumn;
        private DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private ToolStrip toolStripReport;
        private ToolStripButton toolBtnReport;
        private SplitContainer splitContainer;
        private Label label2;
        private ToolStrip toolStripScheme;
        private ToolStripButton toolBtnLinkSchmObj;
        private ToolStripButton toolBtnDelSchmObj;
        private ToolStripButton toolBtnViewSChmObj;
        private ListBox listBoxLinkScmObjects;
        private ToolStripButton toolBtnCopyOrder;
        private TextBox txtHeadWorker;
        private TextBox txtOutputWorker;
        private TextBox txtMakerWorker;
        private TextBox txtWatchWorker;
        private TextBox txtAcceptWorker;
        private Panel panelExtension;
        private Button buttonExtension;
        private NullableDateTimePicker dateTimePickerDateEndExt;
        private MultiColumnComboBox cmbExtWorker;
        private Label label3;
        private Label labelOutputDate;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn brigadeWorkerColumn;
        private DataGridViewTextBoxColumn GroupElectricalTxtColumn;
        private DataGridViewComboBoxColumn idJobTitleDgvColumn;
        private DataGridViewCheckBoxColumn isUnderstudyDgvColumn;
        private Label label4;
        private Label labelDivision;
        private ComboBoxReadOnly cmbDivision;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idOrderDgvColumnInstruction;
        private DataGridViewTextBoxColumn nameObjDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn instructionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recnumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IsolatedDataGridViewTextBoxColumn;
    }
}