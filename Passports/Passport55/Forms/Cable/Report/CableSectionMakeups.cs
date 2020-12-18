using System;

namespace Passport.Forms.Cable.Report
{
	public class CableSectionMakeups
	{
		public CableSectionMakeups()
		{
		}

		public CableSectionMakeups(string firstRow, string secondRow)
		{
			this.string_0 = firstRow;
			this.string_1 = secondRow;
		}

		public string FirstRow
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		public string SecondRow
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		private string string_0;

		private string string_1;
	}
}
