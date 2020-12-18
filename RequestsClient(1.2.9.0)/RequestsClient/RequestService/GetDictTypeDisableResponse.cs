using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x0200002A RID: 42
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[MessageContract(IsWrapped = false)]
	[DebuggerStepThrough]
	public class GetDictTypeDisableResponse
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x0000734F File Offset: 0x0000554F
		public GetDictTypeDisableResponse()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00007357 File Offset: 0x00005557
		public GetDictTypeDisableResponse(GetDictTypeDisableResponseBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x04000090 RID: 144
		[MessageBodyMember(Name = "GetDictTypeDisableResponse", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictTypeDisableResponseBody Body;
	}
}
