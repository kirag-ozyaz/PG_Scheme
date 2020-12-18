using System;

namespace OfficeLB.Word
{
	public class Sentence : Base
	{
		public Sentence()
		{
			
			
		}

		public Sentence(object oSentence)
		{
			
			base.ctor(oSentence);
		}

		public int End
		{
			get
			{
				return (int)this.GetProperty("End", null);
			}
			set
			{
				this.SetProperty("End", new object[]
				{
					value
				});
			}
		}

		public int Start
		{
			get
			{
				return (int)this.GetProperty("Start", null);
			}
			set
			{
				this.SetProperty("Start", new object[]
				{
					value
				});
			}
		}

		public string Text
		{
			get
			{
				return this.GetProperty("Text", null).ToString();
			}
			set
			{
				this.SetProperty("Text", new object[]
				{
					value
				});
			}
		}
	}
}
