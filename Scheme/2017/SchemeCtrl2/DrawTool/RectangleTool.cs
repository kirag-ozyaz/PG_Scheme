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
	public class RectangleTool : DrawObjectBase
	{
		public event ResizeRectangleTool ResizeRectangle
		{
			[CompilerGenerated]
			add
			{
				ResizeRectangleTool resizeRectangleTool = this.resizeRectangleTool_0;
				ResizeRectangleTool resizeRectangleTool2;
				do
				{
					resizeRectangleTool2 = resizeRectangleTool;
					ResizeRectangleTool value2 = (ResizeRectangleTool)Delegate.Combine(resizeRectangleTool2, value);
					resizeRectangleTool = Interlocked.CompareExchange<ResizeRectangleTool>(ref this.resizeRectangleTool_0, value2, resizeRectangleTool2);
				}
				while (resizeRectangleTool != resizeRectangleTool2);
			}
			[CompilerGenerated]
			remove
			{
				ResizeRectangleTool resizeRectangleTool = this.resizeRectangleTool_0;
				ResizeRectangleTool resizeRectangleTool2;
				do
				{
					resizeRectangleTool2 = resizeRectangleTool;
					ResizeRectangleTool value2 = (ResizeRectangleTool)Delegate.Remove(resizeRectangleTool2, value);
					resizeRectangleTool = Interlocked.CompareExchange<ResizeRectangleTool>(ref this.resizeRectangleTool_0, value2, resizeRectangleTool2);
				}
				while (resizeRectangleTool != resizeRectangleTool2);
			}
		}

		public event EventHandler ChangeTypeRectangleTool
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

		public virtual string ObjectType
		{
			get
			{
				return "Rectangle";
			}
		}

		public override int NodeCount
		{
			get
			{
				return 8;
			}
		}

		public virtual RectangleF Rectangle
		{
			get
			{
				return this.rectangleF_0;
			}
			set
			{
				this.rectangleF_0 = value;
			}
		}

		public eTypeRectangleTool TypeRectnagleTool
		{
			get
			{
				return this.eTypeRectangleTool_0;
			}
			set
			{
				if (this.eTypeRectangleTool_0 != value)
				{
					this.eventHandler_0(this, new EventArgs());
					this.eTypeRectangleTool_0 = value;
				}
			}
		}

		public override Color Color
		{
			get
			{
				if (this.Layer != null && this.Layer.Parent != null && base.UseSettingColor)
				{
					eTypeRectangleTool typeRectnagleTool = this.TypeRectnagleTool;
					switch (typeRectnagleTool)
					{
					case eTypeRectangleTool.PP:
						return this.Layer.Parent.Settings.RectanglePPColor;
					case eTypeRectangleTool.CP:
						return this.Layer.Parent.Settings.RectangleCPColor;
					case eTypeRectangleTool.RP:
						return this.Layer.Parent.Settings.RectangleRPColor;
					case eTypeRectangleTool.TP:
						return this.Layer.Parent.Settings.RectangleTPColor;
					default:
						if (typeRectnagleTool == eTypeRectangleTool.SP)
						{
							return this.Layer.Parent.Settings.RectangleSPColor;
						}
						if (typeRectnagleTool == eTypeRectangleTool.PPNO)
						{
							return this.Layer.Parent.Settings.RectanglePPNOColor;
						}
						break;
					}
				}
				return base.Color;
			}
			set
			{
				base.Color = value;
			}
		}

		public override TextFont TextProperty
		{
			get
			{
				if (this.Layer != null && base.UseSettingsText)
				{
					TextFont textFont = base.TextProperty;
					eTypeRectangleTool typeRectnagleTool = this.TypeRectnagleTool;
					switch (typeRectnagleTool)
					{
					case eTypeRectangleTool.PP:
						textFont = this.Layer.Parent.Settings.TextPropertyPP;
						break;
					case eTypeRectangleTool.CP:
						textFont = this.Layer.Parent.Settings.TextPropertyCP;
						break;
					case eTypeRectangleTool.RP:
						textFont = this.Layer.Parent.Settings.TextPropertyRP;
						break;
					case eTypeRectangleTool.TP:
						textFont = this.Layer.Parent.Settings.TextPropertyTP;
						break;
					default:
						if (typeRectnagleTool != eTypeRectangleTool.SP)
						{
							if (typeRectnagleTool == eTypeRectangleTool.PPNO)
							{
								textFont = this.Layer.Parent.Settings.TextPropertyPPNO;
							}
						}
						else
						{
							textFont = this.Layer.Parent.Settings.TextPropertySP;
						}
						break;
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

		public bool IsSubscriber
		{
			get
			{
				return this.bool_7;
			}
			set
			{
				this.bool_7 = value;
			}
		}

		public RectangleTool()
		{
			Class90.TDroV38zslI2T();
			this.eTypeRectangleTool_0 = eTypeRectangleTool.TP;
			this.string_2 = "АБ";
			base..ctor();
			this.TextProperty.Visible = false;
			this.ChangeTypeRectangleTool += this.RectangleTool_ChangeTypeRectangleTool;
			this.ResizeRectangle += this.method_7;
		}

		public RectangleTool(DataRow r, DrawingLayer layer)
		{
			Class90.TDroV38zslI2T();
			this.eTypeRectangleTool_0 = eTypeRectangleTool.TP;
			this.string_2 = "АБ";
			base..ctor(r);
			this.TextProperty.Visible = false;
			this.ChangeTypeRectangleTool += this.RectangleTool_ChangeTypeRectangleTool;
			this.ResizeRectangle += this.method_7;
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)r["SchemaXml"]);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/Obj");
			this.TypeRectnagleTool = (eTypeRectangleTool)Convert.ToInt32(r["TypeCodeId"]);
			this.Rectangle = new RectangleF(Convert.ToSingle(xmlNode.Attributes[0].Value, new CultureInfo(1033)), Convert.ToSingle(xmlNode.Attributes[1].Value, new CultureInfo(1033)), Convert.ToSingle(xmlNode.Attributes[2].Value, new CultureInfo(1033)), Convert.ToSingle(xmlNode.Attributes[3].Value, new CultureInfo(1033)));
			XmlAttribute xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("Subscriber");
			this.IsSubscriber = false;
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("textVis");
			if (xmlAttribute != null)
			{
				this.TextProperty.Visible = Convert.ToBoolean(xmlAttribute.Value);
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("textPos");
				if (xmlAttribute != null)
				{
					this.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("fontVert");
				if (xmlAttribute != null)
				{
					this.TextProperty.FontVirtical = Convert.ToBoolean(xmlAttribute.Value);
				}
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("Visible");
			if (xmlAttribute != null)
			{
				this.Visible = Convert.ToBoolean(xmlAttribute.Value);
			}
			else
			{
				this.Visible = false;
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
			layer.AddObject(this);
			bool flag = false;
			XmlNode xmlNode2 = xmlNode.SelectSingleNode("AVR");
			if (xmlNode2 != null)
			{
				AutomaticEntryProvisionTool automaticEntryProvisionTool = new AutomaticEntryProvisionTool();
				automaticEntryProvisionTool.Location = new UnitPoint((double)Convert.ToSingle(xmlNode2.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode2.Attributes[1].Value, new CultureInfo(1033)));
				automaticEntryProvisionTool.Parent = this;
				if (layer != null)
				{
					layer.AddObject(automaticEntryProvisionTool);
				}
				if (!layer.Parent.Connected)
				{
					automaticEntryProvisionTool.method_4(false, true);
				}
				flag = true;
			}
			xmlNode2 = xmlNode.SelectSingleNode("Lock");
			if (xmlNode2 != null)
			{
				SpecialLockingTool specialLockingTool = new SpecialLockingTool();
				specialLockingTool.Location = new UnitPoint((double)Convert.ToSingle(xmlNode2.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode2.Attributes[1].Value, new CultureInfo(1033)));
				specialLockingTool.Parent = this;
				if (layer != null)
				{
					layer.AddObject(specialLockingTool);
				}
				if (!layer.Parent.Connected)
				{
					specialLockingTool.method_4(false, true);
				}
				flag = true;
			}
			xmlNode2 = xmlNode.SelectSingleNode("TM");
			if (xmlNode2 != null)
			{
				TelemechanicsTool telemechanicsTool = new TelemechanicsTool();
				telemechanicsTool.Location = new UnitPoint((double)Convert.ToSingle(xmlNode2.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode2.Attributes[1].Value, new CultureInfo(1033)));
				telemechanicsTool.Parent = this;
				if (layer != null)
				{
					layer.AddObject(telemechanicsTool);
				}
				if (!layer.Parent.Connected)
				{
					telemechanicsTool.method_4(false, true);
				}
				flag = true;
			}
			xmlNode2 = xmlNode.SelectSingleNode("TMProtect");
			if (xmlNode2 != null)
			{
				TelemechanicsProtectionTool telemechanicsProtectionTool = new TelemechanicsProtectionTool();
				telemechanicsProtectionTool.Location = new UnitPoint((double)Convert.ToSingle(xmlNode2.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode2.Attributes[1].Value, new CultureInfo(1033)));
				telemechanicsProtectionTool.Parent = this;
				if (layer != null)
				{
					layer.AddObject(telemechanicsProtectionTool);
				}
				if (!layer.Parent.Connected)
				{
					telemechanicsProtectionTool.method_4(false, true);
				}
				flag = true;
			}
			xmlNode2 = xmlNode.SelectSingleNode("ResponsibleAbn");
			if (xmlNode2 != null)
			{
				ResponsibleAbonentTool responsibleAbonentTool = new ResponsibleAbonentTool();
				responsibleAbonentTool.Location = new UnitPoint((double)Convert.ToSingle(xmlNode2.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode2.Attributes[1].Value, new CultureInfo(1033)));
				responsibleAbonentTool.Text = xmlNode2.Attributes[2].Value.ToString();
				responsibleAbonentTool.Parent = this;
				if (layer != null)
				{
					layer.AddObject(responsibleAbonentTool);
				}
				if (!layer.Parent.Connected)
				{
					responsibleAbonentTool.method_4(false, true);
				}
				flag = true;
			}
			if (flag)
			{
				this.SaveToSql();
			}
		}

		private void RectangleTool_ChangeTypeRectangleTool(object sender, EventArgs e)
		{
		}

		public void RotateAboutThePoint(double angle, UnitPoint centerOfRotation)
		{
			bool flag = false;
			if (angle == 180.0)
			{
				flag = true;
			}
			else if (angle == 90.0 || angle == 270.0)
			{
				UnitPoint unitPoint = new UnitPoint(this.rectangleF_0.Location);
				double num = unitPoint.X - centerOfRotation.X;
				double num2 = unitPoint.Y - centerOfRotation.Y;
				double num3 = Convert.ToDouble(Math.Cos(1.5707963267948966));
				double num4 = Convert.ToDouble(Math.Sin(1.5707963267948966));
				double value = (double)centerOfRotation.Point.X + num * num3 - num2 * num4;
				double value2 = (double)centerOfRotation.Point.Y + num * num4 + num2 * num3;
				this.rectangleF_0.Width = this.rectangleF_0.Width + this.rectangleF_0.Height;
				this.rectangleF_0.Height = this.rectangleF_0.Width - this.rectangleF_0.Height;
				this.rectangleF_0.Width = this.rectangleF_0.Width - this.rectangleF_0.Height;
				this.rectangleF_0.Location = new PointF(Convert.ToSingle(value) - this.rectangleF_0.Width, Convert.ToSingle(value2));
				flag = true;
			}
			if (!flag)
			{
				return;
			}
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(ShinaTool))
				{
					((ShinaTool)drawObjectBase).RotateAboutThePoint(angle, centerOfRotation);
				}
			}
		}

		public override void Copy(DrawObjectBase acopy)
		{
			base.Copy(acopy);
			if (acopy.GetType() == typeof(RectangleTool))
			{
				this.rectangleF_0 = new RectangleF(((RectangleTool)acopy).Rectangle.Location, ((RectangleTool)acopy).Rectangle.Size);
				this.TypeRectnagleTool = ((RectangleTool)acopy).TypeRectnagleTool;
				this.IdOldBase = ((RectangleTool)acopy).IdOldBase;
				this.IsSubscriber = ((RectangleTool)acopy).IsSubscriber;
			}
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			RectangleTool rectangleTool = new RectangleTool();
			rectangleTool.Copy(this);
			return rectangleTool;
		}

		public override void Move(UnitPoint offset, bool selectedMove)
		{
			if (!selectedMove && this.Selected)
			{
				return;
			}
			this.rectangleF_0.X = this.rectangleF_0.X + (float)offset.X;
			this.rectangleF_0.Y = this.rectangleF_0.Y + (float)offset.Y;
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				drawObjectBase.Move(offset, false);
			}
		}

		public override ISnapPoint SnapPoint(CanvasControl canvas, UnitPoint point, List<DrawObjectBase> otherobjs, Type[] runningsnaptypes, Type usersnaptype)
		{
			if (!this.Visible)
			{
				return null;
			}
			float float_ = base.ThresholdWidth(canvas, base.Width);
			for (int i = 0; i < this.NodeCount; i++)
			{
				UnitPoint node = this.GetNode(i);
				if (Class79.XrgxasnnaZ(node, float_, point))
				{
					return new Class8(canvas, this, node);
				}
			}
			return null;
		}

		public override RectangleF GetBoundingRect(CanvasControl canvas, bool inflate)
		{
			float num = base.ThresholdWidth(canvas, base.Width);
			double num2 = (double)Math.Min(this.rectangleF_0.Left, this.rectangleF_0.Right);
			double num3 = (double)Math.Min(this.rectangleF_0.Top, this.rectangleF_0.Bottom);
			double num4 = (double)Math.Abs(this.rectangleF_0.Left - this.rectangleF_0.Right);
			double num5 = (double)Math.Abs(this.rectangleF_0.Top - this.rectangleF_0.Bottom);
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

		protected override RectangleF GetRectangleText(CanvasControl canvas)
		{
			RectangleF empty = RectangleF.Empty;
			float num = (this.rectangleF_0.Left < this.rectangleF_0.Right) ? this.rectangleF_0.Left : this.rectangleF_0.Right;
			float num2 = (this.rectangleF_0.Left > this.rectangleF_0.Right) ? this.rectangleF_0.Left : this.rectangleF_0.Right;
			float num3 = (this.rectangleF_0.Top < this.rectangleF_0.Bottom) ? this.rectangleF_0.Top : this.rectangleF_0.Bottom;
			float num4 = (this.rectangleF_0.Top > this.rectangleF_0.Bottom) ? this.rectangleF_0.Top : this.rectangleF_0.Bottom;
			RectangleF rectangleF = new RectangleF(num, num3, num2 - num, num4 - num3);
			if (this.TextProperty.Visible)
			{
				Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style);
				string text = this.Text;
				eTypeRectangleTool typeRectnagleTool = this.TypeRectnagleTool;
				switch (typeRectnagleTool)
				{
				case eTypeRectangleTool.PP:
					text = "ПП-" + text;
					break;
				case eTypeRectangleTool.CP:
					text = "ЦП-" + text;
					break;
				case eTypeRectangleTool.RP:
					text = "РП-" + text;
					break;
				case eTypeRectangleTool.TP:
					text = "ТП-" + text;
					break;
				default:
					if (typeRectnagleTool != eTypeRectangleTool.SP)
					{
						if (typeRectnagleTool == eTypeRectangleTool.PPNO)
						{
							text = "ППНО-" + text;
						}
					}
					else
					{
						text = "CП-" + text;
					}
					break;
				}
				if (this.IsSubscriber)
				{
					text = text + " " + this.string_2;
				}
				SizeF sizeF = canvas.Graphics.MeasureString(text, font);
				font.Dispose();
				SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
				empty = new RectangleF(rectangleF.Location, size);
				if (this.TextProperty.FontVirtical)
				{
					empty.Width = size.Height;
					empty.Height = size.Width;
				}
				float num5 = this.IsSubscriber ? ((float)ConvertCanvas.ConvertToUnit(canvas, 2f)) : 0f;
				switch (this.TextProperty.Position)
				{
				case ePositionText.LT:
					if (this.TextProperty.FontVirtical)
					{
						empty.X = rectangleF.Location.X - empty.Width - num5;
						empty.Y = rectangleF.Location.Y + rectangleF.Height - empty.Height;
					}
					else
					{
						empty.X = rectangleF.Location.X;
						empty.Y = rectangleF.Location.Y + rectangleF.Height + num5;
					}
					break;
				case ePositionText.T:
					empty.X = rectangleF.Location.X + rectangleF.Width / 2f - empty.Width / 2f;
					empty.Y = rectangleF.Location.Y + rectangleF.Height + num5;
					break;
				case ePositionText.RT:
					if (this.TextProperty.FontVirtical)
					{
						empty.X = rectangleF.Location.X + rectangleF.Width + num5;
						empty.Y = rectangleF.Location.Y + rectangleF.Height - empty.Height;
					}
					else
					{
						empty.X = rectangleF.Location.X + rectangleF.Width - empty.Width;
						empty.Y = rectangleF.Location.Y + rectangleF.Height + num5;
					}
					break;
				case ePositionText.R:
					empty.X = rectangleF.Location.X + rectangleF.Width + num5;
					empty.Y = rectangleF.Location.Y + rectangleF.Height / 2f - empty.Height / 2f;
					break;
				case ePositionText.RB:
					if (this.TextProperty.FontVirtical)
					{
						empty.X = rectangleF.Location.X + rectangleF.Width + num5;
						empty.Y = rectangleF.Location.Y;
					}
					else
					{
						empty.X = rectangleF.Location.X + rectangleF.Width - empty.Width;
						empty.Y = rectangleF.Location.Y - empty.Height - num5;
					}
					break;
				case ePositionText.B:
					empty.X = rectangleF.Location.X + rectangleF.Width / 2f - empty.Width / 2f;
					empty.Y = rectangleF.Location.Y - empty.Height - num5;
					break;
				case ePositionText.LB:
					if (this.TextProperty.FontVirtical)
					{
						empty.X = rectangleF.Location.X - empty.Width - num5;
						empty.Y = rectangleF.Location.Y;
					}
					else
					{
						empty.X = rectangleF.Location.X;
						empty.Y = rectangleF.Location.Y - empty.Height - num5;
					}
					break;
				case ePositionText.L:
					empty.X = rectangleF.Location.X - empty.Width - num5;
					empty.Y = rectangleF.Location.Y + rectangleF.Height / 2f - empty.Height / 2f;
					break;
				}
				return empty;
			}
			return empty;
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
				if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
				{
					if ((drawMode & eDrawMode.Color) != eDrawMode.Color)
					{
						pen.Color = Color.Black;
					}
				}
				else if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
				{
					if (base.Bookmark != null)
					{
						pen.Color = canvas.Settings.MarkedObjColor;
					}
					if (this.Selected)
					{
						pen.Color = this.SelectedColor;
					}
					if (this.Flashing && canvas.ConvertColorFlash)
					{
						pen.Color = canvas.Settings.BackFlashingColor;
					}
				}
				else
				{
					if (base.Bookmark != null)
					{
						pen.Color = Color.LightGray;
					}
					if (this.Selected)
					{
						pen.Color = Color.Gray;
					}
					if (this.Flashing && canvas.ConvertColorFlash)
					{
						pen.Color = Color.White;
					}
				}
				pen.EndCap = LineCap.Round;
				pen.StartCap = LineCap.Round;
				PointF pointF = ConvertCanvas.ConvertToScreen(canvas, new UnitPoint(this.rectangleF_0.Location));
				PointF pointF2 = ConvertCanvas.ConvertToScreen(canvas, new UnitPoint((double)this.rectangleF_0.Right, (double)this.rectangleF_0.Bottom));
				float num = Math.Min(pointF.X, pointF2.X);
				float num2 = Math.Min(pointF.Y, pointF2.Y);
				float num3 = Math.Max(pointF.X, pointF2.X);
				float num4 = Math.Max(pointF.Y, pointF2.Y);
				canvas.Graphics.DrawRectangle(pen, num, num2, num3 - num, num4 - num2);
				this.DrawText(canvas, drawMode);
				if (this.Selected && (drawMode & eDrawMode.Print) != eDrawMode.Print)
				{
					base.DrawTracker(canvas);
				}
			}
		}

		protected override void DrawText(CanvasControl canvas, eDrawMode drawMode = eDrawMode.Color)
		{
			if (this.Visible && this.TextProperty.Visible)
			{
				if (base.UseSettingsText && this.TextProperty.FontSize * canvas.Zoom <= canvas.Settings.FontSizeNoVisible)
				{
					return;
				}
				using (Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style))
				{
					RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetRectangleText(canvas));
					GraphicsState gstate = canvas.Graphics.Save();
					if (this.TextProperty.FontVirtical)
					{
						Matrix transform = canvas.Graphics.Transform;
						rectangleF.Y += rectangleF.Height;
						transform.RotateAt(-90f, rectangleF.Location, MatrixOrder.Append);
						canvas.Graphics.Transform = transform;
					}
					if (rectangleF.Size.Width > 0f && rectangleF.Size.Height > 0f)
					{
						using (SolidBrush solidBrush = new SolidBrush(this.TextProperty.Color))
						{
							if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
							{
								if ((drawMode & eDrawMode.Color) != eDrawMode.Color)
								{
									solidBrush.Color = Color.Black;
								}
								else if (canvas.Settings.BackgroundColor.ToArgb() == solidBrush.Color.ToArgb() && solidBrush.Color.ToArgb() == Color.White.ToArgb())
								{
									solidBrush.Color = Color.Black;
								}
							}
							else if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
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
							canvas.Graphics.DrawString(this.ToString(), font, solidBrush, rectangleF.Location);
							if (this.IsSubscriber)
							{
								RectangleF rectangleF2 = new RectangleF(rectangleF.Location, new SizeF(0f, 0f));
								SizeF size = canvas.Graphics.MeasureString(this.string_2, font);
								rectangleF2 = new RectangleF(rectangleF2.Location, size);
								if (this.TextProperty.FontVirtical)
								{
									rectangleF2.X += rectangleF.Height - rectangleF2.Width;
								}
								else
								{
									rectangleF2.X += rectangleF.Width - rectangleF2.Width;
								}
								canvas.Graphics.DrawString(this.string_2, font, solidBrush, rectangleF2.Location);
								canvas.Graphics.DrawRectangle(new Pen(solidBrush.Color), rectangleF2.X, rectangleF2.Y, rectangleF2.Width, rectangleF2.Height);
							}
						}
					}
					canvas.Graphics.Restore(gstate);
				}
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			if (!this.Visible)
			{
				return;
			}
			PointF pointF = ConvertCanvas.ConvertToScreen(canvas, new UnitPoint(this.rectangleF_0.Location));
			PointF pointF2 = ConvertCanvas.ConvertToScreen(canvas, new UnitPoint((double)this.rectangleF_0.Right, (double)this.rectangleF_0.Bottom));
			float num = Math.Min(pointF.X, pointF2.X);
			float num2 = Math.Min(pointF.Y, pointF2.Y);
			float num3 = Math.Max(pointF.X, pointF2.X);
			float num4 = Math.Max(pointF.Y, pointF2.Y);
			Pen pen;
			if (isColor)
			{
				pen = new Pen((this.Color == Color.White) ? Color.Black : this.Color);
			}
			else
			{
				pen = new Pen(Color.Black);
			}
			g.DrawRectangle(pen, num, num2, num3 - num, num4 - num2);
			this.DrawText(canvas, eDrawMode.Print);
			pen.Dispose();
		}

		public override void InitializeFromModel(UnitPoint point, DrawingLayer layer, ISnapPoint snap)
		{
			this.rectangleF_0 = new RectangleF(point.Point, new SizeF(0f, 0f));
			base.Width = layer.Width;
			this.Color = layer.Color;
			this.Selected = true;
		}

		public override bool PointInObject(UnitPoint point)
		{
			if (this.Layer == null)
			{
				return false;
			}
			CanvasControl parent = this.Layer.Parent;
			float num = base.ThresholdWidth(parent, base.Width);
			UnitPoint unitPoint = new UnitPoint((double)this.Rectangle.X, (double)this.Rectangle.Y);
			UnitPoint unitPoint_ = new UnitPoint((double)(this.Rectangle.X + this.Rectangle.Width), (double)(this.Rectangle.Y + this.Rectangle.Height));
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
				this.clickedPoint = point;
				return true;
			}
			if (Class79.XrgxasnnaZ(unitPoint + new UnitPoint(unitPoint_.X - unitPoint.X, 0.0), num, point))
			{
				this.clickedPoint = point;
				return true;
			}
			if (Class79.XrgxasnnaZ(unitPoint + new UnitPoint(0.0, unitPoint_.Y - unitPoint.Y), num, point))
			{
				this.clickedPoint = point;
				return true;
			}
			if (Class79.XrgxasnnaZ(unitPoint_, num, point))
			{
				this.clickedPoint = point;
				return true;
			}
			double num6 = Math.Min(unitPoint.X, unitPoint_.X);
			double num7 = Math.Max(unitPoint.X, unitPoint_.X);
			double num8 = Math.Min(unitPoint.Y, unitPoint_.Y);
			double num9 = Math.Max(unitPoint.Y, unitPoint_.Y);
			if (point.X >= num6 - (double)num && point.X <= num7 + (double)num && point.Y >= num8 - (double)num && point.Y <= num9 + (double)num)
			{
				this.clickedPoint = point;
				return true;
			}
			return false;
		}

		public override bool ObjectInRectangle(CanvasControl canvas, RectangleF rect, bool anyPoint)
		{
			RectangleF boundingRect = this.GetBoundingRect(canvas, true);
			if (anyPoint)
			{
				UnitPoint unitPoint_ = new UnitPoint(boundingRect.Location);
				UnitPoint unitPoint_2 = new UnitPoint((double)(boundingRect.X + boundingRect.Width), (double)(boundingRect.Y + boundingRect.Height));
				return Class79.smethod_0(unitPoint_, unitPoint_2, rect);
			}
			return rect.Contains(boundingRect);
		}

		protected override UnitPoint GetNode(int nodeNumber)
		{
			float num = this.Rectangle.X + this.Rectangle.Width / 2f;
			float num2 = this.Rectangle.Y + this.Rectangle.Height / 2f;
			float num3 = this.Rectangle.X;
			float num4 = this.Rectangle.Y;
			switch (nodeNumber)
			{
			case 1:
				num3 = this.Rectangle.X;
				num4 = this.Rectangle.Y;
				break;
			case 2:
				num3 = num;
				num4 = this.Rectangle.Y;
				break;
			case 3:
				num3 = this.Rectangle.Right;
				num4 = this.Rectangle.Y;
				break;
			case 4:
				num3 = this.Rectangle.Right;
				num4 = num2;
				break;
			case 5:
				num3 = this.Rectangle.Right;
				num4 = this.Rectangle.Bottom;
				break;
			case 6:
				num3 = num;
				num4 = this.Rectangle.Bottom;
				break;
			case 7:
				num3 = this.Rectangle.X;
				num4 = this.Rectangle.Bottom;
				break;
			case 8:
				num3 = this.Rectangle.X;
				num4 = num2;
				break;
			}
			return new UnitPoint((double)num3, (double)num4);
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

		public override Cursor GetHandleCursor(int handleNumber)
		{
			if (this.Layer != null && this.Layer.Parent != null && this.Layer.Parent.Mode != eCanvasEditingMode.Edit)
			{
				return Cursors.Default;
			}
			switch (handleNumber)
			{
			case 1:
				return Cursors.SizeNESW;
			case 2:
				return Cursors.SizeNS;
			case 3:
				return Cursors.SizeNWSE;
			case 4:
				return Cursors.SizeWE;
			case 5:
				return Cursors.SizeNESW;
			case 6:
				return Cursors.SizeNS;
			case 7:
				return Cursors.SizeNWSE;
			case 8:
				return Cursors.SizeWE;
			default:
				return Cursors.Default;
			}
		}

		public override void MoveHandleTo(UnitPoint pointU, int handleNumber)
		{
			PointF point = pointU.Point;
			float num = this.rectangleF_0.Left;
			float num2 = this.rectangleF_0.Top;
			float num3 = this.rectangleF_0.Right;
			float num4 = this.rectangleF_0.Bottom;
			switch (handleNumber)
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
			this.rectangleF_0 = new RectangleF(num, num2, num3 - num, num4 - num2);
			UnitPoint unitPoint = new UnitPoint((double)num, (double)num2);
			UnitPoint unitPoint2 = new UnitPoint((double)this.rectangleF_0.Right, (double)this.rectangleF_0.Bottom);
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				this.Layer.Parent.Graphics = Graphics.FromHwnd(this.Layer.Parent.Handle);
				RectangleF boundingRect = drawObjectBase.GetBoundingRect(this.Layer.Parent, false);
				if (!boundingRect.IsEmpty)
				{
					UnitPoint unitPoint3 = new UnitPoint((double)boundingRect.Left, (double)boundingRect.Top);
					UnitPoint unitPoint4 = new UnitPoint((double)boundingRect.Right, (double)boundingRect.Bottom);
					if (unitPoint3.X < unitPoint.X)
					{
						unitPoint.X = unitPoint3.X;
					}
					if (unitPoint3.Y < unitPoint.Y)
					{
						unitPoint.Y = unitPoint3.Y;
					}
					if (unitPoint4.X < unitPoint.X)
					{
						unitPoint.X = unitPoint4.X;
					}
					if (unitPoint4.Y < unitPoint.Y)
					{
						unitPoint.Y = unitPoint4.Y;
					}
					if (unitPoint3.X > unitPoint2.X)
					{
						unitPoint2.X = unitPoint3.X;
					}
					if (unitPoint3.Y > unitPoint2.Y)
					{
						unitPoint2.Y = unitPoint3.Y;
					}
					if (unitPoint4.X > unitPoint2.X)
					{
						unitPoint2.X = unitPoint4.X;
					}
					if (unitPoint4.Y > unitPoint2.Y)
					{
						unitPoint2.Y = unitPoint4.Y;
					}
				}
			}
			if (unitPoint.X < (double)this.rectangleF_0.Left)
			{
				this.rectangleF_0.X = (float)unitPoint.X;
			}
			if (unitPoint.Y < (double)this.rectangleF_0.Top)
			{
				this.rectangleF_0.Y = (float)unitPoint.Y;
			}
			if (unitPoint2.X > (double)this.rectangleF_0.Right)
			{
				this.rectangleF_0.Width = (float)unitPoint2.X - this.rectangleF_0.Left;
			}
			if (unitPoint2.Y > (double)this.rectangleF_0.Bottom)
			{
				this.rectangleF_0.Height = (float)unitPoint2.Y - this.rectangleF_0.Top;
			}
			ResizeRectangleEventsArgs e = new ResizeRectangleEventsArgs(new RectangleF(num, num2, num3 - num, num4 - num2), handleNumber);
			this.resizeRectangleTool_0(this, e);
		}

		public override void Normalize()
		{
			float num = (this.rectangleF_0.Left < this.rectangleF_0.Right) ? this.rectangleF_0.Left : this.rectangleF_0.Right;
			float num2 = (this.rectangleF_0.Left > this.rectangleF_0.Right) ? this.rectangleF_0.Left : this.rectangleF_0.Right;
			float num3 = (this.rectangleF_0.Top < this.rectangleF_0.Bottom) ? this.rectangleF_0.Top : this.rectangleF_0.Bottom;
			float num4 = (this.rectangleF_0.Top > this.rectangleF_0.Bottom) ? this.rectangleF_0.Top : this.rectangleF_0.Bottom;
			this.rectangleF_0 = new RectangleF(num, num3, num2 - num, num4 - num3);
		}

		public override void EndDraw()
		{
			if (new FormRectangleProperties(this, this.Layer.Parent.SqlSettings).ShowDialog() != DialogResult.OK)
			{
				bool delSql = this.Layer != null && this.Layer.Parent != null && this.Layer.Parent.UseObjectFromDB;
				this.Remove(delSql, true);
			}
		}

		public override void vmethod_0(XmlNode xmlNode, List<PointTool> pointList)
		{
			XmlElement xmlElement = xmlNode.OwnerDocument.CreateElement("Group");
			xmlElement.SetAttribute("ID", this.IdBase.ToString());
			xmlElement.SetAttribute("X1", Math.Round((double)this.Rectangle.Location.X, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("Y1", Math.Round((double)this.Rectangle.Location.Y, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("X2", Math.Round((double)this.Rectangle.Size.Width, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("Y2", Math.Round((double)this.Rectangle.Size.Height, 4).ToString(new CultureInfo(1033)));
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
			xmlElement.SetAttribute("type", ((int)this.TypeRectnagleTool).ToString());
			xmlElement.SetAttribute("fontVert", this.TextProperty.FontVirtical.ToString());
			xmlElement.SetAttribute("Visible", this.Visible.ToString());
			xmlNode.AppendChild(xmlElement);
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				drawObjectBase.vmethod_0(xmlElement, pointList);
			}
		}

		public override void vmethod_2(CanvasControl canvas, Document document)
		{
			Vertex vertex = new Vertex((double)this.Rectangle.X, (double)this.Rectangle.Y, this.Layer.Name);
			document.add(vertex);
			Vertex vertex2 = new Vertex((double)(this.Rectangle.X + this.Rectangle.Width), (double)this.Rectangle.Y, this.Layer.Name);
			Vertex vertex3 = new Vertex((double)(this.Rectangle.X + this.Rectangle.Width), (double)(this.Rectangle.Y + this.Rectangle.Height), this.Layer.Name);
			Vertex vertex4 = new Vertex((double)this.Rectangle.X, (double)(this.Rectangle.Y + this.Rectangle.Height), this.Layer.Name);
			document.add(vertex);
			document.add(vertex2);
			document.add(vertex3);
			document.add(vertex4);
			PolyLine polyLine = new PolyLine(this.Layer.Name);
			polyLine.AddVertex(vertex);
			polyLine.AddVertex(vertex2);
			polyLine.AddVertex(vertex3);
			polyLine.AddVertex(vertex4);
			polyLine.AddVertex(vertex);
			document.add(polyLine);
		}

		public override void vmethod_3(CanvasControl canvas, DxfDocument document)
		{
			if (!this.Visible)
			{
				return;
			}
			List<LwPolylineVertex> list = new List<LwPolylineVertex>();
			LwPolylineVertex item = new LwPolylineVertex(new Vector2((double)this.Rectangle.X, (double)this.Rectangle.Y), 0.0);
			list.Add(item);
			item = new LwPolylineVertex(new Vector2((double)(this.Rectangle.X + this.Rectangle.Width), (double)this.Rectangle.Y), 0.0);
			list.Add(item);
			item = new LwPolylineVertex(new Vector2((double)(this.Rectangle.X + this.Rectangle.Width), (double)(this.Rectangle.Y + this.Rectangle.Height)), 0.0);
			list.Add(item);
			item = new LwPolylineVertex(new Vector2((double)this.Rectangle.X, (double)(this.Rectangle.Y + this.Rectangle.Height)), 0.0);
			list.Add(item);
			LwPolyline lwPolyline = new LwPolyline(list, true);
			lwPolyline.Color = new AciColor(this.Color);
			double num = 1.5;
			if (this.TextProperty.Visible)
			{
				RectangleF rectangleText = this.GetRectangleText(canvas);
				float num2 = this.TextProperty.FontVirtical ? rectangleText.Width : rectangleText.Height;
				if (this.TextProperty.FontVirtical)
				{
					rectangleText.X += rectangleText.Width;
				}
				Text text = new Text(this.ToString(), new Vector2((double)rectangleText.X, (double)rectangleText.Y), (double)num2 / num);
				text.Color = new AciColor(this.TextProperty.Color);
				if (this.TextProperty.FontVirtical)
				{
					text.Rotation = 90.0;
				}
				text.Style = new TextStyle(this.TextProperty.FontName);
				document.AddEntity(text);
			}
			document.AddEntity(lwPolyline);
		}

		public override string ToString()
		{
			eTypeRectangleTool typeRectnagleTool = this.TypeRectnagleTool;
			switch (typeRectnagleTool)
			{
			case eTypeRectangleTool.PP:
				return "ПП-" + this.Text;
			case eTypeRectangleTool.CP:
				return "ЦП-" + this.Text;
			case eTypeRectangleTool.RP:
				return "РП-" + this.Text;
			case eTypeRectangleTool.TP:
				return "ТП-" + this.Text;
			default:
				if (typeRectnagleTool == eTypeRectangleTool.SP)
				{
					return "СП-" + this.Text;
				}
				if (typeRectnagleTool != eTypeRectangleTool.PPNO)
				{
					return string.Empty;
				}
				return "ППНО-" + this.Text;
			}
		}

		public override List<DrawObjectBase> GetPowerSource()
		{
			List<DrawObjectBase> powerSource = base.GetPowerSource();
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(ShinaTool) && ((ShinaTool)drawObjectBase).Amperage != null)
				{
					powerSource.Add(drawObjectBase);
					powerSource.AddRange(drawObjectBase.GetPowerSource());
				}
			}
			return powerSource;
		}

		public override List<DrawObjectBase> GetRecipientsPower()
		{
			List<DrawObjectBase> recipientsPower = base.GetRecipientsPower();
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(ShinaTool) && ((ShinaTool)drawObjectBase).Amperage != null)
				{
					foreach (Amperage amperage in ((ShinaTool)drawObjectBase).Amperage.NextAmperages)
					{
						foreach (DrawObjectBase item in drawObjectBase.GetRecipientsPower())
						{
							recipientsPower.Add(item);
						}
					}
				}
			}
			return recipientsPower;
		}

		public LabelTool AddLabelTool(Type typeClass)
		{
			LabelTool labelTool = null;
			try
			{
				labelTool = (LabelTool)Activator.CreateInstance(typeClass);
			}
			catch
			{
			}
			if (labelTool == null)
			{
				return null;
			}
			if (this.clickedPoint.IsEmpty)
			{
				labelTool.Location = new UnitPoint(this.Rectangle.Location);
			}
			else
			{
				labelTool.Location = new UnitPoint(this.clickedPoint.Point);
			}
			labelTool.Parent = this;
			if (this.Layer != null)
			{
				this.Layer.AddObject(labelTool);
			}
			return labelTool;
		}

		public LabelTool AddLabelTool(DataRow r)
		{
			LabelTool labelTool = null;
			Type type = null;
			switch (Convert.ToInt32(r["TypeLabel"]))
			{
			case 1:
				type = typeof(AutomaticEntryProvisionTool);
				break;
			case 2:
				type = typeof(SpecialLockingTool);
				break;
			case 3:
				type = typeof(TelemechanicsTool);
				break;
			case 4:
				type = typeof(TelemechanicsProtectionTool);
				break;
			case 5:
				type = typeof(ResponsibleAbonentTool);
				break;
			case 7:
				type = typeof(VideoTool);
				break;
			}
			try
			{
				labelTool = (LabelTool)Activator.CreateInstance(type);
			}
			catch
			{
			}
			if (labelTool == null)
			{
				return null;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)r["XmlCoords"]);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/Obj");
			labelTool.IdBase = Convert.ToInt32(r["id"]);
			labelTool.Location = new UnitPoint((double)Convert.ToSingle(xmlNode.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode.Attributes[1].Value, new CultureInfo(1033)));
			if (labelTool.GetType() == typeof(ResponsibleAbonentTool))
			{
				labelTool.Text = r["Name"].ToString();
			}
			XmlAttribute xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontName");
			if (xmlAttribute != null)
			{
				labelTool.UseSettingsText = false;
				labelTool.TextProperty.FontName = xmlAttribute.Value;
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontSize");
				if (xmlAttribute != null)
				{
					labelTool.TextProperty.FontSize = Convert.ToSingle(xmlAttribute.Value, new CultureInfo(1033));
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontBold");
				if (xmlAttribute != null)
				{
					labelTool.TextProperty.FontBold = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontItalic");
				if (xmlAttribute != null)
				{
					labelTool.TextProperty.FontItalic = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontUnderline");
				if (xmlAttribute != null)
				{
					labelTool.TextProperty.FontUnderline = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontColor");
				if (xmlAttribute != null)
				{
					labelTool.TextProperty.Color = Color.FromArgb(Convert.ToInt32(xmlAttribute.Value));
				}
			}
			else
			{
				labelTool.UseSettingsText = true;
			}
			labelTool.Parent = this;
			if (this.Layer != null)
			{
				this.Layer.AddObject(labelTool);
			}
			return labelTool;
		}

		public void RemoveLabelTool(Type typeClass)
		{
			bool flag = false;
			for (int i = this.ChildObjects.ToArray<DrawObjectBase>().Length - 1; i >= 0; i--)
			{
				if (this.ChildObjects.ToArray<DrawObjectBase>()[i].GetType() == typeClass)
				{
					this.ChildObjects.ToArray<DrawObjectBase>()[i].Remove(true, false);
					flag = true;
				}
			}
			if (flag)
			{
				this.SaveXmlToSql();
			}
		}

		public override void OnMouseMove(CanvasControl canvas, UnitPoint point, MouseButtons button)
		{
			if (button == MouseButtons.Left)
			{
				eCommandType eCommandType_ = canvas.eCommandType_0;
				if (eCommandType_ == eCommandType.draw)
				{
					RectangleF unitrect = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetBoundingRect(canvas, true));
					unitrect.Inflate(2f, 2f);
					canvas.method_21(new Rectangle((int)unitrect.X, (int)unitrect.Y, (int)unitrect.Width, (int)unitrect.Height));
					this.MoveHandleTo(point, 5);
					this.Draw(canvas, unitrect, eDrawMode.Color);
				}
			}
		}

		private void method_7(RectangleTool rectangleTool_0, ResizeRectangleEventsArgs resizeRectangleEventsArgs_0)
		{
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(this.TypeRectnagleTool);
		}

		public override bool ShowPropertyForm(Point location)
		{
			if (new FormRectangleProperties(this, this.Layer.Parent.SqlSettings)
			{
				Location = location
			}.ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
				return true;
			}
			return false;
		}

		protected override void vmethod_4()
		{
			base.vmethod_4();
			((XmlElement)this.currentXmlScheme).SetAttribute("X1", Math.Round((double)this.Rectangle.Location.X, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("Y1", Math.Round((double)this.Rectangle.Location.Y, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("X2", Math.Round((double)this.Rectangle.Size.Width, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("Y2", Math.Round((double)this.Rectangle.Size.Height, 4).ToString(new CultureInfo(1033)));
			if (this.IsSubscriber)
			{
				((XmlElement)this.currentXmlScheme).SetAttribute("Subscriber", this.IsSubscriber.ToString());
			}
			if (this.TextProperty.Visible)
			{
				((XmlElement)this.currentXmlScheme).SetAttribute("textVis", this.TextProperty.Visible.ToString());
				((XmlElement)this.currentXmlScheme).SetAttribute("textPos", ((int)this.TextProperty.Position).ToString());
				((XmlElement)this.currentXmlScheme).SetAttribute("fontVert", this.TextProperty.FontVirtical.ToString());
			}
			if (this.Visible)
			{
				((XmlElement)this.currentXmlScheme).SetAttribute("Visible", this.Visible.ToString());
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
			}
		}

		[CompilerGenerated]
		private ResizeRectangleTool resizeRectangleTool_0;

		[CompilerGenerated]
		private EventHandler eventHandler_0;

		private RectangleF rectangleF_0;

		private eTypeRectangleTool eTypeRectangleTool_0;

		private bool bool_7;

		private string string_2;

		public UnitPoint clickedPoint;
	}
}
