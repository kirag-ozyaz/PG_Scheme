using LibraryTSQL;
using Logger;
using SchemeModelN.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchemeModelN
{
    public partial class ElectricModel
    {    
        /// <summary>
        /// характеристики центра питания
        /// </summary>
        public class CentralSubstation
        {
            public ElectricObject electricObject { get; set; }
            /// <summary>
            /// имя подстанции
            /// </summary>
            public string ElectricSubName { get; set; }
            /// <summary>
            /// напряжение подстанции
            /// </summary>
            public string VoltageSub { get; set; }
            /// <summary>
            /// тип подстанции
            /// </summary>
            public string ElectricTypeSub { get { return electricTypeSub; } set {electricTypeSub = value; } }
            private string electricTypeSub = "ПС";
            // SchemeModelN.eTypeRectangleTool typesub = eTypeRectangleTool.CP;
            /// <summary>
            /// параметры формирования наименования
            /// </summary>
            public bool IsMinEnergo { get { return isMinEnergo; } set { isMinEnergo = value; } }
            private bool isMinEnergo = false;
        }
        /// <summary>
        /// характеристики электрообъекта
        /// </summary>
        public class ParamsElectricSubstation
        {
            public ElectricObject electricObject { get; set; }
            /// <summary>
            /// параметры формирования наименования
            /// </summary>
            public bool IsMinEnergo { get { return isMinEnergo; } set { isMinEnergo = value; } }
            /// <summary>
            /// полное имя подстанции
            /// </summary>
            public string ElectricSubName { get; set; }
            /// <summary>
            /// подстанция
            /// </summary>
            public ElectricSubstation electricSub { get; set; }
            /// <summary>
            /// напряжение подстанции
            /// </summary>
            public string VoltageSub { get; set; }
            /// <summary>
            /// тип подстанции
            /// </summary>
            public string ElectricTypeSub { get; set; }
            /// <summary>
            /// имя ячейки или линии (КЛ, ВЛ)
            /// </summary>
            public string ElectricLineName { get; set; }
            public ElectricLine electricLine { get; set; }
            /// <summary>
            /// напряжение линии
            /// </summary>
            public string VoltageLine { get; set; }

            private bool isMinEnergo = false;
            /// <summary>
            ///  тип линии
            /// </summary>
            internal string electricTypeLine { get; set; }
            /// <summary>
            /// Шина к которой присоединена ячейка или сама шина (только для ячеек)
            /// </summary>
            public ElectricBus ElectricBusCell { get; set; }
            /// <summary>
            /// Центры питания (только для ячеек)
            /// </summary>
            internal ElectricModel.ParamsElectricSubstation[] PowerSupplyCenterCell { get; set; }
        }
        /// <summary>
        /// вернуть тип подстанции
        /// </summary>
        public string GetTypeSubstation(SchemeModelN.eTypeRectangleTool typesub)
        {
            switch (typesub)
            {
                case SchemeModelN.eTypeRectangleTool.TP:
                    return "ТП";
                case SchemeModelN.eTypeRectangleTool.RP:
                    return "РП";
                default:
                    return "ПС";
            }
        }
        /// <summary>
        /// вернуть тип линии
        /// </summary>
        public string GetTypeLine(SchemeModelN.LineToolType typeline)
        {
            switch (typeline)
            {
                case SchemeModelN.LineToolType.AirLine:
                    return "ВЛ";
                case SchemeModelN.LineToolType.CabelLine:
                    return "КЛ";
                case SchemeModelN.LineToolType.AirLineProtected:
                    return "ВЛЗ";
                case SchemeModelN.LineToolType.MixedLine:
                    return "КВЛ";
                default:
                    return "Яч.";
            }
        }
        /// <summary>
        /// вернуть напряжение
        /// me = true - формат напряжения для минэнерго
        /// </summary>
        public string GetVoltageObject(SchemeModelN.eTypeShinaTool TypeBus,  bool me = true)
        {
            switch (TypeBus)
            {
                case SchemeModelN.eTypeShinaTool.Shina_04:
                    return me ? "0.38" : "0,4";
                case SchemeModelN.eTypeShinaTool.Shina_023:
                    return me ? "0.22" : "0,23";
                case SchemeModelN.eTypeShinaTool.None:
                    return "0";
                case SchemeModelN.eTypeShinaTool.Shina_10:
                    return me ? "10 (10.5)" : "10";
                case SchemeModelN.eTypeShinaTool.Shina_6:
                    return me ? "6 (6.3)" : "6";
                default:
                    return TypeBus.ToString().Replace("Shina_", "");
            }
        }
        public string GetVoltageObject(SchemeModelN.LineToolType TypeLine, bool me = true)
        {
            if (TypeLine.ToString().IndexOf("CellLine_") !=-1)
            {
                switch (TypeLine)
                {
                    case SchemeModelN.LineToolType.CellLine_04:
                        return me ? "0.38" : "0,4";
                    case SchemeModelN.LineToolType.CellLine_023:
                        return me ? "0.22" : "0,23";
                    case SchemeModelN.LineToolType.None:
                        return "0";
                    case SchemeModelN.LineToolType.CellLine_10:
                        return me ? "10 (10.5)" : "10";
                    case SchemeModelN.LineToolType.CellLine_6:
                        return me ? "6 (6.3)" : "6";
                    default:
                        return TypeLine.ToString().Replace("CellLine_", "");
                }
            }
            else
                return "0";
        }
        public string GetVoltageObject(SchemeModelN.ElectricLine cell, bool me = true)
        {
            // связи линии (первый уровень)
            List<ElectricRelation> relation = ((SchemeModelN.ElectricLine)cell).Relations;
            // все связи в которой находится линия (между ячейками)
            List<ElectricRelation> listRelation = new List<ElectricRelation>();
            GetWayRelations(relation, listRelation);

            var Cells = listRelation.Select(s => (ElectricLine)s.Parent).Where(w => w.IsCell()).GroupBy(g => new
            { g.TypeLine });
            var Voltages = Cells.Select(s => new
            {
                VoltageLineME = GetVoltageObject(s.Key.TypeLine),
                VoltageLine = Convert.ToDouble(GetVoltageObject(s.Key.TypeLine, false).Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            });
            var Voltage = (from r in Voltages
                           orderby r.VoltageLine descending
                           select r).First();

            return me ? Voltage.VoltageLineME : Voltage.VoltageLine.ToString();
        }
        public string GetVoltageObject(SchemeModelN.ElectricSubstation sub, bool me = true)
        {
            var electricsBus = sub.ChildObjects.Where(r => r is ElectricBus);
            var Voltages = from r in electricsBus
                     select new
                     {
                         VoltageLineME = GetVoltageObject(((ElectricBus)r).TypeBus),
                         VoltageLine = Convert.ToDouble(GetVoltageObject(((ElectricBus)r).TypeBus, false).Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                     };
            var Voltage = (from r in Voltages
                           orderby r.VoltageLine descending
                           select r).First();

            return  me ? Voltage.VoltageLineME : Voltage.VoltageLine.ToString();
        }
        /// <summary>
        /// Вернем параметры подстанции
        /// me = true - формат напряжения для минэнерго;
        /// isGetParametrElementSub = false - вернуть параметры подстанции, true - вернуть параметры элементов
        /// </summary>
        public ParamsElectricSubstation GetParamsElectricObjectById(int id, bool isGetParametrElementSub = false, bool me = false)
        {
            ParamsElectricSubstation paramsE = new ParamsElectricSubstation();
            try
            {
                paramsE.IsMinEnergo = me;

                SqlDataCommand sqlT = new SqlDataCommand(SqlSettings);

                ElectricObject electricObject = this.listSchmObj.Find((ElectricObject obj) => obj.Id == id);
                if (electricObject == null) return paramsE;
                string electricSubName = null;
                ElectricSubstation electricSub = new ElectricSubstation();

                string VoltageLine = null;
                string ElectricLineName = null;
                ElectricLine electricLine = null;
                bool isLine = false;

                string electricTypeLine = "";

                if (electricObject != null)
                {
                    if (electricObject is ElectricBus) // шина
                    {
                        //electricSubName = sqlT.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[] { ((ElectricBus)electricObject).Id.ToString() }).ToString();
                        electricSubName = GetElectricObjectById(((ElectricBus)electricObject).Id).FullName;

                        electricSub = (ElectricSubstation)((ElectricObject)electricObject).Parent;
                        // paramsE.electricObject = (ElectricBus)electricObject;
                        VoltageLine = GetVoltageObject(((ElectricBus)electricObject).TypeBus);
                    }
                    else if (electricObject is ElectricLine) // линия или ячейка
                    {
                        //object obj = GetElectricObjectById(((ElectricLine)electricObject).Id);
                        if (((ElectricLine)electricObject).IsCell())
                        {
                            //ElectricLineName = sqlT.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[] { ((ElectricLine)electricObject).Id.ToString() }).ToString();
                            ElectricLineName = GetElectricObjectById(((ElectricLine)electricObject).Id).FullName;
                            electricSub = (ElectricSubstation)((ElectricObject)electricObject).Parent;
                            //paramsE.electricObject = (ElectricLine)electricObject;

                            electricLine = (ElectricLine)electricObject;
                            electricTypeLine = GetTypeLine(electricLine.TypeLine);
                            ElectricBus electricBus = null;
                            foreach (ElectricPoint electricPoint in electricLine.Ends)
                            {
                                if (electricPoint.Parent is ElectricBus)
                                {
                                    electricBus = (ElectricBus)electricPoint.Parent;
                                    if (electricBus.TypeBus == eTypeShinaTool.Shina_10 || electricBus.TypeBus == eTypeShinaTool.Shina_110 || electricBus.TypeBus == eTypeShinaTool.Shina_35)
                                    {
                                        break;
                                    }
                                    if (electricBus.TypeBus == eTypeShinaTool.Shina_6)
                                    {
                                        break;
                                    }
                                    if (electricBus.TypeBus == eTypeShinaTool.Shina_04 || electricBus.TypeBus == eTypeShinaTool.Shina_023)
                                    {
                                        break;
                                    }
                                    electricBus = null;
                                }
                            }
                            if (electricBus != null)
                            {
                                VoltageLine = GetVoltageObject(electricBus.TypeBus);
                                //ElectricLineName = GetTypeSubstation(((ElectricSubstation)electricBus.Parent).TypeSubstation) + " " + VoltageLine + " кВ " + electricSubName; 
                                //electricBus.Parent.ToString();
                                electricSubName = electricBus.Parent.ToString();

                                paramsE.ElectricBusCell = electricBus;
                            }
                        }
                        else // линия
                        {
                            ElectricLineName = ((ElectricLine)electricObject).Name.ToString();
                            electricLine = (ElectricLine)electricObject;
                            isLine = true;
                        }
                    }
                    else if (electricObject is ElectricSubstation) // подстанция
                    {
                        electricSubName = ((ElectricSubstation)electricObject).ToString();
                        electricSub = (ElectricSubstation)((ElectricObject)electricObject);
                        //paramsE.electricObject = (ElectricSubstation)electricObject;
                    }
                }

                string electricTypeSub = "";
                string VoltageSub = "";


                if (isLine == false)
                {
                    electricTypeSub = GetTypeSubstation(electricSub.TypeSubstation);
                    var qBeg = electricSub.ChildObjects.Where(r => r is ElectricBus);
                    var q1 = from r in qBeg
                             select new
                             {
                                 VoltageLineME = GetVoltageObject(((ElectricBus)r).TypeBus),
                                 VoltageLine = Convert.ToDouble(GetVoltageObject(((ElectricBus)r).TypeBus, false).Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                             };
                    var Voltage = (from r in q1
                                   orderby r.VoltageLine descending
                                   select r).First();

                    VoltageSub = me ? Voltage.VoltageLineME : Voltage.VoltageLine.ToString();
                    electricSubName = electricTypeSub + " " + VoltageSub + " кВ " + electricSubName;

                    //electricTypeLine = GetTypeLine(electricLine.TypeLine);
                    ElectricLineName = ElectricLineName != null ? electricTypeSub + " " + VoltageSub + " кВ " + ElectricLineName : null;
                    VoltageLine = VoltageLine == null ? VoltageSub : VoltageLine; // VoltageLine = VoltageLine ?? VoltageSub;
                }
                else // линия
                {
                    electricTypeLine = GetTypeLine(electricLine.TypeLine);
                    VoltageLine = GetVoltageObject(electricLine, me);
                    ElectricLineName = ElectricLineName != null ? electricTypeLine + " " + VoltageLine + " кВ " + ElectricLineName : null;
                }

                paramsE.ElectricSubName = electricSubName;
                paramsE.electricSub = electricSub;
                paramsE.VoltageSub = VoltageSub;
                paramsE.ElectricTypeSub = electricTypeSub;
                paramsE.electricObject = electricObject;

                paramsE.VoltageLine = VoltageLine;
                paramsE.ElectricLineName = ElectricLineName;
                paramsE.electricLine = electricLine;
                paramsE.electricTypeLine = electricTypeLine;
            }
            catch (Exception ex)

            {
                Log.Write(Logger.LogLevel.Error, "ElectricModel", "ParamsElectricSubstation", "GetParamsElectricObjectById: idSchmObj = " + id.ToString(), ex.Message, null);
            }
            return paramsE;
        }
        /// <summary>
        /// Вернуть ячейку запитки от центра питания.
        /// Запитка проверяется только от рубильника (ячейки, фидера)
        /// </summary>
        public ElectricModel.ParamsElectricSubstation[] GetCellCP(int idObj)
        {
            ElectricModel.ParamsElectricSubstation[] array2 = null;
            ElectricObject electricObjectById = this.GetElectricObjectById(idObj);
            if (electricObjectById == null)
            {
                return array2;
            }
            // если привязка к шине или подстанции, то пропускаем
            // проверить привязку к высоковольтной ячейке
            // привязка всегда у ячейка должна быть по идее
            if (
                electricObjectById != null &&
                (!(electricObjectById is ElectricBus) || ((ElectricBus)electricObjectById).Amperage != null) &&
                (!(electricObjectById is ElectricLine) || ((ElectricLine)electricObjectById).AmperageCount != 0)
                )
            {
                TreeNodeObj treeNodeObj = this.PoweringReportForDrawObject(idObj, false);
                if (treeNodeObj != null)
                {
                    foreach (TreeNodeObj treeNodeObj2 in treeNodeObj.LeafsList)
                    {
                        if (treeNodeObj2.Tag != null && treeNodeObj2.Tag is ElectricObject)
                        {
                            /// Ячейка запитки от центра питания
                            if (treeNodeObj2.Parent != null && treeNodeObj2.Parent.Tag != null && treeNodeObj2.Parent.Tag is ElectricObject)
                            {
                                array2 = new ElectricModel.ParamsElectricSubstation[]
                                    {
                                        this.GetParamsElectricObjectById(((ElectricObject)treeNodeObj2.Parent.Tag).Id)
                                    };
                            }
                        }
                    }
                }
            }

            return array2;
        }
        /// <summary>
        /// Вернуть список ячеек запитки от центра питания
        /// </summary>
        /// <param name="idObj"></param>
        /// <returns></returns>
        public string[] GetCellsCP(int idObj)
        {
            /// список наименований центров питания
            string[] listNameCP = new string[0];
            /// список центров питания
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
                    // var = Dictionary<ElectricPoint, ElectricAmperage>.ValueCollection.Enumerator
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
            if (listCellCP.Length == 0) return listNameCP;
            listNameCP = new string[listCellCP.Length];
            for (int i = 0; i < listCellCP.Length; i++)
            {
                listNameCP[i] = listCellCP[i].Name;
            }
            return listNameCP;
        }
        #region  ищем все связи для линии (от ячейки до ячейки с КЛ, ВЛ, КВЛ)
        private static void GetWayRelations(List<ElectricRelation> Relations, List<ElectricRelation> listRelation)
        {
            if (listRelation == null) listRelation = new List<ElectricRelation>();
            foreach (ElectricRelation electricRelation in Relations)
            {
                if (!listRelation.Contains(electricRelation))
                {
                    GetWayPointRelations(electricRelation.SourcePoint, listRelation);
                    GetWayPointRelations(electricRelation.DestPoint, listRelation);
                }
            }
        }
        private static void GetWayPointRelations(ElectricPoint Point, List<ElectricRelation> listRelation)
        {
            if (listRelation == null) listRelation = new List<ElectricRelation>();
            foreach (ElectricRelation electricRelation in Point.Relations)
            {
                if (!listRelation.Contains(electricRelation))
                {
                    ElectricPoint electricPoint = (electricRelation.SourcePoint == Point) ? electricRelation.DestPoint : electricRelation.SourcePoint;
                    if (electricPoint != Point)
                    {
                        listRelation.Add(electricRelation);
                        GetWayPointRelations(electricPoint, listRelation);
                    }
                }
            }
        }
        #endregion
        
        /// <summary>
        /// вернуть шину к которой присоединена ячейка
        /// </summary>
        /// <param name="idCell"></param>
        /// <returns></returns>
        public ElectricBus GetBusCell(int idCell)
        {
            ElectricBus electricBus = null;
            ElectricObject electricObject = this.listSchmObj.Find((ElectricObject obj) => obj.Id == idCell);
            if (electricObject == null) return null;
            if (electricObject is ElectricBus) // шина
            {
                electricBus = (ElectricBus)electricObject;
            }
            else if (electricObject is ElectricLine) // линия или ячейка
            {
                if (((ElectricLine)electricObject).IsCell())
                {
                    ElectricLine electricLine = (ElectricLine)electricObject;
                    foreach (ElectricPoint electricPoint in electricLine.Ends)
                    {
                        if (electricPoint.Parent is ElectricBus)
                        {
                            electricBus = (ElectricBus)electricPoint.Parent;
                            if (electricBus.TypeBus == eTypeShinaTool.Shina_10 || electricBus.TypeBus == eTypeShinaTool.Shina_110 || electricBus.TypeBus == eTypeShinaTool.Shina_35)
                            {
                                break;
                            }
                            if (electricBus.TypeBus == eTypeShinaTool.Shina_6)
                            {
                                break;
                            }
                            if (electricBus.TypeBus == eTypeShinaTool.Shina_04 || electricBus.TypeBus == eTypeShinaTool.Shina_023)
                            {
                                break;
                            }
                            electricBus = null;
                        }
                    }
                }
            }
            return electricBus;

        }
        /// <summary>
        /// вернуть первую вышестоящую подстанцию
        /// </summary>
        /// <param name="idScmhObj"></param>
        /// <returns></returns>
        public ElectricSubstation GetFirstSubstation(int idScmhObj)
        {
            ElectricSubstation electricSubstation = null;
            ElectricObject electricObject = this.listSchmObj.Find((ElectricObject obj) => obj.Id == idScmhObj);
            if (electricObject == null) return null;
            if (electricObject is ElectricSubstation) { electricSubstation = (ElectricSubstation)electricObject; }
            if (electricObject is ElectricBus) { electricSubstation = (ElectricSubstation)electricObject.Parent; }
            if (electricObject is ElectricLine)
            {
                ElectricLine electricLine = (ElectricLine)electricObject;
                if (electricLine.IsCell())
                {
                    foreach (ElectricPoint electricPoint in electricLine.Ends)
                    {
                        if (electricPoint.Parent is ElectricBus)
                        {
                            electricSubstation = (ElectricSubstation)((ElectricBus)electricPoint.Parent).Parent;
                            break;
                        }
                    }
                }
                else
                {
                    TreeNodeObj treeNodeObj = PoweringReportForDrawObject(electricLine.Id, false);
                    if (treeNodeObj != null)
                    {
                        foreach (TreeNodeObj node in treeNodeObj.LeafsList)
                        {
                            // надо найти шину
                            if (node.Tag != null && node.Tag is ElectricBus)
                            {
                                ElectricBus electricBus = (ElectricBus)node.Tag;
                                if (electricBus.Parent != null && electricBus.Parent != null && electricBus.Parent is ElectricSubstation)
                                {
                                    electricSubstation = (ElectricSubstation)electricBus.Parent;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return electricSubstation;
        }
    }
}
