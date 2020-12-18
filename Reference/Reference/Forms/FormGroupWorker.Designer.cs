namespace Reference.Forms
{
	public partial class FormGroupWorker : FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.icontainer_0 = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Reference.Forms.FormGroupWorker));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.toolBtnAddWorkerInGroup = new System.Windows.Forms.ToolStripButton();
			this.toolBtnDelWorkerFromGroup = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolBtnShowDelWorker = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
			this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonFindPrev = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonFindNext = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
			this.hLohhVholv = new System.Windows.Forms.SplitContainer();
			this.treeViewGroup = new System.Windows.Forms.TreeView();
			this.toolStripTree = new System.Windows.Forms.ToolStrip();
			this.toolBtnShowDeleteGroup = new System.Windows.Forms.ToolStripButton();
			this.toolTxtFindTreeGroup = new System.Windows.Forms.ToolStripTextBox();
			this.toolBtnFindTreeGroup = new System.Windows.Forms.ToolStripButton();
			this.dgvGroupWorker = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
			this.idDgvTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDRRefDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.fDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.class48_0 = new Class48();
			this.divisionCurrentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateEndDgvTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.toolStripMain.SuspendLayout();
			this.hLohhVholv.Panel1.SuspendLayout();
			this.hLohhVholv.Panel2.SuspendLayout();
			this.hLohhVholv.SuspendLayout();
			this.toolStripTree.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvGroupWorker).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class48_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).BeginInit();
			base.SuspendLayout();
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnAddWorkerInGroup,
				this.toolBtnDelWorkerFromGroup,
				this.toolStripSeparator1,
				this.toolBtnShowDelWorker,
				this.toolStripSeparator2,
				this.toolStripButtonFind,
				this.toolStripTextBoxFind,
				this.toolStripButtonFindPrev,
				this.toolStripButtonFindNext,
				this.toolStripSeparator3,
				this.toolStripButtonPrint,
				this.toolStripSeparator4,
				this.toolStripButtonExportExcel,
				this.toolStripSeparator5,
				this.toolStripButtonRefresh
			});
			this.toolStripMain.Location = new System.Drawing.Point(0, 0);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Size = new System.Drawing.Size(823, 25);
			this.toolStripMain.TabIndex = 0;
			this.toolStripMain.Text = "toolStrip1";
			this.toolBtnAddWorkerInGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnAddWorkerInGroup.Image = Reference.Properties.Resources.smethod_9();
			this.toolBtnAddWorkerInGroup.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnAddWorkerInGroup.Name = "toolBtnAddWorkerInGroup";
			this.toolBtnAddWorkerInGroup.Size = new System.Drawing.Size(23, 22);
			this.toolBtnAddWorkerInGroup.Text = "Добавить в группу";
			this.toolBtnAddWorkerInGroup.Click += new System.EventHandler(this.toolBtnAddWorkerInGroup_Click);
			this.toolBtnDelWorkerFromGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDelWorkerFromGroup.Image = Reference.Properties.Resources.smethod_10();
			this.toolBtnDelWorkerFromGroup.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDelWorkerFromGroup.Name = "toolBtnDelWorkerFromGroup";
			this.toolBtnDelWorkerFromGroup.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDelWorkerFromGroup.Text = "Удалить из группы";
			this.toolBtnDelWorkerFromGroup.Click += new System.EventHandler(this.toolBtnDelWorkerFromGroup_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			this.toolBtnShowDelWorker.CheckOnClick = true;
			this.toolBtnShowDelWorker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnShowDelWorker.Image = Reference.Properties.Resources.smethod_24();
			this.toolBtnShowDelWorker.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDelWorker.Name = "toolBtnShowDelWorker";
			this.toolBtnShowDelWorker.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDelWorker.Text = "Показать удаленных";
			this.toolBtnShowDelWorker.Click += new System.EventHandler(this.toolBtnShowDelWorker_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFind.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonFind.Image");
			this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFind.Name = "toolStripButtonFind";
			this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFind.Text = "Поиск";
			this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
			this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
			this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBoxFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxFind_KeyDown);
			this.toolStripButtonFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFindPrev.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonFindPrev.Image");
			this.toolStripButtonFindPrev.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFindPrev.Name = "toolStripButtonFindPrev";
			this.toolStripButtonFindPrev.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFindPrev.Text = "Поиск назад";
			this.toolStripButtonFindPrev.Click += new System.EventHandler(this.toolStripButtonFindPrev_Click);
			this.toolStripButtonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFindNext.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonFindNext.Image");
			this.toolStripButtonFindNext.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFindNext.Name = "toolStripButtonFindNext";
			this.toolStripButtonFindNext.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFindNext.Text = "Поиск вперед";
			this.toolStripButtonFindNext.Click += new System.EventHandler(this.toolStripButtonFindNext_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPrint.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonPrint.Image");
			this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonPrint.Name = "toolStripButtonPrint";
			this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonPrint.Text = "Печать";
			this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExportExcel.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonExportExcel.Image");
			this.toolStripButtonExportExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonExportExcel.Name = "toolStripButtonExportExcel";
			this.toolStripButtonExportExcel.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonExportExcel.Text = "Экспорт в Excel";
			this.toolStripButtonExportExcel.Click += new System.EventHandler(this.toolStripButtonExportExcel_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRefresh.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonRefresh.Image");
			this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
			this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonRefresh.Text = "Обновить";
			this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
			this.hLohhVholv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hLohhVholv.Location = new System.Drawing.Point(0, 25);
			this.hLohhVholv.Name = "splitContainerMain";
			this.hLohhVholv.Panel1.Controls.Add(this.treeViewGroup);
			this.hLohhVholv.Panel1.Controls.Add(this.toolStripTree);
			this.hLohhVholv.Panel2.Controls.Add(this.dgvGroupWorker);
			this.hLohhVholv.Size = new System.Drawing.Size(823, 365);
			this.hLohhVholv.SplitterDistance = 230;
			this.hLohhVholv.TabIndex = 1;
			this.treeViewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewGroup.Location = new System.Drawing.Point(0, 25);
			this.treeViewGroup.Name = "treeViewGroup";
			this.treeViewGroup.Size = new System.Drawing.Size(230, 340);
			this.treeViewGroup.TabIndex = 1;
			this.treeViewGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewGroup_AfterSelect);
			this.toolStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnShowDeleteGroup,
				this.toolTxtFindTreeGroup,
				this.toolBtnFindTreeGroup
			});
			this.toolStripTree.Location = new System.Drawing.Point(0, 0);
			this.toolStripTree.Name = "toolStripTree";
			this.toolStripTree.Size = new System.Drawing.Size(230, 25);
			this.toolStripTree.TabIndex = 0;
			this.toolStripTree.Text = "toolStrip2";
			this.toolBtnShowDeleteGroup.CheckOnClick = true;
			this.toolBtnShowDeleteGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnShowDeleteGroup.Image = Reference.Properties.Resources.smethod_24();
			this.toolBtnShowDeleteGroup.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDeleteGroup.Name = "toolBtnShowDeleteGroup";
			this.toolBtnShowDeleteGroup.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDeleteGroup.Text = "Показать удаленные";
			this.toolBtnShowDeleteGroup.Click += new System.EventHandler(this.toolBtnShowDeleteGroup_Click);
			this.toolTxtFindTreeGroup.Name = "toolTxtFindTreeGroup";
			this.toolTxtFindTreeGroup.Size = new System.Drawing.Size(100, 25);
			this.toolTxtFindTreeGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTxtFindTreeGroup_KeyDown);
			this.toolBtnFindTreeGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnFindTreeGroup.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnFindTreeGroup.Image");
			this.toolBtnFindTreeGroup.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnFindTreeGroup.Name = "toolBtnFindTreeGroup";
			this.toolBtnFindTreeGroup.Size = new System.Drawing.Size(23, 22);
			this.toolBtnFindTreeGroup.Text = "Поиск";
			this.toolBtnFindTreeGroup.Click += new System.EventHandler(this.toolBtnFindTreeGroup_Click);
			this.dgvGroupWorker.AllowUserToAddRows = false;
			this.dgvGroupWorker.AllowUserToDeleteRows = false;
			dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
			this.dgvGroupWorker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dgvGroupWorker.AutoGenerateColumns = false;
			this.dgvGroupWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroupWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idDgvTxtColumn,
				this.iDRRefDataGridViewImageColumn,
				this.fDataGridViewTextBoxColumn,
				this.iDataGridViewTextBoxColumn,
				this.oDataGridViewTextBoxColumn,
				this.jobTitleDataGridViewTextBoxColumn,
				this.divisionCurrentDataGridViewTextBoxColumn,
				this.birthdayDataGridViewTextBoxColumn,
				this.divisionDataGridViewTextBoxColumn,
				this.dateBeginDataGridViewTextBoxColumn,
				this.dateEndDgvTxtColumn
			});
			this.dgvGroupWorker.DataSource = this.bindingSource_0;
			this.dgvGroupWorker.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvGroupWorker.Location = new System.Drawing.Point(0, 0);
			this.dgvGroupWorker.Name = "dgvGroupWorker";
			this.dgvGroupWorker.ReadOnly = true;
			this.dgvGroupWorker.RowHeadersWidth = 10;
			this.dgvGroupWorker.Size = new System.Drawing.Size(589, 365);
			this.dgvGroupWorker.TabIndex = 0;
			this.dgvGroupWorker.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGroupWorker_CellFormatting);
			this.idDgvTxtColumn.DataPropertyName = "id";
			this.idDgvTxtColumn.HeaderText = "id";
			this.idDgvTxtColumn.Name = "idDgvTxtColumn";
			this.idDgvTxtColumn.ReadOnly = true;
			this.idDgvTxtColumn.Visible = false;
			this.iDRRefDataGridViewImageColumn.DataPropertyName = "IDRRef";
			this.iDRRefDataGridViewImageColumn.HeaderText = "IDRRef";
			this.iDRRefDataGridViewImageColumn.Name = "iDRRefDataGridViewImageColumn";
			this.iDRRefDataGridViewImageColumn.ReadOnly = true;
			this.iDRRefDataGridViewImageColumn.Visible = false;
			this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
			this.fDataGridViewTextBoxColumn.HeaderText = "Фамилия";
			this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
			this.fDataGridViewTextBoxColumn.ReadOnly = true;
			this.iDataGridViewTextBoxColumn.DataPropertyName = "I";
			this.iDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.iDataGridViewTextBoxColumn.Name = "iDataGridViewTextBoxColumn";
			this.iDataGridViewTextBoxColumn.ReadOnly = true;
			this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
			this.oDataGridViewTextBoxColumn.HeaderText = "Отчество";
			this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
			this.oDataGridViewTextBoxColumn.ReadOnly = true;
			this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
			this.jobTitleDataGridViewTextBoxColumn.DataSource = this.class48_0;
			this.jobTitleDataGridViewTextBoxColumn.DisplayMember = "tR_JobTitle.Description";
			this.jobTitleDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.jobTitleDataGridViewTextBoxColumn.HeaderText = "Должность";
			this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
			this.jobTitleDataGridViewTextBoxColumn.ReadOnly = true;
			this.jobTitleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.jobTitleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.jobTitleDataGridViewTextBoxColumn.ValueMember = "tR_JobTitle.id";
			this.class48_0.DataSetName = "DataSetWorkers";
			this.class48_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.divisionCurrentDataGridViewTextBoxColumn.DataPropertyName = "DivisionCurrent";
			this.divisionCurrentDataGridViewTextBoxColumn.DataSource = this.class48_0;
			this.divisionCurrentDataGridViewTextBoxColumn.DisplayMember = "tR_Division.Description";
			this.divisionCurrentDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.divisionCurrentDataGridViewTextBoxColumn.HeaderText = "Подразделение";
			this.divisionCurrentDataGridViewTextBoxColumn.Name = "divisionCurrentDataGridViewTextBoxColumn";
			this.divisionCurrentDataGridViewTextBoxColumn.ReadOnly = true;
			this.divisionCurrentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.divisionCurrentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.divisionCurrentDataGridViewTextBoxColumn.ValueMember = "tR_Division.id";
			this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
			this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
			this.birthdayDataGridViewTextBoxColumn.Visible = false;
			this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
			this.divisionDataGridViewTextBoxColumn.HeaderText = "Division";
			this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
			this.divisionDataGridViewTextBoxColumn.ReadOnly = true;
			this.divisionDataGridViewTextBoxColumn.Visible = false;
			this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "DateBegin";
			this.dateBeginDataGridViewTextBoxColumn.HeaderText = "DateBegin";
			this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
			this.dateBeginDataGridViewTextBoxColumn.ReadOnly = true;
			this.dateBeginDataGridViewTextBoxColumn.Visible = false;
			this.dateEndDgvTxtColumn.DataPropertyName = "DateEnd";
			this.dateEndDgvTxtColumn.HeaderText = "DateEnd";
			this.dateEndDgvTxtColumn.Name = "dateEndDgvTxtColumn";
			this.dateEndDgvTxtColumn.ReadOnly = true;
			this.dateEndDgvTxtColumn.Visible = false;
			this.bindingSource_0.DataMember = "tR_Worker";
			this.bindingSource_0.DataSource = this.class48_0;
			this.bindingSource_0.Filter = "DateEnd is null";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(823, 390);
			base.Controls.Add(this.hLohhVholv);
			base.Controls.Add(this.toolStripMain);
			base.Name = "FormGroupWorker";
			this.Text = "Группы сотрудников";
			base.Load += new System.EventHandler(this.FormGroupWorker_Load);
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.hLohhVholv.Panel1.ResumeLayout(false);
			this.hLohhVholv.Panel1.PerformLayout();
			this.hLohhVholv.Panel2.ResumeLayout(false);
			this.hLohhVholv.ResumeLayout(false);
			this.toolStripTree.ResumeLayout(false);
			this.toolStripTree.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvGroupWorker).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class48_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.ToolStrip toolStripMain;

		private System.Windows.Forms.SplitContainer hLohhVholv;

		private System.Windows.Forms.TreeView treeViewGroup;

		private System.Windows.Forms.ToolStrip toolStripTree;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvGroupWorker;

		private System.Windows.Forms.ToolStripButton toolBtnShowDeleteGroup;

		private System.Windows.Forms.ToolStripTextBox toolTxtFindTreeGroup;

		private System.Windows.Forms.ToolStripButton toolBtnFindTreeGroup;

		private Class48 class48_0;

		private System.Windows.Forms.ToolStripButton toolBtnAddWorkerInGroup;

		private System.Windows.Forms.ToolStripButton toolBtnDelWorkerFromGroup;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripButton toolBtnShowDelWorker;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		private System.Windows.Forms.ToolStripButton toolStripButtonFind;

		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		private System.Windows.Forms.ToolStripButton toolStripButtonPrint;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;

		private System.Windows.Forms.BindingSource bindingSource_0;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDgvTxtColumn;

		private System.Windows.Forms.DataGridViewImageColumn iDRRefDataGridViewImageColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn fDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn iDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewComboBoxColumn jobTitleDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewComboBoxColumn divisionCurrentDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDgvTxtColumn;
	}
}
