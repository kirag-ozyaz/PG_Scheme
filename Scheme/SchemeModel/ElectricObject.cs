using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SchemeModelN
{
    /// <summary>
    /// Базовый класс объектов схемы
    /// </summary>
	public abstract class ElectricObject
	{
		public int Id { get; set; }

		public string Name { get; set; }
        /// <summary>
        /// Полное наименование объекта схемы
        /// </summary>
        public string FullName { get; set; }

        public ElectricObject Parent
		{
			get
			{
				return this.parent;
			}
			set
			{
				if (value == null)
				{
					if (this.parent != null)
					{
						this.parent.RemoveChildObject(this);
						this.parent = null;
						return;
					}
				}
				else
				{
					if (this.parent == null)
					{
						this.parent = value;
						this.parent.AddChildObject(this);
						return;
					}
					if (this.parent != value)
					{
						if (this.parent.childObjects.Contains(this))
						{
							this.parent.RemoveChildObject(this);
						}
						this.parent = value;
						this.parent.AddChildObject(this);
					}
				}
			}
		}

		public virtual IEnumerable<ElectricObject> ChildObjects
		{
			get
			{
				return this.childObjects;
			}
		}

		public ElectricModel ParentModel { get; set; }

		public object Tag { get; set; }

		public ElectricObject()
		{

		}

		public static ElectricPoint GetLinkPoint(ElectricObject objBeg, ElectricObject objEnd)
		{
			ElectricPoint result = null;
			if (objBeg is ElectricLine && objEnd is ElectricLine)
			{
				var points = ((ElectricLine)objBeg).Ends;
                //Func<ElectricPoint, bool> pPoint = null;
                //Func<ElectricPoint, bool> predicate;
                //if ((predicate = pPoint) == null)
                //{
                //	predicate = (pPoint = ((ElectricPoint p) => ((ElectricLine)objEnd).Ends.Contains(p)));
                //}
                //using (var point = points.Where(predicate).GetEnumerator())
                //{
                //	if (!point.MoveNext())
                //	{
                //		return result;
                //	}
                //	return point.Current;
                //}
      

                using (var point = points.Where((ElectricPoint p) => ((ElectricLine)objEnd).Ends.Contains(p)).GetEnumerator())
                {
                    if (!point.MoveNext())
                    {
                        return result;
                    }
                    return point.Current;
                }
            }
			ElectricBus electricBus = null;
			ElectricLine line = null;
			if (objBeg is ElectricLine && objEnd.GetType() == typeof(ElectricBus))
			{
				electricBus = (ElectricBus)objEnd;
				line = (ElectricLine)objBeg;
			}
			else if (objEnd is ElectricLine && objBeg.GetType() == typeof(ElectricBus))
			{
				electricBus = (ElectricBus)objBeg;
				line = (ElectricLine)objEnd;
			}
			if (electricBus != null && line != null)
			{
				var childObjects = electricBus.ChildObjects;
                //Func<ElectricObject, bool> pObject = null;
                //Func<ElectricObject, bool> predicate2;
                //if ((predicate2 = pObject) == null)
                //{
                //	predicate2 = (pObject = ((ElectricObject p) => p is ElectricPoint && line.Ends.Contains((ElectricPoint)p)));
                //}
                //using (var points = childObjects.Where(predicate2).GetEnumerator())
                //{
                //	if (points.MoveNext())
                //	{
                //		result = (ElectricPoint)points.Current;
                //	}
                //}

                using (var point = childObjects.Where((ElectricObject p) => p is ElectricPoint && line.Ends.Contains((ElectricPoint)p)).GetEnumerator())
                {
                    if (point.MoveNext())
                    {
                        result = (ElectricPoint)point.Current;
                    }
                }
            }
			return result;
		}

		internal virtual void ReCalcAmperage()
		{
		}

		public virtual bool RemoveChildObject(ElectricObject item)
		{
			return this.childObjects.Remove(item);
		}

		public virtual void AddChildObject(ElectricObject item)
		{
			this.childObjects.Add(item);
		}
        //internal string voltage;
        public virtual string Voltage { get; set; }

        //public virtual string GetVoltage()
        //{
        //    return null;
        //}
		public override string ToString()
		{
			return this.Name;
		}

		private ElectricObject parent;

		private List<ElectricObject> childObjects = new List<ElectricObject>();

	}

}
