using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class MeasurementLabelTool : FreeLabelTool
	{
		public MeasurementLabelTool()
		{
			this.Text = string.Empty;
		}

		public MeasurementLabelTool(DataRow dataRow_0) : base(dataRow_0)
		{
			this.Text = string.Empty;
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)dataRow_0["XmlCoords"]);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/Obj");
			XmlAttribute xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("Text");
			if (xmlAttribute != null)
			{
				this.Text = xmlAttribute.Value;
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("Measure");
			if (xmlAttribute != null)
			{
				this.Measure = xmlAttribute.Value;
			}
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(eTypeLabelTool.MeasurementLabel);
		}

		protected override void UpdateXML()
		{
			base.UpdateXML();
			((XmlElement)this.currentXmlScheme).SetAttribute("X1", Math.Round(base.Location.X, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("Y1", Math.Round(base.Location.Y, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("Text", this.Text);
			((XmlElement)this.currentXmlScheme).SetAttribute("Measure", this.Measure);
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

		public override string StripText
		{
			get
			{
				return "Замеры: " + base.StripText;
			}
		}

		public override bool Visible
		{
			get
			{
				return this.Layer.Parent.MeasurementLabelVisible && base.Visible;
			}
			set
			{
				base.Visible = value;
			}
		}

		public int Value { get; set; }

		public string Measure { get; set; }

		public string FullText
		{
			get
			{
				return string.Concat(new string[]
				{
					this.Text,
					": ",
					this.Value.ToString(),
					" ",
					this.Measure
				});
			}
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
				RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetRectangleText(canvas));
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
						canvas.Graphics.DrawString(this.FullText, font, new SolidBrush(pen.Color), rectangleF.Location);
						canvas.Graphics.DrawRectangle(pen, rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
					}
					canvas.Graphics.Restore(gstate);
				}
			}
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;
	}
}
