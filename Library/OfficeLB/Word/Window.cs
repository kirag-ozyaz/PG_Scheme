using System;

namespace OfficeLB.Word
{
	public class Window : Base
	{
		public Window()
		{
			
			
		}

		public Window(object oWindow)
		{
			
			base.ctor(oWindow);
		}

		public WdWindowState WindowState
		{
			get
			{
				return (WdWindowState)this.GetProperty("WindowState", null);
			}
			set
			{
				this.SetProperty("WindowState", new object[]
				{
					value
				});
			}
		}

		public void NewWindow()
		{
			this.InvokeMethod("NewWindow", null);
		}
	}
}
