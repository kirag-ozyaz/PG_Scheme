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
	// Token: 0x0200000B RID: 11
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DebuggerStepThrough]
	[MessageContract(IsWrapped = false)]
	public class SuccsessRequest
	{
		// Token: 0x060000AB RID: 171 RVA: 0x000050B8 File Offset: 0x000034B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SuccsessRequest()
		{
			while (false)
			{
				object obj = null[0];
			}
			SuccsessRequest.RhuVF4A3YwFAduiv7y();
			base..ctor();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000050D4 File Offset: 0x000034D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SuccsessRequest(SuccsessRequestBody Body)
		{
			while (false)
			{
				object obj = null[0];
			}
			SuccsessRequest.DOBcqWSrwEQCVPKT8a();
			int num;
			if (SuccsessRequest.rJAshdNYdAAGtcQWdP())
			{
				num = 2;
				if (false)
				{
					goto IL_2A;
				}
			}
			else
			{
				num = 3;
			}
			for (;;)
			{
				IL_57:
				switch (num)
				{
				case 0:
				case 2:
					goto IL_2A;
				case 1:
					goto IL_2F;
				case 3:
					goto IL_3F;
				case 4:
					goto IL_80;
				case 5:
					return;
				default:
					num = 4;
					if (!true)
					{
						goto IL_80;
					}
					break;
				}
			}
			return;
			IL_2A:
			SuccsessRequest.RhuVF4A3YwFAduiv7y();
			IL_2F:
			IL_3F:
			base..ctor();
			IL_80:
			this.Body = Body;
			num = 5;
			goto IL_57;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005174 File Offset: 0x00003574
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SuccsessRequest()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000518C File Offset: 0x0000358C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RhuVF4A3YwFAduiv7y()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000051A4 File Offset: 0x000035A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rJAshdNYdAAGtcQWdP()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000051B8 File Offset: 0x000035B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DOBcqWSrwEQCVPKT8a()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x04000031 RID: 49
		[MessageBodyMember(Name = "Succsess", Namespace = "http://aisgorod.ru/", Order = 0)]
		public SuccsessRequestBody Body;
	}
}
