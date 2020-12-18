using DataSql;
using Logger;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace StatementsForME
{
    partial class  SendRequestToME
    {
        public DataTable LoadDataPlan(int isSendSitePlanMe, int? Year = null, int? Month = null)
        {
            DataTable dt = new DataTable();
            DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();
            // проверим есть ли данные простым запросом, чтобы не запускать тяжелый
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(typeof(SendRequestToME).Assembly, "StatementsForME.GetTableRequestForControl.sql"), sqlConnection);
                    //sqlCommand.Parameters.Add("isSendSiteMe", SqlDbType.Int).Value = isSendSitePlanMe;
                    if (!(Year == null && Month == null))
                    {
                        sqlCommand.Parameters.Add("Year", SqlDbType.Int).Value = Year;
                        sqlCommand.Parameters.Add("Month", SqlDbType.Int).Value = Month;
                    }
                    else
                    {
                        sqlCommand.Parameters.Add("Year", SqlDbType.Int).Value = DBNull.Value;
                        sqlCommand.Parameters.Add("Month", SqlDbType.Int).Value = DBNull.Value;
                    }
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    sqlDataAdapter.Fill(dt);

                    if (dt.Rows.Count <= 0)
                    {
                        return dt;
                    }
                    if (IdDocument != -1)
                    {
                        if (dt.Select("id = " + IdDocument).Count() <= 0)
                        {
                            return dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.Write(LogLevel.Error, "StatementsForME", "SendRequestPlanToME", "LoadData - проверка наличия данных", ex.Message, null);
                }
            }
            // запускаем тяжеловеса
            dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(typeof(SendRequestToME).Assembly, "StatementsForME.GetTableRequestForRepair.sql"), sqlConnection);
                    //sqlCommand.Parameters.Add("isSendSiteMe", SqlDbType.Int).Value = isSendSitePlanMe;
                    sqlCommand.Parameters.Add("Year", SqlDbType.Int).Value = Year;
                    sqlCommand.Parameters.Add("Month", SqlDbType.Int).Value = Month;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    sqlDataAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Log.Write(LogLevel.Error, "StatementsForME", "SendRequestPlanToME", "LoadData - загрузка данных", ex.Message, null);
                }
            }

            if (IdDocument != -1)
            {
                if (dt.Select("id = " + IdDocument).Count() != 0)
                    return dt.Select("id = " + IdDocument).CopyToDataTable();
                else
                    dt.Clear();
            }
            return dt;
        }
    }
}
