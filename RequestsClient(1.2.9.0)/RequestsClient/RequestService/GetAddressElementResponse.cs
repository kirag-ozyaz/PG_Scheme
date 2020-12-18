using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x0200003A RID: 58
	[MessageContract(IsWrapped = false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetAddressElementResponse
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00007492 File Offset: 0x00005692
		public GetAddressElementResponse()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000749A File Offset: 0x0000569A
		public GetAddressElementResponse(GetAddressElementResponseBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x0400009D RID: 157
		[MessageBodyMember(Name = "GetAddressElementResponse", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetAddressElementResponseBody Body;
	}
}
