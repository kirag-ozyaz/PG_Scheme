using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000014 RID: 20
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DebuggerStepThrough]
	[DataContract(Name = "Document", Namespace = "http://aisgorod.ru/")]
	[Serializable]
	public class Document : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00006EB0 File Offset: 0x000050B0
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00006EB8 File Offset: 0x000050B8
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

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00006EC1 File Offset: 0x000050C1
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00006EC9 File Offset: 0x000050C9
		[DataMember(EmitDefaultValue = false)]
		public string Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				if (this.NameField != value)
				{
					this.NameField = value;
					this.RaisePropertyChanged("Name");
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00006EE6 File Offset: 0x000050E6
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00006EEE File Offset: 0x000050EE
		[DataMember(EmitDefaultValue = false, Order = 1)]
		public byte[] Data
		{
			get
			{
				return this.DataField;
			}
			set
			{
				if (this.DataField != value)
				{
					this.DataField = value;
					this.RaisePropertyChanged("Data");
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000A9 RID: 169 RVA: 0x00006F0C File Offset: 0x0000510C
		// (remove) Token: 0x060000AA RID: 170 RVA: 0x00006F44 File Offset: 0x00005144
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060000AB RID: 171 RVA: 0x00006F7C File Offset: 0x0000517C
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000072 RID: 114
		[NonSerialized]
		private ExtensionDataObject a;

		// Token: 0x04000073 RID: 115
		[OptionalField]
		private string NameField;

		// Token: 0x04000074 RID: 116
		[OptionalField]
		private byte[] DataField;
	}
}
