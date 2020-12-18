using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using DXFLibrary;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool.FormsObj;
using SchemeCtrl2.Layers;
using SchemeCtrl2.SnapPoint;

namespace SchemeCtrl2.DrawTool
{
	[Serializable]
	public class ShinaTool : DrawObjectBase
	{
		public event DrawObjectBaseEventHandler AmperageChanged
		{
			[CompilerGenerated]
			add
			{
				DrawObjectBaseEventHandler drawObjectBaseEventHandler = this.drawObjectBaseEventHandler_4;
				DrawObjectBaseEventHandler drawObjectBaseEventHandler2;
				do
				{
					drawObjectBaseEventHandler2 = drawObjectBaseEventHandler;
					DrawObjectBaseEventHandler value2 = (DrawObjectBaseEventHandler)Delegate.Combine(drawObjectBaseEventHandler2, value);
					drawObjectBaseEventHandler = Interlocked.CompareExchange<DrawObjectBaseEventHandler>(ref this.drawObjectBaseEventHandler_4, value2, drawObjectBaseEventHandler2);
				}
				while (drawObjectBaseEventHandler != drawObjectBaseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectBaseEventHandler drawObjectBaseEventHandler = this.drawObjectBaseEventHandler_4;
				DrawObjectBaseEventHandler drawObjectBaseEventHandler2;
				do
				{
					drawObjectBaseEventHandler2 = drawObjectBaseEventHandler;
					DrawObjectBaseEventHandler value2 = (DrawObjectBaseEventHandler)Delegate.Remove(drawObjectBaseEventHandler2, value);
					drawObjectBaseEventHandler = Interlocked.CompareExchange<DrawObjectBaseEventHandler>(ref this.drawObjectBaseEventHandler_4, value2, drawObjectBaseEventHandler2);
				}
				while (drawObjectBaseEventHandler != drawObjectBaseEventHandler2);
			}
		}

		public bool OnAmperage
		{
			get
			{
				return ((RectangleTool)this.Parent).TypeRectnagleTool == eTypeRectangleTool.CP && this.bool_7;
			}
			set
			{
				if (((RectangleTool)this.Parent).TypeRectnagleTool == eTypeRectangleTool.CP && this.bool_7 != value)
				{
					this.bool_7 = value;
					if (!this.bool_7)
					{
						this.amperage_0.method_4();
						return;
					}
					AmperageProperties amperageProperties = new AmperageProperties();
					amperageProperties.power = 0;
					amperageProperties.amperage = 0;
					eTypeShinaTool eTypeShinaTool = this.eTypeShinaTool_0;
					if (eTypeShinaTool != eTypeShinaTool.Shina_6)
					{
						if (eTypeShinaTool == eTypeShinaTool.Shina_10)
						{
							amperageProperties.voltage = 10;
						}
					}
					else
					{
						amperageProperties.voltage = 6;
					}
					this.amperage_0 = new Amperage(this, this, amperageProperties, null);
					this.vmethod_1();
				}
			}
		}

		public virtual Amperage Amperage
		{
			get
			{
				if (this.Parent == null || !(this.Parent is RectangleTool) || ((RectangleTool)this.Parent).TypeRectnagleTool != eTypeRectangleTool.CP)
				{
					return this.amperage_0;
				}
				if (this.bool_7)
				{
					return this.amperage_0;
				}
				return null;
			}
			set
			{
				if (this.Parent != null)
				{
					if (((RectangleTool)this.Parent).TypeRectnagleTool != eTypeRectangleTool.CP)
					{
						this.amperage_0 = value;
						if (this.amperage_0 != null)
						{
							this.vmethod_1();
						}
					}
					else if (((RectangleTool)this.Parent).TypeRectnagleTool == eTypeRectangleTool.CP && value != null && value.Source.IdBase == this.IdBase)
					{
						this.amperage_0 = value;
						this.OnAmperage = true;
						this.vmethod_1();
					}
				}
				else if (this.Parent == null)
				{
					this.amperage_0 = value;
					this.vmethod_1();
				}
				if (this.drawObjectBaseEventHandler_4 != null)
				{
					this.drawObjectBaseEventHandler_4(this);
				}
			}
		}

		public string ObjectType
		{
			get
			{
				return "Shina";
			}
		}

		public override DrawObjectBase Master
		{
			get
			{
				return base.Master;
			}
			set
			{
				if (value != null && value.GetType() != typeof(ShinaTool))
				{
					return;
				}
				if (base.Master != null)
				{
					((ShinaTool)base.Master).AmperageChanged -= this.method_7;
					if (((ShinaTool)base.Master).Amperage != null)
					{
						this.Amperage.method_5();
						this.Amperage = null;
					}
				}
				base.Master = value;
				if (base.Master != null)
				{
					((ShinaTool)base.Master).AmperageChanged += this.method_7;
					if (((ShinaTool)base.Master).Amperage != null)
					{
						this.Amperage = new Amperage(((ShinaTool)base.Master).Amperage.Source, this, ((ShinaTool)base.Master).Amperage.amperageProperties, (((ShinaTool)base.Master).Amperage.method_0().Count<Amperage>() > 0) ? ((ShinaTool)base.Master).Amperage.method_0().First<Amperage>() : null);
						this.vmethod_1();
					}
				}
			}
		}

		private void method_7(DrawObjectBase drawObjectBase_2)
		{
			if (base.Master != null && ((ShinaTool)base.Master).Amperage != null)
			{
				this.Amperage = new Amperage(((ShinaTool)base.Master).Amperage.Source, this, ((ShinaTool)base.Master).Amperage.amperageProperties, ((ShinaTool)base.Master).Amperage.method_0().First<Amperage>());
				this.vmethod_1();
				return;
			}
			if (this.amperage_0 != null)
			{
				this.Amperage.method_5();
				this.Amperage = null;
			}
		}

		public override int NodeCount
		{
			get
			{
				return 2;
			}
		}

		public UnitPoint P1
		{
			get
			{
				return this.unitPoint_0;
			}
			set
			{
				this.unitPoint_0 = value;
			}
		}

		public UnitPoint P2
		{
			get
			{
				return this.unitPoint_1;
			}
			set
			{
				this.unitPoint_1 = value;
			}
		}

		public PointShinaTool SelectedCell
		{
			get
			{
				return this.pointShinaTool_0;
			}
			set
			{
				this.pointShinaTool_0 = value;
			}
		}

		public override DrawObjectBase Parent
		{
			get
			{
				return base.Parent;
			}
			set
			{
				if (this.Parent != null && this.Parent.GetType() == typeof(RectangleTool))
				{
					((RectangleTool)this.Parent).ResizeRectangle -= this.method_17;
					((RectangleTool)this.Parent).ChangeTypeRectangleTool -= this.method_8;
				}
				base.Parent = value;
				if (this.Parent != null && this.Parent.GetType() == typeof(RectangleTool))
				{
					((RectangleTool)this.Parent).ResizeRectangle += this.method_17;
					((RectangleTool)this.Parent).ChangeTypeRectangleTool += this.method_8;
				}
			}
		}

		private void method_8(object sender, EventArgs e)
		{
		}

		public eTypeShinaTool TypeShinaTool
		{
			get
			{
				return this.eTypeShinaTool_0;
			}
			set
			{
				this.eTypeShinaTool_0 = value;
			}
		}

		public TextFont TextVoltProperty
		{
			get
			{
				this.textFont_1.FontName = this.TextProperty.FontName;
				this.textFont_1.FontSize = this.TextProperty.FontSize;
				this.textFont_1.FontBold = this.TextProperty.FontBold;
				this.textFont_1.FontItalic = this.TextProperty.FontItalic;
				this.textFont_1.FontUnderline = this.TextProperty.FontUnderline;
				this.textFont_1.Color = this.TextProperty.Color;
				return this.textFont_1;
			}
			set
			{
				this.textFont_1 = value;
			}
		}

		public override Color Color
		{
			get
			{
				if (this.Layer != null && this.Layer.Parent != null && base.UseSettingColor)
				{
					eTypeShinaTool typeShinaTool = this.TypeShinaTool;
					if (typeShinaTool <= eTypeShinaTool.Shina_023)
					{
						if (typeShinaTool == eTypeShinaTool.Shina_04)
						{
							return this.Layer.Parent.Settings.Shina04Color;
						}
						if (typeShinaTool == eTypeShinaTool.Shina_6)
						{
							return this.Layer.Parent.Settings.Color_0;
						}
						if (typeShinaTool == eTypeShinaTool.Shina_023)
						{
							return this.Layer.Parent.Settings.Shina023Color;
						}
					}
					else
					{
						if (typeShinaTool == eTypeShinaTool.Shina_10)
						{
							return this.Layer.Parent.Settings.Shina10Color;
						}
						if (typeShinaTool == eTypeShinaTool.Shina_35)
						{
							return this.Layer.Parent.Settings.Shina35Color;
						}
						if (typeShinaTool == eTypeShinaTool.Shina_110)
						{
							return this.Layer.Parent.Settings.Shina110Color;
						}
					}
				}
				return base.Color;
			}
			set
			{
				base.Color = value;
			}
		}

		public Color ColorOff
		{
			get
			{
				if (this.Layer != null && this.Layer.Parent != null && base.UseSettingColor)
				{
					eTypeShinaTool typeShinaTool = this.TypeShinaTool;
					if (typeShinaTool <= eTypeShinaTool.Shina_023)
					{
						if (typeShinaTool == eTypeShinaTool.Shina_04)
						{
							return this.Layer.Parent.Settings.Shina04ColorOff;
						}
						if (typeShinaTool == eTypeShinaTool.Shina_6)
						{
							return this.Layer.Parent.Settings.Shina6ColorOff;
						}
						if (typeShinaTool == eTypeShinaTool.Shina_023)
						{
							return this.Layer.Parent.Settings.Shina023ColorOff;
						}
					}
					else
					{
						if (typeShinaTool == eTypeShinaTool.Shina_10)
						{
							return this.Layer.Parent.Settings.Shina10ColorOff;
						}
						if (typeShinaTool == eTypeShinaTool.Shina_35)
						{
							return this.Layer.Parent.Settings.Shina35ColorOff;
						}
						if (typeShinaTool == eTypeShinaTool.Shina_110)
						{
							return this.Layer.Parent.Settings.Shina110ColorOff;
						}
					}
				}
				return this.color_3;
			}
			set
			{
				this.color_3 = value;
			}
		}

		public override TextFont TextProperty
		{
			get
			{
				if (this.Layer != null && base.UseSettingsText)
				{
					TextFont textFont = base.TextProperty;
					eTypeShinaTool typeShinaTool = this.TypeShinaTool;
					if (typeShinaTool <= eTypeShinaTool.Shina_6)
					{
						if (typeShinaTool != eTypeShinaTool.Shina_04)
						{
							if (typeShinaTool == eTypeShinaTool.Shina_6)
							{
								textFont = this.Layer.Parent.Settings.TextPropertyShina6;
							}
						}
						else
						{
							textFont = this.Layer.Parent.Settings.TextPropertyShina04;
						}
					}
					else if (typeShinaTool != eTypeShinaTool.Shina_023)
					{
						if (typeShinaTool == eTypeShinaTool.Shina_10)
						{
							textFont = this.Layer.Parent.Settings.TextPropertyShina10;
						}
					}
					else
					{
						textFont = this.Layer.Parent.Settings.TextPropertyShina023;
					}
					base.TextProperty = new TextFont(textFont.FontName, textFont.FontSize, textFont.FontBold, textFont.FontItalic, textFont.FontUnderline, base.TextProperty.Position, base.TextProperty.FontVirtical, base.TextProperty.Visible, textFont.Color);
					return base.TextProperty;
				}
				return base.TextProperty;
			}
			set
			{
				base.TextProperty = value;
			}
		}

		public override DrawingLayer Layer
		{
			get
			{
				return base.Layer;
			}
			set
			{
				base.Layer = value;
				foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
				{
					drawObjectBase.Layer = value;
				}
			}
		}

		public ShinaTool()
		{
			Class90.TDroV38zslI2T();
			this.widthShina = 0.15f;
			this.eTypeShinaTool_0 = eTypeShinaTool.Shina_10;
			this.textFont_1 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, false, Color.White);
			this.color_3 = Color.White;
			this.splitters = new List<SplitterShinaTool>();
			base..ctor();
			this.TextProperty.Visible = false;
		}

