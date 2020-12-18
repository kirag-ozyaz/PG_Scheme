namespace Reference.Forms.Worker
{
	public partial class FormWorkerOrganization : FormLbr.FormBase
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			this.class48_0 = new Class48();
			this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.dgv = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolTxtFilter = new System.Windows.Forms.ToolStripTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.class48_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgv).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.class48_0.DataSetName = "DataSetWorkers";
			this.class48_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.bindingSource_0.DataMember = "tAbn";
			this.bindingSource_0.DataSource = this.class48_0;
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToDeleteRows = false;
			dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
			this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dgv.AutoGenerateColumns = false;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idDataGridViewTextBoxColumn,
				this.codeAbonentDataGridViewTextBoxColumn,
				this.nameDataGridViewTextBoxColumn,
				this.typeAbnDataGridViewTextBoxColumn,
				this.idWorkerDataGridViewTextBoxColumn,
				this.deletedDataGridViewCheckBoxColumn
			});
			this.dgv.DataSource = this.bindingSource_0;
			this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv.Location = new System.Drawing.Point(0, 25);
			this.dgv.MultiSelect = false;
			this.dgv.Name = "dgv";
			this.dgv.ReadOnly = true;
			this.dgv.RowHeadersWidth = 21;
			this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv.Size = new System.Drawing.Size(579, 277);
			this.dgv.TabIndex = 1;
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
			this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
			this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
			this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.typeAbnDataGridViewTextBoxColumn.DataPropertyName = "TypeAbn";
			this.typeAbnDataGridViewTextBoxColumn.HeaderText = "TypeAbn";
			this.typeAbnDataGridViewTextBoxColumn.Name = "typeAbnDataGridViewTextBoxColumn";
			this.typeAbnDataGridViewTextBoxColumn.ReadOnly = true;
			this.typeAbnDataGridViewTextBoxColumn.Visible = false;
			this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "idWorker";
			this.idWorkerDataGridViewTextBoxColumn.HeaderText = "idWorker";
			this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
			this.idWorkerDataGridViewTextBoxColumn.ReadOnly = true;
			this.idWorkerDataGridViewTextBoxColumn.Visible = false;
			this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
			this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
			this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
			this.deletedDataGridViewCheckBoxColumn.ReadOnly = true;
			this.deletedDataGridViewCheckBoxColumn.Visible = false;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolTxtFilter
			});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(579, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			this.toolTxtFilter.Name = "toolTxtFilter";
			this.toolTxtFilter.Size = new System.Drawing.Size(200, 25);
			this.toolTxtFilter.TextChanged += new System.EventHandler(this.toolTxtFilter_TextChanged);
			this.panel1.Controls.Add(this.buttonCancel);
			this.panel1.Controls.Add(this.buttonOK);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 302);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(579, 51);
			this.panel1.TabIndex = 2;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(492, 16);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(12, 16);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(579, 353);
			base.Controls.Add(this.dgv);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.toolStrip1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormWorkerOrganization";
			this.Text = "Организации";
			base.Activated += new System.EventHandler(this.FormWorkerOrganization_Activated);
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWorkerOrganization_FormClosing);
			base.Load += new System.EventHandler(this.FormWorkerOrganization_Load);
			((System.ComponentModel.ISupportInitialize)this.class48_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgv).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private Class48 class48_0;

		private System.Windows.Forms.BindingSource bindingSource_0;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgv;

		private System.Windows.Forms.ToolStrip toolStrip1;

		private System.Windows.Forms.ToolStripTextBox toolTxtFilter;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn typeAbnDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;

		private System.Windows.Forms.Panel panel1;

		private System.Windows.Forms.Button buttonCancel;

		private System.Windows.Forms.Button buttonOK;
	}
}
