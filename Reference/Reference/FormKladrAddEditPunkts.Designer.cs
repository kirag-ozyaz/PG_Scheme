internal partial class FormKladrAddEditPunkts : FormLbr.FormBase
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
		this.labelParent = new System.Windows.Forms.Label();
		this.comboBoxParent = new System.Windows.Forms.ComboBox();
		this.class20_0 = new Class20();
		this.dataSet_0 = new System.Data.DataSet();
		this.dataTable_0 = new System.Data.DataTable();
		this.dataColumn_0 = new System.Data.DataColumn();
		this.dataColumn_1 = new System.Data.DataColumn();
		this.dataColumn_2 = new System.Data.DataColumn();
		this.dataColumn_3 = new System.Data.DataColumn();
		this.dataColumn_4 = new System.Data.DataColumn();
		this.labelName = new System.Windows.Forms.Label();
		this.textBoxName = new System.Windows.Forms.TextBox();
		this.labelPrefix = new System.Windows.Forms.Label();
		this.comboBoxPrefix = new System.Windows.Forms.ComboBox();
		this.labelKladrCode = new System.Windows.Forms.Label();
		this.textBoxKladrCode = new System.Windows.Forms.TextBox();
		this.labelIndex = new System.Windows.Forms.Label();
		this.textBoxIndex = new System.Windows.Forms.TextBox();
		this.textBoxGninmb = new System.Windows.Forms.TextBox();
		this.labelGninmb = new System.Windows.Forms.Label();
		this.buttonOk = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.labelTypeObj = new System.Windows.Forms.Label();
		this.cmbTypeObj = new System.Windows.Forms.ComboBox();
		((System.ComponentModel.ISupportInitialize)this.class20_0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet_0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
		base.SuspendLayout();
		this.labelParent.AutoSize = true;
		this.labelParent.Location = new System.Drawing.Point(12, 9);
		this.labelParent.Name = "labelParent";
		this.labelParent.Size = new System.Drawing.Size(55, 13);
		this.labelParent.TabIndex = 0;
		this.labelParent.Text = "Родитель";
		this.comboBoxParent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.comboBoxParent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.comboBoxParent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.class20_0, "tR_KladrObj.ParentId", true));
		this.comboBoxParent.DataSource = this.dataSet_0;
		this.comboBoxParent.DisplayMember = "tR_KladrObj.NameSocr";
		this.comboBoxParent.FormattingEnabled = true;
		this.comboBoxParent.Location = new System.Drawing.Point(12, 25);
		this.comboBoxParent.Name = "comboBoxParent";
		this.comboBoxParent.Size = new System.Drawing.Size(250, 21);
		this.comboBoxParent.TabIndex = 1;
		this.comboBoxParent.ValueMember = "tR_KladrObj.Id";
		this.comboBoxParent.SelectedIndexChanged += new System.EventHandler(this.comboBoxParent_SelectedIndexChanged);
		this.class20_0.DataSetName = "DataSetKladr";
		this.class20_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			this.dataColumn_3,
			this.dataColumn_4
		});
		this.dataTable_0.TableName = "tR_KladrObj";
		this.dataColumn_0.ColumnName = "Id";
		this.dataColumn_0.DataType = typeof(int);
		this.dataColumn_1.ColumnName = "Name";
		this.dataColumn_2.ColumnName = "Socr";
		this.dataColumn_3.ColumnName = "NameSocr";
		this.dataColumn_3.Expression = "Name + ' ' + isnull(Socr, '')";
		this.dataColumn_3.ReadOnly = true;
		this.dataColumn_4.AllowDBNull = false;
		this.dataColumn_4.ColumnName = "Level";
		this.dataColumn_4.DataType = typeof(int);
		this.dataColumn_4.DefaultValue = 1;
		this.labelName.AutoSize = true;
		this.labelName.Location = new System.Drawing.Point(9, 108);
		this.labelName.Name = "labelName";
		this.labelName.Size = new System.Drawing.Size(83, 13);
		this.labelName.TabIndex = 2;
		this.labelName.Text = "Намиенование";
		this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tR_KladrObj.Name", true));
		this.textBoxName.Location = new System.Drawing.Point(12, 124);
		this.textBoxName.Name = "textBoxName";
		this.textBoxName.Size = new System.Drawing.Size(135, 20);
		this.textBoxName.TabIndex = 3;
		this.labelPrefix.AutoSize = true;
		this.labelPrefix.Location = new System.Drawing.Point(158, 108);
		this.labelPrefix.Name = "labelPrefix";
		this.labelPrefix.Size = new System.Drawing.Size(53, 13);
		this.labelPrefix.TabIndex = 4;
		this.labelPrefix.Text = "Префикс";
		this.comboBoxPrefix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.comboBoxPrefix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.comboBoxPrefix.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.class20_0, "tR_KladrObj.Socr", true));
		this.comboBoxPrefix.DataSource = this.class20_0;
		this.comboBoxPrefix.DisplayMember = "tR_KladrSocr.SocrName";
		this.comboBoxPrefix.FormattingEnabled = true;
		this.comboBoxPrefix.Location = new System.Drawing.Point(159, 123);
		this.comboBoxPrefix.Name = "comboBoxPrefix";
		this.comboBoxPrefix.Size = new System.Drawing.Size(103, 21);
		this.comboBoxPrefix.TabIndex = 5;
		this.comboBoxPrefix.ValueMember = "tR_KladrSocr.scname";
		this.labelKladrCode.AutoSize = true;
		this.labelKladrCode.Location = new System.Drawing.Point(9, 161);
		this.labelKladrCode.Name = "labelKladrCode";
		this.labelKladrCode.Size = new System.Drawing.Size(65, 13);
		this.labelKladrCode.TabIndex = 6;
		this.labelKladrCode.Text = "Код кладра";
		this.textBoxKladrCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tR_KladrObj.KladrCode", true));
		this.textBoxKladrCode.Location = new System.Drawing.Point(12, 177);
		this.textBoxKladrCode.Name = "textBoxKladrCode";
		this.textBoxKladrCode.Size = new System.Drawing.Size(250, 20);
		this.textBoxKladrCode.TabIndex = 7;
		this.labelIndex.AutoSize = true;
		this.labelIndex.Location = new System.Drawing.Point(9, 212);
		this.labelIndex.Name = "labelIndex";
		this.labelIndex.Size = new System.Drawing.Size(45, 13);
		this.labelIndex.TabIndex = 8;
		this.labelIndex.Text = "Индекс";
		this.textBoxIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tR_KladrObj.Index", true));
		this.textBoxIndex.Location = new System.Drawing.Point(12, 228);
		this.textBoxIndex.Name = "textBoxIndex";
		this.textBoxIndex.Size = new System.Drawing.Size(100, 20);
		this.textBoxIndex.TabIndex = 9;
		this.textBoxGninmb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tR_KladrObj.GNINMB", true));
		this.textBoxGninmb.Location = new System.Drawing.Point(159, 228);
		this.textBoxGninmb.Name = "textBoxGninmb";
		this.textBoxGninmb.Size = new System.Drawing.Size(103, 20);
		this.textBoxGninmb.TabIndex = 10;
		this.labelGninmb.AutoSize = true;
		this.labelGninmb.Location = new System.Drawing.Point(156, 212);
		this.labelGninmb.Name = "labelGninmb";
		this.labelGninmb.Size = new System.Drawing.Size(55, 13);
		this.labelGninmb.TabIndex = 11;
		this.labelGninmb.Text = "Код ФНС";
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Location = new System.Drawing.Point(12, 255);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(75, 23);
		this.buttonOk.TabIndex = 12;
		this.buttonOk.Text = "ОК";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(187, 255);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 13;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.labelTypeObj.AutoSize = true;
		this.labelTypeObj.Location = new System.Drawing.Point(12, 61);
		this.labelTypeObj.Name = "labelTypeObj";
		this.labelTypeObj.Size = new System.Drawing.Size(131, 13);
		this.labelTypeObj.TabIndex = 14;
		this.labelTypeObj.Text = "Тип населенного пункта";
		this.cmbTypeObj.FormattingEnabled = true;
		this.cmbTypeObj.Location = new System.Drawing.Point(12, 77);
		this.cmbTypeObj.Name = "cmbTypeObj";
		this.cmbTypeObj.Size = new System.Drawing.Size(250, 21);
		this.cmbTypeObj.TabIndex = 15;
		this.cmbTypeObj.SelectedIndexChanged += new System.EventHandler(this.cmbTypeObj_SelectedIndexChanged);
		base.AcceptButton = this.buttonOk;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(274, 290);
		base.Controls.Add(this.cmbTypeObj);
		base.Controls.Add(this.labelTypeObj);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.labelGninmb);
		base.Controls.Add(this.textBoxGninmb);
		base.Controls.Add(this.textBoxIndex);
		base.Controls.Add(this.labelIndex);
		base.Controls.Add(this.textBoxKladrCode);
		base.Controls.Add(this.labelKladrCode);
		base.Controls.Add(this.comboBoxPrefix);
		base.Controls.Add(this.labelPrefix);
		base.Controls.Add(this.textBoxName);
		base.Controls.Add(this.labelName);
		base.Controls.Add(this.comboBoxParent);
		base.Controls.Add(this.labelParent);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormKladrAddEditPunkts";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Добавление/редактирование";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKladrAddEditPunkts_FormClosing);
		base.Load += new System.EventHandler(this.FormKladrAddEditPunkts_Load);
		((System.ComponentModel.ISupportInitialize)this.class20_0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet_0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private System.ComponentModel.IContainer icontainer_0;

	private System.Windows.Forms.Label labelParent;

	private System.Windows.Forms.ComboBox comboBoxParent;

	private System.Windows.Forms.Label labelName;

	private System.Windows.Forms.TextBox textBoxName;

	private System.Windows.Forms.Label labelPrefix;

	private System.Windows.Forms.ComboBox comboBoxPrefix;

	private System.Windows.Forms.Label labelKladrCode;

	private System.Windows.Forms.TextBox textBoxKladrCode;

	private System.Windows.Forms.Label labelIndex;

	private System.Windows.Forms.TextBox textBoxIndex;

	private System.Windows.Forms.TextBox textBoxGninmb;

	private System.Windows.Forms.Label labelGninmb;

	private System.Windows.Forms.Button buttonOk;

	private System.Windows.Forms.Button buttonCancel;

	private System.Data.DataSet dataSet_0;

	private System.Data.DataTable dataTable_0;

	private System.Data.DataColumn dataColumn_0;

	private System.Data.DataColumn dataColumn_1;

	private System.Data.DataColumn dataColumn_2;

	private System.Data.DataColumn dataColumn_3;

	private Class20 class20_0;

	private System.Windows.Forms.Label labelTypeObj;

	private System.Windows.Forms.ComboBox cmbTypeObj;

	private System.Data.DataColumn dataColumn_4;
}
