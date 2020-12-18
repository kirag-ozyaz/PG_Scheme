using System;

namespace OfficeLB.Word
{
	public class Windows : Base
	{
		public Windows()
		{
			
			
		}

		public Windows(object oWindows)
		{
			
			base.ctor(oWindows);
		}

		public Window this[int index]
		{
			get
			{
				return new Window(this.InvokeReturn("Item", new object[]
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
		}

		public void Arrange(WdArrangeStyle style)
		{
			this.InvokeMethod("Arrange", new object[]
			{
				style
			});
		}
	}
}
