namespace Reference.Forms
{
	public partial class FormTransformerAdd : System.Windows.Forms.Form
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
			this.icontainer_0 = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Reference.Forms.FormTransformerAdd));
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.tRTransformerBindingSource = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.class37_0 = new Class37();
			this.textBoxType = new System.Windows.Forms.TextBox();
			this.numericUpDownPower = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownHighVoltage = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownLoVoltage = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownRatedAmperHV = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownRatedAmperLV = new System.Windows.Forms.NumericUpDown();
			this.textBoxGroupWindings = new System.Windows.Forms.TextBox();
			this.numericUpDownShortCircuitVolt = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownShortCircuitLoss = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownNoLoadLoss = new System.Windows.Forms.NumericUpDown();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)this.tRTransformerBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownPower).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownHighVoltage).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownLoVoltage).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownRatedAmperHV).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownRatedAmperLV).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownShortCircuitVolt).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownShortCircuitLoss).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownNoLoadLoss).BeginInit();
			base.SuspendLayout();
			this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRTransformerBindingSource, "Name", true));
			this.textBoxName.Location = new System.Drawing.Point(258, 12);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(109, 20);
			this.textBoxName.TabIndex = 0;
			this.tRTransformerBindingSource.DataMember = "tR_Transformer";
			this.tRTransformerBindingSource.DataSource = this.class37_0;
			this.class37_0.DataSetName = "DataSetMeters";
			this.class37_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.textBoxType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRTransformerBindingSource, "Type", true));
			this.textBoxType.Location = new System.Drawing.Point(258, 38);
			this.textBoxType.Name = "textBoxType";
			this.textBoxType.Size = new System.Drawing.Size(109, 20);
			this.textBoxType.TabIndex = 1;
			this.numericUpDownPower.Location = new System.Drawing.Point(258, 64);
			System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDownPower;
			int[] array = new int[4];
			array[0] = 10000;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDownPower.Name = "numericUpDownPower";
			this.numericUpDownPower.Size = new System.Drawing.Size(109, 20);
			this.numericUpDownPower.TabIndex = 2;
			this.numericUpDownPower.ValueChanged += new System.EventHandler(this.numericUpDownPower_ValueChanged);
			this.numericUpDownHighVoltage.DecimalPlaces = 2;
			this.numericUpDownHighVoltage.Location = new System.Drawing.Point(258, 90);
			System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDownHighVoltage;
			int[] array2 = new int[4];
			array2[0] = 1000;
			numericUpDown2.Maximum = new decimal(array2);
			this.numericUpDownHighVoltage.Name = "numericUpDownHighVoltage";
			this.numericUpDownHighVoltage.Size = new System.Drawing.Size(109, 20);
			this.numericUpDownHighVoltage.TabIndex = 3;
			this.numericUpDownHighVoltage.ValueChanged += new System.EventHandler(this.numericUpDownHighVoltage_ValueChanged);
			this.numericUpDownLoVoltage.DecimalPlaces = 2;
			this.numericUpDownLoVoltage.Location = new System.Drawing.Point(258, 116);
			System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDownLoVoltage;
			int[] array3 = new int[4];
			array3[0] = 1000;
			numericUpDown3.Maximum = new decimal(array3);
			this.numericUpDownLoVoltage.Name = "numericUpDownLoVoltage";
			this.numericUpDownLoVoltage.Size = new System.Drawing.Size(109, 20);
			this.numericUpDownLoVoltage.TabIndex = 4;
			this.numericUpDownLoVoltage.ValueChanged += new System.EventHandler(this.numericUpDownLoVoltage_ValueChanged);
			this.numericUpDownRatedAmperHV.DecimalPlaces = 3;
			this.numericUpDownRatedAmperHV.Location = new System.Drawing.Point(258, 142);
			System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDownRatedAmperHV;
			int[] array4 = new int[4];
			array4[0] = 10000;
			numericUpDown4.Maximum = new decimal(array4);
			this.numericUpDownRatedAmperHV.Name = "numericUpDownRatedAmperHV";
			this.numericUpDownRatedAmperHV.Size = new System.Drawing.Size(109, 20);
			this.numericUpDownRatedAmperHV.TabIndex = 5;
			this.numericUpDownRatedAmperHV.ValueChanged += new System.EventHandler(this.numericUpDownRatedAmperHV_ValueChanged);
			this.numericUpDownRatedAmperLV.DecimalPlaces = 3;
			this.numericUpDownRatedAmperLV.Location = new System.Drawing.Point(258, 168);
			System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericUpDownRatedAmperLV;
			int[] array5 = new int[4];
			array5[0] = 10000;
			numericUpDown5.Maximum = new decimal(array5);
			this.numericUpDownRatedAmperLV.Name = "numericUpDownRatedAmperLV";
			this.numericUpDownRatedAmperLV.Size = new System.Drawing.Size(109, 20);
			this.numericUpDownRatedAmperLV.TabIndex = 6;
			this.numericUpDownRatedAmperLV.ValueChanged += new System.EventHandler(this.numericUpDownRatedAmperLV_ValueChanged);
			this.textBoxGroupWindings.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRTransformerBindingSource, "GroupWindings", true));
			this.textBoxGroupWindings.Location = new System.Drawing.Point(258, 194);
			this.textBoxGroupWindings.Name = "textBoxGroupWindings";
			this.textBoxGroupWindings.Size = new System.Drawing.Size(109, 20);
			this.textBoxGroupWindings.TabIndex = 7;
			this.numericUpDownShortCircuitVolt.DecimalPlaces = 1;
			this.numericUpDownShortCircuitVolt.Location = new System.Drawing.Point(258, 220);
			this.numericUpDownShortCircuitVolt.Name = "numericUpDownShortCircuitVolt";
			this.numericUpDownShortCircuitVolt.Size = new System.Drawing.Size(109, 20);
			this.numericUpDownShortCircuitVolt.TabIndex = 8;
			this.numericUpDownShortCircuitVolt.ValueChanged += new System.EventHandler(this.numericUpDownShortCircuitVolt_ValueChanged);
			this.numericUpDownShortCircuitLoss.DecimalPlaces = 3;
			this.numericUpDownShortCircuitLoss.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				196608
			});
			this.numericUpDownShortCircuitLoss.Location = new System.Drawing.Point(258, 246);
			System.Windows.Forms.NumericUpDown numericUpDown6 = this.numericUpDownShortCircuitLoss;
			int[] array6 = new int[4];
			array6[0] = 100000;
			numericUpDown6.Maximum = new decimal(array6);
			this.numericUpDownShortCircuitLoss.Name = "numericUpDownShortCircuitLoss";
			this.numericUpDownShortCircuitLoss.Size = new System.Drawing.Size(109, 20);
			this.numericUpDownShortCircuitLoss.TabIndex = 9;
			this.numericUpDownShortCircuitLoss.ValueChanged += new System.EventHandler(this.numericUpDownShortCircuitLoss_ValueChanged);
			this.numericUpDownNoLoadLoss.DecimalPlaces = 3;
			this.numericUpDownNoLoadLoss.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				196608
			});
			this.numericUpDownNoLoadLoss.Location = new System.Drawing.Point(258, 272);
			System.Windows.Forms.NumericUpDown numericUpDown7 = this.numericUpDownNoLoadLoss;
			int[] array7 = new int[4];
			array7[0] = 100000;
			numericUpDown7.Maximum = new decimal(array7);
			this.numericUpDownNoLoadLoss.Name = "numericUpDownNoLoadLoss";
			this.numericUpDownNoLoadLoss.Size = new System.Drawing.Size(109, 20);
			this.numericUpDownNoLoadLoss.TabIndex = 10;
			this.numericUpDownNoLoadLoss.ValueChanged += new System.EventHandler(this.numericUpDownNoLoadLoss_ValueChanged);
			this.buttonOK.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(214, 301);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 11;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonCancel.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(295, 301);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 12;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Наименование";
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Тип";
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Мощность, кВА";
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(204, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Номинальное высшее напряжение, кВ";
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 118);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(202, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Номинальное низшее напряжение, кВ";
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(229, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Номинальный ток высокого напряжения, А";
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 170);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(221, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Номинальный ток низкого напряжения. А";
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 197);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Группа обмоток";
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 222);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(201, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Напряжение короткого замыкания, %";
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 248);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(184, 13);
			this.label10.TabIndex = 14;
			this.label10.Text = "Потери короткого замыкания, кВт";
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 274);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(148, 13);
			this.label11.TabIndex = 14;
			this.label11.Text = "Потери холостого хода, кВт";
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(382, 336);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.numericUpDownNoLoadLoss);
			base.Controls.Add(this.numericUpDownShortCircuitLoss);
			base.Controls.Add(this.numericUpDownShortCircuitVolt);
			base.Controls.Add(this.numericUpDownRatedAmperLV);
			base.Controls.Add(this.numericUpDownRatedAmperHV);
			base.Controls.Add(this.numericUpDownLoVoltage);
			base.Controls.Add(this.numericUpDownHighVoltage);
			base.Controls.Add(this.numericUpDownPower);
			base.Controls.Add(this.textBoxGroupWindings);
			base.Controls.Add(this.textBoxType);
			base.Controls.Add(this.textBoxName);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormTransformerAdd";
			this.Text = "Добавить трансформатор";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTransformerAdd_FormClosing);
			base.Load += new System.EventHandler(this.FormTransformerAdd_Load);
			((System.ComponentModel.ISupportInitialize)this.tRTransformerBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownPower).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownHighVoltage).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownLoVoltage).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownRatedAmperHV).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownRatedAmperLV).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownShortCircuitVolt).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownShortCircuitLoss).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownNoLoadLoss).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.TextBox textBoxName;

		private Class37 class37_0;

		public System.Windows.Forms.BindingSource tRTransformerBindingSource;

		private System.Windows.Forms.TextBox textBoxType;

		private System.Windows.Forms.NumericUpDown numericUpDownPower;

		private System.Windows.Forms.NumericUpDown numericUpDownHighVoltage;

		private System.Windows.Forms.NumericUpDown numericUpDownLoVoltage;

		private System.Windows.Forms.NumericUpDown numericUpDownRatedAmperHV;

		private System.Windows.Forms.NumericUpDown numericUpDownRatedAmperLV;

		private System.Windows.Forms.TextBox textBoxGroupWindings;

		private System.Windows.Forms.NumericUpDown numericUpDownShortCircuitVolt;

		private System.Windows.Forms.NumericUpDown numericUpDownShortCircuitLoss;

		private System.Windows.Forms.NumericUpDown numericUpDownNoLoadLoss;

		private System.Windows.Forms.Button buttonOK;

		private System.Windows.Forms.Button buttonCancel;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Label label4;

		private System.Windows.Forms.Label label5;

		private System.Windows.Forms.Label label6;

		private System.Windows.Forms.Label label7;

		private System.Windows.Forms.Label label8;

		private System.Windows.Forms.Label label9;

		private System.Windows.Forms.Label label10;

		private System.Windows.Forms.Label label11;
	}
}
