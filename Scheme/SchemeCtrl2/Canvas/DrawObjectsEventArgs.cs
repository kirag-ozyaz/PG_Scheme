using System;
using System.Collections.Generic;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.Canvas
{
	public class DrawObjectsEventArgs : EventArgs
	{
		public string NameChangedProperty
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		public List<DrawObjectBase> Objects
		{
			get
			{
				return this.list_0;
			}
		}

		public UndoRedoManager.ChangesMode ChangesMode
		{
			get
			{
				return this.changesMode_0;
			}
			set
			{
				this.changesMode_0 = value;
			}
		}

		public UnitPoint Offset
		{
			get
			{
				return this.unitPoint_0;
			}
			set
			{
				this.unitPoint_0 = value;
			}
		}

		public bool SelectedMove
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		public DrawObjectsEventArgs(DrawObjectBase drawObjectBase)
		{
			
			this.list_0 = new List<DrawObjectBase>();
			
			this.list_0.Add(drawObjectBase);
		}

		public DrawObjectsEventArgs(List<DrawObjectBase> listObjects)
		{
			
			this.list_0 = new List<DrawObjectBase>();
			
			this.list_0.AddRange(listObjects);
		}

		private List<DrawObjectBase> list_0;

		private UndoRedoManager.ChangesMode changesMode_0;

		private string string_0;

		private UnitPoint unitPoint_0;

		private bool bool_0;
	}
}
