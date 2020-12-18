using System;

namespace OfficeLB.Word
{
	public class Application : Base
	{
		public Application()
		{
			
			
			this._obj = Activator.CreateInstance(Type.GetTypeFromProgID("Word.Application"));
		}

		public Window ActiveWindow
		{
			get
			{
				return new Window(this.GetProperty("ActiveWindow", null));
			}
		}

		public Document ActiveDocument
		{
			get
			{
				return new Document(this.GetProperty("ActiveDocument", null));
			}
		}

		public string ActivePrinter
		{
			get
			{
				return this.GetProperty("ActivePrinter", null).ToString();
			}
			set
			{
				this.SetProperty("ActivePrinter", new object[]
				{
					value
				});
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

		public bool CapsLock
		{
			get
			{
				return bool.Parse(this.GetProperty("CapsLock", null).ToString());
			}
		}

		public WdAlertLevel DisplayAlerts
		{
			get
			{
				return (WdAlertLevel)this.GetProperty("DisplayAlerts", null);
			}
			set
			{
				this.SetProperty("DisplayAlerts", new object[]
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

		public FileSearch FileSearch
		{
			get
			{
				return new FileSearch(this.GetProperty("FileSearch", null));
			}
		}

		public string Path
		{
			get
			{
				return this.GetProperty("Path", null).ToString();
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

		public Selection Selection
		{
			get
			{
				return new Selection(this.GetProperty("Selection", null));
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
		}

		public string UserName
		{
			get
			{
				return this.GetProperty("UserName", null).ToString();
			}
			set
			{
				this.SetProperty("UserName", new object[]
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

		public WdWindowState WindowState
		{
			get
			{
				return (WdWindowState)this.GetProperty("WindowState", null);
			}
			set
			{
				this.SetProperty("WindowState", new object[]
				{
					value
				});
			}
		}

		public Documents Documents
		{
			get
			{
				return new Documents(this.GetProperty("Documents", null));
			}
		}

		public Windows Windows
		{
			get
			{
				return new Windows(this.GetProperty("Windows", null));
			}
		}

		public double CentimetersToPoints(double value)
		{
			return (double)this.InvokeReturn("CentimetersToPoints", new object[]
			{
				value
			});
		}

		public double MillimetersToPoints(double value)
		{
			return (double)this.InvokeReturn("MillimetersToPoints", new object[]
			{
				value
			});
		}

		public double LinesToPoints(double value)
		{
			return (double)this.InvokeReturn("LinesToPoints", new object[]
			{
				value
			});
		}

		public double PicasToPoints(double value)
		{
			return (double)this.InvokeReturn("PicasToPoints", new object[]
			{
				value
			});
		}

		public bool CheckSpelling(string text)
		{
			return bool.Parse(this.InvokeReturn("CheckSpelling", null).ToString());
		}

		public Dialog Dialogs(WdWordDialog dialog)
		{
			return new Dialog(this.GetProperty("Dialogs", new object[]
			{
				dialog
			}));
		}

		public void Help(WdHelpType typeWindow)
		{
			this.InvokeMethod("Help", new object[]
			{
				typeWindow
			});
		}

		public void Move(int left, int top)
		{
			this.InvokeMethod("Move", new object[]
			{
				left,
				top
			});
		}

		public void Quit()
		{
			this.InvokeMethod("Quit", null);
		}

		public void Quit(WdSaveOptions options)
		{
			this.InvokeMethod("Quit", new object[]
			{
				options
			});
		}

		public void Resize(int width, int height)
		{
			this.InvokeMethod("Resize", new object[]
			{
				width,
				height
			});
		}

		public void SendFax()
		{
			this.InvokeMethod("SendFax", null);
		}

		public const string UID = "Word.Application";
	}
}
