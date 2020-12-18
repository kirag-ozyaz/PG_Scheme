using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000003 RID: 3
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DataContract(Name = "Response", Namespace = "http://aisgorod.ru/")]
	[DebuggerStepThrough]
	[Serializable]
	public class Response : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000209B File Offset: 0x0000029B
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000020A3 File Offset: 0x000002A3
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020AC File Offset: 0x000002AC
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000020B4 File Offset: 0x000002B4
		[DataMember(IsRequired = true)]
		public int Code
		{
			get
			{
				return this.CodeField;
			}
			set
			{
				if (!this.CodeField.Equals(value))
				{
					this.CodeField = value;
					this.RaisePropertyChanged("Code");
				}
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020D6 File Offset: 0x000002D6
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000020DE File Offset: 0x000002DE
		[DataMember(EmitDefaultValue = false)]
		public string Message
		{
			get
			{
				return this.MessageField;
			}
			set
			{
				if (this.MessageField != value)
				{
					this.MessageField = value;
					this.RaisePropertyChanged("Message");
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020FB File Offset: 0x000002FB
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002103 File Offset: 0x00000303
		[DataMember(IsRequired = true)]
		public long RequestId
		{
			get
			{
				return this.RequestIdField;
			}
			set
			{
				if (!this.RequestIdField.Equals(value))
				{
					this.RequestIdField = value;
					this.RaisePropertyChanged("RequestId");
				}
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000C RID: 12 RVA: 0x00002128 File Offset: 0x00000328
		// (remove) Token: 0x0600000D RID: 13 RVA: 0x00002160 File Offset: 0x00000360
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600000E RID: 14 RVA: 0x00002198 File Offset: 0x00000398
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000003 RID: 3
		[NonSerialized]
		private ExtensionDataObject a;

		// Token: 0x04000004 RID: 4
		private int CodeField;

		// Token: 0x04000005 RID: 5
		[OptionalField]
		private string MessageField;

		// Token: 0x04000006 RID: 6
		private long RequestIdField;
	}
}
