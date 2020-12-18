namespace Prv.Forms.Exchange
{
    partial class FormKOinUE
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.labelDateBegin = new System.Windows.Forms.Label();
            this.groupBoxTypeDoc = new System.Windows.Forms.GroupBox();
            this.cmbTypeDoc = new System.Windows.Forms.ComboBox();
            this.dsDocAct = new Prv.DataSets.DataSetPrv();
            this.checkBoxRaions = new System.Windows.Forms.CheckBox();
            this.groupBoxRaion = new System.Windows.Forms.GroupBox();
            this.checkedListBoxRaion = new System.Windows.Forms.CheckedListBox();
            this.dTPEnd = new System.Windows.Forms.DateTimePicker();
            this.dTPBeg = new System.Windows.Forms.DateTimePicker();
            this.buttonExec = new System.Windows.Forms.Button();
            this.groupBoxWait = new System.Windows.Forms.GroupBox();
            this.progressBarEndLess = new ControlsLbr.ProgressBarEndLess();
            this.bwKOinUE = new System.ComponentModel.BackgroundWorker();
            this.bsKOinUE = new System.Windows.Forms.BindingSource(this.components);
            this.dsExch = new Prv.DataSets.DataSetExchange();
            this.dataGridViewExcelFilterKOinUE = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrObjIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housePrefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countFloorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPorchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countApartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherTypeObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Digit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IND1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IND2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IND3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsDirectory = new Prv.DataSets.DataSetPrv();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.bwExp = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBoxTypeDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDocAct)).BeginInit();
            this.groupBoxRaion.SuspendLayout();
            this.groupBoxWait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsKOinUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelFilterKOinUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDirectory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelDateEnd);
            this.groupBox1.Controls.Add(this.labelDateBegin);
            this.groupBox1.Controls.Add(this.groupBoxTypeDoc);
            this.groupBox1.Controls.Add(this.checkBoxRaions);
            this.groupBox1.Controls.Add(this.groupBoxRaion);
            this.groupBox1.Controls.Add(this.dTPEnd);
            this.groupBox1.Controls.Add(this.dTPBeg);
            this.groupBox1.Location = new System.Drawing.Point(660, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие выбора";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(9, 61);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(92, 13);
            this.labelDateEnd.TabIndex = 32;
            this.labelDateEnd.Text = "Дата окончания:";
            // 
            // labelDateBegin
            // 
            this.labelDateBegin.AutoSize = true;
            this.labelDateBegin.Location = new System.Drawing.Point(9, 20);
            this.labelDateBegin.Name = "labelDateBegin";
            this.labelDateBegin.Size = new System.Drawing.Size(74, 13);
            this.labelDateBegin.TabIndex = 31;
            this.labelDateBegin.Text = "Дата начала:";
            // 
            // groupBoxTypeDoc
            // 
            this.groupBoxTypeDoc.Controls.Add(this.cmbTypeDoc);
            this.groupBoxTypeDoc.Location = new System.Drawing.Point(7, 114);
            this.groupBoxTypeDoc.Name = "groupBoxTypeDoc";
            this.groupBoxTypeDoc.Size = new System.Drawing.Size(156, 45);
            this.groupBoxTypeDoc.TabIndex = 30;
            this.groupBoxTypeDoc.TabStop = false;
            this.groupBoxTypeDoc.Text = "Вид документа";
            // 
            // cmbTypeDoc
            // 
            this.cmbTypeDoc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsDocAct, "tDocAct.idDocType", true));
            this.cmbTypeDoc.DataSource = this.dsDocAct;
            this.cmbTypeDoc.DisplayMember = "tR_Classifier.Name";
            this.cmbTypeDoc.FormattingEnabled = true;
            this.cmbTypeDoc.Location = new System.Drawing.Point(7, 18);
            this.cmbTypeDoc.Name = "cmbTypeDoc";
            this.cmbTypeDoc.Size = new System.Drawing.Size(143, 21);
            this.cmbTypeDoc.TabIndex = 29;
            this.cmbTypeDoc.ValueMember = "tR_Classifier.Id";
            // 
            // dsDocAct
            // 
            this.dsDocAct.DataSetName = "DataSetPrv";
            this.dsDocAct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxRaions
            // 
            this.checkBoxRaions.AutoSize = true;
            this.checkBoxRaions.Location = new System.Drawing.Point(13, 165);
            this.checkBoxRaions.Name = "checkBoxRaions";
            this.checkBoxRaions.Size = new System.Drawing.Size(117, 17);
            this.checkBoxRaions.TabIndex = 28;
            this.checkBoxRaions.Text = "Выделять районы";
            this.checkBoxRaions.UseVisualStyleBackColor = true;
            this.checkBoxRaions.CheckedChanged += new System.EventHandler(this.checkBoxRaions_CheckedChanged);
            // 
            // groupBoxRaion
            // 
            this.groupBoxRaion.Controls.Add(this.checkedListBoxRaion);
            this.groupBoxRaion.Location = new System.Drawing.Point(7, 188);
            this.groupBoxRaion.Name = "groupBoxRaion";
            this.groupBoxRaion.Size = new System.Drawing.Size(155, 135);
            this.groupBoxRaion.TabIndex = 27;
            this.groupBoxRaion.TabStop = false;
            this.groupBoxRaion.Text = "Районы";
            // 
            // checkedListBoxRaion
            // 
            this.checkedListBoxRaion.FormattingEnabled = true;
            this.checkedListBoxRaion.Location = new System.Drawing.Point(6, 15);
            this.checkedListBoxRaion.Name = "checkedListBoxRaion";
            this.checkedListBoxRaion.Size = new System.Drawing.Size(143, 109);
            this.checkedListBoxRaion.TabIndex = 26;
            // 
            // dTPEnd
            // 
            this.dTPEnd.Location = new System.Drawing.Point(7, 77);
            this.dTPEnd.Name = "dTPEnd";
            this.dTPEnd.Size = new System.Drawing.Size(156, 20);
            this.dTPEnd.TabIndex = 1;
            // 
            // dTPBeg
            // 
            this.dTPBeg.Location = new System.Drawing.Point(7, 37);
            this.dTPBeg.Name = "dTPBeg";
            this.dTPBeg.Size = new System.Drawing.Size(156, 20);
            this.dTPBeg.TabIndex = 0;
            // 
            // buttonExec
            // 
            this.buttonExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExec.Location = new System.Drawing.Point(660, 496);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(169, 23);
            this.buttonExec.TabIndex = 2;
            this.buttonExec.Text = "Сформировать";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // groupBoxWait
            // 
            this.groupBoxWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWait.Controls.Add(this.progressBarEndLess);
            this.groupBoxWait.Location = new System.Drawing.Point(660, 452);
            this.groupBoxWait.Name = "groupBoxWait";
            this.groupBoxWait.Size = new System.Drawing.Size(169, 35);
            this.groupBoxWait.TabIndex = 24;
            this.groupBoxWait.TabStop = false;
            this.groupBoxWait.Text = "Подождите...";
            // 
            // progressBarEndLess
            // 
            this.progressBarEndLess.AutoProgressSpeed = 200;
            this.progressBarEndLess.IndicatorColor = System.Drawing.Color.LightGreen;
            this.progressBarEndLess.Location = new System.Drawing.Point(4, 16);
            this.progressBarEndLess.Name = "progressBarEndLess";
            this.progressBarEndLess.NormalImage = null;
            this.progressBarEndLess.PointImage = null;
            this.progressBarEndLess.Position = 0;
            this.progressBarEndLess.ProgressBoxStyle = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessBoxStyleConstants.SolidSameSize;
            this.progressBarEndLess.ProgressStyle = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessStyleConstants.LeftToRight;
            this.progressBarEndLess.ProgressType = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessTypeConstants.GraphicType;
            this.progressBarEndLess.ShowBorder = false;
            this.progressBarEndLess.Size = new System.Drawing.Size(159, 13);
            this.progressBarEndLess.TabIndex = 21;
            // 
            // bwKOinUE
            // 
            this.bwKOinUE.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwKOinUE_DoWork);
            this.bwKOinUE.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwKOinUE_RunWorkerCompleted);
            // 
            // bsKOinUE
            // 
            this.bsKOinUE.DataMember = "TableKOinUE";
            this.bsKOinUE.DataSource = this.dsExch;
            // 
            // dsExch
            // 
            this.dsExch.DataSetName = "DataSetExchange";
            this.dsExch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewExcelFilterKOinUE
            // 
            this.dataGridViewExcelFilterKOinUE.AllowUserToAddRows = false;
            this.dataGridViewExcelFilterKOinUE.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilterKOinUE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewExcelFilterKOinUE.AutoGenerateColumns = false;
            this.dataGridViewExcelFilterKOinUE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcelFilterKOinUE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeAbonentDataGridViewTextBoxColumn,
            this.NomPoint,
            this.addressDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.visNameDataGridViewTextBoxColumn,
            this.codeOwnerDataGridViewTextBoxColumn,
            this.kladrObjIdDataGridViewTextBoxColumn,
            this.raionDataGridViewTextBoxColumn,
            this.codeStreetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.housePrefixDataGridViewTextBoxColumn,
            this.apartmentDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn,
            this.idMarkDataGridViewTextBoxColumn,
            this.countFloorDataGridViewTextBoxColumn,
            this.countPorchDataGridViewTextBoxColumn,
            this.countApartmentDataGridViewTextBoxColumn,
            this.typeObjDataGridViewTextBoxColumn,
            this.otherTypeObjDataGridViewTextBoxColumn,
            this.dateActDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.Number,
            this.Digit,
            this.IND1,
            this.IND2,
            this.IND3});
            this.dataGridViewExcelFilterKOinUE.DataSource = this.bsKOinUE;
            this.dataGridViewExcelFilterKOinUE.Location = new System.Drawing.Point(9, 9);
            this.dataGridViewExcelFilterKOinUE.Name = "dataGridViewExcelFilterKOinUE";
            this.dataGridViewExcelFilterKOinUE.ReadOnly = true;
            this.dataGridViewExcelFilterKOinUE.RowHeadersWidth = 21;
            this.dataGridViewExcelFilterKOinUE.Size = new System.Drawing.Size(645, 478);
            this.dataGridViewExcelFilterKOinUE.TabIndex = 25;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Лицевой счет";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NomPoint
            // 
            this.NomPoint.DataPropertyName = "NomPoint";
            this.NomPoint.HeaderText = "№ т.у.";
            this.NomPoint.Name = "NomPoint";
            this.NomPoint.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "Ф.И.О.";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Width = 150;
            // 
            // visNameDataGridViewTextBoxColumn
            // 
            this.visNameDataGridViewTextBoxColumn.DataPropertyName = "VisName";
            this.visNameDataGridViewTextBoxColumn.HeaderText = "VisName";
            this.visNameDataGridViewTextBoxColumn.Name = "visNameDataGridViewTextBoxColumn";
            this.visNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.visNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeOwnerDataGridViewTextBoxColumn
            // 
            this.codeOwnerDataGridViewTextBoxColumn.DataPropertyName = "CodeOwner";
            this.codeOwnerDataGridViewTextBoxColumn.HeaderText = "CodeOwner";
            this.codeOwnerDataGridViewTextBoxColumn.Name = "codeOwnerDataGridViewTextBoxColumn";
            this.codeOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeOwnerDataGridViewTextBoxColumn.Visible = false;
            // 
            // kladrObjIdDataGridViewTextBoxColumn
            // 
            this.kladrObjIdDataGridViewTextBoxColumn.DataPropertyName = "KladrObjId";
            this.kladrObjIdDataGridViewTextBoxColumn.HeaderText = "KladrObjId";
            this.kladrObjIdDataGridViewTextBoxColumn.Name = "kladrObjIdDataGridViewTextBoxColumn";
            this.kladrObjIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.kladrObjIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // raionDataGridViewTextBoxColumn
            // 
            this.raionDataGridViewTextBoxColumn.DataPropertyName = "Raion";
            this.raionDataGridViewTextBoxColumn.HeaderText = "Raion";
            this.raionDataGridViewTextBoxColumn.Name = "raionDataGridViewTextBoxColumn";
            this.raionDataGridViewTextBoxColumn.ReadOnly = true;
            this.raionDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeStreetDataGridViewTextBoxColumn
            // 
            this.codeStreetDataGridViewTextBoxColumn.DataPropertyName = "CodeStreet";
            this.codeStreetDataGridViewTextBoxColumn.HeaderText = "CodeStreet";
            this.codeStreetDataGridViewTextBoxColumn.Name = "codeStreetDataGridViewTextBoxColumn";
            this.codeStreetDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeStreetDataGridViewTextBoxColumn.Visible = false;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "House";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            this.houseDataGridViewTextBoxColumn.Visible = false;
            // 
            // housePrefixDataGridViewTextBoxColumn
            // 
            this.housePrefixDataGridViewTextBoxColumn.DataPropertyName = "HousePrefix";
            this.housePrefixDataGridViewTextBoxColumn.HeaderText = "HousePrefix";
            this.housePrefixDataGridViewTextBoxColumn.Name = "housePrefixDataGridViewTextBoxColumn";
            this.housePrefixDataGridViewTextBoxColumn.ReadOnly = true;
            this.housePrefixDataGridViewTextBoxColumn.Visible = false;
            // 
            // apartmentDataGridViewTextBoxColumn
            // 
            this.apartmentDataGridViewTextBoxColumn.DataPropertyName = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.HeaderText = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.Name = "apartmentDataGridViewTextBoxColumn";
            this.apartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.apartmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            this.markDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMarkDataGridViewTextBoxColumn
            // 
            this.idMarkDataGridViewTextBoxColumn.DataPropertyName = "idMark";
            this.idMarkDataGridViewTextBoxColumn.HeaderText = "idMark";
            this.idMarkDataGridViewTextBoxColumn.Name = "idMarkDataGridViewTextBoxColumn";
            this.idMarkDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMarkDataGridViewTextBoxColumn.Visible = false;
            // 
            // countFloorDataGridViewTextBoxColumn
            // 
            this.countFloorDataGridViewTextBoxColumn.DataPropertyName = "CountFloor";
            this.countFloorDataGridViewTextBoxColumn.HeaderText = "CountFloor";
            this.countFloorDataGridViewTextBoxColumn.Name = "countFloorDataGridViewTextBoxColumn";
            this.countFloorDataGridViewTextBoxColumn.ReadOnly = true;
            this.countFloorDataGridViewTextBoxColumn.Visible = false;
            // 
            // countPorchDataGridViewTextBoxColumn
            // 
            this.countPorchDataGridViewTextBoxColumn.DataPropertyName = "CountPorch";
            this.countPorchDataGridViewTextBoxColumn.HeaderText = "CountPorch";
            this.countPorchDataGridViewTextBoxColumn.Name = "countPorchDataGridViewTextBoxColumn";
            this.countPorchDataGridViewTextBoxColumn.ReadOnly = true;
            this.countPorchDataGridViewTextBoxColumn.Visible = false;
            // 
            // countApartmentDataGridViewTextBoxColumn
            // 
            this.countApartmentDataGridViewTextBoxColumn.DataPropertyName = "CountApartment";
            this.countApartmentDataGridViewTextBoxColumn.HeaderText = "CountApartment";
            this.countApartmentDataGridViewTextBoxColumn.Name = "countApartmentDataGridViewTextBoxColumn";
            this.countApartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.countApartmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeObjDataGridViewTextBoxColumn
            // 
            this.typeObjDataGridViewTextBoxColumn.DataPropertyName = "TypeObj";
            this.typeObjDataGridViewTextBoxColumn.HeaderText = "TypeObj";
            this.typeObjDataGridViewTextBoxColumn.Name = "typeObjDataGridViewTextBoxColumn";
            this.typeObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // otherTypeObjDataGridViewTextBoxColumn
            // 
            this.otherTypeObjDataGridViewTextBoxColumn.DataPropertyName = "OtherTypeObj";
            this.otherTypeObjDataGridViewTextBoxColumn.HeaderText = "OtherTypeObj";
            this.otherTypeObjDataGridViewTextBoxColumn.Name = "otherTypeObjDataGridViewTextBoxColumn";
            this.otherTypeObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.otherTypeObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateActDataGridViewTextBoxColumn
            // 
            this.dateActDataGridViewTextBoxColumn.DataPropertyName = "DateAct";
            this.dateActDataGridViewTextBoxColumn.HeaderText = "Дата снятия";
            this.dateActDataGridViewTextBoxColumn.Name = "dateActDataGridViewTextBoxColumn";
            this.dateActDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "Дата внесения";
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            this.dateInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Digit
            // 
            this.Digit.DataPropertyName = "Digit";
            this.Digit.HeaderText = "Разрядность";
            this.Digit.Name = "Digit";
            this.Digit.ReadOnly = true;
            // 
            // IND1
            // 
            this.IND1.DataPropertyName = "IND1";
            this.IND1.HeaderText = "День";
            this.IND1.Name = "IND1";
            this.IND1.ReadOnly = true;
            // 
            // IND2
            // 
            this.IND2.DataPropertyName = "IND2";
            this.IND2.HeaderText = "Ночь";
            this.IND2.Name = "IND2";
            this.IND2.ReadOnly = true;
            // 
            // IND3
            // 
            this.IND3.DataPropertyName = "IND3";
            this.IND3.HeaderText = "Полупик";
            this.IND3.Name = "IND3";
            this.IND3.ReadOnly = true;
            // 
            // dsDirectory
            // 
            this.dsDirectory.DataSetName = "DataSetPrv";
            this.dsDirectory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFile.Location = new System.Drawing.Point(10, 496);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ReadOnly = true;
            this.textBoxFile.Size = new System.Drawing.Size(431, 20);
            this.textBoxFile.TabIndex = 26;
            // 
            // buttonFile
            // 
            this.buttonFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFile.AutoEllipsis = true;
            this.buttonFile.Location = new System.Drawing.Point(447, 496);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(20, 20);
            this.buttonFile.TabIndex = 27;
            this.buttonFile.Text = "...";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // saveFileDialogExport
            // 
            this.saveFileDialogExport.Filter = "dbf files (*.dbf)|*.dbf";
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(473, 496);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(92, 23);
            this.buttonExport.TabIndex = 28;
            this.buttonExport.Text = "Выгрузка в dbf";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonEmail
            // 
            this.buttonEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEmail.Location = new System.Drawing.Point(571, 496);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(83, 23);
            this.buttonEmail.TabIndex = 33;
            this.buttonEmail.Text = "Почта";
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // bwExp
            // 
            this.bwExp.WorkerReportsProgress = true;
            this.bwExp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwExp_DoWork);
            this.bwExp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwExp_RunWorkerCompleted);
            // 
            // FormKOinUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 526);
            this.Controls.Add(this.buttonEmail);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.dataGridViewExcelFilterKOinUE);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.groupBoxWait);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKOinUE";
            this.Text = "Экспорт документов";
            this.Load += new System.EventHandler(this.FormKOinUE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTypeDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDocAct)).EndInit();
            this.groupBoxRaion.ResumeLayout(false);
            this.groupBoxWait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsKOinUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelFilterKOinUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDirectory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.DateTimePicker dTPEnd;
        private System.Windows.Forms.DateTimePicker dTPBeg;
        private Prv.DataSets.DataSetExchange dsExch;
        private System.Windows.Forms.BindingSource bsKOinUE;
        private System.Windows.Forms.GroupBox groupBoxWait;
        private ControlsLbr.ProgressBarEndLess progressBarEndLess;
        private System.ComponentModel.BackgroundWorker bwKOinUE;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilterKOinUE;
        private System.Windows.Forms.CheckedListBox checkedListBoxRaion;
        private System.Windows.Forms.CheckBox checkBoxRaions;
        private System.Windows.Forms.GroupBox groupBoxRaion;
        private Prv.DataSets.DataSetPrv dsDirectory;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonEmail;
        private System.ComponentModel.BackgroundWorker bwExp;
        private System.Windows.Forms.ComboBox cmbTypeDoc;
        private Prv.DataSets.DataSetPrv dsDocAct;
        private System.Windows.Forms.GroupBox groupBoxTypeDoc;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Label labelDateBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kladrObjIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housePrefixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countFloorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPorchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countApartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherTypeObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Digit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IND1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IND2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IND3;

    }
}