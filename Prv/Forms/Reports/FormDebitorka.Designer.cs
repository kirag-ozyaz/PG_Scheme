namespace Prv.Forms.Reports
{
    partial class FormDebitorka
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
            this.bindingSourceRepAll = new System.Windows.Forms.BindingSource(this.components);
            this.dsRep = new Prv.DataSets.DataSetRep();
            this.checkedListBoxRaion = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxPunkts = new System.Windows.Forms.CheckedListBox();
            this.groupBoxHouses = new System.Windows.Forms.GroupBox();
            this.txtHousesRange2 = new System.Windows.Forms.TextBox();
            this.labelPO = new System.Windows.Forms.Label();
            this.txtHousesRange1 = new System.Windows.Forms.TextBox();
            this.labelS = new System.Windows.Forms.Label();
            this.txtHousesOne = new System.Windows.Forms.TextBox();
            this.rbHousesRange = new System.Windows.Forms.RadioButton();
            this.rbHousesOne = new System.Windows.Forms.RadioButton();
            this.rbHousesAll = new System.Windows.Forms.RadioButton();
            this.groupBoxFlats = new System.Windows.Forms.GroupBox();
            this.txtFlatsRange2 = new System.Windows.Forms.TextBox();
            this.labelFlatsPO = new System.Windows.Forms.Label();
            this.txtFlatsRange1 = new System.Windows.Forms.TextBox();
            this.labelFlatsS = new System.Windows.Forms.Label();
            this.txtFlatsOne = new System.Windows.Forms.TextBox();
            this.rbFlatsRange = new System.Windows.Forms.RadioButton();
            this.rbFlatsOne = new System.Windows.Forms.RadioButton();
            this.rbFlatsAll = new System.Windows.Forms.RadioButton();
            this.labelStreet = new System.Windows.Forms.Label();
            this.comboBoxStreet = new System.Windows.Forms.ComboBox();
            this.dsStreet = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.checkBoxDelAdress = new System.Windows.Forms.CheckBox();
            this.dataGridViewAdress = new System.Windows.Forms.DataGridView();
            this.colHousesN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHousesDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colHousesStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHousesDom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHousesFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHousesCodeStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddAdress = new System.Windows.Forms.Button();
            this.buttonDelAdress = new System.Windows.Forms.Button();
            this.tabControlVertical1 = new ControlsLbr.TabControlVertical();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDebCalc = new System.Windows.Forms.Button();
            this.groupBoxWait = new System.Windows.Forms.GroupBox();
            this.progressBarEndLess = new ControlsLbr.ProgressBarEndLess();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.groupBoxNO = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxLimit2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLimit1 = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxTR = new System.Windows.Forms.CheckBox();
            this.до = new System.Windows.Forms.Label();
            this.label_OT = new System.Windows.Forms.Label();
            this.checkBoxNo = new System.Windows.Forms.CheckBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.dataGridViewExcelFilterDabAll = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itogU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsDirectory = new Prv.DataSets.DataSetPrv();
            this.reportViewerDebGraf = new Microsoft.Reporting.WinForms.ReportViewer();
            this.backgroundWorkerDebAll = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRepAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            this.groupBoxHouses.SuspendLayout();
            this.groupBoxFlats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdress)).BeginInit();
            this.tabControlVertical1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxWait.SuspendLayout();
            this.groupBoxNO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelFilterDabAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDirectory)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceRepAll
            // 
            this.bindingSourceRepAll.DataMember = "vPrv_RepDebitorkaAll";
            this.bindingSourceRepAll.DataSource = this.dsRep;
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "DataSetRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkedListBoxRaion
            // 
            this.checkedListBoxRaion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxRaion.FormattingEnabled = true;
            this.checkedListBoxRaion.Location = new System.Drawing.Point(3, 6);
            this.checkedListBoxRaion.Name = "checkedListBoxRaion";
            this.checkedListBoxRaion.Size = new System.Drawing.Size(124, 199);
            this.checkedListBoxRaion.TabIndex = 0;
            // 
            // checkedListBoxPunkts
            // 
            this.checkedListBoxPunkts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxPunkts.FormattingEnabled = true;
            this.checkedListBoxPunkts.Location = new System.Drawing.Point(133, 6);
            this.checkedListBoxPunkts.Name = "checkedListBoxPunkts";
            this.checkedListBoxPunkts.Size = new System.Drawing.Size(119, 199);
            this.checkedListBoxPunkts.TabIndex = 1;
            this.checkedListBoxPunkts.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxPunkts_SelectedIndexChanged);
            // 
            // groupBoxHouses
            // 
            this.groupBoxHouses.Controls.Add(this.txtHousesRange2);
            this.groupBoxHouses.Controls.Add(this.labelPO);
            this.groupBoxHouses.Controls.Add(this.txtHousesRange1);
            this.groupBoxHouses.Controls.Add(this.labelS);
            this.groupBoxHouses.Controls.Add(this.txtHousesOne);
            this.groupBoxHouses.Controls.Add(this.rbHousesRange);
            this.groupBoxHouses.Controls.Add(this.rbHousesOne);
            this.groupBoxHouses.Controls.Add(this.rbHousesAll);
            this.groupBoxHouses.Location = new System.Drawing.Point(258, 0);
            this.groupBoxHouses.Name = "groupBoxHouses";
            this.groupBoxHouses.Size = new System.Drawing.Size(169, 83);
            this.groupBoxHouses.TabIndex = 3;
            this.groupBoxHouses.TabStop = false;
            this.groupBoxHouses.Text = "Дома";
            // 
            // txtHousesRange2
            // 
            this.txtHousesRange2.Enabled = false;
            this.txtHousesRange2.Location = new System.Drawing.Point(135, 58);
            this.txtHousesRange2.Name = "txtHousesRange2";
            this.txtHousesRange2.Size = new System.Drawing.Size(29, 20);
            this.txtHousesRange2.TabIndex = 7;
            // 
            // labelPO
            // 
            this.labelPO.AutoSize = true;
            this.labelPO.Location = new System.Drawing.Point(119, 62);
            this.labelPO.Name = "labelPO";
            this.labelPO.Size = new System.Drawing.Size(19, 13);
            this.labelPO.TabIndex = 6;
            this.labelPO.Text = "по";
            // 
            // txtHousesRange1
            // 
            this.txtHousesRange1.Enabled = false;
            this.txtHousesRange1.Location = new System.Drawing.Point(89, 58);
            this.txtHousesRange1.Name = "txtHousesRange1";
            this.txtHousesRange1.Size = new System.Drawing.Size(30, 20);
            this.txtHousesRange1.TabIndex = 5;
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(76, 62);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(13, 13);
            this.labelS.TabIndex = 4;
            this.labelS.Text = "с";
            // 
            // txtHousesOne
            // 
            this.txtHousesOne.Enabled = false;
            this.txtHousesOne.Location = new System.Drawing.Point(89, 36);
            this.txtHousesOne.Name = "txtHousesOne";
            this.txtHousesOne.Size = new System.Drawing.Size(75, 20);
            this.txtHousesOne.TabIndex = 3;
            // 
            // rbHousesRange
            // 
            this.rbHousesRange.AutoSize = true;
            this.rbHousesRange.Location = new System.Drawing.Point(6, 60);
            this.rbHousesRange.Name = "rbHousesRange";
            this.rbHousesRange.Size = new System.Drawing.Size(76, 17);
            this.rbHousesRange.TabIndex = 2;
            this.rbHousesRange.Text = "Диапазон";
            this.rbHousesRange.UseVisualStyleBackColor = true;
            this.rbHousesRange.CheckedChanged += new System.EventHandler(this.rbHousesRange_CheckedChanged);
            // 
            // rbHousesOne
            // 
            this.rbHousesOne.AutoSize = true;
            this.rbHousesOne.Location = new System.Drawing.Point(6, 37);
            this.rbHousesOne.Name = "rbHousesOne";
            this.rbHousesOne.Size = new System.Drawing.Size(74, 17);
            this.rbHousesOne.TabIndex = 1;
            this.rbHousesOne.Text = "Один дом";
            this.rbHousesOne.UseVisualStyleBackColor = true;
            this.rbHousesOne.CheckedChanged += new System.EventHandler(this.rbHousesOne_CheckedChanged);
            // 
            // rbHousesAll
            // 
            this.rbHousesAll.AutoSize = true;
            this.rbHousesAll.Checked = true;
            this.rbHousesAll.Location = new System.Drawing.Point(6, 14);
            this.rbHousesAll.Name = "rbHousesAll";
            this.rbHousesAll.Size = new System.Drawing.Size(73, 17);
            this.rbHousesAll.TabIndex = 0;
            this.rbHousesAll.TabStop = true;
            this.rbHousesAll.Text = "Все дома";
            this.rbHousesAll.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlats
            // 
            this.groupBoxFlats.Controls.Add(this.txtFlatsRange2);
            this.groupBoxFlats.Controls.Add(this.labelFlatsPO);
            this.groupBoxFlats.Controls.Add(this.txtFlatsRange1);
            this.groupBoxFlats.Controls.Add(this.labelFlatsS);
            this.groupBoxFlats.Controls.Add(this.txtFlatsOne);
            this.groupBoxFlats.Controls.Add(this.rbFlatsRange);
            this.groupBoxFlats.Controls.Add(this.rbFlatsOne);
            this.groupBoxFlats.Controls.Add(this.rbFlatsAll);
            this.groupBoxFlats.Location = new System.Drawing.Point(258, 87);
            this.groupBoxFlats.Name = "groupBoxFlats";
            this.groupBoxFlats.Size = new System.Drawing.Size(169, 85);
            this.groupBoxFlats.TabIndex = 9;
            this.groupBoxFlats.TabStop = false;
            this.groupBoxFlats.Text = "Квартиры";
            // 
            // txtFlatsRange2
            // 
            this.txtFlatsRange2.Enabled = false;
            this.txtFlatsRange2.Location = new System.Drawing.Point(135, 60);
            this.txtFlatsRange2.Name = "txtFlatsRange2";
            this.txtFlatsRange2.Size = new System.Drawing.Size(29, 20);
            this.txtFlatsRange2.TabIndex = 7;
            // 
            // labelFlatsPO
            // 
            this.labelFlatsPO.AutoSize = true;
            this.labelFlatsPO.Location = new System.Drawing.Point(119, 64);
            this.labelFlatsPO.Name = "labelFlatsPO";
            this.labelFlatsPO.Size = new System.Drawing.Size(19, 13);
            this.labelFlatsPO.TabIndex = 6;
            this.labelFlatsPO.Text = "по";
            // 
            // txtFlatsRange1
            // 
            this.txtFlatsRange1.Enabled = false;
            this.txtFlatsRange1.Location = new System.Drawing.Point(89, 59);
            this.txtFlatsRange1.Name = "txtFlatsRange1";
            this.txtFlatsRange1.Size = new System.Drawing.Size(30, 20);
            this.txtFlatsRange1.TabIndex = 5;
            // 
            // labelFlatsS
            // 
            this.labelFlatsS.AutoSize = true;
            this.labelFlatsS.Location = new System.Drawing.Point(76, 63);
            this.labelFlatsS.Name = "labelFlatsS";
            this.labelFlatsS.Size = new System.Drawing.Size(13, 13);
            this.labelFlatsS.TabIndex = 4;
            this.labelFlatsS.Text = "с";
            // 
            // txtFlatsOne
            // 
            this.txtFlatsOne.Enabled = false;
            this.txtFlatsOne.Location = new System.Drawing.Point(89, 37);
            this.txtFlatsOne.Name = "txtFlatsOne";
            this.txtFlatsOne.Size = new System.Drawing.Size(75, 20);
            this.txtFlatsOne.TabIndex = 3;
            // 
            // rbFlatsRange
            // 
            this.rbFlatsRange.AutoSize = true;
            this.rbFlatsRange.Location = new System.Drawing.Point(6, 61);
            this.rbFlatsRange.Name = "rbFlatsRange";
            this.rbFlatsRange.Size = new System.Drawing.Size(76, 17);
            this.rbFlatsRange.TabIndex = 2;
            this.rbFlatsRange.Text = "Диапазон";
            this.rbFlatsRange.UseVisualStyleBackColor = true;
            this.rbFlatsRange.CheckedChanged += new System.EventHandler(this.rbFlatsRange_CheckedChanged);
            // 
            // rbFlatsOne
            // 
            this.rbFlatsOne.AutoSize = true;
            this.rbFlatsOne.Location = new System.Drawing.Point(6, 38);
            this.rbFlatsOne.Name = "rbFlatsOne";
            this.rbFlatsOne.Size = new System.Drawing.Size(51, 17);
            this.rbFlatsOne.TabIndex = 1;
            this.rbFlatsOne.Text = "Одна";
            this.rbFlatsOne.UseVisualStyleBackColor = true;
            this.rbFlatsOne.CheckedChanged += new System.EventHandler(this.rbFlatsOne_CheckedChanged);
            // 
            // rbFlatsAll
            // 
            this.rbFlatsAll.AutoSize = true;
            this.rbFlatsAll.Checked = true;
            this.rbFlatsAll.Location = new System.Drawing.Point(6, 15);
            this.rbFlatsAll.Name = "rbFlatsAll";
            this.rbFlatsAll.Size = new System.Drawing.Size(96, 17);
            this.rbFlatsAll.TabIndex = 0;
            this.rbFlatsAll.TabStop = true;
            this.rbFlatsAll.Text = "Все квартиры";
            this.rbFlatsAll.UseVisualStyleBackColor = true;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(433, 6);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(39, 13);
            this.labelStreet.TabIndex = 10;
            this.labelStreet.Text = "Улица";
            // 
            // comboBoxStreet
            // 
            this.comboBoxStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStreet.DataSource = this.dsStreet;
            this.comboBoxStreet.DisplayMember = "tR_KladrStreet.NameStreet";
            this.comboBoxStreet.FormattingEnabled = true;
            this.comboBoxStreet.Location = new System.Drawing.Point(478, 3);
            this.comboBoxStreet.Name = "comboBoxStreet";
            this.comboBoxStreet.Size = new System.Drawing.Size(442, 21);
            this.comboBoxStreet.TabIndex = 11;
            this.comboBoxStreet.ValueMember = "tR_KladrStreet.Id";
            // 
            // dsStreet
            // 
            this.dsStreet.DataSetName = "NewDataSet";
            this.dsStreet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "tR_KladrStreet";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "name";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Socr";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "NameStreet";
            this.dataColumn4.Expression = "name + \' \' + isnull(socr, \'\')";
            this.dataColumn4.ReadOnly = true;
            // 
            // checkBoxDelAdress
            // 
            this.checkBoxDelAdress.AutoSize = true;
            this.checkBoxDelAdress.Location = new System.Drawing.Point(264, 182);
            this.checkBoxDelAdress.Name = "checkBoxDelAdress";
            this.checkBoxDelAdress.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDelAdress.TabIndex = 12;
            this.checkBoxDelAdress.Text = "Исключить";
            this.checkBoxDelAdress.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdress
            // 
            this.dataGridViewAdress.AllowUserToAddRows = false;
            this.dataGridViewAdress.AllowUserToDeleteRows = false;
            this.dataGridViewAdress.AllowUserToResizeRows = false;
            this.dataGridViewAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAdress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHousesN,
            this.colHousesDel,
            this.colHousesStreet,
            this.colHousesDom,
            this.colHousesFlat,
            this.colHousesCodeStreet});
            this.dataGridViewAdress.Location = new System.Drawing.Point(433, 30);
            this.dataGridViewAdress.MultiSelect = false;
            this.dataGridViewAdress.Name = "dataGridViewAdress";
            this.dataGridViewAdress.ReadOnly = true;
            this.dataGridViewAdress.RowHeadersVisible = false;
            this.dataGridViewAdress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdress.Size = new System.Drawing.Size(487, 175);
            this.dataGridViewAdress.TabIndex = 13;
            // 
            // colHousesN
            // 
            this.colHousesN.HeaderText = "№";
            this.colHousesN.Name = "colHousesN";
            this.colHousesN.ReadOnly = true;
            this.colHousesN.Width = 30;
            // 
            // colHousesDel
            // 
            this.colHousesDel.HeaderText = "Искл.";
            this.colHousesDel.Name = "colHousesDel";
            this.colHousesDel.ReadOnly = true;
            this.colHousesDel.Width = 40;
            // 
            // colHousesStreet
            // 
            this.colHousesStreet.HeaderText = "Улица";
            this.colHousesStreet.Name = "colHousesStreet";
            this.colHousesStreet.ReadOnly = true;
            this.colHousesStreet.Width = 153;
            // 
            // colHousesDom
            // 
            this.colHousesDom.HeaderText = "Дом";
            this.colHousesDom.Name = "colHousesDom";
            this.colHousesDom.ReadOnly = true;
            this.colHousesDom.Width = 70;
            // 
            // colHousesFlat
            // 
            this.colHousesFlat.HeaderText = "Кв.";
            this.colHousesFlat.Name = "colHousesFlat";
            this.colHousesFlat.ReadOnly = true;
            this.colHousesFlat.Width = 70;
            // 
            // colHousesCodeStreet
            // 
            this.colHousesCodeStreet.HeaderText = "Код улицы";
            this.colHousesCodeStreet.Name = "colHousesCodeStreet";
            this.colHousesCodeStreet.ReadOnly = true;
            this.colHousesCodeStreet.Visible = false;
            // 
            // buttonAddAdress
            // 
            this.buttonAddAdress.Location = new System.Drawing.Point(389, 178);
            this.buttonAddAdress.Name = "buttonAddAdress";
            this.buttonAddAdress.Size = new System.Drawing.Size(31, 23);
            this.buttonAddAdress.TabIndex = 14;
            this.buttonAddAdress.Text = ">>";
            this.buttonAddAdress.UseVisualStyleBackColor = true;
            this.buttonAddAdress.Click += new System.EventHandler(this.buttonAddAdress_Click);
            // 
            // buttonDelAdress
            // 
            this.buttonDelAdress.Location = new System.Drawing.Point(352, 178);
            this.buttonDelAdress.Name = "buttonDelAdress";
            this.buttonDelAdress.Size = new System.Drawing.Size(31, 23);
            this.buttonDelAdress.TabIndex = 15;
            this.buttonDelAdress.Text = "<<";
            this.buttonDelAdress.UseVisualStyleBackColor = true;
            this.buttonDelAdress.Click += new System.EventHandler(this.buttonDelAdress_Click);
            // 
            // tabControlVertical1
            // 
            this.tabControlVertical1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlVertical1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlVertical1.Controls.Add(this.tabPage3);
            this.tabControlVertical1.Controls.Add(this.tabPage4);
            this.tabControlVertical1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlVertical1.Location = new System.Drawing.Point(1, 310);
            this.tabControlVertical1.Multiline = true;
            this.tabControlVertical1.Name = "tabControlVertical1";
            this.tabControlVertical1.SelectedIndex = 0;
            this.tabControlVertical1.Size = new System.Drawing.Size(953, 216);
            this.tabControlVertical1.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxStreet);
            this.tabPage3.Controls.Add(this.checkBoxDelAdress);
            this.tabPage3.Controls.Add(this.buttonDelAdress);
            this.tabPage3.Controls.Add(this.checkedListBoxPunkts);
            this.tabPage3.Controls.Add(this.buttonAddAdress);
            this.tabPage3.Controls.Add(this.groupBoxFlats);
            this.tabPage3.Controls.Add(this.checkedListBoxRaion);
            this.tabPage3.Controls.Add(this.labelStreet);
            this.tabPage3.Controls.Add(this.groupBoxHouses);
            this.tabPage3.Controls.Add(this.dataGridViewAdress);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(926, 208);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(926, 208);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonDebCalc);
            this.panel1.Controls.Add(this.groupBoxWait);
            this.panel1.Controls.Add(this.buttonBegin);
            this.panel1.Controls.Add(this.groupBoxNO);
            this.panel1.Controls.Add(this.checkBoxNo);
            this.panel1.Controls.Add(this.comboBoxYear);
            this.panel1.Location = new System.Drawing.Point(844, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 311);
            this.panel1.TabIndex = 18;
            // 
            // buttonDebCalc
            // 
            this.buttonDebCalc.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonDebCalc.Image = global::Prv.Properties.Resources.if_calculator_delete_35795;
            this.buttonDebCalc.Location = new System.Drawing.Point(69, 267);
            this.buttonDebCalc.Name = "buttonDebCalc";
            this.buttonDebCalc.Size = new System.Drawing.Size(37, 37);
            this.buttonDebCalc.TabIndex = 23;
            this.buttonDebCalc.UseVisualStyleBackColor = true;
            this.buttonDebCalc.Click += new System.EventHandler(this.buttonDebCalc_Click);
            // 
            // groupBoxWait
            // 
            this.groupBoxWait.Controls.Add(this.progressBarEndLess);
            this.groupBoxWait.Location = new System.Drawing.Point(8, 173);
            this.groupBoxWait.Name = "groupBoxWait";
            this.groupBoxWait.Size = new System.Drawing.Size(98, 35);
            this.groupBoxWait.TabIndex = 22;
            this.groupBoxWait.TabStop = false;
            this.groupBoxWait.Text = "Подождите...";
            // 
            // progressBarEndLess
            // 
            this.progressBarEndLess.AutoProgress = true;
            this.progressBarEndLess.AutoProgressSpeed = 100;
            this.progressBarEndLess.Location = new System.Drawing.Point(4, 19);
            this.progressBarEndLess.Name = "progressBarEndLess";
            this.progressBarEndLess.NormalImage = null;
            this.progressBarEndLess.PointImage = null;
            this.progressBarEndLess.Position = 6;
            this.progressBarEndLess.ProgressBoxStyle = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessBoxStyleConstants.SolidSameSize;
            this.progressBarEndLess.ProgressStyle = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessStyleConstants.LeftToRight;
            this.progressBarEndLess.ProgressType = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessTypeConstants.GraphicType;
            this.progressBarEndLess.ShowBorder = false;
            this.progressBarEndLess.Size = new System.Drawing.Size(89, 10);
            this.progressBarEndLess.TabIndex = 21;
            // 
            // buttonBegin
            // 
            this.buttonBegin.Location = new System.Drawing.Point(3, 214);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(104, 28);
            this.buttonBegin.TabIndex = 7;
            this.buttonBegin.Text = "Сформировать";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // groupBoxNO
            // 
            this.groupBoxNO.Controls.Add(this.maskedTextBoxLimit2);
            this.groupBoxNO.Controls.Add(this.maskedTextBoxLimit1);
            this.groupBoxNO.Controls.Add(this.checkBoxTR);
            this.groupBoxNO.Controls.Add(this.до);
            this.groupBoxNO.Controls.Add(this.label_OT);
            this.groupBoxNO.Location = new System.Drawing.Point(3, 55);
            this.groupBoxNO.Name = "groupBoxNO";
            this.groupBoxNO.Size = new System.Drawing.Size(104, 112);
            this.groupBoxNO.TabIndex = 6;
            this.groupBoxNO.TabStop = false;
            this.groupBoxNO.Text = "Некорректные";
            // 
            // maskedTextBoxLimit2
            // 
            this.maskedTextBoxLimit2.Location = new System.Drawing.Point(17, 71);
            this.maskedTextBoxLimit2.Mask = "##########";
            this.maskedTextBoxLimit2.Name = "maskedTextBoxLimit2";
            this.maskedTextBoxLimit2.Size = new System.Drawing.Size(82, 20);
            this.maskedTextBoxLimit2.TabIndex = 8;
            // 
            // maskedTextBoxLimit1
            // 
            this.maskedTextBoxLimit1.Location = new System.Drawing.Point(17, 32);
            this.maskedTextBoxLimit1.Mask = "#########";
            this.maskedTextBoxLimit1.Name = "maskedTextBoxLimit1";
            this.maskedTextBoxLimit1.Size = new System.Drawing.Size(82, 20);
            this.maskedTextBoxLimit1.TabIndex = 7;
            // 
            // checkBoxTR
            // 
            this.checkBoxTR.AutoSize = true;
            this.checkBoxTR.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxTR.Location = new System.Drawing.Point(7, 91);
            this.checkBoxTR.Name = "checkBoxTR";
            this.checkBoxTR.Size = new System.Drawing.Size(96, 17);
            this.checkBoxTR.TabIndex = 6;
            this.checkBoxTR.Text = "С трансформ.";
            this.checkBoxTR.UseVisualStyleBackColor = true;
            // 
            // до
            // 
            this.до.AutoSize = true;
            this.до.Location = new System.Drawing.Point(6, 55);
            this.до.Name = "до";
            this.до.Size = new System.Drawing.Size(19, 13);
            this.до.TabIndex = 5;
            this.до.Text = "до";
            // 
            // label_OT
            // 
            this.label_OT.AutoSize = true;
            this.label_OT.Location = new System.Drawing.Point(6, 16);
            this.label_OT.Name = "label_OT";
            this.label_OT.Size = new System.Drawing.Size(18, 13);
            this.label_OT.TabIndex = 2;
            this.label_OT.Text = "от";
            // 
            // checkBoxNo
            // 
            this.checkBoxNo.AutoSize = true;
            this.checkBoxNo.Location = new System.Drawing.Point(12, 34);
            this.checkBoxNo.Name = "checkBoxNo";
            this.checkBoxNo.Size = new System.Drawing.Size(82, 17);
            this.checkBoxNo.TabIndex = 1;
            this.checkBoxNo.Text = "Исключить";
            this.checkBoxNo.UseVisualStyleBackColor = true;
            this.checkBoxNo.CheckedChanged += new System.EventHandler(this.checkBoxNo_CheckedChanged);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(5, 7);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(104, 21);
            this.comboBoxYear.TabIndex = 0;
            // 
            // dataGridViewExcelFilterDabAll
            // 
            this.dataGridViewExcelFilterDabAll.AllowUserToAddRows = false;
            this.dataGridViewExcelFilterDabAll.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilterDabAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewExcelFilterDabAll.AutoGenerateColumns = false;
            this.dataGridViewExcelFilterDabAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcelFilterDabAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodDataGridViewTextBoxColumn,
            this.PStr,
            this.yearDataGridViewTextBoxColumn,
            this.kWTDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.itogU,
            this.countU});
            this.dataGridViewExcelFilterDabAll.DataSource = this.bindingSourceRepAll;
            this.dataGridViewExcelFilterDabAll.Location = new System.Drawing.Point(545, 0);
            this.dataGridViewExcelFilterDabAll.Name = "dataGridViewExcelFilterDabAll";
            this.dataGridViewExcelFilterDabAll.NumbLineVisible = false;
            this.dataGridViewExcelFilterDabAll.ReadOnly = true;
            this.dataGridViewExcelFilterDabAll.RowHeadersWidth = 4;
            this.dataGridViewExcelFilterDabAll.Size = new System.Drawing.Size(298, 311);
            this.dataGridViewExcelFilterDabAll.TabIndex = 19;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodDataGridViewTextBoxColumn.Visible = false;
            this.periodDataGridViewTextBoxColumn.Width = 60;
            // 
            // PStr
            // 
            this.PStr.DataPropertyName = "PStr";
            this.PStr.HeaderText = "Период";
            this.PStr.Name = "PStr";
            this.PStr.ReadOnly = true;
            this.PStr.Width = 50;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Visible = false;
            // 
            // kWTDataGridViewTextBoxColumn
            // 
            this.kWTDataGridViewTextBoxColumn.DataPropertyName = "KWT";
            this.kWTDataGridViewTextBoxColumn.HeaderText = "кВт";
            this.kWTDataGridViewTextBoxColumn.Name = "kWTDataGridViewTextBoxColumn";
            this.kWTDataGridViewTextBoxColumn.ReadOnly = true;
            this.kWTDataGridViewTextBoxColumn.Width = 60;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 50;
            // 
            // itogU
            // 
            this.itogU.DataPropertyName = "itogU";
            this.itogU.HeaderText = "кВтУЭ";
            this.itogU.Name = "itogU";
            this.itogU.ReadOnly = true;
            this.itogU.Width = 60;
            // 
            // countU
            // 
            this.countU.DataPropertyName = "countU";
            this.countU.HeaderText = "аб.УЭ";
            this.countU.Name = "countU";
            this.countU.ReadOnly = true;
            this.countU.Width = 50;
            // 
            // dsDirectory
            // 
            this.dsDirectory.DataSetName = "DataSetPrv";
            this.dsDirectory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerDebGraf
            // 
            this.reportViewerDebGraf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetRep_vPrv_RepDebitorkaAll";
            reportDataSource1.Value = this.bindingSourceRepAll;
            this.reportViewerDebGraf.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDebGraf.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportDebAll.rdlc";
            this.reportViewerDebGraf.Location = new System.Drawing.Point(1, 0);
            this.reportViewerDebGraf.Name = "reportViewerDebGraf";
            this.reportViewerDebGraf.Size = new System.Drawing.Size(538, 308);
            this.reportViewerDebGraf.TabIndex = 20;
            // 
            // backgroundWorkerDebAll
            // 
            this.backgroundWorkerDebAll.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDebAll_DoWork);
            this.backgroundWorkerDebAll.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDebAll_RunWorkerCompleted);
            // 
            // FormDebitorka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 526);
            this.Controls.Add(this.reportViewerDebGraf);
            this.Controls.Add(this.dataGridViewExcelFilterDabAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlVertical1);
            this.Name = "FormDebitorka";
            this.Text = "Начисления";
            this.Load += new System.EventHandler(this.FormDebitorka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRepAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            this.groupBoxHouses.ResumeLayout(false);
            this.groupBoxHouses.PerformLayout();
            this.groupBoxFlats.ResumeLayout(false);
            this.groupBoxFlats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdress)).EndInit();
            this.tabControlVertical1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxWait.ResumeLayout(false);
            this.groupBoxNO.ResumeLayout(false);
            this.groupBoxNO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelFilterDabAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDirectory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxRaion;
        private System.Windows.Forms.CheckedListBox checkedListBoxPunkts;
        private System.Windows.Forms.GroupBox groupBoxHouses;
        private System.Windows.Forms.TextBox txtHousesRange2;
        private System.Windows.Forms.Label labelPO;
        private System.Windows.Forms.TextBox txtHousesRange1;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.TextBox txtHousesOne;
        private System.Windows.Forms.RadioButton rbHousesRange;
        private System.Windows.Forms.RadioButton rbHousesOne;
        private System.Windows.Forms.RadioButton rbHousesAll;
        private System.Windows.Forms.GroupBox groupBoxFlats;
        private System.Windows.Forms.TextBox txtFlatsRange2;
        private System.Windows.Forms.Label labelFlatsPO;
        private System.Windows.Forms.TextBox txtFlatsRange1;
        private System.Windows.Forms.Label labelFlatsS;
        private System.Windows.Forms.TextBox txtFlatsOne;
        private System.Windows.Forms.RadioButton rbFlatsRange;
        private System.Windows.Forms.RadioButton rbFlatsOne;
        private System.Windows.Forms.RadioButton rbFlatsAll;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.ComboBox comboBoxStreet;
        private System.Windows.Forms.CheckBox checkBoxDelAdress;
        private System.Windows.Forms.DataGridView dataGridViewAdress;
        private System.Windows.Forms.Button buttonAddAdress;
        private System.Windows.Forms.Button buttonDelAdress;
        private ControlsLbr.TabControlVertical tabControlVertical1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxNo;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label до;
        private System.Windows.Forms.Label label_OT;
        private System.Windows.Forms.GroupBox groupBoxNO;
        private System.Windows.Forms.CheckBox checkBoxTR;
        private System.Windows.Forms.Button buttonBegin;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilterDabAll;
        private Prv.DataSets.DataSetPrv dsDirectory;
        private System.Data.DataSet dsStreet;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHousesN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colHousesDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHousesStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHousesDom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHousesFlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHousesCodeStreet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLimit1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLimit2;
        private Prv.DataSets.DataSetRep dsRep;
        private System.Windows.Forms.BindingSource bindingSourceRepAll;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDebGraf;
        private ControlsLbr.ProgressBarEndLess progressBarEndLess;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDebAll;
        private System.Windows.Forms.GroupBox groupBoxWait;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itogU;
        private System.Windows.Forms.DataGridViewTextBoxColumn countU;
        private System.Windows.Forms.Button buttonDebCalc;
    }
}