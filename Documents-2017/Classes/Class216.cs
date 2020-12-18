using Documents.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

[DesignerCategory("code"), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), HelpKeyword("vs.data.TableAdapter"), DataObject(true), ToolboxItem(true)]
internal class Class216 : Component
{
    private IDbCommand[] idbCommand_0;

    protected IDbCommand[] method_0()
    {
        if (this.idbCommand_0 == null)
        {
            this.method_1();
        }
        return this.idbCommand_0;
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void method_1()
    {
        this.idbCommand_0 = new IDbCommand[4];
        this.idbCommand_0[0] = new SqlCommand();
        ((SqlCommand) this.idbCommand_0[0]).Connection = new SqlConnection(Settings.Default.PrvDBConnectionString);
        ((SqlCommand) this.idbCommand_0[0]).CommandText = "dbo.GetAbonentAdressStr";
        ((SqlCommand) this.idbCommand_0[0]).CommandType = CommandType.StoredProcedure;
        ((SqlCommand) this.idbCommand_0[0]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.VarChar, 50, ParameterDirection.ReturnValue, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
        ((SqlCommand) this.idbCommand_0[0]).Parameters.Add(new SqlParameter("@CA", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
        this.idbCommand_0[1] = new SqlCommand();
        ((SqlCommand) this.idbCommand_0[1]).Connection = new SqlConnection(Settings.Default.PrvDbncConnectionString);
        ((SqlCommand) this.idbCommand_0[1]).CommandText = "dbo.GetAbonentAdressStr";
        ((SqlCommand) this.idbCommand_0[1]).CommandType = CommandType.StoredProcedure;
        ((SqlCommand) this.idbCommand_0[1]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.VarChar, 50, ParameterDirection.ReturnValue, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
        ((SqlCommand) this.idbCommand_0[1]).Parameters.Add(new SqlParameter("@CA", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
        this.idbCommand_0[2] = new SqlCommand();
        ((SqlCommand) this.idbCommand_0[2]).Connection = new SqlConnection(Settings.Default.PrvDBConnectionString);
        ((SqlCommand) this.idbCommand_0[2]).CommandText = "dbo.GetAbonentConnectedMatrix";
        ((SqlCommand) this.idbCommand_0[2]).CommandType = CommandType.StoredProcedure;
        ((SqlCommand) this.idbCommand_0[2]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Bit, 1, ParameterDirection.ReturnValue, 1, 0, null, DataRowVersion.Current, false, null, "", "", ""));
        ((SqlCommand) this.idbCommand_0[2]).Parameters.Add(new SqlParameter("@CA", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
        this.idbCommand_0[3] = new SqlCommand();
        ((SqlCommand) this.idbCommand_0[3]).Connection = new SqlConnection(Settings.Default.PrvDbncConnectionString);
        ((SqlCommand) this.idbCommand_0[3]).CommandText = "dbo.GetAbonentConnectedMatrix";
        ((SqlCommand) this.idbCommand_0[3]).CommandType = CommandType.StoredProcedure;
        ((SqlCommand) this.idbCommand_0[3]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Bit, 1, ParameterDirection.ReturnValue, 1, 0, null, DataRowVersion.Current, false, null, "", "", ""));
        ((SqlCommand) this.idbCommand_0[3]).Parameters.Add(new SqlParameter("@CA", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
    internal virtual string vmethod_0(int? nullable_0)
    {
        SqlCommand command = (SqlCommand) this.method_0()[0];
        if (nullable_0.HasValue)
        {
            command.Parameters[1].Value = nullable_0.Value;
        }
        else
        {
            command.Parameters[1].Value = DBNull.Value;
        }
        ConnectionState state = command.Connection.State;
        if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            command.Connection.Open();
        }
        try
        {
            command.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                command.Connection.Close();
            }
        }
        if ((command.Parameters[0].Value != null) && (command.Parameters[0].Value.GetType() != typeof(DBNull)))
        {
            return (string) command.Parameters[0].Value;
        }
        return null;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
    internal virtual string vmethod_1(int? nullable_0)
    {
        SqlCommand command = (SqlCommand) this.method_0()[1];
        if (nullable_0.HasValue)
        {
            command.Parameters[1].Value = nullable_0.Value;
        }
        else
        {
            command.Parameters[1].Value = DBNull.Value;
        }
        ConnectionState state = command.Connection.State;
        if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            command.Connection.Open();
        }
        try
        {
            command.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                command.Connection.Close();
            }
        }
        if ((command.Parameters[0].Value != null) && (command.Parameters[0].Value.GetType() != typeof(DBNull)))
        {
            return (string) command.Parameters[0].Value;
        }
        return null;
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
    internal virtual bool? vmethod_2(int? nullable_0)
    {
        SqlCommand command = (SqlCommand) this.method_0()[2];
        if (nullable_0.HasValue)
        {
            command.Parameters[1].Value = nullable_0.Value;
        }
        else
        {
            command.Parameters[1].Value = DBNull.Value;
        }
        ConnectionState state = command.Connection.State;
        if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            command.Connection.Open();
        }
        try
        {
            command.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                command.Connection.Close();
            }
        }
        if ((command.Parameters[0].Value != null) && (command.Parameters[0].Value.GetType() != typeof(DBNull)))
        {
            return new bool?((bool) command.Parameters[0].Value);
        }
        return null;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
    internal virtual bool? vmethod_3(int? nullable_0)
    {
        SqlCommand command = (SqlCommand) this.method_0()[3];
        if (nullable_0.HasValue)
        {
            command.Parameters[1].Value = nullable_0.Value;
        }
        else
        {
            command.Parameters[1].Value = DBNull.Value;
        }
        ConnectionState state = command.Connection.State;
        if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            command.Connection.Open();
        }
        try
        {
            command.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                command.Connection.Close();
            }
        }
        if ((command.Parameters[0].Value != null) && (command.Parameters[0].Value.GetType() != typeof(DBNull)))
        {
            return new bool?((bool) command.Parameters[0].Value);
        }
        return null;
    }
}

