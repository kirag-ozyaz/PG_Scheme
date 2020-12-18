using System;

namespace OfficeLB.Word
{
	public class Section : Base
	{
		public Section()
		{
			
			
		}

		public Section(object oSection)
		{
			
			base.ctor(oSection);
		}

		public Application Application
		{
			get
			{
				return (Application)this.GetProperty("Application", null);
			}
		}

		public Borders Borders
		{
			get
			{
				return new Borders(this.GetProperty("Borders", null));
			}
		}

		public Range Range
		{
			get
			{
				return new Range(this.GetProperty("Range", null));
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

		public int Index
		{
			get
			{
				return (int)this.GetProperty("Index", null);
			}
		}

		public bool ProtectedForForms
		{
			get
			{
				return (bool)this.GetProperty("ProtectedForForms", null);
			}
			set
			{
				this.SetProperty("ProtectedForForms", new object[]
				{
					value
				});
			}
		}
	}
}
