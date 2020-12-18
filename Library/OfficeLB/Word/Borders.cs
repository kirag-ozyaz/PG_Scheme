using System;

namespace OfficeLB.Word
{
	public class Borders : Base
	{
		public Borders()
		{
			
			
		}

		public Borders(object oBorders)
		{
			
			base.ctor(oBorders);
		}

		public Border this[int index]
		{
			get
			{
				return new Border(this.GetProperty("Item", new object[]
				{
					index
				}));
			}
		}

		public int Count
		{
			get
			{
				return (int)this.GetProperty("Count", null);
			}
			set
			{
				this.SetProperty("Count", new object[]
				{
					value
				});
			}
		}

		public bool Enable
		{
			get
			{
				return (bool)this.GetProperty("Enable", null);
			}
			set
			{
				this.SetProperty("Enable", new object[]
				{
					value
				});
			}
		}

		public void ApplyPageBordersToAllSections()
		{
			this.InvokeMethod("ApplyPageBordersToAllSections", null);
		}

		public bool Shadow
		{
			get
			{
				return (bool)this.GetProperty("Shadow", null);
			}
			set
			{
				this.SetProperty("Shadow", new object[]
				{
					value
				});
			}
		}
	}
}
