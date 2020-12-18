using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
using DataSql;
using SchemeModel;
using Library;

namespace References
{
    public class SchemeTables
    {
        /// <summary>
        /// таблица кабелей
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="SqlSettings"></param>
        public static void GetTableSchmCable(DataTable dt, SQLSettings SqlSettings)
        {
            GetReferensTable(dt, "SchmCable", SqlSettings);
        }
        /// <summary>
        /// таблица ячеек
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="SqlSettings"></param>
        public static void GetTableSchmCell(DataTable dt, SQLSettings SqlSettings)
        {
            GetReferensTable(dt, "SchmCell", SqlSettings);
        }
        /// <summary>
        /// таблица марок кабелей
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="SqlSettings"></param>
        public static void GetTableMarkCable(DataTable dt, SQLSettings SqlSettings)
        {
            GetReferensTable(dt, "MarkCable", SqlSettings);
        }
        /// <summary>
        /// вернуть журнал трансформаторов
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="SqlSettings"></param>
        public static void GetTransformerSchmObj(DataTable dt, SQLSettings SqlSettings)
        {
            GetReferensTable(dt, "GetTransformerSchmObj", SqlSettings);
        }

        public static void GetReferensTable(DataTable dt, string Assembly, SQLSettings SqlSettings)
        {
            DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ResourceReader.GetStringAssembly(typeof(SchemeTables), "References."+ Assembly + ".sql"), sqlConnection);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    dt.Clear();
                    sqlDataAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
        }
        /// <summary>
        /// Вернуть справочник по запросу, 
        /// Where - отбор по значениям (если where в основном запросе нет, то добавить)
        /// </summary>
        public static void GetReferensTable(DataTable dt, string Assembly, SQLSettings SqlSettings, string Where = "")
        {
            DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ResourceReader.GetStringAssembly(typeof(SchemeTables), "References." + Assembly + ".sql"), sqlConnection);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    sqlDataAdapter.SelectCommand.CommandText += " " + Where;
                    dt.Clear();
                    sqlDataAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
        }
    }
}
