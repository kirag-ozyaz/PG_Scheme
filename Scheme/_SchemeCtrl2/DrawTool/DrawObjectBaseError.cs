using System;
using System.Threading;

namespace SchemeCtrl2.DrawTool
{
	public class DrawObjectBaseError
	{
		public event EventHandler Fixed
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		public DrawObjectBaseError(string message, DrawObjectBase drawObjectBase_1)
		{
			this.string_0 = message;
			this.drawObjectBase_0 = drawObjectBase_1;
		}

		public void Fix()
		{
			this.eventHandler_0(this, new EventArgs());
		}

		private string string_0;

		private DrawObjectBase drawObjectBase_0;

		private EventHandler eventHandler_0;
	}
}
