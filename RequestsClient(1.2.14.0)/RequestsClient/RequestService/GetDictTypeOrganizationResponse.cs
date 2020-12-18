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
	// Token: 0x02000029 RID: 41
	[MessageContract(IsWrapped = false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DebuggerStepThrough]
	public class GetDictTypeOrganizationResponse
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00007004 File Offset: 0x00005404
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictTypeOrganizationResponse()
		{
			while (false)
			{
				object obj = null[0];
			}
			GetDictTypeOrganizationResponse.ckSICcLClBSf8j3rCYl();
			GetDictTypeOrganizationResponse.Vtj7aNL0BPdHZNBDyl4(this);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00007020 File Offset: 0x00005420
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictTypeOrganizationResponse(GetDictTypeOrganizationResponseBody Body)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = (!GetDictTypeOrganizationResponse.tfrgbOL5aVumLNgmevV()) ? 4 : 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 2:
					GetDictTypeOrganizationResponse.ckSICcLClBSf8j3rCYl();
					goto IL_44;
				case 1:
					goto IL_44;
				case 3:
					break;
				case 4:
					goto IL_54;
				case 5:
					return;
				default:
					num = 3;
					continue;
				}
				IL_24:
				this.Body = Body;
				num = 5;
				if (!GetDictTypeOrganizationResponse.LCJ9bZLvD8V6KISdAU2())
				{
					continue;
				}
				continue;
				IL_54:
				GetDictTypeOrganizationResponse.Vtj7aNL0BPdHZNBDyl4(this);
				goto IL_24;
				IL_44:
				goto IL_54;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000070C0 File Offset: 0x000054C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetDictTypeOrganizationResponse()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000070D8 File Offset: 0x000054D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ckSICcLClBSf8j3rCYl()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000070F0 File Offset: 0x000054F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Vtj7aNL0BPdHZNBDyl4(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000710C File Offset: 0x0000550C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tfrgbOL5aVumLNgmevV()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00007120 File Offset: 0x00005520
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LCJ9bZLvD8V6KISdAU2()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x0400004B RID: 75
		[MessageBodyMember(Name = "GetDictTypeOrganizationResponse", Namespace = "http://aisgorod.ru/", Order = 0)]
		public GetDictTypeOrganizationResponseBody Body;
	}
}
