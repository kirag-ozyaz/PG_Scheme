using System;

namespace Passport.Classes
{
	public class ObjListEventArgs : EventArgs
	{
		public ObjListEventArgs(int int_1)
		{
			this.int_0 = int_1;
		}

		public double NewArea
		{
			get
			{
				return (double)this.int_0;
			}
		}

		private int int_0;
	}
}
