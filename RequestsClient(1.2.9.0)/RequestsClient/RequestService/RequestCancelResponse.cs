using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x0200001E RID: 30
	[DebuggerStepThrough]
	[MessageContract(IsWrapped = false)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class RequestCancelResponse
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00007259 File Offset: 0x00005459
		public RequestCancelResponse()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00007261 File Offset: 0x00005461
		public RequestCancelResponse(RequestCancelResponseBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x04000086 RID: 134
		[MessageBodyMember(Name = "RequestCancelResponse", Namespace = "http://aisgorod.ru/", Order = 0)]
		public RequestCancelResponseBody Body;
	}
}
