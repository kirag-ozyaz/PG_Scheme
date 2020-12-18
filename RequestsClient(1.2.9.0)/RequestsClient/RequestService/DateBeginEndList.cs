using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace RequestsClient.RequestService
{
	// Token: 0x02000013 RID: 19
	[DataContract(Name = "DateBeginEndList", Namespace = "http://aisgorod.ru/")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[DebuggerStepThrough]
	[Serializable]
	public class DateBeginEndList : IExtensibleDataObject, INotifyPropertyChanged
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00006DAC File Offset: 0x00004FAC
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00006DB4 File Offset: 0x00004FB4
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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00006DBD File Offset: 0x00004FBD
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00006DC5 File Offset: 0x00004FC5
		[DataMember(IsRequired = true)]
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00006DE7 File Offset: 0x00004FE7
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00006DEF File Offset: 0x00004FEF
		[DataMember(IsRequired = true)]
		public DateTime DateEnd
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

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600009F RID: 159 RVA: 0x00006E14 File Offset: 0x00005014
		// (remove) Token: 0x060000A0 RID: 160 RVA: 0x00006E4C File Offset: 0x0000504C
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060000A1 RID: 161 RVA: 0x00006E84 File Offset: 0x00005084
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0400006E RID: 110
		[NonSerialized]
		private ExtensionDataObject a;

		// Token: 0x0400006F RID: 111
		private DateTime DateBeginField;

		// Token: 0x04000070 RID: 112
		private DateTime DateEndField;
	}
}
