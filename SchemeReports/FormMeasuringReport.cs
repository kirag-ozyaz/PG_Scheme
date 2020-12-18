using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Logger;
using Microsoft.Reporting.WinForms;
using Model = SchemeModelN;
using Calculations = SchemeModelN.Calculations;

namespace SchemeReports
{
    public partial class FormMeasuringReport : FormBase
    {
        private bool flagOut = false;
        // private string rdlc = "Scheme.FileReports.ReportMeasurement.rdlc";
        private string rdlc = "SchemeReports.RDLC.ReportMeasurement.rdlc";
        private DataTable dtTrans = new DataTable();
        private DataTable dtCable = new DataTable();
        private DataTable dtSwitch = new DataTable();
        private int MeasurementYear=2014;
        private bool sys;

        //    public FormMeasuringReport()
        //    {
        //        InitializeComponent();
        //    }

        public FormMeasuringReport()
        {
            this.InitializeComponent();
            for (int i = DateTime.Now.Year + 2; i >= 2000; i--)
            {
                this.cmbYear.Items.Add(i);
            }
            this.cmbYear.SelectedItem = DateTime.Now.Year;
            this.cmbYear.SelectedIndexChanged +=new EventHandler( this.cmbYear_SelectedIndexChanged);
        }

        private void FormMeasuringReport_Load(object sender, EventArgs e)
        {
            //this.StartBackGround();
            this.toolCmbTypeSchema.SelectedIndex = 1;
            this.toolCmbTypeSchema.SelectedIndexChanged += this.toolStripComboBox_SelectedIndexChanged;
        }
        private void toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void StartBackGround()
        {
            this.panelProgress.Visible = true;
            this.progressBarEndLess.AutoProgress = true;
            this.panelProgress.Left = base.Width / 2 - this.panelProgress.Width / 2;
            this.panelProgress.Top = base.Height / 2 - this.panelProgress.Height / 2;
            this.panelDataGrid.Enabled = false;
            this.panelDataGrid.Visible = false;
            this.panelReport.Enabled = false;
            this.dataGridViewCab.DataSource = null;
            this.dataGridViewTrans.DataSource = null;

            this.toolStrip1.Enabled = false;

            if (this.cmbYear.SelectedItem != null)
            {
                this.MeasurementYear = Convert.ToInt32(this.cmbYear.SelectedItem);
            }
            //режим отображения сети
            bool isNormalSimulationMode = true;
            if (this.toolCmbTypeSchema.SelectedIndex == 0)
            {
                isNormalSimulationMode = false;
            }

            this.backgroundWorker1.RunWorkerAsync(new SimulationMode(isNormalSimulationMode, this.MeasurementYear));
        }
        /// <summary>
        /// isSimulationMode режим отображения сети; true = нормальная, false - оперативная
        /// </summary>
        private class SimulationMode
        {
            internal SimulationMode(bool isSimulationMode, int Year)
            {
                this.IsSimulationMode = isSimulationMode;
                this.PeriodDateTime = new DateTime(Year,12,31);
            }

            internal SimulationMode(bool isSimulationMode, DateTime dateTime)
            {
                this.IsSimulationMode = isSimulationMode;
                this.PeriodDateTime = dateTime;
            }

            internal bool IsSimulationMode;
            internal DateTime PeriodDateTime;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          

            SimulationMode isMode = ((SimulationMode)e.Argument);
            this.MeasurementReport(isMode);
        }

