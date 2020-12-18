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
	// Token: 0x02000010 RID: 16
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[DataContract(Namespace = "http://aisgorod.ru/")]
	[DebuggerStepThrough]
	public class RequestCancelRequestBody
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00005668 File Offset: 0x00003A68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequestCancelRequestBody()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			RequestCancelRequestBody.ukkrOMWr7SAabIKWlkA(this);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005684 File Offset: 0x00003A84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequestCancelRequestBody(long RequestId)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 1:
					base..ctor();
					break;
				case 4:
					HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
					num = ((!RequestCancelRequestBody.ItjSCyWjiV4KqIAev6A()) ? 3 : 0);
					continue;
				case 5:
					return;
				}
				IL_78:
				this.RequestId = RequestId;
				num = 5;
				continue;
				goto IL_78;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000571C File Offset: 0x00003B1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RequestCancelRequestBody()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005734 File Offset: 0x00003B34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ukkrOMWr7SAabIKWlkA(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005750 File Offset: 0x00003B50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ItjSCyWjiV4KqIAev6A()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005764 File Offset: 0x00003B64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eywIGuWXXLIplevWv5c()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x04000037 RID: 55
		[DataMember(Order = 0)]
		public long RequestId;
	}
}
