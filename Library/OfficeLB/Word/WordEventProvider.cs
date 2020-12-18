using System;
using System.Runtime.InteropServices;

namespace OfficeLB.Word
{
	[ClassInterface(0)]
	[TypeLibType(16)]
	public class WordEventProvider : IDisposable, ApplicationEvents
	{
		public virtual void Startup(Application application)
		{
			if (this.startupEventHandler_0 != null)
			{
				this.startupEventHandler_0(application);
			}
		}

		public virtual void Quit(Application application)
		{
			if (this.quitEventHandler_0 != null)
			{
				this.quitEventHandler_0(application);
			}
		}

		public virtual void DocumentChange(Document document)
		{
			if (this.documentChangeEventHandler_0 != null)
			{
				this.documentChangeEventHandler_0(document);
			}
		}

		public virtual void DocumentOpen(Document document)
		{
			if (this.documentOpenEventHandler_0 != null)
			{
				this.documentOpenEventHandler_0(document);
			}
		}

		public virtual void DocumentBeforeClose(Document document, ref bool cancel)
		{
			if (this.documentBeforeCloseEventHandler_0 != null)
			{
				this.documentBeforeCloseEventHandler_0(document, ref cancel);
			}
		}

		public virtual void DocumentBeforePrint(Document document, ref bool cancel)
		{
			if (this.documentBeforePrintEventHandler_0 != null)
			{
				this.documentBeforePrintEventHandler_0(document, ref cancel);
			}
		}

		public virtual void DocumentBeforeSave(Document document, ref bool saveAsUI, ref bool cancel)
		{
			if (this.documentBeforeSaveEventHandler_0 != null)
			{
				this.documentBeforeSaveEventHandler_0(document, ref saveAsUI, ref cancel);
			}
		}

		public virtual void NewDocument(Document document)
		{
			if (this.newDocumentEventHandler_0 != null)
			{
				this.newDocumentEventHandler_0(document);
			}
		}

		public virtual void WindowActivate(Document document, Window window)
		{
			if (this.windowActivateEventHandler_0 != null)
			{
				this.windowActivateEventHandler_0(document, window);
			}
		}

		public virtual void WindowDeactivate(Document document, Window window)
		{
			if (this.windowDeactivateEventHandler_0 != null)
			{
				this.windowDeactivateEventHandler_0(document, window);
			}
		}

		public virtual void WindowSelectionChange(Selection selection)
		{
			if (this.windowSelectionChangeEventHandler_0 != null)
			{
				this.windowSelectionChangeEventHandler_0(selection);
			}
		}

		public virtual void WindowBeforeRightClick(Selection selection, ref bool cancel)
		{
			if (this.windowBeforeRightClickEventHandler_0 != null)
			{
				this.windowBeforeRightClickEventHandler_0(selection, ref cancel);
			}
		}

		public virtual void WindowBeforeDoubleClick(Selection selection, ref bool cancel)
		{
			if (this.windowBeforeDoubleClickEventHandler_0 != null)
			{
				this.windowBeforeDoubleClickEventHandler_0(selection, ref cancel);
			}
		}

		public event StartupEventHandler OnStartup
		{
			add
			{
				lock (this)
				{
					this.startupEventHandler_0 = (StartupEventHandler)Delegate.Combine(this.startupEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.startupEventHandler_0 != null)
					{
						this.startupEventHandler_0 = (StartupEventHandler)Delegate.Remove(this.startupEventHandler_0, value);
					}
				}
			}
		}

		public event QuitEventHandler OnQuit
		{
			add
			{
				lock (this)
				{
					this.quitEventHandler_0 = (QuitEventHandler)Delegate.Combine(this.quitEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.quitEventHandler_0 != null)
					{
						this.quitEventHandler_0 = (QuitEventHandler)Delegate.Remove(this.quitEventHandler_0, value);
					}
				}
			}
		}

