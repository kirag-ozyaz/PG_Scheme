using System;
using System.Collections.Generic;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.WCF
{
	public struct BranchServer
	{
		public BranchType type;

		public int SourcePoint;

		public int DestenationPoint;

		public int Relation;

		public List<int> childObjects;

		public List<LineStateServer> States;
	}
}
