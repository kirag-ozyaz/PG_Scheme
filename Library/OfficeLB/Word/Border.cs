using System;

namespace OfficeLB.Word
{
	public class Border : Base
	{
		public Border()
		{
			
			
		}

		public Border(object oBorder)
		{
			
			base.ctor(oBorder);
		}

		public WdPageBorderArt ArtStyle
		{
			get
			{
				return (WdPageBorderArt)this.GetProperty("ArtStyle", null);
			}
			set
			{
				this.SetProperty("ArtStyle", new object[]
				{
					value
				});
			}
		}

		public double ArtWidth
		{
			get
			{
				return (double)this.GetProperty("ArtWidth", null);
			}
			set
			{
				this.SetProperty("ArtWidth", new object[]
				{
					value
				});
			}
		}

		public WdColor Color
		{
			get
			{
				return (WdColor)this.GetProperty("Color", null);
			}
			set
			{
				this.SetProperty("Color", new object[]
				{
					value
				});
			}
		}

		public WdColorIndex ColorIndex
		{
			get
			{
				return (WdColorIndex)this.GetProperty("ColorIndex", null);
			}
			set
			{
				this.SetProperty("ColorIndex", new object[]
				{
					value
				});
			}
		}

		public bool Inside
		{
			get
			{
				return (bool)this.GetProperty("Inside", null);
			}
		}

		public WdLineStyle LineStyle
		{
			get
			{
				return (WdLineStyle)this.GetProperty("LineStyle", null);
			}
			set
			{
				this.SetProperty("LineStyle", new object[]
				{
					value
				});
			}
		}

		public int LineWidth
		{
			get
			{
				return (int)this.GetProperty("LineWidth", null);
			}
			set
			{
				this.SetProperty("LineWidth", new object[]
				{
					value
				});
			}
		}

		public bool Visible
		{
			get
			{
				return (bool)this.GetProperty("Visible", null);
			}
			set
			{
				this.SetProperty("Visible", new object[]
				{
					value
				});
			}
		}
	}
}
