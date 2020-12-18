using System;

namespace OfficeLB.Word
{
	public class Cells : Base
	{
		public Cells()
		{
			
			
		}

		public Cells(object oCells)
		{
            
			base.ctor(oCells);
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

		public Cell this[int item]
		{
			get
			{
				return new Cell(this.InvokeReturn("Item", new object[]
				{
					item
				}));
			}
		}

		public double Height
		{
			get
			{
				return (double)this.GetProperty("Height", null);
			}
			set
			{
				this.SetProperty("Height", new object[]
				{
					value
				});
			}
		}

		public Columns Columns
		{
			get
			{
				return new Columns(this.GetProperty("Columns", null));
			}
		}

		public int Count
		{
			get
			{
				return (int)this.GetProperty("Count", null);
			}
			set
			{
				this.SetProperty("Count", new object[]
				{
					value
				});
			}
		}

		public WdRowHeightRule HeightRule
		{
			get
			{
				return (WdRowHeightRule)this.GetProperty("HeightRule", null);
			}
			set
			{
				this.SetProperty("HeightRule", new object[]
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

		public WdCellVerticalAlignment VerticalAlignment
		{
			get
			{
				return (WdCellVerticalAlignment)this.GetProperty("VerticalAlignment", null);
			}
			set
			{
				this.SetProperty("VerticalAlignment", new object[]
				{
					value
				});
			}
		}

		public double Width
		{
			get
			{
				return (double)this.GetProperty("Width", null);
			}
			set
			{
				this.SetProperty("Width", new object[]
				{
					value
				});
			}
		}

		public void Delete()
		{
			this.InvokeMethod("Delete", null);
		}

		public void DistributeHeight()
		{
			this.InvokeMethod("DistributeHeight ", null);
		}

		public void DistributeWidth()
		{
			this.InvokeMethod("DistributeWidth", null);
		}

		public void Merge()
		{
			this.InvokeMethod("Merge", null);
		}

		public void Split(int numRows, int numColumns, bool MergeBeforeSplit)
		{
			this.InvokeMethod("Split ", new object[]
			{
				numRows,
				numColumns,
				MergeBeforeSplit
			});
		}
	}
}
