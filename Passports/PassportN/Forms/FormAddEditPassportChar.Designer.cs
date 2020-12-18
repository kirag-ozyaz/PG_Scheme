using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Passport.Classes;
using Passport.Controls;
using Passport.Forms.PassportChars;
using Passport.Properties;

namespace Passport.Forms
{
	public class FormAddEditPassportChar : FormBase
	{
		public int Id { get; set; }

		public int IdParent { get; set; }

		public FormAddEditPassportChar(SQLSettings settings, StateFormCreate state, int id, int tabIndex)
		{
			Class330.Mus9JxKz1CNxy();
			this.int_3 = -1;
			this.string_0 = "";
			this.int_5 = -1;
			this.int_6 = -1;
			this.int_7 = -1;
			this.int_8 = -1;
			base..ctor();
			this.method_31();
			this.tableLayoutPanel_0.ColumnStyles[1].Width = 0f;
			base.Width = 307;
			this.SqlSettings = settings;
			this.Id = id;
			this.stateFormCreate_0 = state;
			this.int_2 = tabIndex;
			this.method_5();
			switch (state)
			{
			case 3:
				this.method_1(id);
				this.Text = "Добавление группы";
				return;
			case 4:
				this.method_3(id);
				this.Text = "Добавление параметра";
				return;
			case 5:
				this.method_2(id);
				this.Text = "Редактирование группы";
				return;
			case 6:
				this.method_4(id);
				this.Text = "Редактирование параметра";
				return;
			default:
				return;
			}
		}

		private bool method_0()
		{
			if (this.textBox_1.Text.Length == 1)
			{
				MessageBox.Show("Параметр \"Название\" отсутствует или введен неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.textBox_1.Focus();
				return false;
			}
			if ((this.stateFormCreate_0 == 4 || this.stateFormCreate_0 == 6) && (int)this.comboBox_1.SelectedValue == 734)
			{
				MessageBox.Show("Отсутствует тип параметра", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.comboBox_1.Focus();
				return false;
			}
			return true;
		}

		private void method_1(int int_9)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_CharList, true, "where id = " + int_9.ToString());
			this.textBox_2.Text = this.class107_0.tP_CharList.Rows[0]["Name"].ToString();
			this.comboBox_1.SelectedIndex = 0;
			this.comboBox_0.SelectedIndex = 0;
			this.comboBox_1.Enabled = false;
			this.string_0 = this.class107_0.tP_CharList.Rows[0]["ParentKey"].ToString();
		}

