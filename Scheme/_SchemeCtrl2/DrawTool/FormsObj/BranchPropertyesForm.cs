using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class BranchPropertyesForm : Form
	{
		public BranchPropertyesForm(Branch branch)
		{
			this.InitializeComponent();
			this.branch_0 = branch;
			this.cabelLineRadioButton.Checked = (this.branch_0.Type == BranchType.CabelLine);
			this.airLineRadioButton.Checked = (this.branch_0.Type == BranchType.AirLine);
			this.radioButtonAirLineProtected.Checked = (this.branch_0.Type == BranchType.AirLineProtected);
		}

		private void BranchPropertyesForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (this.airLineRadioButton.Checked)
				{
					this.branch_0.Type = BranchType.AirLine;
					return;
				}
				if (this.radioButtonAirLineProtected.Checked)
				{
					this.branch_0.Type = BranchType.AirLineProtected;
					return;
				}
				this.branch_0.Type = BranchType.CabelLine;
			}
		}

		private Branch branch_0;
	}
}
