namespace Reference.Forms
{
	public partial class FormCounter : FormLbr.FormBase
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
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Reference.Forms.FormCounter));
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
			this.toolBtnEdit = new System.Windows.Forms.ToolStripButton();
			this.toolBtnDel = new System.Windows.Forms.ToolStripButton();
			this.Ipikrulrju = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolBtnShowDelete = new System.Windows.Forms.ToolStripButton();
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
			this.splitContainerGrid = new System.Windows.Forms.SplitContainer();
			this.dgvCounter = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
			this.idDgvTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDgvTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.Digit = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.ifrkbcHnPp = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.voltageDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.precisionDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.intervalDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.tarifCountDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deletedDgvCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.DaukVllIh3 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemDelCheck = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemDelFull = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.class37_0 = new Class37();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.contextMenuStripPicture = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItemSavePicture = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip.SuspendLayout();
			this.splitContainerGrid.Panel1.SuspendLayout();
			this.splitContainerGrid.Panel2.SuspendLayout();
			this.splitContainerGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvCounter).BeginInit();
			this.DaukVllIh3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.pictureBox).BeginInit();
			this.contextMenuStripPicture.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnAdd,
				this.toolBtnEdit,
				this.toolBtnDel,
				this.Ipikrulrju,
				this.toolStripSeparator1,
				this.toolBtnShowDelete,
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
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(616, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip1";
			this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnAdd.Image = Reference.Properties.Resources.smethod_9();
			this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnAdd.Name = "toolBtnAdd";
			this.toolBtnAdd.Size = new System.Drawing.Size(23, 22);
			this.toolBtnAdd.Text = "Добавить новый счетчик";
			this.toolBtnAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
			this.toolBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnEdit.Image = Reference.Properties.Resources.smethod_11();
			this.toolBtnEdit.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnEdit.Name = "toolBtnEdit";
			this.toolBtnEdit.Size = new System.Drawing.Size(23, 22);
			this.toolBtnEdit.Text = "Редактировать";
			this.toolBtnEdit.Click += new System.EventHandler(this.toolBtnEdit_Click);
			this.toolBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDel.Image = Reference.Properties.Resources.smethod_8();
			this.toolBtnDel.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDel.Name = "toolBtnDel";
			this.toolBtnDel.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDel.Text = "Пометить на удаление";
			this.toolBtnDel.Click += new System.EventHandler(this.toolBtnDel_Click);
			this.Ipikrulrju.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Ipikrulrju.Image = Reference.Properties.Resources.smethod_10();
			this.Ipikrulrju.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.Ipikrulrju.Name = "toolBtnDelFull";
			this.Ipikrulrju.Size = new System.Drawing.Size(23, 22);
			this.Ipikrulrju.Text = "Удалить полностью";
			this.Ipikrulrju.Click += new System.EventHandler(this.Ipikrulrju_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			this.toolBtnShowDelete.CheckOnClick = true;
			this.toolBtnShowDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnShowDelete.Image = Reference.Properties.Resources.smethod_24();
			this.toolBtnShowDelete.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDelete.Name = "toolBtnShowDelete";
			this.toolBtnShowDelete.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDelete.Text = "Показать удаленные";
			this.toolBtnShowDelete.Click += new System.EventHandler(this.toolBtnShowDelete_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFind.Image = Reference.Properties.Resources.smethod_14();
			this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFind.Name = "toolStripButtonFind";
			this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFind.Text = "Поиск";
			this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
			this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
			this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
			this.toolStripButtonFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFindPrev.Image = Reference.Properties.Resources.smethod_16();
			this.toolStripButtonFindPrev.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFindPrev.Name = "toolStripButtonFindPrev";
			this.toolStripButtonFindPrev.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFindPrev.Text = "Поиск назад";
			this.toolStripButtonFindPrev.Click += new System.EventHandler(this.toolStripButtonFindPrev_Click);
			this.toolStripButtonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFindNext.Image = Reference.Properties.Resources.smethod_15();
			this.toolStripButtonFindNext.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFindNext.Name = "toolStripButtonFindNext";
			this.toolStripButtonFindNext.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFindNext.Text = "Поиск вперед";
			this.toolStripButtonFindNext.Click += new System.EventHandler(this.toolStripButtonFindNext_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPrint.Image = Reference.Properties.Resources.smethod_22();
			this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonPrint.Name = "toolStripButtonPrint";
			this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonPrint.Text = "Печать";
			this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExportExcel.Image = Reference.Properties.Resources.smethod_13();
			this.toolStripButtonExportExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonExportExcel.Name = "toolStripButtonExportExcel";
			this.toolStripButtonExportExcel.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonExportExcel.Text = "Экспорт в Excel";
			this.toolStripButtonExportExcel.Click += new System.EventHandler(this.toolStripButtonExportExcel_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRefresh.Image = Reference.Properties.Resources.smethod_23();
			this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
			this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonRefresh.Text = "Обновить";
			this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
			this.splitContainerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerGrid.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainerGrid.Location = new System.Drawing.Point(0, 25);
			this.splitContainerGrid.Name = "splitContainerGrid";
			this.splitContainerGrid.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.splitContainerGrid.Panel1.Controls.Add(this.dgvCounter);
			this.splitContainerGrid.Panel2.Controls.Add(this.splitContainer1);
			this.splitContainerGrid.Size = new System.Drawing.Size(616, 438);
			this.splitContainerGrid.SplitterDistance = 311;
			this.splitContainerGrid.TabIndex = 1;
			this.dgvCounter.AllowUserToAddRows = false;
			this.dgvCounter.AllowUserToDeleteRows = false;
			this.dgvCounter.AutoGenerateColumns = false;
			this.dgvCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCounter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idDgvTextBoxColumn,
				this.nameDgvTextBoxColumn,
				this.Digit,
				this.ifrkbcHnPp,
				this.voltageDataGridViewTextBoxColumn,
				this.precisionDataGridViewTextBoxColumn,
				this.intervalDataGridViewTextBoxColumn,
				this.tarifCountDataGridViewTextBoxColumn,
				this.imageDataGridViewImageColumn,
				this.commentDataGridViewTextBoxColumn,
				this.deletedDgvCheckBoxColumn
			});
			this.dgvCounter.ContextMenuStrip = this.DaukVllIh3;
			this.dgvCounter.DataSource = this.bindingSource_0;
			this.dgvCounter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCounter.Location = new System.Drawing.Point(0, 0);
			this.dgvCounter.Name = "dgvCounter";
			this.dgvCounter.ReadOnly = true;
			this.dgvCounter.RowHeadersWidth = 21;
			this.dgvCounter.Size = new System.Drawing.Size(616, 311);
			this.dgvCounter.TabIndex = 0;
			this.dgvCounter.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCounter_CellFormatting);
			this.idDgvTextBoxColumn.DataPropertyName = "id";
			this.idDgvTextBoxColumn.HeaderText = "id";
			this.idDgvTextBoxColumn.Name = "idDgvTextBoxColumn";
			this.idDgvTextBoxColumn.ReadOnly = true;
			this.idDgvTextBoxColumn.Visible = false;
			this.nameDgvTextBoxColumn.DataPropertyName = "Name";
			this.nameDgvTextBoxColumn.HeaderText = "Наименование";
			this.nameDgvTextBoxColumn.Name = "nameDgvTextBoxColumn";
			this.nameDgvTextBoxColumn.ReadOnly = true;
			this.nameDgvTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.nameDgvTextBoxColumn.Width = 110;
			this.Digit.DataPropertyName = "Digit";
			this.Digit.HeaderText = "Разряд";
			this.Digit.Name = "Digit";
			this.Digit.ReadOnly = true;
			this.Digit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Digit.Width = 70;
			this.ifrkbcHnPp.DataPropertyName = "Phaze";
			this.ifrkbcHnPp.HeaderText = "Фаза";
			this.ifrkbcHnPp.Name = "phazeDataGridViewTextBoxColumn";
			this.ifrkbcHnPp.ReadOnly = true;
			this.ifrkbcHnPp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ifrkbcHnPp.Width = 65;
			this.voltageDataGridViewTextBoxColumn.DataPropertyName = "Voltage";
			this.voltageDataGridViewTextBoxColumn.HeaderText = "Ном напр-е";
			this.voltageDataGridViewTextBoxColumn.Name = "voltageDataGridViewTextBoxColumn";
			this.voltageDataGridViewTextBoxColumn.ReadOnly = true;
			this.voltageDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.voltageDataGridViewTextBoxColumn.Width = 70;
			this.precisionDataGridViewTextBoxColumn.DataPropertyName = "Precision";
			this.precisionDataGridViewTextBoxColumn.HeaderText = "Точность";
			this.precisionDataGridViewTextBoxColumn.Name = "precisionDataGridViewTextBoxColumn";
			this.precisionDataGridViewTextBoxColumn.ReadOnly = true;
			this.precisionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.precisionDataGridViewTextBoxColumn.Width = 70;
			this.intervalDataGridViewTextBoxColumn.DataPropertyName = "Interval";
			this.intervalDataGridViewTextBoxColumn.HeaderText = "Межпров интервал";
			this.intervalDataGridViewTextBoxColumn.Name = "intervalDataGridViewTextBoxColumn";
			this.intervalDataGridViewTextBoxColumn.ReadOnly = true;
			this.intervalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.intervalDataGridViewTextBoxColumn.Width = 80;
			this.tarifCountDataGridViewTextBoxColumn.DataPropertyName = "TarifCount";
			this.tarifCountDataGridViewTextBoxColumn.HeaderText = "Число тарифов";
			this.tarifCountDataGridViewTextBoxColumn.Name = "tarifCountDataGridViewTextBoxColumn";
			this.tarifCountDataGridViewTextBoxColumn.ReadOnly = true;
			this.tarifCountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.tarifCountDataGridViewTextBoxColumn.Width = 80;
			this.imageDataGridViewImageColumn.DataPropertyName = "Image";
			this.imageDataGridViewImageColumn.HeaderText = "Image";
			this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
			this.imageDataGridViewImageColumn.ReadOnly = true;
			this.imageDataGridViewImageColumn.Visible = false;
			this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
			this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
			this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
			this.commentDataGridViewTextBoxColumn.ReadOnly = true;
			this.commentDataGridViewTextBoxColumn.Visible = false;
			this.deletedDgvCheckBoxColumn.DataPropertyName = "Deleted";
			this.deletedDgvCheckBoxColumn.HeaderText = "Deleted";
			this.deletedDgvCheckBoxColumn.Name = "deletedDgvCheckBoxColumn";
			this.deletedDgvCheckBoxColumn.ReadOnly = true;
			this.deletedDgvCheckBoxColumn.Visible = false;
			this.DaukVllIh3.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuItemAdd,
				this.toolMenuItemEdit,
				this.toolMenuItemDel,
				this.toolStripSeparator6,
				this.toolMenuItemCopy,
				this.toolMenuItemExportToExcel,
				this.toolMenuItemPrint
			});
			this.DaukVllIh3.Name = "contextMenuStrip";
			this.DaukVllIh3.Size = new System.Drawing.Size(158, 142);
			this.toolMenuItemAdd.Image = Reference.Properties.Resources.smethod_2();
			this.toolMenuItemAdd.Name = "toolMenuItemAdd";
			this.toolMenuItemAdd.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemAdd.Text = "Добавить";
			this.toolMenuItemAdd.Click += new System.EventHandler(this.toolMenuItemAdd_Click);
			this.toolMenuItemEdit.Image = Reference.Properties.Resources.smethod_4();
			this.toolMenuItemEdit.Name = "toolMenuItemEdit";
			this.toolMenuItemEdit.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemEdit.Text = "Изменить";
			this.toolMenuItemEdit.Click += new System.EventHandler(this.PyBctgfHr8);
			this.toolMenuItemDel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemDelCheck,
				this.toolStripMenuItemDelFull
			});
			this.toolMenuItemDel.Image = Reference.Properties.Resources.smethod_3();
			this.toolMenuItemDel.Name = "toolMenuItemDel";
			this.toolMenuItemDel.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemDel.Text = "Удалить";
			this.toolStripMenuItemDelCheck.Name = "toolStripMenuItemDelCheck";
			this.toolStripMenuItemDelCheck.Size = new System.Drawing.Size(198, 22);
			this.toolStripMenuItemDelCheck.Text = "Пометить на удаление";
			this.toolStripMenuItemDelCheck.Click += new System.EventHandler(this.toolStripMenuItemDelCheck_Click);
			this.toolStripMenuItemDelFull.Name = "toolStripMenuItemDelFull";
			this.toolStripMenuItemDelFull.Size = new System.Drawing.Size(198, 22);
			this.toolStripMenuItemDelFull.Text = "Удалить полностью";
			this.toolStripMenuItemDelFull.Click += new System.EventHandler(this.toolStripMenuItemDelFull_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(154, 6);
			this.toolMenuItemCopy.Image = Reference.Properties.Resources.smethod_6();
			this.toolMenuItemCopy.Name = "toolMenuItemCopy";
			this.toolMenuItemCopy.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemCopy.Text = "Копировать";
			this.toolMenuItemCopy.Click += new System.EventHandler(this.toolMenuItemCopy_Click);
			this.toolMenuItemExportToExcel.Image = Reference.Properties.Resources.smethod_13();
			this.toolMenuItemExportToExcel.Name = "toolMenuItemExportToExcel";
			this.toolMenuItemExportToExcel.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemExportToExcel.Text = "Экспорт в Excel";
			this.toolMenuItemExportToExcel.Click += new System.EventHandler(this.toolMenuItemExportToExcel_Click);
			this.toolMenuItemPrint.Image = Reference.Properties.Resources.smethod_22();
			this.toolMenuItemPrint.Name = "toolMenuItemPrint";
			this.toolMenuItemPrint.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemPrint.Text = "Печать";
			this.toolMenuItemPrint.Click += new System.EventHandler(this.toolMenuItemPrint_Click);
			this.bindingSource_0.DataMember = "tR_MarkMeter";
			this.bindingSource_0.DataSource = this.class37_0;
			this.bindingSource_0.Sort = "Name, Digit, Phaze, Voltage, Precision";
			this.class37_0.DataSetName = "DataSetMeters";
			this.class37_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.richTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
			this.splitContainer1.Size = new System.Drawing.Size(616, 123);
			this.splitContainer1.SplitterDistance = 277;
			this.splitContainer1.TabIndex = 0;
			this.richTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "Comment", true));
			this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox.Location = new System.Drawing.Point(0, 0);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(277, 123);
			this.richTextBox.TabIndex = 0;
			this.richTextBox.Text = "";
			this.pictureBox.ContextMenuStrip = this.contextMenuStripPicture;
			this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSource_0, "Image", true));
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(335, 123);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.contextMenuStripPicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemSavePicture
			});
			this.contextMenuStripPicture.Name = "contextMenuStripPicture";
			this.contextMenuStripPicture.Size = new System.Drawing.Size(182, 48);
			this.toolStripMenuItemSavePicture.Name = "toolStripMenuItemSavePicture";
			this.toolStripMenuItemSavePicture.Size = new System.Drawing.Size(181, 22);
			this.toolStripMenuItemSavePicture.Text = "Сохранить рисунок";
			this.toolStripMenuItemSavePicture.Click += new System.EventHandler(this.toolStripMenuItemSavePicture_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(616, 463);
			base.Controls.Add(this.splitContainerGrid);
			base.Controls.Add(this.toolStrip);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.Name = "FormCounter";
			this.Text = "Счетчики";
			base.Load += new System.EventHandler(this.FormCounter_Load);
			base.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCounter_KeyDown);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.splitContainerGrid.Panel1.ResumeLayout(false);
			this.splitContainerGrid.Panel2.ResumeLayout(false);
			this.splitContainerGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvCounter).EndInit();
			this.DaukVllIh3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.pictureBox).EndInit();
			this.contextMenuStripPicture.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.ToolStrip toolStrip;

		private System.Windows.Forms.SplitContainer splitContainerGrid;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvCounter;

		private System.Windows.Forms.SplitContainer splitContainer1;

		private System.Windows.Forms.RichTextBox richTextBox;

		private System.Windows.Forms.PictureBox pictureBox;

		private Class37 class37_0;

		private System.Windows.Forms.BindingSource bindingSource_0;

		private System.Windows.Forms.ToolStripButton toolBtnAdd;

		private System.Windows.Forms.ToolStripButton toolBtnEdit;

		private System.Windows.Forms.ToolStripButton toolBtnDel;

		private System.Windows.Forms.ToolStripButton Ipikrulrju;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripButton toolBtnShowDelete;

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

		private System.Windows.Forms.DataGridViewTextBoxColumn idDgvTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDgvTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Digit;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn ifrkbcHnPp;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn voltageDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn precisionDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn intervalDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn tarifCountDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDgvCheckBoxColumn;

		private System.Windows.Forms.ContextMenuStrip DaukVllIh3;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemAdd;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemEdit;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemCopy;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemExportToExcel;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemPrint;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelCheck;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelFull;

		private System.Windows.Forms.ContextMenuStrip contextMenuStripPicture;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSavePicture;
	}
}
