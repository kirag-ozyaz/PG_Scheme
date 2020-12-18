using DataSql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;


class SqlDataCommandN
{
    private SQLSettings SqlSettings;

    public int CommandTimeout { get; set; }

    public SqlDataCommandN(SQLSettings sqlSett)
    {
        this.SqlSettings = sqlSett;
        CommandTimeout = 30;
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
            if (text.LastIndexOf(" and ") >= 0)
            {
                text = text.Remove(text.LastIndexOf(" and "));
            }
            ArrayList arrayList2 = new ArrayList();
            foreach (object obj in dt.Columns)
            {
                DataColumn dataColumn = (DataColumn)obj;
                if (arrayList.BinarySearch(dataColumn.ColumnName) < 0)
                {
                    if (!dataColumn.ReadOnly)
                    {
                        arrayList2.Add(dataColumn.ColumnName);
                    }
                }
                else
                {
                    arrayList2.Remove(dataColumn.ColumnName);
                }
            }
            foreach (object obj2 in changes.Rows)
            {
                DataRow dataRow = (DataRow)obj2;
                string text2 = "update [" + dt.TableName + "] set ";
                SqlCommand sqlCommand = new SqlCommand(text2, sqlDataConnect.Connection);
                for (int j = 0; j < arrayList.Count; j++)
                {
                    SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), dt.Columns[arrayList[j].ToString()].DataType);
                    sqlParameter.SqlValue = dataRow[arrayList[j].ToString()];
                    sqlCommand.Parameters.Add(sqlParameter);
                }
                bool flag = false;
                for (int k = 0; k < arrayList2.Count; k++)
                {
                    if (!dataRow[arrayList2[k].ToString(), DataRowVersion.Original].Equals(dataRow[arrayList2[k].ToString(), DataRowVersion.Current]))
                    {
                        flag = true;
                        text2 = string.Concat(new object[]
                        {
                        text2,
                        "[",
                        arrayList2[k],
                        "] = @param",
                        k.ToString(),
                        ", "
                        });
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
                }
                if (flag)
                {
                    if (text2.LastIndexOf(", ") >= 0)
                    {
                        text2 = text2.Remove(text2.LastIndexOf(", "));
                    }
                    text2 += text;
                    sqlCommand.CommandText = text2;
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

    public bool UpdateSqlData(DataTable dt, string setParam, string where)
    {
        SqlDataConnect sqlDataConnect = new SqlDataConnect();
        bool result;
        try
        {
            string cmdText = string.Concat(new string[]
            {
            "update [",
            dt.TableName,
            "] ",
            " set " + setParam,
            " ",
            " where " + where
            });
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
}
