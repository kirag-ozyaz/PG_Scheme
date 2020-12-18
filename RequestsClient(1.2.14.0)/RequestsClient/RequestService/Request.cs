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
	// Token: 0x02000004 RID: 4
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "Request", Namespace = "http://aisgorod.ru/")]
	[Serializable]
	public class Request : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000025E8 File Offset: 0x000009E8
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002600 File Offset: 0x00000A00
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
				return this.UnBJqbEIF;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				this.UnBJqbEIF = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002618 File Offset: 0x00000A18
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002630 File Offset: 0x00000A30
		[DataMember(EmitDefaultValue = false)]
		public string Number
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.JDF02dHo5;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				Request.sFMajBQbKtpCbx4kOW();
				int num;
				if (Request.PAOCpB7lIXKC3ssXW4())
				{
					num = 1;
				}
				else
				{
					num = 4;
					if (!Request.PAOCpB7lIXKC3ssXW4())
					{
						return;
					}
				}
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 1:
						if (this.JDF02dHo5 != value)
						{
							num = 3;
							continue;
						}
						return;
					case 3:
						this.JDF02dHo5 = value;
						break;
					case 5:
						return;
					}
					IL_28:
					this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(52));
					num = 5;
					continue;
					goto IL_28;
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000026E4 File Offset: 0x00000AE4
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000026FC File Offset: 0x00000AFC
		[DataMember(EmitDefaultValue = false, Order = 1)]
		public string AddressDisableText
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.tyMoOQkgr;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num = 3;
				if (!true)
				{
					goto IL_1A;
				}
				for (;;)
				{
					IL_73:
					switch (num)
					{
					case 1:
					case 4:
						this.tyMoOQkgr = value;
						break;
					case 3:
						goto IL_1A;
					case 5:
						return;
					}
					IL_40:
					this.RaisePropertyChanged(Request.HRmTEO1tIAvNfvHmlO(68));
					num = 5;
					continue;
					goto IL_40;
				}
				IL_1A:
				if (this.tyMoOQkgr != value)
				{
					Request.PAOCpB7lIXKC3ssXW4();
					num = (Request.sFMajBQbKtpCbx4kOW() ? 0 : 4);
					goto IL_73;
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000027AC File Offset: 0x00000BAC
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000027C4 File Offset: 0x00000BC4
		[DataMember(EmitDefaultValue = false, Order = 2)]
		public AddressObjects[] AddressHousesDidable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.KX2uI0eRd;
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
						this.KX2uI0eRd = value;
						break;
					case 4:
						if (this.KX2uI0eRd == value)
						{
							return;
						}
						if (Request.PAOCpB7lIXKC3ssXW4())
						{
							num = 3;
							continue;
						}
						num = 0;
						if (Request.sFMajBQbKtpCbx4kOW())
						{
							return;
						}
						continue;
					case 5:
						return;
					}
					IL_3A:
					this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(108));
					num = 5;
					continue;
					goto IL_3A;
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002874 File Offset: 0x00000C74
		// (set) Token: 0x0600001E RID: 30 RVA: 0x0000288C File Offset: 0x00000C8C
		[DataMember(IsRequired = true, Order = 3)]
		public long RefTypeDisable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.LvTMf5uSi;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				Request.PAOCpB7lIXKC3ssXW4();
				int num = Request.sFMajBQbKtpCbx4kOW() ? 4 : 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 3:
						if (!this.LvTMf5uSi.Equals(value))
						{
							num = 1;
							continue;
						}
						return;
					case 1:
						this.LvTMf5uSi = value;
						break;
					case 5:
						return;
					}
					IL_28:
					this.RaisePropertyChanged(Request.HRmTEO1tIAvNfvHmlO(152));
					num = 5;
					continue;
					goto IL_28;
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000293C File Offset: 0x00000D3C
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002954 File Offset: 0x00000D54
		[DataMember(EmitDefaultValue = false, Order = 4)]
		public string Cause
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.BSC8AklTY;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num;
				if (!Request.sFMajBQbKtpCbx4kOW())
				{
					num = 1;
				}
				else
				{
					num = 4;
					if (false)
					{
						goto IL_6C;
					}
				}
				for (;;)
				{
					IL_3D:
					switch (num)
					{
					case 0:
					case 1:
						goto IL_6C;
					case 3:
						this.BSC8AklTY = value;
						break;
					case 5:
						return;
					}
					IL_82:
					this.RaisePropertyChanged(Request.HRmTEO1tIAvNfvHmlO(184));
					num = 5;
					continue;
					goto IL_82;
				}
				IL_6C:
				if (this.BSC8AklTY != value)
				{
					num = 3;
					goto IL_3D;
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002A00 File Offset: 0x00000E00
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002A18 File Offset: 0x00000E18
		[DataMember(IsRequired = true, Order = 5)]
		public DateTime DateBegin
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.EnLRBwVKa;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				Request.PAOCpB7lIXKC3ssXW4();
				int num;
				if (!Request.sFMajBQbKtpCbx4kOW())
				{
					num = 1;
					if (!false)
					{
						goto IL_5D;
					}
				}
				else
				{
					num = 3;
					if (!Request.PAOCpB7lIXKC3ssXW4())
					{
						goto IL_90;
					}
					goto IL_5D;
				}
				IL_2A:
				this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(198));
				num = 5;
				IL_5D:
				switch (num)
				{
				case 0:
				case 1:
					IL_90:
					if (!this.EnLRBwVKa.Equals(value))
					{
						num = 4;
						goto IL_5D;
					}
					return;
				case 4:
					this.EnLRBwVKa = value;
					break;
				case 5:
					return;
				}
				goto IL_2A;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002AD0 File Offset: 0x00000ED0
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002AE8 File Offset: 0x00000EE8
		[DataMember(IsRequired = true, Order = 6)]
		public long RefRequestStatusId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.i74ChxMIb;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				Request.PAOCpB7lIXKC3ssXW4();
				int num = Request.sFMajBQbKtpCbx4kOW() ? 3 : 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 4:
						if (!this.i74ChxMIb.Equals(value))
						{
							num = 1;
							continue;
						}
						return;
					case 1:
						this.i74ChxMIb = value;
						break;
					case 5:
						return;
					}
					IL_89:
					this.RaisePropertyChanged(Request.HRmTEO1tIAvNfvHmlO(220));
					num = 5;
					if (!true)
					{
						break;
					}
					continue;
					goto IL_89;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002B9C File Offset: 0x00000F9C
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002BB4 File Offset: 0x00000FB4
		[DataMember(IsRequired = true, Order = 7)]
		public DateTime? DatePlan
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.YqUX6Ktiu;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				if (!this.YqUX6Ktiu.Equals(value))
				{
					this.YqUX6Ktiu = value;
					this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(260));
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002C04 File Offset: 0x00001004
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002C1C File Offset: 0x0000101C
		[DataMember(IsRequired = true, Order = 8)]
		public DateTime? DateEnd
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.aS3qRFaxt;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				if (!this.aS3qRFaxt.Equals(value))
				{
					this.aS3qRFaxt = value;
					this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(280));
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002C6C File Offset: 0x0000106C
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002C84 File Offset: 0x00001084
		[DataMember(IsRequired = true, Order = 9)]
		public int ToOrganizationId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.pAmmmmFtn;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num = (!Request.PAOCpB7lIXKC3ssXW4()) ? 3 : 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 4:
						if (!this.pAmmmmFtn.Equals(value))
						{
							goto IL_91;
						}
						return;
					case 1:
						goto IL_91;
					case 2:
						break;
					case 3:
						goto IL_24;
					case 5:
						return;
					default:
						num = 2;
						if (!false)
						{
							continue;
						}
						break;
					}
					IL_66:
					this.RaisePropertyChanged(Request.HRmTEO1tIAvNfvHmlO(298));
					num = 5;
					continue;
					IL_24:
					this.pAmmmmFtn = value;
					goto IL_66;
					IL_91:
					goto IL_24;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002D34 File Offset: 0x00001134
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002D4C File Offset: 0x0000114C
		[DataMember(IsRequired = true, Order = 10)]
		public int PerformerOrganizationId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.iK6sNjv35;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num;
				if (Request.PAOCpB7lIXKC3ssXW4())
				{
					num = 4;
					if (false)
					{
						goto IL_26;
					}
				}
				else
				{
					num = 3;
				}
				for (;;)
				{
					IL_74:
					switch (num)
					{
					case 0:
					case 4:
						if (this.iK6sNjv35.Equals(value))
						{
							return;
						}
						num = 1;
						break;
					case 1:
						goto IL_5B;
					default:
						goto IL_91;
					case 3:
						goto IL_26;
					case 5:
						return;
					}
				}
				IL_5B:
				this.iK6sNjv35 = value;
				IL_91:
				IL_26:
				this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(334));
				num = 5;
				goto IL_74;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002DFC File Offset: 0x000011FC
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002E14 File Offset: 0x00001214
		[DataMember(IsRequired = true, Order = 11)]
		public long RefGroupWorksId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.Q1F7NHQnZ;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num;
				if (!Request.sFMajBQbKtpCbx4kOW())
				{
					num = 3;
				}
				else
				{
					num = 2;
					if (false)
					{
						return;
					}
				}
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
						goto IL_24;
					case 4:
						break;
					case 5:
						return;
					default:
						num = 4;
						continue;
					}
					IL_64:
					this.RaisePropertyChanged(Request.HRmTEO1tIAvNfvHmlO(384));
					num = 5;
					if (!Request.PAOCpB7lIXKC3ssXW4())
					{
						goto IL_84;
					}
					continue;
					IL_24:
					this.Q1F7NHQnZ = value;
					goto IL_64;
					IL_95:
					goto IL_24;
					IL_84:
					if (!this.Q1F7NHQnZ.Equals(value))
					{
						goto IL_95;
					}
					break;
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002EC8 File Offset: 0x000012C8
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002EE0 File Offset: 0x000012E0
		[DataMember(EmitDefaultValue = false, Order = 12)]
		public string Comment
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.VsZarM2ok;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				Request.sFMajBQbKtpCbx4kOW();
				int num;
				if (Request.PAOCpB7lIXKC3ssXW4())
				{
					num = 3;
					if (!true)
					{
						goto IL_2A;
					}
				}
				else
				{
					num = 2;
				}
				for (;;)
				{
					IL_5F:
					switch (num)
					{
					case 0:
					case 3:
						goto IL_2A;
					case 1:
						goto IL_36;
					case 2:
						goto IL_46;
					case 4:
						goto IL_86;
					case 5:
						return;
					default:
						num = 4;
						break;
					}
				}
				IL_2A:
				if (this.VsZarM2ok == value)
				{
					return;
				}
				IL_36:
				IL_46:
				this.VsZarM2ok = value;
				IL_86:
				this.RaisePropertyChanged(Request.HRmTEO1tIAvNfvHmlO(418));
				num = 5;
				goto IL_5F;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002F90 File Offset: 0x00001390
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002FA8 File Offset: 0x000013A8
		[DataMember(IsRequired = true, Order = 13)]
		public long RefRegionId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.lgm1NPKK7;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				Request.PAOCpB7lIXKC3ssXW4();
				int num = Request.sFMajBQbKtpCbx4kOW() ? 4 : 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 3:
						if (!this.lgm1NPKK7.Equals(value))
						{
							goto IL_39;
						}
						return;
					case 1:
						goto IL_39;
					case 2:
						break;
					case 4:
						goto IL_63;
					case 5:
						return;
					default:
						num = 2;
						continue;
					}
					IL_49:
					this.RaisePropertyChanged(Request.HRmTEO1tIAvNfvHmlO(436));
					num = 5;
					continue;
					IL_63:
					this.lgm1NPKK7 = value;
					goto IL_49;
					IL_39:
					goto IL_63;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00003058 File Offset: 0x00001458
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00003070 File Offset: 0x00001470
		[DataMember(EmitDefaultValue = false, Order = 14)]
		public DateBeginEndList[] DateBeginEnd
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.J0rOEnfoy;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num = Request.sFMajBQbKtpCbx4kOW() ? 3 : 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 4:
						if (this.J0rOEnfoy != value)
						{
							num = 1;
							continue;
						}
						return;
					case 1:
						this.J0rOEnfoy = value;
						break;
					case 5:
						return;
					}
					IL_3A:
					this.RaisePropertyChanged(Request.HRmTEO1tIAvNfvHmlO(462));
					num = 5;
					continue;
					goto IL_3A;
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003118 File Offset: 0x00001518
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00003130 File Offset: 0x00001530
		[DataMember(EmitDefaultValue = false, Order = 15)]
		public Document[] Documents
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.SoLLiUJxC;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				int num = 4;
				if (!true)
				{
					goto IL_1A;
				}
				for (;;)
				{
					IL_33:
					switch (num)
					{
					case 0:
						goto IL_60;
					case 1:
					case 3:
						goto IL_1A;
					default:
						goto IL_50;
					case 4:
						if (this.SoLLiUJxC == value)
						{
							return;
						}
						Request.PAOCpB7lIXKC3ssXW4();
						if (!Request.sFMajBQbKtpCbx4kOW())
						{
							num = 3;
							if (Request.sFMajBQbKtpCbx4kOW())
							{
								return;
							}
						}
						else
						{
							num = 0;
						}
						break;
					case 5:
						return;
					}
				}
				return;
				IL_1A:
				this.SoLLiUJxC = value;
				IL_50:
				IL_60:
				this.RaisePropertyChanged(cDhluYseFOthxgEIXpc.nKHKpgTSVU(490));
				num = 5;
				goto IL_33;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000037 RID: 55 RVA: 0x000031E4 File Offset: 0x000015E4
		// (remove) Token: 0x06000038 RID: 56 RVA: 0x000032A4 File Offset: 0x000016A4
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
				int num = 5;
				for (;;)
				{
					PropertyChangedEventHandler propertyChangedEventHandler;
					switch (num)
					{
					case 0:
						break;
					case 1:
					case 3:
						goto IL_91;
					case 2:
						goto IL_A0;
					case 4:
						goto IL_35;
					case 5:
						propertyChangedEventHandler = this.MrXvReVrv;
						num = (Request.sFMajBQbKtpCbx4kOW() ? 4 : 3);
						continue;
					case 6:
						return;
					default:
						num = 0;
						continue;
					}
					IL_80:
					PropertyChangedEventHandler propertyChangedEventHandler2;
					if (propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						num = 6;
						continue;
					}
					goto IL_91;
					IL_35:
					PropertyChangedEventHandler value2;
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.MrXvReVrv, value2, propertyChangedEventHandler2);
					goto IL_80;
					IL_A0:
					goto IL_35;
					IL_91:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					goto IL_A0;
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
				int num = 5;
				for (;;)
				{
					PropertyChangedEventHandler propertyChangedEventHandler;
					PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 1:
						goto IL_29;
					case 2:
					case 4:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler, value);
						propertyChangedEventHandler2 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.MrXvReVrv, value2, propertyChangedEventHandler);
						break;
					}
					case 5:
						propertyChangedEventHandler2 = this.MrXvReVrv;
						num = 1;
						continue;
					case 6:
						return;
					}
					IL_18:
					if (propertyChangedEventHandler2 == propertyChangedEventHandler)
					{
						num = 6;
						continue;
					}
					IL_29:
					propertyChangedEventHandler = propertyChangedEventHandler2;
					if (!Request.sFMajBQbKtpCbx4kOW())
					{
						num = 4;
						continue;
					}
					num = 0;
					if (Request.sFMajBQbKtpCbx4kOW())
					{
						break;
					}
					continue;
					goto IL_18;
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003368 File Offset: 0x00001768
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RaisePropertyChanged(string propertyName)
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
			PropertyChangedEventHandler mrXvReVrv;
			for (;;)
			{
				IL_4F:
				switch (num)
				{
				case 1:
				case 3:
					if (mrXvReVrv == null)
					{
						return;
					}
					break;
				case 4:
					goto IL_1A;
				case 5:
					return;
				}
				IL_7C:
				mrXvReVrv(this, new PropertyChangedEventArgs(propertyName));
				num = 5;
				if (false)
				{
					break;
				}
				continue;
				goto IL_7C;
			}
			return;
			IL_1A:
			mrXvReVrv = this.MrXvReVrv;
			num = (Request.sFMajBQbKtpCbx4kOW() ? 0 : 3);
			goto IL_4F;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000340C File Offset: 0x0000180C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Request()
		{
			while (false)
			{
				object obj = null[0];
			}
			Request.Yt2RG9GjbkaGy3ZVpM();
			base..ctor();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003428 File Offset: 0x00001828
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Request()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003440 File Offset: 0x00001840
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PAOCpB7lIXKC3ssXW4()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003454 File Offset: 0x00001854
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sFMajBQbKtpCbx4kOW()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003468 File Offset: 0x00001868
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HRmTEO1tIAvNfvHmlO(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(\u0020);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003484 File Offset: 0x00001884
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Yt2RG9GjbkaGy3ZVpM()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x04000006 RID: 6
		[NonSerialized]
		private ExtensionDataObject UnBJqbEIF;

		// Token: 0x04000007 RID: 7
		[OptionalField]
		private string JDF02dHo5;

		// Token: 0x04000008 RID: 8
		[OptionalField]
		private string tyMoOQkgr;

		// Token: 0x04000009 RID: 9
		[OptionalField]
		private AddressObjects[] KX2uI0eRd;

		// Token: 0x0400000A RID: 10
		private long LvTMf5uSi;

		// Token: 0x0400000B RID: 11
		[OptionalField]
		private string BSC8AklTY;

		// Token: 0x0400000C RID: 12
		private DateTime EnLRBwVKa;

		// Token: 0x0400000D RID: 13
		private long i74ChxMIb;

		// Token: 0x0400000E RID: 14
		private DateTime? YqUX6Ktiu;

		// Token: 0x0400000F RID: 15
		private DateTime? aS3qRFaxt;

		// Token: 0x04000010 RID: 16
		private int pAmmmmFtn;

		// Token: 0x04000011 RID: 17
		private int iK6sNjv35;

		// Token: 0x04000012 RID: 18
		private long Q1F7NHQnZ;

		// Token: 0x04000013 RID: 19
		[OptionalField]
		private string VsZarM2ok;

		// Token: 0x04000014 RID: 20
		private long lgm1NPKK7;

		// Token: 0x04000015 RID: 21
		[OptionalField]
		private DateBeginEndList[] J0rOEnfoy;

		// Token: 0x04000016 RID: 22
		[OptionalField]
		private Document[] SoLLiUJxC;

		// Token: 0x04000017 RID: 23
		[CompilerGenerated]
		private PropertyChangedEventHandler MrXvReVrv;
	}
}
