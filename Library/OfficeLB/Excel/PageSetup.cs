using System;

namespace OfficeLB.Excel
{
	public class PageSetup : Base
	{
		public bool AlignMarginsHeaderFooter
		{
			get
			{
				return (bool)this.GetProperty("AlignMarginsHeaderFooter", null);
			}
			set
			{
				this.SetProperty("AlignMarginsHeaderFooter", new object[]
				{
					value ? 1 : 0
				});
			}
		}

		public bool BlackAndWhite
		{
			get
			{
				return (bool)this.GetProperty("BlackAndWhite", null);
			}
			set
			{
				this.SetProperty("BlackAndWhite", new object[]
				{
					value ? 1 : 0
				});
			}
		}

		public string CenterHeader
		{
			get
			{
				return (string)this.GetProperty("CenterHeader", null);
			}
			set
			{
				this.SetProperty("CenterHeader", new object[]
				{
					value
				});
			}
		}

		public string CenterFooter
		{
			get
			{
				return (string)this.GetProperty("CenterFooter", null);
			}
			set
			{
				this.SetProperty("CenterFooter", new object[]
				{
					value
				});
			}
		}

		public bool CenterHorizontally
		{
			get
			{
				return (bool)this.GetProperty("CenterHorizontally", null);
			}
			set
			{
				this.SetProperty("CenterHorizontally", new object[]
				{
					value
				});
			}
		}

		public bool CenterVertically
		{
			get
			{
				return (bool)this.GetProperty("CenterVertically", null);
			}
			set
			{
				this.SetProperty("CenterVertically", new object[]
				{
					value
				});
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

		public string LeftHeader
		{
			get
			{
				return (string)this.GetProperty("LeftHeader", null);
			}
			set
			{
				this.SetProperty("LeftHeader", new object[]
				{
					value
				});
			}
		}

		public string LeftFooter
		{
			get
			{
				return (string)this.GetProperty("LeftFooter", null);
			}
			set
			{
				this.SetProperty("LeftFooter", new object[]
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

		public xlPageOrientation Orientation
		{
			get
			{
				return (xlPageOrientation)this.GetProperty("Orientation", null);
			}
			set
			{
				this.SetProperty("Orientation", new object[]
				{
					value
				});
			}
		}

		public xlPaperSize PaperSize
		{
			get
			{
				return (xlPaperSize)this.GetProperty("PaperSize", null);
			}
			set
			{
				this.SetProperty("PaperSize", new object[]
				{
					value
				});
			}
		}

		public string RightHeader
		{
			get
			{
				return (string)this.GetProperty("RightHeader", null);
			}
			set
			{
				this.SetProperty("RightHeader", new object[]
				{
					value
				});
			}
		}

		public string RightFooter
		{
			get
			{
				return (string)this.GetProperty("RightFooter", null);
			}
			set
			{
				this.SetProperty("RightFooter", new object[]
				{
					value
				});
			}
		}

		public bool ScaleWithDocHeaderFooter
		{
			get
			{
				return (bool)this.GetProperty("ScaleWithDocHeaderFooter", null);
			}
			set
			{
				this.SetProperty("ScaleWithDocHeaderFooter", new object[]
				{
					value
				});
			}
		}

		public string PrintArea
		{
			get
			{
				return (string)this.GetProperty("PrintArea", null);
			}
			set
			{
				this.SetProperty("PrintArea", new object[]
				{
					value
				});
			}
		}

		public bool PrintGridlines
		{
			get
			{
				return (bool)this.GetProperty("PrintGridlines", null);
			}
			set
			{
				this.SetProperty("PrintGridlines", new object[]
				{
					value
				});
			}
		}

		public bool PrintHeadings
		{
			get
			{
				return (bool)this.GetProperty("PrintHeadings", null);
			}
			set
			{
				this.SetProperty("PrintHeadings", new object[]
				{
					value
				});
			}
		}

		public int Zoom
		{
			get
			{
				return (int)this.GetProperty("Zoom", null);
			}
			set
			{
				this.SetProperty("Zoom", new object[]
				{
					value
				});
			}
		}

		public PageSetup()
		{
			
			
		}

		public PageSetup(object oPageSetup)
		{
			
			base.ctor(oPageSetup);
		}
	}
}
