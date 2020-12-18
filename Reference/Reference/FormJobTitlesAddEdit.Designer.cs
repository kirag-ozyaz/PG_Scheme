internal partial class FormJobTitlesAddEdit : FormLbr.FormBase
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.ehwyzhWwsI != null)
		{
			this.ehwyzhWwsI.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.txtName = new System.Windows.Forms.TextBox();
		this.txtRating = new System.Windows.Forms.TextBox();
		this.numUpDownRate = new System.Windows.Forms.NumericUpDown();
		this.btnOK = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.class48_0 = new Class48();
		((System.ComponentModel.ISupportInitialize)this.numUpDownRate).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.class48_0).BeginInit();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(83, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Наименование";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(12, 48);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(31, 13);
		this.label2.TabIndex = 1;
		this.label2.Text = "Ранг";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(12, 87);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(44, 13);
		this.label3.TabIndex = 2;
		this.label3.Text = "Разряд";
		this.txtName.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
		this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class48_0, "tR_JobTitle.Description", true));
		this.txtName.Location = new System.Drawing.Point(12, 25);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(236, 20);
		this.txtName.TabIndex = 3;
		this.txtRating.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
		this.txtRating.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class48_0, "tR_JobTitle.RName", true));
		this.txtRating.Location = new System.Drawing.Point(12, 64);
		this.txtRating.Name = "txtRating";
		this.txtRating.Size = new System.Drawing.Size(236, 20);
		this.txtRating.TabIndex = 4;
		this.numUpDownRate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.class48_0, "tR_JobTitle.Razrjad", true));
		this.numUpDownRate.Location = new System.Drawing.Point(12, 103);
		this.numUpDownRate.Name = "numUpDownRate";
		this.numUpDownRate.Size = new System.Drawing.Size(91, 20);
		this.numUpDownRate.TabIndex = 5;
		this.btnOK.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
		this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.btnOK.Location = new System.Drawing.Point(92, 144);
		this.btnOK.Name = "btnOK";
		this.btnOK.Size = new System.Drawing.Size(75, 23);
		this.btnOK.TabIndex = 6;
		this.btnOK.Text = "ОК";
		this.btnOK.UseVisualStyleBackColor = true;
		this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
		this.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
		this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new System.Drawing.Point(173, 144);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Отмена";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
		this.class48_0.DataSetName = "DataSetWorkers";
		this.class48_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		base.AcceptButton = this.btnOK;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(260, 178);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnOK);
		base.Controls.Add(this.numUpDownRate);
		base.Controls.Add(this.txtRating);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Name = "FormJobTitlesAddEdit";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "FormJobTitlesAddEdit";
		base.Load += new System.EventHandler(this.FormJobTitlesAddEdit_Load);
		((System.ComponentModel.ISupportInitialize)this.numUpDownRate).EndInit();
		((System.ComponentModel.ISupportInitialize)this.class48_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private System.ComponentModel.IContainer ehwyzhWwsI;

	private System.Windows.Forms.Label label1;

	private System.Windows.Forms.Label label2;

	private System.Windows.Forms.Label label3;

	private System.Windows.Forms.TextBox txtName;

	private System.Windows.Forms.TextBox txtRating;

	private System.Windows.Forms.NumericUpDown numUpDownRate;

	private System.Windows.Forms.Button btnOK;

	private System.Windows.Forms.Button btnCancel;

	private Class48 class48_0;
}
