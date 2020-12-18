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
	// Token: 0x02000023 RID: 35
	[DebuggerStepThrough]
	[MessageContract(IsWrapped = false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDictStatusRequest
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00006A44 File Offset: 0x00004E44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictStatusRequest()
		{
			while (false)
			{
				object obj = null[0];
			}
			GetDictStatusRequest.XaTpm7L1aXiB005ytop();
			GetDictStatusRequest.Ys2F6WLGYy0pXXdna6R(this);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00006A60 File Offset: 0x00004E60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictStatusRequest(GetDictStatusRequestBody Body)
		{
			while (false)
			{
				object obj = null[0];
			}
			GetDictStatusRequest.SVysf1LQgXuKIVIDGsp();
			int num;
			if (GetDictStatusRequest.nVivfWL7lDhEi8Bllta())
			{
				num = 3;
				if (!GetDictStatusRequest.SVysf1LQgXuKIVIDGsp())
				{
				}
			}
			else
			{
				num = 4;
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 3:
					HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
					num = 1;
					if (!GetDictStatusRequest.SVysf1LQgXuKIVIDGsp())
					{
						continue;
					}
					break;
				case 1:
					base..ctor();
					break;
				case 5:
					return;
				}
				IL_8C:
				this.Body = Body;
				num = 5;
				if (false)
				{
					break;
				}
				continue;
				goto IL_8C;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006B0C File Offset: 0x00004F0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetDictStatusRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006B24 File Offset: 0x00004F24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XaTpm7L1aXiB005ytop()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006B3C File Offset: 0x00004F3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ys2F6WLGYy0pXXdna6R(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006B58 File Offset: 0x00004F58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nVivfWL7lDhEi8Bllta()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00006B6C File Offset: 0x00004F6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SVysf1LQgXuKIVIDGsp()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x04000047 RID: 71
		[MessageBodyMember(Name = "GetDictStatus", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictStatusRequestBody Body;
	}
}
