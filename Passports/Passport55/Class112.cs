using System;
using System.Data;
using DataSql;
using Passport.Classes;
using Passport.DataSets;

internal static class Class112
{
	public static bool smethod_0(SQLSettings sqlsettings_0, int int_0, dsPassport.Class57 class57_0)
	{
		new SqlDataCommand(sqlsettings_0);
		return Class112.smethod_4(sqlsettings_0, int_0, class57_0.method_4(), class57_0.method_6(), class57_0.method_8(), UlgesPassportTypeDoc.Balance);
	}

	public static bool smethod_1(SQLSettings sqlsettings_0, int int_0, dsPassport.Class56 class56_0)
	{
		new SqlDataCommand(sqlsettings_0);
		return Class112.smethod_4(sqlsettings_0, int_0, "", class56_0.method_4(), class56_0.method_6(), UlgesPassportTypeDoc.Remont);
	}

	public static DataTable smethod_2(SQLSettings sqlsettings_0)
	{
		return new SqlDataCommand(sqlsettings_0).SelectSqlData("vP_SubstationByNetRegion", true, "ORDER BY SocrName, Name", null);
	}

	public static DataTable smethod_3(SQLSettings sqlsettings_0, int int_0)
	{
		return new SqlDataCommand(sqlsettings_0).SelectSqlData("vP_SubstationByNetRegion", true, string.Format("WHERE idNetRegion = {0} ORDER BY SocrName, Name", int_0), null);
	}

	private static bool smethod_4(SQLSettings sqlsettings_0, int int_0, string string_0, DateTime dateTime_0, string string_1, UlgesPassportTypeDoc ulgesPassportTypeDoc_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		dsPassport.Class53 @class = dsPassport.tP_DocList.method_5();
		@class.method_1(-1);
		@class.method_3(int_0);
		@class.method_5(dateTime_0);
		@class.method_7(string_0);
		@class.Comment = string_1;
		@class.method_11((int)ulgesPassportTypeDoc_0);
		@class.method_13(true);
		@class.method_15(false);
		dsPassport.tP_DocList.method_0(@class);
		return sqlDataCommand.InsertSqlData(dsPassport, dsPassport.tP_DocList);
	}
}
