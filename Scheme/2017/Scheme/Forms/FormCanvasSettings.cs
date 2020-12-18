using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using DataSql;
using Scheme.Classes;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Layers;
using Telemetry;

namespace Scheme.Forms
{
	public partial class FormCanvasSettings : Form
	{
		public FormCanvasSettings(CanvasControl canvas)
		{
			Class63.AGd1PxHzk5wxP();
			base..ctor();
			this.InitializeComponent();
			if (this.canvasColor.Layers.Count<ICanvasLayer>() <= 0)
			{
				DrawingLayer drawingLayer = new DrawingLayer("layerSett", "Layer Setiings", Color.White, 0f);
				drawingLayer.Parent = this.canvasColor;
				drawingLayer.Enabled = false;
				this.canvasColor.AddLayer(drawingLayer);
			}
			this.canvasControl_0 = canvas;
			this.canvasColor.Settings = this.canvasControl_0.Settings.Clone();
			this.opcconfig_0 = this.canvasControl_0.OpcClient.OpcConfig;
			if (!this.canvasColor.Settings.UseDefaultSettings)
			{
				this.radioButtonGeneral.CheckedChanged -= this.radioButtonGeneral_CheckedChanged;
				this.radioButtonIndividual.Checked = true;
				this.radioButtonGeneral.CheckedChanged += this.radioButtonGeneral_CheckedChanged;
			}
			this.method_4();
			this.treeViewColors.SelectedNode = this.treeViewColors.Nodes[0];
			this.method_2();
			this.method_1();
			this.method_0();
			this.method_13();
			this.method_15();
		}

		private void method_0()
		{
			this.numericSizeIcon.Value = GeneralFormSettings.SizeIcon.Height;
			this.numericFontSize.Value = (decimal)GeneralFormSettings.FontSize;
		}

		private void method_1()
		{
			int index = this.cablePropDataGridView.Rows.Add();
			this.cablePropDataGridView.Rows[index].Cells[0].Value = "Марка кабеля";
			this.cablePropDataGridView.Rows[index].Cells[1].Value = this.canvasColor.Settings.VisibleCableMakeup;
			index = this.cablePropDataGridView.Rows.Add();
			this.cablePropDataGridView.Rows[index].Cells[0].Value = "Напряжение кабеля";
			this.cablePropDataGridView.Rows[index].Cells[1].Value = this.canvasColor.Settings.VisibleCableVoltage;
			index = this.cablePropDataGridView.Rows.Add();
			this.cablePropDataGridView.Rows[index].Cells[0].Value = "Количество жил кабеля";
			this.cablePropDataGridView.Rows[index].Cells[1].Value = this.canvasColor.Settings.VisibleCableWires;
			index = this.cablePropDataGridView.Rows.Add();
			this.cablePropDataGridView.Rows[index].Cells[0].Value = "Сечение кабеля";
			this.cablePropDataGridView.Rows[index].Cells[1].Value = this.canvasColor.Settings.VisibleCableCrossSection;
			index = this.cablePropDataGridView.Rows.Add();
			this.cablePropDataGridView.Rows[index].Cells[0].Value = "Длина кабеля";
			this.cablePropDataGridView.Rows[index].Cells[1].Value = this.canvasColor.Settings.VisibleCableLength;
			this.canvasColor.Settings.LoadLinePropertyList(this.canvasControl_0.SqlSettings);
			foreach (PropertyFromBaseElement propertyFromBaseElement in this.canvasColor.Settings.LinePassportProperty)
			{
				index = this.cablePropDataGridView.Rows.Add();
				this.cablePropDataGridView.Rows[index].Tag = propertyFromBaseElement.ID;
				this.cablePropDataGridView.Rows[index].Cells[0].Value = propertyFromBaseElement.Name;
				this.cablePropDataGridView.Rows[index].Cells[1].Value = propertyFromBaseElement.Value;
			}
		}

		private void method_2()
		{
			this.canvasColor.Settings.LoadTransPropertyList(this.canvasControl_0.SqlSettings);
			foreach (PropertyFromBaseElement propertyFromBaseElement in this.canvasColor.Settings.TransformerPassportProperty)
			{
				int index = this.hmoeAwgdZN.Rows.Add();
				this.hmoeAwgdZN.Rows[index].Tag = propertyFromBaseElement.ID;
				this.hmoeAwgdZN.Rows[index].Cells[0].Value = propertyFromBaseElement.Name;
				this.hmoeAwgdZN.Rows[index].Cells[1].Value = propertyFromBaseElement.Value;
			}
		}

