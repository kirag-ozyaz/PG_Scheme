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
	// Token: 0x02000005 RID: 5
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "AddressObjects", Namespace = "http://aisgorod.ru/")]
	[DebuggerStepThrough]
	[Serializable]
	public class AddressObjects : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000349C File Offset: 0x0000189C
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000034B4 File Offset: 0x000018B4
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
				return this.swK4iEb9V;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				this.swK4iEb9V = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000034CC File Offset: 0x000018CC
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000034E4 File Offset: 0x000018E4
		[DataMember(EmitDefaultValue = false)]
		public string City
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.kBbBXiFrX;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				AddressObjects.WfOR6Ft96aBXIIdXET();
				int num;
				if (AddressObjects.JHm6qr4hHYreMs1YYN())
				{
					num = 3;
				}
				else
				{
					num = 2;
					if (!true)
					{
						goto IL_86;
					}
				}
				for (;;)
				{
					IL_41:
					switch (num)
					{
					case 0:
					case 3:
						goto IL_68;
					case 1:
						goto IL_74;
					case 2:
						goto IL_28;
					case 4:
						goto IL_86;
					case 5:
						return;
					default:
						num = 4;
						break;
					}
				}
				IL_28:
				this.kBbBXiFrX = value;
				goto IL_86;
				IL_68:
				if (this.kBbBXiFrX == value)
				{
					return;
				}
				IL_74:
				goto IL_28;
				IL_86:
				this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(512));
				num = 5;
				goto IL_41;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003594 File Offset: 0x00001994
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000035AC File Offset: 0x000019AC
		[DataMember(EmitDefaultValue = false)]
		public string CityType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.tnql45Syo;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num = (!AddressObjects.JHm6qr4hHYreMs1YYN()) ? 3 : 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 2:
						if (this.tnql45Syo != value)
						{
							goto IL_30;
						}
						return;
					case 1:
						goto IL_30;
					case 3:
						goto IL_60;
					case 4:
						break;
					case 5:
						return;
					default:
						num = 4;
						continue;
					}
					IL_40:
					this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(524));
					num = 5;
					if (AddressObjects.JHm6qr4hHYreMs1YYN())
					{
						continue;
					}
					IL_60:
					this.tnql45Syo = value;
					goto IL_40;
					IL_30:
					goto IL_60;
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000365C File Offset: 0x00001A5C
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00003674 File Offset: 0x00001A74
		[DataMember(EmitDefaultValue = false)]
		public string Street
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.tlkPNYlV9;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				AddressObjects.WfOR6Ft96aBXIIdXET();
				int num = (!AddressObjects.JHm6qr4hHYreMs1YYN()) ? 3 : 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 4:
						if (this.tlkPNYlV9 != value)
						{
							goto IL_4E;
						}
						return;
					case 1:
						goto IL_4E;
					case 2:
						break;
					case 3:
						goto IL_5E;
					case 5:
						return;
					default:
						num = 2;
						continue;
					}
					IL_28:
					this.RaisePropertyChanged(AddressObjects.STlFKywySkwuRKPose(544));
					num = 5;
					continue;
					IL_5E:
					this.tlkPNYlV9 = value;
					goto IL_28;
					IL_4E:
					goto IL_5E;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003720 File Offset: 0x00001B20
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00003738 File Offset: 0x00001B38
		[DataMember(EmitDefaultValue = false)]
		public string StreetType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.odZw5GwSG;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num = AddressObjects.WfOR6Ft96aBXIIdXET() ? 1 : 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 3:
						if (this.odZw5GwSG == value)
						{
							return;
						}
						num = 4;
						if (!AddressObjects.JHm6qr4hHYreMs1YYN())
						{
							goto IL_40;
						}
						continue;
					case 4:
						goto IL_40;
					case 5:
						return;
					}
					IL_86:
					this.RaisePropertyChanged(AddressObjects.STlFKywySkwuRKPose(560));
					num = 5;
					continue;
					IL_76:
					goto IL_86;
					IL_40:
					this.odZw5GwSG = value;
					goto IL_76;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000037E8 File Offset: 0x00001BE8
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00003800 File Offset: 0x00001C00
		[DataMember(EmitDefaultValue = false, Order = 4)]
		public string House
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.wOm5NJ4Li;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				AddressObjects.WfOR6Ft96aBXIIdXET();
				int num = (!AddressObjects.JHm6qr4hHYreMs1YYN()) ? 1 : 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 3:
						if (this.wOm5NJ4Li == value)
						{
							return;
						}
						num = 4;
						if (true)
						{
							continue;
						}
						break;
					case 4:
						this.wOm5NJ4Li = value;
						break;
					case 5:
						return;
					}
					IL_86:
					this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(584));
					num = 5;
					continue;
					goto IL_86;
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000038B0 File Offset: 0x00001CB0
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000038C8 File Offset: 0x00001CC8
		[DataMember(EmitDefaultValue = false, Order = 5)]
		public string Object
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.kXw95hq8I;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				AddressObjects.JHm6qr4hHYreMs1YYN();
				int num;
				if (!AddressObjects.WfOR6Ft96aBXIIdXET())
				{
					num = 3;
					if (false)
					{
						goto IL_2A;
					}
				}
				else
				{
					num = 4;
				}
				for (;;)
				{
					IL_5D:
					switch (num)
					{
					case 0:
					case 3:
						if (this.kXw95hq8I == value)
						{
							return;
						}
						num = 1;
						if (false)
						{
							return;
						}
						break;
					case 1:
						goto IL_44;
					default:
						goto IL_7A;
					case 4:
						goto IL_2A;
					case 5:
						return;
					}
				}
				IL_44:
				this.kXw95hq8I = value;
				IL_7A:
				IL_2A:
				this.RaisePropertyChanged(AddressObjects.STlFKywySkwuRKPose(598));
				num = 5;
				goto IL_5D;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600004E RID: 78 RVA: 0x00003978 File Offset: 0x00001D78
		// (remove) Token: 0x0600004F RID: 79 RVA: 0x00003A3C File Offset: 0x00001E3C
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
				int num = 0;
				for (;;)
				{
					PropertyChangedEventHandler propertyChangedEventHandler;
					PropertyChangedEventHandler propertyChangedEventHandler2;
					PropertyChangedEventHandler value2;
					switch (num)
					{
					case 0:
						propertyChangedEventHandler = this.PFJ2hPv98;
						num = 5;
						continue;
					case 2:
					case 4:
						value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
						break;
					case 5:
						goto IL_3D;
					case 6:
						return;
					}
					IL_18:
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PFJ2hPv98, value2, propertyChangedEventHandler2);
					if (propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						num = 6;
						if (!AddressObjects.WfOR6Ft96aBXIIdXET())
						{
							continue;
						}
					}
					IL_3D:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					num = (AddressObjects.WfOR6Ft96aBXIIdXET() ? 1 : 4);
					continue;
					goto IL_18;
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
				AddressObjects.WfOR6Ft96aBXIIdXET();
				int num;
				if (AddressObjects.JHm6qr4hHYreMs1YYN())
				{
					num = 4;
					if (false)
					{
						goto IL_2A;
					}
				}
				else
				{
					num = 1;
					if (!AddressObjects.JHm6qr4hHYreMs1YYN())
					{
						goto IL_53;
					}
				}
				for (;;)
				{
					IL_91:
					switch (num)
					{
					case 0:
					case 4:
						goto IL_2A;
					case 1:
						goto IL_64;
					case 2:
						goto IL_3D;
					case 3:
						goto IL_53;
					case 5:
						goto IL_3B;
					case 6:
						return;
					default:
						num = 3;
						break;
					}
				}
				return;
				IL_2A:
				PropertyChangedEventHandler propertyChangedEventHandler = this.PFJ2hPv98;
				num = 5;
				goto IL_91;
				IL_3B:
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				IL_3D:
				goto IL_64;
				IL_53:
				if (propertyChangedEventHandler == propertyChangedEventHandler2)
				{
					num = 6;
					goto IL_91;
				}
				goto IL_3B;
				IL_64:
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PFJ2hPv98, value2, propertyChangedEventHandler2);
				goto IL_53;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003B08 File Offset: 0x00001F08
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RaisePropertyChanged(string propertyName)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num;
			if (AddressObjects.JHm6qr4hHYreMs1YYN())
			{
				num = 3;
				if (AddressObjects.WfOR6Ft96aBXIIdXET())
				{
					goto IL_2A;
				}
			}
			else
			{
				num = 1;
			}
			PropertyChangedEventHandler pfj2hPv;
			for (;;)
			{
				IL_42:
				switch (num)
				{
				case 0:
				case 3:
					pfj2hPv = this.PFJ2hPv98;
					num = 4;
					if (!AddressObjects.WfOR6Ft96aBXIIdXET())
					{
					}
					break;
				case 1:
					goto IL_6F;
				default:
					goto IL_5F;
				case 4:
					goto IL_2A;
				case 5:
					return;
				}
			}
			IL_2A:
			if (pfj2hPv == null)
			{
				return;
			}
			IL_5F:
			IL_6F:
			AddressObjects.oolKhuVfWTwOnQCJMa(pfj2hPv, this, new PropertyChangedEventArgs(propertyName));
			num = 5;
			goto IL_42;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003BB8 File Offset: 0x00001FB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddressObjects()
		{
			while (false)
			{
				object obj = null[0];
			}
			AddressObjects.UnNK5xkPr3xBJAVpMP();
			AddressObjects.nxvSlldLVysa4o1ssb(this);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003BD4 File Offset: 0x00001FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AddressObjects()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			AddressObjects.FotC54bSohybQAsKJJ();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003BEC File Offset: 0x00001FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JHm6qr4hHYreMs1YYN()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003C00 File Offset: 0x00002000
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WfOR6Ft96aBXIIdXET()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003C14 File Offset: 0x00002014
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object STlFKywySkwuRKPose(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(\u0020);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003C30 File Offset: 0x00002030
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oolKhuVfWTwOnQCJMa(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0(A_1, A_2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003C54 File Offset: 0x00002054
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UnNK5xkPr3xBJAVpMP()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003C6C File Offset: 0x0000206C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nxvSlldLVysa4o1ssb(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003C88 File Offset: 0x00002088
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FotC54bSohybQAsKJJ()
		{
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x04000018 RID: 24
		[NonSerialized]
		private ExtensionDataObject swK4iEb9V;

		// Token: 0x04000019 RID: 25
		[OptionalField]
		private string kBbBXiFrX;

		// Token: 0x0400001A RID: 26
		[OptionalField]
		private string tnql45Syo;

		// Token: 0x0400001B RID: 27
		[OptionalField]
		private string tlkPNYlV9;

		// Token: 0x0400001C RID: 28
		[OptionalField]
		private string odZw5GwSG;

		// Token: 0x0400001D RID: 29
		[OptionalField]
		private string wOm5NJ4Li;

		// Token: 0x0400001E RID: 30
		[OptionalField]
		private string kXw95hq8I;

		// Token: 0x0400001F RID: 31
		[CompilerGenerated]
		private PropertyChangedEventHandler PFJ2hPv98;
	}
}
