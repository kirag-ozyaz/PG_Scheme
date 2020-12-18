using System;

namespace OfficeLB.Word
{
	public class View : Base
	{
		public View()
		{
			
			
		}

		public View(object oView)
		{
			
			base.ctor(oView);
		}

		public bool DisplayBackgrounds
		{
			get
			{
				return (bool)this.GetProperty("DisplayBackgrounds", null);
			}
			set
			{
				this.SetProperty("DisplayBackgrounds", new object[]
				{
					value
				});
			}
		}

		public bool DisplayPageBoundaries
		{
			get
			{
				return (bool)this.GetProperty("DisplayPageBoundaries", null);
			}
			set
			{
				this.SetProperty("DisplayPageBoundaries", new object[]
				{
					value
				});
			}
		}

		public bool DisplaySmartTags
		{
			get
			{
				return (bool)this.GetProperty("DisplaySmartTags", null);
			}
			set
			{
				this.SetProperty("DisplaySmartTags", new object[]
				{
					value
				});
			}
		}

		public bool Draft
		{
			get
			{
				return (bool)this.GetProperty("Draft", null);
			}
			set
			{
				this.SetProperty("Draft", new object[]
				{
					value
				});
			}
		}

		public WdFieldShading FieldShading
		{
			get
			{
				return (WdFieldShading)this.GetProperty("FieldShading", null);
			}
			set
			{
				this.SetProperty("FieldShading", new object[]
				{
					value
				});
			}
		}

		public bool Magnifier
		{
			get
			{
				return (bool)this.GetProperty("Magnifier", null);
			}
			set
			{
				this.SetProperty("Magnifier", new object[]
				{
					value
				});
			}
		}

