using System;
using System.IO;
using System.Reflection;
using System.Text;

// Token: 0x0200000B RID: 11
internal class f
{
	// Token: 0x06000046 RID: 70 RVA: 0x000044BD File Offset: 0x000026BD
	private f()
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x000044C8 File Offset: 0x000026C8
	public static StreamReader b(Assembly A_0, string A_1)
	{
		foreach (string text in A_0.GetManifestResourceNames())
		{
			if (text.EndsWith(A_1))
			{
				return new StreamReader(A_0.GetManifestResourceStream(text), Encoding.GetEncoding(1251));
			}
		}
		return null;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00004510 File Offset: 0x00002710
	public static string a(Assembly A_0, string A_1)
	{
		StreamReader streamReader = f.b(A_0, A_1);
		string result = streamReader.ReadToEnd();
		streamReader.Close();
		return result;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00004531 File Offset: 0x00002731
	public static string a(string name)
	{
		return f.a(typeof(f).Assembly, name);
	}
}
