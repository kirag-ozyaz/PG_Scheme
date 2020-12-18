using System;

namespace OfficeLB.Word
{
	public class Characters : Base
	{
		public Characters()
		{
			
			
		}

		public Characters(object oCharacters)
		{
			
			base.ctor(oCharacters);
		}

		public char this[int index]
		{
			get
			{
				return (char)this.GetProperty("Item", new object[]
				{
					index
				});
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
	}
}
