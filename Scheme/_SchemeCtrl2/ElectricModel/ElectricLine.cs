using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using SchemeCtrl2.ElectricModel.Calculations;

namespace SchemeCtrl2.ElectricModel
{
	public class ElectricLine : ElectricObject
	{
		public int AmperageCount
		{
			get
			{
				return this.Amperages.Count;
			}
		}

		public List<ElectricRelation> Relations
		{
			get
			{
				return this.relations;
			}
		}

		public void AddAmperage(ElectricPoint amperagePoint, Amperage amperage)
		{
			if (this.Amperages.ContainsKey(amperagePoint))
			{
				using (IEnumerator<Amperage> enumerator = amperage.Mediators.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Amperage amperage2 = enumerator.Current;
						if (!this.Amperages[amperagePoint].Mediators.Contains(amperage2))
						{
							this.Amperages[amperagePoint].AddMediator(amperage2);
							amperage2.NextAmperages.Add(this.Amperages[amperagePoint]);
							amperage2.NextAmperages.Remove(amperage);
						}
					}
					return;
				}
			}
			this.Amperages.Add(amperagePoint, amperage);
			this.RecalcAmperage();
		}

		public bool RemoveAmperage(Amperage amperage)
		{
			foreach (ElectricPoint electricPoint in this.Amperages.Keys)
			{
				if (this.Amperages[electricPoint] == amperage)
				{
					this.Amperages.Remove(electricPoint);
					foreach (ElectricRelation electricRelation in this.Relations)
					{
						if (electricRelation.amperagePoint == electricPoint)
						{
							electricRelation.amperagePoint = null;
						}
					}
					this.RecalcAmperage();
					return true;
				}
			}
			return false;
		}

		internal override void RecalcAmperage()
		{
			int i = 0;
			List<ElectricPoint> list = this.Amperages.Keys.ToList<ElectricPoint>();
			while (i < list.Count)
			{
				ElectricPoint electricPoint_ = list[i++];
				this.method_1(electricPoint_);
			}
		}

		internal void method_1(ElectricPoint electricPoint_0)
		{
			if (electricPoint_0 != null)
			{
				this.method_2(electricPoint_0, null, electricPoint_0);
			}
		}

