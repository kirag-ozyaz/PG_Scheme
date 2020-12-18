using SchemeModelN;
using SchemeModelN.Calculations;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal delegate void Delegate0(Interface1 sender, EventArgs0 e);

internal class EventArgs0 : EventArgs
{
	internal EventArgs0()
	{
		
		
		this.method_1(false);
	}

	[CompilerGenerated]
	internal bool method_0()
	{
		return this.bool_0;
	}

	[CompilerGenerated]
	internal void method_1(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	[CompilerGenerated]
	private bool bool_0;
}


internal interface Interface1
{
    [CompilerGenerated]
    void imethod_0(Delegate0 delegate0_0);

    [CompilerGenerated]
    void imethod_1(Delegate0 delegate0_0);

    [CompilerGenerated]
    void imethod_2(Delegate0 delegate0_0);

    [CompilerGenerated]
    void imethod_3(Delegate0 delegate0_0);

    IEnumerable<ElectricAmperage> imethod_4();

    void imethod_5(IEnumerable<ElectricAmperage> ienumerable_0);

    ElectricAmperage imethod_6(ElectricPoint electricPoint_0);

    ElectricPoint imethod_7(ElectricAmperage electricAmperage_0);

    IEnumerable<ElectricPoint> imethod_8(ElectricAmperage electricAmperage_0);

    void imethod_9();

    void imethod_10(ElectricPoint electricPoint_0);

    void imethod_11(ElectricPoint electricPoint_0, ElectricAmperage electricAmperage_0);

    bool imethod_12(ElectricAmperage electricAmperage_0);
}
internal interface Interface0
{
    bool imethod_0();

    void imethod_1(bool bool_0);
}