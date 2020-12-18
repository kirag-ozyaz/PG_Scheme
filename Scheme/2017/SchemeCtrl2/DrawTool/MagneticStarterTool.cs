using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Xml;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class MagneticStarterTool : ObjectOnLine
	{
		public MagneticStarterTool()
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.Text = "МП";
		}

		public MagneticStarterTool(Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(branch);
			this.Text = "МП";
		}

		public MagneticStarterTool(DataRow r, Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(r, branch);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)r["SchemaXml"]);
			XmlAttribute xmlAttribute = (XmlAttribute)xmlDocument.SelectSingleNode("/Obj").Attributes.GetNamedItem("phaseFlags");
			if (xmlAttribute != null)
			{
				this.byte_0 = Convert.ToByte(xmlAttribute.Value);
			}
		}

		public bool Boolean_0
		{
			get
			{
				return (this.byte_0 & 4) == 4;
			}
			set
			{
				if (value)
				{
					this.byte_0 |= 4;
					return;
				}
				this.byte_0 &= 3;
			}
		}

		public bool Boolean_1
		{
			get
			{
				return (this.byte_0 & 2) == 2;
			}
			set
			{
				if (value)
				{
					this.byte_0 |= 2;
					return;
				}
				this.byte_0 &= 5;
			}
		}

		public bool Boolean_2
		{
			get
			{
				return (this.byte_0 & 1) == 1;
			}
			set
			{
				if (value)
				{
					this.byte_0 |= 1;
					return;
				}
				this.byte_0 &= 6;
			}
		}

		protected override void vmethod_4()
		{
			base.vmethod_4();
			((XmlElement)this.currentXmlScheme).SetAttribute("phaseFlags", this.byte_0.ToString(new CultureInfo(1033)));
		}

		protected override void CreateImagePoints()
		{
			base.CreateImagePoints();
			base.Points.Add(new UnitPoint(-0.15, 0.25));
			base.Points.Add(new UnitPoint(-0.1, -0.15));
			base.Points.Add(new UnitPoint(-0.1, -0.3));
			base.Points.Add(new UnitPoint(-0.05, 0.25));
			base.Points.Add(new UnitPoint(0.0, -0.15));
			base.Points.Add(new UnitPoint(0.0, -0.3));
			base.Points.Add(new UnitPoint(0.05, 0.25));
			base.Points.Add(new UnitPoint(0.1, -0.15));
			base.Points.Add(new UnitPoint(0.1, -0.3));
			base.Points.Add(new UnitPoint(-0.15, -0.3));
			base.Points.Add(new UnitPoint(0.1, 0.25));
			base.Points.Add(new UnitPoint(-0.13, 0.125));
			base.Points.Add(new UnitPoint(0.07, 0.125));
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
					PointF[] points = new PointF[]
					{
						array[0],
						array[9],
						array[8],
						array[10]
					};
					if (this.ComplexSwitchgear != null)
					{
						this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
					}
					if (!this.On)
					{
						if (base.IsNormalSection)
						{
							canvas.Graphics.FillPolygon(solidBrush, points);
						}
						else
						{
							canvas.Graphics.FillPolygon(solidBrush, points);
						}
						if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
						{
							pen.Width += 2f;
						}
					}
					else
					{
						canvas.Graphics.FillPolygon(solidBrush, points);
					}
					canvas.Graphics.DrawLine(pen, array[0], array[1]);
					canvas.Graphics.DrawLine(pen, array[1], array[2]);
					if (this.Boolean_0)
					{
						canvas.Graphics.FillEllipse(new SolidBrush(pen.Color), new RectangleF(array[2].X - 2f, array[2].Y - 2f, 5f, 5f));
					}
					canvas.Graphics.DrawLine(pen, array[3], array[4]);
					canvas.Graphics.DrawLine(pen, array[4], array[5]);
					if (this.Boolean_1)
					{
						canvas.Graphics.FillEllipse(new SolidBrush(pen.Color), new RectangleF(array[5].X - 2f, array[5].Y - 2f, 5f, 5f));
					}
					canvas.Graphics.DrawLine(pen, array[6], array[7]);
					canvas.Graphics.DrawLine(pen, array[7], array[8]);
					if (this.Boolean_2)
					{
						canvas.Graphics.FillEllipse(new SolidBrush(pen.Color), new RectangleF(array[8].X - 2f, array[8].Y - 2f, 5f, 5f));
					}
					canvas.Graphics.DrawLine(pen, array[11], array[12]);
					this.DrawText(canvas, drawMode);
					base.DrawTextNormalSection(canvas);
					base.DrawDamage(canvas);
					base.DrawKey(canvas);
				}
			}
		}

		public override void vmethod_3(CanvasControl canvas, DxfDocument document)
		{
			this.ExportDXFSolid(document, base.Points);
			document.AddEntity(new Line(new Vector3(base.Points[0].X, base.Points[0].Y, 2.0), new Vector3(base.Points[1].X, base.Points[1].Y, 3.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[2].X, base.Points[2].Y, 3.0), new Vector3(base.Points[3].X, base.Points[3].Y, 3.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			this.ExportDXFText(canvas, document);
		}

		public override TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.MagneticStarterTool;
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
				base.Points[6],
				base.Points[8],
				base.Points[2]
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

		private byte byte_0;
	}
}
