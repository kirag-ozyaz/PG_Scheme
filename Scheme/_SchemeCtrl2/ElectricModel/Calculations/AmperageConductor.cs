using System;
using System.Collections.Generic;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.ElectricModel.Calculations
{
	public interface AmperageConductor
	{
		event AmperageConductorEventHandler AmperageAdd;

		event AmperageConductorEventHandler AmperageRemove;

		IEnumerable<Amperage> Amperages { get; set; }

		Amperage Amperage(PointTool amperageInput);

		PointTool AmperageInput(Amperage amperage);

		IEnumerable<PointTool> AmperageOutput(Amperage amperage);

		void RecalcAmperage();

		void RecalcAmperage(PointTool amperageInput);

		void AddAmperage(PointTool amperageInput, Amperage amperage);

		bool RemoveAmperage(Amperage amperage);
	}
}
