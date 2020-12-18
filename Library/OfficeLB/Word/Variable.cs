using System;

namespace OfficeLB.Word
{
	public class Variable : Base
	{
		public Variable()
		{
			
			
		}

		public Variable(object oVariable)
		{
			
			base.ctor(oVariable);
		}

		public Application Application
		{
			get
			{
				return (Application)this.GetProperty("Application", null);
			}
		}

		public int Creator
		{
			get
			{
				return (int)this.GetProperty("Creator", null);
			}
		}

		public int Index
		{
			get
			{
				return (int)this.GetProperty("Index", null);
			}
		}

		public string Name
		{
			get
			{
				return (string)this.GetProperty("Name", null);
			}
			set
			{
				this.SetProperty("Name", new object[]
				{
					value
				});
			}
		}

		public object Parent
		{
			get
			{
				return this.GetProperty("Parent", null);
			}
		}

		public object Value
		{
			get
			{
				return this.GetProperty("Value", null);
			}
			set
			{
				this.SetProperty("Value", new object[]
				{
					value
				});
			}
		}

		public void Delete()
		{
			this.InvokeMethod("Delete", null);
		}
	}
}
