using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DataSql;
using Logger;
using SchemeModelN.Calculations;

namespace SchemeModelN
{
	public partial class ElectricModel
	{
        public List<ElectricObject>  Objects   // IEnumerable<ElectricObject>
		{
			get
			{
				return this.listSchmObj;
			}
		}

		public SQLSettings SqlSettings
		{
			get
			{
				return this.sqlsettings;
			}
			set
			{
				this.sqlsettings = value;
				this.setDatabaseGuid();
			}
		}

		public Guid DatabaseGuid
		{
			get
			{
				return this.guid;
			}
		}

		public ElectricModel()
		{
			
			this.guid = Guid.Empty;
			
			this.listSchmObj = new List<ElectricObject>();
			this.listSchmPoint = new Dictionary<int, ElectricPoint>();
		}

		public string[] GetCellCPName(int idObj)
		{
			string[] array = new string[0];
			ElectricObject[] array2 = null;
			ElectricObject electricObjectById = this.GetElectricObjectById(idObj);
			if (electricObjectById != null)
			{
				if (electricObjectById.GetType() == typeof(ElectricBus) && ((ElectricBus)electricObjectById).Amperage != null)
				{
					List<ElectricObject> list = ((ElectricBus)electricObjectById).Amperage.GetPowerSource();
					ElectricObject electricObject = null;
					list.Reverse();
					foreach (ElectricObject electricObject2 in list)
					{
						if (electricObject2.GetType() == typeof(ElectricLine) && ((ElectricLine)electricObject2).IsCell())
						{
							electricObject = electricObject2;
							break;
						}
					}
					if (electricObject != null)
					{
						array2 = new ElectricObject[]
						{
							electricObject
						};
					}
				}
				else
				{
					if (electricObjectById.GetType() == typeof(ElectricLine))
					{
						array2 = new ElectricObject[((ElectricLine)electricObjectById).AmperageCount];
						int num = 0;
						foreach (var enumerator2 in ((ElectricLine)electricObjectById).Amperages.Values)
						{
                            List<ElectricObject> list2 = enumerator2.GetPowerSource();
                            ElectricObject electricObject3 = null;
                            list2.Reverse();
                            foreach (var enumerator in list2)
                            {
                                ElectricObject electricObject4 = enumerator;
                                if (electricObject4.GetType() == typeof(ElectricLine) && ((ElectricLine)electricObject4).IsCell())
                                {
                                    electricObject3 = electricObject4;
                                    break;
                                }
                            }
                            if (electricObject3 != null)
                            {
                                array2[num] = electricObject3;
                            }
                        }
					}
                    else 
					if (electricObjectById.GetType() == typeof(ElectricSwitch))
					{
						ElectricRelation electricRelation = (ElectricRelation)((ElectricSwitch)electricObjectById).Parent;
						if (electricRelation.amperagePoint == null && electricRelation.amperagePoint != null)
						{
							return array;
						}
						List<ElectricObject> list3 = ((ElectricLine)electricRelation.Parent).Amperages[electricRelation.amperagePoint].GetPowerSource();
						ElectricObject electricObject5 = null;
						list3.Reverse();
						foreach (ElectricObject electricObject6 in list3)
						{
							if (electricObject6.GetType() == typeof(ElectricLine) && ((ElectricLine)electricObject6).IsCell())
							{
								electricObject5 = electricObject6;
								break;
							}
						}
						if (electricObject5 != null)
						{
							array2 = new ElectricObject[]
							{
								electricObject5
							};
						}
					}
				}
				array = new string[array2.Length];
				for (int i = 0; i < array2.Length; i++)
				{
					array[i] = string.Format("{0}\\{1}", array2[i].Parent.Name, array2[i].Name);
				}
			}
			return array;
		}

