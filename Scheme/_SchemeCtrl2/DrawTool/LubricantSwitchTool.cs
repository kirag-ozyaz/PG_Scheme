using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	[Serializable]
	public class LubricantSwitchTool : ObjectOnLine
	{
		public LubricantSwitchTool()
		{
		}

		public LubricantSwitchTool(Branch branch) : base(branch)
		{
		}

		public LubricantSwitchTool(DataRow dataRow_0, Branch branch) : base(dataRow_0, branch)
		{
		}

		protected override void CreateImagePoints()
		{
			base.CreateImagePoints();
			base.Points.Add(new UnitPoint(-0.2, -0.2));
			base.Points.Add(new UnitPoint(-0.2, 0.2));
			base.Points.Add(new UnitPoint(0.2, 0.2));
			base.Points.Add(new UnitPoint(0.2, -0.2));
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
					if (this.ComplexSwitchgear != null)
					{
						this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
					}
					PointF[] points = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
					canvas.Graphics.FillPolygon(solidBrush, points);
					canvas.Graphics.DrawPolygon(pen, points);
					this.DrawText(canvas, drawMode);
					base.DrawTextNormalSection(canvas);
					base.DrawDamage(canvas);
					base.DrawKey(canvas);
				}
			}
		}

		public override void ExportDXF(CanvasControl canvas, DxfDocument document)
		{
			this.ExportDXFSolid(document, new List<UnitPoint>
			{
				base.Points[0],
				base.Points[3],
				base.Points[1],
				base.Points[2]
			});
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
			document.AddEntity(new Line(new Vector3(base.Points[2].X, base.Points[2].Y, 2.0), new Vector3(base.Points[3].X, base.Points[3].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[0].X, base.Points[0].Y, 2.0), new Vector3(base.Points[3].X, base.Points[3].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			this.ExportDXFText(canvas, document);
		}

		public override void DrawPrint(CanvasControl canvas, Graphics graphics_0, bool isColor = false)
		{
			if (!this.Visible)
			{
				return;
			}
			SolidBrush solidBrush = new SolidBrush(Color.White);
			Pen pen;
			if (isColor)
			{
				if (!this.On)
				{
					if (base.IsNormalSection)
					{
						solidBrush = new SolidBrush(base.ColorOffN);
					}
					else
					{
						solidBrush = new SolidBrush(base.ColorOff);
					}
				}
				pen = new Pen(this.Color, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			}
			else
			{
				pen = new Pen(Color.White, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width));
			}
			if (this.ComplexSwitchgear != null)
			{
				this.ComplexSwitchgear.DrawPrint(canvas, graphics_0, isColor);
			}
			PointF[] points = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			canvas.Graphics.FillPolygon(solidBrush, points);
			canvas.Graphics.DrawPolygon(pen, points);
			this.DrawText(canvas, eDrawMode.Print);
			if (isColor)
			{
				base.DrawTextNormalSection(canvas);
				base.DrawDamage(canvas);
				base.DrawKey(canvas);
			}
			pen.Dispose();
			solidBrush.Dispose();
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.LubricantSwitchTool;
			}
		}
	}
}
