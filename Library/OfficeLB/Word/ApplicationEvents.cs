using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OfficeLB.Word
{
	[InterfaceType(2)]
	[Guid("000209FE-0000-0000-C000-000000000046")]
	[TypeLibType(4112)]
	public interface ApplicationEvents
	{
		[DispId(1)]
		[TypeLibFunc(65)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Startup([MarshalAs(UnmanagedType.Interface)] [In] Application application);

		[DispId(2)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Quit([MarshalAs(UnmanagedType.Interface)] [In] Application application);

		[DispId(3)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DocumentChange([MarshalAs(UnmanagedType.Interface)] [In] Document document);

		[DispId(4)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DocumentOpen([MarshalAs(UnmanagedType.Interface)] [In] Document document);

		[DispId(6)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DocumentBeforeClose([MarshalAs(UnmanagedType.Interface)] [In] Document ducument, [In] ref bool Cancel);

		[DispId(7)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DocumentBeforePrint([MarshalAs(UnmanagedType.Interface)] [In] Document ducument, [In] ref bool Cancel);

		[DispId(8)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DocumentBeforeSave([MarshalAs(UnmanagedType.Interface)] [In] Document ducument, [In] ref bool SaveAsUI, [In] ref bool Cancel);

		[DispId(9)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void NewDocument([MarshalAs(UnmanagedType.Interface)] [In] Document ducument);

		[DispId(10)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WindowActivate([MarshalAs(UnmanagedType.Interface)] [In] Document ducument, [MarshalAs(UnmanagedType.Interface)] [In] Window window);

		[DispId(11)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WindowDeactivate([MarshalAs(UnmanagedType.Interface)] [In] Document ducument, [MarshalAs(UnmanagedType.Interface)] [In] Window window);

		[DispId(12)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WindowSelectionChange([MarshalAs(UnmanagedType.Interface)] [In] Selection selection);

		[DispId(13)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WindowBeforeRightClick([MarshalAs(UnmanagedType.Interface)] [In] Selection selection, [In] ref bool Cancel);

		[DispId(14)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void WindowBeforeDoubleClick([MarshalAs(UnmanagedType.Interface)] [In] Selection selection, [In] ref bool Cancel);
	}
}
