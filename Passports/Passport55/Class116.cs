using System;
using System.Data;
using System.Data.SqlClient;
using DataSql;

internal class Class116
{
	internal void method_0()
	{
		if (this.sqlConnection_0.State == ConnectionState.Open)
		{
			this.sqlConnection_0.Close();
		}
	}

	internal string method_1()
	{
		return this.string_0;
	}

	internal void method_2(string string_1)
	{
		this.string_0 = string_1;
	}

	internal string method_3(int int_0)
	{
		return "<objOnLine ID=\"" + int_0.ToString() + "\" />";
	}

	internal void method_4()
	{
		this.sqlTransaction_0.Commit();
	}

	internal void method_5()
	{
		this.sqlTransaction_0.Rollback();
	}

	internal Class116(SQLSettings sqlsettings_1)
	{
		try
		{
			this.sqlsettings_0 = sqlsettings_1;
			this.sqlConnection_0 = this.method_27(this.sqlsettings_0);
			this.sqlConnection_0.Open();
			this.sqlTransaction_0 = this.sqlConnection_0.BeginTransaction();
		}
		catch (Exception)
		{
		}
	}

	internal bool method_6(int int_0, string string_1)
	{
		string string_2 = string.Format("SELECT COUNT(Direction) FROM tSchm_Move WHERE Direction = '{1}' AND idObjList = {0} AND Deleted = ((0)) AND Data IN (SELECT MAX(Data) FROM tSchm_Move WHERE idObjList = {0} AND Deleted = ((0)))", int_0, string_1);
		return (int)this.method_29(this.sqlTransaction_0, string_2) > 0;
	}

	internal bool method_7(int int_0)
	{
		string string_ = "SELECT COUNT(*) FROM tSchm_ObjList WHERE EXISTS(SELECT * FROM tSchm_Relation WHERE tSchm_ObjList.IdParent = tSchm_Relation.id) AND Location IS NULL AND Deleted = 0 AND Id = " + int_0.ToString();
		return (int)this.method_29(this.sqlTransaction_0, string_) > 0;
	}

	internal bool method_8(int int_0)
	{
		string string_ = string.Format("SELECT Count(T.o.value('@ID', 'int')) FROM tSchm_Relation AS rel INNER JOIN tSchm_Xml AS x ON rel.Edge = x.ObjId CROSS APPLY x.SchemaXml.nodes('/Obj/Branch/objOnLine') AS T(o) INNER JOIN tSchm_ObjList AS obj ON T.o.value('@ID', 'int') = obj.Id WHERE obj.Deleted = ((0)) AND obj.TypeCodeId = 556 AND rel.Edge = {0}", int_0);
		return (int)this.method_29(this.sqlTransaction_0, string_) > 0;
	}

	internal bool method_9(int int_0)
	{
		string string_ = string.Format("SELECT COUNT(*) FROM tSchm_Xml WHERE [ObjId] = {0}", int_0);
		return (int)this.method_29(this.sqlTransaction_0, string_) > 0;
	}

	internal int method_10(int int_0)
	{
		string string_ = string.Format("SELECT TOP 1 tSchm_Relation.Id FROM tSchm_Relation WHERE tSchm_Relation.Edge = {0}", int_0);
		int result;
		if (int.TryParse(Convert.ToString(this.method_29(this.sqlTransaction_0, string_)), out result))
		{
			return result;
		}
		return -1;
	}

	internal int method_11(int int_0)
	{
		string string_ = string.Format("SELECT tSchm_Relation.Edge FROM tSchm_ObjList INNER JOIN tSchm_Relation ON tSchm_ObjList.IdParent = tSchm_Relation.id WHERE Location IS NULL AND tSchm_ObjList.Deleted = 0 AND tSchm_ObjList.Id = {0}", int_0);
		int result;
		if (int.TryParse(this.method_29(this.sqlTransaction_0, string_).ToString(), out result))
		{
			return result;
		}
		return -1;
	}

