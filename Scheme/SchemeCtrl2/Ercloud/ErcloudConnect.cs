using System;
using System.Runtime.CompilerServices;

namespace SchemeCtrl2.Ercloud
{
	public class ErcloudConnect
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string AddressServer { get; set; }

		public int Port { get; set; }

		public string User { get; set; }

		public string Password { get; set; }

		public ErcloudConnect(int id, string name, string address, int port, string user, string password)
		{
			
			
			this.Id = id;
			this.Name = name;
			this.AddressServer = address;
			this.Port = port;
			this.User = user;
			this.Password = password;
		}

		public override string ToString()
		{
			return string.Format("{0}  (Address={1};Port={2};User={3}", new object[]
			{
				this.Name,
				this.AddressServer,
				this.Port.ToString(),
				this.User
			});
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;
	}
}
