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
	// Token: 0x02000016 RID: 22
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DebuggerStepThrough]
	public class SendReqResponseBody
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00005D68 File Offset: 0x00004168
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SendReqResponseBody()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			SendReqResponseBody.voh7RiWKHIjkKKbFrPO(this);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005D84 File Offset: 0x00004184
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SendReqResponseBody(Response SendReqResult)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = (!SendReqResponseBody.bdyVDFWRSdCUcBTC6W9()) ? 3 : 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 4:
					goto IL_7A;
				case 1:
					goto IL_7F;
				case 2:
					break;
				case 3:
					goto IL_24;
				case 5:
					return;
				default:
					num = 2;
					continue;
				}
				IL_63:
				this.SendReqResult = SendReqResult;
				num = 5;
				if (!SendReqResponseBody.bdyVDFWRSdCUcBTC6W9())
				{
					goto IL_7A;
				}
				continue;
				IL_24:
				base..ctor();
				goto IL_63;
				IL_7F:
				goto IL_24;
				IL_7A:
				SendReqResponseBody.vJxwJdW9J6HJh3cd7CB();
				goto IL_7F;
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005E20 File Offset: 0x00004220
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SendReqResponseBody()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005E38 File Offset: 0x00004238
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void voh7RiWKHIjkKKbFrPO(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005E54 File Offset: 0x00004254
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bdyVDFWRSdCUcBTC6W9()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005E68 File Offset: 0x00004268
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Eslc8PWEQEKtAAU1odX()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005E7C File Offset: 0x0000427C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vJxwJdW9J6HJh3cd7CB()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x0400003D RID: 61
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public Response SendReqResult;
	}
}
