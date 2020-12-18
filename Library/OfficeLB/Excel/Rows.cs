using System;
using System.ComponentModel;

namespace OfficeLB.Excel
{
	public class Rows : Base
	{
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

		public double RowHeight
		{
			get
			{
				return (double)this.GetProperty("RowHeight", null);
			}
			set
			{
				this.SetProperty("RowHeight", new object[]
				{
					value
				});
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

		public Rows()
		{
			
			
		}

		public Rows(object oRows)
		{
			
			base.ctor(oRows);
		}

		public void Delete()
		{
			this.InvokeMethod("Delete", null);
		}
	}
}
