using System;

namespace OfficeLB.Excel
{
	public class Borders : Base
	{
		public xlWeightBorder Weight
		{
			get
			{
				return (xlWeightBorder)this.GetProperty("Weight", null);
			}
			set
			{
				this.SetProperty("Weight", new object[]
				{
					value
				});
			}
		}

		public xlLineStyle LineStyle
		{
			get
			{
				return (xlLineStyle)this.GetProperty("LineStyle", null);
			}
			set
			{
				this.SetProperty("LineStyle", new object[]
				{
					value
				});
			}
		}

		public Borders()
		{
			
			
		}

		public Borders(object oBorders)
		{
			
			base.ctor(oBorders);
		}
	}
}
