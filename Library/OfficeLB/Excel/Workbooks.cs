using System;

namespace OfficeLB.Excel
{
	public class Workbooks : Base
	{
		public Workbook this[int index]
		{
			get
			{
				return new Workbook(this.GetProperty("Item", new object[]
				{
					index
				}));
			}
		}

		public int Count
		{
			get
			{
				return (int)this.GetProperty("Count", null);
			}
		}

		public Workbooks()
		{
			
			
		}

		public Workbooks(object oWorkbooks)
		{
			
			base.ctor(oWorkbooks);
		}

		public Workbook Add()
		{
			return new Workbook(this.InvokeReturn("Add", null));
		}

		public Workbook Add(string fileName)
		{
			return new Workbook(this.InvokeReturn("Add", new object[]
			{
				fileName
			}));
		}

		public Workbook Open(string fileName)
		{
			return new Workbook(this.InvokeReturn("Open", new object[]
			{
				fileName
			}));
		}

		public Workbook Workbook(int index)
		{
			return new Workbook(this.GetProperty("Item", new object[]
			{
				index
			}));
		}
	}
}
