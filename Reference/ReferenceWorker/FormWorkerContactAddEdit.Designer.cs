namespace Reference.Forms
{
	public partial class FormWorkerContactAddEdit : global::FormLbr.FormBase
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
			this.labelFIO = new global::System.Windows.Forms.Label();
			this.textBox_0 = new global::System.Windows.Forms.TextBox();
			this.labelTypeContact = new global::System.Windows.Forms.Label();
			this.comboBoxType = new global::System.Windows.Forms.ComboBox();
			this.labelContact = new global::System.Windows.Forms.Label();
			this.textBoxContact = new global::System.Windows.Forms.TextBox();
			this.buttonOk = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.class48_0 = new global::Class48();
			((global::System.ComponentModel.ISupportInitialize)this.class48_0).BeginInit();
			base.SuspendLayout();
			this.labelFIO.AutoSize = true;
			this.labelFIO.Location = new global::System.Drawing.Point(12, 9);
			this.labelFIO.Name = "labelFIO";
			this.labelFIO.Size = new global::System.Drawing.Size(34, 13);
			this.labelFIO.TabIndex = 6;
			this.labelFIO.Text = "ФИО";
			this.textBox_0.BackColor = global::System.Drawing.SystemColors.Window;
			this.textBox_0.Location = new global::System.Drawing.Point(15, 25);
			this.textBox_0.Name = "textBoxFIO";
			this.textBox_0.ReadOnly = true;
			this.textBox_0.Size = new global::System.Drawing.Size(185, 20);
			this.textBox_0.TabIndex = 7;
			this.labelTypeContact.AutoSize = true;
			this.labelTypeContact.Location = new global::System.Drawing.Point(12, 61);
			this.labelTypeContact.Name = "labelTypeContact";
			this.labelTypeContact.Size = new global::System.Drawing.Size(154, 13);
			this.labelTypeContact.TabIndex = 0;
			this.labelTypeContact.Text = "Тип контактной информации";
			this.comboBoxType.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBoxType.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxType.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedValue", this.class48_0, "tR_WorkerContact.Type", true));
			this.comboBoxType.DataSource = this.class48_0;
			this.comboBoxType.DisplayMember = "tR_Classifier.Name";
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Location = new global::System.Drawing.Point(15, 77);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new global::System.Drawing.Size(185, 21);
			this.comboBoxType.TabIndex = 1;
			this.comboBoxType.ValueMember = "tR_Classifier.Id";
			this.labelContact.AutoSize = true;
			this.labelContact.Location = new global::System.Drawing.Point(12, 118);
			this.labelContact.Name = "labelContact";
			this.labelContact.Size = new global::System.Drawing.Size(133, 13);
			this.labelContact.TabIndex = 2;
			this.labelContact.Text = "Контактная информация";
			this.textBoxContact.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.class48_0, "tR_WorkerContact.Description", true));
			this.textBoxContact.Location = new global::System.Drawing.Point(15, 134);
			this.textBoxContact.Name = "textBoxContact";
			this.textBoxContact.Size = new global::System.Drawing.Size(185, 20);
			this.textBoxContact.TabIndex = 3;
			this.buttonOk.Location = new global::System.Drawing.Point(15, 171);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "ОК";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new global::System.EventHandler(this.buttonOk_Click);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(125, 171);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.class48_0.DataSetName = "DataSetWorkers";
			this.class48_0.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(216, 206);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.textBoxContact);
			base.Controls.Add(this.labelContact);
			base.Controls.Add(this.comboBoxType);
			base.Controls.Add(this.labelTypeContact);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.labelFIO);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormWorkerContactAddEdit";
			this.Text = "FormWorkerContactAddEdit";
			base.Load += new global::System.EventHandler(this.FormWorkerContactAddEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.class48_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.Label labelFIO;

		private global::System.Windows.Forms.TextBox textBox_0;

		private global::System.Windows.Forms.Label labelTypeContact;

		private global::System.Windows.Forms.ComboBox comboBoxType;

		private global::System.Windows.Forms.Label labelContact;

		private global::System.Windows.Forms.TextBox textBoxContact;

		private global::System.Windows.Forms.Button buttonOk;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::Class48 class48_0;
	}
}
