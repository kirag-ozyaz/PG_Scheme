using System;

namespace SchemeModelN
{
    /// <summary>
    /// Описание объекта - связей
    /// </summary>
    public class ElectricRelation : ElectricObject
	{
		public ElectricRelation(ElectricPoint source, ElectricPoint dest)
		{
			this.SourcePoint = source;
			this.DestPoint = dest;
			this.SourcePoint.Relations.Add(this);
			this.DestPoint.Relations.Add(this);
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

        public ElectricPoint SourcePoint; // internal

        public ElectricPoint DestPoint; // internal
    }
}
