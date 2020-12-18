using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataSql;
using Passport.Classes;
using Passport.DataSets;
using Passport.Import;

internal class Class3
{
	public void method_0(SQLSettings sqlsettings_0, int int_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		string text = "SELECT idOldPassport FROM tP_Passport WHERE isActive = ((1)) AND Deleted = ((0)) AND idObjList = " + int_0.ToString();
		DataTable dataTable = sqlDataCommand.SelectSqlData(text);
		if (dataTable.Rows.Count == 0 && !(dataTable.Rows[0]["idOldPassport"] is int))
		{
			MessageBox.Show("Паспорт не найден", "Загрузка паспорта", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		this.method_2(sqlsettings_0, int_0, (int)dataTable.Rows[0]["idOldPassport"]);
	}

	public void method_1(SQLSettings sqlsettings_0, int int_0, string string_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		string text = "SELECT [Код] FROM [ULGES-SQL].[Kab].[dbo].[Паспорт Кабеля] WHERE [Имя] = '%" + string_0 + "%'";
		DataTable dataTable = sqlDataCommand.SelectSqlData(text);
		if (dataTable.Rows.Count == 0 && !(dataTable.Rows[0]["Код"] is int))
		{
			MessageBox.Show("Паспорт не найден", "Загрузка паспорта", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		this.method_2(sqlsettings_0, int_0, (int)dataTable.Rows[0]["idOldPassport"]);
	}

	public void method_2(SQLSettings sqlsettings_0, int int_0, int int_1)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		new dsPassport();
		sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		string text = string.Format("SELECT * FROM [ULGES-SQL].[Kab].[dbo].[Паспорт Кабеля] WHERE [Код] = {0} ", int_1);
		DataTable dataTable = sqlDataCommand.SelectSqlData(text);
		text = string.Format("SELECT * FROM [ULGES-SQL].[Kab].[dbo].[Муфты] WHERE [Муфта] IS NOT NULL AND [Код] = {0} ORDER BY UchN", int_1);
		DataTable dataTable2 = sqlDataCommand.SelectSqlData(text);
		if (dataTable.Rows.Count == 0)
		{
			return;
		}
		DataRow dataRow = dataTable.Rows[0];
		DateTime now = DateTime.Now;
		string string_ = "";
		string string_2 = (dataRow["Имя"] == DBNull.Value) ? "" : dataRow["Имя"].ToString();
		int int_2 = -1;
		string text2 = (dataRow["MontagUch"] == DBNull.Value) ? "" : dataRow["MontagUch"].ToString();
		int int_3 = (int)sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetIdValueList", new string[]
		{
			dataRow["Прин"].ToString()
		});
		string string_3 = "";
		int int_4 = (dataRow["ГП"] == DBNull.Value) ? 1900 : int.Parse(dataRow["ГП"].ToString());
		int int_5 = (dataRow["ГЭ"] == DBNull.Value) ? 1900 : int.Parse(dataRow["ГЭ"].ToString());
		int int_6 = 1900;
		decimal decimal_ = 0.0m;
		decimal decimal_2 = 0.0m;
		decimal decimal_3 = (dataRow["U"] == DBNull.Value) ? 0.0m : decimal.Parse(dataRow["U"].ToString());
		int int_7 = (int)sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetIdValueList", new string[]
		{
			dataRow["Zakazchik"].ToString()
		});
		int int_8 = (int)sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetIdValueList", new string[]
		{
			dataRow["MontagTrest"].ToString()
		});
		int int_9 = (int)sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetIdValueList", new string[]
		{
			dataRow["MontagSMU"].ToString()
		});
		int int_10 = -1;
		int int_11 = -1;
		int num = SchmObj.smethod_0(sqlsettings_0, int_0);
		if (num == -1)
		{
			num = this.method_4(int_1, sqlsettings_0, int_0, now, string_, string_2, int_2, text2, int_3, string_3, int_4, int_5, int_6, decimal_, decimal_2, decimal_3, int_7, int_8, int_9, int_10, int_11);
		}
		else
		{
			num = this.method_3(int_1, sqlsettings_0, int_0, now, string_, string_2, int_2, text2, int_3, string_3, int_4, int_5, int_6, decimal_, decimal_2, decimal_3, int_7, int_8, int_9, int_10, int_11);
		}
		if (dataTable2.Rows.Count > 0)
		{
			int num2 = Clutch.GetIdFromName(sqlsettings_0, int_0, "01", TypeClutch.End);
			if (num2 == -1)
			{
				num2 = this.method_6(sqlsettings_0, "01", int_0);
			}
			int int_12 = num2;
			for (int i = 1; i < dataTable2.Rows.Count; i++)
			{
				try
				{
					int int_13 = (int)sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetIdValueList", new string[]
					{
						dataTable2.Rows[i]["KMarka"].ToString()
					});
					decimal decimal_4 = 0.0m;
					decimal.TryParse(dataTable2.Rows[i]["UNom"].ToString(), out decimal_4);
					int int_14 = 0;
					int.TryParse(dataTable2.Rows[i]["KSech1"].ToString(), out int_14);
					decimal decimal_5 = 0.0m;
					decimal.TryParse(dataTable2.Rows[i]["KSech2"].ToString(), out decimal_5);
					decimal decimal_6 = 0.0m;
					decimal.TryParse(dataTable2.Rows[i]["ДВ"].ToString(), out decimal_6);
					string string_4 = dataTable2.Rows[i]["KUsl"].ToString();
					int int_15 = 0;
					int.TryParse(dataTable2.Rows[i]["KKol"].ToString(), out int_15);
					DateTime dateTime_ = new DateTime(1900, 1, 1);
					if (DateTime.TryParse(dataTable2.Rows[i]["KData"].ToString(), out dateTime_))
					{
						int year = dateTime_.Year;
					}
					string string_5 = dataTable2.Rows[i]["KUslPr"].ToString();
					int int_16 = Class109.smethod_16(sqlsettings_0, string_4);
					if (i + 1 < dataTable2.Rows.Count)
					{
						int int_17 = int.Parse(dataTable2.Rows[i]["ID"].ToString());
						string string_6 = dataTable2.Rows[i]["Муфта"].ToString();
						DateTime now2 = DateTime.Now;
						int.Parse(dataTable2.Rows[i]["UchN"].ToString());
						int int_18 = (int)sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetIdValueList", new string[]
						{
							dataTable2.Rows[i]["Тип"].ToString()
						});
						string string_7 = dataTable2.Rows[i]["Дом"].ToString();
						string string_8 = dataTable2.Rows[i]["Улица"].ToString();
						DateTime dateTime_2 = DateTime.Parse("1900-01-01 00:00:01");
						DateTime.TryParse(dataTable2.Rows[i]["ДатаМ"].ToString(), out dateTime_2);
						decimal decimal_7 = 0.0m;
						decimal.TryParse(dataTable2.Rows[i]["ГЗ"].ToString(), out decimal_7);
						string string_9 = dataTable2.Rows[i]["МКМ"].ToString();
						string string_10 = dataTable2.Rows[i]["MestoKVTP"].ToString();
						string string_11 = dataTable2.Rows[i]["ФИО1"].ToString();
						string string_12 = dataTable2.Rows[i]["ФИО2"].ToString();
						int num3 = this.method_5(sqlsettings_0, int_17, int_0, dataTable2, num, string_6, now, text2, int_18, -1, string_7, string_8, -1, dateTime_2, decimal_7, string_9, string_10, string_11, string_12);
						this.method_13(sqlsettings_0, int_0, int_12, num3, i, int_13, decimal_4, int_14, decimal_5, decimal_6, int_16, int_15, dateTime_, string_5, false);
						int_12 = num3;
					}
					else
					{
						int num4 = Clutch.GetIdFromName(sqlsettings_0, int_0, "02", TypeClutch.End);
						if (num4 == -1)
						{
							num4 = this.method_6(sqlsettings_0, "02", int_0);
						}
						this.method_13(sqlsettings_0, int_0, int_12, num4, i, int_13, decimal_4, int_14, decimal_5, decimal_6, int_16, int_15, dateTime_, string_5, false);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}
		MessageBox.Show("Данные успешно добавлены.", "Загрузка из старой базы.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	public int method_3(int int_0, SQLSettings sqlsettings_0, int int_1, DateTime dateTime_0, string string_0, string string_1, int int_2, string string_2, int int_3, string string_3, int int_4, int int_5, int int_6, decimal decimal_0, decimal decimal_1, decimal decimal_2, int int_7, int int_8, int int_9, int int_10, int int_11)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		SchmObj.smethod_0(sqlsettings_0, int_1);
		int num = this.method_10(sqlsettings_0, int_1, dateTime_0, true, false, int_0);
		if (num <= 0)
		{
			throw new Exception("Inserting passport cable aborted");
		}
		sqlDataCommand.SelectSqlData(dsPassport.tSchm_ObjList, true, "WHERE id = " + int_1.ToString(), null, false, 0);
		dsPassport.tSchm_ObjList.Rows[0]["Name"] = string_1;
		sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tSchm_ObjList);
		Class3.smethod_1(sqlsettings_0, num, new List<Parameter>
		{
			new Parameter(141, string_0),
			new Parameter(51, int_2.ToString()),
			new Parameter(140, string_2.ToString()),
			new Parameter(53, int_3.ToString()),
			new Parameter(54, string_3),
			new Parameter(52, int_4.ToString()),
			new Parameter(55, int_5.ToString()),
			new Parameter(56, int_6.ToString()),
			new Parameter(57, decimal_0.ToString()),
			new Parameter(58, decimal_1.ToString()),
			new Parameter(59, decimal_2.ToString()),
			new Parameter(49, int_7.ToString()),
			new Parameter(138, int_8.ToString()),
			new Parameter(139, int_9.ToString()),
			new Parameter(142, int_10.ToString()),
			new Parameter(143, int_11.ToString())
		}, false);
		return num;
	}