		public event DocumentChangeEventHandler OnDocumentChange
		{
			add
			{
				lock (this)
				{
					this.documentChangeEventHandler_0 = (DocumentChangeEventHandler)Delegate.Combine(this.documentChangeEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.documentChangeEventHandler_0 != null)
					{
						this.documentChangeEventHandler_0 = (DocumentChangeEventHandler)Delegate.Remove(this.documentChangeEventHandler_0, value);
					}
				}
			}
		}

		public event DocumentOpenEventHandler OnDocumentOpen
		{
			add
			{
				lock (this)
				{
					this.documentOpenEventHandler_0 = (DocumentOpenEventHandler)Delegate.Combine(this.documentOpenEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.documentOpenEventHandler_0 != null)
					{
						this.documentOpenEventHandler_0 = (DocumentOpenEventHandler)Delegate.Remove(this.documentOpenEventHandler_0, value);
					}
				}
			}
		}

		public event DocumentBeforeCloseEventHandler OnDocumentBeforeClose
		{
			add
			{
				lock (this)
				{
					this.documentBeforeCloseEventHandler_0 = (DocumentBeforeCloseEventHandler)Delegate.Combine(this.documentBeforeCloseEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.documentBeforeCloseEventHandler_0 != null)
					{
						this.documentBeforeCloseEventHandler_0 = (DocumentBeforeCloseEventHandler)Delegate.Remove(this.documentBeforeCloseEventHandler_0, value);
					}
				}
			}
		}

		public event DocumentBeforePrintEventHandler OnDocumentBeforePrint
		{
			add
			{
				lock (this)
				{
					this.documentBeforePrintEventHandler_0 = (DocumentBeforePrintEventHandler)Delegate.Combine(this.documentBeforePrintEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.documentBeforePrintEventHandler_0 != null)
					{
						this.documentBeforePrintEventHandler_0 = (DocumentBeforePrintEventHandler)Delegate.Remove(this.documentBeforePrintEventHandler_0, value);
					}
				}
			}
		}

		public event DocumentBeforeSaveEventHandler OnDocumentBeforeSave
		{
			add
			{
				lock (this)
				{
					this.documentBeforeSaveEventHandler_0 = (DocumentBeforeSaveEventHandler)Delegate.Combine(this.documentBeforeSaveEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.documentBeforeSaveEventHandler_0 != null)
					{
						this.documentBeforeSaveEventHandler_0 = (DocumentBeforeSaveEventHandler)Delegate.Remove(this.documentBeforeSaveEventHandler_0, value);
					}
				}
			}
		}

		public event NewDocumentEventHandler OnNewDocument
		{
			add
			{
				lock (this)
				{
					this.newDocumentEventHandler_0 = (NewDocumentEventHandler)Delegate.Combine(this.newDocumentEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.newDocumentEventHandler_0 != null)
					{
						this.newDocumentEventHandler_0 = (NewDocumentEventHandler)Delegate.Remove(this.newDocumentEventHandler_0, value);
					}
				}
			}
		}

		public event WindowActivateEventHandler OnWindowActivate
		{
			add
			{
				lock (this)
				{
					this.windowActivateEventHandler_0 = (WindowActivateEventHandler)Delegate.Combine(this.windowActivateEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.windowActivateEventHandler_0 != null)
					{
						this.windowActivateEventHandler_0 = (WindowActivateEventHandler)Delegate.Remove(this.windowActivateEventHandler_0, value);
					}
				}
			}
		}

		public event WindowDeactivateEventHandler OnWindowDeactivate
		{
			add
			{
				lock (this)
				{
					this.windowDeactivateEventHandler_0 = (WindowDeactivateEventHandler)Delegate.Combine(this.windowDeactivateEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.windowDeactivateEventHandler_0 != null)
					{
						this.windowDeactivateEventHandler_0 = (WindowDeactivateEventHandler)Delegate.Remove(this.windowDeactivateEventHandler_0, value);
					}
				}
			}
		}

