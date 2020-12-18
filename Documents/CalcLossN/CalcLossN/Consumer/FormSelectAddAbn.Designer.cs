using ControlsLbr.DataGridViewExcelFilter;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace JournalCalcLoss
{
	public partial class FormSelectAddAbn
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private System.ComponentModel.IContainer components=null;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFL = new System.Windows.Forms.RadioButton();
            this.radioButtonUL = new System.Windows.Forms.RadioButton();
            this.txtCurrentAbn = new System.Windows.Forms.TextBox();
            this.dgvAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKontragentDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameSocrDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAbnDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedKontragentDgvColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isActiveDgvColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourceTAbn = new System.Windows.Forms.BindingSource(this.components);
            this.dsTC = new CalcLossN.DataSet.DataSetConsumer();
            this.timerLoadAbn = new System.Windows.Forms.Timer(this.components);
            this.dgvObj = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idObjDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObjRegDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameObjDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressULDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressFLDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRaionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housePrefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseAllDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isHouseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObjParentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeObjNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceObj = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerDgv = new System.Windows.Forms.SplitContainer();
            this.toolStripCont = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddCont = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEditCont = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelCont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnShowDelAbn = new System.Windows.Forms.ToolStripButton();
            this.toolStripObj = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEditObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelObj = new System.Windows.Forms.ToolStripButton();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.txtFlat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHousePrefix = new System.Windows.Forms.TextBox();
            this.ihfxnysmxZ = new System.Windows.Forms.Label();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStreet = new System.Windows.Forms.ComboBox();
            this.dsStreet = new System.Data.DataSet();
            this.dataTablesRaionObl = new System.Data.DataTable();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPunkt = new System.Windows.Forms.ComboBox();
            this.dsPunkt = new System.Data.DataSet();
            this.dataTablePunkt = new System.Data.DataTable();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.dsRaionObl = new System.Data.DataSet();
            this.dataTableRaionObl = new System.Data.DataTable();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbObl = new System.Windows.Forms.ComboBox();
            this.dsObl = new System.Data.DataSet();
            this.dataTableObl = new System.Data.DataTable();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.radioButtonSelAddress = new System.Windows.Forms.RadioButton();
            this.radioButtonSelectName = new System.Windows.Forms.RadioButton();
            this.tabControlContr = new System.Windows.Forms.TabControl();
            this.tabPageAbnInfo = new System.Windows.Forms.TabPage();
            this.nameFullTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.bankAcntTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.bankDestTextBox = new System.Windows.Forms.TextBox();
            this.oKVEDTextBox = new System.Windows.Forms.TextBox();
            this.bankIDTextBox = new System.Windows.Forms.TextBox();
            this.oKPOTextBox = new System.Windows.Forms.TextBox();
            this.nameFullLabel = new System.Windows.Forms.Label();
            this.bankAcntLabel = new System.Windows.Forms.Label();
            this.iNNLabel = new System.Windows.Forms.Label();
            this.bankDestLabel = new System.Windows.Forms.Label();
            this.kPPLabel = new System.Windows.Forms.Label();
            this.bankIDLabel = new System.Windows.Forms.Label();
            this.oKVEDLabel = new System.Windows.Forms.Label();
            this.oKPOLabel = new System.Windows.Forms.Label();
            this.tsAbnInfo = new System.Windows.Forms.ToolStrip();
            this.tsbAddAbnInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbInfoHistory = new System.Windows.Forms.ToolStripButton();
            this.tabPageDirector = new System.Windows.Forms.TabPage();
            this.tabControlDirectorFIO = new System.Windows.Forms.TabControl();
            this.tabPageI = new System.Windows.Forms.TabPage();
            this.I_postTextBox = new System.Windows.Forms.TextBox();
            this.postLabel = new System.Windows.Forms.Label();
            this.i_OLabel = new System.Windows.Forms.Label();
            this.i_OTextBox = new System.Windows.Forms.TextBox();
            this.i_ILabel = new System.Windows.Forms.Label();
            this.i_ITextBox = new System.Windows.Forms.TextBox();
            this.i_FLabel = new System.Windows.Forms.Label();
            this.i_FTextBox = new System.Windows.Forms.TextBox();
            this.tabPageR = new System.Windows.Forms.TabPage();
            this.R_postTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.r_OLabel = new System.Windows.Forms.Label();
            this.r_OTextBox = new System.Windows.Forms.TextBox();
            this.r_ILabel = new System.Windows.Forms.Label();
            this.r_ITextBox = new System.Windows.Forms.TextBox();
            this.r_FLabel = new System.Windows.Forms.Label();
            this.r_FTextBox = new System.Windows.Forms.TextBox();
            this.tabPageD = new System.Windows.Forms.TabPage();
            this.D_postTextBox = new System.Windows.Forms.TextBox();
            this.d_OLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.d_OTextBox = new System.Windows.Forms.TextBox();
            this.d_ILabel = new System.Windows.Forms.Label();
            this.d_ITextBox = new System.Windows.Forms.TextBox();
            this.d_FLabel = new System.Windows.Forms.Label();
            this.d_FTextBox = new System.Windows.Forms.TextBox();
            this.tabPageT = new System.Windows.Forms.TabPage();
            this.T_postTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.t_OLabel = new System.Windows.Forms.Label();
            this.t_OTextBox = new System.Windows.Forms.TextBox();
            this.t_ILabel = new System.Windows.Forms.Label();
            this.t_ITextBox = new System.Windows.Forms.TextBox();
            this.t_FLabel = new System.Windows.Forms.Label();
            this.t_FTextBox = new System.Windows.Forms.TextBox();
            this.tsDirector = new System.Windows.Forms.ToolStrip();
            this.tsbDirectorAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDirectorEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDirectorHistory = new System.Windows.Forms.ToolStripButton();
            this.tabPageAddress = new System.Windows.Forms.TabPage();
            this.groupBoxAddressP = new System.Windows.Forms.GroupBox();
            this.richTextBoxAddressP = new System.Windows.Forms.RichTextBox();
            this.groupBoxAddressL = new System.Windows.Forms.GroupBox();
            this.richTextBoxAddressL = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddressHistory = new System.Windows.Forms.ToolStripButton();
            this.tabPageContacts = new System.Windows.Forms.TabPage();
            this.dGVAbnContact = new System.Windows.Forms.DataGridView();
            this.idDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAbnContact = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContact = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewContact = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditContac = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelContact = new System.Windows.Forms.ToolStripButton();
            this.tabPageTypeAbn = new System.Windows.Forms.TabPage();
            this.dgvAbnType = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.typeKontragentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnTypeDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeKontragentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAbnType = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripAbnType = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.buttonОК = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.chkVisibleNoActiveAbn = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceObj)).BeginInit();
            this.splitContainerDgv.Panel1.SuspendLayout();
            this.splitContainerDgv.Panel2.SuspendLayout();
            this.splitContainerDgv.SuspendLayout();
            this.toolStripCont.SuspendLayout();
            this.toolStripObj.SuspendLayout();
            this.groupBoxSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablesRaionObl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPunkt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePunkt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRaionObl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRaionObl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableObl)).BeginInit();
            this.tabControlContr.SuspendLayout();
            this.tabPageAbnInfo.SuspendLayout();
            this.tsAbnInfo.SuspendLayout();
            this.tabPageDirector.SuspendLayout();
            this.tabControlDirectorFIO.SuspendLayout();
            this.tabPageI.SuspendLayout();
            this.tabPageR.SuspendLayout();
            this.tabPageD.SuspendLayout();
            this.tabPageT.SuspendLayout();
            this.tsDirector.SuspendLayout();
            this.tabPageAddress.SuspendLayout();
            this.groupBoxAddressP.SuspendLayout();
            this.groupBoxAddressL.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPageContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAbnContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnContact)).BeginInit();
            this.toolStripContact.SuspendLayout();
            this.tabPageTypeAbn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnType)).BeginInit();
            this.toolStripAbnType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonFL);
            this.groupBox1.Controls.Add(this.radioButtonUL);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 37);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonFL
            // 
            this.radioButtonFL.AutoSize = true;
            this.radioButtonFL.Location = new System.Drawing.Point(156, 12);
            this.radioButtonFL.Name = "radioButtonFL";
            this.radioButtonFL.Size = new System.Drawing.Size(131, 17);
            this.radioButtonFL.TabIndex = 1;
            this.radioButtonFL.Text = "Физическое лицо";
            this.radioButtonFL.UseVisualStyleBackColor = true;
            // 
            // radioButtonUL
            // 
            this.radioButtonUL.AutoSize = true;
            this.radioButtonUL.Checked = true;
            this.radioButtonUL.Location = new System.Drawing.Point(10, 12);
            this.radioButtonUL.Name = "radioButtonUL";
            this.radioButtonUL.Size = new System.Drawing.Size(136, 17);
            this.radioButtonUL.TabIndex = 0;
            this.radioButtonUL.TabStop = true;
            this.radioButtonUL.Text = "Юридическое лицо";
            this.radioButtonUL.UseVisualStyleBackColor = true;
            this.radioButtonUL.CheckedChanged += new System.EventHandler(this.radioButtonUL_CheckedChanged);
            // 
            // txtCurrentAbn
            // 
            this.txtCurrentAbn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentAbn.Location = new System.Drawing.Point(109, 10);
            this.txtCurrentAbn.Name = "txtCurrentAbn";
            this.txtCurrentAbn.Size = new System.Drawing.Size(605, 20);
            this.txtCurrentAbn.TabIndex = 2;
            this.txtCurrentAbn.TextChanged += new System.EventHandler(this.txtCurrentAbn_TextChanged);
            // 
            // dgvAbn
            // 
            this.dgvAbn.AllowUserToAddRows = false;
            this.dgvAbn.AllowUserToDeleteRows = false;
            this.dgvAbn.AllowUserToResizeRows = false;
            this.dgvAbn.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeAbonentDataGridViewTextBoxColumn,
            this.idKontragentDgvColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeNameSocrDgvColumn,
            this.typeAbnDgvColumn,
            this.deletedKontragentDgvColumn,
            this.isActiveDgvColumn});
            this.dgvAbn.DataSource = this.bindingSourceTAbn;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAbn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbn.Location = new System.Drawing.Point(24, 0);
            this.dgvAbn.Name = "dgvAbn";
            this.dgvAbn.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbn.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAbn.RowHeadersVisible = false;
            this.dgvAbn.Size = new System.Drawing.Size(322, 162);
            this.dgvAbn.TabIndex = 3;
            this.dgvAbn.VirtualMode = true;
            this.dgvAbn.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAbn_CellFormatting);
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 80;
            // 
            // idKontragentDgvColumn
            // 
            this.idKontragentDgvColumn.DataPropertyName = "id";
            this.idKontragentDgvColumn.HeaderText = "id";
            this.idKontragentDgvColumn.Name = "idKontragentDgvColumn";
            this.idKontragentDgvColumn.ReadOnly = true;
            this.idKontragentDgvColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeNameSocrDgvColumn
            // 
            this.typeNameSocrDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeNameSocrDgvColumn.DataPropertyName = "TypeNameSocr";
            this.typeNameSocrDgvColumn.FillWeight = 20F;
            this.typeNameSocrDgvColumn.HeaderText = "Тип";
            this.typeNameSocrDgvColumn.Name = "typeNameSocrDgvColumn";
            this.typeNameSocrDgvColumn.ReadOnly = true;
            // 
            // typeAbnDgvColumn
            // 
            this.typeAbnDgvColumn.DataPropertyName = "TypeAbn";
            this.typeAbnDgvColumn.HeaderText = "TypeAbn";
            this.typeAbnDgvColumn.Name = "typeAbnDgvColumn";
            this.typeAbnDgvColumn.ReadOnly = true;
            this.typeAbnDgvColumn.Visible = false;
            // 
            // deletedKontragentDgvColumn
            // 
            this.deletedKontragentDgvColumn.DataPropertyName = "Deleted";
            this.deletedKontragentDgvColumn.HeaderText = "Deleted";
            this.deletedKontragentDgvColumn.Name = "deletedKontragentDgvColumn";
            this.deletedKontragentDgvColumn.ReadOnly = true;
            this.deletedKontragentDgvColumn.Visible = false;
            // 
            // isActiveDgvColumn
            // 
            this.isActiveDgvColumn.DataPropertyName = "isActive";
            this.isActiveDgvColumn.HeaderText = "isActive";
            this.isActiveDgvColumn.Name = "isActiveDgvColumn";
            this.isActiveDgvColumn.ReadOnly = true;
            this.isActiveDgvColumn.Visible = false;
            // 
            // bindingSourceTAbn
            // 
            this.bindingSourceTAbn.DataMember = "vAbn";
            this.bindingSourceTAbn.DataSource = this.dsTC;
            this.bindingSourceTAbn.CurrentChanged += new System.EventHandler(this.bindingSourceTAbn_CurrentChanged);
            // 
            // dsTC
            // 
            this.dsTC.DataSetName = "DataSetConsumer";
            this.dsTC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timerLoadAbn
            // 
            this.timerLoadAbn.Interval = 300;
            this.timerLoadAbn.Tick += new System.EventHandler(this.timerLoadAbn_Tick);
            // 
            // dgvObj
            // 
            this.dgvObj.AllowUserToAddRows = false;
            this.dgvObj.AllowUserToDeleteRows = false;
            this.dgvObj.AllowUserToResizeRows = false;
            this.dgvObj.AutoGenerateColumns = false;
            this.dgvObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObjDgvColumn,
            this.idObjRegDgvColumn,
            this.idAbnDataGridViewTextBoxColumn,
            this.idMapDataGridViewTextBoxColumn,
            this.nameObjDgvColumn,
            this.addressULDgvColumn,
            this.addressFLDgvColumn,
            this.commentDataGridViewTextBoxColumn,
            this.idCityDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.idRaionDataGridViewTextBoxColumn,
            this.raionDataGridViewTextBoxColumn,
            this.idStreetDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.housePrefixDataGridViewTextBoxColumn,
            this.houseAllDataGridViewTextBoxColumn,
            this.isHouseDataGridViewCheckBoxColumn,
            this.indexDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn,
            this.idObjParentDataGridViewTextBoxColumn,
            this.typeObjDataGridViewTextBoxColumn,
            this.typeObjNameDataGridViewTextBoxColumn});
            this.dgvObj.DataSource = this.bindingSourceObj;
            this.dgvObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObj.Location = new System.Drawing.Point(24, 0);
            this.dgvObj.Name = "dgvObj";
            this.dgvObj.ReadOnly = true;
            this.dgvObj.RowHeadersVisible = false;
            this.dgvObj.Size = new System.Drawing.Size(346, 162);
            this.dgvObj.TabIndex = 6;
            // 
            // idObjDgvColumn
            // 
            this.idObjDgvColumn.DataPropertyName = "id";
            this.idObjDgvColumn.HeaderText = "id";
            this.idObjDgvColumn.Name = "idObjDgvColumn";
            this.idObjDgvColumn.ReadOnly = true;
            this.idObjDgvColumn.Visible = false;
            // 
            // idObjRegDgvColumn
            // 
            this.idObjRegDgvColumn.DataPropertyName = "idObjReg";
            this.idObjRegDgvColumn.HeaderText = "idObjReg";
            this.idObjRegDgvColumn.Name = "idObjRegDgvColumn";
            this.idObjRegDgvColumn.ReadOnly = true;
            this.idObjRegDgvColumn.Visible = false;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMapDataGridViewTextBoxColumn
            // 
            this.idMapDataGridViewTextBoxColumn.DataPropertyName = "idMap";
            this.idMapDataGridViewTextBoxColumn.HeaderText = "idMap";
            this.idMapDataGridViewTextBoxColumn.Name = "idMapDataGridViewTextBoxColumn";
            this.idMapDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMapDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameObjDgvColumn
            // 
            this.nameObjDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameObjDgvColumn.DataPropertyName = "Name";
            this.nameObjDgvColumn.HeaderText = "Объект";
            this.nameObjDgvColumn.Name = "nameObjDgvColumn";
            this.nameObjDgvColumn.ReadOnly = true;
            // 
            // addressULDgvColumn
            // 
            this.addressULDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressULDgvColumn.HeaderText = "Адрес";
            this.addressULDgvColumn.Name = "addressULDgvColumn";
            this.addressULDgvColumn.ReadOnly = true;
            // 
            // addressFLDgvColumn
            // 
            this.addressFLDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressFLDgvColumn.HeaderText = "Адрес";
            this.addressFLDgvColumn.Name = "addressFLDgvColumn";
            this.addressFLDgvColumn.ReadOnly = true;
            this.addressFLDgvColumn.Visible = false;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCityDataGridViewTextBoxColumn
            // 
            this.idCityDataGridViewTextBoxColumn.DataPropertyName = "idCity";
            this.idCityDataGridViewTextBoxColumn.HeaderText = "idCity";
            this.idCityDataGridViewTextBoxColumn.Name = "idCityDataGridViewTextBoxColumn";
            this.idCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCityDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Visible = false;
            // 
            // idRaionDataGridViewTextBoxColumn
            // 
            this.idRaionDataGridViewTextBoxColumn.DataPropertyName = "idRaion";
            this.idRaionDataGridViewTextBoxColumn.HeaderText = "idRaion";
            this.idRaionDataGridViewTextBoxColumn.Name = "idRaionDataGridViewTextBoxColumn";
            this.idRaionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRaionDataGridViewTextBoxColumn.Visible = false;
            // 
            // raionDataGridViewTextBoxColumn
            // 
            this.raionDataGridViewTextBoxColumn.DataPropertyName = "Raion";
            this.raionDataGridViewTextBoxColumn.HeaderText = "Raion";
            this.raionDataGridViewTextBoxColumn.Name = "raionDataGridViewTextBoxColumn";
            this.raionDataGridViewTextBoxColumn.ReadOnly = true;
            this.raionDataGridViewTextBoxColumn.Visible = false;
            // 
            // idStreetDataGridViewTextBoxColumn
            // 
            this.idStreetDataGridViewTextBoxColumn.DataPropertyName = "idStreet";
            this.idStreetDataGridViewTextBoxColumn.HeaderText = "idStreet";
            this.idStreetDataGridViewTextBoxColumn.Name = "idStreetDataGridViewTextBoxColumn";
            this.idStreetDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStreetDataGridViewTextBoxColumn.Visible = false;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.Visible = false;
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
            // houseAllDataGridViewTextBoxColumn
            // 
            this.houseAllDataGridViewTextBoxColumn.DataPropertyName = "HouseAll";
            this.houseAllDataGridViewTextBoxColumn.HeaderText = "HouseAll";
            this.houseAllDataGridViewTextBoxColumn.Name = "houseAllDataGridViewTextBoxColumn";
            this.houseAllDataGridViewTextBoxColumn.ReadOnly = true;
            this.houseAllDataGridViewTextBoxColumn.Visible = false;
            // 
            // isHouseDataGridViewCheckBoxColumn
            // 
            this.isHouseDataGridViewCheckBoxColumn.DataPropertyName = "IsHouse";
            this.isHouseDataGridViewCheckBoxColumn.HeaderText = "IsHouse";
            this.isHouseDataGridViewCheckBoxColumn.Name = "isHouseDataGridViewCheckBoxColumn";
            this.isHouseDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isHouseDataGridViewCheckBoxColumn.Visible = false;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Index";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.ReadOnly = true;
            this.indexDataGridViewTextBoxColumn.Visible = false;
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            this.latitudeDataGridViewTextBoxColumn.ReadOnly = true;
            this.latitudeDataGridViewTextBoxColumn.Visible = false;
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            this.longitudeDataGridViewTextBoxColumn.ReadOnly = true;
            this.longitudeDataGridViewTextBoxColumn.Visible = false;
            // 
            // idObjParentDataGridViewTextBoxColumn
            // 
            this.idObjParentDataGridViewTextBoxColumn.DataPropertyName = "idObjParent";
            this.idObjParentDataGridViewTextBoxColumn.HeaderText = "idObjParent";
            this.idObjParentDataGridViewTextBoxColumn.Name = "idObjParentDataGridViewTextBoxColumn";
            this.idObjParentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idObjParentDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeObjDataGridViewTextBoxColumn
            // 
            this.typeObjDataGridViewTextBoxColumn.DataPropertyName = "TypeObj";
            this.typeObjDataGridViewTextBoxColumn.HeaderText = "TypeObj";
            this.typeObjDataGridViewTextBoxColumn.Name = "typeObjDataGridViewTextBoxColumn";
            this.typeObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeObjNameDataGridViewTextBoxColumn
            // 
            this.typeObjNameDataGridViewTextBoxColumn.DataPropertyName = "TypeObjName";
            this.typeObjNameDataGridViewTextBoxColumn.HeaderText = "TypeObjName";
            this.typeObjNameDataGridViewTextBoxColumn.Name = "typeObjNameDataGridViewTextBoxColumn";
            this.typeObjNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeObjNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceObj
            // 
            this.bindingSourceObj.DataMember = "vAbnObjAddress";
            this.bindingSourceObj.DataSource = this.dsTC;
            this.bindingSourceObj.CurrentChanged += new System.EventHandler(this.bindingSourceObj_CurrentChanged);
            // 
            // splitContainerDgv
            // 
            this.splitContainerDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerDgv.Location = new System.Drawing.Point(2, 168);
            this.splitContainerDgv.Name = "splitContainerDgv";
            // 
            // splitContainerDgv.Panel1
            // 
            this.splitContainerDgv.Panel1.Controls.Add(this.dgvAbn);
            this.splitContainerDgv.Panel1.Controls.Add(this.toolStripCont);
            // 
            // splitContainerDgv.Panel2
            // 
            this.splitContainerDgv.Panel2.Controls.Add(this.dgvObj);
            this.splitContainerDgv.Panel2.Controls.Add(this.toolStripObj);
            this.splitContainerDgv.Size = new System.Drawing.Size(720, 162);
            this.splitContainerDgv.SplitterDistance = 346;
            this.splitContainerDgv.TabIndex = 7;
            // 
            // toolStripCont
            // 
            this.toolStripCont.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripCont.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCont.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddCont,
            this.toolBtnEditCont,
            this.toolBtnDelCont,
            this.toolStripSeparator1,
            this.toolBtnShowDelAbn});
            this.toolStripCont.Location = new System.Drawing.Point(0, 0);
            this.toolStripCont.Name = "toolStripCont";
            this.toolStripCont.Size = new System.Drawing.Size(24, 162);
            this.toolStripCont.TabIndex = 4;
            this.toolStripCont.Text = "toolStrip1";
            // 
            // toolBtnAddCont
            // 
            this.toolBtnAddCont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddCont.Image = global::CalcLossN.Properties.Resources.ElementAdd;
            this.toolBtnAddCont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddCont.Name = "toolBtnAddCont";
            this.toolBtnAddCont.Size = new System.Drawing.Size(21, 20);
            this.toolBtnAddCont.Text = "Создание контрагента";
            this.toolBtnAddCont.Click += new System.EventHandler(this.toolBtnAddCont_Click);
            // 
            // toolBtnEditCont
            // 
            this.toolBtnEditCont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEditCont.Image = global::CalcLossN.Properties.Resources.ElementEdit;
            this.toolBtnEditCont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEditCont.Name = "toolBtnEditCont";
            this.toolBtnEditCont.Size = new System.Drawing.Size(21, 20);
            this.toolBtnEditCont.Text = "Редактирование Контрагента";
            this.toolBtnEditCont.Click += new System.EventHandler(this.toolBtnEditCont_Click);
            // 
            // toolBtnDelCont
            // 
            this.toolBtnDelCont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelCont.Image = global::CalcLossN.Properties.Resources.ElementDel;
            this.toolBtnDelCont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelCont.Name = "toolBtnDelCont";
            this.toolBtnDelCont.Size = new System.Drawing.Size(21, 20);
            this.toolBtnDelCont.Text = "Удаление контрагента";
            this.toolBtnDelCont.Click += new System.EventHandler(this.toolBtnDelCont_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(21, 6);
            // 
            // toolBtnShowDelAbn
            // 
            this.toolBtnShowDelAbn.CheckOnClick = true;
            this.toolBtnShowDelAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowDelAbn.Image = global::CalcLossN.Properties.Resources.Trash;
            this.toolBtnShowDelAbn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnShowDelAbn.Name = "toolBtnShowDelAbn";
            this.toolBtnShowDelAbn.Size = new System.Drawing.Size(21, 20);
            this.toolBtnShowDelAbn.Text = "Показать удаленных";
            this.toolBtnShowDelAbn.Click += new System.EventHandler(this.toolBtnShowDelAbn_Click);
            // 
            // toolStripObj
            // 
            this.toolStripObj.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripObj.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripObj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddObj,
            this.toolBtnEditObj,
            this.toolBtnDelObj});
            this.toolStripObj.Location = new System.Drawing.Point(0, 0);
            this.toolStripObj.Name = "toolStripObj";
            this.toolStripObj.Size = new System.Drawing.Size(24, 162);
            this.toolStripObj.TabIndex = 7;
            this.toolStripObj.Text = "toolStrip2";
            // 
            // toolBtnAddObj
            // 
            this.toolBtnAddObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddObj.Image = global::CalcLossN.Properties.Resources.ElementAdd;
            this.toolBtnAddObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddObj.Name = "toolBtnAddObj";
            this.toolBtnAddObj.Size = new System.Drawing.Size(21, 20);
            this.toolBtnAddObj.Text = "Добавление объекта";
            this.toolBtnAddObj.Click += new System.EventHandler(this.toolBtnAddObj_Click);
            // 
            // toolBtnEditObj
            // 
            this.toolBtnEditObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEditObj.Image = global::CalcLossN.Properties.Resources.ElementEdit;
            this.toolBtnEditObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEditObj.Name = "toolBtnEditObj";
            this.toolBtnEditObj.Size = new System.Drawing.Size(21, 20);
            this.toolBtnEditObj.Text = "Редактирование объекта";
            this.toolBtnEditObj.Click += new System.EventHandler(this.toolBtnEditObj_Click);
            // 
            // toolBtnDelObj
            // 
            this.toolBtnDelObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelObj.Image = global::CalcLossN.Properties.Resources.ElementDel;
            this.toolBtnDelObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelObj.Name = "toolBtnDelObj";
            this.toolBtnDelObj.Size = new System.Drawing.Size(21, 20);
            this.toolBtnDelObj.Text = "Удаление объекта";
            this.toolBtnDelObj.Click += new System.EventHandler(this.toolBtnDelObj_Click);
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSelect.Controls.Add(this.txtFlat);
            this.groupBoxSelect.Controls.Add(this.label8);
            this.groupBoxSelect.Controls.Add(this.txtHousePrefix);
            this.groupBoxSelect.Controls.Add(this.ihfxnysmxZ);
            this.groupBoxSelect.Controls.Add(this.txtHouse);
            this.groupBoxSelect.Controls.Add(this.label5);
            this.groupBoxSelect.Controls.Add(this.cmbStreet);
            this.groupBoxSelect.Controls.Add(this.label4);
            this.groupBoxSelect.Controls.Add(this.cmbPunkt);
            this.groupBoxSelect.Controls.Add(this.label3);
            this.groupBoxSelect.Controls.Add(this.cmbCity);
            this.groupBoxSelect.Controls.Add(this.label2);
            this.groupBoxSelect.Controls.Add(this.label1);
            this.groupBoxSelect.Controls.Add(this.cmbObl);
            this.groupBoxSelect.Controls.Add(this.radioButtonSelAddress);
            this.groupBoxSelect.Controls.Add(this.radioButtonSelectName);
            this.groupBoxSelect.Controls.Add(this.txtCurrentAbn);
            this.groupBoxSelect.Location = new System.Drawing.Point(2, 35);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(720, 109);
            this.groupBoxSelect.TabIndex = 8;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Фильтр";
            // 
            // txtFlat
            // 
            this.txtFlat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlat.Enabled = false;
            this.txtFlat.Location = new System.Drawing.Point(649, 82);
            this.txtFlat.Name = "txtFlat";
            this.txtFlat.Size = new System.Drawing.Size(61, 20);
            this.txtFlat.TabIndex = 19;
            this.txtFlat.TextChanged += new System.EventHandler(this.txtFlat_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(649, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Квартира";
            // 
            // txtHousePrefix
            // 
            this.txtHousePrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHousePrefix.Enabled = false;
            this.txtHousePrefix.Location = new System.Drawing.Point(603, 82);
            this.txtHousePrefix.Name = "txtHousePrefix";
            this.txtHousePrefix.Size = new System.Drawing.Size(40, 20);
            this.txtHousePrefix.TabIndex = 17;
            this.txtHousePrefix.TextChanged += new System.EventHandler(this.txtHousePrefix_TextChanged);
            // 
            // ihfxnysmxZ
            // 
            this.ihfxnysmxZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ihfxnysmxZ.AutoSize = true;
            this.ihfxnysmxZ.Location = new System.Drawing.Point(600, 70);
            this.ihfxnysmxZ.Name = "ihfxnysmxZ";
            this.ihfxnysmxZ.Size = new System.Drawing.Size(43, 13);
            this.ihfxnysmxZ.TabIndex = 16;
            this.ihfxnysmxZ.Text = "Корпус";
            // 
            // txtHouse
            // 
            this.txtHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHouse.Enabled = false;
            this.txtHouse.Location = new System.Drawing.Point(564, 82);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(33, 20);
            this.txtHouse.TabIndex = 14;
            this.txtHouse.TextChanged += new System.EventHandler(this.txtHouse_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Дом";
            // 
            // cmbStreet
            // 
            this.cmbStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStreet.DataSource = this.dsStreet;
            this.cmbStreet.DisplayMember = "tR_KladrStreet.NameSocr";
            this.cmbStreet.Enabled = false;
            this.cmbStreet.FormattingEnabled = true;
            this.cmbStreet.Location = new System.Drawing.Point(177, 82);
            this.cmbStreet.Name = "cmbStreet";
            this.cmbStreet.Size = new System.Drawing.Size(381, 21);
            this.cmbStreet.TabIndex = 12;
            this.cmbStreet.ValueMember = "tR_KladrStreet.Id";
            this.cmbStreet.SelectedIndexChanged += new System.EventHandler(this.cmbStreet_SelectedIndexChanged);
            // 
            // dsStreet
            // 
            this.dsStreet.DataSetName = "dsStreet";
            this.dsStreet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTablesRaionObl});
            // 
            // dataTablesRaionObl
            // 
            this.dataTablesRaionObl.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn17,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTablesRaionObl.TableName = "tR_KladrStreet";
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "Id";
            this.dataColumn17.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Socr";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "NameSocr";
            this.dataColumn3.Expression = "Name + \' \' + isnull(socr, \'\')";
            this.dataColumn3.ReadOnly = true;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Index";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Улица";
            // 
            // cmbPunkt
            // 
            this.cmbPunkt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPunkt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPunkt.DataSource = this.dsPunkt;
            this.cmbPunkt.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbPunkt.Enabled = false;
            this.cmbPunkt.FormattingEnabled = true;
            this.cmbPunkt.Location = new System.Drawing.Point(6, 82);
            this.cmbPunkt.Name = "cmbPunkt";
            this.cmbPunkt.Size = new System.Drawing.Size(156, 21);
            this.cmbPunkt.TabIndex = 10;
            this.cmbPunkt.ValueMember = "tR_KladrObj.Id";
            this.cmbPunkt.SelectedIndexChanged += new System.EventHandler(this.cmbPunkt_SelectedIndexChanged);
            // 
            // dsPunkt
            // 
            this.dsPunkt.DataSetName = "dsPunkt";
            this.dsPunkt.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTablePunkt});
            // 
            // dataTablePunkt
            // 
            this.dataTablePunkt.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dataTablePunkt.TableName = "tR_KladrObj";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Id";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Name";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Socr";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "NameSocr";
            this.dataColumn8.Expression = "Name + \' \' + isnull(socr, \'\')";
            this.dataColumn8.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Нас. пункт";
            // 
            // cmbCity
            // 
            this.cmbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.DataSource = this.dsRaionObl;
            this.cmbCity.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbCity.Enabled = false;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(266, 46);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(447, 21);
            this.cmbCity.TabIndex = 8;
            this.cmbCity.ValueMember = "tR_KladrObj.Id";
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // dsRaionObl
            // 
            this.dsRaionObl.DataSetName = "dsRaionObl";
            this.dsRaionObl.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableRaionObl});
            // 
            // dataTableRaionObl
            // 
            this.dataTableRaionObl.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12});
            this.dataTableRaionObl.TableName = "tR_KladrObj";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Id";
            this.dataColumn9.DataType = typeof(int);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Name";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Socr";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "NameSocr";
            this.dataColumn12.Expression = "Name + \' \' + isnull(socr, \'\')";
            this.dataColumn12.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Регион";
            // 
            // cmbObl
            // 
            this.cmbObl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbObl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbObl.DataSource = this.dsObl;
            this.cmbObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbObl.Enabled = false;
            this.cmbObl.FormattingEnabled = true;
            this.cmbObl.Location = new System.Drawing.Point(109, 46);
            this.cmbObl.Name = "cmbObl";
            this.cmbObl.Size = new System.Drawing.Size(141, 21);
            this.cmbObl.TabIndex = 5;
            this.cmbObl.ValueMember = "tR_KladrObj.Id";
            this.cmbObl.SelectedIndexChanged += new System.EventHandler(this.cmbObl_SelectedIndexChanged);
            // 
            // dsObl
            // 
            this.dsObl.DataSetName = "dsObl";
            this.dsObl.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableObl});
            // 
            // dataTableObl
            // 
            this.dataTableObl.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16});
            this.dataTableObl.TableName = "tR_KladrObj";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "Id";
            this.dataColumn13.DataType = typeof(int);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "Name";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "Socr";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "NameSocr";
            this.dataColumn16.Expression = "Name + \' \' + isnull(socr, \'\')";
            this.dataColumn16.ReadOnly = true;
            // 
            // radioButtonSelAddress
            // 
            this.radioButtonSelAddress.AutoSize = true;
            this.radioButtonSelAddress.Location = new System.Drawing.Point(6, 43);
            this.radioButtonSelAddress.Name = "radioButtonSelAddress";
            this.radioButtonSelAddress.Size = new System.Drawing.Size(75, 17);
            this.radioButtonSelAddress.TabIndex = 4;
            this.radioButtonSelAddress.Text = "по адресу";
            this.radioButtonSelAddress.UseVisualStyleBackColor = true;
            // 
            // radioButtonSelectName
            // 
            this.radioButtonSelectName.AutoSize = true;
            this.radioButtonSelectName.Checked = true;
            this.radioButtonSelectName.Location = new System.Drawing.Point(6, 11);
            this.radioButtonSelectName.Name = "radioButtonSelectName";
            this.radioButtonSelectName.Size = new System.Drawing.Size(72, 17);
            this.radioButtonSelectName.TabIndex = 3;
            this.radioButtonSelectName.TabStop = true;
            this.radioButtonSelectName.Text = "по имени";
            this.radioButtonSelectName.UseVisualStyleBackColor = true;
            this.radioButtonSelectName.CheckedChanged += new System.EventHandler(this.radioButtonSelectName_CheckedChanged);
            // 
            // tabControlContr
            // 
            this.tabControlContr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlContr.Controls.Add(this.tabPageAbnInfo);
            this.tabControlContr.Controls.Add(this.tabPageDirector);
            this.tabControlContr.Controls.Add(this.tabPageAddress);
            this.tabControlContr.Controls.Add(this.tabPageContacts);
            this.tabControlContr.Controls.Add(this.tabPageTypeAbn);
            this.tabControlContr.Location = new System.Drawing.Point(1, 331);
            this.tabControlContr.Name = "tabControlContr";
            this.tabControlContr.SelectedIndex = 0;
            this.tabControlContr.Size = new System.Drawing.Size(727, 217);
            this.tabControlContr.TabIndex = 9;
            // 
            // tabPageAbnInfo
            // 
            this.tabPageAbnInfo.Controls.Add(this.nameFullTextBox);
            this.tabPageAbnInfo.Controls.Add(this.iNNTextBox);
            this.tabPageAbnInfo.Controls.Add(this.bankAcntTextBox);
            this.tabPageAbnInfo.Controls.Add(this.kPPTextBox);
            this.tabPageAbnInfo.Controls.Add(this.bankDestTextBox);
            this.tabPageAbnInfo.Controls.Add(this.oKVEDTextBox);
            this.tabPageAbnInfo.Controls.Add(this.bankIDTextBox);
            this.tabPageAbnInfo.Controls.Add(this.oKPOTextBox);
            this.tabPageAbnInfo.Controls.Add(this.nameFullLabel);
            this.tabPageAbnInfo.Controls.Add(this.bankAcntLabel);
            this.tabPageAbnInfo.Controls.Add(this.iNNLabel);
            this.tabPageAbnInfo.Controls.Add(this.bankDestLabel);
            this.tabPageAbnInfo.Controls.Add(this.kPPLabel);
            this.tabPageAbnInfo.Controls.Add(this.bankIDLabel);
            this.tabPageAbnInfo.Controls.Add(this.oKVEDLabel);
            this.tabPageAbnInfo.Controls.Add(this.oKPOLabel);
            this.tabPageAbnInfo.Controls.Add(this.tsAbnInfo);
            this.tabPageAbnInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbnInfo.Name = "tabPageAbnInfo";
            this.tabPageAbnInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbnInfo.Size = new System.Drawing.Size(719, 191);
            this.tabPageAbnInfo.TabIndex = 0;
            this.tabPageAbnInfo.Text = "Реквизиты";
            this.tabPageAbnInfo.UseVisualStyleBackColor = true;
            // 
            // nameFullTextBox
            // 
            this.nameFullTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameFullTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "vG_AbnInfo.NameFull", true));
            this.nameFullTextBox.Location = new System.Drawing.Point(119, 3);
            this.nameFullTextBox.Multiline = true;
            this.nameFullTextBox.Name = "nameFullTextBox";
            this.nameFullTextBox.ReadOnly = true;
            this.nameFullTextBox.Size = new System.Drawing.Size(591, 52);
            this.nameFullTextBox.TabIndex = 38;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "vG_AbnInfo.INN", true));
            this.iNNTextBox.Location = new System.Drawing.Point(119, 65);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.ReadOnly = true;
            this.iNNTextBox.Size = new System.Drawing.Size(230, 20);
            this.iNNTextBox.TabIndex = 40;
            // 
            // bankAcntTextBox
            // 
            this.bankAcntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "vG_AbnInfo.BankAcnt", true));
            this.bankAcntTextBox.Location = new System.Drawing.Point(167, 168);
            this.bankAcntTextBox.Name = "bankAcntTextBox";
            this.bankAcntTextBox.ReadOnly = true;
            this.bankAcntTextBox.Size = new System.Drawing.Size(223, 20);
            this.bankAcntTextBox.TabIndex = 52;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "vG_AbnInfo.KPP", true));
            this.kPPTextBox.Location = new System.Drawing.Point(396, 61);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.ReadOnly = true;
            this.kPPTextBox.Size = new System.Drawing.Size(314, 20);
            this.kPPTextBox.TabIndex = 42;
            // 
            // bankDestTextBox
            // 
            this.bankDestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bankDestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "vG_AbnInfo.BankDestName", true));
            this.bankDestTextBox.Location = new System.Drawing.Point(167, 142);
            this.bankDestTextBox.Name = "bankDestTextBox";
            this.bankDestTextBox.ReadOnly = true;
            this.bankDestTextBox.Size = new System.Drawing.Size(543, 20);
            this.bankDestTextBox.TabIndex = 50;
            // 
            // oKVEDTextBox
            // 
            this.oKVEDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "vG_AbnInfo.OKVED", true));
            this.oKVEDTextBox.Location = new System.Drawing.Point(119, 87);
            this.oKVEDTextBox.Name = "oKVEDTextBox";
            this.oKVEDTextBox.ReadOnly = true;
            this.oKVEDTextBox.Size = new System.Drawing.Size(230, 20);
            this.oKVEDTextBox.TabIndex = 44;
            // 
            // bankIDTextBox
            // 
            this.bankIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bankIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "vG_AbnInfo.BankName", true));
            this.bankIDTextBox.Location = new System.Drawing.Point(167, 116);
            this.bankIDTextBox.Name = "bankIDTextBox";
            this.bankIDTextBox.ReadOnly = true;
            this.bankIDTextBox.Size = new System.Drawing.Size(543, 20);
            this.bankIDTextBox.TabIndex = 48;
            // 
            // oKPOTextBox
            // 
            this.oKPOTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oKPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "vG_AbnInfo.OKPO", true));
            this.oKPOTextBox.Location = new System.Drawing.Point(396, 87);
            this.oKPOTextBox.Name = "oKPOTextBox";
            this.oKPOTextBox.ReadOnly = true;
            this.oKPOTextBox.Size = new System.Drawing.Size(314, 20);
            this.oKPOTextBox.TabIndex = 46;
            // 
            // nameFullLabel
            // 
            this.nameFullLabel.AutoSize = true;
            this.nameFullLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameFullLabel.Location = new System.Drawing.Point(31, 7);
            this.nameFullLabel.Name = "nameFullLabel";
            this.nameFullLabel.Size = new System.Drawing.Size(82, 13);
            this.nameFullLabel.TabIndex = 37;
            this.nameFullLabel.Text = "Полное имя:";
            // 
            // bankAcntLabel
            // 
            this.bankAcntLabel.AutoSize = true;
            this.bankAcntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankAcntLabel.Location = new System.Drawing.Point(60, 171);
            this.bankAcntLabel.Name = "bankAcntLabel";
            this.bankAcntLabel.Size = new System.Drawing.Size(105, 13);
            this.bankAcntLabel.TabIndex = 51;
            this.bankAcntLabel.Text = "Расчетный счет:";
            // 
            // iNNLabel
            // 
            this.iNNLabel.AutoSize = true;
            this.iNNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iNNLabel.Location = new System.Drawing.Point(75, 68);
            this.iNNLabel.Name = "iNNLabel";
            this.iNNLabel.Size = new System.Drawing.Size(38, 13);
            this.iNNLabel.TabIndex = 39;
            this.iNNLabel.Text = "ИНН:";
            // 
            // bankDestLabel
            // 
            this.bankDestLabel.AutoSize = true;
            this.bankDestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankDestLabel.Location = new System.Drawing.Point(55, 145);
            this.bankDestLabel.Name = "bankDestLabel";
            this.bankDestLabel.Size = new System.Drawing.Size(111, 13);
            this.bankDestLabel.TabIndex = 49;
            this.bankDestLabel.Text = "Банк получателя:";
            // 
            // kPPLabel
            // 
            this.kPPLabel.AutoSize = true;
            this.kPPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kPPLabel.Location = new System.Drawing.Point(357, 68);
            this.kPPLabel.Name = "kPPLabel";
            this.kPPLabel.Size = new System.Drawing.Size(37, 13);
            this.kPPLabel.TabIndex = 41;
            this.kPPLabel.Text = "КПП:";
            // 
            // bankIDLabel
            // 
            this.bankIDLabel.AutoSize = true;
            this.bankIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankIDLabel.Location = new System.Drawing.Point(41, 119);
            this.bankIDLabel.Name = "bankIDLabel";
            this.bankIDLabel.Size = new System.Drawing.Size(127, 13);
            this.bankIDLabel.TabIndex = 47;
            this.bankIDLabel.Text = "Банк плательщика :";
            // 
            // oKVEDLabel
            // 
            this.oKVEDLabel.AutoSize = true;
            this.oKVEDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oKVEDLabel.Location = new System.Drawing.Point(61, 90);
            this.oKVEDLabel.Name = "oKVEDLabel";
            this.oKVEDLabel.Size = new System.Drawing.Size(54, 13);
            this.oKVEDLabel.TabIndex = 43;
            this.oKVEDLabel.Text = "ОКВЕД:";
            // 
            // oKPOLabel
            // 
            this.oKPOLabel.AutoSize = true;
            this.oKPOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oKPOLabel.Location = new System.Drawing.Point(349, 90);
            this.oKPOLabel.Name = "oKPOLabel";
            this.oKPOLabel.Size = new System.Drawing.Size(46, 13);
            this.oKPOLabel.TabIndex = 45;
            this.oKPOLabel.Text = "ОКПО:";
            // 
            // tsAbnInfo
            // 
            this.tsAbnInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsAbnInfo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAbnInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddAbnInfo,
            this.tsbEditInfo,
            this.tsbInfoHistory});
            this.tsAbnInfo.Location = new System.Drawing.Point(3, 3);
            this.tsAbnInfo.Name = "tsAbnInfo";
            this.tsAbnInfo.Size = new System.Drawing.Size(24, 185);
            this.tsAbnInfo.TabIndex = 36;
            this.tsAbnInfo.Text = "toolStrip1";
            // 
            // tsbAddAbnInfo
            // 
            this.tsbAddAbnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddAbnInfo.Image = global::CalcLossN.Properties.Resources.ElementAdd;
            this.tsbAddAbnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddAbnInfo.Name = "tsbAddAbnInfo";
            this.tsbAddAbnInfo.Size = new System.Drawing.Size(21, 20);
            this.tsbAddAbnInfo.Text = "Новые реквизиты";
            this.tsbAddAbnInfo.Click += new System.EventHandler(this.tsbAddAbnInfo_Click);
            // 
            // tsbEditInfo
            // 
            this.tsbEditInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditInfo.Image = global::CalcLossN.Properties.Resources.ElementEdit;
            this.tsbEditInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditInfo.Name = "tsbEditInfo";
            this.tsbEditInfo.Size = new System.Drawing.Size(21, 20);
            this.tsbEditInfo.Text = "Редактировать реквизиты";
            this.tsbEditInfo.Click += new System.EventHandler(this.tsbEditInfo_Click);
            // 
            // tsbInfoHistory
            // 
            this.tsbInfoHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInfoHistory.Image = global::CalcLossN.Properties.Resources.ElementInformation;
            this.tsbInfoHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfoHistory.Name = "tsbInfoHistory";
            this.tsbInfoHistory.Size = new System.Drawing.Size(21, 20);
            this.tsbInfoHistory.Text = "Истрия реквизитов";
            this.tsbInfoHistory.Click += new System.EventHandler(this.tsbInfoHistory_Click);
            // 
            // tabPageDirector
            // 
            this.tabPageDirector.Controls.Add(this.tabControlDirectorFIO);
            this.tabPageDirector.Controls.Add(this.tsDirector);
            this.tabPageDirector.Location = new System.Drawing.Point(4, 22);
            this.tabPageDirector.Name = "tabPageDirector";
            this.tabPageDirector.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDirector.Size = new System.Drawing.Size(719, 191);
            this.tabPageDirector.TabIndex = 1;
            this.tabPageDirector.Text = "Руководитель";
            this.tabPageDirector.UseVisualStyleBackColor = true;
            // 
            // tabControlDirectorFIO
            // 
            this.tabControlDirectorFIO.Controls.Add(this.tabPageI);
            this.tabControlDirectorFIO.Controls.Add(this.tabPageR);
            this.tabControlDirectorFIO.Controls.Add(this.tabPageD);
            this.tabControlDirectorFIO.Controls.Add(this.tabPageT);
            this.tabControlDirectorFIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDirectorFIO.Location = new System.Drawing.Point(27, 3);
            this.tabControlDirectorFIO.Name = "tabControlDirectorFIO";
            this.tabControlDirectorFIO.SelectedIndex = 0;
            this.tabControlDirectorFIO.Size = new System.Drawing.Size(689, 185);
            this.tabControlDirectorFIO.TabIndex = 40;
            // 
            // tabPageI
            // 
            this.tabPageI.Controls.Add(this.I_postTextBox);
            this.tabPageI.Controls.Add(this.postLabel);
            this.tabPageI.Controls.Add(this.i_OLabel);
            this.tabPageI.Controls.Add(this.i_OTextBox);
            this.tabPageI.Controls.Add(this.i_ILabel);
            this.tabPageI.Controls.Add(this.i_ITextBox);
            this.tabPageI.Controls.Add(this.i_FLabel);
            this.tabPageI.Controls.Add(this.i_FTextBox);
            this.tabPageI.Location = new System.Drawing.Point(4, 22);
            this.tabPageI.Name = "tabPageI";
            this.tabPageI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageI.Size = new System.Drawing.Size(681, 159);
            this.tabPageI.TabIndex = 0;
            this.tabPageI.Text = "Именительный (кто)";
            this.tabPageI.UseVisualStyleBackColor = true;
            // 
            // I_postTextBox
            // 
            this.I_postTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.I_Post", true));
            this.I_postTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.I_postTextBox.Location = new System.Drawing.Point(113, 15);
            this.I_postTextBox.Multiline = true;
            this.I_postTextBox.Name = "I_postTextBox";
            this.I_postTextBox.ReadOnly = true;
            this.I_postTextBox.Size = new System.Drawing.Size(552, 25);
            this.I_postTextBox.TabIndex = 33;
            // 
            // postLabel
            // 
            this.postLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postLabel.AutoSize = true;
            this.postLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postLabel.Location = new System.Drawing.Point(12, 15);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(95, 17);
            this.postLabel.TabIndex = 32;
            this.postLabel.Text = "Должность:";
            // 
            // i_OLabel
            // 
            this.i_OLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_OLabel.AutoSize = true;
            this.i_OLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_OLabel.Location = new System.Drawing.Point(23, 130);
            this.i_OLabel.Name = "i_OLabel";
            this.i_OLabel.Size = new System.Drawing.Size(84, 17);
            this.i_OLabel.TabIndex = 42;
            this.i_OLabel.Text = "Отчество:";
            // 
            // i_OTextBox
            // 
            this.i_OTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_OTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.I_O", true));
            this.i_OTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_OTextBox.Location = new System.Drawing.Point(113, 127);
            this.i_OTextBox.Name = "i_OTextBox";
            this.i_OTextBox.ReadOnly = true;
            this.i_OTextBox.Size = new System.Drawing.Size(552, 23);
            this.i_OTextBox.TabIndex = 43;
            // 
            // i_ILabel
            // 
            this.i_ILabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_ILabel.AutoSize = true;
            this.i_ILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_ILabel.Location = new System.Drawing.Point(64, 95);
            this.i_ILabel.Name = "i_ILabel";
            this.i_ILabel.Size = new System.Drawing.Size(43, 17);
            this.i_ILabel.TabIndex = 40;
            this.i_ILabel.Text = "Имя:";
            // 
            // i_ITextBox
            // 
            this.i_ITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_ITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.I_I", true));
            this.i_ITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_ITextBox.Location = new System.Drawing.Point(113, 92);
            this.i_ITextBox.Name = "i_ITextBox";
            this.i_ITextBox.ReadOnly = true;
            this.i_ITextBox.Size = new System.Drawing.Size(552, 23);
            this.i_ITextBox.TabIndex = 41;
            // 
            // i_FLabel
            // 
            this.i_FLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_FLabel.AutoSize = true;
            this.i_FLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_FLabel.Location = new System.Drawing.Point(25, 58);
            this.i_FLabel.Name = "i_FLabel";
            this.i_FLabel.Size = new System.Drawing.Size(82, 17);
            this.i_FLabel.TabIndex = 38;
            this.i_FLabel.Text = "Фамилия:";
            // 
            // i_FTextBox
            // 
            this.i_FTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_FTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.I_F", true));
            this.i_FTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_FTextBox.Location = new System.Drawing.Point(113, 55);
            this.i_FTextBox.Name = "i_FTextBox";
            this.i_FTextBox.ReadOnly = true;
            this.i_FTextBox.Size = new System.Drawing.Size(552, 23);
            this.i_FTextBox.TabIndex = 39;
            // 
            // tabPageR
            // 
            this.tabPageR.Controls.Add(this.R_postTextBox);
            this.tabPageR.Controls.Add(this.label6);
            this.tabPageR.Controls.Add(this.r_OLabel);
            this.tabPageR.Controls.Add(this.r_OTextBox);
            this.tabPageR.Controls.Add(this.r_ILabel);
            this.tabPageR.Controls.Add(this.r_ITextBox);
            this.tabPageR.Controls.Add(this.r_FLabel);
            this.tabPageR.Controls.Add(this.r_FTextBox);
            this.tabPageR.Location = new System.Drawing.Point(4, 22);
            this.tabPageR.Name = "tabPageR";
            this.tabPageR.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageR.Size = new System.Drawing.Size(681, 159);
            this.tabPageR.TabIndex = 1;
            this.tabPageR.Text = "Родительный (кого)";
            this.tabPageR.UseVisualStyleBackColor = true;
            // 
            // R_postTextBox
            // 
            this.R_postTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.R_postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.R_Post", true));
            this.R_postTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R_postTextBox.Location = new System.Drawing.Point(113, 15);
            this.R_postTextBox.Multiline = true;
            this.R_postTextBox.Name = "R_postTextBox";
            this.R_postTextBox.ReadOnly = true;
            this.R_postTextBox.Size = new System.Drawing.Size(552, 25);
            this.R_postTextBox.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Должность:";
            // 
            // r_OLabel
            // 
            this.r_OLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.r_OLabel.AutoSize = true;
            this.r_OLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_OLabel.Location = new System.Drawing.Point(23, 130);
            this.r_OLabel.Name = "r_OLabel";
            this.r_OLabel.Size = new System.Drawing.Size(84, 17);
            this.r_OLabel.TabIndex = 52;
            this.r_OLabel.Text = "Отчество:";
            // 
            // r_OTextBox
            // 
            this.r_OTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.r_OTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.R_O", true));
            this.r_OTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_OTextBox.Location = new System.Drawing.Point(113, 127);
            this.r_OTextBox.Name = "r_OTextBox";
            this.r_OTextBox.ReadOnly = true;
            this.r_OTextBox.Size = new System.Drawing.Size(552, 23);
            this.r_OTextBox.TabIndex = 53;
            // 
            // r_ILabel
            // 
            this.r_ILabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.r_ILabel.AutoSize = true;
            this.r_ILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_ILabel.Location = new System.Drawing.Point(64, 95);
            this.r_ILabel.Name = "r_ILabel";
            this.r_ILabel.Size = new System.Drawing.Size(43, 17);
            this.r_ILabel.TabIndex = 50;
            this.r_ILabel.Text = "Имя:";
            // 
            // r_ITextBox
            // 
            this.r_ITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.r_ITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.R_I", true));
            this.r_ITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_ITextBox.Location = new System.Drawing.Point(113, 92);
            this.r_ITextBox.Name = "r_ITextBox";
            this.r_ITextBox.ReadOnly = true;
            this.r_ITextBox.Size = new System.Drawing.Size(552, 23);
            this.r_ITextBox.TabIndex = 51;
            // 
            // r_FLabel
            // 
            this.r_FLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.r_FLabel.AutoSize = true;
            this.r_FLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_FLabel.Location = new System.Drawing.Point(25, 58);
            this.r_FLabel.Name = "r_FLabel";
            this.r_FLabel.Size = new System.Drawing.Size(82, 17);
            this.r_FLabel.TabIndex = 48;
            this.r_FLabel.Text = "Фамилия:";
            this.r_FLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // r_FTextBox
            // 
            this.r_FTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.r_FTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.R_F", true));
            this.r_FTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_FTextBox.Location = new System.Drawing.Point(113, 55);
            this.r_FTextBox.Name = "r_FTextBox";
            this.r_FTextBox.ReadOnly = true;
            this.r_FTextBox.Size = new System.Drawing.Size(552, 23);
            this.r_FTextBox.TabIndex = 49;
            // 
            // tabPageD
            // 
            this.tabPageD.Controls.Add(this.D_postTextBox);
            this.tabPageD.Controls.Add(this.d_OLabel);
            this.tabPageD.Controls.Add(this.label9);
            this.tabPageD.Controls.Add(this.d_OTextBox);
            this.tabPageD.Controls.Add(this.d_ILabel);
            this.tabPageD.Controls.Add(this.d_ITextBox);
            this.tabPageD.Controls.Add(this.d_FLabel);
            this.tabPageD.Controls.Add(this.d_FTextBox);
            this.tabPageD.Location = new System.Drawing.Point(4, 22);
            this.tabPageD.Name = "tabPageD";
            this.tabPageD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageD.Size = new System.Drawing.Size(681, 159);
            this.tabPageD.TabIndex = 2;
            this.tabPageD.Text = "Дательный (кому)";
            this.tabPageD.UseVisualStyleBackColor = true;
            // 
            // D_postTextBox
            // 
            this.D_postTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.D_postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.D_Post", true));
            this.D_postTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D_postTextBox.Location = new System.Drawing.Point(113, 15);
            this.D_postTextBox.Multiline = true;
            this.D_postTextBox.Name = "D_postTextBox";
            this.D_postTextBox.ReadOnly = true;
            this.D_postTextBox.Size = new System.Drawing.Size(552, 25);
            this.D_postTextBox.TabIndex = 37;
            // 
            // d_OLabel
            // 
            this.d_OLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.d_OLabel.AutoSize = true;
            this.d_OLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_OLabel.Location = new System.Drawing.Point(23, 130);
            this.d_OLabel.Name = "d_OLabel";
            this.d_OLabel.Size = new System.Drawing.Size(84, 17);
            this.d_OLabel.TabIndex = 58;
            this.d_OLabel.Text = "Отчество:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Должность:";
            // 
            // d_OTextBox
            // 
            this.d_OTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.d_OTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.D_O", true));
            this.d_OTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_OTextBox.Location = new System.Drawing.Point(113, 127);
            this.d_OTextBox.Name = "d_OTextBox";
            this.d_OTextBox.ReadOnly = true;
            this.d_OTextBox.Size = new System.Drawing.Size(552, 23);
            this.d_OTextBox.TabIndex = 59;
            // 
            // d_ILabel
            // 
            this.d_ILabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.d_ILabel.AutoSize = true;
            this.d_ILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_ILabel.Location = new System.Drawing.Point(64, 95);
            this.d_ILabel.Name = "d_ILabel";
            this.d_ILabel.Size = new System.Drawing.Size(43, 17);
            this.d_ILabel.TabIndex = 56;
            this.d_ILabel.Text = "Имя:";
            // 
            // d_ITextBox
            // 
            this.d_ITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.d_ITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.D_I", true));
            this.d_ITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_ITextBox.Location = new System.Drawing.Point(113, 92);
            this.d_ITextBox.Name = "d_ITextBox";
            this.d_ITextBox.ReadOnly = true;
            this.d_ITextBox.Size = new System.Drawing.Size(552, 23);
            this.d_ITextBox.TabIndex = 57;
            // 
            // d_FLabel
            // 
            this.d_FLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.d_FLabel.AutoSize = true;
            this.d_FLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_FLabel.Location = new System.Drawing.Point(25, 58);
            this.d_FLabel.Name = "d_FLabel";
            this.d_FLabel.Size = new System.Drawing.Size(82, 17);
            this.d_FLabel.TabIndex = 54;
            this.d_FLabel.Text = "Фамилия:";
            // 
            // d_FTextBox
            // 
            this.d_FTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.d_FTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.D_F", true));
            this.d_FTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_FTextBox.Location = new System.Drawing.Point(113, 55);
            this.d_FTextBox.Name = "d_FTextBox";
            this.d_FTextBox.ReadOnly = true;
            this.d_FTextBox.Size = new System.Drawing.Size(552, 23);
            this.d_FTextBox.TabIndex = 55;
            // 
            // tabPageT
            // 
            this.tabPageT.CausesValidation = false;
            this.tabPageT.Controls.Add(this.T_postTextBox);
            this.tabPageT.Controls.Add(this.label10);
            this.tabPageT.Controls.Add(this.t_OLabel);
            this.tabPageT.Controls.Add(this.t_OTextBox);
            this.tabPageT.Controls.Add(this.t_ILabel);
            this.tabPageT.Controls.Add(this.t_ITextBox);
            this.tabPageT.Controls.Add(this.t_FLabel);
            this.tabPageT.Controls.Add(this.t_FTextBox);
            this.tabPageT.Location = new System.Drawing.Point(4, 22);
            this.tabPageT.Name = "tabPageT";
            this.tabPageT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageT.Size = new System.Drawing.Size(681, 159);
            this.tabPageT.TabIndex = 3;
            this.tabPageT.Text = "Творительный (кем)";
            this.tabPageT.UseVisualStyleBackColor = true;
            // 
            // T_postTextBox
            // 
            this.T_postTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.T_postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.T_Post", true));
            this.T_postTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T_postTextBox.Location = new System.Drawing.Point(113, 15);
            this.T_postTextBox.Multiline = true;
            this.T_postTextBox.Name = "T_postTextBox";
            this.T_postTextBox.ReadOnly = true;
            this.T_postTextBox.Size = new System.Drawing.Size(552, 25);
            this.T_postTextBox.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Должность:";
            // 
            // t_OLabel
            // 
            this.t_OLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_OLabel.AutoSize = true;
            this.t_OLabel.CausesValidation = false;
            this.t_OLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_OLabel.Location = new System.Drawing.Point(23, 130);
            this.t_OLabel.Name = "t_OLabel";
            this.t_OLabel.Size = new System.Drawing.Size(84, 17);
            this.t_OLabel.TabIndex = 64;
            this.t_OLabel.Text = "Отчество:";
            // 
            // t_OTextBox
            // 
            this.t_OTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_OTextBox.CausesValidation = false;
            this.t_OTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.T_O", true));
            this.t_OTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_OTextBox.Location = new System.Drawing.Point(113, 127);
            this.t_OTextBox.Name = "t_OTextBox";
            this.t_OTextBox.ReadOnly = true;
            this.t_OTextBox.Size = new System.Drawing.Size(552, 23);
            this.t_OTextBox.TabIndex = 65;
            // 
            // t_ILabel
            // 
            this.t_ILabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_ILabel.AutoSize = true;
            this.t_ILabel.CausesValidation = false;
            this.t_ILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_ILabel.Location = new System.Drawing.Point(64, 95);
            this.t_ILabel.Name = "t_ILabel";
            this.t_ILabel.Size = new System.Drawing.Size(43, 17);
            this.t_ILabel.TabIndex = 62;
            this.t_ILabel.Text = "Имя:";
            // 
            // t_ITextBox
            // 
            this.t_ITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_ITextBox.CausesValidation = false;
            this.t_ITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.T_I", true));
            this.t_ITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_ITextBox.Location = new System.Drawing.Point(113, 92);
            this.t_ITextBox.Name = "t_ITextBox";
            this.t_ITextBox.ReadOnly = true;
            this.t_ITextBox.Size = new System.Drawing.Size(552, 23);
            this.t_ITextBox.TabIndex = 63;
            // 
            // t_FLabel
            // 
            this.t_FLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_FLabel.AutoSize = true;
            this.t_FLabel.CausesValidation = false;
            this.t_FLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_FLabel.Location = new System.Drawing.Point(25, 58);
            this.t_FLabel.Name = "t_FLabel";
            this.t_FLabel.Size = new System.Drawing.Size(82, 17);
            this.t_FLabel.TabIndex = 60;
            this.t_FLabel.Text = "Фамилия:";
            // 
            // t_FTextBox
            // 
            this.t_FTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_FTextBox.CausesValidation = false;
            this.t_FTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "tG_AbnChief.T_F", true));
            this.t_FTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_FTextBox.Location = new System.Drawing.Point(113, 55);
            this.t_FTextBox.Name = "t_FTextBox";
            this.t_FTextBox.ReadOnly = true;
            this.t_FTextBox.Size = new System.Drawing.Size(552, 23);
            this.t_FTextBox.TabIndex = 61;
            // 
            // tsDirector
            // 
            this.tsDirector.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsDirector.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsDirector.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDirectorAdd,
            this.tsbDirectorEdit,
            this.tsbDirectorHistory});
            this.tsDirector.Location = new System.Drawing.Point(3, 3);
            this.tsDirector.Name = "tsDirector";
            this.tsDirector.Size = new System.Drawing.Size(24, 185);
            this.tsDirector.TabIndex = 39;
            this.tsDirector.Text = "toolStrip1";
            // 
            // tsbDirectorAdd
            // 
            this.tsbDirectorAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDirectorAdd.Image = global::CalcLossN.Properties.Resources.ElementAdd;
            this.tsbDirectorAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDirectorAdd.Name = "tsbDirectorAdd";
            this.tsbDirectorAdd.Size = new System.Drawing.Size(21, 20);
            this.tsbDirectorAdd.Text = "Новый руководитель";
            this.tsbDirectorAdd.Click += new System.EventHandler(this.tsbDirectorAdd_Click);
            // 
            // tsbDirectorEdit
            // 
            this.tsbDirectorEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDirectorEdit.Image = global::CalcLossN.Properties.Resources.ElementEdit;
            this.tsbDirectorEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDirectorEdit.Name = "tsbDirectorEdit";
            this.tsbDirectorEdit.Size = new System.Drawing.Size(21, 20);
            this.tsbDirectorEdit.Text = "Редактировать руководителя";
            this.tsbDirectorEdit.Click += new System.EventHandler(this.tsbDirectorEdit_Click);
            // 
            // tsbDirectorHistory
            // 
            this.tsbDirectorHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDirectorHistory.Image = global::CalcLossN.Properties.Resources.ElementInformation;
            this.tsbDirectorHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDirectorHistory.Name = "tsbDirectorHistory";
            this.tsbDirectorHistory.Size = new System.Drawing.Size(21, 20);
            this.tsbDirectorHistory.Text = "История руководителей";
            this.tsbDirectorHistory.Click += new System.EventHandler(this.tsbDirectorHistory_Click);
            // 
            // tabPageAddress
            // 
            this.tabPageAddress.Controls.Add(this.groupBoxAddressP);
            this.tabPageAddress.Controls.Add(this.groupBoxAddressL);
            this.tabPageAddress.Controls.Add(this.toolStrip1);
            this.tabPageAddress.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddress.Name = "tabPageAddress";
            this.tabPageAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddress.Size = new System.Drawing.Size(719, 191);
            this.tabPageAddress.TabIndex = 2;
            this.tabPageAddress.Text = "Адреса";
            this.tabPageAddress.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddressP
            // 
            this.groupBoxAddressP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddressP.Controls.Add(this.richTextBoxAddressP);
            this.groupBoxAddressP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAddressP.Location = new System.Drawing.Point(30, 93);
            this.groupBoxAddressP.Name = "groupBoxAddressP";
            this.groupBoxAddressP.Size = new System.Drawing.Size(686, 101);
            this.groupBoxAddressP.TabIndex = 7;
            this.groupBoxAddressP.TabStop = false;
            this.groupBoxAddressP.Text = "Почтовый адрес";
            // 
            // richTextBoxAddressP
            // 
            this.richTextBoxAddressP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAddressP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "vG_AbnAddressP.Representation", true));
            this.richTextBoxAddressP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxAddressP.Location = new System.Drawing.Point(12, 19);
            this.richTextBoxAddressP.Name = "richTextBoxAddressP";
            this.richTextBoxAddressP.ReadOnly = true;
            this.richTextBoxAddressP.Size = new System.Drawing.Size(656, 65);
            this.richTextBoxAddressP.TabIndex = 0;
            this.richTextBoxAddressP.Text = "";
            // 
            // groupBoxAddressL
            // 
            this.groupBoxAddressL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddressL.Controls.Add(this.richTextBoxAddressL);
            this.groupBoxAddressL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAddressL.Location = new System.Drawing.Point(30, 1);
            this.groupBoxAddressL.Name = "groupBoxAddressL";
            this.groupBoxAddressL.Size = new System.Drawing.Size(687, 97);
            this.groupBoxAddressL.TabIndex = 6;
            this.groupBoxAddressL.TabStop = false;
            this.groupBoxAddressL.Text = "Юридический адрес";
            // 
            // richTextBoxAddressL
            // 
            this.richTextBoxAddressL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAddressL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTC, "vG_AbnAddressL.Representation", true));
            this.richTextBoxAddressL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxAddressL.Location = new System.Drawing.Point(13, 19);
            this.richTextBoxAddressL.Name = "richTextBoxAddressL";
            this.richTextBoxAddressL.ReadOnly = true;
            this.richTextBoxAddressL.Size = new System.Drawing.Size(656, 67);
            this.richTextBoxAddressL.TabIndex = 1;
            this.richTextBoxAddressL.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddressHistory});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 185);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddressHistory
            // 
            this.tsbAddressHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddressHistory.Image = global::CalcLossN.Properties.Resources.ElementInformation;
            this.tsbAddressHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddressHistory.Name = "tsbAddressHistory";
            this.tsbAddressHistory.Size = new System.Drawing.Size(21, 20);
            this.tsbAddressHistory.Text = "История адресов";
            this.tsbAddressHistory.Click += new System.EventHandler(this.tsbAddressHistory_Click);
            // 
            // tabPageContacts
            // 
            this.tabPageContacts.Controls.Add(this.dGVAbnContact);
            this.tabPageContacts.Controls.Add(this.toolStripContact);
            this.tabPageContacts.Location = new System.Drawing.Point(4, 22);
            this.tabPageContacts.Name = "tabPageContacts";
            this.tabPageContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContacts.Size = new System.Drawing.Size(719, 191);
            this.tabPageContacts.TabIndex = 3;
            this.tabPageContacts.Text = "Контакты";
            this.tabPageContacts.UseVisualStyleBackColor = true;
            // 
            // dGVAbnContact
            // 
            this.dGVAbnContact.AllowUserToAddRows = false;
            this.dGVAbnContact.AllowUserToDeleteRows = false;
            this.dGVAbnContact.AutoGenerateColumns = false;
            this.dGVAbnContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAbnContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDGVTBC,
            this.idAbnDataGridViewTextBoxColumn1,
            this.postDataGridViewTextBoxColumn,
            this.fDataGridViewTextBoxColumn,
            this.iDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dateChangeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dGVAbnContact.DataSource = this.bsAbnContact;
            this.dGVAbnContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVAbnContact.Location = new System.Drawing.Point(27, 3);
            this.dGVAbnContact.MultiSelect = false;
            this.dGVAbnContact.Name = "dGVAbnContact";
            this.dGVAbnContact.ReadOnly = true;
            this.dGVAbnContact.RowHeadersWidth = 5;
            this.dGVAbnContact.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVAbnContact.RowTemplate.Height = 24;
            this.dGVAbnContact.Size = new System.Drawing.Size(689, 185);
            this.dGVAbnContact.TabIndex = 6;
            // 
            // idDGVTBC
            // 
            this.idDGVTBC.DataPropertyName = "id";
            this.idDGVTBC.HeaderText = "id";
            this.idDGVTBC.Name = "idDGVTBC";
            this.idDGVTBC.ReadOnly = true;
            this.idDGVTBC.Visible = false;
            // 
            // idAbnDataGridViewTextBoxColumn1
            // 
            this.idAbnDataGridViewTextBoxColumn1.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn1.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn1.Name = "idAbnDataGridViewTextBoxColumn1";
            this.idAbnDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn1.Visible = false;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            this.fDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDataGridViewTextBoxColumn
            // 
            this.iDataGridViewTextBoxColumn.DataPropertyName = "I";
            this.iDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.iDataGridViewTextBoxColumn.Name = "iDataGridViewTextBoxColumn";
            this.iDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            this.oDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateChangeDataGridViewTextBoxColumn
            // 
            this.dateChangeDataGridViewTextBoxColumn.DataPropertyName = "DateChange";
            this.dateChangeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateChangeDataGridViewTextBoxColumn.Name = "dateChangeDataGridViewTextBoxColumn";
            this.dateChangeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateChangeDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn1.HeaderText = "Коментарий";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bsAbnContact
            // 
            this.bsAbnContact.DataMember = "tAbnContact";
            this.bsAbnContact.DataSource = this.dsTC;
            // 
            // toolStripContact
            // 
            this.toolStripContact.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripContact.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripContact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewContact,
            this.toolStripButtonEditContac,
            this.toolStripButtonDelContact});
            this.toolStripContact.Location = new System.Drawing.Point(3, 3);
            this.toolStripContact.Name = "toolStripContact";
            this.toolStripContact.Size = new System.Drawing.Size(24, 185);
            this.toolStripContact.TabIndex = 3;
            this.toolStripContact.Text = "toolStrip1";
            // 
            // toolStripButtonNewContact
            // 
            this.toolStripButtonNewContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewContact.Image = global::CalcLossN.Properties.Resources.ElementAdd;
            this.toolStripButtonNewContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewContact.Name = "toolStripButtonNewContact";
            this.toolStripButtonNewContact.Size = new System.Drawing.Size(21, 20);
            this.toolStripButtonNewContact.Text = "Новый контакт";
            this.toolStripButtonNewContact.Click += new System.EventHandler(this.toolStripButtonNewContact_Click);
            // 
            // toolStripButtonEditContac
            // 
            this.toolStripButtonEditContac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditContac.Image = global::CalcLossN.Properties.Resources.ElementEdit;
            this.toolStripButtonEditContac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditContac.Name = "toolStripButtonEditContac";
            this.toolStripButtonEditContac.Size = new System.Drawing.Size(21, 20);
            this.toolStripButtonEditContac.Text = "Редактировать контакт";
            this.toolStripButtonEditContac.Click += new System.EventHandler(this.toolStripButtonEditContac_Click);
            // 
            // toolStripButtonDelContact
            // 
            this.toolStripButtonDelContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelContact.Image = global::CalcLossN.Properties.Resources.ElementDel;
            this.toolStripButtonDelContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelContact.Name = "toolStripButtonDelContact";
            this.toolStripButtonDelContact.Size = new System.Drawing.Size(21, 20);
            this.toolStripButtonDelContact.Text = "Удалить контакт";
            this.toolStripButtonDelContact.Click += new System.EventHandler(this.toolStripButtonDelContact_Click);
            // 
            // tabPageTypeAbn
            // 
            this.tabPageTypeAbn.Controls.Add(this.dgvAbnType);
            this.tabPageTypeAbn.Controls.Add(this.toolStripAbnType);
            this.tabPageTypeAbn.Location = new System.Drawing.Point(4, 22);
            this.tabPageTypeAbn.Name = "tabPageTypeAbn";
            this.tabPageTypeAbn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTypeAbn.Size = new System.Drawing.Size(719, 191);
            this.tabPageTypeAbn.TabIndex = 4;
            this.tabPageTypeAbn.Text = "Принадлежность к типу";
            this.tabPageTypeAbn.UseVisualStyleBackColor = true;
            // 
            // dgvAbnType
            // 
            this.dgvAbnType.AllowUserToAddRows = false;
            this.dgvAbnType.AllowUserToDeleteRows = false;
            this.dgvAbnType.AutoGenerateColumns = false;
            this.dgvAbnType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbnType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeKontragentNameDataGridViewTextBoxColumn,
            this.idAbnTypeDgvColumn,
            this.codeAbonentDataGridViewTextBoxColumn1,
            this.typeKontragentDataGridViewTextBoxColumn});
            this.dgvAbnType.DataSource = this.bsAbnType;
            this.dgvAbnType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbnType.Location = new System.Drawing.Point(27, 3);
            this.dgvAbnType.Name = "dgvAbnType";
            this.dgvAbnType.ReadOnly = true;
            this.dgvAbnType.RowHeadersWidth = 21;
            this.dgvAbnType.Size = new System.Drawing.Size(689, 185);
            this.dgvAbnType.TabIndex = 38;
            // 
            // typeKontragentNameDataGridViewTextBoxColumn
            // 
            this.typeKontragentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeKontragentNameDataGridViewTextBoxColumn.DataPropertyName = "typeKontragentName";
            this.typeKontragentNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeKontragentNameDataGridViewTextBoxColumn.Name = "typeKontragentNameDataGridViewTextBoxColumn";
            this.typeKontragentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAbnTypeDgvColumn
            // 
            this.idAbnTypeDgvColumn.DataPropertyName = "id";
            this.idAbnTypeDgvColumn.HeaderText = "id";
            this.idAbnTypeDgvColumn.Name = "idAbnTypeDgvColumn";
            this.idAbnTypeDgvColumn.ReadOnly = true;
            this.idAbnTypeDgvColumn.Visible = false;
            // 
            // codeAbonentDataGridViewTextBoxColumn1
            // 
            this.codeAbonentDataGridViewTextBoxColumn1.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn1.HeaderText = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn1.Name = "codeAbonentDataGridViewTextBoxColumn1";
            this.codeAbonentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn1.Visible = false;
            // 
            // typeKontragentDataGridViewTextBoxColumn
            // 
            this.typeKontragentDataGridViewTextBoxColumn.DataPropertyName = "typeKontragent";
            this.typeKontragentDataGridViewTextBoxColumn.HeaderText = "typeKontragent";
            this.typeKontragentDataGridViewTextBoxColumn.Name = "typeKontragentDataGridViewTextBoxColumn";
            this.typeKontragentDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeKontragentDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsAbnType
            // 
            this.bsAbnType.DataMember = "vAbnType";
            this.bsAbnType.DataSource = this.dsTC;
            this.bsAbnType.Sort = "typeKontragentName";
            // 
            // toolStripAbnType
            // 
            this.toolStripAbnType.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripAbnType.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripAbnType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStripAbnType.Location = new System.Drawing.Point(3, 3);
            this.toolStripAbnType.Name = "toolStripAbnType";
            this.toolStripAbnType.Size = new System.Drawing.Size(24, 185);
            this.toolStripAbnType.TabIndex = 37;
            this.toolStripAbnType.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::CalcLossN.Properties.Resources.ElementAdd;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton1.Text = "Добавить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::CalcLossN.Properties.Resources.ElementEdit;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton2.Text = "Редактировать";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::CalcLossN.Properties.Resources.ElementDel;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton3.Text = "Удалить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // buttonОК
            // 
            this.buttonОК.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonОК.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonОК.Location = new System.Drawing.Point(12, 554);
            this.buttonОК.Name = "buttonОК";
            this.buttonОК.Size = new System.Drawing.Size(75, 23);
            this.buttonОК.TabIndex = 10;
            this.buttonОК.Text = "ОК";
            this.buttonОК.UseVisualStyleBackColor = true;
            this.buttonОК.Click += new System.EventHandler(this.buttonОК_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(641, 554);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // chkVisibleNoActiveAbn
            // 
            this.chkVisibleNoActiveAbn.AutoSize = true;
            this.chkVisibleNoActiveAbn.Location = new System.Drawing.Point(12, 145);
            this.chkVisibleNoActiveAbn.Name = "chkVisibleNoActiveAbn";
            this.chkVisibleNoActiveAbn.Size = new System.Drawing.Size(194, 17);
            this.chkVisibleNoActiveAbn.TabIndex = 12;
            this.chkVisibleNoActiveAbn.Text = "Показать неактивных абонентов";
            this.chkVisibleNoActiveAbn.UseVisualStyleBackColor = true;
            this.chkVisibleNoActiveAbn.CheckedChanged += new System.EventHandler(this.chkVisibleNoActiveAbn_CheckedChanged);
            // 
            // FormSelectAddAbn
            // 
            this.AcceptButton = this.buttonОК;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(727, 578);
            this.Controls.Add(this.chkVisibleNoActiveAbn);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonОК);
            this.Controls.Add(this.tabControlContr);
            this.Controls.Add(this.groupBoxSelect);
            this.Controls.Add(this.splitContainerDgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSelectAddAbn";
            this.Text = "Выбор/создание контрагента";
            this.Load += new System.EventHandler(this.FormTechConnectionAddAbn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceObj)).EndInit();
            this.splitContainerDgv.Panel1.ResumeLayout(false);
            this.splitContainerDgv.Panel1.PerformLayout();
            this.splitContainerDgv.Panel2.ResumeLayout(false);
            this.splitContainerDgv.Panel2.PerformLayout();
            this.splitContainerDgv.ResumeLayout(false);
            this.toolStripCont.ResumeLayout(false);
            this.toolStripCont.PerformLayout();
            this.toolStripObj.ResumeLayout(false);
            this.toolStripObj.PerformLayout();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablesRaionObl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPunkt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePunkt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRaionObl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRaionObl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableObl)).EndInit();
            this.tabControlContr.ResumeLayout(false);
            this.tabPageAbnInfo.ResumeLayout(false);
            this.tabPageAbnInfo.PerformLayout();
            this.tsAbnInfo.ResumeLayout(false);
            this.tsAbnInfo.PerformLayout();
            this.tabPageDirector.ResumeLayout(false);
            this.tabPageDirector.PerformLayout();
            this.tabControlDirectorFIO.ResumeLayout(false);
            this.tabPageI.ResumeLayout(false);
            this.tabPageI.PerformLayout();
            this.tabPageR.ResumeLayout(false);
            this.tabPageR.PerformLayout();
            this.tabPageD.ResumeLayout(false);
            this.tabPageD.PerformLayout();
            this.tabPageT.ResumeLayout(false);
            this.tabPageT.PerformLayout();
            this.tsDirector.ResumeLayout(false);
            this.tsDirector.PerformLayout();
            this.tabPageAddress.ResumeLayout(false);
            this.tabPageAddress.PerformLayout();
            this.groupBoxAddressP.ResumeLayout(false);
            this.groupBoxAddressL.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPageContacts.ResumeLayout(false);
            this.tabPageContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAbnContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnContact)).EndInit();
            this.toolStripContact.ResumeLayout(false);
            this.toolStripContact.PerformLayout();
            this.tabPageTypeAbn.ResumeLayout(false);
            this.tabPageTypeAbn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnType)).EndInit();
            this.toolStripAbnType.ResumeLayout(false);
            this.toolStripAbnType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // private DataSetTechConnection.vAbnObjAddressDataTable tableAbnObjAddress;

       



        private GroupBox groupBox1;

        private RadioButton radioButtonUL;

        private RadioButton radioButtonFL;

        private TextBox txtCurrentAbn;

        // private DataSetTechConnection dsTC;
        private CalcLossN.DataSet.DataSetConsumer dsTC;

        private BindingSource bindingSourceTAbn;

        private DataGridViewExcelFilter dgvAbn;

        private Timer timerLoadAbn;

        private BindingSource bindingSourceObj;

        private DataGridViewExcelFilter dgvObj;

        private SplitContainer splitContainerDgv;

        private GroupBox groupBoxSelect;

        private RadioButton radioButtonSelectName;

        private ComboBox cmbObl;

        private RadioButton radioButtonSelAddress;

        private ComboBox cmbStreet;

        private Label label4;

        private ComboBox cmbPunkt;

        private Label label3;

        private ComboBox cmbCity;

        private Label label2;

        private Label label1;

        private TextBox txtFlat;

        private Label label8;

        private TextBox txtHousePrefix;

        private Label ihfxnysmxZ;

        private TextBox txtHouse;

        private Label label5;

        private DataSet dsStreet;

        private DataTable dataTablesRaionObl;

        private DataColumn dataColumn17;

        private DataColumn dataColumn1;

        private DataColumn dataColumn2;

        private DataColumn dataColumn3;

        private DataColumn dataColumn4;

        private DataSet dsPunkt;

        private DataTable dataTablePunkt;

        private DataColumn dataColumn5;

        private DataColumn dataColumn6;

        private DataColumn dataColumn7;

        private DataColumn dataColumn8;

        private DataSet dsRaionObl;

        private DataTable dataTableRaionObl;

        private DataColumn dataColumn9;

        private DataColumn dataColumn10;

        private DataColumn dataColumn11;

        private DataColumn dataColumn12;

        private DataSet dsObl;

        private DataTable dataTableObl;

        private DataColumn dataColumn13;

        private DataColumn dataColumn14;

        private DataColumn dataColumn15;

        private DataColumn dataColumn16;

        private TabControl tabControlContr;

        private TabPage tabPageAbnInfo;

        private TabPage tabPageDirector;

        private ToolStrip tsAbnInfo;

        private ToolStripButton tsbAddAbnInfo;

        private ToolStripButton tsbEditInfo;

        private ToolStripButton tsbInfoHistory;

        private TextBox nameFullTextBox;

        private TextBox iNNTextBox;

        private TextBox bankAcntTextBox;

        private TextBox kPPTextBox;

        private TextBox bankDestTextBox;

        private TextBox oKVEDTextBox;

        private TextBox bankIDTextBox;

        private TextBox oKPOTextBox;

        private ToolStrip tsDirector;

        private ToolStripButton tsbDirectorAdd;

        private ToolStripButton tsbDirectorEdit;

        private ToolStripButton tsbDirectorHistory;

        private TabControl tabControlDirectorFIO;

        private TabPage tabPageI;

        private TextBox I_postTextBox;

        private TextBox i_OTextBox;

        private TextBox i_ITextBox;

        private TextBox i_FTextBox;

        private TabPage tabPageR;

        private TextBox R_postTextBox;

        private TextBox r_OTextBox;

        private TextBox r_ITextBox;

        private TextBox r_FTextBox;

        private TabPage tabPageD;

        private TextBox D_postTextBox;

        private TextBox d_OTextBox;

        private TextBox d_ITextBox;

        private TextBox d_FTextBox;

        private TabPage tabPageT;

        private TextBox T_postTextBox;

        private TextBox t_OTextBox;

        private TextBox t_ITextBox;

        private TextBox t_FTextBox;

        private TabPage tabPageAddress;

        private TabPage tabPageContacts;

        private ToolStrip toolStrip1;

        private ToolStripButton tsbAddressHistory;

        private GroupBox groupBoxAddressP;

        private RichTextBox richTextBoxAddressP;

        private GroupBox groupBoxAddressL;

        private RichTextBox richTextBoxAddressL;

        private ToolStrip toolStripContact;

        private ToolStripButton toolStripButtonNewContact;

        private ToolStripButton toolStripButtonEditContac;

        private ToolStripButton toolStripButtonDelContact;

        private BindingSource bsAbnContact;

        private DataGridView dGVAbnContact;

        private DataGridViewTextBoxColumn idDGVTBC;

        private DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn1;

        private DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn fDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn iDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn dateChangeDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        private ToolStrip toolStripCont;

        private ToolStripButton toolBtnAddCont;

        private ToolStripButton toolBtnEditCont;

        private ToolStripButton toolBtnDelCont;

        private ToolStrip toolStripObj;

        private ToolStripButton toolBtnAddObj;

        private ToolStripButton toolBtnEditObj;

        private ToolStripButton toolBtnDelObj;

        private ToolStripSeparator toolStripSeparator1;

        private ToolStripButton toolBtnShowDelAbn;

        private DataGridViewTextBoxColumn idObjDgvColumn;

        private DataGridViewTextBoxColumn idObjRegDgvColumn;

        private DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idMapDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn nameObjDgvColumn;

        private DataGridViewTextBoxColumn addressULDgvColumn;

        private DataGridViewTextBoxColumn addressFLDgvColumn;

        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idCityDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idRaionDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn raionDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idStreetDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn housePrefixDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn houseAllDataGridViewTextBoxColumn;

        private DataGridViewCheckBoxColumn isHouseDataGridViewCheckBoxColumn;

        private DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idObjParentDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn typeObjDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn typeObjNameDataGridViewTextBoxColumn;

        private Button buttonОК;

        private Button buttonCancel;

        private TabPage tabPageTypeAbn;

        private ToolStrip toolStripAbnType;

        private ToolStripButton toolStripButton1;

        private ToolStripButton toolStripButton2;

        private ToolStripButton toolStripButton3;

        private DataGridViewExcelFilter dgvAbnType;

        private BindingSource bsAbnType;

        private DataGridViewTextBoxColumn typeKontragentNameDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idAbnTypeDgvColumn;

        private DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn1;

        private DataGridViewTextBoxColumn typeKontragentDataGridViewTextBoxColumn;

        private CheckBox chkVisibleNoActiveAbn;

        private DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idKontragentDgvColumn;

        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn typeNameSocrDgvColumn;

        private DataGridViewTextBoxColumn typeAbnDgvColumn;

        private DataGridViewCheckBoxColumn deletedKontragentDgvColumn;

        private DataGridViewCheckBoxColumn isActiveDgvColumn;
        private Label nameFullLabel;
        private Label bankAcntLabel;
        private Label iNNLabel;
        private Label bankDestLabel;
        private Label kPPLabel;
        private Label bankIDLabel;
        private Label oKVEDLabel;
        private Label oKPOLabel;
        private Label postLabel;
        private Label i_OLabel;
        private Label i_ILabel;
        private Label i_FLabel;
        private Label label6;
        private Label r_OLabel;
        private Label r_ILabel;
        private Label r_FLabel;
        private Label d_OLabel;
        private Label label9;
        private Label d_ILabel;
        private Label d_FLabel;
        private Label label10;
        private Label t_OLabel;
        private Label t_ILabel;
        private Label t_FLabel;
    }
}
