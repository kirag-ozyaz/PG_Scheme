using System;

namespace OfficeLB.Word
{
	public class Frame : Base
	{
		public Frame()
		{
			
			
		}

		public Frame(object oFrame)
		{
			
			base.ctor(oFrame);
		}

		public Borders Borders
		{
			get
			{
				return new Borders(this.GetProperty("Borders", null));
			}
		}

		public int Height
		{
			get
			{
				return (int)this.GetProperty("Height", null);
			}
			set
			{
				this.SetProperty("Height", new object[]
				{
					value
				});
			}
		}

		public WdFrameSizeRule HeightRule
		{
			get
			{
				return (WdFrameSizeRule)this.GetProperty("HeightRule", null);
			}
			set
			{
				this.SetProperty("HeightRule", new object[]
				{
					value
				});
			}
		}

		public int HorizontalDistance
		{
			get
			{
				return (int)this.GetProperty("HorizontalDistance", null);
			}
			set
			{
				this.SetProperty("HorizontalDistance", new object[]
				{
					value
				});
			}
		}

		public WdFramePosition HorizontalPosition
		{
			get
			{
				return (WdFramePosition)this.GetProperty("HorizontalPosition", null);
			}
			set
			{
				this.SetProperty("HorizontalPosition", new object[]
				{
					value
				});
			}
		}

		public bool LockAnchor
		{
			get
			{
				return (bool)this.GetProperty("LockAnchor", null);
			}
			set
			{
				this.SetProperty("LockAnchor", new object[]
				{
					value
				});
			}
		}

		public Range Range
		{
			get
			{
				return new Range(this.InvokeReturn("Range", null));
			}
		}

		public WdRelativeHorizontalPosition RelativeHorizontalPosition
		{
			get
			{
				return (WdRelativeHorizontalPosition)this.GetProperty("RelativeHorizontalPosition", null);
			}
			set
			{
				this.SetProperty("RelativeHorizontalPosition", new object[]
				{
					value
				});
			}
		}

		public WdRelativeVerticalPosition RelativeVerticalPosition
		{
			get
			{
				return (WdRelativeVerticalPosition)this.GetProperty("RelativeVerticalPosition", null);
			}
			set
			{
				this.SetProperty("RelativeVerticalPosition", new object[]
				{
					value
				});
			}
		}

		public Shading Shading
		{
			get
			{
				return new Shading(this.InvokeReturn("Shading", null));
			}
		}

		public bool TextWrap
		{
			get
			{
				return (bool)this.GetProperty("TextWrap", null);
			}
			set
			{
				this.SetProperty("TextWrap", new object[]
				{
					value
				});
			}
		}

		public int VerticalDistanceFromText
		{
			get
			{
				return (int)this.GetProperty("VerticalDistanceFromText", null);
			}
			set
			{
				this.SetProperty("VerticalDistanceFromText", new object[]
				{
					value
				});
			}
		}

		public WdFramePosition VerticalPosition
		{
			get
			{
				return (WdFramePosition)this.GetProperty("VerticalPosition", null);
			}
			set
			{
				this.SetProperty("VerticalPosition", new object[]
				{
					value
				});
			}
		}

		public int Width
		{
			get
			{
				return (int)this.GetProperty("Width", null);
			}
			set
			{
				this.SetProperty("Width", new object[]
				{
					value
				});
			}
		}

		public WdFrameSizeRule WidthRule
		{
			get
			{
				return (WdFrameSizeRule)this.GetProperty("WidthRule", null);
			}
			set
			{
				this.SetProperty("WidthRule", new object[]
				{
					value
				});
			}
		}
	}
}
