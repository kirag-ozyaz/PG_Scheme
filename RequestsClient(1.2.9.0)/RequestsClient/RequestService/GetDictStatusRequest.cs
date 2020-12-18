using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x02000030 RID: 48
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[MessageContract(IsWrapped = false)]
	public class GetDictStatusRequest
	{
		// Token: 0x060000FB RID: 251 RVA: 0x000073CA File Offset: 0x000055CA
		public GetDictStatusRequest()
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000073D2 File Offset: 0x000055D2
		public GetDictStatusRequest(GetDictStatusRequestBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x04000095 RID: 149
		[MessageBodyMember(Name = "GetDictStatus", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictStatusRequestBody Body;
	}
}
