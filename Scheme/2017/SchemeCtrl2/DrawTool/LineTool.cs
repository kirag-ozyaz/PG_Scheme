using System;
using System.Collections;
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
using SchemeCtrl2.DrawTool.FormsObj;
using SchemeCtrl2.Layers;
using SchemeCtrl2.SnapPoint;

namespace SchemeCtrl2.DrawTool
{
	public class LineTool : DrawObjectBase
	{
		public event LineToolEventHandler StateAdded
		{
			[CompilerGenerated]
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
			[CompilerGenerated]
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
			[CompilerGenerated]
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
			[CompilerGenerated]
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
			[CompilerGenerated]
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
			[CompilerGenerated]
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
			[CompilerGenerated]
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
			[CompilerGenerated]
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
			[CompilerGenerated]
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
			[CompilerGenerated]
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
			Class90.TDroV38zslI2T();
			this.ends = new List<PointTool>();
			this.couplingRealationsList_0 = new CouplingRealationsList();
			this.branches = new List<Branch>();
			this.states = new List<LineToolState>();
			this.Amperages = new Dictionary<PointTool, Amperage>();
			this.color_3 = Color.White;
			this.string_2 = string.Empty;
			base..ctor();
			this.StateAdded += this.LineTool_StateAdded;
			this.StateRemoved += this.LineTool_StateRemoved;
		}

