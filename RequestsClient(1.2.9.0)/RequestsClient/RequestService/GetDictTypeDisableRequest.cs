using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x02000028 RID: 40
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[MessageContract(IsWrapped = false)]
	public class GetDictTypeDisableRequest
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00007330 File Offset: 0x00005530
		public GetDictTypeDisableRequest()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00007338 File Offset: 0x00005538
		public GetDictTypeDisableRequest(GetDictTypeDisableRequestBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x0400008F RID: 143
		[MessageBodyMember(Name = "GetDictTypeDisable", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictTypeDisableRequestBody Body;
	}
}
