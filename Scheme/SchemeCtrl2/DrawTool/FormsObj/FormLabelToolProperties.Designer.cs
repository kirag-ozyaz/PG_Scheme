namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class FormLabelToolProperties : global::System.Windows.Forms.Form
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
			this.labelText = new global::System.Windows.Forms.Label();
			this.textBoxTextLabel = new global::System.Windows.Forms.TextBox();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panelColor = new global::System.Windows.Forms.Panel();
			this.buttonFont = new global::System.Windows.Forms.Button();
			this.checkBoxUseSettingsCanvas = new global::System.Windows.Forms.CheckBox();
			this.fontDialog_0 = new global::System.Windows.Forms.FontDialog();
			this.colorDialog_0 = new global::System.Windows.Forms.ColorDialog();
			this.groupBoxTextDirect = new global::System.Windows.Forms.GroupBox();
			this.radioButtonVertical = new global::System.Windows.Forms.RadioButton();
			this.radioButtonGorizontal = new global::System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBoxTextDirect.SuspendLayout();
			base.SuspendLayout();
			this.labelText.AutoSize = true;
			this.labelText.Location = new global::System.Drawing.Point(12, 9);
			this.labelText.Name = "labelText";
			this.labelText.Size = new global::System.Drawing.Size(37, 13);
			this.labelText.TabIndex = 0;
			this.labelText.Text = "Текст";
			this.textBoxTextLabel.Location = new global::System.Drawing.Point(15, 25);
			this.textBoxTextLabel.Name = "textBoxTextLabel";
			this.textBoxTextLabel.Size = new global::System.Drawing.Size(293, 20);
			this.textBoxTextLabel.TabIndex = 1;
			this.buttonOK.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(15, 143);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(233, 143);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.panelColor);
			this.groupBox1.Controls.Add(this.buttonFont);
			this.groupBox1.Controls.Add(this.checkBoxUseSettingsCanvas);
			this.groupBox1.Location = new global::System.Drawing.Point(15, 51);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(148, 86);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 60);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(32, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Цвет";
			this.panelColor.Location = new global::System.Drawing.Point(44, 55);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new global::System.Drawing.Size(66, 23);
			this.panelColor.TabIndex = 2;
			this.panelColor.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDoubleClick);
			this.buttonFont.Location = new global::System.Drawing.Point(6, 23);
			this.buttonFont.Name = "buttonFont";
			this.buttonFont.Size = new global::System.Drawing.Size(110, 23);
			this.buttonFont.TabIndex = 1;
			this.buttonFont.Text = "Шрифт";
			this.buttonFont.UseVisualStyleBackColor = true;
			this.buttonFont.Click += new global::System.EventHandler(this.buttonFont_Click);
			this.checkBoxUseSettingsCanvas.AutoSize = true;
			this.checkBoxUseSettingsCanvas.Location = new global::System.Drawing.Point(6, 0);
			this.checkBoxUseSettingsCanvas.Name = "checkBoxUseSettingsCanvas";
			this.checkBoxUseSettingsCanvas.Size = new global::System.Drawing.Size(110, 17);
			this.checkBoxUseSettingsCanvas.TabIndex = 0;
			this.checkBoxUseSettingsCanvas.Text = "Свойства схемы";
			this.checkBoxUseSettingsCanvas.UseVisualStyleBackColor = true;
			this.checkBoxUseSettingsCanvas.CheckedChanged += new global::System.EventHandler(this.checkBoxUseSettingsCanvas_CheckedChanged);
			this.groupBoxTextDirect.AutoSize = true;
			this.groupBoxTextDirect.Controls.Add(this.radioButtonVertical);
			this.groupBoxTextDirect.Controls.Add(this.radioButtonGorizontal);
			this.groupBoxTextDirect.Location = new global::System.Drawing.Point(169, 50);
			this.groupBoxTextDirect.Name = "groupBoxTextDirect";
			this.groupBoxTextDirect.Size = new global::System.Drawing.Size(139, 87);
			this.groupBoxTextDirect.TabIndex = 9;
			this.groupBoxTextDirect.TabStop = false;
			this.groupBoxTextDirect.Text = "Направление текста";
			this.radioButtonVertical.AutoSize = true;
			this.radioButtonVertical.Location = new global::System.Drawing.Point(7, 41);
			this.radioButtonVertical.Name = "radioButtonVertical";
			this.radioButtonVertical.Size = new global::System.Drawing.Size(91, 17);
			this.radioButtonVertical.TabIndex = 1;
			this.radioButtonVertical.Text = "Вертикально";
			this.radioButtonVertical.UseVisualStyleBackColor = true;
			this.radioButtonGorizontal.AutoSize = true;
			this.radioButtonGorizontal.Checked = true;
			this.radioButtonGorizontal.Location = new global::System.Drawing.Point(7, 18);
			this.radioButtonGorizontal.Name = "radioButtonGorizontal";
			this.radioButtonGorizontal.Size = new global::System.Drawing.Size(102, 17);
			this.radioButtonGorizontal.TabIndex = 0;
			this.radioButtonGorizontal.TabStop = true;
			this.radioButtonGorizontal.Text = "Горизонтально";
			this.radioButtonGorizontal.UseVisualStyleBackColor = true;
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(320, 176);
			base.Controls.Add(this.groupBoxTextDirect);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.textBoxTextLabel);
			base.Controls.Add(this.labelText);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "FormLabelToolProperties";
			this.Text = "Свойства надписи";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FormLabelToolProperties_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBoxTextDirect.ResumeLayout(false);
			this.groupBoxTextDirect.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.Label labelText;

		private global::System.Windows.Forms.TextBox textBoxTextLabel;

		private global::System.Windows.Forms.Button buttonOK;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.CheckBox checkBoxUseSettingsCanvas;

		private global::System.Windows.Forms.Button buttonFont;

		private global::System.Windows.Forms.FontDialog fontDialog_0;

		private global::System.Windows.Forms.Panel panelColor;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.ColorDialog colorDialog_0;

		private global::System.Windows.Forms.GroupBox groupBoxTextDirect;

		private global::System.Windows.Forms.RadioButton radioButtonVertical;

		private global::System.Windows.Forms.RadioButton radioButtonGorizontal;
	}
}
