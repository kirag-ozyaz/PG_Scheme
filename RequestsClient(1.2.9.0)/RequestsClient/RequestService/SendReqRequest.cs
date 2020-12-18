using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x02000020 RID: 32
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[MessageContract(IsWrapped = false)]
	public class SendReqRequest
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00007287 File Offset: 0x00005487
		public SendReqRequest()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000728F File Offset: 0x0000548F
		public SendReqRequest(SendReqRequestBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x04000088 RID: 136
		[MessageBodyMember(Name = "SendReq", Namespace = "http://aisgorod.ru/", Order = 0)]
		public SendReqRequestBody Body;
	}
}
