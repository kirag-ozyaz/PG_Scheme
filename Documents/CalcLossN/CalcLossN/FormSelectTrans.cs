using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
/// <summary>
/// Выбор марки трансформатора
/// </summary>
internal partial class FormSelectTrans : FormBase
{
    internal int Id { get; set; }

	internal string MakeupTrans { get; set; }

	internal float? RatedPower { get; set; }

	internal float? NoLoadLoss { get; set; }

	internal float? ShortCircuitLoss { get; set; }

    private float? HightVoltage;
    internal float? GetHightVoltage()
	{
		return this.HightVoltage;
	}
	internal void SetHightVoltage(float? hightVoltage)
	{
		this.HightVoltage = hightVoltage;
	}

	internal FormSelectTrans()
	{
	
		this.InitializeComponent();
	}

	private void FormSelectTrans_Load(object sender, EventArgs e)
	{
		base.SelectSqlData(this.dsCalcN.vR_Transformer, true, "where deleted = 0 order by fullname", null, false, 0);
		this.txtFilter.Select();
		this.txtFilter.Focus();
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		base.Close();
	}

	private void dgvTrans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
		{
			this.SetProperties(this.dgvTrans.Rows[e.RowIndex]);
			base.DialogResult = DialogResult.OK;
			base.Close();
		}
	}

	private void SetProperties(DataGridViewRow row)
	{
		this.Id = Convert.ToInt32(row.Cells[this.idDgvColumn.Name].Value);
		this.MakeupTrans = row.Cells[this.fullNameDgvColumn.Name].Value.ToString();
		if (row.Cells[this.powerDgvColumn.Name].Value == DBNull.Value)
		{
			this.RatedPower = null;
		}
		else
		{
			this.RatedPower = new float?(Convert.ToSingle(row.Cells[this.powerDgvColumn.Name].Value) / 1000f);
		}
		if (row.Cells[this.noLoadLossDgvColumn.Name].Value == DBNull.Value)
		{
			this.NoLoadLoss = null;
		}
		else
		{
			this.NoLoadLoss = new float?(Convert.ToSingle(row.Cells[this.noLoadLossDgvColumn.Name].Value));
		}
		if (row.Cells[this.shortCircuitLossDgvColumn.Name].Value == DBNull.Value)
		{
			this.ShortCircuitLoss = null;
		}
		else
		{
			this.ShortCircuitLoss = new float?(Convert.ToSingle(row.Cells[this.shortCircuitLossDgvColumn.Name].Value));
		}
		if (row.Cells[this.highVoltageDgvVoltage.Name].Value == DBNull.Value)
		{
			this.SetHightVoltage(null);
			return;
		}
		this.SetHightVoltage(new float?(Convert.ToSingle(row.Cells[this.highVoltageDgvVoltage.Name].Value)));
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		if (this.dgvTrans.SelectedRows.Count > 0)
		{
			this.SetProperties(this.dgvTrans.SelectedRows[0]);
			base.DialogResult = DialogResult.OK;
			base.Close();
			return;
		}
		MessageBox.Show("Не выбрана ни одна марка трансформатора");
	}

	private void txtFilter_TextChanged(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.txtFilter.Text))
		{
			this.bindingSourceTransformer.Filter = "";
			return;
		}
		this.bindingSourceTransformer.Filter = "fullName like '%" + this.txtFilter.Text + "%'";
	}

}
