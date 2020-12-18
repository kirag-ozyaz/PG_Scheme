using System;
using System.Runtime.CompilerServices;

namespace SchemeCtrl2.Calculations
{
	public class AmperageConductorEventArgs : EventArgs
	{
		public AmperageConductorEventArgs()
		{
			this.Cancel = false;
		}

		public bool Cancel { get; set; }

		[CompilerGenerated]
		private bool bool_0;
	}
}
