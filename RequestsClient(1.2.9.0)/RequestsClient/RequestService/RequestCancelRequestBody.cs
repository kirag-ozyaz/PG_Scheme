using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x0200001D RID: 29
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerStepThrough]
	public class RequestCancelRequestBody
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x00007242 File Offset: 0x00005442
		public RequestCancelRequestBody()
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000724A File Offset: 0x0000544A
		public RequestCancelRequestBody(long RequestId)
		{
			this.RequestId = RequestId;
		}

		// Token: 0x04000085 RID: 133
		[DataMember(Order = 0)]
		public long RequestId;
	}
}