	internal int method_12(string string_1, double double_0)
	{
		int result = -1;
		string string_2 = string.Format("SELECT TOP 1 [Id] FROM [tR_Classifier] WHERE ParentKey = '{0}' AND Value = {1}", string_1, double_0);
		if (!int.TryParse(((int)this.method_29(this.sqlTransaction_0, string_2)).ToString(), out result))
		{
			return -1;
		}
		return result;
	}

	internal int method_13(int int_0)
	{
		string string_ = string.Format("SELECT MAX(TypeSchema) FROM tSchm_Xml WHERE ObjId = {0}", int_0);
		int result;
		if (int.TryParse(this.method_29(this.sqlTransaction_0, string_).ToString(), out result))
		{
			return result;
		}
		return 1;
	}

	internal int method_14(int int_0)
	{
		string string_ = string.Format("SELECT TOP 1 ISNULL(IdParent, IdParentAddl) FROM tSchm_ObjList WHERE tSchm_ObjList.Deleted = 0 AND tSchm_ObjList.Id = {0}", int_0);
		int result;
		if (int.TryParse(this.method_29(this.sqlTransaction_0, string_).ToString(), out result))
		{
			return result;
		}
		return -1;
	}

	internal string method_15(int int_0)
	{
		string string_ = "SELECT ISNULL(c_parent.Name + ' - ' + parent.Name, c_child_location.Name) AS Direction FROM dbo.tSchm_ObjList AS child LEFT JOIN tSchm_ObjList AS parent ON ISNULL(child.IdParentAddl, child.IdParent) = parent.Id AND parent.Deleted = 0 AND parent.TypeCodeId != 111 LEFT JOIN tR_Classifier AS c_parent ON parent.TypeCodeId = c_parent.Id LEFT JOIN tR_Classifier AS c_child_location ON child.Location = c_child_location.Id WHERE child.Deleted = 0 AND child.Id = " + int_0.ToString();
		return this.method_29(this.sqlTransaction_0, string_).ToString();
	}

	internal string method_16(int int_0)
	{
		string string_ = "SELECT ISNULL(c.SocrName + ' - ' + o.Name, o.Name) FROM tSchm_ObjList AS o INNER JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id INNER JOIN tSchm_ObjList AS child ON o.Id = ISNULL(child.IdParent, child.idParentAddl) WHERE child.Id = " + int_0.ToString();
		return Convert.ToString(this.method_29(this.sqlTransaction_0, string_));
	}

	internal void method_17(int int_0, out int int_1, out int int_2, out int int_3)
	{
		int_3 = -1;
		int_2 = -1;
		int_1 = -1;
		string string_ = "SELECT idParent, idParentAddl, Location FROM tSchm_ObjList WHERE Id = " + int_0.ToString();
		DataTable dataTable = this.method_31(this.sqlTransaction_0, string_);
		if (dataTable.Rows.Count == 0)
		{
			throw new Exception("Rollback transformator error.", new Exception("Data of transformator not found."));
		}
		int_1 = (int.TryParse(dataTable.Rows[0]["idParent"].ToString(), out int_1) ? int_1 : -1);
		int_2 = (int.TryParse(dataTable.Rows[0]["idParentAddl"].ToString(), out int_2) ? int_2 : -1);
		int_3 = (int.TryParse(dataTable.Rows[0]["Location"].ToString(), out int_3) ? int_3 : -1);
	}

	internal void method_18(int int_0, int int_1, out string string_1, out string string_2)
	{
		string string_3 = string.Concat(new string[]
		{
			"SELECT RelationId, ISNULL([1], '') AS [1], ISNULL([2], '') AS [2] FROM (SELECT p_xml.TypeSchema, CAST(p_xml.SchemaXml.query('/Obj/Branch/objOnLine[@ID = \"",
			int_0.ToString(),
			"\"]') AS VARCHAR(100)) AS XmlNode, p_xml.SchemaXml.value('(/Obj/Branch/objOnLine[@ID = \"",
			int_0.ToString(),
			"\"]/../@relationId)[1]', 'int') AS RelationId FROM tSchm_Xml p_xml WHERE p_xml.ObjId = ",
			int_1.ToString(),
			") AS SourceTable PIVOT (MAX(XmlNode) FOR TypeSchema IN ([1], [2]) ) AS PivotTable"
		});
		DataTable dataTable = this.method_31(this.sqlTransaction_0, string_3);
		string_1 = dataTable.Rows[0]["1"].ToString();
		string_2 = dataTable.Rows[0]["2"].ToString();
	}

