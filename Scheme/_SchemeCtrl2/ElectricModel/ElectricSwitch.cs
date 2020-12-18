using System;
using System.Runtime.CompilerServices;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.ElectricModel
{
	public class ElectricSwitch : ElectricObject
	{
		public TypeSwitch TypeSwitch { get; set; }

		public bool On
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		private bool bool_0 = true;

		[CompilerGenerated]
		private TypeSwitch typeSwitch_0;
	}
}
