using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using Passport.Forms;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool.FormsObj;

namespace SchemeCtrl2.DrawTool
{
	[Serializable]
	public abstract class ObjectOnLine : DrawObjectBase
	{
		public event EventHandler OnChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		public virtual ComplexSwitchgearTool ComplexSwitchgear
		{
			get
			{
				return this.complexSwitchgearTool_0;
			}
		}

		public override string Text
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		public override TelemetryValues TelemetryValues
		{
			get
			{
				return base.TelemetryValues;
			}
			set
			{
				if (value.SwitchOn != this.On)
				{
					if (value.SwitchOn == true)
					{
						this.On = true;
					}
					if (value.SwitchOn == false)
					{
						this.On = false;
					}
				}
				base.TelemetryValues = value;
			}
		}

		public override TextFont TextProperty
		{
			get
			{
				if (this.Layer != null && base.UseSettingsText)
				{
					TextFont textPropertyObjectInLine = this.Layer.Parent.Settings.TextPropertyObjectInLine;
					base.TextProperty = new TextFont(textPropertyObjectInLine.FontName, textPropertyObjectInLine.FontSize, textPropertyObjectInLine.FontBold, textPropertyObjectInLine.FontItalic, textPropertyObjectInLine.FontUnderline, base.TextProperty.Position, base.TextProperty.FontVirtical, base.TextProperty.Visible, textPropertyObjectInLine.Color);
					return base.TextProperty;
				}
				return base.TextProperty;
			}
			set
			{
				base.TextProperty = value;
			}
		}

		public TextFont TextPropertyNormalSection
		{
			get
			{
				if (this.Layer != null && base.UseSettingsText)
				{
					TextFont textPropertyNormalSection = this.Layer.Parent.Settings.TextPropertyNormalSection;
					this.textFont_1 = new TextFont(textPropertyNormalSection.FontName, textPropertyNormalSection.FontSize, textPropertyNormalSection.FontBold, textPropertyNormalSection.FontItalic, textPropertyNormalSection.FontUnderline, this.textFont_1.Position, this.textFont_1.FontVirtical, this.textFont_1.Visible, textPropertyNormalSection.Color);
				}
				return this.textFont_1;
			}
			set
			{
				this.textFont_1 = value;
			}
		}

		public Color ColorOff
		{
			get
			{
				if (this.Layer != null && base.UseSettingColor)
				{
					return this.Layer.Parent.Settings.ObjectOnLineColorOff;
				}
				return this.xiHnzemgkg;
			}
			set
			{
				this.xiHnzemgkg = value;
			}
		}

		public Color ColorOffN
		{
			get
			{
				if (this.Layer != null && base.UseSettingColor)
				{
					return this.Layer.Parent.Settings.ObjectOnLineColorOffN;
				}
				return this.color_3;
			}
			set
			{
				this.color_3 = value;
			}
		}

		public bool NormalSectionModeOn
		{
			get
			{
				return this.bool_12;
			}
			set
			{
				this.bool_12 = value;
			}
		}

		public bool IsNormalSection
		{
			get
			{
				return this.bool_10;
			}
			set
			{
				this.bool_10 = value;
			}
		}

		public ePositionText PositionDamage
		{
			get
			{
				return this.ePositionText_0;
			}
			set
			{
				this.ePositionText_0 = value;
			}
		}

		public ePositionText PositionKey
		{
			get
			{
				return this.ePositionText_1;
			}
			set
			{
				this.ePositionText_1 = value;
			}
		}

		public bool ContainsGrounding
		{
			get
			{
				return this.bool_13;
			}
			set
			{
				this.bool_13 = value;
				if (!this.bool_13)
				{
					this.ContainsGroundingOn = false;
				}
			}
		}

		public bool ContainsGroundingOn
		{
			get
			{
				return !this.On && this.ContainsGrounding && this.bool_14;
			}
			set
			{
				if (!value)
				{
					this.bool_14 = value;
					return;
				}
				if (!this.On && this.ContainsGrounding)
				{
					this.bool_14 = value;
					return;
				}
				this.bool_14 = false;
			}
		}

		public bool MappingState
		{
			get
			{
				return this.bool_11;
			}
			set
			{
				this.bool_11 = value;
				if (!this.bool_11)
				{
					this.lineToolState_0 = new LineToolState();
				}
			}
		}

		public virtual LineToolState State
		{
			get
			{
				if (this.bool_11)
				{
					return this.lineToolState_0;
				}
				return new LineToolState();
			}
			set
			{
				if (this.bool_11)
				{
					this.lineToolState_0 = value;
				}
			}
		}

		public List<UnitPoint> Points
		{
			get
			{
				return this.list_2;
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
				if (value == null)
				{
					DrawObjectBase drawObjectBase = (Branch)this.Parent;
					base.Parent = null;
					this.Angle = 0f;
					((LineTool)drawObjectBase.Parent).vmethod_1();
					return;
				}
				base.Parent = value;
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
				if (base.Master == value)
				{
					return;
				}
				if (this.Master != null && this.Master.GetType().BaseType == typeof(ObjectOnLine))
				{
					((ObjectOnLine)this.Master).OnChanged -= this.method_7;
					((ObjectOnLine)this.Master).ObjectRemoved -= this.method_12;
				}
				base.Master = value;
				if (this.Master != null && this.Master.GetType().BaseType == typeof(ObjectOnLine))
				{
					this.IsNormalSection = ((ObjectOnLine)this.Master).IsNormalSection;
					((ObjectOnLine)this.Master).OnChanged += this.method_7;
					((ObjectOnLine)this.Master).ObjectRemoved += this.method_12;
				}
			}
		}

		public virtual bool On
		{
			get
			{
				if (!this.bool_12)
				{
					return this.bool_7;
				}
				return !this.bool_10;
			}
			set
			{
				if (this.bool_7 == value)
				{
					return;
				}
				this.bool_7 = value;
				if (this.Parent != null && ((Branch)this.Parent).CouplingRelation != null)
				{
					if (!this.bool_7)
					{
						if (((Branch)this.Parent).CouplingRelation.amperagePoint != null)
						{
							LineTool lineTool = (LineTool)((Branch)this.Parent).Parent;
							PointTool amperagePoint = ((Branch)this.Parent).CouplingRelation.amperagePoint;
							lineTool.Amperages[amperagePoint].method_5();
							foreach (CouplingRelation couplingRelation in lineTool.CouplingRelations)
							{
								if (couplingRelation.amperagePoint == amperagePoint)
								{
									couplingRelation.amperagePoint = null;
								}
							}
							lineTool.method_13(amperagePoint);
						}
					}
					else
					{
						try
						{
							((LineTool)((Branch)this.Parent).Parent).vmethod_1();
						}
						catch
						{
							this.On = false;
						}
					}
					if (this.eventHandler_0 != null)
					{
						this.eventHandler_0(this, new EventArgs());
					}
					return;
				}
			}
		}

		private void method_7(object sender, EventArgs e)
		{
			this.On = ((ObjectOnLine)sender).On;
		}

		public virtual double Delta
		{
			get
			{
				return this.double_0;
			}
			set
			{
				if (double.IsInfinity(value) && double.IsNaN(value))
				{
					if (double.IsInfinity(this.double_0) && double.IsNaN(this.double_0))
					{
						this.Delta = 0.5;
					}
					return;
				}
				this.double_0 = value;
				if (this.complexSwitchgearTool_0 != null)
				{
					this.complexSwitchgearTool_0.Delta = this.double_0;
				}
				if (this.Parent != null)
				{
					double num = this.double_0;
					UnitPoint point = ((Branch)this.Parent).Destination.Point;
					UnitPoint point2 = ((Branch)this.Parent).Source.Point;
					num = 1.0 - this.double_0;
					double num2 = Math.Sqrt(Math.Pow(point.X - point2.X, 2.0) + Math.Pow(point.Y - point2.Y, 2.0)) * num;
					if (Math.Round(point2.X, 4) == Math.Round(point.X, 4))
					{
						this.CenterPoint = new UnitPoint(point2.X, point.Y + num * (point2.Y - point.Y));
					}
					if (Math.Round(point2.Y, 4) == Math.Round(point.Y, 4))
					{
						this.CenterPoint = new UnitPoint(point.X + num * (point2.X - point.X), point2.Y);
					}
					if (Math.Round(point2.X, 4) != Math.Round(point.X, 4) && Math.Round(point2.Y, 4) != Math.Round(point.Y, 4))
					{
						double num3 = 1.0 / (Math.Sqrt(Math.Pow((point2.Y - point.Y) / (point2.X - point.X), 2.0) + 1.0) / num2);
						if (point2.X < point.X)
						{
							num3 *= -1.0;
						}
						double num4 = 1.0 / (Math.Sqrt(Math.Pow((point2.X - point.X) / (point2.Y - point.Y), 2.0) + 1.0) / num2);
						if (point2.Y < point.Y)
						{
							num4 *= -1.0;
						}
						this.CenterPoint = new UnitPoint(point.X + num3, point.Y + num4);
					}
				}
			}
		}

