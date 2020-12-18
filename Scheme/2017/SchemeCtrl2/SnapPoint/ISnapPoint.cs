using System;
using System.Drawing;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.SnapPoint
{
	public interface ISnapPoint
	{
		DrawObjectBase Owner { get; }

		UnitPoint SnapPoint { get; }

		RectangleF BoundingRect { get; }

		void Draw(CanvasControl canvas);
	}
}
