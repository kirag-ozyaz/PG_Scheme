namespace ReferenceWorker
{
	public partial class FormDivisionsAddEdit : FormLbr.FormBase
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cbGroup = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataSetWorker = new DataSetWorker();
			((System.ComponentModel.ISupportInitialize)this.dataSetWorker).BeginInit();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Наименование";
			this.txtName.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetWorker, "tR_Division.Description", true));
			this.txtName.Location = new System.Drawing.Point(12, 74);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(224, 20);
			this.txtName.TabIndex = 3;
			this.btnOK.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(80, 107);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "ОК";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			this.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(161, 107);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.cbGroup.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.cbGroup.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetWorker, "tR_Division.ParentID", true));
			this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(12, 34);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(224, 21);
			this.cbGroup.TabIndex = 8;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Группа";
			this.dataSetWorker.DataSetName = "DataSetReference";
			this.dataSetWorker.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			base.AcceptButton = this.btnOK;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(248, 138);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.cbGroup);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.txtName);
			base.Controls.Add(this.label2);
			base.Name = "FormDivisionsAddEdit";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormDivisionsAddEdit";
			base.Load += new System.EventHandler(this.FormDivisionsAddEdit_Load);
			((System.ComponentModel.ISupportInitialize)this.dataSetWorker).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.TextBox txtName;

		private System.Windows.Forms.Button btnOK;

		private System.Windows.Forms.Button btnCancel;

		private DataSetWorker dataSetWorker;

		private System.Windows.Forms.ComboBox cbGroup;

		private System.Windows.Forms.Label label1;
	}
}
