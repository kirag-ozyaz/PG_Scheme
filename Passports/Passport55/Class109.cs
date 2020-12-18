using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataSql;
using Passport.Classes;
using Passport.DataSets;

internal static class Class109
{
	internal static DataTable smethod_0(SQLSettings sqlsettings_0, int int_0)
	{
		return new SqlDataCommand(sqlsettings_0).SelectSqlData("vP_CabSections", true, "WHERE idObjList = " + int_0.ToString() + " AND Deleted = ((0)) ORDER BY Number", null);
	}

	internal static int smethod_1(SQLSettings sqlsettings_0, dsPassport.Class58 class58_0, int int_0, int int_1, int int_2)
	{
		dsPassport dsPassport = new dsPassport();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		class58_0.idClutchFirst = int_1;
		class58_0.idClutchSecond = int_2;
		class58_0.idObjList = int_0;
		dsPassport.tP_CabSection.method_0(class58_0);
		return sqlDataCommand.InsertSqlDataOneRow(dsPassport.tP_CabSection);
	}

	internal static bool smethod_2(SQLSettings sqlsettings_0, int int_0, int int_1, decimal decimal_0, decimal decimal_1)
	{
		dsPassport dsPassport = new dsPassport();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		sqlDataCommand.SelectSqlData(dsPassport.tP_CabSection, true, string.Format(" WHERE id = {0} AND Deleted = ((0))", int_0), null, false, 0);
		if (dsPassport.tP_CabSection.Rows.Count < 1)
		{
			return false;
		}
		DataRow dataRow = dsPassport.tP_CabSection.Rows[0];
		DataRow dataRow2 = Class109.smethod_14(dsPassport.tP_CabSection, dataRow);
		dataRow["idClutchSecond"] = int_1;
		dataRow["Length"] = decimal_0;
		dataRow2["idClutchFirst"] = int_1;
		dataRow2["Length"] = decimal_1;
		dataRow2["Id"] = -1;
		dataRow2["Number"] = int.Parse(dataRow["Number"].ToString()) + 1;
		dsPassport.tP_CabSection.Rows.Add(dataRow2);
		sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_CabSection);
		return sqlDataCommand.InsertSqlData(dsPassport, dsPassport.tP_CabSection);
	}

	internal static bool smethod_3(SQLSettings sqlsettings_0, int int_0, DataRow dataRow_0, int int_1, int int_2, decimal decimal_0, decimal decimal_1)
	{
		dsPassport dsPassport = new dsPassport();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		sqlDataCommand.SelectSqlData(dsPassport.tP_CabSection, true, string.Format(" WHERE id = {0} AND Deleted = ((0))", int_0), null, false, 0);
		if (dsPassport.tP_CabSection.Rows.Count < 1)
		{
			return false;
		}
		DataRow dataRow = dsPassport.tP_CabSection.Rows[0];
		DataRow dataRow2 = Class109.smethod_14(dsPassport.tP_CabSection, dataRow);
		dataRow["idClutchSecond"] = int_1;
		dataRow["Length"] = decimal_0;
		dataRow_0["idClutchFirst"] = int_1;
		dataRow_0["idClutchSecond"] = int_2;
		dataRow2["idClutchFirst"] = int_2;
		dataRow2["Length"] = decimal_1;
		dataRow2["Id"] = -2;
		dataRow2["Number"] = int.Parse(dataRow["Number"].ToString()) + 1;
		sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_CabSection);
		dsPassport.tP_CabSection.Rows.Add(Class109.smethod_14(dsPassport.tP_CabSection, dataRow_0));
		dsPassport.tP_CabSection.Rows.Add(dataRow2);
		return sqlDataCommand.InsertSqlData(dsPassport, dsPassport.tP_CabSection);
	}

	public static string smethod_4(SQLSettings sqlsettings_0, int int_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		string result = "";
		try
		{
			return sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetFullCabSectionMakeupName", new string[]
			{
				int_0.ToString()
			}).ToString();
		}
		catch (Exception)
		{
		}
		return result;
	}

	internal static bool smethod_5(SQLSettings sqlsettings_0, int int_0, dsPassport.Class58 class58_0, int int_1)
	{
		dsPassport dsPassport = new dsPassport();
		dsPassport.Class58 @class = dsPassport.tP_CabSection.method_5();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		sqlDataCommand.SelectSqlData(dsPassport.tP_CabSection, true, string.Format(" WHERE id = {0} AND Deleted = ((0))", int_0), null, false, 0);
		if (dsPassport.tP_CabSection.Rows.Count < 1)
		{
			return false;
		}
		dsPassport.Class58 class2 = (dsPassport.Class58)dsPassport.tP_CabSection.Rows[0];
		class58_0.idClutchFirst = class2.idClutchSecond;
		class58_0.idClutchSecond = int_1;
		@class.idClutchFirst = int_1;
		dsPassport.tP_CabSection.method_0(class58_0);
		dsPassport.tP_CabSection.method_0(@class);
		sqlDataCommand.InsertSqlData(dsPassport, dsPassport.tP_CabSection);
		sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_CabSection);
		return true;
	}

	internal static bool smethod_6(SQLSettings sqlsettings_0, int[] int_0, dsPassport.Class58 class58_0)
	{
		dsPassport dsPassport = new dsPassport();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		string arg = Class109.smethod_7(int_0, ",");
		sqlDataCommand.SelectSqlData(dsPassport.tP_CabSection, true, string.Format(" WHERE id IN ({0}) AND Deleted = ((0))", arg), null, false, 0);
		if (dsPassport.tP_CabSection.Rows.Count < 1)
		{
			return false;
		}
		IEnumerable<dsPassport.Class58> enumerable = dsPassport.tP_CabSection.Rows.Cast<dsPassport.Class58>();
		foreach (dsPassport.Class58 @class in enumerable)
		{
			@class.Deleted = true;
		}
		class58_0.idClutchFirst = enumerable.First<dsPassport.Class58>().idClutchFirst;
		class58_0.idClutchSecond = enumerable.Last<dsPassport.Class58>().idClutchSecond;
		dsPassport.tP_CabSection.method_0(class58_0);
		sqlDataCommand.InsertSqlData(dsPassport, dsPassport.tP_CabSection);
		sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_CabSection);
		return true;
	}

	internal static string smethod_7(int[] int_0, string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_0.Length; i++)
		{
			stringBuilder.Append((i == 0) ? int_0[0].ToString() : (string_0 + int_0[i].ToString()));
		}
		return stringBuilder.ToString();
	}

	internal static bool smethod_8(SQLSettings sqlsettings_0, int[] int_0, dsPassport.Class58 class58_0, LocationClutch locationClutch_0, int int_1)
	{
		dsPassport dsPassport = new dsPassport();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		string arg = string.Join(", ", int_0.Cast<string>().ToArray<string>());
		sqlDataCommand.SelectSqlData(dsPassport.tP_CabSection, true, string.Format(" WHERE id IN ({0}) AND Deleted = ((0))", arg), null, false, 0);
		if (dsPassport.tP_CabSection.Rows.Count < 1)
		{
			return false;
		}
		IEnumerable<dsPassport.Class58> enumerable = dsPassport.tP_CabSection.Rows.Cast<dsPassport.Class58>();
		foreach (dsPassport.Class58 @class in enumerable)
		{
			@class.Deleted = true;
		}
		if (locationClutch_0 != LocationClutch.Next)
		{
			if (locationClutch_0 != LocationClutch.Previous)
			{
				return false;
			}
			Class109.smethod_11(sqlsettings_0, enumerable.First<dsPassport.Class58>().idObjList, SectionClutch.Second, enumerable.Last<dsPassport.Class58>().idClutchFirst, int_1);
			class58_0.idClutchFirst = int_1;
			class58_0.idClutchSecond = enumerable.Last<dsPassport.Class58>().idClutchSecond;
		}
		else
		{
			Class109.smethod_11(sqlsettings_0, enumerable.First<dsPassport.Class58>().idObjList, SectionClutch.First, enumerable.First<dsPassport.Class58>().idClutchSecond, int_1);
			class58_0.idClutchFirst = enumerable.First<dsPassport.Class58>().idClutchFirst;
			class58_0.idClutchSecond = int_1;
		}
		dsPassport.tP_CabSection.method_0(class58_0);
		sqlDataCommand.InsertSqlData(dsPassport, dsPassport.tP_CabSection);
		sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_CabSection);
		return true;
	}

	internal static bool smethod_9(SQLSettings sqlsettings_0, int[] int_0, dsPassport.Class58 class58_0, LocationClutch locationClutch_0, int int_1, int int_2)
	{
		dsPassport dsPassport = new dsPassport();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		string arg = string.Join(", ", int_0.Cast<string>().ToArray<string>());
		sqlDataCommand.SelectSqlData(dsPassport.tP_CabSection, true, string.Format(" WHERE id IN ({0}) AND Deleted = ((0))", arg), null, false, 0);
		if (dsPassport.tP_CabSection.Rows.Count < 1)
		{
			return false;
		}
		IEnumerable<dsPassport.Class58> enumerable = dsPassport.tP_CabSection.Rows.Cast<dsPassport.Class58>();
		foreach (dsPassport.Class58 @class in enumerable)
		{
			@class.Deleted = true;
		}
		Class109.smethod_11(sqlsettings_0, enumerable.First<dsPassport.Class58>().idObjList, SectionClutch.Second, enumerable.First<dsPassport.Class58>().idClutchFirst, int_1);
		Class109.smethod_11(sqlsettings_0, enumerable.First<dsPassport.Class58>().idObjList, SectionClutch.First, enumerable.Last<dsPassport.Class58>().idClutchSecond, int_2);
		class58_0.idClutchFirst = int_1;
		class58_0.idClutchSecond = int_2;
		dsPassport.tP_CabSection.method_0(class58_0);
		sqlDataCommand.InsertSqlData(dsPassport, dsPassport.tP_CabSection);
		sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_CabSection);
		return true;
	}

	internal static bool smethod_10(SQLSettings sqlsettings_0, int int_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		sqlDataCommand.SelectSqlData(dsPassport.tP_CabSection, true, string.Format(" WHERE id = {0}", int_0), null, false, 0);
		if (dsPassport.tP_CabSection.Rows.Count == 0)
		{
			throw new Exception("CableSection.Delete: Cable section is not found");
		}
		dsPassport.tP_CabSection.Rows[0]["Deleted"] = true;
		return sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_CabSection);
	}

	internal static bool smethod_11(SQLSettings sqlsettings_0, int int_0, SectionClutch sectionClutch_0, int int_1, int int_2)
	{
		dsPassport dsPassport = new dsPassport();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		string text;
		if (sectionClutch_0 != SectionClutch.First)
		{
			if (sectionClutch_0 != SectionClutch.Second)
			{
				return false;
			}
			text = string.Format(" WHERE idObjList = {0} AND idClutchSecond = {1} AND Deleted = ((0))", int_0, int_1);
		}
		else
		{
			text = string.Format(" WHERE idObjList = {0} AND idClutchFirst = {1} AND Deleted = ((0))", int_0, int_1);
		}
		sqlDataCommand.SelectSqlData(dsPassport.tP_CabSection, true, text, null, false, 0);
		if (dsPassport.tP_CabSection.Rows.Count != 1)
		{
			return false;
		}
		dsPassport.Class58 @class = (dsPassport.Class58)dsPassport.tP_CabSection.Rows[0];
		if (sectionClutch_0 != SectionClutch.First)
		{
			if (sectionClutch_0 == SectionClutch.Second)
			{
				@class.idClutchSecond = int_2;
			}
		}
		else
		{
			@class.idClutchFirst = int_2;
		}
		return sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_CabSection);
	}

	internal static bool smethod_12(SQLSettings sqlsettings_0, int[] int_0, LocationClutch locationClutch_0)
	{
		dsPassport dsPassport = new dsPassport();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		string arg = string.Join(", ", int_0.Cast<string>().ToArray<string>());
		sqlDataCommand.SelectSqlData(dsPassport.tP_CabSection, true, string.Format(" WHERE id IN ({0}) AND Deleted = ((0))", arg), null, false, 0);
		if (dsPassport.tP_CabSection.Rows.Count < 1)
		{
			return false;
		}
		IEnumerable<dsPassport.Class58> enumerable = dsPassport.tP_CabSection.Rows.Cast<dsPassport.Class58>();
		foreach (dsPassport.Class58 @class in enumerable)
		{
			@class.Deleted = true;
		}
		if (locationClutch_0 != LocationClutch.Next)
		{
			if (locationClutch_0 != LocationClutch.Previous)
			{
				return false;
			}
			int idClutch = enumerable.First<dsPassport.Class58>().idClutchFirst;
			int num = enumerable.Last<dsPassport.Class58>().idClutchSecond;
			sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_CabSection);
			sqlDataCommand.SelectSqlData(dsPassport.tP_CabSection, true, "WHERE idClutchSecond = {0} AND Deleted = ((0))" + idClutch.ToString(), null, false, 0);
			if (dsPassport.tP_CabSection.Rows.Count != 1)
			{
				throw new Exception("DeleteWithClutch: number of found rows is not equal to 1");
			}
			dsPassport.tP_CabSection.Rows[0]["idClutchSecond"] = num;
			Clutch.Delete(sqlsettings_0, idClutch);
		}
		else
		{
			int num = enumerable.First<dsPassport.Class58>().idClutchFirst;
			int idClutch = enumerable.Last<dsPassport.Class58>().idClutchSecond;
			sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_CabSection);
			sqlDataCommand.SelectSqlData(dsPassport.tP_CabSection, true, "WHERE idClutchFirst = {0} AND Deleted = ((0))" + idClutch.ToString(), null, false, 0);
			if (dsPassport.tP_CabSection.Rows.Count != 1)
			{
				throw new Exception("DeleteWithClutch: number of found rows is not equal to 1");
			}
			dsPassport.tP_CabSection.Rows[0]["idClutchFirst"] = num;
			Clutch.Delete(sqlsettings_0, idClutch);
		}
		sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_CabSection);
		return true;
	}

	internal static bool smethod_13(SQLSettings sqlsettings_0, int[] int_0, int int_1)
	{
		dsPassport dsPassport = new dsPassport();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		string arg = string.Join(", ", int_0.Cast<string>().ToArray<string>());
		sqlDataCommand.SelectSqlData(dsPassport.tP_CabSection, true, string.Format(" WHERE id IN ({0}) AND Deleted = ((0))", arg), null, false, 0);
		if (dsPassport.tP_CabSection.Rows.Count < 1)
		{
			return false;
		}
		IEnumerable<dsPassport.Class58> enumerable = dsPassport.tP_CabSection.Rows.Cast<dsPassport.Class58>();
		foreach (dsPassport.Class58 @class in enumerable)
		{
			@class.Deleted = true;
		}
		int idObjList = enumerable.First<dsPassport.Class58>().idObjList;
		int idClutchFirst = enumerable.First<dsPassport.Class58>().idClutchFirst;
		int idClutchSecond = enumerable.Last<dsPassport.Class58>().idClutchSecond;
		return true;
	}

	internal static DataRow smethod_14(DataTable dataTable_0, DataRow dataRow_0)
	{
		DataRow dataRow = dataTable_0.NewRow();
		dataRow.ItemArray = (dataRow_0.ItemArray.Clone() as object[]);
		return dataRow;
	}

	public static int smethod_15(SQLSettings sqlsettings_0, int int_0, int int_1, int int_2)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		int result = -1;
		string text = string.Format("SELECT * FROM tP_CabSection WHERE idObjList = {0} AND idClutchFirst = {1} AND idClutchSecond = {2}", int_0, int_1, int_2);
		DataTable dataTable = sqlDataCommand.SelectSqlData(text);
		if (dataTable.Rows.Count > 0 && int.TryParse(dataTable.Rows[0]["id"].ToString(), out result))
		{
			return result;
		}
		return -1;
	}

	public static int smethod_16(SQLSettings sqlsettings_0, string string_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		int result = -1;
		string text = string.Format("SELECT id FROM tP_Valuelists WHERE ParentKey = ';Param;CableSection;Laying;' AND Name = '{0}'", string_0);
		DataTable dataTable = sqlDataCommand.SelectSqlData(text);
		if (dataTable.Rows.Count > 0 && int.TryParse(dataTable.Rows[0]["id"].ToString(), out result))
		{
			return result;
		}
		return -1;
	}
}
