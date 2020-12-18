using System.Net;
using System.Security.Cryptography.X509Certificates;

internal class CertificatePolicy : ICertificatePolicy
{
	public bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem)
	{
		return true;
	}
}
