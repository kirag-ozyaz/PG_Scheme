using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.Layers;

namespace SchemeCtrl2.DrawTool
{
	public class GroundingTool : ObjectOnLine
	{
		public event GroundingTool.PortEventHandle PortEvent
		{
			[CompilerGenerated]
			add
			{
				GroundingTool.PortEventHandle portEventHandle = this.portEventHandle_0;
				GroundingTool.PortEventHandle portEventHandle2;
				do
				{
					portEventHandle2 = portEventHandle;
					GroundingTool.PortEventHandle value2 = (GroundingTool.PortEventHandle)Delegate.Combine(portEventHandle2, value);
					portEventHandle = Interlocked.CompareExchange<GroundingTool.PortEventHandle>(ref this.portEventHandle_0, value2, portEventHandle2);
				}
				while (portEventHandle != portEventHandle2);
			}
			[CompilerGenerated]
			remove
			{
				GroundingTool.PortEventHandle portEventHandle = this.portEventHandle_0;
				GroundingTool.PortEventHandle portEventHandle2;
				do
				{
					portEventHandle2 = portEventHandle;
					GroundingTool.PortEventHandle value2 = (GroundingTool.PortEventHandle)Delegate.Remove(portEventHandle2, value);
					portEventHandle = Interlocked.CompareExchange<GroundingTool.PortEventHandle>(ref this.portEventHandle_0, value2, portEventHandle2);
				}
				while (portEventHandle != portEventHandle2);
			}
		}

		public event GroundingTool.PortEventHandle RemovePortEvent
		{
			[CompilerGenerated]
			add
			{
				GroundingTool.PortEventHandle portEventHandle = this.portEventHandle_1;
				GroundingTool.PortEventHandle portEventHandle2;
				do
				{
					portEventHandle2 = portEventHandle;
					GroundingTool.PortEventHandle value2 = (GroundingTool.PortEventHandle)Delegate.Combine(portEventHandle2, value);
					portEventHandle = Interlocked.CompareExchange<GroundingTool.PortEventHandle>(ref this.portEventHandle_1, value2, portEventHandle2);
				}
				while (portEventHandle != portEventHandle2);
			}
			[CompilerGenerated]
			remove
			{
				GroundingTool.PortEventHandle portEventHandle = this.portEventHandle_1;
				GroundingTool.PortEventHandle portEventHandle2;
				do
				{
					portEventHandle2 = portEventHandle;
					GroundingTool.PortEventHandle value2 = (GroundingTool.PortEventHandle)Delegate.Remove(portEventHandle2, value);
					portEventHandle = Interlocked.CompareExchange<GroundingTool.PortEventHandle>(ref this.portEventHandle_1, value2, portEventHandle2);
				}
				while (portEventHandle != portEventHandle2);
			}
		}

