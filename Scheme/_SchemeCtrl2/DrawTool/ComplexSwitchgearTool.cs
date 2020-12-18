using System;
using System.Data;
using System.Drawing;
using System.Linq;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.Layers;

namespace SchemeCtrl2.DrawTool
{
	public class ComplexSwitchgearTool : ObjectOnLine
	{
		public ComplexSwitchgearTool()
		{
		}

		public ComplexSwitchgearTool(Branch branch) : base(branch)
		{
		}

		public ComplexSwitchgearTool(DataRow dataRow_0, Branch branch) : base(dataRow_0, branch)
		{
		}

		public override int IdBase
		{
			get
			{
				return -2;
			}
			set
			{
				base.IdBase = value;
			}
		}

		public override DrawingLayer Layer
		{
			get
			{
				return this.IntegratedSwitch.Layer;
			}
			set
			{
			}
		}

		public ComplexSwitchgearTool.eRollingOutReason RollingOutReason
		{
			get
			{
				return this.eRollingOutReason_0;
			}
			set
			{
				if (value == ComplexSwitchgearTool.eRollingOutReason.None)
				{
					this.RollingOut = false;
				}
				else
				{
					this.RollingOut = true;
					if (!this.RollingOut)
					{
						return;
					}
				}
				this.eRollingOutReason_0 = value;
			}
		}

		public bool RollingOut
		{
			get
			{
				return !base.NormalSectionModeOn && this.bool_1;
			}
			set
			{
				if (this.bool_1 != value && this.IntegratedSwitch != null && !this.IntegratedSwitch.On)
				{
					this.bool_1 = value;
					double num = base.Points[12].X - this.CenterPoint.X;
					double num2 = base.Points[12].Y - this.CenterPoint.Y;
					if (!this.bool_1)
					{
						num *= -1.0;
						num2 *= -1.0;
					}
					for (int i = 6; i < 12; i++)
					{
						base.Points[i] = new UnitPoint(num + base.Points[i].X, num2 + base.Points[i].Y);
					}
					this.IntegratedSwitch.ShiftPoints(num, num2);
					return;
				}
			}
		}

		public ObjectOnLine IntegratedSwitch
		{
			get
			{
				return this.objectOnLine_0;
			}
			set
			{
				if (this.objectOnLine_0 != null)
				{
					this.objectOnLine_0.OnChanged -= this.objectOnLine_0_OnChanged;
				}
				this.objectOnLine_0 = value;
				this.objectOnLine_0.OnChanged += this.objectOnLine_0_OnChanged;
			}
		}

		private void objectOnLine_0_OnChanged(object sender, EventArgs e)
		{
			if (this.objectOnLine_0.On && this.RollingOut)
			{
				this.objectOnLine_0.On = false;
			}
		}

		public override ComplexSwitchgearTool ComplexSwitchgear
		{
			get
			{
				return this;
			}
		}

		public override bool On
		{
			get
			{
				return this.IntegratedSwitch != null && !this.RollingOut;
			}
		}

		public override Color Color
		{
			get
			{
				if (this.IntegratedSwitch != null)
				{
					return this.IntegratedSwitch.Color;
				}
				return base.Color;
			}
			set
			{
				base.Color = value;
			}
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.ComplexSwitchgearTool;
			}
		}

		protected override void CreateImagePoints()
		{
			base.CreateImagePoints();
			base.Points.Add(new UnitPoint(0.0, -0.5));
			base.Points.Add(new UnitPoint(0.1, -0.4));
			base.Points.Add(new UnitPoint(-0.1, -0.4));
			base.Points.Add(new UnitPoint(0.0, 0.5));
			base.Points.Add(new UnitPoint(0.1, 0.4));
			base.Points.Add(new UnitPoint(-0.1, 0.4));
			base.Points.Add(new UnitPoint(0.0, -0.4));
			base.Points.Add(new UnitPoint(0.1, -0.3));
			base.Points.Add(new UnitPoint(-0.1, -0.3));
			base.Points.Add(new UnitPoint(0.0, 0.4));
			base.Points.Add(new UnitPoint(0.1, 0.3));
			base.Points.Add(new UnitPoint(-0.1, 0.3));
			base.Points.Add(new UnitPoint(0.2, 0.0));
			this.systemChanging = true;
			UnitPoint centerPoint = new UnitPoint(0.0, 0.0);
			this.CenterPoint = centerPoint;
			this.systemChanging = false;
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if (canvas.Zoom <= canvas.Settings.ObjectOnLineZoomSimply)
			{
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
					PointF[] points = new PointF[]
					{
						array[0],
						array[1],
						array[4],
						array[3],
						array[5],
						array[2]
					};
					canvas.Graphics.FillPolygon(solidBrush, points);
					canvas.Graphics.DrawLine(pen, array[0], array[1]);
					canvas.Graphics.DrawLine(pen, array[0], array[2]);
					canvas.Graphics.DrawLine(pen, array[3], array[4]);
					canvas.Graphics.DrawLine(pen, array[3], array[5]);
					canvas.Graphics.DrawLine(pen, array[6], array[7]);
					canvas.Graphics.DrawLine(pen, array[6], array[8]);
					canvas.Graphics.DrawLine(pen, array[9], array[10]);
					canvas.Graphics.DrawLine(pen, array[9], array[11]);
					this.DrawText(canvas, drawMode);
					this.DrawTextMode(canvas);
					base.DrawDamage(canvas);
					base.DrawKey(canvas);
				}
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics graphics_0, bool isColor = false)
		{
			if (!this.Visible)
			{
				return;
			}
			SolidBrush solidBrush = new SolidBrush(Color.White);
			Pen pen = new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			PointF[] points = new PointF[]
			{
				array[0],
				array[1],
				array[4],
				array[3],
				array[5],
				array[2]
			};
			canvas.Graphics.FillPolygon(solidBrush, points);
			canvas.Graphics.DrawLine(pen, array[0], array[1]);
			canvas.Graphics.DrawLine(pen, array[0], array[2]);
			canvas.Graphics.DrawLine(pen, array[3], array[4]);
			canvas.Graphics.DrawLine(pen, array[3], array[5]);
			canvas.Graphics.DrawLine(pen, array[6], array[7]);
			canvas.Graphics.DrawLine(pen, array[6], array[8]);
			canvas.Graphics.DrawLine(pen, array[9], array[10]);
			canvas.Graphics.DrawLine(pen, array[9], array[11]);
			this.DrawText(canvas, eDrawMode.Print);
			this.DrawTextMode(canvas);
			base.DrawDamage(canvas);
			base.DrawKey(canvas);
			pen.Dispose();
			solidBrush.Dispose();
		}

