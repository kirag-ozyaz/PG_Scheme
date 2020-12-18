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

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[DataObject(true)]
[ToolboxItem(true)]
[DesignerCategory("code")]
internal class Class103 : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class103()
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
		dataTableMapping.DataSetTable = "fn_P_GetChildObjCharList";
		dataTableMapping.ColumnMappings.Add("ParentId", "ParentId");
		dataTableMapping.ColumnMappings.Add("ParentName", "ParentName");
		dataTableMapping.ColumnMappings.Add("Id", "Id");
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		dataTableMapping.ColumnMappings.Add("TabIndex", "TabIndex");
		dataTableMapping.ColumnMappings.Add("Level", "Level");
		this.sqlDataAdapter_0.TableMappings.Add(dataTableMapping);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void method_9()
	{
		this.sqlConnection_0 = new SqlConnection();
		this.sqlConnection_0.ConnectionString = Settings.Default.GESConnectionString3;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void method_10()
	{
		this.sqlCommand_0 = new SqlCommand[1];
		this.sqlCommand_0[0] = new SqlCommand();
		this.sqlCommand_0[0].Connection = this.method_1();
		this.sqlCommand_0[0].CommandText = "SELECT ParentId, ParentName, Id, Name, TabIndex, [Level] FROM dbo.fn_P_GetChildObjCharList(@ParentId)";
		this.sqlCommand_0[0].CommandType = CommandType.Text;
		this.sqlCommand_0[0].Parameters.Add(new SqlParameter("@ParentId", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, false, null, "", "", ""));
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int vmethod_0(dsPassport.fn_P_GetChildObjCharListDataTable fn_P_GetChildObjCharListDataTable_0, int int_0)
	{
		this.method_0().SelectCommand = this.method_5()[0];
		this.method_0().SelectCommand.Parameters[0].Value = int_0;
		if (this.method_6())
		{
			fn_P_GetChildObjCharListDataTable_0.Clear();
		}
		return this.method_0().Fill(fn_P_GetChildObjCharListDataTable_0);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[DebuggerNonUserCode]
	public virtual dsPassport.fn_P_GetChildObjCharListDataTable vmethod_1(int int_0)
	{
		this.method_0().SelectCommand = this.method_5()[0];
		this.method_0().SelectCommand.Parameters[0].Value = int_0;
		dsPassport.fn_P_GetChildObjCharListDataTable fn_P_GetChildObjCharListDataTable = new dsPassport.fn_P_GetChildObjCharListDataTable();
		this.method_0().Fill(fn_P_GetChildObjCharListDataTable);
		return fn_P_GetChildObjCharListDataTable;
	}

	private SqlDataAdapter sqlDataAdapter_0;

	private SqlConnection sqlConnection_0;

	private SqlTransaction sqlTransaction_0;

	private SqlCommand[] sqlCommand_0;

	private bool bool_0;
}
