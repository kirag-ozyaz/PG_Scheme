using System;

namespace OfficeLB.Word
{
	public class Frames : Base
	{
		public Frames()
		{
			
			
		}

		public Frames(object oFrames)
		{
			
			base.ctor(oFrames);
		}

		public Sentence this[int index]
		{
			get
			{
				return new Sentence(this.GetProperty("Item", new object[]
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
	}
}
