using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Library
{
    class FileInfo
    {
        private static uint FILE_ATTRIBUTE_NORMAL = 0x80;
        private static uint SHGFI_ICON = 0x100;
        private static uint SHGFI_LARGEICON = 0;
        private static uint SHGFI_USEFILEATTRIBUTES = 0x10;

        public static Icon IconOfFile(string FileName)
        {
            SHFILEINFO psfi = new SHFILEINFO();
            uint uFlags = SHGFI_USEFILEATTRIBUTES | SHGFI_ICON;
            uFlags |= SHGFI_LARGEICON;
            if (SHGetFileInfo(FileName, FILE_ATTRIBUTE_NORMAL, ref psfi, Marshal.SizeOf(psfi), uFlags) == 0)
            {
                return null;
            }
            return Icon.FromHandle(psfi.hIcon);
        }

        [DllImport("shell32.dll")]
        public static extern int SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, int cbfileInfo, uint uFlags);

        [StructLayout(LayoutKind.Sequential)]
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