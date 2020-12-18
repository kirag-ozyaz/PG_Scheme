using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DataSql;
/// <summary>
/// Работа с глобальным логом
/// </summary>
namespace References
{
    /// <summary>
    /// вернуть записи таблицы 'tL_SchmAbn' на определенную дату события
    /// с отбором по определенным объектам абонентов
    /// </summary>
    public class TableLog
    {
        private DataSql.SQLSettings sQLSettings;

        public SQLSettings SQLSettings { get => sQLSettings; set => sQLSettings = value; }

        public DataTable  Get(string TableName, DateTime dataEvent, List<string> listIdColumn, string idColumnName = "idAbnObj")
        {
            DataTable dt = new DataTable(TableName);
            // смотрим запрос GetTableSchmAbn
            string select = String.Format("SELECT  tl.*" +
                "  FROM[GES_log].[dbo].{0} tl" +
                "  where tl.{3} in ({2})  and tl.id =" +
                "                (Select Top 1 id" +
                "                 from" +
                "                (" +
                "                SELECT top 1 id" +
                "                    FROM [GES_log].[dbo].{0}" +
                "                    where {3} = tl.{3}  and(datecommand > '{1}')" +
                "                        union all" +
                "                SELECT top 1 id" +
                "                    FROM [GES_log].[dbo].{0}" +
                "                    where {3} = tl.{3}  and(datecommand <= '{1}')" +
                "                    order by id desc" +
                "               ) tlAll" +
                "                order by id asc" +
                "			)" +
                "  order by tl.id desc", 
                    new object[]  { TableName, dataEvent.ToString("yyyy-MM-dd HH:mm:ss"), String.Join(",", listIdColumn.ToArray()) , idColumnName });

            using (SqlConnection sqlConnection = new SqlConnection(SQLSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                dt = new DataSql.SqlDataCommand(SQLSettings).SelectSqlData(select);
            }

            return dt;
        }
    }
}
