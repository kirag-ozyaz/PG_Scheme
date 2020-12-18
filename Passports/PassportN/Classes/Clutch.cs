using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DataSql;

namespace Passport.Classes
{
	public static class Clutch
	{
		public static DataTable GetData(SQLSettings settings, int idCable, TypeObjList typeClutch, bool classifierName)
		{
			int typeId = ObjList.GetTypeId(settings, typeClutch);
			new SqlDataCommand(settings);
			string where = string.Format("WHERE ol.IdParent = {0} AND ol.TypeCodeId = {1} AND ol.Deleted = ((0))", idCable, typeId);
			string order = "ORDER BY CONVERT(INT, CASE WHEN Name like '%[^0-9]%' THEN SUBSTRING(Name,1,PATINDEX('%[^0-9]%',Name)-1) ELSE Name END)";
			return PassportData.GetEquipmentData(settings, typeId, "", "", where, order, classifierName);
		}

		public static DataTable GetData(SQLSettings settings, int idCable, string clutchName, TypeObjList typeClutch, bool classifierName)
		{
			new SqlDataCommand(settings);
			string where = string.Format("WHERE ol.IdParent = {0} AND c_ol.ParentKey = ';SCM;Clutch;' AND ol.Deleted = ((0)) AND ol.Name = '{1}'", idCable, clutchName);
			string order = "ORDER BY CONVERT(INT, CASE WHEN Name like '%[^0-9]%' THEN SUBSTRING(Name,1,PATINDEX('%[^0-9]%',Name)-1) ELSE Name END)";
			return PassportData.GetEquipmentData(settings, ObjList.GetTypeId(settings, typeClutch), "", "", where, order, classifierName);
		}

		public static bool Replace(SQLSettings settings, int oldId, int newId)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect(180);
			sqlDataConnect.OpenConnection(settings);
			SqlCommand sqlCommand = new SqlCommand("pP_ReplaceClutchs", sqlDataConnect.Connection);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			SqlParameter sqlParameter = new SqlParameter("@idOld", SqlDbType.Int);
			sqlParameter.Value = oldId;
			sqlCommand.Parameters.Add(sqlParameter);
			SqlParameter sqlParameter2 = new SqlParameter("@idNew", SqlDbType.Int);
			sqlParameter2.Value = newId;
			sqlCommand.Parameters.Add(sqlParameter2);
			return (bool)sqlCommand.ExecuteScalar();
		}

		public static int[] GetAllClutchOnCabSection(SQLSettings settings, int idPassport)
		{
			Class107 @class = new Class107();
			new SqlDataCommand(settings).SelectSqlData(@class.tP_CabSection, true, string.Format(" WHERE idPassport = {0} AND Deleted = ((0))", idPassport), null, false, 0);
			EnumerableRowCollection<int> enumerableRowCollection = from row in @class.tP_CabSection
			where !row.Deleted
			select row.idClutchFirst;
			EnumerableRowCollection<int> enumerableRowCollection2 = from row in @class.tP_CabSection
			where !row.Deleted
			select row.idClutchSecond;
			return enumerableRowCollection.Except(enumerableRowCollection2).Union(enumerableRowCollection2.Except(enumerableRowCollection)).ToArray<int>();
		}

		public static int GetIdFromName(SQLSettings settings, int idCable, string Name, TypeClutch type)
		{
			int result = -1;
			DataTable dataTable = new SqlDataCommand(settings).SelectSqlData("tSchm_ObjList", true, string.Format("WHERE idParent = {0} AND Name = '{1}' AND TypeCodeId = {2} AND Deleted = ((0))", idCable, Name, (int)type), null);
			if (dataTable.Rows.Count == 0)
			{
				return -1;
			}
			int.TryParse(dataTable.Rows[0]["id"].ToString(), out result);
			return result;
		}

		public static int Create(SQLSettings settings, int idCable, EndClutch value)
		{
			return Clutch.Create(settings, idCable, (value == EndClutch.First) ? "01" : "02", TypeClutch.End);
		}

		public static int Create(SQLSettings settings, int idCable, string Name, TypeClutch type)
		{
			int idFromName = Clutch.GetIdFromName(settings, idCable, Name, type);
			if (idFromName > 0)
			{
				return idFromName;
			}
			SqlDataCommand sqlDataCommand = new SqlDataCommand(settings);
			Class107 @class = new Class107();
			Class107.Class244 class2 = @class.tSchm_ObjList.method_5();
			class2.IdParent = idCable;
			class2.TypeCodeId = (int)type;
			class2.idParentAddl = idCable;
			class2.Name = Name;
			class2.Deleted = false;
			@class.tSchm_ObjList.method_0(class2);
			return sqlDataCommand.InsertSqlDataOneRow(@class.tSchm_ObjList);
		}