	internal void method_19(int int_0, out string string_1, out string string_2)
	{
		string string_3 = "SELECT ObjId, [1], [2] FROM (SELECT ObjId, TypeSchema, CAST(SchemaXml AS VARCHAR(MAX)) AS SchemaXml FROM tSchm_Xml WHERE ObjId = " + int_0.ToString() + ") AS SourceTable PIVOT (MAX(SchemaXml) FOR TypeSchema IN ([1], [2]) ) AS PivotTable";
		DataTable dataTable = this.method_31(this.sqlTransaction_0, string_3);
		if (dataTable.Rows[0][0] == DBNull.Value)
		{
			throw new Exception("Rollback transformator error.", new Exception("Xml cells not found."));
		}
		string_1 = dataTable.Rows[0]["1"].ToString();
		string_2 = dataTable.Rows[0]["2"].ToString();
	}

	internal bool method_20(int int_0, int int_1, int int_2, int int_3, int int_4, string string_1, string string_2, string string_3, string string_4, DateTime dateTime_0, int int_5, string string_5, string string_6, bool bool_0)
	{
		string[] array = new string[15];
		array[0] = int_0.ToString();
		array[1] = int_1.ToString();
		array[2] = int_2.ToString();
		array[3] = int_3.ToString();
		array[4] = int_4.ToString();
		array[5] = string_1;
		array[6] = string_2;
		array[7] = string_3;
		array[8] = string_4;
		array[9] = dateTime_0.ToString("MM/dd/yyyy HH:MM:ss");
		array[10] = int_5.ToString();
		array[11] = string_5;
		array[12] = string_6;
		array[13] = (bool_0 ? "1" : "0");
		string string_7 = string.Format("INSERT INTO [tSchm_Move] ([idObjList] ,[idRelation] ,[idCell] ,[idSubstation] ,[Location] ,[XmlCellFirst] ,[XmlCellSecond] ,[XmlTransfFirst] ,[XmlTransfSecond] ,[Data] ,[Action] ,[Direction] ,[Comment] ,[Deleted]) VALUES ({0}, {1}, {2}, {3}, {4}, CAST('{5}' AS XML), CAST('{6}' AS XML), CAST('{7}' AS XML), CAST('{8}' AS XML), CAST('{9}' AS SMALLDATETIME), {10}, '{11}', '{12}', (({13})))", array);
		return this.method_33(this.sqlTransaction_0, string_7);
	}

	internal bool method_21(int int_0, int int_1, int int_2)
	{
		string string_ = string.Concat(new string[]
		{
			"UPDATE tSchm_Xml SET SchemaXml.modify('insert <objOnLine ID=\"",
			int_2.ToString(),
			"\" /> as first into (/Obj/Branch[@relationId=\"",
			int_1.ToString(),
			"\"])[1]') WHERE ObjId = ",
			int_0.ToString()
		});
		return this.method_33(this.sqlTransaction_0, string_);
	}

	internal bool method_22(int int_0, int int_1)
	{
		string string_ = string.Concat(new object[]
		{
			"UPDATE tSchm_Xml SET SchemaXml.modify('delete (/Obj/Branch/objOnLine[@ID = \"",
			int_1,
			"\"])[1]') WHERE ObjId = ",
			int_0.ToString()
		});
		return this.method_33(this.sqlTransaction_0, string_);
	}

