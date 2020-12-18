using System;
using System.Data;
using System.Drawing;
using System.Linq;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class CircuitBreakerTool : ObjectOnLine
	{
		public CircuitBreakerTool()
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.Text = "АВ";
		}

		public CircuitBreakerTool(Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(branch);
			this.Text = "АВ";
		}

		public CircuitBreakerTool(DataRow r, Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(r, branch);
		}

		protected override void CreateImagePoints()
		{
			base.CreateImagePoints();
			base.Points.Add(new UnitPoint(0.0, -0.2));
			base.Points.Add(new UnitPoint(0.2, 0.3));
			base.Points.Add(new UnitPoint(0.06, -0.05));
			base.Points.Add(new UnitPoint(0.14, 0.15));
			base.Points.Add(new UnitPoint(0.19, 0.13));
			base.Points.Add(new UnitPoint(0.11, -0.07));
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
					array2[0] = array[6];
					array2[1] = array[7];
					array2[2] = array[8];
					array2[3] = array[9];
					if (!this.On && (drawMode & eDrawMode.Color) == eDrawMode.Color)
					{
						pen.Width += 2f;
					}
					canvas.Graphics.FillPolygon(solidBrush, array2);
					canvas.Graphics.DrawLine(pen, array[0], array[1]);
					array2[0] = array[2];
					array2[1] = array[3];
					array2[2] = array[4];
					array2[3] = array[5];
					canvas.Graphics.DrawPolygon(pen, array2);
					this.DrawText(canvas, drawMode);
					base.DrawTextNormalSection(canvas);
					base.DrawDamage(canvas);
					base.DrawKey(canvas);
				}
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			if (!this.Visible)
			{
				return;
			}
			if (this.ComplexSwitchgear != null)
			{
				this.ComplexSwitchgear.DrawPrint(canvas, g, false);
			}
			Pen pen = new Pen(Color.Black);
			SolidBrush solidBrush = new SolidBrush(Color.White);
			PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			PointF[] array2 = new PointF[]
			{
				array[6],
				array[7],
				array[8],
				array[9]
			};
			canvas.Graphics.FillPolygon(solidBrush, array2);
			canvas.Graphics.DrawLine(pen, array[0], array[1]);
			array2[0] = array[2];
			array2[1] = array[3];
			array2[2] = array[4];
			array2[3] = array[5];
			canvas.Graphics.DrawPolygon(pen, array2);
			this.DrawText(canvas, eDrawMode.Print);
			pen.Dispose();
			solidBrush.Dispose();
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.CircuitBreaker;
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
				base.Points[6],
				base.Points[7],
				base.Points[8],
				base.Points[9]
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
