namespace ReferenceWorker
{
	public partial class FormWorkerGroupElectricalAddEdit : FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.labelFIO = new System.Windows.Forms.Label();
			this.textBoxFIO = new System.Windows.Forms.TextBox();
			this.dsWorker = new ReferenceWorker.DataSetWorker();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxGroup = new System.Windows.Forms.ComboBox();
			this.dateTimePickerBegin = new ControlsLbr.NullableDateTimePicker();
			this.dateTimePickerEnd = new ControlsLbr.NullableDateTimePicker();
			((System.ComponentModel.ISupportInitialize)this.dsWorker).BeginInit();
			base.SuspendLayout();
			this.labelFIO.AutoSize = true;
			this.labelFIO.Location = new System.Drawing.Point(12, 9);
			this.labelFIO.Name = "labelFIO";
			this.labelFIO.Size = new System.Drawing.Size(95, 13);
			this.labelFIO.TabIndex = 6;
			this.labelFIO.Text = "ФИО сотрудника";
			this.textBoxFIO.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxFIO.Location = new System.Drawing.Point(15, 25);
			this.textBoxFIO.Name = "textBoxFIO";
			this.textBoxFIO.ReadOnly = true;
			this.textBoxFIO.Size = new System.Drawing.Size(271, 20);
			this.textBoxFIO.TabIndex = 7;
			this.dsWorker.DataSetName = "DataSetWorkers";
			this.dsWorker.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(15, 143);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "ОК";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(211, 143);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Дата начала";
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(157, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Дата окончания";
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(68, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
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
			this.comboBoxGroup.Location = new System.Drawing.Point(160, 110);
			this.comboBoxGroup.Name = "comboBoxGroup";
			this.comboBoxGroup.Size = new System.Drawing.Size(58, 21);
			this.comboBoxGroup.TabIndex = 13;
			this.dateTimePickerBegin.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsWorker, "tJ_GroupElectricalWorker.DateBegin", true));
			this.dateTimePickerBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerBegin.Location = new System.Drawing.Point(15, 76);
			this.dateTimePickerBegin.Name = "dateTimePickerBegin";
			this.dateTimePickerBegin.Size = new System.Drawing.Size(139, 20);
			this.dateTimePickerBegin.TabIndex = 14;
			this.dateTimePickerBegin.Value = new System.DateTime(2012, 6, 1, 12, 21, 26, 166);
			this.dateTimePickerBegin.ValueChanged += new System.EventHandler(this.dateTimePickerBegin_ValueChanged);
			this.dateTimePickerEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsWorker, "tJ_GroupElectricalWorker.DateEnd", true));
			this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerEnd.Location = new System.Drawing.Point(160, 76);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(126, 20);
			this.dateTimePickerEnd.TabIndex = 15;
			this.dateTimePickerEnd.Value = new System.DateTime(2012, 6, 1, 12, 21, 28, 234);
			base.AcceptButton = this.buttonOk;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(302, 179);
			base.Controls.Add(this.dateTimePickerEnd);
			base.Controls.Add(this.dateTimePickerBegin);
			base.Controls.Add(this.comboBoxGroup);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.textBoxFIO);
			base.Controls.Add(this.labelFIO);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormWorkerGroupElectricalAddEdit";
			this.Text = "FormWorkerContactAddEdit";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWorkerGroupElectricalAddEdit_FormClosing);
			base.Load += new System.EventHandler(this.FormWorkerGroupElectricalAddEdit_Load);
			((System.ComponentModel.ISupportInitialize)this.dsWorker).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.Label labelFIO;

		private System.Windows.Forms.TextBox textBoxFIO;

		private System.Windows.Forms.Button buttonOk;

		private System.Windows.Forms.Button buttonCancel;

		private ReferenceWorker.DataSetWorker dsWorker;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.ComboBox comboBoxGroup;

		private ControlsLbr.NullableDateTimePicker dateTimePickerBegin;

		private ControlsLbr.NullableDateTimePicker dateTimePickerEnd;
	}
}
