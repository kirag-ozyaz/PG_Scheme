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
	// Token: 0x02000015 RID: 21
	[MessageContract(IsWrapped = false)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class SendReqResponse
	{
		// Token: 0x060000EE RID: 238 RVA: 0x00005C44 File Offset: 0x00004044
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SendReqResponse()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			base..ctor();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00005C60 File Offset: 0x00004060
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SendReqResponse(SendReqResponseBody Body)
		{
			while (false)
			{
				object obj = null[0];
			}
			SendReqResponse.BjYjY2WmKiZrus3VZLd();
			int num = (!SendReqResponse.br5BPQWPT3SAR0fv43T()) ? 1 : 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 4:
					goto IL_3F;
				case 3:
					SendReqResponse.jlfpRBWgQfWI11ykNIY(this);
					break;
				case 5:
					return;
				}
				IL_28:
				this.Body = Body;
				num = 5;
				if (!SendReqResponse.BjYjY2WmKiZrus3VZLd())
				{
					continue;
				}
				IL_3F:
				HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
				num = 3;
				if (!SendReqResponse.BjYjY2WmKiZrus3VZLd())
				{
					continue;
				}
				continue;
				goto IL_28;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00005D0C File Offset: 0x0000410C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SendReqResponse()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005D24 File Offset: 0x00004124
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool br5BPQWPT3SAR0fv43T()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00005D38 File Offset: 0x00004138
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BjYjY2WmKiZrus3VZLd()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005D4C File Offset: 0x0000414C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jlfpRBWgQfWI11ykNIY(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x0400003C RID: 60
		[MessageBodyMember(Name = "SendReqResponse", Namespace = "http://aisgorod.ru/", Order = 0)]
		public SendReqResponseBody Body;
	}
}