	internal bool method_23(int int_0, int int_1)
	{
		string string_ = string.Concat(new string[]
		{
			"INSERT INTO tSchm_Xml ([ObjId], [TypeSchema], [SchemaXml]) VALUES (",
			int_0.ToString(),
			", ",
			int_1.ToString(),
			", CAST('<Obj delta=\"0.5\" />' AS XML))"
		});
		return this.method_33(this.sqlTransaction_0, string_);
	}

	internal bool method_24(int int_0, int int_1)
	{
		string string_ = string.Format("UPDATE tSchm_ObjList SET [idParent] = NULL, [idParentAddl] = NULL, [Location] = {0} ,[Deleted] = ((1)) WHERE Id = {1}", int_0, int_1);
		return this.method_33(this.sqlTransaction_0, string_);
	}

	internal bool method_25(int int_0, int int_1)
	{
		string string_ = string.Format("UPDATE [tSchm_ObjList] SET [IdParent] = NULL ,[Location] = {0} ,[idParentAddl] = NULL WHERE Id = {1}", int_0, int_1);
		return this.method_33(this.sqlTransaction_0, string_);
	}

	internal bool method_26(int int_0, int int_1, int int_2, string string_1)
	{
		string string_2 = string.Format("UPDATE [tSchm_ObjList] SET [IdParent] = {1} ,[Name] = '{3}',[Location] = NULL ,[idParentAddl] = {2} WHERE Id = {0}", new object[]
		{
			int_0,
			(int_1 == -1) ? int_2 : int_1,
			int_2,
			"Т" + string_1
		});
		return this.method_33(this.sqlTransaction_0, string_2);
	}

	private SqlConnection method_27(SQLSettings sqlsettings_1)
	{
		if (sqlsettings_1.Autentification.ToUpper() == "WINDOWS")
		{
			return new SqlConnection(string.Concat(new string[]
			{
				"Server=",
				sqlsettings_1.ServerDB,
				"; dataBase=",
				sqlsettings_1.DBName,
				"; Integrated Security=true; Connection TimeOut = 180"
			}));
		}
		return new SqlConnection(string.Concat(new string[]
		{
			"Server=",
			sqlsettings_1.ServerDB,
			"; dataBase=",
			sqlsettings_1.DBName,
			"; uid=",
			sqlsettings_1.SqlUserConnect,
			";pwd=",
			sqlsettings_1.SqlPasswConnect,
			";Integrated Security=false; Connection TimeOut = 180"
		}));
	}

	private object method_28(string string_1)
	{
		return this.method_29(null, string_1);
	}

	private object method_29(SqlTransaction sqlTransaction_1, string string_1)
	{
		object result;
		try
		{
			result = new SqlCommand
			{
				Connection = this.sqlConnection_0,
				Transaction = sqlTransaction_1,
				CommandType = CommandType.Text,
				CommandText = string_1
			}.ExecuteScalar();
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	private DataTable method_30(string string_1)
	{
		return this.method_31(null, string_1);
	}

	private DataTable method_31(SqlTransaction sqlTransaction_1, string string_1)
	{
		DataTable result;
		try
		{
			DataTable dataTable = new DataTable();
			new SqlDataAdapter(new SqlCommand
			{
				Connection = this.sqlConnection_0,
				Transaction = sqlTransaction_1,
				CommandType = CommandType.Text,
				CommandText = string_1
			}).Fill(dataTable);
			result = dataTable;
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	private bool method_32(string string_1)
	{
		return this.method_33(null, string_1);
	}

	private bool method_33(SqlTransaction sqlTransaction_1, string string_1)
	{
		bool result;
		try
		{
			new DataTable();
			result = (new SqlCommand
			{
				Connection = this.sqlConnection_0,
				Transaction = sqlTransaction_1,
				CommandType = CommandType.Text,
				CommandText = string_1
			}.ExecuteNonQuery() > 0);
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	private SQLSettings sqlsettings_0;

	private SqlConnection sqlConnection_0;

	private SqlTransaction sqlTransaction_0;

	private string string_0 = "<Obj delta=\"0.5\" />";
}
