using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.Layers;
using SchemeCtrl2.SnapPoint;

namespace SchemeCtrl2.DrawTool
{
	public class ImageTool : DrawObjectBase
	{
		public ImageTool()
		{
			
			
		}

		public ImageTool(Bitmap image)
		{
			
			this..ctor();
			this.image = image;
		}

		public ImageTool(DataRow r, DrawingLayer layer)
		{
			
			
		}

		public ImageTool(DataRow r, DrawingLayer layer, Bitmap image)
		{
			
			this..ctor(r, layer);
			this.image = image;
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if (!this.Visible)
			{
				return;
			}
			RectangleF rect = ConvertCanvas.ConvertToScreen(canvas, this.envelope);
			if (this.image != null)
			{
				canvas.Graphics.DrawImage(this.image, rect);
				return;
			}
			canvas.Graphics.FillRectangle(new SolidBrush(Color.White), rect);
		}

		public override void Move(UnitPoint offset, bool selectedMove)
		{
			if (!selectedMove && this.Selected)
			{
				return;
			}
			this.envelope.X = this.envelope.X + (float)offset.X;
			this.envelope.Y = this.envelope.Y + (float)offset.Y;
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				drawObjectBase.Move(offset, false);
			}
		}

		public override bool ObjectInRectangle(CanvasControl canvas, RectangleF rect, bool anyPoint)
		{
			RectangleF boundingRect = this.GetBoundingRect(canvas, true);
			if (anyPoint)
			{
				UnitPoint unitPoint_ = new UnitPoint(boundingRect.Location);
				UnitPoint unitPoint_2 = new UnitPoint((double)(boundingRect.X + boundingRect.Width), (double)(boundingRect.Y + boundingRect.Height));
				return Class79.smethod_0(unitPoint_, unitPoint_2, rect);
			}
			return rect.Contains(boundingRect);
		}

		public override RectangleF GetBoundingRect(CanvasControl canvas, bool inflate)
		{
			float num = base.ThresholdWidth(canvas, base.Width);
			double num2 = (double)Math.Min(this.envelope.Left, this.envelope.Right);
			double num3 = (double)Math.Min(this.envelope.Top, this.envelope.Bottom);
			double num4 = (double)Math.Abs(this.envelope.Left - this.envelope.Right);
			double num5 = (double)Math.Abs(this.envelope.Top - this.envelope.Bottom);
			RectangleF result = new RectangleF((float)num2, (float)num3, (float)num4, (float)num5);
			RectangleF rectangleText = this.GetRectangleText(canvas);
			if (!rectangleText.IsEmpty)
			{
				num2 = (double)Math.Min(rectangleText.X, result.X);
				num3 = (double)Math.Min(rectangleText.Y, result.Y);
				num4 = (double)Math.Max(rectangleText.Right, result.Right) - num2;
				num5 = (double)Math.Max(rectangleText.Bottom, result.Bottom) - num3;
				result = new RectangleF((float)num2, (float)num3, (float)num4, (float)num5);
			}
			if (inflate)
			{
				result.Inflate(num, num);
			}
			return result;
		}

		public override ISnapPoint SnapPoint(CanvasControl canvas, UnitPoint point, List<DrawObjectBase> otherobjs, Type[] runningsnaptypes, Type usersnaptype)
		{
			if (!this.Visible)
			{
				return null;
			}
			float float_ = base.ThresholdWidth(canvas, base.Width);
			for (int i = 0; i < this.NodeCount; i++)
			{
				UnitPoint node = this.GetNode(i);
				if (Class79.XrgxasnnaZ(node, float_, point))
				{
					return new Class8(canvas, this, node);
				}
			}
			return null;
		}

		protected override UnitPoint GetNode(int nodeNumber)
		{
			float num = this.envelope.X + this.envelope.Width / 2f;
			float num2 = this.envelope.Y + this.envelope.Height / 2f;
			float num3 = this.envelope.X;
			float num4 = this.envelope.Y;
			switch (nodeNumber)
			{
			case 1:
				num3 = this.envelope.X;
				num4 = this.envelope.Y;
				break;
			case 2:
				num3 = num;
				num4 = this.envelope.Y;
				break;
			case 3:
				num3 = this.envelope.Right;
				num4 = this.envelope.Y;
				break;
			case 4:
				num3 = this.envelope.Right;
				num4 = num2;
				break;
			case 5:
				num3 = this.envelope.Right;
				num4 = this.envelope.Bottom;
				break;
			case 6:
				num3 = num;
				num4 = this.envelope.Bottom;
				break;
			case 7:
				num3 = this.envelope.X;
				num4 = this.envelope.Bottom;
				break;
			case 8:
				num3 = this.envelope.X;
				num4 = num2;
				break;
			}
			return new UnitPoint((double)num3, (double)num4);
		}

		public override int HitTest(CanvasControl canvas, PointF point)
		{
			if (this.Selected)
			{
				for (int i = 1; i <= this.NodeCount; i++)
				{
					if (base.GetNodeRectangle(canvas, i).Contains(point))
					{
						return i;
					}
				}
			}
			return -1;
		}

		public override Cursor GetHandleCursor(int handleNumber)
		{
			if (this.Layer != null && this.Layer.Parent != null && this.Layer.Parent.Mode != eCanvasEditingMode.Edit)
			{
				return Cursors.Default;
			}
			switch (handleNumber)
			{
			case 1:
				return Cursors.SizeNESW;
			case 2:
				return Cursors.SizeNS;
			case 3:
				return Cursors.SizeNWSE;
			case 4:
				return Cursors.SizeWE;
			case 5:
				return Cursors.SizeNESW;
			case 6:
				return Cursors.SizeNS;
			case 7:
				return Cursors.SizeNWSE;
			case 8:
				return Cursors.SizeWE;
			default:
				return Cursors.Default;
			}
		}

		public override void Normalize()
		{
			float num = (this.envelope.Left < this.envelope.Right) ? this.envelope.Left : this.envelope.Right;
			float num2 = (this.envelope.Left > this.envelope.Right) ? this.envelope.Left : this.envelope.Right;
			float num3 = (this.envelope.Top < this.envelope.Bottom) ? this.envelope.Top : this.envelope.Bottom;
			float num4 = (this.envelope.Top > this.envelope.Bottom) ? this.envelope.Top : this.envelope.Bottom;
			this.envelope = new RectangleF(num, num3, num2 - num, num4 - num3);
		}

		public override void EndDraw()
		{
		}

		protected RectangleF envelope;

		protected Bitmap image;
	}
}
