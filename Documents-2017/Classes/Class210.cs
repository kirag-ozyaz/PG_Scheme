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

[HelpKeyword("vs.data.TableAdapter"), DataObject(true), ToolboxItem(true), DesignerCategory("code"), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
internal class Class210 : Component
{
    private bool bool_0;
    private SqlCommand[] sqlCommand_0;
    private SqlConnection sqlConnection_0;
    private SqlDataAdapter sqlDataAdapter_0;
    private SqlTransaction sqlTransaction_0;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public Class210()
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
        this.sqlCommand_0[0].CommandText = "SELECT        CodeAbonent, StartDate, FIO\r\nFROM            tAbonent\r\nWHERE        (CodeAbonent = @Code)";
        this.sqlCommand_0[0].CommandType = CommandType.Text;
        this.sqlCommand_0[0].Parameters.Add(new SqlParameter("@Code", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "CodeAbonent", DataRowVersion.Current, false, null, "", "", ""));
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
            DataSetTable = "tAbonentNC",
            ColumnMappings = { 
                { 
                    "CodeAbonent",
                    "CodeAbonent"
                },
                { 
                    "StartDate",
                    "StartDate"
                },
                { 
                    "FIO",
                    "FIO"
                }
            }
        };
        this.sqlDataAdapter_0.TableMappings.Add(mapping);
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void method_9()
    {
        this.sqlConnection_0 = new SqlConnection();
        this.sqlConnection_0.ConnectionString = Settings.Default.PrvDbncConnectionString;
    }

    [HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Fill, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public virtual int vmethod_0(OrgDataSet.tAbonentNCDataTable tAbonentNCDataTable_0, int? nullable_0)
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
            tAbonentNCDataTable_0.Clear();
        }
        return this.method_0().Fill(tAbonentNCDataTable_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Select, true)]
    public virtual OrgDataSet.tAbonentNCDataTable vmethod_1(int? nullable_0)
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
        OrgDataSet.tAbonentNCDataTable dataTable = new OrgDataSet.tAbonentNCDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }
}

