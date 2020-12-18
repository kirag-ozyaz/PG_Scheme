using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool.FormsObj;
using Telemetry;

namespace SchemeCtrl2.DrawTool
{
	public class TelemetryLabelTool : FreeLabelTool
	{
		public TelemetryLabelTool()
		{
			this.Text = string.Empty;
		}

		public TelemetryLabelTool(DataRow dataRow_0) : base(dataRow_0)
		{
			this.Text = string.Empty;
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)dataRow_0["XmlCoords"]);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/Obj");
			XmlAttribute xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("ObjectTelemetry");
			if (xmlAttribute != null)
			{
				this.ObjectTelemetry = Convert.ToInt32(xmlAttribute.Value);
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("TelemetryParameterId");
			if (xmlAttribute != null)
			{
				this.TelemetryParameterId = Convert.ToInt32(xmlAttribute.Value);
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("Prefix");
			if (xmlAttribute != null)
			{
				this.Prefix = xmlAttribute.Value;
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("DecimalPlaces");
			if (xmlAttribute != null)
			{
				this.DecimalPlaces = Convert.ToInt32(xmlAttribute.Value);
			}
		}

		public int ObjectTelemetry { get; set; }

		public int TelemetryParameterId { get; set; }

		public override bool Visible
		{
			get
			{
				return this.Layer.Parent.TelemetryLabelVisible && base.Visible;
			}
			set
			{
				base.Visible = value;
			}
		}

		public override string Text
		{
			get
			{
				string result = base.Text;
				if (this.opcmessage_0 != null)
				{
					if (this.opcmessage_0.ValueType == "VT_BOOL")
					{
						if (Convert.ToBoolean(this.opcmessage_0.Value))
						{
							result = this.opcmessage_0.StateNormName;
						}
						else
						{
							result = this.opcmessage_0.StateAbnormName;
						}
					}
					if (this.opcmessage_0.ValueType == "VT_R4")
					{
						double value = (double)Convert.ToSingle(this.opcmessage_0.Value, new CultureInfo(1033));
						result = Math.Round(value, this.int_0).ToString();
					}
				}
				return result;
			}
			set
			{
				base.Text = value;
			}
		}

		public string Prefix { get; set; }

		public string Measure { get; set; }

		public string FullText
		{
			get
			{
				return string.Concat(new string[]
				{
					this.Prefix,
					" ",
					this.Text,
					" ",
					this.Measure
				});
			}
		}

		public int DecimalPlaces
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public OPCMessage OPCMessage
		{
			get
			{
				return this.opcmessage_0;
			}
			set
			{
				this.opcmessage_0 = value;
				this.Text = this.opcmessage_0.Value;
				this.Measure = this.opcmessage_0.Measure;
			}
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(eTypeLabelTool.TelemetryLabel);
		}

		protected override void UpdateXML()
		{
			base.UpdateXML();
			((XmlElement)this.currentXmlScheme).SetAttribute("X1", Math.Round(base.Location.X, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("Y1", Math.Round(base.Location.Y, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("ObjectTelemetry", this.ObjectTelemetry.ToString());
			((XmlElement)this.currentXmlScheme).SetAttribute("TelemetryParameterId", this.TelemetryParameterId.ToString());
			((XmlElement)this.currentXmlScheme).SetAttribute("Prefix", this.Prefix);
			((XmlElement)this.currentXmlScheme).SetAttribute("Measure", this.Measure);
			((XmlElement)this.currentXmlScheme).SetAttribute("DecimalPlaces", this.DecimalPlaces.ToString());
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

		protected override RectangleF GetRectangleText(CanvasControl canvas)
		{
			RectangleF empty = RectangleF.Empty;
			Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style);
			SizeF sizeF = canvas.Graphics.MeasureString(this.FullText, font);
			SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
			empty = new RectangleF(base.Location.Point, size);
			font.Dispose();
			return empty;
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if (!this.Visible)
			{
				return;
			}
			if (this.TextProperty.FontSize * canvas.Zoom <= canvas.Settings.FontSizeNoVisible)
			{
				return;
			}
			using (Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style))
			{
				bool flag = false;
				if (this.opcmessage_0 != null)
				{
					flag = (this.opcmessage_0.ValueType == "VT_BOOL");
				}
				RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetRectangleText(canvas));
				RectangleF empty = RectangleF.Empty;
				if (flag)
				{
					empty = new RectangleF(rectangleF.Location, new SizeF(rectangleF.Height, rectangleF.Height));
					rectangleF.X += rectangleF.Height;
				}
				GraphicsState gstate = canvas.Graphics.Save();
				if (this.TextProperty.FontVirtical)
				{
					Matrix transform = canvas.Graphics.Transform;
					rectangleF.Y += rectangleF.Height;
					transform.RotateAt(-90f, rectangleF.Location, MatrixOrder.Append);
					canvas.Graphics.Transform = transform;
				}
				using (Pen pen = new Pen(this.TextProperty.Color, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width)))
				{
					SolidBrush brush = null;
					if (flag)
					{
						if (Convert.ToBoolean(this.opcmessage_0.Value))
						{
							brush = new SolidBrush(Color.LimeGreen);
						}
						else
						{
							brush = new SolidBrush(Color.Red);
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
						if (this.Selected)
						{
							pen.Color = Color.Gray;
						}
						if (this.Flashing && canvas.ConvertColorFlash)
						{
							pen.Color = Color.White;
						}
					}
					if (rectangleF.Size.Width > 0f && rectangleF.Size.Height > 0f)
					{
						if (flag)
						{
							canvas.Graphics.FillRectangle(brush, empty);
							canvas.Graphics.DrawRectangle(pen, empty.X, empty.Y, empty.Width, empty.Height);
						}
						canvas.Graphics.DrawString(this.FullText, font, new SolidBrush(pen.Color), rectangleF.Location);
						canvas.Graphics.DrawRectangle(pen, rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
					}
					canvas.Graphics.Restore(gstate);
				}
			}
		}

		public override bool ShowPropertyForm(Point location)
		{
			int idBase = this.IdBase;
			if (new FormTelemetryLabelPropertiy(this.Layer.Parent.SqlSettings, this)
			{
				Location = location
			}.ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
				return true;
			}
			return false;
		}

		private OPCMessage opcmessage_0;

		private Type type_0 = typeof(string);

		private int int_0 = 2;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;
	}
}
