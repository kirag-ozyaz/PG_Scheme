using System;
using System.Linq;
using System.Runtime.CompilerServices;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.ElectricModel.Calculations;

namespace SchemeCtrl2.ElectricModel
{
	public class ElectricBus : ElectricObject
	{
		public eTypeShinaTool TypeBus { get; set; }

		public bool OnAmperage
		{
			get
			{
				return ((ElectricSubstation)base.Parent).TypeSubstation == eTypeRectangleTool.CP && this.bool_0;
			}
			set
			{
				if (((ElectricSubstation)base.Parent).TypeSubstation == eTypeRectangleTool.CP && this.bool_0 != value)
				{
					this.bool_0 = value;
					if (!this.bool_0)
					{
						this.amperage_0.OffAmperage();
						return;
					}
					this.amperage_0 = new Amperage(this, this, new AmperageProperties
					{
						power = 0,
						amperage = 0,
						voltage = this.GetVoltage()
					}, null);
					this.RecalcAmperage();
				}
			}
		}

		public virtual Amperage Amperage
		{
			get
			{
				if (base.Parent == null || !(base.Parent is ElectricSubstation) || ((ElectricSubstation)base.Parent).TypeSubstation != eTypeRectangleTool.CP)
				{
					return this.amperage_0;
				}
				if (this.bool_0)
				{
					return this.amperage_0;
				}
				return null;
			}
			set
			{
				if (base.Parent != null && ((ElectricSubstation)base.Parent).TypeSubstation != eTypeRectangleTool.CP)
				{
					if (value == null)
					{
						this.amperage_0.OffAmperage();
					}
					this.amperage_0 = value;
					if (this.amperage_0 != null)
					{
						this.RecalcAmperage();
						return;
					}
				}
				else if (base.Parent == null)
				{
					this.amperage_0 = value;
					this.RecalcAmperage();
				}
			}
		}

		internal override void RecalcAmperage()
		{
			foreach (ElectricObject electricObject in this.ChildObjects)
			{
				if (electricObject.GetType() == typeof(ElectricPoint) && ((ElectricPoint)electricObject).Relations.Count > 0)
				{
					this.method_1((ElectricPoint)electricObject);
				}
			}
		}

		public int GetVoltage()
		{
			eTypeShinaTool typeBus = this.TypeBus;
			switch (typeBus)
			{
			case eTypeShinaTool.Shina_04:
				break;
			case eTypeShinaTool.Shina_6:
				return 2;
			default:
				switch (typeBus)
				{
				case eTypeShinaTool.Shina_023:
					break;
				case eTypeShinaTool.Shina_10:
					return 2;
				default:
					return 0;
				}
				break;
			}
			return 1;
		}

		internal void method_1(ElectricPoint electricPoint_0)
		{
			if (electricPoint_0.Relations.Count == 0)
			{
				return;
			}
			if (this.Amperage != null && (this.Amperage.Mediators.Count<Amperage>() == 0 || this.Amperage.Mediators.First<Amperage>().Conductor != electricPoint_0.Relations[0].Parent))
			{
				if (electricPoint_0.Relations[0].Parent is ElectricLine && !((ElectricLine)electricPoint_0.Relations[0].Parent).Amperages.ContainsKey(electricPoint_0))
				{
					Amperage amperage = this.Amperage.PassOn(electricPoint_0.Relations[0].Parent);
					if (amperage != null)
					{
						((ElectricLine)electricPoint_0.Relations[0].Parent).AddAmperage(electricPoint_0, amperage);
						return;
					}
				}
				else if (electricPoint_0.Relations[0].amperagePoint == null)
				{
					if (((ElectricLine)electricPoint_0.Relations[0].Parent).Amperages[electricPoint_0].Mediators == this.Amperage)
					{
						return;
					}
					throw new Exception("короткое замыкание при передаче на другой объект");
				}
			}
		}

		public override string ToString()
		{
			eTypeShinaTool typeBus = this.TypeBus;
			switch (typeBus)
			{
			case eTypeShinaTool.Shina_04:
				return "Ш04 - " + base.Name;
			case eTypeShinaTool.Shina_6:
				return "Ш6 - " + base.Name;
			default:
				switch (typeBus)
				{
				case eTypeShinaTool.Shina_023:
					return "Ш023 - " + base.Name;
				case eTypeShinaTool.Shina_10:
					return "Ш10 - " + base.Name;
				default:
					return base.Name;
				}
				break;
			}
		}

		private Amperage amperage_0;

		private bool bool_0;

		[CompilerGenerated]
		private eTypeShinaTool eTypeShinaTool_0;
	}
}