		public ShinaTool(DataRow r, DrawingLayer layer)
		{
			Class90.TDroV38zslI2T();
			this.widthShina = 0.15f;
			this.eTypeShinaTool_0 = eTypeShinaTool.Shina_10;
			this.textFont_1 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, false, Color.White);
			this.color_3 = Color.White;
			this.splitters = new List<SplitterShinaTool>();
			base..ctor(r);
			layer.AddObject(this);
			this.TextProperty.Visible = false;
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)r["SchemaXml"]);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/Obj");
			this.TypeShinaTool = (eTypeShinaTool)Convert.ToInt32(r["TypeCodeId"]);
			this.P1 = new UnitPoint((double)Convert.ToSingle(xmlNode.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode.Attributes[1].Value, new CultureInfo(1033)));
			this.P2 = new UnitPoint((double)Convert.ToSingle(xmlNode.Attributes[2].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode.Attributes[3].Value, new CultureInfo(1033)));
			XmlAttribute xmlAttribute = xmlNode.Attributes["limEd"];
			if (xmlAttribute != null)
			{
				this.LimitedEditing = Convert.ToBoolean(xmlAttribute.Value);
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("textPos");
			if (xmlAttribute != null)
			{
				this.TextProperty.Visible = true;
				if (xmlAttribute != null)
				{
					this.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
				}
			}
			else
			{
				this.TextProperty.Visible = false;
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("TextVoltVis");
			if (xmlAttribute != null)
			{
				this.TextVoltProperty.Visible = Convert.ToBoolean(xmlAttribute.Value);
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("TextVoltPos");
				if (xmlAttribute != null)
				{
					this.TextVoltProperty.Position = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
				}
			}
			foreach (object obj in xmlNode.SelectNodes("WP"))
			{
				XmlNode xmlNode2 = (XmlNode)obj;
				PointShinaTool pointShinaTool = new PointShinaTool();
				xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("text");
				if (xmlAttribute != null)
				{
					pointShinaTool.Text = xmlAttribute.Value;
				}
				xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("textPos");
				if (xmlAttribute != null)
				{
					pointShinaTool.TextProperty.Visible = true;
					pointShinaTool.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
				}
				else
				{
					pointShinaTool.TextProperty.Visible = false;
				}
				xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("FontName");
				if (xmlAttribute != null)
				{
					pointShinaTool.UseSettingsText = false;
					pointShinaTool.TextProperty.FontName = xmlAttribute.Value;
					xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("FontSize");
					if (xmlAttribute != null)
					{
						pointShinaTool.TextProperty.FontSize = Convert.ToSingle(xmlAttribute.Value, new CultureInfo(1033));
					}
					xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("FontBold");
					if (xmlAttribute != null)
					{
						pointShinaTool.TextProperty.FontBold = Convert.ToBoolean(xmlAttribute.Value);
					}
					xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("FontItalic");
					if (xmlAttribute != null)
					{
						pointShinaTool.TextProperty.FontItalic = Convert.ToBoolean(xmlAttribute.Value);
					}
					xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("FontUnderline");
					if (xmlAttribute != null)
					{
						pointShinaTool.TextProperty.FontUnderline = Convert.ToBoolean(xmlAttribute.Value);
					}
					xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("FontColor");
					if (xmlAttribute != null)
					{
						pointShinaTool.TextProperty.Color = Color.FromArgb(Convert.ToInt32(xmlAttribute.Value));
					}
				}
				else
				{
					pointShinaTool.UseSettingsText = true;
				}
				pointShinaTool.UseSettingColor = false;
				xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("Color");
				if (xmlAttribute != null)
				{
					pointShinaTool.Color = Color.FromArgb(Convert.ToInt32(xmlAttribute.Value));
				}
				else
				{
					pointShinaTool.Color = Color.White;
				}
				pointShinaTool.Point = new UnitPoint((double)Convert.ToSingle(xmlNode2.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode2.Attributes[1].Value, new CultureInfo(1033)));
				pointShinaTool.Parent = this;
				pointShinaTool.Width = 0.125f;
				pointShinaTool.Delta = (float)(Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - (float)pointShinaTool.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - (float)pointShinaTool.Point.Y), 2.0)) / Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - this.unitPoint_1.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - this.unitPoint_1.Point.Y), 2.0)));
				if (float.IsNaN(pointShinaTool.Delta))
				{
					pointShinaTool.Delta = 0f;
				}
				layer.AddObject(pointShinaTool);
				pointShinaTool.ObjectRemoved += this.method_9;
				this.ReCalcCellShina();
			}
			foreach (object obj2 in xmlNode.SelectNodes("splitter"))
			{
				XmlNode xml = (XmlNode)obj2;
				SplitterShinaTool splitterShinaTool = new SplitterShinaTool(this, xml);
				splitterShinaTool.ObjectRemoved += this.method_10;
				this.AddPointShinaTool(splitterShinaTool.branch.Source);
			}
		}

		public void RotateAboutThePoint(double angle, UnitPoint centerOfRotation)
		{
			double num = this.unitPoint_0.X - centerOfRotation.X;
			double num2 = this.unitPoint_0.Y - centerOfRotation.Y;
			double num3 = Convert.ToDouble(Math.Cos(angle * 3.1415926535897931 / 180.0));
			double num4 = Convert.ToDouble(Math.Sin(angle * 3.1415926535897931 / 180.0));
			double x = (double)centerOfRotation.Point.X + num * num3 - num2 * num4;
			double y = (double)centerOfRotation.Point.Y + num * num4 + num2 * num3;
			this.unitPoint_0 = new UnitPoint(x, y);
			num = this.unitPoint_1.X - centerOfRotation.X;
			num2 = this.unitPoint_1.Y - centerOfRotation.Y;
			x = (double)centerOfRotation.Point.X + num * num3 - num2 * num4;
			y = (double)centerOfRotation.Point.Y + num * num4 + num2 * num3;
			this.unitPoint_1 = new UnitPoint(x, y);
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(PointShinaTool) && ((PointShinaTool)drawObjectBase).CouplingRelations.Count != 0)
				{
					((LineTool)((PointShinaTool)drawObjectBase).Branches.First<Branch>().Parent).RotateAboutThePoint(angle, centerOfRotation);
				}
			}
		}

		public void ReflectAboutTheLine(UnitPoint up1, UnitPoint up2)
		{
			UnitPoint unitPoint = Class79.smethod_4(up1, up2, this.unitPoint_0);
			double num = (double)this.unitPoint_0.Point.X - unitPoint.X;
			double num2 = (double)this.unitPoint_0.Point.Y - unitPoint.Y;
			this.unitPoint_0 = new UnitPoint((double)((float)(unitPoint.X - num)), (double)((float)(unitPoint.Y - num2)));
			unitPoint = Class79.smethod_4(up1, up2, this.unitPoint_1);
			num = (double)this.unitPoint_1.Point.X - unitPoint.X;
			num2 = (double)this.unitPoint_1.Point.Y - unitPoint.Y;
			this.unitPoint_1 = new UnitPoint((double)((float)(unitPoint.X - num)), (double)((float)(unitPoint.Y - num2)));
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(PointShinaTool) && ((PointShinaTool)drawObjectBase).CouplingRelations.Count != 0)
				{
					((LineTool)((PointShinaTool)drawObjectBase).Branches.First<Branch>().Parent).ReflectAboutTheLine(up1, up2);
				}
			}
		}

		public void AddWhitePoint()
		{
			PointShinaTool pointShinaTool = new PointShinaTool();
			pointShinaTool.Text = "ВН на трансформаторе";
			pointShinaTool.UseSettingColor = false;
			pointShinaTool.Color = Color.White;
			pointShinaTool.Point = new UnitPoint(this.unitPoint_2.X, this.unitPoint_2.Y);
			pointShinaTool.Parent = this;
			pointShinaTool.Width = 0.125f;
			pointShinaTool.Delta = (float)(Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - (float)pointShinaTool.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - (float)pointShinaTool.Point.Y), 2.0)) / Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - this.unitPoint_1.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - this.unitPoint_1.Point.Y), 2.0)));
			if (float.IsNaN(pointShinaTool.Delta))
			{
				pointShinaTool.Delta = 0f;
			}
			this.Layer.AddObject(pointShinaTool);
			this.ReCalcCellShina();
			pointShinaTool.ObjectRemoved += this.method_9;
			this.SaveXmlToSql();
		}

		private void method_9(DrawObjectBase drawObjectBase_2)
		{
			drawObjectBase_2.ObjectRemoved -= this.method_9;
			this.SaveXmlToSql();
		}

		public void AddCellLineTool()
		{
			PointShinaTool pointShinaTool = new PointShinaTool();
			pointShinaTool.UseSettingColor = false;
			pointShinaTool.Color = Color.Aqua;
			pointShinaTool.Point = new UnitPoint(this.unitPoint_2.X, this.unitPoint_2.Y);
			pointShinaTool.Parent = this;
			pointShinaTool.Delta = (float)(Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - (float)pointShinaTool.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - (float)pointShinaTool.Point.Y), 2.0)) / Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - this.unitPoint_1.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - this.unitPoint_1.Point.Y), 2.0)));
			if (float.IsNaN(pointShinaTool.Delta))
			{
				pointShinaTool.Delta = 0f;
			}
			this.ReCalcCellShina();
			LineCellTool lineCellTool = new LineCellTool();
			eTypeShinaTool eTypeShinaTool = this.eTypeShinaTool_0;
			if (eTypeShinaTool <= eTypeShinaTool.Shina_6)
			{
				if (eTypeShinaTool != eTypeShinaTool.Shina_04)
				{
					if (eTypeShinaTool == eTypeShinaTool.Shina_6)
					{
						lineCellTool.Type = LineToolType.CellLine_6;
					}
				}
				else
				{
					lineCellTool.Type = LineToolType.CellLine_04;
				}
			}
			else if (eTypeShinaTool != eTypeShinaTool.Shina_023)
			{
				if (eTypeShinaTool == eTypeShinaTool.Shina_10)
				{
					lineCellTool.Type = LineToolType.CellLine_10;
				}
			}
			else
			{
				lineCellTool.Type = LineToolType.CellLine_023;
			}
			this.Layer.AddObject(lineCellTool);
			if (base.GetType() == typeof(ShinaTool))
			{
				lineCellTool.Parent = this.Parent;
			}
			else if (base.GetType() == typeof(SplitterShinaTool))
			{
				lineCellTool.Parent = ((SplitterShinaTool)this).parentShina.Parent;
			}
			lineCellTool.AddBranch(pointShinaTool, new PointTool(this.unitPoint_2));
			base.CallDrawNewObjectEvent(this, lineCellTool);
		}

		public void AddBridgeShinaTool()
		{
			PointShinaTool pointShinaTool = new PointShinaTool();
			pointShinaTool.UseSettingColor = false;
			pointShinaTool.Color = Color.Aqua;
			pointShinaTool.Point = new UnitPoint(this.unitPoint_2.X, this.unitPoint_2.Y);
			pointShinaTool.Parent = this;
			pointShinaTool.Delta = (float)(Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - (float)pointShinaTool.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - (float)pointShinaTool.Point.Y), 2.0)) / Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - this.unitPoint_1.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - this.unitPoint_1.Point.Y), 2.0)));
			if (float.IsNaN(pointShinaTool.Delta))
			{
				pointShinaTool.Delta = 0f;
			}
			this.ReCalcCellShina();
			Class14 @class = new Class14();
			this.Layer.AddObject(@class);
			@class.Parent = this.Parent;
			@class.AddBranch(pointShinaTool, new PointTool(this.unitPoint_2));
			base.CallDrawNewObjectEvent(this, @class);
		}

		public void AddSplitterShinaTool()
		{
			PointShinaTool pointShinaTool = new PointShinaTool();
			pointShinaTool.UseSettingColor = false;
			pointShinaTool.Color = Color.Aqua;
			pointShinaTool.Point = new UnitPoint(this.unitPoint_2.X, this.unitPoint_2.Y);
			pointShinaTool.Parent = this;
			pointShinaTool.Delta = (float)(Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - (float)pointShinaTool.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - (float)pointShinaTool.Point.Y), 2.0)) / Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - this.unitPoint_1.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - this.unitPoint_1.Point.Y), 2.0)));
			if (float.IsNaN(pointShinaTool.Delta))
			{
				pointShinaTool.Delta = 0f;
			}
			this.ReCalcCellShina();
			SplitterShinaTool splitterShinaTool = new SplitterShinaTool(this.Layer, pointShinaTool);
			this.splitters.Add(splitterShinaTool);
			splitterShinaTool.ObjectRemoved += this.method_10;
			base.CallDrawNewObjectEvent(this, splitterShinaTool);
			this.SaveXmlToSql();
			this.Layer.Parent.CommandEscape();
		}

		public void AddPatternAbn(eTypeAddShinaPatterns typePatterns, float? deltaPoint)
		{
			PointShinaTool pointShinaTool = new PointShinaTool();
			pointShinaTool.Parent = this;
			if (deltaPoint == null)
			{
				pointShinaTool.Point = new UnitPoint(this.unitPoint_2.X, this.unitPoint_2.Y);
				pointShinaTool.Delta = (float)(Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - (float)pointShinaTool.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - (float)pointShinaTool.Point.Y), 2.0)) / Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - this.unitPoint_1.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - this.unitPoint_1.Point.Y), 2.0)));
				if (float.IsNaN(pointShinaTool.Delta))
				{
					pointShinaTool.Delta = 0f;
				}
			}
			else
			{
				pointShinaTool.Delta = deltaPoint.Value;
				if (float.IsNaN(pointShinaTool.Delta))
				{
					pointShinaTool.Delta = 0f;
				}
			}
			this.ReCalcCellShina();
			LineCellTool addLineCell = new LineCellTool();
			eTypeShinaTool eTypeShinaTool = this.eTypeShinaTool_0;
			if (eTypeShinaTool <= eTypeShinaTool.Shina_6)
			{
				if (eTypeShinaTool != eTypeShinaTool.Shina_04)
				{
					if (eTypeShinaTool == eTypeShinaTool.Shina_6)
					{
						addLineCell.Type = LineToolType.CellLine_6;
					}
				}
				else
				{
					addLineCell.Type = LineToolType.CellLine_04;
				}
			}
			else if (eTypeShinaTool != eTypeShinaTool.Shina_023)
			{
				if (eTypeShinaTool == eTypeShinaTool.Shina_10)
				{
					addLineCell.Type = LineToolType.CellLine_10;
				}
			}
			else
			{
				addLineCell.Type = LineToolType.CellLine_023;
			}
			this.Layer.AddObject(addLineCell);
			if (base.GetType() == typeof(ShinaTool))
			{
				addLineCell.Parent = this.Parent;
			}
			else if (base.GetType() == typeof(SplitterShinaTool))
			{
				addLineCell.Parent = ((SplitterShinaTool)this).parentShina.Parent;
			}
			PointTool pointTool = new PointTool(new UnitPoint(pointShinaTool.Point.X, pointShinaTool.Point.Y - 3.0));
			addLineCell.AddBranch(pointShinaTool, pointTool);
			addLineCell.Text = (pointShinaTool.Text = "1");
			TextFont textProperty = addLineCell.TextProperty;
			pointShinaTool.TextProperty.Visible = true;
			textProperty.Visible = true;
			TextFont textProperty2 = addLineCell.TextProperty;
			pointShinaTool.TextProperty.Position = ePositionText.T;
			textProperty2.Position = ePositionText.T;
			LineTool lineTool = new LineTool();
			if (this.Parent != null)
			{
				lineTool.Text = this.Parent.ToString() + "\\" + this.ToString() + "\\Line-Abn1";
			}
			else
			{
				lineTool.Text = this.ToString() + "\\Line-Abn1";
			}
			this.Layer.AddObject(lineTool);
			lineTool.AddBranch(pointTool, new PointTool(new UnitPoint(pointShinaTool.Point.X, pointShinaTool.Point.Y - 6.0)));
			switch (typePatterns)
			{
			case eTypeAddShinaPatterns.Reserv:
			{
				ObjectOnLine objectOnLine = addLineCell.Branches[0].AddSwitchTool(TypeSwitch.LinearDisconnectorTool, 0.3);
				this.Layer.AddObject(objectOnLine);
				objectOnLine.On = true;
				TextBranchTool textBranchTool = new TextBranchTool();
				textBranchTool.Direct = false;
				textBranchTool.Text = "Резерв";
				textBranchTool.Parent = lineTool.Branches[0];
				this.Layer.AddObject(textBranchTool);
				break;
			}
			case eTypeAddShinaPatterns.Auto:
			{
				ObjectOnLine objectOnLine = addLineCell.Branches[0].AddSwitchTool(TypeSwitch.CircuitBreaker, 0.3);
				this.Layer.AddObject(objectOnLine);
				objectOnLine.On = true;
				ObjectOnLine drawobject = lineTool.Branches[0].AddSwitchTool(TypeSwitch.EndTrimTool, 0.1);
				this.Layer.AddObject(drawobject);
				TextBranchTool textBranchTool = new TextBranchTool();
				textBranchTool.Direct = false;
				textBranchTool.Text = "Текст1";
				textBranchTool.Parent = lineTool.Branches[0];
				this.Layer.AddObject(textBranchTool);
				textBranchTool = new TextBranchTool();
				textBranchTool.Direct = false;
				textBranchTool.TextProperty.Position = ePositionText.B;
				textBranchTool.Text = "Текст2";
				textBranchTool.Parent = lineTool.Branches[0];
				this.Layer.AddObject(textBranchTool);
				break;
			}
			case eTypeAddShinaPatterns.Normal:
			{
				ObjectOnLine objectOnLine = addLineCell.Branches[0].AddSwitchTool(TypeSwitch.LinearDisconnectorTool, 0.3);
				this.Layer.AddObject(objectOnLine);
				objectOnLine.On = true;
				ObjectOnLine drawobject2 = addLineCell.Branches[0].AddSwitchTool(TypeSwitch.FuseTool, 0.6);
				this.Layer.AddObject(drawobject2);
				ObjectOnLine drawobject = lineTool.Branches[0].AddSwitchTool(TypeSwitch.EndTrimTool, 0.1);
				this.Layer.AddObject(drawobject);
				TextBranchTool textBranchTool = new TextBranchTool();
				textBranchTool.Direct = false;
				textBranchTool.Text = "Текст1";
				textBranchTool.Parent = lineTool.Branches[0];
				this.Layer.AddObject(textBranchTool);
				textBranchTool = new TextBranchTool();
				textBranchTool.Direct = false;
				textBranchTool.TextProperty.Position = ePositionText.B;
				textBranchTool.Text = "Текст2";
				textBranchTool.Parent = lineTool.Branches[0];
				this.Layer.AddObject(textBranchTool);
				break;
			}
			case eTypeAddShinaPatterns.RPS:
			{
				ObjectOnLine objectOnLine = addLineCell.Branches[0].AddSwitchTool(TypeSwitch.RPSTool, 0.3);
				this.Layer.AddObject(objectOnLine);
				objectOnLine.On = true;
				ObjectOnLine drawobject2 = addLineCell.Branches[0].AddSwitchTool(TypeSwitch.FuseTool, 0.6);
				this.Layer.AddObject(drawobject2);
				ObjectOnLine drawobject = lineTool.Branches[0].AddSwitchTool(TypeSwitch.EndTrimTool, 0.1);
				this.Layer.AddObject(drawobject);
				TextBranchTool textBranchTool = new TextBranchTool();
				textBranchTool.Direct = false;
				textBranchTool.Text = "Текст1";
				textBranchTool.Parent = lineTool.Branches[0];
				this.Layer.AddObject(textBranchTool);
				textBranchTool = new TextBranchTool();
				textBranchTool.Direct = false;
				textBranchTool.TextProperty.Position = ePositionText.B;
				textBranchTool.Text = "Текст2";
				textBranchTool.Parent = lineTool.Branches[0];
				this.Layer.AddObject(textBranchTool);
				break;
			}
			}
			this.Layer.Parent.DoInvalidate(true);
			IEnumerable<DrawObjectBase> source = from obj in this.Layer.Objects
			where obj != addLineCell && obj.GetType() == addLineCell.GetType() && ((LineCellTool)obj).Type == addLineCell.Type
			select obj;
			while ((from obj in source
			where obj.Text == addLineCell.Text
			select obj).Count<DrawObjectBase>() > 0)
			{
				addLineCell.Text = (Convert.ToInt32(addLineCell.Text) + 1).ToString();
			}
			pointShinaTool.Text = addLineCell.Text;
			lineTool.CreateUniqueCopyName();
			addLineCell.SaveToSql(false, true);
			lineTool.SaveToSql(false, true);
		}

		private void method_10(DrawObjectBase drawObjectBase_2)
		{
			this.RemoveSplitter((SplitterShinaTool)drawObjectBase_2);
		}

		public override string GetFullName()
		{
			if (this.Parent != null)
			{
				return this.Parent.ToString() + ": " + this.ToString();
			}
			return this.ToString();
		}

		public override string ToString()
		{
			eTypeShinaTool typeShinaTool = this.TypeShinaTool;
			if (typeShinaTool <= eTypeShinaTool.Shina_6)
			{
				if (typeShinaTool == eTypeShinaTool.Shina_04)
				{
					return "Ш04 - " + this.Text;
				}
				if (typeShinaTool == eTypeShinaTool.Shina_6)
				{
					return "Ш6 - " + this.Text;
				}
			}
			else
			{
				if (typeShinaTool == eTypeShinaTool.Shina_023)
				{
					return "Ш023 - " + this.Text;
				}
				if (typeShinaTool == eTypeShinaTool.Shina_10)
				{
					return "Ш10 - " + this.Text;
				}
			}
			return this.Text;
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			ShinaTool shinaTool = new ShinaTool();
			shinaTool.Copy(this);
			return shinaTool;
		}

		public override void Copy(DrawObjectBase acopy)
		{
			base.Copy(acopy);
			if (acopy.GetType() == typeof(ShinaTool))
			{
				this.P1 = ((ShinaTool)acopy).P1;
				this.P2 = ((ShinaTool)acopy).P2;
				this.TypeShinaTool = ((ShinaTool)acopy).TypeShinaTool;
			}
		}

		public override bool PointInObject(UnitPoint point)
		{
			if (this.Layer == null)
			{
				return false;
			}
			CanvasControl parent = this.Layer.Parent;
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(PointShinaTool) && drawObjectBase.PointInObject(point))
				{
					this.pointShinaTool_0 = (PointShinaTool)drawObjectBase;
					return true;
				}
			}
			this.pointShinaTool_0 = null;
			float num = base.ThresholdWidth(parent, base.Width);
			if (this.unitPoint_0.Y != this.unitPoint_1.Y)
			{
				float num2 = Convert.ToSingle((point.Y - this.unitPoint_0.Y) * (this.unitPoint_1.X - this.unitPoint_0.X) / (this.unitPoint_1.Y - this.unitPoint_0.Y) + this.unitPoint_0.X);
				if (Math.Abs(point.X - (double)num2) <= (double)num && Math.Min(this.unitPoint_1.Y, this.unitPoint_0.Y) - (double)num <= point.Y && Math.Max(this.unitPoint_1.Y, this.unitPoint_0.Y) + (double)num >= point.Y)
				{
					this.unitPoint_2 = new UnitPoint(this.unitPoint_0.X, point.Y);
					return true;
				}
			}
			if (this.unitPoint_1.X != this.unitPoint_0.X)
			{
				float num3 = Convert.ToSingle((point.X - this.unitPoint_0.X) * (this.unitPoint_1.Y - this.unitPoint_0.Y) / (this.unitPoint_1.X - this.unitPoint_0.X) + this.unitPoint_0.Y);
				if (Math.Abs(point.Y - (double)num3) <= (double)num && Math.Min(this.unitPoint_1.X, this.unitPoint_0.X) - (double)num <= point.X && Math.Max(this.unitPoint_1.X, this.unitPoint_0.X) + (double)num >= point.X)
				{
					this.unitPoint_2 = new UnitPoint(point.X, this.unitPoint_0.Y);
					return true;
				}
			}
			return false;
		}

		public override void Move(UnitPoint offset, bool selectedMove)
		{
			if (!selectedMove && this.Selected)
			{
				return;
			}
			if (this.pointShinaTool_0 == null)
			{
				if (this.Parent != null)
				{
					UnitPoint unitPoint = this.unitPoint_0 + offset;
					UnitPoint unitPoint2 = this.unitPoint_1 + offset;
					if (this.Parent.GetType() == typeof(RectangleTool))
					{
						if (unitPoint.X < (double)((RectangleTool)this.Parent).Rectangle.Left)
						{
							offset.X = (double)((RectangleTool)this.Parent).Rectangle.Left - this.unitPoint_0.X;
						}
						if (unitPoint2.X < (double)((RectangleTool)this.Parent).Rectangle.Left)
						{
							offset.X = (double)((RectangleTool)this.Parent).Rectangle.Left - this.unitPoint_1.X;
						}
						if (unitPoint.X > (double)((RectangleTool)this.Parent).Rectangle.Right)
						{
							offset.X = (double)((RectangleTool)this.Parent).Rectangle.Right - this.unitPoint_0.X;
						}
						if (unitPoint2.X > (double)((RectangleTool)this.Parent).Rectangle.Right)
						{
							offset.X = (double)((RectangleTool)this.Parent).Rectangle.Right - this.unitPoint_1.X;
						}
						if (unitPoint.Y < (double)((RectangleTool)this.Parent).Rectangle.Top)
						{
							offset.Y = (double)((RectangleTool)this.Parent).Rectangle.Top - this.unitPoint_0.Y;
						}
						if (unitPoint2.Y < (double)((RectangleTool)this.Parent).Rectangle.Top)
						{
							offset.Y = (double)((RectangleTool)this.Parent).Rectangle.Top - this.unitPoint_1.Y;
						}
						if (unitPoint.Y > (double)((RectangleTool)this.Parent).Rectangle.Bottom)
						{
							offset.Y = (double)((RectangleTool)this.Parent).Rectangle.Bottom - this.unitPoint_0.Y;
						}
						if (unitPoint2.Y > (double)((RectangleTool)this.Parent).Rectangle.Bottom)
						{
							offset.Y = (double)((RectangleTool)this.Parent).Rectangle.Bottom - this.unitPoint_1.Y;
						}
					}
				}
				this.unitPoint_0 += offset;
				this.unitPoint_1 += offset;
			}
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				drawObjectBase.Move(offset, false);
			}
		}

		public override ISnapPoint SnapPoint(CanvasControl canvas, UnitPoint point, List<DrawObjectBase> otherobjs, Type[] runningsnaptypes, Type usersnaptype)
		{
			float float_ = base.ThresholdWidth(canvas, base.Width);
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(PointShinaTool) && Class79.XrgxasnnaZ(((PointShinaTool)drawObjectBase).Point, float_, point))
				{
					return new Class8(canvas, this, ((PointShinaTool)drawObjectBase).Point);
				}
			}
			return null;
		}

		public override RectangleF GetBoundingRect(CanvasControl canvas, bool inflate)
		{
			float num = base.ThresholdWidth(canvas, base.Width);
			double num2 = Math.Min(this.unitPoint_0.X, this.unitPoint_1.X);
			double num3 = Math.Min(this.unitPoint_0.Y, this.unitPoint_1.Y);
			double num4 = Math.Abs(this.unitPoint_1.X - this.unitPoint_0.X);
			double num5 = Math.Abs(this.unitPoint_1.Y - this.unitPoint_0.Y);
			RectangleF result = new RectangleF((float)num2, (float)num3, (float)num4, (float)num5);
			RectangleF rectangleText = this.GetRectangleText(canvas);
			if (!rectangleText.IsEmpty)
			{
				num2 = (double)Math.Min(rectangleText.X, result.X);
				num3 = (double)Math.Min(rectangleText.Y, result.Y);
				num4 = (double)Math.Max(rectangleText.Right, result.Right) - num2;
				num5 = (double)Math.Max(rectangleText.Bottom, result.Bottom) - num3;
				result = new RectangleF((float)num2, (float)num3, (float)num4, (float)num5);
			}
			if (inflate)
			{
				result.Inflate(num, num);
			}
			return result;
		}

		public Color GetCurrentColor()
		{
			if (this.Selected)
			{
				return this.SelectedColor;
			}
			if (this.Amperage == null)
			{
				return this.ColorOff;
			}
			return this.Color;
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if (!this.Visible)
			{
				return;
			}
			Color color = this.Color;
			if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
			{
				if (this.Selected && (drawMode & eDrawMode.Print) != eDrawMode.Print)
				{
					color = this.SelectedColor;
				}
				else if (base.Bookmark != null && (drawMode & eDrawMode.Print) != eDrawMode.Print)
				{
					color = canvas.Settings.MarkedObjColor;
				}
				else if (this.Amperage == null)
				{
					color = this.ColorOff;
				}
				else
				{
					color = this.Color;
				}
				if (this.Flashing && canvas.ConvertColorFlash && (drawMode & eDrawMode.Print) != eDrawMode.Print)
				{
					color = canvas.Settings.BackFlashingColor;
				}
			}
			else if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
			{
				color = Color.Black;
			}
			else
			{
				if (this.Selected)
				{
					color = Color.Gray;
				}
				else if (base.Bookmark != null)
				{
					color = Color.LightGray;
				}
				if (this.Flashing && canvas.ConvertColorFlash)
				{
					color = Color.White;
				}
			}
			using (Pen pen = new Pen(color, ConvertCanvas.ConvertToScreen(canvas, (double)this.widthShina)))
			{
				PointF pt = ConvertCanvas.ConvertToScreen(canvas, this.unitPoint_0);
				PointF pt2 = ConvertCanvas.ConvertToScreen(canvas, this.unitPoint_1);
				canvas.Graphics.DrawLine(pen, pt, pt2);
				this.DrawText(canvas, drawMode);
				this.method_11(canvas, drawMode);
				this.method_13(canvas, unitrect, drawMode);
				if (this.Selected && (drawMode & eDrawMode.Print) != eDrawMode.Print)
				{
					base.DrawTracker(canvas);
				}
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			Pen pen;
			if (isColor)
			{
				pen = new Pen((this.Color == Color.White) ? Color.Black : this.Color, ConvertCanvas.ConvertToScreen(canvas, (double)this.widthShina));
			}
			else
			{
				pen = new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)this.widthShina));
			}
			PointF pt = ConvertCanvas.ConvertToScreen(canvas, this.unitPoint_0);
			PointF pt2 = ConvertCanvas.ConvertToScreen(canvas, this.unitPoint_1);
			g.DrawLine(pen, pt, pt2);
			if (this.TextProperty.Visible)
			{
				Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style);
				RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetRectangleText(canvas));
				GraphicsState gstate = g.Save();
				if (this.TextProperty.FontVirtical)
				{
					Matrix transform = g.Transform;
					rectangleF.Y += rectangleF.Height;
					transform.RotateAt(-90f, rectangleF.Location, MatrixOrder.Append);
					g.Transform = transform;
				}
				if (rectangleF.Size.Width > 0f && rectangleF.Size.Height > 0f)
				{
					g.DrawString(this.Text, font, new SolidBrush(Color.Black), rectangleF.Location);
				}
				font.Dispose();
				g.Restore(gstate);
			}
			this.method_11(canvas, eDrawMode.Print);
			this.method_13(canvas, RectangleF.Empty, eDrawMode.Print);
			pen.Dispose();
		}

		private void method_11(CanvasControl canvasControl_0, eDrawMode eDrawMode_0 = eDrawMode.Color)
		{
			if (this.Visible && this.TextVoltProperty.Visible)
			{
				if (base.UseSettingsText && this.TextProperty.FontSize * canvasControl_0.Zoom <= canvasControl_0.Settings.FontSizeNoVisible && (eDrawMode_0 & eDrawMode.Print) != eDrawMode.Print)
				{
					return;
				}
				using (Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvasControl_0.Zoom, this.TextProperty.Font.Style))
				{
					RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(canvasControl_0, this.method_12(canvasControl_0));
					GraphicsState gstate = canvasControl_0.Graphics.Save();
					if (this.textFont_1.FontVirtical)
					{
						Matrix transform = canvasControl_0.Graphics.Transform;
						rectangleF.Y += rectangleF.Height;
						transform.RotateAt(-90f, rectangleF.Location, MatrixOrder.Append);
						canvasControl_0.Graphics.Transform = transform;
					}
					if (rectangleF.Size.Width > 0f && rectangleF.Size.Height > 0f)
					{
						using (SolidBrush solidBrush = new SolidBrush(this.TextVoltProperty.Color))
						{
							if ((eDrawMode_0 & eDrawMode.Print) == eDrawMode.Print)
							{
								if ((eDrawMode_0 & eDrawMode.Color) != eDrawMode.Color)
								{
									solidBrush.Color = Color.Black;
								}
								else if (canvasControl_0.Settings.BackgroundColor.ToArgb() == solidBrush.Color.ToArgb() && solidBrush.Color.ToArgb() == Color.White.ToArgb())
								{
									solidBrush.Color = Color.Black;
								}
							}
							else if ((eDrawMode_0 & eDrawMode.Color) == eDrawMode.Color)
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
							string s = "";
							eTypeShinaTool typeShinaTool = this.TypeShinaTool;
							if (typeShinaTool <= eTypeShinaTool.Shina_6)
							{
								if (typeShinaTool != eTypeShinaTool.Shina_04)
								{
									if (typeShinaTool == eTypeShinaTool.Shina_6)
									{
										s = "6 кВ";
									}
								}
								else
								{
									s = "0.4 кВ";
								}
							}
							else if (typeShinaTool != eTypeShinaTool.Shina_023)
							{
								if (typeShinaTool == eTypeShinaTool.Shina_10)
								{
									s = "10 кВ";
								}
							}
							else
							{
								s = "0.23 кВ";
							}
							canvasControl_0.Graphics.DrawString(s, font, solidBrush, rectangleF.Location);
						}
					}
					canvasControl_0.Graphics.Restore(gstate);
				}
			}
		}

		private RectangleF method_12(CanvasControl canvasControl_0)
		{
			RectangleF empty = RectangleF.Empty;
			UnitPoint unitPoint = this.unitPoint_0;
			UnitPoint unitPoint2 = this.unitPoint_1;
			if (this.unitPoint_0.X > this.unitPoint_1.X)
			{
				unitPoint = this.unitPoint_1;
				unitPoint2 = this.unitPoint_0;
			}
			if (this.TextVoltProperty.Visible)
			{
				string text = "";
				eTypeShinaTool typeShinaTool = this.TypeShinaTool;
				if (typeShinaTool <= eTypeShinaTool.Shina_6)
				{
					if (typeShinaTool != eTypeShinaTool.Shina_04)
					{
						if (typeShinaTool == eTypeShinaTool.Shina_6)
						{
							text = "6 кВ";
						}
					}
					else
					{
						text = "0.4 кВ";
					}
				}
				else if (typeShinaTool != eTypeShinaTool.Shina_023)
				{
					if (typeShinaTool == eTypeShinaTool.Shina_10)
					{
						text = "10 кВ";
					}
				}
				else
				{
					text = "0.23 кВ";
				}
				Font font = new Font("Arial", 10f * canvasControl_0.Zoom);
				SizeF sizeF = canvasControl_0.Graphics.MeasureString(text, font);
				font.Dispose();
				SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvasControl_0, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvasControl_0, sizeF.Height));
				empty = new RectangleF(this.unitPoint_0.Point, size);
				Math.Abs(this.unitPoint_0.X - this.unitPoint_1.X);
				Math.Abs(this.unitPoint_0.Y - this.unitPoint_1.Y);
				ePositionText position = this.TextVoltProperty.Position;
				if (position != ePositionText.R)
				{
					if (position == ePositionText.L)
					{
						if (this.unitPoint_0.X == this.unitPoint_1.X)
						{
							empty.X = (float)this.unitPoint_0.X - size.Width;
							empty.Y = (float)Math.Min(this.unitPoint_0.Y, this.unitPoint_1.Y) + (float)Math.Abs(this.unitPoint_0.Y - this.unitPoint_1.Y) / 2f - size.Height / 2f - size.Height;
						}
						else
						{
							empty.X = (float)unitPoint.X - size.Width;
							empty.Y = (float)unitPoint.Y - size.Height;
						}
					}
				}
				else if (this.unitPoint_0.X == this.unitPoint_1.X)
				{
					empty.X = (float)this.unitPoint_0.X;
					empty.Y = (float)Math.Min(this.unitPoint_0.Y, this.unitPoint_1.Y) + (float)Math.Abs(this.unitPoint_0.Y - this.unitPoint_1.Y) / 2f - size.Width / 2f;
				}
				else
				{
					empty.X = (float)unitPoint2.X;
					empty.Y = (float)unitPoint2.Y - size.Height;
				}
				return empty;
			}
			return empty;
		}

		protected override RectangleF GetRectangleText(CanvasControl canvas)
		{
			RectangleF empty = RectangleF.Empty;
			UnitPoint unitPoint = this.unitPoint_0;
			UnitPoint unitPoint2 = this.unitPoint_1;
			if (this.unitPoint_0.X > this.unitPoint_1.X)
			{
				unitPoint = this.unitPoint_1;
				unitPoint2 = this.unitPoint_0;
			}
			if (this.TextProperty.Visible)
			{
				Font font = new Font(this.TextProperty.FontName, this.TextProperty.FontSize * canvas.Zoom);
				SizeF sizeF = canvas.Graphics.MeasureString(this.Text, font);
				font.Dispose();
				SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
				empty = new RectangleF(this.unitPoint_0.Point, size);
				Math.Abs(this.unitPoint_0.X - this.unitPoint_1.X);
				Math.Abs(this.unitPoint_0.Y - this.unitPoint_1.Y);
				switch (this.TextProperty.Position)
				{
				case ePositionText.T:
					if (this.unitPoint_0.Y == this.unitPoint_1.Y)
					{
						empty.X = (float)Math.Min(this.unitPoint_0.X, this.unitPoint_1.X) + (float)Math.Abs(this.unitPoint_0.X - this.unitPoint_1.X) / 2f - size.Width / 2f;
						empty.Y = (float)this.unitPoint_0.Y;
					}
					else if (this.unitPoint_0.Y > this.unitPoint_1.Y)
					{
						empty.X = (float)this.unitPoint_0.X - size.Width / 2f;
						empty.Y = (float)this.unitPoint_0.Y;
					}
					else
					{
						empty.X = (float)this.unitPoint_1.X - size.Width / 2f;
						empty.Y = (float)this.unitPoint_1.Y;
					}
					break;
				case ePositionText.R:
					if (this.unitPoint_0.X == this.unitPoint_1.X)
					{
						empty.X = (float)this.unitPoint_0.X;
						empty.Y = (float)Math.Min(this.unitPoint_0.Y, this.unitPoint_1.Y) + (float)Math.Abs(this.unitPoint_0.Y - this.unitPoint_1.Y) / 2f - size.Width / 2f;
					}
					else
					{
						empty.X = (float)unitPoint2.X;
						empty.Y = (float)unitPoint2.Y;
					}
					break;
				case ePositionText.B:
					if (this.unitPoint_0.Y == this.unitPoint_1.Y)
					{
						empty.X = (float)Math.Min(this.unitPoint_0.X, this.unitPoint_1.X) + (float)Math.Abs(this.unitPoint_0.X - this.unitPoint_1.X) / 2f - size.Width / 2f;
						empty.Y = (float)this.unitPoint_0.Y - size.Height;
					}
					else if (this.unitPoint_0.Y < this.unitPoint_1.Y)
					{
						empty.X = (float)this.unitPoint_0.X - size.Width / 2f;
						empty.Y = (float)this.unitPoint_0.Y - size.Height;
					}
					else
					{
						empty.X = (float)this.unitPoint_1.X - size.Width / 2f;
						empty.Y = (float)this.unitPoint_1.Y - size.Height;
					}
					break;
				case ePositionText.L:
					if (this.unitPoint_0.X == this.unitPoint_1.X)
					{
						empty.X = (float)this.unitPoint_0.X - size.Width;
						empty.Y = (float)Math.Min(this.unitPoint_0.Y, this.unitPoint_1.Y) + (float)Math.Abs(this.unitPoint_0.Y - this.unitPoint_1.Y) / 2f - size.Height / 2f;
					}
					else
					{
						empty.X = (float)unitPoint.X - size.Width;
						empty.Y = (float)unitPoint.Y;
					}
					break;
				}
				return empty;
			}
			return empty;
		}

		private void method_13(CanvasControl canvasControl_0, RectangleF rectangleF_0, eDrawMode eDrawMode_0 = eDrawMode.Color)
		{
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				drawObjectBase.Draw(canvasControl_0, rectangleF_0, eDrawMode_0);
			}
		}

		public override void InitializeFromModel(UnitPoint point, DrawingLayer layer, ISnapPoint snap)
		{
			ConvertCanvas.ConvertToUnit(this.Layer.Parent, 5f * this.Layer.Parent.Zoom);
			this.unitPoint_1 = point;
			this.unitPoint_0 = point;
			base.Width = layer.Width;
			this.Color = layer.Color;
			this.Selected = true;
		}

		public override bool ObjectInRectangle(CanvasControl canvas, RectangleF rect, bool anyPoint)
		{
			RectangleF boundingRect = this.GetBoundingRect(canvas, true);
			if (anyPoint)
			{
				UnitPoint unitPoint = new UnitPoint(boundingRect.Location);
				UnitPoint unitPoint2 = new UnitPoint((double)(boundingRect.X + boundingRect.Width), (double)(boundingRect.Y + boundingRect.Height));
				return Class79.smethod_0(unitPoint, unitPoint2, rect);
			}
			return rect.Contains(boundingRect);
		}

		public override void EndDraw()
		{
			if (new FormShinaProperties(this, this.Layer.Parent.SqlSettings).ShowDialog() == DialogResult.OK)
			{
				if (this.Parent != null && this.Parent.GetType() == typeof(RectangleTool) && ((RectangleTool)this.Parent).TypeRectnagleTool == eTypeRectangleTool.CP)
				{
					this.OnAmperage = true;
					return;
				}
			}
			else
			{
				bool delSql = this.Layer != null && this.Layer.Parent != null && this.Layer.Parent.UseObjectFromDB;
				this.Remove(delSql, true);
			}
		}

		protected override UnitPoint GetNode(int nodeNumber)
		{
			if (nodeNumber == 1)
			{
				return this.unitPoint_0;
			}
			if (nodeNumber != 2)
			{
				return new UnitPoint(0.0, 0.0);
			}
			return this.unitPoint_1;
		}

		public override Cursor GetHandleCursor(int handleNumber)
		{
			if (this.Layer != null && this.Layer.Parent != null && this.Layer.Parent.Mode != eCanvasEditingMode.Edit)
			{
				return Cursors.Default;
			}
			if (handleNumber != 1)
			{
				if (handleNumber != 2)
				{
					return Cursors.Default;
				}
			}
			return Cursors.SizeNWSE;
		}

		public override void MoveHandleTo(UnitPoint point, int handleNumber)
		{
			bool flag = false;
			bool flag2 = Math.Abs(this.P1.X - this.P2.X) < Math.Abs(this.P1.Y - this.unitPoint_1.Y);
			if (handleNumber != 1)
			{
				if (handleNumber == 2)
				{
					if (flag = (Math.Abs(point.X - this.P1.X) < Math.Abs(point.Y - this.unitPoint_0.Y)))
					{
						this.unitPoint_1.X = this.unitPoint_0.X;
						if (this.Parent != null && this.Parent.GetType() == typeof(RectangleTool))
						{
							if (point.Y < (double)((RectangleTool)this.Parent).Rectangle.Top)
							{
								point.Y = (double)((RectangleTool)this.Parent).Rectangle.Top;
							}
							if (point.Y > (double)((RectangleTool)this.Parent).Rectangle.Bottom)
							{
								point.Y = (double)((RectangleTool)this.Parent).Rectangle.Bottom;
							}
						}
						this.unitPoint_1.Y = point.Y;
					}
					else
					{
						this.unitPoint_1.Y = this.unitPoint_0.Y;
						if (this.Parent != null && this.Parent.GetType() == typeof(RectangleTool))
						{
							if (point.X < (double)((RectangleTool)this.Parent).Rectangle.Left)
							{
								point.X = (double)((RectangleTool)this.Parent).Rectangle.Left;
							}
							if (point.X > (double)((RectangleTool)this.Parent).Rectangle.Right)
							{
								point.X = (double)((RectangleTool)this.Parent).Rectangle.Right;
							}
						}
						this.unitPoint_1.X = point.X;
					}
				}
			}
			else if (flag = (Math.Abs(point.X - this.P2.X) < Math.Abs(point.Y - this.unitPoint_1.Y)))
			{
				this.unitPoint_0.X = this.unitPoint_1.X;
				if (this.Parent != null && this.Parent.GetType() == typeof(RectangleTool))
				{
					if (point.Y < (double)((RectangleTool)this.Parent).Rectangle.Top)
					{
						point.Y = (double)((RectangleTool)this.Parent).Rectangle.Top;
					}
					if (point.Y > (double)((RectangleTool)this.Parent).Rectangle.Bottom)
					{
						point.Y = (double)((RectangleTool)this.Parent).Rectangle.Bottom;
					}
				}
				this.unitPoint_0.Y = point.Y;
			}
			else
			{
				this.unitPoint_0.Y = this.unitPoint_1.Y;
				if (this.Parent != null && this.Parent.GetType() == typeof(RectangleTool))
				{
					if (point.X < (double)((RectangleTool)this.Parent).Rectangle.Left)
					{
						point.X = (double)((RectangleTool)this.Parent).Rectangle.Left;
					}
					if (point.X > (double)((RectangleTool)this.Parent).Rectangle.Right)
					{
						point.X = (double)((RectangleTool)this.Parent).Rectangle.Right;
					}
				}
				this.unitPoint_0.X = point.X;
			}
			if (flag != flag2)
			{
				this.ReCalcCellShina();
			}
		}

		public override int HitTest(CanvasControl canvas, PointF point)
		{
			if (this.Selected)
			{
				for (int i = 1; i <= this.NodeCount; i++)
				{
					if (base.GetNodeRectangle(canvas, i).Contains(point))
					{
						return i;
					}
				}
			}
			return -1;
		}

		public override void vmethod_0(XmlNode xmlNode, List<PointTool> pointList)
		{
			XmlDocument ownerDocument = xmlNode.OwnerDocument;
			XmlElement xmlElement = ownerDocument.CreateElement("Shina");
			xmlElement.SetAttribute("ID", this.IdBase.ToString());
			xmlElement.SetAttribute("X1", Math.Round(this.P1.X, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("Y1", Math.Round(this.P1.Y, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("X2", Math.Round(this.P2.X, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("Y2", Math.Round(this.P2.Y, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("text", this.Text);
			xmlElement.SetAttribute("textVis", this.TextProperty.Visible.ToString());
			xmlElement.SetAttribute("textPos", ((int)this.TextProperty.Position).ToString());
			if (!base.UseSettingColor)
			{
				xmlElement.SetAttribute("color", this.Color.ToArgb().ToString());
			}
			else
			{
				xmlElement.SetAttribute("color", "");
			}
			xmlElement.SetAttribute("TypeShina", ((int)this.TypeShinaTool).ToString());
			xmlElement.SetAttribute("TextVoltVis", this.TextVoltProperty.Visible.ToString());
			xmlElement.SetAttribute("TextVoltPos", ((int)this.TextVoltProperty.Position).ToString());
			xmlNode.AppendChild(xmlElement);
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(PointShinaTool))
				{
					if (((PointShinaTool)drawObjectBase).CouplingRelations.Count > 0)
					{
						XmlElement xmlElement2 = ownerDocument.CreateElement("point");
						if (drawObjectBase.IdBase <= 0)
						{
							drawObjectBase.vmethod_0(xmlElement, pointList);
						}
						else
						{
							xmlElement2.SetAttribute("ID", drawObjectBase.IdBase.ToString());
							xmlElement.AppendChild(xmlElement2);
						}
					}
					else if (((PointShinaTool)drawObjectBase).Branches.Count<Branch>() > 0 && ((PointShinaTool)drawObjectBase).Branches.First<Branch>().Parent.GetType() == typeof(SplitterShinaTool))
					{
						SplitterShinaTool splitterShinaTool = (SplitterShinaTool)((PointShinaTool)drawObjectBase).Branches.First<Branch>().Parent;
						XmlElement xmlElement3 = this.xmlCoords.CreateElement("splitter");
						splitterShinaTool.GetXml(xmlElement3);
						this.currentXmlScheme.AppendChild(xmlElement3);
					}
				}
				else
				{
					drawObjectBase.vmethod_0(xmlElement, pointList);
				}
			}
		}

		public void RemoveCell(PointShinaTool delCell)
		{
			((List<DrawObjectBase>)this.ChildObjects).Remove(delCell);
		}

		public void RemoveSplitter(SplitterShinaTool splitter)
		{
			((List<DrawObjectBase>)this.ChildObjects).Remove(splitter.branch.Source);
			this.splitters.Remove(splitter);
			while (splitter.ChildObjects.Count<DrawObjectBase>() > 0)
			{
				DrawObjectBase drawObjectBase = splitter.ChildObjects.First<DrawObjectBase>();
				if (this.ChildObjects.Contains(drawObjectBase))
				{
					((List<DrawObjectBase>)this.ChildObjects).Remove(drawObjectBase);
				}
				drawObjectBase.Parent = null;
				((List<DrawObjectBase>)splitter.ChildObjects).Remove(drawObjectBase);
			}
			this.SaveXmlToSql();
		}

		public PointShinaTool AddPointShinaTool(PointTool point)
		{
			PointShinaTool pointShinaTool = new PointShinaTool();
			pointShinaTool.UseSettingColor = false;
			pointShinaTool.Color = Color.Aqua;
			pointShinaTool.Point = point.Point;
			pointShinaTool.IdOldBase = point.IdOldBase;
			pointShinaTool.Layer = this.Layer;
			pointShinaTool.IdBase = point.IdBase;
			pointShinaTool.Parent = this;
			pointShinaTool.Delta = (float)(Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - (float)pointShinaTool.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - (float)pointShinaTool.Point.Y), 2.0)) / Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - this.unitPoint_1.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - this.unitPoint_1.Point.Y), 2.0)));
			if (float.IsNaN(pointShinaTool.Delta))
			{
				pointShinaTool.Delta = 0f;
			}
			this.ReCalcCellShina();
			return pointShinaTool;
		}

		public PointShinaTool AddPointShinaTool(UnitPoint point)
		{
			PointShinaTool pointShinaTool = new PointShinaTool();
			pointShinaTool.UseSettingColor = false;
			pointShinaTool.Color = Color.Aqua;
			pointShinaTool.Point = point;
			pointShinaTool.Parent = this;
			pointShinaTool.Layer = this.Layer;
			pointShinaTool.Delta = (float)(Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - (float)pointShinaTool.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - (float)pointShinaTool.Point.Y), 2.0)) / Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - this.unitPoint_1.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - this.unitPoint_1.Point.Y), 2.0)));
			if (float.IsNaN(pointShinaTool.Delta))
			{
				pointShinaTool.Delta = 0f;
			}
			this.ReCalcCellShina();
			return pointShinaTool;
		}

		public PointShinaTool AddPointShinaTool(PointShinaTool point)
		{
			if (this.splitters.Count > 0)
			{
				using (List<SplitterShinaTool>.Enumerator enumerator = this.splitters.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						SplitterShinaTool splitterShinaTool = enumerator.Current;
						if (splitterShinaTool.pointThatShouldBeLoaded.Contains(point.IdBase))
						{
							return splitterShinaTool.AddPointShinaTool(point);
						}
					}
					goto IL_5D;
				}
				PointShinaTool result;
				return result;
			}
			IL_5D:
			point.Parent = this;
			point.Layer = this.Layer;
			point.Delta = (float)(Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - (float)point.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - (float)point.Point.Y), 2.0)) / Math.Sqrt(Math.Pow((double)(this.unitPoint_0.Point.X - this.unitPoint_1.Point.X), 2.0) + Math.Pow((double)(this.unitPoint_0.Point.Y - this.unitPoint_1.Point.Y), 2.0)));
			if (float.IsNaN(point.Delta))
			{
				point.Delta = 0f;
			}
			point.AddBranchEvent += new PointToolEventHandle(this.method_14);
			this.ReCalcCellShina();
			return point;
		}

		private void method_14(object sender, EventArgs e)
		{
		}

		public override void vmethod_2(CanvasControl canvas, Document document)
		{
			Line line = new Line(this.Layer.Name, this.P1.X, this.P1.Y, this.P2.X, this.P2.Y);
			document.add(line);
		}

		public override void vmethod_3(CanvasControl canvas, DxfDocument document)
		{
			double num = 1.5;
			LwPolyline lwPolyline = new LwPolyline();
			LwPolylineVertex item = new LwPolylineVertex(new Vector2(this.P1.X, this.P1.Y), 0.0);
			LwPolylineVertex item2 = new LwPolylineVertex(new Vector2(this.P2.X, this.unitPoint_1.Y), 0.0);
			Color color = (this.Amperage == null) ? this.ColorOff : this.Color;
			lwPolyline.Color = new AciColor(color);
			lwPolyline.Vertexes = new List<LwPolylineVertex>
			{
				item,
				item2
			};
			lwPolyline.SetConstantWidth(0.2);
			if (this.TextProperty.Visible)
			{
				RectangleF rectangleText = this.GetRectangleText(canvas);
				document.AddEntity(new Text(this.Text, new Vector2((double)rectangleText.X, (double)rectangleText.Y), (double)rectangleText.Height / num)
				{
					Color = new AciColor(this.TextProperty.Color),
					Style = new TextStyle(this.TextProperty.FontName)
				});
			}
			if (this.Visible && this.textFont_1.Visible)
			{
				RectangleF rectangleF = this.method_12(canvas);
				canvas.Graphics.Save();
				if (rectangleF.Size.Width > 0f && rectangleF.Size.Height > 0f)
				{
					string text = "";
					eTypeShinaTool typeShinaTool = this.TypeShinaTool;
					if (typeShinaTool <= eTypeShinaTool.Shina_6)
					{
						if (typeShinaTool != eTypeShinaTool.Shina_04)
						{
							if (typeShinaTool == eTypeShinaTool.Shina_6)
							{
								text = "6 кВ";
							}
						}
						else
						{
							text = "0.4 кВ";
						}
					}
					else if (typeShinaTool != eTypeShinaTool.Shina_023)
					{
						if (typeShinaTool == eTypeShinaTool.Shina_10)
						{
							text = "10 кВ";
						}
					}
					else
					{
						text = "0.23 кВ";
					}
					document.AddEntity(new Text(text, new Vector2((double)rectangleF.X, (double)rectangleF.Y), (double)rectangleF.Height / num)
					{
						Color = new AciColor(this.TextVoltProperty.Color),
						Style = new TextStyle(this.TextVoltProperty.FontName)
					});
				}
			}
			document.AddEntity(lwPolyline);
		}

		public override List<DrawObjectBase> GetPowerSource()
		{
			if (this.Amperage != null)
			{
				return this.Amperage.GetPowerSource();
			}
			return new List<DrawObjectBase>();
		}

		public override List<DrawObjectBase> GetRecipientsPower()
		{
			List<DrawObjectBase> recipientsPower = base.GetRecipientsPower();
			this.method_15(this.Amperage, recipientsPower);
			return recipientsPower;
		}

		private void method_15(Amperage amperage_1, List<DrawObjectBase> list_2)
		{
			list_2.Add(amperage_1.Conductor);
			foreach (Amperage amperage_2 in amperage_1.NextAmperages)
			{
				this.method_15(amperage_2, list_2);
			}
		}

		public override void OnMouseMove(CanvasControl canvas, UnitPoint point, MouseButtons button)
		{
			if (button == MouseButtons.Left)
			{
				eCommandType eCommandType_ = canvas.eCommandType_0;
				if (eCommandType_ == eCommandType.draw)
				{
					this.MoveHandleTo(point, 2);
					base.OnMouseMove(canvas, point, button);
				}
			}
		}

		public override void OnMouseUp(CanvasControl canvas, UnitPoint point, ISnapPoint snappoint, MouseButtons button)
		{
			base.OnMouseUp(canvas, point, snappoint, button);
		}

		public override bool ShowPropertyForm(Point location)
		{
			if (new FormShinaProperties(this, this.Layer.Parent.SqlSettings)
			{
				Location = location
			}.ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
				return true;
			}
			return false;
		}

		internal override void vmethod_1()
		{
			foreach (SplitterShinaTool splitterShinaTool in this.splitters)
			{
				foreach (DrawObjectBase drawObjectBase in splitterShinaTool.ChildObjects)
				{
					if (drawObjectBase.GetType() == typeof(PointShinaTool) && ((PointShinaTool)drawObjectBase).CouplingRelations.Count > 0)
					{
						this.method_16((PointShinaTool)drawObjectBase);
					}
				}
			}
			foreach (DrawObjectBase drawObjectBase2 in this.ChildObjects)
			{
				if (drawObjectBase2.GetType() == typeof(PointShinaTool) && ((PointShinaTool)drawObjectBase2).CouplingRelations.Count > 0)
				{
					this.method_16((PointShinaTool)drawObjectBase2);
				}
			}
		}

		internal void method_16(PointShinaTool pointShinaTool_1)
		{
			if (pointShinaTool_1.BranchesCount == 0)
			{
				return;
			}
			if (this.Amperage != null && (this.Amperage.method_0().Count<Amperage>() == 0 || this.Amperage.method_0().First<Amperage>().Conductor != pointShinaTool_1[0].Parent))
			{
				if (pointShinaTool_1[0].Parent is LineTool && !((LineTool)pointShinaTool_1[0].Parent).Amperages.ContainsKey(pointShinaTool_1))
				{
					Amperage amperage = this.Amperage.method_1(pointShinaTool_1[0].Parent);
					if (amperage != null)
					{
						((LineTool)pointShinaTool_1[0].Parent).AddAmperage(pointShinaTool_1, amperage);
						return;
					}
				}
				else if (pointShinaTool_1.CouplingRelations[0].amperagePoint == null && ((LineTool)pointShinaTool_1[0].Parent).Amperages[pointShinaTool_1].method_0() != this.Amperage)
				{
					throw new Exception("короткое замыкание при передаче на другой объект");
				}
			}
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(this.TypeShinaTool);
		}

		private void method_17(RectangleTool rectangleTool_0, ResizeRectangleEventsArgs resizeRectangleEventsArgs_0)
		{
			this.ReCalcCellShina();
		}

		private RectangleF method_18(RectangleF rectangleF_0, UnitPoint unitPoint_3, int int_2)
		{
			PointF point = unitPoint_3.Point;
			float num = rectangleF_0.Left;
			float num2 = rectangleF_0.Top;
			float num3 = rectangleF_0.Right;
			float num4 = rectangleF_0.Bottom;
			switch (int_2)
			{
			case 1:
				num = point.X;
				num2 = point.Y;
				break;
			case 2:
				num2 = point.Y;
				break;
			case 3:
				num3 = point.X;
				num2 = point.Y;
				break;
			case 4:
				num3 = point.X;
				break;
			case 5:
				num3 = point.X;
				num4 = point.Y;
				break;
			case 6:
				num4 = point.Y;
				break;
			case 7:
				num = point.X;
				num4 = point.Y;
				break;
			case 8:
				num = point.X;
				break;
			}
			return new RectangleF(num, num2, num3 - num, num4 - num2);
		}

		protected void ReCalcCellShina()
		{
			if (this.unitPoint_0.Y != this.unitPoint_1.Y && this.unitPoint_0.X != this.unitPoint_1.X)
			{
				foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
				{
					if (drawObjectBase.GetType() == typeof(PointShinaTool))
					{
						double y = (this.unitPoint_1.Y - this.unitPoint_0.Y) * (double)((PointShinaTool)drawObjectBase).Delta + this.unitPoint_0.Y;
						double x = (this.unitPoint_1.X - this.unitPoint_0.X) * (double)((PointShinaTool)drawObjectBase).Delta + this.unitPoint_0.X;
						((PointShinaTool)drawObjectBase).Point = new UnitPoint(x, y);
					}
				}
				return;
			}
			if (this.unitPoint_0.Y != this.unitPoint_1.Y)
			{
				foreach (DrawObjectBase drawObjectBase2 in this.ChildObjects)
				{
					if (drawObjectBase2.GetType() == typeof(PointShinaTool))
					{
						double y2 = (this.unitPoint_1.Y - this.unitPoint_0.Y) * (double)((PointShinaTool)drawObjectBase2).Delta + this.unitPoint_0.Y;
						((PointShinaTool)drawObjectBase2).Point = new UnitPoint(this.unitPoint_0.X, y2);
					}
				}
			}
			if (this.unitPoint_0.X != this.unitPoint_1.X)
			{
				foreach (DrawObjectBase drawObjectBase3 in this.ChildObjects)
				{
					if (drawObjectBase3.GetType() == typeof(PointShinaTool))
					{
						double x2 = (this.unitPoint_1.X - this.unitPoint_0.X) * (double)((PointShinaTool)drawObjectBase3).Delta + this.unitPoint_0.X;
						((PointShinaTool)drawObjectBase3).Point = new UnitPoint(x2, this.unitPoint_0.Y);
					}
				}
			}
		}

		protected override void vmethod_4()
		{
			base.vmethod_4();
			((XmlElement)this.currentXmlScheme).SetAttribute("X1", Math.Round(this.P1.X, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("Y1", Math.Round(this.P1.Y, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("X2", Math.Round(this.P2.X, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("Y2", Math.Round(this.P2.Y, 4).ToString(new CultureInfo(1033)));
			if (this.TextProperty.Visible)
			{
				((XmlElement)this.currentXmlScheme).SetAttribute("textPos", ((int)this.TextProperty.Position).ToString());
			}
			if (this.TextVoltProperty.Visible)
			{
				((XmlElement)this.currentXmlScheme).SetAttribute("TextVoltVis", this.TextVoltProperty.Visible.ToString());
				((XmlElement)this.currentXmlScheme).SetAttribute("TextVoltPos", ((int)this.TextVoltProperty.Position).ToString());
			}
			if (this.LimitedEditing)
			{
				((XmlElement)this.currentXmlScheme).SetAttribute("limEd", this.LimitedEditing.ToString());
			}
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(PointShinaTool))
				{
					if (((PointShinaTool)drawObjectBase).CouplingRelations.Count > 0)
					{
						XmlElement xmlElement = this.xmlCoords.CreateElement("point");
						xmlElement.SetAttribute("ID", drawObjectBase.IdBase.ToString());
						this.currentXmlScheme.AppendChild(xmlElement);
					}
					else if (((PointShinaTool)drawObjectBase).Branches.Count<Branch>() == 0)
					{
						XmlElement xmlElement2 = this.xmlCoords.CreateElement("WP");
						PointShinaTool pointShinaTool = (PointShinaTool)drawObjectBase;
						xmlElement2.SetAttribute("X", Math.Round(pointShinaTool.Point.X, 4).ToString(new CultureInfo(1033)));
						xmlElement2.SetAttribute("Y", Math.Round(pointShinaTool.Point.Y, 4).ToString(new CultureInfo(1033)));
						if (pointShinaTool.Color != Color.White)
						{
							xmlElement2.SetAttribute("Color", pointShinaTool.Color.ToArgb().ToString());
						}
						if (!string.IsNullOrEmpty(pointShinaTool.Text))
						{
							xmlElement2.SetAttribute("text", pointShinaTool.Text);
							if (pointShinaTool.TextProperty.Visible)
							{
								xmlElement2.SetAttribute("textPos", ((int)pointShinaTool.TextProperty.Position).ToString());
							}
							if (!pointShinaTool.UseSettingsText)
							{
								xmlElement2.SetAttribute("FontName", pointShinaTool.TextProperty.FontName);
								xmlElement2.SetAttribute("FontSize", pointShinaTool.TextProperty.FontSize.ToString(new CultureInfo(1033)));
								xmlElement2.SetAttribute("FontBold", pointShinaTool.TextProperty.FontBold.ToString());
								xmlElement2.SetAttribute("FontItalic", pointShinaTool.TextProperty.FontItalic.ToString());
								xmlElement2.SetAttribute("FontUnderline", pointShinaTool.TextProperty.FontUnderline.ToString());
								xmlElement2.SetAttribute("FontColor", pointShinaTool.TextProperty.Color.ToArgb().ToString());
							}
						}
						this.currentXmlScheme.AppendChild(xmlElement2);
					}
					else if (((PointShinaTool)drawObjectBase).Branches.Count<Branch>() > 0 && ((PointShinaTool)drawObjectBase).Branches.First<Branch>().Parent.GetType() == typeof(SplitterShinaTool))
					{
						SplitterShinaTool splitterShinaTool = (SplitterShinaTool)((PointShinaTool)drawObjectBase).Branches.First<Branch>().Parent;
						XmlElement xmlElement3 = this.xmlCoords.CreateElement("splitter");
						splitterShinaTool.GetXml(xmlElement3);
						this.currentXmlScheme.AppendChild(xmlElement3);
					}
				}
			}
		}

		public override void Align()
		{
			if (this.P1.X == this.P2.X)
			{
				return;
			}
			if (this.P1.Y == this.P2.Y)
			{
				return;
			}
			if (Math.Abs(this.P1.X - this.P2.X) > Math.Abs(this.P1.Y - this.P2.Y))
			{
				this.P2 = new UnitPoint(this.P2.X, this.P1.Y);
			}
			else
			{
				this.P2 = new UnitPoint(this.P1.X, this.P2.Y);
			}
			this.Layer.Parent.DoInvalidate(true);
		}

		protected override void Dispose(bool disposing)
		{
			if (!this.disposed && disposing)
			{
				this.amperage_0 = null;
				this.pointShinaTool_0 = null;
				while (this.splitters.Count > 0)
				{
					this.splitters[0].Dispose();
					this.splitters.RemoveAt(0);
				}
				this.textFont_1 = null;
			}
			base.Dispose(disposing);
		}

		[CompilerGenerated]
		private DrawObjectBaseEventHandler drawObjectBaseEventHandler_4;

		protected float widthShina;

		private UnitPoint unitPoint_0;

		private UnitPoint unitPoint_1;

		private PointShinaTool pointShinaTool_0;

		private UnitPoint unitPoint_2;

		private eTypeShinaTool eTypeShinaTool_0;

		private TextFont textFont_1;

		private Color color_3;

		[NonSerialized]
		private Amperage amperage_0;

		private bool bool_7;

		public List<SplitterShinaTool> splitters;
	}
}
