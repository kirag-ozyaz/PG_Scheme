using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using SchemeModelN.Calculations;

namespace SchemeModelN
{
    /// <summary>
    /// Описание объекта - линия/ячейка подстанции
    /// </summary>
    public class ElectricLine : ElectricObject
    {
        public int AmperageCount
        {
            get
            {
                return this.Amperages.Count;
            }
        }

        public int NextAmperageCount
        {
            get
            {
                int Count = 0;
                foreach (ElectricAmperage electricAmperage in this.Amperages.Values)
                {
                    Count += electricAmperage.NextAmperages().Count;
                }
                return Count;
            }
        }

        public List<ElectricRelation> Relations
        {
            get
            {
                return this.relations;
            }
        }
        private LineToolType typeLine;
        /// <summary>
        /// тип линии
        /// </summary>
        public LineToolType TypeLine
        {
            get
            { return typeLine; }
            set
            {
                typeLine = value;
                //if (this.IsCell() && value.ToString() != String.Empty)
                //{
                //    Voltage = this.ParentModel.GetVoltageObject(value);
                //}
            }
        }
        public string GetVoltage()
        {
            string voltage = String.Empty;
            if (this.IsCell())
                if (this.Ends != null)
                {
                    foreach (var point in this.Ends)
                    {
                        voltage = point.ParentModel.GetVoltageObject(this, false);
                        if (voltage != String.Empty) break;
                    }
                }
            return voltage;

        }

        public void AddAmperage(ElectricPoint pt, ElectricAmperage amperage) // internal
        {
			if (this.Amperages.ContainsKey(pt))
			{
				using (var enumerator = amperage.Mediators.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ElectricAmperage electricAmperage = enumerator.Current;
						if (!this.Amperages[pt].Mediators.Contains(electricAmperage))
						{
							this.Amperages[pt].AddMediator(electricAmperage);
							electricAmperage.NextAmperages().Add(this.Amperages[pt]);
							electricAmperage.NextAmperages().Remove(amperage);
						}
					}
					return;
				}
			}
			this.Amperages.Add(pt, amperage);
			this.ReCalcAmperage();
		}

		internal bool RemoveAmperage(ElectricAmperage electricAmperage)
		{
			foreach (ElectricPoint electricPoint in this.Amperages.Keys)
			{
				if (this.Amperages[electricPoint] == electricAmperage)
				{
					this.Amperages.Remove(electricPoint);
					foreach (ElectricRelation electricRelation in this.Relations)
					{
						if (electricRelation.amperagePoint == electricPoint)
						{
							electricRelation.amperagePoint = null;
						}
					}
					this.ReCalcAmperage();
					return true;
				}
			}
			return false;
		}

		internal override void ReCalcAmperage()
		{
			int i = 0;
			var list = this.Amperages.Keys.ToList<ElectricPoint>();
			while (i < list.Count)
			{
				ElectricPoint electricPoint_ = list[i++];
				this.RecalcAmperageForPoint(electricPoint_);
			}
		}

		internal void RecalcAmperageForPoint(ElectricPoint point)
		{
			if (point != null)
			{
				this.GetAmperageToEnds(point, null, point);
			}
		}

