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
	public class DamageTool : ObjectOnLine
	{
		public DamageTool()
		{
			
			
			this.Text = "Повреждено";
		}

		public DamageTool(Branch branch)
		{
			
			base..ctor(branch);
			this.Text = "Повреждено";
		}

		public DamageTool(DataRow r, Branch branch)
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
				if (!this.Layer.Parent.Settings.DamageToolColorLine || this.Parent == null || this.Parent.GetType() != typeof(Branch))
				{
					return this.Layer.Parent.Settings.DamageToolColor;
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
			base.Points.Add(new UnitPoint(0.2, 0.2));
			base.Points.Add(new UnitPoint(-0.1, -0.05));
			base.Points.Add(new UnitPoint(0.15, 0.1));
			base.Points.Add(new UnitPoint(-0.2, -0.2));
			base.Points.Add(new UnitPoint(-0.15, -0.05));
			base.Points.Add(new UnitPoint(-0.05, -0.15));
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
					canvas.Graphics.DrawLine(pen, array[5], array[6]);
					canvas.Graphics.DrawLine(pen, array[6], array[7]);
					canvas.Graphics.DrawLine(pen, array[7], array[8]);
					canvas.Graphics.DrawLine(pen, array[7], array[9]);
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
			SolidBrush brush = new SolidBrush(Color.Black);
			PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			PointF[] points = new PointF[]
			{
				array[0],
				array[1],
				array[2],
				array[3]
			};
			g.FillPolygon(brush, points);
			g.DrawPolygon(pen, points);
			g.DrawLine(pen, array[4], array[5]);
			g.DrawLine(pen, array[5], array[6]);
			g.DrawLine(pen, array[6], array[7]);
			g.DrawLine(pen, array[7], array[8]);
			g.DrawLine(pen, array[7], array[9]);
			this.DrawText(canvas, eDrawMode.Print);
		}

		public override void vmethod_3(CanvasControl canvas, DxfDocument document)
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
			document.AddEntity(new Line(new Vector3(base.Points[4].X, base.Points[4].Y, 2.0), new Vector3(base.Points[5].X, base.Points[5].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[5].X, base.Points[5].Y, 2.0), new Vector3(base.Points[6].X, base.Points[6].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[6].X, base.Points[6].Y, 2.0), new Vector3(base.Points[7].X, base.Points[7].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[7].X, base.Points[7].Y, 2.0), new Vector3(base.Points[8].X, base.Points[8].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[7].X, base.Points[7].Y, 2.0), new Vector3(base.Points[9].X, base.Points[9].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			this.ExportDXFText(canvas, document);
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
				return TypeSwitch.DamageTool;
			}
		}

		public override bool On
		{
			get
			{
				return base.NormalSectionModeOn;
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
	}
}
