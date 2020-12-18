using System;

namespace OfficeLB.Word
{
	public class Selection : Base
	{
		public Selection()
		{
			
			
		}

		public Selection(object oSelection)
		{
			
			base.ctor(oSelection);
		}

		public bool Active
		{
			get
			{
				return (bool)this.GetProperty("Active", null);
			}
		}

		public Bookmarks Bookmarks
		{
			get
			{
				return new Bookmarks(this.GetProperty("Bookmarks", null));
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

		public Characters Characters
		{
			get
			{
				return new Characters(this.GetProperty("Characters", null));
			}
		}

		public Columns Columns
		{
			get
			{
				return new Columns(this.GetProperty("Columns", null));
			}
		}

		public bool ColumnSelectMode
		{
			get
			{
				return (bool)this.GetProperty("ColumnSelectMode", null);
			}
			set
			{
				this.SetProperty("ColumnSelectMode", new object[]
				{
					value
				});
			}
		}

		public Document Document
		{
			get
			{
				return new Document(this.GetProperty("Document", null));
			}
		}

		public int End
		{
			get
			{
				return (int)this.GetProperty("End", null);
			}
			set
			{
				this.SetProperty("End", new object[]
				{
					value
				});
			}
		}

		public bool ExtendMode
		{
			get
			{
				return (bool)this.GetProperty("ExtendMode", null);
			}
			set
			{
				this.SetProperty("ExtendMode", new object[]
				{
					value
				});
			}
		}

		public Find Find
		{
			get
			{
				return new Find(this.GetProperty("Find", null));
			}
		}

		public int FitTextWidth
		{
			get
			{
				return (int)this.GetProperty("FitTextWidth", null);
			}
			set
			{
				this.SetProperty("FitTextWidth", new object[]
				{
					value
				});
			}
		}

		public WdSelectionFlags Flags
		{
			get
			{
				return (WdSelectionFlags)this.GetProperty("Flags", null);
			}
			set
			{
				this.SetProperty("Flags", new object[]
				{
					value
				});
			}
		}

		public Font Font
		{
			get
			{
				return new Font(this.GetProperty("Font", null));
			}
		}

		public Range FormattedText
		{
			get
			{
				return new Range(this.InvokeReturn("FormattedText", null));
			}
		}

		public Frames Frames
		{
			get
			{
				return new Frames(this.GetProperty("Frames", null));
			}
		}

		public WdTextOrientation Orientation
		{
			get
			{
				return (WdTextOrientation)this.GetProperty("Orientation", null);
			}
			set
			{
				this.SetProperty("Orientation", new object[]
				{
					value
				});
			}
		}

		public PageSetup PageSetup
		{
			get
			{
				return new PageSetup(this.GetProperty("PageSetup", null));
			}
		}

		public ParagraphFormat ParagraphFormat
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

		public Paragraphs Paragraphs
		{
			get
			{
				return new Paragraphs(this.GetProperty("Paragraphs", null));
			}
		}

		public object Parent
		{
			get
			{
				return this.GetProperty("Parent", null);
			}
		}

		public Range Range
		{
			get
			{
				return new Range(this.GetProperty("Range", null));
			}
		}

		public Rows Rows
		{
			get
			{
				return new Rows(this.GetProperty("Rows", null));
			}
		}

		public Sections Sections
		{
			get
			{
				return new Sections(this.GetProperty("Sections", null));
			}
		}

		public Sentences Sentences
		{
			get
			{
				return new Sentences(this.GetProperty("Sentences", null));
			}
		}

		public Shading Shading
		{
			get
			{
				return new Shading(this.GetProperty("Shading", null));
			}
		}

		public int Start
		{
			get
			{
				return (int)this.GetProperty("Start", null);
			}
			set
			{
				this.SetProperty("Start", new object[]
				{
					value
				});
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

		public Tables Tables
		{
			get
			{
				return new Tables(this.GetProperty("Tables", null));
			}
		}

		public string Text
		{
			get
			{
				return this.GetProperty("Text", null).ToString();
			}
			set
			{
				this.SetProperty("Text", new object[]
				{
					value
				});
			}
		}

		public Tables TopLevelTables
		{
			get
			{
				return new Tables(this.GetProperty("TopLevelTables", null));
			}
		}

		public WdSelectionType Type
		{
			get
			{
				return (WdSelectionType)this.GetProperty("Type", null);
			}
		}

		public string TypeText
		{
			get
			{
				return this.InvokeReturn("TypeText", null).ToString();
			}
			set
			{
				this.InvokeMethod("TypeText", new object[]
				{
					value
				});
			}
		}

		public Words Words
		{
			get
			{
				return new Words(this.InvokeReturn(" Words", null));
			}
		}

		public void TypeParagraph()
		{
			this.InvokeMethod("TypeParagraph", null);
		}

		public void HomeKey(WdUnits unit, WdMovementType extend)
		{
			this.InvokeMethod("HomeKey", new object[]
			{
				unit,
				extend
			});
		}

		public void EndKey(WdUnits unit, WdMovementType extend)
		{
			this.InvokeMethod("EndKey", new object[]
			{
				unit,
				extend
			});
		}

		public bool FindAndReplace(string text, string replaceWith, bool ShortText)
		{
			this.HomeKey(WdUnits.wdUnitsStory, WdMovementType.wdMovementTypeMove);
			this.Find.ClearFormatting();
			this.Find.Replacement.ClearFormatting();
			bool result;
			if (ShortText)
			{
				result = this.Find.Execute(text, replaceWith, WdFindWrap.wdFindStop, WdReplace.wdReplaceOne);
			}
			else
			{
				this.Find.Text = text;
				if (result = this.Find.Execute())
				{
					this.TypeText = replaceWith;
				}
			}
			return result;
		}

		public void Collapse(WdCollapseDirection direction)
		{
			this.InvokeMethod("Collapse", new object[]
			{
				direction
			});
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

		public void MoveLeft(WdUnits unit, int count, WdMovementType extend)
		{
			this.InvokeMethod("MoveLeft", new object[]
			{
				unit,
				count,
				extend
			});
		}

		public void MoveRight(WdUnits unit, int count, WdMovementType extend)
		{
			this.InvokeMethod("MoveRight", new object[]
			{
				unit,
				count,
				extend
			});
		}

		public void MoveUp(WdUnits unit, int count, WdMovementType extend)
		{
			this.InvokeMethod("MoveUp", new object[]
			{
				unit,
				count,
				extend
			});
		}

		public void MoveDown(WdUnits unit, int count, WdMovementType extend)
		{
			this.InvokeMethod("MoveDown", new object[]
			{
				unit,
				count,
				extend
			});
		}

		public void Copy()
		{
			this.InvokeMethod("Copy", null);
		}

		public void Cut()
		{
			this.InvokeMethod("Cut", null);
		}

		public void Paste()
		{
			this.InvokeMethod("Paste", null);
		}

		public void Select()
		{
			this.InvokeMethod("Select", null);
		}
	}
}
