using System;
using System.Collections.Generic;
using System.ComponentModel;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.Calculations
{
	[TypeConverter(typeof(Class84))]
	public class Amperage
	{
		internal IEnumerable<Amperage> method_0()
		{
			return this.list_1;
		}

		public DrawObjectBase Conductor
		{
			get
			{
				return this.drawObjectBase_0;
			}
			set
			{
				this.drawObjectBase_0 = value;
			}
		}

		public List<Amperage> NextAmperages
		{
			get
			{
				return this.list_0;
			}
		}

		internal DrawObjectBase Source
		{
			get
			{
				return this.drawObjectBase_1;
			}
			set
			{
				this.drawObjectBase_1 = value;
			}
		}

		public Amperage(DrawObjectBase source, DrawObjectBase conductor, AmperageProperties amperageProperties, Amperage mediator)
		{
			Class90.TDroV38zslI2T();
			this.list_0 = new List<Amperage>();
			this.list_1 = new List<Amperage>();
			base..ctor();
			this.amperageProperties = amperageProperties;
			this.Source = source;
			this.drawObjectBase_0 = conductor;
			if (conductor != source && conductor.Master != source)
			{
				this.method_6(mediator);
			}
		}

		internal Amperage method_1(DrawObjectBase drawObjectBase_2)
		{
			if (drawObjectBase_2.Master != null)
			{
				return null;
			}
			Amperage amperage = new Amperage(this.Source, drawObjectBase_2, this.amperageProperties, this);
			this.list_0.Add(amperage);
			return amperage;
		}

		internal Amperage method_2(DrawObjectBase drawObjectBase_2, AmperageProperties amperageProperties_0)
		{
			if (drawObjectBase_2.Master != null)
			{
				return null;
			}
			Amperage amperage = new Amperage(this.Source, drawObjectBase_2, amperageProperties_0, this);
			this.list_0.Add(amperage);
			return amperage;
		}

		internal Amperage method_3(DrawObjectBase drawObjectBase_2)
		{
			Amperage amperage = new Amperage(this.Source, drawObjectBase_2, this.amperageProperties, this);
			foreach (Amperage amperage_ in this.list_1)
			{
				amperage.method_6(amperage_);
			}
			return amperage;
		}

		internal void method_4()
		{
			while (this.list_1.Count > 0)
			{
				this.vdAlEyJnoG(this.list_1[0]);
			}
			if (this.drawObjectBase_0.GetType() == typeof(ShinaTool))
			{
				((ShinaTool)this.drawObjectBase_0).Amperage = null;
				this.method_5();
			}
			else
			{
				((LineTool)this.drawObjectBase_0).RemoveAmperage(this);
			}
			this.drawObjectBase_0.vmethod_1();
		}

		internal void method_5()
		{
			while (this.list_0.Count > 0)
			{
				this.list_0[0].vdAlEyJnoG(this);
			}
		}

		internal void method_6(Amperage amperage_0)
		{
			this.list_1.Add(amperage_0);
		}

		internal void vdAlEyJnoG(Amperage amperage_0)
		{
			if (this.list_1.Count == 1 && this.drawObjectBase_0 != this.drawObjectBase_1)
			{
				this.method_5();
				if (this.drawObjectBase_0.GetType() == typeof(ShinaTool))
				{
					((ShinaTool)this.drawObjectBase_0).Amperage = null;
				}
				else if (this.drawObjectBase_0.GetType() == typeof(LineTool) || this.drawObjectBase_0.GetType() == typeof(LineCellTool))
				{
					((LineTool)this.drawObjectBase_0).RemoveAmperage(this);
					((LineTool)this.drawObjectBase_0).vmethod_1();
				}
			}
			this.list_1.Remove(amperage_0);
			amperage_0.list_0.Remove(this);
		}

		public List<DrawObjectBase> GetPowerSource()
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			this.method_8(list, this, null, null);
			return list;
		}

		internal bool method_7(DrawObjectBase drawObjectBase_2)
		{
			List<DrawObjectBase> list_ = new List<DrawObjectBase>();
			return this.method_9(list_, this.drawObjectBase_0, drawObjectBase_2);
		}

		private bool method_8(List<DrawObjectBase> list_2, Amperage amperage_0, Amperage amperage_1, DrawObjectBase drawObjectBase_2)
		{
			DrawObjectBase drawObjectBase = amperage_0.drawObjectBase_0;
			if (drawObjectBase == drawObjectBase_2)
			{
				return true;
			}
			if (drawObjectBase.GetType() != typeof(LineTool))
			{
				if (drawObjectBase.GetType() != typeof(LineCellTool))
				{
					if (drawObjectBase.GetType() != typeof(ShinaTool))
					{
						return false;
					}
					list_2.Add(drawObjectBase);
					using (List<Amperage>.Enumerator enumerator = amperage_0.list_1.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Amperage amperage_2 = enumerator.Current;
							if (this.method_8(list_2, amperage_2, amperage_0, drawObjectBase_2))
							{
								return true;
							}
						}
						return false;
					}
				}
			}
			if (amperage_1 == null)
			{
				list_2.Add(drawObjectBase);
				using (List<Amperage>.Enumerator enumerator = amperage_0.list_1.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Amperage amperage_3 = enumerator.Current;
						if (this.method_8(list_2, amperage_3, amperage_0, drawObjectBase_2))
						{
							return true;
						}
					}
					return false;
				}
			}
			using (Dictionary<PointTool, Amperage>.ValueCollection.Enumerator enumerator2 = ((LineTool)drawObjectBase).Amperages.Values.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current == amperage_0)
					{
						List<DrawObjectBase> wayOnLineTool = Amperage.GetWayOnLineTool(amperage_0, amperage_1);
						BranchCollection branchCollection = new BranchCollection();
						foreach (DrawObjectBase drawObjectBase2 in wayOnLineTool)
						{
							Branch branch = (Branch)drawObjectBase2;
							branchCollection.Add(branch);
						}
						list_2.Add(branchCollection);
						foreach (Amperage amperage_4 in amperage_0.list_1)
						{
							if (this.method_8(list_2, amperage_4, amperage_0, drawObjectBase_2))
							{
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		public static List<DrawObjectBase> GetWayOnLineTool(Amperage amperage, Amperage nextAmperage)
		{
			if (amperage.Conductor.GetType() != typeof(LineTool) && amperage.Conductor.GetType() != typeof(LineCellTool))
			{
				return null;
			}
			LineTool lineTool = (LineTool)amperage.Conductor;
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			PointTool pointTool_ = null;
			DrawObjectBase conductor = nextAmperage.Conductor;
			if (conductor.GetType() != typeof(LineTool))
			{
				if (conductor.GetType() != typeof(LineCellTool))
				{
					if (conductor.GetType() == typeof(ShinaTool))
					{
						using (IEnumerator<PointTool> enumerator = lineTool.Ends.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								PointTool pointTool = enumerator.Current;
								if (pointTool.Parent == conductor)
								{
									pointTool_ = pointTool;
									break;
								}
							}
							goto IL_12E;
						}
					}
					throw new Exception();
				}
			}
			foreach (PointTool pointTool2 in ((LineTool)conductor).Amperages.Keys)
			{
				if (((LineTool)conductor).Amperages[pointTool2] == nextAmperage)
				{
					pointTool_ = pointTool2;
					break;
				}
			}
			IL_12E:
			PointTool pointTool3 = null;
			foreach (PointTool pointTool4 in lineTool.Amperages.Keys)
			{
				if (lineTool.Amperages[pointTool4] == amperage)
				{
					pointTool3 = pointTool4;
					break;
				}
			}
			if (pointTool3 == null)
			{
			}
			List<CouplingRelation> list2 = new List<CouplingRelation>();
			Amperage.smethod_0(list2, lineTool, pointTool3, null, pointTool_);
			foreach (CouplingRelation couplingRelation in list2)
			{
				foreach (Branch item in couplingRelation.method_3())
				{
					list.Add(item);
				}
			}
			return list;
		}

		private static bool smethod_0(List<CouplingRelation> list_2, LineTool lineTool_0, PointTool pointTool_0, CouplingRelation couplingRelation_0, PointTool pointTool_1)
		{
			foreach (CouplingRelation couplingRelation in pointTool_0.CouplingRelations)
			{
				if (couplingRelation.method_3().Count != 0 && couplingRelation != couplingRelation_0 && couplingRelation.Line == lineTool_0)
				{
					PointTool pointTool = (couplingRelation.method_1() == pointTool_0) ? couplingRelation.method_2() : couplingRelation.method_1();
					if (pointTool == pointTool_1 || Amperage.smethod_0(list_2, lineTool_0, pointTool, couplingRelation, pointTool_1))
					{
						list_2.Add(couplingRelation);
						return true;
					}
				}
			}
			return false;
		}

		private bool method_9(List<DrawObjectBase> list_2, DrawObjectBase drawObjectBase_2, DrawObjectBase drawObjectBase_3)
		{
			if (drawObjectBase_2.GetType() != typeof(LineTool))
			{
				if (drawObjectBase_2.GetType() != typeof(LineCellTool))
				{
					if (drawObjectBase_2.GetType() != typeof(ShinaTool))
					{
						return false;
					}
					using (List<Amperage>.Enumerator enumerator = ((ShinaTool)drawObjectBase_2).Amperage.list_1.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Amperage amperage = enumerator.Current;
							DrawObjectBase drawObjectBase = amperage.drawObjectBase_0;
							if (drawObjectBase == drawObjectBase_3)
							{
								return true;
							}
							if (!list_2.Contains(drawObjectBase))
							{
								list_2.Add(drawObjectBase);
								if (drawObjectBase != amperage.drawObjectBase_1 && this.method_9(list_2, drawObjectBase, drawObjectBase_3))
								{
									return true;
								}
							}
						}
						return false;
					}
				}
			}
			foreach (Amperage amperage2 in ((LineTool)drawObjectBase_2).Amperages.Values)
			{
				foreach (Amperage amperage3 in amperage2.list_1)
				{
					DrawObjectBase drawObjectBase2 = amperage3.drawObjectBase_0;
					bool flag = true;
					if (drawObjectBase2 == drawObjectBase_3)
					{
						return true;
					}
					if (drawObjectBase2.GetType() != typeof(LineTool))
					{
						if (drawObjectBase2.GetType() != typeof(LineCellTool))
						{
							if (list_2.Contains(drawObjectBase2))
							{
								continue;
							}
							list_2.Add(drawObjectBase2);
							if (drawObjectBase2 != amperage3.drawObjectBase_1 && drawObjectBase2.Master == null && this.method_9(list_2, drawObjectBase2, drawObjectBase_3))
							{
								return true;
							}
							continue;
						}
					}
					foreach (CouplingRelation couplingRelation in ((LineTool)drawObjectBase2).CouplingRelations)
					{
						if (couplingRelation.amperagePoint != null && ((LineTool)drawObjectBase2).Amperages[couplingRelation.amperagePoint] == amperage3)
						{
							foreach (Branch item in couplingRelation.method_3())
							{
								if (!list_2.Contains(item))
								{
									list_2.Add(item);
								}
								else
								{
									flag = false;
								}
							}
						}
					}
					if (flag && this.method_9(list_2, drawObjectBase2, drawObjectBase_3))
					{
						return true;
					}
				}
			}
			return false;
		}

		private List<Amperage> list_0;

		private DrawObjectBase drawObjectBase_0;

		private DrawObjectBase drawObjectBase_1;

		private List<Amperage> list_1;

		public AmperageProperties amperageProperties;
	}
}
