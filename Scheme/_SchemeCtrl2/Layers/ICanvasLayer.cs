using System;
using System.Collections.Generic;
using System.Drawing;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.SnapPoint;

namespace SchemeCtrl2.Layers
{
	public interface ICanvasLayer
	{
		string Id { get; }

		void Draw(CanvasControl canvas, RectangleF unitrect);

		ISnapPoint SnapPoint(CanvasControl canvas, UnitPoint point, List<DrawObjectBase> otherobj);

		IEnumerable<DrawObjectBase> Objects { get; }

		int ObjectsCount { get; }

		bool Enabled { get; set; }

		bool Visible { get; set; }

		CanvasControl Parent { get; set; }
	}
}
