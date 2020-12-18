using System;

namespace SchemeCtrl2.Canvas.Forms
{
	public class Parameter
	{
		public Parameter()
		{
		}

		public Parameter(int idParameter, string value)
		{
			this.int_0 = idParameter;
			this.string_0 = value;
		}

		public int IdParameter
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public string Value
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

		private int int_0;

		private string string_0;
	}
}
