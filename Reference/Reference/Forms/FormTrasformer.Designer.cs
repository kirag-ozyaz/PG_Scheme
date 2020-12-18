namespace Reference.Forms
{
	public partial class FormTrasformer : FormLbr.FormBase
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
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Reference.Forms.FormTrasformer));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonAddTransformer = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEditTransformer = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRemoveRestore = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonViewDeleted = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonSearchPrev = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSearchNext = new System.Windows.Forms.ToolStripButton();
			this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.class37_0 = new Class37();
			this.dataGridViewExcelFilter1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
			this.yvBwPlixdU = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.typeDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.powerDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.highVoltageDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.lowVoltageDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.ratedAmperHVDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.ratedAmperLVDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.groupWindingsDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.shortCircuitVoltDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.shortCircuitLossDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.noLoadLossDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.deletedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataGridViewExcelFilter1).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripButtonAddTransformer,
				this.toolStripButtonEditTransformer,
				this.toolStripButtonRemoveRestore,
				this.toolStripButtonViewDeleted,
				this.toolStripSeparator1,
				this.toolStripTextBoxSearch,
				this.toolStripButtonSearchPrev,
				this.toolStripButtonSearchNext
			});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(734, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStripButtonAddTransformer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAddTransformer.Image = Reference.Properties.Resources.smethod_9();
			this.toolStripButtonAddTransformer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAddTransformer.Name = "toolStripButtonAddTransformer";
			this.toolStripButtonAddTransformer.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonAddTransformer.Text = "Добавить";
			this.toolStripButtonAddTransformer.Click += new System.EventHandler(this.toolStripButtonAddTransformer_Click);
			this.toolStripButtonEditTransformer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonEditTransformer.Image = Reference.Properties.Resources.smethod_11();
			this.toolStripButtonEditTransformer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEditTransformer.Name = "toolStripButtonEditTransformer";
			this.toolStripButtonEditTransformer.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonEditTransformer.Text = "Редактировать";
			this.toolStripButtonEditTransformer.Click += new System.EventHandler(this.toolStripButtonEditTransformer_Click);
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
			this.toolStripButtonViewDeleted.Click += new System.EventHandler(this.toolStripButtonViewDeleted_Click);
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
			this.bindingSource_0.DataMember = "tR_Transformer";
			this.bindingSource_0.DataSource = this.class37_0;
			this.class37_0.DataSetName = "DataSetMeters";
			this.class37_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.dataGridViewExcelFilter1.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter1.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter1.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewExcelFilter1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.yvBwPlixdU,
				this.nameDataGridViewTextBoxColumn1,
				this.typeDataGridViewTextBoxColumn1,
				this.powerDataGridViewTextBoxColumn1,
				this.highVoltageDataGridViewTextBoxColumn1,
				this.lowVoltageDataGridViewTextBoxColumn1,
				this.ratedAmperHVDataGridViewTextBoxColumn1,
				this.ratedAmperLVDataGridViewTextBoxColumn1,
				this.groupWindingsDataGridViewTextBoxColumn1,
				this.shortCircuitVoltDataGridViewTextBoxColumn1,
				this.shortCircuitLossDataGridViewTextBoxColumn1,
				this.noLoadLossDataGridViewTextBoxColumn1,
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
			this.dataGridViewExcelFilter1.Size = new System.Drawing.Size(728, 365);
			this.dataGridViewExcelFilter1.TabIndex = 4;
			this.dataGridViewExcelFilter1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExcelFilter1_CellDoubleClick);
			this.dataGridViewExcelFilter1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewExcelFilter1_DataError);
			this.yvBwPlixdU.DataPropertyName = "id";
			this.yvBwPlixdU.HeaderText = "id";
			this.yvBwPlixdU.Name = "idDataGridViewTextBoxColumn1";
			this.yvBwPlixdU.ReadOnly = true;
			this.yvBwPlixdU.Visible = false;
			this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
			this.nameDataGridViewTextBoxColumn1.MinimumWidth = 100;
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn1.HeaderText = "Тип";
			this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
			this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
			this.typeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.powerDataGridViewTextBoxColumn1.DataPropertyName = "Power";
			this.powerDataGridViewTextBoxColumn1.HeaderText = "Мощность";
			this.powerDataGridViewTextBoxColumn1.Name = "powerDataGridViewTextBoxColumn1";
			this.powerDataGridViewTextBoxColumn1.ReadOnly = true;
			this.powerDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.highVoltageDataGridViewTextBoxColumn1.DataPropertyName = "HighVoltage";
			this.highVoltageDataGridViewTextBoxColumn1.HeaderText = "Номинальное высшее напряжение";
			this.highVoltageDataGridViewTextBoxColumn1.Name = "highVoltageDataGridViewTextBoxColumn1";
			this.highVoltageDataGridViewTextBoxColumn1.ReadOnly = true;
			this.highVoltageDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.lowVoltageDataGridViewTextBoxColumn1.DataPropertyName = "LowVoltage";
			this.lowVoltageDataGridViewTextBoxColumn1.HeaderText = "Номинальное низшее напряжение";
			this.lowVoltageDataGridViewTextBoxColumn1.Name = "lowVoltageDataGridViewTextBoxColumn1";
			this.lowVoltageDataGridViewTextBoxColumn1.ReadOnly = true;
			this.lowVoltageDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ratedAmperHVDataGridViewTextBoxColumn1.DataPropertyName = "RatedAmperHV";
			this.ratedAmperHVDataGridViewTextBoxColumn1.HeaderText = "Номинальный ток высокого напряжение";
			this.ratedAmperHVDataGridViewTextBoxColumn1.Name = "ratedAmperHVDataGridViewTextBoxColumn1";
			this.ratedAmperHVDataGridViewTextBoxColumn1.ReadOnly = true;
			this.ratedAmperHVDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ratedAmperLVDataGridViewTextBoxColumn1.DataPropertyName = "RatedAmperLV";
			this.ratedAmperLVDataGridViewTextBoxColumn1.HeaderText = "Номинальный ток низкого напряжения";
			this.ratedAmperLVDataGridViewTextBoxColumn1.Name = "ratedAmperLVDataGridViewTextBoxColumn1";
			this.ratedAmperLVDataGridViewTextBoxColumn1.ReadOnly = true;
			this.ratedAmperLVDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.groupWindingsDataGridViewTextBoxColumn1.DataPropertyName = "GroupWindings";
			this.groupWindingsDataGridViewTextBoxColumn1.HeaderText = "Группа обмоток";
			this.groupWindingsDataGridViewTextBoxColumn1.Name = "groupWindingsDataGridViewTextBoxColumn1";
			this.groupWindingsDataGridViewTextBoxColumn1.ReadOnly = true;
			this.groupWindingsDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.shortCircuitVoltDataGridViewTextBoxColumn1.DataPropertyName = "ShortCircuitVolt";
			this.shortCircuitVoltDataGridViewTextBoxColumn1.HeaderText = "Напряжение короткого замыкания";
			this.shortCircuitVoltDataGridViewTextBoxColumn1.Name = "shortCircuitVoltDataGridViewTextBoxColumn1";
			this.shortCircuitVoltDataGridViewTextBoxColumn1.ReadOnly = true;
			this.shortCircuitVoltDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.shortCircuitLossDataGridViewTextBoxColumn1.DataPropertyName = "ShortCircuitLoss";
			this.shortCircuitLossDataGridViewTextBoxColumn1.HeaderText = "Потери короткого замыкания";
			this.shortCircuitLossDataGridViewTextBoxColumn1.Name = "shortCircuitLossDataGridViewTextBoxColumn1";
			this.shortCircuitLossDataGridViewTextBoxColumn1.ReadOnly = true;
			this.shortCircuitLossDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.noLoadLossDataGridViewTextBoxColumn1.DataPropertyName = "NoLoadLoss";
			this.noLoadLossDataGridViewTextBoxColumn1.HeaderText = "Потери холостого хода";
			this.noLoadLossDataGridViewTextBoxColumn1.Name = "noLoadLossDataGridViewTextBoxColumn1";
			this.noLoadLossDataGridViewTextBoxColumn1.ReadOnly = true;
			this.noLoadLossDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.deletedDataGridViewCheckBoxColumn1.DataPropertyName = "Deleted";
			this.deletedDataGridViewCheckBoxColumn1.HeaderText = "Deleted";
			this.deletedDataGridViewCheckBoxColumn1.Name = "deletedDataGridViewCheckBoxColumn1";
			this.deletedDataGridViewCheckBoxColumn1.ReadOnly = true;
			this.deletedDataGridViewCheckBoxColumn1.Visible = false;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewExcelFilter1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43f));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 414);
			this.tableLayoutPanel1.TabIndex = 5;
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
			this.tableLayoutPanel2.Size = new System.Drawing.Size(728, 37);
			this.tableLayoutPanel2.TabIndex = 30;
			this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAccept.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAccept.Location = new System.Drawing.Point(521, 6);
			this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 6, 10, 6);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(99, 25);
			this.btnAccept.TabIndex = 8;
			this.btnAccept.Text = "Выбрать";
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnCancel.Location = new System.Drawing.Point(640, 6);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 6, 3, 6);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 25);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Закрыть";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(734, 439);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Controls.Add(this.toolStrip1);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormTrasformer";
			this.Text = "Трансформатор";
			base.Load += new System.EventHandler(this.FormTrasformer_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataGridViewExcelFilter1).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.ToolStrip toolStrip1;

		private System.Windows.Forms.ToolStripButton toolStripButtonAddTransformer;

		private System.Windows.Forms.ToolStripButton toolStripButtonEditTransformer;

		private System.Windows.Forms.ToolStripButton toolStripButtonRemoveRestore;

		private System.Windows.Forms.ToolStripButton toolStripButtonViewDeleted;

		private System.Windows.Forms.BindingSource bindingSource_0;

		private Class37 class37_0;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter1;

		private System.Windows.Forms.DataGridViewTextBoxColumn yvBwPlixdU;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn typeDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn powerDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn highVoltageDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn lowVoltageDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn ratedAmperHVDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn ratedAmperLVDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn groupWindingsDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn shortCircuitVoltDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn shortCircuitLossDataGridViewTextBoxColumn1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn noLoadLossDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn1;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;

		private System.Windows.Forms.ToolStripButton toolStripButtonSearchPrev;

		private System.Windows.Forms.ToolStripButton toolStripButtonSearchNext;

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		private System.Windows.Forms.Button btnAccept;

		private System.Windows.Forms.Button btnCancel;
	}
}
