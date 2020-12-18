using System;
using System.Data;
using System.Drawing;
using System.Linq;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class VacuumSwitchTool : ObjectOnLine
	{
		public VacuumSwitchTool()
		{
			
			
			this.Text = "ВВ";
		}

		public VacuumSwitchTool(Branch branch)
		{
			
			base..ctor(branch);
			this.Text = "ВВ";
		}

		public VacuumSwitchTool(DataRow r, Branch branch)
		{
			
			base..ctor(r, branch);
		}

		protected override void CreateImagePoints()
		{
			base.CreateImagePoints();
			base.Points.Add(new UnitPoint(-0.2, -0.2));
			base.Points.Add(new UnitPoint(-0.2, 0.2));
			base.Points.Add(new UnitPoint(0.2, 0.2));
			base.Points.Add(new UnitPoint(0.2, -0.2));
			base.Points.Add(new UnitPoint(-0.1, -0.1));
			base.Points.Add(new UnitPoint(-0.1, 0.1));
			base.Points.Add(new UnitPoint(0.1, 0.1));
			base.Points.Add(new UnitPoint(0.1, -0.1));
			this.systemChanging = true;
			this.CenterPoint = new UnitPoint(0.0, 0.0);
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
			using (SolidBrush solidBrush = new SolidBrush(this.Color))
			{
				using (SolidBrush solidBrush2 = new SolidBrush(canvas.Settings.BackgroundColor))
				{
					if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
					{
						if ((drawMode & eDrawMode.Color) != eDrawMode.Color)
						{
							solidBrush.Color = Color.Black;
							solidBrush2.Color = Color.White;
						}
					}
					else if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
					{
						if (this.Selected)
						{
							solidBrush.Color = this.SelectedColor;
						}
						else if (base.Bookmark != null)
						{
							solidBrush.Color = canvas.Settings.MarkedObjColor;
						}
						if (this.Flashing && canvas.ConvertColorFlash)
						{
							solidBrush.Color = canvas.Settings.BackFlashingColor;
						}
						if (!this.On)
						{
							if (base.IsNormalSection)
							{
								solidBrush2.Color = base.ColorOffN;
							}
							else
							{
								solidBrush2.Color = base.ColorOff;
							}
						}
					}
					else
					{
						if (this.Selected)
						{
							solidBrush.Color = Color.Gray;
						}
						else if (base.Bookmark != null)
						{
							solidBrush.Color = Color.LightGray;
						}
						if (this.Flashing && canvas.ConvertColorFlash)
						{
							solidBrush.Color = Color.White;
						}
					}
					PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
					PointF[] points = new PointF[]
					{
						array[0],
						array[1],
						array[2],
						array[3]
					};
					if (this.ComplexSwitchgear != null)
					{
						this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
					}
					canvas.Graphics.FillPolygon(solidBrush, points);
					points = new PointF[]
					{
						array[4],
						array[5],
						array[6],
						array[7]
					};
					canvas.Graphics.FillPolygon(solidBrush2, points);
					this.DrawText(canvas, drawMode);
					base.DrawTextNormalSection(canvas);
					base.DrawDamage(canvas);
					base.DrawKey(canvas);
				}
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			if (this.ComplexSwitchgear != null)
			{
				this.ComplexSwitchgear.DrawPrint(canvas, g, false);
			}
			new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			SolidBrush brush = new SolidBrush(Color.Black);
			SolidBrush brush2 = new SolidBrush(Color.White);
			PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			PointF[] points = new PointF[]
			{
				array[0],
				array[1],
				array[2],
				array[3]
			};
			g.FillPolygon(brush, points);
			points = new PointF[]
			{
				array[4],
				array[5],
				array[6],
				array[7]
			};
			g.FillPolygon(brush2, points);
			this.DrawText(canvas, eDrawMode.Print);
		}

		public override bool PointInObject(UnitPoint point)
		{
			if (this.Layer == null)
			{
				return false;
			}
			UnitPoint[] array = base.Points.ToArray<UnitPoint>();
			UnitPoint[] array2 = new UnitPoint[]
			{
				array[0],
				array[1],
				array[2],
				array[3]
			};
			bool flag = false;
			int i = 0;
			int num = array2.Length - 1;
			while (i < array2.Length)
			{
				if (((array2[i].Y <= point.Y && point.Y < array2[num].Y) || (array2[num].Y <= point.Y && point.Y < array2[i].Y)) && point.X > (array2[num].X - array2[i].X) * (point.Y - array2[i].Y) / (array2[num].Y - array[i].Y) + array2[i].X)
				{
					flag = !flag;
				}
				num = i++;
			}
			return flag;
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.VacuumSwitchTool;
			}
		}
	}
}
