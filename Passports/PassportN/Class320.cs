using System;
using System.Data;
using DataSql;
using Passport.Classes;

internal static class Class320
{
	public static bool smethod_0(SQLSettings sqlsettings_0, int int_0, Class107.Class252 class252_0)
	{
		new SqlDataCommand(sqlsettings_0);
		return Class320.smethod_4(sqlsettings_0, int_0, class252_0.PRIKAZ_N, class252_0.PRIKAZ_DATE, class252_0.FIRMA, UlgesPassportTypeDoc.Balance);
	}

	public static bool smethod_1(SQLSettings sqlsettings_0, int int_0, Class107.Class251 class251_0)
	{
		new SqlDataCommand(sqlsettings_0);
		return Class320.smethod_4(sqlsettings_0, int_0, "", class251_0.DATE, class251_0.RABOTA, UlgesPassportTypeDoc.Remont);
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
		Class107 @class = new Class107();
		Class107.Class248 class2 = @class.tP_DocList.method_5();
		class2.ParentId = -1;
		class2.idObjList = int_0;
		class2.DateDoc = dateTime_0;
		class2.NumberDoc = string_0;
		class2.Comment = string_1;
		class2.TypeDoc = (int)ulgesPassportTypeDoc_0;
		class2.isActive = true;
		class2.Deleted = false;
		@class.tP_DocList.method_0(class2);
		return sqlDataCommand.InsertSqlData(@class, @class.tP_DocList);
	}
}
