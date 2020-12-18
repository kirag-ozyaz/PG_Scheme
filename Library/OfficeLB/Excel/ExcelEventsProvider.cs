using System;
using System.Runtime.InteropServices;

namespace OfficeLB.Excel
{
	[ClassInterface(0)]
	[TypeLibType(16)]
	public class ExcelEventsProvider : IDisposable, ApplicationEvents
	{
		public virtual void NewWorkbook(object sender)
		{
			if (this.newWorkbookEventHandler_0 != null)
			{
				this.newWorkbookEventHandler_0(sender);
			}
		}

		public virtual void SheetActivate(object sender)
		{
			if (this.sheetActivateEventHandler_0 != null)
			{
				this.sheetActivateEventHandler_0(sender);
			}
		}

		public virtual void SheetBeforeDoubleClick(object sender, object Range, ref bool Cancel)
		{
			if (this.sheetBeforeDoubleClickEventHandler_0 != null)
			{
				this.sheetBeforeDoubleClickEventHandler_0(sender, Range, ref Cancel);
			}
		}

		public virtual void SheetBeforeRightClick(object sender, object Range, ref bool Cancel)
		{
			if (this.sheetBeforeRightClickEventHandler_0 != null)
			{
				this.sheetBeforeRightClickEventHandler_0(sender, Range, ref Cancel);
			}
		}

		public virtual void SheetCalculate(object sender)
		{
			if (this.sheetCalculateEventHandler_0 != null)
			{
				this.sheetCalculateEventHandler_0(sender);
			}
		}

		public virtual void SheetChange(object sender, object Range)
		{
			if (this.sheetChangeEventHandler_0 != null)
			{
				this.sheetChangeEventHandler_0(sender, Range);
			}
		}

		public virtual void SheetDeactivate(object sender)
		{
			if (this.sheetDeactivateEventHandler_0 != null)
			{
				this.sheetDeactivateEventHandler_0(sender);
			}
		}

		public virtual void SheetFollowHyperlink(object sender, object Hyperlink)
		{
			if (this.sheetFollowHyperlinkEventHandler_0 != null)
			{
				this.sheetFollowHyperlinkEventHandler_0(sender, Hyperlink);
			}
		}

		public virtual void SheetPivotTableUpdate(object sender, object PivotTable)
		{
			if (this.sheetPivotTableUpdateEventHandler_0 != null)
			{
				this.sheetPivotTableUpdateEventHandler_0(sender, PivotTable);
			}
		}

		public virtual void SheetSelectionChange(object sender, object Range)
		{
			if (this.sheetSelectionChangeEventHandler_0 != null)
			{
				this.sheetSelectionChangeEventHandler_0(sender, Range);
			}
		}

		public virtual void WindowActivate(object Workbook, object Window)
		{
			if (this.windowActivateEventHandler_0 != null)
			{
				this.windowActivateEventHandler_0(Workbook, Window);
			}
		}

		public virtual void WindowDeactivate(object Workbook, object Window)
		{
			if (this.windowDeactivateEventHandler_0 != null)
			{
				this.windowDeactivateEventHandler_0(Workbook, Window);
			}
		}

		public virtual void WindowResize(object Workbook, object Window)
		{
			if (this.windowResizeEventHandler_0 != null)
			{
				this.windowResizeEventHandler_0(Workbook, Window);
			}
		}

		public virtual void WorkbookActivate(object Workbook)
		{
			if (this.workbookActivateEventHandler_0 != null)
			{
				this.workbookActivateEventHandler_0(Workbook);
			}
		}

		public virtual void WorkbookAddinInstall(object Workbook)
		{
			if (this.workbookAddinInstallEventHandler_0 != null)
			{
				this.workbookAddinInstallEventHandler_0(Workbook);
			}
		}

		public virtual void WorkbookAddinUninstall(object Workbook)
		{
			if (this.workbookAddinUninstallEventHandler_0 != null)
			{
				this.workbookAddinUninstallEventHandler_0(Workbook);
			}
		}

		public virtual void WorkbookBeforeClose(object Workbook, ref bool Cancel)
		{
			if (this.workbookBeforeCloseEventHandler_0 != null)
			{
				this.workbookBeforeCloseEventHandler_0(Workbook, ref Cancel);
			}
		}

