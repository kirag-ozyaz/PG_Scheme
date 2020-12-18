using System;

namespace OfficeLB.Excel
{
	public class Interior : Base
	{
		public int ColorIndex
		{
			get
			{
				return (int)this.GetProperty("ColorIndex", null);
			}
			set
			{
				this.SetProperty("ColorIndex", new object[]
				{
					value
				});
			}
		}

		public Interior()
		{
			
			
		}

		public Interior(object oInterior)
		{
			
			base.ctor(oInterior);
		}
	}
}
