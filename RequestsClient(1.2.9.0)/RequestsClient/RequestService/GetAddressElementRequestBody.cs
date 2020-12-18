using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000039 RID: 57
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	public class GetAddressElementRequestBody
	{
		// Token: 0x0600010B RID: 267 RVA: 0x0000747B File Offset: 0x0000567B
		public GetAddressElementRequestBody()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00007483 File Offset: 0x00005683
		public GetAddressElementRequestBody(long? parentId)
		{
			this.parentId = parentId;
		}

		// Token: 0x0400009C RID: 156
		[DataMember(Order = 0)]
		public long? parentId;
	}
}
