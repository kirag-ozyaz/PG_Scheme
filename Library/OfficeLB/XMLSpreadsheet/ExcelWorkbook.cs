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
	public class ExcelWorkbook
	{
		public string WindowHeight
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

		public string WindowWidth
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

		public string WindowTopX
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

		public string WindowTopY
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		public string ProtectStructure
		{
			get
			{
				return this.string_4;
			}
			set
			{
				this.string_4 = value;
			}
		}

		public string ProtectWindows
		{
			get
			{
				return this.string_5;
			}
			set
			{
				this.string_5 = value;
			}
		}

		public ExcelWorkbook()
		{
			
			
		}

		private string string_0;

		private string string_1;

		private string string_2;

		private string string_3;

		private string string_4;

		private string string_5;
	}
}