		public virtual void WorkbookBeforePrint(object Workbook, ref bool Cancel)
		{
			if (this.workbookBeforePrintEventHandler_0 != null)
			{
				this.workbookBeforePrintEventHandler_0(Workbook, ref Cancel);
			}
		}

		public virtual void WorkbookBeforeSave(object Workbook, bool save, ref bool Cancel)
		{
			if (this.workbookBeforeSaveEventHandler_0 != null)
			{
				this.workbookBeforeSaveEventHandler_0(Workbook, save, ref Cancel);
			}
		}

		public virtual void WorkbookDeactivate(object Workbook)
		{
			if (this.workbookDeactivateEventHandler_0 != null)
			{
				this.workbookDeactivateEventHandler_0(Workbook);
			}
		}

		public virtual void WorkbookNewSheet(object Workbook, object sheet)
		{
			if (this.workbookNewSheetEventHandler_0 != null)
			{
				this.workbookNewSheetEventHandler_0(Workbook, sheet);
			}
		}

		public virtual void WorkbookOpen(object Workbook)
		{
			if (this.workbookOpenEventHandler_0 != null)
			{
				this.workbookOpenEventHandler_0(Workbook);
			}
		}

		public virtual void WorkbookPivotTableCloseConnection(object Workbook, object PivotTable)
		{
			if (this.workbookPivotTableCloseConnectionEventHandler_0 != null)
			{
				this.workbookPivotTableCloseConnectionEventHandler_0(Workbook, PivotTable);
			}
		}

		public virtual void WorkbookPivotTableOpenConnection(object Workbook, object PivotTable)
		{
			if (this.workbookPivotTableOpenConnectionEventHandler_0 != null)
			{
				this.workbookPivotTableOpenConnectionEventHandler_0(Workbook, PivotTable);
			}
		}

		public event NewWorkbookEventHandler OnNewWorkbookDelegate
		{
			add
			{
				lock (this)
				{
					this.newWorkbookEventHandler_0 = (NewWorkbookEventHandler)Delegate.Combine(this.newWorkbookEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.newWorkbookEventHandler_0 != null)
					{
						this.newWorkbookEventHandler_0 = (NewWorkbookEventHandler)Delegate.Remove(this.newWorkbookEventHandler_0, value);
					}
				}
			}
		}

		public event SheetActivateEventHandler OnSheetActivateDelegate
		{
			add
			{
				lock (this)
				{
					this.sheetActivateEventHandler_0 = (SheetActivateEventHandler)Delegate.Combine(this.sheetActivateEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.sheetActivateEventHandler_0 != null)
					{
						this.sheetActivateEventHandler_0 = (SheetActivateEventHandler)Delegate.Remove(this.sheetActivateEventHandler_0, value);
					}
				}
			}
		}

		public event SheetBeforeDoubleClickEventHandler OnSheetBeforeDoubleClickDelegate
		{
			add
			{
				lock (this)
				{
					this.sheetBeforeDoubleClickEventHandler_0 = (SheetBeforeDoubleClickEventHandler)Delegate.Combine(this.sheetBeforeDoubleClickEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.sheetBeforeDoubleClickEventHandler_0 != null)
					{
						this.sheetBeforeDoubleClickEventHandler_0 = (SheetBeforeDoubleClickEventHandler)Delegate.Remove(this.sheetBeforeDoubleClickEventHandler_0, value);
					}
				}
			}
		}

		public event SheetBeforeRightClickEventHandler OnSheetBeforeRightClickDelegate
		{
			add
			{
				lock (this)
				{
					this.sheetBeforeRightClickEventHandler_0 = (SheetBeforeRightClickEventHandler)Delegate.Combine(this.sheetBeforeRightClickEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.sheetBeforeRightClickEventHandler_0 != null)
					{
						this.sheetBeforeRightClickEventHandler_0 = (SheetBeforeRightClickEventHandler)Delegate.Remove(this.sheetBeforeRightClickEventHandler_0, value);
					}
				}
			}
		}

