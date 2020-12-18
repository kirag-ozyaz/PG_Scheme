using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x02000018 RID: 24
	[MessageContract(IsWrapped = false)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class SuccsessRequest
	{
		// Token: 0x060000CE RID: 206 RVA: 0x000071C8 File Offset: 0x000053C8
		public SuccsessRequest()
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000071D0 File Offset: 0x000053D0
		public SuccsessRequest(SuccsessRequestBody Body)
		{
			this.Body = Body;
		}

		// Token: 0x0400007F RID: 127
		[MessageBodyMember(Name = "Succsess", Namespace = "http://aisgorod.ru/", Order = 0)]
		public SuccsessRequestBody Body;
	}
}
