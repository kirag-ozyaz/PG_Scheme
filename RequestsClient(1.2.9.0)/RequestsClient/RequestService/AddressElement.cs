using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000016 RID: 22
	[DataContract(Name = "AddressElement", Namespace = "http://aisgorod.ru/")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class AddressElement : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000070A4 File Offset: 0x000052A4
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000070AC File Offset: 0x000052AC
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

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000070B5 File Offset: 0x000052B5
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000070BD File Offset: 0x000052BD
		[DataMember(IsRequired = true)]
		public long Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!this.IdField.Equals(value))
				{
					this.IdField = value;
					this.RaisePropertyChanged("Id");
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000070DF File Offset: 0x000052DF
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000070E7 File Offset: 0x000052E7
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00007104 File Offset: 0x00005304
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000710C File Offset: 0x0000530C
		[DataMember(EmitDefaultValue = false, Order = 2)]
		public string Designation
		{
			get
			{
				return this.DesignationField;
			}
			set
			{
				if (this.DesignationField != value)
				{
					this.DesignationField = value;
					this.RaisePropertyChanged("Designation");
				}
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000BF RID: 191 RVA: 0x0000712C File Offset: 0x0000532C
		// (remove) Token: 0x060000C0 RID: 192 RVA: 0x00007164 File Offset: 0x00005364
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060000C1 RID: 193 RVA: 0x0000719C File Offset: 0x0000539C
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400007A RID: 122
		[NonSerialized]
		private ExtensionDataObject a;

		// Token: 0x0400007B RID: 123
		private long IdField;

		// Token: 0x0400007C RID: 124
		[OptionalField]
		private string NameField;

		// Token: 0x0400007D RID: 125
		[OptionalField]
		private string DesignationField;
	}
}
