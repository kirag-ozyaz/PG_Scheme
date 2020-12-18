using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000033 RID: 51
	[DebuggerStepThrough]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDictStatusResponseBody
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00007400 File Offset: 0x00005600
		public GetDictStatusResponseBody()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00007408 File Offset: 0x00005608
		public GetDictStatusResponseBody(DICTIONARY[] GetDictStatusResult)
		{
			this.GetDictStatusResult = GetDictStatusResult;
		}

		// Token: 0x04000097 RID: 151
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public DICTIONARY[] GetDictStatusResult;
	}
}
