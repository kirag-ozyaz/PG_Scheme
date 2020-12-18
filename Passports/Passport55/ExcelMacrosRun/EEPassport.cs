using System;
using System.Runtime.CompilerServices;

namespace ExcelMacrosRun
{
	public class EEPassport : IDisposable
	{
		public string FilePath { get; set; }

		public string ConnectionString
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

		public string Password
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

		public EEPassport()
		{
		}

		public EEPassport(string filePath)
		{
			this.FilePath = filePath;
		}

		public void Open()
		{
		}

		public void Dispose()
		{
		}

		[CompilerGenerated]
		private string string_0;

		private string string_1 = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";

		private string string_2 = "";
	}
}
