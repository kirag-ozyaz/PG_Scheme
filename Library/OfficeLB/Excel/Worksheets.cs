using System;

namespace OfficeLB.Excel
{
	public class Worksheets : Base
	{
		public Worksheet this[int index]
		{
			get
			{
				return new Worksheet(this.GetProperty("Item", new object[]
				{
					index
				}));
			}
		}

		public Worksheet this[string name]
		{
			get
			{
				return new Worksheet(this.GetProperty("Item", new object[]
				{
					name
				}));
			}
		}

		public string Application
		{
			get
			{
				return this.GetProperty("Application", null).ToString();
			}
		}

		public int Count
		{
			get
			{
				return (int)this.GetProperty("Count", null);
			}
		}

		public int Creator
		{
			get
			{
				return (int)this.GetProperty("Creator", null);
			}
		}

		public object Parent
		{
			get
			{
				return this.GetProperty("Parent", null);
			}
		}

		public bool Visible
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("Visible", null).ToString());
			}
			set
			{
				this.SetProperty("Visible", new object[]
				{
					value
				});
			}
		}

		public Worksheets()
		{
			
			
		}

		public Worksheets(object oWorksheets)
		{
			
			base.ctor(oWorksheets);
		}

		public Worksheet Worksheet(int index)
		{
			return new Worksheet(this.GetProperty("Item", new object[]
			{
				index
			}));
		}

		public void Add()
		{
			this.InvokeMethod("Add", null);
		}

		public void Add(Worksheet Before, Worksheet After, int Count)
		{
			string methodName = "Add";
			object[] array = new object[4];
			array[0] = Before;
			array[1] = After;
			array[2] = Count;
			this.InvokeMethod(methodName, array);
		}

		public void Delete()
		{
			this.InvokeMethod("Delete", null);
		}

		public void PrintPreview(bool EnableChanges)
		{
			this.InvokeMethod("PrintPreview", new object[]
			{
				EnableChanges
			});
		}

		public void Select(bool Replace)
		{
			this.InvokeMethod("Select", new object[]
			{
				Replace
			});
		}
	}
}
