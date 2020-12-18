using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.SnapPoint;

namespace SchemeCtrl2.Layers
{
	public class GridLayer : ICanvasLayer
	{
		public string Id
		{
			get
			{
				return "grid";
			}
		}

		public SizeF Spacing
		{
			get
			{
				return this.sizeF_0;
			}
			set
			{
				this.sizeF_0 = value;
			}
		}

		public int MinSize
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public GridLayer.eGridStyle GridStyle
		{
			get
			{
				if (this.Parent != null)
				{
					return this.Parent.Settings.GridStyle;
				}
				return this.eGridStyle_0;
			}
			set
			{
				this.eGridStyle_0 = value;
			}
		}

		public Color Color
		{
			get
			{
				if (this.Parent != null)
				{
					return this.Parent.Settings.GridColor;
				}
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
			}
		}

		public IEnumerable<DrawObjectBase> Objects
		{
			get
			{
				return null;
			}
		}

		public int ObjectsCount
		{
			get
			{
				return 0;
			}
		}

		public bool Enabled
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		public bool Visible
		{
			get
			{
				return this.Parent == null || this.Parent.Settings.GridVisible;
			}
			set
			{
				this.Visible = value;
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

		public GridLayer(CanvasControl parent)
		{
			this.canvasControl_0 = parent;
		}

		public void Copy(GridLayer acopy)
		{
			this.bool_0 = acopy.bool_0;
			this.sizeF_0 = acopy.sizeF_0;
			this.int_0 = acopy.int_0;
			this.eGridStyle_0 = acopy.eGridStyle_0;
			this.color_0 = acopy.color_0;
		}

		public void Draw(CanvasControl canvas, RectangleF unitrect)
		{
			if (!this.Enabled)
			{
				return;
			}
			if (!this.Visible)
			{
				return;
			}
			float width = this.Spacing.Width;
			float height = this.Spacing.Height;
			float num = ConvertCanvas.ConvertToScreen(canvas, (double)width);
			float num2 = ConvertCanvas.ConvertToScreen(canvas, (double)height);
			if (num >= (float)this.MinSize && num2 >= (float)this.MinSize)
			{
				PointF location = unitrect.Location;
				PointF pointF = new PointF(unitrect.Location.X + unitrect.Width, unitrect.Location.Y + unitrect.Height);
				float num3 = (float)Math.Round((double)(location.X / width)) * width;
				float num4 = unitrect.Height + unitrect.Y;
				float x = pointF.X;
				float num5 = (float)Math.Round((double)(location.Y / height)) * height;
				if (this.GridStyle == GridLayer.eGridStyle.Dots)
				{
					SolidBrush brush = new SolidBrush(this.Color);
					PointF pointF2 = ConvertCanvas.ConvertToScreen(canvas, new UnitPoint((double)num3, (double)num4));
					pointF2.Y -= unitrect.Height;
					ConvertCanvas.ConvertToScreen(canvas, new UnitPoint((double)x, (double)num5));
					ConvertCanvas.ConvertToScreen(canvas, (double)width);
					ConvertCanvas.ConvertToScreen(canvas, (double)height);
					for (float num6 = num3; num6 <= x; num6 += width)
					{
						for (float num7 = num5; num7 <= num4; num7 += height)
						{
							PointF pointF3 = ConvertCanvas.ConvertToScreen(canvas, new UnitPoint((double)num6, (double)num7));
							canvas.Graphics.FillEllipse(brush, pointF3.X, pointF3.Y, 2f, 2f);
						}
					}
				}
				if (this.GridStyle == GridLayer.eGridStyle.Lines)
				{
					Pen pen = new Pen(this.Color);
					GraphicsPath graphicsPath = new GraphicsPath();
					while (num3 < x)
					{
						PointF pt = ConvertCanvas.ConvertToScreen(canvas, new UnitPoint((double)num3, (double)location.Y));
						PointF pt2 = ConvertCanvas.ConvertToScreen(canvas, new UnitPoint((double)num3, (double)pointF.Y));
						graphicsPath.AddLine(pt, pt2);
						graphicsPath.CloseFigure();
						num3 += width;
					}
					while (num5 < num4)
					{
						PointF pt3 = ConvertCanvas.ConvertToScreen(canvas, new UnitPoint((double)location.X, (double)num5));
						PointF pt4 = ConvertCanvas.ConvertToScreen(canvas, new UnitPoint((double)pointF.X, (double)num5));
						graphicsPath.AddLine(pt3, pt4);
						graphicsPath.CloseFigure();
						num5 += height;
					}
					canvas.Graphics.DrawPath(pen, graphicsPath);
				}
				return;
			}
		}

		public ISnapPoint SnapPoint(CanvasControl canvas, UnitPoint point, List<DrawObjectBase> otherobj)
		{
			if (!this.Enabled || !this.Visible)
			{
				return null;
			}
			UnitPoint unitPoint_ = default(UnitPoint);
			UnitPoint unitPoint = point;
			float width = this.Spacing.Width;
			float height = this.Spacing.Height;
			unitPoint_.X = (double)((float)Math.Round(unitPoint.X / (double)width) * width);
			unitPoint_.Y = (double)((float)Math.Round(unitPoint.Y / (double)height) * height);
			double num = ConvertCanvas.ConvertToUnit(canvas, 6f);
			if (unitPoint_.X < point.X - num || unitPoint_.X > point.X + num)
			{
				return null;
			}
			if (unitPoint_.Y >= point.Y - num && unitPoint_.Y <= point.Y + num)
			{
				return new Class103(canvas, unitPoint_);
			}
			return null;
		}

		private SizeF sizeF_0 = new SizeF(1f, 1f);

		private bool bool_0 = true;

		private int int_0 = 15;

		private GridLayer.eGridStyle eGridStyle_0 = GridLayer.eGridStyle.Lines;

		private Color color_0 = Color.FromArgb(50, Color.Gray);

		private CanvasControl canvasControl_0;

		public enum eGridStyle
		{
			Dots,
			Lines
		}
	}
}
