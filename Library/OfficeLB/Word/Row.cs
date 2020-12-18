using System;

namespace OfficeLB.Word
{
	public class Row : Base
	{
		public Row()
		{
			
			
		}

		public Row(object oRow)
		{
			
			base.ctor(oRow);
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

		public Cells Cells
		{
			get
			{
				return new Cells(this.GetProperty("Cells", null));
			}
		}

		public Row Next
		{
			get
			{
				return new Row(this.GetProperty("Next", null));
			}
		}

		public Row Previous
		{
			get
			{
				return new Row(this.GetProperty("Previous", null));
			}
		}

		public Range Range
		{
			get
			{
				return new Range(this.GetProperty("Range", null));
			}
		}

		public Shading Shading
		{
			get
			{
				return new Shading(this.GetProperty("Shading", null));
			}
		}

		public WdRowAlignment Alignment
		{
			get
			{
				return (WdRowAlignment)this.GetProperty("Alignment", null);
			}
			set
			{
				this.SetProperty("Alignment", new object[]
				{
					value
				});
			}
		}

		public bool AllowBreakAcrossPages
		{
			get
			{
				return (bool)this.GetProperty("AllowBreakAcrossPages", null);
			}
			set
			{
				this.SetProperty("AllowBreakAcrossPages", new object[]
				{
					value
				});
			}
		}

		public int Creator
		{
			get
			{
				return (int)this.GetProperty("Creator", null);
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

		public int HeadingFormat
		{
			get
			{
				return (int)this.GetProperty("HeadingFormat", null);
			}
			set
			{
				this.SetProperty("HeadingFormat", new object[]
				{
					value
				});
			}
		}

		public int Index
		{
			get
			{
				return (int)this.GetProperty("Index", null);
			}
		}

		public bool IsFirst
		{
			get
			{
				return (bool)this.GetProperty("IsFirst", null);
			}
		}

		public bool IsLast
		{
			get
			{
				return (bool)this.GetProperty("IsLast", null);
			}
		}

		public int NestingLevel
		{
			get
			{
				return (int)this.GetProperty("NestingLevel", null);
			}
		}

		public double SpaceBetweenColumns
		{
			get
			{
				return (double)this.GetProperty("SpaceBetweenColumns", null);
			}
			set
			{
				this.SetProperty("SpaceBetweenColumns", new object[]
				{
					value
				});
			}
		}

		public Range ConvertToText(WdTableFieldSeparator Separator, bool NestedTables)
		{
			return new Range(this.InvokeReturn("ConvertToText", new object[]
			{
				Separator,
				NestedTables
			}));
		}

		public Range ConvertToTextOld(WdTableFieldSeparator Separator)
		{
			return new Range(this.InvokeReturn("ConvertToTextOld", new object[]
			{
				Separator
			}));
		}

		public void Delete()
		{
			this.InvokeMethod("Delete", null);
		}

		public void SetHeight(float RowHeight, WdRowHeightRule HeighRule)
		{
			this.InvokeMethod("SetHeight", new object[]
			{
				RowHeight,
				HeighRule
			});
		}

		public void Select()
		{
			this.InvokeMethod("Select", null);
		}

		public void SetLeftIndent(float LeftIndent, WdRulerStyle RulerStyle)
		{
			this.InvokeMethod("SetLeftIndent", new object[]
			{
				LeftIndent,
				RulerStyle
			});
		}
	}
}
