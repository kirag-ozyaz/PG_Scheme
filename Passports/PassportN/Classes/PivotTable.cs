using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
			DataTable dataTable = new DataTable();
			if (columnX.ColumnName == "")
			{
				columnX.ColumnName = table.Columns[0].ColumnName;
			}
			dataTable.Columns.Add(columnY.Caption);
			dataTable.Columns.Add(columnY2.Caption);
			dataTable.Columns.Add(columnY3.Caption);
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
			if (columnY.ColumnName != "" && columnZ.ColumnName != "")
			{
				List<Class319> list2 = new List<Class319>();
				using (IEnumerator enumerator = table.Rows.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DataRow dr = (DataRow)enumerator.Current;
						if ((from psp in list2
						where psp.method_0() == dr[columnY.ColumnName].ToString() && psp.method_2() == dr[columnY2.ColumnName].ToString() && psp.method_4() == dr[columnY3.ColumnName].ToString()
						select psp).Count<Class319>() == 0)
						{
							list2.Add(new Class319(dr[columnY.ColumnName].ToString(), dr[columnY2.ColumnName].ToString(), dr[columnY3.ColumnName].ToString()));
						}
					}
				}
				foreach (Class319 @class in list2)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow[0] = @class.method_0();
					dataRow[1] = @class.method_2();
					dataRow[2] = @class.method_4();
					foreach (DataRow dataRow2 in table.Select(columnY.ColumnName + "='" + @class.method_0() + "'"))
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
					goto IL_45C;
				}
				return dataTable;
			}
			IL_45C:
			throw new Exception("The columns to perform inversion are not provided");
		}

		public static DataTable GetInversedDataTable(DataTable table, DataColumn columnX, DataColumn columnY, DataColumn columnY2, DataColumn columnZ, string nullValue, bool sumValues)
		{
			DataTable dataTable = new DataTable();
			if (columnX.ColumnName == "")
			{
				columnX.ColumnName = table.Columns[0].ColumnName;
			}
			dataTable.Columns.Add(columnY.Caption);
			dataTable.Columns.Add(columnY2.Caption);
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
			if (columnY.ColumnName != "" && columnZ.ColumnName != "")
			{
				List<Class319> list2 = new List<Class319>();
				using (IEnumerator enumerator = table.Rows.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DataRow dr = (DataRow)enumerator.Current;
						if ((from psp in list2
						where psp.method_0() == dr[columnY.ColumnName].ToString() && psp.method_2() == dr[columnY2.ColumnName].ToString()
						select psp).Count<Class319>() == 0)
						{
							list2.Add(new Class319(dr[columnY.ColumnName].ToString(), dr[columnY2.ColumnName].ToString()));
						}
					}
				}
				foreach (Class319 @class in list2)
				{
					DataRow dataRow = dataTable.NewRow();
					dataRow[0] = @class.method_0();
					dataRow[1] = @class.method_2();
					foreach (DataRow dataRow2 in table.Select(columnY.ColumnName + "='" + @class.method_0() + "'"))
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
					goto IL_40C;
				}
				return dataTable;
			}
			IL_40C:
			throw new Exception("The columns to perform inversion are not provided");
		}
	}
}
