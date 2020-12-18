namespace Reference.Forms.MapObj
{
	public partial class FormMapObjAddEdit : FormLbr.FormBase
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
			this.labelObl = new System.Windows.Forms.Label();
			this.cmbObl = new System.Windows.Forms.ComboBox();
			this.dataSet_0 = new System.Data.DataSet();
			this.vCypyVusgP = new System.Data.DataTable();
			this.dataColumn_0 = new System.Data.DataColumn();
			this.qSmpwqZdyo = new System.Data.DataColumn();
			this.GjapFujsiQ = new System.Data.DataColumn();
			this.dataColumn_1 = new System.Data.DataColumn();
			this.labelRaionObl = new System.Windows.Forms.Label();
			this.cmbRaionObl = new System.Windows.Forms.ComboBox();
			this.dataSet_1 = new System.Data.DataSet();
			this.dataTable_0 = new System.Data.DataTable();
			this.dataColumn_2 = new System.Data.DataColumn();
			this.dataColumn_3 = new System.Data.DataColumn();
			this.dataColumn_4 = new System.Data.DataColumn();
			this.dataColumn_5 = new System.Data.DataColumn();
			this.labelCity = new System.Windows.Forms.Label();
			this.kEeIxoqAnO = new System.Windows.Forms.ComboBox();
			this.dataSet_2 = new System.Data.DataSet();
			this.dataTable_1 = new System.Data.DataTable();
			this.dataColumn_6 = new System.Data.DataColumn();
			this.dataColumn_7 = new System.Data.DataColumn();
			this.dataColumn_8 = new System.Data.DataColumn();
			this.dataColumn_9 = new System.Data.DataColumn();
			this.labelRaionCity = new System.Windows.Forms.Label();
			this.cmbRaionCity = new System.Windows.Forms.ComboBox();
			this.class20_0 = new Class20();
			this.labelStreet = new System.Windows.Forms.Label();
			this.cmbStreet = new System.Windows.Forms.ComboBox();
			this.dataSet_3 = new System.Data.DataSet();
			this.dataTable_2 = new System.Data.DataTable();
			this.dataColumn_10 = new System.Data.DataColumn();
			this.dataColumn_11 = new System.Data.DataColumn();
			this.dataColumn_12 = new System.Data.DataColumn();
			this.dataColumn_13 = new System.Data.DataColumn();
			this.labelHouse = new System.Windows.Forms.Label();
			this.txtHouse = new System.Windows.Forms.TextBox();
			this.labelHousePrefix = new System.Windows.Forms.Label();
			this.txtHousePrefix = new System.Windows.Forms.TextBox();
			this.labelIndex = new System.Windows.Forms.Label();
			this.txtIndex = new System.Windows.Forms.TextBox();
			this.checkBoxIsHouse = new System.Windows.Forms.CheckBox();
			this.groupBoxHouse = new System.Windows.Forms.GroupBox();
			this.lnapflutpA = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.groupBox_0 = new System.Windows.Forms.GroupBox();
			this.txtLongitude = new System.Windows.Forms.TextBox();
			this.labelLongitude = new System.Windows.Forms.Label();
			this.txtLatitude = new System.Windows.Forms.TextBox();
			this.labelLatitude = new System.Windows.Forms.Label();
			this.labelComment = new System.Windows.Forms.Label();
			this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.dataSet_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.vCypyVusgP).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class20_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_3).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_2).BeginInit();
			this.groupBoxHouse.SuspendLayout();
			this.groupBox_0.SuspendLayout();
			base.SuspendLayout();
			this.labelObl.AutoSize = true;
			this.labelObl.Location = new System.Drawing.Point(6, 16);
			this.labelObl.Name = "labelObl";
			this.labelObl.Size = new System.Drawing.Size(50, 13);
			this.labelObl.TabIndex = 0;
			this.labelObl.Text = "Область";
			this.cmbObl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbObl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbObl.DataSource = this.dataSet_0;
			this.cmbObl.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbObl.FormattingEnabled = true;
			this.cmbObl.Location = new System.Drawing.Point(9, 32);
			this.cmbObl.Name = "cmbObl";
			this.cmbObl.Size = new System.Drawing.Size(143, 21);
			this.cmbObl.TabIndex = 1;
			this.cmbObl.ValueMember = "tR_KladrObj.Id";
			this.cmbObl.SelectedIndexChanged += new System.EventHandler(this.cmbObl_SelectedIndexChanged);
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Tables.AddRange(new System.Data.DataTable[]
			{
				this.vCypyVusgP
			});
			this.vCypyVusgP.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn_0,
				this.qSmpwqZdyo,
				this.GjapFujsiQ,
				this.dataColumn_1
			});
			this.vCypyVusgP.TableName = "tR_KladrObj";
			this.dataColumn_0.ColumnName = "Id";
			this.dataColumn_0.DataType = typeof(int);
			this.qSmpwqZdyo.ColumnName = "Name";
			this.GjapFujsiQ.ColumnName = "Socr";
			this.dataColumn_1.ColumnName = "NameSocr";
			this.dataColumn_1.Expression = "Name + ' ' + isnull(socr, '')";
			this.dataColumn_1.ReadOnly = true;
			this.labelRaionObl.AutoSize = true;
			this.labelRaionObl.Location = new System.Drawing.Point(6, 56);
			this.labelRaionObl.Name = "labelRaionObl";
			this.labelRaionObl.Size = new System.Drawing.Size(72, 13);
			this.labelRaionObl.TabIndex = 2;
			this.labelRaionObl.Text = "Район/город";
			this.cmbRaionObl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbRaionObl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbRaionObl.DataSource = this.dataSet_1;
			this.cmbRaionObl.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbRaionObl.FormattingEnabled = true;
			this.cmbRaionObl.Location = new System.Drawing.Point(9, 72);
			this.cmbRaionObl.Name = "cmbRaionObl";
			this.cmbRaionObl.Size = new System.Drawing.Size(143, 21);
			this.cmbRaionObl.TabIndex = 3;
			this.cmbRaionObl.ValueMember = "tR_KladrObj.Id";
			this.cmbRaionObl.SelectedIndexChanged += new System.EventHandler(this.cmbRaionObl_SelectedIndexChanged);
			this.dataSet_1.DataSetName = "NewDataSet";
			this.dataSet_1.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dataTable_0
			});
			this.dataTable_0.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn_2,
				this.dataColumn_3,
				this.dataColumn_4,
				this.dataColumn_5
			});
			this.dataTable_0.TableName = "tR_KladrObj";
			this.dataColumn_2.ColumnName = "Id";
			this.dataColumn_2.DataType = typeof(int);
			this.dataColumn_3.ColumnName = "Name";
			this.dataColumn_4.ColumnName = "Socr";
			this.dataColumn_5.ColumnName = "NameSocr";
			this.dataColumn_5.Expression = "Name + ' ' + isnull(socr, '')";
			this.dataColumn_5.ReadOnly = true;
			this.labelCity.AutoSize = true;
			this.labelCity.Location = new System.Drawing.Point(6, 96);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(102, 13);
			this.labelCity.TabIndex = 4;
			this.labelCity.Text = "Населенный пункт";
			this.kEeIxoqAnO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.kEeIxoqAnO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.kEeIxoqAnO.DataSource = this.dataSet_2;
			this.kEeIxoqAnO.DisplayMember = "tR_KladrObj.NameSocr";
			this.kEeIxoqAnO.FormattingEnabled = true;
			this.kEeIxoqAnO.Location = new System.Drawing.Point(9, 112);
			this.kEeIxoqAnO.Name = "cmbCity";
			this.kEeIxoqAnO.Size = new System.Drawing.Size(143, 21);
			this.kEeIxoqAnO.TabIndex = 5;
			this.kEeIxoqAnO.ValueMember = "tR_KladrObj.Id";
			this.kEeIxoqAnO.SelectedIndexChanged += new System.EventHandler(this.kEeIxoqAnO_SelectedIndexChanged);
			this.dataSet_2.DataSetName = "NewDataSet";
			this.dataSet_2.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dataTable_1
			});
			this.dataTable_1.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn_6,
				this.dataColumn_7,
				this.dataColumn_8,
				this.dataColumn_9
			});
			this.dataTable_1.TableName = "tR_KladrObj";
			this.dataColumn_6.ColumnName = "Id";
			this.dataColumn_6.DataType = typeof(int);
			this.dataColumn_7.ColumnName = "Name";
			this.dataColumn_8.ColumnName = "Socr";
			this.dataColumn_9.ColumnName = "NameSocr";
			this.dataColumn_9.Expression = "Name + ' ' + isnull(socr, '')";
			this.dataColumn_9.ReadOnly = true;
			this.labelRaionCity.AutoSize = true;
			this.labelRaionCity.Location = new System.Drawing.Point(179, 16);
			this.labelRaionCity.Name = "labelRaionCity";
			this.labelRaionCity.Size = new System.Drawing.Size(76, 13);
			this.labelRaionCity.TabIndex = 6;
			this.labelRaionCity.Text = "Район города";
			this.cmbRaionCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbRaionCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbRaionCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.class20_0, "tMapObj.Raion", true));
			this.cmbRaionCity.DataSource = this.class20_0;
			this.cmbRaionCity.DisplayMember = "tR_Classifier.Name";
			this.cmbRaionCity.FormattingEnabled = true;
			this.cmbRaionCity.Location = new System.Drawing.Point(182, 32);
			this.cmbRaionCity.Name = "cmbRaionCity";
			this.cmbRaionCity.Size = new System.Drawing.Size(143, 21);
			this.cmbRaionCity.TabIndex = 7;
			this.cmbRaionCity.ValueMember = "tR_Classifier.Id";
			this.class20_0.DataSetName = "DataSetKladr";
			this.class20_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.labelStreet.AutoSize = true;
			this.labelStreet.Location = new System.Drawing.Point(179, 56);
			this.labelStreet.Name = "labelStreet";
			this.labelStreet.Size = new System.Drawing.Size(39, 13);
			this.labelStreet.TabIndex = 8;
			this.labelStreet.Text = "Улица";
			this.cmbStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbStreet.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.class20_0, "tMapObj.Street", true));
			this.cmbStreet.DataSource = this.dataSet_3;
			this.cmbStreet.DisplayMember = "tR_KladrStreet.NameSocr";
			this.cmbStreet.FormattingEnabled = true;
			this.cmbStreet.Location = new System.Drawing.Point(182, 72);
			this.cmbStreet.Name = "cmbStreet";
			this.cmbStreet.Size = new System.Drawing.Size(143, 21);
			this.cmbStreet.TabIndex = 9;
			this.cmbStreet.ValueMember = "tR_KladrStreet.Id";
			this.dataSet_3.DataSetName = "NewDataSet";
			this.dataSet_3.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dataTable_2
			});
			this.dataTable_2.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn_10,
				this.dataColumn_11,
				this.dataColumn_12,
				this.dataColumn_13
			});
			this.dataTable_2.TableName = "tR_KladrStreet";
			this.dataColumn_10.ColumnName = "Id";
			this.dataColumn_10.DataType = typeof(int);
			this.dataColumn_11.ColumnName = "Name";
			this.dataColumn_12.ColumnName = "Socr";
			this.dataColumn_13.ColumnName = "NameSocr";
			this.dataColumn_13.Expression = "Name + ' ' + isnull(socr, '')";
			this.dataColumn_13.ReadOnly = true;
			this.labelHouse.AutoSize = true;
			this.labelHouse.Location = new System.Drawing.Point(183, 96);
			this.labelHouse.Name = "labelHouse";
			this.labelHouse.Size = new System.Drawing.Size(30, 13);
			this.labelHouse.TabIndex = 10;
			this.labelHouse.Text = "Дом";
			this.txtHouse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObj.House", true));
			this.txtHouse.Location = new System.Drawing.Point(182, 112);
			this.txtHouse.Name = "txtHouse";
			this.txtHouse.Size = new System.Drawing.Size(63, 20);
			this.txtHouse.TabIndex = 11;
			this.labelHousePrefix.AutoSize = true;
			this.labelHousePrefix.Location = new System.Drawing.Point(258, 96);
			this.labelHousePrefix.Name = "labelHousePrefix";
			this.labelHousePrefix.Size = new System.Drawing.Size(53, 13);
			this.labelHousePrefix.TabIndex = 12;
			this.labelHousePrefix.Text = "Префикс";
			this.txtHousePrefix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObj.HousePrefix", true));
			this.txtHousePrefix.Location = new System.Drawing.Point(261, 112);
			this.txtHousePrefix.Name = "txtHousePrefix";
			this.txtHousePrefix.Size = new System.Drawing.Size(64, 20);
			this.txtHousePrefix.TabIndex = 13;
			this.labelIndex.AutoSize = true;
			this.labelIndex.Location = new System.Drawing.Point(6, 136);
			this.labelIndex.Name = "labelIndex";
			this.labelIndex.Size = new System.Drawing.Size(45, 13);
			this.labelIndex.TabIndex = 14;
			this.labelIndex.Text = "Индекс";
			this.txtIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObj.Index", true));
			this.txtIndex.Location = new System.Drawing.Point(9, 152);
			this.txtIndex.Name = "txtIndex";
			this.txtIndex.Size = new System.Drawing.Size(88, 20);
			this.txtIndex.TabIndex = 15;
			this.checkBoxIsHouse.AutoSize = true;
			this.checkBoxIsHouse.Checked = true;
			this.checkBoxIsHouse.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxIsHouse.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.class20_0, "tMapObj.IsHouse", true));
			this.checkBoxIsHouse.Location = new System.Drawing.Point(186, 152);
			this.checkBoxIsHouse.Name = "checkBoxIsHouse";
			this.checkBoxIsHouse.Size = new System.Drawing.Size(112, 17);
			this.checkBoxIsHouse.TabIndex = 16;
			this.checkBoxIsHouse.Text = "Является домом";
			this.checkBoxIsHouse.UseVisualStyleBackColor = true;
			this.groupBoxHouse.Controls.Add(this.lnapflutpA);
			this.groupBoxHouse.Controls.Add(this.txtName);
			this.groupBoxHouse.Controls.Add(this.labelObl);
			this.groupBoxHouse.Controls.Add(this.checkBoxIsHouse);
			this.groupBoxHouse.Controls.Add(this.cmbObl);
			this.groupBoxHouse.Controls.Add(this.txtIndex);
			this.groupBoxHouse.Controls.Add(this.labelRaionObl);
			this.groupBoxHouse.Controls.Add(this.labelIndex);
			this.groupBoxHouse.Controls.Add(this.cmbRaionObl);
			this.groupBoxHouse.Controls.Add(this.txtHousePrefix);
			this.groupBoxHouse.Controls.Add(this.labelCity);
			this.groupBoxHouse.Controls.Add(this.labelHousePrefix);
			this.groupBoxHouse.Controls.Add(this.kEeIxoqAnO);
			this.groupBoxHouse.Controls.Add(this.txtHouse);
			this.groupBoxHouse.Controls.Add(this.labelRaionCity);
			this.groupBoxHouse.Controls.Add(this.labelHouse);
			this.groupBoxHouse.Controls.Add(this.cmbRaionCity);
			this.groupBoxHouse.Controls.Add(this.cmbStreet);
			this.groupBoxHouse.Controls.Add(this.labelStreet);
			this.groupBoxHouse.Location = new System.Drawing.Point(0, 0);
			this.groupBoxHouse.Name = "groupBoxHouse";
			this.groupBoxHouse.Size = new System.Drawing.Size(336, 205);
			this.groupBoxHouse.TabIndex = 0;
			this.groupBoxHouse.TabStop = false;
			this.lnapflutpA.AutoSize = true;
			this.lnapflutpA.Location = new System.Drawing.Point(12, 179);
			this.lnapflutpA.Name = "labelName";
			this.lnapflutpA.Size = new System.Drawing.Size(77, 13);
			this.lnapflutpA.TabIndex = 18;
			this.lnapflutpA.Text = "Нименование";
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObj.Name", true));
			this.txtName.Location = new System.Drawing.Point(95, 176);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(230, 20);
			this.txtName.TabIndex = 17;
			this.groupBox_0.Controls.Add(this.txtLongitude);
			this.groupBox_0.Controls.Add(this.labelLongitude);
			this.groupBox_0.Controls.Add(this.txtLatitude);
			this.groupBox_0.Controls.Add(this.labelLatitude);
			this.groupBox_0.Location = new System.Drawing.Point(0, 207);
			this.groupBox_0.Name = "groupBoxGPS";
			this.groupBox_0.Size = new System.Drawing.Size(336, 42);
			this.groupBox_0.TabIndex = 1;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "GPS";
			this.txtLongitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObj.Longitude", true));
			this.txtLongitude.Location = new System.Drawing.Point(228, 13);
			this.txtLongitude.Name = "txtLongitude";
			this.txtLongitude.Size = new System.Drawing.Size(100, 20);
			this.txtLongitude.TabIndex = 3;
			this.labelLongitude.AutoSize = true;
			this.labelLongitude.Location = new System.Drawing.Point(172, 16);
			this.labelLongitude.Name = "labelLongitude";
			this.labelLongitude.Size = new System.Drawing.Size(50, 13);
			this.labelLongitude.TabIndex = 2;
			this.labelLongitude.Text = "Долгота";
			this.txtLatitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObj.Latitude", true));
			this.txtLatitude.Location = new System.Drawing.Point(63, 13);
			this.txtLatitude.Name = "txtLatitude";
			this.txtLatitude.Size = new System.Drawing.Size(100, 20);
			this.txtLatitude.TabIndex = 1;
			this.labelLatitude.AutoSize = true;
			this.labelLatitude.Location = new System.Drawing.Point(12, 16);
			this.labelLatitude.Name = "labelLatitude";
			this.labelLatitude.Size = new System.Drawing.Size(45, 13);
			this.labelLatitude.TabIndex = 0;
			this.labelLatitude.Text = "Широта";
			this.labelComment.AutoSize = true;
			this.labelComment.Location = new System.Drawing.Point(6, 252);
			this.labelComment.Name = "labelComment";
			this.labelComment.Size = new System.Drawing.Size(77, 13);
			this.labelComment.TabIndex = 2;
			this.labelComment.Text = "Комментарий";
			this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObj.Comment", true));
			this.richTextBoxComment.Location = new System.Drawing.Point(0, 268);
			this.richTextBoxComment.Name = "richTextBoxComment";
			this.richTextBoxComment.Size = new System.Drawing.Size(336, 67);
			this.richTextBoxComment.TabIndex = 3;
			this.richTextBoxComment.Text = "";
			this.buttonOk.Location = new System.Drawing.Point(8, 341);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "ОК";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(253, 341);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(335, 370);
			base.Controls.Add(this.labelComment);
			base.Controls.Add(this.richTextBoxComment);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.groupBox_0);
			base.Controls.Add(this.groupBoxHouse);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormMapObjAddEdit";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавление нового объекта";
			base.Load += new System.EventHandler(this.cyvIfStEoT);
			((System.ComponentModel.ISupportInitialize)this.dataSet_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.vCypyVusgP).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class20_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_3).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_2).EndInit();
			this.groupBoxHouse.ResumeLayout(false);
			this.groupBoxHouse.PerformLayout();
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.Label labelObl;

		private System.Windows.Forms.ComboBox cmbObl;

		private System.Windows.Forms.Label labelRaionObl;

		private System.Windows.Forms.ComboBox cmbRaionObl;

		private System.Windows.Forms.Label labelCity;

		private System.Windows.Forms.ComboBox kEeIxoqAnO;

		private System.Windows.Forms.Label labelRaionCity;

		private System.Windows.Forms.ComboBox cmbRaionCity;

		private System.Windows.Forms.Label labelStreet;

		private System.Windows.Forms.ComboBox cmbStreet;

		private System.Windows.Forms.Label labelHouse;

		private System.Windows.Forms.TextBox txtHouse;

		private System.Windows.Forms.Label labelHousePrefix;

		private System.Windows.Forms.TextBox txtHousePrefix;

		private System.Windows.Forms.Label labelIndex;

		private System.Windows.Forms.TextBox txtIndex;

		private System.Windows.Forms.CheckBox checkBoxIsHouse;

		private System.Windows.Forms.GroupBox groupBoxHouse;

		private System.Windows.Forms.GroupBox groupBox_0;

		private System.Windows.Forms.TextBox txtLongitude;

		private System.Windows.Forms.Label labelLongitude;

		private System.Windows.Forms.TextBox txtLatitude;

		private System.Windows.Forms.Label labelLatitude;

		private System.Windows.Forms.Label labelComment;

		private System.Windows.Forms.RichTextBox richTextBoxComment;

		private System.Windows.Forms.Button buttonOk;

		private System.Windows.Forms.Button buttonCancel;

		private Class20 class20_0;

		private System.Data.DataSet dataSet_0;

		private System.Data.DataTable vCypyVusgP;

		private System.Data.DataColumn dataColumn_0;

		private System.Data.DataColumn qSmpwqZdyo;

		private System.Data.DataColumn GjapFujsiQ;

		private System.Data.DataColumn dataColumn_1;

		private System.Data.DataSet dataSet_1;

		private System.Data.DataTable dataTable_0;

		private System.Data.DataColumn dataColumn_2;

		private System.Data.DataColumn dataColumn_3;

		private System.Data.DataColumn dataColumn_4;

		private System.Data.DataColumn dataColumn_5;

		private System.Data.DataSet dataSet_2;

		private System.Data.DataTable dataTable_1;

		private System.Data.DataColumn dataColumn_6;

		private System.Data.DataColumn dataColumn_7;

		private System.Data.DataColumn dataColumn_8;

		private System.Data.DataColumn dataColumn_9;

		private System.Data.DataSet dataSet_3;

		private System.Data.DataTable dataTable_2;

		private System.Data.DataColumn dataColumn_10;

		private System.Data.DataColumn dataColumn_11;

		private System.Data.DataColumn dataColumn_12;

		private System.Data.DataColumn dataColumn_13;

		private System.Windows.Forms.TextBox txtName;

		private System.Windows.Forms.Label lnapflutpA;
	}
}
