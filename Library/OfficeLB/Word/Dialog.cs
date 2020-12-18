using System;

namespace OfficeLB.Word
{
	public class Dialog : Base
	{
		public Dialog()
		{
			
			
		}

		public Dialog(object oDialog)
		{
			
			base.ctor(oDialog);
		}

		public void Show()
		{
			this.InvokeMethod("Show", null);
		}

		public int Display(int time)
		{
			return (int)this.InvokeReturn("Display", new object[]
			{
				time
			});
		}

		public void Execute()
		{
			this.InvokeMethod("Execute", null);
		}

		public void Update()
		{
			this.InvokeMethod("Update", null);
		}
	}
}
