using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataSql;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.ElectricModel.Calculations;

namespace SchemeCtrl2.ElectricModel
{
	public class ElectricModel
	{
		public IEnumerable<ElectricObject> Objects
		{
			get
			{
				return this.objects;
			}
		}

		public SQLSettings SqlSettings { get; set; }

		public ElectricModel()
		{
			this.objects = new List<ElectricObject>();
			this.loadedPoints = new Dictionary<int, ElectricPoint>();
		}

		public void LoadSchema()
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			try
			{
				if (sqlDataConnect.OpenConnection(this.SqlSettings))
				{
					DataTable dataTable = new DataTable();
					Dictionary<int, ElectricObject> dictionary = new Dictionary<int, ElectricObject>();
					string text = "";
					foreach (object obj in Enum.GetValues(typeof(eTypeRectangleTool)))
					{
						eTypeRectangleTool eTypeRectangleTool = (eTypeRectangleTool)obj;
						text = text + Convert.ToInt32(eTypeRectangleTool).ToString() + ",";
					}
					text = text.Remove(text.Length - 1);
					string selectCommandText = "SELECT \r\n\t                                     obj.[Id]\r\n                                          ,obj.[Name]\r\n                                          ,obj.typecodeid\r\n                                          ,(case When oc.value is null then 0 else 1 end) as isSubscriber\r\n                                      FROM [tSchm_ObjList] as obj\r\n                                      left join tP_Passport as p on p.idObjList = obj.[Id] and p.deleted = 0 and isActive = 1\r\n                                      left join tP_ObjectChar as oc on oc.[idPassport] = p.id and oc.idobjchar = 174 and oc.value = 293 and oc.deleted=0\r\n                                      where obj.typecodeid in (" + text + ") and obj.deleted=0";
					new SqlDataAdapter(selectCommandText, sqlDataConnect.Connection)
					{
						SelectCommand = 
						{
							CommandTimeout = 0
						}
					}.Fill(dataTable);
					foreach (object obj2 in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj2;
						ElectricSubstation electricSubstation = new ElectricSubstation();
						electricSubstation.Id = Convert.ToInt32(dataRow["Id"]);
						electricSubstation.Name = dataRow["Name"].ToString();
						electricSubstation.TypeSubstation = (eTypeRectangleTool)Convert.ToInt32(dataRow["TypeCodeId"]);
						electricSubstation.Tag = Convert.ToBoolean(dataRow["isSubscriber"]);
						this.objects.Add(electricSubstation);
						dictionary.Add(electricSubstation.Id, electricSubstation);
					}
					DataTable dataTable2 = new DataTable();
					text = "";
					foreach (object obj3 in Enum.GetValues(typeof(eTypeShinaTool)))
					{
						eTypeShinaTool eTypeShinaTool = (eTypeShinaTool)obj3;
						text = text + Convert.ToInt32(eTypeShinaTool).ToString() + ",";
					}
					text = text.Remove(text.Length - 1);
					selectCommandText = " select id, name, idParent from vSChm_ObjListXml s1 where s1.typeSchema = 1 and deleted = 0 and typeCodeId = 111  union all  select id, name, idParent from vSChm_ObjListXml s2 where s2.typeSchema = 2 and deleted = 0  and s2.id not in (select id from vSchm_ObjListxml where typeSchema = 1) and typeCodeId = 111 ";
					new SqlDataAdapter(selectCommandText, sqlDataConnect.Connection)
					{
						SelectCommand = 
						{
							CommandTimeout = 0
						}
					}.Fill(dataTable2);
					dataTable = new DataTable();
					text = "";
					foreach (object obj4 in Enum.GetValues(typeof(eTypeShinaTool)))
					{
						eTypeShinaTool eTypeShinaTool2 = (eTypeShinaTool)obj4;
						text = text + Convert.ToInt32(eTypeShinaTool2).ToString() + ",";
					}
					text = text.Remove(text.Length - 1);
					selectCommandText = string.Concat(new string[]
					{
						" select id, name, idParent, typeCodeId from vSChm_ObjListXml s1 where s1.typeSchema = 1 and deleted = 0 and typeCodeId in (",
						text,
						")  union all  select id, name,  idParent, typeCodeId from vSChm_ObjListXml s2 where s2.typeSchema = 2 and deleted = 0  and s2.id not in (select id from vSchm_ObjListxml where typeSchema = 1) and typeCodeId in (",
						text,
						") "
					});
					new SqlDataAdapter(selectCommandText, sqlDataConnect.Connection)
					{
						SelectCommand = 
						{
							CommandTimeout = 0
						}
					}.Fill(dataTable);
					foreach (object obj5 in dataTable.Rows)
					{
						DataRow dataRow2 = (DataRow)obj5;
						ElectricBus electricBus = new ElectricBus();
						electricBus.Id = Convert.ToInt32(dataRow2["Id"]);
						electricBus.Name = dataRow2["Name"].ToString();
						electricBus.TypeBus = (eTypeShinaTool)Convert.ToInt32(dataRow2["TypeCodeId"]);
						if (dictionary.ContainsKey(Convert.ToInt32(dataRow2["idParent"])))
						{
							electricBus.Parent = dictionary[Convert.ToInt32(dataRow2["idParent"])];
						}
						this.objects.Add(electricBus);
						DataRow[] array = dataTable2.Select(" IdParent = " + electricBus.Id.ToString());
						foreach (DataRow dataRow3 in array)
						{
							ElectricPoint electricPoint = new ElectricPoint();
							electricPoint.Id = Convert.ToInt32(dataRow3["id"]);
							electricPoint.Parent = electricBus;
							electricPoint.ParentModel = this;
							this.loadedPoints.Add(electricPoint.Id, electricPoint);
						}
					}
					dataTable = new DataTable();
					text = "";
					foreach (object obj6 in Enum.GetValues(typeof(LineToolType)))
					{
						LineToolType lineToolType = (LineToolType)obj6;
						text = text + Convert.ToInt32(lineToolType).ToString() + ",";
					}
					text = text.Remove(text.Length - 1);
					selectCommandText = string.Concat(new string[]
					{
						" select id, idParent, name from vSChm_ObjListXml s1 where s1.typeSchema = 1 and deleted = 0 and typeCodeId in (",
						text,
						")  union all  select id,  idParent, name from vSChm_ObjListXml s2 where s2.typeSchema = 2 and deleted = 0  and s2.id not in (select id from vSchm_ObjListxml where typeSchema = 1) and typeCodeId in (",
						text,
						") "
					});
					new SqlDataAdapter(selectCommandText, sqlDataConnect.Connection)
					{
						SelectCommand = 
						{
							CommandTimeout = 0
						}
					}.Fill(dataTable);
					DataTable dataTable3 = new DataTable();
					selectCommandText = " select * from tSchm_Relation ";
					new SqlDataAdapter(selectCommandText, sqlDataConnect.Connection)
					{
						SelectCommand = 
						{
							CommandTimeout = 0
						}
					}.Fill(dataTable3);
					DataTable dataTable4 = new DataTable();
					text = "";
					foreach (object obj7 in Enum.GetValues(typeof(TypeSwitch)))
					{
						LineToolType lineToolType2 = (LineToolType)obj7;
						text = text + Convert.ToInt32(lineToolType2).ToString() + ",";
					}
					text = text.Remove(text.Length - 1);
					selectCommandText = string.Concat(new string[]
					{
						" select id, idParent, OnOff, TypeCodeId from vSChm_ObjListXml s1 where s1.typeSchema = 1 and deleted = 0 and typeCodeId in (",
						text,
						")  union all  select id, idParent, OnOff, TypeCodeId from vSChm_ObjListXml s2 where s2.typeSchema = 2 and deleted = 0  and s2.id not in (select id from vSchm_ObjListxml where typeSchema = 1) and typeCodeId in (",
						text,
						") "
					});
					new SqlDataAdapter(selectCommandText, sqlDataConnect.Connection)
					{
						SelectCommand = 
						{
							CommandTimeout = 0
						}
					}.Fill(dataTable4);
					foreach (object obj8 in dataTable.Rows)
					{
						DataRow dataRow4 = (DataRow)obj8;
						ElectricLine electricLine = new ElectricLine();
						electricLine.Id = Convert.ToInt32(dataRow4["id"]);
						electricLine.Name = dataRow4["Name"].ToString();
						if (dataRow4["IdParent"] != DBNull.Value && dictionary.ContainsKey(Convert.ToInt32(dataRow4["IdParent"])))
						{
							electricLine.Parent = dictionary[Convert.ToInt32(dataRow4["IdParent"])];
						}
						DataRow[] array3 = dataTable3.Select("Edge = " + electricLine.Id.ToString());
						foreach (DataRow dataRow5 in array3)
						{
							ElectricPoint electricPoint2;
							if (this.loadedPoints.ContainsKey(Convert.ToInt32(dataRow5["SourceObj"])))
							{
								electricPoint2 = this.loadedPoints[Convert.ToInt32(dataRow5["SourceObj"])];
							}
							else
							{
								electricPoint2 = new ElectricPoint();
								electricPoint2.Id = Convert.ToInt32(dataRow5["SourceObj"]);
								electricPoint2.ParentModel = this;
								this.loadedPoints.Add(electricPoint2.Id, electricPoint2);
							}
							ElectricPoint electricPoint3;
							if (this.loadedPoints.ContainsKey(Convert.ToInt32(dataRow5["DestObj"])))
							{
								electricPoint3 = this.loadedPoints[Convert.ToInt32(dataRow5["DestObj"])];
							}
							else
							{
								electricPoint3 = new ElectricPoint();
								electricPoint3.Id = Convert.ToInt32(dataRow5["DestObj"]);
								electricPoint3.ParentModel = this;
								this.loadedPoints.Add(electricPoint3.Id, electricPoint3);
							}
							ElectricRelation electricRelation = new ElectricRelation(electricPoint2, electricPoint3);
							electricRelation.Id = Convert.ToInt32(dataRow5["id"]);
							electricRelation.Parent = electricLine;
							electricLine.Relations.Add(electricRelation);
							DataRow[] array5 = dataTable4.Select("IdParent = " + electricRelation.Id.ToString());
							foreach (DataRow dataRow6 in array5)
							{
								ElectricSwitch electricSwitch = new ElectricSwitch();
								electricSwitch.Id = Convert.ToInt32(dataRow6["id"]);
								electricSwitch.TypeSwitch = (TypeSwitch)Convert.ToInt32(dataRow6["TypeCodeId"]);
								electricSwitch.Parent = electricRelation;
								if (dataRow6["OnOff"] != DBNull.Value)
								{
									electricSwitch.On = Convert.ToBoolean(dataRow6["OnOff"]);
								}
								this.objects.Add(electricSwitch);
							}
						}
						this.objects.Add(electricLine);
					}
					this.OnSimulate();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void OnSimulate()
		{
			IEnumerable<ElectricObject> source = this.objects;
			if (ElectricModel.func_0 == null)
			{
				ElectricModel.func_0 = new Func<ElectricObject, bool>(ElectricModel.smethod_0);
			}
			foreach (ElectricObject electricObject in source.Where(ElectricModel.func_0))
			{
				((ElectricBus)electricObject).OnAmperage = true;
			}
		}

		public void OffSimulate()
		{
			IEnumerable<ElectricObject> source = this.objects;
			if (ElectricModel.func_1 == null)
			{
				ElectricModel.func_1 = new Func<ElectricObject, bool>(ElectricModel.smethod_1);
			}
			foreach (ElectricObject electricObject in source.Where(ElectricModel.func_1))
			{
				((ElectricBus)electricObject).OnAmperage = false;
			}
		}

		public void RefreshSimulate()
		{
			this.OffSimulate();
			this.OnSimulate();
		}

		public List<ElectricObject> PoweringReportForDrawObject(ElectricObject electricObject_0, bool forwardDirection, bool withoutLastCell)
		{
			TreeNodeObj treeNodeObj_ = this.PoweringReportForDrawObject(electricObject_0, forwardDirection);
			List<ElectricObject> list = new List<ElectricObject>();
			this.method_0(treeNodeObj_, list, withoutLastCell);
			return list;
		}

		private void method_0(TreeNodeObj treeNodeObj_0, List<ElectricObject> list_0, bool bool_0)
		{
			if (treeNodeObj_0.Tag != null && treeNodeObj_0.Tag is ElectricObject && !list_0.Contains((ElectricObject)treeNodeObj_0.Tag))
			{
				if (treeNodeObj_0.Tag.GetType() == typeof(ElectricBus) && !list_0.Contains(((ElectricObject)treeNodeObj_0.Tag).Parent))
				{
					list_0.Add(((ElectricObject)treeNodeObj_0.Tag).Parent);
				}
				if (bool_0 && treeNodeObj_0.IsLeaf && treeNodeObj_0.Tag.GetType() == typeof(ElectricLine) && ((ElectricLine)treeNodeObj_0.Tag).IsCell())
				{
					bool flag = true;
					ElectricLine electricLine = (ElectricLine)treeNodeObj_0.Tag;
					foreach (ElectricRelation electricRelation in electricLine.Relations)
					{
						if (!electricRelation.On)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						list_0.Add((ElectricObject)treeNodeObj_0.Tag);
					}
				}
				else
				{
					list_0.Add((ElectricObject)treeNodeObj_0.Tag);
				}
			}
			foreach (TreeNodeObj treeNodeObj_ in treeNodeObj_0.Nodes)
			{
				this.method_0(treeNodeObj_, list_0, bool_0);
			}
		}

		public TreeNodeObj PoweringReportForDrawObject(ElectricObject electricObject_0, bool forwardDirection)
		{
			if (electricObject_0 is ElectricSubstation)
			{
				return this.method_1((ElectricSubstation)electricObject_0, forwardDirection);
			}
			if (electricObject_0 is ElectricBus)
			{
				return this.method_2((ElectricBus)electricObject_0, forwardDirection);
			}
			if (electricObject_0 is ElectricLine)
			{
				return this.method_3((ElectricLine)electricObject_0, forwardDirection);
			}
			return new TreeNodeObj
			{
				Tag = electricObject_0
			};
		}

		private TreeNodeObj method_1(ElectricSubstation electricSubstation_0, bool bool_0)
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = electricSubstation_0;
			IEnumerable<ElectricObject> childObjects = electricSubstation_0.ChildObjects;
			if (ElectricModel.func_2 == null)
			{
				ElectricModel.func_2 = new Func<ElectricObject, bool>(ElectricModel.smethod_2);
			}
			foreach (ElectricObject electricObject in childObjects.Where(ElectricModel.func_2))
			{
				treeNodeObj.AddNode(this.method_2((ElectricBus)electricObject, bool_0));
			}
			return treeNodeObj;
		}

		private TreeNodeObj method_2(ElectricBus electricBus_0, bool bool_0)
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = electricBus_0;
			if (electricBus_0.Amperage == null)
			{
				return treeNodeObj;
			}
			if (bool_0)
			{
				using (List<Amperage>.Enumerator enumerator = electricBus_0.Amperage.NextAmperages.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Amperage amperage = enumerator.Current;
						int id = amperage.Conductor.Id;
						this.method_5(amperage, treeNodeObj);
					}
					return treeNodeObj;
				}
			}
			List<ElectricObject> list = this.method_4(electricBus_0);
			if (list == null)
			{
				return treeNodeObj;
			}
			TreeNodeObj treeNodeObj_ = treeNodeObj;
			foreach (ElectricObject electricObject_ in list)
			{
				TreeNodeObj treeNodeObj2 = this.method_6(treeNodeObj_, electricObject_);
				if (treeNodeObj2 != null)
				{
					treeNodeObj_ = treeNodeObj2;
				}
			}
			return treeNodeObj;
		}

