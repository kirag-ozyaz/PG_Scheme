using System;
using System.Collections.Generic;
using System.ComponentModel;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.Calculations
{
	[TypeConverter(typeof(AmperageConverter))]
	public class Amperage
	{
		public IEnumerable<Amperage> Mediators
		{
			get
			{
				return this.list_1;
			}
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

		public DrawObjectBase Source
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
			this.amperageProperties = amperageProperties;
			this.Source = source;
			this.drawObjectBase_0 = conductor;
			if (conductor != source)
			{
				this.AddMediator(mediator);
			}
		}

		public Amperage PassOn(DrawObjectBase conductor)
		{
			if (conductor.Master != null)
			{
				return null;
			}
			Amperage amperage = new Amperage(this.Source, conductor, this.amperageProperties, this);
			this.list_0.Add(amperage);
			return amperage;
		}

		public Amperage PassOn(DrawObjectBase conductor, AmperageProperties newProperty)
		{
			if (conductor.Master != null)
			{
				return null;
			}
			Amperage amperage = new Amperage(this.Source, conductor, newProperty, this);
			this.list_0.Add(amperage);
			return amperage;
		}

		public Amperage Clone(DrawObjectBase conductor)
		{
			Amperage amperage = new Amperage(this.Source, conductor, this.amperageProperties, this);
			foreach (Amperage mediator in this.list_1)
			{
				amperage.AddMediator(mediator);
			}
			return amperage;
		}

		public void OffAmperage()
		{
			while (this.list_1.Count > 0)
			{
				this.RemoveMediator(this.list_1[0]);
			}
			if (this.drawObjectBase_0.GetType() == typeof(ShinaTool))
			{
				((ShinaTool)this.drawObjectBase_0).Amperage = null;
				this.KillNextAmperage();
			}
			else
			{
				((LineTool)this.drawObjectBase_0).RemoveAmperage(this);
			}
			this.drawObjectBase_0.RecalcAmperage();
		}

		public void KillNextAmperage()
		{
			while (this.list_0.Count > 0)
			{
				this.list_0[0].RemoveMediator(this);
			}
		}

		public void AddMediator(Amperage mediator)
		{
			this.list_1.Add(mediator);
		}

		public void RemoveMediator(Amperage mediator)
		{
			if (this.list_1.Count == 1 && this.drawObjectBase_0 != this.drawObjectBase_1)
			{
				this.KillNextAmperage();
				if (this.drawObjectBase_0.GetType() == typeof(ShinaTool))
				{
					((ShinaTool)this.drawObjectBase_0).Amperage = null;
				}
				else if (this.drawObjectBase_0.GetType() == typeof(LineTool) || this.drawObjectBase_0.GetType() == typeof(LineCellTool))
				{
					((LineTool)this.drawObjectBase_0).RemoveAmperage(this);
					((LineTool)this.drawObjectBase_0).RecalcAmperage();
				}
			}
			this.list_1.Remove(mediator);
			mediator.list_0.Remove(this);
		}

		public List<DrawObjectBase> GetPowerSource()
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			this.method_0(list, this, null, null);
			return list;
		}

		public bool PowerSourceConteins(DrawObjectBase desiredObject)
		{
			List<DrawObjectBase> list_ = new List<DrawObjectBase>();
			return this.method_1(list_, this.drawObjectBase_0, desiredObject);
		}

		private bool method_0(List<DrawObjectBase> list_2, Amperage amperage_0, Amperage amperage_1, DrawObjectBase drawObjectBase_2)
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
							if (this.method_0(list_2, amperage_2, amperage_0, drawObjectBase_2))
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
				using (List<Amperage>.Enumerator enumerator2 = amperage_0.list_1.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Amperage amperage_3 = enumerator2.Current;
						if (this.method_0(list_2, amperage_3, amperage_0, drawObjectBase_2))
						{
							return true;
						}
					}
					return false;
				}
			}
			foreach (Amperage amperage in ((LineTool)drawObjectBase).Amperages.Values)
			{
				if (amperage == amperage_0)
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
						if (this.method_0(list_2, amperage_4, amperage_0, drawObjectBase_2))
						{
							return true;
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
									IL_B6:
									goto IL_122;
								}
							}
							goto IL_B6;
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
			IL_122:
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
				foreach (Branch item in couplingRelation.Branches)
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
				if (couplingRelation.Branches.Count != 0 && couplingRelation != couplingRelation_0 && couplingRelation.Line == lineTool_0)
				{
					PointTool pointTool = (couplingRelation.Vertex1 == pointTool_0) ? couplingRelation.Vertex2 : couplingRelation.Vertex1;
					if (pointTool == pointTool_1 || Amperage.smethod_0(list_2, lineTool_0, pointTool, couplingRelation, pointTool_1))
					{
						list_2.Add(couplingRelation);
						return true;
					}
				}
			}
			return false;
		}

		private bool method_1(List<DrawObjectBase> list_2, DrawObjectBase drawObjectBase_2, DrawObjectBase drawObjectBase_3)
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
								if (drawObjectBase != amperage.drawObjectBase_1 && this.method_1(list_2, drawObjectBase, drawObjectBase_3))
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
							if (drawObjectBase2 != amperage3.drawObjectBase_1 && drawObjectBase2.Master == null && this.method_1(list_2, drawObjectBase2, drawObjectBase_3))
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
							foreach (Branch item in couplingRelation.Branches)
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
					if (flag && this.method_1(list_2, drawObjectBase2, drawObjectBase_3))
					{
						return true;
					}
				}
			}
			return false;
		}

		private List<Amperage> list_0 = new List<Amperage>();

		private DrawObjectBase drawObjectBase_0;

		private DrawObjectBase drawObjectBase_1;

		private List<Amperage> list_1 = new List<Amperage>();

		public AmperageProperties amperageProperties;
	}
}
