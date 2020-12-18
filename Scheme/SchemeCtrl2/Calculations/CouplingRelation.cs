using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using DataSql;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.Calculations
{
	[TypeConverter(typeof(Class85))]
	public class CouplingRelation : IDisposable
	{
		internal bool Deleted { get; set; }

		internal bool On
		{
			get
			{
				using (List<Branch>.Enumerator enumerator = this.list_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.On)
						{
							return false;
						}
					}
				}
				if (this.Line != null && this.Line.Master != null)
				{
					using (IEnumerator<CouplingRelation> enumerator2 = ((LineTool)this.Line.Master).CouplingRelations.Where(new Func<CouplingRelation, bool>(this.method_8)).GetEnumerator())
					{
						if (enumerator2.MoveNext())
						{
							return enumerator2.Current.On;
						}
					}
				}
				return true;
			}
		}

		internal List<DrawObjectBase> method_0()
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (Branch branch in this.list_0)
			{
				foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
				{
					if (drawObjectBase.GetType() == typeof(GroundingTool) && ((GroundingTool)drawObjectBase).On)
					{
						list.Add(drawObjectBase);
					}
				}
			}
			return list;
		}

		internal PointTool method_1()
		{
			return this.pointTool_0;
		}

		internal PointTool method_2()
		{
			return this.pointTool_1;
		}

		public LineTool Line { get; set; }

		internal List<Branch> method_3()
		{
			return this.list_0;
		}

		internal CouplingRelation(PointTool vertex1, PointTool vertex2)
		{
			
			this.list_0 = new List<Branch>();
			
			this.pointTool_0 = vertex1;
			this.pointTool_1 = vertex2;
			this.pointTool_0.CouplingRelations.method_3(this);
			this.pointTool_1.CouplingRelations.method_3(this);
		}

		private void method_4(CouplingRelation couplingRelation_0, Class87 class87_0)
		{
		}

		internal void method_5(PointTool pointTool_2, PointTool pointTool_3)
		{
			if (pointTool_3.GetType() == typeof(PointTool) && pointTool_3.TypePoint == TypePointTool.Point)
			{
				pointTool_3.TypePoint = TypePointTool.Coupling;
			}
			if (pointTool_2 == this.pointTool_0)
			{
				if (pointTool_3 == this.pointTool_1)
				{
					this.method_7();
					return;
				}
				if (this.pointTool_0.IdBase != 0 && this.pointTool_0.CouplingRelations.Count == 1)
				{
					int idBase = this.pointTool_0.IdBase;
					if (pointTool_3.IdBase == 0)
					{
						this.pointTool_0.IdBase = 0;
						pointTool_3.IdBase = idBase;
					}
				}
				this.pointTool_0.CouplingRelations.method_5(this);
				this.pointTool_0 = pointTool_3;
				this.pointTool_0.CouplingRelations.method_3(this);
			}
			else
			{
				if (pointTool_2 != this.pointTool_1)
				{
					throw new Exception("старая точка не принадлежит связи");
				}
				if (pointTool_3 == this.pointTool_0)
				{
					this.method_7();
					return;
				}
				if (this.pointTool_1.IdBase != 0 && this.pointTool_1.CouplingRelations.Count == 1)
				{
					int idBase2 = this.pointTool_1.IdBase;
					if (pointTool_3.IdBase == 0)
					{
						this.pointTool_1.IdBase = 0;
						pointTool_3.IdBase = idBase2;
					}
				}
				this.pointTool_1.CouplingRelations.method_5(this);
				this.pointTool_1 = pointTool_3;
				this.pointTool_1.CouplingRelations.method_3(this);
			}
			if (pointTool_2.CouplingRelations.Count == 0)
			{
				pointTool_2.TypePoint = TypePointTool.Point;
			}
			pointTool_3.TypePoint = TypePointTool.Coupling;
		}

		private void method_6()
		{
			if (this.Id == 0)
			{
				return;
			}
			if (this.pointTool_0.BranchesCount == 0)
			{
				return;
			}
			if (this.pointTool_0.Branches.First<Branch>().Parent == null)
			{
				return;
			}
			if (this.pointTool_0.Branches.First<Branch>().Parent.Layer == null)
			{
				return;
			}
			if (this.pointTool_0.Branches.First<Branch>().Parent.Layer.Parent == null)
			{
				return;
			}
			if (this.pointTool_0.Branches.First<Branch>().Parent.Layer.Parent.SqlSettings == null)
			{
				return;
			}
			if (!this.pointTool_0.Branches.First<Branch>().Parent.Layer.Parent.UseObjectFromDB)
			{
				return;
			}
			new SqlDataCommand(this.pointTool_0.Branches.First<Branch>().Parent.Layer.Parent.SqlSettings).DeleteSqlDataById(this.pointTool_0.Branches.First<Branch>().Parent.Layer.Parent.dsScheme.tSchm_Relation, this.Id);
			this.Id = 0;
		}

		internal void method_7()
		{
			this.method_6();
			this.pointTool_0.CouplingRelations.method_5(this);
			this.pointTool_1.CouplingRelations.method_5(this);
			while (this.list_0.Count > 0)
			{
				Branch branch = this.list_0[0];
				if (branch.CouplingRelation == this)
				{
					branch.CouplingRelation = null;
				}
			}
			this.list_0.Clear();
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected void Dispose(bool disposing)
		{
			if (!this.caGmKcwmjj)
			{
				if (disposing)
				{
					if (this.list_0 != null)
					{
						while (this.list_0.Count > 0)
						{
							this.list_0[0].Dispose();
							this.list_0.RemoveAt(0);
						}
					}
					this.list_0 = null;
					if (this.pointTool_0 != null)
					{
						this.pointTool_0.Dispose();
					}
					if (this.pointTool_1 != null)
					{
						this.pointTool_1.Dispose();
					}
				}
				this.caGmKcwmjj = true;
			}
		}

		~CouplingRelation()
		{
			this.Dispose(false);
		}

		[CompilerGenerated]
		private bool method_8(CouplingRelation couplingRelation_0)
		{
			return couplingRelation_0.Id == this.Id;
		}

		public int Id;

		private PointTool pointTool_0;

		private PointTool pointTool_1;

		private List<Branch> list_0;

		public PointTool amperagePoint;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private LineTool lineTool_0;

		private bool caGmKcwmjj;
	}
}