		public override Color Color
		{
			get
			{
				if (this.Layer == null || !base.UseSettingColor)
				{
					return base.Color;
				}
				if (!this.Layer.Parent.Settings.GroundingToolColorLine || this.Parent == null || this.Parent.GetType() != typeof(Branch))
				{
					return this.Layer.Parent.Settings.GroundingToolColor;
				}
				Branch branch = (Branch)this.Parent;
				if (branch.CheckVoltageInPoint(this.CenterPoint))
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

		public GroundingTool()
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.Text = "Заземление";
		}

		public GroundingTool(Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(branch);
			this.Text = "Заземление";
			if (branch.CouplingRelation.amperagePoint != null)
			{
				this.On = false;
			}
		}

		public GroundingTool(DataRow r, Branch branch)
		{
			Class90.TDroV38zslI2T();
			base..ctor(r, branch);
		}

		protected override void CreateImagePoints()
		{
			base.Points.Add(new UnitPoint(0.0, 0.25));
			base.Points.Add(new UnitPoint(0.1, 0.25));
			base.Points.Add(new UnitPoint(0.1, 0.35));
			base.Points.Add(new UnitPoint(0.3, 0.25));
			base.Points.Add(new UnitPoint(0.5, 0.25));
			base.Points.Add(new UnitPoint(0.5, 0.0));
			base.Points.Add(new UnitPoint(0.5, 0.5));
			base.Points.Add(new UnitPoint(0.6, 0.1));
			base.Points.Add(new UnitPoint(0.6, 0.4));
			base.Points.Add(new UnitPoint(0.7, 0.2));
			base.Points.Add(new UnitPoint(0.7, 0.3));
			base.Points.Add(new UnitPoint(0.0, 0.0));
			base.Points.Add(new UnitPoint(0.0, 0.5));
			base.Points.Add(new UnitPoint(0.7, 0.5));
			base.Points.Add(new UnitPoint(0.7, 0.0));
			this.systemChanging = true;
			UnitPoint centerPoint = new UnitPoint(base.Points[0].Point);
			this.CenterPoint = centerPoint;
			this.systemChanging = false;
			this.PortEvent += this.method_14;
			this.RemovePortEvent += this.method_13;
		}

		private void method_13(GroundingTool groundingTool_0)
		{
		}

		private void method_14(GroundingTool groundingTool_0)
		{
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
					SolidBrush solidBrush2 = new SolidBrush(this.Color);
					if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
					{
						if ((drawMode & eDrawMode.Color) != eDrawMode.Color)
						{
							pen.Color = Color.Black;
							solidBrush2 = new SolidBrush(Color.Black);
							solidBrush.Color = Color.White;
						}
					}
					else if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
					{
						if (this.Selected)
						{
							pen.Color = this.SelectedColor;
							solidBrush2 = new SolidBrush(this.SelectedColor);
						}
						else if (base.Bookmark != null)
						{
							pen.Color = canvas.Settings.MarkedObjColor;
							solidBrush2 = new SolidBrush(canvas.Settings.MarkedObjColor);
						}
						else if (this.bool_15)
						{
							pen.Color = Color.DeepPink;
							solidBrush2 = new SolidBrush(Color.DeepPink);
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
							solidBrush2 = new SolidBrush(Color.Gray);
						}
						else if (base.Bookmark != null)
						{
							pen.Color = Color.LightGray;
							solidBrush2 = new SolidBrush(Color.LightGray);
						}
						if (this.Flashing && canvas.ConvertColorFlash)
						{
							pen.Color = Color.White;
							solidBrush2 = new SolidBrush(Color.White);
						}
					}
					RectangleF rectangleF = new RectangleF(new PointF(base.Points[0].Point.X - 0.05f, base.Points[0].Point.Y - 0.05f), new SizeF(0.1f, -0.1f));
					rectangleF = ConvertCanvas.ConvertToScreen(canvas, rectangleF);
					PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
					if (this.ComplexSwitchgear != null)
					{
						this.ComplexSwitchgear.Draw(canvas, unitrect, drawMode);
					}
					if (!this.On)
					{
						PointF[] points = new PointF[]
						{
							array[11],
							array[12],
							array[13],
							array[14]
						};
						canvas.Graphics.FillPolygon(solidBrush, points);
						if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
						{
							pen.Width += 2f;
						}
					}
					canvas.Graphics.FillEllipse(solidBrush2, rectangleF);
					canvas.Graphics.DrawLine(pen, array[0], array[1]);
					canvas.Graphics.DrawLine(pen, array[2], array[3]);
					canvas.Graphics.DrawLine(pen, array[3], array[4]);
					canvas.Graphics.DrawLine(pen, array[5], array[6]);
					canvas.Graphics.DrawLine(pen, array[7], array[8]);
					canvas.Graphics.DrawLine(pen, array[9], array[10]);
					this.DrawText(canvas, drawMode);
					base.DrawTextNormalSection(canvas);
					base.DrawDamage(canvas);
					base.DrawKey(canvas);
					solidBrush2.Dispose();
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
			RectangleF rectangleF = new RectangleF(new PointF(base.Points[0].Point.X - 0.05f, base.Points[0].Point.Y - 0.05f), new SizeF(0.1f, -0.1f));
			rectangleF = ConvertCanvas.ConvertToScreen(canvas, rectangleF);
			PointF[] array = ConvertCanvas.ConvertToScreen(canvas, base.Points.ToArray<UnitPoint>());
			canvas.Graphics.FillEllipse(brush, rectangleF);
			canvas.Graphics.DrawLine(pen, array[0], array[1]);
			canvas.Graphics.DrawLine(pen, array[2], array[3]);
			canvas.Graphics.DrawLine(pen, array[3], array[4]);
			canvas.Graphics.DrawLine(pen, array[5], array[6]);
			canvas.Graphics.DrawLine(pen, array[7], array[8]);
			canvas.Graphics.DrawLine(pen, array[9], array[10]);
			this.DrawText(canvas, eDrawMode.Print);
		}

		public override void vmethod_3(CanvasControl canvas, DxfDocument document)
		{
			Circle circle = new Circle(new Vector3(base.Points[0].X, base.Points[0].Y, 2.0), 0.05000000074505806);
			List<HatchBoundaryPath> list = new List<HatchBoundaryPath>
			{
				new HatchBoundaryPath(new List<IEntityObject>
				{
					circle
				})
			};
			Hatch hatch = new Hatch(HatchPattern.Solid, list);
			hatch.Color = new AciColor(this.Color);
			hatch.Layer = new Layer("Switches");
			circle.Layer = new Layer("Switches");
			circle.Color = new AciColor(this.Color);
			document.AddEntity(circle);
			document.AddEntity(hatch);
			document.AddEntity(new Line(new Vector3(base.Points[0].X, base.Points[0].Y, 2.0), new Vector3(base.Points[1].X, base.Points[1].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[2].X, base.Points[2].Y, 2.0), new Vector3(base.Points[3].X, base.Points[3].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[3].X, base.Points[3].Y, 2.0), new Vector3(base.Points[4].X, base.Points[4].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[5].X, base.Points[5].Y, 2.0), new Vector3(base.Points[6].X, base.Points[6].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[7].X, base.Points[7].Y, 2.0), new Vector3(base.Points[8].X, base.Points[8].Y, 2.0))
			{
				Color = new AciColor(this.Color),
				Layer = new Layer("Switches")
			});
			document.AddEntity(new Line(new Vector3(base.Points[9].X, base.Points[9].Y, 2.0), new Vector3(base.Points[10].X, base.Points[10].Y, 2.0))
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
				if (base.MappingState)
				{
					return TypeSwitch.GroundingStateTool;
				}
				return TypeSwitch.GroundingTool;
			}
		}

		public override bool Visible
		{
			get
			{
				return (!base.MappingState || !base.NormalSectionModeOn) && base.Visible;
			}
			set
			{
				base.Visible = value;
			}
		}

		public override bool On
		{
			get
			{
				return base.MappingState || (!base.NormalSectionModeOn && base.On);
			}
			set
			{
				if (value && this.Parent != null && ((Branch)this.Parent).CheckVoltageInPoint(this.CenterPoint))
				{
					this.Layer.Parent.SendMessage("На данном участке нельзя включить заземление, он под напряжением", eMessageType.Warning);
					return;
				}
				base.On = value;
			}
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			DrawObjectBase drawObjectBase = base.Clone(SaveParentRelation);
			((GroundingTool)drawObjectBase).bool_15 = this.bool_15;
			return drawObjectBase;
		}

		public override DrawingLayer Layer
		{
			get
			{
				return base.Layer;
			}
			set
			{
				if (this.bool_15)
				{
					if (value == null)
					{
						this.portEventHandle_1(this);
					}
					else
					{
						this.portEventHandle_0(this);
					}
				}
				base.Layer = value;
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
				base.Points[2],
				base.Points[5],
				base.Points[7],
				base.Points[9],
				base.Points[10],
				base.Points[8],
				base.Points[6]
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

		[CompilerGenerated]
		private GroundingTool.PortEventHandle portEventHandle_0;

		[CompilerGenerated]
		private GroundingTool.PortEventHandle portEventHandle_1;

		private bool bool_15;

		public delegate void PortEventHandle(GroundingTool sender);
	}
}
