using System;

namespace OfficeLB.Word
{
	public class Options : Base
	{
		public Options()
		{
			
			
		}

		public Options(object oOptions)
		{
			
			base.ctor(oOptions);
		}

		public bool BackgroundSave
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("BackgroundSave", null).ToString());
			}
			set
			{
				this.SetProperty("BackgroundSave", new object[]
				{
					value
				});
			}
		}

		public bool Overtype
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("Overtype", null).ToString());
			}
			set
			{
				this.SetProperty("Overtype", new object[]
				{
					value
				});
			}
		}

		public bool PrintFieldCodes
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("PrintFieldCodes", null).ToString());
			}
			set
			{
				this.SetProperty("PrintFieldCodes", new object[]
				{
					value
				});
			}
		}

		public bool PrintHiddenText
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("PrintHiddenText", null).ToString());
			}
			set
			{
				this.SetProperty("PrintHiddenText", new object[]
				{
					value
				});
			}
		}

		public bool RepleceSelection
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("RepleceSelection", null).ToString());
			}
			set
			{
				this.SetProperty("RepleceSelection", new object[]
				{
					value
				});
			}
		}

		public bool UpdateFieldsAtPrint
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("UpdateFieldsAtPrint", null).ToString());
			}
			set
			{
				this.SetProperty("UpdateFieldsAtPrint", new object[]
				{
					value
				});
			}
		}
	}
}
