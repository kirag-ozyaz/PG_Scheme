using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class MeasurementLabelTool : FreeLabelTool
	{
		public MeasurementLabelTool()
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.Text = string.Empty;
			this.list_2 = new List<MeasurementLabelTool.Class12>();
		}

		public MeasurementLabelTool(DataRow r)
		{
			Class90.TDroV38zslI2T();
			base..ctor(r);
			this.Text = string.Empty;
			this.list_2 = new List<MeasurementLabelTool.Class12>();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)r["XmlCoords"]);
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

		protected override void vmethod_4()
		{
			base.vmethod_4();
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
			for (int i = 0; i < this.list_2.Count; i++)
			{
				MeasurementLabelTool.Class12 @class = this.list_2[i];
				XmlElement xmlElement = this.currentXmlScheme.OwnerDocument.CreateElement("transId");
				xmlElement.SetAttribute("value", @class.int_0.ToString());
				this.currentXmlScheme.AppendChild(xmlElement);
			}
		}

		protected override RectangleF GetRectangleText(CanvasControl canvas)
		{
			Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style);
			SizeF sizeF = canvas.Graphics.MeasureString(this.FullText, font);
			SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
			RectangleF result = new RectangleF(base.Location.Point, size);
			font.Dispose();
			return result;
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

		public string Measure { get; set; }

		public string FullText
		{
			get
			{
				int num = 0;
				int num2 = this.Text.IndexOf(';');
				List<string> list = new List<string>();
				while (num2 != -1)
				{
					string item = this.Text.Substring(num, num2 - num);
					num = num2 + 1;
					num2 = this.Text.IndexOf(';', num);
					list.Add(item);
				}
				string text = string.Empty;
				for (int i = 0; i < this.list_2.Count; i++)
				{
					if (this.list_2[i].int_1 != -1)
					{
						string arg = (list.Count > i) ? list[i] : this.Text;
						text += string.Format("{0}:{1}{2};", arg, this.list_2[i].int_1, this.Measure);
					}
				}
				if (text == string.Empty)
				{
					text = this.Text;
				}
				return text;
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

		public void AddTransformer(int transId)
		{
			if (this.list_2.Count((MeasurementLabelTool.Class12 o) => o.int_0 == transId) > 0)
			{
				return;
			}
			MeasurementLabelTool.Class12 @class = new MeasurementLabelTool.Class12();
			@class.int_0 = transId;
			@class.int_1 = -1;
			this.list_2.Add(@class);
		}

		public void AddMeasurement(int transId, int value)
		{
			if (this.list_2.Count((MeasurementLabelTool.Class12 o) => o.int_0 == transId) == 0)
			{
				this.AddTransformer(transId);
			}
			foreach (MeasurementLabelTool.Class12 @class in this.list_2)
			{
				if (@class.int_0 == transId)
				{
					@class.int_1 = value;
				}
			}
		}

		public void ClearMeasurement()
		{
			this.list_2.Clear();
		}

		private List<MeasurementLabelTool.Class12> list_2;

		[CompilerGenerated]
		private string string_2;

		private class Class12
		{
			public Class12()
			{
				Class90.TDroV38zslI2T();
				base..ctor();
			}

			internal int int_0;

			internal int int_1;
		}
	}
}
