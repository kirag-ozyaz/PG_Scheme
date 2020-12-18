using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class VoltageTransformerTool : ObjectOnLine
	{
		public VoltageTransformerTool()
		{
		}

		public VoltageTransformerTool(Branch branch) : base(branch)
		{
		}

		public VoltageTransformerTool(DataRow dataRow_0, Branch branch) : base(dataRow_0, branch)
		{
		}

		public override bool On
		{
			get
			{
				return true;
			}
		}

		protected override void CreateImagePoints()
		{
			base.Points.Add(new UnitPoint(0.0, 0.15));
			base.Points.Add(new UnitPoint(-0.1, -0.15));
			base.Points.Add(new UnitPoint(0.1, -0.15));
			this.systemChanging = true;
			this.CenterPoint = new UnitPoint(0.0, 0.0);
			this.systemChanging = false;
		}

		protected override RectangleF GetRectangleText(CanvasControl canvas)
		{
			RectangleF empty = RectangleF.Empty;
			if (!this.TextProperty.Visible)
			{
				return empty;
			}
			if (base.Points.Count > 0)
			{
				empty.Location = base.Points[0].Point;
				empty.Size = new SizeF(0f, 0f);
				float num = empty.Left;
				float num2 = empty.Right;
				float num3 = empty.Top;
				float num4 = empty.Bottom;
				foreach (UnitPoint unitPoint in base.Points)
				{
					if (unitPoint.X < (double)num)
					{
						num = (float)unitPoint.X;
					}
					if (unitPoint.X > (double)num2)
					{
						num2 = (float)unitPoint.X;
					}
					if (unitPoint.Y < (double)num3)
					{
						num3 = (float)unitPoint.Y;
					}
					if (unitPoint.Y > (double)num4)
					{
						num4 = (float)unitPoint.Y;
					}
				}
				RectangleF rectangleF = new RectangleF(num - 0.2f, num3 - 0.2f, num2 - num + 0.4f, num4 - num3 + 0.4f);
				Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style);
				SizeF sizeF = canvas.Graphics.MeasureString(this.Text, font);
				font.Dispose();
				SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
				empty = new RectangleF(rectangleF.Location, size);
				switch (this.TextProperty.Position)
				{
				case ePositionText.LT:
					empty.X = rectangleF.Location.X - empty.Width;
					empty.Y = rectangleF.Location.Y + rectangleF.Height;
					break;
				case ePositionText.T:
					empty.X = rectangleF.Location.X + rectangleF.Width / 2f - empty.Width / 2f;
					empty.Y = rectangleF.Location.Y + rectangleF.Height;
					break;
				case ePositionText.RT:
					empty.X = rectangleF.Location.X + rectangleF.Width;
					empty.Y = rectangleF.Location.Y + rectangleF.Height;
					break;
				case ePositionText.R:
					empty.X = rectangleF.Location.X + rectangleF.Width;
					empty.Y = rectangleF.Location.Y + rectangleF.Height / 2f - empty.Height / 2f;
					break;
				case ePositionText.RB:
					empty.X = rectangleF.Location.X + rectangleF.Width;
					empty.Y = rectangleF.Location.Y - empty.Height;
					break;
				case ePositionText.B:
					empty.X = rectangleF.Location.X + rectangleF.Width / 2f - empty.Width / 2f;
					empty.Y = rectangleF.Location.Y - empty.Height;
					break;
				case ePositionText.LB:
					empty.X = rectangleF.Location.X - empty.Width;
					empty.Y = rectangleF.Location.Y - empty.Height;
					break;
				case ePositionText.L:
					empty.X = rectangleF.Location.X - empty.Width;
					empty.Y = rectangleF.Location.Y + rectangleF.Height / 2f - empty.Height / 2f;
					break;
				}
				return empty;
			}
			return empty;
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if (!this.Visible)
			{
				return;
			}
			using (Pen pen = new Pen(this.Color, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width)))
			{
				if (canvas.KoefResolution > 1)
				{
					if (pen.Width == 0f)
					{
						pen.Width = (float)canvas.KoefResolution;
					}
					else
					{
						pen.Width *= (float)canvas.KoefResolution;
					}
				}
				using (SolidBrush solidBrush = new SolidBrush(canvas.Settings.BackgroundColor))
				{
					if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
					{
						if ((drawMode & eDrawMode.Color) != eDrawMode.Color)
						{
							pen.Color = Color.Black;
							solidBrush.Color = Color.White;
						}
					}
					else if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
					{
						if (this.Selected)
						{
							pen.Color = this.SelectedColor;
						}
						else if (base.Bookmark != null)
						{
							pen.Color = canvas.Settings.MarkedObjColor;
						}
						if (this.Flashing && canvas.ConvertColorFlash)
						{
							pen.Color = canvas.Settings.BackFlashingColor;
						}
						if (!this.On)
						{
							if (base.IsNormalSection)
							{
								solidBrush.Color = base.ColorOffN;
							}
							else
							{
								solidBrush.Color = base.ColorOff;
							}
						}
					}
					else
					{
						if (this.Selected)
						{
							pen.Color = Color.Gray;
						}
						else if (base.Bookmark != null)
						{
							pen.Color = Color.LightGray;
						}
						if (this.Flashing && canvas.ConvertColorFlash)
						{
							pen.Color = Color.White;
						}
					}
					RectangleF rectangleF = new RectangleF(new PointF(base.Points[0].Point.X - 0.2f, base.Points[0].Point.Y - 0.2f), new SizeF(0.4f, -0.4f));
					RectangleF rectangleF2 = new RectangleF(new PointF(base.Points[1].Point.X - 0.2f, base.Points[1].Point.Y - 0.2f), new SizeF(0.4f, -0.4f));
					RectangleF rectangleF3 = new RectangleF(new PointF(base.Points[2].Point.X - 0.2f, base.Points[2].Point.Y - 0.2f), new SizeF(0.4f, -0.4f));
					rectangleF = ConvertCanvas.ConvertToScreen(canvas, rectangleF);
					rectangleF2 = ConvertCanvas.ConvertToScreen(canvas, rectangleF2);
					rectangleF3 = ConvertCanvas.ConvertToScreen(canvas, rectangleF3);
					if (this.ComplexSwitchgear != null)
					{
						this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
					}
					canvas.Graphics.FillEllipse(solidBrush, rectangleF);
					canvas.Graphics.FillEllipse(solidBrush, rectangleF2);
					canvas.Graphics.FillEllipse(solidBrush, rectangleF3);
					canvas.Graphics.DrawEllipse(pen, rectangleF);
					canvas.Graphics.DrawEllipse(pen, rectangleF2);
					canvas.Graphics.DrawEllipse(pen, rectangleF3);
					this.DrawText(canvas, drawMode);
					base.DrawDamage(canvas);
					base.DrawKey(canvas);
				}
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics graphics_0, bool isColor = false)
		{
			if (this.ComplexSwitchgear != null)
			{
				this.ComplexSwitchgear.DrawPrint(canvas, graphics_0, false);
			}
			Pen pen = new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			SolidBrush brush = new SolidBrush(Color.White);
			ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			RectangleF rectangleF = new RectangleF(new PointF(base.Points[0].Point.X - 0.2f, base.Points[0].Point.Y - 0.2f), new SizeF(0.4f, -0.4f));
			RectangleF rectangleF2 = new RectangleF(new PointF(base.Points[1].Point.X - 0.2f, base.Points[1].Point.Y - 0.2f), new SizeF(0.4f, -0.4f));
			RectangleF rectangleF3 = new RectangleF(new PointF(base.Points[2].Point.X - 0.2f, base.Points[2].Point.Y - 0.2f), new SizeF(0.4f, -0.4f));
			rectangleF = ConvertCanvas.ConvertToScreen(canvas, rectangleF);
			rectangleF2 = ConvertCanvas.ConvertToScreen(canvas, rectangleF2);
			rectangleF3 = ConvertCanvas.ConvertToScreen(canvas, rectangleF3);
			graphics_0.FillEllipse(brush, rectangleF);
			graphics_0.FillEllipse(brush, rectangleF2);
			graphics_0.FillEllipse(brush, rectangleF3);
			graphics_0.DrawEllipse(pen, rectangleF);
			graphics_0.DrawEllipse(pen, rectangleF2);
			graphics_0.DrawEllipse(pen, rectangleF3);
			this.DrawText(canvas, eDrawMode.Print);
		}

		public override void ExportDXF(CanvasControl canvas, DxfDocument document)
		{
			Circle circle = new Circle(new Vector3(base.Points[0].X, base.Points[0].Y, 2.0), 0.20000000298023224);
			List<HatchBoundaryPath> list = new List<HatchBoundaryPath>
			{
				new HatchBoundaryPath(new List<IEntityObject>
				{
					circle
				})
			};
			Hatch hatch = new Hatch(HatchPattern.Solid, list);
			hatch.Color.Index = 256;
			hatch.Layer = new Layer("Switches");
			circle.Layer = new Layer("Switches");
			circle.Color = new AciColor(this.Color);
			document.AddEntity(circle);
			document.AddEntity(hatch);
			circle = new Circle(new Vector3(base.Points[1].X, base.Points[1].Y, 2.0), 0.20000000298023224);
			list = new List<HatchBoundaryPath>
			{
				new HatchBoundaryPath(new List<IEntityObject>
				{
					circle
				})
			};
			hatch = new Hatch(HatchPattern.Solid, list);
			hatch.Color.Index = 256;
			circle.Color = new AciColor(this.Color);
			hatch.Layer = new Layer("Switches");
			circle.Layer = new Layer("Switches");
			document.AddEntity(circle);
			document.AddEntity(hatch);
			circle = new Circle(new Vector3(base.Points[2].X, base.Points[2].Y, 2.0), 0.20000000298023224);
			list = new List<HatchBoundaryPath>
			{
				new HatchBoundaryPath(new List<IEntityObject>
				{
					circle
				})
			};
			hatch = new Hatch(HatchPattern.Solid, list);
			hatch.Color.Index = 256;
			circle.Color = new AciColor(this.Color);
			hatch.Layer = new Layer("Switches");
			circle.Layer = new Layer("Switches");
			document.AddEntity(circle);
			document.AddEntity(hatch);
			this.ExportDXFText(canvas, document);
		}

		public override bool PointInObject(UnitPoint point)
		{
			return this.Layer != null && (Class88.smethod_4(base.Points[0], 0.2f, point) || Class88.smethod_4(base.Points[1], 0.2f, point) || Class88.smethod_4(base.Points[2], 0.2f, point));
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.VoltageTransformerTool;
			}
		}

		private const float float_0 = 0.2f;
	}
}
