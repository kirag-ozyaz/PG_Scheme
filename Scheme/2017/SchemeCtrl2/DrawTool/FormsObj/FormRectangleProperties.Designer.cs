namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class FormRectangleProperties : global::System.Windows.Forms.Form
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
			this.labelTextObj = new global::System.Windows.Forms.Label();
			this.textBoxTextObj = new global::System.Windows.Forms.TextBox();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.comboBoxExistTP = new global::System.Windows.Forms.ComboBox();
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
			this.radioButtonExistTP = new global::System.Windows.Forms.RadioButton();
			this.radioButtonNewStation = new global::System.Windows.Forms.RadioButton();
			this.cmbType = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.radioButtonNotVisible = new global::System.Windows.Forms.RadioButton();
			this.radioButtonRB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonR = new global::System.Windows.Forms.RadioButton();
			this.radioButtonRT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonLB = new global::System.Windows.Forms.RadioButton();
			this.radioButtonL = new global::System.Windows.Forms.RadioButton();
			this.radioButtonLT = new global::System.Windows.Forms.RadioButton();
			this.radioButtonT = new global::System.Windows.Forms.RadioButton();
			this.labelColor = new global::System.Windows.Forms.Label();
			this.colorDialog_0 = new global::System.Windows.Forms.ColorDialog();
			this.panelColor = new global::System.Windows.Forms.Panel();
			this.fontDialog_0 = new global::System.Windows.Forms.FontDialog();
			this.buttonFont = new global::System.Windows.Forms.Button();
			this.groupBoxTextDirect = new global::System.Windows.Forms.GroupBox();
			this.radioButtonVertical = new global::System.Windows.Forms.RadioButton();
			this.radioButtonGorizontal = new global::System.Windows.Forms.RadioButton();
			this.groupBoxOrientation = new global::System.Windows.Forms.GroupBox();
			this.groupBoxSettingsDB = new global::System.Windows.Forms.GroupBox();
			this.checkBoxSettingDB = new global::System.Windows.Forms.CheckBox();
			this.checkBoxSubscriber = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataSet_0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_1).BeginInit();
			this.groupBoxTextDirect.SuspendLayout();
			this.groupBoxOrientation.SuspendLayout();
			this.groupBoxSettingsDB.SuspendLayout();
			base.SuspendLayout();
			this.labelTextObj.AutoSize = true;
			this.labelTextObj.Location = new global::System.Drawing.Point(3, 56);
			this.labelTextObj.Name = "labelTextObj";
			this.labelTextObj.Size = new global::System.Drawing.Size(37, 13);
			this.labelTextObj.TabIndex = 0;
			this.labelTextObj.Text = "Текст";
			this.textBoxTextObj.Location = new global::System.Drawing.Point(6, 140);
			this.textBoxTextObj.Name = "textBoxTextObj";
			this.textBoxTextObj.Size = new global::System.Drawing.Size(209, 20);
			this.textBoxTextObj.TabIndex = 1;
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(7, 276);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(280, 276);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.comboBoxExistTP);
			this.groupBox1.Controls.Add(this.radioButtonExistTP);
			this.groupBox1.Controls.Add(this.radioButtonNewStation);
			this.groupBox1.Controls.Add(this.cmbType);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBoxTextObj);
			this.groupBox1.Controls.Add(this.labelTextObj);
			this.groupBox1.Location = new global::System.Drawing.Point(1, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(221, 268);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Имя";
			this.comboBoxExistTP.DataSource = this.dataSet_0;
			this.comboBoxExistTP.DisplayMember = "tSchm_ObjList.Name";
			this.comboBoxExistTP.Enabled = false;
			this.comboBoxExistTP.FormattingEnabled = true;
			this.comboBoxExistTP.Location = new global::System.Drawing.Point(6, 95);
			this.comboBoxExistTP.Name = "comboBoxExistTP";
			this.comboBoxExistTP.Size = new global::System.Drawing.Size(209, 21);
			this.comboBoxExistTP.TabIndex = 17;
			this.comboBoxExistTP.ValueMember = "tSchm_ObjList.ID";
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
			this.radioButtonExistTP.AutoSize = true;
			this.radioButtonExistTP.Enabled = false;
			this.radioButtonExistTP.Location = new global::System.Drawing.Point(6, 72);
			this.radioButtonExistTP.Name = "radioButtonExistTP";
			this.radioButtonExistTP.Size = new global::System.Drawing.Size(122, 17);
			this.radioButtonExistTP.TabIndex = 16;
			this.radioButtonExistTP.Text = "Подстанции в базе";
			this.radioButtonExistTP.UseVisualStyleBackColor = true;
			this.radioButtonExistTP.CheckedChanged += new global::System.EventHandler(this.radioButtonExistTP_CheckedChanged);
			this.radioButtonNewStation.AutoSize = true;
			this.radioButtonNewStation.Checked = true;
			this.radioButtonNewStation.Location = new global::System.Drawing.Point(6, 121);
			this.radioButtonNewStation.Name = "radioButtonNewStation";
			this.radioButtonNewStation.Size = new global::System.Drawing.Size(142, 17);
			this.radioButtonNewStation.TabIndex = 14;
			this.radioButtonNewStation.TabStop = true;
			this.radioButtonNewStation.Text = "Имя новой подстанции";
			this.radioButtonNewStation.UseVisualStyleBackColor = true;
			this.cmbType.DataSource = this.dataSet_0;
			this.cmbType.DisplayMember = "tR_Classifier.name";
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Location = new global::System.Drawing.Point(6, 32);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new global::System.Drawing.Size(209, 21);
			this.cmbType.TabIndex = 12;
			this.cmbType.ValueMember = "tR_Classifier.ID";
			this.cmbType.SelectedIndexChanged += new global::System.EventHandler(this.oOyAhwAlKY);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(3, 16);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(26, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Тип";
			this.radioButtonNotVisible.AutoSize = true;
			this.radioButtonNotVisible.Location = new global::System.Drawing.Point(134, 33);
			this.radioButtonNotVisible.Name = "radioButtonNotVisible";
			this.radioButtonNotVisible.Size = new global::System.Drawing.Size(85, 30);
			this.radioButtonNotVisible.TabIndex = 10;
			this.radioButtonNotVisible.TabStop = true;
			this.radioButtonNotVisible.Text = "не \r\nотображать";
			this.radioButtonNotVisible.UseVisualStyleBackColor = true;
			this.radioButtonRB.AutoSize = true;
			this.radioButtonRB.Location = new global::System.Drawing.Point(88, 65);
			this.radioButtonRB.Name = "radioButtonRB";
			this.radioButtonRB.Size = new global::System.Drawing.Size(40, 17);
			this.radioButtonRB.TabIndex = 9;
			this.radioButtonRB.TabStop = true;
			this.radioButtonRB.Text = "RB";
			this.radioButtonRB.UseVisualStyleBackColor = true;
			this.radioButtonR.AutoSize = true;
			this.radioButtonR.Location = new global::System.Drawing.Point(88, 42);
			this.radioButtonR.Name = "radioButtonR";
			this.radioButtonR.Size = new global::System.Drawing.Size(33, 17);
			this.radioButtonR.TabIndex = 8;
			this.radioButtonR.TabStop = true;
			this.radioButtonR.Text = "R";
			this.radioButtonR.UseVisualStyleBackColor = true;
			this.radioButtonRT.AutoSize = true;
			this.radioButtonRT.Location = new global::System.Drawing.Point(88, 19);
			this.radioButtonRT.Name = "radioButtonRT";
			this.radioButtonRT.Size = new global::System.Drawing.Size(40, 17);
			this.radioButtonRT.TabIndex = 7;
			this.radioButtonRT.TabStop = true;
			this.radioButtonRT.Text = "RT";
			this.radioButtonRT.UseVisualStyleBackColor = true;
			this.radioButtonB.AutoSize = true;
			this.radioButtonB.Location = new global::System.Drawing.Point(50, 65);
			this.radioButtonB.Name = "radioButtonB";
			this.radioButtonB.Size = new global::System.Drawing.Size(32, 17);
			this.radioButtonB.TabIndex = 6;
			this.radioButtonB.TabStop = true;
			this.radioButtonB.Text = "B";
			this.radioButtonB.UseVisualStyleBackColor = true;
			this.radioButtonLB.AutoSize = true;
			this.radioButtonLB.Location = new global::System.Drawing.Point(6, 65);
			this.radioButtonLB.Name = "radioButtonLB";
			this.radioButtonLB.Size = new global::System.Drawing.Size(38, 17);
			this.radioButtonLB.TabIndex = 5;
			this.radioButtonLB.TabStop = true;
			this.radioButtonLB.Text = "LB";
			this.radioButtonLB.UseVisualStyleBackColor = true;
			this.radioButtonL.AutoSize = true;
			this.radioButtonL.Location = new global::System.Drawing.Point(6, 42);
			this.radioButtonL.Name = "radioButtonL";
			this.radioButtonL.Size = new global::System.Drawing.Size(31, 17);
			this.radioButtonL.TabIndex = 4;
			this.radioButtonL.TabStop = true;
			this.radioButtonL.Text = "L";
			this.radioButtonL.UseVisualStyleBackColor = true;
			this.radioButtonLT.AutoSize = true;
			this.radioButtonLT.Location = new global::System.Drawing.Point(6, 19);
			this.radioButtonLT.Name = "radioButtonLT";
			this.radioButtonLT.Size = new global::System.Drawing.Size(38, 17);
			this.radioButtonLT.TabIndex = 3;
			this.radioButtonLT.TabStop = true;
			this.radioButtonLT.Text = "LT";
			this.radioButtonLT.UseVisualStyleBackColor = true;
			this.radioButtonT.AutoSize = true;
			this.radioButtonT.Location = new global::System.Drawing.Point(50, 19);
			this.radioButtonT.Name = "radioButtonT";
			this.radioButtonT.Size = new global::System.Drawing.Size(32, 17);
			this.radioButtonT.TabIndex = 2;
			this.radioButtonT.TabStop = true;
			this.radioButtonT.Text = "T";
			this.radioButtonT.UseVisualStyleBackColor = true;
			this.labelColor.AutoSize = true;
			this.labelColor.Location = new global::System.Drawing.Point(6, 36);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new global::System.Drawing.Size(77, 13);
			this.labelColor.TabIndex = 5;
			this.labelColor.Text = "Цвет объекта";
			this.panelColor.Location = new global::System.Drawing.Point(6, 52);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new global::System.Drawing.Size(95, 20);
			this.panelColor.TabIndex = 6;
			this.panelColor.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDoubleClick);
			this.fontDialog_0.ShowColor = true;
			this.buttonFont.Location = new global::System.Drawing.Point(6, 78);
			this.buttonFont.Name = "buttonFont";
			this.buttonFont.Size = new global::System.Drawing.Size(95, 23);
			this.buttonFont.TabIndex = 7;
			this.buttonFont.Text = "Шрифт";
			this.buttonFont.UseVisualStyleBackColor = true;
			this.buttonFont.Click += new global::System.EventHandler(this.buttonFont_Click);
			this.groupBoxTextDirect.AutoSize = true;
			this.groupBoxTextDirect.Controls.Add(this.radioButtonVertical);
			this.groupBoxTextDirect.Controls.Add(this.radioButtonGorizontal);
			this.groupBoxTextDirect.Location = new global::System.Drawing.Point(228, 122);
			this.groupBoxTextDirect.Name = "groupBoxTextDirect";
			this.groupBoxTextDirect.Size = new global::System.Drawing.Size(127, 77);
			this.groupBoxTextDirect.TabIndex = 8;
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
			this.groupBoxOrientation.Controls.Add(this.radioButtonLT);
			this.groupBoxOrientation.Controls.Add(this.radioButtonT);
			this.groupBoxOrientation.Controls.Add(this.radioButtonL);
			this.groupBoxOrientation.Controls.Add(this.radioButtonNotVisible);
			this.groupBoxOrientation.Controls.Add(this.radioButtonLB);
			this.groupBoxOrientation.Controls.Add(this.radioButtonRB);
			this.groupBoxOrientation.Controls.Add(this.radioButtonB);
			this.groupBoxOrientation.Controls.Add(this.radioButtonR);
			this.groupBoxOrientation.Controls.Add(this.radioButtonRT);
			this.groupBoxOrientation.Location = new global::System.Drawing.Point(1, 178);
			this.groupBoxOrientation.Name = "groupBoxOrientation";
			this.groupBoxOrientation.Size = new global::System.Drawing.Size(221, 92);
			this.groupBoxOrientation.TabIndex = 13;
			this.groupBoxOrientation.TabStop = false;
			this.groupBoxOrientation.Text = "Ориентация";
			this.groupBoxSettingsDB.Controls.Add(this.checkBoxSettingDB);
			this.groupBoxSettingsDB.Controls.Add(this.labelColor);
			this.groupBoxSettingsDB.Controls.Add(this.buttonFont);
			this.groupBoxSettingsDB.Controls.Add(this.panelColor);
			this.groupBoxSettingsDB.Location = new global::System.Drawing.Point(228, 2);
			this.groupBoxSettingsDB.Name = "groupBoxSettingsDB";
			this.groupBoxSettingsDB.Size = new global::System.Drawing.Size(127, 114);
			this.groupBoxSettingsDB.TabIndex = 14;
			this.groupBoxSettingsDB.TabStop = false;
			this.checkBoxSettingDB.AutoSize = true;
			this.checkBoxSettingDB.Location = new global::System.Drawing.Point(6, 16);
			this.checkBoxSettingDB.Name = "checkBoxSettingDB";
			this.checkBoxSettingDB.Size = new global::System.Drawing.Size(110, 17);
			this.checkBoxSettingDB.TabIndex = 0;
			this.checkBoxSettingDB.Text = "Свойства схемы";
			this.checkBoxSettingDB.UseVisualStyleBackColor = true;
			this.checkBoxSettingDB.CheckedChanged += new global::System.EventHandler(this.checkBoxSettingDB_CheckedChanged);
			this.checkBoxSubscriber.AutoSize = true;
			this.checkBoxSubscriber.Enabled = false;
			this.checkBoxSubscriber.Location = new global::System.Drawing.Point(228, 205);
			this.checkBoxSubscriber.Name = "checkBoxSubscriber";
			this.checkBoxSubscriber.Size = new global::System.Drawing.Size(92, 17);
			this.checkBoxSubscriber.TabIndex = 15;
			this.checkBoxSubscriber.Text = "Абонентская";
			this.checkBoxSubscriber.UseVisualStyleBackColor = true;
			this.label2.Enabled = false;
			this.label2.Location = new global::System.Drawing.Point(228, 228);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(124, 42);
			this.label2.TabIndex = 16;
			this.label2.Text = "Свойство назначается через паспорт объекта";
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(364, 311);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.checkBoxSubscriber);
			base.Controls.Add(this.groupBoxSettingsDB);
			base.Controls.Add(this.groupBoxTextDirect);
			base.Controls.Add(this.groupBoxOrientation);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "FormRectangleProperties";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Свойство прямоугольника";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FormRectangleProperties_FormClosing);
			base.Load += new global::System.EventHandler(this.FormRectangleProperties_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataSet_0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_1).EndInit();
			this.groupBoxTextDirect.ResumeLayout(false);
			this.groupBoxTextDirect.PerformLayout();
			this.groupBoxOrientation.ResumeLayout(false);
			this.groupBoxOrientation.PerformLayout();
			this.groupBoxSettingsDB.ResumeLayout(false);
			this.groupBoxSettingsDB.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer icontainer_0;

		private global::System.Windows.Forms.Label labelTextObj;

		private global::System.Windows.Forms.TextBox textBoxTextObj;

		private global::System.Windows.Forms.Button buttonOK;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.RadioButton radioButtonL;

		private global::System.Windows.Forms.RadioButton radioButtonLT;

		private global::System.Windows.Forms.RadioButton radioButtonT;

		private global::System.Windows.Forms.RadioButton radioButtonNotVisible;

		private global::System.Windows.Forms.RadioButton radioButtonRB;

		private global::System.Windows.Forms.RadioButton radioButtonR;

		private global::System.Windows.Forms.RadioButton radioButtonRT;

		private global::System.Windows.Forms.RadioButton radioButtonB;

		private global::System.Windows.Forms.RadioButton radioButtonLB;

		private global::System.Windows.Forms.Label labelColor;

		private global::System.Windows.Forms.ColorDialog colorDialog_0;

		private global::System.Windows.Forms.Panel panelColor;

		private global::System.Windows.Forms.ComboBox cmbType;

		private global::System.Windows.Forms.Label label1;

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

		private global::System.Windows.Forms.FontDialog fontDialog_0;

		private global::System.Windows.Forms.Button buttonFont;

		private global::System.Windows.Forms.GroupBox groupBoxTextDirect;

		private global::System.Windows.Forms.RadioButton radioButtonVertical;

		private global::System.Windows.Forms.RadioButton radioButtonGorizontal;

		private global::System.Windows.Forms.ComboBox comboBoxExistTP;

		private global::System.Windows.Forms.RadioButton radioButtonExistTP;

		private global::System.Windows.Forms.RadioButton radioButtonNewStation;

		private global::System.Windows.Forms.GroupBox groupBoxOrientation;

		private global::System.Windows.Forms.GroupBox groupBoxSettingsDB;

		private global::System.Windows.Forms.CheckBox checkBoxSettingDB;

		private global::System.Windows.Forms.CheckBox checkBoxSubscriber;

		private global::System.Windows.Forms.Label label2;
	}
}
