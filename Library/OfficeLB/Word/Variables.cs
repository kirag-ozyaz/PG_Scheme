using System;
using System.Collections;

namespace OfficeLB.Word
{
	public class Variables : Base
	{
		public Variables()
		{
			
			
		}

		public Variables(object oVariables)
		{
			
			base.ctor(oVariables);
		}

		public Application Application
		{
			get
			{
				return (Application)this.GetProperty("Application", null);
			}
		}

		public int Count
		{
			get
			{
				return (int)this.GetProperty("Count", null);
			}
		}

		public int Creator
		{
			get
			{
				return (int)this.GetProperty("Creator", null);
			}
		}

		public int Item
		{
			get
			{
				return (int)this.GetProperty("Item", null);
			}
		}

		public object Parent
		{
			get
			{
				return this.GetProperty("Creator", null);
			}
			set
			{
				this.SetProperty("Creator", new object[]
				{
					value
				});
			}
		}

		public void Add()
		{
			this.InvokeMethod("Add", null);
		}

		public IEnumerable GetEnumerator()
		{
			return (IEnumerable)this.InvokeReturn("GetEnumerator", null);
		}
	}
}
