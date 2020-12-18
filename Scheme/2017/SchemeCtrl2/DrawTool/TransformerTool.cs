using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool.FormsObj;

namespace SchemeCtrl2.DrawTool
{
	public class TransformerTool : ObjectOnLine
	{
		public TransformerTool()
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.Text = "Т";
		}

		public TransformerTool(Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(branch);
			this.Text = "Т";
		}

		public TransformerTool(DataRow r, Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(r, branch);
		}

		public override bool On
		{
			get
			{
				return true;
			}
		}

		public override void EndDraw()
		{
			PointF pointF = ConvertCanvas.ConvertToScreen(this.Layer.Parent, this.CenterPoint);
			if (this.Layer == null || this.Layer.Parent == null)
			{
				this.ShowPropertyForm(this.Layer.Parent.PointToScreen(new Point((int)pointF.X, (int)pointF.Y)));
				return;
			}
			Point location = this.Layer.Parent.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
			RectangleTool rectangleTool = null;
			if (this.Parent != null && this.Parent.Parent != null)
			{
				rectangleTool = (RectangleTool)((LineTool)this.Parent.Parent).ParRectangle();
			}
			if (rectangleTool == null && this.Parent.Parent.GetType() == typeof(LineTool) && this.Parent.Parent.Layer != null && this.Parent.Parent.Layer.Parent != null && this.Parent.Parent.Layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
			{
				foreach (PointTool pointTool in ((LineTool)this.Parent.Parent).Ends)
				{
					if (pointTool.Parent != null && pointTool.Parent.GetType() == typeof(LineCellTool) && pointTool.Parent.Parent != null)
					{
						rectangleTool = (RectangleTool)pointTool.Parent.Parent;
						break;
					}
				}
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
				return;
			}
			bool delSql = this.Layer != null && this.Layer.Parent != null && this.Layer.Parent.UseObjectFromDB;
			this.Remove(delSql, true);
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
			base.Points.Add(new UnitPoint(0.0, -0.15));
			base.Points.Add(new UnitPoint(0.0, 0.15));
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
				RectangleF rectangleF = new RectangleF(num - 0.2f, num3 - 0.2f, num2 - num + 0.4f, num4 - num3 + 0.4f);
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

		protected RectangleF GetRectangleText(CanvasControl canvas, string customText)
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
				RectangleF rectangleF = new RectangleF(num - 0.2f, num3 - 0.2f, num2 - num + 0.4f, num4 - num3 + 0.4f);
				Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style);
				SizeF sizeF = canvas.Graphics.MeasureString(customText, font);
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
					RectangleF rectangleF = new RectangleF(new PointF(base.Points[0].Point.X - 0.2f, base.Points[0].Point.Y - 0.2f), new SizeF(0.4f, -0.4f));
					RectangleF rectangleF2 = new RectangleF(new PointF(base.Points[1].Point.X - 0.2f, base.Points[1].Point.Y - 0.2f), new SizeF(0.4f, -0.4f));
					rectangleF = ConvertCanvas.ConvertToScreen(canvas, rectangleF);
					rectangleF2 = ConvertCanvas.ConvertToScreen(canvas, rectangleF2);
					if (this.ComplexSwitchgear != null)
					{
						this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
					}
					canvas.Graphics.FillEllipse(solidBrush, rectangleF);
					canvas.Graphics.FillEllipse(solidBrush, rectangleF2);
					canvas.Graphics.DrawEllipse(pen, rectangleF);
					canvas.Graphics.DrawEllipse(pen, rectangleF2);
					this.DrawText(canvas, drawMode);
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
			Pen pen = new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			SolidBrush brush = new SolidBrush(Color.White);
			ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			RectangleF rectangleF = new RectangleF(new PointF(base.Points[0].Point.X - 0.2f, base.Points[0].Point.Y - 0.2f), new SizeF(0.4f, -0.4f));
			RectangleF rectangleF2 = new RectangleF(new PointF(base.Points[1].Point.X - 0.2f, base.Points[1].Point.Y - 0.2f), new SizeF(0.4f, -0.4f));
			rectangleF = ConvertCanvas.ConvertToScreen(canvas, rectangleF);
			rectangleF2 = ConvertCanvas.ConvertToScreen(canvas, rectangleF2);
			g.FillEllipse(brush, rectangleF);
			g.FillEllipse(brush, rectangleF2);
			g.DrawEllipse(pen, rectangleF);
			g.DrawEllipse(pen, rectangleF2);
			this.DrawText(canvas, eDrawMode.Print);
		}

