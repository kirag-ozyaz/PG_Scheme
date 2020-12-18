using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SchemeCtrl2.Canvas
{
	public static class FileInfo
	{
		[DllImport("shell32.dll")]
		public static extern int SHGetFileInfo(string pszPath, uint dwFileAttributes, ref FileInfo.SHFILEINFO psfi, int cbfileInfo, uint uFlags);

		public static Icon IconOfFile(string FileName)
		{
			FileInfo.SHFILEINFO shfileinfo = default(FileInfo.SHFILEINFO);
			uint num = FileInfo.uint_2 | FileInfo.uint_0;
			num |= FileInfo.uint_1;
			if (FileInfo.SHGetFileInfo(FileName, FileInfo.uint_3, ref shfileinfo, Marshal.SizeOf(shfileinfo), num) == 0)
			{
				return null;
			}
			return Icon.FromHandle(shfileinfo.hIcon);
		}

		private static uint uint_0 = 256u;

		private static uint uint_1 = 0u;

		private static uint uint_2 = 16u;

		private static uint uint_3 = 128u;

		public struct SHFILEINFO
		{
			public IntPtr hIcon;

			public IntPtr iIcon;

			public uint dwAttributes;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szDisplayName;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public string szTypeName;
		}
	}
}
