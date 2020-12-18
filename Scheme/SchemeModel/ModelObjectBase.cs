using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SchemeModelN
{
	public abstract class ModelObjectBase
	{
		public int Id { get; set; }

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		public ModelObjectBase Parent
		{
			get
			{
				return this.parent;
			}
			set
			{
				if (this.parent == null)
				{
					this.parent = value;
				}
				else
				{
					ModelObjectBase modelObjectBase = this.parent;
					this.parent = value;
					if (modelObjectBase != null)
					{
						modelObjectBase.RemoveChild(this);
					}
				}
				if (this.parent != null && !this.parent.ConteinsChild(this))
				{
					this.parent.AddChild(this);
				}
			}
		}

		public IEnumerable<ModelObjectBase> Children
		{
			get
			{
				return this.children;
			}
		}

		public int ChildrenCount
		{
			get
			{
				return this.children.Count;
			}
		}

		public void AddChild(ModelObjectBase mob)
		{
			if (mob == null)
			{
				return;
			}
			if (this.ConteinsChild(mob))
			{
				return;
			}
			this.children.Add(mob);
			if (mob.parent != this)
			{
				mob.Parent = this;
			}
		}

		public void RemoveChild(ModelObjectBase mob)
		{
			if (mob == null)
			{
				return;
			}
			if (!this.ConteinsChild(mob))
			{
				return;
			}
			this.children.Remove(mob);
			if (mob.parent == this)
			{
				mob.Parent = null;
			}
		}

		public bool ConteinsChild(ModelObjectBase mob)
		{
			return this.children.Contains(mob);
		}

		protected ModelObjectBase()
		{
			
			this.children = new List<ModelObjectBase>();
			this.name = string.Empty;
			
		}

		private ModelObjectBase parent;

		private List<ModelObjectBase> children;

		private string name;

	}
}
