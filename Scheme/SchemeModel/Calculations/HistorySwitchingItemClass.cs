using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SchemeModelN.Calculations
{
	public class HistorySwitchingItemClass
	{
		public DateTime switchingTime { get; set; }

		public int Action { get; set; }

		public bool IsDown
		{
			get
			{
				return this.isDown;
			}
			set
			{
				this.isDown = value;
			}
		}

		public int SwitchId { get; set; }

		public string ActionCaption
		{
			get
			{
				return this.caption;
			}
			set
			{
				this.caption = value;
				string a = this.caption;
				if (a == "Выключен")
				{
					this.Action = 0;
					return;
				}
				if (a == "Включен")
				{
					this.Action = 1;
					return;
				}
				if (this.caption.IndexOf("Добавлен статус ") >= 0)
				{
					this.Action = 2;
					return;
				}
				if (this.caption.IndexOf("Удален статус ") >= 0)
				{
					this.Action = 3;
				}
			}
		}

		public string Comment { get; set; }

		public ElectricObject ElectricObject { get; set; }

		public List<int> InvolvedObjects //  IEnumerable<int> 
        {
			get
			{
				return this.listIdObjects;
			}
		}

		public void AddInvolvedObjects(int obj)
		{
			this.listIdObjects.Add(obj);
		}

		public void AddInvolvedObjects(IEnumerable<int> obj)
		{
			this.listIdObjects.AddRange(obj);
		}

		public void DelInvolvedObjects(int obj)
		{
			this.listIdObjects.Remove(obj);
		}

		public HistorySwitchingItemClass()
		{
			
			this.listIdObjects = new List<int>();
			this.caption = string.Empty;
			
		}

		private List<int> listIdObjects;

		private string caption;

		private bool isDown;

	}
}