		protected override RectangleF GetRectangleText(CanvasControl canvas)
		{
			RectangleF empty = RectangleF.Empty;
			if (this.eRollingOutReason_0 == ComplexSwitchgearTool.eRollingOutReason.None)
			{
				return empty;
			}
			if (base.Points.Count > 0)
			{
				empty.Location = base.Points[0].Point;
				empty.Size = new SizeF(0f, 0f);
				float num = empty.Left;
				float num2 = empty.Right;
				float num3 = empty.Top;
				float num4 = empty.Bottom;
				foreach (UnitPoint unitPoint in base.Points)
				{
					if (unitPoint.X < (double)num)
					{
						num = (float)unitPoint.X;
					}
					if (unitPoint.X > (double)num2)
					{
						num2 = (float)unitPoint.X;
					}
					if (unitPoint.Y < (double)num3)
					{
						num3 = (float)unitPoint.Y;
					}
					if (unitPoint.Y > (double)num4)
					{
						num4 = (float)unitPoint.Y;
					}
				}
				RectangleF rectangleF = new RectangleF(num, num3, num2 - num, num4 - num3);
				Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style);
				string text = string.Empty;
				switch (this.eRollingOutReason_0)
				{
				case ComplexSwitchgearTool.eRollingOutReason.Repair:
					text = "P";
					break;
				case ComplexSwitchgearTool.eRollingOutReason.Test:
					text = "И";
					break;
				}
				SizeF sizeF = canvas.Graphics.MeasureString(text, font);
				font.Dispose();
				SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
				empty = new RectangleF(rectangleF.Location, size);
				empty.X = rectangleF.Location.X + rectangleF.Width;
				empty.Y = rectangleF.Location.Y + rectangleF.Height / 2f - empty.Height / 2f;
				return empty;
			}
			return empty;
		}

		protected void DrawTextMode(CanvasControl canvas)
		{
			if (this.eRollingOutReason_0 != ComplexSwitchgearTool.eRollingOutReason.None)
			{
				if (base.UseSettingsText && this.TextProperty.FontSize * canvas.Zoom <= canvas.Settings.FontSizeNoVisible)
				{
					return;
				}
				Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style | FontStyle.Bold);
				string s = string.Empty;
				switch (this.eRollingOutReason_0)
				{
				case ComplexSwitchgearTool.eRollingOutReason.Repair:
					s = "P";
					break;
				case ComplexSwitchgearTool.eRollingOutReason.Test:
					s = "И";
					break;
				default:
					return;
				}
				RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetRectangleText(canvas));
				if (rectangleF.Size.Width > 0f && rectangleF.Size.Height > 0f)
				{
					RectangleF rect = rectangleF;
					rect.X += 2f * canvas.Zoom;
					rect.Width -= 5f * canvas.Zoom;
					rect.Y += 1.5f * canvas.Zoom;
					rect.Height -= 4f * canvas.Zoom;
					canvas.Graphics.FillRectangle(new SolidBrush(Color.LightGray), rect);
					canvas.Graphics.DrawString(s, font, new SolidBrush(Color.Black), rectangleF.Location);
				}
				font.Dispose();
			}
		}

		public override bool PointInObject(UnitPoint point)
		{
			return false;
		}

		private bool bool_1;

		private ComplexSwitchgearTool.eRollingOutReason eRollingOutReason_0 = ComplexSwitchgearTool.eRollingOutReason.None;

		private ObjectOnLine objectOnLine_0;

		public enum eRollingOutReason
		{
			Repair,
			Test,
			None
		}
	}
}
