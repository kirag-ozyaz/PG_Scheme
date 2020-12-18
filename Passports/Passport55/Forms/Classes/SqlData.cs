using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataSql;

namespace Passport.Forms.Classes
{
	public static class SqlData
	{
		public static bool SelectSqlData(SQLSettings SqlSettings, DataSet dataSet_0, DataTable dataTable_0, bool withGetSqlPermission, string where, bool distinct)
		{
			return SqlData.SelectSqlData(SqlSettings, dataSet_0, dataTable_0.TableName, withGetSqlPermission, where, distinct);
		}

		public static bool SelectSqlData(SQLSettings SqlSettings, DataSet dataSet_0, string tableName, bool withGetSqlPermission, string where, bool distinct)
		{
			DataTable dataTable;
			if (withGetSqlPermission)
			{
				dataTable = SqlData.GetSqlPermissions(SqlSettings, new string[]
				{
					tableName
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
				string text;
				if (distinct)
				{
					text = "select distinct ";
				}
				else
				{
					text = "select ";
				}
				if (withGetSqlPermission)
				{
					foreach (DataRow dataRow in dataTable.Select("Operation = 'select'"))
					{
						if (dataSet_0.Tables[tableName].Columns.Count > 0)
						{
							if (dataSet_0.Tables[tableName].Columns.Contains(dataRow["ColumnName"].ToString()))
							{
								text = string.Concat(new object[]
								{
									text,
									"[",
									tableName,
									"].[",
									dataRow["ColumnName"],
									"], "
								});
							}
						}
						else
						{
							text = string.Concat(new object[]
							{
								text,
								"[",
								tableName,
								"].[",
								dataRow["ColumnName"],
								"], "
							});
						}
					}
					text = text.Remove(text.LastIndexOf(", "));
				}
				else
				{
					text += " * ";
				}
				text = text + " from " + tableName + " ";
				text += where;
				dataSet_0.Tables[tableName].Clear();
				sqlDataConnect.OpenConnection(SqlSettings);
				new SqlDataAdapter(text, sqlDataConnect.Connection).Fill(dataSet_0, tableName);
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

		public static bool SelectSqlDataTableOther(SQLSettings SqlSettings, DataSet dataSet_0, DataTable dataTable_0, string tableNameSql, bool withGetSqlPermission, string where)
		{
			return SqlData.SelectSqlDataTableOther(SqlSettings, dataSet_0, dataTable_0.TableName, tableNameSql, withGetSqlPermission, where, -1);
		}

		public static bool SelectSqlDataTableOther(SQLSettings SqlSettings, DataSet dataSet_0, string tableName, string tableNameSql, bool withGetSqlPermission, string where, int countRows)
		{
			DataTable dataTable;
			if (withGetSqlPermission)
			{
				dataTable = SqlData.GetSqlPermissions(SqlSettings, new string[]
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
				string text;
				if (countRows < 0)
				{
					text = "select ";
				}
				else
				{
					text = "select top " + countRows.ToString() + " ";
				}
				if (withGetSqlPermission)
				{
					foreach (DataRow dataRow in dataTable.Select("Operation = 'select'"))
					{
						if (dataSet_0.Tables[tableName] != null && dataSet_0.Tables[tableName].Columns.Count > 0)
						{
							if (dataSet_0.Tables[tableName].Columns.Contains(dataRow["ColumnName"].ToString()))
							{
								text = string.Concat(new object[]
								{
									text,
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
							text = string.Concat(new object[]
							{
								text,
								"[",
								tableNameSql,
								"].[",
								dataRow["ColumnName"],
								"], "
							});
						}
					}
					if (text.Length <= 0)
					{
						MessageBox.Show("Не определены столбцы для выборки");
						return false;
					}
					text = text.Remove(text.LastIndexOf(", "));
				}
				else
				{
					text += " * ";
				}
				text = text + " from " + tableNameSql + " ";
				text += where;
				if (dataSet_0.Tables[tableName] != null)
				{
					dataSet_0.Tables[tableName].Clear();
				}
				sqlDataConnect.OpenConnection(SqlSettings);
				new SqlDataAdapter(text, sqlDataConnect.Connection).Fill(dataSet_0, tableName);
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

		public static bool UpdateSqlData(SQLSettings SqlSettings, DataSet dataSet_0, DataTable dataTable_0)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			try
			{
				sqlDataConnect.OpenConnection(SqlSettings);
				DataTable changes = dataSet_0.Tables[dataTable_0.TableName].GetChanges(DataRowState.Modified);
				if (changes == null || changes.Rows.Count == 0)
				{
					return true;
				}
				DataColumn[] primaryKey = dataSet_0.Tables[dataTable_0.TableName].PrimaryKey;
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
				string text2 = "update " + dataTable_0.TableName + " set ";
				ArrayList arrayList2 = new ArrayList();
				int num = 0;
				foreach (object obj in dataSet_0.Tables[dataTable_0.TableName].Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (arrayList.BinarySearch(dataColumn.ColumnName) < 0)
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
						SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), dataSet_0.Tables[dataTable_0.TableName].Columns[arrayList[j].ToString()].DataType);
						sqlParameter.SqlValue = dataRow[arrayList[j].ToString()];
						sqlCommand.Parameters.Add(sqlParameter);
					}
					for (int k = 0; k < arrayList2.Count; k++)
					{
						Type dataType = dataSet_0.Tables[dataTable_0.TableName].Columns[arrayList2[k].ToString()].DataType;
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

		public static bool UpdateSqlData(SQLSettings SqlSettings, DataSet dataSet_0, DataTable dataTable_0, ref SqlTransaction transaction)
		{
			if (transaction == null)
			{
				SqlData.UpdateSqlData(SqlSettings, dataSet_0, dataTable_0);
			}
			SqlDataConnect sqlDataConnect = new SqlDataConnect(transaction.Connection);
			try
			{
				DataTable changes = dataSet_0.Tables[dataTable_0.TableName].GetChanges(DataRowState.Modified);
				if (changes == null || changes.Rows.Count == 0)
				{
					return true;
				}
				DataColumn[] primaryKey = dataSet_0.Tables[dataTable_0.TableName].PrimaryKey;
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
				string text2 = "update " + dataTable_0.TableName + " set ";
				ArrayList arrayList2 = new ArrayList();
				int num = 0;
				foreach (object obj in dataSet_0.Tables[dataTable_0.TableName].Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (arrayList.BinarySearch(dataColumn.ColumnName) < 0)
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
					sqlCommand.Transaction = transaction;
					for (int j = 0; j < arrayList.Count; j++)
					{
						SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), dataSet_0.Tables[dataTable_0.TableName].Columns[arrayList[j].ToString()].DataType);
						sqlParameter.SqlValue = dataRow[arrayList[j].ToString()];
						sqlCommand.Parameters.Add(sqlParameter);
					}
					for (int k = 0; k < arrayList2.Count; k++)
					{
						Type dataType = dataSet_0.Tables[dataTable_0.TableName].Columns[arrayList2[k].ToString()].DataType;
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
				transaction.Commit();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
				transaction.Rollback();
				return false;
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
			return true;
		}

		public static bool UpdateSqlDataTableOther(SQLSettings SqlSettings, DataSet dataSet_0, DataTable dataTable_0, string tableNameSql)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			try
			{
				sqlDataConnect.OpenConnection(SqlSettings);
				DataTable changes = dataSet_0.Tables[dataTable_0.TableName].GetChanges(DataRowState.Modified);
				if (changes == null || changes.Rows.Count == 0)
				{
					return true;
				}
				DataColumn[] primaryKey = dataSet_0.Tables[dataTable_0.TableName].PrimaryKey;
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
				string text2 = "update " + tableNameSql + " set ";
				ArrayList arrayList2 = new ArrayList();
				int num = 0;
				foreach (object obj in dataSet_0.Tables[dataTable_0.TableName].Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (arrayList.BinarySearch(dataColumn.ColumnName) < 0)
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
						SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), dataSet_0.Tables[dataTable_0.TableName].Columns[arrayList[j].ToString()].DataType);
						sqlParameter.SqlValue = dataRow[arrayList[j].ToString()];
						sqlCommand.Parameters.Add(sqlParameter);
					}
					for (int k = 0; k < arrayList2.Count; k++)
					{
						Type dataType = dataSet_0.Tables[dataTable_0.TableName].Columns[arrayList2[k].ToString()].DataType;
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

		public static bool UpdateSqlDataTableOther(SQLSettings SqlSettings, DataSet dataSet_0, DataTable dataTable_0, string tableNameSql, ref SqlTransaction transaction)
		{
			if (transaction == null)
			{
				SqlData.UpdateSqlDataTableOther(SqlSettings, dataSet_0, dataTable_0, tableNameSql);
			}
			SqlDataConnect sqlDataConnect = new SqlDataConnect(transaction.Connection);
			try
			{
				DataTable changes = dataSet_0.Tables[dataTable_0.TableName].GetChanges(DataRowState.Modified);
				if (changes == null || changes.Rows.Count == 0)
				{
					return true;
				}
				DataColumn[] primaryKey = dataSet_0.Tables[dataTable_0.TableName].PrimaryKey;
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
				string text2 = "update " + tableNameSql + " set ";
				ArrayList arrayList2 = new ArrayList();
				int num = 0;
				foreach (object obj in dataSet_0.Tables[dataTable_0.TableName].Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (arrayList.BinarySearch(dataColumn.ColumnName) < 0)
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
					sqlCommand.Transaction = transaction;
					for (int j = 0; j < arrayList.Count; j++)
					{
						SqlParameter sqlParameter = new SqlParameter("@paramPrimary" + j.ToString(), dataSet_0.Tables[dataTable_0.TableName].Columns[arrayList[j].ToString()].DataType);
						sqlParameter.SqlValue = dataRow[arrayList[j].ToString()];
						sqlCommand.Parameters.Add(sqlParameter);
					}
					for (int k = 0; k < arrayList2.Count; k++)
					{
						Type dataType = dataSet_0.Tables[dataTable_0.TableName].Columns[arrayList2[k].ToString()].DataType;
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
				transaction.Commit();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
				transaction.Rollback();
				return false;
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
			return true;
		}

		public static bool InsertSqlData(SQLSettings SqlSettings, DataSet dataSet_0, DataTable dataTable_0)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			try
			{
				sqlDataConnect.OpenConnection(SqlSettings);
				DataTable changes = dataSet_0.Tables[dataTable_0.TableName].GetChanges(DataRowState.Added);
				if (changes == null || changes.Rows.Count == 0)
				{
					return true;
				}
				DataColumn[] primaryKey = dataSet_0.Tables[dataTable_0.TableName].PrimaryKey;
				string text = " values (";
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < primaryKey.Length; i++)
				{
					arrayList.Add(primaryKey[i].ColumnName);
				}
				string text2 = "insert into " + dataTable_0.TableName + "( ";
				ArrayList arrayList2 = new ArrayList();
				int num = 0;
				foreach (object obj in dataSet_0.Tables[dataTable_0.TableName].Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (arrayList.BinarySearch(dataColumn.ColumnName) < 0)
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
						Type dataType = dataSet_0.Tables[dataTable_0.TableName].Columns[arrayList2[j].ToString()].DataType;
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

		public static int InsertSqlDataOneRow(SQLSettings SqlSettings, DataSet dataSet_0, DataTable dataTable_0)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			int result = -1;
			try
			{
				sqlDataConnect.OpenConnection(SqlSettings);
				SqlTransaction sqlTransaction = sqlDataConnect.Connection.BeginTransaction();
				DataTable changes = dataSet_0.Tables[dataTable_0.TableName].GetChanges(DataRowState.Added);
				if (changes == null || changes.Rows.Count == 0)
				{
					return -1;
				}
				DataColumn[] primaryKey = dataSet_0.Tables[dataTable_0.TableName].PrimaryKey;
				string text = " values (";
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < primaryKey.Length; i++)
				{
					arrayList.Add(primaryKey[i].ColumnName);
				}
				string text2 = "insert into " + dataTable_0.TableName + "( ";
				ArrayList arrayList2 = new ArrayList();
				int num = 0;
				foreach (object obj in dataSet_0.Tables[dataTable_0.TableName].Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (arrayList.BinarySearch(dataColumn.ColumnName) < 0)
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
				SqlCommand sqlCommand = new SqlCommand(text2, sqlDataConnect.Connection);
				sqlCommand.Transaction = sqlTransaction;
				for (int j = 0; j < arrayList2.Count; j++)
				{
					Type dataType = dataSet_0.Tables[dataTable_0.TableName].Columns[arrayList2[j].ToString()].DataType;
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
				sqlCommand.CommandText = "select IDENT_CURRENT('" + dataTable_0.TableName + "')";
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

		public static object CallSQLScalarFunction(SQLSettings SqlSettings, string nameFunction, params string[] param)
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
				sqlDataConnect.OpenConnection(SqlSettings);
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

		public static DataTable CallSQLTabledValueFunction(SQLSettings SqlSettings, string nameFunction, params string[] param)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			DataTable dataTable = new DataTable();
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
				sqlDataConnect.OpenConnection(SqlSettings);
				SqlCommand sqlCommand = new SqlCommand(text, sqlDataConnect.Connection);
				for (int j = 0; j < param.Length; j++)
				{
					SqlParameter value = new SqlParameter("@param" + j.ToString(), param[j]);
					sqlCommand.Parameters.Add(value);
				}
				dataTable = new DataTable();
				new SqlDataAdapter(sqlCommand).Fill(dataTable);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
			return dataTable;
		}

		public static DataTable GetSqlPermissions(SQLSettings SqlSettings, string[] tableNames)
		{
			string text = "dbo.GetPermissionsTable";
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("TableName", typeof(string));
			dataTable.Columns.Add("ColumnName", typeof(string));
			dataTable.Columns.Add("Operation", typeof(string));
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			DataTable result;
			try
			{
				sqlDataConnect.OpenConnection(SqlSettings);
				for (int i = 0; i < tableNames.Length; i++)
				{
					SqlDataReader sqlDataReader = new SqlCommand(string.Concat(new string[]
					{
						"select ColumnName from ",
						text,
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
						text,
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
	}
}
