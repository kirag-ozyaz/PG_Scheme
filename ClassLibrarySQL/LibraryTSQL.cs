using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataSql;
using Logger;
using Npgsql;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace LibraryTSQL
{
    /// <summary>
    /// команды для работы с Microsoft SQL Server (v1)
    /// </summary>
    public class SqlDataCommand
    {
        private int _commandTimeout = 30;

        public SQLSettings SqlSettings { get; set; }

        public int CommandTimeout { get => _commandTimeout; set => _commandTimeout = value; }
        public SqlDataCommand(SQLSettings sqlSett)
        {
            this.SqlSettings = sqlSett;
            // CommandTimeout = 30;
        }
        public SqlDataCommand()
        {
        }
        public object CallSQLScalarFunction(string nameFunction, params string[] param)
        {
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            object result;
            try
            {
                string text = "select " + nameFunction;
                for (int i = 0; i < param.Length; i++)
                {
                    if (i < param.Length - 1)
                    {
                        if (i == 0)
                        {
                            text += "( @param0, ";
                        }
                        else
                        {
                            text = text + " @param" + i.ToString() + ", ";
                        }
                    }
                    else if (i == 0)
                    {
                        text += "( @param0)";
                    }
                    else
                    {
                        text = text + " @param" + i.ToString() + ") ";
                    }
                }
                sqlDataConnect.OpenConnection(this.SqlSettings);
                SqlCommand sqlCommand = new SqlCommand(text, sqlDataConnect.Connection);
                for (int j = 0; j < param.Length; j++)
                {
                    SqlParameter value = new SqlParameter("@param" + j.ToString(), param[j]);
                    sqlCommand.Parameters.Add(value);
                }
                result = sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                result = null;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return result;
        }

        public bool UpdateSqlDataOnlyChange(DataTable dt)
        {
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            try
            {
                sqlDataConnect.OpenConnection(SqlSettings);
                DataTable changes = dt.GetChanges(DataRowState.Modified);
                if (changes == null || changes.Rows.Count == 0)
                {
                    return true;
                }
                DataColumn[] primaryKey = dt.PrimaryKey;
                string textWhere = " where ";
                ArrayList arrayListPrimary = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayListPrimary.Add(primaryKey[i].ColumnName);
                    textWhere = string.Concat(new string[]
                    {
                        textWhere, "[",  primaryKey[i].ColumnName, "] = @paramPrimary", i.ToString(), " and " });
                    }   
                if (textWhere.LastIndexOf(" and ") >= 0)
                {
                    textWhere = textWhere.Remove(textWhere.LastIndexOf(" and "));
                }
                ArrayList arrayListSet = new ArrayList();
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    if (arrayListPrimary.BinarySearch(dataColumn.ColumnName) < 0)
                    {
                        if (!dataColumn.ReadOnly)
                        {
                            arrayListSet.Add(dataColumn.ColumnName);
                        }
                    }
                    else
                    {
                        arrayListSet.Remove(dataColumn.ColumnName);
                    }
                }
                foreach (DataRow dataRow in changes.Rows)
                {
                    string textUpdate = "update [" + dt.TableName + "] set ";
                    SqlCommand sqlCommand = new SqlCommand(textUpdate, sqlDataConnect.Connection);
                    for (int j = 0; j < arrayListPrimary.Count; j++)
                    {
                        SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), dt.Columns[arrayListPrimary[j].ToString()].DataType);
                        sqlParameter.SqlValue = dataRow[arrayListPrimary[j].ToString()];
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    bool flag = false;
                    for (int k = 0; k < arrayListSet.Count; k++)
                    {
                        if (!dataRow[arrayListSet[k].ToString(), DataRowVersion.Original].Equals(dataRow[arrayListSet[k].ToString(), DataRowVersion.Current]))
                        {
                            flag = true;
                            textUpdate = string.Concat(new object[] {textUpdate,"[",arrayListSet[k],"] = @param",k.ToString(),", "});
                            Type dataType = dt.Columns[arrayListSet[k].ToString()].DataType;
                            SqlParameter sqlParameter2;
                            if (dataType == typeof(byte[]))
                            {
                                sqlParameter2 = new SqlParameter("@param" + k.ToString(), SqlDbType.Binary);
                            }
                            else
                            {
                                sqlParameter2 = new SqlParameter("@param" + k.ToString(), dataType);
                            }
                            sqlParameter2.SqlValue = dataRow[arrayListSet[k].ToString()];
                            sqlCommand.Parameters.Add(sqlParameter2);
                        }
                    }
                    if (flag)
                    {
                        if (textUpdate.LastIndexOf(", ") >= 0)
                        {
                            textUpdate = textUpdate.Remove(textUpdate.LastIndexOf(", "));
                        }
                        textUpdate += textWhere;
                        sqlCommand.CommandText = textUpdate;
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return false;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }
        /// <summary>
        /// обновление таблицы по одному параметру, либо все перечислить через запятую
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="setParam"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public bool UpdateSqlData(DataTable dt, string setParam, string where)
        {
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            bool result;
            try
            {
                string cmdText = string.Concat(new string[] { "update [", dt.TableName, "] ", " set " + setParam, " ", " where " + where });
                sqlDataConnect.OpenConnection(this.SqlSettings);
                new SqlCommand(cmdText, sqlDataConnect.Connection).ExecuteNonQuery();
                return true;
            }
            catch
            {
                result = false;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return result;
        }

        public bool SelectSqlData(DataTable dt, bool withGetSqlPermission, string where = "", int? timeOut = null, bool distinct = false, int countRows = 0)
        {
            DataTable dataTable;
            if (withGetSqlPermission)
            {
                dataTable = this.GetSqlPermissions(new string[]
                {
            dt.TableName
                });
            }
            else
            {
                dataTable = new DataTable();
            }
            bool result;
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
            {
                try
                {
                    string text = "select ";
                    if (distinct)
                    {
                        text += "distinct ";
                    }
                    if (countRows > 0)
                    {
                        text = text + "top " + countRows.ToString() + " ";
                    }
                    if (withGetSqlPermission)
                    {
                        foreach (DataRow dataRow in dataTable.Select("Operation = 'select'"))
                        {
                            if (dt.Columns.Count > 0)
                            {
                                if (dt.Columns.Contains(dataRow["ColumnName"].ToString()))
                                {
                                    text = string.Concat(new object[] { text, "[", dt.TableName, "].[", dataRow["ColumnName"], "], " });
                                }
                            }
                            else
                            {
                                text = string.Concat(new object[] { text, "[", dt.TableName, "].[", dataRow["ColumnName"], "], " });
                            }
                        }
                        text = text.Remove(text.LastIndexOf(", "));
                    }
                    else
                    {
                        text += " * ";
                    }
                    text = text + " from " + dt.TableName + " ";
                    text += where;
                    dt.Clear();
                    sqlConnection.Open();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(text, sqlConnection))
                    //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(text, sqlConnection);
                    {
                        if (timeOut != null)
                        {
                            sqlDataAdapter.SelectCommand.CommandTimeout = timeOut.Value;
                        }
                        sqlDataAdapter.Fill(dt);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                    result = false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return result;
        }

        private bool SelectSqlData(DataSet ds, string dt, bool withGetSqlPermission, string where, TimeSpan timeOut)
        {
            DataTable dataTable;
            if (withGetSqlPermission)
            {
                dataTable = this.GetSqlPermissions(new string[]
                {
                    dt
                });
            }
            else
            {
                dataTable = new DataTable();
            }
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            bool result;
            try
            {
                string txtSelect = "select ";
                if (withGetSqlPermission)
                {
                    foreach (DataRow dataRow in dataTable.Select("Operation = 'select'"))
                    {
                        if (ds.Tables[dt] != null && ds.Tables[dt].Columns.Count > 0)
                        {
                            if (ds.Tables[dt].Columns.Contains(dataRow["ColumnName"].ToString()))
                            {
                                txtSelect = string.Concat(new object[]
                                {
                                    txtSelect,
                                    "[",
                                    dt,
                                    "].[",
                                    dataRow["ColumnName"],
                                    "], "
                                });
                            }
                        }
                        else
                        {
                            txtSelect = string.Concat(new object[]
                            {
                                txtSelect,
                                "[",
                                dt,
                                "].[",
                                dataRow["ColumnName"],
                                "], "
                            });
                        }
                    }
                    txtSelect = txtSelect.Remove(txtSelect.LastIndexOf(", "));
                }
                else
                {
                    txtSelect += " * ";
                }
                txtSelect = txtSelect + " from " + dt + " ";
                txtSelect += where;
                if (ds.Tables[dt] != null)
                {
                    ds.Tables[dt].Clear();
                }
                sqlDataConnect.OpenConnection(this.SqlSettings);
                new SqlDataAdapter(txtSelect, sqlDataConnect.Connection)
                {
                    SelectCommand =
                    {
                        CommandTimeout = timeOut.Seconds
                    }
                }.Fill(ds, dt);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                result = false;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return result;
        }

        private bool SelectSqlData(DataSet ds, string dt, bool withGetSqlPermission, string where)
        {
            return this.SelectSqlData(ds, dt, withGetSqlPermission, where, new TimeSpan(0, 0, CommandTimeout));
        }

        public bool SelectSqlData(DataSet ds, DataTable dt, bool withGetSqlPermission, string where)
        {
            return this.SelectSqlData(ds, dt.TableName, withGetSqlPermission, where);
        }

        public bool SelectSqlDataTableOther(DataSet ds, string tableName, string tableNameSql, bool withGetSqlPermission, string where, int countRows, bool distinct)
        {
            DataTable dataTable;
            if (withGetSqlPermission)
            {
                dataTable = this.GetSqlPermissions(new string[]
                {
                    tableNameSql
                });
            }
            else
            {
                dataTable = new DataTable();
            }
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            try
            {
                string textSelect;
                if (countRows < 0)
                {
                    textSelect = "select " + (distinct ? "distinct " : "");
                }
                else
                {
                    textSelect = string.Concat(new string[]
                    {
                            "select ",
                            distinct ? "distinct " : "",
                            "top ",
                            countRows.ToString(),
                            " "
                    });
                }
                if (withGetSqlPermission)
                {
                    foreach (DataRow dataRow in dataTable.Select("Operation = 'select'"))
                    {
                        if (ds.Tables[tableName] != null && ds.Tables[tableName].Columns.Count > 0)
                        {
                            if (ds.Tables[tableName].Columns.Contains(dataRow["ColumnName"].ToString()))
                            {
                                textSelect = string.Concat(new object[]
                                {
                            textSelect,
                            "[",
                            tableNameSql,
                            "].[",
                            dataRow["ColumnName"],
                            "], "
                                });
                            }
                        }
                        else
                        {
                            textSelect = string.Concat(new object[]
                            {
                                    textSelect,
                                    "[",
                                    tableNameSql,
                                    "].[",
                                    dataRow["ColumnName"],
                                    "], "
                            });
                        }
                    }
                    if (textSelect.Length <= 0)
                    {
                        MessageBox.Show("Не определены столбцы для выборки");
                        return false;
                    }
                    textSelect = textSelect.Remove(textSelect.LastIndexOf(", "));
                }
                else
                {
                    textSelect += " * ";
                }
                textSelect = textSelect + " from " + tableNameSql + " ";
                textSelect += where;
                if (ds.Tables[tableName] != null)
                {
                    ds.Tables[tableName].Clear();
                }
                sqlDataConnect.OpenConnection(this.SqlSettings);
                new SqlDataAdapter(textSelect, sqlDataConnect.Connection).Fill(ds, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return false;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }

        public bool SelectSqlDataTableOther(DataSet ds, DataTable dt, string tableNameSql, bool withGetSqlPermission, string where)
        {
            return this.SelectSqlDataTableOther(ds, dt.TableName, tableNameSql, withGetSqlPermission, where, -1, false);
        }

        public DataTable SelectSqlData(string tableName, bool withGetSqlPermission, string where)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable(tableName);
            dataSet.Tables.Add(dataTable);
            if (this.SelectSqlData(dataSet, dataTable, withGetSqlPermission, where))
            {
                return dataSet.Tables[tableName];
            }
            return dataTable;
        }

        public DataTable GetSqlPermissions(string[] tableNames)
        {
            string PermissionsTable = "dbo.GetPermissionsTable";
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("TableName", typeof(string));
            dataTable.Columns.Add("ColumnName", typeof(string));
            dataTable.Columns.Add("Operation", typeof(string));
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            DataTable result;
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                for (int i = 0; i < tableNames.Length; i++)
                {
                    SqlDataReader sqlDataReader = new SqlCommand(string.Concat(new string[]
                    {
                "select ColumnName from ",
                PermissionsTable,
                "('",
                tableNames[i],
                "', 'select', 1)"
                    }), sqlDataConnect.Connection).ExecuteReader();
                    new ArrayList();
                    while (sqlDataReader.Read())
                    {
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["TableName"] = tableNames[i].ToUpper();
                        dataRow["ColumnName"] = sqlDataReader[0].ToString().ToUpper();
                        dataRow["Operation"] = "Select";
                        dataTable.Rows.Add(dataRow);
                    }
                    sqlDataReader.Close();
                    sqlDataReader = new SqlCommand(string.Concat(new string[]
                    {
                "select ColumnName from ",
                PermissionsTable,
                "('",
                tableNames[i],
                "', 'update', 1)"
                    }), sqlDataConnect.Connection).ExecuteReader();
                    new ArrayList();
                    while (sqlDataReader.Read())
                    {
                        DataRow dataRow2 = dataTable.NewRow();
                        dataRow2["TableName"] = tableNames[i].ToUpper();
                        dataRow2["ColumnName"] = sqlDataReader[0].ToString().ToUpper();
                        dataRow2["Operation"] = "update";
                        dataTable.Rows.Add(dataRow2);
                    }
                    sqlDataReader.Close();
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно получить SQL-права\n" + ex.Message, ex.Source);
                result = null;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return result;
        }

        public bool InsertSqlData(DataSet ds, DataTable dt)
        {
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                DataTable changes = dt.GetChanges(DataRowState.Added);
                if (changes == null || changes.Rows.Count == 0)
                {
                    return true;
                }
                DataColumn[] primaryKey = dt.PrimaryKey;
                string text = " values (";
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayList.Add(primaryKey[i].ColumnName);
                }
                string text2 = "insert into " + dt.TableName + "( ";
                ArrayList arrayList2 = new ArrayList();
                int num = 0;
                foreach (object obj in dt.Columns)
                {
                    DataColumn dataColumn = (DataColumn)obj;
                    if (!dataColumn.AutoIncrement)
                    {
                        arrayList2.Add(dataColumn.ColumnName);
                        string str = text;
                        string str2 = "@param";
                        int num2 = num;
                        num = num2 + 1;
                        text = str + str2 + num2.ToString() + ", ";
                        text2 = text2 + "[" + dataColumn.ColumnName + "], ";
                    }
                    else
                    {
                        arrayList2.Remove(dataColumn.ColumnName);
                    }
                }
                text = text.Remove(text.LastIndexOf(", ")) + ") ";
                text2 = text2.Remove(text2.LastIndexOf(", ")) + ") ";
                text2 += text;
                foreach (object obj2 in changes.Rows)
                {
                    DataRow dataRow = (DataRow)obj2;
                    SqlCommand sqlCommand = new SqlCommand(text2, sqlDataConnect.Connection);
                    for (int j = 0; j < arrayList2.Count; j++)
                    {
                        Type dataType = dt.Columns[arrayList2[j].ToString()].DataType;
                        SqlParameter sqlParameter;
                        if (dataType == typeof(byte[]))
                        {
                            sqlParameter = new SqlParameter("@param" + j.ToString(), SqlDbType.Binary);
                        }
                        else
                        {
                            sqlParameter = new SqlParameter("@param" + j.ToString(), dataType);
                        }
                        sqlParameter.SqlValue = dataRow[arrayList2[j].ToString()];
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return false;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }

        public bool InsertSqlDataTableOther(DataSet ds, DataTable dt, string tableNameSql = "")
        {
            if (tableNameSql == String.Empty) tableNameSql = dt.TableName;
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                DataTable changes = ds.Tables[dt.TableName].GetChanges(DataRowState.Added);
                if (changes == null || changes.Rows.Count == 0)
                {
                    return true;
                }
                DataColumn[] primaryKey = ds.Tables[dt.TableName].PrimaryKey;
                string textValues = " values (";
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayList.Add(primaryKey[i].ColumnName);
                }
                string textInsert = "insert into " + tableNameSql + "( ";
                ArrayList arrayList2 = new ArrayList();
                int num = 0;
                foreach (object obj in ds.Tables[dt.TableName].Columns)
                {
                    DataColumn dataColumn = (DataColumn)obj;
                    if (arrayList.BinarySearch(dataColumn.ColumnName) < 0)
                    {
                        arrayList2.Add(dataColumn.ColumnName);
                        string strValue = textValues;
                        string strParam = "@param";
                        int num2 = num;
                        num = num2 + 1;
                        textValues = strValue + strParam + num2.ToString() + ", ";
                        textInsert = textInsert + "[" + dataColumn.ColumnName + "], ";
                    }
                    else
                    {
                        arrayList2.Remove(dataColumn.ColumnName);
                    }
                }
                textValues = textValues.Remove(textValues.LastIndexOf(", ")) + ") ";
                textInsert = textInsert.Remove(textInsert.LastIndexOf(", ")) + ") ";
                textInsert += textValues;
                foreach (object obj2 in changes.Rows)
                {
                    DataRow dataRow = (DataRow)obj2;
                    SqlCommand sqlCommand = new SqlCommand(textInsert, sqlDataConnect.Connection);
                    for (int j = 0; j < arrayList2.Count; j++)
                    {
                        Type dataType = ds.Tables[dt.TableName].Columns[arrayList2[j].ToString()].DataType;
                        SqlParameter sqlParameter;
                        if (dataType == typeof(byte[]))
                        {
                            sqlParameter = new SqlParameter("@param" + j.ToString(), SqlDbType.Binary);
                        }
                        else
                        {
                            sqlParameter = new SqlParameter("@param" + j.ToString(), dataType);
                        }
                        sqlParameter.SqlValue = dataRow[arrayList2[j].ToString()];
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return false;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }

        public int InsertSqlDataOneRowTableOther(DataSet ds, DataTable dt, string tableNameSql = "")
        {
            if (tableNameSql == String.Empty) tableNameSql = dt.TableName;
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            int result = -1;
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                SqlTransaction sqlTransaction = sqlDataConnect.Connection.BeginTransaction();
                DataTable changes = ds.Tables[dt.TableName].GetChanges(DataRowState.Added);
                if (changes == null || changes.Rows.Count == 0)
                {
                    return -1;
                }
                DataColumn[] primaryKey = ds.Tables[dt.TableName].PrimaryKey;
                string textValues = " values (";
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayList.Add(primaryKey[i].ColumnName);
                }
                string textInsert = "insert into " + tableNameSql + "( ";
                ArrayList arrayList2 = new ArrayList();
                int num = 0;
                foreach (object obj in ds.Tables[dt.TableName].Columns)
                {
                    DataColumn dataColumn = (DataColumn)obj;
                    if (arrayList.BinarySearch(dataColumn.ColumnName) < 0)
                    {
                        arrayList2.Add(dataColumn.ColumnName);
                        string strValues = textValues;
                        string strParam = "@param";
                        int num2 = num;
                        num = num2 + 1;
                        textValues = strValues + strParam + num2.ToString() + ", ";
                        textInsert = textInsert + "[" + dataColumn.ColumnName + "], ";
                    }
                    else
                    {
                        arrayList2.Remove(dataColumn.ColumnName);
                    }
                }
                textValues = textValues.Remove(textValues.LastIndexOf(", ")) + ") ";
                textInsert = textInsert.Remove(textInsert.LastIndexOf(", ")) + ") ";
                textInsert += textValues;
                SqlCommand sqlCommand = new SqlCommand(textInsert, sqlDataConnect.Connection);
                sqlCommand.Transaction = sqlTransaction;
                for (int j = 0; j < arrayList2.Count; j++)
                {
                    Type dataType = ds.Tables[dt.TableName].Columns[arrayList2[j].ToString()].DataType;
                    SqlParameter sqlParameter;
                    if (dataType == typeof(byte[]))
                    {
                        sqlParameter = new SqlParameter("@param" + j.ToString(), SqlDbType.Binary);
                    }
                    else
                    {
                        sqlParameter = new SqlParameter("@param" + j.ToString(), dataType);
                    }
                    sqlParameter.SqlValue = changes.Rows[0][arrayList2[j].ToString()];
                    sqlCommand.Parameters.Add(sqlParameter);
                }
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "select IDENT_CURRENT('" + tableNameSql + "')";
                result = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return -1;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return result;
        }

        public bool InsertSqlData(DataTable dt)
        {
            return InsertSqlData(dt, true);
        }

        /// <summary>
        /// Обновить (Вставить записи в базу данных)
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="isChekAutoIncrement">если False  то не проверяем автоинкрементность при формировании строки</param>
        /// <returns></returns>
        public bool InsertSqlData(DataTable dt, bool isChekAutoIncrement = true)
        {
            DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                DataTable changes = dt.GetChanges(DataRowState.Added);
                if (changes == null || changes.Rows.Count == 0)
                {
                    bool result = true;
                    return result;
                }
                DataColumn[] primaryKey = dt.PrimaryKey;
                string textValues = " values (";
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayList.Add(primaryKey[i].ColumnName);
                }
                string textBegin = "insert into " + dt.TableName + "( ";
                ArrayList arrayListColumn = new ArrayList();
                int num = 0;
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    if (!dataColumn.AutoIncrement || isChekAutoIncrement == false)
                    {
                        arrayListColumn.Add(dataColumn.ColumnName);
                        string sqlParameter = "@param";
                        int Ordinal = num;
                        num = Ordinal + 1;
                        textValues = textValues + sqlParameter + Ordinal.ToString() + ", ";
                        textBegin = textBegin + "[" + dataColumn.ColumnName + "], ";
                    }
                    else
                    {
                        arrayListColumn.Remove(dataColumn.ColumnName);
                    }
                }
                textValues = textValues.Remove(textValues.LastIndexOf(", ")) + ") ";
                textBegin = textBegin.Remove(textBegin.LastIndexOf(", ")) + ") ";
                textBegin += textValues;
                foreach (DataRow dataRow in changes.Rows)
                {
                    SqlCommand sqlCommand = new SqlCommand(textBegin, sqlDataConnect.Connection);
                    for (int j = 0; j < arrayListColumn.Count; j++)
                    {
                        Type dataType = dt.Columns[arrayListColumn[j].ToString()].DataType;
                        SqlParameter sqlParameter;
                        if (dataType == typeof(byte[]))
                        {
                            sqlParameter = new SqlParameter("@param" + j.ToString(), SqlDbType.Binary);
                        }
                        else
                        {
                            sqlParameter = new SqlParameter("@param" + j.ToString(), dataType);
                        }
                        sqlParameter.SqlValue = dataRow[arrayListColumn[j].ToString()];
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                bool result = false;
                return result;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }

        public bool UpdateSqlData(DataSet ds, DataTable dt)
        {
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                DataTable changes = ds.Tables[dt.TableName].GetChanges(DataRowState.Modified);
                if (changes == null || changes.Rows.Count == 0)
                {
                    return true;
                }
                DataColumn[] primaryKey = ds.Tables[dt.TableName].PrimaryKey;
                string text = " where ";
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayList.Add(primaryKey[i].ColumnName);
                    text = string.Concat(new string[]
                    {
                text,
                "[",
                primaryKey[i].ColumnName,
                "] = @paramPrimary",
                i.ToString(),
                " and "
                    });
                }
                string text2 = "update " + dt.TableName + " set ";
                ArrayList arrayList2 = new ArrayList();
                int num = 0;
                foreach (object obj in ds.Tables[dt.TableName].Columns)
                {
                    DataColumn dataColumn = (DataColumn)obj;
                    if (arrayList.BinarySearch(dataColumn.ColumnName) < 0)
                    {
                        if (!dataColumn.ReadOnly)
                        {
                            arrayList2.Add(dataColumn.ColumnName);
                            string[] array = new string[6];
                            array[0] = text2;
                            array[1] = "[";
                            array[2] = dataColumn.ColumnName;
                            array[3] = "] = @param";
                            int num2 = 4;
                            int num3 = num;
                            num = num3 + 1;
                            array[num2] = num3.ToString();
                            array[5] = ", ";
                            text2 = string.Concat(array);
                        }
                    }
                    else
                    {
                        arrayList2.Remove(dataColumn.ColumnName);
                    }
                }
                text = text.Remove(text.LastIndexOf(" and "));
                text2 = text2.Remove(text2.LastIndexOf(", "));
                text2 += text;
                foreach (object obj2 in changes.Rows)
                {
                    DataRow dataRow = (DataRow)obj2;
                    SqlCommand sqlCommand = new SqlCommand(text2, sqlDataConnect.Connection);
                    for (int j = 0; j < arrayList.Count; j++)
                    {
                        SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), ds.Tables[dt.TableName].Columns[arrayList[j].ToString()].DataType);
                        sqlParameter.SqlValue = dataRow[arrayList[j].ToString()];
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    for (int k = 0; k < arrayList2.Count; k++)
                    {
                        Type dataType = ds.Tables[dt.TableName].Columns[arrayList2[k].ToString()].DataType;
                        SqlParameter sqlParameter2;
                        if (dataType == typeof(byte[]))
                        {
                            sqlParameter2 = new SqlParameter("@param" + k.ToString(), SqlDbType.Binary);
                        }
                        else
                        {
                            sqlParameter2 = new SqlParameter("@param" + k.ToString(), dataType);
                        }
                        sqlParameter2.SqlValue = dataRow[arrayList2[k].ToString()];
                        sqlCommand.Parameters.Add(sqlParameter2);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return false;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }

        public bool UpdateSqlDataTableOther(DataSet ds, DataTable dt, string tableNameSql = "")
        {
            if (tableNameSql == String.Empty) tableNameSql = dt.TableName;
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                DataTable changes = ds.Tables[dt.TableName].GetChanges(DataRowState.Modified);
                if (changes == null || changes.Rows.Count == 0)
                {
                    return true;
                }
                DataColumn[] primaryKey = ds.Tables[dt.TableName].PrimaryKey;
                string textWhere = " where ";
                ArrayList arrayListPrimaryKey = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayListPrimaryKey.Add(primaryKey[i].ColumnName);
                    textWhere = string.Concat(new string[]
                    {
                            textWhere,
                            "[",
                            primaryKey[i].ColumnName,
                            "] = @paramPrimary",
                            i.ToString(),
                            " and "
                                });
                }
                string textUpdate = "update " + tableNameSql + " set ";
                ArrayList arrayListColumn = new ArrayList();
                int num = 0;
                foreach (DataColumn dataColumn in ds.Tables[dt.TableName].Columns)
                {
                    if (arrayListPrimaryKey.BinarySearch(dataColumn.ColumnName) < 0)
                    {
                        arrayListColumn.Add(dataColumn.ColumnName);
                        string[] arrayValue = new string[6];
                        arrayValue[0] = textUpdate;
                        arrayValue[1] = "[";
                        arrayValue[2] = dataColumn.ColumnName;
                        arrayValue[3] = "] = @param";
                        int num2 = 4;
                        int num3 = num;
                        num = num3 + 1;
                        arrayValue[num2] = num3.ToString();
                        arrayValue[5] = ", ";
                        textUpdate = string.Concat(arrayValue);
                    }
                    else
                    {
                        arrayListColumn.Remove(dataColumn.ColumnName);
                    }
                }
                textWhere = textWhere.Remove(textWhere.LastIndexOf(" and "));
                textUpdate = textUpdate.Remove(textUpdate.LastIndexOf(", "));
                textUpdate += textWhere;
                foreach (object obj2 in changes.Rows)
                {
                    DataRow dataRow = (DataRow)obj2;
                    SqlCommand sqlCommand = new SqlCommand(textUpdate, sqlDataConnect.Connection);
                    for (int j = 0; j < arrayListPrimaryKey.Count; j++)
                    {
                        SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), ds.Tables[dt.TableName].Columns[arrayListPrimaryKey[j].ToString()].DataType);
                        sqlParameter.SqlValue = dataRow[arrayListPrimaryKey[j].ToString()];
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    for (int k = 0; k < arrayListColumn.Count; k++)
                    {
                        Type dataType = ds.Tables[dt.TableName].Columns[arrayListColumn[k].ToString()].DataType;
                        SqlParameter sqlParameter2;
                        if (dataType == typeof(byte[]))
                        {
                            sqlParameter2 = new SqlParameter("@param" + k.ToString(), SqlDbType.Binary);
                        }
                        else
                        {
                            sqlParameter2 = new SqlParameter("@param" + k.ToString(), dataType);
                        }
                        sqlParameter2.SqlValue = dataRow[arrayListColumn[k].ToString()];
                        sqlCommand.Parameters.Add(sqlParameter2);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return false;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }

        public bool UpdateSqlData(DataTable dt)
        {
            DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                DataTable changes = dt.GetChanges(DataRowState.Modified);
                if (changes == null || changes.Rows.Count == 0)
                {
                    bool result = true;
                    return result;
                }
                DataColumn[] primaryKey = dt.PrimaryKey;
                string textWhere = " where ";
                ArrayList arrayPrimaryKey = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayPrimaryKey.Add(primaryKey[i].ColumnName);
                    textWhere = string.Concat(new string[] { textWhere, "[", primaryKey[i].ColumnName, "] = @paramPrimary", i.ToString(), " and " });
                }
                string textUpdate = "update " + dt.TableName + " set ";
                ArrayList arrayListColumn = new ArrayList();
                int num = 0;
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    if (arrayPrimaryKey.BinarySearch(dataColumn.ColumnName) < 0)
                    {
                        if (!dataColumn.ReadOnly)
                        {
                            arrayListColumn.Add(dataColumn.ColumnName);
                            int num2 = num;
                            num = num2 + 1;
                            textUpdate = string.Concat(new string[] { textUpdate, "[", dataColumn.ColumnName, "] = @param", num2.ToString(), ", " });
                        }
                    }
                    else
                    {
                        arrayListColumn.Remove(dataColumn.ColumnName);
                    }
                }
                textWhere = textWhere.Remove(textWhere.LastIndexOf(" and "));
                textUpdate = textUpdate.Remove(textUpdate.LastIndexOf(", "));
                textUpdate += textWhere;
                foreach (DataRow dataRow in changes.Rows)
                {
                    SqlCommand sqlCommand = new SqlCommand(textUpdate, sqlDataConnect.Connection);
                    for (int j = 0; j < arrayPrimaryKey.Count; j++)
                    {
                        SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), dt.Columns[arrayPrimaryKey[j].ToString()].DataType);
                        sqlParameter.SqlValue = dataRow[arrayPrimaryKey[j].ToString(), DataRowVersion.Original];
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    for (int k = 0; k < arrayListColumn.Count; k++)
                    {
                        Type dataType = dt.Columns[arrayListColumn[k].ToString()].DataType;
                        SqlParameter sqlParameter2;
                        if (dataType == typeof(byte[]))
                        {
                            sqlParameter2 = new SqlParameter("@param" + k.ToString(), SqlDbType.Binary);
                        }
                        else
                        {
                            sqlParameter2 = new SqlParameter("@param" + k.ToString(), dataType);
                        }
                        sqlParameter2.SqlValue = dataRow[arrayListColumn[k].ToString()];
                        sqlCommand.Parameters.Add(sqlParameter2);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                bool result = false;
                return result;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }

        public bool DeleteSqlData(DataSet ds, DataTable dt)
        {
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                DataTable changes = ds.Tables[dt.TableName].GetChanges(DataRowState.Deleted);
                if (changes == null || changes.Rows.Count == 0)
                {
                    return true;
                }
                DataColumn[] primaryKey = ds.Tables[dt.TableName].PrimaryKey;
                string textWhere = " where ";
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayList.Add(primaryKey[i].ColumnName);
                    textWhere = string.Concat(new string[]
                    {
                                textWhere,
                                primaryKey[i].ColumnName,
                                " = @paramPrimary",
                                i.ToString(),
                                " and "
                    });
                }
                string textDelete = "delete " + dt.TableName + " ";
                textWhere = textWhere.Remove(textWhere.LastIndexOf(" and "));
                textDelete += textWhere;
                foreach (object obj in changes.Rows)
                {
                    DataRow dataRow = (DataRow)obj;
                    SqlCommand sqlCommand = new SqlCommand(textDelete, sqlDataConnect.Connection);
                    for (int j = 0; j < arrayList.Count; j++)
                    {
                        SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), ds.Tables[dt.TableName].Columns[arrayList[j].ToString()].DataType);
                        sqlParameter.SqlValue = dataRow[arrayList[j].ToString(), DataRowVersion.Original];
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return false;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }

        public bool DeleteSqlDataTableOther(DataSet ds, DataTable dt, string tableNameSql = "")
        {
            if (tableNameSql == String.Empty) tableNameSql = dt.TableName;
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                DataTable changes = ds.Tables[dt.TableName].GetChanges(DataRowState.Deleted);
                if (changes == null || changes.Rows.Count == 0)
                {
                    return true;
                }
                DataColumn[] primaryKey = ds.Tables[dt.TableName].PrimaryKey;
                string textWhere = " where ";
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayList.Add(primaryKey[i].ColumnName);
                    textWhere = string.Concat(new string[]
                    {
                                textWhere,
                                primaryKey[i].ColumnName,
                                " = @paramPrimary",
                                i.ToString(),
                                " and "
                    });
                }
                string textDelete = "delete " + tableNameSql + " ";
                textWhere = textWhere.Remove(textWhere.LastIndexOf(" and "));
                textDelete += textWhere;
                foreach (object obj in changes.Rows)
                {
                    DataRow dataRow = (DataRow)obj;
                    SqlCommand sqlCommand = new SqlCommand(textDelete, sqlDataConnect.Connection);
                    for (int j = 0; j < arrayList.Count; j++)
                    {
                        SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), ds.Tables[dt.TableName].Columns[arrayList[j].ToString()].DataType);
                        sqlParameter.SqlValue = dataRow[arrayList[j].ToString(), DataRowVersion.Original];
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return false;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }
    }
    /// <summary>
    /// команды для работы с PostgreSQL (PostGIS)
    /// </summary>
    public class pSQL
    {
        /// <summary>
        /// Идентификатор пространственной привязки
        /// </summary>
        public int SRID { get; set; } = 4326;
        public string connectionString { get;  set; }
        public bool showMessageBox { get;  set; }
        /// <summary>
        /// Экспорт с формированием координат (точка);
        /// в исходной таблице колонки геометерии (geom) нет;
        /// создаем потом
        /// </summary>
        /// <param name="tableIn"></param>
        /// <param name="chemaOUT"></param>
        /// <param name="tableOUT"></param>
        /// <param name="longitude">Колонка определяющая долготу</param>
        /// <param name="latitude">Колонка определяющая широту</param>
        /// <param name="isUpdate">Обновлять или удалять данные</param>
        /// <returns></returns>
        public bool ExportSqlData(DataTable tableIn, string chemaOUT, string tableOUT, string longitude, string latitude)
        {
            bool result = true;
            
            // проверка на вставку геометрии
            // в исходной таблице колонки геометерии (geom) нет 
            bool isGeom = false;
            string ColumnsGeom = "geom";
            string paramX=""; string paramY="";
            if (longitude != String.Empty && latitude != String.Empty) isGeom = true;

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            try
            {
                // 1. параметрическая строка для выборки и обновления
                DataColumn[] primaryKey = tableIn.PrimaryKey;
                string textWhere = " where ";
                ArrayList arrayListPrimaryKey = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayListPrimaryKey.Add(primaryKey[i].ColumnName);
                    textWhere += "\"" + primaryKey[i].ColumnName + "\" = @paramPrimary" + i.ToString() + " and ";
                }
                if (textWhere.LastIndexOf(" and ") >= 0)
                {
                    textWhere = textWhere.Remove(textWhere.LastIndexOf(" and "));
                }
                
                // 2. параметрическая строка для вставки 
                ArrayList arrayListColumns = new ArrayList();
                string listColumns = "";
                string listValues = "";
                foreach (DataColumn item in tableIn.Columns)
                {
                    arrayListColumns.Add(item.ColumnName);
                    listValues = listValues + "@param" + item.Ordinal.ToString() + ", ";
                    listColumns += "\"" + item.ColumnName + "\", ";
                    if (isGeom)
                        {
                        if (item.ColumnName == longitude) paramX = "@param" + item.Ordinal.ToString();
                        if (item.ColumnName == latitude) paramY = "@param" + item.Ordinal.ToString();
                    }
                }
                if (isGeom)
                {
                    listValues += $"ST_SetSRID(ST_MakePoint({paramX}, {paramY}), {SRID})";
                    listColumns += "\"" + ColumnsGeom + "\" ";
                }
                else
                {
                    listValues = listValues.Remove(listValues.LastIndexOf(", "));
                    listColumns = listColumns.Remove(listColumns.LastIndexOf(", "));
                }
                
                // 3. параметрическая строка для обновления
                ArrayList arrayListSet = new ArrayList();
                foreach (DataColumn item in tableIn.Columns)
                {
                    if (arrayListPrimaryKey.BinarySearch(item.ColumnName) < 0)
                    {
                        if (!item.ReadOnly)
                        {
                            arrayListSet.Add(item.ColumnName);
                        }
                    }
                    else
                    {
                        arrayListSet.Remove(item.ColumnName);
                    }
                }
                
                // 4. обработка данных
                foreach (DataRow dataRow in tableIn.Rows)
                {
                    bool isUpdate = false;
                    // проверим, есть ли запись заданным ид
                    // если ид нет, то добавим запись
                    DataTable dtResult = new DataTable();
                    NpgsqlCommand sqlCommand = conn.CreateCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    using (NpgsqlDataAdapter daPSQL = new NpgsqlDataAdapter())
                    {
                        for (int j = 0; j < arrayListPrimaryKey.Count; j++)
                        {
                            DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListPrimaryKey[j].ToString()].DataType);
                            NpgsqlParameter sqlParameter = new NpgsqlParameter("@paramPrimary" + j.ToString(), dataType);
                            sqlParameter.Value = dataRow[arrayListPrimaryKey[j].ToString()];
                            sqlCommand.Parameters.Add(sqlParameter);
                        }
                        string sqlSelect = "SELECT * FROM  \"" + chemaOUT + "\".\"" + tableOUT + "\"";
                        sqlSelect += textWhere;
                        sqlCommand.CommandText = sqlSelect;

                        daPSQL.SelectCommand = sqlCommand;
                        daPSQL.Fill(dtResult);

                        if (dtResult.Rows.Count != 0) isUpdate = true;
                    }

                    if (isUpdate)
                    {
                        string sqlUpdate = "update \"" + chemaOUT + "\".\"" + tableOUT + "\" set ";
                        //for (int j = 0; j < arrayListPrimaryKey.Count; j++)
                        //{
                        //    DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListPrimaryKey[j].ToString()].DataType);
                        //    NpgsqlParameter sqlParameter = new NpgsqlParameter("@paramPrimary" + j.ToString(), dataType);
                        //    sqlParameter.Value = dataRow[arrayListPrimaryKey[j].ToString()];
                        //    sqlCommand.Parameters.Add(sqlParameter);
                        //}
                        for (int k = 0; k < arrayListSet.Count; k++)
                        {
                            sqlUpdate += $"\"{arrayListSet[k]}\" = @param{k.ToString()}, ";

                            DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListSet[k].ToString()].DataType);
                            NpgsqlParameter sqlParameter2 = new NpgsqlParameter("@param" + k.ToString(), dataType);

                            sqlParameter2.Value = dataRow[arrayListSet[k].ToString()];
                            sqlCommand.Parameters.Add(sqlParameter2);
                            if (isGeom)
                            {
                                if (arrayListSet[k].ToString() == longitude) paramX = "@param" + k.ToString();
                                if (arrayListSet[k].ToString() == latitude) paramY = "@param" + k.ToString();
                            }
                        }

                        if (sqlUpdate.LastIndexOf(", ") >= 0)
                        {
                            sqlUpdate = sqlUpdate.Remove(sqlUpdate.LastIndexOf(", "));
                        }
                        if (isGeom)
                        {
                            sqlUpdate += $", \"{ColumnsGeom}\" =  ST_SetSRID(ST_MakePoint({paramX}, {paramY}), {SRID})";
                        }
                        sqlUpdate += textWhere;
                        sqlCommand.CommandText = sqlUpdate;
                    }
                    else
                    {
                        string sqlINSERT = "INSERT INTO \"" + chemaOUT + "\".\"" + tableOUT + "\" (" + listColumns + ") VALUES (" + listValues + ")";
                        sqlCommand.CommandText = sqlINSERT;
                        NpgsqlParameter sqlParameter;
                        for (int j = 0; j < arrayListColumns.Count; j++)
                        {
                            DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListColumns[j].ToString()].DataType);
                            sqlParameter = new NpgsqlParameter("@param" + j.ToString(), dataType);
                            sqlParameter.Value = dataRow[arrayListColumns[j].ToString()];

                            sqlCommand.Parameters.Add(sqlParameter);
                        }
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                if (showMessageBox)
                    MessageBox.Show(ex.Message, ex.Source);
                else
                    Log.Write(Logger.LogLevel.Error, "LibraryTSQL", "pSQL", "ExportSqlData: " + tableOUT, ex.Message, null);
                result = false;
            }
            finally
            {
                conn.Close();
            }

            //if (isUpdate)
            //{
            //    DataColumn[] primaryKey = tableIn.PrimaryKey;
            //    string textWhere = " where ";
            //    ArrayList arrayListPrimaryKey = new ArrayList();
            //    for (int i = 0; i < primaryKey.Length; i++)
            //    {
            //        arrayListPrimaryKey.Add(primaryKey[i].ColumnName);
            //        textWhere += "[" + primaryKey[i].ColumnName + "] = @paramPrimary" + i.ToString() + " and ";
            //    }
            //    if (textWhere.LastIndexOf(" and ") >= 0)
            //    {
            //        textWhere = textWhere.Remove(textWhere.LastIndexOf(" and "));
            //    }
            //    ArrayList arrayListSet = new ArrayList();
            //    foreach (DataColumn dataColumn in tableIn.Columns)
            //    {
            //        if (arrayListPrimaryKey.BinarySearch(dataColumn.ColumnName) < 0)
            //        {
            //            if (!dataColumn.ReadOnly)
            //            {
            //                arrayListSet.Add(dataColumn.ColumnName);
            //            }
            //        }
            //        else
            //        {
            //            arrayListSet.Remove(dataColumn.ColumnName);
            //        }
            //    }
            //    try
            //    {
            //        foreach (DataRow dataRow in tableIn.Rows)
            //        {
            //            string sqlUpdate = "update \"" + chemaOUT + "\".\"" + tableOUT + "\" set ";
            //            //string textUpdate = "update [" + dt.TableName + "] set ";
            //            NpgsqlCommand sqlCommand = conn.CreateCommand();

            //            for (int j = 0; j < arrayListPrimaryKey.Count; j++)
            //            {
            //                DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListPrimaryKey[j].ToString()].DataType);
            //                NpgsqlParameter sqlParameter = new NpgsqlParameter("@paramPrimary" + j.ToString(), dataType);
            //                sqlParameter.Value = dataRow[arrayListPrimaryKey[j].ToString()];
            //                sqlCommand.Parameters.Add(sqlParameter);
            //            }
            //            for (int k = 0; k < arrayListSet.Count; k++)
            //            {
            //                sqlUpdate += $"[{arrayListSet[k]}] = @param{k.ToString()}, ";

            //                DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListSet[k].ToString()].DataType);
            //                NpgsqlParameter sqlParameter2 = new NpgsqlParameter("@param" + k.ToString(), dataType);

            //                sqlParameter2.Value = dataRow[arrayListSet[k].ToString()];
            //                sqlCommand.Parameters.Add(sqlParameter2);
            //            }
            //            if (sqlUpdate.LastIndexOf(", ") >= 0)
            //            {
            //                sqlUpdate = sqlUpdate.Remove(sqlUpdate.LastIndexOf(", "));
            //            }
            //            sqlUpdate += textWhere;
            //            sqlCommand.CommandType = CommandType.Text;
            //            sqlCommand.CommandText = sqlUpdate;
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //        return true;
            //    }
            //    catch (NpgsqlException ex)
            //    {
            //        if (showMessageBox)
            //            MessageBox.Show(ex.Message, ex.Source);
            //        else
            //            Log.Write(Logger.LogLevel.Error, "LibraryTSQL", "pSQL", "ExportSqlData (Update Point): " + tableOUT, ex.Message, null);
            //        result = false;
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //}
            //else
            //{
            //    ArrayList arrayListColumns = new ArrayList();
            //    string listColumns = "";
            //    string listValues = "";
            //    foreach (DataColumn item in tableIn.Columns)
            //    {
            //        arrayListColumns.Add(item.ColumnName);
            //        listValues = listValues + "@param" + item.Ordinal.ToString() + ", ";
            //        listColumns += "\"" + item.ColumnName + "\", ";
            //        if (isGeom)
            //        {
            //            if (item.ColumnName == longitude) paramX = "@param" + item.Ordinal.ToString();
            //            if (item.ColumnName == latitude) paramY = "@param" + item.Ordinal.ToString();
            //        }
            //    }
            //    if (isGeom)
            //    {
            //        listValues += $"ST_SetSRID(ST_MakePoint({paramX}, {paramY}), {SRID})";
            //        listColumns += "\"" + ColumnsGeom + "\" ";
            //    }
            //    else
            //    {
            //        listValues = listValues.Remove(listValues.LastIndexOf(", "));
            //        listColumns = listColumns.Remove(listColumns.LastIndexOf(", "));
            //    }
            //    string sqlINSERT = "INSERT INTO \"" + chemaOUT + "\".\"" + tableOUT + "\" (" + listColumns + ") VALUES (" + listValues + ")";

            //    try
            //    {
            //        foreach (DataRow row in tableIn.Rows)
            //        {
            //            NpgsqlCommand sqlCommand = conn.CreateCommand();
            //            sqlCommand.CommandType = CommandType.Text;
            //            sqlCommand.CommandText = sqlINSERT;
            //            NpgsqlParameter sqlParameter;
            //            for (int j = 0; j < arrayListColumns.Count; j++)
            //            {
            //                DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListColumns[j].ToString()].DataType);
            //                sqlParameter = new NpgsqlParameter("@param" + j.ToString(), dataType);
            //                sqlParameter.Value = row[arrayListColumns[j].ToString()];

            //                sqlCommand.Parameters.Add(sqlParameter);
            //            }
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //        return true;
            //    }
            //    catch (NpgsqlException ex)
            //    {
            //        if (showMessageBox)
            //            MessageBox.Show(ex.Message, ex.Source);
            //        else
            //            Log.Write(Logger.LogLevel.Error, "LibraryTSQL", "pSQL", "ExportSqlData (Insert Point): " + tableOUT, ex.Message, null);
            //        result = false;
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //}

            return result;
        }
        public bool ExportSqlData(DataTable tableIn, string chemaOUT, string tableOUT)
        {
            bool result = true;
            ArrayList arrayListColumns = new ArrayList();
            string listColumns = "";
            string textValues = "";

            foreach (DataColumn item in tableIn.Columns)
            {
                arrayListColumns.Add(item.ColumnName);
                textValues = textValues + "@param" + item.Ordinal.ToString() + ", ";
                listColumns += "\"" + item.ColumnName + "\", ";
            }
            textValues = textValues.Remove(textValues.LastIndexOf(", "));
            listColumns = listColumns.Remove(listColumns.LastIndexOf(", "));
            string sqlI = "INSERT INTO \"" + chemaOUT + "\".\"" + tableOUT + "\" (" + listColumns + ") VALUES (" + textValues + ")";

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();

            try
            {
                foreach (DataRow row in tableIn.Rows)
                {
                    NpgsqlCommand sqlCommand = conn.CreateCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = sqlI;
                    NpgsqlParameter sqlParameter;
                    for (int j = 0; j < arrayListColumns.Count; j++)
                    {
                        DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListColumns[j].ToString()].DataType);
                        sqlParameter = new NpgsqlParameter("@param" + j.ToString(), dataType);
                        sqlParameter.Value = row[arrayListColumns[j].ToString()];

                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (NpgsqlException ex)
            {
                if (showMessageBox)
                    MessageBox.Show(ex.Message, ex.Source);
                else
                    Log.Write(Logger.LogLevel.Error, "LibraryTSQL", "pSQL", "ExportSqlData: " + tableOUT, ex.Message, null);
                result = false;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public class Geom
        {
            string ColumnName { get; set; } = "geom";
            string Value { get; set; }
        }
        /// <summary>
        /// Экспорт с произвольной геометрией;
        /// Для этого в таблице обязательно нужна колонка geom 
        /// с заранее сформированой геометрией (текст)
        /// </summary>
        /// <param name="tableIn"></param>
        /// <param name="chemaOUT"></param>
        /// <param name="tableOUT"></param>
        /// <returns></returns>
        public bool ExportSqlDataGeom(DataTable tableIn, string chemaOUT, string tableOUT, bool isDelete)
        {
            if (isDelete) DeleteSqlData(chemaOUT, tableOUT);
            bool result = true;
            // проверка на вставку геометрии
            // найдем колону geom
            bool isGeom = false;
            string ColumnsGeom = "geom";
            // номер параметра колонки геометрии в строке всатвки
            int ColumnsParametrGeom = 0;
            if (tableIn.Columns.Contains(ColumnsGeom))
                isGeom = true;

            ArrayList arrayListColumns = new ArrayList();
            string listColumns = "";
            string listValues = "";

            foreach (DataColumn item in tableIn.Columns)
            {
                listColumns += "\"" + item.ColumnName + "\", ";
                listValues = listValues + "@param" + item.Ordinal.ToString() + ", ";
                arrayListColumns.Add(item.ColumnName);
                // сформируем параметр
                // если есть колонка геометрии, то в массиве и значениях потом не обрабатываем
                if (item.ColumnName == ColumnsGeom && isGeom)
                    ColumnsParametrGeom = item.Ordinal;

            }
            listValues = listValues.Remove(listValues.LastIndexOf(", "));
            listColumns = listColumns.Remove(listColumns.LastIndexOf(", "));
            string sqlI = "INSERT INTO \"" + chemaOUT + "\".\"" + tableOUT + "\" (" + listColumns + ") VALUES (" + listValues + ")";

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();

            try
            {
                foreach (DataRow row in tableIn.Rows)
                {
                    NpgsqlCommand sqlCommand = conn.CreateCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    if (isGeom)
                    {
                        if (row[ColumnsGeom].ToString() != "" || row[ColumnsGeom] != DBNull.Value)
                            sqlCommand.CommandText = sqlI.Replace("@param" + ColumnsParametrGeom.ToString(), $"ST_SetSRID({row[ColumnsGeom].ToString()}, {SRID})");
                        else
                        {
                            string NoSolumnGeom = sqlI.Replace(", @param" + ColumnsParametrGeom.ToString(), "");
                            NoSolumnGeom = NoSolumnGeom.Replace(", \"" + ColumnsGeom + "\"", "");
                            sqlCommand.CommandText = NoSolumnGeom;
                        }
                    }
                    else
                        sqlCommand.CommandText = sqlI;
                    NpgsqlParameter sqlParameter;
                    for (int j = 0; j < arrayListColumns.Count; j++)
                    {
                        if (arrayListColumns[j].ToString() == ColumnsGeom && isGeom)
                            continue;
                        DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListColumns[j].ToString()].DataType);
                        sqlParameter = new NpgsqlParameter("@param" + j.ToString(), dataType);
                        sqlParameter.Value = row[arrayListColumns[j].ToString()];

                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (NpgsqlException ex)
            {
                if (showMessageBox)
                    MessageBox.Show(ex.Message, ex.Source);
                else
                    Log.Write(Logger.LogLevel.Error, "LibraryTSQL", "pSQL", "ExportSqlData: " + tableOUT, ex.Message, null);
                result = false;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool ExportSqlDataGeom(DataTable tableIn, string chemaOUT, string tableOUT)
        {
            
            bool result = true;

            // проверка на вставку геометрии
            // в исходной таблице колонки геометерии (geom) нет 
            bool isGeom = false;
            string ColumnsGeom = "geom";
            // номер параметра колонки геометрии в строке всатвки
            int ColumnsParametrGeom = 0;
            if (tableIn.Columns.Contains(ColumnsGeom))
                isGeom = true;

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            try
            {
                // 1. параметрическая строка для выборки и обновления
                DataColumn[] primaryKey = tableIn.PrimaryKey;
                string textWhere = " where ";
                ArrayList arrayListPrimaryKey = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayListPrimaryKey.Add(primaryKey[i].ColumnName);
                    textWhere += "\"" + primaryKey[i].ColumnName + "\" = @paramPrimary" + i.ToString() + " and ";
                }
                if (textWhere.LastIndexOf(" and ") >= 0)
                {
                    textWhere = textWhere.Remove(textWhere.LastIndexOf(" and "));
                }
                // 2. параметрическая строка для вставки 
                ArrayList arrayListColumns = new ArrayList();
                string listColumns = "";
                string listValues = "";
                foreach (DataColumn item in tableIn.Columns)
                {
                    arrayListColumns.Add(item.ColumnName);
                    listValues = listValues + "@param" + item.Ordinal.ToString() + ", ";
                    listColumns += "\"" + item.ColumnName + "\", ";
                    // сформируем параметр
                    // если есть колонка геометрии, то в массиве и значениях потом не обрабатываем
                    if (item.ColumnName == ColumnsGeom && isGeom)
                        ColumnsParametrGeom = item.Ordinal;
                }
                listValues = listValues.Remove(listValues.LastIndexOf(", "));
                listColumns = listColumns.Remove(listColumns.LastIndexOf(", "));
                // 3. параметрическая строка для обновления
                ArrayList arrayListSet = new ArrayList();
                foreach (DataColumn item in tableIn.Columns)
                {
                    if (arrayListPrimaryKey.BinarySearch(item.ColumnName) < 0)
                    {
                        if (!item.ReadOnly)
                        {
                            arrayListSet.Add(item.ColumnName);
                        }
                    }
                    else
                    {
                        arrayListSet.Remove(item.ColumnName);
                    }
                }
                // 4. обработка данных
                foreach (DataRow dataRow in tableIn.Rows)
                {
                    // если в колонке geom пусто, то запись не экспортируем
                    //if (isGeom)
                    //{
                    //    if (dataRow[ColumnsGeom].ToString() == "" || dataRow[ColumnsGeom] == DBNull.Value)
                    //        continue;
                    //}
                    bool isUpdate = false;
                    // проверим, есть ли запись заданным ид
                    // если ид нет, то добавим запись
                    DataTable dtResult = new DataTable();
                    NpgsqlCommand sqlCommand = conn.CreateCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    using (NpgsqlDataAdapter daPSQL = new NpgsqlDataAdapter())
                    {
                        for (int j = 0; j < arrayListPrimaryKey.Count; j++)
                        {
                            DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListPrimaryKey[j].ToString()].DataType);
                            NpgsqlParameter sqlParameter = new NpgsqlParameter("@paramPrimary" + j.ToString(), dataType);
                            sqlParameter.Value = dataRow[arrayListPrimaryKey[j].ToString()];
                            sqlCommand.Parameters.Add(sqlParameter);
                        }
                        string sqlSelect = "SELECT * FROM  \"" + chemaOUT + "\".\"" + tableOUT + "\"";
                        sqlSelect += textWhere;
                        sqlCommand.CommandText = sqlSelect;

                        daPSQL.SelectCommand = sqlCommand;
                        daPSQL.Fill(dtResult);

                        if (dtResult.Rows.Count != 0) isUpdate = true;
                    }

                    if (isUpdate)
                    {
                        string sqlUpdate = "update \"" + chemaOUT + "\".\"" + tableOUT + "\" set ";
                        //for (int j = 0; j < arrayListPrimaryKey.Count; j++)
                        //{
                        //    DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListPrimaryKey[j].ToString()].DataType);
                        //    NpgsqlParameter sqlParameter = new NpgsqlParameter("@paramPrimary" + j.ToString(), dataType);
                        //    sqlParameter.Value = dataRow[arrayListPrimaryKey[j].ToString()];
                        //    sqlCommand.Parameters.Add(sqlParameter);
                        //}
                        for (int k = 0; k < arrayListSet.Count; k++)
                        {
                            if (arrayListSet[k].ToString() == ColumnsGeom && isGeom)
                                continue;
                            sqlUpdate += $"\"{arrayListSet[k]}\" = @param{k.ToString()}, ";

                            DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListSet[k].ToString()].DataType);
                            NpgsqlParameter sqlParameter2 = new NpgsqlParameter("@param" + k.ToString(), dataType);

                            sqlParameter2.Value = dataRow[arrayListSet[k].ToString()];
                            sqlCommand.Parameters.Add(sqlParameter2);
                        }

                        if (sqlUpdate.LastIndexOf(", ") >= 0)
                        {
                            sqlUpdate = sqlUpdate.Remove(sqlUpdate.LastIndexOf(", "));
                        }
                        if (isGeom)
                        {
                            if (dataRow[ColumnsGeom].ToString() != "" || dataRow[ColumnsGeom] != DBNull.Value)
                                 sqlUpdate += $", \"{ColumnsGeom}\" = ST_SetSRID({ dataRow[ColumnsGeom].ToString()}, { SRID})";
                        }
                        sqlUpdate += textWhere;
                        sqlCommand.CommandText = sqlUpdate;
                    }
                    else
                    {
                        string sqlINSERT = "INSERT INTO \"" + chemaOUT + "\".\"" + tableOUT + "\" (" + listColumns + ") VALUES (" + listValues + ")";
                        if (isGeom)
                        {
                            if (dataRow[ColumnsGeom].ToString() != "" || dataRow[ColumnsGeom] != DBNull.Value)
                                sqlCommand.CommandText = sqlINSERT.Replace("@param" + ColumnsParametrGeom.ToString(), $"ST_SetSRID({dataRow[ColumnsGeom].ToString()}, {SRID})");
                            else
                            {
                                string NoSolumnGeom = sqlINSERT.Replace(", @param" + ColumnsParametrGeom.ToString(), "");
                                NoSolumnGeom = NoSolumnGeom.Replace(", \"" + ColumnsGeom + "\"", "");
                                sqlCommand.CommandText = NoSolumnGeom;
                            }
                        }
                        else
                            sqlCommand.CommandText = sqlINSERT;
                        NpgsqlParameter sqlParameter;
                        for (int j = 0; j < arrayListColumns.Count; j++)
                        {
                            if (arrayListColumns[j].ToString() == ColumnsGeom && isGeom)
                                continue;
                            DbType dataType = LibraryTypeData.TypeConvertor.ToDbType(tableIn.Columns[arrayListColumns[j].ToString()].DataType);
                            sqlParameter = new NpgsqlParameter("@param" + j.ToString(), dataType);
                            sqlParameter.Value = dataRow[arrayListColumns[j].ToString()];

                            sqlCommand.Parameters.Add(sqlParameter);
                        }
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                if (showMessageBox)
                    MessageBox.Show(ex.Message, ex.Source);
                else
                    Log.Write(Logger.LogLevel.Error, "LibraryTSQL", "pSQL", "ExportSqlData: " + tableOUT, ex.Message, null);
                result = false;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool DeleteSqlData(string chema, string table, string where = "")
        {
            bool result = true;
            if (where != "") where += " ";
            string sqlD = "DELETE FROM  \"" + chema + "\".\"" + table + "\"" + where + ";";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            try
            {
                NpgsqlCommand sqlCommand = conn.CreateCommand();
                sqlCommand.CommandText = sqlD;
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (NpgsqlException ex)
            {
                if (showMessageBox)
                    MessageBox.Show(ex.Message, ex.Source);
                else
                    Log.Write(Logger.LogLevel.Error, "LibraryTSQL", "pSQL", "DeleteSqlData: " + table, ex.Message, null);
                result = false;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public DataTable SelectSqlData(string chema, string table, string where = "")
        {
            DataTable dataTable = new DataTable(table);
            if (where != "") where += " ";
            string sqlD = "SELECT * FROM  \"" + chema + "\".\"" + table + "\"" + where + ";";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            try
            {
                NpgsqlCommand sqlCommand = conn.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                using (NpgsqlDataAdapter daPSQL = new NpgsqlDataAdapter())
                {
                    sqlCommand.CommandText = sqlD;

                    daPSQL.SelectCommand = sqlCommand;
                    daPSQL.Fill(dataTable);
                }

            }
            catch (NpgsqlException ex)
            {
                if (showMessageBox)
                    MessageBox.Show(ex.Message, ex.Source);
                else
                    Log.Write(Logger.LogLevel.Error, "LibraryTSQL", "pSQL", "SelectSqlData: " + table, ex.Message, null);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
    }
    internal class sqlDataConnect
    {
    }
    /// <summary>
    /// команды для работы с Microsoft SQL Server (v2)
    /// </summary>
    public class cTSQL : FormLbr.FormBase
    {
        public bool UpdateSqlDataN(DataTable dt)
        {
            DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                DataTable changes = dt.GetChanges(DataRowState.Modified);
                if (changes == null || changes.Rows.Count == 0)
                {
                    bool result = true;
                    return result;
                }
                DataColumn[] primaryKey = dt.PrimaryKey;
                string text = " where ";
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayList.Add(primaryKey[i].ColumnName);
                    text = string.Concat(new string[]
                    {
                text,
                "[",
                primaryKey[i].ColumnName,
                "] = @paramPrimary",
                i.ToString(),
                " and "
                    });
                }
                string text2 = "update " + dt.TableName + " set ";
                ArrayList arrayList2 = new ArrayList();
                int num = 0;
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    if (arrayList.BinarySearch(dataColumn.ColumnName) < 0)
                    {
                        if (!dataColumn.ReadOnly)
                        {
                            arrayList2.Add(dataColumn.ColumnName);
                            string[] expr_119 = new string[6];
                            expr_119[0] = text2;
                            expr_119[1] = "[";
                            expr_119[2] = dataColumn.ColumnName;
                            expr_119[3] = "] = @param";
                            int arg_14B_1 = 4;
                            int num2 = num;
                            num = num2 + 1;
                            expr_119[arg_14B_1] = num2.ToString();
                            expr_119[5] = ", ";
                            text2 = string.Concat(expr_119);
                        }
                    }
                    else
                    {
                        arrayList2.Remove(dataColumn.ColumnName);
                    }
                }
                text = text.Remove(text.LastIndexOf(" and "));
                text2 = text2.Remove(text2.LastIndexOf(", "));
                text2 += text;
                foreach (DataRow dataRow in changes.Rows)
                {
                    SqlCommand sqlCommand = new SqlCommand(text2, sqlDataConnect.Connection);
                    for (int j = 0; j < arrayList.Count; j++)
                    {
                        SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), dt.Columns[arrayList[j].ToString()].DataType);
                        sqlParameter.SqlValue = dataRow[arrayList[j].ToString()];
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    for (int k = 0; k < arrayList2.Count; k++)
                    {
                        Type dataType = dt.Columns[arrayList2[k].ToString()].DataType;
                        SqlParameter sqlParameter2;
                        if (dataType == typeof(byte[]))
                        {
                            sqlParameter2 = new SqlParameter("@param" + k.ToString(), SqlDbType.Binary);
                        }
                        else
                        {
                            sqlParameter2 = new SqlParameter("@param" + k.ToString(), dataType);
                        }
                        sqlParameter2.SqlValue = dataRow[arrayList2[k].ToString()];
                        sqlCommand.Parameters.Add(sqlParameter2);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                bool result = false;
                return result;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }

        public bool InsertSqlDataN(DataTable dt)
        {
            DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                DataTable changes = dt.GetChanges(DataRowState.Added);
                if (changes == null || changes.Rows.Count == 0)
                {
                    bool result = true;
                    return result;
                }
                DataColumn[] primaryKey = dt.PrimaryKey;
                string textValues = " values (";
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayList.Add(primaryKey[i].ColumnName);
                }
                string textBegin = "insert into " + dt.TableName + "( ";
                ArrayList arrayList2 = new ArrayList();
                int num = 0;
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    if (!dataColumn.AutoIncrement)
                    {
                        arrayList2.Add(dataColumn.ColumnName);
                        string arg_DC_0 = textValues;
                        string sqlParameter = "@param";
                        int Ordinal = num;
                        num = Ordinal + 1;
                        textValues = arg_DC_0 + sqlParameter + Ordinal.ToString() + ", ";
                        textBegin = textBegin + "[" + dataColumn.ColumnName + "], ";
                    }
                    else
                    {
                        arrayList2.Remove(dataColumn.ColumnName);
                    }
                }
                textValues = textValues.Remove(textValues.LastIndexOf(", ")) + ") ";
                textBegin = textBegin.Remove(textBegin.LastIndexOf(", ")) + ") ";
                textBegin += textValues;
                foreach (DataRow dataRow in changes.Rows)
                {
                    SqlCommand sqlCommand = new SqlCommand(textBegin, sqlDataConnect.Connection);
                    for (int j = 0; j < arrayList2.Count; j++)
                    {
                        Type dataType = dt.Columns[arrayList2[j].ToString()].DataType;
                        SqlParameter sqlParameter;
                        if (dataType == typeof(byte[]))
                        {
                            sqlParameter = new SqlParameter("@param" + j.ToString(), SqlDbType.Binary);
                        }
                        else
                        {
                            sqlParameter = new SqlParameter("@param" + j.ToString(), dataType);
                        }
                        sqlParameter.SqlValue = dataRow[arrayList2[j].ToString()];
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                bool result = false;
                return result;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }

        public bool DeleteSqlDataWhereN(DataTable dt, string where)
        {
            DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();
            bool result;
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                new SqlCommand("delete " + dt.TableName + " " + where, sqlDataConnect.Connection).ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                result = false;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return result;
        }
        /// <summary>
        /// запись строки DataRow
        /// </summary>
        /// <param name="r">строка</param>
        /// <param name="isValueNotNull"> использовать пустые значения, по умолчанию - да</param>
        /// <returns></returns>
        public int InsertSqlDataOneRowN(DataRow r, bool isValueNotNull = true)
        {
            if (r.Table == null)
            {
                return -1;
            }
            DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();
            int result = -1;
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                SqlTransaction sqlTransaction = sqlDataConnect.Connection.BeginTransaction();
                DataColumn[] primaryKey = r.Table.PrimaryKey;
                string text = " values (";
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayList.Add(primaryKey[i].ColumnName);
                }
                string text2 = "insert into " + r.Table.TableName + "( ";
                ArrayList arrayList2 = new ArrayList();
                int num = 0;
                foreach (object obj in r.Table.Columns)
                {
                    DataColumn dataColumn = (DataColumn)obj;
                    if (arrayList.BinarySearch(dataColumn.ColumnName) < 0)
                    {
                        if (!dataColumn.ReadOnly)
                        {
                            if (isValueNotNull || r[dataColumn] != DBNull.Value)
                            {
                                arrayList2.Add(dataColumn.ColumnName);
                                string str = text;
                                string str2 = "@param";
                                int num2 = num;
                                num = num2 + 1;
                                text = str + str2 + num2.ToString() + ", ";
                                text2 = text2 + "[" + dataColumn.ColumnName + "], ";
                            }
                        }
                    }
                    else
                    {
                        arrayList2.Remove(dataColumn.ColumnName);
                    }
                }
                text = text.Remove(text.LastIndexOf(", ")) + ") ";
                text2 = text2.Remove(text2.LastIndexOf(", ")) + ") ";
                text2 += text;
                SqlCommand sqlCommand = new SqlCommand(text2, sqlDataConnect.Connection);
                sqlCommand.Transaction = sqlTransaction;
                for (int j = 0; j < arrayList2.Count; j++)
                {
                    Type dataType = r.Table.Columns[arrayList2[j].ToString()].DataType;
                    SqlParameter sqlParameter;
                    if (dataType == typeof(byte[]))
                    {
                        sqlParameter = new SqlParameter("@param" + j.ToString(), SqlDbType.Binary);
                    }
                    else
                    {
                        sqlParameter = new SqlParameter("@param" + j.ToString(), dataType);
                    }
                    sqlParameter.SqlValue = r[arrayList2[j].ToString()];
                    sqlCommand.Parameters.Add(sqlParameter);
                }
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "select IDENT_CURRENT('" + r.Table.TableName + "')";
                result = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return -1;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return result;
        }

        public DataTable GetDataTable(string tableName, string where, bool showMessageBox = true)
        {
            DataTable dataTable = new DataTable(tableName);
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    string sqlS = "SELECT * FROM  " + tableName + " " + where;
                    dataTable = new DataSql.SqlDataCommand(this.SqlSettings).SelectSqlData(sqlS);

                }
                catch (Exception ex)
                {
                    if (showMessageBox)
                        MessageBox.Show(ex.Message, ex.Source);
                    else
                        Log.Write(Logger.LogLevel.Error, "ExportToPostGIS", "FormExportReference", "LoadData - " + tableName, ex.Message, null);
                }
            }
            return dataTable;
        }
        public bool DeleteSqlDataN(DataTable dt)
        {
            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            try
            {
                sqlDataConnect.OpenConnection(this.SqlSettings);
                DataTable changes = dt.GetChanges(DataRowState.Deleted);
                if (changes == null || changes.Rows.Count == 0)
                {
                    return true;
                }
                DataColumn[] primaryKey = dt.PrimaryKey;
                string txtWhere = " where ";
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayList.Add(primaryKey[i].ColumnName);
                    txtWhere = string.Concat(new string[] { txtWhere, primaryKey[i].ColumnName, " = @paramPrimary", i.ToString(), " and " });
                }
                string txtDelete = "delete " + dt.TableName + " ";
                txtWhere = txtWhere.Remove(txtWhere.LastIndexOf(" and "));
                txtDelete += txtWhere;
                foreach (object obj in changes.Rows)
                {
                    DataRow dataRow = (DataRow)obj;
                    SqlCommand sqlCommand = new SqlCommand(txtDelete, sqlDataConnect.Connection);
                    for (int j = 0; j < arrayList.Count; j++)
                    {
                        SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), dt.Columns[arrayList[j].ToString()].DataType);
                        sqlParameter.SqlValue = dataRow[arrayList[j].ToString(), DataRowVersion.Original];
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return false;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }
    }
    public class mSQL
    { }
#region Проба
    public class QuerySQL
    {
        public QuerySQL(object obj)
        {
            Select select = new Select();
            Obj = obj ?? throw new ArgumentNullException(nameof(obj));
        }

        public object Obj { get; }

        class Select
        {
            public Select()
            {
            }
        }
    }
#endregion
}

namespace DataSqlDemo
{
    [TypeConverter(typeof(SqlSettingsConverter))]
    public class SQLSettings
    {
        public SQLSettings()
        {
            this.serverDB = "";
            this.dbName = "";
            this.autentification = "";
            this.sqlUserConnect = "";
            this.sqlPasswConnect = "";
        }

        public SQLSettings(string serverDB, string dbName, string autentification, string sqlUserConnect, string sqlPasswConnect)
        {
            this.serverDB = serverDB;
            this.dbName = dbName;
            this.autentification = autentification;
            this.sqlUserConnect = sqlUserConnect;
            this.sqlPasswConnect = sqlPasswConnect;
        }

        public SQLSettings(SQLSettings sqlSett)
        {
            this.serverDB = sqlSett.ServerDB;
            this.dbName = sqlSett.DBName;
            this.autentification = sqlSett.Autentification;
            this.sqlUserConnect = sqlSett.SqlUserConnect;
            this.sqlPasswConnect = sqlSett.SqlPasswConnect;
        }

        [RefreshProperties(RefreshProperties.All)]
        public string ServerDB
        {
            get
            {
                return this.serverDB;
            }
            set
            {
                this.serverDB = value;
                this.DoPropertyChanged("ServerDB");
            }
        }

        [RefreshProperties(RefreshProperties.All)]
        public string DBName
        {
            get
            {
                return this.dbName;
            }
            set
            {
                this.dbName = value;
                this.DoPropertyChanged("DBName");
            }
        }

        [RefreshProperties(RefreshProperties.All)]
        public string Autentification
        {
            get
            {
                return this.autentification;
            }
            set
            {
                this.autentification = value;
                this.DoPropertyChanged("Autentification");
            }
        }

        [RefreshProperties(RefreshProperties.All)]
        public string SqlUserConnect
        {
            get
            {
                return this.sqlUserConnect;
            }
            set
            {
                this.sqlUserConnect = value;
                this.DoPropertyChanged("SqlUserConnect");
            }
        }

        [RefreshProperties(RefreshProperties.All)]
        public string SqlPasswConnect
        {
            get
            {
                return this.sqlPasswConnect;
            }
            set
            {
                this.sqlPasswConnect = value;
                this.DoPropertyChanged("SqlPasswConnect");
            }
        }

        public delegate void PropertyChangedEventHandler(string propertyName);
        [CompilerGenerated]
        private SQLSettings.PropertyChangedEventHandler propertyChangedEventHandler;
        public event SQLSettings.PropertyChangedEventHandler PropertyChanged
        {
            [CompilerGenerated]
            add
            {
                SQLSettings.PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler;
                SQLSettings.PropertyChangedEventHandler propertyChangedEventHandler2;
                do
                {
                    propertyChangedEventHandler2 = propertyChangedEventHandler;
                    SQLSettings.PropertyChangedEventHandler value2 = (SQLSettings.PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
                    propertyChangedEventHandler = Interlocked.CompareExchange<SQLSettings.PropertyChangedEventHandler>(ref this.propertyChangedEventHandler, value2, propertyChangedEventHandler2);
                }
                while (propertyChangedEventHandler != propertyChangedEventHandler2);
            }
            [CompilerGenerated]
            remove
            {
                SQLSettings.PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler;
                SQLSettings.PropertyChangedEventHandler propertyChangedEventHandler2;
                do
                {
                    propertyChangedEventHandler2 = propertyChangedEventHandler;
                    SQLSettings.PropertyChangedEventHandler value2 = (SQLSettings.PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
                    propertyChangedEventHandler = Interlocked.CompareExchange<SQLSettings.PropertyChangedEventHandler>(ref this.propertyChangedEventHandler, value2, propertyChangedEventHandler2);
                }
                while (propertyChangedEventHandler != propertyChangedEventHandler2);
            }
        }

        public string GetConnectionString()
        {
            string empty = string.Empty;
            if (string.IsNullOrEmpty(this.serverDB))
            {
                return string.Empty;
            }
            if (string.IsNullOrEmpty(this.dbName))
            {
                return string.Empty;
            }
            if (this.autentification == "WINDOWS")
            {
                return string.Concat(new string[]
                {
                    "Server=",
                    this.serverDB,
                    "; dataBase=",
                    this.dbName,
                    "; Integrated Security=true"
                });
            }
            if (this.autentification == "SQL")
            {
                return string.Concat(new string[]
                {
                    "Server=",
                    this.serverDB,
                    "; dataBase=",
                    this.dbName,
                    "; uid=",
                    this.sqlUserConnect,
                    ";pwd=",
                    this.sqlPasswConnect,
                    ";Integrated Security=false"
                });
            }
            return empty;
        }

        private void DoPropertyChanged(string name)
        {
            if (this.propertyChangedEventHandler != null)
            {
                this.propertyChangedEventHandler(name);
            }
        }

        public static SQLSettings Parse(string value)
        {
            string[] array = value.Split(new char[] { ',' });
            return new SQLSettings(array[0], array[1], array[2], array[3], array[4]);
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", new object[]
            {
                this.serverDB,
                this.dbName,
                this.autentification,
                this.sqlUserConnect,
                this.sqlPasswConnect
            });
        }

        private string serverDB = "";

        private string dbName = "";

        private string autentification = "";

        private string sqlUserConnect = "";

        private string sqlPasswConnect = "";
    }

    internal class SqlSettingsConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                return SQLSettings.Parse(value as string);
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType != typeof(string) || value == null)
            {
                return base.ConvertTo(context, culture, value, destinationType);
            }
            if (value is SQLSettings)
            {
                return ((SQLSettings)value).ToString();
            }
            return value;
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(SQLSettings)).Sort(new string[]
            {
            "ServerDB",
            "DBName",
            "Autentification",
            "SqlUserConnect",
            "SqlPasswConnect"
            });
        }

    }
}