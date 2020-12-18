using System;
using System.Runtime.CompilerServices;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.ElectricModel
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

		[CompilerGenerated]
		private eTypeRectangleTool eTypeRectangleTool_0;
	}
}
