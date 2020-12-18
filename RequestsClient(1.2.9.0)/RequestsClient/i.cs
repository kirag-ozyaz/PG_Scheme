using System;
using System.Drawing;
using System.Runtime.InteropServices;

// Token: 0x0200000E RID: 14
internal static class i
{
	// Token: 0x0600005D RID: 93
	[DllImport("shell32.dll")]
	internal static extern int SHGetFileInfo(string A_0, uint A_1, ref i.a A_2, int A_3, uint A_4);

	// Token: 0x0600005E RID: 94 RVA: 0x000067B0 File Offset: 0x000049B0
	internal static Icon a(string FileName)
	{
		i.a a = default(i.a);
		uint num = i.c | i.a;
		num |= i.b;
		if (i.SHGetFileInfo(FileName, i.d, ref a, Marshal.SizeOf(a), num) == 0)
		{
			return null;
		}
		return Icon.FromHandle(a.a);
	}

	// Token: 0x0400004B RID: 75
	internal static uint a = 256u;

	// Token: 0x0400004C RID: 76
	private static uint b = 0u;

	// Token: 0x0400004D RID: 77
	private static uint c = 16u;

	// Token: 0x0400004E RID: 78
	private static uint d = 128u;

	// Token: 0x0200000F RID: 15
	internal struct a
	{
		// Token: 0x0400004F RID: 79
		public IntPtr a;

		// Token: 0x04000050 RID: 80
		public IntPtr b;

		// Token: 0x04000051 RID: 81
		public uint c;

		// Token: 0x04000052 RID: 82
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string d;

		// Token: 0x04000053 RID: 83
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string e;
	}
}