		private TreeNodeObj method_3(ElectricLine electricLine_0, bool bool_0)
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = electricLine_0;
			foreach (Amperage amperage in electricLine_0.Amperages.Values)
			{
				if (bool_0)
				{
					using (List<Amperage>.Enumerator enumerator2 = amperage.NextAmperages.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Amperage amperage_ = enumerator2.Current;
							this.method_5(amperage_, treeNodeObj);
						}
						continue;
					}
				}
				List<ElectricObject> powerSource = amperage.GetPowerSource();
				TreeNodeObj treeNodeObj_ = treeNodeObj;
				foreach (ElectricObject electricObject_ in powerSource)
				{
					TreeNodeObj treeNodeObj2 = this.method_6(treeNodeObj_, electricObject_);
					if (treeNodeObj2 != null)
					{
						treeNodeObj_ = treeNodeObj2;
					}
				}
			}
			return treeNodeObj;
		}

		private List<ElectricObject> method_4(ElectricBus electricBus_0)
		{
			if (electricBus_0.Amperage != null)
			{
				return electricBus_0.Amperage.GetPowerSource();
			}
			return null;
		}

		private void method_5(Amperage amperage_0, TreeNodeObj treeNodeObj_0)
		{
			TreeNodeObj treeNodeObj = this.method_6(treeNodeObj_0, amperage_0.Conductor);
			if (treeNodeObj == null)
			{
				return;
			}
			foreach (Amperage amperage_ in amperage_0.NextAmperages)
			{
				this.method_5(amperage_, treeNodeObj);
			}
		}

		private TreeNodeObj method_6(TreeNodeObj treeNodeObj_0, ElectricObject electricObject_0)
		{
			if (electricObject_0 != treeNodeObj_0.Tag)
			{
				TreeNodeObj treeNodeObj = treeNodeObj_0.AddNode();
				treeNodeObj.Tag = electricObject_0;
				return treeNodeObj;
			}
			return null;
		}

		[CompilerGenerated]
		private static bool smethod_0(ElectricObject electricObject_0)
		{
			return electricObject_0.GetType() == typeof(ElectricBus) && electricObject_0.Parent != null && electricObject_0.Parent.GetType() == typeof(ElectricSubstation) && ((ElectricSubstation)electricObject_0.Parent).TypeSubstation == eTypeRectangleTool.CP;
		}

		[CompilerGenerated]
		private static bool smethod_1(ElectricObject electricObject_0)
		{
			return electricObject_0.GetType() == typeof(ElectricBus) && electricObject_0.Parent.GetType() == typeof(ElectricSubstation) && ((ElectricSubstation)electricObject_0.Parent).TypeSubstation == eTypeRectangleTool.CP;
		}

		[CompilerGenerated]
		private static bool smethod_2(ElectricObject electricObject_0)
		{
			return electricObject_0.GetType() == typeof(ElectricBus) && ((ElectricBus)electricObject_0).Amperage != null;
		}

		private eSimulationMode eSimulationMode_0 = eSimulationMode.Online;

		public List<ElectricObject> objects;

		public Dictionary<int, ElectricPoint> loadedPoints;

		[CompilerGenerated]
		private SQLSettings sqlsettings_0;

		[CompilerGenerated]
		private static Func<ElectricObject, bool> func_0;

		[CompilerGenerated]
		private static Func<ElectricObject, bool> func_1;

		[CompilerGenerated]
		private static Func<ElectricObject, bool> func_2;
	}
}
