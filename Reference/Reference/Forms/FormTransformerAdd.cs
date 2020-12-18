using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Reference.Forms
{
	public partial class FormTransformerAdd : Form
	{
		public FormTransformerAdd()
		{
			
			
			this.InitializeComponent();
		}

		private void FormTransformerAdd_Load(object sender, EventArgs e)
		{
			this.class46_0 = (Class37.Class46)((DataRowView)this.tRTransformerBindingSource.Current).Row;
			this.bool_0 = true;
			if (!this.class46_0.method_0())
			{
				this.textBoxName.Text = this.class46_0.Name;
			}
			if (!this.class46_0.method_2())
			{
				this.textBoxType.Text = this.class46_0.Type;
			}
			if (!this.class46_0.method_4())
			{
				this.numericUpDownPower.Value = this.class46_0.Power;
			}
			if (!this.class46_0.method_5())
			{
				this.numericUpDownHighVoltage.Value = this.class46_0.HighVoltage;
			}
			if (!this.class46_0.method_7())
			{
				this.numericUpDownLoVoltage.Value = this.class46_0.LowVoltage;
			}
			if (!this.class46_0.method_9())
			{
				this.numericUpDownRatedAmperHV.Value = this.class46_0.RatedAmperHV;
			}
			if (!this.class46_0.method_11())
			{
				this.numericUpDownRatedAmperLV.Value = this.class46_0.RatedAmperLV;
			}
			if (!this.class46_0.method_13())
			{
				this.textBoxGroupWindings.Text = this.class46_0.GroupWindings;
			}
			if (!this.class46_0.method_15())
			{
				this.numericUpDownShortCircuitVolt.Value = this.class46_0.ShortCircuitVolt;
			}
			if (!this.class46_0.method_17())
			{
				this.numericUpDownShortCircuitLoss.Value = this.class46_0.ShortCircuitLoss;
			}
			if (!this.class46_0.method_19())
			{
				this.numericUpDownNoLoadLoss.Value = this.class46_0.NoLoadLoss;
			}
			this.bool_0 = false;
		}

		private void numericUpDownPower_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.class46_0.Power = Convert.ToInt32(this.numericUpDownPower.Value);
			}
		}

		private void numericUpDownHighVoltage_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.class46_0.HighVoltage = Convert.ToDecimal(this.numericUpDownHighVoltage.Value);
			}
		}

		private void numericUpDownLoVoltage_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.class46_0.LowVoltage = Convert.ToDecimal(this.numericUpDownLoVoltage.Value);
			}
		}

		private void numericUpDownRatedAmperHV_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.class46_0.RatedAmperHV = Convert.ToDecimal(this.numericUpDownRatedAmperHV.Value);
			}
		}

		private void numericUpDownRatedAmperLV_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.class46_0.RatedAmperLV = Convert.ToDecimal(this.numericUpDownRatedAmperLV.Value);
			}
		}

		private void numericUpDownShortCircuitVolt_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.class46_0.ShortCircuitVolt = Convert.ToDecimal(this.numericUpDownShortCircuitVolt.Value);
			}
		}

		private void numericUpDownShortCircuitLoss_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.class46_0.ShortCircuitLoss = Convert.ToDecimal(this.numericUpDownShortCircuitLoss.Value);
			}
		}

		private void numericUpDownNoLoadLoss_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.class46_0.NoLoadLoss = Convert.ToDecimal(this.numericUpDownNoLoadLoss.Value);
			}
		}

		private void FormTransformerAdd_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (this.class46_0.method_0())
				{
					MessageBox.Show("Поле \"Наименование\" не заполнено");
					e.Cancel = true;
					return;
				}
				if (this.class46_0.method_2())
				{
					MessageBox.Show("Поле \"Тип\" не заполнено");
					e.Cancel = true;
					return;
				}
				if (this.class46_0.method_4())
				{
					MessageBox.Show("Поле \"Мощность\" не заполнено");
					e.Cancel = true;
					return;
				}
				if (this.class46_0.method_5())
				{
					MessageBox.Show("Поле \"Номинальное высшее напряжение\" не заполнено");
					e.Cancel = true;
					return;
				}
				if (this.class46_0.method_7())
				{
					MessageBox.Show("Поле \"Номинальное низшее напряжение\" не заполнено");
					e.Cancel = true;
				}
			}
		}

		private Class37.Class46 class46_0;

		private bool bool_0;
	}
}