		public LineTool(DataRow r, DrawingLayer layer)
		{
			Class90.TDroV38zslI2T();
			this.ends = new List<PointTool>();
			this.couplingRealationsList_0 = new CouplingRealationsList();
			this.branches = new List<Branch>();
			this.states = new List<LineToolState>();
			this.Amperages = new Dictionary<PointTool, Amperage>();
			this.color_3 = Color.White;
			this.string_2 = string.Empty;
			base..ctor(r);
			this.bool_7 = true;
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)r["SchemaXml"]);
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
			foreach (object obj5 in xmlNode2.ChildNodes)
			{
				XmlNode xmlNode3 = (XmlNode)obj5;
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
						bool flag = false;
						DataRow[] rowPoint = layer.Parent.class22_0.vSchm_ObjListXml.Select(string.Concat(new object[]
						{
							"Id = ",
							num,
							" and typeSChema = ",
							((int)layer.Parent.TypeCanvas).ToString()
						}));
						if (rowPoint.Length == 0)
						{
							rowPoint = layer.Parent.class22_0.vSchm_ObjListXml.Select("Id = " + num);
							flag = true;
						}
						if (rowPoint.Length == 0)
						{
							PointTool pointTool = new PointTool();
							pointTool.IdBase = num;
							pointTool.Layer = layer;
							pointTool.NeedToPreserve = NeedToPreserveEnum.const_2;
							layer.Parent.loadedPoints.Add(pointTool.IdBase, pointTool);
							list.Add(pointTool);
						}
						else
						{
							int i = (int)rowPoint[0]["TypeCodeId"];
							PointTool pointTool2;
							if (i != 111)
							{
								if (i != 556)
								{
									continue;
								}
								pointTool2 = new TransformerPointTool(rowPoint[0]);
							}
							else
							{
								pointTool2 = new PointTool(rowPoint[0]);
							}
							if (flag)
							{
								pointTool2.NeedToPreserve = NeedToPreserveEnum.const_2;
							}
							if (layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond && rowPoint[0]["idParent"] != DBNull.Value)
							{
								IEnumerable<DrawObjectBase> source = from a in layer.Objects
								where a.IdBase == Convert.ToInt32(rowPoint[0]["idParent"]) && a.GetType() == typeof(ShinaTool)
								select a;
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
			DataRow[] array = layer.Parent.class22_0.tSchm_Relation.Select("Edge = " + this.IdBase.ToString());
			List<CouplingRelation> list2 = new List<CouplingRelation>();
			foreach (DataRow dataRow in array)
			{
				if (!layer.Parent.loadedPoints.ContainsKey((int)dataRow["SourceObj"]))
				{
					DataRow[] array3 = layer.Parent.class22_0.vSchm_ObjListXml.Select("Id = " + Convert.ToInt32(dataRow["SourceObj"]));
					if (array3.Length != 0)
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
						pointTool5.NeedToPreserve = NeedToPreserveEnum.const_2;
						layer.Parent.loadedPoints.Add(pointTool5.IdBase, pointTool5);
					}
				}
				if (!layer.Parent.loadedPoints.ContainsKey((int)dataRow["DestObj"]))
				{
					DataRow[] array4 = layer.Parent.class22_0.vSchm_ObjListXml.Select("Id = " + Convert.ToInt32(dataRow["DestObj"]));
					if (array4.Length != 0)
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
						pointTool7.NeedToPreserve = NeedToPreserveEnum.const_2;
						layer.Parent.loadedPoints.Add(pointTool7.IdBase, pointTool7);
					}
				}
				CouplingRelation couplingRelation = new CouplingRelation(layer.Parent.loadedPoints[(int)dataRow["SourceObj"]], layer.Parent.loadedPoints[(int)dataRow["DestObj"]]);
				if (!list.Contains(couplingRelation.method_1()) || !list.Contains(couplingRelation.method_2()))
				{
					list2.Add(couplingRelation);
				}
				couplingRelation.Id = (int)dataRow["id"];
				couplingRelation.Line = this;
				this.CouplingRelations.method_3(couplingRelation);
			}
			using (IEnumerator enumerator = xmlNode.SelectNodes("Branch").GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					XmlNode xmlNode6 = (XmlNode)enumerator.Current;
					if (xmlNode6.Attributes.Count < 4)
					{
						layer.Parent.SendMessage(this, "Ошибка во время загрузки ветки (" + this.IdBase.ToString() + ": неверные атрибуты)", eMessageType.Error);
					}
					else
					{
						CouplingRelation couplingRelation2 = null;
						PointTool src = list[Convert.ToInt32(xmlNode6.Attributes[1].Value)];
						PointTool dest = list[Convert.ToInt32(xmlNode6.Attributes[2].Value)];
						using (List<CouplingRelation>.Enumerator enumerator2 = this.CouplingRelations.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								CouplingRelation couplingRelation3 = enumerator2.Current;
								if (couplingRelation3.Id == Convert.ToInt32(xmlNode6.Attributes[3].Value))
								{
									couplingRelation2 = couplingRelation3;
									break;
								}
							}
							goto IL_112F;
						}
						goto IL_99F;
						IL_9C5:
						IEnumerable<CouplingRelation> source2 = from obj in list2
						where obj.method_1() == src || obj.method_2() == src || obj.method_1() == dest || obj.method_2() == dest
						select obj;
						if (source2.Count<CouplingRelation>() == 0)
						{
							layer.Parent.SendMessage(this, "Ошибка во время загрузки ветки (" + this.IdBase.ToString() + ": не найдена подходящая связь)", eMessageType.Error);
							continue;
						}
						if (source2.Count<CouplingRelation>() == 1)
						{
							couplingRelation2 = source2.First<CouplingRelation>();
						}
						if (couplingRelation2 != null && (list.Contains(couplingRelation2.method_1()) || list.Contains(couplingRelation2.method_2())))
						{
							goto IL_A51;
						}
						layer.Parent.SendMessage(this, "Ошибка во время загрузки ветки (" + this.IdBase.ToString() + ": не найдена связь или её точки)", eMessageType.Error);
						continue;
						IL_112F:
						if (couplingRelation2 == null)
						{
							goto IL_9C5;
						}
						IL_99F:
						if (!list.Contains(couplingRelation2.method_1()) && !list.Contains(couplingRelation2.method_2()))
						{
							goto IL_9C5;
						}
						IL_A51:
						if (Convert.ToInt32(xmlNode6.Attributes[1].Value) != -1 && Convert.ToInt32(xmlNode6.Attributes[2].Value) != -1)
						{
							if (list2.Contains(couplingRelation2))
							{
								if (src.IdBase != 0 && src != couplingRelation2.method_1() && src != couplingRelation2.method_2())
								{
									if (!list.Contains(couplingRelation2.method_1()))
									{
										src = couplingRelation2.method_1();
									}
									else if (!list.Contains(couplingRelation2.method_2()))
									{
										src = couplingRelation2.method_2();
									}
								}
								if (dest.IdBase != 0 && dest != couplingRelation2.method_1() && dest != couplingRelation2.method_2())
								{
									if (!list.Contains(couplingRelation2.method_1()))
									{
										dest = couplingRelation2.method_1();
									}
									else if (!list.Contains(couplingRelation2.method_2()))
									{
										dest = couplingRelation2.method_2();
									}
								}
							}
							Branch branch = new Branch(this, src, dest, (BranchType)Convert.ToInt32(xmlNode6.Attributes[0].Value), couplingRelation2);
							foreach (object obj2 in xmlNode6.SelectNodes("objOnLine"))
							{
								XmlNode xmlNode7 = (XmlNode)obj2;
								int num2 = -1;
								if (this.Layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond && !r.IsNull("Tag"))
								{
									num2 = (int)r["Tag"];
								}
								DataRow[] array5 = layer.Parent.class22_0.vSchm_ObjListXml.Select(string.Format("Id = {0} and IdParent = {1} and Tag {2}", Convert.ToInt32(xmlNode7.Attributes[0].Value), couplingRelation2.Id, (num2 == -1) ? "IS NULL" : ("= " + num2)));
								if (array5.Length != 0)
								{
									TypeSwitch typeSwitch = (TypeSwitch)Convert.ToInt32(array5[0]["TypeCodeId"]);
									ObjectOnLine objectOnLine = branch.AddSwitchTool(typeSwitch, array5[0]);
									objectOnLine.LimitedEditing = this.LimitedEditing;
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
							foreach (object obj3 in xmlNode6.SelectNodes("state"))
							{
								XmlNode stateNode = (XmlNode)obj3;
								LineToolState state = new LineToolState(branch, stateNode);
								this.AddState(state);
							}
							foreach (object obj4 in xmlNode6.SelectNodes("textBranch"))
							{
								XmlNode xmlNode8 = (XmlNode)obj4;
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
			}
			this.GetPointsList();
			this.StateAdded += this.LineTool_StateAdded;
			this.StateRemoved += this.LineTool_StateRemoved;
			this.bool_7 = false;
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
				return this.string_2;
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
						amperage.method_5();
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
						foreach (CouplingRelation couplingRelation in this.couplingRealationsList_0)
						{
							PointTool amperagePoint;
							if (couplingRelation.method_1().IdBase == pointTool.IdBase)
							{
								amperagePoint = couplingRelation.method_1();
							}
							else
							{
								if (couplingRelation.method_2().IdBase != pointTool.IdBase)
								{
									continue;
								}
								amperagePoint = couplingRelation.method_2();
							}
							this.AddAmperage(amperagePoint, new Amperage(((LineTool)base.Master).Amperages[pointTool].Source, this, ((LineTool)base.Master).Amperages[pointTool].amperageProperties, ((LineTool)base.Master).Amperages[pointTool].method_0().First<Amperage>()));
						}
					}
				}
			}
		}

		public CouplingRealationsList CouplingRelations
		{
			get
			{
				return this.couplingRealationsList_0;
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
					if (value != LineToolType.CabelLine)
					{
						if (value != LineToolType.AirLine)
						{
							if (value != LineToolType.AirLineProtected)
							{
								type = BranchType.CabelLine;
							}
							else
							{
								type = BranchType.AirLineProtected;
							}
						}
						else
						{
							type = BranchType.AirLine;
						}
					}
					else
					{
						type = BranchType.CabelLine;
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
					if (typeParentShina <= eTypeShinaTool.Shina_023)
					{
						if (typeParentShina == eTypeShinaTool.Shina_04)
						{
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class14))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Line04ColorOff;
									}
									return this.color_3;
								}
							}
							return this.Layer.Parent.Settings.Cell04ColorOff;
						}
						if (typeParentShina == eTypeShinaTool.Shina_6)
						{
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class14))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Line6ColorOff;
									}
									return this.color_3;
								}
							}
							return this.Layer.Parent.Settings.Cell6ColorOff;
						}
						if (typeParentShina == eTypeShinaTool.Shina_023)
						{
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class14))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Line023ColorOff;
									}
									return this.color_3;
								}
							}
							return this.Layer.Parent.Settings.Cell023ColorOff;
						}
					}
					else
					{
						if (typeParentShina == eTypeShinaTool.Shina_10)
						{
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class14))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Line10ColorOff;
									}
									return this.color_3;
								}
							}
							return this.Layer.Parent.Settings.Cell10ColorOff;
						}
						if (typeParentShina == eTypeShinaTool.Shina_35)
						{
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class14))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Line35ColorOff;
									}
									return this.color_3;
								}
							}
							return this.Layer.Parent.Settings.Cell35ColorOff;
						}
						if (typeParentShina == eTypeShinaTool.Shina_110)
						{
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class14))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Line110ColorOff;
									}
									return this.color_3;
								}
							}
							return this.Layer.Parent.Settings.Cell110ColorOff;
						}
					}
				}
				return this.color_3;
			}
			set
			{
				this.color_3 = value;
			}
		}

		public override Color Color
		{
			get
			{
				if (this.Layer != null && base.UseSettingColor)
				{
					eTypeShinaTool typeParentShina = this.GetTypeParentShina(new List<LineTool>());
					if (typeParentShina <= eTypeShinaTool.Shina_023)
					{
						if (typeParentShina == eTypeShinaTool.Shina_04)
						{
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class14))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Color_8;
									}
									return base.Color;
								}
							}
							return this.Layer.Parent.Settings.Color_4;
						}
						if (typeParentShina == eTypeShinaTool.Shina_6)
						{
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class14))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Color_7;
									}
									return base.Color;
								}
							}
							return this.Layer.Parent.Settings.Color_3;
						}
						if (typeParentShina == eTypeShinaTool.Shina_023)
						{
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class14))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Line023Color;
									}
									return base.Color;
								}
							}
							return this.Layer.Parent.Settings.Cell023Color;
						}
					}
					else
					{
						if (typeParentShina == eTypeShinaTool.Shina_10)
						{
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class14))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Color_6;
									}
									return base.Color;
								}
							}
							return this.Layer.Parent.Settings.Color_2;
						}
						if (typeParentShina == eTypeShinaTool.Shina_35)
						{
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class14))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Color_5;
									}
									return base.Color;
								}
							}
							return this.Layer.Parent.Settings.Color_1;
						}
						if (typeParentShina == eTypeShinaTool.Shina_110)
						{
							if (base.GetType() != typeof(LineCellTool))
							{
								if (base.GetType() != typeof(Class14))
								{
									if (base.GetType() == typeof(LineTool))
									{
										return this.Layer.Parent.Settings.Line110Color;
									}
									return base.Color;
								}
							}
							return this.Layer.Parent.Settings.Cell110Color;
						}
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
			if (base.GetType() != typeof(LineCellTool))
			{
				if (base.GetType() != typeof(Class14))
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
							foreach (Branch branch in pointTool3.Branches.Where(new Func<Branch, bool>(this.method_17)))
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
						using (IEnumerator<Branch> enumerator2 = pointTool.Branches.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.Parent.Layer != null)
								{
									flag = false;
									break;
								}
							}
							goto IL_75;
						}
						IL_6C:
						pointTool.Layer = value;
						continue;
						IL_75:
						if (flag)
						{
							goto IL_6C;
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
					amperage.method_5();
				}
				List<CouplingRelation> list = new List<CouplingRelation>();
				CouplingRelation couplingRelation2 = point.CouplingRelations.First<CouplingRelation>();
				list.Add(couplingRelation2);
				this.RunOnRelation(list, (couplingRelation2.method_1() == point) ? couplingRelation2.method_2() : couplingRelation2.method_1());
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
					this.CouplingRelations.method_5(couplingRelation3);
					couplingRelation3.amperagePoint = null;
					couplingRelation3.Line = lineTool;
					lineTool.CouplingRelations.method_3(couplingRelation3);
					foreach (Branch branch in couplingRelation3.method_3())
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
				using (List<PointTool>.Enumerator enumerator4 = list3.GetEnumerator())
				{
					while (enumerator4.MoveNext())
					{
						PointTool ap = enumerator4.Current;
						if (pointsList.Contains(ap))
						{
							this.Amperages[ap].Conductor = lineTool;
							lineTool.Amperages.Add(ap, this.Amperages[ap]);
							this.Amperages.Remove(ap);
							IEnumerable<CouplingRelation> couplingRelations = this.CouplingRelations;
							Func<CouplingRelation, bool> predicate;
							Func<CouplingRelation, bool> <>9__0;
							if ((predicate = <>9__0) == null)
							{
								predicate = (<>9__0 = ((CouplingRelation obj) => obj.amperagePoint == ap));
							}
							foreach (CouplingRelation couplingRelation4 in couplingRelations.Where(predicate))
							{
								couplingRelation4.amperagePoint = null;
							}
						}
					}
				}
				if (this.Amperages.Count > 0)
				{
					this.vmethod_1();
				}
				if (lineTool.Amperages.Count > 0)
				{
					lineTool.vmethod_1();
				}
				return lineTool;
			}
			return null;
		}

		protected void RunOnRelation(List<CouplingRelation> RelationsList, PointTool nextVertex)
		{
			foreach (CouplingRelation couplingRelation in nextVertex.CouplingRelations)
			{
				if (couplingRelation.method_3().Count >= 0 && !RelationsList.Contains(couplingRelation) && couplingRelation.Line == this)
				{
					RelationsList.Add(couplingRelation);
					this.RunOnRelation(RelationsList, (couplingRelation.method_1() == nextVertex) ? couplingRelation.method_2() : couplingRelation.method_1());
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
				double x = (double)centerOfRotation.Point.X + num * num3 - num2 * num4;
				double y = (double)centerOfRotation.Point.Y + num * num4 + num2 * num3;
				pointTool.Point = new UnitPoint(x, y);
			}
		}

		public void ReflectAboutTheLine(UnitPoint p1, UnitPoint p2)
		{
			foreach (PointTool pointTool in this.pointToolList)
			{
				UnitPoint unitPoint = Class79.smethod_4(p1, p2, pointTool.Point);
				double num = pointTool.Point.X - unitPoint.X;
				double num2 = pointTool.Point.Y - unitPoint.Y;
				pointTool.Point = new UnitPoint((double)((float)(unitPoint.X - num)), (double)((float)(unitPoint.Y - num2)));
			}
		}

		public bool Validation()
		{
			bool flag = false;
			bool flag2 = false;
			this.string_2 = string.Empty;
			foreach (CouplingRelation couplingRelation in this.couplingRealationsList_0)
			{
				if (!flag && couplingRelation.method_1().BranchesCount == 2 && couplingRelation.method_1()[0].Parent == couplingRelation.method_1()[1].Parent)
				{
					flag = true;
				}
				if (!flag && couplingRelation.method_2().BranchesCount == 2 && couplingRelation.method_2()[0].Parent == couplingRelation.method_2()[1].Parent)
				{
					flag = true;
				}
				if (!flag2)
				{
					foreach (Branch branch in couplingRelation.method_3())
					{
						if ((branch.Source.BranchesCount > 2 && couplingRelation.method_1() != branch.Source && couplingRelation.method_2() != branch.Source) || (branch.Destination.BranchesCount > 2 && couplingRelation.method_1() != branch.Destination && couplingRelation.method_2() != branch.Destination))
						{
							flag2 = true;
						}
					}
				}
			}
			if (flag)
			{
				this.string_2 += "Ошибка связей - связь по среди линии. ";
			}
			if (flag2)
			{
				this.string_2 += "Ошибка связей - разветвление внутри связи. ";
			}
			return this.string_2 == string.Empty;
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

		public virtual Branch AddBranch(PointTool src, PointTool dest)
		{
			if (this.LimitedEditing)
			{
				return null;
			}
			bool flag = false;
			bool flag2 = false;
			foreach (Branch branch in this.branches)
			{
				if (branch.Source == src || branch.Destination == src)
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
			if (src.Layer == null)
			{
				src.Layer = this.Layer;
			}
			if (dest.Layer == null)
			{
				dest.Layer = this.Layer;
			}
			Branch branch2;
			if (!flag && !flag2)
			{
				this.ends.Add(src);
				src.AddBranchEvent += new PointToolEventHandle(this.method_7);
				this.ends.Add(dest);
				dest.AddBranchEvent += new PointToolEventHandle(this.method_7);
				branch2 = new Branch(this, src, dest);
				branch2.CouplingRelation = this.CreateRelation(src, dest);
				this.AmperageAnalisForNewPoint(src, branch2);
				this.AmperageAnalisForNewPoint(dest, branch2);
			}
			else if (!flag2)
			{
				if (this.ends.Contains(src))
				{
					this.ends.Remove(src);
					src.AddBranchEvent -= new PointToolEventHandle(this.method_7);
					this.ends.Add(dest);
					dest.AddBranchEvent += new PointToolEventHandle(this.method_7);
				}
				if (src.CouplingRelations.Count > 1)
				{
					this.CreateCoupling(dest);
					this.ends.Add(dest);
					dest.AddBranchEvent += new PointToolEventHandle(this.method_7);
					branch2 = new Branch(this, src, dest);
					branch2.CouplingRelation = this.CreateRelation(src, dest);
					this.AmperageAnalisForNewPoint(src, branch2);
				}
				else if (src.CouplingRelations.Count == 1)
				{
					this.ChangeCoupling(src, dest);
					branch2 = new Branch(this, src, dest);
					branch2.CouplingRelation = dest.CouplingRelations[dest.CouplingRelations.Count - 1];
					int count = dest.CouplingRelations.Count;
					this.AmperageAnalisForNewPoint(src, branch2);
				}
				else
				{
					branch2 = this.AddBranching(src, dest);
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
					dest.AddBranchEvent -= new PointToolEventHandle(this.method_7);
					this.ends.Add(src);
					src.AddBranchEvent += new PointToolEventHandle(this.method_7);
				}
				if (dest.CouplingRelations.Count > 1)
				{
					this.CreateCoupling(src);
					this.ends.Add(src);
					src.AddBranchEvent += new PointToolEventHandle(this.method_7);
					branch2 = new Branch(this, src, dest);
					branch2.CouplingRelation = this.CreateRelation(dest, src);
					this.AmperageAnalisForNewPoint(dest, branch2);
				}
				else if (dest.CouplingRelations.Count == 1)
				{
					this.ChangeCoupling(dest, src);
					branch2 = new Branch(this, src, dest);
					branch2.CouplingRelation = src.CouplingRelations[src.CouplingRelations.Count - 1];
					this.AmperageAnalisForNewPoint(dest, branch2);
				}
				else
				{
					branch2 = this.AddBranching(dest, src);
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

		private void method_7(object sender, EventArgs e)
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
				pointTool = new PointTool(Class79.smethod_4(this.selectedBranch.Source.Point, this.selectedBranch.Destination.Point, this.clickedPoint));
				PointTool destination = this.selectedBranch.Destination;
				Amperage amperage = this.Amperages.ContainsKey(destination) ? this.Amperages[destination] : null;
				destination.RemoveBranch(this.selectedBranch);
				this.selectedBranch.Destination = pointTool;
				pointTool.AddBranch(this.selectedBranch);
				new Branch(this, destination, pointTool).CouplingRelation = this.selectedBranch.CouplingRelation;
				if (amperage != null)
				{
					this.Amperages.Add(destination, amperage);
					this.vmethod_1();
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
			this.vmethod_1();
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
				source.AddBranchEvent += new PointToolEventHandle(this.method_7);
				this.ends.Add(destination);
				destination.AddBranchEvent += new PointToolEventHandle(this.method_7);
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
					source.AddBranchEvent -= new PointToolEventHandle(this.method_7);
					this.ends.Add(destination);
					destination.AddBranchEvent += new PointToolEventHandle(this.method_7);
				}
				if (source.CouplingRelations.Count > 1)
				{
					branch.Parent = this;
					this.branches.Add(branch);
					if (source.BranchesCount > 2)
					{
						this.ends.Add(destination);
						destination.AddBranchEvent += new PointToolEventHandle(this.method_7);
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
					destination.AddBranchEvent -= new PointToolEventHandle(this.method_7);
					this.ends.Add(source);
					source.AddBranchEvent += new PointToolEventHandle(this.method_7);
				}
				if (destination.CouplingRelations.Count > 1)
				{
					branch.Parent = this;
					this.branches.Add(branch);
					if (destination.BranchesCount > 2)
					{
						this.ends.Add(source);
						source.AddBranchEvent += new PointToolEventHandle(this.method_7);
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

		public virtual Branch AddBranch(PointTool src, PointTool dest, BranchType type)
		{
			if (this.LimitedEditing)
			{
				return null;
			}
			Branch branch = this.AddBranch(src, dest);
			if (branch != null)
			{
				branch.Type = type;
			}
			return branch;
		}

		protected Branch AddBranching(PointTool src, PointTool dest)
		{
			if (src.CouplingRelations.Count != 0)
			{
				return null;
			}
			if (src.BranchesCount > 2)
			{
				throw new Exception("Непонятно О_о");
			}
			Branch branch = src[0];
			this.DevideRelation(branch.CouplingRelation, src);
			return this.AddBranch(src, dest);
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
			if (branch2.CouplingRelation.method_2() != branch2.Destination)
			{
				branch2.CouplingRelation.method_1();
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
			while (pointTool != branch2.CouplingRelation.method_2())
			{
				if (pointTool == branch2.CouplingRelation.method_1())
				{
					break;
				}
				if (pointTool.BranchesCount > 2)
				{
					throw new Exception("Неожиданная ошибка: У точки больше 2-х соурсов, но конец связи ещё не найден :(");
				}
				using (IEnumerator<Branch> enumerator = pointTool.Branches.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Branch branch4 = enumerator.Current;
						if (branch4 != branch2)
						{
							branch2 = branch4;
							break;
						}
					}
					goto IL_147;
				}
				goto IL_103;
				IL_11C:
				list.Add(branch2);
				if (list.Count >= ((LineTool)branch2.Parent).Branches.Count)
				{
					throw new Exception("Совсем неожиданная ошибка: точка-путешественница не нашла себя в бренче :'(");
				}
				continue;
				IL_103:
				pointTool = branch2.Destination;
				goto IL_11C;
				IL_147:
				if (branch2.Source == pointTool)
				{
					goto IL_103;
				}
				if (branch2.Destination == pointTool)
				{
					pointTool = branch2.Source;
					goto IL_11C;
				}
				throw new Exception("Совсем неожиданная ошибка: точка-путешественница не нашла себя в бренче :'(");
			}
			branch2.CouplingRelation.method_5(pointTool, source);
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
			using (IEnumerator<Branch> enumerator = point.Branches.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Parent != this)
					{
						throw new Exception("К данной точке нельзя добавить линию");
					}
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
				Amperage amperage = lineTool_0.Amperages[lineToolEventArgs_0.eventPoint].method_3(this);
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
				this.method_13(newBranch.CouplingRelation.amperagePoint);
				return;
			}
			if (flag2 && !flag)
			{
				((ShinaTool)newPoint.Parent).method_16((PointShinaTool)newPoint);
				return;
			}
			if (couplingRelation != null && !flag)
			{
				couplingRelation.Line.method_13(couplingRelation.amperagePoint);
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
				this.CreateRelation(dictionary[couplingRelation.method_1()], dictionary[couplingRelation.method_2()]);
			}
			foreach (Branch branch in aCopy.Branches)
			{
				Branch branch2 = new Branch(this, dictionary[branch.Source], dictionary[branch.Destination], branch.Type);
				foreach (CouplingRelation couplingRelation2 in this.CouplingRelations)
				{
					if ((couplingRelation2.method_1() == dictionary[branch.CouplingRelation.method_1()] && couplingRelation2.method_2() == dictionary[branch.CouplingRelation.method_2()]) || (couplingRelation2.method_2() == dictionary[branch.CouplingRelation.method_1()] && couplingRelation2.method_1() == dictionary[branch.CouplingRelation.method_2()]))
					{
						branch2.CouplingRelation = couplingRelation2;
					}
				}
				int count = aCopy.OurBranchesInPoint(branch.Source).Count;
				if (count == 1)
				{
					this.ends.Add(dictionary[branch.Source]);
					dictionary[branch.Source].AddBranchEvent += new PointToolEventHandle(this.method_7);
					if (dictionary[branch.Source].GetType() != typeof(PointShinaTool))
					{
						dictionary[branch.Source].TypePoint = TypePointTool.Coupling;
					}
				}
				if (count > 2)
				{
					dictionary[branch.Source].TypePoint = TypePointTool.Coupling;
				}
				int count2 = aCopy.OurBranchesInPoint(branch.Destination).Count;
				if (count2 == 1)
				{
					this.ends.Add(dictionary[branch.Destination]);
					dictionary[branch.Source].AddBranchEvent += new PointToolEventHandle(this.method_7);
					if (dictionary[branch.Destination].GetType() != typeof(PointShinaTool))
					{
						dictionary[branch.Destination].TypePoint = TypePointTool.Coupling;
					}
				}
				if (count2 > 2)
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
						((TextBranchTool)drawObjectBase.Clone(false)).Parent = branch2;
					}
				}
				branch2.Master = branch;
			}
		}

		public override void InitializeFromModel(UnitPoint point, DrawingLayer layer, ISnapPoint snap)
		{
			this.Remove(false, true);
			this.Layer = layer;
			PointTool src = new PointTool(point);
			PointTool dest = new PointTool(point);
			this.AddBranch(src, dest);
			base.Width = layer.Width;
			this.Color = layer.Color;
			this.Selected = true;
		}

		public override void Remove(bool delSql, bool bool_8)
		{
			if (!this.LimitedEditing)
			{
				foreach (CouplingRelation couplingRelation in this.CouplingRelations)
				{
					while (this.Amperages.Count > 0)
					{
						this.Amperages.Values.First<Amperage>().method_4();
					}
					couplingRelation.Deleted = true;
					bool flag = true;
					using (List<CouplingRelation>.Enumerator enumerator2 = couplingRelation.method_1().CouplingRelations.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (!enumerator2.Current.Deleted)
							{
								flag = false;
								break;
							}
						}
						goto IL_FF;
					}
					goto IL_99;
					IL_A6:
					flag = true;
					using (List<CouplingRelation>.Enumerator enumerator2 = couplingRelation.method_2().CouplingRelations.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (!enumerator2.Current.Deleted)
							{
								flag = false;
								break;
							}
						}
					}
					if (flag)
					{
						couplingRelation.method_2().Remove(true, false);
						continue;
					}
					continue;
					IL_99:
					couplingRelation.method_1().Remove(true, false);
					goto IL_A6;
					IL_FF:
					if (flag)
					{
						goto IL_99;
					}
					goto IL_A6;
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
						drawObjectBase.Remove(delSql, bool_8);
					}
				}
			}
			base.Remove(delSql, bool_8);
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
					new SqlDataCommand(this.Layer.Parent.SqlSettings).DeleteSqlData(this.Layer.Parent.class22_0.tSchm_Xml, "where [ObjId] = " + this.IdBase + " AND TypeSchema=2");
				}
				this.SaveToSql(false, true);
			}
		}

		public override bool ObjectInRectangle(CanvasControl canvas, RectangleF rect, bool anyPoint)
		{
			using (List<Branch>.Enumerator enumerator = this.branches.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.ObjectInRectangle(canvas, rect, anyPoint))
					{
						return true;
					}
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

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			foreach (Branch branch in this.branches)
			{
				branch.DrawPrint(canvas, g, isColor);
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
				eCommandType eCommandType_ = canvas.eCommandType_0;
				if (eCommandType_ == eCommandType.draw)
				{
					if (this.branches.Count == 0)
					{
						return;
					}
					if (this.branches.Count == 1 && this.branches[0].Source.Point == this.branches[0].Destination.Point)
					{
						PointTool pointTool = canvas.method_29(point);
						bool flag = false;
						if (pointTool != null)
						{
							using (IEnumerator<Branch> enumerator = pointTool.Branches.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									if (enumerator.Current.Parent.LimitedEditing)
									{
										flag = true;
										break;
									}
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
						PointTool pointTool2 = canvas.method_29(point);
						if (pointTool2 == null)
						{
							this.AddBranch(new PointTool(point));
							return;
						}
						bool flag2 = false;
						using (IEnumerator<Branch> enumerator = pointTool2.Branches.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.Parent.LimitedEditing)
								{
									flag2 = true;
									break;
								}
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
		}

		public override void OnMouseMove(CanvasControl canvas, UnitPoint point, MouseButtons button)
		{
			if (button == MouseButtons.None)
			{
				eCommandType eCommandType_ = canvas.eCommandType_0;
				if (eCommandType_ == eCommandType.draw)
				{
					canvas.Graphics = Graphics.FromHwnd(canvas.Handle);
					RectangleF unitrect = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetBoundingRect(canvas, true));
					unitrect.Inflate(2f, 2f);
					canvas.method_21(new Rectangle((int)unitrect.X, (int)unitrect.Y, (int)unitrect.Width, (int)unitrect.Height));
					this.MoveHandleTo(point, this.pointToolList.IndexOf(this.branches[this.branches.Count - 1].Destination) + 1);
					this.Draw(canvas, unitrect, eDrawMode.Color);
				}
			}
		}

		public override void MoveHandleTo(UnitPoint point, int handleNumber)
		{
			PointTool pointTool = this.pointToolList[handleNumber - 1];
			if (pointTool.Parent != null && pointTool.Parent.Layer != null)
			{
				if (pointTool.Parent.GetType() == typeof(LineCellTool) || pointTool.Parent.GetType() == typeof(Class14))
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
			foreach (PointTool pointTool in this.GetPointsList())
			{
				if (pointTool.Parent != null)
				{
					if (pointTool.Parent == this)
					{
						IEnumerable<IGrouping<DrawObjectBase, Branch>> enumerable = from bs in pointTool.Branches
						group bs by bs.Parent;
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
					IEnumerable<IGrouping<DrawObjectBase, Branch>> enumerable2 = from bs in pointTool.Branches
					group bs by bs.Parent;
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
						using (IEnumerator<Branch> enumerator2 = branch.Source.Branches.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.Parent == this)
								{
									num++;
								}
								if (num > 2)
								{
									break;
								}
							}
							goto IL_138;
						}
						goto IL_95;
						IL_BD:
						num = 0;
						using (IEnumerator<Branch> enumerator2 = branch.Destination.Branches.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.Parent == this)
								{
									num++;
								}
								if (num > 2)
								{
									break;
								}
							}
						}
						if (num == 1)
						{
							this.ends.Add(branch.Destination);
							branch.Destination.AddBranchEvent += new PointToolEventHandle(this.method_7);
							continue;
						}
						continue;
						IL_95:
						this.ends.Add(branch.Source);
						branch.Source.AddBranchEvent += new PointToolEventHandle(this.method_7);
						goto IL_BD;
						IL_138:
						if (num == 1)
						{
							goto IL_95;
						}
						goto IL_BD;
					}
				}
				this.method_12(this.ends[0], null, list);
			}
			this.pointToolList = list;
			return list;
		}

		public override void EndDraw()
		{
			if (this.Branches[this.Branches.Count - 1].Destination.BranchesCount == 1 && base.GetType() != typeof(LineCellTool) && base.GetType() != typeof(Class14))
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
			if (this.Amperages.Count > 0)
			{
				flag = true;
				foreach (Amperage amperage in this.Amperages.Values)
				{
					amperage.method_5();
				}
			}
			bool flag2 = false;
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
				pointTool.AddBranchEvent -= new PointToolEventHandle(this.method_7);
				this.ends.Add(newPoint);
				newPoint.AddBranchEvent += new PointToolEventHandle(this.method_7);
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
						couplingRelation.method_5(pointTool, newPoint);
						i--;
					}
				}
				if (newPoint.CouplingRelations.Count == 2 && newPoint.CouplingRelations[0].Line == newPoint.CouplingRelations[1].Line)
				{
					CouplingRelation couplingRelation2 = newPoint.CouplingRelations[0];
					CouplingRelation couplingRelation3 = newPoint.CouplingRelations[1];
					if (newPoint != couplingRelation2.method_1())
					{
						couplingRelation2.method_1();
					}
					else
					{
						couplingRelation2.method_2();
					}
					PointTool pointTool2 = (newPoint == couplingRelation3.method_1()) ? couplingRelation3.method_2() : couplingRelation3.method_1();
					while (couplingRelation3.method_3().Count > 0)
					{
						couplingRelation3.method_3()[0].CouplingRelation = couplingRelation2;
					}
					newPoint.CouplingRelations.method_5(couplingRelation3);
					pointTool2.CouplingRelations.method_5(couplingRelation3);
					couplingRelation2.method_5(newPoint, pointTool2);
				}
				flag2 = (pointTool.CouplingRelations.Count == 0);
			}
			if (flag2)
			{
				pointTool.Remove(true, true);
			}
			this.pointToolList = this.GetPointsList();
			if (flag)
			{
				this.vmethod_1();
			}
		}

		public string GenerateNameForCabelLine()
		{
			string text = "";
			if (this.Type == LineToolType.CabelLine)
			{
				List<LineTool.Class15> list = new List<LineTool.Class15>(2);
				list.Add(new LineTool.Class15());
				list.Add(new LineTool.Class15());
				for (int i = 0; i < 2; i++)
				{
					list[i].pointTool_0 = this.ends[i];
				}
				for (int j = 2; j < this.ends.Count<PointTool>(); j++)
				{
					if (list[0].pointTool_0.Parent == null && list[0].pointTool_0.Branches.Count<Branch>() == 1)
					{
						list[0].pointTool_0 = this.ends[j];
					}
					else if (list[1].pointTool_0.Parent == null && list[1].pointTool_0.Branches.Count<Branch>() == 1)
					{
						list[1].pointTool_0 = this.ends[j];
					}
				}
				for (int k = 0; k < list.Count; k++)
				{
					list[k].int_0 = 99;
					if (list[k].pointTool_0.Parent != null)
					{
						list[k].string_0 = list[k].pointTool_0.Parent.Parent.ToString() + " Яч." + list[k].pointTool_0.Parent.Text;
						eTypeRectangleTool typeRectnagleTool = ((RectangleTool)list[k].pointTool_0.Parent.Parent).TypeRectnagleTool;
						switch (typeRectnagleTool)
						{
						case eTypeRectangleTool.PP:
							list[k].int_0 = 1;
							break;
						case eTypeRectangleTool.CP:
							list[k].int_0 = 4;
							break;
						case eTypeRectangleTool.RP:
							list[k].int_0 = 3;
							break;
						case eTypeRectangleTool.TP:
							list[k].int_0 = 2;
							break;
						default:
							if (typeRectnagleTool != eTypeRectangleTool.SP && typeRectnagleTool != eTypeRectangleTool.PPNO)
							{
								list[k].int_0 = 9;
							}
							else
							{
								list[k].int_0 = 5;
							}
							break;
						}
					}
					else if (list[k].pointTool_0.Branches.Count<Branch>() > 1)
					{
						foreach (Branch branch in list[k].pointTool_0.Branches)
						{
							if (branch.Parent != this)
							{
								string text2 = ((LineTool)branch.Parent).method_8("Напряжение");
								if (!string.IsNullOrEmpty(text2))
								{
									text2 = " " + text2 + "кВ";
								}
								LineToolType type = ((LineTool)branch.Parent).Type;
								if (type != LineToolType.CabelLine)
								{
									if (type != LineToolType.AirLine)
									{
										if (type == LineToolType.AirLineProtected)
										{
											list[k].int_0 = 13;
											list[k].string_0 = "ВЛЗ" + text2;
											if (!string.IsNullOrEmpty(list[k].pointTool_0.Text))
											{
												list[k].string_1 = "оп." + list[k].pointTool_0.Text;
											}
										}
									}
									else
									{
										list[k].int_0 = 12;
										list[k].string_0 = "ВЛ" + text2;
										if (!string.IsNullOrEmpty(list[k].pointTool_0.Text))
										{
											list[k].string_1 = "оп." + list[k].pointTool_0.Text;
										}
									}
									break;
								}
								list[k].string_0 = "КЛ" + text2;
								list[k].int_0 = 11;
								break;
							}
						}
					}
				}
				LineTool.Class15 @class = list[0];
				LineTool.Class15 class2 = list[1];
				if (list[0].int_0 > list[1].int_0)
				{
					@class = list[1];
					class2 = list[0];
				}
				if (@class.int_0 >= 10 && class2.int_0 >= 10)
				{
					if (@class.int_0 > 11 && class2.int_0 > 11)
					{
						string text3 = "";
						if (@class.pointTool_0.Branches.Count<Branch>() > 0 && @class.pointTool_0.Branches.First<Branch>().Parent != null)
						{
							foreach (DrawObjectBase drawObjectBase in @class.pointTool_0.Branches.First<Branch>().Parent.GetPowerSource())
							{
								if (drawObjectBase is BranchCollection && drawObjectBase.Parent != null && drawObjectBase.Parent is LineCellTool && drawObjectBase.Parent.Parent != null && drawObjectBase.Parent.Parent is RectangleTool)
								{
									text3 = string.Concat(new string[]
									{
										" (",
										drawObjectBase.Parent.Parent.ToString(),
										" яч.",
										drawObjectBase.Parent.Text,
										") "
									});
									break;
								}
							}
						}
						if (!string.IsNullOrEmpty(@class.string_1) && !string.IsNullOrEmpty(class2.string_1))
						{
							text = string.Concat(new string[]
							{
								@class.string_1,
								"-",
								class2.string_1,
								text3,
								" - ",
								@class.string_0
							});
						}
						else if (string.IsNullOrEmpty(@class.string_1))
						{
							text = class2.string_1 + text3 + " - " + @class.string_0;
						}
						else
						{
							text = @class.string_1 + text3 + " - " + @class.string_0;
						}
					}
					else
					{
						text = @class.string_0;
						string str = "";
						if (class2.int_0 > 11)
						{
							str = (string.IsNullOrEmpty(class2.string_1) ? "" : (class2.string_1 + "-"));
						}
						text = @class.string_0 + " - " + str + class2.string_0;
					}
				}
				else if (@class.int_0 == class2.int_0)
				{
					if (string.Compare(@class.string_0, class2.string_0) <= 0)
					{
						text = @class.string_0 + " - " + class2.string_0;
					}
					else
					{
						text = class2.string_0 + " - " + @class.string_0;
					}
				}
				else
				{
					string str2 = "";
					if (class2.int_0 > 11)
					{
						str2 = (string.IsNullOrEmpty(class2.string_1) ? "" : (class2.string_1 + "-"));
					}
					text = @class.string_0 + " - " + str2 + class2.string_0;
				}
			}
			if (this.Type == LineToolType.AirLine || this.Type == LineToolType.AirLineProtected)
			{
				string str3 = "";
				foreach (DrawObjectBase drawObjectBase2 in this.GetPowerSource())
				{
					if (drawObjectBase2 is BranchCollection && drawObjectBase2.Parent != null && drawObjectBase2.Parent is LineCellTool && drawObjectBase2.Parent.Parent != null && drawObjectBase2.Parent.Parent is RectangleTool)
					{
						str3 = drawObjectBase2.Parent.Parent.ToString() + " яч." + drawObjectBase2.Parent.Text;
						break;
					}
				}
				string text4 = this.method_8("Напряжение");
				if (!string.IsNullOrEmpty(text4))
				{
					text4 = " " + text4 + "кВ";
				}
				text = str3 + text4;
			}
			string text5 = this.method_8("Спаренность");
			if (!string.IsNullOrEmpty(text5))
			{
				text = string.Format(text + " ({0})", text5);
			}
			return text;
		}

		internal string method_8(string string_3)
		{
			string result = "";
			if (this.IdBase > 0 && this.Layer != null && this.Layer.Parent != null && this.Layer.Parent.SqlSettings != null)
			{
				SqlDataCommand sqlDataCommand = new SqlDataCommand(this.Layer.Parent.SqlSettings);
				DataTable dataTable = new DataTable("vP_PassportDataReports");
				dataTable.Columns.Add("CharValue", typeof(string));
				sqlDataCommand.SelectSqlData(dataTable, true, string.Format(" where idObj = {0} and CharName = '{1}'", this.IdBase, string_3), null, false, 0);
				if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["CharValue"] != DBNull.Value)
				{
					result = dataTable.Rows[0]["CharValue"].ToString();
				}
			}
			return result;
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
					foreach (PointTool pointTool2 in from obj in ((LineTool)pointTool.Parent).Ends
					where obj.Parent != null && obj.Parent.GetType() == typeof(ShinaTool)
					select obj)
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

		public override void vmethod_0(XmlNode xmlNode, List<PointTool> pointList)
		{
			XmlElement xmlElement = xmlNode.OwnerDocument.CreateElement("Line");
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
				branch.vmethod_0(xmlElement, pointList);
			}
		}

		public override bool HaveContact(DrawObjectBase obj)
		{
			foreach (PointTool pointTool in this.ends)
			{
				if (pointTool.Parent == obj)
				{
					return true;
				}
				using (IEnumerator<Branch> enumerator2 = pointTool.Branches.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.Parent == obj)
						{
							return true;
						}
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

		public override void vmethod_2(CanvasControl canvas, Document document)
		{
			foreach (Branch branch in this.Branches)
			{
				Line line = new Line(this.Layer.Name, branch.Source.Point.X, branch.Source.Point.Y, branch.Destination.Point.X, branch.Destination.Point.Y);
				document.add(line);
			}
		}

		public override void vmethod_3(CanvasControl canvas, DxfDocument document)
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
				branch.Source.vmethod_3(canvas, document);
				branch.Destination.vmethod_3(canvas, document);
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
			if (this.selectedBranch.CouplingRelation.amperagePoint == null)
			{
				return null;
			}
			if (this.selectedBranch != null && this.Amperages.ContainsKey(this.selectedBranch.CouplingRelation.amperagePoint))
			{
				Amperage amperage_ = this.Amperages[this.selectedBranch.CouplingRelation.amperagePoint];
				List<DrawObjectBase> recipientsPower = base.GetRecipientsPower();
				this.method_9(amperage_, recipientsPower);
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
				this.bool_7 = true;
				state.Remove(false);
				this.bool_7 = false;
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
				using (List<DrawObjectBase>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current != drawObjectBase)
						{
							return null;
						}
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

		public BranchCollection GetWayOnLineTool(PointTool pt1, PointTool pt2)
		{
			if (!this.ends.Contains(pt1) && !this.ends.Contains(pt2))
			{
				return null;
			}
			BranchCollection branchCollection = new BranchCollection();
			List<CouplingRelation> list = new List<CouplingRelation>();
			this.getRelationWay(pt1, pt2, null, list);
			foreach (CouplingRelation couplingRelation in list)
			{
				branchCollection.AddRange(couplingRelation.method_3());
			}
			return branchCollection;
		}

		public bool getRelationWay(PointTool pt, PointTool destination, CouplingRelation oldRelation, List<CouplingRelation> crList)
		{
			bool flag = false;
			foreach (CouplingRelation couplingRelation in pt.CouplingRelations)
			{
				if (couplingRelation.method_3().Count != 0 && couplingRelation != oldRelation && couplingRelation.Line == this)
				{
					PointTool pointTool = (couplingRelation.method_1() == pt) ? couplingRelation.method_2() : couplingRelation.method_1();
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

		private void method_9(Amperage amperage_0, List<DrawObjectBase> list_2)
		{
			list_2.Add(amperage_0.Conductor);
			foreach (Amperage amperage_ in amperage_0.NextAmperages)
			{
				this.method_9(amperage_, list_2);
			}
		}

		protected CouplingRelation CreateRelation(PointTool src, PointTool dest)
		{
			if (src.GetType() != typeof(PointShinaTool) && src.TypePoint != TypePointTool.Coupling)
			{
				src.TypePoint = TypePointTool.Coupling;
			}
			if (dest.GetType() != typeof(PointShinaTool) && dest.TypePoint != TypePointTool.Coupling)
			{
				dest.TypePoint = TypePointTool.Coupling;
			}
			CouplingRelation couplingRelation = new CouplingRelation(src, dest);
			couplingRelation.Line = this;
			this.couplingRealationsList_0.method_3(couplingRelation);
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
				if (couplingRelation.method_1() != newCoupling)
				{
					if (couplingRelation.method_2() != newCoupling)
					{
						couplingRelation.method_5(oldCoupling, newCoupling);
						continue;
					}
				}
				this.DeleteCouplingRelation(couplingRelation);
				oldCoupling.CouplingRelations.method_5(couplingRelation);
				newCoupling.CouplingRelations.method_5(couplingRelation);
			}
		}

		protected void DeleteCouplingRelation(CouplingRelation coupingRelation)
		{
			if (this.LimitedEditing)
			{
				return;
			}
			this.couplingRealationsList_0.method_5(coupingRelation);
		}

		protected void DeleteCouping(PointTool oldCouping)
		{
			oldCouping.TypePoint = TypePointTool.Point;
		}

		public void AddPointTool()
		{
			PointTool pointTool = new PointTool(Class79.smethod_4(this.selectedBranch.Source.Point, this.selectedBranch.Destination.Point, this.clickedPoint));
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
			this.vmethod_1();
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
					goto IL_CD;
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
			IL_CD:
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
				using (List<CouplingRelation>.Enumerator enumerator2 = pointDeputy.CouplingRelations.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == branch.CouplingRelation)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					branch.CouplingRelation.method_7();
					if (pointDeputy.CouplingRelations.Count == 2)
					{
						CouplingRelation couplingRelation = pointDeputy.CouplingRelations[0];
						if (pointDeputy != couplingRelation.method_1())
						{
							couplingRelation.method_1();
						}
						else
						{
							couplingRelation.method_2();
						}
						PointTool pointTool_ = (pointDeputy == pointDeputy.CouplingRelations[1].method_1()) ? pointDeputy.CouplingRelations[1].method_2() : pointDeputy.CouplingRelations[1].method_1();
						while (pointDeputy.CouplingRelations[1].method_3().Count > 0)
						{
							pointDeputy.CouplingRelations[1].method_3()[0].CouplingRelation = couplingRelation;
						}
						pointDeputy.CouplingRelations[1].method_7();
						couplingRelation.method_5(pointDeputy, pointTool_);
						pointDeputy.DeleteSql();
						if (pointDeputy.IdBase != 0)
						{
							pointDeputy.IdBase = 0;
						}
					}
				}
				else
				{
					branch.CouplingRelation.method_5(removedPoint, pointDeputy);
					branch.CouplingRelation = null;
				}
				pointDeputy.RemoveBranch(branch);
				removedPoint.RemoveBranch(branch);
				this.ends.Remove(removedPoint);
				bool flag2 = pointDeputy.Branches.Count<Branch>() == 1;
				int num = 0;
				if (!flag2)
				{
					using (IEnumerator<Branch> enumerator = pointDeputy.Branches.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.Parent == this)
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
					this.Amperages[removedPoint].method_4();
				}
				else
				{
					foreach (Branch branch5 in removedPoint.Branches)
					{
						if (branch5.CouplingRelation.amperagePoint == removedPoint)
						{
							using (IEnumerator<Amperage> enumerator3 = ((LineTool)branch5.Parent).Amperages[removedPoint].method_0().GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									if (enumerator3.Current.Conductor == this)
									{
										((LineTool)branch5.Parent).Amperages[removedPoint].method_4();
									}
									if (!((LineTool)branch5.Parent).Amperages.ContainsKey(removedPoint))
									{
										break;
									}
								}
							}
						}
					}
					if (removedPoint.Parent != null && removedPoint.Parent.GetType() == typeof(ShinaTool) && ((ShinaTool)removedPoint.Parent).Amperage != null)
					{
						((ShinaTool)removedPoint.Parent).Amperage.method_4();
						((ShinaTool)removedPoint.Parent).vmethod_1();
					}
				}
			}
			else
			{
				branch.CouplingRelation.method_5(removedPoint, pointDeputy);
				branch.CouplingRelation = null;
				pointDeputy.RemoveBranch(branch);
				removedPoint.RemoveBranch(branch);
				this.Branches.Remove(branch);
				branch.Remove(true, true);
				foreach (Branch branch6 in removedPoint.Branches)
				{
					if (branch6.Source == removedPoint)
					{
						branch6.Source = pointDeputy;
						branch6.ReCalcSwitchCoords(branch6.Destination.Point, removedPoint.Point, pointDeputy.Point);
					}
					else
					{
						if (branch6.Destination != removedPoint)
						{
							throw new Exception("Данный случай не предусмотрен (ветка принадлежит точке, но точка к ней ни как не относится) , ищи ошибки");
						}
						branch6.Destination = pointDeputy;
						branch6.ReCalcSwitchCoords(branch6.Source.Point, removedPoint.Point, pointDeputy.Point);
					}
					pointDeputy.AddBranch(branch6);
					branch6.CouplingRelation.method_5(removedPoint, pointDeputy);
				}
				if (pointDeputy.CouplingRelations.Count == 2)
				{
					CouplingRelation couplingRelation2 = pointDeputy.CouplingRelations[0];
					if (pointDeputy != couplingRelation2.method_1())
					{
						couplingRelation2.method_1();
					}
					else
					{
						couplingRelation2.method_2();
					}
					PointTool pointTool_2 = (pointDeputy == pointDeputy.CouplingRelations[1].method_1()) ? pointDeputy.CouplingRelations[1].method_2() : pointDeputy.CouplingRelations[1].method_1();
					while (pointDeputy.CouplingRelations[1].method_3().Count > 0)
					{
						pointDeputy.CouplingRelations[1].method_3()[0].CouplingRelation = couplingRelation2;
					}
					pointDeputy.CouplingRelations[1].method_7();
					couplingRelation2.method_5(pointDeputy, pointTool_2);
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
			if (couplingRelation.method_3().Count < 2)
			{
				throw new Exception("в связи одна ветка");
			}
			bool flag = false;
			foreach (Branch branch in couplingRelation.method_3())
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
			while (pointTool2 != couplingRelation.method_2())
			{
				if (pointTool2 == couplingRelation.method_1())
				{
					break;
				}
				if (pointTool2.BranchesCount > 2)
				{
					throw new Exception("Неожиданная ошибка: У точки больше 2-х соурсов, но конец связи ещё не найден :(");
				}
				using (IEnumerator<Branch> enumerator2 = pointTool2.Branches.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Branch branch3 = enumerator2.Current;
						if (branch3 != branch2)
						{
							branch2 = branch3;
							break;
						}
					}
					goto IL_13F;
				}
				goto IL_105;
				IL_113:
				PointTool pointTool3;
				pointTool2 = pointTool3;
				list.Add(branch2);
				if (list.Count >= ((LineTool)branch2.Parent).Branches.Count)
				{
					throw new Exception("Совсем неожиданная ошибка: точка-путешественница не нашла себя связи :'(");
				}
				continue;
				IL_105:
				pointTool3 = branch2.Source;
				goto IL_113;
				IL_13F:
				if (pointTool2 != branch2.Source)
				{
					goto IL_105;
				}
				pointTool3 = branch2.Destination;
				goto IL_113;
			}
			couplingRelation.method_5(pointTool2, pointTool);
			CouplingRelation couplingRelation2 = this.CreateRelation(pointTool, pointTool2);
			foreach (Branch branch4 in list)
			{
				branch4.CouplingRelation = couplingRelation2;
			}
		}

		private void method_10(object sender, EventArgs e)
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

		private void method_11(object sender, EventArgs e)
		{
			if (new BranchPropertyesForm(this.selectedBranch).ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
			}
		}

		private void method_12(PointTool pointTool_0, Branch branch_0, List<PointTool> list_2)
		{
			if (list_2.Contains(pointTool_0))
			{
				return;
			}
			list_2.Add(pointTool_0);
			foreach (DrawObjectBase drawObjectBase in pointTool_0.Branches)
			{
				if (drawObjectBase.GetType() == typeof(Branch) && (Branch)drawObjectBase != branch_0 && ((Branch)drawObjectBase).Parent == this)
				{
					if (((Branch)drawObjectBase).Destination == pointTool_0)
					{
						this.method_12(((Branch)drawObjectBase).Source, (Branch)drawObjectBase, list_2);
					}
					else if (((Branch)drawObjectBase).Source == pointTool_0)
					{
						this.method_12(((Branch)drawObjectBase).Destination, (Branch)drawObjectBase, list_2);
					}
				}
			}
		}

		public void AddAmperage(PointTool amperagePoint, Amperage amperage)
		{
			if (this.Amperages.ContainsKey(amperagePoint))
			{
				using (IEnumerator<Amperage> enumerator = amperage.method_0().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Amperage amperage2 = enumerator.Current;
						if (!this.Amperages[amperagePoint].method_0().Contains(amperage2))
						{
							this.Amperages[amperagePoint].method_6(amperage2);
							amperage2.NextAmperages.Add(this.Amperages[amperagePoint]);
							amperage2.NextAmperages.Remove(amperage);
						}
					}
					goto IL_9A;
				}
			}
			this.Amperages.Add(amperagePoint, amperage);
			this.vmethod_1();
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
					this.vmethod_1();
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
				if (this.Amperages[key].method_0() == mediator)
				{
					return this.Amperages[key];
				}
			}
			return null;
		}

		public void RcA()
		{
			this.vmethod_1();
		}

		internal override void vmethod_1()
		{
			int i = 0;
			List<PointTool> list = this.Amperages.Keys.ToList<PointTool>();
			while (i < list.Count)
			{
				PointTool pointTool_ = list[i++];
				this.method_13(pointTool_);
			}
		}

		internal void method_13(PointTool pointTool_0)
		{
			if (pointTool_0 != null)
			{
				this.method_14(pointTool_0, null, pointTool_0);
			}
		}

		private void method_14(PointTool pointTool_0, CouplingRelation couplingRelation_0, PointTool pointTool_1)
		{
			int idBase = this.IdBase;
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
							if (couplingRelation.Line != this && couplingRelation.Line.Layer != null && couplingRelation.Line != amperage.method_0())
							{
								if (!couplingRelation.Line.Amperages.ContainsKey(pointTool_0) && couplingRelation.amperagePoint == null)
								{
									Amperage amperage2 = amperage.method_1(couplingRelation.Line);
									if (amperage2 != null)
									{
										couplingRelation.Line.AddAmperage(pointTool_0, amperage2);
									}
								}
								else if (couplingRelation.amperagePoint != null && couplingRelation.Line.Amperages[couplingRelation.amperagePoint].Source == amperage.Source && couplingRelation.Line.Layer != null && !amperage.method_7(couplingRelation.Line))
								{
									Amperage amperage3 = amperage.method_1(couplingRelation.Line);
									if (amperage3 != null)
									{
										couplingRelation.Line.AddAmperage(pointTool_0, amperage3);
									}
								}
							}
						}
						goto IL_20D;
					}
				}
				if (pointTool_0.Parent != null && pointTool_0.Parent.Layer != null && pointTool_0.Parent.GetType() != typeof(LineCellTool) && amperage.method_0() != pointTool_0.Parent)
				{
					if (((ShinaTool)pointTool_0.Parent).Amperage == null)
					{
						Amperage amperage4 = amperage.method_1(pointTool_0.Parent);
						if (amperage4 != null)
						{
							((ShinaTool)pointTool_0.Parent).Amperage = amperage4;
						}
					}
					else if (((ShinaTool)pointTool_0.Parent).Amperage.method_0() != this && ((ShinaTool)pointTool_0.Parent).Amperage.Source != amperage.Source)
					{
						this.Layer.Parent.SendMessage(this, "Не предусмотренное замыкание в цепи.", eMessageType.Warning);
					}
				}
			}
			IL_20D:
			foreach (CouplingRelation couplingRelation2 in pointTool_0.CouplingRelations)
			{
				if (couplingRelation2.Line == this && couplingRelation2.Line != amperage.method_0() && couplingRelation2 != couplingRelation_0)
				{
					List<DrawObjectBase> list = couplingRelation2.method_0();
					PointTool pointTool = (pointTool_0 == couplingRelation2.method_1()) ? couplingRelation2.method_2() : couplingRelation2.method_1();
					if (this.Amperages.ContainsKey(pointTool) && couplingRelation2.amperagePoint == pointTool && couplingRelation2.On)
					{
						if (this.Amperages[pointTool].Source != amperage.Source)
						{
							this.Layer.Parent.SendMessage(this, "короткое замыкание (встреча с другим тока в одной не разомкнутой линии)", eMessageType.Error);
						}
						else
						{
							this.method_14(pointTool, couplingRelation2, pointTool_1);
						}
					}
					else if (couplingRelation2.amperagePoint == null)
					{
						couplingRelation2.amperagePoint = pointTool_1;
						foreach (DrawObjectBase drawObjectBase in list)
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
							this.method_14(pointTool, couplingRelation2, pointTool_1);
						}
					}
					else if (couplingRelation2.On && couplingRelation2.amperagePoint == pointTool_1)
					{
						this.method_14(pointTool, couplingRelation2, pointTool_1);
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
			this.method_15();
			this.vmethod_4();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.Layer.Parent.SqlSettings);
			Class22 @class = new Class22();
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
			sqlDataCommand.SelectSqlData(@class.tSchm_Xml, false, text, null, false, 0);
			if (@class.tSchm_Xml.Rows.Count > 0)
			{
				@class.tSchm_Xml.Rows[0]["SchemaXml"] = this.xmlCoords.InnerXml;
				if (@class.tSchm_Xml.Rows[0]["Tag"] == null && rectangleTool != null)
				{
					@class.tSchm_Xml.Rows[0]["Tag"] = rectangleTool.IdBase;
				}
				@class.tSchm_Xml.Rows[0].EndEdit();
				return sqlDataCommand.UpdateSqlData(@class, @class.tSchm_Xml);
			}
			@class.tSchm_Xml.method_1(this.IdBase, (int)this.Layer.Parent.TypeCanvas, this.xmlCoords.InnerXml);
			return sqlDataCommand.InsertSqlData(@class, @class.tSchm_Xml);
		}

		private void method_15()
		{
			foreach (CouplingRelation couplingRelation in this.couplingRealationsList_0)
			{
				couplingRelation.method_1().SaveToSql(false, false);
				couplingRelation.method_2().SaveToSql(false, false);
				SqlDataCommand sqlDataCommand = new SqlDataCommand(this.Layer.Parent.SqlSettings);
				Class22 @class = new Class22();
				if (couplingRelation.Id > 0)
				{
					sqlDataCommand.SelectSqlData(@class.tSchm_Relation, false, "where id = " + couplingRelation.Id.ToString(), null, false, 0);
					if (@class.tSchm_Relation.Rows.Count > 0)
					{
						bool flag = false;
						if ((int)@class.tSchm_Relation.Rows[0]["SourceObj"] != couplingRelation.method_1().IdBase)
						{
							@class.tSchm_Relation.Rows[0]["SourceObj"] = couplingRelation.method_1().IdBase;
							flag = true;
						}
						if ((int)@class.tSchm_Relation.Rows[0]["DestObj"] != couplingRelation.method_2().IdBase)
						{
							@class.tSchm_Relation.Rows[0]["DestObj"] = couplingRelation.method_2().IdBase;
							flag = true;
						}
						if ((int)@class.tSchm_Relation.Rows[0]["Edge"] != this.IdBase)
						{
							@class.tSchm_Relation.Rows[0]["Edge"] = this.IdBase;
							flag = true;
						}
						if (flag)
						{
							@class.tSchm_Relation.Rows[0].EndEdit();
							sqlDataCommand.UpdateSqlData(@class, @class.tSchm_Relation);
						}
					}
				}
				else
				{
					DataRow dataRow = @class.tSchm_Relation.NewRow();
					dataRow["SourceObj"] = couplingRelation.method_1().IdBase;
					dataRow["DestObj"] = couplingRelation.method_2().IdBase;
					dataRow["Edge"] = this.IdBase;
					@class.tSchm_Relation.Rows.Add(dataRow);
					couplingRelation.Id = sqlDataCommand.InsertSqlDataOneRow(@class.tSchm_Relation);
				}
			}
		}

		private void method_16(DrawObjectBase drawObjectBase_2)
		{
			int num = 1;
			foreach (CouplingRelation couplingRelation in this.couplingRealationsList_0)
			{
				int num2 = 0;
				if (drawObjectBase_2 != couplingRelation.method_1() && int.TryParse(couplingRelation.method_1().Text, out num2) && num <= num2)
				{
					num = num2 + 1;
				}
				if (drawObjectBase_2 != couplingRelation.method_2() && int.TryParse(couplingRelation.method_2().Text, out num2) && num <= num2)
				{
					num = num2 + 1;
				}
			}
			drawObjectBase_2.Text = num.ToString();
		}

		public override string GetUpdateScriptXML(bool children, List<int> id)
		{
			if (this.IdBase <= 0)
			{
				return "";
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (CouplingRelation couplingRelation in this.CouplingRelations)
			{
				stringBuilder.Append(couplingRelation.method_1().GetUpdateScriptXML(false, id));
				stringBuilder.Append(couplingRelation.method_2().GetUpdateScriptXML(false, id));
			}
			this.vmethod_4();
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
			text = string.Concat(new string[]
			{
				text,
				" where Objid = ",
				this.IdBase.ToString(),
				" AND TypeSchema = ",
				((int)this.Layer.Parent.TypeCanvas).ToString()
			});
			if (rectangleTool != null)
			{
				text = text + " AND (Tag = " + rectangleTool.IdBase.ToString() + " OR Tag is NULL)";
			}
			if (id.Contains(this.IdBase))
			{
				text = "";
			}
			else
			{
				id.Add(this.IdBase);
			}
			return " " + stringBuilder + text;
		}

		protected override void vmethod_4()
		{
			base.vmethod_4();
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
			Branch result = null;
			try
			{
				CouplingRelation couplingRelation = this.CouplingRelations.Single((CouplingRelation o) => o.Id == idCouplingRelation);
				if (couplingRelation != null && couplingRelation.method_3().Count > numBranch)
				{
					result = couplingRelation.method_3()[numBranch];
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
				while (this.couplingRealationsList_0.Count > 0)
				{
					this.couplingRealationsList_0[0].Dispose();
					this.couplingRealationsList_0.RemoveAt(0);
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
		private bool method_17(Branch branch_0)
		{
			return branch_0.Parent != this;
		}

		protected List<PointTool> ends;

		private CouplingRealationsList couplingRealationsList_0;

		protected List<PointTool> pointToolList;

		protected List<Branch> branches;

		protected PointTool selectedPoint;

		protected Branch selectedBranch;

		protected UnitPoint clickedPoint;

		protected List<LineToolState> states;

		private bool bool_7;

		public Dictionary<PointTool, Amperage> Amperages;

		private Color color_3;

		private string string_2;

		[CompilerGenerated]
		private LineToolEventHandler lineToolEventHandler_0;

		[CompilerGenerated]
		private LineToolEventHandler lineToolEventHandler_1;

		[CompilerGenerated]
		private LineToolEventHandler lineToolEventHandler_2;

		[CompilerGenerated]
		private LineToolEventHandler lineToolEventHandler_3;

		[CompilerGenerated]
		private LineToolEventHandler lineToolEventHandler_4;

		private class Class15
		{
			public Class15()
			{
				Class90.TDroV38zslI2T();
				base..ctor();
			}

			internal string string_0;

			internal int int_0;

			internal string string_1;

			internal PointTool pointTool_0;
		}
	}
}