        private void MeasurementReport(SimulationMode isMode)
        {
            Model.ElectricModel electricModel = new Model.ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            electricModel.LoadSchema(isMode.IsSimulationMode);
            int _MeasurementYear = isMode.PeriodDateTime.Year;

            List<Model.ElectricObject> listElectricBus = new List<Model.ElectricObject>();

            var s1 = electricModel.Objects.Where(w => w.GetType().Equals(typeof(SchemeModelN.ElectricSubstation)));
            var schmObjCp = s1.Where(w => ((SchemeModelN.ElectricSubstation)w).TypeSubstation.Equals(SchemeModelN.eTypeRectangleTool.CP));

            var listSchmObjCP = from o in electricModel.Objects
                                where o is Model.ElectricBus && o.Parent != null && o.Parent is Model.ElectricSubstation && ((Model.ElectricSubstation)o.Parent).TypeSubstation == Model.eTypeRectangleTool.CP
                                select o;

            // int IdSchmObj = 806349;
            // listElectricBus.AddRange(listSchmObjCP.Where(w=>w.Id == IdSchmObj));
            listElectricBus.AddRange(listSchmObjCP);

            Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();
            //Dictionary<int, int[]> dictionary2 = dictionary;
            //int key = 10;
            //int[] array = new int[2];
            //array[0] = 60;
            //dictionary2.Add(key, array);
            dictionary.Add(16, new int[] {80,75});
            dictionary.Add(25, new int[] {105,90});
            dictionary.Add(35, new int[] {125,115});
            dictionary.Add(50, new int[] {155,140});
            dictionary.Add(70, new int[] {190,165});
            dictionary.Add(95, new int[] {225,205});
            dictionary.Add(120, new int[] {260,240});
            dictionary.Add(150, new int[] {300,275});
            dictionary.Add(185, new int[] {340,310});
            dictionary.Add(240, new int[] {390,355});
            try
            {
                SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
                SqlCommand sqlCommand = new SqlCommand(string.Concat(new object[]
                {
                    "Select mat1.[IdBus],mat1.[idObjList],mat1.Ia,mat1.Ib,mat1.Ic, maxI.I, m1.DateD, disp.fio as disp, m1.TemperatureD\r\n                                                                                                from [tJ_MeasAmperageTransf] as mat1 inner join\r\n\t                                                                                                (SELECT mat.[IdBus],mat.[idObjList],m.[TypeDoc],(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) then max([Ia]) else case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) then max([Ic]) end end end) as I, max([Ia]) as a, max([Ib]) as b, max([Ic]) as c\r\n\t                                                                                                FROM [tJ_MeasAmperageTransf] as mat\r\n\t                                                                                                inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n\t                                                                                                where  mat.deleted = 0 and m.[TypeDoc] = 1192 and  ((year(m.[DateD]) = ",
                    _MeasurementYear,
                    " and month(m.[DateD]) between 1 and 11)or(year(m.[DateD]) = ",
                    _MeasurementYear,
                    "-1 and month(m.[DateD])=12) ) and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n\t                                                                                                group by mat.[IdBus], mat.[idObjList], m.[TypeDoc]) as maxI \r\n                                                                                                on mat1.[IdBus]=maxI.[IdBus] and mat1.[idObjList]=maxI.[idObjList] and mat1.Ia = maxI.a and mat1.Ib= maxI.b and mat1.Ic = maxI.c \r\n                                                                                                inner join [tJ_Measurement] as m1 on mat1.[idMeasurement] = m1.id and m1.[TypeDoc]=1192\r\n                                                                                                left join vR_Worker disp on m1.idWorkerCheck = disp.id\r\n                                                                                                where mat1.deleted = 0 and ((year(m1.[DateD]) = ",
                    _MeasurementYear,
                    " and month(m1.[DateD]) between 1 and 11)or(year(m1.[DateD]) = ",
                    _MeasurementYear,
                    "-1 and month(m1.[DateD])=12) ) and  mat1.[Ia] is not null and  mat1.[Ib] is not null and  mat1.[Ic] is not null and mat1.idbus is not null"
                }));
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                this.dtSwitch.Clear();
                this.dtSwitch.Load(reader);

                sqlCommand.CommandText = "SELECT tSchm_ObjList.id, tSchm_ObjList.name, p.[Power]\r\n                                                                                                    FROM tSchm_ObjList\r\n                                                                                                    inner join tR_Classifier on tSchm_ObjList.[TypeCodeId]=tR_Classifier.id and tR_Classifier.[ParentKey] like ';SCM;INLINE_OBJ;SWITCH;' and tR_Classifier.Value = 11\r\n                                                                                                    outer apply dbo.fn_J_MeasTransfPassport(tSchm_ObjList.[Id]) p\r\n                                                                                                    where tSchm_ObjList.Deleted=0";
                reader = sqlCommand.ExecuteReader();
                this.dtTrans.Clear();
                this.dtTrans.Load(reader);

                sqlCommand.CommandText = "select tSchm_ObjList.id, tSchm_ObjList.name, minsect.CrossSection\r\n                                            from tSchm_ObjList \r\n                                            inner join (SELECT [idObjList],min([CrossSection])as CrossSection\r\n                                              FROM [tP_CabSection]  \r\n                                              where deleted=0 and [Length]>10\r\n                                              group by idobjlist)as minsect on tSchm_ObjList.id=minsect.idObjList \r\n                                            inner join tP_Passport pas on pas.idObjlist = tSchm_ObjList.id";
                reader = sqlCommand.ExecuteReader();
                this.dtCable.Clear();
                this.dtCable.Load(reader);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            this.dataSetScheme.MeasurementReport1.Clear();
            this.dataSetScheme.MeasurementReport2.Clear();
            
            foreach (Model.ElectricObject electricObject in listElectricBus)
            {
                Logger( $"{electricObject.Parent.ToString().Trim()} idParent = {electricObject.Parent.Id}", flagOut);
                Calculations.TreeNodeObj treeNodeObj = electricModel.PoweringReportForDrawObject(electricObject, true);
                if (treeNodeObj.Nodes.Count<Calculations.TreeNodeObj>() != 0)
                {
                    //Logger("+begin");
                    // соберем начальные ячейки 
                    Logger( $"{electricObject.Parent.ToString().Trim()} idParent = {electricObject.Parent.Id} Name = {electricObject.Name} id = {electricObject.Id}. Дерево есть", flagOut);
                    Dictionary<Model.ElectricLine, List<Model.ElectricObject>> dictionaryElectricCell = new Dictionary<Model.ElectricLine, List<Model.ElectricObject>>();
                    if (electricObject.GetType() == typeof(Model.ElectricBus))
                    {
                        Logger( $"1.1 - шина {((Model.ElectricBus)electricObject).Name} id = {((Model.ElectricBus)electricObject).Id}", flagOut);
                        foreach (var enumerator2 in (from s in electricObject.ChildObjects
                                                     where s.GetType() == typeof(Model.ElectricPoint)
                                                     select s))
                        {
                            Model.ElectricObject electricObject2 = enumerator2;
                            Model.ElectricPoint electricPoint = (Model.ElectricPoint)electricObject2;
                            if (electricPoint.Relations.Count == 1 && electricPoint.Relations[0].Parent.GetType() == typeof(Model.ElectricLine) && ((Model.ElectricLine)electricPoint.Relations[0].Parent).IsCell())
                            {
                                dictionaryElectricCell.Add((Model.ElectricLine)electricPoint.Relations[0].Parent, new List<Model.ElectricObject>());
                                Logger( $" 1.1.1 - ячейки шины {(Model.ElectricLine)electricPoint.Relations[0].Parent} id={((Model.ElectricLine)electricPoint.Relations[0].Parent).Id}", flagOut);
                            }
                        }
                    }
                    else
                    {
                        if (electricObject.GetType() == typeof(Model.ElectricLine) && ((Model.ElectricLine)electricObject).IsCell())
                        {
                            Logger( $"1.2 - ячейка {((Model.ElectricLine)electricObject).Name} id = {((Model.ElectricLine)electricObject).Id}", flagOut);
                            dictionaryElectricCell.Add((Model.ElectricLine)electricObject, new List<Model.ElectricObject>());
                        }
                    }
                    
                    Dictionary<Model.ElectricBus, object[,]> dictionaryElectricBus = new Dictionary<Model.ElectricBus, object[,]>();
                    Dictionary<Model.ElectricRelation, int> relationsMeasurement = new Dictionary<Model.ElectricRelation, int>();
                    // соберем подчиненные ветки
                    Logger( $"2.0 Подчиненных веток {((Model.ElectricObject)treeNodeObj.Tag).ToString().Trim()} id = {((Model.ElectricObject)treeNodeObj.Tag).Id}  :-- {treeNodeObj.LeafsList.Count()}", flagOut);
                    int n = 0;
                    foreach (var treeNodeObj3 in treeNodeObj.LeafsList)
                    {
                        n++;
                        Calculations.TreeNodeObj treeNodeObj2 = treeNodeObj3;
                        Model.ElectricObject electricObjectBeg = null;
                        List<Model.ElectricObject> listObj = new List<Model.ElectricObject>();
                        bool flag = false;
                        int num = 0;
                        Logger( $" 2.0.1  {((Model.ElectricObject)treeNodeObj2.Tag).ToString().Trim()} id = {((Model.ElectricObject)treeNodeObj2.Tag).Id}. Родитель ветки id = {((Model.ElectricObject)treeNodeObj2.Parent.Tag).Id} {treeNodeObj2.Parent.Tag.ToString()} {(((Model.ElectricObject)treeNodeObj2.Parent.Tag).Parent != null?"(принадлежит id = "+((Model.ElectricObject)treeNodeObj2.Parent.Tag).Parent.Id+" "+((Model.ElectricObject)treeNodeObj2.Parent.Tag).Parent.ToString()+")":"")} <-> {treeNodeObj2.Level}", flagOut);
                        while (treeNodeObj2.Parent != null)
                        {
                            if (treeNodeObj2.Tag == null)
                            {
                                MessageBox.Show("В элементе дерева нет объекта схемы");
                                return;
                            }
                            
                            if (treeNodeObj2.Tag.GetType() == typeof(Model.ElectricBus) && (((Model.ElectricBus)treeNodeObj2.Tag).TypeBus == Model.eTypeShinaTool.Shina_6 || ((Model.ElectricBus)treeNodeObj2.Tag).TypeBus == Model.eTypeShinaTool.Shina_10))
                            {
                                Model.ElectricBus electricBus = (Model.ElectricBus)treeNodeObj2.Tag;
                                Logger( $"   2.0.1.1 electricBus id = {electricBus.Id} name = {electricBus.ToString().Trim()} (Родитель id = {electricBus.Parent.Id} {electricBus.Parent.ToString()}) <-> {treeNodeObj2.Level}", flagOut);
                                if (!dictionaryElectricBus.ContainsKey(electricBus))
                                {
                                    DataRow[] rowSwitch = this.dtSwitch.Select("IdBus = " + electricBus.Id.ToString());
                                    if (rowSwitch.Length != 0)
                                    {
                 
                                        object[,] arraySwitch = new object[rowSwitch.Length, 8];
                                        for (int i = 0; i < rowSwitch.Length; i++)
                                        {
                                            arraySwitch[i, 0] = rowSwitch[i][1];
                                            arraySwitch[i, 1] = rowSwitch[i][5];
                                            arraySwitch[i, 2] = rowSwitch[i][2];
                                            arraySwitch[i, 3] = rowSwitch[i][3];
                                            arraySwitch[i, 4] = rowSwitch[i][4];
                                            arraySwitch[i, 5] = rowSwitch[i][6];
                                            arraySwitch[i, 6] = rowSwitch[i][7];
                                            arraySwitch[i, 7] = rowSwitch[i][8];
                                            num += (int)arraySwitch[i, 1];
                                        }
                                        dictionaryElectricBus.Add(electricBus, arraySwitch);
                                    }
                                    else
                                    {
                                        dictionaryElectricBus.Add(electricBus, new object[1, 1]);
                                    }
                                }
                                flag = true;
                                if (!listObj.Contains(electricBus))
                                {
                                    listObj.Add(electricBus);
                                }
                            }
                            else if (treeNodeObj2.Tag.GetType() == typeof(Model.ElectricLine))
                            {
                                if (electricObjectBeg == null)
                                {
                                    electricObjectBeg = (Model.ElectricObject)treeNodeObj2.Tag;
                                    treeNodeObj2 = treeNodeObj2.Parent;
                                    continue;
                                }
                                Model.ElectricLine electricLine = (Model.ElectricLine)treeNodeObj2.Tag;
                                List<Model.ElectricRelation> listRelation = new List<Model.ElectricRelation>();
                                Model.ElectricPoint pointBeg = Model.ElectricObject.GetLinkPoint(electricLine, electricObjectBeg);
                            
                                Model.ElectricObject electricObjectEnd = (Model.ElectricObject)treeNodeObj2.Parent.Tag;
                                Model.ElectricPoint pointEnd = Model.ElectricObject.GetLinkPoint(electricLine, electricObjectEnd);
                                electricLine.getRelationWay(pointBeg, pointEnd, null, listRelation);
                                Logger($"    2.0.1.2 electricLine id = {electricLine.Id} name = {electricLine.ToString().Trim()} {(electricLine.Parent != null ? " (Родитель id = " + electricLine.Parent.Id  + " " + electricLine.Parent.ToString() +")" :"")} <-> {treeNodeObj2.Level}", flagOut);
                                foreach (Model.ElectricRelation key2 in listRelation)
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
                                if (!listObj.Contains(electricLine) && flag)
                                {
                                    listObj.Add(electricLine);
                                }
                            }
                            //Logger("+");
                            electricObjectBeg = (Model.ElectricObject)treeNodeObj2.Tag;
                            treeNodeObj2 = treeNodeObj2.Parent;
                            //Logger($"{treeNodeObj2.Tag}");
                            //Logger($"{treeNodeObj2.Tag.GetType()}");
                            if (treeNodeObj2.Tag.GetType() == typeof(Model.ElectricLine) && ((Model.ElectricLine)treeNodeObj2.Tag).IsCell() && dictionaryElectricCell.ContainsKey((Model.ElectricLine)treeNodeObj2.Tag))
                            {
                                //Logger( $" 2.0.2 доп. список {(Model.ElectricObject)treeNodeObj2.Tag} id = {((Model.ElectricObject)treeNodeObj2.Tag).Id}", flagOut);
                                foreach (Model.ElectricObject item in listObj)
                                {
                                    if (!dictionaryElectricCell[(Model.ElectricLine)treeNodeObj2.Tag].Contains(item))
                                    {
                                        dictionaryElectricCell[(Model.ElectricLine)treeNodeObj2.Tag].Add(item);
                                        //Logger( $"    2.0.2.1  ElectricLine {(Model.ElectricLine)treeNodeObj2.Tag} id= {item.Id} name =  {item.Name.Trim()}", flagOut);
                                    }
                                }
                            }
                            //Logger("+");
                        }
                        //Logger(n.ToString());
                    }
                    // Вывод на печать
                    Logger( $"3.Resultat. Вывод данных", flagOut);
                    foreach (Model.ElectricLine electricLine2 in dictionaryElectricCell.Keys)
                    {
                        int SummaMaximumLoad = 0; // максимальная сумма нагрузок на ячейку
                        foreach (Model.ElectricObject obj in dictionaryElectricCell[electricLine2])
                        {
                            if (obj.GetType() == typeof(Model.ElectricBus))
                            {
                                Model.ElectricBus keyBus = (Model.ElectricBus)obj;
                                Logger( $" 3.1 ElectricBus id = {keyBus.Id} name ={keyBus.Name}", flagOut);
                                object[,] arrayBus = dictionaryElectricBus[keyBus];
                                if (arrayBus.Length != 1)
                                {
                                    for (int j = 0; j < arrayBus.Length / 8; j++)
                                    {
                                        Logger( $" 3.1 ElectricBus id = {keyBus.Id} name ={keyBus.Name} массив {(int)arrayBus[j, 1]}", flagOut);
                                        SummaMaximumLoad += (int)arrayBus[j, 1];
                                    }
                                }
                            }
                        }
                        Logger( $" 3.1  ElectricLine id ={electricLine2.Id} name ={electricLine2.Name} CountSwith = {SummaMaximumLoad}", flagOut);
                        foreach (Model.ElectricObject electricObject5 in dictionaryElectricCell[electricLine2])
                        {
                            if (electricObject5.GetType() == typeof(Model.ElectricBus))
                            {
                                Model.ElectricBus keyBus = (Model.ElectricBus)electricObject5;
                                object[,] arrayBus = dictionaryElectricBus[keyBus];
                                if (arrayBus.Length == 1)
                                {
                                    DataRow dataRow = this.dataSetScheme.MeasurementReport1.NewRow();
                                    dataRow["roottp"] = electricLine2.Parent.ToString();
                                    dataRow["cell"] = electricLine2.ToString();
                                    dataRow["tp"] = keyBus.Parent.ToString();
                                    dataRow["I"] = SummaMaximumLoad.ToString();
                                    dataRow["Comment"] = ((((Model.ElectricSubstation)keyBus.Parent).Tag == null || !Convert.ToBoolean(((Model.ElectricSubstation)keyBus.Parent).Tag)) ? string.Empty : "Абонентская");
                                    this.dataSetScheme.MeasurementReport1.Rows.Add(dataRow);
                                }
                                else
                                {
                                    for (int k = 0; k < arrayBus.Length / 8; k++)
                                    {
                                        DataRow dataRow2 = this.dataSetScheme.MeasurementReport1.NewRow();
                                        dataRow2["roottp"] = electricLine2.Parent.ToString();
                                        dataRow2["cell"] = electricLine2.ToString();
                                        dataRow2["tp"] = keyBus.Parent.ToString();
                                        DataRow[] array6 = this.dtTrans.Select("id = " + ((int)arrayBus[k, 0]).ToString());
                                        if (array6.Length != 0)
                                        {
                                            dataRow2["trans"] = array6[0][1];
                                            dataRow2["PkVA"] = array6[0][2];
                                        }
                                        else
                                        {
                                            dataRow2["trans"] = ((int)arrayBus[k, 0]).ToString();
                                        }
                                        dataRow2["I"] = SummaMaximumLoad.ToString();
                                        dataRow2["A"] = arrayBus[k, 2].ToString();
                                        dataRow2["B"] = arrayBus[k, 3].ToString();
                                        dataRow2["C"] = arrayBus[k, 4].ToString();
                                        dataRow2["Date"] = ((DateTime)arrayBus[k, 5]).ToString("dd.MM.yy");
                                        dataRow2["Time"] = ((DateTime)arrayBus[k, 5]).ToString("HH:mm");
                                        dataRow2["Disp"] = arrayBus[k, 6].ToString();
                                        dataRow2["TemperatureD"] = arrayBus[k, 7].ToString();
                                        this.dataSetScheme.MeasurementReport1.Rows.Add(dataRow2);
                                    }
                                }
                            }
                            else if (electricObject5.GetType() == typeof(Model.ElectricLine))
                            {
                                Model.ElectricLine electricLine3 = (Model.ElectricLine)electricObject5;
                                int num3 = 0;
                                int TypeBus = 0;

                                foreach (Model.ElectricObject electricObject6 in electricLine3.ChildObjects.Where(((Model.ElectricObject c) => c is Model.ElectricRelation && relationsMeasurement.ContainsKey((Model.ElectricRelation)c))))
                                {
                                    Model.ElectricRelation electricRelation = (Model.ElectricRelation)electricObject6;
                                    if (relationsMeasurement[electricRelation] > num3)
                                    {
                                        num3 = relationsMeasurement[electricRelation];
                                    }
                                    TypeBus = (int)((Model.ElectricBus)electricLine3.Amperages[electricRelation.amperagePoint].Source).TypeBus;
                                }
                                DataRow dataRow3 = this.dataSetScheme.MeasurementReport2.NewRow();
                                dataRow3["roottp"] = electricLine2.Parent.ToString();
                                dataRow3["cell"] = electricLine2.ToString();
                                dataRow3["KLVL"] = electricLine3.ToString();
                                DataRow[] array7 = this.dtCable.Select("id = " + electricLine3.Id.ToString());
                                if (array7.Length != 0)
                                {
                                    int key4 = Convert.ToInt32(array7[0][2]);
                                    dataRow3["section"] = key4.ToString();
                                    if (dictionary.ContainsKey(key4))
                                    {
                                        int value = 0;
                                        if (TypeBus == 541)
                                        {
                                            value = dictionary[key4][0];
                                        }
                                        else if (TypeBus == 564)
                                        {
                                            value = dictionary[key4][1];
                                        }
                                        dataRow3["pload"] = value.ToString();
                                        dataRow3["loading"] = Math.Round((double)(Convert.ToSingle(num3) / Convert.ToSingle(value) * 100f)).ToString();
                                    }
                                }
                                dataRow3["measurement"] = num3;
                                this.dataSetScheme.MeasurementReport2.Rows.Add(dataRow3);
                            }
                        }
                    }
                    Logger( $"4 окончание", flagOut);
                }
            }
        }
       
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "TPMeasurement";
            reportDataSource.Value = this.dataSetScheme.MeasurementReport1;
            this.reportViewer0.LocalReport.DataSources.Add(reportDataSource);
            ReportDataSource reportDataSource2 = new ReportDataSource();
            reportDataSource2.Name = "CabMeasurement";
            reportDataSource2.Value = this.dataSetScheme.MeasurementReport2;
            this.reportViewer0.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer0.LocalReport.ReportEmbeddedResource = this.rdlc;
            this.reportViewer0.RefreshReport();
            this.panelProgress.Visible = false;
            this.progressBarEndLess.AutoProgress = false;
            this.dataGridViewCab.DataSource = this.measurementReport2BindingSource;
            this.dataGridViewTrans.DataSource = this.measurementReport1BindingSource;
            this.panelDataGrid.Enabled = true;
            this.panelDataGrid.Visible = true;

            this.toolStrip1.Enabled = true;
        }

