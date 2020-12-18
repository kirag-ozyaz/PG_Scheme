using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr;

namespace Reference.Forms
{
	public partial class FormCableAdd : Form
	{
		public FormCableAdd()
		{
			
			
			this.InitializeComponent();
		}

		private void FormCableAdd_Load(object sender, EventArgs e)
		{
			this.class47_0 = (Class37.Class47)((DataRowView)this.tRCableBindingSource.Current).Row;
			if (this.class47_0.RowState == DataRowState.Detached)
			{
				this.Text = "Добавить кабель";
			}
			else if (this.class47_0.RowState == DataRowState.Unchanged)
			{
				this.Text = "Редактировать кабель";
			}
			this.bool_0 = true;
			if (!this.class47_0.method_2())
			{
				this.numericUpDownWires.Value = new decimal?(this.class47_0.Wires);
			}
			else
			{
				this.numericUpDownWires.Value = null;
			}
			if (!this.class47_0.method_6())
			{
				this.yFoyOpHlnE.Value = new decimal?(this.class47_0.WiresAddl);
			}
			else
			{
				this.yFoyOpHlnE.Value = null;
			}
			if (!this.class47_0.method_4())
			{
				this.numericUpDownCrossSection.Value = new decimal?(Convert.ToDecimal(this.class47_0.CrossSection));
			}
			else
			{
				this.numericUpDownCrossSection.Value = null;
			}
			if (!this.class47_0.method_8())
			{
				this.numericUpDownCrossSectionAddl.Value = new decimal?(Convert.ToDecimal(this.class47_0.CrossSectionAddl));
			}
			else
			{
				this.numericUpDownCrossSectionAddl.Value = null;
			}
			if (!this.class47_0.method_9())
			{
				this.numericUpDownWiresLight.Value = new decimal?(this.class47_0.WiresLight);
			}
			else
			{
				this.numericUpDownWiresLight.Value = null;
			}
			if (!this.class47_0.method_11())
			{
				this.numericUpDownCrossSectionLight.Value = new decimal?(Convert.ToDecimal(this.class47_0.CrossSectionLight));
			}
			else
			{
				this.numericUpDownCrossSectionLight.Value = null;
			}
			if (!this.class47_0.method_14())
			{
				this.numericUpDownAmperage.Value = new decimal?(Convert.ToDecimal(this.class47_0.Amperage));
			}
			else
			{
				this.numericUpDownAmperage.Value = null;
			}
			if (!this.class47_0.method_12())
			{
				this.numericUpDownAmperageAir.Value = new decimal?(Convert.ToDecimal(this.class47_0.AmperageAir));
			}
			else
			{
				this.numericUpDownAmperageAir.Value = null;
			}
			if (!this.class47_0.method_16())
			{
				this.numericUpDownResistance.Value = new decimal?(Convert.ToDecimal(this.class47_0.Resistance));
			}
			else
			{
				this.numericUpDownResistance.Value = null;
			}
			if (!this.class47_0.method_18())
			{
				this.numericUpDownResistanceAddl.Value = new decimal?(Convert.ToDecimal(this.class47_0.ResistanceAddl));
			}
			else
			{
				this.numericUpDownResistanceAddl.Value = null;
			}
			this.bool_0 = false;
		}

		private void numericUpDownWires_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				if (this.numericUpDownWires.Value != null)
				{
					this.class47_0.Wires = Convert.ToInt32(this.numericUpDownWires.Value);
					return;
				}
				this.class47_0.method_3();
			}
		}

		private void yFoyOpHlnE_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				if (this.yFoyOpHlnE.Value != null)
				{
					this.class47_0.WiresAddl = Convert.ToInt32(this.yFoyOpHlnE.Value);
					return;
				}
				this.class47_0.method_7();
			}
		}

		private void numericUpDownCrossSection_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.class47_0.CrossSection = (double)Convert.ToSingle(this.numericUpDownCrossSection.Value);
			}
		}

		private void numericUpDownCrossSectionAddl_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				if (this.numericUpDownCrossSectionAddl.Value != null)
				{
					this.class47_0.CrossSectionAddl = (double)Convert.ToSingle(this.numericUpDownCrossSectionAddl.Value);
					return;
				}
				this.class47_0.McuegWbuTyN();
			}
		}

		private void numericUpDownWiresLight_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				if (this.numericUpDownWiresLight.Value != null)
				{
					this.class47_0.WiresLight = Convert.ToInt32(this.numericUpDownWiresLight.Value);
					return;
				}
				this.class47_0.method_10();
			}
		}

		private void numericUpDownCrossSectionLight_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				if (this.numericUpDownCrossSectionLight.Value != null)
				{
					this.class47_0.CrossSectionLight = (double)Convert.ToSingle(this.numericUpDownCrossSectionLight.Value);
					return;
				}
				this.class47_0.DxAegxQpYsB();
			}
		}

		private void numericUpDownAmperage_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				if (this.numericUpDownAmperage.Value != null)
				{
					this.class47_0.Amperage = (double)Convert.ToSingle(this.numericUpDownAmperage.Value);
					return;
				}
				this.class47_0.method_15();
			}
		}

		private void numericUpDownAmperageAir_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				if (this.numericUpDownAmperageAir.Value != null)
				{
					this.class47_0.AmperageAir = (double)Convert.ToSingle(this.numericUpDownAmperageAir.Value);
					return;
				}
				this.class47_0.method_13();
			}
		}

		private void numericUpDownResistance_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				if (this.numericUpDownResistance.Value != null)
				{
					this.class47_0.Resistance = (double)Convert.ToSingle(this.numericUpDownResistance.Value);
					return;
				}
				this.class47_0.method_17();
			}
		}

		private void numericUpDownResistanceAddl_ValueChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				if (this.numericUpDownResistanceAddl.Value != null)
				{
					this.class47_0.ResistanceAddl = (double)Convert.ToSingle(this.numericUpDownResistanceAddl.Value);
					return;
				}
				this.class47_0.DyfegDwgcUp();
			}
		}

		private void FormCableAdd_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (this.class47_0.method_0())
				{
					MessageBox.Show("Поле \"Наименование\" не заполнено");
					e.Cancel = true;
					return;
				}
				if (this.class47_0.method_4())
				{
					MessageBox.Show("Поле \"Сечение\" не заполнено");
					e.Cancel = true;
				}
			}
		}

		private Class37.Class47 class47_0;

		private bool bool_0;

		public class NullableNumericUpDown : NumericUpDown
		{
			public NullableNumericUpDown()
			{
				
				this.bool_0 = true;
				
				base.ValueChanged += this.NullableNumericUpDown_ValueChanged;
				base.TextChanged += this.NullableNumericUpDown_TextChanged;
			}

			[Bindable(true)]
			public new decimal? Value
			{
				get
				{
					return this.nullable_0;
				}
				set
				{
					this.nullable_0 = value;
					if (value != null)
					{
						base.Value = (int)value.Value;
						this.Text = this.Value.ToString();
						return;
					}
					this.Text = "";
				}
			}

			private void NullableNumericUpDown_ValueChanged(object sender, EventArgs e)
			{
				if (this.bool_0)
				{
					this.nullable_0 = new decimal?(base.Value);
				}
			}

			private void NullableNumericUpDown_TextChanged(object sender, EventArgs e)
			{
				if (this.Text == "")
				{
					this.nullable_0 = null;
					this.bool_0 = false;
					this.OnValueChanged(e);
					this.bool_0 = true;
				}
			}

			private decimal? nullable_0;

			private bool bool_0;
		}
	}
}
