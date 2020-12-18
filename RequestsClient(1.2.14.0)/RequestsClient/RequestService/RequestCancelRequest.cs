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
	// Token: 0x0200000F RID: 15
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(IsWrapped = false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class RequestCancelRequest
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x0000553C File Offset: 0x0000393C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequestCancelRequest()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			base..ctor();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005558 File Offset: 0x00003958
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequestCancelRequest(RequestCancelRequestBody Body)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 1:
				case 4:
					base..ctor();
					break;
				case 3:
					goto IL_2F;
				case 5:
					return;
				}
				IL_18:
				this.Body = Body;
				num = 5;
				if (RequestCancelRequest.aKAfy3z3rTSIqaLuCS())
				{
					continue;
				}
				IL_2F:
				RequestCancelRequest.Df03FyWWVvqIiruX9jQ();
				RequestCancelRequest.aKAfy3z3rTSIqaLuCS();
				num = (RequestCancelRequest.iwPO0TW3xsAH99s11TL() ? 0 : 4);
				continue;
				goto IL_18;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000055F8 File Offset: 0x000039F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RequestCancelRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			RequestCancelRequest.uH1MYWWLkRsMniH5i8r();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005610 File Offset: 0x00003A10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aKAfy3z3rTSIqaLuCS()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005624 File Offset: 0x00003A24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iwPO0TW3xsAH99s11TL()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005638 File Offset: 0x00003A38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Df03FyWWVvqIiruX9jQ()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005650 File Offset: 0x00003A50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uH1MYWWLkRsMniH5i8r()
		{
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x04000036 RID: 54
		[MessageBodyMember(Name = "RequestCancel", Namespace = "http://aisgorod.ru/", Order = 0)]
		public RequestCancelRequestBody Body;
	}
}
