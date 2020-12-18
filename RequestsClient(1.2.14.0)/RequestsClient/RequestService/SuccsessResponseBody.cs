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
	// Token: 0x0200000E RID: 14
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class SuccsessResponseBody
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00005440 File Offset: 0x00003840
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SuccsessResponseBody()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			base..ctor();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000545C File Offset: 0x0000385C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SuccsessResponseBody(Response SuccsessResult)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num;
			if (SuccsessResponseBody.IPrIr7ZETIiHEWR8c0())
			{
				num = 2;
				if (false)
				{
					goto IL_26;
				}
			}
			else
			{
				num = 3;
				if (!SuccsessResponseBody.IPrIr7ZETIiHEWR8c0())
				{
					goto IL_41;
				}
			}
			for (;;)
			{
				IL_59:
				switch (num)
				{
				case 0:
				case 2:
					goto IL_26;
				case 1:
					goto IL_2B;
				case 3:
					goto IL_41;
				case 4:
					goto IL_80;
				case 5:
					return;
				default:
					num = 4;
					break;
				}
			}
			return;
			IL_26:
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			IL_2B:
			IL_41:
			base..ctor();
			IL_80:
			this.SuccsessResult = SuccsessResult;
			num = 5;
			goto IL_59;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000054FC File Offset: 0x000038FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SuccsessResponseBody()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005514 File Offset: 0x00003914
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IPrIr7ZETIiHEWR8c0()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005528 File Offset: 0x00003928
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tVVj22copKwtsHpBqR()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x04000035 RID: 53
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public Response SuccsessResult;
	}
}
