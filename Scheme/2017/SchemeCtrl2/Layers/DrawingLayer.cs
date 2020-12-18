using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.SnapPoint;

namespace SchemeCtrl2.Layers
{
	[Serializable]
	public class DrawingLayer : IDisposable, ICanvasLayer
	{
		public event ObjectsLayerEventHandler ObjectsAdded
		{
			[CompilerGenerated]
			add
			{
				ObjectsLayerEventHandler objectsLayerEventHandler = this.objectsLayerEventHandler_0;
				ObjectsLayerEventHandler objectsLayerEventHandler2;
				do
				{
					objectsLayerEventHandler2 = objectsLayerEventHandler;
					ObjectsLayerEventHandler value2 = (ObjectsLayerEventHandler)Delegate.Combine(objectsLayerEventHandler2, value);
					objectsLayerEventHandler = Interlocked.CompareExchange<ObjectsLayerEventHandler>(ref this.objectsLayerEventHandler_0, value2, objectsLayerEventHandler2);
				}
				while (objectsLayerEventHandler != objectsLayerEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				ObjectsLayerEventHandler objectsLayerEventHandler = this.objectsLayerEventHandler_0;
				ObjectsLayerEventHandler objectsLayerEventHandler2;
				do
				{
					objectsLayerEventHandler2 = objectsLayerEventHandler;
					ObjectsLayerEventHandler value2 = (ObjectsLayerEventHandler)Delegate.Remove(objectsLayerEventHandler2, value);
					objectsLayerEventHandler = Interlocked.CompareExchange<ObjectsLayerEventHandler>(ref this.objectsLayerEventHandler_0, value2, objectsLayerEventHandler2);
				}
				while (objectsLayerEventHandler != objectsLayerEventHandler2);
			}
		}

		public event ObjectsLayerEventHandler ObjectsRemoved
		{
			[CompilerGenerated]
			add
			{
				ObjectsLayerEventHandler objectsLayerEventHandler = this.objectsLayerEventHandler_1;
				ObjectsLayerEventHandler objectsLayerEventHandler2;
				do
				{
					objectsLayerEventHandler2 = objectsLayerEventHandler;
					ObjectsLayerEventHandler value2 = (ObjectsLayerEventHandler)Delegate.Combine(objectsLayerEventHandler2, value);
					objectsLayerEventHandler = Interlocked.CompareExchange<ObjectsLayerEventHandler>(ref this.objectsLayerEventHandler_1, value2, objectsLayerEventHandler2);
				}
				while (objectsLayerEventHandler != objectsLayerEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				ObjectsLayerEventHandler objectsLayerEventHandler = this.objectsLayerEventHandler_1;
				ObjectsLayerEventHandler objectsLayerEventHandler2;
				do
				{
					objectsLayerEventHandler2 = objectsLayerEventHandler;
					ObjectsLayerEventHandler value2 = (ObjectsLayerEventHandler)Delegate.Remove(objectsLayerEventHandler2, value);
					objectsLayerEventHandler = Interlocked.CompareExchange<ObjectsLayerEventHandler>(ref this.objectsLayerEventHandler_1, value2, objectsLayerEventHandler2);
				}
				while (objectsLayerEventHandler != objectsLayerEventHandler2);
			}
		}

		public string Id
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

		public Color Color
		{
			get
			{
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
			}
		}

		public float Width
		{
			get
			{
				return this.float_0;
			}
			set
			{
				this.float_0 = value;
			}
		}

		public string Name
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		public bool Enabled
		{
			get
			{
				return this.bool_0 && this.bool_1;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		public bool Visible
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		public IEnumerable<DrawObjectBase> Objects
		{
			get
			{
				return this.list_0;
			}
		}

		public int ObjectsCount
		{
			get
			{
				return this.list_0.Count;
			}
		}

		public CanvasControl Parent
		{
			get
			{
				return this.canvasControl_0;
			}
			set
			{
				this.canvasControl_0 = value;
			}
		}

		public DrawingLayer()
		{
			Class90.TDroV38zslI2T();
			this.string_1 = "<Layer>";
			this.bool_0 = true;
			this.bool_1 = true;
			this.list_0 = new List<DrawObjectBase>();
			base..ctor();
		}

		public DrawingLayer(string id, string name, Color color, float width)
		{
			Class90.TDroV38zslI2T();
			this.string_1 = "<Layer>";
			this.bool_0 = true;
			this.bool_1 = true;
			this.list_0 = new List<DrawObjectBase>();
			base..ctor();
			this.string_0 = id;
			this.string_1 = name;
			this.color_0 = color;
			this.float_0 = width;
		}

		protected virtual void OnObjectsAdded(List<DrawObjectBase> addObjects)
		{
			if (this.objectsLayerEventHandler_0 != null)
			{
				this.objectsLayerEventHandler_0(addObjects);
			}
		}

		protected virtual void OnObjectsRemoved(List<DrawObjectBase> removeObjects)
		{
			if (this.objectsLayerEventHandler_1 != null)
			{
				this.objectsLayerEventHandler_1(removeObjects);
			}
		}

		public void Draw(CanvasControl canvas, RectangleF unitrect)
		{
			foreach (DrawObjectBase drawObjectBase in from obj in this.list_0
			where obj != null && obj.ObjectInRectangle(canvas, unitrect, true)
			select obj)
			{
				drawObjectBase.Draw(canvas, unitrect, eDrawMode.Color);
			}
		}

		public ISnapPoint SnapPoint(CanvasControl canvas, UnitPoint point, List<DrawObjectBase> otherobj)
		{
			foreach (DrawObjectBase drawObjectBase in this.list_0)
			{
				ISnapPoint snapPoint = drawObjectBase.SnapPoint(canvas, point, otherobj, null, null);
				if (snapPoint != null)
				{
					return snapPoint;
				}
			}
			return null;
		}

		public void AddObject(DrawObjectBase drawobject)
		{
			if ((this.Parent != null && this.Parent.TypeCanvas != eTypeCanvas.SchemaClone) || drawobject.Layer == null)
			{
				drawobject.Layer = this;
			}
			this.list_0.Add(drawobject);
			this.OnObjectsAdded(new List<DrawObjectBase>
			{
				drawobject
			});
		}

		public void RemoveObject(DrawObjectBase drawobject)
		{
			drawobject.Layer = null;
			this.list_0.Remove(drawobject);
			this.OnObjectsRemoved(new List<DrawObjectBase>
			{
				drawobject
			});
		}

		public List<DrawObjectBase> DeleteObjects(IEnumerable<DrawObjectBase> delObjects, bool delSql)
		{
			if (!this.Enabled)
			{
				return null;
			}
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in delObjects)
			{
				if (this.list_0.Contains(drawObjectBase))
				{
					drawObjectBase.Remove(delSql, true);
					list.Add(drawObjectBase);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			this.OnObjectsRemoved(list);
			return list;
		}

		public void Clear(bool delSql)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			while (this.list_0.Count > 0)
			{
				DrawObjectBase drawObjectBase = this.list_0[0];
				list.Add(this.list_0[0]);
				this.list_0[0].Remove(delSql, true);
			}
			this.OnObjectsRemoved(list);
		}

		public void ApplyFilter(List<int> idObjects)
		{
			IEnumerable<DrawObjectBase> enumerable = from obj in this.Objects
			where idObjects.Contains(obj.IdBase)
			select obj;
			IEnumerable<DrawObjectBase> enumerable2 = from obj in this.Objects
			where !idObjects.Contains(obj.IdBase)
			select obj;
			foreach (DrawObjectBase drawObjectBase in enumerable)
			{
				drawObjectBase.Visible = true;
			}
			foreach (DrawObjectBase drawObjectBase2 in enumerable2)
			{
				drawObjectBase2.Visible = false;
			}
		}

		public void ClearFilter()
		{
			foreach (DrawObjectBase drawObjectBase in this.Objects)
			{
				drawObjectBase.Visible = true;
			}
		}

		public static DrawingLayer NewLayer(XmlElement xmlelement)
		{
			string text = xmlelement.GetAttribute("Id");
			if (text.Length == 0)
			{
				text = Guid.NewGuid().ToString();
			}
			DrawingLayer drawingLayer = new DrawingLayer(text, string.Empty, Color.White, 0f);
			foreach (object obj in xmlelement.ChildNodes)
			{
				XmlElement xmlElement = (XmlElement)obj;
				Class2.smethod_1(xmlElement, drawingLayer);
				if (xmlElement.Name == "items")
				{
					foreach (object obj2 in xmlElement.ChildNodes)
					{
						XmlElement xmlElement2 = (XmlElement)obj2;
						object obj3 = CanvasControl.CreateObject(xmlElement2.Name);
						if (obj3 != null)
						{
							if (obj3 != null)
							{
								Class2.smethod_2(xmlElement2, obj3);
							}
							if (obj3 is Interface0)
							{
								((Interface0)obj3).imethod_1();
							}
							if (obj3 is DrawObjectBase)
							{
								drawingLayer.AddObject(obj3 as DrawObjectBase);
							}
						}
					}
				}
			}
			return drawingLayer;
		}

		public void method_0(XmlNode xmlNode)
		{
			XmlDocument ownerDocument = xmlNode.OwnerDocument;
			XmlElement xmlElement = ownerDocument.CreateElement("layer");
			xmlElement.SetAttribute("ID", this.Id);
			xmlNode.AppendChild(xmlElement);
			List<PointTool> list = new List<PointTool>();
			foreach (DrawObjectBase drawObjectBase in from drawobject in this.list_0
			where drawobject.Parent == null
			select drawobject)
			{
				drawObjectBase.vmethod_0(xmlElement, list);
			}
			XmlElement xmlElement2 = ownerDocument.CreateElement("points");
			xmlNode.AppendChild(xmlElement2);
			foreach (PointTool pointTool in list)
			{
				pointTool.vmethod_0(xmlElement2, list);
			}
		}

		public void Dispose()
		{
			this.Dispose(true);
		}

		protected void Dispose(bool disposing)
		{
			if (!this.bool_2)
			{
				if (disposing)
				{
					if (this.Parent.TypeCanvas != eTypeCanvas.SchemaClone && this.list_0 != null)
					{
						this.list_0.ForEach(delegate(DrawObjectBase i)
						{
							i.Dispose();
						});
						this.list_0.Clear();
					}
					this.list_0 = null;
					this.canvasControl_0 = null;
				}
				this.bool_2 = true;
			}
		}

		~DrawingLayer()
		{
			this.Dispose(false);
		}

		[CompilerGenerated]
		private ObjectsLayerEventHandler objectsLayerEventHandler_0;

		[CompilerGenerated]
		private ObjectsLayerEventHandler objectsLayerEventHandler_1;

		private string string_0;

		private Color color_0;

		private float float_0;

		private string string_1;

		private bool bool_0;

		private bool bool_1;

		private List<DrawObjectBase> list_0;

		[NonSerialized]
		private CanvasControl canvasControl_0;

		private bool bool_2;
	}
}
