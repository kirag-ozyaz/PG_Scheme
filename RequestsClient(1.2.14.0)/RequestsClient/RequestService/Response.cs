using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using HsEXfKsq15GfPw4kPLQ;
using j5c8XXscsIc6vD2Fg4l;
using WTbxUfsXa34kJl1qKMV;

namespace RequestsClient.RequestService
{
	// Token: 0x02000003 RID: 3
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DebuggerStepThrough]
	[DataContract(Name = "Response", Namespace = "http://aisgorod.ru/")]
	[Serializable]
	public class Response : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000468
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002080 File Offset: 0x00000480
		[Browsable(false)]
		public ExtensionDataObject ExtensionData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.dNa3vdQtH;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				this.dNa3vdQtH = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002098 File Offset: 0x00000498
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000020B0 File Offset: 0x000004B0
		[DataMember(IsRequired = true)]
		public int Code
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.qrHIGLQwO;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (this.qrHIGLQwO.Equals(value))
						{
							return;
						}
						if (!Response.psf9uTrkEwSNqe0thJ())
						{
							num = 3;
							continue;
						}
						num = 4;
						if (false)
						{
							return;
						}
						continue;
					case 1:
					case 4:
						this.qrHIGLQwO = value;
						break;
					case 5:
						return;
					}
					IL_18:
					this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(0));
					num = 5;
					continue;
					goto IL_18;
				}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002160 File Offset: 0x00000560
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002178 File Offset: 0x00000578
		[DataMember(EmitDefaultValue = false)]
		public string Message
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.crTgvaSsF;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				Response.psf9uTrkEwSNqe0thJ();
				int num;
				if (!Response.Co2VUenGOpp2Ro54Q0())
				{
					num = 4;
				}
				else
				{
					num = 1;
					if (Response.Co2VUenGOpp2Ro54Q0())
					{
						goto IL_74;
					}
				}
				for (;;)
				{
					IL_41:
					switch (num)
					{
					case 0:
					case 4:
						goto IL_74;
					case 3:
						this.crTgvaSsF = value;
						break;
					case 5:
						return;
					}
					IL_8A:
					this.RaisePropertyChanged(Response.KNMykw2fm9LJJ2hD9t(12));
					num = 5;
					continue;
					goto IL_8A;
				}
				IL_74:
				if (this.crTgvaSsF != value)
				{
					num = 3;
					goto IL_41;
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000222C File Offset: 0x0000062C
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002244 File Offset: 0x00000644
		[DataMember(IsRequired = true)]
		public long RequestId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.KcLeZqjC7;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (this.KcLeZqjC7.Equals(value))
						{
							return;
						}
						if (Response.Co2VUenGOpp2Ro54Q0())
						{
							num = 3;
							continue;
						}
						num = 4;
						if (!Response.psf9uTrkEwSNqe0thJ())
						{
							return;
						}
						continue;
					case 1:
					case 4:
						this.KcLeZqjC7 = value;
						break;
					case 5:
						return;
					}
					IL_5E:
					this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(30));
					num = 5;
					continue;
					goto IL_5E;
				}
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000A RID: 10 RVA: 0x000022F8 File Offset: 0x000006F8
		// (remove) Token: 0x0600000B RID: 11 RVA: 0x000023BC File Offset: 0x000007BC
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					object obj = null[0];
				}
				int num = 3;
				for (;;)
				{
					PropertyChangedEventHandler propertyChangedEventHandler;
					switch (num)
					{
					case 0:
					case 1:
						goto IL_84;
					case 2:
						goto IL_93;
					case 3:
						propertyChangedEventHandler = this.gkqnoLQFc;
						Response.Co2VUenGOpp2Ro54Q0();
						num = ((!Response.psf9uTrkEwSNqe0thJ()) ? 5 : 0);
						continue;
					case 4:
						break;
					case 5:
						goto IL_39;
					case 6:
						return;
					default:
						num = 4;
						continue;
					}
					IL_A3:
					PropertyChangedEventHandler propertyChangedEventHandler2;
					if (propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						num = 6;
						continue;
					}
					goto IL_84;
					IL_39:
					PropertyChangedEventHandler value2;
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.gkqnoLQFc, value2, propertyChangedEventHandler2);
					goto IL_A3;
					IL_93:
					goto IL_39;
					IL_84:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					value2 = (PropertyChangedEventHandler)Response.RuveSvTRjea83JspbA(propertyChangedEventHandler2, value);
					goto IL_93;
				}
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					object obj = null[0];
				}
				int num = 0;
				for (;;)
				{
					IL_69:
					PropertyChangedEventHandler propertyChangedEventHandler;
					PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_2B;
					case 1:
					case 2:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler, value);
						propertyChangedEventHandler2 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.gkqnoLQFc, value2, propertyChangedEventHandler);
						goto IL_8A;
					}
					default:
						goto IL_8A;
					case 4:
						goto IL_18;
					case 5:
						break;
					case 6:
						return;
					}
					for (;;)
					{
						IL_9C:
						propertyChangedEventHandler = propertyChangedEventHandler2;
						if (!Response.Co2VUenGOpp2Ro54Q0())
						{
							break;
						}
						num = 4;
						if (true)
						{
							goto IL_69;
						}
					}
					num = 1;
					continue;
					IL_18:
					if (propertyChangedEventHandler2 != propertyChangedEventHandler)
					{
						goto IL_9C;
					}
					num = 6;
					if (true)
					{
						continue;
					}
					IL_2B:
					propertyChangedEventHandler2 = this.gkqnoLQFc;
					num = 5;
					continue;
					IL_8A:
					goto IL_18;
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002480 File Offset: 0x00000880
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RaisePropertyChanged(string propertyName)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num;
			if (Response.psf9uTrkEwSNqe0thJ())
			{
				num = 3;
				if (!true)
				{
					goto IL_26;
				}
			}
			else
			{
				num = 2;
			}
			for (;;)
			{
				IL_3E:
				switch (num)
				{
				case 0:
				case 3:
					goto IL_65;
				case 1:
					goto IL_6C;
				case 2:
					goto IL_26;
				case 4:
					goto IL_7C;
				case 5:
					return;
				default:
					num = 4;
					break;
				}
			}
			IL_65:
			PropertyChangedEventHandler propertyChangedEventHandler = this.gkqnoLQFc;
			IL_6C:
			IL_26:
			if (propertyChangedEventHandler == null)
			{
				return;
			}
			IL_7C:
			propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			num = 5;
			goto IL_3E;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002520 File Offset: 0x00000920
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Response()
		{
			while (false)
			{
				object obj = null[0];
			}
			Response.ySpv5mHFMdFoyTkfA9();
			base..ctor();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000253C File Offset: 0x0000093C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Response()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			Response.mOGMkPlKMlQH1pw8OG();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002554 File Offset: 0x00000954
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool psf9uTrkEwSNqe0thJ()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002568 File Offset: 0x00000968
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Co2VUenGOpp2Ro54Q0()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000257C File Offset: 0x0000097C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KNMykw2fm9LJJ2hD9t(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(\u0020);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002598 File Offset: 0x00000998
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RuveSvTRjea83JspbA(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Delegate.Combine(A_0, A_1);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000025B8 File Offset: 0x000009B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ySpv5mHFMdFoyTkfA9()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000025D0 File Offset: 0x000009D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mOGMkPlKMlQH1pw8OG()
		{
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x04000001 RID: 1
		[NonSerialized]
		private ExtensionDataObject dNa3vdQtH;

		// Token: 0x04000002 RID: 2
		private int qrHIGLQwO;

		// Token: 0x04000003 RID: 3
		[OptionalField]
		private string crTgvaSsF;

		// Token: 0x04000004 RID: 4
		private long KcLeZqjC7;

		// Token: 0x04000005 RID: 5
		[CompilerGenerated]
		private PropertyChangedEventHandler gkqnoLQFc;
	}
}
