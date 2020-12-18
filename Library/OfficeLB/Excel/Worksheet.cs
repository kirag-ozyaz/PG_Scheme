using System;
using System.ComponentModel;
using System.Text;

namespace OfficeLB.Excel
{
	public class Worksheet : Base
	{
		public string Name
		{
			get
			{
				return this.GetProperty("Name", null).ToString();
			}
			set
			{
				this.SetProperty("Name", new object[]
				{
					value
				});
			}
		}

		public Worksheet()
		{
			
			
		}

		public Worksheet(object oWorksheet)
		{
			
			base.ctor(oWorksheet);
		}

		public static string ParseColNum(int ColNum)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (ColNum <= 0)
			{
				return "A";
			}
			char value = (char)(65 + ColNum % 26);
			while (ColNum / 26 != 0)
			{
				ColNum /= 26;
				stringBuilder.Append((char)(65 + ColNum - 1));
			}
			stringBuilder.Append(value);
			return stringBuilder.ToString();
		}

		[Description("Returns a Range object that represents the used range on the specified worksheet. Read-only.")]
		public Range UsedRange
		{
			get
			{
				return new Range(this.GetProperty("UsedRange", null));
			}
		}

		public void Activate()
		{
			this.InvokeMethod("Activate", null);
		}

		public void Paste()
		{
			this.InvokeMethod("Paste", null);
		}

		public void Paste(int value)
		{
			this.InvokeMethod("Paste", new object[]
			{
				value
			});
		}

		public void Select()
		{
			this.InvokeMethod("Select", null);
		}

		public Range Range(string cell)
		{
			return new Range(this.GetProperty("Range", new object[]
			{
				cell
			}));
		}

		public Range Range(string cell1, string cell2)
		{
			return new Range(this.GetProperty("Range", new object[]
			{
				cell1,
				cell2
			}));
		}

		public Range Range(int column, int row)
		{
			return new Range(this.GetProperty("Range", new object[]
			{
				Worksheet.ParseColNum(column - 1) + row.ToString()
			}));
		}

		public Range Range(int column1, int row1, int column2, int row2)
		{
			return new Range(this.GetProperty("Range", new object[]
			{
				Worksheet.ParseColNum(column1 - 1) + row1.ToString(),
				Worksheet.ParseColNum(column2 - 1) + row2.ToString()
			}));
		}

		public Cell Cell(string cell)
		{
			return new Cell(this.GetProperty("Cell", new object[]
			{
				cell
			}));
		}

		public Cell Cell(int column, int row)
		{
			return new Cell(this.GetProperty("Cell", new object[]
			{
				Worksheet.ParseColNum(column - 1) + row.ToString()
			}));
		}

		public Columns Columns(string columns)
		{
			return new Columns(this.GetProperty("Columns", new object[]
			{
				columns
			}));
		}

		public Columns Columns(int column1, int column2)
		{
			return new Columns(this.GetProperty("Columns", new object[]
			{
				Worksheet.ParseColNum(column1 - 1) + ":" + Worksheet.ParseColNum(column2 - 1)
			}));
		}

		public Rows Rows(string rows)
		{
			return new Rows(this.GetProperty("Rows", new object[]
			{
				rows
			}));
		}

		public Rows Rows(int row1, int row2)
		{
			return new Rows(this.GetProperty("Rows", new object[]
			{
				row1.ToString() + ":" + row2.ToString()
			}));
		}
	}
}
