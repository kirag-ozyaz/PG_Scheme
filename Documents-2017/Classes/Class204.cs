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

[HelpKeyword("vs.data.TableAdapter"), ToolboxItem(true), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), DesignerCategory("code"), DataObject(true)]
internal class Class204 : Component
{
    private bool bool_0;
    private SqlCommand[] sqlCommand_0;
    private SqlConnection sqlConnection_0;
    private SqlDataAdapter sqlDataAdapter_0;
    private SqlTransaction sqlTransaction_0;

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Class204()
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
        this.sqlCommand_0 = new SqlCommand[2];
        this.sqlCommand_0[0] = new SqlCommand();
        this.sqlCommand_0[0].Connection = this.method_1();
        this.sqlCommand_0[0].CommandText = "SELECT        Id, Reason, IdTypeApl\r\nFROM            tblAbnAplForDisconReason\r\nWHERE        (IdTypeApl = @IdTypeApl)";
        this.sqlCommand_0[0].CommandType = CommandType.Text;
        this.sqlCommand_0[0].Parameters.Add(new SqlParameter("@IdTypeApl", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdTypeApl", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[1] = new SqlCommand();
        this.sqlCommand_0[1].Connection = this.method_1();
        this.sqlCommand_0[1].CommandText = "SELECT        Reason\r\nFROM            tblAbnAplForDisconReason\r\nWHERE        (Id = @Id)";
        this.sqlCommand_0[1].CommandType = CommandType.Text;
        this.sqlCommand_0[1].Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Current, false, null, "", "", ""));
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

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void method_8()
    {
        this.sqlDataAdapter_0 = new SqlDataAdapter();
        DataTableMapping mapping = new DataTableMapping {
            SourceTable = "Table",
            DataSetTable = "tblAbnAplForDisconReason",
            ColumnMappings = { 
                { 
                    "Id",
                    "Id"
                },
                { 
                    "Reason",
                    "Reason"
                },
                { 
                    "IdTypeApl",
                    "IdTypeApl"
                }
            }
        };
        this.sqlDataAdapter_0.TableMappings.Add(mapping);
        this.sqlDataAdapter_0.DeleteCommand = new SqlCommand();
        this.sqlDataAdapter_0.DeleteCommand.Connection = this.method_1();
        this.sqlDataAdapter_0.DeleteCommand.CommandText = "DELETE FROM tblAbnAplForDisconReason\r\nWHERE        (Id = @Original_Id)";
        this.sqlDataAdapter_0.DeleteCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand = new SqlCommand();
        this.sqlDataAdapter_0.InsertCommand.Connection = this.method_1();
        this.sqlDataAdapter_0.InsertCommand.CommandText = "INSERT INTO [tblAbnAplForDisconReason] ([Reason], [IdTypeApl]) VALUES (@Reason, @IdTypeApl);\r\nSELECT Id, Reason, IdTypeApl FROM tblAbnAplForDisconReason WHERE (Id = SCOPE_IDENTITY())";
        this.sqlDataAdapter_0.InsertCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Reason", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Reason", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@IdTypeApl", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdTypeApl", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand = new SqlCommand();
        this.sqlDataAdapter_0.UpdateCommand.Connection = this.method_1();
        this.sqlDataAdapter_0.UpdateCommand.CommandText = "UPDATE       tblAbnAplForDisconReason\r\nSET                Reason = @Reason, IdTypeApl = @IdTypeApl\r\nWHERE        (Id = @Original_Id); \r\nSELECT Id, Reason, IdTypeApl FROM tblAbnAplForDisconReason WHERE (Id = @Id)";
        this.sqlDataAdapter_0.UpdateCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Reason", SqlDbType.NVarChar, 100, ParameterDirection.Input, 0, 0, "Reason", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IdTypeApl", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdTypeApl", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Original, false, null, "", "", ""));
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void method_9()
    {
        this.sqlConnection_0 = new SqlConnection();
        this.sqlConnection_0.ConnectionString = Settings.Default.trueGESConnectionString;
    }

    [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Fill, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_0(OrgDataSet.tblAbnAplForDisconReasonDataTable tblAbnAplForDisconReasonDataTable_0, int? nullable_0)
    {
        this.method_0().SelectCommand = this.method_5()[0];
        if (nullable_0.HasValue)
        {
            this.method_0().SelectCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        if (this.method_6())
        {
            tblAbnAplForDisconReasonDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconReasonDataTable_0);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Select, true), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
    public virtual OrgDataSet.tblAbnAplForDisconReasonDataTable vmethod_1(int? nullable_0)
    {
        this.method_0().SelectCommand = this.method_5()[0];
        if (nullable_0.HasValue)
        {
            this.method_0().SelectCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        OrgDataSet.tblAbnAplForDisconReasonDataTable dataTable = new OrgDataSet.tblAbnAplForDisconReasonDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_2(OrgDataSet.tblAbnAplForDisconReasonDataTable tblAbnAplForDisconReasonDataTable_0)
    {
        return this.method_0().Update(tblAbnAplForDisconReasonDataTable_0);
    }

    [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_3(OrgDataSet orgDataSet_0)
    {
        return this.method_0().Update(orgDataSet_0, "tblAbnAplForDisconReason");
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_4(DataRow dataRow_0)
    {
        DataRow[] dataRows = new DataRow[] { dataRow_0 };
        return this.method_0().Update(dataRows);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
    public virtual int vmethod_5(DataRow[] dataRow_0)
    {
        return this.method_0().Update(dataRow_0);
    }

    [DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Delete, true), HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_6(int int_0)
    {
        int num;
        this.method_0().DeleteCommand.Parameters[0].Value = int_0;
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

    [DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Insert, true), HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_7(string string_0, int? nullable_0)
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
        if (nullable_0.HasValue)
        {
            this.method_0().InsertCommand.Parameters[1].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[1].Value = DBNull.Value;
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Update, true), HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_8(string string_0, int? nullable_0, int int_0, int int_1)
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
        this.method_0().UpdateCommand.Parameters[2].Value = int_0;
        this.method_0().UpdateCommand.Parameters[3].Value = int_1;
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

    [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual object vmethod_9(int int_0)
    {
        object obj2;
        SqlCommand command = this.method_5()[1];
        command.Parameters[0].Value = int_0;
        ConnectionState state = command.Connection.State;
        if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            command.Connection.Open();
        }
        try
        {
            obj2 = command.ExecuteScalar();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                command.Connection.Close();
            }
        }
        if ((obj2 != null) && (obj2.GetType() != typeof(DBNull)))
        {
            return obj2;
        }
        return null;
    }
}

