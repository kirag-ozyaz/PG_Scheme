using System;
using System.ComponentModel;

namespace SchemeModelN
{
    /// <summary>
    /// тип подстанции
    /// </summary>
	public enum eTypeRectangleTool
	{
		[Description("ТП")]
		TP = 538,
		[Description("ПП")]
		PP = 535,
		[Description("РП")]
		RP = 537,
		[Description("ЦП")]
		CP = 536,
		[Description("СП")]
		SP = 1034,
		[Description("ППНО")]
		PPNO = 1275
	}
}
