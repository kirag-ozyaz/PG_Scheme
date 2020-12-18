using System;
using System.Data;
using System.Drawing;
using System.Linq;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class LoadSwitchTool : ObjectOnLine
	{
		public LoadSwitchTool()
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.Text = "ВН";
		}

		public LoadSwitchTool(Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(branch);
			this.Text = "ВН";
		}

		public LoadSwitchTool(DataRow r, Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(r, branch);
		}

		protected override void CreateImagePoints()
		{
			base.CreateImagePoints();
			base.Points.Add(new UnitPoint(0.0, -0.3));
			base.Points.Add(new UnitPoint(0.2, 0.2));
			base.Points.Add(new UnitPoint(-0.1, 0.2));
			base.Points.Add(new UnitPoint(0.1, 0.2));
			base.Points.Add(new UnitPoint(0.0, 0.1));
			base.Points.Add(new UnitPoint(-0.1, -0.3));
			base.Points.Add(new UnitPoint(-0.1, 0.2));
			base.Points.Add(new UnitPoint(0.2, 0.2));
			base.Points.Add(new UnitPoint(0.2, -0.3));
			this.systemChanging = true;
			UnitPoint centerPoint = new UnitPoint(0.0, 0.0);
			this.CenterPoint = centerPoint;
			this.systemChanging = false;
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if (canvas.Zoom <= canvas.Settings.ObjectOnLineZoomSimply)
			{
				base.Draw(canvas, unitrect, drawMode);
				return;
			}
			if (!this.Visible)
			{
				return;
			}
			using (Pen pen = new Pen(this.Color, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width)))
			{
				if (canvas.method_90() > 1)
				{
					if (pen.Width == 0f)
					{
						pen.Width = (float)canvas.method_90();
					}
					else
					{
						pen.Width *= (float)canvas.method_90();
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
					PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
					RectangleF rectangleF = new RectangleF(new PointF(base.Points[4].Point.X - 0.1f, base.Points[4].Point.Y - 0.1f), new SizeF(0.2f, -0.2f));
					PointF[] array2 = new PointF[]
					{
						array[0],
						array[1],
						array[3],
						array[2]
					};
					rectangleF = ConvertCanvas.ConvertToScreen(canvas, rectangleF);
					if (this.ComplexSwitchgear != null)
					{
						this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
					}
					if (!this.On)
					{
						array2[0] = array[5];
						array2[1] = array[6];
						array2[2] = array[7];
						array2[3] = array[8];
						canvas.Graphics.FillPolygon(solidBrush, array2);
						if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
						{
							pen.Width += 1.5f;
						}
					}
					else
					{
						canvas.Graphics.FillPolygon(solidBrush, array2);
					}
					canvas.Graphics.DrawLine(pen, array[0], array[1]);
					canvas.Graphics.DrawLine(pen, array[2], array[3]);
					canvas.Graphics.DrawEllipse(pen, rectangleF);
					this.DrawText(canvas, drawMode);
					base.DrawTextNormalSection(canvas);
					base.DrawDamage(canvas);
					base.DrawKey(canvas);
				}
			}
		}

		public override void vmethod_3(CanvasControl canvas, DxfDocument document)
		{
			this.ExportDXFSolid(document, base.Points);
			document.AddEntity(new Line(new Vector3(base.Points[0].X, base.Points[0].Y, 2.0), new Vector3(base.Points[1].X, base.Points[1].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[2].X, base.Points[2].Y, 2.0), new Vector3(base.Points[3].X, base.Points[3].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Circle(new Vector3(base.Points[4].X, base.Points[4].Y, 2.0), 0.1)
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			this.ExportDXFText(canvas, document);
		}

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			if (this.ComplexSwitchgear != null)
			{
				this.ComplexSwitchgear.DrawPrint(canvas, g, false);
			}
			Pen pen = new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			new SolidBrush(Color.Black);
			SolidBrush brush = new SolidBrush(Color.White);
			RectangleF rectangleF = new RectangleF(new PointF(base.Points[4].Point.X - 0.1f, base.Points[4].Point.Y - 0.1f), new SizeF(0.2f, -0.2f));
			PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			PointF[] points = new PointF[]
			{
				array[0],
				array[1],
				array[3],
				array[2]
			};
			rectangleF = ConvertCanvas.ConvertToScreen(canvas, rectangleF);
			canvas.Graphics.FillPolygon(brush, points);
			canvas.Graphics.DrawLine(pen, array[0], array[1]);
			canvas.Graphics.DrawLine(pen, array[2], array[3]);
			canvas.Graphics.DrawEllipse(pen, rectangleF);
			this.DrawText(canvas, eDrawMode.Print);
			base.DrawTextNormalSection(canvas);
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.LoadSwitchTool;
			}
		}

		public override bool PointInObject(UnitPoint point)
		{
			if (this.Layer == null)
			{
				return false;
			}
			UnitPoint[] array = new UnitPoint[]
			{
				base.Points[0],
				base.Points[1],
				base.Points[3],
				base.Points[2]
			};
			bool flag = false;
			int i = 0;
			int num = array.Length - 1;
			while (i < array.Length)
			{
				if (((array[i].Y <= point.Y && point.Y < array[num].Y) || (array[num].Y <= point.Y && point.Y < array[i].Y)) && point.X > (array[num].X - array[i].X) * (point.Y - array[i].Y) / (array[num].Y - array[i].Y) + array[i].X)
				{
					flag = !flag;
				}
				num = i++;
			}
			return flag;
		}
	}
}
