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
	// Token: 0x02000022 RID: 34
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class GetDictTypeRegionResponseBody
	{
		// Token: 0x06000141 RID: 321 RVA: 0x00006930 File Offset: 0x00004D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictTypeRegionResponseBody()
		{
			while (false)
			{
				object obj = null[0];
			}
			GetDictTypeRegionResponseBody.KxeIqhLl8yEurXhgC3q();
			base..ctor();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000694C File Offset: 0x00004D4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictTypeRegionResponseBody(DICTIONARY[] GetDictTypeRegionResult)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num;
			if (GetDictTypeRegionResponseBody.H43IXmLTXJpm3qcQfTH())
			{
				num = 4;
				if (!GetDictTypeRegionResponseBody.H43IXmLTXJpm3qcQfTH())
				{
					goto IL_2A;
				}
			}
			else
			{
				num = 3;
				if (!true)
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
				case 4:
					goto IL_2A;
				case 1:
					goto IL_2F;
				case 2:
					goto IL_80;
				case 3:
					goto IL_41;
				case 5:
					return;
				default:
					num = 2;
					break;
				}
			}
			return;
			IL_2A:
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			IL_2F:
			IL_41:
			base..ctor();
			IL_80:
			this.GetDictTypeRegionResult = GetDictTypeRegionResult;
			num = 5;
			goto IL_59;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000069EC File Offset: 0x00004DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetDictTypeRegionResponseBody()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006A04 File Offset: 0x00004E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KxeIqhLl8yEurXhgC3q()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006A1C File Offset: 0x00004E1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H43IXmLTXJpm3qcQfTH()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00006A30 File Offset: 0x00004E30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O53ORYLHpB8ERkGTfBf()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x04000046 RID: 70
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public DICTIONARY[] GetDictTypeRegionResult;
	}
}
