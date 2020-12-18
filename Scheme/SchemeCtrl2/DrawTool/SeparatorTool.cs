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
	public class SeparatorTool : ObjectOnLine
	{
		public SeparatorTool()
		{
			
			
			this.Text = "Отделитель";
		}

		public SeparatorTool(Branch branch)
		{
			
			base..ctor(branch);
			this.Text = "Отделитель";
		}

		public SeparatorTool(DataRow r, Branch branch)
		{
			
			base..ctor(r, branch);
		}

		protected override void CreateImagePoints()
		{
			base.CreateImagePoints();
			base.Points.Add(new UnitPoint(0.0, -0.2));
			base.Points.Add(new UnitPoint(0.2, 0.3));
			base.Points.Add(new UnitPoint(-0.1, 0.3));
			base.Points.Add(new UnitPoint(0.1, 0.3));
			base.Points.Add(new UnitPoint(0.1, 0.05));
			base.Points.Add(new UnitPoint(0.3, 0.05));
			base.Points.Add(new UnitPoint(0.2, 0.0));
			base.Points.Add(new UnitPoint(0.2, 0.1));
			base.Points.Add(new UnitPoint(-0.1, -0.2));
			base.Points.Add(new UnitPoint(-0.1, 0.3));
			base.Points.Add(new UnitPoint(0.3, 0.3));
			base.Points.Add(new UnitPoint(0.3, -0.2));
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
					PointF[] array2 = new PointF[4];
					if (this.ComplexSwitchgear != null)
					{
						this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
					}
					array2[0] = array[8];
					array2[1] = array[9];
					array2[2] = array[10];
					array2[3] = array[11];
					canvas.Graphics.FillPolygon(solidBrush, array2);
					if (!this.On && (drawMode & eDrawMode.Color) == eDrawMode.Color)
					{
						pen.Width += 2f;
					}
					(new PointF[]
					{
						array[0],
						array[1],
						array[3],
						array[2],
						array[4],
						array[5],
						default(PointF),
						array[6]
					})[6] = array[7];
					canvas.Graphics.DrawLine(pen, array[0], array[1]);
					canvas.Graphics.DrawLine(pen, array[2], array[3]);
					canvas.Graphics.DrawLine(pen, array[4], array[5]);
					canvas.Graphics.DrawLine(pen, array[6], array[5]);
					canvas.Graphics.DrawLine(pen, array[7], array[5]);
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
			document.AddEntity(new Line(new Vector3(base.Points[0].X, base.Points[0].Y, 2.0), new Vector3(base.Points[1].X, base.Points[1].Y, 3.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[2].X, base.Points[2].Y, 3.0), new Vector3(base.Points[3].X, base.Points[3].Y, 3.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			this.ExportDXFText(canvas, document);
		}

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			if (!this.Visible)
			{
				return;
			}
			SolidBrush solidBrush = new SolidBrush(Color.White);
			Pen pen;
			if (isColor)
			{
				pen = new Pen(this.Color, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			}
			else
			{
				pen = new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			}
			PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			PointF[] array2 = new PointF[4];
			if (this.ComplexSwitchgear != null)
			{
				this.ComplexSwitchgear.DrawPrint(canvas, g, isColor);
			}
			array2[0] = array[8];
			array2[1] = array[9];
			array2[2] = array[10];
			array2[3] = array[11];
			if (!this.On && isColor)
			{
				if (base.IsNormalSection)
				{
					canvas.Graphics.FillPolygon(new SolidBrush(base.ColorOffN), array2);
				}
				else
				{
					canvas.Graphics.FillPolygon(new SolidBrush(base.ColorOff), array2);
				}
				pen.Width += 2f;
			}
			else
			{
				canvas.Graphics.FillPolygon(solidBrush, array2);
			}
			(new PointF[]
			{
				array[0],
				array[1],
				array[3],
				array[2],
				array[4],
				array[5],
				default(PointF),
				array[6]
			})[6] = array[7];
			canvas.Graphics.DrawLine(pen, array[0], array[1]);
			canvas.Graphics.DrawLine(pen, array[2], array[3]);
			canvas.Graphics.DrawLine(pen, array[4], array[5]);
			canvas.Graphics.DrawLine(pen, array[6], array[5]);
			canvas.Graphics.DrawLine(pen, array[7], array[5]);
			this.DrawText(canvas, eDrawMode.Print);
			if (isColor)
			{
				base.DrawTextNormalSection(canvas);
				base.DrawDamage(canvas);
				base.DrawKey(canvas);
			}
			pen.Dispose();
			solidBrush.Dispose();
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.SeparatorTool;
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
