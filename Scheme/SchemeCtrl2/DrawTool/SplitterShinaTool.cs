using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Xml;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.Layers;

namespace SchemeCtrl2.DrawTool
{
	public class SplitterShinaTool : ShinaTool
	{
		public SplitterShinaTool()
		{
			
			this.pointThatShouldBeLoaded = new List<int>();
			
			this.widthShina = 0f;
		}

		public override Amperage Amperage
		{
			get
			{
				if (this.parentShina != null)
				{
					return this.parentShina.Amperage;
				}
				return base.Amperage;
			}
			set
			{
			}
		}

		public override int IdBase
		{
			get
			{
				if (this.parentShina != null)
				{
					return this.parentShina.IdBase;
				}
				return 0;
			}
			set
			{
			}
		}

		public SplitterShinaTool(DrawingLayer layer, PointShinaTool src)
		{
			
			this.pointThatShouldBeLoaded = new List<int>();
			
			this.widthShina = 0f;
			if (src.Parent != null)
			{
				if (src.Parent.GetType() == typeof(ShinaTool))
				{
					PointShinaTool pointShinaTool = new PointShinaTool();
					ShinaTool shinaTool = (ShinaTool)src.Parent;
					float num = (float)Math.Sqrt(Math.Pow(shinaTool.P1.X - shinaTool.P2.X, 2.0) + Math.Pow(shinaTool.P1.Y - shinaTool.P2.Y, 2.0));
					float num2 = (num * 0.25f > 1f) ? 1f : (num * 0.25f);
					if (shinaTool.P1.X == shinaTool.P2.X)
					{
						pointShinaTool.Point = new UnitPoint(src.Point.X + (double)num2, src.Point.Y);
						base.P1 = new UnitPoint(pointShinaTool.Point.X, pointShinaTool.Point.Y - (double)(num2 / 2f));
						base.P2 = new UnitPoint(pointShinaTool.Point.X, pointShinaTool.Point.Y + (double)(num2 / 2f));
					}
					else
					{
						pointShinaTool.Point = new UnitPoint(src.Point.X, src.Point.Y - (double)num2);
						base.P1 = new UnitPoint(pointShinaTool.Point.X - (double)(num2 / 2f), pointShinaTool.Point.Y);
						base.P2 = new UnitPoint(pointShinaTool.Point.X + (double)(num2 / 2f), pointShinaTool.Point.Y);
					}
					base.AddPointShinaTool(pointShinaTool);
					layer.AddObject(this);
					this.parentShina = shinaTool;
					base.TypeShinaTool = shinaTool.TypeShinaTool;
					shinaTool.splitters.Add(this);
					this.branch = new Branch(src, pointShinaTool);
					this.branch.Parent = this;
					this.Layer.Parent.CommandEscape();
					return;
				}
			}
		}

		public SplitterShinaTool(ShinaTool par, XmlNode xml)
		{
			
			this.pointThatShouldBeLoaded = new List<int>();
			
			this.widthShina = 0f;
			PointShinaTool pointShinaTool = new PointShinaTool();
			PointShinaTool pointShinaTool2 = new PointShinaTool();
			pointShinaTool.Point = new UnitPoint((double)Convert.ToSingle(xml.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xml.Attributes[1].Value, new CultureInfo(1033)));
			pointShinaTool2.Point = new UnitPoint((double)Convert.ToSingle(xml.Attributes[2].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xml.Attributes[3].Value, new CultureInfo(1033)));
			base.P1 = new UnitPoint((double)Convert.ToSingle(xml.Attributes[4].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xml.Attributes[5].Value, new CultureInfo(1033)));
			base.P2 = new UnitPoint((double)Convert.ToSingle(xml.Attributes[6].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xml.Attributes[7].Value, new CultureInfo(1033)));
			par.AddPointShinaTool(pointShinaTool);
			base.AddPointShinaTool(pointShinaTool2);
			this.parentShina = par;
			base.TypeShinaTool = par.TypeShinaTool;
			par.splitters.Add(this);
			this.branch = new Branch(pointShinaTool, pointShinaTool2);
			this.branch.Parent = this;
			foreach (object obj in xml.SelectNodes("point"))
			{
				XmlAttribute xmlAttribute = ((XmlNode)obj).Attributes["ID"];
				if (xmlAttribute != null)
				{
					this.pointThatShouldBeLoaded.Add(Convert.ToInt32(xmlAttribute.Value));
				}
			}
		}

		public override void Remove(bool delSql, bool bool_8)
		{
			base.Remove(false, bool_8);
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			base.Draw(canvas, unitrect, drawMode);
		}

		public override bool PointInObject(UnitPoint point)
		{
			return this.Layer != null && (base.PointInObject(point) ?? this.branch.PointInObject(point));
		}

		public override void SaveXmlToSql()
		{
			this.parentShina.SaveXmlToSql();
		}

		public void GetXml(XmlElement xmlElement)
		{
			xmlElement.SetAttribute("pstX1", Math.Round(this.branch.Source.Point.X, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("pstY1", Math.Round(this.branch.Source.Point.Y, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("pstX2", Math.Round(this.branch.Destination.Point.X, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("pstY2", Math.Round(this.branch.Destination.Point.Y, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("X1", Math.Round(base.P1.X, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("Y1", Math.Round(base.P1.Y, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("X2", Math.Round(base.P2.X, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("Y2", Math.Round(base.P2.Y, 4).ToString(new CultureInfo(1033)));
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(PointShinaTool) && ((PointShinaTool)drawObjectBase).CouplingRelations.Count > 0 && ((PointShinaTool)drawObjectBase).Branches.First<Branch>().Parent.GetType() == typeof(LineCellTool))
				{
					XmlElement xmlElement2 = xmlElement.OwnerDocument.CreateElement("point");
					xmlElement2.SetAttribute("ID", drawObjectBase.IdBase.ToString());
					xmlElement.AppendChild(xmlElement2);
				}
			}
		}

		public Branch branch;

		public ShinaTool parentShina;

		public List<int> pointThatShouldBeLoaded;
	}
}
