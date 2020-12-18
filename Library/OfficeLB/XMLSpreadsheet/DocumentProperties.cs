using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	[DesignerCategory("code")]
	[XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
	[DebuggerStepThrough]
	[Serializable]
	public class DocumentProperties
	{
		public string Author
		{
			get
			{
				return this.OwpwKaEjw;
			}
			set
			{
				this.OwpwKaEjw = value;
			}
		}

		public string LastAuthor
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		public string Created
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		public string Version
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		public DocumentProperties()
		{
			
			
		}

		private string OwpwKaEjw;

		private string string_0;

		private string string_1;

		private string string_2;
	}
}
