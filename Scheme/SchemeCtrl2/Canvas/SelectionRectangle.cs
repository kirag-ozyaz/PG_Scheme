using System;
using System.Drawing;

namespace SchemeCtrl2.Canvas
{
	public class SelectionRectangle
	{
		public SelectionRectangle(PointF mousedownpoint)
		{
			
			
			this.pointF_0 = mousedownpoint;
			this.pointF_1 = PointF.Empty;
		}

		public void Reset()
		{
			this.pointF_1 = PointF.Empty;
		}

		public void SetMousePoint(Graphics dc, PointF mousepoint)
		{
			this.pointF_1 = mousepoint;
		}

		public Rectangle ScreenRect()
		{
			float num = Math.Min(this.pointF_0.X, this.pointF_1.X);
			float num2 = Math.Min(this.pointF_0.Y, this.pointF_1.Y);
			float num3 = Math.Abs(this.pointF_0.X - this.pointF_1.X);
			float num4 = Math.Abs(this.pointF_0.Y - this.pointF_1.Y);
			if (this.pointF_1 == PointF.Empty)
			{
				return Rectangle.Empty;
			}
			if (num3 >= 4f && num4 >= 4f)
			{
				return new Rectangle((int)num, (int)num2, (int)num3, (int)num4);
			}
			return Rectangle.Empty;
		}

		public RectangleF Selection(CanvasControl canvas)
		{
			Rectangle screenrect = this.ScreenRect();
			if (screenrect.IsEmpty)
			{
				return RectangleF.Empty;
			}
			return ConvertCanvas.ConvertToUnitNormalized(canvas, screenrect);
		}

		public bool AnyPoint()
		{
			return this.pointF_0.X > this.pointF_1.X;
		}

		private Color method_0()
		{
			if (this.AnyPoint())
			{
				return Color.Blue;
			}
			return Color.Green;
		}

		private PointF pointF_0;

		private PointF pointF_1;
	}
}
