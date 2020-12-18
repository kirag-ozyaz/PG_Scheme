using System;

namespace Constants
{
	public class StringValue : Attribute
	{
		public StringValue(string value)
		{
			//Class2.ugTePaEz97aN4();
			
			this.string_0 = value;
		}

		public string Value
		{
			get
			{
				return this.string_0;
			}
		}

		private string string_0;
	}
}
