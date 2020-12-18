using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using DataSql;
using SchemeCtrl2.Data;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Layers;

namespace SchemeCtrl2.Canvas
{
	public class CanvasSettings
	{
		public XmlDocument DocUser
		{
			get
			{
				return this.xmlDocument_0;
			}
			set
			{
				this.xmlDocument_0 = value;
			}
		}

		public XmlDocument DocDefault
		{
			get
			{
				return this.xmlDocument_1;
			}
			set
			{
				this.xmlDocument_1 = value;
			}
		}

		public bool UseDefaultSettings
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		public SmoothingMode QualityImage
		{
			get
			{
				return this.smoothingMode_0;
			}
			set
			{
				this.smoothingMode_0 = value;
			}
		}

		public Color BackgroundColor
		{
			get
			{
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
			}
		}

		public Color GridColor
		{
			get
			{
				return this.color_1;
			}
			set
			{
				this.color_1 = value;
			}
		}

		public GridLayer.eGridStyle GridStyle
		{
			get
			{
				return this.eGridStyle_0;
			}
			set
			{
				this.eGridStyle_0 = value;
			}
		}

		public bool GridVisible
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		public Color SelectedObjColor
		{
			get
			{
				return this.color_2;
			}
			set
			{
				this.color_2 = value;
			}
		}

		public Color BackFlashingColor
		{
			get
			{
				return this.color_3;
			}
			set
			{
				this.color_3 = value;
			}
		}

		public Color MarkedObjColor
		{
			get
			{
				return this.color_4;
			}
			set
			{
				this.color_4 = value;
			}
		}

		public Color RectangleTPColor
		{
			get
			{
				return this.color_5;
			}
			set
			{
				this.color_5 = value;
			}
		}

		public Color RectangleCPColor
		{
			get
			{
				return this.color_6;
			}
			set
			{
				this.color_6 = value;
			}
		}

		public Color RectangleRPColor
		{
			get
			{
				return this.color_7;
			}
			set
			{
				this.color_7 = value;
			}
		}

		public Color RectanglePPColor
		{
			get
			{
				return this.color_8;
			}
			set
			{
				this.color_8 = value;
			}
		}

		public Color RectangleSPColor
		{
			get
			{
				return this.color_9;
			}
			set
			{
				this.color_9 = value;
			}
		}

		public Color RectanglePPNOColor
		{
			get
			{
				return this.color_10;
			}
			set
			{
				this.color_10 = value;
			}
		}

		public Color Shina10Color
		{
			get
			{
				return this.color_11;
			}
			set
			{
				this.color_11 = value;
			}
		}

		public Color Shina10ColorOff
		{
			get
			{
				return this.color_12;
			}
			set
			{
				this.color_12 = value;
			}
		}

		public Color Shina6Color
		{
			get
			{
				return this.color_13;
			}
			set
			{
				this.color_13 = value;
			}
		}

		public Color Shina6ColorOff
		{
			get
			{
				return this.color_14;
			}
			set
			{
				this.color_14 = value;
			}
		}

		public Color Shina04Color
		{
			get
			{
				return this.color_15;
			}
			set
			{
				this.color_15 = value;
			}
		}

		public Color Shina04ColorOff
		{
			get
			{
				return this.color_16;
			}
			set
			{
				this.color_16 = value;
			}
		}

		public Color Shina023Color
		{
			get
			{
				return this.color_17;
			}
			set
			{
				this.color_17 = value;
			}
		}

		public Color Shina023ColorOff
		{
			get
			{
				return this.color_18;
			}
			set
			{
				this.color_18 = value;
			}
		}

		public Color Cell10Color
		{
			get
			{
				return this.color_19;
			}
			set
			{
				this.color_19 = value;
			}
		}

		public Color Cell10ColorOff
		{
			get
			{
				return this.color_20;
			}
			set
			{
				this.color_20 = value;
			}
		}

		public Color Cell6Color
		{
			get
			{
				return this.color_21;
			}
			set
			{
				this.color_21 = value;
			}
		}

		public Color Cell6ColorOff
		{
			get
			{
				return this.color_22;
			}
			set
			{
				this.color_22 = value;
			}
		}

		public Color Cell04Color
		{
			get
			{
				return this.color_23;
			}
			set
			{
				this.color_23 = value;
			}
		}

		public Color Cell04ColorOff
		{
			get
			{
				return this.color_24;
			}
			set
			{
				this.color_24 = value;
			}
		}

		public Color Cell023Color
		{
			get
			{
				return this.color_25;
			}
			set
			{
				this.color_25 = value;
			}
		}

		public Color Cell023ColorOff
		{
			get
			{
				return this.color_26;
			}
			set
			{
				this.color_26 = value;
			}
		}

		public Color Line10Color
		{
			get
			{
				return this.color_27;
			}
			set
			{
				this.color_27 = value;
			}
		}

		public Color Line10ColorOff
		{
			get
			{
				return this.color_28;
			}
			set
			{
				this.color_28 = value;
			}
		}

		public Color Line6Color
		{
			get
			{
				return this.color_29;
			}
			set
			{
				this.color_29 = value;
			}
		}

		public Color Line6ColorOff
		{
			get
			{
				return this.color_30;
			}
			set
			{
				this.color_30 = value;
			}
		}

		public Color Line04Color
		{
			get
			{
				return this.color_31;
			}
			set
			{
				this.color_31 = value;
			}
		}

		public Color Line04ColorOff
		{
			get
			{
				return this.color_32;
			}
			set
			{
				this.color_32 = value;
			}
		}

		public Color Line023Color
		{
			get
			{
				return this.color_33;
			}
			set
			{
				this.color_33 = value;
			}
		}

