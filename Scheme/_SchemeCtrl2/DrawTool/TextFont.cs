using System;
using System.Drawing;

namespace SchemeCtrl2.DrawTool
{
	[Serializable]
	public class TextFont
	{
		public string FontName { get; set; }

		public float FontSize
		{
			get
			{
				return this.fontSize;
			}
			set
			{
				if (value > 0f)
				{
					this.fontSize = value;
				}
			}
		}

		public bool FontBold { get; set; }

		public bool FontItalic { get; set; }

		public bool FontUnderline { get; set; }

		public ePositionText Position { get; set; }

		public bool FontVirtical { get; set; }

		public bool Visible { get; set; }

		public Font Font
		{
			get
			{
				FontStyle fontStyle = FontStyle.Regular;
				if (this.FontBold)
				{
					fontStyle |= FontStyle.Bold;
				}
				if (this.FontItalic)
				{
					fontStyle |= FontStyle.Italic;
				}
				if (this.FontUnderline)
				{
					fontStyle |= FontStyle.Underline;
				}
				return new Font(this.FontName, this.FontSize, fontStyle);
			}
			set
			{
				this.FontName = value.Name;
				this.FontSize = value.Size;
				this.FontBold = value.Bold;
				this.FontItalic = value.Italic;
				this.FontUnderline = value.Underline;
			}
		}

		public Color Color { get; set; }

		public TextFont()
		{
		}

		public TextFont(string fontName, float fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, ePositionText positionTExt, bool fontVertical, bool visible, Color color)
		{
			this.FontName = fontName;
			this.FontSize = fontSize;
			this.FontBold = fontBold;
			this.FontItalic = fontItalic;
			this.FontUnderline = fontUnderLine;
			this.Position = positionTExt;
			this.FontVirtical = fontVertical;
			this.Visible = visible;
			this.Color = color;
		}

		private float fontSize = 1f;
	}
}
