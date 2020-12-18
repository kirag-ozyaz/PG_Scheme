using System;
using System.Data;
using System.Linq;
using DataSql;
using Passport.DataSets;

internal class Class114
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

	public Class114()
	{
	}

	public Class114(SQLSettings sqlsettings_1)
	{
		this.sqlsettings_0 = sqlsettings_1;
	}

	public Class114(SQLSettings sqlsettings_1, int int_1)
	{
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

	internal static int smethod_3(SQLSettings sqlsettings_1, string string_1, int int_1)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_1);
		dsPassport dsPassport = new dsPassport();
		dsPassport.Class49 @class = dsPassport.tSchm_ObjList.method_5();
		@class.Name = string_1;
		@class.TypeCodeId = 556;
		@class.IdParent = int_1;
		@class.method_5(false);
		return sqlDataCommand.InsertSqlDataOneRow(dsPassport.tSchm_ObjList);
	}

	internal int method_2(string string_1, int int_1)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		dsPassport.Class49 @class = dsPassport.tSchm_ObjList.method_5();
		@class.Name = string_1;
		@class.TypeCodeId = 556;
		@class.IdParent = int_1;
		@class.method_5(false);
		this.int_0 = sqlDataCommand.InsertSqlDataOneRow(dsPassport.tSchm_ObjList);
		return this.int_0;
	}

	internal bool method_3(Enum3 enum3_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		sqlDataCommand.SelectSqlData(dsPassport.tSchm_ObjList, true, "WHERE id = " + this.int_0.ToString(), null, false, 0);
		DataRow dataRow = dsPassport.tSchm_ObjList.Rows[0];
		dataRow["IdParent"] = DBNull.Value;
		dataRow["Location"] = this.method_4(enum3_0);
		dataRow["IdParentAddl"] = DBNull.Value;
		return sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tSchm_ObjList);
	}

	internal int method_4(Enum3 enum3_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		sqlDataCommand.SelectSqlData(dsPassport.tR_Classifier, true, string.Format("WHERE ParentKey = ;Passport;ObjLocation; AND Value = {0}", (int)enum3_0), null, false, 0);
		if (dsPassport.tR_Classifier.Rows.Count <= 0)
		{
			return -1;
		}
		return (int)dsPassport.tR_Classifier.Rows[0]["id"];
	}

	internal int method_5(int int_1)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
		dsPassport dsPassport = new dsPassport();
		string text = string.Format("WHERE tSchm_Relation.Edge = {0}", int_1);
		sqlDataCommand.SelectSqlData(dsPassport.tR_Classifier, true, text, null, false, 1);
		if (dsPassport.tR_Classifier.Rows.Count <= 0)
		{
			return -1;
		}
		return (int)dsPassport.tSchm_Relation.Rows[0]["id"];
	}

	internal static int smethod_4(SQLSettings sqlsettings_1, int int_1)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_1);
		dsPassport dsPassport = new dsPassport();
		string text = string.Format("WHERE idObjList = {0} AND Deleted = 0 AND isActive = 1", int_1);
		sqlDataCommand.SelectSqlData(dsPassport.tP_Passport, true, text, null, false, 1);
		if (dsPassport.tP_Passport.Rows.Count <= 0)
		{
			return -1;
		}
		return (int)dsPassport.tP_Passport.Rows[0]["id"];
	}

	internal static int smethod_5(SQLSettings sqlsettings_1, int int_1, int int_2, string string_1)
	{
		return Class114.smethod_6(sqlsettings_1, int_1, int_2, string_1, true);
	}

	internal static int smethod_6(SQLSettings sqlsettings_1, int int_1, int int_2, string string_1, bool bool_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_1);
		dsPassport dsPassport = new dsPassport();
		if (!bool_0)
		{
			sqlDataCommand.SelectSqlData(dsPassport.tP_ObjectChar, true, string.Format("WHERE idPassport = {0} AND idObjChar = {1} AND Deleted = ((0))  AND value IS NOT NULL AND value != '-1' AND value != '' AND value != '0'", int_1, int_2), null, false, 0);
			if (dsPassport.tP_ObjectChar.Rows.Count > 0)
			{
				return dsPassport.tP_ObjectChar.First<dsPassport.Class13>().Int32_0;
			}
		}
		sqlDataCommand.SelectSqlData(dsPassport.tP_ObjectChar, true, string.Format("WHERE idPassport = {0} AND idObjChar = {1} AND Deleted = ((0))", int_1, int_2), null, false, 0);
		if (dsPassport.tP_ObjectChar.Rows.Count > 0)
		{
			dsPassport.tP_ObjectChar.First<dsPassport.Class13>().Value = string_1;
			dsPassport.tP_ObjectChar.First<dsPassport.Class13>().EndEdit();
			sqlDataCommand.UpdateSqlData(dsPassport, dsPassport.tP_ObjectChar);
			return dsPassport.tP_ObjectChar.First<dsPassport.Class13>().Int32_0;
		}
		dsPassport.Class13 @class = dsPassport.tP_ObjectChar.method_5();
		@class.idPassport = int_1;
		@class.idObjChar = int_2;
		@class.Value = string_1;
		@class.Deleted = false;
		dsPassport.tP_ObjectChar.method_0(@class);
		return sqlDataCommand.InsertSqlDataOneRow(dsPassport.tP_ObjectChar);
	}

	internal static bool smethod_7(SQLSettings sqlsettings_1, int int_1, bool bool_0)
	{
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_1);
		dsPassport dsPassport = new dsPassport();
		return sqlDataCommand.UpdateSqlData(dsPassport.tP_Passport, "SET isActive = " + (bool_0 ? "((1))" : "((0))"), string.Format("WHERE id = {0}", int_1));
	}

	internal static bool smethod_8(SQLSettings sqlsettings_1, int int_1)
	{
		return new SqlDataCommand(sqlsettings_1).SelectSqlData(string.Format("SELECT * FROM tSchm_Move WHERE idObjList = {0} AND Deleted = ((0))", int_1)).Rows.Count > 0;
	}

	internal static bool smethod_9(SQLSettings sqlsettings_1, string string_1, int int_1)
	{
		return new SqlDataCommand(sqlsettings_1).SelectSqlData(string.Format("SELECT * FROM tSchm_ObjList WHERE (idParent = {1} OR idParentAddl = {1}) AND Name = '{0}' AND Deleted = ((0))", string_1, int_1)).Rows.Count > 0;
	}

	private SQLSettings sqlsettings_0;

	private int int_0;

	public const string string_0 = "SELECT tr.ID, dbo.fn_PI_GetIdObjListByOldName(trev.Comment1) AS idSubstation, ISNULL(l.Id, - 1) AS location, trev.Comment1, 'Т' + CAST(trev.Param AS VARCHAR(10)) AS Name, tr.TR_TYPE, CASE WHEN CAST(tr.INV_NOMER AS VARCHAR(10)) = '0' THEN '' ELSE CAST(tr.INV_NOMER AS VARCHAR(10)) END AS INV_NOMER, tr.ZAV_NOMER, tr.POWER, CASE WHEN CAST(tr.VOLT AS VARCHAR(10)) = '0' THEN '' \t ELSE CAST(tr.VOLT AS VARCHAR(10)) END AS HighVoltage, CASE WHEN CAST(tr.VOLT_NN AS VARCHAR(10)) = '0' THEN '' \t ELSE CAST(tr.VOLT_NN AS VARCHAR(10)) END AS LowVoltage, CASE WHEN CAST(tr.GR_OBMOTKA AS VARCHAR(10)) = '0' THEN '' \t ELSE CAST(tr.GR_OBMOTKA AS VARCHAR(10)) END AS GR_OBMOTKA, CASE WHEN CAST(tr.BUILD_YEAR AS VARCHAR(10)) = '1900' THEN '' \t WHEN CAST(tr.BUILD_YEAR AS VARCHAR(10)) = '0' THEN '' \t ELSE CAST(tr.BUILD_YEAR AS VARCHAR(10)) END AS BUILD_YEAR FROM [ULGES-SQL].PasportPS.dbo.view_LastTravel AS lt LEFT OUTER JOIN [ULGES-SQL].PasportPS.dbo.Transf_Travel AS trev ON lt.ID_Transf = trev.ID_Transf AND lt.MaxDate = trev.Date RIGHT OUTER JOIN [ULGES-SQL].PasportPS.dbo.Transf AS tr ON lt.ID_Transf = tr.ID LEFT OUTER JOIN dbo.tR_Classifier AS l ON trev.Comment1 = l.Name AND l.Deleted = 0 AND l.ParentKey = ';Passport;ObjLocation;' WHERE (trev.Deleted = 0) AND tr.ID NOT IN (SELECT idOldPassport FROM tSchm_ObjList AS ol \t\t\t\t  JOIN tP_Passport AS p ON ol.id = p.idObjList \t\t\t\t  WHERE ol.TypeCodeId = 556 AND ol.Deleted = ((0)) AND p.Deleted = ((0))) GROUP BY l.Id, tr.ID, tr.TR_TYPE, tr.ZAV_NOMER, tr.INV_NOMER, tr.POWER, tr.VOLT, tr.GR_OBMOTKA, \t\t trev.Date, trev.Comment1, trev.Param, tr.VOLT_NN, tr.BUILD_YEAR";
}
