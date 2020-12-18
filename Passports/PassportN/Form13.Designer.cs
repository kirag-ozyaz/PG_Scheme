using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using FormLbr;
using Passport.Classes;
using Passport.Controls;
using Passport.Properties;

internal class Form13 : FormBase
{
	internal int method_0()
	{
		return this.int_2;
	}

	internal void method_1(int int_4)
	{
		this.int_2 = int_4;
	}

	internal int method_2()
	{
		return this.int_1;
	}

	internal void method_3(int int_4)
	{
		this.int_1 = int_4;
	}

	internal int method_4()
	{
		return this.int_0;
	}

	internal void method_5(int int_4)
	{
		this.int_0 = int_4;
	}

	[CompilerGenerated]
	internal StateFormCreate method_6()
	{
		return this.stateFormCreate_0;
	}

	[CompilerGenerated]
	internal void method_7(StateFormCreate stateFormCreate_1)
	{
		this.stateFormCreate_0 = stateFormCreate_1;
	}

	[CompilerGenerated]
	internal Enum4 method_8()
	{
		return this.enum4_0;
	}

	[CompilerGenerated]
	internal void method_9(Enum4 enum4_1)
	{
		this.enum4_0 = enum4_1;
	}

	internal Form13()
	{
		Class330.Mus9JxKz1CNxy();
		this.int_0 = -1;
		this.int_1 = -1;
		this.int_2 = -1;
		this.string_0 = string.Empty;
		base..ctor();
		this.method_29();
		this.method_10();
		this.WlYmhhmeTud.DataError += this.WlYmhhmeTud_DataError;
	}

	internal Form13(int int_4, int int_5)
	{
		Class330.Mus9JxKz1CNxy();
		this.int_0 = -1;
		this.int_1 = -1;
		this.int_2 = -1;
		this.string_0 = string.Empty;
		base..ctor();
		this.method_29();
		this.method_10();
		this.int_2 = int_4;
		this.int_1 = int_5;
		this.WlYmhhmeTud.DataError += this.WlYmhhmeTud_DataError;
	}

	private void method_10()
	{
		this.textBox_0.DataBindings[0].DataSourceNullValue = string.Empty;
		this.textBox_0.DataBindings[0].NullValue = 0;
	}

