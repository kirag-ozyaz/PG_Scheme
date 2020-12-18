using System;

namespace OfficeLB.Word
{
	public class Words : Base
	{
		public Words()
		{
			
			
		}

		public Words(object oWords)
		{
			
			base.ctor(oWords);
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

		public Range First
		{
			get
			{
				return new Range(this.GetProperty("First", null));
			}
		}

		public object Item
		{
			get
			{
				return this.GetProperty("Item", null);
			}
		}

		public Range Last
		{
			get
			{
				return new Range(this.GetProperty("Last", null));
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
