using System;
using System.Collections.Generic;

namespace SchemeModelN
{
	public class ElectricPoint : ElectricObject
	{
		public ElectricPoint()
		{
			
			this.Relations = new List<ElectricRelation>();
			
		}

		public List<ElectricRelation> Relations;
	}
}
