using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x0200002C RID: 44
	[MessageContract(IsWrapped = false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DebuggerStepThrough]
	public class GetDictTypeRegionRequest
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x0000737D File Offset: 0x0000557D
		public GetDictTypeRegionRequest()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00007385 File Offset: 0x00005585
		public GetDictTypeRegionRequest(GetDictTypeRegionRequestBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x04000092 RID: 146
		[MessageBodyMember(Name = "GetDictTypeRegion", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictTypeRegionRequestBody Body;
	}
}
