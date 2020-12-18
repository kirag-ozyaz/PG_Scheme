using System;
using System.Collections.Generic;

namespace SchemeCtrl2.ElectricModel
{
	public class ElectricPoint : ElectricObject
	{
		public List<ElectricRelation> Relations = new List<ElectricRelation>();
	}
}
