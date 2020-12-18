using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000037 RID: 55
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDictTypeOrganizationResponseBody
	{
		// Token: 0x06000107 RID: 263 RVA: 0x0000744D File Offset: 0x0000564D
		public GetDictTypeOrganizationResponseBody()
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00007455 File Offset: 0x00005655
		public GetDictTypeOrganizationResponseBody(DICTIONARY[] GetDictTypeOrganizationResult)
		{
			this.GetDictTypeOrganizationResult = GetDictTypeOrganizationResult;
		}

		// Token: 0x0400009A RID: 154
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public DICTIONARY[] GetDictTypeOrganizationResult;
	}
}