		private void method_2(ElectricPoint electricPoint_0, ElectricRelation electricRelation_0, ElectricPoint electricPoint_1)
		{
			Func<Amperage, bool> func = null;
			ElectricLine.Class85 @class = new ElectricLine.Class85();
			@class.electricPoint_0 = electricPoint_0;
			@class.electricLine_0 = this;
			Amperage amperage = this.Amperages[electricPoint_1];
			if ((@class.electricPoint_0.Relations.Count == 1 || @class.electricPoint_0.Relations.Count(new Func<ElectricRelation, bool>(this.method_3)) == 1) && electricRelation_0 != null)
			{
				if (@class.electricPoint_0.Relations.Count > 1)
				{
					using (List<ElectricRelation>.Enumerator enumerator = @class.electricPoint_0.Relations.GetEnumerator())
					{
						Func<Amperage, bool> func2 = null;
						ElectricLine.Class86 class2 = new ElectricLine.Class86();
						class2.class85_0 = @class;
						while (enumerator.MoveNext())
						{
							ElectricRelation electricRelation_ = enumerator.Current;
							class2.electricRelation_0 = electricRelation_;
							if (class2.electricRelation_0.Parent != this)
							{
								IEnumerable<Amperage> mediators = amperage.Mediators;
								if (func2 == null)
								{
									func2 = new Func<Amperage, bool>(class2.method_0);
								}
								if (mediators.Count(func2) == 0)
								{
									if (!((ElectricLine)class2.electricRelation_0.Parent).Amperages.ContainsKey(@class.electricPoint_0) && class2.electricRelation_0.amperagePoint == null)
									{
										Amperage amperage2 = amperage.PassOn(class2.electricRelation_0.Parent);
										if (amperage2 != null)
										{
											((ElectricLine)class2.electricRelation_0.Parent).AddAmperage(@class.electricPoint_0, amperage2);
										}
									}
									else if (class2.electricRelation_0.amperagePoint != null && ((ElectricLine)class2.electricRelation_0.Parent).Amperages[class2.electricRelation_0.amperagePoint].Source == amperage.Source && !amperage.PowerSourceConteins(class2.electricRelation_0.Parent))
									{
										Amperage amperage3 = amperage.PassOn(class2.electricRelation_0.Parent);
										if (amperage3 != null)
										{
											((ElectricLine)class2.electricRelation_0.Parent).AddAmperage(@class.electricPoint_0, amperage3);
										}
									}
								}
							}
						}
						goto IL_287;
					}
				}
				if (@class.electricPoint_0.Parent != null && @class.electricPoint_0.Parent.GetType() == typeof(ElectricBus))
				{
					IEnumerable<Amperage> mediators2 = amperage.Mediators;
					if (func == null)
					{
						func = new Func<Amperage, bool>(@class.method_0);
					}
					if (mediators2.Count(func) == 0 && ((ElectricBus)@class.electricPoint_0.Parent).Amperage == null)
					{
						Amperage amperage4 = amperage.PassOn(@class.electricPoint_0.Parent);
						if (amperage4 != null)
						{
							((ElectricBus)@class.electricPoint_0.Parent).Amperage = amperage4;
						}
					}
				}
			}
			IL_287:
			using (List<ElectricRelation>.Enumerator enumerator2 = @class.electricPoint_0.Relations.GetEnumerator())
			{
				Func<Amperage, bool> func3 = null;
				ElectricLine.Class87 class3 = new ElectricLine.Class87();
				class3.class85_0 = @class;
				while (enumerator2.MoveNext())
				{
					ElectricRelation electricRelation_2 = enumerator2.Current;
					class3.electricRelation_0 = electricRelation_2;
					if (class3.electricRelation_0.Parent == this)
					{
						IEnumerable<Amperage> mediators3 = amperage.Mediators;
						if (func3 == null)
						{
							func3 = new Func<Amperage, bool>(class3.method_0);
						}
						if (mediators3.Count(func3) == 0 && class3.electricRelation_0 != electricRelation_0)
						{
							ElectricPoint electricPoint = (@class.electricPoint_0 == class3.electricRelation_0.source) ? class3.electricRelation_0.dest : class3.electricRelation_0.source;
							if (this.Amperages.ContainsKey(electricPoint) && class3.electricRelation_0.amperagePoint == electricPoint && class3.electricRelation_0.On)
							{
								if (this.Amperages[electricPoint].Source == amperage.Source)
								{
									this.method_2(electricPoint, class3.electricRelation_0, electricPoint_1);
								}
							}
							else if (class3.electricRelation_0.amperagePoint == null)
							{
								class3.electricRelation_0.amperagePoint = electricPoint_1;
								if (class3.electricRelation_0.On)
								{
									this.method_2(electricPoint, class3.electricRelation_0, electricPoint_1);
								}
							}
							else if (class3.electricRelation_0.On && class3.electricRelation_0.amperagePoint == electricPoint_1)
							{
								this.method_2(electricPoint, class3.electricRelation_0, electricPoint_1);
							}
						}
					}
				}
			}
		}

		public bool IsCell()
		{
			List<ElectricRelation> list = this.Relations;
			if (ElectricLine.predicate_0 == null)
			{
				ElectricLine.predicate_0 = new Predicate<ElectricRelation>(ElectricLine.smethod_0);
			}
			return list.Exists(ElectricLine.predicate_0);
		}

