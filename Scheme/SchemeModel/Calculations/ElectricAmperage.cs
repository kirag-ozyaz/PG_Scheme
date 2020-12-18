using Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SchemeModelN.Calculations
{
    /// <summary>
    /// Запитка объекта схемы
    /// </summary>
	[TypeConverter(typeof(AmperageConverte))]
	public class ElectricAmperage
	{
        public List<ElectricAmperage> xMediators // internal
        {
            get
            {
                return this.mediators;
            }
            set
            {
                value = this.mediators;
            }
        }
        /// <summary>
        /// посредники (предыдущие объекты)
        /// </summary>
        public IEnumerable<ElectricAmperage> Mediators // internal
        {
            get
            {
                return this.mediators;
            }
        }
        /// <summary>
        /// проводник текущий
        /// </summary>
        public ElectricObject Conductor
        {
            get
            {
                return this.conductor;
            }
            set
            {
                this.conductor = value;
            }
        }

        public List<ElectricAmperage> NextAmperages() // internal
        {
			return this.nextAmperages;
		}
        /// <summary>
        /// источник питания - запитка (на данный момент шина)
        /// </summary>
		public ElectricObject Source
		{
			get
			{
				return this.source;
			}
			set
			{
				this.source = value;
			}
		}

		internal ElectricAmperage(ElectricObject source, ElectricObject conductor, AmperageProperties amperageProperties, ElectricAmperage mediator)
		{
			this.nextAmperages = new List<ElectricAmperage>();
			this.mediators = new List<ElectricAmperage>();
			
			this.AmperageProperty = amperageProperties;
			this.Source = source;
			this.conductor = conductor;
			if (conductor != source)
			{
				this.AddMediator(mediator);
			}
		}
        /// <summary>
        /// сформируем характеристики шины на основании ElectricLine
        /// </summary>
        /// напряжение, мошность и ....
        public ElectricAmperage PassOn(ElectricObject conductor) // internal
        {
			ElectricAmperage amperage = new ElectricAmperage(this.Source, conductor, this.AmperageProperty, this);
			if (conductor.GetType() == typeof(ElectricBus))
			{
				if (this.AmperageProperty.Voltage < ((ElectricBus)conductor).GetVoltage())
				{
					return null;
				}
				amperage.AmperageProperty = new AmperageProperties(((ElectricBus)conductor).GetVoltage(), this.AmperageProperty.Amperages, this.AmperageProperty.Power);
			}
			this.nextAmperages.Add(amperage);
			return amperage;
		}

		internal ElectricAmperage PassOn(ElectricObject conductor, AmperageProperties newProperty)
		{
			ElectricAmperage amperage = new ElectricAmperage(this.Source, conductor, newProperty, this);
			this.nextAmperages.Add(amperage);
			return amperage;
		}

		internal ElectricAmperage Clone(ElectricObject conductor)
		{
			ElectricAmperage amperage = new ElectricAmperage(this.Source, conductor, this.AmperageProperty, this);
			foreach (ElectricAmperage electricAmperage_ in this.mediators)
			{
				amperage.AddMediator(electricAmperage_);
			}
			return amperage;
		}

		internal void OffAmperage()
		{
			while (this.mediators.Count > 0)
			{
				this.RemoveMediator(this.mediators[0]);
			}
			if (this.conductor.GetType() == typeof(ElectricBus))
			{
				((ElectricBus)this.conductor).Amperage = null;
				this.RemoveNextAmperage();
			}
			else
			{
				((ElectricLine)this.conductor).RemoveAmperage(this);
			}
			this.conductor.ReCalcAmperage();
		}

		internal void RemoveNextAmperage()
		{
			int count = this.nextAmperages.Count;
			for (int i = 0; i < this.nextAmperages.Count; i++)
			{
				this.nextAmperages[i].RemoveMediator(this);
				if (count > this.nextAmperages.Count)
				{
					count = this.nextAmperages.Count;
					i--;
				}
			}
			this.nextAmperages.Clear();
		}

        public void AddMediator(ElectricAmperage mediator) // internal
        {
			this.mediators.Add(mediator);
		}

		internal void RemoveMediator(ElectricAmperage mediator)
		{
			if (this.mediators.Count == 1 && this.conductor != this.source)
			{
				this.RemoveNextAmperage();
				if (this.conductor.GetType() == typeof(ElectricBus))
				{
					((ElectricBus)this.conductor).Amperage = null;
				}
				else if (this.conductor.GetType() == typeof(ElectricLine))
				{
					((ElectricLine)this.conductor).RemoveAmperage(this);
					((ElectricLine)this.conductor).ReCalcAmperage();
				}
			}
			this.mediators.Remove(mediator);
			mediator.nextAmperages.Remove(this);
		}

		public  List<ElectricObject> GetPowerSource() // internal
        {
			List<ElectricObject> list = new List<ElectricObject>();
			this.RunOnMediators(list, this, null, null);
			return list;
		}

		internal bool PowerSourceConteins(ElectricObject desiredObject)
		{
			List<ElectricObject> list_ = new List<ElectricObject>();
			return this.RunOnMediators(list_, this.conductor, desiredObject);
		}

		private bool RunOnMediators(List<ElectricObject> list, ElectricAmperage amperage, ElectricAmperage nextAmperage, ElectricObject desiredObject)
        {
            ElectricObject electricObject = amperage.conductor;
            if (electricObject == desiredObject)
            {
                return true;
            }
            if (electricObject.GetType() == typeof(ElectricLine))
            {
                if (nextAmperage == null)
                {
                    list.Add(electricObject);
                    foreach (var electricAmperage_2 in amperage.mediators)
                    {
                        if (this.RunOnMediators(list, electricAmperage_2, amperage, desiredObject))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                foreach (var enumerator2 in ((ElectricLine)electricObject).Amperages.Values)
                {
                    if (enumerator2 == amperage)
                    {
                        list.Add(electricObject);
                        foreach (ElectricAmperage electricAmperage_3 in amperage.mediators)
                        {
                            if (this.RunOnMediators(list, electricAmperage_3, amperage, desiredObject))
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
            if (electricObject.GetType() != typeof(ElectricBus))
			{
				return false;
			}
			list.Add(electricObject);

            foreach (var amperage5 in amperage.mediators)
            {
                if (this.RunOnMediators(list, amperage5, amperage, desiredObject))
                {
                    return true;
                }
            }
            return false;

            //bool result;
            //return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="conductor">основной объект</param>
        /// <param name="desiredObject">искомый объект</param>
        /// <returns></returns>
        private bool RunOnMediators(List<ElectricObject> list, ElectricObject conductor, ElectricObject desiredObject)
        {

            //Log.Write(LogLevel.Debug, "SchemeModelN", "ElectricAmperage", "RunOnMediators", string.Format("-Conductor: ({0}, {1}) desiredObject ({2}, {3}, {4}) ", new object[] { conductor.FullName, conductor.Id, desiredObject.Name, desiredObject.Id, desiredObject.FullName }), null);
            try
            {
                if (conductor.GetType() == typeof(ElectricLine))
                {
                    foreach (var electricAmperage in ((ElectricLine)conductor).Amperages.Values)
                    {
                        foreach (ElectricAmperage electricAmperageMed in electricAmperage.mediators)
                        {
                            ElectricObject electricObject = electricAmperageMed.conductor;

                            //Log.Write(LogLevel.Debug, "SchemeModelN", "ElectricAmperage", "RunOnMediators", string.Format("--ElectricLine: ({0}, {1}, {2}) ", new object[] { electricObject.Name, electricObject.Id, electricObject.FullName }), null);

                            bool flag = true;
                            if (electricObject == desiredObject)
                            {
                                return true;
                            }
                            if (electricObject.GetType() == typeof(ElectricLine))
                            {
                                foreach (ElectricRelation Edge in ((ElectricLine)electricObject).Relations)
                                {
                                    // ошибка 
                                    //Log.Write(LogLevel.Debug, "SchemeModelN", "ElectricAmperage", "RunOnMediators", string.Format("---Edge: ({0}, {1}) ", new object[] { Edge.Name, Edge.Id }), null);
                                    if (Edge.amperagePoint != null && ((ElectricLine)electricObject).Amperages[Edge.amperagePoint] == electricAmperageMed)
                                    {
                                        if (!list.Contains(Edge))
                                        {
                                            //Log.Write(LogLevel.Debug, "SchemeModelN", "ElectricAmperage", "RunOnMediators", string.Format("++++ElectricLine: ({0}, {1}, {2}) ", new object[] { electricObject.Name, electricObject.Id, electricObject.FullName }), null);
                                            list.Add(Edge);
                                        }
                                        else
                                        {
                                            flag = false;
                                        }
                                    }
                                }
                                if (flag && this.RunOnMediators(list, electricObject, desiredObject))
                                {
                                    return true;
                                }
                            }
                            else if (!list.Contains(electricObject))
                            {
                                list.Add(electricObject);
                                //Log.Write(LogLevel.Debug, "SchemeModelN", "ElectricAmperage", "RunOnMediators", string.Format("++++electricObject: ({0}, {1}) ", new object[] { electricObject.Name, electricObject.Id }), null);

                                if (electricObject != electricAmperageMed.source && this.RunOnMediators(list, electricObject, desiredObject))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                    return false;
                }
                if (conductor.GetType() != typeof(ElectricBus))
                {
                    return false;
                }
                using (var enumerator2 = ((ElectricBus)conductor).Amperage.mediators.GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        ElectricAmperage electricAmperage3 = enumerator2.Current;
                        ElectricObject electricObject2 = electricAmperage3.conductor;
                        if (electricObject2 == desiredObject)
                        {
                            return true;
                        }
                        if (!list.Contains(electricObject2))
                        {
                            list.Add(electricObject2);
                            //Log.Write(LogLevel.Debug, "SchemeModelN", "ElectricAmperage", "RunOnMediators", string.Format("++++electricObject2: ({0}, {1}) ", new object[] { electricObject2.Name, electricObject2.Id }), null);

                            if (electricObject2 != electricAmperage3.source && this.RunOnMediators(list, electricObject2, desiredObject))
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
                //bool result;
                //return result;
            }
            catch
            {
                throw new Exception("ошибка переполнение стека");
            }
        }

		private List<ElectricAmperage> nextAmperages;

		private ElectricObject conductor;

		private ElectricObject source;

		private List<ElectricAmperage> mediators;

		internal AmperageProperties AmperageProperty;
	}
}