	public int method_4(int int_0, SQLSettings sqlsettings_0, int int_1, DateTime dateTime_0, string string_0, string string_1, int int_2, string string_2, int int_3, string string_3, int int_4, int int_5, int int_6, decimal decimal_0, decimal decimal_1, decimal decimal_2, int int_7, int int_8, int int_9, int int_10, int int_11)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		int num = this.method_10(sqlsettings_0, int_1, dateTime_0, true, false, int_0);
		if (num <= 0)
		{
			throw new Exception("Inserting passport cable aborted");
		}
		sqlDataCommand.SelectSqlData(dsPassport.tSchm_ObjList, true, "WHERE id = " + int_1.ToString(), null, false, 0);
		dsPassport.tSchm_ObjList.Rows[0]["Name"] = string_1;
		sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tSchm_ObjList);
		Class3.smethod_0(sqlsettings_0, num, new List<Parameter>
		{
			new Parameter(141, string_0),
			new Parameter(51, int_2.ToString()),
			new Parameter(140, string_2.ToString()),
			new Parameter(53, int_3.ToString()),
			new Parameter(54, string_3),
			new Parameter(52, int_4.ToString()),
			new Parameter(55, int_5.ToString()),
			new Parameter(56, int_6.ToString()),
			new Parameter(57, decimal_0.ToString()),
			new Parameter(58, decimal_1.ToString()),
			new Parameter(59, decimal_2.ToString()),
			new Parameter(49, int_7.ToString()),
			new Parameter(138, int_8.ToString()),
			new Parameter(139, int_9.ToString()),
			new Parameter(142, int_10.ToString()),
			new Parameter(143, int_11.ToString())
		}, false);
		return num;
	}

	public int method_5(SQLSettings sqlsettings_0, int int_0, int int_1, DataTable dataTable_0, int int_2, string string_0, DateTime dateTime_0, string string_1, int int_3, int int_4, string string_2, string string_3, int int_5, DateTime dateTime_1, decimal decimal_0, string string_4, string string_5, string string_6, string string_7)
	{
		int num = Clutch.GetIdFromName(sqlsettings_0, int_1, string_0, TypeClutch.Connective);
		if (num == -1)
		{
			num = this.method_7(sqlsettings_0, string_0, int_1, dataTable_0);
		}
		if (num <= 0)
		{
			throw new Exception("Inserting clutch is aborted.");
		}
		int num2 = SchmObj.smethod_0(sqlsettings_0, num);
		if (num2 == -1)
		{
			num2 = this.method_12(sqlsettings_0, num, int_1, dateTime_0, true, false, int_0);
			if (num2 <= 0)
			{
				throw new Exception("Inserting passport clutch is aborted.");
			}
			List<Parameter> list = new List<Parameter>();
			list.Add(new Parameter(35, string_1.ToString()));
			list.Add(new Parameter(36, int_3.ToString()));
			list.Add(new Parameter(145, int_4.ToString()));
			list.Add(new Parameter(177, string_2.ToString()));
			list.Add(new Parameter(178, string_3.ToString()));
			list.Add(new Parameter(38, int_5.ToString()));
			if (dateTime_1 > new DateTime(1900, 1, 1))
			{
				list.Add(new Parameter(37, dateTime_1.ToString()));
			}
			list.Add(new Parameter(40, decimal_0.ToString()));
			list.Add(new Parameter(41, string_4.ToString()));
			list.Add(new Parameter(144, string_5.ToString()));
			list.Add(new Parameter(42, string_6.ToString()));
			list.Add(new Parameter(43, string_7.ToString()));
			Class3.smethod_0(sqlsettings_0, num2, list, false);
		}
		return num;
	}

	public int method_6(SQLSettings sqlsettings_0, string string_0, int int_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		dsPassport.Class49 @class = dsPassport.tSchm_ObjList.method_5();
		@class.Name = string_0;
		@class.TypeCodeId = 926;
		@class.IdParent = int_0;
		@class.method_5(false);
		@class.idParentAddl = int_0;
		dsPassport.tSchm_ObjList.method_0(@class);
		return sqlDataCommand.InsertSqlDataOneRow(dsPassport.tSchm_ObjList);
	}

	private int method_7(SQLSettings sqlsettings_0, string string_0, int int_0, DataTable dataTable_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		dsPassport.tSchm_ObjList.Rows.Clear();
		dsPassport.Class49 @class = dsPassport.tSchm_ObjList.method_5();
		@class.Name = this.method_8(sqlsettings_0, int_0, string_0, dataTable_0);
		@class.TypeCodeId = 612;
		@class.IdParent = int_0;
		@class.method_5(false);
		@class.idParentAddl = int_0;
		dsPassport.tSchm_ObjList.method_0(@class);
		return sqlDataCommand.InsertSqlDataOneRow(dsPassport.tSchm_ObjList);
	}

	private string method_8(SQLSettings sqlsettings_0, int int_0, string string_0, DataTable dataTable_0)
	{
		string text = "";
		int num = dataTable_0.Select("Муфта = '" + string_0 + "'").Count<DataRow>();
		if (num == 1)
		{
			return string_0;
		}
		if (num == 0)
		{
			throw new Exception("Не найдена муфта");
		}
		for (int i = 1; i < num + 1; i++)
		{
			text = string_0 + "/" + i.ToString();
			if (!this.method_9(sqlsettings_0, int_0, text))
			{
				return text;
			}
		}
		return text;
	}

	private bool method_9(SQLSettings sqlsettings_0, int int_0, string string_0)
	{
		return (int)new SqlDataCommand(sqlsettings_0).CallSQLScalarFunction("dbo.fn_P_ExistsNameClutch", new string[]
		{
			int_0.ToString(),
			string_0
		}) > 0;
	}

	private int method_10(SQLSettings sqlsettings_0, int int_0, DateTime dateTime_0, bool bool_0, bool bool_1, int int_1)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		dsPassport.Class62 @class = dsPassport.tP_Passport.method_5();
		@class.idObjList = int_0;
		@class.idEquipment = -1;
		@class.Number = 0;
		@class.Date = dateTime_0;
		@class.DateIn = DateTime.Now;
		@class.isActive = bool_0;
		@class.Deleted = bool_1;
		@class.idOldPassport = int_1;
		dsPassport.tP_Passport.method_0(@class);
		return sqlDataCommand.InsertSqlDataOneRow(dsPassport.tP_Passport);
	}

	private bool method_11(SQLSettings sqlsettings_0, int int_0, int int_1)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		sqlDataCommand.SelectSqlData(dsPassport.tP_Passport, true, "WHERE id = " + int_0.ToString(), null, false, 0);
		if (dsPassport.tP_Passport.Rows.Count == 0)
		{
			return false;
		}
		dsPassport.tP_Passport.Rows[0]["idOldPassport"] = int_1;
		return sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_Passport);
	}

	private int method_12(SQLSettings sqlsettings_0, int int_0, int int_1, DateTime dateTime_0, bool bool_0, bool bool_1, int int_2)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		dsPassport.Class62 @class = dsPassport.tP_Passport.method_5();
		@class.idObjList = int_0;
		@class.ParentId = int_1;
		@class.idEquipment = -1;
		@class.Number = 0;
		@class.Date = dateTime_0;
		@class.DateIn = DateTime.Now;
		@class.isActive = bool_0;
		@class.Deleted = bool_1;
		@class.idOldPassport = int_2;
		dsPassport.tP_Passport.method_0(@class);
		return sqlDataCommand.InsertSqlDataOneRow(dsPassport.tP_Passport);
	}

	private static bool smethod_0(SQLSettings sqlsettings_0, int int_0, List<Parameter> list_0, bool bool_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		foreach (Parameter parameter in list_0)
		{
			dsPassport.Class13 @class = dsPassport.tP_ObjectChar.method_5();
			@class.idPassport = int_0;
			@class.idObjChar = parameter.IdParameter;
			@class.Value = parameter.Value;
			@class.Deleted = bool_0;
			dsPassport.tP_ObjectChar.method_0(@class);
		}
		return sqlDataCommand.InsertSqlData(dsPassport, dsPassport.tP_ObjectChar);
	}

	private static bool smethod_1(SQLSettings sqlsettings_0, int int_0, List<Parameter> list_0, bool bool_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		bool flag = false;
		foreach (Parameter parameter in list_0)
		{
			sqlDataCommand.SelectSqlData(dsPassport.tP_ObjectChar, true, string.Format("WHERE idPassport = {0} AND idObjChar = {1} AND Deleted = ((0))", int_0, parameter.IdParameter), null, false, 0);
			if (dsPassport.tP_ObjectChar.Rows.Count != 0)
			{
				dsPassport.tP_ObjectChar.Rows[0]["Value"] = parameter.Value;
				if (!flag)
				{
					flag = sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_ObjectChar);
				}
				else
				{
					sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_ObjectChar);
				}
			}
			else
			{
				dsPassport.Class13 @class = dsPassport.tP_ObjectChar.method_5();
				@class.idPassport = int_0;
				@class.idObjChar = parameter.IdParameter;
				@class.Value = parameter.Value;
				@class.Deleted = bool_0;
				dsPassport.tP_ObjectChar.method_0(@class);
			}
		}
		if (!flag)
		{
			flag = sqlDataCommand.InsertSqlData(dsPassport, dsPassport.tP_ObjectChar);
		}
		else
		{
			sqlDataCommand.InsertSqlData(dsPassport, dsPassport.tP_ObjectChar);
		}
		return flag;
	}

	public int method_13(SQLSettings sqlsettings_0, int int_0, int int_1, int int_2, int int_3, int int_4, decimal decimal_0, int int_5, decimal decimal_1, decimal decimal_2, int int_6, int int_7, DateTime dateTime_0, string string_0, bool bool_0)
	{
		int num = Class109.smethod_15(sqlsettings_0, int_0, int_1, int_2);
		if (num == -1)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
			dsPassport dsPassport = new dsPassport();
			dsPassport.tP_CabSection.Clear();
			dsPassport.Class58 @class = dsPassport.tP_CabSection.method_5();
			@class.idObjList = int_0;
			@class.idClutchFirst = int_1;
			@class.idClutchSecond = int_2;
			@class.Number = int_3.ToString();
			@class.CableMakeup = int_4;
			@class.Voltage = decimal_0;
			@class.Wires = int_5;
			@class.CrossSection = decimal_1;
			@class.Length = decimal_2;
			@class.Conditions = int_6;
			@class.Count = int_7;
			if (dateTime_0 > new DateTime(1901, 1, 1))
			{
				@class.YearLaying = dateTime_0;
			}
			@class.Comment = string_0;
			@class.Deleted = bool_0;
			dsPassport.tP_CabSection.method_0(@class);
			num = sqlDataCommand.InsertSqlDataOneRow(dsPassport.tP_CabSection);
		}
		return num;
	}
}
