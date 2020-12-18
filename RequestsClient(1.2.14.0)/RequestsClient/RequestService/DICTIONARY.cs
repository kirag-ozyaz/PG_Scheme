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
	// Token: 0x02000008 RID: 8
	[DebuggerStepThrough]
	[DataContract(Name = "DICTIONARY", Namespace = "http://aisgorod.ru/")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class DICTIONARY : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000462C File Offset: 0x00002A2C
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00004644 File Offset: 0x00002A44
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
				return this.BP9TEuicF;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				this.BP9TEuicF = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000465C File Offset: 0x00002A5C
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00004674 File Offset: 0x00002A74
		[DataMember(EmitDefaultValue = false)]
		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.NWUdvEjdI;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				DICTIONARY.m3EPxg5XML9662UcqU();
				int num;
				if (!DICTIONARY.OuBKsbvpkotkI5n7Gs())
				{
					num = 1;
					if (!true)
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
					IL_43:
					switch (num)
					{
					case 0:
					case 1:
						if (this.NWUdvEjdI == value)
						{
							return;
						}
						num = 4;
						break;
					default:
						goto IL_60;
					case 3:
						goto IL_70;
					case 4:
						goto IL_2A;
					case 5:
						return;
					}
				}
				return;
				IL_2A:
				this.NWUdvEjdI = value;
				IL_60:
				IL_70:
				this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(614));
				num = 5;
				goto IL_43;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00004724 File Offset: 0x00002B24
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000473C File Offset: 0x00002B3C
		[DataMember(IsRequired = true)]
		public long Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.AQXURcyt5;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num = DICTIONARY.OuBKsbvpkotkI5n7Gs() ? 4 : 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 3:
						goto IL_84;
					case 1:
						goto IL_95;
					case 2:
						break;
					case 4:
						goto IL_3E;
					case 5:
						return;
					default:
						num = 2;
						if (!DICTIONARY.m3EPxg5XML9662UcqU())
						{
							goto IL_84;
						}
						continue;
					}
					IL_24:
					this.RaisePropertyChanged(DICTIONARY.hWceCOCKPjIE1VKgbq(638));
					num = 5;
					continue;
					IL_3E:
					this.AQXURcyt5 = value;
					goto IL_24;
					IL_95:
					goto IL_3E;
					IL_84:
					if (!this.AQXURcyt5.Equals(value))
					{
						goto IL_95;
					}
					break;
				}
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000081 RID: 129 RVA: 0x000047F0 File Offset: 0x00002BF0
		// (remove) Token: 0x06000082 RID: 130 RVA: 0x000048BC File Offset: 0x00002CBC
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
				DICTIONARY.OuBKsbvpkotkI5n7Gs();
				int num;
				if (DICTIONARY.m3EPxg5XML9662UcqU())
				{
					num = 5;
					if (!DICTIONARY.m3EPxg5XML9662UcqU())
					{
						goto IL_2E;
					}
				}
				else
				{
					num = 2;
					if (!true)
					{
						return;
					}
				}
				for (;;)
				{
					IL_78:
					switch (num)
					{
					case 0:
					case 5:
						goto IL_A3;
					case 1:
						goto IL_AA;
					case 2:
						goto IL_4D;
					case 3:
						goto IL_59;
					case 4:
						goto IL_2E;
					case 6:
						return;
					default:
						num = 4;
						break;
					}
				}
				IL_59:
				PropertyChangedEventHandler propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)DICTIONARY.Qc08Dw0Sj64Ao21lIK(propertyChangedEventHandler, value);
				goto IL_2E;
				IL_A3:
				PropertyChangedEventHandler propertyChangedEventHandler2 = this.P3ntI3UMO;
				IL_AA:
				goto IL_4D;
				IL_2E:
				propertyChangedEventHandler2 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.P3ntI3UMO, value2, propertyChangedEventHandler);
				if (propertyChangedEventHandler2 == propertyChangedEventHandler)
				{
					num = 6;
					goto IL_78;
				}
				IL_4D:
				propertyChangedEventHandler = propertyChangedEventHandler2;
				num = 3;
				goto IL_78;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					object obj = null[0];
				}
				int num = (!DICTIONARY.m3EPxg5XML9662UcqU()) ? 2 : 3;
				for (;;)
				{
					PropertyChangedEventHandler propertyChangedEventHandler;
					PropertyChangedEventHandler propertyChangedEventHandler2;
					PropertyChangedEventHandler value2;
					switch (num)
					{
					case 0:
					case 3:
						propertyChangedEventHandler = this.P3ntI3UMO;
						break;
					case 1:
						break;
					case 2:
						break;
					case 4:
						value2 = (PropertyChangedEventHandler)DICTIONARY.HSD1s5xJRa3lNewoHE(propertyChangedEventHandler2, value);
						goto IL_91;
					case 5:
						goto IL_91;
					case 6:
						return;
					default:
						num = 5;
						continue;
					}
					IL_24:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					num = 4;
					continue;
					goto IL_24;
					IL_91:
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.P3ntI3UMO, value2, propertyChangedEventHandler2);
					if (propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						goto IL_24;
					}
					num = 6;
				}
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000497C File Offset: 0x00002D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RaisePropertyChanged(string propertyName)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 1:
				case 4:
					goto IL_58;
				case 3:
					goto IL_35;
				case 5:
					return;
				}
				IL_18:
				PropertyChangedEventHandler p3ntI3UMO;
				p3ntI3UMO(this, new PropertyChangedEventArgs(propertyName));
				num = 5;
				if (!DICTIONARY.OuBKsbvpkotkI5n7Gs())
				{
					continue;
				}
				IL_35:
				p3ntI3UMO = this.P3ntI3UMO;
				DICTIONARY.m3EPxg5XML9662UcqU();
				if (DICTIONARY.OuBKsbvpkotkI5n7Gs())
				{
					num = 0;
					continue;
				}
				num = 4;
				if (false)
				{
					goto IL_58;
				}
				continue;
				IL_8D:
				goto IL_18;
				IL_58:
				if (p3ntI3UMO != null)
				{
					goto IL_8D;
				}
				break;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004A28 File Offset: 0x00002E28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DICTIONARY()
		{
			while (false)
			{
				object obj = null[0];
			}
			DICTIONARY.eHj5HLhp2t1K66tkeY();
			base..ctor();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004A44 File Offset: 0x00002E44
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DICTIONARY()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004A5C File Offset: 0x00002E5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m3EPxg5XML9662UcqU()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004A70 File Offset: 0x00002E70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OuBKsbvpkotkI5n7Gs()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004A84 File Offset: 0x00002E84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hWceCOCKPjIE1VKgbq(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(\u0020);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004AA0 File Offset: 0x00002EA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Qc08Dw0Sj64Ao21lIK(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Delegate.Combine(A_0, A_1);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004AC0 File Offset: 0x00002EC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HSD1s5xJRa3lNewoHE(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Delegate.Remove(A_0, A_1);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004AE0 File Offset: 0x00002EE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eHj5HLhp2t1K66tkeY()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x04000028 RID: 40
		[NonSerialized]
		private ExtensionDataObject BP9TEuicF;

		// Token: 0x04000029 RID: 41
		[OptionalField]
		private string NWUdvEjdI;

		// Token: 0x0400002A RID: 42
		private long AQXURcyt5;

		// Token: 0x0400002B RID: 43
		[CompilerGenerated]
		private PropertyChangedEventHandler P3ntI3UMO;
	}
}
