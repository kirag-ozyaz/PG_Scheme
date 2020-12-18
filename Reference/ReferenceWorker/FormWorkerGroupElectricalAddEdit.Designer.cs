namespace Reference.Forms
{
	public partial class FormWorkerGroupElectricalAddEdit : global::FormLbr.FormBase
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
			this.class48_0 = new global::Class48();
			this.buttonOk = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.comboBoxGroup = new global::System.Windows.Forms.ComboBox();
			this.dateTimePickerBegin = new global::ControlsLbr.NullableDateTimePicker();
			this.dateTimePickerEnd = new global::ControlsLbr.NullableDateTimePicker();
			((global::System.ComponentModel.ISupportInitialize)this.class48_0).BeginInit();
			base.SuspendLayout();
			this.labelFIO.AutoSize = true;
			this.labelFIO.Location = new global::System.Drawing.Point(12, 9);
			this.labelFIO.Name = "labelFIO";
			this.labelFIO.Size = new global::System.Drawing.Size(95, 13);
			this.labelFIO.TabIndex = 6;
			this.labelFIO.Text = "ФИО сотрудника";
			this.textBox_0.BackColor = global::System.Drawing.SystemColors.Window;
			this.textBox_0.Location = new global::System.Drawing.Point(15, 25);
			this.textBox_0.Name = "textBoxFIO";
			this.textBox_0.ReadOnly = true;
			this.textBox_0.Size = new global::System.Drawing.Size(271, 20);
			this.textBox_0.TabIndex = 7;
			this.class48_0.DataSetName = "DataSetWorkers";
			this.class48_0.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.buttonOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new global::System.Drawing.Point(15, 143);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "ОК";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(211, 143);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 60);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(71, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Дата начала";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(157, 60);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(89, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Дата окончания";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(68, 113);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(86, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Группа допуска";
			this.comboBoxGroup.FormattingEnabled = true;
			this.comboBoxGroup.Items.AddRange(new object[]
			{
				"I",
				"II",
				"III",
				"IV",
				"V"
			});
			this.comboBoxGroup.Location = new global::System.Drawing.Point(160, 110);
			this.comboBoxGroup.Name = "comboBoxGroup";
			this.comboBoxGroup.Size = new global::System.Drawing.Size(58, 21);
			this.comboBoxGroup.TabIndex = 13;
			this.dateTimePickerBegin.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.class48_0, "tJ_GroupElectricalWorker.DateBegin", true));
			this.dateTimePickerBegin.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerBegin.Location = new global::System.Drawing.Point(15, 76);
			this.dateTimePickerBegin.Name = "dateTimePickerBegin";
			this.dateTimePickerBegin.Size = new global::System.Drawing.Size(139, 20);
			this.dateTimePickerBegin.TabIndex = 14;
			this.dateTimePickerBegin.Value = new global::System.DateTime(2012, 6, 1, 12, 21, 26, 166);
			this.dateTimePickerBegin.ValueChanged += new global::System.EventHandler(this.dateTimePickerBegin_ValueChanged);
			this.dateTimePickerEnd.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.class48_0, "tJ_GroupElectricalWorker.DateEnd", true));
			this.dateTimePickerEnd.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerEnd.Location = new global::System.Drawing.Point(160, 76);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new global::System.Drawing.Size(126, 20);
			this.dateTimePickerEnd.TabIndex = 15;
			this.dateTimePickerEnd.Value = new global::System.DateTime(2012, 6, 1, 12, 21, 28, 234);
			base.AcceptButton = this.buttonOk;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(302, 179);
			base.Controls.Add(this.dateTimePickerEnd);
			base.Controls.Add(this.dateTimePickerBegin);
			base.Controls.Add(this.comboBoxGroup);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.labelFIO);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormWorkerGroupElectricalAddEdit";
			this.Text = "FormWorkerContactAddEdit";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FormWorkerGroupElectricalAddEdit_FormClosing);
			base.Load += new global::System.EventHandler(this.FormWorkerGroupElectricalAddEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.class48_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.Label labelFIO;

		private global::System.Windows.Forms.TextBox textBox_0;

		private global::System.Windows.Forms.Button buttonOk;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::Class48 class48_0;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.ComboBox comboBoxGroup;

		private global::ControlsLbr.NullableDateTimePicker dateTimePickerBegin;

		private global::ControlsLbr.NullableDateTimePicker dateTimePickerEnd;
	}
}
