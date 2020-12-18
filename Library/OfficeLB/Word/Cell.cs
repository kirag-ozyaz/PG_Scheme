using System;

namespace OfficeLB.Word
{
	public class Cell : Base
	{
		public Cell()
		{
			
			
		}

		public Cell(object oCell)
		{

            base.ctor(oCell);
        }

		public double BottomPadding
		{
			get
			{
				return (double)this.GetProperty("BottomPadding", null);
			}
			set
			{
				this.SetProperty("BottomPadding", new object[]
				{
					value
				});
			}
		}

		public bool FitText
		{
			get
			{
				return (bool)this.GetProperty("FitText", null);
			}
			set
			{
				this.SetProperty("FitText", new object[]
				{
					value
				});
			}
		}

		public double LeftPadding
		{
			get
			{
				return (double)this.GetProperty("LeftPadding", null);
			}
			set
			{
				this.SetProperty("LeftPadding", new object[]
				{
					value
				});
			}
		}

		public double RightPadding
		{
			get
			{
				return (double)this.GetProperty("RightPadding", null);
			}
			set
			{
				this.SetProperty("RightPadding", new object[]
				{
					value
				});
			}
		}

		public double TopPadding
		{
			get
			{
				return (double)this.GetProperty("TopPadding", null);
			}
			set
			{
				this.SetProperty("TopPadding", new object[]
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

		public ParagraphFormat ParagraphFormat
		{
			get
			{
				return new ParagraphFormat(this.GetProperty("ParagraphFormat", null));
			}
		}

		public Font Font
		{
			get
			{
				return new Font(this.GetProperty("Font", null));
			}
		}

		public Range Range
		{
			get
			{
				return new Range(this.GetProperty("Range", null));
			}
		}
	}
}
