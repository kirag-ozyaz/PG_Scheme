using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Layers;

internal class Control0 : CanvasControl
{
	public CanvasControl method_103()
	{
		return this.canvasControl_1;
	}

	public void method_104(CanvasControl canvasControl_2)
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

	public RectangleF method_105()
	{
		return this.rectangleF_2;
	}

	public void method_106(RectangleF rectangleF_3)
	{
		this.rectangleF_2 = rectangleF_3;
		base.DoInvalidate(false);
	}

	public float method_107()
	{
		return this.float_1;
	}

	public void method_108(float float_3)
	{
		this.float_1 = float_3;
	}

	public float method_109()
	{
		return this.float_2;
	}

	public void method_110(float float_3)
	{
		this.float_2 = float_3;
	}

	public Control0()
	{
		
		this.rectangleF_2 = RectangleF.Empty;
		this.float_1 = 0.2f;
		this.float_2 = 0.2f;
		
		base.Zoom = 1f;
		base.StatusStripVisible = false;
		this.backgroundLayer_1 = new BackgroundLayer(this);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		Rectangle clipRectangle = e.ClipRectangle;
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
			if (base.Enabled && this.method_103() != null)
			{
				foreach (ICanvasLayer canvasLayer in this.method_103().Layers)
				{
					DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
					if (drawingLayer.Visible)
					{
						drawingLayer.Draw(this, unitrect);
					}
				}
			}
		}
		e.Graphics.DrawImage(this.staticImage, clipRectangle, clipRectangle, GraphicsUnit.Pixel);
		if (this.method_105() != RectangleF.Empty)
		{
			RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(this, this.method_105());
			e.Graphics.DrawRectangle(new Pen(Color.White, 5f), rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
		}
		base.Graphics = e.Graphics;
		this.staticRepaint = false;
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		PointF screenpoint = new PointF((float)e.X, (float)e.Y);
		UnitPoint center = ConvertCanvas.ConvertToUnit(this, screenpoint);
		if (e.Button == MouseButtons.Left && this.method_103() != null)
		{
			this.method_103().SetCenter(center);
			this.method_103().DoInvalidate(true);
		}
	}

	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		if (this.method_103() != null)
		{
			base.Graphics = Graphics.FromHwnd(base.Handle);
			RectangleF rectangleF = new RectangleF(new PointF(0f, 0f), new SizeF(0f, 0f));
			new List<DrawObjectBase>();
			foreach (ICanvasLayer canvasLayer in this.method_103().Layers)
			{
				foreach (DrawObjectBase drawObjectBase in ((DrawingLayer)canvasLayer).Objects)
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
			PointF p = new PointF(rectangleF.X + rectangleF.Width / 2f, rectangleF.Y + rectangleF.Height / 2f);
			base.SetCenter(new UnitPoint(p));
		}
	}

	public void method_111(Point point_1)
	{
		if (this.method_103() != null)
		{
			if (this.Cursor == Cursors.SizeNWSE)
			{
				base.Location = point_1;
				base.Width = this.method_103().Width - base.Location.X;
				base.Height = this.method_103().Height - base.Location.Y;
			}
			this.float_1 = (float)base.Width / (float)this.method_103().Width;
			this.float_2 = (float)base.Height / (float)this.method_103().Height;
		}
		base.DoInvalidate(false);
	}

	private CanvasControl canvasControl_1;

	private BackgroundLayer backgroundLayer_1;

	private RectangleF rectangleF_2;

	private float float_1;

	private float float_2;
}
