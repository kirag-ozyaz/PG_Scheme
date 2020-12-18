using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Xml;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class NodeTool : LabelTool
	{
		public override Color Color
		{
			get
			{
				if (this.Layer != null && base.UseSettingColor)
				{
					return this.Layer.Parent.Settings.NodeToolColor;
				}
				return base.Color;
			}
			set
			{
				base.Color = value;
			}
		}

		public NodeTool()
		{
			
			
			this.Text = "Примечание";
		}

		public NodeTool(DataRow r)
		{
			
			
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			NodeTool nodeTool = new NodeTool();
			nodeTool.Copy(this);
			return nodeTool;
		}

		private RectangleF GetRectangle()
		{
			UnitPoint unitPoint = base.Location + new UnitPoint(0.3, 0.3);
			base.Rectangle = new RectangleF((float)base.Location.X, (float)base.Location.Y, (float)(unitPoint.X - base.Location.X), (float)(unitPoint.Y - base.Location.Y));
			return base.Rectangle;
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if (this.Visible)
			{
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
							solidBrush.Color = canvas.Settings.SelectedObjColor;
						}
					}
					else if (this.Selected)
					{
						solidBrush.Color = Color.Gray;
					}
					this.GetRectangle();
					RectangleF rect = ConvertCanvas.ConvertToScreenNormalized(canvas, base.Rectangle);
					canvas.Graphics.FillEllipse(solidBrush, rect);

                    RectangleF unitrect2 = new RectangleF(base.Rectangle.X + 0.11f, base.Rectangle.Y + 0.01f, 0.08f, 0.08f);
					rect = ConvertCanvas.ConvertToScreenNormalized(canvas, unitrect2);
					canvas.Graphics.FillEllipse(new SolidBrush(canvas.Settings.BackgroundColor), rect);

                    unitrect2 = new RectangleF(base.Rectangle.X + 0.11f, base.Rectangle.Y + 0.11f, 0.08f, 0.18f);
					rect = ConvertCanvas.ConvertToScreenNormalized(canvas, unitrect2);
					canvas.Graphics.FillEllipse(new SolidBrush(canvas.Settings.BackgroundColor), rect);
				}
			}
		}

		public override RectangleF GetBoundingRect(CanvasControl canvas, bool inflate)
		{
			float num = base.ThresholdWidth(canvas, base.Width);
			RectangleF result = this.GetRectangle();
			if (inflate)
			{
				result.Inflate(num, num);
			}
			return result;
		}

		public override bool PointInObject(UnitPoint point)
		{
			if (this.Layer == null)
			{
				return false;
			}
			CanvasControl parent = this.Layer.Parent;
			float num = base.ThresholdWidth(parent, base.Width);
			parent.Graphics = Graphics.FromHwnd(parent.Handle);
			this.GetRectangle();
			UnitPoint unitPoint = new UnitPoint((double)base.Rectangle.X, (double)base.Rectangle.Y);
			UnitPoint unitPoint_ = new UnitPoint((double)(base.Rectangle.X + base.Rectangle.Width), (double)(base.Rectangle.Y + base.Rectangle.Height));
			double num2 = Math.Min(unitPoint.X, unitPoint_.X) - (double)num;
			double num3 = Math.Max(unitPoint.X, unitPoint_.X) + (double)num;
			if (point.X < num2 || point.X > num3)
			{
				return false;
			}
			double num4 = Math.Min(unitPoint.Y, unitPoint_.Y) - (double)num;
			double num5 = Math.Max(unitPoint.Y, unitPoint_.Y) + (double)num;
			if (point.Y < num4 || point.Y > num5)
			{
				return false;
			}
			if (Class79.XrgxasnnaZ(unitPoint, num, point))
			{
				return true;
			}
			if (Class79.XrgxasnnaZ(unitPoint + new UnitPoint(unitPoint_.X - unitPoint.X, 0.0), num, point))
			{
				return true;
			}
			if (Class79.XrgxasnnaZ(unitPoint + new UnitPoint(0.0, unitPoint_.Y - unitPoint.Y), num, point))
			{
				return true;
			}
			if (Class79.XrgxasnnaZ(unitPoint_, num, point))
			{
				return true;
			}
			double num6 = Math.Min(unitPoint.X, unitPoint_.X);
			double num7 = Math.Max(unitPoint.X, unitPoint_.X);
			double num8 = Math.Min(unitPoint.Y, unitPoint_.Y);
			double num9 = Math.Max(unitPoint.Y, unitPoint_.Y);
			return point.X >= num6 - (double)num && point.X <= num7 + (double)num && point.Y >= num8 - (double)num && point.Y <= num9 + (double)num;
		}

		public override string ToString()
		{
			return this.Text;
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(eTypeLabelTool.Node);
		}

		protected override void vmethod_4()
		{
			this.xmlCoords = new XmlDocument();
			this.xmlCoords.LoadXml("<Obj></Obj>");
			XmlNode currentXmlScheme = this.xmlCoords.SelectSingleNode("Obj");
			this.currentXmlScheme = currentXmlScheme;
			((XmlElement)this.currentXmlScheme).SetAttribute("X1", Math.Round(base.Location.X, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("Y1", Math.Round(base.Location.Y, 4).ToString(new CultureInfo(1033)));
			if (!base.UseSettingColor)
			{
				((XmlElement)this.currentXmlScheme).SetAttribute("Color", this.Color.ToArgb().ToString());
			}
		}
	}
}
