using System;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.Calculations
{
	public class CouplingRelationChangeEventArgs
	{
		public CouplingRelationChangeEventArgs(DrawObjectBase oldVertex, DrawObjectBase newVertex)
		{
			this.oldVertex = oldVertex;
			this.newVertex = newVertex;
		}

		public DrawObjectBase oldVertex;

		public DrawObjectBase newVertex;
	}
}
