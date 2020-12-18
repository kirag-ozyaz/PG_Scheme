using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;

internal partial class FormSelectCable : FormBase
{
	internal int Id { get; set; }
    private string MakeupCable;

	internal string GetMakeupCable()
	{
		return this.MakeupCable;
	}

	internal void SetMakeupCable(string makeupCable)
	{
		this.MakeupCable = makeupCable;
	}

	internal float? Resistance { get; set; }

	internal float? VoltageValue { get; set; }

	internal float? CrossSection { get; private set; }

	internal FormSelectCable()
	{
		
		this.InitializeComponent();
	}

	private void FormSelectCable_Load(object sender, EventArgs e)
	{
		base.SelectSqlData(this.dsCalcN.vR_Cable, true, "where deleted = 0 order by fullname", null, false, 0);
		this.txtFilter.Select();
		this.txtFilter.Focus();
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		base.Close();
	}

	private void dgvCable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
		{
			this.Id = Convert.ToInt32(this.dgvCable[this.idDgvColumn.Name, e.RowIndex].Value);
			this.SetMakeupCable(this.dgvCable[this.fullNameDgvColumn.Name, e.RowIndex].Value.ToString());
			if (this.dgvCable[this.resistanceDgvColumn.Name, e.RowIndex].Value == DBNull.Value)
			{
				this.Resistance = null;
			}
			else
			{
				this.Resistance = new float?(Convert.ToSingle(this.dgvCable[this.resistanceDgvColumn.Name, e.RowIndex].Value));
			}
			if (this.dgvCable[this.voltageValueDgvColumn.Name, e.RowIndex].Value == DBNull.Value)
			{
				this.VoltageValue = null;
			}
			else
			{
				this.VoltageValue = new float?(Convert.ToSingle(this.dgvCable[this.voltageValueDgvColumn.Name, e.RowIndex].Value));
			}
			if (this.dgvCable.SelectedRows[0].Cells[this.crossSectionDgvColumn.Name].Value == DBNull.Value)
			{
				this.CrossSection = null;
			}
			else
			{
				this.CrossSection = new float?(Convert.ToSingle(this.dgvCable.SelectedRows[0].Cells[this.crossSectionDgvColumn.Name].Value));
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		if (this.dgvCable.SelectedRows.Count > 0)
		{
			this.Id = Convert.ToInt32(this.dgvCable.SelectedRows[0].Cells[this.idDgvColumn.Name].Value);
			this.SetMakeupCable(this.dgvCable.SelectedRows[0].Cells[this.fullNameDgvColumn.Name].Value.ToString());
			if (this.dgvCable.SelectedRows[0].Cells[this.resistanceDgvColumn.Name].Value == DBNull.Value)
			{
				this.Resistance = null;
			}
			else
			{
				this.Resistance = new float?(Convert.ToSingle(this.dgvCable.SelectedRows[0].Cells[this.resistanceDgvColumn.Name].Value));
			}
			if (this.dgvCable.SelectedRows[0].Cells[this.voltageValueDgvColumn.Name].Value == DBNull.Value)
			{
				this.VoltageValue = null;
			}
			else
			{
				this.VoltageValue = new float?(Convert.ToSingle(this.dgvCable.SelectedRows[0].Cells[this.voltageValueDgvColumn.Name].Value));
			}
			if (this.dgvCable.SelectedRows[0].Cells[this.crossSectionDgvColumn.Name].Value == DBNull.Value)
			{
				this.CrossSection = null;
			}
			else
			{
				this.CrossSection = new float?(Convert.ToSingle(this.dgvCable.SelectedRows[0].Cells[this.crossSectionDgvColumn.Name].Value));
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
			return;
		}
		MessageBox.Show("Не выбрана ни одна марка кабеля");
	}

	private void txtFilter_TextChanged(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.txtFilter.Text))
		{
			this.bindingSourceCable.Filter = "";
			return;
		}
		this.bindingSourceCable.Filter = "fullName like '%" + this.txtFilter.Text + "%'";
	}

	
}
