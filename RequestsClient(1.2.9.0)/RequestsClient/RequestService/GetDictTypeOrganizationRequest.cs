using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x02000034 RID: 52
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DebuggerStepThrough]
	[MessageContract(IsWrapped = false)]
	public class GetDictTypeOrganizationRequest
	{
		// Token: 0x06000102 RID: 258 RVA: 0x00007417 File Offset: 0x00005617
		public GetDictTypeOrganizationRequest()
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000741F File Offset: 0x0000561F
		public GetDictTypeOrganizationRequest(GetDictTypeOrganizationRequestBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x04000098 RID: 152
		[MessageBodyMember(Name = "GetDictTypeOrganization", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictTypeOrganizationRequestBody Body;
	}
}
