using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;

internal class Form8 : FormBase
{
	[CompilerGenerated]
	internal StateFormCreate method_0()
	{
		return this.stateFormCreate_0;
	}

	[CompilerGenerated]
	internal void method_1(StateFormCreate stateFormCreate_1)
	{
		this.stateFormCreate_0 = stateFormCreate_1;
	}

	internal int method_2()
	{
		return this.int_1;
	}

	internal Form8(int int_2, int int_3)
	{
		Class330.Mus9JxKz1CNxy();
		this.int_0 = -1;
		this.int_1 = -1;
		base..ctor();
		this.method_8();
		this.method_3();
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	protected override void OnLoad(EventArgs eventArgs_0)
	{
		base.OnLoad(eventArgs_0);
		this.method_4();
		StateFormCreate stateFormCreate = this.method_0();
		if (stateFormCreate != null)
		{
			if (stateFormCreate == 1)
			{
				this.Text = "Редактирование адреса " + this.method_7(this.int_0);
				base.SelectSqlData(this.ycimVeObqtL.tP_ObjAddress, true, string.Format("where id = '{0}'", this.int_1), null, false, 0);
				return;
			}
			if (stateFormCreate != 11)
			{
				return;
			}
			this.Text = "Копирование адреса " + this.method_7(this.int_0);
			base.SelectSqlData(this.ycimVeObqtL.tP_ObjAddress, true, string.Format("where id = '{0}'", this.int_1), null, false, 0);
			Class107.Class292 @class = this.ycimVeObqtL.tP_ObjAddress[0];
			@class["houseNumber"] = DBNull.Value;
			@class["comment"] = DBNull.Value;
			@class.AcceptChanges();
			@class.SetAdded();
			this.int_1 = -1;
			return;
		}
		else
		{
			this.Text = "Добавление адреса " + this.method_7(this.int_0);
			string text = string.Format("where idObjList = '{0}' and deleted = '0' order by id desc", this.int_0);
			base.SelectSqlData(this.ycimVeObqtL.tP_ObjAddress, true, text, null, false, 1);
			if (this.ycimVeObqtL.tP_ObjAddress.Rows.Count == 0)
			{
				DataRow dataRow = this.ycimVeObqtL.tP_ObjAddress.NewRow();
				dataRow["idObjList"] = this.int_0;
				dataRow["deleted"] = false;
				this.ycimVeObqtL.tP_ObjAddress.Rows.Add(dataRow);
				return;
			}
			this.ycimVeObqtL.tP_ObjAddress[0]["idStreet"] = DBNull.Value;
			this.ycimVeObqtL.tP_ObjAddress[0]["houseNumber"] = DBNull.Value;
			this.ycimVeObqtL.tP_ObjAddress[0]["comment"] = DBNull.Value;
			return;
		}
	}

	protected override void OnClosing(CancelEventArgs cancelEventArgs_0)
	{
		base.OnClosing(cancelEventArgs_0);
		if (base.DialogResult == DialogResult.OK && !this.method_5())
		{
			base.DialogResult = DialogResult.None;
			cancelEventArgs_0.Cancel = true;
		}
	}

	private void method_3()
	{
		this.textBox_0.DataBindings[0].DataSourceNullValue = DBNull.Value;
		this.textBox_0.DataBindings[0].NullValue = string.Empty;
		this.richTextBox_0.DataBindings[0].DataSourceNullValue = DBNull.Value;
		this.richTextBox_0.DataBindings[0].NullValue = string.Empty;
		this.comboBox_0.DataBindings[0].DataSourceNullValue = DBNull.Value;
		this.comboBox_1.DataBindings[0].DataSourceNullValue = DBNull.Value;
		this.comboBox_2.DataBindings[0].DataSourceNullValue = DBNull.Value;
		this.comboBox_3.DataBindings[0].DataSourceNullValue = DBNull.Value;
	}

	private void method_4()
	{
		DataTable dataTable = this.method_6();
		BindingSource bindingSource = new BindingSource();
		bindingSource.DataSource = dataTable;
		base.SelectSqlData(dataTable, true, "where PrimaryKey = 'Subject' and deleted = '0' order by Name, Socr", null, false, 0);
		this.comboBox_0.DisplayMember = "FullName";
		this.comboBox_0.ValueMember = "id";
		this.comboBox_0.DataSource = bindingSource;
		this.comboBox_0.SelectedIndex = -1;
	}

	private bool method_5()
	{
		this.ycimVeObqtL.tP_ObjAddress[0].EndEdit();
		StateFormCreate stateFormCreate = this.method_0();
		if (stateFormCreate != null)
		{
			if (stateFormCreate == 1)
			{
				return base.UpdateSqlData(this.ycimVeObqtL.tP_ObjAddress);
			}
			if (stateFormCreate != 11)
			{
				return true;
			}
		}
		this.int_1 = base.InsertSqlDataOneRow(this.ycimVeObqtL.tP_ObjAddress[0]);
		return this.int_1 != -1;
	}

	private void snwmyqMyhrK_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private DataTable method_6()
	{
		return new DataTable("tR_KladrObj")
		{
			Columns = 
			{
				{
					"id",
					typeof(int)
				},
				{
					"ParentId",
					typeof(int)
				},
				{
					"Name",
					typeof(string)
				},
				{
					"Socr",
					typeof(string)
				},
				{
					"Level",
					typeof(int)
				},
				{
					"ParentKey",
					typeof(string)
				},
				{
					"fullName",
					typeof(string),
					"Name + isnull(' ' + Socr, '')"
				}
			}
		};
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.comboBox_0.SelectedIndex < 0)
		{
			this.comboBox_1.DataSource = null;
			return;
		}
		DataTable dataTable = this.method_6();
		BindingSource bindingSource = new BindingSource();
		bindingSource.DataSource = dataTable;
		base.SelectSqlData(dataTable, true, string.Format("where ParentId = '{0}' and deleted = '0' order by Name, Socr", this.comboBox_0.SelectedValue), null, false, 0);
		this.comboBox_1.DisplayMember = "FullName";
		this.comboBox_1.ValueMember = "id";
		this.comboBox_1.DataSource = bindingSource;
		this.comboBox_1.SelectedIndex = -1;
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.comboBox_1.SelectedIndex < 0)
		{
			this.comboBox_2.DataSource = null;
			this.comboBox_3.DataSource = null;
			return;
		}
		DataTable dataTable = this.method_6();
		BindingSource bindingSource = new BindingSource();
		bindingSource.DataSource = dataTable;
		base.SelectSqlData(dataTable, true, string.Format("where ParentId = '{0}' and deleted = '0' order by Name, Socr", this.comboBox_1.SelectedValue), null, false, 0);
		this.comboBox_2.DisplayMember = "FullName";
		this.comboBox_2.ValueMember = "id";
		this.comboBox_2.DataSource = bindingSource;
		this.comboBox_2.SelectedIndex = -1;
		DataTable dataTable2 = new DataTable("tR_KladrStreet");
		dataTable2.Columns.Add("id", typeof(int));
		dataTable2.Columns.Add("KladrObjId", typeof(int));
		dataTable2.Columns.Add("Name", typeof(string));
		dataTable2.Columns.Add("Socr", typeof(string));
		dataTable2.Columns.Add("fullName", typeof(string), "Name + isnull(' ' + Socr, '')");
		BindingSource bindingSource2 = new BindingSource();
		bindingSource2.DataSource = dataTable2;
		base.SelectSqlData(dataTable2, true, string.Format("where kladrObjId = '{0}' and deleted = '0' order by Name, Socr", this.comboBox_1.SelectedValue), null, false, 0);
		this.comboBox_3.DisplayMember = "FullName";
		this.comboBox_3.ValueMember = "id";
		this.comboBox_3.DataSource = bindingSource2;
		this.comboBox_3.SelectedIndex = -1;
	}

	private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.comboBox_2.SelectedIndex == -1)
		{
			this.comboBox_3.DataSource = null;
			return;
		}
		DataTable dataTable = new DataTable("tR_KladrStreet");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("KladrObjId", typeof(int));
		dataTable.Columns.Add("Name", typeof(string));
		dataTable.Columns.Add("Socr", typeof(string));
		dataTable.Columns.Add("fullName", typeof(string), "Name + isnull(' ' + Socr, '')");
		BindingSource bindingSource = new BindingSource();
		bindingSource.DataSource = dataTable;
		base.SelectSqlData(dataTable, true, string.Format("where kladrObjId = '{0}' and deleted = '0' order by Name, Socr", this.comboBox_2.SelectedValue), null, false, 0);
		this.comboBox_3.DisplayMember = "FullName";
		this.comboBox_3.ValueMember = "id";
		this.comboBox_3.DataSource = bindingSource;
		this.comboBox_3.SelectedIndex = -1;
	}

	private string method_7(int int_2)
	{
		string result = string.Empty;
		string text = string.Format("select isnull(c_ol.SocrName + ' - ', '') + ol.Name as ObjName\r\nfrom tSchm_ObjList as ol\r\nleft join tR_Classifier as c_ol on c_ol.id = ol.typeCodeId\r\nwhere ol.id = '{0}'", int_2);
		DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
		if (dataTable != null && dataTable.Rows.Count > 0)
		{
			result = Convert.ToString(dataTable.Rows[0]["ObjName"]);
		}
		return result;
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Form8.p20oat9lprTALlPbJNhD(this, bool_0);
	}

	private void method_8()
	{
		this.ycimVeObqtL = new Class107();
		this.label_0 = new Label();
		this.label_1 = new Label();
		this.label_2 = new Label();
		this.label_3 = new Label();
		this.label_4 = new Label();
		this.label_5 = new Label();
		this.comboBox_0 = new ComboBox();
		this.comboBox_1 = new ComboBox();
		this.comboBox_2 = new ComboBox();
		this.comboBox_3 = new ComboBox();
		this.textBox_0 = new TextBox();
		this.richTextBox_0 = new RichTextBox();
		this.button_0 = new Button();
		this.snwmyqMyhrK = new Button();
		((ISupportInitialize)this.ycimVeObqtL).BeginInit();
		base.SuspendLayout();
		this.ycimVeObqtL.DataSetName = "dsPassport";
		this.ycimVeObqtL.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(12, 9);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(43, 13);
		this.label_0.TabIndex = 0;
		this.label_0.Text = "Регион";
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(12, 49);
		this.label_1.Name = "label2";
		this.label_1.Size = new Size(38, 13);
		this.label_1.TabIndex = 1;
		this.label_1.Text = "Район";
		this.label_2.AutoSize = true;
		this.label_2.Location = new Point(12, 89);
		this.label_2.Name = "label3";
		this.label_2.Size = new Size(102, 13);
		this.label_2.TabIndex = 2;
		this.label_2.Text = "Населенный пункт";
		this.label_3.AutoSize = true;
		this.label_3.Location = new Point(12, 129);
		this.label_3.Name = "label4";
		this.label_3.Size = new Size(39, 13);
		this.label_3.TabIndex = 3;
		this.label_3.Text = "Улица";
		this.label_4.AutoSize = true;
		this.label_4.Location = new Point(12, 169);
		this.label_4.Name = "label5";
		this.label_4.Size = new Size(30, 13);
		this.label_4.TabIndex = 4;
		this.label_4.Text = "Дом";
		this.label_5.AutoSize = true;
		this.label_5.Location = new Point(12, 208);
		this.label_5.Name = "label6";
		this.label_5.Size = new Size(70, 13);
		this.label_5.TabIndex = 5;
		this.label_5.Text = "Примечание";
		this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.ycimVeObqtL, "tP_ObjAddress.idRegion", true));
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Location = new Point(12, 25);
		this.comboBox_0.Name = "cmbRegion";
		this.comboBox_0.Size = new Size(191, 21);
		this.comboBox_0.TabIndex = 6;
		this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
		this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.ycimVeObqtL, "tP_ObjAddress.idLocality", true));
		this.comboBox_1.FormattingEnabled = true;
		this.comboBox_1.Location = new Point(12, 65);
		this.comboBox_1.Name = "cmbLocality";
		this.comboBox_1.Size = new Size(191, 21);
		this.comboBox_1.TabIndex = 7;
		this.comboBox_1.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
		this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.ycimVeObqtL, "tP_ObjAddress.idTown", true));
		this.comboBox_2.FormattingEnabled = true;
		this.comboBox_2.Location = new Point(12, 105);
		this.comboBox_2.Name = "cmbTown";
		this.comboBox_2.Size = new Size(191, 21);
		this.comboBox_2.TabIndex = 8;
		this.comboBox_2.SelectedIndexChanged += this.comboBox_2_SelectedIndexChanged;
		this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_3.DataBindings.Add(new Binding("SelectedValue", this.ycimVeObqtL, "tP_ObjAddress.idStreet", true));
		this.comboBox_3.FormattingEnabled = true;
		this.comboBox_3.Location = new Point(12, 145);
		this.comboBox_3.Name = "cmbStreet";
		this.comboBox_3.Size = new Size(191, 21);
		this.comboBox_3.TabIndex = 9;
		this.textBox_0.DataBindings.Add(new Binding("Text", this.ycimVeObqtL, "tP_ObjAddress.houseNumber", true));
		this.textBox_0.Location = new Point(12, 185);
		this.textBox_0.Name = "txtHouse";
		this.textBox_0.Size = new Size(115, 20);
		this.textBox_0.TabIndex = 10;
		this.richTextBox_0.DataBindings.Add(new Binding("Text", this.ycimVeObqtL, "tP_ObjAddress.comment", true));
		this.richTextBox_0.Location = new Point(12, 224);
		this.richTextBox_0.Name = "rtxtComment";
		this.richTextBox_0.Size = new Size(254, 52);
		this.richTextBox_0.TabIndex = 11;
		this.richTextBox_0.Text = "";
		this.button_0.DialogResult = DialogResult.OK;
		this.button_0.Location = new Point(110, 300);
		this.button_0.Name = "btnOK";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 12;
		this.button_0.Text = "ОК";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.snwmyqMyhrK_Click;
		this.snwmyqMyhrK.DialogResult = DialogResult.Cancel;
		this.snwmyqMyhrK.Location = new Point(191, 300);
		this.snwmyqMyhrK.Name = "btnCancel";
		this.snwmyqMyhrK.Size = new Size(75, 23);
		this.snwmyqMyhrK.TabIndex = 13;
		this.snwmyqMyhrK.Text = "Отмена";
		this.snwmyqMyhrK.UseVisualStyleBackColor = true;
		this.snwmyqMyhrK.Click += this.snwmyqMyhrK_Click;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(278, 334);
		base.Controls.Add(this.snwmyqMyhrK);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.richTextBox_0);
		base.Controls.Add(this.textBox_0);
		base.Controls.Add(this.comboBox_3);
		base.Controls.Add(this.comboBox_2);
		base.Controls.Add(this.comboBox_1);
		base.Controls.Add(this.comboBox_0);
		base.Controls.Add(this.label_5);
		base.Controls.Add(this.label_4);
		base.Controls.Add(this.label_3);
		base.Controls.Add(this.label_2);
		base.Controls.Add(this.label_1);
		base.Controls.Add(this.label_0);
		base.Name = "FormAddEditObjAddress";
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "FormAddEditObjAddress";
		((ISupportInitialize)this.ycimVeObqtL).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	internal static void p20oat9lprTALlPbJNhD(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private int int_0;

	private int int_1;

	[CompilerGenerated]
	private StateFormCreate stateFormCreate_0;

	private IContainer icontainer_0;

	private Class107 ycimVeObqtL;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private ComboBox comboBox_0;

	private ComboBox comboBox_1;

	private ComboBox comboBox_2;

	private ComboBox comboBox_3;

	private TextBox textBox_0;

	private RichTextBox richTextBox_0;

	private Button button_0;

	private Button snwmyqMyhrK;
}
