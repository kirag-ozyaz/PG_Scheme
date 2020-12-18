using System;
using System.Drawing;

namespace SchemeCtrl2.DrawTool
{
	public class ResizeRectangleEventsArgs : EventArgs
	{
		public ResizeRectangleEventsArgs(RectangleF rect, int nodeNumber)
		{
			this.Rectangle = rect;
			this.NodeNumber = nodeNumber;
		}

		public RectangleF Rectangle;

		public bool Cancel;

		public int NodeNumber;
	}
}
