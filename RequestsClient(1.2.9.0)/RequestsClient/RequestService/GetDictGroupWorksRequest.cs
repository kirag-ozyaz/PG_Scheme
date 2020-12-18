using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x02000024 RID: 36
	[MessageContract(IsWrapped = false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDictGroupWorksRequest
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x000072E3 File Offset: 0x000054E3
		public GetDictGroupWorksRequest()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000072EB File Offset: 0x000054EB
		public GetDictGroupWorksRequest(GetDictGroupWorksRequestBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x0400008C RID: 140
		[MessageBodyMember(Name = "GetDictGroupWorks", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictGroupWorksRequestBody Body;
	}
}
