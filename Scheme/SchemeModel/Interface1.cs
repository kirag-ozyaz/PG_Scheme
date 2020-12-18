using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SchemeModelN;
using SchemeModelN.Calculations;

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
