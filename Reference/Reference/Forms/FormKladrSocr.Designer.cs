namespace Reference.Forms
{
	public partial class FormKladrSocr : FormLbr.FormBase
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
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Reference.Forms.FormKladrSocr));
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
			this.toolBtnEdit = new System.Windows.Forms.ToolStripButton();
			this.toolBtnDel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparatorAddEditDel = new System.Windows.Forms.ToolStripSeparator();
			this.toolBtnSave = new System.Windows.Forms.ToolStripButton();
			this.DusPxblucL = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
			this.toolStripTextBoxGrid = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonFindPrev = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonFindNext = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
			this.dgvKladrSocr = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.levelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.socrNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.scnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuGrid = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.class20_0 = new Class20();
			this.toolStripMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvKladrSocr).BeginInit();
			this.contextMenuGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class20_0).BeginInit();
			base.SuspendLayout();
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnAdd,
				this.toolBtnEdit,
				this.toolBtnDel,
				this.toolStripSeparatorAddEditDel,
				this.toolBtnSave,
				this.DusPxblucL,
				this.toolStripButtonFind,
				this.toolStripTextBoxGrid,
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
			this.toolStripMain.Size = new System.Drawing.Size(448, 25);
			this.toolStripMain.TabIndex = 0;
			this.toolStripMain.Text = "toolStrip1";
			this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnAdd.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnAdd.Image");
			this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnAdd.Name = "toolBtnAdd";
			this.toolBtnAdd.Size = new System.Drawing.Size(23, 22);
			this.toolBtnAdd.Text = "Добавить";
			this.toolBtnAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
			this.toolBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnEdit.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnEdit.Image");
			this.toolBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolBtnEdit.Name = "toolBtnEdit";
			this.toolBtnEdit.Size = new System.Drawing.Size(23, 22);
			this.toolBtnEdit.Text = "Редактировать";
			this.toolBtnEdit.Click += new System.EventHandler(this.toolBtnEdit_Click);
			this.toolBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDel.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnDel.Image");
			this.toolBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolBtnDel.Name = "toolBtnDel";
			this.toolBtnDel.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDel.Text = "Удаллить";
			this.toolBtnDel.Click += new System.EventHandler(this.toolBtnDel_Click);
			this.toolStripSeparatorAddEditDel.Name = "toolStripSeparatorAddEditDel";
			this.toolStripSeparatorAddEditDel.Size = new System.Drawing.Size(6, 25);
			this.toolBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnSave.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnSave.Image");
			this.toolBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolBtnSave.Name = "toolBtnSave";
			this.toolBtnSave.Size = new System.Drawing.Size(23, 22);
			this.toolBtnSave.Text = "Сохранить";
			this.toolBtnSave.Click += new System.EventHandler(this.toolBtnSave_Click);
			this.DusPxblucL.Name = "toolStripSeparatorSave";
			this.DusPxblucL.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFind.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonFind.Image");
			this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFind.Name = "toolStripButtonFind";
			this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFind.Text = "Поиск";
			this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
			this.toolStripTextBoxGrid.Name = "toolStripTextBoxGrid";
			this.toolStripTextBoxGrid.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBoxGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxGrid_KeyDown);
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
			this.dgvKladrSocr.AutoGenerateColumns = false;
			this.dgvKladrSocr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKladrSocr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idDataGridViewTextBoxColumn,
				this.levelColumn,
				this.socrNameColumn,
				this.scnameColumn
			});
			this.dgvKladrSocr.ContextMenuStrip = this.contextMenuGrid;
			this.dgvKladrSocr.DataSource = this.bindingSource_0;
			this.dgvKladrSocr.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvKladrSocr.Location = new System.Drawing.Point(0, 25);
			this.dgvKladrSocr.Name = "dgvKladrSocr";
			this.dgvKladrSocr.RowHeadersWidth = 21;
			this.dgvKladrSocr.Size = new System.Drawing.Size(448, 375);
			this.dgvKladrSocr.TabIndex = 1;
			this.dgvKladrSocr.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKladrSocr_CellEndEdit);
			this.dgvKladrSocr.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvKladrSocr_CellValidating);
			this.dgvKladrSocr.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvKladrSocr_RowValidating);
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			this.levelColumn.DataPropertyName = "Level";
			this.levelColumn.HeaderText = "Уровень";
			this.levelColumn.Name = "levelColumn";
			this.levelColumn.ReadOnly = true;
			this.socrNameColumn.DataPropertyName = "SocrName";
			this.socrNameColumn.HeaderText = "Наименование";
			this.socrNameColumn.Name = "socrNameColumn";
			this.socrNameColumn.ReadOnly = true;
			this.scnameColumn.DataPropertyName = "scname";
			this.scnameColumn.HeaderText = "Сокращение";
			this.scnameColumn.Name = "scnameColumn";
			this.scnameColumn.ReadOnly = true;
			this.contextMenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuItemAdd,
				this.toolMenuItemEdit,
				this.toolMenuItemDel,
				this.toolStripSeparator1,
				this.toolMenuItemCopy,
				this.toolMenuItemExport,
				this.toolMenuItemPrint
			});
			this.contextMenuGrid.Name = "contextMenuGrid";
			this.contextMenuGrid.Size = new System.Drawing.Size(158, 164);
			this.contextMenuGrid.Text = "Контекстное меню грида";
			this.toolMenuItemAdd.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemAdd.Image");
			this.toolMenuItemAdd.Name = "toolMenuItemAdd";
			this.toolMenuItemAdd.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemAdd.Text = "Добавить";
			this.toolMenuItemAdd.Click += new System.EventHandler(this.toolMenuItemAdd_Click);
			this.toolMenuItemEdit.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemEdit.Image");
			this.toolMenuItemEdit.Name = "toolMenuItemEdit";
			this.toolMenuItemEdit.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemEdit.Text = "Редактировать";
			this.toolMenuItemEdit.Click += new System.EventHandler(this.toolMenuItemEdit_Click);
			this.toolMenuItemDel.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemDel.Image");
			this.toolMenuItemDel.Name = "toolMenuItemDel";
			this.toolMenuItemDel.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemDel.Text = "Удалить";
			this.toolMenuItemDel.Click += new System.EventHandler(this.toolMenuItemDel_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
			this.toolMenuItemCopy.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemCopy.Image");
			this.toolMenuItemCopy.Name = "toolMenuItemCopy";
			this.toolMenuItemCopy.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemCopy.Text = "Копировать";
			this.toolMenuItemCopy.Click += new System.EventHandler(this.toolMenuItemCopy_Click);
			this.toolMenuItemExport.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemExport.Image");
			this.toolMenuItemExport.Name = "toolMenuItemExport";
			this.toolMenuItemExport.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemExport.Text = "Экспорт в Excel";
			this.toolMenuItemExport.Click += new System.EventHandler(this.toolMenuItemExport_Click);
			this.toolMenuItemPrint.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemPrint.Image");
			this.toolMenuItemPrint.Name = "toolMenuItemPrint";
			this.toolMenuItemPrint.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemPrint.Text = "Печать";
			this.toolMenuItemPrint.Click += new System.EventHandler(this.toolMenuItemPrint_Click);
			this.bindingSource_0.DataMember = "tR_KladrSocr";
			this.bindingSource_0.DataSource = this.class20_0;
			this.class20_0.DataSetName = "DataSetKladr";
			this.class20_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(448, 400);
			base.Controls.Add(this.dgvKladrSocr);
			base.Controls.Add(this.toolStripMain);
			base.Name = "FormKladrSocr";
			base.ShowIcon = false;
			this.Text = "Типы адресных объектов";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKladrSocr_FormClosing);
			base.Load += new System.EventHandler(this.FormKladrSocr_Load);
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvKladrSocr).EndInit();
			this.contextMenuGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class20_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.ToolStrip toolStripMain;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvKladrSocr;

		private System.Windows.Forms.BindingSource bindingSource_0;

		private Class20 class20_0;

		private System.Windows.Forms.ToolStripButton toolBtnAdd;

		private System.Windows.Forms.ToolStripButton toolBtnEdit;

		private System.Windows.Forms.ToolStripButton toolBtnDel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorAddEditDel;

		private System.Windows.Forms.ToolStripButton toolBtnSave;

		private System.Windows.Forms.ToolStripSeparator DusPxblucL;

		private System.Windows.Forms.ToolStripButton toolStripButtonFind;

		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxGrid;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		private System.Windows.Forms.ToolStripButton toolStripButtonPrint;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn levelColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn socrNameColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn scnameColumn;

		private System.Windows.Forms.ContextMenuStrip contextMenuGrid;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemAdd;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemEdit;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemCopy;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemExport;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemPrint;
	}
}
