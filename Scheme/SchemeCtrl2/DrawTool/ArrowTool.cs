using System;
using System.Data;
using System.Drawing;
using System.Linq;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class ArrowTool : ObjectOnLine
	{
		public ArrowTool()
		{
			
			
			this.Text = "Перенос нагрузки";
		}

		public ArrowTool(Branch branch)
		{
			
			base..ctor(branch);
			this.Text = "Перенос нагрузки";
		}

		public ArrowTool(DataRow r, Branch branch)
		{
			
			base..ctor(r, branch);
		}

		public override int IdBase
		{
			get
			{
				return -1;
			}
			set
			{
				base.IdBase = value;
			}
		}

		protected override void CreateImagePoints()
		{
			base.Points.Add(new UnitPoint(0.22, -0.25));
			base.Points.Add(new UnitPoint(0.37, -0.25));
			base.Points.Add(new UnitPoint(0.37, 0.1));
			base.Points.Add(new UnitPoint(0.22, 0.1));
			base.Points.Add(new UnitPoint(0.15, 0.1));
			base.Points.Add(new UnitPoint(0.45, 0.1));
			base.Points.Add(new UnitPoint(0.3, 0.25));
			this.systemChanging = true;
			this.CenterPoint = new UnitPoint(0.0, 0.0);
			this.systemChanging = false;
		}

		public override Color Color
		{
			get
			{
				if (this.Layer != null && base.UseSettingColor)
				{
					return this.Layer.Parent.Settings.ArrowToolColor;
				}
				return base.Color;
			}
			set
			{
				base.Color = value;
			}
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if (!this.Visible)
			{
				return;
			}
			using (SolidBrush solidBrush = new SolidBrush(this.Color))
			{
				if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
				{
					if ((drawMode & eDrawMode.Color) != eDrawMode.Color)
					{
						solidBrush.Color = Color.Black;
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
				canvas.Graphics.FillPolygon(solidBrush, points);
				points = new PointF[]
				{
					array[4],
					array[5],
					array[6]
				};
				canvas.Graphics.FillPolygon(solidBrush, points);
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			SolidBrush solidBrush = new SolidBrush(Color.Black);
			PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			PointF[] points = new PointF[]
			{
				array[0],
				array[1],
				array[2],
				array[3]
			};
			canvas.Graphics.FillPolygon(solidBrush, points);
			points = new PointF[]
			{
				array[4],
				array[5],
				array[6]
			};
			canvas.Graphics.FillPolygon(solidBrush, points);
			solidBrush.Dispose();
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
				return TypeSwitch.ArrowTool;
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