		public Color Line023ColorOff
		{
			get
			{
				return this.color_34;
			}
			set
			{
				this.color_34 = value;
			}
		}

		public float ObjectOnLineZoomSimply
		{
			get
			{
				return this.float_0;
			}
			set
			{
				this.float_0 = value;
			}
		}

		public Color LubricantSwitchToolColor
		{
			get
			{
				return this.color_35;
			}
			set
			{
				this.color_35 = value;
			}
		}

		public Color LinearDisconnectorToolColor
		{
			get
			{
				return this.color_36;
			}
			set
			{
				this.color_36 = value;
			}
		}

		public Color LoadSwitchToolColor
		{
			get
			{
				return this.color_37;
			}
			set
			{
				this.color_37 = value;
			}
		}

		public Color VacuumSwitchToolColor
		{
			get
			{
				return this.color_40;
			}
			set
			{
				this.color_40 = value;
			}
		}

		public Color OutsideLineDisconnectorToolColor
		{
			get
			{
				return this.color_41;
			}
			set
			{
				this.color_41 = value;
			}
		}

		public Color EndTrimToolColor
		{
			get
			{
				return this.color_42;
			}
			set
			{
				this.color_42 = value;
			}
		}

		public Color GroundingToolColor
		{
			get
			{
				return this.color_44;
			}
			set
			{
				this.color_44 = value;
			}
		}

		public bool GroundingToolColorLine
		{
			get
			{
				return this.bool_3;
			}
			set
			{
				this.bool_3 = value;
			}
		}

		public Color DamageToolColor
		{
			get
			{
				return this.color_39;
			}
			set
			{
				this.color_39 = value;
			}
		}

		public bool DamageToolColorLine
		{
			get
			{
				return this.bool_4;
			}
			set
			{
				this.bool_4 = value;
			}
		}

		public Color OffToolColor
		{
			get
			{
				return this.color_45;
			}
			set
			{
				this.color_45 = value;
			}
		}

		public bool OffToolColorLine
		{
			get
			{
				return this.bool_5;
			}
			set
			{
				this.bool_5 = value;
			}
		}

		public Color NoPhasedToolColor
		{
			get
			{
				return this.color_46;
			}
			set
			{
				this.color_46 = value;
			}
		}

		public bool NoPhasedToolColorLine
		{
			get
			{
				return this.bool_6;
			}
			set
			{
				this.bool_6 = value;
			}
		}

		public Color ArrowToolColor
		{
			get
			{
				return this.color_43;
			}
			set
			{
				this.color_43 = value;
			}
		}

		public Color ObjectOnLineColorOff
		{
			get
			{
				return this.color_47;
			}
			set
			{
				this.color_47 = value;
			}
		}

		public Color ObjectOnLineColorOffN
		{
			get
			{
				return this.color_48;
			}
			set
			{
				this.color_48 = value;
			}
		}

		public Color ObjectOnLineDamageStateColor
		{
			get
			{
				return this.color_49;
			}
			set
			{
				this.color_49 = value;
			}
		}

		public Color ObjectOnLineKeyStateColor
		{
			get
			{
				return this.color_50;
			}
			set
			{
				this.color_50 = value;
			}
		}

