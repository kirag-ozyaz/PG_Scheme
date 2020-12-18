using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Passport.Classes
{
	public static class PivotTable
	{
		public static DataTable GetInversedDataTable(DataTable table, string columnX, params string[] columnsToIgnore)
		{
			DataTable dataTable = new DataTable();
			if (columnX == "")
			{
				columnX = table.Columns[0].ColumnName;
			}
			dataTable.Columns.Add(columnX);
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			if (columnsToIgnore.Length != 0)
			{
				list2.AddRange(columnsToIgnore);
			}
			if (!list2.Contains(columnX))
			{
				list2.Add(columnX);
			}
			foreach (object obj in table.Rows)
			{
				string text = ((DataRow)obj)[columnX].ToString();
				if (list.Contains(text))
				{
					throw new Exception("The inversion used must have unique values for column " + columnX);
				}
				list.Add(text);
				dataTable.Columns.Add(text);
			}
			foreach (object obj2 in table.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj2;
				if (!list.Contains(dataColumn.ColumnName) && !list2.Contains(dataColumn.ColumnName))
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow[0] = dataColumn.ColumnName;
					dataTable.Rows.Add(dataRow);
				}
			}
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				for (int j = 1; j < dataTable.Columns.Count; j++)
				{
					dataTable.Rows[i][j] = table.Rows[j - 1][dataTable.Rows[i][0].ToString()].ToString();
				}
			}
			return dataTable;
		}

		public static DataTable GetInversedDataTable(DataTable table, string columnX, string columnY, string columnZ, string nullValue, bool sumValues)
		{
			DataTable dataTable = new DataTable();
			if (columnX == "")
			{
				columnX = table.Columns[0].ColumnName;
			}
			dataTable.Columns.Add(columnY);
			List<string> list = new List<string>();
			foreach (object obj in table.Rows)
			{
				string text = ((DataRow)obj)[columnX].ToString();
				if (!list.Contains(text))
				{
					list.Add(text);
					dataTable.Columns.Add(text);
				}
			}
			if (columnY != "" && columnZ != "")
			{
				List<string> list2 = new List<string>();
				foreach (object obj2 in table.Rows)
				{
					DataRow dataRow = (DataRow)obj2;
					if (!list2.Contains(dataRow[columnY].ToString()))
					{
						list2.Add(dataRow[columnY].ToString());
					}
				}
				foreach (string text2 in list2)
				{
					DataRow dataRow2 = dataTable.NewRow();
					dataRow2[0] = text2;
					foreach (DataRow dataRow3 in table.Select(columnY + "='" + text2 + "'"))
					{
						string text3 = dataRow3[columnX].ToString();
						using (IEnumerator enumerator = dataTable.Columns.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (((DataColumn)enumerator.Current).ColumnName == text3)
								{
									if (sumValues)
									{
										try
										{
											dataRow2[text3] = Convert.ToDecimal(dataRow2[text3]) + Convert.ToDecimal(dataRow3[columnZ]);
											continue;
										}
										catch
										{
											dataRow2[text3] = dataRow3[columnZ];
											continue;
										}
									}
									dataRow2[text3] = dataRow3[columnZ];
								}
							}
						}
					}
					dataTable.Rows.Add(dataRow2);
				}
				if (nullValue != "")
				{
					using (IEnumerator enumerator = dataTable.Rows.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj3 = enumerator.Current;
							DataRow dataRow4 = (DataRow)obj3;
							foreach (object obj4 in dataTable.Columns)
							{
								DataColumn dataColumn = (DataColumn)obj4;
								if (dataRow4[dataColumn.ColumnName].ToString() == "")
								{
									dataRow4[dataColumn.ColumnName] = nullValue;
								}
							}
						}
						return dataTable;
					}
					goto IL_31B;
				}
				return dataTable;
			}
			IL_31B:
			throw new Exception("The columns to perform inversion are not provided");
		}

		public static DataTable GetInversedDataTable(DataTable table, DataColumn columnX, DataColumn columnY, DataColumn columnY2, DataColumn columnY3, DataColumn columnZ, string nullValue, bool sumValues)
		{
			PivotTable.Class206 @class = new PivotTable.Class206();
			@class.dataColumn_0 = columnY;
			@class.dataColumn_1 = columnY2;
			@class.dataColumn_2 = columnY3;
			DataTable dataTable = new DataTable();
			if (columnX.ColumnName == "")
			{
				columnX.ColumnName = table.Columns[0].ColumnName;
			}
			dataTable.Columns.Add(@class.dataColumn_0.Caption);
			dataTable.Columns.Add(@class.dataColumn_1.Caption);
			dataTable.Columns.Add(@class.dataColumn_2.Caption);
			List<string> list = new List<string>();
			foreach (object obj in table.Rows)
			{
				string text = ((DataRow)obj)[columnX.ColumnName].ToString();
				if (!list.Contains(text) && text.Length != 0)
				{
					list.Add(text);
					dataTable.Columns.Add(text);
				}
			}
			if (@class.dataColumn_0.ColumnName != "" && columnZ.ColumnName != "")
			{
				List<Class111> list2 = new List<Class111>();
				using (IEnumerator enumerator = table.Rows.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						PivotTable.Class205 class2 = new PivotTable.Class205();
						class2.class206_0 = @class;
						class2.dataRow_0 = (DataRow)enumerator.Current;
						if (list2.Where(new Func<Class111, bool>(class2.method_0)).Count<Class111>() == 0)
						{
							list2.Add(new Class111(class2.dataRow_0[class2.class206_0.dataColumn_0.ColumnName].ToString(), class2.dataRow_0[class2.class206_0.dataColumn_1.ColumnName].ToString(), class2.dataRow_0[class2.class206_0.dataColumn_2.ColumnName].ToString()));
						}
					}
				}
				foreach (Class111 class3 in list2)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow[0] = class3.Col1;
					dataRow[1] = class3.Col2;
					dataRow[2] = class3.Col3;
					foreach (DataRow dataRow2 in table.Select(@class.dataColumn_0.ColumnName + "='" + class3.Col1 + "'"))
					{
						string text2 = dataRow2[columnX.ColumnName].ToString();
						using (IEnumerator enumerator = dataTable.Columns.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (((DataColumn)enumerator.Current).ColumnName == text2)
								{
									if (sumValues)
									{
										try
										{
											dataRow[text2] = Convert.ToDecimal(dataRow[text2]) + Convert.ToDecimal(dataRow2[columnZ]);
											continue;
										}
										catch
										{
											dataRow[text2] = dataRow2[columnZ.ColumnName];
											continue;
										}
									}
									dataRow[text2] = dataRow2[columnZ.ColumnName];
								}
							}
						}
					}
					dataTable.Rows.Add(dataRow);
				}
				if (nullValue != "")
				{
					using (IEnumerator enumerator = dataTable.Rows.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							DataRow dataRow3 = (DataRow)obj2;
							foreach (object obj3 in dataTable.Columns)
							{
								DataColumn dataColumn = (DataColumn)obj3;
								if (dataRow3[dataColumn.ColumnName].ToString() == "")
								{
									dataRow3[dataColumn.ColumnName] = nullValue;
								}
							}
						}
						return dataTable;
					}
					goto IL_45E;
				}
				return dataTable;
			}
			IL_45E:
			throw new Exception("The columns to perform inversion are not provided");
		}

		public static DataTable GetInversedDataTable(DataTable table, DataColumn columnX, DataColumn columnY, DataColumn columnY2, DataColumn columnZ, string nullValue, bool sumValues)
		{
			PivotTable.Class208 @class = new PivotTable.Class208();
			@class.dataColumn_0 = columnY;
			@class.dataColumn_1 = columnY2;
			DataTable dataTable = new DataTable();
			if (columnX.ColumnName == "")
			{
				columnX.ColumnName = table.Columns[0].ColumnName;
			}
			dataTable.Columns.Add(@class.dataColumn_0.Caption);
			dataTable.Columns.Add(@class.dataColumn_1.Caption);
			List<string> list = new List<string>();
			foreach (object obj in table.Rows)
			{
				string text = ((DataRow)obj)[columnX.ColumnName].ToString();
				if (!list.Contains(text) && text.Length != 0)
				{
					list.Add(text);
					dataTable.Columns.Add(text);
				}
			}
			if (@class.dataColumn_0.ColumnName != "" && columnZ.ColumnName != "")
			{
				List<Class111> list2 = new List<Class111>();
				using (IEnumerator enumerator = table.Rows.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						PivotTable.Class207 class2 = new PivotTable.Class207();
						class2.class208_0 = @class;
						class2.dataRow_0 = (DataRow)enumerator.Current;
						if (list2.Where(new Func<Class111, bool>(class2.method_0)).Count<Class111>() == 0)
						{
							list2.Add(new Class111(class2.dataRow_0[class2.class208_0.dataColumn_0.ColumnName].ToString(), class2.dataRow_0[class2.class208_0.dataColumn_1.ColumnName].ToString()));
						}
					}
				}
				foreach (Class111 class3 in list2)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow[0] = class3.Col1;
					dataRow[1] = class3.Col2;
					foreach (DataRow dataRow2 in table.Select(@class.dataColumn_0.ColumnName + "='" + class3.Col1 + "'"))
					{
						string text2 = dataRow2[columnX.ColumnName].ToString();
						using (IEnumerator enumerator = dataTable.Columns.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (((DataColumn)enumerator.Current).ColumnName == text2)
								{
									if (sumValues)
									{
										try
										{
											dataRow[text2] = Convert.ToDecimal(dataRow[text2]) + Convert.ToDecimal(dataRow2[columnZ]);
											continue;
										}
										catch
										{
											dataRow[text2] = dataRow2[columnZ.ColumnName];
											continue;
										}
									}
									dataRow[text2] = dataRow2[columnZ.ColumnName];
								}
							}
						}
					}
					dataTable.Rows.Add(dataRow);
				}
				if (nullValue != "")
				{
					using (IEnumerator enumerator = dataTable.Rows.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							DataRow dataRow3 = (DataRow)obj2;
							foreach (object obj3 in dataTable.Columns)
							{
								DataColumn dataColumn = (DataColumn)obj3;
								if (dataRow3[dataColumn.ColumnName].ToString() == "")
								{
									dataRow3[dataColumn.ColumnName] = nullValue;
								}
							}
						}
						return dataTable;
					}
					goto IL_40E;
				}
				return dataTable;
			}
			IL_40E:
			throw new Exception("The columns to perform inversion are not provided");
		}

		[CompilerGenerated]
		private sealed class Class205
		{
			internal bool method_0(Class111 class111_0)
			{
				return class111_0.Col1 == this.dataRow_0[this.class206_0.dataColumn_0.ColumnName].ToString() && class111_0.Col2 == this.dataRow_0[this.class206_0.dataColumn_1.ColumnName].ToString() && class111_0.Col3 == this.dataRow_0[this.class206_0.dataColumn_2.ColumnName].ToString();
			}

			public DataRow dataRow_0;

			public PivotTable.Class206 class206_0;
		}

		[CompilerGenerated]
		private sealed class Class206
		{
			public DataColumn dataColumn_0;

			public DataColumn dataColumn_1;

			public DataColumn dataColumn_2;
		}

		[CompilerGenerated]
		private sealed class Class207
		{
			internal bool method_0(Class111 class111_0)
			{
				return class111_0.Col1 == this.dataRow_0[this.class208_0.dataColumn_0.ColumnName].ToString() && class111_0.Col2 == this.dataRow_0[this.class208_0.dataColumn_1.ColumnName].ToString();
			}

			public DataRow dataRow_0;

			public PivotTable.Class208 class208_0;
		}

		[CompilerGenerated]
		private sealed class Class208
		{
			public DataColumn dataColumn_0;

			public DataColumn dataColumn_1;
		}
	}
}