		private void method_2(int int_9)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.vP_ParameterEdit, true, "where id = " + int_9.ToString());
			this.textBox_2.Text = this.class107_0.vP_ParameterEdit.Rows[0]["ParentName"].ToString();
			this.textBox_1.Text = this.class107_0.vP_ParameterEdit.Rows[0]["Name"].ToString();
			this.textBox_0.Text = this.class107_0.vP_ParameterEdit.Rows[0]["ShortName"].ToString();
			this.comboBox_1.SelectedValue = (int)this.class107_0.vP_ParameterEdit.Rows[0]["Type"];
			this.comboBox_0.SelectedValue = (int)this.class107_0.vP_ParameterEdit.Rows[0]["Format"];
			this.comboBox_1.Enabled = false;
			this.string_0 = this.class107_0.vP_ParameterEdit.Rows[0]["ParentKey"].ToString();
			this.mmeybEsuSr.Text = this.class107_0.vP_ParameterEdit.Rows[0]["Comment"].ToString();
		}

		private void method_3(int int_9)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_CharList, true, "where id = " + int_9);
			this.textBox_2.Text = this.class107_0.tP_CharList.Rows[0]["Name"].ToString();
			this.comboBox_1.SelectedValue = (int)this.class107_0.tP_CharList.Rows[0]["Type"];
			this.comboBox_0.SelectedValue = (int)this.class107_0.tP_CharList.Rows[0]["Format"];
			this.comboBox_1.Enabled = true;
			this.string_0 = this.class107_0.tP_CharList.Rows[0]["ParentKey"].ToString();
		}

		private void method_4(int int_9)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.vP_ParameterEdit, true, "where id = " + int_9);
			this.textBox_2.Text = this.class107_0.vP_ParameterEdit.Rows[0]["ParentName"].ToString();
			this.textBox_1.Text = this.class107_0.vP_ParameterEdit.Rows[0]["Name"].ToString();
			this.textBox_0.Text = this.class107_0.vP_ParameterEdit.Rows[0]["ShortName"].ToString();
			this.comboBox_3.SelectedValue = ((this.class107_0.vP_ParameterEdit.Rows[0]["Dimention"] == DBNull.Value) ? -1 : ((int)this.class107_0.vP_ParameterEdit.Rows[0]["Dimention"]));
			this.checkBox_0.Checked = (bool)this.class107_0.vP_ParameterEdit.Rows[0]["UseDimention"];
			this.comboBox_1.SelectedValue = (int)this.class107_0.vP_ParameterEdit.Rows[0]["Type"];
			this.int_8 = (int)this.comboBox_1.SelectedValue;
			this.comboBox_0.SelectedValue = (int)this.class107_0.vP_ParameterEdit.Rows[0]["Format"];
			if (int.TryParse(this.class107_0.vP_ParameterEdit.Rows[0]["idValueList"].ToString(), out this.int_6))
			{
				this.comboBox_2.SelectedValue = this.int_6;
			}
			this.string_0 = this.class107_0.vP_ParameterEdit.Rows[0]["ParentKey"].ToString();
			this.comboBox_1.Enabled = true;
			this.mmeybEsuSr.Text = this.class107_0.vP_ParameterEdit.Rows[0]["Comment"].ToString();
		}

		private void method_5()
		{
			base.SelectSqlDataTableOther(this.class107_0, this.class107_0.tR_ParameterTypes, "tR_Classifier", true, "where ParentKey like ';Passport;DataType;' and deleted = 0 and isGroup = 0 order by Name");
			base.SelectSqlDataTableOther(this.class107_0, this.class107_0.tR_ParameterFormat, "tR_Classifier", true, "where (ParentKey like ';Passport;DateFormat;' or ParentKey like ';Passport;DigitFormat;')\r\nand deleted = 0 and isGroup = 0 order by Name");
			base.SelectSqlDataTableOther(this.class107_0, this.class107_0.vP_GetGroupList, "vP_GetValueList", true, "where isGroup = ((1)) and deleted = ((0)) order by Name");
			this.comboBox_1.DataSource = this.class107_0.tR_ParameterTypes;
			this.comboBox_1.DisplayMember = "Name";
			this.comboBox_1.ValueMember = "id";
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = this.class107_0.tR_ParameterFormat;
			this.comboBox_0.DataSource = bindingSource;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "id";
			this.comboBox_2.DataSource = this.class107_0.vP_GetGroupList;
			this.comboBox_2.DisplayMember = "Name";
			this.comboBox_2.ValueMember = "id";
			this.method_27();
		}

		private void method_6(int int_9)
		{
			base.SelectSqlDataTableOther(this.class107_0, this.class107_0.vP_GetGroupList, "vP_GetValueList", true, "where isGroup = 1 and deleted = 0 order by Name");
			this.comboBox_2.DataSource = this.class107_0.vP_GetGroupList;
			this.comboBox_2.DisplayMember = "Name";
			this.comboBox_2.ValueMember = "id";
			this.comboBox_2.SelectedValue = int_9;
		}

		private bool method_7(int int_9)
		{
			Class107.Class285 @class = this.class107_0.tP_CharList.method_5();
			@class.ParentId = int_9;
			@class.ParentKey = this.method_25(this.string_0, this.textBox_1.Text);
			@class.Name = this.textBox_1.Text;
			@class.ShortName = this.textBox_0.Text;
			@class.Type = (int)this.comboBox_1.SelectedValue;
			@class.Format = (int)this.comboBox_0.SelectedValue;
			@class.Dimention = -1;
			@class.idValueList = this.int_3;
			@class.TableName = this.GetValueListTableName(this.int_3).ToString();
			@class.TabIndex = this.int_2;
			@class.Comment = this.mmeybEsuSr.Text;
			@class.isGroup = true;
			@class.Panel = false;
			@class.Deleted = false;
			@class.ReadOnly = false;
			@class.UseDimention = false;
			this.class107_0.tP_CharList.method_0(@class);
			this.Id = base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_CharList);
			return this.Id != -1;
		}

		private bool method_8(int int_9)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_CharList, true, string.Format("where id = {0}", int_9.ToString()));
			foreach (object obj in this.class107_0.tP_CharList.Rows)
			{
				Class107.Class285 @class = (Class107.Class285)obj;
				@class.Name = this.textBox_1.Text;
				@class.ShortName = this.textBox_0.Text;
				@class.Comment = this.mmeybEsuSr.Text;
			}
			return base.UpdateSqlData(this.class107_0, this.class107_0.tP_CharList);
		}

		private bool method_9(int int_9)
		{
			int num = -1;
			base.CallSQLScalarFunction("dbo.fn_GetTabIndex", new string[]
			{
				int_9.ToString()
			});
			this.int_2 = (int)base.CallSQLScalarFunction("dbo.fn_GetTabIndex", new string[]
			{
				int_9.ToString()
			});
			if (this.int_3 == -1)
			{
				return false;
			}
			Class107.Class285 @class = this.class107_0.tP_CharList.method_5();
			@class.ParentId = int_9;
			@class.ParentKey = this.string_0;
			@class.Name = this.textBox_1.Text;
			@class.ShortName = this.textBox_0.Text;
			@class.Type = (int)this.comboBox_1.SelectedValue;
			@class.Format = (int)this.comboBox_0.SelectedValue;
			if (this.comboBox_3.SelectedValue != null && int.TryParse(this.comboBox_3.SelectedValue.ToString(), out num) && num != -1)
			{
				@class.Dimention = num;
			}
			@class.UseDimention = this.checkBox_0.Checked;
			@class.idValueList = this.int_3;
			@class.TableName = this.GetValueListTableName(this.int_3).ToString();
			@class.TabIndex = this.int_2;
			@class.Comment = this.mmeybEsuSr.Text;
			@class.ReadOnly = false;
			@class.isGroup = false;
			@class.Panel = false;
			@class.Deleted = false;
			this.class107_0.tP_CharList.method_0(@class);
			this.Id = base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_CharList);
			return this.Id != -1;
		}

		private bool method_10(int int_9)
		{
			int num = -1;
			if (this.int_3 == -1)
			{
				return false;
			}
			base.SelectSqlData(this.class107_0, this.class107_0.tP_CharList, true, "where id = " + int_9.ToString());
			this.class107_0.tP_CharList.Rows[0]["Name"] = this.textBox_1.Text;
			this.class107_0.tP_CharList.Rows[0]["ShortName"] = this.textBox_0.Text;
			this.class107_0.tP_CharList.Rows[0]["Type"] = this.comboBox_1.SelectedValue;
			this.class107_0.tP_CharList.Rows[0]["Format"] = this.comboBox_0.SelectedValue;
			if (this.comboBox_3.SelectedValue != null && int.TryParse(this.comboBox_3.SelectedValue.ToString(), out num) && num != -1)
			{
				this.class107_0.tP_CharList.Rows[0]["Dimention"] = num;
			}
			this.class107_0.tP_CharList.Rows[0]["UseDimention"] = this.checkBox_0.Checked;
			this.class107_0.tP_CharList.Rows[0]["idValueList"] = this.int_3;
			this.class107_0.tP_CharList.Rows[0]["TableName"] = this.GetValueListTableName(this.int_3);
			this.class107_0.tP_CharList.Rows[0]["Comment"] = this.mmeybEsuSr.Text;
			return base.UpdateSqlData(this.class107_0, this.class107_0.tP_CharList);
		}

		private void button_3_Click(object sender, EventArgs e)
		{
			bool flag = false;
			try
			{
				if (this.method_0())
				{
					switch (this.stateFormCreate_0)
					{
					case 3:
						flag = this.method_7(this.Id);
						break;
					case 4:
						flag = this.method_9(this.Id);
						break;
					case 5:
						flag = this.method_8(this.Id);
						break;
					case 6:
						flag = this.method_10(this.Id);
						if (this.bool_0)
						{
							this.method_17(this.Id);
						}
						if (this.bool_1)
						{
							this.method_15(this.Id, this.int_6);
						}
						break;
					}
					if (flag)
					{
						base.DialogResult = DialogResult.OK;
						base.Close();
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		public string TableName { get; set; }

		public bool IsListEdited
		{
			get
			{
				return this.method_11(2) == (int)this.comboBox_1.SelectedValue;
			}
		}

		public int ParentId
		{
			get
			{
				return this.int_3;
			}
		}

		private int method_11(int int_9)
		{
			DataTable dataTable = base.SelectSqlData("tR_Classifier", true, "WHERE Deleted = ((0)) AND ParentKey = ';Passport;DataType;' AND Value = " + int_9.ToString());
			if (dataTable.Rows.Count > 0)
			{
				return (int)dataTable.Rows[0]["id"];
			}
			return -1;
		}

		public TableNameEnum GetValueListTableName(int id)
		{
			EnumerableRowCollection<Class107.Class227> source = from names in this.class107_0.vP_GetGroupList
			where names.id == id
			select names;
			if (source.Count<Class107.Class227>() > 0)
			{
				this.TableName = source.First<Class107.Class227>().TableName;
				string tableName = source.First<Class107.Class227>().TableName;
				uint num = <PrivateImplementationDetails>.ComputeStringHash(tableName);
				if (num <= 2889017024u)
				{
					if (num != 2155469404u)
					{
						if (num != 2358446054u)
						{
							if (num == 2889017024u)
							{
								if (tableName == "tP_ValueLists")
								{
									return TableNameEnum.tP_ValueLists;
								}
							}
						}
						else if (tableName == "tAbn")
						{
							return TableNameEnum.tAbn;
						}
					}
					else if (tableName == "tSchm_ObjList")
					{
						return TableNameEnum.tSchm_ObjList;
					}
				}
				else if (num <= 2934327313u)
				{
					if (num != 2925914865u)
					{
						if (num == 2934327313u)
						{
							if (tableName == "tR_KladrObj")
							{
								return TableNameEnum.tR_KladrObj;
							}
						}
					}
					else if (tableName == "tR_Classifier")
					{
						return TableNameEnum.tR_Classifier;
					}
				}
				else if (num != 3228860235u)
				{
					if (num == 4143259250u)
					{
						if (tableName == "vP_Worker")
						{
							return TableNameEnum.vP_Worker;
						}
					}
				}
				else if (tableName == "tR_KladrStreet")
				{
					return TableNameEnum.tR_KladrStreet;
				}
				return TableNameEnum.None;
			}
			return TableNameEnum.None;
		}

		private void method_12(bool bool_2)
		{
			this.comboBox_2.Enabled = !bool_2;
		}

		private void method_13(bool bool_2)
		{
			this.button_1.Visible = bool_2;
			this.button_0.Visible = bool_2;
		}

		private void comboBox_1_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.comboBox_1.SelectedValue != null && this.comboBox_1.SelectedValue.GetType() != typeof(DataRowView))
			{
				int num = (int)this.comboBox_1.SelectedValue;
				int num2 = this.method_23("Дата");
				int num3 = this.method_23("Список");
				int num4 = this.method_23("Текст");
				int num5 = this.method_23("Числовой");
				if (num == num3)
				{
					this.tableLayoutPanel_0.ColumnStyles[1].Width = 50f;
					base.Width = 588;
					this.method_6(this.int_3);
					this.method_13(false);
					this.comboBox_0.Enabled = true;
				}
				else
				{
					if (this.tableLayoutPanel_0.ColumnStyles[1].Width != 0f)
					{
						this.tableLayoutPanel_0.ColumnStyles[1].Width = 0f;
						base.Width = 307;
						this.method_13(true);
					}
					this.comboBox_0.Enabled = false;
				}
				if ((int)this.comboBox_1.SelectedValue == num2)
				{
					if (this.comboBox_0.DataSource != null)
					{
						((BindingSource)this.comboBox_0.DataSource).Filter = "ParentKey = ';Passport;DateFormat;' and Value <> '0'";
						this.comboBox_0.SelectedIndex = 0;
					}
					this.comboBox_0.Enabled = true;
				}
				else if ((int)this.comboBox_1.SelectedValue == num5)
				{
					if (this.comboBox_0.DataSource != null)
					{
						((BindingSource)this.comboBox_0.DataSource).Filter = "ParentKey = ';Passport;DigitFormat;'";
						this.comboBox_0.SelectedIndex = 0;
					}
					this.comboBox_0.Enabled = true;
				}
				else
				{
					if (this.comboBox_0.DataSource != null)
					{
						((BindingSource)this.comboBox_0.DataSource).Filter = "ParentKey = ';Passport;DateFormat;' and Value = '0'";
						this.comboBox_0.SelectedIndex = 0;
					}
					this.comboBox_0.Enabled = false;
				}
				if ((this.int_5 != -1 || this.int_5 != 734) && this.int_6 != -1)
				{
					if (this.int_5 == num3 && num == num4)
					{
						this.method_14(ReplaceTypeChar.ListToText);
					}
					else if (this.int_5 == num4 && num == num3)
					{
						this.method_14(ReplaceTypeChar.TextToList);
					}
				}
				if (this.method_19(this.Id) && this.int_5 != num && num != 727)
				{
					MessageBox.Show("Невозможно изиенить тип характеристики.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					this.comboBox_1.SelectedValue = this.int_5;
					return;
				}
			}
		}

		private void method_14(ReplaceTypeChar replaceTypeChar_0)
		{
			if (replaceTypeChar_0 == ReplaceTypeChar.TextToList)
			{
				this.bool_0 = !this.bool_1;
				return;
			}
			if (replaceTypeChar_0 != ReplaceTypeChar.ListToText)
			{
				return;
			}
			this.bool_1 = !this.bool_0;
		}

		private int method_15(int int_9, int int_10)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			int result;
			try
			{
				sqlDataConnect.OpenConnection(this.SqlSettings);
				result = new SqlCommand(string.Format("UPDATE tP_ObjectChar SET Value = (SELECT distinct vl.Name\r\nFROM tP_ValueLists AS vl join\r\ntP_CharList AS cl on vl.ParentId = cl.idValueList and vl.isGroup = '0'\r\nWHERE cl.idValueList = '{1}' and tP_ObjectChar.idObjChar = '{0}'\r\nand cast(vl.id as varchar(max)) = tP_ObjectChar.Value)\r\nWHERE EXISTS(SELECT distinct vl.Name\r\nFROM tP_ValueLists AS vl join\r\ntP_CharList AS cl on vl.ParentId = cl.idValueList and vl.isGroup = '0'\r\nWHERE cl.idValueList = '{1}' and tP_ObjectChar.idObjChar = '{0}'\r\nand cast(vl.id as varchar(max)) = tP_ObjectChar.Value)", int_9, int_10), sqlDataConnect.Connection).ExecuteNonQuery();
			}
			catch (Exception)
			{
				result = -1;
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
			return result;
		}

		private int method_16(int int_9, int int_10)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			int result;
			try
			{
				sqlDataConnect.OpenConnection(this.SqlSettings);
				result = new SqlCommand(string.Format("UPDATE tP_ObjectChar SET Value = (SELECT distinct vl.id\r\nFROM tP_ValueLists AS vl join\r\ntP_CharList AS cl on vl.ParentId = cl.idValueList and vl.isGroup = '0'\r\nWHERE cl.idValueList = '{1}' and tP_ObjectChar.idObjChar = '{0}' and vl.Name = tP_ObjectChar.Value)\r\nWHERE EXISTS(SELECT distinct vl.id\r\nFROM tP_ValueLists AS vl join\r\ntP_CharList AS cl on vl.ParentId = cl.idValueList and vl.isGroup = '0'\r\nWHERE cl.idValueList = '{1}' and tP_ObjectChar.idObjChar = '{0}' and vl.Name = tP_ObjectChar.Value)", int_9, int_10), sqlDataConnect.Connection).ExecuteNonQuery();
			}
			catch (Exception)
			{
				result = -1;
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
			return result;
		}

		private int method_17(int int_9)
		{
			int result;
			try
			{
				if (int_9 == -1)
				{
					FormTypeCharTextToListReplace formTypeCharTextToListReplace = new FormTypeCharTextToListReplace(this.SqlSettings);
					if (formTypeCharTextToListReplace.ShowDialog() == DialogResult.Cancel)
					{
						this.comboBox_2.SelectedValue = -1;
						this.comboBox_1.SelectedValue = this.int_8;
						result = -1;
					}
					else
					{
						this.method_18(this.Id, formTypeCharTextToListReplace.IdGroupValueChar);
						result = this.method_16(this.Id, formTypeCharTextToListReplace.IdGroupValueChar);
					}
				}
				else if (MessageBox.Show("Использовать выбранный список значений?", "Изменение типа данных характеристики.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					this.method_18(this.Id, (int)this.comboBox_2.SelectedValue);
					this.toolStripMenuItem_0.Enabled = (this.toolStripButton_0.Enabled = (this.toolStripButton_1.Enabled = ((int)this.comboBox_2.SelectedValue != 107)));
					this.method_20((int)this.comboBox_2.SelectedValue);
					this.method_22((int)this.comboBox_2.SelectedValue);
					this.int_7 = (int)this.comboBox_2.SelectedValue;
					result = this.method_16(this.Id, this.int_7);
				}
				else
				{
					FormAddGroupElementList formAddGroupElementList = new FormAddGroupElementList();
					formAddGroupElementList.MdiParent = base.MdiParent;
					formAddGroupElementList.stateFormCreate = 3;
					formAddGroupElementList.TableName = TableNameEnum.tP_ValueLists;
					formAddGroupElementList.ShowDialog();
					this.method_18(this.Id, formAddGroupElementList.IdParent);
					this.int_7 = formAddGroupElementList.IdParent;
					result = this.method_16(this.Id, this.int_7);
				}
			}
			catch (Exception)
			{
				result = -1;
			}
			return result;
		}

		private int method_18(int int_9, int int_10)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			int result;
			try
			{
				sqlDataConnect.OpenConnection(this.SqlSettings);
				result = new SqlCommand(string.Format("INSERT INTO tP_ValueLists (ParentId, Name, isGroup, Deleted) (SELECT DISTINCT {1}, och.Value, ((0)), ((0)) FROM tP_ObjectChar AS och JOIN tP_CharList AS chl ON och.idObjChar = chl.id WHERE och.Value NOT IN (SELECT Name FROM tP_ValueLists WHERE ParentId = {1}) AND chl.id = {0} AND LEN(och.Value) > 0)", int_9, int_10), sqlDataConnect.Connection).ExecuteNonQuery();
			}
			catch (Exception)
			{
				result = -1;
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
			return result;
		}

		private bool method_19(int int_9)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			bool result;
			try
			{
				sqlDataConnect.OpenConnection(this.SqlSettings);
				result = (new SqlCommand(string.Format("SELECT COUNT(*) FROM tP_ObjectChar WHERE idObjChar = {0}", int_9), sqlDataConnect.Connection).ExecuteNonQuery() > 0);
			}
			catch (Exception)
			{
				result = true;
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
			return result;
		}

		private void comboBox_2_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.comboBox_2.SelectedValue != null && this.comboBox_2.SelectedValue.GetType() != typeof(DataRowView))
			{
				this.int_3 = (int)this.comboBox_2.SelectedValue;
				this.toolStripMenuItem_0.Enabled = (this.toolStripButton_0.Enabled = (this.toolStripButton_1.Enabled = (this.int_3 != 107)));
				this.method_20(this.int_3);
				this.method_22(this.int_3);
			}
		}

		private void method_20(int int_9)
		{
			TableNameEnum valueListTableName = this.GetValueListTableName(int_9);
			if (valueListTableName == TableNameEnum.tP_ValueLists)
			{
				this.toolStripSplitButton_0.Enabled = true;
				this.toolStripMenuItem_0.Enabled = true;
				this.toolStripMenuItem_1.Enabled = true;
				this.toolStripButton_0.Enabled = true;
				this.toolStripButton_1.Enabled = true;
				return;
			}
			if (valueListTableName != TableNameEnum.vP_Worker)
			{
				this.toolStripSplitButton_0.Enabled = true;
				this.toolStripMenuItem_0.Enabled = false;
				this.toolStripMenuItem_1.Enabled = true;
				this.toolStripButton_0.Enabled = false;
				this.toolStripButton_1.Enabled = false;
				return;
			}
			this.toolStripSplitButton_0.Enabled = false;
			this.toolStripMenuItem_0.Enabled = false;
			this.toolStripMenuItem_1.Enabled = false;
			this.toolStripButton_0.Enabled = false;
			this.toolStripButton_1.Enabled = false;
		}

		private void method_21(int int_9)
		{
			foreach (object obj in ((IEnumerable)this.dataGridView_0.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if ((int)dataGridViewRow.Cells["idValue"].Value == int_9)
				{
					this.dataGridView_0.FirstDisplayedScrollingRowIndex = dataGridViewRow.Index;
					dataGridViewRow.Selected = true;
				}
			}
		}

		private void method_22(int int_9)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.vP_GetValueList, true, "WHERE ParentId = " + int_9.ToString() + " AND Deleted = ((0)) ORDER BY Name");
			this.dataGridView_0.DataSource = this.class107_0.vP_GetValueList;
		}

		private int method_23(string string_2)
		{
			EnumerableRowCollection<int> source = from types in this.class107_0.tR_ParameterTypes
			where types.Name == string_2
			select types.Id;
			if (source.Count<int>() > 0)
			{
				return source.First<int>();
			}
			return -1;
		}

		private int method_24(int int_9)
		{
			if (base.Parent != null && base.Parent.Controls != null)
			{
				using (IEnumerator enumerator = base.Parent.Controls.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						Control control = (Control)obj;
						if (control.GetType() == typeof(DataGridViewPassport))
						{
							return ((DataGridViewPassport)control).RowCount + 1;
						}
					}
					return -1;
				}
				int result;
				return result;
			}
			return -1;
		}

		private string method_25(string string_2, string string_3)
		{
			string_3 = Regex.Replace(string_3, "[-.?!)(,:]", "");
			string_3 = Transliteration.Front(string_3);
			string[] array = string_3.Split(new char[]
			{
				' '
			}, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (!char.IsDigit(Convert.ToChar(text.Substring(0, 1))))
				{
					array[i] = text.Substring(0, 1).ToUpper() + text.Substring(1, text.Length - 1);
				}
			}
			return string_2 + string.Join("", (from s in array
			select s.ToString()).ToArray<string>()) + ";";
		}

		private int method_26(int int_9)
		{
			base.SelectSqlData(this.class107_0.tP_CharList, true, string.Format("where id = {0}", int_9), null, true, 0);
			if (this.class107_0.tP_CharList.Rows.Count > 0)
			{
				return (int)this.class107_0.tP_CharList.Rows[0]["ParentIdValue"];
			}
			return -1;
		}

		public static string FirstUpper(string cap)
		{
			return cap.Substring(0, 1).ToUpper() + ((cap.Length > 1) ? cap.Substring(1) : "");
		}

		private void method_27()
		{
			this.comboBox_3.DataSource = base.SelectSqlData("tR_Classifier", true, "WHERE ParentKey = ';Passport;CharDimention;' AND isGroup = ((0)) AND Deleted = ((0))");
			this.comboBox_3.DisplayMember = "SocrName";
			this.comboBox_3.ValueMember = "Id";
			this.comboBox_3.SelectedValue = -1;
		}

		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			if (this.int_3 > 0)
			{
				TableNameEnum valueListTableName = this.GetValueListTableName(this.int_3);
				if (valueListTableName == TableNameEnum.tAbn || valueListTableName == TableNameEnum.tP_ValueLists)
				{
					FormAddGroupElementList formAddGroupElementList = new FormAddGroupElementList();
					formAddGroupElementList.SqlSettings = this.SqlSettings;
					formAddGroupElementList.MdiParent = base.MdiParent;
					formAddGroupElementList.IdParent = this.int_3;
					formAddGroupElementList.stateFormCreate = 4;
					formAddGroupElementList.TableName = this.GetValueListTableName(this.int_3);
					formAddGroupElementList.ShowDialog();
					bool flag = this.int_4 != 0;
					this.method_22(this.int_3);
					if (flag)
					{
						this.method_21(formAddGroupElementList.Id);
					}
				}
			}
		}

		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			FormAddGroupElementList formAddGroupElementList = new FormAddGroupElementList();
			formAddGroupElementList.SqlSettings = this.SqlSettings;
			formAddGroupElementList.MdiParent = base.MdiParent;
			formAddGroupElementList.stateFormCreate = 3;
			formAddGroupElementList.TableName = TableNameEnum.tP_ValueLists;
			formAddGroupElementList.ShowDialog();
			this.IdParent = formAddGroupElementList.IdParent;
			this.method_6(this.IdParent);
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0 && this.method_28() == TableNameEnum.tP_ValueLists)
			{
				FormAddGroupElementList formAddGroupElementList = new FormAddGroupElementList();
				formAddGroupElementList.SqlSettings = this.SqlSettings;
				formAddGroupElementList.MdiParent = base.MdiParent;
				formAddGroupElementList.stateFormCreate = 6;
				formAddGroupElementList.Id = (int)this.dataGridView_0.SelectedRows[0].Cells["idValue"].Value;
				formAddGroupElementList.TableName = this.GetValueListTableName(this.int_3);
				formAddGroupElementList.ShowDialog();
				bool flag = this.int_4 != 0;
				this.method_22(this.int_3);
				if (flag)
				{
					this.method_21(formAddGroupElementList.Id);
					return;
				}
			}
			else
			{
				MessageBox.Show("Невозможно редактировать элемент в выбранной группе", "Редактирование.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private TableNameEnum method_28()
		{
			string a = (this.dataGridView_0.RowCount > 0) ? this.dataGridView_0.Rows[0].Cells["tableNameValue"].Value.ToString() : "tP_ValueLists";
			if (a == "tP_ValueLists")
			{
				return TableNameEnum.tP_ValueLists;
			}
			if (a == "tR_KladrObj")
			{
				return TableNameEnum.tR_KladrObj;
			}
			if (a == "tR_KladrStreet")
			{
				return TableNameEnum.tR_KladrStreet;
			}
			if (a == "tAbn")
			{
				return TableNameEnum.tAbn;
			}
			if (a == "tR_Classifier")
			{
				return TableNameEnum.tR_Classifier;
			}
			if (!(a == "vP_Worker"))
			{
				return TableNameEnum.None;
			}
			return TableNameEnum.vP_Worker;
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0 && this.method_28() == TableNameEnum.tP_ValueLists && MessageBox.Show("Вы действительно хотите удалить значение?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				if (this.GetValueListTableName(this.int_3) == TableNameEnum.tAbn)
				{
					this.method_29((int)this.dataGridView_0.SelectedRows[0].Cells["idValue"].Value);
				}
				if (this.GetValueListTableName(this.int_3) == TableNameEnum.tP_ValueLists)
				{
					this.method_30((int)this.dataGridView_0.SelectedRows[0].Cells["idValue"].Value);
				}
				this.method_22(this.int_3);
				return;
			}
			MessageBox.Show("Удалить выбранное значение невозможно", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
		}

		private bool method_29(int int_9)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tAbn, true, "WHERE Id = " + this.dataGridView_0.SelectedRows[0].Cells["idValue"].Value.ToString());
			if (this.class107_0.tAbn.Rows.Count <= 0)
			{
				return false;
			}
			((Class107.Class211)this.class107_0.tAbn.Rows[0]).Deleted = true;
			return base.UpdateSqlData(this.class107_0, this.class107_0.tAbn);
		}

		private bool method_30(int int_9)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_ValueLists, true, "WHERE Id = " + this.dataGridView_0.SelectedRows[0].Cells["idValue"].Value.ToString());
			if (this.class107_0.tP_ValueLists.Rows.Count <= 0)
			{
				return false;
			}
			((Class107.Class272)this.class107_0.tP_ValueLists.Rows[0]).Deleted = true;
			return base.UpdateSqlData(this.class107_0, this.class107_0.tP_ValueLists);
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			int int_ = (int)this.comboBox_2.SelectedValue;
			if (this.dataGridView_0.SelectedRows != null)
			{
				int num = (int)this.dataGridView_0.SelectedRows[0].Cells["idValue"].Value;
			}
			this.method_6(int_);
			this.method_22(int_);
		}

		private void comboBox_3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '.')
			{
				this.comboBox_3.SelectedValue = -1;
			}
		}

		private void atByKeasFF(object sender, EventArgs e)
		{
			int num = -1;
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0 && int.TryParse(this.dataGridView_0.SelectedRows[0].Cells["ParentIdAddl"].Value.ToString(), out num) && num == 683 && this.TableName == TableNameEnum.tAbn.ToString())
			{
				this.toolStripSplitButton_0.Enabled = true;
				this.toolStripMenuItem_0.Enabled = true;
				this.toolStripMenuItem_1.Enabled = true;
				this.toolStripButton_0.Enabled = true;
				this.toolStripButton_1.Enabled = true;
				return;
			}
			this.toolStripSplitButton_0.Enabled = true;
			this.toolStripMenuItem_0.Enabled = true;
			this.toolStripMenuItem_1.Enabled = true;
			this.toolStripButton_0.Enabled = false;
			this.toolStripButton_1.Enabled = false;
		}

		private void FormAddEditPassportChar_Load(object sender, EventArgs e)
		{
			this.int_5 = (int)this.comboBox_1.SelectedValue;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_31()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.panel_0 = new Panel();
			this.comboBox_0 = new ComboBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.groupBox_0 = new GroupBox();
			this.checkBox_0 = new CheckBox();
			this.label_6 = new Label();
			this.comboBox_3 = new ComboBox();
			this.label_0 = new Label();
			this.comboBox_1 = new ComboBox();
			this.label_1 = new Label();
			this.qosyRpErMl = new Label();
			this.textBox_0 = new TextBox();
			this.mmeybEsuSr = new RichTextBox();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.textBox_1 = new TextBox();
			this.label_4 = new Label();
			this.textBox_2 = new TextBox();
			this.panel_1 = new Panel();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripSplitButton_0 = new ToolStripSplitButton();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripButton_2 = new ToolStripButton();
			this.label_5 = new Label();
			this.comboBox_2 = new ComboBox();
			this.button_2 = new Button();
			this.button_3 = new Button();
			this.class107_0 = new Class107();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel_0.SuspendLayout();
			this.panel_0.SuspendLayout();
			this.groupBox_0.SuspendLayout();
			this.panel_1.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			this.toolStrip_0.SuspendLayout();
			((ISupportInitialize)this.class107_0).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.Controls.Add(this.panel_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.panel_1, 1, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tlpGeneral";
			this.tableLayoutPanel_0.RowCount = 1;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Size = new Size(563, 366);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.panel_0.Controls.Add(this.comboBox_0);
			this.panel_0.Controls.Add(this.button_0);
			this.panel_0.Controls.Add(this.button_1);
			this.panel_0.Controls.Add(this.groupBox_0);
			this.panel_0.Controls.Add(this.label_4);
			this.panel_0.Controls.Add(this.textBox_2);
			this.panel_0.Dock = DockStyle.Fill;
			this.panel_0.Location = new Point(3, 3);
			this.panel_0.Name = "pnlGeneral";
			this.panel_0.Size = new Size(275, 360);
			this.panel_0.TabIndex = 0;
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.Enabled = false;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Items.AddRange(new object[]
			{
				"DD/MM/YYYY",
				"YYYY"
			});
			this.comboBox_0.Location = new Point(177, 147);
			this.comboBox_0.Name = "cbTypeParameterFormat";
			this.comboBox_0.Size = new Size(83, 21);
			this.comboBox_0.TabIndex = 22;
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(191, 328);
			this.button_0.Name = "btnCancel";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 19;
			this.button_0.Text = "Отмена";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_2_Click;
			this.button_1.Location = new Point(18, 328);
			this.button_1.Name = "btnOK";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 18;
			this.button_1.Text = "ОК";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_3_Click;
			this.groupBox_0.Controls.Add(this.checkBox_0);
			this.groupBox_0.Controls.Add(this.label_6);
			this.groupBox_0.Controls.Add(this.comboBox_3);
			this.groupBox_0.Controls.Add(this.label_0);
			this.groupBox_0.Controls.Add(this.comboBox_1);
			this.groupBox_0.Controls.Add(this.label_1);
			this.groupBox_0.Controls.Add(this.qosyRpErMl);
			this.groupBox_0.Controls.Add(this.textBox_0);
			this.groupBox_0.Controls.Add(this.mmeybEsuSr);
			this.groupBox_0.Controls.Add(this.label_2);
			this.groupBox_0.Controls.Add(this.label_3);
			this.groupBox_0.Controls.Add(this.textBox_1);
			this.groupBox_0.Location = new Point(18, 37);
			this.groupBox_0.Name = "groupBox";
			this.groupBox_0.Size = new Size(248, 268);
			this.groupBox_0.TabIndex = 17;
			this.groupBox_0.TabStop = false;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Location = new Point(14, 153);
			this.checkBox_0.Name = "chbDimention";
			this.checkBox_0.Size = new Size(15, 14);
			this.checkBox_0.TabIndex = 18;
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(6, 134);
			this.label_6.Name = "lbDimention";
			this.label_6.Size = new Size(75, 13);
			this.label_6.TabIndex = 17;
			this.label_6.Text = "Размерность";
			this.comboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_3.FormattingEnabled = true;
			this.comboBox_3.Location = new Point(37, 150);
			this.comboBox_3.Name = "cbDimention";
			this.comboBox_3.Size = new Size(205, 21);
			this.comboBox_3.TabIndex = 16;
			this.comboBox_3.KeyPress += this.comboBox_3_KeyPress;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(159, 94);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(49, 13);
			this.label_0.TabIndex = 15;
			this.label_0.Text = "Формат";
			this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Items.AddRange(new object[]
			{
				"Дата",
				"Список",
				"Текст"
			});
			this.comboBox_1.Location = new Point(9, 110);
			this.comboBox_1.Name = "cbTypeParameter";
			this.comboBox_1.Size = new Size(144, 21);
			this.comboBox_1.TabIndex = 14;
			this.comboBox_1.SelectedValueChanged += this.comboBox_1_SelectedValueChanged;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(6, 94);
			this.label_1.Name = "lbTypeParameter";
			this.label_1.Size = new Size(26, 13);
			this.label_1.TabIndex = 10;
			this.label_1.Text = "Тип";
			this.qosyRpErMl.AutoSize = true;
			this.qosyRpErMl.Location = new Point(6, 55);
			this.qosyRpErMl.Name = "lbSocrName";
			this.qosyRpErMl.Size = new Size(109, 13);
			this.qosyRpErMl.TabIndex = 2;
			this.qosyRpErMl.Text = "Сокр наименование";
			this.textBox_0.Location = new Point(9, 71);
			this.textBox_0.Name = "tbShortName";
			this.textBox_0.Size = new Size(233, 20);
			this.textBox_0.TabIndex = 3;
			this.mmeybEsuSr.Location = new Point(9, 190);
			this.mmeybEsuSr.Name = "rtbComment";
			this.mmeybEsuSr.Size = new Size(233, 71);
			this.mmeybEsuSr.TabIndex = 9;
			this.mmeybEsuSr.Text = "";
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(6, 174);
			this.label_2.Name = "lbComment";
			this.label_2.Size = new Size(77, 13);
			this.label_2.TabIndex = 8;
			this.label_2.Text = "Комментарий";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(6, 16);
			this.label_3.Name = "lbName";
			this.label_3.Size = new Size(83, 13);
			this.label_3.TabIndex = 0;
			this.label_3.Text = "Наименование";
			this.textBox_1.Location = new Point(9, 32);
			this.textBox_1.Name = "tbName";
			this.textBox_1.Size = new Size(233, 20);
			this.textBox_1.TabIndex = 1;
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(15, 14);
			this.label_4.Name = "lbParent";
			this.label_4.Size = new Size(42, 13);
			this.label_4.TabIndex = 20;
			this.label_4.Text = "Группа";
			this.textBox_2.BackColor = Color.White;
			this.textBox_2.Location = new Point(76, 11);
			this.textBox_2.Name = "tbParent";
			this.textBox_2.Size = new Size(190, 20);
			this.textBox_2.TabIndex = 21;
			this.panel_1.Controls.Add(this.dataGridView_0);
			this.panel_1.Controls.Add(this.toolStrip_0);
			this.panel_1.Controls.Add(this.label_5);
			this.panel_1.Controls.Add(this.comboBox_2);
			this.panel_1.Controls.Add(this.button_2);
			this.panel_1.Controls.Add(this.button_3);
			this.panel_1.Dock = DockStyle.Fill;
			this.panel_1.Location = new Point(284, 3);
			this.panel_1.Name = "panel1";
			this.panel_1.Size = new Size(276, 360);
			this.panel_1.TabIndex = 1;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToResizeRows = false;
			this.dataGridView_0.BackgroundColor = Color.White;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_12
			});
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.White;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = Color.White;
			dataGridViewCellStyle.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.Location = new Point(15, 92);
			this.dataGridView_0.MultiSelect = false;
			this.dataGridView_0.Name = "dgvValueList";
			this.dataGridView_0.ReadOnly = true;
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(248, 229);
			this.dataGridView_0.TabIndex = 27;
			this.dataGridView_0.SelectionChanged += this.atByKeasFF;
			this.dataGridViewTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_6.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_6.Name = "NameValue";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_7.HeaderText = "idValue";
			this.dataGridViewTextBoxColumn_7.Name = "idValue";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_8.HeaderText = "parentIdValue";
			this.dataGridViewTextBoxColumn_8.Name = "parenrIdValue";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "ParentIdAddl";
			this.dataGridViewTextBoxColumn_9.HeaderText = "ParentIdAddl";
			this.dataGridViewTextBoxColumn_9.Name = "ParentIdAddl";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "TableName";
			this.dataGridViewTextBoxColumn_10.HeaderText = "TableNameValue";
			this.dataGridViewTextBoxColumn_10.Name = "TableNameValue";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "isGroup";
			this.dataGridViewTextBoxColumn_11.HeaderText = "isGroupValue";
			this.dataGridViewTextBoxColumn_11.Name = "isGroupValue";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_12.HeaderText = "DeletedValue";
			this.dataGridViewTextBoxColumn_12.Name = "DeletedValue";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripSplitButton_0,
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripSeparator_0,
				this.toolStripButton_2
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "tsValueLists";
			this.toolStrip_0.Size = new Size(276, 25);
			this.toolStrip_0.TabIndex = 26;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_1
			});
			this.toolStripSplitButton_0.Image = Resources.smethod_24();
			this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButton_0.Name = "tssbtnAddElement";
			this.toolStripSplitButton_0.Size = new Size(32, 22);
			this.toolStripSplitButton_0.Text = "Добавить";
			this.toolStripSplitButton_0.ButtonClick += this.toolStripMenuItem_0_Click;
			this.toolStripMenuItem_0.Image = Resources.smethod_24();
			this.toolStripMenuItem_0.Name = "tsmiAddElement";
			this.toolStripMenuItem_0.Size = new Size(175, 22);
			this.toolStripMenuItem_0.Text = "Добавить элемент";
			this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
			this.toolStripMenuItem_1.Image = Resources.smethod_32();
			this.toolStripMenuItem_1.Name = "tsmiAddGroup";
			this.toolStripMenuItem_1.Size = new Size(175, 22);
			this.toolStripMenuItem_1.Text = "Добавить группу";
			this.toolStripMenuItem_1.ToolTipText = "Добавить группу";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.smethod_26();
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "tsbEdit";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Изменить";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.smethod_25();
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "tsbDelete";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Удалить";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripSeparator_0.Name = "toolStripSeparator1";
			this.toolStripSeparator_0.Size = new Size(6, 25);
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.smethod_45();
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "tsbRefresh";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "toolStripButton4";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(20, 37);
			this.label_5.Name = "label2";
			this.label_5.Size = new Size(94, 13);
			this.label_5.TabIndex = 25;
			this.label_5.Text = "Список значений";
			this.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(23, 56);
			this.comboBox_2.Name = "cbTypeList";
			this.comboBox_2.Size = new Size(240, 21);
			this.comboBox_2.TabIndex = 24;
			this.comboBox_2.SelectedValueChanged += this.comboBox_2_SelectedValueChanged;
			this.button_2.DialogResult = DialogResult.Cancel;
			this.button_2.Location = new Point(188, 328);
			this.button_2.Name = "btnCancel_List";
			this.button_2.Size = new Size(75, 23);
			this.button_2.TabIndex = 21;
			this.button_2.Text = "Отмена";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.button_3.Location = new Point(94, 328);
			this.button_3.Name = "btnOk_List";
			this.button_3.Size = new Size(75, 23);
			this.button_3.TabIndex = 20;
			this.button_3.Text = "ОК";
			this.button_3.UseVisualStyleBackColor = true;
			this.button_3.Click += this.button_3_Click;
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_0.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_1.HeaderText = "idValue";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_1.Width = 5;
			this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_2.HeaderText = "ParentIdValue";
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "TableName";
			this.dataGridViewTextBoxColumn_3.HeaderText = "TableNameValue";
			this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Visible = false;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "isGroup";
			this.dataGridViewTextBoxColumn_4.HeaderText = "isGroupValue";
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_5.HeaderText = "DeletedValue";
			this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			base.AcceptButton = this.button_1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(563, 366);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormAddEditPassportChar";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "FormAddEditParameterList";
			base.Load += this.FormAddEditPassportChar_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.panel_1.ResumeLayout(false);
			this.panel_1.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			((ISupportInitialize)this.class107_0).EndInit();
			base.ResumeLayout(false);
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		private int int_2;

		private StateFormCreate stateFormCreate_0;

		private int int_3;

		private int int_4;

		private string string_0;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private bool bool_0;

		private bool bool_1;

		[CompilerGenerated]
		private string string_1;

		private IContainer icontainer_0;

		private Class107 class107_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private Panel panel_0;

		private ComboBox comboBox_0;

		private Button button_0;

		private Button button_1;

		private GroupBox groupBox_0;

		private Label label_0;

		private ComboBox comboBox_1;

		private Label label_1;

		private Label qosyRpErMl;

		private TextBox textBox_0;

		private RichTextBox mmeybEsuSr;

		private Label label_2;

		private Label label_3;

		private TextBox textBox_1;

		private Label label_4;

		private TextBox textBox_2;

		private Panel panel_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripButton toolStripButton_2;

		private Label label_5;

		private ComboBox comboBox_2;

		private Button button_2;

		private Button button_3;

		private DataGridView dataGridView_0;

		private ToolStripSplitButton toolStripSplitButton_0;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripMenuItem toolStripMenuItem_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private Label label_6;

		private ComboBox comboBox_3;

		private CheckBox checkBox_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
	}
}
