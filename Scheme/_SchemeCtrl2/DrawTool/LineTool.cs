using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using DataSql;
using DXFLibrary;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.Data;
using SchemeCtrl2.DrawTool.FormsObj;
using SchemeCtrl2.Layers;
using SchemeCtrl2.SnapPoint;

namespace SchemeCtrl2.DrawTool
{
	public class LineTool : DrawObjectBase
	{
		public event LineToolEventHandler StateAdded
		{
			add
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_0;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Combine(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_0, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
			remove
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_0;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Remove(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_0, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
		}

		public event LineToolEventHandler StateRemoved
		{
			add
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_1;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Combine(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_1, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
			remove
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_1;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Remove(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_1, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
		}

		public event LineToolEventHandler AmperageAdded
		{
			add
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_2;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Combine(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_2, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
			remove
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_2;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Remove(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_2, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
		}

		public event LineToolEventHandler AmperageRemoved
		{
			add
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_3;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Combine(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_3, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
			remove
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_3;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Remove(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_3, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
		}

		public event LineToolEventHandler ConnectionWithObject
		{
			add
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_4;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Combine(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_4, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
			remove
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_4;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Remove(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_4, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
		}

		public LineTool()
		{
			this.StateAdded += this.LineTool_StateAdded;
			this.StateRemoved += this.LineTool_StateRemoved;
		}

		public LineTool(DataRow dataRow_0, DrawingLayer layer) : base(dataRow_0)
		{
			this.bool_0 = true;
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)dataRow_0["SchemaXml"]);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/Obj");
			int idBase = this.IdBase;
			layer.AddObject(this);
			XmlAttribute xmlAttribute = xmlNode.Attributes["textVis"];
			if (xmlAttribute != null)
			{
				this.TextProperty.Visible = Convert.ToBoolean(xmlAttribute.Value);
				xmlAttribute = xmlNode.Attributes["textPos"];
				if (xmlAttribute != null)
				{
					this.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
				}
			}
			xmlAttribute = xmlNode.Attributes["limEd"];
			if (xmlAttribute != null)
			{
				this.LimitedEditing = Convert.ToBoolean(xmlAttribute.Value);
			}
			XmlNode xmlNode2 = xmlNode.SelectSingleNode("Points");
			List<PointTool> list = new List<PointTool>();
			foreach (object obj in xmlNode2.ChildNodes)
			{
				XmlNode xmlNode3 = (XmlNode)obj;
				xmlAttribute = xmlNode3.Attributes["ID"];
				if (xmlAttribute != null)
				{
					int num = Convert.ToInt32(xmlAttribute.Value);
					if (layer.Parent.loadedPoints.ContainsKey(num))
					{
						list.Add(layer.Parent.loadedPoints[num]);
					}
					else
					{
						Func<DrawObjectBase, bool> func = null;
						LineTool.Class77 @class = new LineTool.Class77();
						bool flag = false;
						@class.dataRow_0 = layer.Parent.dataSetScheme_0.vSchm_ObjListXml.Select(string.Concat(new object[]
						{
							"Id = ",
							num,
							" and typeSChema = ",
							((int)layer.Parent.TypeCanvas).ToString()
						}));
						if (@class.dataRow_0.Length == 0)
						{
							@class.dataRow_0 = layer.Parent.dataSetScheme_0.vSchm_ObjListXml.Select("Id = " + num);
							flag = true;
						}
						if (@class.dataRow_0.Length == 0)
						{
							PointTool pointTool = new PointTool();
							pointTool.IdBase = num;
							pointTool.Layer = layer;
							pointTool.NeedToPreserve = NeedToPreserveEnum.InsertXML;
							layer.Parent.loadedPoints.Add(pointTool.IdBase, pointTool);
							list.Add(pointTool);
						}
						else
						{
							int num2 = (int)@class.dataRow_0[0]["TypeCodeId"];
							PointTool pointTool2;
							if (num2 != 111)
							{
								if (num2 != 556)
								{
									continue;
								}
								pointTool2 = new TransformerPointTool(@class.dataRow_0[0]);
							}
							else
							{
								pointTool2 = new PointTool(@class.dataRow_0[0]);
							}
							if (flag)
							{
								pointTool2.NeedToPreserve = NeedToPreserveEnum.InsertXML;
							}
							if (layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond && @class.dataRow_0[0]["idParent"] != DBNull.Value)
							{
								IEnumerable<DrawObjectBase> objects = layer.Objects;
								if (func == null)
								{
									func = new Func<DrawObjectBase, bool>(@class.method_0);
								}
								IEnumerable<DrawObjectBase> source = objects.Where(func);
								if (source.Count<DrawObjectBase>() > 0)
								{
									pointTool2.Parent = source.First<DrawObjectBase>();
								}
							}
							pointTool2.Layer = layer;
							layer.Parent.loadedPoints.Add(pointTool2.IdBase, pointTool2);
							list.Add(pointTool2);
						}
					}
				}
				else
				{
					PointTool pointTool3 = new PointTool(new UnitPoint((double)Convert.ToSingle(xmlNode3.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode3.Attributes[1].Value, new CultureInfo(1033))));
					xmlAttribute = (XmlAttribute)xmlNode3.Attributes.GetNamedItem("text");
					if (xmlAttribute != null)
					{
						pointTool3.Text = xmlAttribute.Value;
						xmlAttribute = (XmlAttribute)xmlNode3.Attributes.GetNamedItem("textVis");
						if (xmlAttribute != null)
						{
							pointTool3.TextProperty.Visible = Convert.ToBoolean(xmlAttribute.Value);
						}
						xmlAttribute = (XmlAttribute)xmlNode3.Attributes.GetNamedItem("textPos");
						if (xmlAttribute != null)
						{
							pointTool3.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
						}
						xmlAttribute = (XmlAttribute)xmlNode3.Attributes.GetNamedItem("FontColor");
						if (xmlAttribute != null)
						{
							pointTool3.UseSettingsText = false;
							pointTool3.TextProperty.Color = Color.FromArgb(Convert.ToInt32(xmlAttribute.Value));
						}
					}
					else
					{
						pointTool3.Text = null;
						pointTool3.TextProperty.Visible = false;
					}
					pointTool3.Layer = layer;
					list.Add(pointTool3);
				}
			}
			DataRow[] array = layer.Parent.dataSetScheme_0.tSchm_Relation.Select("Edge = " + this.IdBase.ToString());
			List<CouplingRelation> list2 = new List<CouplingRelation>();
			foreach (DataRow dataRow in array)
			{
				if (!layer.Parent.loadedPoints.ContainsKey((int)dataRow["SourceObj"]))
				{
					DataRow[] array3 = layer.Parent.dataSetScheme_0.vSchm_ObjListXml.Select("Id = " + Convert.ToInt32(dataRow["SourceObj"]));
					if (array3.Length > 0)
					{
						xmlDocument.LoadXml((string)array3[0]["SchemaXml"]);
						XmlNode xmlNode4 = xmlDocument.SelectSingleNode("/Obj");
						PointTool pointTool4 = new PointTool(new UnitPoint((double)Convert.ToSingle(xmlNode4.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode4.Attributes[1].Value, new CultureInfo(1033))));
						pointTool4.IdBase = Convert.ToInt32(array3[0]["id"]);
						pointTool4.Layer = layer;
						layer.Parent.loadedPoints.Add(pointTool4.IdBase, pointTool4);
					}
					else
					{
						PointTool pointTool5 = new PointTool();
						pointTool5.IdBase = (int)dataRow["SourceObj"];
						pointTool5.Layer = layer;
						pointTool5.NeedToPreserve = NeedToPreserveEnum.InsertXML;
						layer.Parent.loadedPoints.Add(pointTool5.IdBase, pointTool5);
					}
				}
				if (!layer.Parent.loadedPoints.ContainsKey((int)dataRow["DestObj"]))
				{
					DataRow[] array4 = layer.Parent.dataSetScheme_0.vSchm_ObjListXml.Select("Id = " + Convert.ToInt32(dataRow["DestObj"]));
					if (array4.Length > 0)
					{
						xmlDocument.LoadXml((string)array4[0]["SchemaXml"]);
						XmlNode xmlNode5 = xmlDocument.SelectSingleNode("/Obj");
						PointTool pointTool6 = new PointTool(new UnitPoint((double)Convert.ToSingle(xmlNode5.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode5.Attributes[1].Value, new CultureInfo(1033))));
						pointTool6.IdBase = Convert.ToInt32(array4[0]["id"]);
						pointTool6.Layer = layer;
						layer.Parent.loadedPoints.Add(pointTool6.IdBase, pointTool6);
					}
					else
					{
						PointTool pointTool7 = new PointTool();
						pointTool7.IdBase = (int)dataRow["DestObj"];
						pointTool7.Layer = layer;
						pointTool7.NeedToPreserve = NeedToPreserveEnum.InsertXML;
						layer.Parent.loadedPoints.Add(pointTool7.IdBase, pointTool7);
					}
				}
				CouplingRelation couplingRelation = new CouplingRelation(layer.Parent.loadedPoints[(int)dataRow["SourceObj"]], layer.Parent.loadedPoints[(int)dataRow["DestObj"]]);
				if (!list.Contains(couplingRelation.Vertex1) || !list.Contains(couplingRelation.Vertex2))
				{
					list2.Add(couplingRelation);
				}
				couplingRelation.Id = (int)dataRow["id"];
				couplingRelation.Line = this;
				this.CouplingRelations.Add(couplingRelation);
			}
			XmlNodeList xmlNodeList = xmlNode.SelectNodes("Branch");
			foreach (object obj2 in xmlNodeList)
			{
				XmlNode xmlNode6 = (XmlNode)obj2;
				Func<CouplingRelation, bool> func2 = null;
				LineTool.Class78 class2 = new LineTool.Class78();
				if (xmlNode6.Attributes.Count < 4)
				{
					layer.Parent.SendMessage(this, "Ошибка во время загрузки ветки (" + this.IdBase.ToString() + ": неверные атрибуты)", eMessageType.Error);
				}
				else
				{
					CouplingRelation couplingRelation2 = null;
					class2.pointTool_0 = list[Convert.ToInt32(xmlNode6.Attributes[1].Value)];
					class2.pointTool_1 = list[Convert.ToInt32(xmlNode6.Attributes[2].Value)];
					foreach (CouplingRelation couplingRelation3 in this.CouplingRelations)
					{
						if (couplingRelation3.Id == Convert.ToInt32(xmlNode6.Attributes[3].Value))
						{
							couplingRelation2 = couplingRelation3;
							break;
						}
					}
					if (couplingRelation2 == null || (!list.Contains(couplingRelation2.Vertex1) && !list.Contains(couplingRelation2.Vertex2)))
					{
						IEnumerable<CouplingRelation> source2 = list2;
						if (func2 == null)
						{
							func2 = new Func<CouplingRelation, bool>(class2.method_0);
						}
						IEnumerable<CouplingRelation> source3 = source2.Where(func2);
						if (source3.Count<CouplingRelation>() == 0)
						{
							layer.Parent.SendMessage(this, "Ошибка во время загрузки ветки (" + this.IdBase.ToString() + ": не найдена подходящая связь)", eMessageType.Error);
							continue;
						}
						if (source3.Count<CouplingRelation>() == 1)
						{
							couplingRelation2 = source3.First<CouplingRelation>();
						}
						if (couplingRelation2 == null || (!list.Contains(couplingRelation2.Vertex1) && !list.Contains(couplingRelation2.Vertex2)))
						{
							layer.Parent.SendMessage(this, "Ошибка во время загрузки ветки (" + this.IdBase.ToString() + ": не найдена связь или её точки)", eMessageType.Error);
							continue;
						}
					}
					if (Convert.ToInt32(xmlNode6.Attributes[1].Value) != -1 && Convert.ToInt32(xmlNode6.Attributes[2].Value) != -1)
					{
						if (list2.Contains(couplingRelation2))
						{
							if (class2.pointTool_0.IdBase != 0 && class2.pointTool_0 != couplingRelation2.Vertex1 && class2.pointTool_0 != couplingRelation2.Vertex2)
							{
								if (!list.Contains(couplingRelation2.Vertex1))
								{
									class2.pointTool_0 = couplingRelation2.Vertex1;
								}
								else if (!list.Contains(couplingRelation2.Vertex2))
								{
									class2.pointTool_0 = couplingRelation2.Vertex2;
								}
							}
							if (class2.pointTool_1.IdBase != 0 && class2.pointTool_1 != couplingRelation2.Vertex1 && class2.pointTool_1 != couplingRelation2.Vertex2)
							{
								if (!list.Contains(couplingRelation2.Vertex1))
								{
									class2.pointTool_1 = couplingRelation2.Vertex1;
								}
								else if (!list.Contains(couplingRelation2.Vertex2))
								{
									class2.pointTool_1 = couplingRelation2.Vertex2;
								}
							}
						}
						Branch branch = new Branch(this, class2.pointTool_0, class2.pointTool_1, (BranchType)Convert.ToInt32(xmlNode6.Attributes[0].Value), couplingRelation2);
						XmlNodeList xmlNodeList2 = xmlNode6.SelectNodes("objOnLine");
						foreach (object obj3 in xmlNodeList2)
						{
							XmlNode xmlNode7 = (XmlNode)obj3;
							DataRow[] array5 = layer.Parent.dataSetScheme_0.vSchm_ObjListXml.Select(string.Concat(new object[]
							{
								"Id = ",
								Convert.ToInt32(xmlNode7.Attributes[0].Value),
								" and IdParent = ",
								couplingRelation2.Id
							}));
							if (array5.Length != 0)
							{
								TypeSwitch typeSwitch = (TypeSwitch)Convert.ToInt32(array5[0]["TypeCodeId"]);
								ObjectOnLine objectOnLine = branch.AddSwitchTool(typeSwitch, array5[0]);
								objectOnLine.LimitedEditing = this.LimitedEditing;
								if (objectOnLine.LimitedEditing && array5.Length == 1 && Convert.ToInt32(array5[0]["TypeSchema"]) == 2)
								{
									this.LimitedEditing = false;
								}
								layer.AddObject(objectOnLine);
								if (array5[0]["idGroup"] != DBNull.Value)
								{
									int key = Convert.ToInt32(array5[0]["idGroup"]);
									if (layer.Parent.dictionary_0.ContainsKey(key))
									{
										layer.Parent.dictionary_0[key].Add(objectOnLine);
									}
								}
							}
						}
						xmlNodeList2 = xmlNode6.SelectNodes("state");
						foreach (object obj4 in xmlNodeList2)
						{
							XmlNode stateNode = (XmlNode)obj4;
							LineToolState state = new LineToolState(branch, stateNode);
							this.AddState(state);
						}
						xmlNodeList2 = xmlNode6.SelectNodes("textBranch");
						foreach (object obj5 in xmlNodeList2)
						{
							XmlNode xmlNode8 = (XmlNode)obj5;
							TextBranchTool textBranchTool = new TextBranchTool();
							textBranchTool.Delta = Convert.ToSingle(xmlNode8.Attributes[0].Value, new CultureInfo(1033));
							if (float.IsNaN(textBranchTool.Delta))
							{
								textBranchTool.Delta = 0.5f;
							}
							textBranchTool.Direct = Convert.ToBoolean(xmlNode8.Attributes[1].Value);
							textBranchTool.Text = xmlNode8.Attributes[2].Value;
							textBranchTool.Type = (eTextBranchType)Convert.ToInt32(xmlNode8.Attributes[3].Value);
							if (xmlNode8.Attributes.Count > 4)
							{
								textBranchTool.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode8.Attributes[4].Value);
								if (xmlNode8.Attributes.Count > 5)
								{
									if (xmlNode8.Attributes["Passport"] != null)
									{
										textBranchTool.Passport = Convert.ToBoolean(xmlNode8.Attributes["Passport"].Value);
									}
									else
									{
										textBranchTool.Passport = (Convert.ToBoolean(xmlNode8.Attributes[6].Value) || Convert.ToBoolean(xmlNode8.Attributes[7].Value) || Convert.ToBoolean(xmlNode8.Attributes[8].Value) || Convert.ToBoolean(xmlNode8.Attributes[9].Value));
									}
								}
							}
							xmlAttribute = (XmlAttribute)xmlNode8.Attributes.GetNamedItem("Color");
							if (xmlAttribute != null)
							{
								textBranchTool.UseSettingColor = false;
								textBranchTool.Color = Color.FromArgb(Convert.ToInt32(xmlAttribute.Value));
							}
							else
							{
								textBranchTool.UseSettingColor = true;
							}
							xmlAttribute = (XmlAttribute)xmlNode8.Attributes.GetNamedItem("FontName");
							if (xmlAttribute != null)
							{
								textBranchTool.UseSettingsText = false;
								textBranchTool.TextProperty.FontName = xmlAttribute.Value;
								xmlAttribute = (XmlAttribute)xmlNode8.Attributes.GetNamedItem("FontSize");
								if (xmlAttribute != null)
								{
									textBranchTool.TextProperty.FontSize = Convert.ToSingle(xmlAttribute.Value, new CultureInfo(1033));
								}
								xmlAttribute = (XmlAttribute)xmlNode8.Attributes.GetNamedItem("FontBold");
								if (xmlAttribute != null)
								{
									textBranchTool.TextProperty.FontBold = Convert.ToBoolean(xmlAttribute.Value);
								}
								xmlAttribute = (XmlAttribute)xmlNode8.Attributes.GetNamedItem("FontItalic");
								if (xmlAttribute != null)
								{
									textBranchTool.TextProperty.FontItalic = Convert.ToBoolean(xmlAttribute.Value);
								}
								xmlAttribute = (XmlAttribute)xmlNode8.Attributes.GetNamedItem("FontUnderline");
								if (xmlAttribute != null)
								{
									textBranchTool.TextProperty.FontUnderline = Convert.ToBoolean(xmlAttribute.Value);
								}
								xmlAttribute = (XmlAttribute)xmlNode8.Attributes.GetNamedItem("FontColor");
								if (xmlAttribute != null)
								{
									textBranchTool.TextProperty.Color = Color.FromArgb(Convert.ToInt32(xmlAttribute.Value));
								}
							}
							else
							{
								textBranchTool.UseSettingsText = true;
							}
							textBranchTool.Parent = branch;
							this.Layer.AddObject(textBranchTool);
						}
						this.branches.Add(branch);
						branch.Parent = this;
					}
				}
			}
			this.GetPointsList();
			this.StateAdded += this.LineTool_StateAdded;
			this.StateRemoved += this.LineTool_StateRemoved;
			this.bool_0 = false;
		}

		private void LineTool_StateRemoved(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
			DrawObjectBase master = this.Master;
		}

		private void LineTool_StateAdded(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
			DrawObjectBase master = this.Master;
		}

		public string ErrorString
		{
			get
			{
				return this.string_0;
			}
		}

		public override bool Flashing
		{
			get
			{
				return base.Flashing;
			}
			set
			{
				base.Flashing = value;
				foreach (Branch branch in this.branches)
				{
					branch.Flashing = value;
				}
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
				if (base.Master != null)
				{
					((LineTool)base.Master).AmperageAdded -= this.LineTool_AmperageAdded;
					((LineTool)base.Master).AmperageRemoved -= this.LineTool_AmperageRemoved;
					foreach (Amperage amperage in this.Amperages.Values)
					{
						amperage.KillNextAmperage();
						this.RemoveAmperage(amperage);
					}
				}
				base.Master = value;
				if (base.Master != null)
				{
					((LineTool)base.Master).AmperageAdded += this.LineTool_AmperageAdded;
					((LineTool)base.Master).AmperageRemoved += this.LineTool_AmperageRemoved;
					foreach (PointTool pointTool in ((LineTool)base.Master).Amperages.Keys)
					{
						foreach (CouplingRelation couplingRelation in this.couplingRelations)
						{
							PointTool amperagePoint;
							if (couplingRelation.Vertex1.IdBase == pointTool.IdBase)
							{
								amperagePoint = couplingRelation.Vertex1;
							}
							else
							{
								if (couplingRelation.Vertex2.IdBase != pointTool.IdBase)
								{
									continue;
								}
								amperagePoint = couplingRelation.Vertex2;
							}
							this.AddAmperage(amperagePoint, new Amperage(((LineTool)base.Master).Amperages[pointTool].Source, this, ((LineTool)base.Master).Amperages[pointTool].amperageProperties, ((LineTool)base.Master).Amperages[pointTool].Mediators.First<Amperage>()));
						}
					}
				}
			}
		}

		public CouplingRealationsList CouplingRelations
		{
			get
			{
				return this.couplingRelations;
			}
		}

		public Dictionary<PointTool, Amperage> AmperagesProp
		{
			get
			{
				return this.Amperages;
			}
		}

		public IEnumerable<PointTool> Ends
		{
			get
			{
				return this.ends;
			}
		}

		public override int NodeCount
		{
			get
			{
				return this.pointToolList.Count;
			}
		}

		public List<Branch> Branches
		{
			get
			{
				return this.branches;
			}
		}

		public Branch SelectedBranch
		{
			get
			{
				return this.selectedBranch;
			}
		}

		public UnitPoint ClickedPoint
		{
			get
			{
				return this.clickedPoint;
			}
		}

		public PointTool SelectedPoint
		{
			get
			{
				return this.selectedPoint;
			}
		}

		public virtual LineToolType Type
		{
			get
			{
				if (this.branches.Count != 0)
				{
					BranchType type = this.branches[0].Type;
					foreach (Branch branch in this.branches)
					{
						if (type != branch.Type)
						{
							return LineToolType.MixedLine;
						}
					}
					switch (type)
					{
					case BranchType.AirLine:
						return LineToolType.AirLine;
					case BranchType.CabelLine:
						return LineToolType.CabelLine;
					case BranchType.AirLineProtected:
						return LineToolType.AirLineProtected;
					default:
						return LineToolType.CabelLine;
					}
					LineToolType result;
					return result;
				}
				return LineToolType.MixedLine;
			}
			set
			{
				if (value != LineToolType.MixedLine)
				{
					BranchType type;
					switch (value)
					{
					case LineToolType.CabelLine:
						type = BranchType.CabelLine;
						break;
					case LineToolType.AirLine:
						type = BranchType.AirLine;
						break;
					default:
						if (value != LineToolType.AirLineProtected)
						{
							type = BranchType.CabelLine;
						}
						else
						{
							type = BranchType.AirLineProtected;
						}
						break;
					}
					foreach (Branch branch in this.branches)
					{
						branch.Type = type;
					}
				}
			}
		}

		public IEnumerable<LineToolState> States
		{
			get
			{
				return this.states;
			}
		}

		public int CountStates
		{
			get
			{
				return this.states.Count;
			}
		}

		public Color ColorOff
		{
			get
			{
				if (this.Layer != null && base.UseSettingColor)
				{
					eTypeShinaTool typeParentShina = this.GetTypeParentShina(new List<LineTool>());
					switch (typeParentShina)
					{
					case eTypeShinaTool.Shina_04:
						if (base.GetType() != typeof(LineCellTool))
						{
							if (base.GetType() != typeof(Class74))
							{
								if (base.GetType() == typeof(LineTool))
								{
									return this.Layer.Parent.Settings.Line04ColorOff;
								}
								return this.color_0;
							}
						}
						return this.Layer.Parent.Settings.Cell04ColorOff;
					case eTypeShinaTool.Shina_6:
						if (base.GetType() != typeof(LineCellTool))
						{
							if (base.GetType() != typeof(Class74))
							{
								if (base.GetType() == typeof(LineTool))
								{
									return this.Layer.Parent.Settings.Line6ColorOff;
								}
								return this.color_0;
							}
						}
						return this.Layer.Parent.Settings.Cell6ColorOff;
					default:
						switch (typeParentShina)
						{
						case eTypeShinaTool.Shina_023:
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class74))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Line023ColorOff;
									}
									return this.color_0;
								}
							}
							return this.Layer.Parent.Settings.Cell023ColorOff;
						case eTypeShinaTool.Shina_10:
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class74))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Line10ColorOff;
									}
									return this.color_0;
								}
							}
							return this.Layer.Parent.Settings.Cell10ColorOff;
						}
						break;
					}
				}
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
			}
		}

		public override Color Color
		{
			get
			{
				if (this.Layer != null && base.UseSettingColor)
				{
					eTypeShinaTool typeParentShina = this.GetTypeParentShina(new List<LineTool>());
					switch (typeParentShina)
					{
					case eTypeShinaTool.Shina_04:
						if (base.GetType() != typeof(LineCellTool))
						{
							if (base.GetType() != typeof(Class74))
							{
								if (base.GetType() == typeof(LineTool))
								{
									return this.Layer.Parent.Settings.Line04Color;
								}
								return base.Color;
							}
						}
						return this.Layer.Parent.Settings.Cell04Color;
					case eTypeShinaTool.Shina_6:
						if (base.GetType() != typeof(LineCellTool))
						{
							if (base.GetType() != typeof(Class74))
							{
								if (base.GetType() == typeof(LineTool))
								{
									return this.Layer.Parent.Settings.Line6Color;
								}
								return base.Color;
							}
						}
						return this.Layer.Parent.Settings.Cell6Color;
					default:
						switch (typeParentShina)
						{
						case eTypeShinaTool.Shina_023:
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class74))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Line023Color;
									}
									return base.Color;
								}
							}
							return this.Layer.Parent.Settings.Cell023Color;
						case eTypeShinaTool.Shina_10:
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class74))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Line10Color;
									}
									return base.Color;
								}
							}
							return this.Layer.Parent.Settings.Cell10Color;
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

		public virtual eTypeShinaTool GetTypeParentShina(List<LineTool> lines)
		{
			Func<Branch, bool> func = null;
			if (base.GetType() != typeof(LineCellTool))
			{
				if (base.GetType() != typeof(Class74))
				{
					if (base.GetType() == typeof(LineTool))
					{
						foreach (PointTool pointTool in this.Ends)
						{
							if (pointTool.Parent != null && pointTool.Parent.GetType() == typeof(LineCellTool) && !((LineCellTool)pointTool.Parent).IsTransformer)
							{
								foreach (PointTool pointTool2 in ((LineCellTool)pointTool.Parent).Ends)
								{
									if (pointTool2.Parent != null && pointTool2.Parent is ShinaTool)
									{
										return ((ShinaTool)pointTool2.Parent).TypeShinaTool;
									}
								}
								return eTypeShinaTool.None;
							}
						}
						lines.Add(this);
						foreach (PointTool pointTool3 in this.Ends)
						{
							IEnumerable<Branch> source = pointTool3.Branches;
							if (func == null)
							{
								func = new Func<Branch, bool>(this.method_16);
							}
							foreach (Branch branch in source.Where(func))
							{
								if (!lines.Contains((LineTool)branch.Parent))
								{
									return ((LineTool)branch.Parent).GetTypeParentShina(lines);
								}
							}
						}
					}
					return eTypeShinaTool.None;
				}
			}
			foreach (PointTool pointTool4 in this.Ends)
			{
				if (pointTool4.Parent != null && pointTool4.Parent is ShinaTool)
				{
					return ((ShinaTool)pointTool4.Parent).TypeShinaTool;
				}
			}
			return eTypeShinaTool.None;
		}

		public override DrawingLayer Layer
		{
			get
			{
				return base.Layer;
			}
			set
			{
				base.Layer = value;
				foreach (PointTool pointTool in this.GetPointsList())
				{
					if (value != null)
					{
						pointTool.Layer = value;
					}
					else
					{
						bool flag = true;
						foreach (Branch branch in pointTool.Branches)
						{
							if (branch.Parent.Layer != null)
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							pointTool.Layer = value;
						}
					}
				}
			}
		}

		public override bool Deleted
		{
			get
			{
				return base.Deleted;
			}
			set
			{
				base.Deleted = value;
				foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
				{
					if (drawObjectBase is Branch)
					{
						drawObjectBase.Deleted = value;
					}
				}
			}
		}

		public virtual LineTool DevideLine(PointTool point)
		{
			if (point.BranchesCount == 2 && point.Branches.Last<Branch>().Parent == point.Branches.First<Branch>().Parent)
			{
				if (point.CouplingRelations.Count < 2)
				{
					CouplingRelation couplingRelation = point.Branches.First<Branch>().CouplingRelation;
					this.DevideRelation(couplingRelation, point);
				}
				LineTool lineTool = new LineTool();
				lineTool.Text = this.Text;
				this.Layer.AddObject(lineTool);
				lineTool.CreateUniqueCopyName();
				foreach (Amperage amperage in this.Amperages.Values)
				{
					amperage.KillNextAmperage();
				}
				List<CouplingRelation> list = new List<CouplingRelation>();
				CouplingRelation couplingRelation2 = point.CouplingRelations.First<CouplingRelation>();
				list.Add(couplingRelation2);
				this.RunOnRelation(list, (couplingRelation2.Vertex1 == point) ? couplingRelation2.Vertex2 : couplingRelation2.Vertex1);
				if (list.Count > this.CouplingRelations.Count / 2)
				{
					List<CouplingRelation> list2 = new List<CouplingRelation>();
					list2.AddRange(list);
					list.Clear();
					foreach (CouplingRelation item in this.CouplingRelations)
					{
						if (!list2.Contains(item))
						{
							list.Add(item);
						}
					}
				}
				foreach (CouplingRelation couplingRelation3 in list)
				{
					this.CouplingRelations.Remove(couplingRelation3);
					couplingRelation3.amperagePoint = null;
					couplingRelation3.Line = lineTool;
					lineTool.CouplingRelations.Add(couplingRelation3);
					foreach (Branch branch in couplingRelation3.Branches)
					{
						this.Branches.Remove(branch);
						lineTool.Branches.Add(branch);
						branch.Parent = lineTool;
					}
				}
				List<PointTool> list3 = new List<PointTool>();
				list3.AddRange(this.Amperages.Keys);
				this.ends.Clear();
				this.GetPointsList();
				List<PointTool> pointsList = lineTool.GetPointsList();
				using (List<PointTool>.Enumerator enumerator5 = list3.GetEnumerator())
				{
					Func<CouplingRelation, bool> func = null;
					LineTool.Class79 @class = new LineTool.Class79();
					while (enumerator5.MoveNext())
					{
						PointTool pointTool_ = enumerator5.Current;
						@class.pointTool_0 = pointTool_;
						if (pointsList.Contains(@class.pointTool_0))
						{
							this.Amperages[@class.pointTool_0].Conductor = lineTool;
							lineTool.Amperages.Add(@class.pointTool_0, this.Amperages[@class.pointTool_0]);
							this.Amperages.Remove(@class.pointTool_0);
							IEnumerable<CouplingRelation> source = this.CouplingRelations;
							if (func == null)
							{
								func = new Func<CouplingRelation, bool>(@class.method_0);
							}
							foreach (CouplingRelation couplingRelation4 in source.Where(func))
							{
								couplingRelation4.amperagePoint = null;
							}
						}
					}
				}
				if (this.Amperages.Count > 0)
				{
					this.RecalcAmperage();
				}
				if (lineTool.Amperages.Count > 0)
				{
					lineTool.RecalcAmperage();
				}
				return lineTool;
			}
			return null;
		}

		protected void RunOnRelation(List<CouplingRelation> RelationsList, PointTool nextVertex)
		{
			foreach (CouplingRelation couplingRelation in nextVertex.CouplingRelations)
			{
				if (couplingRelation.Branches.Count >= 0 && !RelationsList.Contains(couplingRelation) && couplingRelation.Line == this)
				{
					RelationsList.Add(couplingRelation);
					this.RunOnRelation(RelationsList, (couplingRelation.Vertex1 == nextVertex) ? couplingRelation.Vertex2 : couplingRelation.Vertex1);
				}
			}
		}

		public void RotateAboutThePoint(double angle, UnitPoint centerOfRotation)
		{
			foreach (PointTool pointTool in this.pointToolList)
			{
				double num = pointTool.Point.X - centerOfRotation.X;
				double num2 = pointTool.Point.Y - centerOfRotation.Y;
				double num3 = Convert.ToDouble(Math.Cos(angle * 3.1415926535897931 / 180.0));
				double num4 = Convert.ToDouble(Math.Sin(angle * 3.1415926535897931 / 180.0));
				double double_ = (double)centerOfRotation.Point.X + num * num3 - num2 * num4;
				double double_2 = (double)centerOfRotation.Point.Y + num * num4 + num2 * num3;
				pointTool.Point = new UnitPoint(double_, double_2);
			}
		}

		public void ReflectAboutTheLine(UnitPoint unitPoint_0, UnitPoint unitPoint_1)
		{
			foreach (PointTool pointTool in this.pointToolList)
			{
				UnitPoint unitPoint = Class88.smethod_5(unitPoint_0, unitPoint_1, pointTool.Point);
				double num = pointTool.Point.X - unitPoint.X;
				double num2 = pointTool.Point.Y - unitPoint.Y;
				pointTool.Point = new UnitPoint((double)((float)(unitPoint.X - num)), (double)((float)(unitPoint.Y - num2)));
			}
		}

		public bool Validation()
		{
			bool flag = false;
			bool flag2 = false;
			this.string_0 = string.Empty;
			foreach (CouplingRelation couplingRelation in this.couplingRelations)
			{
				if (!flag && couplingRelation.Vertex1.BranchesCount == 2 && couplingRelation.Vertex1[0].Parent == couplingRelation.Vertex1[1].Parent)
				{
					flag = true;
				}
				if (!flag && couplingRelation.Vertex2.BranchesCount == 2 && couplingRelation.Vertex2[0].Parent == couplingRelation.Vertex2[1].Parent)
				{
					flag = true;
				}
				if (!flag2)
				{
					foreach (Branch branch in couplingRelation.Branches)
					{
						if ((branch.Source.BranchesCount > 2 && couplingRelation.Vertex1 != branch.Source && couplingRelation.Vertex2 != branch.Source) || (branch.Destination.BranchesCount > 2 && couplingRelation.Vertex1 != branch.Destination && couplingRelation.Vertex2 != branch.Destination))
						{
							flag2 = true;
						}
					}
				}
			}
			if (flag)
			{
				this.string_0 += "Ошибка связей - связь по среди линии. ";
			}
			if (flag2)
			{
				this.string_0 += "Ошибка связей - разветвление внутри связи. ";
			}
			return this.string_0 == string.Empty;
		}

		public bool EndsContains(PointTool item)
		{
			return this.ends.Contains(item);
		}

		public override bool PointInObject(UnitPoint point)
		{
			if (this.Layer == null)
			{
				return false;
			}
			CanvasControl parent = this.Layer.Parent;
			this.selectedBranch = null;
			this.selectedPoint = null;
			foreach (Branch branch in this.branches)
			{
				if (branch.PointInObject(point))
				{
					this.selectedBranch = branch;
					this.HitTest(parent, ConvertCanvas.ConvertToScreen(parent, point));
					this.clickedPoint = point;
					return true;
				}
			}
			foreach (PointTool pointTool in this.ends)
			{
				if (pointTool.PointInObject(point))
				{
					this.selectedPoint = pointTool;
					this.clickedPoint = point;
					return true;
				}
			}
			return false;
		}

		public virtual Branch AddBranch(PointTool pointTool_0, PointTool dest)
		{
			if (this.LimitedEditing)
			{
				return null;
			}
			bool flag = false;
			bool flag2 = false;
			foreach (Branch branch in this.branches)
			{
				if (branch.Source == pointTool_0 || branch.Destination == pointTool_0)
				{
					flag = true;
				}
				if (branch.Source == dest || branch.Destination == dest)
				{
					flag2 = true;
				}
				if (flag && flag2)
				{
					break;
				}
			}
			if (pointTool_0.Layer == null)
			{
				pointTool_0.Layer = this.Layer;
			}
			if (dest.Layer == null)
			{
				dest.Layer = this.Layer;
			}
			Branch branch2;
			if (!flag && !flag2)
			{
				this.ends.Add(pointTool_0);
				pointTool_0.AddBranchEvent += new PointToolEventHandle(this.method_6);
				this.ends.Add(dest);
				dest.AddBranchEvent += new PointToolEventHandle(this.method_6);
				branch2 = new Branch(this, pointTool_0, dest);
				branch2.CouplingRelation = this.CreateRelation(pointTool_0, dest);
				this.AmperageAnalisForNewPoint(pointTool_0, branch2);
				this.AmperageAnalisForNewPoint(dest, branch2);
			}
			else if (!flag2)
			{
				if (this.ends.Contains(pointTool_0))
				{
					this.ends.Remove(pointTool_0);
					pointTool_0.AddBranchEvent -= new PointToolEventHandle(this.method_6);
					this.ends.Add(dest);
					dest.AddBranchEvent += new PointToolEventHandle(this.method_6);
				}
				if (pointTool_0.CouplingRelations.Count > 1)
				{
					this.CreateCoupling(dest);
					this.ends.Add(dest);
					dest.AddBranchEvent += new PointToolEventHandle(this.method_6);
					branch2 = new Branch(this, pointTool_0, dest);
					branch2.CouplingRelation = this.CreateRelation(pointTool_0, dest);
					this.AmperageAnalisForNewPoint(pointTool_0, branch2);
				}
				else if (pointTool_0.CouplingRelations.Count == 1)
				{
					this.ChangeCoupling(pointTool_0, dest);
					branch2 = new Branch(this, pointTool_0, dest);
					branch2.CouplingRelation = dest.CouplingRelations[dest.CouplingRelations.Count - 1];
					int count = dest.CouplingRelations.Count;
					this.AmperageAnalisForNewPoint(pointTool_0, branch2);
				}
				else
				{
					branch2 = this.AddBranching(pointTool_0, dest);
				}
			}
			else
			{
				if (flag)
				{
					return null;
				}
				if (this.ends.Contains(dest))
				{
					this.ends.Remove(dest);
					dest.AddBranchEvent -= new PointToolEventHandle(this.method_6);
					this.ends.Add(pointTool_0);
					pointTool_0.AddBranchEvent += new PointToolEventHandle(this.method_6);
				}
				if (dest.CouplingRelations.Count > 1)
				{
					this.CreateCoupling(pointTool_0);
					this.ends.Add(pointTool_0);
					pointTool_0.AddBranchEvent += new PointToolEventHandle(this.method_6);
					branch2 = new Branch(this, pointTool_0, dest);
					branch2.CouplingRelation = this.CreateRelation(dest, pointTool_0);
					this.AmperageAnalisForNewPoint(dest, branch2);
				}
				else if (dest.CouplingRelations.Count == 1)
				{
					this.ChangeCoupling(dest, pointTool_0);
					branch2 = new Branch(this, pointTool_0, dest);
					branch2.CouplingRelation = pointTool_0.CouplingRelations[pointTool_0.CouplingRelations.Count - 1];
					this.AmperageAnalisForNewPoint(dest, branch2);
				}
				else
				{
					branch2 = this.AddBranching(dest, pointTool_0);
				}
			}
			this.selectedBranch = branch2;
			this.GetPointsList();
			return branch2;
		}

		public virtual bool AddBranch(PointTool dest)
		{
			if (this.LimitedEditing)
			{
				return false;
			}
			PointTool destination = this.branches[this.branches.Count - 1].Destination;
			return this.AddBranch(destination, dest) != null;
		}

		private void method_6(object sender, EventArgs e)
		{
			if ((sender is PointTool || sender.GetType().BaseType == typeof(PointTool)) && this.lineToolEventHandler_4 != null)
			{
				this.lineToolEventHandler_4(this, new LineToolEventArgs((PointTool)sender, null, null, null, null));
			}
		}

		public void AddBranch()
		{
			if (this.LimitedEditing)
			{
				return;
			}
			PointTool pointTool;
			if (this.selectedPoint != null)
			{
				pointTool = this.selectedPoint;
			}
			else
			{
				if (this.selectedBranch == null)
				{
					return;
				}
				pointTool = new PointTool(Class88.smethod_5(this.selectedBranch.Source.Point, this.selectedBranch.Destination.Point, this.clickedPoint));
				PointTool destination = this.selectedBranch.Destination;
				Amperage amperage = this.Amperages.ContainsKey(destination) ? this.Amperages[destination] : null;
				destination.RemoveBranch(this.selectedBranch);
				this.selectedBranch.Destination = pointTool;
				pointTool.AddBranch(this.selectedBranch);
				Branch branch = new Branch(this, destination, pointTool);
				branch.CouplingRelation = this.selectedBranch.CouplingRelation;
				if (amperage != null)
				{
					this.Amperages.Add(destination, amperage);
					this.RecalcAmperage();
				}
				this.selectedBranch = null;
				this.selectedPoint = pointTool;
				this.pointToolList = this.GetPointsList();
			}
			try
			{
				this.AddBranching(pointTool);
			}
			catch (Exception ex)
			{
				this.Layer.Parent.SendMessage(ex.Message, eMessageType.Warning);
				return;
			}
			base.CallDrawNewObjectEvent(this, this);
			this.RecalcAmperage();
		}

		public virtual bool AddBranch(Branch branch)
		{
			if (this.LimitedEditing)
			{
				return false;
			}
			bool flag = false;
			bool flag2 = false;
			PointTool source = branch.Source;
			PointTool destination = branch.Destination;
			foreach (Branch branch2 in this.branches)
			{
				if (branch2.Source == source || branch2.Destination == source)
				{
					flag = true;
				}
				if (branch2.Source == destination || branch2.Destination == destination)
				{
					flag2 = true;
				}
				if (flag && flag2)
				{
					break;
				}
			}
			if (source.Layer == null)
			{
				source.Layer = this.Layer;
			}
			if (destination.Layer == null)
			{
				destination.Layer = this.Layer;
			}
			if (!flag && !flag2)
			{
				this.ends.Add(source);
				source.AddBranchEvent += new PointToolEventHandle(this.method_6);
				this.ends.Add(destination);
				destination.AddBranchEvent += new PointToolEventHandle(this.method_6);
				branch.Parent = this;
				this.branches.Add(branch);
				if (branch.CouplingRelation == null)
				{
					branch.CouplingRelation = this.CreateRelation(source, destination);
				}
				this.AmperageAnalisForNewPoint(source, branch);
				this.AmperageAnalisForNewPoint(destination, branch);
			}
			else if (!flag2)
			{
				if (this.ends.Contains(source))
				{
					branch.Parent = this;
					this.ends.Remove(source);
					source.AddBranchEvent -= new PointToolEventHandle(this.method_6);
					this.ends.Add(destination);
					destination.AddBranchEvent += new PointToolEventHandle(this.method_6);
				}
				if (source.CouplingRelations.Count > 1)
				{
					branch.Parent = this;
					this.branches.Add(branch);
					if (source.BranchesCount > 2)
					{
						this.ends.Add(destination);
						destination.AddBranchEvent += new PointToolEventHandle(this.method_6);
					}
					if (branch.CouplingRelation == null)
					{
						this.CreateCoupling(destination);
						branch.CouplingRelation = this.CreateRelation(source, destination);
					}
					this.AmperageAnalisForNewPoint(destination, branch);
				}
				else if (source.CouplingRelations.Count != 1 && (source.CouplingRelations.Count != 0 || branch.CouplingRelation == null))
				{
					branch.Parent = this;
					this.AddBranching(branch);
				}
				else
				{
					branch.Parent = this;
					this.branches.Add(branch);
					if (branch.CouplingRelation == null)
					{
						this.ChangeCoupling(source, destination);
						branch.CouplingRelation = destination.CouplingRelations[destination.CouplingRelations.Count - 1];
					}
					this.AmperageAnalisForNewPoint(destination, branch);
				}
			}
			else
			{
				if (flag)
				{
					return false;
				}
				if (this.ends.Contains(destination))
				{
					branch.Parent = this;
					this.ends.Remove(destination);
					destination.AddBranchEvent -= new PointToolEventHandle(this.method_6);
					this.ends.Add(source);
					source.AddBranchEvent += new PointToolEventHandle(this.method_6);
				}
				if (destination.CouplingRelations.Count > 1)
				{
					branch.Parent = this;
					this.branches.Add(branch);
					if (destination.BranchesCount > 2)
					{
						this.ends.Add(source);
						source.AddBranchEvent += new PointToolEventHandle(this.method_6);
					}
					if (branch.CouplingRelation == null)
					{
						this.CreateCoupling(source);
						branch.CouplingRelation = this.CreateRelation(destination, source);
					}
					this.AmperageAnalisForNewPoint(source, branch);
				}
				else if (destination.CouplingRelations.Count == 1)
				{
					branch.Parent = this;
					this.branches.Add(branch);
					if (branch.CouplingRelation == null)
					{
						this.ChangeCoupling(destination, source);
						branch.CouplingRelation = source.CouplingRelations[source.CouplingRelations.Count - 1];
					}
					this.AmperageAnalisForNewPoint(source, branch);
				}
				else
				{
					branch.Parent = this;
					this.AddBranching(branch);
				}
			}
			this.GetPointsList();
			return true;
		}

		public virtual Branch AddBranch(PointTool pointTool_0, PointTool dest, BranchType type)
		{
			if (this.LimitedEditing)
			{
				return null;
			}
			Branch branch = this.AddBranch(pointTool_0, dest);
			if (branch != null)
			{
				branch.Type = type;
			}
			return branch;
		}

		protected Branch AddBranching(PointTool pointTool_0, PointTool dest)
		{
			if (pointTool_0.CouplingRelations.Count != 0)
			{
				return null;
			}
			if (pointTool_0.BranchesCount > 2)
			{
				throw new Exception("Непонятно О_о");
			}
			Branch branch = pointTool_0[0];
			this.DevideRelation(branch.CouplingRelation, pointTool_0);
			return this.AddBranch(pointTool_0, dest);
		}

		protected bool AddBranching(Branch branch)
		{
			if (this.LimitedEditing)
			{
				return false;
			}
			PointTool source = branch.Source;
			PointTool destination = branch.Destination;
			if (source.TypePoint == TypePointTool.Coupling)
			{
				return false;
			}
			if (source.BranchesCount > 3)
			{
				throw new Exception("Непонятно О_о");
			}
			Branch branch2 = source[0];
			Branch branch3 = source[1];
			if (branch2.CouplingRelation.Vertex2 != branch2.Destination)
			{
				PointTool vertex = branch2.CouplingRelation.Vertex1;
				PointTool destination2 = branch3.Destination;
			}
			PointTool pointTool;
			if (source == branch2.Destination)
			{
				pointTool = branch2.Source;
			}
			else
			{
				pointTool = branch2.Destination;
			}
			List<Branch> list = new List<Branch>();
			list.Add(branch2);
			while (pointTool != branch2.CouplingRelation.Vertex2)
			{
				if (pointTool == branch2.CouplingRelation.Vertex1)
				{
					break;
				}
				if (pointTool.BranchesCount > 2)
				{
					throw new Exception("Неожиданная ошибка: У точки больше 2-х соурсов, но конец связи ещё не найден :(");
				}
				foreach (Branch branch4 in pointTool.Branches)
				{
					if (branch4 != branch2)
					{
						branch2 = branch4;
						break;
					}
				}
				if (branch2.Source == pointTool)
				{
					pointTool = branch2.Destination;
				}
				else
				{
					if (branch2.Destination != pointTool)
					{
						throw new Exception("Совсем неожиданная ошибка: точка-путешественница не нашла себя в бренче :'(");
					}
					pointTool = branch2.Source;
				}
				list.Add(branch2);
				if (list.Count >= ((LineTool)branch2.Parent).Branches.Count)
				{
					throw new Exception("Совсем неожиданная ошибка: точка-путешественница не нашла себя в бренче :'(");
				}
			}
			branch2.CouplingRelation.ChangeCoupling(pointTool, source);
			CouplingRelation couplingRelation = this.CreateRelation(source, pointTool);
			foreach (Branch branch5 in list)
			{
				branch5.CouplingRelation = couplingRelation;
			}
			if (branch.CouplingRelation == null)
			{
				branch.CouplingRelation = new CouplingRelation(source, destination);
			}
			return true;
		}

		protected void AddBranching(PointTool point)
		{
			if (this.LimitedEditing)
			{
				return;
			}
			foreach (Branch branch in point.Branches)
			{
				if (branch.Parent != this)
				{
					throw new Exception("К данной точке нельзя добавить линию");
				}
			}
			PointTool dest = new PointTool(new UnitPoint(point.Point.Point));
			this.AddBranch(point, dest);
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			LineTool lineTool = new LineTool();
			lineTool.Copy(this);
			lineTool.Master = this;
			if (SaveParentRelation)
			{
				this.AmperageAdded += this.LineTool_AmperageAdded;
				this.AmperageRemoved += this.LineTool_AmperageRemoved;
				this.StateAdded += this.LineTool_StateAdded;
				this.StateRemoved += this.LineTool_StateRemoved;
			}
			return lineTool;
		}

		private void LineTool_AmperageRemoved(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
			if (lineTool_0 == this.Master)
			{
				PointTool pointTool = null;
				foreach (PointTool pointTool2 in this.ends)
				{
					if (pointTool2.IdBase == lineToolEventArgs_0.eventPoint.IdBase)
					{
						pointTool = pointTool2;
						break;
					}
				}
				if (pointTool != null && this.Amperages.ContainsKey(pointTool))
				{
					this.RemoveAmperage(this.Amperages[pointTool]);
				}
			}
		}

		private void LineTool_AmperageAdded(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
			if (lineTool_0 == this.Master)
			{
				Amperage amperage = lineTool_0.Amperages[lineToolEventArgs_0.eventPoint].Clone(this);
				PointTool pointTool = null;
				foreach (PointTool pointTool2 in this.ends)
				{
					if (pointTool2.IdBase == lineToolEventArgs_0.eventPoint.IdBase)
					{
						pointTool = pointTool2;
						break;
					}
				}
				if (pointTool != null)
				{
					this.AddAmperage(pointTool, amperage);
				}
			}
		}

		public void AmperageAnalisForNewPoint(PointTool newPoint, Branch newBranch)
		{
			bool flag = newBranch.CouplingRelation.amperagePoint != null;
			bool flag2 = false;
			CouplingRelation couplingRelation = null;
			if (newPoint.Parent != null && newPoint.Parent != this && newPoint.Parent.GetType() == typeof(ShinaTool))
			{
				flag2 = (((ShinaTool)newPoint.Parent).Amperage != null);
			}
			foreach (Branch branch in newPoint.Branches)
			{
				if (branch.Parent != this && branch.CouplingRelation.amperagePoint != null && branch.CouplingRelation.amperagePoint != newPoint)
				{
					couplingRelation = branch.CouplingRelation;
				}
			}
			if (flag && flag2 && ((ShinaTool)newPoint.Parent).Amperage.Source != this.Amperages[newBranch.CouplingRelation.amperagePoint].Source)
			{
				this.Layer.Parent.SendMessage(this, "Не предусмотренное замыкание в цепи.", eMessageType.Error);
			}
			if (flag && couplingRelation != null && couplingRelation.Line.Amperages[couplingRelation.amperagePoint].Source != this.Amperages[newBranch.CouplingRelation.amperagePoint].Source)
			{
				this.Layer.Parent.SendMessage(this, "Не предусмотренное замыкание в цепи.", eMessageType.Error);
			}
			if (flag && !flag2 && couplingRelation == null)
			{
				this.method_11(newBranch.CouplingRelation.amperagePoint);
				return;
			}
			if (flag2 && !flag)
			{
				((ShinaTool)newPoint.Parent).method_15((PointShinaTool)newPoint);
				return;
			}
			if (couplingRelation != null && !flag)
			{
				couplingRelation.Line.method_11(couplingRelation.amperagePoint);
			}
		}

		public List<Branch> OurBranchesInPoint(PointTool pointTool)
		{
			List<Branch> list = new List<Branch>();
			foreach (Branch branch in pointTool.Branches)
			{
				if (branch.Parent == this)
				{
					list.Add(branch);
				}
			}
			return list;
		}

		public virtual void Copy(LineTool aCopy)
		{
			base.Copy(aCopy);
			this.Type = aCopy.Type;
			Dictionary<PointTool, PointTool> dictionary = new Dictionary<PointTool, PointTool>();
			foreach (PointTool pointTool in aCopy.GetPointsList())
			{
				dictionary.Add(pointTool, (PointTool)pointTool.Clone(false));
				if (pointTool.Parent == aCopy)
				{
					dictionary[pointTool].Parent = this;
				}
			}
			foreach (CouplingRelation couplingRelation in aCopy.CouplingRelations)
			{
				this.CreateRelation(dictionary[couplingRelation.Vertex1], dictionary[couplingRelation.Vertex2]);
			}
			foreach (Branch branch in aCopy.Branches)
			{
				Branch branch2 = new Branch(this, dictionary[branch.Source], dictionary[branch.Destination], branch.Type);
				foreach (CouplingRelation couplingRelation2 in this.CouplingRelations)
				{
					if ((couplingRelation2.Vertex1 == dictionary[branch.CouplingRelation.Vertex1] && couplingRelation2.Vertex2 == dictionary[branch.CouplingRelation.Vertex2]) || (couplingRelation2.Vertex2 == dictionary[branch.CouplingRelation.Vertex1] && couplingRelation2.Vertex1 == dictionary[branch.CouplingRelation.Vertex2]))
					{
						branch2.CouplingRelation = couplingRelation2;
					}
				}
				int count = aCopy.OurBranchesInPoint(branch.Source).Count;
				if (count == 1)
				{
					this.ends.Add(dictionary[branch.Source]);
					dictionary[branch.Source].AddBranchEvent += new PointToolEventHandle(this.method_6);
					if (dictionary[branch.Source].GetType() != typeof(PointShinaTool))
					{
						dictionary[branch.Source].TypePoint = TypePointTool.Coupling;
					}
				}
				if (count > 2)
				{
					dictionary[branch.Source].TypePoint = TypePointTool.Coupling;
				}
				count = aCopy.OurBranchesInPoint(branch.Destination).Count;
				if (count == 1)
				{
					this.ends.Add(dictionary[branch.Destination]);
					dictionary[branch.Source].AddBranchEvent += new PointToolEventHandle(this.method_6);
					if (dictionary[branch.Destination].GetType() != typeof(PointShinaTool))
					{
						dictionary[branch.Destination].TypePoint = TypePointTool.Coupling;
					}
				}
				if (count > 2)
				{
					dictionary[branch.Destination].TypePoint = TypePointTool.Coupling;
				}
				foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
				{
					if (drawObjectBase is ObjectOnLine)
					{
						ObjectOnLine objectOnLine = (ObjectOnLine)drawObjectBase.Clone(false);
						objectOnLine.Parent = branch2;
						branch2.AddSwitchTool(objectOnLine);
					}
					if (drawObjectBase is TextBranchTool)
					{
						TextBranchTool textBranchTool = (TextBranchTool)drawObjectBase.Clone(false);
						textBranchTool.Parent = branch2;
					}
				}
				branch2.Master = branch;
			}
		}

		public override void InitializeFromModel(UnitPoint point, DrawingLayer layer, ISnapPoint snap)
		{
			this.Remove(false, true);
			this.Layer = layer;
			PointTool pointTool_ = new PointTool(point);
			PointTool dest = new PointTool(point);
			this.AddBranch(pointTool_, dest);
			base.Width = layer.Width;
			this.Color = layer.Color;
			this.Selected = true;
		}

		public override void Remove(bool delSql, bool parentNULL)
		{
			if (!this.LimitedEditing)
			{
				foreach (CouplingRelation couplingRelation in this.CouplingRelations)
				{
					while (this.Amperages.Count > 0)
					{
						this.Amperages.Values.First<Amperage>().OffAmperage();
					}
					couplingRelation.Deleted = true;
					bool flag = true;
					foreach (CouplingRelation couplingRelation2 in couplingRelation.Vertex1.CouplingRelations)
					{
						if (!couplingRelation2.Deleted)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						couplingRelation.Vertex1.Remove(true, false);
					}
					flag = true;
					foreach (CouplingRelation couplingRelation3 in couplingRelation.Vertex2.CouplingRelations)
					{
						if (!couplingRelation3.Deleted)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						couplingRelation.Vertex2.Remove(true, false);
					}
				}
				foreach (PointTool pointTool in this.ends)
				{
					int num = 0;
					while (pointTool.BranchesCount > num)
					{
						Branch branch = pointTool[num];
						if (branch.Parent == this)
						{
							pointTool.RemoveBranch(branch);
							break;
						}
						num++;
					}
				}
				this.Deleted = true;
				foreach (Branch branch2 in this.branches)
				{
					foreach (DrawObjectBase drawObjectBase in branch2.ChildObjects)
					{
						drawObjectBase.Remove(delSql, parentNULL);
					}
				}
			}
			base.Remove(delSql, parentNULL);
		}

		public override Cursor GetHandleCursor(int handleNumber)
		{
			if (this.Layer != null && this.Layer.Parent != null && this.Layer.Parent.Mode != eCanvasEditingMode.Edit)
			{
				return Cursors.Default;
			}
			if (handleNumber >= 0)
			{
				return Cursors.SizeNWSE;
			}
			return Cursors.Default;
		}

		public override int HitTest(CanvasControl canvas, PointF point)
		{
			if (this.Selected)
			{
				for (int i = 1; i <= this.NodeCount; i++)
				{
					if (base.GetNodeRectangle(canvas, i).Contains(point))
					{
						this.selectedPoint = this.pointToolList[i - 1];
						return i;
					}
				}
			}
			return -1;
		}

		protected override UnitPoint GetNode(int nodeNumber)
		{
			return this.pointToolList[nodeNumber - 1].Point;
		}

		protected override void CallEndDrawEvent(DrawObjectBase sender)
		{
			base.OnEndDrawEvent(sender);
			if (this.IdBase > 0)
			{
				if (this.Layer.Parent.TypeCanvas != eTypeCanvas.SchemeSecond)
				{
					SqlDataCommand sqlDataCommand = new SqlDataCommand(this.Layer.Parent.SqlSettings);
					sqlDataCommand.DeleteSqlData(this.Layer.Parent.dataSetScheme_0.tSchm_Xml, "where [ObjId] = " + this.IdBase + " AND TypeSchema=2");
				}
				this.SaveToSql(false, true);
			}
		}

		public override bool ObjectInRectangle(CanvasControl canvas, RectangleF rect, bool anyPoint)
		{
			foreach (Branch branch in this.branches)
			{
				if (branch.ObjectInRectangle(canvas, rect, anyPoint))
				{
					return true;
				}
			}
			return false;
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if (!this.Visible)
			{
				return;
			}
			foreach (Branch branch in this.branches)
			{
				branch.Draw(canvas, unitrect, drawMode);
			}
			if (this.Selected && (drawMode & eDrawMode.Print) != eDrawMode.Print)
			{
				base.DrawTracker(canvas);
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics graphics_0, bool isColor = false)
		{
			foreach (Branch branch in this.branches)
			{
				branch.DrawPrint(canvas, graphics_0, isColor);
			}
		}

		public override RectangleF GetBoundingRect(CanvasControl canvas, bool inflate)
		{
			if (this.ends.Count > 0)
			{
				float num = base.ThresholdWidth(canvas, base.Width);
				UnitPoint point = this.ends[0].Point;
				UnitPoint point2 = this.ends[0].Point;
				foreach (Branch branch in this.branches)
				{
					if (branch.Source.Point.X < point.X)
					{
						point.X = branch.Source.Point.X;
					}
					if (branch.Source.Point.Y < point.Y)
					{
						point.Y = branch.Source.Point.Y;
					}
					if (branch.Destination.Point.X < point.X)
					{
						point.X = branch.Destination.Point.X;
					}
					if (branch.Destination.Point.Y < point.Y)
					{
						point.Y = branch.Destination.Point.Y;
					}
					if (branch.Source.Point.X > point2.X)
					{
						point2.X = branch.Source.Point.X;
					}
					if (branch.Source.Point.Y > point2.Y)
					{
						point2.Y = branch.Source.Point.Y;
					}
					if (branch.Destination.Point.X > point2.X)
					{
						point2.X = branch.Destination.Point.X;
					}
					if (branch.Destination.Point.Y > point2.Y)
					{
						point2.Y = branch.Destination.Point.Y;
					}
				}
				RectangleF result = new RectangleF(point.Point.X, point.Point.Y, point2.Point.X - point.Point.X, point2.Point.Y - point.Point.Y);
				if (inflate)
				{
					result.Inflate(num, num);
				}
				return result;
			}
			return Rectangle.Empty;
		}

		public override void OnMouseDown(CanvasControl canvas, UnitPoint point, ISnapPoint snappoint, MouseButtons button)
		{
			if (button != MouseButtons.Left)
			{
				if (button != MouseButtons.Right)
				{
					return;
				}
				eCommandType eCommandType_ = canvas.eCommandType_0;
				if (eCommandType_ == eCommandType.draw)
				{
					this.CallEndDrawEvent(this);
					return;
				}
				base.OnMouseDown(canvas, point, snappoint, button);
			}
			else
			{
				eCommandType eCommandType_2 = canvas.eCommandType_0;
				if (eCommandType_2 != eCommandType.draw)
				{
					return;
				}
				if (this.branches.Count == 0)
				{
					return;
				}
				if (this.branches.Count == 1 && this.branches[0].Source.Point == this.branches[0].Destination.Point)
				{
					PointTool pointTool = canvas.method_44(point);
					bool flag = false;
					if (pointTool != null)
					{
						foreach (Branch branch in pointTool.Branches)
						{
							if (branch.Parent.LimitedEditing)
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							this.RechangePointInBranch(this.Branches[0], pointTool, true);
							this.AmperageAnalisForNewPoint(pointTool, this.branches[0]);
							return;
						}
					}
				}
				else if (this.branches.Count >= 1)
				{
					PointTool pointTool2 = canvas.method_44(point);
					if (pointTool2 == null)
					{
						this.AddBranch(new PointTool(point));
						return;
					}
					bool flag2 = false;
					foreach (Branch branch2 in pointTool2.Branches)
					{
						if (branch2.Parent.LimitedEditing)
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						flag2 = this.pointToolList.Contains(pointTool2);
					}
					if (!flag2 && pointTool2 != null)
					{
						this.RechangePointInBranch(this.Branches[this.Branches.Count - 1], pointTool2, false);
						this.AmperageAnalisForNewPoint(pointTool2, this.branches[this.Branches.Count - 1]);
						this.CallEndDrawEvent(this);
						return;
					}
				}
			}
		}

		public override void OnMouseMove(CanvasControl canvas, UnitPoint point, MouseButtons button)
		{
			if (button != MouseButtons.None)
			{
				return;
			}
			eCommandType eCommandType_ = canvas.eCommandType_0;
			if (eCommandType_ != eCommandType.draw)
			{
				return;
			}
			canvas.Graphics = Graphics.FromHwnd(canvas.Handle);
			RectangleF unitrect = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetBoundingRect(canvas, true));
			unitrect.Inflate(2f, 2f);
			canvas.method_36(new Rectangle((int)unitrect.X, (int)unitrect.Y, (int)unitrect.Width, (int)unitrect.Height));
			this.MoveHandleTo(point, this.pointToolList.IndexOf(this.branches[this.branches.Count - 1].Destination) + 1);
			this.Draw(canvas, unitrect, eDrawMode.Color);
		}

		public override void MoveHandleTo(UnitPoint point, int handleNumber)
		{
			PointTool pointTool = this.pointToolList[handleNumber - 1];
			if (pointTool.Parent != null && pointTool.Parent.Layer != null)
			{
				if (pointTool.Parent.GetType() == typeof(LineCellTool) || pointTool.Parent.GetType() == typeof(Class74))
				{
					if (pointTool.Parent.Parent != null && pointTool.Parent.Parent.Layer != null)
					{
						if (point.X < (double)((RectangleTool)pointTool.Parent.Parent).Rectangle.Left)
						{
							point.X = (double)((RectangleTool)pointTool.Parent.Parent).Rectangle.Left;
						}
						if (point.X > (double)((RectangleTool)pointTool.Parent.Parent).Rectangle.Right)
						{
							point.X = (double)((RectangleTool)pointTool.Parent.Parent).Rectangle.Right;
						}
						if (point.Y < (double)((RectangleTool)pointTool.Parent.Parent).Rectangle.Top)
						{
							point.Y = (double)((RectangleTool)pointTool.Parent.Parent).Rectangle.Top;
						}
						if (point.Y > (double)((RectangleTool)pointTool.Parent.Parent).Rectangle.Bottom)
						{
							point.Y = (double)((RectangleTool)pointTool.Parent.Parent).Rectangle.Bottom;
						}
					}
					pointTool.Point = point;
				}
				if (pointTool.Parent.GetType() == typeof(ShinaTool) || pointTool.Parent.GetType() == typeof(SplitterShinaTool))
				{
					pointTool.Point = point;
				}
				return;
			}
			pointTool.Point = point;
		}

		public override void Move(UnitPoint offset, bool selectedMove)
		{
			if (!selectedMove && this.Selected)
			{
				return;
			}
			List<PointTool> pointsList = this.GetPointsList();
			foreach (PointTool pointTool in pointsList)
			{
				if (pointTool.Parent != null)
				{
					if (pointTool.Parent == this)
					{
						IEnumerable<Branch> source = pointTool.Branches;
						if (LineTool.func_0 == null)
						{
							LineTool.func_0 = new Func<Branch, DrawObjectBase>(LineTool.smethod_0);
						}
						IEnumerable<IGrouping<DrawObjectBase, Branch>> enumerable = source.GroupBy(LineTool.func_0);
						int num = 0;
						foreach (IGrouping<DrawObjectBase, Branch> grouping in enumerable)
						{
							if (grouping.Key.Selected && grouping.Key.GetType() == typeof(LineCellTool))
							{
								num++;
							}
						}
						if (num == 0)
						{
							num = 1;
						}
						UnitPoint point = pointTool.Point;
						point.X += offset.X / (double)num;
						point.Y += offset.Y / (double)num;
						pointTool.Point = point;
					}
					if (pointTool.Parent is ShinaTool && !pointTool.Parent.Selected && !pointTool.Parent.Parent.Selected)
					{
						UnitPoint point2 = pointTool.Point;
						point2.X += offset.X;
						point2.Y += offset.Y;
						pointTool.Point = point2;
					}
				}
				else if (pointTool.Parent == null)
				{
					IEnumerable<Branch> source2 = pointTool.Branches;
					if (LineTool.func_1 == null)
					{
						LineTool.func_1 = new Func<Branch, DrawObjectBase>(LineTool.smethod_1);
					}
					IEnumerable<IGrouping<DrawObjectBase, Branch>> enumerable2 = source2.GroupBy(LineTool.func_1);
					int num2 = 0;
					foreach (IGrouping<DrawObjectBase, Branch> grouping2 in enumerable2)
					{
						if (grouping2.Key.Selected && grouping2.Key.GetType() == typeof(LineTool))
						{
							num2++;
						}
					}
					if (num2 == 0)
					{
						num2 = 1;
					}
					UnitPoint point3 = pointTool.Point;
					point3.X += offset.X / (double)num2;
					point3.Y += offset.Y / (double)num2;
					pointTool.Point = point3;
				}
			}
		}

		public List<PointTool> GetPointsList()
		{
			List<PointTool> list = new List<PointTool>();
			if (this.branches.Count > 0)
			{
				if (this.ends.Count == 0)
				{
					foreach (Branch branch in this.branches)
					{
						int num = 0;
						foreach (Branch branch2 in branch.Source.Branches)
						{
							if (branch2.Parent == this)
							{
								num++;
							}
							if (num > 2)
							{
								break;
							}
						}
						if (num == 1)
						{
							this.ends.Add(branch.Source);
							branch.Source.AddBranchEvent += new PointToolEventHandle(this.method_6);
						}
						num = 0;
						foreach (Branch branch3 in branch.Destination.Branches)
						{
							if (branch3.Parent == this)
							{
								num++;
							}
							if (num > 2)
							{
								break;
							}
						}
						if (num == 1)
						{
							this.ends.Add(branch.Destination);
							branch.Destination.AddBranchEvent += new PointToolEventHandle(this.method_6);
						}
					}
				}
				this.method_10(this.ends[0], null, list);
			}
			this.pointToolList = list;
			return list;
		}

		public override void EndDraw()
		{
			if (this.Branches[this.Branches.Count - 1].Destination.BranchesCount == 1 && base.GetType() != typeof(LineCellTool) && base.GetType() != typeof(Class74))
			{
				DrawingLayer layer = this.Layer;
				this.RemovePointTool(this.selectedBranch.Destination);
				if (this.Layer == null)
				{
					layer.Parent.CommandEscape();
					return;
				}
			}
			if (this.Layer != null && this.Layer.Parent != null)
			{
				if (this.Layer.Parent.UseObjectFromDB && this.IdBase <= 0)
				{
					Form form;
					if (this is LineCellTool)
					{
						form = new FormCellProperties((LineCellTool)this, this.Layer.Parent.SqlSettings);
					}
					else
					{
						form = new LinePropertyesForm(this);
					}
					if (form.ShowDialog() == DialogResult.Cancel)
					{
						this.Layer.Parent.CommandEscape();
						this.Remove(this.IdBase > 0, true);
						this.Parent = null;
						return;
					}
					this.Layer.Parent.CommandEscape();
					return;
				}
				else
				{
					this.Layer.Parent.CommandEscape();
				}
			}
		}

		public void RechangePointInBranch(Branch branch, PointTool newPoint, bool isSourse)
		{
			bool flag = false;
			PointTool pointTool;
			if (isSourse)
			{
				pointTool = branch.Source;
				branch.Source = newPoint;
			}
			else
			{
				pointTool = branch.Destination;
				branch.Destination = newPoint;
			}
			newPoint.AddBranch(branch);
			pointTool.RemoveBranch(branch);
			if (this.ends.Contains(pointTool))
			{
				this.ends.Remove(pointTool);
				pointTool.AddBranchEvent -= new PointToolEventHandle(this.method_6);
				this.ends.Add(newPoint);
				newPoint.AddBranchEvent += new PointToolEventHandle(this.method_6);
				if (pointTool.Parent == this && newPoint.Parent == null)
				{
					newPoint.Parent = pointTool.Parent;
				}
			}
			if (newPoint.Layer == null)
			{
				newPoint.Layer = this.Layer;
			}
			if (pointTool.CouplingRelations.Count == 0)
			{
				if (pointTool.BranchesCount != 2)
				{
					throw new Exception("Ошибка, такого быть не должно");
				}
				if (pointTool[0].CouplingRelation != pointTool[1].CouplingRelation)
				{
					throw new Exception("Ошибка, такого быть не должно");
				}
				this.DevideRelation(pointTool[0].CouplingRelation, pointTool);
			}
			if (pointTool.CouplingRelations.Count > 0)
			{
				for (int i = 0; i < pointTool.CouplingRelations.Count; i++)
				{
					CouplingRelation couplingRelation = pointTool.CouplingRelations[i];
					if (couplingRelation.Line == this)
					{
						couplingRelation.ChangeCoupling(pointTool, newPoint);
						i--;
					}
				}
				if (newPoint.CouplingRelations.Count == 2 && newPoint.CouplingRelations[0].Line == newPoint.CouplingRelations[1].Line)
				{
					CouplingRelation couplingRelation2 = newPoint.CouplingRelations[0];
					CouplingRelation couplingRelation3 = newPoint.CouplingRelations[1];
					if (newPoint != couplingRelation2.Vertex1)
					{
						PointTool vertex = couplingRelation2.Vertex1;
					}
					else
					{
						PointTool vertex2 = couplingRelation2.Vertex2;
					}
					PointTool pointTool2 = (newPoint == couplingRelation3.Vertex1) ? couplingRelation3.Vertex2 : couplingRelation3.Vertex1;
					while (couplingRelation3.Branches.Count > 0)
					{
						couplingRelation3.Branches[0].CouplingRelation = couplingRelation2;
					}
					newPoint.CouplingRelations.Remove(couplingRelation3);
					pointTool2.CouplingRelations.Remove(couplingRelation3);
					couplingRelation2.ChangeCoupling(newPoint, pointTool2);
				}
				flag = (pointTool.CouplingRelations.Count == 0);
			}
			if (flag)
			{
				pointTool.Remove(true, true);
			}
			this.pointToolList = this.GetPointsList();
		}

		public string GenerateNameForCabelLine()
		{
			if (this.Type == LineToolType.CabelLine)
			{
				if (this.Ends.Count<PointTool>() == 2)
				{
					string text = string.Empty;
					string text2 = string.Empty;
					int num = 0;
					int num2 = 0;
					if (this.ends[0].Parent != null)
					{
						text = this.ends[0].Parent.Parent.ToString() + " Яч." + this.ends[0].Parent.Text;
						switch (((RectangleTool)this.ends[0].Parent.Parent).TypeRectnagleTool)
						{
						case eTypeRectangleTool.PP:
							num = 1;
							break;
						case eTypeRectangleTool.CP:
							num = 4;
							break;
						case eTypeRectangleTool.RP:
							num = 3;
							break;
						case eTypeRectangleTool.TP:
							num = 2;
							break;
						}
					}
					else
					{
						num = 5;
						if (this.ends[0].Branches.Count<Branch>() > 1)
						{
							foreach (Branch branch in this.ends[0].Branches)
							{
								if (branch.Parent != this)
								{
									LineToolType type = ((LineTool)branch.Parent).Type;
									switch (type)
									{
									case LineToolType.CabelLine:
										text = "КЛ";
										break;
									case LineToolType.AirLine:
										text = "ВЛ";
										break;
									default:
										if (type == LineToolType.AirLineProtected)
										{
											text = "ВЛЗ";
										}
										break;
									}
								}
							}
						}
					}
					if (this.ends[1].Parent != null)
					{
						text2 = this.ends[1].Parent.Parent.ToString() + " Яч." + this.ends[1].Parent.Text;
						switch (((RectangleTool)this.ends[1].Parent.Parent).TypeRectnagleTool)
						{
						case eTypeRectangleTool.PP:
							num2 = 1;
							break;
						case eTypeRectangleTool.CP:
							num2 = 4;
							break;
						case eTypeRectangleTool.RP:
							num2 = 3;
							break;
						case eTypeRectangleTool.TP:
							num2 = 2;
							break;
						}
					}
					else
					{
						num2 = 5;
						if (this.ends[1].Branches.Count<Branch>() > 1)
						{
							foreach (Branch branch2 in this.ends[1].Branches)
							{
								if (branch2.Parent != this)
								{
									LineToolType type2 = ((LineTool)branch2.Parent).Type;
									switch (type2)
									{
									case LineToolType.CabelLine:
										text2 = "КЛ";
										break;
									case LineToolType.AirLine:
										text2 = "ВЛ";
										break;
									default:
										if (type2 == LineToolType.AirLineProtected)
										{
											text2 = "ВЛЗ";
										}
										break;
									}
								}
							}
						}
					}
					if (num == num2)
					{
						if (num == 5)
						{
							return text + " - " + text2;
						}
						if (string.Compare(this.ends[0].Parent.Parent.Text, this.ends[1].Parent.Parent.Text) <= 0)
						{
							return text + " - " + text2;
						}
						return text2 + " - " + text;
					}
					else
					{
						if (num < num2)
						{
							return text + " - " + text2;
						}
						return text2 + " - " + text;
					}
				}
			}
			return string.Empty;
		}

		public List<string> GetDestinations()
		{
			List<string> list = new List<string>();
			base.GetType();
			typeof(LineCellTool);
			foreach (PointTool pointTool in this.ends)
			{
				string text = "";
				if (pointTool.Parent != null && (pointTool.Parent.GetType() == typeof(LineTool) || pointTool.Parent.GetType().BaseType == typeof(LineTool)))
				{
					string text2 = pointTool.Parent.Text;
					string text3 = string.Empty;
					IEnumerable<PointTool> source = ((LineTool)pointTool.Parent).Ends;
					if (LineTool.func_2 == null)
					{
						LineTool.func_2 = new Func<PointTool, bool>(LineTool.smethod_2);
					}
					foreach (PointTool pointTool2 in source.Where(LineTool.func_2))
					{
						if (text3 != string.Empty)
						{
							text3 += "; ";
						}
						text3 += pointTool2.Parent.Text;
					}
					if (pointTool.Parent.Parent != null)
					{
						text = pointTool.Parent.Parent.Text;
					}
					list.Add(string.Concat(new string[]
					{
						"ТП: ",
						text,
						" шина: ",
						text3,
						" ячейка: ",
						text2
					}));
				}
			}
			return list;
		}

		public override string ToString()
		{
			if (this.Text == string.Empty)
			{
				List<string> destinations = this.GetDestinations();
				StringBuilder stringBuilder = new StringBuilder();
				foreach (string str in destinations)
				{
					stringBuilder.Append(str + "; ");
				}
				return stringBuilder.ToString();
			}
			return this.Text;
		}

		public override ISnapPoint SnapPoint(CanvasControl canvas, UnitPoint point, List<DrawObjectBase> otherobj, Type[] runningsnaptypes, Type usersnaptype)
		{
			base.ThresholdWidth(canvas, base.Width);
			foreach (PointTool pointTool in this.pointToolList)
			{
				ISnapPoint snapPoint = pointTool.SnapPoint(canvas, point, otherobj, runningsnaptypes, usersnaptype);
				if (snapPoint != null)
				{
					return snapPoint;
				}
			}
			return null;
		}

		public override void SaveToXML(XmlNode xmlNode, List<PointTool> pointList)
		{
			XmlDocument ownerDocument = xmlNode.OwnerDocument;
			XmlElement xmlElement = ownerDocument.CreateElement("Line");
			xmlElement.SetAttribute("ID", this.IdBase.ToString());
			xmlElement.SetAttribute("text", this.Text);
			xmlElement.SetAttribute("textVis", this.TextProperty.Visible.ToString());
			xmlElement.SetAttribute("textPos", ((int)this.TextProperty.Position).ToString());
			if (!base.UseSettingColor)
			{
				xmlElement.SetAttribute("color", this.Color.Name);
			}
			else
			{
				xmlElement.SetAttribute("color", "");
			}
			xmlNode.AppendChild(xmlElement);
			foreach (Branch branch in this.branches)
			{
				branch.SaveToXML(xmlElement, pointList);
			}
		}

		public override bool HaveContact(DrawObjectBase drawObjectBase_1)
		{
			foreach (PointTool pointTool in this.ends)
			{
				if (pointTool.Parent == drawObjectBase_1)
				{
					return true;
				}
				foreach (Branch branch in pointTool.Branches)
				{
					if (branch.Parent == drawObjectBase_1)
					{
						return true;
					}
				}
			}
			return false;
		}

		public DrawObjectBase GetHitBranch(UnitPoint point)
		{
			foreach (Branch branch in this.branches)
			{
				if (branch.PointInObject(point))
				{
					return branch;
				}
			}
			return null;
		}

		public override void ExportDXF(CanvasControl canvas, Document document)
		{
			foreach (Branch branch in this.Branches)
			{
				Line line = new Line(this.Layer.Name, branch.Source.Point.X, branch.Source.Point.Y, branch.Destination.Point.X, branch.Destination.Point.Y);
				document.add(line);
			}
		}

		public override void ExportDXF(CanvasControl canvas, DxfDocument document)
		{
			foreach (Branch branch in this.Branches)
			{
				Line line = new Line(new Vector2(branch.Source.Point.X, branch.Source.Point.Y), new Vector2(branch.Destination.Point.X, branch.Destination.Point.Y));
				if (branch.Type == BranchType.AirLine)
				{
					line.LineType = LineType.Dashed;
				}
				line.Color = new AciColor(branch.GetCurrentColor());
				document.AddEntity(line);
				branch.Source.ExportDXF(canvas, document);
				branch.Destination.ExportDXF(canvas, document);
			}
		}

		public override List<DrawObjectBase> GetPowerSource()
		{
			List<DrawObjectBase> powerSource = base.GetPowerSource();
			foreach (Amperage amperage in this.Amperages.Values)
			{
				powerSource.AddRange(amperage.GetPowerSource());
			}
			return powerSource;
		}

		public List<DrawObjectBase> GetPowerSource(Branch branch)
		{
			List<DrawObjectBase> powerSource = base.GetPowerSource();
			if (this.branches.Contains(branch) && branch.CouplingRelation != null)
			{
				PointTool amperagePoint = branch.CouplingRelation.amperagePoint;
				if (amperagePoint != null && this.Amperages.ContainsKey(amperagePoint) && this.selectedBranch.CheckVoltageInPoint(this.clickedPoint))
				{
					powerSource.AddRange(this.Amperages[amperagePoint].GetPowerSource());
				}
			}
			return powerSource;
		}

		public override List<DrawObjectBase> GetRecipientsPower()
		{
			if (this.selectedBranch != null && this.Amperages.ContainsKey(this.selectedBranch.CouplingRelation.amperagePoint))
			{
				Amperage amperage_ = this.Amperages[this.selectedBranch.CouplingRelation.amperagePoint];
				List<DrawObjectBase> recipientsPower = base.GetRecipientsPower();
				this.method_7(amperage_, recipientsPower);
				return recipientsPower;
			}
			return base.GetPowerSource();
		}

		public void AddState(LineToolState state)
		{
			if (this.LimitedEditing)
			{
				return;
			}
			this.states.Add(state);
			this.Layer.AddObject(state.Mapping);
			this.Layer.Parent.DoInvalidate(true);
			if (this.lineToolEventHandler_0 != null)
			{
				this.lineToolEventHandler_0(this, new LineToolEventArgs(null, state, null, null, null));
			}
		}

		public void AddState(ObjectOnLine objectOnline)
		{
			if (this.LimitedEditing)
			{
				return;
			}
			if (objectOnline.State == null)
			{
				return;
			}
			this.states.Add(objectOnline.State);
			if (this.lineToolEventHandler_0 != null)
			{
				this.lineToolEventHandler_0(this, new LineToolEventArgs(null, objectOnline.State, null, null, null));
			}
		}

		public void RemoveState(LineToolState state)
		{
			if (this.LimitedEditing)
			{
				return;
			}
			this.states.Remove(state);
			if (state.Mapping != null)
			{
				this.bool_0 = true;
				state.Remove(false);
				this.bool_0 = false;
			}
			if (this.lineToolEventHandler_1 != null)
			{
				this.lineToolEventHandler_1(this, new LineToolEventArgs(null, state, null, null, null));
			}
			this.Layer.Parent.DoInvalidate(true);
		}

		public DrawObjectBase ParRectangle()
		{
			if (base.GetType() == typeof(LineCellTool))
			{
				return this.Parent;
			}
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (PointTool pointTool in this.Ends)
			{
				if (pointTool.Parent == null || pointTool.Parent.GetType() != typeof(LineCellTool))
				{
					return null;
				}
				list.Add(pointTool.Parent.Parent);
			}
			if (list.Count > 1)
			{
				DrawObjectBase drawObjectBase = list[0];
				foreach (DrawObjectBase drawObjectBase2 in list)
				{
					if (drawObjectBase2 != drawObjectBase)
					{
						return null;
					}
				}
				return drawObjectBase;
			}
			return null;
		}

		public void ClearStates()
		{
			if (this.LimitedEditing)
			{
				return;
			}
			this.states.Clear();
		}

		public BranchCollection GetWayOnLineTool(PointTool pointTool_0, PointTool pointTool_1)
		{
			if (!this.ends.Contains(pointTool_0) && !this.ends.Contains(pointTool_1))
			{
				return null;
			}
			BranchCollection branchCollection = new BranchCollection();
			List<CouplingRelation> list = new List<CouplingRelation>();
			this.getRelationWay(pointTool_0, pointTool_1, null, list);
			foreach (CouplingRelation couplingRelation in list)
			{
				branchCollection.AddRange(couplingRelation.Branches);
			}
			return branchCollection;
		}

		public bool getRelationWay(PointTool pointTool_0, PointTool destination, CouplingRelation oldRelation, List<CouplingRelation> crList)
		{
			bool flag = false;
			foreach (CouplingRelation couplingRelation in pointTool_0.CouplingRelations)
			{
				if (couplingRelation.Branches.Count != 0 && couplingRelation != oldRelation && couplingRelation.Line == this)
				{
					PointTool pointTool = (couplingRelation.Vertex1 == pointTool_0) ? couplingRelation.Vertex2 : couplingRelation.Vertex1;
					if (pointTool == destination)
					{
						flag = true;
					}
					else if (this.getRelationWay(pointTool, destination, couplingRelation, crList))
					{
						flag = true;
					}
					if (flag)
					{
						crList.Add(couplingRelation);
						break;
					}
				}
			}
			return flag;
		}

		private void method_7(Amperage amperage_0, List<DrawObjectBase> list_1)
		{
			list_1.Add(amperage_0.Conductor);
			foreach (Amperage amperage_ in amperage_0.NextAmperages)
			{
				this.method_7(amperage_, list_1);
			}
		}

		protected CouplingRelation CreateRelation(PointTool pointTool_0, PointTool dest)
		{
			if (pointTool_0.GetType() != typeof(PointShinaTool) && pointTool_0.TypePoint != TypePointTool.Coupling)
			{
				pointTool_0.TypePoint = TypePointTool.Coupling;
			}
			if (dest.GetType() != typeof(PointShinaTool) && dest.TypePoint != TypePointTool.Coupling)
			{
				dest.TypePoint = TypePointTool.Coupling;
			}
			CouplingRelation couplingRelation = new CouplingRelation(pointTool_0, dest);
			couplingRelation.Line = this;
			this.couplingRelations.Add(couplingRelation);
			return couplingRelation;
		}

		protected void CreateCoupling(PointTool newCouping)
		{
			newCouping.TypePoint = TypePointTool.Coupling;
		}

		protected void ChangeCoupling(PointTool oldCoupling, PointTool newCoupling)
		{
			if (this.LimitedEditing)
			{
				return;
			}
			oldCoupling.TypePoint = TypePointTool.Point;
			newCoupling.TypePoint = TypePointTool.Coupling;
			while (oldCoupling.CouplingRelations.Count > 0)
			{
				CouplingRelation couplingRelation = oldCoupling.CouplingRelations[0];
				if (couplingRelation.Vertex1 != newCoupling)
				{
					if (couplingRelation.Vertex2 != newCoupling)
					{
						couplingRelation.ChangeCoupling(oldCoupling, newCoupling);
						continue;
					}
				}
				this.DeleteCouplingRelation(couplingRelation);
				oldCoupling.CouplingRelations.Remove(couplingRelation);
				newCoupling.CouplingRelations.Remove(couplingRelation);
			}
		}

		protected void DeleteCouplingRelation(CouplingRelation coupingRelation)
		{
			if (this.LimitedEditing)
			{
				return;
			}
			this.couplingRelations.Remove(coupingRelation);
		}

		protected void DeleteCouping(PointTool oldCouping)
		{
			oldCouping.TypePoint = TypePointTool.Point;
		}

		public void AddPointTool()
		{
			PointTool pointTool = new PointTool(Class88.smethod_5(this.selectedBranch.Source.Point, this.selectedBranch.Destination.Point, this.clickedPoint));
			PointTool destination = this.selectedBranch.Destination;
			destination.RemoveBranch(this.selectedBranch);
			this.selectedBranch.Destination = pointTool;
			pointTool.AddBranch(this.selectedBranch);
			Branch branch = new Branch(this, pointTool, destination);
			branch.CouplingRelation = this.selectedBranch.CouplingRelation;
			branch.Type = this.selectedBranch.Type;
			this.selectedBranch = null;
			this.selectedPoint = pointTool;
			pointTool.Layer = this.Layer;
			this.pointToolList = this.GetPointsList();
			this.RecalcAmperage();
			this.Layer.Parent.DoInvalidate(true);
		}

		public PointTool GetPointDeputy(PointTool point)
		{
			if (this.ends.Contains(point))
			{
				using (IEnumerator<Branch> enumerator = point.Branches.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Branch branch = enumerator.Current;
						if (branch.Parent == this)
						{
							return (point == branch.Source) ? branch.Destination : branch.Source;
						}
					}
					goto IL_D4;
				}
			}
			foreach (Branch branch2 in point.Branches)
			{
				if (branch2.Parent == this)
				{
					PointTool pointTool = (point == branch2.Source) ? branch2.Destination : branch2.Source;
					if (!this.ends.Contains(pointTool) || point.CouplingRelations.Count == 0)
					{
						return pointTool;
					}
				}
			}
			IL_D4:
			return null;
		}

		public void RemovePointTool(PointTool removedPoint)
		{
			if (this.LimitedEditing && removedPoint.CouplingRelations.Count != 0)
			{
				return;
			}
			if (this.branches.Count == 1)
			{
				this.Remove(true, true);
				return;
			}
			PointTool pointDeputy = this.GetPointDeputy(removedPoint);
			if (pointDeputy == null)
			{
				return;
			}
			Branch branch = null;
			foreach (Branch branch2 in removedPoint.Branches)
			{
				if (pointDeputy.Branches.Contains(branch2))
				{
					branch = branch2;
					break;
				}
			}
			if (branch == null)
			{
				throw new Exception("Данный случай не предусмотрен (отсутствует ветка принадлежащая данной точке и точке-заменителю) , ищи ошибки");
			}
			if (branch.ChildObjects.Count<DrawObjectBase>() > 0)
			{
				if (!this.ends.Contains(removedPoint) && removedPoint.Branches.Count<Branch>() == 2)
				{
					foreach (Branch branch3 in removedPoint.Branches)
					{
						if (branch3 != branch)
						{
							for (int i = branch.ChildObjects.Count<DrawObjectBase>(); i > 0; i--)
							{
								branch.ChildObjects.First<DrawObjectBase>().Parent = branch3;
							}
						}
					}
				}
				if (pointDeputy.Branches.Count<Branch>() == 2)
				{
					foreach (Branch branch4 in pointDeputy.Branches)
					{
						if (branch4 != branch)
						{
							for (int j = branch.ChildObjects.Count<DrawObjectBase>(); j > 0; j--)
							{
								branch.ChildObjects.First<DrawObjectBase>().Parent = branch4;
							}
						}
					}
				}
			}
			if (removedPoint.CouplingRelations.Count == 0)
			{
				if (removedPoint.BranchesCount != 2)
				{
					throw new Exception("В данном случае у точки не может быть более двух бренчей, ищи ошибки");
				}
				if (branch.Parent != this)
				{
					throw new Exception("Данный случай не предусмотрен (точка лежит по среди линии но у неё есть не принадлежащие ей ветки, или же она на конце линии, но к ней не прицеплена ни одна связь) , ищи ошибки");
				}
				branch.CouplingRelation = null;
				pointDeputy.RemoveBranch(branch);
				removedPoint.RemoveBranch(branch);
				this.Branches.Remove(branch);
				branch.Remove(true, true);
				branch = removedPoint.Branches.First<Branch>();
				if (branch.Parent != this)
				{
					throw new Exception("Данный случай не предусмотрен (точка лежит по среди линии но у неё есть не принадлежащие ей ветки, или же она на конце линии, но к ней не прицеплена ни одна связь) , ищи ошибки");
				}
				if (branch.Source == removedPoint)
				{
					branch.Source = pointDeputy;
				}
				else
				{
					if (branch.Destination != removedPoint)
					{
						throw new Exception("Данный случай не предусмотрен (ветка принадлежит точке, но точка к ней ни как не относится) , ищи ошибки");
					}
					branch.Destination = pointDeputy;
				}
				pointDeputy.AddBranch(branch);
			}
			else if (this.ends.Contains(removedPoint))
			{
				bool flag = false;
				foreach (CouplingRelation couplingRelation in pointDeputy.CouplingRelations)
				{
					if (couplingRelation == branch.CouplingRelation)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					branch.CouplingRelation.RemoveRelation();
					if (pointDeputy.CouplingRelations.Count == 2)
					{
						CouplingRelation couplingRelation2 = pointDeputy.CouplingRelations[0];
						if (pointDeputy != couplingRelation2.Vertex1)
						{
							PointTool vertex = couplingRelation2.Vertex1;
						}
						else
						{
							PointTool vertex2 = couplingRelation2.Vertex2;
						}
						PointTool newp = (pointDeputy == pointDeputy.CouplingRelations[1].Vertex1) ? pointDeputy.CouplingRelations[1].Vertex2 : pointDeputy.CouplingRelations[1].Vertex1;
						while (pointDeputy.CouplingRelations[1].Branches.Count > 0)
						{
							Branch branch5 = pointDeputy.CouplingRelations[1].Branches[0];
							branch5.CouplingRelation = couplingRelation2;
						}
						pointDeputy.CouplingRelations[1].RemoveRelation();
						couplingRelation2.ChangeCoupling(pointDeputy, newp);
						pointDeputy.DeleteSql();
						if (pointDeputy.IdBase != 0)
						{
							pointDeputy.IdBase = 0;
						}
					}
				}
				else
				{
					branch.CouplingRelation.ChangeCoupling(removedPoint, pointDeputy);
					branch.CouplingRelation = null;
				}
				pointDeputy.RemoveBranch(branch);
				removedPoint.RemoveBranch(branch);
				this.ends.Remove(removedPoint);
				bool flag2 = pointDeputy.Branches.Count<Branch>() == 1;
				int num = 0;
				if (!flag2)
				{
					foreach (Branch branch6 in pointDeputy.Branches)
					{
						if (branch6.Parent == this)
						{
							num++;
						}
						if (num > 1)
						{
							flag2 = true;
							break;
						}
					}
				}
				if (flag2)
				{
					this.ends.Add(pointDeputy);
				}
				this.Branches.Remove(branch);
				branch.Remove(true, true);
				if (removedPoint.Parent == this)
				{
					removedPoint.Parent = null;
					pointDeputy.Parent = this;
				}
				if (this.Amperages.ContainsKey(removedPoint))
				{
					this.Amperages[removedPoint].OffAmperage();
				}
				else
				{
					foreach (Branch branch7 in removedPoint.Branches)
					{
						if (branch7.CouplingRelation.amperagePoint == removedPoint)
						{
							foreach (Amperage amperage in ((LineTool)branch7.Parent).Amperages[removedPoint].Mediators)
							{
								if (amperage.Conductor == this)
								{
									((LineTool)branch7.Parent).Amperages[removedPoint].OffAmperage();
								}
								if (!((LineTool)branch7.Parent).Amperages.ContainsKey(removedPoint))
								{
									break;
								}
							}
						}
					}
					if (removedPoint.Parent != null && removedPoint.Parent.GetType() == typeof(ShinaTool))
					{
						((ShinaTool)removedPoint.Parent).Amperage.OffAmperage();
					}
				}
			}
			else
			{
				branch.CouplingRelation.ChangeCoupling(removedPoint, pointDeputy);
				branch.CouplingRelation = null;
				pointDeputy.RemoveBranch(branch);
				removedPoint.RemoveBranch(branch);
				this.Branches.Remove(branch);
				branch.Remove(true, true);
				foreach (Branch branch8 in removedPoint.Branches)
				{
					if (branch8.Source == removedPoint)
					{
						branch8.Source = pointDeputy;
						branch8.ReCalcSwitchCoords(branch8.Destination.Point, removedPoint.Point, pointDeputy.Point);
					}
					else
					{
						if (branch8.Destination != removedPoint)
						{
							throw new Exception("Данный случай не предусмотрен (ветка принадлежит точке, но точка к ней ни как не относится) , ищи ошибки");
						}
						branch8.Destination = pointDeputy;
						branch8.ReCalcSwitchCoords(branch8.Source.Point, removedPoint.Point, pointDeputy.Point);
					}
					pointDeputy.AddBranch(branch8);
					branch8.CouplingRelation.ChangeCoupling(removedPoint, pointDeputy);
				}
				if (pointDeputy.CouplingRelations.Count == 2)
				{
					CouplingRelation couplingRelation3 = pointDeputy.CouplingRelations[0];
					if (pointDeputy != couplingRelation3.Vertex1)
					{
						PointTool vertex3 = couplingRelation3.Vertex1;
					}
					else
					{
						PointTool vertex4 = couplingRelation3.Vertex2;
					}
					PointTool newp2 = (pointDeputy == pointDeputy.CouplingRelations[1].Vertex1) ? pointDeputy.CouplingRelations[1].Vertex2 : pointDeputy.CouplingRelations[1].Vertex1;
					while (pointDeputy.CouplingRelations[1].Branches.Count > 0)
					{
						Branch branch9 = pointDeputy.CouplingRelations[1].Branches[0];
						branch9.CouplingRelation = couplingRelation3;
					}
					pointDeputy.CouplingRelations[1].RemoveRelation();
					couplingRelation3.ChangeCoupling(pointDeputy, newp2);
					pointDeputy.DeleteSql();
				}
			}
			if (this.IdBase > 0)
			{
				this.SaveToSql(false, true);
			}
			if (removedPoint.IdBase > 0 && removedPoint.CouplingRelations.Count == 0)
			{
				removedPoint.Remove(true, false);
			}
			removedPoint = null;
			this.pointToolList = this.GetPointsList();
			this.Layer.Parent.DoInvalidate(true);
		}

		protected void DevideRelation(CouplingRelation couplingRelation, PointTool pointTool)
		{
			if (couplingRelation.Branches.Count < 2)
			{
				throw new Exception("в связи одна ветка");
			}
			bool flag = false;
			foreach (Branch branch in couplingRelation.Branches)
			{
				if (branch.Source != pointTool)
				{
					if (branch.Destination != pointTool)
					{
						continue;
					}
				}
				flag = true;
				break;
			}
			if (!flag)
			{
				throw new Exception("точка не принадлежит связи");
			}
			LineTool line = couplingRelation.Line;
			Branch branch2 = pointTool[0];
			PointTool pointTool2 = (pointTool == branch2.Source) ? branch2.Destination : branch2.Source;
			List<Branch> list = new List<Branch>();
			list.Add(branch2);
			while (pointTool2 != couplingRelation.Vertex2)
			{
				if (pointTool2 == couplingRelation.Vertex1)
				{
					break;
				}
				if (pointTool2.BranchesCount > 2)
				{
					throw new Exception("Неожиданная ошибка: У точки больше 2-х соурсов, но конец связи ещё не найден :(");
				}
				foreach (Branch branch3 in pointTool2.Branches)
				{
					if (branch3 != branch2)
					{
						branch2 = branch3;
						break;
					}
				}
				pointTool2 = ((pointTool2 == branch2.Source) ? branch2.Destination : branch2.Source);
				list.Add(branch2);
				if (list.Count >= ((LineTool)branch2.Parent).Branches.Count)
				{
					throw new Exception("Совсем неожиданная ошибка: точка-путешественница не нашла себя связи :'(");
				}
			}
			couplingRelation.ChangeCoupling(pointTool2, pointTool);
			CouplingRelation couplingRelation2 = this.CreateRelation(pointTool, pointTool2);
			foreach (Branch branch4 in list)
			{
				branch4.CouplingRelation = couplingRelation2;
			}
		}

		private void method_8(object sender, EventArgs e)
		{
			this.ShowPropertyForm(((ToolStripMenuItem)sender).GetCurrentParent().Location);
		}

		public override bool ShowPropertyForm(Point location)
		{
			if (new LinePropertyesForm(this)
			{
				Location = location
			}.ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
				return true;
			}
			return false;
		}

		private void method_9(object sender, EventArgs e)
		{
			BranchPropertyesForm branchPropertyesForm = new BranchPropertyesForm(this.selectedBranch);
			if (branchPropertyesForm.ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
			}
		}

		private void method_10(PointTool pointTool_0, Branch branch_0, List<PointTool> list_1)
		{
			if (list_1.Contains(pointTool_0))
			{
				return;
			}
			list_1.Add(pointTool_0);
			foreach (DrawObjectBase drawObjectBase in pointTool_0.Branches)
			{
				if (drawObjectBase.GetType() == typeof(Branch) && (Branch)drawObjectBase != branch_0 && ((Branch)drawObjectBase).Parent == this)
				{
					if (((Branch)drawObjectBase).Destination == pointTool_0)
					{
						this.method_10(((Branch)drawObjectBase).Source, (Branch)drawObjectBase, list_1);
					}
					else if (((Branch)drawObjectBase).Source == pointTool_0)
					{
						this.method_10(((Branch)drawObjectBase).Destination, (Branch)drawObjectBase, list_1);
					}
				}
			}
		}

		public void AddAmperage(PointTool amperagePoint, Amperage amperage)
		{
			if (this.Amperages.ContainsKey(amperagePoint))
			{
				using (IEnumerator<Amperage> enumerator = amperage.Mediators.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Amperage amperage2 = enumerator.Current;
						if (!this.Amperages[amperagePoint].Mediators.Contains(amperage2))
						{
							this.Amperages[amperagePoint].AddMediator(amperage2);
							amperage2.NextAmperages.Add(this.Amperages[amperagePoint]);
							amperage2.NextAmperages.Remove(amperage);
						}
					}
					goto IL_9A;
				}
			}
			this.Amperages.Add(amperagePoint, amperage);
			this.RecalcAmperage();
			IL_9A:
			if (this.lineToolEventHandler_2 != null)
			{
				this.lineToolEventHandler_2(this, new LineToolEventArgs(amperagePoint, null, null, null, null));
			}
		}

		public bool RemoveAmperage(Amperage amperage)
		{
			foreach (PointTool pointTool in this.Amperages.Keys)
			{
				if (this.Amperages[pointTool] == amperage)
				{
					this.Amperages.Remove(pointTool);
					foreach (CouplingRelation couplingRelation in this.CouplingRelations)
					{
						if (couplingRelation.amperagePoint == pointTool)
						{
							couplingRelation.amperagePoint = null;
						}
					}
					this.RecalcAmperage();
					if (this.lineToolEventHandler_3 != null)
					{
						this.lineToolEventHandler_3(this, new LineToolEventArgs(pointTool, null, null, null, null));
					}
					return true;
				}
			}
			return false;
		}

		public Amperage ConteinAmperage(DrawObjectBase mediator)
		{
			foreach (PointTool key in this.Amperages.Keys)
			{
				if (this.Amperages[key].Mediators == mediator)
				{
					return this.Amperages[key];
				}
			}
			return null;
		}

		public void RcA()
		{
			this.RecalcAmperage();
		}

		internal override void RecalcAmperage()
		{
			int i = 0;
			List<PointTool> list = this.Amperages.Keys.ToList<PointTool>();
			while (i < list.Count)
			{
				PointTool pointTool_ = list[i++];
				this.method_11(pointTool_);
			}
		}

		internal void method_11(PointTool pointTool_0)
		{
			if (pointTool_0 != null)
			{
				this.method_12(pointTool_0, null, pointTool_0);
			}
		}

		private void method_12(PointTool pointTool_0, CouplingRelation couplingRelation_0, PointTool pointTool_1)
		{
			Amperage amperage = this.Amperages[pointTool_1];
			if (this.ends.Contains(pointTool_0) && couplingRelation_0 != null)
			{
				if (pointTool_0.CouplingRelations.Count > 1)
				{
					using (List<CouplingRelation>.Enumerator enumerator = pointTool_0.CouplingRelations.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							CouplingRelation couplingRelation = enumerator.Current;
							if (couplingRelation.Line != this && couplingRelation.Line.Layer != null && couplingRelation.Line != amperage.Mediators)
							{
								if (!couplingRelation.Line.Amperages.ContainsKey(pointTool_0) && couplingRelation.amperagePoint == null)
								{
									Amperage amperage2 = amperage.PassOn(couplingRelation.Line);
									if (amperage2 != null)
									{
										couplingRelation.Line.AddAmperage(pointTool_0, amperage2);
									}
								}
								else if (couplingRelation.amperagePoint != null && couplingRelation.Line.Amperages[couplingRelation.amperagePoint].Source == amperage.Source && couplingRelation.Line.Layer != null && !amperage.PowerSourceConteins(couplingRelation.Line))
								{
									Amperage amperage3 = amperage.PassOn(couplingRelation.Line);
									if (amperage3 != null)
									{
										couplingRelation.Line.AddAmperage(pointTool_0, amperage3);
									}
								}
							}
						}
						goto IL_205;
					}
				}
				if (pointTool_0.Parent != null && pointTool_0.Parent.Layer != null && pointTool_0.Parent.GetType() != typeof(LineCellTool) && amperage.Mediators != pointTool_0.Parent)
				{
					if (((ShinaTool)pointTool_0.Parent).Amperage == null)
					{
						Amperage amperage4 = amperage.PassOn(pointTool_0.Parent);
						if (amperage4 != null)
						{
							((ShinaTool)pointTool_0.Parent).Amperage = amperage4;
						}
					}
					else if (((ShinaTool)pointTool_0.Parent).Amperage.Mediators != this && ((ShinaTool)pointTool_0.Parent).Amperage.Source != amperage.Source)
					{
						this.Layer.Parent.SendMessage(this, "Не предусмотренное замыкание в цепи.", eMessageType.Warning);
					}
				}
			}
			IL_205:
			foreach (CouplingRelation couplingRelation2 in pointTool_0.CouplingRelations)
			{
				if (couplingRelation2.Line == this && couplingRelation2.Line != amperage.Mediators && couplingRelation2 != couplingRelation_0)
				{
					List<DrawObjectBase> noise = couplingRelation2.GetNoise();
					PointTool pointTool = (pointTool_0 == couplingRelation2.Vertex1) ? couplingRelation2.Vertex2 : couplingRelation2.Vertex1;
					if (this.Amperages.ContainsKey(pointTool) && couplingRelation2.amperagePoint == pointTool && couplingRelation2.On)
					{
						if (this.Amperages[pointTool].Source != amperage.Source)
						{
							this.Layer.Parent.SendMessage(this, "короткое замыкание (встреча с другим тока в одной не разомкнутой линии)", eMessageType.Error);
						}
						else
						{
							this.method_12(pointTool, couplingRelation2, pointTool_1);
						}
					}
					else if (couplingRelation2.amperagePoint == null)
					{
						couplingRelation2.amperagePoint = pointTool_1;
						foreach (DrawObjectBase drawObjectBase in noise)
						{
							if (drawObjectBase.GetType() == typeof(GroundingTool))
							{
								GroundingTool groundingTool = (GroundingTool)drawObjectBase;
								if (((Branch)groundingTool.Parent).CheckVoltageInPoint(groundingTool.CenterPoint))
								{
									this.Layer.Parent.SendMessage(this, "заземлённый проводник", eMessageType.Error);
								}
							}
						}
						if (couplingRelation2.On)
						{
							this.method_12(pointTool, couplingRelation2, pointTool_1);
						}
					}
					else if (couplingRelation2.On && couplingRelation2.amperagePoint == pointTool_1)
					{
						this.method_12(pointTool, couplingRelation2, pointTool_1);
					}
				}
			}
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(this.Type);
		}

		public override bool SaveToSql(bool isbackground, bool children)
		{
			if (base.SaveToSql(isbackground, false))
			{
				if (children)
				{
					foreach (Branch branch in this.Branches)
					{
						foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
						{
							drawObjectBase.SaveToSql(isbackground, children);
						}
					}
				}
				this.SaveToSql();
				return true;
			}
			return false;
		}

		protected override bool SaveToSql()
		{
			if (!base.SaveToSql())
			{
				return false;
			}
			if (this.IdBase <= 0)
			{
				return true;
			}
			this.method_13();
			this.UpdateXML();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.Layer.Parent.SqlSettings);
			DataSetScheme dataSetScheme = new DataSetScheme();
			string text = " where ObjId = " + this.IdBase.ToString() + " AND TypeSchema = " + ((int)this.Layer.Parent.TypeCanvas).ToString();
			RectangleTool rectangleTool = null;
			if (this.Layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
			{
				foreach (DrawObjectBase drawObjectBase in this.Layer.Objects)
				{
					if (drawObjectBase is RectangleTool)
					{
						rectangleTool = (RectangleTool)drawObjectBase;
						break;
					}
				}
			}
			if (rectangleTool != null)
			{
				text = text + " AND (Tag = " + rectangleTool.IdBase.ToString() + " OR Tag is NULL)";
			}
			sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Xml, false, text);
			if (dataSetScheme.tSchm_Xml.Rows.Count > 0)
			{
				dataSetScheme.tSchm_Xml.Rows[0]["SchemaXml"] = this.xmlCoords.InnerXml;
				if (dataSetScheme.tSchm_Xml.Rows[0]["Tag"] == null && rectangleTool != null)
				{
					dataSetScheme.tSchm_Xml.Rows[0]["Tag"] = rectangleTool.IdBase;
				}
				dataSetScheme.tSchm_Xml.Rows[0].EndEdit();
				return sqlDataCommand.UpdateSqlData(dataSetScheme, dataSetScheme.tSchm_Xml);
			}
			dataSetScheme.tSchm_Xml.method_1(this.IdBase, (int)this.Layer.Parent.TypeCanvas, this.xmlCoords.InnerXml);
			return sqlDataCommand.InsertSqlData(dataSetScheme, dataSetScheme.tSchm_Xml);
		}

		private void method_13()
		{
			foreach (CouplingRelation couplingRelation in this.couplingRelations)
			{
				couplingRelation.Vertex1.SaveToSql(false, false);
				couplingRelation.Vertex2.SaveToSql(false, false);
				SqlDataCommand sqlDataCommand = new SqlDataCommand(this.Layer.Parent.SqlSettings);
				DataSetScheme dataSetScheme = new DataSetScheme();
				if (couplingRelation.Id > 0)
				{
					sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Relation, false, "where id = " + couplingRelation.Id.ToString());
					if (dataSetScheme.tSchm_Relation.Rows.Count > 0)
					{
						bool flag = false;
						if ((int)dataSetScheme.tSchm_Relation.Rows[0]["SourceObj"] != couplingRelation.Vertex1.IdBase)
						{
							dataSetScheme.tSchm_Relation.Rows[0]["SourceObj"] = couplingRelation.Vertex1.IdBase;
							flag = true;
						}
						if ((int)dataSetScheme.tSchm_Relation.Rows[0]["DestObj"] != couplingRelation.Vertex2.IdBase)
						{
							dataSetScheme.tSchm_Relation.Rows[0]["DestObj"] = couplingRelation.Vertex2.IdBase;
							flag = true;
						}
						if ((int)dataSetScheme.tSchm_Relation.Rows[0]["Edge"] != this.IdBase)
						{
							dataSetScheme.tSchm_Relation.Rows[0]["Edge"] = this.IdBase;
							flag = true;
						}
						if (flag)
						{
							dataSetScheme.tSchm_Relation.Rows[0].EndEdit();
							sqlDataCommand.UpdateSqlData(dataSetScheme, dataSetScheme.tSchm_Relation);
						}
					}
				}
				else
				{
					DataRow dataRow = dataSetScheme.tSchm_Relation.NewRow();
					dataRow["SourceObj"] = couplingRelation.Vertex1.IdBase;
					dataRow["DestObj"] = couplingRelation.Vertex2.IdBase;
					dataRow["Edge"] = this.IdBase;
					dataSetScheme.tSchm_Relation.Rows.Add(dataRow);
					couplingRelation.Id = sqlDataCommand.InsertSqlDataOneRow(dataSetScheme, dataSetScheme.tSchm_Relation);
				}
			}
		}

		private void method_14(DrawObjectBase drawObjectBase_1)
		{
			int num = 1;
			foreach (CouplingRelation couplingRelation in this.couplingRelations)
			{
				int num2 = 0;
				if (drawObjectBase_1 != couplingRelation.Vertex1 && int.TryParse(couplingRelation.Vertex1.Text, out num2) && num <= num2)
				{
					num = num2 + 1;
				}
				if (drawObjectBase_1 != couplingRelation.Vertex2 && int.TryParse(couplingRelation.Vertex2.Text, out num2) && num <= num2)
				{
					num = num2 + 1;
				}
			}
			drawObjectBase_1.Text = num.ToString();
		}

		private void method_15(PointTool pointTool_0)
		{
			if (this.IdBase <= 0)
			{
				throw new Exception("Нет ID у линии");
			}
			DataSet dataSet = new DataSet();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.Layer.Parent.SqlSettings);
			if (pointTool_0.IdBase <= 0)
			{
				int num;
				if (!int.TryParse(pointTool_0.Text, out num))
				{
					this.method_14(pointTool_0);
				}
				int? num2 = null;
				if (pointTool_0.GetType() == typeof(PointShinaTool))
				{
					if (pointTool_0.Parent != null && pointTool_0.Parent.GetType() == typeof(ShinaTool) && pointTool_0.Parent.IdBase > 0)
					{
						num2 = new int?(pointTool_0.Parent.IdBase);
					}
				}
				else if (pointTool_0.Parent == null && this.IdBase > 0)
				{
					num2 = new int?(this.IdBase);
				}
				else if (pointTool_0.Parent.GetType() == typeof(LineCellTool) && pointTool_0.Parent != null && pointTool_0.Parent.GetType() == typeof(LineCellTool) && pointTool_0.Parent.IdBase > 0)
				{
					num2 = new int?(pointTool_0.Parent.IdBase);
				}
				if (num2 == null)
				{
					sqlDataCommand.SelectSqlData(dataSet, "tSchm_Point", true, " where name = '" + pointTool_0.Text + "' and ParentId is null and ParentLine = " + this.IdBase.ToString());
				}
				else
				{
					sqlDataCommand.SelectSqlData(dataSet, "tSchm_Point", true, string.Concat(new string[]
					{
						" where name = '",
						pointTool_0.Text,
						"' and ParentId = ",
						num2.ToString(),
						" and ParentLine = ",
						this.IdBase.ToString()
					}));
				}
				DataColumn[] primaryKey = new DataColumn[]
				{
					dataSet.Tables["tSchm_Point"].Columns["id"]
				};
				dataSet.Tables["tSchm_Point"].PrimaryKey = primaryKey;
				dataSet.Tables["tSchm_Point"].Columns["Id"].AutoIncrement = true;
				if (dataSet.Tables["tSchm_Point"].Rows.Count == 0)
				{
					DataRow dataRow = dataSet.Tables["tSchm_Point"].NewRow();
					dataRow["Name"] = pointTool_0.Text;
					if (this.Parent != null)
					{
						dataRow["ParentId"] = num2;
					}
					dataRow["ParentLine"] = this.IdBase;
					dataSet.Tables["tSchm_Point"].Rows.Add(dataRow);
					pointTool_0.IdBase = sqlDataCommand.InsertSqlDataOneRow(dataSet, dataSet.Tables["tSchm_Point"]);
					pointTool_0.SaveToSql(false, false);
				}
				else
				{
					pointTool_0.IdBase = Convert.ToInt32(dataSet.Tables["tSchm_Point"].Rows[0]["Id"]);
				}
				if (pointTool_0.GetType() == typeof(PointShinaTool) && pointTool_0.Parent != null && pointTool_0.Parent.GetType() == typeof(ShinaTool) && pointTool_0.Parent.IdBase > 0)
				{
					pointTool_0.Parent.SaveToSql(false, false);
				}
			}
		}

		public override string GetUpdateScriptXML(bool children, List<int> list_1)
		{
			if (this.IdBase <= 0)
			{
				return "";
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (CouplingRelation couplingRelation in this.CouplingRelations)
			{
				stringBuilder.Append(couplingRelation.Vertex1.GetUpdateScriptXML(false, list_1));
				stringBuilder.Append(couplingRelation.Vertex2.GetUpdateScriptXML(false, list_1));
			}
			this.UpdateXML();
			string text = " update tSChm_Xml set [SchemaXml] = ' " + this.xmlCoords.InnerXml + "'";
			RectangleTool rectangleTool = null;
			if (this.Layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
			{
				foreach (DrawObjectBase drawObjectBase in this.Layer.Objects)
				{
					if (drawObjectBase is RectangleTool)
					{
						rectangleTool = (RectangleTool)drawObjectBase;
						break;
					}
				}
			}
			if (rectangleTool != null)
			{
				text = text + ", [Tag] = " + rectangleTool.IdBase.ToString();
			}
			string text2 = text;
			text = string.Concat(new string[]
			{
				text2,
				" where Objid = ",
				this.IdBase.ToString(),
				" AND TypeSchema = ",
				((int)this.Layer.Parent.TypeCanvas).ToString()
			});
			if (rectangleTool != null)
			{
				text = text + " AND (Tag = " + rectangleTool.IdBase.ToString() + " OR Tag is NULL)";
			}
			if (list_1.Contains(this.IdBase))
			{
				text = "";
			}
			else
			{
				list_1.Add(this.IdBase);
			}
			return " " + stringBuilder + text;
		}

		protected override void UpdateXML()
		{
			base.UpdateXML();
			if (this.TextProperty.Visible)
			{
				((XmlElement)this.currentXmlScheme).SetAttribute("textVis", this.TextProperty.Visible.ToString());
				((XmlElement)this.currentXmlScheme).SetAttribute("textPos", ((int)this.TextProperty.Position).ToString());
			}
			if (this.LimitedEditing)
			{
				((XmlElement)this.currentXmlScheme).SetAttribute("limEd", this.LimitedEditing.ToString());
			}
			List<PointTool> pointsList = this.GetPointsList();
			XmlElement xmlElement = this.xmlCoords.CreateElement("Points");
			this.currentXmlScheme.AppendChild(xmlElement);
			bool flag = true;
			foreach (PointTool pointTool in pointsList)
			{
				XmlElement xmlElement2 = this.xmlCoords.CreateElement("Point");
				xmlElement.AppendChild(xmlElement2);
				if (pointTool.IdBase <= 0)
				{
					xmlElement2.SetAttribute("X", Math.Round(pointTool.Point.X, 4).ToString(new CultureInfo(1033)));
					xmlElement2.SetAttribute("Y", Math.Round(pointTool.Point.Y, 4).ToString(new CultureInfo(1033)));
					if (pointTool.TextProperty.Visible)
					{
						xmlElement2.SetAttribute("text", pointTool.Text);
						xmlElement2.SetAttribute("textVis", pointTool.TextProperty.Visible.ToString());
						xmlElement2.SetAttribute("textPos", ((int)pointTool.TextProperty.Position).ToString());
						if (!pointTool.UseSettingsText)
						{
							xmlElement2.SetAttribute("FontColor", pointTool.TextProperty.Color.ToArgb().ToString());
						}
					}
				}
				else
				{
					xmlElement2.SetAttribute("ID", pointTool.IdBase.ToString());
				}
				if (pointTool.TextProperty.Visible && flag)
				{
					int idBase = pointTool.IdBase;
					((XmlElement)this.currentXmlScheme).SetAttribute("textPoint", idBase.ToString());
					flag = false;
				}
			}
			foreach (Branch branch in this.branches)
			{
				XmlElement xmlElement3 = this.xmlCoords.CreateElement("Branch");
				xmlElement3.SetAttribute("Type", ((int)branch.Type).ToString());
				xmlElement3.SetAttribute("srcID", pointsList.IndexOf(branch.Source).ToString());
				xmlElement3.SetAttribute("destID", pointsList.IndexOf(branch.Destination).ToString());
				if (branch.CouplingRelation != null)
				{
					xmlElement3.SetAttribute("relationId", branch.CouplingRelation.Id.ToString());
				}
				this.currentXmlScheme.AppendChild(xmlElement3);
				foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
				{
					if (drawObjectBase is TextBranchTool)
					{
						XmlElement xmlElement4 = this.xmlCoords.CreateElement("textBranch");
						xmlElement4.SetAttribute("delta", Math.Round((double)((TextBranchTool)drawObjectBase).Delta, 4).ToString(new CultureInfo(1033)));
						xmlElement4.SetAttribute("direct", ((TextBranchTool)drawObjectBase).Direct.ToString());
						xmlElement4.SetAttribute("text", ((TextBranchTool)drawObjectBase).Text);
						xmlElement4.SetAttribute("type", ((int)((TextBranchTool)drawObjectBase).Type).ToString());
						xmlElement4.SetAttribute("TextPos", ((int)drawObjectBase.TextProperty.Position).ToString());
						xmlElement4.SetAttribute("Passport", ((TextBranchTool)drawObjectBase).Passport.ToString());
						if (!drawObjectBase.UseSettingColor)
						{
							xmlElement4.SetAttribute("Color", drawObjectBase.Color.ToArgb().ToString());
						}
						if (!drawObjectBase.UseSettingsText)
						{
							xmlElement4.SetAttribute("FontName", drawObjectBase.TextProperty.FontName);
							xmlElement4.SetAttribute("FontSize", drawObjectBase.TextProperty.FontSize.ToString(new CultureInfo(1033)));
							xmlElement4.SetAttribute("FontBold", drawObjectBase.TextProperty.FontBold.ToString());
							xmlElement4.SetAttribute("FontItalic", drawObjectBase.TextProperty.FontItalic.ToString());
							xmlElement4.SetAttribute("FontUnderline", drawObjectBase.TextProperty.FontUnderline.ToString());
						}
						xmlElement3.AppendChild(xmlElement4);
					}
					if (drawObjectBase is ObjectOnLine && !((ObjectOnLine)drawObjectBase).MappingState)
					{
						XmlElement xmlElement5 = this.xmlCoords.CreateElement("objOnLine");
						xmlElement5.SetAttribute("ID", drawObjectBase.IdBase.ToString());
						xmlElement3.AppendChild(xmlElement5);
					}
					else if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine))
					{
						if (drawObjectBase.IdBase > 0)
						{
							XmlElement xmlElement6 = this.xmlCoords.CreateElement("objOnLine");
							xmlElement6.SetAttribute("ID", drawObjectBase.IdBase.ToString());
							xmlElement3.AppendChild(xmlElement6);
						}
						else
						{
							XmlElement xmlElement7 = this.xmlCoords.CreateElement("state");
							xmlElement7.SetAttribute("type", Convert.ToInt32(((ObjectOnLine)drawObjectBase).State.state).ToString());
							xmlElement7.SetAttribute("delta", Math.Round(((ObjectOnLine)drawObjectBase).Delta, 4).ToString(new CultureInfo(1033)));
							xmlElement7.SetAttribute("On", ((ObjectOnLine)drawObjectBase).On.ToString());
							xmlElement7.SetAttribute("gorMirror", ((ObjectOnLine)drawObjectBase).GorMirror.ToString());
							xmlElement7.SetAttribute("vertMirror", ((ObjectOnLine)drawObjectBase).VertMirror.ToString());
							xmlElement7.SetAttribute("Text", ((ObjectOnLine)drawObjectBase).Text);
							if (drawObjectBase.TextProperty.Visible)
							{
								xmlElement7.SetAttribute("TextPos", ((int)drawObjectBase.TextProperty.Position).ToString());
							}
							if (!drawObjectBase.UseSettingColor)
							{
								xmlElement7.SetAttribute("Color", drawObjectBase.Color.ToArgb().ToString());
							}
							xmlElement3.AppendChild(xmlElement7);
						}
					}
				}
			}
		}

		public Branch FindBranch(int idCouplingRelation, int numBranch)
		{
			Func<CouplingRelation, bool> func = null;
			LineTool.Class80 @class = new LineTool.Class80();
			@class.int_0 = idCouplingRelation;
			Branch result = null;
			try
			{
				IEnumerable<CouplingRelation> source = this.CouplingRelations;
				if (func == null)
				{
					func = new Func<CouplingRelation, bool>(@class.method_0);
				}
				CouplingRelation couplingRelation = source.Single(func);
				if (couplingRelation != null && couplingRelation.Branches.Count > numBranch)
				{
					result = couplingRelation.Branches[numBranch];
				}
			}
			catch
			{
			}
			return result;
		}

		protected override void Dispose(bool disposing)
		{
			if (!this.disposed && disposing)
			{
				while (this.branches.Count > 0)
				{
					this.branches[0].Dispose();
					this.branches.RemoveAt(0);
				}
				while (this.couplingRelations.Count > 0)
				{
					this.couplingRelations[0].Dispose();
					this.couplingRelations.RemoveAt(0);
				}
				this.selectedBranch = null;
				this.selectedPoint = null;
				this.pointToolList.Clear();
				this.ends.Clear();
				this.states.Clear();
			}
			base.Dispose(disposing);
		}

		[CompilerGenerated]
		private bool method_16(Branch branch_0)
		{
			return branch_0.Parent != this;
		}

		[CompilerGenerated]
		private static DrawObjectBase smethod_0(Branch branch_0)
		{
			return branch_0.Parent;
		}

		[CompilerGenerated]
		private static DrawObjectBase smethod_1(Branch branch_0)
		{
			return branch_0.Parent;
		}

		[CompilerGenerated]
		private static bool smethod_2(PointTool pointTool_0)
		{
			return pointTool_0.Parent != null && pointTool_0.Parent.GetType() == typeof(ShinaTool);
		}

		protected List<PointTool> ends = new List<PointTool>();

		protected CouplingRealationsList couplingRelations = new CouplingRealationsList();

		protected List<PointTool> pointToolList;

		protected List<Branch> branches = new List<Branch>();

		protected PointTool selectedPoint;

		protected Branch selectedBranch;

		protected UnitPoint clickedPoint;

		protected List<LineToolState> states = new List<LineToolState>();

		private bool bool_0;

		public Dictionary<PointTool, Amperage> Amperages = new Dictionary<PointTool, Amperage>();

		private Color color_0 = Color.White;

		private string string_0 = string.Empty;

		private LineToolEventHandler lineToolEventHandler_0;

		private LineToolEventHandler lineToolEventHandler_1;

		private LineToolEventHandler lineToolEventHandler_2;

		private LineToolEventHandler lineToolEventHandler_3;

		private LineToolEventHandler lineToolEventHandler_4;

		[CompilerGenerated]
		private static Func<Branch, DrawObjectBase> func_0;

		[CompilerGenerated]
		private static Func<Branch, DrawObjectBase> func_1;

		[CompilerGenerated]
		private static Func<PointTool, bool> func_2;

		[CompilerGenerated]
		private sealed class Class77
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == Convert.ToInt32(this.dataRow_0[0]["idParent"]) && drawObjectBase_0.GetType() == typeof(ShinaTool);
			}

			public DataRow[] dataRow_0;
		}

		[CompilerGenerated]
		private sealed class Class78
		{
			public bool method_0(CouplingRelation couplingRelation_0)
			{
				return couplingRelation_0.Vertex1 == this.pointTool_0 || couplingRelation_0.Vertex2 == this.pointTool_0 || couplingRelation_0.Vertex1 == this.pointTool_1 || couplingRelation_0.Vertex2 == this.pointTool_1;
			}

			public PointTool pointTool_0;

			public PointTool pointTool_1;
		}

		[CompilerGenerated]
		private sealed class Class79
		{
			public bool method_0(CouplingRelation couplingRelation_0)
			{
				return couplingRelation_0.amperagePoint == this.pointTool_0;
			}

			public PointTool pointTool_0;
		}

		[CompilerGenerated]
		private sealed class Class80
		{
			public bool method_0(CouplingRelation couplingRelation_0)
			{
				return couplingRelation_0.Id == this.int_0;
			}

			public int int_0;
		}
	}
}
