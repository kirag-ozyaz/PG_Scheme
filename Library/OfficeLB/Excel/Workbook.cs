using System;

namespace OfficeLB.Excel
{
	public class Workbook : Base
	{
		public ActiveSheet ActiveSheet
		{
			get
			{
				return new ActiveSheet(this.GetProperty("ActiveSheet", null));
			}
		}

		public string FullName
		{
			get
			{
				return this.GetProperty("FullName", null).ToString();
			}
		}

		public string Name
		{
			get
			{
				return this.GetProperty("Name", null).ToString();
			}
		}

		public string Path
		{
			get
			{
				return this.GetProperty("Path", null).ToString();
			}
		}

		public string Password
		{
			get
			{
				return this.GetProperty("Password", null).ToString();
			}
			set
			{
				this.SetProperty("Password", new object[]
				{
					value
				});
			}
		}

		public Worksheets Worksheets
		{
			get
			{
				return new Worksheets(this.GetProperty("Worksheets", null));
			}
			set
			{
				this.SetProperty("Worksheets", new object[]
				{
					value
				});
			}
		}

		public Workbook()
		{
			
			
		}

		public Workbook(object oWorkbook)
		{
			
			base.ctor(oWorkbook);
		}

		public void Add()
		{
			this.InvokeMethod("Add", null);
		}

		public void Add(string fileName)
		{
			this.InvokeMethod("Add", new object[]
			{
				fileName
			});
		}

		public void Open(string fileName)
		{
			this.InvokeMethod("Open", new object[]
			{
				fileName
			});
		}

		public void PrintOut()
		{
			this.InvokeMethod("PrintOut", null);
		}

		public void Protect()
		{
			this.InvokeMethod("Protect", null);
		}

		public void Unprotect()
		{
			this.InvokeMethod("Unprotect", null);
		}

		public void Printout()
		{
			this.InvokeMethod("Printout", null);
		}

		public void SendMail(string Recipients, string Subject, bool ReturnReceipt)
		{
			this.InvokeMethod("SendMail", new object[]
			{
				Recipients,
				Subject,
				ReturnReceipt
			});
		}

		public void Save()
		{
			this.InvokeMethod("Save", null);
		}

		public void SaveAs(string fileName)
		{
			this.InvokeMethod("SaveAs", new object[]
			{
				fileName
			});
		}

		public void SetBackgroundPicture(string fileName)
		{
			this.InvokeMethod("SetBackgroundPicture", new object[]
			{
				fileName
			});
		}
	}
}
