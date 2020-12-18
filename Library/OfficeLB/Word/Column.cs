using System;

namespace OfficeLB.Word
{
	public class Column : Base
	{
		public Column()
		{
			
			
		}

		public Column(object oColumn)
		{
			
			base.ctor(oColumn);
		}

		public WdPreferredType PreferredWidthType
		{
			get
			{
				return (WdPreferredType)this.GetProperty("PreferredWidthType", null);
			}
			set
			{
				this.SetProperty("PreferredWidthType", new object[]
				{
					value
				});
			}
		}

		public double PreferredWidth
		{
			get
			{
				return (double)this.GetProperty("PreferredWidth", null);
			}
			set
			{
				this.SetProperty("PreferredWidth", new object[]
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

		public ParagraphFormat ParagraphFormat
		{
			get
			{
				return new ParagraphFormat(this.GetProperty("ParagraphFormat", null));
			}
		}

		public Range Range
		{
			get
			{
				return new Range(this.GetProperty("Range", null));
			}
		}

		public void AutoFit()
		{
			this.InvokeMethod("AutoFit", null);
		}
	}
}