		public virtual float Angle
		{
			get
			{
				return this.float_1;
			}
			set
			{
				float num = 0f;
				if (this.float_1 >= -360f && this.float_1 <= 360f && value >= -360f && value <= 360f)
				{
					num = this.float_1 - value;
					this.float_1 = value;
				}
				else if (value >= -360f && value <= 360f)
				{
					num = 180f - value;
					this.float_1 = value;
				}
				if (this.complexSwitchgearTool_0 != null)
				{
					this.complexSwitchgearTool_0.Angle = this.float_1;
				}
				if (num != 0f)
				{
					PointF[] array = new PointF[this.Points.Count];
					int num2 = 0;
					foreach (UnitPoint unitPoint in this.Points)
					{
						float num3 = unitPoint.Point.X - this.unitPoint_0.Point.X;
						float num4 = unitPoint.Point.Y - this.unitPoint_0.Point.Y;
						float num5 = Convert.ToSingle(Math.Cos((double)num * 3.1415926535897931 / 180.0));
						float num6 = Convert.ToSingle(Math.Sin((double)num * 3.1415926535897931 / 180.0));
						float x = this.unitPoint_0.Point.X + num3 * num5 - num4 * num6;
						float y = this.unitPoint_0.Point.Y + num3 * num6 + num4 * num5;
						array[num2] = new PointF(x, y);
						num2++;
					}
					this.Points.Clear();
					foreach (PointF p in array)
					{
						this.Points.Add(new UnitPoint(p));
					}
					array = new PointF[this.list_4.Count];
					num2 = 0;
					foreach (UnitPoint unitPoint2 in this.list_4)
					{
						float num7 = unitPoint2.Point.X - this.unitPoint_0.Point.X;
						float num8 = unitPoint2.Point.Y - this.unitPoint_0.Point.Y;
						float num9 = Convert.ToSingle(Math.Cos((double)num * 3.1415926535897931 / 180.0));
						float num10 = Convert.ToSingle(Math.Sin((double)num * 3.1415926535897931 / 180.0));
						float x2 = this.unitPoint_0.Point.X + num7 * num9 - num8 * num10;
						float y2 = this.unitPoint_0.Point.Y + num7 * num10 + num8 * num9;
						array[num2] = new PointF(x2, y2);
						num2++;
					}
					this.list_4.Clear();
					foreach (PointF p2 in array)
					{
						this.list_4.Add(new UnitPoint(p2));
					}
				}
			}
		}

		public virtual UnitPoint CenterPoint
		{
			get
			{
				return this.unitPoint_0;
			}
			set
			{
				UnitPoint unitPoint = this.unitPoint_0;
				this.unitPoint_0 = value;
				if (!this.systemChanging)
				{
					for (int i = 0; i < this.Points.Count; i++)
					{
						double num = this.Points[i].X - unitPoint.X;
						double num2 = this.Points[i].Y - unitPoint.Y;
						this.Points[i] = new UnitPoint(num + this.unitPoint_0.X, num2 + this.unitPoint_0.Y);
					}
					for (int j = 0; j < this.list_4.Count; j++)
					{
						double num = this.list_4[j].X - unitPoint.X;
						double num2 = this.list_4[j].Y - unitPoint.Y;
						this.list_4[j] = new UnitPoint(num + this.unitPoint_0.X, num2 + this.unitPoint_0.Y);
					}
				}
				if (this.Parent != null)
				{
					double d = Math.Sqrt(Math.Pow(((Branch)this.Parent).Source.Point.X - this.CenterPoint.X, 2.0) + Math.Pow(((Branch)this.Parent).Source.Point.Y - this.CenterPoint.Y, 2.0)) / Math.Sqrt(Math.Pow(((Branch)this.Parent).Source.Point.X - ((Branch)this.Parent).Destination.Point.X, 2.0) + Math.Pow(((Branch)this.Parent).Source.Point.Y - ((Branch)this.Parent).Destination.Point.Y, 2.0));
					if (!double.IsNaN(d) && !double.IsInfinity(d))
					{
						this.double_0 = d;
					}
				}
				if (this.complexSwitchgearTool_0 != null)
				{
					this.complexSwitchgearTool_0.CenterPoint = this.unitPoint_0;
				}
			}
		}

		public override bool Selected
		{
			get
			{
				return base.Selected;
			}
			set
			{
				base.Selected = value;
			}
		}

