namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class FormShinaProperties : global::System.Windows.Forms.Form
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
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.radioBtnTextNew = new global::System.Windows.Forms.RadioButton();
			this.radioBtnTextBase = new global::System.Windows.Forms.RadioButton();
			this.cmbTextBase = new global::System.Windows.Forms.ComboBox();
			this.dataSet_1 = new global::System.Data.DataSet();
			this.dataTable_2 = new global::System.Data.DataTable();
			this.dataColumn_7 = new global::System.Data.DataColumn();
			this.dataColumn_8 = new global::System.Data.DataColumn();
			this.dataColumn_9 = new global::System.Data.DataColumn();
			this.dataColumn_10 = new global::System.Data.DataColumn();
			this.dataColumn_11 = new global::System.Data.DataColumn();
			this.numericUpDownTextNew = new global::System.Windows.Forms.NumericUpDown();
			this.radioButtonB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonRight = new global::System.Windows.Forms.RadioButton();
			this.radioButtonLeft = new global::System.Windows.Forms.RadioButton();
			this.radioButtonNotVisible = new global::System.Windows.Forms.RadioButton();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.comboBoxTP = new global::System.Windows.Forms.ComboBox();
			this.panelColor = new global::System.Windows.Forms.Panel();
			this.labelColor = new global::System.Windows.Forms.Label();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.colorDialog_0 = new global::System.Windows.Forms.ColorDialog();
			this.dataSet_0 = new global::System.Data.DataSet();
			this.dataTable_0 = new global::System.Data.DataTable();
			this.dataColumn_0 = new global::System.Data.DataColumn();
			this.dataColumn_1 = new global::System.Data.DataColumn();
			this.dataTable_1 = new global::System.Data.DataTable();
			this.dataColumn_2 = new global::System.Data.DataColumn();
			this.dataColumn_3 = new global::System.Data.DataColumn();
			this.dataColumn_4 = new global::System.Data.DataColumn();
			this.dataColumn_5 = new global::System.Data.DataColumn();
			this.dataColumn_6 = new global::System.Data.DataColumn();
			this.radioButtonOn = new global::System.Windows.Forms.RadioButton();
			this.radioButtonOff = new global::System.Windows.Forms.RadioButton();
			this.labelVolt = new global::System.Windows.Forms.Label();
			this.comboBoxVolt = new global::System.Windows.Forms.ComboBox();
			this.radioButtonNoVolt = new global::System.Windows.Forms.RadioButton();
			this.radioButtonVoltL = new global::System.Windows.Forms.RadioButton();
			this.radioButtonVoltR = new global::System.Windows.Forms.RadioButton();
			this.groupBoxAmp = new global::System.Windows.Forms.GroupBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.cmbParentBus = new global::System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataSet_1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownTextNew).BeginInit();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataSet_0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_1).BeginInit();
			this.groupBoxAmp.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.radioButtonB);
			this.groupBox1.Controls.Add(this.radioButtonT);
			this.groupBox1.Controls.Add(this.radioButtonRight);
			this.groupBox1.Controls.Add(this.radioButtonLeft);
			this.groupBox1.Controls.Add(this.radioButtonNotVisible);
			this.groupBox1.Location = new global::System.Drawing.Point(1, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(251, 120);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Номер";
			this.groupBox3.Controls.Add(this.radioBtnTextNew);
			this.groupBox3.Controls.Add(this.radioBtnTextBase);
			this.groupBox3.Controls.Add(this.cmbTextBase);
			this.groupBox3.Controls.Add(this.numericUpDownTextNew);
			this.groupBox3.Location = new global::System.Drawing.Point(0, 11);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(90, 109);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.radioBtnTextNew.AutoSize = true;
			this.radioBtnTextNew.Location = new global::System.Drawing.Point(6, 58);
			this.radioBtnTextNew.Name = "radioBtnTextNew";
			this.radioBtnTextNew.Size = new global::System.Drawing.Size(80, 17);
			this.radioBtnTextNew.TabIndex = 10;
			this.radioBtnTextNew.Text = "Новое имя";
			this.radioBtnTextNew.UseVisualStyleBackColor = true;
			this.radioBtnTextBase.AutoSize = true;
			this.radioBtnTextBase.Checked = true;
			this.radioBtnTextBase.Location = new global::System.Drawing.Point(6, 9);
			this.radioBtnTextBase.Name = "radioBtnTextBase";
			this.radioBtnTextBase.Size = new global::System.Drawing.Size(68, 17);
			this.radioBtnTextBase.TabIndex = 9;
			this.radioBtnTextBase.TabStop = true;
			this.radioBtnTextBase.Text = "Из базы";
			this.radioBtnTextBase.UseVisualStyleBackColor = true;
			this.radioBtnTextBase.CheckedChanged += new global::System.EventHandler(this.radioBtnTextBase_CheckedChanged);
			this.cmbTextBase.DataSource = this.dataSet_1;
			this.cmbTextBase.DisplayMember = "tSchm_ObjList.Name";
			this.cmbTextBase.FormattingEnabled = true;
			this.cmbTextBase.Location = new global::System.Drawing.Point(11, 31);
			this.cmbTextBase.Name = "cmbTextBase";
			this.cmbTextBase.Size = new global::System.Drawing.Size(68, 21);
			this.cmbTextBase.TabIndex = 0;
			this.cmbTextBase.ValueMember = "tSchm_ObjList.ID";
			this.dataSet_1.DataSetName = "NewDataSet";
			this.dataSet_1.Tables.AddRange(new global::System.Data.DataTable[]
			{
				this.dataTable_2
			});
			this.dataTable_2.Columns.AddRange(new global::System.Data.DataColumn[]
			{
				this.dataColumn_7,
				this.dataColumn_8,
				this.dataColumn_9,
				this.dataColumn_10,
				this.dataColumn_11
			});
			this.dataTable_2.Constraints.AddRange(new global::System.Data.Constraint[]
			{
				new global::System.Data.UniqueConstraint("Constraint1", new string[]
				{
					"ID"
				}, true)
			});
			this.dataTable_2.PrimaryKey = new global::System.Data.DataColumn[]
			{
				this.dataColumn_7
			};
			this.dataTable_2.TableName = "tSchm_ObjList";
			this.dataColumn_7.AllowDBNull = false;
			this.dataColumn_7.AutoIncrement = true;
			this.dataColumn_7.Caption = "ID";
			this.dataColumn_7.ColumnName = "ID";
			this.dataColumn_7.DataType = typeof(int);
			this.dataColumn_8.ColumnName = "Name";
			this.dataColumn_9.ColumnName = "TypeCodeId";
			this.dataColumn_9.DataType = typeof(int);
			this.dataColumn_10.ColumnName = "Deleted";
			this.dataColumn_10.DataType = typeof(bool);
			this.dataColumn_11.ColumnName = "IdParent";
			this.dataColumn_11.DataType = typeof(int);
			this.numericUpDownTextNew.Enabled = false;
			this.numericUpDownTextNew.Location = new global::System.Drawing.Point(11, 81);
			this.numericUpDownTextNew.Name = "numericUpDownTextNew";
			this.numericUpDownTextNew.Size = new global::System.Drawing.Size(68, 20);
			this.numericUpDownTextNew.TabIndex = 8;
			this.radioButtonB.AutoSize = true;
			this.radioButtonB.Location = new global::System.Drawing.Point(137, 69);
			this.radioButtonB.Name = "radioButtonB";
			this.radioButtonB.Size = new global::System.Drawing.Size(54, 17);
			this.radioButtonB.TabIndex = 5;
			this.radioButtonB.TabStop = true;
			this.radioButtonB.Text = "снизу";
			this.radioButtonB.UseVisualStyleBackColor = true;
			this.radioButtonT.AutoSize = true;
			this.radioButtonT.Location = new global::System.Drawing.Point(137, 23);
			this.radioButtonT.Name = "radioButtonT";
			this.radioButtonT.Size = new global::System.Drawing.Size(59, 17);
			this.radioButtonT.TabIndex = 4;
			this.radioButtonT.TabStop = true;
			this.radioButtonT.Text = "сверху";
			this.radioButtonT.UseVisualStyleBackColor = true;
			this.radioButtonRight.AutoSize = true;
			this.radioButtonRight.Location = new global::System.Drawing.Point(176, 46);
			this.radioButtonRight.Name = "radioButtonRight";
			this.radioButtonRight.Size = new global::System.Drawing.Size(61, 17);
			this.radioButtonRight.TabIndex = 3;
			this.radioButtonRight.TabStop = true;
			this.radioButtonRight.Text = "справа";
			this.radioButtonRight.UseVisualStyleBackColor = true;
			this.radioButtonLeft.AutoSize = true;
			this.radioButtonLeft.Location = new global::System.Drawing.Point(96, 46);
			this.radioButtonLeft.Name = "radioButtonLeft";
			this.radioButtonLeft.Size = new global::System.Drawing.Size(55, 17);
			this.radioButtonLeft.TabIndex = 2;
			this.radioButtonLeft.TabStop = true;
			this.radioButtonLeft.Text = "слева";
			this.radioButtonLeft.UseVisualStyleBackColor = true;
			this.radioButtonNotVisible.AutoSize = true;
			this.radioButtonNotVisible.Location = new global::System.Drawing.Point(112, 94);
			this.radioButtonNotVisible.Name = "radioButtonNotVisible";
			this.radioButtonNotVisible.Size = new global::System.Drawing.Size(100, 17);
			this.radioButtonNotVisible.TabIndex = 1;
			this.radioButtonNotVisible.TabStop = true;
			this.radioButtonNotVisible.Text = "не отображать";
			this.radioButtonNotVisible.UseVisualStyleBackColor = true;
			this.groupBox2.Controls.Add(this.comboBoxTP);
			this.groupBox2.Location = new global::System.Drawing.Point(1, 127);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(251, 46);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Шина в группе";
			this.comboBoxTP.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTP.FormattingEnabled = true;
			this.comboBoxTP.Location = new global::System.Drawing.Point(11, 19);
			this.comboBoxTP.Name = "comboBoxTP";
			this.comboBoxTP.Size = new global::System.Drawing.Size(234, 21);
			this.comboBoxTP.TabIndex = 0;
			this.comboBoxTP.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxTP_SelectedIndexChanged);
			this.panelColor.Location = new global::System.Drawing.Point(258, 21);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new global::System.Drawing.Size(95, 20);
			this.panelColor.TabIndex = 8;
			this.panelColor.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDoubleClick);
			this.labelColor.AutoSize = true;
			this.labelColor.Location = new global::System.Drawing.Point(258, 5);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new global::System.Drawing.Size(32, 13);
			this.labelColor.TabIndex = 7;
			this.labelColor.Text = "Цвет";
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(15, 267);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 9;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(278, 267);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 10;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Tables.AddRange(new global::System.Data.DataTable[]
			{
				this.dataTable_0,
				this.dataTable_1
			});
			this.dataTable_0.Columns.AddRange(new global::System.Data.DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1
			});
			this.dataTable_0.TableName = "tR_Classifier";
			this.dataColumn_0.ColumnName = "ID";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_1.ColumnName = "name";
			this.dataTable_1.Columns.AddRange(new global::System.Data.DataColumn[]
			{
				this.dataColumn_2,
				this.dataColumn_3,
				this.dataColumn_4,
				this.dataColumn_5,
				this.dataColumn_6
			});
			this.dataTable_1.Constraints.AddRange(new global::System.Data.Constraint[]
			{
				new global::System.Data.UniqueConstraint("Constraint1", new string[]
				{
					"ID"
				}, true)
			});
			this.dataTable_1.PrimaryKey = new global::System.Data.DataColumn[]
			{
				this.dataColumn_2
			};
			this.dataTable_1.TableName = "tSchm_ObjList";
			this.dataColumn_2.AllowDBNull = false;
			this.dataColumn_2.AutoIncrement = true;
			this.dataColumn_2.Caption = "ID";
			this.dataColumn_2.ColumnName = "ID";
			this.dataColumn_2.DataType = typeof(int);
			this.dataColumn_3.ColumnName = "Name";
			this.dataColumn_4.ColumnName = "TypeCodeId";
			this.dataColumn_4.DataType = typeof(int);
			this.dataColumn_5.ColumnName = "Deleted";
			this.dataColumn_5.DataType = typeof(bool);
			this.dataColumn_6.ColumnName = "IdParent";
			this.dataColumn_6.DataType = typeof(int);
			this.radioButtonOn.AutoSize = true;
			this.radioButtonOn.Location = new global::System.Drawing.Point(6, 19);
			this.radioButtonOn.Name = "radioButtonOn";
			this.radioButtonOn.Size = new global::System.Drawing.Size(44, 17);
			this.radioButtonOn.TabIndex = 11;
			this.radioButtonOn.Text = "Вкл";
			this.radioButtonOn.UseVisualStyleBackColor = true;
			this.radioButtonOff.AutoSize = true;
			this.radioButtonOff.Location = new global::System.Drawing.Point(6, 36);
			this.radioButtonOff.Name = "radioButtonOff";
			this.radioButtonOff.Size = new global::System.Drawing.Size(52, 17);
			this.radioButtonOff.TabIndex = 11;
			this.radioButtonOff.Text = "Выкл";
			this.radioButtonOff.UseVisualStyleBackColor = true;
			this.labelVolt.AutoSize = true;
			this.labelVolt.Location = new global::System.Drawing.Point(9, 176);
			this.labelVolt.Name = "labelVolt";
			this.labelVolt.Size = new global::System.Drawing.Size(37, 13);
			this.labelVolt.TabIndex = 12;
			this.labelVolt.Text = "Вольт";
			this.comboBoxVolt.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVolt.FormattingEnabled = true;
			this.comboBoxVolt.Location = new global::System.Drawing.Point(12, 192);
			this.comboBoxVolt.Name = "comboBoxVolt";
			this.comboBoxVolt.Size = new global::System.Drawing.Size(93, 21);
			this.comboBoxVolt.TabIndex = 13;
			this.comboBoxVolt.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxVolt_SelectedIndexChanged);
			this.radioButtonNoVolt.AutoSize = true;
			this.radioButtonNoVolt.Checked = true;
			this.radioButtonNoVolt.Location = new global::System.Drawing.Point(138, 176);
			this.radioButtonNoVolt.Name = "radioButtonNoVolt";
			this.radioButtonNoVolt.Size = new global::System.Drawing.Size(100, 17);
			this.radioButtonNoVolt.TabIndex = 14;
			this.radioButtonNoVolt.TabStop = true;
			this.radioButtonNoVolt.Text = "не отображать";
			this.radioButtonNoVolt.UseVisualStyleBackColor = true;
			this.radioButtonVoltL.AutoSize = true;
			this.radioButtonVoltL.Location = new global::System.Drawing.Point(113, 193);
			this.radioButtonVoltL.Name = "radioButtonVoltL";
			this.radioButtonVoltL.Size = new global::System.Drawing.Size(55, 17);
			this.radioButtonVoltL.TabIndex = 15;
			this.radioButtonVoltL.Text = "слева";
			this.radioButtonVoltL.UseVisualStyleBackColor = true;
			this.radioButtonVoltR.AutoSize = true;
			this.radioButtonVoltR.Location = new global::System.Drawing.Point(185, 193);
			this.radioButtonVoltR.Name = "radioButtonVoltR";
			this.radioButtonVoltR.Size = new global::System.Drawing.Size(61, 17);
			this.radioButtonVoltR.TabIndex = 16;
			this.radioButtonVoltR.Text = "справа";
			this.radioButtonVoltR.UseVisualStyleBackColor = true;
			this.groupBoxAmp.Controls.Add(this.radioButtonOff);
			this.groupBoxAmp.Controls.Add(this.radioButtonOn);
			this.groupBoxAmp.Location = new global::System.Drawing.Point(258, 47);
			this.groupBoxAmp.Name = "groupBoxAmp";
			this.groupBoxAmp.Size = new global::System.Drawing.Size(95, 74);
			this.groupBoxAmp.TabIndex = 17;
			this.groupBoxAmp.TabStop = false;
			this.groupBoxAmp.Text = "Напряжение";
			this.groupBoxAmp.Visible = false;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 216);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(86, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Основная шина";
			this.cmbParentBus.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbParentBus.FormattingEnabled = true;
			this.cmbParentBus.Location = new global::System.Drawing.Point(12, 232);
			this.cmbParentBus.Name = "cmbParentBus";
			this.cmbParentBus.Size = new global::System.Drawing.Size(234, 21);
			this.cmbParentBus.TabIndex = 19;
			this.cmbParentBus.SelectedValueChanged += new global::System.EventHandler(this.cmbParentBus_SelectedValueChanged);
			this.cmbParentBus.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.cmbParentBus_KeyDown);
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(360, 293);
			base.Controls.Add(this.cmbParentBus);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.groupBoxAmp);
			base.Controls.Add(this.radioButtonVoltR);
			base.Controls.Add(this.radioButtonVoltL);
			base.Controls.Add(this.radioButtonNoVolt);
			base.Controls.Add(this.comboBoxVolt);
			base.Controls.Add(this.labelVolt);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.panelColor);
			base.Controls.Add(this.labelColor);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.Name = "FormShinaProperties";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Свойства шины";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FormShinaProperties_FormClosing);
			base.Load += new global::System.EventHandler(this.FormShinaProperties_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataSet_1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownTextNew).EndInit();
			this.groupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataSet_0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_1).EndInit();
			this.groupBoxAmp.ResumeLayout(false);
			this.groupBoxAmp.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.ComboBox cmbTextBase;

		private global::System.Windows.Forms.RadioButton radioButtonRight;

		private global::System.Windows.Forms.RadioButton radioButtonLeft;

		private global::System.Windows.Forms.RadioButton radioButtonNotVisible;

		private global::System.Windows.Forms.GroupBox groupBox2;

		private global::System.Windows.Forms.ComboBox comboBoxTP;

		private global::System.Windows.Forms.Panel panelColor;

		private global::System.Windows.Forms.Label labelColor;

		private global::System.Windows.Forms.Button buttonOK;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::System.Windows.Forms.ColorDialog colorDialog_0;

		private global::System.Windows.Forms.RadioButton radioButtonT;

		private global::System.Windows.Forms.RadioButton radioButtonB;

		private global::System.Data.DataSet dataSet_0;

		private global::System.Data.DataTable dataTable_0;

		private global::System.Data.DataColumn dataColumn_0;

		private global::System.Data.DataColumn dataColumn_1;

		private global::System.Data.DataTable dataTable_1;

		private global::System.Data.DataColumn dataColumn_2;

		private global::System.Data.DataColumn dataColumn_3;

		private global::System.Data.DataColumn dataColumn_4;

		private global::System.Data.DataColumn dataColumn_5;

		private global::System.Data.DataColumn dataColumn_6;

		private global::System.Windows.Forms.RadioButton radioButtonOn;

		private global::System.Windows.Forms.RadioButton radioButtonOff;

		private global::System.Windows.Forms.Label labelVolt;

		private global::System.Windows.Forms.ComboBox comboBoxVolt;

		private global::System.Windows.Forms.RadioButton radioButtonNoVolt;

		private global::System.Windows.Forms.RadioButton radioButtonVoltL;

		private global::System.Windows.Forms.RadioButton radioButtonVoltR;

		private global::System.Windows.Forms.GroupBox groupBox3;

		private global::System.Windows.Forms.RadioButton radioBtnTextNew;

		private global::System.Windows.Forms.RadioButton radioBtnTextBase;

		private global::System.Windows.Forms.NumericUpDown numericUpDownTextNew;

		private global::System.Data.DataSet dataSet_1;

		private global::System.Data.DataTable dataTable_2;

		private global::System.Data.DataColumn dataColumn_7;

		private global::System.Data.DataColumn dataColumn_8;

		private global::System.Data.DataColumn dataColumn_9;

		private global::System.Data.DataColumn dataColumn_10;

		private global::System.Data.DataColumn dataColumn_11;

		private global::System.Windows.Forms.GroupBox groupBoxAmp;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.ComboBox cmbParentBus;
	}
}
