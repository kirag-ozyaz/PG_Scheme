namespace Reference.Forms
{
	public partial class FormTransAddEdit : FormLbr.FormBase
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
			this.labelPrimary = new System.Windows.Forms.Label();
			this.numericUpDownPriamry = new System.Windows.Forms.NumericUpDown();
			this.class37_0 = new Class37();
			this.labelSecondary = new System.Windows.Forms.Label();
			this.numericUpDownSecondary = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownPrecision = new System.Windows.Forms.NumericUpDown();
			this.labelPrecision = new System.Windows.Forms.Label();
			this.labelInterval = new System.Windows.Forms.Label();
			this.labelType = new System.Windows.Forms.Label();
			this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
			this.labelComment = new System.Windows.Forms.Label();
			this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
			this.labelPicture = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.openFileDialog_0 = new System.Windows.Forms.OpenFileDialog();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownPriamry).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownSecondary).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownPrecision).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownInterval).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox).BeginInit();
			base.SuspendLayout();
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(12, 9);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(83, 13);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Наименование";
			this.labelPrimary.AutoSize = true;
			this.labelPrimary.Location = new System.Drawing.Point(12, 60);
			this.labelPrimary.Name = "labelPrimary";
			this.labelPrimary.Size = new System.Drawing.Size(44, 13);
			this.labelPrimary.TabIndex = 2;
			this.labelPrimary.Text = "Первич";
			this.numericUpDownPriamry.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.class37_0, "tR_MarkTrans.Primary", true));
			this.numericUpDownPriamry.Location = new System.Drawing.Point(15, 76);
			System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDownPriamry;
			int[] array = new int[4];
			array[0] = 100000;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDownPriamry.Name = "numericUpDownPriamry";
			this.numericUpDownPriamry.Size = new System.Drawing.Size(85, 20);
			this.numericUpDownPriamry.TabIndex = 3;
			System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDownPriamry;
			int[] array2 = new int[4];
			array2[0] = 5;
			numericUpDown2.Value = new decimal(array2);
			this.class37_0.DataSetName = "DataSetMeters";
			this.class37_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.labelSecondary.AutoSize = true;
			this.labelSecondary.Location = new System.Drawing.Point(118, 60);
			this.labelSecondary.Name = "labelSecondary";
			this.labelSecondary.Size = new System.Drawing.Size(42, 13);
			this.labelSecondary.TabIndex = 4;
			this.labelSecondary.Text = "Вторич";
			this.numericUpDownSecondary.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.class37_0, "tR_MarkTrans.Secondary", true));
			this.numericUpDownSecondary.Location = new System.Drawing.Point(119, 75);
			this.numericUpDownSecondary.Name = "numericUpDownSecondary";
			this.numericUpDownSecondary.Size = new System.Drawing.Size(77, 20);
			this.numericUpDownSecondary.TabIndex = 5;
			System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDownSecondary;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.numericUpDownPrecision.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.class37_0, "tR_MarkTrans.Precision", true));
			this.numericUpDownPrecision.DecimalPlaces = 1;
			this.numericUpDownPrecision.Increment = new decimal(new int[]
			{
				5,
				0,
				0,
				65536
			});
			this.numericUpDownPrecision.Location = new System.Drawing.Point(221, 76);
			this.numericUpDownPrecision.Name = "numericUpDownPrecision";
			this.numericUpDownPrecision.Size = new System.Drawing.Size(77, 20);
			this.numericUpDownPrecision.TabIndex = 7;
			this.labelPrecision.AutoSize = true;
			this.labelPrecision.Location = new System.Drawing.Point(218, 60);
			this.labelPrecision.Name = "labelPrecision";
			this.labelPrecision.Size = new System.Drawing.Size(54, 13);
			this.labelPrecision.TabIndex = 6;
			this.labelPrecision.Text = "Точность";
			this.labelInterval.AutoSize = true;
			this.labelInterval.Location = new System.Drawing.Point(13, 112);
			this.labelInterval.Name = "labelInterval";
			this.labelInterval.Size = new System.Drawing.Size(104, 13);
			this.labelInterval.TabIndex = 8;
			this.labelInterval.Text = "Межпров интервал";
			this.labelType.AutoSize = true;
			this.labelType.Location = new System.Drawing.Point(174, 112);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(26, 13);
			this.labelType.TabIndex = 10;
			this.labelType.Text = "Тип";
			this.numericUpDownInterval.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.class37_0, "tR_MarkTrans.Interval", true));
			this.numericUpDownInterval.Location = new System.Drawing.Point(15, 128);
			this.numericUpDownInterval.Name = "numericUpDownInterval";
			this.numericUpDownInterval.Size = new System.Drawing.Size(139, 20);
			this.numericUpDownInterval.TabIndex = 9;
			System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDownInterval;
			int[] array4 = new int[4];
			array4[0] = 16;
			numericUpDown4.Value = new decimal(array4);
			this.labelComment.AutoSize = true;
			this.labelComment.Location = new System.Drawing.Point(13, 160);
			this.labelComment.Name = "labelComment";
			this.labelComment.Size = new System.Drawing.Size(77, 13);
			this.labelComment.TabIndex = 12;
			this.labelComment.Text = "Комментарии";
			this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class37_0, "tR_MarkTrans.Comment", true));
			this.richTextBoxComment.Location = new System.Drawing.Point(16, 176);
			this.richTextBoxComment.Name = "richTextBoxComment";
			this.richTextBoxComment.Size = new System.Drawing.Size(154, 50);
			this.richTextBoxComment.TabIndex = 13;
			this.richTextBoxComment.Text = "";
			this.labelPicture.AutoSize = true;
			this.labelPicture.Location = new System.Drawing.Point(173, 160);
			this.labelPicture.Name = "labelPicture";
			this.labelPicture.Size = new System.Drawing.Size(55, 13);
			this.labelPicture.TabIndex = 14;
			this.labelPicture.Text = "Картинка";
			this.pictureBox.BackColor = System.Drawing.SystemColors.Info;
			this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.class37_0, "tR_MarkTrans.Image", true));
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
			this.buttonOk.TabIndex = 15;
			this.buttonOk.Text = "ОК";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(277, 243);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 16;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.openFileDialog_0.FileName = "openFileDialog1";
			this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class37_0, "tR_MarkTrans.Name", true));
			this.textBoxName.Location = new System.Drawing.Point(15, 25);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(337, 20);
			this.textBoxName.TabIndex = 1;
			this.comboBoxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.class37_0, "tR_MarkTrans.TypeTrans", true));
			this.comboBoxType.DataSource = this.class37_0;
			this.comboBoxType.DisplayMember = "tR_Classifier.Name";
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Location = new System.Drawing.Point(177, 128);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(175, 21);
			this.comboBoxType.TabIndex = 11;
			this.comboBoxType.ValueMember = "tR_Classifier.Id";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(364, 278);
			base.Controls.Add(this.comboBoxType);
			base.Controls.Add(this.textBoxName);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.pictureBox);
			base.Controls.Add(this.labelPicture);
			base.Controls.Add(this.richTextBoxComment);
			base.Controls.Add(this.labelComment);
			base.Controls.Add(this.numericUpDownInterval);
			base.Controls.Add(this.labelType);
			base.Controls.Add(this.labelInterval);
			base.Controls.Add(this.labelPrecision);
			base.Controls.Add(this.numericUpDownPrecision);
			base.Controls.Add(this.numericUpDownSecondary);
			base.Controls.Add(this.labelSecondary);
			base.Controls.Add(this.numericUpDownPriamry);
			base.Controls.Add(this.labelPrimary);
			base.Controls.Add(this.labelName);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormTransAddEdit";
			this.Text = "FormCounterAddEdit";
			base.Load += new System.EventHandler(this.FormTransAddEdit_Load);
			((System.ComponentModel.ISupportInitialize)this.numericUpDownPriamry).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownSecondary).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownPrecision).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownInterval).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.Label labelName;

		private System.Windows.Forms.Label labelPrimary;

		private System.Windows.Forms.NumericUpDown numericUpDownPriamry;

		private System.Windows.Forms.Label labelSecondary;

		private System.Windows.Forms.NumericUpDown numericUpDownSecondary;

		private System.Windows.Forms.NumericUpDown numericUpDownPrecision;

		private System.Windows.Forms.Label labelPrecision;

		private System.Windows.Forms.Label labelInterval;

		private System.Windows.Forms.Label labelType;

		private System.Windows.Forms.NumericUpDown numericUpDownInterval;

		private System.Windows.Forms.Label labelComment;

		private System.Windows.Forms.RichTextBox richTextBoxComment;

		private System.Windows.Forms.Label labelPicture;

		private System.Windows.Forms.PictureBox pictureBox;

		private System.Windows.Forms.Button buttonOk;

		private System.Windows.Forms.Button buttonCancel;

		private Class37 class37_0;

		private System.Windows.Forms.OpenFileDialog openFileDialog_0;

		private System.Windows.Forms.TextBox textBoxName;

		private System.Windows.Forms.ComboBox comboBoxType;
	}
}
