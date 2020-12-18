using System;
using System.Data;
using System.Drawing;

namespace SchemeCtrl2.DrawTool
{
	public class LinearDisconnectorWaxworkTool : LinearDisconnectorTool
	{
		public LinearDisconnectorWaxworkTool()
		{
			
			
			this.Text = "РЛ (муляж)";
		}

		public LinearDisconnectorWaxworkTool(Branch branch)
		{
			
			base..ctor(branch);
			this.Text = "РЛ (муляж)";
		}

		public LinearDisconnectorWaxworkTool(DataRow r, Branch branch)
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
				return TypeSwitch.LinearDisconnectorToolWaxwork;
			}
		}
	}
}
