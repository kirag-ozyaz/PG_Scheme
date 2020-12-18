namespace Reference.Forms
{
	public partial class FormWorkerAddEdit : global::FormLbr.FormBase
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
			this.icontainer_0 = new global::System.ComponentModel.Container();
			this.labelFIO = new global::System.Windows.Forms.Label();
			this.textBoxFamily = new global::System.Windows.Forms.TextBox();
			this.class48_0 = new global::Class48();
			this.buttonOk = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.textBoxFirstName = new global::System.Windows.Forms.TextBox();
			this.textBoxSecondName = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.comboBoxDivision = new global::System.Windows.Forms.ComboBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.dateTimePickerDateBirth = new global::System.Windows.Forms.DateTimePicker();
			this.buttonOrganization = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.txtOrganization = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.cbJobTitle = new global::System.Windows.Forms.ComboBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.ndtpDateEnd = new global::ControlsLbr.NullableDateTimePicker();
			this.dtpDateBegin = new global::System.Windows.Forms.DateTimePicker();
			this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.icontainer_0);
			((global::System.ComponentModel.ISupportInitialize)this.class48_0).BeginInit();
			base.SuspendLayout();
			this.labelFIO.AutoSize = true;
			this.labelFIO.Location = new global::System.Drawing.Point(12, 90);
			this.labelFIO.Name = "labelFIO";
			this.labelFIO.Size = new global::System.Drawing.Size(56, 13);
			this.labelFIO.TabIndex = 6;
			this.labelFIO.Text = "Фамилия";
			this.textBoxFamily.BackColor = global::System.Drawing.SystemColors.Window;
			this.textBoxFamily.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.class48_0, "tR_Worker.F", true));
			this.textBoxFamily.Location = new global::System.Drawing.Point(15, 106);
			this.textBoxFamily.Name = "textBoxFamily";
			this.textBoxFamily.Size = new global::System.Drawing.Size(100, 20);
			this.textBoxFamily.TabIndex = 7;
			this.class48_0.DataSetName = "DataSetWorkers";
			this.class48_0.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.buttonOk.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.buttonOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new global::System.Drawing.Point(12, 318);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "ОК";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(252, 318);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.textBoxFirstName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.class48_0, "tR_Worker.I", true));
			this.textBoxFirstName.Location = new global::System.Drawing.Point(121, 106);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new global::System.Drawing.Size(100, 20);
			this.textBoxFirstName.TabIndex = 8;
			this.textBoxSecondName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.class48_0, "tR_Worker.O", true));
			this.textBoxSecondName.Location = new global::System.Drawing.Point(227, 106);
			this.textBoxSecondName.Name = "textBoxSecondName";
			this.textBoxSecondName.Size = new global::System.Drawing.Size(100, 20);
			this.textBoxSecondName.TabIndex = 9;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(122, 90);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(29, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Имя";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(224, 90);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(54, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Отчество";
			this.comboBoxDivision.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedValue", this.class48_0, "tR_Worker.DivisionCurrent", true));
			this.comboBoxDivision.DataSource = this.class48_0;
			this.comboBoxDivision.DisplayMember = "tR_Division.Description";
			this.comboBoxDivision.FormattingEnabled = true;
			this.comboBoxDivision.Location = new global::System.Drawing.Point(15, 25);
			this.comboBoxDivision.Name = "comboBoxDivision";
			this.comboBoxDivision.Size = new global::System.Drawing.Size(312, 21);
			this.comboBoxDivision.TabIndex = 12;
			this.comboBoxDivision.ValueMember = "tR_Division.id";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(87, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Подразделение";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(12, 139);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(86, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Дата рождения";
			this.dateTimePickerDateBirth.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.class48_0, "tR_Worker.Birthday", true));
			this.dateTimePickerDateBirth.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.class48_0, "tR_Worker.Birthday", true));
			this.dateTimePickerDateBirth.Location = new global::System.Drawing.Point(15, 155);
			this.dateTimePickerDateBirth.Name = "dateTimePickerDateBirth";
			this.dateTimePickerDateBirth.Size = new global::System.Drawing.Size(206, 20);
			this.dateTimePickerDateBirth.TabIndex = 15;
			this.buttonOrganization.Location = new global::System.Drawing.Point(237, 202);
			this.buttonOrganization.Name = "buttonOrganization";
			this.buttonOrganization.Size = new global::System.Drawing.Size(90, 23);
			this.buttonOrganization.TabIndex = 16;
			this.buttonOrganization.Text = "Выбрать";
			this.buttonOrganization.UseVisualStyleBackColor = true;
			this.buttonOrganization.Click += new global::System.EventHandler(this.buttonOrganization_Click);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(12, 188);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(74, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Организации";
			this.txtOrganization.Location = new global::System.Drawing.Point(15, 204);
			this.txtOrganization.Name = "txtOrganization";
			this.txtOrganization.ReadOnly = true;
			this.txtOrganization.Size = new global::System.Drawing.Size(216, 20);
			this.txtOrganization.TabIndex = 18;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(12, 49);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(65, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Должность";
			this.cbJobTitle.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedValue", this.class48_0, "tR_Worker.JobTitle", true));
			this.cbJobTitle.FormattingEnabled = true;
			this.cbJobTitle.Location = new global::System.Drawing.Point(15, 65);
			this.cbJobTitle.Name = "cbJobTitle";
			this.cbJobTitle.Size = new global::System.Drawing.Size(312, 21);
			this.cbJobTitle.TabIndex = 20;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(12, 227);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(44, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "Принят";
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(12, 266);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(45, 13);
			this.label8.TabIndex = 22;
			this.label8.Text = "Уволен";
			this.ndtpDateEnd.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.class48_0, "tR_Worker.DateEnd", true));
			this.ndtpDateEnd.Location = new global::System.Drawing.Point(15, 282);
			this.ndtpDateEnd.Name = "ndtpDateEnd";
			this.ndtpDateEnd.Size = new global::System.Drawing.Size(206, 20);
			this.ndtpDateEnd.TabIndex = 23;
			this.ndtpDateEnd.Value = new global::System.DateTime(2016, 4, 27, 9, 21, 44, 766);
			this.dtpDateBegin.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.class48_0, "tR_Worker.DateBegin", true));
			this.dtpDateBegin.Location = new global::System.Drawing.Point(15, 243);
			this.dtpDateBegin.Name = "dtpDateBegin";
			this.dtpDateBegin.Size = new global::System.Drawing.Size(206, 20);
			this.dtpDateBegin.TabIndex = 24;
			this.toolTip_0.ToolTipIcon = global::System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip_0.ToolTipTitle = "Дата увольнения";
			base.AcceptButton = this.buttonOk;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(336, 351);
			base.Controls.Add(this.dtpDateBegin);
			base.Controls.Add(this.ndtpDateEnd);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.cbJobTitle);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.txtOrganization);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.buttonOrganization);
			base.Controls.Add(this.dateTimePickerDateBirth);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.comboBoxDivision);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBoxSecondName);
			base.Controls.Add(this.textBoxFirstName);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.textBoxFamily);
			base.Controls.Add(this.labelFIO);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormWorkerAddEdit";
			this.Text = "FormWorkerContactAddEdit";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.WeJwNunrSe);
			base.Load += new global::System.EventHandler(this.FormWorkerAddEdit_Load);
			((global::System.ComponentModel.ISupportInitialize)this.class48_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.Label labelFIO;

		private global::System.Windows.Forms.TextBox textBoxFamily;

		private global::System.Windows.Forms.Button buttonOk;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::Class48 class48_0;

		private global::System.Windows.Forms.TextBox textBoxFirstName;

		private global::System.Windows.Forms.TextBox textBoxSecondName;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.ComboBox comboBoxDivision;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.DateTimePicker dateTimePickerDateBirth;

		private global::System.Windows.Forms.Button buttonOrganization;

		private global::System.Windows.Forms.Label label5;

		private global::System.Windows.Forms.TextBox txtOrganization;

		private global::System.Windows.Forms.Label label6;

		private global::System.Windows.Forms.ComboBox cbJobTitle;

		private global::System.Windows.Forms.Label label7;

		private global::System.Windows.Forms.Label label8;

		private global::ControlsLbr.NullableDateTimePicker ndtpDateEnd;

		private global::System.Windows.Forms.DateTimePicker dtpDateBegin;

		private global::System.Windows.Forms.ToolTip toolTip_0;
	}
}
