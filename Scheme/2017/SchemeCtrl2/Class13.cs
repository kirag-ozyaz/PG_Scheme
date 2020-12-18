using System;
using System.Data;
using System.Drawing;
using System.Linq;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;

internal class Class13 : ObjectOnLine
{
	internal Class13()
	{
		Class90.TDroV38zslI2T();
		base..ctor();
		this.Text = "Счетчик";
	}

	internal Class13(Branch branch_0)
	{
		Class90.TDroV38zslI2T();
		base..ctor(branch_0);
		this.Text = "Счетчик";
	}

	internal Class13(DataRow dataRow_0, Branch branch_0)
	{
		Class90.TDroV38zslI2T();
		base..ctor(dataRow_0, branch_0);
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
		base.CreateImagePoints();
		base.Points.Add(new UnitPoint(-0.15, 0.25));
		base.Points.Add(new UnitPoint(0.15, 0.25));
		base.Points.Add(new UnitPoint(0.15, -0.25));
		base.Points.Add(new UnitPoint(-0.15, -0.25));
		base.Points.Add(new UnitPoint(-0.15, 0.125));
		base.Points.Add(new UnitPoint(0.15, 0.125));
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
				RectangleF unitrect2 = new RectangleF(new PointF(base.Points[4].Point.X - 0.1f, base.Points[4].Point.Y - 0.1f), new SizeF(0.2f, -0.2f));
				PointF[] points = new PointF[]
				{
					array[0],
					array[1],
					array[2],
					array[3]
				};
				unitrect2 = ConvertCanvas.ConvertToScreen(canvas, unitrect2);
				if (this.ComplexSwitchgear != null)
				{
					this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
				}
				canvas.Graphics.FillPolygon(solidBrush, points);
				canvas.Graphics.DrawPolygon(pen, points);
				canvas.Graphics.DrawLine(pen, array[4], array[5]);
				this.DrawText(canvas, drawMode);
				base.DrawTextNormalSection(canvas);
				base.DrawDamage(canvas);
				base.DrawKey(canvas);
			}
		}
	}

	public override TypeSwitch TypeSwitch
	{
		get
		{
			return TypeSwitch.ElectricMeterTool;
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
