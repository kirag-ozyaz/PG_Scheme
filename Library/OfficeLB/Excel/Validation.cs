using System;

namespace OfficeLB.Excel
{
	public class Validation : Base
	{
		public Validation()
		{
			
			
		}

		public Validation(object oRange)
		{
			
			base.ctor(oRange);
		}

		public xlDVAlertStyle AlertStyle
		{
			get
			{
				return (xlDVAlertStyle)this.GetProperty("AlertStyle", null);
			}
			set
			{
				this.SetProperty("AlertStyle", new object[]
				{
					value
				});
			}
		}

		public Application Application
		{
			get
			{
				return new Application(this.GetProperty("Application", null));
			}
		}

		public int Creator
		{
			get
			{
				return (int)this.GetProperty("Creator", null);
			}
		}

		public object Parent
		{
			get
			{
				return this.GetProperty("Parent", null);
			}
		}
	}
}
