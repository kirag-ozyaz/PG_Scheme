using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SchemeModelN
{
	public class ElectricSubstation : ElectricObject
	{
		public eTypeRectangleTool TypeSubstation { get; set; }

		public override string ToString()
		{
			eTypeRectangleTool typeSubstation = this.TypeSubstation;
			switch (typeSubstation)
			{
			case eTypeRectangleTool.PP:
				return "ПП-" + base.Name;
			case eTypeRectangleTool.CP:
				return "ЦП-" + base.Name;
			case eTypeRectangleTool.RP:
				return "РП-" + base.Name;
			case eTypeRectangleTool.TP:
				return "ТП-" + base.Name;
			default:
				if (typeSubstation == eTypeRectangleTool.SP)
				{
					return "СП-" + base.Name;
				}
				if (typeSubstation != eTypeRectangleTool.PPNO)
				{
					return string.Empty;
				}
				return "ППНО-" + base.Name;
			}
		}

		public ElectricSubstation()
		{
			
			
		}
    }
}
