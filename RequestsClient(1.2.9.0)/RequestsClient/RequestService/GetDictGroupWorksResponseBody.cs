using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000027 RID: 39
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	public class GetDictGroupWorksResponseBody
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00007319 File Offset: 0x00005519
		public GetDictGroupWorksResponseBody()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00007321 File Offset: 0x00005521
		public GetDictGroupWorksResponseBody(DICTIONARY[] GetDictGroupWorksResult)
		{
			this.GetDictGroupWorksResult = GetDictGroupWorksResult;
		}

		// Token: 0x0400008E RID: 142
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public DICTIONARY[] GetDictGroupWorksResult;
	}
}
