using System;

namespace OfficeLB.Excel
{
	public class Cell : Base
	{
		public string Formula
		{
			get
			{
				return this.GetProperty("Formula", null).ToString();
			}
			set
			{
				this.SetProperty("Formula", new object[]
				{
					value
				});
			}
		}

		public string Name
		{
			get
			{
				return this.GetProperty("Name", null).ToString();
			}
			set
			{
				this.SetProperty("Name", new object[]
				{
					value
				});
			}
		}

		public string Text
		{
			get
			{
				return this.GetProperty("Text", null).ToString();
			}
			set
			{
				this.SetProperty("Text", new object[]
				{
					value
				});
			}
		}

		public object Value
		{
			get
			{
				return this.GetProperty("Value", null);
			}
			set
			{
				this.SetProperty("Value", new object[]
				{
					value
				});
			}
		}

		public Cell()
		{
			
			
		}

		public Cell(object oCell)
		{
			
			base.ctor(oCell);
		}

		public void Clear()
		{
			this.InvokeMethod("Clear", null);
		}

		public void Select()
		{
			this.InvokeMethod("Select", null);
		}
	}
}
