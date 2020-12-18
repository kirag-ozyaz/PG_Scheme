namespace Reference.Forms
{
	public partial class FormCounterAddEdit : FormLbr.FormBase
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
			this.labelName = new System.Windows.Forms.Label();
			this.labelDigit = new System.Windows.Forms.Label();
			this.numericUpDownDigit = new System.Windows.Forms.NumericUpDown();
			this.class37_0 = new Class37();
			this.labelPhaze = new System.Windows.Forms.Label();
			this.numericUpDownPhaze = new System.Windows.Forms.NumericUpDown();
			this.labelVoltage = new System.Windows.Forms.Label();
			this.comboBoxVoltage = new System.Windows.Forms.ComboBox();
			this.numericUpDownPrecision = new System.Windows.Forms.NumericUpDown();
			this.labelPrecision = new System.Windows.Forms.Label();
			this.labelInterval = new System.Windows.Forms.Label();
			this.labelTarif = new System.Windows.Forms.Label();
			this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownTarif = new System.Windows.Forms.NumericUpDown();
			this.labelComment = new System.Windows.Forms.Label();
			this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
			this.labelPicture = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.openFileDialog_0 = new System.Windows.Forms.OpenFileDialog();
			this.textBoxName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownDigit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownPhaze).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownPrecision).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownInterval).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownTarif).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox).BeginInit();
			base.SuspendLayout();
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(12, 9);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(83, 13);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Наименование";
			this.labelDigit.AutoSize = true;
			this.labelDigit.Location = new System.Drawing.Point(12, 60);
			this.labelDigit.Name = "labelDigit";
			this.labelDigit.Size = new System.Drawing.Size(73, 13);
			this.labelDigit.TabIndex = 2;
			this.labelDigit.Text = "Разрядность";
			this.numericUpDownDigit.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.class37_0, "tR_MarkMeter.Digit", true));
			this.numericUpDownDigit.Location = new System.Drawing.Point(15, 76);
			this.numericUpDownDigit.Name = "numericUpDownDigit";
			this.numericUpDownDigit.Size = new System.Drawing.Size(85, 20);
			this.numericUpDownDigit.TabIndex = 3;
			System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDownDigit;
			int[] array = new int[4];
			array[0] = 5;
			numericUpDown.Value = new decimal(array);
			this.class37_0.DataSetName = "DataSetMeters";
			this.class37_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.labelPhaze.AutoSize = true;
			this.labelPhaze.Location = new System.Drawing.Point(118, 60);
			this.labelPhaze.Name = "labelPhaze";
			this.labelPhaze.Size = new System.Drawing.Size(36, 13);
			this.labelPhaze.TabIndex = 4;
			this.labelPhaze.Text = "Фаза";
			this.numericUpDownPhaze.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.class37_0, "tR_MarkMeter.Phaze", true));
			this.numericUpDownPhaze.Location = new System.Drawing.Point(119, 75);
			this.numericUpDownPhaze.Name = "numericUpDownPhaze";
			this.numericUpDownPhaze.Size = new System.Drawing.Size(77, 20);
			this.numericUpDownPhaze.TabIndex = 5;
			System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDownPhaze;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Value = new decimal(array2);
			this.labelVoltage.AutoSize = true;
			this.labelVoltage.Location = new System.Drawing.Point(210, 59);
			this.labelVoltage.Name = "labelVoltage";
			this.labelVoltage.Size = new System.Drawing.Size(142, 13);
			this.labelVoltage.TabIndex = 6;
			this.labelVoltage.Text = "Номинальное напряжение";
			this.comboBoxVoltage.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.class37_0, "tR_MarkMeter.Voltage", true));
			this.comboBoxVoltage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class37_0, "tR_MarkMeter.Voltage", true));
			this.comboBoxVoltage.FormattingEnabled = true;
			this.comboBoxVoltage.Items.AddRange(new object[]
			{
				"220",
				"380"
			});
			this.comboBoxVoltage.Location = new System.Drawing.Point(213, 75);
			this.comboBoxVoltage.Name = "comboBoxVoltage";
			this.comboBoxVoltage.Size = new System.Drawing.Size(139, 21);
			this.comboBoxVoltage.TabIndex = 7;
			this.numericUpDownPrecision.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.class37_0, "tR_MarkMeter.Precision", true));
			this.numericUpDownPrecision.DecimalPlaces = 1;
			this.numericUpDownPrecision.Increment = new decimal(new int[]
			{
				5,
				0,
				0,
				65536
			});
			this.numericUpDownPrecision.Location = new System.Drawing.Point(176, 128);
			this.numericUpDownPrecision.Name = "numericUpDownPrecision";
			this.numericUpDownPrecision.Size = new System.Drawing.Size(77, 20);
			this.numericUpDownPrecision.TabIndex = 11;
			this.labelPrecision.AutoSize = true;
			this.labelPrecision.Location = new System.Drawing.Point(173, 112);
			this.labelPrecision.Name = "labelPrecision";
			this.labelPrecision.Size = new System.Drawing.Size(54, 13);
			this.labelPrecision.TabIndex = 10;
			this.labelPrecision.Text = "Точность";
			this.labelInterval.AutoSize = true;
			this.labelInterval.Location = new System.Drawing.Point(13, 112);
			this.labelInterval.Name = "labelInterval";
			this.labelInterval.Size = new System.Drawing.Size(104, 13);
			this.labelInterval.TabIndex = 8;
			this.labelInterval.Text = "Межпров интервал";
			this.labelTarif.AutoSize = true;
			this.labelTarif.Location = new System.Drawing.Point(267, 112);
			this.labelTarif.Name = "labelTarif";
			this.labelTarif.Size = new System.Drawing.Size(85, 13);
			this.labelTarif.TabIndex = 12;
			this.labelTarif.Text = "Число тарифов";
			this.numericUpDownInterval.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.class37_0, "tR_MarkMeter.Interval", true));
			this.numericUpDownInterval.Location = new System.Drawing.Point(15, 128);
			this.numericUpDownInterval.Name = "numericUpDownInterval";
			this.numericUpDownInterval.Size = new System.Drawing.Size(139, 20);
			this.numericUpDownInterval.TabIndex = 9;
			System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDownInterval;
			int[] array3 = new int[4];
			array3[0] = 16;
			numericUpDown3.Value = new decimal(array3);
			this.numericUpDownTarif.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.class37_0, "tR_MarkMeter.TarifCount", true));
			this.numericUpDownTarif.Location = new System.Drawing.Point(270, 128);
			this.numericUpDownTarif.Name = "numericUpDownTarif";
			this.numericUpDownTarif.Size = new System.Drawing.Size(82, 20);
			this.numericUpDownTarif.TabIndex = 13;
			System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDownTarif;
			int[] array4 = new int[4];
			array4[0] = 1;
			numericUpDown4.Value = new decimal(array4);
			this.labelComment.AutoSize = true;
			this.labelComment.Location = new System.Drawing.Point(13, 160);
			this.labelComment.Name = "labelComment";
			this.labelComment.Size = new System.Drawing.Size(77, 13);
			this.labelComment.TabIndex = 14;
			this.labelComment.Text = "Комментарии";
			this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class37_0, "tR_MarkMeter.Comment", true));
			this.richTextBoxComment.Location = new System.Drawing.Point(16, 176);
			this.richTextBoxComment.Name = "richTextBoxComment";
			this.richTextBoxComment.Size = new System.Drawing.Size(154, 50);
			this.richTextBoxComment.TabIndex = 15;
			this.richTextBoxComment.Text = "";
			this.labelPicture.AutoSize = true;
			this.labelPicture.Location = new System.Drawing.Point(173, 160);
			this.labelPicture.Name = "labelPicture";
			this.labelPicture.Size = new System.Drawing.Size(55, 13);
			this.labelPicture.TabIndex = 16;
			this.labelPicture.Text = "Картинка";
			this.pictureBox.BackColor = System.Drawing.SystemColors.Info;
			this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.class37_0, "tR_MarkMeter.Image", true));
			this.pictureBox.Location = new System.Drawing.Point(176, 176);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(176, 50);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 17;
			this.pictureBox.TabStop = false;
			this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
			this.buttonOk.Location = new System.Drawing.Point(16, 243);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 17;
			this.buttonOk.Text = "ОК";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(277, 243);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 18;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.openFileDialog_0.FileName = "openFileDialog1";
			this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class37_0, "tR_MarkMeter.Name", true));
			this.textBoxName.Location = new System.Drawing.Point(15, 25);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(337, 20);
			this.textBoxName.TabIndex = 1;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(364, 278);
			base.Controls.Add(this.textBoxName);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.pictureBox);
			base.Controls.Add(this.labelPicture);
			base.Controls.Add(this.richTextBoxComment);
			base.Controls.Add(this.labelComment);
			base.Controls.Add(this.numericUpDownTarif);
			base.Controls.Add(this.numericUpDownInterval);
			base.Controls.Add(this.labelTarif);
			base.Controls.Add(this.labelInterval);
			base.Controls.Add(this.labelPrecision);
			base.Controls.Add(this.numericUpDownPrecision);
			base.Controls.Add(this.comboBoxVoltage);
			base.Controls.Add(this.labelVoltage);
			base.Controls.Add(this.numericUpDownPhaze);
			base.Controls.Add(this.labelPhaze);
			base.Controls.Add(this.numericUpDownDigit);
			base.Controls.Add(this.labelDigit);
			base.Controls.Add(this.labelName);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormCounterAddEdit";
			this.Text = "FormCounterAddEdit";
			base.Load += new System.EventHandler(this.FormCounterAddEdit_Load);
			((System.ComponentModel.ISupportInitialize)this.numericUpDownDigit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownPhaze).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownPrecision).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownInterval).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownTarif).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.Label labelName;

		private System.Windows.Forms.Label labelDigit;

		private System.Windows.Forms.NumericUpDown numericUpDownDigit;

		private System.Windows.Forms.Label labelPhaze;

		private System.Windows.Forms.NumericUpDown numericUpDownPhaze;

		private System.Windows.Forms.Label labelVoltage;

		private System.Windows.Forms.ComboBox comboBoxVoltage;

		private System.Windows.Forms.NumericUpDown numericUpDownPrecision;

		private System.Windows.Forms.Label labelPrecision;

		private System.Windows.Forms.Label labelInterval;

		private System.Windows.Forms.Label labelTarif;

		private System.Windows.Forms.NumericUpDown numericUpDownInterval;

		private System.Windows.Forms.NumericUpDown numericUpDownTarif;

		private System.Windows.Forms.Label labelComment;

		private System.Windows.Forms.RichTextBox richTextBoxComment;

		private System.Windows.Forms.Label labelPicture;

		private System.Windows.Forms.PictureBox pictureBox;

		private System.Windows.Forms.Button buttonOk;

		private System.Windows.Forms.Button buttonCancel;

		private Class37 class37_0;

		private System.Windows.Forms.OpenFileDialog openFileDialog_0;

		private System.Windows.Forms.TextBox textBoxName;
	}
}
