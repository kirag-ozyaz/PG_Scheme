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
using WinFormsUI.Docking;

namespace Scheme.Forms
{

	public partial class FormGeneralScheme2 : FormBase
	{
        private List<int> listIdObj = new List<int>();
        private StringBuilder strIdObj = new StringBuilder(); 
        // активный объект при открытии
        private int idInitActiveObj=-1;
        // какой тип схемы отрыть
        private eTypeCanvas typeCanvas = eTypeCanvas.SchemeMain;  // по умолчанию - главную схему открываем;
        private eSimulationMode eSimulationMode = eSimulationMode.Online;
        private CanvasControl canvasScheme = new CanvasControl();
        private CanvasControl activeCanvas;
        private FormDockCanvasMessage formCanvasMessage;
        private FormDockOPCMessage formOPCMessage;
        private TreeViewPanelObjects treeViewObjects;
        private PoweringTreeViewPanel poweringTreeViewPanel;
        private FormDockStates formDockStates;
        private Dictionary<DrawObjectBase, CanvasControl> objSchemeDictionary = new Dictionary<DrawObjectBase, CanvasControl>();
        private Dictionary<IDockContent, List<TreeNode>> canvasNodes = new Dictionary<IDockContent, List<TreeNode>>();
        private bool closeWindow = false;
        private bool isLoadScheme = false;
        /// <summary>
        /// удаленная точка WCF сервера
        /// </summary>
        private EndpointAddress endPoint = null;
        public OPCClient opcClient = new OPCClient();
        private Size size_0;
        private Form form_0;
        private Point point_0;
        private FormWindowState formWindowState;
        private Thread thread_0;
        private List<DrawObjectBase> list_1;
        private int int_1;
        private List<string> list_2 = new List<string>();
        private Dictionary<DockContentBase, int> dictionary_2 = new Dictionary<DockContentBase, int>();
        private int int_2;
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;

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
			xmlAttribute.Value = this.formOPCMessage.Visible.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockState");
			xmlAttribute.Value = this.formOPCMessage.DockState.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockLeftPortion");
			xmlAttribute.Value = this.formOPCMessage.DockPanel.DockLeftPortion.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockRightPortion");
			xmlAttribute.Value = this.formOPCMessage.DockPanel.DockRightPortion.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockTopPortion");
			xmlAttribute.Value = this.formOPCMessage.DockPanel.DockTopPortion.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockBottomPortion");
			xmlAttribute.Value = this.formOPCMessage.DockPanel.DockBottomPortion.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlNode.AppendChild(xmlNode6);
			XmlNode xmlNode7 = xmlDocument.CreateElement("CanvasMessage");
			xmlAttribute = xmlDocument.CreateAttribute("Visible");
			xmlAttribute.Value = this.formCanvasMessage.Visible.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockState");
			xmlAttribute.Value = this.formCanvasMessage.DockState.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockLeftPortion");
			xmlAttribute.Value = this.formCanvasMessage.DockPanel.DockLeftPortion.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockRightPortion");
			xmlAttribute.Value = this.formCanvasMessage.DockPanel.DockRightPortion.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockTopPortion");
			xmlAttribute.Value = this.formCanvasMessage.DockPanel.DockTopPortion.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockBottomPortion");
			xmlAttribute.Value = this.formCanvasMessage.DockPanel.DockBottomPortion.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlNode.AppendChild(xmlNode7);
			XmlNode xmlNode8 = xmlDocument.CreateElement("PowerPanel");
			xmlAttribute = xmlDocument.CreateAttribute("Visible");
			xmlAttribute.Value = this.poweringTreeViewPanel.Visible.ToString();
			xmlNode8.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockState");
			xmlAttribute.Value = this.poweringTreeViewPanel.DockState.ToString();
			xmlNode8.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockLeftPortion");
			xmlAttribute.Value = this.poweringTreeViewPanel.DockPanel.DockLeftPortion.ToString();
			xmlNode8.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockRightPortion");
			xmlAttribute.Value = this.poweringTreeViewPanel.DockPanel.DockRightPortion.ToString();
			xmlNode8.Attributes.Append(xmlAttribute);
			xmlNode.AppendChild(xmlNode8);
			XmlNode xmlNode9 = xmlDocument.CreateElement("StatesPanel");
			xmlAttribute = xmlDocument.CreateAttribute("Visible");
			xmlAttribute.Value = this.formDockStates.Visible.ToString();
			xmlNode9.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockState");
			xmlAttribute.Value = this.formDockStates.DockState.ToString();
			xmlNode9.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockLeftPortion");
			xmlAttribute.Value = this.formDockStates.DockPanel.DockLeftPortion.ToString();
			xmlNode9.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("DockRightPortion");
			xmlAttribute.Value = this.formDockStates.DockPanel.DockRightPortion.ToString();
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

