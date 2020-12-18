using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
/// <summary>
/// Выбор аварийного документа (основание)
/// </summary>
internal partial class FormSelectDamage : FormBase
{
    //internal int TypeDamage
    //{
    //    get
    //    {
    //        return Convert.ToInt32(((DataRowView)this.bsDamage.Current).Row["TypeDoc"]);
    //    }
    //}
    internal int? GetIdDocument()
	{
		if (this.bsDamage.Current != null)
		{
			return new int?(Convert.ToInt32(((DataRowView)this.bsDamage.Current).Row["id"]));
		}
		return null;
	}

	internal FormSelectDamage()
	{
		this.InitializeComponent();
		this.FillDataFilter();
		this.toolStrip.Items.Insert(1, new ToolStripControlHost(this.dateBeg));
		this.toolStrip.Items.Insert(3, new ToolStripControlHost(this.dateEnd));
	}
    /// <summary>
    /// заполнить даты фильтров
    /// </summary>
	private void FillDataFilter()
	{
		this.dateBeg = new DateTimePicker();
		this.dateBeg.Value = new DateTime(DateTime.Now.Year, 1, 1);
		this.dateEnd = new DateTimePicker();
		this.dateEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddMilliseconds(-1.0);
	}

	private void FormSelectDamage_Load(object sender, EventArgs e)
	{
		this.LoadDamageFilter();
	}

	private void LoadDamageFilter()
	{
        //	base.SelectSqlData(this.dsDamageN.vJ_Damage, true, string.Format(" where dateDoc >= '{0}' and dateDoc <= '{1}' \r\n                and typeDoc = {2} order by dateDoc desc", this.dateBeg.Value.ToString("yyyyMMdd"), this.dateEnd.Value.ToString("yyyyMMdd"), 1402), null, false, 0);
        base.SelectSqlData(this.dsDamageN.vJ_Damage, true, string.Format(" where dateDoc >= '{0}' and dateDoc <= '{1}' \r\n                and typeDoc  in ({2}, {3}) order by dateDoc desc", this.dateBeg.Value.ToString("yyyyMMdd"), this.dateEnd.Value.ToString("yyyyMMdd"), 1402, 1401), null, false, 0);
    }

	private void btnApplyFilter_Click(object sender, EventArgs e)
	{
		this.LoadDamageFilter();
	}

	private void btnResetFilter_Click(object sender, EventArgs e)
	{
		this.FillDataFilter();
		this.LoadDamageFilter();
	}

	private void FormSelectDamage_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK && this.bsDamage.Current == null)
		{
			MessageBox.Show("Не выбран ни один документ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			e.Cancel = true;
			return;
		}
	}

	private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}
	}




}
