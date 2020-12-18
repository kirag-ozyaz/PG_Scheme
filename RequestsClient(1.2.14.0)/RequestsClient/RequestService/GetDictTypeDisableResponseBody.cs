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
	// Token: 0x0200001E RID: 30
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class GetDictTypeDisableResponseBody
	{
		// Token: 0x06000128 RID: 296 RVA: 0x00006550 File Offset: 0x00004950
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictTypeDisableResponseBody()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			GetDictTypeDisableResponseBody.Nn3yDNWIF7okOEfosBQ(this);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000656C File Offset: 0x0000496C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetDictTypeDisableResponseBody(DICTIONARY[] GetDictTypeDisableResult)
		{
			while (false)
			{
				object obj = null[0];
			}
			GetDictTypeDisableResponseBody.dhWNoAWJEW8tFUy2dbn();
			int num;
			if (GetDictTypeDisableResponseBody.OhivfsWUadDFx9Y68LU())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (GetDictTypeDisableResponseBody.dhWNoAWJEW8tFUy2dbn())
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
					goto IL_43;
				case 3:
					goto IL_84;
				case 5:
					return;
				default:
					num = 3;
					if (false)
					{
						goto IL_84;
					}
					break;
				}
			}
			IL_28:
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			IL_2D:
			IL_43:
			base..ctor();
			IL_84:
			this.GetDictTypeDisableResult = GetDictTypeDisableResult;
			num = 5;
			goto IL_5B;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006610 File Offset: 0x00004A10
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GetDictTypeDisableResponseBody()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			GetDictTypeDisableResponseBody.tmc9NiWZtGbRqxQG6tk();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006628 File Offset: 0x00004A28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Nn3yDNWIF7okOEfosBQ(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00006644 File Offset: 0x00004A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OhivfsWUadDFx9Y68LU()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00006658 File Offset: 0x00004A58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dhWNoAWJEW8tFUy2dbn()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000666C File Offset: 0x00004A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tmc9NiWZtGbRqxQG6tk()
		{
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x04000043 RID: 67
		[DataMember(EmitDefaultValue = false, Order = 0)]
		public DICTIONARY[] GetDictTypeDisableResult;
	}
}
