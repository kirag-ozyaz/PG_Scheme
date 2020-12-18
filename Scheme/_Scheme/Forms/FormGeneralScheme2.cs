using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Constants;
using ControlsLbr;
using DataSql;
using Documents.Forms.Abonent;
using Documents.Forms.DailyReport.JournalDamage;
using Documents.Forms.JournalOrder;
using Documents.Forms.JournalRelayProtectionAutomation;
using Documents.Forms.TechnologicalConnection.RBP;
using FormLbr;
using FormLbr.Classes;
using Passport.Forms;
using Scheme.Classes;
using Scheme.Forms.LinkCellPoint;
using Scheme.Properties;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.Canvas.Forms;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.DrawTool.FormsObj;
using SchemeCtrl2.Layers;
using SchemeModel.Calculations;
using Telemetry;
using WeifenLuo.WinFormsUI.Docking;
//using WeifenLuo.WinFormsUI.Docking;

namespace Scheme.Forms
{
	public partial class FormGeneralScheme2 : FormBase
	{
		protected override XmlDocument CreateXmlConfig()
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
			xmlDocument.AppendChild(newChild);
			XmlNode xmlNode = xmlDocument.CreateElement("FormGeneralScheme");
			xmlDocument.AppendChild(xmlNode);
			XmlNode xmlNode2 = xmlDocument.CreateElement("Canvas");
			XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("CenterPointX");
			xmlAttribute.Value = this.canvasScheme.CenterPointUnit().X.ToString();
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("CenterPointY");
			xmlAttribute.Value = this.canvasScheme.CenterPointUnit().Y.ToString();
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Zoom");
			xmlAttribute.Value = this.canvasScheme.Zoom.ToString();
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlNode.AppendChild(xmlNode2);
			XmlNode xmlNode3 = xmlDocument.CreateElement("objectsCanvas");
			XmlNode xmlNode4 = xmlDocument.CreateElement("GeneralVisibilitySettings");
			xmlAttribute = xmlDocument.CreateAttribute("LineInformationVisible");
			xmlAttribute.Value = this.LineInformationVisible.ToString();
			xmlNode4.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("TelemetryLabelVisible");
			xmlAttribute.Value = this.TelemetryLabelVisible.ToString();
			xmlNode4.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("MeasurementLabelVisible");
			xmlAttribute.Value = this.MeasurementLabelVisible.ToString();
			xmlNode4.Attributes.Append(xmlAttribute);
			xmlNode3.AppendChild(xmlNode4);
			xmlNode.AppendChild(xmlNode3);
			XmlNode xmlNode5 = xmlDocument.CreateElement("TreePanel");
			xmlAttribute = xmlDocument.CreateAttribute("Visible");
			xmlAttribute.Value = this.treeViewObjects.Visible.ToString();
			xmlNode5.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockState");
			xmlAttribute.Value = this.treeViewObjects.DockState.ToString();
			xmlNode5.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockLeftPortion");
			xmlAttribute.Value = this.treeViewObjects.DockPanel.DockLeftPortion.ToString();
			xmlNode5.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockRightPortion");
			xmlAttribute.Value = this.treeViewObjects.DockPanel.DockRightPortion.ToString();
			xmlNode5.Attributes.Append(xmlAttribute);
			xmlNode.AppendChild(xmlNode5);
			XmlNode xmlNode6 = xmlDocument.CreateElement("OPCMessage");
			xmlAttribute = xmlDocument.CreateAttribute("Visible");
			xmlAttribute.Value = this.class11_0.Visible.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockState");
			xmlAttribute.Value = this.class11_0.DockState.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockLeftPortion");
			xmlAttribute.Value = this.class11_0.DockPanel.DockLeftPortion.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockRightPortion");
			xmlAttribute.Value = this.class11_0.DockPanel.DockRightPortion.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockTopPortion");
			xmlAttribute.Value = this.class11_0.DockPanel.DockTopPortion.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockBottomPortion");
			xmlAttribute.Value = this.class11_0.DockPanel.DockBottomPortion.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlNode.AppendChild(xmlNode6);
			XmlNode xmlNode7 = xmlDocument.CreateElement("CanvasMessage");
			xmlAttribute = xmlDocument.CreateAttribute("Visible");
			xmlAttribute.Value = this.class9_0.Visible.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockState");
			xmlAttribute.Value = this.class9_0.DockState.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockLeftPortion");
			xmlAttribute.Value = this.class9_0.DockPanel.DockLeftPortion.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockRightPortion");
			xmlAttribute.Value = this.class9_0.DockPanel.DockRightPortion.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockTopPortion");
			xmlAttribute.Value = this.class9_0.DockPanel.DockTopPortion.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockBottomPortion");
			xmlAttribute.Value = this.class9_0.DockPanel.DockBottomPortion.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlNode.AppendChild(xmlNode7);
			XmlNode xmlNode8 = xmlDocument.CreateElement("PowerPanel");
			xmlAttribute = xmlDocument.CreateAttribute("Visible");
			xmlAttribute.Value = this.class17_0.Visible.ToString();
			xmlNode8.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockState");
			xmlAttribute.Value = this.class17_0.DockState.ToString();
			xmlNode8.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockLeftPortion");
			xmlAttribute.Value = this.class17_0.DockPanel.DockLeftPortion.ToString();
			xmlNode8.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockRightPortion");
			xmlAttribute.Value = this.class17_0.DockPanel.DockRightPortion.ToString();
			xmlNode8.Attributes.Append(xmlAttribute);
			xmlNode.AppendChild(xmlNode8);
			XmlNode xmlNode9 = xmlDocument.CreateElement("StatesPanel");
			xmlAttribute = xmlDocument.CreateAttribute("Visible");
			xmlAttribute.Value = this.class12_0.Visible.ToString();
			xmlNode9.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockState");
			xmlAttribute.Value = this.class12_0.DockState.ToString();
			xmlNode9.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockLeftPortion");
			xmlAttribute.Value = this.class12_0.DockPanel.DockLeftPortion.ToString();
			xmlNode9.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockRightPortion");
			xmlAttribute.Value = this.class12_0.DockPanel.DockRightPortion.ToString();
			xmlNode9.Attributes.Append(xmlAttribute);
			xmlNode.AppendChild(xmlNode9);
			XmlNode xmlNode10 = xmlDocument.CreateElement("GeneralFormSettings");
			foreach (PropertyInfo propertyInfo in typeof(GeneralFormSettings).GetProperties())
			{
				if (propertyInfo.Name == "SizeIcon")
				{
					xmlAttribute = xmlDocument.CreateAttribute(propertyInfo.Name);
					xmlAttribute.Value = GeneralFormSettings.SizeIcon.Width.ToString();
					xmlNode10.Attributes.Append(xmlAttribute);
				}
				else
				{
					xmlAttribute = xmlDocument.CreateAttribute(propertyInfo.Name);
					xmlAttribute.Value = propertyInfo.GetValue(null, null).ToString();
					xmlNode10.Attributes.Append(xmlAttribute);
				}
			}
			xmlNode.AppendChild(xmlNode10);
			XmlNode xmlNode11 = xmlDocument.CreateElement("ToolStrip");
			foreach (object obj in this.toolStripContainer_0.BottomToolStripPanel.Controls)
			{
				Control control = (Control)obj;
				if (control is ToolStrip)
				{
					XmlNode xmlNode12 = xmlDocument.CreateElement(control.Name);
					xmlAttribute = xmlDocument.CreateAttribute("Dock");
					xmlAttribute.Value = "Bottom";
					xmlNode12.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute("X");
					xmlAttribute.Value = control.Location.X.ToString();
					xmlNode12.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute("Y");
					xmlAttribute.Value = control.Location.Y.ToString();
					xmlNode12.Attributes.Append(xmlAttribute);
					xmlNode11.AppendChild(xmlNode12);
				}
			}
			foreach (object obj2 in this.toolStripContainer_0.LeftToolStripPanel.Controls)
			{
				Control control2 = (Control)obj2;
				if (control2 is ToolStrip)
				{
					XmlNode xmlNode13 = xmlDocument.CreateElement(control2.Name);
					xmlAttribute = xmlDocument.CreateAttribute("Dock");
					xmlAttribute.Value = "Left";
					xmlNode13.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute("X");
					xmlAttribute.Value = control2.Location.X.ToString();
					xmlNode13.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute("Y");
					xmlAttribute.Value = control2.Location.Y.ToString();
					xmlNode13.Attributes.Append(xmlAttribute);
					xmlNode11.AppendChild(xmlNode13);
				}
			}
			foreach (object obj3 in this.toolStripContainer_0.TopToolStripPanel.Controls)
			{
				Control control3 = (Control)obj3;
				if (control3 is ToolStrip)
				{
					XmlNode xmlNode14 = xmlDocument.CreateElement(control3.Name);
					xmlAttribute = xmlDocument.CreateAttribute("Dock");
					xmlAttribute.Value = "Top";
					xmlNode14.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute("X");
					xmlAttribute.Value = control3.Location.X.ToString();
					xmlNode14.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute("Y");
					xmlAttribute.Value = control3.Location.Y.ToString();
					xmlNode14.Attributes.Append(xmlAttribute);
					xmlNode11.AppendChild(xmlNode14);
				}
			}
			foreach (object obj4 in this.toolStripContainer_0.RightToolStripPanel.Controls)
			{
				Control control4 = (Control)obj4;
				if (control4 is ToolStrip)
				{
					XmlNode xmlNode15 = xmlDocument.CreateElement(control4.Name);
					xmlAttribute = xmlDocument.CreateAttribute("Dock");
					xmlAttribute.Value = "Right";
					xmlNode15.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute("X");
					xmlAttribute.Value = control4.Location.X.ToString();
					xmlNode15.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute("Y");
					xmlAttribute.Value = control4.Location.Y.ToString();
					xmlNode15.Attributes.Append(xmlAttribute);
					xmlNode11.AppendChild(xmlNode15);
				}
			}
			xmlNode.AppendChild(xmlNode11);
			return xmlDocument;
		}

		private static int smethod_0(XmlNode xmlNode_0, XmlNode xmlNode_1)
		{
			if (xmlNode_0 == null)
			{
				if (xmlNode_1 == null)
				{
					return 0;
				}
				return -1;
			}
			else
			{
				if (xmlNode_1 == null)
				{
					return 1;
				}
				int num = string.Compare(xmlNode_0.Attributes["Dock"].Value, xmlNode_1.Attributes["Dock"].Value);
				if (num != 0)
				{
					return num;
				}
				if (!(xmlNode_0.Attributes["Dock"].Value == "Left") && !(xmlNode_0.Attributes["Dock"].Value == "Right"))
				{
					int num2 = Convert.ToInt32(xmlNode_0.Attributes["Y"].Value).CompareTo(Convert.ToInt32(xmlNode_1.Attributes["Y"].Value));
					if (num2 != 0)
					{
						return num2;
					}
					return Convert.ToInt32(xmlNode_0.Attributes["X"].Value).CompareTo(Convert.ToInt32(xmlNode_1.Attributes["X"].Value));
				}
				else
				{
					int num3 = Convert.ToInt32(xmlNode_0.Attributes["X"].Value).CompareTo(Convert.ToInt32(xmlNode_1.Attributes["X"].Value));
					if (num3 != 0)
					{
						return num3;
					}
					return Convert.ToInt32(xmlNode_0.Attributes["Y"].Value).CompareTo(Convert.ToInt32(xmlNode_1.Attributes["Y"].Value));
				}
			}
		}

