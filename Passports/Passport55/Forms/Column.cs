using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Passport.Forms
{
	[DataContract]
	public class Column
	{
		[DataMember]
		public int Index { get; set; }

		[DataMember]
		public string Name { get; set; }

		public Column(int index, string name)
		{
			this.Index = index;
			this.Name = name;
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;
	}
}
