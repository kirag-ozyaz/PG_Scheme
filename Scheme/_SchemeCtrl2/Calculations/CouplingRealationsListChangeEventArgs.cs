using System;

namespace SchemeCtrl2.Calculations
{
	public class CouplingRealationsListChangeEventArgs
	{
		public CouplingRealationsListChangeEventArgs(CouplingRelation item, CouplingRealationsListChangeType type)
		{
			this.item = item;
			this.type = type;
		}

		public CouplingRelation item;

		public CouplingRealationsListChangeType type;

		public CouplingRelationChangeEventArgs couplingRealationChangeEventArgs;
	}
}
