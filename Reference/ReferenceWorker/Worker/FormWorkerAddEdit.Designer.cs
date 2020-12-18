namespace ReferenceWorker
{
	public partial class FormWorkerAddEdit : FormLbr.FormBase
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
            this.components = new System.ComponentModel.Container();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxFamily = new System.Windows.Forms.TextBox();
            this.dsWorker = new ReferenceWorker.DataSetWorker();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDivision = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDateBirth = new System.Windows.Forms.DateTimePicker();
            this.buttonOrganization = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrganization = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbJobTitle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ndtpDateEnd = new ControlsLbr.NullableDateTimePicker();
            this.dtpDateBegin = new System.Windows.Forms.DateTimePicker();
            this.toolTip_0 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(12, 90);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(56, 13);
            this.labelFIO.TabIndex = 6;
            this.labelFIO.Text = "Фамилия";
            // 
            // textBoxFamily
            // 
            this.textBoxFamily.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFamily.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsWorker, "tR_Worker.F", true));
            this.textBoxFamily.Location = new System.Drawing.Point(15, 106);
            this.textBoxFamily.Name = "textBoxFamily";
            this.textBoxFamily.Size = new System.Drawing.Size(100, 20);
            this.textBoxFamily.TabIndex = 7;
            // 
            // dsWorker
            // 
            this.dsWorker.DataSetName = "DataSetWorkers";
            this.dsWorker.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(12, 318);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(252, 318);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsWorker, "tR_Worker.I", true));
            this.textBoxFirstName.Location = new System.Drawing.Point(121, 106);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsWorker, "tR_Worker.O", true));
            this.textBoxSecondName.Location = new System.Drawing.Point(227, 106);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Отчество";
            // 
            // comboBoxDivision
            // 
            this.comboBoxDivision.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsWorker, "tR_Worker.DivisionCurrent", true));
            this.comboBoxDivision.DataSource = this.dsWorker;
            this.comboBoxDivision.DisplayMember = "tR_Division.Description";
            this.comboBoxDivision.FormattingEnabled = true;
            this.comboBoxDivision.Location = new System.Drawing.Point(15, 25);
            this.comboBoxDivision.Name = "comboBoxDivision";
            this.comboBoxDivision.Size = new System.Drawing.Size(312, 21);
            this.comboBoxDivision.TabIndex = 12;
            this.comboBoxDivision.ValueMember = "tR_Division.id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Подразделение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата рождения";
            // 
            // dateTimePickerDateBirth
            // 
            this.dateTimePickerDateBirth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsWorker, "tR_Worker.Birthday", true));
            this.dateTimePickerDateBirth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsWorker, "tR_Worker.Birthday", true));
            this.dateTimePickerDateBirth.Location = new System.Drawing.Point(15, 155);
            this.dateTimePickerDateBirth.Name = "dateTimePickerDateBirth";
            this.dateTimePickerDateBirth.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerDateBirth.TabIndex = 15;
            // 
            // buttonOrganization
            // 
            this.buttonOrganization.Location = new System.Drawing.Point(237, 202);
            this.buttonOrganization.Name = "buttonOrganization";
            this.buttonOrganization.Size = new System.Drawing.Size(90, 23);
            this.buttonOrganization.TabIndex = 16;
            this.buttonOrganization.Text = "Выбрать";
            this.buttonOrganization.UseVisualStyleBackColor = true;
            this.buttonOrganization.Click += new System.EventHandler(this.buttonOrganization_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Организация";
            // 
            // txtOrganization
            // 
            this.txtOrganization.Location = new System.Drawing.Point(15, 204);
            this.txtOrganization.Name = "txtOrganization";
            this.txtOrganization.ReadOnly = true;
            this.txtOrganization.Size = new System.Drawing.Size(216, 20);
            this.txtOrganization.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Должность";
            // 
            // cbJobTitle
            // 
            this.cbJobTitle.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsWorker, "tR_Worker.JobTitle", true));
            this.cbJobTitle.FormattingEnabled = true;
            this.cbJobTitle.Location = new System.Drawing.Point(15, 65);
            this.cbJobTitle.Name = "cbJobTitle";
            this.cbJobTitle.Size = new System.Drawing.Size(312, 21);
            this.cbJobTitle.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Принят";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Уволен";
            // 
            // ndtpDateEnd
            // 
            this.ndtpDateEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsWorker, "tR_Worker.DateEnd", true));
            this.ndtpDateEnd.Location = new System.Drawing.Point(15, 282);
            this.ndtpDateEnd.Name = "ndtpDateEnd";
            this.ndtpDateEnd.Size = new System.Drawing.Size(206, 20);
            this.ndtpDateEnd.TabIndex = 23;
            this.ndtpDateEnd.Value = new System.DateTime(2016, 4, 27, 9, 21, 44, 766);
            // 
            // dtpDateBegin
            // 
            this.dtpDateBegin.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsWorker, "tR_Worker.DateBegin", true));
            this.dtpDateBegin.Location = new System.Drawing.Point(15, 243);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.Size = new System.Drawing.Size(206, 20);
            this.dtpDateBegin.TabIndex = 24;
            // 
            // toolTip_0
            // 
            this.toolTip_0.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_0.ToolTipTitle = "Дата увольнения";
            // 
            // FormWorkerAddEdit
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(339, 351);
            this.Controls.Add(this.dtpDateBegin);
            this.Controls.Add(this.ndtpDateEnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbJobTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrganization);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonOrganization);
            this.Controls.Add(this.dateTimePickerDateBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDivision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxFamily);
            this.Controls.Add(this.labelFIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWorkerAddEdit";
            this.Text = "FormWorkerContactAddEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWorkerAddEdit_FormClosing);
            this.Load += new System.EventHandler(this.FormWorkerAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.ComponentModel.IContainer components;

		private System.Windows.Forms.Label labelFIO;

		private System.Windows.Forms.TextBox textBoxFamily;

		private System.Windows.Forms.Button buttonOk;

		private System.Windows.Forms.Button buttonCancel;

		private ReferenceWorker.DataSetWorker dsWorker;

		private System.Windows.Forms.TextBox textBoxFirstName;

		private System.Windows.Forms.TextBox textBoxSecondName;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.ComboBox comboBoxDivision;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Label label4;

		private System.Windows.Forms.DateTimePicker dateTimePickerDateBirth;

		private System.Windows.Forms.Button buttonOrganization;

		private System.Windows.Forms.Label label5;

		private System.Windows.Forms.TextBox txtOrganization;

		private System.Windows.Forms.Label label6;

		private System.Windows.Forms.ComboBox cbJobTitle;

		private System.Windows.Forms.Label label7;

		private System.Windows.Forms.Label label8;

		private ControlsLbr.NullableDateTimePicker ndtpDateEnd;

		private System.Windows.Forms.DateTimePicker dtpDateBegin;

		private System.Windows.Forms.ToolTip toolTip_0;
	}
}
