using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DataSql;

namespace Library
{
    public class Security
    {
        public SQLSettings SqlSettings { get; set; }
        
        /// <summary>
        /// получим текущего пользователя
        /// </summary>
        /// <returns></returns>
        public string GetCurrentUser()
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                sqlConnection.Open();
                using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand sqlCommand2 = new SqlCommand("select isnull(w.fio, u.name) as name from tuser u" +
                            "                                left join vr_worker w on u.idWorker = w.id " +
                            "                                    where login = SYSTEM_USER", sqlConnection))
                        {
                            sqlCommand2.CommandTimeout = 0;
                            sqlCommand2.Transaction = sqlTransaction;
                            DbDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCommand2);
                            DataTable dataTable = new DataTable();
                            dbDataAdapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["name"] != DBNull.Value)
                            {
                                return dataTable.Rows[0]["name"].ToString();
                            }
                        }
                        sqlTransaction.Commit();
                    }
                    catch 
                    {
                        sqlTransaction.Rollback();
                    }
                }

            }
            return string.Empty;
        }

        public DataTable GetCurrentUserRules()
        {
    
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                sqlConnection.Open();
                using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand sqlCommand2 = new SqlCommand("  " +
                            " select id, isnull(w.fio, u.name) as name, w.[WorkerGroup], w.[ParentKey] from tuser u " +
                            "              left join[vWorkerGroup] w on u.idWorker = w.id " +
                            "               where login = SYSTEM_USER", sqlConnection))
                        {
                            sqlCommand2.CommandTimeout = 0;
                            sqlCommand2.Transaction = sqlTransaction;
                            DbDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCommand2);
                            DataTable dataTable = new DataTable();
                            dbDataAdapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["name"] != DBNull.Value)
                            {
                                return dataTable;
                            }
                        }
                        sqlTransaction.Commit();
                    }
                    catch
                    {
                        sqlTransaction.Rollback();
                    }
                }

            }
            return null;
        }
    }
}