		protected override void ApplyConfig(XmlDocument doc1)
		{
			XmlNode xmlNode = doc1.SelectSingleNode("FormGeneralScheme");
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
						this.formOPCMessage.Close();
					}
					xmlAttribute2 = xmlNode3.Attributes["DockState"];
					if (xmlAttribute2 != null)
					{
						this.formOPCMessage.DockState = (DockState)Enum.Parse(typeof(DockState), xmlAttribute2.Value);
					}
					xmlAttribute2 = xmlNode3.Attributes["DockLeftPortion"];
					if (xmlAttribute2 != null)
					{
						this.formOPCMessage.DockPanel.DockLeftPortion = Convert.ToDouble(xmlAttribute2.Value);
					}
					xmlAttribute2 = xmlNode3.Attributes["DockRightPortion"];
					if (xmlAttribute2 != null)
					{
						this.formOPCMessage.DockPanel.DockRightPortion = Convert.ToDouble(xmlAttribute2.Value);
					}
					xmlAttribute2 = xmlNode3.Attributes["DockTopPortion"];
					if (xmlAttribute2 != null)
					{
						this.formOPCMessage.DockPanel.DockTopPortion = Convert.ToDouble(xmlAttribute2.Value);
					}
					xmlAttribute2 = xmlNode3.Attributes["DockBottomPortion"];
					if (xmlAttribute2 != null)
					{
						this.formOPCMessage.DockPanel.DockBottomPortion = Convert.ToDouble(xmlAttribute2.Value);
					}
				}
				XmlNode xmlNode4 = xmlNode.SelectSingleNode("CanvasMessage");
				if (xmlNode4 != null)
				{
					XmlAttribute xmlAttribute3 = xmlNode4.Attributes["Visible"];
					if (xmlAttribute3 != null && !Convert.ToBoolean(xmlAttribute3.Value))
					{
						this.formCanvasMessage.Close();
					}
					xmlAttribute3 = xmlNode4.Attributes["DockState"];
					if (xmlAttribute3 != null)
					{
						this.formCanvasMessage.DockState = (DockState)Enum.Parse(typeof(DockState), xmlAttribute3.Value);
					}
					xmlAttribute3 = xmlNode4.Attributes["DockLeftPortion"];
					if (xmlAttribute3 != null)
					{
						this.formCanvasMessage.DockPanel.DockLeftPortion = Convert.ToDouble(xmlAttribute3.Value);
					}
					xmlAttribute3 = xmlNode4.Attributes["DockRightPortion"];
					if (xmlAttribute3 != null)
					{
						this.formCanvasMessage.DockPanel.DockRightPortion = Convert.ToDouble(xmlAttribute3.Value);
					}
					xmlAttribute3 = xmlNode4.Attributes["DockTopPortion"];
					if (xmlAttribute3 != null)
					{
						this.formCanvasMessage.DockPanel.DockTopPortion = Convert.ToDouble(xmlAttribute3.Value);
					}
					xmlAttribute3 = xmlNode4.Attributes["DockBottomPortion"];
					if (xmlAttribute3 != null)
					{
						this.formCanvasMessage.DockPanel.DockBottomPortion = Convert.ToDouble(xmlAttribute3.Value);
					}
				}
				XmlNode xmlNode5 = xmlNode.SelectSingleNode("PowerPanel");
				if (xmlNode5 != null)
				{
					XmlAttribute xmlAttribute4 = xmlNode5.Attributes["Visible"];
					if (xmlAttribute4 != null && !Convert.ToBoolean(xmlAttribute4.Value))
					{
						this.poweringTreeViewPanel.Close();
					}
					xmlAttribute4 = xmlNode5.Attributes["DockState"];
					if (xmlAttribute4 != null)
					{
						this.poweringTreeViewPanel.DockState = (DockState)Enum.Parse(typeof(DockState), xmlAttribute4.Value);
					}
					xmlAttribute4 = xmlNode5.Attributes["DockLeftPortion"];
					if (xmlAttribute4 != null)
					{
						this.poweringTreeViewPanel.DockPanel.DockLeftPortion = Convert.ToDouble(xmlAttribute4.Value);
					}
					xmlAttribute4 = xmlNode5.Attributes["DockRightPortion"];
					if (xmlAttribute4 != null)
					{
						this.poweringTreeViewPanel.DockPanel.DockRightPortion = Convert.ToDouble(xmlAttribute4.Value);
					}
				}
				XmlNode xmlNode6 = xmlNode.SelectSingleNode("StatesPanel");
				if (xmlNode6 != null)
				{
					XmlAttribute xmlAttribute5 = xmlNode6.Attributes["Visible"];
					if (xmlAttribute5 != null && !Convert.ToBoolean(xmlAttribute5.Value))
					{
						this.formDockStates.Close();
					}
					xmlAttribute5 = xmlNode6.Attributes["DockState"];
					if (xmlAttribute5 != null)
					{
						this.formDockStates.DockState = (DockState)Enum.Parse(typeof(DockState), xmlAttribute5.Value);
					}
					xmlAttribute5 = xmlNode6.Attributes["DockLeftPortion"];
					if (xmlAttribute5 != null)
					{
						this.formDockStates.DockPanel.DockLeftPortion = Convert.ToDouble(xmlAttribute5.Value);
					}
					xmlAttribute5 = xmlNode6.Attributes["DockRightPortion"];
					if (xmlAttribute5 != null)
					{
						this.formDockStates.DockPanel.DockRightPortion = Convert.ToDouble(xmlAttribute5.Value);
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

        #region Старая схема
        private void LoadOldScheme(string NameDB)
		{
			if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeSecond)
			{
				SqlConnection selectConnection = new SqlConnection("Server = ulges-sql;dataBase = scheme_" + NameDB + ";Integrated Security=true;Connection TimeOut = 180");
				if (this.activeCanvas.Layers.Count<ICanvasLayer>() > 0)
				{
					IEnumerable<DrawObjectBase> source = from a in this.activeCanvas.Layers.First<ICanvasLayer>().Objects
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
			foreach (DrawObjectBase drawObjectBase in this.activeCanvas.Layers.First<ICanvasLayer>().Objects)
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
			int num2 = this.activeCanvas.Layers.First<ICanvasLayer>().Objects.Count((DrawObjectBase o) => o.GetType() == typeof(RectangleTool) || o.GetType() == typeof(LineTool));
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
			IEnumerable<DrawObjectBase> source = from obj in this.activeCanvas.Layers.First<ICanvasLayer>().Objects
			where obj.GetType() == typeof(RectangleTool)
			select obj;
			int num = 0;
			using (IEnumerator enumerator = dataTable_0.Rows.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DataRow dr = (DataRow)enumerator.Current;
					if ((!(dr["Volt"].ToString() == "1") && !(dr["Volt"].ToString() == "0")) || this.activeCanvas.TypeCanvas != eTypeCanvas.SchemeSecond)
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
						if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
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
						shinaTool.Layer = (DrawingLayer)this.activeCanvas.Layers.First<ICanvasLayer>();
						if (!this.activeCanvas.ValidateToUnique(shinaTool))
						{
							shinaTool.CreateUniqueCopyName();
						}
						this.activeCanvas.AddObject(this.activeCanvas.Layers.First<ICanvasLayer>(), shinaTool);
						this.backgroundWorker_0.ReportProgress((int)((float)num / (float)dataTable_0.Rows.Count * 100f), " Shina: ");
						num++;
					}
				}
			}
		}

		private void method_6(DataTable dataTable_0)
		{
			IEnumerable<DrawObjectBase> source = from obj in this.activeCanvas.Layers.First<ICanvasLayer>().Objects
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
			IEnumerable<DrawObjectBase> enumerable = from obj in this.activeCanvas.Layers.First<ICanvasLayer>().Objects
			where obj.GetType() == typeof(ShinaTool)
			select obj;
			using (IEnumerator enumerator = dataTable_0.Rows.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					if (!this.listIdObj.Contains(Convert.ToInt32(dataRow["id_obj"])))
					{
						LineCellTool lineCellTool = new LineCellTool();
						DataRow[] points = dataTable_1.Select("id_obj = " + dataRow["id_point1"].ToString());
						PointTool pointTool = new PointTool((DrawingLayer)this.activeCanvas.Layers.First<ICanvasLayer>());
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
								if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
								{
									source = from obj in this.activeCanvas.Layers.First<ICanvasLayer>().Objects
									where obj.GetType() == typeof(RectangleTool) && ((RectangleTool)obj).IdOldBase == points[0]["nom_group"].ToString()
									select obj;
								}
								else
								{
									source = from obj in this.activeCanvas.Layers.First<ICanvasLayer>().Objects
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
								lineCellTool.Layer = (DrawingLayer)this.activeCanvas.Layers.First<ICanvasLayer>();
								if (!this.activeCanvas.ValidateToUnique(lineCellTool))
								{
									lineCellTool.CreateUniqueCopyName();
								}
								foreach (DataRow dataRow2 in dataTable_2.Select("id_line = " + dataRow["id_obj"].ToString()))
								{
									TypeSwitch typeSwitch = TypeSwitch.LinearDisconnectorTool;
									switch (Convert.ToInt32(dataRow2["type"]))
									{
									case 1:
										if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
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
										if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
										{
											typeSwitch = TypeSwitch.LubricantSwitchTool;
										}
										else
										{
											typeSwitch = TypeSwitch.LinearDisconnectorTool;
										}
										break;
									case 4:
										if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
										{
											typeSwitch = TypeSwitch.DamageTool;
										}
										else
										{
											typeSwitch = TypeSwitch.FuseTool;
										}
										break;
									case 5:
										if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
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
										if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
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
									objectOnLine.Layer = (DrawingLayer)this.activeCanvas.Layers.First<ICanvasLayer>();
									objectOnLine.Text = "Выключатель";
									if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
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
									if (!this.activeCanvas.ValidateToUnique(objectOnLine))
									{
										objectOnLine.CreateUniqueCopyName();
									}
									((DrawingLayer)this.activeCanvas.Layers.First<ICanvasLayer>()).AddObject(objectOnLine);
								}
								if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeSecond)
								{
									foreach (DataRow dataRow3 in dataTable_3.Select("id_line = " + dataRow["id_obj"].ToString()))
									{
										TextBranchTool textBranchTool = new TextBranchTool();
										textBranchTool.Parent = lineCellTool.Branches[lineCellTool.Branches.Count - 1];
										textBranchTool.Layer = (DrawingLayer)this.activeCanvas.Layers.First<ICanvasLayer>();
										textBranchTool.IdOldBase = dataRow3["id_obj"].ToString();
										textBranchTool.Text = dataRow3["text"].ToString();
										if (Convert.ToInt32(dataRow3["orient"]) == 0)
										{
											textBranchTool.TextProperty.Position = ePositionText.B;
										}
										((DrawingLayer)this.activeCanvas.Layers.First<ICanvasLayer>()).AddObject(textBranchTool);
									}
								}
								foreach (DrawObjectBase drawObjectBase in enumerable)
								{
									ShinaTool shinaTool = (ShinaTool)drawObjectBase;
									if (shinaTool.Parent != null && (this.activeCanvas.TypeCanvas != eTypeCanvas.SchemeMain || !(((RectangleTool)shinaTool.Parent).IdOldBase != points[0]["nom_group"].ToString())))
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
								this.listIdObj.Add(Convert.ToInt32(dataRow["id_obj"]));
								this.backgroundWorker_0.ReportProgress((int)((float)this.listIdObj.Count / (float)dataTable_0.Rows.Count * 100f), " LineCell: ");
								this.strIdObj.Append(dataRow["id_obj"].ToString() + ",");
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
								this.activeCanvas.AddObject(this.activeCanvas.Layers.First<ICanvasLayer>(), lineCellTool);
								continue;
								IL_BD6:
								if (this.activeCanvas.ValidateToUnique(lineCellTool))
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
			IEnumerable<DrawObjectBase> enumerable = from obj in this.activeCanvas.Layers.First<ICanvasLayer>().Objects
			where obj.GetType() == typeof(ShinaTool)
			select obj;
			string text = this.strIdObj.ToString();
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
				if (!this.listIdObj.Contains(Convert.ToInt32(dataRow["id_obj"])))
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
					PointTool pointTool = new PointTool((DrawingLayer)this.activeCanvas.Layers.First<ICanvasLayer>());
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
								if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
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
								if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
								{
									typeSwitch = TypeSwitch.LubricantSwitchTool;
								}
								else
								{
									typeSwitch = TypeSwitch.LinearDisconnectorTool;
								}
								break;
							case 4:
								if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
								{
									typeSwitch = TypeSwitch.DamageTool;
								}
								else
								{
									typeSwitch = TypeSwitch.FuseTool;
								}
								break;
							case 5:
								if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
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
								if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
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
							objectOnLine.Layer = (DrawingLayer)this.activeCanvas.Layers.First<ICanvasLayer>();
							objectOnLine.Text = "Выключатель";
							if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
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
							if (!this.activeCanvas.ValidateToUnique(objectOnLine))
							{
								objectOnLine.CreateUniqueCopyName();
							}
							((DrawingLayer)this.activeCanvas.Layers.First<ICanvasLayer>()).AddObject(objectOnLine);
						}
						if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeSecond)
						{
							foreach (DataRow dataRow3 in dataTable_3.Select("id_line = " + dataRow["id_obj"].ToString()))
							{
								TextBranchTool textBranchTool = new TextBranchTool();
								textBranchTool.Parent = lineCellTool_0.Branches[lineCellTool_0.Branches.Count - 1];
								textBranchTool.Layer = (DrawingLayer)this.activeCanvas.Layers.First<ICanvasLayer>();
								textBranchTool.IdOldBase = dataRow3["id_obj"].ToString();
								textBranchTool.Text = dataRow3["text"].ToString();
								if (Convert.ToInt32(dataRow3["orient"]) == 0)
								{
									textBranchTool.TextProperty.Position = ePositionText.B;
								}
								((DrawingLayer)this.activeCanvas.Layers.First<ICanvasLayer>()).AddObject(textBranchTool);
							}
						}
						foreach (DrawObjectBase drawObjectBase in enumerable)
						{
							ShinaTool shinaTool = (ShinaTool)drawObjectBase;
							if (shinaTool.Parent != null && (this.activeCanvas.TypeCanvas != eTypeCanvas.SchemeMain || !(((RectangleTool)shinaTool.Parent).IdOldBase != array3[0]["nom_group"].ToString())))
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
						this.listIdObj.Add(Convert.ToInt32(dataRow["id_obj"]));
						this.backgroundWorker_0.ReportProgress((int)((float)this.listIdObj.Count / (float)dataTable_0.Rows.Count * 100f), " LineCell: ");
						this.strIdObj.Append(dataRow["id_obj"].ToString() + ",");
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
				if (!this.listIdObj.Contains(Convert.ToInt32(dataRow["id_obj"])))
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
							this.listIdObj.Add(Convert.ToInt32(dataRow["id_obj"]));
							this.backgroundWorker_0.ReportProgress((int)((float)this.listIdObj.Count / (float)dataTable_0.Rows.Count * 100f), " Line: ");
							this.strIdObj.Append(dataRow["id_obj"].ToString() + ",");
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
			string text = this.strIdObj.ToString();
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
				if (!this.listIdObj.Contains(Convert.ToInt32(dataRow["id_obj"])))
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
						this.listIdObj.Add(Convert.ToInt32(dataRow["id_obj"]));
						this.backgroundWorker_0.ReportProgress((int)((float)this.listIdObj.Count / (float)dataTable_0.Rows.Count * 100f), " Line: ");
						this.strIdObj.Append(dataRow["id_obj"].ToString() + ",");
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
        #endregion

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
			

			this.InitializeComponent();
			this.InitForm();
		}

		public FormGeneralScheme2(SQLSettings sqlSettings)
		{

			this.InitializeComponent();
			this.SqlSettings = sqlSettings;
			this.InitForm();
		}
        /// <summary>
        /// конструктор с подключением к WCF
        /// основной способ подключения
        /// </summary>
        /// <param name="sqlSettings"></param>
        /// <param name="endPoint"></param>
        /// <param name="a">Чтобы VS (#$%& >:o) не перепутала с другим конструктором и не стала выдавать ошибку</param>
		public FormGeneralScheme2(SQLSettings sqlSettings, EndpointAddress endPoint, int a)
		{

			
			this.InitializeComponent();

			this.endPoint = endPoint;
			this.SqlSettings = sqlSettings;
			this.InitForm();
		}

		public FormGeneralScheme2(SQLSettings sqlSettings, int simulationMode, int a)
		{

			
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

			
			this.InitializeComponent();
			this.InitForm();
			this.idInitActiveObj = activeObj;
			this.typeCanvas = typeCanvas;
		}
        // Инициализация формы
        private void InitForm()
		{
			GeneralFormSettings.SizeIconChanged(new EventHandler(this.tbvehYxUr9));
			GeneralFormSettings.FontSizeChanged(new EventHandler(this.method_15));
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
			dockContentBase.DockAreas = DockAreas.Document;
			dockContentBase.CloseButtonVisible = false;
			if (this.eSimulationMode == eSimulationMode.Online)
			{
				dockContentBase.Text = "Оперативная схема";
			}
			else if (this.eSimulationMode == eSimulationMode.Normal)
			{
				dockContentBase.Text = "Нормальная схема";
			}
			this.canvasScheme.CanvasModeChanged += this.canvasControl_0_CanvasModeChanged;
			this.canvasScheme.TypeCanvas = this.typeCanvas;
			this.canvasScheme.SimulationMode = this.eSimulationMode;
			this.canvasScheme.ShowContextMenuCanvasEvent += new ShowContextMenuCanvasEventHandler(this.canvasScheme_ShowContextMenuCanvasEvent);
			this.canvasScheme.HideContextMenuCanvasEvent += new ShowContextMenuCanvasEventHandler(this.canvasControl_HideContextMenuCanvasEvent);
			this.canvasScheme.ObjectsAdded += new DrawObjectEventHandler(this.canvasScheme_ObjectsAdded);
			this.canvasScheme.ObjectClicked += new DrawObjectEventHandler(this.canvasControl_ObjectClicked);
			this.canvasScheme.FlashObjectsAdded += new DrawObjectEventHandler(this.canvasControl_FlashObjectsAdded);
			this.canvasScheme.FlashObjectsRemoved += new DrawObjectEventHandler(this.canvasControl_FlashObjectsRemoved);
			this.canvasScheme.ContextMenuRectangle = this.contextMenuStrip_0;
			this.activeCanvas = this.canvasScheme;
			this.dockPanel1.ActiveDocumentChanged += this.dockPanel_0_ActiveDocumentChanged;
			dockContentBase.ShowForm += this.ShowFormBase;
			dockContentBase.Show(this.dockPanel1);
			if (this.canvasScheme.Layers.Count<ICanvasLayer>() <= 0)
			{
				DrawingLayer drawingLayer = new DrawingLayer("defaultLayer", "Default Layer", Color.White, 0f);
				drawingLayer.Parent = this.canvasScheme;
				this.canvasScheme.AddLayer(drawingLayer);
			}
			this.toolStripTools.Location = new Point(0, 0);
			this.toolStrip_2.Location = new Point(this.toolStripTools.Right, 0);
			this.toolStrip_3.Location = new Point(this.toolStrip_2.Right, 0);
			this.toolStrip_4.Location = new Point(0, this.toolStripTools.Bottom);
			this.toolStrip_0.Location = new Point(this.toolStrip_4.Right, this.toolStripTools.Bottom);
			this.toolStrip_5.Location = new Point(this.toolStrip_0.Right, this.toolStripTools.Bottom);
		}

		private FormBase ShowFormBase(object sender, ShowFormEventArgs e)
		{
			return this.OnShowForm(e);
		}

		private void method_13()
		{
		}

		private void canvasControl_0_CanvasModeChanged(object sender, EventArgs e)
		{
		}

		private bool method_14()
		{
			Class19 @class = new Class19();
			base.SelectSqlData(@class, @class.vUserInGroup, true, " where Login = SYSTEM_USER ");
			return @class.vUserInGroup.Rows.Count > 0 && @class.vUserInGroup.Rows[0]["nameGroup"].ToString() == "ОДС";
		}

		private void method_15(object sender, EventArgs e)
		{
			this.Font = new Font(this.Font.Name, GeneralFormSettings.FontSize);
		}

		private void tbvehYxUr9(object sender, EventArgs e)
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
			this.toolStripTools.ImageScalingSize = GeneralFormSettings.SizeIcon;
			location = this.toolStripTools.Location;
			this.toolStripTools.Scale(new SizeF(2f, 2f));
			this.toolStripTools.Location = location;
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
			this.isLoadScheme = true;
			this.canvasScheme.SaveProcessChanged += this.canvasControl_0_SaveProcessChanged;
			this.canvasScheme.CanvasMessage += this.canvasControl_0_CanvasMessage;
			this.canvasScheme.SelectedObjectMoved += this.canvasControl_0_SelectedObjectMoved;
			this.canvasScheme.SelectedObjectEdited += this.canvasControl_SelectedObjectEdited;
			this.canvasScheme.DrawingCompleted += this.canvasControl_DrawingCompleted;
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
				this.canvasNodes.Remove((IDockContent)this.canvasScheme.Parent);
			}
			this.backgroundWorker_1.RunWorkerAsync(bool_5);
		}

		private void canvasControl_0_ObjectOnLinePropertyOnCanged(object sender, EventArgs e)
		{
			if (this.formDockStates == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)sender;
			if (objectOnLine.On)
			{
				if (!objectOnLine.IsNormalSection)
				{
					this.formDockStates.method_10((ObjectOnLine)sender);
					return;
				}
				this.formDockStates.method_9((ObjectOnLine)sender);
				return;
			}
			else
			{
				if (objectOnLine.IsNormalSection)
				{
					this.formDockStates.method_10((ObjectOnLine)sender);
					return;
				}
				this.formDockStates.method_9((ObjectOnLine)sender);
				return;
			}
		}

		private void canvasControl_0_StateRemoved(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
			if (this.formDockStates == null)
			{
				return;
			}
			this.formDockStates.method_8(lineToolEventArgs_0.state);
		}

		private void canvasControl_0_StateAdded(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
			if (this.formDockStates != null)
			{
				this.formDockStates.method_6(lineToolEventArgs_0.state);
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
			if (this.canvasScheme.WorkerCounter <= 0 && !this.isLoadScheme)
			{
				GeneralFormSettings.smethod_1(new EventHandler(this.tbvehYxUr9));
				GeneralFormSettings.smethod_3(new EventHandler(this.method_15));
				base.SaveFormConfig(null);
				this.OPCDisconnect();
				if (this.thread_0 != null && this.thread_0.IsAlive)
				{
					this.thread_0.Abort();
				}
			}
			else
			{
				this.closeWindow = true;
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
					this.formWindowState = base.WindowState;
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
					base.WindowState = this.formWindowState;
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
			this.isLoadScheme = false;
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
			this.formCanvasMessage.method_6("Загрузка завершена", 2, null);
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
			if (this.closeWindow)
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
				this.treeViewObjects = new TreeViewPanelObjects();
				flag = true;
			}
			this.treeViewObjects.Show(this.dockPanel1);
			if (flag)
			{
				this.treeViewObjects.DockPanel.DockRightPortion = 0.15;
				this.treeViewObjects.method_0(new TreeViewEventHandler(this.method_22));
				this.treeViewObjects.method_14(new Delegate4(this.method_19));
				this.treeViewObjects.Layout += this.class9_0_Layout;
				this.treeViewObjects.FormClosing += this.class18_0_FormClosing;
				this.treeViewObjects.method_10((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]);
				this.canvasNodes.Add(this.dockPanel1.ActiveDocument, this.treeViewObjects.method_9());
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
			if (this.activeCanvas != null)
			{
				foreach (ICanvasLayer canvasLayer in this.activeCanvas.Layers)
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
				if (this.canvasNodes.ContainsKey(this.dockPanel1.ActiveDocument))
				{
					this.treeViewObjects.method_11(this.canvasNodes[this.dockPanel1.ActiveDocument]);
				}
				else if (((DockContentBase)this.dockPanel1.ActiveDocument).Controls.Count > 0 && ((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
				{
					CanvasControl canvasControl = (CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0];
					this.treeViewObjects.method_10(canvasControl);
					this.canvasNodes.Add(this.dockPanel1.ActiveDocument, this.treeViewObjects.method_9());
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
			if (this.activeCanvas != null)
			{
				this.activeCanvas.DoInvalidate(true);
			}
		}

		private void method_22(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Level > 0 && e.Node.IsSelected)
			{
				if (e.Node.Tag is DrawObjectBase)
				{
					DrawObjectBase drawObject = (DrawObjectBase)e.Node.Tag;
					if (this.activeCanvas != null)
					{
						this.activeCanvas.SetObjectsInCenterScreen(drawObject, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
						return;
					}
				}
				else
				{
					List<DrawObjectBase> drawObjects = (List<DrawObjectBase>)e.Node.Tag;
					if (this.activeCanvas != null)
					{
						this.activeCanvas.SetObjectsInCenterScreen(drawObjects, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
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
				this.formCanvasMessage.method_6("Соединение с OPCServer прошло успешно", 2, null);
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
				this.formCanvasMessage.method_6("Отсоединение от сервера", 2, null);
				this.method_24(false);
				break;
			case 7:
				this.formCanvasMessage.method_6("Обрыв соединения с OPCServer", 0, null);
				this.method_24(false);
				return;
			case 8:
				this.formCanvasMessage.method_6(object_0.ToString(), 0, null);
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
			if (this.activeCanvas.Layers.Count<ICanvasLayer>() > 0)
			{
				source = from o in this.activeCanvas.ActiveLayer.Objects
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
							if (this.formOPCMessage != null)
							{
								this.formOPCMessage.method_5(message, (ObjectOnLine)drawObjectBase);
							}
						}
					}
					if (this.formOPCMessage != null)
					{
						this.formOPCMessage.method_4(message, eMessageType.OPCItem);
					}
				}
			}
		}

		private void method_26(OPCMessage opcmessage_0)
		{
			if (this.formOPCMessage != null)
			{
				this.formOPCMessage.method_4(opcmessage_0, eMessageType.OPCEvent);
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
				this.formCanvasMessage.method_6(ex.Message, 0, null);
			}
		}

		private void method_28()
		{
			bool flag = false;
			if (this.formOPCMessage == null)
			{
				this.formOPCMessage = new FormDockOPCMessage();
				flag = true;
			}
			this.formOPCMessage.Show(this.dockPanel1);
			if (flag)
			{
				this.formOPCMessage.DockPanel.DockRightPortion = 0.5;
				this.formOPCMessage.method_0(new Delegate1(this.method_29));
				this.formOPCMessage.FormClosing += this.class11_0_FormClosing;
				this.formOPCMessage.Layout += this.class9_0_Layout;
				this.formOPCMessage.method_13(new EventHandler(this.method_30));
				this.formOPCMessage.method_15(new EventHandler(this.method_31));
			}
		}

		private void class11_0_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.toolStripButton_5.Checked = false;
			this.formOPCMessage.Hide();
			e.Cancel = true;
		}

		private void method_29(OPCMessage opcmessage_0)
		{
			DrawObjectBase drawObjectBase = this.activeCanvas.FindObjectById(opcmessage_0.ObjectId);
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
			if (this.poweringTreeViewPanel == null)
			{
				this.poweringTreeViewPanel = new PoweringTreeViewPanel();
				this.poweringTreeViewPanel.method_10(this.SqlSettings);
				flag = true;
			}
			this.poweringTreeViewPanel.Show(this.dockPanel1);
			if (flag)
			{
				this.poweringTreeViewPanel.DockPanel.DockLeftPortion = 0.15;
				this.poweringTreeViewPanel.Layout += this.class9_0_Layout;
				this.poweringTreeViewPanel.FormClosing += this.class17_0_FormClosing;
			}
		}

		private void class17_0_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.toolStripButton_7.Checked = false;
			this.poweringTreeViewPanel.Hide();
			e.Cancel = true;
		}

		private void method_33()
		{
			bool flag = false;
			if (this.formDockStates == null)
			{
				this.formDockStates = new FormDockStates();
				flag = true;
			}
			this.formDockStates.Show(this.dockPanel1);
			if (flag)
			{
				this.formDockStates.DockPanel.DockLeftPortion = 0.15;
				this.formDockStates.Layout += this.class12_0_Layout;
				this.formDockStates.FormClosing += this.class12_0_FormClosing;
				this.formDockStates.method_1(new DataGridViewCellEventHandler(this.method_35));
				this.method_34();
			}
		}

		private void method_34()
		{
			if (this.formDockStates != null)
			{
				try
				{
					foreach (LineToolState lineToolState_ in ((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]).States)
					{
						this.formDockStates.method_6(lineToolState_);
					}
					foreach (ICanvasLayer canvasLayer in ((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]).Layers)
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
										this.formDockStates.method_10(objectOnLine);
									}
									else
									{
										this.formDockStates.method_9(objectOnLine);
									}
								}
								else if (objectOnLine.IsNormalSection)
								{
									this.formDockStates.method_10(objectOnLine);
								}
								else
								{
									this.formDockStates.method_9(objectOnLine);
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
			if (e.RowIndex >= 0 && this.formDockStates.method_0().Count > 0)
			{
				DataGridViewRow dataGridViewRow = this.formDockStates.method_0()[0];
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
			this.formDockStates.Hide();
			e.Cancel = true;
		}

		private void method_36()
		{
			if (this.formDockStates != null)
			{
				this.formDockStates.method_3();
			}
		}

		private void method_37()
		{
			bool flag = false;
			if (this.formCanvasMessage == null)
			{
				this.formCanvasMessage = new FormDockCanvasMessage();
				flag = true;
			}
			this.formCanvasMessage.Show(this.dockPanel1);
			if (flag)
			{
				this.formCanvasMessage.DockPanel.DockBottomPortion = 0.15;
				this.formCanvasMessage.Layout += this.class9_0_Layout;
				this.formCanvasMessage.method_0(new DataGridViewCellEventHandler(this.method_38));
				this.formCanvasMessage.FormClosing += this.class9_0_FormClosing;
			}
		}

		private void class9_0_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.toolStripButton_6.Checked = false;
			this.formCanvasMessage.Hide();
			e.Cancel = true;
		}

		private void method_38(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && this.formCanvasMessage.method_2().Count > 0)
			{
				DataGridViewRow dataGridViewRow = this.formCanvasMessage.method_2()[0];
				if (dataGridViewRow.Tag != null)
				{
					this.canvasScheme.SetObjectsInCenterScreen(((CanvasMessageEventArgs)dataGridViewRow.Tag).MessageObjects, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
				}
			}
		}

		private void method_39()
		{
			if (this.formCanvasMessage != null)
			{
				this.formCanvasMessage.method_5();
			}
		}

		private void toolStripButton_11_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null)
			{
				this.activeCanvas.CommandPan();
			}
		}

		private void toolStripButton_12_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null)
			{
				this.activeCanvas.CommandEscape();
			}
		}

		private void toolStripButton_21_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null)
			{
				this.activeCanvas.CommandZoomWindow();
			}
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null)
			{
				this.activeCanvas.CommandDrawTool("Rectangle");
			}
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null)
			{
				this.activeCanvas.CommandDrawTool("Shina");
			}
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null)
			{
				this.activeCanvas.CommandDrawTool("Line");
			}
		}