		private void FormCanvasSettings_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				this.method_3();
			}
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			this.method_3();
			this.canvasControl_0.DoInvalidate(true);
		}

		private void method_3()
		{
			if (this.canvasColor.Settings.UseDefaultSettings)
			{
				this.canvasColor.Settings.DocDefault = this.canvasColor.Settings.SaveToXmlDocument();
			}
			else
			{
				this.canvasColor.Settings.DocUser = this.canvasColor.Settings.SaveToXmlDocument();
			}
			this.canvasControl_0.Settings = this.canvasColor.Settings.Clone();
			this.canvasControl_0.Settings.SaveToBase(this.canvasControl_0.SqlSettings, this.canvasControl_0.TypeCanvas);
			if (GeneralFormSettings.SizeIcon.Width != (int)this.numericSizeIcon.Value)
			{
				GeneralFormSettings.SizeIcon = new Size((int)this.numericSizeIcon.Value, (int)this.numericSizeIcon.Value);
			}
			GeneralFormSettings.FontSize = (float)this.numericFontSize.Value;
			this.method_14();
		}

		private void treeViewColors_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.IsSelected)
			{
				this.checkBoxColorLine.CheckedChanged -= this.checkBoxColorLine_CheckedChanged;
				this.panelColor.Visible = false;
				this.panelColor.Enabled = true;
				this.panelColorOff.Visible = false;
				this.panelSelectedColor.Visible = false;
				this.groupBoxGrid.Visible = false;
				this.buttonFont.Visible = false;
				this.panelColorOff.Visible = false;
				this.checkBoxColorLine.Visible = false;
				this.panelZoomSimply.Visible = false;
				this.panelFontNoVisible.Visible = false;
				this.panelColorNormal.Visible = false;
				this.panelZoomSimply.Visible = false;
				this.panelFontNoVisible.Visible = false;
				this.numericUpDownFontNoVisible.Value = (decimal)this.canvasColor.Settings.FontSizeNoVisible;
				this.method_5();
				if (e.Node.Text == "Фон")
				{
					Control control = this.panelColor;
					this.panelColor.Enabled = true;
					control.Visible = true;
					this.panelColorOff.Visible = false;
					this.buttonFont.Visible = false;
					this.panelColorSel.BackColor = this.canvasColor.Settings.BackgroundColor;
					this.panelFontNoVisible.Visible = false;
					this.panelSelectedColor.Visible = false;
					this.groupBoxGrid.Visible = false;
					this.checkBoxColorLine.Visible = false;
				}
				if (e.Node.Text == "Сетка")
				{
					Control control2 = this.panelColor;
					this.panelColor.Enabled = true;
					control2.Visible = true;
					this.panelColorOff.Visible = false;
					this.buttonFont.Visible = false;
					this.panelColorSel.BackColor = this.canvasColor.Settings.GridColor;
					this.panelSelectedColor.Visible = false;
					this.groupBoxGrid.Visible = true;
					this.checkBoxColorLine.Visible = false;
					this.panelFontNoVisible.Visible = false;
					if (!this.canvasColor.Settings.GridVisible)
					{
						this.radioButtonNoVisibleGrid.Checked = true;
					}
					else if (this.canvasColor.Settings.GridStyle == GridLayer.eGridStyle.Dots)
					{
						this.radioButtonDots.Checked = true;
					}
					else
					{
						this.radioButtonLine.Checked = true;
					}
				}
				if (e.Node.Text == "Выделенные объекты")
				{
					Control control3 = this.panelColor;
					this.panelColor.Enabled = true;
					control3.Visible = true;
					this.panelColorOff.Visible = false;
					this.panelSelectedColor.Visible = false;
					this.panelColorOff.Visible = false;
					this.groupBoxGrid.Visible = false;
					this.buttonFont.Visible = false;
					this.checkBoxColorLine.Visible = false;
					this.panelColorSel.BackColor = this.canvasColor.Settings.SelectedObjColor;
					this.method_6(eTypeRectangleTool.TP);
					this.method_8(eTypeShinaTool.Shina_10);
					using (IEnumerator<ICanvasLayer> enumerator = this.canvasColor.Layers.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ICanvasLayer canvasLayer = enumerator.Current;
							foreach (DrawObjectBase drawobject in ((DrawingLayer)canvasLayer).Objects)
							{
								this.canvasColor.SelectObject(drawobject);
							}
						}
						goto IL_385;
					}
				}
				this.canvasColor.ClearSelectedObjects();
				IL_385:
				if (e.Node.Text == "Отмеченные объекты")
				{
					Control control4 = this.panelColor;
					this.panelColor.Enabled = true;
					control4.Visible = true;
					this.panelColorOff.Visible = false;
					this.panelSelectedColor.Visible = false;
					this.panelColorOff.Visible = false;
					this.groupBoxGrid.Visible = false;
					this.buttonFont.Visible = false;
					this.checkBoxColorLine.Visible = false;
					this.panelColorSel.BackColor = this.canvasColor.Settings.MarkedObjColor;
					this.method_6(eTypeRectangleTool.TP);
					this.method_8(eTypeShinaTool.Shina_10);
					List<DrawObjectBase> list = new List<DrawObjectBase>();
					foreach (ICanvasLayer canvasLayer2 in this.canvasColor.Layers)
					{
						foreach (DrawObjectBase item in ((DrawingLayer)canvasLayer2).Objects)
						{
							list.Add(item);
						}
					}
					this.canvasColor.AddBookMark(list);
				}
				else
				{
					this.canvasColor.ClearBookmarks();
				}
				if (e.Node.Text == "Мерцающие объекты")
				{
					Control control5 = this.panelColor;
					this.panelColor.Enabled = true;
					control5.Visible = true;
					this.panelColorOff.Visible = false;
					this.panelSelectedColor.Visible = false;
					this.panelColorOff.Visible = false;
					this.groupBoxGrid.Visible = false;
					this.buttonFont.Visible = false;
					this.checkBoxColorLine.Visible = false;
					this.panelColorSel.BackColor = this.canvasColor.Settings.BackFlashingColor;
					this.method_6(eTypeRectangleTool.TP);
					this.method_8(eTypeShinaTool.Shina_10);
					using (IEnumerator<ICanvasLayer> enumerator = this.canvasColor.Layers.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ICanvasLayer canvasLayer3 = enumerator.Current;
							foreach (DrawObjectBase obj in ((DrawingLayer)canvasLayer3).Objects)
							{
								this.canvasColor.AddFlashObject(obj);
							}
						}
						goto IL_5DD;
					}
				}
				this.canvasColor.ClearFlashingObjects();
				IL_5DD:
				if (e.Node.Parent != null && e.Node.Parent.Text == "Подстанции")
				{
					Control control6 = this.panelColor;
					this.panelColor.Enabled = true;
					control6.Visible = true;
					this.panelColorOff.Visible = false;
					this.panelSelectedColor.Visible = false;
					this.groupBoxGrid.Visible = false;
					this.buttonFont.Visible = true;
					this.checkBoxColorLine.Visible = false;
					TextFont textFont = new TextFont();
					if (e.Node.Text == "ЦП")
					{
						this.method_6(eTypeRectangleTool.CP);
						this.panelColorSel.BackColor = this.canvasColor.Settings.RectangleCPColor;
						textFont = this.canvasColor.Settings.TextPropertyCP;
					}
					if (e.Node.Text == "ТП")
					{
						this.method_6(eTypeRectangleTool.TP);
						this.panelColorSel.BackColor = this.canvasColor.Settings.RectangleTPColor;
						textFont = this.canvasColor.Settings.TextPropertyTP;
					}
					if (e.Node.Text == "РП")
					{
						this.method_6(eTypeRectangleTool.RP);
						this.panelColorSel.BackColor = this.canvasColor.Settings.RectangleRPColor;
						textFont = this.canvasColor.Settings.TextPropertyRP;
					}
					if (e.Node.Text == "ПП")
					{
						this.method_6(eTypeRectangleTool.PP);
						this.panelColorSel.BackColor = this.canvasColor.Settings.RectanglePPColor;
						textFont = this.canvasColor.Settings.TextPropertyPP;
					}
					if (e.Node.Text == "СП")
					{
						this.method_6(eTypeRectangleTool.SP);
						this.panelColorSel.BackColor = this.canvasColor.Settings.RectangleSPColor;
						textFont = this.canvasColor.Settings.TextPropertySP;
					}
					if (e.Node.Text == "ППНО")
					{
						this.method_6(eTypeRectangleTool.PPNO);
						this.panelColorSel.BackColor = this.canvasColor.Settings.RectanglePPNOColor;
						textFont = this.canvasColor.Settings.TextPropertyPPNO;
					}
					FontStyle fontStyle = FontStyle.Regular;
					if (textFont.FontBold)
					{
						fontStyle = FontStyle.Bold;
					}
					if (textFont.FontItalic)
					{
						fontStyle |= FontStyle.Italic;
					}
					if (textFont.FontUnderline)
					{
						fontStyle |= FontStyle.Underline;
					}
					this.fontDialog_0.Font = new Font(textFont.FontName, textFont.FontSize, fontStyle, GraphicsUnit.Pixel);
					this.fontDialog_0.Color = textFont.Color;
				}
				if (e.Node.Parent != null && e.Node.Parent.Text == "Шины")
				{
					Control control7 = this.panelColor;
					this.panelColor.Enabled = true;
					control7.Visible = true;
					Control control8 = this.panelColorOff;
					this.panelColorOff.Enabled = true;
					control8.Visible = true;
					this.panelSelectedColor.Visible = false;
					this.groupBoxGrid.Visible = false;
					this.buttonFont.Visible = true;
					this.checkBoxColorLine.Visible = false;
					TextFont textFont2 = new TextFont();
					if (e.Node.Text == "Шина 110 кВ")
					{
						this.method_8(eTypeShinaTool.Shina_110);
						this.panelColorSel.BackColor = this.canvasColor.Settings.Shina110Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Shina110ColorOff;
						textFont2 = this.canvasColor.Settings.TextPropertyShina110;
					}
					if (e.Node.Text == "Шина 35 кВ")
					{
						this.method_8(eTypeShinaTool.Shina_35);
						this.panelColorSel.BackColor = this.canvasColor.Settings.Shina35Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Shina35ColorOff;
						textFont2 = this.canvasColor.Settings.TextPropertyShina35;
					}
					if (e.Node.Text == "Шина 10 кВ")
					{
						this.method_8(eTypeShinaTool.Shina_10);
						this.panelColorSel.BackColor = this.canvasColor.Settings.Shina10Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Shina10ColorOff;
						textFont2 = this.canvasColor.Settings.TextPropertyShina10;
					}
					if (e.Node.Text == "Шина 6 кВ")
					{
						this.method_8(eTypeShinaTool.Shina_6);
						this.panelColorSel.BackColor = this.canvasColor.Settings.Shina6Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Shina6ColorOff;
						textFont2 = this.canvasColor.Settings.TextPropertyShina6;
					}
					if (e.Node.Text == "Шина 0,4 кВ")
					{
						this.method_8(eTypeShinaTool.Shina_04);
						this.panelColorSel.BackColor = this.canvasColor.Settings.Shina04Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Shina04ColorOff;
						textFont2 = this.canvasColor.Settings.TextPropertyShina04;
					}
					if (e.Node.Text == "Шина 0,23 кВ")
					{
						this.method_8(eTypeShinaTool.Shina_023);
						this.panelColorSel.BackColor = this.canvasColor.Settings.Shina023Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Shina023ColorOff;
						textFont2 = this.canvasColor.Settings.TextPropertyShina023;
					}
					FontStyle fontStyle2 = FontStyle.Regular;
					if (textFont2.FontBold)
					{
						fontStyle2 = FontStyle.Bold;
					}
					if (textFont2.FontItalic)
					{
						fontStyle2 |= FontStyle.Italic;
					}
					if (textFont2.FontUnderline)
					{
						fontStyle2 |= FontStyle.Underline;
					}
					this.fontDialog_0.Font = new Font(textFont2.FontName, textFont2.FontSize, fontStyle2, GraphicsUnit.Pixel);
					this.fontDialog_0.Color = textFont2.Color;
				}
				if (e.Node.Parent != null && e.Node.Parent.Text == "Ячейки")
				{
					Control control9 = this.panelColor;
					this.panelColor.Enabled = true;
					control9.Visible = true;
					Control control10 = this.panelColorOff;
					this.panelColorOff.Enabled = true;
					control10.Visible = true;
					this.panelSelectedColor.Visible = false;
					this.groupBoxGrid.Visible = false;
					this.buttonFont.Visible = true;
					this.checkBoxColorLine.Visible = false;
					TextFont textFont3 = new TextFont();
					if (e.Node.Text == "Ячейка 110 кВ")
					{
						this.method_9("110 кВ");
						this.panelColorSel.BackColor = this.canvasColor.Settings.Cell110Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Cell110ColorOff;
						textFont3 = this.canvasColor.Settings.TextPropertyCell110;
					}
					if (e.Node.Text == "Ячейка 35 кВ")
					{
						this.method_9("35 кВ");
						this.panelColorSel.BackColor = this.canvasColor.Settings.Cell35Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Cell35ColorOff;
						textFont3 = this.canvasColor.Settings.TextPropertyCell35;
					}
					if (e.Node.Text == "Ячейка 10 кВ")
					{
						this.method_9("10 кВ");
						this.panelColorSel.BackColor = this.canvasColor.Settings.Cell10Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Cell10ColorOff;
						textFont3 = this.canvasColor.Settings.TextPropertyCell10;
					}
					if (e.Node.Text == "Ячейка 6 кВ")
					{
						this.method_9("6 кВ");
						this.panelColorSel.BackColor = this.canvasColor.Settings.Cell6Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Cell6ColorOff;
						textFont3 = this.canvasColor.Settings.TextPropertyCell6;
					}
					if (e.Node.Text == "Ячейка 0,4 кВ")
					{
						this.method_9("0,4 кВ");
						this.panelColorSel.BackColor = this.canvasColor.Settings.Cell04Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Cell04ColorOff;
						textFont3 = this.canvasColor.Settings.TextPropertyCell04;
					}
					if (e.Node.Text == "Ячейка 0,23 кВ")
					{
						this.method_9("0,23 кВ");
						this.panelColorSel.BackColor = this.canvasColor.Settings.Cell023Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Cell023ColorOff;
						textFont3 = this.canvasColor.Settings.TextPropertyCell023;
					}
					FontStyle fontStyle3 = FontStyle.Regular;
					if (textFont3.FontBold)
					{
						fontStyle3 = FontStyle.Bold;
					}
					if (textFont3.FontItalic)
					{
						fontStyle3 |= FontStyle.Italic;
					}
					if (textFont3.FontUnderline)
					{
						fontStyle3 |= FontStyle.Underline;
					}
					this.fontDialog_0.Font = new Font(textFont3.FontName, textFont3.FontSize, fontStyle3, GraphicsUnit.Pixel);
					this.fontDialog_0.Color = textFont3.Color;
				}
				if (e.Node.Parent != null && e.Node.Parent.Text == "Линии")
				{
					Control control11 = this.panelColor;
					this.panelColor.Enabled = true;
					control11.Visible = true;
					Control control12 = this.panelColorOff;
					this.panelColorOff.Enabled = true;
					control12.Visible = true;
					this.panelSelectedColor.Visible = false;
					this.groupBoxGrid.Visible = false;
					this.checkBoxColorLine.Visible = false;
					if (e.Node.Text == "Линия 110 кВ")
					{
						this.method_10("110 кВ");
						this.panelColorSel.BackColor = this.canvasColor.Settings.Line110Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Line110ColorOff;
					}
					if (e.Node.Text == "Линия 35 кВ")
					{
						this.method_10("35 кВ");
						this.panelColorSel.BackColor = this.canvasColor.Settings.Line35Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Line35ColorOff;
					}
					if (e.Node.Text == "Линия 10 кВ")
					{
						this.method_10("10 кВ");
						this.panelColorSel.BackColor = this.canvasColor.Settings.Line10Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Line10ColorOff;
					}
					if (e.Node.Text == "Линия 6 кВ")
					{
						this.method_10("6 кВ");
						this.panelColorSel.BackColor = this.canvasColor.Settings.Line6Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Line6ColorOff;
					}
					if (e.Node.Text == "Линия 0,4 кВ")
					{
						this.method_10("0,4 кВ");
						this.panelColorSel.BackColor = this.canvasColor.Settings.Line04Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Line04ColorOff;
					}
					if (e.Node.Text == "Линия 0,23 кВ")
					{
						this.method_10("0,23 кВ");
						this.panelColorSel.BackColor = this.canvasColor.Settings.Line023Color;
						this.panelColorOffSel.BackColor = this.canvasColor.Settings.Line023ColorOff;
					}
				}
				if (e.Node.Parent != null && e.Node.Parent.Text == "Объекты на линии")
				{
					this.panelColor.Visible = true;
					this.panelColorOff.Visible = false;
					this.panelSelectedColor.Visible = false;
					this.groupBoxGrid.Visible = false;
					this.buttonFont.Visible = true;
					new TextFont();
					this.panelColorOff.Visible = true;
					this.panelColorNormal.Visible = true;
					this.panelColorOffSel.BackColor = this.canvasColor.Settings.ObjectOnLineColorOff;
					this.panelColorNormalSel.BackColor = this.canvasColor.Settings.ObjectOnLineColorOffN;
					this.checkBoxColorLine.Visible = true;
					this.checkBoxColorLine.Checked = this.canvasColor.Settings.ObjectOnLineColorLine;
					this.panelZoomSimply.Visible = true;
					this.numericUpDownZoomSimply.Value = (decimal)(this.canvasColor.Settings.ObjectOnLineZoomSimply * 100f);
					if (this.checkBoxColorLine.Checked)
					{
						this.panelColor.Enabled = false;
					}
					if (e.Node.Text == "Маслянный выключатель")
					{
						this.method_11(TypeSwitch.LubricantSwitchTool);
						this.panelColorSel.BackColor = this.canvasColor.Settings.LubricantSwitchToolColor;
					}
					if (e.Node.Text == "Линейный разъединитель")
					{
						this.method_11(TypeSwitch.LinearDisconnectorTool);
						this.panelColorSel.BackColor = this.canvasColor.Settings.LinearDisconnectorToolColor;
					}
					if (e.Node.Text == "Выключатель нагрузки")
					{
						this.method_11(TypeSwitch.LoadSwitchTool);
						this.panelColorSel.BackColor = this.canvasColor.Settings.LoadSwitchToolColor;
					}
					if (e.Node.Text == "Трансформатор")
					{
						this.method_11(TypeSwitch.TransformerTool);
						this.panelColorSel.BackColor = this.canvasColor.Settings.TransformerToolColor;
					}
					if (e.Node.Text == "Вакуумный выключатель")
					{
						this.method_11(TypeSwitch.VacuumSwitchTool);
						this.panelColorSel.BackColor = this.canvasColor.Settings.VacuumSwitchToolColor;
					}
					if (e.Node.Text == "Наружный линейный разъединитель")
					{
						this.method_11(TypeSwitch.OutsideLineDisconnectorTool);
						this.panelColorSel.BackColor = this.canvasColor.Settings.OutsideLineDisconnectorToolColor;
					}
					if (e.Node.Text == "Концевая разделка")
					{
						this.method_11(TypeSwitch.EndTrimTool);
						this.panelColorSel.BackColor = this.canvasColor.Settings.EndTrimToolColor;
					}
					if (e.Node.Text == "Текст")
					{
						this.buttonFont.Visible = true;
						this.method_12();
						this.panelColorSel.BackColor = this.canvasColor.Settings.TextBranchColor;
						TextFont textPropertyTextBranch = this.canvasColor.Settings.TextPropertyTextBranch;
					}
					if (e.Node.Text == "Перенос нагрузки")
					{
						this.method_11(TypeSwitch.ArrowTool);
						this.panelColorSel.BackColor = this.canvasColor.Settings.ArrowToolColor;
						this.panelColor.Enabled = true;
						this.panelColorOff.Visible = false;
						this.panelSelectedColor.Visible = false;
						this.groupBoxGrid.Visible = false;
						this.buttonFont.Visible = false;
						this.panelColorNormal.Visible = false;
						this.checkBoxColorLine.Visible = false;
						this.panelZoomSimply.Visible = false;
					}
					if (e.Node.Text == "Заземление")
					{
						this.method_11(TypeSwitch.GroundingTool);
						this.panelColorSel.BackColor = this.canvasColor.Settings.GroundingToolColor;
						this.panelColor.Enabled = !(this.checkBoxColorLine.Checked = this.canvasColor.Settings.GroundingToolColorLine);
					}
					if (e.Node.Text == "Повреждение кабеля")
					{
						this.method_11(TypeSwitch.DamageTool);
						this.panelColorSel.BackColor = this.canvasColor.Settings.DamageToolColor;
						this.panelColor.Enabled = !(this.checkBoxColorLine.Checked = this.canvasColor.Settings.DamageToolColorLine);
					}
					if (e.Node.Text == "Отключение кабеля")
					{
						this.method_11(TypeSwitch.OffTool);
						this.panelColorSel.BackColor = this.canvasColor.Settings.OffToolColor;
						this.panelColor.Enabled = !(this.checkBoxColorLine.Checked = this.canvasColor.Settings.OffToolColorLine);
					}
					if (e.Node.Text == "Несфазировано")
					{
						this.method_11(TypeSwitch.NotPhasedTool);
						this.panelColorSel.BackColor = this.canvasColor.Settings.NoPhasedToolColor;
						this.panelColor.Enabled = !(this.checkBoxColorLine.Checked = this.canvasColor.Settings.NoPhasedToolColorLine);
					}
					this.fontDialog_0.Font = this.canvasColor.Settings.TextPropertyObjectInLine.Font;
					this.fontDialog_0.Color = this.canvasColor.Settings.TextPropertyObjectInLine.Color;
				}
				if (e.Node.Level == 2 && e.Node.Parent.Parent.Text == "Объекты на линии")
				{
					this.panelColor.Visible = true;
					this.method_11(TypeSwitch.LubricantSwitchTool);
					if (e.Node.Text == "Спец. замок")
					{
						this.panelColorSel.BackColor = this.canvasColor.Settings.ObjectOnLineKeyStateColor;
					}
					if (e.Node.Text == "Повреждение")
					{
						this.panelColorSel.BackColor = this.canvasColor.Settings.ObjectOnLineDamageStateColor;
					}
				}
				if (e.Node.Parent != null && e.Node.Parent.Text == "Обозначения")
				{
					Control control13 = this.panelColor;
					this.panelColor.Enabled = false;
					control13.Visible = false;
					this.panelColorOff.Visible = false;
					this.panelSelectedColor.Visible = false;
					this.groupBoxGrid.Visible = false;
					this.buttonFont.Visible = true;
					this.checkBoxColorLine.Visible = false;
					TextFont textFont4 = new TextFont("Arial", 8.5f, false, false, false, ePositionText.None, false, false, Color.White);
					if (e.Node.Text == "АВР")
					{
						this.method_7(typeof(AutomaticEntryProvisionTool));
						textFont4 = this.canvasColor.Settings.TextPropertyAutomaticEntryProvision;
					}
					if (e.Node.Text == "Спец. замок")
					{
						this.method_7(typeof(SpecialLockingTool));
						textFont4 = this.canvasColor.Settings.TextPropertySpecialLocking;
					}
					if (e.Node.Text == "ТМ")
					{
						this.method_7(typeof(TelemechanicsTool));
						textFont4 = this.canvasColor.Settings.TextPropertyTelemechanics;
					}
					if (e.Node.Text == "ТМ-Охрана")
					{
						this.method_7(typeof(TelemechanicsProtectionTool));
						textFont4 = this.canvasColor.Settings.TextPropertyTelemechanicsProtection;
					}
					if (e.Node.Text == "Ответсвенный абонент")
					{
						this.method_7(typeof(ResponsibleAbonentTool));
						textFont4 = this.canvasColor.Settings.TextPropertyResponsibleAbonentTool;
					}
					if (e.Node.Text == "Примечание")
					{
						this.method_7(typeof(NodeTool));
						this.panelColorSel.BackColor = this.canvasColor.Settings.NodeToolColor;
						Control control14 = this.panelColor;
						this.panelColor.Enabled = true;
						control14.Visible = true;
						this.buttonFont.Visible = false;
					}
					FontStyle fontStyle4 = FontStyle.Regular;
					if (textFont4.FontBold)
					{
						fontStyle4 = FontStyle.Bold;
					}
					if (textFont4.FontItalic)
					{
						fontStyle4 |= FontStyle.Italic;
					}
					if (textFont4.FontUnderline)
					{
						fontStyle4 |= FontStyle.Underline;
					}
					this.fontDialog_0.Font = new Font(textFont4.FontName, textFont4.FontSize, fontStyle4, GraphicsUnit.Pixel);
					this.fontDialog_0.Color = textFont4.Color;
				}
				if (e.Node.Text == "Качество изображения")
				{
					Control control15 = this.panelColor;
					this.panelColor.Enabled = false;
					control15.Visible = false;
					this.panelColorOff.Visible = false;
					this.panelSelectedColor.Visible = false;
					this.panelColorOffSel.Visible = false;
					this.groupBoxGrid.Visible = false;
					this.buttonFont.Visible = false;
					this.checkBoxColorLine.Visible = false;
					this.cmbQualityImage.Visible = true;
					if (this.canvasColor.Settings.QualityImage == SmoothingMode.HighSpeed)
					{
						this.cmbQualityImage.SelectedIndex = 0;
					}
					else
					{
						this.cmbQualityImage.SelectedIndex = 1;
					}
					this.method_6(eTypeRectangleTool.TP);
					this.method_8(eTypeShinaTool.Shina_10);
				}
				else
				{
					this.cmbQualityImage.Visible = false;
				}
				this.checkBoxColorLine.CheckedChanged += this.checkBoxColorLine_CheckedChanged;
				this.canvasColor.DoInvalidate(true);
			}
		}

		private void panelColorSel_MouseClick(object sender, MouseEventArgs e)
		{
			this.colorDialog_0.Color = ((Panel)sender).BackColor;
			if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
			{
				((Panel)sender).BackColor = this.colorDialog_0.Color;
				if (this.treeViewColors.SelectedNode.Text == "Фон")
				{
					this.canvasColor.Settings.BackgroundColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Сетка")
				{
					this.canvasColor.Settings.GridColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Выделенные объекты")
				{
					this.canvasColor.Settings.SelectedObjColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Отмеченные объекты")
				{
					this.canvasColor.Settings.MarkedObjColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Мерцающие объекты")
				{
					this.canvasColor.Settings.BackFlashingColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "ЦП")
				{
					this.canvasColor.Settings.RectangleCPColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "РП")
				{
					this.canvasColor.Settings.RectangleRPColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "ТП")
				{
					this.canvasColor.Settings.RectangleTPColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "ПП")
				{
					this.canvasColor.Settings.RectanglePPColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "СП")
				{
					this.canvasColor.Settings.RectangleSPColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "ППНО")
				{
					this.canvasColor.Settings.RectanglePPNOColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 110 кВ")
				{
					this.canvasColor.Settings.Shina110Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 35 кВ")
				{
					this.canvasColor.Settings.Shina35Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 10 кВ")
				{
					this.canvasColor.Settings.Shina10Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 6 кВ")
				{
					this.canvasColor.Settings.Shina6Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 0,4 кВ")
				{
					this.canvasColor.Settings.Shina04Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 0,23 кВ")
				{
					this.canvasColor.Settings.Shina023Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 110 кВ")
				{
					this.canvasColor.Settings.Cell110Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 35 кВ")
				{
					this.canvasColor.Settings.Cell35Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 10 кВ")
				{
					this.canvasColor.Settings.Cell10Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 6 кВ")
				{
					this.canvasColor.Settings.Cell6Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 0,4 кВ")
				{
					this.canvasColor.Settings.Cell04Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 0,23 кВ")
				{
					this.canvasColor.Settings.Cell023Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линия 110 кВ")
				{
					this.canvasColor.Settings.Line110Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линия 35 кВ")
				{
					this.canvasColor.Settings.Line35Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линия 10 кВ")
				{
					this.canvasColor.Settings.Line10Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линия 6 кВ")
				{
					this.canvasColor.Settings.Line6Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линия 0,4 кВ")
				{
					this.canvasColor.Settings.Line04Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линия 0,23 кВ")
				{
					this.canvasColor.Settings.Line023Color = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Маслянный выключатель")
				{
					this.canvasColor.Settings.LubricantSwitchToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линейный разъединитель")
				{
					this.canvasColor.Settings.LinearDisconnectorToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Выключатель нагрузки")
				{
					this.canvasColor.Settings.LoadSwitchToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Заземление")
				{
					this.canvasColor.Settings.GroundingToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Трансформатор")
				{
					this.canvasColor.Settings.TransformerToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Повреждение кабеля")
				{
					this.canvasColor.Settings.DamageToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Вакуумный выключатель")
				{
					this.canvasColor.Settings.VacuumSwitchToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Наружный линейный разъединитель")
				{
					this.canvasColor.Settings.OutsideLineDisconnectorToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Концевая разделка")
				{
					this.canvasColor.Settings.EndTrimToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Текст")
				{
					this.canvasColor.Settings.TextBranchColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Перенос нагрузки")
				{
					this.canvasColor.Settings.ArrowToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Отключение кабеля")
				{
					this.canvasColor.Settings.OffToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Несфазировано")
				{
					this.canvasColor.Settings.NoPhasedToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode != null && this.treeViewColors.SelectedNode.Parent != null && this.treeViewColors.SelectedNode.Parent.Text == "Обозначения" && this.treeViewColors.SelectedNode.Text == "Примечание")
				{
					this.canvasColor.Settings.NodeToolColor = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Level == 2 && this.treeViewColors.SelectedNode.Parent.Parent.Text == "Объекты на линии")
				{
					if (this.treeViewColors.SelectedNode.Text == "Спец. замок")
					{
						this.canvasColor.Settings.ObjectOnLineKeyStateColor = ((Panel)sender).BackColor;
					}
					if (this.treeViewColors.SelectedNode.Text == "Повреждение")
					{
						this.canvasColor.Settings.ObjectOnLineDamageStateColor = ((Panel)sender).BackColor;
					}
				}
				this.canvasColor.DoInvalidate(true);
			}
		}

		private void panelColorOffSel_MouseClick(object sender, MouseEventArgs e)
		{
			this.colorDialog_0.Color = ((Panel)sender).BackColor;
			if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
			{
				((Panel)sender).BackColor = this.colorDialog_0.Color;
				if (this.treeViewColors.SelectedNode.Text == "Шина 110 кВ")
				{
					this.canvasColor.Settings.Shina110ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 35 кВ")
				{
					this.canvasColor.Settings.Shina35ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 10 кВ")
				{
					this.canvasColor.Settings.Shina10ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 6 кВ")
				{
					this.canvasColor.Settings.Shina6ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 0,4 кВ")
				{
					this.canvasColor.Settings.Shina04ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 0,23 кВ")
				{
					this.canvasColor.Settings.Shina023ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 110 кВ")
				{
					this.canvasColor.Settings.Cell110ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 35 кВ")
				{
					this.canvasColor.Settings.Cell35ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 10 кВ")
				{
					this.canvasColor.Settings.Cell10ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 6 кВ")
				{
					this.canvasColor.Settings.Cell6ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 0,4 кВ")
				{
					this.canvasColor.Settings.Cell04ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 0,23 кВ")
				{
					this.canvasColor.Settings.Cell023ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линия 110 кВ")
				{
					this.canvasColor.Settings.Line110ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линия 35 кВ")
				{
					this.canvasColor.Settings.Line35ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линия 10 кВ")
				{
					this.canvasColor.Settings.Line10ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линия 6 кВ")
				{
					this.canvasColor.Settings.Line6ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линия 0,4 кВ")
				{
					this.canvasColor.Settings.Line04ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Text == "Линия 0,23 кВ")
				{
					this.canvasColor.Settings.Line023ColorOff = ((Panel)sender).BackColor;
				}
				if (this.treeViewColors.SelectedNode.Parent != null && this.treeViewColors.SelectedNode.Parent.Text == "Объекты на линии")
				{
					this.canvasColor.Settings.ObjectOnLineColorOff = ((Panel)sender).BackColor;
				}
				this.canvasColor.DoInvalidate(true);
			}
		}

		private void panelColorNormalSel_MouseClick(object sender, MouseEventArgs e)
		{
			this.colorDialog_0.Color = ((Panel)sender).BackColor;
			if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
			{
				((Panel)sender).BackColor = this.colorDialog_0.Color;
				if (this.treeViewColors.SelectedNode.Parent != null && this.treeViewColors.SelectedNode.Parent.Text == "Объекты на линии")
				{
					this.canvasColor.Settings.ObjectOnLineColorOffN = ((Panel)sender).BackColor;
				}
				this.canvasColor.DoInvalidate(true);
			}
		}

		private void buttonFont_Click(object sender, EventArgs e)
		{
			if (this.fontDialog_0.ShowDialog() == DialogResult.OK)
			{
				Font font = this.fontDialog_0.Font;
				if (this.treeViewColors.SelectedNode.Text == "ЦП")
				{
					this.canvasColor.Settings.TextPropertyCP = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "ТП")
				{
					this.canvasColor.Settings.TextPropertyTP = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "РП")
				{
					this.canvasColor.Settings.TextPropertyRP = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "ПП")
				{
					this.canvasColor.Settings.TextPropertyPP = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "СП")
				{
					this.canvasColor.Settings.TextPropertySP = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "ППНО")
				{
					this.canvasColor.Settings.TextPropertyPPNO = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 110 кВ")
				{
					this.canvasColor.Settings.TextPropertyShina110 = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 35 кВ")
				{
					this.canvasColor.Settings.TextPropertyShina35 = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 10 кВ")
				{
					this.canvasColor.Settings.TextPropertyShina10 = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 6 кВ")
				{
					this.canvasColor.Settings.TextPropertyShina6 = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 0,4 кВ")
				{
					this.canvasColor.Settings.TextPropertyShina04 = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Шина 0,23 кВ")
				{
					this.canvasColor.Settings.TextPropertyShina023 = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 110 кВ")
				{
					this.canvasColor.Settings.TextPropertyCell110 = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 35 кВ")
				{
					this.canvasColor.Settings.TextPropertyCell35 = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 10 кВ")
				{
					this.canvasColor.Settings.TextPropertyCell10 = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 6 кВ")
				{
					this.canvasColor.Settings.TextPropertyCell6 = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 0,4 кВ")
				{
					this.canvasColor.Settings.TextPropertyCell04 = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Ячейка 0,23 кВ")
				{
					this.canvasColor.Settings.TextPropertyCell023 = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Текст")
				{
					this.canvasColor.Settings.TextPropertyTextBranch = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Text == "Маслянный выключатель" || this.treeViewColors.SelectedNode.Text == "Линейный разъединитель" || this.treeViewColors.SelectedNode.Text == "Выключатель нагрузки" || this.treeViewColors.SelectedNode.Text == "Заземление" || this.treeViewColors.SelectedNode.Text == "Трансформатор" || this.treeViewColors.SelectedNode.Text == "Повреждение кабеля" || this.treeViewColors.SelectedNode.Text == "Вакуумный выключатель" || this.treeViewColors.SelectedNode.Text == "Наружный линейный разъединитель" || this.treeViewColors.SelectedNode.Text == "Концевая разделка")
				{
					this.canvasColor.Settings.TextPropertyObjectInLine = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
				}
				if (this.treeViewColors.SelectedNode.Parent != null && this.treeViewColors.SelectedNode.Parent.Text == "Обозначения")
				{
					if (this.treeViewColors.SelectedNode.Text == "АВР")
					{
						this.canvasColor.Settings.TextPropertyAutomaticEntryProvision = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
					}
					if (this.treeViewColors.SelectedNode.Text == "Спец. замок")
					{
						this.canvasColor.Settings.TextPropertySpecialLocking = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
					}
					if (this.treeViewColors.SelectedNode.Text == "ТМ")
					{
						this.canvasColor.Settings.TextPropertyTelemechanics = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
					}
					if (this.treeViewColors.SelectedNode.Text == "ТМ-Охрана")
					{
						this.canvasColor.Settings.TextPropertyTelemechanicsProtection = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
					}
					if (this.treeViewColors.SelectedNode.Text == "Ответсвенный абонент")
					{
						this.canvasColor.Settings.TextPropertyResponsibleAbonentTool = new TextFont(font.Name, font.Size, font.Bold, font.Italic, font.Underline, ePositionText.T, false, true, this.fontDialog_0.Color);
					}
				}
				this.canvasColor.DoInvalidate(true);
			}
		}

		private void checkBoxColorLine_CheckedChanged(object sender, EventArgs e)
		{
			this.panelColor.Enabled = !this.checkBoxColorLine.Checked;
			string text = this.treeViewColors.SelectedNode.Text;
			if (!(text == "Заземление"))
			{
				if (!(text == "Повреждение кабеля"))
				{
					if (!(text == "Отключение кабеля"))
					{
						if (!(text == "Несфазировано"))
						{
							this.canvasColor.Settings.ObjectOnLineColorLine = this.checkBoxColorLine.Checked;
						}
						else
						{
							this.canvasColor.Settings.NoPhasedToolColorLine = this.checkBoxColorLine.Checked;
						}
					}
					else
					{
						this.canvasColor.Settings.OffToolColorLine = this.checkBoxColorLine.Checked;
					}
				}
				else
				{
					this.canvasColor.Settings.DamageToolColorLine = this.checkBoxColorLine.Checked;
				}
			}
			else
			{
				this.canvasColor.Settings.GroundingToolColorLine = this.checkBoxColorLine.Checked;
			}
			this.canvasColor.DoInvalidate(true);
		}

		private void cmbQualityImage_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbQualityImage.SelectedIndex == 0)
			{
				this.canvasColor.Settings.QualityImage = SmoothingMode.HighSpeed;
			}
			else
			{
				this.canvasColor.Settings.QualityImage = SmoothingMode.HighQuality;
			}
			this.canvasColor.DoInvalidate(true);
		}

		private void numericUpDownZoomSimply_ValueChanged(object sender, EventArgs e)
		{
			this.canvasColor.Settings.ObjectOnLineZoomSimply = (float)this.numericUpDownZoomSimply.Value / 100f;
		}

		private void numericUpDownFontNoVisible_ValueChanged(object sender, EventArgs e)
		{
			this.canvasColor.Settings.FontSizeNoVisible = (float)this.numericUpDownFontNoVisible.Value;
		}

		private void radioButtonDots_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButtonDots.Checked)
			{
				this.canvasColor.Settings.GridVisible = true;
				this.canvasColor.Settings.GridStyle = GridLayer.eGridStyle.Dots;
			}
			this.canvasColor.DoInvalidate(true);
		}

		private void radioButtonNoVisibleGrid_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButtonNoVisibleGrid.Checked)
			{
				this.canvasColor.Settings.GridVisible = false;
			}
			this.canvasColor.DoInvalidate(true);
		}

		private void radioButtonLine_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButtonLine.Checked)
			{
				this.canvasColor.Settings.GridVisible = true;
				this.canvasColor.Settings.GridStyle = GridLayer.eGridStyle.Lines;
			}
			this.canvasColor.DoInvalidate(true);
		}

		private void radioButtonGeneral_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButtonGeneral.Checked)
			{
				this.canvasColor.Settings.UseDefaultSettings = true;
				this.canvasColor.Settings.DocUser = this.canvasColor.Settings.SaveToXmlDocument();
				this.canvasColor.Settings.LoadSchemeFromXML(this.canvasColor.Settings.DocDefault);
			}
			else
			{
				this.canvasColor.Settings.DocDefault = this.canvasColor.Settings.SaveToXmlDocument();
				this.canvasColor.Settings.LoadSchemeFromXML(this.canvasColor.Settings.DocUser);
				this.canvasColor.Settings.UseDefaultSettings = false;
			}
			this.canvasColor.DoInvalidate(true);
		}

		private void method_4()
		{
			RectangleTool rectangleTool = new RectangleTool();
			rectangleTool.Rectangle = new RectangleF(-3f, -3f, 6f, 6f);
			rectangleTool.TypeRectnagleTool = eTypeRectangleTool.CP;
			rectangleTool.Text = "пример";
			rectangleTool.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(rectangleTool);
			rectangleTool = new RectangleTool();
			rectangleTool.Rectangle = new RectangleF(-3f, -3f, 6f, 6f);
			rectangleTool.TypeRectnagleTool = eTypeRectangleTool.PP;
			rectangleTool.Text = "пример";
			rectangleTool.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(rectangleTool);
			rectangleTool = new RectangleTool();
			rectangleTool.Rectangle = new RectangleF(-3f, -3f, 6f, 6f);
			rectangleTool.TypeRectnagleTool = eTypeRectangleTool.RP;
			rectangleTool.Text = "пример";
			rectangleTool.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(rectangleTool);
			rectangleTool = new RectangleTool();
			rectangleTool.Rectangle = new RectangleF(-3f, -3f, 6f, 6f);
			rectangleTool.TypeRectnagleTool = eTypeRectangleTool.TP;
			rectangleTool.Text = "пример";
			rectangleTool.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(rectangleTool);
			rectangleTool = new RectangleTool();
			rectangleTool.Rectangle = new RectangleF(-3f, -3f, 6f, 6f);
			rectangleTool.TypeRectnagleTool = eTypeRectangleTool.SP;
			rectangleTool.Text = "пример";
			rectangleTool.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(rectangleTool);
			rectangleTool = new RectangleTool();
			rectangleTool.Rectangle = new RectangleF(-3f, -3f, 6f, 6f);
			rectangleTool.TypeRectnagleTool = eTypeRectangleTool.PPNO;
			rectangleTool.Text = "пример";
			rectangleTool.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(rectangleTool);
			ShinaTool shinaTool = new ShinaTool();
			shinaTool.P1 = new UnitPoint(-3.0, 1.0);
			shinaTool.P2 = new UnitPoint(3.0, 1.0);
			shinaTool.TypeShinaTool = eTypeShinaTool.Shina_110;
			shinaTool.Text = "1";
			shinaTool.TextProperty.Visible = true;
			shinaTool.TextVoltProperty.Visible = true;
			shinaTool.Amperage = new Amperage(shinaTool, shinaTool, new AmperageProperties(), null);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(shinaTool);
			shinaTool = new ShinaTool();
			shinaTool.P1 = new UnitPoint(-3.0, -1.0);
			shinaTool.P2 = new UnitPoint(3.0, -1.0);
			shinaTool.TypeShinaTool = eTypeShinaTool.Shina_110;
			shinaTool.Text = "1";
			shinaTool.TextProperty.Visible = true;
			shinaTool.TextVoltProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(shinaTool);
			shinaTool = new ShinaTool();
			shinaTool.P1 = new UnitPoint(-3.0, 1.0);
			shinaTool.P2 = new UnitPoint(3.0, 1.0);
			shinaTool.TypeShinaTool = eTypeShinaTool.Shina_35;
			shinaTool.Text = "1";
			shinaTool.TextProperty.Visible = true;
			shinaTool.TextVoltProperty.Visible = true;
			shinaTool.Amperage = new Amperage(shinaTool, shinaTool, new AmperageProperties(), null);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(shinaTool);
			shinaTool = new ShinaTool();
			shinaTool.P1 = new UnitPoint(-3.0, -1.0);
			shinaTool.P2 = new UnitPoint(3.0, -1.0);
			shinaTool.TypeShinaTool = eTypeShinaTool.Shina_35;
			shinaTool.Text = "1";
			shinaTool.TextProperty.Visible = true;
			shinaTool.TextVoltProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(shinaTool);
			shinaTool = new ShinaTool();
			shinaTool.P1 = new UnitPoint(-3.0, 1.0);
			shinaTool.P2 = new UnitPoint(3.0, 1.0);
			shinaTool.TypeShinaTool = eTypeShinaTool.Shina_10;
			shinaTool.Text = "1";
			shinaTool.TextProperty.Visible = true;
			shinaTool.TextVoltProperty.Visible = true;
			shinaTool.Amperage = new Amperage(shinaTool, shinaTool, new AmperageProperties(), null);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(shinaTool);
			shinaTool = new ShinaTool();
			shinaTool.P1 = new UnitPoint(-3.0, -1.0);
			shinaTool.P2 = new UnitPoint(3.0, -1.0);
			shinaTool.TypeShinaTool = eTypeShinaTool.Shina_10;
			shinaTool.Text = "1";
			shinaTool.TextProperty.Visible = true;
			shinaTool.TextVoltProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(shinaTool);
			shinaTool = new ShinaTool();
			shinaTool.P1 = new UnitPoint(-3.0, 1.0);
			shinaTool.P2 = new UnitPoint(3.0, 1.0);
			shinaTool.TypeShinaTool = eTypeShinaTool.Shina_6;
			shinaTool.Text = "1";
			shinaTool.TextProperty.Visible = true;
			shinaTool.TextVoltProperty.Visible = true;
			shinaTool.Amperage = new Amperage(shinaTool, shinaTool, new AmperageProperties(), null);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(shinaTool);
			shinaTool = new ShinaTool();
			shinaTool.P1 = new UnitPoint(-3.0, -1.0);
			shinaTool.P2 = new UnitPoint(3.0, -1.0);
			shinaTool.TypeShinaTool = eTypeShinaTool.Shina_6;
			shinaTool.Text = "1";
			shinaTool.TextProperty.Visible = true;
			shinaTool.TextVoltProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(shinaTool);
			shinaTool = new ShinaTool();
			shinaTool.P1 = new UnitPoint(-3.0, 1.0);
			shinaTool.P2 = new UnitPoint(3.0, 1.0);
			shinaTool.TypeShinaTool = eTypeShinaTool.Shina_04;
			shinaTool.Text = "1";
			shinaTool.TextProperty.Visible = true;
			shinaTool.TextVoltProperty.Visible = true;
			shinaTool.Amperage = new Amperage(shinaTool, shinaTool, new AmperageProperties(), null);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(shinaTool);
			shinaTool = new ShinaTool();
			shinaTool.P1 = new UnitPoint(-3.0, -1.0);
			shinaTool.P2 = new UnitPoint(3.0, -1.0);
			shinaTool.TypeShinaTool = eTypeShinaTool.Shina_04;
			shinaTool.Text = "1";
			shinaTool.TextProperty.Visible = true;
			shinaTool.TextVoltProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(shinaTool);
			shinaTool = new ShinaTool();
			shinaTool.P1 = new UnitPoint(-3.0, 1.0);
			shinaTool.P2 = new UnitPoint(3.0, 1.0);
			shinaTool.TypeShinaTool = eTypeShinaTool.Shina_023;
			shinaTool.Text = "1";
			shinaTool.TextProperty.Visible = true;
			shinaTool.TextVoltProperty.Visible = true;
			shinaTool.Amperage = new Amperage(shinaTool, shinaTool, new AmperageProperties(), null);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(shinaTool);
			shinaTool = new ShinaTool();
			shinaTool.P1 = new UnitPoint(-3.0, -1.0);
			shinaTool.P2 = new UnitPoint(3.0, -1.0);
			shinaTool.TypeShinaTool = eTypeShinaTool.Shina_023;
			shinaTool.Text = "1";
			shinaTool.TextProperty.Visible = true;
			shinaTool.TextVoltProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(shinaTool);
			ShinaTool shinaTool2 = new ShinaTool();
			shinaTool2.P1 = new UnitPoint(-3.0, 1.0);
			shinaTool2.P2 = new UnitPoint(3.0, 1.0);
			shinaTool2.TypeShinaTool = eTypeShinaTool.Shina_110;
			shinaTool2.Text = "1";
			shinaTool2.TextProperty.Visible = true;
			shinaTool2.TextVoltProperty.Visible = true;
			PointShinaTool pointShinaTool = new PointShinaTool();
			pointShinaTool.Point = new UnitPoint(-3.0, 1.0);
			shinaTool2.AddPointShinaTool(pointShinaTool);
			LineCellTool lineCellTool = new LineCellTool();
			lineCellTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			PointShinaTool pointShinaTool2 = new PointShinaTool();
			pointShinaTool2.Point = new UnitPoint(3.0, 1.0);
			pointShinaTool2.Text = "110 кВ";
			pointShinaTool2.TextProperty.Visible = true;
			lineCellTool.AddBranch(pointShinaTool, pointShinaTool2);
			lineCellTool.Text = "110 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineCellTool);
			LineTool lineTool = new LineTool();
			lineTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			lineTool.AddBranch(pointShinaTool2, new PointTool(new UnitPoint(-3.0, 1.0)));
			lineTool.Text = "110 кВ";
			shinaTool2.Amperage = new Amperage(shinaTool, shinaTool, new AmperageProperties(), null);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineTool);
			TextBranchTool textBranchTool = new TextBranchTool();
			textBranchTool.Parent = lineTool.Branches[0];
			textBranchTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			textBranchTool.Text = "Текст";
			textBranchTool.Delta = 0.5f;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(textBranchTool);
			LineToolState state = new LineToolState(lineTool.Branches[0], 0.5, States.Arrow);
			lineTool.AddState(state);
			ShinaTool shinaTool3 = new ShinaTool();
			shinaTool3.P1 = new UnitPoint(-3.0, -1.0);
			shinaTool3.P2 = new UnitPoint(3.0, -1.0);
			shinaTool3.TypeShinaTool = eTypeShinaTool.Shina_110;
			shinaTool3.Text = "1";
			shinaTool3.TextProperty.Visible = true;
			shinaTool3.TextVoltProperty.Visible = true;
			PointShinaTool pointShinaTool3 = new PointShinaTool();
			pointShinaTool3.Point = new UnitPoint(-3.0, -1.0);
			shinaTool3.AddPointShinaTool(pointShinaTool3);
			LineCellTool lineCellTool2 = new LineCellTool();
			lineCellTool2.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			PointShinaTool pointShinaTool4 = new PointShinaTool();
			pointShinaTool4.Point = new UnitPoint(3.0, -1.0);
			lineCellTool2.AddBranch(pointShinaTool3, pointShinaTool4);
			lineCellTool2.Text = "110 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineCellTool2);
			LineTool lineTool2 = new LineTool();
			lineTool2.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			lineTool2.AddBranch(pointShinaTool4, new PointTool(new UnitPoint(-3.0, -1.0)));
			lineTool2.Text = "110 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineTool2);
			ObjectOnLine objectOnLine = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LubricantSwitchTool, 0.25);
			objectOnLine.On = true;
			objectOnLine.PositionDamage = ePositionText.RB;
			objectOnLine.PositionKey = ePositionText.LB;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine);
			ObjectOnLine objectOnLine2 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LubricantSwitchTool, 0.5);
			objectOnLine2.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine2);
			ObjectOnLine drawobject = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LubricantSwitchTool, 0.75);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(drawobject);
			ObjectOnLine objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LinearDisconnectorTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LoadSwitchTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.GroundingTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.TransformerTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.DamageTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.VacuumSwitchTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.OutsideLineDisconnectorTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.EndTrimTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.OffTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.NotPhasedTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			ShinaTool shinaTool4 = new ShinaTool();
			shinaTool4.P1 = new UnitPoint(-3.0, 1.0);
			shinaTool4.P2 = new UnitPoint(3.0, 1.0);
			shinaTool4.TypeShinaTool = eTypeShinaTool.Shina_35;
			shinaTool4.Text = "1";
			shinaTool4.TextProperty.Visible = true;
			shinaTool4.TextVoltProperty.Visible = true;
			pointShinaTool = new PointShinaTool();
			pointShinaTool.Point = new UnitPoint(-3.0, 1.0);
			shinaTool4.AddPointShinaTool(pointShinaTool);
			lineCellTool = new LineCellTool();
			lineCellTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			pointShinaTool2 = new PointShinaTool();
			pointShinaTool2.Point = new UnitPoint(3.0, 1.0);
			pointShinaTool2.Text = "35 кВ";
			pointShinaTool2.TextProperty.Visible = true;
			lineCellTool.AddBranch(pointShinaTool, pointShinaTool2);
			lineCellTool.Text = "35 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineCellTool);
			lineTool = new LineTool();
			lineTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			lineTool.AddBranch(pointShinaTool2, new PointTool(new UnitPoint(-3.0, 1.0)));
			lineTool.Text = "35 кВ";
			shinaTool4.Amperage = new Amperage(shinaTool, shinaTool, new AmperageProperties(), null);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineTool);
			textBranchTool = new TextBranchTool();
			textBranchTool.Parent = lineTool.Branches[0];
			textBranchTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			textBranchTool.Text = "Текст";
			textBranchTool.Delta = 0.5f;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(textBranchTool);
			state = new LineToolState(lineTool.Branches[0], 0.5, States.Arrow);
			lineTool.AddState(state);
			ShinaTool shinaTool5 = new ShinaTool();
			shinaTool5.P1 = new UnitPoint(-3.0, -1.0);
			shinaTool5.P2 = new UnitPoint(3.0, -1.0);
			shinaTool5.TypeShinaTool = eTypeShinaTool.Shina_35;
			shinaTool5.Text = "1";
			shinaTool5.TextProperty.Visible = true;
			shinaTool5.TextVoltProperty.Visible = true;
			pointShinaTool3 = new PointShinaTool();
			pointShinaTool3.Point = new UnitPoint(-3.0, -1.0);
			shinaTool5.AddPointShinaTool(pointShinaTool3);
			lineCellTool2 = new LineCellTool();
			lineCellTool2.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			pointShinaTool4 = new PointShinaTool();
			pointShinaTool4.Point = new UnitPoint(3.0, -1.0);
			lineCellTool2.AddBranch(pointShinaTool3, pointShinaTool4);
			lineCellTool2.Text = "35 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineCellTool2);
			lineTool2 = new LineTool();
			lineTool2.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			lineTool2.AddBranch(pointShinaTool4, new PointTool(new UnitPoint(-3.0, -1.0)));
			lineTool2.Text = "35 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineTool2);
			objectOnLine = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LubricantSwitchTool, 0.25);
			objectOnLine.On = true;
			objectOnLine.PositionDamage = ePositionText.RB;
			objectOnLine.PositionKey = ePositionText.LB;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine);
			objectOnLine2 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LubricantSwitchTool, 0.5);
			objectOnLine2.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine2);
			drawobject = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LubricantSwitchTool, 0.75);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(drawobject);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LinearDisconnectorTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LoadSwitchTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.GroundingTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.TransformerTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.DamageTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.VacuumSwitchTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.OutsideLineDisconnectorTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.EndTrimTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.OffTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.NotPhasedTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			ShinaTool shinaTool6 = new ShinaTool();
			shinaTool6.P1 = new UnitPoint(-3.0, 1.0);
			shinaTool6.P2 = new UnitPoint(3.0, 1.0);
			shinaTool6.TypeShinaTool = eTypeShinaTool.Shina_10;
			shinaTool6.Text = "1";
			shinaTool6.TextProperty.Visible = true;
			shinaTool6.TextVoltProperty.Visible = true;
			pointShinaTool = new PointShinaTool();
			pointShinaTool.Point = new UnitPoint(-3.0, 1.0);
			shinaTool6.AddPointShinaTool(pointShinaTool);
			lineCellTool = new LineCellTool();
			lineCellTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			pointShinaTool2 = new PointShinaTool();
			pointShinaTool2.Point = new UnitPoint(3.0, 1.0);
			pointShinaTool2.Text = "10 кВ";
			pointShinaTool2.TextProperty.Visible = true;
			lineCellTool.AddBranch(pointShinaTool, pointShinaTool2);
			lineCellTool.Text = "10 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineCellTool);
			lineTool = new LineTool();
			lineTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			lineTool.AddBranch(pointShinaTool2, new PointTool(new UnitPoint(-3.0, 1.0)));
			lineTool.Text = "10 кВ";
			shinaTool6.Amperage = new Amperage(shinaTool, shinaTool, new AmperageProperties(), null);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineTool);
			textBranchTool = new TextBranchTool();
			textBranchTool.Parent = lineTool.Branches[0];
			textBranchTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			textBranchTool.Text = "Текст";
			textBranchTool.Delta = 0.5f;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(textBranchTool);
			state = new LineToolState(lineTool.Branches[0], 0.5, States.Arrow);
			lineTool.AddState(state);
			ShinaTool shinaTool7 = new ShinaTool();
			shinaTool7.P1 = new UnitPoint(-3.0, -1.0);
			shinaTool7.P2 = new UnitPoint(3.0, -1.0);
			shinaTool7.TypeShinaTool = eTypeShinaTool.Shina_10;
			shinaTool7.Text = "1";
			shinaTool7.TextProperty.Visible = true;
			shinaTool7.TextVoltProperty.Visible = true;
			pointShinaTool3 = new PointShinaTool();
			pointShinaTool3.Point = new UnitPoint(-3.0, -1.0);
			shinaTool7.AddPointShinaTool(pointShinaTool3);
			lineCellTool2 = new LineCellTool();
			lineCellTool2.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			pointShinaTool4 = new PointShinaTool();
			pointShinaTool4.Point = new UnitPoint(3.0, -1.0);
			lineCellTool2.AddBranch(pointShinaTool3, pointShinaTool4);
			lineCellTool2.Text = "10 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineCellTool2);
			lineTool2 = new LineTool();
			lineTool2.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			lineTool2.AddBranch(pointShinaTool4, new PointTool(new UnitPoint(-3.0, -1.0)));
			lineTool2.Text = "10 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineTool2);
			objectOnLine = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LubricantSwitchTool, 0.25);
			objectOnLine.On = true;
			objectOnLine.PositionDamage = ePositionText.RB;
			objectOnLine.PositionKey = ePositionText.LB;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine);
			objectOnLine2 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LubricantSwitchTool, 0.5);
			objectOnLine2.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine2);
			drawobject = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LubricantSwitchTool, 0.75);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(drawobject);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LinearDisconnectorTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.LoadSwitchTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.GroundingTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.TransformerTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.DamageTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.VacuumSwitchTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.OutsideLineDisconnectorTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.EndTrimTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.OffTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			objectOnLine3 = lineTool2.Branches[0].AddSwitchTool(TypeSwitch.NotPhasedTool, 0.5);
			objectOnLine3.TextProperty.Visible = true;
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(objectOnLine3);
			ShinaTool shinaTool8 = new ShinaTool();
			shinaTool8.P1 = new UnitPoint(-3.0, 1.0);
			shinaTool8.P2 = new UnitPoint(3.0, 1.0);
			shinaTool8.TypeShinaTool = eTypeShinaTool.Shina_6;
			shinaTool8.Text = "1";
			shinaTool8.TextProperty.Visible = true;
			shinaTool8.TextVoltProperty.Visible = true;
			pointShinaTool = new PointShinaTool();
			pointShinaTool.Point = new UnitPoint(-3.0, 1.0);
			shinaTool8.AddPointShinaTool(pointShinaTool);
			lineCellTool = new LineCellTool();
			lineCellTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			pointShinaTool2 = new PointShinaTool();
			pointShinaTool2.Point = new UnitPoint(3.0, 1.0);
			pointShinaTool2.Text = "6 кВ";
			pointShinaTool2.TextProperty.Visible = true;
			lineCellTool.AddBranch(pointShinaTool, pointShinaTool2);
			lineCellTool.Text = "6 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineCellTool);
			lineTool = new LineTool();
			lineTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			lineTool.AddBranch(pointShinaTool2, new PointTool(new UnitPoint(-3.0, 1.0)));
			lineTool.Text = "6 кВ";
			shinaTool8.Amperage = new Amperage(shinaTool, shinaTool, new AmperageProperties(), null);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineTool);
			ShinaTool shinaTool9 = new ShinaTool();
			shinaTool9.P1 = new UnitPoint(-3.0, -1.0);
			shinaTool9.P2 = new UnitPoint(3.0, -1.0);
			shinaTool9.TypeShinaTool = eTypeShinaTool.Shina_6;
			shinaTool9.Text = "1";
			shinaTool9.TextProperty.Visible = true;
			shinaTool9.TextVoltProperty.Visible = true;
			pointShinaTool3 = new PointShinaTool();
			pointShinaTool3.Point = new UnitPoint(-3.0, -1.0);
			shinaTool9.AddPointShinaTool(pointShinaTool3);
			lineCellTool2 = new LineCellTool();
			lineCellTool2.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			pointShinaTool4 = new PointShinaTool();
			pointShinaTool4.Point = new UnitPoint(3.0, -1.0);
			lineCellTool2.AddBranch(pointShinaTool3, pointShinaTool4);
			lineCellTool2.Text = "6 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineCellTool2);
			lineTool2 = new LineTool();
			lineTool2.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			lineTool2.AddBranch(pointShinaTool4, new PointTool(new UnitPoint(-3.0, -1.0)));
			lineTool2.Text = "6 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineTool2);
			ShinaTool shinaTool10 = new ShinaTool();
			shinaTool10.P1 = new UnitPoint(-3.0, 1.0);
			shinaTool10.P2 = new UnitPoint(3.0, 1.0);
			shinaTool10.TypeShinaTool = eTypeShinaTool.Shina_04;
			shinaTool10.Text = "1";
			shinaTool10.TextProperty.Visible = true;
			shinaTool10.TextVoltProperty.Visible = true;
			pointShinaTool = new PointShinaTool();
			pointShinaTool.Point = new UnitPoint(-3.0, 1.0);
			shinaTool10.AddPointShinaTool(pointShinaTool);
			lineCellTool = new LineCellTool();
			lineCellTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			pointShinaTool2 = new PointShinaTool();
			pointShinaTool2.Point = new UnitPoint(3.0, 1.0);
			pointShinaTool2.Text = "0,4 кВ";
			pointShinaTool2.TextProperty.Visible = true;
			lineCellTool.AddBranch(pointShinaTool, pointShinaTool2);
			lineCellTool.Text = "0,4 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineCellTool);
			lineTool = new LineTool();
			lineTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			lineTool.AddBranch(pointShinaTool2, new PointTool(new UnitPoint(-3.0, 1.0)));
			lineTool.Text = "0,4 кВ";
			shinaTool10.Amperage = new Amperage(shinaTool, shinaTool, new AmperageProperties(), null);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineTool);
			ShinaTool shinaTool11 = new ShinaTool();
			shinaTool11.P1 = new UnitPoint(-3.0, -1.0);
			shinaTool11.P2 = new UnitPoint(3.0, -1.0);
			shinaTool11.TypeShinaTool = eTypeShinaTool.Shina_04;
			shinaTool11.Text = "1";
			shinaTool11.TextProperty.Visible = true;
			shinaTool11.TextVoltProperty.Visible = true;
			pointShinaTool3 = new PointShinaTool();
			pointShinaTool3.Point = new UnitPoint(-3.0, -1.0);
			shinaTool11.AddPointShinaTool(pointShinaTool3);
			lineCellTool2 = new LineCellTool();
			lineCellTool2.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			pointShinaTool4 = new PointShinaTool();
			pointShinaTool4.Point = new UnitPoint(3.0, -1.0);
			lineCellTool2.AddBranch(pointShinaTool3, pointShinaTool4);
			lineCellTool2.Text = "0,4 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineCellTool2);
			lineTool2 = new LineTool();
			lineTool2.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			lineTool2.AddBranch(pointShinaTool4, new PointTool(new UnitPoint(-3.0, -1.0)));
			lineTool2.Text = "0,4 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineTool2);
			ShinaTool shinaTool12 = new ShinaTool();
			shinaTool12.P1 = new UnitPoint(-3.0, 1.0);
			shinaTool12.P2 = new UnitPoint(3.0, 1.0);
			shinaTool12.TypeShinaTool = eTypeShinaTool.Shina_023;
			shinaTool12.Text = "1";
			shinaTool12.TextProperty.Visible = true;
			shinaTool12.TextVoltProperty.Visible = true;
			pointShinaTool = new PointShinaTool();
			pointShinaTool.Point = new UnitPoint(-3.0, 1.0);
			shinaTool12.AddPointShinaTool(pointShinaTool);
			lineCellTool = new LineCellTool();
			lineCellTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			pointShinaTool2 = new PointShinaTool();
			pointShinaTool2.Point = new UnitPoint(3.0, 1.0);
			pointShinaTool2.Text = "0,23 кВ";
			pointShinaTool2.TextProperty.Visible = true;
			lineCellTool.AddBranch(pointShinaTool, pointShinaTool2);
			lineCellTool.Text = "0,23 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineCellTool);
			lineTool = new LineTool();
			lineTool.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			lineTool.AddBranch(pointShinaTool2, new PointTool(new UnitPoint(-3.0, 1.0)));
			lineTool.Text = "0,23 кВ";
			shinaTool12.Amperage = new Amperage(shinaTool, shinaTool, new AmperageProperties(), null);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineTool);
			ShinaTool shinaTool13 = new ShinaTool();
			shinaTool13.P1 = new UnitPoint(-3.0, -1.0);
			shinaTool13.P2 = new UnitPoint(3.0, -1.0);
			shinaTool13.TypeShinaTool = eTypeShinaTool.Shina_023;
			shinaTool13.Text = "1";
			shinaTool13.TextProperty.Visible = true;
			shinaTool13.TextVoltProperty.Visible = true;
			pointShinaTool3 = new PointShinaTool();
			pointShinaTool3.Point = new UnitPoint(-3.0, -1.0);
			shinaTool13.AddPointShinaTool(pointShinaTool3);
			lineCellTool2 = new LineCellTool();
			lineCellTool2.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			pointShinaTool4 = new PointShinaTool();
			pointShinaTool4.Point = new UnitPoint(3.0, -1.0);
			lineCellTool2.AddBranch(pointShinaTool3, pointShinaTool4);
			lineCellTool2.Text = "0,23 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineCellTool2);
			lineTool2 = new LineTool();
			lineTool2.Layer = (DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>();
			lineTool2.AddBranch(pointShinaTool4, new PointTool(new UnitPoint(-3.0, -1.0)));
			lineTool2.Text = "0,23 кВ";
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(lineTool2);
			SpecialLockingTool specialLockingTool = new SpecialLockingTool();
			specialLockingTool.Parent = rectangleTool;
			specialLockingTool.Location = new UnitPoint(-3.0, -3.0);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(specialLockingTool);
			TelemechanicsTool telemechanicsTool = new TelemechanicsTool();
			telemechanicsTool.Parent = rectangleTool;
			telemechanicsTool.Location = new UnitPoint(-3.0, 3.0);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(telemechanicsTool);
			AutomaticEntryProvisionTool automaticEntryProvisionTool = new AutomaticEntryProvisionTool();
			automaticEntryProvisionTool.Parent = rectangleTool;
			automaticEntryProvisionTool.Location = new UnitPoint(3.0, -3.0);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(automaticEntryProvisionTool);
			TelemechanicsProtectionTool telemechanicsProtectionTool = new TelemechanicsProtectionTool();
			telemechanicsProtectionTool.Parent = rectangleTool;
			telemechanicsProtectionTool.Location = new UnitPoint(3.0, 3.0);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(telemechanicsProtectionTool);
			ResponsibleAbonentTool responsibleAbonentTool = new ResponsibleAbonentTool();
			responsibleAbonentTool.Parent = rectangleTool;
			responsibleAbonentTool.Location = new UnitPoint(0.0, 0.0);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(responsibleAbonentTool);
			NodeTool nodeTool = new NodeTool();
			nodeTool.Text = "Примечание";
			nodeTool.Location = new UnitPoint(0.0, 0.0);
			((DrawingLayer)this.canvasColor.Layers.First<ICanvasLayer>()).AddObject(nodeTool);
		}

		private void method_5()
		{
			foreach (ICanvasLayer canvasLayer in this.canvasColor.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					drawObjectBase.Visible = false;
				}
			}
		}

		private void method_6(eTypeRectangleTool eTypeRectangleTool_0)
		{
			foreach (ICanvasLayer canvasLayer in this.canvasColor.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					if (drawObjectBase.GetType() == typeof(RectangleTool) && ((RectangleTool)drawObjectBase).TypeRectnagleTool == eTypeRectangleTool_0)
					{
						drawObjectBase.Visible = true;
					}
				}
			}
		}

		private void method_7(Type type_0)
		{
			if (type_0 == typeof(NodeTool))
			{
				using (IEnumerator<ICanvasLayer> enumerator = this.canvasColor.Layers.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ICanvasLayer canvasLayer = enumerator.Current;
						foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
						{
							if (drawObjectBase.GetType() == type_0)
							{
								drawObjectBase.Visible = true;
							}
						}
					}
					return;
				}
			}
			foreach (ICanvasLayer canvasLayer2 in this.canvasColor.Layers)
			{
				foreach (DrawObjectBase drawObjectBase2 in canvasLayer2.Objects)
				{
					if (drawObjectBase2.GetType() == typeof(RectangleTool) && ((RectangleTool)drawObjectBase2).TypeRectnagleTool == eTypeRectangleTool.TP)
					{
						drawObjectBase2.Visible = true;
					}
					if (drawObjectBase2.GetType() == type_0)
					{
						drawObjectBase2.Visible = true;
					}
				}
			}
		}

		private void method_8(eTypeShinaTool eTypeShinaTool_0)
		{
			foreach (ICanvasLayer canvasLayer in this.canvasColor.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					if (drawObjectBase.GetType() == typeof(ShinaTool) && ((ShinaTool)drawObjectBase).TypeShinaTool == eTypeShinaTool_0)
					{
						drawObjectBase.Visible = true;
					}
				}
			}
		}

		private void method_9(string string_0)
		{
			foreach (ICanvasLayer canvasLayer in this.canvasColor.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					if (drawObjectBase.GetType() == typeof(LineCellTool) && drawObjectBase.Text == string_0)
					{
						drawObjectBase.Visible = true;
					}
				}
			}
		}

		private void method_10(string string_0)
		{
			foreach (ICanvasLayer canvasLayer in this.canvasColor.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					if (drawObjectBase.GetType() == typeof(LineTool) && drawObjectBase.Text == string_0)
					{
						drawObjectBase.Visible = true;
					}
				}
			}
		}

		private void method_11(TypeSwitch typeSwitch_0)
		{
			foreach (ICanvasLayer canvasLayer in this.canvasColor.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine) && ((ObjectOnLine)drawObjectBase).TypeSwitch == typeSwitch_0)
					{
						drawObjectBase.Visible = true;
						if (drawObjectBase.Parent != null)
						{
							drawObjectBase.Parent.Visible = true;
							if (drawObjectBase.Parent.GetType() == typeof(Branch))
							{
								drawObjectBase.Parent.Parent.Visible = true;
							}
						}
					}
				}
			}
		}

		private void method_12()
		{
			foreach (ICanvasLayer canvasLayer in this.canvasColor.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					if (drawObjectBase.GetType() == typeof(TextBranchTool))
					{
						drawObjectBase.Visible = true;
						if (drawObjectBase.Parent != null)
						{
							drawObjectBase.Parent.Visible = true;
							if (drawObjectBase.Parent.GetType() == typeof(Branch))
							{
								drawObjectBase.Parent.Parent.Visible = true;
							}
						}
					}
				}
			}
		}

		private void method_13()
		{
			this.textBoxIPAddressOPCServer.Text = this.opcconfig_0.IpAddressOPCServer;
			this.textBoxPortOPCServer.Text = this.opcconfig_0.PortOPCServer.ToString();
			this.textBoxServerOPCConfig.Text = this.opcconfig_0.SqlSettings.ServerDB;
			this.textBoxBaseOPCConfig.Text = this.opcconfig_0.SqlSettings.DBName;
			this.checkBoxAutoReconnect.Checked = this.canvasControl_0.OpcClient.AutoReconnect;
			this.textBoxItervalReconnect.Text = this.canvasControl_0.OpcClient.IntervalReconnect.ToString();
		}

		private void method_14()
		{
			SQLSettings sqlsettings = new SQLSettings(this.textBoxServerOPCConfig.Text, this.textBoxBaseOPCConfig.Text, this.canvasControl_0.SqlSettings.Autentification, this.canvasControl_0.SqlSettings.SqlUserConnect, this.canvasControl_0.SqlSettings.SqlPasswConnect);
			this.canvasControl_0.OpcClient.OpcConfig = new OPCConfig(this.textBoxIPAddressOPCServer.Text, Convert.ToInt32(this.textBoxPortOPCServer.Text), sqlsettings);
			this.canvasControl_0.OpcClient.AutoReconnect = this.checkBoxAutoReconnect.Checked;
			this.canvasControl_0.OpcClient.IntervalReconnect = Convert.ToInt32(this.textBoxItervalReconnect.Text);
			this.canvasControl_0.OpcClient.SaveOPCConfig(this.canvasControl_0.SqlSettings);
		}

		private void checkBoxAutoReconnect_CheckedChanged(object sender, EventArgs e)
		{
			this.textBoxItervalReconnect.Enabled = this.checkBoxAutoReconnect.Checked;
		}

		private void method_15()
		{
			DataTable dataTable = new DataTable();
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this.canvasControl_0.SqlSettings.GetConnectionString());
				SqlCommand sqlCommand = new SqlCommand("SELECT [Year] FROM [tJ_Measurement] where [Year] is not null group by [Year] order by [Year] desc");
				sqlCommand.Connection = sqlConnection;
				sqlConnection.Open();
				SqlDataReader reader = sqlCommand.ExecuteReader();
				dataTable.Load(reader);
				sqlConnection.Close();
				this.comboBoxMeasurementYear.DataSource = dataTable;
				this.comboBoxMeasurementYear.DisplayMember = "Year";
				this.comboBoxMeasurementYear.ValueMember = "Year";
				if (dataTable.Select("Year=" + this.canvasControl_0.Settings.MeasurementYear.ToString()).Length != 0)
				{
					this.comboBoxMeasurementYear.SelectedValue = this.canvasColor.Settings.MeasurementYear;
				}
				else
				{
					this.canvasColor.Settings.MeasurementYear = Convert.ToInt32(this.comboBoxMeasurementYear.SelectedValue);
				}
				this.comboBoxMeasurementYear.SelectedIndexChanged += this.comboBoxMeasurementYear_SelectedIndexChanged;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void comboBoxMeasurementYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.canvasColor.Settings.MeasurementYear = Convert.ToInt32(this.comboBoxMeasurementYear.SelectedValue);
		}

		private void JkIeHaOeLT_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void checkBoxCableVoltage_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void checkBoxCableWires_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void checkBoxCableCrossSection_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void checkBoxCableLenght_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void cablePropDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				return;
			}
			bool flag = !Convert.ToBoolean(this.cablePropDataGridView.Rows[e.RowIndex].Cells[1].Value);
			switch (e.RowIndex)
			{
			case 0:
				this.canvasColor.Settings.VisibleCableMakeup = flag;
				return;
			case 1:
				this.canvasColor.Settings.VisibleCableVoltage = flag;
				return;
			case 2:
				this.canvasColor.Settings.VisibleCableWires = flag;
				return;
			case 3:
				this.canvasColor.Settings.VisibleCableCrossSection = flag;
				return;
			case 4:
				this.canvasColor.Settings.VisibleCableLength = flag;
				return;
			default:
			{
				if (this.cablePropDataGridView.Rows[e.RowIndex].Tag == null)
				{
					return;
				}
				int num = Convert.ToInt32(this.cablePropDataGridView.Rows[e.RowIndex].Tag);
				foreach (PropertyFromBaseElement propertyFromBaseElement in this.canvasColor.Settings.LinePassportProperty)
				{
					if (propertyFromBaseElement.ID == num)
					{
						propertyFromBaseElement.Value = flag;
						break;
					}
				}
				return;
			}
			}
		}

		private void hmoeAwgdZN_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex != 1)
			{
				return;
			}
			bool flag = !Convert.ToBoolean(this.hmoeAwgdZN.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			int num = Convert.ToInt32(this.hmoeAwgdZN.Rows[e.RowIndex].Tag);
			foreach (PropertyFromBaseElement propertyFromBaseElement in this.canvasColor.Settings.TransformerPassportProperty)
			{
				if (propertyFromBaseElement.ID == num)
				{
					propertyFromBaseElement.Value = flag;
					break;
				}
			}
		}

		private CanvasControl canvasControl_0;

		private OPCConfig opcconfig_0;
	}
}
