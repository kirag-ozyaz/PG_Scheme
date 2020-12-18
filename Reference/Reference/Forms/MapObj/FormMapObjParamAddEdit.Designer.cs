namespace Reference.Forms.MapObj
{
	public partial class FormMapObjParamAddEdit : FormLbr.FormBase
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
			this.class20_0 = new Class20();
			this.groupBoxObj = new System.Windows.Forms.GroupBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxHousePrefix = new System.Windows.Forms.TextBox();
			this.labelHousePrefix = new System.Windows.Forms.Label();
			this.textBoxHouse = new System.Windows.Forms.TextBox();
			this.labelHouse = new System.Windows.Forms.Label();
			this.labelStreet = new System.Windows.Forms.Label();
			this.textBoxStreet = new System.Windows.Forms.TextBox();
			this.groupBoxParam = new System.Windows.Forms.GroupBox();
			this.textBoxYearBuilt = new System.Windows.Forms.TextBox();
			this.labelYearBuilt = new System.Windows.Forms.Label();
			this.textBoxApartment = new System.Windows.Forms.TextBox();
			this.labelApartment = new System.Windows.Forms.Label();
			this.labelPorch = new System.Windows.Forms.Label();
			this.textBoxPorch = new System.Windows.Forms.TextBox();
			this.labelFloor = new System.Windows.Forms.Label();
			this.textBoxFloor = new System.Windows.Forms.TextBox();
			this.cmbOtherType = new System.Windows.Forms.ComboBox();
			this.labelOtherType = new System.Windows.Forms.Label();
			this.labelType = new System.Windows.Forms.Label();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.labelDateBegin = new System.Windows.Forms.Label();
			this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
			this.labelDateEnd = new System.Windows.Forms.Label();
			this.dateTimePickerEnd = new ControlsLbr.NullableDateTimePicker();
			this.labelReason = new System.Windows.Forms.Label();
			this.cmbReason = new System.Windows.Forms.ComboBox();
			this.labelComment = new System.Windows.Forms.Label();
			this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
			this.bapZylnPk1 = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.bindingSource_1 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.bindingSource_2 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			((System.ComponentModel.ISupportInitialize)this.class20_0).BeginInit();
			this.groupBoxObj.SuspendLayout();
			this.groupBoxParam.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_2).BeginInit();
			base.SuspendLayout();
			this.class20_0.DataSetName = "DataSetKladr";
			this.class20_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.groupBoxObj.Controls.Add(this.textBoxName);
			this.groupBoxObj.Controls.Add(this.labelName);
			this.groupBoxObj.Controls.Add(this.textBoxHousePrefix);
			this.groupBoxObj.Controls.Add(this.labelHousePrefix);
			this.groupBoxObj.Controls.Add(this.textBoxHouse);
			this.groupBoxObj.Controls.Add(this.labelHouse);
			this.groupBoxObj.Controls.Add(this.labelStreet);
			this.groupBoxObj.Controls.Add(this.textBoxStreet);
			this.groupBoxObj.Location = new System.Drawing.Point(1, 0);
			this.groupBoxObj.Name = "groupBoxObj";
			this.groupBoxObj.Size = new System.Drawing.Size(330, 92);
			this.groupBoxObj.TabIndex = 0;
			this.groupBoxObj.TabStop = false;
			this.groupBoxObj.Text = "Объект";
			this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "vMapObj.Name", true));
			this.textBoxName.Location = new System.Drawing.Point(100, 61);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new System.Drawing.Size(217, 20);
			this.textBoxName.TabIndex = 7;
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(11, 64);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(83, 13);
			this.labelName.TabIndex = 6;
			this.labelName.Text = "Наименование";
			this.textBoxHousePrefix.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxHousePrefix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "vMapObj.HousePrefix", true));
			this.textBoxHousePrefix.Location = new System.Drawing.Point(248, 32);
			this.textBoxHousePrefix.Name = "textBoxHousePrefix";
			this.textBoxHousePrefix.ReadOnly = true;
			this.textBoxHousePrefix.Size = new System.Drawing.Size(69, 20);
			this.textBoxHousePrefix.TabIndex = 5;
			this.labelHousePrefix.AutoSize = true;
			this.labelHousePrefix.Location = new System.Drawing.Point(245, 16);
			this.labelHousePrefix.Name = "labelHousePrefix";
			this.labelHousePrefix.Size = new System.Drawing.Size(53, 13);
			this.labelHousePrefix.TabIndex = 4;
			this.labelHousePrefix.Text = "Префикс";
			this.textBoxHouse.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxHouse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "vMapObj.House", true));
			this.textBoxHouse.Location = new System.Drawing.Point(182, 32);
			this.textBoxHouse.Name = "textBoxHouse";
			this.textBoxHouse.ReadOnly = true;
			this.textBoxHouse.Size = new System.Drawing.Size(55, 20);
			this.textBoxHouse.TabIndex = 3;
			this.labelHouse.AutoSize = true;
			this.labelHouse.Location = new System.Drawing.Point(179, 16);
			this.labelHouse.Name = "labelHouse";
			this.labelHouse.Size = new System.Drawing.Size(30, 13);
			this.labelHouse.TabIndex = 2;
			this.labelHouse.Text = "Дом";
			this.labelStreet.AutoSize = true;
			this.labelStreet.Location = new System.Drawing.Point(11, 16);
			this.labelStreet.Name = "labelStreet";
			this.labelStreet.Size = new System.Drawing.Size(39, 13);
			this.labelStreet.TabIndex = 1;
			this.labelStreet.Text = "Улица";
			this.textBoxStreet.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "vMapObj.streetName", true));
			this.textBoxStreet.Location = new System.Drawing.Point(14, 32);
			this.textBoxStreet.Name = "textBoxStreet";
			this.textBoxStreet.ReadOnly = true;
			this.textBoxStreet.Size = new System.Drawing.Size(154, 20);
			this.textBoxStreet.TabIndex = 0;
			this.groupBoxParam.Controls.Add(this.richTextBoxComment);
			this.groupBoxParam.Controls.Add(this.labelComment);
			this.groupBoxParam.Controls.Add(this.cmbReason);
			this.groupBoxParam.Controls.Add(this.labelReason);
			this.groupBoxParam.Controls.Add(this.dateTimePickerEnd);
			this.groupBoxParam.Controls.Add(this.labelDateEnd);
			this.groupBoxParam.Controls.Add(this.dateTimePickerBegin);
			this.groupBoxParam.Controls.Add(this.labelDateBegin);
			this.groupBoxParam.Controls.Add(this.textBoxYearBuilt);
			this.groupBoxParam.Controls.Add(this.labelYearBuilt);
			this.groupBoxParam.Controls.Add(this.textBoxApartment);
			this.groupBoxParam.Controls.Add(this.labelApartment);
			this.groupBoxParam.Controls.Add(this.labelPorch);
			this.groupBoxParam.Controls.Add(this.textBoxPorch);
			this.groupBoxParam.Controls.Add(this.labelFloor);
			this.groupBoxParam.Controls.Add(this.textBoxFloor);
			this.groupBoxParam.Controls.Add(this.cmbOtherType);
			this.groupBoxParam.Controls.Add(this.labelOtherType);
			this.groupBoxParam.Controls.Add(this.labelType);
			this.groupBoxParam.Controls.Add(this.cmbType);
			this.groupBoxParam.Location = new System.Drawing.Point(1, 98);
			this.groupBoxParam.Name = "groupBoxParam";
			this.groupBoxParam.Size = new System.Drawing.Size(330, 233);
			this.groupBoxParam.TabIndex = 1;
			this.groupBoxParam.TabStop = false;
			this.groupBoxParam.Text = "Параметры";
			this.textBoxYearBuilt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObjParameter.YearBuilt", true));
			this.textBoxYearBuilt.Location = new System.Drawing.Point(231, 72);
			this.textBoxYearBuilt.Name = "textBoxYearBuilt";
			this.textBoxYearBuilt.Size = new System.Drawing.Size(86, 20);
			this.textBoxYearBuilt.TabIndex = 11;
			this.labelYearBuilt.AutoSize = true;
			this.labelYearBuilt.Location = new System.Drawing.Point(228, 56);
			this.labelYearBuilt.Name = "labelYearBuilt";
			this.labelYearBuilt.Size = new System.Drawing.Size(89, 13);
			this.labelYearBuilt.TabIndex = 10;
			this.labelYearBuilt.Text = "Дата постройки";
			this.textBoxApartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObjParameter.CountApartment", true));
			this.textBoxApartment.Location = new System.Drawing.Point(166, 72);
			this.textBoxApartment.Name = "textBoxApartment";
			this.textBoxApartment.Size = new System.Drawing.Size(51, 20);
			this.textBoxApartment.TabIndex = 9;
			this.labelApartment.AutoSize = true;
			this.labelApartment.Location = new System.Drawing.Point(165, 56);
			this.labelApartment.Name = "labelApartment";
			this.labelApartment.Size = new System.Drawing.Size(52, 13);
			this.labelApartment.TabIndex = 8;
			this.labelApartment.Text = "Квартир.";
			this.labelPorch.AutoSize = true;
			this.labelPorch.Location = new System.Drawing.Point(85, 56);
			this.labelPorch.Name = "labelPorch";
			this.labelPorch.Size = new System.Drawing.Size(52, 13);
			this.labelPorch.TabIndex = 7;
			this.labelPorch.Text = "Подъезд";
			this.textBoxPorch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObjParameter.CountPorch", true));
			this.textBoxPorch.Location = new System.Drawing.Point(88, 72);
			this.textBoxPorch.Name = "textBoxPorch";
			this.textBoxPorch.Size = new System.Drawing.Size(71, 20);
			this.textBoxPorch.TabIndex = 6;
			this.labelFloor.AutoSize = true;
			this.labelFloor.Location = new System.Drawing.Point(11, 56);
			this.labelFloor.Name = "labelFloor";
			this.labelFloor.Size = new System.Drawing.Size(33, 13);
			this.labelFloor.TabIndex = 5;
			this.labelFloor.Text = "Этаж";
			this.textBoxFloor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObjParameter.CountFloor", true));
			this.textBoxFloor.Location = new System.Drawing.Point(11, 72);
			this.textBoxFloor.Name = "textBoxFloor";
			this.textBoxFloor.Size = new System.Drawing.Size(71, 20);
			this.textBoxFloor.TabIndex = 4;
			this.cmbOtherType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbOtherType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbOtherType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.class20_0, "tMapObjParameter.OtherTypeObj", true));
			this.cmbOtherType.DataSource = this.bindingSource_1;
			this.cmbOtherType.DisplayMember = "Name";
			this.cmbOtherType.FormattingEnabled = true;
			this.cmbOtherType.Location = new System.Drawing.Point(166, 32);
			this.cmbOtherType.Name = "cmbOtherType";
			this.cmbOtherType.Size = new System.Drawing.Size(151, 21);
			this.cmbOtherType.TabIndex = 3;
			this.cmbOtherType.ValueMember = "Id";
			this.labelOtherType.AutoSize = true;
			this.labelOtherType.Location = new System.Drawing.Point(163, 16);
			this.labelOtherType.Name = "labelOtherType";
			this.labelOtherType.Size = new System.Drawing.Size(54, 13);
			this.labelOtherType.TabIndex = 2;
			this.labelOtherType.Text = "Расш тип";
			this.labelType.AutoSize = true;
			this.labelType.Location = new System.Drawing.Point(11, 16);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(71, 13);
			this.labelType.TabIndex = 1;
			this.labelType.Text = "Тип объекта";
			this.cmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.class20_0, "tMapObjParameter.TypeObj", true));
			this.cmbType.DataSource = this.bindingSource_0;
			this.cmbType.DisplayMember = "Name";
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Location = new System.Drawing.Point(11, 32);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(149, 21);
			this.cmbType.TabIndex = 0;
			this.cmbType.ValueMember = "Id";
			this.labelDateBegin.AutoSize = true;
			this.labelDateBegin.Location = new System.Drawing.Point(11, 105);
			this.labelDateBegin.Name = "labelDateBegin";
			this.labelDateBegin.Size = new System.Drawing.Size(71, 13);
			this.labelDateBegin.TabIndex = 12;
			this.labelDateBegin.Text = "Дата начала";
			this.dateTimePickerBegin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObjParameter.dateBegin", true));
			this.dateTimePickerBegin.Location = new System.Drawing.Point(14, 121);
			this.dateTimePickerBegin.Name = "dateTimePickerBegin";
			this.dateTimePickerBegin.Size = new System.Drawing.Size(146, 20);
			this.dateTimePickerBegin.TabIndex = 13;
			this.labelDateEnd.AutoSize = true;
			this.labelDateEnd.Location = new System.Drawing.Point(168, 105);
			this.labelDateEnd.Name = "labelDateEnd";
			this.labelDateEnd.Size = new System.Drawing.Size(66, 13);
			this.labelDateEnd.TabIndex = 14;
			this.labelDateEnd.Text = "Дата конца";
			this.dateTimePickerEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObjParameter.dateEnd", true));
			this.dateTimePickerEnd.Location = new System.Drawing.Point(166, 121);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(151, 20);
			this.dateTimePickerEnd.TabIndex = 15;
			this.dateTimePickerEnd.Value = new System.DateTime(2010, 10, 13, 10, 47, 11, 390);
			this.labelReason.AutoSize = true;
			this.labelReason.Location = new System.Drawing.Point(109, 150);
			this.labelReason.Name = "labelReason";
			this.labelReason.Size = new System.Drawing.Size(50, 13);
			this.labelReason.TabIndex = 16;
			this.labelReason.Text = "Причина";
			this.cmbReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbReason.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.class20_0, "tMapObjParameter.ReasonEnd", true));
			this.cmbReason.DataSource = this.bindingSource_2;
			this.cmbReason.DisplayMember = "Name";
			this.cmbReason.FormattingEnabled = true;
			this.cmbReason.Location = new System.Drawing.Point(166, 147);
			this.cmbReason.Name = "cmbReason";
			this.cmbReason.Size = new System.Drawing.Size(151, 21);
			this.cmbReason.TabIndex = 17;
			this.cmbReason.ValueMember = "Id";
			this.labelComment.AutoSize = true;
			this.labelComment.Location = new System.Drawing.Point(11, 171);
			this.labelComment.Name = "labelComment";
			this.labelComment.Size = new System.Drawing.Size(77, 13);
			this.labelComment.TabIndex = 18;
			this.labelComment.Text = "Комментарии";
			this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.class20_0, "tMapObjParameter.Comment", true));
			this.richTextBoxComment.Location = new System.Drawing.Point(14, 187);
			this.richTextBoxComment.Name = "richTextBoxComment";
			this.richTextBoxComment.Size = new System.Drawing.Size(303, 46);
			this.richTextBoxComment.TabIndex = 19;
			this.richTextBoxComment.Text = "";
			this.bapZylnPk1.Location = new System.Drawing.Point(15, 337);
			this.bapZylnPk1.Name = "buttonOk";
			this.bapZylnPk1.Size = new System.Drawing.Size(75, 23);
			this.bapZylnPk1.TabIndex = 2;
			this.bapZylnPk1.Text = "ОК";
			this.bapZylnPk1.UseVisualStyleBackColor = true;
			this.bapZylnPk1.Click += new System.EventHandler(this.bapZylnPk1_Click);
			this.buttonCancel.Location = new System.Drawing.Point(243, 337);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.bindingSource_0.DataMember = "tR_Classifier";
			this.bindingSource_0.DataSource = this.class20_0;
			this.bindingSource_0.Filter = "ParentKey = ';HouseParam;HouseType;'";
			this.bindingSource_1.DataMember = "tR_Classifier";
			this.bindingSource_1.DataSource = this.class20_0;
			this.bindingSource_1.Filter = "ParentKey = ';HouseParam;HouseOtherType;'";
			this.bindingSource_2.DataMember = "tR_Classifier";
			this.bindingSource_2.DataSource = this.class20_0;
			this.bindingSource_2.Filter = "ParentKey = ';HouseParam;HouseReasonClose;'";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(331, 370);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.bapZylnPk1);
			base.Controls.Add(this.groupBoxParam);
			base.Controls.Add(this.groupBoxObj);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormMapObjParamAddEdit";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавление параметров объекта";
			base.Load += new System.EventHandler(this.FormMapObjParamAddEdit_Load);
			((System.ComponentModel.ISupportInitialize)this.class20_0).EndInit();
			this.groupBoxObj.ResumeLayout(false);
			this.groupBoxObj.PerformLayout();
			this.groupBoxParam.ResumeLayout(false);
			this.groupBoxParam.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_2).EndInit();
			base.ResumeLayout(false);
		}

		private System.ComponentModel.IContainer icontainer_0;

		private Class20 class20_0;

		private System.Windows.Forms.GroupBox groupBoxObj;

		private System.Windows.Forms.TextBox textBoxHousePrefix;

		private System.Windows.Forms.Label labelHousePrefix;

		private System.Windows.Forms.TextBox textBoxHouse;

		private System.Windows.Forms.Label labelHouse;

		private System.Windows.Forms.Label labelStreet;

		private System.Windows.Forms.TextBox textBoxStreet;

		private System.Windows.Forms.Label labelName;

		private System.Windows.Forms.TextBox textBoxName;

		private System.Windows.Forms.GroupBox groupBoxParam;

		private System.Windows.Forms.ComboBox cmbType;

		private System.Windows.Forms.TextBox textBoxYearBuilt;

		private System.Windows.Forms.Label labelYearBuilt;

		private System.Windows.Forms.TextBox textBoxApartment;

		private System.Windows.Forms.Label labelApartment;

		private System.Windows.Forms.Label labelPorch;

		private System.Windows.Forms.TextBox textBoxPorch;

		private System.Windows.Forms.Label labelFloor;

		private System.Windows.Forms.TextBox textBoxFloor;

		private System.Windows.Forms.ComboBox cmbOtherType;

		private System.Windows.Forms.Label labelOtherType;

		private System.Windows.Forms.Label labelType;

		private System.Windows.Forms.DateTimePicker dateTimePickerBegin;

		private System.Windows.Forms.Label labelDateBegin;

		private System.Windows.Forms.RichTextBox richTextBoxComment;

		private System.Windows.Forms.Label labelComment;

		private System.Windows.Forms.ComboBox cmbReason;

		private System.Windows.Forms.Label labelReason;

		private ControlsLbr.NullableDateTimePicker dateTimePickerEnd;

		private System.Windows.Forms.Label labelDateEnd;

		private System.Windows.Forms.Button bapZylnPk1;

		private System.Windows.Forms.Button buttonCancel;

		private System.Windows.Forms.BindingSource bindingSource_0;

		private System.Windows.Forms.BindingSource bindingSource_1;

		private System.Windows.Forms.BindingSource bindingSource_2;
	}
}
