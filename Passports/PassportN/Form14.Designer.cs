using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Constants;
using ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty;
using DataSql;
using FormLbr;
using Passport.Properties;

internal class Form14 : FormBase
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

	internal Form14(int int_2, int int_3, decimal decimal_1)
	{
		Class330.Mus9JxKz1CNxy();
		this.int_0 = -1;
		this.int_1 = -1;
		this.decimal_0 = -1m;
		base..ctor();
		this.method_24();
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.decimal_0 = decimal_1;
	}

	private void Form14_Load(object sender, EventArgs e)
	{
		this.method_3();
		this.method_7();
		StateFormCreate stateFormCreate = this.method_0();
		if (stateFormCreate != null)
		{
			if (stateFormCreate == 1 || stateFormCreate == 7)
			{
				this.GyMmPqrgiyG();
				this.method_11();
			}
		}
		else
		{
			this.method_8();
			this.method_9();
		}
		this.method_12();
		this.comboBox_1.SelectedValueChanged += this.comboBox_1_SelectedValueChanged;
	}

	private void Form14_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK && !this.method_13())
		{
			base.DialogResult = DialogResult.None;
			e.Cancel = true;
		}
	}

	private void method_3()
	{
		StateFormCreate stateFormCreate = this.method_0();
		if (stateFormCreate != null)
		{
			if (stateFormCreate != 1)
			{
				if (stateFormCreate == 7)
				{
					Control control = this.comboBox_1;
					Control control2 = this.comboBox_1;
					this.numericUpDown_0.Enabled = false;
					control2.Visible = false;
					control.Enabled = false;
					this.numericUpDown_0.Visible = true;
					this.dataGridView_0.ReadOnly = true;
					this.dataGridView_0.AllowUserToAddRows = false;
					this.dataGridView_0.AllowUserToDeleteRows = false;
				}
			}
			else
			{
				Control control3 = this.comboBox_1;
				Control control4 = this.comboBox_1;
				this.numericUpDown_0.Enabled = false;
				control4.Visible = false;
				control3.Enabled = false;
				this.numericUpDown_0.Visible = true;
			}
		}
		else if (this.decimal_0 == Convert.ToDecimal((Form14.Enum5)1))
		{
			Control control5 = this.comboBox_1;
			this.comboBox_1.Visible = false;
			control5.Enabled = false;
			Control control6 = this.numericUpDown_0;
			this.numericUpDown_0.Visible = true;
			control6.Enabled = true;
		}
		else if (this.decimal_0 == Convert.ToDecimal((Form14.Enum5)7))
		{
			Control control7 = this.comboBox_1;
			this.comboBox_1.Visible = true;
			control7.Enabled = true;
			Control control8 = this.numericUpDown_0;
			this.numericUpDown_0.Visible = false;
			control8.Enabled = false;
			this.method_5();
		}
		if (this.decimal_0 == Convert.ToDecimal((Form14.Enum5)1))
		{
			this.label_3.Text = "От кого";
			this.Text = "Принятие на баланс " + this.method_21(this.int_0);
		}
		else if (this.decimal_0 == Convert.ToDecimal((Form14.Enum5)7))
		{
			this.label_3.Text = "Кто";
			this.Text = "Модернизация/реконструкция " + this.method_21(this.int_0);
		}
		this.method_4();
	}

	private void method_4()
	{
		base.SelectSqlData(this.class14_0.tAbn, true, "WHERE Deleted = ((0)) AND TypeAbn IN (207, 230, 231, 614, 683)", null, false, 0);
		BindingSource bindingSource = new BindingSource();
		bindingSource.DataSource = this.class14_0.tAbn;
		bindingSource.Sort = "Name";
		this.comboBox_0.DataSource = bindingSource;
		this.comboBox_0.DisplayMember = "Name";
		this.comboBox_0.ValueMember = "id";
		this.comboBox_0.SelectedIndex = -1;
	}

	private void method_5()
	{
		this.comboBox_1.SelectedValueChanged -= this.comboBox_1_SelectedValueChanged;
		DataTable dataTable = new DataTable("tSchm_ObjList");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("Name", typeof(string));
		dataTable.Columns.Add("typeCodeId", typeof(int));
		string text = string.Format("where idParent = '{0}' and deleted = '0'\r\nand typeCodeId in (Select id from tR_Classifier where ParentKey = '{1}' and Value = '1'\r\nand deleted = '0' and isGroup = '0')\r\n--and id not in (select idSector from tP_DocList where Deleted = '0' and idObjList = '{0}'\r\n--and TypeDoc in (select id from tR_Classifier where ParentKey = ';TypeDoc;tPassport;PS;' and Value = '1'\r\n--and Deleted = '0' and IsGroup = '0'))", this.int_0, ";SCM;Sector;");
		base.SelectSqlData(dataTable, true, text, null, false, 0);
		this.comboBox_1.DataSource = dataTable;
		this.comboBox_1.DisplayMember = "Name";
		this.comboBox_1.ValueMember = "id";
	}

	private int method_6()
	{
		string text = string.Format("select ISNULL(max(CAST(Name as int)) + 1, 1) as SectorNum\r\nfrom tSchm_ObjList\r\nwhere idParent = '{0}' and deleted = '0'\r\nand typeCodeId in (Select id from tR_Classifier where ParentKey = '{1}' and Value = '1'\r\nand deleted = '0' and isGroup = '0')\r\n", this.int_0, ";SCM;Sector;");
		return Convert.ToInt32(new SqlDataCommand(this.SqlSettings).SelectSqlData(text).Rows[0]["SectorNum"]);
	}

	private void method_7()
	{
		this.dataTable_0 = new DataTable("tSchm_ObjList");
		this.dataTable_0.Columns.Add("id", typeof(int));
		this.dataTable_0.Columns.Add("Name", typeof(string));
		this.dataTable_0.Columns.Add("typeCodeId", typeof(int));
		string text = string.Format("WHERE ((idParent = '{0}' AND typeCodeId IN (SELECT id FROM tR_Classifier\r\nWHERE ParentKey = ';SCM;Pole;' and deleted = '0' AND isGroup = '0'))\r\nOR (id IN (SELECT idClutchFirst as idPylon FROM tP_CabSection\r\nWHERE idObjList = '{0}' and deleted = '0' UNION\r\nSELECT idClutchSecond as idPylon FROM tP_CabSection\r\nWHERE idObjList = '{0}' and deleted = '0'))) AND deleted = '0'", this.int_0);
		base.SelectSqlData(this.dataTable_0, true, text, null, false, 0);
	}

	private void method_8()
	{
		DataRow dataRow = this.class14_0.tP_DocList.NewRow();
		dataRow["ParentId"] = -1;
		dataRow["idObjList"] = this.int_0;
		dataRow["dateDoc"] = this.method_10();
		dataRow["typeDoc"] = this.method_22(";TypeDoc;tPassport;PS;", this.decimal_0);
		dataRow["isActive"] = true;
		dataRow["deleted"] = false;
		this.class14_0.tP_DocList.Rows.Add(dataRow);
	}

	private void method_9()
	{
		DataRow dataRow = this.class14_0.tSchm_ObjList.NewRow();
		dataRow["Name"] = this.method_6();
		dataRow["typeCodeId"] = this.method_22(";SCM;Sector;", 1m);
		dataRow["idParent"] = this.int_0;
		dataRow["deleted"] = false;
		this.class14_0.tSchm_ObjList.Rows.Add(dataRow);
	}

	private DateTime method_10()
	{
		if (this.method_0() != null || !(this.decimal_0 == Convert.ToDecimal((Form14.Enum5)7)))
		{
			return DateTime.Now;
		}
		string text = string.Format("where idObjList = '{0}' and deleted = '0' order by dateDoc desc", this.int_0);
		DataTable dataTable = new DataTable("tP_DocList");
		base.SelectSqlData(dataTable, true, text, null, false, 0);
		if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["dateDoc"] != null && dataTable.Rows[0]["dateDoc"] is DateTime)
		{
			return Convert.ToDateTime(dataTable.Rows[0]["dateDoc"]).AddDays(1.0);
		}
		return DateTime.Now;
	}

	private void GyMmPqrgiyG()
	{
		base.SelectSqlData(this.class14_0.tP_DocList, true, string.Format("where id = '{0}'", this.int_1), null, false, 0);
		if (this.class14_0.tP_DocList.Rows.Count > 0 && this.class14_0.tP_DocList[0]["DataXml"] != DBNull.Value)
		{
			this.method_20(Convert.ToString(this.class14_0.tP_DocList[0]["DataXml"]));
		}
	}

	private void method_11()
	{
		if (this.class14_0.tP_DocList.Rows.Count == 0)
		{
			this.method_9();
			return;
		}
		int num = -1;
		int.TryParse(this.class14_0.tP_DocList[0]["idSector"].ToString(), out num);
		base.SelectSqlData(this.class14_0.tSchm_ObjList, true, string.Format("where id = '{0}' --and deleted = '0'", num), null, false, 0);
	}

	private void method_12()
	{
		if (!(this.decimal_0 == Convert.ToDecimal((Form14.Enum5)7)) || this.method_0() != null)
		{
			base.SelectSqlData(this.class14_0.tP_BalanceEquipment, true, string.Format("where idDocList = '{0}'", this.int_1), null, false, 0);
			return;
		}
		if (this.comboBox_1.SelectedItem == null)
		{
			return;
		}
		int num = Convert.ToInt32(((DataRowView)this.comboBox_1.SelectedItem)["id"]);
		string commandText = string.Format("select eq.id, eq.idDocList, eq.idEquipment, null as [action]\r\nfrom tP_BalanceEquipment as eq\r\nwhere (eq.[action] <> 'deleted' or eq.[action] is null)\r\nand idDocList = (select top 1 doc.id from tP_DocList as doc \r\n                inner join tR_Classifier as c_doc on c_doc.Id = doc.TypeDoc\r\n                and c_doc.Deleted = '0' and c_doc.IsGroup = '0'\r\n                and c_doc.ParentKey = ';TypeDoc;tPassport;PS;' and c_doc.Value in ('1','7')\r\n                where doc.Deleted = '0' and doc.idObjList = '{0}' and doc.idSector = '{1}'\r\n                order by doc.DateDoc desc)", this.int_0, num);
		SqlDataConnect sqlDataConnect = new SqlDataConnect();
		sqlDataConnect.OpenConnection(this.SqlSettings);
		SqlCommand sqlCommand = new SqlCommand();
		sqlCommand.Connection = sqlDataConnect.Connection;
		sqlCommand.CommandType = CommandType.Text;
		sqlCommand.CommandText = commandText;
		if (this.class14_0.tP_BalanceEquipment != null)
		{
			this.class14_0.tP_BalanceEquipment.Clear();
		}
		new SqlDataAdapter(sqlCommand).Fill(this.class14_0.tP_BalanceEquipment);
		sqlDataConnect.CloseConnection();
	}

	private bool method_13()
	{
		if (!this.method_16())
		{
			return false;
		}
		if (!this.method_17())
		{
			return false;
		}
		StateFormCreate stateFormCreate = this.method_0();
		if (stateFormCreate != null)
		{
			if (stateFormCreate == 1)
			{
				this.class14_0.tP_DocList[0]["DataXml"] = this.method_19();
				this.class14_0.tP_DocList[0].EndEdit();
				base.UpdateSqlDataOnlyChange(this.class14_0.tP_DocList);
			}
		}
		else
		{
			int num = -1;
			if (this.decimal_0 == Convert.ToDecimal((Form14.Enum5)1))
			{
				this.class14_0.tSchm_ObjList.get_IlxaYnvrcqN(0)["Name"] = this.numericUpDown_0.Value.ToString();
				this.class14_0.tSchm_ObjList.get_IlxaYnvrcqN(0).EndEdit();
				num = base.InsertSqlDataOneRow(this.class14_0.tSchm_ObjList.get_IlxaYnvrcqN(0));
				if (num == -1)
				{
					return false;
				}
			}
			else if (this.decimal_0 == Convert.ToDecimal((Form14.Enum5)7))
			{
				num = Convert.ToInt32(this.comboBox_1.SelectedValue);
			}
			this.class14_0.tP_DocList[0]["idSector"] = num;
			this.class14_0.tP_DocList[0]["DataXml"] = this.method_19();
			if (this.decimal_0 == Convert.ToDecimal((Form14.Enum5)1))
			{
				this.class14_0.tP_DocList[0]["ParentId"] = -1;
			}
			else if (this.decimal_0 == Convert.ToDecimal((Form14.Enum5)7))
			{
				this.class14_0.tP_DocList[0]["ParentId"] = this.method_18(this.int_0, num, Convert.ToDecimal((Form14.Enum5)1));
			}
			this.class14_0.tP_DocList[0].EndEdit();
			this.int_1 = base.InsertSqlDataOneRow(this.class14_0.tP_DocList[0]);
			if (this.int_1 == -1)
			{
				return false;
			}
		}
		this.method_14();
		return true;
	}

	private bool method_14()
	{
		foreach (object obj in this.class14_0.tP_BalanceEquipment.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			if (dataRow.RowState != DataRowState.Deleted)
			{
				dataRow["idDocList"] = this.int_1;
				dataRow.EndEdit();
			}
		}
		if (this.method_0() == null)
		{
			this.class14_0.tP_BalanceEquipment.AcceptChanges();
			foreach (object obj2 in this.class14_0.tP_BalanceEquipment.Rows)
			{
				((DataRow)obj2).SetAdded();
			}
			if (!base.InsertSqlData(this.class14_0.tP_BalanceEquipment))
			{
				return false;
			}
			DataView defaultView = this.class14_0.tP_BalanceEquipment.DefaultView;
			defaultView.RowFilter = "action = 'deleted'";
			if (defaultView.Count == this.class14_0.tP_BalanceEquipment.Count)
			{
				new SqlDataCommand(this.SqlSettings).UpdateSqlData(new DataTable("tSchm_ObjList"), "set deleted = '1'", string.Format("where id = '{0}'", this.class14_0.tP_DocList[0]["idSector"]));
			}
		}
		else if (this.method_0() == 1)
		{
			if (!base.UpdateSqlData(this.class14_0.tP_BalanceEquipment))
			{
				return false;
			}
			if (!base.DeleteSqlData(this.class14_0.tP_BalanceEquipment))
			{
				return false;
			}
			if (!base.InsertSqlData(this.class14_0.tP_BalanceEquipment))
			{
				return false;
			}
		}
		return true;
	}

	private bool method_15()
	{
		if (this.method_0() != null)
		{
			return true;
		}
		if (this.decimal_0 == Convert.ToDecimal((Form14.Enum5)1))
		{
			if (this.numericUpDown_0.Value <= 0m)
			{
				MessageBox.Show("Номер участка должен быть больше нуля.");
				return false;
			}
		}
		else if (this.decimal_0 == Convert.ToDecimal((Form14.Enum5)7) && this.comboBox_1.SelectedIndex == -1)
		{
			MessageBox.Show("Выберите участок.");
			return false;
		}
		return true;
	}

	private bool method_16()
	{
		if (!this.method_15())
		{
			return false;
		}
		StateFormCreate stateFormCreate = this.method_0();
		if (stateFormCreate != null)
		{
			return stateFormCreate == 1 || true;
		}
		if (this.decimal_0 == Convert.ToDecimal((Form14.Enum5)7))
		{
			return true;
		}
		int num = Convert.ToInt32(this.numericUpDown_0.Value);
		DataTable dataTable = new DataTable("tSchm_ObjList");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("Name", typeof(string));
		dataTable.Columns.Add("typeCodeId", typeof(int));
		string text = string.Format("where idParent = '{0}' and deleted = '0' and Name = '{1}'\r\nand typeCodeId in (select id from tR_Classifier where ParentKey = '{2}' and Value = '1'\r\nand deleted = '0' and isGroup = '0')", this.int_0, num, ";SCM;Sector;");
		base.SelectSqlData(dataTable, true, text, null, false, 0);
		if (dataTable.Rows.Count > 0)
		{
			MessageBox.Show(string.Format("На линии {0} уже имеется участок с номером - {1}.\r\nПожалуйста, выберите другой номер участка.", this.method_21(this.int_0), num));
			return false;
		}
		return true;
	}

	private bool method_17()
	{
		if (this.dataGridView_0.NewRowIndex == 0)
		{
			MessageBox.Show("Невозмжно сохранить документ. Добавьте хотя бы одну опору.");
			return false;
		}
		return true;
	}

	private int method_18(int int_2, int int_3, decimal decimal_1)
	{
		string text = string.Format("select doc.id from tP_DocList as doc\r\nwhere doc.idObjList = '{0}' and doc.idSector = '{1}' and doc.deleted = '0'\r\nand doc.typeDoc = (select id from tR_Classifier where ParentKey = ';TypeDoc;tPassport;PS;' and Value = '{2}'\r\nand deleted = '0' and isGroup = '0')", int_2, int_3, decimal_1);
		DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
		if (dataTable.Rows.Count > 0)
		{
			return Convert.ToInt32(dataTable.Rows[0]["id"]);
		}
		return -1;
	}

	private XDocument method_19()
	{
		XDocument xdocument = new XDocument();
		xdocument.Add(new XElement("AddlInfo", new object[]
		{
			new XAttribute("invNumber", this.textBox_1.Text),
			new XAttribute("idAbn", (this.comboBox_0.SelectedItem == null) ? string.Empty : ((DataRowView)this.comboBox_0.SelectedItem).Row["id"].ToString())
		}));
		return xdocument;
	}

	private void method_20(string string_0)
	{
		XElement root = XDocument.Load(new StringReader(string_0)).Root;
		this.textBox_1.Text = Convert.ToString(root.Attribute("invNumber").Value);
		int num;
		if (int.TryParse(root.Attribute("idAbn").Value, out num))
		{
			this.comboBox_0.SelectedValue = num;
		}
	}

	private string method_21(int int_2)
	{
		string text = "select ISNULL(c_ol.SocrName + ' - ', '') + ol.Name as FullName\r\nfrom tSchm_ObjList as ol\r\nleft join tR_Classifier as c_ol on c_ol.id = ol.typeCodeId\r\n" + string.Format("where ol.id = '{0}'", int_2);
		DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
		if (dataTable != null && dataTable.Rows.Count > 0)
		{
			return Convert.ToString(dataTable.Rows[0]["FullName"]);
		}
		return string.Empty;
	}

	private int method_22(string string_0, decimal decimal_1)
	{
		DataTable dataTable = new DataTable("tR_Classifier");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("Name", typeof(string));
		string text = string.Format("where ParentKey = '{0}' and Value = '{1}'\r\n and deleted = '0' and isGroup = '0'", string_0, decimal_1);
		base.SelectSqlData(dataTable, true, text, null, false, 0);
		if (dataTable.Rows.Count > 0)
		{
			return Convert.ToInt32(dataTable.Rows[0]["id"]);
		}
		return -1;
	}

	private void dataGridView_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		if (this.dataTable_0 == null)
		{
			return;
		}
		for (int i = 0; i < e.RowCount; i++)
		{
			DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.dataGridView_0[this.dataGridViewComboBoxColumn_1.Name, e.RowIndex + i];
			dataGridViewComboBoxCell.DataSource = new BindingSource
			{
				DataSource = this.dataTable_0.Copy()
			};
			dataGridViewComboBoxCell.DisplayMember = "Name";
			dataGridViewComboBoxCell.ValueMember = "id";
		}
	}

	private void dataGridView_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.RowIndex == -1)
		{
			return;
		}
		DataGridView dataGridView = (DataGridView)sender;
		if (dataGridView[this.dataGridViewTextBoxColumn_6.Index, e.RowIndex].Value is string)
		{
			if (Convert.ToString(dataGridView[this.dataGridViewTextBoxColumn_6.Index, e.RowIndex].Value) == Convert.ToString((Form14.Enum6)1))
			{
				e.CellStyle.ForeColor = Color.Red;
				return;
			}
			if (Convert.ToString(dataGridView[this.dataGridViewTextBoxColumn_6.Index, e.RowIndex].Value) == Convert.ToString((Form14.Enum6)2))
			{
				e.CellStyle.ForeColor = Color.Green;
			}
		}
	}

	private void dataGridView_0_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (e.Control is DataGridViewComboBoxEditingControl)
		{
			DataGridViewComboBoxEditingControl dataGridViewComboBoxEditingControl = (DataGridViewComboBoxEditingControl)e.Control;
			dataGridViewComboBoxEditingControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			dataGridViewComboBoxEditingControl.AutoCompleteSource = AutoCompleteSource.ListItems;
			dataGridViewComboBoxEditingControl.DropDownStyle = ComboBoxStyle.DropDown;
			BindingSource bindingSource = (BindingSource)dataGridViewComboBoxEditingControl.DataSource;
			if (bindingSource != null)
			{
				bindingSource.Filter = string.Empty;
				StringBuilder stringBuilder = new StringBuilder();
				foreach (object obj in ((IEnumerable)dataGridView.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					if (!dataGridViewRow.IsNewRow && (dataGridView.CurrentCell == null || dataGridView.CurrentCell.RowIndex != dataGridViewRow.Index) && dataGridViewRow.Cells[this.dataGridViewComboBoxColumn_1.Index].Value != null && (!(dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_6.Index].Value is string) || !(dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_6.Index].Value.ToString() == "deleted")))
					{
						stringBuilder.AppendFormat(",{0}", dataGridViewRow.Cells[this.dataGridViewComboBoxColumn_1.Index].Value);
					}
				}
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Remove(0, 1);
					bindingSource.Filter = string.Format("id not in ({0})", stringBuilder);
				}
				if (dataGridView.CurrentCell != null && dataGridView.CurrentCell.Value != null)
				{
					dataGridViewComboBoxEditingControl.SelectedValue = dataGridView.CurrentCell.Value;
				}
			}
		}
	}

	private void dataGridView_0_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
		e.ThrowException = false;
		e.Cancel = true;
	}

	private void dataGridView_0_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		object value = dataGridView.Rows[e.RowIndex].HeaderCell.Value;
		if (value == null || !value.Equals((e.RowIndex + 1).ToString()))
		{
			dataGridView.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
		}
	}

	private void dataGridView_0_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		if (e.RowIndex < 0)
		{
			return;
		}
		if (((DataGridView)sender).Rows[e.RowIndex].IsNewRow)
		{
			return;
		}
		if (e.ColumnIndex == this.dataGridViewButtonColumn_1.Index)
		{
			e.Paint(e.CellBounds, DataGridViewPaintParts.All);
			Image image = Resources.smethod_20();
			float x = (float)(e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2);
			float y = (float)(e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2);
			e.Graphics.DrawImage(image, x, y, (float)image.Width, (float)image.Height);
			e.Handled = true;
		}
		if (e.ColumnIndex == this.dataGridViewButtonColumn_2.Index)
		{
			e.Paint(e.CellBounds, DataGridViewPaintParts.All);
			Image image2 = Resources.smethod_61();
			float x2 = (float)(e.CellBounds.Left + (e.CellBounds.Width - image2.Width) / 2);
			float y2 = (float)(e.CellBounds.Top + (e.CellBounds.Height - image2.Height) / 2);
			e.Graphics.DrawImage(image2, x2, y2, (float)image2.Width, (float)image2.Height);
			e.Handled = true;
		}
	}

	private void dataGridView_0_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (this.method_0() == 7)
		{
			return;
		}
		DataGridView dataGridView = (DataGridView)sender;
		if (dataGridView.CurrentRow.IsNewRow)
		{
			return;
		}
		if (e.ColumnIndex == this.dataGridViewButtonColumn_1.Index)
		{
			if (this.method_0() == 1 && this.decimal_0 == Convert.ToDecimal((Form14.Enum5)1))
			{
				dataGridView.Rows.RemoveAt(e.RowIndex);
				return;
			}
			if (Convert.ToInt32(dataGridView[this.dataGridViewTextBoxColumn_4.Index, e.RowIndex].Value) < 0)
			{
				dataGridView.Rows.RemoveAt(e.RowIndex);
			}
			else
			{
				dataGridView[this.dataGridViewTextBoxColumn_6.Index, e.RowIndex].Value = Convert.ToString((Form14.Enum6)1);
			}
		}
		if (e.ColumnIndex == this.dataGridViewButtonColumn_2.Index)
		{
			if (this.decimal_0 == Convert.ToDecimal((Form14.Enum5)1))
			{
				return;
			}
			if (Convert.ToInt32(dataGridView[this.dataGridViewTextBoxColumn_4.Index, e.RowIndex].Value) > 0)
			{
				dataGridView[this.dataGridViewTextBoxColumn_6.Index, e.RowIndex].Value = null;
			}
		}
	}

	private void dataGridView_0_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (dataGridView.CurrentRow.IsNewRow)
		{
			return;
		}
		if (e.ColumnIndex == this.dataGridViewComboBoxColumn_1.Index && Convert.ToInt32(dataGridView[this.dataGridViewTextBoxColumn_4.Index, e.RowIndex].Value) > 0)
		{
			e.Cancel = true;
		}
	}

	private void dataGridView_0_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		this.method_23((DataGridView)sender, e.RowIndex, e.ColumnIndex);
	}

	private void method_23(DataGridView dataGridView_1, int int_2, int int_3)
	{
		if (int_2 < 0)
		{
			return;
		}
		if (int_3 == this.dataGridViewTextBoxColumn_6.Index)
		{
			if (Convert.ToString(dataGridView_1[this.dataGridViewTextBoxColumn_6.Index, int_2].Value) == Convert.ToString((Form14.Enum6)1))
			{
				dataGridView_1[this.dataGridViewTextBoxColumn_7.Index, int_2].Value = "удалена";
				return;
			}
			if (Convert.ToString(dataGridView_1[this.dataGridViewTextBoxColumn_6.Index, int_2].Value) == Convert.ToString((Form14.Enum6)2))
			{
				dataGridView_1[this.dataGridViewTextBoxColumn_7.Index, int_2].Value = "добавлена";
				return;
			}
			if (dataGridView_1[this.dataGridViewTextBoxColumn_6.Index, int_2].Value == null || dataGridView_1[this.dataGridViewTextBoxColumn_6.Index, int_2].Value == DBNull.Value)
			{
				dataGridView_1[this.dataGridViewTextBoxColumn_7.Index, int_2].Value = string.Empty;
			}
		}
	}

	private void dataGridView_0_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
	{
		foreach (object obj in ((IEnumerable)this.dataGridView_0.Rows))
		{
			DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
			if (!dataGridViewRow.IsNewRow)
			{
				this.method_23(this.dataGridView_0, dataGridViewRow.Index, this.dataGridViewTextBoxColumn_6.Index);
			}
		}
	}

	private void dataGridView_0_UserAddedRow(object sender, DataGridViewRowEventArgs e)
	{
		((DataGridView)sender)[this.dataGridViewTextBoxColumn_6.Index, e.Row.Index - 1].Value = Convert.ToString((Form14.Enum6)2);
	}

	private void dataGridView_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (this.bindingSource_0.Current == null)
		{
			return;
		}
		if (e.KeyCode == Keys.Delete && Convert.ToInt32(((DataRowView)this.bindingSource_0.Current).Row[this.dataGridViewTextBoxColumn_4.Index]) > 0)
		{
			((DataRowView)this.bindingSource_0.Current).Row[this.dataGridViewTextBoxColumn_6.Index] = Convert.ToString((Form14.Enum6)1);
			e.Handled = true;
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void comboBox_1_SelectedValueChanged(object sender, EventArgs e)
	{
		this.method_12();
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Form14.oj0nOe9LklXYkU91L2rd(this, bool_0);
	}

	private void method_24()
	{
		this.icontainer_0 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
		this.label_0 = new Label();
		this.textBox_0 = new TextBox();
		this.class14_0 = new Class14();
		this.dateTimePicker_0 = new DateTimePicker();
		this.label_1 = new Label();
		this.label_2 = new Label();
		this.textBox_1 = new TextBox();
		this.label_3 = new Label();
		this.comboBox_0 = new ComboBox();
		this.wLjmPevUwc4 = new Label();
		this.tableLayoutPanel_0 = new TableLayoutPanel();
		this.numericUpDown_0 = new NumericUpDown();
		this.comboBox_1 = new ComboBox();
		this.label_4 = new Label();
		this.dataGridView_0 = new DataGridView();
		this.dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
		this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		this.dataGridViewButtonColumn_1 = new DataGridViewButtonColumn();
		this.dataGridViewButtonColumn_2 = new DataGridViewButtonColumn();
		this.dataGridViewImageButtonColumn_1 = new DataGridViewImageButtonColumn();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.label_5 = new Label();
		this.richTextBox_0 = new RichTextBox();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
		this.dataGridViewButtonColumn_0 = new DataGridViewButtonColumn();
		this.dataGridViewImageButtonColumn_0 = new DataGridViewImageButtonColumn();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		((ISupportInitialize)this.class14_0).BeginInit();
		this.tableLayoutPanel_0.SuspendLayout();
		((ISupportInitialize)this.numericUpDown_0).BeginInit();
		((ISupportInitialize)this.dataGridView_0).BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		base.SuspendLayout();
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(12, 41);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(86, 13);
		this.label_0.TabIndex = 0;
		this.label_0.Text = "Номер приказа";
		this.textBox_0.DataBindings.Add(new Binding("Text", this.class14_0, "tP_DocList.NumberDoc", true));
		this.textBox_0.Location = new Point(104, 38);
		this.textBox_0.Name = "txtDocNum";
		this.textBox_0.Size = new Size(127, 20);
		this.textBox_0.TabIndex = 2;
		this.class14_0.DataSetName = "dsDocuments";
		this.class14_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.class14_0, "tP_DocList.DateDoc", true));
		this.dateTimePicker_0.Location = new Point(104, 12);
		this.dateTimePicker_0.Name = "dtpDateDoc";
		this.dateTimePicker_0.Size = new Size(127, 20);
		this.dateTimePicker_0.TabIndex = 1;
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(12, 15);
		this.label_1.Name = "label2";
		this.label_1.Size = new Size(78, 13);
		this.label_1.TabIndex = 3;
		this.label_1.Text = "Дата приказа";
		this.label_2.AutoSize = true;
		this.label_2.Location = new Point(12, 67);
		this.label_2.Name = "label3";
		this.label_2.Size = new Size(44, 13);
		this.label_2.TabIndex = 4;
		this.label_2.Text = "Инв. №";
		this.textBox_1.Location = new Point(104, 64);
		this.textBox_1.Name = "txtInvNum";
		this.textBox_1.Size = new Size(127, 20);
		this.textBox_1.TabIndex = 3;
		this.label_3.AutoSize = true;
		this.label_3.Location = new Point(12, 93);
		this.label_3.Name = "lblWho";
		this.label_3.Size = new Size(46, 13);
		this.label_3.TabIndex = 6;
		this.label_3.Text = "От кого";
		this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Location = new Point(104, 90);
		this.comboBox_0.Name = "cmbCompany";
		this.comboBox_0.Size = new Size(193, 21);
		this.comboBox_0.TabIndex = 4;
		this.wLjmPevUwc4.AutoSize = true;
		this.wLjmPevUwc4.Location = new Point(12, 119);
		this.wLjmPevUwc4.Name = "label5";
		this.wLjmPevUwc4.Size = new Size(83, 13);
		this.wLjmPevUwc4.TabIndex = 8;
		this.wLjmPevUwc4.Text = "Номер участка";
		this.tableLayoutPanel_0.ColumnCount = 1;
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		this.tableLayoutPanel_0.Controls.Add(this.numericUpDown_0, 0, 0);
		this.tableLayoutPanel_0.Controls.Add(this.comboBox_1, 0, 1);
		this.tableLayoutPanel_0.Location = new Point(104, 117);
		this.tableLayoutPanel_0.Name = "tlpSectorNum";
		this.tableLayoutPanel_0.RowCount = 2;
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel_0.Size = new Size(127, 42);
		this.tableLayoutPanel_0.TabIndex = 9;
		this.numericUpDown_0.DataBindings.Add(new Binding("Value", this.class14_0, "tSchm_ObjList.Name", true));
		this.numericUpDown_0.Dock = DockStyle.Fill;
		this.numericUpDown_0.Location = new Point(0, 0);
		this.numericUpDown_0.Margin = new Padding(0);
		NumericUpDown numericUpDown = this.numericUpDown_0;
		int[] array = new int[4];
		array[0] = 100000000;
		numericUpDown.Maximum = new decimal(array);
		NumericUpDown numericUpDown2 = this.numericUpDown_0;
		int[] array2 = new int[4];
		array2[0] = 1;
		numericUpDown2.Minimum = new decimal(array2);
		this.numericUpDown_0.Name = "nudSectorNum";
		this.numericUpDown_0.Size = new Size(127, 20);
		this.numericUpDown_0.TabIndex = 5;
		NumericUpDown numericUpDown3 = this.numericUpDown_0;
		int[] array3 = new int[4];
		array3[0] = 1;
		numericUpDown3.Value = new decimal(array3);
		this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.class14_0, "tP_DocList.idSector", true));
		this.comboBox_1.Dock = DockStyle.Fill;
		this.comboBox_1.Enabled = false;
		this.comboBox_1.FormattingEnabled = true;
		this.comboBox_1.Location = new Point(0, 20);
		this.comboBox_1.Margin = new Padding(0);
		this.comboBox_1.Name = "cmbSectorNum";
		this.comboBox_1.Size = new Size(127, 21);
		this.comboBox_1.TabIndex = 5;
		this.comboBox_1.Visible = false;
		this.comboBox_1.SelectedValueChanged += this.comboBox_1_SelectedValueChanged;
		this.label_4.AutoSize = true;
		this.label_4.Location = new Point(12, 146);
		this.label_4.Name = "label6";
		this.label_4.Size = new Size(41, 13);
		this.label_4.TabIndex = 10;
		this.label_4.Text = "Опоры";
		this.dataGridView_0.AutoGenerateColumns = false;
		this.dataGridView_0.BackgroundColor = SystemColors.Window;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		this.dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewComboBoxColumn_1,
			this.dataGridViewTextBoxColumn_4,
			this.dataGridViewTextBoxColumn_5,
			this.dataGridViewTextBoxColumn_6,
			this.dataGridViewTextBoxColumn_7,
			this.dataGridViewButtonColumn_1,
			this.dataGridViewButtonColumn_2,
			this.dataGridViewImageButtonColumn_1
		});
		this.dataGridView_0.DataSource = this.bindingSource_0;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = SystemColors.Window;
		dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
		this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle2;
		this.dataGridView_0.Location = new Point(15, 165);
		this.dataGridView_0.MultiSelect = false;
		this.dataGridView_0.Name = "dgvEquipment";
		dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = SystemColors.Control;
		dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle3.Padding = new Padding(0, 3, 0, 3);
		dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
		this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
		this.dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
		this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView_0.Size = new Size(378, 150);
		this.dataGridView_0.TabIndex = 6;
		this.dataGridView_0.CellBeginEdit += this.dataGridView_0_CellBeginEdit;
		this.dataGridView_0.CellClick += this.dataGridView_0_CellClick;
		this.dataGridView_0.CellFormatting += this.dataGridView_0_CellFormatting;
		this.dataGridView_0.CellPainting += this.dataGridView_0_CellPainting;
		this.dataGridView_0.CellValueChanged += this.dataGridView_0_CellValueChanged;
		this.dataGridView_0.DataBindingComplete += this.dataGridView_0_DataBindingComplete;
		this.dataGridView_0.DataError += this.dataGridView_0_DataError;
		this.dataGridView_0.EditingControlShowing += this.dataGridView_0_EditingControlShowing;
		this.dataGridView_0.RowPrePaint += this.dataGridView_0_RowPrePaint;
		this.dataGridView_0.RowsAdded += this.dataGridView_0_RowsAdded;
		this.dataGridView_0.UserAddedRow += this.dataGridView_0_UserAddedRow;
		this.dataGridView_0.KeyDown += this.dataGridView_0_KeyDown;
		this.dataGridViewComboBoxColumn_1.DataPropertyName = "idEquipment";
		this.dataGridViewComboBoxColumn_1.HeaderText = "Наименование";
		this.dataGridViewComboBoxColumn_1.Name = "idEquipmentDgvEquipment";
		this.dataGridViewComboBoxColumn_1.Resizable = DataGridViewTriState.True;
		this.dataGridViewComboBoxColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
		this.dataGridViewComboBoxColumn_1.Width = 150;
		this.dataGridViewTextBoxColumn_4.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_4.HeaderText = "id";
		this.dataGridViewTextBoxColumn_4.Name = "idDgvEquipment";
		this.dataGridViewTextBoxColumn_4.ReadOnly = true;
		this.dataGridViewTextBoxColumn_4.Visible = false;
		this.dataGridViewTextBoxColumn_5.DataPropertyName = "idDocList";
		this.dataGridViewTextBoxColumn_5.HeaderText = "idDocList";
		this.dataGridViewTextBoxColumn_5.Name = "idDocListDgvEquipment";
		this.dataGridViewTextBoxColumn_5.Visible = false;
		this.dataGridViewTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_6.DataPropertyName = "action";
		this.dataGridViewTextBoxColumn_6.HeaderText = "Действие";
		this.dataGridViewTextBoxColumn_6.Name = "actionDgvEquipment";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.Visible = false;
		this.dataGridViewTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_7.DataPropertyName = "state";
		this.dataGridViewTextBoxColumn_7.HeaderText = "Статус";
		this.dataGridViewTextBoxColumn_7.Name = "stateDgvEquipment";
		this.dataGridViewButtonColumn_1.HeaderText = "";
		this.dataGridViewButtonColumn_1.Name = "delBtnDgvEquipment";
		this.dataGridViewButtonColumn_1.Resizable = DataGridViewTriState.False;
		this.dataGridViewButtonColumn_1.Width = 25;
		this.dataGridViewButtonColumn_2.HeaderText = "";
		this.dataGridViewButtonColumn_2.Name = "restoreDgvEquipment";
		this.dataGridViewButtonColumn_2.Resizable = DataGridViewTriState.False;
		this.dataGridViewButtonColumn_2.Width = 25;
		this.dataGridViewImageButtonColumn_1.ButtonImage = Resources.smethod_20();
		this.dataGridViewImageButtonColumn_1.HeaderText = "Column1";
		this.dataGridViewImageButtonColumn_1.Name = "imgCol";
		this.dataGridViewImageButtonColumn_1.Resizable = DataGridViewTriState.True;
		this.dataGridViewImageButtonColumn_1.Visible = false;
		this.dataGridViewImageButtonColumn_1.Width = 35;
		this.bindingSource_0.DataMember = "tP_BalanceEquipment";
		this.bindingSource_0.DataSource = this.class14_0;
		this.label_5.AutoSize = true;
		this.label_5.Location = new Point(12, 321);
		this.label_5.Margin = new Padding(3, 3, 3, 0);
		this.label_5.Name = "label7";
		this.label_5.Size = new Size(70, 13);
		this.label_5.TabIndex = 12;
		this.label_5.Text = "Примечание";
		this.richTextBox_0.DataBindings.Add(new Binding("Text", this.class14_0, "tP_DocList.Comment", true));
		this.richTextBox_0.Location = new Point(15, 337);
		this.richTextBox_0.Name = "rtxtComment";
		this.richTextBox_0.Size = new Size(378, 66);
		this.richTextBox_0.TabIndex = 7;
		this.richTextBox_0.Text = "";
		this.button_0.DialogResult = DialogResult.Cancel;
		this.button_0.Location = new Point(318, 424);
		this.button_0.Name = "btnCancel";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 9;
		this.button_0.Text = "Отмена";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_1_Click;
		this.button_1.DialogResult = DialogResult.OK;
		this.button_1.Location = new Point(237, 424);
		this.button_1.Name = "btnOK";
		this.button_1.Size = new Size(75, 23);
		this.button_1.TabIndex = 8;
		this.button_1.Text = "ОК";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		this.dataGridViewComboBoxColumn_0.DataPropertyName = "idEquipment";
		this.dataGridViewComboBoxColumn_0.HeaderText = "Наименование";
		this.dataGridViewComboBoxColumn_0.Name = "dataGridViewComboBoxColumn1";
		this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
		this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
		this.dataGridViewComboBoxColumn_0.Width = 150;
		this.dataGridViewButtonColumn_0.HeaderText = "";
		this.dataGridViewButtonColumn_0.Name = "dataGridViewButtonColumn1";
		this.dataGridViewButtonColumn_0.Width = 25;
		this.dataGridViewImageButtonColumn_0.ButtonImage = Resources.smethod_20();
		this.dataGridViewImageButtonColumn_0.HeaderText = "Column1";
		this.dataGridViewImageButtonColumn_0.Name = "dataGridViewImageButtonColumn1";
		this.dataGridViewImageButtonColumn_0.Resizable = DataGridViewTriState.True;
		this.dataGridViewImageButtonColumn_0.Width = 35;
		this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_0.HeaderText = "id";
		this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewTextBoxColumn_0.Visible = false;
		this.dataGridViewTextBoxColumn_1.DataPropertyName = "idDocList";
		dataGridViewCellStyle4.NullValue = "-1";
		this.dataGridViewTextBoxColumn_1.DefaultCellStyle = dataGridViewCellStyle4;
		this.dataGridViewTextBoxColumn_1.HeaderText = "idDocList";
		this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
		this.dataGridViewTextBoxColumn_1.Visible = false;
		this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_2.DataPropertyName = "action";
		this.dataGridViewTextBoxColumn_2.HeaderText = "Статус";
		this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
		this.dataGridViewTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewTextBoxColumn_2.Visible = false;
		this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_3.DataPropertyName = "state";
		this.dataGridViewTextBoxColumn_3.HeaderText = "Статус";
		this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn4";
		this.dataGridViewTextBoxColumn_3.ReadOnly = true;
		base.AcceptButton = this.button_1;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(405, 460);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.richTextBox_0);
		base.Controls.Add(this.label_5);
		base.Controls.Add(this.dataGridView_0);
		base.Controls.Add(this.label_4);
		base.Controls.Add(this.tableLayoutPanel_0);
		base.Controls.Add(this.wLjmPevUwc4);
		base.Controls.Add(this.comboBox_0);
		base.Controls.Add(this.label_3);
		base.Controls.Add(this.textBox_1);
		base.Controls.Add(this.label_2);
		base.Controls.Add(this.label_1);
		base.Controls.Add(this.dateTimePicker_0);
		base.Controls.Add(this.textBox_0);
		base.Controls.Add(this.label_0);
		base.Name = "FormAddEditAirLineBalance";
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Принятие на баланс";
		base.FormClosing += this.Form14_FormClosing;
		base.Load += this.Form14_Load;
		((ISupportInitialize)this.class14_0).EndInit();
		this.tableLayoutPanel_0.ResumeLayout(false);
		((ISupportInitialize)this.numericUpDown_0).EndInit();
		((ISupportInitialize)this.dataGridView_0).EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	internal static void oj0nOe9LklXYkU91L2rd(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private int int_0;

	private int int_1;

	private decimal decimal_0;

	private DataTable dataTable_0;

	[CompilerGenerated]
	private StateFormCreate stateFormCreate_0;

	private IContainer icontainer_0;

	private Label label_0;

	private TextBox textBox_0;

	private DateTimePicker dateTimePicker_0;

	private Label label_1;

	private Label label_2;

	private TextBox textBox_1;

	private Label label_3;

	private ComboBox comboBox_0;

	private Label wLjmPevUwc4;

	private TableLayoutPanel tableLayoutPanel_0;

	private NumericUpDown numericUpDown_0;

	private ComboBox comboBox_1;

	private Label label_4;

	private DataGridView dataGridView_0;

	private Label label_5;

	private RichTextBox richTextBox_0;

	private Button button_0;

	private Button button_1;

	private BindingSource bindingSource_0;

	private Class14 class14_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

	private DataGridViewButtonColumn dataGridViewButtonColumn_0;

	private DataGridViewImageButtonColumn dataGridViewImageButtonColumn_0;

	private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private DataGridViewButtonColumn dataGridViewButtonColumn_1;

	private DataGridViewButtonColumn dataGridViewButtonColumn_2;

	private DataGridViewImageButtonColumn dataGridViewImageButtonColumn_1;

	private enum Enum5
	{

	}

	private enum Enum6
	{

	}
}
