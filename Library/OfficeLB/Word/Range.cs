using System;

namespace OfficeLB.Word
{
	public class Range : Base
	{
		public Range()
		{
			
			
		}

		public Range(object oRange)
		{
			
			base.ctor(oRange);
		}

		public int BookmarkID
		{
			get
			{
				return (int)this.GetProperty("BookmarkID", null);
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
			set
			{
				this.SetProperty("Borders", new object[]
				{
					value
				});
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

		public WdCharacterWidth CharacterWidth
		{
			get
			{
				return (WdCharacterWidth)this.GetProperty("CharacterWidth", null);
			}
			set
			{
				this.SetProperty("CharacterWidth", new object[]
				{
					value
				});
			}
		}

		public Columns Columns
		{
			get
			{
				return new Columns(this.GetProperty("Columns", null));
			}
		}

		public bool CombineCharacters
		{
			get
			{
				return (bool)this.GetProperty("CombineCharacters", null);
			}
			set
			{
				this.SetProperty("CombineCharacters", new object[]
				{
					value
				});
			}
		}

		public Comments Comments
		{
			get
			{
				return new Comments(this.GetProperty("Comments", null));
			}
		}

		public Document Document
		{
			get
			{
				return new Document(this.GetProperty("Document", null));
			}
		}

		public Range Duplicate
		{
			get
			{
				return new Range(this.GetProperty("Duplicate", null));
			}
		}

		public Editors Editors
		{
			get
			{
				return new Editors(this.GetProperty("Editors", null));
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

		public int End
		{
			get
			{
				return (int)this.GetProperty("End", null);
			}
		}

		public Find Find
		{
			get
			{
				return new Find(this.GetProperty("Find", null));
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
			set
			{
				this.InvokeMethod("FormattedText", new object[]
				{
					value
				});
			}
		}

		public Frames Frames
		{
			get
			{
				return new Frames(this.GetProperty("Frames", null));
			}
		}

		public bool GrammarChecked
		{
			get
			{
				return (bool)this.GetProperty("GrammarChecked", null);
			}
			set
			{
				this.SetProperty("GrammarChecked", new object[]
				{
					value
				});
			}
		}

		public WdColorIndex HighlightColorIndex
		{
			get
			{
				return (WdColorIndex)this.GetProperty("HighlightColorIndex", null);
			}
			set
			{
				this.SetProperty("HighlightColorIndex", new object[]
				{
					value
				});
			}
		}

		public WdHorizontalInVerticalType HorizontalInVertical
		{
			get
			{
				return (WdHorizontalInVerticalType)this.GetProperty("HorizontalInVertical", null);
			}
			set
			{
				this.SetProperty("HorizontalInVertical", new object[]
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

		public int Information(WdInformation value)
		{
			return (int)this.GetProperty("Information", new object[]
			{
				value
			});
		}

		public bool IsEndOfRowMark
		{
			get
			{
				return (bool)this.GetProperty("IsEndOfRowMark", null);
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

		public WdKana Kana
		{
			get
			{
				return (WdKana)this.GetProperty("Kana", null);
			}
			set
			{
				this.SetProperty("Kana", new object[]
				{
					value
				});
			}
		}

		public bool LanguageDetected
		{
			get
			{
				return (bool)this.GetProperty("LanguageDetected", null);
			}
			set
			{
				this.SetProperty("LanguageDetected", new object[]
				{
					value
				});
			}
		}

		public object LanguageID
		{
			get
			{
				return this.GetProperty("LanguageID", null);
			}
			set
			{
				this.SetProperty("LanguageID", new object[]
				{
					value
				});
			}
		}

		public WdLanguageID LanguageIDFarEast
		{
			get
			{
				return (WdLanguageID)this.GetProperty("LanguageIDFarEast", null);
			}
			set
			{
				this.SetProperty("LanguageIDFarEast", new object[]
				{
					value
				});
			}
		}

		public WdLanguageID Name
		{
			get
			{
				return (WdLanguageID)this.GetProperty("LanguageIDOther", null);
			}
			set
			{
				this.SetProperty("LanguageIDOther", new object[]
				{
					value
				});
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

		public int PreviousBookmarkID
		{
			get
			{
				return (int)this.GetProperty("PreviousBookmarkID", null);
			}
			set
			{
				this.SetProperty("PreviousBookmarkID", new object[]
				{
					value
				});
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

		public bool ShowAll
		{
			get
			{
				return (bool)this.GetProperty("ShowAll", null);
			}
			set
			{
				this.SetProperty("ShowAll", new object[]
				{
					value
				});
			}
		}

		public bool SpellingChecked
		{
			get
			{
				return (bool)this.GetProperty("SpellingChecked", null);
			}
			set
			{
				this.SetProperty("SpellingChecked", new object[]
				{
					value
				});
			}
		}

		public int Start
		{
			get
			{
				return (int)this.GetProperty("Start", null);
			}
		}

		public int StoryLength
		{
			get
			{
				return (int)this.GetProperty("StoryLength", null);
			}
			set
			{
				this.SetProperty("StoryLength", new object[]
				{
					value
				});
			}
		}

		public WdStoryType StoryType
		{
			get
			{
				return (WdStoryType)this.GetProperty("StoryType", null);
			}
			set
			{
				this.SetProperty("StoryType", new object[]
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

		public WdTwoLinesInOneType TwoLinesInOne
		{
			get
			{
				return (WdTwoLinesInOneType)this.GetProperty("TwoLinesInOne", null);
			}
			set
			{
				this.SetProperty("TwoLinesInOne", new object[]
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

		public object[,] ValueArray
		{
			get
			{
				return (object[,])this.GetProperty("Value", null);
			}
			set
			{
				this.SetProperty("Value", new object[]
				{
					value
				});
			}
		}

		public object Value
		{
			get
			{
				return this.GetProperty("Value", null);
			}
			set
			{
				this.SetProperty("Value", new object[]
				{
					value
				});
			}
		}

		public Words Words
		{
			get
			{
				return new Words(this.GetProperty("Words", null));
			}
		}

		public string XML
		{
			get
			{
				return this.GetProperty("XML", null).ToString();
			}
			set
			{
				this.SetProperty("XML", new object[]
				{
					value
				});
			}
		}

		public void AutoFormat()
		{
			this.InvokeMethod("AutoFormat", null);
		}

		public void Collapse(WdCollapseDirection direction)
		{
			this.InvokeMethod("Collapse", new object[]
			{
				direction
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

		public void Delete(WdUnits Unit, int Count)
		{
			this.InvokeMethod("Delete", new object[]
			{
				Unit,
				Count
			});
		}

		public int Expand(WdUnits unit)
		{
			return (int)this.InvokeReturn("Expand", new object[]
			{
				unit
			});
		}

		public Range GoToNext(WdGoToItem item)
		{
			return new Range(this.InvokeReturn("GoToNext", new object[]
			{
				item
			}));
		}

		public Range GoToPrevious(WdGoToItem item)
		{
			return new Range(this.InvokeReturn("GoToPrevious", new object[]
			{
				item
			}));
		}

		public void InsertAfter(string text)
		{
			this.InvokeMethod("InsertAfter", new object[]
			{
				text
			});
		}

		public void InsertBefore(string text)
		{
			this.InvokeMethod("InsertBefore", new object[]
			{
				text
			});
		}

		public void InsertBreak(WdBreakType type)
		{
			this.InvokeMethod("InsertBreak", new object[]
			{
				type
			});
		}

		public void InsertParagraph()
		{
			this.InvokeMethod("InsertParagraph", null);
		}

		public void InsertParagraphAfter()
		{
			this.InvokeMethod("InsertParagraphAfter", null);
		}

		public void InsertParagraphBefore()
		{
			this.InvokeMethod("InsertParagraphBefore", null);
		}

		public void Paste()
		{
			this.InvokeMethod("Paste", null);
		}

		public void Select()
		{
			this.InvokeMethod("Select", null);
		}

		public void TypeParagraph()
		{
			this.InvokeMethod("TypeParagraph", null);
		}

		public void MoveStart(WdUnits unit, int position)
		{
			this.InvokeMethod("MoveStart", new object[]
			{
				unit,
				position
			});
		}

		public void MoveEnd(WdUnits unit, int position)
		{
			this.InvokeMethod("MoveEnd", new object[]
			{
				unit,
				position
			});
		}

		public void SetRange(int start, int end)
		{
			this.InvokeMethod("SetRange", new object[]
			{
				start,
				end
			});
		}
	}
}
