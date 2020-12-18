using System;
using System.Collections.Generic;
using System.Drawing;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.SnapPoint;
using SchemeCtrl2.Xml;

namespace SchemeCtrl2.Layers
{
	public class BackgroundLayer : IDisposable, ICanvasLayer
	{
		[XmlSerializable]
		public Color Color
		{
			get
			{
				if (this.Parent == null)
				{
					return this.color_0;
				}
				return this.Parent.Settings.BackgroundColor;
			}
			set
			{
				this.color_0 = value;
				if (this.Parent == null)
				{
					this.solidBrush_0 = new SolidBrush(this.color_0);
					return;
				}
				this.solidBrush_0 = new SolidBrush(this.Parent.Settings.BackgroundColor);
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

		public int ObjectsCount
		{
			get
			{
				return 0;
			}
		}

		public string Id
		{
			get
			{
				return "background";
			}
		}

		public BackgroundLayer(CanvasControl parent)
		{
			
			this.color_0 = Color.Black;
			
			this.canvasControl_0 = parent;
			this.solidBrush_0 = new SolidBrush(this.Color);
		}

		public void Draw(CanvasControl canvas, RectangleF unitrect)
		{
			RectangleF rect = ConvertCanvas.ConvertToScreenNormalized(canvas, unitrect);
			this.solidBrush_0 = new SolidBrush(this.Color);
			canvas.Graphics.FillRectangle(this.solidBrush_0, rect);
		}

		public PointF SnapPoint(PointF unitmousepoint)
		{
			return PointF.Empty;
		}

		ISnapPoint ICanvasLayer.SnapPoint(CanvasControl canvas, UnitPoint point, List<DrawObjectBase> otherobj)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		public IEnumerable<DrawObjectBase> Objects
		{
			get
			{
				return null;
			}
		}

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Visible
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected void Dispose(bool disposing)
		{
			if (!this.bool_0)
			{
				if (disposing)
				{
					if (this.solidBrush_0 != null)
					{
						this.solidBrush_0.Dispose();
					}
					this.canvasControl_0 = null;
				}
				this.bool_0 = true;
			}
		}

		~BackgroundLayer()
		{
			this.Dispose(false);
		}

		private SolidBrush solidBrush_0;

		private Color color_0;

		private CanvasControl canvasControl_0;

		private bool bool_0;
	}
}
