using System;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.ElectricModel
{
	public class ElectricRelation : ElectricObject
	{
		public ElectricRelation(ElectricPoint source, ElectricPoint dest)
		{
			this.source = source;
			this.dest = dest;
			this.source.Relations.Add(this);
			this.dest.Relations.Add(this);
		}

		public bool On
		{
			get
			{
				foreach (ElectricObject electricObject in this.ChildObjects)
				{
					ElectricSwitch electricSwitch = (ElectricSwitch)electricObject;
					if (!electricSwitch.On && electricSwitch.TypeSwitch != TypeSwitch.GroundingTool)
					{
						return false;
					}
				}
				return true;
			}
		}

		public ElectricPoint amperagePoint;

		public ElectricPoint source;

		public ElectricPoint dest;
	}
}