		public IEnumerable<ElectricPoint> Ends
		{
			get
			{
				Func<ElectricRelation, bool> func = null;
				Func<ElectricRelation, bool> func2 = null;
				List<ElectricPoint> list = new List<ElectricPoint>();
				foreach (ElectricRelation electricRelation in this.Relations)
				{
					IEnumerable<ElectricRelation> source = electricRelation.source.Relations;
					if (func == null)
					{
						func = new Func<ElectricRelation, bool>(this.method_4);
					}
					if (source.Where(func).Count<ElectricRelation>() == 1)
					{
						list.Add(electricRelation.source);
					}
					IEnumerable<ElectricRelation> source2 = electricRelation.dest.Relations;
					if (func2 == null)
					{
						func2 = new Func<ElectricRelation, bool>(this.method_5);
					}
					if (source2.Where(func2).Count<ElectricRelation>() == 1)
					{
						list.Add(electricRelation.dest);
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
					IEnumerable<ElectricRelation> source = electricPoint.Relations;
					if (ElectricLine.func_0 == null)
					{
						ElectricLine.func_0 = new Func<ElectricRelation, bool>(ElectricLine.smethod_1);
					}
					if (source.Count(ElectricLine.func_0) > 0)
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
				foreach (ElectricObject electricObject2 in list)
				{
					if (electricObject2 != electricObject)
					{
						return null;
					}
				}
				return electricObject;
			}
			return null;
		}

		public bool IsRelationOff()
		{
			IEnumerable<ElectricRelation> source = this.relations;
			if (ElectricLine.func_1 == null)
			{
				ElectricLine.func_1 = new Func<ElectricRelation, bool>(ElectricLine.smethod_2);
			}
			return source.Count(ElectricLine.func_1) > 0;
		}

		public bool getRelationWay(ElectricPoint electricPoint_0, ElectricPoint destination, ElectricRelation oldRelation, List<ElectricRelation> crList)
		{
			bool flag = false;
			foreach (ElectricRelation electricRelation in electricPoint_0.Relations)
			{
				if (electricRelation != oldRelation && electricRelation.Parent == this)
				{
					ElectricPoint electricPoint = (electricRelation.source == electricPoint_0) ? electricRelation.dest : electricRelation.source;
					if (electricPoint == destination)
					{
						flag = true;
					}
					else if (this.getRelationWay(electricPoint, destination, electricRelation, crList))
					{
						flag = true;
					}
					if (flag)
					{
						crList.Add(electricRelation);
						break;
					}
				}
			}
			return flag;
		}

		[CompilerGenerated]
		private bool method_3(ElectricRelation electricRelation_0)
		{
			return electricRelation_0.Parent == this;
		}

		[CompilerGenerated]
		private static bool smethod_0(ElectricRelation electricRelation_0)
		{
			return (electricRelation_0.dest.Parent != null && electricRelation_0.dest.Parent is ElectricBus) || (electricRelation_0.source.Parent != null && electricRelation_0.source.Parent is ElectricBus);
		}

		[CompilerGenerated]
		private bool method_4(ElectricRelation electricRelation_0)
		{
			return electricRelation_0.Parent == this;
		}

		[CompilerGenerated]
		private bool method_5(ElectricRelation electricRelation_0)
		{
			return electricRelation_0.Parent == this;
		}

		[CompilerGenerated]
		private static bool smethod_1(ElectricRelation electricRelation_0)
		{
			return ((ElectricLine)electricRelation_0.Parent).IsCell();
		}

		[CompilerGenerated]
		private static bool smethod_2(ElectricRelation electricRelation_0)
		{
			return !electricRelation_0.On;
		}

		public Dictionary<ElectricPoint, Amperage> Amperages = new Dictionary<ElectricPoint, Amperage>();

		public List<ElectricRelation> relations = new List<ElectricRelation>();

		[CompilerGenerated]
		private static Predicate<ElectricRelation> predicate_0;

		[CompilerGenerated]
		private static Func<ElectricRelation, bool> func_0;

		[CompilerGenerated]
		private static Func<ElectricRelation, bool> func_1;

		[CompilerGenerated]
		private sealed class Class85
		{
			public bool method_0(Amperage amperage_0)
			{
				return amperage_0.Conductor == this.electricPoint_0.Parent;
			}

			public ElectricLine electricLine_0;

			public ElectricPoint electricPoint_0;
		}

		[CompilerGenerated]
		private sealed class Class86
		{
			public bool method_0(Amperage amperage_0)
			{
				return amperage_0.Conductor == this.electricRelation_0.Parent;
			}

			public ElectricLine.Class85 class85_0;

			public ElectricRelation electricRelation_0;
		}

		[CompilerGenerated]
		private sealed class Class87
		{
			public bool method_0(Amperage amperage_0)
			{
				return amperage_0.Conductor == this.electricRelation_0.Parent;
			}

			public ElectricLine.Class85 class85_0;

			public ElectricRelation electricRelation_0;
		}
	}
}
