using System;
using System.Data;
using System.Linq;
using DataSql;

internal class Class322
{
	public SQLSettings method_0()
	{
		return this.sqlsettings_0;
	}

	public void method_1(SQLSettings sqlsettings_1)
	{
		this.sqlsettings_0 = sqlsettings_1;
	}

	public int Id
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	public Class322()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
	}

	public Class322(SQLSettings sqlsettings_1)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.sqlsettings_0 = sqlsettings_1;
	}

	public Class322(SQLSettings sqlsettings_1, int int_1)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.sqlsettings_0 = sqlsettings_1;
		this.int_0 = int_1;
	}

	internal static DataTable smethod_0(SQLSettings sqlsettings_1, int int_1)
	{
		return new SqlDataCommand(sqlsettings_1).SelectSqlData("vP_MoveTrans", true, "WHERE idObjList = " + int_1.ToString() + " AND Deleted = 0 ORDER BY Data DESC", null);
	}

	internal static DataTable smethod_1(SQLSettings sqlsettings_1)
	{
		string text = "SELECT tr.ID, dbo.fn_PI_GetIdObjListByOldName(trev.Comment1) AS idSubstation, ISNULL(l.Id, - 1) AS location, trev.Comment1, 'Т' + CAST(trev.Param AS VARCHAR(10)) AS Name, tr.TR_TYPE, CASE WHEN CAST(tr.INV_NOMER AS VARCHAR(10)) = '0' THEN '' ELSE CAST(tr.INV_NOMER AS VARCHAR(10)) END AS INV_NOMER, tr.ZAV_NOMER, tr.POWER, CASE WHEN CAST(tr.VOLT AS VARCHAR(10)) = '0' THEN '' \t ELSE CAST(tr.VOLT AS VARCHAR(10)) END AS HighVoltage, CASE WHEN CAST(tr.VOLT_NN AS VARCHAR(10)) = '0' THEN '' \t ELSE CAST(tr.VOLT_NN AS VARCHAR(10)) END AS LowVoltage, CASE WHEN CAST(tr.GR_OBMOTKA AS VARCHAR(10)) = '0' THEN '' \t ELSE CAST(tr.GR_OBMOTKA AS VARCHAR(10)) END AS GR_OBMOTKA, CASE WHEN CAST(tr.BUILD_YEAR AS VARCHAR(10)) = '1900' THEN '' \t WHEN CAST(tr.BUILD_YEAR AS VARCHAR(10)) = '0' THEN '' \t ELSE CAST(tr.BUILD_YEAR AS VARCHAR(10)) END AS BUILD_YEAR FROM [ULGES-SQL].PasportPS.dbo.view_LastTravel AS lt LEFT OUTER JOIN [ULGES-SQL].PasportPS.dbo.Transf_Travel AS trev ON lt.ID_Transf = trev.ID_Transf AND lt.MaxDate = trev.Date RIGHT OUTER JOIN [ULGES-SQL].PasportPS.dbo.Transf AS tr ON lt.ID_Transf = tr.ID LEFT OUTER JOIN dbo.tR_Classifier AS l ON trev.Comment1 = l.Name AND l.Deleted = 0 AND l.ParentKey = ';Passport;ObjLocation;' WHERE (trev.Deleted = 0) AND tr.ID NOT IN (SELECT idOldPassport FROM tSchm_ObjList AS ol \t\t\t\t  JOIN tP_Passport AS p ON ol.id = p.idObjList \t\t\t\t  WHERE ol.TypeCodeId = 556 AND ol.Deleted = ((0)) AND p.Deleted = ((0))) GROUP BY l.Id, tr.ID, tr.TR_TYPE, tr.ZAV_NOMER, tr.INV_NOMER, tr.POWER, tr.VOLT, tr.GR_OBMOTKA, \t\t trev.Date, trev.Comment1, trev.Param, tr.VOLT_NN, tr.BUILD_YEARORDER BY Comment1, Name";
		return new SqlDataCommand(sqlsettings_1).SelectSqlData(text);
	}

	internal static DataTable smethod_2(SQLSettings sqlsettings_1, int int_1)
	{
		string text = "SELECT tr.ID, dbo.fn_PI_GetIdObjListByOldName(trev.Comment1) AS idSubstation, ISNULL(l.Id, - 1) AS location, trev.Comment1, 'Т' + CAST(trev.Param AS VARCHAR(10)) AS Name, tr.TR_TYPE, CASE WHEN CAST(tr.INV_NOMER AS VARCHAR(10)) = '0' THEN '' ELSE CAST(tr.INV_NOMER AS VARCHAR(10)) END AS INV_NOMER, tr.ZAV_NOMER, tr.POWER, CASE WHEN CAST(tr.VOLT AS VARCHAR(10)) = '0' THEN '' \t ELSE CAST(tr.VOLT AS VARCHAR(10)) END AS HighVoltage, CASE WHEN CAST(tr.VOLT_NN AS VARCHAR(10)) = '0' THEN '' \t ELSE CAST(tr.VOLT_NN AS VARCHAR(10)) END AS LowVoltage, CASE WHEN CAST(tr.GR_OBMOTKA AS VARCHAR(10)) = '0' THEN '' \t ELSE CAST(tr.GR_OBMOTKA AS VARCHAR(10)) END AS GR_OBMOTKA, CASE WHEN CAST(tr.BUILD_YEAR AS VARCHAR(10)) = '1900' THEN '' \t WHEN CAST(tr.BUILD_YEAR AS VARCHAR(10)) = '0' THEN '' \t ELSE CAST(tr.BUILD_YEAR AS VARCHAR(10)) END AS BUILD_YEAR FROM [ULGES-SQL].PasportPS.dbo.view_LastTravel AS lt LEFT OUTER JOIN [ULGES-SQL].PasportPS.dbo.Transf_Travel AS trev ON lt.ID_Transf = trev.ID_Transf AND lt.MaxDate = trev.Date RIGHT OUTER JOIN [ULGES-SQL].PasportPS.dbo.Transf AS tr ON lt.ID_Transf = tr.ID LEFT OUTER JOIN dbo.tR_Classifier AS l ON trev.Comment1 = l.Name AND l.Deleted = 0 AND l.ParentKey = ';Passport;ObjLocation;' WHERE (trev.Deleted = 0) AND tr.ID NOT IN (SELECT idOldPassport FROM tSchm_ObjList AS ol \t\t\t\t  JOIN tP_Passport AS p ON ol.id = p.idObjList \t\t\t\t  WHERE ol.TypeCodeId = 556 AND ol.Deleted = ((0)) AND p.Deleted = ((0))) GROUP BY l.Id, tr.ID, tr.TR_TYPE, tr.ZAV_NOMER, tr.INV_NOMER, tr.POWER, tr.VOLT, tr.GR_OBMOTKA, \t\t trev.Date, trev.Comment1, trev.Param, tr.VOLT_NN, tr.BUILD_YEARWHERE idSubstation = " + int_1.ToString() + " AND Deleted = 0 ORDER BY NameSubstation, NameTransf";
		return new SqlDataCommand(sqlsettings_1).SelectSqlData(text);
	}

	internal static int smethod_3(SQLSettings sqlsettings_1, string string_0, int int_1)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_1);
		Class107 @class = new Class107();
		Class107.Class244 class2 = @class.tSchm_ObjList.method_5();
		class2.Name = string_0;
		class2.TypeCodeId = 556;
		class2.IdParent = int_1;
		class2.Deleted = false;
		return sqlDataCommand.InsertSqlDataOneRow(@class.tSchm_ObjList);
	}

	internal int method_2(string string_0, int int_1)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
		Class107 @class = new Class107();
		Class107.Class244 class2 = @class.tSchm_ObjList.method_5();
		class2.Name = string_0;
		class2.TypeCodeId = 556;
		class2.IdParent = int_1;
		class2.Deleted = false;
		this.int_0 = sqlDataCommand.InsertSqlDataOneRow(@class.tSchm_ObjList);
		return this.int_0;
	}

	internal bool method_3(Enum12 enum12_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
		Class107 @class = new Class107();
		sqlDataCommand.SelectSqlData(@class.tSchm_ObjList, true, "WHERE id = " + this.int_0.ToString(), null, false, 0);
		DataRow dataRow = @class.tSchm_ObjList.Rows[0];
		dataRow["IdParent"] = DBNull.Value;
		dataRow["Location"] = this.method_4(enum12_0);
		dataRow["IdParentAddl"] = DBNull.Value;
		return sqlDataCommand.UpdateSqlData(@class, @class.tSchm_ObjList);
	}

	internal int method_4(Enum12 enum12_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
		Class107 @class = new Class107();
		sqlDataCommand.SelectSqlData(@class.tR_Classifier, true, string.Format("WHERE ParentKey = ;Passport;ObjLocation; AND Value = {0}", (int)enum12_0), null, false, 0);
		if (@class.tR_Classifier.Rows.Count <= 0)
		{
			return -1;
		}
		return (int)@class.tR_Classifier.Rows[0]["id"];
	}

	internal int method_5(int int_1)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
		Class107 @class = new Class107();
		string text = string.Format("WHERE tSchm_Relation.Edge = {0}", int_1);
		sqlDataCommand.SelectSqlData(@class.tR_Classifier, true, text, null, false, 1);
		if (@class.tR_Classifier.Rows.Count <= 0)
		{
			return -1;
		}
		return (int)@class.tSchm_Relation.Rows[0]["id"];
	}

	internal static int smethod_4(SQLSettings sqlsettings_1, int int_1)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_1);
		Class107 @class = new Class107();
		string text = string.Format("WHERE idObjList = {0} AND Deleted = 0 AND isActive = 1", int_1);
		sqlDataCommand.SelectSqlData(@class.tP_Passport, true, text, null, false, 1);
		if (@class.tP_Passport.Rows.Count <= 0)
		{
			return -1;
		}
		return (int)@class.tP_Passport.Rows[0]["id"];
	}

	internal static int smethod_5(SQLSettings sqlsettings_1, int int_1, int int_2, string string_0)
	{
		return Class322.smethod_6(sqlsettings_1, int_1, int_2, string_0, true);
	}

	internal static int smethod_6(SQLSettings sqlsettings_1, int int_1, int int_2, string string_0, bool bool_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_1);
		Class107 @class = new Class107();
		if (!bool_0)
		{
			sqlDataCommand.SelectSqlData(@class.tP_ObjectChar, true, string.Format("WHERE idPassport = {0} AND idObjChar = {1} AND Deleted = ((0))  AND value IS NOT NULL AND value != '-1' AND value != '' AND value != '0'", int_1, int_2), null, false, 0);
			if (@class.tP_ObjectChar.Rows.Count > 0)
			{
				return @class.tP_ObjectChar.First<Class107.Class208>().id;
			}
		}
		sqlDataCommand.SelectSqlData(@class.tP_ObjectChar, true, string.Format("WHERE idPassport = {0} AND idObjChar = {1} AND Deleted = ((0))", int_1, int_2), null, false, 0);
		if (@class.tP_ObjectChar.Rows.Count > 0)
		{
			@class.tP_ObjectChar.First<Class107.Class208>().Value = string_0;
			@class.tP_ObjectChar.First<Class107.Class208>().EndEdit();
			sqlDataCommand.UpdateSqlData(@class, @class.tP_ObjectChar);
			return @class.tP_ObjectChar.First<Class107.Class208>().id;
		}
		Class107.Class208 class2 = @class.tP_ObjectChar.method_5();
		class2.idPassport = int_1;
		class2.idObjChar = int_2;
		class2.Value = string_0;
		class2.Deleted = false;
		@class.tP_ObjectChar.method_0(class2);
		return sqlDataCommand.InsertSqlDataOneRow(@class.tP_ObjectChar);
	}

	internal static bool smethod_7(SQLSettings sqlsettings_1, int int_1, bool bool_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_1);
		Class107 @class = new Class107();
		return sqlDataCommand.UpdateSqlData(@class.tP_Passport, "SET isActive = " + (bool_0 ? "((1))" : "((0))"), string.Format("WHERE id = {0}", int_1));
	}

	internal static bool smethod_8(SQLSettings sqlsettings_1, int int_1)
	{
		return new SqlDataCommand(sqlsettings_1).SelectSqlData(string.Format("SELECT * FROM tSchm_Move WHERE idObjList = {0} AND Deleted = ((0))", int_1)).Rows.Count > 0;
	}

	internal static bool AsMaBjvtheg(SQLSettings sqlsettings_1, string string_0, int int_1)
	{
		return new SqlDataCommand(sqlsettings_1).SelectSqlData(string.Format("SELECT * FROM tSchm_ObjList WHERE (idParent = {1} OR idParentAddl = {1}) AND Name = '{0}' AND Deleted = ((0))", string_0, int_1)).Rows.Count > 0;
	}

	private SQLSettings sqlsettings_0;

	private int int_0;
}