		public string[] GetCPName(int idObj)
		{
			string[] listNameCP = new string[0];
			ElectricObject[] listCellCP = null;
			ElectricObject electricObjectById = this.GetElectricObjectById(idObj);
			if (electricObjectById == null)
			{
				return listNameCP;
			}
			if (electricObjectById.GetType() == typeof(ElectricBus) && ((ElectricBus)electricObjectById).Amperage != null)
			{
				listCellCP = new ElectricObject[]
				{
					((ElectricBus)electricObjectById).Amperage.Source.Parent
				};
			}
			else
			{
				if (electricObjectById.GetType() == typeof(ElectricLine))
				{
					listCellCP = new ElectricObject[((ElectricLine)electricObjectById).AmperageCount];
					int num = 0;
					foreach (var enumerator in ((ElectricLine)electricObjectById).Amperages.Values)
					{
							ElectricAmperage electricAmperage = enumerator;
							listCellCP[num] = electricAmperage.Source.Parent;
					}
				}
				else if (electricObjectById.GetType() == typeof(ElectricSwitch))
				{
					ElectricRelation electricRelation = (ElectricRelation)((ElectricSwitch)electricObjectById).Parent;
					if (electricRelation.amperagePoint == null && electricRelation.amperagePoint != null)
					{
						return listNameCP;
					}
					listCellCP = new ElectricObject[]
					{
						((ElectricLine)electricRelation.Parent).Amperages[electricRelation.amperagePoint].Source.Parent
					};
				}
			}
			listNameCP = new string[listCellCP.Length];
			for (int i = 0; i < listCellCP.Length; i++)
			{
				listNameCP[i] = listCellCP[i].Name;
			}
			return listNameCP;
		}
        /// <summary>
        /// грузим схему
        /// isNormal = true в нормальном режиме
        /// </summary>
        /// <param name="isNormal"></param>
		public void LoadSchema(bool isNormal = false)
		{
			if (this.listSchmObj.Count > 0)
			{
				this.OffSimulate();
				this.listSchmObj.Clear();
			}
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			try
			{
				if (sqlDataConnect.OpenConnection(this.SqlSettings))
				{
                    /*****************************************************************************/
                    // соберем подстанциии (ElectricSubstation)
                    DataTable dataTable = new DataTable();
					this.listSchmPoint = new Dictionary<int, ElectricPoint>();
					Dictionary<int, ElectricObject> dictionary = new Dictionary<int, ElectricObject>();
					StringBuilder stringBuilder = new StringBuilder();
					string txtCodeObjSchm = "";
					//string txtCodeSub = "";
					//foreach (eTypeRectangleTool eTypeRectangleTool in Enum.GetValues(typeof(eTypeRectangleTool)))
					//{
					//	txtCodeSub = txtCodeSub + Convert.ToInt32(eTypeRectangleTool).ToString() + ",";
					//}
					//txtCodeSub = txtCodeSub.Remove(txtCodeSub.Length - 1);
                    // может выборку сделать по @typeObj = ';SCM;PS;'
                    string selectCommandText = "SELECT obj.[Id], obj.[Name], obj.typecodeid" +
                        "                    ,(case When oc.value is null then 0 else 1 end) as isSubscriber, cl.socrname + '-' + obj.Name as FullName  " +
                        "                   FROM [tSchm_ObjList] as obj " +
                        "                   left join tr_classifier as cl on cl.id = obj.typecodeid " +
                        "                   left join tP_Passport as p on p.id = " +
                        "                           (select top 1 id  " +
                        "                             from tp_Passport " +
                        "                              where idObjList = obj.[Id] and deleted = 0 and isActive = 1 " +
                        "                              order by date desc) " +
                        "                    left join tP_ObjectChar as oc on oc.[idPassport] = p.id and oc.idobjchar = 174 and oc.value = 293 and oc.deleted=0 " +
                        // "                       where obj.typecodeid in (" + txtCodeSub + ") and obj.deleted=0 " +
                        "                           where (obj.deleted = 0 and cl.ParentKey like ';SCM;PS;')";
					new SqlDataAdapter(selectCommandText, sqlDataConnect.Connection)
					{
						SelectCommand = 
						{
							CommandTimeout = 0
						}
					}.Fill(dataTable);
					foreach (DataRow dataRow in dataTable.Rows)
					{
						ElectricSubstation electricSubstation = new ElectricSubstation();
						electricSubstation.Id = Convert.ToInt32(dataRow["Id"]);
						electricSubstation.Name = dataRow["Name"].ToString();
                        electricSubstation.TypeSubstation = (eTypeRectangleTool)Convert.ToInt32(dataRow["TypeCodeId"]);
                        electricSubstation.FullName = dataRow["FullName"].ToString().ToUpper();
                        electricSubstation.Tag = Convert.ToBoolean(dataRow["isSubscriber"]);
						this.listSchmObj.Add(electricSubstation);
						dictionary.Add(electricSubstation.Id, electricSubstation);
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append(", ");
						}
						stringBuilder.Append(electricSubstation.Id.ToString());
					}
                    /***********************************************************************************/
                    // соберем узлы (точки)
                    // @typeObj = ';SCM;CP;
                    DataTable dataTablePoint = new DataTable();
					selectCommandText = " select id, name, idParent, 'Точка соединения' as FullName " +
                        "                 from tSChm_ObjList " +
                        "                 where TypeCodeId = 111 " +
                        "                                and deleted = 0";
					new SqlDataAdapter(selectCommandText, sqlDataConnect.Connection)
					{
						SelectCommand = 
						{
							CommandTimeout = 0
						}
					}.Fill(dataTablePoint);
                    /***********************************************************************************/
                    // соберем шины (electricBus) принадлежащие подстанциям
                    // ';SCM;BUS;%'
                    dataTable = new DataTable();
					//txtCodeObjSchm = "";
					//foreach (eTypeShinaTool eTypeShinaTool in Enum.GetValues(typeof(eTypeShinaTool)))
					//{
					//	txtCodeObjSchm = txtCodeObjSchm + Convert.ToInt32(eTypeShinaTool).ToString() + ",";
					//}
					//txtCodeObjSchm = txtCodeObjSchm.Remove(txtCodeObjSchm.Length - 1);
					selectCommandText = string.Format("" +
                        //" select id, name, idParent, typeCodeId  " +
                        //"  from tSchm_ObjList " +
                        //"  where typeCodeId in ({0}) " +
                        //"         and deleted = 0 " +
                        //"         and idParent in (select id from tSChm_ObjList where typeCodeId in ({1}) and deleted = 0)", txtCodeObjSchm, txtCodeSub);
                    "select obj.id, obj.name, obj.idParent, obj.typeCodeId, " +
                       "  clb.socrname + '-' + objb.Name + ' \\ ' + cl.socrname + '-' + obj.Name   FullName " +
                        " from tSchm_ObjList obj " +
                        "    left join tr_classifier cl on cl.id = obj.typecodeid " +
                        "    left join tSChm_ObjList objb on obj.idParent = objb.id " +
                        "    left join tr_classifier clb on clb.id = objb.typecodeid " +
                        " where cl.ParentKey like ';SCM;BUS;%' and obj.deleted = 0  and objb.deleted = 0");


                    new SqlDataAdapter(selectCommandText, sqlDataConnect.Connection)
					{
						SelectCommand = 
						{
							CommandTimeout = 0
						}
					}.Fill(dataTable);
					foreach (DataRow row in dataTable.Rows)
					{
						ElectricBus electricBus = new ElectricBus();
						electricBus.Id = Convert.ToInt32(row["Id"]);
						electricBus.Name = row["Name"].ToString();
                        eTypeShinaTool typeBus = (eTypeShinaTool)Convert.ToInt32(row["TypeCodeId"]);
                        electricBus.TypeBus = typeBus;
                        electricBus.Voltage = this.GetVoltageObject(typeBus, false);
                        electricBus.FullName = row["FullName"].ToString();
                        if (dictionary.ContainsKey(Convert.ToInt32(row["idParent"])))
						{
							electricBus.Parent = dictionary[Convert.ToInt32(row["idParent"])];
						}
						this.listSchmObj.Add(electricBus);
						foreach (DataRow dataRow3 in dataTablePoint.Select(" IdParent = " + electricBus.Id.ToString()))
						{
							ElectricPoint electricPoint = new ElectricPoint();
							electricPoint.Id = Convert.ToInt32(dataRow3["id"]);
							electricPoint.Parent = electricBus;
							electricPoint.ParentModel = this;
							this.listSchmPoint.Add(electricPoint.Id, electricPoint);
						}
					}
                    /***********************************************************************************/
                    // соберем кабельные, воздушные и смешанные (КВЛ) линии
                    // + ячейки
                    dataTable = new DataTable();
					//txtCodeObjSchm = "";
					//foreach (LineToolType lineToolType in Enum.GetValues(typeof(LineToolType)))
					//{
					//	txtCodeObjSchm = txtCodeObjSchm + Convert.ToInt32(lineToolType).ToString() + ",";
					//}
					//txtCodeObjSchm = txtCodeObjSchm.Remove(txtCodeObjSchm.Length - 1);
                    //selectCommandText = string.Format("   select id, idParent, name, typeCodeId from tSchm_ObjList  where typeCodeId in ({0}) " +
                    //    "  and deleted = 0 " +
                    //    "  and (idParent in (select id from tSChm_ObjList where typeCodeid in ({1}) and deleted = 0)  or idParent is null)", txtCodeObjSchm, txtCodeSub);

                    selectCommandText = string.Format("with cellAll (id, fullname) as (select cell.Id id " +
                        "      , ISNULL(clSub.SocrName + '-', '') + sub.Name + '\\' +ISNULL(clBus.SocrName + ' - ', '') + bus.Name +'\\'+ISNULL(clCell.SocrName + ' ', '') + Replace(cell.Name,'яч.','_') fullname " +
                        "                  from tSchm_ObjList AS bus " +
                        "                      left join tr_classifier clbus on clbus.id = bus.typecodeid " +
                        "                      left join tSchm_ObjList AS point ON bus.id = point.IdParent " +
                        "                      left join tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj " +
                        "                      left join tSchm_ObjList AS cell ON cell.id = rel.edge" +
                        "                    left JOIN tR_Classifier AS clCell ON cell.TypeCodeId = clCell.id AND clCell.ParentKey LIKE ';SCM;Cell;%' " +
                        "                    left join tSchm_ObjList AS sub ON sub.id = bus.IdParent " +
                        "                    left join tr_classifier clsub on clsub.id = sub.typecodeid " +
                        "    where  bus.Id != cell.Id and clBus.ParentKey like ';SCM;BUS;%' " +
                        "             and isnull(cell.deleted, 0) = 0 and isnull(bus.deleted, 0) = 0 and isnull(sub.deleted, 0) = 0 " +
                        "             AND isnull(point.deleted, 0) = 0) " +
                        " select cell.id, cell.idParent, cell.name, cell.typeCodeId, (select top 1 fullname from cellall where id = cell.id)  fullname " +
                        "from tSchm_ObjList AS cell " +
                        "    left join tr_classifier clCell on clCell.id = cell.typecodeid " +
                        "    left join tSChm_ObjList sub on cell.idParent = sub.id " +
                        "    left join tr_classifier clSub on clSub.id = sub.typecodeid " +
                        "where(clCell.ParentKey like ';SCM;Cell;%') " +
                        "      and isnull(cell.deleted, 0) = 0 " +
                        "      and((sub.deleted = 0 and clSub.ParentKey like ';SCM;PS;')  or cell.idParent is null) " +
                        "	  and exists(select top 1 fullname from cellall where id = cell.id) " +
                        "union all " +
                        "select cell.id, cell.idParent, cell.name, cell.typeCodeId,   clCell.socrname + '-' + cell.name fullname " +
                        "from tSchm_ObjList AS cell " +
                        "    left join tr_classifier clCell on clCell.id = cell.typecodeid " +
                        "    left join tSChm_ObjList sub on cell.idParent = sub.id " +
                        "    left join tr_classifier clSub on clSub.id = sub.typecodeid " +
                        "where(clCell.ParentKey like ';SCM;Line;') " +
                        "      and isnull(cell.deleted, 0) = 0 " +
                        "      and((sub.deleted = 0 and clSub.ParentKey like ';SCM;PS;')  or cell.idParent is null)");
                    new SqlDataAdapter(selectCommandText, sqlDataConnect.Connection)
					{
						SelectCommand = 
						{
							CommandTimeout = 0
						}
					}.Fill(dataTable);
                    /***********************************************************************************/
                    // Соберем связи (Relation)
                    DataTable dtRelation = new DataTable();
					selectCommandText = " select id, sourceobj, destobj, edge  from tSchm_Relation " +
                        " where edge in (select id from tSchm_ObjList where deleted = 0) " +
                        "  and sourceobj in (select id from tSchm_ObjList where deleted = 0) " +
                        "  and destobj in (select id from tSchm_ObjList where deleted = 0)";

                    new SqlDataAdapter(selectCommandText, sqlDataConnect.Connection)
					{
						SelectCommand = 
						{
							CommandTimeout = 0
						}
					}.Fill(dtRelation);
                    /***********************************************************************************/
                    // соберем оборудование на  линии (edge) - проверить параметр включенния/отключенния
                    DataTable dtSwitch = new DataTable();
					txtCodeObjSchm = "";
					foreach (TypeSwitch typeSwitch in Enum.GetValues(typeof(TypeSwitch)))
					{
						txtCodeObjSchm = txtCodeObjSchm + Convert.ToInt32(typeSwitch).ToString() + ",";
					}
					txtCodeObjSchm = txtCodeObjSchm.Remove(txtCodeObjSchm.Length - 1);
                    // ';SCM;INLINE_OBJ;SWITCH;'
                    // ';SCM;INLINE_OBJ;STATELINE;'
                    if (!isNormal)
					{
						selectCommandText = string.Format("select id, idParent, OnOff, TypeCodeId, Name from tSchm_ObjList " +
                            " where typeCodeId in ({0}) and deleted = 0", txtCodeObjSchm);
					}
					else
					{
						selectCommandText = string.Format(" " +
                            " select o.id, o.idParent, " +
                            "    case when x.SchemaXml.exist('Obj[@IsNormal cast as xs:string? = \"True\"]') = 1 then 0 else 1 end  as OnOff, " +
                            "    o.TypeCodeId, o.Name" +
                            " from tSchm_ObjList o " +
                            " left join tSchm_xml x on x.id = (select top 1 id " +
                            "                                  from tSchm_xml" +
                            "                                  where Objid = o.id" +
                            "                                  order by typeSchema)" +
                            " where typeCodeId in ({0}) and deleted = 0", txtCodeObjSchm);
					}
					new SqlDataAdapter(selectCommandText, sqlDataConnect.Connection)
					{
						SelectCommand = 
						{
							CommandTimeout = 0
						}
					}.Fill(dtSwitch);
                    //*********************************************//
					foreach (DataRow rowLine in dataTable.Rows)
					{
						ElectricLine electricLine = new ElectricLine();
						electricLine.Id = Convert.ToInt32(rowLine["id"]);
						electricLine.Name = rowLine["Name"].ToString();
                        electricLine.FullName = rowLine["FullName"].ToString();
                        LineToolType typeLine = (LineToolType)Convert.ToInt32(rowLine["TypeCodeId"]);
                        electricLine.TypeLine = typeLine;
                        electricLine.Voltage = this.GetVoltageObject(typeLine, false);
                        if (rowLine["IdParent"] != DBNull.Value && dictionary.ContainsKey(Convert.ToInt32(rowLine["IdParent"])))
						{
							electricLine.Parent = dictionary[Convert.ToInt32(rowLine["IdParent"])];
						}
						foreach (DataRow rowEdge in dtRelation.Select("Edge = " + electricLine.Id.ToString()))
						{
							ElectricPoint SourcePoint;
							if (this.listSchmPoint.ContainsKey(Convert.ToInt32(rowEdge["SourceObj"])))
							{
								SourcePoint = this.listSchmPoint[Convert.ToInt32(rowEdge["SourceObj"])];
							}
							else
							{
								SourcePoint = new ElectricPoint();
								SourcePoint.Id = Convert.ToInt32(rowEdge["SourceObj"]);
								SourcePoint.ParentModel = this;
								this.listSchmPoint.Add(SourcePoint.Id, SourcePoint);
							}
							ElectricPoint DestPoint;
							if (this.listSchmPoint.ContainsKey(Convert.ToInt32(rowEdge["DestObj"])))
							{
								DestPoint = this.listSchmPoint[Convert.ToInt32(rowEdge["DestObj"])];
							}
							else
							{
								DestPoint = new ElectricPoint();
								DestPoint.Id = Convert.ToInt32(rowEdge["DestObj"]);
								DestPoint.ParentModel = this;
								this.listSchmPoint.Add(DestPoint.Id, DestPoint);
							}
							ElectricRelation electricRelation = new ElectricRelation(SourcePoint, DestPoint);
							electricRelation.Id = Convert.ToInt32(rowEdge["id"]);
							electricRelation.Parent = electricLine;
							electricLine.Relations.Add(electricRelation);
                            // соберем оборудование на линиях - со статусом отключения
							foreach (DataRow row in dtSwitch.Select("IdParent = " + electricRelation.Id.ToString()))
							{
								ElectricSwitch electricSwitch = new ElectricSwitch();
								electricSwitch.Id = Convert.ToInt32(row["id"]);
								electricSwitch.TypeSwitch = (TypeSwitch)Convert.ToInt32(row["TypeCodeId"]);
								electricSwitch.Name = row["Name"].ToString();
								electricSwitch.Parent = electricRelation;
								if (row["OnOff"] != DBNull.Value)
								{
									electricSwitch.On = Convert.ToBoolean(row["OnOff"]);
								}
								this.listSchmObj.Add(electricSwitch);
							}
						}
						this.listSchmObj.Add(electricLine);
					}
					this.OnSimulate();
				}
			}
			catch (Exception innerException)
			{
				throw new Exception("Ошибка загрузки модели", innerException);
			}
		}
        /// <summary>
        /// грузим схему
        /// </summary>
        /// <param name="date"></param>
		public void LoadSchema(DateTime date)
		{
            //Log.Write(LogLevel.Info, "SchemeModelN", "ElectricModel", "LoadSchema", string.Format("Модель на {0} ", new object[] { date }), null);
            //Log.Write(LogLevel.Info, "SchemeModelN", "ElectricModel", "LoadSchema", string.Format("Модель false", new object[] { }), null);
            this.LoadSchema(false);
            //Log.Write(LogLevel.Info, "SchemeModelN", "ElectricModel", "OffSimulate", string.Format("OffSimulate ", new object[] { }), null);
            this.OffSimulate();
            //Log.Write(LogLevel.Info, "SchemeModelN", "ElectricModel", "SetStatusOffEdges", string.Format("SetStatusOffEdges ", new object[] { date }), null);
            this.SetStatusOffEdges(date);
            //Log.Write(LogLevel.Info, "SchemeModelN", "ElectricModel", "OnSimulate", string.Format("OnSimulate", new object[] { }), null);
            this.OnSimulate("4");
		}

