using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.WCF
{
	public class ObjectBaseServer
	{
		public bool VertMirror { get; set; }

		public bool GorMirror { get; set; }

		public bool On { get; set; }

		public float Delta { get; set; }

		public TypeSwitch TypeObjectOnLine
		{
			get
			{
				return this.typeSwitch_0;
			}
			set
			{
				this.typeSwitch_0 = value;
			}
		}

		public virtual string Text { get; set; }

		public virtual eTypeTransferObject TypeTransferObject { get; set; }

		public eTypeRectangleTool TypeRectangle
		{
			get
			{
				return this.eTypeRectangleTool_0;
			}
			set
			{
				this.eTypeRectangleTool_0 = value;
			}
		}

		public eTypeShinaTool TypeShina
		{
			get
			{
				return this.eTypeShinaTool_0;
			}
			set
			{
				this.eTypeShinaTool_0 = value;
			}
		}

		public virtual int Id { get; set; }

		public virtual int ParentId { get; set; }

		public virtual List<UnitPoint> ListPoints
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
			}
		}

		public virtual List<int> ChildrenObjects
		{
			get
			{
				return this.list_2;
			}
			set
			{
				this.list_2 = value;
			}
		}

		public virtual List<PointServerTool> ListPointsTool
		{
			get
			{
				return this.list_1;
			}
			set
			{
				this.list_1 = value;
			}
		}

		public List<BranchServer> Branches
		{
			get
			{
				return this.list_3;
			}
			set
			{
				this.list_3 = value;
			}
		}

		public List<RelationServer> Relations
		{
			get
			{
				return this.list_4;
			}
			set
			{
				this.list_4 = value;
			}
		}

		public ObjectBaseServer()
		{
			
			this.list_0 = new List<UnitPoint>();
			this.list_1 = new List<PointServerTool>();
			this.list_2 = new List<int>();
			this.list_3 = new List<BranchServer>();
			this.list_4 = new List<RelationServer>();
			this.eTypeShinaTool_0 = eTypeShinaTool.None;
			this.eTypeRectangleTool_0 = eTypeRectangleTool.TP;
			this.typeSwitch_0 = TypeSwitch.None;
			
		}

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private bool bool_1;

		[CompilerGenerated]
		private bool bool_2;

		[CompilerGenerated]
		private float float_0;

		private List<UnitPoint> list_0;

		private List<PointServerTool> list_1;

		private List<int> list_2;

		private List<BranchServer> list_3;

		private List<RelationServer> list_4;

		private eTypeShinaTool eTypeShinaTool_0;

		private eTypeRectangleTool eTypeRectangleTool_0;

		private TypeSwitch typeSwitch_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private eTypeTransferObject eTypeTransferObject_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;
	}
}
