using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x0200001A RID: 26
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(IsWrapped = false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class SuccsessResponse
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x000071FD File Offset: 0x000053FD
		public SuccsessResponse()
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00007205 File Offset: 0x00005405
		public SuccsessResponse(SuccsessResponseBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x04000082 RID: 130
		[MessageBodyMember(Name = "SuccsessResponse", Namespace = "http://aisgorod.ru/", Order = 0)]
		public SuccsessResponseBody Body;
	}
}