		private void GetAmperageToEnds(ElectricPoint SourcePoint, ElectricRelation glRelation, ElectricPoint DestPoint)
		{
			ElectricAmperage electricAmperage = this.Amperages[DestPoint];
            if ((SourcePoint.Relations.Count == 1 || SourcePoint.Relations.Count(c => c.Parent == this) == 1) && glRelation != null)
                {
                if (SourcePoint.Relations.Count > 1)
                {
                    using (var enumerator = SourcePoint.Relations.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            ElectricRelation couplingRelation = enumerator.Current;
                            if (couplingRelation.Parent != this && electricAmperage.Mediators.Count((ElectricAmperage a) => a.Conductor == couplingRelation.Parent) == 0)
                            {
                                if (!((ElectricLine)couplingRelation.Parent).Amperages.ContainsKey(SourcePoint) && couplingRelation.amperagePoint == null)
                                {
                                    ElectricAmperage electricAmperage2 = electricAmperage.PassOn(couplingRelation.Parent);
                                    if (electricAmperage2 != null)
                                    {
                                        ((ElectricLine)couplingRelation.Parent).AddAmperage(SourcePoint, electricAmperage2);
                                    }
                                }
                                else if (couplingRelation.amperagePoint != null && ((ElectricLine)couplingRelation.Parent).Amperages[couplingRelation.amperagePoint].Source == electricAmperage.Source && !electricAmperage.PowerSourceConteins(couplingRelation.Parent))
                                {
                                    ElectricAmperage electricAmperage3 = electricAmperage.PassOn(couplingRelation.Parent);
                                    if (electricAmperage3 != null)
                                    {
                                        ((ElectricLine)couplingRelation.Parent).AddAmperage(SourcePoint, electricAmperage3);
                                    }
                                }
                            }
                        }
                        //	goto IL_265;
                    }
                }
                else //
                    if (SourcePoint.Parent != null && SourcePoint.Parent.GetType() == typeof(ElectricBus) && electricAmperage.Mediators.Count((ElectricAmperage a) => a.Conductor == SourcePoint.Parent) == 0 && ((ElectricBus)SourcePoint.Parent).Amperage == null)
                    {
                        ElectricAmperage electricAmperage4 = electricAmperage.PassOn(SourcePoint.Parent);
                        if (electricAmperage4 != null)
                        {
                            ((ElectricBus)SourcePoint.Parent).Amperage = electricAmperage4;
                        }
                    }
            }
			//IL_265:
			using (var enumerator = SourcePoint.Relations.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ElectricRelation couplingRelation2 = enumerator.Current;
					if (couplingRelation2.Parent == this && electricAmperage.Mediators.Count((ElectricAmperage a) => a.Conductor == couplingRelation2.Parent) == 0 && couplingRelation2 != glRelation)
					{
						ElectricPoint electricPoint = (SourcePoint == couplingRelation2.SourcePoint) ? couplingRelation2.DestPoint : couplingRelation2.SourcePoint;
						if (this.Amperages.ContainsKey(electricPoint) && couplingRelation2.amperagePoint == electricPoint && couplingRelation2.On)
						{
							if (this.Amperages[electricPoint].Source == electricAmperage.Source)
							{
								this.GetAmperageToEnds(electricPoint, couplingRelation2, DestPoint);
							}
						}
						else if (couplingRelation2.amperagePoint == null)
						{
							couplingRelation2.amperagePoint = DestPoint;
							if (couplingRelation2.On)
							{
								this.GetAmperageToEnds(electricPoint, couplingRelation2, DestPoint);
							}
						}
						else if (couplingRelation2.On && couplingRelation2.amperagePoint == DestPoint)
						{
							this.GetAmperageToEnds(electricPoint, couplingRelation2, DestPoint);
						}
					}
				}
			}
		}

		public bool IsCell()
		{
			return this.Relations.Exists((ElectricRelation obj) => (obj.DestPoint.Parent != null && obj.DestPoint.Parent is ElectricBus) || (obj.SourcePoint.Parent != null && obj.SourcePoint.Parent is ElectricBus));
		}

        /// <summary>
        /// концы линии
        /// </summary>
		public List<ElectricPoint> Ends
		{
			get
			{
				var list = new List<ElectricPoint>();
				foreach (ElectricRelation electricRelation in this.Relations)
				{

                    if (electricRelation.SourcePoint.Relations.Where(w => w.Parent == this).Count<ElectricRelation>() == 1)
                    {
						list.Add(electricRelation.SourcePoint);
					}

                    if (electricRelation.DestPoint.Relations.Where(w => w.Parent == this).Count<ElectricRelation>() == 1)
                    {
                        list.Add(electricRelation.DestPoint);
                    }
				}
				return list;
			}
		}

       

        public override string ToString()
		{
			if (this.IsCell())
			{
				return "яч. " + base.Name;
			}
			return base.ToString();
		}

		public ElectricObject ParRectangle()
		{
			if (this.IsCell())
			{
				return base.Parent;
			}
			List<ElectricObject> list = new List<ElectricObject>();
			foreach (ElectricPoint electricPoint in this.Ends)
			{
				if (electricPoint.Parent != null)
				{
					if (electricPoint.Relations.Count((ElectricRelation o) => ((ElectricLine)o.Parent).IsCell()) > 0)
					{
						list.Add(electricPoint.Parent.Parent);
						continue;
					}
				}
				return null;
			}
			if (list.Count > 1)
			{
				ElectricObject electricObject = list[0];
				using (List<ElectricObject>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current != electricObject)
						{
							return null;
						}
					}
				}
				return electricObject;
			}
			return null;
		}

		public bool IsRelationOff()
		{
			return this.relations.Count((ElectricRelation obj) => !obj.On) > 0;
		}

		public bool getRelationWay(ElectricPoint SourcePoint, ElectricPoint DestPoint, ElectricRelation firstRelation, List<ElectricRelation> crListRelations)
		{
			bool flag = false;
			foreach (ElectricRelation electricRelation in SourcePoint.Relations)
			{
				if (electricRelation != firstRelation && electricRelation.Parent == this)
				{
					ElectricPoint electricPoint = (electricRelation.SourcePoint == SourcePoint) ? electricRelation.DestPoint : electricRelation.SourcePoint;
					if (electricPoint == DestPoint)
					{
						flag = true;
					}
					else if (this.getRelationWay(electricPoint, DestPoint, electricRelation, crListRelations))
					{
						flag = true;
					}
					if (flag)
					{
						crListRelations.Add(electricRelation);
						break;
					}
				}
			}
			return flag;
		}

		public ElectricLine()
		{
			
			this.Amperages = new Dictionary<ElectricPoint, ElectricAmperage>();
			this.relations = new List<ElectricRelation>();
			
		}
        /// <summary>
        /// точки запитки
        /// </summary>
		public Dictionary<ElectricPoint, ElectricAmperage> Amperages;

		private List<ElectricRelation> relations;
    }
}
