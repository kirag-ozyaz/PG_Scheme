using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x02000038 RID: 56
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[MessageContract(IsWrapped = false)]
	public class GetAddressElementRequest
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00007464 File Offset: 0x00005664
		public GetAddressElementRequest()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000746C File Offset: 0x0000566C
		public GetAddressElementRequest(GetAddressElementRequestBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x0400009B RID: 155
		[MessageBodyMember(Name = "GetAddressElement", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetAddressElementRequestBody Body;
	}
}
