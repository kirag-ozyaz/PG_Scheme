using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using j5c8XXscsIc6vD2Fg4l;
using WTbxUfsXa34kJl1qKMV;

namespace RequestsClient.RequestService
{
	// Token: 0x0200002B RID: 43
	[MessageContract(IsWrapped = false)]
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class GetAddressElementRequest
	{
		// Token: 0x0600017A RID: 378 RVA: 0x00007248 File Offset: 0x00005648
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetAddressElementRequest()
		{
			while (false)
			{
				object obj = null[0];
			}
			GetAddressElementRequest.BS3gqxLa9lgqYwTGxRq();
			base..ctor();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00007264 File Offset: 0x00005664
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetAddressElementRequest(GetAddressElementRequestBody Body)
		{
			while (false)
			{
				object obj = null[0];
			}
			GetAddressElementRequest.oi9sHZLYZ9ICZDDJQci();
			int num;
			if (!GetAddressElementRequest.oeifljLu7BXpPWl33Ij())
			{
				num = 4;
			}
			else
			{
				num = 1;
				if (!GetAddressElementRequest.oi9sHZLYZ9ICZDDJQci())
				{
					goto IL_73;
				}
			}
			for (;;)
			{
				IL_40:
				switch (num)
				{
				case 0:
				case 4:
					goto IL_73;
				case 3:
					base..ctor();
					break;
				case 5:
					return;
				}
				IL_82:
				this.Body = Body;
				num = 5;
				continue;
				goto IL_82;
			}
			return;
			IL_73:
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			num = 3;
			goto IL_40;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00007304 File Offset: 0x00005704
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetAddressElementRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000731C File Offset: 0x0000571C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BS3gqxLa9lgqYwTGxRq()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00007334 File Offset: 0x00005734
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oi9sHZLYZ9ICZDDJQci()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00007348 File Offset: 0x00005748
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oeifljLu7BXpPWl33Ij()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x0400004D RID: 77
		[MessageBodyMember(Name = "GetAddressElement", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetAddressElementRequestBody Body;
	}
}
