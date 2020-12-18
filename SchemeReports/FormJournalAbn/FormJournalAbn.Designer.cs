using ControlsLbr.DataGridViewExcelFilter;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Abonent
{
	public partial class FormJournalAbnN// : WinFormsUI.Docking.DockContentBase
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
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
		}

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>		
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolBtnFind = new System.Windows.Forms.ToolStripButton();
            this.toolTextFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tooBtnExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkVersion2019 = new System.Windows.Forms.CheckBox();
            this.tabControlFilter = new System.Windows.Forms.TabControl();
            this.tabPageFilter = new System.Windows.Forms.TabPage();
            this.groupBoxAbnObj = new System.Windows.Forms.GroupBox();
            this.chkActiveAbnObj = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHousePrefix = new System.Windows.Forms.TextBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStreet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbRaionObl = new System.Windows.Forms.ComboBox();
            this.labelRaionObl = new System.Windows.Forms.Label();
            this.cmbObl = new System.Windows.Forms.ComboBox();
            this.labelObl = new System.Windows.Forms.Label();
            this.txtNameAbnObj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxAbn = new System.Windows.Forms.GroupBox();
            this.chkShowDelAbn = new System.Windows.Forms.CheckBox();
            this.chkActiveAbn = new System.Windows.Forms.CheckBox();
            this.chkTypeAbn = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameAbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeAbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageFilterAdd = new System.Windows.Forms.TabPage();
            this.groupBoxPoint = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPointNumber = new System.Windows.Forms.TextBox();
            this.cmbPointTypeMeter = new ControlsLbr.MultiColumnComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbPointAll = new System.Windows.Forms.RadioButton();
            this.rbPointCurrent = new System.Windows.Forms.RadioButton();
            this.tabPageAddColumn = new System.Windows.Forms.TabPage();
            this.groupBoxPointAddColumn = new System.Windows.Forms.GroupBox();
            this.chkPointNumber = new System.Windows.Forms.CheckBox();
            this.chkPointTypeMeter = new System.Windows.Forms.CheckBox();
            this.groupBoxLinkSchm = new System.Windows.Forms.GroupBox();
            this.chkSchmObjName = new System.Windows.Forms.CheckBox();
            this.chkCellName = new System.Windows.Forms.CheckBox();
            this.chkBusName = new System.Windows.Forms.CheckBox();
            this.chkSubName = new System.Windows.Forms.CheckBox();
            this.chkPrecision = new System.Windows.Forms.CheckBox();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.dgv = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.deletedAbnDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.activeAbnDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.objActiveDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameAbnDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeAbnNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameAbnObjDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.KladrObjNameDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.StreetNameDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.houseDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.subNameDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.busNameDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.cellNameDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.schmObjNameDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeAbnDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idSchmObjDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.IdSubDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnObjDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.pointTypeMeterDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.pointNumberDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new System.Data.DataSet();
            this.TableFindAbn = new System.Data.DataTable();
            this.dataColumnidAbn = new System.Data.DataColumn();
            this.dataColumnCodeAbonent = new System.Data.DataColumn();
            this.dataColumnNameAbn = new System.Data.DataColumn();
            this.dataColumnTypeAbn = new System.Data.DataColumn();
            this.dataColumnTypeAbnName = new System.Data.DataColumn();
            this.dataColumndeletedAbn = new System.Data.DataColumn();
            this.dataColumnactiveAbn = new System.Data.DataColumn();
            this.dataColumnnameAbnObj = new System.Data.DataColumn();
            this.dataColumnKladrObjName = new System.Data.DataColumn();
            this.dataColumnStreetName = new System.Data.DataColumn();
            this.dataColumnHouse = new System.Data.DataColumn();
            this.dataColumnobjActive = new System.Data.DataColumn();
            this.dataColumnSubName = new System.Data.DataColumn();
            this.dataColumnBusName3 = new System.Data.DataColumn();
            this.dataColumnCellName = new System.Data.DataColumn();
            this.dataColumnSchmObjName = new System.Data.DataColumn();
            this.dataColumnidSchmObj = new System.Data.DataColumn();
            this.dataColumnidAbnObj = new System.Data.DataColumn();
            this.dataColumnIdSub = new System.Data.DataColumn();
            this.dataColumnPointTypeMeter = new System.Data.DataColumn();
            this.dataColumnPointNumber = new System.Data.DataColumn();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.contextMenuDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuShowAbn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuGoToSchemaSchmObj = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuGoToSchemaSubstation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemPassportSubstation = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewFilterTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn3 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn4 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn5 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn6 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn7 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn8 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn9 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn10 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn11 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn12 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn13 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn14 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn15 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn16 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMain.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlFilter.SuspendLayout();
            this.tabPageFilter.SuspendLayout();
            this.groupBoxAbnObj.SuspendLayout();
            this.groupBoxAbn.SuspendLayout();
            this.tabPageFilterAdd.SuspendLayout();
            this.groupBoxPoint.SuspendLayout();
            this.tabPageAddColumn.SuspendLayout();
            this.groupBoxPointAddColumn.SuspendLayout();
            this.groupBoxLinkSchm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableFindAbn)).BeginInit();
            this.contextMenuDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.toolBtnFind,
            this.toolTextFind,
            this.toolBtnFindPrev,
            this.toolBtnFindNext,
            this.toolStripSeparator1,
            this.tooBtnExportToExcel});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1083, 25);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 22);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.Visible = false;
            // 
            // toolBtnFind
            // 
            this.toolBtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFind.Image = global::SchemeReports.Properties.Resources.Find;
            this.toolBtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFind.Name = "toolBtnFind";
            this.toolBtnFind.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFind.Text = "Поиск";
            this.toolBtnFind.Click += new System.EventHandler(this.toolBtnFind_Click);
            // 
            // toolTextFind
            // 
            this.toolTextFind.Name = "toolTextFind";
            this.toolTextFind.Size = new System.Drawing.Size(100, 25);
            this.toolTextFind.ToolTipText = "Текст для поиска";
            this.toolTextFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTextFind_KeyDown);
            // 
            // toolBtnFindPrev
            // 
            this.toolBtnFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = global::SchemeReports.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindPrev.Text = "Поиск назад";
            this.toolBtnFindPrev.Click += new System.EventHandler(this.toolBtnFindPrev_Click);
            // 
            // toolBtnFindNext
            // 
            this.toolBtnFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::SchemeReports.Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindNext.Text = "Поиск вперед";
            this.toolBtnFindNext.Click += new System.EventHandler(this.toolBtnFindNext_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tooBtnExportToExcel
            // 
            this.tooBtnExportToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooBtnExportToExcel.Image = global::SchemeReports.Properties.Resources.Excel;
            this.tooBtnExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooBtnExportToExcel.Name = "tooBtnExportToExcel";
            this.tooBtnExportToExcel.Size = new System.Drawing.Size(23, 22);
            this.tooBtnExportToExcel.Text = "Экспорт в Excel";
            this.tooBtnExportToExcel.Click += new System.EventHandler(this.tooBtnExportToExcel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlFilter);
            this.splitContainer1.Panel1.Controls.Add(this.chkPrecision);
            this.splitContainer1.Panel1.Controls.Add(this.buttonApplyFilter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv);
            this.splitContainer1.Size = new System.Drawing.Size(1083, 643);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 1;
            // 
            // chkVersion2019
            // 
            this.chkVersion2019.AutoSize = true;
            this.chkVersion2019.Location = new System.Drawing.Point(9, 253);
            this.chkVersion2019.Name = "chkVersion2019";
            this.chkVersion2019.Size = new System.Drawing.Size(90, 17);
            this.chkVersion2019.TabIndex = 2;
            this.chkVersion2019.Text = "Версия 2019";
            this.chkVersion2019.UseVisualStyleBackColor = true;
            // 
            // tabControlFilter
            // 
            this.tabControlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlFilter.Controls.Add(this.tabPageFilter);
            this.tabControlFilter.Controls.Add(this.tabPageFilterAdd);
            this.tabControlFilter.Controls.Add(this.tabPageAddColumn);
            this.tabControlFilter.Location = new System.Drawing.Point(4, 3);
            this.tabControlFilter.Name = "tabControlFilter";
            this.tabControlFilter.SelectedIndex = 0;
            this.tabControlFilter.Size = new System.Drawing.Size(259, 559);
            this.tabControlFilter.TabIndex = 0;
            this.tabControlFilter.SelectedIndexChanged += new System.EventHandler(this.tabControlFilter_SelectedIndexChanged);
            // 
            // tabPageFilter
            // 
            this.tabPageFilter.AutoScroll = true;
            this.tabPageFilter.Controls.Add(this.groupBoxAbnObj);
            this.tabPageFilter.Controls.Add(this.groupBoxAbn);
            this.tabPageFilter.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilter.Name = "tabPageFilter";
            this.tabPageFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilter.Size = new System.Drawing.Size(251, 533);
            this.tabPageFilter.TabIndex = 0;
            this.tabPageFilter.Text = "Фильтр";
            this.tabPageFilter.UseVisualStyleBackColor = true;
            // 
            // groupBoxAbnObj
            // 
            this.groupBoxAbnObj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAbnObj.Controls.Add(this.chkActiveAbnObj);
            this.groupBoxAbnObj.Controls.Add(this.label7);
            this.groupBoxAbnObj.Controls.Add(this.txtHousePrefix);
            this.groupBoxAbnObj.Controls.Add(this.txtHouse);
            this.groupBoxAbnObj.Controls.Add(this.label8);
            this.groupBoxAbnObj.Controls.Add(this.cmbStreet);
            this.groupBoxAbnObj.Controls.Add(this.label6);
            this.groupBoxAbnObj.Controls.Add(this.label5);
            this.groupBoxAbnObj.Controls.Add(this.cmbCity);
            this.groupBoxAbnObj.Controls.Add(this.cmbRaionObl);
            this.groupBoxAbnObj.Controls.Add(this.labelRaionObl);
            this.groupBoxAbnObj.Controls.Add(this.cmbObl);
            this.groupBoxAbnObj.Controls.Add(this.labelObl);
            this.groupBoxAbnObj.Controls.Add(this.txtNameAbnObj);
            this.groupBoxAbnObj.Controls.Add(this.label4);
            this.groupBoxAbnObj.Location = new System.Drawing.Point(0, 287);
            this.groupBoxAbnObj.Name = "groupBoxAbnObj";
            this.groupBoxAbnObj.Size = new System.Drawing.Size(251, 206);
            this.groupBoxAbnObj.TabIndex = 1;
            this.groupBoxAbnObj.TabStop = false;
            this.groupBoxAbnObj.Text = "Объект абонента";
            // 
            // chkActiveAbnObj
            // 
            this.chkActiveAbnObj.AutoSize = true;
            this.chkActiveAbnObj.Checked = true;
            this.chkActiveAbnObj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActiveAbnObj.Location = new System.Drawing.Point(9, 180);
            this.chkActiveAbnObj.Name = "chkActiveAbnObj";
            this.chkActiveAbnObj.Size = new System.Drawing.Size(115, 17);
            this.chkActiveAbnObj.TabIndex = 27;
            this.chkActiveAbnObj.Text = "Только активные";
            this.chkActiveAbnObj.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Преф";
            // 
            // txtHousePrefix
            // 
            this.txtHousePrefix.Location = new System.Drawing.Point(147, 154);
            this.txtHousePrefix.Name = "txtHousePrefix";
            this.txtHousePrefix.Size = new System.Drawing.Size(38, 20);
            this.txtHousePrefix.TabIndex = 26;
            // 
            // txtHouse
            // 
            this.txtHouse.Location = new System.Drawing.Point(48, 154);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(41, 20);
            this.txtHouse.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Дом";
            // 
            // cmbStreet
            // 
            this.cmbStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStreet.DisplayMember = "tR_KladrStreet.NameSocr";
            this.cmbStreet.FormattingEnabled = true;
            this.cmbStreet.Location = new System.Drawing.Point(92, 130);
            this.cmbStreet.Name = "cmbStreet";
            this.cmbStreet.Size = new System.Drawing.Size(152, 21);
            this.cmbStreet.TabIndex = 22;
            this.cmbStreet.ValueMember = "tR_KladrStreet.Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Улица";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Нас. пункт";
            // 
            // cmbCity
            // 
            this.cmbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(92, 103);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(152, 21);
            this.cmbCity.TabIndex = 20;
            this.cmbCity.ValueMember = "tR_KladrObj.Id";
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // cmbRaionObl
            // 
            this.cmbRaionObl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRaionObl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRaionObl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRaionObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbRaionObl.FormattingEnabled = true;
            this.cmbRaionObl.Location = new System.Drawing.Point(92, 75);
            this.cmbRaionObl.Name = "cmbRaionObl";
            this.cmbRaionObl.Size = new System.Drawing.Size(152, 21);
            this.cmbRaionObl.TabIndex = 18;
            this.cmbRaionObl.ValueMember = "tR_KladrObj.Id";
            this.cmbRaionObl.SelectedIndexChanged += new System.EventHandler(this.cmbRaionObl_SelectedIndexChanged);
            // 
            // labelRaionObl
            // 
            this.labelRaionObl.AutoSize = true;
            this.labelRaionObl.Location = new System.Drawing.Point(3, 78);
            this.labelRaionObl.Name = "labelRaionObl";
            this.labelRaionObl.Size = new System.Drawing.Size(72, 13);
            this.labelRaionObl.TabIndex = 17;
            this.labelRaionObl.Text = "Район/город";
            // 
            // cmbObl
            // 
            this.cmbObl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbObl.FormattingEnabled = true;
            this.cmbObl.Location = new System.Drawing.Point(92, 48);
            this.cmbObl.Name = "cmbObl";
            this.cmbObl.Size = new System.Drawing.Size(152, 21);
            this.cmbObl.TabIndex = 16;
            this.cmbObl.ValueMember = "tR_KladrObj.Id";
            this.cmbObl.SelectedIndexChanged += new System.EventHandler(this.cmbObl_SelectedIndexChanged);
            // 
            // labelObl
            // 
            this.labelObl.AutoSize = true;
            this.labelObl.Location = new System.Drawing.Point(6, 51);
            this.labelObl.Name = "labelObl";
            this.labelObl.Size = new System.Drawing.Size(50, 13);
            this.labelObl.TabIndex = 15;
            this.labelObl.Text = "Область";
            // 
            // txtNameAbnObj
            // 
            this.txtNameAbnObj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameAbnObj.Location = new System.Drawing.Point(92, 22);
            this.txtNameAbnObj.Name = "txtNameAbnObj";
            this.txtNameAbnObj.Size = new System.Drawing.Size(153, 20);
            this.txtNameAbnObj.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Наименование";
            // 
            // groupBoxAbn
            // 
            this.groupBoxAbn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAbn.Controls.Add(this.chkVersion2019);
            this.groupBoxAbn.Controls.Add(this.chkShowDelAbn);
            this.groupBoxAbn.Controls.Add(this.chkActiveAbn);
            this.groupBoxAbn.Controls.Add(this.chkTypeAbn);
            this.groupBoxAbn.Controls.Add(this.label3);
            this.groupBoxAbn.Controls.Add(this.txtNameAbn);
            this.groupBoxAbn.Controls.Add(this.label2);
            this.groupBoxAbn.Controls.Add(this.txtCodeAbn);
            this.groupBoxAbn.Controls.Add(this.label1);
            this.groupBoxAbn.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAbn.Name = "groupBoxAbn";
            this.groupBoxAbn.Size = new System.Drawing.Size(251, 281);
            this.groupBoxAbn.TabIndex = 0;
            this.groupBoxAbn.TabStop = false;
            this.groupBoxAbn.Text = "Абонент";
            // 
            // chkShowDelAbn
            // 
            this.chkShowDelAbn.AutoSize = true;
            this.chkShowDelAbn.Location = new System.Drawing.Point(9, 230);
            this.chkShowDelAbn.Name = "chkShowDelAbn";
            this.chkShowDelAbn.Size = new System.Drawing.Size(132, 17);
            this.chkShowDelAbn.TabIndex = 7;
            this.chkShowDelAbn.Text = "Показать удаленных";
            this.chkShowDelAbn.UseVisualStyleBackColor = true;
            // 
            // chkActiveAbn
            // 
            this.chkActiveAbn.AutoSize = true;
            this.chkActiveAbn.Checked = true;
            this.chkActiveAbn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActiveAbn.Location = new System.Drawing.Point(9, 207);
            this.chkActiveAbn.Name = "chkActiveAbn";
            this.chkActiveAbn.Size = new System.Drawing.Size(115, 17);
            this.chkActiveAbn.TabIndex = 6;
            this.chkActiveAbn.Text = "Только активные";
            this.chkActiveAbn.UseVisualStyleBackColor = true;
            // 
            // chkTypeAbn
            // 
            this.chkTypeAbn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTypeAbn.CheckOnClick = true;
            this.chkTypeAbn.FormattingEnabled = true;
            this.chkTypeAbn.Location = new System.Drawing.Point(6, 92);
            this.chkTypeAbn.Name = "chkTypeAbn";
            this.chkTypeAbn.Size = new System.Drawing.Size(239, 109);
            this.chkTypeAbn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип абонента";
            // 
            // txtNameAbn
            // 
            this.txtNameAbn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameAbn.Location = new System.Drawing.Point(92, 48);
            this.txtNameAbn.Name = "txtNameAbn";
            this.txtNameAbn.Size = new System.Drawing.Size(153, 20);
            this.txtNameAbn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование";
            // 
            // txtCodeAbn
            // 
            this.txtCodeAbn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeAbn.Location = new System.Drawing.Point(92, 22);
            this.txtCodeAbn.Name = "txtCodeAbn";
            this.txtCodeAbn.Size = new System.Drawing.Size(153, 20);
            this.txtCodeAbn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код";
            // 
            // tabPageFilterAdd
            // 
            this.tabPageFilterAdd.AutoScroll = true;
            this.tabPageFilterAdd.Controls.Add(this.groupBoxPoint);
            this.tabPageFilterAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilterAdd.Name = "tabPageFilterAdd";
            this.tabPageFilterAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilterAdd.Size = new System.Drawing.Size(251, 533);
            this.tabPageFilterAdd.TabIndex = 1;
            this.tabPageFilterAdd.Text = "Расширенный фильтр";
            this.tabPageFilterAdd.UseVisualStyleBackColor = true;
            // 
            // groupBoxPoint
            // 
            this.groupBoxPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPoint.Controls.Add(this.label10);
            this.groupBoxPoint.Controls.Add(this.txtPointNumber);
            this.groupBoxPoint.Controls.Add(this.cmbPointTypeMeter);
            this.groupBoxPoint.Controls.Add(this.label9);
            this.groupBoxPoint.Controls.Add(this.rbPointAll);
            this.groupBoxPoint.Controls.Add(this.rbPointCurrent);
            this.groupBoxPoint.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPoint.Name = "groupBoxPoint";
            this.groupBoxPoint.Size = new System.Drawing.Size(251, 337);
            this.groupBoxPoint.TabIndex = 0;
            this.groupBoxPoint.TabStop = false;
            this.groupBoxPoint.Text = "Точка учета";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Номер счетчика";
            // 
            // txtPointNumber
            // 
            this.txtPointNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPointNumber.Location = new System.Drawing.Point(101, 69);
            this.txtPointNumber.Name = "txtPointNumber";
            this.txtPointNumber.Size = new System.Drawing.Size(143, 20);
            this.txtPointNumber.TabIndex = 5;
            this.txtPointNumber.TextChanged += new System.EventHandler(this.txtPointNumber_TextChanged);
            // 
            // cmbPointTypeMeter
            // 
            this.cmbPointTypeMeter.AutoComplete = true;
            this.cmbPointTypeMeter.AutoDropdown = true;
            this.cmbPointTypeMeter.BackColorEven = System.Drawing.Color.White;
            this.cmbPointTypeMeter.BackColorOdd = System.Drawing.Color.White;
            this.cmbPointTypeMeter.ColumnNames = "";
            this.cmbPointTypeMeter.ColumnWidthDefault = 75;
            this.cmbPointTypeMeter.ColumnWidths = "0;100;25;25;30;25";
            this.cmbPointTypeMeter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPointTypeMeter.FormattingEnabled = true;
            this.cmbPointTypeMeter.LinkedColumnIndex = 0;
            this.cmbPointTypeMeter.LinkedTextBox = null;
            this.cmbPointTypeMeter.Location = new System.Drawing.Point(101, 42);
            this.cmbPointTypeMeter.Name = "cmbPointTypeMeter";
            this.cmbPointTypeMeter.Size = new System.Drawing.Size(144, 21);
            this.cmbPointTypeMeter.TabIndex = 4;
            this.cmbPointTypeMeter.SelectedIndexChanged += new System.EventHandler(this.cmbPointTypeMeter_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Тип счетчика";
            // 
            // rbPointAll
            // 
            this.rbPointAll.AutoSize = true;
            this.rbPointAll.Location = new System.Drawing.Point(120, 19);
            this.rbPointAll.Name = "rbPointAll";
            this.rbPointAll.Size = new System.Drawing.Size(44, 17);
            this.rbPointAll.TabIndex = 1;
            this.rbPointAll.TabStop = true;
            this.rbPointAll.Text = "Все";
            this.toolTip.SetToolTip(this.rbPointAll, "Все счетчики, включая демонтированные");
            this.rbPointAll.UseVisualStyleBackColor = true;
            // 
            // rbPointCurrent
            // 
            this.rbPointCurrent.AutoSize = true;
            this.rbPointCurrent.Checked = true;
            this.rbPointCurrent.Location = new System.Drawing.Point(8, 19);
            this.rbPointCurrent.Name = "rbPointCurrent";
            this.rbPointCurrent.Size = new System.Drawing.Size(97, 17);
            this.rbPointCurrent.TabIndex = 0;
            this.rbPointCurrent.TabStop = true;
            this.rbPointCurrent.Text = "Действующие";
            this.toolTip.SetToolTip(this.rbPointCurrent, "Счетчики, которые установлены в данный момент");
            this.rbPointCurrent.UseVisualStyleBackColor = true;
            // 
            // tabPageAddColumn
            // 
            this.tabPageAddColumn.AutoScroll = true;
            this.tabPageAddColumn.Controls.Add(this.groupBoxPointAddColumn);
            this.tabPageAddColumn.Controls.Add(this.groupBoxLinkSchm);
            this.tabPageAddColumn.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddColumn.Name = "tabPageAddColumn";
            this.tabPageAddColumn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddColumn.Size = new System.Drawing.Size(251, 533);
            this.tabPageAddColumn.TabIndex = 2;
            this.tabPageAddColumn.Text = "Доп столбцы";
            this.tabPageAddColumn.UseVisualStyleBackColor = true;
            // 
            // groupBoxPointAddColumn
            // 
            this.groupBoxPointAddColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPointAddColumn.Controls.Add(this.chkPointNumber);
            this.groupBoxPointAddColumn.Controls.Add(this.chkPointTypeMeter);
            this.groupBoxPointAddColumn.Location = new System.Drawing.Point(0, 111);
            this.groupBoxPointAddColumn.Name = "groupBoxPointAddColumn";
            this.groupBoxPointAddColumn.Size = new System.Drawing.Size(251, 100);
            this.groupBoxPointAddColumn.TabIndex = 1;
            this.groupBoxPointAddColumn.TabStop = false;
            this.groupBoxPointAddColumn.Text = "Точка учета";
            // 
            // chkPointNumber
            // 
            this.chkPointNumber.AutoSize = true;
            this.chkPointNumber.Location = new System.Drawing.Point(8, 42);
            this.chkPointNumber.Name = "chkPointNumber";
            this.chkPointNumber.Size = new System.Drawing.Size(108, 17);
            this.chkPointNumber.TabIndex = 1;
            this.chkPointNumber.Text = "Номер счетчика";
            this.chkPointNumber.UseVisualStyleBackColor = true;
            // 
            // chkPointTypeMeter
            // 
            this.chkPointTypeMeter.AutoSize = true;
            this.chkPointTypeMeter.Location = new System.Drawing.Point(8, 19);
            this.chkPointTypeMeter.Name = "chkPointTypeMeter";
            this.chkPointTypeMeter.Size = new System.Drawing.Size(93, 17);
            this.chkPointTypeMeter.TabIndex = 0;
            this.chkPointTypeMeter.Text = "Тип счетчика";
            this.chkPointTypeMeter.UseVisualStyleBackColor = true;
            // 
            // groupBoxLinkSchm
            // 
            this.groupBoxLinkSchm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLinkSchm.Controls.Add(this.chkSchmObjName);
            this.groupBoxLinkSchm.Controls.Add(this.chkCellName);
            this.groupBoxLinkSchm.Controls.Add(this.chkBusName);
            this.groupBoxLinkSchm.Controls.Add(this.chkSubName);
            this.groupBoxLinkSchm.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLinkSchm.Name = "groupBoxLinkSchm";
            this.groupBoxLinkSchm.Size = new System.Drawing.Size(251, 115);
            this.groupBoxLinkSchm.TabIndex = 0;
            this.groupBoxLinkSchm.TabStop = false;
            this.groupBoxLinkSchm.Text = "Привязка к схеме";
            // 
            // chkSchmObjName
            // 
            this.chkSchmObjName.AutoSize = true;
            this.chkSchmObjName.Location = new System.Drawing.Point(8, 88);
            this.chkSchmObjName.Name = "chkSchmObjName";
            this.chkSchmObjName.Size = new System.Drawing.Size(183, 17);
            this.chkSchmObjName.TabIndex = 3;
            this.chkSchmObjName.Text = "Наименование объекта схемы";
            this.chkSchmObjName.UseVisualStyleBackColor = true;
            // 
            // chkCellName
            // 
            this.chkCellName.AutoSize = true;
            this.chkCellName.Location = new System.Drawing.Point(8, 65);
            this.chkCellName.Name = "chkCellName";
            this.chkCellName.Size = new System.Drawing.Size(63, 17);
            this.chkCellName.TabIndex = 2;
            this.chkCellName.Text = "Ячейка";
            this.chkCellName.UseVisualStyleBackColor = true;
            // 
            // chkBusName
            // 
            this.chkBusName.AutoSize = true;
            this.chkBusName.Location = new System.Drawing.Point(8, 42);
            this.chkBusName.Name = "chkBusName";
            this.chkBusName.Size = new System.Drawing.Size(53, 17);
            this.chkBusName.TabIndex = 1;
            this.chkBusName.Text = "Шина";
            this.chkBusName.UseVisualStyleBackColor = true;
            // 
            // chkSubName
            // 
            this.chkSubName.AutoSize = true;
            this.chkSubName.Location = new System.Drawing.Point(8, 19);
            this.chkSubName.Name = "chkSubName";
            this.chkSubName.Size = new System.Drawing.Size(110, 17);
            this.chkSubName.TabIndex = 0;
            this.chkSubName.Text = "Имя подстанции";
            this.chkSubName.UseVisualStyleBackColor = true;
            // 
            // chkPrecision
            // 
            this.chkPrecision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkPrecision.AutoSize = true;
            this.chkPrecision.Location = new System.Drawing.Point(16, 565);
            this.chkPrecision.Name = "chkPrecision";
            this.chkPrecision.Size = new System.Drawing.Size(134, 17);
            this.chkPrecision.TabIndex = 1;
            this.chkPrecision.Text = "Точное соответствие";
            this.chkPrecision.UseVisualStyleBackColor = true;
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApplyFilter.Location = new System.Drawing.Point(16, 608);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(236, 23);
            this.buttonApplyFilter.TabIndex = 0;
            this.buttonApplyFilter.Text = "Применить";
            this.buttonApplyFilter.UseVisualStyleBackColor = true;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deletedAbnDgvColumn,
            this.activeAbnDgvColumn,
            this.objActiveDgvColumn,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.nameAbnDataGridViewTextBoxColumn,
            this.typeAbnNameDataGridViewTextBoxColumn,
            this.nameAbnObjDgvColumn,
            this.KladrObjNameDgvColumn,
            this.StreetNameDgvColumn,
            this.houseDgvColumn,
            this.subNameDgvColumn,
            this.busNameDgvColumn,
            this.cellNameDgvColumn,
            this.schmObjNameDgvColumn,
            this.typeAbnDgvColumn,
            this.idAbnDataGridViewTextBoxColumn,
            this.idSchmObjDgvColumn,
            this.IdSubDgvColumn,
            this.idAbnObjDgvColumn,
            this.pointTypeMeterDgvColumn,
            this.pointNumberDgvColumn});
            this.dgv.DataSource = this.bindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.Size = new System.Drawing.Size(814, 643);
            this.dgv.TabIndex = 0;
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            //this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // deletedAbnDgvColumn
            // 
            this.deletedAbnDgvColumn.DataPropertyName = "deletedAbn";
            this.deletedAbnDgvColumn.HeaderText = "Абонент удален";
            this.deletedAbnDgvColumn.Name = "deletedAbnDgvColumn";
            this.deletedAbnDgvColumn.ReadOnly = true;
            this.deletedAbnDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deletedAbnDgvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.deletedAbnDgvColumn.Visible = false;
            this.deletedAbnDgvColumn.Width = 40;
            // 
            // activeAbnDgvColumn
            // 
            this.activeAbnDgvColumn.DataPropertyName = "activeAbn";
            this.activeAbnDgvColumn.HeaderText = "Активный абонент";
            this.activeAbnDgvColumn.Name = "activeAbnDgvColumn";
            this.activeAbnDgvColumn.ReadOnly = true;
            this.activeAbnDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activeAbnDgvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.activeAbnDgvColumn.Visible = false;
            // 
            // objActiveDgvColumn
            // 
            this.objActiveDgvColumn.DataPropertyName = "objActive";
            this.objActiveDgvColumn.HeaderText = "Активный объект";
            this.objActiveDgvColumn.Name = "objActiveDgvColumn";
            this.objActiveDgvColumn.ReadOnly = true;
            this.objActiveDgvColumn.Visible = false;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameAbnDataGridViewTextBoxColumn
            // 
            this.nameAbnDataGridViewTextBoxColumn.DataPropertyName = "NameAbn";
            this.nameAbnDataGridViewTextBoxColumn.HeaderText = "Абонент";
            this.nameAbnDataGridViewTextBoxColumn.Name = "nameAbnDataGridViewTextBoxColumn";
            this.nameAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAbnDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeAbnNameDataGridViewTextBoxColumn
            // 
            this.typeAbnNameDataGridViewTextBoxColumn.DataPropertyName = "TypeAbnName";
            this.typeAbnNameDataGridViewTextBoxColumn.HeaderText = "Тип абонента";
            this.typeAbnNameDataGridViewTextBoxColumn.Name = "typeAbnNameDataGridViewTextBoxColumn";
            this.typeAbnNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeAbnNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameAbnObjDgvColumn
            // 
            this.nameAbnObjDgvColumn.DataPropertyName = "nameAbnObj";
            this.nameAbnObjDgvColumn.HeaderText = "Объект";
            this.nameAbnObjDgvColumn.Name = "nameAbnObjDgvColumn";
            this.nameAbnObjDgvColumn.ReadOnly = true;
            // 
            // KladrObjNameDgvColumn
            // 
            this.KladrObjNameDgvColumn.DataPropertyName = "KladrObjName";
            this.KladrObjNameDgvColumn.HeaderText = "Нас. пункт";
            this.KladrObjNameDgvColumn.Name = "KladrObjNameDgvColumn";
            this.KladrObjNameDgvColumn.ReadOnly = true;
            // 
            // StreetNameDgvColumn
            // 
            this.StreetNameDgvColumn.DataPropertyName = "StreetName";
            this.StreetNameDgvColumn.HeaderText = "Улица";
            this.StreetNameDgvColumn.Name = "StreetNameDgvColumn";
            this.StreetNameDgvColumn.ReadOnly = true;
            // 
            // houseDgvColumn
            // 
            this.houseDgvColumn.DataPropertyName = "House";
            this.houseDgvColumn.HeaderText = "Дом";
            this.houseDgvColumn.Name = "houseDgvColumn";
            this.houseDgvColumn.ReadOnly = true;
            // 
            // subNameDgvColumn
            // 
            this.subNameDgvColumn.DataPropertyName = "SubName";
            this.subNameDgvColumn.HeaderText = "Подстанция";
            this.subNameDgvColumn.Name = "subNameDgvColumn";
            this.subNameDgvColumn.ReadOnly = true;
            // 
            // busNameDgvColumn
            // 
            this.busNameDgvColumn.DataPropertyName = "BusName";
            this.busNameDgvColumn.HeaderText = "Шина";
            this.busNameDgvColumn.Name = "busNameDgvColumn";
            this.busNameDgvColumn.ReadOnly = true;
            // 
            // cellNameDgvColumn
            // 
            this.cellNameDgvColumn.DataPropertyName = "CellName";
            this.cellNameDgvColumn.HeaderText = "Ячейка";
            this.cellNameDgvColumn.Name = "cellNameDgvColumn";
            this.cellNameDgvColumn.ReadOnly = true;
            // 
            // schmObjNameDgvColumn
            // 
            this.schmObjNameDgvColumn.DataPropertyName = "SchmObjName";
            this.schmObjNameDgvColumn.HeaderText = "Объект схемы";
            this.schmObjNameDgvColumn.Name = "schmObjNameDgvColumn";
            this.schmObjNameDgvColumn.ReadOnly = true;
            // 
            // typeAbnDgvColumn
            // 
            this.typeAbnDgvColumn.AllowUserVisibleColumn = false;
            this.typeAbnDgvColumn.DataPropertyName = "TypeAbn";
            this.typeAbnDgvColumn.HeaderText = "TypeAbn";
            this.typeAbnDgvColumn.Name = "typeAbnDgvColumn";
            this.typeAbnDgvColumn.ReadOnly = true;
            this.typeAbnDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeAbnDgvColumn.Visible = false;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.AllowUserVisibleColumn = false;
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSchmObjDgvColumn
            // 
            this.idSchmObjDgvColumn.AllowUserVisibleColumn = false;
            this.idSchmObjDgvColumn.DataPropertyName = "idSchmObj";
            this.idSchmObjDgvColumn.HeaderText = "idSchmObj";
            this.idSchmObjDgvColumn.Name = "idSchmObjDgvColumn";
            this.idSchmObjDgvColumn.ReadOnly = true;
            this.idSchmObjDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idSchmObjDgvColumn.Visible = false;
            // 
            // IdSubDgvColumn
            // 
            this.IdSubDgvColumn.AllowUserVisibleColumn = false;
            this.IdSubDgvColumn.DataPropertyName = "IdSub";
            this.IdSubDgvColumn.HeaderText = "IdSub";
            this.IdSubDgvColumn.Name = "IdSubDgvColumn";
            this.IdSubDgvColumn.ReadOnly = true;
            this.IdSubDgvColumn.Visible = false;
            // 
            // idAbnObjDgvColumn
            // 
            this.idAbnObjDgvColumn.AllowUserVisibleColumn = false;
            this.idAbnObjDgvColumn.DataPropertyName = "idAbnObj";
            this.idAbnObjDgvColumn.HeaderText = "idAbnObj";
            this.idAbnObjDgvColumn.Name = "idAbnObjDgvColumn";
            this.idAbnObjDgvColumn.ReadOnly = true;
            this.idAbnObjDgvColumn.Visible = false;
            // 
            // pointTypeMeterDgvColumn
            // 
            this.pointTypeMeterDgvColumn.AllowUserVisibleColumn = false;
            this.pointTypeMeterDgvColumn.DataPropertyName = "PointTypeMeter";
            this.pointTypeMeterDgvColumn.HeaderText = "Тип счетчика";
            this.pointTypeMeterDgvColumn.Name = "pointTypeMeterDgvColumn";
            this.pointTypeMeterDgvColumn.ReadOnly = true;
            this.pointTypeMeterDgvColumn.Visible = false;
            // 
            // pointNumberDgvColumn
            // 
            this.pointNumberDgvColumn.AllowUserVisibleColumn = false;
            this.pointNumberDgvColumn.DataPropertyName = "PointNumber";
            this.pointNumberDgvColumn.HeaderText = "№ счетчика";
            this.pointNumberDgvColumn.Name = "pointNumberDgvColumn";
            this.pointNumberDgvColumn.ReadOnly = true;
            this.pointNumberDgvColumn.Visible = false;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "TableFindAbn";
            this.bindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "NewDataSet";
            this.ds.Tables.AddRange(new System.Data.DataTable[] {
            this.TableFindAbn});
            // 
            // TableFindAbn
            // 
            this.TableFindAbn.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumnidAbn,
            this.dataColumnCodeAbonent,
            this.dataColumnNameAbn,
            this.dataColumnTypeAbn,
            this.dataColumnTypeAbnName,
            this.dataColumndeletedAbn,
            this.dataColumnactiveAbn,
            this.dataColumnnameAbnObj,
            this.dataColumnKladrObjName,
            this.dataColumnStreetName,
            this.dataColumnHouse,
            this.dataColumnobjActive,
            this.dataColumnSubName,
            this.dataColumnBusName3,
            this.dataColumnCellName,
            this.dataColumnSchmObjName,
            this.dataColumnidSchmObj,
            this.dataColumnidAbnObj,
            this.dataColumnIdSub,
            this.dataColumnPointTypeMeter,
            this.dataColumnPointNumber});
            this.TableFindAbn.TableName = "TableFindAbn";
            // 
            // dataColumnidAbn
            // 
            this.dataColumnidAbn.ColumnName = "idAbn";
            this.dataColumnidAbn.DataType = typeof(int);
            // 
            // dataColumnCodeAbonent
            // 
            this.dataColumnCodeAbonent.ColumnName = "CodeAbonent";
            this.dataColumnCodeAbonent.DataType = typeof(int);
            // 
            // dataColumnNameAbn
            // 
            this.dataColumnNameAbn.ColumnName = "NameAbn";
            // 
            // dataColumnTypeAbn
            // 
            this.dataColumnTypeAbn.ColumnName = "TypeAbn";
            this.dataColumnTypeAbn.DataType = typeof(int);
            // 
            // dataColumnTypeAbnName
            // 
            this.dataColumnTypeAbnName.ColumnName = "TypeAbnName";
            // 
            // dataColumndeletedAbn
            // 
            this.dataColumndeletedAbn.ColumnName = "deletedAbn";
            this.dataColumndeletedAbn.DataType = typeof(bool);
            // 
            // dataColumnactiveAbn
            // 
            this.dataColumnactiveAbn.ColumnName = "activeAbn";
            this.dataColumnactiveAbn.DataType = typeof(bool);
            // 
            // dataColumnnameAbnObj
            // 
            this.dataColumnnameAbnObj.ColumnName = "nameAbnObj";
            // 
            // dataColumnKladrObjName
            // 
            this.dataColumnKladrObjName.ColumnName = "KladrObjName";
            // 
            // dataColumnStreetName
            // 
            this.dataColumnStreetName.ColumnName = "StreetName";
            // 
            // dataColumnHouse
            // 
            this.dataColumnHouse.ColumnName = "House";
            // 
            // dataColumnobjActive
            // 
            this.dataColumnobjActive.ColumnName = "objActive";
            this.dataColumnobjActive.DataType = typeof(bool);
            // 
            // dataColumnSubName
            // 
            this.dataColumnSubName.ColumnName = "SubName";
            // 
            // dataColumnBusName3
            // 
            this.dataColumnBusName3.ColumnName = "BusName";
            // 
            // dataColumnCellName
            // 
            this.dataColumnCellName.ColumnName = "CellName";
            // 
            // dataColumnSchmObjName
            // 
            this.dataColumnSchmObjName.ColumnName = "SchmObjName";
            // 
            // dataColumnidSchmObj
            // 
            this.dataColumnidSchmObj.ColumnName = "idSchmObj";
            // 
            // dataColumnidAbnObj
            // 
            this.dataColumnidAbnObj.ColumnName = "idAbnObj";
            this.dataColumnidAbnObj.DataType = typeof(int);
            // 
            // dataColumnIdSub
            // 
            this.dataColumnIdSub.ColumnName = "IdSub";
            this.dataColumnIdSub.DataType = typeof(int);
            // 
            // dataColumnPointTypeMeter
            // 
            this.dataColumnPointTypeMeter.ColumnName = "PointTypeMeter";
            // 
            // dataColumnPointNumber
            // 
            this.dataColumnPointNumber.ColumnName = "PointNumber";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // contextMenuDgv
            // 
            this.contextMenuDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuShowAbn,
            this.toolMenuSchema,
            this.toolMenuItemPassportSubstation});
            this.contextMenuDgv.Name = "contextMenuDgv";
            this.contextMenuDgv.Size = new System.Drawing.Size(190, 70);
            this.contextMenuDgv.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuDgv_Opening);
            // 
            // toolMenuShowAbn
            // 
            this.toolMenuShowAbn.Image = global::SchemeReports.Properties.Resources.Person;
            this.toolMenuShowAbn.Name = "toolMenuShowAbn";
            this.toolMenuShowAbn.Size = new System.Drawing.Size(189, 22);
            this.toolMenuShowAbn.Text = "Открыть карточку";
            this.toolMenuShowAbn.Click += new System.EventHandler(this.toolMenuShowAbn_Click);
            // 
            // toolMenuSchema
            // 
            this.toolMenuSchema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuGoToSchemaSchmObj,
            this.toolMenuGoToSchemaSubstation});
            this.toolMenuSchema.Image = global::SchemeReports.Properties.Resources.Scheme_Old;
            this.toolMenuSchema.Name = "toolMenuSchema";
            this.toolMenuSchema.Size = new System.Drawing.Size(189, 22);
            this.toolMenuSchema.Text = "Схема";
            // 
            // toolMenuGoToSchemaSchmObj
            // 
            this.toolMenuGoToSchemaSchmObj.Name = "toolMenuGoToSchemaSchmObj";
            this.toolMenuGoToSchemaSchmObj.Size = new System.Drawing.Size(195, 22);
            this.toolMenuGoToSchemaSchmObj.Text = "Показать на схеме";
            this.toolMenuGoToSchemaSchmObj.Click += new System.EventHandler(this.toolMenuGoToSchemaSchmObj_Click);
            // 
            // toolMenuGoToSchemaSubstation
            // 
            this.toolMenuGoToSchemaSubstation.Name = "toolMenuGoToSchemaSubstation";
            this.toolMenuGoToSchemaSubstation.Size = new System.Drawing.Size(195, 22);
            this.toolMenuGoToSchemaSubstation.Text = "Показать подстанцию";
            this.toolMenuGoToSchemaSubstation.Click += new System.EventHandler(this.toolMenuGoToSchemaSubstation_Click);
            // 
            // toolMenuItemPassportSubstation
            // 
            this.toolMenuItemPassportSubstation.Name = "toolMenuItemPassportSubstation";
            this.toolMenuItemPassportSubstation.Size = new System.Drawing.Size(189, 22);
            this.toolMenuItemPassportSubstation.Text = "Паспорт подстанции";
            this.toolMenuItemPassportSubstation.Click += new System.EventHandler(this.toolMenuItemPassportSubstation_Click);
            // 
            // dataGridViewFilterTextBoxColumn1
            // 
            this.dataGridViewFilterTextBoxColumn1.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn1.DataPropertyName = "CodeAbonent";
            this.dataGridViewFilterTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewFilterTextBoxColumn1.Name = "dataGridViewFilterTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn2
            // 
            this.dataGridViewFilterTextBoxColumn2.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn2.DataPropertyName = "NameAbn";
            this.dataGridViewFilterTextBoxColumn2.HeaderText = "Абонент";
            this.dataGridViewFilterTextBoxColumn2.Name = "dataGridViewFilterTextBoxColumn2";
            this.dataGridViewFilterTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn3
            // 
            this.dataGridViewFilterTextBoxColumn3.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn3.DataPropertyName = "TypeAbnName";
            this.dataGridViewFilterTextBoxColumn3.HeaderText = "Тип абонента";
            this.dataGridViewFilterTextBoxColumn3.Name = "dataGridViewFilterTextBoxColumn3";
            this.dataGridViewFilterTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn4
            // 
            this.dataGridViewFilterTextBoxColumn4.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn4.DataPropertyName = "nameAbnObj";
            this.dataGridViewFilterTextBoxColumn4.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn4.Name = "dataGridViewFilterTextBoxColumn4";
            // 
            // dataGridViewFilterTextBoxColumn5
            // 
            this.dataGridViewFilterTextBoxColumn5.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn5.DataPropertyName = "KladrObjName";
            this.dataGridViewFilterTextBoxColumn5.HeaderText = "Нас. пункт";
            this.dataGridViewFilterTextBoxColumn5.Name = "dataGridViewFilterTextBoxColumn5";
            // 
            // dataGridViewFilterTextBoxColumn6
            // 
            this.dataGridViewFilterTextBoxColumn6.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn6.DataPropertyName = "StreetName";
            this.dataGridViewFilterTextBoxColumn6.HeaderText = "Улица";
            this.dataGridViewFilterTextBoxColumn6.Name = "dataGridViewFilterTextBoxColumn6";
            // 
            // dataGridViewFilterTextBoxColumn7
            // 
            this.dataGridViewFilterTextBoxColumn7.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn7.DataPropertyName = "House";
            this.dataGridViewFilterTextBoxColumn7.HeaderText = "Дом";
            this.dataGridViewFilterTextBoxColumn7.Name = "dataGridViewFilterTextBoxColumn7";
            // 
            // dataGridViewFilterTextBoxColumn8
            // 
            this.dataGridViewFilterTextBoxColumn8.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn8.DataPropertyName = "SubName";
            this.dataGridViewFilterTextBoxColumn8.HeaderText = "Подстанция";
            this.dataGridViewFilterTextBoxColumn8.Name = "dataGridViewFilterTextBoxColumn8";
            this.dataGridViewFilterTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn8.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn9
            // 
            this.dataGridViewFilterTextBoxColumn9.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn9.DataPropertyName = "BusName";
            this.dataGridViewFilterTextBoxColumn9.HeaderText = "Шина";
            this.dataGridViewFilterTextBoxColumn9.Name = "dataGridViewFilterTextBoxColumn9";
            this.dataGridViewFilterTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn9.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn10
            // 
            this.dataGridViewFilterTextBoxColumn10.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn10.DataPropertyName = "CellName";
            this.dataGridViewFilterTextBoxColumn10.HeaderText = "Ячейка";
            this.dataGridViewFilterTextBoxColumn10.Name = "dataGridViewFilterTextBoxColumn10";
            // 
            // dataGridViewFilterTextBoxColumn11
            // 
            this.dataGridViewFilterTextBoxColumn11.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn11.DataPropertyName = "SchmObjName";
            this.dataGridViewFilterTextBoxColumn11.HeaderText = "Объект схемы";
            this.dataGridViewFilterTextBoxColumn11.Name = "dataGridViewFilterTextBoxColumn11";
            // 
            // dataGridViewFilterTextBoxColumn12
            // 
            this.dataGridViewFilterTextBoxColumn12.DataPropertyName = "CellName";
            this.dataGridViewFilterTextBoxColumn12.HeaderText = "Ячейка";
            this.dataGridViewFilterTextBoxColumn12.Name = "dataGridViewFilterTextBoxColumn12";
            // 
            // dataGridViewFilterTextBoxColumn13
            // 
            this.dataGridViewFilterTextBoxColumn13.DataPropertyName = "SchmObjName";
            this.dataGridViewFilterTextBoxColumn13.HeaderText = "Объект схемы";
            this.dataGridViewFilterTextBoxColumn13.Name = "dataGridViewFilterTextBoxColumn13";
            // 
            // dataGridViewFilterTextBoxColumn14
            // 
            this.dataGridViewFilterTextBoxColumn14.DataPropertyName = "idSchmObj";
            this.dataGridViewFilterTextBoxColumn14.HeaderText = "idSchmObj";
            this.dataGridViewFilterTextBoxColumn14.Name = "dataGridViewFilterTextBoxColumn14";
            this.dataGridViewFilterTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn14.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn15
            // 
            this.dataGridViewFilterTextBoxColumn15.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn15.DataPropertyName = "IdSub";
            this.dataGridViewFilterTextBoxColumn15.HeaderText = "IdSub";
            this.dataGridViewFilterTextBoxColumn15.Name = "dataGridViewFilterTextBoxColumn15";
            this.dataGridViewFilterTextBoxColumn15.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn16
            // 
            this.dataGridViewFilterTextBoxColumn16.AllowUserVisibleColumn = false;
            this.dataGridViewFilterTextBoxColumn16.DataPropertyName = "idAbnObj";
            this.dataGridViewFilterTextBoxColumn16.HeaderText = "idAbnObj";
            this.dataGridViewFilterTextBoxColumn16.Name = "dataGridViewFilterTextBoxColumn16";
            this.dataGridViewFilterTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TypeAbn";
            this.dataGridViewTextBoxColumn1.HeaderText = "TypeAbn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn2.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idSchmObj";
            this.dataGridViewTextBoxColumn3.HeaderText = "idSchmObj";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // FormJournalAbn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 668);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormJournalAbn";
            this.Text = "Журнал контрагентов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJournalAbn_FormClosed);
            this.Load += new System.EventHandler(this.FormJournalAbn_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControlFilter.ResumeLayout(false);
            this.tabPageFilter.ResumeLayout(false);
            this.groupBoxAbnObj.ResumeLayout(false);
            this.groupBoxAbnObj.PerformLayout();
            this.groupBoxAbn.ResumeLayout(false);
            this.groupBoxAbn.PerformLayout();
            this.tabPageFilterAdd.ResumeLayout(false);
            this.groupBoxPoint.ResumeLayout(false);
            this.groupBoxPoint.PerformLayout();
            this.tabPageAddColumn.ResumeLayout(false);
            this.groupBoxPointAddColumn.ResumeLayout(false);
            this.groupBoxPointAddColumn.PerformLayout();
            this.groupBoxLinkSchm.ResumeLayout(false);
            this.groupBoxLinkSchm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableFindAbn)).EndInit();
            this.contextMenuDgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ToolStrip toolStripMain;
        private SplitContainer splitContainer1;
        private TabControl tabControlFilter;
        private TabPage tabPageFilter;
        private GroupBox groupBoxAbn;
        private CheckedListBox chkTypeAbn;
        private Label label3;
        private TextBox txtNameAbn;
        private Label label2;
        private TextBox txtCodeAbn;
        private Label label1;
        private TabPage tabPageFilterAdd;
        private Button buttonApplyFilter;
        private ToolStripProgressBar progressBar;
        private DataGridViewExcelFilter dgv;
        private BindingSource bindingSource;
        private DataSet ds;
        private DataTable TableFindAbn;
        private DataColumn dataColumnidAbn;
        private DataColumn dataColumnCodeAbonent;
        private DataColumn dataColumnNameAbn;
        private DataColumn dataColumnTypeAbn;
        private DataColumn dataColumnTypeAbnName;
        private DataColumn dataColumndeletedAbn;
        private BackgroundWorker backgroundWorker;
        private CheckBox chkPrecision;
        private DataColumn dataColumnactiveAbn;
        private CheckBox chkShowDelAbn;
        private CheckBox chkActiveAbn;
        private GroupBox groupBoxAbnObj;
        private TextBox txtNameAbnObj;
        private Label label4;
        private DataColumn dataColumnnameAbnObj;
        private Label label5;
        private ComboBox cmbCity;
        private ComboBox cmbRaionObl;
        private Label labelRaionObl;
        private ComboBox cmbObl;
        private Label labelObl;
        private ComboBox cmbStreet;
        private Label label6;
        private Label label7;
        private TextBox txtHousePrefix;
        private TextBox txtHouse;
        private Label label8;
        private DataColumn dataColumnKladrObjName;
        private DataColumn dataColumnStreetName;
        private DataColumn dataColumnHouse;
        private CheckBox chkActiveAbnObj;
        private DataColumn dataColumnobjActive;
        private TabPage tabPageAddColumn;
        private GroupBox groupBoxLinkSchm;
        private CheckBox chkSchmObjName;
        private CheckBox chkCellName;
        private CheckBox chkBusName;
        private CheckBox chkSubName;
        private DataColumn dataColumnSubName;
        private DataColumn dataColumnBusName3;
        private DataColumn dataColumnCellName;
        private DataColumn dataColumnSchmObjName;
        private DataColumn dataColumnidSchmObj;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn8;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn9;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn10;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn12;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn13;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn14;
        private ContextMenuStrip contextMenuDgv;
        private ToolStripMenuItem toolMenuShowAbn;
        private ToolStripMenuItem toolMenuGoToSchemaSchmObj;
        private DataColumn dataColumnidAbnObj;
        private ToolStripButton toolBtnFind;
        private ToolStripTextBox toolTextFind;
        private ToolStripButton toolBtnFindPrev;
        private ToolStripButton toolBtnFindNext;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tooBtnExportToExcel;
        private DataColumn dataColumnIdSub;
        private ToolStripMenuItem toolMenuSchema;
        private ToolStripMenuItem toolMenuGoToSchemaSubstation;
        private ToolStripMenuItem toolMenuItemPassportSubstation;
        private GroupBox groupBoxPoint;
        private Label label9;
        private RadioButton rbPointAll;
        private ToolTip toolTip;
        private RadioButton rbPointCurrent;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn15;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn16;
        private Label label10;
        private TextBox txtPointNumber;
        private ControlsLbr.MultiColumnComboBox cmbPointTypeMeter;
        private GroupBox groupBoxPointAddColumn;
        private CheckBox chkPointNumber;
        private CheckBox chkPointTypeMeter;
        private DataColumn dataColumnPointTypeMeter;
        private DataColumn dataColumnPointNumber;
        private CheckBox chkVersion2019;
        private DataGridViewFilterCheckBoxColumn deletedAbnDgvColumn;
        private DataGridViewFilterCheckBoxColumn activeAbnDgvColumn;
        private DataGridViewFilterCheckBoxColumn objActiveDgvColumn;
        private DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn nameAbnDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn typeAbnNameDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn nameAbnObjDgvColumn;
        private DataGridViewFilterTextBoxColumn KladrObjNameDgvColumn;
        private DataGridViewFilterTextBoxColumn StreetNameDgvColumn;
        private DataGridViewFilterTextBoxColumn houseDgvColumn;
        private DataGridViewFilterTextBoxColumn subNameDgvColumn;
        private DataGridViewFilterTextBoxColumn busNameDgvColumn;
        private DataGridViewFilterTextBoxColumn cellNameDgvColumn;
        private DataGridViewFilterTextBoxColumn schmObjNameDgvColumn;
        private DataGridViewFilterTextBoxColumn typeAbnDgvColumn;
        private DataGridViewFilterTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn idSchmObjDgvColumn;
        private DataGridViewFilterTextBoxColumn IdSubDgvColumn;
        private DataGridViewFilterTextBoxColumn idAbnObjDgvColumn;
        private DataGridViewFilterTextBoxColumn pointTypeMeterDgvColumn;
        private DataGridViewFilterTextBoxColumn pointNumberDgvColumn;
    }
}
