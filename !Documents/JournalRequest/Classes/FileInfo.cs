using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Documents.Classes
{
    public static class FileInfo
    {
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
        };
        [DllImport("shell32.dll")]
        public static extern int SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, int cbfileInfo, uint uFlags);

        private static uint SHGFI_ICON = 0x100; // get icon
       /* private static uint SHGFI_DISPLAYNAME = 0x200; // get display name
        private static uint SHGFI_TYPENAME = 0x400; // get type name
        private static uint SHGFI_ATTRIBUTES = 0x800; // get attributes
        private static uint SHGFI_ICONLOCATION = 0x1000; // get icon location
        private static uint SHGFI_EXETYPE = 0x2000; // return exe type
        private static uint SHGFI_SYSICONINDEX = 0x4000; // get system icon index
        private static uint SHGFI_LINKOVERLAY = 0x8000; // put a link overlay on icon
        private static uint SHGFI_SELECTED = 0x10000; // show icon in selected state*/
        private static uint SHGFI_LARGEICON = 0x0; // get large icon
        /*private static uint SHGFI_SMALLICON = 0x1; // get small icon
        private static uint SHGFI_OPENICON = 0x2; // get open icon
        private static uint SHGFI_SHELLICONSIZE = 0x4; // get shell size icon
        private static uint SHGFI_PIDL = 0x8; // pszPath is a pidl*/
        private static uint SHGFI_USEFILEATTRIBUTES = 0x10; // use passed dwFileAttribute
        private static uint FILE_ATTRIBUTE_NORMAL = 0x80;
        public static Icon IconOfFile(string FileName)
        {
            SHFILEINFO info = new SHFILEINFO();

            uint flags = SHGFI_USEFILEATTRIBUTES | SHGFI_ICON;
            flags |= SHGFI_LARGEICON;

            int retval = SHGetFileInfo(FileName, FILE_ATTRIBUTE_NORMAL, ref info, System.Runtime.InteropServices.Marshal.SizeOf(info), flags);
            if (retval == 0)
            {
                return null; // error occured
            }

            return System.Drawing.Icon.FromHandle(info.hIcon);
        }
    }
}
