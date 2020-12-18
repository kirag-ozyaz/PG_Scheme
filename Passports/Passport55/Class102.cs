using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using Passport.DataSets;
using Passport.Properties;

[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
internal class Class102 : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class102()
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
		if (this.method_0() != null && this.method_0().DeleteCommand != null)
		{
			this.method_0().DeleteCommand.Transaction = this.sqlTransaction_0;
		}
		if (this.method_0() != null && this.method_0().InsertCommand != null)
		{
			this.method_0().InsertCommand.Transaction = this.sqlTransaction_0;
		}
		if (this.method_0() != null && this.method_0().UpdateCommand != null)
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void method_8()
	{
		this.sqlDataAdapter_0 = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "fn_PassportChar";
		dataTableMapping.ColumnMappings.Add("id", "id");
		dataTableMapping.ColumnMappings.Add("ParentId", "ParentId");
		dataTableMapping.ColumnMappings.Add("ParentKey", "ParentKey");
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		dataTableMapping.ColumnMappings.Add("Type", "Type");
		dataTableMapping.ColumnMappings.Add("TabIndex", "TabIndex");
		dataTableMapping.ColumnMappings.Add("isGroup", "isGroup");
		this.sqlDataAdapter_0.TableMappings.Add(dataTableMapping);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void method_9()
	{
		this.sqlConnection_0 = new SqlConnection();
		this.sqlConnection_0.ConnectionString = Settings.Default.GESConnectionString;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void method_10()
	{
		this.sqlCommand_0 = new SqlCommand[1];
		this.sqlCommand_0[0] = new SqlCommand();
		this.sqlCommand_0[0].Connection = this.method_1();
		this.sqlCommand_0[0].CommandText = "SELECT id, ParentId, ParentKey, Name, Type, TabIndex, isGroup FROM dbo.fn_PassportChar(@ParentKey)";
		this.sqlCommand_0[0].CommandType = CommandType.Text;
		this.sqlCommand_0[0].Parameters.Add(new SqlParameter("@ParentKey", SqlDbType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, false, null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[DebuggerNonUserCode]
	public virtual int vmethod_0(dsPassport.fn_PassportCharDataTable fn_PassportCharDataTable_0, string string_0)
	{
		this.method_0().SelectCommand = this.method_5()[0];
		if (string_0 == null)
		{
			throw new ArgumentNullException("ParentKey");
		}
		this.method_0().SelectCommand.Parameters[0].Value = string_0;
		if (this.method_6())
		{
			fn_PassportCharDataTable_0.Clear();
		}
		return this.method_0().Fill(fn_PassportCharDataTable_0);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual dsPassport.fn_PassportCharDataTable vmethod_1(string string_0)
	{
		this.method_0().SelectCommand = this.method_5()[0];
		if (string_0 == null)
		{
			throw new ArgumentNullException("ParentKey");
		}
		this.method_0().SelectCommand.Parameters[0].Value = string_0;
		dsPassport.fn_PassportCharDataTable fn_PassportCharDataTable = new dsPassport.fn_PassportCharDataTable();
		this.method_0().Fill(fn_PassportCharDataTable);
		return fn_PassportCharDataTable;
	}

	private SqlDataAdapter sqlDataAdapter_0;

	private SqlConnection sqlConnection_0;

	private SqlTransaction sqlTransaction_0;

	private SqlCommand[] sqlCommand_0;

	private bool bool_0;
}