		public event SheetCalculateEventHandler OnSheetCalculateDelegate
		{
			add
			{
				lock (this)
				{
					this.sheetCalculateEventHandler_0 = (SheetCalculateEventHandler)Delegate.Combine(this.sheetCalculateEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.sheetCalculateEventHandler_0 != null)
					{
						this.sheetCalculateEventHandler_0 = (SheetCalculateEventHandler)Delegate.Remove(this.sheetCalculateEventHandler_0, value);
					}
				}
			}
		}

		public event SheetChangeEventHandler OnSheetChangeDelegate
		{
			add
			{
				lock (this)
				{
					this.sheetChangeEventHandler_0 = (SheetChangeEventHandler)Delegate.Combine(this.sheetChangeEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.sheetChangeEventHandler_0 != null)
					{
						this.sheetChangeEventHandler_0 = (SheetChangeEventHandler)Delegate.Remove(this.sheetChangeEventHandler_0, value);
					}
				}
			}
		}

		public event SheetDeactivateEventHandler OnSheetDeactivateDelegate
		{
			add
			{
				lock (this)
				{
					this.sheetDeactivateEventHandler_0 = (SheetDeactivateEventHandler)Delegate.Combine(this.sheetDeactivateEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.sheetDeactivateEventHandler_0 != null)
					{
						this.sheetDeactivateEventHandler_0 = (SheetDeactivateEventHandler)Delegate.Remove(this.sheetDeactivateEventHandler_0, value);
					}
				}
			}
		}

		public event SheetFollowHyperlinkEventHandler OnSheetFollowHyperlinkDelegate
		{
			add
			{
				lock (this)
				{
					this.sheetFollowHyperlinkEventHandler_0 = (SheetFollowHyperlinkEventHandler)Delegate.Combine(this.sheetFollowHyperlinkEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.sheetFollowHyperlinkEventHandler_0 != null)
					{
						this.sheetFollowHyperlinkEventHandler_0 = (SheetFollowHyperlinkEventHandler)Delegate.Remove(this.sheetFollowHyperlinkEventHandler_0, value);
					}
				}
			}
		}

		public event SheetPivotTableUpdateEventHandler OnSheetPivotTableUpdateDelegate
		{
			add
			{
				lock (this)
				{
					this.sheetPivotTableUpdateEventHandler_0 = (SheetPivotTableUpdateEventHandler)Delegate.Combine(this.sheetPivotTableUpdateEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.sheetPivotTableUpdateEventHandler_0 != null)
					{
						this.sheetPivotTableUpdateEventHandler_0 = (SheetPivotTableUpdateEventHandler)Delegate.Remove(this.sheetPivotTableUpdateEventHandler_0, value);
					}
				}
			}
		}

		public event SheetSelectionChangeEventHandler OnSheetSelectionChangeDelegate
		{
			add
			{
				lock (this)
				{
					this.sheetSelectionChangeEventHandler_0 = (SheetSelectionChangeEventHandler)Delegate.Combine(this.sheetSelectionChangeEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.sheetSelectionChangeEventHandler_0 != null)
					{
						this.sheetSelectionChangeEventHandler_0 = (SheetSelectionChangeEventHandler)Delegate.Remove(this.sheetSelectionChangeEventHandler_0, value);
					}
				}
			}
		}

		public event WindowActivateEventHandler OnWindowActivateDelegate
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

		public event WindowDeactivateEventHandler OnWindowDeactivateDelegate
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

		public event WindowResizeEventHandler OnWindowResizeDelegate
		{
			add
			{
				lock (this)
				{
					this.windowResizeEventHandler_0 = (WindowResizeEventHandler)Delegate.Combine(this.windowResizeEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.windowResizeEventHandler_0 != null)
					{
						this.windowResizeEventHandler_0 = (WindowResizeEventHandler)Delegate.Remove(this.windowResizeEventHandler_0, value);
					}
				}
			}
		}

		public event WorkbookActivateEventHandler OnWorkbookActivateDelegate
		{
			add
			{
				lock (this)
				{
					this.workbookActivateEventHandler_0 = (WorkbookActivateEventHandler)Delegate.Combine(this.workbookActivateEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.workbookActivateEventHandler_0 != null)
					{
						this.workbookActivateEventHandler_0 = (WorkbookActivateEventHandler)Delegate.Remove(this.workbookActivateEventHandler_0, value);
					}
				}
			}
		}

