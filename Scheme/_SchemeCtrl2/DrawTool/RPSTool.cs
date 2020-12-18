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
	public class RPSTool : ObjectOnLine
	{
		public RPSTool()
		{
		}

		public RPSTool(Branch branch) : base(branch)
		{
		}

		public RPSTool(DataRow dataRow_0, Branch branch) : base(dataRow_0, branch)
		{
		}

		protected override void CreateImagePoints()
		{
			base.CreateImagePoints();
			base.Points.Add(new UnitPoint(0.0, -0.2));
			base.Points.Add(new UnitPoint(0.2, 0.3));
			base.Points.Add(new UnitPoint(0.1, 0.3));
			base.Points.Add(new UnitPoint(-0.1, 0.3));
			base.Points.Add(new UnitPoint(-0.1, -0.2));
			base.Points.Add(new UnitPoint(-0.1, 0.3));
			base.Points.Add(new UnitPoint(0.2, 0.3));
			base.Points.Add(new UnitPoint(0.2, -0.2));
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
					PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
					if (this.ComplexSwitchgear != null)
					{
						this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
					}
					PointF[] array2 = new PointF[]
					{
						array[0],
						array[1],
						array[2],
						array[3]
					};
					if (!this.On)
					{
						array2[0] = array[4];
						array2[1] = array[5];
						array2[2] = array[6];
						array2[3] = array[7];
						canvas.Graphics.FillPolygon(solidBrush, array2);
						if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
						{
							pen.Width += 2f;
						}
					}
					else
					{
						canvas.Graphics.FillPolygon(solidBrush, array2);
					}
					canvas.Graphics.DrawLine(pen, array[0], array[1]);
					this.DrawText(canvas, drawMode);
					base.DrawTextNormalSection(canvas);
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
			PointF[] array = new PointF[4];
			new SolidBrush(Color.Black);
			SolidBrush brush = new SolidBrush(Color.White);
			PointF[] array2 = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			array[0] = array2[0];
			array[1] = array2[1];
			array[2] = array2[2];
			array[3] = array2[3];
			canvas.Graphics.FillPolygon(brush, array);
			graphics_0.DrawLine(pen, array2[0], array2[1]);
			this.DrawText(canvas, eDrawMode.Print);
		}

		public override void ExportDXF(CanvasControl canvas, DxfDocument document)
		{
			this.ExportDXFSolid(document, new List<UnitPoint>
			{
				base.Points[0],
				base.Points[3],
				base.Points[1],
				base.Points[2]
			});
			document.AddEntity(new Line(new Vector3(base.Points[0].X, base.Points[0].Y, 2.0), new Vector3(base.Points[1].X, base.Points[1].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			this.ExportDXFText(canvas, document);
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.RPSTool;
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
				base.Points[2],
				base.Points[3]
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
