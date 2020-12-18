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
	// Token: 0x02000026 RID: 38
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DebuggerStepThrough]
	public class GetDictStatusResponseBody
	{
		// Token: 0x0600015A RID: 346 RVA: 0x00006D2C File Offset: 0x0000512C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictStatusResponseBody()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			GetDictStatusResponseBody.NuSSmmLm0Er8sR8Rh2e(this);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00006D48 File Offset: 0x00005148
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictStatusResponseBody(DICTIONARY[] GetDictStatusResult)
		{
			while (false)
			{
				object obj = null[0];
			}
			GetDictStatusResponseBody.FlVNiWLPXCLNGjgSNil();
			int num;
			if (GetDictStatusResponseBody.iCTkVCLFWJ27CPxHEAg())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (GetDictStatusResponseBody.FlVNiWLPXCLNGjgSNil())
				{
					goto IL_43;
				}
			}
			for (;;)
			{
				IL_5B:
				switch (num)
				{
				case 0:
				case 4:
					goto IL_28;
				case 1:
					goto IL_2D;
				case 2:
					goto IL_82;
				case 3:
					goto IL_43;
				case 5:
					return;
				default:
					num = 2;
					break;
				}
			}
			IL_28:
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			IL_2D:
			IL_43:
			GetDictStatusResponseBody.NuSSmmLm0Er8sR8Rh2e(this);
			IL_82:
			this.GetDictStatusResult = GetDictStatusResult;
			num = 5;
			if (!GetDictStatusResponseBody.FlVNiWLPXCLNGjgSNil())
			{
				goto IL_5B;
			}
			goto IL_5B;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00006DF4 File Offset: 0x000051F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetDictStatusResponseBody()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			GetDictStatusResponseBody.vKeOa1LgoKfbHcKmnHy();
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00006E0C File Offset: 0x0000520C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NuSSmmLm0Er8sR8Rh2e(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00006E28 File Offset: 0x00005228
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iCTkVCLFWJ27CPxHEAg()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00006E3C File Offset: 0x0000523C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FlVNiWLPXCLNGjgSNil()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00006E50 File Offset: 0x00005250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vKeOa1LgoKfbHcKmnHy()
		{
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x04000049 RID: 73
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public DICTIONARY[] GetDictStatusResult;
	}
}
