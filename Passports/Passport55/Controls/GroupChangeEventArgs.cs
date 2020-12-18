using System;
using System.ComponentModel;

namespace Passport.Controls
{
	[Description("Класс, содержащий данные о событии изменения группы параметра при перемещении строк")]
	public class GroupChangeEventArgs : EventArgs
	{
		public GroupChangeEventArgs(int RowIndex, string CharName, string OldGroupName, string NewGroupName)
		{
			this.int_0 = RowIndex;
			this.string_0 = CharName;
			this.string_1 = OldGroupName;
			this.string_2 = NewGroupName;
		}

		[Description("Получает новый индекс перемещаемой строки")]
		public int RowIndex
		{
			get
			{
				return this.int_0;
			}
		}

		[Description("Получает имя перемещаемого параметра")]
		public string CharName
		{
			get
			{
				return this.string_0;
			}
		}

		[Description("Получает имя группы из которой переместили параметер")]
		public string OldGroupName
		{
			get
			{
				return this.string_1;
			}
		}

		[Description("Получает имя группы в которую переместили параметер")]
		public string NewGroupName
		{
			get
			{
				return this.string_2;
			}
		}

		private int int_0;

		private string string_0;

		private string string_1;

		private string string_2;
	}
}
