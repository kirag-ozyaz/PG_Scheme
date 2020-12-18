using System;
using System.Runtime.CompilerServices;

namespace Passport.Forms
{
	public class TreeNodeData
	{
		public TreeNodeData(int Id, int TypeCodeId, string Name, string Text, decimal Voltage, int idParentAddl)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.Id = Id;
			this.TypeCodeId = TypeCodeId;
			this.Name = Name;
			this.Text = Text;
			this.Voltage = Voltage;
			this.IdParentAddl = idParentAddl;
		}

		public TreeNodeData(int Id, int IdParent, int TypeCodeId, string Name, string Text, int CountChild)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.Id = Id;
			this.IdParent = IdParent;
			this.TypeCodeId = TypeCodeId;
			this.Name = Name;
			this.Text = Text;
			this.CountChild = CountChild;
		}

		public int Id { get; set; }

		public int IdParent { get; set; }

		public int TypeCodeId { get; set; }

		public string Name { get; set; }

		public string Text { get; set; }

		public decimal Voltage { get; set; }

		public int IdParentAddl { get; set; }

		public int CountChild { get; set; }

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private decimal decimal_0;

		[CompilerGenerated]
		private int int_3;

		[CompilerGenerated]
		private int int_4;
	}
}
