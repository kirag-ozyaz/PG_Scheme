internal partial class FormKladrAddEditStreet : FormLbr.FormBase
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
		this.labelKladrObj = new System.Windows.Forms.Label();
		this.comboBoxKladrObj = new System.Windows.Forms.ComboBox();
		this.class20_0 = new Class20();
		this.dataSet_0 = new System.Data.DataSet();
		this.dataTable_0 = new System.Data.DataTable();
		this.dataColumn_0 = new System.Data.DataColumn();
		this.dataColumn_1 = new System.Data.DataColumn();
		this.dataColumn_2 = new System.Data.DataColumn();
		this.dataColumn_3 = new System.Data.DataColumn();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.buttonOk = new System.Windows.Forms.Button();
		this.labelGninmb = new System.Windows.Forms.Label();
		this.textBoxGninmb = new System.Windows.Forms.TextBox();
		this.textBoxIndex = new System.Windows.Forms.TextBox();
		this.labelIndex = new System.Windows.Forms.Label();
		this.textBoxKladrCode = new System.Windows.Forms.TextBox();
		this.labelKladrCode = new System.Windows.Forms.Label();
		this.comboBoxPrefix = new System.Windows.Forms.ComboBox();
		this.labelPrefix = new System.Windows.Forms.Label();
		this.textBoxName = new System.Windows.Forms.TextBox();
		this.labelName = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.class20_0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet_0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
		base.SuspendLayout();
		this.labelKladrObj.AutoSize = true;
		this.labelKladrObj.Location = new System.Drawing.Point(12, 9);
		this.labelKladrObj.Name = "labelKladrObj";
		this.labelKladrObj.Size = new System.Drawing.Size(102, 13);
		this.labelKladrObj.TabIndex = 0;
		this.labelKladrObj.Text = "Населенный пункт";
		this.comboBoxKladrObj.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.comboBoxKladrObj.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.comboBoxKladrObj.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.class20_0, "tR_KladrStreet.KladrObjId", true));
		this.comboBoxKladrObj.DataSource = this.dataSet_0;
		this.comboBoxKladrObj.DisplayMember = "tR_KladrObj.NameSocr";
		this.comboBoxKladrObj.FormattingEnabled = true;
		this.comboBoxKladrObj.Location = new System.Drawing.Point(15, 25);
		this.comboBoxKladrObj.Name = "comboBoxKladrObj";
		this.comboBoxKladrObj.Size = new System.Drawing.Size(247, 21);
		this.comboBoxKladrObj.TabIndex = 1;
		this.comboBoxKladrObj.ValueMember = "tR_KladrObj.Id";
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
			this.dataColumn_3
		});
		this.dataTable_0.TableName = "tR_KladrObj";
		this.dataColumn_0.ColumnName = "Id";
		this.dataColumn_0.DataType = typeof(int);
		this.dataColumn_1.ColumnName = "Name";
		this.dataColumn_2.ColumnName = "Socr";
		this.dataColumn_3.ColumnName = "NameSocr";
		this.dataColumn_3.Expression = "Name + ' ' + isnull(Socr, '')";
		this.dataColumn_3.ReadOnly = true;
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(187, 210);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 25;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.buttonOk.Location = new System.Drawing.Point(15, 210);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(75, 23);
		this.buttonOk.TabIndex = 24;
		this.buttonOk.Text = "ОК";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
		this.labelGninmb.AutoSize = true;
		this.labelGninmb.Location = new System.Drawing.Point(159, 163);
		this.labelGninmb.Name = "labelGninmb";
		this.labelGninmb.Size = new System.Drawing.Size(55, 13);
		this.labelGninmb.TabIndex = 23;
		this.labelGninmb.Text = "Код ФНС";
		this.textBoxGninmb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tR_KladrStreet.GNINMB", true));
		this.textBoxGninmb.Location = new System.Drawing.Point(162, 179);
		this.textBoxGninmb.Name = "textBoxGninmb";
		this.textBoxGninmb.Size = new System.Drawing.Size(100, 20);
		this.textBoxGninmb.TabIndex = 22;
		this.textBoxIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tR_KladrStreet.Index", true));
		this.textBoxIndex.Location = new System.Drawing.Point(15, 179);
		this.textBoxIndex.Name = "textBoxIndex";
		this.textBoxIndex.Size = new System.Drawing.Size(100, 20);
		this.textBoxIndex.TabIndex = 21;
		this.labelIndex.AutoSize = true;
		this.labelIndex.Location = new System.Drawing.Point(12, 163);
		this.labelIndex.Name = "labelIndex";
		this.labelIndex.Size = new System.Drawing.Size(45, 13);
		this.labelIndex.TabIndex = 20;
		this.labelIndex.Text = "Индекс";
		this.textBoxKladrCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tR_KladrStreet.KladrCode", true));
		this.textBoxKladrCode.Location = new System.Drawing.Point(15, 128);
		this.textBoxKladrCode.Name = "textBoxKladrCode";
		this.textBoxKladrCode.Size = new System.Drawing.Size(247, 20);
		this.textBoxKladrCode.TabIndex = 19;
		this.labelKladrCode.AutoSize = true;
		this.labelKladrCode.Location = new System.Drawing.Point(12, 112);
		this.labelKladrCode.Name = "labelKladrCode";
		this.labelKladrCode.Size = new System.Drawing.Size(65, 13);
		this.labelKladrCode.TabIndex = 18;
		this.labelKladrCode.Text = "Код кладра";
		this.comboBoxPrefix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
		this.comboBoxPrefix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.comboBoxPrefix.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.class20_0, "tR_KladrStreet.Socr", true));
		this.comboBoxPrefix.DataSource = this.class20_0;
		this.comboBoxPrefix.DisplayMember = "tR_KladrSocr.SocrName";
		this.comboBoxPrefix.FormattingEnabled = true;
		this.comboBoxPrefix.Location = new System.Drawing.Point(162, 74);
		this.comboBoxPrefix.Name = "comboBoxPrefix";
		this.comboBoxPrefix.Size = new System.Drawing.Size(100, 21);
		this.comboBoxPrefix.TabIndex = 17;
		this.comboBoxPrefix.ValueMember = "tR_KladrSocr.scname";
		this.labelPrefix.AutoSize = true;
		this.labelPrefix.Location = new System.Drawing.Point(161, 59);
		this.labelPrefix.Name = "labelPrefix";
		this.labelPrefix.Size = new System.Drawing.Size(53, 13);
		this.labelPrefix.TabIndex = 16;
		this.labelPrefix.Text = "Префикс";
		this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tR_KladrStreet.Name", true));
		this.textBoxName.Location = new System.Drawing.Point(15, 75);
		this.textBoxName.Name = "textBoxName";
		this.textBoxName.Size = new System.Drawing.Size(135, 20);
		this.textBoxName.TabIndex = 15;
		this.labelName.AutoSize = true;
		this.labelName.Location = new System.Drawing.Point(12, 59);
		this.labelName.Name = "labelName";
		this.labelName.Size = new System.Drawing.Size(83, 13);
		this.labelName.TabIndex = 14;
		this.labelName.Text = "Наименование";
		base.AcceptButton = this.buttonOk;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(273, 242);
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
		base.Controls.Add(this.comboBoxKladrObj);
		base.Controls.Add(this.labelKladrObj);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormKladrAddEditStreet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "FormKladrAddEditStreet";
		base.Load += new System.EventHandler(this.FormKladrAddEditStreet_Load);
		((System.ComponentModel.ISupportInitialize)this.class20_0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet_0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private System.ComponentModel.IContainer icontainer_0;

	private System.Windows.Forms.Label labelKladrObj;

	private System.Windows.Forms.ComboBox comboBoxKladrObj;

	private System.Windows.Forms.Button buttonCancel;

	private System.Windows.Forms.Button buttonOk;

	private System.Windows.Forms.Label labelGninmb;

	private System.Windows.Forms.TextBox textBoxGninmb;

	private System.Windows.Forms.TextBox textBoxIndex;

	private System.Windows.Forms.Label labelIndex;

	private System.Windows.Forms.TextBox textBoxKladrCode;

	private System.Windows.Forms.Label labelKladrCode;

	private System.Windows.Forms.ComboBox comboBoxPrefix;

	private System.Windows.Forms.Label labelPrefix;

	private System.Windows.Forms.TextBox textBoxName;

	private System.Windows.Forms.Label labelName;

	private Class20 class20_0;

	private System.Data.DataSet dataSet_0;

	private System.Data.DataTable dataTable_0;

	private System.Data.DataColumn dataColumn_0;

	private System.Data.DataColumn dataColumn_1;

	private System.Data.DataColumn dataColumn_2;

	private System.Data.DataColumn dataColumn_3;
}
