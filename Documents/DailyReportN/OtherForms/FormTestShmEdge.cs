using SchemeModelN;
using SchemeModelN.Calculations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DailyReportN.OtherForms
{
    public partial class FormTestShmEdge : FormLbr.FormBase
    {
        private ElectricModel el;

        public FormTestShmEdge()
        {
            InitializeComponent();
          
            dtpDateDoc.Value = Convert.ToDateTime("06.02.2019 15:32");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            rtBox.Clear();
            el = new ElectricModel();

            //ElectricModel el = new ElectricModel();
            el.SqlSettings = this.SqlSettings;
            // electricModel.LoadSchema(this.dtpDateDoc.Value);
            el.LoadSchema(false);
            el.OffSimulate();
            SetStatusOffEdges(this.dtpDateDoc.Value);
            OnSimulate("4");
        }

        public void OnSimulate(string info = "")
        {
            // соберем шины с центров питания
            foreach (ElectricObject electricObject in from obj in el.Objects
                                                      where obj.GetType() == typeof(ElectricBus) && obj.Parent != null && obj.Parent.GetType() == typeof(ElectricSubstation) && ((ElectricSubstation)obj.Parent).TypeSubstation == eTypeRectangleTool.CP
                                                      select obj)
            {
                var Bus = (ElectricBus)electricObject;
                rtBox.AppendText("--ElectricBus: " + Bus.Id + "    "
                    + Bus.Name + "    "
                    + Bus.TypeBus.ToString() + "  "
                    + ((ElectricSubstation)electricObject.Parent).ToString() + "    "
                    + ((ElectricSubstation)electricObject.Parent).TypeSubstation.ToString() + " "
                    + "OnAmperage:" + Bus.OnAmperage
                    );
                Bus.xOnAmperage = true;
                rtBox.AppendText("--->" + Bus.OnAmperage + "\r\n");
                Application.DoEvents();
                /******************** ElectricBus ************************/
                // ReCalcAmperage
                ReCalcAmperage(Bus);
            }
        }
        #region ElectricBus
        /// <summary>
        /// соберем точки на шинах
        /// </summary>
        /// <param name="Bus"></param>
        internal void ReCalcAmperage(ElectricBus Bus = null)
        {
            foreach (ElectricObject obj in Bus.ChildObjects)
            {
                if (obj.GetType() == typeof(ElectricPoint) && ((ElectricPoint)obj).Relations.Count > 0)
                {
                    rtBox.AppendText("----ElectricPoint: " + ((ElectricPoint)obj).Name + "  " + ((ElectricPoint)obj).Id.ToString() + "\r\n");
                    this.RecalcAmperageForCell((ElectricPoint)obj, Bus);
                }
            }
        }
        /// <summary>
        /// соберем ячейки отходящие с шин
        /// </summary>
        /// <param name="point"></param>
        /// <param name="Bus"></param>
        internal void RecalcAmperageForCell(ElectricPoint point, ElectricBus Bus = null)
        {
            if (point.Relations.Count == 0)
            {
                return;
            }
            if (Bus.Amperage != null && (Bus.Amperage.Mediators.Count<ElectricAmperage>() == 0 || Bus.Amperage.Mediators.First<ElectricAmperage>().Conductor != point.Relations[0].Parent))
            {
                if (point.Relations[0].Parent is ElectricLine && !((ElectricLine)(point.Relations[0].Parent)).Amperages.ContainsKey(point))
                {
                    var Line = (ElectricLine)point.Relations[0].Parent;

                    ElectricAmperage electricAmperage = Bus.Amperage.PassOn(point.Relations[0].Parent);
                    rtBox.AppendText("-----ElectricAmperage (PassOn): " + electricAmperage.ToString() + "   (" + Line.ToString() + ")\r\n");
                    if (electricAmperage != null)
                    {
                        rtBox.AppendText("----->>>>>>>>>>AddAmperage: " + electricAmperage.Conductor.ToString() + "\r\n");
                        //((ElectricLine)point.Relations[0].Parent).AddAmperage(point, electricAmperage);
                        AddAmperage((ElectricLine)point.Relations[0].Parent, point, electricAmperage);
                        return;
                    }
                }
                else if (point.Relations[0].amperagePoint == null && ((ElectricLine)point.Relations[0].Parent).Amperages[point].Mediators != Bus.Amperage)
                {
                    rtBox.AppendText("-----= короткое замыкание при передаче на другой объект\r\n");
                    throw new Exception("короткое замыкание при передаче на другой объект");
                }
            }
        }
        #endregion
        #region ElectricAmperage
        internal void AddMediator(ElectricAmperage amperage, ElectricAmperage mediator)
        {
            amperage.xMediators.Add(mediator);
        }
        internal bool PowerSourceConteins(ElectricAmperage amperage, ElectricObject desiredObject)
        {
            List<ElectricObject> list_ = new List<ElectricObject>();
            // return amperage.RunOnMediators(list_, amperage.conductor, desiredObject);
            return RunOnMediators(amperage, list_, amperage.Conductor, desiredObject);
        }

        private bool RunOnMediators(ElectricAmperage amperageN, List<ElectricObject> list, ElectricAmperage amperage, ElectricAmperage nextAmperage, ElectricObject desiredObject)
        {
            ElectricObject electricObject = amperage.Conductor;
            if (electricObject == desiredObject)
            {
                return true;
            }
            if (electricObject.GetType() == typeof(ElectricLine))
            {
                if (nextAmperage == null)
                {
                    list.Add(electricObject);
                    using (var enumerator = amperage.Mediators.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            ElectricAmperage electricAmperage_2 = enumerator.Current;
                            if (this.RunOnMediators(amperageN, list, electricAmperage_2, amperage, desiredObject))
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                }
                using (Dictionary<ElectricPoint, ElectricAmperage>.ValueCollection.Enumerator enumerator2 = ((ElectricLine)electricObject).Amperages.Values.GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        if (enumerator2.Current == amperage)
                        {
                            list.Add(electricObject);
                            foreach (ElectricAmperage electricAmperage_3 in amperage.Mediators)
                            {
                                if (this.RunOnMediators(amperageN, list, electricAmperage_3, amperage, desiredObject))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                    return false;
                }
            }
            if (electricObject.GetType() != typeof(ElectricBus))
            {
                return false;
            }
            list.Add(electricObject);
            using (var enumerator = amperage.Mediators.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ElectricAmperage amperage5 = enumerator.Current;
                    if (this.RunOnMediators(amperageN, list, amperage5, amperage, desiredObject))
                    {
                        return true;
                    }
                }
                return false;
            }
            //bool result;
            //return result;
        }

        private bool RunOnMediators(ElectricAmperage amperageN, List<ElectricObject> list, ElectricObject conductor, ElectricObject desiredObject)
        {

            //Log.Write(LogLevel.Debug, "SchemeModelN", "ElectricAmperage", "RunOnMediators", string.Format("----Conductor: ({0}, {1}) desiredObject ({2}, {3}) ", new object[] { conductor.Name, conductor.Id, desiredObject.Name, desiredObject.Id }), null);
            try
            {
                if (conductor.GetType() == typeof(ElectricLine))
                {
                    foreach (var electricAmperage in ((ElectricLine)conductor).Amperages.Values)
                    {
                        foreach (ElectricAmperage electricAmperageMed in electricAmperage.Mediators)
                        {
                            ElectricObject electricObject = electricAmperageMed.Conductor;

                            //Log.Write(LogLevel.Debug, "SchemeModelN", "ElectricAmperage", "RunOnMediators", string.Format("----ElectricLine: ({0}, {1}) ", new object[] { electricObject.Name, electricObject.Id }), null);

                            bool flag = true;
                            if (electricObject == desiredObject)
                            {
                                return true;
                            }
                            if (electricObject.GetType() == typeof(ElectricLine))
                            {
                                foreach (ElectricRelation Edge in ((ElectricLine)electricObject).Relations)
                                {
                                    if (Edge.amperagePoint != null && ((ElectricLine)electricObject).Amperages[Edge.amperagePoint] == electricAmperageMed)
                                    {
                                        if (!list.Contains(Edge))
                                        {
                                            //Log.Write(LogLevel.Debug, "SchemeModelN", "ElectricAmperage", "RunOnMediators", string.Format("++++ElectricLine: ({0}, {1}) ", new object[] { electricObject.Name, electricObject.Id }), null);
                                            list.Add(Edge);
                                        }
                                        else
                                        {
                                            flag = false;
                                        }
                                    }
                                }
                                if (flag && this.RunOnMediators(amperageN, list, electricObject, desiredObject))
                                {
                                    return true;
                                }
                            }
                            else if (!list.Contains(electricObject))
                            {
                                list.Add(electricObject);
                                //Log.Write(LogLevel.Debug, "SchemeModelN", "ElectricAmperage", "RunOnMediators", string.Format("++++electricObject: ({0}, {1}) ", new object[] { electricObject.Name, electricObject.Id }), null);

                                if (electricObject != electricAmperageMed.Source && this.RunOnMediators(amperageN, list, electricObject, desiredObject))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                    return false;
                }
                if (conductor.GetType() != typeof(ElectricBus))
                {
                    return false;
                }
                using (var enumerator2 = ((ElectricBus)conductor).Amperage.Mediators.GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        ElectricAmperage electricAmperage3 = enumerator2.Current;
                        ElectricObject electricObject2 = electricAmperage3.Conductor;
                        if (electricObject2 == desiredObject)
                        {
                            return true;
                        }
                        if (!list.Contains(electricObject2))
                        {
                            list.Add(electricObject2);
                            //Log.Write(LogLevel.Debug, "SchemeModelN", "ElectricAmperage", "RunOnMediators", string.Format("++++electricObject2: ({0}, {1}) ", new object[] { electricObject2.Name, electricObject2.Id }), null);

                            if (electricObject2 != electricAmperage3.Source && this.RunOnMediators(amperageN, list, electricObject2, desiredObject))
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
                //bool result;
                //return result;
            }
            catch
            {
                throw new Exception("ошибка переполнение стека");
            }
        }

        #endregion
        #region ElectricLine
        public void AddAmperage(ElectricLine line, ElectricPoint pt, ElectricAmperage amperage) // internal
        {
            if (line.Amperages.ContainsKey(pt))
            {
                using (var enumerator = amperage.Mediators.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        ElectricAmperage electricAmperage = enumerator.Current;
                        if (!line.Amperages[pt].Mediators.Contains(electricAmperage))
                        {
                            //line.Amperages[pt].AddMediator(electricAmperage);
                            AddMediator(line.Amperages[pt],  electricAmperage);
                            electricAmperage.NextAmperages().Add(line.Amperages[pt]);
                            electricAmperage.NextAmperages().Remove(amperage);
                        }
                    }
                    return;
                }
            }
            line.Amperages.Add(pt, amperage);
            // line.ReCalcAmperage();
            ReCalcAmperage(line);
        }

        internal  void ReCalcAmperage(ElectricLine line)
        {
            int i = 0;
            var list = line.Amperages.Keys.ToList<ElectricPoint>();
            while (i < list.Count)
            {
                ElectricPoint electricPoint_ = list[i++];
                // line.RecalcAmperageForPoint(electricPoint_);
                RecalcAmperageForPoint(line, electricPoint_);
            }
        }
        internal void RecalcAmperageForPoint(ElectricLine line, ElectricPoint point)
        {
            if (point != null)
            {
                //line.GetAmperageToEnds(point, null, point);
                GetAmperageToEnds(line, point, null, point);
            }
        }
        private void GetAmperageToEnds(ElectricLine line, ElectricPoint SourcePoint, ElectricRelation glRelation, ElectricPoint DestPoint)
        {
            ElectricAmperage electricAmperage = line.Amperages[DestPoint];
            if ((SourcePoint.Relations.Count == 1 || SourcePoint.Relations.Count(c => c.Parent == line) == 1) && glRelation != null)
            {
                if (SourcePoint.Relations.Count > 1)
                {
                    using (var enumerator = SourcePoint.Relations.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            ElectricRelation couplingRelation = enumerator.Current;
                            if (couplingRelation.Parent != line && electricAmperage.Mediators.Count((ElectricAmperage a) => a.Conductor == couplingRelation.Parent) == 0)
                            {
                                if (!((ElectricLine)couplingRelation.Parent).Amperages.ContainsKey(SourcePoint) && couplingRelation.amperagePoint == null)
                                {
                                    ElectricAmperage electricAmperage2 = electricAmperage.PassOn(couplingRelation.Parent);
                                    if (electricAmperage2 != null)
                                    {
                                        // ((ElectricLine)couplingRelation.Parent).AddAmperage(SourcePoint, electricAmperage2);
                                        AddAmperage((ElectricLine)couplingRelation.Parent, SourcePoint, electricAmperage2);
                                    }
                                }
                                else if (couplingRelation.amperagePoint != null && ((ElectricLine)couplingRelation.Parent).Amperages[couplingRelation.amperagePoint].Source == electricAmperage.Source && !PowerSourceConteins(electricAmperage, couplingRelation.Parent))
                                {
                                    ElectricAmperage electricAmperage3 = electricAmperage.PassOn(couplingRelation.Parent);
                                    if (electricAmperage3 != null)
                                    {
                                        // ((ElectricLine)couplingRelation.Parent).AddAmperage(SourcePoint, electricAmperage3);
                                        AddAmperage((ElectricLine)couplingRelation.Parent, SourcePoint, electricAmperage3);
                                    }
                                }
                            }
                        }
                        //	goto IL_265;
                    }
                }
                else //
                    if (SourcePoint.Parent != null && SourcePoint.Parent.GetType() == typeof(ElectricBus) && electricAmperage.Mediators.Count((ElectricAmperage a) => a.Conductor == SourcePoint.Parent) == 0 && ((ElectricBus)SourcePoint.Parent).Amperage == null)
                {
                    ElectricAmperage electricAmperage4 = electricAmperage.PassOn(SourcePoint.Parent);
                    if (electricAmperage4 != null)
                    {
                        ((ElectricBus)SourcePoint.Parent).Amperage = electricAmperage4;
                    }
                }
            }
            //IL_265:
            using (var enumerator = SourcePoint.Relations.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ElectricRelation couplingRelation2 = enumerator.Current;
                    if (couplingRelation2.Parent == line && electricAmperage.Mediators.Count((ElectricAmperage a) => a.Conductor == couplingRelation2.Parent) == 0 && couplingRelation2 != glRelation)
                    {
                        ElectricPoint electricPoint = (SourcePoint == couplingRelation2.SourcePoint) ? couplingRelation2.DestPoint : couplingRelation2.SourcePoint;
                        if (line.Amperages.ContainsKey(electricPoint) && couplingRelation2.amperagePoint == electricPoint && couplingRelation2.On)
                        {
                            if (line.Amperages[electricPoint].Source == electricAmperage.Source)
                            {
                                GetAmperageToEnds(line, electricPoint, couplingRelation2, DestPoint);
                            }
                        }
                        else if (couplingRelation2.amperagePoint == null)
                        {
                            couplingRelation2.amperagePoint = DestPoint;
                            if (couplingRelation2.On)
                            {
                                GetAmperageToEnds(line, electricPoint, couplingRelation2, DestPoint);
                            }
                        }
                        else if (couplingRelation2.On && couplingRelation2.amperagePoint == DestPoint)
                        {
                            GetAmperageToEnds(line, electricPoint, couplingRelation2, DestPoint);
                        }
                    }
                }
            }
        }
        #endregion
        /// <summary>
        /// установка статуса отключения ребра
        /// </summary>
        /// <param name="dateTime"></param>
        public void SetStatusOffEdges(DateTime dateTime)
        {
            // читаем логи действий диспетчеров
            SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand(string.Format(" select o.id, \r\n\t\t                                            ldown.dateLog as dateDown,\r\n\t\t                                            ldown.action as actionDown,\r\n\t\t                                            lup.dateLog as dateup,\r\n\t\t                                            lup.action as actionup\r\n                                              from tSchm_ObjList o\r\n\t                                            left join [tSchm_LogDispatcher] lUp on lup.id = (select top 1 id from [tSchm_LogDispatcher]\r\n\t\t\t\t\t\t\t\t\t\t\t                                                   where idObj = o.id and DateLog > '{0}'\r\n\t\t\t\t\t\t\t\t\t\t\t                                                   order by dateLog asc)\r\n\t                                            left join [tSchm_LogDispatcher] lDown on lDown.id = (select top 1 id from [tSchm_LogDispatcher]\r\n\t\t\t\t\t\t\t\t\t\t\t                                                   where idObj = o.id and DateLog <= '{0}'\r\n\t\t\t\t\t\t\t\t\t\t\t                                                   order by dateLog desc)\r\n                                            where (lup.id is not null)", dateTime.ToString("yyyyMMdd HH:mm:ss")), sqlConnection);

            // " order by ldown.dateLog"
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
                var source = from o in el.Objects
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

        public ElectricObject GetElectricObjectById(int id)
        {
            ElectricObject electricObject = el.Objects.Find((ElectricObject obj) => obj.Id == id);
            return electricObject;
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
                        using (Dictionary<ElectricPoint, ElectricAmperage>.ValueCollection.Enumerator enumerator2 = ((ElectricLine)electricObjectById).Amperages.Values.GetEnumerator())
                        {
                            while (enumerator2.MoveNext())
                            {
                                List<ElectricObject> list2 = enumerator2.Current.GetPowerSource();
                                ElectricObject electricObject3 = null;
                                list2.Reverse();
                                using (List<ElectricObject>.Enumerator enumerator = list2.GetEnumerator())
                                {
                                    while (enumerator.MoveNext())
                                    {
                                        ElectricObject electricObject4 = enumerator.Current;
                                        if (electricObject4.GetType() == typeof(ElectricLine) && ((ElectricLine)electricObject4).IsCell())
                                        {
                                            electricObject3 = electricObject4;
                                            break;
                                        }
                                    }
                                    goto IL_17D;
                                }
                                IL_175:
                                array2[num] = electricObject3;
                                continue;
                                IL_17D:
                                if (electricObject3 != null)
                                {
                                    goto IL_175;
                                }
                            }
                            //goto IL_261;
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
                //IL_261:
                array = new string[array2.Length];
                for (int i = 0; i < array2.Length; i++)
                {
                    array[i] = string.Format("{0}\\{1}", array2[i].Parent.Name, array2[i].Name);
                }
            }
            return array;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReferenceTables.CreateReferenceTables.getTextSendSiteME(7, SqlSettings);
        }
    }
}
