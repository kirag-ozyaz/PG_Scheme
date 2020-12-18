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
	// Token: 0x02000007 RID: 7
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "Document", Namespace = "http://aisgorod.ru/")]
	[Serializable]
	public class Document : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00004184 File Offset: 0x00002584
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000419C File Offset: 0x0000259C
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
				return this.iRcSZAJFf;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				this.iRcSZAJFf = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000041B4 File Offset: 0x000025B4
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000041CC File Offset: 0x000025CC
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
				return this.q7QkXaywq;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				Document.cRxwmriAoMB9wuJUkr();
				int num;
				if (Document.SUkUuM92wHuLPvhYdv())
				{
					num = 2;
					if (Document.cRxwmriAoMB9wuJUkr())
					{
						goto IL_2E;
					}
				}
				else
				{
					num = 3;
				}
				for (;;)
				{
					IL_83:
					switch (num)
					{
					case 0:
					case 2:
						goto IL_2E;
					case 1:
						goto IL_3A;
					case 3:
						goto IL_6A;
					case 4:
						goto IL_4A;
					case 5:
						return;
					default:
						num = 4;
						break;
					}
				}
				IL_2E:
				if (this.q7QkXaywq == value)
				{
					return;
				}
				IL_3A:
				goto IL_6A;
				IL_4A:
				this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(614));
				num = 5;
				if (Document.SUkUuM92wHuLPvhYdv())
				{
					goto IL_83;
				}
				IL_6A:
				this.q7QkXaywq = value;
				goto IL_4A;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00004284 File Offset: 0x00002684
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0000429C File Offset: 0x0000269C
		[DataMember(EmitDefaultValue = false, Order = 1)]
		public byte[] Data
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.veFfXU2Oi;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				Document.cRxwmriAoMB9wuJUkr();
				int num;
				if (Document.SUkUuM92wHuLPvhYdv())
				{
					num = 3;
				}
				else
				{
					num = 2;
					if (!Document.SUkUuM92wHuLPvhYdv())
					{
						goto IL_4A;
					}
				}
				for (;;)
				{
					IL_63:
					switch (num)
					{
					case 0:
					case 3:
						goto IL_28;
					case 1:
						goto IL_34;
					case 2:
						goto IL_4A;
					case 4:
						goto IL_8A;
					case 5:
						return;
					default:
						num = 4;
						break;
					}
				}
				IL_28:
				if (this.veFfXU2Oi == value)
				{
					return;
				}
				IL_34:
				IL_4A:
				this.veFfXU2Oi = value;
				IL_8A:
				this.RaisePropertyChanged(Document.UjsNmPe6xTFIVEqnNX(626));
				num = 5;
				if (Document.SUkUuM92wHuLPvhYdv())
				{
					goto IL_63;
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000072 RID: 114 RVA: 0x00004354 File Offset: 0x00002754
		// (remove) Token: 0x06000073 RID: 115 RVA: 0x00004424 File Offset: 0x00002824
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
				Document.SUkUuM92wHuLPvhYdv();
				int num = Document.cRxwmriAoMB9wuJUkr() ? 4 : 5;
				for (;;)
				{
					PropertyChangedEventHandler propertyChangedEventHandler;
					switch (num)
					{
					case 0:
					case 5:
						propertyChangedEventHandler = this.CYJ6FSLN8;
						num = 1;
						continue;
					case 1:
						goto IL_28;
					case 2:
						goto IL_37;
					case 3:
						break;
					case 4:
						goto IL_73;
					case 6:
						return;
					default:
						num = 3;
						if (!true)
						{
							return;
						}
						continue;
					}
					IL_58:
					PropertyChangedEventHandler propertyChangedEventHandler2;
					if (propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						goto IL_28;
					}
					num = 6;
					if (!Document.cRxwmriAoMB9wuJUkr())
					{
						continue;
					}
					continue;
					IL_73:
					PropertyChangedEventHandler value2;
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.CYJ6FSLN8, value2, propertyChangedEventHandler2);
					goto IL_58;
					IL_37:
					goto IL_73;
					IL_28:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					goto IL_37;
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
				Document.SUkUuM92wHuLPvhYdv();
				int num = Document.cRxwmriAoMB9wuJUkr() ? 1 : 4;
				for (;;)
				{
					PropertyChangedEventHandler propertyChangedEventHandler;
					switch (num)
					{
					case 0:
					case 4:
						propertyChangedEventHandler = this.CYJ6FSLN8;
						num = 5;
						if (Document.cRxwmriAoMB9wuJUkr())
						{
							return;
						}
						continue;
					case 1:
						goto IL_3B;
					case 2:
						goto IL_95;
					case 3:
						break;
					case 5:
						goto IL_86;
					case 6:
						return;
					default:
						num = 3;
						continue;
					}
					IL_28:
					PropertyChangedEventHandler propertyChangedEventHandler2;
					if (propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						goto IL_86;
					}
					num = 6;
					if (!false)
					{
						continue;
					}
					IL_3B:
					PropertyChangedEventHandler value2;
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.CYJ6FSLN8, value2, propertyChangedEventHandler2);
					goto IL_28;
					IL_95:
					goto IL_3B;
					IL_86:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					value2 = (PropertyChangedEventHandler)Document.Gx9xGpMdTyQnSS0FKG(propertyChangedEventHandler2, value);
					goto IL_95;
				}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000044F0 File Offset: 0x000028F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RaisePropertyChanged(string propertyName)
		{
			while (false)
			{
				object obj = null[0];
			}
			Document.SUkUuM92wHuLPvhYdv();
			int num;
			if (!Document.cRxwmriAoMB9wuJUkr())
			{
				num = 4;
			}
			else
			{
				num = 1;
				if (false)
				{
					goto IL_6F;
				}
			}
			PropertyChangedEventHandler cyj6FSLN;
			for (;;)
			{
				IL_40:
				switch (num)
				{
				case 0:
				case 4:
					goto IL_6F;
				case 3:
					if (cyj6FSLN == null)
					{
						return;
					}
					break;
				case 5:
					return;
				}
				IL_80:
				cyj6FSLN(this, new PropertyChangedEventArgs(propertyName));
				num = 5;
				continue;
				goto IL_80;
			}
			return;
			IL_6F:
			cyj6FSLN = this.CYJ6FSLN8;
			num = 3;
			goto IL_40;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004594 File Offset: 0x00002994
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Document()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			base..ctor();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000045B0 File Offset: 0x000029B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Document()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000045C8 File Offset: 0x000029C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SUkUuM92wHuLPvhYdv()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000045DC File Offset: 0x000029DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cRxwmriAoMB9wuJUkr()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000045F0 File Offset: 0x000029F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UjsNmPe6xTFIVEqnNX(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(\u0020);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000460C File Offset: 0x00002A0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Gx9xGpMdTyQnSS0FKG(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Delegate.Remove(A_0, A_1);
		}

		// Token: 0x04000024 RID: 36
		[NonSerialized]
		private ExtensionDataObject iRcSZAJFf;

		// Token: 0x04000025 RID: 37
		[OptionalField]
		private string q7QkXaywq;

		// Token: 0x04000026 RID: 38
		[OptionalField]
		private byte[] veFfXU2Oi;

		// Token: 0x04000027 RID: 39
		[CompilerGenerated]
		private PropertyChangedEventHandler CYJ6FSLN8;
	}
}
