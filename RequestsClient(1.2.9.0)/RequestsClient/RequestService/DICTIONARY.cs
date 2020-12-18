using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000015 RID: 21
	[DebuggerStepThrough]
	[DataContract(Name = "DICTIONARY", Namespace = "http://aisgorod.ru/")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class DICTIONARY : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00006FA8 File Offset: 0x000051A8
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00006FB0 File Offset: 0x000051B0
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00006FB9 File Offset: 0x000051B9
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00006FC1 File Offset: 0x000051C1
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

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00006FDE File Offset: 0x000051DE
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00006FE6 File Offset: 0x000051E6
		[DataMember(IsRequired = true)]
		public long Value
		{
			get
			{
				return this.ValueField;
			}
			set
			{
				if (!this.ValueField.Equals(value))
				{
					this.ValueField = value;
					this.RaisePropertyChanged("Value");
				}
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000B3 RID: 179 RVA: 0x00007008 File Offset: 0x00005208
		// (remove) Token: 0x060000B4 RID: 180 RVA: 0x00007040 File Offset: 0x00005240
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060000B5 RID: 181 RVA: 0x00007078 File Offset: 0x00005278
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000076 RID: 118
		[NonSerialized]
		private ExtensionDataObject a;

		// Token: 0x04000077 RID: 119
		[OptionalField]
		private string NameField;

		// Token: 0x04000078 RID: 120
		private long ValueField;
	}
}