		public event WorkbookAddinInstallEventHandler OnWorkbookAddinInstallDelegate
		{
			add
			{
				lock (this)
				{
					this.workbookAddinInstallEventHandler_0 = (WorkbookAddinInstallEventHandler)Delegate.Combine(this.workbookAddinInstallEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.workbookAddinInstallEventHandler_0 != null)
					{
						this.workbookAddinInstallEventHandler_0 = (WorkbookAddinInstallEventHandler)Delegate.Remove(this.workbookAddinInstallEventHandler_0, value);
					}
				}
			}
		}

		public event WorkbookAddinUninstallEventHandler OnWorkbookAddinUninstallDelegate
		{
			add
			{
				lock (this)
				{
					this.workbookAddinUninstallEventHandler_0 = (WorkbookAddinUninstallEventHandler)Delegate.Combine(this.workbookAddinUninstallEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.workbookAddinUninstallEventHandler_0 != null)
					{
						this.workbookAddinUninstallEventHandler_0 = (WorkbookAddinUninstallEventHandler)Delegate.Remove(this.workbookAddinUninstallEventHandler_0, value);
					}
				}
			}
		}

		public event WorkbookBeforeCloseEventHandler OnWorkbookBeforeCloseDelegate
		{
			add
			{
				lock (this)
				{
					this.workbookBeforeCloseEventHandler_0 = (WorkbookBeforeCloseEventHandler)Delegate.Combine(this.workbookBeforeCloseEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.workbookBeforeCloseEventHandler_0 != null)
					{
						this.workbookBeforeCloseEventHandler_0 = (WorkbookBeforeCloseEventHandler)Delegate.Remove(this.workbookBeforeCloseEventHandler_0, value);
					}
				}
			}
		}

		public event WorkbookBeforePrintEventHandler OnWorkbookBeforePrintDelegate
		{
			add
			{
				lock (this)
				{
					this.workbookBeforePrintEventHandler_0 = (WorkbookBeforePrintEventHandler)Delegate.Combine(this.workbookBeforePrintEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.workbookBeforePrintEventHandler_0 != null)
					{
						this.workbookBeforePrintEventHandler_0 = (WorkbookBeforePrintEventHandler)Delegate.Remove(this.workbookBeforePrintEventHandler_0, value);
					}
				}
			}
		}

		public event WorkbookBeforeSaveEventHandler OnWorkbookBeforeSaveDelegate
		{
			add
			{
				lock (this)
				{
					this.workbookBeforeSaveEventHandler_0 = (WorkbookBeforeSaveEventHandler)Delegate.Combine(this.workbookBeforeSaveEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.workbookBeforeSaveEventHandler_0 != null)
					{
						this.workbookBeforeSaveEventHandler_0 = (WorkbookBeforeSaveEventHandler)Delegate.Remove(this.workbookBeforeSaveEventHandler_0, value);
					}
				}
			}
		}

		public event WorkbookDeactivateEventHandler OnWorkbookDeactivateDelegate
		{
			add
			{
				lock (this)
				{
					this.workbookDeactivateEventHandler_0 = (WorkbookDeactivateEventHandler)Delegate.Combine(this.workbookDeactivateEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.workbookDeactivateEventHandler_0 != null)
					{
						this.workbookDeactivateEventHandler_0 = (WorkbookDeactivateEventHandler)Delegate.Remove(this.workbookDeactivateEventHandler_0, value);
					}
				}
			}
		}

		public event WorkbookNewSheetEventHandler OnWorkbookNewSheetDelegate
		{
			add
			{
				lock (this)
				{
					this.workbookNewSheetEventHandler_0 = (WorkbookNewSheetEventHandler)Delegate.Combine(this.workbookNewSheetEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.workbookNewSheetEventHandler_0 != null)
					{
						this.workbookNewSheetEventHandler_0 = (WorkbookNewSheetEventHandler)Delegate.Remove(this.workbookNewSheetEventHandler_0, value);
					}
				}
			}
		}

		public event WorkbookOpenEventHandler OnWorkbookOpenDelegate
		{
			add
			{
				lock (this)
				{
					this.workbookOpenEventHandler_0 = (WorkbookOpenEventHandler)Delegate.Combine(this.workbookOpenEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.workbookOpenEventHandler_0 != null)
					{
						this.workbookOpenEventHandler_0 = (WorkbookOpenEventHandler)Delegate.Remove(this.workbookOpenEventHandler_0, value);
					}
				}
			}
		}

