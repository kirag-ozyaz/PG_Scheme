using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool.FormsObj;

namespace SchemeCtrl2.DrawTool
{
	public class AmperageTransformerTool : ObjectOnLine
	{
		public AmperageTransformerTool()
		{
			
			
			this.Text = "Тт";
		}

		public AmperageTransformerTool(Branch branch)
		{
			
			base..ctor(branch);
			this.Text = "Тт";
		}

		public AmperageTransformerTool(DataRow r, Branch branch)
		{
			
			base..ctor(r, branch);
		}

		public override bool On
		{
			get
			{
				return true;
			}
		}

		public override bool ShowPropertyForm(Point location)
		{
			if (this.IdBase != 0)
			{
				return base.ShowPropertyForm(location);
			}
			RectangleTool rectangleTool = null;
			if (this.Parent != null && this.Parent.Parent != null && this.Parent.Parent.Parent != null && this.Parent.Parent.Parent is RectangleTool)
			{
				rectangleTool = (RectangleTool)this.Parent.Parent.Parent;
			}
			TransformerToolPropertyForm transformerToolPropertyForm;
			if (rectangleTool == null)
			{
				transformerToolPropertyForm = new TransformerToolPropertyForm(this, this.Layer.Parent.SqlSettings);
			}
			else
			{
				transformerToolPropertyForm = new TransformerToolPropertyForm(rectangleTool.IdBase, this, this.Layer.Parent.SqlSettings);
			}
			transformerToolPropertyForm.Location = location;
			if (transformerToolPropertyForm.ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
				return true;
			}
			return false;
		}

		protected override void CreateImagePoints()
		{
			base.Points.Add(new UnitPoint(0.31, -0.3));
			base.Points.Add(new UnitPoint(0.31, 0.3));
			base.Points.Add(new UnitPoint(0.37, 0.2));
			base.Points.Add(new UnitPoint(0.03, 0.2));
			base.Points.Add(new UnitPoint(0.03, 0.0));
			base.Points.Add(new UnitPoint(0.31, 0.0));
			base.Points.Add(new UnitPoint(0.03, -0.2));
			base.Points.Add(new UnitPoint(0.37, -0.2));
			this.systemChanging = true;
			this.CenterPoint = new UnitPoint(0.0, 0.0);
			this.systemChanging = false;
		}

		protected override RectangleF GetRectangleText(CanvasControl canvas)
		{
			RectangleF empty = RectangleF.Empty;
			if (!this.TextProperty.Visible)
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
				RectangleF rectangleF = new RectangleF(num - 0.1f, num3 - 0.1f, num2 - num + 0.2f, num4 - num3 + 0.2f);
				Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style);
				SizeF sizeF = canvas.Graphics.MeasureString(this.Text, font);
				font.Dispose();
				SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
				empty = new RectangleF(rectangleF.Location, size);
				switch (this.TextProperty.Position)
				{
				case ePositionText.LT:
					empty.X = rectangleF.Location.X - empty.Width;
					empty.Y = rectangleF.Location.Y + rectangleF.Height;
					break;
				case ePositionText.T:
					empty.X = rectangleF.Location.X + rectangleF.Width / 2f - empty.Width / 2f;
					empty.Y = rectangleF.Location.Y + rectangleF.Height;
					break;
				case ePositionText.RT:
					empty.X = rectangleF.Location.X + rectangleF.Width;
					empty.Y = rectangleF.Location.Y + rectangleF.Height;
					break;
				case ePositionText.R:
					empty.X = rectangleF.Location.X + rectangleF.Width;
					empty.Y = rectangleF.Location.Y + rectangleF.Height / 2f - empty.Height / 2f;
					break;
				case ePositionText.RB:
					empty.X = rectangleF.Location.X + rectangleF.Width;
					empty.Y = rectangleF.Location.Y - empty.Height;
					break;
				case ePositionText.B:
					empty.X = rectangleF.Location.X + rectangleF.Width / 2f - empty.Width / 2f;
					empty.Y = rectangleF.Location.Y - empty.Height;
					break;
				case ePositionText.LB:
					empty.X = rectangleF.Location.X - empty.Width;
					empty.Y = rectangleF.Location.Y - empty.Height;
					break;
				case ePositionText.L:
					empty.X = rectangleF.Location.X - empty.Width;
					empty.Y = rectangleF.Location.Y + rectangleF.Height / 2f - empty.Height / 2f;
					break;
				}
				return empty;
			}
			return empty;
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
				if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
				{
					if ((drawMode & eDrawMode.Color) != eDrawMode.Color)
					{
						pen.Color = Color.Black;
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
				canvas.Graphics.DrawLine(pen, array[0], array[1]);
				canvas.Graphics.DrawBezier(pen, array[2], array[3], array[4], array[5]);
				canvas.Graphics.DrawBezier(pen, array[5], array[4], array[6], array[7]);
				this.DrawText(canvas, drawMode);
				base.DrawDamage(canvas);
				base.DrawKey(canvas);
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			Pen pen = new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			new SolidBrush(Color.White);
			PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			if (this.ComplexSwitchgear != null)
			{
				this.ComplexSwitchgear.DrawPrint(canvas, g, false);
			}
			canvas.Graphics.DrawLine(pen, array[0], array[1]);
			canvas.Graphics.DrawBezier(pen, array[2], array[3], array[4], array[5]);
			canvas.Graphics.DrawBezier(pen, array[5], array[4], array[6], array[7]);
			this.DrawText(canvas, eDrawMode.Print);
		}

		public override bool PointInObject(UnitPoint point)
		{
			return this.Layer != null && Class79.smethod_8(point, base.Points.ToArray());
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.AmperageTransformer;
			}
		}
	}
}
