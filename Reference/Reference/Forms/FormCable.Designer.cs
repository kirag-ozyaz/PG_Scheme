namespace Reference.Forms
{
	public partial class FormCable : FormLbr.FormBase
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
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Reference.Forms.FormCable));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonAddCable = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEditCable = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRemoveRestore = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonViewDeleted = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonSearchPrev = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSearchNext = new System.Windows.Forms.ToolStripButton();
			this.bindingSource_1 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.class37_0 = new Class37();
			this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.dataGridViewExcelFilter1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cableMakeupDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.VoltageF = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterComboBoxColumn();
			this.wiresDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.crossSectionDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.wiresAddlDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.crossSectionAddlDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.WiresLight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CrossSectionLight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amperageDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.amperageAirDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.resistanceDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.resistanceAddlDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.idVoltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deletedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dataGridViewExcelFilter1).BeginInit();
			base.SuspendLayout();
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripButtonAddCable,
				this.toolStripButtonEditCable,
				this.toolStripButtonRemoveRestore,
				this.toolStripButtonViewDeleted,
				this.toolStripSeparator1,
				this.toolStripTextBoxSearch,
				this.toolStripButtonSearchPrev,
				this.toolStripButtonSearchNext
			});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(705, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStripButtonAddCable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAddCable.Image = Reference.Properties.Resources.smethod_9();
			this.toolStripButtonAddCable.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAddCable.Name = "toolStripButtonAddCable";
			this.toolStripButtonAddCable.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonAddCable.Text = "Добавить";
			this.toolStripButtonAddCable.Click += new System.EventHandler(this.UwHeeysHh3);
			this.toolStripButtonEditCable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonEditCable.Image = Reference.Properties.Resources.smethod_11();
			this.toolStripButtonEditCable.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEditCable.Name = "toolStripButtonEditCable";
			this.toolStripButtonEditCable.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonEditCable.Text = "Редактировать";
			this.toolStripButtonEditCable.Click += new System.EventHandler(this.toolStripButtonEditCable_Click);
			this.toolStripButtonRemoveRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRemoveRestore.Image = Reference.Properties.Resources.smethod_10();
			this.toolStripButtonRemoveRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonRemoveRestore.Name = "toolStripButtonRemoveRestore";
			this.toolStripButtonRemoveRestore.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonRemoveRestore.Text = "Удалить";
			this.toolStripButtonRemoveRestore.Click += new System.EventHandler(this.toolStripButtonRemoveRestore_Click);
			this.toolStripButtonViewDeleted.CheckOnClick = true;
			this.toolStripButtonViewDeleted.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonViewDeleted.Image = Reference.Properties.Resources.smethod_24();
			this.toolStripButtonViewDeleted.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonViewDeleted.Name = "toolStripButtonViewDeleted";
			this.toolStripButtonViewDeleted.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonViewDeleted.Text = "Показать удалённые";
			this.toolStripButtonViewDeleted.CheckedChanged += new System.EventHandler(this.YwUewLqVne);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
			this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 25);
			this.toolStripButtonSearchPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSearchPrev.Image = Reference.Properties.Resources.smethod_16();
			this.toolStripButtonSearchPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSearchPrev.Name = "toolStripButtonSearchPrev";
			this.toolStripButtonSearchPrev.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSearchPrev.Text = "Поиск ";
			this.toolStripButtonSearchPrev.Click += new System.EventHandler(this.toolStripButtonSearchPrev_Click);
			this.toolStripButtonSearchNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSearchNext.Image = Reference.Properties.Resources.smethod_15();
			this.toolStripButtonSearchNext.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSearchNext.Name = "toolStripButtonSearchNext";
			this.toolStripButtonSearchNext.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSearchNext.Text = "Поиск";
			this.toolStripButtonSearchNext.Click += new System.EventHandler(this.toolStripButtonSearchNext_Click);
			this.bindingSource_1.DataMember = "tR_Classifier";
			this.bindingSource_1.DataSource = this.class37_0;
			this.class37_0.DataSetName = "DataSetMeters";
			this.class37_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.bindingSource_0.DataMember = "tR_Cable";
			this.bindingSource_0.DataSource = this.class37_0;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewExcelFilter1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43f));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 414);
			this.tableLayoutPanel1.TabIndex = 4;
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 6);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133f));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98f));
			this.tableLayoutPanel2.Controls.Add(this.btnAccept, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 374);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(699, 37);
			this.tableLayoutPanel2.TabIndex = 29;
			this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAccept.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAccept.Location = new System.Drawing.Point(492, 6);
			this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 6, 10, 6);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(99, 25);
			this.btnAccept.TabIndex = 8;
			this.btnAccept.Text = "Выбрать";
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnCancel.Location = new System.Drawing.Point(611, 6);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 6, 3, 6);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 25);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Закрыть";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.dataGridViewExcelFilter1.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter1.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter1.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewExcelFilter1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idDataGridViewTextBoxColumn1,
				this.cableMakeupDataGridViewTextBoxColumn1,
				this.VoltageF,
				this.wiresDataGridViewTextBoxColumn1,
				this.crossSectionDataGridViewTextBoxColumn1,
				this.wiresAddlDataGridViewTextBoxColumn,
				this.crossSectionAddlDataGridViewTextBoxColumn,
				this.WiresLight,
				this.CrossSectionLight,
				this.amperageDataGridViewTextBoxColumn1,
				this.amperageAirDataGridViewTextBoxColumn,
				this.resistanceDataGridViewTextBoxColumn1,
				this.resistanceAddlDataGridViewTextBoxColumn,
				this.idVoltageDataGridViewTextBoxColumn,
				this.deletedDataGridViewCheckBoxColumn1
			});
			this.dataGridViewExcelFilter1.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewExcelFilter1.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewExcelFilter1.MultiSelect = false;
			this.dataGridViewExcelFilter1.Name = "dataGridViewExcelFilter1";
			this.dataGridViewExcelFilter1.ReadOnly = true;
			this.dataGridViewExcelFilter1.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter1.Size = new System.Drawing.Size(699, 365);
			this.dataGridViewExcelFilter1.TabIndex = 3;
			this.dataGridViewExcelFilter1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExcelFilter1_CellDoubleClick);
			this.dataGridViewExcelFilter1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewExcelFilter1_DataError);
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn1.HeaderText = "id";
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			this.idDataGridViewTextBoxColumn1.ReadOnly = true;
			this.idDataGridViewTextBoxColumn1.Visible = false;
			this.cableMakeupDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cableMakeupDataGridViewTextBoxColumn1.DataPropertyName = "CableMakeup";
			this.cableMakeupDataGridViewTextBoxColumn1.HeaderText = "Наименование";
			this.cableMakeupDataGridViewTextBoxColumn1.MinimumWidth = 100;
			this.cableMakeupDataGridViewTextBoxColumn1.Name = "cableMakeupDataGridViewTextBoxColumn1";
			this.cableMakeupDataGridViewTextBoxColumn1.ReadOnly = true;
			this.cableMakeupDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.VoltageF.DataPropertyName = "IdVoltage";
			this.VoltageF.DataSource = this.bindingSource_1;
			this.VoltageF.DisplayMember = "Name";
			this.VoltageF.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.VoltageF.HeaderText = "Напряжение";
			this.VoltageF.Name = "VoltageF";
			this.VoltageF.ReadOnly = true;
			this.VoltageF.ValueMember = "Id";
			this.wiresDataGridViewTextBoxColumn1.DataPropertyName = "Wires";
			this.wiresDataGridViewTextBoxColumn1.HeaderText = "Количество жил";
			this.wiresDataGridViewTextBoxColumn1.Name = "wiresDataGridViewTextBoxColumn1";
			this.wiresDataGridViewTextBoxColumn1.ReadOnly = true;
			this.wiresDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.crossSectionDataGridViewTextBoxColumn1.DataPropertyName = "CrossSection";
			this.crossSectionDataGridViewTextBoxColumn1.HeaderText = "Сечение";
			this.crossSectionDataGridViewTextBoxColumn1.Name = "crossSectionDataGridViewTextBoxColumn1";
			this.crossSectionDataGridViewTextBoxColumn1.ReadOnly = true;
			this.crossSectionDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.wiresAddlDataGridViewTextBoxColumn.DataPropertyName = "WiresAddl";
			this.wiresAddlDataGridViewTextBoxColumn.HeaderText = "Нулевые жилы";
			this.wiresAddlDataGridViewTextBoxColumn.Name = "wiresAddlDataGridViewTextBoxColumn";
			this.wiresAddlDataGridViewTextBoxColumn.ReadOnly = true;
			this.wiresAddlDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.crossSectionAddlDataGridViewTextBoxColumn.DataPropertyName = "CrossSectionAddl";
			this.crossSectionAddlDataGridViewTextBoxColumn.HeaderText = "Сечение нулевых жил";
			this.crossSectionAddlDataGridViewTextBoxColumn.Name = "crossSectionAddlDataGridViewTextBoxColumn";
			this.crossSectionAddlDataGridViewTextBoxColumn.ReadOnly = true;
			this.crossSectionAddlDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.WiresLight.DataPropertyName = "WiresLight";
			this.WiresLight.HeaderText = "Жилы освещения";
			this.WiresLight.Name = "WiresLight";
			this.WiresLight.ReadOnly = true;
			this.CrossSectionLight.DataPropertyName = "CrossSectionLight";
			this.CrossSectionLight.HeaderText = "Сечение жил освещения";
			this.CrossSectionLight.Name = "CrossSectionLight";
			this.CrossSectionLight.ReadOnly = true;
			this.amperageDataGridViewTextBoxColumn1.DataPropertyName = "Amperage";
			this.amperageDataGridViewTextBoxColumn1.HeaderText = "Максимально допустимый ток в земле";
			this.amperageDataGridViewTextBoxColumn1.Name = "amperageDataGridViewTextBoxColumn1";
			this.amperageDataGridViewTextBoxColumn1.ReadOnly = true;
			this.amperageDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.amperageAirDataGridViewTextBoxColumn.DataPropertyName = "AmperageAir";
			this.amperageAirDataGridViewTextBoxColumn.HeaderText = "Максимально допустимый ток на воздухе";
			this.amperageAirDataGridViewTextBoxColumn.Name = "amperageAirDataGridViewTextBoxColumn";
			this.amperageAirDataGridViewTextBoxColumn.ReadOnly = true;
			this.amperageAirDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.resistanceDataGridViewTextBoxColumn1.DataPropertyName = "Resistance";
			this.resistanceDataGridViewTextBoxColumn1.HeaderText = "Удельное активное сопротивление";
			this.resistanceDataGridViewTextBoxColumn1.Name = "resistanceDataGridViewTextBoxColumn1";
			this.resistanceDataGridViewTextBoxColumn1.ReadOnly = true;
			this.resistanceDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.resistanceAddlDataGridViewTextBoxColumn.DataPropertyName = "ResistanceAddl";
			this.resistanceAddlDataGridViewTextBoxColumn.HeaderText = "Удельное активное сопротивление нулевых жил";
			this.resistanceAddlDataGridViewTextBoxColumn.Name = "resistanceAddlDataGridViewTextBoxColumn";
			this.resistanceAddlDataGridViewTextBoxColumn.ReadOnly = true;
			this.resistanceAddlDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.idVoltageDataGridViewTextBoxColumn.DataPropertyName = "IdVoltage";
			this.idVoltageDataGridViewTextBoxColumn.HeaderText = "IdVoltage";
			this.idVoltageDataGridViewTextBoxColumn.Name = "idVoltageDataGridViewTextBoxColumn";
			this.idVoltageDataGridViewTextBoxColumn.ReadOnly = true;
			this.idVoltageDataGridViewTextBoxColumn.Visible = false;
			this.deletedDataGridViewCheckBoxColumn1.DataPropertyName = "Deleted";
			this.deletedDataGridViewCheckBoxColumn1.HeaderText = "Deleted";
			this.deletedDataGridViewCheckBoxColumn1.Name = "deletedDataGridViewCheckBoxColumn1";
			this.deletedDataGridViewCheckBoxColumn1.ReadOnly = true;
			this.deletedDataGridViewCheckBoxColumn1.Visible = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(705, 439);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Controls.Add(this.toolStrip1);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormCable";
			this.Text = "Кабели";
			base.Load += new System.EventHandler(this.FormCable_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dataGridViewExcelFilter1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.ToolStrip toolStrip1;

		private System.Windows.Forms.BindingSource bindingSource_0;

		private Class37 class37_0;

		private System.Windows.Forms.ToolStripButton toolStripButtonAddCable;

		private System.Windows.Forms.ToolStripButton toolStripButtonEditCable;

		private System.Windows.Forms.ToolStripButton toolStripButtonRemoveRestore;

		private System.Windows.Forms.ToolStripButton toolStripButtonViewDeleted;

		private System.Windows.Forms.BindingSource bindingSource_1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter1;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;

		private System.Windows.Forms.ToolStripButton toolStripButtonSearchPrev;

		private System.Windows.Forms.ToolStripButton toolStripButtonSearchNext;

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		private System.Windows.Forms.Button btnAccept;

		private System.Windows.Forms.Button btnCancel;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn cableMakeupDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterComboBoxColumn VoltageF;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn wiresDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn crossSectionDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn wiresAddlDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn crossSectionAddlDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn WiresLight;

		private System.Windows.Forms.DataGridViewTextBoxColumn CrossSectionLight;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn amperageDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn amperageAirDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn resistanceDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn resistanceAddlDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn idVoltageDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn1;
	}
}
