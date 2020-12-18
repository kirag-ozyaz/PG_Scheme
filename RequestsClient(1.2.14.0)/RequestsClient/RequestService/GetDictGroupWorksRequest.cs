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
	// Token: 0x02000017 RID: 23
	[MessageContract(IsWrapped = false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDictGroupWorksRequest
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00005E94 File Offset: 0x00004294
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictGroupWorksRequest()
		{
			while (false)
			{
				object obj = null[0];
			}
			GetDictGroupWorksRequest.lGCbxIWMmH9BbMpRA5j();
			GetDictGroupWorksRequest.pa1cWGW5FCr5bAHO8TD(this);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005EB0 File Offset: 0x000042B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictGroupWorksRequest(GetDictGroupWorksRequestBody Body)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 4;
			if (!true)
			{
				goto IL_1A;
			}
			for (;;)
			{
				IL_43:
				switch (num)
				{
				case 0:
					goto IL_1A;
				case 1:
				case 3:
					goto IL_2B;
				default:
					goto IL_60;
				case 4:
					HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
					GetDictGroupWorksRequest.sTCQS3We6Fk0l2OoyPp();
					num = ((!GetDictGroupWorksRequest.sDmUtfWiGhP8tmPpmKN()) ? 0 : 3);
					break;
				case 5:
					return;
				}
			}
			IL_2B:
			base..ctor();
			IL_60:
			IL_1A:
			this.Body = Body;
			num = 5;
			goto IL_43;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005F4C File Offset: 0x0000434C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetDictGroupWorksRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005F64 File Offset: 0x00004364
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lGCbxIWMmH9BbMpRA5j()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005F7C File Offset: 0x0000437C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pa1cWGW5FCr5bAHO8TD(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005F98 File Offset: 0x00004398
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sDmUtfWiGhP8tmPpmKN()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00005FAC File Offset: 0x000043AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sTCQS3We6Fk0l2OoyPp()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x0400003E RID: 62
		[MessageBodyMember(Name = "GetDictGroupWorks", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictGroupWorksRequestBody Body;
	}
}
