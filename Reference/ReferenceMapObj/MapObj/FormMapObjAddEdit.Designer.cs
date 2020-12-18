namespace ReferenceMapObj
{
	public partial class FormMapObjAddEdit : FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.labelObl = new System.Windows.Forms.Label();
			this.cmbObl = new System.Windows.Forms.ComboBox();
			this.dsObl = new System.Data.DataSet();
			this.dataTableObl = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataColumn3 = new System.Data.DataColumn();
			this.dataColumn4 = new System.Data.DataColumn();
			this.labelRaionObl = new System.Windows.Forms.Label();
			this.cmbRaionObl = new System.Windows.Forms.ComboBox();
			this.dsRaionObl = new System.Data.DataSet();
			this.dataTable1 = new System.Data.DataTable();
			this.dataColumn5 = new System.Data.DataColumn();
			this.dataColumn6 = new System.Data.DataColumn();
			this.dataColumn7 = new System.Data.DataColumn();
			this.dataColumn8 = new System.Data.DataColumn();
			this.labelCity = new System.Windows.Forms.Label();
			this.cmbCity = new System.Windows.Forms.ComboBox();
			this.dsPunkts = new System.Data.DataSet();
			this.dataTable2 = new System.Data.DataTable();
			this.dataColumn9 = new System.Data.DataColumn();
			this.dataColumn10 = new System.Data.DataColumn();
			this.dataColumn11 = new System.Data.DataColumn();
			this.dataColumn12 = new System.Data.DataColumn();
			this.labelRaionCity = new System.Windows.Forms.Label();
			this.cmbRaionCity = new System.Windows.Forms.ComboBox();
			this.dsKladr = new DataSets.DataSetKladr();
			this.labelStreet = new System.Windows.Forms.Label();
			this.cmbStreet = new System.Windows.Forms.ComboBox();
			this.dsStreet = new System.Data.DataSet();
			this.dataTable3 = new System.Data.DataTable();
			this.dataColumn13 = new System.Data.DataColumn();
			this.dataColumn14 = new System.Data.DataColumn();
			this.dataColumn15 = new System.Data.DataColumn();
			this.dataColumn16 = new System.Data.DataColumn();
			this.labelHouse = new System.Windows.Forms.Label();
			this.txtHouse = new System.Windows.Forms.TextBox();
			this.labelHousePrefix = new System.Windows.Forms.Label();
			this.txtHousePrefix = new System.Windows.Forms.TextBox();
			this.labelIndex = new System.Windows.Forms.Label();
			this.txtIndex = new System.Windows.Forms.TextBox();
			this.checkBoxIsHouse = new System.Windows.Forms.CheckBox();
			this.groupBoxHouse = new System.Windows.Forms.GroupBox();
			this.labelName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.groupBoxGPS = new System.Windows.Forms.GroupBox();
			this.txtLongitude = new System.Windows.Forms.TextBox();
			this.labelLongitude = new System.Windows.Forms.Label();
			this.txtLatitude = new System.Windows.Forms.TextBox();
			this.labelLatitude = new System.Windows.Forms.Label();
			this.labelComment = new System.Windows.Forms.Label();
			this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.dsObl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTableObl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dsRaionObl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dsPunkts).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dsKladr).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dsStreet).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable3).BeginInit();
			this.groupBoxHouse.SuspendLayout();
			this.groupBoxGPS.SuspendLayout();
			base.SuspendLayout();
			this.labelObl.AutoSize = true;
			this.labelObl.Location = new System.Drawing.Point(6, 16);
			this.labelObl.Name = "labelObl";
			this.labelObl.Size = new System.Drawing.Size(50, 13);
			this.labelObl.TabIndex = 0;
			this.labelObl.Text = "Область";
			this.cmbObl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbObl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbObl.DataSource = this.dsObl;
			this.cmbObl.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbObl.FormattingEnabled = true;
			this.cmbObl.Location = new System.Drawing.Point(9, 32);
			this.cmbObl.Name = "cmbObl";
			this.cmbObl.Size = new System.Drawing.Size(143, 21);
			this.cmbObl.TabIndex = 1;
			this.cmbObl.ValueMember = "tR_KladrObj.Id";
			this.cmbObl.SelectedIndexChanged += new System.EventHandler(this.cmbObl_SelectedIndexChanged);
			this.dsObl.DataSetName = "NewDataSet";
			this.dsObl.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dataTableObl
			});
			this.dataTableObl.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn1,
				this.dataColumn2,
				this.dataColumn3,
				this.dataColumn4
			});
			this.dataTableObl.TableName = "tR_KladrObj";
			this.dataColumn1.ColumnName = "Id";
			this.dataColumn1.DataType = typeof(int);
			this.dataColumn2.ColumnName = "Name";
			this.dataColumn3.ColumnName = "Socr";
			this.dataColumn4.ColumnName = "NameSocr";
			this.dataColumn4.Expression = "Name + ' ' + isnull(socr, '')";
			this.dataColumn4.ReadOnly = true;
			this.labelRaionObl.AutoSize = true;
			this.labelRaionObl.Location = new System.Drawing.Point(6, 56);
			this.labelRaionObl.Name = "labelRaionObl";
			this.labelRaionObl.Size = new System.Drawing.Size(72, 13);
			this.labelRaionObl.TabIndex = 2;
			this.labelRaionObl.Text = "Район/город";
			this.cmbRaionObl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbRaionObl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbRaionObl.DataSource = this.dsRaionObl;
			this.cmbRaionObl.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbRaionObl.FormattingEnabled = true;
			this.cmbRaionObl.Location = new System.Drawing.Point(9, 72);
			this.cmbRaionObl.Name = "cmbRaionObl";
			this.cmbRaionObl.Size = new System.Drawing.Size(143, 21);
			this.cmbRaionObl.TabIndex = 3;
			this.cmbRaionObl.ValueMember = "tR_KladrObj.Id";
			this.cmbRaionObl.SelectedIndexChanged += new System.EventHandler(this.cmbRaionObl_SelectedIndexChanged);
			this.dsRaionObl.DataSetName = "NewDataSet";
			this.dsRaionObl.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dataTable1
			});
			this.dataTable1.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn5,
				this.dataColumn6,
				this.dataColumn7,
				this.dataColumn8
			});
			this.dataTable1.TableName = "tR_KladrObj";
			this.dataColumn5.ColumnName = "Id";
			this.dataColumn5.DataType = typeof(int);
			this.dataColumn6.ColumnName = "Name";
			this.dataColumn7.ColumnName = "Socr";
			this.dataColumn8.ColumnName = "NameSocr";
			this.dataColumn8.Expression = "Name + ' ' + isnull(socr, '')";
			this.dataColumn8.ReadOnly = true;
			this.labelCity.AutoSize = true;
			this.labelCity.Location = new System.Drawing.Point(6, 96);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(102, 13);
			this.labelCity.TabIndex = 4;
			this.labelCity.Text = "Населенный пункт";
			this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbCity.DataSource = this.dsPunkts;
			this.cmbCity.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbCity.FormattingEnabled = true;
			this.cmbCity.Location = new System.Drawing.Point(9, 112);
			this.cmbCity.Name = "cmbCity";
			this.cmbCity.Size = new System.Drawing.Size(143, 21);
			this.cmbCity.TabIndex = 5;
			this.cmbCity.ValueMember = "tR_KladrObj.Id";
			this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
			this.dsPunkts.DataSetName = "NewDataSet";
			this.dsPunkts.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dataTable2
			});
			this.dataTable2.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn9,
				this.dataColumn10,
				this.dataColumn11,
				this.dataColumn12
			});
			this.dataTable2.TableName = "tR_KladrObj";
			this.dataColumn9.ColumnName = "Id";
			this.dataColumn9.DataType = typeof(int);
			this.dataColumn10.ColumnName = "Name";
			this.dataColumn11.ColumnName = "Socr";
			this.dataColumn12.ColumnName = "NameSocr";
			this.dataColumn12.Expression = "Name + ' ' + isnull(socr, '')";
			this.dataColumn12.ReadOnly = true;
			this.labelRaionCity.AutoSize = true;
			this.labelRaionCity.Location = new System.Drawing.Point(179, 16);
			this.labelRaionCity.Name = "labelRaionCity";
			this.labelRaionCity.Size = new System.Drawing.Size(76, 13);
			this.labelRaionCity.TabIndex = 6;
			this.labelRaionCity.Text = "Район города";
			this.cmbRaionCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbRaionCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbRaionCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsKladr, "tMapObj.Raion", true));
			this.cmbRaionCity.DataSource = this.dsKladr;
			this.cmbRaionCity.DisplayMember = "tR_Classifier.Name";
			this.cmbRaionCity.FormattingEnabled = true;
			this.cmbRaionCity.Location = new System.Drawing.Point(182, 32);
			this.cmbRaionCity.Name = "cmbRaionCity";
			this.cmbRaionCity.Size = new System.Drawing.Size(143, 21);
			this.cmbRaionCity.TabIndex = 7;
			this.cmbRaionCity.ValueMember = "tR_Classifier.Id";
			this.dsKladr.DataSetName = "DataSetKladr";
			this.dsKladr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.labelStreet.AutoSize = true;
			this.labelStreet.Location = new System.Drawing.Point(179, 56);
			this.labelStreet.Name = "labelStreet";
			this.labelStreet.Size = new System.Drawing.Size(39, 13);
			this.labelStreet.TabIndex = 8;
			this.labelStreet.Text = "Улица";
			this.cmbStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbStreet.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsKladr, "tMapObj.Street", true));
			this.cmbStreet.DataSource = this.dsStreet;
			this.cmbStreet.DisplayMember = "tR_KladrStreet.NameSocr";
			this.cmbStreet.FormattingEnabled = true;
			this.cmbStreet.Location = new System.Drawing.Point(182, 72);
			this.cmbStreet.Name = "cmbStreet";
			this.cmbStreet.Size = new System.Drawing.Size(143, 21);
			this.cmbStreet.TabIndex = 9;
			this.cmbStreet.ValueMember = "tR_KladrStreet.Id";
			this.dsStreet.DataSetName = "NewDataSet";
			this.dsStreet.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dataTable3
			});
			this.dataTable3.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn13,
				this.dataColumn14,
				this.dataColumn15,
				this.dataColumn16
			});
			this.dataTable3.TableName = "tR_KladrStreet";
			this.dataColumn13.ColumnName = "Id";
			this.dataColumn13.DataType = typeof(int);
			this.dataColumn14.ColumnName = "Name";
			this.dataColumn15.ColumnName = "Socr";
			this.dataColumn16.ColumnName = "NameSocr";
			this.dataColumn16.Expression = "Name + ' ' + isnull(socr, '')";
			this.dataColumn16.ReadOnly = true;
			this.labelHouse.AutoSize = true;
			this.labelHouse.Location = new System.Drawing.Point(183, 96);
			this.labelHouse.Name = "labelHouse";
			this.labelHouse.Size = new System.Drawing.Size(30, 13);
			this.labelHouse.TabIndex = 10;
			this.labelHouse.Text = "Дом";
			this.txtHouse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsKladr, "tMapObj.House", true));
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
			this.txtHousePrefix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsKladr, "tMapObj.HousePrefix", true));
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
			this.txtIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsKladr, "tMapObj.Index", true));
			this.txtIndex.Location = new System.Drawing.Point(9, 152);
			this.txtIndex.Name = "txtIndex";
			this.txtIndex.Size = new System.Drawing.Size(88, 20);
			this.txtIndex.TabIndex = 15;
			this.checkBoxIsHouse.AutoSize = true;
			this.checkBoxIsHouse.Checked = true;
			this.checkBoxIsHouse.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxIsHouse.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsKladr, "tMapObj.IsHouse", true));
			this.checkBoxIsHouse.Location = new System.Drawing.Point(186, 152);
			this.checkBoxIsHouse.Name = "checkBoxIsHouse";
			this.checkBoxIsHouse.Size = new System.Drawing.Size(112, 17);
			this.checkBoxIsHouse.TabIndex = 16;
			this.checkBoxIsHouse.Text = "Является домом";
			this.checkBoxIsHouse.UseVisualStyleBackColor = true;
			this.groupBoxHouse.Controls.Add(this.labelName);
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
			this.groupBoxHouse.Controls.Add(this.cmbCity);
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
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(12, 179);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(77, 13);
			this.labelName.TabIndex = 18;
			this.labelName.Text = "Нименование";
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsKladr, "tMapObj.Name", true));
			this.txtName.Location = new System.Drawing.Point(95, 176);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(230, 20);
			this.txtName.TabIndex = 17;
			this.groupBoxGPS.Controls.Add(this.txtLongitude);
			this.groupBoxGPS.Controls.Add(this.labelLongitude);
			this.groupBoxGPS.Controls.Add(this.txtLatitude);
			this.groupBoxGPS.Controls.Add(this.labelLatitude);
			this.groupBoxGPS.Location = new System.Drawing.Point(0, 207);
			this.groupBoxGPS.Name = "groupBoxGPS";
			this.groupBoxGPS.Size = new System.Drawing.Size(336, 42);
			this.groupBoxGPS.TabIndex = 1;
			this.groupBoxGPS.TabStop = false;
			this.groupBoxGPS.Text = "GPS";
			this.txtLongitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsKladr, "tMapObj.Longitude", true));
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
			this.txtLatitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsKladr, "tMapObj.Latitude", true));
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
			this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsKladr, "tMapObj.Comment", true));
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
			base.Controls.Add(this.groupBoxGPS);
			base.Controls.Add(this.groupBoxHouse);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormMapObjAddEdit";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавление нового объекта";
			base.Load += new System.EventHandler(this.FormMapObjAdd_Load);
			((System.ComponentModel.ISupportInitialize)this.dsObl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTableObl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dsRaionObl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dsPunkts).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dsKladr).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dsStreet).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable3).EndInit();
			this.groupBoxHouse.ResumeLayout(false);
			this.groupBoxHouse.PerformLayout();
			this.groupBoxGPS.ResumeLayout(false);
			this.groupBoxGPS.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer components  = null;

		private System.Windows.Forms.Label labelObl;

		private System.Windows.Forms.ComboBox cmbObl;

		private System.Windows.Forms.Label labelRaionObl;

		private System.Windows.Forms.ComboBox cmbRaionObl;

		private System.Windows.Forms.Label labelCity;

		private System.Windows.Forms.ComboBox cmbCity;

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

		private System.Windows.Forms.GroupBox groupBoxGPS;

		private System.Windows.Forms.TextBox txtLongitude;

		private System.Windows.Forms.Label labelLongitude;

		private System.Windows.Forms.TextBox txtLatitude;

		private System.Windows.Forms.Label labelLatitude;

		private System.Windows.Forms.Label labelComment;

		private System.Windows.Forms.RichTextBox richTextBoxComment;

		private System.Windows.Forms.Button buttonOk;

		private System.Windows.Forms.Button buttonCancel;

		private DataSets.DataSetKladr dsKladr;

		private System.Data.DataSet dsObl;

		private System.Data.DataTable dataTableObl;

		private System.Data.DataColumn dataColumn1;

		private System.Data.DataColumn dataColumn2;

		private System.Data.DataColumn dataColumn3;

		private System.Data.DataColumn dataColumn4;

		private System.Data.DataSet dsRaionObl;

		private System.Data.DataTable dataTable1;

		private System.Data.DataColumn dataColumn5;

		private System.Data.DataColumn dataColumn6;

		private System.Data.DataColumn dataColumn7;

		private System.Data.DataColumn dataColumn8;

		private System.Data.DataSet dsPunkts;

		private System.Data.DataTable dataTable2;

		private System.Data.DataColumn dataColumn9;

		private System.Data.DataColumn dataColumn10;

		private System.Data.DataColumn dataColumn11;

		private System.Data.DataColumn dataColumn12;

		private System.Data.DataSet dsStreet;

		private System.Data.DataTable dataTable3;

		private System.Data.DataColumn dataColumn13;

		private System.Data.DataColumn dataColumn14;

		private System.Data.DataColumn dataColumn15;

		private System.Data.DataColumn dataColumn16;

		private System.Windows.Forms.TextBox txtName;

		private System.Windows.Forms.Label labelName;
	}
}