        private void FormMeasuringReport_Resize(object sender, EventArgs e)
        {
            this.panelProgress.Left = base.Width / 2 - this.progressBarEndLess.Width / 2;
            this.panelProgress.Top = base.Height / 2 - this.progressBarEndLess.Height / 2;
        }

        private void toolStripButtonGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.sys)
            {
                this.sys = true;
                this.toolStripButtonReport.Checked = !this.toolStripButtonGrid.Checked;
                this.sys = false;
            }
            this.panelDataGrid.Enabled = (this.panelDataGrid.Visible = this.toolStripButtonGrid.Checked);
        }

        private void toolStripButtonReport_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.sys)
            {
                this.sys = true;
                this.toolStripButtonGrid.Checked = !this.toolStripButtonReport.Checked;
                this.sys = false;
            }
            this.panelReport.Enabled = (this.panelReport.Visible = this.toolStripButtonReport.Checked);
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.StartBackGround();
        }

        private void экспортТаблицыВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.экспортТаблицыВExcelToolStripMenuItem.Tag != null && this.экспортТаблицыВExcelToolStripMenuItem.Tag.GetType() == typeof(DataGridViewExcelFilter))
            {
                ((DataGridViewExcelFilter)this.экспортТаблицыВExcelToolStripMenuItem.Tag).CopyToExcel(true);
            }
        }

        private void tsbReport_Click(object sender, EventArgs e)
        {
            this.StartBackGround();
        }
        private void Logger (string message, bool flagOut = true)
        {
            if(flagOut) Log.Write(LogLevel.Info, "SchemeReports", "FormMeasuringReport","Report", message);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (this.cmbYear.SelectedItem != null)
            {
                this.MeasurementYear = Convert.ToInt32(this.cmbYear.SelectedItem);
            }
            //режим отображения сети
            bool isNormalSimulationMode = true;
            if (this.toolCmbTypeSchema.SelectedIndex == 0)
            {
                isNormalSimulationMode = false;
            }

            MeasurementReport(new SimulationMode(isNormalSimulationMode, this.MeasurementYear));
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            this.dataGridViewTrans.ExportToExcel();
            this.dataGridViewCab.ExportToExcel();
        }
    }
}