using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x0200001F RID: 31
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerStepThrough]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	public class RequestCancelResponseBody
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00007270 File Offset: 0x00005470
		public RequestCancelResponseBody()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007278 File Offset: 0x00005478
		public RequestCancelResponseBody(Response RequestCancelResult)
		{
			this.RequestCancelResult = RequestCancelResult;
		}

		// Token: 0x04000087 RID: 135
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public Response RequestCancelResult;
	}
}
