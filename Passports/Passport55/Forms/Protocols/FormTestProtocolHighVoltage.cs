﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Constants;

namespace Passport.Forms.Protocols
{
	public partial class FormTestProtocolHighVoltage : Form
	{
		public FormTestProtocolHighVoltage(int idPassport, StateFormCreate stateForm)
		{
			this.InitializeComponent();
			this.int_0 = idPassport;
			this.stateFormCreate_0 = stateForm;
		}

		private void tbCableB_Leave(object sender, EventArgs e)
		{
			if (this.tbCableB.Text.Length == 0)
			{
				this.ControlsCableBEnabled = false;
				return;
			}
			this.ControlsCableBEnabled = true;
		}

		private bool ControlsCableBEnabled
		{
			set
			{
				this.tbBeginTestB.Enabled = value;
				this.tbAssessmentBeginB.Enabled = value;
				this.tbAssessmentEndB.Enabled = value;
				this.tbCableMakeupB.Enabled = value;
				this.tbEndTestB.Enabled = value;
				this.cbCoincideBA.Enabled = value;
				this.cbCoincideBB.Enabled = value;
				this.cbCoincideBC.Enabled = value;
				this.cbCorrBeginB.Enabled = value;
				this.cbCorrEndB.Enabled = value;
				this.cbIntegrityBA.Enabled = value;
				this.cbIntegrityBB.Enabled = value;
				this.cbIntegrityBC.Enabled = value;
				this.cbBreakdownBA.Enabled = value;
				this.cbBreakdownBB.Enabled = value;
				this.cbBreakdownBC.Enabled = value;
				this.cbIncreaseLeakageCurrentBA.Enabled = value;
				this.cbIncreaseLeakageCurrentBB.Enabled = value;
				this.cbIncreaseLeakageCurrentBC.Enabled = value;
				this.cbDischargeBA.Enabled = value;
				this.cbDischargeBB.Enabled = value;
				this.cbDischargeBC.Enabled = value;
			}
		}

		private int int_0;

		private StateFormCreate stateFormCreate_0;
	}
}