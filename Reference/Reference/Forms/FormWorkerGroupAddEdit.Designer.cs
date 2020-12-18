namespace Reference.Forms
{
	public partial class FormWorkerGroupAddEdit : FormLbr.FormBase
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
			this.labelFIO = new System.Windows.Forms.Label();
			this.textBox_0 = new System.Windows.Forms.TextBox();
			this.labelTypeContact = new System.Windows.Forms.Label();
			this.comboBoxGroupWorker = new System.Windows.Forms.ComboBox();
			this.class48_0 = new Class48();
			this.ynbludKlFn = new System.Windows.Forms.Button();
			this.qtllrSpfIk = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.class48_0).BeginInit();
			base.SuspendLayout();
			this.labelFIO.AutoSize = true;
			this.labelFIO.Location = new System.Drawing.Point(12, 9);
			this.labelFIO.Name = "labelFIO";
			this.labelFIO.Size = new System.Drawing.Size(34, 13);
			this.labelFIO.TabIndex = 6;
			this.labelFIO.Text = "ФИО";
			this.textBox_0.BackColor = System.Drawing.SystemColors.Window;
			this.textBox_0.Location = new System.Drawing.Point(15, 25);
			this.textBox_0.Name = "textBoxFIO";
			this.textBox_0.ReadOnly = true;
			this.textBox_0.Size = new System.Drawing.Size(185, 20);
			this.textBox_0.TabIndex = 7;
			this.labelTypeContact.AutoSize = true;
			this.labelTypeContact.Location = new System.Drawing.Point(12, 61);
			this.labelTypeContact.Name = "labelTypeContact";
			this.labelTypeContact.Size = new System.Drawing.Size(98, 13);
			this.labelTypeContact.TabIndex = 0;
			this.labelTypeContact.Text = "Группа работника";
			this.comboBoxGroupWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBoxGroupWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxGroupWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.class48_0, "tL_ClassifierWorker.IdGroup", true));
			this.comboBoxGroupWorker.DataSource = this.class48_0;
			this.comboBoxGroupWorker.DisplayMember = "tR_Classifier.Name";
			this.comboBoxGroupWorker.FormattingEnabled = true;
			this.comboBoxGroupWorker.Location = new System.Drawing.Point(15, 77);
			this.comboBoxGroupWorker.Name = "comboBoxGroupWorker";
			this.comboBoxGroupWorker.Size = new System.Drawing.Size(185, 21);
			this.comboBoxGroupWorker.TabIndex = 1;
			this.comboBoxGroupWorker.ValueMember = "tR_Classifier.Id";
			this.comboBoxGroupWorker.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroupWorker_SelectedIndexChanged);
			this.class48_0.DataSetName = "DataSetWorkers";
			this.class48_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.ynbludKlFn.Location = new System.Drawing.Point(15, 114);
			this.ynbludKlFn.Name = "buttonOk";
			this.ynbludKlFn.Size = new System.Drawing.Size(75, 23);
			this.ynbludKlFn.TabIndex = 4;
			this.ynbludKlFn.Text = "ОК";
			this.ynbludKlFn.UseVisualStyleBackColor = true;
			this.ynbludKlFn.Click += new System.EventHandler(this.ynbludKlFn_Click);
			this.qtllrSpfIk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.qtllrSpfIk.Location = new System.Drawing.Point(125, 114);
			this.qtllrSpfIk.Name = "buttonCancel";
			this.qtllrSpfIk.Size = new System.Drawing.Size(75, 23);
			this.qtllrSpfIk.TabIndex = 5;
			this.qtllrSpfIk.Text = "Отмена";
			this.qtllrSpfIk.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.qtllrSpfIk;
			base.ClientSize = new System.Drawing.Size(216, 146);
			base.Controls.Add(this.qtllrSpfIk);
			base.Controls.Add(this.ynbludKlFn);
			base.Controls.Add(this.comboBoxGroupWorker);
			base.Controls.Add(this.labelTypeContact);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.labelFIO);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormWorkerGroupAddEdit";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormWorkerContactAddEdit";
			base.Load += new System.EventHandler(this.FormWorkerGroupAddEdit_Load);
			((System.ComponentModel.ISupportInitialize)this.class48_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.Label labelFIO;

		private System.Windows.Forms.TextBox textBox_0;

		private System.Windows.Forms.Label labelTypeContact;

		private System.Windows.Forms.ComboBox comboBoxGroupWorker;

		private System.Windows.Forms.Button ynbludKlFn;

		private System.Windows.Forms.Button qtllrSpfIk;

		private Class48 class48_0;
	}
}
