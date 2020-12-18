using System;
using System.ComponentModel;

namespace OfficeLB.Excel
{
	public class ActiveSheet : Base
	{
		public PageSetup PageSetup
		{
			get
			{
				return new PageSetup(this.GetProperty("PageSetup", null));
			}
		}

		public ActiveSheet()
		{
			
			
		}

		public ActiveSheet(object oActiveSheet)
		{
			
			base.ctor(oActiveSheet);
		}

		[Description("Returns a Range object that represents the used range on the specified worksheet. Read-only.")]
		public Range UsedRange
		{
			get
			{
				return new Range(this.GetProperty("UsedRange", null));
			}
		}
	}
}
