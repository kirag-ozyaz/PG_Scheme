using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000012 RID: 18
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DebuggerStepThrough]
	[DataContract(Name = "AddressObjects", Namespace = "http://aisgorod.ru/")]
	[Serializable]
	public class AddressObjects : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00006C20 File Offset: 0x00004E20
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00006C28 File Offset: 0x00004E28
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00006C31 File Offset: 0x00004E31
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00006C39 File Offset: 0x00004E39
		[DataMember(EmitDefaultValue = false)]
		public string City
		{
			get
			{
				return this.CityField;
			}
			set
			{
				if (this.CityField != value)
				{
					this.CityField = value;
					this.RaisePropertyChanged("City");
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00006C56 File Offset: 0x00004E56
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00006C5E File Offset: 0x00004E5E
		[DataMember(EmitDefaultValue = false)]
		public string CityType
		{
			get
			{
				return this.CityTypeField;
			}
			set
			{
				if (this.CityTypeField != value)
				{
					this.CityTypeField = value;
					this.RaisePropertyChanged("CityType");
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00006C7B File Offset: 0x00004E7B
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00006C83 File Offset: 0x00004E83
		[DataMember(EmitDefaultValue = false)]
		public string Street
		{
			get
			{
				return this.StreetField;
			}
			set
			{
				if (this.StreetField != value)
				{
					this.StreetField = value;
					this.RaisePropertyChanged("Street");
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00006CA0 File Offset: 0x00004EA0
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00006CA8 File Offset: 0x00004EA8
		[DataMember(EmitDefaultValue = false)]
		public string StreetType
		{
			get
			{
				return this.StreetTypeField;
			}
			set
			{
				if (this.StreetTypeField != value)
				{
					this.StreetTypeField = value;
					this.RaisePropertyChanged("StreetType");
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00006CC5 File Offset: 0x00004EC5
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00006CCD File Offset: 0x00004ECD
		[DataMember(EmitDefaultValue = false, Order = 4)]
		public string House
		{
			get
			{
				return this.HouseField;
			}
			set
			{
				if (this.HouseField != value)
				{
					this.HouseField = value;
					this.RaisePropertyChanged("House");
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00006CEA File Offset: 0x00004EEA
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00006CF2 File Offset: 0x00004EF2
		[DataMember(EmitDefaultValue = false, Order = 5)]
		public string Object
		{
			get
			{
				return this.ObjectField;
			}
			set
			{
				if (this.ObjectField != value)
				{
					this.ObjectField = value;
					this.RaisePropertyChanged("Object");
				}
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000095 RID: 149 RVA: 0x00006D10 File Offset: 0x00004F10
		// (remove) Token: 0x06000096 RID: 150 RVA: 0x00006D48 File Offset: 0x00004F48
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000097 RID: 151 RVA: 0x00006D80 File Offset: 0x00004F80
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000066 RID: 102
		[NonSerialized]
		private ExtensionDataObject a;

		// Token: 0x04000067 RID: 103
		[OptionalField]
		private string CityField;

		// Token: 0x04000068 RID: 104
		[OptionalField]
		private string CityTypeField;

		// Token: 0x04000069 RID: 105
		[OptionalField]
		private string StreetField;

		// Token: 0x0400006A RID: 106
		[OptionalField]
		private string StreetTypeField;

		// Token: 0x0400006B RID: 107
		[OptionalField]
		private string HouseField;

		// Token: 0x0400006C RID: 108
		[OptionalField]
		private string ObjectField;
	}
}
