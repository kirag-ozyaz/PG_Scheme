using System;
using System.Data;
using Constants;
using DataSql;
using Passport.DataSets;

internal static class Class110
{
	public static int smethod_0(SQLSettings sqlsettings_0, string string_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		DataRow dataRow = dsPassport.tLogInOut.NewRow();
		dataRow["DateIn"] = DateTime.Now;
		dataRow["Module"] = string_0;
		dsPassport.tLogInOut.Rows.Add(dataRow);
		return sqlDataCommand.InsertSqlDataOneRow(dsPassport.tLogInOut);
	}

	public static void smethod_1(SQLSettings sqlsettings_0, int int_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		sqlDataCommand.SelectSqlData(dsPassport.tLogInOut, true, "where id = " + int_0.ToString(), null, false, 0);
		if (dsPassport.tLogInOut.Rows.Count > 0)
		{
			dsPassport.tLogInOut.Rows[0]["DateOut"] = DateTime.Now;
			sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tLogInOut);
		}
	}

	public static void smethod_2(SQLSettings sqlsettings_0, int int_0, StateFormCreate stateFormCreate_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		sqlDataCommand.SelectSqlData(dsPassport.tLogInOut, true, "where id = " + int_0.ToString(), null, false, 0);
		string arg = "";
		switch (stateFormCreate_0)
		{
		case 0:
			arg = "Add";
			break;
		case 1:
			arg = "Edit";
			break;
		case 2:
			arg = "Delete";
			break;
		case 3:
			arg = "AddGruop";
			break;
		case 4:
			arg = "AddElement";
			break;
		case 5:
			arg = "EditGroup";
			break;
		case 6:
			arg = "EditElement";
			break;
		case 7:
			arg = "Show";
			break;
		case 8:
			arg = "Move";
			break;
		}
		if (dsPassport.tLogInOut.Rows.Count > 0)
		{
			DataRow dataRow = dsPassport.tLogInOut.Rows[0];
			if (dataRow["Comment"] == DBNull.Value)
			{
				dataRow["Comment"] = "";
			}
			DataRow dataRow2 = dataRow;
			dataRow2["Comment"] = dataRow2["Comment"] + string.Format("\r\n {0}: {1}", DateTime.Now, arg);
			sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tLogInOut);
		}
	}
}
