using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000019 RID: 25
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class SuccsessRequestBody
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x000071DF File Offset: 0x000053DF
		public SuccsessRequestBody()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000071E7 File Offset: 0x000053E7
		public SuccsessRequestBody(long RequestId, DateTime DateEnd)
		{
			this.RequestId = RequestId;
			this.DateEnd = DateEnd;
		}

		// Token: 0x04000080 RID: 128
		[DataMember(Order = 0)]
		public long RequestId;

		// Token: 0x04000081 RID: 129
		[DataMember(Order = 1)]
		public DateTime DateEnd;
	}
}
