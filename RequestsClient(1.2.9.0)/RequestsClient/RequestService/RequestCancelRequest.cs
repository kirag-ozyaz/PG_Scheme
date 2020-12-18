using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x0200001C RID: 28
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[MessageContract(IsWrapped = false)]
	public class RequestCancelRequest
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x0000722B File Offset: 0x0000542B
		public RequestCancelRequest()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00007233 File Offset: 0x00005433
		public RequestCancelRequest(RequestCancelRequestBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x04000084 RID: 132
		[MessageBodyMember(Name = "RequestCancel", Namespace = "http://aisgorod.ru/", Order = 0)]
		public RequestCancelRequestBody Body;
	}
}
