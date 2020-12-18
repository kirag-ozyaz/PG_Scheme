using System;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class PointToolEvetsArgs : EventArgs
	{
		public PointToolEvetsArgs(UnitPoint oldPoint, UnitPoint newPoint, Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor();
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
