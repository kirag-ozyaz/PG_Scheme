using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x0200001B RID: 27
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	public class SuccsessResponseBody
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x00007214 File Offset: 0x00005414
		public SuccsessResponseBody()
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000721C File Offset: 0x0000541C
		public SuccsessResponseBody(Response SuccsessResult)
		{
			this.SuccsessResult = SuccsessResult;
		}

		// Token: 0x04000083 RID: 131
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public Response SuccsessResult;
	}
}
