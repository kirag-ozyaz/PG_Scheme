namespace SchemeCtrl2.Canvas.Forms
{
	public partial class FormExportCanvasToImage : global::System.Windows.Forms.Form
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
			this.groupBoxColor = new global::System.Windows.Forms.GroupBox();
			this.radioButtonTwoColor = new global::System.Windows.Forms.RadioButton();
			this.radioButtonManyColor = new global::System.Windows.Forms.RadioButton();
			this.labelBackgroundColor = new global::System.Windows.Forms.Label();
			this.panelBackgroundColor = new global::System.Windows.Forms.Panel();
			this.groupBoxSizeImage = new global::System.Windows.Forms.GroupBox();
			this.labelNewSizeImage = new global::System.Windows.Forms.Label();
			this.labelOldSizeImage = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.numUpDownPercent = new global::System.Windows.Forms.NumericUpDown();
			this.radioButtonPercentImageSize = new global::System.Windows.Forms.RadioButton();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.numUpDownNewHeight = new global::System.Windows.Forms.NumericUpDown();
			this.numUpDownNewWidth = new global::System.Windows.Forms.NumericUpDown();
			this.radioButtonChangeSizeImage = new global::System.Windows.Forms.RadioButton();
			this.radioButtonCurrentSizeImage = new global::System.Windows.Forms.RadioButton();
			this.label6 = new global::System.Windows.Forms.Label();
			this.textBoxFileName = new global::System.Windows.Forms.TextBox();
			this.buttonFileName = new global::System.Windows.Forms.Button();
			this.buttonSave = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.saveFileDialog_0 = new global::System.Windows.Forms.SaveFileDialog();
			this.groupBoxColor.SuspendLayout();
			this.groupBoxSizeImage.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numUpDownPercent).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numUpDownNewHeight).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numUpDownNewWidth).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.groupBoxColor.Controls.Add(this.radioButtonTwoColor);
			this.groupBoxColor.Controls.Add(this.radioButtonManyColor);
			this.groupBoxColor.Location = new global::System.Drawing.Point(2, 0);
			this.groupBoxColor.Name = "groupBoxColor";
			this.groupBoxColor.Size = new global::System.Drawing.Size(151, 66);
			this.groupBoxColor.TabIndex = 0;
			this.groupBoxColor.TabStop = false;
			this.groupBoxColor.Text = "Цвет";
			this.radioButtonTwoColor.AutoSize = true;
			this.radioButtonTwoColor.Location = new global::System.Drawing.Point(10, 42);
			this.radioButtonTwoColor.Name = "radioButtonTwoColor";
			this.radioButtonTwoColor.Size = new global::System.Drawing.Size(90, 17);
			this.radioButtonTwoColor.TabIndex = 1;
			this.radioButtonTwoColor.Text = "Черно-белая";
			this.radioButtonTwoColor.UseVisualStyleBackColor = true;
			this.radioButtonTwoColor.CheckedChanged += new global::System.EventHandler(this.radioButtonTwoColor_CheckedChanged);
			this.radioButtonManyColor.AutoSize = true;
			this.radioButtonManyColor.Checked = true;
			this.radioButtonManyColor.Location = new global::System.Drawing.Point(10, 19);
			this.radioButtonManyColor.Name = "radioButtonManyColor";
			this.radioButtonManyColor.Size = new global::System.Drawing.Size(68, 17);
			this.radioButtonManyColor.TabIndex = 0;
			this.radioButtonManyColor.TabStop = true;
			this.radioButtonManyColor.Text = "Цветная";
			this.radioButtonManyColor.UseVisualStyleBackColor = true;
			this.labelBackgroundColor.AutoSize = true;
			this.labelBackgroundColor.Location = new global::System.Drawing.Point(12, 76);
			this.labelBackgroundColor.Name = "labelBackgroundColor";
			this.labelBackgroundColor.Size = new global::System.Drawing.Size(64, 13);
			this.labelBackgroundColor.TabIndex = 1;
			this.labelBackgroundColor.Text = "Цвет фона:";
			this.panelBackgroundColor.BackColor = global::System.Drawing.Color.Black;
			this.panelBackgroundColor.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelBackgroundColor.Location = new global::System.Drawing.Point(82, 72);
			this.panelBackgroundColor.Name = "panelBackgroundColor";
			this.panelBackgroundColor.Size = new global::System.Drawing.Size(71, 24);
			this.panelBackgroundColor.TabIndex = 2;
			this.panelBackgroundColor.Click += new global::System.EventHandler(this.panelBackgroundColor_Click);
			this.groupBoxSizeImage.Controls.Add(this.labelNewSizeImage);
			this.groupBoxSizeImage.Controls.Add(this.labelOldSizeImage);
			this.groupBoxSizeImage.Controls.Add(this.label5);
			this.groupBoxSizeImage.Controls.Add(this.label4);
			this.groupBoxSizeImage.Controls.Add(this.label3);
			this.groupBoxSizeImage.Controls.Add(this.numUpDownPercent);
			this.groupBoxSizeImage.Controls.Add(this.radioButtonPercentImageSize);
			this.groupBoxSizeImage.Controls.Add(this.label2);
			this.groupBoxSizeImage.Controls.Add(this.label1);
			this.groupBoxSizeImage.Controls.Add(this.numUpDownNewHeight);
			this.groupBoxSizeImage.Controls.Add(this.numUpDownNewWidth);
			this.groupBoxSizeImage.Controls.Add(this.radioButtonChangeSizeImage);
			this.groupBoxSizeImage.Controls.Add(this.radioButtonCurrentSizeImage);
			this.groupBoxSizeImage.Location = new global::System.Drawing.Point(159, 0);
			this.groupBoxSizeImage.Name = "groupBoxSizeImage";
			this.groupBoxSizeImage.Size = new global::System.Drawing.Size(263, 198);
			this.groupBoxSizeImage.TabIndex = 3;
			this.groupBoxSizeImage.TabStop = false;
			this.groupBoxSizeImage.Text = "Размер рисунка";
			this.labelNewSizeImage.AutoSize = true;
			this.labelNewSizeImage.Location = new global::System.Drawing.Point(114, 171);
			this.labelNewSizeImage.Name = "labelNewSizeImage";
			this.labelNewSizeImage.Size = new global::System.Drawing.Size(35, 13);
			this.labelNewSizeImage.TabIndex = 14;
			this.labelNewSizeImage.Text = "label6";
			this.labelOldSizeImage.AutoSize = true;
			this.labelOldSizeImage.Location = new global::System.Drawing.Point(114, 147);
			this.labelOldSizeImage.Name = "labelOldSizeImage";
			this.labelOldSizeImage.Size = new global::System.Drawing.Size(35, 13);
			this.labelOldSizeImage.TabIndex = 13;
			this.labelOldSizeImage.Text = "label6";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(6, 171);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(85, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Новый размер:";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(6, 147);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(102, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Исходный размер:";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(97, 116);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(15, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "%";
			this.numUpDownPercent.Location = new global::System.Drawing.Point(24, 114);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numUpDownPercent;
			int[] array = new int[4];
			array[0] = 10000000;
			numericUpDown.Maximum = new decimal(array);
			this.numUpDownPercent.Name = "numUpDownPercent";
			this.numUpDownPercent.Size = new global::System.Drawing.Size(67, 20);
			this.numUpDownPercent.TabIndex = 9;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numUpDownPercent;
			int[] array2 = new int[4];
			array2[0] = 100;
			numericUpDown2.Value = new decimal(array2);
			this.numUpDownPercent.ValueChanged += new global::System.EventHandler(this.numUpDownPercent_ValueChanged);
			this.radioButtonPercentImageSize.AutoSize = true;
			this.radioButtonPercentImageSize.Location = new global::System.Drawing.Point(6, 91);
			this.radioButtonPercentImageSize.Name = "radioButtonPercentImageSize";
			this.radioButtonPercentImageSize.Size = new global::System.Drawing.Size(226, 17);
			this.radioButtonPercentImageSize.TabIndex = 8;
			this.radioButtonPercentImageSize.TabStop = true;
			this.radioButtonPercentImageSize.Text = "Процент от исходной ширины и высоты";
			this.radioButtonPercentImageSize.UseVisualStyleBackColor = true;
			this.radioButtonPercentImageSize.CheckedChanged += new global::System.EventHandler(this.radioButtonPercentImageSize_CheckedChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(203, 69);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(25, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "пкс";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(104, 69);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(12, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "х";
			this.numUpDownNewHeight.Location = new global::System.Drawing.Point(130, 65);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numUpDownNewHeight;
			int[] array3 = new int[4];
			array3[0] = 10000000;
			numericUpDown3.Maximum = new decimal(array3);
			this.numUpDownNewHeight.Name = "numUpDownNewHeight";
			this.numUpDownNewHeight.Size = new global::System.Drawing.Size(67, 20);
			this.numUpDownNewHeight.TabIndex = 5;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numUpDownNewHeight;
			int[] array4 = new int[4];
			array4[0] = 768;
			numericUpDown4.Value = new decimal(array4);
			this.numUpDownNewHeight.ValueChanged += new global::System.EventHandler(this.numUpDownNewHeight_ValueChanged);
			this.numUpDownNewWidth.Location = new global::System.Drawing.Point(24, 65);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numUpDownNewWidth;
			int[] array5 = new int[4];
			array5[0] = 10000000;
			numericUpDown5.Maximum = new decimal(array5);
			this.numUpDownNewWidth.Name = "numUpDownNewWidth";
			this.numUpDownNewWidth.Size = new global::System.Drawing.Size(67, 20);
			this.numUpDownNewWidth.TabIndex = 4;
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numUpDownNewWidth;
			int[] array6 = new int[4];
			array6[0] = 1024;
			numericUpDown6.Value = new decimal(array6);
			this.numUpDownNewWidth.ValueChanged += new global::System.EventHandler(this.numUpDownNewWidth_ValueChanged);
			this.radioButtonChangeSizeImage.AutoSize = true;
			this.radioButtonChangeSizeImage.Location = new global::System.Drawing.Point(6, 42);
			this.radioButtonChangeSizeImage.Name = "radioButtonChangeSizeImage";
			this.radioButtonChangeSizeImage.Size = new global::System.Drawing.Size(191, 17);
			this.radioButtonChangeSizeImage.TabIndex = 3;
			this.radioButtonChangeSizeImage.TabStop = true;
			this.radioButtonChangeSizeImage.Text = "Произвольные ширина и высота";
			this.radioButtonChangeSizeImage.UseVisualStyleBackColor = true;
			this.radioButtonChangeSizeImage.CheckedChanged += new global::System.EventHandler(this.radioButtonChangeSizeImage_CheckedChanged);
			this.radioButtonCurrentSizeImage.AutoSize = true;
			this.radioButtonCurrentSizeImage.Checked = true;
			this.radioButtonCurrentSizeImage.Location = new global::System.Drawing.Point(6, 19);
			this.radioButtonCurrentSizeImage.Name = "radioButtonCurrentSizeImage";
			this.radioButtonCurrentSizeImage.Size = new global::System.Drawing.Size(117, 17);
			this.radioButtonCurrentSizeImage.TabIndex = 0;
			this.radioButtonCurrentSizeImage.TabStop = true;
			this.radioButtonCurrentSizeImage.Text = "Исходный размер";
			this.radioButtonCurrentSizeImage.UseVisualStyleBackColor = true;
			this.radioButtonCurrentSizeImage.CheckedChanged += new global::System.EventHandler(this.radioButtonCurrentSizeImage_CheckedChanged);
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(12, 188);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(64, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Имя файла";
			this.textBoxFileName.Location = new global::System.Drawing.Point(12, 204);
			this.textBoxFileName.Name = "textBoxFileName";
			this.textBoxFileName.Size = new global::System.Drawing.Size(379, 20);
			this.textBoxFileName.TabIndex = 5;
			this.textBoxFileName.Text = "default.jpeg";
			this.buttonFileName.Location = new global::System.Drawing.Point(391, 204);
			this.buttonFileName.Name = "buttonFileName";
			this.buttonFileName.Size = new global::System.Drawing.Size(31, 23);
			this.buttonFileName.TabIndex = 6;
			this.buttonFileName.Text = "...";
			this.buttonFileName.UseVisualStyleBackColor = true;
			this.buttonFileName.Click += new global::System.EventHandler(this.buttonFileName_Click);
			this.buttonSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.buttonSave.Location = new global::System.Drawing.Point(12, 248);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new global::System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new global::System.EventHandler(this.buttonSave_Click);
			this.buttonClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.buttonClose.Location = new global::System.Drawing.Point(347, 248);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 8;
			this.buttonClose.Text = "Закрыть";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.pictureBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox1.Location = new global::System.Drawing.Point(428, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(500, 267);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.saveFileDialog_0.AutoUpgradeEnabled = false;
			this.saveFileDialog_0.RestoreDirectory = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(927, 279);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonSave);
			base.Controls.Add(this.buttonFileName);
			base.Controls.Add(this.textBoxFileName);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.groupBoxSizeImage);
			base.Controls.Add(this.panelBackgroundColor);
			base.Controls.Add(this.labelBackgroundColor);
			base.Controls.Add(this.groupBoxColor);
			base.Name = "FormExportCanvasToImage";
			this.Text = "Экспорт в картинку";
			base.Load += new global::System.EventHandler(this.FormExportCanvasToImage_Load);
			this.groupBoxColor.ResumeLayout(false);
			this.groupBoxColor.PerformLayout();
			this.groupBoxSizeImage.ResumeLayout(false);
			this.groupBoxSizeImage.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numUpDownPercent).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numUpDownNewHeight).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numUpDownNewWidth).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.GroupBox groupBoxColor;

		private global::System.Windows.Forms.RadioButton radioButtonTwoColor;

		private global::System.Windows.Forms.RadioButton radioButtonManyColor;

		private global::System.Windows.Forms.Label labelBackgroundColor;

		private global::System.Windows.Forms.Panel panelBackgroundColor;

		private global::System.Windows.Forms.GroupBox groupBoxSizeImage;

		private global::System.Windows.Forms.Label labelNewSizeImage;

		private global::System.Windows.Forms.Label labelOldSizeImage;

		private global::System.Windows.Forms.Label label5;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.NumericUpDown numUpDownPercent;

		private global::System.Windows.Forms.RadioButton radioButtonPercentImageSize;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.NumericUpDown numUpDownNewHeight;

		private global::System.Windows.Forms.NumericUpDown numUpDownNewWidth;

		private global::System.Windows.Forms.RadioButton radioButtonChangeSizeImage;

		private global::System.Windows.Forms.RadioButton radioButtonCurrentSizeImage;

		private global::System.Windows.Forms.Label label6;

		private global::System.Windows.Forms.TextBox textBoxFileName;

		private global::System.Windows.Forms.Button buttonFileName;

		private global::System.Windows.Forms.Button buttonSave;

		private global::System.Windows.Forms.Button buttonClose;

		private global::System.Windows.Forms.PictureBox pictureBox1;

		private global::System.Windows.Forms.SaveFileDialog saveFileDialog_0;
	}
}
