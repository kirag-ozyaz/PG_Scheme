using System;
using System.Data;
using System.Drawing;

namespace SchemeCtrl2.DrawTool
{
	public class LoadSwitchWaxworkTool : LoadSwitchTool
	{
		public LoadSwitchWaxworkTool()
		{
			
			
			this.Text = "ВН (муляж)";
		}

		public LoadSwitchWaxworkTool(Branch branch)
		{
			
			base..ctor(branch);
			this.Text = "ВН (муляж)";
		}

		public LoadSwitchWaxworkTool(DataRow r, Branch branch)
		{
			
			base..ctor(r, branch);
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
