using System;
using System.Drawing;
using System.Runtime.CompilerServices;

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
				return this.float_0;
			}
			set
			{
				if (value > 0f)
				{
					this.float_0 = value;
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
			Class90.TDroV38zslI2T();
			this.float_0 = 1f;
			base..ctor();
		}

		public TextFont(string fontName, float fontSize, bool fontBold, bool fontItalic, bool fontUnderLine, ePositionText positionTExt, bool fontVertical, bool visible, Color color)
		{
			Class90.TDroV38zslI2T();
			this.float_0 = 1f;
			base..ctor();
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

		private float float_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private bool bool_1;

		[CompilerGenerated]
		private bool bool_2;

		[CompilerGenerated]
		private ePositionText ePositionText_0;

		[CompilerGenerated]
		private bool bool_3;

		[CompilerGenerated]
		private bool bool_4;

		[CompilerGenerated]
		private Color EpVqbrhoqp;
	}
}
