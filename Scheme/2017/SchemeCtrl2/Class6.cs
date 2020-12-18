using System;
using System.Drawing;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.SnapPoint;

internal class Class6 : ISnapPoint
{
	public DrawObjectBase Owner
	{
		get
		{
			return this.drawObjectBase_0;
		}
	}

	public virtual UnitPoint SnapPoint
	{
		get
		{
			return this.unitPoint_0;
		}
	}

	public virtual RectangleF BoundingRect
	{
		get
		{
			return this.rectangleF_0;
		}
	}

	public Class6(CanvasControl canvasControl_0, DrawObjectBase drawObjectBase_1, UnitPoint unitPoint_1)
	{
		Class90.TDroV38zslI2T();
		base..ctor();
		this.drawObjectBase_0 = drawObjectBase_1;
		this.unitPoint_0 = unitPoint_1;
		float num = (float)ConvertCanvas.ConvertToUnit(canvasControl_0, 14f);
		this.rectangleF_0.X = (float)(unitPoint_1.X - (double)(num / 2f));
		this.rectangleF_0.Y = (float)(unitPoint_1.Y - (double)(num / 2f));
		this.rectangleF_0.Width = num;
		this.rectangleF_0.Height = num;
	}

	public virtual void Draw(CanvasControl canvas)
	{
	}

	protected void method_0(CanvasControl canvasControl_0, Pen pen_0, Brush brush_0)
	{
		try
		{
			RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(canvasControl_0, this.rectangleF_0);
			Rectangle rect = new Rectangle((int)rectangleF.Left, (int)rectangleF.Top, (int)rectangleF.Width, (int)rectangleF.Height);
			canvasControl_0.Graphics.DrawRectangle(pen_0, rect);
			int num = rect.X;
			rect.X = num + 1;
			num = rect.Y;
			rect.Y = num + 1;
			num = rect.Width;
			rect.Width = num - 1;
			num = rect.Height;
			rect.Height = num - 1;
			if (brush_0 != null)
			{
				canvasControl_0.Graphics.FillRectangle(brush_0, rect);
			}
		}
		catch
		{
		}
	}

	protected UnitPoint unitPoint_0;

	protected RectangleF rectangleF_0;

	protected DrawObjectBase drawObjectBase_0;
}
