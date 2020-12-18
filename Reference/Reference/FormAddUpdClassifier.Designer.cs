internal partial class FormAddUpdClassifier : FormLbr.FormBase
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
		this.textBoxParent = new System.Windows.Forms.TextBox();
		this.labelParent = new System.Windows.Forms.Label();
		this.ljdOdiUpxb = new System.Windows.Forms.GroupBox();
		this.labelSocrName = new System.Windows.Forms.Label();
		this.textBoxSocrName = new System.Windows.Forms.TextBox();
		this.class48_0 = new Class48();
		this.labelParentKey = new System.Windows.Forms.Label();
		this.textBoxParentKey = new System.Windows.Forms.TextBox();
		this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
		this.labelComment = new System.Windows.Forms.Label();
		this.labelValue = new System.Windows.Forms.Label();
		this.labelName = new System.Windows.Forms.Label();
		this.textBoxValue = new System.Windows.Forms.TextBox();
		this.textBoxName = new System.Windows.Forms.TextBox();
		this.dataTable_0 = new System.Data.DataTable();
		this.dataColumn_0 = new System.Data.DataColumn();
		this.dataColumn_1 = new System.Data.DataColumn();
		this.dataColumn_2 = new System.Data.DataColumn();
		this.dataColumn_3 = new System.Data.DataColumn();
		this.dataColumn_4 = new System.Data.DataColumn();
		this.dataColumn_5 = new System.Data.DataColumn();
		this.dataColumn_6 = new System.Data.DataColumn();
		this.dataColumn_7 = new System.Data.DataColumn();
		this.buttonOK = new System.Windows.Forms.Button();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.ljdOdiUpxb.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.class48_0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
		base.SuspendLayout();
		this.textBoxParent.BackColor = System.Drawing.SystemColors.Window;
		this.textBoxParent.Location = new System.Drawing.Point(73, 12);
		this.textBoxParent.Name = "textBoxParent";
		this.textBoxParent.ReadOnly = true;
		this.textBoxParent.Size = new System.Drawing.Size(190, 20);
		this.textBoxParent.TabIndex = 4;
		this.labelParent.AutoSize = true;
		this.labelParent.Location = new System.Drawing.Point(12, 15);
		this.labelParent.Name = "labelParent";
		this.labelParent.Size = new System.Drawing.Size(55, 13);
		this.labelParent.TabIndex = 3;
		this.labelParent.Text = "Родитель";
		this.ljdOdiUpxb.Controls.Add(this.labelSocrName);
		this.ljdOdiUpxb.Controls.Add(this.textBoxSocrName);
		this.ljdOdiUpxb.Controls.Add(this.labelParentKey);
		this.ljdOdiUpxb.Controls.Add(this.textBoxParentKey);
		this.ljdOdiUpxb.Controls.Add(this.richTextBoxComment);
		this.ljdOdiUpxb.Controls.Add(this.labelComment);
		this.ljdOdiUpxb.Controls.Add(this.labelValue);
		this.ljdOdiUpxb.Controls.Add(this.labelName);
		this.ljdOdiUpxb.Controls.Add(this.textBoxValue);
		this.ljdOdiUpxb.Controls.Add(this.textBoxName);
		this.ljdOdiUpxb.Location = new System.Drawing.Point(15, 38);
		this.ljdOdiUpxb.Name = "groupBox";
		this.ljdOdiUpxb.Size = new System.Drawing.Size(248, 261);
		this.ljdOdiUpxb.TabIndex = 0;
		this.ljdOdiUpxb.TabStop = false;
		this.labelSocrName.AutoSize = true;
		this.labelSocrName.Location = new System.Drawing.Point(6, 55);
		this.labelSocrName.Name = "labelSocrName";
		this.labelSocrName.Size = new System.Drawing.Size(109, 13);
		this.labelSocrName.TabIndex = 2;
		this.labelSocrName.Text = "Сокр наименование";
		this.textBoxSocrName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class48_0, "tR_Classifier.SocrName", true));
		this.textBoxSocrName.Location = new System.Drawing.Point(9, 71);
		this.textBoxSocrName.Name = "textBoxSocrName";
		this.textBoxSocrName.Size = new System.Drawing.Size(233, 20);
		this.textBoxSocrName.TabIndex = 3;
		this.class48_0.DataSetName = "NewDataSet";
		this.class48_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.labelParentKey.AutoSize = true;
		this.labelParentKey.Location = new System.Drawing.Point(6, 133);
		this.labelParentKey.Name = "labelParentKey";
		this.labelParentKey.Size = new System.Drawing.Size(33, 13);
		this.labelParentKey.TabIndex = 6;
		this.labelParentKey.Text = "Ключ";
		this.textBoxParentKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class48_0, "tR_Classifier.ParentKey", true));
		this.textBoxParentKey.Location = new System.Drawing.Point(9, 149);
		this.textBoxParentKey.Name = "textBoxParentKey";
		this.textBoxParentKey.Size = new System.Drawing.Size(233, 20);
		this.textBoxParentKey.TabIndex = 7;
		this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class48_0, "tR_Classifier.Comment", true));
		this.richTextBoxComment.Location = new System.Drawing.Point(9, 188);
		this.richTextBoxComment.Name = "richTextBoxComment";
		this.richTextBoxComment.Size = new System.Drawing.Size(233, 72);
		this.richTextBoxComment.TabIndex = 9;
		this.richTextBoxComment.Text = "";
		this.labelComment.AutoSize = true;
		this.labelComment.Location = new System.Drawing.Point(6, 172);
		this.labelComment.Name = "labelComment";
		this.labelComment.Size = new System.Drawing.Size(77, 13);
		this.labelComment.TabIndex = 8;
		this.labelComment.Text = "Комментарий";
		this.labelValue.AutoSize = true;
		this.labelValue.Location = new System.Drawing.Point(6, 94);
		this.labelValue.Name = "labelValue";
		this.labelValue.Size = new System.Drawing.Size(55, 13);
		this.labelValue.TabIndex = 4;
		this.labelValue.Text = "Значение";
		this.labelName.AutoSize = true;
		this.labelName.Location = new System.Drawing.Point(6, 16);
		this.labelName.Name = "labelName";
		this.labelName.Size = new System.Drawing.Size(83, 13);
		this.labelName.TabIndex = 0;
		this.labelName.Text = "Наименование";
		this.textBoxValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class48_0, "tR_Classifier.Value", true));
		this.textBoxValue.Location = new System.Drawing.Point(9, 110);
		this.textBoxValue.Name = "textBoxValue";
		this.textBoxValue.Size = new System.Drawing.Size(233, 20);
		this.textBoxValue.TabIndex = 5;
		this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class48_0, "tR_Classifier.Name", true));
		this.textBoxName.Location = new System.Drawing.Point(9, 32);
		this.textBoxName.Name = "textBoxName";
		this.textBoxName.Size = new System.Drawing.Size(233, 20);
		this.textBoxName.TabIndex = 1;
		this.buttonOK.Location = new System.Drawing.Point(12, 305);
		this.buttonOK.Name = "buttonOK";
		this.buttonOK.Size = new System.Drawing.Size(75, 23);
		this.buttonOK.TabIndex = 1;
		this.buttonOK.Text = "ОК";
		this.buttonOK.UseVisualStyleBackColor = true;
		this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(188, 305);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 2;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(275, 335);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonOK);
		base.Controls.Add(this.ljdOdiUpxb);
		base.Controls.Add(this.labelParent);
		base.Controls.Add(this.textBoxParent);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormAddUpdClassifier";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "FormAddUpdClassifier";
		base.Load += new System.EventHandler(this.FormAddUpdClassifier_Load);
		this.ljdOdiUpxb.ResumeLayout(false);
		this.ljdOdiUpxb.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.class48_0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private System.ComponentModel.IContainer icontainer_0;

	private System.Windows.Forms.TextBox textBoxParent;

	private System.Windows.Forms.Label labelParent;

	private System.Windows.Forms.GroupBox ljdOdiUpxb;

	private System.Windows.Forms.Label labelValue;

	private System.Windows.Forms.Label labelName;

	private System.Windows.Forms.TextBox textBoxValue;

	private System.Windows.Forms.TextBox textBoxName;

	private System.Windows.Forms.RichTextBox richTextBoxComment;

	private System.Windows.Forms.Label labelComment;

	private System.Windows.Forms.Button buttonOK;

	private System.Windows.Forms.Button buttonCancel;

	private Class48 class48_0;

	private System.Data.DataTable dataTable_0;

	private System.Data.DataColumn dataColumn_0;

	private System.Data.DataColumn dataColumn_1;

	private System.Data.DataColumn dataColumn_2;

	private System.Data.DataColumn dataColumn_3;

	private System.Data.DataColumn dataColumn_4;

	private System.Data.DataColumn dataColumn_5;

	private System.Data.DataColumn dataColumn_6;

	private System.Data.DataColumn dataColumn_7;

	private System.Windows.Forms.Label labelParentKey;

	private System.Windows.Forms.TextBox textBoxParentKey;

	private System.Windows.Forms.Label labelSocrName;

	private System.Windows.Forms.TextBox textBoxSocrName;
}
