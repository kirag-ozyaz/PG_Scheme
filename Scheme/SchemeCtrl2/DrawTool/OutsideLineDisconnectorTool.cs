using System;
using System.Data;
using System.Drawing;
using System.Linq;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class OutsideLineDisconnectorTool : ObjectOnLine
	{
		public OutsideLineDisconnectorTool()
		{
			
			
			this.Text = "РЛНД";
		}

		public OutsideLineDisconnectorTool(Branch branch)
		{
			
			base..ctor(branch);
			this.Text = "РЛНД";
		}

		public OutsideLineDisconnectorTool(DataRow r, Branch branch)
		{
			
			base..ctor(r, branch);
		}

		protected override void CreateImagePoints()
		{
			base.Points.Add(new UnitPoint(0.0, -0.2));
			base.Points.Add(new UnitPoint(0.09, 0.18));
			base.Points.Add(new UnitPoint(-0.05, 0.18));
			base.Points.Add(new UnitPoint(0.05, 0.18));
			base.Points.Add(new UnitPoint(-0.1, -0.2));
			base.Points.Add(new UnitPoint(-0.1, 0.2));
			base.Points.Add(new UnitPoint(0.1, 0.2));
			base.Points.Add(new UnitPoint(0.1, -0.2));
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
			using (Pen pen = new Pen(canvas.Settings.BackgroundColor, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width)))
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
				using (SolidBrush solidBrush = new SolidBrush(this.Color))
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
					PointF[] array2 = new PointF[]
					{
						array[0],
						array[1],
						array[3],
						array[2]
					};
					if (this.ComplexSwitchgear != null)
					{
						this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
					}
					array2[0] = array[4];
					array2[1] = array[5];
					array2[2] = array[6];
					array2[3] = array[7];
					if (base.IsNormalSection)
					{
						canvas.Graphics.FillPolygon(solidBrush, array2);
					}
					else
					{
						canvas.Graphics.FillPolygon(solidBrush, array2);
					}
					if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
					{
						pen.Width += 2f;
					}
					canvas.Graphics.DrawLine(pen, array[0], array[1]);
					canvas.Graphics.DrawLine(pen, array[2], array[3]);
					this.DrawText(canvas, drawMode);
					base.DrawTextNormalSection(canvas);
					base.DrawDamage(canvas);
					base.DrawKey(canvas);
				}
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
				base.Points[4],
				base.Points[5],
				base.Points[6],
				base.Points[7]
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

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			if (this.ComplexSwitchgear != null)
			{
				this.ComplexSwitchgear.DrawPrint(canvas, g, false);
			}
			new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			SolidBrush brush = new SolidBrush(Color.Black);
			PointF[] points = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			g.FillPolygon(brush, points);
			this.DrawText(canvas, eDrawMode.Print);
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.OutsideLineDisconnectorTool;
			}
		}
	}
}
