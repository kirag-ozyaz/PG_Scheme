namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class FormPointProperties : global::System.Windows.Forms.Form
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
			this.buttonFont = new global::System.Windows.Forms.Button();
			this.checkBoxUseSettingsText = new global::System.Windows.Forms.CheckBox();
			this.radioButtonRB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonRT = new global::System.Windows.Forms.RadioButton();
			this.labelColor = new global::System.Windows.Forms.Label();
			this.panelColor = new global::System.Windows.Forms.Panel();
			this.radioButtonNotVisible = new global::System.Windows.Forms.RadioButton();
			this.radioButtonLB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonLT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonRight = new global::System.Windows.Forms.RadioButton();
			this.radioButtonB = new global::System.Windows.Forms.RadioButton();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.radioButtonT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonLeft = new global::System.Windows.Forms.RadioButton();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.buttonOK = new global::System.Windows.Forms.Button();
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
			this.fontDialog_0 = new global::System.Windows.Forms.FontDialog();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataSet_0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_1).BeginInit();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.buttonFont);
			this.groupBox1.Controls.Add(this.checkBoxUseSettingsText);
			this.groupBox1.Controls.Add(this.radioButtonRB);
			this.groupBox1.Controls.Add(this.radioButtonRT);
			this.groupBox1.Controls.Add(this.labelColor);
			this.groupBox1.Controls.Add(this.panelColor);
			this.groupBox1.Controls.Add(this.radioButtonNotVisible);
			this.groupBox1.Controls.Add(this.radioButtonLB);
			this.groupBox1.Controls.Add(this.radioButtonLT);
			this.groupBox1.Controls.Add(this.radioButtonRight);
			this.groupBox1.Controls.Add(this.radioButtonB);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.radioButtonT);
			this.groupBox1.Controls.Add(this.radioButtonLeft);
			this.groupBox1.Location = new global::System.Drawing.Point(1, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(270, 154);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Текст";
			this.buttonFont.Location = new global::System.Drawing.Point(6, 105);
			this.buttonFont.Name = "buttonFont";
			this.buttonFont.Size = new global::System.Drawing.Size(117, 23);
			this.buttonFont.TabIndex = 12;
			this.buttonFont.Text = "Шрифт";
			this.buttonFont.UseVisualStyleBackColor = true;
			this.buttonFont.Click += new global::System.EventHandler(this.buttonFont_Click);
			this.checkBoxUseSettingsText.AutoSize = true;
			this.checkBoxUseSettingsText.Location = new global::System.Drawing.Point(6, 56);
			this.checkBoxUseSettingsText.Name = "checkBoxUseSettingsText";
			this.checkBoxUseSettingsText.Size = new global::System.Drawing.Size(117, 17);
			this.checkBoxUseSettingsText.TabIndex = 11;
			this.checkBoxUseSettingsText.Text = "Настройки схемы";
			this.checkBoxUseSettingsText.UseVisualStyleBackColor = true;
			this.checkBoxUseSettingsText.CheckedChanged += new global::System.EventHandler(this.checkBoxUseSettingsText_CheckedChanged);
			this.radioButtonRB.AutoSize = true;
			this.radioButtonRB.Location = new global::System.Drawing.Point(220, 56);
			this.radioButtonRB.Name = "radioButtonRB";
			this.radioButtonRB.Size = new global::System.Drawing.Size(40, 17);
			this.radioButtonRB.TabIndex = 10;
			this.radioButtonRB.TabStop = true;
			this.radioButtonRB.Text = "RB";
			this.radioButtonRB.UseVisualStyleBackColor = true;
			this.radioButtonRT.AutoSize = true;
			this.radioButtonRT.Location = new global::System.Drawing.Point(220, 10);
			this.radioButtonRT.Name = "radioButtonRT";
			this.radioButtonRT.Size = new global::System.Drawing.Size(40, 17);
			this.radioButtonRT.TabIndex = 9;
			this.radioButtonRT.TabStop = true;
			this.radioButtonRT.Text = "RT";
			this.radioButtonRT.UseVisualStyleBackColor = true;
			this.labelColor.AutoSize = true;
			this.labelColor.Location = new global::System.Drawing.Point(6, 79);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new global::System.Drawing.Size(32, 13);
			this.labelColor.TabIndex = 9;
			this.labelColor.Text = "Цвет";
			this.panelColor.Location = new global::System.Drawing.Point(38, 79);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new global::System.Drawing.Size(69, 20);
			this.panelColor.TabIndex = 10;
			this.panelColor.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDoubleClick);
			this.radioButtonNotVisible.AutoSize = true;
			this.radioButtonNotVisible.Location = new global::System.Drawing.Point(153, 79);
			this.radioButtonNotVisible.Name = "radioButtonNotVisible";
			this.radioButtonNotVisible.Size = new global::System.Drawing.Size(100, 17);
			this.radioButtonNotVisible.TabIndex = 1;
			this.radioButtonNotVisible.TabStop = true;
			this.radioButtonNotVisible.Text = "не отображать";
			this.radioButtonNotVisible.UseVisualStyleBackColor = true;
			this.radioButtonLB.AutoSize = true;
			this.radioButtonLB.Location = new global::System.Drawing.Point(138, 56);
			this.radioButtonLB.Name = "radioButtonLB";
			this.radioButtonLB.Size = new global::System.Drawing.Size(38, 17);
			this.radioButtonLB.TabIndex = 8;
			this.radioButtonLB.TabStop = true;
			this.radioButtonLB.Text = "LB";
			this.radioButtonLB.UseVisualStyleBackColor = true;
			this.radioButtonLT.AutoSize = true;
			this.radioButtonLT.Location = new global::System.Drawing.Point(138, 10);
			this.radioButtonLT.Name = "radioButtonLT";
			this.radioButtonLT.Size = new global::System.Drawing.Size(38, 17);
			this.radioButtonLT.TabIndex = 7;
			this.radioButtonLT.TabStop = true;
			this.radioButtonLT.Text = "LT";
			this.radioButtonLT.UseVisualStyleBackColor = true;
			this.radioButtonRight.AutoSize = true;
			this.radioButtonRight.Location = new global::System.Drawing.Point(220, 33);
			this.radioButtonRight.Name = "radioButtonRight";
			this.radioButtonRight.Size = new global::System.Drawing.Size(33, 17);
			this.radioButtonRight.TabIndex = 3;
			this.radioButtonRight.TabStop = true;
			this.radioButtonRight.Text = "R";
			this.radioButtonRight.UseVisualStyleBackColor = true;
			this.radioButtonB.AutoSize = true;
			this.radioButtonB.Location = new global::System.Drawing.Point(182, 56);
			this.radioButtonB.Name = "radioButtonB";
			this.radioButtonB.Size = new global::System.Drawing.Size(32, 17);
			this.radioButtonB.TabIndex = 5;
			this.radioButtonB.TabStop = true;
			this.radioButtonB.Text = "B";
			this.radioButtonB.UseVisualStyleBackColor = true;
			this.textBox1.Location = new global::System.Drawing.Point(6, 17);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(75, 20);
			this.textBox1.TabIndex = 6;
			this.radioButtonT.AutoSize = true;
			this.radioButtonT.Location = new global::System.Drawing.Point(182, 10);
			this.radioButtonT.Name = "radioButtonT";
			this.radioButtonT.Size = new global::System.Drawing.Size(32, 17);
			this.radioButtonT.TabIndex = 4;
			this.radioButtonT.TabStop = true;
			this.radioButtonT.Text = "T";
			this.radioButtonT.UseVisualStyleBackColor = true;
			this.radioButtonLeft.AutoSize = true;
			this.radioButtonLeft.Location = new global::System.Drawing.Point(138, 33);
			this.radioButtonLeft.Name = "radioButtonLeft";
			this.radioButtonLeft.Size = new global::System.Drawing.Size(31, 17);
			this.radioButtonLeft.TabIndex = 2;
			this.radioButtonLeft.TabStop = true;
			this.radioButtonLeft.Text = "L";
			this.radioButtonLeft.UseVisualStyleBackColor = true;
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(196, 166);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 12;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(1, 166);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 11;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
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
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(280, 201);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.groupBox1);
			base.Name = "FormPointProperties";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Свойство узла";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FormPointProperties_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataSet_0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_1).EndInit();
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.RadioButton radioButtonB;

		private global::System.Windows.Forms.RadioButton radioButtonT;

		private global::System.Windows.Forms.RadioButton radioButtonRight;

		private global::System.Windows.Forms.RadioButton radioButtonLeft;

		private global::System.Windows.Forms.RadioButton radioButtonNotVisible;

		private global::System.Windows.Forms.Panel panelColor;

		private global::System.Windows.Forms.Label labelColor;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::System.Windows.Forms.Button buttonOK;

		private global::System.Windows.Forms.ColorDialog colorDialog_0;

		private global::System.Windows.Forms.TextBox textBox1;

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

		private global::System.Windows.Forms.RadioButton radioButtonRB;

		private global::System.Windows.Forms.RadioButton radioButtonRT;

		private global::System.Windows.Forms.RadioButton radioButtonLB;

		private global::System.Windows.Forms.RadioButton radioButtonLT;

		private global::System.Windows.Forms.Button buttonFont;

		private global::System.Windows.Forms.CheckBox checkBoxUseSettingsText;

		private global::System.Windows.Forms.FontDialog fontDialog_0;
	}
}
