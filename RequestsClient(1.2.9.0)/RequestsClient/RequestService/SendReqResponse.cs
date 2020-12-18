using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x02000022 RID: 34
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(IsWrapped = false)]
	public class SendReqResponse
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x000072B5 File Offset: 0x000054B5
		public SendReqResponse()
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000072BD File Offset: 0x000054BD
		public SendReqResponse(SendReqResponseBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x0400008A RID: 138
		[MessageBodyMember(Name = "SendReqResponse", Namespace = "http://aisgorod.ru/", Order = 0)]
		public SendReqResponseBody Body;
	}
}
