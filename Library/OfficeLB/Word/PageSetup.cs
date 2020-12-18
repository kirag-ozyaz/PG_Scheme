using System;

namespace OfficeLB.Word
{
	public class PageSetup : Base
	{
		public PageSetup()
		{
			
			
		}

		public PageSetup(object oPageSetup)
		{
			
			base.ctor(oPageSetup);
		}

		public Application Application
		{
			get
			{
				return (Application)this.GetProperty("Application", null);
			}
		}

		public bool BookFoldPrinting
		{
			get
			{
				return (bool)this.GetProperty("BookFoldPrinting", null);
			}
			set
			{
				this.SetProperty("BookFoldPrinting", new object[]
				{
					value
				});
			}
		}

		public bool BookFoldPrintingSheets
		{
			get
			{
				return (bool)this.GetProperty("BookFoldPrintingSheets", null);
			}
			set
			{
				this.SetProperty("BookFoldPrintingSheets", new object[]
				{
					value
				});
			}
		}

		public bool BookFoldRevPrinting
		{
			get
			{
				return (bool)this.GetProperty("BookFoldRevPrinting", null);
			}
			set
			{
				this.SetProperty("BookFoldRevPrinting", new object[]
				{
					value
				});
			}
		}

		public double BottomMargin
		{
			get
			{
				return (double)this.GetProperty("BottomMargin", null);
			}
			set
			{
				this.SetProperty("BottomMargin", new object[]
				{
					value
				});
			}
		}

		public int CharsLine
		{
			get
			{
				return (int)this.GetProperty("CharsLine", null);
			}
			set
			{
				this.SetProperty("CharsLine", new object[]
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

		public bool DifferentFirstPageHeaderFooter
		{
			get
			{
				return (bool)this.GetProperty("DifferentFirstPageHeaderFooter", null);
			}
			set
			{
				this.SetProperty("DifferentFirstPageHeaderFooter", new object[]
				{
					value
				});
			}
		}

		public WdPaperTray FirstPageTray
		{
			get
			{
				return (WdPaperTray)this.GetProperty("FirstPageTray", null);
			}
			set
			{
				this.SetProperty("FirstPageTray", new object[]
				{
					value
				});
			}
		}

		public double FooterDistance
		{
			get
			{
				return (double)this.GetProperty("FooterDistance", null);
			}
			set
			{
				this.SetProperty("FooterDistance", new object[]
				{
					value
				});
			}
		}

		public double Gutter
		{
			get
			{
				return (double)this.GetProperty("Gutter", null);
			}
			set
			{
				this.SetProperty("Gutter", new object[]
				{
					value
				});
			}
		}

		public WdGutterStyleOld GutterPos
		{
			get
			{
				return (WdGutterStyleOld)this.GetProperty("GutterPos", null);
			}
			set
			{
				this.SetProperty("GutterPos", new object[]
				{
					value
				});
			}
		}

		public double HeaderDistance
		{
			get
			{
				return (double)this.GetProperty("HeaderDistance", null);
			}
			set
			{
				this.SetProperty("HeaderDistance", new object[]
				{
					value
				});
			}
		}

		public WdLayoutMode LayoutMode
		{
			get
			{
				return (WdLayoutMode)this.GetProperty("LayoutMode", null);
			}
			set
			{
				this.SetProperty("LayoutMode", new object[]
				{
					value
				});
			}
		}

		public double LeftMargin
		{
			get
			{
				return (double)this.GetProperty("LeftMargin", null);
			}
			set
			{
				this.SetProperty("LeftMargin", new object[]
				{
					value
				});
			}
		}

		public int LinesPage
		{
			get
			{
				return (int)this.GetProperty("LinesPage", null);
			}
			set
			{
				this.SetProperty("LinesPage", new object[]
				{
					value
				});
			}
		}

		public double MirrorMargins
		{
			get
			{
				return (double)this.GetProperty("MirrorMargins", null);
			}
			set
			{
				this.SetProperty("MirrorMargins", new object[]
				{
					value
				});
			}
		}

		public bool OddAndEvenPagesHeaderFooter
		{
			get
			{
				return (bool)this.GetProperty("OddAndEvenPagesHeaderFooter", null);
			}
			set
			{
				this.SetProperty("OddAndEvenPagesHeaderFooter", new object[]
				{
					value
				});
			}
		}

		public WdOrientation Orientation
		{
			get
			{
				return (WdOrientation)this.GetProperty("Orientation", null);
			}
			set
			{
				this.SetProperty("Orientation", new object[]
				{
					value
				});
			}
		}

		public WdPaperTray OtherPagesTray
		{
			get
			{
				return (WdPaperTray)this.GetProperty("OtherPagesTray", null);
			}
			set
			{
				this.SetProperty("OtherPagesTray", new object[]
				{
					value
				});
			}
		}

		public double PageHeight
		{
			get
			{
				return (double)this.GetProperty("PageHeight", null);
			}
			set
			{
				this.SetProperty("PageHeight", new object[]
				{
					value
				});
			}
		}

		public double PageWidth
		{
			get
			{
				return (double)this.GetProperty("PageWidth", null);
			}
			set
			{
				this.SetProperty("PageWidth", new object[]
				{
					value
				});
			}
		}

		public WdPaperSize PaperSize
		{
			get
			{
				return (WdPaperSize)this.GetProperty("PaperSize", null);
			}
			set
			{
				this.SetProperty("PaperSize", new object[]
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

		public double RightMargin
		{
			get
			{
				return (double)this.GetProperty("RightMargin", null);
			}
			set
			{
				this.SetProperty("RightMargin", new object[]
				{
					value
				});
			}
		}

		public WdSectionDirection SectionDirection
		{
			get
			{
				return (WdSectionDirection)this.GetProperty("SectionDirection", null);
			}
			set
			{
				this.SetProperty("SectionDirection", new object[]
				{
					value
				});
			}
		}

		public WdSectionStart SectionStart
		{
			get
			{
				return (WdSectionStart)this.GetProperty("SectionStart", null);
			}
			set
			{
				this.SetProperty("SectionStart", new object[]
				{
					value
				});
			}
		}

		public bool SuppressEndnotes
		{
			get
			{
				return (bool)this.GetProperty("SuppressEndnotes", null);
			}
			set
			{
				this.SetProperty("SuppressEndnotes", new object[]
				{
					value
				});
			}
		}

		public double TopMargin
		{
			get
			{
				return (double)this.GetProperty("TopMargin", null);
			}
			set
			{
				this.SetProperty("TopMargin", new object[]
				{
					value
				});
			}
		}

		public bool TwoPagesOnOne
		{
			get
			{
				return (bool)this.GetProperty("TwoPagesOnOne", null);
			}
			set
			{
				this.SetProperty("TwoPagesOnOne", new object[]
				{
					value
				});
			}
		}

		public WdVerticalAlignment VerticalAlignment
		{
			get
			{
				return (WdVerticalAlignment)this.GetProperty("VerticalAlignment", null);
			}
			set
			{
				this.SetProperty("VerticalAlignment", new object[]
				{
					value
				});
			}
		}

		public void SetAsTemplateDefault()
		{
			this.InvokeMethod("SetAsTemplateDefault", null);
		}

		public void TogglePortrait()
		{
			this.InvokeMethod("TogglePortrait", null);
		}
	}
}
