using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OfficeLB.Excel
{
	[Guid("00024413-0000-0000-C000-000000000046")]
	[TypeLibType(4112)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	[ComImport]
	public interface ApplicationEvents
	{
		[DispId(1565)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void NewWorkbook([MarshalAs(UnmanagedType.Interface)] [In] object Wb);

		[DispId(1558)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SheetSelectionChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Sh, [MarshalAs(UnmanagedType.Interface)] [In] object Target);

		[DispId(1559)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SheetBeforeDoubleClick([MarshalAs(UnmanagedType.IDispatch)] [In] object Sh, [MarshalAs(UnmanagedType.Interface)] [In] object Target, [In] ref bool Cancel);

		[DispId(1560)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SheetBeforeRightClick([MarshalAs(UnmanagedType.IDispatch)] [In] object Sh, [MarshalAs(UnmanagedType.Interface)] [In] object Target, [In] ref bool Cancel);

		[DispId(1561)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SheetActivate([MarshalAs(UnmanagedType.IDispatch)] [In] object Sh);

		[DispId(1562)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SheetDeactivate([MarshalAs(UnmanagedType.IDispatch)] [In] object Sh);

		[DispId(1563)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SheetCalculate([MarshalAs(UnmanagedType.IDispatch)] [In] object Sh);

		[DispId(1564)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SheetChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Sh, [MarshalAs(UnmanagedType.Interface)] [In] object Target);

		[DispId(1567)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WorkbookOpen([MarshalAs(UnmanagedType.Interface)] [In] object Wb);

		[DispId(1568)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WorkbookActivate([MarshalAs(UnmanagedType.Interface)] [In] object Wb);

		[DispId(1569)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WorkbookDeactivate([MarshalAs(UnmanagedType.Interface)] [In] object Wb);

		[DispId(1570)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WorkbookBeforeClose([MarshalAs(UnmanagedType.Interface)] [In] object Wb, [In] ref bool Cancel);

		[DispId(1571)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WorkbookBeforeSave([MarshalAs(UnmanagedType.Interface)] [In] object Wb, [In] bool SaveAsUI, [In] ref bool Cancel);

		[DispId(1572)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WorkbookBeforePrint([MarshalAs(UnmanagedType.Interface)] [In] object Wb, [In] ref bool Cancel);

		[DispId(1573)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WorkbookNewSheet([MarshalAs(UnmanagedType.Interface)] [In] object Wb, [MarshalAs(UnmanagedType.IDispatch)] [In] object Sh);

		[DispId(1574)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WorkbookAddinInstall([MarshalAs(UnmanagedType.Interface)] [In] object Wb);

		[DispId(1575)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WorkbookAddinUninstall([MarshalAs(UnmanagedType.Interface)] [In] object Wb);

		[DispId(1554)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WindowResize([MarshalAs(UnmanagedType.Interface)] [In] object Wb, [MarshalAs(UnmanagedType.Interface)] [In] object Wn);

		[DispId(1556)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WindowActivate([MarshalAs(UnmanagedType.Interface)] [In] object Wb, [MarshalAs(UnmanagedType.Interface)] [In] object Wn);

		[DispId(1557)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WindowDeactivate([MarshalAs(UnmanagedType.Interface)] [In] object Wb, [MarshalAs(UnmanagedType.Interface)] [In] object Wn);

		[DispId(1854)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SheetFollowHyperlink([MarshalAs(UnmanagedType.IDispatch)] [In] object Sh, [MarshalAs(UnmanagedType.Interface)] [In] object Target);

		[DispId(2157)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void SheetPivotTableUpdate([MarshalAs(UnmanagedType.IDispatch)] [In] object Sh, [MarshalAs(UnmanagedType.Interface)] [In] object Target);

		[DispId(2160)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WorkbookPivotTableCloseConnection([MarshalAs(UnmanagedType.Interface)] [In] object Wb, [MarshalAs(UnmanagedType.Interface)] [In] object Target);

		[DispId(2161)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WorkbookPivotTableOpenConnection([MarshalAs(UnmanagedType.Interface)] [In] object Wb, [MarshalAs(UnmanagedType.Interface)] [In] object Target);
	}
}
