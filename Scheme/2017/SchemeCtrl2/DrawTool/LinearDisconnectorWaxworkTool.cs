using System;
using System.Data;
using System.Drawing;

namespace SchemeCtrl2.DrawTool
{
	public class LinearDisconnectorWaxworkTool : LinearDisconnectorTool
	{
		public LinearDisconnectorWaxworkTool()
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.Text = "РЛ (муляж)";
		}

		public LinearDisconnectorWaxworkTool(Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(branch);
			this.Text = "РЛ (муляж)";
		}

		public LinearDisconnectorWaxworkTool(DataRow r, Branch branch)
		{
			Class90.TDroV38zslI2T();
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
