using System;
using System.Collections.Generic;
using System.ComponentModel;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.ElectricModel.Calculations
{
	[TypeConverter(typeof(Class93))]
	public class Amperage
	{
		public IEnumerable<Amperage> Mediators
		{
			get
			{
				return this.list_1;
			}
		}

		public ElectricObject Conductor
		{
			get
			{
				return this.electricObject_0;
			}
			set
			{
				this.electricObject_0 = value;
			}
		}

		public List<Amperage> NextAmperages
		{
			get
			{
				return this.list_0;
			}
		}

		public ElectricObject Source
		{
			get
			{
				return this.electricObject_1;
			}
			set
			{
				this.electricObject_1 = value;
			}
		}

		public Amperage(ElectricObject source, ElectricObject conductor, AmperageProperties amperageProperties, Amperage mediator)
		{
			this.amperageProperties = amperageProperties;
			this.Source = source;
			this.electricObject_0 = conductor;
			if (conductor != source)
			{
				this.AddMediator(mediator);
			}
		}

		public Amperage PassOn(ElectricObject conductor)
		{
			Amperage amperage = new Amperage(this.Source, conductor, this.amperageProperties, this);
			if (conductor.GetType() == typeof(ElectricBus))
			{
				if (this.amperageProperties.voltage < ((ElectricBus)conductor).GetVoltage())
				{
					return null;
				}
				amperage.amperageProperties = new AmperageProperties(((ElectricBus)conductor).GetVoltage(), this.amperageProperties.amperage, this.amperageProperties.power);
			}
			this.list_0.Add(amperage);
			return amperage;
		}

		public Amperage PassOn(ElectricObject conductor, AmperageProperties newProperty)
		{
			Amperage amperage = new Amperage(this.Source, conductor, newProperty, this);
			this.list_0.Add(amperage);
			return amperage;
		}

		public Amperage Clone(ElectricObject conductor)
		{
			Amperage amperage = new Amperage(this.Source, conductor, this.amperageProperties, this);
			foreach (Amperage mediator in this.list_1)
			{
				amperage.AddMediator(mediator);
			}
			return amperage;
		}

		public void OffAmperage()
		{
			while (this.list_1.Count > 0)
			{
				this.RemoveMediator(this.list_1[0]);
			}
			if (this.electricObject_0.GetType() == typeof(ShinaTool))
			{
				((ElectricBus)this.electricObject_0).Amperage = null;
				this.KillNextAmperage();
			}
			else
			{
				((ElectricLine)this.electricObject_0).RemoveAmperage(this);
			}
			this.electricObject_0.RecalcAmperage();
		}

		public void KillNextAmperage()
		{
			while (this.list_0.Count > 0)
			{
				this.list_0[0].RemoveMediator(this);
			}
		}

		public void AddMediator(Amperage mediator)
		{
			this.list_1.Add(mediator);
		}

		public void RemoveMediator(Amperage mediator)
		{
			if (this.list_1.Count == 1 && this.electricObject_0 != this.electricObject_1)
			{
				this.KillNextAmperage();
				if (this.electricObject_0.GetType() == typeof(ElectricBus))
				{
					((ElectricBus)this.electricObject_0).Amperage = null;
				}
				else if (this.electricObject_0.GetType() == typeof(ElectricLine))
				{
					((ElectricLine)this.electricObject_0).RemoveAmperage(this);
					((ElectricLine)this.electricObject_0).RecalcAmperage();
				}
			}
			this.list_1.Remove(mediator);
			mediator.list_0.Remove(this);
		}

		public List<ElectricObject> GetPowerSource()
		{
			List<ElectricObject> list = new List<ElectricObject>();
			this.method_0(list, this, null, null);
			return list;
		}

		public bool PowerSourceConteins(ElectricObject desiredObject)
		{
			List<ElectricObject> list_ = new List<ElectricObject>();
			return this.method_1(list_, this.electricObject_0, desiredObject);
		}

		private bool method_0(List<ElectricObject> list_2, Amperage amperage_0, Amperage amperage_1, ElectricObject electricObject_2)
		{
			ElectricObject electricObject = amperage_0.electricObject_0;
			if (electricObject == electricObject_2)
			{
				return true;
			}
			if (electricObject.GetType() == typeof(ElectricLine))
			{
				if (amperage_1 == null)
				{
					list_2.Add(electricObject);
					using (List<Amperage>.Enumerator enumerator = amperage_0.list_1.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Amperage amperage_2 = enumerator.Current;
							if (this.method_0(list_2, amperage_2, amperage_0, electricObject_2))
							{
								return true;
							}
						}
						return false;
					}
				}
				using (Dictionary<ElectricPoint, Amperage>.ValueCollection.Enumerator enumerator2 = ((ElectricLine)electricObject).Amperages.Values.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Amperage amperage = enumerator2.Current;
						if (amperage == amperage_0)
						{
							list_2.Add(electricObject);
							foreach (Amperage amperage_3 in amperage_0.list_1)
							{
								if (this.method_0(list_2, amperage_3, amperage_0, electricObject_2))
								{
									return true;
								}
							}
						}
					}
					return false;
				}
			}
			if (electricObject.GetType() != typeof(ShinaTool))
			{
				return false;
			}
			list_2.Add(electricObject);
			using (List<Amperage>.Enumerator enumerator4 = amperage_0.list_1.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					Amperage amperage_4 = enumerator4.Current;
					if (this.method_0(list_2, amperage_4, amperage_0, electricObject_2))
					{
						return true;
					}
				}
				return false;
			}
			bool result;
			return result;
		}

		private bool method_1(List<ElectricObject> list_2, ElectricObject electricObject_2, ElectricObject electricObject_3)
		{
			if (electricObject_2.GetType() == typeof(ElectricLine))
			{
				using (Dictionary<ElectricPoint, Amperage>.ValueCollection.Enumerator enumerator = ((ElectricLine)electricObject_2).Amperages.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Amperage amperage = enumerator.Current;
						foreach (Amperage amperage2 in amperage.list_1)
						{
							ElectricObject electricObject = amperage2.electricObject_0;
							bool flag = true;
							if (electricObject == electricObject_3)
							{
								return true;
							}
							if (electricObject.GetType() == typeof(ElectricLine))
							{
								foreach (ElectricRelation electricRelation in ((ElectricLine)electricObject).Relations)
								{
									if (electricRelation.amperagePoint != null && ((ElectricLine)electricObject).Amperages[electricRelation.amperagePoint] == amperage2)
									{
										if (!list_2.Contains(electricRelation))
										{
											list_2.Add(electricRelation);
										}
										else
										{
											flag = false;
										}
									}
								}
								if (flag && this.method_1(list_2, electricObject, electricObject_3))
								{
									return true;
								}
							}
							else if (!list_2.Contains(electricObject))
							{
								list_2.Add(electricObject);
								if (electricObject != amperage2.electricObject_1 && this.method_1(list_2, electricObject, electricObject_3))
								{
									return true;
								}
							}
						}
					}
					return false;
				}
			}
			if (electricObject_2.GetType() != typeof(ElectricBus))
			{
				return false;
			}
			using (List<Amperage>.Enumerator enumerator4 = ((ElectricBus)electricObject_2).Amperage.list_1.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					Amperage amperage3 = enumerator4.Current;
					ElectricObject electricObject2 = amperage3.electricObject_0;
					if (electricObject2 == electricObject_3)
					{
						return true;
					}
					if (!list_2.Contains(electricObject2))
					{
						list_2.Add(electricObject2);
						if (electricObject2 != amperage3.electricObject_1 && this.method_1(list_2, electricObject2, electricObject_3))
						{
							return true;
						}
					}
				}
				return false;
			}
			bool result;
			return result;
		}

		private List<Amperage> list_0 = new List<Amperage>();

		private ElectricObject electricObject_0;

		private ElectricObject electricObject_1;

		private List<Amperage> list_1 = new List<Amperage>();

		public AmperageProperties amperageProperties;
	}
}
