using System;
using System.Runtime.CompilerServices;

namespace SchemeModelN
{
	public class ElectricSwitch : ElectricObject
	{
		public TypeSwitch TypeSwitch { get; set; }

		public bool On
		{
			get
			{
				return this.on;
			}
			set
			{
				if (this.on == value)
				{
					return;
				}
				this.on = value;
          
                if (base.Parent != null && base.Parent.GetType() == typeof(ElectricRelation) && base.Parent.Parent != null && base.Parent.Parent.GetType() == typeof(ElectricLine))
                {
                    ElectricRelation electricRelation = (ElectricRelation)base.Parent;
                    ElectricLine electricLine = (ElectricLine)base.Parent.Parent;
                    ElectricPoint amperagePoint = electricRelation.amperagePoint;
                    if (amperagePoint == null)
                    {
                        return;
                    }
                    if (!this.on)
                    {
                        electricLine.Amperages[amperagePoint].RemoveNextAmperage();
                    }
                    try
                    {
                        electricLine.RecalcAmperageForPoint(amperagePoint);
                    }
                    catch
                    {
                        this.on = false;
                    }
                }
            }
		}

		//private void method_1() // AddSwitchTool
  //      {
		//	if (base.Parent != null && base.Parent.GetType() == typeof(ElectricRelation) && base.Parent.Parent != null && base.Parent.Parent.GetType() == typeof(ElectricLine))
		//	{
		//		ElectricRelation electricRelation = (ElectricRelation)base.Parent;
		//		ElectricLine electricLine = (ElectricLine)base.Parent.Parent;
		//		ElectricPoint amperagePoint = electricRelation.amperagePoint;
		//		if (amperagePoint == null)
		//		{
		//			return;
		//		}
		//		if (!this.on)
		//		{
		//			electricLine.Amperages[amperagePoint].KillNextAmperage();
		//		}
		//		try
		//		{
		//			electricLine.RecalcAmperageForPoint(amperagePoint);
		//		}
		//		catch
		//		{
		//			this.on = false;
		//		}
		//	}
		//}

		public ElectricSwitch()
		{
			
			this.on = true;
			
		}

		private bool on;
	}
}
