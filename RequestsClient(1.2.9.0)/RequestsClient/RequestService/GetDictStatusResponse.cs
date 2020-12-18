using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x02000032 RID: 50
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(IsWrapped = false)]
	public class GetDictStatusResponse
	{
		// Token: 0x060000FE RID: 254 RVA: 0x000073E9 File Offset: 0x000055E9
		public GetDictStatusResponse()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000073F1 File Offset: 0x000055F1
		public GetDictStatusResponse(GetDictStatusResponseBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x04000096 RID: 150
		[MessageBodyMember(Name = "GetDictStatusResponse", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictStatusResponseBody Body;
	}
}
