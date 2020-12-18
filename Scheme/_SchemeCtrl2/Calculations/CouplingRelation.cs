using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using DataSql;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.Calculations
{
	[TypeConverter(typeof(CouplingRelationConverter))]
	public class CouplingRelation : IDisposable
	{
		public bool Deleted { get; set; }

		public bool On
		{
			get
			{
				Func<CouplingRelation, bool> func = null;
				foreach (Branch branch in this.list_0)
				{
					if (!branch.On)
					{
						return false;
					}
				}
				if (this.Line != null && this.Line.Master != null)
				{
					IEnumerable<CouplingRelation> couplingRelations = ((LineTool)this.Line.Master).CouplingRelations;
					if (func == null)
					{
						func = new Func<CouplingRelation, bool>(this.method_1);
					}
					using (IEnumerator<CouplingRelation> enumerator2 = couplingRelations.Where(func).GetEnumerator())
					{
						if (enumerator2.MoveNext())
						{
							CouplingRelation couplingRelation = enumerator2.Current;
							return couplingRelation.On;
						}
					}
				}
				return true;
			}
		}

		public List<DrawObjectBase> GetNoise()
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

		public PointTool Vertex1
		{
			get
			{
				return this.pointTool_0;
			}
		}

		public PointTool Vertex2
		{
			get
			{
				return this.pointTool_1;
			}
		}

		public LineTool Line { get; set; }

		public List<Branch> Branches
		{
			get
			{
				return this.list_0;
			}
		}

		public CouplingRelation(PointTool vertex1, PointTool vertex2)
		{
			this.pointTool_0 = vertex1;
			this.pointTool_1 = vertex2;
			this.pointTool_0.CouplingRelations.Add(this);
			this.pointTool_1.CouplingRelations.Add(this);
		}

		private void method_0(CouplingRelation couplingRelation_0, CouplingRelationChangeEventArgs couplingRelationChangeEventArgs_0)
		{
		}

		public void ChangeCoupling(PointTool oldp, PointTool newp)
		{
			if (newp.GetType() == typeof(PointTool) && newp.TypePoint == TypePointTool.Point)
			{
				newp.TypePoint = TypePointTool.Coupling;
			}
			if (oldp == this.pointTool_0)
			{
				if (newp == this.pointTool_1)
				{
					this.RemoveRelation();
					return;
				}
				if (this.pointTool_0.IdBase != 0 && this.pointTool_0.CouplingRelations.Count == 1)
				{
					int idBase = this.pointTool_0.IdBase;
					if (newp.IdBase == 0)
					{
						this.pointTool_0.IdBase = 0;
						newp.IdBase = idBase;
					}
				}
				this.pointTool_0.CouplingRelations.Remove(this);
				this.pointTool_0 = newp;
				this.pointTool_0.CouplingRelations.Add(this);
			}
			else
			{
				if (oldp != this.pointTool_1)
				{
					throw new Exception("старая точка не принадлежит связи");
				}
				if (newp == this.pointTool_0)
				{
					this.RemoveRelation();
					return;
				}
				if (this.pointTool_1.IdBase != 0 && this.pointTool_1.CouplingRelations.Count == 1)
				{
					int idBase2 = this.pointTool_1.IdBase;
					if (newp.IdBase == 0)
					{
						this.pointTool_1.IdBase = 0;
						newp.IdBase = idBase2;
					}
				}
				this.pointTool_1.CouplingRelations.Remove(this);
				this.pointTool_1 = newp;
				this.pointTool_1.CouplingRelations.Add(this);
			}
			if (oldp.CouplingRelations.Count == 0)
			{
				oldp.TypePoint = TypePointTool.Point;
			}
			newp.TypePoint = TypePointTool.Coupling;
		}

		protected void RemoveFromBase()
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
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.pointTool_0.Branches.First<Branch>().Parent.Layer.Parent.SqlSettings);
			sqlDataCommand.DeleteSqlDataById(this.pointTool_0.Branches.First<Branch>().Parent.Layer.Parent.dataSetScheme_0.tSchm_Relation, this.Id);
			this.Id = 0;
		}

		public void RemoveRelation()
		{
			this.RemoveFromBase();
			this.pointTool_0.CouplingRelations.Remove(this);
			this.pointTool_1.CouplingRelations.Remove(this);
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
			if (!this.bool_0)
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
				this.bool_0 = true;
			}
		}

		~CouplingRelation()
		{
			this.Dispose(false);
		}

		[CompilerGenerated]
		private bool method_1(CouplingRelation couplingRelation_0)
		{
			return couplingRelation_0.Id == this.Id;
		}

		public int Id;

		private PointTool pointTool_0;

		private PointTool pointTool_1;

		private List<Branch> list_0 = new List<Branch>();

		public PointTool amperagePoint;

		private bool bool_0;

		[CompilerGenerated]
		private bool bool_1;

		[CompilerGenerated]
		private LineTool lineTool_0;
	}
}
