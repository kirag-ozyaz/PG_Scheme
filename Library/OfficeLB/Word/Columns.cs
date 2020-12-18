using System;

namespace OfficeLB.Word
{
	public class Columns : Base
	{
		public Columns()
		{
			
			
		}

		public Columns(object oColumns)
		{
			
			base.ctor(oColumns);
		}

		public Column this[int item]
		{
			get
			{
				return new Column(this.InvokeReturn("Item", new object[]
				{
					item
				}));
			}
		}

		public void DistributeWidth()
		{
			this.InvokeMethod("DistributeWidth", null);
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
