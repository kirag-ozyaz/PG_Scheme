using System;
using System.Runtime.CompilerServices;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.WCF
{
	public class ObjectOnLineServer
	{
		public virtual int Id { get; set; }

		public bool VertMirror { get; set; }

		public bool GorMirror { get; set; }

		public bool On { get; set; }

		public float Delta { get; set; }

		public TypeSwitch TypeObjectOnLine { get; set; }

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private bool bool_1;

		[CompilerGenerated]
		private bool bool_2;

		[CompilerGenerated]
		private float float_0;

		[CompilerGenerated]
		private TypeSwitch typeSwitch_0;
	}
}
