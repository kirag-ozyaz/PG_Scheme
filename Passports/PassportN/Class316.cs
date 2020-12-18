using System;
using System.ComponentModel;
using System.Windows.Forms;

internal class Class316
{
	[Description("Нумерация в заголовках строк")]
	internal static void smethod_0(DataGridView dataGridView_0, DataGridViewRowPrePaintEventArgs dataGridViewRowPrePaintEventArgs_0)
	{
		DataGridView dataGridView = (DataGridView)dataGridView_0;
		if (dataGridView.Rows[dataGridViewRowPrePaintEventArgs_0.RowIndex].IsNewRow)
		{
			return;
		}
		object value = dataGridView.Rows[dataGridViewRowPrePaintEventArgs_0.RowIndex].HeaderCell.Value;
		if (value == null || !value.Equals((dataGridViewRowPrePaintEventArgs_0.RowIndex + 1).ToString()))
		{
			dataGridView.Rows[dataGridViewRowPrePaintEventArgs_0.RowIndex].HeaderCell.Value = (dataGridViewRowPrePaintEventArgs_0.RowIndex + 1).ToString();
		}
	}

	internal static void smethod_1(DataGridView dataGridView_0, EventArgs eventArgs_0)
	{
		DataGridView dataGridView = (DataGridView)dataGridView_0;
		if (dataGridView.IsCurrentCellDirty)
		{
			dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}
	}

	public Class316()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
	}
}
