internal partial class FormGroupWorkerAdd : FormLbr.FormBase
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
		this.labelGroup = new System.Windows.Forms.Label();
		this.cmbGroup = new System.Windows.Forms.ComboBox();
		this.class48_0 = new Class48();
		this.labelWorker = new System.Windows.Forms.Label();
		this.cmbWorker = new System.Windows.Forms.ComboBox();
		this.dataSet_0 = new System.Data.DataSet();
		this.dataTable_0 = new System.Data.DataTable();
		this.dataColumn_0 = new System.Data.DataColumn();
		this.dataColumn_1 = new System.Data.DataColumn();
		this.dataColumn_2 = new System.Data.DataColumn();
		this.laDhzrySiQ = new System.Data.DataColumn();
		this.dataColumn_3 = new System.Data.DataColumn();
		this.buttonOk = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.class48_0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet_0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
		base.SuspendLayout();
		this.labelGroup.AutoSize = true;
		this.labelGroup.Location = new System.Drawing.Point(12, 9);
		this.labelGroup.Name = "labelGroup";
		this.labelGroup.Size = new System.Drawing.Size(42, 13);
		this.labelGroup.TabIndex = 0;
		this.labelGroup.Text = "Группа";
		this.cmbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cmbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cmbGroup.DataSource = this.class48_0;
		this.cmbGroup.DisplayMember = "tR_Classifier.Name";
		this.cmbGroup.FormattingEnabled = true;
		this.cmbGroup.Location = new System.Drawing.Point(15, 25);
		this.cmbGroup.Name = "cmbGroup";
		this.cmbGroup.Size = new System.Drawing.Size(219, 21);
		this.cmbGroup.TabIndex = 1;
		this.cmbGroup.ValueMember = "tR_Classifier.Id";
		this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
		this.class48_0.DataSetName = "DataSetWorkers";
		this.class48_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.labelWorker.AutoSize = true;
		this.labelWorker.Location = new System.Drawing.Point(12, 61);
		this.labelWorker.Name = "labelWorker";
		this.labelWorker.Size = new System.Drawing.Size(60, 13);
		this.labelWorker.TabIndex = 2;
		this.labelWorker.Text = "Сотрудник";
		this.cmbWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.cmbWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.cmbWorker.DataSource = this.dataSet_0;
		this.cmbWorker.DisplayMember = "tR_Worker.FIO";
		this.cmbWorker.FormattingEnabled = true;
		this.cmbWorker.Location = new System.Drawing.Point(15, 77);
		this.cmbWorker.Name = "cmbWorker";
		this.cmbWorker.Size = new System.Drawing.Size(219, 21);
		this.cmbWorker.TabIndex = 3;
		this.cmbWorker.ValueMember = "tR_Worker.Id";
		this.dataSet_0.DataSetName = "NewDataSet";
		this.dataSet_0.Tables.AddRange(new System.Data.DataTable[]
		{
			this.dataTable_0
		});
		this.dataTable_0.Columns.AddRange(new System.Data.DataColumn[]
		{
			this.dataColumn_0,
			this.dataColumn_1,
			this.dataColumn_2,
			this.laDhzrySiQ,
			this.dataColumn_3
		});
		this.dataTable_0.TableName = "tR_Worker";
		this.dataColumn_0.ColumnName = "Id";
		this.dataColumn_0.DataType = typeof(int);
		this.dataColumn_1.ColumnName = "F";
		this.dataColumn_2.ColumnName = "I";
		this.laDhzrySiQ.ColumnName = "O";
		this.dataColumn_3.ColumnName = "FIO";
		this.dataColumn_3.Expression = "isnull(F, '') + ' '  + isnull(I, '') + ' ' + isnull(O, '')";
		this.dataColumn_3.ReadOnly = true;
		this.buttonOk.Location = new System.Drawing.Point(15, 122);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(75, 23);
		this.buttonOk.TabIndex = 4;
		this.buttonOk.Text = "ОК";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(159, 122);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 5;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(246, 158);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.cmbWorker);
		base.Controls.Add(this.labelWorker);
		base.Controls.Add(this.cmbGroup);
		base.Controls.Add(this.labelGroup);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormGroupWorkerAdd";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Добавление сотрудника в группу";
		base.Load += new System.EventHandler(this.FormGroupWorkerAdd_Load);
		((System.ComponentModel.ISupportInitialize)this.class48_0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet_0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private System.ComponentModel.IContainer icontainer_0;

	private System.Windows.Forms.Label labelGroup;

	private System.Windows.Forms.ComboBox cmbGroup;

	private System.Windows.Forms.Label labelWorker;

	private System.Windows.Forms.ComboBox cmbWorker;

	private System.Windows.Forms.Button buttonOk;

	private System.Windows.Forms.Button buttonCancel;

	private Class48 class48_0;

	private System.Data.DataSet dataSet_0;

	private System.Data.DataTable dataTable_0;

	private System.Data.DataColumn dataColumn_0;

	private System.Data.DataColumn dataColumn_1;

	private System.Data.DataColumn dataColumn_2;

	private System.Data.DataColumn laDhzrySiQ;

	private System.Data.DataColumn dataColumn_3;
}
