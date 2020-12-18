using System;
using System.ComponentModel;

namespace OfficeLB.Excel
{
	public class Columns : Base
	{
		public double ColumnWidth
		{
			get
			{
				return (double)this.GetProperty("ColumnWhidth", null);
			}
			set
			{
				this.SetProperty("ColumnWidth", new object[]
				{
					value
				});
			}
		}

		public bool Group
		{
			set
			{
				if (value)
				{
					this.InvokeMethod("Group", null);
					return;
				}
				this.InvokeMethod("Ungroup", null);
			}
		}

		[Description("Получает количество элементов в наборе (диапазоне).")]
		public int Count
		{
			get
			{
				return (int)this.GetProperty("Count", null);
			}
		}

		public Columns()
		{
			
			
		}

		public Columns(object oColumns)
		{
			
			base.ctor(oColumns);
		}

		public void Delete()
		{
			this.InvokeMethod("Delete", null);
		}
	}
}
