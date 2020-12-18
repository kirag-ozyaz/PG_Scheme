using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SchemeCtrl2.DrawTool;

internal class EventArgs0 : EventArgs
{
	[CompilerGenerated]
	internal List<DrawObjectBase> method_0()
	{
		return this.list_0;
	}

	[CompilerGenerated]
	internal void method_1(List<DrawObjectBase> list_1)
	{
		this.list_0 = list_1;
	}

	internal EventArgs0(List<DrawObjectBase> list_1)
	{
		Class63.AGd1PxHzk5wxP();
		base..ctor();
		this.method_1(list_1);
	}

	[CompilerGenerated]
	private List<DrawObjectBase> list_0;
}
