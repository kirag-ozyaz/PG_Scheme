using System;

namespace OfficeLB.Word
{
	public class Sections : Base
	{
		public Sections()
		{
			
			
		}

		public Sections(object oSections)
		{
			
			base.ctor(oSections);
		}

		public Application Application
		{
			get
			{
				return (Application)this.GetProperty("Application", null);
			}
		}

		public Section this[int index]
		{
			get
			{
				return new Section(this.InvokeReturn("Item", new object[]
				{
					index
				}));
			}
		}

		public Section First
		{
			get
			{
				return new Section(this.GetProperty("First", null));
			}
		}

		public Section Last
		{
			get
			{
				return new Section(this.GetProperty("Last", null));
			}
		}

		public PageSetup PageSetup
		{
			get
			{
				return new PageSetup(this.GetProperty("PageSetup", null));
			}
		}

		public object Parent
		{
			get
			{
				return this.GetProperty("Parent", null);
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

		public Section Add()
		{
			return new Section(this.InvokeReturn("Add", null));
		}
	}
}
