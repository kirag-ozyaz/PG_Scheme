using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Logger;
using SchemeModelN.Calculations;

namespace SchemeModelN
{
    /// <summary>
    /// Описание объекта - Шина
    /// </summary>
	public class ElectricBus : ElectricObject
	{
		public eTypeShinaTool TypeBus { get; set; }

        public bool xOnAmperage
        {
            get
            {
                return ((ElectricSubstation)base.Parent).TypeSubstation == eTypeRectangleTool.CP && this.onAmperage;
            }
            set
            {
                // добавляем центры питания
                if (((ElectricSubstation)base.Parent).TypeSubstation == eTypeRectangleTool.CP && this.onAmperage != value)
                {
                    this.onAmperage = value;
                    if (!this.onAmperage)
                    {
                        this.amperage.OffAmperage();
                    }
                    else
                    {
                        this.amperage = new ElectricAmperage(this, this, new AmperageProperties
                        {
                            Power = 0,
                            Amperages = 0,
                            Voltage = this.GetVoltage()
                        }, null);
                        //this.ReCalcAmperage();
                    }
                }
            }
        }

        public bool OnAmperage
		{
			get
			{
				return ((ElectricSubstation)base.Parent).TypeSubstation == eTypeRectangleTool.CP && this.onAmperage;
			}
			set
			{
                // добавляем центры питания
				if (((ElectricSubstation)base.Parent).TypeSubstation == eTypeRectangleTool.CP && this.onAmperage != value)
				{
					this.onAmperage = value;
                    if (!this.onAmperage)
                    {
                        this.amperage.OffAmperage();
                    }
                    else
                    {
                        this.amperage = new ElectricAmperage(this, this, new AmperageProperties
                        {
                            Power = 0,
                            Amperages = 0,
                            Voltage = this.GetVoltage()
                        }, null);
                        this.ReCalcAmperage();
                    }
				}
			}
		}

		public virtual ElectricAmperage Amperage
		{
			get
			{
				if (base.Parent == null || !(base.Parent is ElectricSubstation) || ((ElectricSubstation)base.Parent).TypeSubstation != eTypeRectangleTool.CP)
				{
					return this.amperage;
				}
				if (this.onAmperage)
				{
					return this.amperage;
				}
				return null;
			}
			set
			{
				if (base.Parent != null && ((ElectricSubstation)base.Parent).TypeSubstation != eTypeRectangleTool.CP)
				{
					this.amperage = value;
					if (this.amperage != null)
					{
						this.ReCalcAmperage();
						return;
					}
				}
				else if (base.Parent == null)
				{
					this.amperage = value;
					this.ReCalcAmperage();
				}
			}
		}

		internal override void ReCalcAmperage()
		{
			foreach (ElectricObject obj in this.ChildObjects)
			{
				if (obj.GetType() == typeof(ElectricPoint) && ((ElectricPoint)obj).Relations.Count > 0)
				{
					this.RecalcAmperageForCell((ElectricPoint)obj);
				}
			}
		}
        /// <summary>
        /// Вернуть уровень напряжения объекта (это не напряжение)
        /// </summary>
        /// <returns></returns>
        public int GetVoltage()
		{

            //  eTypeShinaTool.Shina_023    = 1
            //  eTypeShinaTool.Shina_04     = 1
            //  eTypeShinaTool.Shina_6      = 2
            //  eTypeShinaTool.Shina_10     = 2
            //  eTypeShinaTool.Shina_35     = 3
            //  eTypeShinaTool.Shina_110    = 3


            eTypeShinaTool typeBus = this.TypeBus;
			if (typeBus <= eTypeShinaTool.Shina_023) // 563
			{
				if (typeBus != eTypeShinaTool.Shina_04) // 540
				{
					if (typeBus == eTypeShinaTool.Shina_6) //541
					{
						return 2;
					}
					if (typeBus != eTypeShinaTool.Shina_023) // 563
					{
						return 0;
					}
				}
				return 1;
			}
			if (typeBus != eTypeShinaTool.Shina_10) // 564
			{
				if (typeBus != eTypeShinaTool.Shina_35) // 653
				{
					if (typeBus != eTypeShinaTool.Shina_110)    // 654
					{
						return 0;
					}
				}
				return 3;
			}
			return 2;
		}

		internal void RecalcAmperageForCell(ElectricPoint pt) 
        {
			if (pt.Relations.Count == 0)
			{
				return;
			}
			if (this.Amperage != null && (this.Amperage.Mediators.Count<ElectricAmperage>() == 0 || this.Amperage.Mediators.First<ElectricAmperage>().Conductor != pt.Relations[0].Parent))
			{
				if (pt.Relations[0].Parent is ElectricLine && !((ElectricLine)pt.Relations[0].Parent).Amperages.ContainsKey(pt))
				{
                    //Log.Write(LogLevel.Info, "SchemeModelN", "ElectricBus", "RecalcAmperageForCell", string.Format("ElectricLine: ", new object[] { ((ElectricLine)(pt.Relations[0].Parent)).Id }), null);

                    ElectricAmperage electricAmperage = this.Amperage.PassOn(pt.Relations[0].Parent);
					if (electricAmperage != null)
					{
						((ElectricLine)pt.Relations[0].Parent).AddAmperage(pt, electricAmperage);
						return;
					}
				}
				else if (pt.Relations[0].amperagePoint == null && ((ElectricLine)pt.Relations[0].Parent).Amperages[pt].Mediators != this.Amperage)
				{
					throw new Exception("короткое замыкание при передаче на другой объект");
				}
			}
		}

        public  string ToString(bool isFlag)
        {
            string result = base.Name;
            if (isFlag)
            {
                switch (base.Name)
                {
                    case "1": result = "I"; break;
                    case "2": result = "II"; break;
                    case "3": result = "III"; break;
                    case "4": result = "IV"; break;
                    case "5": result = "V"; break;
                    case "6": result = "VI"; break;
                    case "7": result = "VII"; break;
                    case "8": result = "VIII"; break;
                    case "9": result = "IX"; break;
                    case "10": result = "X"; break;
                    default:
                        break;
                }
                return result + " с.ш.";
            }
            else { result = this.ToString(); }

            return result;
        }

        public override string ToString()
		{
			eTypeShinaTool typeBus = this.TypeBus;
			//if (typeBus <= eTypeShinaTool.Shina_6)
			//{
				if (typeBus == eTypeShinaTool.Shina_04)
				{
					return "Ш04 - " + base.Name;
				}
				if (typeBus == eTypeShinaTool.Shina_6)
				{
					return "Ш6 - " + base.Name;
				}
			//}
			//else
			//{
				if (typeBus == eTypeShinaTool.Shina_023)
				{
					return "Ш023 - " + base.Name;
				}
				if (typeBus == eTypeShinaTool.Shina_10)
				{
					return "Ш10 - " + base.Name;
				}
            if (typeBus == eTypeShinaTool.Shina_110)
            {
                return "Ш110 - " + base.Name;
            }
            //}
            return base.Name;
		}

		public ElectricBus()
		{
			
			
		}

		private ElectricAmperage amperage;

		private bool onAmperage;
    }
}