		protected override void DrawText(CanvasControl canvas, eDrawMode drawMode = eDrawMode.Color)
		{
			if (this.Visible && this.TextProperty.Visible)
			{
				string text = this.Text;
				if (this.passportDataRow != null)
				{
					foreach (PropertyFromBaseElement propertyFromBaseElement in canvas.Settings.TransformerPassportProperty)
					{
						if (Convert.ToBoolean(propertyFromBaseElement.Value))
						{
							text = text + "\r\n" + this.passportDataRow[propertyFromBaseElement.Name];
						}
					}
				}
				if (base.UseSettingsText && this.TextProperty.FontSize * canvas.Zoom <= canvas.Settings.FontSizeNoVisible)
				{
					return;
				}
				using (Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style))
				{
					RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetRectangleText(canvas, text));
					GraphicsState gstate = canvas.Graphics.Save();
					if (this.TextProperty.FontVirtical)
					{
						Matrix transform = canvas.Graphics.Transform;
						rectangleF.Y += rectangleF.Height;
						transform.RotateAt(-90f, rectangleF.Location, MatrixOrder.Append);
						canvas.Graphics.Transform = transform;
					}
					if (rectangleF.Size.Width > 0f && rectangleF.Size.Height > 0f)
					{
						using (SolidBrush solidBrush = new SolidBrush(this.TextProperty.Color))
						{
							if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
							{
								if ((drawMode & eDrawMode.Color) != eDrawMode.Color)
								{
									solidBrush.Color = Color.Black;
								}
								else if (canvas.Settings.BackgroundColor.ToArgb() == solidBrush.Color.ToArgb() && solidBrush.Color.ToArgb() == Color.White.ToArgb())
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
							}
							else if (this.Selected)
							{
								solidBrush.Color = Color.Gray;
							}
							canvas.Graphics.DrawString(text, font, solidBrush, rectangleF.Location);
						}
					}
					canvas.Graphics.Restore(gstate);
				}
			}
		}

		public override void vmethod_3(CanvasControl canvas, DxfDocument document)
		{
			Circle circle = new Circle(new Vector3(base.Points[0].X, base.Points[0].Y, 2.0), 0.20000000298023224);
			List<HatchBoundaryPath> list = new List<HatchBoundaryPath>
			{
				new HatchBoundaryPath(new List<IEntityObject>
				{
					circle
				})
			};
			Hatch hatch = new Hatch(HatchPattern.Solid, list);
			hatch.Color.Index = 256;
			hatch.Layer = new Layer("Switches");
			circle.Layer = new Layer("Switches");
			circle.Color = new AciColor(this.Color);
			document.AddEntity(circle);
			document.AddEntity(hatch);
			circle = new Circle(new Vector3(base.Points[1].X, base.Points[1].Y, 2.0), 0.20000000298023224);
			list = new List<HatchBoundaryPath>
			{
				new HatchBoundaryPath(new List<IEntityObject>
				{
					circle
				})
			};
			hatch = new Hatch(HatchPattern.Solid, list);
			hatch.Color.Index = 256;
			circle.Color = new AciColor(this.Color);
			hatch.Layer = new Layer("Switches");
			circle.Layer = new Layer("Switches");
			document.AddEntity(circle);
			document.AddEntity(hatch);
			this.ExportDXFText(canvas, document);
		}

		public override bool PointInObject(UnitPoint point)
		{
			return this.Layer != null && (Class79.XrgxasnnaZ(base.Points[0], 0.2f, point) || Class79.XrgxasnnaZ(base.Points[1], 0.2f, point));
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.TransformerTool;
			}
		}

		public DataRow passportDataRow;
	}
}
