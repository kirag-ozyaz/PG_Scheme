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
	// Token: 0x02000009 RID: 9
	[DataContract(Name = "AddressElement", Namespace = "http://aisgorod.ru/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class AddressElement : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004AF8 File Offset: 0x00002EF8
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00004B10 File Offset: 0x00002F10
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
				return this.O91DwVuj0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				this.O91DwVuj0 = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00004B28 File Offset: 0x00002F28
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00004B40 File Offset: 0x00002F40
		[DataMember(IsRequired = true)]
		public long Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.LIscb7Aky;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				AddressElement.nJMSU3Ys941R4im1Cw();
				int num = (!AddressElement.SyPAuJonoEMekULKX8()) ? 3 : 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 2:
						if (!this.LIscb7Aky.Equals(value))
						{
							goto IL_9F;
						}
						return;
					case 1:
						goto IL_9F;
					case 3:
						goto IL_44;
					case 4:
						break;
					case 5:
						return;
					default:
						num = 4;
						if (!AddressElement.nJMSU3Ys941R4im1Cw())
						{
							continue;
						}
						continue;
					}
					IL_28:
					this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(652));
					num = 5;
					if (true)
					{
						continue;
					}
					IL_44:
					this.LIscb7Aky = value;
					goto IL_28;
					IL_9F:
					goto IL_44;
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00004BFC File Offset: 0x00002FFC
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00004C14 File Offset: 0x00003014
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
				return this.bKYp4cJwW;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num;
				if (AddressElement.SyPAuJonoEMekULKX8())
				{
					num = 2;
				}
				else
				{
					num = 4;
					if (!true)
					{
						goto IL_42;
					}
				}
				for (;;)
				{
					IL_75:
					switch (num)
					{
					case 0:
					case 2:
						goto IL_24;
					case 1:
						goto IL_30;
					case 3:
						goto IL_42;
					case 4:
						goto IL_5C;
					case 5:
						return;
					default:
						num = 3;
						if (!AddressElement.SyPAuJonoEMekULKX8())
						{
							return;
						}
						break;
					}
				}
				IL_24:
				if (this.bKYp4cJwW == value)
				{
					return;
				}
				IL_30:
				IL_5C:
				this.bKYp4cJwW = value;
				IL_42:
				this.RaisePropertyChanged(AddressElement.Db2yVXufQcZQQvuMfZ(614));
				num = 5;
				goto IL_75;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00004CC4 File Offset: 0x000030C4
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00004CDC File Offset: 0x000030DC
		[DataMember(EmitDefaultValue = false, Order = 2)]
		public string Designation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.vVgWfWJya;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
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
					case 1:
					case 3:
						goto IL_5A;
					case 4:
						if (this.vVgWfWJya != value)
						{
							num = ((!AddressElement.SyPAuJonoEMekULKX8()) ? 0 : 3);
							continue;
						}
						return;
					case 5:
						return;
					}
					IL_3A:
					this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(660));
					num = 5;
					if (!AddressElement.SyPAuJonoEMekULKX8())
					{
						goto IL_5A;
					}
					continue;
					IL_90:
					goto IL_3A;
					IL_5A:
					this.vVgWfWJya = value;
					goto IL_90;
				}
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000094 RID: 148 RVA: 0x00004D8C File Offset: 0x0000318C
		// (remove) Token: 0x06000095 RID: 149 RVA: 0x00004E54 File Offset: 0x00003254
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
				int num = AddressElement.nJMSU3Ys941R4im1Cw() ? 4 : 5;
				for (;;)
				{
					PropertyChangedEventHandler propertyChangedEventHandler;
					switch (num)
					{
					case 0:
					case 5:
						propertyChangedEventHandler = this.DkDHni35o;
						goto IL_2B;
					case 1:
						goto IL_2B;
					case 2:
						break;
					case 3:
						goto IL_5C;
					case 4:
						goto IL_AC;
					case 6:
						return;
					default:
						num = 2;
						if (!AddressElement.SyPAuJonoEMekULKX8())
						{
							goto IL_AC;
						}
						continue;
					}
					IL_3B:
					PropertyChangedEventHandler value2;
					PropertyChangedEventHandler propertyChangedEventHandler2;
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.DkDHni35o, value2, propertyChangedEventHandler2);
					if (propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						goto IL_AC;
					}
					num = 6;
					if (true)
					{
						continue;
					}
					IL_5C:
					value2 = (PropertyChangedEventHandler)AddressElement.iultm3ayUnnPn9EE8h(propertyChangedEventHandler2, value);
					goto IL_3B;
					IL_AC:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					num = 3;
					continue;
					IL_2B:
					goto IL_AC;
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
				int num = 4;
				if (false)
				{
					goto IL_1A;
				}
				PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_39:
					switch (num)
					{
					case 0:
					case 1:
						goto IL_91;
					case 2:
						goto IL_93;
					case 3:
						goto IL_A3;
					case 4:
						break;
					case 5:
						goto IL_1A;
					case 6:
						return;
					default:
						num = 3;
						if (AddressElement.SyPAuJonoEMekULKX8())
						{
							continue;
						}
						break;
					}
					propertyChangedEventHandler = this.DkDHni35o;
					AddressElement.SyPAuJonoEMekULKX8();
					if (!AddressElement.nJMSU3Ys941R4im1Cw())
					{
						num = 0;
						if (!AddressElement.SyPAuJonoEMekULKX8())
						{
							goto IL_91;
						}
					}
					else
					{
						num = 5;
					}
				}
				return;
				IL_1A:
				PropertyChangedEventHandler propertyChangedEventHandler2;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				goto IL_A3;
				IL_91:
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				IL_93:
				goto IL_1A;
				IL_A3:
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.DkDHni35o, value2, propertyChangedEventHandler2);
				if (propertyChangedEventHandler == propertyChangedEventHandler2)
				{
					num = 6;
					goto IL_39;
				}
				goto IL_91;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004F24 File Offset: 0x00003324
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RaisePropertyChanged(string propertyName)
		{
			while (false)
			{
				object obj = null[0];
			}
			AddressElement.SyPAuJonoEMekULKX8();
			int num = AddressElement.nJMSU3Ys941R4im1Cw() ? 4 : 2;
			for (;;)
			{
				PropertyChangedEventHandler dkDHni35o;
				switch (num)
				{
				case 0:
				case 2:
					dkDHni35o = this.DkDHni35o;
					goto IL_2F;
				case 1:
					goto IL_2F;
				case 3:
					break;
				case 4:
					goto IL_3F;
				case 5:
					return;
				default:
					num = 3;
					continue;
				}
				IL_7E:
				AddressElement.K7WBbDqnllYJIQ8R8T(dkDHni35o, this, new PropertyChangedEventArgs(propertyName));
				num = 5;
				continue;
				IL_3F:
				if (dkDHni35o != null)
				{
					goto IL_7E;
				}
				break;
				IL_2F:
				goto IL_3F;
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004FC8 File Offset: 0x000033C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddressElement()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			AddressElement.xOUqwD8hKR3XHWDLPm(this);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004FE4 File Offset: 0x000033E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AddressElement()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			AddressElement.GnVm6gBcdyjV5xAiaL();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004FFC File Offset: 0x000033FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SyPAuJonoEMekULKX8()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00005010 File Offset: 0x00003410
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nJMSU3Ys941R4im1Cw()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005024 File Offset: 0x00003424
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Db2yVXufQcZQQvuMfZ(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(\u0020);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00005040 File Offset: 0x00003440
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iultm3ayUnnPn9EE8h(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Delegate.Combine(A_0, A_1);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005060 File Offset: 0x00003460
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void K7WBbDqnllYJIQ8R8T(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0(A_1, A_2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005084 File Offset: 0x00003484
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xOUqwD8hKR3XHWDLPm(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000050A0 File Offset: 0x000034A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GnVm6gBcdyjV5xAiaL()
		{
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x0400002C RID: 44
		[NonSerialized]
		private ExtensionDataObject O91DwVuj0;

		// Token: 0x0400002D RID: 45
		private long LIscb7Aky;

		// Token: 0x0400002E RID: 46
		[OptionalField]
		private string bKYp4cJwW;

		// Token: 0x0400002F RID: 47
		[OptionalField]
		private string vVgWfWJya;

		// Token: 0x04000030 RID: 48
		[CompilerGenerated]
		private PropertyChangedEventHandler DkDHni35o;
	}
}
