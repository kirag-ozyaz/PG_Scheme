using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace OfficeLB.XMLSpreadsheet
{
	public class XmlSpreadsheet
	{
		public string SheetName { get; set; }

		public XmlSpreadsheet()
		{
			
			
			this.workbook_0 = new Workbook();
			this.workbook_0.DocumentProperties = this.method_7();
			this.workbook_0.ExcelWorkBook = this.method_8();
			this.workbook_0.Styles = this.method_9();
		}

		public XmlSpreadsheet(DocumentProperties documentProperties)
		{
			
			
			this.workbook_0 = new Workbook();
			if (documentProperties == null)
			{
				this.workbook_0.DocumentProperties = this.method_7();
			}
			this.workbook_0.DocumentProperties = documentProperties;
			this.workbook_0.ExcelWorkBook = this.method_8();
			this.workbook_0.Styles = this.method_9();
		}

		public Workbook GenerateWorkBook<T>(IList<T> values)
		{
			if (values == null || values.Count == 0)
			{
				throw new ArgumentException();
			}
			this.workbook_0.Worksheets = new Worksheet[1];
			this.workbook_0.Worksheets.SetValue(this.method_0<T>(values), 0);
			return this.workbook_0;
		}

		public Workbook GenerateWorkBook(object[] columnHeaders, object[,] values, int columnCount, int rowCount)
		{
			if (values == null || values.Length == 0)
			{
				throw new ArgumentException();
			}
			this.workbook_0.Worksheets = new Worksheet[1];
			this.workbook_0.Worksheets.SetValue(this.method_1(columnHeaders, values, columnCount, rowCount), 0);
			return this.workbook_0;
		}

		public string GenerateSpreadsheet<T>(IList<T> values)
		{
			if (values == null || values.Count == 0)
			{
				throw new ArgumentException();
			}
			this.workbook_0.Worksheets = new Worksheet[1];
			this.workbook_0.Worksheets.SetValue(this.method_0<T>(values), 0);
			return Serializer.SerializeObject(this.workbook_0, typeof(Workbook));
		}

		public string GenerateSpreadsheet(object[] columnHeaders, object[,] values, int columnCount, int rowCount)
		{
			if (values == null || values.Length == 0)
			{
				throw new ArgumentException();
			}
			this.workbook_0.Worksheets = new Worksheet[1];
			this.workbook_0.Worksheets.SetValue(this.method_1(columnHeaders, values, columnCount, rowCount), 0);
			return Serializer.SerializeObject(this.workbook_0, typeof(Workbook));
		}

		public string GenerateSpreadsheet(object[] columnHeaders, int[] columnWidth, object[,] values, int columnCount, int rowCount)
		{
			if (values == null || values.Length == 0)
			{
				throw new ArgumentException();
			}
			this.workbook_0.Worksheets = new Worksheet[1];
			this.workbook_0.Worksheets.SetValue(this.method_2(columnHeaders, columnWidth, values, columnCount, rowCount), 0);
			return Serializer.SerializeObject(this.workbook_0, typeof(Workbook));
		}

		private Worksheet method_0<c9coCg7AFSPRxaVRKd>(IList<c9coCg7AFSPRxaVRKd> ilist_0)
		{
			Row[] array = new Row[ilist_0.Count + 1];
			array.SetValue(this.method_3<c9coCg7AFSPRxaVRKd>(), 0);
			this.method_5<c9coCg7AFSPRxaVRKd>(ilist_0, 1, array);
			return new Worksheet
			{
				Name = this.SheetName,
				Table = this.method_12(array),
				WorksheetOptions = this.method_10()
			};
		}

		private Worksheet method_1(object[] object_0, object[,] object_1, int int_0, int int_1)
		{
			return this.method_2(object_0, null, object_1, int_0, int_1);
		}

		private Worksheet method_2(object[] object_0, int[] int_0, object[,] object_1, int int_1, int int_2)
		{
			int int_3 = 1;
			Row[] array = new Row[int_2 + 1];
			Column[] array2 = new Column[int_1];
			for (int i = 0; i < int_1; i++)
			{
				array2[i] = new Column();
				if (int_0 == null)
				{
					array2[i].AutoFitWidth = "1";
				}
				else
				{
					array2[i].Width = int_0[i].ToString();
				}
			}
			array.SetValue(this.method_4(object_0, int_1), 0);
			this.method_6(object_1, int_1, int_2, int_3, array);
			return new Worksheet
			{
				Name = this.SheetName,
				Table = this.method_11(array2, array),
				WorksheetOptions = this.method_10()
			};
		}

		private Row method_3<tBSRM7dK5JLKWQwpKa>()
		{
			PropertyInfo[] properties = typeof(tBSRM7dK5JLKWQwpKa).GetProperties();
			Cell[] array = new Cell[properties.Length];
			int num = 0;
			foreach (PropertyInfo propertyInfo in properties)
			{
				array.SetValue(this.method_14("s60", this.method_15("String", propertyInfo.Name)), num);
				num++;
			}
			return this.method_13(array);
		}

		private Row method_4(object[] object_0, int int_0)
		{
			Cell[] array = new Cell[int_0];
			for (int i = 0; i < int_0 - 1; i++)
			{
				array.SetValue(this.method_14("header", this.method_15("String", object_0[i].ToString())), i);
			}
			return this.method_13(array);
		}

		private void method_5<JjwPCaCWFwHKwZPdg3>(IList<JjwPCaCWFwHKwZPdg3> ilist_0, int int_0, Row[] row_0)
		{
			PropertyInfo[] properties = typeof(JjwPCaCWFwHKwZPdg3).GetProperties();
			Cell[] array = new Cell[properties.Length];
			foreach (JjwPCaCWFwHKwZPdg3 jjwPCaCWFwHKwZPdg in ilist_0)
			{
				int num = 0;
				foreach (PropertyInfo propertyInfo in properties)
				{
					string string_ = string.Empty;
					object value = propertyInfo.GetValue(jjwPCaCWFwHKwZPdg, null);
					if (value != null)
					{
						string_ = value.ToString();
					}
					array.SetValue(this.method_14(null, this.method_15("String", string_)), num);
					num++;
				}
				row_0.SetValue(this.method_13(array), int_0);
				int_0++;
			}
		}

		private void method_6(object[,] object_0, int int_0, int int_1, int int_2, Row[] row_0)
		{
			Cell[] array = new Cell[int_0];
			for (int i = 0; i < int_1; i++)
			{
				for (int j = 0; j < int_0 - 1; j++)
				{
					string string_ = string.Empty;
					if (object_0[i, j] != null)
					{
						string_ = object_0[i, j].ToString();
					}
					array.SetValue(this.method_14(null, this.method_15("String", string_)), j);
				}
				row_0.SetValue(this.method_13(array), int_2);
				int_2++;
			}
		}

		private DocumentProperties method_7()
		{
			return new DocumentProperties
			{
				Author = "System",
				LastAuthor = "System",
				Created = DateTime.Now.ToString(),
				Version = "11.8107"
			};
		}

		private ExcelWorkbook method_8()
		{
			return new ExcelWorkbook
			{
				WindowHeight = "900",
				WindowWidth = "900",
				WindowTopX = "300",
				WindowTopY = "100",
				ProtectStructure = "False",
				ProtectWindows = "False"
			};
		}

		private Styles method_9()
		{
			Aligment aligment = new Aligment();
			aligment.Horizontal = "Center";
			aligment.Vertical = "Center";
			Font font = new Font();
			font.FontName = "Arial";
			font.Size = "11";
			font.Bold = "0";
			Style style = new Style();
			style.ID = "Default";
			style.Name = "Normal";
			Style style2 = new Style();
			style2.ID = "header";
			style2.Aligment = aligment;
			style2.Font = font;
			Styles styles = new Styles();
			styles.Style = new Style[2];
			styles.Style.SetValue(style, 0);
			styles.Style.SetValue(style2, 1);
			return styles;
		}

		private WorksheetOptions method_10()
		{
			return new WorksheetOptions
			{
				ProtectObjects = "False",
				ProtectScenarios = "False"
			};
		}

		private Table method_11(Column[] column_0, Row[] row_0)
		{
			Table table = new Table();
			table.Columns = new Column[column_0.Length];
			for (int i = 0; i < column_0.Length; i++)
			{
				table.Columns.SetValue(column_0[i], i);
			}
			table.Rows = new Row[row_0.Length];
			for (int j = 0; j < row_0.Length; j++)
			{
				table.Rows.SetValue(row_0[j], j);
			}
			return table;
		}

		private Table method_12(Row[] row_0)
		{
			Table table = new Table();
			table.Rows = new Row[row_0.Length];
			for (int i = 0; i < row_0.Length; i++)
			{
				table.Rows.SetValue(row_0[i], i);
			}
			return table;
		}

		private Row method_13(Cell[] cell_0)
		{
			Row row = new Row();
			row.Cells = new Cell[cell_0.Length];
			for (int i = 0; i < cell_0.Length; i++)
			{
				row.Cells.SetValue(cell_0[i], i);
			}
			return row;
		}

		private Cell method_14(string string_1, Data data_0)
		{
			return new Cell
			{
				StyleID = string_1,
				Data = data_0
			};
		}

		private Data method_15(string string_1, string string_2)
		{
			return new Data
			{
				Type = string_1,
				Value = string_2
			};
		}

		private Workbook workbook_0;

		[CompilerGenerated]
		private string string_0;
	}
}
