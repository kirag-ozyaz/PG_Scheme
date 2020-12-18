using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000021 RID: 33
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerStepThrough]
	public class SendReqRequestBody
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x0000729E File Offset: 0x0000549E
		public SendReqRequestBody()
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000072A6 File Offset: 0x000054A6
		public SendReqRequestBody(Request req)
		{
			this.req = req;
		}

		// Token: 0x04000089 RID: 137
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public Request req;
	}
}
