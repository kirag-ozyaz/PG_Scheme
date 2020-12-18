using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Layers;

internal class Control0 : CanvasControl
{
	public CanvasControl method_95()
	{
		return this.canvasControl_1;
	}

	public void method_96(CanvasControl canvasControl_2)
	{
		this.canvasControl_1 = canvasControl_2;
	}

	public override bool StatusStripVisible
	{
		get
		{
			return false;
		}
	}

	public RectangleF method_97()
	{
		return this.rectangleF_2;
	}

	public void method_98(RectangleF rectangleF_3)
	{
		this.rectangleF_2 = rectangleF_3;
		base.DoInvalidate(false);
	}

	public float method_99()
	{
		return this.float_3;
	}

	public void method_100(float float_5)
	{
		this.float_3 = float_5;
	}

	public float method_101()
	{
		return this.float_4;
	}

	public void method_102(float float_5)
	{
		this.float_4 = float_5;
	}

	public Control0()
	{
		base.Zoom = 1f;
		base.StatusStripVisible = false;
		this.backgroundLayer_1 = new BackgroundLayer(this);
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		Rectangle clipRectangle = paintEventArgs_0.ClipRectangle;
		if (this.staticImage == null)
		{
			this.staticImage = new Bitmap(base.ClientRectangle.Width, base.ClientRectangle.Height);
			this.staticRepaint = true;
		}
		RectangleF unitrect = ConvertCanvas.ConvertToUnitNormalized(this, clipRectangle);
		if (this.staticRepaint)
		{
			base.Graphics = Graphics.FromImage(this.staticImage);
			this.staticRepaint = false;
			this.backgroundLayer_1.Draw(this, unitrect);
			if (base.Enabled && this.method_95() != null)
			{
				foreach (ICanvasLayer canvasLayer in this.method_95().Layers)
				{
					DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
					if (drawingLayer.Visible)
					{
						drawingLayer.Draw(this, unitrect);
					}
				}
			}
		}
		paintEventArgs_0.Graphics.DrawImage(this.staticImage, clipRectangle, clipRectangle, GraphicsUnit.Pixel);
		if (this.method_97() != RectangleF.Empty)
		{
			RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(this, this.method_97());
			paintEventArgs_0.Graphics.DrawRectangle(new Pen(Color.White, 5f), rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
		}
		base.Graphics = paintEventArgs_0.Graphics;
		this.staticRepaint = false;
	}

	protected override void OnMouseWheel(MouseEventArgs mouseEventArgs_0)
	{
	}

	protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		PointF screenpoint = new PointF((float)mouseEventArgs_0.X, (float)mouseEventArgs_0.Y);
		UnitPoint center = ConvertCanvas.ConvertToUnit(this, screenpoint);
		if (mouseEventArgs_0.Button == MouseButtons.Left && this.method_95() != null)
		{
			this.method_95().SetCenter(center);
			this.method_95().DoInvalidate(true);
		}
	}

	protected override void OnResize(EventArgs eventArgs_0)
	{
		base.OnResize(eventArgs_0);
		if (this.method_95() != null)
		{
			base.Graphics = Graphics.FromHwnd(base.Handle);
			RectangleF rectangleF = new RectangleF(new PointF(0f, 0f), new SizeF(0f, 0f));
			new List<DrawObjectBase>();
			foreach (ICanvasLayer canvasLayer in this.method_95().Layers)
			{
				DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
				foreach (DrawObjectBase drawObjectBase in drawingLayer.Objects)
				{
					RectangleF boundingRect = drawObjectBase.GetBoundingRect(this, false);
					if (rectangleF.X > boundingRect.X)
					{
						rectangleF.X = boundingRect.X;
					}
					if (rectangleF.Y > boundingRect.Y)
					{
						rectangleF.Y = boundingRect.Y;
					}
					if (rectangleF.X + rectangleF.Width < boundingRect.X + boundingRect.Width)
					{
						rectangleF.Width += boundingRect.X + boundingRect.Width - (rectangleF.X + rectangleF.Width);
					}
					if (rectangleF.Y + rectangleF.Height < boundingRect.Y + boundingRect.Height)
					{
						rectangleF.Height += boundingRect.Y + boundingRect.Height - (rectangleF.Y + rectangleF.Height);
					}
				}
			}
			RectangleF rectangleF2 = ConvertCanvas.ConvertToUnitNormalized(this, base.ClientRectangle);
			float num = rectangleF.Height / rectangleF.Width;
			float num2 = rectangleF2.Height / rectangleF2.Width;
			float num3;
			if (num <= num2)
			{
				num3 = rectangleF.Width / rectangleF2.Width;
			}
			else
			{
				num3 = rectangleF.Height / rectangleF2.Height;
			}
			if (num3 != 0f)
			{
				base.Zoom /= num3;
			}
			if (base.Zoom == 0f)
			{
				base.Zoom = 0.0001f;
			}
			PointF pointF_ = new PointF(rectangleF.X + rectangleF.Width / 2f, rectangleF.Y + rectangleF.Height / 2f);
			base.SetCenter(new UnitPoint(pointF_));
		}
	}

	public void method_103(Point point_2)
	{
		if (this.method_95() != null)
		{
			if (this.Cursor == Cursors.SizeNWSE)
			{
				base.Location = point_2;
				base.Width = this.method_95().Width - base.Location.X;
				base.Height = this.method_95().Height - base.Location.Y;
			}
			this.float_3 = (float)base.Width / (float)this.method_95().Width;
			this.float_4 = (float)base.Height / (float)this.method_95().Height;
		}
		base.DoInvalidate(false);
	}

	private CanvasControl canvasControl_1;

	private BackgroundLayer backgroundLayer_1;

	private RectangleF rectangleF_2 = RectangleF.Empty;

	private float float_3 = 0.2f;

	private float float_4 = 0.2f;
}
