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
				return this.LcqTcgRaar;
			}
			set
			{
				this.LcqTcgRaar = value;
			}
		}

		public Color RectangleTPColor
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

		public Color RectangleCPColor
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

		public Color RectangleRPColor
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

		public Color RectanglePPColor
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

		public Color RectangleSPColor
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

		public Color RectanglePPNOColor
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

		public Color Shina110Color
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

		public Color Shina110ColorOff
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

		public Color Shina35Color
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

		public Color Shina35ColorOff
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

		public Color Shina10Color
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

		public Color Shina10ColorOff
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

		public Color Color_0
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

		public Color Shina6ColorOff
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

		public Color Shina04Color
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

		public Color Shina04ColorOff
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

		public Color Shina023Color
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

		public Color Shina023ColorOff
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

		public Color Cell110Color
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

		public Color Cell110ColorOff
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

		public Color Color_1
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

		public Color Cell35ColorOff
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

		public Color Color_2
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

		public Color Cell10ColorOff
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

		public Color Color_3
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

		public Color Cell6ColorOff
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

		public Color Color_4
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

		public Color Cell04ColorOff
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

		public Color Cell023Color
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

		public Color Cell023ColorOff
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

		public Color Line110Color
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

		public Color Line110ColorOff
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

		public Color Color_5
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

		public Color Line35ColorOff
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

		public Color Color_6
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

		public Color Line10ColorOff
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

		public Color Color_7
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

		public Color Line6ColorOff
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

		public Color Color_8
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

		public Color Line04ColorOff
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

		public Color Line023Color
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

		public Color Line023ColorOff
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
				return this.color_46;
			}
			set
			{
				this.color_46 = value;
			}
		}

		public Color LinearDisconnectorToolColor
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

		public Color LoadSwitchToolColor
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

		public Color VacuumSwitchToolColor
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

		public Color OutsideLineDisconnectorToolColor
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

		public Color EndTrimToolColor
		{
			get
			{
				return this.color_53;
			}
			set
			{
				this.color_53 = value;
			}
		}

		public Color GroundingToolColor
		{
			get
			{
				return this.color_55;
			}
			set
			{
				this.color_55 = value;
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
				return this.color_50;
			}
			set
			{
				this.color_50 = value;
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
				return this.color_56;
			}
			set
			{
				this.color_56 = value;
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
				return this.color_57;
			}
			set
			{
				this.color_57 = value;
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
				return this.color_54;
			}
			set
			{
				this.color_54 = value;
			}
		}

		public Color ObjectOnLineColorOff
		{
			get
			{
				return this.color_58;
			}
			set
			{
				this.color_58 = value;
			}
		}

		public Color ObjectOnLineColorOffN
		{
			get
			{
				return this.color_59;
			}
			set
			{
				this.color_59 = value;
			}
		}

		public Color ObjectOnLineDamageStateColor
		{
			get
			{
				return this.color_60;
			}
			set
			{
				this.color_60 = value;
			}
		}

		public Color ObjectOnLineKeyStateColor
		{
			get
			{
				return this.color_61;
			}
			set
			{
				this.color_61 = value;
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
				return this.color_62;
			}
			set
			{
				this.color_62 = value;
			}
		}

		public Color TransformerToolColor
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

		public TextFont TextPropertyShina110
		{
			get
			{
				return this.textFont_6;
			}
			set
			{
				this.textFont_8 = value;
			}
		}

		public TextFont TextPropertyShina35
		{
			get
			{
				return this.textFont_7;
			}
			set
			{
				this.textFont_8 = value;
			}
		}

		public TextFont TextPropertyShina10
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

		public TextFont TextPropertyShina6
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

		public TextFont TextPropertyShina04
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

		public TextFont TextPropertyShina023
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

		public TextFont TextPropertyCell110
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

		public TextFont TextPropertyCell35
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

		public TextFont TextPropertyCell10
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

		public TextFont TextPropertyCell6
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

		public TextFont TextPropertyCell04
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

		public TextFont TextPropertyCell023
		{
			get
			{
				return this.EqtxAfRxJN;
			}
			set
			{
				this.EqtxAfRxJN = value;
			}
		}

		public TextFont TextPropertyObjectInLine
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

		public TextFont TextPropertyNormalSection
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

		public TextFont TextPropertyTextBranch
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

		public TextFont TextPropertyAutomaticEntryProvision
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

		public TextFont TextPropertySpecialLocking
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

		public TextFont TextPropertyTelemechanics
		{
			get
			{
				return this.textFont_22;
			}
			set
			{
				this.textFont_22 = value;
			}
		}

		public TextFont TextPropertyTelemechanicsProtection
		{
			get
			{
				return this.textFont_23;
			}
			set
			{
				this.textFont_23 = value;
			}
		}

		public TextFont TextPropertyResponsibleAbonentTool
		{
			get
			{
				return this.textFont_24;
			}
			set
			{
				this.textFont_24 = value;
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
				return this.color_63;
			}
			set
			{
				this.color_63 = value;
			}
		}

		public int MeasurementYear { get; set; }

		public CanvasSettings()
		{
			
			this.xmlDocument_0 = new XmlDocument();
			this.xmlDocument_1 = new XmlDocument();
			this.bool_0 = true;
			this.smoothingMode_0 = SmoothingMode.HighSpeed;
			this.color_0 = Color.Black;
			this.color_1 = Color.FromArgb(50, Color.Gray);
			this.eGridStyle_0 = GridLayer.eGridStyle.Lines;
			this.bool_1 = true;
			this.float_0 = 0.1f;
			this.float_1 = 3f;
			this.list_0 = new List<PropertyFromBaseElement>();
			this.list_1 = new List<PropertyFromBaseElement>();
			this.color_2 = Color.Red;
			this.color_3 = Color.Red;
			this.LcqTcgRaar = Color.Violet;
			this.color_4 = Color.RoyalBlue;
			this.color_5 = Color.Yellow;
			this.color_6 = Color.Purple;
			this.color_7 = Color.Plum;
			this.color_8 = Color.Aqua;
			this.color_9 = Color.LightCyan;
			this.color_10 = Color.Yellow;
			this.color_11 = Color.DarkGoldenrod;
			this.color_12 = Color.Yellow;
			this.color_13 = Color.DarkGoldenrod;
			this.color_14 = Color.Yellow;
			this.color_15 = Color.DarkGoldenrod;
			this.color_16 = Color.Lime;
			this.color_17 = Color.DarkGreen;
			this.color_18 = Color.White;
			this.color_19 = Color.White;
			this.color_20 = Color.White;
			this.color_21 = Color.White;
			this.color_22 = Color.Yellow;
			this.color_23 = Color.DarkGoldenrod;
			this.color_24 = Color.Yellow;
			this.color_25 = Color.DarkGoldenrod;
			this.color_26 = Color.Yellow;
			this.color_27 = Color.DarkGoldenrod;
			this.color_28 = Color.Lime;
			this.color_29 = Color.DarkGreen;
			this.color_30 = Color.White;
			this.color_31 = Color.White;
			this.color_32 = Color.White;
			this.color_33 = Color.White;
			this.color_34 = Color.Yellow;
			this.color_35 = Color.DarkGoldenrod;
			this.color_36 = Color.Yellow;
			this.color_37 = Color.DarkGoldenrod;
			this.color_38 = Color.Yellow;
			this.color_39 = Color.DarkGoldenrod;
			this.color_40 = Color.Lime;
			this.color_41 = Color.DarkGreen;
			this.color_42 = Color.White;
			this.color_43 = Color.White;
			this.color_44 = Color.White;
			this.color_45 = Color.White;
			this.color_46 = Color.White;
			this.color_47 = Color.White;
			this.color_48 = Color.White;
			this.color_49 = Color.White;
			this.color_50 = Color.White;
			this.color_51 = Color.White;
			this.color_52 = Color.White;
			this.color_53 = Color.White;
			this.color_54 = Color.Aqua;
			this.color_55 = Color.White;
			this.color_56 = Color.White;
			this.color_57 = Color.White;
			this.color_58 = Color.LightGray;
			this.color_59 = Color.Green;
			this.color_60 = Color.Red;
			this.color_61 = Color.Red;
			this.bool_2 = true;
			this.bool_3 = true;
			this.bool_4 = true;
			this.bool_5 = true;
			this.bool_6 = true;
			this.color_62 = Color.White;
			this.color_63 = Color.Yellow;
			this.textFont_0 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_1 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_2 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_3 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_4 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_5 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_6 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_7 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_8 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_9 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_10 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_11 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_12 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_13 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_14 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_15 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_16 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.EqtxAfRxJN = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_17 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_18 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_19 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_20 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_21 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_22 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_23 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.textFont_24 = new TextFont("Arial", 10f, false, false, false, ePositionText.T, false, true, Color.White);
			this.bool_7 = true;
			this.bool_8 = true;
			this.bool_9 = true;
			this.bool_10 = true;
			this.bool_11 = true;
			
		}

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
			this.textFont_8.FontSize += 0.5f;
			this.textFont_9.FontSize += 0.5f;
			this.textFont_10.FontSize += 0.5f;
			this.textFont_11.FontSize += 0.5f;
			this.textFont_14.FontSize += 0.5f;
			this.textFont_15.FontSize += 0.5f;
			this.textFont_16.FontSize += 0.5f;
			this.EqtxAfRxJN.FontSize += 0.5f;
			this.textFont_17.FontSize += 0.5f;
			this.textFont_18.FontSize += 0.5f;
			this.textFont_19.FontSize += 0.5f;
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
				this.textFont_16.FontSize -= 0.5f;
			}
			if (this.EqtxAfRxJN.FontSize >= 1f)
			{
				this.EqtxAfRxJN.FontSize -= 0.5f;
			}
			if (this.textFont_17.FontSize >= 1f)
			{
				this.textFont_17.FontSize -= 0.5f;
			}
			if (this.textFont_18.FontSize >= 1f)
			{
				this.textFont_18.FontSize -= 0.5f;
			}
			if (this.textFont_19.FontSize >= 1f)
			{
				this.textFont_19.FontSize += 0.5f;
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
			DataSetScheme @class = new DataSetScheme();
			IPAddress ipaddress = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];
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
				sqlDataCommand.SelectSqlData(@class.tSchm_Settings, true, "where [HostIP]='" + ipaddress.ToString() + "_2'", null, false, 0);
			}
			else
			{
				sqlDataCommand.SelectSqlData(@class.tSchm_Settings, true, "where [HostIP]='" + ipaddress.ToString() + "'", null, false, 0);
			}
			if (@class.tSchm_Settings.Rows.Count == 0)
			{
				DataRow dataRow = @class.tSchm_Settings.NewRow();
				dataRow["HostIP"] = ((typeCanvas == eTypeCanvas.SchemeSecond) ? (ipaddress.ToString() + "_2") : ipaddress.ToString());
				dataRow["Settings"] = this.DocUser.InnerXml;
				@class.tSchm_Settings.Rows.Add(dataRow);
				sqlDataCommand.InsertSqlDataOneRow(@class.tSchm_Settings);
			}
			else
			{
				@class.tSchm_Settings.Rows[0]["Settings"] = this.DocUser.InnerXml;
				@class.tSchm_Settings.Rows[0].EndEdit();
				sqlDataCommand.UpdateSqlData(@class, @class.tSchm_Settings);
			}
			@class = new DataSetScheme();
			if (typeCanvas == eTypeCanvas.SchemeSecond)
			{
				sqlDataCommand.SelectSqlData(@class.tSchm_Settings, true, "where [HostIP]='Default_2'", null, false, 0);
			}
			else
			{
				sqlDataCommand.SelectSqlData(@class.tSchm_Settings, true, "where [HostIP]='Default'", null, false, 0);
			}
			if (@class.tSchm_Settings.Rows.Count == 0)
			{
				DataRow dataRow2 = @class.tSchm_Settings.NewRow();
				dataRow2["HostIP"] = ((typeCanvas == eTypeCanvas.SchemeSecond) ? "Default_2" : "Default");
				dataRow2["Settings"] = this.DocDefault.InnerXml;
				@class.tSchm_Settings.Rows.Add(dataRow2);
				sqlDataCommand.InsertSqlDataOneRow(@class.tSchm_Settings);
				return;
			}
			@class.tSchm_Settings.Rows[0]["Settings"] = this.DocDefault.InnerXml;
			@class.tSchm_Settings.Rows[0].EndEdit();
			sqlDataCommand.UpdateSqlData(@class, @class.tSchm_Settings);
		}

		public void LoadTransPropertyList(SQLSettings sqlSetting)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlSetting);
			DataSetScheme @class = new DataSetScheme();
			sqlDataCommand.SelectSqlData(@class.tP_CharList, true, "where ParentKey like ';EquipChar;Passp;Trans;%' and IsGroup = 0 and Deleted=0", null, false, 0);
			bool flag = this.TransformerPassportProperty.Count > 0;
			foreach (DataSetScheme.Class71 class2 in @class.tP_CharList)
			{
				int num = Convert.ToInt32(class2["id"]);
				bool flag2 = false;
				if (!flag)
				{
					goto IL_117;
				}
				using (List<PropertyFromBaseElement>.Enumerator enumerator2 = this.TransformerPassportProperty.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						PropertyFromBaseElement propertyFromBaseElement = enumerator2.Current;
						if (propertyFromBaseElement.ID == num)
						{
							propertyFromBaseElement.Name = class2["Name"].ToString();
							flag2 = true;
							break;
						}
					}
					goto IL_117;
				}
				IL_D0:
				PropertyFromBaseElement propertyFromBaseElement2 = new PropertyFromBaseElement();
				propertyFromBaseElement2.ID = num;
				propertyFromBaseElement2.Name = class2["Name"].ToString();
				propertyFromBaseElement2.Value = false;
				this.TransformerPassportProperty.Add(propertyFromBaseElement2);
				continue;
				IL_117:
				if (!flag2)
				{
					goto IL_D0;
				}
			}
		}

		public void LoadLinePropertyList(SQLSettings sqlSetting)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlSetting);
			DataSetScheme @class = new DataSetScheme();
			sqlDataCommand.SelectSqlData(@class.tP_CharList, true, "where ParentKey like ';EquipChar;Passp;Line%' and IsGroup = 0 and Deleted=0", null, false, 0);
			bool flag = this.LinePassportProperty.Count > 0;
			foreach (DataSetScheme.Class71 class2 in @class.tP_CharList)
			{
				int num = Convert.ToInt32(class2["id"]);
				bool flag2 = false;
				if (!flag)
				{
					goto IL_117;
				}
				using (List<PropertyFromBaseElement>.Enumerator enumerator2 = this.LinePassportProperty.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						PropertyFromBaseElement propertyFromBaseElement = enumerator2.Current;
						if (propertyFromBaseElement.ID == num)
						{
							propertyFromBaseElement.Name = class2["Name"].ToString();
							flag2 = true;
							break;
						}
					}
					goto IL_117;
				}
				IL_D0:
				PropertyFromBaseElement propertyFromBaseElement2 = new PropertyFromBaseElement();
				propertyFromBaseElement2.ID = num;
				propertyFromBaseElement2.Name = class2["Name"].ToString();
				propertyFromBaseElement2.Value = false;
				this.LinePassportProperty.Add(propertyFromBaseElement2);
				continue;
				IL_117:
				if (!flag2)
				{
					goto IL_D0;
				}
			}
		}

		public void LoadSchemeFromBase(SQLSettings sqlSetting, eTypeCanvas typeCanvas)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlSetting);
			DataSetScheme @class = new DataSetScheme();
			this.LoadTransPropertyList(sqlSetting);
			this.LoadLinePropertyList(sqlSetting);
			IPAddress ipaddress = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];
			string text = (typeCanvas == eTypeCanvas.SchemeSecond) ? (ipaddress.ToString() + "_2") : ipaddress.ToString();
			string text2 = (typeCanvas == eTypeCanvas.SchemeSecond) ? "Default_2" : "Default";
			sqlDataCommand.SelectSqlData(@class.tSchm_Settings, true, string.Concat(new string[]
			{
				"where [HostIP]='",
				text,
				"' or [HostIP] = '",
				text2,
				"'"
			}), null, false, 0);
			DataRow[] array = @class.tSchm_Settings.Select("HostIP = '" + text + "'");
			DataRow[] array2 = @class.tSchm_Settings.Select("HostIP = '" + text2 + "'");
			if (array.Length != 0)
			{
				try
				{
					this.xmlDocument_0.LoadXml((string)array[0]["Settings"]);
				}
				catch
				{
					this.xmlDocument_0 = this.SaveToXmlDocument();
				}
				if (array2.Length != 0)
				{
					try
					{
						this.xmlDocument_1.LoadXml((string)array2[0]["Settings"]);
						goto IL_1F2;
					}
					catch
					{
						this.xmlDocument_1 = this.SaveToXmlDocument();
						goto IL_1F2;
					}
				}
				try
				{
					this.xmlDocument_1.LoadXml((string)array[0]["Settings"]);
					goto IL_1F2;
				}
				catch
				{
					this.xmlDocument_1 = this.SaveToXmlDocument();
					goto IL_1F2;
				}
			}
			if (array2.Length != 0)
			{
				try
				{
					this.xmlDocument_0.LoadXml((string)array2[0]["Settings"]);
					this.xmlDocument_1.LoadXml((string)array2[0]["Settings"]);
					goto IL_1F2;
				}
				catch
				{
					this.xmlDocument_0 = (this.xmlDocument_1 = this.SaveToXmlDocument());
					goto IL_1F2;
				}
			}
			this.xmlDocument_1 = (this.xmlDocument_0 = this.SaveToXmlDocument());
			IL_1F2:
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
						num = Convert.ToInt32(xmlAttribute.Name.Substring(1, xmlAttribute.Name.Length - 1));
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
						num2 = Convert.ToInt32(xmlAttribute2.Name.Substring(1, xmlAttribute2.Name.Length - 1));
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

		private XmlDocument xmlDocument_0;

		private XmlDocument xmlDocument_1;

		private bool bool_0;

		private SmoothingMode smoothingMode_0;

		private Color color_0;

		private Color color_1;

		private GridLayer.eGridStyle eGridStyle_0;

		private bool bool_1;

		private float float_0;

		private float float_1;

		private List<PropertyFromBaseElement> list_0;

		private List<PropertyFromBaseElement> list_1;

		private Color color_2;

		private Color color_3;

		private Color LcqTcgRaar;

		private Color color_4;

		private Color color_5;

		private Color color_6;

		private Color color_7;

		private Color color_8;

		private Color color_9;

		private Color color_10;

		private Color color_11;

		private Color color_12;

		private Color color_13;

		private Color color_14;

		private Color color_15;

		private Color color_16;

		private Color color_17;

		private Color color_18;

		private Color color_19;

		private Color color_20;

		private Color color_21;

		private Color color_22;

		private Color color_23;

		private Color color_24;

		private Color color_25;

		private Color color_26;

		private Color color_27;

		private Color color_28;

		private Color color_29;

		private Color color_30;

		private Color color_31;

		private Color color_32;

		private Color color_33;

		private Color color_34;

		private Color color_35;

		private Color color_36;

		private Color color_37;

		private Color color_38;

		private Color color_39;

		private Color color_40;

		private Color color_41;

		private Color color_42;

		private Color color_43;

		private Color color_44;

		private Color color_45;

		private Color color_46;

		private Color color_47;

		private Color color_48;

		private Color color_49;

		private Color color_50;

		private Color color_51;

		private Color color_52;

		private Color color_53;

		private Color color_54;

		private Color color_55;

		private Color color_56;

		private Color color_57;

		private Color color_58;

		private Color color_59;

		private Color color_60;

		private Color color_61;

		private bool bool_2;

		private bool bool_3;

		private bool bool_4;

		private bool bool_5;

		private bool bool_6;

		private Color color_62;

		private Color color_63;

		private TextFont textFont_0;

		private TextFont textFont_1;

		private TextFont textFont_2;

		private TextFont textFont_3;

		private TextFont textFont_4;

		private TextFont textFont_5;

		private TextFont textFont_6;

		private TextFont textFont_7;

		private TextFont textFont_8;

		private TextFont textFont_9;

		private TextFont textFont_10;

		private TextFont textFont_11;

		private TextFont textFont_12;

		private TextFont textFont_13;

		private TextFont textFont_14;

		private TextFont textFont_15;

		private TextFont textFont_16;

		private TextFont EqtxAfRxJN;

		private TextFont textFont_17;

		private TextFont textFont_18;

		private TextFont textFont_19;

		private TextFont textFont_20;

		private TextFont textFont_21;

		private TextFont textFont_22;

		private TextFont textFont_23;

		private TextFont textFont_24;

		private bool bool_7;

		private bool bool_8;

		private bool bool_9;

		private bool bool_10;

		private bool bool_11;

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
