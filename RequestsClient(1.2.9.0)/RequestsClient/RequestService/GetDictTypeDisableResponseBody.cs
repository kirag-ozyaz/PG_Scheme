using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x0200002B RID: 43
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	public class GetDictTypeDisableResponseBody
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00007366 File Offset: 0x00005566
		public GetDictTypeDisableResponseBody()
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000736E File Offset: 0x0000556E
		public GetDictTypeDisableResponseBody(DICTIONARY[] GetDictTypeDisableResult)
		{
			this.GetDictTypeDisableResult = GetDictTypeDisableResult;
		}

		// Token: 0x04000091 RID: 145
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public DICTIONARY[] GetDictTypeDisableResult;
	}
}