		public event WorkbookPivotTableCloseConnectionEventHandler OnWorkbookPivotTableCloseConnectionDelegate
		{
			add
			{
				lock (this)
				{
					this.workbookPivotTableCloseConnectionEventHandler_0 = (WorkbookPivotTableCloseConnectionEventHandler)Delegate.Combine(this.workbookPivotTableCloseConnectionEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.workbookPivotTableCloseConnectionEventHandler_0 != null)
					{
						this.workbookPivotTableCloseConnectionEventHandler_0 = (WorkbookPivotTableCloseConnectionEventHandler)Delegate.Remove(this.workbookPivotTableCloseConnectionEventHandler_0, value);
					}
				}
			}
		}

		public event WorkbookPivotTableOpenConnectionEventHandler OnWorkbookPivotTableOpenConnectionDelegate
		{
			add
			{
				lock (this)
				{
					this.workbookPivotTableOpenConnectionEventHandler_0 = (WorkbookPivotTableOpenConnectionEventHandler)Delegate.Combine(this.workbookPivotTableOpenConnectionEventHandler_0, value);
				}
			}
			remove
			{
				lock (this)
				{
					if (this.workbookPivotTableOpenConnectionEventHandler_0 != null)
					{
						this.workbookPivotTableOpenConnectionEventHandler_0 = (WorkbookPivotTableOpenConnectionEventHandler)Delegate.Remove(this.workbookPivotTableOpenConnectionEventHandler_0, value);
					}
				}
			}
		}

		public bool Connect()
		{
			bool result;
			try
			{
				this.object_0 = Marshal.GetActiveObject("Excel.Application");
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

		public ExcelEventsProvider()
		{
			
			
		}

		~ExcelEventsProvider()
		{
			this.Dispose();
		}

		private NewWorkbookEventHandler newWorkbookEventHandler_0;

		private SheetActivateEventHandler sheetActivateEventHandler_0;

		private SheetBeforeDoubleClickEventHandler sheetBeforeDoubleClickEventHandler_0;

		private SheetBeforeRightClickEventHandler sheetBeforeRightClickEventHandler_0;

		private SheetCalculateEventHandler sheetCalculateEventHandler_0;

		private SheetChangeEventHandler sheetChangeEventHandler_0;

		private SheetDeactivateEventHandler sheetDeactivateEventHandler_0;

		private SheetFollowHyperlinkEventHandler sheetFollowHyperlinkEventHandler_0;

		private SheetPivotTableUpdateEventHandler sheetPivotTableUpdateEventHandler_0;

		private SheetSelectionChangeEventHandler sheetSelectionChangeEventHandler_0;

		private WindowActivateEventHandler windowActivateEventHandler_0;

		private WindowDeactivateEventHandler windowDeactivateEventHandler_0;

		private WindowResizeEventHandler windowResizeEventHandler_0;

		private WorkbookActivateEventHandler workbookActivateEventHandler_0;

		private WorkbookAddinInstallEventHandler workbookAddinInstallEventHandler_0;

		private WorkbookAddinUninstallEventHandler workbookAddinUninstallEventHandler_0;

		private WorkbookBeforeCloseEventHandler workbookBeforeCloseEventHandler_0;

		private WorkbookBeforePrintEventHandler workbookBeforePrintEventHandler_0;

		private WorkbookBeforeSaveEventHandler workbookBeforeSaveEventHandler_0;

		private WorkbookDeactivateEventHandler workbookDeactivateEventHandler_0;

		private WorkbookNewSheetEventHandler workbookNewSheetEventHandler_0;

		private WorkbookOpenEventHandler workbookOpenEventHandler_0;

		private WorkbookPivotTableCloseConnectionEventHandler workbookPivotTableCloseConnectionEventHandler_0;

		private WorkbookPivotTableOpenConnectionEventHandler workbookPivotTableOpenConnectionEventHandler_0;

		private UCOMIConnectionPointContainer ucomiconnectionPointContainer_0;

		private UCOMIConnectionPoint ucomiconnectionPoint_0;

		private int int_0;

		private object object_0;

		private bool bool_0;
	}
}
