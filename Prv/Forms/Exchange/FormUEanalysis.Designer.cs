namespace Prv.Forms.Exchange
{
    partial class FormUEanalysis
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
            this.tabControlAnalysis = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainerUEoplPOST = new System.Windows.Forms.SplitContainer();
            this.dgvefUEoplPostFiles = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.folderFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.bsFileName = new System.Windows.Forms.BindingSource(this.components);
            this.dsExchange = new Prv.DataSets.DataSetExchange();
            this.dgvefUEoplPostDoc = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocOplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogovorDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nomPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.raionDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.gorodokDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.domDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.korpDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.kvDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nomPomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRaznDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOplDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predPokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tekPokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKVTitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomTarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byPeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyOplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poNormeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopPriznakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSTNachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateinsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOpl = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripUeOplPOST = new System.Windows.Forms.ToolStrip();
            this.tscbTypeDoc = new System.Windows.Forms.ToolStripComboBox();
            this.tscbOk = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbInsAgain = new System.Windows.Forms.ToolStripButton();
            this.tabControlAnalysis.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.splitContainerUEoplPOST.Panel1.SuspendLayout();
            this.splitContainerUEoplPOST.Panel2.SuspendLayout();
            this.splitContainerUEoplPOST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefUEoplPostFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefUEoplPostDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOpl)).BeginInit();
            this.toolStripUeOplPOST.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAnalysis
            // 
            this.tabControlAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAnalysis.Controls.Add(this.tabPage1);
            this.tabControlAnalysis.Location = new System.Drawing.Point(0, 0);
            this.tabControlAnalysis.Name = "tabControlAnalysis";
            this.tabControlAnalysis.SelectedIndex = 0;
            this.tabControlAnalysis.Size = new System.Drawing.Size(887, 630);
            this.tabControlAnalysis.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainerUEoplPOST);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оплата по почте";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainerUEoplPOST
            // 
            this.splitContainerUEoplPOST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUEoplPOST.Location = new System.Drawing.Point(3, 3);
            this.splitContainerUEoplPOST.Name = "splitContainerUEoplPOST";
            this.splitContainerUEoplPOST.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerUEoplPOST.Panel1
            // 
            this.splitContainerUEoplPOST.Panel1.Controls.Add(this.dgvefUEoplPostFiles);
            // 
            // splitContainerUEoplPOST.Panel2
            // 
            this.splitContainerUEoplPOST.Panel2.Controls.Add(this.dgvefUEoplPostDoc);
            this.splitContainerUEoplPOST.Panel2.Controls.Add(this.toolStripUeOplPOST);
            this.splitContainerUEoplPOST.Size = new System.Drawing.Size(873, 598);
            this.splitContainerUEoplPOST.SplitterDistance = 138;
            this.splitContainerUEoplPOST.TabIndex = 0;
            // 
            // dgvefUEoplPostFiles
            // 
            this.dgvefUEoplPostFiles.AllowUserToAddRows = false;
            this.dgvefUEoplPostFiles.AllowUserToDeleteRows = false;
            this.dgvefUEoplPostFiles.AutoGenerateColumns = false;
            this.dgvefUEoplPostFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvefUEoplPostFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folderFileDataGridViewTextBoxColumn,
            this.fileDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvefUEoplPostFiles.DataSource = this.bsFileName;
            this.dgvefUEoplPostFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvefUEoplPostFiles.Location = new System.Drawing.Point(0, 0);
            this.dgvefUEoplPostFiles.Name = "dgvefUEoplPostFiles";
            this.dgvefUEoplPostFiles.ReadOnly = true;
            this.dgvefUEoplPostFiles.RowHeadersWidth = 21;
            this.dgvefUEoplPostFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvefUEoplPostFiles.Size = new System.Drawing.Size(873, 138);
            this.dgvefUEoplPostFiles.TabIndex = 0;
            this.dgvefUEoplPostFiles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvefUEoplPostFiles_CellMouseClick);
            // 
            // folderFileDataGridViewTextBoxColumn
            // 
            this.folderFileDataGridViewTextBoxColumn.DataPropertyName = "FolderFile";
            this.folderFileDataGridViewTextBoxColumn.HeaderText = "FolderFile";
            this.folderFileDataGridViewTextBoxColumn.Name = "folderFileDataGridViewTextBoxColumn";
            this.folderFileDataGridViewTextBoxColumn.ReadOnly = true;
            this.folderFileDataGridViewTextBoxColumn.Visible = false;
            // 
            // fileDataGridViewTextBoxColumn
            // 
            this.fileDataGridViewTextBoxColumn.DataPropertyName = "File";
            this.fileDataGridViewTextBoxColumn.HeaderText = "Имя файла";
            this.fileDataGridViewTextBoxColumn.Name = "fileDataGridViewTextBoxColumn";
            this.fileDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fileDataGridViewTextBoxColumn.Width = 500;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата прогрузки";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bsFileName
            // 
            this.bsFileName.DataMember = "vPrv_DocOplUEPostFiles";
            this.bsFileName.DataSource = this.dsExchange;
            // 
            // dsExchange
            // 
            this.dsExchange.DataSetName = "DataSetExchange";
            this.dsExchange.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvefUEoplPostDoc
            // 
            this.dgvefUEoplPostDoc.AllowUserToAddRows = false;
            this.dgvefUEoplPostDoc.AllowUserToDeleteRows = false;
            this.dgvefUEoplPostDoc.AutoGenerateColumns = false;
            this.dgvefUEoplPostDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvefUEoplPostDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idDocOplDataGridViewTextBoxColumn,
            this.dogovorDataGridViewTextBoxColumn,
            this.nomPointDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.raionDataGridViewTextBoxColumn,
            this.gorodokDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.domDataGridViewTextBoxColumn,
            this.korpDataGridViewTextBoxColumn,
            this.kvDataGridViewTextBoxColumn,
            this.nomPomDataGridViewTextBoxColumn,
            this.dataOplDataGridViewTextBoxColumn,
            this.dataRaznDataGridViewTextBoxColumn,
            this.typeOplDataGridViewTextBoxColumn,
            this.typeKodDataGridViewTextBoxColumn,
            this.predPokDataGridViewTextBoxColumn,
            this.tekPokDataGridViewTextBoxColumn,
            this.colKVTDataGridViewTextBoxColumn,
            this.colKVTitDataGridViewTextBoxColumn,
            this.nomTarifDataGridViewTextBoxColumn,
            this.byPeriodDataGridViewTextBoxColumn,
            this.keyOplDataGridViewTextBoxColumn,
            this.poNormeDataGridViewTextBoxColumn,
            this.dopPriznakDataGridViewTextBoxColumn,
            this.iSTNachDataGridViewTextBoxColumn,
            this.constCodeDataGridViewTextBoxColumn,
            this.nameFileDataGridViewTextBoxColumn,
            this.okDataGridViewTextBoxColumn,
            this.dateinsDataGridViewTextBoxColumn,
            this.idOwnerDataGridViewTextBoxColumn});
            this.dgvefUEoplPostDoc.DataSource = this.bsOpl;
            this.dgvefUEoplPostDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvefUEoplPostDoc.Location = new System.Drawing.Point(0, 25);
            this.dgvefUEoplPostDoc.Name = "dgvefUEoplPostDoc";
            this.dgvefUEoplPostDoc.ReadOnly = true;
            this.dgvefUEoplPostDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvefUEoplPostDoc.Size = new System.Drawing.Size(873, 431);
            this.dgvefUEoplPostDoc.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDocOplDataGridViewTextBoxColumn
            // 
            this.idDocOplDataGridViewTextBoxColumn.DataPropertyName = "idDocOpl";
            this.idDocOplDataGridViewTextBoxColumn.HeaderText = "idDocOpl";
            this.idDocOplDataGridViewTextBoxColumn.Name = "idDocOplDataGridViewTextBoxColumn";
            this.idDocOplDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocOplDataGridViewTextBoxColumn.Visible = false;
            // 
            // dogovorDataGridViewTextBoxColumn
            // 
            this.dogovorDataGridViewTextBoxColumn.DataPropertyName = "Dogovor";
            this.dogovorDataGridViewTextBoxColumn.HeaderText = "Договор";
            this.dogovorDataGridViewTextBoxColumn.Name = "dogovorDataGridViewTextBoxColumn";
            this.dogovorDataGridViewTextBoxColumn.ReadOnly = true;
            this.dogovorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nomPointDataGridViewTextBoxColumn
            // 
            this.nomPointDataGridViewTextBoxColumn.DataPropertyName = "NomPoint";
            this.nomPointDataGridViewTextBoxColumn.HeaderText = "№ т.у";
            this.nomPointDataGridViewTextBoxColumn.Name = "nomPointDataGridViewTextBoxColumn";
            this.nomPointDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomPointDataGridViewTextBoxColumn.Width = 40;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "Ф.И.О.";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // raionDataGridViewTextBoxColumn
            // 
            this.raionDataGridViewTextBoxColumn.DataPropertyName = "Raion";
            this.raionDataGridViewTextBoxColumn.HeaderText = "Район";
            this.raionDataGridViewTextBoxColumn.Name = "raionDataGridViewTextBoxColumn";
            this.raionDataGridViewTextBoxColumn.ReadOnly = true;
            this.raionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gorodokDataGridViewTextBoxColumn
            // 
            this.gorodokDataGridViewTextBoxColumn.DataPropertyName = "Gorodok";
            this.gorodokDataGridViewTextBoxColumn.HeaderText = "Нас.пункт";
            this.gorodokDataGridViewTextBoxColumn.Name = "gorodokDataGridViewTextBoxColumn";
            this.gorodokDataGridViewTextBoxColumn.ReadOnly = true;
            this.gorodokDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ulicaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // domDataGridViewTextBoxColumn
            // 
            this.domDataGridViewTextBoxColumn.DataPropertyName = "Dom";
            this.domDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.domDataGridViewTextBoxColumn.Name = "domDataGridViewTextBoxColumn";
            this.domDataGridViewTextBoxColumn.ReadOnly = true;
            this.domDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // korpDataGridViewTextBoxColumn
            // 
            this.korpDataGridViewTextBoxColumn.DataPropertyName = "Korp";
            this.korpDataGridViewTextBoxColumn.HeaderText = "Корпус";
            this.korpDataGridViewTextBoxColumn.Name = "korpDataGridViewTextBoxColumn";
            this.korpDataGridViewTextBoxColumn.ReadOnly = true;
            this.korpDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // kvDataGridViewTextBoxColumn
            // 
            this.kvDataGridViewTextBoxColumn.DataPropertyName = "Kv";
            this.kvDataGridViewTextBoxColumn.HeaderText = "кв.";
            this.kvDataGridViewTextBoxColumn.Name = "kvDataGridViewTextBoxColumn";
            this.kvDataGridViewTextBoxColumn.ReadOnly = true;
            this.kvDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nomPomDataGridViewTextBoxColumn
            // 
            this.nomPomDataGridViewTextBoxColumn.DataPropertyName = "NomPom";
            this.nomPomDataGridViewTextBoxColumn.HeaderText = "№ пом.";
            this.nomPomDataGridViewTextBoxColumn.Name = "nomPomDataGridViewTextBoxColumn";
            this.nomPomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataOplDataGridViewTextBoxColumn
            // 
            this.dataOplDataGridViewTextBoxColumn.DataPropertyName = "DataOpl";
            this.dataOplDataGridViewTextBoxColumn.HeaderText = "Дата опл.";
            this.dataOplDataGridViewTextBoxColumn.Name = "dataOplDataGridViewTextBoxColumn";
            this.dataOplDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRaznDataGridViewTextBoxColumn
            // 
            this.dataRaznDataGridViewTextBoxColumn.DataPropertyName = "DataRazn";
            this.dataRaznDataGridViewTextBoxColumn.HeaderText = "Дата внесения";
            this.dataRaznDataGridViewTextBoxColumn.Name = "dataRaznDataGridViewTextBoxColumn";
            this.dataRaznDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeOplDataGridViewTextBoxColumn
            // 
            this.typeOplDataGridViewTextBoxColumn.DataPropertyName = "TypeOpl";
            this.typeOplDataGridViewTextBoxColumn.HeaderText = "Тип опл.";
            this.typeOplDataGridViewTextBoxColumn.Name = "typeOplDataGridViewTextBoxColumn";
            this.typeOplDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeOplDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeKodDataGridViewTextBoxColumn
            // 
            this.typeKodDataGridViewTextBoxColumn.DataPropertyName = "TypeKod";
            this.typeKodDataGridViewTextBoxColumn.HeaderText = "TypeKod";
            this.typeKodDataGridViewTextBoxColumn.Name = "typeKodDataGridViewTextBoxColumn";
            this.typeKodDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeKodDataGridViewTextBoxColumn.Visible = false;
            // 
            // predPokDataGridViewTextBoxColumn
            // 
            this.predPokDataGridViewTextBoxColumn.DataPropertyName = "PredPok";
            this.predPokDataGridViewTextBoxColumn.HeaderText = "Пред. показания";
            this.predPokDataGridViewTextBoxColumn.Name = "predPokDataGridViewTextBoxColumn";
            this.predPokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tekPokDataGridViewTextBoxColumn
            // 
            this.tekPokDataGridViewTextBoxColumn.DataPropertyName = "TekPok";
            this.tekPokDataGridViewTextBoxColumn.HeaderText = "Тек. показания";
            this.tekPokDataGridViewTextBoxColumn.Name = "tekPokDataGridViewTextBoxColumn";
            this.tekPokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colKVTDataGridViewTextBoxColumn
            // 
            this.colKVTDataGridViewTextBoxColumn.DataPropertyName = "ColKVT";
            this.colKVTDataGridViewTextBoxColumn.HeaderText = "кол.кВтч";
            this.colKVTDataGridViewTextBoxColumn.Name = "colKVTDataGridViewTextBoxColumn";
            this.colKVTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colKVTitDataGridViewTextBoxColumn
            // 
            this.colKVTitDataGridViewTextBoxColumn.DataPropertyName = "ColKVTit";
            this.colKVTitDataGridViewTextBoxColumn.HeaderText = "Итог кВтч";
            this.colKVTitDataGridViewTextBoxColumn.Name = "colKVTitDataGridViewTextBoxColumn";
            this.colKVTitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomTarifDataGridViewTextBoxColumn
            // 
            this.nomTarifDataGridViewTextBoxColumn.DataPropertyName = "NomTarif";
            this.nomTarifDataGridViewTextBoxColumn.HeaderText = "№тариф";
            this.nomTarifDataGridViewTextBoxColumn.Name = "nomTarifDataGridViewTextBoxColumn";
            this.nomTarifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // byPeriodDataGridViewTextBoxColumn
            // 
            this.byPeriodDataGridViewTextBoxColumn.DataPropertyName = "ByPeriod";
            this.byPeriodDataGridViewTextBoxColumn.HeaderText = "За период";
            this.byPeriodDataGridViewTextBoxColumn.Name = "byPeriodDataGridViewTextBoxColumn";
            this.byPeriodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyOplDataGridViewTextBoxColumn
            // 
            this.keyOplDataGridViewTextBoxColumn.DataPropertyName = "KeyOpl";
            this.keyOplDataGridViewTextBoxColumn.HeaderText = "KeyOpl";
            this.keyOplDataGridViewTextBoxColumn.Name = "keyOplDataGridViewTextBoxColumn";
            this.keyOplDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyOplDataGridViewTextBoxColumn.Visible = false;
            // 
            // poNormeDataGridViewTextBoxColumn
            // 
            this.poNormeDataGridViewTextBoxColumn.DataPropertyName = "PoNorme";
            this.poNormeDataGridViewTextBoxColumn.HeaderText = "По норме";
            this.poNormeDataGridViewTextBoxColumn.Name = "poNormeDataGridViewTextBoxColumn";
            this.poNormeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dopPriznakDataGridViewTextBoxColumn
            // 
            this.dopPriznakDataGridViewTextBoxColumn.DataPropertyName = "DopPriznak";
            this.dopPriznakDataGridViewTextBoxColumn.HeaderText = "Доп.признак";
            this.dopPriznakDataGridViewTextBoxColumn.Name = "dopPriznakDataGridViewTextBoxColumn";
            this.dopPriznakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSTNachDataGridViewTextBoxColumn
            // 
            this.iSTNachDataGridViewTextBoxColumn.DataPropertyName = "IST_Nach";
            this.iSTNachDataGridViewTextBoxColumn.HeaderText = "IST_Nach";
            this.iSTNachDataGridViewTextBoxColumn.Name = "iSTNachDataGridViewTextBoxColumn";
            this.iSTNachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // constCodeDataGridViewTextBoxColumn
            // 
            this.constCodeDataGridViewTextBoxColumn.DataPropertyName = "Const_Code";
            this.constCodeDataGridViewTextBoxColumn.HeaderText = "Const_Code";
            this.constCodeDataGridViewTextBoxColumn.Name = "constCodeDataGridViewTextBoxColumn";
            this.constCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameFileDataGridViewTextBoxColumn
            // 
            this.nameFileDataGridViewTextBoxColumn.DataPropertyName = "NameFile";
            this.nameFileDataGridViewTextBoxColumn.HeaderText = "Источник";
            this.nameFileDataGridViewTextBoxColumn.Name = "nameFileDataGridViewTextBoxColumn";
            this.nameFileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okDataGridViewTextBoxColumn
            // 
            this.okDataGridViewTextBoxColumn.DataPropertyName = "Ok";
            this.okDataGridViewTextBoxColumn.HeaderText = "Ok";
            this.okDataGridViewTextBoxColumn.Name = "okDataGridViewTextBoxColumn";
            this.okDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateinsDataGridViewTextBoxColumn
            // 
            this.dateinsDataGridViewTextBoxColumn.DataPropertyName = "Dateins";
            this.dateinsDataGridViewTextBoxColumn.HeaderText = "Dateins";
            this.dateinsDataGridViewTextBoxColumn.Name = "dateinsDataGridViewTextBoxColumn";
            this.dateinsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idOwnerDataGridViewTextBoxColumn
            // 
            this.idOwnerDataGridViewTextBoxColumn.DataPropertyName = "IdOwner";
            this.idOwnerDataGridViewTextBoxColumn.HeaderText = "IdOwner";
            this.idOwnerDataGridViewTextBoxColumn.Name = "idOwnerDataGridViewTextBoxColumn";
            this.idOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsOpl
            // 
            this.bsOpl.DataMember = "vPrv_DocOplUEPost";
            this.bsOpl.DataSource = this.dsExchange;
            // 
            // toolStripUeOplPOST
            // 
            this.toolStripUeOplPOST.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbTypeDoc,
            this.tscbOk,
            this.toolStripButtonFind,
            this.toolStripTextBoxFind,
            this.toolStripButtonFindPrev,
            this.toolStripButtonFindNext,
            this.toolStripButtonPrint,
            this.toolStripButtonExportExcel,
            this.tsbInsAgain});
            this.toolStripUeOplPOST.Location = new System.Drawing.Point(0, 0);
            this.toolStripUeOplPOST.Name = "toolStripUeOplPOST";
            this.toolStripUeOplPOST.Size = new System.Drawing.Size(873, 25);
            this.toolStripUeOplPOST.TabIndex = 0;
            this.toolStripUeOplPOST.Text = "toolStrip1";
            // 
            // tscbTypeDoc
            // 
            this.tscbTypeDoc.Items.AddRange(new object[] {
            "Оплата",
            "Все"});
            this.tscbTypeDoc.Name = "tscbTypeDoc";
            this.tscbTypeDoc.Size = new System.Drawing.Size(121, 25);
            this.tscbTypeDoc.SelectedIndexChanged += new System.EventHandler(this.tscbTypeDoc_SelectedIndexChanged);
            // 
            // tscbOk
            // 
            this.tscbOk.Items.AddRange(new object[] {
            "Не провелась",
            "Все"});
            this.tscbOk.Name = "tscbOk";
            this.tscbOk.Size = new System.Drawing.Size(121, 25);
            this.tscbOk.SelectedIndexChanged += new System.EventHandler(this.tscbOk_SelectedIndexChanged);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = global::Prv.Properties.Resources.Find;
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonFindPrev
            // 
            this.toolStripButtonFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindPrev.Image = global::Prv.Properties.Resources.FindPrev;
            this.toolStripButtonFindPrev.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFindPrev.Name = "toolStripButtonFindPrev";
            this.toolStripButtonFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindPrev.Text = "Поиск назад";
            this.toolStripButtonFindPrev.Click += new System.EventHandler(this.toolStripButtonFindPrev_Click);
            // 
            // toolStripButtonFindNext
            // 
            this.toolStripButtonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindNext.Image = global::Prv.Properties.Resources.FindNext;
            this.toolStripButtonFindNext.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFindNext.Name = "toolStripButtonFindNext";
            this.toolStripButtonFindNext.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindNext.Text = "Поиск вперед";
            this.toolStripButtonFindNext.Click += new System.EventHandler(this.toolStripButtonFindNext_Click);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Image = global::Prv.Properties.Resources.Print;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrint.Text = "Печать";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // toolStripButtonExportExcel
            // 
            this.toolStripButtonExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExportExcel.Image = global::Prv.Properties.Resources.Excel;
            this.toolStripButtonExportExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonExportExcel.Name = "toolStripButtonExportExcel";
            this.toolStripButtonExportExcel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExportExcel.Text = "Экспорт в Excel";
            this.toolStripButtonExportExcel.Click += new System.EventHandler(this.toolStripButtonExportExcel_Click);
            // 
            // tsbInsAgain
            // 
            this.tsbInsAgain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbInsAgain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInsAgain.Image = global::Prv.Properties.Resources.ElementGo;
            this.tsbInsAgain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsAgain.Name = "tsbInsAgain";
            this.tsbInsAgain.Size = new System.Drawing.Size(23, 22);
            this.tsbInsAgain.Text = "Провести оплату заново";
            this.tsbInsAgain.Click += new System.EventHandler(this.tsbInsAgain_Click);
            // 
            // FormUEanalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 628);
            this.Controls.Add(this.tabControlAnalysis);
            this.Name = "FormUEanalysis";
            this.Text = "Анализ прогружаемых данных Ульяновскэнерго";
            this.Load += new System.EventHandler(this.FormUEanalysis_Load);
            this.tabControlAnalysis.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainerUEoplPOST.Panel1.ResumeLayout(false);
            this.splitContainerUEoplPOST.Panel2.ResumeLayout(false);
            this.splitContainerUEoplPOST.Panel2.PerformLayout();
            this.splitContainerUEoplPOST.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvefUEoplPostFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefUEoplPostDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOpl)).EndInit();
            this.toolStripUeOplPOST.ResumeLayout(false);
            this.toolStripUeOplPOST.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSets.DataSetExchange dsExchange;
        private System.Windows.Forms.TabControl tabControlAnalysis;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainerUEoplPOST;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvefUEoplPostFiles;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvefUEoplPostDoc;
        private System.Windows.Forms.ToolStrip toolStripUeOplPOST;
        private System.Windows.Forms.BindingSource bsFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderFileDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn fileDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripComboBox tscbTypeDoc;
        private System.Windows.Forms.ToolStripComboBox tscbOk;
        private System.Windows.Forms.BindingSource bsOpl;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocOplDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dogovorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPointDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn fIODataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn raionDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn gorodokDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn domDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn korpDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn kvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRaznDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn typeOplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predPokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tekPokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKVTitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byPeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyOplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poNormeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dopPriznakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSTNachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateinsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;
        private System.Windows.Forms.ToolStripButton tsbInsAgain;
    }
}