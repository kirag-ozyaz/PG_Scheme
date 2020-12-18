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
	// Token: 0x02000006 RID: 6
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DebuggerStepThrough]
	[DataContract(Name = "DateBeginEndList", Namespace = "http://aisgorod.ru/")]
	[Serializable]
	public class DateBeginEndList : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003CA0 File Offset: 0x000020A0
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00003CB8 File Offset: 0x000020B8
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
				return this.dZ8ALpY62;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				this.dZ8ALpY62 = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003CD0 File Offset: 0x000020D0
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00003CE8 File Offset: 0x000020E8
		[DataMember(IsRequired = true)]
		public DateTime DateBegin
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.WLyVcwRCx;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					object obj = null[0];
				}
				DateBeginEndList.mHqdgwPBqOCsoDoTWj();
				int num = (!DateBeginEndList.fAo3E9FOXJ40e8mYDq()) ? 4 : 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
					case 2:
						if (!this.WLyVcwRCx.Equals(value))
						{
							goto IL_79;
						}
						return;
					case 1:
						goto IL_79;
					case 3:
						break;
					case 4:
						goto IL_28;
					case 5:
						return;
					default:
						num = 3;
						continue;
					}
					IL_89:
					this.RaisePropertyChanged(DateBeginEndList.sAYQy4m2GAkGkL9m8w(198));
					num = 5;
					if (!true)
					{
						break;
					}
					continue;
					IL_28:
					this.WLyVcwRCx = value;
					goto IL_89;
					IL_79:
					goto IL_28;
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003D9C File Offset: 0x0000219C
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00003DB4 File Offset: 0x000021B4
		[DataMember(IsRequired = true)]
		public DateTime DateEnd
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					object obj = null[0];
				}
				return this.FbiKHXEfK;
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
						if (!this.FbiKHXEfK.Equals(value))
						{
							num = ((!DateBeginEndList.fAo3E9FOXJ40e8mYDq()) ? 3 : 4);
							continue;
						}
						return;
					case 1:
					case 4:
						this.FbiKHXEfK = value;
						break;
					case 5:
						return;
					}
					IL_3F:
					this.RaisePropertyChanged(DateBeginEndList.sAYQy4m2GAkGkL9m8w(280));
					num = 5;
					continue;
					goto IL_3F;
				}
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000060 RID: 96 RVA: 0x00003E60 File Offset: 0x00002260
		// (remove) Token: 0x06000061 RID: 97 RVA: 0x00003F20 File Offset: 0x00002320
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
				int num;
				if (DateBeginEndList.fAo3E9FOXJ40e8mYDq())
				{
					num = 2;
					if (false)
					{
						goto IL_26;
					}
				}
				else
				{
					num = 5;
				}
				PropertyChangedEventHandler propertyChangedEventHandler;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				for (;;)
				{
					IL_87:
					switch (num)
					{
					case 0:
					case 2:
						goto IL_43;
					case 1:
						goto IL_4A;
					case 3:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler, value);
						propertyChangedEventHandler2 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.z74QsdHk8, value2, propertyChangedEventHandler);
						break;
					}
					case 4:
						break;
					case 5:
						goto IL_26;
					case 6:
						return;
					default:
						num = 4;
						continue;
					}
					if (propertyChangedEventHandler2 != propertyChangedEventHandler)
					{
						goto IL_26;
					}
					num = 6;
				}
				IL_43:
				propertyChangedEventHandler2 = this.z74QsdHk8;
				IL_4A:
				IL_26:
				propertyChangedEventHandler = propertyChangedEventHandler2;
				num = 3;
				goto IL_87;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					object obj = null[0];
				}
				DateBeginEndList.fAo3E9FOXJ40e8mYDq();
				int num = DateBeginEndList.mHqdgwPBqOCsoDoTWj() ? 4 : 2;
				for (;;)
				{
					PropertyChangedEventHandler propertyChangedEventHandler;
					PropertyChangedEventHandler propertyChangedEventHandler2;
					PropertyChangedEventHandler value2;
					switch (num)
					{
					case 0:
					case 2:
						propertyChangedEventHandler = this.z74QsdHk8;
						goto IL_83;
					case 1:
						goto IL_83;
					case 3:
						break;
					case 4:
						goto IL_B2;
					case 5:
						value2 = (PropertyChangedEventHandler)DateBeginEndList.IyPqhAgsgQ3PqprA9O(propertyChangedEventHandler2, value);
						break;
					case 6:
						return;
					default:
						num = 3;
						if (!DateBeginEndList.mHqdgwPBqOCsoDoTWj())
						{
							continue;
						}
						continue;
					}
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.z74QsdHk8, value2, propertyChangedEventHandler2);
					if (propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						num = 6;
						continue;
					}
					IL_B2:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					num = 5;
					if (DateBeginEndList.mHqdgwPBqOCsoDoTWj())
					{
						break;
					}
					continue;
					IL_83:
					goto IL_B2;
				}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003FF4 File Offset: 0x000023F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RaisePropertyChanged(string propertyName)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = (!DateBeginEndList.fAo3E9FOXJ40e8mYDq()) ? 3 : 2;
			for (;;)
			{
				PropertyChangedEventHandler propertyChangedEventHandler;
				switch (num)
				{
				case 0:
				case 2:
					propertyChangedEventHandler = this.z74QsdHk8;
					goto IL_81;
				case 1:
					goto IL_81;
				case 3:
					goto IL_3B;
				case 4:
					break;
				case 5:
					return;
				default:
					num = 4;
					continue;
				}
				IL_24:
				DateBeginEndList.HZar8WRRPncQrYHHei(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
				num = 5;
				continue;
				IL_3B:
				if (propertyChangedEventHandler != null)
				{
					goto IL_24;
				}
				break;
				IL_81:
				goto IL_3B;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004094 File Offset: 0x00002494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DateBeginEndList()
		{
			while (false)
			{
				object obj = null[0];
			}
			DateBeginEndList.OSMquHE0BculSATb29();
			DateBeginEndList.LZ2i5YKn997Y5q7f8m(this);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000040B0 File Offset: 0x000024B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DateBeginEndList()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000040C8 File Offset: 0x000024C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fAo3E9FOXJ40e8mYDq()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000040DC File Offset: 0x000024DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mHqdgwPBqOCsoDoTWj()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000040F0 File Offset: 0x000024F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sAYQy4m2GAkGkL9m8w(int \u0020)
		{
			while (false)
			{
				object obj = null[0];
			}
			return cDhluYseFOthxgEIXpc.nKHKpgTSVU(\u0020);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000410C File Offset: 0x0000250C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IyPqhAgsgQ3PqprA9O(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return Delegate.Remove(A_0, A_1);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000412C File Offset: 0x0000252C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HZar8WRRPncQrYHHei(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0(A_1, A_2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004150 File Offset: 0x00002550
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OSMquHE0BculSATb29()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004168 File Offset: 0x00002568
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LZ2i5YKn997Y5q7f8m(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor();
		}

		// Token: 0x04000020 RID: 32
		[NonSerialized]
		private ExtensionDataObject dZ8ALpY62;

		// Token: 0x04000021 RID: 33
		private DateTime WLyVcwRCx;

		// Token: 0x04000022 RID: 34
		private DateTime FbiKHXEfK;

		// Token: 0x04000023 RID: 35
		[CompilerGenerated]
		private PropertyChangedEventHandler z74QsdHk8;
	}
}
