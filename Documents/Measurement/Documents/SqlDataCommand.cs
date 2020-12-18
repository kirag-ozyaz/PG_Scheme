//using FormLbr;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Documents.Measurement
{
    public class SqlDataCommand : FormLbr.FormBase
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
                string text = " values (";
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < primaryKey.Length; i++)
                {
                    arrayList.Add(primaryKey[i].ColumnName);
                }
                string text2 = "insert into " + dt.TableName + "( ";
                ArrayList arrayList2 = new ArrayList();
                int num = 0;
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    if (!dataColumn.AutoIncrement)
                    {
                        arrayList2.Add(dataColumn.ColumnName);
                        string arg_DC_0 = text;
                        string arg_DC_1 = "@param";
                        int num2 = num;
                        num = num2 + 1;
                        text = arg_DC_0 + arg_DC_1 + num2.ToString() + ", ";
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
                foreach (DataRow dataRow in changes.Rows)
                {
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
                bool result = false;
                return result;
            }
            finally
            {
                sqlDataConnect.CloseConnection();
            }
            return true;
        }
    }
}