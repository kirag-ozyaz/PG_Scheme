using System;
using System.Drawing;
using System.Windows.Forms;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Layers;
using SchemeCtrl2.SnapPoint;

namespace SchemeCtrl2.Canvas
{
	public class CanvasFrame
	{
		public CanvasFrame(UnitPoint point)
		{
			this.rectangleF_0 = new RectangleF(point.Point, new SizeF(0f, 0f));
		}

		public CanvasFrame(RectangleF rect)
		{
			this.rectangleF_0 = rect;
		}

		public int NodeCount
		{
			get
			{
				return 8;
			}
		}

		public virtual RectangleF Rectangle
		{
			get
			{
				return this.rectangleF_0;
			}
			set
			{
				this.rectangleF_0 = value;
			}
		}

		public void Normalize()
		{
			float num = (this.rectangleF_0.Left < this.rectangleF_0.Right) ? this.rectangleF_0.Left : this.rectangleF_0.Right;
			float num2 = (this.rectangleF_0.Left > this.rectangleF_0.Right) ? this.rectangleF_0.Left : this.rectangleF_0.Right;
			float num3 = (this.rectangleF_0.Top < this.rectangleF_0.Bottom) ? this.rectangleF_0.Top : this.rectangleF_0.Bottom;
			float num4 = (this.rectangleF_0.Top > this.rectangleF_0.Bottom) ? this.rectangleF_0.Top : this.rectangleF_0.Bottom;
			this.rectangleF_0 = new RectangleF(num, num3, num2 - num, num4 - num3);
		}

		public void InitializeFromModel(UnitPoint point, DrawingLayer layer, ISnapPoint snap)
		{
			this.rectangleF_0 = new RectangleF(point.Point, new SizeF(0f, 0f));
		}

		protected UnitPoint GetNode(int nodeNumber)
		{
			float num = this.Rectangle.X + this.Rectangle.Width / 2f;
			float num2 = this.Rectangle.Y + this.Rectangle.Height / 2f;
			float num3 = this.Rectangle.X;
			float num4 = this.Rectangle.Y;
			switch (nodeNumber)
			{
			case 1:
				num3 = this.Rectangle.X;
				num4 = this.Rectangle.Y;
				break;
			case 2:
				num3 = num;
				num4 = this.Rectangle.Y;
				break;
			case 3:
				num3 = this.Rectangle.Right;
				num4 = this.Rectangle.Y;
				break;
			case 4:
				num3 = this.Rectangle.Right;
				num4 = num2;
				break;
			case 5:
				num3 = this.Rectangle.Right;
				num4 = this.Rectangle.Bottom;
				break;
			case 6:
				num3 = num;
				num4 = this.Rectangle.Bottom;
				break;
			case 7:
				num3 = this.Rectangle.X;
				num4 = this.Rectangle.Bottom;
				break;
			case 8:
				num3 = this.Rectangle.X;
				num4 = num2;
				break;
			}
			return new UnitPoint((double)num3, (double)num4);
		}

		public RectangleF GetNodeRectangle(CanvasControl canvas, int nodeNumber)
		{
			PointF pointF = ConvertCanvas.ConvertToScreen(canvas, this.GetNode(nodeNumber));
			return new RectangleF(pointF.X - 3f, pointF.Y - 3f, 7f, 7f);
		}

		public int HitTest(CanvasControl canvas, UnitPoint point)
		{
			for (int i = 1; i <= this.NodeCount; i++)
			{
				if (ConvertCanvas.ConvertToUnitNormalized(canvas, this.GetNodeRectangle(canvas, i)).Contains(point.Point))
				{
					return i;
				}
			}
			UnitPoint unitPoint = new UnitPoint((double)this.rectangleF_0.X, (double)this.rectangleF_0.Y);
			UnitPoint unitPoint2 = new UnitPoint((double)(this.rectangleF_0.X + this.rectangleF_0.Width), (double)(this.rectangleF_0.Y + this.rectangleF_0.Height));
			double num = Math.Min(unitPoint.X, unitPoint2.X);
			double num2 = Math.Max(unitPoint.X, unitPoint2.X);
			double num3 = Math.Min(unitPoint.Y, unitPoint2.Y);
			double num4 = Math.Max(unitPoint.Y, unitPoint2.Y);
			if (point.X >= num && point.X <= num2 && point.Y >= num3 && point.Y <= num4)
			{
				return 0;
			}
			return -1;
		}

		public Cursor GetHandleCursor(int handleNumber)
		{
			switch (handleNumber)
			{
			case 1:
			case 5:
				return Cursors.SizeNWSE;
			case 2:
			case 6:
				return Cursors.SizeNS;
			case 3:
			case 7:
				return Cursors.SizeNESW;
			case 4:
			case 8:
				return Cursors.SizeWE;
			default:
				return Cursors.Default;
			}
		}

		public void Move(UnitPoint offset)
		{
			this.rectangleF_0.X = this.rectangleF_0.X + (float)offset.X;
			this.rectangleF_0.Y = this.rectangleF_0.Y + (float)offset.Y;
		}

		public void MoveHandleTo(UnitPoint pointU, int handleNumber)
		{
			PointF point = pointU.Point;
			float num = this.rectangleF_0.Left;
			float num2 = this.rectangleF_0.Top;
			float num3 = this.rectangleF_0.Right;
			float num4 = this.rectangleF_0.Bottom;
			switch (handleNumber)
			{
			case 1:
				num = point.X;
				num2 = point.Y;
				break;
			case 2:
				num2 = point.Y;
				break;
			case 3:
				num3 = point.X;
				num2 = point.Y;
				break;
			case 4:
				num3 = point.X;
				break;
			case 5:
				num3 = point.X;
				num4 = point.Y;
				break;
			case 6:
				num4 = point.Y;
				break;
			case 7:
				num = point.X;
				num4 = point.Y;
				break;
			case 8:
				num = point.X;
				break;
			}
			this.rectangleF_0 = new RectangleF(num, num2, num3 - num, num4 - num2);
			UnitPoint unitPoint = new UnitPoint((double)num, (double)num2);
			UnitPoint unitPoint2 = new UnitPoint((double)this.rectangleF_0.Right, (double)this.rectangleF_0.Bottom);
			if (unitPoint.X < (double)this.rectangleF_0.Left)
			{
				this.rectangleF_0.X = (float)unitPoint.X;
			}
			if (unitPoint.Y < (double)this.rectangleF_0.Top)
			{
				this.rectangleF_0.Y = (float)unitPoint.Y;
			}
			if (unitPoint2.X > (double)this.rectangleF_0.Right)
			{
				this.rectangleF_0.Width = (float)unitPoint2.X - this.rectangleF_0.Left;
			}
			if (unitPoint2.Y > (double)this.rectangleF_0.Bottom)
			{
				this.rectangleF_0.Height = (float)unitPoint2.Y - this.rectangleF_0.Top;
			}
			new ResizeRectangleEventsArgs(new RectangleF(num, num2, num3 - num, num4 - num2), handleNumber);
		}

		private RectangleF rectangleF_0;
	}
}
