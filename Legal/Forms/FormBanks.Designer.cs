namespace Legal.Forms
{
    partial class FormBanks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            this.bsBanks = new System.Windows.Forms.BindingSource(this.components);
            this.dgvefBanks = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFull = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFO = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.CORSCHET = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.LOCALSCH = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.contactsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultDGVCBC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UseSelfAccount = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ParentBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankDest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALCSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANKCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TREB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REESTR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ReestrCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pENIDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dOPSCHETDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FILIAL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.KAZN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tsBanks = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBankAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBankDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBankEdit = new System.Windows.Forms.ToolStripButton();
            this.bsBankDefault = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBankDefault = new System.Windows.Forms.DataGridView();
            this.bankIDDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameShortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORSCHETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCALSCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.useSelfAccountDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parentBankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankDestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALCSTATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANKCODEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tREBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEESTRDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reestrCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pENIDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dOPSCHETDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fILIALDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kAZNDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBoxBankDafoult = new System.Windows.Forms.GroupBox();
            this.groupBoxBanks = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNameShort = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNameShort = new System.Windows.Forms.Label();
            this.textBoxZIP = new System.Windows.Forms.TextBox();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelMFO = new System.Windows.Forms.Label();
            this.textBoxMFO = new System.Windows.Forms.TextBox();
            this.labelCORSCHET = new System.Windows.Forms.Label();
            this.textBoxCORSCHET = new System.Windows.Forms.TextBox();
            this.labelLOCALSCH = new System.Windows.Forms.Label();
            this.textBoxLOCALSCH = new System.Windows.Forms.TextBox();
            this.comboBoxParentBank = new System.Windows.Forms.ComboBox();
            this.bsParentBank = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxBankDest = new System.Windows.Forms.ComboBox();
            this.bsBankDest = new System.Windows.Forms.BindingSource(this.components);
            this.labelParent = new System.Windows.Forms.Label();
            this.labelDest = new System.Windows.Forms.Label();
            this.textBoxParentAccount = new System.Windows.Forms.TextBox();
            this.labelParentAccount = new System.Windows.Forms.Label();
            this.checkBoxReestr = new System.Windows.Forms.CheckBox();
            this.checkBoxFilial = new System.Windows.Forms.CheckBox();
            this.checkBoxKAZN = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxTREB = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxReestrCount = new System.Windows.Forms.MaskedTextBox();
            this.labelTREB = new System.Windows.Forms.Label();
            this.labelReestrCount = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxBankDefault = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSaveCancel = new System.Windows.Forms.Button();
            this.checkBoxUseSelfAccount = new System.Windows.Forms.CheckBox();
            this.textBoxPhones = new System.Windows.Forms.TextBox();
            this.labelPhones = new System.Windows.Forms.Label();
            this.contextMenuStripBanks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMode = new System.Windows.Forms.Label();
            this.panelMode = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefBanks)).BeginInit();
            this.tsBanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBankDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankDefault)).BeginInit();
            this.groupBoxBankDafoult.SuspendLayout();
            this.groupBoxBanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsParentBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBankDest)).BeginInit();
            this.contextMenuStripBanks.SuspendLayout();
            this.panelMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsBanks
            // 
            this.bsBanks.DataMember = "tBanks";
            this.bsBanks.DataSource = this.dsAbn;
            // 
            // dgvefBanks
            // 
            this.dgvefBanks.AllowUserToAddRows = false;
            this.dgvefBanks.AllowUserToDeleteRows = false;
            this.dgvefBanks.AutoGenerateColumns = false;
            this.dgvefBanks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvefBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvefBanks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankID,
            this.nameShort,
            this.nameFull,
            this.city,
            this.MFO,
            this.CORSCHET,
            this.LOCALSCH,
            this.contactsDataGridViewTextBoxColumn,
            this.Phones,
            this.DefaultDGVCBC,
            this.UseSelfAccount,
            this.ParentBank,
            this.ParentAccount,
            this.BankDest,
            this.cALCSTATEDataGridViewTextBoxColumn,
            this.ZIP,
            this.bANKCODEDataGridViewTextBoxColumn,
            this.TREB,
            this.REESTR,
            this.ReestrCount,
            this.pENIDataGridViewCheckBoxColumn,
            this.dOPSCHETDataGridViewCheckBoxColumn,
            this.FILIAL,
            this.KAZN,
            this.modeDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.dgvefBanks.DataSource = this.bsBanks;
            this.dgvefBanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvefBanks.Location = new System.Drawing.Point(3, 16);
            this.dgvefBanks.MultiSelect = false;
            this.dgvefBanks.Name = "dgvefBanks";
            this.dgvefBanks.ReadOnly = true;
            this.dgvefBanks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvefBanks.Size = new System.Drawing.Size(972, 251);
            this.dgvefBanks.TabIndex = 0;
            this.dgvefBanks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvefBanks_CellMouseClick);
            // 
            // bankID
            // 
            this.bankID.DataPropertyName = "BankID";
            this.bankID.HeaderText = "BankID";
            this.bankID.Name = "bankID";
            this.bankID.ReadOnly = true;
            this.bankID.Visible = false;
            // 
            // nameShort
            // 
            this.nameShort.DataPropertyName = "NameShort";
            this.nameShort.HeaderText = "NameShort";
            this.nameShort.Name = "nameShort";
            this.nameShort.ReadOnly = true;
            this.nameShort.Visible = false;
            // 
            // nameFull
            // 
            this.nameFull.DataPropertyName = "NameFull";
            this.nameFull.HeaderText = "Наименование";
            this.nameFull.Name = "nameFull";
            this.nameFull.ReadOnly = true;
            this.nameFull.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // city
            // 
            this.city.DataPropertyName = "City";
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Visible = false;
            // 
            // MFO
            // 
            this.MFO.DataPropertyName = "MFO";
            this.MFO.HeaderText = "БИК";
            this.MFO.Name = "MFO";
            this.MFO.ReadOnly = true;
            this.MFO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CORSCHET
            // 
            this.CORSCHET.DataPropertyName = "CORSCHET";
            this.CORSCHET.HeaderText = "Корреспондентский счет";
            this.CORSCHET.Name = "CORSCHET";
            this.CORSCHET.ReadOnly = true;
            this.CORSCHET.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // LOCALSCH
            // 
            this.LOCALSCH.DataPropertyName = "LOCALSCH";
            this.LOCALSCH.HeaderText = "Локальный счет";
            this.LOCALSCH.Name = "LOCALSCH";
            this.LOCALSCH.ReadOnly = true;
            this.LOCALSCH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // contactsDataGridViewTextBoxColumn
            // 
            this.contactsDataGridViewTextBoxColumn.DataPropertyName = "Contacts";
            this.contactsDataGridViewTextBoxColumn.HeaderText = "Contacts";
            this.contactsDataGridViewTextBoxColumn.Name = "contactsDataGridViewTextBoxColumn";
            this.contactsDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactsDataGridViewTextBoxColumn.Visible = false;
            // 
            // Phones
            // 
            this.Phones.DataPropertyName = "Phones";
            this.Phones.HeaderText = "Phones";
            this.Phones.Name = "Phones";
            this.Phones.ReadOnly = true;
            this.Phones.Visible = false;
            // 
            // DefaultDGVCBC
            // 
            this.DefaultDGVCBC.DataPropertyName = "Default";
            this.DefaultDGVCBC.HeaderText = "Default";
            this.DefaultDGVCBC.Name = "DefaultDGVCBC";
            this.DefaultDGVCBC.ReadOnly = true;
            this.DefaultDGVCBC.Visible = false;
            // 
            // UseSelfAccount
            // 
            this.UseSelfAccount.DataPropertyName = "UseSelfAccount";
            this.UseSelfAccount.HeaderText = "UseSelfAccount";
            this.UseSelfAccount.Name = "UseSelfAccount";
            this.UseSelfAccount.ReadOnly = true;
            this.UseSelfAccount.Visible = false;
            // 
            // ParentBank
            // 
            this.ParentBank.DataPropertyName = "ParentBank";
            this.ParentBank.HeaderText = "ParentBank";
            this.ParentBank.Name = "ParentBank";
            this.ParentBank.ReadOnly = true;
            this.ParentBank.Visible = false;
            // 
            // ParentAccount
            // 
            this.ParentAccount.DataPropertyName = "ParentAccount";
            this.ParentAccount.HeaderText = "ParentAccount";
            this.ParentAccount.Name = "ParentAccount";
            this.ParentAccount.ReadOnly = true;
            this.ParentAccount.Visible = false;
            // 
            // BankDest
            // 
            this.BankDest.DataPropertyName = "BankDest";
            this.BankDest.HeaderText = "BankDest";
            this.BankDest.Name = "BankDest";
            this.BankDest.ReadOnly = true;
            this.BankDest.Visible = false;
            // 
            // cALCSTATEDataGridViewTextBoxColumn
            // 
            this.cALCSTATEDataGridViewTextBoxColumn.DataPropertyName = "CALCSTATE";
            this.cALCSTATEDataGridViewTextBoxColumn.HeaderText = "CALCSTATE";
            this.cALCSTATEDataGridViewTextBoxColumn.Name = "cALCSTATEDataGridViewTextBoxColumn";
            this.cALCSTATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cALCSTATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // ZIP
            // 
            this.ZIP.DataPropertyName = "ZIP";
            this.ZIP.HeaderText = "ZIP";
            this.ZIP.Name = "ZIP";
            this.ZIP.ReadOnly = true;
            this.ZIP.Visible = false;
            // 
            // bANKCODEDataGridViewTextBoxColumn
            // 
            this.bANKCODEDataGridViewTextBoxColumn.DataPropertyName = "BANKCODE";
            this.bANKCODEDataGridViewTextBoxColumn.HeaderText = "BANKCODE";
            this.bANKCODEDataGridViewTextBoxColumn.Name = "bANKCODEDataGridViewTextBoxColumn";
            this.bANKCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bANKCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // TREB
            // 
            this.TREB.DataPropertyName = "TREB";
            this.TREB.HeaderText = "TREB";
            this.TREB.Name = "TREB";
            this.TREB.ReadOnly = true;
            this.TREB.Visible = false;
            // 
            // REESTR
            // 
            this.REESTR.DataPropertyName = "REESTR";
            this.REESTR.HeaderText = "REESTR";
            this.REESTR.Name = "REESTR";
            this.REESTR.ReadOnly = true;
            this.REESTR.Visible = false;
            // 
            // ReestrCount
            // 
            this.ReestrCount.DataPropertyName = "ReestrCount";
            this.ReestrCount.HeaderText = "ReestrCount";
            this.ReestrCount.Name = "ReestrCount";
            this.ReestrCount.ReadOnly = true;
            this.ReestrCount.Visible = false;
            // 
            // pENIDataGridViewCheckBoxColumn
            // 
            this.pENIDataGridViewCheckBoxColumn.DataPropertyName = "PENI";
            this.pENIDataGridViewCheckBoxColumn.HeaderText = "PENI";
            this.pENIDataGridViewCheckBoxColumn.Name = "pENIDataGridViewCheckBoxColumn";
            this.pENIDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pENIDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dOPSCHETDataGridViewCheckBoxColumn
            // 
            this.dOPSCHETDataGridViewCheckBoxColumn.DataPropertyName = "DOPSCHET";
            this.dOPSCHETDataGridViewCheckBoxColumn.HeaderText = "DOPSCHET";
            this.dOPSCHETDataGridViewCheckBoxColumn.Name = "dOPSCHETDataGridViewCheckBoxColumn";
            this.dOPSCHETDataGridViewCheckBoxColumn.ReadOnly = true;
            this.dOPSCHETDataGridViewCheckBoxColumn.Visible = false;
            // 
            // FILIAL
            // 
            this.FILIAL.DataPropertyName = "FILIAL";
            this.FILIAL.HeaderText = "FILIAL";
            this.FILIAL.Name = "FILIAL";
            this.FILIAL.ReadOnly = true;
            this.FILIAL.Visible = false;
            // 
            // KAZN
            // 
            this.KAZN.DataPropertyName = "KAZN";
            this.KAZN.HeaderText = "KAZN";
            this.KAZN.Name = "KAZN";
            this.KAZN.ReadOnly = true;
            this.KAZN.Visible = false;
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.DataPropertyName = "Mode";
            this.modeDataGridViewTextBoxColumn.HeaderText = "Mode";
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            this.modeDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.deletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // tsBanks
            // 
            this.tsBanks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBankAdd,
            this.toolStripButtonBankDel,
            this.toolStripButtonBankEdit});
            this.tsBanks.Location = new System.Drawing.Point(0, 0);
            this.tsBanks.Name = "tsBanks";
            this.tsBanks.Size = new System.Drawing.Size(984, 25);
            this.tsBanks.TabIndex = 1;
            this.tsBanks.Text = "toolStrip1";
            // 
            // toolStripButtonBankAdd
            // 
            this.toolStripButtonBankAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBankAdd.Image = global::Legal.Properties.Resources.bank_plus;
            this.toolStripButtonBankAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBankAdd.Name = "toolStripButtonBankAdd";
            this.toolStripButtonBankAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBankAdd.Text = "Добавить банк";
            this.toolStripButtonBankAdd.Click += new System.EventHandler(this.toolStripButtonBankAdd_Click);
            // 
            // toolStripButtonBankDel
            // 
            this.toolStripButtonBankDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBankDel.Image = global::Legal.Properties.Resources.bank_minus;
            this.toolStripButtonBankDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBankDel.Name = "toolStripButtonBankDel";
            this.toolStripButtonBankDel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBankDel.Text = "Удалить банк";
            this.toolStripButtonBankDel.Click += new System.EventHandler(this.toolStripButtonBankDel_Click);
            // 
            // toolStripButtonBankEdit
            // 
            this.toolStripButtonBankEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBankEdit.Image = global::Legal.Properties.Resources.bank_pencil;
            this.toolStripButtonBankEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBankEdit.Name = "toolStripButtonBankEdit";
            this.toolStripButtonBankEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBankEdit.Text = "Редактировать банк";
            this.toolStripButtonBankEdit.Click += new System.EventHandler(this.toolStripButtonBankEdit_Click);
            // 
            // bsBankDefault
            // 
            this.bsBankDefault.DataMember = "tBanksDafault";
            this.bsBankDefault.DataSource = this.dsAbn;
            // 
            // dgvBankDefault
            // 
            this.dgvBankDefault.AllowUserToAddRows = false;
            this.dgvBankDefault.AllowUserToDeleteRows = false;
            this.dgvBankDefault.AutoGenerateColumns = false;
            this.dgvBankDefault.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBankDefault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankDefault.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankIDDefault,
            this.nameShortDataGridViewTextBoxColumn,
            this.nameFullDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.mFODataGridViewTextBoxColumn,
            this.cORSCHETDataGridViewTextBoxColumn,
            this.lOCALSCHDataGridViewTextBoxColumn,
            this.contactsDataGridViewTextBoxColumn1,
            this.phonesDataGridViewTextBoxColumn1,
            this.defaultDataGridViewCheckBoxColumn,
            this.useSelfAccountDataGridViewCheckBoxColumn,
            this.parentBankDataGridViewTextBoxColumn,
            this.parentAccountDataGridViewTextBoxColumn,
            this.bankDestDataGridViewTextBoxColumn,
            this.cALCSTATEDataGridViewTextBoxColumn1,
            this.zIPDataGridViewTextBoxColumn,
            this.bANKCODEDataGridViewTextBoxColumn1,
            this.tREBDataGridViewTextBoxColumn,
            this.rEESTRDataGridViewCheckBoxColumn,
            this.reestrCountDataGridViewTextBoxColumn,
            this.pENIDataGridViewCheckBoxColumn1,
            this.dOPSCHETDataGridViewCheckBoxColumn1,
            this.fILIALDataGridViewCheckBoxColumn,
            this.kAZNDataGridViewCheckBoxColumn,
            this.modeDataGridViewTextBoxColumn1,
            this.deletedDataGridViewCheckBoxColumn1});
            this.dgvBankDefault.DataSource = this.bsBankDefault;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBankDefault.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBankDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankDefault.Location = new System.Drawing.Point(3, 16);
            this.dgvBankDefault.MultiSelect = false;
            this.dgvBankDefault.Name = "dgvBankDefault";
            this.dgvBankDefault.ReadOnly = true;
            this.dgvBankDefault.RowHeadersWidth = 5;
            this.dgvBankDefault.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBankDefault.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankDefault.Size = new System.Drawing.Size(978, 47);
            this.dgvBankDefault.TabIndex = 2;
            this.dgvBankDefault.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBankDefault_CellMouseClick);
            // 
            // bankIDDefault
            // 
            this.bankIDDefault.DataPropertyName = "BankID";
            this.bankIDDefault.HeaderText = "BankID";
            this.bankIDDefault.Name = "bankIDDefault";
            this.bankIDDefault.ReadOnly = true;
            this.bankIDDefault.Visible = false;
            // 
            // nameShortDataGridViewTextBoxColumn
            // 
            this.nameShortDataGridViewTextBoxColumn.DataPropertyName = "NameShort";
            this.nameShortDataGridViewTextBoxColumn.HeaderText = "NameShort";
            this.nameShortDataGridViewTextBoxColumn.Name = "nameShortDataGridViewTextBoxColumn";
            this.nameShortDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameShortDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameFullDataGridViewTextBoxColumn
            // 
            this.nameFullDataGridViewTextBoxColumn.DataPropertyName = "NameFull";
            this.nameFullDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameFullDataGridViewTextBoxColumn.Name = "nameFullDataGridViewTextBoxColumn";
            this.nameFullDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Visible = false;
            // 
            // mFODataGridViewTextBoxColumn
            // 
            this.mFODataGridViewTextBoxColumn.DataPropertyName = "MFO";
            this.mFODataGridViewTextBoxColumn.HeaderText = "БИК";
            this.mFODataGridViewTextBoxColumn.Name = "mFODataGridViewTextBoxColumn";
            this.mFODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cORSCHETDataGridViewTextBoxColumn
            // 
            this.cORSCHETDataGridViewTextBoxColumn.DataPropertyName = "CORSCHET";
            this.cORSCHETDataGridViewTextBoxColumn.HeaderText = "Корреспондентский счет";
            this.cORSCHETDataGridViewTextBoxColumn.Name = "cORSCHETDataGridViewTextBoxColumn";
            this.cORSCHETDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lOCALSCHDataGridViewTextBoxColumn
            // 
            this.lOCALSCHDataGridViewTextBoxColumn.DataPropertyName = "LOCALSCH";
            this.lOCALSCHDataGridViewTextBoxColumn.HeaderText = "Локальный счет";
            this.lOCALSCHDataGridViewTextBoxColumn.Name = "lOCALSCHDataGridViewTextBoxColumn";
            this.lOCALSCHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactsDataGridViewTextBoxColumn1
            // 
            this.contactsDataGridViewTextBoxColumn1.DataPropertyName = "Contacts";
            this.contactsDataGridViewTextBoxColumn1.HeaderText = "Contacts";
            this.contactsDataGridViewTextBoxColumn1.Name = "contactsDataGridViewTextBoxColumn1";
            this.contactsDataGridViewTextBoxColumn1.ReadOnly = true;
            this.contactsDataGridViewTextBoxColumn1.Visible = false;
            // 
            // phonesDataGridViewTextBoxColumn1
            // 
            this.phonesDataGridViewTextBoxColumn1.DataPropertyName = "Phones";
            this.phonesDataGridViewTextBoxColumn1.HeaderText = "Phones";
            this.phonesDataGridViewTextBoxColumn1.Name = "phonesDataGridViewTextBoxColumn1";
            this.phonesDataGridViewTextBoxColumn1.ReadOnly = true;
            this.phonesDataGridViewTextBoxColumn1.Visible = false;
            // 
            // defaultDataGridViewCheckBoxColumn
            // 
            this.defaultDataGridViewCheckBoxColumn.DataPropertyName = "Default";
            this.defaultDataGridViewCheckBoxColumn.HeaderText = "Default";
            this.defaultDataGridViewCheckBoxColumn.Name = "defaultDataGridViewCheckBoxColumn";
            this.defaultDataGridViewCheckBoxColumn.ReadOnly = true;
            this.defaultDataGridViewCheckBoxColumn.Visible = false;
            // 
            // useSelfAccountDataGridViewCheckBoxColumn
            // 
            this.useSelfAccountDataGridViewCheckBoxColumn.DataPropertyName = "UseSelfAccount";
            this.useSelfAccountDataGridViewCheckBoxColumn.HeaderText = "UseSelfAccount";
            this.useSelfAccountDataGridViewCheckBoxColumn.Name = "useSelfAccountDataGridViewCheckBoxColumn";
            this.useSelfAccountDataGridViewCheckBoxColumn.ReadOnly = true;
            this.useSelfAccountDataGridViewCheckBoxColumn.Visible = false;
            // 
            // parentBankDataGridViewTextBoxColumn
            // 
            this.parentBankDataGridViewTextBoxColumn.DataPropertyName = "ParentBank";
            this.parentBankDataGridViewTextBoxColumn.HeaderText = "ParentBank";
            this.parentBankDataGridViewTextBoxColumn.Name = "parentBankDataGridViewTextBoxColumn";
            this.parentBankDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentBankDataGridViewTextBoxColumn.Visible = false;
            // 
            // parentAccountDataGridViewTextBoxColumn
            // 
            this.parentAccountDataGridViewTextBoxColumn.DataPropertyName = "ParentAccount";
            this.parentAccountDataGridViewTextBoxColumn.HeaderText = "ParentAccount";
            this.parentAccountDataGridViewTextBoxColumn.Name = "parentAccountDataGridViewTextBoxColumn";
            this.parentAccountDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentAccountDataGridViewTextBoxColumn.Visible = false;
            // 
            // bankDestDataGridViewTextBoxColumn
            // 
            this.bankDestDataGridViewTextBoxColumn.DataPropertyName = "BankDest";
            this.bankDestDataGridViewTextBoxColumn.HeaderText = "BankDest";
            this.bankDestDataGridViewTextBoxColumn.Name = "bankDestDataGridViewTextBoxColumn";
            this.bankDestDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankDestDataGridViewTextBoxColumn.Visible = false;
            // 
            // cALCSTATEDataGridViewTextBoxColumn1
            // 
            this.cALCSTATEDataGridViewTextBoxColumn1.DataPropertyName = "CALCSTATE";
            this.cALCSTATEDataGridViewTextBoxColumn1.HeaderText = "CALCSTATE";
            this.cALCSTATEDataGridViewTextBoxColumn1.Name = "cALCSTATEDataGridViewTextBoxColumn1";
            this.cALCSTATEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cALCSTATEDataGridViewTextBoxColumn1.Visible = false;
            // 
            // zIPDataGridViewTextBoxColumn
            // 
            this.zIPDataGridViewTextBoxColumn.DataPropertyName = "ZIP";
            this.zIPDataGridViewTextBoxColumn.HeaderText = "ZIP";
            this.zIPDataGridViewTextBoxColumn.Name = "zIPDataGridViewTextBoxColumn";
            this.zIPDataGridViewTextBoxColumn.ReadOnly = true;
            this.zIPDataGridViewTextBoxColumn.Visible = false;
            // 
            // bANKCODEDataGridViewTextBoxColumn1
            // 
            this.bANKCODEDataGridViewTextBoxColumn1.DataPropertyName = "BANKCODE";
            this.bANKCODEDataGridViewTextBoxColumn1.HeaderText = "BANKCODE";
            this.bANKCODEDataGridViewTextBoxColumn1.Name = "bANKCODEDataGridViewTextBoxColumn1";
            this.bANKCODEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bANKCODEDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tREBDataGridViewTextBoxColumn
            // 
            this.tREBDataGridViewTextBoxColumn.DataPropertyName = "TREB";
            this.tREBDataGridViewTextBoxColumn.HeaderText = "TREB";
            this.tREBDataGridViewTextBoxColumn.Name = "tREBDataGridViewTextBoxColumn";
            this.tREBDataGridViewTextBoxColumn.ReadOnly = true;
            this.tREBDataGridViewTextBoxColumn.Visible = false;
            // 
            // rEESTRDataGridViewCheckBoxColumn
            // 
            this.rEESTRDataGridViewCheckBoxColumn.DataPropertyName = "REESTR";
            this.rEESTRDataGridViewCheckBoxColumn.HeaderText = "REESTR";
            this.rEESTRDataGridViewCheckBoxColumn.Name = "rEESTRDataGridViewCheckBoxColumn";
            this.rEESTRDataGridViewCheckBoxColumn.ReadOnly = true;
            this.rEESTRDataGridViewCheckBoxColumn.Visible = false;
            // 
            // reestrCountDataGridViewTextBoxColumn
            // 
            this.reestrCountDataGridViewTextBoxColumn.DataPropertyName = "ReestrCount";
            this.reestrCountDataGridViewTextBoxColumn.HeaderText = "ReestrCount";
            this.reestrCountDataGridViewTextBoxColumn.Name = "reestrCountDataGridViewTextBoxColumn";
            this.reestrCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.reestrCountDataGridViewTextBoxColumn.Visible = false;
            // 
            // pENIDataGridViewCheckBoxColumn1
            // 
            this.pENIDataGridViewCheckBoxColumn1.DataPropertyName = "PENI";
            this.pENIDataGridViewCheckBoxColumn1.HeaderText = "PENI";
            this.pENIDataGridViewCheckBoxColumn1.Name = "pENIDataGridViewCheckBoxColumn1";
            this.pENIDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.pENIDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dOPSCHETDataGridViewCheckBoxColumn1
            // 
            this.dOPSCHETDataGridViewCheckBoxColumn1.DataPropertyName = "DOPSCHET";
            this.dOPSCHETDataGridViewCheckBoxColumn1.HeaderText = "DOPSCHET";
            this.dOPSCHETDataGridViewCheckBoxColumn1.Name = "dOPSCHETDataGridViewCheckBoxColumn1";
            this.dOPSCHETDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dOPSCHETDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // fILIALDataGridViewCheckBoxColumn
            // 
            this.fILIALDataGridViewCheckBoxColumn.DataPropertyName = "FILIAL";
            this.fILIALDataGridViewCheckBoxColumn.HeaderText = "FILIAL";
            this.fILIALDataGridViewCheckBoxColumn.Name = "fILIALDataGridViewCheckBoxColumn";
            this.fILIALDataGridViewCheckBoxColumn.ReadOnly = true;
            this.fILIALDataGridViewCheckBoxColumn.Visible = false;
            // 
            // kAZNDataGridViewCheckBoxColumn
            // 
            this.kAZNDataGridViewCheckBoxColumn.DataPropertyName = "KAZN";
            this.kAZNDataGridViewCheckBoxColumn.HeaderText = "KAZN";
            this.kAZNDataGridViewCheckBoxColumn.Name = "kAZNDataGridViewCheckBoxColumn";
            this.kAZNDataGridViewCheckBoxColumn.ReadOnly = true;
            this.kAZNDataGridViewCheckBoxColumn.Visible = false;
            // 
            // modeDataGridViewTextBoxColumn1
            // 
            this.modeDataGridViewTextBoxColumn1.DataPropertyName = "Mode";
            this.modeDataGridViewTextBoxColumn1.HeaderText = "Mode";
            this.modeDataGridViewTextBoxColumn1.Name = "modeDataGridViewTextBoxColumn1";
            this.modeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.modeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // deletedDataGridViewCheckBoxColumn1
            // 
            this.deletedDataGridViewCheckBoxColumn1.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn1.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn1.Name = "deletedDataGridViewCheckBoxColumn1";
            this.deletedDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.deletedDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // groupBoxBankDafoult
            // 
            this.groupBoxBankDafoult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBankDafoult.Controls.Add(this.dgvBankDefault);
            this.groupBoxBankDafoult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxBankDafoult.Location = new System.Drawing.Point(0, 28);
            this.groupBoxBankDafoult.Name = "groupBoxBankDafoult";
            this.groupBoxBankDafoult.Size = new System.Drawing.Size(984, 66);
            this.groupBoxBankDafoult.TabIndex = 3;
            this.groupBoxBankDafoult.TabStop = false;
            this.groupBoxBankDafoult.Text = "Банк по умолчанию";
            // 
            // groupBoxBanks
            // 
            this.groupBoxBanks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBanks.Controls.Add(this.panelMode);
            this.groupBoxBanks.Controls.Add(this.dgvefBanks);
            this.groupBoxBanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxBanks.Location = new System.Drawing.Point(3, 100);
            this.groupBoxBanks.Name = "groupBoxBanks";
            this.groupBoxBanks.Size = new System.Drawing.Size(978, 270);
            this.groupBoxBanks.TabIndex = 4;
            this.groupBoxBanks.TabStop = false;
            this.groupBoxBanks.Text = "Банки";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(142, 376);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(382, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxNameShort
            // 
            this.textBoxNameShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNameShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameShort.Location = new System.Drawing.Point(707, 376);
            this.textBoxNameShort.Name = "textBoxNameShort";
            this.textBoxNameShort.Size = new System.Drawing.Size(271, 20);
            this.textBoxNameShort.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(3, 379);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(141, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Полное наименование";
            // 
            // labelNameShort
            // 
            this.labelNameShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNameShort.AutoSize = true;
            this.labelNameShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameShort.Location = new System.Drawing.Point(530, 379);
            this.labelNameShort.Name = "labelNameShort";
            this.labelNameShort.Size = new System.Drawing.Size(178, 13);
            this.labelNameShort.TabIndex = 8;
            this.labelNameShort.Text = "Сокращенное наименование";
            // 
            // textBoxZIP
            // 
            this.textBoxZIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxZIP.Location = new System.Drawing.Point(54, 402);
            this.textBoxZIP.Name = "textBoxZIP";
            this.textBoxZIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxZIP.TabIndex = 9;
            // 
            // labelZip
            // 
            this.labelZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelZip.AutoSize = true;
            this.labelZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZip.Location = new System.Drawing.Point(3, 406);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(51, 13);
            this.labelZip.TabIndex = 10;
            this.labelZip.Text = "Индекс";
            // 
            // labelCity
            // 
            this.labelCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.Location = new System.Drawing.Point(170, 406);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(42, 13);
            this.labelCity.TabIndex = 11;
            this.labelCity.Text = "Город";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(213, 402);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(128, 20);
            this.textBoxCity.TabIndex = 12;
            // 
            // labelMFO
            // 
            this.labelMFO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMFO.AutoSize = true;
            this.labelMFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMFO.Location = new System.Drawing.Point(348, 405);
            this.labelMFO.Name = "labelMFO";
            this.labelMFO.Size = new System.Drawing.Size(32, 13);
            this.labelMFO.TabIndex = 13;
            this.labelMFO.Text = "БИК";
            // 
            // textBoxMFO
            // 
            this.textBoxMFO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMFO.Location = new System.Drawing.Point(384, 402);
            this.textBoxMFO.Name = "textBoxMFO";
            this.textBoxMFO.Size = new System.Drawing.Size(140, 20);
            this.textBoxMFO.TabIndex = 14;
            // 
            // labelCORSCHET
            // 
            this.labelCORSCHET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCORSCHET.AutoSize = true;
            this.labelCORSCHET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCORSCHET.Location = new System.Drawing.Point(531, 406);
            this.labelCORSCHET.Name = "labelCORSCHET";
            this.labelCORSCHET.Size = new System.Drawing.Size(37, 13);
            this.labelCORSCHET.TabIndex = 15;
            this.labelCORSCHET.Text = "к/сч.";
            // 
            // textBoxCORSCHET
            // 
            this.textBoxCORSCHET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCORSCHET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCORSCHET.Location = new System.Drawing.Point(569, 402);
            this.textBoxCORSCHET.Name = "textBoxCORSCHET";
            this.textBoxCORSCHET.Size = new System.Drawing.Size(186, 20);
            this.textBoxCORSCHET.TabIndex = 16;
            // 
            // labelLOCALSCH
            // 
            this.labelLOCALSCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLOCALSCH.AutoSize = true;
            this.labelLOCALSCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLOCALSCH.Location = new System.Drawing.Point(761, 406);
            this.labelLOCALSCH.Name = "labelLOCALSCH";
            this.labelLOCALSCH.Size = new System.Drawing.Size(37, 13);
            this.labelLOCALSCH.TabIndex = 17;
            this.labelLOCALSCH.Text = "р/сч.";
            // 
            // textBoxLOCALSCH
            // 
            this.textBoxLOCALSCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLOCALSCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLOCALSCH.Location = new System.Drawing.Point(800, 401);
            this.textBoxLOCALSCH.Name = "textBoxLOCALSCH";
            this.textBoxLOCALSCH.Size = new System.Drawing.Size(178, 20);
            this.textBoxLOCALSCH.TabIndex = 18;
            // 
            // comboBoxParentBank
            // 
            this.comboBoxParentBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxParentBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxParentBank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxParentBank.DataSource = this.bsParentBank;
            this.comboBoxParentBank.DisplayMember = "NameFull";
            this.comboBoxParentBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxParentBank.FormattingEnabled = true;
            this.comboBoxParentBank.Location = new System.Drawing.Point(83, 437);
            this.comboBoxParentBank.Name = "comboBoxParentBank";
            this.comboBoxParentBank.Size = new System.Drawing.Size(441, 21);
            this.comboBoxParentBank.TabIndex = 19;
            this.comboBoxParentBank.ValueMember = "BankID";
            // 
            // bsParentBank
            // 
            this.bsParentBank.DataMember = "tBanks";
            this.bsParentBank.DataSource = this.dsAbn;
            // 
            // comboBoxBankDest
            // 
            this.comboBoxBankDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxBankDest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBankDest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBankDest.DataSource = this.bsBankDest;
            this.comboBoxBankDest.DisplayMember = "NameFull";
            this.comboBoxBankDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxBankDest.FormattingEnabled = true;
            this.comboBoxBankDest.Location = new System.Drawing.Point(83, 475);
            this.comboBoxBankDest.Name = "comboBoxBankDest";
            this.comboBoxBankDest.Size = new System.Drawing.Size(441, 21);
            this.comboBoxBankDest.TabIndex = 20;
            this.comboBoxBankDest.ValueMember = "BankID";
            // 
            // bsBankDest
            // 
            this.bsBankDest.DataMember = "tBanks";
            this.bsBankDest.DataSource = this.dsAbn;
            // 
            // labelParent
            // 
            this.labelParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelParent.AutoSize = true;
            this.labelParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParent.Location = new System.Drawing.Point(6, 440);
            this.labelParent.Name = "labelParent";
            this.labelParent.Size = new System.Drawing.Size(71, 13);
            this.labelParent.TabIndex = 21;
            this.labelParent.Text = "Филиал от";
            // 
            // labelDest
            // 
            this.labelDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDest.AutoSize = true;
            this.labelDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDest.Location = new System.Drawing.Point(3, 478);
            this.labelDest.Name = "labelDest";
            this.labelDest.Size = new System.Drawing.Size(77, 13);
            this.labelDest.TabIndex = 22;
            this.labelDest.Text = " Выстав. из";
            // 
            // textBoxParentAccount
            // 
            this.textBoxParentAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxParentAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxParentAccount.Location = new System.Drawing.Point(569, 437);
            this.textBoxParentAccount.Name = "textBoxParentAccount";
            this.textBoxParentAccount.Size = new System.Drawing.Size(186, 20);
            this.textBoxParentAccount.TabIndex = 23;
            // 
            // labelParentAccount
            // 
            this.labelParentAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelParentAccount.AutoSize = true;
            this.labelParentAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParentAccount.Location = new System.Drawing.Point(530, 440);
            this.labelParentAccount.Name = "labelParentAccount";
            this.labelParentAccount.Size = new System.Drawing.Size(37, 13);
            this.labelParentAccount.TabIndex = 24;
            this.labelParentAccount.Text = "л/сч.";
            // 
            // checkBoxReestr
            // 
            this.checkBoxReestr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxReestr.AutoSize = true;
            this.checkBoxReestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxReestr.Location = new System.Drawing.Point(302, 508);
            this.checkBoxReestr.Name = "checkBoxReestr";
            this.checkBoxReestr.Size = new System.Drawing.Size(222, 17);
            this.checkBoxReestr.TabIndex = 25;
            this.checkBoxReestr.Text = "Формировать отдельный реестр";
            this.checkBoxReestr.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilial
            // 
            this.checkBoxFilial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxFilial.AutoSize = true;
            this.checkBoxFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxFilial.Location = new System.Drawing.Point(569, 479);
            this.checkBoxFilial.Name = "checkBoxFilial";
            this.checkBoxFilial.Size = new System.Drawing.Size(400, 17);
            this.checkBoxFilial.TabIndex = 26;
            this.checkBoxFilial.Text = "Банк имеет филиалы (спец. алгоритм фомирования реестров)";
            this.checkBoxFilial.UseVisualStyleBackColor = true;
            // 
            // checkBoxKAZN
            // 
            this.checkBoxKAZN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxKAZN.AutoSize = true;
            this.checkBoxKAZN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxKAZN.Location = new System.Drawing.Point(569, 508);
            this.checkBoxKAZN.Name = "checkBoxKAZN";
            this.checkBoxKAZN.Size = new System.Drawing.Size(364, 17);
            this.checkBoxKAZN.TabIndex = 27;
            this.checkBoxKAZN.Text = "Казначейство (спец. алгоритм формирования реестров)";
            this.checkBoxKAZN.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxTREB
            // 
            this.maskedTextBoxTREB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBoxTREB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxTREB.Location = new System.Drawing.Point(122, 506);
            this.maskedTextBoxTREB.Mask = "00";
            this.maskedTextBoxTREB.Name = "maskedTextBoxTREB";
            this.maskedTextBoxTREB.Size = new System.Drawing.Size(22, 20);
            this.maskedTextBoxTREB.TabIndex = 28;
            // 
            // maskedTextBoxReestrCount
            // 
            this.maskedTextBoxReestrCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBoxReestrCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxReestrCount.Location = new System.Drawing.Point(274, 506);
            this.maskedTextBoxReestrCount.Mask = "00";
            this.maskedTextBoxReestrCount.Name = "maskedTextBoxReestrCount";
            this.maskedTextBoxReestrCount.Size = new System.Drawing.Size(22, 20);
            this.maskedTextBoxReestrCount.TabIndex = 29;
            // 
            // labelTREB
            // 
            this.labelTREB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTREB.AutoSize = true;
            this.labelTREB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTREB.Location = new System.Drawing.Point(6, 509);
            this.labelTREB.Name = "labelTREB";
            this.labelTREB.Size = new System.Drawing.Size(120, 13);
            this.labelTREB.TabIndex = 30;
            this.labelTREB.Text = "Кол-во требований";
            // 
            // labelReestrCount
            // 
            this.labelReestrCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelReestrCount.AutoSize = true;
            this.labelReestrCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReestrCount.Location = new System.Drawing.Point(170, 509);
            this.labelReestrCount.Name = "labelReestrCount";
            this.labelReestrCount.Size = new System.Drawing.Size(106, 13);
            this.labelReestrCount.TabIndex = 31;
            this.labelReestrCount.Text = "Кол-во реестров";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(878, 572);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "Выход";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxBankDefault
            // 
            this.checkBoxBankDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxBankDefault.AutoSize = true;
            this.checkBoxBankDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBankDefault.Location = new System.Drawing.Point(569, 540);
            this.checkBoxBankDefault.Name = "checkBoxBankDefault";
            this.checkBoxBankDefault.Size = new System.Drawing.Size(227, 17);
            this.checkBoxBankDefault.TabIndex = 36;
            this.checkBoxBankDefault.Text = "Банк по умолчанию (только один)";
            this.checkBoxBankDefault.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(666, 572);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 37;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSaveCancel
            // 
            this.buttonSaveCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveCancel.Location = new System.Drawing.Point(772, 572);
            this.buttonSaveCancel.Name = "buttonSaveCancel";
            this.buttonSaveCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveCancel.TabIndex = 38;
            this.buttonSaveCancel.Text = "Отмена";
            this.buttonSaveCancel.UseVisualStyleBackColor = true;
            this.buttonSaveCancel.Click += new System.EventHandler(this.buttonSaveCancel_Click);
            // 
            // checkBoxUseSelfAccount
            // 
            this.checkBoxUseSelfAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxUseSelfAccount.AutoSize = true;
            this.checkBoxUseSelfAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUseSelfAccount.Location = new System.Drawing.Point(800, 427);
            this.checkBoxUseSelfAccount.Name = "checkBoxUseSelfAccount";
            this.checkBoxUseSelfAccount.Size = new System.Drawing.Size(180, 17);
            this.checkBoxUseSelfAccount.TabIndex = 39;
            this.checkBoxUseSelfAccount.Text = "выставлять на свой р/сч.";
            this.checkBoxUseSelfAccount.UseVisualStyleBackColor = true;
            // 
            // textBoxPhones
            // 
            this.textBoxPhones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhones.Location = new System.Drawing.Point(83, 538);
            this.textBoxPhones.Name = "textBoxPhones";
            this.textBoxPhones.Size = new System.Drawing.Size(441, 20);
            this.textBoxPhones.TabIndex = 40;
            // 
            // labelPhones
            // 
            this.labelPhones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPhones.AutoSize = true;
            this.labelPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhones.Location = new System.Drawing.Point(9, 541);
            this.labelPhones.Name = "labelPhones";
            this.labelPhones.Size = new System.Drawing.Size(68, 13);
            this.labelPhones.TabIndex = 41;
            this.labelPhones.Text = "Телефоны";
            // 
            // contextMenuStripBanks
            // 
            this.contextMenuStripBanks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBankToolStripMenuItem,
            this.DelBankToolStripMenuItem,
            this.EditBankToolStripMenuItem});
            this.contextMenuStripBanks.Name = "contextMenuStripBanks";
            this.contextMenuStripBanks.Size = new System.Drawing.Size(155, 70);
            // 
            // AddBankToolStripMenuItem
            // 
            this.AddBankToolStripMenuItem.Image = global::Legal.Properties.Resources.bank_plus;
            this.AddBankToolStripMenuItem.Name = "AddBankToolStripMenuItem";
            this.AddBankToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AddBankToolStripMenuItem.Text = "Добавить";
            this.AddBankToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonBankAdd_Click);
            // 
            // DelBankToolStripMenuItem
            // 
            this.DelBankToolStripMenuItem.Image = global::Legal.Properties.Resources.bank_minus;
            this.DelBankToolStripMenuItem.Name = "DelBankToolStripMenuItem";
            this.DelBankToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.DelBankToolStripMenuItem.Text = "Удалить";
            this.DelBankToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonBankDel_Click);
            // 
            // EditBankToolStripMenuItem
            // 
            this.EditBankToolStripMenuItem.Image = global::Legal.Properties.Resources.bank_pencil;
            this.EditBankToolStripMenuItem.Name = "EditBankToolStripMenuItem";
            this.EditBankToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.EditBankToolStripMenuItem.Text = "Редактировать";
            this.EditBankToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonBankEdit_Click);
            // 
            // labelMode
            // 
            this.labelMode.BackColor = System.Drawing.Color.Transparent;
            this.labelMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMode.Location = new System.Drawing.Point(0, 0);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(654, 56);
            this.labelMode.TabIndex = 0;
            this.labelMode.Text = "labelMode";
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMode
            // 
            this.panelMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMode.BackColor = System.Drawing.Color.Transparent;
            this.panelMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMode.Controls.Add(this.labelMode);
            this.panelMode.Location = new System.Drawing.Point(183, 115);
            this.panelMode.Name = "panelMode";
            this.panelMode.Size = new System.Drawing.Size(654, 56);
            this.panelMode.TabIndex = 1;
            // 
            // FormBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.labelPhones);
            this.Controls.Add(this.textBoxPhones);
            this.Controls.Add(this.checkBoxUseSelfAccount);
            this.Controls.Add(this.buttonSaveCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxBankDefault);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelReestrCount);
            this.Controls.Add(this.labelTREB);
            this.Controls.Add(this.maskedTextBoxReestrCount);
            this.Controls.Add(this.maskedTextBoxTREB);
            this.Controls.Add(this.checkBoxKAZN);
            this.Controls.Add(this.checkBoxFilial);
            this.Controls.Add(this.checkBoxReestr);
            this.Controls.Add(this.labelParentAccount);
            this.Controls.Add(this.textBoxParentAccount);
            this.Controls.Add(this.labelDest);
            this.Controls.Add(this.labelParent);
            this.Controls.Add(this.comboBoxBankDest);
            this.Controls.Add(this.comboBoxParentBank);
            this.Controls.Add(this.textBoxLOCALSCH);
            this.Controls.Add(this.labelLOCALSCH);
            this.Controls.Add(this.textBoxCORSCHET);
            this.Controls.Add(this.labelCORSCHET);
            this.Controls.Add(this.textBoxMFO);
            this.Controls.Add(this.labelMFO);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.textBoxZIP);
            this.Controls.Add(this.labelNameShort);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxNameShort);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.groupBoxBanks);
            this.Controls.Add(this.groupBoxBankDafoult);
            this.Controls.Add(this.tsBanks);
            this.Name = "FormBanks";
            this.Text = "Банки";
            this.Load += new System.EventHandler(this.FormBanks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefBanks)).EndInit();
            this.tsBanks.ResumeLayout(false);
            this.tsBanks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBankDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankDefault)).EndInit();
            this.groupBoxBankDafoult.ResumeLayout(false);
            this.groupBoxBanks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsParentBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBankDest)).EndInit();
            this.contextMenuStripBanks.ResumeLayout(false);
            this.panelMode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet.DataSetAbn dsAbn;
        private System.Windows.Forms.BindingSource bsBanks;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvefBanks;
        private System.Windows.Forms.ToolStrip tsBanks;
        private System.Windows.Forms.BindingSource bsBankDefault;
        private System.Windows.Forms.DataGridView dgvBankDefault;
        private System.Windows.Forms.GroupBox groupBoxBankDafoult;
        private System.Windows.Forms.GroupBox groupBoxBanks;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNameShort;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNameShort;
        private System.Windows.Forms.TextBox textBoxZIP;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelMFO;
        private System.Windows.Forms.TextBox textBoxMFO;
        private System.Windows.Forms.Label labelCORSCHET;
        private System.Windows.Forms.TextBox textBoxCORSCHET;
        private System.Windows.Forms.Label labelLOCALSCH;
        private System.Windows.Forms.TextBox textBoxLOCALSCH;
        private System.Windows.Forms.ComboBox comboBoxParentBank;
        private System.Windows.Forms.ComboBox comboBoxBankDest;
        private System.Windows.Forms.BindingSource bsBankDest;
        private System.Windows.Forms.BindingSource bsParentBank;
        private System.Windows.Forms.Label labelParent;
        private System.Windows.Forms.Label labelDest;
        private System.Windows.Forms.TextBox textBoxParentAccount;
        private System.Windows.Forms.Label labelParentAccount;
        private System.Windows.Forms.CheckBox checkBoxReestr;
        private System.Windows.Forms.CheckBox checkBoxFilial;
        private System.Windows.Forms.CheckBox checkBoxKAZN;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTREB;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxReestrCount;
        private System.Windows.Forms.Label labelTREB;
        private System.Windows.Forms.Label labelReestrCount;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxBankDefault;
        private System.Windows.Forms.ToolStripButton toolStripButtonBankAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonBankDel;
        private System.Windows.Forms.ToolStripButton toolStripButtonBankEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveCancel;
        private System.Windows.Forms.CheckBox checkBoxUseSelfAccount;
        private System.Windows.Forms.TextBox textBoxPhones;
        private System.Windows.Forms.Label labelPhones;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameShort;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn MFO;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn CORSCHET;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn LOCALSCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DefaultDGVCBC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UseSelfAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankDest;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALCSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TREB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn REESTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReestrCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pENIDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dOPSCHETDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FILIAL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn KAZN;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankIDDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameShortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFullDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORSCHETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCALSCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn defaultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useSelfAccountDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentBankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankDestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALCSTATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKCODEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tREBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rEESTRDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reestrCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pENIDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dOPSCHETDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fILIALDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kAZNDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBanks;
        private System.Windows.Forms.ToolStripMenuItem AddBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditBankToolStripMenuItem;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Panel panelMode;
    }
}