using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OfficeLB.Excel
{
	public class Application : Base
	{
		public Application()
		{
			
			
			this._obj = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
		}

		public Application(object oApplication)
		{
			
			base.ctor(oApplication);
		}

		public object Excel
		{
			get
			{
				return this._obj;
			}
		}

		public string Caption
		{
			get
			{
				return this.GetProperty("Caption", null).ToString();
			}
			set
			{
				this.SetProperty("Caption", new object[]
				{
					value
				});
			}
		}

		public bool DisplayAlerts
		{
			get
			{
				return (bool)this.GetProperty("DisplayAlerts", null);
			}
			set
			{
				this.SetProperty("DisplayAlerts", new object[]
				{
					value
				});
			}
		}

		public xlCommentDisplayMode DisplayCommentIndicator
		{
			get
			{
				return (xlCommentDisplayMode)this.GetProperty("DisplayCommentIndicator", null);
			}
			set
			{
				this.SetProperty("DisplayCommentIndicator", new object[]
				{
					value
				});
			}
		}

		public bool DisplayFormulaBar
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("DisplayFormulaBar", null).ToString());
			}
			set
			{
				this.SetProperty("DisplayFormulaBar", new object[]
				{
					value
				});
			}
		}

		public bool DisplayScrollBars
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("DisplayScrollBars", null).ToString());
			}
			set
			{
				this.SetProperty("DisplayScrollBars", new object[]
				{
					value
				});
			}
		}

		public bool DisplayStatusBar
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("DisplayStatusBar", null).ToString());
			}
			set
			{
				this.SetProperty("DisplayStatusBar", new object[]
				{
					value
				});
			}
		}

		public bool EditDirectlyInCell
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("EditDirectlyInCell", null).ToString());
			}
			set
			{
				this.SetProperty("EditDirectlyInCell", new object[]
				{
					value
				});
			}
		}

		public bool PrintCommunication
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("PrintCommunication", null).ToString());
			}
			set
			{
				this.SetProperty("PrintCommunication", new object[]
				{
					value
				});
			}
		}

		public void Run(string name, object[] value)
		{
			try
			{
				this.InvokeMethod("Run", new object[]
				{
					name,
					value
				});
			}
			catch (TargetInvocationException ex)
			{
				COMException ex2 = ex.InnerException as COMException;
				if (ex2 != null && (ex2.ErrorCode == -2146827284 || ex2.ErrorCode == 1004))
				{
					throw new ApplicationException(string.Format("The macro '{0}' does not exist.", name), ex);
				}
				throw ex;
			}
		}

		public bool ScreenUpdating
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("ScreenUpdating", null).ToString());
			}
			set
			{
				this.SetProperty("ScreenUpdating", new object[]
				{
					value
				});
			}
		}

		public int SheetsInNewWorkbook
		{
			get
			{
				return (int)this.GetProperty("SheetsInNewWorkbook", null);
			}
			set
			{
				this.SetProperty("SheetsInNewWorkbook", new object[]
				{
					value
				});
			}
		}

		public string StatusBar
		{
			get
			{
				return this.GetProperty("StatusBar", null).ToString();
			}
			set
			{
				this.SetProperty("StatusBar", new object[]
				{
					value
				});
			}
		}

		public bool UserControl
		{
			get
			{
				return Convert.ToBoolean(this.GetProperty("UserControl", null).ToString());
			}
			set
			{
				this.SetProperty("UserControl", new object[]
				{
					value
				});
			}
		}

		public string Value
		{
			get
			{
				return this.GetProperty("Value", null).ToString();
			}
			set
			{
				this.SetProperty("Value", new object[]
				{
					value
				});
			}
		}

		public string Version
		{
			get
			{
				return this.GetProperty("Version", null).ToString();
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

		public xlWindowState WindowState
		{
			get
			{
				return (xlWindowState)this.GetProperty("WindowState", null);
			}
			set
			{
				this.SetProperty("WindowState", new object[]
				{
					value
				});
			}
		}

		public Workbooks BookCollection
		{
			get
			{
				return new Workbooks(this.GetProperty("WorkBooks", null));
			}
		}

		public void Calculate()
		{
			this.InvokeMethod("Calculate", null);
		}

		public void Quit()
		{
			this.InvokeMethod("Quit", null);
		}

		public void Workbooks()
		{
			this.InvokeMethod("Workbooks", null);
		}

		public WorksheetFunction WorksheetFunction
		{
			get
			{
				return new WorksheetFunction(this.GetProperty("WorksheetFunction", null));
			}
		}

		public const string UID = "Excel.Application";
	}
}
