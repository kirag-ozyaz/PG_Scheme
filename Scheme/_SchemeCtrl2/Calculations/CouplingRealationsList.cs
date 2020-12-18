using System;
using System.Collections.Generic;
using System.Threading;

namespace SchemeCtrl2.Calculations
{
	public class CouplingRealationsList : List<CouplingRelation>
	{
		public event CouplingRealationsListChangeEventHandler CouplingRealationsListChangeEvent
		{
			add
			{
				CouplingRealationsListChangeEventHandler couplingRealationsListChangeEventHandler = this.couplingRealationsListChangeEventHandler_0;
				CouplingRealationsListChangeEventHandler couplingRealationsListChangeEventHandler2;
				do
				{
					couplingRealationsListChangeEventHandler2 = couplingRealationsListChangeEventHandler;
					CouplingRealationsListChangeEventHandler value2 = (CouplingRealationsListChangeEventHandler)Delegate.Combine(couplingRealationsListChangeEventHandler2, value);
					couplingRealationsListChangeEventHandler = Interlocked.CompareExchange<CouplingRealationsListChangeEventHandler>(ref this.couplingRealationsListChangeEventHandler_0, value2, couplingRealationsListChangeEventHandler2);
				}
				while (couplingRealationsListChangeEventHandler != couplingRealationsListChangeEventHandler2);
			}
			remove
			{
				CouplingRealationsListChangeEventHandler couplingRealationsListChangeEventHandler = this.couplingRealationsListChangeEventHandler_0;
				CouplingRealationsListChangeEventHandler couplingRealationsListChangeEventHandler2;
				do
				{
					couplingRealationsListChangeEventHandler2 = couplingRealationsListChangeEventHandler;
					CouplingRealationsListChangeEventHandler value2 = (CouplingRealationsListChangeEventHandler)Delegate.Remove(couplingRealationsListChangeEventHandler2, value);
					couplingRealationsListChangeEventHandler = Interlocked.CompareExchange<CouplingRealationsListChangeEventHandler>(ref this.couplingRealationsListChangeEventHandler_0, value2, couplingRealationsListChangeEventHandler2);
				}
				while (couplingRealationsListChangeEventHandler != couplingRealationsListChangeEventHandler2);
			}
		}

		public CouplingRealationsList()
		{
			this.CouplingRealationsListChangeEvent += this.CouplingRealationsList_CouplingRealationsListChangeEvent;
		}

		private void CouplingRealationsList_CouplingRealationsListChangeEvent(object sender, CouplingRealationsListChangeEventArgs e)
		{
		}

		public new void Add(CouplingRelation couplingRelation)
		{
			base.Add(couplingRelation);
			this.couplingRealationsListChangeEventHandler_0(this, new CouplingRealationsListChangeEventArgs(couplingRelation, CouplingRealationsListChangeType.Add));
		}

		private void method_0(CouplingRelation couplingRelation_0, CouplingRelationChangeEventArgs couplingRelationChangeEventArgs_0)
		{
			CouplingRealationsListChangeEventArgs couplingRealationsListChangeEventArgs = new CouplingRealationsListChangeEventArgs(couplingRelation_0, CouplingRealationsListChangeType.ItemChanget);
			couplingRealationsListChangeEventArgs.couplingRealationChangeEventArgs = couplingRelationChangeEventArgs_0;
			this.couplingRealationsListChangeEventHandler_0(this, couplingRealationsListChangeEventArgs);
		}

		public new void Remove(CouplingRelation couplingRelation)
		{
			base.Remove(couplingRelation);
			this.couplingRealationsListChangeEventHandler_0(this, new CouplingRealationsListChangeEventArgs(couplingRelation, CouplingRealationsListChangeType.Remove));
		}

		private CouplingRealationsListChangeEventHandler couplingRealationsListChangeEventHandler_0;
	}
}