	private void WlYmhhmeTud_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
	}

	private void Form13_Load(object sender, EventArgs e)
	{
		this.method_11();
		StateFormCreate stateFormCreate = this.method_6();
		if (stateFormCreate == null)
		{
			this.Text = "Добавление опоры";
			Class107.Class244 @class = this.class107_0.tSchm_ObjList.method_5();
			@class.IdParent = this.method_2();
			@class.idParentAddl = this.method_2();
			@class.Deleted = false;
			if (this.method_4() != -1)
			{
				this.Text = "Добавление опоры в пролет № " + this.method_12(this.method_4());
				int num = this.method_28(";SCM;Pole;", 2m);
				if (num != -1)
				{
					@class.TypeCodeId = num;
				}
			}
			this.class107_0.tSchm_ObjList.method_0(@class);
			Class107.Class257 class2 = this.class107_0.tP_Passport.method_5();
			class2.idObjList = this.method_0();
			class2.Date = DateTime.Now;
			class2.DateIn = DateTime.Now;
			class2.Deleted = false;
			class2.isActive = true;
			this.class107_0.tP_Passport.method_0(class2);
			this.WlYmhhmeTud.AddRowAddingParemeter(ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;Pole;", 1m), this.SqlSettings);
			return;
		}
		if (stateFormCreate != 1)
		{
			if (stateFormCreate != 11)
			{
				return;
			}
			base.SelectSqlData(this.class107_0, this.class107_0.tSchm_ObjList, true, string.Format("WHERE id = {0}", this.method_0()));
			this.Text = "Копирование опоры № " + this.class107_0.tSchm_ObjList[0].Name;
			this.bindingSource_2.ResetBindings(false);
			int activePassport = PassportData.GetActivePassport(this.SqlSettings, this.method_0());
			base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where id = '{0}'", activePassport), null, false, 0);
			this.WlYmhhmeTud.AddRowEditingParameter(this.SqlSettings, activePassport, DataGridViewPassport.CreateState.Copy);
			return;
		}
		else
		{
			if (this.method_4() == -1)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tSchm_ObjList, true, string.Format("WHERE id = {0}", this.method_0()));
				this.Text = "Редактирование опоры № " + this.class107_0.tSchm_ObjList[0].Name;
				this.bindingSource_2.ResetBindings(false);
				int activePassport = PassportData.GetActivePassport(this.SqlSettings, this.method_0());
				base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where id = '{0}'", activePassport), null, false, 0);
				this.WlYmhhmeTud.AddRowEditingParameter(this.SqlSettings, activePassport, DataGridViewPassport.CreateState.EditValue);
				this.method_18();
				return;
			}
			this.Text = "Вставка опоры в пролет № " + this.method_12(this.method_4());
			return;
		}
	}

	private void method_11()
	{
		base.SelectSqlData(this.class107_0, this.class107_0.tR_Classifier, true, "WHERE ParentKey = ';SCM;Pole;' AND isGroup = ((0)) AND Deleted = ((0))");
		this.bindingSource_1.ResetBindings(false);
		if (this.method_6() == 1 && this.method_4() != -1)
		{
			DataTable dataTable = new DataTable("tSchm_ObjList");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			dataTable.Columns.Add("typeCodeId", typeof(int));
			string text = string.Format("where idParent = '{0}' and deleted = '0'\r\n and typeCodeId in (select id from tR_Classifier where deleted = '0'\r\n and isGroup = '0' and ParentKey = ';SCM;Pole;')\r\nand id not in (select idClutchFirst from tP_CabSection where idObjList = '{0}' and Deleted = '0')\r\nand id not in (select idClutchSecond from tP_CabSection where idObjList = '{0}' and Deleted = '0')", this.method_2());
			base.SelectSqlData(dataTable, true, text, null, false, 0);
			Control control = this.comboBox_1;
			this.comboBox_1.Enabled = true;
			control.Visible = true;
			Control control2 = this.arhmhfXsamx;
			this.arhmhfXsamx.Enabled = false;
			control2.Visible = false;
			this.comboBox_1.DisplayMember = "Name";
			this.comboBox_1.ValueMember = "id";
			this.comboBox_1.DataSource = dataTable;
		}
	}

	private string method_12(int int_4)
	{
		DataTable dataTable = new DataTable("tP_CabSection");
		base.SelectSqlData(dataTable, true, string.Format("where id = '{0}'", int_4), null, false, 0);
		if (dataTable.Rows.Count > 0)
		{
			return Convert.ToString(dataTable.Rows[0]["Number"]);
		}
		return string.Empty;
	}

	private bool method_13()
	{
		DateTime datePassport = DateTime.TryParse(this.nullableDateTimePicker_0.Value.ToString(), out datePassport) ? ((DateTime)this.nullableDateTimePicker_0.Value) : DateTime.Now;
		this.bindingSource_2.EndEdit();
		StateFormCreate stateFormCreate = this.method_6();
		if (stateFormCreate != null)
		{
			if (stateFormCreate == 1)
			{
				base.UpdateSqlData(this.class107_0, this.class107_0.tSchm_ObjList);
				this.WlYmhhmeTud.SaveUpdatedData(datePassport, Convert.ToInt32(this.class107_0.tP_Passport[0]["Number"]));
				this.method_19();
				this.method_14();
				return true;
			}
			if (stateFormCreate != 11)
			{
				return false;
			}
			this.method_1(base.InsertSqlDataOneRow(this.class107_0.tSchm_ObjList[0]));
			if (this.method_0() == -1)
			{
				return false;
			}
			this.WlYmhhmeTud.SaveInsertedData(this.method_0(), datePassport, Convert.ToInt32(this.class107_0.tP_Passport[0]["Number"]));
			this.method_19();
			return true;
		}
		else
		{
			this.method_1(base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tSchm_ObjList));
			if (this.method_0() == -1)
			{
				return false;
			}
			this.WlYmhhmeTud.SaveInsertedData(this.method_0(), datePassport, Convert.ToInt32(this.class107_0.tP_Passport[0]["Number"]));
			this.method_19();
			this.method_14();
			return true;
		}
	}

	private void method_14()
	{
		if (this.method_4() == -1)
		{
			return;
		}
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
		{
			sqlConnection.Open();
			SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
			string commandText = string.Empty;
			try
			{
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = sqlConnection;
				sqlCommand.Transaction = sqlTransaction;
				sqlCommand.CommandType = CommandType.Text;
				string text = this.method_15();
				if (string.IsNullOrEmpty(text))
				{
					sqlTransaction.Rollback();
					sqlConnection.Close();
				}
				commandText = string.Format(string.Concat(new string[]
				{
					"INSERT INTO tp_CabSection(",
					text,
					", idClutchFirst, Number, [Length])\r\nselect ",
					text,
					", '{0}', '{1}', [Length] / 2  from tP_CabSection where id = '{2}'"
				}), this.method_0(), this.method_16(), this.method_4());
				sqlCommand.CommandText = commandText;
				sqlCommand.ExecuteNonQuery();
				commandText = string.Format("UPDATE tP_CabSection SET idClutchSecond = '{0}', [Length] = [Length] / 2\r\nwhere id = '{1}'", this.method_0(), this.method_4());
				sqlCommand.CommandText = commandText;
				sqlCommand.ExecuteNonQuery();
				sqlTransaction.Commit();
			}
			catch
			{
				sqlTransaction.Rollback();
				sqlConnection.Close();
			}
		}
	}

	private string method_15()
	{
		string text = "select stuff((select ',' + name\r\nfrom sys.columns\r\nwhere [object_id] = object_id(N'tP_CabSection', N'U') \r\nand name not in (select COLUMN_NAME \r\n                from INFORMATION_SCHEMA.KEY_COLUMN_USAGE\r\n                where TABLE_NAME = 'tP_CabSection')\r\nand name not in ('idClutchFirst', 'Number', 'Length')\r\nfor xml path('')),1,1,'') as ColsStr";
		DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
		if (dataTable.Rows.Count > 0)
		{
			return Convert.ToString(dataTable.Rows[0]["ColsStr"]);
		}
		return string.Empty;
	}

	private int method_16()
	{
		string text = string.Format("select ISNULL(max(Number) + 1, 1) as Number from tP_CabSection\r\nwhere idObjList = '{0}' and deleted = '0'", this.method_2());
		DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
		if (dataTable.Rows.Count > 0)
		{
			return Convert.ToInt32(dataTable.Rows[0]["Number"]);
		}
		return 1;
	}

	protected override void OnClosing(CancelEventArgs cancelEventArgs_0)
	{
		if (base.DialogResult == DialogResult.OK && (!this.method_17() || (!this.method_13() && this.method_6() == 1)))
		{
			cancelEventArgs_0.Cancel = true;
			if (this.string_0 != string.Empty)
			{
				MessageBox.Show(this.string_0);
			}
		}
		base.OnClosing(cancelEventArgs_0);
		if (this.form7_0 != null)
		{
			this.form7_0.DialogResult = DialogResult.Cancel;
			this.form7_0.Close();
		}
	}

	private bool method_17()
	{
		bool result = true;
		if (this.comboBox_0.SelectedIndex < 0)
		{
			new ToolTip().Show("!", this.comboBox_0, 10, 5, 3000);
			result = false;
		}
		string text = this.class107_0.tSchm_ObjList.Rows[0]["Name"].ToString();
		if (text.Trim() == string.Empty)
		{
			new ToolTip().Show("!", this.arhmhfXsamx, 10, 5, 3000);
			result = false;
		}
		string text2 = string.Format("WHERE name = '{0}' AND IdParent = {1} AND idParentAddl = {2} and deleted = 0 ", text, this.method_2(), this.method_2());
		if (this.method_6() == 1)
		{
			text2 += string.Format(" AND id <> {0}", this.method_0());
		}
		if (base.SelectSqlData("tSchm_ObjList", true, text2).Rows.Count > 0)
		{
			new ToolTip().Show("!", this.arhmhfXsamx, 10, 5, 3000);
			this.string_0 = "Наименование опоры не является уникальным";
			result = false;
		}
		return result;
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		this.form7_0 = new Form7(this.method_2(), this.method_0(), -1, -1);
		this.form7_0.SqlSettings = this.SqlSettings;
		this.form7_0.MdiParent = base.MdiParent;
		this.form7_0.method_1(0);
		this.form7_0.method_3(this.class107_0.tP_CabBranches.method_5());
		this.form7_0.hUtmjzkxkdC(this.class107_0.tP_BranchObjRelation.method_5());
		this.form7_0.Show();
		this.form7_0.FormClosed -= this.form7_0_FormClosed;
		this.form7_0.FormClosed += this.form7_0_FormClosed;
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		if (this.dataGridView_0.RowCount == 0)
		{
			return;
		}
		int num = (int)this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_92.Name].Value;
		int num2;
		if (!int.TryParse(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_95.Name].Value.ToString(), out num2))
		{
			num2 = -1;
		}
		this.int_3 = this.dataGridView_0.CurrentRow.Index;
		this.form7_0 = new Form7(this.method_2(), this.method_0(), num, num2);
		this.form7_0.SqlSettings = this.SqlSettings;
		this.form7_0.MdiParent = base.MdiParent;
		this.form7_0.method_1(1);
		DataRow[] array = this.class107_0.tP_CabBranches.Select("id = " + num.ToString());
		this.form7_0.method_3((Class107.Class288)array[0]);
		DataRow[] array2 = this.class107_0.tP_BranchObjRelation.Select(string.Format("idCabBranch = {0} and idObj = {1}", num, num2));
		this.form7_0.hUtmjzkxkdC((Class107.Class289)array2[0]);
		this.form7_0.Show();
		this.form7_0.FormClosed -= this.form7_0_FormClosed;
		this.form7_0.FormClosed += this.form7_0_FormClosed;
	}

	private void toolStripButton_2_Click(object sender, EventArgs e)
	{
		if (this.dataGridView_0.RowCount == 0)
		{
			return;
		}
		int num = (int)this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_92.Name].Value;
		for (int i = 0; i < this.class107_0.vP_CabBranches.Rows.Count; i++)
		{
			if (this.class107_0.vP_CabBranches[i].RowState != DataRowState.Deleted && this.class107_0.vP_CabBranches[i].id == num)
			{
				this.class107_0.vP_CabBranches[i].Delete();
			}
		}
		for (int j = 0; j < this.class107_0.tP_CabBranches.Rows.Count; j++)
		{
			if (this.class107_0.tP_CabBranches[j].RowState != DataRowState.Deleted && this.class107_0.tP_CabBranches[j].id == num)
			{
				this.class107_0.tP_CabBranches[j].Delete();
				IL_10D:
				for (int k = 0; k < this.class107_0.tP_BranchObjRelation.Rows.Count; k++)
				{
					if (this.class107_0.tP_BranchObjRelation[k].RowState != DataRowState.Deleted && this.class107_0.tP_BranchObjRelation[k].idCabBranch == num)
					{
						this.class107_0.tP_BranchObjRelation[k].Delete();
					}
				}
				return;
			}
		}
		goto IL_10D;
	}

	private void toolStripButton_3_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("При обновлении все несохраненные данные в таблице ответвлений будут утеряны.\r\nПродолжить?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
		{
			this.method_18();
			return;
		}
	}

	private void toolStripButton_4_Click(object sender, EventArgs e)
	{
		if (this.dataGridView_0.RowCount == 0)
		{
			return;
		}
		int int_ = (int)this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_92.Name].Value;
		this.form7_0 = new Form7(this.method_2(), this.method_0(), int_, -1);
		this.form7_0.SqlSettings = this.SqlSettings;
		this.form7_0.MdiParent = base.MdiParent;
		this.form7_0.method_1(4);
		DataRow[] array = this.class107_0.tP_CabBranches.Select("id = " + int_.ToString());
		this.form7_0.method_3((Class107.Class288)array[0]);
		this.form7_0.hUtmjzkxkdC(this.class107_0.tP_BranchObjRelation.method_5());
		this.form7_0.Show();
		this.form7_0.FormClosed -= this.form7_0_FormClosed;
		this.form7_0.FormClosed += this.form7_0_FormClosed;
	}

	private void toolStripButton_5_Click(object sender, EventArgs e)
	{
		if (this.dataGridView_0.RowCount == 0)
		{
			return;
		}
		int num = (int)this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_92.Name].Value;
		int num2;
		if (!int.TryParse(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_95.Name].Value.ToString(), out num2))
		{
			num2 = -1;
		}
		this.int_3 = this.dataGridView_0.CurrentRow.Index;
		this.form7_0 = new Form7(this.method_2(), this.method_0(), num, num2);
		this.form7_0.SqlSettings = this.SqlSettings;
		this.form7_0.MdiParent = base.MdiParent;
		this.form7_0.method_1(6);
		DataRow[] array = this.class107_0.tP_CabBranches.Select("id = " + num.ToString());
		this.form7_0.method_3((Class107.Class288)array[0]);
		DataRow[] array2 = this.class107_0.tP_BranchObjRelation.Select(string.Format("idCabBranch = {0} and idObj = {1}", num, num2));
		this.form7_0.hUtmjzkxkdC((Class107.Class289)array2[0]);
		this.form7_0.Show();
		this.form7_0.FormClosed -= this.form7_0_FormClosed;
		this.form7_0.FormClosed += this.form7_0_FormClosed;
	}

	private void toolStripButton_6_Click(object sender, EventArgs e)
	{
		if (this.dataGridView_0.RowCount == 0)
		{
			return;
		}
		int num = (int)this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_92.Name].Value;
		int num2 = (int)this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_95.Name].Value;
		this.bindingSource_3.RemoveCurrent();
		for (int i = 0; i < this.class107_0.tP_BranchObjRelation.Rows.Count; i++)
		{
			if (this.class107_0.tP_BranchObjRelation[i].RowState != DataRowState.Deleted && this.class107_0.tP_BranchObjRelation[i].idCabBranch == num && this.class107_0.tP_BranchObjRelation[i].idObj == num2)
			{
				this.class107_0.tP_BranchObjRelation[i].Delete();
				if (this.class107_0.tP_BranchObjRelation.Select("idCabBranch = " + num.ToString()).Length == 0)
				{
					this.class107_0.tP_CabBranches.Select("id = " + num.ToString())[0].Delete();
				}
				return;
			}
		}
	}

	private void method_18()
	{
		base.SelectSqlData(this.class107_0, this.class107_0.tP_CabBranches, true, string.Format("where idPole = '{0}'", this.method_0()));
		if (this.class107_0.tP_CabBranches.Rows.Count == 0)
		{
			return;
		}
		string text = string.Empty;
		foreach (object obj in this.class107_0.tP_CabBranches.Rows)
		{
			Class107.Class288 @class = (Class107.Class288)obj;
			text = text + "," + @class.id.ToString();
		}
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Remove(0, 1);
			base.SelectSqlData(this.class107_0, this.class107_0.tP_BranchObjRelation, true, string.Format("where idCabBranch in ({0})", text));
		}
		base.SelectSqlData(this.class107_0, this.class107_0.vP_CabBranches, true, string.Format(" where idPole = '{0}' order by id, idAirLine desc", this.method_0()));
		this.bindingSource_3.ResetBindings(false);
	}

	private void form7_0_FormClosed(object sender, FormClosedEventArgs e)
	{
		if (this.form7_0.DialogResult == DialogResult.OK)
		{
			Class107.Class290 @class = this.class107_0.vP_CabBranches.method_4();
			switch (this.form7_0.method_0())
			{
			case 0:
			{
				this.class107_0.tP_CabBranches.Rows.Add(this.form7_0.method_2());
				int num = this.class107_0.tP_CabBranches.Rows.IndexOf(this.form7_0.method_2());
				this.form7_0.method_4().idCabBranch = this.class107_0.tP_CabBranches[num].id;
				this.class107_0.tP_BranchObjRelation.Rows.Add(this.form7_0.method_4());
				@class.id = this.class107_0.tP_CabBranches[num].id;
				for (int i = 1; i < this.form7_0.method_2().ItemArray.Count<object>(); i++)
				{
					string columnName = this.class107_0.tP_CabBranches.Columns[i].ColumnName;
					@class[columnName] = this.form7_0.method_2()[columnName];
				}
				for (int j = 2; j < this.form7_0.method_4().ItemArray.Count<object>(); j++)
				{
					string columnName2 = this.class107_0.tP_BranchObjRelation.Columns[j].ColumnName;
					@class[columnName2] = this.form7_0.method_4()[columnName2];
				}
				@class.AirLineName = this.form7_0.AirLineName;
				@class.ObjName = this.form7_0.ObjName;
				@class.cableType = this.form7_0.method_5();
				@class.EndEdit();
				this.class107_0.vP_CabBranches.Rows.Add(@class);
				goto IL_4CD;
			}
			case 1:
				using (IEnumerator enumerator = this.class107_0.vP_CabBranches.Rows.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						Class107.Class290 class2 = (Class107.Class290)obj;
						if (class2.id == this.form7_0.method_2().id)
						{
							for (int k = 1; k < this.form7_0.method_2().ItemArray.Count<object>(); k++)
							{
								string columnName3 = this.class107_0.tP_CabBranches.Columns[k].ColumnName;
								class2[columnName3] = this.form7_0.method_2()[columnName3];
							}
							class2.AirLineName = this.form7_0.AirLineName;
							class2.cableType = this.form7_0.method_5();
						}
					}
					goto IL_4CD;
				}
				break;
			case 2:
			case 3:
			case 5:
				goto IL_4CD;
			case 4:
				break;
			case 6:
			{
				int num = this.dataGridView_0.CurrentRow.Index;
				this.class107_0.vP_CabBranches[this.int_3].idObj = this.form7_0.method_4().idObj;
				this.class107_0.vP_CabBranches[this.int_3].ObjName = this.form7_0.ObjName;
				this.class107_0.vP_CabBranches[this.int_3].typeCodeId = this.form7_0.method_4().typeCodeId;
				goto IL_4CD;
			}
			default:
				goto IL_4CD;
			}
			this.form7_0.method_4().idCabBranch = this.form7_0.method_2().id;
			this.class107_0.tP_BranchObjRelation.Rows.Add(this.form7_0.method_4());
			for (int l = 0; l < this.form7_0.method_2().ItemArray.Count<object>(); l++)
			{
				string columnName4 = this.class107_0.tP_CabBranches.Columns[l].ColumnName;
				@class[columnName4] = this.form7_0.method_2()[columnName4];
			}
			for (int m = 2; m < this.form7_0.method_4().ItemArray.Count<object>(); m++)
			{
				string columnName5 = this.class107_0.tP_BranchObjRelation.Columns[m].ColumnName;
				@class[columnName5] = this.form7_0.method_4()[columnName5];
			}
			@class.AirLineName = this.form7_0.AirLineName;
			@class.ObjName = this.form7_0.ObjName;
			@class.cableType = this.form7_0.method_5();
			@class.EndEdit();
			this.class107_0.vP_CabBranches.Rows.Add(@class);
			IL_4CD:
			DataView dataView = new DataView(this.class107_0.vP_CabBranches);
			dataView.Sort = "id, idAirLine asc";
			this.bindingSource_3.DataSource = dataView;
		}
	}

	private void method_19()
	{
		for (int i = 0; i < this.class107_0.tP_CabBranches.Rows.Count; i++)
		{
			if (this.class107_0.tP_CabBranches[i].RowState == DataRowState.Added)
			{
				this.class107_0.tP_CabBranches[i].idPole = this.method_0();
				int id = this.class107_0.tP_CabBranches[i].id;
				int num = base.InsertSqlDataOneRow(this.class107_0.tP_CabBranches[i]);
				if (num != -1)
				{
					for (int j = 0; j < this.class107_0.tP_BranchObjRelation.Rows.Count; j++)
					{
						if (this.class107_0.tP_BranchObjRelation[j].RowState != DataRowState.Deleted && this.class107_0.tP_BranchObjRelation[j].idCabBranch == id)
						{
							this.class107_0.tP_BranchObjRelation[j].idCabBranch = num;
						}
					}
				}
			}
		}
		base.InsertSqlData(this.class107_0.tP_BranchObjRelation);
		base.UpdateSqlDataOnlyChange(this.class107_0.tP_CabBranches);
		base.UpdateSqlDataOnlyChange(this.class107_0.tP_BranchObjRelation);
		base.DeleteSqlData(this.class107_0.tP_CabBranches);
		base.DeleteSqlData(this.class107_0.tP_BranchObjRelation);
	}

	private void bindingSource_3_CurrentChanged(object sender, EventArgs e)
	{
		bool enabled = this.bindingSource_3.Current != null;
		this.toolStripButton_4.Enabled = enabled;
		this.toolStripButton_5.Enabled = enabled;
		this.toolStripButton_6.Enabled = enabled;
	}

	private void method_20()
	{
		string cmdText = "select sect.id, sect.idObjList, (obj.typeCodeSocr + '-' + obj.Name) as AirLineName,\r\nsect.idClutchFirst, F.Name as fPole, sect.idClutchSecond, S.Name as sPole, sect.idEquipment, cab.CableMakeup\r\nfrom tP_CabSection as sect left join\r\nvSchm_ObjList as obj on sect.idObjList = obj.Id left join\r\ntSchm_ObjList as F on F.id = sect.idClutchFirst left join\r\ntSchm_ObjList as S on S.id = sect.idClutchSecond left join\r\ntR_Cable as cab on cab.id = sect.idEquipment\r\n" + string.Format("where (sect.idClutchFirst = '{0}' or sect.idClutchSecond = '{0}') and sect.deleted = '0'", this.method_0());
		SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
		sqlConnection.Open();
		try
		{
			new SqlDataAdapter(new SqlCommand(cmdText, sqlConnection)).Fill(this.dataSet_0, "Attachment");
			this.dataGridView_1.AutoGenerateColumns = false;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.Source);
			sqlConnection.Close();
		}
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		this.method_24(this.method_0());
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		this.method_25();
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		this.method_26();
	}

	private void toolStripButton_10_Click(object sender, EventArgs e)
	{
		this.method_22(this.method_0());
	}

	private void method_21(int int_4, int int_5)
	{
		this.method_22(int_4);
		foreach (object obj in ((IEnumerable)this.dataGridViewExcelFilter_0.Rows))
		{
			DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
			if ((int)dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_180.Name].Value == int_5)
			{
				dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_182.Name].Selected = true;
				this.dataGridViewExcelFilter_0.FirstDisplayedScrollingRowIndex = dataGridViewRow.Index;
			}
		}
	}

	private void method_22(int int_4)
	{
		int typeCodeId = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;INLINE_OBJ;OTHER_OBJ;", 2m);
		int typeCodeId2 = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;INLINE_OBJ;OTHER_OBJ;", 1m);
		int typeCodeId3 = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;INLINE_OBJ;SWITCH;", 8m);
		int typeCodeId4 = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;INLINE_OBJ;SWITCH;", 14m);
		DataTable dataTable = new DataTable();
		DataTable dataTable_ = new DataTable();
		dataTable = PassportData.GetEquipmentData(this.SqlSettings, typeCodeId, ",typeCodeName, idPylon ", ",c_ol.Name as typeCodeName, ol.idParentAddl as idPylon ", string.Format("WHERE ol.idParentAddl in ({0}) AND ol.TypeCodeId = {1}", int_4, typeCodeId), "", false);
		dataTable_ = PassportData.GetEquipmentData(this.SqlSettings, typeCodeId2, ",typeCodeName, idPylon ", ",c_ol.Name as typeCodeName, ol.idParentAddl as idPylon ", string.Format("WHERE ol.idParentAddl in ({0}) AND ol.TypeCodeId = {1}", int_4, typeCodeId2), "", false);
		this.method_23(dataTable, dataTable_);
		dataTable_ = PassportData.GetEquipmentData(this.SqlSettings, typeCodeId3, ",typeCodeName, idPylon ", ",c_ol.Name as typeCodeName, ol.idParentAddl as idPylon ", string.Format("WHERE ol.idParentAddl in ({0}) AND ol.TypeCodeId = {1}", int_4, typeCodeId3), "", false);
		this.method_23(dataTable, dataTable_);
		dataTable_ = PassportData.GetEquipmentData(this.SqlSettings, typeCodeId4, ",typeCodeName, idPylon ", ",c_ol.Name as typeCodeName, ol.idParentAddl as idPylon ", string.Format("WHERE ol.idParentAddl in ({0}) AND ol.TypeCodeId = {1}", int_4, typeCodeId4), "", false);
		this.method_23(dataTable, dataTable_);
		this.bindingSource_0 = new BindingSource();
		this.bindingSource_0.DataSource = dataTable;
		this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
	}

	private void method_23(DataTable dataTable_1, DataTable dataTable_2)
	{
		foreach (object obj in dataTable_2.Columns)
		{
			DataColumn dataColumn = (DataColumn)obj;
			if (!dataTable_1.Columns.Contains(dataColumn.ColumnName))
			{
				dataTable_1.Columns.Add(new DataColumn(dataColumn.ColumnName, dataColumn.DataType));
			}
		}
		foreach (object obj2 in dataTable_2.Rows)
		{
			DataRow dataRow = (DataRow)obj2;
			DataRow dataRow2 = dataTable_1.NewRow();
			foreach (object obj3 in dataTable_2.Columns)
			{
				DataColumn dataColumn2 = (DataColumn)obj3;
				dataRow2[dataColumn2.ColumnName] = dataRow[dataColumn2.ColumnName];
			}
			dataTable_1.Rows.Add(dataRow2);
		}
	}

	private void method_24(int int_4 = -1)
	{
		Form9 form = new Form9(this.method_2(), -1, int_4);
		form.SqlSettings = this.SqlSettings;
		form.method_1(0);
		form.MdiParent = base.MdiParent;
		form.FormClosed += this.method_27;
		form.Show();
	}

	private void method_25()
	{
		if (this.bindingSource_0 != null && this.bindingSource_0.Current != null)
		{
			int int_ = Convert.ToInt32(((DataRowView)this.bindingSource_0.Current).Row["idObjList"]);
			Form9 form = new Form9(this.method_2(), int_, -1);
			form.SqlSettings = this.SqlSettings;
			form.method_1(1);
			form.FormClosed += this.method_27;
			form.MdiParent = base.MdiParent;
			form.Show();
			return;
		}
	}

	private void method_26()
	{
		if (this.bindingSource_0 == null || this.bindingSource_0.Current == null)
		{
			return;
		}
		if (MessageBox.Show("Вы дествительно хотите удалить выбранное оборудование?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
		{
			return;
		}
		int num = Convert.ToInt32(((DataRowView)this.bindingSource_0.Current).Row["idObjList"]);
		DataTable dataTable = new DataTable("tSchm_ObjList");
		new SqlDataCommand(this.SqlSettings).UpdateSqlData(dataTable, "set deleted = '1'", string.Format("where id = '{0}'", num));
		this.method_22(this.method_0());
	}

	private void method_27(object sender, FormClosedEventArgs e)
	{
		Form9 form = (Form9)sender;
		if (form.DialogResult == DialogResult.OK)
		{
			if (form.method_0() == null)
			{
				this.method_22(this.method_0());
				return;
			}
			if (form.method_0() == 1)
			{
				this.method_21(this.method_0(), form.method_2());
			}
		}
	}

	private void nXumYxuHiJu(object sender, DataGridViewCellEventArgs e)
	{
		this.method_25();
	}

	private void dataGridViewExcelFilter_0_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
	{
		if (e.ColumnIndex == -1 && e.RowIndex == -1)
		{
			e.ContextMenuStrip = null;
			return;
		}
		e.ContextMenuStrip = this.contextMenuStrip_0;
	}

	private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.tabControl_0.SelectedTab == this.tabPage_1 && this.method_6() == 1)
		{
			this.method_20();
			return;
		}
		if (this.tabControl_0.SelectedTab == this.tabPage_2)
		{
			this.method_22(this.method_0());
		}
	}

	private int method_28(string string_1, decimal decimal_0)
	{
		DataTable dataTable = new DataTable("tR_Classifier");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("Name", typeof(string));
		base.SelectSqlData(dataTable, true, string.Format("where ParentKey = '{0}' and Value = '{1}' and deleted = '0'", string_1, decimal_0), null, false, 0);
		if (dataTable.Rows.Count > 0)
		{
			return Convert.ToInt32(dataTable.Rows[0]["id"]);
		}
		return -1;
	}

	private void comboBox_1_SelectedValueChanged(object sender, EventArgs e)
	{
		if (this.comboBox_1.SelectedValue == null)
		{
			return;
		}
		this.method_1(Convert.ToInt32(this.comboBox_1.SelectedValue));
		base.SelectSqlData(this.class107_0, this.class107_0.tSchm_ObjList, true, string.Format("WHERE id = {0}", this.method_0()));
		int activePassport = PassportData.GetActivePassport(this.SqlSettings, this.method_0());
		base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where id = '{0}'", activePassport), null, false, 0);
		this.WlYmhhmeTud.AddRowEditingParameter(this.SqlSettings, activePassport, DataGridViewPassport.CreateState.EditValue);
		this.method_18();
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.MuimhWmsJeG != null)
		{
			this.MuimhWmsJeG.Dispose();
		}
		Form13.wTf0759tJG1skIPOgyyi(this, bool_0);
	}

	private void method_29()
	{
		this.MuimhWmsJeG = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
		this.sRpmhjcafTn = new TableLayoutPanel();
		this.label_0 = new Label();
		this.aUamhyqUbcS = new Label();
		this.label_1 = new Label();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.comboBox_0 = new ComboBox();
		this.bindingSource_2 = new BindingSource(this.MuimhWmsJeG);
		this.class107_0 = new Class107();
		this.bindingSource_1 = new BindingSource(this.MuimhWmsJeG);
		this.WlYmhhmeTud = new DataGridViewPassport();
		this.dataGridViewTextBoxColumn_216 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_217 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_218 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_40 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_219 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_220 = new DataGridViewTextBoxColumn();
		this.label_2 = new Label();
		this.nullableDateTimePicker_0 = new NullableDateTimePicker();
		this.SaXmhDkoWpW = new ToolStrip();
		this.toolStripButton_0 = new ToolStripButton();
		this.toolStripButton_1 = new ToolStripButton();
		this.toolStripButton_2 = new ToolStripButton();
		this.toolStripButton_3 = new ToolStripButton();
		this.oSemuTsZeeO = new ToolStripSeparator();
		this.toolStripButton_4 = new ToolStripButton();
		this.toolStripButton_5 = new ToolStripButton();
		this.toolStripButton_6 = new ToolStripButton();
		this.dataGridView_0 = new DataGridView();
		this.dataGridViewTextBoxColumn_92 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_93 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_94 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_95 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_96 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_97 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_98 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_99 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_100 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_101 = new DataGridViewTextBoxColumn();
		this.foomDmAjsXv = new DataGridViewTextBoxColumn();
		this.bindingSource_3 = new BindingSource(this.MuimhWmsJeG);
		this.label_3 = new Label();
		this.textBox_0 = new TextBox();
		this.tableLayoutPanel_0 = new TableLayoutPanel();
		this.comboBox_1 = new ComboBox();
		this.arhmhfXsamx = new TextBox();
		this.dataGridViewTextBoxColumn_212 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_213 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_214 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_39 = new DataGridViewCheckBoxColumn();
		this.ImdmNpylFi1 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_215 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_207 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_208 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_209 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_38 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_210 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_211 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_203 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_204 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_205 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_37 = new DataGridViewCheckBoxColumn();
		this.sBnmNslbenp = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_206 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_198 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_199 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_200 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_36 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_201 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_202 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_193 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_194 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_195 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_35 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_196 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_197 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_189 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_190 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_191 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_34 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_192 = new DataGridViewTextBoxColumn();
		this.HfemNmvmel1 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_184 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_185 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_186 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_33 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_187 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_188 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_174 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_175 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_176 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_32 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_177 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_178 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_169 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_170 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_171 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_31 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_172 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_173 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_164 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_165 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_166 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_30 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_167 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_168 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_159 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_160 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_161 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_29 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_162 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_163 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_154 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_155 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_156 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_28 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_157 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_158 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_149 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_150 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_151 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_27 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_152 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_153 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_145 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_146 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_147 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_26 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_148 = new DataGridViewTextBoxColumn();
		this.grEmAmWmSlf = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_140 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_141 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_142 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_25 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_143 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_144 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_135 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_136 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_137 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_24 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_138 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_139 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_130 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_131 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_132 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_23 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_133 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_134 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_125 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_126 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_127 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_22 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_128 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_129 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_120 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_121 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_122 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_21 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_123 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_124 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_116 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_117 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_118 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_20 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_119 = new DataGridViewTextBoxColumn();
		this.OaMmDjiXcZm = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_111 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_112 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_113 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_19 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_114 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_115 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_106 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_107 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_108 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_18 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_109 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_110 = new DataGridViewTextBoxColumn();
		this.XoxmDaTvfrW = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_102 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_103 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_17 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_104 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_105 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_78 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_79 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_80 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_16 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_81 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_82 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_73 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_74 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_75 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_15 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_76 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_77 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_68 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_69 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_70 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_14 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_71 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_72 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_13 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_66 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_67 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_12 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_11 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_10 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_9 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_8 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_7 = new DataGridViewCheckBoxColumn();
		this.KykmupDneZn = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_6 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
		this.dZdmuJrqoc0 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_5 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_4 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		this.tabControl_0 = new TabControl();
		this.tabPage_0 = new TabPage();
		this.tabPage_1 = new TabPage();
		this.dataGridView_1 = new DataGridView();
		this.dataGridViewTextBoxColumn_83 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_84 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_85 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_86 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_87 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_88 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_89 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_90 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_91 = new DataGridViewTextBoxColumn();
		this.bindingSource_4 = new BindingSource(this.MuimhWmsJeG);
		this.dataSet_0 = new DataSet();
		this.dataTable_0 = new DataTable();
		this.dataColumn_0 = new DataColumn();
		this.dataColumn_1 = new DataColumn();
		this.dataColumn_2 = new DataColumn();
		this.dataColumn_3 = new DataColumn();
		this.dataColumn_4 = new DataColumn();
		this.dataColumn_5 = new DataColumn();
		this.dataColumn_6 = new DataColumn();
		this.dataColumn_7 = new DataColumn();
		this.dataColumn_8 = new DataColumn();
		this.tabPage_2 = new TabPage();
		this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
		this.MrxmArpksbR = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_179 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_180 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_181 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_182 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_183 = new DataGridViewTextBoxColumn();
		this.mhYmAyRpMln = new ToolStrip();
		this.toolStripButton_7 = new ToolStripButton();
		this.toolStripButton_8 = new ToolStripButton();
		this.toolStripButton_9 = new ToolStripButton();
		this.toolStripSeparator_0 = new ToolStripSeparator();
		this.toolStripButton_10 = new ToolStripButton();
		this.contextMenuStrip_0 = new ContextMenuStrip(this.MuimhWmsJeG);
		this.toolStripMenuItem_0 = new ToolStripMenuItem();
		this.toolStripMenuItem_1 = new ToolStripMenuItem();
		this.toolStripMenuItem_2 = new ToolStripMenuItem();
		this.sRpmhjcafTn.SuspendLayout();
		((ISupportInitialize)this.bindingSource_2).BeginInit();
		((ISupportInitialize)this.class107_0).BeginInit();
		((ISupportInitialize)this.bindingSource_1).BeginInit();
		((ISupportInitialize)this.WlYmhhmeTud).BeginInit();
		this.SaXmhDkoWpW.SuspendLayout();
		((ISupportInitialize)this.dataGridView_0).BeginInit();
		((ISupportInitialize)this.bindingSource_3).BeginInit();
		this.tableLayoutPanel_0.SuspendLayout();
		this.tabControl_0.SuspendLayout();
		this.tabPage_0.SuspendLayout();
		this.tabPage_1.SuspendLayout();
		((ISupportInitialize)this.dataGridView_1).BeginInit();
		((ISupportInitialize)this.bindingSource_4).BeginInit();
		((ISupportInitialize)this.dataSet_0).BeginInit();
		((ISupportInitialize)this.dataTable_0).BeginInit();
		this.tabPage_2.SuspendLayout();
		this.dataGridViewExcelFilter_0.BeginInit();
		this.mhYmAyRpMln.SuspendLayout();
		this.contextMenuStrip_0.SuspendLayout();
		base.SuspendLayout();
		this.sRpmhjcafTn.ColumnCount = 6;
		this.sRpmhjcafTn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
		this.sRpmhjcafTn.ColumnStyles.Add(new ColumnStyle());
		this.sRpmhjcafTn.ColumnStyles.Add(new ColumnStyle());
		this.sRpmhjcafTn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		this.sRpmhjcafTn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54f));
		this.sRpmhjcafTn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 176f));
		this.sRpmhjcafTn.Controls.Add(this.label_0, 1, 1);
		this.sRpmhjcafTn.Controls.Add(this.aUamhyqUbcS, 1, 2);
		this.sRpmhjcafTn.Controls.Add(this.label_1, 1, 3);
		this.sRpmhjcafTn.Controls.Add(this.button_0, 5, 8);
		this.sRpmhjcafTn.Controls.Add(this.button_1, 2, 8);
		this.sRpmhjcafTn.Controls.Add(this.comboBox_0, 2, 2);
		this.sRpmhjcafTn.Controls.Add(this.WlYmhhmeTud, 0, 5);
		this.sRpmhjcafTn.Controls.Add(this.label_2, 4, 4);
		this.sRpmhjcafTn.Controls.Add(this.nullableDateTimePicker_0, 5, 4);
		this.sRpmhjcafTn.Controls.Add(this.SaXmhDkoWpW, 0, 6);
		this.sRpmhjcafTn.Controls.Add(this.dataGridView_0, 0, 7);
		this.sRpmhjcafTn.Controls.Add(this.label_3, 1, 4);
		this.sRpmhjcafTn.Controls.Add(this.textBox_0, 2, 4);
		this.sRpmhjcafTn.Controls.Add(this.tableLayoutPanel_0, 2, 1);
		this.sRpmhjcafTn.Dock = DockStyle.Fill;
		this.sRpmhjcafTn.Location = new Point(3, 3);
		this.sRpmhjcafTn.Name = "tableLayoutPanel1";
		this.sRpmhjcafTn.RowCount = 9;
		this.sRpmhjcafTn.RowStyles.Add(new RowStyle(SizeType.Absolute, 10f));
		this.sRpmhjcafTn.RowStyles.Add(new RowStyle());
		this.sRpmhjcafTn.RowStyles.Add(new RowStyle());
		this.sRpmhjcafTn.RowStyles.Add(new RowStyle());
		this.sRpmhjcafTn.RowStyles.Add(new RowStyle(SizeType.Absolute, 34f));
		this.sRpmhjcafTn.RowStyles.Add(new RowStyle(SizeType.Percent, 70f));
		this.sRpmhjcafTn.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		this.sRpmhjcafTn.RowStyles.Add(new RowStyle(SizeType.Percent, 30f));
		this.sRpmhjcafTn.RowStyles.Add(new RowStyle(SizeType.Absolute, 43f));
		this.sRpmhjcafTn.Size = new Size(455, 558);
		this.sRpmhjcafTn.TabIndex = 0;
		this.label_0.AutoSize = true;
		this.label_0.Dock = DockStyle.Fill;
		this.label_0.Location = new Point(23, 10);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(83, 27);
		this.label_0.TabIndex = 0;
		this.label_0.Text = "Наименование";
		this.label_0.TextAlign = ContentAlignment.MiddleLeft;
		this.aUamhyqUbcS.AutoSize = true;
		this.aUamhyqUbcS.Dock = DockStyle.Fill;
		this.aUamhyqUbcS.Location = new Point(23, 37);
		this.aUamhyqUbcS.Name = "label2";
		this.aUamhyqUbcS.Size = new Size(83, 27);
		this.aUamhyqUbcS.TabIndex = 1;
		this.aUamhyqUbcS.Text = "Тип опоры";
		this.aUamhyqUbcS.TextAlign = ContentAlignment.MiddleLeft;
		this.label_1.AutoSize = true;
		this.sRpmhjcafTn.SetColumnSpan(this.label_1, 2);
		this.label_1.Dock = DockStyle.Fill;
		this.label_1.Location = new Point(23, 71);
		this.label_1.Margin = new Padding(3, 7, 3, 3);
		this.label_1.Name = "label3";
		this.label_1.Size = new Size(189, 13);
		this.label_1.TabIndex = 2;
		this.label_1.Text = "Паспортные данные:";
		this.label_1.TextAlign = ContentAlignment.MiddleLeft;
		this.button_0.DialogResult = DialogResult.Cancel;
		this.button_0.Dock = DockStyle.Left;
		this.button_0.Location = new Point(286, 521);
		this.button_0.Margin = new Padding(7, 7, 3, 10);
		this.button_0.Name = "btnCancel";
		this.button_0.Size = new Size(75, 27);
		this.button_0.TabIndex = 3;
		this.button_0.Text = "Отмена";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_1_Click;
		this.sRpmhjcafTn.SetColumnSpan(this.button_1, 3);
		this.button_1.DialogResult = DialogResult.OK;
		this.button_1.Dock = DockStyle.Right;
		this.button_1.Location = new Point(197, 521);
		this.button_1.Margin = new Padding(3, 7, 7, 10);
		this.button_1.Name = "btnAccept";
		this.button_1.Size = new Size(75, 27);
		this.button_1.TabIndex = 4;
		this.button_1.Text = "Применить";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.sRpmhjcafTn.SetColumnSpan(this.comboBox_0, 3);
		this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_2, "TypeCodeId", true));
		this.comboBox_0.DataSource = this.bindingSource_1;
		this.comboBox_0.DisplayMember = "Name";
		this.comboBox_0.Dock = DockStyle.Fill;
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Location = new Point(112, 40);
		this.comboBox_0.Name = "cbType";
		this.comboBox_0.Size = new Size(164, 21);
		this.comboBox_0.TabIndex = 5;
		this.comboBox_0.ValueMember = "Id";
		this.bindingSource_2.DataMember = "tSchm_ObjList";
		this.bindingSource_2.DataSource = this.class107_0;
		this.class107_0.DataSetName = "dsPassport";
		this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.bindingSource_1.DataMember = "tR_Classifier";
		this.bindingSource_1.DataSource = this.class107_0;
		this.bindingSource_1.Sort = "Name";
		this.WlYmhhmeTud.AllowUserToAddRows = false;
		this.WlYmhhmeTud.AllowUserToDeleteRows = false;
		this.WlYmhhmeTud.AllowUserToResizeRows = false;
		this.WlYmhhmeTud.BackgroundColor = Color.White;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		this.WlYmhhmeTud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.WlYmhhmeTud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.sRpmhjcafTn.SetColumnSpan(this.WlYmhhmeTud, 6);
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = Color.White;
		dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = Color.White;
		dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
		this.WlYmhhmeTud.DefaultCellStyle = dataGridViewCellStyle2;
		this.WlYmhhmeTud.Dock = DockStyle.Fill;
		this.WlYmhhmeTud.DragDropComplite = false;
		this.WlYmhhmeTud.EditMode = DataGridViewEditMode.EditOnEnter;
		this.WlYmhhmeTud.Location = new Point(3, 124);
		this.WlYmhhmeTud.MultiSelect = false;
		this.WlYmhhmeTud.Name = "DataGridViewPassport1";
		this.WlYmhhmeTud.RowHeadersVisible = false;
		this.WlYmhhmeTud.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.WlYmhhmeTud.Size = new Size(449, 252);
		this.WlYmhhmeTud.TabIndex = 7;
		this.dataGridViewTextBoxColumn_216.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_216.Name = "dataGridViewTextBoxColumn196";
		this.dataGridViewTextBoxColumn_216.ReadOnly = true;
		this.dataGridViewTextBoxColumn_216.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_216.Visible = false;
		this.dataGridViewTextBoxColumn_217.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_217.Name = "dataGridViewTextBoxColumn197";
		this.dataGridViewTextBoxColumn_217.ReadOnly = true;
		this.dataGridViewTextBoxColumn_217.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_217.Visible = false;
		this.dataGridViewTextBoxColumn_218.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_218.Name = "dataGridViewTextBoxColumn198";
		this.dataGridViewTextBoxColumn_218.ReadOnly = true;
		this.dataGridViewTextBoxColumn_218.Visible = false;
		this.dataGridViewCheckBoxColumn_40.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_40.Name = "dataGridViewCheckBoxColumn40";
		this.dataGridViewCheckBoxColumn_40.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_40.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_40.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_40.Visible = false;
		this.dataGridViewTextBoxColumn_219.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_219.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_219.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_219.Name = "dataGridViewTextBoxColumn199";
		this.dataGridViewTextBoxColumn_219.ReadOnly = true;
		this.dataGridViewTextBoxColumn_219.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_219.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_219.Width = 5;
		this.dataGridViewTextBoxColumn_220.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_220.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_220.Name = "dataGridViewTextBoxColumn200";
		this.dataGridViewTextBoxColumn_220.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_220.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.label_2.AutoSize = true;
		this.label_2.Dock = DockStyle.Right;
		this.label_2.Location = new Point(243, 87);
		this.label_2.Name = "label4";
		this.label_2.Size = new Size(33, 34);
		this.label_2.TabIndex = 8;
		this.label_2.Text = "Дата";
		this.label_2.TextAlign = ContentAlignment.MiddleRight;
		this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.class107_0, "tP_Passport.Date", true));
		this.nullableDateTimePicker_0.Dock = DockStyle.Fill;
		this.nullableDateTimePicker_0.Location = new Point(282, 94);
		this.nullableDateTimePicker_0.Margin = new Padding(3, 7, 3, 3);
		this.nullableDateTimePicker_0.Name = "dtpDatePassport";
		this.nullableDateTimePicker_0.Size = new Size(170, 20);
		this.nullableDateTimePicker_0.TabIndex = 9;
		this.nullableDateTimePicker_0.Value = new DateTime(2013, 6, 6, 14, 38, 31, 127);
		this.sRpmhjcafTn.SetColumnSpan(this.SaXmhDkoWpW, 6);
		this.SaXmhDkoWpW.Dock = DockStyle.Fill;
		this.SaXmhDkoWpW.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_0,
			this.toolStripButton_1,
			this.toolStripButton_2,
			this.toolStripButton_3,
			this.oSemuTsZeeO,
			this.toolStripButton_4,
			this.toolStripButton_5,
			this.toolStripButton_6
		});
		this.SaXmhDkoWpW.Location = new Point(0, 379);
		this.SaXmhDkoWpW.Name = "toolStripBranch";
		this.SaXmhDkoWpW.Size = new Size(455, 25);
		this.SaXmhDkoWpW.TabIndex = 10;
		this.SaXmhDkoWpW.Text = "toolStrip1";
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.Image = Resources.smethod_24();
		this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_0.Name = "toolBtnAdd";
		this.toolStripButton_0.Size = new Size(23, 22);
		this.toolStripButton_0.Text = "Добавить ответвление";
		this.toolStripButton_0.Click += this.toolStripButton_0_Click;
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.Image = Resources.smethod_26();
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "toolBtnEdit";
		this.toolStripButton_1.Size = new Size(23, 22);
		this.toolStripButton_1.Text = "Редактировать ответвление";
		this.toolStripButton_1.Click += this.toolStripButton_1_Click;
		this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_2.Image = Resources.smethod_25();
		this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_2.Name = "toolBtnUpd";
		this.toolStripButton_2.Size = new Size(23, 22);
		this.toolStripButton_2.Text = "Удалить ответвление";
		this.toolStripButton_2.Click += this.toolStripButton_2_Click;
		this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_3.Image = Resources.smethod_45();
		this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_3.Name = "toolBtnUpdate";
		this.toolStripButton_3.Size = new Size(23, 22);
		this.toolStripButton_3.Text = "Обновить ответвления";
		this.toolStripButton_3.Visible = false;
		this.toolStripButton_3.Click += this.toolStripButton_3_Click;
		this.oSemuTsZeeO.Name = "toolStripSeparator1";
		this.oSemuTsZeeO.Size = new Size(6, 25);
		this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_4.Enabled = false;
		this.toolStripButton_4.Image = Resources.smethod_1();
		this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_4.Name = "toolBtnAddObj";
		this.toolStripButton_4.Size = new Size(23, 22);
		this.toolStripButton_4.Text = "Добавить объект";
		this.toolStripButton_4.Click += this.toolStripButton_4_Click;
		this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_5.Enabled = false;
		this.toolStripButton_5.Image = Resources.smethod_2();
		this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_5.Name = "toolBtnEditObj";
		this.toolStripButton_5.Size = new Size(23, 22);
		this.toolStripButton_5.Text = "Редактировать объект";
		this.toolStripButton_5.Click += this.toolStripButton_5_Click;
		this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_6.Enabled = false;
		this.toolStripButton_6.Image = Resources.Delete;
		this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_6.Name = "toolBtnDelObj";
		this.toolStripButton_6.Size = new Size(23, 22);
		this.toolStripButton_6.Text = "Удалить объект";
		this.toolStripButton_6.Click += this.toolStripButton_6_Click;
		this.dataGridView_0.AllowUserToAddRows = false;
		this.dataGridView_0.AllowUserToDeleteRows = false;
		this.dataGridView_0.AutoGenerateColumns = false;
		dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
		dataGridViewCellStyle3.BackColor = SystemColors.Control;
		dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
		this.dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
		this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_92,
			this.dataGridViewTextBoxColumn_93,
			this.dataGridViewTextBoxColumn_94,
			this.dataGridViewTextBoxColumn_95,
			this.dataGridViewTextBoxColumn_96,
			this.dataGridViewTextBoxColumn_97,
			this.dataGridViewTextBoxColumn_98,
			this.dataGridViewTextBoxColumn_99,
			this.dataGridViewTextBoxColumn_100,
			this.dataGridViewTextBoxColumn_101,
			this.foomDmAjsXv
		});
		this.sRpmhjcafTn.SetColumnSpan(this.dataGridView_0, 6);
		this.dataGridView_0.DataSource = this.bindingSource_3;
		this.dataGridView_0.Dock = DockStyle.Fill;
		this.dataGridView_0.Location = new Point(3, 407);
		this.dataGridView_0.Name = "dgvCabBranches";
		this.dataGridView_0.ReadOnly = true;
		this.dataGridView_0.RowHeadersVisible = false;
		this.dataGridView_0.Size = new Size(449, 104);
		this.dataGridView_0.TabIndex = 11;
		this.dataGridViewTextBoxColumn_92.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_92.HeaderText = "Отвод";
		this.dataGridViewTextBoxColumn_92.MinimumWidth = 15;
		this.dataGridViewTextBoxColumn_92.Name = "idDgvCabBranches";
		this.dataGridViewTextBoxColumn_92.ReadOnly = true;
		this.dataGridViewTextBoxColumn_92.Width = 30;
		this.dataGridViewTextBoxColumn_93.DataPropertyName = "idAirLine";
		this.dataGridViewTextBoxColumn_93.HeaderText = "idAirLine";
		this.dataGridViewTextBoxColumn_93.Name = "idAirLineDgvCabBranches";
		this.dataGridViewTextBoxColumn_93.ReadOnly = true;
		this.dataGridViewTextBoxColumn_93.Visible = false;
		this.dataGridViewTextBoxColumn_94.DataPropertyName = "idPole";
		this.dataGridViewTextBoxColumn_94.HeaderText = "idPole";
		this.dataGridViewTextBoxColumn_94.Name = "idPoleDgvCabBranches";
		this.dataGridViewTextBoxColumn_94.ReadOnly = true;
		this.dataGridViewTextBoxColumn_94.Visible = false;
		this.dataGridViewTextBoxColumn_95.DataPropertyName = "idObj";
		this.dataGridViewTextBoxColumn_95.HeaderText = "idObj";
		this.dataGridViewTextBoxColumn_95.Name = "idObjDgvCabBranches";
		this.dataGridViewTextBoxColumn_95.ReadOnly = true;
		this.dataGridViewTextBoxColumn_95.Visible = false;
		this.dataGridViewTextBoxColumn_96.DataPropertyName = "typeCodeId";
		this.dataGridViewTextBoxColumn_96.HeaderText = "typeCodeId";
		this.dataGridViewTextBoxColumn_96.Name = "typeCodeIdDgvCabBranches";
		this.dataGridViewTextBoxColumn_96.ReadOnly = true;
		this.dataGridViewTextBoxColumn_96.Visible = false;
		this.dataGridViewTextBoxColumn_97.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_97.DataPropertyName = "AirLineName";
		this.dataGridViewTextBoxColumn_97.HeaderText = "Линия";
		this.dataGridViewTextBoxColumn_97.MinimumWidth = 30;
		this.dataGridViewTextBoxColumn_97.Name = "airLineNameDgvCabBranches";
		this.dataGridViewTextBoxColumn_97.ReadOnly = true;
		this.dataGridViewTextBoxColumn_98.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_98.DataPropertyName = "ObjName";
		this.dataGridViewTextBoxColumn_98.HeaderText = "Объект";
		this.dataGridViewTextBoxColumn_98.MinimumWidth = 30;
		this.dataGridViewTextBoxColumn_98.Name = "objNameDgvCabBranches";
		this.dataGridViewTextBoxColumn_98.ReadOnly = true;
		this.dataGridViewTextBoxColumn_99.DataPropertyName = "cableMakeup";
		this.dataGridViewTextBoxColumn_99.HeaderText = "Марка кабеля";
		this.dataGridViewTextBoxColumn_99.Name = "cableMakeupDgvCabBranches";
		this.dataGridViewTextBoxColumn_99.ReadOnly = true;
		this.dataGridViewTextBoxColumn_99.Visible = false;
		this.dataGridViewTextBoxColumn_100.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_100.DataPropertyName = "cableType";
		this.dataGridViewTextBoxColumn_100.HeaderText = "Тип провода";
		this.dataGridViewTextBoxColumn_100.MinimumWidth = 30;
		this.dataGridViewTextBoxColumn_100.Name = "cableTypeDgvCabBranches";
		this.dataGridViewTextBoxColumn_100.ReadOnly = true;
		this.dataGridViewTextBoxColumn_101.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_101.DataPropertyName = "wireGauge";
		this.dataGridViewTextBoxColumn_101.HeaderText = "Сечение";
		this.dataGridViewTextBoxColumn_101.MinimumWidth = 30;
		this.dataGridViewTextBoxColumn_101.Name = "wireGaugeDgvCabBranches";
		this.dataGridViewTextBoxColumn_101.ReadOnly = true;
		this.foomDmAjsXv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.foomDmAjsXv.DataPropertyName = "cableLength";
		this.foomDmAjsXv.HeaderText = "Длина кабеля, м";
		this.foomDmAjsXv.MinimumWidth = 30;
		this.foomDmAjsXv.Name = "cableLengthDgvCabBranches";
		this.foomDmAjsXv.ReadOnly = true;
		this.bindingSource_3.DataMember = "vP_CabBranches";
		this.bindingSource_3.DataSource = this.class107_0;
		this.bindingSource_3.CurrentChanged += this.bindingSource_3_CurrentChanged;
		this.label_3.AutoSize = true;
		this.label_3.Dock = DockStyle.Fill;
		this.label_3.Location = new Point(23, 87);
		this.label_3.Name = "label5";
		this.label_3.Size = new Size(83, 34);
		this.label_3.TabIndex = 12;
		this.label_3.Text = "Номер";
		this.label_3.TextAlign = ContentAlignment.MiddleLeft;
		this.textBox_0.DataBindings.Add(new Binding("Text", this.class107_0, "tP_Passport.Number", true));
		this.textBox_0.Dock = DockStyle.Fill;
		this.textBox_0.Location = new Point(112, 94);
		this.textBox_0.Margin = new Padding(3, 7, 3, 3);
		this.textBox_0.Name = "txtNumber";
		this.textBox_0.Size = new Size(100, 20);
		this.textBox_0.TabIndex = 13;
		this.tableLayoutPanel_0.ColumnCount = 1;
		this.sRpmhjcafTn.SetColumnSpan(this.tableLayoutPanel_0, 3);
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		this.tableLayoutPanel_0.Controls.Add(this.comboBox_1, 0, 1);
		this.tableLayoutPanel_0.Controls.Add(this.arhmhfXsamx, 0, 0);
		this.tableLayoutPanel_0.Location = new Point(112, 13);
		this.tableLayoutPanel_0.Name = "tableLayoutPanel2";
		this.tableLayoutPanel_0.RowCount = 2;
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel_0.Size = new Size(164, 21);
		this.tableLayoutPanel_0.TabIndex = 14;
		this.comboBox_1.Dock = DockStyle.Fill;
		this.comboBox_1.Enabled = false;
		this.comboBox_1.FormattingEnabled = true;
		this.comboBox_1.Location = new Point(0, 20);
		this.comboBox_1.Margin = new Padding(0);
		this.comboBox_1.Name = "cmbName";
		this.comboBox_1.Size = new Size(164, 21);
		this.comboBox_1.TabIndex = 0;
		this.comboBox_1.Visible = false;
		this.comboBox_1.SelectedValueChanged += this.comboBox_1_SelectedValueChanged;
		this.arhmhfXsamx.DataBindings.Add(new Binding("Text", this.bindingSource_2, "Name", true));
		this.arhmhfXsamx.Dock = DockStyle.Fill;
		this.arhmhfXsamx.Location = new Point(0, 0);
		this.arhmhfXsamx.Margin = new Padding(0);
		this.arhmhfXsamx.Name = "tbName";
		this.arhmhfXsamx.Size = new Size(164, 20);
		this.arhmhfXsamx.TabIndex = 6;
		this.dataGridViewTextBoxColumn_212.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_212.Name = "dataGridViewTextBoxColumn191";
		this.dataGridViewTextBoxColumn_212.ReadOnly = true;
		this.dataGridViewTextBoxColumn_212.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_212.Visible = false;
		this.dataGridViewTextBoxColumn_213.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_213.Name = "dataGridViewTextBoxColumn192";
		this.dataGridViewTextBoxColumn_213.ReadOnly = true;
		this.dataGridViewTextBoxColumn_213.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_213.Visible = false;
		this.dataGridViewTextBoxColumn_214.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_214.Name = "dataGridViewTextBoxColumn193";
		this.dataGridViewTextBoxColumn_214.ReadOnly = true;
		this.dataGridViewTextBoxColumn_214.Visible = false;
		this.dataGridViewCheckBoxColumn_39.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_39.Name = "dataGridViewCheckBoxColumn39";
		this.dataGridViewCheckBoxColumn_39.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_39.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_39.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_39.Visible = false;
		this.ImdmNpylFi1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.ImdmNpylFi1.FillWeight = 150f;
		this.ImdmNpylFi1.HeaderText = "Характеристика";
		this.ImdmNpylFi1.Name = "dataGridViewTextBoxColumn194";
		this.ImdmNpylFi1.ReadOnly = true;
		this.ImdmNpylFi1.Resizable = DataGridViewTriState.True;
		this.ImdmNpylFi1.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_215.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_215.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_215.Name = "dataGridViewTextBoxColumn195";
		this.dataGridViewTextBoxColumn_215.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_215.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_207.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_207.Name = "dataGridViewTextBoxColumn186";
		this.dataGridViewTextBoxColumn_207.ReadOnly = true;
		this.dataGridViewTextBoxColumn_207.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_207.Visible = false;
		this.dataGridViewTextBoxColumn_208.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_208.Name = "dataGridViewTextBoxColumn187";
		this.dataGridViewTextBoxColumn_208.ReadOnly = true;
		this.dataGridViewTextBoxColumn_208.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_208.Visible = false;
		this.dataGridViewTextBoxColumn_209.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_209.Name = "dataGridViewTextBoxColumn188";
		this.dataGridViewTextBoxColumn_209.ReadOnly = true;
		this.dataGridViewTextBoxColumn_209.Visible = false;
		this.dataGridViewCheckBoxColumn_38.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_38.Name = "dataGridViewCheckBoxColumn38";
		this.dataGridViewCheckBoxColumn_38.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_38.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_38.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_38.Visible = false;
		this.dataGridViewTextBoxColumn_210.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_210.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_210.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_210.Name = "dataGridViewTextBoxColumn189";
		this.dataGridViewTextBoxColumn_210.ReadOnly = true;
		this.dataGridViewTextBoxColumn_210.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_210.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_211.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_211.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_211.Name = "dataGridViewTextBoxColumn190";
		this.dataGridViewTextBoxColumn_211.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_211.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_203.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_203.Name = "dataGridViewTextBoxColumn181";
		this.dataGridViewTextBoxColumn_203.ReadOnly = true;
		this.dataGridViewTextBoxColumn_203.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_203.Visible = false;
		this.dataGridViewTextBoxColumn_204.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_204.Name = "dataGridViewTextBoxColumn182";
		this.dataGridViewTextBoxColumn_204.ReadOnly = true;
		this.dataGridViewTextBoxColumn_204.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_204.Visible = false;
		this.dataGridViewTextBoxColumn_205.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_205.Name = "dataGridViewTextBoxColumn183";
		this.dataGridViewTextBoxColumn_205.ReadOnly = true;
		this.dataGridViewTextBoxColumn_205.Visible = false;
		this.dataGridViewCheckBoxColumn_37.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_37.Name = "dataGridViewCheckBoxColumn37";
		this.dataGridViewCheckBoxColumn_37.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_37.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_37.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_37.Visible = false;
		this.sBnmNslbenp.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.sBnmNslbenp.FillWeight = 150f;
		this.sBnmNslbenp.HeaderText = "Характеристика";
		this.sBnmNslbenp.Name = "dataGridViewTextBoxColumn184";
		this.sBnmNslbenp.ReadOnly = true;
		this.sBnmNslbenp.Resizable = DataGridViewTriState.True;
		this.sBnmNslbenp.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_206.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_206.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_206.Name = "dataGridViewTextBoxColumn185";
		this.dataGridViewTextBoxColumn_206.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_206.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_198.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_198.Name = "dataGridViewTextBoxColumn176";
		this.dataGridViewTextBoxColumn_198.ReadOnly = true;
		this.dataGridViewTextBoxColumn_198.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_198.Visible = false;
		this.dataGridViewTextBoxColumn_199.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_199.Name = "dataGridViewTextBoxColumn177";
		this.dataGridViewTextBoxColumn_199.ReadOnly = true;
		this.dataGridViewTextBoxColumn_199.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_199.Visible = false;
		this.dataGridViewTextBoxColumn_200.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_200.Name = "dataGridViewTextBoxColumn178";
		this.dataGridViewTextBoxColumn_200.ReadOnly = true;
		this.dataGridViewTextBoxColumn_200.Visible = false;
		this.dataGridViewCheckBoxColumn_36.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_36.Name = "dataGridViewCheckBoxColumn36";
		this.dataGridViewCheckBoxColumn_36.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_36.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_36.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_36.Visible = false;
		this.dataGridViewTextBoxColumn_201.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_201.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_201.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_201.Name = "dataGridViewTextBoxColumn179";
		this.dataGridViewTextBoxColumn_201.ReadOnly = true;
		this.dataGridViewTextBoxColumn_201.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_201.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_202.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_202.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_202.Name = "dataGridViewTextBoxColumn180";
		this.dataGridViewTextBoxColumn_202.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_202.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_193.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_193.Name = "dataGridViewTextBoxColumn171";
		this.dataGridViewTextBoxColumn_193.ReadOnly = true;
		this.dataGridViewTextBoxColumn_193.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_193.Visible = false;
		this.dataGridViewTextBoxColumn_194.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_194.Name = "dataGridViewTextBoxColumn172";
		this.dataGridViewTextBoxColumn_194.ReadOnly = true;
		this.dataGridViewTextBoxColumn_194.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_194.Visible = false;
		this.dataGridViewTextBoxColumn_195.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_195.Name = "dataGridViewTextBoxColumn173";
		this.dataGridViewTextBoxColumn_195.ReadOnly = true;
		this.dataGridViewTextBoxColumn_195.Visible = false;
		this.dataGridViewCheckBoxColumn_35.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_35.Name = "dataGridViewCheckBoxColumn35";
		this.dataGridViewCheckBoxColumn_35.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_35.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_35.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_35.Visible = false;
		this.dataGridViewTextBoxColumn_196.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_196.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_196.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_196.Name = "dataGridViewTextBoxColumn174";
		this.dataGridViewTextBoxColumn_196.ReadOnly = true;
		this.dataGridViewTextBoxColumn_196.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_196.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_197.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_197.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_197.Name = "dataGridViewTextBoxColumn175";
		this.dataGridViewTextBoxColumn_197.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_197.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_189.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_189.Name = "dataGridViewTextBoxColumn166";
		this.dataGridViewTextBoxColumn_189.ReadOnly = true;
		this.dataGridViewTextBoxColumn_189.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_189.Visible = false;
		this.dataGridViewTextBoxColumn_190.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_190.Name = "dataGridViewTextBoxColumn167";
		this.dataGridViewTextBoxColumn_190.ReadOnly = true;
		this.dataGridViewTextBoxColumn_190.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_190.Visible = false;
		this.dataGridViewTextBoxColumn_191.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_191.Name = "dataGridViewTextBoxColumn168";
		this.dataGridViewTextBoxColumn_191.ReadOnly = true;
		this.dataGridViewTextBoxColumn_191.Visible = false;
		this.dataGridViewCheckBoxColumn_34.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_34.Name = "dataGridViewCheckBoxColumn34";
		this.dataGridViewCheckBoxColumn_34.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_34.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_34.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_34.Visible = false;
		this.dataGridViewTextBoxColumn_192.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_192.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_192.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_192.Name = "dataGridViewTextBoxColumn169";
		this.dataGridViewTextBoxColumn_192.ReadOnly = true;
		this.dataGridViewTextBoxColumn_192.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_192.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.HfemNmvmel1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.HfemNmvmel1.HeaderText = "Значение";
		this.HfemNmvmel1.Name = "dataGridViewTextBoxColumn170";
		this.HfemNmvmel1.Resizable = DataGridViewTriState.True;
		this.HfemNmvmel1.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_184.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_184.Name = "dataGridViewTextBoxColumn161";
		this.dataGridViewTextBoxColumn_184.ReadOnly = true;
		this.dataGridViewTextBoxColumn_184.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_184.Visible = false;
		this.dataGridViewTextBoxColumn_185.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_185.Name = "dataGridViewTextBoxColumn162";
		this.dataGridViewTextBoxColumn_185.ReadOnly = true;
		this.dataGridViewTextBoxColumn_185.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_185.Visible = false;
		this.dataGridViewTextBoxColumn_186.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_186.Name = "dataGridViewTextBoxColumn163";
		this.dataGridViewTextBoxColumn_186.ReadOnly = true;
		this.dataGridViewTextBoxColumn_186.Visible = false;
		this.dataGridViewCheckBoxColumn_33.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_33.Name = "dataGridViewCheckBoxColumn33";
		this.dataGridViewCheckBoxColumn_33.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_33.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_33.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_33.Visible = false;
		this.dataGridViewTextBoxColumn_187.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_187.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_187.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_187.Name = "dataGridViewTextBoxColumn164";
		this.dataGridViewTextBoxColumn_187.ReadOnly = true;
		this.dataGridViewTextBoxColumn_187.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_187.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_188.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_188.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_188.Name = "dataGridViewTextBoxColumn165";
		this.dataGridViewTextBoxColumn_188.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_188.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_174.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_174.Name = "dataGridViewTextBoxColumn156";
		this.dataGridViewTextBoxColumn_174.ReadOnly = true;
		this.dataGridViewTextBoxColumn_174.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_174.Visible = false;
		this.dataGridViewTextBoxColumn_175.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_175.Name = "dataGridViewTextBoxColumn157";
		this.dataGridViewTextBoxColumn_175.ReadOnly = true;
		this.dataGridViewTextBoxColumn_175.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_175.Visible = false;
		this.dataGridViewTextBoxColumn_176.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_176.Name = "dataGridViewTextBoxColumn158";
		this.dataGridViewTextBoxColumn_176.ReadOnly = true;
		this.dataGridViewTextBoxColumn_176.Visible = false;
		this.dataGridViewCheckBoxColumn_32.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_32.Name = "dataGridViewCheckBoxColumn32";
		this.dataGridViewCheckBoxColumn_32.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_32.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_32.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_32.Visible = false;
		this.dataGridViewTextBoxColumn_177.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_177.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_177.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_177.Name = "dataGridViewTextBoxColumn159";
		this.dataGridViewTextBoxColumn_177.ReadOnly = true;
		this.dataGridViewTextBoxColumn_177.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_177.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_178.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_178.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_178.Name = "dataGridViewTextBoxColumn160";
		this.dataGridViewTextBoxColumn_178.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_178.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_169.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_169.Name = "dataGridViewTextBoxColumn151";
		this.dataGridViewTextBoxColumn_169.ReadOnly = true;
		this.dataGridViewTextBoxColumn_169.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_169.Visible = false;
		this.dataGridViewTextBoxColumn_170.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_170.Name = "dataGridViewTextBoxColumn152";
		this.dataGridViewTextBoxColumn_170.ReadOnly = true;
		this.dataGridViewTextBoxColumn_170.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_170.Visible = false;
		this.dataGridViewTextBoxColumn_171.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_171.Name = "dataGridViewTextBoxColumn153";
		this.dataGridViewTextBoxColumn_171.ReadOnly = true;
		this.dataGridViewTextBoxColumn_171.Visible = false;
		this.dataGridViewCheckBoxColumn_31.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_31.Name = "dataGridViewCheckBoxColumn31";
		this.dataGridViewCheckBoxColumn_31.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_31.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_31.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_31.Visible = false;
		this.dataGridViewTextBoxColumn_172.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_172.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_172.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_172.Name = "dataGridViewTextBoxColumn154";
		this.dataGridViewTextBoxColumn_172.ReadOnly = true;
		this.dataGridViewTextBoxColumn_172.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_172.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_173.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_173.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_173.Name = "dataGridViewTextBoxColumn155";
		this.dataGridViewTextBoxColumn_173.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_173.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_164.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_164.Name = "dataGridViewTextBoxColumn146";
		this.dataGridViewTextBoxColumn_164.ReadOnly = true;
		this.dataGridViewTextBoxColumn_164.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_164.Visible = false;
		this.dataGridViewTextBoxColumn_165.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_165.Name = "dataGridViewTextBoxColumn147";
		this.dataGridViewTextBoxColumn_165.ReadOnly = true;
		this.dataGridViewTextBoxColumn_165.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_165.Visible = false;
		this.dataGridViewTextBoxColumn_166.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_166.Name = "dataGridViewTextBoxColumn148";
		this.dataGridViewTextBoxColumn_166.ReadOnly = true;
		this.dataGridViewTextBoxColumn_166.Visible = false;
		this.dataGridViewCheckBoxColumn_30.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_30.Name = "dataGridViewCheckBoxColumn30";
		this.dataGridViewCheckBoxColumn_30.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_30.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_30.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_30.Visible = false;
		this.dataGridViewTextBoxColumn_167.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_167.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_167.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_167.Name = "dataGridViewTextBoxColumn149";
		this.dataGridViewTextBoxColumn_167.ReadOnly = true;
		this.dataGridViewTextBoxColumn_167.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_167.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_168.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_168.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_168.Name = "dataGridViewTextBoxColumn150";
		this.dataGridViewTextBoxColumn_168.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_168.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_159.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_159.Name = "dataGridViewTextBoxColumn141";
		this.dataGridViewTextBoxColumn_159.ReadOnly = true;
		this.dataGridViewTextBoxColumn_159.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_159.Visible = false;
		this.dataGridViewTextBoxColumn_160.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_160.Name = "dataGridViewTextBoxColumn142";
		this.dataGridViewTextBoxColumn_160.ReadOnly = true;
		this.dataGridViewTextBoxColumn_160.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_160.Visible = false;
		this.dataGridViewTextBoxColumn_161.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_161.Name = "dataGridViewTextBoxColumn143";
		this.dataGridViewTextBoxColumn_161.ReadOnly = true;
		this.dataGridViewTextBoxColumn_161.Visible = false;
		this.dataGridViewCheckBoxColumn_29.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_29.Name = "dataGridViewCheckBoxColumn29";
		this.dataGridViewCheckBoxColumn_29.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_29.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_29.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_29.Visible = false;
		this.dataGridViewTextBoxColumn_162.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_162.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_162.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_162.Name = "dataGridViewTextBoxColumn144";
		this.dataGridViewTextBoxColumn_162.ReadOnly = true;
		this.dataGridViewTextBoxColumn_162.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_162.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_163.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_163.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_163.Name = "dataGridViewTextBoxColumn145";
		this.dataGridViewTextBoxColumn_163.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_163.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_154.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_154.Name = "dataGridViewTextBoxColumn136";
		this.dataGridViewTextBoxColumn_154.ReadOnly = true;
		this.dataGridViewTextBoxColumn_154.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_154.Visible = false;
		this.dataGridViewTextBoxColumn_155.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_155.Name = "dataGridViewTextBoxColumn137";
		this.dataGridViewTextBoxColumn_155.ReadOnly = true;
		this.dataGridViewTextBoxColumn_155.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_155.Visible = false;
		this.dataGridViewTextBoxColumn_156.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_156.Name = "dataGridViewTextBoxColumn138";
		this.dataGridViewTextBoxColumn_156.ReadOnly = true;
		this.dataGridViewTextBoxColumn_156.Visible = false;
		this.dataGridViewCheckBoxColumn_28.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_28.Name = "dataGridViewCheckBoxColumn28";
		this.dataGridViewCheckBoxColumn_28.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_28.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_28.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_28.Visible = false;
		this.dataGridViewTextBoxColumn_157.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_157.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_157.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_157.Name = "dataGridViewTextBoxColumn139";
		this.dataGridViewTextBoxColumn_157.ReadOnly = true;
		this.dataGridViewTextBoxColumn_157.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_157.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_158.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_158.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_158.Name = "dataGridViewTextBoxColumn140";
		this.dataGridViewTextBoxColumn_158.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_158.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_149.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_149.Name = "dataGridViewTextBoxColumn131";
		this.dataGridViewTextBoxColumn_149.ReadOnly = true;
		this.dataGridViewTextBoxColumn_149.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_149.Visible = false;
		this.dataGridViewTextBoxColumn_150.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_150.Name = "dataGridViewTextBoxColumn132";
		this.dataGridViewTextBoxColumn_150.ReadOnly = true;
		this.dataGridViewTextBoxColumn_150.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_150.Visible = false;
		this.dataGridViewTextBoxColumn_151.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_151.Name = "dataGridViewTextBoxColumn133";
		this.dataGridViewTextBoxColumn_151.ReadOnly = true;
		this.dataGridViewTextBoxColumn_151.Visible = false;
		this.dataGridViewCheckBoxColumn_27.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_27.Name = "dataGridViewCheckBoxColumn27";
		this.dataGridViewCheckBoxColumn_27.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_27.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_27.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_27.Visible = false;
		this.dataGridViewTextBoxColumn_152.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_152.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_152.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_152.Name = "dataGridViewTextBoxColumn134";
		this.dataGridViewTextBoxColumn_152.ReadOnly = true;
		this.dataGridViewTextBoxColumn_152.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_152.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_153.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_153.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_153.Name = "dataGridViewTextBoxColumn135";
		this.dataGridViewTextBoxColumn_153.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_153.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_145.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_145.Name = "dataGridViewTextBoxColumn126";
		this.dataGridViewTextBoxColumn_145.ReadOnly = true;
		this.dataGridViewTextBoxColumn_145.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_145.Visible = false;
		this.dataGridViewTextBoxColumn_146.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_146.Name = "dataGridViewTextBoxColumn127";
		this.dataGridViewTextBoxColumn_146.ReadOnly = true;
		this.dataGridViewTextBoxColumn_146.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_146.Visible = false;
		this.dataGridViewTextBoxColumn_147.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_147.Name = "dataGridViewTextBoxColumn128";
		this.dataGridViewTextBoxColumn_147.ReadOnly = true;
		this.dataGridViewTextBoxColumn_147.Visible = false;
		this.dataGridViewCheckBoxColumn_26.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_26.Name = "dataGridViewCheckBoxColumn26";
		this.dataGridViewCheckBoxColumn_26.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_26.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_26.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_26.Visible = false;
		this.dataGridViewTextBoxColumn_148.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_148.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_148.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_148.Name = "dataGridViewTextBoxColumn129";
		this.dataGridViewTextBoxColumn_148.ReadOnly = true;
		this.dataGridViewTextBoxColumn_148.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_148.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.grEmAmWmSlf.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.grEmAmWmSlf.HeaderText = "Значение";
		this.grEmAmWmSlf.Name = "dataGridViewTextBoxColumn130";
		this.grEmAmWmSlf.Resizable = DataGridViewTriState.True;
		this.grEmAmWmSlf.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_140.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_140.Name = "dataGridViewTextBoxColumn121";
		this.dataGridViewTextBoxColumn_140.ReadOnly = true;
		this.dataGridViewTextBoxColumn_140.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_140.Visible = false;
		this.dataGridViewTextBoxColumn_141.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_141.Name = "dataGridViewTextBoxColumn122";
		this.dataGridViewTextBoxColumn_141.ReadOnly = true;
		this.dataGridViewTextBoxColumn_141.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_141.Visible = false;
		this.dataGridViewTextBoxColumn_142.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_142.Name = "dataGridViewTextBoxColumn123";
		this.dataGridViewTextBoxColumn_142.ReadOnly = true;
		this.dataGridViewTextBoxColumn_142.Visible = false;
		this.dataGridViewCheckBoxColumn_25.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_25.Name = "dataGridViewCheckBoxColumn25";
		this.dataGridViewCheckBoxColumn_25.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_25.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_25.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_25.Visible = false;
		this.dataGridViewTextBoxColumn_143.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_143.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_143.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_143.Name = "dataGridViewTextBoxColumn124";
		this.dataGridViewTextBoxColumn_143.ReadOnly = true;
		this.dataGridViewTextBoxColumn_143.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_143.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_144.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_144.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_144.Name = "dataGridViewTextBoxColumn125";
		this.dataGridViewTextBoxColumn_144.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_144.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_135.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_135.Name = "dataGridViewTextBoxColumn116";
		this.dataGridViewTextBoxColumn_135.ReadOnly = true;
		this.dataGridViewTextBoxColumn_135.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_135.Visible = false;
		this.dataGridViewTextBoxColumn_136.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_136.Name = "dataGridViewTextBoxColumn117";
		this.dataGridViewTextBoxColumn_136.ReadOnly = true;
		this.dataGridViewTextBoxColumn_136.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_136.Visible = false;
		this.dataGridViewTextBoxColumn_137.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_137.Name = "dataGridViewTextBoxColumn118";
		this.dataGridViewTextBoxColumn_137.ReadOnly = true;
		this.dataGridViewTextBoxColumn_137.Visible = false;
		this.dataGridViewCheckBoxColumn_24.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_24.Name = "dataGridViewCheckBoxColumn24";
		this.dataGridViewCheckBoxColumn_24.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_24.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_24.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_24.Visible = false;
		this.dataGridViewTextBoxColumn_138.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_138.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_138.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_138.Name = "dataGridViewTextBoxColumn119";
		this.dataGridViewTextBoxColumn_138.ReadOnly = true;
		this.dataGridViewTextBoxColumn_138.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_138.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_139.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_139.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_139.Name = "dataGridViewTextBoxColumn120";
		this.dataGridViewTextBoxColumn_139.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_139.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_130.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_130.Name = "dataGridViewTextBoxColumn111";
		this.dataGridViewTextBoxColumn_130.ReadOnly = true;
		this.dataGridViewTextBoxColumn_130.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_130.Visible = false;
		this.dataGridViewTextBoxColumn_131.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_131.Name = "dataGridViewTextBoxColumn112";
		this.dataGridViewTextBoxColumn_131.ReadOnly = true;
		this.dataGridViewTextBoxColumn_131.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_131.Visible = false;
		this.dataGridViewTextBoxColumn_132.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_132.Name = "dataGridViewTextBoxColumn113";
		this.dataGridViewTextBoxColumn_132.ReadOnly = true;
		this.dataGridViewTextBoxColumn_132.Visible = false;
		this.dataGridViewCheckBoxColumn_23.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_23.Name = "dataGridViewCheckBoxColumn23";
		this.dataGridViewCheckBoxColumn_23.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_23.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_23.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_23.Visible = false;
		this.dataGridViewTextBoxColumn_133.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_133.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_133.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_133.Name = "dataGridViewTextBoxColumn114";
		this.dataGridViewTextBoxColumn_133.ReadOnly = true;
		this.dataGridViewTextBoxColumn_133.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_133.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_134.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_134.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_134.Name = "dataGridViewTextBoxColumn115";
		this.dataGridViewTextBoxColumn_134.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_134.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_125.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_125.Name = "dataGridViewTextBoxColumn106";
		this.dataGridViewTextBoxColumn_125.ReadOnly = true;
		this.dataGridViewTextBoxColumn_125.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_125.Visible = false;
		this.dataGridViewTextBoxColumn_126.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_126.Name = "dataGridViewTextBoxColumn107";
		this.dataGridViewTextBoxColumn_126.ReadOnly = true;
		this.dataGridViewTextBoxColumn_126.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_126.Visible = false;
		this.dataGridViewTextBoxColumn_127.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_127.Name = "dataGridViewTextBoxColumn108";
		this.dataGridViewTextBoxColumn_127.ReadOnly = true;
		this.dataGridViewTextBoxColumn_127.Visible = false;
		this.dataGridViewCheckBoxColumn_22.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_22.Name = "dataGridViewCheckBoxColumn22";
		this.dataGridViewCheckBoxColumn_22.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_22.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_22.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_22.Visible = false;
		this.dataGridViewTextBoxColumn_128.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_128.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_128.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_128.Name = "dataGridViewTextBoxColumn109";
		this.dataGridViewTextBoxColumn_128.ReadOnly = true;
		this.dataGridViewTextBoxColumn_128.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_128.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_129.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_129.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_129.Name = "dataGridViewTextBoxColumn110";
		this.dataGridViewTextBoxColumn_129.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_129.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_120.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_120.Name = "dataGridViewTextBoxColumn101";
		this.dataGridViewTextBoxColumn_120.ReadOnly = true;
		this.dataGridViewTextBoxColumn_120.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_120.Visible = false;
		this.dataGridViewTextBoxColumn_121.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_121.Name = "dataGridViewTextBoxColumn102";
		this.dataGridViewTextBoxColumn_121.ReadOnly = true;
		this.dataGridViewTextBoxColumn_121.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_121.Visible = false;
		this.dataGridViewTextBoxColumn_122.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_122.Name = "dataGridViewTextBoxColumn103";
		this.dataGridViewTextBoxColumn_122.ReadOnly = true;
		this.dataGridViewTextBoxColumn_122.Visible = false;
		this.dataGridViewCheckBoxColumn_21.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_21.Name = "dataGridViewCheckBoxColumn21";
		this.dataGridViewCheckBoxColumn_21.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_21.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_21.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_21.Visible = false;
		this.dataGridViewTextBoxColumn_123.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_123.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_123.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_123.Name = "dataGridViewTextBoxColumn104";
		this.dataGridViewTextBoxColumn_123.ReadOnly = true;
		this.dataGridViewTextBoxColumn_123.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_123.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_124.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_124.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_124.Name = "dataGridViewTextBoxColumn105";
		this.dataGridViewTextBoxColumn_124.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_124.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_116.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_116.Name = "dataGridViewTextBoxColumn96";
		this.dataGridViewTextBoxColumn_116.ReadOnly = true;
		this.dataGridViewTextBoxColumn_116.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_116.Visible = false;
		this.dataGridViewTextBoxColumn_117.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_117.Name = "dataGridViewTextBoxColumn97";
		this.dataGridViewTextBoxColumn_117.ReadOnly = true;
		this.dataGridViewTextBoxColumn_117.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_117.Visible = false;
		this.dataGridViewTextBoxColumn_118.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_118.Name = "dataGridViewTextBoxColumn98";
		this.dataGridViewTextBoxColumn_118.ReadOnly = true;
		this.dataGridViewTextBoxColumn_118.Visible = false;
		this.dataGridViewCheckBoxColumn_20.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_20.Name = "dataGridViewCheckBoxColumn20";
		this.dataGridViewCheckBoxColumn_20.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_20.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_20.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_20.Visible = false;
		this.dataGridViewTextBoxColumn_119.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_119.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_119.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_119.Name = "dataGridViewTextBoxColumn99";
		this.dataGridViewTextBoxColumn_119.ReadOnly = true;
		this.dataGridViewTextBoxColumn_119.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_119.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.OaMmDjiXcZm.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.OaMmDjiXcZm.HeaderText = "Значение";
		this.OaMmDjiXcZm.Name = "dataGridViewTextBoxColumn100";
		this.OaMmDjiXcZm.Resizable = DataGridViewTriState.True;
		this.OaMmDjiXcZm.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_111.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_111.Name = "dataGridViewTextBoxColumn91";
		this.dataGridViewTextBoxColumn_111.ReadOnly = true;
		this.dataGridViewTextBoxColumn_111.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_111.Visible = false;
		this.dataGridViewTextBoxColumn_112.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_112.Name = "dataGridViewTextBoxColumn92";
		this.dataGridViewTextBoxColumn_112.ReadOnly = true;
		this.dataGridViewTextBoxColumn_112.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_112.Visible = false;
		this.dataGridViewTextBoxColumn_113.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_113.Name = "dataGridViewTextBoxColumn93";
		this.dataGridViewTextBoxColumn_113.ReadOnly = true;
		this.dataGridViewTextBoxColumn_113.Visible = false;
		this.dataGridViewCheckBoxColumn_19.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_19.Name = "dataGridViewCheckBoxColumn19";
		this.dataGridViewCheckBoxColumn_19.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_19.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_19.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_19.Visible = false;
		this.dataGridViewTextBoxColumn_114.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_114.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_114.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_114.Name = "dataGridViewTextBoxColumn94";
		this.dataGridViewTextBoxColumn_114.ReadOnly = true;
		this.dataGridViewTextBoxColumn_114.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_114.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_115.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_115.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_115.Name = "dataGridViewTextBoxColumn95";
		this.dataGridViewTextBoxColumn_115.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_115.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_106.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_106.Name = "dataGridViewTextBoxColumn86";
		this.dataGridViewTextBoxColumn_106.ReadOnly = true;
		this.dataGridViewTextBoxColumn_106.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_106.Visible = false;
		this.dataGridViewTextBoxColumn_107.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_107.Name = "dataGridViewTextBoxColumn87";
		this.dataGridViewTextBoxColumn_107.ReadOnly = true;
		this.dataGridViewTextBoxColumn_107.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_107.Visible = false;
		this.dataGridViewTextBoxColumn_108.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_108.Name = "dataGridViewTextBoxColumn88";
		this.dataGridViewTextBoxColumn_108.ReadOnly = true;
		this.dataGridViewTextBoxColumn_108.Visible = false;
		this.dataGridViewCheckBoxColumn_18.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_18.Name = "dataGridViewCheckBoxColumn18";
		this.dataGridViewCheckBoxColumn_18.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_18.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_18.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_18.Visible = false;
		this.dataGridViewTextBoxColumn_109.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_109.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_109.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_109.Name = "dataGridViewTextBoxColumn89";
		this.dataGridViewTextBoxColumn_109.ReadOnly = true;
		this.dataGridViewTextBoxColumn_109.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_109.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_110.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_110.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_110.Name = "dataGridViewTextBoxColumn90";
		this.dataGridViewTextBoxColumn_110.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_110.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.XoxmDaTvfrW.HeaderText = "idChar";
		this.XoxmDaTvfrW.Name = "dataGridViewTextBoxColumn81";
		this.XoxmDaTvfrW.ReadOnly = true;
		this.XoxmDaTvfrW.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.XoxmDaTvfrW.Visible = false;
		this.dataGridViewTextBoxColumn_102.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_102.Name = "dataGridViewTextBoxColumn82";
		this.dataGridViewTextBoxColumn_102.ReadOnly = true;
		this.dataGridViewTextBoxColumn_102.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_102.Visible = false;
		this.dataGridViewTextBoxColumn_103.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_103.Name = "dataGridViewTextBoxColumn83";
		this.dataGridViewTextBoxColumn_103.ReadOnly = true;
		this.dataGridViewTextBoxColumn_103.Visible = false;
		this.dataGridViewCheckBoxColumn_17.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_17.Name = "dataGridViewCheckBoxColumn17";
		this.dataGridViewCheckBoxColumn_17.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_17.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_17.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_17.Visible = false;
		this.dataGridViewTextBoxColumn_104.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_104.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_104.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_104.Name = "dataGridViewTextBoxColumn84";
		this.dataGridViewTextBoxColumn_104.ReadOnly = true;
		this.dataGridViewTextBoxColumn_104.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_104.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_105.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_105.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_105.Name = "dataGridViewTextBoxColumn85";
		this.dataGridViewTextBoxColumn_105.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_105.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_78.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_78.Name = "dataGridViewTextBoxColumn76";
		this.dataGridViewTextBoxColumn_78.ReadOnly = true;
		this.dataGridViewTextBoxColumn_78.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_78.Visible = false;
		this.dataGridViewTextBoxColumn_79.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_79.Name = "dataGridViewTextBoxColumn77";
		this.dataGridViewTextBoxColumn_79.ReadOnly = true;
		this.dataGridViewTextBoxColumn_79.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_79.Visible = false;
		this.dataGridViewTextBoxColumn_80.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_80.Name = "dataGridViewTextBoxColumn78";
		this.dataGridViewTextBoxColumn_80.ReadOnly = true;
		this.dataGridViewTextBoxColumn_80.Visible = false;
		this.dataGridViewCheckBoxColumn_16.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_16.Name = "dataGridViewCheckBoxColumn16";
		this.dataGridViewCheckBoxColumn_16.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_16.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_16.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_16.Visible = false;
		this.dataGridViewTextBoxColumn_81.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_81.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_81.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_81.Name = "dataGridViewTextBoxColumn79";
		this.dataGridViewTextBoxColumn_81.ReadOnly = true;
		this.dataGridViewTextBoxColumn_81.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_81.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_82.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_82.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_82.Name = "dataGridViewTextBoxColumn80";
		this.dataGridViewTextBoxColumn_82.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_82.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_73.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_73.Name = "dataGridViewTextBoxColumn71";
		this.dataGridViewTextBoxColumn_73.ReadOnly = true;
		this.dataGridViewTextBoxColumn_73.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_73.Visible = false;
		this.dataGridViewTextBoxColumn_74.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_74.Name = "dataGridViewTextBoxColumn72";
		this.dataGridViewTextBoxColumn_74.ReadOnly = true;
		this.dataGridViewTextBoxColumn_74.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_74.Visible = false;
		this.dataGridViewTextBoxColumn_75.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_75.Name = "dataGridViewTextBoxColumn73";
		this.dataGridViewTextBoxColumn_75.ReadOnly = true;
		this.dataGridViewTextBoxColumn_75.Visible = false;
		this.dataGridViewCheckBoxColumn_15.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_15.Name = "dataGridViewCheckBoxColumn15";
		this.dataGridViewCheckBoxColumn_15.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_15.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_15.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_15.Visible = false;
		this.dataGridViewTextBoxColumn_76.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_76.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_76.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_76.Name = "dataGridViewTextBoxColumn74";
		this.dataGridViewTextBoxColumn_76.ReadOnly = true;
		this.dataGridViewTextBoxColumn_76.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_76.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_77.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_77.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_77.Name = "dataGridViewTextBoxColumn75";
		this.dataGridViewTextBoxColumn_77.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_77.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_68.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_68.Name = "dataGridViewTextBoxColumn66";
		this.dataGridViewTextBoxColumn_68.ReadOnly = true;
		this.dataGridViewTextBoxColumn_68.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_68.Visible = false;
		this.dataGridViewTextBoxColumn_69.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_69.Name = "dataGridViewTextBoxColumn67";
		this.dataGridViewTextBoxColumn_69.ReadOnly = true;
		this.dataGridViewTextBoxColumn_69.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_69.Visible = false;
		this.dataGridViewTextBoxColumn_70.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_70.Name = "dataGridViewTextBoxColumn68";
		this.dataGridViewTextBoxColumn_70.ReadOnly = true;
		this.dataGridViewTextBoxColumn_70.Visible = false;
		this.dataGridViewCheckBoxColumn_14.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_14.Name = "dataGridViewCheckBoxColumn14";
		this.dataGridViewCheckBoxColumn_14.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_14.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_14.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_14.Visible = false;
		this.dataGridViewTextBoxColumn_71.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_71.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_71.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_71.Name = "dataGridViewTextBoxColumn69";
		this.dataGridViewTextBoxColumn_71.ReadOnly = true;
		this.dataGridViewTextBoxColumn_71.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_71.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_72.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_72.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_72.Name = "dataGridViewTextBoxColumn70";
		this.dataGridViewTextBoxColumn_72.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_72.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_63.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_63.Name = "dataGridViewTextBoxColumn61";
		this.dataGridViewTextBoxColumn_63.ReadOnly = true;
		this.dataGridViewTextBoxColumn_63.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_63.Visible = false;
		this.dataGridViewTextBoxColumn_64.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_64.Name = "dataGridViewTextBoxColumn62";
		this.dataGridViewTextBoxColumn_64.ReadOnly = true;
		this.dataGridViewTextBoxColumn_64.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_64.Visible = false;
		this.dataGridViewTextBoxColumn_65.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_65.Name = "dataGridViewTextBoxColumn63";
		this.dataGridViewTextBoxColumn_65.ReadOnly = true;
		this.dataGridViewTextBoxColumn_65.Visible = false;
		this.dataGridViewCheckBoxColumn_13.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_13.Name = "dataGridViewCheckBoxColumn13";
		this.dataGridViewCheckBoxColumn_13.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_13.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_13.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_13.Visible = false;
		this.dataGridViewTextBoxColumn_66.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_66.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_66.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_66.Name = "dataGridViewTextBoxColumn64";
		this.dataGridViewTextBoxColumn_66.ReadOnly = true;
		this.dataGridViewTextBoxColumn_66.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_66.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_67.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_67.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_67.Name = "dataGridViewTextBoxColumn65";
		this.dataGridViewTextBoxColumn_67.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_67.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_58.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_58.Name = "dataGridViewTextBoxColumn56";
		this.dataGridViewTextBoxColumn_58.ReadOnly = true;
		this.dataGridViewTextBoxColumn_58.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_58.Visible = false;
		this.dataGridViewTextBoxColumn_59.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_59.Name = "dataGridViewTextBoxColumn57";
		this.dataGridViewTextBoxColumn_59.ReadOnly = true;
		this.dataGridViewTextBoxColumn_59.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_59.Visible = false;
		this.dataGridViewTextBoxColumn_60.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_60.Name = "dataGridViewTextBoxColumn58";
		this.dataGridViewTextBoxColumn_60.ReadOnly = true;
		this.dataGridViewTextBoxColumn_60.Visible = false;
		this.dataGridViewCheckBoxColumn_12.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_12.Name = "dataGridViewCheckBoxColumn12";
		this.dataGridViewCheckBoxColumn_12.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_12.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_12.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_12.Visible = false;
		this.dataGridViewTextBoxColumn_61.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_61.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_61.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_61.Name = "dataGridViewTextBoxColumn59";
		this.dataGridViewTextBoxColumn_61.ReadOnly = true;
		this.dataGridViewTextBoxColumn_61.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_61.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_62.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_62.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_62.Name = "dataGridViewTextBoxColumn60";
		this.dataGridViewTextBoxColumn_62.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_62.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_53.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_53.Name = "dataGridViewTextBoxColumn51";
		this.dataGridViewTextBoxColumn_53.ReadOnly = true;
		this.dataGridViewTextBoxColumn_53.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_53.Visible = false;
		this.dataGridViewTextBoxColumn_54.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_54.Name = "dataGridViewTextBoxColumn52";
		this.dataGridViewTextBoxColumn_54.ReadOnly = true;
		this.dataGridViewTextBoxColumn_54.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_54.Visible = false;
		this.dataGridViewTextBoxColumn_55.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_55.Name = "dataGridViewTextBoxColumn53";
		this.dataGridViewTextBoxColumn_55.ReadOnly = true;
		this.dataGridViewTextBoxColumn_55.Visible = false;
		this.dataGridViewCheckBoxColumn_11.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_11.Name = "dataGridViewCheckBoxColumn11";
		this.dataGridViewCheckBoxColumn_11.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_11.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_11.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_11.Visible = false;
		this.dataGridViewTextBoxColumn_56.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_56.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_56.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_56.Name = "dataGridViewTextBoxColumn54";
		this.dataGridViewTextBoxColumn_56.ReadOnly = true;
		this.dataGridViewTextBoxColumn_56.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_56.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_57.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_57.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_57.Name = "dataGridViewTextBoxColumn55";
		this.dataGridViewTextBoxColumn_57.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_57.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_48.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_48.Name = "dataGridViewTextBoxColumn46";
		this.dataGridViewTextBoxColumn_48.ReadOnly = true;
		this.dataGridViewTextBoxColumn_48.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_48.Visible = false;
		this.dataGridViewTextBoxColumn_49.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_49.Name = "dataGridViewTextBoxColumn47";
		this.dataGridViewTextBoxColumn_49.ReadOnly = true;
		this.dataGridViewTextBoxColumn_49.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_49.Visible = false;
		this.dataGridViewTextBoxColumn_50.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_50.Name = "dataGridViewTextBoxColumn48";
		this.dataGridViewTextBoxColumn_50.ReadOnly = true;
		this.dataGridViewTextBoxColumn_50.Visible = false;
		this.dataGridViewCheckBoxColumn_10.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_10.Name = "dataGridViewCheckBoxColumn10";
		this.dataGridViewCheckBoxColumn_10.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_10.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_10.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_10.Visible = false;
		this.dataGridViewTextBoxColumn_51.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_51.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_51.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_51.Name = "dataGridViewTextBoxColumn49";
		this.dataGridViewTextBoxColumn_51.ReadOnly = true;
		this.dataGridViewTextBoxColumn_51.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_51.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_52.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_52.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_52.Name = "dataGridViewTextBoxColumn50";
		this.dataGridViewTextBoxColumn_52.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_52.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_43.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_43.Name = "dataGridViewTextBoxColumn41";
		this.dataGridViewTextBoxColumn_43.ReadOnly = true;
		this.dataGridViewTextBoxColumn_43.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_43.Visible = false;
		this.dataGridViewTextBoxColumn_44.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_44.Name = "dataGridViewTextBoxColumn42";
		this.dataGridViewTextBoxColumn_44.ReadOnly = true;
		this.dataGridViewTextBoxColumn_44.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_44.Visible = false;
		this.dataGridViewTextBoxColumn_45.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_45.Name = "dataGridViewTextBoxColumn43";
		this.dataGridViewTextBoxColumn_45.ReadOnly = true;
		this.dataGridViewTextBoxColumn_45.Visible = false;
		this.dataGridViewCheckBoxColumn_9.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_9.Name = "dataGridViewCheckBoxColumn9";
		this.dataGridViewCheckBoxColumn_9.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_9.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_9.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_9.Visible = false;
		this.dataGridViewTextBoxColumn_46.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_46.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_46.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_46.Name = "dataGridViewTextBoxColumn44";
		this.dataGridViewTextBoxColumn_46.ReadOnly = true;
		this.dataGridViewTextBoxColumn_46.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_46.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_47.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_47.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_47.Name = "dataGridViewTextBoxColumn45";
		this.dataGridViewTextBoxColumn_47.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_47.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_38.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_38.Name = "dataGridViewTextBoxColumn36";
		this.dataGridViewTextBoxColumn_38.ReadOnly = true;
		this.dataGridViewTextBoxColumn_38.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_38.Visible = false;
		this.dataGridViewTextBoxColumn_39.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_39.Name = "dataGridViewTextBoxColumn37";
		this.dataGridViewTextBoxColumn_39.ReadOnly = true;
		this.dataGridViewTextBoxColumn_39.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_39.Visible = false;
		this.dataGridViewTextBoxColumn_40.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_40.Name = "dataGridViewTextBoxColumn38";
		this.dataGridViewTextBoxColumn_40.ReadOnly = true;
		this.dataGridViewTextBoxColumn_40.Visible = false;
		this.dataGridViewCheckBoxColumn_8.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_8.Name = "dataGridViewCheckBoxColumn8";
		this.dataGridViewCheckBoxColumn_8.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_8.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_8.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_8.Visible = false;
		this.dataGridViewTextBoxColumn_41.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_41.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_41.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_41.Name = "dataGridViewTextBoxColumn39";
		this.dataGridViewTextBoxColumn_41.ReadOnly = true;
		this.dataGridViewTextBoxColumn_41.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_41.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_42.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_42.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_42.Name = "dataGridViewTextBoxColumn40";
		this.dataGridViewTextBoxColumn_42.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_42.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_34.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_34.Name = "dataGridViewTextBoxColumn31";
		this.dataGridViewTextBoxColumn_34.ReadOnly = true;
		this.dataGridViewTextBoxColumn_34.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_34.Visible = false;
		this.dataGridViewTextBoxColumn_35.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_35.Name = "dataGridViewTextBoxColumn32";
		this.dataGridViewTextBoxColumn_35.ReadOnly = true;
		this.dataGridViewTextBoxColumn_35.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_35.Visible = false;
		this.dataGridViewTextBoxColumn_36.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_36.Name = "dataGridViewTextBoxColumn33";
		this.dataGridViewTextBoxColumn_36.ReadOnly = true;
		this.dataGridViewTextBoxColumn_36.Visible = false;
		this.dataGridViewCheckBoxColumn_7.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_7.Name = "dataGridViewCheckBoxColumn7";
		this.dataGridViewCheckBoxColumn_7.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_7.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_7.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_7.Visible = false;
		this.KykmupDneZn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.KykmupDneZn.FillWeight = 150f;
		this.KykmupDneZn.HeaderText = "Характеристика";
		this.KykmupDneZn.Name = "dataGridViewTextBoxColumn34";
		this.KykmupDneZn.ReadOnly = true;
		this.KykmupDneZn.Resizable = DataGridViewTriState.True;
		this.KykmupDneZn.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_37.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_37.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_37.Name = "dataGridViewTextBoxColumn35";
		this.dataGridViewTextBoxColumn_37.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_37.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_29.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_29.Name = "dataGridViewTextBoxColumn26";
		this.dataGridViewTextBoxColumn_29.ReadOnly = true;
		this.dataGridViewTextBoxColumn_29.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_29.Visible = false;
		this.dataGridViewTextBoxColumn_30.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_30.Name = "dataGridViewTextBoxColumn27";
		this.dataGridViewTextBoxColumn_30.ReadOnly = true;
		this.dataGridViewTextBoxColumn_30.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_30.Visible = false;
		this.dataGridViewTextBoxColumn_31.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_31.Name = "dataGridViewTextBoxColumn28";
		this.dataGridViewTextBoxColumn_31.ReadOnly = true;
		this.dataGridViewTextBoxColumn_31.Visible = false;
		this.dataGridViewCheckBoxColumn_6.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_6.Name = "dataGridViewCheckBoxColumn6";
		this.dataGridViewCheckBoxColumn_6.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_6.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_6.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_6.Visible = false;
		this.dataGridViewTextBoxColumn_32.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_32.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_32.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_32.Name = "dataGridViewTextBoxColumn29";
		this.dataGridViewTextBoxColumn_32.ReadOnly = true;
		this.dataGridViewTextBoxColumn_32.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_32.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_33.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_33.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_33.Name = "dataGridViewTextBoxColumn30";
		this.dataGridViewTextBoxColumn_33.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_33.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_25.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_25.Name = "dataGridViewTextBoxColumn21";
		this.dataGridViewTextBoxColumn_25.ReadOnly = true;
		this.dataGridViewTextBoxColumn_25.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_25.Visible = false;
		this.dataGridViewTextBoxColumn_26.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_26.Name = "dataGridViewTextBoxColumn22";
		this.dataGridViewTextBoxColumn_26.ReadOnly = true;
		this.dataGridViewTextBoxColumn_26.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_26.Visible = false;
		this.dZdmuJrqoc0.HeaderText = "TabIndexChar";
		this.dZdmuJrqoc0.Name = "dataGridViewTextBoxColumn23";
		this.dZdmuJrqoc0.ReadOnly = true;
		this.dZdmuJrqoc0.Visible = false;
		this.dataGridViewCheckBoxColumn_5.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_5.Name = "dataGridViewCheckBoxColumn5";
		this.dataGridViewCheckBoxColumn_5.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_5.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_5.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_5.Visible = false;
		this.dataGridViewTextBoxColumn_27.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_27.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_27.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_27.Name = "dataGridViewTextBoxColumn24";
		this.dataGridViewTextBoxColumn_27.ReadOnly = true;
		this.dataGridViewTextBoxColumn_27.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_27.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_28.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_28.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_28.Name = "dataGridViewTextBoxColumn25";
		this.dataGridViewTextBoxColumn_28.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_28.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_20.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_20.Name = "dataGridViewTextBoxColumn16";
		this.dataGridViewTextBoxColumn_20.ReadOnly = true;
		this.dataGridViewTextBoxColumn_20.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_20.Visible = false;
		this.dataGridViewTextBoxColumn_21.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_21.Name = "dataGridViewTextBoxColumn17";
		this.dataGridViewTextBoxColumn_21.ReadOnly = true;
		this.dataGridViewTextBoxColumn_21.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_21.Visible = false;
		this.dataGridViewTextBoxColumn_22.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_22.Name = "dataGridViewTextBoxColumn18";
		this.dataGridViewTextBoxColumn_22.ReadOnly = true;
		this.dataGridViewTextBoxColumn_22.Visible = false;
		this.dataGridViewCheckBoxColumn_4.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_4.Name = "dataGridViewCheckBoxColumn4";
		this.dataGridViewCheckBoxColumn_4.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_4.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_4.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_4.Visible = false;
		this.dataGridViewTextBoxColumn_23.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_23.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_23.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_23.Name = "dataGridViewTextBoxColumn19";
		this.dataGridViewTextBoxColumn_23.ReadOnly = true;
		this.dataGridViewTextBoxColumn_23.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_23.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_24.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_24.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_24.Name = "dataGridViewTextBoxColumn20";
		this.dataGridViewTextBoxColumn_24.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_24.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_15.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn11";
		this.dataGridViewTextBoxColumn_15.ReadOnly = true;
		this.dataGridViewTextBoxColumn_15.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_15.Visible = false;
		this.dataGridViewTextBoxColumn_16.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn12";
		this.dataGridViewTextBoxColumn_16.ReadOnly = true;
		this.dataGridViewTextBoxColumn_16.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_16.Visible = false;
		this.dataGridViewTextBoxColumn_17.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn13";
		this.dataGridViewTextBoxColumn_17.ReadOnly = true;
		this.dataGridViewTextBoxColumn_17.Visible = false;
		this.dataGridViewCheckBoxColumn_3.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_3.Name = "dataGridViewCheckBoxColumn3";
		this.dataGridViewCheckBoxColumn_3.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_3.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_3.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_3.Visible = false;
		this.dataGridViewTextBoxColumn_18.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_18.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_18.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn14";
		this.dataGridViewTextBoxColumn_18.ReadOnly = true;
		this.dataGridViewTextBoxColumn_18.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_18.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_19.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn15";
		this.dataGridViewTextBoxColumn_19.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_19.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_10.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn6";
		this.dataGridViewTextBoxColumn_10.ReadOnly = true;
		this.dataGridViewTextBoxColumn_10.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_10.Visible = false;
		this.dataGridViewTextBoxColumn_11.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn7";
		this.dataGridViewTextBoxColumn_11.ReadOnly = true;
		this.dataGridViewTextBoxColumn_11.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_11.Visible = false;
		this.dataGridViewTextBoxColumn_12.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn8";
		this.dataGridViewTextBoxColumn_12.ReadOnly = true;
		this.dataGridViewTextBoxColumn_12.Visible = false;
		this.dataGridViewCheckBoxColumn_2.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_2.Name = "dataGridViewCheckBoxColumn2";
		this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_2.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_2.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_2.Visible = false;
		this.dataGridViewTextBoxColumn_13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_13.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_13.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn9";
		this.dataGridViewTextBoxColumn_13.ReadOnly = true;
		this.dataGridViewTextBoxColumn_13.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_13.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_14.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn10";
		this.dataGridViewTextBoxColumn_14.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_14.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_5.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_5.ReadOnly = true;
		this.dataGridViewTextBoxColumn_5.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_5.Visible = false;
		this.dataGridViewTextBoxColumn_6.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn2";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_6.Visible = false;
		this.dataGridViewTextBoxColumn_7.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn3";
		this.dataGridViewTextBoxColumn_7.ReadOnly = true;
		this.dataGridViewTextBoxColumn_7.Visible = false;
		this.dataGridViewCheckBoxColumn_1.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_1.Name = "dataGridViewCheckBoxColumn1";
		this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_1.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_1.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_1.Visible = false;
		this.dataGridViewTextBoxColumn_8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_8.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_8.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn4";
		this.dataGridViewTextBoxColumn_8.ReadOnly = true;
		this.dataGridViewTextBoxColumn_8.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_8.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_9.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn5";
		this.dataGridViewTextBoxColumn_9.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_9.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_0.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn461";
		this.dataGridViewTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewTextBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_0.Visible = false;
		this.dataGridViewTextBoxColumn_1.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn463";
		this.dataGridViewTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewTextBoxColumn_1.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_1.Visible = false;
		this.dataGridViewTextBoxColumn_2.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn464";
		this.dataGridViewTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewTextBoxColumn_2.Visible = false;
		this.dataGridViewCheckBoxColumn_0.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_0.Name = "dataGridViewCheckBoxColumn93";
		this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_0.Visible = false;
		this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_3.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_3.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn465";
		this.dataGridViewTextBoxColumn_3.ReadOnly = true;
		this.dataGridViewTextBoxColumn_3.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_4.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn466";
		this.dataGridViewTextBoxColumn_4.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_4.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.tabControl_0.Controls.Add(this.tabPage_0);
		this.tabControl_0.Controls.Add(this.tabPage_1);
		this.tabControl_0.Controls.Add(this.tabPage_2);
		this.tabControl_0.Dock = DockStyle.Fill;
		this.tabControl_0.Location = new Point(0, 0);
		this.tabControl_0.Name = "tabControl1";
		this.tabControl_0.SelectedIndex = 0;
		this.tabControl_0.Size = new Size(469, 590);
		this.tabControl_0.TabIndex = 1;
		this.tabControl_0.SelectedIndexChanged += this.tabControl_0_SelectedIndexChanged;
		this.tabPage_0.Controls.Add(this.sRpmhjcafTn);
		this.tabPage_0.Location = new Point(4, 22);
		this.tabPage_0.Name = "tabPgPassport";
		this.tabPage_0.Padding = new Padding(3);
		this.tabPage_0.Size = new Size(461, 564);
		this.tabPage_0.TabIndex = 0;
		this.tabPage_0.Text = "Пасспорт";
		this.tabPage_0.UseVisualStyleBackColor = true;
		this.tabPage_1.Controls.Add(this.dataGridView_1);
		this.tabPage_1.Location = new Point(4, 22);
		this.tabPage_1.Name = "tabPgAttachment";
		this.tabPage_1.Padding = new Padding(3);
		this.tabPage_1.Size = new Size(461, 564);
		this.tabPage_1.TabIndex = 1;
		this.tabPage_1.Text = "Принадлежность";
		this.tabPage_1.UseVisualStyleBackColor = true;
		this.dataGridView_1.AllowUserToAddRows = false;
		this.dataGridView_1.AllowUserToDeleteRows = false;
		this.dataGridView_1.AutoGenerateColumns = false;
		dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
		dataGridViewCellStyle4.BackColor = SystemColors.Control;
		dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
		this.dataGridView_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_1.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_83,
			this.dataGridViewTextBoxColumn_84,
			this.dataGridViewTextBoxColumn_85,
			this.dataGridViewTextBoxColumn_86,
			this.dataGridViewTextBoxColumn_87,
			this.dataGridViewTextBoxColumn_88,
			this.dataGridViewTextBoxColumn_89,
			this.dataGridViewTextBoxColumn_90,
			this.dataGridViewTextBoxColumn_91
		});
		this.dataGridView_1.DataSource = this.bindingSource_4;
		this.dataGridView_1.Dock = DockStyle.Fill;
		this.dataGridView_1.Location = new Point(3, 3);
		this.dataGridView_1.Name = "dgvAttachment";
		this.dataGridView_1.ReadOnly = true;
		this.dataGridView_1.RowHeadersVisible = false;
		this.dataGridView_1.Size = new Size(455, 558);
		this.dataGridView_1.TabIndex = 0;
		this.dataGridViewTextBoxColumn_83.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_83.HeaderText = "id";
		this.dataGridViewTextBoxColumn_83.Name = "idDgvAttachment";
		this.dataGridViewTextBoxColumn_83.ReadOnly = true;
		this.dataGridViewTextBoxColumn_83.Visible = false;
		this.dataGridViewTextBoxColumn_84.DataPropertyName = "idObjList";
		this.dataGridViewTextBoxColumn_84.HeaderText = "idObjList";
		this.dataGridViewTextBoxColumn_84.Name = "idObjListDgvAttachment";
		this.dataGridViewTextBoxColumn_84.ReadOnly = true;
		this.dataGridViewTextBoxColumn_84.Visible = false;
		this.dataGridViewTextBoxColumn_85.DataPropertyName = "idClutchFirst";
		this.dataGridViewTextBoxColumn_85.HeaderText = "idClutchFirst";
		this.dataGridViewTextBoxColumn_85.Name = "idClutchFirstDgvAttachment";
		this.dataGridViewTextBoxColumn_85.ReadOnly = true;
		this.dataGridViewTextBoxColumn_85.Visible = false;
		this.dataGridViewTextBoxColumn_86.DataPropertyName = "idClutchSecond";
		this.dataGridViewTextBoxColumn_86.HeaderText = "idClutchSecond";
		this.dataGridViewTextBoxColumn_86.Name = "idClutchSecondDgvAttachment";
		this.dataGridViewTextBoxColumn_86.ReadOnly = true;
		this.dataGridViewTextBoxColumn_86.Visible = false;
		this.dataGridViewTextBoxColumn_87.DataPropertyName = "idEquipment";
		this.dataGridViewTextBoxColumn_87.HeaderText = "idEquipment";
		this.dataGridViewTextBoxColumn_87.Name = "idEquipmentDgvAttachment";
		this.dataGridViewTextBoxColumn_87.ReadOnly = true;
		this.dataGridViewTextBoxColumn_87.Visible = false;
		this.dataGridViewTextBoxColumn_88.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_88.DataPropertyName = "AirLineName";
		this.dataGridViewTextBoxColumn_88.HeaderText = "Линия";
		this.dataGridViewTextBoxColumn_88.MinimumWidth = 20;
		this.dataGridViewTextBoxColumn_88.Name = "airLineNameDgvAttachment";
		this.dataGridViewTextBoxColumn_88.ReadOnly = true;
		this.dataGridViewTextBoxColumn_89.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_89.DataPropertyName = "fPole";
		this.dataGridViewTextBoxColumn_89.HeaderText = "Опора №1";
		this.dataGridViewTextBoxColumn_89.MinimumWidth = 20;
		this.dataGridViewTextBoxColumn_89.Name = "fPoleDgvAttachment";
		this.dataGridViewTextBoxColumn_89.ReadOnly = true;
		this.dataGridViewTextBoxColumn_90.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_90.DataPropertyName = "sPole";
		this.dataGridViewTextBoxColumn_90.HeaderText = "Опора №2";
		this.dataGridViewTextBoxColumn_90.MinimumWidth = 20;
		this.dataGridViewTextBoxColumn_90.Name = "sPoleDgvAttachment";
		this.dataGridViewTextBoxColumn_90.ReadOnly = true;
		this.dataGridViewTextBoxColumn_91.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_91.DataPropertyName = "CableMakeup";
		this.dataGridViewTextBoxColumn_91.HeaderText = "Марка кабеля";
		this.dataGridViewTextBoxColumn_91.MinimumWidth = 20;
		this.dataGridViewTextBoxColumn_91.Name = "cableMakeupDgvAttachment";
		this.dataGridViewTextBoxColumn_91.ReadOnly = true;
		this.bindingSource_4.DataMember = "Attachment";
		this.bindingSource_4.DataSource = this.dataSet_0;
		this.dataSet_0.DataSetName = "NewDataSet";
		this.dataSet_0.Tables.AddRange(new DataTable[]
		{
			this.dataTable_0
		});
		this.dataTable_0.Columns.AddRange(new DataColumn[]
		{
			this.dataColumn_0,
			this.dataColumn_1,
			this.dataColumn_2,
			this.dataColumn_3,
			this.dataColumn_4,
			this.dataColumn_5,
			this.dataColumn_6,
			this.dataColumn_7,
			this.dataColumn_8
		});
		this.dataTable_0.Constraints.AddRange(new Constraint[]
		{
			new UniqueConstraint("Constraint1", new string[]
			{
				"id"
			}, true)
		});
		this.dataTable_0.PrimaryKey = new DataColumn[]
		{
			this.dataColumn_0
		};
		this.dataTable_0.TableName = "Attachment";
		this.dataColumn_0.AllowDBNull = false;
		this.dataColumn_0.AutoIncrement = true;
		this.dataColumn_0.AutoIncrementSeed = -1L;
		this.dataColumn_0.AutoIncrementStep = -1L;
		this.dataColumn_0.ColumnName = "id";
		this.dataColumn_0.DataType = typeof(int);
		this.dataColumn_1.ColumnName = "idObjList";
		this.dataColumn_1.DataType = typeof(int);
		this.dataColumn_2.ColumnName = "AirLineName";
		this.dataColumn_3.ColumnName = "idClutchFirst";
		this.dataColumn_3.DataType = typeof(int);
		this.dataColumn_4.ColumnName = "fPole";
		this.dataColumn_5.ColumnName = "idClutchSecond";
		this.dataColumn_5.DataType = typeof(int);
		this.dataColumn_6.ColumnName = "sPole";
		this.dataColumn_7.ColumnName = "idEquipment";
		this.dataColumn_7.DataType = typeof(int);
		this.dataColumn_8.ColumnName = "CableMakeup";
		this.tabPage_2.Controls.Add(this.dataGridViewExcelFilter_0);
		this.tabPage_2.Controls.Add(this.mhYmAyRpMln);
		this.tabPage_2.Location = new Point(4, 22);
		this.tabPage_2.Name = "tpEquipment";
		this.tabPage_2.Size = new Size(461, 564);
		this.tabPage_2.TabIndex = 2;
		this.tabPage_2.Text = "Оборудование";
		this.tabPage_2.UseVisualStyleBackColor = true;
		this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_0.BackgroundColor = SystemColors.Window;
		dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopLeft;
		dataGridViewCellStyle5.BackColor = SystemColors.Control;
		dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
		this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
		this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.MrxmArpksbR,
			this.dataGridViewTextBoxColumn_179,
			this.dataGridViewTextBoxColumn_180,
			this.dataGridViewTextBoxColumn_181,
			this.dataGridViewTextBoxColumn_182,
			this.dataGridViewTextBoxColumn_183
		});
		dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle6.BackColor = SystemColors.Window;
		dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle6.SelectionBackColor = SystemColors.HighlightText;
		dataGridViewCellStyle6.SelectionForeColor = Color.Blue;
		dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
		this.dataGridViewExcelFilter_0.DefaultCellStyle = dataGridViewCellStyle6;
		this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_0.Location = new Point(0, 25);
		this.dataGridViewExcelFilter_0.MultiSelect = false;
		this.dataGridViewExcelFilter_0.Name = "dgvEquipment";
		this.dataGridViewExcelFilter_0.ReadOnly = true;
		dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle7.BackColor = SystemColors.Control;
		dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle7.Padding = new Padding(0, 3, 0, 3);
		dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
		this.dataGridViewExcelFilter_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
		this.dataGridViewExcelFilter_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
		this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.CellSelect;
		this.dataGridViewExcelFilter_0.Size = new Size(461, 539);
		this.dataGridViewExcelFilter_0.TabIndex = 1;
		this.dataGridViewExcelFilter_0.CellContextMenuStripNeeded += this.dataGridViewExcelFilter_0_CellContextMenuStripNeeded;
		this.dataGridViewExcelFilter_0.CellDoubleClick += this.nXumYxuHiJu;
		this.MrxmArpksbR.DataPropertyName = "id";
		this.MrxmArpksbR.HeaderText = "id";
		this.MrxmArpksbR.Name = "idDgvEquip";
		this.MrxmArpksbR.ReadOnly = true;
		this.MrxmArpksbR.Visible = false;
		this.dataGridViewTextBoxColumn_179.DataPropertyName = "idEquipment";
		this.dataGridViewTextBoxColumn_179.HeaderText = "idEquipment";
		this.dataGridViewTextBoxColumn_179.Name = "idEquipmentDgvEquip";
		this.dataGridViewTextBoxColumn_179.ReadOnly = true;
		this.dataGridViewTextBoxColumn_179.Visible = false;
		this.dataGridViewTextBoxColumn_180.DataPropertyName = "idObjList";
		this.dataGridViewTextBoxColumn_180.HeaderText = "idObjList";
		this.dataGridViewTextBoxColumn_180.Name = "idObjListDgvEquip";
		this.dataGridViewTextBoxColumn_180.ReadOnly = true;
		this.dataGridViewTextBoxColumn_180.Visible = false;
		this.dataGridViewTextBoxColumn_181.DataPropertyName = "idPylon";
		this.dataGridViewTextBoxColumn_181.HeaderText = "idPylon";
		this.dataGridViewTextBoxColumn_181.Name = "idPylonDgvEquip";
		this.dataGridViewTextBoxColumn_181.ReadOnly = true;
		this.dataGridViewTextBoxColumn_181.Visible = false;
		this.dataGridViewTextBoxColumn_182.DataPropertyName = "typeCodeName";
		this.dataGridViewTextBoxColumn_182.HeaderText = "Оборудование";
		this.dataGridViewTextBoxColumn_182.Name = "typeCodeNameDgvEquip";
		this.dataGridViewTextBoxColumn_182.ReadOnly = true;
		this.dataGridViewTextBoxColumn_183.DataPropertyName = "Name";
		this.dataGridViewTextBoxColumn_183.HeaderText = "Наименование";
		this.dataGridViewTextBoxColumn_183.Name = "NameDgvEquip";
		this.dataGridViewTextBoxColumn_183.ReadOnly = true;
		this.mhYmAyRpMln.GripStyle = ToolStripGripStyle.Hidden;
		this.mhYmAyRpMln.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_7,
			this.toolStripButton_8,
			this.toolStripButton_9,
			this.toolStripSeparator_0,
			this.toolStripButton_10
		});
		this.mhYmAyRpMln.Location = new Point(0, 0);
		this.mhYmAyRpMln.Name = "tsEquipment";
		this.mhYmAyRpMln.Size = new Size(461, 25);
		this.mhYmAyRpMln.TabIndex = 0;
		this.mhYmAyRpMln.Text = "toolStrip1";
		this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_7.Image = Resources.smethod_24();
		this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_7.Name = "tsBtnAddEquip";
		this.toolStripButton_7.Size = new Size(23, 22);
		this.toolStripButton_7.Text = "toolStripButton1";
		this.toolStripButton_7.Click += this.toolStripMenuItem_0_Click;
		this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_8.Image = Resources.smethod_26();
		this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_8.Name = "tsBtnEditEquip";
		this.toolStripButton_8.Size = new Size(23, 22);
		this.toolStripButton_8.Text = "toolStripButton2";
		this.toolStripButton_8.Click += this.toolStripMenuItem_1_Click;
		this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_9.Image = Resources.smethod_25();
		this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_9.Name = "tsBtnDelEquip";
		this.toolStripButton_9.Size = new Size(23, 22);
		this.toolStripButton_9.Text = "toolStripButton3";
		this.toolStripButton_9.Click += this.toolStripMenuItem_2_Click;
		this.toolStripSeparator_0.Name = "toolStripSeparator2";
		this.toolStripSeparator_0.Size = new Size(6, 25);
		this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_10.Image = Resources.smethod_45();
		this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_10.Name = "tsBtnRefreshEquip";
		this.toolStripButton_10.Size = new Size(23, 22);
		this.toolStripButton_10.Text = "toolStripButton4";
		this.toolStripButton_10.Click += this.toolStripButton_10_Click;
		this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripMenuItem_0,
			this.toolStripMenuItem_1,
			this.toolStripMenuItem_2
		});
		this.contextMenuStrip_0.Name = "cmsPylonEquip";
		this.contextMenuStrip_0.Size = new Size(155, 70);
		this.toolStripMenuItem_0.Image = Resources.smethod_24();
		this.toolStripMenuItem_0.Name = "tsmiAddEquip";
		this.toolStripMenuItem_0.Size = new Size(154, 22);
		this.toolStripMenuItem_0.Text = "Добавить";
		this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
		this.toolStripMenuItem_1.Image = Resources.smethod_26();
		this.toolStripMenuItem_1.Name = "tsmiEditEquip";
		this.toolStripMenuItem_1.Size = new Size(154, 22);
		this.toolStripMenuItem_1.Text = "Редактировать";
		this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
		this.toolStripMenuItem_2.Image = Resources.smethod_25();
		this.toolStripMenuItem_2.Name = "tsmiDelEquip";
		this.toolStripMenuItem_2.Size = new Size(154, 22);
		this.toolStripMenuItem_2.Text = "Удалить";
		this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(469, 590);
		base.Controls.Add(this.tabControl_0);
		base.Name = "FormAddEditPylone";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "1";
		base.Load += this.Form13_Load;
		this.sRpmhjcafTn.ResumeLayout(false);
		this.sRpmhjcafTn.PerformLayout();
		((ISupportInitialize)this.bindingSource_2).EndInit();
		((ISupportInitialize)this.class107_0).EndInit();
		((ISupportInitialize)this.bindingSource_1).EndInit();
		((ISupportInitialize)this.WlYmhhmeTud).EndInit();
		this.SaXmhDkoWpW.ResumeLayout(false);
		this.SaXmhDkoWpW.PerformLayout();
		((ISupportInitialize)this.dataGridView_0).EndInit();
		((ISupportInitialize)this.bindingSource_3).EndInit();
		this.tableLayoutPanel_0.ResumeLayout(false);
		this.tableLayoutPanel_0.PerformLayout();
		this.tabControl_0.ResumeLayout(false);
		this.tabPage_0.ResumeLayout(false);
		this.tabPage_1.ResumeLayout(false);
		((ISupportInitialize)this.dataGridView_1).EndInit();
		((ISupportInitialize)this.bindingSource_4).EndInit();
		((ISupportInitialize)this.dataSet_0).EndInit();
		((ISupportInitialize)this.dataTable_0).EndInit();
		this.tabPage_2.ResumeLayout(false);
		this.tabPage_2.PerformLayout();
		this.dataGridViewExcelFilter_0.EndInit();
		this.mhYmAyRpMln.ResumeLayout(false);
		this.mhYmAyRpMln.PerformLayout();
		this.contextMenuStrip_0.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	internal static void wTf0759tJG1skIPOgyyi(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private int int_0;

	private int int_1;

	private int int_2;

	[CompilerGenerated]
	private StateFormCreate stateFormCreate_0;

	[CompilerGenerated]
	private Enum4 enum4_0;

	private string string_0;

	internal Form7 form7_0;

	private int int_3;

	private BindingSource bindingSource_0;

	private IContainer MuimhWmsJeG;

	private TableLayoutPanel sRpmhjcafTn;

	private Label label_0;

	private Label aUamhyqUbcS;

	private Label label_1;

	private Button button_0;

	private Button button_1;

	private ComboBox comboBox_0;

	private TextBox arhmhfXsamx;

	private BindingSource bindingSource_1;

	private Class107 class107_0;

	private BindingSource bindingSource_2;

	private DataGridViewPassport WlYmhhmeTud;

	private Label label_2;

	private NullableDateTimePicker nullableDateTimePicker_0;

	private ToolStrip SaXmhDkoWpW;

	private ToolStripButton toolStripButton_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private ToolStripButton toolStripButton_3;

	private DataGridView dataGridView_0;

	private BindingSource bindingSource_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

	private ToolStripSeparator oSemuTsZeeO;

	private ToolStripButton toolStripButton_4;

	private ToolStripButton toolStripButton_5;

	private ToolStripButton toolStripButton_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

	private DataGridViewTextBoxColumn dZdmuJrqoc0;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_7;

	private DataGridViewTextBoxColumn KykmupDneZn;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_68;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_69;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_70;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_71;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_72;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_73;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_74;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_75;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_76;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_77;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_78;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_79;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_80;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_81;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_82;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private DataGridView dataGridView_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_83;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_84;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_85;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_86;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_87;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_88;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_89;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_90;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_91;

	private BindingSource bindingSource_4;

	private DataSet dataSet_0;

	private DataTable dataTable_0;

	private DataColumn dataColumn_0;

	private DataColumn dataColumn_1;

	private DataColumn dataColumn_2;

	private DataColumn dataColumn_3;

	private DataColumn dataColumn_4;

	private DataColumn dataColumn_5;

	private DataColumn dataColumn_6;

	private DataColumn dataColumn_7;

	private DataColumn dataColumn_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_92;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_93;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_94;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_95;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_96;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_97;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_98;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_99;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_100;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_101;

	private DataGridViewTextBoxColumn foomDmAjsXv;

	private DataGridViewTextBoxColumn XoxmDaTvfrW;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_102;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_103;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_104;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_105;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_106;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_107;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_108;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_109;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_110;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_111;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_112;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_113;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_114;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_115;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_116;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_117;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_118;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_119;

	private DataGridViewTextBoxColumn OaMmDjiXcZm;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_120;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_121;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_122;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_123;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_124;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_125;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_126;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_127;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_128;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_129;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_130;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_131;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_132;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_133;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_134;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_135;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_136;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_137;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_138;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_139;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_140;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_141;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_142;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_25;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_143;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_144;

	private Label label_3;

	private TextBox textBox_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_145;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_146;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_147;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_148;

	private DataGridViewTextBoxColumn grEmAmWmSlf;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_149;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_150;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_151;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_152;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_153;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_154;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_155;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_156;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_28;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_157;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_158;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_159;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_160;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_161;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_29;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_162;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_163;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_164;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_165;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_166;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_167;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_168;

	private TabPage tabPage_2;

	private ToolStrip mhYmAyRpMln;

	private DataGridViewExcelFilter dataGridViewExcelFilter_0;

	private ToolStripButton toolStripButton_7;

	private ToolStripButton toolStripButton_8;

	private ToolStripButton toolStripButton_9;

	private ToolStripSeparator toolStripSeparator_0;

	private ToolStripButton toolStripButton_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_169;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_170;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_171;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_31;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_172;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_173;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_174;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_175;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_176;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_32;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_177;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_178;

	private DataGridViewTextBoxColumn MrxmArpksbR;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_179;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_180;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_181;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_182;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_183;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_184;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_185;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_186;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_187;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_188;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_189;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_190;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_191;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_34;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_192;

	private DataGridViewTextBoxColumn HfemNmvmel1;

	private ContextMenuStrip contextMenuStrip_0;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_193;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_194;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_195;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_196;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_197;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_198;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_199;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_200;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_36;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_201;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_202;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_203;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_204;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_205;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_37;

	private DataGridViewTextBoxColumn sBnmNslbenp;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_206;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_207;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_208;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_209;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_38;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_210;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_211;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_212;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_213;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_214;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_39;

	private DataGridViewTextBoxColumn ImdmNpylFi1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_215;

	private TableLayoutPanel tableLayoutPanel_0;

	private ComboBox comboBox_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_216;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_217;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_218;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_40;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_219;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_220;
}
