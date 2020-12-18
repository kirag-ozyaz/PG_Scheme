using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x0200003B RID: 59
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class GetAddressElementResponseBody
	{
		// Token: 0x0600010F RID: 271 RVA: 0x000074A9 File Offset: 0x000056A9
		public GetAddressElementResponseBody()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000074B1 File Offset: 0x000056B1
		public GetAddressElementResponseBody(AddressElement[] GetAddressElementResult)
		{
			this.GetAddressElementResult = GetAddressElementResult;
		}

		// Token: 0x0400009E RID: 158
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public AddressElement[] GetAddressElementResult;
	}
}
