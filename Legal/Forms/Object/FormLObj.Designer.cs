namespace Legal.Forms.Object
{
    partial class FormLObj
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLObj));
            this.dataGridViewObj = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.SelectCell = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.objName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.ShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarifName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.CodeAbonent = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.abnName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Specialist = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.DateBegin = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.NameObjParent = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.master = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Address = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Region = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Name_Group = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.PowerSet = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.PowerFact = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.KLoss = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Regime = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.CategoryName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.NetName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.SaleName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.AbnNameMinus = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsObj1 = new Legal.DataSet.dsObj();
            this.Status = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Sale = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxObj = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCheck = new System.Windows.Forms.ToolStripButton();
            this.btnUncheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbStatus = new System.Windows.Forms.ToolStripComboBox();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbMaster = new System.Windows.Forms.ToolStripComboBox();
            this.btnChangeBinding = new System.Windows.Forms.ToolStripButton();
            this.tbName = new System.Windows.Forms.ToolStripTextBox();
            this.tbCode = new System.Windows.Forms.ToolStripTextBox();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.cmbTariff = new System.Windows.Forms.ToolStripComboBox();
            this.btnChangeTariff = new System.Windows.Forms.ToolStripButton();
            this.idDataGridViewObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.abnNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bsWorkers = new System.Windows.Forms.BindingSource(this.components);
            this.btnReportPower = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewObj
            // 
            this.dataGridViewObj.AllowUserToAddRows = false;
            this.dataGridViewObj.AllowUserToDeleteRows = false;
            this.dataGridViewObj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewObj.AutoGenerateColumns = false;
            this.dataGridViewObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCell,
            this.objName,
            this.ShortName,
            this.TarifName,
            this.CodeAbonent,
            this.abnName,
            this.Specialist,
            this.DateBegin,
            this.NameObjParent,
            this.master,
            this.Address,
            this.Region,
            this.Name_Group,
            this.PowerSet,
            this.PowerFact,
            this.KLoss,
            this.Regime,
            this.CategoryName,
            this.NetName,
            this.SaleName,
            this.AbnNameMinus,
            this.id});
            this.dataGridViewObj.DataSource = this.bindingSource1;
            this.dataGridViewObj.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewObj.Name = "dataGridViewObj";
            this.dataGridViewObj.NumbLineVisible = false;
            this.dataGridViewObj.RowHeadersWidth = 4;
            this.dataGridViewObj.RowTemplate.Height = 24;
            this.dataGridViewObj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewObj.Size = new System.Drawing.Size(984, 496);
            this.dataGridViewObj.TabIndex = 0;
            this.dataGridViewObj.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewObj_CurrentCellDirtyStateChanged);
            this.dataGridViewObj.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewObj_Paint);
            // 
            // SelectCell
            // 
            this.SelectCell.HeaderText = "Выбор";
            this.SelectCell.Name = "SelectCell";
            this.SelectCell.Width = 70;
            // 
            // objName
            // 
            this.objName.DataPropertyName = "ObjName";
            this.objName.HeaderText = "Объект";
            this.objName.Name = "objName";
            this.objName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.objName.Width = 400;
            // 
            // ShortName
            // 
            this.ShortName.DataPropertyName = "ShortName";
            this.ShortName.HeaderText = "Короткое имя";
            this.ShortName.Name = "ShortName";
            this.ShortName.Width = 200;
            // 
            // TarifName
            // 
            this.TarifName.DataPropertyName = "TarifName";
            this.TarifName.HeaderText = "Тариф";
            this.TarifName.Name = "TarifName";
            this.TarifName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CodeAbonent
            // 
            this.CodeAbonent.DataPropertyName = "CodeAbonent";
            this.CodeAbonent.HeaderText = "Код";
            this.CodeAbonent.Name = "CodeAbonent";
            this.CodeAbonent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodeAbonent.Width = 75;
            // 
            // abnName
            // 
            this.abnName.DataPropertyName = "AbnName";
            this.abnName.HeaderText = "Владелец";
            this.abnName.Name = "abnName";
            this.abnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.abnName.Width = 300;
            // 
            // Specialist
            // 
            this.Specialist.DataPropertyName = "Specialist";
            this.Specialist.HeaderText = "Специалист";
            this.Specialist.Name = "Specialist";
            this.Specialist.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DateBegin
            // 
            this.DateBegin.DataPropertyName = "DateBegin";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DateBegin.DefaultCellStyle = dataGridViewCellStyle1;
            this.DateBegin.HeaderText = "В договоре";
            this.DateBegin.Name = "DateBegin";
            this.DateBegin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateBegin.Width = 120;
            // 
            // NameObjParent
            // 
            this.NameObjParent.DataPropertyName = "NameObjParent";
            this.NameObjParent.HeaderText = "Родитель";
            this.NameObjParent.Name = "NameObjParent";
            this.NameObjParent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // master
            // 
            this.master.DataPropertyName = "Master";
            this.master.HeaderText = "Мастер";
            this.master.Name = "master";
            this.master.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.master.Width = 90;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Address.Width = 300;
            // 
            // Region
            // 
            this.Region.DataPropertyName = "Region";
            this.Region.HeaderText = "Район";
            this.Region.Name = "Region";
            this.Region.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Name_Group
            // 
            this.Name_Group.DataPropertyName = "Name_Group";
            this.Name_Group.HeaderText = "Подстанция";
            this.Name_Group.Name = "Name_Group";
            this.Name_Group.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PowerSet
            // 
            this.PowerSet.DataPropertyName = "PowerSet";
            this.PowerSet.HeaderText = "Уст.мощн.";
            this.PowerSet.Name = "PowerSet";
            // 
            // PowerFact
            // 
            this.PowerFact.DataPropertyName = "PowerFact";
            this.PowerFact.HeaderText = "Факт.мощн.";
            this.PowerFact.Name = "PowerFact";
            // 
            // KLoss
            // 
            this.KLoss.DataPropertyName = "KLoss";
            this.KLoss.HeaderText = "Потери";
            this.KLoss.Name = "KLoss";
            // 
            // Regime
            // 
            this.Regime.DataPropertyName = "Regime";
            this.Regime.HeaderText = "Режим";
            this.Regime.Name = "Regime";
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Категория";
            this.CategoryName.Name = "CategoryName";
            // 
            // NetName
            // 
            this.NetName.DataPropertyName = "NetName";
            this.NetName.HeaderText = "Сетевая";
            this.NetName.Name = "NetName";
            // 
            // SaleName
            // 
            this.SaleName.DataPropertyName = "SaleName";
            this.SaleName.HeaderText = "Сбытовая";
            this.SaleName.Name = "SaleName";
            // 
            // AbnNameMinus
            // 
            this.AbnNameMinus.DataPropertyName = "AbnNameMinus";
            this.AbnNameMinus.HeaderText = "Минус";
            this.AbnNameMinus.Name = "AbnNameMinus";
            this.AbnNameMinus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vG_AbnObj";
            this.bindingSource1.DataSource = this.dsObj1;
            // 
            // dsObj1
            // 
            this.dsObj1.DataSetName = "dsObj";
            this.dsObj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Status.DefaultCellStyle = dataGridViewCellStyle2;
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.Width = 125;
            // 
            // Sale
            // 
            this.Sale.DataPropertyName = "Sale";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sale.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sale.HeaderText = "Сбыт";
            this.Sale.Name = "Sale";
            this.Sale.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sale.Width = 150;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Всего объектов";
            // 
            // tBoxObj
            // 
            this.tBoxObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBoxObj.Enabled = false;
            this.tBoxObj.Location = new System.Drawing.Point(121, 534);
            this.tBoxObj.Name = "tBoxObj";
            this.tBoxObj.Size = new System.Drawing.Size(57, 20);
            this.tBoxObj.TabIndex = 3;
            this.tBoxObj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCheck,
            this.btnUncheck,
            this.toolStripSeparator1,
            this.cbStatus,
            this.btnExcel,
            this.btnExportExcel,
            this.toolStripSeparator2,
            this.cmbMaster,
            this.btnChangeBinding,
            this.tbName,
            this.tbCode,
            this.btnCopy,
            this.cmbTariff,
            this.btnChangeTariff});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCheck
            // 
            this.btnCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(23, 22);
            this.btnCheck.Text = "Выбрать все";
            this.btnCheck.ToolTipText = "Выбрать все строки";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnUncheck
            // 
            this.btnUncheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUncheck.Image = ((System.Drawing.Image)(resources.GetObject("btnUncheck.Image")));
            this.btnUncheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUncheck.Name = "btnUncheck";
            this.btnUncheck.Size = new System.Drawing.Size(23, 22);
            this.btnUncheck.Text = "Отменить выбор";
            this.btnUncheck.ToolTipText = "Отменить выбор";
            this.btnUncheck.Click += new System.EventHandler(this.btnUncheck_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cbStatus
            // 
            this.cbStatus.Items.AddRange(new object[] {
            "Активные",
            "Все"});
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 25);
            this.cbStatus.ToolTipText = "Режим отображения";
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(23, 22);
            this.btnExcel.Text = "Экспорт в Excel выбранных записей";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cmbMaster
            // 
            this.cmbMaster.Name = "cmbMaster";
            this.cmbMaster.Size = new System.Drawing.Size(121, 25);
            this.cmbMaster.ToolTipText = "Список мастеров";
            // 
            // btnChangeBinding
            // 
            this.btnChangeBinding.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChangeBinding.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeBinding.Image")));
            this.btnChangeBinding.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeBinding.Name = "btnChangeBinding";
            this.btnChangeBinding.Size = new System.Drawing.Size(23, 22);
            this.btnChangeBinding.Text = "Изменить привязку мастера к объекту";
            this.btnChangeBinding.Click += new System.EventHandler(this.btnChangeBinding_Click);
            // 
            // tbName
            // 
            this.tbName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Margin = new System.Windows.Forms.Padding(1, 0, 5, 0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 25);
            // 
            // tbCode
            // 
            this.tbCode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(50, 25);
            this.tbCode.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCode.ToolTipText = "Введите номер потребителя для копирования";
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(23, 22);
            this.btnCopy.Text = "Скопировать выбранные объекты";
            this.btnCopy.ToolTipText = "Скопировать выбранные объекты";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // cmbTariff
            // 
            this.cmbTariff.Name = "cmbTariff";
            this.cmbTariff.Size = new System.Drawing.Size(300, 25);
            // 
            // btnChangeTariff
            // 
            this.btnChangeTariff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChangeTariff.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeTariff.Image")));
            this.btnChangeTariff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeTariff.Name = "btnChangeTariff";
            this.btnChangeTariff.Size = new System.Drawing.Size(23, 22);
            this.btnChangeTariff.Text = "Изменить тариф";
            this.btnChangeTariff.ToolTipText = "Изменить тариф";
            this.btnChangeTariff.Click += new System.EventHandler(this.btnChangeTariff_Click);
            // 
            // idDataGridViewObj
            // 
            this.idDataGridViewObj.DataPropertyName = "id";
            this.idDataGridViewObj.HeaderText = "id";
            this.idDataGridViewObj.Name = "idDataGridViewObj";
            this.idDataGridViewObj.Visible = false;
            // 
            // masterDataGridViewTextBoxColumn
            // 
            this.masterDataGridViewTextBoxColumn.DataPropertyName = "Master";
            this.masterDataGridViewTextBoxColumn.HeaderText = "Мастер";
            this.masterDataGridViewTextBoxColumn.Name = "masterDataGridViewTextBoxColumn";
            this.masterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.masterDataGridViewTextBoxColumn.Width = 75;
            // 
            // abnNameDataGridViewTextBoxColumn
            // 
            this.abnNameDataGridViewTextBoxColumn.DataPropertyName = "AbnName";
            this.abnNameDataGridViewTextBoxColumn.HeaderText = "Владелец";
            this.abnNameDataGridViewTextBoxColumn.Name = "abnNameDataGridViewTextBoxColumn";
            this.abnNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.abnNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(862, 532);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // bsWorkers
            // 
            this.bsWorkers.DataMember = "vWorkerGroup";
            this.bsWorkers.DataSource = this.dsObj1;
            // 
            // btnReportPower
            // 
            this.btnReportPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportPower.Location = new System.Drawing.Point(673, 532);
            this.btnReportPower.Name = "btnReportPower";
            this.btnReportPower.Size = new System.Drawing.Size(159, 23);
            this.btnReportPower.TabIndex = 6;
            this.btnReportPower.Text = "Резервируемая мощность";
            this.btnReportPower.UseVisualStyleBackColor = true;
            this.btnReportPower.Click += new System.EventHandler(this.btnReportPower_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportExcel.Image = global::Legal.Properties.Resources.xlsx_mac;
            this.btnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(23, 22);
            this.btnExportExcel.Text = "Выгрузка в  Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // FormLObj
            // 
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.btnReportPower);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridViewObj);
            this.Controls.Add(this.tBoxObj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormLObj";
            this.Text = "Объекты";
            this.Load += new System.EventHandler(this.FormLObj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewObj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxObj;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Status;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Sale;
        private Legal.DataSet.dsObj dsObj1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewObj;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn masterDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn abnNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripComboBox cbStatus;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripButton btnCheck;
        private System.Windows.Forms.ToolStripButton btnUncheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox cmbMaster;
        private System.Windows.Forms.ToolStripButton btnChangeBinding;
        private System.Windows.Forms.BindingSource bsWorkers;
        private System.Windows.Forms.ToolStripTextBox tbCode;
        private System.Windows.Forms.ToolStripTextBox tbName;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripComboBox cmbTariff;
        private System.Windows.Forms.ToolStripButton btnChangeTariff;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCell;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn objName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortName;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn TarifName;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn CodeAbonent;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn abnName;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Specialist;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn DateBegin;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn NameObjParent;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn master;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Address;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Region;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Name_Group;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn PowerSet;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn PowerFact;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn KLoss;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Regime;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn CategoryName;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn NetName;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn SaleName;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn AbnNameMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button btnReportPower;
        private System.Windows.Forms.ToolStripButton btnExportExcel;
    }
}
