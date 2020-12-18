using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x02000036 RID: 54
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(IsWrapped = false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerStepThrough]
	public class GetDictTypeOrganizationResponse
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00007436 File Offset: 0x00005636
		public GetDictTypeOrganizationResponse()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000743E File Offset: 0x0000563E
		public GetDictTypeOrganizationResponse(GetDictTypeOrganizationResponseBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x04000099 RID: 153
		[MessageBodyMember(Name = "GetDictTypeOrganizationResponse", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictTypeOrganizationResponseBody Body;
	}
}
