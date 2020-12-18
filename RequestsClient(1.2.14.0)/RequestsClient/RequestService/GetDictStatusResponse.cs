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
	// Token: 0x02000025 RID: 37
	[DebuggerStepThrough]
	[MessageContract(IsWrapped = false)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class GetDictStatusResponse
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00006C10 File Offset: 0x00005010
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictStatusResponse()
		{
			while (false)
			{
				object obj = null[0];
			}
			GetDictStatusResponse.EUZS0kLbQuxWZ8ietL8();
			base..ctor();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00006C2C File Offset: 0x0000502C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictStatusResponse(GetDictStatusResponseBody Body)
		{
			while (false)
			{
				object obj = null[0];
			}
			GetDictStatusResponse.EMBhNtLdbsCeXWsFFe1();
			int num;
			if (GetDictStatusResponse.jR9eC2Lk6U0ZV7agHto())
			{
				num = 3;
				if (true)
				{
					goto IL_42;
				}
			}
			else
			{
				num = 1;
				if (!GetDictStatusResponse.jR9eC2Lk6U0ZV7agHto())
				{
					goto IL_75;
				}
				goto IL_42;
			}
			IL_2A:
			base..ctor();
			goto IL_5F;
			IL_42:
			switch (num)
			{
			case 0:
			case 3:
				goto IL_8C;
			case 4:
				goto IL_2A;
			case 5:
				return;
			}
			IL_5F:
			IL_75:
			this.Body = Body;
			num = 5;
			if (GetDictStatusResponse.jR9eC2Lk6U0ZV7agHto())
			{
				goto IL_42;
			}
			IL_8C:
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			num = 4;
			goto IL_42;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00006CD4 File Offset: 0x000050D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetDictStatusResponse()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00006CEC File Offset: 0x000050EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EUZS0kLbQuxWZ8ietL8()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00006D04 File Offset: 0x00005104
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jR9eC2Lk6U0ZV7agHto()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00006D18 File Offset: 0x00005118
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EMBhNtLdbsCeXWsFFe1()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x04000048 RID: 72
		[MessageBodyMember(Name = "GetDictStatusResponse", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictStatusResponseBody Body;
	}
}
