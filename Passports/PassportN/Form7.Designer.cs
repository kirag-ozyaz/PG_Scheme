using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using Consumer.Forms.ConsumerObj;
using DataSql;
using FormLbr;

internal class Form7 : FormBase
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

	internal Class107.Class288 method_2()
	{
		return this.class288_0;
	}

	internal void method_3(Class107.Class288 class288_1)
	{
		this.class288_0 = class288_1;
	}

	internal Class107.Class289 method_4()
	{
		return this.class289_0;
	}

	internal void hUtmjzkxkdC(Class107.Class289 class289_1)
	{
		this.class289_0 = class289_1;
	}

	internal string ObjName
	{
		get
		{
			return this.textBox_2.Text;
		}
	}

	internal string AirLineName
	{
		get
		{
			return this.comboBox_0.GetItemText(this.comboBox_0.SelectedItem);
		}
	}

	internal string method_5()
	{
		return this.comboBox_1.GetItemText(this.comboBox_1.SelectedItem);
	}

	internal Form7()
	{
		Class330.Mus9JxKz1CNxy();
		this.int_0 = -1;
		this.int_1 = -1;
		this.int_2 = -1;
		this.int_3 = -1;
		this.class12_0 = new Class12(-1, string.Empty);
		this.string_0 = ";SKUEE;TypeAbn;";
		this.string_1 = ";SCM;PS;";
		base..ctor();
		this.method_14();
	}

	internal Form7(int int_7, int int_8, int int_9, int int_10)
	{
		Class330.Mus9JxKz1CNxy();
		this.int_0 = -1;
		this.int_1 = -1;
		this.int_2 = -1;
		this.int_3 = -1;
		this.class12_0 = new Class12(-1, string.Empty);
		this.string_0 = ";SKUEE;TypeAbn;";
		this.string_1 = ";SCM;PS;";
		base..ctor();
		this.method_14();
		this.int_1 = int_7;
		this.int_2 = int_8;
		this.int_3 = int_10;
		this.int_0 = int_9;
	}

	private void Form7_Load(object sender, EventArgs e)
	{
		this.method_7();
		this.method_8();
		this.VebmjiwBviQ();
		this.int_4 = this.method_10(this.string_0);
		this.int_5 = this.method_10(this.string_1);
		switch (this.method_0())
		{
		case 0:
		{
			this.Text = "Добавить отвод";
			Class107.Class288 @class = this.class107_0.tP_CabBranches.method_5();
			@class.idPole = this.int_2;
			@class.idAirLine = this.int_1;
			this.class107_0.tP_CabBranches.Rows.Add(@class);
			break;
		}
		case 1:
		{
			this.Text = "Редактировать отвод";
			Class107.Class288 @class = this.class107_0.tP_CabBranches.method_5();
			for (int i = 1; i < this.method_2().ItemArray.Count<object>(); i++)
			{
				@class[i] = this.method_2()[i];
			}
			this.class107_0.tP_CabBranches.Rows.Add(@class);
			this.method_9();
			break;
		}
		case 4:
		{
			this.Text = "Добавить объект";
			Class107.Class288 @class = this.class107_0.tP_CabBranches.method_5();
			for (int j = 1; j < this.method_2().ItemArray.Count<object>(); j++)
			{
				@class[j] = this.method_2()[j];
			}
			this.class107_0.tP_CabBranches.Rows.Add(@class);
			this.method_4().idCabBranch = this.method_2().id;
			break;
		}
		case 6:
		{
			this.Text = "Редактировать объект";
			Class107.Class288 @class = this.class107_0.tP_CabBranches.method_5();
			for (int k = 1; k < this.method_2().ItemArray.Count<object>(); k++)
			{
				@class[k] = this.method_2()[k];
			}
			this.class107_0.tP_CabBranches.Rows.Add(@class);
			this.method_9();
			break;
		}
		}
		this.method_6();
	}

	private void method_6()
	{
		if (this.method_0() != 4)
		{
			if (this.method_0() != 6)
			{
				if (this.method_0() == 1)
				{
					this.comboBox_2.Enabled = false;
					this.button_2.Enabled = false;
					this.textBox_2.Enabled = false;
				}
				return;
			}
		}
		this.comboBox_0.Enabled = false;
		this.comboBox_1.Enabled = false;
		this.textBox_1.Enabled = false;
		this.textBox_0.Enabled = false;
	}

	private void method_7()
	{
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("name", typeof(string));
		string text = string.Format("select id, Name\r\nfrom tSchm_ObjList\r\nwhere id in (select idObjList from tP_CabSection\r\nwhere idClutchFirst = '{0}' or idClutchSecond = '{0}') or id = '{1}'", this.int_2, this.int_1);
		dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
		this.comboBox_0.DataSource = dataTable;
		this.comboBox_0.DisplayMember = "name";
		this.comboBox_0.ValueMember = "id";
	}

	private void method_8()
	{
		DataTable dataTable = new DataTable("tR_Classifier");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("name", typeof(string));
		base.SelectSqlData(dataTable, true, "where ParentKey in (';SCM;PS;') and deleted = '0' and isGroup = '1'", null, false, 0);
		this.comboBox_2.DataSource = dataTable;
		this.comboBox_2.DisplayMember = "name";
		this.comboBox_2.ValueMember = "id";
	}

	private void method_9()
	{
		int int_ = -1;
		if (!int.TryParse(this.method_4().typeCodeId.ToString(), out int_))
		{
			return;
		}
		int num = this.method_11(int_);
		base.SelectSqlData(this.class107_0, this.class107_0.tR_Classifier, true, string.Format("where id = '{0}' and deleted = '0'", num));
		if (num == this.int_4)
		{
			DataTable dataTable = new DataTable("vAbnObj");
			base.SelectSqlData(dataTable, true, "where id = " + this.int_3.ToString(), null, false, 0);
			this.textBox_2.Text = dataTable.Rows[0]["address"].ToString();
		}
		else if (num == this.int_5)
		{
			DataTable dataTable2 = new DataTable("vP_GetObjListData");
			base.SelectSqlData(dataTable2, true, "where id = " + this.int_3.ToString(), null, false, 0);
			this.textBox_2.Text = dataTable2.Rows[0]["socrName"].ToString() + " - " + dataTable2.Rows[0]["Name"].ToString();
		}
		this.class12_0.int_0 = this.int_3;
		this.class12_0.string_0 = this.textBox_2.Text;
	}

	private void VebmjiwBviQ()
	{
		DataTable dataTable = new DataTable("tP_ValueLists");
		base.SelectSqlData(dataTable, true, "where ParentKey = ';Param;Cable;Makeup;' and isGroup = '0' order by Name", null, false, 0);
		dataTable.Rows.Add(dataTable.NewRow());
		DataView dataView = new DataView(dataTable);
		dataView.Sort = "Name";
		this.comboBox_1.DataSource = dataView.ToTable();
		this.comboBox_1.DisplayMember = "Name";
		this.comboBox_1.ValueMember = "id";
		this.comboBox_1.SelectedIndex = -1;
	}

	private int method_10(string string_2)
	{
		string cmdText = string.Format("Select id From tR_Classifier Where ParentKey = '{0}' and deleted = '0' and isGroup = '1'", string_2);
		int result;
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
		{
			try
			{
				sqlConnection.Open();
				SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
				sqlCommand.CommandType = CommandType.Text;
				if (sqlCommand.ExecuteScalar() == DBNull.Value)
				{
					result = -1;
				}
				else
				{
					result = (int)sqlCommand.ExecuteScalar();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
				result = -1;
			}
			finally
			{
				sqlConnection.Close();
			}
		}
		return result;
	}

	private int method_11(int int_7)
	{
		int result;
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
		{
			string cmdText = string.Format("select ParentId from tR_Classifier where id = '{0}' and deleted = '0'", int_7);
			try
			{
				sqlConnection.Open();
				SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
				sqlCommand.CommandType = CommandType.Text;
				if (sqlCommand.ExecuteScalar() == DBNull.Value)
				{
					result = -1;
				}
				else
				{
					result = (int)sqlCommand.ExecuteScalar();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
				result = -1;
			}
			finally
			{
				sqlConnection.Close();
			}
		}
		return result;
	}

	private bool method_12()
	{
		if (this.comboBox_0.SelectedIndex == -1)
		{
			string text = "Выберите линию";
			MessageBox.Show(this, text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
		int num = this.method_10(this.string_0);
		if (this.comboBox_2.SelectedValue != null)
		{
			if (num != (int)this.comboBox_2.SelectedValue)
			{
				if (this.class12_0.int_0 == -1)
				{
					new ToolTip().Show("!", this.textBox_2, 10, 5, 3000);
					return false;
				}
				return true;
			}
		}
		return true;
	}

	private void method_13()
	{
		for (int i = 1; i < this.class107_0.tP_CabBranches.Columns.Count; i++)
		{
			this.method_2()[i] = this.class107_0.tP_CabBranches[0][i];
		}
		this.method_2().EndEdit();
		if (this.int_4 == (int)this.comboBox_2.SelectedValue)
		{
			this.method_4().idObj = this.class12_0.int_0;
			this.method_4().typeCodeId = -1;
			this.method_4().EndEdit();
			return;
		}
		this.method_4().idObj = this.class12_0.int_0;
		if (this.comboBox_2.SelectedValue.ToString() == this.int_4.ToString())
		{
			DataTable dataTable = new DataTable();
			dataTable = base.SelectSqlData("vAbnObj", true, "where id = " + this.class12_0.int_0.ToString());
			this.method_4().typeCodeId = (int)dataTable.Rows[0]["typeAbn"];
		}
		else if (this.comboBox_2.SelectedValue.ToString() == this.int_5.ToString())
		{
			DataTable dataTable2 = new DataTable();
			dataTable2 = base.SelectSqlData("vP_GetObjListData", true, "where id = " + this.class12_0.int_0.ToString());
			this.method_4().typeCodeId = (int)dataTable2.Rows[0]["typeCodeId"];
		}
		this.method_4().EndEdit();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		if (!this.method_12())
		{
			return;
		}
		this.method_13();
		base.Close();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		base.Close();
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		if (this.comboBox_2.SelectedValue == null)
		{
			new ToolTip().Show("!", this.comboBox_2, 10, 5, 3000);
			return;
		}
		if (this.comboBox_2.SelectedValue.ToString() == this.int_4.ToString())
		{
			FormConsumerObjGrid formConsumerObjGrid = new FormConsumerObjGrid(null);
			formConsumerObjGrid.StartPosition = FormStartPosition.CenterParent;
			formConsumerObjGrid.SqlSettings = this.SqlSettings;
			formConsumerObjGrid.IsSelectAbnObj = true;
			formConsumerObjGrid.IsMultiSelect = false;
			formConsumerObjGrid.SelAbnType = 206;
			if (formConsumerObjGrid.ShowDialog(this) == DialogResult.OK)
			{
				List<AbnAndAbnObj> selectedAbnObj = formConsumerObjGrid.SelectedAbnObj;
				DataTable dataTable = base.SelectSqlData("vAbnObj", true, "where id = " + selectedAbnObj[0].IdAbnObj.ToString());
				this.class12_0 = new Class12(selectedAbnObj[0].IdAbnObj, dataTable.Rows[0]["address"].ToString());
				this.textBox_2.Text = this.class12_0.string_0;
			}
			formConsumerObjGrid.Dispose();
			return;
		}
		if (this.comboBox_2.SelectedValue.ToString() == this.int_5.ToString())
		{
			Form11 form = new Form11();
			form.SqlSettings = this.SqlSettings;
			if (form.ShowDialog() == DialogResult.OK)
			{
				this.class12_0 = form.method_0();
				this.textBox_2.Text = this.class12_0.string_0;
			}
			form.Dispose();
		}
	}

	private void comboBox_2_SelectedValueChanged(object sender, EventArgs e)
	{
		if (this.int_6 == this.comboBox_2.SelectedIndex)
		{
			return;
		}
		if (this.comboBox_2.SelectedValue.ToString() == this.int_4.ToString())
		{
			this.button_2.Enabled = false;
		}
		else
		{
			this.button_2.Enabled = true;
		}
		this.class12_0.int_0 = -1;
		this.class12_0.string_0 = string.Empty;
		this.textBox_2.Text = this.class12_0.string_0;
	}

	private void comboBox_2_DropDown(object sender, EventArgs e)
	{
		this.int_6 = this.comboBox_2.SelectedIndex;
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Form7.KkaK959g4rNc0g74qiMx(this, bool_0);
	}

	private void method_14()
	{
		this.tableLayoutPanel_0 = new TableLayoutPanel();
		this.label_0 = new Label();
		this.label_1 = new Label();
		this.label_2 = new Label();
		this.label_3 = new Label();
		this.label_4 = new Label();
		this.textBox_0 = new TextBox();
		this.class107_0 = new Class107();
		this.textBox_1 = new TextBox();
		this.comboBox_0 = new ComboBox();
		this.comboBox_1 = new ComboBox();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.textBox_2 = new TextBox();
		this.button_2 = new Button();
		this.comboBox_2 = new ComboBox();
		this.label_5 = new Label();
		this.tableLayoutPanel_0.SuspendLayout();
		((ISupportInitialize)this.class107_0).BeginInit();
		base.SuspendLayout();
		this.tableLayoutPanel_0.ColumnCount = 4;
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110f));
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70f));
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30f));
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57f));
		this.tableLayoutPanel_0.Controls.Add(this.label_0, 0, 0);
		this.tableLayoutPanel_0.Controls.Add(this.label_1, 0, 2);
		this.tableLayoutPanel_0.Controls.Add(this.label_2, 0, 3);
		this.tableLayoutPanel_0.Controls.Add(this.label_3, 0, 4);
		this.tableLayoutPanel_0.Controls.Add(this.label_4, 0, 5);
		this.tableLayoutPanel_0.Controls.Add(this.textBox_0, 1, 5);
		this.tableLayoutPanel_0.Controls.Add(this.textBox_1, 1, 4);
		this.tableLayoutPanel_0.Controls.Add(this.comboBox_0, 1, 0);
		this.tableLayoutPanel_0.Controls.Add(this.comboBox_1, 1, 3);
		this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 6);
		this.tableLayoutPanel_0.Controls.Add(this.button_1, 2, 6);
		this.tableLayoutPanel_0.Controls.Add(this.textBox_2, 1, 2);
		this.tableLayoutPanel_0.Controls.Add(this.button_2, 3, 1);
		this.tableLayoutPanel_0.Controls.Add(this.comboBox_2, 1, 1);
		this.tableLayoutPanel_0.Controls.Add(this.label_5, 0, 1);
		this.tableLayoutPanel_0.Dock = DockStyle.Fill;
		this.tableLayoutPanel_0.Location = new Point(0, 0);
		this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
		this.tableLayoutPanel_0.Padding = new Padding(10, 20, 10, 10);
		this.tableLayoutPanel_0.RowCount = 7;
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		this.tableLayoutPanel_0.Size = new Size(337, 217);
		this.tableLayoutPanel_0.TabIndex = 0;
		this.label_0.AutoSize = true;
		this.label_0.Dock = DockStyle.Fill;
		this.label_0.Location = new Point(13, 20);
		this.label_0.Name = "label1";
		this.label_0.Padding = new Padding(0, 5, 0, 0);
		this.label_0.Size = new Size(104, 25);
		this.label_0.TabIndex = 0;
		this.label_0.Text = "Линия";
		this.label_1.AutoSize = true;
		this.label_1.Dock = DockStyle.Fill;
		this.label_1.Location = new Point(13, 70);
		this.label_1.Name = "label2";
		this.label_1.Padding = new Padding(0, 5, 0, 0);
		this.label_1.Size = new Size(104, 25);
		this.label_1.TabIndex = 1;
		this.label_1.Text = "Объект";
		this.label_2.AutoSize = true;
		this.label_2.Dock = DockStyle.Fill;
		this.label_2.Location = new Point(13, 95);
		this.label_2.Name = "label3";
		this.label_2.Padding = new Padding(0, 5, 0, 0);
		this.label_2.Size = new Size(104, 25);
		this.label_2.TabIndex = 2;
		this.label_2.Text = "Марка кабеля";
		this.label_3.AutoSize = true;
		this.label_3.Dock = DockStyle.Fill;
		this.label_3.Location = new Point(13, 120);
		this.label_3.Name = "label4";
		this.label_3.Padding = new Padding(0, 5, 0, 0);
		this.label_3.Size = new Size(104, 25);
		this.label_3.TabIndex = 3;
		this.label_3.Text = "Сечение провода";
		this.label_4.AutoSize = true;
		this.label_4.Dock = DockStyle.Fill;
		this.label_4.Location = new Point(13, 145);
		this.label_4.Name = "label5";
		this.label_4.Padding = new Padding(0, 5, 0, 0);
		this.label_4.Size = new Size(104, 25);
		this.label_4.TabIndex = 4;
		this.label_4.Text = "Длина провода, м";
		this.tableLayoutPanel_0.SetColumnSpan(this.textBox_0, 3);
		this.textBox_0.DataBindings.Add(new Binding("Text", this.class107_0, "tP_CabBranches.cableLength", true));
		this.textBox_0.Dock = DockStyle.Fill;
		this.textBox_0.Location = new Point(123, 148);
		this.textBox_0.Name = "txtLength";
		this.textBox_0.Size = new Size(201, 20);
		this.textBox_0.TabIndex = 7;
		this.class107_0.DataSetName = "dsPassport";
		this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.tableLayoutPanel_0.SetColumnSpan(this.textBox_1, 3);
		this.textBox_1.DataBindings.Add(new Binding("Text", this.class107_0, "tP_CabBranches.wireGauge", true));
		this.textBox_1.Dock = DockStyle.Fill;
		this.textBox_1.Location = new Point(123, 123);
		this.textBox_1.Name = "txtGauge";
		this.textBox_1.Size = new Size(201, 20);
		this.textBox_1.TabIndex = 6;
		this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.tableLayoutPanel_0.SetColumnSpan(this.comboBox_0, 3);
		this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.class107_0, "tP_CabBranches.idAirLine", true));
		this.comboBox_0.Dock = DockStyle.Fill;
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Location = new Point(123, 23);
		this.comboBox_0.Name = "cbAirLine";
		this.comboBox_0.Size = new Size(201, 21);
		this.comboBox_0.TabIndex = 1;
		this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.tableLayoutPanel_0.SetColumnSpan(this.comboBox_1, 3);
		this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.class107_0, "tP_CabBranches.cableMakeup", true));
		this.comboBox_1.Dock = DockStyle.Fill;
		this.comboBox_1.FormattingEnabled = true;
		this.comboBox_1.Location = new Point(123, 98);
		this.comboBox_1.Name = "cbCabMakeup";
		this.comboBox_1.Size = new Size(201, 21);
		this.comboBox_1.TabIndex = 5;
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_0.DialogResult = DialogResult.OK;
		this.button_0.Location = new Point(147, 181);
		this.button_0.Name = "btnOK";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 8;
		this.button_0.Text = "ОК";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_0_Click;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.tableLayoutPanel_0.SetColumnSpan(this.button_1, 2);
		this.button_1.DialogResult = DialogResult.Cancel;
		this.button_1.Location = new Point(228, 181);
		this.button_1.Name = "btnCancel";
		this.button_1.Size = new Size(75, 23);
		this.button_1.TabIndex = 9;
		this.button_1.Text = "Отмена";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		this.textBox_2.BackColor = SystemColors.Window;
		this.tableLayoutPanel_0.SetColumnSpan(this.textBox_2, 3);
		this.textBox_2.Dock = DockStyle.Fill;
		this.textBox_2.Location = new Point(123, 73);
		this.textBox_2.Name = "txtObj";
		this.textBox_2.ReadOnly = true;
		this.textBox_2.Size = new Size(201, 20);
		this.textBox_2.TabIndex = 4;
		this.button_2.Dock = DockStyle.Fill;
		this.button_2.Location = new Point(270, 45);
		this.button_2.Margin = new Padding(0);
		this.button_2.Name = "btnObj";
		this.button_2.Size = new Size(57, 25);
		this.button_2.TabIndex = 3;
		this.button_2.Text = "Обзор";
		this.button_2.UseVisualStyleBackColor = true;
		this.button_2.Click += this.button_2_Click;
		this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.tableLayoutPanel_0.SetColumnSpan(this.comboBox_2, 2);
		this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.class107_0, "tR_Classifier.Id", true));
		this.comboBox_2.Dock = DockStyle.Fill;
		this.comboBox_2.FormattingEnabled = true;
		this.comboBox_2.Location = new Point(123, 48);
		this.comboBox_2.Name = "cbObjType";
		this.comboBox_2.Size = new Size(144, 21);
		this.comboBox_2.TabIndex = 2;
		this.comboBox_2.DropDown += this.comboBox_2_DropDown;
		this.comboBox_2.SelectedValueChanged += this.comboBox_2_SelectedValueChanged;
		this.label_5.AutoSize = true;
		this.label_5.Dock = DockStyle.Fill;
		this.label_5.Location = new Point(13, 45);
		this.label_5.Name = "label6";
		this.label_5.Padding = new Padding(0, 5, 0, 0);
		this.label_5.Size = new Size(104, 25);
		this.label_5.TabIndex = 10;
		this.label_5.Text = "Тип объекта";
		base.AcceptButton = this.button_0;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(337, 217);
		base.Controls.Add(this.tableLayoutPanel_0);
		base.Name = "FormAddEditCabBranch";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Отводы";
		base.Load += this.Form7_Load;
		this.tableLayoutPanel_0.ResumeLayout(false);
		this.tableLayoutPanel_0.PerformLayout();
		((ISupportInitialize)this.class107_0).EndInit();
		base.ResumeLayout(false);
	}

	internal static void KkaK959g4rNc0g74qiMx(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private Class12 class12_0;

	private Class107.Class288 class288_0;

	private Class107.Class289 class289_0;

	private string string_0;

	private string string_1;

	private int int_4;

	private int int_5;

	[CompilerGenerated]
	private StateFormCreate stateFormCreate_0;

	private int int_6;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private ComboBox comboBox_0;

	private ComboBox comboBox_1;

	private Button button_0;

	private Button button_1;

	private Class107 class107_0;

	private TextBox textBox_2;

	private Button button_2;

	private ComboBox comboBox_2;

	private Label label_5;
}
