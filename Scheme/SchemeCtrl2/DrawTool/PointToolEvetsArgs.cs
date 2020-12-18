using System;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class PointToolEvetsArgs : EventArgs
	{
		public PointToolEvetsArgs(UnitPoint oldPoint, UnitPoint newPoint, Branch branch)
		{
			
			
			this.newPoint = newPoint;
			this.oldPoint = oldPoint;
			this.branch = branch;
		}

		public UnitPoint oldPoint;

		public UnitPoint newPoint;

		public Branch branch;

		public bool cancel;
	}
}
