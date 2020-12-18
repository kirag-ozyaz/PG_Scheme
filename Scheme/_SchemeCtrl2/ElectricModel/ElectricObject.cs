using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SchemeCtrl2.ElectricModel
{
	public abstract class ElectricObject
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public ElectricObject Parent
		{
			get
			{
				return this.electricObject_0;
			}
			set
			{
				if (value == null)
				{
					if (this.electricObject_0 != null)
					{
						this.electricObject_0.RemoveChildObject(this);
						this.electricObject_0 = null;
						return;
					}
				}
				else
				{
					if (this.electricObject_0 == null)
					{
						this.electricObject_0 = value;
						this.electricObject_0.AddChildObject(this);
						return;
					}
					if (this.electricObject_0 != value)
					{
						if (this.electricObject_0.list_0.Contains(this))
						{
							this.electricObject_0.RemoveChildObject(this);
						}
						this.electricObject_0 = value;
						this.electricObject_0.AddChildObject(this);
					}
				}
			}
		}

		public virtual IEnumerable<ElectricObject> ChildObjects
		{
			get
			{
				return this.list_0;
			}
		}

		public ElectricModel ParentModel { get; set; }

		public object Tag { get; set; }

		public ElectricObject()
		{
			this.method_0();
		}

		private void method_0()
		{
			this.list_0 = new List<ElectricObject>();
		}

		public static ElectricPoint GetLinkPoint(ElectricObject dob1, ElectricObject dob2)
		{
			Func<ElectricPoint, bool> func = null;
			ElectricObject.Class83 @class = new ElectricObject.Class83();
			@class.electricObject_0 = dob2;
			ElectricPoint result = null;
			if (dob1 is ElectricLine && @class.electricObject_0 is ElectricLine)
			{
				IEnumerable<ElectricPoint> ends = ((ElectricLine)dob1).Ends;
				if (func == null)
				{
					func = new Func<ElectricPoint, bool>(@class.method_0);
				}
				using (IEnumerator<ElectricPoint> enumerator = ends.Where(func).GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						ElectricPoint electricPoint = enumerator.Current;
						result = electricPoint;
					}
					return result;
				}
			}
			Func<ElectricObject, bool> func2 = null;
			ElectricObject.Class84 class2 = new ElectricObject.Class84();
			class2.class83_0 = @class;
			ElectricBus electricBus = null;
			class2.electricLine_0 = null;
			if (dob1 is ElectricLine && @class.electricObject_0.GetType() == typeof(ElectricBus))
			{
				electricBus = (ElectricBus)@class.electricObject_0;
				class2.electricLine_0 = (ElectricLine)dob1;
			}
			else if (@class.electricObject_0 is ElectricLine && dob1.GetType() == typeof(ElectricBus))
			{
				electricBus = (ElectricBus)dob1;
				class2.electricLine_0 = (ElectricLine)@class.electricObject_0;
			}
			if (electricBus != null && class2.electricLine_0 != null)
			{
				IEnumerable<ElectricObject> childObjects = electricBus.ChildObjects;
				if (func2 == null)
				{
					func2 = new Func<ElectricObject, bool>(class2.method_0);
				}
				using (IEnumerator<ElectricObject> enumerator2 = childObjects.Where(func2).GetEnumerator())
				{
					if (enumerator2.MoveNext())
					{
						ElectricObject electricObject = enumerator2.Current;
						result = (ElectricPoint)electricObject;
					}
				}
			}
			return result;
		}

		internal virtual void RecalcAmperage()
		{
		}

		public virtual bool RemoveChildObject(ElectricObject item)
		{
			return this.list_0.Remove(item);
		}

		public virtual void AddChildObject(ElectricObject item)
		{
			this.list_0.Add(item);
		}

		public override string ToString()
		{
			return this.Name;
		}

		private ElectricObject electricObject_0;

		private List<ElectricObject> list_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private ElectricModel electricModel_0;

		[CompilerGenerated]
		private object object_0;

		[CompilerGenerated]
		private sealed class Class83
		{
			public bool method_0(ElectricPoint electricPoint_0)
			{
				return ((ElectricLine)this.electricObject_0).Ends.Contains(electricPoint_0);
			}

			public ElectricObject electricObject_0;
		}

		[CompilerGenerated]
		private sealed class Class84
		{
			public bool method_0(ElectricObject electricObject_0)
			{
				return electricObject_0 is ElectricPoint && this.electricLine_0.Ends.Contains((ElectricPoint)electricObject_0);
			}

			public ElectricObject.Class83 class83_0;

			public ElectricLine electricLine_0;
		}
	}
}
