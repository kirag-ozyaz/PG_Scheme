using System;
using System.Data;
using System.Drawing;

namespace SchemeCtrl2.DrawTool
{
	public class LoadSwitchWaxworkTool : LoadSwitchTool
	{
		public LoadSwitchWaxworkTool()
		{
		}

		public LoadSwitchWaxworkTool(Branch branch) : base(branch)
		{
		}

		public LoadSwitchWaxworkTool(DataRow dataRow_0, Branch branch) : base(dataRow_0, branch)
		{
		}

		public override bool On
		{
			get
			{
				return true;
			}
		}

		public override Color Color
		{
			get
			{
				return Color.Gray;
			}
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.LoadSwitchToolWaxwork;
			}
		}
	}
}
