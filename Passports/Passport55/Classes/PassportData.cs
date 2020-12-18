using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataSql;

namespace Passport.Classes
{
	public static class PassportData
	{
		public static DataTable GetJournalData(SQLSettings SqlSettings, int[] typeCodeId)
		{
			return PassportData.GetJournalData(SqlSettings, typeCodeId, -1);
		}

		public static DataTable GetJournalData(SQLSettings SqlSettings, int[] typeCodeId, int idObjList)
		{
			return PassportData.GetJournalData(SqlSettings, typeCodeId, idObjList, false, false);
		}

		public static DataTable GetJournalData(SQLSettings SqlSettings, int[] typeCodeId, bool isUnbinded, bool isDeleted = false)
		{
			return PassportData.GetJournalData(SqlSettings, typeCodeId, -1, isUnbinded, isDeleted);
		}

		public static DataTable GetJournalData(SQLSettings SqlSettings, int[] typeCodeId, int idObjList, bool isUnbinded, bool isDeleted = false)
		{
			SqlConnection sqlConnection = new SqlConnection();
			DataTable dataTable = new DataTable();
			try
			{
				bool flag = typeCodeId[0] == 535 || typeCodeId[0] == 536 || typeCodeId[0] == 537 || typeCodeId[0] == 538 || typeCodeId[0] == 1034;
				bool flag2 = typeCodeId[0] == 546;
				bool flag3 = typeCodeId[0] == 556 || typeCodeId[0] == 603;
				bool flag4 = typeCodeId[0] == 556;
				if (typeCodeId[0] != 547)
				{
					bool flag5 = typeCodeId[0] == 983;
				}
				SqlDataCommand sqlDataCommand = new SqlDataCommand(SqlSettings);
				sqlConnection = PassportData.smethod_0(SqlSettings);
				sqlConnection.Open();
				string text = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdTypeValue", new string[]
				{
					";Passport;DataType;",
					"2"
				}).ToString();
				string text2 = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdTypeValue", new string[]
				{
					";Passport;DataType;",
					"3"
				}).ToString();
				string text3 = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdTypeValue", new string[]
				{
					";Passport;DateFormat;",
					"2"
				}).ToString();
				string text4 = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdClassifier", new string[]
				{
					";Passport;ObjLocation;",
					"5"
				}).ToString();
				string text5 = PassportData.smethod_1(sqlConnection, typeCodeId[0], "");
				string text6 = PassportData.smethod_1(sqlConnection, typeCodeId[0], "pt");
				if (text5 == "" || text6 == "")
				{
					return new DataTable();
				}
				string str = "";
				string text7 = "";
				string[] array = null;
				if (flag4 || flag2)
				{
					array = PassportData.smethod_4(SqlSettings, flag4 ? "tR_Transformer" : "tR_Cable");
					if (array.Length != 0)
					{
						str = "pvt.[" + string.Join("], pvt.[", array) + "]";
						text7 = "[" + string.Join("],[", array) + "]";
					}
				}
				StringBuilder stringBuilder = new StringBuilder();
				if (isUnbinded && isDeleted)
				{
					stringBuilder.AppendFormat("WHERE child.TypeCodeId IN ({0}) AND child.Deleted = '0'", PassportData.smethod_3(typeCodeId, ","));
				}
				else if (isUnbinded)
				{
					stringBuilder.AppendLine(string.Concat(new string[]
					{
						"WHERE child.TypeCodeId IN (",
						PassportData.smethod_3(typeCodeId, ","),
						") AND child.Location = ",
						1091.ToString(),
						" AND child.Deleted = ((1))"
					}));
				}
				else
				{
					stringBuilder.AppendLine(string.Concat(new string[]
					{
						"WHERE (child.Deleted = 1 AND child.Location = ",
						text4,
						" OR child.Deleted = 0) AND child.TypeCodeId IN (",
						PassportData.smethod_3(typeCodeId, ","),
						")",
						(idObjList == -1) ? "" : (" AND child.Id = " + idObjList.ToString())
					}));
				}
				string oldValue = "[Год ввода в эксплуатацию]";
				string newValue = "[Год ввода в эксплуатацию], (SELECT MAX(DateDoc) FROM tP_DocList WHERE idObjList = pt.Id) AS [Дата посл. ремонта]";
				string text8 = flag ? text6.Replace(oldValue, newValue) : text6;
				string commandText = string.Concat(new object[]
				{
					"SELECT pt.Id, pt.IdPassport, pt.idEquipment",
					flag3 ? ", pt.[Расположение]" : "",
					", pt.[Наименование]",
					(text8 == "") ? "" : (", " + text8),
					flag3 ? ", (SELECT MAX(Data) FROM tSchm_Move WHERE Action = 865 AND idObjList = pt.id GROUP BY idObjList) [Дата ремонта]" : "",
					(array == null || array.Length == 0) ? "" : ("," + str),
					", pt.P_Deleted\r\n\r\n FROM (SELECT child.Id, tP_Passport.id AS IdPassport, tP_Passport.idEquipment, tP_Passport.deleted as P_Deleted, \r\n",
					flag3 ? "ISNULL(c_parent.Name + ' - ' + parent.Name, c_child_location.Name) + (CASE WHEN parent.Deleted = 1 THEN ' (уд.)' ELSE '' END) AS [Расположение], child.Name AS [Наименование], " : "c_child_type.SocrName + ' - ' + child.Name AS [Наименование], ",
					"dbo.tP_CharList.Name, ISNULL(CASE WHEN tP_CharList.Type = ",
					text,
					" THEN (SELECT Name FROM vP_GetValueList WHERE id = tP_ObjectChar.Value AND ParentId = tP_CharList.idValueList AND TableName = tP_CharList.TableName) WHEN tP_CharList.Type = ",
					text2,
					" AND tP_CharList.Format = ",
					text3,
					" THEN ISNULL(CONVERT(varchar(10), tP_ObjectChar.Value, 104), '') ELSE tP_ObjectChar.Value END, '') AS CharValue \r\nFROM dbo.tSchm_ObjList AS child \r\n",
					flag3 ? "LEFT JOIN tSchm_ObjList AS parent ON ISNULL(child.IdParentAddl, child.IdParent) = parent.Id AND parent.TypeCodeId != 111 \r\nLEFT JOIN tR_Classifier AS c_parent ON parent.TypeCodeId = c_parent.Id \r\nLEFT JOIN tR_Classifier AS c_child_location ON child.Location = c_child_location.Id \r\n" : "LEFT JOIN tR_Classifier AS c_child_type ON child.TypeCodeId = c_child_type.Id \r\n",
					isDeleted ? "INNER JOIN dbo.tP_Passport ON child.Id = dbo.tP_Passport.idObjList AND dbo.tP_Passport.Deleted = '1'\r\n" : "LEFT JOIN dbo.tP_Passport ON child.Id = dbo.tP_Passport.idObjList AND dbo.tP_Passport.Deleted = 0 AND dbo.tP_Passport.isActive = 1 \r\n",
					"LEFT JOIN dbo.tP_ObjectChar ON dbo.tP_Passport.id = dbo.tP_ObjectChar.idPassport \r\nLEFT JOIN dbo.tP_CharList ON dbo.tP_ObjectChar.idObjChar = dbo.tP_CharList.id AND dbo.tP_CharList.Deleted = 0 \r\n",
					flag2 ? "LEFT JOIN dbo.vP_GetMinCabSection AS cs ON child.id = cs.idObjList \r\n" : "",
					stringBuilder,
					") sq \r\nPIVOT (MAX(CharValue) FOR sq.Name IN (",
					(text5 == "") ? "" : text5,
					flag3 ? (((text5.Length > 1) ? ", " : "") + "[Дата ремонта]") : "",
					")) AS pt",
					(array == null || array.Length == 0) ? "" : string.Concat(new string[]
					{
						" LEFT JOIN (SELECT id, [Description], Value FROM ",
						flag4 ? "vP_TransfReference" : "vP_CableReference",
						") AS SourceTable PIVOT (MIN([Value]) FOR [Description] IN (",
						text7,
						")) AS pvt ON pt.idEquipment = pvt.id"
					})
				});
				new SqlDataAdapter(new SqlCommand
				{
					CommandTimeout = 180,
					Connection = sqlConnection,
					CommandType = CommandType.Text,
					CommandText = commandText
				}).Fill(dataTable);
			}
			catch (Exception)
			{
			}
			finally
			{
				if (sqlConnection.State == ConnectionState.Open)
				{
					sqlConnection.Close();
				}
			}
			return dataTable;
		}

		public static DataTable GetCableOperationReportData(SQLSettings SqlSettings)
		{
			SqlConnection sqlConnection = new SqlConnection();
			DataTable dataTable = new DataTable();
			try
			{
				SqlDataCommand sqlDataCommand = new SqlDataCommand(SqlSettings);
				sqlConnection = PassportData.smethod_0(SqlSettings);
				sqlConnection.Open();
				string text = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdTypeValue", new string[]
				{
					";Passport;DataType;",
					"2"
				}).ToString();
				string text2 = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdTypeValue", new string[]
				{
					";Passport;DataType;",
					"3"
				}).ToString();
				string text3 = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdTypeValue", new string[]
				{
					";Passport;DateFormat;",
					"2"
				}).ToString();
				string commandText = string.Concat(new object[]
				{
					"SELECT Id, [Район], [Наименование], DateDecommissioning, DateCommissioning, DATEDIFF(day, DateDecommissioning, DateCommissioning) AS Days, Reason, [Принадлежность]  FROM (SELECT child.Id, c_child_type.SocrName + ' - ' + child.Name AS [Наименование],  ch.Name, oper.DateDecommissioning, oper.DateCommissioning, reason.Name AS Reason, ISNULL(CASE WHEN ch.Type = ",
					text,
					" THEN (SELECT Name FROM vP_GetValueList WHERE id = tP_ObjectChar.Value AND ParentId = ch.idValueList AND TableName = ch.TableName) WHEN ch.Type = ",
					text2,
					" AND ch.Format = ",
					text3,
					" THEN ISNULL(CONVERT(varchar(10), tP_ObjectChar.Value, 104), '') ELSE tP_ObjectChar.value END, '') AS CharValue  FROM dbo.tSchm_ObjList AS child  LEFT JOIN tR_Classifier AS c_child_type ON child.TypeCodeId = c_child_type.Id  LEFT JOIN dbo.tP_Passport ON child.Id = dbo.tP_Passport.idObjList AND dbo.tP_Passport.Deleted = 0 AND dbo.tP_Passport.isActive = 1  LEFT JOIN dbo.tP_ObjectChar ON dbo.tP_Passport.id = dbo.tP_ObjectChar.idPassport  LEFT JOIN dbo.tP_CharList AS ch ON dbo.tP_ObjectChar.idObjChar = ch.id AND ch.Deleted = 0 AND ch.id IN (51, 53) LEFT JOIN tP_CabOperation AS oper ON child.id = oper.idObjList AND oper.Deleted = ((0)) LEFT JOIN tP_ValueLists AS reason ON oper.Reason = reason.id AND reason.ParentKey = ';Cable;Addl;OperReason;' WHERE (child.Deleted = 1 AND child.Location = 909 OR child.Deleted = 0) AND child.TypeCodeId IN (",
					546,
					") ) sq PIVOT (MAX(CharValue) FOR sq.Name IN ([Район],[Принадлежность])) AS pt"
				});
				new SqlDataAdapter(new SqlCommand
				{
					Connection = sqlConnection,
					CommandType = CommandType.Text,
					CommandText = commandText
				}).Fill(dataTable);
			}
			catch (Exception)
			{
			}
			finally
			{
				if (sqlConnection.State == ConnectionState.Open)
				{
					sqlConnection.Close();
				}
			}
			return dataTable;
		}

		public static DataTable GetEquipmentData(SQLSettings SqlSettings, int TypeCodeId, string where, bool classifierName)
		{
			return PassportData.GetEquipmentData(SqlSettings, TypeCodeId, "", "", where, "", classifierName);
		}

		public static DataTable GetEquipmentData(SQLSettings SqlSettings, int typeCodeId, string selectAddl, string selectPivotAddl, string where, string order, bool classifierName)
		{
			SqlConnection sqlConnection = new SqlConnection();
			DataTable dataTable = new DataTable();
			try
			{
				SqlDataCommand sqlDataCommand = new SqlDataCommand(SqlSettings);
				sqlConnection = PassportData.smethod_0(SqlSettings);
				sqlConnection.Open();
				string text = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdTypeValue", new string[]
				{
					";Passport;DataType;",
					"2"
				}).ToString();
				string text2 = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdTypeValue", new string[]
				{
					";Passport;DataType;",
					"3"
				}).ToString();
				string text3 = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdTypeValue", new string[]
				{
					";Passport;DateFormat;",
					"2"
				}).ToString();
				string text4 = PassportData.smethod_1(sqlConnection, typeCodeId, "");
				string text5 = PassportData.smethod_1(sqlConnection, typeCodeId, "pt");
				string str = "";
				string text6 = "";
				string[] array = null;
				bool flag = typeCodeId == 556;
				string commandText = string.Concat(new string[]
				{
					"SELECT ISNULL(",
					(text4 == "") ? "" : "pt.",
					"Id, -1) AS id, idObjList, idEquipment, Name",
					selectAddl,
					(text5 == "") ? "" : (", " + text5),
					(array == null || array.Length == 0) ? "" : ("," + str),
					" FROM (SELECT DISTINCT p.id, ol.id AS idObjList, p.idEquipment",
					selectPivotAddl,
					", ",
					classifierName ? "ISNULL(c_ol.SocrName + ' - ', '')" : "",
					" + ol.Name AS Name , cl.Name AS CharName, ISNULL(CASE WHEN cl.Type = ",
					text,
					" AND cl.idValueList != '107' THEN (SELECT Name FROM vP_GetValueList WHERE id = oc.Value AND ParentId = cl.idValueList AND TableName = cl.TableName) WHEN cl.Type = ",
					text2,
					" AND cl.Format = ",
					text3,
					" THEN ISNULL(CONVERT(varchar(10), oc.Value, 104), '') ELSE oc.value END, '') AS Value FROM dbo.tSchm_ObjList AS ol JOIN tR_Classifier AS c_ol ON ol.TypeCodeId = c_ol.Id AND ol.Deleted = ((0))LEFT JOIN dbo.tP_Passport AS p ON ol.Id = p.idObjList AND p.Deleted = ((0)) AND p.isActive = ((1)) LEFT JOIN dbo.tP_ObjectChar AS oc ON p.id = oc.idPassport LEFT JOIN  dbo.tP_CharList AS cl ON oc.idObjChar = cl.id ",
					where,
					") sq",
					(text4 == "") ? "" : string.Concat(new string[]
					{
						" PIVOT (MAX(Value) FOR sq.CharName IN (",
						text4,
						")) AS pt ",
						(array == null || array.Length == 0) ? " " : string.Concat(new string[]
						{
							" LEFT JOIN (SELECT id, [Description], Value FROM ",
							flag ? "vP_TransfReference" : "vP_CableReference",
							") AS SourceTable PIVOT (MIN([Value]) FOR [Description] IN (",
							text6,
							")) AS pvt ON pt.idEquipment = pvt.id "
						}),
						order
					})
				});
				new SqlDataAdapter(new SqlCommand
				{
					Connection = sqlConnection,
					CommandType = CommandType.Text,
					CommandText = commandText
				}).Fill(dataTable);
			}
			catch (Exception)
			{
			}
			finally
			{
				if (sqlConnection.State == ConnectionState.Open)
				{
					sqlConnection.Close();
				}
			}
			return dataTable;
		}

		public static BindingSource GetCountEquipmentData(SQLSettings SqlSettings)
		{
			SqlConnection sqlConnection = new SqlConnection();
			DataTable dataTable = new DataTable();
			BindingSource bindingSource = new BindingSource();
			try
			{
				new SqlDataCommand(SqlSettings);
				sqlConnection = PassportData.smethod_0(SqlSettings);
				sqlConnection.Open();
				string text = PassportData.smethod_2(sqlConnection);
				string commandText = string.Concat(new string[]
				{
					"SELECT SS_Type AS [Тип], SS_Name [Наименование], SS_Balance [Принадлежность], ",
					text,
					"FROM (SELECT c_ss.Name AS SS_Type, ss.Name AS SS_Name, ss_vl.Name AS SS_Balance, c_sw.Name AS SW_Name, COUNT(sw.Id) AS SW_Count FROM tSchm_ObjList AS ss JOIN tR_Classifier AS c_ss ON ss.TypeCodeId = c_ss.id AND c_ss.id IN (535, 536, 537, 538) LEFT JOIN tSchm_ObjList AS cell ON ss.id = cell.idParent LEFT JOIN tSchm_ObjList AS sw ON cell.id = sw.idParentAddl AND sw.TypeCodeId IN (552, 553, 554, 558, 559, 903) LEFT JOIN tR_Classifier AS c_sw ON sw.TypeCodeId = c_sw.id LEFT JOIN tP_Passport AS ss_p ON ss.id = ss_p.idObjList AND ss_p.isActive = ((1)) AND ss_p.Deleted = ((0)) LEFT JOIN tP_ObjectChar AS ss_och ON ss_p.id = ss_och.idPassport AND ss_och.idObjChar = 174 LEFT JOIN tP_ValueLists AS ss_vl ON ss_och.Value = ss_vl.id WHERE ss.Deleted = ((0)) GROUP BY c_ss.Name, c_sw.Name, ss.Name, ss_vl.Name UNION SELECT c_ss.Name AS SS_Type, ss.Name AS SS_Name, ss_vl.Name AS SS_Balance, c_transf.Name AS SW_Name, COUNT(transf.Id) AS SW_Count FROM tSchm_ObjList AS ss JOIN tR_Classifier AS c_ss ON ss.TypeCodeId = c_ss.id JOIN tSchm_ObjList AS transf ON ss.id = transf.idParent AND transf.TypeCodeId = 556 JOIN tR_Classifier AS c_transf ON transf.TypeCodeId = c_transf.id LEFT JOIN tP_Passport AS ss_p ON ss.id = ss_p.idObjList AND ss_p.isActive = ((1)) AND ss_p.Deleted = ((0)) LEFT JOIN tP_ObjectChar AS ss_och ON ss_p.id = ss_och.idPassport AND ss_och.idObjChar = 174 LEFT JOIN tP_ValueLists AS ss_vl ON ss_och.Value = ss_vl.id WHERE ss.Deleted = ((0)) GROUP BY c_ss.Name, c_transf.Name, ss.Name, ss_vl.Name) AS p PIVOT (MAX(SW_Count) FOR SW_Name IN (",
					text,
					")) AS pvt ORDER BY pvt.SS_Type, pvt.SS_Name"
				});
				new SqlDataAdapter(new SqlCommand
				{
					Connection = sqlConnection,
					CommandType = CommandType.Text,
					CommandText = commandText
				}).Fill(dataTable);
				bindingSource.DataSource = dataTable;
			}
			catch (Exception)
			{
			}
			finally
			{
				if (sqlConnection.State == ConnectionState.Open)
				{
					sqlConnection.Close();
				}
			}
			return bindingSource;
		}

		public static DataTable GetProtocolClutchData(SQLSettings SqlSettings, int idObjList)
		{
			SqlConnection sqlConnection = new SqlConnection();
			DataTable dataTable = new DataTable();
			new BindingSource();
			try
			{
				new SqlDataCommand(SqlSettings);
				sqlConnection = PassportData.smethod_0(SqlSettings);
				sqlConnection.Open();
				string commandText = "SELECT id, idParent, Name, ISNULL([Тип], '') [Тип], [Дата монтажа][Дата монтажа],ISNULL([Монтаж произвел], '') [Монтаж произвел] FROM (SELECT DISTINCT ol.id, ol.idParent, ol.Name AS Name, cl.Name AS CharName,  ISNULL(CASE WHEN cl.Type = 728 AND cl.TableName = 'tP_ValueLists' THEN (SELECT Name FROM tP_ValueLists WHERE id = oc.Value AND ParentId = cl.idValueList) ELSE oc.value END, '') AS Value FROM dbo.tSchm_ObjList AS ol INNER JOIN tR_Classifier AS c_ol ON ol.TypeCodeId = c_ol.Id LEFT JOIN dbo.tP_Passport AS p ON ol.Id = p.idObjList AND p.Deleted = ((0)) AND p.isActive = ((1)) LEFT JOIN dbo.tP_ObjectChar AS oc ON p.id = oc.idPassport LEFT JOIN  dbo.tP_CharList AS cl ON oc.idObjChar = cl.id  WHERE ol.Deleted = ((0)) AND idParent = " + idObjList.ToString() + ")sq PIVOT (MAX(Value) FOR sq.CharName IN ([Тип],[Дата монтажа],[Монтаж произвел])) AS pt";
				new SqlDataAdapter(new SqlCommand
				{
					Connection = sqlConnection,
					CommandType = CommandType.Text,
					CommandText = commandText
				}).Fill(dataTable);
			}
			catch (Exception)
			{
			}
			finally
			{
				if (sqlConnection.State == ConnectionState.Open)
				{
					sqlConnection.Close();
				}
			}
			return dataTable;
		}

		public static DataTable GetRepairData(SQLSettings SqlSettings, int idObjList)
		{
			return new SqlDataCommand(SqlSettings).SelectSqlData("tP_DocList", true, "WHERE idObjList = " + idObjList.ToString() + " AND TypeDoc = 961 AND Deleted = 0 ORDER BY DateDoc DESC", null);
		}

		public static DataTable GetBuildRepairData(SQLSettings SqlSettings, int idObjList)
		{
			return new SqlDataCommand(SqlSettings).SelectSqlData("vP_BuildSubsRepair", true, "WHERE idObjList = " + idObjList.ToString() + " AND Deleted = 0", null);
		}

		public static DataTable GetBalanceData(SQLSettings SqlSettings, int idObjList)
		{
			return new SqlDataCommand(SqlSettings).SelectSqlData("vP_DocList", true, "WHERE idObjList = " + idObjList.ToString() + " AND TypeDoc = 960 AND Deleted = 0 ORDER BY DateDoc DESC", null);
		}

		public static int GetActivePassport(SQLSettings SqlSettings, int idObjList)
		{
			return (int)new SqlDataCommand(SqlSettings).CallSQLScalarFunction("dbo.fn_P_GetIdActivePassport", new string[]
			{
				idObjList.ToString()
			});
		}

		public static DateTime GetDate(SQLSettings SqlSettings, int idPassport)
		{
			DataTable dataTable = new SqlDataCommand(SqlSettings).SelectSqlData(string.Format("SELECT Date FROM tP_Passport WHERE id = {0}", idPassport));
			if (dataTable.Rows.Count > 0 && dataTable.Rows[0][0] != DBNull.Value)
			{
				return (DateTime)dataTable.Rows[0][0];
			}
			return new DateTime(1900, 1, 1);
		}

		private static SqlConnection smethod_0(SQLSettings sqlsettings_0)
		{
			if (sqlsettings_0.Autentification.ToUpper() == "WINDOWS")
			{
				return new SqlConnection(string.Concat(new string[]
				{
					"Server=",
					sqlsettings_0.ServerDB,
					"; dataBase=",
					sqlsettings_0.DBName,
					"; Integrated Security=true; Connection TimeOut = 180"
				}));
			}
			return new SqlConnection(string.Concat(new string[]
			{
				"Server=",
				sqlsettings_0.ServerDB,
				"; dataBase=",
				sqlsettings_0.DBName,
				"; uid=",
				sqlsettings_0.SqlUserConnect,
				";pwd=",
				sqlsettings_0.SqlPasswConnect,
				";Integrated Security=false; Connection TimeOut = 180"
			}));
		}

		private static string smethod_1(SqlConnection sqlConnection_0, int int_0, string string_0)
		{
			string result;
			try
			{
				string commandText = string.Concat(new string[]
				{
					"SELECT STUFF((SELECT CAST(',' AS VARCHAR(MAX)) + CAST('",
					string_0,
					(string_0.Length > 0) ? "." : "",
					"' + QUOTENAME(child.[Name]) AS VARCHAR(MAX)) FROM [dbo].[tP_CharList] AS child JOIN [dbo].[tP_CharList] AS parent ON child.ParentId = parent.id JOIN [dbo].[tP_ObjClassParamList] AS ocpl ON parent.[ParentId] = ocpl.[idParamList] AND ocpl.Deleted = ((0))  WHERE ocpl.[idClassifier] = ",
					int_0.ToString(),
					" AND child.[isGroup] = 0 AND child.[Deleted] = 0 AND child.Name != '' GROUP BY child.[Name] ORDER BY MIN(child.[TabIndex]) FOR XML PATH('')), 1, 1, '')"
				});
				result = new SqlCommand
				{
					Connection = sqlConnection_0,
					CommandType = CommandType.Text,
					CommandText = commandText
				}.ExecuteScalar().ToString();
			}
			catch (Exception)
			{
				result = "";
			}
			return result;
		}

		private static string smethod_2(SqlConnection sqlConnection_0)
		{
			string result;
			try
			{
				string commandText = "SELECT STUFF((SELECT CAST(',' AS VARCHAR(MAX)) + CAST(QUOTENAME([Name]) AS VARCHAR(MAX)) FROM tR_Classifier WHERE id IN (552, 553, 554, 558, 559, 903, 556) GROUP BY Name ORDER BY MAX(Name) FOR XML PATH('')), 1, 1, '')";
				result = new SqlCommand
				{
					Connection = sqlConnection_0,
					CommandType = CommandType.Text,
					CommandText = commandText
				}.ExecuteScalar().ToString();
			}
			catch (Exception)
			{
				result = "";
			}
			return result;
		}

		private static string smethod_3(int[] int_0, string string_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < int_0.Length; i++)
			{
				stringBuilder.Append((i == 0) ? int_0[0].ToString() : (string_0 + int_0[i].ToString()));
			}
			return stringBuilder.ToString();
		}

		private static string[] smethod_4(SQLSettings sqlsettings_0, string string_0)
		{
			return new SqlDataCommand(sqlsettings_0).SelectSqlData("SELECT Description FROM vP_TableColumnDescription WHERE [Table] = '" + string_0 + "' AND [Description] IS NOT NULL").AsEnumerable().Select(new Func<DataRow, string>(PassportData.<>c.<>9.method_0)).ToArray<string>();
		}
	}
}
