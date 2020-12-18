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
	// Token: 0x0200000C RID: 12
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class SuccsessRequestBody
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x000051CC File Offset: 0x000035CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SuccsessRequestBody()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			base..ctor();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000051E8 File Offset: 0x000035E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SuccsessRequestBody(long RequestId, DateTime DateEnd)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = (!SuccsessRequestBody.vygfuhsZPcPS4VJ8Wm()) ? 2 : 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 4:
					goto IL_47;
				case 1:
					break;
				case 2:
					break;
				case 3:
					goto IL_34;
				case 5:
					this.RequestId = RequestId;
					goto IL_34;
				case 6:
					return;
				default:
					num = 3;
					if (!SuccsessRequestBody.vygfuhsZPcPS4VJ8Wm())
					{
						return;
					}
					continue;
				}
				IL_24:
				base..ctor();
				num = 5;
				continue;
				IL_4C:
				goto IL_24;
				IL_47:
				SuccsessRequestBody.SD1mgrpRDIylHkcmeI();
				goto IL_4C;
				IL_34:
				this.DateEnd = DateEnd;
				num = 6;
				if (false)
				{
					goto IL_47;
				}
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000529C File Offset: 0x0000369C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SuccsessRequestBody()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000052B4 File Offset: 0x000036B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vygfuhsZPcPS4VJ8Wm()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000052C8 File Offset: 0x000036C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KedNgTfJbev0OEDrDJ()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000052DC File Offset: 0x000036DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SD1mgrpRDIylHkcmeI()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x04000032 RID: 50
		[DataMember(Order = 0)]
		public long RequestId;

		// Token: 0x04000033 RID: 51
		[DataMember(Order = 1)]
		public DateTime DateEnd;
	}
}
