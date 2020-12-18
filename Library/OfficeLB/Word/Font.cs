using System;

namespace OfficeLB.Word
{
	public class Font : Base
	{
		public Font()
		{
			
			
		}

		public Font(object oFont)
		{
			
			base.ctor(oFont);
		}

		public bool AllCaps
		{
			get
			{
				return (bool)this.GetProperty("AllCaps", null);
			}
			set
			{
				this.SetProperty("AllCaps", new object[]
				{
					value
				});
			}
		}

		public WdAnimation Animation
		{
			get
			{
				return (WdAnimation)this.GetProperty("Animation", null);
			}
			set
			{
				this.SetProperty("Animation", new object[]
				{
					value
				});
			}
		}

		public bool Bold
		{
			get
			{
				return (bool)this.GetProperty("Bold", null);
			}
			set
			{
				this.SetProperty("Bold", new object[]
				{
					value
				});
			}
		}

		public Borders Borders
		{
			get
			{
				return new Borders(this.GetProperty("Borders", null));
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

		public bool DisableCharacterSpaceGrid
		{
			get
			{
				return (bool)this.GetProperty("DisableCharacterSpaceGrid", null);
			}
			set
			{
				this.SetProperty("DisableCharacterSpaceGrid", new object[]
				{
					value
				});
			}
		}

		public bool DoubleStrikeThrough
		{
			get
			{
				return (bool)this.GetProperty("DoubleStrikeThrough", null);
			}
			set
			{
				this.SetProperty("DoubleStrikeThrough", new object[]
				{
					value
				});
			}
		}

		public bool Emboss
		{
			get
			{
				return (bool)this.GetProperty("Emboss", null);
			}
			set
			{
				this.SetProperty("Emboss", new object[]
				{
					value
				});
			}
		}

		public WdEmphasisMark EmphasisMark
		{
			get
			{
				return (WdEmphasisMark)this.GetProperty("EmphasisMark", null);
			}
			set
			{
				this.SetProperty("EmphasisMark", new object[]
				{
					value
				});
			}
		}

		public bool Engrave
		{
			get
			{
				return (bool)this.GetProperty("Engrave", null);
			}
			set
			{
				this.SetProperty("Engrave", new object[]
				{
					value
				});
			}
		}

		public bool Hidden
		{
			get
			{
				return (bool)this.GetProperty("Hidden", null);
			}
			set
			{
				this.SetProperty("Hidden", new object[]
				{
					value
				});
			}
		}

		public bool Italic
		{
			get
			{
				return (bool)this.GetProperty("Italic", null);
			}
			set
			{
				this.SetProperty("Italic", new object[]
				{
					value
				});
			}
		}

		public string Name
		{
			get
			{
				return (string)this.GetProperty("Name", null);
			}
			set
			{
				this.SetProperty("Name", new object[]
				{
					value
				});
			}
		}

		public string NameAscii
		{
			get
			{
				return (string)this.GetProperty("NameAscii", null);
			}
			set
			{
				this.SetProperty("NameAscii", new object[]
				{
					value
				});
			}
		}

		public bool Outline
		{
			get
			{
				return (bool)this.GetProperty("Outline", null);
			}
			set
			{
				this.SetProperty("Outline", new object[]
				{
					value
				});
			}
		}

		public int Position
		{
			get
			{
				return (int)this.GetProperty("Position", null);
			}
			set
			{
				this.SetProperty("Position", new object[]
				{
					value
				});
			}
		}

		public double Scaling
		{
			get
			{
				return (double)this.GetProperty("Scaling", null);
			}
			set
			{
				this.SetProperty("Scaling", new object[]
				{
					value
				});
			}
		}

		public Shading Shading
		{
			get
			{
				return (Shading)this.GetProperty("Shading", null);
			}
			set
			{
				this.SetProperty("Shading", new object[]
				{
					value
				});
			}
		}

		public bool Shadow
		{
			get
			{
				return (bool)this.GetProperty("Shadow", null);
			}
			set
			{
				this.SetProperty("Shadow", new object[]
				{
					value
				});
			}
		}

		public int Size
		{
			get
			{
				return (int)this.GetProperty("Size", null);
			}
			set
			{
				this.SetProperty("Size", new object[]
				{
					value
				});
			}
		}

		public bool SmallCaps
		{
			get
			{
				return (bool)this.GetProperty("SmallCaps", null);
			}
			set
			{
				this.SetProperty("SmallCaps", new object[]
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

		public bool Strikethrough
		{
			get
			{
				return (bool)this.GetProperty("Strikethrough", null);
			}
			set
			{
				this.SetProperty("Strikethrough", new object[]
				{
					value
				});
			}
		}

		public bool Subscript
		{
			get
			{
				return (bool)this.GetProperty("Subscript", null);
			}
			set
			{
				this.SetProperty("Subscript", new object[]
				{
					value
				});
			}
		}

		public bool Superscript
		{
			get
			{
				return (bool)this.GetProperty("Superscript", null);
			}
			set
			{
				this.SetProperty("Superscript", new object[]
				{
					value
				});
			}
		}

		public WdUnderline Underline
		{
			get
			{
				return (WdUnderline)this.GetProperty("Underline", null);
			}
			set
			{
				this.SetProperty("Underline", new object[]
				{
					value
				});
			}
		}

		public WdColor UnderlineColor
		{
			get
			{
				return (WdColor)this.GetProperty("UnderlineColor", null);
			}
			set
			{
				this.SetProperty("UnderlineColor", new object[]
				{
					value
				});
			}
		}

		public void Grow()
		{
			this.InvokeMethod("Grow", null);
		}

		public void Reset()
		{
			this.InvokeMethod("Reset", null);
		}

		public void SetAsTemplateDefault()
		{
			this.InvokeMethod("SetAsTemplateDefault", null);
		}

		public void Shrink()
		{
			this.InvokeMethod("Shrink", null);
		}
	}
}
