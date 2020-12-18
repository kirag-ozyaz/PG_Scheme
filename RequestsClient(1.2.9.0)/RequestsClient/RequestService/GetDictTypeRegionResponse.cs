using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x0200002E RID: 46
	[MessageContract(IsWrapped = false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDictTypeRegionResponse
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x0000739C File Offset: 0x0000559C
		public GetDictTypeRegionResponse()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000073A4 File Offset: 0x000055A4
		public GetDictTypeRegionResponse(GetDictTypeRegionResponseBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x04000093 RID: 147
		[MessageBodyMember(Name = "GetDictTypeRegionResponse", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictTypeRegionResponseBody Body;
	}
}
