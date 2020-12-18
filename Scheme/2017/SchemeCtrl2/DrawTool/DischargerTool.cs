using System;
using System.Data;
using System.Drawing;
using System.Linq;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class DischargerTool : ObjectOnLine
	{
		public DischargerTool()
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.Text = "Разрядник";
		}

		public DischargerTool(Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(branch);
			this.Text = "Разрядник";
		}

		public DischargerTool(DataRow r, Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(r, branch);
		}

		protected override void CreateImagePoints()
		{
			base.Points.Add(new UnitPoint(-0.1, -0.3));
			base.Points.Add(new UnitPoint(-0.1, 0.3));
			base.Points.Add(new UnitPoint(0.1, 0.3));
			base.Points.Add(new UnitPoint(0.1, -0.3));
			base.Points.Add(new UnitPoint(0.0, 0.3));
			base.Points.Add(new UnitPoint(0.0, 0.1));
			base.Points.Add(new UnitPoint(-0.08, 0.25));
			base.Points.Add(new UnitPoint(0.08, 0.25));
			this.systemChanging = true;
			this.CenterPoint = new UnitPoint(0.0, 0.0);
			this.systemChanging = false;
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
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
					if (this.ComplexSwitchgear != null)
					{
						this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
					}
					PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
					PointF[] points = new PointF[]
					{
						array[0],
						array[1],
						array[2],
						array[3]
					};
					canvas.Graphics.FillPolygon(solidBrush, points);
					canvas.Graphics.DrawPolygon(pen, points);
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

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			if (this.ComplexSwitchgear != null)
			{
				this.ComplexSwitchgear.DrawPrint(canvas, g, false);
			}
			Pen pen = new Pen(Color.Black);
			PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			PointF[] points = new PointF[]
			{
				array[0],
				array[1],
				array[2],
				array[3]
			};
			g.FillPolygon(new SolidBrush(Color.White), points);
			g.DrawPolygon(pen, points);
			g.DrawLine(pen, array[4], array[5]);
			g.DrawLine(pen, array[6], array[5]);
			g.DrawLine(pen, array[7], array[5]);
			this.DrawText(canvas, eDrawMode.Print);
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.DischargerTool;
			}
		}

		public override bool On
		{
			get
			{
				return true;
			}
		}
	}
}
