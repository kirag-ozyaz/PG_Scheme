using System;

namespace OfficeLB.Word
{
	public class FoundFiles : Base
	{
		public FoundFiles()
		{
			
			
		}

		public FoundFiles(object oFoundFiles)
		{
			
			base.ctor(oFoundFiles);
		}

		public int Count
		{
			get
			{
				return (int)this.GetProperty("Count", null);
			}
		}

		public string this[int index]
		{
			get
			{
				return this.GetProperty("Item", new object[]
				{
					index
				}).ToString();
			}
		}
	}
}
