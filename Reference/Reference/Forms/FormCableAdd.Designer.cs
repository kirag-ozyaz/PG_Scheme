namespace Reference.Forms
{
	public partial class FormCableAdd : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Reference.Forms.FormCableAdd));
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tRCableBindingSource = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.class37_0 = new Class37();
			this.numericUpDownWires = new Reference.Forms.FormCableAdd.NullableNumericUpDown();
			this.numericUpDownAmperage = new Reference.Forms.FormCableAdd.NullableNumericUpDown();
			this.numericUpDownResistance = new Reference.Forms.FormCableAdd.NullableNumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ibiykAjSb5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.tRClassifierBindingSource = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.numericUpDownAmperageAir = new Reference.Forms.FormCableAdd.NullableNumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.yFoyOpHlnE = new Reference.Forms.FormCableAdd.NullableNumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.numericUpDownCrossSectionAddl = new Reference.Forms.FormCableAdd.NullableNumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.numericUpDownResistanceAddl = new Reference.Forms.FormCableAdd.NullableNumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.numericUpDownCrossSectionLight = new Reference.Forms.FormCableAdd.NullableNumericUpDown();
			this.numericUpDownWiresLight = new Reference.Forms.FormCableAdd.NullableNumericUpDown();
			this.numericUpDownCrossSection = new ControlsLbr.NullableNumericUpDown();
			((System.ComponentModel.ISupportInitialize)this.tRCableBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownWires).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownAmperage).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownResistance).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.tRClassifierBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownAmperageAir).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.yFoyOpHlnE).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownCrossSectionAddl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownResistanceAddl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownCrossSectionLight).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownWiresLight).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownCrossSection).BeginInit();
			base.SuspendLayout();
			this.buttonOK.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(254, 327);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 10;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonCancel.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(335, 327);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 11;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRCableBindingSource, "CableMakeup", true));
			this.textBox1.Location = new System.Drawing.Point(254, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(158, 20);
			this.textBox1.TabIndex = 0;
			this.tRCableBindingSource.DataMember = "tR_Cable";
			this.tRCableBindingSource.DataSource = this.class37_0;
			this.class37_0.DataSetName = "DataSetMeters";
			this.class37_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.numericUpDownWires.Location = new System.Drawing.Point(253, 65);
			this.numericUpDownWires.Name = "numericUpDownWires";
			this.numericUpDownWires.Size = new System.Drawing.Size(158, 20);
			this.numericUpDownWires.TabIndex = 2;
			this.numericUpDownWires.Value = null;
			this.numericUpDownWires.ValueChanged += new System.EventHandler(this.numericUpDownWires_ValueChanged);
			this.numericUpDownAmperage.DecimalPlaces = 2;
			this.numericUpDownAmperage.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericUpDownAmperage.Location = new System.Drawing.Point(254, 221);
			System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDownAmperage;
			int[] array = new int[4];
			array[0] = 1000;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDownAmperage.Name = "numericUpDownAmperage";
			this.numericUpDownAmperage.Size = new System.Drawing.Size(158, 20);
			this.numericUpDownAmperage.TabIndex = 6;
			this.numericUpDownAmperage.Value = null;
			this.numericUpDownAmperage.ValueChanged += new System.EventHandler(this.numericUpDownAmperage_ValueChanged);
			this.numericUpDownResistance.DecimalPlaces = 3;
			this.numericUpDownResistance.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericUpDownResistance.Location = new System.Drawing.Point(255, 273);
			System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDownResistance;
			int[] array2 = new int[4];
			array2[0] = 1000;
			numericUpDown2.Maximum = new decimal(array2);
			this.numericUpDownResistance.Name = "numericUpDownResistance";
			this.numericUpDownResistance.Size = new System.Drawing.Size(158, 20);
			this.numericUpDownResistance.TabIndex = 8;
			this.numericUpDownResistance.Value = null;
			this.numericUpDownResistance.ValueChanged += new System.EventHandler(this.numericUpDownResistance_ValueChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Наименование кабеля";
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Количество жил";
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Сечение (мм²)";
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(223, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Максимально допустимый ток в земле (A)";
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 275);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(212, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Удельное активное сопротивление (Ом)";
			this.ibiykAjSb5.AutoSize = true;
			this.ibiykAjSb5.Location = new System.Drawing.Point(12, 40);
			this.ibiykAjSb5.Name = "label6";
			this.ibiykAjSb5.Size = new System.Drawing.Size(71, 13);
			this.ibiykAjSb5.TabIndex = 5;
			this.ibiykAjSb5.Text = "Напряжение";
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tRCableBindingSource, "IdVoltage", true));
			this.comboBox1.DataSource = this.tRClassifierBindingSource;
			this.comboBox1.DisplayMember = "Name";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(254, 38);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(157, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.ValueMember = "Id";
			this.tRClassifierBindingSource.DataMember = "tR_Classifier";
			this.tRClassifierBindingSource.DataSource = this.class37_0;
			this.numericUpDownAmperageAir.DecimalPlaces = 2;
			this.numericUpDownAmperageAir.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericUpDownAmperageAir.Location = new System.Drawing.Point(254, 247);
			System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDownAmperageAir;
			int[] array3 = new int[4];
			array3[0] = 1000;
			numericUpDown3.Maximum = new decimal(array3);
			this.numericUpDownAmperageAir.Name = "numericUpDownAmperageAir";
			this.numericUpDownAmperageAir.Size = new System.Drawing.Size(158, 20);
			this.numericUpDownAmperageAir.TabIndex = 7;
			this.numericUpDownAmperageAir.Value = null;
			this.numericUpDownAmperageAir.ValueChanged += new System.EventHandler(this.numericUpDownAmperageAir_ValueChanged);
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 249);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(237, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Максимально допустимый ток на воздухе (A)";
			this.yFoyOpHlnE.Location = new System.Drawing.Point(254, 117);
			this.yFoyOpHlnE.Name = "numericUpDownWiresAddl";
			this.yFoyOpHlnE.Size = new System.Drawing.Size(157, 20);
			this.yFoyOpHlnE.TabIndex = 3;
			this.yFoyOpHlnE.Value = null;
			this.yFoyOpHlnE.ValueChanged += new System.EventHandler(this.yFoyOpHlnE_ValueChanged);
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 119);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(83, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Нулевые жилы";
			this.numericUpDownCrossSectionAddl.DecimalPlaces = 2;
			this.numericUpDownCrossSectionAddl.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericUpDownCrossSectionAddl.Location = new System.Drawing.Point(253, 143);
			System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDownCrossSectionAddl;
			int[] array4 = new int[4];
			array4[0] = 1000;
			numericUpDown4.Maximum = new decimal(array4);
			this.numericUpDownCrossSectionAddl.Name = "numericUpDownCrossSectionAddl";
			this.numericUpDownCrossSectionAddl.Size = new System.Drawing.Size(158, 20);
			this.numericUpDownCrossSectionAddl.TabIndex = 5;
			this.numericUpDownCrossSectionAddl.Value = null;
			this.numericUpDownCrossSectionAddl.ValueChanged += new System.EventHandler(this.numericUpDownCrossSectionAddl_ValueChanged);
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 145);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(145, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = "Сечение нулевых жил (мм²)";
			this.numericUpDownResistanceAddl.DecimalPlaces = 3;
			this.numericUpDownResistanceAddl.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericUpDownResistanceAddl.Location = new System.Drawing.Point(255, 299);
			System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericUpDownResistanceAddl;
			int[] array5 = new int[4];
			array5[0] = 1000;
			numericUpDown5.Maximum = new decimal(array5);
			this.numericUpDownResistanceAddl.Name = "numericUpDownResistanceAddl";
			this.numericUpDownResistanceAddl.Size = new System.Drawing.Size(158, 20);
			this.numericUpDownResistanceAddl.TabIndex = 9;
			this.numericUpDownResistanceAddl.Value = null;
			this.numericUpDownResistanceAddl.ValueChanged += new System.EventHandler(this.numericUpDownResistanceAddl_ValueChanged);
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(13, 301);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(220, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "Уд. акт. сопротивление нулевых жил (Ом)";
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(11, 197);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(160, 13);
			this.label11.TabIndex = 13;
			this.label11.Text = "Сечение жил освещения (мм²)";
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(11, 171);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(98, 13);
			this.label12.TabIndex = 12;
			this.label12.Text = "Жилы освещения";
			this.numericUpDownCrossSectionLight.DecimalPlaces = 2;
			this.numericUpDownCrossSectionLight.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericUpDownCrossSectionLight.Location = new System.Drawing.Point(253, 195);
			System.Windows.Forms.NumericUpDown numericUpDown6 = this.numericUpDownCrossSectionLight;
			int[] array6 = new int[4];
			array6[0] = 1000;
			numericUpDown6.Maximum = new decimal(array6);
			this.numericUpDownCrossSectionLight.Name = "numericUpDownCrossSectionLight";
			this.numericUpDownCrossSectionLight.Size = new System.Drawing.Size(158, 20);
			this.numericUpDownCrossSectionLight.TabIndex = 15;
			this.numericUpDownCrossSectionLight.Value = null;
			this.numericUpDownCrossSectionLight.ValueChanged += new System.EventHandler(this.numericUpDownCrossSectionLight_ValueChanged);
			this.numericUpDownWiresLight.Location = new System.Drawing.Point(253, 169);
			this.numericUpDownWiresLight.Name = "numericUpDownWiresLight";
			this.numericUpDownWiresLight.Size = new System.Drawing.Size(158, 20);
			this.numericUpDownWiresLight.TabIndex = 14;
			this.numericUpDownWiresLight.Value = null;
			this.numericUpDownWiresLight.ValueChanged += new System.EventHandler(this.numericUpDownWiresLight_ValueChanged);
			this.numericUpDownCrossSection.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.numericUpDownCrossSection.Location = new System.Drawing.Point(253, 91);
			System.Windows.Forms.NumericUpDown numericUpDown7 = this.numericUpDownCrossSection;
			int[] array7 = new int[4];
			array7[0] = 1000;
			numericUpDown7.Maximum = new decimal(array7);
			this.numericUpDownCrossSection.Name = "numericUpDownCrossSection";
			this.numericUpDownCrossSection.Size = new System.Drawing.Size(158, 20);
			this.numericUpDownCrossSection.TabIndex = 16;
			this.numericUpDownCrossSection.Value = null;
			this.numericUpDownCrossSection.ValueChanged += new System.EventHandler(this.numericUpDownCrossSection_ValueChanged);
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(422, 362);
			base.Controls.Add(this.numericUpDownCrossSection);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.numericUpDownCrossSectionLight);
			base.Controls.Add(this.numericUpDownWiresLight);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.ibiykAjSb5);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.numericUpDownResistanceAddl);
			base.Controls.Add(this.numericUpDownResistance);
			base.Controls.Add(this.numericUpDownAmperageAir);
			base.Controls.Add(this.numericUpDownAmperage);
			base.Controls.Add(this.numericUpDownCrossSectionAddl);
			base.Controls.Add(this.yFoyOpHlnE);
			base.Controls.Add(this.numericUpDownWires);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.buttonCancel);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormCableAdd";
			this.Text = "Добавить кабель";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCableAdd_FormClosing);
			base.Load += new System.EventHandler(this.FormCableAdd_Load);
			((System.ComponentModel.ISupportInitialize)this.tRCableBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownWires).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownAmperage).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownResistance).EndInit();
			((System.ComponentModel.ISupportInitialize)this.tRClassifierBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownAmperageAir).EndInit();
			((System.ComponentModel.ISupportInitialize)this.yFoyOpHlnE).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownCrossSectionAddl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownResistanceAddl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownCrossSectionLight).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownWiresLight).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownCrossSection).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.Button buttonOK;

		private System.Windows.Forms.Button buttonCancel;

		private System.Windows.Forms.TextBox textBox1;

		private Reference.Forms.FormCableAdd.NullableNumericUpDown numericUpDownWires;

		private Reference.Forms.FormCableAdd.NullableNumericUpDown numericUpDownAmperage;

		private Reference.Forms.FormCableAdd.NullableNumericUpDown numericUpDownResistance;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Label label4;

		private System.Windows.Forms.Label label5;

		private Class37 class37_0;

		public System.Windows.Forms.BindingSource tRCableBindingSource;

		private System.Windows.Forms.Label ibiykAjSb5;

		private System.Windows.Forms.ComboBox comboBox1;

		public System.Windows.Forms.BindingSource tRClassifierBindingSource;

		private Reference.Forms.FormCableAdd.NullableNumericUpDown numericUpDownAmperageAir;

		private System.Windows.Forms.Label label7;

		private Reference.Forms.FormCableAdd.NullableNumericUpDown yFoyOpHlnE;

		private System.Windows.Forms.Label label8;

		private Reference.Forms.FormCableAdd.NullableNumericUpDown numericUpDownCrossSectionAddl;

		private System.Windows.Forms.Label label9;

		private Reference.Forms.FormCableAdd.NullableNumericUpDown numericUpDownResistanceAddl;

		private System.Windows.Forms.Label label10;

		private System.Windows.Forms.Label label11;

		private System.Windows.Forms.Label label12;

		private Reference.Forms.FormCableAdd.NullableNumericUpDown numericUpDownCrossSectionLight;

		private Reference.Forms.FormCableAdd.NullableNumericUpDown numericUpDownWiresLight;

		private ControlsLbr.NullableNumericUpDown numericUpDownCrossSection;
	}
}
