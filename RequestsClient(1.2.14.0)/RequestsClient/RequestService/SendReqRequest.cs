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
	// Token: 0x02000013 RID: 19
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[MessageContract(IsWrapped = false)]
	[DebuggerStepThrough]
	public class SendReqRequest
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x000059EC File Offset: 0x00003DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SendReqRequest()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			base..ctor();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005A08 File Offset: 0x00003E08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SendReqRequest(SendReqRequestBody Body)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num;
			if (SendReqRequest.DwaIdeW4HobbGqyb1Tw())
			{
				num = 4;
				if (!true)
				{
					goto IL_26;
				}
			}
			else
			{
				num = 2;
			}
			for (;;)
			{
				IL_6A:
				switch (num)
				{
				case 0:
				case 4:
					goto IL_3D;
				case 1:
					goto IL_42;
				case 2:
					goto IL_52;
				case 3:
					goto IL_26;
				case 5:
					return;
				default:
					num = 3;
					if (false)
					{
						return;
					}
					break;
				}
			}
			return;
			IL_26:
			this.Body = Body;
			num = 5;
			if (SendReqRequest.DwaIdeW4HobbGqyb1Tw())
			{
				goto IL_6A;
			}
			IL_3D:
			SendReqRequest.K97v1sWwWeRQcFX3Mcs();
			IL_42:
			IL_52:
			base..ctor();
			goto IL_26;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005AA8 File Offset: 0x00003EA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SendReqRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005AC0 File Offset: 0x00003EC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DwaIdeW4HobbGqyb1Tw()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005AD4 File Offset: 0x00003ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pRtMsLWtQUvvj9Zhx8g()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005AE8 File Offset: 0x00003EE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void K97v1sWwWeRQcFX3Mcs()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x0400003A RID: 58
		[MessageBodyMember(Name = "SendReq", Namespace = "http://aisgorod.ru/", Order = 0)]
		public SendReqRequestBody Body;
	}
}
