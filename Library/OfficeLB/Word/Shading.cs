using System;

namespace OfficeLB.Word
{
	public class Shading : Base
	{
		public Shading()
		{
			
			
		}

		public Shading(object oShadihg)
		{
			
			base.ctor(oShadihg);
		}

		public WdColor BackgroundPatternColor
		{
			get
			{
				return (WdColor)this.GetProperty("BackgroundPatternColor", null);
			}
			set
			{
				this.SetProperty("BackgroundPatternColor", new object[]
				{
					value
				});
			}
		}

		public WdColorIndex BackgroundPatternColorIndex
		{
			get
			{
				return (WdColorIndex)this.GetProperty("BackgroundPatternColor", null);
			}
			set
			{
				this.SetProperty("BackgroundPatternColor", new object[]
				{
					value
				});
			}
		}

		public WdColor ForegroundPatternColor
		{
			get
			{
				return (WdColor)this.GetProperty("ForegroundPatternColor", null);
			}
			set
			{
				this.SetProperty("ForegroundPatternColor", new object[]
				{
					value
				});
			}
		}

		public WdColorIndex ForegroundPatternColorIndex
		{
			get
			{
				return (WdColorIndex)this.GetProperty("ForegroundPatternColor", null);
			}
			set
			{
				this.SetProperty("ForegroundPatternColor", new object[]
				{
					value
				});
			}
		}

		public WdTextureIndex Texture
		{
			get
			{
				return (WdTextureIndex)this.GetProperty("Texture", null);
			}
			set
			{
				this.SetProperty("Texture", new object[]
				{
					value
				});
			}
		}
	}
}
