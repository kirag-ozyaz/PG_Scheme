using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Passport.Classes
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

		// Note: this type is marked as 'beforefieldinit'.
		static FileInfo()
		{
			Class330.Mus9JxKz1CNxy();
			FileInfo.uint_0 = 256u;
			FileInfo.uint_1 = 0u;
			FileInfo.uint_2 = 16u;
			FileInfo.uint_3 = 128u;
		}

		private static uint uint_0;

		private static uint uint_1;

		private static uint uint_2;

		private static uint uint_3;

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