		public static bool Edit(SQLSettings settings, int idClutch, string name, TypeClutch type)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(settings);
			Class107 @class = new Class107();
			sqlDataCommand.SelectSqlData(@class.tSchm_ObjList, true, "WHERE id = " + idClutch.ToString(), null, false, 0);
			if (@class.tSchm_ObjList.Rows.Count == 0)
			{
				throw new Exception("Не найдена муфта.");
			}
			Class107.Class244 class2 = (Class107.Class244)@class.tSchm_ObjList.Rows[0];
			class2.TypeCodeId = (int)type;
			class2.Name = name;
			return sqlDataCommand.UpdateSqlData(@class, @class.tSchm_ObjList);
		}

		public static bool Delete(SQLSettings settings, int idClutch)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(settings);
			Class107 @class = new Class107();
			sqlDataCommand.SelectSqlData(@class.tSchm_ObjList, true, string.Format(" WHERE id = {0}", idClutch), null, false, 0);
			if (@class.tSchm_ObjList.Rows.Count == 0)
			{
				throw new Exception("DeleteClutch: Clutch not found");
			}
			@class.tSchm_ObjList.Rows[0]["Deleted"] = true;
			@class.tSchm_ObjList.Rows[0].EndEdit();
			return sqlDataCommand.UpdateSqlData(@class, @class.tSchm_ObjList);
		}

		public static bool DeletePassport(SQLSettings settings, int idClutchPassport)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(settings);
			Class107 @class = new Class107();
			sqlDataCommand.SelectSqlData(@class.tP_Passport, true, string.Format(" WHERE id = {0}", idClutchPassport), null, false, 0);
			if (@class.tP_Passport.Rows.Count == 0)
			{
				throw new Exception("DeleteClutchPassport: Passport clutch not found");
			}
			@class.tP_Passport.Rows[0]["Deleted"] = true;
			@class.tP_Passport.Rows[0].EndEdit();
			return sqlDataCommand.UpdateSqlData(@class, @class.tP_Passport);
		}

		public static DataTable GetClutchTypes(SQLSettings settings)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(settings);
			string text = string.Format("WHERE ParentKey = ';SCM;Clutch;' AND isGroup = ((0)) AND Deleted = ((0))", new object[0]);
			return sqlDataCommand.SelectSqlData("tR_Classifier", true, text, null);
		}

		public static bool isExistIntoCabSection(SQLSettings settings, int idCable, int idCabSection, int idClutch, SectionClutch value)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(settings);
			string arg = ((value == SectionClutch.First) ? "idClutchFirst = " : "idClutchSecond = ") + idClutch;
			string text = string.Format("WHERE idObjList = {0} AND id != {1} AND {2} AND Deleted = ((0))", idCable, idCabSection, arg);
			return sqlDataCommand.SelectSqlData("tP_CabSection", true, text, null).Rows.Count > 0;
		}

		public static bool isExistEndClutchIntoCabSection(SQLSettings settings, int idCable, EndClutch value)
		{
			string arg = (value == EndClutch.First) ? "01" : "02";
			SqlDataCommand sqlDataCommand = new SqlDataCommand(settings);
			string text = string.Format("AS ol JOIN tR_Classifier AS c ON ol.TypeCodeId = c.id WHERE ol.idParent = {0} AND c.ParentKey = ';SCM;Clutch;' AND c.Value = 1 AND ol.Deleted = ((0)) AND ol.Name = '{1}'", idCable, arg);
			return sqlDataCommand.SelectSqlData("tSchm_ObjList", true, text, null).Rows.Count > 0;
		}

		public static void isExistEndClutchIntoCabSection(SQLSettings settings, int idCable, out bool first, out bool second)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(settings);
			string text = string.Format("WHERE idParent = {0} AND Deleted = ((0))", idCable);
			DataTable dataTable = sqlDataCommand.SelectSqlData("tSchm_ObjList", true, text, null);
			first = (dataTable.Select("Name = '01'").Length != 0);
			second = (dataTable.Select("Name = '02'").Length != 0);
		}

		public static bool FindEndClutches(SQLSettings settings, int idCable)
		{
			bool flag = false;
			bool flag2 = false;
			Clutch.isExistEndClutchIntoCabSection(settings, idCable, out flag, out flag2);
			return flag && flag2;
		}
	}
}