		public bool ObjectOnLineColorLine
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				this.bool_2 = value;
			}
		}

		public Color TextBranchColor
		{
			get
			{
				return this.color_51;
			}
			set
			{
				this.color_51 = value;
			}
		}

		public Color TransformerToolColor
		{
			get
			{
				return this.color_38;
			}
			set
			{
				this.color_38 = value;
			}
		}

		public List<PropertyFromBaseElement> TransformerPassportProperty
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
			}
		}

		public List<PropertyFromBaseElement> LinePassportProperty
		{
			get
			{
				return this.list_1;
			}
			set
			{
				this.list_1 = value;
			}
		}

		public bool VisibleCableMakeup { get; set; }

		public bool VisibleCableVoltage { get; set; }

		public bool VisibleCableWires { get; set; }

		public bool VisibleCableCrossSection { get; set; }

		public bool VisibleCableLength { get; set; }

		public float FontSizeNoVisible
		{
			get
			{
				return this.float_1;
			}
			set
			{
				this.float_1 = value;
			}
		}

		public TextFont TextPropertyCP
		{
			get
			{
				return this.textFont_0;
			}
			set
			{
				this.textFont_0 = value;
			}
		}

		public TextFont TextPropertyTP
		{
			get
			{
				return this.textFont_1;
			}
			set
			{
				this.textFont_1 = value;
			}
		}

		public TextFont TextPropertyRP
		{
			get
			{
				return this.textFont_2;
			}
			set
			{
				this.textFont_2 = value;
			}
		}

		public TextFont TextPropertyPP
		{
			get
			{
				return this.textFont_3;
			}
			set
			{
				this.textFont_3 = value;
			}
		}

		public TextFont TextPropertySP
		{
			get
			{
				return this.textFont_4;
			}
			set
			{
				this.textFont_4 = value;
			}
		}

		public TextFont TextPropertyPPNO
		{
			get
			{
				return this.textFont_5;
			}
			set
			{
				this.textFont_5 = value;
			}
		}

		public TextFont TextPropertyShina10
		{
			get
			{
				return this.textFont_6;
			}
			set
			{
				this.textFont_6 = value;
			}
		}

		public TextFont TextPropertyShina6
		{
			get
			{
				return this.textFont_7;
			}
			set
			{
				this.textFont_7 = value;
			}
		}

		public TextFont TextPropertyShina04
		{
			get
			{
				return this.textFont_8;
			}
			set
			{
				this.textFont_8 = value;
			}
		}

		public TextFont TextPropertyShina023
		{
			get
			{
				return this.textFont_9;
			}
			set
			{
				this.textFont_9 = value;
			}
		}

		public TextFont TextPropertyCell10
		{
			get
			{
				return this.textFont_10;
			}
			set
			{
				this.textFont_10 = value;
			}
		}

		public TextFont TextPropertyCell6
		{
			get
			{
				return this.textFont_11;
			}
			set
			{
				this.textFont_11 = value;
			}
		}

		public TextFont TextPropertyCell04
		{
			get
			{
				return this.textFont_12;
			}
			set
			{
				this.textFont_12 = value;
			}
		}

		public TextFont TextPropertyCell023
		{
			get
			{
				return this.textFont_13;
			}
			set
			{
				this.textFont_13 = value;
			}
		}

		public TextFont TextPropertyObjectInLine
		{
			get
			{
				return this.textFont_15;
			}
			set
			{
				this.textFont_15 = value;
			}
		}

		public TextFont TextPropertyNormalSection
		{
			get
			{
				return this.textFont_16;
			}
			set
			{
				this.textFont_16 = value;
			}
		}

		public TextFont TextPropertyTextBranch
		{
			get
			{
				return this.textFont_14;
			}
			set
			{
				this.textFont_14 = value;
			}
		}

		public TextFont TextPropertyAutomaticEntryProvision
		{
			get
			{
				return this.textFont_17;
			}
			set
			{
				this.textFont_17 = value;
			}
		}

		public TextFont TextPropertySpecialLocking
		{
			get
			{
				return this.textFont_18;
			}
			set
			{
				this.textFont_18 = value;
			}
		}

		public TextFont TextPropertyTelemechanics
		{
			get
			{
				return this.textFont_19;
			}
			set
			{
				this.textFont_19 = value;
			}
		}

		public TextFont TextPropertyTelemechanicsProtection
		{
			get
			{
				return this.textFont_20;
			}
			set
			{
				this.textFont_20 = value;
			}
		}

		public TextFont TextPropertyResponsibleAbonentTool
		{
			get
			{
				return this.textFont_21;
			}
			set
			{
				this.textFont_21 = value;
			}
		}

		public bool VisibleAutomaticEntryProvisionTool
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

		public bool VisibleSpecialLockingTool
		{
			get
			{
				return this.bool_8;
			}
			set
			{
				this.bool_8 = value;
			}
		}

		public bool VisibleTelemechanicsTool
		{
			get
			{
				return this.bool_9;
			}
			set
			{
				this.bool_9 = value;
			}
		}

		public bool VisibleTelemechanicsProtectionTool
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

		public bool VisibleResponsibleAbonentTool
		{
			get
			{
				return this.bool_11;
			}
			set
			{
				this.bool_11 = value;
			}
		}

		public Color NodeToolColor
		{
			get
			{
				return this.color_52;
			}
			set
			{
				this.color_52 = value;
			}
		}

		public int MeasurementYear { get; set; }

		public CanvasSettings Clone()
		{
			PropertyInfo[] properties = typeof(CanvasSettings).GetProperties();
			CanvasSettings canvasSettings = new CanvasSettings();
			foreach (PropertyInfo propertyInfo in properties)
			{
				object value = propertyInfo.GetValue(this, null);
				propertyInfo.SetValue(canvasSettings, value, null);
			}
			return canvasSettings;
		}

		public void ZoomInFontSize()
		{
			this.textFont_0.FontSize += 0.5f;
			this.textFont_1.FontSize += 0.5f;
			this.textFont_3.FontSize += 0.5f;
			this.textFont_2.FontSize += 0.5f;
			this.textFont_6.FontSize += 0.5f;
			this.textFont_7.FontSize += 0.5f;
			this.textFont_8.FontSize += 0.5f;
			this.textFont_9.FontSize += 0.5f;
			this.textFont_10.FontSize += 0.5f;
			this.textFont_11.FontSize += 0.5f;
			this.textFont_12.FontSize += 0.5f;
			this.textFont_13.FontSize += 0.5f;
			this.textFont_14.FontSize += 0.5f;
			this.textFont_15.FontSize += 0.5f;
			this.textFont_16.FontSize += 0.5f;
		}

		public void ZoomOutFontSize()
		{
			if (this.textFont_0.FontSize >= 1f)
			{
				this.textFont_0.FontSize -= 0.5f;
			}
			if (this.textFont_1.FontSize >= 1f)
			{
				this.textFont_1.FontSize -= 0.5f;
			}
			if (this.textFont_3.FontSize >= 1f)
			{
				this.textFont_3.FontSize -= 0.5f;
			}
			if (this.textFont_2.FontSize >= 1f)
			{
				this.textFont_2.FontSize -= 0.5f;
			}
			if (this.textFont_6.FontSize >= 1f)
			{
				this.textFont_6.FontSize -= 0.5f;
			}
			if (this.textFont_7.FontSize >= 1f)
			{
				this.textFont_7.FontSize -= 0.5f;
			}
			if (this.textFont_8.FontSize >= 1f)
			{
				this.textFont_8.FontSize -= 0.5f;
			}
			if (this.textFont_9.FontSize >= 1f)
			{
				this.textFont_9.FontSize -= 0.5f;
			}
			if (this.textFont_10.FontSize >= 1f)
			{
				this.textFont_10.FontSize -= 0.5f;
			}
			if (this.textFont_11.FontSize >= 1f)
			{
				this.textFont_11.FontSize -= 0.5f;
			}
			if (this.textFont_12.FontSize >= 1f)
			{
				this.textFont_12.FontSize -= 0.5f;
			}
			if (this.textFont_13.FontSize >= 1f)
			{
				this.textFont_13.FontSize -= 0.5f;
			}
			if (this.textFont_14.FontSize >= 1f)
			{
				this.textFont_14.FontSize -= 0.5f;
			}
			if (this.textFont_15.FontSize >= 1f)
			{
				this.textFont_15.FontSize -= 0.5f;
			}
			if (this.textFont_16.FontSize >= 1f)
			{
				this.textFont_16.FontSize += 0.5f;
			}
		}

		public XmlDocument SaveToXmlDocument()
		{
			PropertyInfo[] properties = typeof(CanvasSettings).GetProperties();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml("<canvasSettings></canvasSettings>");
			XmlNode xmlNode = xmlDocument.SelectSingleNode("canvasSettings");
			XmlElement xmlElement = xmlDocument.CreateElement("Canvas");
			xmlElement.SetAttribute("UseDefaultSetting", this.UseDefaultSettings.ToString());
			xmlElement.SetAttribute("QualityImage", this.QualityImage.ToString());
			xmlNode.AppendChild(xmlElement);
			XmlElement xmlElement2 = xmlDocument.CreateElement("CanvasZoomSettings");
			xmlElement2.SetAttribute("ObjectOnLineZoomSimply", this.float_0.ToString(new CultureInfo(1033)));
			xmlNode.AppendChild(xmlElement2);
			XmlElement xmlElement3 = xmlDocument.CreateElement("UseColor");
			xmlElement3.SetAttribute("ObjectOnLineColorLine", this.ObjectOnLineColorLine.ToString());
			xmlElement3.SetAttribute("GroundingToolColorLine", this.GroundingToolColorLine.ToString());
			xmlElement3.SetAttribute("DamageToolColorLine", this.DamageToolColorLine.ToString());
			xmlElement3.SetAttribute("NoPhasedToolColorLine", this.NoPhasedToolColorLine.ToString());
			xmlElement3.SetAttribute("OffToolColorLine", this.OffToolColorLine.ToString());
			xmlNode.AppendChild(xmlElement3);
			XmlElement xmlElement4 = xmlDocument.CreateElement("ColorSettings");
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (propertyInfo.PropertyType == typeof(Color))
				{
					Color color = (Color)propertyInfo.GetValue(this, null);
					xmlElement4.SetAttribute(propertyInfo.Name, color.ToArgb().ToString());
				}
			}
			xmlNode.AppendChild(xmlElement4);
			XmlElement xmlElement5 = xmlDocument.CreateElement("TextProperties");
			xmlElement5.SetAttribute("FontSizeNoVisible", this.FontSizeNoVisible.ToString(new CultureInfo(1033)));
			foreach (PropertyInfo propertyInfo2 in properties)
			{
				if (propertyInfo2.PropertyType == typeof(TextFont))
				{
					TextFont textFont = (TextFont)propertyInfo2.GetValue(this, null);
					XmlElement xmlElement6 = xmlDocument.CreateElement(propertyInfo2.Name);
					xmlElement6.SetAttribute("FontName", textFont.FontName);
					xmlElement6.SetAttribute("FontSize", textFont.FontSize.ToString(new CultureInfo(1033)));
					xmlElement6.SetAttribute("FontBold", textFont.FontBold.ToString());
					xmlElement6.SetAttribute("FontItalic", textFont.FontItalic.ToString());
					xmlElement6.SetAttribute("FontUnderline", textFont.FontUnderline.ToString());
					xmlElement6.SetAttribute("Color", textFont.Color.ToArgb().ToString());
					xmlElement5.AppendChild(xmlElement6);
				}
			}
			xmlNode.AppendChild(xmlElement5);
			XmlElement xmlElement7 = xmlDocument.CreateElement("VisibleLabelTool");
			xmlElement7.SetAttribute("VisibleAutomaticEntryProvisionTool", this.VisibleAutomaticEntryProvisionTool.ToString());
			xmlElement7.SetAttribute("VisibleSpecialLockingTool", this.VisibleSpecialLockingTool.ToString());
			xmlElement7.SetAttribute("VisibleTelemechanicsTool", this.VisibleTelemechanicsTool.ToString());
			xmlElement7.SetAttribute("VisibleTelemechanicsProtectionTool", this.VisibleTelemechanicsProtectionTool.ToString());
			xmlElement7.SetAttribute("VisibleResponsibleAbonentTool.", this.VisibleResponsibleAbonentTool.ToString());
			xmlNode.AppendChild(xmlElement7);
			xmlElement7 = xmlDocument.CreateElement("LabelTool");
			xmlElement7.SetAttribute("MeasurementYear", this.MeasurementYear.ToString());
			xmlNode.AppendChild(xmlElement7);
			XmlElement xmlElement8 = xmlDocument.CreateElement("VisibleTextCableTool");
			xmlElement8.SetAttribute("VisibleCableMakeup", this.VisibleCableMakeup.ToString());
			xmlElement8.SetAttribute("VisibleCableVoltage", this.VisibleCableVoltage.ToString());
			xmlElement8.SetAttribute("VisibleCableWires", this.VisibleCableWires.ToString());
			xmlElement8.SetAttribute("VisibleCableCrossSection", this.VisibleCableCrossSection.ToString());
			xmlElement8.SetAttribute("VisibleCableLength", this.VisibleCableLength.ToString());
			foreach (PropertyFromBaseElement propertyFromBaseElement in this.list_1)
			{
				bool flag;
				if (flag = Convert.ToBoolean(propertyFromBaseElement.Value))
				{
					xmlElement8.SetAttribute("i" + propertyFromBaseElement.ID.ToString(), flag.ToString());
				}
			}
			xmlNode.AppendChild(xmlElement8);
			XmlElement xmlElement9 = xmlDocument.CreateElement("VisibleTextTransTool");
			foreach (PropertyFromBaseElement propertyFromBaseElement2 in this.list_0)
			{
				bool flag2;
				if (flag2 = Convert.ToBoolean(propertyFromBaseElement2.Value))
				{
					xmlElement9.SetAttribute("i" + propertyFromBaseElement2.ID.ToString(), flag2.ToString());
				}
			}
			xmlNode.AppendChild(xmlElement9);
			return xmlDocument;
		}

		public void SaveToBase(SQLSettings sqlSetting, eTypeCanvas typeCanvas)
		{
			XmlDocument xmlDocument = this.SaveToXmlDocument();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlSetting);
			DataSetScheme dataSetScheme = new DataSetScheme();
			string hostName = Dns.GetHostName();
			IPAddress ipaddress = Dns.GetHostByName(hostName).AddressList[0];
			if (this.UseDefaultSettings)
			{
				this.DocDefault = xmlDocument;
			}
			else
			{
				this.DocUser = xmlDocument;
			}
			if (typeCanvas == eTypeCanvas.SchemeSecond)
			{
				sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Settings, true, "where [HostIP]='" + ipaddress.ToString() + "_2'");
			}
			else
			{
				sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Settings, true, "where [HostIP]='" + ipaddress.ToString() + "'");
			}
			if (dataSetScheme.tSchm_Settings.Rows.Count == 0)
			{
				DataRow dataRow = dataSetScheme.tSchm_Settings.NewRow();
				dataRow["HostIP"] = ((typeCanvas == eTypeCanvas.SchemeSecond) ? (ipaddress.ToString() + "_2") : ipaddress.ToString());
				dataRow["Settings"] = this.DocUser.InnerXml;
				dataSetScheme.tSchm_Settings.Rows.Add(dataRow);
				sqlDataCommand.InsertSqlDataOneRow(dataSetScheme, dataSetScheme.tSchm_Settings);
			}
			else
			{
				dataSetScheme.tSchm_Settings.Rows[0]["Settings"] = this.DocUser.InnerXml;
				dataSetScheme.tSchm_Settings.Rows[0].EndEdit();
				sqlDataCommand.UpdateSqlData(dataSetScheme, dataSetScheme.tSchm_Settings);
			}
			dataSetScheme = new DataSetScheme();
			if (typeCanvas == eTypeCanvas.SchemeSecond)
			{
				sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Settings, true, "where [HostIP]='Default_2'");
			}
			else
			{
				sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Settings, true, "where [HostIP]='Default'");
			}
			if (dataSetScheme.tSchm_Settings.Rows.Count == 0)
			{
				DataRow dataRow2 = dataSetScheme.tSchm_Settings.NewRow();
				dataRow2["HostIP"] = ((typeCanvas == eTypeCanvas.SchemeSecond) ? "Default_2" : "Default");
				dataRow2["Settings"] = this.DocDefault.InnerXml;
				dataSetScheme.tSchm_Settings.Rows.Add(dataRow2);
				sqlDataCommand.InsertSqlDataOneRow(dataSetScheme, dataSetScheme.tSchm_Settings);
				return;
			}
			dataSetScheme.tSchm_Settings.Rows[0]["Settings"] = this.DocDefault.InnerXml;
			dataSetScheme.tSchm_Settings.Rows[0].EndEdit();
			sqlDataCommand.UpdateSqlData(dataSetScheme, dataSetScheme.tSchm_Settings);
		}

		public void LoadTransPropertyList(SQLSettings sqlSetting)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlSetting);
			DataSetScheme dataSetScheme = new DataSetScheme();
			sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tP_CharList, true, "where ParentKey like ';EquipChar;Passp;Trans;%' and IsGroup = 0 and Deleted=0");
			bool flag = this.TransformerPassportProperty.Count > 0;
			foreach (DataSetScheme.Class65 @class in dataSetScheme.tP_CharList)
			{
				int num = Convert.ToInt32(@class["id"]);
				bool flag2 = false;
				if (flag)
				{
					foreach (PropertyFromBaseElement propertyFromBaseElement in this.TransformerPassportProperty)
					{
						if (propertyFromBaseElement.ID == num)
						{
							propertyFromBaseElement.Name = @class["Name"].ToString();
							flag2 = true;
							break;
						}
					}
				}
				if (!flag2)
				{
					PropertyFromBaseElement propertyFromBaseElement2 = new PropertyFromBaseElement();
					propertyFromBaseElement2.ID = num;
					propertyFromBaseElement2.Name = @class["Name"].ToString();
					propertyFromBaseElement2.Value = false;
					this.TransformerPassportProperty.Add(propertyFromBaseElement2);
				}
			}
		}

		public void LoadLinePropertyList(SQLSettings sqlSetting)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlSetting);
			DataSetScheme dataSetScheme = new DataSetScheme();
			sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tP_CharList, true, "where ParentKey like ';EquipChar;Passp;Line%' and IsGroup = 0 and Deleted=0");
			bool flag = this.LinePassportProperty.Count > 0;
			foreach (DataSetScheme.Class65 @class in dataSetScheme.tP_CharList)
			{
				int num = Convert.ToInt32(@class["id"]);
				bool flag2 = false;
				if (flag)
				{
					foreach (PropertyFromBaseElement propertyFromBaseElement in this.LinePassportProperty)
					{
						if (propertyFromBaseElement.ID == num)
						{
							propertyFromBaseElement.Name = @class["Name"].ToString();
							flag2 = true;
							break;
						}
					}
				}
				if (!flag2)
				{
					PropertyFromBaseElement propertyFromBaseElement2 = new PropertyFromBaseElement();
					propertyFromBaseElement2.ID = num;
					propertyFromBaseElement2.Name = @class["Name"].ToString();
					propertyFromBaseElement2.Value = false;
					this.LinePassportProperty.Add(propertyFromBaseElement2);
				}
			}
		}

		public void LoadSchemeFromBase(SQLSettings sqlSetting, eTypeCanvas typeCanvas)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlSetting);
			DataSetScheme dataSetScheme = new DataSetScheme();
			this.LoadTransPropertyList(sqlSetting);
			this.LoadLinePropertyList(sqlSetting);
			string hostName = Dns.GetHostName();
			IPAddress ipaddress = Dns.GetHostByName(hostName).AddressList[0];
			string text = (typeCanvas == eTypeCanvas.SchemeSecond) ? (ipaddress.ToString() + "_2") : ipaddress.ToString();
			string text2 = (typeCanvas == eTypeCanvas.SchemeSecond) ? "Default_2" : "Default";
			sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Settings, true, string.Concat(new string[]
			{
				"where [HostIP]='",
				text,
				"' or [HostIP] = '",
				text2,
				"'"
			}));
			DataRow[] array = dataSetScheme.tSchm_Settings.Select("HostIP = '" + text + "'");
			DataRow[] array2 = dataSetScheme.tSchm_Settings.Select("HostIP = '" + text2 + "'");
			if (array.Length > 0)
			{
				try
				{
					this.xmlDocument_0.LoadXml((string)array[0]["Settings"]);
				}
				catch
				{
					this.xmlDocument_0 = this.SaveToXmlDocument();
				}
				if (array2.Length > 0)
				{
					try
					{
						this.xmlDocument_1.LoadXml((string)array2[0]["Settings"]);
						goto IL_1FD;
					}
					catch
					{
						this.xmlDocument_1 = this.SaveToXmlDocument();
						goto IL_1FD;
					}
				}
				try
				{
					this.xmlDocument_1.LoadXml((string)array[0]["Settings"]);
					goto IL_1FD;
				}
				catch
				{
					this.xmlDocument_1 = this.SaveToXmlDocument();
					goto IL_1FD;
				}
			}
			if (array2.Length > 0)
			{
				try
				{
					this.xmlDocument_0.LoadXml((string)array2[0]["Settings"]);
					this.xmlDocument_1.LoadXml((string)array2[0]["Settings"]);
					goto IL_1FD;
				}
				catch
				{
					this.xmlDocument_0 = (this.xmlDocument_1 = this.SaveToXmlDocument());
					goto IL_1FD;
				}
			}
			this.xmlDocument_1 = (this.xmlDocument_0 = this.SaveToXmlDocument());
			IL_1FD:
			XmlNode xmlNode = this.xmlDocument_0.SelectSingleNode("canvasSettings");
			try
			{
				XmlNode xmlNode2 = xmlNode.SelectSingleNode("Canvas");
				if (xmlNode2 != null && xmlNode2.Attributes["UseDefaultSetting"] != null)
				{
					this.UseDefaultSettings = Convert.ToBoolean(xmlNode2.Attributes["UseDefaultSetting"].Value);
				}
			}
			catch
			{
			}
			if (this.UseDefaultSettings)
			{
				this.LoadSchemeFromXML(this.xmlDocument_1);
				return;
			}
			this.LoadSchemeFromXML(this.xmlDocument_0);
		}

		public void LoadSchemeFromXML(XmlDocument docUser)
		{
			PropertyInfo[] properties = typeof(CanvasSettings).GetProperties();
			XmlNode xmlNode = docUser.SelectSingleNode("canvasSettings");
			XmlNode xmlNode2 = xmlNode.SelectSingleNode("Canvas");
			if (xmlNode2 != null && xmlNode2.Attributes["QualityImage"] != null)
			{
				this.QualityImage = (SmoothingMode)Enum.Parse(typeof(SmoothingMode), xmlNode2.Attributes["QualityImage"].Value);
			}
			XmlNode xmlNode3 = xmlNode.SelectSingleNode("CanvasZoomSettings");
			if (xmlNode3 != null && xmlNode3.Attributes["ObjectOnLineZoomSimply"] != null)
			{
				this.ObjectOnLineZoomSimply = Convert.ToSingle(xmlNode3.Attributes["ObjectOnLineZoomSimply"].Value, new CultureInfo(1033));
			}
			XmlNode xmlNode4 = xmlNode.SelectSingleNode("UseColor");
			if (xmlNode4 != null)
			{
				if (xmlNode4.Attributes["ObjectOnLineColorLine"] != null)
				{
					this.ObjectOnLineColorLine = Convert.ToBoolean(xmlNode4.Attributes["ObjectOnLineColorLine"].Value);
				}
				if (xmlNode4.Attributes["GroundingToolColorLine"] != null)
				{
					this.GroundingToolColorLine = Convert.ToBoolean(xmlNode4.Attributes["GroundingToolColorLine"].Value);
				}
				if (xmlNode4.Attributes["DamageToolColorLine"] != null)
				{
					this.DamageToolColorLine = Convert.ToBoolean(xmlNode4.Attributes["DamageToolColorLine"].Value);
				}
				if (xmlNode4.Attributes["NoPhasedToolColorLine"] != null)
				{
					this.NoPhasedToolColorLine = Convert.ToBoolean(xmlNode4.Attributes["NoPhasedToolColorLine"].Value);
				}
				if (xmlNode4.Attributes["OffToolColorLine"] != null)
				{
					this.OffToolColorLine = Convert.ToBoolean(xmlNode4.Attributes["OffToolColorLine"].Value);
				}
			}
			XmlNode xmlNode5 = xmlNode.SelectSingleNode("ColorSettings");
			if (xmlNode5 != null)
			{
				foreach (PropertyInfo propertyInfo in properties)
				{
					if (propertyInfo.PropertyType == typeof(Color))
					{
						Color color = (Color)propertyInfo.GetValue(this, null);
						if (xmlNode5.Attributes[propertyInfo.Name] != null)
						{
							color = Color.FromArgb(Convert.ToInt32(xmlNode5.Attributes[propertyInfo.Name].Value));
						}
						propertyInfo.SetValue(this, color, null);
					}
				}
			}
			XmlNode xmlNode6 = xmlNode.SelectSingleNode("TextProperties");
			if (xmlNode6 != null)
			{
				if (xmlNode6.Attributes["FontSizeNoVisible"] != null)
				{
					this.FontSizeNoVisible = Convert.ToSingle(xmlNode6.Attributes["FontSizeNoVisible"].Value, new CultureInfo(1033));
				}
				foreach (PropertyInfo propertyInfo2 in properties)
				{
					if (propertyInfo2.PropertyType == typeof(TextFont))
					{
						TextFont textFont = (TextFont)propertyInfo2.GetValue(this, null);
						XmlNode xmlNode7 = xmlNode6.SelectSingleNode(propertyInfo2.Name);
						if (xmlNode7 != null)
						{
							if (xmlNode7.Attributes["FontName"] != null)
							{
								textFont.FontName = xmlNode7.Attributes["FontName"].Value;
							}
							if (xmlNode7.Attributes["FontSize"] != null)
							{
								textFont.FontSize = Convert.ToSingle(xmlNode7.Attributes["FontSize"].Value, new CultureInfo(1033));
							}
							if (xmlNode7.Attributes["FontBold"] != null)
							{
								textFont.FontBold = Convert.ToBoolean(xmlNode7.Attributes["FontBold"].Value);
							}
							if (xmlNode7.Attributes["FontItalic"] != null)
							{
								textFont.FontItalic = Convert.ToBoolean(xmlNode7.Attributes["FontItalic"].Value);
							}
							if (xmlNode7.Attributes["FontUnderline"] != null)
							{
								textFont.FontUnderline = Convert.ToBoolean(xmlNode7.Attributes["FontUnderline"].Value);
							}
							if (xmlNode7.Attributes["Color"] != null)
							{
								textFont.Color = Color.FromArgb(Convert.ToInt32(xmlNode7.Attributes["Color"].Value));
							}
							propertyInfo2.SetValue(this, textFont, null);
						}
					}
				}
			}
			XmlNode xmlNode8 = xmlNode.SelectSingleNode("VisibleLabelTool");
			if (xmlNode8 != null)
			{
				if (xmlNode8.Attributes["VisibleAutomaticEntryProvisionTool"] != null)
				{
					this.VisibleAutomaticEntryProvisionTool = Convert.ToBoolean(xmlNode8.Attributes["VisibleAutomaticEntryProvisionTool"].Value);
				}
				if (xmlNode8.Attributes["VisibleSpecialLockingTool"] != null)
				{
					this.VisibleSpecialLockingTool = Convert.ToBoolean(xmlNode8.Attributes["VisibleSpecialLockingTool"].Value);
				}
				if (xmlNode8.Attributes["VisibleTelemechanicsTool"] != null)
				{
					this.VisibleTelemechanicsTool = Convert.ToBoolean(xmlNode8.Attributes["VisibleTelemechanicsTool"].Value);
				}
				if (xmlNode8.Attributes["VisibleTelemechanicsProtectionTool"] != null)
				{
					this.VisibleTelemechanicsProtectionTool = Convert.ToBoolean(xmlNode8.Attributes["VisibleTelemechanicsProtectionTool"].Value);
				}
				if (xmlNode8.Attributes["VisibleResponsibleAbonentTool"] != null)
				{
					this.VisibleResponsibleAbonentTool = Convert.ToBoolean(xmlNode8.Attributes["VisibleResponsibleAbonentTool"].Value);
				}
			}
			xmlNode8 = xmlNode.SelectSingleNode("LabelTool");
			if (xmlNode8 != null && xmlNode8.Attributes["MeasurementYear"] != null)
			{
				this.MeasurementYear = Convert.ToInt32(xmlNode8.Attributes["MeasurementYear"].Value);
			}
			XmlNode xmlNode9 = xmlNode.SelectSingleNode("VisibleTextCableTool");
			if (xmlNode9 != null)
			{
				if (xmlNode9.Attributes["VisibleCableCrossSection"] != null)
				{
					this.VisibleCableCrossSection = Convert.ToBoolean(xmlNode9.Attributes["VisibleCableCrossSection"].Value);
				}
				if (xmlNode9.Attributes["VisibleCableLength"] != null)
				{
					this.VisibleCableLength = Convert.ToBoolean(xmlNode9.Attributes["VisibleCableLength"].Value);
				}
				if (xmlNode9.Attributes["VisibleCableMakeup"] != null)
				{
					this.VisibleCableMakeup = Convert.ToBoolean(xmlNode9.Attributes["VisibleCableMakeup"].Value);
				}
				if (xmlNode9.Attributes["VisibleCableVoltage"] != null)
				{
					this.VisibleCableVoltage = Convert.ToBoolean(xmlNode9.Attributes["VisibleCableVoltage"].Value);
				}
				if (xmlNode9.Attributes["VisibleCableWires"] != null)
				{
					this.VisibleCableWires = Convert.ToBoolean(xmlNode9.Attributes["VisibleCableWires"].Value);
				}
				foreach (object obj in xmlNode9.Attributes)
				{
					XmlAttribute xmlAttribute = (XmlAttribute)obj;
					int num = -1;
					try
					{
						string value = xmlAttribute.Name.Substring(1, xmlAttribute.Name.Length - 1);
						num = Convert.ToInt32(value);
					}
					catch
					{
					}
					if (num != -1)
					{
						foreach (PropertyFromBaseElement propertyFromBaseElement in this.LinePassportProperty)
						{
							if (propertyFromBaseElement.ID == num)
							{
								propertyFromBaseElement.Value = Convert.ToBoolean(xmlAttribute.Value);
							}
						}
					}
				}
			}
			XmlNode xmlNode10 = xmlNode.SelectSingleNode("VisibleTextTransTool");
			if (xmlNode10 != null)
			{
				foreach (object obj2 in xmlNode10.Attributes)
				{
					XmlAttribute xmlAttribute2 = (XmlAttribute)obj2;
					int num2 = -1;
					try
					{
						string value2 = xmlAttribute2.Name.Substring(1, xmlAttribute2.Name.Length - 1);
						num2 = Convert.ToInt32(value2);
					}
					catch
					{
					}
					if (num2 != -1)
					{
						foreach (PropertyFromBaseElement propertyFromBaseElement2 in this.TransformerPassportProperty)
						{
							if (propertyFromBaseElement2.ID == num2)
							{
								propertyFromBaseElement2.Value = Convert.ToBoolean(xmlAttribute2.Value);
							}
						}
					}
				}
			}
		}

		private XmlDocument xmlDocument_0 = new XmlDocument();

		private XmlDocument xmlDocument_1 = new XmlDocument();

		private bool bool_0 = true;

		private SmoothingMode smoothingMode_0 = SmoothingMode.HighSpeed;

		private Color color_0 = Color.Black;

		private Color color_1 = Color.FromArgb(50, Color.Gray);

		private GridLayer.eGridStyle eGridStyle_0 = GridLayer.eGridStyle.Lines;

		private bool bool_1 = true;

		private float float_0 = 0.1f;

		private float float_1 = 3f;

		private List<PropertyFromBaseElement> list_0 = new List<PropertyFromBaseElement>();

		private List<PropertyFromBaseElement> list_1 = new List<PropertyFromBaseElement>();

		private Color color_2 = Color.Red;

		private Color color_3 = Color.Red;

		private Color color_4 = Color.Violet;

		private Color color_5 = Color.RoyalBlue;

		private Color color_6 = Color.Yellow;

		private Color color_7 = Color.Purple;

		private Color color_8 = Color.Plum;

		private Color color_9 = Color.Aqua;

		private Color color_10 = Color.LightCyan;

		private Color color_11 = Color.Yellow;

		private Color color_12 = Color.DarkGoldenrod;

		private Color color_13 = Color.Lime;

		private Color color_14 = Color.DarkGreen;

		private Color color_15 = Color.White;

		private Color color_16 = Color.White;

		private Color color_17 = Color.White;

		private Color color_18 = Color.White;

		private Color color_19 = Color.Yellow;

		private Color color_20 = Color.DarkGoldenrod;

		private Color color_21 = Color.Lime;

		private Color color_22 = Color.DarkGreen;

		private Color color_23 = Color.White;

		private Color color_24 = Color.White;

		private Color color_25 = Color.White;

		private Color color_26 = Color.White;

		private Color color_27 = Color.Yellow;

		private Color color_28 = Color.DarkGoldenrod;

		private Color color_29 = Color.Lime;

		private Color color_30 = Color.DarkGreen;

		private Color color_31 = Color.White;

		private Color color_32 = Color.White;

		private Color color_33 = Color.White;

		private Color color_34 = Color.White;

		private Color color_35 = Color.White;

		private Color color_36 = Color.White;

		private Color color_37 = Color.White;

		private Color color_38 = Color.White;

		private Color color_39 = Color.White;

		private Color color_40 = Color.White;

		private Color color_41 = Color.White;

		private Color color_42 = Color.White;

		private Color color_43 = Color.Aqua;

		private Color color_44 = Color.White;

		private Color color_45 = Color.White;

		private Color color_46 = Color.White;

		private Color color_47 = Color.LightGray;

		private Color color_48 = Color.Green;

		private Color color_49 = Color.Red;

		private Color color_50 = Color.Red;

		private bool bool_2 = true;

		private bool bool_3 = true;

		private bool bool_4 = true;

		private bool bool_5 = true;

		private bool bool_6 = true;

		private Color color_51 = Color.White;

		private Color color_52 = Color.Yellow;

		private TextFont textFont_0 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_1 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_2 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_3 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_4 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_5 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_6 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_7 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_8 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_9 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_10 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_11 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_12 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_13 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_14 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_15 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_16 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_17 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_18 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_19 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_20 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private TextFont textFont_21 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);

		private bool bool_7 = true;

		private bool bool_8 = true;

		private bool bool_9 = true;

		private bool bool_10 = true;

		private bool bool_11 = true;

		[CompilerGenerated]
		private bool bool_12;

		[CompilerGenerated]
		private bool bool_13;

		[CompilerGenerated]
		private bool bool_14;

		[CompilerGenerated]
		private bool bool_15;

		[CompilerGenerated]
		private bool bool_16;

		[CompilerGenerated]
		private int int_0;
	}
}
