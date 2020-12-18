using System;
using System.Windows.Forms;

internal class Class1 : DateTimePicker, IDataGridViewEditingControl
{
	public Class1()
	{
		base.Format = DateTimePickerFormat.Short;
	}

	public object EditingControlFormattedValue
	{
		get
		{
			return base.Value.ToShortDateString();
		}
		set
		{
			if (value is string)
			{
				try
				{
					base.Value = DateTime.Parse((string)value);
				}
				catch
				{
					base.Value = DateTime.Now;
				}
			}
		}
	}

	public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
	{
		return this.EditingControlFormattedValue;
	}

	public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
	{
		this.Font = dataGridViewCellStyle.Font;
		base.CalendarForeColor = dataGridViewCellStyle.ForeColor;
		base.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
	}

	public int EditingControlRowIndex
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
	{
		switch (keyData & Keys.KeyCode)
		{
		case Keys.Prior:
		case Keys.Next:
		case Keys.End:
		case Keys.Home:
		case Keys.Left:
		case Keys.Up:
		case Keys.Right:
		case Keys.Down:
			return true;
		default:
			return !dataGridViewWantsInputKey;
		}
	}

	public void PrepareEditingControlForEdit(bool selectAll)
	{
	}

	public bool RepositionEditingControlOnValueChange
	{
		get
		{
			return false;
		}
	}

	public DataGridView EditingControlDataGridView
	{
		get
		{
			return this.dataGridView_0;
		}
		set
		{
			this.dataGridView_0 = value;
		}
	}

	public bool EditingControlValueChanged
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	public Cursor EditingPanelCursor
	{
		get
		{
			return base.Cursor;
		}
	}

	protected override void OnValueChanged(EventArgs eventargs)
	{
		this.bool_0 = true;
		this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
		base.OnValueChanged(eventargs);
	}

	private DataGridView dataGridView_0;

	private bool bool_0;

	private int int_0;
}
