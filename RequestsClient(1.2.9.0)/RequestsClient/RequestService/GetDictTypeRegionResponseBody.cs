using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x0200002F RID: 47
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerStepThrough]
	public class GetDictTypeRegionResponseBody
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x000073B3 File Offset: 0x000055B3
		public GetDictTypeRegionResponseBody()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000073BB File Offset: 0x000055BB
		public GetDictTypeRegionResponseBody(DICTIONARY[] GetDictTypeRegionResult)
		{
			this.GetDictTypeRegionResult = GetDictTypeRegionResult;
		}

		// Token: 0x04000094 RID: 148
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public DICTIONARY[] GetDictTypeRegionResult;
	}
}
