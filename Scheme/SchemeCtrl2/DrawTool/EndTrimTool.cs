using System;
using System.Data;
using System.Drawing;
using System.Linq;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class EndTrimTool : ObjectOnLine
	{
		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.EndTrimTool;
			}
		}

		public override bool On
		{
			get
			{
				return true;
			}
		}

		public EndTrimTool()
		{
			
			
			this.Text = "Концевая разделка";
		}

		public EndTrimTool(Branch branch)
		{
			
			base..ctor(branch);
			this.Text = "Концевая разделка";
		}

		public EndTrimTool(DataRow r, Branch branch)
		{
			
			base..ctor(r, branch);
		}

		protected override void CreateImagePoints()
		{
			base.Points.Add(new UnitPoint(0.0, -0.075));
			base.Points.Add(new UnitPoint(-0.15, 0.075));
			base.Points.Add(new UnitPoint(0.15, 0.075));
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
					PointF[] points = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
					if (this.ComplexSwitchgear != null)
					{
						this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
					}
					canvas.Graphics.DrawPolygon(pen, points);
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
			new SolidBrush(Color.Black);
			PointF[] points = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			g.DrawPolygon(pen, points);
			this.DrawText(canvas, eDrawMode.Print);
		}

		public override void vmethod_3(CanvasControl canvas, DxfDocument document)
		{
			document.AddEntity(new Line(new Vector3(base.Points[0].X, base.Points[0].Y, 2.0), new Vector3(base.Points[1].X, base.Points[1].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[1].X, base.Points[1].Y, 2.0), new Vector3(base.Points[2].X, base.Points[2].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[2].X, base.Points[2].Y, 2.0), new Vector3(base.Points[0].X, base.Points[0].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			this.ExportDXFText(canvas, document);
		}
	}
}
