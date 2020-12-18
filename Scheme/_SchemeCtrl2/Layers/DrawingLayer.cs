using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.SnapPoint;

namespace SchemeCtrl2.Layers
{
	[Serializable]
	public class DrawingLayer : ICanvasLayer, IDisposable
	{
		public event ObjectsLayerEventHandler ObjectsAdded;

		public event ObjectsLayerEventHandler ObjectsRemoved;

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
				return this.color;
			}
			set
			{
				this.color = value;
			}
		}

		public float Width
		{
			get
			{
				return this.width;
			}
			set
			{
				this.width = value;
			}
		}

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

		public bool Enabled
		{
			get
			{
				return this.enabled && this.visible;
			}
			set
			{
				this.enabled = value;
			}
		}

		public bool Visible
		{
			get
			{
				return this.visible;
			}
			set
			{
				this.visible = value;
			}
		}

		public IEnumerable<DrawObjectBase> Objects
		{
			get
			{
				return this.objects;
			}
		}

		public int ObjectsCount
		{
			get
			{
				return this.objects.Count;
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
		}

		public DrawingLayer(string string_1, string name, Color color, float width)
		{
			this.string_0 = string_1;
			this.name = name;
			this.color = color;
			this.width = width;
		}

		protected virtual void OnObjectsAdded(List<DrawObjectBase> addObjects)
		{
			if (this.ObjectsAdded != null)
			{
				this.ObjectsAdded(addObjects);
			}
		}

		protected virtual void OnObjectsRemoved(List<DrawObjectBase> removeObjects)
		{
			if (this.ObjectsRemoved != null)
			{
				this.ObjectsRemoved(removeObjects);
			}
		}

		public void Draw(CanvasControl canvas, RectangleF unitrect)
		{
			DrawingLayer.Class5 @class = new DrawingLayer.Class5();
			@class.canvasControl_0 = canvas;
			@class.rectangleF_0 = unitrect;
			IEnumerable<DrawObjectBase> enumerable = this.objects.Where(new Func<DrawObjectBase, bool>(@class.method_0));
			foreach (DrawObjectBase drawObjectBase in enumerable)
			{
				drawObjectBase.Draw(@class.canvasControl_0, @class.rectangleF_0, eDrawMode.Color);
			}
		}

		public ISnapPoint SnapPoint(CanvasControl canvas, UnitPoint point, List<DrawObjectBase> otherobj)
		{
			foreach (DrawObjectBase drawObjectBase in this.objects)
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
			this.objects.Add(drawobject);
			this.OnObjectsAdded(new List<DrawObjectBase>
			{
				drawobject
			});
		}

		public void RemoveObject(DrawObjectBase drawobject)
		{
			drawobject.Layer = null;
			this.objects.Remove(drawobject);
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
				if (this.objects.Contains(drawObjectBase))
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
			while (this.objects.Count > 0)
			{
				DrawObjectBase drawObjectBase = this.objects[0];
				list.Add(this.objects[0]);
				this.objects[0].Remove(delSql, true);
			}
			this.OnObjectsRemoved(list);
		}

		public void ApplyFilter(List<int> idObjects)
		{
			DrawingLayer.Class6 @class = new DrawingLayer.Class6();
			@class.list_0 = idObjects;
			IEnumerable<DrawObjectBase> enumerable = this.Objects.Where(new Func<DrawObjectBase, bool>(@class.method_0));
			IEnumerable<DrawObjectBase> enumerable2 = this.Objects.Where(new Func<DrawObjectBase, bool>(@class.method_1));
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
				Class101.smethod_1(xmlElement, drawingLayer);
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
								Class101.smethod_2(xmlElement2, obj3);
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

		public void SaveToXML(XmlNode xmlNode)
		{
			XmlDocument ownerDocument = xmlNode.OwnerDocument;
			XmlElement xmlElement = ownerDocument.CreateElement("layer");
			xmlElement.SetAttribute("ID", this.Id);
			xmlNode.AppendChild(xmlElement);
			List<PointTool> list = new List<PointTool>();
			IEnumerable<DrawObjectBase> source = this.objects;
			if (DrawingLayer.CS$<>9__CachedAnonymousMethodDelegate8 == null)
			{
				DrawingLayer.CS$<>9__CachedAnonymousMethodDelegate8 = new Func<DrawObjectBase, bool>(DrawingLayer.smethod_0);
			}
			IEnumerable<DrawObjectBase> enumerable = source.Where(DrawingLayer.CS$<>9__CachedAnonymousMethodDelegate8);
			foreach (DrawObjectBase drawObjectBase in enumerable)
			{
				drawObjectBase.SaveToXML(xmlElement, list);
			}
			XmlElement xmlElement2 = ownerDocument.CreateElement("points");
			xmlNode.AppendChild(xmlElement2);
			foreach (PointTool pointTool in list)
			{
				pointTool.SaveToXML(xmlElement2, list);
			}
		}

		public void Dispose()
		{
			this.Dispose(true);
		}

		protected void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					if (this.Parent.TypeCanvas != eTypeCanvas.SchemaClone && this.objects != null)
					{
						List<DrawObjectBase> list = this.objects;
						if (DrawingLayer.CS$<>9__CachedAnonymousMethodDelegatea == null)
						{
							DrawingLayer.CS$<>9__CachedAnonymousMethodDelegatea = new Action<DrawObjectBase>(DrawingLayer.smethod_1);
						}
						list.ForEach(DrawingLayer.CS$<>9__CachedAnonymousMethodDelegatea);
						this.objects.Clear();
					}
					this.objects = null;
					this.canvasControl_0 = null;
				}
				this.disposed = true;
			}
		}

		~DrawingLayer()
		{
			this.Dispose(false);
		}

		[CompilerGenerated]
		private static bool smethod_0(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.Parent == null;
		}

		[CompilerGenerated]
		private static void smethod_1(DrawObjectBase drawObjectBase_0)
		{
			drawObjectBase_0.Dispose();
		}

		private string string_0;

		private Color color;

		private float width;

		private string name = "<Layer>";

		private bool enabled = true;

		private bool visible = true;

		private List<DrawObjectBase> objects = new List<DrawObjectBase>();

		[NonSerialized]
		private CanvasControl canvasControl_0;

		private bool disposed;

		[CompilerGenerated]
		private sealed class Class5
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0 != null && drawObjectBase_0.ObjectInRectangle(this.canvasControl_0, this.rectangleF_0, true);
			}

			public CanvasControl canvasControl_0;

			public RectangleF rectangleF_0;
		}

		[CompilerGenerated]
		private sealed class Class6
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return this.list_0.Contains(drawObjectBase_0.IdBase);
			}

			public bool method_1(DrawObjectBase drawObjectBase_0)
			{
				return !this.list_0.Contains(drawObjectBase_0.IdBase);
			}

			public List<int> list_0;
		}
	}
}
