using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using Passport.DataSets;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapterManager")]
internal class Class104 : Component
{
	public Class104.Enum1 method_0()
	{
		return this.enum1_0;
	}

	public void method_1(Class104.Enum1 enum1_1)
	{
		this.enum1_0 = enum1_1;
	}

	public bool method_2()
	{
		return this.bool_0;
	}

	public void method_3(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	public IDbConnection method_4()
	{
		if (this.idbConnection_0 != null)
		{
			return this.idbConnection_0;
		}
		return null;
	}

	public void method_5(IDbConnection idbConnection_1)
	{
		this.idbConnection_0 = idbConnection_1;
	}

	public int method_6()
	{
		return 0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int method_7(dsPassport dsPassport_0, List<DataRow> list_0, List<DataRow> list_1)
	{
		return 0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int method_8(dsPassport dsPassport_0, List<DataRow> list_0)
	{
		return 0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int method_9(dsPassport dsPassport_0, List<DataRow> list_0)
	{
		return 0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private DataRow[] method_10(DataRow[] dataRow_0, List<DataRow> list_0)
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
	public virtual int vmethod_0(dsPassport dsPassport_0)
	{
		if (dsPassport_0 == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!dsPassport_0.HasChanges())
		{
			return 0;
		}
		IDbConnection dbConnection = this.method_4();
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
		if (this.method_2())
		{
			dataSet = new DataSet();
			dataSet.Merge(dsPassport_0);
		}
		try
		{
			if (this.method_0() == Class104.Enum1.const_1)
			{
				num += this.method_7(dsPassport_0, list, list2);
				num += this.method_8(dsPassport_0, list2);
			}
			else
			{
				num += this.method_8(dsPassport_0, list2);
				num += this.method_7(dsPassport_0, list, list2);
			}
			num += this.method_9(dsPassport_0, list);
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
			if (this.method_2())
			{
				dsPassport_0.Clear();
				dsPassport_0.Merge(dataSet);
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
		Array.Sort<DataRow>(dataRow_0, new Class104.Class105(dataRelation_0, bool_1));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected virtual bool vmethod_2(IDbConnection idbConnection_1)
	{
		return this.idbConnection_0 != null || this.method_4() == null || idbConnection_1 == null || string.Equals(this.method_4().ConnectionString, idbConnection_1.ConnectionString, StringComparison.Ordinal);
	}

	private Class104.Enum1 enum1_0;

	private bool bool_0;

	private IDbConnection idbConnection_0;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public enum Enum1
	{
		const_0,
		const_1
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private class Class105 : IComparer<DataRow>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class105(DataRelation dataRelation_1, bool bool_0)
		{
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
		public int Compare(DataRow row1, DataRow row2)
		{
			if (row1 == row2)
			{
				return 0;
			}
			if (row1 == null)
			{
				return -1;
			}
			if (row2 == null)
			{
				return 1;
			}
			int num = 0;
			DataRow dataRow = this.method_0(row1, out num);
			int value = 0;
			DataRow dataRow2 = this.method_0(row2, out value);
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