		private void toolStripButton_36_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null)
			{
				this.activeCanvas.CommandDrawTool("Text");
			}
		}

		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
			PatternTP pattern = new PatternTP();
			if (this.activeCanvas != null)
			{
				this.activeCanvas.CommandPattern(pattern);
			}
		}

		private void toolStripButton_13_Click(object sender, EventArgs e)
		{
		}

		private void toolStripButton_14_Click(object sender, EventArgs e)
		{
			if (this.canvasScheme.WorkerCounter <= 0 && !this.isLoadScheme)
			{
				this.method_16(true);
				return;
			}
			this.formCanvasMessage.method_6("Не завершено сохранение изменений", 2, null);
		}

		private void toolStripButton_16_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null)
			{
				this.activeCanvas.ShowPageSetupDialog();
			}
		}

		private void toolStripButton_17_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null)
			{
				this.activeCanvas.printPreviewDialog = new PrintPreviewDialog();
				this.activeCanvas.printPreviewDialog.Document = this.activeCanvas.printDocument;
				this.activeCanvas.printPreviewDialog.MdiParent = base.MdiParent;
				this.activeCanvas.printPreviewDialog.Show();
			}
		}

		private void toolStripButton_18_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null && this.activeCanvas.printDialog.ShowDialog() == DialogResult.OK)
			{
				this.activeCanvas.printDocument.Print();
			}
		}

		private void toolStripButton_37_Click(object sender, EventArgs e)
		{
			this.activeCanvas.Print();
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
					Func<DrawObjectBase, bool> C9__0=null;
					foreach (ICanvasLayer canvasLayer in this.canvasScheme.Layers)
					{
						List<DrawObjectBase> list2 = list;
						IEnumerable<DrawObjectBase> objects = canvasLayer.Objects;
						Func<DrawObjectBase, bool> predicate;
						if ((predicate = C9__0) == null)
						{
							predicate = (C9__0 = ((DrawObjectBase obj) => listIdObjects.Contains(obj.IdBase)));
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
					dockContentBase.Show(this.dockPanel1);
				}
			}
		}

		private void toolStripButton_27_Click(object sender, EventArgs e)
		{
			this.canvasScheme.ClearFilter();
		}

		private void toolStripButton_46_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null)
			{
				this.method_40();
				if (this.list_1 != null && this.list_1.Count > 0)
				{
					this.int_1 = 0;
					this.activeCanvas.SetObjectsInCenterScreen(this.list_1[this.int_1], false, CanvasControl.SetObjectsInCenterScreenOptions.select);
				}
			}
		}

		private void toolStripButton_47_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null)
			{
				this.method_40();
				if (this.list_1 != null && this.list_1.Count > 0)
				{
					this.int_1--;
					if (this.int_1 < 0)
					{
						this.int_1 = this.list_1.Count - 1;
					}
					this.activeCanvas.SetObjectsInCenterScreen(this.list_1[this.int_1], false, CanvasControl.SetObjectsInCenterScreenOptions.select);
				}
			}
		}

		private void toolStripButton_48_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas != null)
			{
				this.int_1++;
				this.method_40();
				if (this.list_1 != null && this.list_1.Count > 0)
				{
					if (this.int_1 >= this.list_1.Count)
					{
						this.int_1 = 0;
					}
					this.activeCanvas.SetObjectsInCenterScreen(this.list_1[this.int_1], false, CanvasControl.SetObjectsInCenterScreenOptions.select);
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
					foreach (ICanvasLayer canvasLayer in this.activeCanvas.Layers)
					{
						DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
						this.list_1.AddRange(drawingLayer.Objects.Where(new Func<DrawObjectBase, bool>(this.method_57)));
					}
					this.list_1.Sort((DrawObjectBase o1, DrawObjectBase o2) => o1.ToString().CompareTo(o2.ToString()));
					List<DrawObjectBase> list = new List<DrawObjectBase>();
					foreach (ICanvasLayer canvasLayer2 in this.activeCanvas.Layers)
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
			this.LoadOldScheme("NR");
			this.listIdObj.Clear();
			this.LoadOldScheme("NL");
			this.listIdObj.Clear();
		}

		private void toolStripButton_19_Click(object sender, EventArgs e)
		{
			if (new FormCanvasSettings(this.activeCanvas).ShowDialog() == DialogResult.OK)
			{
				if (this.activeCanvas != null)
				{
					this.activeCanvas.DoInvalidate(true);
				}
				this.activeCanvas.UpdateMeasurementForBus();
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
			formJournalAbn.Show(this.dockPanel1);
		}

		private void method_42(object sender, GoToSchemaEventArgs e)
		{
			this.OnGoToSchema(e);
		}

		private void canvasControl_FlashObjectsRemoved(CanvasControl canvasControl_2, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
			if (this.canvasScheme.FlashingObjects.Count<DrawObjectBase>() <= 0)
			{
				this.toolStripButton_28.Enabled = false;
			}
		}

		private void canvasControl_FlashObjectsAdded(CanvasControl canvasControl_2, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
			this.toolStripButton_28.Enabled = true;
		}

		private void canvasControl_DrawingCompleted(CanvasControl canvasControl_2, DrawObjectsEventArgs drawObjectsEventArgs_0)
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

		private void canvasControl_SelectedObjectEdited(CanvasControl canvasControl_2, DrawObjectsEventArgs drawObjectsEventArgs_0)
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
			if ((int)sender == 0 && this.closeWindow)
			{
				base.Close();
			}
		}

		private void canvasControl_ObjectClicked(CanvasControl canvasControl_2, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
			if (this.treeViewObjects != null)
			{
				if (drawObjectsEventArgs_0.Objects == null || drawObjectsEventArgs_0.Objects.Count == 0)
				{
					this.treeViewObjects.method_3(null);
					return;
				}
				bool flag = false;
				using (List<DrawObjectBase>.Enumerator enumerator = drawObjectsEventArgs_0.Objects.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						DrawObjectBase drawObjectBase_ = enumerator.Current;
						this.treeViewObjects.method_3(drawObjectBase_);
						flag = true;
					}
				}
				if (!flag)
				{
					this.poweringTreeViewPanel.VtnUlqUaJQ(null);
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
				IEnumerable<IDockContent> documents = this.dockPanel1.Documents;
				Func<IDockContent, bool> C9__0=null;
				Func<IDockContent, bool> predicate;
				if ((predicate = C9__0) == null)
				{
					predicate = (C9__0 = ((IDockContent o) => o.GetType() == typeof(Class13) && ((Class13)o).method_3(dob)));
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
				IEnumerable<IDockContent> documents2 = this.dockPanel1.Documents;
				Func<IDockContent, bool> C9__1 = null;
				Func<IDockContent, bool> predicate2;
				if ((predicate2 = C9__1) == null)
				{
					predicate2 = (C9__1 = ((IDockContent o) => o.GetType() == typeof(Class13) && ((Class13)o).method_3(dob)));
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
					this.activeCanvas.Settings.MeasurementYear,
					" and month(m.[DateD]) between 1 and 11)or(year(m.[DateD]) = ",
					this.activeCanvas.Settings.MeasurementYear,
					"-1 and month(m.[DateD])=12) ) and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n\t                                                                                                group by mat.[IdBus], mat.[idObjList], m.[TypeDoc]) as maxI \r\n                                                                                                on mat1.[IdBus]=maxI.[IdBus] and mat1.[idObjList]=maxI.[idObjList] and mat1.Ia = maxI.a and mat1.Ib= maxI.b and mat1.Ic = maxI.c \r\n                                                                                                inner join [tJ_Measurement] as m1 on mat1.[idMeasurement] = m1.id and m1.[TypeDoc]=1192\r\n                                                                                                where mat1.deleted = 0 and ((year(m1.[DateD]) = ",
					this.activeCanvas.Settings.MeasurementYear,
					" and month(m1.[DateD]) between 1 and 11)or(year(m1.[DateD]) = ",
					this.activeCanvas.Settings.MeasurementYear,
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
				TreeNodeObj treeNodeObj = this.activeCanvas.PoweringReportForDrawObject(drawObjectBase, true);
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
					Func<CouplingRelation, bool> C9__1;
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
								if ((predicate = C9__1) == null)
								{
									predicate = (C9__1 = ((CouplingRelation c) => relationsMeasurement.ContainsKey(c)));
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
			}.Show(this.dockPanel1);
		}

		private void method_44(object sender, EventArgs e)
		{
			if ((this.activeCanvas.SelectedObjects.Count<DrawObjectBase>() == 1 && this.activeCanvas.SelectedObjects.First<DrawObjectBase>().GetType() == typeof(ShinaTool)) || this.activeCanvas.SelectedObjects.First<DrawObjectBase>().GetType() == typeof(LineCellTool))
			{
				this.method_43(new List<DrawObjectBase>
				{
					this.activeCanvas.SelectedObjects.First<DrawObjectBase>()
				});
			}
		}

		private void canvasControl_HideContextMenuCanvasEvent(ContextMenuStrip contextMenuStrip_1, List<object> list_3)
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
				using (IEnumerator<IDockContent> enumerator = this.dockPanel1.Documents.GetEnumerator())
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
				}.Show(this.dockPanel1);
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
			this.activeCanvas.ZoomInSymbols();
		}

		private void toolStripButton_25_Click(object sender, EventArgs e)
		{
			this.activeCanvas.ZoomOutSymbols();
		}

		private void toolStripButton_22_Click(object sender, EventArgs e)
		{
			this.activeCanvas.ZoomIn();
		}

		private void toolStripButton_23_Click(object sender, EventArgs e)
		{
			this.activeCanvas.ZoomOut();
		}

		private void uhjImiftgM(object sender, EventArgs e)
		{
			this.canvasScheme.ClearFlashingObjects();
			this.canvasScheme.DoInvalidate(true);
		}

		private void toolStripComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.dockPanel1.ActiveDocument.GetType() == typeof(DockContentBase) && ((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
			{
				switch (((ToolStripComboBox)sender).SelectedIndex)
				{
				case 0:
				{
					this.activeCanvas.Mode = eCanvasEditingMode.ReadOnly;
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
					this.activeCanvas.Mode = eCanvasEditingMode.Dispatcher;
					if (this.activeCanvas.Mode != eCanvasEditingMode.Dispatcher)
					{
						eCanvasEditingMode mode = this.activeCanvas.Mode;
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
					if (this.activeCanvas.Mode != eCanvasEditingMode.Edit)
					{
						this.activeCanvas.Mode = eCanvasEditingMode.Edit;
						if (this.activeCanvas.Mode != eCanvasEditingMode.Edit)
						{
							eCanvasEditingMode mode = this.activeCanvas.Mode;
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
							if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain && MessageBox.Show("Перед началом редактирования рекомендуется перезагрузить схему. Перезагрузить схему?", "Перезагрузка схемы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
							{
								this.toolStripButton_14_Click(sender, e);
							}
							this.method_52();
							if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
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
				this.activeCanvas.Focus();
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
			if (saveFileDialog.ShowDialog() == DialogResult.OK && this.activeCanvas != null)
			{
				this.activeCanvas.ExportToDXF(saveFileDialog.FileName);
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
				this.formCanvasMessage.method_6(canvasMessageEventArgs_0.MessageText, (int)canvasMessageEventArgs_0.MessageType, canvasMessageEventArgs_0);
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
			this.formOPCMessage.Close();
		}

		private void toolStripButton_6_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_6.Checked)
			{
				this.method_37();
				return;
			}
			this.formCanvasMessage.Close();
		}

		private void toolStripButton_7_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_7.Checked)
			{
				this.method_32();
				return;
			}
			this.poweringTreeViewPanel.Close();
		}

		private void toolStripButton_10_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_10.Checked)
			{
				this.method_33();
				return;
			}
			this.formDockStates.Close();
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
			if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeMain)
			{
				num = this.int_2;
			}
			if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeSecond && this.dictionary_2.ContainsKey((DockContentBase)this.dockPanel1.ActiveDocument))
			{
				num = this.dictionary_2[(DockContentBase)this.dockPanel1.ActiveDocument];
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
						this.activeCanvas.Mode.ToString(),
						"\n"
					});
					@class.tLogInOut.Rows[0].EndEdit();
					base.UpdateSqlData(@class, @class.tLogInOut);
				}
			}
		}

		private void dockPanel_0_ActiveDocumentChanged(object sender, EventArgs e)
		{
			if (this.dockPanel1.ActiveDocument != null)
			{
				if (this.dockPanel1.ActiveDocument.GetType() == typeof(DockContentBase) && ((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
				{
					this.activeCanvas = (CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0];
					if (this.activeCanvas.Layers.Count<ICanvasLayer>() > 0)
					{
						this.method_21();
					}
					switch (this.activeCanvas.TypeCanvas)
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
					switch (this.activeCanvas.Mode)
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
					this.activeCanvas.LineInformationVisible = this.LineInformationVisible;
					this.activeCanvas.TelemetryLabelVisible = this.TelemetryLabelVisible;
					base.SetControlsPropertiesUser();
					switch (this.activeCanvas.TypeCanvas)
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
					this.activeCanvas.DoInvalidate(true);
					this.toolStrip_3.Visible = true;
					this.toolStrip_2.Visible = true;
					this.toolStrip_5.Visible = true;
					this.toolStripTools.Visible = true;
					this.toolStrip_0.Visible = true;
					this.toolStrip_4.Visible = true;
					return;
				}
				this.toolStrip_3.Visible = false;
				this.toolStrip_2.Visible = false;
				this.toolStrip_5.Visible = false;
				this.toolStripTools.Visible = false;
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
			canvasControl.HideContextMenuCanvasEvent += this.canvasControl_HideContextMenuCanvasEvent;
			canvasControl.ObjectsAdded += this.canvasScheme_ObjectsAdded;
			canvasControl.ObjectClicked += this.canvasControl_ObjectClicked;
			canvasControl.FlashObjectsAdded += this.canvasControl_FlashObjectsAdded;
			canvasControl.FlashObjectsRemoved += this.canvasControl_FlashObjectsRemoved;
			canvasControl.ContextMenuRectangle = this.contextMenuStrip_0;
			canvasControl.TypeCanvas = eTypeCanvas.SchemaClone;
			DrawingLayer layer = new DrawingLayer();
			canvasControl.AddLayer(layer);
			return dockContentBase;
		}

		private void toolStripButton_35_Click(object sender, EventArgs e)
		{
			if ((DockContentBase)this.dockPanel1.ActiveDocument != null && ((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl) && this.dockPanel1.ActiveDocument != null && ((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]).Layers.Count<ICanvasLayer>() > 0 && ((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]).SelectedCount > 0)
			{
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				list.AddRange(((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]).SelectedObjects);
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
				dockContentBase.Show(this.dockPanel1);
			}
		}

		private void toolStripButton_38_Click(object sender, EventArgs e)
		{
			if (((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]).SelectedObjects.Count<DrawObjectBase>() < 2)
			{
				return;
			}
			GroupDrawObjectBase groupDrawObjectBase = new GroupDrawObjectBase();
			foreach (DrawObjectBase item in ((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]).SelectedObjects)
			{
				groupDrawObjectBase.Add(item);
			}
			new GroupPropertyForm(groupDrawObjectBase).ShowDialog();
		}

		private void toolStripButton_39_Click(object sender, EventArgs e)
		{
			IEnumerable<DrawObjectBase> selectedObjects = ((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]).SelectedObjects;
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
			if (this.activeCanvas != null)
			{
				this.activeCanvas.ShowFormAbnFromOldSchema(dob, Convert.ToInt32(((ToolStripMenuItem)sender).Tag) == 1);
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
			if (this.canvasScheme.Mode == eCanvasEditingMode.Edit && this.activeCanvas.SelectedCount > 0)
			{
				this.activeCanvas.RemoveSelectedObjects();
				this.activeCanvas.CommandEscape();
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
			if (this.activeCanvas != null)
			{
				this.activeCanvas.ShowFormSchmObjFile(obj);
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
			if (!this.objSchemeDictionary.ContainsKey(rectangleTool))
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
				dockContentBase.ShowForm += this.ShowFormBase;
				dockContentBase.Show(this.dockPanel1);
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
			if (((DockContentBase)sender).Controls.Count > 0 && ((DockContentBase)sender).Controls[0] is CanvasControl && (((CanvasControl)((DockContentBase)sender).Controls[0]).WorkerCounter > 0 || this.isLoadScheme))
			{
				e.Cancel = true;
			}
		}

		private void pYnMneGkhg_Click(object sender, EventArgs e)
		{
			if (this.contextMenuStrip_0.Tag != null)
			{
				RectangleTool rectangleTool = (RectangleTool)this.contextMenuStrip_0.Tag;
				new FormDockPassport(this.SqlSettings, rectangleTool.IdBase).Show(this.dockPanel1);
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
			if (this.dockPanel1.ActiveDocument.GetType() == typeof(DockContentBase) && ((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
			{
				((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]).ClearBookmarks();
			}
		}

		private void toolStripButton_31_Click(object sender, EventArgs e)
		{
			if (this.dockPanel1.ActiveDocument.GetType() == typeof(DockContentBase) && ((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
			{
				((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]).NextBookmark();
			}
		}

		private void toolStripButton_29_Click(object sender, EventArgs e)
		{
			if (this.dockPanel1.ActiveDocument.GetType() == typeof(DockContentBase) && ((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
			{
				((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]).PrevBookmark();
			}
		}

		private void toolStripButton_30_Click(object sender, EventArgs e)
		{
			if (this.dockPanel1.ActiveDocument.GetType() == typeof(DockContentBase) && ((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0].GetType() == typeof(CanvasControl))
			{
				((CanvasControl)((DockContentBase)this.dockPanel1.ActiveDocument).Controls[0]).CurrentBookmark();
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
						dockContentBase.ShowForm += this.ShowFormBase;
						dockContentBase.Show(this.dockPanel1);
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
				return this.activeCanvas;
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
				this.activeCanvas.LineInformationVisible = value;
				this.activeCanvas.DoInvalidate(true);
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
				this.activeCanvas.TelemetryLabelVisible = value;
				this.activeCanvas.DoInvalidate(true);
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
				this.activeCanvas.MeasurementLabelVisible = value;
				this.activeCanvas.DoInvalidate(true);
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
			if (this.activeCanvas != null)
			{
				switch (this.toolStripComboBox_2.SelectedIndex)
				{
				case -1:
					return;
				case 0:
				case 1:
					this.activeCanvas.Settings.MeasurementYear = this.toolStripComboBox_2.SelectedIndex;
					this.activeCanvas.UpdateMeasurementForBus();
					this.activeCanvas.DoInvalidate(true);
					return;
				default:
					this.activeCanvas.Settings.MeasurementYear = Convert.ToInt32(this.toolStripComboBox_2.SelectedItem);
					this.activeCanvas.UpdateMeasurementForBus();
					this.activeCanvas.DoInvalidate(true);
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
			this.activeCanvas.UpdateAllTelemetryLabels();
		}

		private void toolStripButton_41_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_41.Checked)
			{
				if (this.activeCanvas.CanvasCommandType != eCommandType.frame || this.activeCanvas.CanvasCommandType != eCommandType.drawframe)
				{
					this.activeCanvas.CommandDrawFrame();
					return;
				}
			}
			else if (this.activeCanvas.CanvasCommandType == eCommandType.frame || this.activeCanvas.CanvasCommandType == eCommandType.drawframe)
			{
				this.activeCanvas.CommandEscape();
			}
		}

		private void toolStripButton_42_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeSecond)
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
				sqlDataCommand.SelectSqlData(@class.tSchm_CheckSecondLevel, false, "where idObj = " + this.activeCanvas.IdRect, null, false, 0);
				SqlConnection sqlConnection = new SqlConnection(SqlDataConnect.GetConnectionString(this.SqlSettings));
				string cmdText = "select IDUser from tuser where login = SYSTEM_USER";
				sqlConnection.Open();
				int num = Convert.ToInt32(new SqlCommand(cmdText, sqlConnection).ExecuteScalar());
				sqlConnection.Close();
				if (@class.tSchm_CheckSecondLevel.Rows.Count == 0)
				{
					DataRow dataRow = @class.tSchm_CheckSecondLevel.NewRow();
					dataRow["idObj"] = this.activeCanvas.IdRect;
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
				this.poweringTreeViewPanel.method_11();
			}
		}

		private void toolStripButton_43_Click(object sender, EventArgs e)
		{
			if (this.activeCanvas.TypeCanvas == eTypeCanvas.SchemeSecond)
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
				sqlDataCommand.SelectSqlData(@class.tSchm_CheckSecondLevel, false, "where idObj = " + this.activeCanvas.IdRect, null, false, 0);
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
				this.poweringTreeViewPanel.method_11();
			}
		}

		private void toolStripButton_49_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_49.Checked)
			{
				if (this.activeCanvas.SimulationMode != eSimulationMode.Training)
				{
					this.activeCanvas.SimulationMode = eSimulationMode.Training;
					DialogResult dialogResult = MessageBox.Show("Загрузить?(Нет - начать новую)", "Режим тренажёра");
					if (dialogResult != DialogResult.Yes && dialogResult != DialogResult.No)
					{
						this.toolStripButton_49.Checked = false;
						return;
					}
				}
			}
			else if (this.activeCanvas.SimulationMode == eSimulationMode.Training)
			{
				this.activeCanvas.SimulationMode = eSimulationMode.Online;
				this.toolStripButton_14_Click(sender, e);
			}
		}

		public override void GetNetworkMessage(object sender, SendCommandEventArgs e)
		{
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



	}
}
