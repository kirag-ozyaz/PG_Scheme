using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Diagnostics;

[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapterManager")]
internal class Class297 : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class297.Enum7 Enum7_0
	{
		get
		{
			return this.enum7_0;
		}
		set
		{
			this.enum7_0 = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	[DebuggerNonUserCode]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public IDbConnection IDbConnection_0
	{
		get
		{
			if (this.idbConnection_0 != null)
			{
				return this.idbConnection_0;
			}
			return null;
		}
		set
		{
			this.idbConnection_0 = value;
		}
	}

	[DebuggerNonUserCode]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public int Int32_0
	{
		get
		{
			return 0;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private int method_0(Class107 class107_0, List<DataRow> list_0, List<DataRow> list_1)
	{
		return 0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private int method_1(Class107 class107_0, List<DataRow> list_0)
	{
		return 0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int method_2(Class107 class107_0, List<DataRow> list_0)
	{
		return 0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private DataRow[] method_3(DataRow[] dataRow_0, List<DataRow> list_0)
	{
		if (dataRow_0 == null || dataRow_0.Length < 1)
		{
			return dataRow_0;
		}
		if (list_0 != null && list_0.Count >= 1)
		{
			List<DataRow> list = new List<DataRow>();
			foreach (DataRow item in dataRow_0)
			{
				if (!list_0.Contains(item))
				{
					list.Add(item);
				}
			}
			return list.ToArray();
		}
		return dataRow_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int vmethod_0(Class107 class107_0)
	{
		if (class107_0 == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!class107_0.HasChanges())
		{
			return 0;
		}
		IDbConnection dbConnection = this.IDbConnection_0;
		if (dbConnection == null)
		{
			throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
		}
		bool flag = false;
		if ((dbConnection.State & ConnectionState.Broken) == ConnectionState.Broken)
		{
			dbConnection.Close();
		}
		if (dbConnection.State == ConnectionState.Closed)
		{
			dbConnection.Open();
			flag = true;
		}
		IDbTransaction dbTransaction = dbConnection.BeginTransaction();
		if (dbTransaction == null)
		{
			throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
		}
		List<DataRow> list = new List<DataRow>();
		List<DataRow> list2 = new List<DataRow>();
		List<DataAdapter> list3 = new List<DataAdapter>();
		new Dictionary<object, IDbConnection>();
		int num = 0;
		DataSet dataSet = null;
		if (this.Boolean_0)
		{
			dataSet = new DataSet();
			dataSet.Merge(class107_0);
		}
		try
		{
			if (this.Enum7_0 == (Class297.Enum7)1)
			{
				num += this.method_0(class107_0, list, list2);
				num += this.method_1(class107_0, list2);
			}
			else
			{
				num += this.method_1(class107_0, list2);
				num += this.method_0(class107_0, list, list2);
			}
			num += this.method_2(class107_0, list);
			dbTransaction.Commit();
			if (0 < list2.Count)
			{
				DataRow[] array = new DataRow[list2.Count];
				list2.CopyTo(array);
				for (int i = 0; i < array.Length; i++)
				{
					array[i].AcceptChanges();
				}
			}
			if (0 < list.Count)
			{
				DataRow[] array2 = new DataRow[list.Count];
				list.CopyTo(array2);
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].AcceptChanges();
				}
			}
		}
		catch (Exception ex)
		{
			dbTransaction.Rollback();
			if (this.Boolean_0)
			{
				class107_0.Clear();
				class107_0.Merge(dataSet);
			}
			else if (0 < list2.Count)
			{
				DataRow[] array3 = new DataRow[list2.Count];
				list2.CopyTo(array3);
				foreach (DataRow dataRow in array3)
				{
					dataRow.AcceptChanges();
					dataRow.SetAdded();
				}
			}
			throw ex;
		}
		finally
		{
			if (flag)
			{
				dbConnection.Close();
			}
			if (0 < list3.Count)
			{
				DataAdapter[] array4 = new DataAdapter[list3.Count];
				list3.CopyTo(array4);
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l].AcceptChangesDuringUpdate = true;
				}
			}
		}
		return num;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected virtual void vmethod_1(DataRow[] dataRow_0, DataRelation dataRelation_0, bool bool_1)
	{
		Array.Sort<DataRow>(dataRow_0, new Class297.Class298(dataRelation_0, bool_1));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected virtual bool vmethod_2(IDbConnection idbConnection_1)
	{
		return this.idbConnection_0 != null || this.IDbConnection_0 == null || idbConnection_1 == null || string.Equals(this.IDbConnection_0.ConnectionString, idbConnection_1.ConnectionString, StringComparison.Ordinal);
	}

	public Class297()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
	}

	private Class297.Enum7 enum7_0;

	private bool bool_0;

	private IDbConnection idbConnection_0;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public enum Enum7
	{

	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private class Class298 : IComparer<DataRow>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class298(DataRelation dataRelation_1, bool bool_0)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.dataRelation_0 = dataRelation_1;
			if (bool_0)
			{
				this.int_0 = -1;
				return;
			}
			this.int_0 = 1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private DataRow method_0(DataRow dataRow_0, out int int_1)
		{
			DataRow result = dataRow_0;
			int_1 = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[dataRow_0] = dataRow_0;
			DataRow parentRow = dataRow_0.GetParentRow(this.dataRelation_0, DataRowVersion.Default);
			while (parentRow != null && !dictionary.ContainsKey(parentRow))
			{
				int_1++;
				result = parentRow;
				dictionary[parentRow] = parentRow;
				parentRow = parentRow.GetParentRow(this.dataRelation_0, DataRowVersion.Default);
			}
			if (int_1 == 0)
			{
				dictionary.Clear();
				dictionary[dataRow_0] = dataRow_0;
				parentRow = dataRow_0.GetParentRow(this.dataRelation_0, DataRowVersion.Original);
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					int_1++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(this.dataRelation_0, DataRowVersion.Original);
				}
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Compare(DataRow x, DataRow y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			int num = 0;
			DataRow dataRow = this.method_0(x, out num);
			int value = 0;
			DataRow dataRow2 = this.method_0(y, out value);
			if (dataRow == dataRow2)
			{
				return this.int_0 * num.CompareTo(value);
			}
			if (dataRow.Table.Rows.IndexOf(dataRow) < dataRow2.Table.Rows.IndexOf(dataRow2))
			{
				return -1;
			}
			return 1;
		}

		private DataRelation dataRelation_0;

		private int int_0;
	}
}
