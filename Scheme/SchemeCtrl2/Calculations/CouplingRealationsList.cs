using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SchemeCtrl2.Calculations
{
	public class CouplingRealationsList : List<CouplingRelation>
	{
		[CompilerGenerated]
		internal void method_0(Delegate37 value)
		{
			Delegate37 @delegate = this.delegate37_0;
			Delegate37 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate37 value2 = (Delegate37)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange<Delegate37>(ref this.delegate37_0, value2, delegate2);
			}
			while (@delegate != delegate2);
		}

		[CompilerGenerated]
		internal void method_1(Delegate37 value)
		{
			Delegate37 @delegate = this.delegate37_0;
			Delegate37 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate37 value2 = (Delegate37)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange<Delegate37>(ref this.delegate37_0, value2, delegate2);
			}
			while (@delegate != delegate2);
		}

		internal CouplingRealationsList()
		{
			
			
			this.method_0(new Delegate37(this.method_2));
		}

		private void method_2(object object_0, Class86 class86_0)
		{
		}

		internal void method_3(CouplingRelation couplingRelation_0)
		{
			base.Add(couplingRelation_0);
			this.delegate37_0(this, new Class86(couplingRelation_0, (Enum8)0));
		}

		private void method_4(CouplingRelation couplingRelation_0, Class87 class87_0)
		{
			Class86 @class = new Class86(couplingRelation_0, (Enum8)2);
			@class.class87_0 = class87_0;
			this.delegate37_0(this, @class);
		}

		internal void method_5(CouplingRelation couplingRelation_0)
		{
			base.Remove(couplingRelation_0);
			this.delegate37_0(this, new Class86(couplingRelation_0, (Enum8)1));
		}

		[CompilerGenerated]
		private Delegate37 delegate37_0;
	}
}
