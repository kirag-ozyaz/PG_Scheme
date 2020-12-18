using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j5c8XXscsIc6vD2Fg4l;
using WTbxUfsXa34kJl1qKMV;

namespace RequestsClient.RequestService
{
	// Token: 0x0200002E RID: 46
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class GetAddressElementResponseBody
	{
		// Token: 0x0600018A RID: 394 RVA: 0x000074D0 File Offset: 0x000058D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetAddressElementResponseBody()
		{
			while (false)
			{
				object obj = null[0];
			}
			GetAddressElementResponseBody.zgW4o8LSZQHSHJH4HId();
			GetAddressElementResponseBody.evsTZ1LAkePdMt63k5l(this);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000074EC File Offset: 0x000058EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetAddressElementResponseBody(AddressElement[] GetAddressElementResult)
		{
			while (false)
			{
				object obj = null[0];
			}
			GetAddressElementResponseBody.a6AaMOLNe1WiCgHTWIL();
			int num = (!GetAddressElementResponseBody.oQtRtlL6OarE6vC4WQl()) ? 2 : 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 3:
					GetAddressElementResponseBody.zgW4o8LSZQHSHJH4HId();
					goto IL_6C;
				case 1:
					goto IL_6C;
				case 2:
					goto IL_28;
				case 4:
					break;
				case 5:
					return;
				default:
					num = 4;
					continue;
				}
				IL_7C:
				this.GetAddressElementResult = GetAddressElementResult;
				num = 5;
				if (!GetAddressElementResponseBody.a6AaMOLNe1WiCgHTWIL())
				{
					continue;
				}
				continue;
				IL_28:
				GetAddressElementResponseBody.evsTZ1LAkePdMt63k5l(this);
				goto IL_7C;
				IL_6C:
				goto IL_28;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007590 File Offset: 0x00005990
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetAddressElementResponseBody()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000075A8 File Offset: 0x000059A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zgW4o8LSZQHSHJH4HId()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000075C0 File Offset: 0x000059C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void evsTZ1LAkePdMt63k5l(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000075DC File Offset: 0x000059DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oQtRtlL6OarE6vC4WQl()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000075F0 File Offset: 0x000059F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a6AaMOLNe1WiCgHTWIL()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x04000050 RID: 80
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public AddressElement[] GetAddressElementResult;
	}
}
