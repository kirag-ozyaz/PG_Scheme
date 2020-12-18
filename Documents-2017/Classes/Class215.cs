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

[DesignerCategory("code"), HelpKeyword("vs.data.TableAdapter"), ToolboxItem(true), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), DataObject(true)]
internal class Class215 : Component
{
    private bool bool_0;
    private SqlCommand[] sqlCommand_0;
    private SqlConnection sqlConnection_0;
    private SqlDataAdapter sqlDataAdapter_0;
    private SqlTransaction sqlTransaction_0;

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Class215()
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
        this.sqlCommand_0[0].CommandText = "SELECT        id, F + ' ' + I + ' ' + O AS FIO\r\nFROM            tR_Worker\r\nWHERE        (Division = @Division) AND (DateEnd IS NULL)\r\nORDER BY FIO";
        this.sqlCommand_0[0].CommandType = CommandType.Text;
        this.sqlCommand_0[0].Parameters.Add(new SqlParameter("@Division", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Division", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[1] = new SqlCommand();
        this.sqlCommand_0[1].Connection = this.method_1();
        this.sqlCommand_0[1].CommandText = "SELECT        tR_Worker.id, tR_Worker.F + ' ' + tR_Worker.I + ' ' + tR_Worker.O AS FIO\r\nFROM            tR_Worker INNER JOIN\r\n                         tL_ClassifierWorker ON tR_Worker.id = tL_ClassifierWorker.IdWorker INNER JOIN\r\n                         tR_Classifier ON tL_ClassifierWorker.IdGroup = tR_Classifier.Id AND tR_Classifier.IsGroup = 0\r\nWHERE        (tR_Worker.DateEnd IS NULL) AND (tR_Classifier.ParentKey LIKE @Division)\r\nORDER BY FIO";
        this.sqlCommand_0[1].CommandType = CommandType.Text;
        this.sqlCommand_0[1].Parameters.Add(new SqlParameter("@Division", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, "ParentKey", DataRowVersion.Current, false, null, "", "", ""));
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
            DataSetTable = "tR_Worker",
            ColumnMappings = { 
                { 
                    "id",
                    "id"
                },
                { 
                    "FIO",
                    "FIO"
                }
            }
        };
        this.sqlDataAdapter_0.TableMappings.Add(mapping);
        this.sqlDataAdapter_0.DeleteCommand = new SqlCommand();
        this.sqlDataAdapter_0.DeleteCommand.Connection = this.method_1();
        this.sqlDataAdapter_0.DeleteCommand.CommandText = "DELETE FROM [tR_Worker] WHERE (([id] = @Original_id))";
        this.sqlDataAdapter_0.DeleteCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "id", DataRowVersion.Original, false, null, "", "", ""));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    private void method_9()
    {
        this.sqlConnection_0 = new SqlConnection();
        this.sqlConnection_0.ConnectionString = Settings.Default.trueGESConnectionString;
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int vmethod_0(OrgDataSet.tR_WorkerDataTable tR_WorkerDataTable_0, int? nullable_0)
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
            tR_WorkerDataTable_0.Clear();
        }
        return this.method_0().Fill(tR_WorkerDataTable_0);
    }

    [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Select, true)]
    public virtual OrgDataSet.tR_WorkerDataTable vmethod_1(int? nullable_0)
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
        OrgDataSet.tR_WorkerDataTable dataTable = new OrgDataSet.tR_WorkerDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Fill, false), DebuggerNonUserCode]
    public virtual int vmethod_2(OrgDataSet.tR_WorkerDataTable tR_WorkerDataTable_0, string string_0)
    {
        this.method_0().SelectCommand = this.method_5()[1];
        if (string_0 == null)
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = string_0;
        }
        if (this.method_6())
        {
            tR_WorkerDataTable_0.Clear();
        }
        return this.method_0().Fill(tR_WorkerDataTable_0);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Select, false), DebuggerNonUserCode]
    public virtual OrgDataSet.tR_WorkerDataTable vmethod_3(string string_0)
    {
        this.method_0().SelectCommand = this.method_5()[1];
        if (string_0 == null)
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = string_0;
        }
        OrgDataSet.tR_WorkerDataTable dataTable = new OrgDataSet.tR_WorkerDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_4(OrgDataSet.tR_WorkerDataTable tR_WorkerDataTable_0)
    {
        return this.method_0().Update(tR_WorkerDataTable_0);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
    public virtual int vmethod_5(OrgDataSet orgDataSet_0)
    {
        return this.method_0().Update(orgDataSet_0, "tR_Worker");
    }

    [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_6(DataRow dataRow_0)
    {
        DataRow[] dataRows = new DataRow[] { dataRow_0 };
        return this.method_0().Update(dataRows);
    }

    [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_7(DataRow[] dataRow_0)
    {
        return this.method_0().Update(dataRow_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Delete, true), DebuggerNonUserCode]
    public virtual int vmethod_8(int int_0)
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
}

