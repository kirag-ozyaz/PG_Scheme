using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
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
		public event EventHandler OnChanged;

		public virtual ComplexSwitchgearTool ComplexSwitchgear
		{
			get
			{
				return this.complexSwitchgear;
			}
		}

		public override string Text
		{
			get
			{
				return this.text;
			}
			set
			{
				this.text = value;
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
					TextFont textFont = this.Layer.Parent.Settings.TextPropertyNormalSection;
					this.textPropertyNormalSection = new TextFont(textFont.FontName, textFont.FontSize, textFont.FontBold, textFont.FontItalic, textFont.FontUnderline, this.textPropertyNormalSection.Position, this.textPropertyNormalSection.FontVirtical, this.textPropertyNormalSection.Visible, textFont.Color);
				}
				return this.textPropertyNormalSection;
			}
			set
			{
				this.textPropertyNormalSection = value;
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
				return this.colorOff;
			}
			set
			{
				this.colorOff = value;
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
				return this.colorOffN;
			}
			set
			{
				this.colorOffN = value;
			}
		}

		public bool NormalSectionModeOn
		{
			get
			{
				return this.normalSectionModeOn;
			}
			set
			{
				this.normalSectionModeOn = value;
			}
		}

		public bool IsNormalSection
		{
			get
			{
				return this.isNormalSection;
			}
			set
			{
				this.isNormalSection = value;
			}
		}

		public ePositionText PositionDamage
		{
			get
			{
				return this.positionDamage;
			}
			set
			{
				this.positionDamage = value;
			}
		}

		public ePositionText PositionKey
		{
			get
			{
				return this.positionKey;
			}
			set
			{
				this.positionKey = value;
			}
		}

		public bool ContainsGrounding
		{
			get
			{
				return this.containsGrounding;
			}
			set
			{
				this.containsGrounding = value;
				if (!this.containsGrounding)
				{
					this.ContainsGroundingOn = false;
				}
			}
		}

		public bool ContainsGroundingOn
		{
			get
			{
				return !this.On && this.ContainsGrounding && this.containsGroundingOn;
			}
			set
			{
				if (!value)
				{
					this.containsGroundingOn = value;
					return;
				}
				if (!this.On && this.ContainsGrounding)
				{
					this.containsGroundingOn = value;
					return;
				}
				this.containsGroundingOn = false;
			}
		}

		public bool MappingState
		{
			get
			{
				return this.mappingState;
			}
			set
			{
				this.mappingState = value;
				if (!this.mappingState)
				{
					this.state = new LineToolState();
				}
			}
		}

		public virtual LineToolState State
		{
			get
			{
				if (this.mappingState)
				{
					return this.state;
				}
				return new LineToolState();
			}
			set
			{
				if (this.mappingState)
				{
					this.state = value;
				}
			}
		}

		public List<UnitPoint> Points
		{
			get
			{
				return this.points;
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
					Branch branch = (Branch)this.Parent;
					base.Parent = null;
					this.Angle = 0f;
					((LineTool)branch.Parent).RecalcAmperage();
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
					((ObjectOnLine)this.Master).OnChanged -= this.method_6;
					((ObjectOnLine)this.Master).ObjectRemoved -= this.method_11;
				}
				base.Master = value;
				if (this.Master != null && this.Master.GetType().BaseType == typeof(ObjectOnLine))
				{
					((ObjectOnLine)this.Master).OnChanged += this.method_6;
					((ObjectOnLine)this.Master).ObjectRemoved += this.method_11;
				}
			}
		}

		public virtual bool On
		{
			get
			{
				if (!this.normalSectionModeOn)
				{
					return this.bool_0;
				}
				return !this.isNormalSection;
			}
			set
			{
				if (this.bool_0 == value)
				{
					return;
				}
				this.bool_0 = value;
				if (this.Parent != null && ((Branch)this.Parent).CouplingRelation != null)
				{
					if (!this.bool_0)
					{
						if (((Branch)this.Parent).CouplingRelation.amperagePoint != null)
						{
							LineTool lineTool = (LineTool)((Branch)this.Parent).Parent;
							PointTool amperagePoint = ((Branch)this.Parent).CouplingRelation.amperagePoint;
							lineTool.Amperages[amperagePoint].KillNextAmperage();
							foreach (CouplingRelation couplingRelation in lineTool.CouplingRelations)
							{
								if (couplingRelation.amperagePoint == amperagePoint)
								{
									couplingRelation.amperagePoint = null;
								}
							}
							lineTool.method_11(amperagePoint);
						}
					}
					else
					{
						try
						{
							((LineTool)((Branch)this.Parent).Parent).RecalcAmperage();
						}
						catch
						{
							this.On = false;
						}
					}
					if (this.OnChanged != null)
					{
						this.OnChanged(this, new EventArgs());
					}
					return;
				}
			}
		}

		private void method_6(object sender, EventArgs e)
		{
			this.On = ((ObjectOnLine)sender).On;
		}

		public virtual double Delta
		{
			get
			{
				return this.delta;
			}
			set
			{
				if (double.IsInfinity(value) && double.IsNaN(value))
				{
					if (double.IsInfinity(this.delta) && double.IsNaN(this.delta))
					{
						this.Delta = 0.5;
					}
					return;
				}
				this.delta = value;
				if (this.complexSwitchgear != null)
				{
					this.complexSwitchgear.Delta = this.delta;
				}
				if (this.Parent != null)
				{
					double num = this.delta;
					UnitPoint point = ((Branch)this.Parent).Destination.Point;
					UnitPoint point2 = ((Branch)this.Parent).Source.Point;
					num = 1.0 - this.delta;
					double num2 = Math.Sqrt(Math.Pow(point.X - point2.X, 2.0) + Math.Pow(point.Y - point2.Y, 2.0));
					double num3 = num2 * num;
					if (point2.X == point.X)
					{
						this.CenterPoint = new UnitPoint(point2.X, point.Y + num * (point2.Y - point.Y));
					}
					if (point2.Y == point.Y)
					{
						this.CenterPoint = new UnitPoint(point.X + num * (point2.X - point.X), point2.Y);
					}
					if (point2.X != point.X && point2.Y != point.Y)
					{
						double num4 = 1.0 / (Math.Sqrt(Math.Pow((point2.Y - point.Y) / (point2.X - point.X), 2.0) + 1.0) / num3);
						if (point2.X < point.X)
						{
							num4 *= -1.0;
						}
						double num5 = 1.0 / (Math.Sqrt(Math.Pow((point2.X - point.X) / (point2.Y - point.Y), 2.0) + 1.0) / num3);
						if (point2.Y < point.Y)
						{
							num5 *= -1.0;
						}
						this.CenterPoint = new UnitPoint(point.X + num4, point.Y + num5);
					}
				}
			}
		}

		public virtual float Angle
		{
			get
			{
				return this.angle;
			}
			set
			{
				float num = 0f;
				if (this.angle >= -360f && this.angle <= 360f && value >= -360f && value <= 360f)
				{
					num = this.angle - value;
					this.angle = value;
				}
				else if (value >= -360f && value <= 360f)
				{
					num = 180f - value;
					this.angle = value;
				}
				if (this.complexSwitchgear != null)
				{
					this.complexSwitchgear.Angle = this.angle;
				}
				if (num != 0f)
				{
					PointF[] array = new PointF[this.Points.Count];
					int num2 = 0;
					foreach (UnitPoint unitPoint in this.Points)
					{
						float num3 = unitPoint.Point.X - this.centerPoint.Point.X;
						float num4 = unitPoint.Point.Y - this.centerPoint.Point.Y;
						float num5 = Convert.ToSingle(Math.Cos((double)num * 3.1415926535897931 / 180.0));
						float num6 = Convert.ToSingle(Math.Sin((double)num * 3.1415926535897931 / 180.0));
						float x = this.centerPoint.Point.X + num3 * num5 - num4 * num6;
						float y = this.centerPoint.Point.Y + num3 * num6 + num4 * num5;
						array[num2] = new PointF(x, y);
						num2++;
					}
					this.Points.Clear();
					foreach (PointF pointF_ in array)
					{
						this.Points.Add(new UnitPoint(pointF_));
					}
					array = new PointF[this.pointsRectangle.Count];
					num2 = 0;
					foreach (UnitPoint unitPoint2 in this.pointsRectangle)
					{
						float num7 = unitPoint2.Point.X - this.centerPoint.Point.X;
						float num8 = unitPoint2.Point.Y - this.centerPoint.Point.Y;
						float num9 = Convert.ToSingle(Math.Cos((double)num * 3.1415926535897931 / 180.0));
						float num10 = Convert.ToSingle(Math.Sin((double)num * 3.1415926535897931 / 180.0));
						float x2 = this.centerPoint.Point.X + num7 * num9 - num8 * num10;
						float y2 = this.centerPoint.Point.Y + num7 * num10 + num8 * num9;
						array[num2] = new PointF(x2, y2);
						num2++;
					}
					this.pointsRectangle.Clear();
					foreach (PointF pointF_2 in array)
					{
						this.pointsRectangle.Add(new UnitPoint(pointF_2));
					}
				}
			}
		}

		public virtual UnitPoint CenterPoint
		{
			get
			{
				return this.centerPoint;
			}
			set
			{
				UnitPoint unitPoint = this.centerPoint;
				this.centerPoint = value;
				if (!this.systemChanging)
				{
					for (int i = 0; i < this.Points.Count; i++)
					{
						double num = this.Points[i].X - unitPoint.X;
						double num2 = this.Points[i].Y - unitPoint.Y;
						this.Points[i] = new UnitPoint(num + this.centerPoint.X, num2 + this.centerPoint.Y);
					}
					for (int j = 0; j < this.pointsRectangle.Count; j++)
					{
						double num = this.pointsRectangle[j].X - unitPoint.X;
						double num2 = this.pointsRectangle[j].Y - unitPoint.Y;
						this.pointsRectangle[j] = new UnitPoint(num + this.centerPoint.X, num2 + this.centerPoint.Y);
					}
				}
				if (this.Parent != null)
				{
					double d = Math.Sqrt(Math.Pow(((Branch)this.Parent).Source.Point.X - this.CenterPoint.X, 2.0) + Math.Pow(((Branch)this.Parent).Source.Point.Y - this.CenterPoint.Y, 2.0)) / Math.Sqrt(Math.Pow(((Branch)this.Parent).Source.Point.X - ((Branch)this.Parent).Destination.Point.X, 2.0) + Math.Pow(((Branch)this.Parent).Source.Point.Y - ((Branch)this.Parent).Destination.Point.Y, 2.0));
					if (!double.IsNaN(d) && !double.IsInfinity(d))
					{
						this.delta = d;
					}
				}
				if (this.complexSwitchgear != null)
				{
					this.complexSwitchgear.CenterPoint = this.centerPoint;
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
						if (branch.CheckVoltageInPoint(this.centerPoint))
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
				return this.vertMirror;
			}
			set
			{
				if (this.vertMirror != value)
				{
					bool flag;
					if (flag = (this.complexSwitchgear != null && this.complexSwitchgear.RollingOut))
					{
						this.complexSwitchgear.RollingOut = false;
					}
					GraphicsPath graphicsPath = new GraphicsPath();
					graphicsPath.AddLine(((Branch)this.Parent).Source.Point.Point, ((Branch)this.Parent).Destination.Point.Point);
					Matrix matrix = new Matrix();
					matrix.RotateAt(90f, this.CenterPoint.Point);
					graphicsPath.Transform(matrix);
					UnitPoint unitPoint_ = new UnitPoint(graphicsPath.PathPoints[0]);
					UnitPoint unitPoint_2 = new UnitPoint(graphicsPath.PathPoints[1]);
					for (int i = 0; i < this.points.Count; i++)
					{
						UnitPoint unitPoint = this.points[i];
						this.points.RemoveAt(i);
						UnitPoint unitPoint2 = Class88.smethod_5(unitPoint_, unitPoint_2, unitPoint);
						double num = unitPoint.X - unitPoint2.X;
						double num2 = unitPoint.Y - unitPoint2.Y;
						unitPoint.Point = new PointF((float)(unitPoint2.X - num), (float)(unitPoint2.Y - num2));
						this.points.Insert(i, unitPoint);
					}
					if (flag)
					{
						this.complexSwitchgear.RollingOut = true;
					}
					this.vertMirror = value;
				}
			}
		}

		public virtual bool GorMirror
		{
			get
			{
				return this.gorMirorr;
			}
			set
			{
				if (this.gorMirorr != value)
				{
					bool flag;
					if (flag = (this.complexSwitchgear != null && this.complexSwitchgear.RollingOut))
					{
						this.complexSwitchgear.RollingOut = false;
					}
					for (int i = 0; i < this.points.Count; i++)
					{
						UnitPoint unitPoint = this.points[i];
						this.points.RemoveAt(i);
						UnitPoint unitPoint2 = Class88.smethod_5(((Branch)this.Parent).Source.Point, ((Branch)this.Parent).Destination.Point, unitPoint);
						double num = unitPoint.X - unitPoint2.X;
						double num2 = unitPoint.Y - unitPoint2.Y;
						unitPoint.Point = new PointF((float)(unitPoint2.X - num), (float)(unitPoint2.Y - num2));
						this.points.Insert(i, unitPoint);
					}
					if (flag)
					{
						this.complexSwitchgear.RollingOut = true;
					}
					this.gorMirorr = value;
				}
			}
		}

		public ObjectOnLine()
		{
			this.CreateImagePoints();
		}

		public ObjectOnLine(Branch branch)
		{
			this.Parent = branch;
			this.CreateImagePoints();
		}

		public ObjectOnLine(DataRow dataRow_0, Branch branch) : base(dataRow_0)
		{
			this.Parent = branch;
			this.Layer = branch.Parent.Layer;
			XmlDocument xmlDocument = new XmlDocument();
			this.NormalSectionModeOn = (this.Layer.Parent.SimulationMode == eSimulationMode.Normal);
			if (!dataRow_0.IsNull("OnOff"))
			{
				this.On = Convert.ToBoolean(dataRow_0["OnOff"]);
			}
			xmlDocument.LoadXml((string)dataRow_0["SchemaXml"]);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/Obj");
			XmlAttribute xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("delta");
			this.CreateImagePoints();
			double d = (double)Convert.ToSingle(xmlAttribute.Value, new CultureInfo(1033));
			if (!double.IsNaN(d) && !double.IsInfinity(d))
			{
				this.Delta = d;
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
					States states = States.none;
					TypeSwitch typeSwitch = this.TypeSwitch;
					switch (typeSwitch)
					{
					case TypeSwitch.GroundingTool:
						states = States.grounded;
						break;
					case TypeSwitch.TransformerTool:
						break;
					case TypeSwitch.DamageTool:
						states = States.break_down;
						break;
					default:
						switch (typeSwitch)
						{
						case TypeSwitch.OffTool:
							states = States.const_1;
							break;
						case TypeSwitch.NotPhasedTool:
							states = States.not_phased;
							break;
						}
						break;
					}
					this.State = new LineToolState();
					this.State.state = states;
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

		private void method_7(object sender, EventArgs e)
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

		private void method_8(object sender, EventArgs e)
		{
			this.ShowPropertyForm(((ToolStripMenuItem)sender).GetCurrentParent().Location);
		}

		protected override void RemoveContextMenus()
		{
		}

		private void method_9(object sender, EventArgs e)
		{
			this.ShowPropertyForm(((ToolStripMenuItem)sender).GetCurrentParent().Location);
		}

		public void ShiftPoints(double double_0, double double_1)
		{
			for (int i = 0; i < this.Points.Count; i++)
			{
				this.Points[i] = new UnitPoint(double_0 + this.Points[i].X, double_1 + this.Points[i].Y);
			}
		}

		public void RemoveComplexSwitchgear()
		{
			this.complexSwitchgear.RollingOut = false;
			this.complexSwitchgear = null;
			this.Layer.Parent.DoInvalidate(true);
		}

		public void SetComplexSwitchgear()
		{
			this.complexSwitchgear = new ComplexSwitchgearTool((Branch)this.Parent);
			this.complexSwitchgear.Delta = this.Delta;
			this.complexSwitchgear.Angle = this.Angle;
			this.complexSwitchgear.IntegratedSwitch = this;
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
			foreach (Branch branch in couplingRelation.Branches)
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
			foreach (Branch branch in couplingRelation.Branches)
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
			float num = Convert.ToSingle(Math.Atan(Math.Abs(branch.Source.Point.X - branch.Destination.Point.X) / Math.Abs(branch.Source.Point.Y - branch.Destination.Point.Y)) * 57.295779513082323);
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
						this.Layer.Parent.ProxySingleton.ObjectOnLineOnChange(this.IdBase, this.On);
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
			int index = this.points.Count - 1;
			while (i < this.points.Count)
			{
				if (((this.points[i].Y <= point.Y && point.Y < this.points[index].Y) || (this.points[index].Y <= point.Y && point.Y < this.points[i].Y)) && point.X > (this.points[index].X - this.points[i].X) * (point.Y - this.points[i].Y) / (this.points[index].Y - this.points[i].Y) + this.points[i].X)
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

		private PointTool method_10(UnitPoint unitPoint_0, Branch branch_0)
		{
			PointTool pointTool = (branch_0.Source.Point.X >= branch_0.Destination.Point.X) ? branch_0.Source : branch_0.Destination;
			PointTool pointTool2 = (branch_0.Source.Point.X < branch_0.Destination.Point.X) ? branch_0.Source : branch_0.Destination;
			PointTool pointTool3 = (branch_0.Source.Point.Y >= branch_0.Destination.Point.Y) ? branch_0.Source : branch_0.Destination;
			PointTool pointTool4 = (branch_0.Source.Point.Y < branch_0.Destination.Point.Y) ? branch_0.Source : branch_0.Destination;
			if (unitPoint_0.X > pointTool.Point.X)
			{
				return pointTool;
			}
			if (unitPoint_0.X < pointTool2.Point.X)
			{
				return pointTool2;
			}
			if (unitPoint_0.Y > pointTool3.Point.Y)
			{
				return pointTool3;
			}
			if (unitPoint_0.Y < pointTool4.Point.Y)
			{
				return pointTool4;
			}
			return null;
		}

		public void ChangeBranch(Branch branch)
		{
			Branch branch2 = (Branch)this.Parent;
			this.Parent = branch;
			if (this.complexSwitchgear != null)
			{
				this.complexSwitchgear.Parent = branch;
			}
			if (branch2.CouplingRelation != branch.CouplingRelation && !this.bool_0)
			{
				((LineTool)branch2.Parent).RecalcAmperage();
				if (branch.CouplingRelation.amperagePoint != null)
				{
					LineTool lineTool = (LineTool)branch.Parent;
					PointTool amperagePoint = branch.CouplingRelation.amperagePoint;
					lineTool.Amperages[amperagePoint].KillNextAmperage();
					foreach (CouplingRelation couplingRelation in lineTool.CouplingRelations)
					{
						if (couplingRelation.amperagePoint == amperagePoint)
						{
							couplingRelation.amperagePoint = null;
						}
					}
					lineTool.method_11(amperagePoint);
				}
			}
		}

		public override void Move(UnitPoint offset, bool selectedMove)
		{
			if (!this.Parent.Selected)
			{
				UnitPoint unitPoint_ = new UnitPoint(this.CenterPoint.X + offset.X, this.CenterPoint.Y + offset.Y);
				UnitPoint unitPoint = Class88.smethod_5(((Branch)this.Parent).Source.Point, ((Branch)this.Parent).Destination.Point, unitPoint_);
				PointTool pointTool = this.method_10(unitPoint, (Branch)this.Parent);
				if (pointTool != null)
				{
					Dictionary<Branch, UnitPoint> dictionary = new Dictionary<Branch, UnitPoint>();
					foreach (Branch branch in pointTool.Branches)
					{
						if (branch != this.Parent && branch.Parent != null && branch.Parent == this.Parent.Parent && (branch.CouplingRelation == ((Branch)this.Parent).CouplingRelation || !this.Parent.Parent.LimitedEditing))
						{
							UnitPoint unitPoint2 = Class88.smethod_5(branch.Source.Point, branch.Destination.Point, unitPoint_);
							if (this.method_10(unitPoint2, branch) == null)
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
				UnitPoint unitPoint5 = this.CenterPoint;
				this.CenterPoint = unitPoint;
				if (base.GetType() != typeof(GroundingTool) && !this.On)
				{
					foreach (DrawObjectBase drawObjectBase in this.Parent.ChildObjects)
					{
						if (drawObjectBase.GetType() == typeof(GroundingTool) && ((GroundingTool)drawObjectBase).On && ((Branch)this.Parent).CheckVoltageInPoint(((GroundingTool)drawObjectBase).centerPoint))
						{
							this.CenterPoint = unitPoint5;
							break;
						}
					}
				}
			}
		}

		public override void SaveToXML(XmlNode xmlNode, List<PointTool> pointList)
		{
			TypeSwitch typeSwitch = this.TypeSwitch;
			XmlDocument ownerDocument = xmlNode.OwnerDocument;
			XmlElement xmlElement = ownerDocument.CreateElement("Switch");
			xmlElement.SetAttribute("ID", this.IdBase.ToString());
			xmlElement.SetAttribute("delta", Math.Round(this.Delta, 4).ToString(new CultureInfo(1033)));
			XmlElement xmlElement2 = xmlElement;
			string name = "type";
			int num = (int)typeSwitch;
			xmlElement2.SetAttribute(name, num.ToString());
			xmlElement.SetAttribute("On", this.bool_0.ToString());
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
			objectOnLine.delta = this.delta;
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
				objectOnLine.OnChanged += this.method_6;
				objectOnLine.ObjectRemoved += this.method_11;
			}
			return objectOnLine;
		}

		private void method_11(DrawObjectBase drawObjectBase_1)
		{
			if (drawObjectBase_1.GetType().BaseType == typeof(ObjectOnLine))
			{
				ObjectOnLine objectOnLine = (ObjectOnLine)drawObjectBase_1;
				objectOnLine.OnChanged -= this.method_6;
				objectOnLine.ObjectRemoved -= this.method_11;
			}
		}

		public override void Remove(bool delSql, bool parentNULL)
		{
			Branch branch = (Branch)this.Parent;
			base.Remove(delSql, parentNULL);
			this.Deleted = true;
			branch.Parent.RecalcAmperage();
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
					PointF[] array = ConvertCanvas.ConvertToScreen(canvas, this.pointsRectangle.ToArray<UnitPoint>());
					canvas.Graphics.FillPolygon(solidBrush, array);
					this.DrawText(canvas, drawMode);
					this.DrawTextNormalSection(canvas);
				}
			}
		}

		public static ObjectOnLine CreateObjectOnLine(TypeSwitch type)
		{
			if (type <= TypeSwitch.VoltageTransformerTool)
			{
				if (type <= TypeSwitch.OutsideLineDisconnectorTool)
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
							return new GroundingTool();
						case TypeSwitch.TransformerTool:
							return new TransformerTool();
						case TypeSwitch.DamageTool:
							return new DamageTool();
						case TypeSwitch.VacuumSwitchTool:
							return new VacuumSwitchTool();
						case TypeSwitch.OutsideLineDisconnectorTool:
							return new OutsideLineDisconnectorTool();
						}
						break;
					}
				}
				else
				{
					if (type == TypeSwitch.EndTrimTool)
					{
						return new EndTrimTool();
					}
					switch (type)
					{
					case TypeSwitch.FuseTool:
						return new FuseTool();
					case TypeSwitch.DischargerTool:
						return new DischargerTool();
					case TypeSwitch.VoltageLimiterTool:
						return new VoltageLimiterTool();
					case TypeSwitch.VoltageTransformerTool:
						return new VoltageTransformerTool();
					}
				}
			}
			else if (type <= TypeSwitch.AmperageTransformer)
			{
				if (type == TypeSwitch.CircuitBreaker)
				{
					return new CircuitBreakerTool();
				}
				switch (type)
				{
				case TypeSwitch.RPSTool:
					return new RPSTool();
				case TypeSwitch.AmperageTransformer:
					return new AmperageTransformerTool();
				}
			}
			else
			{
				switch (type)
				{
				case TypeSwitch.OffTool:
					return new OffTool();
				case TypeSwitch.NotPhasedTool:
					return new NotPhasedTool();
				default:
					switch (type)
					{
					case TypeSwitch.MagneticStarterTool:
						return new MagneticStarterTool();
					case TypeSwitch.ElectricMeterTool:
						return new ElectricMeterTool();
					}
					break;
				}
			}
			return null;
		}

		public static ObjectOnLine CreateObjectOnLine(TypeSwitch type, Branch branch)
		{
			if (type <= TypeSwitch.VoltageTransformerTool)
			{
				if (type <= TypeSwitch.OutsideLineDisconnectorTool)
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
							return new GroundingTool(branch);
						case TypeSwitch.TransformerTool:
							return new TransformerTool(branch);
						case TypeSwitch.DamageTool:
							return new DamageTool(branch);
						case TypeSwitch.VacuumSwitchTool:
							return new VacuumSwitchTool(branch);
						case TypeSwitch.OutsideLineDisconnectorTool:
							return new OutsideLineDisconnectorTool(branch);
						}
						break;
					}
				}
				else
				{
					if (type == TypeSwitch.EndTrimTool)
					{
						return new EndTrimTool(branch);
					}
					switch (type)
					{
					case TypeSwitch.FuseTool:
						return new FuseTool(branch);
					case TypeSwitch.DischargerTool:
						return new DischargerTool(branch);
					case TypeSwitch.VoltageLimiterTool:
						return new VoltageLimiterTool(branch);
					case TypeSwitch.VoltageTransformerTool:
						return new VoltageTransformerTool(branch);
					}
				}
			}
			else if (type <= TypeSwitch.AmperageTransformer)
			{
				if (type == TypeSwitch.CircuitBreaker)
				{
					return new CircuitBreakerTool(branch);
				}
				switch (type)
				{
				case TypeSwitch.RPSTool:
					return new RPSTool(branch);
				case TypeSwitch.AmperageTransformer:
					return new AmperageTransformerTool(branch);
				}
			}
			else
			{
				switch (type)
				{
				case TypeSwitch.OffTool:
					return new OffTool(branch);
				case TypeSwitch.NotPhasedTool:
					return new NotPhasedTool(branch);
				default:
					switch (type)
					{
					case TypeSwitch.MagneticStarterTool:
						return new MagneticStarterTool(branch);
					case TypeSwitch.ElectricMeterTool:
						return new ElectricMeterTool(branch);
					}
					break;
				}
			}
			return null;
		}

		public static ObjectOnLine CreateObjectOnLine(TypeSwitch type, DataRow dataRow_0, Branch branch)
		{
			if (type <= TypeSwitch.VoltageTransformerTool)
			{
				if (type <= TypeSwitch.OutsideLineDisconnectorTool)
				{
					switch (type)
					{
					case TypeSwitch.ArrowTool:
						return new ArrowTool(dataRow_0, branch);
					case TypeSwitch.LinearDisconnectorToolWaxwork:
						return new LinearDisconnectorWaxworkTool(dataRow_0, branch);
					case TypeSwitch.LoadSwitchToolWaxwork:
						return new LoadSwitchWaxworkTool(dataRow_0, branch);
					case (TypeSwitch)6:
					case (TypeSwitch)7:
					case (TypeSwitch)8:
					case (TypeSwitch)9:
						break;
					case TypeSwitch.SeparatorTool:
						return new SeparatorTool(dataRow_0, branch);
					case TypeSwitch.ComplexSwitchgearTool:
						return new ComplexSwitchgearTool(dataRow_0, branch);
					default:
						switch (type)
						{
						case TypeSwitch.LubricantSwitchTool:
							return new LubricantSwitchTool(dataRow_0, branch);
						case TypeSwitch.LinearDisconnectorTool:
							return new LinearDisconnectorTool(dataRow_0, branch);
						case TypeSwitch.LoadSwitchTool:
							return new LoadSwitchTool(dataRow_0, branch);
						case TypeSwitch.GroundingTool:
							return new GroundingTool(dataRow_0, branch);
						case TypeSwitch.TransformerTool:
							return new TransformerTool(dataRow_0, branch);
						case TypeSwitch.DamageTool:
							return new DamageTool(dataRow_0, branch);
						case TypeSwitch.VacuumSwitchTool:
							return new VacuumSwitchTool(dataRow_0, branch);
						case TypeSwitch.OutsideLineDisconnectorTool:
							return new OutsideLineDisconnectorTool(dataRow_0, branch);
						}
						break;
					}
				}
				else
				{
					if (type == TypeSwitch.EndTrimTool)
					{
						return new EndTrimTool(dataRow_0, branch);
					}
					switch (type)
					{
					case TypeSwitch.FuseTool:
						return new FuseTool(dataRow_0, branch);
					case TypeSwitch.DischargerTool:
						return new DischargerTool(dataRow_0, branch);
					case TypeSwitch.VoltageLimiterTool:
						return new VoltageLimiterTool(dataRow_0, branch);
					case TypeSwitch.VoltageTransformerTool:
						return new VoltageTransformerTool(dataRow_0, branch);
					}
				}
			}
			else if (type <= TypeSwitch.AmperageTransformer)
			{
				if (type == TypeSwitch.CircuitBreaker)
				{
					return new CircuitBreakerTool(dataRow_0, branch);
				}
				switch (type)
				{
				case TypeSwitch.RPSTool:
					return new RPSTool(dataRow_0, branch);
				case TypeSwitch.AmperageTransformer:
					return new AmperageTransformerTool(dataRow_0, branch);
				}
			}
			else
			{
				switch (type)
				{
				case TypeSwitch.OffTool:
					return new OffTool(dataRow_0, branch);
				case TypeSwitch.NotPhasedTool:
					return new NotPhasedTool(dataRow_0, branch);
				default:
					switch (type)
					{
					case TypeSwitch.MagneticStarterTool:
						return new MagneticStarterTool(dataRow_0, branch);
					case TypeSwitch.ElectricMeterTool:
						return new ElectricMeterTool(dataRow_0, branch);
					}
					break;
				}
			}
			return null;
		}

		public override bool ObjectInRectangle(CanvasControl canvas, RectangleF rect, bool anyPoint)
		{
			return Class88.smethod_1(this.Points.ToArray(), rect);
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
				this.ShowPropertyForm(new Point(Convert.ToInt32(this.centerPoint.X), Convert.ToInt32(this.centerPoint.Y)));
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
			if (this.points.Count > 0)
			{
				empty.Location = this.points[0].Point;
				empty.Size = new SizeF(0f, 0f);
				float num = empty.Left;
				float num2 = empty.Right;
				float num3 = empty.Top;
				float num4 = empty.Bottom;
				foreach (UnitPoint unitPoint in this.points)
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
			if (this.points.Count > 0)
			{
				empty.Location = this.points[0].Point;
				empty.Size = new SizeF(0f, 0f);
				float num = empty.Left;
				float num2 = empty.Right;
				float num3 = empty.Top;
				float num4 = empty.Bottom;
				foreach (UnitPoint unitPoint in this.points)
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
			if (this.positionDamage != ePositionText.None)
			{
				using (Pen pen = new Pen(canvas.Settings.ObjectOnLineDamageStateColor))
				{
					RectangleF boundingRect = this.GetBoundingRect(canvas, false);
					UnitPoint item = new UnitPoint((double)boundingRect.Right, (double)boundingRect.Bottom);
					switch (this.positionDamage)
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
				switch (this.positionKey)
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

		public override string GetUpdateScriptXML(bool children, List<int> list_1)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.IdBase > 0)
			{
				stringBuilder.Append(this.Parent.Parent.GetUpdateScriptXML(children, list_1));
				this.UpdateXML();
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
				if (list_1.Contains(this.IdBase))
				{
					result = "";
				}
				else
				{
					list_1.Add(this.IdBase);
				}
				return result;
			}
			if ((base.GetType().BaseType == typeof(ObjectOnLine) && this.MappingState) || base.GetType() == typeof(TextBranchTool))
			{
				return this.Parent.Parent.GetUpdateScriptXML(children, list_1);
			}
			return string.Empty;
		}

		protected override void UpdateXML()
		{
			if (base.GetType() != typeof(ArrowTool))
			{
				base.UpdateXML();
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
			this.pointsRectangle.Add(new UnitPoint(-0.1, -0.2));
			this.pointsRectangle.Add(new UnitPoint(-0.1, 0.2));
			this.pointsRectangle.Add(new UnitPoint(0.1, 0.2));
			this.pointsRectangle.Add(new UnitPoint(0.12, -0.2));
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

		protected virtual void ExportDXFSolid(DxfDocument document, List<UnitPoint> list_1)
		{
			document.AddEntity(new Solid
			{
				FirstVertex = new Vector3(list_1[0].X, list_1[0].Y, 1.0),
				SecondVertex = new Vector3(list_1[1].X, list_1[1].Y, 1.0),
				ThirdVertex = new Vector3(list_1[2].X, list_1[2].Y, 1.0),
				FourthVertex = new Vector3(list_1[3].X, list_1[3].Y, 1.0),
				Color = 
				{
					Index = 256
				},
				Layer = new Layer("Switches")
			});
		}

		private bool bool_0;

		private List<UnitPoint> points = new List<UnitPoint>();

		private List<UnitPoint> detailedModePoints = new List<UnitPoint>();

		private UnitPoint centerPoint;

		private double delta = double.NaN;

		private float angle = float.NaN;

		protected bool systemChanging;

		private bool vertMirror;

		private bool gorMirorr;

		private Color colorOff = Color.Black;

		private Color colorOffN = Color.Black;

		private bool isNormalSection;

		private TextFont textPropertyNormalSection = new TextFont("Arial", 15f, false, false, false, ePositionText.T, false, false, Color.White);

		private bool mappingState;

		private LineToolState state;

		private ePositionText positionDamage = ePositionText.None;

		private ePositionText positionKey = ePositionText.None;

		private string text = "Выключатель";

		private ComplexSwitchgearTool complexSwitchgear;

		private bool normalSectionModeOn;

		private bool containsGrounding;

		private bool containsGroundingOn;

		public bool erSwitch;

		private List<UnitPoint> pointsRectangle = new List<UnitPoint>();
	}
}
