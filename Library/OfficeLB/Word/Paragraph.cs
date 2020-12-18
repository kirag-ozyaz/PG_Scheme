using System;

namespace OfficeLB.Word
{
	public class Paragraph : Base
	{
		public Paragraph()
		{
			
			
		}

		public Paragraph(object oParagraph)
		{
			
			base.ctor(oParagraph);
		}

		public Application Application
		{
			get
			{
				return (Application)this.GetProperty("Application", null);
			}
		}

		public DropCap DropCap
		{
			get
			{
				return new DropCap(this.GetProperty("DropCap", null));
			}
		}

		public ParagraphFormat Format
		{
			get
			{
				return new ParagraphFormat(this.GetProperty("ParagraphFormat", null));
			}
			set
			{
				this.SetProperty("ParagraphFormat", new object[]
				{
					value
				});
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

		public bool AddSpaceBetweenFarEastAndAlpha
		{
			get
			{
				return (bool)this.GetProperty("AddSpaceBetweenFarEastAndAlpha", null);
			}
			set
			{
				this.SetProperty("AddSpaceBetweenFarEastAndAlpha", new object[]
				{
					value
				});
			}
		}

		public bool AddSpaceBetweenFarEastAndDigit
		{
			get
			{
				return (bool)this.GetProperty("AddSpaceBetweenFarEastAndDigit", null);
			}
			set
			{
				this.SetProperty("AddSpaceBetweenFarEastAndDigit", new object[]
				{
					value
				});
			}
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

		public bool AutoAdjustRightIndent
		{
			get
			{
				return (bool)this.GetProperty("AutoAdjustRightIndent", null);
			}
			set
			{
				this.SetProperty("AutoAdjustRightIndent", new object[]
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
			set
			{
				this.SetProperty("Borders", new object[]
				{
					value
				});
			}
		}

		public double CharacterUnitFirstLineIndent
		{
			get
			{
				return (double)this.GetProperty("CharacterUnitFirstLineIndent", null);
			}
			set
			{
				this.SetProperty("CharacterUnitFirstLineIndent", new object[]
				{
					value
				});
			}
		}

		public double CharacterUnitLeftIndent
		{
			get
			{
				return (double)this.GetProperty("CharacterUnitLeftIndent", null);
			}
			set
			{
				this.SetProperty("CharacterUnitLeftIndent", new object[]
				{
					value
				});
			}
		}

		public double CharacterUnitRightIndent
		{
			get
			{
				return (double)this.GetProperty("CharacterUnitRightIndent", null);
			}
			set
			{
				this.SetProperty("CharacterUnitRightIndent", new object[]
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

		public bool FarEastLineBreakControl
		{
			get
			{
				return (bool)this.GetProperty("FarEastLineBreakControl", null);
			}
			set
			{
				this.SetProperty("FarEastLineBreakControl", new object[]
				{
					value
				});
			}
		}

		public double FirstLineIndent
		{
			get
			{
				return (double)this.GetProperty("FirstLineIndent", null);
			}
			set
			{
				this.SetProperty("FirstLineIndent", new object[]
				{
					value
				});
			}
		}

		public bool HalfWidthPunctuationOnTopOfLine
		{
			get
			{
				return (bool)this.GetProperty("HalfWidthPunctuationOnTopOfLine", null);
			}
			set
			{
				this.SetProperty("HalfWidthPunctuationOnTopOfLine", new object[]
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

		public string ID
		{
			get
			{
				return this.GetProperty("ID", null).ToString();
			}
			set
			{
				this.SetProperty("ID", new object[]
				{
					value
				});
			}
		}

		public bool IsStyleSeparator
		{
			get
			{
				return (bool)this.GetProperty("IsStyleSeparator", null);
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

		public double LeftIndent
		{
			get
			{
				return (double)this.GetProperty("LeftIndent", null);
			}
			set
			{
				this.SetProperty("LeftIndent", new object[]
				{
					value
				});
			}
		}

		public double LineSpacing
		{
			get
			{
				return (double)this.GetProperty("LineSpacing", null);
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

		public int LineUnitAfter
		{
			get
			{
				return (int)this.GetProperty("LineUnitAfter", null);
			}
			set
			{
				this.SetProperty("LineUnitAfter", new object[]
				{
					value
				});
			}
		}

		public int LineUnitBefore
		{
			get
			{
				return (int)this.GetProperty("LineUnitBefore", null);
			}
			set
			{
				this.SetProperty("LineUnitBefore", new object[]
				{
					value
				});
			}
		}

		public int ListNumberOriginal
		{
			get
			{
				return (int)this.GetProperty("ListNumberOriginal", null);
			}
		}

		public bool MirrorIndents
		{
			get
			{
				return (bool)this.GetProperty("MirrorIndents", null);
			}
			set
			{
				this.SetProperty("MirrorIndents", new object[]
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

		public WdOutlineLevel OutlineLevel
		{
			get
			{
				return (WdOutlineLevel)this.GetProperty("OutlineLevel", null);
			}
			set
			{
				this.SetProperty("OutlineLevel", new object[]
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

		public object Parent
		{
			get
			{
				return this.GetProperty("Parent", null);
			}
		}

		public WdReadingOrder ReadingOrder
		{
			get
			{
				return (WdReadingOrder)this.GetProperty("ReadingOrder", null);
			}
			set
			{
				this.SetProperty("ReadingOrder", new object[]
				{
					value
				});
			}
		}

		public double RightIndent
		{
			get
			{
				return (double)this.GetProperty("RightIndent", null);
			}
			set
			{
				this.SetProperty("RightIndent", new object[]
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

		public object Style
		{
			get
			{
				return this.GetProperty("Style", null);
			}
			set
			{
				this.SetProperty("Style", new object[]
				{
					value
				});
			}
		}

		public WdTextboxTightWrap TextboxTightWrap
		{
			get
			{
				return (WdTextboxTightWrap)this.GetProperty("TextboxTightWrap", null);
			}
			set
			{
				this.SetProperty("TextboxTightWrap", new object[]
				{
					value
				});
			}
		}

		public bool WidowControl
		{
			get
			{
				return (bool)this.GetProperty("WidowControl", null);
			}
			set
			{
				this.SetProperty("WidowControl", new object[]
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

		public Range Range
		{
			get
			{
				return new Range(this.GetProperty("Range", new object[]
				{
					startPos,
					endPos
				}));
			}
		}

		public Paragraph Next(int count)
		{
			return new Paragraph(this.InvokeReturn("Next", new object[]
			{
				count
			}));
		}

		public Paragraph Previous(int count)
		{
			return new Paragraph(this.InvokeReturn("Previous", new object[]
			{
				count
			}));
		}

		public void CloseUp()
		{
			this.InvokeMethod("CloseUp", null);
		}

		public void Indent()
		{
			this.InvokeMethod("Indent", null);
		}

		public void IndentCharWidth(int count)
		{
			this.InvokeMethod("IndentCharWidth", new object[]
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

		public void JoinList()
		{
			this.InvokeMethod("JoinList", null);
		}

		public void OpenOrCloseUp()
		{
			this.InvokeMethod("OpenOrCloseUp", null);
		}

		public void OpenUp()
		{
			this.InvokeMethod("OpenUp", null);
		}

		public void Outdent()
		{
			this.InvokeMethod("Outdent", null);
		}

		public void OutlineDemote()
		{
			this.InvokeMethod("OutlineDemote", null);
		}

		public void OutlineDemoteToBody()
		{
			this.InvokeMethod("OutlineDemoteToBody", null);
		}

		public void OutlinePromote()
		{
			this.InvokeMethod("OutlinePromote", null);
		}

		public void Reset()
		{
			this.InvokeMethod("Reset", null);
		}

		public void ResetAdvanceTo()
		{
			this.InvokeMethod("ResetAdvanceTo", null);
		}

		public void SelectNumber()
		{
			this.InvokeMethod("SelectNumber", null);
		}

		public void SeparateList()
		{
			this.InvokeMethod("SeparateList", null);
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
			this.InvokeMethod("Name", new object[]
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
