using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

// Token: 0x02000004 RID: 4
internal class a : ICertificatePolicy
{
	// Token: 0x06000011 RID: 17 RVA: 0x000021CC File Offset: 0x000003CC
	public bool CheckValidationResult(ServicePoint sPoint, X509Certificate cert, WebRequest wRequest, int certProb)
	{
		return true;
	}
}