		public event WindowSelectionChangeEventHandler OnWindowSelectionChange
		{
			add
			{
				lock (this)
				{
					this.windowSelectionChangeEventHandler_0 = (WindowSelectionChangeEventHandler)Delegate.Combine(this.windowSelectionChangeEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.windowSelectionChangeEventHandler_0 != null)
					{
						this.windowSelectionChangeEventHandler_0 = (WindowSelectionChangeEventHandler)Delegate.Remove(this.windowSelectionChangeEventHandler_0, value);
					}
				}
			}
		}

		public event WindowBeforeRightClickEventHandler OnWindowBeforeRightClick
		{
			add
			{
				lock (this)
				{
					this.windowBeforeRightClickEventHandler_0 = (WindowBeforeRightClickEventHandler)Delegate.Combine(this.windowBeforeRightClickEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.windowBeforeRightClickEventHandler_0 != null)
					{
						this.windowBeforeRightClickEventHandler_0 = (WindowBeforeRightClickEventHandler)Delegate.Remove(this.windowBeforeRightClickEventHandler_0, value);
					}
				}
			}
		}

		public event WindowBeforeDoubleClickEventHandler OnWindowBeforeDouble
		{
			add
			{
				lock (this)
				{
					this.windowBeforeDoubleClickEventHandler_0 = (WindowBeforeDoubleClickEventHandler)Delegate.Combine(this.windowBeforeDoubleClickEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.windowBeforeDoubleClickEventHandler_0 != null)
					{
						this.windowBeforeDoubleClickEventHandler_0 = (WindowBeforeDoubleClickEventHandler)Delegate.Remove(this.windowBeforeDoubleClickEventHandler_0, value);
					}
				}
			}
		}

		public bool Connect()
		{
			bool result;
			try
			{
				this.object_0 = Marshal.GetActiveObject("Word.Application");
				this.ucomiconnectionPointContainer_0 = (this.object_0 as UCOMIConnectionPointContainer);
				Guid guid = new Guid("00024413-0000-0000-C000-000000000046");
				this.ucomiconnectionPointContainer_0.FindConnectionPoint(ref guid, out this.ucomiconnectionPoint_0);
				this.ucomiconnectionPoint_0.Advise(this, out this.int_0);
				bool flag = false;
				result = false;
				this.bool_0 = flag;
				result = false;
			}
			catch
			{
				this.Dispose();
				result = false;
			}
			return result;
		}

		public void Dispose()
		{
			if (!this.bool_0)
			{
				try
				{
					this.ucomiconnectionPoint_0.Unadvise(this.int_0);
				}
				catch
				{
				}
				try
				{
					Marshal.ReleaseComObject(this.object_0);
				}
				catch
				{
				}
				GC.GetTotalMemory(true);
				this.bool_0 = true;
				GC.SuppressFinalize(this);
			}
		}

		public WordEventProvider()
		{
			
			
		}

		~WordEventProvider()
		{
			this.Dispose();
		}

		private StartupEventHandler startupEventHandler_0;

		private QuitEventHandler quitEventHandler_0;

		private DocumentChangeEventHandler documentChangeEventHandler_0;

		private DocumentOpenEventHandler documentOpenEventHandler_0;

		private DocumentBeforeCloseEventHandler documentBeforeCloseEventHandler_0;

		private DocumentBeforePrintEventHandler documentBeforePrintEventHandler_0;

		private DocumentBeforeSaveEventHandler documentBeforeSaveEventHandler_0;

		private NewDocumentEventHandler newDocumentEventHandler_0;

		private WindowActivateEventHandler windowActivateEventHandler_0;

		private WindowDeactivateEventHandler windowDeactivateEventHandler_0;

		private WindowSelectionChangeEventHandler windowSelectionChangeEventHandler_0;

		private WindowBeforeRightClickEventHandler windowBeforeRightClickEventHandler_0;

		private WindowBeforeDoubleClickEventHandler windowBeforeDoubleClickEventHandler_0;

		private UCOMIConnectionPointContainer ucomiconnectionPointContainer_0;

		private UCOMIConnectionPoint ucomiconnectionPoint_0;

		private int int_0;

		private object object_0;

		private bool bool_0;
	}
}