		public override Color Color
		{
			get
			{
				if (this.Layer != null && base.UseSettingColor)
				{
					if (this.Layer.Parent.Settings.ObjectOnLineColorLine && this.Parent != null && this.Parent.GetType() == typeof(Branch))
					{
						Branch branch = (Branch)this.Parent;
						if (branch.CheckVoltageInPoint(this.unitPoint_0))
						{
							return branch.Color;
						}
						return branch.ColorOff;
					}
					else
					{
						TypeSwitch typeSwitch = this.TypeSwitch;
						switch (typeSwitch)
						{
						case TypeSwitch.LubricantSwitchTool:
							return this.Layer.Parent.Settings.LubricantSwitchToolColor;
						case TypeSwitch.LinearDisconnectorTool:
							return this.Layer.Parent.Settings.LinearDisconnectorToolColor;
						case TypeSwitch.LoadSwitchTool:
							return this.Layer.Parent.Settings.LoadSwitchToolColor;
						case TypeSwitch.GroundingTool:
							return this.Layer.Parent.Settings.GroundingToolColor;
						case TypeSwitch.TransformerTool:
							return this.Layer.Parent.Settings.TransformerToolColor;
						case TypeSwitch.DamageTool:
							return this.Layer.Parent.Settings.DamageToolColor;
						case TypeSwitch.VacuumSwitchTool:
							return this.Layer.Parent.Settings.VacuumSwitchToolColor;
						case TypeSwitch.OutsideLineDisconnectorTool:
							return this.Layer.Parent.Settings.OutsideLineDisconnectorToolColor;
						default:
							if (typeSwitch == TypeSwitch.EndTrimTool)
							{
								return this.Layer.Parent.Settings.EndTrimToolColor;
							}
							break;
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

		public virtual TypeSwitch TypeSwitch
		{
			get
			{
				return TypeSwitch.None;
			}
		}

		public virtual bool VertMirror
		{
			get
			{
				return this.bool_8;
			}
			set
			{
				if (this.bool_8 != value)
				{
					bool flag;
					if (flag = (this.complexSwitchgearTool_0 != null && this.complexSwitchgearTool_0.RollingOut))
					{
						this.complexSwitchgearTool_0.RollingOut = false;
					}
					GraphicsPath graphicsPath = new GraphicsPath();
					graphicsPath.AddLine(((Branch)this.Parent).Source.Point.Point, ((Branch)this.Parent).Destination.Point.Point);
					Matrix matrix = new Matrix();
					matrix.RotateAt(90f, this.CenterPoint.Point);
					graphicsPath.Transform(matrix);
					UnitPoint unitPoint = new UnitPoint(graphicsPath.PathPoints[0]);
					UnitPoint unitPoint_ = new UnitPoint(graphicsPath.PathPoints[1]);
					for (int i = 0; i < this.list_2.Count; i++)
					{
						UnitPoint unitPoint2 = this.list_2[i];
						this.list_2.RemoveAt(i);
						UnitPoint unitPoint3 = Class79.smethod_4(unitPoint, unitPoint_, unitPoint2);
						double num = unitPoint2.X - unitPoint3.X;
						double num2 = unitPoint2.Y - unitPoint3.Y;
						unitPoint2.Point = new PointF((float)(unitPoint3.X - num), (float)(unitPoint3.Y - num2));
						this.list_2.Insert(i, unitPoint2);
					}
					if (flag)
					{
						this.complexSwitchgearTool_0.RollingOut = true;
					}
					this.bool_8 = value;
				}
			}
		}

		public virtual bool GorMirror
		{
			get
			{
				return this.bool_9;
			}
			set
			{
				if (this.bool_9 != value)
				{
					bool flag;
					if (flag = (this.complexSwitchgearTool_0 != null && this.complexSwitchgearTool_0.RollingOut))
					{
						this.complexSwitchgearTool_0.RollingOut = false;
					}
					for (int i = 0; i < this.list_2.Count; i++)
					{
						UnitPoint unitPoint = this.list_2[i];
						this.list_2.RemoveAt(i);
						UnitPoint unitPoint2 = Class79.smethod_4(((Branch)this.Parent).Source.Point, ((Branch)this.Parent).Destination.Point, unitPoint);
						double num = unitPoint.X - unitPoint2.X;
						double num2 = unitPoint.Y - unitPoint2.Y;
						unitPoint.Point = new PointF((float)(unitPoint2.X - num), (float)(unitPoint2.Y - num2));
						this.list_2.Insert(i, unitPoint);
					}
					if (flag)
					{
						this.complexSwitchgearTool_0.RollingOut = true;
					}
					this.bool_9 = value;
				}
			}
		}

		public ObjectOnLine()
		{
			
			this.list_2 = new List<UnitPoint>();
			this.list_3 = new List<UnitPoint>();
			this.double_0 = double.NaN;
			this.float_1 = float.NaN;
			this.xiHnzemgkg = Color.Black;
			this.color_3 = Color.Black;
			this.textFont_1 = new TextFont("Arial", 15f, false, false, false, ePositionText.T, false, false, Color.White);
			this.ePositionText_0 = ePositionText.None;
			this.ePositionText_1 = ePositionText.None;
			this.string_2 = "Выключатель";
			this.list_4 = new List<UnitPoint>();
			
			this.CreateImagePoints();
		}

		public ObjectOnLine(Branch branch)
		{
			
			this.list_2 = new List<UnitPoint>();
			this.list_3 = new List<UnitPoint>();
			this.double_0 = double.NaN;
			this.float_1 = float.NaN;
			this.xiHnzemgkg = Color.Black;
			this.color_3 = Color.Black;
			this.textFont_1 = new TextFont("Arial", 15f, false, false, false, ePositionText.T, false, false, Color.White);
			this.ePositionText_0 = ePositionText.None;
			this.ePositionText_1 = ePositionText.None;
			this.string_2 = "Выключатель";
			this.list_4 = new List<UnitPoint>();
			
			this.Parent = branch;
			this.CreateImagePoints();
		}

		public ObjectOnLine(DataRow r, Branch branch)
		{
			
			this.list_2 = new List<UnitPoint>();
			this.list_3 = new List<UnitPoint>();
			this.double_0 = double.NaN;
			this.float_1 = float.NaN;
			this.xiHnzemgkg = Color.Black;
			this.color_3 = Color.Black;
			this.textFont_1 = new TextFont("Arial", 15f, false, false, false, ePositionText.T, false, false, Color.White);
			this.ePositionText_0 = ePositionText.None;
			this.ePositionText_1 = ePositionText.None;
			this.string_2 = "Выключатель";
			this.list_4 = new List<UnitPoint>();
			
			Convert.ToInt32(r["id"]);
			this.Parent = branch;
			this.Layer = branch.Parent.Layer;
			XmlDocument xmlDocument = new XmlDocument();
			this.NormalSectionModeOn = (this.Layer.Parent.SimulationMode == eSimulationMode.Normal);
			if (!r.IsNull("OnOff"))
			{
				this.On = Convert.ToBoolean(r["OnOff"]);
			}
			xmlDocument.LoadXml((string)r["SchemaXml"]);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/Obj");
			XmlAttribute xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("delta");
			this.CreateImagePoints();
			double num = (double)Convert.ToSingle(xmlAttribute.Value, new CultureInfo(1033));
			if (!double.IsNaN(num) && !double.IsInfinity(num))
			{
				this.Delta = num;
			}
			else
			{
				this.Delta = 0.5;
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("MappingState");
			if (xmlAttribute != null)
			{
				this.MappingState = Convert.ToBoolean(xmlAttribute.Value);
				if (this.MappingState && this.Parent != null && this.Parent.Parent != null && this.Parent.Parent is LineTool)
				{
					States state = States.none;
					TypeSwitch typeSwitch = this.TypeSwitch;
					if (typeSwitch <= TypeSwitch.DamageTool)
					{
						if (typeSwitch != TypeSwitch.GroundingTool)
						{
							if (typeSwitch == TypeSwitch.DamageTool)
							{
								state = States.break_down;
							}
						}
						else
						{
							state = States.grounded;
						}
					}
					else if (typeSwitch != TypeSwitch.OffTool)
					{
						if (typeSwitch == TypeSwitch.NotPhasedTool)
						{
							state = States.not_phased;
						}
					}
					else
					{
						state = States.off;
					}
					this.State = new LineToolState();
					this.State.state = state;
					this.State.Mapping = this;
					((LineTool)this.Parent.Parent).AddState(this);
				}
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("IsNormal");
			if (xmlAttribute != null)
			{
				this.IsNormalSection = Convert.ToBoolean(xmlAttribute.Value);
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("NormalPosition");
			if (xmlAttribute != null)
			{
				this.TextPropertyNormalSection.Position = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("textVis");
			if (xmlAttribute != null)
			{
				this.TextProperty.Visible = Convert.ToBoolean(xmlAttribute.Value);
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("textPos");
			if (xmlAttribute != null)
			{
				this.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("PosDamage");
			if (xmlAttribute != null)
			{
				this.PositionDamage = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("PosKey");
			if (xmlAttribute != null)
			{
				this.PositionKey = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("ComplexSwitchgear");
			if (xmlAttribute != null && Convert.ToBoolean(xmlAttribute.Value))
			{
				this.SetComplexSwitchgear();
			}
			if (this.ComplexSwitchgear != null)
			{
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("ComplexSwitchgearRollingOutReason");
				if (xmlAttribute != null)
				{
					this.ComplexSwitchgear.RollingOutReason = (ComplexSwitchgearTool.eRollingOutReason)Convert.ToInt32(xmlAttribute.Value);
				}
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("ContainsGrounding");
			this.ContainsGrounding = (xmlAttribute != null && Convert.ToBoolean(xmlAttribute.Value));
			if (this.ContainsGrounding)
			{
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("ContainsGroundingOn");
				this.ContainsGroundingOn = (xmlAttribute != null && Convert.ToBoolean(xmlAttribute.Value));
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("Color");
			if (xmlAttribute != null)
			{
				base.UseSettingColor = false;
				this.Color = Color.FromArgb(Convert.ToInt32(xmlAttribute.Value));
			}
			else
			{
				base.UseSettingColor = true;
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontName");
			if (xmlAttribute != null)
			{
				base.UseSettingsText = false;
				this.TextProperty.FontName = xmlAttribute.Value;
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontSize");
				if (xmlAttribute != null)
				{
					this.TextProperty.FontSize = Convert.ToSingle(xmlAttribute.Value, new CultureInfo(1033));
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontBold");
				if (xmlAttribute != null)
				{
					this.TextProperty.FontBold = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontItalic");
				if (xmlAttribute != null)
				{
					this.TextProperty.FontItalic = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontUnderline");
				if (xmlAttribute != null)
				{
					this.TextProperty.FontUnderline = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontColor");
				if (xmlAttribute != null)
				{
					this.TextProperty.Color = Color.FromArgb(Convert.ToInt32(xmlAttribute.Value));
				}
			}
			else
			{
				base.UseSettingsText = true;
			}
			this.RecalcAngle();
		}

		private void method_8(object sender, EventArgs e)
		{
			if (this.Layer == null)
			{
				return;
			}
			if (this.Layer.Parent == null)
			{
				return;
			}
			FormDockPassport formDockPassport = new FormDockPassport(this.Layer.Parent.SqlSettings, this.IdBase);
			Control mdiForm = base.GetMdiForm(this.Layer.Parent);
			if (mdiForm != null)
			{
				formDockPassport.MdiParent = (Form)mdiForm;
			}
			formDockPassport.Show();
		}

		private void method_9(object sender, EventArgs e)
		{
			this.ShowPropertyForm(((ToolStripMenuItem)sender).GetCurrentParent().Location);
		}

		protected override void RemoveContextMenus()
		{
		}

		private void method_10(object sender, EventArgs e)
		{
			this.ShowPropertyForm(((ToolStripMenuItem)sender).GetCurrentParent().Location);
		}

		public void ShiftPoints(double dx, double dy)
		{
			for (int i = 0; i < this.Points.Count; i++)
			{
				this.Points[i] = new UnitPoint(dx + this.Points[i].X, dy + this.Points[i].Y);
			}
		}

		public void RemoveComplexSwitchgear()
		{
			this.complexSwitchgearTool_0.RollingOut = false;
			this.complexSwitchgearTool_0 = null;
			this.Layer.Parent.DoInvalidate(true);
		}

		public void SetComplexSwitchgear()
		{
			this.complexSwitchgearTool_0 = new ComplexSwitchgearTool((Branch)this.Parent);
			this.complexSwitchgearTool_0.Delta = this.Delta;
			this.complexSwitchgearTool_0.Angle = this.Angle;
			this.complexSwitchgearTool_0.IntegratedSwitch = this;
			this.Layer.Parent.DoInvalidate(true);
		}

		public List<ObjectOnLine> SearchObjectsOnLine()
		{
			List<ObjectOnLine> list = new List<ObjectOnLine>();
			CouplingRelation couplingRelation = ((Branch)this.Parent).CouplingRelation;
			if (couplingRelation == null)
			{
				throw new Exception("Ветка без связи");
			}
			Type type = base.GetType();
			foreach (Branch branch in couplingRelation.method_3())
			{
				foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
				{
					if (drawObjectBase.GetType() == type && drawObjectBase != this)
					{
						list.Add((ObjectOnLine)drawObjectBase);
					}
				}
			}
			return list;
		}

		public List<ObjectOnLine> SearchObjectsOnLine(Type type)
		{
			if (type.BaseType != typeof(ObjectOnLine))
			{
				throw new Exception("Неверный параметр");
			}
			List<ObjectOnLine> list = new List<ObjectOnLine>();
			CouplingRelation couplingRelation = ((Branch)this.Parent).CouplingRelation;
			if (couplingRelation == null)
			{
				throw new Exception("Ветка без связи");
			}
			foreach (Branch branch in couplingRelation.method_3())
			{
				foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
				{
					if (drawObjectBase.GetType() == type && drawObjectBase != this)
					{
						list.Add((ObjectOnLine)drawObjectBase);
					}
				}
			}
			return list;
		}

		public void RecalcAngle()
		{
			if (this.Parent == null)
			{
				return;
			}
			Branch branch = (Branch)this.Parent;
			float num = Convert.ToSingle(Math.Round(Math.Atan(Math.Abs(branch.Source.Point.X - branch.Destination.Point.X) / Math.Abs(branch.Source.Point.Y - branch.Destination.Point.Y)) * 57.295779513082323));
			if (branch.Source.Point.X > branch.Destination.Point.X && branch.Source.Point.Y > branch.Destination.Point.Y)
			{
				num += 180f;
			}
			else if (branch.Source.Point.Y > branch.Destination.Point.Y)
			{
				num = 90f - (num - 90f);
			}
			else if (branch.Source.Point.X > branch.Destination.Point.X)
			{
				num = 270f - (num - 90f);
			}
			this.Angle = num;
		}

		public override void Align()
		{
			if (this.Parent.Parent.GetType() != typeof(LineCellTool))
			{
				return;
			}
			if (!(((Branch)this.Parent).Destination is PointShinaTool))
			{
				if (((Branch)this.Parent).Source.Parent != this.Parent.Parent)
				{
					this.VertMirror = false;
					this.GorMirror = false;
					return;
				}
			}
			this.VertMirror = true;
			this.GorMirror = true;
		}

		public override bool ShowPropertyForm(Point location)
		{
			bool on = this.On;
			if (new ObjectOnLinePropertyForm(this, this.Layer.Parent.SqlSettings)
			{
				Location = location
			}.ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
				if (on != this.On)
				{
					CanvasLog.SaveLogDispatcher(this.Layer.Parent.SqlSettings, new int?(this.IdBase), this.On ? "Включен" : "Выключен", "");
					if (this.Layer.Parent.Connected)
					{
						this.Layer.Parent.ProxySingleton.ObjectOnLineOnChange(this.IdBase, this.On, Class18.smethod_3());
					}
				}
				return true;
			}
			return false;
		}

		public override bool PointInObject(UnitPoint point)
		{
			if (this.Layer == null)
			{
				return false;
			}
			CanvasControl parent = this.Layer.Parent;
			bool flag = false;
			int i = 0;
			int index = this.list_2.Count - 1;
			while (i < this.list_2.Count)
			{
				if (((this.list_2[i].Y <= point.Y && point.Y < this.list_2[index].Y) || (this.list_2[index].Y <= point.Y && point.Y < this.list_2[i].Y)) && point.X > (this.list_2[index].X - this.list_2[i].X) * (point.Y - this.list_2[i].Y) / (this.list_2[index].Y - this.list_2[i].Y) + this.list_2[i].X)
				{
					flag = !flag;
				}
				index = i++;
			}
			return flag;
		}

		public override string GetFullName()
		{
			if (this.Parent != null)
			{
				return this.Parent.GetFullName() + ": " + this.ToString();
			}
			return base.GetFullName();
		}

		private PointTool method_11(UnitPoint unitPoint_1, Branch branch_0)
		{
			PointTool pointTool = (branch_0.Source.Point.X >= branch_0.Destination.Point.X) ? branch_0.Source : branch_0.Destination;
			PointTool pointTool2 = (branch_0.Source.Point.X < branch_0.Destination.Point.X) ? branch_0.Source : branch_0.Destination;
			PointTool pointTool3 = (branch_0.Source.Point.Y >= branch_0.Destination.Point.Y) ? branch_0.Source : branch_0.Destination;
			PointTool pointTool4 = (branch_0.Source.Point.Y < branch_0.Destination.Point.Y) ? branch_0.Source : branch_0.Destination;
			if (unitPoint_1.X > pointTool.Point.X)
			{
				return pointTool;
			}
			if (unitPoint_1.X < pointTool2.Point.X)
			{
				return pointTool2;
			}
			if (unitPoint_1.Y > pointTool3.Point.Y)
			{
				return pointTool3;
			}
			if (unitPoint_1.Y < pointTool4.Point.Y)
			{
				return pointTool4;
			}
			return null;
		}

		public void ChangeBranch(Branch branch)
		{
			Branch branch2 = (Branch)this.Parent;
			this.Parent = branch;
			if (this.complexSwitchgearTool_0 != null)
			{
				this.complexSwitchgearTool_0.Parent = branch;
			}
			if (branch2.CouplingRelation != branch.CouplingRelation && !this.bool_7)
			{
				((LineTool)branch2.Parent).vmethod_1();
				if (branch.CouplingRelation.amperagePoint != null)
				{
					LineTool lineTool = (LineTool)branch.Parent;
					PointTool amperagePoint = branch.CouplingRelation.amperagePoint;
					lineTool.Amperages[amperagePoint].method_5();
					foreach (CouplingRelation couplingRelation in lineTool.CouplingRelations)
					{
						if (couplingRelation.amperagePoint == amperagePoint)
						{
							couplingRelation.amperagePoint = null;
						}
					}
					lineTool.method_13(amperagePoint);
				}
			}
		}

		public override void Move(UnitPoint offset, bool selectedMove)
		{
			if (!this.Parent.Selected)
			{
				UnitPoint unitPoint_ = new UnitPoint(this.CenterPoint.X + offset.X, this.CenterPoint.Y + offset.Y);
				UnitPoint unitPoint = Class79.smethod_4(((Branch)this.Parent).Source.Point, ((Branch)this.Parent).Destination.Point, unitPoint_);
				PointTool pointTool = this.method_11(unitPoint, (Branch)this.Parent);
				if (pointTool != null)
				{
					Dictionary<Branch, UnitPoint> dictionary = new Dictionary<Branch, UnitPoint>();
					foreach (Branch branch in pointTool.Branches)
					{
						if (branch != this.Parent && branch.Parent != null && branch.Parent == this.Parent.Parent && (branch.CouplingRelation == ((Branch)this.Parent).CouplingRelation || !this.Parent.Parent.LimitedEditing))
						{
							UnitPoint unitPoint2 = Class79.smethod_4(branch.Source.Point, branch.Destination.Point, unitPoint_);
							if (this.method_11(unitPoint2, branch) == null)
							{
								dictionary.Add(branch, unitPoint2);
							}
						}
					}
					if (dictionary.Count < 1)
					{
						unitPoint = pointTool.Point;
					}
					else if (dictionary.Count == 1)
					{
						Branch branch2 = dictionary.Keys.First<Branch>();
						UnitPoint unitPoint3 = dictionary[branch2];
						this.ChangeBranch(branch2);
						unitPoint = unitPoint3;
						this.RecalcAngle();
					}
					else
					{
						Branch branch3 = dictionary.Keys.First<Branch>();
						UnitPoint unitPoint4 = dictionary[branch3];
						foreach (Branch branch4 in dictionary.Keys)
						{
							double num = Math.Abs(unitPoint_.X - unitPoint4.X);
							double num2 = Math.Abs(unitPoint_.Y - unitPoint4.Y);
							double num3 = Math.Abs(unitPoint_.X - dictionary[branch4].X);
							double num4 = Math.Abs(unitPoint_.Y - dictionary[branch4].Y);
							if (num + num2 > num3 + num4)
							{
								branch3 = branch4;
								unitPoint4 = dictionary[branch4];
							}
							this.ChangeBranch(branch3);
							unitPoint = unitPoint4;
							this.RecalcAngle();
						}
					}
				}
				if (base.GetType() == typeof(GroundingTool) && this.On && ((Branch)this.Parent).CheckVoltageInPoint(unitPoint))
				{
					unitPoint = this.CenterPoint;
				}
				UnitPoint centerPoint = this.CenterPoint;
				this.CenterPoint = unitPoint;
				if (base.GetType() != typeof(GroundingTool) && !this.On)
				{
					foreach (DrawObjectBase drawObjectBase in this.Parent.ChildObjects)
					{
						if (drawObjectBase.GetType() == typeof(GroundingTool) && ((GroundingTool)drawObjectBase).On && ((Branch)this.Parent).CheckVoltageInPoint(((GroundingTool)drawObjectBase).unitPoint_0))
						{
							this.CenterPoint = centerPoint;
							break;
						}
					}
				}
			}
		}

		public override void vmethod_0(XmlNode xmlNode, List<PointTool> pointList)
		{
			TypeSwitch typeSwitch = this.TypeSwitch;
			XmlElement xmlElement = xmlNode.OwnerDocument.CreateElement("Switch");
			xmlElement.SetAttribute("ID", this.IdBase.ToString());
			xmlElement.SetAttribute("delta", Math.Round(this.Delta, 4).ToString(new CultureInfo(1033)));
			XmlElement xmlElement2 = xmlElement;
			string name = "type";
			int num = (int)typeSwitch;
			xmlElement2.SetAttribute(name, num.ToString());
			xmlElement.SetAttribute("On", this.bool_7.ToString());
			xmlElement.SetAttribute("Text", this.Text);
			xmlElement.SetAttribute("textVis", this.TextProperty.Visible.ToString());
			xmlElement.SetAttribute("textPos", ((int)this.TextProperty.Position).ToString());
			xmlElement.SetAttribute("gorMirror", this.GorMirror.ToString());
			xmlElement.SetAttribute("vertMirror", this.VertMirror.ToString());
			xmlNode.AppendChild(xmlElement);
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			ObjectOnLine objectOnLine = ObjectOnLine.CreateObjectOnLine(this.TypeSwitch);
			objectOnLine.CenterPoint = this.CenterPoint;
			objectOnLine.Angle = this.Angle;
			objectOnLine.Color = this.Color;
			objectOnLine.double_0 = this.double_0;
			objectOnLine.Fill = base.Fill;
			objectOnLine.IdBase = this.IdBase;
			objectOnLine.On = this.On;
			objectOnLine.Master = this;
			objectOnLine.Text = this.Text;
			objectOnLine.TextProperty = new TextFont(this.TextProperty.FontName, this.TextProperty.FontSize, this.TextProperty.FontBold, this.TextProperty.FontItalic, this.TextProperty.FontUnderline, this.TextProperty.Position, this.TextProperty.FontVirtical, this.TextProperty.Visible, this.TextProperty.Color);
			if (base.GetType() == typeof(ComplexSwitchgearTool))
			{
				((ComplexSwitchgearTool)objectOnLine).IntegratedSwitch = (ObjectOnLine)((ComplexSwitchgearTool)this).IntegratedSwitch.Clone(SaveParentRelation);
			}
			objectOnLine.IsNormalSection = this.IsNormalSection;
			objectOnLine.TextPropertyNormalSection.Position = this.TextPropertyNormalSection.Position;
			objectOnLine.Visible = this.Visible;
			objectOnLine.UseSettingColor = base.UseSettingColor;
			objectOnLine.UseLayerWidth = base.UseLayerWidth;
			objectOnLine.Width = base.Width;
			if (SaveParentRelation)
			{
				objectOnLine.OnChanged += this.method_7;
				objectOnLine.ObjectRemoved += this.method_12;
			}
			return objectOnLine;
		}

		private void method_12(DrawObjectBase drawObjectBase_2)
		{
			if (drawObjectBase_2.GetType().BaseType == typeof(ObjectOnLine))
			{
				ObjectOnLine objectOnLine = (ObjectOnLine)drawObjectBase_2;
				objectOnLine.OnChanged -= this.method_7;
				objectOnLine.ObjectRemoved -= this.method_12;
			}
		}

		public override void Remove(bool delSql, bool bool_15)
		{
			DrawObjectBase drawObjectBase = (Branch)this.Parent;
			base.Remove(delSql, bool_15);
			this.Deleted = true;
			drawObjectBase.Parent.vmethod_1();
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if ((double)canvas.Zoom < 0.25)
			{
				return;
			}
			if (!this.Visible)
			{
				return;
			}
			using (SolidBrush solidBrush = new SolidBrush(this.Color))
			{
				if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
				{
					if ((drawMode & eDrawMode.Color) != eDrawMode.Color)
					{
						solidBrush.Color = Color.Black;
					}
				}
				else
				{
					if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
					{
						if (this.Selected)
						{
							solidBrush.Color = this.SelectedColor;
						}
						else if (this.IsNormalSection)
						{
							solidBrush.Color = this.ColorOffN;
						}
						else if (!this.On)
						{
							solidBrush.Color = this.ColorOff;
						}
						if (this.Flashing && canvas.ConvertColorFlash)
						{
							solidBrush.Color = canvas.Settings.BackFlashingColor;
						}
					}
					else
					{
						if (this.Selected)
						{
							solidBrush.Color = Color.Gray;
						}
						if (this.Flashing && canvas.ConvertColorFlash)
						{
							solidBrush.Color = Color.White;
						}
					}
					PointF[] points = ConvertCanvas.ConvertToScreen(canvas, this.list_4.ToArray<UnitPoint>());
					canvas.Graphics.FillPolygon(solidBrush, points);
					this.DrawText(canvas, drawMode);
					this.DrawTextNormalSection(canvas);
				}
			}
		}

		public static ObjectOnLine CreateObjectOnLine(TypeSwitch type)
		{
			if (type <= TypeSwitch.CircuitBreaker)
			{
				if (type <= TypeSwitch.EndTrimTool)
				{
					switch (type)
					{
					case TypeSwitch.ArrowTool:
						return new ArrowTool();
					case TypeSwitch.LinearDisconnectorToolWaxwork:
						return new LinearDisconnectorWaxworkTool();
					case TypeSwitch.LoadSwitchToolWaxwork:
						return new LoadSwitchWaxworkTool();
					case (TypeSwitch)6:
					case (TypeSwitch)7:
					case (TypeSwitch)8:
					case (TypeSwitch)9:
						break;
					case TypeSwitch.SeparatorTool:
						return new SeparatorTool();
					case TypeSwitch.ComplexSwitchgearTool:
						return new ComplexSwitchgearTool();
					default:
						switch (type)
						{
						case TypeSwitch.LubricantSwitchTool:
							return new LubricantSwitchTool();
						case TypeSwitch.LinearDisconnectorTool:
							return new LinearDisconnectorTool();
						case TypeSwitch.LoadSwitchTool:
							return new LoadSwitchTool();
						case TypeSwitch.GroundingTool:
							goto IL_170;
						case TypeSwitch.TransformerTool:
							return new TransformerTool();
						case TypeSwitch.DamageTool:
							return new DamageTool();
						case TypeSwitch.VacuumSwitchTool:
							return new VacuumSwitchTool();
						case TypeSwitch.OutsideLineDisconnectorTool:
							return new OutsideLineDisconnectorTool();
						default:
							if (type == TypeSwitch.EndTrimTool)
							{
								return new EndTrimTool();
							}
							break;
						}
						break;
					}
				}
				else
				{
					if (type == TypeSwitch.FuseTool)
					{
						return new FuseTool();
					}
					if (type == TypeSwitch.VoltageTransformerTool)
					{
						return new VoltageTransformerTool();
					}
					if (type == TypeSwitch.CircuitBreaker)
					{
						return new CircuitBreakerTool();
					}
				}
			}
			else if (type <= TypeSwitch.NotPhasedTool)
			{
				if (type == TypeSwitch.RPSTool)
				{
					return new RPSTool();
				}
				if (type == TypeSwitch.AmperageTransformer)
				{
					return new AmperageTransformerTool();
				}
				switch (type)
				{
				case TypeSwitch.DischargerTool:
					return new DischargerTool();
				case TypeSwitch.VoltageLimiterTool:
					return new VoltageLimiterTool();
				case TypeSwitch.OffTool:
					return new OffTool();
				case TypeSwitch.NotPhasedTool:
					return new NotPhasedTool();
				}
			}
			else
			{
				if (type == TypeSwitch.MagneticStarterTool)
				{
					return new MagneticStarterTool();
				}
				if (type == TypeSwitch.ElectricMeterTool)
				{
					return new Class13();
				}
				if (type == TypeSwitch.GroundingStateTool)
				{
					goto IL_170;
				}
			}
			return null;
			IL_170:
			return new GroundingTool();
		}

		public static ObjectOnLine CreateObjectOnLine(TypeSwitch type, Branch branch)
		{
			if (type <= TypeSwitch.CircuitBreaker)
			{
				if (type <= TypeSwitch.EndTrimTool)
				{
					switch (type)
					{
					case TypeSwitch.ArrowTool:
						return new ArrowTool(branch);
					case TypeSwitch.LinearDisconnectorToolWaxwork:
						return new LinearDisconnectorWaxworkTool(branch);
					case TypeSwitch.LoadSwitchToolWaxwork:
						return new LoadSwitchWaxworkTool(branch);
					case (TypeSwitch)6:
					case (TypeSwitch)7:
					case (TypeSwitch)8:
					case (TypeSwitch)9:
						break;
					case TypeSwitch.SeparatorTool:
						return new SeparatorTool(branch);
					case TypeSwitch.ComplexSwitchgearTool:
						return new ComplexSwitchgearTool(branch);
					default:
						switch (type)
						{
						case TypeSwitch.LubricantSwitchTool:
							return new LubricantSwitchTool(branch);
						case TypeSwitch.LinearDisconnectorTool:
							return new LinearDisconnectorTool(branch);
						case TypeSwitch.LoadSwitchTool:
							return new LoadSwitchTool(branch);
						case TypeSwitch.GroundingTool:
							goto IL_186;
						case TypeSwitch.TransformerTool:
							return new TransformerTool(branch);
						case TypeSwitch.DamageTool:
							return new DamageTool(branch);
						case TypeSwitch.VacuumSwitchTool:
							return new VacuumSwitchTool(branch);
						case TypeSwitch.OutsideLineDisconnectorTool:
							return new OutsideLineDisconnectorTool(branch);
						default:
							if (type == TypeSwitch.EndTrimTool)
							{
								return new EndTrimTool(branch);
							}
							break;
						}
						break;
					}
				}
				else
				{
					if (type == TypeSwitch.FuseTool)
					{
						return new FuseTool(branch);
					}
					if (type == TypeSwitch.VoltageTransformerTool)
					{
						return new VoltageTransformerTool(branch);
					}
					if (type == TypeSwitch.CircuitBreaker)
					{
						return new CircuitBreakerTool(branch);
					}
				}
			}
			else if (type <= TypeSwitch.NotPhasedTool)
			{
				if (type == TypeSwitch.RPSTool)
				{
					return new RPSTool(branch);
				}
				if (type == TypeSwitch.AmperageTransformer)
				{
					return new AmperageTransformerTool(branch);
				}
				switch (type)
				{
				case TypeSwitch.DischargerTool:
					return new DischargerTool(branch);
				case TypeSwitch.VoltageLimiterTool:
					return new VoltageLimiterTool(branch);
				case TypeSwitch.OffTool:
					return new OffTool(branch);
				case TypeSwitch.NotPhasedTool:
					return new NotPhasedTool(branch);
				}
			}
			else
			{
				if (type == TypeSwitch.MagneticStarterTool)
				{
					return new MagneticStarterTool(branch);
				}
				if (type == TypeSwitch.ElectricMeterTool)
				{
					return new Class13(branch);
				}
				if (type == TypeSwitch.GroundingStateTool)
				{
					goto IL_186;
				}
			}
			return null;
			IL_186:
			return new GroundingTool(branch);
		}

		public static ObjectOnLine CreateObjectOnLine(TypeSwitch type, DataRow r, Branch branch)
		{
			if (type <= TypeSwitch.CircuitBreaker)
			{
				if (type <= TypeSwitch.EndTrimTool)
				{
					switch (type)
					{
					case TypeSwitch.ArrowTool:
						return new ArrowTool(r, branch);
					case TypeSwitch.LinearDisconnectorToolWaxwork:
						return new LinearDisconnectorWaxworkTool(r, branch);
					case TypeSwitch.LoadSwitchToolWaxwork:
						return new LoadSwitchWaxworkTool(r, branch);
					case (TypeSwitch)6:
					case (TypeSwitch)7:
					case (TypeSwitch)8:
					case (TypeSwitch)9:
						break;
					case TypeSwitch.SeparatorTool:
						return new SeparatorTool(r, branch);
					case TypeSwitch.ComplexSwitchgearTool:
						return new ComplexSwitchgearTool(r, branch);
					default:
						switch (type)
						{
						case TypeSwitch.LubricantSwitchTool:
							return new LubricantSwitchTool(r, branch);
						case TypeSwitch.LinearDisconnectorTool:
							return new LinearDisconnectorTool(r, branch);
						case TypeSwitch.LoadSwitchTool:
							return new LoadSwitchTool(r, branch);
						case TypeSwitch.GroundingTool:
							goto IL_19C;
						case TypeSwitch.TransformerTool:
							return new TransformerTool(r, branch);
						case TypeSwitch.DamageTool:
							return new DamageTool(r, branch);
						case TypeSwitch.VacuumSwitchTool:
							return new VacuumSwitchTool(r, branch);
						case TypeSwitch.OutsideLineDisconnectorTool:
							return new OutsideLineDisconnectorTool(r, branch);
						default:
							if (type == TypeSwitch.EndTrimTool)
							{
								return new EndTrimTool(r, branch);
							}
							break;
						}
						break;
					}
				}
				else
				{
					if (type == TypeSwitch.FuseTool)
					{
						return new FuseTool(r, branch);
					}
					if (type == TypeSwitch.VoltageTransformerTool)
					{
						return new VoltageTransformerTool(r, branch);
					}
					if (type == TypeSwitch.CircuitBreaker)
					{
						return new CircuitBreakerTool(r, branch);
					}
				}
			}
			else if (type <= TypeSwitch.NotPhasedTool)
			{
				if (type == TypeSwitch.RPSTool)
				{
					return new RPSTool(r, branch);
				}
				if (type == TypeSwitch.AmperageTransformer)
				{
					return new AmperageTransformerTool(r, branch);
				}
				switch (type)
				{
				case TypeSwitch.DischargerTool:
					return new DischargerTool(r, branch);
				case TypeSwitch.VoltageLimiterTool:
					return new VoltageLimiterTool(r, branch);
				case TypeSwitch.OffTool:
					return new OffTool(r, branch);
				case TypeSwitch.NotPhasedTool:
					return new NotPhasedTool(r, branch);
				}
			}
			else
			{
				if (type == TypeSwitch.MagneticStarterTool)
				{
					return new MagneticStarterTool(r, branch);
				}
				if (type == TypeSwitch.ElectricMeterTool)
				{
					return new Class13(r, branch);
				}
				if (type == TypeSwitch.GroundingStateTool)
				{
					goto IL_19C;
				}
			}
			return null;
			IL_19C:
			return new GroundingTool(r, branch);
		}

		public override bool ObjectInRectangle(CanvasControl canvas, RectangleF rect, bool anyPoint)
		{
			return Class79.smethod_1(this.Points.ToArray(), rect);
		}

		public override RectangleF GetBoundingRect(CanvasControl canvas, bool inflate)
		{
			RectangleF empty = RectangleF.Empty;
			if (this.Points.Count > 0)
			{
				float num = base.ThresholdWidth(canvas, base.Width);
				empty = new RectangleF(this.Points[0].Point.X, this.Points[0].Point.Y, 0f, 0f);
				foreach (UnitPoint unitPoint in this.Points)
				{
					if (unitPoint.Point.X < empty.X)
					{
						empty.X = unitPoint.Point.X;
					}
					if (unitPoint.Point.X > empty.Right)
					{
						empty.Width = unitPoint.Point.X - empty.X;
					}
					if (unitPoint.Point.Y < empty.Y)
					{
						empty.Y = unitPoint.Point.Y;
					}
					if (unitPoint.Point.Y > empty.Bottom)
					{
						empty.Height = unitPoint.Point.Y - empty.Y;
					}
				}
				RectangleF rectangleF = this.GetRectangleText(canvas);
				if (!rectangleF.IsEmpty)
				{
					float num2 = Math.Min(rectangleF.X, empty.X);
					float num3 = Math.Min(rectangleF.Y, empty.Y);
					float num4 = Math.Max(rectangleF.Right, empty.Right) - num2;
					float num5 = Math.Max(rectangleF.Bottom, empty.Bottom) - num3;
					empty = new RectangleF(num2, num3, num4, num5);
				}
				rectangleF = this.GetRectangleTextNormalSection(canvas);
				if (!rectangleF.IsEmpty)
				{
					float num6 = Math.Min(rectangleF.X, empty.X);
					float num7 = Math.Min(rectangleF.Y, empty.Y);
					float num8 = Math.Max(rectangleF.Right, empty.Right) - num6;
					float num9 = Math.Max(rectangleF.Bottom, empty.Bottom) - num7;
					empty = new RectangleF(num6, num7, num8, num9);
				}
				if (inflate)
				{
					empty.Inflate(num, num);
				}
			}
			return empty;
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(this.TypeSwitch);
		}

		public override void EndDraw()
		{
			if (this.Layer == null || this.Layer.Parent == null)
			{
				this.ShowPropertyForm(new Point(Convert.ToInt32(this.unitPoint_0.X), Convert.ToInt32(this.unitPoint_0.Y)));
				return;
			}
			PointF pointF = ConvertCanvas.ConvertToScreen(this.Layer.Parent, this.CenterPoint);
			Point location = this.Layer.Parent.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
			if (new ObjectOnLinePropertyForm(this, this.Layer.Parent.SqlSettings)
			{
				Location = location
			}.ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
				return;
			}
			bool delSql = this.Layer != null && this.Layer.Parent != null && this.Layer.Parent.UseObjectFromDB;
			this.Remove(delSql, true);
		}

		protected override RectangleF GetRectangleText(CanvasControl canvas)
		{
			RectangleF empty = RectangleF.Empty;
			if (!this.TextProperty.Visible)
			{
				return empty;
			}
			if (this.list_2.Count > 0)
			{
				empty.Location = this.list_2[0].Point;
				empty.Size = new SizeF(0f, 0f);
				float num = empty.Left;
				float num2 = empty.Right;
				float num3 = empty.Top;
				float num4 = empty.Bottom;
				foreach (UnitPoint unitPoint in this.list_2)
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
				RectangleF rectangleF = new RectangleF(num, num3, num2 - num, num4 - num3);
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

		protected RectangleF GetRectangleTextNormalSection(CanvasControl canvas)
		{
			RectangleF empty = RectangleF.Empty;
			if (!this.IsNormalSection)
			{
				return empty;
			}
			if (this.list_2.Count > 0)
			{
				empty.Location = this.list_2[0].Point;
				empty.Size = new SizeF(0f, 0f);
				float num = empty.Left;
				float num2 = empty.Right;
				float num3 = empty.Top;
				float num4 = empty.Bottom;
				foreach (UnitPoint unitPoint in this.list_2)
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
				RectangleF rectangleF = new RectangleF(num, num3, num2 - num, num4 - num3);
				Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style);
				string text = "Н";
				SizeF sizeF = canvas.Graphics.MeasureString(text, font);
				font.Dispose();
				SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
				empty = new RectangleF(rectangleF.Location, size);
				switch (this.TextPropertyNormalSection.Position)
				{
				case ePositionText.T:
					empty.X = rectangleF.Location.X + rectangleF.Width / 2f - empty.Width / 2f;
					empty.Y = rectangleF.Location.Y + rectangleF.Height;
					break;
				case ePositionText.R:
					empty.X = rectangleF.Location.X + rectangleF.Width;
					empty.Y = rectangleF.Location.Y + rectangleF.Height / 2f - empty.Height / 2f;
					break;
				case ePositionText.B:
					empty.X = rectangleF.Location.X + rectangleF.Width / 2f - empty.Width / 2f;
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

		protected void DrawTextNormalSection(CanvasControl canvas)
		{
			if (this.IsNormalSection)
			{
				if (base.UseSettingsText && this.TextProperty.FontSize * canvas.Zoom <= canvas.Settings.FontSizeNoVisible)
				{
					return;
				}
				Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style | FontStyle.Bold);
				string s = "Н";
				RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetRectangleTextNormalSection(canvas));
				if (rectangleF.Size.Width > 0f && rectangleF.Size.Height > 0f)
				{
					RectangleF rect = rectangleF;
					rect.X += 2f * canvas.Zoom;
					rect.Width -= 5f * canvas.Zoom;
					rect.Y += 1.5f * canvas.Zoom;
					rect.Height -= 4f * canvas.Zoom;
					canvas.Graphics.FillRectangle(new SolidBrush(Color.LightGray), rect);
					canvas.Graphics.DrawString(s, font, new SolidBrush(Color.Black), rectangleF.Location);
				}
				font.Dispose();
			}
		}

		protected void DrawDamage(CanvasControl canvas)
		{
			if (this.ePositionText_0 != ePositionText.None)
			{
				using (Pen pen = new Pen(canvas.Settings.ObjectOnLineDamageStateColor))
				{
					RectangleF boundingRect = this.GetBoundingRect(canvas, false);
					UnitPoint item = new UnitPoint((double)boundingRect.Right, (double)boundingRect.Bottom);
					switch (this.ePositionText_0)
					{
					case ePositionText.LT:
						item = new UnitPoint((double)boundingRect.Left - 0.16, (double)boundingRect.Bottom);
						break;
					case ePositionText.T:
						item = new UnitPoint((double)(boundingRect.Left + boundingRect.Width / 2f) - 0.08, (double)boundingRect.Bottom);
						break;
					case ePositionText.R:
						item = new UnitPoint((double)boundingRect.Right, (double)(boundingRect.Top + boundingRect.Height / 2f) - 0.06);
						break;
					case ePositionText.RB:
						item = new UnitPoint((double)boundingRect.Right, (double)boundingRect.Top - 0.12);
						break;
					case ePositionText.B:
						item = new UnitPoint((double)(boundingRect.Left + boundingRect.Width / 2f) - 0.08, (double)boundingRect.Top - 0.12);
						break;
					case ePositionText.LB:
						item = new UnitPoint((double)boundingRect.Left - 0.16, (double)boundingRect.Top - 0.12);
						break;
					case ePositionText.L:
						item = new UnitPoint((double)boundingRect.Left - 0.16, (double)(boundingRect.Top + boundingRect.Height / 2f) - 0.06);
						break;
					}
					PointF[] array = ConvertCanvas.ConvertToScreen(canvas, new List<UnitPoint>
					{
						item,
						new UnitPoint(item.X + 0.10000000149011612, item.Y + 0.10000000149011612),
						new UnitPoint(item.X + 0.059999998658895493, item.Y + 0.019999999552965164),
						new UnitPoint(item.X + 0.15999999642372131, item.Y + 0.11999999731779099),
						new UnitPoint(item.X + 0.13500000536441803, item.Y + 0.10499999672174454),
						new UnitPoint(item.X + 0.14499999582767487, item.Y + 0.0949999988079071)
					}.ToArray<UnitPoint>());
					canvas.Graphics.DrawLine(pen, array[0], array[1]);
					canvas.Graphics.DrawLine(pen, array[1], array[2]);
					canvas.Graphics.DrawLine(pen, array[2], array[3]);
					canvas.Graphics.DrawLine(pen, array[3], array[4]);
					canvas.Graphics.DrawLine(pen, array[3], array[5]);
				}
			}
		}

		protected void DrawKey(CanvasControl canvas)
		{
			if (this.PositionKey != ePositionText.None)
			{
				Pen pen = new Pen(canvas.Settings.ObjectOnLineKeyStateColor);
				RectangleF boundingRect = this.GetBoundingRect(canvas, false);
				UnitPoint item = new UnitPoint((double)boundingRect.Right, (double)boundingRect.Bottom);
				switch (this.ePositionText_1)
				{
				case ePositionText.LT:
					item = new UnitPoint((double)boundingRect.Left - 0.1, (double)boundingRect.Bottom);
					break;
				case ePositionText.T:
					item = new UnitPoint((double)(boundingRect.Left + boundingRect.Width / 2f) - 0.05, (double)boundingRect.Bottom);
					break;
				case ePositionText.R:
					item = new UnitPoint((double)boundingRect.Right, (double)(boundingRect.Top + boundingRect.Height / 2f) - 0.075);
					break;
				case ePositionText.RB:
					item = new UnitPoint((double)boundingRect.Right, (double)boundingRect.Top - 0.15);
					break;
				case ePositionText.B:
					item = new UnitPoint((double)(boundingRect.Left + boundingRect.Width / 2f) - 0.05, (double)boundingRect.Top - 0.15);
					break;
				case ePositionText.LB:
					item = new UnitPoint((double)boundingRect.Left - 0.1, (double)boundingRect.Top - 0.15);
					break;
				case ePositionText.L:
					item = new UnitPoint((double)boundingRect.Left - 0.1, (double)(boundingRect.Top + boundingRect.Height / 2f) - 0.075);
					break;
				}
				PointF[] array = ConvertCanvas.ConvertToScreen(canvas, new List<UnitPoint>
				{
					item,
					new UnitPoint(item.X + 0.10000000149011612, item.Y + 0.10000000149011612),
					new UnitPoint(item.X, item.Y + 0.05000000074505806),
					new UnitPoint(item.X + 0.10000000149011612, item.Y + 0.15000000596046448),
					new UnitPoint(item.X + 0.039999999105930328, item.Y + 0.019999999552965164),
					new UnitPoint(item.X + 0.059999998658895493, item.Y + 0.079999998211860657)
				}.ToArray<UnitPoint>());
				canvas.Graphics.DrawRectangle(pen, array[0].X, array[1].Y, array[1].X - array[0].X, array[0].Y - array[1].Y);
				canvas.Graphics.DrawArc(pen, array[2].X, array[3].Y, array[3].X - array[2].X, array[2].Y - array[3].Y, 180f, 180f);
				canvas.Graphics.FillRectangle(new SolidBrush(canvas.Settings.ObjectOnLineKeyStateColor), array[4].X, array[5].Y, array[5].X - array[4].X, array[4].Y - array[5].Y);
				pen.Dispose();
			}
		}

		public override string GetUpdateScriptXML(bool children, List<int> id)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.IdBase > 0)
			{
				stringBuilder.Append(this.Parent.Parent.GetUpdateScriptXML(children, id));
				this.vmethod_4();
				stringBuilder.Append(string.Concat(new string[]
				{
					" UPDATE [tSchm_ObjList] SET [IdParent] = ",
					((Branch)this.Parent).CouplingRelation.Id.ToString(),
					" where Id = ",
					this.IdBase.ToString(),
					" "
				}));
				string result = string.Concat(new object[]
				{
					" ",
					stringBuilder,
					" update tSChm_Xml set [SchemaXml] = ' ",
					this.xmlCoords.InnerXml,
					"' where ObjId = ",
					this.IdBase.ToString(),
					" AND TypeSchema = ",
					((int)this.Layer.Parent.TypeCanvas).ToString()
				});
				if (id.Contains(this.IdBase))
				{
					result = "";
				}
				else
				{
					id.Add(this.IdBase);
				}
				return result;
			}
			if ((base.GetType().BaseType == typeof(ObjectOnLine) && this.MappingState) || base.GetType() == typeof(TextBranchTool))
			{
				return this.Parent.Parent.GetUpdateScriptXML(children, id);
			}
			return string.Empty;
		}

		protected override void vmethod_4()
		{
			if (base.GetType() != typeof(ArrowTool))
			{
				base.vmethod_4();
				((XmlElement)this.currentXmlScheme).SetAttribute("delta", Math.Round(this.Delta, 4).ToString(new CultureInfo(1033)));
				if (this.MappingState)
				{
					((XmlElement)this.currentXmlScheme).SetAttribute("MappingState", this.MappingState.ToString());
				}
				if (this.IsNormalSection)
				{
					((XmlElement)this.currentXmlScheme).SetAttribute("IsNormal", this.IsNormalSection.ToString());
					((XmlElement)this.currentXmlScheme).SetAttribute("NormalPosition", ((int)this.TextPropertyNormalSection.Position).ToString());
				}
				if (this.TextProperty.Visible)
				{
					((XmlElement)this.currentXmlScheme).SetAttribute("textVis", this.TextProperty.Visible.ToString());
					((XmlElement)this.currentXmlScheme).SetAttribute("textPos", ((int)this.TextProperty.Position).ToString());
				}
				if (this.PositionDamage != ePositionText.None)
				{
					((XmlElement)this.currentXmlScheme).SetAttribute("PosDamage", ((int)this.PositionDamage).ToString());
				}
				if (this.PositionKey != ePositionText.None)
				{
					((XmlElement)this.currentXmlScheme).SetAttribute("PosKey", ((int)this.PositionKey).ToString());
				}
				((XmlElement)this.currentXmlScheme).SetAttribute("gorMirror", this.GorMirror.ToString());
				((XmlElement)this.currentXmlScheme).SetAttribute("vertMirror", this.VertMirror.ToString());
				((XmlElement)this.currentXmlScheme).SetAttribute("ComplexSwitchgear", (this.ComplexSwitchgear != null).ToString());
				if (this.ComplexSwitchgear != null)
				{
					((XmlElement)this.currentXmlScheme).SetAttribute("ComplexSwitchgearRollingOutReason", ((int)this.ComplexSwitchgear.RollingOutReason).ToString());
				}
				if (!this.ContainsGrounding)
				{
					((XmlElement)this.currentXmlScheme).SetAttribute("ContainsGrounding", this.ContainsGrounding.ToString());
					if (this.ContainsGroundingOn)
					{
						((XmlElement)this.currentXmlScheme).SetAttribute("ContainsGroundingOn", this.ContainsGroundingOn.ToString());
					}
				}
				if (!base.UseSettingColor)
				{
					((XmlElement)this.currentXmlScheme).SetAttribute("Color", this.Color.ToArgb().ToString());
				}
				if (!base.UseSettingsText)
				{
					((XmlElement)this.currentXmlScheme).SetAttribute("FontName", this.TextProperty.FontName);
					((XmlElement)this.currentXmlScheme).SetAttribute("FontSize", this.TextProperty.FontSize.ToString(new CultureInfo(1033)));
					((XmlElement)this.currentXmlScheme).SetAttribute("FontBold", this.TextProperty.FontBold.ToString());
					((XmlElement)this.currentXmlScheme).SetAttribute("FontItalic", this.TextProperty.FontItalic.ToString());
					((XmlElement)this.currentXmlScheme).SetAttribute("FontUnderline", this.TextProperty.FontUnderline.ToString());
					((XmlElement)this.currentXmlScheme).SetAttribute("FontColor", this.TextProperty.Color.ToArgb().ToString());
					return;
				}
			}
			else
			{
				this.Parent.SaveXmlToSql();
			}
		}

		public override bool SaveToSql(bool isbackground, bool children)
		{
			if (base.GetType() != typeof(ComplexSwitchgearTool) && base.GetType() != typeof(ArrowTool) && base.SaveToSql(false, children))
			{
				if (this.Parent != null && this.Parent.GetType() == typeof(Branch) && this.Parent.Parent != null)
				{
					this.Parent.Parent.SaveXmlToSql();
				}
				return true;
			}
			return false;
		}

		protected virtual void CreateImagePoints()
		{
			this.list_4.Add(new UnitPoint(-0.1, -0.2));
			this.list_4.Add(new UnitPoint(-0.1, 0.2));
			this.list_4.Add(new UnitPoint(0.1, 0.2));
			this.list_4.Add(new UnitPoint(0.12, -0.2));
		}

		protected virtual void ExportDXFText(CanvasControl canvas, DxfDocument document)
		{
			double num = 1.5;
			if (this.TextProperty.Visible)
			{
				RectangleF rectangleText = this.GetRectangleText(canvas);
				document.AddEntity(new Text(this.ToString(), new Vector2((double)rectangleText.X, (double)rectangleText.Y), (double)rectangleText.Height / num)
				{
					Color = new AciColor(this.TextProperty.Color),
					Style = new TextStyle(this.TextProperty.FontName),
					Layer = new Layer("Switches")
				});
			}
		}

		protected virtual void ExportDXFSolid(DxfDocument document, List<UnitPoint> ps)
		{
			document.AddEntity(new Solid
			{
				FirstVertex = new Vector3(ps[0].X, ps[0].Y, 1.0),
				SecondVertex = new Vector3(ps[1].X, ps[1].Y, 1.0),
				ThirdVertex = new Vector3(ps[2].X, ps[2].Y, 1.0),
				FourthVertex = new Vector3(ps[3].X, ps[3].Y, 1.0),
				Color = 
				{
					Index = 256
				},
				Layer = new Layer("Switches")
			});
		}

		private bool bool_7;

		private List<UnitPoint> list_2;

		private List<UnitPoint> list_3;

		private UnitPoint unitPoint_0;

		private double double_0;

		private float float_1;

		protected bool systemChanging;

		private bool bool_8;

		private bool bool_9;

		private Color xiHnzemgkg;

		private Color color_3;

		private bool bool_10;

		private TextFont textFont_1;

		private bool bool_11;

		private LineToolState lineToolState_0;

		private ePositionText ePositionText_0;

		private ePositionText ePositionText_1;

		[CompilerGenerated]
		private EventHandler eventHandler_0;

		private string string_2;

		private ComplexSwitchgearTool complexSwitchgearTool_0;

		private bool bool_12;

		private bool bool_13;

		private bool bool_14;

		public bool erSwitch;

		private List<UnitPoint> list_4;
	}
}
