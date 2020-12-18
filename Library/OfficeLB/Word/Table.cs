using System;

namespace OfficeLB.Word
{
	public class Table : Base
	{
		public Table()
		{
			
			
		}

		public Table(object oTable)
		{
			
			base.ctor(oTable);
		}

		public Application Application
		{
			get
			{
				return (Application)this.GetProperty("Application", null);
			}
		}

		public Borders Borders
		{
			get
			{
				return new Borders(this.GetProperty("Borders", null));
			}
		}

		public Columns Columns
		{
			get
			{
				return new Columns(this.GetProperty("Columns", null));
			}
		}

		public object Parent
		{
			get
			{
				return this.GetProperty("Parent", null);
			}
		}

		public Range Range
		{
			get
			{
				return new Range(this.GetProperty("Range", null));
			}
		}

		public Rows Rows
		{
			get
			{
				return new Rows(this.GetProperty("Rows", null));
			}
		}

		public Shading Shading
		{
			get
			{
				return new Shading(this.GetProperty("Shading", null));
			}
		}

		public Tables Tables
		{
			get
			{
				return new Tables(this.GetProperty("Tables", null));
			}
		}

		public bool AllowAutoFit
		{
			get
			{
				return (bool)this.GetProperty("AllowAutoFit", null);
			}
			set
			{
				this.SetProperty("AllowAutoFit", new object[]
				{
					value
				});
			}
		}

		public bool AllowPageBreaks
		{
			get
			{
				return (bool)this.GetProperty("AllowPageBreaks", null);
			}
			set
			{
				this.SetProperty("AllowPageBreaks", new object[]
				{
					value
				});
			}
		}

		public bool ApplyStyleColumnBands
		{
			get
			{
				return (bool)this.GetProperty("ApplyStyleColumnBands", null);
			}
			set
			{
				this.SetProperty("ApplyStyleColumnBands", new object[]
				{
					value
				});
			}
		}

		public bool ApplyStyleFirstColumn
		{
			get
			{
				return (bool)this.GetProperty("ApplyStyleFirstColumn", null);
			}
			set
			{
				this.SetProperty("ApplyStyleFirstColumn", new object[]
				{
					value
				});
			}
		}

		public bool ApplyStyleHeadingRows
		{
			get
			{
				return (bool)this.GetProperty("ApplyStyleHeadingRows", null);
			}
			set
			{
				this.SetProperty("ApplyStyleHeadingRows", new object[]
				{
					value
				});
			}
		}

		public bool ApplyStyleLastColumn
		{
			get
			{
				return (bool)this.GetProperty("ApplyStyleLastColumn", null);
			}
			set
			{
				this.SetProperty("ApplyStyleLastColumn", new object[]
				{
					value
				});
			}
		}

		public bool ApplyStyleLastRow
		{
			get
			{
				return (bool)this.GetProperty("ApplyStyleLastRow", null);
			}
			set
			{
				this.SetProperty("ApplyStyleLastRow", new object[]
				{
					value
				});
			}
		}

		public bool ApplyStyleRowBands
		{
			get
			{
				return (bool)this.GetProperty("ApplyStyleRowBands", null);
			}
			set
			{
				this.SetProperty("ApplyStyleRowBands", new object[]
				{
					value
				});
			}
		}

		public double BottomPadding
		{
			get
			{
				return (double)this.GetProperty("BottomPadding", null);
			}
			set
			{
				this.SetProperty("BottomPadding", new object[]
				{
					value
				});
			}
		}

		public string ID
		{
			get
			{
				return this.GetProperty("ID", null).ToString();
			}
			set
			{
				this.SetProperty("ID", new object[]
				{
					value
				});
			}
		}

		public double LeftPadding
		{
			get
			{
				return (double)this.GetProperty("LeftPadding", null);
			}
			set
			{
				this.SetProperty("LeftPadding", new object[]
				{
					value
				});
			}
		}

		public int NestingLevel
		{
			get
			{
				return (int)this.GetProperty("NestingLevel", null);
			}
		}

		public double PreferredWidth
		{
			get
			{
				return (double)this.GetProperty("PreferredWidth", null);
			}
			set
			{
				this.SetProperty("PreferredWidth", new object[]
				{
					value
				});
			}
		}

		public WdPreferredWidthType PreferredWidthType
		{
			get
			{
				return (WdPreferredWidthType)this.GetProperty("PreferredWidthType", null);
			}
			set
			{
				this.SetProperty("PreferredWidthType", new object[]
				{
					value
				});
			}
		}

		public double RightPadding
		{
			get
			{
				return (double)this.GetProperty("RightPadding", null);
			}
			set
			{
				this.SetProperty("RightPadding", new object[]
				{
					value
				});
			}
		}

		public int Spacing
		{
			get
			{
				return (int)this.GetProperty("Spacing", null);
			}
			set
			{
				this.SetProperty("Spacing", new object[]
				{
					value
				});
			}
		}

		public object Style
		{
			get
			{
				return this.GetProperty("Style", null);
			}
			set
			{
				this.SetProperty("Style", new object[]
				{
					value
				});
			}
		}

		public WdTableDirection TableDirection
		{
			get
			{
				return (WdTableDirection)this.GetProperty("TableDirection", null);
			}
			set
			{
				this.SetProperty("TableDirection", new object[]
				{
					value
				});
			}
		}

		public double TopPadding
		{
			get
			{
				return (double)this.GetProperty("TopPadding", null);
			}
			set
			{
				this.SetProperty("TopPadding", new object[]
				{
					value
				});
			}
		}

		public bool Uniform
		{
			get
			{
				return (bool)this.GetProperty("Uniform", null);
			}
			set
			{
				this.SetProperty("Uniform", new object[]
				{
					value
				});
			}
		}

		public Cells Cells(int row, int column)
		{
			return new Cells(this.GetProperty("Cells", new object[]
			{
				row,
				column
			}));
		}

		public Table Split(object row)
		{
			return new Table(this.InvokeReturn("Split", new object[]
			{
				row
			}));
		}

		public void AutoFitBehavior(WdAutoFitBehavior behavior)
		{
			this.InvokeMethod("AutoFitBehavior", new object[]
			{
				behavior
			});
		}

		public void ConvertToText(WdTableFieldSeparator separator, bool nestedTables)
		{
			this.InvokeMethod("ConvertToText", new object[]
			{
				separator,
				nestedTables
			});
		}

		public void Delete()
		{
			this.InvokeMethod("Delete", null);
		}

		public void Select()
		{
			this.InvokeMethod("Select", null);
		}

		public void SortAscending()
		{
			this.InvokeMethod("SortAscending", null);
		}

		public void SortDescending()
		{
			this.InvokeMethod("SortDescending", null);
		}

		public void UpdateAutoFormat()
		{
			this.InvokeMethod("UpdateAutoFormat", null);
		}
	}
}
