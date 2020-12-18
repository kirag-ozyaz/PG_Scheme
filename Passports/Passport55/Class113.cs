using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;
using Passport.Classes;

internal class Class113 : IDisposable
{
	[CompilerGenerated]
	public void method_0(ChangeContractor changeContractor_1)
	{
		ChangeContractor changeContractor = this.changeContractor_0;
		ChangeContractor changeContractor2;
		do
		{
			changeContractor2 = changeContractor;
			ChangeContractor value = (ChangeContractor)Delegate.Combine(changeContractor2, changeContractor_1);
			changeContractor = Interlocked.CompareExchange<ChangeContractor>(ref this.changeContractor_0, value, changeContractor2);
		}
		while (changeContractor != changeContractor2);
	}

	[CompilerGenerated]
	public void method_1(ChangeContractor changeContractor_1)
	{
		ChangeContractor changeContractor = this.changeContractor_0;
		ChangeContractor changeContractor2;
		do
		{
			changeContractor2 = changeContractor;
			ChangeContractor value = (ChangeContractor)Delegate.Remove(changeContractor2, changeContractor_1);
			changeContractor = Interlocked.CompareExchange<ChangeContractor>(ref this.changeContractor_0, value, changeContractor2);
		}
		while (changeContractor != changeContractor2);
	}

	public void Dispose()
	{
		this.vmethod_0(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void vmethod_0(bool bool_1)
	{
		this.method_12();
		if (!this.bool_0)
		{
			if (bool_1)
			{
				this.sqlConnection_0 = null;
			}
			this.bool_0 = true;
		}
	}

	public Class113(string string_4, DataSet dataSet_0, DataTable dataTable_1)
	{
		this.dataTable_0 = dataSet_0.Tables[dataTable_1.TableName];
		this.string_3 = "";
		this.string_2 = string_4;
		SqlDependency.Stop(string_4);
		SqlDependency.Start(string_4);
		this.int_0 = 0;
		this.sqlConnection_0 = new SqlConnection(string_4);
	}

	public Class113(string string_4, DataSet dataSet_0, DataTable dataTable_1, string string_5)
	{
		this.dataTable_0 = dataTable_1;
		this.string_3 = string_5;
		this.string_2 = string_4;
		SqlDependency.Stop(string_4);
		SqlDependency.Start(string_4);
		this.int_0 = 0;
		this.sqlConnection_0 = new SqlConnection(string_4);
	}

	public Class113(string string_4, DataSet dataSet_0, DataTable dataTable_1, string string_5, string string_6, int int_2)
	{
		this.dataTable_0 = dataTable_1;
		this.string_3 = "";
		this.string_2 = string_4;
		this.string_0 = string_5;
		this.string_1 = string_6;
		this.int_1 = int_2;
		if (string_5 == "")
		{
			SqlDependency.Stop(string_4);
			SqlDependency.Start(string_4);
		}
		else
		{
			SqlDependency.Stop(string_4, string_5);
			SqlDependency.Start(string_4, string_5);
		}
		this.int_0 = 0;
		this.sqlConnection_0 = new SqlConnection(string_4);
	}

	public Class113(string string_4, ref DataTable dataTable_1, string string_5, string string_6, string string_7, int int_2)
	{
		this.dataTable_0 = dataTable_1;
		this.string_3 = string_5;
		this.string_2 = string_4;
		this.string_0 = string_6;
		this.string_1 = string_7;
		this.int_1 = int_2;
		if (string_6 == "")
		{
			SqlDependency.Stop(string_4);
			SqlDependency.Start(string_4);
		}
		else
		{
			SqlDependency.Stop(string_4, string_6);
			SqlDependency.Start(string_4, string_6);
		}
		this.int_0 = 0;
		this.sqlConnection_0 = new SqlConnection(string_4);
	}

	~Class113()
	{
		this.method_12();
		this.vmethod_0(false);
	}

	public bool method_2()
	{
		bool result;
		try
		{
			new SqlClientPermission(PermissionState.Unrestricted).Demand();
			result = true;
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public DataTable method_3()
	{
		return this.dataTable_0;
	}

	public void method_4(DataTable dataTable_1)
	{
		this.dataTable_0 = dataTable_1;
	}

	public string method_5()
	{
		return this.string_0;
	}

	public void method_6(string string_4)
	{
		this.string_0 = string_4;
	}

	public string method_7()
	{
		return this.string_1;
	}

	public void method_8(string string_4)
	{
		this.string_1 = string_4;
	}

	public int method_9()
	{
		return this.int_1;
	}

	public void method_10(int int_2)
	{
		this.int_1 = int_2;
	}

	public DataTable method_11(bool bool_1)
	{
		try
		{
			SqlConnection sqlConnection = new SqlConnection(this.string_2);
			SqlCommand sqlCommand = new SqlCommand(this.method_13(), sqlConnection);
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.Notification = null;
			((this.string_1 == "") ? new SqlDependency(sqlCommand) : new SqlDependency(sqlCommand, this.string_1, this.int_1)).OnChange += this.method_14;
			if (sqlConnection.State == ConnectionState.Closed)
			{
				sqlConnection.Open();
			}
			this.dataTable_0.Load(sqlCommand.ExecuteReader(CommandBehavior.CloseConnection));
		}
		catch (Exception ex)
		{
			throw ex;
		}
		return this.dataTable_0;
	}

	public void method_12()
	{
		if (this.string_0 == "")
		{
			SqlDependency.Stop(this.string_2);
			return;
		}
		SqlDependency.Stop(this.string_2, this.string_0);
	}

	private string method_13()
	{
		string text = "";
		if (this.dataTable_0.Columns.Count > 0)
		{
			string text2 = "dbo." + this.dataTable_0.TableName;
			text += "SELECT ";
			foreach (object obj in this.dataTable_0.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj;
				text = string.Concat(new string[]
				{
					text,
					text2,
					".",
					dataColumn.ColumnName,
					","
				});
			}
			text = text.Remove(text.LastIndexOf(','));
			text = string.Concat(new string[]
			{
				text,
				" FROM ",
				text2,
				" ",
				this.string_3
			});
		}
		return text;
	}

	private void method_14(object sender, SqlNotificationEventArgs e)
	{
		SqlDependency sqlDependency = sender as SqlDependency;
		this.int_0++;
		sqlDependency.OnChange -= this.method_14;
		if (this.changeContractor_0 != null)
		{
			this.changeContractor_0(this, new TableDataChangeEventArgs(e.Type, e.Info, e.Source, this.int_0, this.dataTable_0.TableName));
		}
	}

	private bool bool_0;

	private int int_0;

	private SqlConnection sqlConnection_0;

	[CompilerGenerated]
	private ChangeContractor changeContractor_0;

	private string string_0;

	private string string_1;

	private int int_1;

	private string string_2;

	private DataTable dataTable_0;

	private string string_3;
}
