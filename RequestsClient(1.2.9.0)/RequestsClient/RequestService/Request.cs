using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000011 RID: 17
	[DebuggerStepThrough]
	[DataContract(Name = "Request", Namespace = "http://aisgorod.ru/")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Request : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000068DE File Offset: 0x00004ADE
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000068E6 File Offset: 0x00004AE6
		[Browsable(false)]
		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.a;
			}
			set
			{
				this.a = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000068EF File Offset: 0x00004AEF
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000068F7 File Offset: 0x00004AF7
		[DataMember(EmitDefaultValue = false)]
		public string Number
		{
			get
			{
				return this.NumberField;
			}
			set
			{
				if (this.NumberField != value)
				{
					this.NumberField = value;
					this.RaisePropertyChanged("Number");
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00006914 File Offset: 0x00004B14
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000691C File Offset: 0x00004B1C
		[DataMember(EmitDefaultValue = false, Order = 1)]
		public string AddressDisableText
		{
			get
			{
				return this.AddressDisableTextField;
			}
			set
			{
				if (this.AddressDisableTextField != value)
				{
					this.AddressDisableTextField = value;
					this.RaisePropertyChanged("AddressDisableText");
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00006939 File Offset: 0x00004B39
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00006941 File Offset: 0x00004B41
		[DataMember(EmitDefaultValue = false, Order = 2)]
		public AddressObjects[] AddressHousesDidable
		{
			get
			{
				return this.AddressHousesDidableField;
			}
			set
			{
				if (this.AddressHousesDidableField != value)
				{
					this.AddressHousesDidableField = value;
					this.RaisePropertyChanged("AddressHousesDidable");
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000695E File Offset: 0x00004B5E
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00006966 File Offset: 0x00004B66
		[DataMember(IsRequired = true, Order = 3)]
		public long RefTypeDisable
		{
			get
			{
				return this.RefTypeDisableField;
			}
			set
			{
				if (!this.RefTypeDisableField.Equals(value))
				{
					this.RefTypeDisableField = value;
					this.RaisePropertyChanged("RefTypeDisable");
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00006988 File Offset: 0x00004B88
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00006990 File Offset: 0x00004B90
		[DataMember(EmitDefaultValue = false, Order = 4)]
		public string Cause
		{
			get
			{
				return this.CauseField;
			}
			set
			{
				if (this.CauseField != value)
				{
					this.CauseField = value;
					this.RaisePropertyChanged("Cause");
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000069AD File Offset: 0x00004BAD
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000069B5 File Offset: 0x00004BB5
		[DataMember(IsRequired = true, Order = 5)]
		public DateTime DateBegin
		{
			get
			{
				return this.DateBeginField;
			}
			set
			{
				if (!this.DateBeginField.Equals(value))
				{
					this.DateBeginField = value;
					this.RaisePropertyChanged("DateBegin");
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000069D7 File Offset: 0x00004BD7
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000069DF File Offset: 0x00004BDF
		[DataMember(IsRequired = true, Order = 6)]
		public long RefRequestStatusId
		{
			get
			{
				return this.RefRequestStatusIdField;
			}
			set
			{
				if (!this.RefRequestStatusIdField.Equals(value))
				{
					this.RefRequestStatusIdField = value;
					this.RaisePropertyChanged("RefRequestStatusId");
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00006A01 File Offset: 0x00004C01
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00006A09 File Offset: 0x00004C09
		[DataMember(IsRequired = true, Order = 7)]
		public DateTime? DatePlan
		{
			get
			{
				return this.DatePlanField;
			}
			set
			{
				if (!this.DatePlanField.Equals(value))
				{
					this.DatePlanField = value;
					this.RaisePropertyChanged("DatePlan");
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00006A36 File Offset: 0x00004C36
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00006A3E File Offset: 0x00004C3E
		[DataMember(IsRequired = true, Order = 8)]
		public DateTime? DateEnd
		{
			get
			{
				return this.DateEndField;
			}
			set
			{
				if (!this.DateEndField.Equals(value))
				{
					this.DateEndField = value;
					this.RaisePropertyChanged("DateEnd");
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00006A6B File Offset: 0x00004C6B
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00006A73 File Offset: 0x00004C73
		[DataMember(IsRequired = true, Order = 9)]
		public int ToOrganizationId
		{
			get
			{
				return this.ToOrganizationIdField;
			}
			set
			{
				if (!this.ToOrganizationIdField.Equals(value))
				{
					this.ToOrganizationIdField = value;
					this.RaisePropertyChanged("ToOrganizationId");
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00006A95 File Offset: 0x00004C95
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00006A9D File Offset: 0x00004C9D
		[DataMember(IsRequired = true, Order = 10)]
		public int PerformerOrganizationId
		{
			get
			{
				return this.PerformerOrganizationIdField;
			}
			set
			{
				if (!this.PerformerOrganizationIdField.Equals(value))
				{
					this.PerformerOrganizationIdField = value;
					this.RaisePropertyChanged("PerformerOrganizationId");
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00006ABF File Offset: 0x00004CBF
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00006AC7 File Offset: 0x00004CC7
		[DataMember(IsRequired = true, Order = 11)]
		public long RefGroupWorksId
		{
			get
			{
				return this.RefGroupWorksIdField;
			}
			set
			{
				if (!this.RefGroupWorksIdField.Equals(value))
				{
					this.RefGroupWorksIdField = value;
					this.RaisePropertyChanged("RefGroupWorksId");
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00006AE9 File Offset: 0x00004CE9
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00006AF1 File Offset: 0x00004CF1
		[DataMember(EmitDefaultValue = false, Order = 12)]
		public string Comment
		{
			get
			{
				return this.CommentField;
			}
			set
			{
				if (this.CommentField != value)
				{
					this.CommentField = value;
					this.RaisePropertyChanged("Comment");
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00006B0E File Offset: 0x00004D0E
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00006B16 File Offset: 0x00004D16
		[DataMember(IsRequired = true, Order = 13)]
		public long RefRegionId
		{
			get
			{
				return this.RefRegionIdField;
			}
			set
			{
				if (!this.RefRegionIdField.Equals(value))
				{
					this.RefRegionIdField = value;
					this.RaisePropertyChanged("RefRegionId");
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00006B38 File Offset: 0x00004D38
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00006B40 File Offset: 0x00004D40
		[DataMember(EmitDefaultValue = false, Order = 14)]
		public DateBeginEndList[] DateBeginEnd
		{
			get
			{
				return this.DateBeginEndField;
			}
			set
			{
				if (this.DateBeginEndField != value)
				{
					this.DateBeginEndField = value;
					this.RaisePropertyChanged("DateBeginEnd");
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00006B5D File Offset: 0x00004D5D
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00006B65 File Offset: 0x00004D65
		[DataMember(EmitDefaultValue = false, Order = 15)]
		public Document[] Documents
		{
			get
			{
				return this.DocumentsField;
			}
			set
			{
				if (this.DocumentsField != value)
				{
					this.DocumentsField = value;
					this.RaisePropertyChanged("Documents");
				}
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000083 RID: 131 RVA: 0x00006B84 File Offset: 0x00004D84
		// (remove) Token: 0x06000084 RID: 132 RVA: 0x00006BBC File Offset: 0x00004DBC
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000085 RID: 133 RVA: 0x00006BF4 File Offset: 0x00004DF4
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000054 RID: 84
		[NonSerialized]
		private ExtensionDataObject a;

		// Token: 0x04000055 RID: 85
		[OptionalField]
		private string NumberField;

		// Token: 0x04000056 RID: 86
		[OptionalField]
		private string AddressDisableTextField;

		// Token: 0x04000057 RID: 87
		[OptionalField]
		private AddressObjects[] AddressHousesDidableField;

		// Token: 0x04000058 RID: 88
		private long RefTypeDisableField;

		// Token: 0x04000059 RID: 89
		[OptionalField]
		private string CauseField;

		// Token: 0x0400005A RID: 90
		private DateTime DateBeginField;

		// Token: 0x0400005B RID: 91
		private long RefRequestStatusIdField;

		// Token: 0x0400005C RID: 92
		private DateTime? DatePlanField;

		// Token: 0x0400005D RID: 93
		private DateTime? DateEndField;

		// Token: 0x0400005E RID: 94
		private int ToOrganizationIdField;

		// Token: 0x0400005F RID: 95
		private int PerformerOrganizationIdField;

		// Token: 0x04000060 RID: 96
		private long RefGroupWorksIdField;

		// Token: 0x04000061 RID: 97
		[OptionalField]
		private string CommentField;

		// Token: 0x04000062 RID: 98
		private long RefRegionIdField;

		// Token: 0x04000063 RID: 99
		[OptionalField]
		private DateBeginEndList[] DateBeginEndField;

		// Token: 0x04000064 RID: 100
		[OptionalField]
		private Document[] DocumentsField;
	}
}
