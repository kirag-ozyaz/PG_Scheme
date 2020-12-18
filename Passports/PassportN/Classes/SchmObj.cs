using System;
using System.Data;
using System.Data.SqlClient;
using DataSql;

namespace Passport.Classes
{
	public static class SchmObj
	{
		public static string GetMinCabSectionString(SQLSettings settings, int idCable)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(settings);
			string result = "";
			try
			{
				return sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetFullCableMakeupName", new string[]
				{
					idCable.ToString()
				}).ToString();
			}
			catch (Exception)
			{
			}
			return result;
		}

		public static string GetMinAirLineSpanString(SQLSettings Sett, int idAirLine)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(Sett);
			string empty = string.Empty;
			try
			{
				return sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetFullCableMakeupNameByAirLine", new string[]
				{
					idAirLine.ToString()
				}).ToString();
			}
			catch (Exception)
			{
			}
			return empty;
		}

		public static bool ExistsPassport(SQLSettings settings, int idCable)
		{
			return (int)new SqlDataCommand(settings).SelectSqlData(string.Format("SELECT COUNT(id) Count FROM tP_Passport WHERE idObjList = {0} AND isActive = ((1)) AND Deleted = ((0))", idCable)).Rows[0]["Count"] > 0;
		}

		public static int GetIdCable(SQLSettings settings, int idPassport)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			DataTable dataTable = new DataTable();
			int num = -1;
			int result;
			try
			{
				sqlDataConnect.OpenConnection(settings);
				new SqlDataAdapter(new SqlCommand("SELECT idObjList FROM tP_Passport WHERE id = " + idPassport.ToString(), sqlDataConnect.Connection)).Fill(dataTable);
				if (dataTable.Rows.Count > 0)
				{
					int.TryParse(dataTable.Rows[0][0].ToString(), out num);
				}
				result = num;
			}
			catch (Exception)
			{
				result = num;
			}
			return result;
		}

		public static bool UnbindPassport(SQLSettings settings, int idObjList)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			bool result;
			try
			{
				sqlDataConnect.OpenConnection(settings);
				using (SqlCommand sqlCommand = new SqlCommand("Procedure", sqlDataConnect.Connection))
				{
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "dbo.pP_UnbindCablePassport";
					SqlParameter sqlParameter = new SqlParameter();
					sqlParameter.ParameterName = "@idObjList";
					sqlParameter.SqlDbType = SqlDbType.Int;
					sqlParameter.Value = idObjList;
					sqlParameter.Direction = ParameterDirection.Input;
					sqlCommand.Parameters.Add(sqlParameter);
					result = (sqlCommand.ExecuteNonQuery() > 0);
				}
			}
			catch (Exception)
			{
				result = false;
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
			return result;
		}

		public static bool BindPassport(SQLSettings settings, int idObjList, int idBindObjList)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			bool result;
			try
			{
				sqlDataConnect.OpenConnection(settings);
				using (SqlCommand sqlCommand = new SqlCommand("Procedure", sqlDataConnect.Connection))
				{
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "dbo.pP_BindCablePassport";
					SqlParameter sqlParameter = new SqlParameter();
					sqlParameter.ParameterName = "@idObjList";
					sqlParameter.SqlDbType = SqlDbType.Int;
					sqlParameter.Value = idObjList;
					sqlParameter.Direction = ParameterDirection.Input;
					sqlCommand.Parameters.Add(sqlParameter);
					SqlParameter sqlParameter2 = new SqlParameter();
					sqlParameter2.ParameterName = "@idBindObjList";
					sqlParameter2.SqlDbType = SqlDbType.Int;
					sqlParameter2.Value = idBindObjList;
					sqlParameter2.Direction = ParameterDirection.Input;
					sqlCommand.Parameters.Add(sqlParameter2);
					result = (sqlCommand.ExecuteNonQuery() > 0);
				}
			}
			catch (Exception)
			{
				result = false;
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
			return result;
		}

		public static bool BindDeletedPassport(SQLSettings Settings, int idObjList, int idPassport)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			bool result;
			try
			{
				sqlDataConnect.OpenConnection(Settings);
				using (SqlCommand sqlCommand = new SqlCommand(string.Format("UPDATE tP_Passport\r\nSET idObjList = '{0}', deleted = '0', isActive = '1'\r\nWHERE id = '{1}'", idObjList, idPassport), sqlDataConnect.Connection))
				{
					result = (sqlCommand.ExecuteNonQuery() > 0);
				}
			}
			catch (Exception)
			{
				result = false;
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
			return result;
		}

		internal static int smethod_0(SQLSettings sqlsettings_0, int int_0)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings_0);
			Class107 @class = new Class107();
			string text = string.Format("WHERE idObjList = {0} AND Deleted = 0 AND isActive = 1", int_0);
			sqlDataCommand.SelectSqlData(@class.tP_Passport, true, text, null, false, 1);
			if (@class.tP_Passport.Rows.Count <= 0)
			{
				return -1;
			}
			return (int)@class.tP_Passport.Rows[0]["id"];
		}
	}
}