		protected override void ApplyConfig(XmlDocument doc)
		{
			XmlNode xmlNode = doc.SelectSingleNode("FormGeneralScheme");
			if (xmlNode != null)
			{
				XmlNode xmlNode2 = xmlNode.SelectSingleNode("TreePanel");
				if (xmlNode2 != null)
				{
					XmlAttribute xmlAttribute = xmlNode2.Attributes["Visible"];
					if (xmlAttribute != null && !Convert.ToBoolean(xmlAttribute.Value))
					{
						this.treeViewObjects.Close();
					}
					xmlAttribute = xmlNode2.Attributes["DockState"];
					if (xmlAttribute != null)
					{
						this.treeViewObjects.DockState = (DockState)Enum.Parse(typeof(DockState), xmlAttribute.Value);
					}
					xmlAttribute = xmlNode2.Attributes["DockLeftPortion"];
					if (xmlAttribute != null)
					{
						this.treeViewObjects.DockPanel.DockLeftPortion = Convert.ToDouble(xmlAttribute.Value);
					}
					xmlAttribute = xmlNode2.Attributes["DockRightPortion"];
					if (xmlAttribute != null)
					{
						this.treeViewObjects.DockPanel.DockRightPortion = Convert.ToDouble(xmlAttribute.Value);
					}
				}
				XmlNode xmlNode3 = xmlNode.SelectSingleNode("OPCMessage");
				if (xmlNode3 != null)
				{
					XmlAttribute xmlAttribute2 = xmlNode3.Attributes["Visible"];
					if (xmlAttribute2 != null && !Convert.ToBoolean(xmlAttribute2.Value))
					{
						this.class11_0.Close();
					}
					xmlAttribute2 = xmlNode3.Attributes["DockState"];
					if (xmlAttribute2 != null)
					{
						this.class11_0.DockState = (DockState)Enum.Parse(typeof(DockState), xmlAttribute2.Value);
					}
					xmlAttribute2 = xmlNode3.Attributes["DockLeftPortion"];
					if (xmlAttribute2 != null)
					{
						this.class11_0.DockPanel.DockLeftPortion = Convert.ToDouble(xmlAttribute2.Value);
					}
					xmlAttribute2 = xmlNode3.Attributes["DockRightPortion"];
					if (xmlAttribute2 != null)
					{
						this.class11_0.DockPanel.DockRightPortion = Convert.ToDouble(xmlAttribute2.Value);
					}
					xmlAttribute2 = xmlNode3.Attributes["DockTopPortion"];
					if (xmlAttribute2 != null)
					{
						this.class11_0.DockPanel.DockTopPortion = Convert.ToDouble(xmlAttribute2.Value);
					}
					xmlAttribute2 = xmlNode3.Attributes["DockBottomPortion"];
					if (xmlAttribute2 != null)
					{
						this.class11_0.DockPanel.DockBottomPortion = Convert.ToDouble(xmlAttribute2.Value);
					}
				}
				XmlNode xmlNode4 = xmlNode.SelectSingleNode("CanvasMessage");
				if (xmlNode4 != null)
				{
					XmlAttribute xmlAttribute3 = xmlNode4.Attributes["Visible"];
					if (xmlAttribute3 != null && !Convert.ToBoolean(xmlAttribute3.Value))
					{
						this.class9_0.Close();
					}
					xmlAttribute3 = xmlNode4.Attributes["DockState"];
					if (xmlAttribute3 != null)
					{
						this.class9_0.DockState = (DockState)Enum.Parse(typeof(DockState), xmlAttribute3.Value);
					}
					xmlAttribute3 = xmlNode4.Attributes["DockLeftPortion"];
					if (xmlAttribute3 != null)
					{
						this.class9_0.DockPanel.DockLeftPortion = Convert.ToDouble(xmlAttribute3.Value);
					}
					xmlAttribute3 = xmlNode4.Attributes["DockRightPortion"];
					if (xmlAttribute3 != null)
					{
						this.class9_0.DockPanel.DockRightPortion = Convert.ToDouble(xmlAttribute3.Value);
					}
					xmlAttribute3 = xmlNode4.Attributes["DockTopPortion"];
					if (xmlAttribute3 != null)
					{
						this.class9_0.DockPanel.DockTopPortion = Convert.ToDouble(xmlAttribute3.Value);
					}
					xmlAttribute3 = xmlNode4.Attributes["DockBottomPortion"];
					if (xmlAttribute3 != null)
					{
						this.class9_0.DockPanel.DockBottomPortion = Convert.ToDouble(xmlAttribute3.Value);
					}
				}
				XmlNode xmlNode5 = xmlNode.SelectSingleNode("PowerPanel");
				if (xmlNode5 != null)
				{
					XmlAttribute xmlAttribute4 = xmlNode5.Attributes["Visible"];
					if (xmlAttribute4 != null && !Convert.ToBoolean(xmlAttribute4.Value))
					{
						this.class17_0.Close();
					}
					xmlAttribute4 = xmlNode5.Attributes["DockState"];
					if (xmlAttribute4 != null)
					{
						this.class17_0.DockState = (DockState)Enum.Parse(typeof(DockState), xmlAttribute4.Value);
					}
					xmlAttribute4 = xmlNode5.Attributes["DockLeftPortion"];
					if (xmlAttribute4 != null)
					{
						this.class17_0.DockPanel.DockLeftPortion = Convert.ToDouble(xmlAttribute4.Value);
					}
					xmlAttribute4 = xmlNode5.Attributes["DockRightPortion"];
					if (xmlAttribute4 != null)
					{
						this.class17_0.DockPanel.DockRightPortion = Convert.ToDouble(xmlAttribute4.Value);
					}
				}
				XmlNode xmlNode6 = xmlNode.SelectSingleNode("StatesPanel");
				if (xmlNode6 != null)
				{
					XmlAttribute xmlAttribute5 = xmlNode6.Attributes["Visible"];
					if (xmlAttribute5 != null && !Convert.ToBoolean(xmlAttribute5.Value))
					{
						this.class12_0.Close();
					}
					xmlAttribute5 = xmlNode6.Attributes["DockState"];
					if (xmlAttribute5 != null)
					{
						this.class12_0.DockState = (DockState)Enum.Parse(typeof(DockState), xmlAttribute5.Value);
					}
					xmlAttribute5 = xmlNode6.Attributes["DockLeftPortion"];
					if (xmlAttribute5 != null)
					{
						this.class12_0.DockPanel.DockLeftPortion = Convert.ToDouble(xmlAttribute5.Value);
					}
					xmlAttribute5 = xmlNode6.Attributes["DockRightPortion"];
					if (xmlAttribute5 != null)
					{
						this.class12_0.DockPanel.DockRightPortion = Convert.ToDouble(xmlAttribute5.Value);
					}
				}
				XmlNode xmlNode7 = xmlNode.SelectSingleNode("GeneralFormSettings");
				if (xmlNode7 != null)
				{
					foreach (PropertyInfo propertyInfo in typeof(GeneralFormSettings).GetProperties())
					{
						XmlAttribute xmlAttribute6 = xmlNode7.Attributes[propertyInfo.Name];
						if (xmlAttribute6 != null)
						{
							if (propertyInfo.Name == "SizeIcon")
							{
								int num = Convert.ToInt32(xmlAttribute6.Value);
								GeneralFormSettings.SizeIcon = new Size(num, num);
							}
							else if (propertyInfo.PropertyType == typeof(float))
							{
								propertyInfo.SetValue(null, Convert.ToSingle(xmlAttribute6.Value), null);
							}
						}
					}
				}
				XmlNode xmlNode8 = xmlNode.SelectSingleNode("ToolStrip");
				List<XmlNode> list = new List<XmlNode>();
				List<Control> list2 = new List<Control>();
				for (int j = 0; j < this.toolStripContainer_0.TopToolStripPanel.Controls.Count; j++)
				{
					Control control = this.toolStripContainer_0.TopToolStripPanel.Controls[j];
					if (control is ToolStrip)
					{
						XmlNode xmlNode9 = xmlNode8.SelectSingleNode(control.Name);
						if (xmlNode9 != null)
						{
							list.Add(xmlNode9);
							this.toolStripContainer_0.TopToolStripPanel.Controls.Remove(control);
							list2.Add(control);
							j--;
						}
					}
				}
				list.Sort(new Comparison<XmlNode>(FormGeneralScheme2.smethod_0));
				using (List<XmlNode>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						XmlNode node1 = enumerator.Current;
						Control control2 = list2.Single((Control obj) => obj.Name == node1.Name);
						int x = 0;
						int y = 0;
						XmlAttribute xmlAttribute7 = node1.Attributes["X"];
						if (xmlAttribute7 != null)
						{
							x = Convert.ToInt32(xmlAttribute7.Value);
						}
						xmlAttribute7 = node1.Attributes["Y"];
						if (xmlAttribute7 != null)
						{
							y = Convert.ToInt32(xmlAttribute7.Value);
						}
						control2.Location = new Point(x, y);
						xmlAttribute7 = node1.Attributes["Dock"];
						if (xmlAttribute7 != null)
						{
							string value = xmlAttribute7.Value;
							if (!(value == "Bottom"))
							{
								if (!(value == "Left"))
								{
									if (!(value == "Top"))
									{
										if (value == "Right")
										{
											this.toolStripContainer_0.RightToolStripPanel.Controls.Add(control2);
										}
									}
									else
									{
										this.toolStripContainer_0.TopToolStripPanel.Controls.Add(control2);
									}
								}
								else
								{
									this.toolStripContainer_0.LeftToolStripPanel.Controls.Add(control2);
								}
							}
							else
							{
								this.toolStripContainer_0.BottomToolStripPanel.Controls.Add(control2);
							}
						}
					}
				}
				this.opcClient.LoadOPCConfig(this.canvasScheme.SqlSettings);
				this.opcClient.OpcConfig.SqlSettings.Autentification = this.canvasScheme.SqlSettings.Autentification;
				this.opcClient.OpcConfig.SqlSettings.SqlUserConnect = this.canvasScheme.SqlSettings.SqlUserConnect;
				this.opcClient.OpcConfig.SqlSettings.SqlPasswConnect = this.canvasScheme.SqlSettings.SqlPasswConnect;
				XmlNode xmlNode10 = xmlNode.SelectSingleNode("Canvas");
				if (xmlNode10 != null)
				{
					XmlAttribute xmlAttribute8 = xmlNode10.Attributes["Zoom"];
					if (xmlAttribute8 != null)
					{
						this.canvasScheme.Zoom = Convert.ToSingle(xmlAttribute8.Value);
						if (float.IsInfinity(this.canvasScheme.Zoom) || float.IsNaN(this.canvasScheme.Zoom))
						{
							this.canvasScheme.Zoom = 1f;
						}
					}
					XmlAttribute xmlAttribute9 = xmlNode10.Attributes["CenterPointX"];
					XmlAttribute xmlAttribute10 = xmlNode10.Attributes["CenterPointY"];
					if (xmlAttribute9 != null && xmlAttribute10 != null)
					{
						float num2 = Convert.ToSingle(xmlAttribute9.Value);
						float num3 = Convert.ToSingle(xmlAttribute10.Value);
						if (float.IsNaN(num2))
						{
							num2 = 0f;
						}
						if (float.IsNaN(num3))
						{
							num3 = 0f;
						}
						this.canvasScheme.SetCenter(new UnitPoint((double)num2, (double)num3));
					}
					this.canvasScheme.DoInvalidate(true);
				}
				XmlNode xmlNode11 = xmlNode.SelectSingleNode("objectsCanvas");
				if (xmlNode11 != null)
				{
					XmlNode xmlNode12 = xmlNode11.SelectSingleNode("GeneralVisibilitySettings");
					XmlAttribute xmlAttribute11 = xmlNode12.Attributes["LineInformationVisible"];
					if (xmlAttribute11 != null)
					{
						this.LineInformationVisible = Convert.ToBoolean(xmlAttribute11.Value);
					}
					xmlAttribute11 = xmlNode12.Attributes["TelemetryLabelVisible"];
					if (xmlAttribute11 != null)
					{
						this.TelemetryLabelVisible = Convert.ToBoolean(xmlAttribute11.Value);
					}
					else
					{
						this.TelemetryLabelVisible = false;
					}
					xmlAttribute11 = xmlNode12.Attributes["MeasurementLabelVisible"];
					if (xmlAttribute11 != null)
					{
						this.MeasurementLabelVisible = Convert.ToBoolean(xmlAttribute11.Value);
						return;
					}
					this.MeasurementLabelVisible = false;
				}
			}
		}

		private void method_0(string string_0)
		{
			if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeSecond)
			{
				SqlConnection selectConnection = new SqlConnection("Server = ulges-sql;dataBase = scheme_" + string_0 + ";Integrated Security=true;Connection TimeOut = 180");
				if (this.canvasControl_1.Layers.Count<ICanvasLayer>() > 0)
				{
					IEnumerable<DrawObjectBase> source = from a in this.canvasControl_1.Layers.First<ICanvasLayer>().Objects
					where a.GetType() == typeof(RectangleTool)
					select a;
					if (source.Count<DrawObjectBase>() > 0)
					{
						RectangleTool rectangleTool = (RectangleTool)source.First<DrawObjectBase>();
						DataTable dataTable = new DataTable();
						new SqlDataAdapter("select id_obj, name, orient_name, x_coord1, y_coord1, x_coord2, y_coord2, name_group, volt   from el_shina where name_group = '" + rectangleTool.Text + "'", selectConnection).Fill(dataTable);
						this.method_5(dataTable);
						DataTable dataTable2 = new DataTable();
						new SqlDataAdapter("select id_obj, name, orient_name, x_coord, y_coord, nom_shina, name_group   from el_point where name_group =  '" + rectangleTool.Text + "'", selectConnection).Fill(dataTable2);
						this.method_6(dataTable2);
						DataTable dataTable3 = new DataTable();
						new SqlDataAdapter("select id_obj, id_point1, id_point2, vid   from el_line where name_group =  '" + rectangleTool.Text + "'", selectConnection).Fill(dataTable3);
						DataTable dataTable4 = new DataTable();
						new SqlDataAdapter("select id_obj, id_line, place, type from el_in_line where name_group =  '" + rectangleTool.Text + "'", selectConnection).Fill(dataTable4);
						DataTable dataTable5 = new DataTable();
						new SqlDataAdapter("select id_obj, id_line, place, orient, text  from el_line_text  where name_group =  '" + rectangleTool.Text + "'", selectConnection).Fill(dataTable5);
						this.method_7(dataTable3, dataTable2, dataTable4, dataTable5);
						this.method_2();
					}
				}
			}
		}

		private void method_1(string string_0)
		{
			if (MessageBox.Show("Очистить схему перед загрузкой?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				((DrawingLayer)this.canvasScheme.Layers.First<ICanvasLayer>()).Clear(true);
				SqlDataConnect sqlDataConnect = new SqlDataConnect();
				sqlDataConnect.OpenConnection(this.SqlSettings);
				new SqlCommand("delete tSChm_ObjList delete tSchm_relation delete tSChm_Xml", sqlDataConnect.Connection).ExecuteNonQuery();
			}
			SqlConnection sqlConnection = new SqlConnection("Server = ulges-sql;dataBase = scheme_" + string_0 + ";Integrated Security=true; Connection TimeOut = 180");
			sqlConnection.Open();
			DataTable dataTable = new DataTable();
			new SqlDataAdapter("select id_obj, name, orient_name, type, x_coord1, y_coord1, x_coord2, y_coord2   from ob_group where deleted = 0  ", sqlConnection).Fill(dataTable);
			this.method_4(dataTable);
			DataTable dataTable2 = new DataTable();
			new SqlDataAdapter("select id_obj, name, orient_name, x_coord1, y_coord1, x_coord2, y_coord2, nom_group, volt   from ob_shina where deleted = 0 ", sqlConnection).Fill(dataTable2);
			this.method_5(dataTable2);
			DataTable dataTable3 = new DataTable();
			new SqlDataAdapter("select id_obj, name, orient_name, x_coord, y_coord, nom_shina, nom_group   from ob_point where deleted = 0 ", sqlConnection).Fill(dataTable3);
			DataTable dataTable4 = new DataTable();
			new SqlDataAdapter("select id_obj, id_point1, id_point2, vid   from ob_line where deleted = 0 ", sqlConnection).Fill(dataTable4);
			this.method_6(dataTable3);
			DataTable dataTable5 = new DataTable();
			new SqlDataAdapter("select id_obj, id_line, place, type, key_on, KEY_Normal from ob_in_line where deleted = 0 ", sqlConnection).Fill(dataTable5);
			DataTable dataTable6 = new DataTable();
			dataTable6 = dataTable4.Clone();
			foreach (object obj in dataTable4.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				DataRow[] array = dataTable3.Select("id_obj = " + dataRow["id_point1"].ToString());
				DataRow[] array2 = dataTable3.Select("id_obj = " + dataRow["id_point2"].ToString());
				if (array.Length != 0 && array2.Length != 0 && !(array[0]["nom_group"].ToString() != array2[0]["nom_group"].ToString()) && !(array[0]["nom_group"].ToString() == "-1"))
				{
					dataTable6.ImportRow(dataRow);
				}
			}
			this.method_7(dataTable6, dataTable3, dataTable5, null);
			this.method_9(dataTable4, dataTable3, dataTable5);
			this.method_3();
		}

		private void method_2()
		{
			foreach (DrawObjectBase drawObjectBase in this.canvasControl_1.Layers.First<ICanvasLayer>().Objects)
			{
				if (drawObjectBase.GetType() == typeof(RectangleTool))
				{
					((RectangleTool)drawObjectBase).SaveToSql(false, true);
				}
			}
		}

		private void method_3()
		{
			int num = 0;
			int num2 = this.canvasControl_1.Layers.First<ICanvasLayer>().Objects.Count((DrawObjectBase o) => o.GetType() == typeof(RectangleTool) || o.GetType() == typeof(LineTool));
			foreach (DrawObjectBase drawObjectBase in this.canvasScheme.Layers.First<ICanvasLayer>().Objects)
			{
				bool flag = false;
				if (drawObjectBase.GetType() == typeof(RectangleTool))
				{
					num++;
					if (drawObjectBase.IdBase <= 0)
					{
						((RectangleTool)drawObjectBase).SaveToSql(false, true);
					}
					flag = true;
				}
				else if (drawObjectBase.GetType() == typeof(LineTool))
				{
					num++;
					if (drawObjectBase.IdBase <= 0)
					{
						if (drawObjectBase.Text.Length > 511)
						{
							drawObjectBase.Text = drawObjectBase.Text.Remove(511);
						}
						((LineTool)drawObjectBase).SaveToSql(false, true);
					}
					flag = true;
				}
				if (flag)
				{
					int num3 = Convert.ToInt32((double)num / (double)num2 * 100.0);
					if (num3 <= 100)
					{
						this.backgroundWorker_0.ReportProgress(num3, "Save: ");
					}
				}
			}
		}

		private void method_4(DataTable dataTable_0)
		{
			int num = 0;
			foreach (object obj in dataTable_0.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				RectangleTool rectangleTool = new RectangleTool();
				float num2 = Convert.ToSingle(dataRow["x_coord1"]) / 96f * 2.54f;
				float num3 = -(Convert.ToSingle(dataRow["y_coord1"]) / 96f) * 2.54f;
				float num4 = Convert.ToSingle(dataRow["x_coord2"]) / 96f * 2.54f;
				float num5 = -(Convert.ToSingle(dataRow["y_coord2"]) / 96f) * 2.54f;
				if (num4 < num2)
				{
					float num6 = num2;
					num2 = num4;
					num4 = num6;
				}
				if (num5 < num3)
				{
					float num7 = num3;
					num3 = num5;
					num5 = num7;
				}
				rectangleTool.Rectangle = new RectangleF(num2, num3, num4 - num2, num5 - num3);
				rectangleTool.Text = dataRow["name"].ToString();
				rectangleTool.TextProperty.Visible = true;
				if (Convert.ToInt32(dataRow["orient_name"]) == 1)
				{
					goto IL_24B;
				}
				if (Convert.ToInt32(dataRow["orient_name"]) == 101)
				{
					goto IL_24B;
				}
				if (Convert.ToInt32(dataRow["orient_name"]) != 2)
				{
					if (Convert.ToInt32(dataRow["orient_name"]) != 102)
					{
						if (Convert.ToInt32(dataRow["orient_name"]) != 3)
						{
							if (Convert.ToInt32(dataRow["orient_name"]) != 103)
							{
								if (Convert.ToInt32(dataRow["orient_name"]) != 4)
								{
									if (Convert.ToInt32(dataRow["orient_name"]) != 104)
									{
										rectangleTool.TextProperty.Visible = false;
										goto IL_277;
									}
								}
								rectangleTool.TextProperty.Position = ePositionText.B;
								if (Convert.ToInt32(dataRow["orient_name"]) == 104)
								{
									rectangleTool.TextProperty.FontVirtical = true;
									goto IL_277;
								}
								goto IL_277;
							}
						}
						rectangleTool.TextProperty.Position = ePositionText.R;
						if (Convert.ToInt32(dataRow["orient_name"]) == 103)
						{
							rectangleTool.TextProperty.FontVirtical = true;
							goto IL_277;
						}
						goto IL_277;
					}
				}
				rectangleTool.TextProperty.Position = ePositionText.T;
				if (Convert.ToInt32(dataRow["orient_name"]) == 102)
				{
					rectangleTool.TextProperty.FontVirtical = true;
				}
				IL_277:
				rectangleTool.IdOldBase = dataRow["Id_Obj"].ToString();
				rectangleTool.UseSettingColor = false;
				rectangleTool.Color = Color.RoyalBlue;
				switch (Convert.ToInt32(dataRow["type"]))
				{
				case 1:
					rectangleTool.Color = Color.Yellow;
					rectangleTool.TypeRectnagleTool = eTypeRectangleTool.CP;
					break;
				case 2:
					rectangleTool.Color = Color.Purple;
					rectangleTool.TypeRectnagleTool = eTypeRectangleTool.RP;
					break;
				case 3:
					rectangleTool.TypeRectnagleTool = eTypeRectangleTool.TP;
					break;
				case 4:
					rectangleTool.Color = Color.Plum;
					rectangleTool.TypeRectnagleTool = eTypeRectangleTool.PP;
					break;
				default:
					rectangleTool.TypeRectnagleTool = eTypeRectangleTool.TP;
					break;
				}
				rectangleTool.Layer = (DrawingLayer)this.canvasScheme.Layers.First<ICanvasLayer>();
				if (!this.canvasScheme.ValidateToUnique(rectangleTool))
				{
					rectangleTool.CreateUniqueCopyName();
				}
				this.canvasScheme.AddObject(this.canvasScheme.Layers.First<ICanvasLayer>(), rectangleTool);
				this.backgroundWorker_0.ReportProgress((int)((float)num / (float)dataTable_0.Rows.Count * 100f), " Rectnagle: ");
				num++;
				continue;
				IL_24B:
				rectangleTool.TextProperty.Position = ePositionText.L;
				if (Convert.ToInt32(dataRow["orient_name"]) == 101)
				{
					rectangleTool.TextProperty.FontVirtical = true;
					goto IL_277;
				}
				goto IL_277;
			}
		}

		private void method_5(DataTable dataTable_0)
		{
			IEnumerable<DrawObjectBase> source = from obj in this.canvasControl_1.Layers.First<ICanvasLayer>().Objects
			where obj.GetType() == typeof(RectangleTool)
			select obj;
			int num = 0;
			using (IEnumerator enumerator = dataTable_0.Rows.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DataRow dr = (DataRow)enumerator.Current;
					if ((!(dr["Volt"].ToString() == "1") && !(dr["Volt"].ToString() == "0")) || this.canvasControl_1.TypeCanvas != eTypeCanvas.SchemeSecond)
					{
						ShinaTool shinaTool = new ShinaTool();
						float num2 = Convert.ToSingle(dr["x_coord1"]) / 96f * 2.54f;
						float num3 = -(Convert.ToSingle(dr["y_coord1"]) / 96f) * 2.54f;
						float num4 = Convert.ToSingle(dr["x_coord2"]) / 96f * 2.54f;
						float num5 = -(Convert.ToSingle(dr["y_coord2"]) / 96f) * 2.54f;
						if (num4 < num2)
						{
							float num6 = num2;
							num2 = num4;
							num4 = num6;
						}
						if (num5 < num3)
						{
							float num7 = num3;
							num3 = num5;
							num5 = num7;
						}
						shinaTool.P1 = new UnitPoint((double)num2, (double)num3);
						shinaTool.P2 = new UnitPoint((double)num4, (double)num5);
						shinaTool.Text = (Convert.ToInt32(dr["name"]) + 1).ToString();
						shinaTool.IdOldBase = dr["Id_Obj"].ToString();
						if (Convert.ToInt32(dr["orient_name"]) == 0)
						{
							shinaTool.TextProperty.Visible = false;
						}
						else
						{
							shinaTool.TextProperty.Visible = true;
							if (Convert.ToInt32(dr["orient_name"]) == 1)
							{
								shinaTool.TextProperty.Position = ePositionText.L;
							}
							else if (Convert.ToInt32(dr["orient_name"]) == 2)
							{
								shinaTool.TextProperty.Position = ePositionText.T;
							}
							else if (Convert.ToInt32(dr["orient_name"]) == 3)
							{
								shinaTool.TextProperty.Position = ePositionText.R;
							}
							else if (Convert.ToInt32(dr["orient_name"]) == 4)
							{
								shinaTool.TextProperty.Position = ePositionText.B;
							}
						}
						if (dr["Volt"].ToString() == "1")
						{
							shinaTool.TypeShinaTool = eTypeShinaTool.Shina_6;
						}
						if (dr["Volt"].ToString() == "0")
						{
							shinaTool.TypeShinaTool = eTypeShinaTool.Shina_10;
						}
						if (dr["Volt"].ToString() == "2")
						{
							shinaTool.TypeShinaTool = eTypeShinaTool.Shina_04;
						}
						if (dr["Volt"].ToString() == "3")
						{
							shinaTool.TypeShinaTool = eTypeShinaTool.Shina_023;
						}
						if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
						{
							IEnumerable<DrawObjectBase> source2 = from rect in source
							where ((RectangleTool)rect).IdOldBase == dr["nom_group"].ToString()
							select rect;
							if (source2.Count<DrawObjectBase>() > 0)
							{
								shinaTool.Parent = source2.First<DrawObjectBase>();
							}
						}
						else
						{
							shinaTool.Parent = source.First<DrawObjectBase>();
						}
						shinaTool.Layer = (DrawingLayer)this.canvasControl_1.Layers.First<ICanvasLayer>();
						if (!this.canvasControl_1.ValidateToUnique(shinaTool))
						{
							shinaTool.CreateUniqueCopyName();
						}
						this.canvasControl_1.AddObject(this.canvasControl_1.Layers.First<ICanvasLayer>(), shinaTool);
						this.backgroundWorker_0.ReportProgress((int)((float)num / (float)dataTable_0.Rows.Count * 100f), " Shina: ");
						num++;
					}
				}
			}
		}

		private void method_6(DataTable dataTable_0)
		{
			IEnumerable<DrawObjectBase> source = from obj in this.canvasControl_1.Layers.First<ICanvasLayer>().Objects
			where obj.GetType() == typeof(ShinaTool)
			select obj;
			int num = 0;
			using (IEnumerator enumerator = dataTable_0.Rows.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DataRow dr = (DataRow)enumerator.Current;
					PointShinaTool pointShinaTool = new PointShinaTool();
					float num2 = Convert.ToSingle(dr["x_coord"]) / 96f * 2.54f;
					float num3 = -(Convert.ToSingle(dr["y_coord"]) / 96f) * 2.54f;
					pointShinaTool.Point = new UnitPoint((double)num2, (double)num3);
					pointShinaTool.Text = dr["name"].ToString();
					pointShinaTool.IdOldBase = dr["Id_Obj"].ToString();
					if (Convert.ToInt32(dr["orient_name"]) == 0)
					{
						pointShinaTool.TextProperty.Visible = false;
					}
					else
					{
						pointShinaTool.TextProperty.Visible = true;
						if (Convert.ToInt32(dr["orient_name"]) != 1)
						{
							if (Convert.ToInt32(dr["orient_name"]) != 2)
							{
								if (Convert.ToInt32(dr["orient_name"]) != 3)
								{
									if (Convert.ToInt32(dr["orient_name"]) != 4)
									{
										if (Convert.ToInt32(dr["orient_name"]) != 5)
										{
											if (Convert.ToInt32(dr["orient_name"]) != 6)
											{
												if (Convert.ToInt32(dr["orient_name"]) == 7 || Convert.ToInt32(dr["orient_name"]) == 8)
												{
													pointShinaTool.TextProperty.Position = ePositionText.B;
													goto IL_23F;
												}
												goto IL_23F;
											}
										}
										pointShinaTool.TextProperty.Position = ePositionText.R;
										goto IL_23F;
									}
								}
								pointShinaTool.TextProperty.Position = ePositionText.T;
								goto IL_23F;
							}
						}
						pointShinaTool.TextProperty.Position = ePositionText.L;
					}
					IL_23F:
					IEnumerable<DrawObjectBase> source2 = from shina in source
					where ((ShinaTool)shina).IdOldBase == dr["nom_shina"].ToString()
					select shina;
					if (source2.Count<DrawObjectBase>() > 0)
					{
						pointShinaTool.Parent = source2.First<DrawObjectBase>();
						((ShinaTool)source2.First<DrawObjectBase>()).AddPointShinaTool(pointShinaTool);
					}
					source2 = from shina in source
					where ((ShinaTool)shina).IdOldBase == dr["nom_shina"].ToString()
					select shina;
					this.backgroundWorker_0.ReportProgress((int)((float)num / (float)dataTable_0.Rows.Count * 100f), " Cell: ");
					num++;
				}
			}
		}

		private void method_7(DataTable dataTable_0, DataTable dataTable_1, DataTable dataTable_2, DataTable dataTable_3)
		{
			IEnumerable<DrawObjectBase> enumerable = from obj in this.canvasControl_1.Layers.First<ICanvasLayer>().Objects
			where obj.GetType() == typeof(ShinaTool)
			select obj;
			using (IEnumerator enumerator = dataTable_0.Rows.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					if (!this.list_0.Contains(Convert.ToInt32(dataRow["id_obj"])))
					{
						LineCellTool lineCellTool = new LineCellTool();
						DataRow[] points = dataTable_1.Select("id_obj = " + dataRow["id_point1"].ToString());
						PointTool pointTool = new PointTool((DrawingLayer)this.canvasControl_1.Layers.First<ICanvasLayer>());
						if (points.Length != 0)
						{
							float num = Convert.ToSingle(points[0]["x_coord"]) / 96f * 2.54f;
							float num2 = -(Convert.ToSingle(points[0]["y_coord"]) / 96f) * 2.54f;
							pointTool.Point = new UnitPoint((double)num, (double)num2);
							pointTool.IdOldBase = points[0]["id_obj"].ToString();
							if (Convert.ToInt32(points[0]["orient_name"]) == 0)
							{
								pointTool.TextProperty.Visible = false;
							}
							else
							{
								pointTool.Text = points[0]["name"].ToString();
								pointTool.TextProperty.Visible = true;
								if (Convert.ToInt32(points[0]["orient_name"]) != 1)
								{
									if (Convert.ToInt32(points[0]["orient_name"]) != 2)
									{
										if (Convert.ToInt32(points[0]["orient_name"]) != 3)
										{
											if (Convert.ToInt32(points[0]["orient_name"]) != 4)
											{
												if (Convert.ToInt32(points[0]["orient_name"]) != 5)
												{
													if (Convert.ToInt32(points[0]["orient_name"]) != 6)
													{
														if (Convert.ToInt32(points[0]["orient_name"]) == 7 || Convert.ToInt32(points[0]["orient_name"]) == 8)
														{
															pointTool.TextProperty.Position = ePositionText.B;
															goto IL_2C3;
														}
														goto IL_2C3;
													}
												}
												pointTool.TextProperty.Position = ePositionText.R;
												goto IL_2C3;
											}
										}
										pointTool.TextProperty.Position = ePositionText.T;
										goto IL_2C3;
									}
								}
								pointTool.TextProperty.Position = ePositionText.L;
							}
							IL_2C3:
							points = dataTable_1.Select("id_obj = " + dataRow["id_point2"].ToString());
							PointTool pointTool2 = new PointTool((DrawingLayer)this.canvasScheme.Layers.First<ICanvasLayer>());
							if (points.Length != 0)
							{
								float num3 = Convert.ToSingle(points[0]["x_coord"]) / 96f * 2.54f;
								float num4 = -(Convert.ToSingle(points[0]["y_coord"]) / 96f) * 2.54f;
								pointTool2.Point = new UnitPoint((double)num3, (double)num4);
								pointTool2.IdOldBase = points[0]["id_obj"].ToString();
								if (Convert.ToInt32(points[0]["orient_name"]) == 0)
								{
									pointTool2.TextProperty.Visible = false;
								}
								else
								{
									pointTool2.Text = points[0]["name"].ToString();
									pointTool2.TextProperty.Visible = true;
									if (Convert.ToInt32(points[0]["orient_name"]) != 1)
									{
										if (Convert.ToInt32(points[0]["orient_name"]) != 2)
										{
											if (Convert.ToInt32(points[0]["orient_name"]) != 3)
											{
												if (Convert.ToInt32(points[0]["orient_name"]) != 4)
												{
													if (Convert.ToInt32(points[0]["orient_name"]) != 5)
													{
														if (Convert.ToInt32(points[0]["orient_name"]) != 6)
														{
															if (Convert.ToInt32(points[0]["orient_name"]) == 7 || Convert.ToInt32(points[0]["orient_name"]) == 8)
															{
																pointTool2.TextProperty.Position = ePositionText.B;
																goto IL_4FE;
															}
															goto IL_4FE;
														}
													}
													pointTool2.TextProperty.Position = ePositionText.R;
													goto IL_4FE;
												}
											}
											pointTool2.TextProperty.Position = ePositionText.T;
											goto IL_4FE;
										}
									}
									pointTool2.TextProperty.Position = ePositionText.L;
								}
								IL_4FE:
								IEnumerable<DrawObjectBase> source;
								if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
								{
									source = from obj in this.canvasControl_1.Layers.First<ICanvasLayer>().Objects
									where obj.GetType() == typeof(RectangleTool) && ((RectangleTool)obj).IdOldBase == points[0]["nom_group"].ToString()
									select obj;
								}
								else
								{
									source = from obj in this.canvasControl_1.Layers.First<ICanvasLayer>().Objects
									where obj.GetType() == typeof(RectangleTool) && ((RectangleTool)obj).Text == points[0]["name_group"].ToString()
									select obj;
								}
								lineCellTool.Parent = source.First<DrawObjectBase>();
								if (Convert.ToInt32(dataRow["vid"]) == 2)
								{
									lineCellTool.AddBranch(pointTool, pointTool2, BranchType.AirLine);
								}
								else
								{
									lineCellTool.AddBranch(pointTool, pointTool2);
								}
								lineCellTool.Layer = (DrawingLayer)this.canvasControl_1.Layers.First<ICanvasLayer>();
								if (!this.canvasControl_1.ValidateToUnique(lineCellTool))
								{
									lineCellTool.CreateUniqueCopyName();
								}
								foreach (DataRow dataRow2 in dataTable_2.Select("id_line = " + dataRow["id_obj"].ToString()))
								{
									TypeSwitch typeSwitch = TypeSwitch.LinearDisconnectorTool;
									switch (Convert.ToInt32(dataRow2["type"]))
									{
									case 1:
										if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
										{
											typeSwitch = TypeSwitch.LinearDisconnectorTool;
										}
										else
										{
											typeSwitch = TypeSwitch.TransformerTool;
										}
										break;
									case 2:
										typeSwitch = TypeSwitch.LoadSwitchTool;
										break;
									case 3:
										if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
										{
											typeSwitch = TypeSwitch.LubricantSwitchTool;
										}
										else
										{
											typeSwitch = TypeSwitch.LinearDisconnectorTool;
										}
										break;
									case 4:
										if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
										{
											typeSwitch = TypeSwitch.DamageTool;
										}
										else
										{
											typeSwitch = TypeSwitch.FuseTool;
										}
										break;
									case 5:
										if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
										{
											typeSwitch = TypeSwitch.GroundingTool;
										}
										else
										{
											typeSwitch = TypeSwitch.LinearDisconnectorTool;
										}
										break;
									case 6:
										typeSwitch = TypeSwitch.FuseTool;
										break;
									case 8:
										if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
										{
											typeSwitch = TypeSwitch.OutsideLineDisconnectorTool;
										}
										else
										{
											typeSwitch = TypeSwitch.EndTrimTool;
										}
										break;
									case 10:
										typeSwitch = TypeSwitch.VacuumSwitchTool;
										break;
									}
									ObjectOnLine objectOnLine = lineCellTool.Branches[lineCellTool.Branches.Count - 1].AddSwitchTool(typeSwitch, (double)Convert.ToSingle(dataRow2["Place"]));
									objectOnLine.Layer = (DrawingLayer)this.canvasControl_1.Layers.First<ICanvasLayer>();
									objectOnLine.Text = "Выключатель";
									if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
									{
										if (Convert.ToInt32(dataRow2["KEY_ON"]) == 1)
										{
											objectOnLine.On = true;
										}
										objectOnLine.IsNormalSection = true;
										switch (Convert.ToInt32(dataRow2["KEY_NORMAL"]))
										{
										case 0:
											objectOnLine.IsNormalSection = false;
											break;
										case 1:
											objectOnLine.TextPropertyNormalSection.Position = ePositionText.L;
											break;
										case 2:
											objectOnLine.TextPropertyNormalSection.Position = ePositionText.T;
											break;
										case 3:
											objectOnLine.TextPropertyNormalSection.Position = ePositionText.R;
											break;
										case 4:
											objectOnLine.TextPropertyNormalSection.Position = ePositionText.B;
											break;
										}
									}
									else
									{
										objectOnLine.On = true;
									}
									if (!this.canvasControl_1.ValidateToUnique(objectOnLine))
									{
										objectOnLine.CreateUniqueCopyName();
									}
									((DrawingLayer)this.canvasControl_1.Layers.First<ICanvasLayer>()).AddObject(objectOnLine);
								}
								if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeSecond)
								{
									foreach (DataRow dataRow3 in dataTable_3.Select("id_line = " + dataRow["id_obj"].ToString()))
									{
										TextBranchTool textBranchTool = new TextBranchTool();
										textBranchTool.Parent = lineCellTool.Branches[lineCellTool.Branches.Count - 1];
										textBranchTool.Layer = (DrawingLayer)this.canvasControl_1.Layers.First<ICanvasLayer>();
										textBranchTool.IdOldBase = dataRow3["id_obj"].ToString();
										textBranchTool.Text = dataRow3["text"].ToString();
										if (Convert.ToInt32(dataRow3["orient"]) == 0)
										{
											textBranchTool.TextProperty.Position = ePositionText.B;
										}
										((DrawingLayer)this.canvasControl_1.Layers.First<ICanvasLayer>()).AddObject(textBranchTool);
									}
								}
								foreach (DrawObjectBase drawObjectBase in enumerable)
								{
									ShinaTool shinaTool = (ShinaTool)drawObjectBase;
									if (shinaTool.Parent != null && (this.canvasControl_1.TypeCanvas != eTypeCanvas.SchemeMain || !(((RectangleTool)shinaTool.Parent).IdOldBase != points[0]["nom_group"].ToString())))
									{
										foreach (DrawObjectBase drawObjectBase2 in shinaTool.ChildObjects)
										{
											if (drawObjectBase2.GetType() == typeof(PointShinaTool))
											{
												if (drawObjectBase2.IdOldBase == pointTool.IdOldBase)
												{
													lineCellTool.RechangePointInBranch(lineCellTool.Branches[0], (PointShinaTool)drawObjectBase2, true);
												}
												if (drawObjectBase2.IdOldBase == pointTool2.IdOldBase)
												{
													lineCellTool.RechangePointInBranch(lineCellTool.Branches[0], (PointShinaTool)drawObjectBase2, false);
												}
											}
										}
									}
								}
								this.list_0.Add(Convert.ToInt32(dataRow["id_obj"]));
								this.backgroundWorker_0.ReportProgress((int)((float)this.list_0.Count / (float)dataTable_0.Rows.Count * 100f), " LineCell: ");
								this.stringBuilder_0.Append(dataRow["id_obj"].ToString() + ",");
								this.method_8(lineCellTool, dataTable_0, dataTable_1, pointTool, dataTable_2, dataTable_3);
								this.method_8(lineCellTool, dataTable_0, dataTable_1, pointTool2, dataTable_2, dataTable_3);
								using (List<PointTool>.Enumerator enumerator4 = lineCellTool.GetPointsList().GetEnumerator())
								{
									while (enumerator4.MoveNext())
									{
										PointTool pointTool3 = enumerator4.Current;
										if (pointTool3.TextProperty.Visible && pointTool3.Text != "")
										{
											lineCellTool.Text = pointTool3.Text;
											lineCellTool.TextProperty.Visible = true;
											lineCellTool.TextProperty.Position = pointTool3.TextProperty.Position;
											break;
										}
									}
									goto IL_BD6;
								}
								goto IL_BAD;
								IL_BB4:
								this.canvasControl_1.AddObject(this.canvasControl_1.Layers.First<ICanvasLayer>(), lineCellTool);
								continue;
								IL_BD6:
								if (this.canvasControl_1.ValidateToUnique(lineCellTool))
								{
									goto IL_BB4;
								}
								IL_BAD:
								lineCellTool.CreateUniqueCopyName();
								goto IL_BB4;
							}
						}
					}
				}
			}
		}

		private void method_8(LineCellTool lineCellTool_0, DataTable dataTable_0, DataTable dataTable_1, PointTool pointTool_0, DataTable dataTable_2, DataTable dataTable_3)
		{
			IEnumerable<DrawObjectBase> enumerable = from obj in this.canvasControl_1.Layers.First<ICanvasLayer>().Objects
			where obj.GetType() == typeof(ShinaTool)
			select obj;
			string text = this.stringBuilder_0.ToString();
			if (text.Length > 0)
			{
				text = text.Remove(text.Length - 1);
			}
			string filterExpression;
			if (text.Length > 0)
			{
				filterExpression = string.Concat(new string[]
				{
					"(id_point1 = ",
					pointTool_0.IdOldBase,
					" or id_point2 = ",
					pointTool_0.IdOldBase,
					") and  id_obj not in (",
					text,
					")"
				});
			}
			else
			{
				filterExpression = "id_point1 = " + pointTool_0.IdOldBase + " or id_point2 = " + pointTool_0.IdOldBase;
			}
			DataRow[] array = dataTable_0.Select(filterExpression);
			if (array.Length == 0)
			{
				return;
			}
			foreach (DataRow dataRow in array)
			{
				if (!this.list_0.Contains(Convert.ToInt32(dataRow["id_obj"])))
				{
					DataRow[] array3 = null;
					if (dataRow["id_point1"].ToString() == pointTool_0.IdOldBase)
					{
						array3 = dataTable_1.Select("id_obj = " + dataRow["id_point2"].ToString());
					}
					if (dataRow["id_point2"].ToString() == pointTool_0.IdOldBase)
					{
						array3 = dataTable_1.Select("id_obj = " + dataRow["id_point1"].ToString());
					}
					PointTool pointTool = new PointTool((DrawingLayer)this.canvasControl_1.Layers.First<ICanvasLayer>());
					if (array3 != null && array3.Length != 0)
					{
						float num = Convert.ToSingle(array3[0]["x_coord"]) / 96f * 2.54f;
						float num2 = -(Convert.ToSingle(array3[0]["y_coord"]) / 96f) * 2.54f;
						pointTool.Point = new UnitPoint((double)num, (double)num2);
						pointTool.IdOldBase = array3[0]["id_obj"].ToString();
						if (Convert.ToInt32(array3[0]["orient_name"]) == 0)
						{
							pointTool.TextProperty.Visible = false;
						}
						else
						{
							pointTool.Text = array3[0]["name"].ToString();
							pointTool.TextProperty.Visible = true;
							if (Convert.ToInt32(array3[0]["orient_name"]) != 1)
							{
								if (Convert.ToInt32(array3[0]["orient_name"]) != 2)
								{
									if (Convert.ToInt32(array3[0]["orient_name"]) != 3)
									{
										if (Convert.ToInt32(array3[0]["orient_name"]) != 4)
										{
											if (Convert.ToInt32(array3[0]["orient_name"]) != 5)
											{
												if (Convert.ToInt32(array3[0]["orient_name"]) != 6)
												{
													if (Convert.ToInt32(array3[0]["orient_name"]) == 7 || Convert.ToInt32(array3[0]["orient_name"]) == 8)
													{
														pointTool.TextProperty.Position = ePositionText.B;
														goto IL_37D;
													}
													goto IL_37D;
												}
											}
											pointTool.TextProperty.Position = ePositionText.R;
											goto IL_37D;
										}
									}
									pointTool.TextProperty.Position = ePositionText.T;
									goto IL_37D;
								}
							}
							pointTool.TextProperty.Position = ePositionText.L;
						}
						IL_37D:
						if (Convert.ToInt32(dataRow["vid"]) == 2)
						{
							lineCellTool_0.AddBranch(pointTool_0, pointTool, BranchType.AirLine);
						}
						else
						{
							lineCellTool_0.AddBranch(pointTool_0, pointTool);
						}
						foreach (DataRow dataRow2 in dataTable_2.Select("id_line = " + dataRow["id_obj"].ToString()))
						{
							TypeSwitch typeSwitch = TypeSwitch.LinearDisconnectorTool;
							switch (Convert.ToInt32(dataRow2["type"]))
							{
							case 1:
								if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
								{
									typeSwitch = TypeSwitch.LinearDisconnectorTool;
								}
								else
								{
									typeSwitch = TypeSwitch.TransformerTool;
								}
								break;
							case 2:
								typeSwitch = TypeSwitch.LoadSwitchTool;
								break;
							case 3:
								if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
								{
									typeSwitch = TypeSwitch.LubricantSwitchTool;
								}
								else
								{
									typeSwitch = TypeSwitch.LinearDisconnectorTool;
								}
								break;
							case 4:
								if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
								{
									typeSwitch = TypeSwitch.DamageTool;
								}
								else
								{
									typeSwitch = TypeSwitch.FuseTool;
								}
								break;
							case 5:
								if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
								{
									typeSwitch = TypeSwitch.GroundingTool;
								}
								else
								{
									typeSwitch = TypeSwitch.LinearDisconnectorTool;
								}
								break;
							case 6:
								typeSwitch = TypeSwitch.FuseTool;
								break;
							case 8:
								if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
								{
									typeSwitch = TypeSwitch.OutsideLineDisconnectorTool;
								}
								else
								{
									typeSwitch = TypeSwitch.EndTrimTool;
								}
								break;
							case 10:
								typeSwitch = TypeSwitch.VacuumSwitchTool;
								break;
							}
							ObjectOnLine objectOnLine = lineCellTool_0.Branches[lineCellTool_0.Branches.Count - 1].AddSwitchTool(typeSwitch, (double)Convert.ToSingle(dataRow2["Place"]));
							objectOnLine.Layer = (DrawingLayer)this.canvasControl_1.Layers.First<ICanvasLayer>();
							objectOnLine.Text = "Выключатель";
							if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
							{
								if (Convert.ToInt32(dataRow2["KEY_ON"]) == 1)
								{
									objectOnLine.On = true;
								}
								objectOnLine.IsNormalSection = true;
								switch (Convert.ToInt32(dataRow2["KEY_NORMAL"]))
								{
								case 0:
									objectOnLine.IsNormalSection = false;
									break;
								case 1:
									objectOnLine.TextPropertyNormalSection.Position = ePositionText.L;
									break;
								case 2:
									objectOnLine.TextPropertyNormalSection.Position = ePositionText.T;
									break;
								case 3:
									objectOnLine.TextPropertyNormalSection.Position = ePositionText.R;
									break;
								case 4:
									objectOnLine.TextPropertyNormalSection.Position = ePositionText.B;
									break;
								}
							}
							else
							{
								objectOnLine.On = true;
							}
							if (!this.canvasControl_1.ValidateToUnique(objectOnLine))
							{
								objectOnLine.CreateUniqueCopyName();
							}
							((DrawingLayer)this.canvasControl_1.Layers.First<ICanvasLayer>()).AddObject(objectOnLine);
						}
						if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeSecond)
						{
							foreach (DataRow dataRow3 in dataTable_3.Select("id_line = " + dataRow["id_obj"].ToString()))
							{
								TextBranchTool textBranchTool = new TextBranchTool();
								textBranchTool.Parent = lineCellTool_0.Branches[lineCellTool_0.Branches.Count - 1];
								textBranchTool.Layer = (DrawingLayer)this.canvasControl_1.Layers.First<ICanvasLayer>();
								textBranchTool.IdOldBase = dataRow3["id_obj"].ToString();
								textBranchTool.Text = dataRow3["text"].ToString();
								if (Convert.ToInt32(dataRow3["orient"]) == 0)
								{
									textBranchTool.TextProperty.Position = ePositionText.B;
								}
								((DrawingLayer)this.canvasControl_1.Layers.First<ICanvasLayer>()).AddObject(textBranchTool);
							}
						}
						foreach (DrawObjectBase drawObjectBase in enumerable)
						{
							ShinaTool shinaTool = (ShinaTool)drawObjectBase;
							if (shinaTool.Parent != null && (this.canvasControl_1.TypeCanvas != eTypeCanvas.SchemeMain || !(((RectangleTool)shinaTool.Parent).IdOldBase != array3[0]["nom_group"].ToString())))
							{
								foreach (DrawObjectBase drawObjectBase2 in shinaTool.ChildObjects)
								{
									if (drawObjectBase2.GetType() == typeof(PointShinaTool) && drawObjectBase2.IdOldBase == pointTool.IdOldBase)
									{
										lineCellTool_0.RechangePointInBranch(lineCellTool_0.Branches[lineCellTool_0.Branches.Count - 1], (PointShinaTool)drawObjectBase2, false);
									}
								}
							}
						}
						this.list_0.Add(Convert.ToInt32(dataRow["id_obj"]));
						this.backgroundWorker_0.ReportProgress((int)((float)this.list_0.Count / (float)dataTable_0.Rows.Count * 100f), " LineCell: ");
						this.stringBuilder_0.Append(dataRow["id_obj"].ToString() + ",");
						lineCellTool_0.UseSettingColor = false;
						lineCellTool_0.Color = Color.Green;
						this.method_8(lineCellTool_0, dataTable_0, dataTable_1, pointTool, dataTable_2, dataTable_3);
					}
				}
			}
		}

		private void method_9(DataTable dataTable_0, DataTable dataTable_1, DataTable dataTable_2)
		{
			IEnumerable<DrawObjectBase> enumerable = from obj in this.canvasScheme.Layers.First<ICanvasLayer>().Objects
			where obj.GetType() == typeof(LineCellTool)
			select obj;
			from obj in this.canvasScheme.Layers.First<ICanvasLayer>().Objects
			where obj.GetType() == typeof(ShinaTool)
			select obj;
			foreach (object obj2 in dataTable_0.Rows)
			{
				DataRow dataRow = (DataRow)obj2;
				if (!this.list_0.Contains(Convert.ToInt32(dataRow["id_obj"])))
				{
					LineTool lineTool = new LineTool();
					DataRow[] array = dataTable_1.Select("id_obj = " + dataRow["id_point1"].ToString());
					PointTool pointTool = new PointTool((DrawingLayer)this.canvasScheme.Layers.First<ICanvasLayer>());
					if (array.Length != 0)
					{
						float num = Convert.ToSingle(array[0]["x_coord"]) / 96f * 2.54f;
						float num2 = -(Convert.ToSingle(array[0]["y_coord"]) / 96f) * 2.54f;
						pointTool.Point = new UnitPoint((double)num, (double)num2);
						pointTool.IdOldBase = array[0]["id_obj"].ToString();
						array = dataTable_1.Select("id_obj = " + dataRow["id_point2"].ToString());
						PointTool pointTool2 = new PointTool((DrawingLayer)this.canvasScheme.Layers.First<ICanvasLayer>());
						if (array.Length != 0)
						{
							float num3 = Convert.ToSingle(array[0]["x_coord"]) / 96f * 2.54f;
							float num4 = -(Convert.ToSingle(array[0]["y_coord"]) / 96f) * 2.54f;
							pointTool2.Point = new UnitPoint((double)num3, (double)num4);
							pointTool2.IdOldBase = array[0]["id_obj"].ToString();
							if (Convert.ToInt32(dataRow["vid"]) == 2)
							{
								lineTool.AddBranch(pointTool, pointTool2, BranchType.AirLine);
							}
							else
							{
								lineTool.AddBranch(pointTool, pointTool2);
							}
							lineTool.Layer = (DrawingLayer)this.canvasScheme.Layers.First<ICanvasLayer>();
							lineTool.Text = lineTool.ToString();
							if (!this.canvasScheme.ValidateToUnique(lineTool))
							{
								lineTool.CreateUniqueCopyName();
							}
							foreach (DataRow dataRow2 in dataTable_2.Select("id_line = " + dataRow["id_obj"].ToString()))
							{
								TypeSwitch typeSwitch = TypeSwitch.LinearDisconnectorTool;
								switch (Convert.ToInt32(dataRow2["type"]))
								{
								case 1:
									typeSwitch = TypeSwitch.LinearDisconnectorTool;
									break;
								case 2:
									typeSwitch = TypeSwitch.LoadSwitchTool;
									break;
								case 3:
									typeSwitch = TypeSwitch.LubricantSwitchTool;
									break;
								case 4:
									typeSwitch = TypeSwitch.DamageTool;
									break;
								case 5:
									typeSwitch = TypeSwitch.GroundingTool;
									break;
								case 8:
									typeSwitch = TypeSwitch.OutsideLineDisconnectorTool;
									break;
								case 10:
									typeSwitch = TypeSwitch.VacuumSwitchTool;
									break;
								}
								ObjectOnLine objectOnLine = lineTool.Branches[lineTool.Branches.Count - 1].AddSwitchTool(typeSwitch, (double)Convert.ToSingle(dataRow2["Place"]));
								objectOnLine.Layer = (DrawingLayer)this.canvasScheme.Layers.First<ICanvasLayer>();
								objectOnLine.Text = "Выключатель";
								if (Convert.ToInt32(dataRow2["KEY_ON"]) == 1)
								{
									objectOnLine.On = true;
								}
								objectOnLine.IsNormalSection = true;
								switch (Convert.ToInt32(dataRow2["KEY_NORMAL"]))
								{
								case 0:
									objectOnLine.IsNormalSection = false;
									break;
								case 1:
									objectOnLine.TextPropertyNormalSection.Position = ePositionText.L;
									break;
								case 2:
									objectOnLine.TextPropertyNormalSection.Position = ePositionText.T;
									break;
								case 3:
									objectOnLine.TextPropertyNormalSection.Position = ePositionText.R;
									break;
								case 4:
									objectOnLine.TextPropertyNormalSection.Position = ePositionText.B;
									break;
								}
								if (!this.canvasScheme.ValidateToUnique(objectOnLine))
								{
									objectOnLine.CreateUniqueCopyName();
								}
								((DrawingLayer)this.canvasScheme.Layers.First<ICanvasLayer>()).AddObject(objectOnLine);
							}
							bool flag = false;
							bool flag2 = false;
							foreach (DrawObjectBase drawObjectBase in enumerable)
							{
								PointTool[] array3 = ((LineCellTool)drawObjectBase).Ends.ToArray<PointTool>();
								for (int j = 0; j < array3.Length; j++)
								{
									if (array3[j].IdOldBase == pointTool.IdOldBase)
									{
										lineTool.RechangePointInBranch(lineTool.Branches[0], array3[j], true);
										flag = true;
									}
									if (array3[j].IdOldBase == pointTool2.IdOldBase)
									{
										lineTool.RechangePointInBranch(lineTool.Branches[0], array3[j], false);
										flag2 = true;
									}
								}
							}
							this.list_0.Add(Convert.ToInt32(dataRow["id_obj"]));
							this.backgroundWorker_0.ReportProgress((int)((float)this.list_0.Count / (float)dataTable_0.Rows.Count * 100f), " Line: ");
							this.stringBuilder_0.Append(dataRow["id_obj"].ToString() + ",");
							if (!flag)
							{
								this.method_10(lineTool, dataTable_0, dataTable_1, pointTool, dataTable_2);
							}
							if (!flag2)
							{
								this.method_10(lineTool, dataTable_0, dataTable_1, pointTool2, dataTable_2);
							}
							lineTool.Text = lineTool.ToString();
							if (!this.canvasScheme.ValidateToUnique(lineTool))
							{
								lineTool.CreateUniqueCopyName();
							}
							lineTool.Validation();
							this.canvasScheme.AddObject(this.canvasScheme.Layers.First<ICanvasLayer>(), lineTool);
						}
					}
				}
			}
		}

		private void method_10(LineTool lineTool_0, DataTable dataTable_0, DataTable dataTable_1, PointTool pointTool_0, DataTable dataTable_2)
		{
			from obj in this.canvasScheme.Layers.First<ICanvasLayer>().Objects
			where obj.GetType() == typeof(ShinaTool)
			select obj;
			IEnumerable<DrawObjectBase> enumerable = from obj in this.canvasScheme.Layers.First<ICanvasLayer>().Objects
			where obj.GetType() == typeof(LineCellTool)
			select obj;
			string text = this.stringBuilder_0.ToString();
			if (text.Length > 0)
			{
				text = text.Remove(text.Length - 1);
			}
			string filterExpression;
			if (text.Length > 0)
			{
				filterExpression = string.Concat(new string[]
				{
					"(id_point1 = ",
					pointTool_0.IdOldBase,
					" or id_point2 = ",
					pointTool_0.IdOldBase,
					") and  id_obj not in (",
					text,
					")"
				});
			}
			else
			{
				filterExpression = "id_point1 = " + pointTool_0.IdOldBase + " or id_point2 = " + pointTool_0.IdOldBase;
			}
			DataRow[] array = dataTable_0.Select(filterExpression);
			if (array.Length == 0)
			{
				return;
			}
			foreach (DataRow dataRow in array)
			{
				if (!this.list_0.Contains(Convert.ToInt32(dataRow["id_obj"])))
				{
					DataRow[] array3 = null;
					if (dataRow["id_point1"].ToString() == pointTool_0.IdOldBase)
					{
						array3 = dataTable_1.Select("id_obj = " + dataRow["id_point2"].ToString());
					}
					if (dataRow["id_point2"].ToString() == pointTool_0.IdOldBase)
					{
						array3 = dataTable_1.Select("id_obj = " + dataRow["id_point1"].ToString());
					}
					PointTool pointTool = new PointTool((DrawingLayer)this.canvasScheme.Layers.First<ICanvasLayer>());
					if (array3 != null && array3.Length != 0)
					{
						float num = Convert.ToSingle(array3[0]["x_coord"]) / 96f * 2.54f;
						float num2 = -(Convert.ToSingle(array3[0]["y_coord"]) / 96f) * 2.54f;
						pointTool.Point = new UnitPoint((double)num, (double)num2);
						pointTool.IdOldBase = array3[0]["id_obj"].ToString();
						bool flag = false;
						using (List<Branch>.Enumerator enumerator = lineTool_0.Branches.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Branch branch = enumerator.Current;
								if (branch.Source.IdOldBase == pointTool.IdOldBase || branch.Destination.IdOldBase == pointTool.IdOldBase)
								{
									flag = true;
									break;
								}
							}
							goto IL_632;
						}
						IL_2E2:
						if (Convert.ToInt32(dataRow["vid"]) == 2)
						{
							lineTool_0.AddBranch(pointTool_0, pointTool, BranchType.AirLine);
						}
						else
						{
							lineTool_0.AddBranch(pointTool_0, pointTool);
						}
						foreach (DataRow dataRow2 in dataTable_2.Select("id_line = " + dataRow["id_obj"].ToString()))
						{
							TypeSwitch typeSwitch = TypeSwitch.LinearDisconnectorTool;
							switch (Convert.ToInt32(dataRow2["type"]))
							{
							case 1:
								typeSwitch = TypeSwitch.LinearDisconnectorTool;
								break;
							case 2:
								typeSwitch = TypeSwitch.LoadSwitchTool;
								break;
							case 3:
								typeSwitch = TypeSwitch.LubricantSwitchTool;
								break;
							case 4:
								typeSwitch = TypeSwitch.DamageTool;
								break;
							case 5:
								typeSwitch = TypeSwitch.GroundingTool;
								break;
							case 8:
								typeSwitch = TypeSwitch.OutsideLineDisconnectorTool;
								break;
							case 10:
								typeSwitch = TypeSwitch.VacuumSwitchTool;
								break;
							}
							ObjectOnLine objectOnLine = lineTool_0.Branches[lineTool_0.Branches.Count - 1].AddSwitchTool(typeSwitch, (double)Convert.ToSingle(dataRow2["Place"]));
							objectOnLine.Layer = (DrawingLayer)this.canvasScheme.Layers.First<ICanvasLayer>();
							objectOnLine.Text = "Выключатель";
							if (Convert.ToInt32(dataRow2["KEY_ON"]) == 1)
							{
								objectOnLine.On = true;
							}
							objectOnLine.IsNormalSection = true;
							switch (Convert.ToInt32(dataRow2["KEY_NORMAL"]))
							{
							case 0:
								objectOnLine.IsNormalSection = false;
								break;
							case 1:
								objectOnLine.TextPropertyNormalSection.Position = ePositionText.L;
								break;
							case 2:
								objectOnLine.TextPropertyNormalSection.Position = ePositionText.T;
								break;
							case 3:
								objectOnLine.TextPropertyNormalSection.Position = ePositionText.R;
								break;
							case 4:
								objectOnLine.TextPropertyNormalSection.Position = ePositionText.B;
								break;
							}
							if (!this.canvasScheme.ValidateToUnique(objectOnLine))
							{
								objectOnLine.CreateUniqueCopyName();
							}
							((DrawingLayer)this.canvasScheme.Layers.First<ICanvasLayer>()).AddObject(objectOnLine);
						}
						bool flag2 = false;
						using (IEnumerator<DrawObjectBase> enumerator2 = enumerable.GetEnumerator())
						{
							IL_578:
							while (enumerator2.MoveNext())
							{
								DrawObjectBase drawObjectBase = enumerator2.Current;
								PointTool[] array5 = ((LineCellTool)drawObjectBase).Ends.ToArray<PointTool>();
								int k = 0;
								while (k < array5.Length)
								{
									if (!(array5[k].IdOldBase == pointTool.IdOldBase))
									{
										k++;
									}
									else
									{
										lineTool_0.RechangePointInBranch(lineTool_0.Branches[lineTool_0.Branches.Count - 1], array5[k], false);
										flag2 = true;
										IL_574:
										if (!flag2)
										{
											goto IL_578;
										}
										goto IL_591;
									}
								}
								goto IL_574;
							}
						}
						IL_591:
						this.list_0.Add(Convert.ToInt32(dataRow["id_obj"]));
						this.backgroundWorker_0.ReportProgress((int)((float)this.list_0.Count / (float)dataTable_0.Rows.Count * 100f), " Line: ");
						this.stringBuilder_0.Append(dataRow["id_obj"].ToString() + ",");
						lineTool_0.UseSettingColor = false;
						lineTool_0.Color = Color.Green;
						if (!flag2)
						{
							this.method_10(lineTool_0, dataTable_0, dataTable_1, pointTool, dataTable_2);
							goto IL_627;
						}
						goto IL_627;
						IL_632:
						if (!flag)
						{
							goto IL_2E2;
						}
					}
				}
				IL_627:;
			}
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			this.canvasScheme.undoRedoManager.SaveChanges = false;
			this.method_1(e.Argument.ToString());
		}

		private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.toolStripProgressBar_0.Value = e.ProgressPercentage;
		}

		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.canvasScheme.Enabled = true;
			this.toolStrip_0.Enabled = true;
			this.canvasScheme.undoRedoManager.SaveChanges = true;
			this.canvasScheme.DoInvalidate(true);
		}

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool FlashWindow(IntPtr intptr_0, bool bool_5);

		public FormGeneralScheme2()
		{
			
			this.list_0 = new List<int>();
			this.stringBuilder_0 = new StringBuilder();
			this.idInitActiveObj = -1;
			this.typeCanvas = eTypeCanvas.SchemeMain;
			this.eSimulationMode = eSimulationMode.Online;
			this.canvasScheme = new CanvasControl();
			this.dictionary_0 = new Dictionary<DrawObjectBase, CanvasControl>();
			this.dictionary_1 = new Dictionary<IDockContent, List<TreeNode>>();
			this.opcClient = new OPCClient();
			this.list_2 = new List<string>();
			this.dictionary_2 = new Dictionary<DockContentBase, int>();
			
			this.InitializeComponent();
			this.InitForm();
		}

		public FormGeneralScheme2(SQLSettings sqlSettings)
		{
			
			this.list_0 = new List<int>();
			this.stringBuilder_0 = new StringBuilder();
			this.idInitActiveObj = -1;
			this.typeCanvas = eTypeCanvas.SchemeMain;
			this.eSimulationMode = eSimulationMode.Online;
			this.canvasScheme = new CanvasControl();
			this.dictionary_0 = new Dictionary<DrawObjectBase, CanvasControl>();
			this.dictionary_1 = new Dictionary<IDockContent, List<TreeNode>>();
			this.opcClient = new OPCClient();
			this.list_2 = new List<string>();
			this.dictionary_2 = new Dictionary<DockContentBase, int>();
			
			this.InitializeComponent();
			this.SqlSettings = sqlSettings;
			this.InitForm();
		}

		public FormGeneralScheme2(SQLSettings sqlSettings, EndpointAddress endPoint, int a)
		{
			
			this.list_0 = new List<int>();
			this.stringBuilder_0 = new StringBuilder();
			this.idInitActiveObj = -1;
			this.typeCanvas = eTypeCanvas.SchemeMain;
			this.eSimulationMode = eSimulationMode.Online;
			this.canvasScheme = new CanvasControl();
			this.dictionary_0 = new Dictionary<DrawObjectBase, CanvasControl>();
			this.dictionary_1 = new Dictionary<IDockContent, List<TreeNode>>();
			this.opcClient = new OPCClient();
			this.list_2 = new List<string>();
			this.dictionary_2 = new Dictionary<DockContentBase, int>();
			
			this.InitializeComponent();
			this.endPoint = endPoint;
			this.SqlSettings = sqlSettings;
			this.InitForm();
		}

		public FormGeneralScheme2(SQLSettings sqlSettings, int simulationMode, int a)
		{
			
			this.list_0 = new List<int>();
			this.stringBuilder_0 = new StringBuilder();
			this.idInitActiveObj = -1;
			this.typeCanvas = eTypeCanvas.SchemeMain;
			this.eSimulationMode = eSimulationMode.Online;
			this.canvasScheme = new CanvasControl();
			this.dictionary_0 = new Dictionary<DrawObjectBase, CanvasControl>();
			this.dictionary_1 = new Dictionary<IDockContent, List<TreeNode>>();
			this.opcClient = new OPCClient();
			this.list_2 = new List<string>();
			this.dictionary_2 = new Dictionary<DockContentBase, int>();
			
			this.InitializeComponent();
			try
			{
			}
			catch (Exception innerException)
			{
				throw new Exception("Неверный параметр", innerException);
			}
			this.SqlSettings = sqlSettings;
			this.eSimulationMode = (eSimulationMode)simulationMode;
			this.InitForm();
		}

		public FormGeneralScheme2(eTypeCanvas typeCanvas, int activeObj)
		{
			
			this.list_0 = new List<int>();
			this.stringBuilder_0 = new StringBuilder();
			this.idInitActiveObj = -1;
			this.typeCanvas = eTypeCanvas.SchemeMain;
			this.eSimulationMode = eSimulationMode.Online;
			this.canvasScheme = new CanvasControl();
			this.dictionary_0 = new Dictionary<DrawObjectBase, CanvasControl>();
			this.dictionary_1 = new Dictionary<IDockContent, List<TreeNode>>();
			this.opcClient = new OPCClient();
			this.list_2 = new List<string>();
			this.dictionary_2 = new Dictionary<DockContentBase, int>();
			
			this.InitializeComponent();
			this.InitForm();
			this.idInitActiveObj = activeObj;
			this.typeCanvas = typeCanvas;
		}

		private void InitForm()
		{
			GeneralFormSettings.SizeIconChanged(new EventHandler(this.GeneralFormSettings_SizeIconChanged));
			GeneralFormSettings.FontSizeChanged(new EventHandler(this.GeneralFormSettings_FontSizeChanged));
			DockContentBase dockContentBase = new DockContentBase();
			dockContentBase.SqlSettings = this.SqlSettings;
			dockContentBase.Controls.Add(this.canvasScheme);
			this.canvasScheme.Dock = DockStyle.Fill;
			if (this.SqlSettings != null)
			{
				this.canvasScheme.SqlSettings = this.SqlSettings;
			}
			if (this.endPoint != null)
			{
				this.canvasScheme.Endpoint = this.endPoint;
			}
			dockContentBase.DockAreas = 32; //DockAreas.Document
            dockContentBase.CloseButtonVisible = false;
			if (this.eSimulationMode == eSimulationMode.Online)
			{
				dockContentBase.Text = "Оперативная схема";
			}
			else if (this.eSimulationMode == eSimulationMode.Normal)
			{
				dockContentBase.Text = "Нормальная схема";
			}
			this.canvasScheme.CanvasModeChanged += this.canvasScheme_CanvasModeChanged;
			this.canvasScheme.TypeCanvas = this.typeCanvas;
			this.canvasScheme.SimulationMode = this.eSimulationMode;
			this.canvasScheme.ShowContextMenuCanvasEvent += this.canvasScheme_ShowContextMenuCanvasEvent;
			this.canvasScheme.HideContextMenuCanvasEvent += this.canvasControl_0_HideContextMenuCanvasEvent;
			this.canvasScheme.ObjectsAdded += this.canvasScheme_ObjectsAdded;
			this.canvasScheme.ObjectClicked += this.canvasScheme_ObjectClicked;
			this.canvasScheme.FlashObjectsAdded += this.canvasControl_0_FlashObjectsAdded;
			this.canvasScheme.FlashObjectsRemoved += this.canvasControl_0_FlashObjectsRemoved;
			this.canvasScheme.ContextMenuRectangle = this.contextMenuStrip_0;
			this.canvasControl_1 = this.canvasScheme;
			this.dockPanel_0.ActiveDocumentChanged += this.dockPanel_0_ActiveDocumentChanged;
			dockContentBase.ShowForm += this.method_12;
			dockContentBase.Show(this.dockPanel_0);
			if (this.canvasScheme.Layers.Count<ICanvasLayer>() <= 0)
			{
				DrawingLayer drawingLayer = new DrawingLayer("defaultLayer", "Default Layer", Color.White, 0f);
				drawingLayer.Parent = this.canvasScheme;
				this.canvasScheme.AddLayer(drawingLayer);
			}
			this.toolStrip_1.Location = new Point(0, 0);
			this.toolStrip_2.Location = new Point(this.toolStrip_1.Right, 0);
			this.toolStrip_3.Location = new Point(this.toolStrip_2.Right, 0);
			this.toolStrip_4.Location = new Point(0, this.toolStrip_1.Bottom);
			this.toolStrip_0.Location = new Point(this.toolStrip_4.Right, this.toolStrip_1.Bottom);
			this.toolStrip_5.Location = new Point(this.toolStrip_0.Right, this.toolStrip_1.Bottom);
		}

		private FormBase method_12(object object_0, ShowFormEventArgs showFormEventArgs_0)
		{
			return this.OnShowForm(showFormEventArgs_0);
		}

		private void method_13()
		{
		}

		private void canvasScheme_CanvasModeChanged(object sender, EventArgs e)
		{
		}

		private bool method_14()
		{
			Class19 @class = new Class19();
			base.SelectSqlData(@class, @class.vUserInGroup, true, " where Login = SYSTEM_USER ");
			return @class.vUserInGroup.Rows.Count > 0 && @class.vUserInGroup.Rows[0]["nameGroup"].ToString() == "ОДС";
		}

		private void GeneralFormSettings_FontSizeChanged(object sender, EventArgs e)
		{
			this.Font = new Font(this.Font.Name, GeneralFormSettings.FontSize);
		}

		private void GeneralFormSettings_SizeIconChanged(object sender, EventArgs e)
		{
			this.toolStrip_2.ImageScalingSize = GeneralFormSettings.SizeIcon;
			Point location = this.toolStrip_2.Location;
			this.toolStrip_2.Scale(new SizeF(2f, 2f));
			this.toolStrip_2.Location = location;
			this.toolStrip_3.ImageScalingSize = GeneralFormSettings.SizeIcon;
			location = this.toolStrip_3.Location;
			this.toolStrip_3.Scale(new SizeF(2f, 2f));
			this.toolStrip_3.Location = location;
			this.toolStrip_0.ImageScalingSize = GeneralFormSettings.SizeIcon;
			location = this.toolStrip_0.Location;
			this.toolStrip_0.Scale(new SizeF(2f, 2f));
			this.toolStrip_0.Location = location;
			this.toolStrip_1.ImageScalingSize = GeneralFormSettings.SizeIcon;
			location = this.toolStrip_1.Location;
			this.toolStrip_1.Scale(new SizeF(2f, 2f));
			this.toolStrip_1.Location = location;
			this.toolStrip_4.ImageScalingSize = GeneralFormSettings.SizeIcon;
			location = this.toolStrip_4.Location;
			this.toolStrip_4.Scale(new SizeF(2f, 2f));
			this.toolStrip_4.Location = location;
			this.toolStrip_5.ImageScalingSize = GeneralFormSettings.SizeIcon;
			location = this.toolStrip_5.Location;
			this.toolStrip_5.Scale(new SizeF(2f, 2f));
			this.toolStrip_5.Location = location;
		}

		private void FormGeneralScheme2_Load(object sender, EventArgs e)
		{
			if (this.method_14())
			{
				this.toolStripComboBox_0.SelectedIndex = 1;
				this.toolStripComboBox_1.SelectedIndex = 1;
			}
			else
			{
				this.toolStripComboBox_0.SelectedIndex = 0;
				this.toolStripComboBox_1.SelectedIndex = 0;
			}
			this.toolStripButton_49.Visible = false;
			this.canvasScheme.SqlSettings = this.SqlSettings;
			this.canvasScheme.undoRedoManager.SaveChanges = false;
			this.canvasScheme.SimulationMode = this.eSimulationMode;
			this.canvasScheme.TypeCanvas = this.typeCanvas;
			this.canvasScheme.UseObjectFromDB = true;
			this.canvasScheme.SchemeName = "Schema1";
			this.bool_1 = true;
			this.canvasScheme.SaveProcessChanged += this.canvasControl_0_SaveProcessChanged;
			this.canvasScheme.CanvasMessage += this.canvasControl_0_CanvasMessage;
			this.canvasScheme.SelectedObjectMoved += this.canvasControl_0_SelectedObjectMoved;
			this.canvasScheme.SelectedObjectEdited += this.canvasControl_0_SelectedObjectEdited;
			this.canvasScheme.DrawingCompleted += this.canvasControl_0_DrawingCompleted;
			this.canvasScheme.StateAdded += this.canvasControl_0_StateAdded;
			this.canvasScheme.StateRemoved += this.canvasControl_0_StateRemoved;
			this.canvasScheme.ObjectOnLinePropertyOnCanged += this.canvasControl_0_ObjectOnLinePropertyOnCanged;
			this.method_37();
			this.method_16(false);
			this.canvasScheme.UpdateMeasurementForBus();
		}

		private void method_16(bool bool_5)
		{
			this.toolStrip_0.Enabled = false;
			this.toolStripContainer_0.Enabled = false;
			this.canvasScheme.Enabled = false;
			this.panel_0.Left = base.ClientSize.Width / 2 - this.progressBarEndLess_0.Width / 2;
			this.panel_0.Top = base.ClientSize.Height / 2 - this.progressBarEndLess_0.Height / 2;
			this.panel_0.Visible = true;
			this.progressBarEndLess_0.AutoProgress = true;
			if (bool_5)
			{
				this.method_39();
				this.method_36();
				this.dictionary_1.Remove((IDockContent)this.canvasScheme.Parent);
			}
			this.backgroundWorker_1.RunWorkerAsync(bool_5);
		}

		private void canvasControl_0_ObjectOnLinePropertyOnCanged(object sender, EventArgs e)
		{
			if (this.class12_0 == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)sender;
			if (objectOnLine.On)
			{
				if (!objectOnLine.IsNormalSection)
				{
					this.class12_0.method_10((ObjectOnLine)sender);
					return;
				}
				this.class12_0.method_9((ObjectOnLine)sender);
				return;
			}
			else
			{
				if (objectOnLine.IsNormalSection)
				{
					this.class12_0.method_10((ObjectOnLine)sender);
					return;
				}
				this.class12_0.method_9((ObjectOnLine)sender);
				return;
			}
		}

		private void canvasControl_0_StateRemoved(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
			if (this.class12_0 == null)
			{
				return;
			}
			this.class12_0.method_8(lineToolEventArgs_0.state);
		}

		private void canvasControl_0_StateAdded(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
			if (this.class12_0 != null)
			{
				this.class12_0.method_6(lineToolEventArgs_0.state);
			}
		}

		private void method_17(UndoRedoManager.TypeAction typeAction_0, bool bool_5)
		{
			if (typeAction_0 == UndoRedoManager.TypeAction.Undo)
			{
				this.toolStripButton_33.Enabled = bool_5;
				return;
			}
			this.toolStripButton_34.Enabled = bool_5;
		}

		private void FormGeneralScheme2_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.canvasScheme.WorkerCounter <= 0 && !this.bool_1)
			{
				GeneralFormSettings.smethod_1(new EventHandler(this.GeneralFormSettings_SizeIconChanged));
				GeneralFormSettings.smethod_3(new EventHandler(this.GeneralFormSettings_FontSizeChanged));
				base.SaveFormConfig(null);
				this.OPCDisconnect();
				if (this.thread_0 != null && this.thread_0.IsAlive)
				{
					this.thread_0.Abort();
				}
			}
			else
			{
				this.bool_0 = true;
				base.Enabled = false;
				e.Cancel = true;
			}
			this.method_51();
		}

		private void FormGeneralScheme2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return && (e.Modifiers == Keys.Alt || e.Modifiers == Keys.Control))
			{
				if (base.FormBorderStyle != FormBorderStyle.None)
				{
					this.size_0 = base.Size;
					this.formWindowState_0 = base.WindowState;
					this.point_0 = base.Location;
					this.form_0 = base.MdiParent;
					base.MdiParent = null;
					Screen[] allScreens = Screen.AllScreens;
					Rectangle bounds = Screen.PrimaryScreen.Bounds;
					if (e.Modifiers == Keys.Alt)
					{
						foreach (Screen screen in allScreens)
						{
							if (this.form_0.Left + 8 >= screen.Bounds.Left && this.form_0.Left + 8 <= screen.Bounds.Left + screen.Bounds.Width && this.form_0.Top + 8 >= screen.Bounds.Top && this.form_0.Top + 8 <= screen.Bounds.Top + screen.Bounds.Height)
							{
								bounds = screen.Bounds;
								base.Top = screen.Bounds.Top;
								base.Left = screen.Bounds.Left;
								IL_17D:
								base.FormBorderStyle = FormBorderStyle.None;
								base.Size = new Size(bounds.Width, bounds.Height);
								return;
							}
						}
						goto IL_17D;
					}
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					foreach (Screen screen2 in allScreens)
					{
						if (num > screen2.Bounds.Left)
						{
							num = screen2.Bounds.Left;
						}
						if (num2 > screen2.Bounds.Top)
						{
							num2 = screen2.Bounds.Top;
						}
						if (num3 < screen2.Bounds.Width)
						{
							num3 = screen2.Bounds.Width;
						}
						if (num4 < screen2.Bounds.Height)
						{
							num4 = screen2.Bounds.Height;
						}
					}
					base.FormBorderStyle = FormBorderStyle.None;
					base.Left = num;
					base.Top = num2;
					base.Size = new Size(num3 - num, num4 - num2);
					return;
				}
				else
				{
					base.FormBorderStyle = FormBorderStyle.Sizable;
					base.WindowState = this.formWindowState_0;
					base.Location = this.point_0;
					base.Size = this.size_0;
					base.MdiParent = this.form_0;
				}
			}
		}

		private void dockPanel_0_Resize(object sender, EventArgs e)
		{
			this.panel_0.Left = base.ClientSize.Width / 2 - this.progressBarEndLess_0.Width / 2;
			this.panel_0.Top = base.ClientSize.Height / 2 - this.progressBarEndLess_0.Height / 2;
		}

		private void backgroundWorker_1_DoWork(object sender, DoWorkEventArgs e)
		{
			eTypeCanvas eTypeCanvas = this.typeCanvas;
			if (eTypeCanvas != eTypeCanvas.SchemeMain)
			{
				if (eTypeCanvas == eTypeCanvas.SchemeSecond)
				{
					this.method_46();
				}
			}
			else
			{
				CanvasControl obj = this.canvasScheme;
				lock (obj)
				{
					this.canvasScheme.LoadScheme();
				}
			}
			e.Result = e.Argument;
		}

		private void backgroundWorker_1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			bool flag = (bool)e.Result;
			this.bool_1 = false;
			DrawObjectBase drawObjectBase = null;
			this.canvasScheme.Settings.LoadSchemeFromBase(this.canvasScheme.SqlSettings, eTypeCanvas.SchemeMain);
			this.method_55();
			if (!flag)
			{
				this.method_33();
				this.method_28();
				this.method_18();
				this.method_32();
			}
			else
			{
				this.method_36();
				this.method_34();
				this.method_21();
			}
			ClientManager.canvasControl = this.canvasScheme;
			if (!flag)
			{
				foreach (ICanvasLayer canvasLayer in this.canvasScheme.Layers)
				{
					foreach (DrawObjectBase drawObjectBase2 in ((DrawingLayer)canvasLayer).Objects)
					{
						if (this.idInitActiveObj > -1 && this.idInitActiveObj == drawObjectBase2.IdBase)
						{
							drawObjectBase = drawObjectBase2;
						}
					}
				}
				this.canvasScheme.undoRedoManager.SaveChanges = true;
				this.canvasScheme.undoRedoManager.CanUndoRedoEvent += this.method_17;
				base.LoadFormConfig(null);
				this.canvasScheme.UpdateAllTelemetryLabels();
			}
			this.class9_0.method_6("Загрузка завершена", 2, null);
			this.canvasScheme.OpcClient = this.opcClient;
			this.InitOPC();
			if (drawObjectBase != null)
			{
				this.canvasScheme.SetObjectsInCenterScreen(drawObjectBase, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
			}
			if (!flag)
			{
				this.method_50();
			}
			this.canvasScheme.Enabled = true;
			this.toolStrip_0.Enabled = true;
			this.panel_0.Visible = false;
			this.progressBarEndLess_0.AutoProgress = false;
			if (!flag)
			{
				FormGeneralScheme2.FlashWindow(base.MdiParent.Handle, true);
			}
			this.toolStripContainer_0.Enabled = true;
			if (this.bool_0)
			{
				base.Close();
			}
			this.canvasScheme.DoInvalidate(true);
		}

		private void method_18()
		{
			bool flag = false;
			if (this.treeViewObjects == null)
			{
				this.treeViewObjects = new Class18();
				flag = true;
			}
			this.treeViewObjects.Show(this.dockPanel_0);
			if (flag)
			{
				this.treeViewObjects.DockPanel.DockRightPortion = 0.15;
				this.treeViewObjects.method_0(new TreeViewEventHandler(this.method_22));
				this.treeViewObjects.method_14(new Delegate4(this.method_19));
				this.treeViewObjects.Layout += this.class9_0_Layout;
				this.treeViewObjects.FormClosing += this.class18_0_FormClosing;
				this.treeViewObjects.method_10((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]);
				this.dictionary_1.Add(this.dockPanel_0.ActiveDocument, this.treeViewObjects.method_9());
				return;
			}
			this.method_21();
		}

		private void method_19(object sender, EventArgs0 e)
		{
			List<DrawObjectBase> list = this.method_20();
			e.method_1(list);
		}

		private List<DrawObjectBase> method_20()
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			if (this.canvasControl_1 != null)
			{
				foreach (ICanvasLayer canvasLayer in this.canvasControl_1.Layers)
				{
					foreach (DrawObjectBase drawObjectBase in ((DrawingLayer)canvasLayer).Objects)
					{
						if (drawObjectBase.GetType() == typeof(LineTool) && ((LineTool)drawObjectBase).Type == LineToolType.CabelLine)
						{
							list.Add(drawObjectBase);
						}
					}
				}
				SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
				DataTable dataTable = new DataTable("tSchm_ObjList");
				dataTable.Columns.Add("id", typeof(int));
				new DataSet().Tables.Add(dataTable);
				sqlDataCommand.SelectSqlData(dataTable, true, " left join tP_Passport p on tSchm_ObjList.id = p.idObjList where tSChm_ObjList.typeCodeId = " + 546.ToString() + " and tSChm_ObjList.deleted = 0 and not p.id is null", null, false, 0);
				foreach (object obj2 in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj2;
					int id = Convert.ToInt32(dataRow["id"]);
					try
					{
						DrawObjectBase item = list.Single((DrawObjectBase obj) => obj.IdBase == id);
						list.Remove(item);
					}
					catch
					{
					}
				}
			}
			return list;
		}

		private void toolStripButton_44_Click(object sender, EventArgs e)
		{
			this.canvasScheme.ClearSelectedObjects();
			foreach (DrawObjectBase drawobject in this.method_20())
			{
				this.canvasScheme.SelectObject(drawobject);
			}
			this.canvasScheme.DoInvalidate(true);
		}

		private void method_21()
		{
			try
			{
				if (this.dictionary_1.ContainsKey(this.dockPanel_0.ActiveDocument))
				{
					this.treeViewObjects.method_11(this.dictionary_1[this.dockPanel_0.ActiveDocument]);
				}
				else if (((DockContentBase)this.dockPanel_0.ActiveDocument).Controls.Count > 0 && ((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
				{
					CanvasControl canvasControl = (CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0];
					this.treeViewObjects.method_10(canvasControl);
					this.dictionary_1.Add(this.dockPanel_0.ActiveDocument, this.treeViewObjects.method_9());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void class18_0_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.toolStripButton_4.Checked = false;
			this.treeViewObjects.Hide();
			e.Cancel = true;
		}

		private void class9_0_Layout(object sender, LayoutEventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.DoInvalidate(true);
			}
		}

		private void method_22(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Level > 0 && e.Node.IsSelected)
			{
				if (e.Node.Tag is DrawObjectBase)
				{
					DrawObjectBase drawObject = (DrawObjectBase)e.Node.Tag;
					if (this.canvasControl_1 != null)
					{
						this.canvasControl_1.SetObjectsInCenterScreen(drawObject, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
						return;
					}
				}
				else
				{
					List<DrawObjectBase> drawObjects = (List<DrawObjectBase>)e.Node.Tag;
					if (this.canvasControl_1 != null)
					{
						this.canvasControl_1.SetObjectsInCenterScreen(drawObjects, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
					}
				}
			}
		}

		public void InitOPC()
		{
			this.opcClient.OPCSyncDisconnect();
			this.opcClient.OnSocketEvent -= new DelegateSocketEventMethod(this.method_23);
			this.opcClient.OnGetEvent -= new DelegateOPCClientGetEvent(this.method_26);
			this.opcClient.OnGetItem -= new DelegateOPCClientGetEvents(this.method_25);
			this.opcClient.OnSocketEvent += new DelegateSocketEventMethod(this.method_23);
			this.opcClient.OnGetEvent += new DelegateOPCClientGetEvent(this.method_26);
			this.opcClient.OnGetItem += new DelegateOPCClientGetEvents(this.method_25);
			this.method_27();
			this.OPCClientConnect();
		}

		private void method_23(SocketEventTypeEnum socketEventTypeEnum_0, object object_0)
		{
			switch (socketEventTypeEnum_0)
			{
			case 1:
				this.class9_0.method_6("Соединение с OPCServer прошло успешно", 2, null);
				this.method_24(true);
				return;
			case 2:
			case 3:
			case 4:
			case 5:
			case 9:
			case 10:
				break;
			case 6:
				this.class9_0.method_6("Отсоединение от сервера", 2, null);
				this.method_24(false);
				break;
			case 7:
				this.class9_0.method_6("Обрыв соединения с OPCServer", 0, null);
				this.method_24(false);
				return;
			case 8:
				this.class9_0.method_6(object_0.ToString(), 0, null);
				return;
			default:
				return;
			}
		}

		private void method_24(bool bool_5)
		{
			if (this.toolStrip_6.InvokeRequired)
			{
				this.toolStrip_6.Invoke(new Action(delegate()
				{
					this.toolStrip_6.Visible = bool_5;
				}));
				return;
			}
			this.toolStrip_6.Visible = bool_5;
		}

		private void method_25(List<OPCMessage> list_3)
		{
			IEnumerable<DrawObjectBase> source = null;
			if (this.canvasControl_1.Layers.Count<ICanvasLayer>() > 0)
			{
				source = from o in this.canvasControl_1.ActiveLayer.Objects
				where o is ObjectOnLine
				select o;
			}
			using (List<OPCMessage>.Enumerator enumerator = list_3.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					OPCMessage message = enumerator.Current;
					if (message.ObjectId > 0)
					{
						IEnumerable<DrawObjectBase> source2 = from d in source
						where d.IdBase == message.ObjectId
						select d;
						if (source2.Count<DrawObjectBase>() == 0)
						{
							continue;
						}
						DrawObjectBase drawObjectBase = source2.First<DrawObjectBase>();
						if (drawObjectBase is ObjectOnLine && message.ValueType == "VT_BOOL")
						{
							if (!string.IsNullOrEmpty(message.Value))
							{
								Convert.ToBoolean(message.Value);
							}
							if (this.class11_0 != null)
							{
								this.class11_0.method_5(message, (ObjectOnLine)drawObjectBase);
							}
						}
					}
					if (this.class11_0 != null)
					{
						this.class11_0.method_4(message, eMessageType.OPCItem);
					}
				}
			}
		}

		private void method_26(OPCMessage opcmessage_0)
		{
			if (this.class11_0 != null)
			{
				this.class11_0.method_4(opcmessage_0, eMessageType.OPCEvent);
			}
		}

		public void OPCClientConnect()
		{
			if (this.opcClient.GetPermissionForOPC(this.SqlSettings))
			{
				this.opcClient.OPCAsyncConnect();
				return;
			}
			this.TelemetryLabelVisible = false;
		}

		public void OPCDisconnect()
		{
			this.opcClient.OPCSyncDisconnect();
		}

		public void method_27()
		{
			this.thread_0 = new Thread(new ThreadStart(this.LoadOPCDataTrhead));
			this.thread_0.Start();
		}

		public void LoadOPCDataTrhead()
		{
			new SqlDataCommand(this.SqlSettings);
			try
			{
				this.opcClient.LoadOPCData();
			}
			catch (Exception ex)
			{
				this.class9_0.method_6(ex.Message, 0, null);
			}
		}

		private void method_28()
		{
			bool flag = false;
			if (this.class11_0 == null)
			{
				this.class11_0 = new Class11();
				flag = true;
			}
			this.class11_0.Show(this.dockPanel_0);
			if (flag)
			{
				this.class11_0.DockPanel.DockRightPortion = 0.5;
				this.class11_0.method_0(new Delegate1(this.method_29));
				this.class11_0.FormClosing += this.class11_0_FormClosing;
				this.class11_0.Layout += this.class9_0_Layout;
				this.class11_0.method_13(new EventHandler(this.method_30));
				this.class11_0.method_15(new EventHandler(this.method_31));
			}
		}

		private void class11_0_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.toolStripButton_5.Checked = false;
			this.class11_0.Hide();
			e.Cancel = true;
		}

		private void method_29(OPCMessage opcmessage_0)
		{
			DrawObjectBase drawObjectBase = this.canvasControl_1.FindObjectById(opcmessage_0.ObjectId);
			if (drawObjectBase != null)
			{
				this.canvasScheme.SetObjectsInCenterScreen(drawObjectBase, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
			}
		}

		private void method_30(object sender, EventArgs e)
		{
			this.opcClient.OPCAsyncSend_GetAllItem();
		}

		private void method_31(object sender, EventArgs e)
		{
			this.opcClient.OPCAsyncSend_AcknowledgeEvent((List<OPCMessage>)sender);
		}

		private void method_32()
		{
			bool flag = false;
			if (this.class17_0 == null)
			{
				this.class17_0 = new Class17();
				this.class17_0.method_10(this.SqlSettings);
				flag = true;
			}
			this.class17_0.Show(this.dockPanel_0);
			if (flag)
			{
				this.class17_0.DockPanel.DockLeftPortion = 0.15;
				this.class17_0.Layout += this.class9_0_Layout;
				this.class17_0.FormClosing += this.class17_0_FormClosing;
			}
		}

		private void class17_0_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.toolStripButton_7.Checked = false;
			this.class17_0.Hide();
			e.Cancel = true;
		}

		private void method_33()
		{
			bool flag = false;
			if (this.class12_0 == null)
			{
				this.class12_0 = new Class12();
				flag = true;
			}
			this.class12_0.Show(this.dockPanel_0);
			if (flag)
			{
				this.class12_0.DockPanel.DockLeftPortion = 0.15;
				this.class12_0.Layout += this.class12_0_Layout;
				this.class12_0.FormClosing += this.class12_0_FormClosing;
				this.class12_0.method_1(new DataGridViewCellEventHandler(this.method_35));
				this.method_34();
			}
		}

		private void method_34()
		{
			if (this.class12_0 != null)
			{
				try
				{
					foreach (LineToolState lineToolState_ in ((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]).States)
					{
						this.class12_0.method_6(lineToolState_);
					}
					foreach (ICanvasLayer canvasLayer in ((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]).Layers)
					{
						foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
						{
							if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine) && drawObjectBase.GetType() != typeof(GroundingTool) && !((ObjectOnLine)drawObjectBase).MappingState)
							{
								ObjectOnLine objectOnLine = (ObjectOnLine)drawObjectBase;
								if (objectOnLine.On)
								{
									if (!objectOnLine.IsNormalSection)
									{
										this.class12_0.method_10(objectOnLine);
									}
									else
									{
										this.class12_0.method_9(objectOnLine);
									}
								}
								else if (objectOnLine.IsNormalSection)
								{
									this.class12_0.method_10(objectOnLine);
								}
								else
								{
									this.class12_0.method_9(objectOnLine);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
				}
			}
		}

		private void method_35(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && this.class12_0.method_0().Count > 0)
			{
				DataGridViewRow dataGridViewRow = this.class12_0.method_0()[0];
				if (dataGridViewRow.Tag != null)
				{
					this.canvasScheme.SetObjectsInCenterScreen((DrawObjectBase)dataGridViewRow.Tag, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
				}
			}
		}

		private void class12_0_Layout(object sender, LayoutEventArgs e)
		{
			this.canvasScheme.DoInvalidate(true);
		}

		private void class12_0_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.toolStripButton_10.Checked = false;
			this.class12_0.Hide();
			e.Cancel = true;
		}

		private void method_36()
		{
			if (this.class12_0 != null)
			{
				this.class12_0.method_3();
			}
		}

		private void method_37()
		{
			bool flag = false;
			if (this.class9_0 == null)
			{
				this.class9_0 = new Class9();
				flag = true;
			}
			this.class9_0.Show(this.dockPanel_0);
			if (flag)
			{
				this.class9_0.DockPanel.DockBottomPortion = 0.15;
				this.class9_0.Layout += this.class9_0_Layout;
				this.class9_0.method_0(new DataGridViewCellEventHandler(this.method_38));
				this.class9_0.FormClosing += this.class9_0_FormClosing;
			}
		}

		private void class9_0_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.toolStripButton_6.Checked = false;
			this.class9_0.Hide();
			e.Cancel = true;
		}

		private void method_38(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && this.class9_0.method_2().Count > 0)
			{
				DataGridViewRow dataGridViewRow = this.class9_0.method_2()[0];
				if (dataGridViewRow.Tag != null)
				{
					this.canvasScheme.SetObjectsInCenterScreen(((CanvasMessageEventArgs)dataGridViewRow.Tag).MessageObjects, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
				}
			}
		}

		private void method_39()
		{
			if (this.class9_0 != null)
			{
				this.class9_0.method_5();
			}
		}

		private void toolStripButton_11_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.CommandPan();
			}
		}

		private void toolStripButton_12_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.CommandEscape();
			}
		}

		private void toolStripButton_21_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.CommandZoomWindow();
			}
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.CommandDrawTool("Rectangle");
			}
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.CommandDrawTool("Shina");
			}
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.CommandDrawTool("Line");
			}
		}

		private void toolStripButton_36_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.CommandDrawTool("Text");
			}
		}

		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
			PatternTP pattern = new PatternTP();
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.CommandPattern(pattern);
			}
		}

		private void toolStripButton_13_Click(object sender, EventArgs e)
		{
		}

		private void toolStripButton_14_Click(object sender, EventArgs e)
		{
			if (this.canvasScheme.WorkerCounter <= 0 && !this.bool_1)
			{
				this.method_16(true);
				return;
			}
			this.class9_0.method_6("Не завершено сохранение изменений", 2, null);
		}

		private void toolStripButton_16_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.ShowPageSetupDialog();
			}
		}

		private void toolStripButton_17_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.printPreviewDialog = new PrintPreviewDialog();
				this.canvasControl_1.printPreviewDialog.Document = this.canvasControl_1.printDocument;
				this.canvasControl_1.printPreviewDialog.MdiParent = base.MdiParent;
				this.canvasControl_1.printPreviewDialog.Show();
			}
		}

		private void toolStripButton_18_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null && this.canvasControl_1.printDialog.ShowDialog() == DialogResult.OK)
			{
				this.canvasControl_1.printDocument.Print();
			}
		}

		private void toolStripButton_37_Click(object sender, EventArgs e)
		{
			this.canvasControl_1.Print();
		}

		private void toolStripButton_26_Click(object sender, EventArgs e)
		{
			FormCanvasFilterApply formCanvasFilterApply = new FormCanvasFilterApply(this.canvasScheme.Settings);
			formCanvasFilterApply.SqlSettings = this.SqlSettings;
			if (formCanvasFilterApply.ShowDialog() == DialogResult.OK)
			{
				List<int> listIdObjects = formCanvasFilterApply.ListIdObjects;
				List<string> listFilterName = formCanvasFilterApply.ListFilterName;
				if (listFilterName.Count > 0)
				{
					List<DrawObjectBase> list = new List<DrawObjectBase>();
					Func<DrawObjectBase, bool> <>9__0;
					foreach (ICanvasLayer canvasLayer in this.canvasScheme.Layers)
					{
						List<DrawObjectBase> list2 = list;
						IEnumerable<DrawObjectBase> objects = canvasLayer.Objects;
						Func<DrawObjectBase, bool> predicate;
						if ((predicate = <>9__0) == null)
						{
							predicate = (<>9__0 = ((DrawObjectBase obj) => listIdObjects.Contains(obj.IdBase)));
						}
						list2.AddRange(objects.Where(predicate));
					}
					StringBuilder stringBuilder = new StringBuilder();
					foreach (string value in listFilterName)
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append("; ");
						}
						stringBuilder.Append(value);
					}
					DockContentBase dockContentBase = this.method_53(stringBuilder.ToString());
					CanvasControl canvasControl = (CanvasControl)dockContentBase.Controls[0];
					foreach (DrawObjectBase drawObjectBase in from o in list
					where o.GetType() == typeof(RectangleTool)
					select o)
					{
						((DrawingLayer)canvasControl.ActiveLayer).AddObject(drawObjectBase);
						if (drawObjectBase.Selected)
						{
							canvasControl.SelectObject(drawObjectBase);
						}
					}
					foreach (DrawObjectBase drawObjectBase2 in from o in list
					where o.GetType() == typeof(ShinaTool)
					select o)
					{
						((DrawingLayer)canvasControl.ActiveLayer).AddObject(drawObjectBase2);
						if (drawObjectBase2.Selected)
						{
							canvasControl.SelectObject(drawObjectBase2);
						}
					}
					foreach (DrawObjectBase drawObjectBase3 in from o in list
					where (o.GetType() == typeof(BranchCollection) && ((BranchCollection)o).Collection.Count<Branch>() > 0) || o.GetType() == typeof(LineTool) || o.GetType() == typeof(LineCellTool)
					select o)
					{
						if (drawObjectBase3 is BranchCollection && ((BranchCollection)drawObjectBase3).Collection.Count<Branch>() > 0)
						{
							((DrawingLayer)canvasControl.ActiveLayer).AddObject(((BranchCollection)drawObjectBase3).Collection.First<Branch>().Parent);
						}
						else
						{
							((DrawingLayer)canvasControl.ActiveLayer).AddObject(drawObjectBase3);
						}
						if (drawObjectBase3.Selected)
						{
							canvasControl.SelectObject(drawObjectBase3);
						}
					}
					foreach (DrawObjectBase drawObjectBase4 in from o in list
					where o.GetType().BaseType == typeof(ObjectOnLine)
					select o)
					{
						((DrawingLayer)canvasControl.ActiveLayer).AddObject(drawObjectBase4);
						if (drawObjectBase4.Selected)
						{
							canvasControl.SelectObject(drawObjectBase4);
						}
					}
					canvasControl.FitToScreen();
					dockContentBase.Show(this.dockPanel_0);
				}
			}
		}

		private void toolStripButton_27_Click(object sender, EventArgs e)
		{
			this.canvasScheme.ClearFilter();
		}

		private void toolStripButton_46_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.method_40();
				if (this.list_1 != null && this.list_1.Count > 0)
				{
					this.int_1 = 0;
					this.canvasControl_1.SetObjectsInCenterScreen(this.list_1[this.int_1], false, CanvasControl.SetObjectsInCenterScreenOptions.select);
				}
			}
		}

		private void toolStripButton_47_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.method_40();
				if (this.list_1 != null && this.list_1.Count > 0)
				{
					this.int_1--;
					if (this.int_1 < 0)
					{
						this.int_1 = this.list_1.Count - 1;
					}
					this.canvasControl_1.SetObjectsInCenterScreen(this.list_1[this.int_1], false, CanvasControl.SetObjectsInCenterScreenOptions.select);
				}
			}
		}

		private void toolStripButton_48_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				this.int_1++;
				this.method_40();
				if (this.list_1 != null && this.list_1.Count > 0)
				{
					if (this.int_1 >= this.list_1.Count)
					{
						this.int_1 = 0;
					}
					this.canvasControl_1.SetObjectsInCenterScreen(this.list_1[this.int_1], false, CanvasControl.SetObjectsInCenterScreenOptions.select);
				}
			}
		}

		private void method_40()
		{
			if (!string.IsNullOrEmpty(this.toolStripTextBox_0.Text))
			{
				if (this.list_1 == null || this.list_1.Count == 0)
				{
					this.list_1 = new List<DrawObjectBase>();
					foreach (ICanvasLayer canvasLayer in this.canvasControl_1.Layers)
					{
						DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
						this.list_1.AddRange(drawingLayer.Objects.Where(new Func<DrawObjectBase, bool>(this.method_57)));
					}
					this.list_1.Sort((DrawObjectBase o1, DrawObjectBase o2) => o1.ToString().CompareTo(o2.ToString()));
					List<DrawObjectBase> list = new List<DrawObjectBase>();
					foreach (ICanvasLayer canvasLayer2 in this.canvasControl_1.Layers)
					{
						DrawingLayer drawingLayer2 = (DrawingLayer)canvasLayer2;
						list.AddRange(drawingLayer2.Objects.Where(new Func<DrawObjectBase, bool>(this.method_58)));
					}
					list.Sort((DrawObjectBase o1, DrawObjectBase o2) => o1.ToString().CompareTo(o2.ToString()));
					this.list_1.AddRange(list);
					this.int_1 = 0;
					return;
				}
			}
			else
			{
				this.list_1 = null;
			}
		}

		private void toolStripTextBox_0_TextChanged(object sender, EventArgs e)
		{
			this.int_1 = 0;
			if (this.list_1 != null)
			{
				this.list_1.Clear();
			}
			this.list_1 = null;
		}

		private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				Keys modifiers = e.Modifiers;
				if (modifiers == Keys.None)
				{
					this.toolStripButton_48_Click(sender, e);
					return;
				}
				if (modifiers != Keys.Shift)
				{
					return;
				}
				this.toolStripButton_47_Click(sender, e);
			}
		}

		private void toolStripMenuItem_21_Click(object sender, EventArgs e)
		{
			this.method_1("NP");
		}

		private void toolStripMenuItem_20_Click(object sender, EventArgs e)
		{
			this.method_1("NL");
		}

		private void toolStripMenuItem_19_Click(object sender, EventArgs e)
		{
			this.method_1("NR");
		}

		private void method_41(object sender, EventArgs e)
		{
		}

		private void toolStripMenuItem_26_Click(object sender, EventArgs e)
		{
			this.method_0("NR");
			this.list_0.Clear();
			this.method_0("NL");
			this.list_0.Clear();
		}

		private void toolStripButton_19_Click(object sender, EventArgs e)
		{
			if (new FormCanvasSettings(this.canvasControl_1).ShowDialog() == DialogResult.OK)
			{
				if (this.canvasControl_1 != null)
				{
					this.canvasControl_1.DoInvalidate(true);
				}
				this.canvasControl_1.UpdateMeasurementForBus();
			}
		}

		private void toolStripButton_53_Click(object sender, EventArgs e)
		{
			new Form2
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void toolStripButton_54_Click(object sender, EventArgs e)
		{
			FormJournalAbn formJournalAbn = new FormJournalAbn();
			formJournalAbn.SqlSettings = this.SqlSettings;
			formJournalAbn.GoToSchema += this.method_42;
			formJournalAbn.Show(this.dockPanel_0);
		}

		private void method_42(object sender, GoToSchemaEventArgs e)
		{
			this.OnGoToSchema(e);
		}

		private void canvasControl_0_FlashObjectsRemoved(CanvasControl canvasControl_2, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
			if (this.canvasScheme.FlashingObjects.Count<DrawObjectBase>() <= 0)
			{
				this.toolStripButton_28.Enabled = false;
			}
		}

		private void canvasControl_0_FlashObjectsAdded(CanvasControl canvasControl_2, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
			this.toolStripButton_28.Enabled = true;
		}

		private void canvasControl_0_DrawingCompleted(CanvasControl canvasControl_2, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
			SendCommandEventArgs sendCommandEventArgs = new SendCommandEventArgs();
			sendCommandEventArgs.Cake = 222;
			CommandBox command = new CommandBox(Command.ReloadDrawObject);
			foreach (DrawObjectBase drawObjectBase in drawObjectsEventArgs_0.Objects)
			{
				CommandValue value = new CommandValue("Object");
				value.AddAtribute("id", drawObjectBase.IdBase.ToString());
				command.AddValue(value);
			}
			sendCommandEventArgs.AddCommand(command);
			base.OnSendCommand(this, sendCommandEventArgs);
		}

		private void canvasControl_0_SelectedObjectEdited(CanvasControl canvasControl_2, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
			SendCommandEventArgs sendCommandEventArgs = new SendCommandEventArgs();
			sendCommandEventArgs.Cake = 222;
			CommandBox command = new CommandBox(Command.ReloadDrawObject);
			foreach (DrawObjectBase drawObjectBase in drawObjectsEventArgs_0.Objects)
			{
				CommandValue value = new CommandValue("Object");
				value.AddAtribute("id", drawObjectBase.IdBase.ToString());
				command.AddValue(value);
			}
			sendCommandEventArgs.AddCommand(command);
			base.OnSendCommand(this, sendCommandEventArgs);
		}

		private void canvasControl_0_SelectedObjectMoved(CanvasControl canvasControl_2, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
			foreach (DrawObjectBase drawObjectBase in drawObjectsEventArgs_0.Objects)
			{
				ClientManager.DOBMove(drawObjectBase.IdBase, drawObjectsEventArgs_0.Offset, drawObjectsEventArgs_0.SelectedMove);
			}
		}

		private void canvasControl_0_SaveProcessChanged(object sender, EventArgs e)
		{
			this.toolStripLabel_1.Text = sender.ToString();
			if ((int)sender == 0 && this.bool_0)
			{
				base.Close();
			}
		}

		private void canvasScheme_ObjectClicked(CanvasControl sender, DrawObjectsEventArgs e)
		{
			if (this.treeViewObjects != null)
			{
				if (e.Objects == null || e.Objects.Count == 0)
				{
					this.treeViewObjects.SelectedObject(null);
					return;
				}
				bool flag = false;
				using (List<DrawObjectBase>.Enumerator enumerator = e.Objects.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						DrawObjectBase drawObjectBase_ = enumerator.Current;
						this.treeViewObjects.SelectedObject(drawObjectBase_);
						flag = true;
					}
				}
				if (!flag)
				{
					this.class17_0.VtnUlqUaJQ(null);
				}
			}
		}

		private void canvasScheme_ShowContextMenuCanvasEvent(ContextMenuStrip contextMenuStrip_1, List<object> list_3)
		{
			if (contextMenuStrip_1.Tag == null && !(contextMenuStrip_1.Tag is DrawObjectBase))
			{
				return;
			}
			DrawObjectBase dob = (DrawObjectBase)contextMenuStrip_1.Tag;
			if (dob is LineTool)
			{
				ToolStripMenuItem toolStripMenuItem = null;
				if (!contextMenuStrip_1.Items.ContainsKey("toolStripMenuItemCellTelemetryChart"))
				{
					toolStripMenuItem = new ToolStripMenuItem();
					toolStripMenuItem.Name = "toolStripMenuItemCellTelemetryChart";
					toolStripMenuItem.Size = new Size(271, 22);
					toolStripMenuItem.Text = "График";
					toolStripMenuItem.Click += this.method_45;
					contextMenuStrip_1.Items.Insert(18, toolStripMenuItem);
					this.list_2.Add("toolStripMenuItemCellTelemetryChart");
				}
				if (toolStripMenuItem == null)
				{
					toolStripMenuItem = (ToolStripMenuItem)contextMenuStrip_1.Items["toolStripMenuItemCellTelemetryChart"];
				}
				toolStripMenuItem.DropDownItems.Clear();
				List<Class13> list = new List<Class13>();
				IEnumerable<IDockContent> documents = this.dockPanel_0.Documents;
				Func<IDockContent, bool> <>9__0;
				Func<IDockContent, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((IDockContent o) => o.GetType() == typeof(Class13) && ((Class13)o).method_3(dob)));
				}
				foreach (IDockContent dockContent in documents.Where(predicate))
				{
					list.Add((Class13)dockContent);
					ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
					toolStripMenuItem2.Name = ((Class13)dockContent).Name;
					toolStripMenuItem2.Size = new Size(271, 22);
					toolStripMenuItem2.Text = "Добавить в " + ((Class13)dockContent).Text;
					toolStripMenuItem2.Tag = dockContent;
					toolStripMenuItem2.Click += this.method_45;
					toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
				}
				if (toolStripMenuItem.DropDownItems.Count > 0)
				{
					ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
					toolStripMenuItem3.Name = "toolStripMenuItemNewCellTelemetryChart";
					toolStripMenuItem3.Size = new Size(271, 22);
					toolStripMenuItem3.Text = "Новый график";
					toolStripMenuItem3.Click += this.method_45;
					toolStripMenuItem.DropDownItems.Add(toolStripMenuItem3);
				}
				if (dob.GetType() == typeof(LineCellTool) && !contextMenuStrip_1.Items.ContainsKey("toolStripMenuItemMeasurementReport") && dob.Parent.GetType() == typeof(RectangleTool))
				{
					ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
					toolStripMenuItem4.Name = "toolStripMenuItemMeasurementReport";
					toolStripMenuItem4.Size = new Size(271, 22);
					toolStripMenuItem4.Text = "Отчет по замерам";
					toolStripMenuItem4.Click += this.method_44;
					contextMenuStrip_1.Items.Insert(26, toolStripMenuItem4);
					this.list_2.Add("toolStripMenuItemMeasurementReport");
					return;
				}
			}
			else if (dob.GetType() == typeof(ShinaTool))
			{
				ToolStripMenuItem toolStripMenuItem5 = null;
				if (!contextMenuStrip_1.Items.ContainsKey("toolStripMenuItemCellTelemetryChart"))
				{
					toolStripMenuItem5 = new ToolStripMenuItem();
					toolStripMenuItem5.Name = "toolStripMenuItemCellTelemetryChart";
					toolStripMenuItem5.Size = new Size(271, 22);
					toolStripMenuItem5.Text = "График";
					toolStripMenuItem5.Click += this.method_45;
					contextMenuStrip_1.Items.Insert(11, toolStripMenuItem5);
					this.list_2.Add("toolStripMenuItemCellTelemetryChart");
				}
				if (toolStripMenuItem5 == null)
				{
					toolStripMenuItem5 = (ToolStripMenuItem)contextMenuStrip_1.Items["toolStripMenuItemCellTelemetryChart"];
				}
				toolStripMenuItem5.DropDownItems.Clear();
				List<Class13> list2 = new List<Class13>();
				IEnumerable<IDockContent> documents2 = this.dockPanel_0.Documents;
				Func<IDockContent, bool> <>9__1;
				Func<IDockContent, bool> predicate2;
				if ((predicate2 = <>9__1) == null)
				{
					predicate2 = (<>9__1 = ((IDockContent o) => o.GetType() == typeof(Class13) && ((Class13)o).method_3(dob)));
				}
				foreach (IDockContent dockContent2 in documents2.Where(predicate2))
				{
					list2.Add((Class13)dockContent2);
					ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem();
					toolStripMenuItem6.Name = ((Class13)dockContent2).Name;
					toolStripMenuItem6.Size = new Size(271, 22);
					toolStripMenuItem6.Text = "Добавить в " + ((Class13)dockContent2).Text;
					toolStripMenuItem6.Tag = dockContent2;
					toolStripMenuItem6.Click += this.method_45;
					toolStripMenuItem5.DropDownItems.Add(toolStripMenuItem6);
				}
				if (toolStripMenuItem5.DropDownItems.Count > 0)
				{
					ToolStripMenuItem toolStripMenuItem7 = new ToolStripMenuItem();
					toolStripMenuItem7.Name = "toolStripMenuItemNewCellTelemetryChart";
					toolStripMenuItem7.Size = new Size(271, 22);
					toolStripMenuItem7.Text = "Новый график";
					toolStripMenuItem7.Click += this.method_45;
					toolStripMenuItem5.DropDownItems.Add(toolStripMenuItem7);
				}
				if (!contextMenuStrip_1.Items.ContainsKey("toolStripMenuItemMeasurementReport") && dob.Parent.GetType() == typeof(RectangleTool))
				{
					ToolStripMenuItem toolStripMenuItem8 = new ToolStripMenuItem();
					toolStripMenuItem8.Name = "toolStripMenuItemMeasurementReport";
					toolStripMenuItem8.Size = new Size(271, 22);
					toolStripMenuItem8.Text = "Отчет по замерам";
					toolStripMenuItem8.Click += this.method_44;
					contextMenuStrip_1.Items.Insert(6, toolStripMenuItem8);
					this.list_2.Add("toolStripMenuItemMeasurementReport");
					return;
				}
			}
		}

		private void method_43(IEnumerable<DrawObjectBase> ienumerable_0)
		{
			Class19 @class = new Class19();
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			DataTable dataTable3 = new DataTable();
			Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();
			Dictionary<int, int[]> dictionary2 = dictionary;
			int key = 10;
			int[] array = new int[2];
			array[0] = 60;
			dictionary2.Add(key, array);
			dictionary.Add(16, new int[]
			{
				80,
				75
			});
			dictionary.Add(25, new int[]
			{
				105,
				90
			});
			dictionary.Add(35, new int[]
			{
				125,
				115
			});
			dictionary.Add(50, new int[]
			{
				155,
				140
			});
			dictionary.Add(70, new int[]
			{
				190,
				165
			});
			dictionary.Add(95, new int[]
			{
				225,
				205
			});
			dictionary.Add(120, new int[]
			{
				260,
				240
			});
			dictionary.Add(150, new int[]
			{
				300,
				275
			});
			dictionary.Add(185, new int[]
			{
				340,
				310
			});
			dictionary.Add(240, new int[]
			{
				390,
				355
			});
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
				SqlCommand sqlCommand = new SqlCommand(string.Concat(new object[]
				{
					"Select mat1.[IdBus],mat1.[idObjList],mat1.Ia,mat1.Ib,mat1.Ic, maxI.I, m1.DateD\r\n                                                                                                from [tJ_MeasAmperageTransf] as mat1 inner join\r\n\t                                                                                                (SELECT mat.[IdBus],mat.[idObjList],m.[TypeDoc],(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) then max([Ia]) else case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) then max([Ic]) end end end) as I, max([Ia]) as a, max([Ib]) as b, max([Ic]) as c\r\n\t                                                                                                FROM [tJ_MeasAmperageTransf] as mat\r\n\t                                                                                                inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n\t                                                                                                where  mat.deleted = 0 and m.[TypeDoc] = 1192 and  ((year(m.[DateD]) = ",
					this.canvasControl_1.Settings.MeasurementYear,
					" and month(m.[DateD]) between 1 and 11)or(year(m.[DateD]) = ",
					this.canvasControl_1.Settings.MeasurementYear,
					"-1 and month(m.[DateD])=12) ) and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n\t                                                                                                group by mat.[IdBus], mat.[idObjList], m.[TypeDoc]) as maxI \r\n                                                                                                on mat1.[IdBus]=maxI.[IdBus] and mat1.[idObjList]=maxI.[idObjList] and mat1.Ia = maxI.a and mat1.Ib= maxI.b and mat1.Ic = maxI.c \r\n                                                                                                inner join [tJ_Measurement] as m1 on mat1.[idMeasurement] = m1.id and m1.[TypeDoc]=1192\r\n                                                                                                where mat1.deleted = 0 and ((year(m1.[DateD]) = ",
					this.canvasControl_1.Settings.MeasurementYear,
					" and month(m1.[DateD]) between 1 and 11)or(year(m1.[DateD]) = ",
					this.canvasControl_1.Settings.MeasurementYear,
					"-1 and month(m1.[DateD])=12) ) and  mat1.[Ia] is not null and  mat1.[Ib] is not null and  mat1.[Ic] is not null and mat1.idbus is not null"
				}));
				sqlCommand.Connection = sqlConnection;
				sqlConnection.Open();
				SqlDataReader reader = sqlCommand.ExecuteReader();
				dataTable3.Load(reader);
				sqlCommand.CommandText = "SELECT tSchm_ObjList.id, tSchm_ObjList.name, p.[Power]\r\n                                                                                                    FROM tSchm_ObjList\r\n                                                                                                    inner join tR_Classifier on tSchm_ObjList.[TypeCodeId]=tR_Classifier.id and tR_Classifier.[ParentKey] like ';SCM;INLINE_OBJ;SWITCH;' and tR_Classifier.Value = 11\r\n                                                                                                    outer apply dbo.fn_J_MeasTransfPassport(tSchm_ObjList.[Id]) p\r\n                                                                                                    where tSchm_ObjList.Deleted=0";
				reader = sqlCommand.ExecuteReader();
				dataTable.Load(reader);
				sqlCommand.CommandText = "select tSchm_ObjList.id, tSchm_ObjList.name, minsect.CrossSection\r\n                                            from tSchm_ObjList \r\n                                            inner join (SELECT [idObjList],min([CrossSection])as CrossSection\r\n                                              FROM [tP_CabSection]  \r\n                                              where deleted=0 and [Length]>10\r\n                                              group by idobjlist)as minsect on tSchm_ObjList.id=minsect.idObjList \r\n                                            inner join tP_Passport pas on pas.idObjlist = tSchm_ObjList.id";
				reader = sqlCommand.ExecuteReader();
				dataTable2.Load(reader);
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			foreach (DrawObjectBase drawObjectBase in ienumerable_0)
			{
				TreeNodeObj treeNodeObj = this.canvasControl_1.PoweringReportForDrawObject(drawObjectBase, true);
				if (treeNodeObj.Nodes.Count<TreeNodeObj>() != 0)
				{
					Dictionary<LineCellTool, List<DrawObjectBase>> dictionary3 = new Dictionary<LineCellTool, List<DrawObjectBase>>();
					if (drawObjectBase.GetType() == typeof(ShinaTool))
					{
						using (IEnumerator<DrawObjectBase> enumerator2 = (from s in drawObjectBase.ChildObjects
						where s.GetType() == typeof(PointShinaTool)
						select s).GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								DrawObjectBase drawObjectBase2 = enumerator2.Current;
								PointTool pointTool = (PointTool)drawObjectBase2;
								if (pointTool.CouplingRelations.Count == 1 && pointTool.CouplingRelations[0].Line.GetType() == typeof(LineCellTool))
								{
									dictionary3.Add((LineCellTool)pointTool.CouplingRelations[0].Line, new List<DrawObjectBase>());
								}
							}
							goto IL_3AC;
						}
						goto IL_385;
					}
					goto IL_385;
					IL_3AC:
					Dictionary<ShinaTool, object[,]> dictionary4 = new Dictionary<ShinaTool, object[,]>();
					Dictionary<CouplingRelation, int> relationsMeasurement = new Dictionary<CouplingRelation, int>();
					foreach (TreeNodeObj treeNodeObj2 in treeNodeObj.LeafsList)
					{
						DrawObjectBase drawObjectBase3 = null;
						List<DrawObjectBase> list = new List<DrawObjectBase>();
						bool flag = false;
						int num = 0;
						while (treeNodeObj2.Parent != null)
						{
							if (treeNodeObj2.Tag == null)
							{
								MessageBox.Show("В элементе дерева нет объекта схемы");
								return;
							}
							if (treeNodeObj2.Tag.GetType() == typeof(ShinaTool))
							{
								ShinaTool shinaTool = (ShinaTool)treeNodeObj2.Tag;
								if (!dictionary4.ContainsKey(shinaTool))
								{
									DataRow[] array2 = dataTable3.Select("IdBus = " + shinaTool.IdBase.ToString());
									if (array2.Length != 0)
									{
										object[,] array3 = new object[array2.Length, 6];
										for (int i = 0; i < array2.Length; i++)
										{
											array3[i, 0] = array2[i][1];
											array3[i, 1] = array2[i][5];
											array3[i, 2] = array2[i][2];
											array3[i, 3] = array2[i][3];
											array3[i, 4] = array2[i][4];
											array3[i, 5] = array2[i][6];
											num += (int)array3[i, 1];
										}
										dictionary4.Add(shinaTool, array3);
									}
									else
									{
										dictionary4.Add(shinaTool, new object[1, 1]);
									}
								}
								flag = true;
								if (!list.Contains(shinaTool))
								{
									list.Add(shinaTool);
								}
							}
							else if (treeNodeObj2.Tag.GetType() == typeof(LineTool))
							{
								if (drawObjectBase3 == null)
								{
									drawObjectBase3 = (DrawObjectBase)treeNodeObj2.Tag;
									treeNodeObj2 = treeNodeObj2.Parent;
									continue;
								}
								LineTool lineTool = (LineTool)treeNodeObj2.Tag;
								List<CouplingRelation> list2 = new List<CouplingRelation>();
								PointTool linkPoint = DrawObjectBase.GetLinkPoint(lineTool, drawObjectBase3);
								DrawObjectBase dob = (DrawObjectBase)treeNodeObj2.Parent.Tag;
								PointTool linkPoint2 = DrawObjectBase.GetLinkPoint(lineTool, dob);
								lineTool.getRelationWay(linkPoint, linkPoint2, null, list2);
								foreach (CouplingRelation key2 in list2)
								{
									if (relationsMeasurement.ContainsKey(key2))
									{
										relationsMeasurement[key2] += num;
									}
									else
									{
										relationsMeasurement[key2] = num;
									}
								}
								if (!list.Contains(lineTool) && flag)
								{
									list.Add(lineTool);
								}
							}
							drawObjectBase3 = (DrawObjectBase)treeNodeObj2.Tag;
							treeNodeObj2 = treeNodeObj2.Parent;
							if (treeNodeObj2.Tag.GetType() == typeof(LineCellTool) && dictionary3.ContainsKey((LineCellTool)treeNodeObj2.Tag))
							{
								foreach (DrawObjectBase item in list)
								{
									if (!dictionary3[(LineCellTool)treeNodeObj2.Tag].Contains(item))
									{
										dictionary3[(LineCellTool)treeNodeObj2.Tag].Add(item);
									}
								}
							}
						}
					}
					Func<CouplingRelation, bool> <>9__1;
					foreach (LineCellTool lineCellTool in dictionary3.Keys)
					{
						int num2 = 0;
						foreach (DrawObjectBase drawObjectBase4 in dictionary3[lineCellTool])
						{
							if (drawObjectBase4.GetType() == typeof(ShinaTool))
							{
								ShinaTool key3 = (ShinaTool)drawObjectBase4;
								object[,] array4 = dictionary4[key3];
								if (array4.Length != 1)
								{
									for (int j = 0; j < array4.Length / 6; j++)
									{
										num2 += (int)array4[j, 1];
									}
								}
							}
						}
						foreach (DrawObjectBase drawObjectBase5 in dictionary3[lineCellTool])
						{
							if (drawObjectBase5.GetType() == typeof(ShinaTool))
							{
								ShinaTool shinaTool2 = (ShinaTool)drawObjectBase5;
								object[,] array5 = dictionary4[shinaTool2];
								if (array5.Length == 1)
								{
									DataRow dataRow = @class.MeasurementReport1.NewRow();
									dataRow["roottp"] = lineCellTool.Parent.GetFullName();
									dataRow["cell"] = lineCellTool.GetFullName();
									dataRow["tp"] = shinaTool2.Parent.GetFullName();
									dataRow["I"] = num2.ToString();
									dataRow["Comment"] = (((RectangleTool)shinaTool2.Parent).IsSubscriber ? "Абонентская" : string.Empty);
									@class.MeasurementReport1.Rows.Add(dataRow);
								}
								else
								{
									for (int k = 0; k < array5.Length / 6; k++)
									{
										DataRow dataRow2 = @class.MeasurementReport1.NewRow();
										dataRow2["roottp"] = lineCellTool.Parent.GetFullName();
										dataRow2["cell"] = lineCellTool.GetFullName();
										dataRow2["tp"] = shinaTool2.Parent.GetFullName();
										DataRow[] array6 = dataTable.Select("id = " + ((int)array5[k, 0]).ToString());
										if (array6.Length != 0)
										{
											dataRow2["trans"] = array6[0][1];
											dataRow2["PkVA"] = array6[0][2];
										}
										else
										{
											dataRow2["trans"] = ((int)array5[k, 0]).ToString();
										}
										dataRow2["I"] = num2.ToString();
										dataRow2["A"] = array5[k, 2].ToString();
										dataRow2["B"] = array5[k, 3].ToString();
										dataRow2["C"] = array5[k, 4].ToString();
										dataRow2["Date"] = ((DateTime)array5[k, 5]).ToString("dd.MM.yy");
										dataRow2["Time"] = ((DateTime)array5[k, 5]).ToString("HH:mm");
										dataRow2["Comment"] = (((RectangleTool)shinaTool2.Parent).IsSubscriber ? "Абонентская" : string.Empty);
										@class.MeasurementReport1.Rows.Add(dataRow2);
									}
								}
							}
							else if (drawObjectBase5.GetType() == typeof(LineTool))
							{
								LineTool lineTool2 = (LineTool)drawObjectBase5;
								int num3 = 0;
								int num4 = 0;
								IEnumerable<CouplingRelation> couplingRelations = lineTool2.CouplingRelations;
								Func<CouplingRelation, bool> predicate;
								if ((predicate = <>9__1) == null)
								{
									predicate = (<>9__1 = ((CouplingRelation c) => relationsMeasurement.ContainsKey(c)));
								}
								foreach (CouplingRelation couplingRelation in couplingRelations.Where(predicate))
								{
									if (relationsMeasurement[couplingRelation] > num3)
									{
										num3 = relationsMeasurement[couplingRelation];
									}
									num4 = lineTool2.Amperages[couplingRelation.amperagePoint].amperageProperties.voltage;
								}
								DataRow dataRow3 = @class.MeasurementReport2.NewRow();
								dataRow3["roottp"] = lineCellTool.Parent.GetFullName();
								dataRow3["cell"] = lineCellTool.GetFullName();
								dataRow3["KLVL"] = lineTool2.GetFullName();
								DataRow[] array7 = dataTable2.Select("id = " + lineTool2.IdBase.ToString());
								if (array7.Length != 0)
								{
									int key4 = Convert.ToInt32(array7[0][2]);
									dataRow3["section"] = key4.ToString();
									if (dictionary.ContainsKey(key4))
									{
										int value = 0;
										if (num4 == 6)
										{
											value = dictionary[key4][0];
										}
										else if (num4 == 10)
										{
											value = dictionary[key4][1];
										}
										dataRow3["pload"] = value.ToString();
										dataRow3["loading"] = Math.Round((double)(Convert.ToSingle(num3) / Convert.ToSingle(value) * 100f)).ToString();
									}
								}
								dataRow3["measurement"] = num3;
								@class.MeasurementReport2.Rows.Add(dataRow3);
							}
						}
					}
					continue;
					IL_385:
					if (drawObjectBase.GetType() == typeof(LineCellTool))
					{
						dictionary3.Add((LineCellTool)drawObjectBase, new List<DrawObjectBase>());
						goto IL_3AC;
					}
					goto IL_3AC;
				}
			}
			new Class8(@class.MeasurementReport1, @class.MeasurementReport2, "Scheme.FileReports.ReportMeasurement.rdlc")
			{
				SqlSettings = this.SqlSettings
			}.Show(this.dockPanel_0);
		}

		private void method_44(object sender, EventArgs e)
		{
			if ((this.canvasControl_1.SelectedObjects.Count<DrawObjectBase>() == 1 && this.canvasControl_1.SelectedObjects.First<DrawObjectBase>().GetType() == typeof(ShinaTool)) || this.canvasControl_1.SelectedObjects.First<DrawObjectBase>().GetType() == typeof(LineCellTool))
			{
				this.method_43(new List<DrawObjectBase>
				{
					this.canvasControl_1.SelectedObjects.First<DrawObjectBase>()
				});
			}
		}

		private void canvasControl_0_HideContextMenuCanvasEvent(ContextMenuStrip contextMenuStrip_1, List<object> list_3)
		{
		}

		private void method_45(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			if (toolStripMenuItem.DropDownItems.Count > 0)
			{
				return;
			}
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null || contextMenu.Tag == null)
			{
				return;
			}
			DrawObjectBase drawObjectBase_ = (DrawObjectBase)contextMenu.Tag;
			if (toolStripMenuItem.Tag == null)
			{
				int num = 1;
				using (IEnumerator<IDockContent> enumerator = this.dockPanel_0.Documents.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.GetType() == typeof(Class13))
						{
							num++;
						}
					}
				}
				new Class13(this.SqlSettings, drawObjectBase_)
				{
					Name = "FormTelemetryChart" + num.ToString(),
					Text = "График " + num.ToString()
				}.Show(this.dockPanel_0);
				return;
			}
			((Class13)toolStripMenuItem.Tag).method_5(drawObjectBase_);
		}

		private void method_46()
		{
			DataTable dataTable = base.SelectSqlData("tSChm_ObjList", true, " where id = " + this.idInitActiveObj.ToString());
			if (dataTable.Rows.Count > 0)
			{
				int num = Convert.ToInt32(dataTable.Rows[0]["typeCodeId"]);
				int idBase = Convert.ToInt32(dataTable.Rows[0]["id"]);
				string str = dataTable.Rows[0]["name"].ToString();
				if (dataTable.Rows[0]["idParent"] != DBNull.Value)
				{
					idBase = Convert.ToInt32(dataTable.Rows[0]["idParent"]);
					dataTable = base.SelectSqlData("tSChm_ObjList", true, " where id = " + idBase.ToString());
					if (dataTable.Rows.Count <= 0)
					{
						return;
					}
					num = Convert.ToInt32(dataTable.Rows[0]["typeCodeId"]);
					str = dataTable.Rows[0]["name"].ToString();
				}
				bool flag = false;
				foreach (object obj in Enum.GetValues(typeof(SchmTypeSubstation)))
				{
					SchmTypeSubstation schmTypeSubstation = (SchmTypeSubstation)obj;
					if (num == (int)schmTypeSubstation)
					{
						flag = true;
					}
				}
				if (flag)
				{
					switch (num)
					{
					case 535:
						this.canvasScheme.Parent.Text = "ПП-";
						break;
					case 536:
						this.canvasScheme.Parent.Text = "ЦП-";
						break;
					case 537:
						this.canvasScheme.Parent.Text = "РП-";
						break;
					case 538:
						this.canvasScheme.Parent.Text = "ТП-";
						break;
					}
					Control parent = this.canvasScheme.Parent;
					parent.Text += str;
					RectangleTool rectangleTool = new RectangleTool();
					rectangleTool.IdBase = idBase;
					this.canvasScheme.LoadScheme(rectangleTool);
				}
			}
		}

		private void method_47(object sender, EventArgs e)
		{
			RectangleTool rectangleTool = (RectangleTool)((ToolStripMenuItem)sender).Tag;
			new FormLinkCellPoint(new List<int>
			{
				rectangleTool.IdBase
			})
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void canvasScheme_ObjectsAdded(CanvasControl canvasControl_2, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
		}

		private void toolStripButton_24_Click(object sender, EventArgs e)
		{
			this.canvasControl_1.ZoomInSymbols();
		}

		private void toolStripButton_25_Click(object sender, EventArgs e)
		{
			this.canvasControl_1.ZoomOutSymbols();
		}

		private void toolStripButton_22_Click(object sender, EventArgs e)
		{
			this.canvasControl_1.ZoomIn();
		}

		private void toolStripButton_23_Click(object sender, EventArgs e)
		{
			this.canvasControl_1.ZoomOut();
		}

		private void uhjImiftgM(object sender, EventArgs e)
		{
			this.canvasScheme.ClearFlashingObjects();
			this.canvasScheme.DoInvalidate(true);
		}

		private void toolStripComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.dockPanel_0.ActiveDocument.GetType() == typeof(DockContentBase) && ((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
			{
				switch (((ToolStripComboBox)sender).SelectedIndex)
				{
				case 0:
				{
					this.canvasControl_1.Mode = eCanvasEditingMode.ReadOnly;
					this.method_52();
					ToolStripItem toolStripItem = this.toolStripButton_0;
					ToolStripItem toolStripItem2 = this.toolStripSeparator_6;
					ToolStripItem toolStripItem3 = this.toolStripButton_1;
					ToolStripItem toolStripItem4 = this.toolStripButton_2;
					ToolStripItem toolStripItem5 = this.toolStripButton_36;
					ToolStripItem toolStripItem6 = this.toolStripSeparator_0;
					ToolStripItem toolStripItem7 = this.toolStripButton_3;
					ToolStripItem toolStripItem8 = this.toolStripButton_38;
					ToolStripItem toolStripItem9 = this.toolStripButton_39;
					ToolStripItem toolStripItem10 = this.toolStripSeparator_13;
					ToolStripItem toolStripItem11 = this.toolStripButton_33;
					this.toolStripButton_34.Visible = false;
					toolStripItem11.Visible = false;
					toolStripItem10.Visible = false;
					toolStripItem9.Visible = false;
					toolStripItem8.Visible = false;
					toolStripItem7.Visible = false;
					toolStripItem6.Visible = false;
					toolStripItem5.Visible = false;
					toolStripItem4.Visible = false;
					toolStripItem3.Visible = false;
					toolStripItem2.Visible = false;
					toolStripItem.Visible = false;
					break;
				}
				case 1:
					this.canvasControl_1.Mode = eCanvasEditingMode.Dispatcher;
					if (this.canvasControl_1.Mode != eCanvasEditingMode.Dispatcher)
					{
						eCanvasEditingMode mode = this.canvasControl_1.Mode;
						if (mode != eCanvasEditingMode.ReadOnly)
						{
							if (mode == eCanvasEditingMode.Edit)
							{
								((ToolStripComboBox)sender).SelectedIndex = 3;
							}
						}
						else
						{
							((ToolStripComboBox)sender).SelectedIndex = 0;
						}
					}
					else
					{
						this.method_52();
						ToolStripItem toolStripItem12 = this.toolStripButton_0;
						ToolStripItem toolStripItem13 = this.toolStripSeparator_6;
						ToolStripItem toolStripItem14 = this.toolStripButton_1;
						ToolStripItem toolStripItem15 = this.toolStripButton_2;
						ToolStripItem toolStripItem16 = this.toolStripButton_36;
						ToolStripItem toolStripItem17 = this.toolStripSeparator_0;
						ToolStripItem toolStripItem18 = this.toolStripButton_3;
						ToolStripItem toolStripItem19 = this.toolStripButton_38;
						ToolStripItem toolStripItem20 = this.toolStripButton_39;
						ToolStripItem toolStripItem21 = this.toolStripSeparator_13;
						ToolStripItem toolStripItem22 = this.toolStripButton_33;
						this.toolStripButton_34.Visible = false;
						toolStripItem22.Visible = false;
						toolStripItem21.Visible = false;
						toolStripItem20.Visible = false;
						toolStripItem19.Visible = false;
						toolStripItem18.Visible = false;
						toolStripItem17.Visible = false;
						toolStripItem16.Visible = false;
						toolStripItem15.Visible = false;
						toolStripItem14.Visible = false;
						toolStripItem13.Visible = false;
						toolStripItem12.Visible = false;
					}
					break;
				case 2:
					if (this.canvasControl_1.Mode != eCanvasEditingMode.Edit)
					{
						this.canvasControl_1.Mode = eCanvasEditingMode.Edit;
						if (this.canvasControl_1.Mode != eCanvasEditingMode.Edit)
						{
							eCanvasEditingMode mode = this.canvasControl_1.Mode;
							if (mode != eCanvasEditingMode.ReadOnly)
							{
								if (mode == eCanvasEditingMode.Dispatcher)
								{
									((ToolStripComboBox)sender).SelectedIndex = 1;
								}
							}
							else
							{
								((ToolStripComboBox)sender).SelectedIndex = 0;
							}
						}
						else
						{
							if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain && MessageBox.Show("Перед началом редактирования рекомендуется перезагрузить схему. Перезагрузить схему?", "Перезагрузка схемы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
							{
								this.toolStripButton_14_Click(sender, e);
							}
							this.method_52();
							if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
							{
								ToolStripItem toolStripItem23 = this.toolStripButton_0;
								ToolStripItem toolStripItem24 = this.toolStripSeparator_6;
								ToolStripItem toolStripItem25 = this.toolStripButton_1;
								ToolStripItem toolStripItem26 = this.toolStripButton_2;
								ToolStripItem toolStripItem27 = this.toolStripSeparator_0;
								ToolStripItem toolStripItem28 = this.toolStripButton_3;
								ToolStripItem toolStripItem29 = this.toolStripButton_38;
								ToolStripItem toolStripItem30 = this.toolStripButton_39;
								ToolStripItem toolStripItem31 = this.toolStripSeparator_13;
								ToolStripItem toolStripItem32 = this.toolStripButton_33;
								this.toolStripButton_34.Visible = true;
								toolStripItem32.Visible = true;
								toolStripItem31.Visible = true;
								toolStripItem30.Visible = true;
								toolStripItem29.Visible = true;
								toolStripItem28.Visible = true;
								toolStripItem27.Visible = true;
								toolStripItem26.Visible = true;
								toolStripItem25.Visible = true;
								toolStripItem24.Visible = true;
								toolStripItem23.Visible = true;
							}
							else
							{
								ToolStripItem toolStripItem33 = this.toolStripButton_0;
								ToolStripItem toolStripItem34 = this.toolStripButton_1;
								this.toolStripButton_2.Visible = true;
								toolStripItem34.Visible = true;
								toolStripItem33.Visible = true;
							}
						}
					}
					break;
				}
				this.canvasControl_1.Focus();
			}
		}

		private void toolStripButton_20_Click(object sender, EventArgs e)
		{
			this.canvasScheme.VisibleCanvasSchemeMap = this.toolStripButton_20.Checked;
			if (this.toolStripButton_20.Checked)
			{
				this.toolStripButton_20.Text = "Скрыть карту схемы";
				return;
			}
			this.toolStripButton_20.Text = "Показать карту схемы";
		}

		private void toolStripButton_15_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "(*.dxf)|*.dxf";
			if (saveFileDialog.ShowDialog() == DialogResult.OK && this.canvasControl_1 != null)
			{
				this.canvasControl_1.ExportToDXF(saveFileDialog.FileName);
				MessageBox.Show("Файл успешно сохранен");
			}
		}

		private void canvasControl_0_CanvasMessage(CanvasControl canvasControl_2, CanvasMessageEventArgs canvasMessageEventArgs_0)
		{
			switch (canvasMessageEventArgs_0.MessageType)
			{
			case eMessageType.Error:
			case eMessageType.Warning:
			case eMessageType.Information:
			case eMessageType.LogDispatcher:
				this.class9_0.method_6(canvasMessageEventArgs_0.MessageText, (int)canvasMessageEventArgs_0.MessageType, canvasMessageEventArgs_0);
				break;
			case eMessageType.OPCEvent:
			case eMessageType.OPCItem:
				break;
			default:
				return;
			}
		}

		private void toolStripButton_33_Click(object sender, EventArgs e)
		{
			this.canvasScheme.undoRedoManager.Undo();
		}

		private void toolStripButton_34_Click(object sender, EventArgs e)
		{
			this.canvasScheme.undoRedoManager.Redo();
		}

		private void toolStripButton_4_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_4.Checked)
			{
				this.method_18();
				return;
			}
			this.treeViewObjects.Close();
		}

		private void toolStripButton_5_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_5.Checked)
			{
				this.method_28();
				return;
			}
			this.class11_0.Close();
		}

		private void toolStripButton_6_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_6.Checked)
			{
				this.method_37();
				return;
			}
			this.class9_0.Close();
		}

		private void toolStripButton_7_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_7.Checked)
			{
				this.method_32();
				return;
			}
			this.class17_0.Close();
		}

		private void toolStripButton_10_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_10.Checked)
			{
				this.method_33();
				return;
			}
			this.class12_0.Close();
		}

		private void method_48(object sender, EventArgs e)
		{
			Class19 @class = new Class19();
			DataRow dataRow = @class.tLogInOut.NewRow();
			dataRow["DateIn"] = DateTime.Now;
			dataRow["Module"] = base.Name + ": " + ((DockContentBase)sender).Text;
			@class.tLogInOut.Rows.Add(dataRow);
			int value = base.InsertSqlDataOneRow(@class, @class.tLogInOut);
			if (!this.dictionary_2.ContainsKey((DockContentBase)sender))
			{
				this.dictionary_2.Add((DockContentBase)sender, value);
			}
		}

		private void method_49(object sender, FormClosedEventArgs e)
		{
			if (this.dictionary_2.ContainsKey((DockContentBase)sender))
			{
				Class19 @class = new Class19();
				base.SelectSqlData(@class, @class.tLogInOut, true, "where id = " + this.dictionary_2[(DockContentBase)sender].ToString());
				if (@class.tLogInOut.Rows.Count > 0)
				{
					@class.tLogInOut.Rows[0]["DateOut"] = DateTime.Now;
					@class.tLogInOut.Rows[0].EndEdit();
					base.UpdateSqlData(@class, @class.tLogInOut);
				}
			}
		}

		private void method_50()
		{
			Class19 @class = new Class19();
			DataRow dataRow = @class.tLogInOut.NewRow();
			dataRow["DateIn"] = DateTime.Now;
			dataRow["Module"] = "FormGeneralScheme2";
			@class.tLogInOut.Rows.Add(dataRow);
			this.int_2 = base.InsertSqlDataOneRow(@class, @class.tLogInOut);
		}

		private void method_51()
		{
			if (this.int_2 > 0)
			{
				Class19 @class = new Class19();
				base.SelectSqlData(@class, @class.tLogInOut, true, "where id = " + this.int_2.ToString());
				if (@class.tLogInOut.Rows.Count > 0)
				{
					@class.tLogInOut.Rows[0]["DateOut"] = DateTime.Now;
					@class.tLogInOut.Rows[0].EndEdit();
					base.UpdateSqlData(@class, @class.tLogInOut);
				}
			}
		}

		private void method_52()
		{
			int num = 0;
			if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeMain)
			{
				num = this.int_2;
			}
			if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeSecond && this.dictionary_2.ContainsKey((DockContentBase)this.dockPanel_0.ActiveDocument))
			{
				num = this.dictionary_2[(DockContentBase)this.dockPanel_0.ActiveDocument];
			}
			if (num > 0)
			{
				Class19 @class = new Class19();
				base.SelectSqlData(@class, @class.tLogInOut, true, "where id = " + num.ToString());
				if (@class.tLogInOut.Rows.Count > 0)
				{
					DataRow dataRow = @class.tLogInOut.Rows[0];
					dataRow["Comment"] = string.Concat(new object[]
					{
						dataRow["Comment"],
						DateTime.Now.ToString(),
						": ",
						this.canvasControl_1.Mode.ToString(),
						"\n"
					});
					@class.tLogInOut.Rows[0].EndEdit();
					base.UpdateSqlData(@class, @class.tLogInOut);
				}
			}
		}

		private void dockPanel_0_ActiveDocumentChanged(object sender, EventArgs e)
		{
			if (this.dockPanel_0.ActiveDocument != null)
			{
				if (this.dockPanel_0.ActiveDocument.GetType() == typeof(DockContentBase) && ((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
				{
					this.canvasControl_1 = (CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0];
					if (this.canvasControl_1.Layers.Count<ICanvasLayer>() > 0)
					{
						this.method_21();
					}
					switch (this.canvasControl_1.TypeCanvas)
					{
					case eTypeCanvas.SchemeMain:
						this.toolStripSeparator_10.Visible = true;
						this.toolStripButton_29.Visible = true;
						this.toolStripButton_30.Visible = true;
						this.toolStripButton_31.Visible = true;
						this.toolStripButton_32.Visible = true;
						this.toolStripSplitButton_0.Visible = false;
						this.toolStripSeparator_13.Visible = true;
						this.toolStripButton_38.Visible = true;
						this.toolStripButton_39.Visible = true;
						this.toolStripLabel_0.Visible = true;
						this.toolStripButton_42.Visible = false;
						this.toolStripButton_43.Visible = false;
						this.toolStripComboBox_0.Visible = true;
						this.toolStripComboBox_1.Visible = false;
						this.toolStripButton_19.Visible = true;
						this.toolStripButton_45.Visible = false;
						break;
					case eTypeCanvas.SchemeSecond:
						this.toolStripSeparator_10.Visible = false;
						this.toolStripButton_29.Visible = false;
						this.toolStripButton_30.Visible = false;
						this.toolStripButton_31.Visible = false;
						this.toolStripButton_32.Visible = false;
						this.toolStripSeparator_13.Visible = false;
						this.toolStripButton_38.Visible = false;
						this.toolStripButton_39.Visible = false;
						this.toolStripLabel_0.Visible = true;
						this.toolStripSeparator_11.Visible = true;
						this.toolStripButton_42.Visible = true;
						this.toolStripButton_43.Visible = true;
						this.toolStripComboBox_0.Visible = false;
						this.toolStripComboBox_1.Visible = true;
						this.toolStripButton_19.Visible = false;
						this.toolStripButton_45.Visible = true;
						break;
					case eTypeCanvas.SchemaClone:
						this.toolStripSeparator_10.Visible = false;
						this.toolStripButton_29.Visible = false;
						this.toolStripButton_30.Visible = false;
						this.toolStripButton_31.Visible = false;
						this.toolStripButton_32.Visible = false;
						this.toolStripSeparator_13.Visible = false;
						this.toolStripButton_38.Visible = false;
						this.toolStripButton_39.Visible = false;
						this.toolStripSplitButton_0.Visible = false;
						this.toolStripComboBox_0.Visible = false;
						this.toolStripComboBox_1.Visible = false;
						this.toolStripButton_19.Visible = false;
						this.toolStripButton_45.Visible = false;
						this.toolStripLabel_0.Visible = false;
						this.toolStripSeparator_11.Visible = false;
						this.toolStripButton_42.Visible = false;
						this.toolStripButton_43.Visible = false;
						break;
					}
					switch (this.canvasControl_1.Mode)
					{
					case eCanvasEditingMode.ReadOnly:
						this.toolStripComboBox_0.SelectedIndex = 0;
						this.toolStripComboBox_1.SelectedIndex = 0;
						break;
					case eCanvasEditingMode.Dispatcher:
						this.toolStripComboBox_0.SelectedIndex = 1;
						this.toolStripComboBox_1.SelectedIndex = 1;
						break;
					case eCanvasEditingMode.Edit:
						this.toolStripComboBox_0.SelectedIndex = 2;
						this.toolStripComboBox_1.SelectedIndex = 2;
						break;
					}
					this.canvasControl_1.LineInformationVisible = this.LineInformationVisible;
					this.canvasControl_1.TelemetryLabelVisible = this.TelemetryLabelVisible;
					base.SetControlsPropertiesUser();
					switch (this.canvasControl_1.TypeCanvas)
					{
					case eTypeCanvas.SchemeMain:
						this.toolStripComboBox_1.Visible = false;
						this.toolStripButton_45.Visible = false;
						break;
					case eTypeCanvas.SchemeSecond:
						this.toolStripComboBox_0.Visible = false;
						this.toolStripButton_19.Visible = false;
						break;
					case eTypeCanvas.SchemaClone:
						this.toolStripComboBox_0.Visible = false;
						this.toolStripComboBox_1.Visible = false;
						this.toolStripButton_19.Visible = false;
						this.toolStripButton_45.Visible = false;
						break;
					}
					this.canvasControl_1.DoInvalidate(true);
					this.toolStrip_3.Visible = true;
					this.toolStrip_2.Visible = true;
					this.toolStrip_5.Visible = true;
					this.toolStrip_1.Visible = true;
					this.toolStrip_0.Visible = true;
					this.toolStrip_4.Visible = true;
					return;
				}
				this.toolStrip_3.Visible = false;
				this.toolStrip_2.Visible = false;
				this.toolStrip_5.Visible = false;
				this.toolStrip_1.Visible = false;
				this.toolStrip_0.Visible = false;
				this.toolStrip_4.Visible = false;
			}
		}

		private void toolStripButton_9_Click(object sender, EventArgs e)
		{
		}

		private DockContentBase method_53(string string_0)
		{
			DockContentBase dockContentBase = new DockContentBase();
			CanvasControl canvasControl = new CanvasControl();
			dockContentBase.SqlSettings = this.SqlSettings;
			dockContentBase.Controls.Add(canvasControl);
			canvasControl.Dock = DockStyle.Fill;
			canvasControl.SqlSettings = this.SqlSettings;
			canvasControl.Settings = this.canvasScheme.Settings;
			dockContentBase.DockAreas = 32;
			dockContentBase.Text = string_0;
			canvasControl.ShowContextMenuCanvasEvent += this.canvasScheme_ShowContextMenuCanvasEvent;
			canvasControl.HideContextMenuCanvasEvent += this.canvasControl_0_HideContextMenuCanvasEvent;
			canvasControl.ObjectsAdded += this.canvasScheme_ObjectsAdded;
			canvasControl.ObjectClicked += this.canvasScheme_ObjectClicked;
			canvasControl.FlashObjectsAdded += this.canvasControl_0_FlashObjectsAdded;
			canvasControl.FlashObjectsRemoved += this.canvasControl_0_FlashObjectsRemoved;
			canvasControl.ContextMenuRectangle = this.contextMenuStrip_0;
			canvasControl.TypeCanvas = eTypeCanvas.SchemaClone;
			DrawingLayer layer = new DrawingLayer();
			canvasControl.AddLayer(layer);
			return dockContentBase;
		}

		private void toolStripButton_35_Click(object sender, EventArgs e)
		{
			if ((DockContentBase)this.dockPanel_0.ActiveDocument != null && ((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl) && this.dockPanel_0.ActiveDocument != null && ((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]).Layers.Count<ICanvasLayer>() > 0 && ((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]).SelectedCount > 0)
			{
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				list.AddRange(((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]).SelectedObjects);
				DockContentBase dockContentBase = this.method_53("Дополнительная вкладка");
				CanvasControl canvasControl = (CanvasControl)dockContentBase.Controls[0];
				foreach (DrawObjectBase drawObjectBase in from o in list
				where o.GetType() == typeof(RectangleTool)
				select o)
				{
					((DrawingLayer)canvasControl.ActiveLayer).AddObject(drawObjectBase);
					if (drawObjectBase.Selected)
					{
						canvasControl.SelectObject(drawObjectBase);
					}
				}
				foreach (DrawObjectBase drawObjectBase2 in from o in list
				where o.GetType() == typeof(ShinaTool)
				select o)
				{
					((DrawingLayer)canvasControl.ActiveLayer).AddObject(drawObjectBase2);
					if (drawObjectBase2.Selected)
					{
						canvasControl.SelectObject(drawObjectBase2);
					}
				}
				foreach (DrawObjectBase drawObjectBase3 in from o in list
				where (o.GetType() == typeof(BranchCollection) && ((BranchCollection)o).Collection.Count<Branch>() > 0) || o.GetType() == typeof(LineTool) || o.GetType() == typeof(LineCellTool)
				select o)
				{
					if (drawObjectBase3 is BranchCollection && ((BranchCollection)drawObjectBase3).Collection.Count<Branch>() > 0)
					{
						((DrawingLayer)canvasControl.ActiveLayer).AddObject(((BranchCollection)drawObjectBase3).Collection.First<Branch>().Parent);
					}
					else
					{
						((DrawingLayer)canvasControl.ActiveLayer).AddObject(drawObjectBase3);
					}
					if (drawObjectBase3.Selected)
					{
						canvasControl.SelectObject(drawObjectBase3);
					}
				}
				foreach (DrawObjectBase drawObjectBase4 in from o in list
				where o.GetType().BaseType == typeof(ObjectOnLine)
				select o)
				{
					((DrawingLayer)canvasControl.ActiveLayer).AddObject(drawObjectBase4);
					if (drawObjectBase4.Selected)
					{
						canvasControl.SelectObject(drawObjectBase4);
					}
				}
				canvasControl.FitToScreen();
				dockContentBase.Show(this.dockPanel_0);
			}
		}

		private void toolStripButton_38_Click(object sender, EventArgs e)
		{
			if (((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]).SelectedObjects.Count<DrawObjectBase>() < 2)
			{
				return;
			}
			GroupDrawObjectBase groupDrawObjectBase = new GroupDrawObjectBase();
			foreach (DrawObjectBase item in ((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]).SelectedObjects)
			{
				groupDrawObjectBase.Add(item);
			}
			new GroupPropertyForm(groupDrawObjectBase).ShowDialog();
		}

		private void toolStripButton_39_Click(object sender, EventArgs e)
		{
			IEnumerable<DrawObjectBase> selectedObjects = ((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]).SelectedObjects;
			if (selectedObjects.Count<DrawObjectBase>() < 2)
			{
				return;
			}
			List<GroupDrawObjectBase> list = new List<GroupDrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in selectedObjects)
			{
				if (drawObjectBase.Group != null && !list.Contains(drawObjectBase.Group))
				{
					list.Add(drawObjectBase.Group);
				}
			}
			foreach (GroupDrawObjectBase groupDrawObjectBase in list)
			{
				groupDrawObjectBase.Remove();
			}
		}

		private void contextMenuStrip_0_Opening(object sender, CancelEventArgs e)
		{
			this.toolStripMenuItem_7.Visible = (this.canvasScheme.Mode != eCanvasEditingMode.ReadOnly);
			this.toolStripMenuItem_27.Visible = (this.canvasScheme.Mode == eCanvasEditingMode.Edit);
			this.toolStripMenuItem_3.Visible = (this.canvasScheme.Mode == eCanvasEditingMode.Edit);
			this.toolStripMenuItem_2.Visible = (this.canvasScheme.Mode == eCanvasEditingMode.Edit);
			this.toolStripSeparator_2.Visible = (this.canvasScheme.Mode == eCanvasEditingMode.Edit);
			this.toolStripMenuItem_10.Visible = (this.canvasScheme.Mode == eCanvasEditingMode.Edit);
			this.toolStripSeparator_3.Visible = (this.canvasScheme.Mode == eCanvasEditingMode.Edit);
			this.toolStripMenuItem_40.Visible = (this.canvasScheme.Mode == eCanvasEditingMode.Edit);
			this.toolStripMenuItem_24.Enabled = (this.canvasScheme.Mode == eCanvasEditingMode.Edit && CopyPasteCanvasObjects.IsPasteInObjects(this.canvasScheme.SelectedObjects.ToList<DrawObjectBase>(), this.canvasScheme.CopiedObjects.ToList<DrawObjectBase>()));
			this.toolStripMenuItem_11.Checked = false;
			this.toolStripMenuItem_11.Tag = typeof(AutomaticEntryProvisionTool);
			this.toolStripMenuItem_12.Checked = false;
			this.toolStripMenuItem_12.Tag = typeof(SpecialLockingTool);
			this.toolStripMenuItem_17.Checked = false;
			this.toolStripMenuItem_17.Tag = typeof(TelemechanicsTool);
			this.toolStripMenuItem_18.Checked = false;
			this.toolStripMenuItem_18.Tag = typeof(TelemechanicsProtectionTool);
			this.toolStripMenuItem_35.Checked = false;
			this.toolStripMenuItem_35.Tag = typeof(VideoTool);
			this.toolStripMenuItem_22.Tag = typeof(ResponsibleAbonentTool);
			if (this.contextMenuStrip_0.Tag != null)
			{
				foreach (DrawObjectBase drawObjectBase in ((RectangleTool)this.contextMenuStrip_0.Tag).ChildObjects)
				{
					if (drawObjectBase.GetType() == typeof(AutomaticEntryProvisionTool))
					{
						this.toolStripMenuItem_11.Checked = true;
					}
					if (drawObjectBase.GetType() == typeof(SpecialLockingTool))
					{
						this.toolStripMenuItem_12.Checked = true;
					}
					if (drawObjectBase.GetType() == typeof(TelemechanicsTool))
					{
						this.toolStripMenuItem_17.Checked = true;
					}
					if (drawObjectBase.GetType() == typeof(TelemechanicsProtectionTool))
					{
						this.toolStripMenuItem_18.Checked = true;
					}
					if (drawObjectBase.GetType() == typeof(VideoTool))
					{
						this.toolStripMenuItem_35.Checked = true;
					}
				}
			}
		}

		private void toolStripMenuItem_14_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				List<DrawObjectBase> powerSource = ((RectangleTool)this.contextMenuStrip_0.Tag).GetPowerSource();
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				foreach (DrawObjectBase drawObjectBase in powerSource)
				{
					list.Add(drawObjectBase);
					if (drawObjectBase is ShinaTool)
					{
						list.Add(drawObjectBase.Parent);
					}
					if (drawObjectBase is Branch)
					{
						foreach (DrawObjectBase item in drawObjectBase.ChildObjects)
						{
							list.Add(item);
						}
					}
				}
				if (Convert.ToInt32(((ToolStripDropDownItem)sender).Tag) == 1)
				{
					this.canvasScheme.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
					return;
				}
				if (Convert.ToInt32(((ToolStripDropDownItem)sender).Tag) == 2)
				{
					this.canvasScheme.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.flashing);
				}
			}
		}

		private void toolStripMenuItem_16_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				List<DrawObjectBase> recipientsPower = ((RectangleTool)this.contextMenuStrip_0.Tag).GetRecipientsPower();
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				foreach (DrawObjectBase drawObjectBase in recipientsPower)
				{
					list.Add(drawObjectBase);
					if (drawObjectBase is ShinaTool)
					{
						list.Add(drawObjectBase.Parent);
					}
					if (drawObjectBase is LineCellTool || drawObjectBase is LineTool)
					{
						foreach (Branch branch in ((LineTool)drawObjectBase).Branches)
						{
							foreach (DrawObjectBase item in branch.ChildObjects)
							{
								list.Add(item);
							}
						}
					}
				}
				if (Convert.ToInt32(((ToolStripDropDownItem)sender).Tag) == 1)
				{
					this.canvasScheme.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
					return;
				}
				if (Convert.ToInt32(((ToolStripDropDownItem)sender).Tag) == 2)
				{
					this.canvasScheme.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.flashing);
				}
			}
		}

		private void toolStripMenuItem_25_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenuStrip = this.contextMenuStrip_0;
			if (contextMenuStrip == null)
			{
				return;
			}
			if (contextMenuStrip.Tag == null)
			{
				return;
			}
			List<DrawObjectBase> adjacentSubstation = CanvasControl.GetAdjacentSubstation((DrawObjectBase)contextMenuStrip.Tag);
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in adjacentSubstation)
			{
				list.Add(drawObjectBase);
				if (drawObjectBase is LineTool || drawObjectBase is LineCellTool)
				{
					foreach (Branch branch in ((LineTool)drawObjectBase).Branches)
					{
						foreach (DrawObjectBase item in branch.ChildObjects)
						{
							list.Add(item);
						}
					}
				}
			}
			this.canvasScheme.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
		}

		private void toolStripMenuItem_38_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenuStrip = this.contextMenuStrip_0;
			if (contextMenuStrip == null)
			{
				return;
			}
			if (contextMenuStrip.Tag == null)
			{
				return;
			}
			DrawObjectBase dob = (DrawObjectBase)contextMenuStrip.Tag;
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.ShowFormAbnFromOldSchema(dob, Convert.ToInt32(((ToolStripMenuItem)sender).Tag) == 1);
			}
		}

		private void toolStripMenuItem_23_Click(object sender, EventArgs e)
		{
			this.canvasScheme.CopySelectedObjects();
		}

		private void toolStripMenuItem_24_Click(object sender, EventArgs e)
		{
			this.canvasScheme.PasteInObjects(this.canvasScheme.SelectedObjects.ToList<DrawObjectBase>());
		}

		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			if (this.canvasScheme.Mode == eCanvasEditingMode.Edit && this.canvasControl_1.SelectedCount > 0)
			{
				this.canvasControl_1.RemoveSelectedObjects();
				this.canvasControl_1.CommandEscape();
			}
		}

		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
				foreach (DrawObjectBase drawObjectBase in rectangleTool.ChildObjects)
				{
					if (drawObjectBase.Layer != null)
					{
						drawObjectBase.Align();
					}
				}
				rectangleTool.SaveToSql(false, true);
			}
		}

		private void toolStripMenuItem_30_Click(object sender, EventArgs e)
		{
			RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
			UnitPoint empty = UnitPoint.Empty;
			UnitPoint empty2 = UnitPoint.Empty;
			string a = ((ToolStripMenuItem)sender).Tag.ToString();
			if (!(a == "H"))
			{
				if (a == "V")
				{
					empty = new UnitPoint((double)(rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width / 2f), (double)rectangleTool.Rectangle.Y);
					empty2 = new UnitPoint((double)(rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width / 2f), (double)(rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height));
				}
			}
			else
			{
				empty = new UnitPoint((double)rectangleTool.Rectangle.X, (double)(rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height / 2f));
				empty2 = new UnitPoint((double)(rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width), (double)(rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height / 2f));
			}
			if (empty == UnitPoint.Empty)
			{
				return;
			}
			foreach (DrawObjectBase drawObjectBase in rectangleTool.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(ShinaTool))
				{
					((ShinaTool)drawObjectBase).ReflectAboutTheLine(empty, empty2);
				}
			}
			this.canvasScheme.DoInvalidate(true);
			rectangleTool.SaveToSql(false, true);
		}

		private void toolStripMenuItem_34_Click(object sender, EventArgs e)
		{
			RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
			float num = Convert.ToSingle(((ToolStripMenuItem)sender).Tag);
			UnitPoint centerOfRotation = new UnitPoint((double)(rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width / 2f), (double)(rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height / 2f));
			rectangleTool.RotateAboutThePoint((double)num, centerOfRotation);
			this.canvasScheme.DoInvalidate(true);
			rectangleTool.SaveToSql(false, true);
		}

		private void toolStripMenuItem_39_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenuStrip = this.contextMenuStrip_0;
			if (contextMenuStrip == null)
			{
				return;
			}
			if (contextMenuStrip.Tag == null)
			{
				return;
			}
			DrawObjectBase obj = (DrawObjectBase)contextMenuStrip.Tag;
			if (this.canvasControl_1 != null)
			{
				this.canvasControl_1.ShowFormSchmObjFile(obj);
			}
		}

		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				((RectangleTool)this.contextMenuStrip_0.Tag).ShowPropertyForm(((ToolStripMenuItem)sender).GetCurrentParent().Location);
			}
		}

		private void toolStripMenuItem_5_Click(object sender, EventArgs e)
		{
			RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
			if (!this.dictionary_0.ContainsKey(rectangleTool))
			{
				DockContentBase dockContentBase = new DockContentBase();
				dockContentBase.Load += this.method_48;
				dockContentBase.FormClosing += this.method_54;
				dockContentBase.FormClosed += this.method_49;
				dockContentBase.SqlSettings = this.SqlSettings;
				CanvasControl canvasControl = new CanvasControl();
				dockContentBase.Controls.Add(canvasControl);
				canvasControl.Dock = DockStyle.Fill;
				canvasControl.SqlSettings = this.SqlSettings;
				dockContentBase.DockAreas = 32;
				dockContentBase.Text = rectangleTool.ToString();
				canvasControl.TypeCanvas = eTypeCanvas.SchemeSecond;
				canvasControl.Monopoly = false;
				canvasControl.Mode = this.canvasScheme.Mode;
				canvasControl.SimulationMode = this.canvasScheme.SimulationMode;
				dockContentBase.ShowForm += this.method_12;
				dockContentBase.Show(this.dockPanel_0);
				canvasControl.UseObjectFromDB = true;
				canvasControl.CanvasMessage += this.canvasControl_0_CanvasMessage;
				canvasControl.LoadScheme(rectangleTool);
				canvasControl.Settings.LoadSchemeFromBase(canvasControl.SqlSettings, canvasControl.TypeCanvas);
				canvasControl.Settings.MeasurementYear = this.canvasScheme.Settings.MeasurementYear;
				canvasControl.MeasurementLabelVisible = this.canvasScheme.MeasurementLabelVisible;
				canvasControl.OpcClient = this.opcClient;
				this.method_21();
				canvasControl.UpdateAllTelemetryLabels();
				canvasControl.UpdateMeasurementForBus();
			}
		}

		private void method_54(object sender, FormClosingEventArgs e)
		{
			if (((DockContentBase)sender).Controls.Count > 0 && ((DockContentBase)sender).Controls[0] is CanvasControl && (((CanvasControl)((DockContentBase)sender).Controls[0]).WorkerCounter > 0 || this.bool_1))
			{
				e.Cancel = true;
			}
		}

		private void pYnMneGkhg_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
				new FormDockPassport(this.SqlSettings, rectangleTool.IdBase).Show(this.dockPanel_0);
			}
		}

		private void toolStripMenuItem_6_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
				new FormLinkCellPoint(new List<int>
				{
					rectangleTool.IdBase
				})
				{
					SqlSettings = this.SqlSettings,
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripMenuItem_49_Click(object sender, EventArgs e)
		{
			RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
			new FormJournalOrder(new List<int>
			{
				rectangleTool.IdBase
			})
			{
				MdiParent = base.MdiParent,
				SqlSettings = this.SqlSettings
			}.Show();
		}

		private void toolStripMenuItem_42_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
				ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
				showFormEventArgs.TypeForm = "Documents.Forms.Measurement.FormMeasurement, Documents";
				showFormEventArgs.FormMode = eFormMode.Dialog;
				showFormEventArgs.Param = new object[1];
				showFormEventArgs.Param[0] = rectangleTool.IdBase;
				showFormEventArgs.SQLSettings = this.SqlSettings;
				this.OnShowForm(showFormEventArgs);
			}
		}

		private void toolStripMenuItem_50_Click(object sender, EventArgs e)
		{
			new FormJournalRelayProtectionAutomation(((RectangleTool)this.contextMenuStrip_0.Tag).IdBase)
			{
				MdiParent = base.MdiParent,
				SqlSettings = this.SqlSettings
			}.Show();
		}

		private void toolStripMenuItem_43_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
				List<int> list = new List<int>();
				list.Add(rectangleTool.IdBase);
				ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
				showFormEventArgs.TypeForm = "Documents.Forms.TechnologicalConnection.TU.FormJournalTU, Documents";
				showFormEventArgs.FormMode = eFormMode.Mdi;
				showFormEventArgs.Param = new object[1];
				showFormEventArgs.Param[0] = list;
				showFormEventArgs.SQLSettings = this.SqlSettings;
				this.OnShowForm(showFormEventArgs);
			}
		}

		private void toolStripMenuItem_44_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
				List<int> list = new List<int>();
				list.Add(rectangleTool.IdBase);
				ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
				showFormEventArgs.TypeForm = "Documents.Forms.TechnologicalConnection.Contract.FormJournalContract, Documents";
				showFormEventArgs.FormMode = eFormMode.Mdi;
				showFormEventArgs.Param = new object[1];
				showFormEventArgs.Param[0] = list;
				showFormEventArgs.SQLSettings = this.SqlSettings;
				this.OnShowForm(showFormEventArgs);
			}
		}

		private void toolStripMenuItem_47_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
				RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
				List<int> list = new List<int>();
				list.Add(rectangleTool.IdBase);
				ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
				showFormEventArgs.TypeForm = "Documents.Forms.TechnologicalConnection.ActTC.FormJournalActs, Documents";
				showFormEventArgs.FormMode = eFormMode.Mdi;
				showFormEventArgs.Param = new object[2];
				showFormEventArgs.Param[0] = list;
				showFormEventArgs.Param[1] = Convert.ToInt32(toolStripMenuItem.Tag);
				showFormEventArgs.SQLSettings = this.SqlSettings;
				this.OnShowForm(showFormEventArgs);
			}
		}

		private void toolStripMenuItem_51_Click(object sender, EventArgs e)
		{
			RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
			new FormJournalActRBP(new List<int>
			{
				rectangleTool.IdBase
			})
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void IlbLiynpEJ_Click(object sender, EventArgs e)
		{
			RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
			new FormJournalDamage(new List<int>
			{
				rectangleTool.IdBase
			})
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void toolStripMenuItem_8_Click(object sender, EventArgs e)
		{
			new FormCanvasAddDelFilter(this.canvasScheme.SelectedObjects.ToList<DrawObjectBase>(), StateFormCreate.Add)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
		}

		private void toolStripMenuItem_9_Click(object sender, EventArgs e)
		{
			new FormCanvasAddDelFilter(this.canvasScheme.SelectedObjects.ToList<DrawObjectBase>(), StateFormCreate.Delete)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
		}

		private void toolStripMenuItem_22_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
				if (toolStripMenuItem.Tag == null)
				{
					return;
				}
				Type type = (Type)toolStripMenuItem.Tag;
				RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
				if (type == typeof(ResponsibleAbonentTool))
				{
					rectangleTool.AddLabelTool(type).ShowPropertyForm(((ToolStripMenuItem)sender).GetCurrentParent().Location);
				}
				else if (!toolStripMenuItem.Checked)
				{
					rectangleTool.RemoveLabelTool(type);
				}
				else
				{
					rectangleTool.AddLabelTool(type).SaveToSql(false, true);
				}
			}
			this.canvasScheme.DoInvalidate(true);
		}

		private void toolStripMenuItem_40_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				if (this.contextMenuStrip_0.Tag == null)
				{
					return;
				}
				RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
				TelemetryLabelTool telemetryLabelTool = new TelemetryLabelTool();
				telemetryLabelTool.ObjectTelemetry = rectangleTool.IdBase;
				if (rectangleTool.clickedPoint.IsEmpty)
				{
					telemetryLabelTool.Location = new UnitPoint(rectangleTool.Rectangle.Location);
				}
				else
				{
					telemetryLabelTool.Location = new UnitPoint(rectangleTool.clickedPoint.Point);
				}
				rectangleTool.Layer.AddObject(telemetryLabelTool);
				if (!telemetryLabelTool.ShowPropertyForm(((ToolStripMenuItem)sender).GetCurrentParent().Location))
				{
					telemetryLabelTool.Remove(false, false);
				}
			}
		}

		private void toolStripButton_32_Click(object sender, EventArgs e)
		{
			if (this.dockPanel_0.ActiveDocument.GetType() == typeof(DockContentBase) && ((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
			{
				((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]).ClearBookmarks();
			}
		}

		private void toolStripButton_31_Click(object sender, EventArgs e)
		{
			if (this.dockPanel_0.ActiveDocument.GetType() == typeof(DockContentBase) && ((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
			{
				((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]).NextBookmark();
			}
		}

		private void toolStripButton_29_Click(object sender, EventArgs e)
		{
			if (this.dockPanel_0.ActiveDocument.GetType() == typeof(DockContentBase) && ((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
			{
				((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]).PrevBookmark();
			}
		}

		private void toolStripButton_30_Click(object sender, EventArgs e)
		{
			if (this.dockPanel_0.ActiveDocument.GetType() == typeof(DockContentBase) && ((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
			{
				((CanvasControl)((DockContentBase)this.dockPanel_0.ActiveDocument).Controls[0]).CurrentBookmark();
			}
		}

		public bool SetObjectsInCenterScreen(List<int> idObjects)
		{
			if (this.canvasScheme.SetObjectsInCenterScreen(idObjects, true, CanvasControl.SetObjectsInCenterScreenOptions.select))
			{
				if (this.canvasScheme.Zoom > 2f)
				{
					this.canvasScheme.SetZoom(2f);
				}
				if (this.canvasScheme.Parent != null && this.canvasScheme.Parent is DockContentBase)
				{
					((DockContentBase)this.canvasScheme.Parent).Activate();
				}
				return true;
			}
			if (idObjects.Count == 1)
			{
				DataTable dataTable = new DataTable("tSchm_Xml");
				dataTable.Columns.Add("Tag", typeof(int));
				base.SelectSqlData(dataTable, true, string.Format(" where ObjId = {0} and TypeSchema = 2 and Tag is not null", idObjects[0]), null, false, 0);
				if (dataTable.Rows.Count > 0)
				{
					DrawObjectBase drawObjectBase = this.canvasScheme.FindObjectById(Convert.ToInt32(dataTable.Rows[0]["Tag"]));
					if (drawObjectBase != null && drawObjectBase is RectangleTool)
					{
						DockContentBase dockContentBase = new DockContentBase();
						dockContentBase.Load += this.method_48;
						dockContentBase.FormClosing += this.method_54;
						dockContentBase.FormClosed += this.method_49;
						dockContentBase.SqlSettings = this.SqlSettings;
						CanvasControl canvasControl = new CanvasControl();
						dockContentBase.Controls.Add(canvasControl);
						canvasControl.Dock = DockStyle.Fill;
						canvasControl.SqlSettings = this.SqlSettings;
						dockContentBase.DockAreas = 32;
						dockContentBase.Text = drawObjectBase.ToString();
						canvasControl.TypeCanvas = eTypeCanvas.SchemeSecond;
						canvasControl.Monopoly = false;
						canvasControl.Mode = this.canvasScheme.Mode;
						canvasControl.SimulationMode = this.canvasScheme.SimulationMode;
						dockContentBase.ShowForm += this.method_12;
						dockContentBase.Show(this.dockPanel_0);
						canvasControl.UseObjectFromDB = true;
						canvasControl.CanvasMessage += this.canvasControl_0_CanvasMessage;
						canvasControl.LoadScheme((RectangleTool)drawObjectBase);
						canvasControl.Settings.LoadSchemeFromBase(canvasControl.SqlSettings, canvasControl.TypeCanvas);
						canvasControl.Settings.MeasurementYear = this.canvasScheme.Settings.MeasurementYear;
						canvasControl.MeasurementLabelVisible = this.canvasScheme.MeasurementLabelVisible;
						canvasControl.OpcClient = this.opcClient;
						this.method_21();
						canvasControl.UpdateAllTelemetryLabels();
						canvasControl.UpdateMeasurementForBus();
						if (canvasControl.SetObjectsInCenterScreen(idObjects, false, CanvasControl.SetObjectsInCenterScreenOptions.select))
						{
							if (canvasControl.Zoom > 2f)
							{
								canvasControl.SetZoom(2f);
							}
							return true;
						}
					}
				}
			}
			return false;
		}

		public CanvasControl ActiveCanvas
		{
			get
			{
				return this.canvasControl_1;
			}
		}

		public bool LineInformationVisible
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				this.bool_2 = value;
				this.canvasControl_1.LineInformationVisible = value;
				this.canvasControl_1.DoInvalidate(true);
				if (this.toolStripButton_40.Checked != value)
				{
					this.toolStripButton_40.Checked = value;
				}
			}
		}

		public bool TelemetryLabelVisible
		{
			get
			{
				return this.bool_3;
			}
			set
			{
				this.bool_3 = value;
				this.canvasControl_1.TelemetryLabelVisible = value;
				this.canvasControl_1.DoInvalidate(true);
				if (this.toolStripButton_50.Checked != value)
				{
					this.toolStripButton_50.Checked = value;
				}
			}
		}

		public bool MeasurementLabelVisible
		{
			get
			{
				return this.bool_4;
			}
			set
			{
				this.bool_4 = value;
				this.canvasControl_1.MeasurementLabelVisible = value;
				this.canvasControl_1.DoInvalidate(true);
				if (this.toolStripButton_52.Checked != value)
				{
					this.toolStripButton_52.Checked = value;
				}
			}
		}

		private void toolStripButton_40_Click(object sender, EventArgs e)
		{
			this.LineInformationVisible = this.toolStripButton_40.Checked;
			this.toolStripButton_40.Text = (this.toolStripButton_40.Checked ? "Информация на линиях: Вкл" : "Информация на линиях: Выкл");
		}

		private void method_55()
		{
			this.toolStripComboBox_2.Items.Clear();
			this.toolStripComboBox_2.Items.Add("Пиковые нагрузки (за все года)");
			this.toolStripComboBox_2.Items.Add("Последние замеры");
			try
			{
				DataTable dataTable = new DataTable();
				using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
				{
					using (SqlCommand sqlCommand = new SqlCommand("select year(m.DAteD) as [name], year(m.DAteD) as [year] from [tJ_MeasAmperageTransf] as mat\r\n                                                                    inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                                                               where  mat.deleted = 0 and m.[TypeDoc] = 1192 and m.dateD is not null\r\n                                                               group by year(m.DAteD)\r\n                                                               order by year(m.DAteD) desc"))
					{
						sqlCommand.Connection = sqlConnection;
						sqlConnection.Open();
						SqlDataReader reader = sqlCommand.ExecuteReader();
						dataTable.Load(reader);
						sqlConnection.Close();
					}
				}
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					this.toolStripComboBox_2.Items.Add(dataRow["year"].ToString());
				}
				this.toolStripComboBox_2.SelectedItem = this.canvasScheme.Settings.MeasurementYear.ToString();
			}
			catch
			{
			}
		}

		private void toolStripButton_52_CheckedChanged(object sender, EventArgs e)
		{
			this.MeasurementLabelVisible = this.toolStripButton_52.Checked;
			this.toolStripButton_50.Text = (this.toolStripButton_52.Checked ? "Метки замеров: Вкл" : "Метки замеров: Выкл");
		}

		private void toolStripComboBox_2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.canvasControl_1 != null)
			{
				switch (this.toolStripComboBox_2.SelectedIndex)
				{
				case -1:
					return;
				case 0:
				case 1:
					this.canvasControl_1.Settings.MeasurementYear = this.toolStripComboBox_2.SelectedIndex;
					this.canvasControl_1.UpdateMeasurementForBus();
					this.canvasControl_1.DoInvalidate(true);
					return;
				default:
					this.canvasControl_1.Settings.MeasurementYear = Convert.ToInt32(this.toolStripComboBox_2.SelectedItem);
					this.canvasControl_1.UpdateMeasurementForBus();
					this.canvasControl_1.DoInvalidate(true);
					break;
				}
			}
		}

		private void toolStripButton_50_CheckedChanged(object sender, EventArgs e)
		{
			this.TelemetryLabelVisible = this.toolStripButton_50.Checked;
			this.toolStripButton_51.Visible = this.toolStripButton_50.Checked;
			this.toolStripButton_50.Text = (this.toolStripButton_50.Checked ? "Метки телеметрии: Вкл" : "Метки телеметрии: Выкл");
		}

		private void toolStripButton_51_Click(object sender, EventArgs e)
		{
			this.canvasControl_1.UpdateAllTelemetryLabels();
		}

		private void toolStripButton_41_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_41.Checked)
			{
				if (this.canvasControl_1.CanvasCommandType != eCommandType.frame || this.canvasControl_1.CanvasCommandType != eCommandType.drawframe)
				{
					this.canvasControl_1.CommandDrawFrame();
					return;
				}
			}
			else if (this.canvasControl_1.CanvasCommandType == eCommandType.frame || this.canvasControl_1.CanvasCommandType == eCommandType.drawframe)
			{
				this.canvasControl_1.CommandEscape();
			}
		}

		private void toolStripButton_42_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeSecond)
			{
				if (MessageBox.Show("Вы действительно хотите отметить подстанцию как заполненню", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				{
					return;
				}
				if (this.SqlSettings == null)
				{
					return;
				}
				Class19 @class = new Class19();
				SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
				sqlDataCommand.SelectSqlData(@class.tSchm_CheckSecondLevel, false, "where idObj = " + this.canvasControl_1.IdRect, null, false, 0);
				SqlConnection sqlConnection = new SqlConnection(SqlDataConnect.GetConnectionString(this.SqlSettings));
				string cmdText = "select IDUser from tuser where login = SYSTEM_USER";
				sqlConnection.Open();
				int num = Convert.ToInt32(new SqlCommand(cmdText, sqlConnection).ExecuteScalar());
				sqlConnection.Close();
				if (@class.tSchm_CheckSecondLevel.Rows.Count == 0)
				{
					DataRow dataRow = @class.tSchm_CheckSecondLevel.NewRow();
					dataRow["idObj"] = this.canvasControl_1.IdRect;
					dataRow["idUserFilled"] = num;
					dataRow["DateFilling"] = DateTime.Now;
					@class.tSchm_CheckSecondLevel.Rows.Add(dataRow);
					sqlDataCommand.InsertSqlDataOneRow(@class.tSchm_CheckSecondLevel);
				}
				else
				{
					DataRow dataRow2 = @class.tSchm_CheckSecondLevel.Rows[0];
					dataRow2["idUserFilled"] = num;
					dataRow2["DateFilling"] = DateTime.Now;
					sqlDataCommand.UpdateSqlData(@class, @class.tSchm_CheckSecondLevel);
				}
				this.class17_0.method_11();
			}
		}

		private void toolStripButton_43_Click(object sender, EventArgs e)
		{
			if (this.canvasControl_1.TypeCanvas == eTypeCanvas.SchemeSecond)
			{
				if (MessageBox.Show("Вы действительно хотите отметить подстанцию как проверенную", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				{
					return;
				}
				if (this.SqlSettings == null)
				{
					return;
				}
				Class19 @class = new Class19();
				SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
				sqlDataCommand.SelectSqlData(@class.tSchm_CheckSecondLevel, false, "where idObj = " + this.canvasControl_1.IdRect, null, false, 0);
				SqlConnection sqlConnection = new SqlConnection(SqlDataConnect.GetConnectionString(this.SqlSettings));
				string cmdText = "select IDUser from tuser where login = SYSTEM_USER";
				sqlConnection.Open();
				int num = Convert.ToInt32(new SqlCommand(cmdText, sqlConnection).ExecuteScalar());
				sqlConnection.Close();
				if (@class.tSchm_CheckSecondLevel.Rows.Count > 0)
				{
					DataRow dataRow = @class.tSchm_CheckSecondLevel.Rows[0];
					dataRow["idUserChecked"] = num;
					dataRow["CheckDate"] = DateTime.Now;
					sqlDataCommand.UpdateSqlData(@class, @class.tSchm_CheckSecondLevel);
				}
				this.class17_0.method_11();
			}
		}

		private void toolStripButton_49_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_49.Checked)
			{
				if (this.canvasControl_1.SimulationMode != eSimulationMode.Training)
				{
					this.canvasControl_1.SimulationMode = eSimulationMode.Training;
					DialogResult dialogResult = MessageBox.Show("Загрузить?(Нет - начать новую)", "Режим тренажёра");
					if (dialogResult != DialogResult.Yes && dialogResult != DialogResult.No)
					{
						this.toolStripButton_49.Checked = false;
						return;
					}
				}
			}
			else if (this.canvasControl_1.SimulationMode == eSimulationMode.Training)
			{
				this.canvasControl_1.SimulationMode = eSimulationMode.Online;
				this.toolStripButton_14_Click(sender, e);
			}
		}

		public override void GetNetworkMessage(object sender, SendCommandEventArgs e)
		{
		}

		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormGeneralScheme2));
			DockPanelSkin dockPanelSkin = new DockPanelSkin();
			AutoHideStripSkin autoHideStripSkin = new AutoHideStripSkin();
			DockPanelGradient dockPanelGradient = new DockPanelGradient();
			TabGradient tabGradient = new TabGradient();
			DockPaneStripSkin dockPaneStripSkin = new DockPaneStripSkin();
			DockPaneStripGradient dockPaneStripGradient = new DockPaneStripGradient();
			TabGradient tabGradient2 = new TabGradient();
			DockPanelGradient dockPanelGradient2 = new DockPanelGradient();
			TabGradient tabGradient3 = new TabGradient();
			DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient = new DockPaneStripToolWindowGradient();
			TabGradient tabGradient4 = new TabGradient();
			TabGradient tabGradient5 = new TabGradient();
			DockPanelGradient dockPanelGradient3 = new DockPanelGradient();
			TabGradient tabGradient6 = new TabGradient();
			TabGradient tabGradient7 = new TabGradient();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripButton_6 = new ToolStripButton();
			this.toolStripButton_7 = new ToolStripButton();
			this.toolStripButton_10 = new ToolStripButton();
			this.toolStripButton_8 = new ToolStripButton();
			this.toolStripButton_9 = new ToolStripButton();
			this.toolStripButton_5 = new ToolStripButton();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.toolStrip_1 = new ToolStrip();
			this.toolStripButton_12 = new ToolStripButton();
			this.toolStripButton_11 = new ToolStripButton();
			this.toolStripButton_41 = new ToolStripButton();
			this.toolStripSeparator_6 = new ToolStripSeparator();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripButton_36 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripButton_33 = new ToolStripButton();
			this.toolStripButton_34 = new ToolStripButton();
			this.toolStripSeparator_13 = new ToolStripSeparator();
			this.toolStripButton_38 = new ToolStripButton();
			this.toolStripButton_39 = new ToolStripButton();
			this.toolStripSeparator_14 = new ToolStripSeparator();
			this.toolStripButton_40 = new ToolStripButton();
			this.toolStripButton_52 = new ToolStripButton();
			this.toolStripComboBox_2 = new ToolStripComboBox();
			this.toolStripButton_44 = new ToolStripButton();
			this.toolStripButton_42 = new ToolStripButton();
			this.toolStripButton_43 = new ToolStripButton();
			this.toolStripButton_50 = new ToolStripButton();
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_5 = new ToolStripMenuItem();
			this.pYnMneGkhg = new ToolStripMenuItem();
			this.toolStripMenuItem_6 = new ToolStripMenuItem();
			this.toolStripMenuItem_41 = new ToolStripMenuItem();
			this.toolStripMenuItem_49 = new ToolStripMenuItem();
			this.toolStripMenuItem_42 = new ToolStripMenuItem();
			this.toolStripMenuItem_50 = new ToolStripMenuItem();
			this.toolStripSeparator_16 = new ToolStripSeparator();
			this.toolStripMenuItem_48 = new ToolStripMenuItem();
			this.toolStripMenuItem_43 = new ToolStripMenuItem();
			this.toolStripMenuItem_44 = new ToolStripMenuItem();
			this.toolStripSeparator_17 = new ToolStripSeparator();
			this.toolStripMenuItem_45 = new ToolStripMenuItem();
			this.toolStripMenuItem_46 = new ToolStripMenuItem();
			this.toolStripMenuItem_47 = new ToolStripMenuItem();
			this.toolStripSeparator_18 = new ToolStripSeparator();
			this.toolStripMenuItem_51 = new ToolStripMenuItem();
			this.IlbLiynpEJ = new ToolStripMenuItem();
			this.toolStripSeparator_5 = new ToolStripSeparator();
			this.toolStripMenuItem_10 = new ToolStripMenuItem();
			this.toolStripMenuItem_11 = new ToolStripMenuItem();
			this.toolStripMenuItem_12 = new ToolStripMenuItem();
			this.toolStripMenuItem_17 = new ToolStripMenuItem();
			this.toolStripMenuItem_18 = new ToolStripMenuItem();
			this.toolStripMenuItem_35 = new ToolStripMenuItem();
			this.toolStripMenuItem_22 = new ToolStripMenuItem();
			this.toolStripMenuItem_40 = new ToolStripMenuItem();
			this.toolStripSeparator_3 = new ToolStripSeparator();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_13 = new ToolStripMenuItem();
			this.toolStripMenuItem_14 = new ToolStripMenuItem();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripMenuItem_15 = new ToolStripMenuItem();
			this.toolStripMenuItem_16 = new ToolStripMenuItem();
			this.toolStripMenuItem_25 = new ToolStripMenuItem();
			this.toolStripMenuItem_36 = new ToolStripMenuItem();
			this.toolStripMenuItem_37 = new ToolStripMenuItem();
			this.toolStripMenuItem_38 = new ToolStripMenuItem();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripMenuItem_7 = new ToolStripMenuItem();
			this.toolStripMenuItem_8 = new ToolStripMenuItem();
			this.toolStripMenuItem_9 = new ToolStripMenuItem();
			this.toolStripSeparator_4 = new ToolStripSeparator();
			this.toolStripMenuItem_23 = new ToolStripMenuItem();
			this.toolStripMenuItem_24 = new ToolStripMenuItem();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.toolStripMenuItem_27 = new ToolStripMenuItem();
			this.toolStripMenuItem_28 = new ToolStripMenuItem();
			this.toolStripMenuItem_29 = new ToolStripMenuItem();
			this.toolStripMenuItem_30 = new ToolStripMenuItem();
			this.toolStripMenuItem_31 = new ToolStripMenuItem();
			this.toolStripMenuItem_32 = new ToolStripMenuItem();
			this.toolStripMenuItem_33 = new ToolStripMenuItem();
			this.toolStripMenuItem_34 = new ToolStripMenuItem();
			this.toolStripMenuItem_3 = new ToolStripMenuItem();
			this.toolStripSeparator_2 = new ToolStripSeparator();
			this.toolStripMenuItem_39 = new ToolStripMenuItem();
			this.toolStripMenuItem_4 = new ToolStripMenuItem();
			this.backgroundWorker_1 = new BackgroundWorker();
			this.panel_0 = new Panel();
			this.label_0 = new Label();
			this.progressBarEndLess_0 = new ProgressBarEndLess();
			this.toolStrip_2 = new ToolStrip();
			this.toolStripButton_13 = new ToolStripButton();
			this.toolStripButton_14 = new ToolStripButton();
			this.toolStripButton_15 = new ToolStripButton();
			this.toolStripSeparator_7 = new ToolStripSeparator();
			this.toolStripButton_45 = new ToolStripButton();
			this.toolStripButton_19 = new ToolStripButton();
			this.toolStripButton_53 = new ToolStripButton();
			this.toolStripSeparator_11 = new ToolStripSeparator();
			this.toolStripLabel_0 = new ToolStripLabel();
			this.toolStripComboBox_1 = new ToolStripComboBox();
			this.toolStripComboBox_0 = new ToolStripComboBox();
			this.toolStripSplitButton_0 = new ToolStripSplitButton();
			this.toolStripMenuItem_19 = new ToolStripMenuItem();
			this.toolStripMenuItem_20 = new ToolStripMenuItem();
			this.toolStripMenuItem_21 = new ToolStripMenuItem();
			this.toolStripMenuItem_26 = new ToolStripMenuItem();
			this.toolStripProgressBar_0 = new ToolStripProgressBar();
			this.toolStripLabel_1 = new ToolStripLabel();
			this.toolStripButton_49 = new ToolStripButton();
			this.toolStripButton_51 = new ToolStripButton();
			this.toolStrip_3 = new ToolStrip();
			this.toolStripButton_16 = new ToolStripButton();
			this.toolStripButton_17 = new ToolStripButton();
			this.toolStripButton_18 = new ToolStripButton();
			this.toolStripButton_37 = new ToolStripButton();
			this.toolStrip_4 = new ToolStrip();
			this.toolStripButton_20 = new ToolStripButton();
			this.toolStripSeparator_8 = new ToolStripSeparator();
			this.toolStripButton_21 = new ToolStripButton();
			this.toolStripButton_22 = new ToolStripButton();
			this.toolStripButton_23 = new ToolStripButton();
			this.toolStripButton_24 = new ToolStripButton();
			this.toolStripButton_25 = new ToolStripButton();
			this.toolStrip_5 = new ToolStrip();
			this.toolStripButton_26 = new ToolStripButton();
			this.toolStripButton_27 = new ToolStripButton();
			this.toolStripSeparator_12 = new ToolStripSeparator();
			this.toolStripButton_35 = new ToolStripButton();
			this.toolStripSeparator_9 = new ToolStripSeparator();
			this.toolStripButton_28 = new ToolStripButton();
			this.toolStripSeparator_10 = new ToolStripSeparator();
			this.toolStripButton_29 = new ToolStripButton();
			this.toolStripButton_30 = new ToolStripButton();
			this.toolStripButton_31 = new ToolStripButton();
			this.toolStripButton_32 = new ToolStripButton();
			this.toolStripSeparator_15 = new ToolStripSeparator();
			this.toolStripButton_46 = new ToolStripButton();
			this.toolStripTextBox_0 = new ToolStripTextBox();
			this.toolStripButton_47 = new ToolStripButton();
			this.toolStripButton_48 = new ToolStripButton();
			this.mniLotCpLE = new ToolStripSeparator();
			this.toolStripButton_54 = new ToolStripButton();
			this.toolStripContainer_0 = new ToolStripContainer();
			this.dockPanel_0 = new DockPanel();
			this.toolStrip_6 = new ToolStrip();
			this.dataGridViewImageColumn_18 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_17 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_16 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_15 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_14 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_13 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_12 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_11 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_10 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_9 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_7 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_6 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_3 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_2 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_1 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_4 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_5 = new DataGridViewImageColumn();
			this.dataGridViewImageColumn_8 = new DataGridViewImageColumn();
			this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.QynLzkVuoQ = new ToolStripButton();
			this.toolStrip_0.SuspendLayout();
			this.toolStrip_1.SuspendLayout();
			this.contextMenuStrip_0.SuspendLayout();
			this.panel_0.SuspendLayout();
			this.toolStrip_2.SuspendLayout();
			this.toolStrip_3.SuspendLayout();
			this.toolStrip_4.SuspendLayout();
			this.toolStrip_5.SuspendLayout();
			this.toolStripContainer_0.ContentPanel.SuspendLayout();
			this.toolStripContainer_0.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer_0.SuspendLayout();
			this.toolStrip_6.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip_0.Dock = DockStyle.None;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_4,
				this.toolStripButton_6,
				this.toolStripButton_7,
				this.toolStripButton_10,
				this.toolStripButton_8,
				this.toolStripButton_9
			});
			this.toolStrip_0.Location = new Point(115, 75);
			this.toolStrip_0.Name = "toolStripWindows";
			this.toolStrip_0.Size = new Size(104, 25);
			this.toolStrip_0.TabIndex = 1;
			this.toolStrip_0.Text = "Доп. окна";
			this.toolStripButton_4.Checked = true;
			this.toolStripButton_4.CheckOnClick = true;
			this.toolStripButton_4.CheckState = CheckState.Checked;
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = Resources.smethod_66();
			this.toolStripButton_4.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_4.Name = "toolBtnTreeObjects";
			this.toolStripButton_4.Size = new Size(23, 22);
			this.toolStripButton_4.Text = "Дерево объектов";
			this.toolStripButton_4.Click += this.toolStripButton_4_Click;
			this.toolStripButton_6.Checked = true;
			this.toolStripButton_6.CheckOnClick = true;
			this.toolStripButton_6.CheckState = CheckState.Checked;
			this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_6.Image = Resources.Message;
			this.toolStripButton_6.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_6.Name = "toolBtnMessage";
			this.toolStripButton_6.Size = new Size(23, 22);
			this.toolStripButton_6.Text = "Панель сообщений";
			this.toolStripButton_6.Click += this.toolStripButton_6_Click;
			this.toolStripButton_7.Checked = true;
			this.toolStripButton_7.CheckOnClick = true;
			this.toolStripButton_7.CheckState = CheckState.Checked;
			this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_7.Image = Resources.smethod_2();
			this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_7.Name = "toolBtnPowering";
			this.toolStripButton_7.Size = new Size(23, 22);
			this.toolStripButton_7.Text = "Проверка \"второго\" уровня";
			this.toolStripButton_7.Click += this.toolStripButton_7_Click;
			this.toolStripButton_10.Checked = true;
			this.toolStripButton_10.CheckOnClick = true;
			this.toolStripButton_10.CheckState = CheckState.Checked;
			this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_10.Image = Resources.odqpIseRpC();
			this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_10.Name = "toolBtnStates";
			this.toolStripButton_10.Size = new Size(23, 22);
			this.toolStripButton_10.Text = "Статусы объектов";
			this.toolStripButton_10.Click += this.toolStripButton_10_Click;
			this.toolStripButton_8.CheckOnClick = true;
			this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_8.Image = (Image)componentResourceManager.GetObject("toolBtnSrvStart.Image");
			this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_8.Name = "toolBtnSrvStart";
			this.toolStripButton_8.Size = new Size(23, 22);
			this.toolStripButton_8.Text = "StartServer";
			this.toolStripButton_8.Visible = false;
			this.toolStripButton_9.CheckOnClick = true;
			this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_9.Image = (Image)componentResourceManager.GetObject("toolBtnSrvJoin.Image");
			this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_9.Name = "toolBtnSrvJoin";
			this.toolStripButton_9.Size = new Size(23, 22);
			this.toolStripButton_9.Text = "Join";
			this.toolStripButton_9.Visible = false;
			this.toolStripButton_9.Click += this.toolStripButton_9_Click;
			this.toolStripButton_5.Checked = true;
			this.toolStripButton_5.CheckOnClick = true;
			this.toolStripButton_5.CheckState = CheckState.Checked;
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = Resources.smethod_63();
			this.toolStripButton_5.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_5.Name = "toolBtnTelemetry";
			this.toolStripButton_5.Size = new Size(23, 22);
			this.toolStripButton_5.Text = "Телеметрия";
			this.toolStripButton_5.Click += this.toolStripButton_5_Click;
			this.backgroundWorker_0.WorkerReportsProgress = true;
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.ProgressChanged += this.backgroundWorker_0_ProgressChanged;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.toolStrip_1.Dock = DockStyle.None;
			this.toolStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_12,
				this.toolStripButton_11,
				this.toolStripButton_41,
				this.toolStripSeparator_6,
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripButton_2,
				this.toolStripButton_36,
				this.toolStripSeparator_0,
				this.toolStripButton_3,
				this.toolStripButton_33,
				this.toolStripButton_34,
				this.toolStripSeparator_13,
				this.toolStripButton_38,
				this.toolStripButton_39,
				this.toolStripSeparator_14,
				this.toolStripButton_40,
				this.toolStripButton_52,
				this.toolStripComboBox_2,
				this.toolStripButton_44,
				this.toolStripButton_42,
				this.toolStripButton_43
			});
			this.toolStrip_1.Location = new Point(107, 25);
			this.toolStrip_1.Name = "toolStripTools";
			this.toolStrip_1.Size = new Size(483, 25);
			this.toolStrip_1.TabIndex = 3;
			this.toolStrip_1.Text = "Инструменты";
			this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_12.Image = Resources.smethod_12();
			this.toolStripButton_12.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_12.Name = "toolBtnEscCanvas";
			this.toolStripButton_12.Size = new Size(23, 22);
			this.toolStripButton_12.Text = "Курсор";
			this.toolStripButton_12.Click += this.toolStripButton_12_Click;
			this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_11.Image = Resources.smethod_11();
			this.toolStripButton_11.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_11.Name = "toolBtnPanCanvas";
			this.toolStripButton_11.Size = new Size(23, 22);
			this.toolStripButton_11.Text = "Движение подложки";
			this.toolStripButton_11.Click += this.toolStripButton_11_Click;
			this.toolStripButton_41.CheckOnClick = true;
			this.toolStripButton_41.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_41.Image = Resources.smethod_33();
			this.toolStripButton_41.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_41.Name = "toolStripButtonSelectionFrame";
			this.toolStripButton_41.Size = new Size(23, 22);
			this.toolStripButton_41.Text = "Рамка";
			this.toolStripButton_41.Click += this.toolStripButton_41_Click;
			this.toolStripSeparator_6.Name = "toolStripSeparator1";
			this.toolStripSeparator_6.Size = new Size(6, 25);
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.smethod_15();
			this.toolStripButton_0.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_0.Name = "toolBtnRectangle";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "ТП,РП,ЦП,ПП";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.smethod_16();
			this.toolStripButton_1.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_1.Name = "toolBtnShina";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Шина";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.smethod_9();
			this.toolStripButton_2.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_2.Name = "toolBtnPolyLine";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Кабель";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.toolStripButton_36.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_36.Image = Resources.smethod_64();
			this.toolStripButton_36.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_36.Name = "toolBtnTextTool";
			this.toolStripButton_36.Size = new Size(23, 22);
			this.toolStripButton_36.Text = "Текст";
			this.toolStripButton_36.Click += this.toolStripButton_36_Click;
			this.toolStripSeparator_0.Name = "toolStripSeparatorTools";
			this.toolStripSeparator_0.Size = new Size(6, 25);
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = Resources.smethod_17();
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "tooBtnPatternTP";
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Шаблон ТП";
			this.toolStripButton_3.Click += this.toolStripButton_3_Click;
			this.toolStripButton_33.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_33.Enabled = false;
			this.toolStripButton_33.Image = (Image)componentResourceManager.GetObject("undoToolStripButton.Image");
			this.toolStripButton_33.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_33.Name = "undoToolStripButton";
			this.toolStripButton_33.Size = new Size(23, 22);
			this.toolStripButton_33.Text = "Отменить";
			this.toolStripButton_33.Click += this.toolStripButton_33_Click;
			this.toolStripButton_34.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_34.Enabled = false;
			this.toolStripButton_34.Image = (Image)componentResourceManager.GetObject("redoToolStripButton.Image");
			this.toolStripButton_34.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_34.Name = "redoToolStripButton";
			this.toolStripButton_34.Size = new Size(23, 22);
			this.toolStripButton_34.Text = "Возвратить";
			this.toolStripButton_34.Click += this.toolStripButton_34_Click;
			this.toolStripSeparator_13.Name = "toolStripSeparatorGroup";
			this.toolStripSeparator_13.Size = new Size(6, 25);
			this.toolStripButton_38.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_38.Image = Resources.smethod_57();
			this.toolStripButton_38.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_38.Name = "toolBtnGroup";
			this.toolStripButton_38.Size = new Size(23, 22);
			this.toolStripButton_38.Text = "Сгруппировать";
			this.toolStripButton_38.Click += this.toolStripButton_38_Click;
			this.toolStripButton_39.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_39.Image = Resources.smethod_58();
			this.toolStripButton_39.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_39.Name = "toolBtnUngroup";
			this.toolStripButton_39.Size = new Size(23, 22);
			this.toolStripButton_39.Text = "Разгруппировать";
			this.toolStripButton_39.Click += this.toolStripButton_39_Click;
			this.toolStripSeparator_14.Name = "toolStripSeparator8";
			this.toolStripSeparator_14.Size = new Size(6, 25);
			this.toolStripButton_40.Checked = true;
			this.toolStripButton_40.CheckOnClick = true;
			this.toolStripButton_40.CheckState = CheckState.Checked;
			this.toolStripButton_40.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_40.Image = Resources.smethod_60();
			this.toolStripButton_40.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_40.Name = "toolStripLineInformation";
			this.toolStripButton_40.Size = new Size(23, 22);
			this.toolStripButton_40.Text = "Информация на линиях";
			this.toolStripButton_40.Click += this.toolStripButton_40_Click;
			this.toolStripButton_52.Checked = true;
			this.toolStripButton_52.CheckOnClick = true;
			this.toolStripButton_52.CheckState = CheckState.Checked;
			this.toolStripButton_52.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_52.Image = Resources.measurement;
			this.toolStripButton_52.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_52.Name = "toolStripButtonMeasurementLabel";
			this.toolStripButton_52.Size = new Size(23, 22);
			this.toolStripButton_52.Text = "Метки замеров";
			this.toolStripButton_52.CheckedChanged += this.toolStripButton_52_CheckedChanged;
			this.toolStripComboBox_2.AutoSize = false;
			this.toolStripComboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.toolStripComboBox_2.FlatStyle = FlatStyle.System;
			this.toolStripComboBox_2.Name = "toolStripComboBoxMeasurementDate";
			this.toolStripComboBox_2.Size = new Size(100, 23);
			this.toolStripComboBox_2.ToolTipText = "Выберите год замеров";
			this.toolStripComboBox_2.SelectedIndexChanged += this.toolStripComboBox_2_SelectedIndexChanged;
			this.toolStripButton_44.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_44.Image = Resources.smethod_36();
			this.toolStripButton_44.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_44.Name = "toolStripButtonLineNoPassport";
			this.toolStripButton_44.Size = new Size(23, 22);
			this.toolStripButton_44.Text = "Кабельные линии без паспорта";
			this.toolStripButton_44.Click += this.toolStripButton_44_Click;
			this.toolStripButton_42.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_42.Image = (Image)componentResourceManager.GetObject("toolStripButtonDoneSecondLevel.Image");
			this.toolStripButton_42.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_42.Name = "toolStripButtonDoneSecondLevel";
			this.toolStripButton_42.Size = new Size(23, 22);
			this.toolStripButton_42.Text = "Схема заполнена";
			this.toolStripButton_42.Visible = false;
			this.toolStripButton_42.Click += this.toolStripButton_42_Click;
			this.toolStripButton_43.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_43.Image = (Image)componentResourceManager.GetObject("toolStripButtonCheckSecondLevel.Image");
			this.toolStripButton_43.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_43.Name = "toolStripButtonCheckSecondLevel";
			this.toolStripButton_43.Size = new Size(23, 22);
			this.toolStripButton_43.Text = "Схема проверена";
			this.toolStripButton_43.Visible = false;
			this.toolStripButton_43.Click += this.toolStripButton_43_Click;
			this.toolStripButton_50.Checked = true;
			this.toolStripButton_50.CheckOnClick = true;
			this.toolStripButton_50.CheckState = CheckState.Checked;
			this.toolStripButton_50.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_50.Image = Resources.smethod_4();
			this.toolStripButton_50.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_50.Name = "toolStripButtonTelemetryLabel";
			this.toolStripButton_50.Size = new Size(23, 22);
			this.toolStripButton_50.Text = "Метки телеметрии";
			this.toolStripButton_50.CheckedChanged += this.toolStripButton_50_CheckedChanged;
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_5,
				this.pYnMneGkhg,
				this.toolStripMenuItem_6,
				this.toolStripMenuItem_41,
				this.toolStripSeparator_5,
				this.toolStripMenuItem_10,
				this.toolStripMenuItem_40,
				this.toolStripSeparator_3,
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_25,
				this.toolStripMenuItem_36,
				this.toolStripSeparator_1,
				this.toolStripMenuItem_7,
				this.toolStripSeparator_4,
				this.toolStripMenuItem_23,
				this.toolStripMenuItem_24,
				this.toolStripMenuItem_2,
				this.toolStripMenuItem_27,
				this.toolStripMenuItem_3,
				this.toolStripSeparator_2,
				this.toolStripMenuItem_39,
				this.toolStripMenuItem_4
			});
			this.contextMenuStrip_0.Name = "contextMenuRectnagle";
			this.contextMenuStrip_0.Size = new Size(233, 430);
			this.contextMenuStrip_0.Opening += this.contextMenuStrip_0_Opening;
			this.toolStripMenuItem_5.Name = "toolMenuItemRectOpen";
			this.toolStripMenuItem_5.Size = new Size(232, 22);
			this.toolStripMenuItem_5.Text = "Раскрыть";
			this.toolStripMenuItem_5.Click += this.toolStripMenuItem_5_Click;
			this.pYnMneGkhg.Name = "toolMenuItemRectPassport";
			this.pYnMneGkhg.Size = new Size(232, 22);
			this.pYnMneGkhg.Text = "Паспорт";
			this.pYnMneGkhg.Click += this.pYnMneGkhg_Click;
			this.toolStripMenuItem_6.Name = "toolMenuItemRectAbonents";
			this.toolStripMenuItem_6.Size = new Size(232, 22);
			this.toolStripMenuItem_6.Text = "Абоненты";
			this.toolStripMenuItem_6.Visible = false;
			this.toolStripMenuItem_6.Click += this.toolStripMenuItem_6_Click;
			this.toolStripMenuItem_41.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_49,
				this.toolStripMenuItem_42,
				this.toolStripMenuItem_50,
				this.toolStripSeparator_16,
				this.toolStripMenuItem_48,
				this.IlbLiynpEJ
			});
			this.toolStripMenuItem_41.Name = "toolMenuItemRectDocuments";
			this.toolStripMenuItem_41.Size = new Size(232, 22);
			this.toolStripMenuItem_41.Text = "Документы";
			this.toolStripMenuItem_49.Image = Resources.smethod_35();
			this.toolStripMenuItem_49.Name = "toolMenuItemRectJournalOrder";
			this.toolStripMenuItem_49.Size = new Size(281, 22);
			this.toolStripMenuItem_49.Text = "Наряды";
			this.toolStripMenuItem_49.Click += this.toolStripMenuItem_49_Click;
			this.toolStripMenuItem_42.Image = Resources.measurement;
			this.toolStripMenuItem_42.Name = "toolMenuItemRectMeasurement";
			this.toolStripMenuItem_42.Size = new Size(281, 22);
			this.toolStripMenuItem_42.Text = "Замеры";
			this.toolStripMenuItem_42.Click += this.toolStripMenuItem_42_Click;
			this.toolStripMenuItem_50.Image = Resources.smethod_53();
			this.toolStripMenuItem_50.Name = "toolMenuItemRectRelayProtectAutomation";
			this.toolStripMenuItem_50.Size = new Size(281, 22);
			this.toolStripMenuItem_50.Text = "Уставки РЗА";
			this.toolStripMenuItem_50.Click += this.toolStripMenuItem_50_Click;
			this.toolStripSeparator_16.Name = "toolStripSeparator12";
			this.toolStripSeparator_16.Size = new Size(278, 6);
			this.toolStripMenuItem_48.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_43,
				this.toolStripMenuItem_44,
				this.toolStripSeparator_17,
				this.toolStripMenuItem_45,
				this.toolStripMenuItem_46,
				this.toolStripMenuItem_47,
				this.toolStripSeparator_18,
				this.toolStripMenuItem_51
			});
			this.toolStripMenuItem_48.Name = "toolMenuItemRectTechConnect";
			this.toolStripMenuItem_48.Size = new Size(281, 22);
			this.toolStripMenuItem_48.Text = "Технологическое присоединение";
			this.toolStripMenuItem_43.Image = Resources.smethod_5();
			this.toolStripMenuItem_43.Name = "toolMenuItemRectTU";
			this.toolStripMenuItem_43.Size = new Size(354, 22);
			this.toolStripMenuItem_43.Text = "Технические условия";
			this.toolStripMenuItem_43.Click += this.toolStripMenuItem_43_Click;
			this.toolStripMenuItem_44.Image = Resources.smethod_10();
			this.toolStripMenuItem_44.Name = "toolMenuItemRectContractTP";
			this.toolStripMenuItem_44.Size = new Size(354, 22);
			this.toolStripMenuItem_44.Text = "Договора на ТП";
			this.toolStripMenuItem_44.Click += this.toolStripMenuItem_44_Click;
			this.toolStripSeparator_17.Name = "toolStripSeparator9";
			this.toolStripSeparator_17.Size = new Size(351, 6);
			this.toolStripMenuItem_45.Name = "toolMenuItemRectActElectricalInspection";
			this.toolStripMenuItem_45.Size = new Size(354, 22);
			this.toolStripMenuItem_45.Tag = "1238";
			this.toolStripMenuItem_45.Text = "Акты осмотра электроустановок";
			this.toolStripMenuItem_45.Click += this.toolStripMenuItem_47_Click;
			this.toolStripMenuItem_46.Name = "toolMenuItemRectActPerformingTU";
			this.toolStripMenuItem_46.Size = new Size(354, 22);
			this.toolStripMenuItem_46.Tag = "1239";
			this.toolStripMenuItem_46.Text = "Акты выполнения технических условий";
			this.toolStripMenuItem_46.Click += this.toolStripMenuItem_47_Click;
			this.toolStripMenuItem_47.Name = "toolMenuItemRectActTC";
			this.toolStripMenuItem_47.Size = new Size(354, 22);
			this.toolStripMenuItem_47.Tag = "1240";
			this.toolStripMenuItem_47.Text = "Акты о технологическом присоединении";
			this.toolStripMenuItem_47.Click += this.toolStripMenuItem_47_Click;
			this.toolStripSeparator_18.Name = "toolStripSeparator15";
			this.toolStripSeparator_18.Size = new Size(351, 6);
			this.toolStripMenuItem_51.Name = "toolMenuItemRectActRBP";
			this.toolStripMenuItem_51.Size = new Size(354, 22);
			this.toolStripMenuItem_51.Text = "Акты разграничения барансовой принадлежности";
			this.toolStripMenuItem_51.Click += this.toolStripMenuItem_51_Click;
			this.IlbLiynpEJ.Name = "toolMenuItemRectDamage";
			this.IlbLiynpEJ.Size = new Size(281, 22);
			this.IlbLiynpEJ.Text = "Журнал технологических нарушений";
			this.IlbLiynpEJ.Click += this.IlbLiynpEJ_Click;
			this.toolStripSeparator_5.Name = "toolStripSeparator11";
			this.toolStripSeparator_5.Size = new Size(229, 6);
			this.toolStripMenuItem_10.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_11,
				this.toolStripMenuItem_12,
				this.toolStripMenuItem_17,
				this.toolStripMenuItem_18,
				this.toolStripMenuItem_35,
				this.toolStripMenuItem_22
			});
			this.toolStripMenuItem_10.Name = "toolMenuItemRectSetLabel";
			this.toolStripMenuItem_10.Size = new Size(232, 22);
			this.toolStripMenuItem_10.Text = "Информация";
			this.toolStripMenuItem_11.CheckOnClick = true;
			this.toolStripMenuItem_11.Name = "toolMenuItemRectSetAVR";
			this.toolStripMenuItem_11.Size = new Size(263, 22);
			this.toolStripMenuItem_11.Text = "АВР";
			this.toolStripMenuItem_11.Click += this.toolStripMenuItem_22_Click;
			this.toolStripMenuItem_12.CheckOnClick = true;
			this.toolStripMenuItem_12.Name = "toolMenuItemRectSetLock";
			this.toolStripMenuItem_12.Size = new Size(263, 22);
			this.toolStripMenuItem_12.Text = "Спец замок";
			this.toolStripMenuItem_12.Click += this.toolStripMenuItem_22_Click;
			this.toolStripMenuItem_17.CheckOnClick = true;
			this.toolStripMenuItem_17.Name = "toolMenuItemRectSetTM";
			this.toolStripMenuItem_17.Size = new Size(263, 22);
			this.toolStripMenuItem_17.Text = "Телемеханика";
			this.toolStripMenuItem_17.Click += this.toolStripMenuItem_22_Click;
			this.toolStripMenuItem_18.CheckOnClick = true;
			this.toolStripMenuItem_18.Name = "toolMenuItemRectSetTMProtect";
			this.toolStripMenuItem_18.Size = new Size(263, 22);
			this.toolStripMenuItem_18.Text = "Телемеханика-охрана";
			this.toolStripMenuItem_18.Click += this.toolStripMenuItem_22_Click;
			this.toolStripMenuItem_35.CheckOnClick = true;
			this.toolStripMenuItem_35.Name = "toolMenuItemRectSetVideo";
			this.toolStripMenuItem_35.Size = new Size(263, 22);
			this.toolStripMenuItem_35.Text = "Видеонаблюдение";
			this.toolStripMenuItem_35.Click += this.toolStripMenuItem_22_Click;
			this.toolStripMenuItem_22.Name = "toolMenuItemRectSetResopsibleAbn";
			this.toolStripMenuItem_22.Size = new Size(263, 22);
			this.toolStripMenuItem_22.Text = "Добавить ответсвенного абонента";
			this.toolStripMenuItem_22.Click += this.toolStripMenuItem_22_Click;
			this.toolStripMenuItem_40.Name = "toolStripMenuItemAddTelemetryLabel";
			this.toolStripMenuItem_40.Size = new Size(232, 22);
			this.toolStripMenuItem_40.Text = "Вывести данные телеметрии";
			this.toolStripMenuItem_40.Click += this.toolStripMenuItem_40_Click;
			this.toolStripSeparator_3.Name = "toolStripSeparatorSetLabel";
			this.toolStripSeparator_3.Size = new Size(229, 6);
			this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_13,
				this.toolStripMenuItem_14
			});
			this.toolStripMenuItem_0.Name = "toolMenuItemRectPowerSource";
			this.toolStripMenuItem_0.Size = new Size(232, 22);
			this.toolStripMenuItem_0.Text = "Просчитать запитку";
			this.toolStripMenuItem_13.Name = "toolStripMenuItem1";
			this.toolStripMenuItem_13.Size = new Size(186, 22);
			this.toolStripMenuItem_13.Tag = "1";
			this.toolStripMenuItem_13.Text = "Выделить";
			this.toolStripMenuItem_13.Click += this.toolStripMenuItem_14_Click;
			this.toolStripMenuItem_14.Name = "toolStripMenuItem2";
			this.toolStripMenuItem_14.Size = new Size(186, 22);
			this.toolStripMenuItem_14.Tag = "2";
			this.toolStripMenuItem_14.Text = "Выделить миганием";
			this.toolStripMenuItem_14.Click += this.toolStripMenuItem_14_Click;
			this.toolStripMenuItem_1.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_15,
				this.toolStripMenuItem_16
			});
			this.toolStripMenuItem_1.Name = "toolMenuItemRectRecipientsPower";
			this.toolStripMenuItem_1.Size = new Size(232, 22);
			this.toolStripMenuItem_1.Text = "Просчитать схему";
			this.toolStripMenuItem_15.Name = "toolStripMenuItem3";
			this.toolStripMenuItem_15.Size = new Size(186, 22);
			this.toolStripMenuItem_15.Tag = "1";
			this.toolStripMenuItem_15.Text = "Выделить";
			this.toolStripMenuItem_15.Click += this.toolStripMenuItem_16_Click;
			this.toolStripMenuItem_16.Name = "toolStripMenuItem4";
			this.toolStripMenuItem_16.Size = new Size(186, 22);
			this.toolStripMenuItem_16.Tag = "2";
			this.toolStripMenuItem_16.Text = "Выделить миганием";
			this.toolStripMenuItem_16.Click += this.toolStripMenuItem_16_Click;
			this.toolStripMenuItem_25.Name = "toolStripMenuItemAdjacentSubstation";
			this.toolStripMenuItem_25.Size = new Size(232, 22);
			this.toolStripMenuItem_25.Text = "Смежные подстанции";
			this.toolStripMenuItem_25.Click += this.toolStripMenuItem_25_Click;
			this.toolStripMenuItem_36.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_37,
				this.toolStripMenuItem_38
			});
			this.toolStripMenuItem_36.Name = "toolStripMenuItemRectGetOldAbn";
			this.toolStripMenuItem_36.Size = new Size(232, 22);
			this.toolStripMenuItem_36.Text = "Абоненты";
			this.toolStripMenuItem_37.Name = "toolStripMenuItemRectOldAbnCurrentRect";
			this.toolStripMenuItem_37.Size = new Size(191, 22);
			this.toolStripMenuItem_37.Text = "Текущей подстанции";
			this.toolStripMenuItem_37.Click += this.toolStripMenuItem_38_Click;
			this.toolStripMenuItem_38.Name = "toolStripMenuItemRectOldAbnNextRect";
			this.toolStripMenuItem_38.Size = new Size(191, 22);
			this.toolStripMenuItem_38.Tag = "1";
			this.toolStripMenuItem_38.Text = "По цепочке";
			this.toolStripMenuItem_38.Click += this.toolStripMenuItem_38_Click;
			this.toolStripSeparator_1.Name = "toolStripSeparator10";
			this.toolStripSeparator_1.Size = new Size(229, 6);
			this.toolStripMenuItem_7.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_8,
				this.toolStripMenuItem_9
			});
			this.toolStripMenuItem_7.Name = "toolMenuItemRectFilter";
			this.toolStripMenuItem_7.Size = new Size(232, 22);
			this.toolStripMenuItem_7.Text = "Фильтр";
			this.toolStripMenuItem_8.Name = "toolMenuItemRectFilterAdd";
			this.toolStripMenuItem_8.Size = new Size(183, 22);
			this.toolStripMenuItem_8.Text = "Добавить в фильтр";
			this.toolStripMenuItem_8.Click += this.toolStripMenuItem_8_Click;
			this.toolStripMenuItem_9.Name = "toolMenuItemRectFilterDel";
			this.toolStripMenuItem_9.Size = new Size(183, 22);
			this.toolStripMenuItem_9.Text = "Удалить из фильтра";
			this.toolStripMenuItem_9.Click += this.toolStripMenuItem_9_Click;
			this.toolStripSeparator_4.Name = "toolStripSeparator13";
			this.toolStripSeparator_4.Size = new Size(229, 6);
			this.toolStripMenuItem_23.Name = "toolMenuItemRectCopy";
			this.toolStripMenuItem_23.Size = new Size(232, 22);
			this.toolStripMenuItem_23.Text = "Копировать";
			this.toolStripMenuItem_23.Click += this.toolStripMenuItem_23_Click;
			this.toolStripMenuItem_24.Name = "toolMenuItemRectPaste";
			this.toolStripMenuItem_24.Size = new Size(232, 22);
			this.toolStripMenuItem_24.Text = "Вставить";
			this.toolStripMenuItem_24.Click += this.toolStripMenuItem_24_Click;
			this.toolStripMenuItem_2.Name = "toolMenuItemRectDel";
			this.toolStripMenuItem_2.Size = new Size(232, 22);
			this.toolStripMenuItem_2.Text = "Удалить";
			this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
			this.toolStripMenuItem_27.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_28,
				this.toolStripMenuItem_31
			});
			this.toolStripMenuItem_27.Name = "toolStripMenuItemRectanglePosition";
			this.toolStripMenuItem_27.Size = new Size(232, 22);
			this.toolStripMenuItem_27.Text = "Положение";
			this.toolStripMenuItem_28.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_29,
				this.toolStripMenuItem_30
			});
			this.toolStripMenuItem_28.Name = "toolStripMenuItemReflect";
			this.toolStripMenuItem_28.Size = new Size(133, 22);
			this.toolStripMenuItem_28.Text = "Отразить";
			this.toolStripMenuItem_29.Name = "toolStripMenuItemVReflect";
			this.toolStripMenuItem_29.Size = new Size(163, 22);
			this.toolStripMenuItem_29.Tag = "V";
			this.toolStripMenuItem_29.Text = "По вертикали";
			this.toolStripMenuItem_29.Click += this.toolStripMenuItem_30_Click;
			this.toolStripMenuItem_30.Name = "toolStripMenuItemHReflect";
			this.toolStripMenuItem_30.Size = new Size(163, 22);
			this.toolStripMenuItem_30.Tag = "H";
			this.toolStripMenuItem_30.Text = "По горизонтали";
			this.toolStripMenuItem_30.Click += this.toolStripMenuItem_30_Click;
			this.toolStripMenuItem_31.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_32,
				this.toolStripMenuItem_33,
				this.toolStripMenuItem_34
			});
			this.toolStripMenuItem_31.Name = "toolStripMenuItemRotateRectangle";
			this.toolStripMenuItem_31.Size = new Size(133, 22);
			this.toolStripMenuItem_31.Text = "Повернуть";
			this.toolStripMenuItem_32.Name = "toolStripMenuItemRotate90";
			this.toolStripMenuItem_32.Size = new Size(144, 22);
			this.toolStripMenuItem_32.Tag = "90";
			this.toolStripMenuItem_32.Text = "90 градусов";
			this.toolStripMenuItem_32.Click += this.toolStripMenuItem_34_Click;
			this.toolStripMenuItem_33.Name = "toolStripMenuItemRotate180";
			this.toolStripMenuItem_33.Size = new Size(144, 22);
			this.toolStripMenuItem_33.Tag = "180";
			this.toolStripMenuItem_33.Text = "180 градусов";
			this.toolStripMenuItem_33.Click += this.toolStripMenuItem_34_Click;
			this.toolStripMenuItem_34.Name = "toolStripMenuItemRotate270";
			this.toolStripMenuItem_34.Size = new Size(144, 22);
			this.toolStripMenuItem_34.Tag = "270";
			this.toolStripMenuItem_34.Text = "270 градусов";
			this.toolStripMenuItem_34.Click += this.toolStripMenuItem_34_Click;
			this.toolStripMenuItem_3.Name = "toolMenuItemRectAlign";
			this.toolStripMenuItem_3.Size = new Size(232, 22);
			this.toolStripMenuItem_3.Text = "Выровнять объекты";
			this.toolStripMenuItem_3.Click += this.toolStripMenuItem_3_Click;
			this.toolStripSeparator_2.Name = "toolStripSeparatorEditRectangle";
			this.toolStripSeparator_2.Size = new Size(229, 6);
			this.toolStripMenuItem_39.Name = "toolMenuItemRectFile";
			this.toolStripMenuItem_39.Size = new Size(232, 22);
			this.toolStripMenuItem_39.Text = "Файлы";
			this.toolStripMenuItem_39.Click += this.toolStripMenuItem_39_Click;
			this.toolStripMenuItem_4.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.toolStripMenuItem_4.Name = "toolMenuItemRectProperty";
			this.toolStripMenuItem_4.Size = new Size(232, 22);
			this.toolStripMenuItem_4.Text = "Свойства объекта";
			this.toolStripMenuItem_4.Click += this.toolStripMenuItem_4_Click;
			this.backgroundWorker_1.WorkerReportsProgress = true;
			this.backgroundWorker_1.DoWork += this.backgroundWorker_1_DoWork;
			this.backgroundWorker_1.RunWorkerCompleted += this.backgroundWorker_1_RunWorkerCompleted;
			this.panel_0.BackColor = SystemColors.Control;
			this.panel_0.Controls.Add(this.label_0);
			this.panel_0.Controls.Add(this.progressBarEndLess_0);
			this.panel_0.Location = new Point(262, 205);
			this.panel_0.Name = "panelProgress";
			this.panel_0.Size = new Size(431, 74);
			this.panel_0.TabIndex = 5;
			this.panel_0.Visible = false;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(111, 12);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(230, 13);
			this.label_0.TabIndex = 6;
			this.label_0.Text = "Подождите... Идет загрузка схемы из базы";
			this.progressBarEndLess_0.AutoProgressSpeed = 130;
			this.progressBarEndLess_0.Dock = DockStyle.Bottom;
			this.progressBarEndLess_0.Location = new Point(0, 39);
			this.progressBarEndLess_0.Name = "progressBarEndLess";
			this.progressBarEndLess_0.NormalImage = (Image)componentResourceManager.GetObject("progressBarEndLess.NormalImage");
			this.progressBarEndLess_0.PointImage = (Image)componentResourceManager.GetObject("progressBarEndLess.PointImage");
			this.progressBarEndLess_0.Position = 0;
			this.progressBarEndLess_0.ProgressStyle = 1;
			this.progressBarEndLess_0.ProgressType = 1;
			this.progressBarEndLess_0.Size = new Size(431, 35);
			this.progressBarEndLess_0.TabIndex = 5;
			this.toolStrip_2.Dock = DockStyle.None;
			this.toolStrip_2.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_13,
				this.toolStripButton_14,
				this.toolStripButton_15,
				this.toolStripSeparator_7,
				this.toolStripButton_45,
				this.toolStripButton_19,
				this.toolStripButton_53,
				this.toolStripSeparator_11,
				this.toolStripLabel_0,
				this.toolStripComboBox_1,
				this.toolStripComboBox_0,
				this.toolStripSplitButton_0,
				this.toolStripProgressBar_0,
				this.toolStripLabel_1,
				this.toolStripButton_49
			});
			this.toolStrip_2.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStrip_2.Location = new Point(393, 50);
			this.toolStrip_2.Name = "toolStripSave";
			this.toolStrip_2.Size = new Size(330, 25);
			this.toolStrip_2.TabIndex = 6;
			this.toolStrip_2.Text = "Сохранение";
			this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_13.Image = Resources.smethod_54();
			this.toolStripButton_13.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_13.Name = "toolBtnSave";
			this.toolStripButton_13.Size = new Size(23, 22);
			this.toolStripButton_13.Text = "Сохранить";
			this.toolStripButton_13.Click += this.toolStripButton_13_Click;
			this.toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_14.Image = Resources.smethod_51();
			this.toolStripButton_14.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_14.Name = "toolBtnRefresh";
			this.toolStripButton_14.Size = new Size(23, 22);
			this.toolStripButton_14.Text = "Обновить";
			this.toolStripButton_14.Click += this.toolStripButton_14_Click;
			this.toolStripButton_15.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_15.Image = Resources.smethod_22();
			this.toolStripButton_15.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_15.Name = "toolStripButtonExport";
			this.toolStripButton_15.Size = new Size(23, 22);
			this.toolStripButton_15.Text = "Экспорт в AutoCAD";
			this.toolStripButton_15.Click += this.toolStripButton_15_Click;
			this.toolStripSeparator_7.Name = "toolStripSeparator7";
			this.toolStripSeparator_7.Size = new Size(6, 25);
			this.toolStripButton_45.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_45.Image = Resources.smethod_55();
			this.toolStripButton_45.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_45.Name = "toolBtnSetting2";
			this.toolStripButton_45.Size = new Size(23, 22);
			this.toolStripButton_45.Text = "Настройки";
			this.toolStripButton_45.Visible = false;
			this.toolStripButton_45.Click += this.toolStripButton_19_Click;
			this.toolStripButton_19.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_19.Image = Resources.smethod_55();
			this.toolStripButton_19.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_19.Name = "toolBtnSetting";
			this.toolStripButton_19.Size = new Size(23, 22);
			this.toolStripButton_19.Text = "Настройки";
			this.toolStripButton_19.Click += this.toolStripButton_19_Click;
			this.toolStripButton_53.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_53.Image = Resources.Ercloud;
			this.toolStripButton_53.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_53.Name = "toolBtnErcloud";
			this.toolStripButton_53.Size = new Size(23, 22);
			this.toolStripButton_53.Text = "Настройки Ercloud";
			this.toolStripButton_53.Click += this.toolStripButton_53_Click;
			this.toolStripSeparator_11.Name = "toolStripSeparator5";
			this.toolStripSeparator_11.Size = new Size(6, 25);
			this.toolStripLabel_0.Name = "toolStripLabel2";
			this.toolStripLabel_0.Size = new Size(45, 22);
			this.toolStripLabel_0.Text = "Режим";
			this.toolStripComboBox_1.AutoSize = false;
			this.toolStripComboBox_1.CausesValidation = false;
			this.toolStripComboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.toolStripComboBox_1.FlatStyle = FlatStyle.System;
			this.toolStripComboBox_1.Items.AddRange(new object[]
			{
				"Просмотр",
				"Диспетчер",
				"Редактирование"
			});
			this.toolStripComboBox_1.Name = "toolStripComboBoxRezim2";
			this.toolStripComboBox_1.Size = new Size(121, 23);
			this.toolStripComboBox_1.Visible = false;
			this.toolStripComboBox_1.SelectedIndexChanged += this.toolStripComboBox_0_SelectedIndexChanged;
			this.toolStripComboBox_0.AutoSize = false;
			this.toolStripComboBox_0.CausesValidation = false;
			this.toolStripComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.toolStripComboBox_0.FlatStyle = FlatStyle.System;
			this.toolStripComboBox_0.Items.AddRange(new object[]
			{
				"Просмотр",
				"Диспетчер",
				"Редактирование"
			});
			this.toolStripComboBox_0.Name = "toolStripComboBoxRezim";
			this.toolStripComboBox_0.Size = new Size(121, 23);
			this.toolStripComboBox_0.SelectedIndexChanged += this.toolStripComboBox_0_SelectedIndexChanged;
			this.toolStripSplitButton_0.Alignment = ToolStripItemAlignment.Right;
			this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripSplitButton_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_19,
				this.toolStripMenuItem_20,
				this.toolStripMenuItem_21,
				this.toolStripMenuItem_26
			});
			this.toolStripSplitButton_0.Image = (Image)componentResourceManager.GetObject("toolSplitBtnLoadOld.Image");
			this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButton_0.Name = "toolSplitBtnLoadOld";
			this.toolStripSplitButton_0.Size = new Size(68, 22);
			this.toolStripSplitButton_0.Text = "LoadOld";
			this.toolStripSplitButton_0.Visible = false;
			this.toolStripMenuItem_19.Name = "toolMenuLoadPB";
			this.toolStripMenuItem_19.Size = new Size(162, 22);
			this.toolStripMenuItem_19.Text = "Правый берег";
			this.toolStripMenuItem_19.Visible = false;
			this.toolStripMenuItem_19.Click += this.toolStripMenuItem_19_Click;
			this.toolStripMenuItem_20.Name = "toolMenuLoadLB";
			this.toolStripMenuItem_20.Size = new Size(162, 22);
			this.toolStripMenuItem_20.Text = "Левый берег";
			this.toolStripMenuItem_20.Visible = false;
			this.toolStripMenuItem_20.Click += this.toolStripMenuItem_20_Click;
			this.toolStripMenuItem_21.Name = "toolMenuLoadPrig";
			this.toolStripMenuItem_21.Size = new Size(162, 22);
			this.toolStripMenuItem_21.Text = "Пригород";
			this.toolStripMenuItem_21.Visible = false;
			this.toolStripMenuItem_21.Click += this.toolStripMenuItem_21_Click;
			this.toolStripMenuItem_26.Name = "toolMenuLoadSEcondSchema";
			this.toolStripMenuItem_26.Size = new Size(162, 22);
			this.toolStripMenuItem_26.Text = "Второй уровень";
			this.toolStripMenuItem_26.Click += this.toolStripMenuItem_26_Click;
			this.toolStripProgressBar_0.Alignment = ToolStripItemAlignment.Right;
			this.toolStripProgressBar_0.Name = "toolStripProgressBar1";
			this.toolStripProgressBar_0.Size = new Size(100, 22);
			this.toolStripProgressBar_0.Visible = false;
			this.toolStripLabel_1.Alignment = ToolStripItemAlignment.Right;
			this.toolStripLabel_1.Name = "workerCounterLabel";
			this.toolStripLabel_1.Size = new Size(13, 22);
			this.toolStripLabel_1.Text = "0";
			this.toolStripLabel_1.Visible = false;
			this.toolStripButton_49.CheckOnClick = true;
			this.toolStripButton_49.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_49.Image = (Image)componentResourceManager.GetObject("toolStripButtonTraining.Image");
			this.toolStripButton_49.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_49.Name = "toolStripButtonTraining";
			this.toolStripButton_49.Size = new Size(23, 22);
			this.toolStripButton_49.Text = "Режим песочницы";
			this.toolStripButton_49.Click += this.toolStripButton_49_Click;
			this.toolStripButton_51.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_51.Image = Resources.smethod_67();
			this.toolStripButton_51.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_51.Name = "toolBtnTelemetryRefresh";
			this.toolStripButton_51.Size = new Size(23, 22);
			this.toolStripButton_51.Text = "Обновить показания телеметрии";
			this.toolStripButton_51.Click += this.toolStripButton_51_Click;
			this.toolStrip_3.Dock = DockStyle.None;
			this.toolStrip_3.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_16,
				this.toolStripButton_17,
				this.toolStripButton_18,
				this.toolStripButton_37
			});
			this.toolStrip_3.Location = new Point(3, 25);
			this.toolStrip_3.Name = "toolStripPrint";
			this.toolStrip_3.Size = new Size(104, 25);
			this.toolStrip_3.TabIndex = 7;
			this.toolStrip_3.Text = "Печать";
			this.toolStripButton_16.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_16.Image = Resources.smethod_42();
			this.toolStripButton_16.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_16.Name = "toolBtnPageSetup";
			this.toolStripButton_16.Size = new Size(23, 22);
			this.toolStripButton_16.Text = "Настройка страницы";
			this.toolStripButton_16.Click += this.toolStripButton_16_Click;
			this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_17.Image = Resources.smethod_49();
			this.toolStripButton_17.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_17.Name = "toolBtnPrintPreview";
			this.toolStripButton_17.Size = new Size(23, 22);
			this.toolStripButton_17.Text = "Предварительный просмотр";
			this.toolStripButton_17.Click += this.toolStripButton_17_Click;
			this.toolStripButton_18.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_18.Image = Resources.smethod_45();
			this.toolStripButton_18.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_18.Name = "toolBtnPrint";
			this.toolStripButton_18.Size = new Size(23, 22);
			this.toolStripButton_18.Text = "Печать";
			this.toolStripButton_18.Click += this.toolStripButton_18_Click;
			this.toolStripButton_37.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_37.Image = Resources.smethod_46();
			this.toolStripButton_37.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_37.Name = "toolStripButtonPrint";
			this.toolStripButton_37.Size = new Size(23, 22);
			this.toolStripButton_37.Text = "Печать";
			this.toolStripButton_37.Click += this.toolStripButton_37_Click;
			this.toolStrip_4.Dock = DockStyle.None;
			this.toolStrip_4.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_20,
				this.toolStripSeparator_8,
				this.toolStripButton_21,
				this.toolStripButton_22,
				this.toolStripButton_23,
				this.toolStripButton_24,
				this.toolStripButton_25
			});
			this.toolStrip_4.Location = new Point(3, 0);
			this.toolStrip_4.Name = "toolStripZoom";
			this.toolStrip_4.Size = new Size(156, 25);
			this.toolStrip_4.TabIndex = 9;
			this.toolStrip_4.Text = "Масштаб";
			this.toolStripButton_20.CheckOnClick = true;
			this.toolStripButton_20.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_20.Image = Resources.smethod_38();
			this.toolStripButton_20.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_20.Name = "toolStripButtonShowMap";
			this.toolStripButton_20.Size = new Size(23, 22);
			this.toolStripButton_20.Text = "Показать карту схемы";
			this.toolStripButton_20.Click += this.toolStripButton_20_Click;
			this.toolStripSeparator_8.Name = "toolStripSeparator4";
			this.toolStripSeparator_8.Size = new Size(6, 25);
			this.toolStripButton_21.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_21.Image = Resources.smethod_70();
			this.toolStripButton_21.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_21.Name = "toolBtnZoomWindow";
			this.toolStripButton_21.Size = new Size(23, 22);
			this.toolStripButton_21.Text = "Подогнать под рамку";
			this.toolStripButton_21.Click += this.toolStripButton_21_Click;
			this.toolStripButton_22.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_22.Image = Resources.smethod_0();
			this.toolStripButton_22.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_22.Name = "toolBtnZoomIn";
			this.toolStripButton_22.Size = new Size(23, 22);
			this.toolStripButton_22.Text = "Увеличить масштаб";
			this.toolStripButton_22.Click += this.toolStripButton_22_Click;
			this.toolStripButton_23.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_23.Image = Resources.smethod_1();
			this.toolStripButton_23.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_23.Name = "toolBtnZoomOut";
			this.toolStripButton_23.Size = new Size(23, 22);
			this.toolStripButton_23.Text = "Уменьшить масштаб";
			this.toolStripButton_23.Click += this.toolStripButton_23_Click;
			this.toolStripButton_24.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_24.Image = Resources.smethod_68();
			this.toolStripButton_24.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_24.Name = "toolBtnZoomInSymbol";
			this.toolStripButton_24.Size = new Size(23, 22);
			this.toolStripButton_24.Text = "Увеличить шрифт";
			this.toolStripButton_24.Click += this.toolStripButton_24_Click;
			this.toolStripButton_25.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_25.Image = Resources.smethod_69();
			this.toolStripButton_25.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_25.Name = "toolBtnZoomOutSymbol";
			this.toolStripButton_25.Size = new Size(23, 22);
			this.toolStripButton_25.Text = "Уменьшить шрифт";
			this.toolStripButton_25.Click += this.toolStripButton_25_Click;
			this.toolStrip_5.Dock = DockStyle.None;
			this.toolStrip_5.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_26,
				this.toolStripButton_27,
				this.toolStripSeparator_12,
				this.toolStripButton_35,
				this.toolStripSeparator_9,
				this.toolStripButton_28,
				this.toolStripSeparator_10,
				this.toolStripButton_29,
				this.toolStripButton_30,
				this.toolStripButton_31,
				this.toolStripButton_32,
				this.toolStripSeparator_15,
				this.toolStripButton_46,
				this.toolStripTextBox_0,
				this.toolStripButton_47,
				this.toolStripButton_48,
				this.mniLotCpLE,
				this.toolStripButton_54
			});
			this.toolStrip_5.Location = new Point(3, 50);
			this.toolStrip_5.Name = "toolStripFilter";
			this.toolStrip_5.Size = new Size(390, 25);
			this.toolStrip_5.TabIndex = 10;
			this.toolStrip_5.Text = "Фильтр";
			this.toolStripButton_26.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_26.Image = Resources.smethod_23();
			this.toolStripButton_26.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_26.Name = "toolStripButtonFilter";
			this.toolStripButton_26.Size = new Size(23, 22);
			this.toolStripButton_26.Text = "Фильтр";
			this.toolStripButton_26.Click += this.toolStripButton_26_Click;
			this.toolStripButton_27.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_27.Image = Resources.smethod_24();
			this.toolStripButton_27.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_27.Name = "toolStripButtonFilterDel";
			this.toolStripButton_27.Size = new Size(23, 22);
			this.toolStripButton_27.Text = "Убрать фильтр";
			this.toolStripButton_27.Click += this.toolStripButton_27_Click;
			this.toolStripSeparator_12.Name = "toolStripSeparator6";
			this.toolStripSeparator_12.Size = new Size(6, 25);
			this.toolStripButton_35.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_35.Image = Resources.smethod_61();
			this.toolStripButton_35.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_35.Name = "toolStripButton1";
			this.toolStripButton_35.Size = new Size(23, 22);
			this.toolStripButton_35.Text = "Показать в отдельной вкладке";
			this.toolStripButton_35.Click += this.toolStripButton_35_Click;
			this.toolStripSeparator_9.Name = "toolStripSeparator2";
			this.toolStripSeparator_9.Size = new Size(6, 25);
			this.toolStripButton_28.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_28.Enabled = false;
			this.toolStripButton_28.Image = Resources.smethod_32();
			this.toolStripButton_28.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_28.Name = "toolStripButtonNoFlashing";
			this.toolStripButton_28.Size = new Size(23, 22);
			this.toolStripButton_28.Text = "Отменить мерцание";
			this.toolStripButton_28.Click += this.uhjImiftgM;
			this.toolStripSeparator_10.Name = "toolStripSeparatorBookmark";
			this.toolStripSeparator_10.Size = new Size(6, 25);
			this.toolStripButton_29.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_29.Image = (Image)componentResourceManager.GetObject("toolStripButtonPrevBookmark.Image");
			this.toolStripButton_29.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_29.Name = "toolStripButtonPrevBookmark";
			this.toolStripButton_29.Size = new Size(23, 22);
			this.toolStripButton_29.Text = "Предыдущая метка";
			this.toolStripButton_29.Click += this.toolStripButton_29_Click;
			this.toolStripButton_30.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_30.Image = (Image)componentResourceManager.GetObject("toolStripButtonCurrentBookmark.Image");
			this.toolStripButton_30.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_30.Name = "toolStripButtonCurrentBookmark";
			this.toolStripButton_30.Size = new Size(23, 22);
			this.toolStripButton_30.Text = "Текущая метка";
			this.toolStripButton_30.Click += this.toolStripButton_30_Click;
			this.toolStripButton_31.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_31.Image = (Image)componentResourceManager.GetObject("toolStripButtonNextBookmark.Image");
			this.toolStripButton_31.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_31.Name = "toolStripButtonNextBookmark";
			this.toolStripButton_31.Size = new Size(23, 22);
			this.toolStripButton_31.Text = "Cледующая метка";
			this.toolStripButton_31.Click += this.toolStripButton_31_Click;
			this.toolStripButton_32.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_32.Image = (Image)componentResourceManager.GetObject("toolStripButtonRemoveAllBookmarks.Image");
			this.toolStripButton_32.ImageTransparentColor = Color.Red;
			this.toolStripButton_32.Name = "toolStripButtonRemoveAllBookmarks";
			this.toolStripButton_32.Size = new Size(23, 22);
			this.toolStripButton_32.Text = "Удалить все метки";
			this.toolStripButton_32.Click += this.toolStripButton_32_Click;
			this.toolStripSeparator_15.Name = "toolStripSeparator3";
			this.toolStripSeparator_15.Size = new Size(6, 25);
			this.toolStripButton_46.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_46.Image = Resources.smethod_28();
			this.toolStripButton_46.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_46.Name = "toolStripButtonFind";
			this.toolStripButton_46.Size = new Size(23, 22);
			this.toolStripButton_46.Text = "Поиск";
			this.toolStripButton_46.Click += this.toolStripButton_46_Click;
			this.toolStripTextBox_0.Name = "toolStripTextBoxFind";
			this.toolStripTextBox_0.Size = new Size(70, 25);
			this.toolStripTextBox_0.ToolTipText = "Текст для поиска";
			this.toolStripTextBox_0.KeyDown += this.toolStripTextBox_0_KeyDown;
			this.toolStripTextBox_0.TextChanged += this.toolStripTextBox_0_TextChanged;
			this.toolStripButton_47.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_47.Image = Resources.smethod_30();
			this.toolStripButton_47.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_47.Name = "toolStripButtonFindPrev";
			this.toolStripButton_47.Size = new Size(23, 22);
			this.toolStripButton_47.Text = "Поиск назад";
			this.toolStripButton_47.Click += this.toolStripButton_47_Click;
			this.toolStripButton_48.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_48.Image = Resources.smethod_29();
			this.toolStripButton_48.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_48.Name = "toolStripButtonFindNext";
			this.toolStripButton_48.Size = new Size(23, 22);
			this.toolStripButton_48.Text = "Поиск вперед";
			this.toolStripButton_48.Click += this.toolStripButton_48_Click;
			this.mniLotCpLE.Name = "toolStripSeparator14";
			this.mniLotCpLE.Size = new Size(6, 25);
			this.toolStripButton_54.BackColor = Color.Bisque;
			this.toolStripButton_54.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_54.Image = Resources.smethod_6();
			this.toolStripButton_54.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_54.Name = "toolBtnJournalAbonent";
			this.toolStripButton_54.Size = new Size(23, 22);
			this.toolStripButton_54.Text = "Журнал абонентов";
			this.toolStripButton_54.Click += this.toolStripButton_54_Click;
			this.toolStripContainer_0.ContentPanel.Controls.Add(this.panel_0);
			this.toolStripContainer_0.ContentPanel.Controls.Add(this.dockPanel_0);
			this.toolStripContainer_0.ContentPanel.Size = new Size(973, 435);
			this.toolStripContainer_0.Dock = DockStyle.Fill;
			this.toolStripContainer_0.Location = new Point(0, 0);
			this.toolStripContainer_0.Name = "toolStripContainer1";
			this.toolStripContainer_0.Size = new Size(973, 535);
			this.toolStripContainer_0.TabIndex = 11;
			this.toolStripContainer_0.Text = "toolStripContainer1";
			this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_4);
			this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_3);
			this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_1);
			this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_2);
			this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_0);
			this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_5);
			this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_6);
			this.dockPanel_0.ActiveAutoHideContent = null;
			this.dockPanel_0.Dock = DockStyle.Fill;
			this.dockPanel_0.DockBackColor = SystemColors.Control;
			this.dockPanel_0.DocumentStyle = 1;
			this.dockPanel_0.Location = new Point(0, 0);
			this.dockPanel_0.Name = "dockPanel1";
			this.dockPanel_0.Size = new Size(973, 435);
			dockPanelGradient.EndColor = SystemColors.ControlLight;
			dockPanelGradient.StartColor = SystemColors.ControlLight;
			autoHideStripSkin.DockStripGradient = dockPanelGradient;
			tabGradient.EndColor = SystemColors.Control;
			tabGradient.StartColor = SystemColors.Control;
			tabGradient.TextColor = SystemColors.ControlDarkDark;
			autoHideStripSkin.TabGradient = tabGradient;
			dockPanelSkin.AutoHideStripSkin = autoHideStripSkin;
			tabGradient2.EndColor = SystemColors.ControlLightLight;
			tabGradient2.StartColor = SystemColors.ControlLightLight;
			tabGradient2.TextColor = SystemColors.ControlText;
			dockPaneStripGradient.ActiveTabGradient = tabGradient2;
			dockPanelGradient2.EndColor = SystemColors.Control;
			dockPanelGradient2.StartColor = SystemColors.Control;
			dockPaneStripGradient.DockStripGradient = dockPanelGradient2;
			tabGradient3.EndColor = SystemColors.ControlLight;
			tabGradient3.StartColor = SystemColors.ControlLight;
			tabGradient3.TextColor = SystemColors.ControlText;
			dockPaneStripGradient.InactiveTabGradient = tabGradient3;
			dockPaneStripSkin.DocumentGradient = dockPaneStripGradient;
			tabGradient4.EndColor = SystemColors.ActiveCaption;
			tabGradient4.LinearGradientMode = LinearGradientMode.Vertical;
			tabGradient4.StartColor = SystemColors.GradientActiveCaption;
			tabGradient4.TextColor = SystemColors.ActiveCaptionText;
			dockPaneStripToolWindowGradient.ActiveCaptionGradient = tabGradient4;
			tabGradient5.EndColor = SystemColors.Control;
			tabGradient5.StartColor = SystemColors.Control;
			tabGradient5.TextColor = SystemColors.ControlText;
			dockPaneStripToolWindowGradient.ActiveTabGradient = tabGradient5;
			dockPanelGradient3.EndColor = SystemColors.ControlLight;
			dockPanelGradient3.StartColor = SystemColors.ControlLight;
			dockPaneStripToolWindowGradient.DockStripGradient = dockPanelGradient3;
			tabGradient6.EndColor = SystemColors.GradientInactiveCaption;
			tabGradient6.LinearGradientMode = LinearGradientMode.Vertical;
			tabGradient6.StartColor = SystemColors.GradientInactiveCaption;
			tabGradient6.TextColor = SystemColors.ControlText;
			dockPaneStripToolWindowGradient.InactiveCaptionGradient = tabGradient6;
			tabGradient7.EndColor = Color.Transparent;
			tabGradient7.StartColor = Color.Transparent;
			tabGradient7.TextColor = SystemColors.ControlDarkDark;
			dockPaneStripToolWindowGradient.InactiveTabGradient = tabGradient7;
			dockPaneStripSkin.ToolWindowGradient = dockPaneStripToolWindowGradient;
			dockPanelSkin.DockPaneStripSkin = dockPaneStripSkin;
			this.dockPanel_0.Skin = dockPanelSkin;
			this.dockPanel_0.TabIndex = 0;
			this.dockPanel_0.Resize += this.dockPanel_0_Resize;
			this.toolStrip_6.Dock = DockStyle.None;
			this.toolStrip_6.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_5,
				this.toolStripButton_50,
				this.toolStripButton_51
			});
			this.toolStrip_6.Location = new Point(3, 75);
			this.toolStrip_6.Name = "toolStripTelemetry";
			this.toolStrip_6.Size = new Size(112, 25);
			this.toolStrip_6.TabIndex = 11;
			this.toolStrip_6.Visible = false;
			this.dataGridViewImageColumn_18.Name = "dataGridViewImageColumn24";
			this.dataGridViewImageColumn_18.ReadOnly = true;
			this.dataGridViewImageColumn_18.Width = 20;
			this.dataGridViewImageColumn_17.Name = "dataGridViewImageColumn23";
			this.dataGridViewImageColumn_17.ReadOnly = true;
			this.dataGridViewImageColumn_17.Width = 20;
			this.dataGridViewImageColumn_16.Name = "dataGridViewImageColumn22";
			this.dataGridViewImageColumn_16.ReadOnly = true;
			this.dataGridViewImageColumn_16.Width = 20;
			this.dataGridViewImageColumn_15.Name = "dataGridViewImageColumn21";
			this.dataGridViewImageColumn_15.ReadOnly = true;
			this.dataGridViewImageColumn_15.Width = 20;
			this.dataGridViewImageColumn_14.Name = "dataGridViewImageColumn20";
			this.dataGridViewImageColumn_14.ReadOnly = true;
			this.dataGridViewImageColumn_14.Width = 20;
			this.dataGridViewImageColumn_13.Name = "dataGridViewImageColumn19";
			this.dataGridViewImageColumn_13.ReadOnly = true;
			this.dataGridViewImageColumn_13.Width = 20;
			this.dataGridViewImageColumn_12.Name = "dataGridViewImageColumn18";
			this.dataGridViewImageColumn_12.ReadOnly = true;
			this.dataGridViewImageColumn_12.Width = 20;
			this.dataGridViewImageColumn_11.Name = "dataGridViewImageColumn17";
			this.dataGridViewImageColumn_11.ReadOnly = true;
			this.dataGridViewImageColumn_11.Width = 20;
			this.dataGridViewImageColumn_10.Name = "dataGridViewImageColumn16";
			this.dataGridViewImageColumn_10.ReadOnly = true;
			this.dataGridViewImageColumn_10.Width = 20;
			this.dataGridViewImageColumn_9.Name = "dataGridViewImageColumn15";
			this.dataGridViewImageColumn_9.ReadOnly = true;
			this.dataGridViewImageColumn_9.Width = 20;
			this.dataGridViewImageColumn_7.Name = "dataGridViewImageColumn13";
			this.dataGridViewImageColumn_7.ReadOnly = true;
			this.dataGridViewImageColumn_7.Width = 20;
			this.dataGridViewImageColumn_6.Name = "dataGridViewImageColumn12";
			this.dataGridViewImageColumn_6.ReadOnly = true;
			this.dataGridViewImageColumn_6.Width = 20;
			this.dataGridViewImageColumn_3.Name = "dataGridViewImageColumn9";
			this.dataGridViewImageColumn_3.ReadOnly = true;
			this.dataGridViewImageColumn_3.Width = 20;
			this.dataGridViewImageColumn_2.Name = "dataGridViewImageColumn8";
			this.dataGridViewImageColumn_2.ReadOnly = true;
			this.dataGridViewImageColumn_2.Width = 20;
			this.dataGridViewImageColumn_1.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn_1.ReadOnly = true;
			this.dataGridViewImageColumn_1.Width = 20;
			this.dataGridViewImageColumn_0.Frozen = true;
			this.dataGridViewImageColumn_0.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn_0.ReadOnly = true;
			this.dataGridViewImageColumn_0.Width = 20;
			this.dataGridViewImageColumn_4.Name = "dataGridViewImageColumn10";
			this.dataGridViewImageColumn_4.ReadOnly = true;
			this.dataGridViewImageColumn_4.Width = 20;
			this.dataGridViewImageColumn_5.Name = "dataGridViewImageColumn11";
			this.dataGridViewImageColumn_5.ReadOnly = true;
			this.dataGridViewImageColumn_5.Width = 20;
			this.dataGridViewImageColumn_8.Name = "dataGridViewImageColumn14";
			this.dataGridViewImageColumn_8.ReadOnly = true;
			this.dataGridViewImageColumn_8.Width = 20;
			this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn24";
			this.dataGridViewTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewTextBoxColumn_18.Width = 50;
			this.dataGridViewTextBoxColumn_19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn25";
			this.dataGridViewTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewTextBoxColumn_17.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn23";
			this.dataGridViewTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn21";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn20";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn19";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn17";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn16";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.QynLzkVuoQ.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.QynLzkVuoQ.Image = (Image)componentResourceManager.GetObject("toolStripButton2.Image");
			this.QynLzkVuoQ.ImageTransparentColor = Color.Magenta;
			this.QynLzkVuoQ.Name = "toolStripButton2";
			this.QynLzkVuoQ.Size = new Size(23, 22);
			this.QynLzkVuoQ.Text = "toolStripButton2";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(973, 535);
			base.Controls.Add(this.toolStripContainer_0);
			this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.Name = "FormGeneralScheme2";
			this.Text = "Схема";
			base.WindowState = FormWindowState.Maximized;
			base.FormClosing += this.FormGeneralScheme2_FormClosing;
			base.Load += this.FormGeneralScheme2_Load;
			base.KeyDown += this.FormGeneralScheme2_KeyDown;
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.toolStrip_1.ResumeLayout(false);
			this.toolStrip_1.PerformLayout();
			this.contextMenuStrip_0.ResumeLayout(false);
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			this.toolStrip_2.ResumeLayout(false);
			this.toolStrip_2.PerformLayout();
			this.toolStrip_3.ResumeLayout(false);
			this.toolStrip_3.PerformLayout();
			this.toolStrip_4.ResumeLayout(false);
			this.toolStrip_4.PerformLayout();
			this.toolStrip_5.ResumeLayout(false);
			this.toolStrip_5.PerformLayout();
			this.toolStripContainer_0.ContentPanel.ResumeLayout(false);
			this.toolStripContainer_0.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer_0.TopToolStripPanel.PerformLayout();
			this.toolStripContainer_0.ResumeLayout(false);
			this.toolStripContainer_0.PerformLayout();
			this.toolStrip_6.ResumeLayout(false);
			this.toolStrip_6.PerformLayout();
			base.ResumeLayout(false);
		}

		[CompilerGenerated]
		private bool method_57(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(RectangleTool) && drawObjectBase_0.ToString().ToUpper().Contains(this.toolStripTextBox_0.Text.ToUpper());
		}

		[CompilerGenerated]
		private bool method_58(DrawObjectBase drawObjectBase_0)
		{
			if (drawObjectBase_0.GetType() != typeof(ResponsibleAbonentTool) && drawObjectBase_0.GetType() != typeof(FreeLabelTool))
			{
				if (drawObjectBase_0.GetType() != typeof(FreeLabelTool))
				{
					return false;
				}
			}
			return drawObjectBase_0.ToString().ToUpper().Contains(this.toolStripTextBox_0.Text.ToUpper());
		}

		internal static void oasD8t7mCFJELxuQ5qd(Form form_1, bool bool_5)
		{
			form_1.Dispose(bool_5);
		}

		private List<int> list_0;

		private StringBuilder stringBuilder_0;

		private int idInitActiveObj;

		private eTypeCanvas typeCanvas;

		private eSimulationMode eSimulationMode;

		private CanvasControl canvasScheme;

		private CanvasControl canvasControl_1;

		private Class9 class9_0;

		private Class11 class11_0;

		private Class18 treeViewObjects;

		private Class17 class17_0;

		private Class12 class12_0;

		private Dictionary<DrawObjectBase, CanvasControl> dictionary_0;

		private Dictionary<IDockContent, List<TreeNode>> dictionary_1;

		private bool bool_0;

		private bool bool_1;

		private EndpointAddress endPoint;

		public OPCClient opcClient;

		private Size size_0;

		private Form form_0;

		private Point point_0;

		private FormWindowState formWindowState_0;

		private Thread thread_0;

		private List<DrawObjectBase> list_1;

		private int int_1;

		private List<string> list_2;

		private Dictionary<DockContentBase, int> dictionary_2;

		private int int_2;

		private bool bool_2;

		private bool bool_3;

		private bool bool_4;

		private ToolStrip toolStrip_0;

		private BackgroundWorker backgroundWorker_0;

		private ToolStrip toolStrip_1;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripButton toolStripButton_2;

		private DataGridViewImageColumn dataGridViewImageColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripButton toolStripButton_3;

		private DataGridViewImageColumn dataGridViewImageColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewImageColumn dataGridViewImageColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewImageColumn dataGridViewImageColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewImageColumn dataGridViewImageColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewImageColumn dataGridViewImageColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewImageColumn dataGridViewImageColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewImageColumn dataGridViewImageColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewImageColumn dataGridViewImageColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewImageColumn dataGridViewImageColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewImageColumn dataGridViewImageColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewImageColumn dataGridViewImageColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewImageColumn dataGridViewImageColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewImageColumn dataGridViewImageColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewImageColumn dataGridViewImageColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewImageColumn dataGridViewImageColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewImageColumn dataGridViewImageColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewImageColumn dataGridViewImageColumn_17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		private DataGridViewImageColumn dataGridViewImageColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		private DockPanel dockPanel_0;

		private ToolStripButton toolStripButton_4;

		private ToolStripButton toolStripButton_5;

		private ToolStripButton toolStripButton_6;

		private ToolStripButton toolStripButton_7;

		private ToolStripButton toolStripButton_8;

		private ToolStripButton toolStripButton_9;

		private ToolStripButton toolStripButton_10;

		private ContextMenuStrip contextMenuStrip_0;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripMenuItem toolStripMenuItem_1;

		private ToolStripSeparator toolStripSeparator_1;

		private ToolStripMenuItem toolStripMenuItem_2;

		private ToolStripMenuItem toolStripMenuItem_3;

		private ToolStripSeparator toolStripSeparator_2;

		private ToolStripMenuItem toolStripMenuItem_4;

		private ToolStripMenuItem toolStripMenuItem_5;

		private ToolStripMenuItem pYnMneGkhg;

		private ToolStripMenuItem toolStripMenuItem_6;

		private ToolStripSeparator toolStripSeparator_3;

		private ToolStripMenuItem toolStripMenuItem_7;

		private ToolStripSeparator toolStripSeparator_4;

		private ToolStripMenuItem toolStripMenuItem_8;

		private ToolStripMenuItem toolStripMenuItem_9;

		private BackgroundWorker backgroundWorker_1;

		private Panel panel_0;

		private Label label_0;

		private ProgressBarEndLess progressBarEndLess_0;

		private ToolStripSeparator toolStripSeparator_5;

		private ToolStripMenuItem toolStripMenuItem_10;

		private ToolStripMenuItem toolStripMenuItem_11;

		private ToolStripMenuItem toolStripMenuItem_12;

		private ToolStripMenuItem toolStripMenuItem_13;

		private ToolStripMenuItem toolStripMenuItem_14;

		private ToolStripMenuItem toolStripMenuItem_15;

		private ToolStripMenuItem toolStripMenuItem_16;

		private ToolStripMenuItem toolStripMenuItem_17;

		private ToolStripMenuItem toolStripMenuItem_18;

		private ToolStripButton toolStripButton_11;

		private ToolStripButton toolStripButton_12;

		private ToolStripSeparator toolStripSeparator_6;

		private ToolStrip toolStrip_2;

		private ToolStripButton toolStripButton_13;

		private ToolStripButton toolStripButton_14;

		private ToolStripButton toolStripButton_15;

		private ToolStrip toolStrip_3;

		private ToolStripButton toolStripButton_16;

		private ToolStripButton toolStripButton_17;

		private ToolStripButton toolStripButton_18;

		private ToolStripSeparator toolStripSeparator_7;

		private ToolStripButton toolStripButton_19;

		private ToolStrip toolStrip_4;

		private ToolStripButton toolStripButton_20;

		private ToolStripSeparator toolStripSeparator_8;

		private ToolStripButton toolStripButton_21;

		private ToolStripButton toolStripButton_22;

		private ToolStripButton toolStripButton_23;

		private ToolStripButton toolStripButton_24;

		private ToolStripButton toolStripButton_25;

		private ToolStrip toolStrip_5;

		private ToolStripButton toolStripButton_26;

		private ToolStripButton toolStripButton_27;

		private ToolStripSeparator toolStripSeparator_9;

		private ToolStripButton toolStripButton_28;

		private ToolStripSeparator toolStripSeparator_10;

		private ToolStripButton toolStripButton_29;

		private ToolStripButton toolStripButton_30;

		private ToolStripButton toolStripButton_31;

		private ToolStripButton toolStripButton_32;

		private ToolStripSeparator toolStripSeparator_11;

		private ToolStripLabel toolStripLabel_0;

		private ToolStripComboBox toolStripComboBox_0;

		private ToolStripSplitButton toolStripSplitButton_0;

		private ToolStripMenuItem toolStripMenuItem_19;

		private ToolStripMenuItem toolStripMenuItem_20;

		private ToolStripMenuItem toolStripMenuItem_21;

		private ToolStripProgressBar toolStripProgressBar_0;

		private ToolStripLabel toolStripLabel_1;

		private ToolStripMenuItem toolStripMenuItem_22;

		private ToolStripContainer toolStripContainer_0;

		private ToolStripMenuItem toolStripMenuItem_23;

		private ToolStripMenuItem toolStripMenuItem_24;

		private ToolStripButton toolStripButton_33;

		private ToolStripButton toolStripButton_34;

		private ToolStripMenuItem toolStripMenuItem_25;

		private ToolStripMenuItem toolStripMenuItem_26;

		private ToolStripButton toolStripButton_35;

		private ToolStripSeparator toolStripSeparator_12;

		private ToolStripMenuItem toolStripMenuItem_27;

		private ToolStripMenuItem toolStripMenuItem_28;

		private ToolStripMenuItem toolStripMenuItem_29;

		private ToolStripMenuItem toolStripMenuItem_30;

		private ToolStripMenuItem toolStripMenuItem_31;

		private ToolStripMenuItem toolStripMenuItem_32;

		private ToolStripMenuItem toolStripMenuItem_33;

		private ToolStripMenuItem toolStripMenuItem_34;

		private ToolStripButton toolStripButton_36;

		private ToolStripButton toolStripButton_37;

		private ToolStripMenuItem toolStripMenuItem_35;

		private ToolStripSeparator toolStripSeparator_13;

		private ToolStripButton toolStripButton_38;

		private ToolStripButton toolStripButton_39;

		private ToolStripSeparator toolStripSeparator_14;

		private ToolStripButton toolStripButton_40;

		private ToolStripButton toolStripButton_41;

		private ToolStripButton toolStripButton_42;

		private ToolStripButton toolStripButton_43;

		private ToolStripComboBox toolStripComboBox_1;

		private ToolStripButton toolStripButton_44;

		private ToolStripButton toolStripButton_45;

		private ToolStripMenuItem toolStripMenuItem_36;

		private ToolStripMenuItem toolStripMenuItem_37;

		private ToolStripMenuItem toolStripMenuItem_38;

		private ToolStripSeparator toolStripSeparator_15;

		private ToolStripTextBox toolStripTextBox_0;

		private ToolStripButton toolStripButton_46;

		private ToolStripButton toolStripButton_47;

		private ToolStripButton toolStripButton_48;

		private ToolStripMenuItem toolStripMenuItem_39;

		private ToolStripButton toolStripButton_49;

		private ToolStripMenuItem toolStripMenuItem_40;

		private ToolStripButton toolStripButton_50;

		private ToolStripButton toolStripButton_51;

		private ToolStripButton toolStripButton_52;

		private ToolStripButton toolStripButton_53;

		private ToolStripMenuItem toolStripMenuItem_41;

		private ToolStripMenuItem toolStripMenuItem_42;

		private ToolStripMenuItem toolStripMenuItem_43;

		private ToolStripMenuItem toolStripMenuItem_44;

		private ToolStripSeparator toolStripSeparator_16;

		private ToolStripSeparator toolStripSeparator_17;

		private ToolStripMenuItem toolStripMenuItem_45;

		private ToolStripMenuItem toolStripMenuItem_46;

		private ToolStripMenuItem toolStripMenuItem_47;

		private ToolStripComboBox toolStripComboBox_2;

		private ToolStripSeparator mniLotCpLE;

		private ToolStripButton toolStripButton_54;

		private ToolStripMenuItem toolStripMenuItem_48;

		private ToolStripMenuItem toolStripMenuItem_49;

		private ToolStripMenuItem toolStripMenuItem_50;

		private ToolStripSeparator toolStripSeparator_18;

		private ToolStripMenuItem toolStripMenuItem_51;

		private ToolStripMenuItem IlbLiynpEJ;

		private ToolStrip toolStrip_6;

		private ToolStripButton QynLzkVuoQ;
	}
}