		public bool MailMergeDataView
		{
			get
			{
				return (bool)this.GetProperty("MailMergeDataView", null);
			}
			set
			{
				this.SetProperty("MailMergeDataView", new object[]
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

		public bool ReadingLayout
		{
			get
			{
				return (bool)this.GetProperty("ReadingLayout", null);
			}
			set
			{
				this.SetProperty("ReadingLayout", new object[]
				{
					value
				});
			}
		}

		public bool ReadingLayoutActualView
		{
			get
			{
				return (bool)this.GetProperty("ReadingLayoutActualView", null);
			}
			set
			{
				this.SetProperty("ReadingLayoutActualView", new object[]
				{
					value
				});
			}
		}

		public bool ReadingLayoutAllowMultiplePages
		{
			get
			{
				return (bool)this.GetProperty("ReadingLayoutAllowMultiplePages", null);
			}
			set
			{
				this.SetProperty("ReadingLayoutAllowMultiplePages", new object[]
				{
					value
				});
			}
		}

		public bool RevisionsBalloonShowConnectingLines
		{
			get
			{
				return (bool)this.GetProperty("RevisionsBalloonShowConnectingLines", null);
			}
			set
			{
				this.SetProperty("RevisionsBalloonShowConnectingLines", new object[]
				{
					value
				});
			}
		}

		public WdRevisionsBalloonMargin RevisionsBalloonSide
		{
			get
			{
				return (WdRevisionsBalloonMargin)this.GetProperty("RevisionsBalloonSide", null);
			}
			set
			{
				this.SetProperty("RevisionsBalloonSide", new object[]
				{
					value
				});
			}
		}

		public int RevisionsBalloonWidth
		{
			get
			{
				return (int)this.GetProperty("RevisionsBalloonWidth", null);
			}
			set
			{
				this.SetProperty("RevisionsBalloonWidth", new object[]
				{
					value
				});
			}
		}

		public WdRevisionsBalloonWidthType RevisionsBalloonWidthType
		{
			get
			{
				return (WdRevisionsBalloonWidthType)this.GetProperty("RevisionsBalloonWidthType", null);
			}
			set
			{
				this.SetProperty("RevisionsBalloonWidthType", new object[]
				{
					value
				});
			}
		}

		public WdRevisionsMode RevisionsMode
		{
			get
			{
				return (WdRevisionsMode)this.GetProperty("RevisionsMode", null);
			}
			set
			{
				this.SetProperty("RevisionsMode", new object[]
				{
					value
				});
			}
		}

		public WdRevisionsView RevisionsView
		{
			get
			{
				return (WdRevisionsView)this.GetProperty("RevisionsView", null);
			}
			set
			{
				this.SetProperty("RevisionsView", new object[]
				{
					value
				});
			}
		}

		public WdSeekView SeekView
		{
			get
			{
				return (WdSeekView)this.GetProperty("SeekView", null);
			}
			set
			{
				this.SetProperty("SeekView", new object[]
				{
					value
				});
			}
		}

		public bool ShadeEditableRanges
		{
			get
			{
				return (int)this.GetProperty("ShadeEditableRanges", null) == 65535;
			}
			set
			{
				if (value)
				{
					this.SetProperty("ShadeEditableRanges", new object[]
					{
						65535
					});
					return;
				}
				this.SetProperty("ShadeEditableRanges", new object[]
				{
					0
				});
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

		public bool ShowAnimation
		{
			get
			{
				return (bool)this.GetProperty("ShowAnimation", null);
			}
			set
			{
				this.SetProperty("ShowAnimation", new object[]
				{
					value
				});
			}
		}

		public bool ShowBookmarks
		{
			get
			{
				return (bool)this.GetProperty("ShowBookmarks", null);
			}
			set
			{
				this.SetProperty("ShowBookmarks", new object[]
				{
					value
				});
			}
		}

		public bool ShowComments
		{
			get
			{
				return (bool)this.GetProperty("ShowComments", null);
			}
			set
			{
				this.SetProperty("ShowComments", new object[]
				{
					value
				});
			}
		}

		public bool ShowDrawings
		{
			get
			{
				return (bool)this.GetProperty("ShowDrawings", null);
			}
			set
			{
				this.SetProperty("ShowDrawings", new object[]
				{
					value
				});
			}
		}

		public bool ShowHighlight
		{
			get
			{
				return (bool)this.GetProperty("ShowHighlight", null);
			}
			set
			{
				this.SetProperty("ShowHighlight", new object[]
				{
					value
				});
			}
		}

		public bool ShowHyphens
		{
			get
			{
				return (bool)this.GetProperty("ShowHyphens", null);
			}
			set
			{
				this.SetProperty("ShowHyphens", new object[]
				{
					value
				});
			}
		}

		public bool ShowInkAnnotations
		{
			get
			{
				return (bool)this.GetProperty("ShowInkAnnotations", null);
			}
			set
			{
				this.SetProperty("ShowInkAnnotations", new object[]
				{
					value
				});
			}
		}

		public bool ShowInsertionsAndDeletions
		{
			get
			{
				return (bool)this.GetProperty("ShowInsertionsAndDeletions", null);
			}
			set
			{
				this.SetProperty("ShowInsertionsAndDeletions", new object[]
				{
					value
				});
			}
		}

		public bool ShowMainTextLayer
		{
			get
			{
				return (bool)this.GetProperty("ShowMainTextLayer", null);
			}
			set
			{
				this.SetProperty("ShowMainTextLayer", new object[]
				{
					value
				});
			}
		}

		public bool ShowObjectAnchors
		{
			get
			{
				return (bool)this.GetProperty("ShowObjectAnchors", null);
			}
			set
			{
				this.SetProperty("ShowObjectAnchors", new object[]
				{
					value
				});
			}
		}

		public bool ShowOptionalBreaks
		{
			get
			{
				return (bool)this.GetProperty("ShowOptionalBreaks", null);
			}
			set
			{
				this.SetProperty("ShowOptionalBreaks", new object[]
				{
					value
				});
			}
		}

		public bool ShowParagraphs
		{
			get
			{
				return (bool)this.GetProperty("ShowParagraphs", null);
			}
			set
			{
				this.SetProperty("ShowParagraphs", new object[]
				{
					value
				});
			}
		}

		public bool ShowPicturePlaceHolders
		{
			get
			{
				return (bool)this.GetProperty("ShowPicturePlaceHolders", null);
			}
			set
			{
				this.SetProperty("ShowPicturePlaceHolders", new object[]
				{
					value
				});
			}
		}

		public bool ShowRevisionsAndComments
		{
			get
			{
				return (bool)this.GetProperty("ShowRevisionsAndComments", null);
			}
			set
			{
				this.SetProperty("ShowRevisionsAndComments", new object[]
				{
					value
				});
			}
		}

		public bool ShowSpaces
		{
			get
			{
				return (bool)this.GetProperty("ShowSpaces", null);
			}
			set
			{
				this.SetProperty("ShowSpaces", new object[]
				{
					value
				});
			}
		}

		public bool ShowTabs
		{
			get
			{
				return (bool)this.GetProperty("ShowTabs", null);
			}
			set
			{
				this.SetProperty("ShowTabs", new object[]
				{
					value
				});
			}
		}

		public bool ShowTextBoundaries
		{
			get
			{
				return (bool)this.GetProperty("ShowTextBoundaries", null);
			}
			set
			{
				this.SetProperty("ShowTextBoundaries", new object[]
				{
					value
				});
			}
		}

		public bool ShowXMLMarkup
		{
			get
			{
				return (bool)this.GetProperty("ShowXMLMarkup", null);
			}
			set
			{
				this.SetProperty("ShowXMLMarkup", new object[]
				{
					value
				});
			}
		}

		public WdSpecialPane SplitSpecial
		{
			get
			{
				return (WdSpecialPane)this.GetProperty("SplitSpecial", null);
			}
			set
			{
				this.SetProperty("SplitSpecial", new object[]
				{
					value
				});
			}
		}

		public bool TableGridlines
		{
			get
			{
				return (bool)this.GetProperty("TableGridlines", null);
			}
			set
			{
				this.SetProperty("TableGridlines", new object[]
				{
					value
				});
			}
		}

		public WdViewType Type
		{
			get
			{
				return (WdViewType)this.GetProperty("Type", null);
			}
			set
			{
				this.SetProperty("Type", new object[]
				{
					value
				});
			}
		}

		public bool WrapToWindow
		{
			get
			{
				return (bool)this.GetProperty("WrapToWindow", null);
			}
			set
			{
				this.SetProperty("WrapToWindow", new object[]
				{
					value
				});
			}
		}

		public void CollapseOutline()
		{
			this.InvokeMethod("CollapseOutline", null);
		}

		public void ExpandOutline()
		{
			this.InvokeMethod("ExpandOutline", null);
		}

		public void NextHeaderFooter()
		{
			this.InvokeMethod("NextHeaderFooter", null);
		}

		public void PreviousHeaderFooter()
		{
			this.InvokeMethod("PreviousHeaderFooter", null);
		}

		public void ShowAllHeadings()
		{
			this.InvokeMethod("Name", null);
		}

		public void ShowHeading(int level)
		{
			this.InvokeMethod("ShowHeading", new object[]
			{
				level
			});
		}
	}
}
