using Documents.DataSets;
using Documents.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

[HelpKeyword("vs.data.TableAdapter"), ToolboxItem(true), DataObject(true), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), DesignerCategory("code")]
internal class Class211 : Component
{
    private bool bool_0;
    private SqlCommand[] sqlCommand_0;
    private SqlConnection sqlConnection_0;
    private SqlDataAdapter sqlDataAdapter_0;
    private SqlTransaction sqlTransaction_0;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public Class211()
    {
        this.method_7(true);
    }

    protected internal SqlDataAdapter method_0()
    {
        if (this.sqlDataAdapter_0 == null)
        {
            this.method_8();
        }
        return this.sqlDataAdapter_0;
    }

    internal SqlConnection method_1()
    {
        if (this.sqlConnection_0 == null)
        {
            this.method_9();
        }
        return this.sqlConnection_0;
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void method_10()
    {
        this.sqlCommand_0 = new SqlCommand[] { new SqlCommand() };
        this.sqlCommand_0[0].Connection = this.method_1();
        this.sqlCommand_0[0].CommandText = "SELECT Id, Point FROM dbo.tblAbnAplConnectPointForIndividualUsers";
        this.sqlCommand_0[0].CommandType = CommandType.Text;
    }

    internal void method_2(SqlConnection sqlConnection_1)
    {
        this.sqlConnection_0 = sqlConnection_1;
        if (this.method_0().InsertCommand != null)
        {
            this.method_0().InsertCommand.Connection = sqlConnection_1;
        }
        if (this.method_0().DeleteCommand != null)
        {
            this.method_0().DeleteCommand.Connection = sqlConnection_1;
        }
        if (this.method_0().UpdateCommand != null)
        {
            this.method_0().UpdateCommand.Connection = sqlConnection_1;
        }
        for (int i = 0; i < this.method_5().Length; i++)
        {
            if (this.method_5()[i] != null)
            {
                this.method_5()[i].Connection = sqlConnection_1;
            }
        }
    }

    internal SqlTransaction method_3()
    {
        return this.sqlTransaction_0;
    }

    internal void method_4(SqlTransaction sqlTransaction_1)
    {
        this.sqlTransaction_0 = sqlTransaction_1;
        for (int i = 0; i < this.method_5().Length; i++)
        {
            this.method_5()[i].Transaction = this.sqlTransaction_0;
        }
        if ((this.method_0() != null) && (this.method_0().DeleteCommand != null))
        {
            this.method_0().DeleteCommand.Transaction = this.sqlTransaction_0;
        }
        if ((this.method_0() != null) && (this.method_0().InsertCommand != null))
        {
            this.method_0().InsertCommand.Transaction = this.sqlTransaction_0;
        }
        if ((this.method_0() != null) && (this.method_0().UpdateCommand != null))
        {
            this.method_0().UpdateCommand.Transaction = this.sqlTransaction_0;
        }
    }

    protected SqlCommand[] method_5()
    {
        if (this.sqlCommand_0 == null)
        {
            this.method_10();
        }
        return this.sqlCommand_0;
    }

    public bool method_6()
    {
        return this.bool_0;
    }

    public void method_7(bool bool_1)
    {
        this.bool_0 = bool_1;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    private void method_8()
    {
        this.sqlDataAdapter_0 = new SqlDataAdapter();
        DataTableMapping mapping = new DataTableMapping {
            SourceTable = "Table",
            DataSetTable = "tblAbnAplConnectPointForIndividualUsers",
            ColumnMappings = { 
                { 
                    "Id",
                    "Id"
                },
                { 
                    "Point",
                    "Point"
                }
            }
        };
        this.sqlDataAdapter_0.TableMappings.Add(mapping);
        this.sqlDataAdapter_0.DeleteCommand = new SqlCommand();
        this.sqlDataAdapter_0.DeleteCommand.Connection = this.method_1();
        this.sqlDataAdapter_0.DeleteCommand.CommandText = "DELETE FROM [dbo].[tblAbnAplConnectPointForIndividualUsers] WHERE (([Id] = @Original_Id) AND ((@IsNull_Point = 1 AND [Point] IS NULL) OR ([Point] = @Original_Point)))";
        this.sqlDataAdapter_0.DeleteCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Point", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Point", DataRowVersion.Original, true, null, "", "", ""));
        this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Point", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Point", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand = new SqlCommand();
        this.sqlDataAdapter_0.InsertCommand.Connection = this.method_1();
        this.sqlDataAdapter_0.InsertCommand.CommandText = "INSERT INTO [dbo].[tblAbnAplConnectPointForIndividualUsers] ([Point]) VALUES (@Point);\r\nSELECT Id, Point FROM tblAbnAplConnectPointForIndividualUsers WHERE (Id = SCOPE_IDENTITY())";
        this.sqlDataAdapter_0.InsertCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Point", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Point", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand = new SqlCommand();
        this.sqlDataAdapter_0.UpdateCommand.Connection = this.method_1();
        this.sqlDataAdapter_0.UpdateCommand.CommandText = "UPDATE       tblAbnAplConnectPointForIndividualUsers\r\nSET                Point = @Point\r\nWHERE        (Id = @Original_Id); \r\nSELECT Id, Point FROM tblAbnAplConnectPointForIndividualUsers WHERE (Id = @Id)";
        this.sqlDataAdapter_0.UpdateCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Point", SqlDbType.NVarChar, 0xff, ParameterDirection.Input, 0, 0, "Point", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Original, false, null, "", "", ""));
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void method_9()
    {
        this.sqlConnection_0 = new SqlConnection();
        this.sqlConnection_0.ConnectionString = Settings.Default.trueGESConnectionString;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Fill, true), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
    public virtual int vmethod_0(OrgDataSet.tblAbnAplConnectPointForIndividualUsersDataTable tblAbnAplConnectPointForIndividualUsersDataTable_0)
    {
        this.method_0().SelectCommand = this.method_5()[0];
        if (this.method_6())
        {
            tblAbnAplConnectPointForIndividualUsersDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplConnectPointForIndividualUsersDataTable_0);
    }

    [DataObjectMethod(DataObjectMethodType.Select, true), HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public virtual OrgDataSet.tblAbnAplConnectPointForIndividualUsersDataTable vmethod_1()
    {
        this.method_0().SelectCommand = this.method_5()[0];
        OrgDataSet.tblAbnAplConnectPointForIndividualUsersDataTable dataTable = new OrgDataSet.tblAbnAplConnectPointForIndividualUsersDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
    public virtual int vmethod_2(OrgDataSet.tblAbnAplConnectPointForIndividualUsersDataTable tblAbnAplConnectPointForIndividualUsersDataTable_0)
    {
        return this.method_0().Update(tblAbnAplConnectPointForIndividualUsersDataTable_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public virtual int vmethod_3(OrgDataSet orgDataSet_0)
    {
        return this.method_0().Update(orgDataSet_0, "tblAbnAplConnectPointForIndividualUsers");
    }

    [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public virtual int vmethod_4(DataRow dataRow_0)
    {
        DataRow[] dataRows = new DataRow[] { dataRow_0 };
        return this.method_0().Update(dataRows);
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_5(DataRow[] dataRow_0)
    {
        return this.method_0().Update(dataRow_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Delete, true), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_6(int? nullable_0, string string_0)
    {
        int num;
        if (nullable_0.HasValue)
        {
            this.method_0().DeleteCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().DeleteCommand.Parameters[0].Value = DBNull.Value;
        }
        if (string_0 == null)
        {
            this.method_0().DeleteCommand.Parameters[1].Value = 1;
            this.method_0().DeleteCommand.Parameters[2].Value = DBNull.Value;
        }
        else
        {
            this.method_0().DeleteCommand.Parameters[1].Value = 0;
            this.method_0().DeleteCommand.Parameters[2].Value = string_0;
        }
        ConnectionState state = this.method_0().DeleteCommand.Connection.State;
        if ((this.method_0().DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            this.method_0().DeleteCommand.Connection.Open();
        }
        try
        {
            num = this.method_0().DeleteCommand.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                this.method_0().DeleteCommand.Connection.Close();
            }
        }
        return num;
    }

    [DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Insert, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_7(string string_0)
    {
        int num;
        if (string_0 == null)
        {
            this.method_0().InsertCommand.Parameters[0].Value = DBNull.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[0].Value = string_0;
        }
        ConnectionState state = this.method_0().InsertCommand.Connection.State;
        if ((this.method_0().InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            this.method_0().InsertCommand.Connection.Open();
        }
        try
        {
            num = this.method_0().InsertCommand.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                this.method_0().InsertCommand.Connection.Close();
            }
        }
        return num;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Update, true), DebuggerNonUserCode]
    public virtual int vmethod_8(string string_0, int? nullable_0, int? nullable_1)
    {
        int num;
        if (string_0 == null)
        {
            this.method_0().UpdateCommand.Parameters[0].Value = DBNull.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[0].Value = string_0;
        }
        if (nullable_0.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[1].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[1].Value = DBNull.Value;
        }
        if (nullable_1.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[2].Value = nullable_1.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[2].Value = DBNull.Value;
        }
        ConnectionState state = this.method_0().UpdateCommand.Connection.State;
        if ((this.method_0().UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            this.method_0().UpdateCommand.Connection.Open();
        }
        try
        {
            num = this.method_0().UpdateCommand.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                this.method_0().UpdateCommand.Connection.Close();
            }
        }
        return num;
    }
}

