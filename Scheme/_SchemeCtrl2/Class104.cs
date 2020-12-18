using System;
using System.Drawing;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;

internal class Class104 : Class102
{
	public Class104(CanvasControl canvasControl_0, DrawObjectBase drawObjectBase_1, UnitPoint unitPoint_1) : base(canvasControl_0, drawObjectBase_1, unitPoint_1)
	{
	}

	public override void Draw(CanvasControl canvas)
	{
		base.method_0(canvas, Pens.Blue, Brushes.YellowGreen);
	}
}
