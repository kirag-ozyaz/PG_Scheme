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

namespace SchemeReports
{
    /// <summary>
    /// Тестироваие схемы
    /// </summary>
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
                                        // ошибка 
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
            SqlCommand sqlCommand = new SqlCommand(string.Format(" " +
                "select o.id,  ldown.dateLog as dateDown, ldown.action as actionDown,  lup.dateLog as dateup, " +
                "        lup.action as actionup " +
                "  from tSchm_ObjList o " +
                "    left join [tSchm_LogDispatcher] lUp on lup.id = " +
                "                   (select top 1 id from [tSchm_LogDispatcher] " +
                "                    where idObj = o.id and DateLog > '{0}' " +
                "                    order by dateLog asc) " +
                "    left join [tSchm_LogDispatcher] lDown on lDown.id = " +
                "                   (select top 1 id from [tSchm_LogDispatcher] " +
                "                    where idObj = o.id and DateLog <= '{0}' " +
                "                    order by dateLog desc) " +
                "  where (lup.id is not null)", dateTime.ToString("yyyyMMdd HH:mm:ss")), sqlConnection);

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
                                    //goto IL_17D;
                                    if (electricObject3 != null)
                                    {
                                        array2[num] = electricObject3;
                                    }
                                }
                                //IL_175:
                                //array2[num] = electricObject3;
                                //continue;
                                //IL_17D:
                                //if (electricObject3 != null)
                                //{
                                //	goto IL_175;
                                //}
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
            Reference.Tables.getTextSendSiteME(7, SqlSettings);
        }

        private void btnLoadSchm_Click(object sender, EventArgs e)
        {
            //
            SchemeModelN.ElectricModel electricModel = new SchemeModelN.ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            electricModel.LoadSchema();

            var line = electricModel.GetElectricObjectById(1080300);
            // связи линии (первый уровень)
            List<ElectricRelation>  relation = ((SchemeModelN.ElectricLine)line).Relations;
            // все связи в которой находится линия (между ячейками)
            List<ElectricRelation> listRelation = new List<ElectricRelation>();
            GetWayRelations(relation, listRelation);

            var Cells = listRelation.Select(s => (ElectricLine)s.Parent).Where(w => w.IsCell()).GroupBy(g => new
            { g.TypeLine });
            var Voltages = Cells.Select(s => new
            {
                VoltageLineME = electricModel.GetVoltageObject(s.Key.TypeLine),
                VoltageLine = Convert.ToDouble(electricModel.GetVoltageObject(s.Key.TypeLine, false).Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            });
            var Voltage = (from r in Voltages
                           orderby r.VoltageLine descending
                           select r).First();

            rtBox.AppendText(Voltage.VoltageLineME.ToString());

        }
        // ищем все связи для линии (от ячейки до ячейки с КЛ, ВЛ, КВЛ)
        private static void GetWayRelations(List<ElectricRelation> Relations, List<ElectricRelation> listRelation)
        {
            if (listRelation == null) listRelation = new List<ElectricRelation>();
            foreach (ElectricRelation electricRelation in Relations)
            {
                if (!listRelation.Contains(electricRelation))
                {
                    GetWayPointRelations(electricRelation.SourcePoint, listRelation);
                    GetWayPointRelations(electricRelation.DestPoint, listRelation);

                    //listRelation.Add(electricRelation);
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

        private void button2_Click(object sender, EventArgs e)
        {
            bool toolStripMenuItemUE = false;
            bool tspDatatoGIS = false;
            bool toolStripMenuItemSchedulers = false;
            /**/
            Library.Security security = new Library.Security();
            security.SqlSettings = SqlSettings;
            DataTable CurrentRules = security.GetCurrentUserRules();
            foreach (DataRow row in CurrentRules.Rows)
            {
                switch (row["WorkerGroup"])
                {
                    case ";GroupWorker;Administrator;": toolStripMenuItemUE = true; break;
                    case ";GroupWorker;Map;": tspDatatoGIS = true; break;
                    case ";GroupWorker;GeneralInterfaceLegal;": toolStripMenuItemSchedulers = true; break;
                }
            }
            /**/
            string txtCodeObjSchm = "";
            foreach (LineToolType obj in Enum.GetValues(typeof(LineToolType)))
            {
                txtCodeObjSchm = txtCodeObjSchm + Convert.ToInt32(obj).ToString() + ",";
            }
            txtCodeObjSchm = txtCodeObjSchm.Remove(txtCodeObjSchm.Length - 1);
            rtBox.Clear();
            rtBox.AppendText($"LineToolType: {txtCodeObjSchm}\r\n");
            string txtCodeSub = "";
            foreach (eTypeRectangleTool obj in Enum.GetValues(typeof(eTypeRectangleTool)))
            {
                txtCodeSub = txtCodeSub + Convert.ToInt32(obj).ToString() + ",";
            }
            txtCodeSub = txtCodeSub.Remove(txtCodeSub.Length - 1);
            rtBox.AppendText($"eTypeRectangleTool: {txtCodeSub}\r\n");

            txtCodeSub = "\r\n";
            foreach (TypeSwitch obj in Enum.GetValues(typeof(TypeSwitch)))
            {
                txtCodeSub = txtCodeSub + Convert.ToInt32(obj).ToString() + ",";
                rtBox.AppendText($"{obj.ToString()} = {Convert.ToInt32(obj).ToString() }" + ",\r\n");
            }
            txtCodeSub = txtCodeSub.Remove(txtCodeSub.Length - 1);
            rtBox.AppendText($"TypeSwitch: {txtCodeSub}\r\n");
            // GetElectricObjectById
        }
    }
}
