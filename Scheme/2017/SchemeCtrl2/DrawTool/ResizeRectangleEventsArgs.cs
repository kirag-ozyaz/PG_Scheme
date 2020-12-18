using System;
using System.Drawing;

namespace SchemeCtrl2.DrawTool
{
	public class ResizeRectangleEventsArgs : EventArgs
	{
		public ResizeRectangleEventsArgs(RectangleF rect, int nodeNumber)
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.Rectangle = rect;
			this.NodeNumber = nodeNumber;
		}

		public RectangleF Rectangle;

		public bool Cancel;

		public int NodeNumber;
	}
}
