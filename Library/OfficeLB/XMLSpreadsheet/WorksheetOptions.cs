using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	[XmlRoot(Namespace = "urn:schemas-microsoft-com:office:excel", IsNullable = false)]
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[Serializable]
	public class WorksheetOptions
	{
		public string Selected
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

		public string ProtectObjects
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

		public string ProtectScenarios
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

		public WorksheetOptions()
		{
			
			
		}

		private string string_0;

		private string string_1;

		private string string_2;
	}
}