		public void OnSimulate(string info = "")
		{
			foreach (ElectricObject electricObject in from obj in this.listSchmObj
			                                where obj.GetType() == typeof(ElectricBus) && obj.Parent != null && obj.Parent.GetType() == typeof(ElectricSubstation) && ((ElectricSubstation)obj.Parent).TypeSubstation == eTypeRectangleTool.CP
			                                select obj)
			{
                 ((ElectricBus)electricObject).OnAmperage = true;
			}
		}

		public void OffSimulate()
		{
			foreach (ElectricObject electricObject in from obj in this.listSchmObj
			                                        where obj.GetType() == typeof(ElectricBus) && obj.Parent.GetType() == typeof(ElectricSubstation) && ((ElectricSubstation)obj.Parent).TypeSubstation == eTypeRectangleTool.CP
			                                        select obj)
			{
				((ElectricBus)electricObject).OnAmperage = false;
			}
		}

		public void RefreshSimulate()
		{
			this.OffSimulate();
			this.OnSimulate();
		}
        /// <summary>
        /// соберем дерево объектов
        /// forwardDirection = false - смотрим дерево вверх к запитке
        /// forwardDirection = true - смотрим дерево внихз к подчиненным веткам
        /// withounLastCell - формирование списка из подчиненных веток - без всяких херней 
        /// </summary>
        /// <returns></returns>
        public List<ElectricObject> PoweringReportForDrawObject(ElectricObject obj, bool forwardDirection, bool withoutLastCell)
		{
			TreeNodeObj treeNodeObj;
            if (obj is ElectricSubstation)
            {
                ElectricSubstation electricSubstation = (ElectricSubstation)obj;
                treeNodeObj = new TreeNodeObj();
                treeNodeObj.Tag = electricSubstation;
                using (var enumerator = (from o in electricSubstation.ChildObjects
                                         where o.GetType() == typeof(ElectricBus) && ((ElectricBus)o).Amperage != null
                                         select o).GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        ElectricObject electricObject = enumerator.Current;
                        if (((ElectricBus)electricObject).Amperage.Mediators.Count<ElectricAmperage>() > 0)
                        {
                            ElectricLine electricLine_ = (ElectricLine)((ElectricBus)electricObject).Amperage.Mediators.First<ElectricAmperage>().Conductor;
                            treeNodeObj.AddNode(this.AddNodeLine(electricLine_, forwardDirection));
                        }
                        else
                        {
                            treeNodeObj.AddNode(this.AddNodeBus((ElectricBus)electricObject, forwardDirection));
                        }
                    }
                }
            }
            else
                treeNodeObj = this.PoweringReportForDrawObject(obj, forwardDirection);
			List<ElectricObject> list = new List<ElectricObject>();
			this.FillTreeNodesObj(treeNodeObj, list, withoutLastCell);
			return list;
		}
        /// <summary>
        /// соберем дерево объектов
        /// forwardDirection = false - смотрим дерево вверх к запитке
        /// forwardDirection = true - смотрим дерево внихз к подчиненным веткам
        /// </summary>
        /// <returns></returns>
        public TreeNodeObj PoweringReportForDrawObject(ElectricObject obj, bool forwardDirection)
		{
			if (obj is ElectricSubstation)
			{
				return this.AddNodeSubStation((ElectricSubstation)obj, forwardDirection);
			}
			if (obj is ElectricBus)
			{
				return this.AddNodeBus((ElectricBus)obj, forwardDirection);
			}
			if (obj is ElectricRelation)
			{
				return this.AddNodeRelation((ElectricRelation)obj, forwardDirection);
			}
			if (obj is ElectricLine)
			{
				return this.AddNodeLine((ElectricLine)obj, forwardDirection);
			}
			return new TreeNodeObj
			{
				Tag = obj
			};
		}
        /// <summary>
        /// соберем дерево объектов
        /// forwardDirection = false - смотрим дерево вверх к запитке
        /// forwardDirection = true - смотрим дерево внихз к подчиненным веткам
        /// </summary>
        /// <returns></returns>
        public TreeNodeObj PoweringReportForDrawObject(int idSchmObj, bool forwardDirection)
		{
            // Log.Write(LogLevel.Debug, "SchemeModelN", "ElectricModel", "PoweringReportForDrawObject", string.Format("Модель для {0}", new object[] { idSchmObj}), null);
            ElectricObject electricObjectById = this.GetElectricObjectById(idSchmObj);
			if (electricObjectById == null)
			{
				return null;
			}
			return this.PoweringReportForDrawObject(electricObjectById, forwardDirection);
		}


        public ElectricObject GetElectricObjectById(int id)
		{
			ElectricObject electricObject = this.listSchmObj.Find((ElectricObject obj) => obj.Id == id);
			if (electricObject == null)
			{
				Log.Write(LogLevel.Warn, "SchemeModel", "ElectricModel", "GetElectricObjectById", string.Format("Объект с id {0} не был найден в модели {1}:{2}(guid - {3}). Количество загруженных объектов - {4}", new object[]
				{
					id,
					this.SqlSettings.ServerDB,
					this.SqlSettings.DBName,
					this.guid,
					this.listSchmObj.Count
				}), null);
			}
			return electricObject;
		}

        /// <summary>
        /// установка статуса отключения ребра
        /// </summary>
        /// <param name="dateTime"></param>
		public void SetStatusOffEdges(DateTime dateTime)
        {
            // читаем логи действий диспетчеров
            SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(string.Format(" select o.id, \r\n\t\t     ldown.dateLog as dateDown,\r\n\t\t       ldown.action as actionDown,\r\n\t\t       lup.dateLog as dateup,\r\n\t\t       lup.action as actionup\r\n         from tSchm_ObjList o\r\n\t            left join [tSchm_LogDispatcher] lUp on lup.id = (select top 1 id from [tSchm_LogDispatcher]\r\n\t\t\t\t\t\t\t\t\t\t\t     where idObj = o.id and DateLog > '{0}'\r\n\t\t\t\t\t\t\t\t\t\t\t          order by dateLog asc)\r\n\t      left join [tSchm_LogDispatcher] lDown on lDown.id = (select top 1 id from [tSchm_LogDispatcher]\r\n\t\t\t\t\t\t\t\t\t\t\t       where idObj = o.id and DateLog <= '{0}'\r\n\t\t\t\t\t\t\t\t\t\t\t        order by dateLog desc)\r\n        where (lup.id is not null) order by ldown.dateLog", dateTime.ToString("yyyyMMdd HH:mm:ss")), sqlConnection); // order by ldown.dateLog - в оригинале небыло
            DataTable dtLogDispatcher = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dtLogDispatcher.Load(sqlDataReader);
                sqlDataReader.Close();
                sqlConnection.Close();
            }
            catch
            {
            }
            foreach (DataRow dataRow in dtLogDispatcher.Rows)
            {
                SchemeModelN.Calculations.HistorySwitchingItemClass swItemHistory = new SchemeModelN.Calculations.HistorySwitchingItemClass();
                if (dataRow["ActionDown"] != DBNull.Value && dataRow["ActionDown"].ToString().IndexOf("\"Повреждено\"") == -1 && dataRow["ActionDown"].ToString().IndexOf("\"Отсоединено\"") == -1) 
                {
                    swItemHistory.ActionCaption = (string)dataRow["ActionDown"];
                    swItemHistory.IsDown = true;
                }
                else
                {
                    swItemHistory.ActionCaption = (string)dataRow["ActionUp"];
                }
                swItemHistory.SwitchId = (int)dataRow["id"];
                var source = from o in this.listSchmObj
                             where o.Id == swItemHistory.SwitchId
                             select o;
                if (source.Count<ElectricObject>() != 0)
                {
                    ElectricObject electricObject = source.First<ElectricObject>();
                    if (electricObject.GetType() == typeof(ElectricLine))
                    {
                        TypeSwitch ts = TypeSwitch.None;
                        if (swItemHistory.IsDown)
                        {
                            continue;
                        }
                        if (swItemHistory.ActionCaption.IndexOf("\"Повреждено\"") > 0)
                        {
                            ts = TypeSwitch.DamageTool;
                        }
                        else if (swItemHistory.ActionCaption.IndexOf("\"Отсоединено\"") > 0)
                        {
                            ts = TypeSwitch.OffTool;
                        }
                        if (ts == TypeSwitch.None)
                        {
                            continue;
                        }
                        Func<ElectricObject, bool> pObject = null;
                        foreach (ElectricRelation electricRelation in ((ElectricLine)electricObject).Relations)
                        {
                            var childObjects = electricRelation.ChildObjects;
                            Func<ElectricObject, bool> predicate;
                            if ((predicate = pObject) == null)
                            {
                                // predicate = (pObject = ((ElectricObject o) => o.GetType() == typeof(ElectricSwitch) && ((ElectricSwitch)o).TypeSwitch == ts && !((ElectricSwitch)o).On));
                                predicate = (pObject = (o => o.GetType() == typeof(ElectricSwitch) && ((ElectricSwitch)o).TypeSwitch == ts && !((ElectricSwitch)o).On));
                            }
                            var source2 = childObjects.Where(predicate);
                            if (source2.Count<ElectricObject>() != 0)
                            {
                                electricObject = source2.First<ElectricObject>();
                            }
                        }
                        if (electricObject.GetType() == typeof(ElectricLine))
                        {
                            continue;
                        }
                    }
                    ElectricSwitch electricSwitch = (ElectricSwitch)electricObject;
                    swItemHistory.ElectricObject = electricSwitch;
                    if (swItemHistory.Action == 0 || swItemHistory.Action == 2)
                    {
                        electricSwitch.On = !swItemHistory.IsDown;
                    }
                    if (swItemHistory.Action == 1 || swItemHistory.Action == 3)
                    {
                        electricSwitch.On = swItemHistory.IsDown;
                    }
                }
            }
        }

        public List<HistorySwitchingItemClass> ExcursionIntoHistory(DateTime startDate)
		{
			List<HistorySwitchingItemClass> list = new List<HistorySwitchingItemClass>();
			Stack<HistorySwitchingItemClass> stack = new Stack<HistorySwitchingItemClass>();
			SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
			SqlCommand sqlCommand = new SqlCommand(string.Format("SELECT [DateLog]\r\n                                                    ,[idObj]\r\n                                                    ,[Action]\r\n                                                FROM [tSchm_LogDispatcher]\r\n                                                where DateLog > '{0}'\r\n                                                order by DateLog desc", startDate.ToString("yyyyMMdd")), sqlConnection);
			DataTable dataTable = new DataTable();
			try
			{
				sqlConnection.Open();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				dataTable.Load(sqlDataReader);
				sqlDataReader.Close();
				sqlConnection.Close();
			}
			catch
			{
			}
            foreach(DataRow dataRow in dataTable.Rows)
			//using (var enumerator = dataTable.Rows.GetEnumerator())
			{
				//while (enumerator.MoveNext())
				//{
					//object obj = enumerator.Current;
                    //DataRow dataRow = (DataRow)obj;
					HistorySwitchingItemClass swItem = new HistorySwitchingItemClass();
					swItem.ActionCaption = (string)dataRow["Action"];
					swItem.SwitchId = (int)dataRow["idObj"];
					swItem.switchingTime = (DateTime)dataRow["DateLog"];
					var source = from o in this.listSchmObj
					                    where o.Id == swItem.SwitchId
					                    select o;
					if (source.Count<ElectricObject>() != 0)
					{
						ElectricObject electricObject = source.First<ElectricObject>();
						if (electricObject.GetType() == typeof(ElectricLine))
						{
							TypeSwitch ts = TypeSwitch.None;
							if (swItem.ActionCaption.IndexOf("\"Повреждено\"") > 0)
							{
								ts = TypeSwitch.DamageTool;
							}
							else if (swItem.ActionCaption.IndexOf("\"Отсоединено\"") > 0)
							{
								ts = TypeSwitch.OffTool;
							}
							if (ts == TypeSwitch.None)
							{
								continue;
							}
							Func<ElectricObject, bool> pObject = null;
							foreach (ElectricRelation electricRelation in ((ElectricLine)electricObject).Relations)
							{
								var childObjects = electricRelation.ChildObjects;
								Func<ElectricObject, bool> predicate;
								if ((predicate = pObject) == null)
								{
									predicate = (pObject = ((ElectricObject o) => o.GetType() == typeof(ElectricSwitch) && ((ElectricSwitch)o).TypeSwitch == ts && !((ElectricSwitch)o).On));
								}
								var source2 = childObjects.Where(predicate);
								if (source2.Count<ElectricObject>() != 0)
								{
									electricObject = source2.First<ElectricObject>();
								}
							}
							if (electricObject.GetType() == typeof(ElectricLine))
							{
								continue;
							}
						}
						ElectricSwitch electricSwitch = (ElectricSwitch)electricObject;
						swItem.ElectricObject = electricSwitch;
						if (swItem.Action == 0 || swItem.Action == 2)
						{
							electricSwitch.On = true;
						}
						if (swItem.Action == 1 || swItem.Action == 3)
						{
							electricSwitch.On = false;
						}
						stack.Push(swItem);
					}
				//}
				goto IL_3DE;
			}
			IL_2C5:
			HistorySwitchingItemClass historySwitchingItemClass = stack.Pop();
			ElectricSwitch electricSwitch2 = (ElectricSwitch)historySwitchingItemClass.ElectricObject;
			if (historySwitchingItemClass.Action == 0 || historySwitchingItemClass.Action == 2)
			{
				ElectricRelation obj2 = (ElectricRelation)electricSwitch2.Parent;
				List<ElectricObject> list2 = this.PoweringReportForDrawObject(obj2, true, true);
				List<int> list3 = new List<int>();
				foreach (ElectricObject electricObject2 in list2)
				{
					list3.Add(electricObject2.Id);
				}
				historySwitchingItemClass.AddInvolvedObjects(list3);
				electricSwitch2.On = false;
			}
			if (historySwitchingItemClass.Action == 1 || historySwitchingItemClass.Action == 3)
			{
				electricSwitch2.On = true;
				ElectricRelation objRelation = (ElectricRelation)electricSwitch2.Parent;
				List<ElectricObject> list4 = this.PoweringReportForDrawObject(objRelation, true, true);
				List<int> list5 = new List<int>();
				foreach (ElectricObject electricObject3 in list4)
				{
					list5.Add(electricObject3.Id);
				}
				historySwitchingItemClass.AddInvolvedObjects(list5);
			}
			list.Add(historySwitchingItemClass);
			IL_3DE:
			if (stack.Count <= 0)
			{
				return list;
			}
			goto IL_2C5;
		}

		public void AddObject(ElectricObject obj)
		{
			this.listSchmObj.Add(obj);
		}

		public bool RemoveObject(ElectricObject obj)
		{
			return this.listSchmObj.Remove(obj);
		}
        /// <summary>
        /// заполнить узлами дерево объектов
        /// </summary>
        /// <param name="nodesObj"></param>
        /// <param name="listObj"></param>
        /// <param name="forwardDirection"></param>
		private void FillTreeNodesObj(TreeNodeObj nodesObj, List<ElectricObject> listObj, bool forwardDirection)
		{
			if (nodesObj.Tag != null && nodesObj.Tag is ElectricObject && !listObj.Contains((ElectricObject)nodesObj.Tag))
			{
				if (nodesObj.Tag.GetType() == typeof(ElectricBus) && !listObj.Contains(((ElectricObject)nodesObj.Tag).Parent))
				{
					listObj.Add(((ElectricObject)nodesObj.Tag).Parent);
				}
				if (forwardDirection && nodesObj.IsLeaf && nodesObj.Tag.GetType() == typeof(ElectricLine) && ((ElectricLine)nodesObj.Tag).IsCell())
				{
					bool flag = true;
					//using (List<ElectricRelation>.Enumerator enumerator = ((ElectricLine)treeNodeObj.Tag).Relations.GetEnumerator())
					//{
					//	while (enumerator.MoveNext())
					//	{
					//		if (!enumerator.Current.On)
					//		{
					//			flag = false;
					//			break;
					//		}
					//	}
					//}
                    foreach (var enumerator in ((ElectricLine)nodesObj.Tag).Relations)
                    {
                        if (!enumerator.On)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
					{
						listObj.Add((ElectricObject)nodesObj.Tag);
					}
				}
				else
				{
					listObj.Add((ElectricObject)nodesObj.Tag);
				}
			}
			foreach (TreeNodeObj node in nodesObj.Nodes)
			{
				this.FillTreeNodesObj(node, listObj, forwardDirection);
			}
		}

		private void setDatabaseGuid()
		{
			SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
			SqlCommand sqlCommand = new SqlCommand(string.Format("SELECT [database_guid] FROM sys.databases INNER JOIN sys.database_recovery_status ON sys.database_recovery_status.database_id = sys.databases.database_id WHERE [name] = '{0}'", this.sqlsettings.DBName), sqlConnection);
			sqlConnection.Open();
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			if (sqlDataReader.Read())
			{
				this.guid = (Guid)sqlDataReader[0];
			}
			sqlConnection.Close();
		}

		private TreeNodeObj AddNodeSubStation(ElectricSubstation SubStation, bool forwardDirection)
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = SubStation;
			foreach (ElectricObject electricObject in from obj in SubStation.ChildObjects
			                                            where obj.GetType() == typeof(ElectricBus) && ((ElectricBus)obj).Amperage != null
			                                            select obj)
			{
				treeNodeObj.AddNode(this.AddNodeBus((ElectricBus)electricObject, forwardDirection));
			}
			return treeNodeObj;
		}

		private TreeNodeObj AddNodeBus(ElectricBus Bus, bool forwardDirection)
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = Bus;
			if (Bus.Amperage == null)
			{
				return treeNodeObj;
			}
			if (forwardDirection)
			{
				using (var enumerator = Bus.Amperage.NextAmperages().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ElectricAmperage electricAmperage = enumerator.Current;
						int id = electricAmperage.Conductor.Id;
						this.method_8(electricAmperage, treeNodeObj);
					}
					return treeNodeObj;
				}
			}
			var list = this.method_7(Bus);
			if (list == null)
			{
				return treeNodeObj;
			}
			TreeNodeObj treeNodeObj_ = treeNodeObj;
			foreach (ElectricObject electricObject_ in list)
			{
				TreeNodeObj treeNodeObj2 = this.method_9(treeNodeObj_, electricObject_);
				if (treeNodeObj2 != null)
				{
					treeNodeObj_ = treeNodeObj2;
				}
			}
			return treeNodeObj;
		}

		private TreeNodeObj AddNodeLine(ElectricLine Line, bool forwardDirection)
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = Line;
			foreach (ElectricAmperage electricAmperage in Line.Amperages.Values)
			{
				if (forwardDirection)
				{
					using (var enumerator2 = electricAmperage.NextAmperages().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							ElectricAmperage electricAmperage_ = enumerator2.Current;
							this.method_8(electricAmperage_, treeNodeObj);
						}
						continue;
					}
				}
				var list = electricAmperage.GetPowerSource();
				TreeNodeObj treeNodeObj_ = treeNodeObj;
				foreach (ElectricObject obj in list)
				{
					TreeNodeObj treeNodeObj2 = this.method_9(treeNodeObj_, obj);
					if (treeNodeObj2 != null)
					{
						treeNodeObj_ = treeNodeObj2;
					}
				}
			}
			return treeNodeObj;
		}

		private TreeNodeObj AddNodeRelation(ElectricRelation Relation, bool forwardDirection)
		{
			ElectricLine electricLine = (ElectricLine)Relation.Parent;
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = electricLine;
			if (Relation.amperagePoint != null)
			{
				ElectricAmperage electricAmperage = electricLine.Amperages[Relation.amperagePoint];
				if (forwardDirection)
				{
					using (var enumerator = electricAmperage.NextAmperages().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ElectricAmperage electricAmperage_ = enumerator.Current;
							this.method_8(electricAmperage_, treeNodeObj);
						}
						return treeNodeObj;
					}
				}
				var list = electricAmperage.GetPowerSource();
				TreeNodeObj node = treeNodeObj;
				foreach (ElectricObject obj in list)
				{
					TreeNodeObj node2 = this.method_9(node, obj);
					if (node2 != null)
					{
						node = node2;
					}
				}
			}
			return treeNodeObj;
		}

		private List<ElectricObject> method_7(ElectricBus Bus)
		{
			if (Bus.Amperage != null)
			{
				return Bus.Amperage.GetPowerSource();
			}
			return null;
		}

		private void method_8(ElectricAmperage Amperage, TreeNodeObj treeNodeObj)
		{
			TreeNodeObj node = this.method_9(treeNodeObj, Amperage.Conductor);
			if (node == null)
			{
				return;
			}
			foreach (ElectricAmperage electricAmperage_ in Amperage.NextAmperages())
			{
				this.method_8(electricAmperage_, node);
			}
		}

		private TreeNodeObj method_9(TreeNodeObj treeNodeObj, ElectricObject obj)
		{
			if (obj != treeNodeObj.Tag)
			{
				TreeNodeObj node = treeNodeObj.AddNode();
				node.Tag = obj;
				return node;
			}
			return null;
		}
        private void LoggerN(string message, bool flagOut = true)
        {
            if (flagOut) Log.Write(LogLevel.Info, "SchemeModelN", "ElectricModel", "", message);
        }
        /// <summary>
        /// список объектов схемы
        /// </summary>
		private List<ElectricObject> listSchmObj;
        /// <summary>
        /// список точек схемы
        /// </summary>
		private Dictionary<int, ElectricPoint> listSchmPoint;

		private Guid guid;

		private SQLSettings sqlsettings;
	}
}
