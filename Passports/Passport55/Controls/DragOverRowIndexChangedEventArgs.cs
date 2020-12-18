using System;
using System.ComponentModel;

namespace Passport.Controls
{
	[Description("Класс, содержащий данные о событии изменения индекса строки под курсором, при перемещении строк")]
	public class DragOverRowIndexChangedEventArgs : EventArgs
	{
		public DragOverRowIndexChangedEventArgs(int currentRowIndex, int previousRowIndex)
		{
			this.int_0 = currentRowIndex;
			this.int_1 = previousRowIndex;
		}

		public int CurrentRowIndex
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public int PreviousRowIndex
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		private int int_0;

		private int int_1;
	}
}
