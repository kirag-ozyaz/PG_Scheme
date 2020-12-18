using System;

namespace OfficeLB.Word
{
	public class ParagraphFormat : Base
	{
		public ParagraphFormat()
		{
			
			
		}

		public ParagraphFormat(object oParagraphFormat)
		{
			
			base.ctor(oParagraphFormat);
		}

		public WdParagraphAlignment Alignment
		{
			get
			{
				return (WdParagraphAlignment)this.GetProperty("Alignment", null);
			}
			set
			{
				this.SetProperty("Alignment", new object[]
				{
					value
				});
			}
		}

		public WdBaselineAlignment BaseLineAlignment
		{
			get
			{
				return (WdBaselineAlignment)this.GetProperty("BaseLineAlignment", null);
			}
			set
			{
				this.SetProperty("BaseLineAlignment", new object[]
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

		public bool DisableLineHeightGrid
		{
			get
			{
				return (bool)this.GetProperty("DisableLineHeightGrid", null);
			}
			set
			{
				this.SetProperty("DisableLineHeightGrid", new object[]
				{
					value
				});
			}
		}

		public int FirstLineIndent
		{
			get
			{
				return (int)this.GetProperty("FirstLineIndent", null);
			}
			set
			{
				this.SetProperty("FirstLineIndent", new object[]
				{
					value
				});
			}
		}

		public bool HangingPunctuation
		{
			get
			{
				return (bool)this.GetProperty("HangingPunctuation", null);
			}
			set
			{
				this.SetProperty("HangingPunctuation", new object[]
				{
					value
				});
			}
		}

		public bool Hyphenation
		{
			get
			{
				return (bool)this.GetProperty("Hyphenation", null);
			}
			set
			{
				this.SetProperty("Hyphenation", new object[]
				{
					value
				});
			}
		}

		public bool KeepTogether
		{
			get
			{
				return (bool)this.GetProperty("KeepTogether", null);
			}
			set
			{
				this.SetProperty("KeepTogether", new object[]
				{
					value
				});
			}
		}

		public bool KeepWithNext
		{
			get
			{
				return (bool)this.GetProperty("KeepWithNext", null);
			}
			set
			{
				this.SetProperty("KeepWithNext", new object[]
				{
					value
				});
			}
		}

		public int LeftIndent
		{
			get
			{
				return (int)this.GetProperty("LeftIndent", null);
			}
			set
			{
				this.SetProperty("LeftIndent", new object[]
				{
					value
				});
			}
		}

		public int LineSpacing
		{
			get
			{
				return (int)this.GetProperty("LineSpacing", null);
			}
			set
			{
				this.SetProperty("LineSpacing", new object[]
				{
					value
				});
			}
		}

		public WdLineSpacing LineSpacingRule
		{
			get
			{
				return (WdLineSpacing)this.GetProperty("LineSpacingRule", null);
			}
			set
			{
				this.SetProperty("LineSpacingRule", new object[]
				{
					value
				});
			}
		}

		public bool NoLineNumber
		{
			get
			{
				return (bool)this.GetProperty("NoLineNumber", null);
			}
			set
			{
				this.SetProperty("NoLineNumber", new object[]
				{
					value
				});
			}
		}

		public bool OnTopOfLine
		{
			get
			{
				return (bool)this.GetProperty("OnTopOfLine", null);
			}
			set
			{
				this.SetProperty("OnTopOfLine", new object[]
				{
					value
				});
			}
		}

		public WdOutlineLevel OutlineLevel
		{
			get
			{
				return (WdOutlineLevel)this.GetProperty("LineSpacingRule", null);
			}
			set
			{
				this.SetProperty("LineSpacingRule", new object[]
				{
					value
				});
			}
		}

		public bool PageBreakBefore
		{
			get
			{
				return (bool)this.GetProperty("PageBreakBefore", null);
			}
			set
			{
				this.SetProperty("PageBreakBefore", new object[]
				{
					value
				});
			}
		}

		public int RightIndent
		{
			get
			{
				return (int)this.GetProperty("RightIndent", null);
			}
			set
			{
				this.SetProperty("RightIndent", new object[]
				{
					value
				});
			}
		}

		public Shading Shading
		{
			get
			{
				return new Shading(this.GetProperty("Shading", null));
			}
		}

		public string Style
		{
			get
			{
				return this.GetProperty("Style", null).ToString();
			}
			set
			{
				this.SetProperty("Style", new object[]
				{
					value
				});
			}
		}

		public double SpaceAfter
		{
			get
			{
				return (double)this.GetProperty("SpaceAfter", null);
			}
			set
			{
				this.SetProperty("SpaceAfter", new object[]
				{
					value
				});
			}
		}

		public bool SpaceAfterAuto
		{
			get
			{
				return (bool)this.GetProperty("SpaceAfterAuto", null);
			}
			set
			{
				this.SetProperty("SpaceAfterAuto", new object[]
				{
					value
				});
			}
		}

		public double SpaceBefore
		{
			get
			{
				return (double)this.GetProperty("SpaceBefore", null);
			}
			set
			{
				this.SetProperty("SpaceBefore", new object[]
				{
					value
				});
			}
		}

		public bool SpaceBeforeAuto
		{
			get
			{
				return (bool)this.GetProperty("SpaceBeforeAuto", null);
			}
			set
			{
				this.SetProperty("SpaceBeforeAuto", new object[]
				{
					value
				});
			}
		}

		public bool WordWrap
		{
			get
			{
				return (bool)this.GetProperty("WordWrap", null);
			}
			set
			{
				this.SetProperty("WordWrap", new object[]
				{
					value
				});
			}
		}

		public void CloseUp()
		{
			this.InvokeMethod("CloseUp", null);
		}

		public void IndentCharWidth(int count)
		{
			this.InvokeMethod("CloseUp", new object[]
			{
				count
			});
		}

		public void IndentFirstLineCharWidth(int count)
		{
			this.InvokeMethod("IndentFirstLineCharWidth", new object[]
			{
				count
			});
		}

		public void OpenOrCloseUp()
		{
			this.InvokeMethod("OpenOrCloseUp", null);
		}

		public void OpenUp()
		{
			this.InvokeMethod("OpenUp", null);
		}

		public void Reset()
		{
			this.InvokeMethod("Reset", null);
		}

		public void Space1()
		{
			this.InvokeMethod("Space1", null);
		}

		public void Space15()
		{
			this.InvokeMethod("Space15", null);
		}

		public void Space2()
		{
			this.InvokeMethod("Space2", null);
		}

		public void TabHangingIndent(int count)
		{
			this.InvokeMethod("TabHangingIndent", new object[]
			{
				count
			});
		}

		public void TabIndent(int count)
		{
			this.InvokeMethod("TabIndent", new object[]
			{
				count
			});
		}
	}
}
