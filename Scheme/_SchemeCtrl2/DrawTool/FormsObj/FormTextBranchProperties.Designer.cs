namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class FormTextBranchProperties : global::System.Windows.Forms.Form
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
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox = new global::System.Windows.Forms.TextBox();
			this.checkBoxDirect = new global::System.Windows.Forms.CheckBox();
			this.groupBox = new global::System.Windows.Forms.GroupBox();
			this.radioButtonB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonT = new global::System.Windows.Forms.RadioButton();
			this.groupBoxPoints = new global::System.Windows.Forms.GroupBox();
			this.radioButtonPassport = new global::System.Windows.Forms.RadioButton();
			this.radioButtonText = new global::System.Windows.Forms.RadioButton();
			this.groupBoxStyle = new global::System.Windows.Forms.GroupBox();
			this.checkBoxSettingDB = new global::System.Windows.Forms.CheckBox();
			this.labelColor = new global::System.Windows.Forms.Label();
			this.buttonFont = new global::System.Windows.Forms.Button();
			this.panelColor = new global::System.Windows.Forms.Panel();
			this.groupBox.SuspendLayout();
			this.groupBoxPoints.SuspendLayout();
			this.groupBoxStyle.SuspendLayout();
			base.SuspendLayout();
			this.buttonOK.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(15, 199);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(345, 199);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 4);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(37, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Текст";
			this.textBox.Location = new global::System.Drawing.Point(15, 20);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.Size = new global::System.Drawing.Size(279, 72);
			this.textBox.TabIndex = 3;
			this.textBox.TextChanged += new global::System.EventHandler(this.textBox_TextChanged);
			this.textBox.Enter += new global::System.EventHandler(this.textBox_Enter);
			this.textBox.Leave += new global::System.EventHandler(this.textBox_Leave);
			this.checkBoxDirect.AutoSize = true;
			this.checkBoxDirect.Location = new global::System.Drawing.Point(6, 19);
			this.checkBoxDirect.Name = "checkBoxDirect";
			this.checkBoxDirect.Size = new global::System.Drawing.Size(135, 17);
			this.checkBoxDirect.TabIndex = 4;
			this.checkBoxDirect.Text = "Прямое направление";
			this.checkBoxDirect.UseVisualStyleBackColor = true;
			this.groupBox.Controls.Add(this.radioButtonB);
			this.groupBox.Controls.Add(this.radioButtonT);
			this.groupBox.Controls.Add(this.checkBoxDirect);
			this.groupBox.Location = new global::System.Drawing.Point(15, 98);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new global::System.Drawing.Size(135, 95);
			this.groupBox.TabIndex = 5;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "Расположение";
			this.radioButtonB.AutoSize = true;
			this.radioButtonB.Location = new global::System.Drawing.Point(6, 66);
			this.radioButtonB.Name = "radioButtonB";
			this.radioButtonB.Size = new global::System.Drawing.Size(43, 17);
			this.radioButtonB.TabIndex = 1;
			this.radioButtonB.Text = "под";
			this.radioButtonB.UseVisualStyleBackColor = true;
			this.radioButtonT.AutoSize = true;
			this.radioButtonT.Checked = true;
			this.radioButtonT.Location = new global::System.Drawing.Point(6, 43);
			this.radioButtonT.Name = "radioButtonT";
			this.radioButtonT.Size = new global::System.Drawing.Size(43, 17);
			this.radioButtonT.TabIndex = 0;
			this.radioButtonT.TabStop = true;
			this.radioButtonT.Text = "над";
			this.radioButtonT.UseVisualStyleBackColor = true;
			this.groupBoxPoints.Controls.Add(this.radioButtonPassport);
			this.groupBoxPoints.Controls.Add(this.radioButtonText);
			this.groupBoxPoints.Location = new global::System.Drawing.Point(156, 98);
			this.groupBoxPoints.Name = "groupBoxPoints";
			this.groupBoxPoints.Size = new global::System.Drawing.Size(138, 95);
			this.groupBoxPoints.TabIndex = 6;
			this.groupBoxPoints.TabStop = false;
			this.groupBoxPoints.Text = "Информация";
			this.radioButtonPassport.AutoSize = true;
			this.radioButtonPassport.Location = new global::System.Drawing.Point(6, 42);
			this.radioButtonPassport.Name = "radioButtonPassport";
			this.radioButtonPassport.Size = new global::System.Drawing.Size(94, 43);
			this.radioButtonPassport.TabIndex = 0;
			this.radioButtonPassport.TabStop = true;
			this.radioButtonPassport.Text = "Отображать \r\nинформацию \r\nиз паспорта";
			this.radioButtonPassport.UseVisualStyleBackColor = true;
			this.radioButtonPassport.CheckedChanged += new global::System.EventHandler(this.radioButtonPassport_CheckedChanged);
			this.radioButtonText.AutoSize = true;
			this.radioButtonText.Location = new global::System.Drawing.Point(6, 19);
			this.radioButtonText.Name = "radioButtonText";
			this.radioButtonText.Size = new global::System.Drawing.Size(118, 17);
			this.radioButtonText.TabIndex = 0;
			this.radioButtonText.TabStop = true;
			this.radioButtonText.Text = "Отображать текст";
			this.radioButtonText.UseVisualStyleBackColor = true;
			this.radioButtonText.CheckedChanged += new global::System.EventHandler(this.radioButtonText_CheckedChanged);
			this.groupBoxStyle.Controls.Add(this.checkBoxSettingDB);
			this.groupBoxStyle.Controls.Add(this.labelColor);
			this.groupBoxStyle.Controls.Add(this.buttonFont);
			this.groupBoxStyle.Controls.Add(this.panelColor);
			this.groupBoxStyle.Location = new global::System.Drawing.Point(300, 12);
			this.groupBoxStyle.Name = "groupBoxStyle";
			this.groupBoxStyle.Size = new global::System.Drawing.Size(120, 181);
			this.groupBoxStyle.TabIndex = 7;
			this.groupBoxStyle.TabStop = false;
			this.groupBoxStyle.Text = "Стиль";
			this.checkBoxSettingDB.AutoSize = true;
			this.checkBoxSettingDB.Location = new global::System.Drawing.Point(6, 19);
			this.checkBoxSettingDB.Name = "checkBoxSettingDB";
			this.checkBoxSettingDB.Size = new global::System.Drawing.Size(110, 17);
			this.checkBoxSettingDB.TabIndex = 8;
			this.checkBoxSettingDB.Text = "Свойства схемы";
			this.checkBoxSettingDB.UseVisualStyleBackColor = true;
			this.checkBoxSettingDB.CheckedChanged += new global::System.EventHandler(this.checkBoxSettingDB_CheckedChanged);
			this.labelColor.AutoSize = true;
			this.labelColor.Location = new global::System.Drawing.Point(6, 39);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new global::System.Drawing.Size(77, 13);
			this.labelColor.TabIndex = 9;
			this.labelColor.Text = "Цвет объекта";
			this.buttonFont.Location = new global::System.Drawing.Point(9, 86);
			this.buttonFont.Name = "buttonFont";
			this.buttonFont.Size = new global::System.Drawing.Size(95, 23);
			this.buttonFont.TabIndex = 11;
			this.buttonFont.Text = "Шрифт";
			this.buttonFont.UseVisualStyleBackColor = true;
			this.buttonFont.Click += new global::System.EventHandler(this.buttonFont_Click);
			this.panelColor.Location = new global::System.Drawing.Point(9, 60);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new global::System.Drawing.Size(95, 20);
			this.panelColor.TabIndex = 10;
			this.panelColor.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDoubleClick);
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(424, 234);
			base.Controls.Add(this.groupBoxStyle);
			base.Controls.Add(this.groupBoxPoints);
			base.Controls.Add(this.groupBox);
			base.Controls.Add(this.textBox);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Name = "FormTextBranchProperties";
			this.Text = "Свойства текста";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FormTextBranchProperties_FormClosing);
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
			this.groupBoxPoints.ResumeLayout(false);
			this.groupBoxPoints.PerformLayout();
			this.groupBoxStyle.ResumeLayout(false);
			this.groupBoxStyle.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.Button buttonOK;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.TextBox textBox;

		private global::System.Windows.Forms.CheckBox checkBoxDirect;

		private global::System.Windows.Forms.GroupBox groupBox;

		private global::System.Windows.Forms.RadioButton radioButtonB;

		private global::System.Windows.Forms.RadioButton radioButtonT;

		private global::System.Windows.Forms.GroupBox groupBoxPoints;

		private global::System.Windows.Forms.RadioButton radioButtonPassport;

		private global::System.Windows.Forms.RadioButton radioButtonText;

		private global::System.Windows.Forms.GroupBox groupBoxStyle;

		private global::System.Windows.Forms.CheckBox checkBoxSettingDB;

		private global::System.Windows.Forms.Label labelColor;

		private global::System.Windows.Forms.Button buttonFont;

		private global::System.Windows.Forms.Panel panelColor;
	}
}
