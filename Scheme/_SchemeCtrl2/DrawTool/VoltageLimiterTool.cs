using System;
using System.Data;
using System.Drawing;
using System.Linq;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class VoltageLimiterTool : ObjectOnLine
	{
		public VoltageLimiterTool()
		{
		}

		public VoltageLimiterTool(Branch branch) : base(branch)
		{
		}

		public VoltageLimiterTool(DataRow dataRow_0, Branch branch) : base(dataRow_0, branch)
		{
		}

		protected override void CreateImagePoints()
		{
			base.Points.Add(new UnitPoint(-0.1, -0.3));
			base.Points.Add(new UnitPoint(-0.1, 0.3));
			base.Points.Add(new UnitPoint(0.1, 0.3));
			base.Points.Add(new UnitPoint(0.1, -0.3));
			base.Points.Add(new UnitPoint(-0.15, 0.25));
			base.Points.Add(new UnitPoint(-0.15, 0.1));
			base.Points.Add(new UnitPoint(0.15, -0.25));
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
					canvas.Graphics.DrawPolygon(pen, points);
					canvas.Graphics.DrawLine(pen, array[4], array[5]);
					canvas.Graphics.DrawLine(pen, array[6], array[5]);
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
			Pen pen = new Pen(Color.Black);
			PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			PointF[] points = new PointF[]
			{
				array[0],
				array[1],
				array[2],
				array[3]
			};
			graphics_0.FillPolygon(new SolidBrush(Color.White), points);
			graphics_0.DrawPolygon(pen, points);
			graphics_0.DrawLine(pen, array[4], array[5]);
			graphics_0.DrawLine(pen, array[6], array[5]);
			this.DrawText(canvas, eDrawMode.Print);
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.VoltageLimiterTool;
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
