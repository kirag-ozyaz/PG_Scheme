using System;

namespace OfficeLB.Word
{
	public class Rows : Base
	{
		public Rows()
		{
			
			
		}

		public Rows(object oRows)
		{
			
			base.ctor(oRows);
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

		public Row this[int item]
		{
			get
			{
				return new Row(this.InvokeReturn("Item", new object[]
				{
					item
				}));
			}
		}

		public Row First
		{
			get
			{
				return new Row(this.GetProperty("First", null));
			}
		}

		public Font Font
		{
			get
			{
				return new Font(this.GetProperty("Font", null));
			}
		}

		public Row Last
		{
			get
			{
				return new Row(this.GetProperty("Last", null));
			}
		}

		public Range Range
		{
			get
			{
				return new Range(this.InvokeReturn("Range", null));
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

		public bool AllowOverlap
		{
			get
			{
				return (bool)this.GetProperty("AllowOverlap", null);
			}
			set
			{
				this.SetProperty("AllowOverlap", new object[]
				{
					value
				});
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

		public double DistanceBottom
		{
			get
			{
				return (double)this.GetProperty("DistanceBottom", null);
			}
			set
			{
				this.SetProperty("DistanceBottom", new object[]
				{
					value
				});
			}
		}

		public double DistanceLeft
		{
			get
			{
				return (double)this.GetProperty("DistanceLeft", null);
			}
			set
			{
				this.SetProperty("DistanceLeft", new object[]
				{
					value
				});
			}
		}

		public double DistanceRight
		{
			get
			{
				return (double)this.GetProperty("DistanceRight", null);
			}
			set
			{
				this.SetProperty("DistanceRight", new object[]
				{
					value
				});
			}
		}

		public double DistanceTop
		{
			get
			{
				return (double)this.GetProperty("DistanceTop", null);
			}
			set
			{
				this.SetProperty("DistanceTop", new object[]
				{
					value
				});
			}
		}

		public int WrapAroundText
		{
			get
			{
				return (int)this.GetProperty("WrapAroundText", null);
			}
			set
			{
				this.SetProperty("WrapAroundText", new object[]
				{
					value
				});
			}
		}

		public Row Add()
		{
			return new Row(this.InvokeReturn("Add", null));
		}

		public Range ConvertToText()
		{
			return new Range(this.InvokeReturn("ConvertToText", null));
		}

		public void Delete()
		{
			this.InvokeMethod("Delete", null);
		}

		public void DistributeHeight()
		{
			this.InvokeMethod("DistributeHeight", null);
		}

		public void Select()
		{
			this.InvokeMethod("Select", null);
		}
	}
}
