using System;
using System.Windows.Forms;

internal class Class2 : DataGridViewTextBoxCell
{
	public Class2()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
	}

	public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
	{
		base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
		Class1 @class = base.DataGridView.EditingControl as Class1;
		if (base.Value == null)
		{
			@class.Value = (DateTime)this.DefaultNewRowValue;
			return;
		}
		DateTime dateTime = DateTime.Parse(base.Value.ToString());
		if (dateTime == new DateTime(1, 1, 1, 0, 0, 0))
		{
			@class.Value = (DateTime)this.DefaultNewRowValue;
			return;
		}
		@class.Value = dateTime;
	}

	public override Type EditType
	{
		get
		{
			return typeof(Class1);
		}
	}

	public override Type ValueType
	{
		get
		{
			return typeof(DateTime);
		}
	}

	public override object DefaultNewRowValue
	{
		get
		{
			return DateTime.Now;
		}
	}
}
