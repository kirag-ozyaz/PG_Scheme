using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x02000026 RID: 38
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[MessageContract(IsWrapped = false)]
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDictGroupWorksResponse
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00007302 File Offset: 0x00005502
		public GetDictGroupWorksResponse()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000730A File Offset: 0x0000550A
		public GetDictGroupWorksResponse(GetDictGroupWorksResponseBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x0400008D RID: 141
		[MessageBodyMember(Name = "GetDictGroupWorksResponse", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictGroupWorksResponseBody Body;
	}
}
