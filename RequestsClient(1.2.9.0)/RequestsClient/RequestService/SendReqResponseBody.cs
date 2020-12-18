using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000023 RID: 35
	[DebuggerStepThrough]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class SendReqResponseBody
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x000072CC File Offset: 0x000054CC
		public SendReqResponseBody()
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000072D4 File Offset: 0x000054D4
		public SendReqResponseBody(Response SendReqResult)
		{
			this.SendReqResult = SendReqResult;
		}

		// Token: 0x0400008B RID: 139
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public Response SendReqResult;
	}
}
