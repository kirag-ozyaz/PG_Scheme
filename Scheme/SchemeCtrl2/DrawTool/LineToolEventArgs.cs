using System;
using SchemeCtrl2.Calculations;

namespace SchemeCtrl2.DrawTool
{
	public class LineToolEventArgs : EventArgs
	{
		public LineToolEventArgs(PointTool eventPoint, LineToolState state, CouplingRelation couplingRelation, Branch branch, ObjectOnLine objectOnLine)
		{
			
			
			this.eventPoint = eventPoint;
			this.state = state;
			this.couplingRelation = couplingRelation;
			this.branch = branch;
			this.objectOnLine = objectOnLine;
		}

		public PointTool eventPoint;

		public LineToolState state;

		public CouplingRelation couplingRelation;

		public Branch branch;

		public ObjectOnLine objectOnLine;
	}
}
