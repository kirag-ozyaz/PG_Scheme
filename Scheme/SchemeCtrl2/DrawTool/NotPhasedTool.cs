using System;
using System.Data;
using System.Drawing;
using System.Linq;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class NotPhasedTool : ObjectOnLine
	{
		public NotPhasedTool()
		{
			
			
			this.Text = "Несфазировано";
		}

		public NotPhasedTool(Branch branch)
		{
			
			base..ctor(branch);
			this.Text = "Несфазировано";
		}

		public NotPhasedTool(DataRow r, Branch branch)
		{
			
			base..ctor(r, branch);
		}

		public override Color Color
		{
			get
			{
				if (this.Layer == null || !base.UseSettingColor)
				{
					return base.Color;
				}
				if (!this.Layer.Parent.Settings.NoPhasedToolColorLine || this.Parent == null || this.Parent.GetType() != typeof(Branch))
				{
					return this.Layer.Parent.Settings.NoPhasedToolColor;
				}
				Branch branch = (Branch)this.Parent;
				if (branch.CouplingRelation.On && branch.CouplingRelation.amperagePoint != null && ((LineTool)branch.Parent).Amperages.ContainsKey(branch.CouplingRelation.amperagePoint))
				{
					return branch.Color;
				}
				return branch.ColorOff;
			}
			set
			{
				base.Color = value;
			}
		}

		protected override void CreateImagePoints()
		{
			base.Points.Add(new UnitPoint(-0.2, -0.2));
			base.Points.Add(new UnitPoint(-0.2, 0.2));
			base.Points.Add(new UnitPoint(0.2, 0.2));
			base.Points.Add(new UnitPoint(0.2, -0.2));
			base.Points.Add(new UnitPoint(0.19, -0.19));
			this.systemChanging = true;
			this.CenterPoint = new UnitPoint(0.0, 0.0);
			this.systemChanging = false;
		}

		public override float Angle
		{
			get
			{
				return base.Angle;
			}
			set
			{
				if (base.MappingState)
				{
					base.Angle = 0f;
					return;
				}
				base.Angle = value;
			}
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
					Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style | FontStyle.Bold);
					if ((double)font.Size >= 0.1)
					{
						string s = "Ф";
						canvas.Graphics.DrawString(s, font, new SolidBrush(pen.Color), array[4]);
					}
					font.Dispose();
					this.DrawText(canvas, drawMode);
				}
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			if (this.ComplexSwitchgear != null)
			{
				this.ComplexSwitchgear.DrawPrint(canvas, g, false);
			}
			Pen pen = new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			SolidBrush solidBrush = new SolidBrush(Color.White);
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
			Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style | FontStyle.Bold);
			if ((double)font.Size >= 0.1)
			{
				string s = "Ф";
				canvas.Graphics.DrawString(s, font, new SolidBrush(this.Color), array[4]);
			}
			font.Dispose();
			this.DrawText(canvas, eDrawMode.Print);
			pen.Dispose();
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
				return TypeSwitch.NotPhasedTool;
			}
		}

		public override bool On
		{
			get
			{
				return true;
			}
		}

		public override bool Visible
		{
			get
			{
				return !base.NormalSectionModeOn && base.Visible;
			}
			set
			{
				base.Visible = value;
			}
		}
	}
}
