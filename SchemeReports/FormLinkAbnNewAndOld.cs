using FormLbr;
using SchemeModel;
using SchemeModel.Calculations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;
using ModelN = SchemeModelN;
using ModelNCalc = SchemeModelN.Calculations;

namespace SchemeReports
{
    public partial class FormLinkAbnNewAndOld : FormBase
    {
        private bool flag0 = true;
        private bool flag = true;
        private DataTable dtSchmAbnFull;
        private DataTable dtSchmCable;
        private DataTable dtSchmCell;
        private DataTable dtReportCP1;
        private DataTable dtSchmTr;

        public FormLinkAbnNewAndOld()
        {
            this.dtSchmAbnFull = new DataTable("vL_SchmAbnFull");
            this.dtSchmCable = new DataTable("SchmCable");
            this.dtSchmCell = new DataTable("SchmCell");
            this.dtReportCP1 = new DataTable("dtReportCP1");
            this.dtSchmTr = new DataTable("SchmTr");
            //this.TPConnectDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            //this.tPrazrDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();

            this.InitializeComponent();

            // this.columncontact.MaxLength = int.MaxValue;
            /*************************************************************************/


            this.TPConnectDgvColumn.DataPropertyName = "GosTP";
            this.TPConnectDgvColumn.HeaderText = "ПС (Госсектор)";
            this.TPConnectDgvColumn.Name = "TPConnectDgvColumn";
            this.TPConnectDgvColumn.ReadOnly = true;

            this.tPrazrDgvColumn.DataPropertyName = "razrTP";
            this.tPrazrDgvColumn.HeaderText = "ТП (Разреш)";
            this.tPrazrDgvColumn.Name = "tPrazrDgvColumn";
            this.tPrazrDgvColumn.ReadOnly = true;
            /*********************************************************************/
            this.dateTimePeriodKWT = new DateTimePicker();
            this.dateTimePeriodKWT.Width = 120;
            this.dateTimePeriodKWT.Format = DateTimePickerFormat.Custom;
            this.dateTimePeriodKWT.CustomFormat = "MMMM yyyy";
            this.dateTimePeriodKWT.Value = DateTime.Now.AddMonths(-1);
            this.dateTimePeriodKWT.ValueChanged += new EventHandler(this.dateTimePicker_ValueChanged);
            int num = 0;

            foreach (var enumerator in this.toolStrip.Items)
            {
                {
                    if ((ToolStripItem)enumerator == this.toolLabelPeriodKWT)
                    {
                        break;
                    }
                    num++;
                }
            }
            this.toolStrip.Items.Insert(num + 1, new ToolStripControlHost(this.dateTimePeriodKWT));
            this.bsSchmAbnFull.DataSource = this.dtSchmAbnFull;
        }

        private void FormLinkAbnNewAndOld_Load(object sender, EventArgs e)
        {
            this.toolCmbTypeSchema.SelectedIndex = 1;
            //this.StartBackGroundLinkAbnNewAndOld();
            //this.StartBackGroundLinkAbnWithCP();
            this.toolCmbTypeSchema.SelectedIndexChanged += this.toolStripComboBox_SelectedIndexChanged;
        }

        //
        private void StartBackGroundLinkAbnNewAndOld()
        {
            this.panelProgress.Visible = true;
            this.progressBarEndLess.AutoProgress = true;
            this.panelProgress.Left = base.Width / 2 - this.panelProgress.Width / 2;
            this.panelProgress.Top = base.Height / 2 - this.panelProgress.Height / 2;
            this.splitContainer1.Enabled = false;
            this.tabControl1.Enabled = false;

            this.toolStrip.Enabled = false;
            this.dgvListLegal.DataSource = null;
            this.dgvListLegalContact.DataSource = null;
            this.flag0 = false;
            this.bgLinkAbnNewAndOld.RunWorkerAsync();
        }

        private void bgLinkAbnNewAndOld_DoWork(object sender, DoWorkEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(GetResource.GetStringAssembly("SchemeReports.ReportLinkAbnNewAndOld.sql"), sqlConnection);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    this.dtSchmAbnFull.Clear();
                    sqlDataAdapter.Fill(this.dtSchmAbnFull);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
        }

        private void FormLinkAbnNewAndOld_Resize(object sender, EventArgs e)
        {
            this.panelProgress.Left = base.Width / 2 - this.progressBarEndLess.Width / 2;
            this.panelProgress.Top = base.Height / 2 - this.progressBarEndLess.Height / 2;
        }

        private void bgLinkAbnNewAndOld_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.flag0 = true;
            if (this.flag && this.flag0)
            {
                this.StopBackGround();
            }
        }

        private void bsSchmAbnFullCurrentChanged(object sender, EventArgs e)
        {
            if (this.bsSchmAbnFull.Current != null)
            {
                int num = Convert.ToInt32(((DataRowView)this.bsSchmAbnFull.Current).Row["idAbn"]);
                base.SelectSqlData(this.dataSetScheme, this.dataSetScheme.tAbnContact, true, "where [idAbn] = " + num);
                return;
            }
            this.dataSetScheme.tAbnContact.Clear();
        }

        private void toolBtnRefresh_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab == this.tabPage811_2019)
                this.StartBackGroundLinkAbnWithCP_2019();
            else if (this.tabControl1.SelectedTab == this.tabPage811)
                this.StartBackGroundLinkAbnWithCP();
            else
                this.StartBackGroundLinkAbnNewAndOld();
        }
        private void toolBtnExportExcel_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab == this.tabPageAbnWithCP)
            {
                this.dgvReportCP.ExportToExcel();
            }
            if (this.tabControl1.SelectedTab == this.tabPageLegal)
            {
                this.dgvListLegal.CopyToExcel(true);
            }
            if (this.tabControl1.SelectedTab == this.tabPage811)
            {
                //this.dgvReport811.CopyToExcel(true);
                this.dgvReport811.ExportToExcel();
            }
            if (this.tabControl1.SelectedTab == this.tabPage811_2019)
            {
                //this.dgvReport811.CopyToExcel(true);
                this.dgvReport811_2019.ExportToExcel();
            }
            if (this.tabControl1.SelectedTab == this.tabPageNominalPowerCP)
            {
                //this.dgvReport811.CopyToExcel(true);
                this.dgvNominalPowerCP.ExportToExcel();
            }
        }
        private void toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
        }
        #region 2018
        private void StartBackGroundLinkAbnWithCP()
        {
            this.panelProgress.Visible = true;
            this.progressBarEndLess.AutoProgress = true;
            this.panelProgress.Left = base.Width / 2 - this.panelProgress.Width / 2;
            this.panelProgress.Top = base.Height / 2 - this.panelProgress.Height / 2;
            this.splitContainer1.Enabled = false;
            this.tabControl1.Enabled = false;

            this.toolStrip.Enabled = false;
            this.dgvReportCP.DataSource = null;
            this.flag = false;
            // режим отображения сети
            bool isNormalSimulationMode = true;
            if (this.toolCmbTypeSchema.SelectedIndex == 0)
            {
                isNormalSimulationMode = false;
            }
            this.bgLinkAbnWithCP.RunWorkerAsync(new FormLinkAbnNewAndOld.SimulationMode(isNormalSimulationMode, this.dateTimePeriodKWT.Value));
        }
        private void bgLinkAbnWithCP_DoWork(object sender, DoWorkEventArgs e)
        {
            // таблица брони
            dtActApprovalReservation = new DataTable();
            References.SchemeTables.GetReferensTable(dtActApprovalReservation, "SqlScripts.ActApprovalReservation", SqlSettings);
            // таблица кабелей
            References.SchemeTables.GetTableSchmCable(dtSchmCable, SqlSettings);
            // таблица ячеек
            References.SchemeTables.GetTableSchmCell(dtSchmCell, SqlSettings);
            // таблица привязок
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    //SqlCommand sqlCommand = new SqlCommand(GetResource.GetStream("SchemeReports.ReportLinkAbnWithCP.sql"), sqlConnection);
                    SqlCommand sqlCommand = new SqlCommand(GetResource.GetStringAssembly("SchemeReports.ReportLinkAbnWithCP-5.sql"), sqlConnection);
                    sqlCommand.Parameters.Add("dt", SqlDbType.DateTime).Value = ((FormLinkAbnNewAndOld.SimulationMode)e.Argument).PeriodDateTime;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    this.dtReportCP.Clear();
                    sqlDataAdapter.Fill(this.dtReportCP);

                    ElectricModel electricModel = new ElectricModel();
                    electricModel.SqlSettings = this.SqlSettings;
                    electricModel.LoadSchema(((FormLinkAbnNewAndOld.SimulationMode)e.Argument).IsSimulationMode);
#if !DEBUG
                    Thread thread = new Thread(new ParameterizedThreadStart(this.FillReportCP));
                    thread.Start(new FormLinkAbnNewAndOld.ReestrObjectsSchemaForReport(0, this.dtReportCP.Rows.Count / 2, electricModel));

                    Thread thread2 = new Thread(new ParameterizedThreadStart(this.FillReportCP));
                    thread2.Start(new FormLinkAbnNewAndOld.ReestrObjectsSchemaForReport(this.dtReportCP.Rows.Count / 2 + 1, this.dtReportCP.Rows.Count, electricModel));

                    thread.Join();
                    thread2.Join();
#else
                    Thread thread = new Thread(new ParameterizedThreadStart(this.FillReportCP));
                    thread.Start(new FormLinkAbnNewAndOld.ReestrObjectsSchemaForReport(0, this.dtReportCP.Rows.Count, electricModel));
                    thread.Join();
#endif
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }

            try
            {
                //var dtReportr811 = dtReportCP.AsEnumerable()
                //            .GroupBy(r => new
                //            {
                //                typeAbnName = r["typeAbnName"],
                //                categoryName = r["categoryName"],
                //                cellName = r["cellName"],

                //                busName = r["busName"],
                //                subName = r["subName"],

                //                schmObjName = r["schmObjName"],
                //                cellCPName = r["cellCPName"],

                //                busCPName = r["busCPName"],
                //                subCPName = r["subCPName"],

                //                listNodes = r["listNodes"],
                //                listNodesDown = r["listNodesDown"],

                //                Voltage = r["Voltage"]
                //            })
                //            .Select(d => new { value = d.Key, SumMeter = d.Sum(n => n.Field<int>("Meter")) })
                //            // .ToList()
                //            //.OrderBy(d => d.value.busCPName)
                //            ;
                /*1  формируем сгруппированный реестр  кол.-ва счетчиков по пустым привязкам*/
                var dt1 = dtReportCP.AsEnumerable()
                    .Where(r => (bool)r["is811"] == true && r["subName"].ToString() == "")
                    .GroupBy(r => new { category = r["categoryName"], voltage = r["Voltage"], typeAbn = r["typeAbnName"] })
                    .Select(rrr => new
                    {
                        Cat = rrr.Key.category.ToString(),
                        Vol = rrr.Key.voltage.ToString(),
                        //TypeA = rrr.Key.typeAbn.ToString(),
                        Summa = rrr.Sum(w => (int)w["Meter"])
                    })
                    .ToList();

                /*2 формируем итоговый реестр */
                /* заполним нулевые значения из dt1 */
                /* уберем пустые привязки */
                this.dsSchemeReports1.tReport811.Clear();
                DataTable dt811 = this.dsSchemeReports1.tReport811;
                foreach (DataRow row in dtReportCP.AsEnumerable().Where(r => (bool)r["is811"] == true && r["subName"].ToString() != ""))
                {
                    int MeterCount = Convert.ToInt32(row["Meter"]);
                    if (MeterCount == 0)
                    {
                        // обнулим суммы в таблице dt1
                        for (int i = 0; i < dt1.Count; i++)
                        {
                            //var row1 = dt1[i];
                            if (dt1[i].Cat == row["categoryName"].ToString()
                                && dt1[i].Vol == row["Voltage"].ToString()
                                //&& dt1[i].TypeA == row["typeAbnName"].ToString()
                                )
                            {
                                if (dt1[i].Summa != 0)
                                {
                                    MeterCount = 1;
                                    int Summa = dt1[i].Summa - 1;
                                    //dt1[i] = new { dt1[i].Cat, dt1[i].Vol, dt1[i].TypeA, Summa };
                                    dt1[i] = new { dt1[i].Cat, dt1[i].Vol, Summa };
                                }
                                break;
                            }
                        }
                    }

                    DataRow row2 = dt811.NewRow();
                    row2["subCPName"] = row["subCPName"];
                    row2["listNodes"] = row["listNodes"];
                    row2["subName"] = row["subName"];
                    row2["HighestVoltageClass"] = row["highestVoltageClass"];
                    row2["listNodesDown"] = row["listNodesDown"];
                    row2["VoltageClass"] = row["voltageClass"];

                    switch (row["categoryName"].ToString())
                    {
                        case "I":
                            row2["CategoryReliabilityFirst"] = MeterCount;
                            break;
                        case "II":
                            row2["CategoryReliabilitySecond"] = MeterCount;
                            break;
                        case "III":
                            row2["CategoryReliabilityThird"] = MeterCount;
                            break;
                        default:
                            row2["CategoryReliabilityThird"] = MeterCount;
                            break;
                    }
                    switch (row["Voltage"].ToString())
                    {
                        case "ВН":
                            row2["LevelVoltageHV"] = MeterCount;
                            break;
                        case "СН-1":
                            row2["LevelVoltageSV-1"] = MeterCount;
                            break;
                        case "СН-2":
                            row2["LevelVoltageSV-2"] = MeterCount;
                            break;
                        case "НН":
                            row2["LevelVoltageLV"] = MeterCount;
                            break;
                        default:
                            row2["LevelVoltageLV"] = MeterCount;
                            break;
                    }
                    if (row["typeAbnName"].ToString() == "Сетевая организация")
                        row2["NetworkOrganizations"] = MeterCount;
                    row2["MeterAll"] = MeterCount;
                    row2["Commnets"] = row["categoryName"].ToString() + "; " + row["Voltage"].ToString();// + "; " + row["typeAbnName"].ToString();
                    dt811.Rows.Add(row2);
                }

                /* 3 если в dt1 остались данные, то размажем уже в конечной таблице dt*/
                for (int j = 0; j < dt1.Count; j++)
                {
                    //var row1 = dt1[j];
                    if (dt1[j].Summa != 0)
                    {
                        // CountCycles - количество циклов прогона по конечной таблице
                        int CountCycles = Convert.ToInt32(Math.Ceiling((decimal)dt1[j].Summa / (decimal)dt811.AsEnumerable().Count(r => r["Commnets"].ToString() == dt1[j].Cat + "; " + dt1[j].Vol)));
                        for (int k = 1; k <= CountCycles; k++)
                        {
                            // заполняем основной список
                            for (int i = 0; i < dt811.Rows.Count; i++)
                            {
                                if (dt1[j].Summa != 0)
                                {
                                    //DataRow row = dt811.Rows[i];
                                    if (dt811.Rows[i]["Commnets"].ToString() == dt1[j].Cat + "; " + dt1[j].Vol)
                                    {
                                        // 1 
                                        int Summa = dt1[j].Summa - 1;
                                        dt1[j] = new { dt1[j].Cat, dt1[j].Vol, Summa };
                                        // 2
                                        int MeterCount = Convert.ToInt32(dt811.Rows[i]["MeterAll"]) + 1;
                                        dt811.Rows[i]["MeterAll"] = MeterCount ;
                                        switch (dt1[j].Cat)
                                        {
                                            case "I":
                                                dt811.Rows[i]["CategoryReliabilityFirst"] = MeterCount;
                                                break;
                                            case "II":
                                                dt811.Rows[i]["CategoryReliabilitySecond"] = MeterCount;
                                                break;
                                            case "III":
                                                dt811.Rows[i]["CategoryReliabilityThird"] = MeterCount;
                                                break;
                                            default:
                                                dt811.Rows[i]["CategoryReliabilityThird"] = MeterCount;
                                                break;
                                        }
                                        switch (dt1[j].Vol)
                                        {
                                            case "ВН":
                                                dt811.Rows[i]["LevelVoltageHV"] = MeterCount;
                                                break;
                                            case "СН-1":
                                                dt811.Rows[i]["LevelVoltageSV-1"] = MeterCount;
                                                break;
                                            case "СН-2":
                                                dt811.Rows[i]["LevelVoltageSV-2"] = MeterCount;
                                                break;
                                            case "НН":
                                                dt811.Rows[i]["LevelVoltageLV"] = MeterCount;
                                                break;
                                            default:
                                                dt811.Rows[i]["LevelVoltageLV"] = MeterCount;
                                                break;
                                        }

                                    }
                                }
                            }
                        }
                    }
                }

                this.bsReport811.DataSource = dt811;  //this.dsSchemeReports1.tReport811;
                dgvReport811.DataSource = bsReport811;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка обработки №1: " + ex.Source);
            }

        }
        private void bgLinkAbnWithCP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.flag = true;
            if (this.flag && this.flag0)
            {
                this.StopBackGround();
            }
        }
        FormLinkAbnNewAndOld.ReestrObjectsSchemaForReport objectSchema;
        private DataTable dtActApprovalReservation;

        private void FillReportCP(object FullObjectsSchema)
        {
            //FullObjectsSchema - полный список объектов схемы
            objectSchema = (FormLinkAbnNewAndOld.ReestrObjectsSchemaForReport)FullObjectsSchema;
            for (int i = objectSchema.Begin; i < objectSchema.End; i++)
            {
                DataRow dataRow = this.dtReportCP.Rows[i];
                // затолкаем броню
                // var dt2 = dtReportCP.Join(dtActApprovalReservation, )
                DataRow[] dataRowAct = dtActApprovalReservation.Select($"idAbn = {dataRow["idAbn"]} and idAbnObj = {dataRow["idAbnObj"]} ");

                if (dataRowAct.Length > 0)
                {
                    dataRow["NumDoc"] = dataRowAct[0]["NumDoc"];
                    dataRow["DateDoc"] = dataRowAct[0]["DateDoc"];
                    dataRow["EmergencyReserv"] = dataRowAct[0]["EmergencyReserv"];
                    dataRow["TechnologicalReserv"] = dataRowAct[0]["TechnologicalReserv"];
                }



                if (dataRow["idSchmObj"] != DBNull.Value)
                {
                    // находим объект (от привязки абонента) в электрической модели схемы
                    ElectricObject electricObjectById = objectSchema.ElModel.GetElectricObjectById(Convert.ToInt32(dataRow["idSchmObj"]));
                    if (
                        electricObjectById != null && 
                        (!(electricObjectById is ElectricBus) || ((ElectricBus)electricObjectById).Amperage != null) && 
                        (!(electricObjectById is ElectricLine) || ((ElectricLine)electricObjectById).AmperageCount != 0)
                        )
                    {
                        // первая точка это electricObjectById - по нему определим первую подстанцию, ее тип и напряжение
                        // если parent = null, то привязка не к ячейке, а к подстанции, либо шине
                        // SubName - имя подстанции к которой осуществлена привязка
                        string SubName = "";
                        string SubNameShort = "";

                        // listNodesDown - список - цепочка кабельных и воздушных линий от рубильника до абонента после подстанции
                        string listNodesDown = "";
                        double VoltageLineDown = 0;
                        string VoltageClass = "";
                        // соберем дерево объектов
                        // forwardDirection = false - смотрим дерево вверх к запитке
                        // forwardDirection = true - смотрим дерево внихз к подчиненным веткам
                        // withounLastCell - формирование списка из подчиненных веток - без всяких херней 

                        // если привязка к шине или подстанции, то пропускаем
                        // проверить привязку к высоковольтной ячейке
                        // привязка всегда у ячейка долна быть по идее
                        if (electricObjectById is ElectricLine)
                        {
                            var listNodeObjDown = objectSchema.ElModel.PoweringReportForDrawObject(electricObjectById, true, true);
                            if (listNodeObjDown != null)
                            {
                                DataRow[] row;
                                foreach (var node in listNodeObjDown)
                                {
                                    if ((ElectricObject)node is ElectricLine)
                                        if (!(((ElectricLine)node).IsCell()))
                                        {
                                            row = dtSchmCable.Select("id = " + ((ElectricObject)node).Id);
                                            if (row.Count() > 0)
                                            {
                                                listNodesDown = listNodesDown + (listNodesDown != "" ? "; " : "") + row.First()["TypeCable"] + " " + VoltageLineDown.ToString().Replace(",", ".") + " кВ " + node.ToString();//.Replace("\\", "/");
                                            }
                                        }
                                        else
                                        {
                                            row = dtSchmCell.Select("id = " + ((ElectricObject)node).Id);
                                            if (row.Count() > 0)
                                            {
                                                VoltageLineDown = Convert.ToDouble(row.First()["Value"]);
                                                if (VoltageClass == "" || VoltageClass == null) VoltageClass = VoltageLineDown.ToString().Replace(",", ".");
                                            }
                                        }
                                }
                            }
                            // если нет родителя у ячейки, то попытаемся его заполнить
                            // у ячейки должен быть родитель подстанция (заполняем ее)
                            if (electricObjectById.Parent == null)
                            {
                                var Parents_ElectricObjectById = ((SchemeModel.ElectricLine)electricObjectById).Ends.Where(s => s.Parent != null);
                                var FirstPoint = Parents_ElectricObjectById.First();
                                if (FirstPoint != null)
                                {
                                    // у точки родитель должна быть шина!!! у шины подстанция
                                    if (FirstPoint.Parent is ElectricBus)
                                        electricObjectById.Parent = FirstPoint.Parent.Parent;
                                    else if (FirstPoint.Parent is ElectricSubstation) // это маловероятно - но кто его знает
                                        electricObjectById.Parent = FirstPoint.Parent;
                                }
                            }
                        }
                        TreeNodeObj treeNodeObj = objectSchema.ElModel.PoweringReportForDrawObject(Convert.ToInt32(dataRow["idSchmObj"]), false);
                        if (treeNodeObj != null)
                        {
                            string BusCPName = "";
                            string BusCPId = "";
                            string SubCPName = "";
                            string SubCpId = "";
                            string CellCPName = "";
                            string CellCpId = "";
                            // набор - список - цепочка кабельных и воздушных линий
                            string listNodes = "";
                            // напряжение линии
                            string VoltageLine = "";
                            int num = 0;
                            // здесь ищем начало дерева - запитка и находим последнюю подстанцию по idSchmObj
                            // LeafsList - список листьев дерева (сколько их может быть?)
                            // treeNodeObj.Nodes - узел верхний - здесь можно собрать всю цепочку снизу до верху через Nodes
                            // где тип объекта искать неизвестно пока-что
                            // num - количество родителей - запиток
                            // если num > 1, то дублируем (клонируем) обрабатываемую запись
                            foreach (TreeNodeObj treeNodeObj2 in treeNodeObj.LeafsList)
                            { /*1*/
                                if (treeNodeObj2.Tag != null && treeNodeObj2.Tag is ElectricObject)
                                {
                                    if (treeNodeObj2.Parent != null && treeNodeObj2.Parent.Tag != null && treeNodeObj2.Parent.Tag is ElectricObject)
                                    {
                                        CellCPName = ((ElectricObject)treeNodeObj2.Parent.Tag).ToString();
                                        CellCpId = ((ElectricObject)treeNodeObj2.Parent.Tag).Id.ToString();
                                    }
                                    BusCPName = ((ElectricObject)treeNodeObj2.Tag).ToString();
                                    BusCPId = ((ElectricObject)treeNodeObj2.Tag).Id.ToString();
                                    if (((ElectricObject)treeNodeObj2.Tag).Parent != null)
                                    {
                                        SubCPName = ((ElectricObject)treeNodeObj2.Tag).Parent.ToString();
                                        SubCpId = ((ElectricObject)treeNodeObj2.Tag).Parent.Id.ToString();

                                        VoltageLine = Reference.Tables.GetVoltageObject(((ElectricBus)((ElectricObject)treeNodeObj2.Tag)).TypeBus);

                                        SubCPName = Reference.Tables.GetTypeSubstation(((ElectricSubstation)((ElectricObject)treeNodeObj2.Tag).Parent).TypeSubstation) + " " + VoltageLine + " кВ " + SubCPName;
                                    }
                                    if (electricObjectById.Parent != null)
                                    {
                                        SubNameShort = electricObjectById.Parent.ToString();
                                        SubName = Reference.Tables.GetTypeSubstation(((ElectricSubstation)electricObjectById.Parent).TypeSubstation) + " " + VoltageLine + " кВ " + SubNameShort;
                                    }
                                    else
                                    {
                                        SubNameShort = electricObjectById.ToString();
                                        SubName = Reference.Tables.GetTypeSubstation(((ElectricSubstation)electricObjectById).TypeSubstation) + " " + VoltageLine + " кВ " + SubNameShort;
                                    }
                                }
                                if (treeNodeObj2.GetRoot.Tag != null && treeNodeObj2.GetRoot.Nodes.Count() != 0)
                                {
                                    listNodes = GetNodesString(treeNodeObj2.GetRoot.Nodes.ElementAt(num), "", VoltageLine);
                                }
                                else
                                    listNodes = "";
                                // listNodesDown ==> не собрали/не нашли кабель до абонента
                                if (listNodesDown == "")
                                {
                                    listNodesDown = "КЛ 0.38 кВ " + SubNameShort + @"\" + dataRow["address"].ToString();
                                    VoltageClass = "0.38";
                                }

                                DataTable table = this.dtReportCP;
                                lock (table)
                                {
                                    if (num == 0)
                                    {
                                        dataRow["busCPName"] = BusCPName;
                                        dataRow["busCPId"] = BusCPId;
                                        dataRow["subCPName"] = SubCPName;
                                        dataRow["subCpId"] = SubCpId;
                                        dataRow["cellCPName"] = CellCPName;
                                        dataRow["cellCpId"] = CellCpId;
                                        // получим дерево линий в одной строке
                                        dataRow["listNodes"] = listNodes;
                                        dataRow["listNodesDown"] = listNodesDown;
                                        dataRow["subname"] = SubName;
                                        dataRow["highestVoltageClass"] = VoltageLine;
                                        dataRow["voltageClass"] = VoltageClass;
                                    }
                                    else // для журнала 8.1.1 этот блок не нужен, надо избавиться
                                    {
                                        // сравниваем новые параметры с предыдущимии
                                        if (!(
                                        dataRow["busCPId"].ToString() == BusCPId &&
                                        dataRow["subCpId"].ToString() == SubCpId &&
                                        dataRow["cellCpId"].ToString() == CellCpId
                                            ))
                                        {
                                            DataRow dataRow2 = this.dtReportCP.NewRow();
                                            dataRow2.ItemArray = (dataRow.ItemArray.Clone() as object[]);
                                            dataRow2["busCPName"] = BusCPName;
                                            dataRow2["busCPId"] = BusCPId;
                                            dataRow2["subCPName"] = SubCPName;
                                            dataRow2["subCpId"] = SubCpId;
                                            dataRow2["cellCPName"] = CellCPName;
                                            dataRow2["cellCpId"] = CellCpId;
                                            // получим дерево линий в одной строке
                                            dataRow2["listNodes"] = listNodes;
                                            dataRow2["listNodesDown"] = listNodesDown;
                                            dataRow2["subname"] = SubName;
                                            dataRow2["highestVoltageClass"] = VoltageLine;
                                            dataRow2["voltageClass"] = VoltageClass;
                                            // количество счетчиков равно нулю, надо будет потом размазать
                                            dataRow2["Meter"] = 0;
                                            dataRow2["is811"] = false;
                                            this.dtReportCP.Rows.Add(dataRow2);
                                        }
                                    }
                                }
                                num++;
                            } /*1*/
                        }
                    }
                }
            }
        }
        #endregion
        #region 2019
        private void StartBackGroundLinkAbnWithCP_2019()
        {
            this.panelProgress.Visible = true;
            this.progressBarEndLess.AutoProgress = true;
            this.panelProgress.Left = base.Width / 2 - this.panelProgress.Width / 2;
            this.panelProgress.Top = base.Height / 2 - this.panelProgress.Height / 2;
            this.splitContainer1.Enabled = false;
            this.tabControl1.Enabled = false;

            this.toolStrip.Enabled = false;
            this.dgvReport811_2019.DataSource = null;
            this.flag = false;
            // режим отображения сети
            bool isNormalSimulationMode = true;
            if (this.toolCmbTypeSchema.SelectedIndex == 0)
            {
                isNormalSimulationMode = false;
            }
            this.bgLinkAbnWithCP_2019.RunWorkerAsync(new FormLinkAbnNewAndOld.SimulationMode(isNormalSimulationMode, this.dateTimePeriodKWT.Value));
        }
        private void bgLinkAbnWithCP_2019_DoWork(object sender, DoWorkEventArgs e)
        {
            References.SchemeTables.GetTableSchmCable(dtSchmCable, SqlSettings);
            References.SchemeTables.GetTableSchmCell(dtSchmCell, SqlSettings);
            // таблица привязок
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    // SqlCommand sqlCommand = new SqlCommand(GetResource.GetStream("SchemeReports.ReportLinkAbnWithCP.sql"), sqlConnection);
                    SqlCommand sqlCommand = new SqlCommand(GetResource.GetStringAssembly("SchemeReports.vL_SchmAbnFull_2019.sql"), sqlConnection);
                    // SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(typeof(Reference.Tables).Assembly, "References.vL_SchmAbnFull_2019.sql"), sqlConnection);
                    sqlCommand.Parameters.Add("dt", SqlDbType.DateTime).Value = ((FormLinkAbnNewAndOld.SimulationMode)e.Argument).PeriodDateTime;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    this.dtReportCP.Clear();
                    sqlDataAdapter.Fill(this.dtReportCP);
                    ElectricModel electricModel = new ElectricModel();
                    electricModel.SqlSettings = this.SqlSettings;
                    electricModel.LoadSchema(((FormLinkAbnNewAndOld.SimulationMode)e.Argument).IsSimulationMode);
#if !DEBUG
                    Thread thread = new Thread(new ParameterizedThreadStart(this.FillReportCP_2019));
                    thread.Start(new FormLinkAbnNewAndOld.ReestrObjectsSchemaForReport(0, this.dtReportCP.Rows.Count / 2, electricModel));

                    Thread thread2 = new Thread(new ParameterizedThreadStart(this.FillReportCP_2019));
                    thread2.Start(new FormLinkAbnNewAndOld.ReestrObjectsSchemaForReport(this.dtReportCP.Rows.Count / 2 + 1, this.dtReportCP.Rows.Count, electricModel));

                    thread.Join();
                    thread2.Join();
#else
                    Thread thread = new Thread(new ParameterizedThreadStart(this.FillReportCP_2019));
                    thread.Start(new FormLinkAbnNewAndOld.ReestrObjectsSchemaForReport(0, this.dtReportCP.Rows.Count, electricModel));
                    thread.Join();
#endif
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }

            try
            {
                /*1  формируем сгруппированный реестр  кол.-ва счетчиков по пустым привязкам и пустым центрам питания*/
                var dtVoid = dtReportCP.AsEnumerable()
                    .Where(r => r["subName"].ToString() == "" || r["subCPName"].ToString() == "")
                    .GroupBy(r => new { category = r["categoryName"], voltage = r["Voltage"], NoNetwork = ((int)r["typeAbn"] != 231 && ((int)r["idAbnNet"] == 220859 || (int)r["idAbnNet"] == 434002 || (int)r["idAbnNet"] == -1)) })
                    .Select(rrr => new
                    {
                        Cat = rrr.Key.category.ToString(),
                        Vol = rrr.Key.voltage.ToString(),
                        //TypeA = rrr.Key.typeAbn.ToString(),
                        NoNet = rrr.Key.NoNetwork,
                        Summa = rrr.Sum(w => (int)w["Meter"]
                        )
                    })
                    .ToList();

                /*2 формируем итоговый реестр */
                /* заполним нулевые значения из dt1 */
                /* уберем пустые привязки */
                this.dsSchemeReports1.tReport811.Clear();
                DataTable dt811 = this.dsSchemeReports1.tReport811;
                //var dtTemp = dtReportCP.AsEnumerable().Where(r => r["subName"].ToString() != "" && r["subCPName"].ToString() != "");

                foreach (DataRow row in dtReportCP.AsEnumerable().Where(r => r["subName"].ToString() != "" && r["subCPName"].ToString() != ""))
                {
                    int MeterCount = Convert.ToInt32(row["Meter"]);
                    bool NoNet = ((int)row["typeAbn"] != 231 && ((int)row["idAbnNet"] == 220859 || (int)row["idAbnNet"] == 434002 || (int)row["idAbnNet"] == -1));
                    if (MeterCount == 0)
                    {
                        // обнулим суммы в таблице dt1
                        for (int i = 0; i < dtVoid.Count; i++)
                        {
                            if (dtVoid[i].Cat == row["categoryName"].ToString()   && dtVoid[i].Vol == row["Voltage"].ToString()
                                && (dtVoid[i].NoNet == NoNet))
                            {
                                if (dtVoid[i].Summa != 0)
                                {
                                    MeterCount = 1;
                                    int Summa = dtVoid[i].Summa - 1;
                                    dtVoid[i] = new { dtVoid[i].Cat, dtVoid[i].Vol, dtVoid[i].NoNet, Summa };
                                }
                                break;
                            }
                        }
                    }

                    DataRow row2 = dt811.NewRow();
                    row2["subCPName"] = row["subCPName"];
                    row2["listNodes"] = row["listNodes"];
                    row2["subName"] = row["subName"];
                    row2["HighestVoltageClass"] = row["highestVoltageClass"];
                    row2["listNodesDown"] = row["listNodesDown"];
                    row2["VoltageClass"] = row["voltageClass"];

                    if (MeterCount > 0)
                        if (NoNet)
                        {
                            switch (row["categoryName"].ToString())
                            {
                                case "I":
                                    row2["CategoryReliabilityFirst"] = MeterCount;
                                    break;
                                case "I особая":
                                    row2["CategoryReliabilityFirst"] = MeterCount;
                                    break;
                                case "II":
                                    row2["CategoryReliabilitySecond"] = MeterCount;
                                    break;
                                case "III":
                                    row2["CategoryReliabilityThird"] = MeterCount;
                                    break;
                                default:
                                    row2["CategoryReliabilityThird"] = MeterCount;
                                    break;
                            }
                            switch (row["Voltage"].ToString())
                            {
                                case "ВН":
                                    row2["LevelVoltageHV"] = MeterCount;
                                    break;
                                case "СН-1":
                                    row2["LevelVoltageSV-1"] = MeterCount;
                                    break;
                                case "СН-2":
                                    row2["LevelVoltageSV-2"] = MeterCount;
                                    break;
                                case "НН":
                                    row2["LevelVoltageLV"] = MeterCount;
                                    break;
                                default:
                                    row2["LevelVoltageLV"] = MeterCount;
                                    break;
                            }
                        }
                        else 
                        {
                            row2["NetworkOrganizations"] = MeterCount;
                        };

                    row2["MeterAll"] = MeterCount;
                    row2["Commnets"] = row["categoryName"].ToString() + "; " + row["Voltage"].ToString() + "; " + NoNet.ToString();// + "; " + row["typeAbnName"].ToString();
                    dt811.Rows.Add(row2);
                }
                /* 3 если в dtVoid остались данные, то размажем уже в конечной таблице dt*/
                for (int j = 0; j < dtVoid.Count; j++)
                {
                    if (dtVoid[j].Summa != 0)
                    {
                        // CountCycles - количество циклов прогона по конечной таблице
                        decimal tInt = (decimal)dt811.AsEnumerable().Count(r => r["Commnets"].ToString() == dtVoid[j].Cat + "; " + dtVoid[j].Vol + "; " + dtVoid[j].NoNet.ToString());
                        if (tInt > 0) // почему то не находятся значения
                        {
                            int CountCycles = Convert.ToInt32(Math.Ceiling((decimal)dtVoid[j].Summa / tInt));
                            for (int k = 1; k <= CountCycles; k++)
                            {
                                // заполняем основной список
                                for (int i = 0; i < dt811.Rows.Count; i++)
                                {
                                    if (dtVoid[j].Summa > 0)
                                    {
                                        if (dt811.Rows[i]["Commnets"].ToString() == dtVoid[j].Cat + "; " + dtVoid[j].Vol + "; " + dtVoid[j].NoNet.ToString())
                                        {
                                            // 1 
                                            int Summa = dtVoid[j].Summa - 1;
                                            dtVoid[j] = new { dtVoid[j].Cat, dtVoid[j].Vol, dtVoid[j].NoNet, Summa };
                                            // 2
                                            int MeterCount = Convert.ToInt32(dt811.Rows[i]["MeterAll"]) + 1;
                                            dt811.Rows[i]["MeterAll"] = MeterCount;
                                            if (dtVoid[j].NoNet) // если не сетевая компания
                                            {
                                                switch (dtVoid[j].Cat)
                                                {
                                                    case "I":
                                                        dt811.Rows[i]["CategoryReliabilityFirst"] = MeterCount;
                                                        break;
                                                    case "I особая":
                                                        dt811.Rows[i]["CategoryReliabilityFirst"] = MeterCount;
                                                        break;
                                                    case "II":
                                                        dt811.Rows[i]["CategoryReliabilitySecond"] = MeterCount;
                                                        break;
                                                    case "III":
                                                        dt811.Rows[i]["CategoryReliabilityThird"] = MeterCount;
                                                        break;
                                                    default:
                                                        dt811.Rows[i]["CategoryReliabilityThird"] = MeterCount;
                                                        break;
                                                }
                                                switch (dtVoid[j].Vol)
                                                {
                                                    case "ВН":
                                                        dt811.Rows[i]["LevelVoltageHV"] = MeterCount;
                                                        break;
                                                    case "СН-1":
                                                        dt811.Rows[i]["LevelVoltageSV-1"] = MeterCount;
                                                        break;
                                                    case "СН-2":
                                                        dt811.Rows[i]["LevelVoltageSV-2"] = MeterCount;
                                                        break;
                                                    case "НН":
                                                        dt811.Rows[i]["LevelVoltageLV"] = MeterCount;
                                                        break;
                                                    default:
                                                        dt811.Rows[i]["LevelVoltageLV"] = MeterCount;
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                dt811.Rows[i]["NetworkOrganizations"] = MeterCount;
                                            };
                                        }
                                    }
                                }
                            }
                        }
                        else // затолкаем ошибку в п....
                        { }
                    }
                }
                // отправим в конечную таблицу значения количества счетчиков больше нуля
                this.bsReport811_2019.DataSource = dt811;//.Select("MeterAll > 0"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка обработки №2: " + ex.Source);
            }

        }
        private void bgLinkAbnWithCP_2019_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.flag = true;
            if (this.flag && this.flag0)
            {
                //this.StopBackGround();
                this.dgvReport811_2019.DataSource = this.bsReport811_2019;
                this.splitContainer1.Enabled = true;
                this.tabControl1.Enabled = true;

                this.toolStrip.Enabled = true;
                this.panelProgress.Visible = false;
                this.progressBarEndLess.AutoProgress = false;
            }
        }
        //FormLinkAbnNewAndOld.ReestrObjectsSchemaForReport objectSchema_2019;
        private void FillReportCP_2019(object FullObjectsSchema)
        {
            //FullObjectsSchema - полный список объектов схемы
            objectSchema = (FormLinkAbnNewAndOld.ReestrObjectsSchemaForReport)FullObjectsSchema;
            for (int i = objectSchema.Begin; i < objectSchema.End; i++)
                ////for (int i = objectSchema.Begin; i < 1000; i++)
                {
                DataRow dataRow = this.dtReportCP.Rows[i];
                if (dataRow["idSchmObj"] != DBNull.Value)
                {
                    // находим объект (от привязки абонента) в электрической модели схемы
                    ElectricObject electricObjectById = objectSchema.ElModel.GetElectricObjectById(Convert.ToInt32(dataRow["idSchmObj"]));

                    if (
                        electricObjectById != null &&
                        (!(electricObjectById is ElectricBus) || ((ElectricBus)electricObjectById).Amperage != null) &&
                        (!(electricObjectById is ElectricLine) || ((ElectricLine)electricObjectById).AmperageCount != 0)
                        )
                    {
                        // первая точка это electricObjectById - по нему определим первую подстанцию, ее тип и напряжение
                        // если parent = null, то привязка не к ячейке, а к подстанции, либо шине
                        // SubName - имя подстанции к которой осуществлена привязка
                        string SubName = "";
                        string SubNameShort = "";

                        // listNodesDown - список - цепочка кабельных и воздушных линий от рубильника до абонента после подстанции
                        string listNodesDown = "";
                        string VoltageLineDown = "0";
                        string VoltageClass = "";
                        // соберем дерево объектов
                        // forwardDirection = false - смотрим дерево вверх к запитке
                        // forwardDirection = true - смотрим дерево внихз к подчиненным веткам
                        // withounLastCell - формирование списка из подчиненных веток - без всяких херней 

                        // если привязка к шине или подстанции, то пропускаем
                        // проверить привязку к высоковольтной ячейке
                        // привязка всегда у ячейка должна быть по идее
                        int electricObjectById_Id = electricObjectById.Id; //== 923702;
                        if (electricObjectById is ElectricLine)
                        {
                            var listNodeObjDown = objectSchema.ElModel.PoweringReportForDrawObject(electricObjectById, true, true);
                            if (listNodeObjDown != null)
                            {
                                DataRow[] row;
                                foreach (var node in listNodeObjDown)
                                {
                                    if ((ElectricObject)node is ElectricLine)
                                        if (!(((ElectricLine)node).IsCell()))
                                        {
                                            row = dtSchmCable.Select("id = " + ((ElectricObject)node).Id);
                                            if (row.Count() > 0)
                                            {
                                                listNodesDown = listNodesDown + (listNodesDown != "" ? "; " : "") + row.First()["TypeCable"] + " " + VoltageLineDown.ToString().Replace(",", ".") + " кВ " + node.ToString();//.Replace("\\", "/");
                                            }
                                        }
                                        else
                                        {
                                            row = dtSchmCell.Select("id = " + ((ElectricObject)node).Id);
                                            if (row.Count() > 0)
                                            {
                                                VoltageLineDown = Convert.ToString(row.First()["ValueME"]);
                                                if (VoltageClass == "" || VoltageClass == null) VoltageClass = Convert.ToString(row.First()["Value"]).ToString().Replace(",", ".");
                                            }
                                        }
                                }
                            }
                            // если нет родителя у ячейки, то попытаемся его заполнить
                            // у ячейки должен быть родитель подстанция (заполняем ее)
                            if (electricObjectById.Parent == null)
                            {
                                var Parents_ElectricObjectById = ((ElectricLine)electricObjectById).Ends.Where(s => s.Parent != null);
                                var FirstPoint = Parents_ElectricObjectById.First();
                                if (FirstPoint != null )
                                {
                                    // у точки родитель должна быть шина!!! у шины подстанция
                                    if (FirstPoint.Parent is ElectricBus)
                                        electricObjectById.Parent = FirstPoint.Parent.Parent;
                                    else if (FirstPoint.Parent is ElectricSubstation) // это маловероятно - но его знает
                                        electricObjectById.Parent = FirstPoint.Parent;
                                }
                            }
                        }
                        TreeNodeObj treeNodeObj = objectSchema.ElModel.PoweringReportForDrawObject(Convert.ToInt32(dataRow["idSchmObj"]), false);
                        if (treeNodeObj != null)
                        {
                            string BusCPName = "";
                            string BusCPId = "";
                            string SubCPName = "";
                            string SubCpId = "";
                            string CellCPName = "";
                            string CellCpId = "";
                            // набор - список - цепочка кабельных и воздушных линий
                            string listNodes = "";
                            // напряжение линии
                            string VoltageLine = "";
                            int num = 0;
                            // здесь ищем начало дерева - запитка и находим последнюю подстанцию по idSchmObj
                            // LeafsList - список листьев дерева (сколько их может быть?)
                            // treeNodeObj.Nodes - узел верхний - здесь можно собрать всю цепочку снизу до верху через Nodes
                            // где тип объекта искать неизвестно пока-что
                            // num - количество родителей - запиток
                            // если num > 1, то дублируем (клонируем) обрабатываемую запись
                            foreach (TreeNodeObj treeNodeObj2 in treeNodeObj.LeafsList)
                            { /*1*/
                                if (treeNodeObj2.Tag != null && treeNodeObj2.Tag is ElectricObject)
                                {
                                    if (treeNodeObj2.Parent != null && treeNodeObj2.Parent.Tag != null && treeNodeObj2.Parent.Tag is ElectricObject)
                                    {
                                        CellCPName = ((ElectricObject)treeNodeObj2.Parent.Tag).ToString();
                                        CellCpId = ((ElectricObject)treeNodeObj2.Parent.Tag).Id.ToString();
                                    }
                                    BusCPName = ((ElectricObject)treeNodeObj2.Tag).ToString();
                                    BusCPId = ((ElectricObject)treeNodeObj2.Tag).Id.ToString();
                                    if (((ElectricObject)treeNodeObj2.Tag).Parent != null)
                                    {
                                        SubCPName = ((ElectricObject)treeNodeObj2.Tag).Parent.ToString();
                                        SubCpId = ((ElectricObject)treeNodeObj2.Tag).Parent.Id.ToString();

                                        VoltageLine = Reference.Tables.GetVoltageObject(((ElectricBus)((ElectricObject)treeNodeObj2.Tag)).TypeBus);

                                        SubCPName = Reference.Tables.GetTypeSubstation(((ElectricSubstation)((ElectricObject)treeNodeObj2.Tag).Parent).TypeSubstation) + " " + VoltageLine + " кВ " + SubCPName;
                                    }
                                    if (electricObjectById.Parent != null)
                                    {
                                        SubNameShort = electricObjectById.Parent.ToString();
                                        SubName = Reference.Tables.GetTypeSubstation(((ElectricSubstation)electricObjectById.Parent).TypeSubstation) + " " + VoltageLine + " кВ " + SubNameShort;
                                    }
                                    else
                                    {
                                        SubNameShort = electricObjectById.ToString();
                                        SubName = Reference.Tables.GetTypeSubstation(((ElectricSubstation)electricObjectById).TypeSubstation) + " " + VoltageLine + " кВ " + SubNameShort;
                                    }
                                }
                                if (treeNodeObj2.GetRoot.Tag != null && treeNodeObj2.GetRoot.Nodes.Count() != 0)
                                {
                                    listNodes = GetNodesString(treeNodeObj2.GetRoot.Nodes.ElementAt(num), "", VoltageLine);
                                }
                                else
                                    listNodes = "";
                                // listNodesDown ==> не собрали/не нашли кабель до абонента/ не привязан абонент к схеме
                                if (listNodesDown == "")
                                {
                                    listNodesDown = "КЛ 0.38 кВ " + SubNameShort + @"\" + dataRow["address"].ToString();
                                    VoltageClass = "0.40000";
                                }

                                DataTable table = this.dtReportCP;
                                lock (table)
                                {
                                    if (num == 0)
                                    {
                                        dataRow["busCPName"] = BusCPName;
                                        dataRow["busCPId"] = BusCPId;
                                        dataRow["subCPName"] = SubCPName;
                                        dataRow["subCpId"] = SubCpId;
                                        dataRow["cellCPName"] = CellCPName;
                                        dataRow["cellCpId"] = CellCpId;
                                        // получим дерево линий в одной строке
                                        dataRow["listNodes"] = listNodes;
                                        dataRow["listNodesDown"] = listNodesDown;
                                        dataRow["subname"] = SubName;
                                        dataRow["highestVoltageClass"] = VoltageLine;
                                        dataRow["voltageClass"] = VoltageClass;
                                    }
                                    break; // по второму кругу не надо идти
                                }
                                //num++;
                            } /*1*/
                        }
                    }
                }
            }
        }
        #endregion
        private string GetNodesString(TreeNodeObj node, string result, string VoltageLine)
        {
            DataRow[] row;
            string res = result;
            if (node.Nodes.Count() != 0)
            {
                foreach (var nod in node.Nodes)
                {
                    // выберем только линии - ячейки и шины отсеем
                    if ((ElectricObject)nod.Tag is ElectricLine)
                        if (!(((ElectricLine)nod.Tag).IsCell()))
                        {
                            row = dtSchmCable.Select("id = " + ((ElectricObject)nod.Tag).Id);
                            if (row.Count() > 0)
                            {
                                //добавляем
                                res = res + (res != "" ? "; " : "") + row.First()["TypeCable"] + " " + VoltageLine + " кВ " + nod.Tag.ToString();
                            }
                        }
                    res = GetNodesString(nod, res, VoltageLine);
                }
            }
            return res;
        }

        private void StopBackGround()
        {
            this.dgvListLegal.DataSource = this.bsSchmAbnFull;
            this.dgvListLegalContact.DataSource = this.bsAbnContact;
            this.dgvReportCP.DataSource = this.bsReportCP;
            //this.dgvReport811_2019.DataSource = this.bsReport811_2019;
            this.splitContainer1.Enabled = true;
            this.tabControl1.Enabled = true;

            this.toolStrip.Enabled = true;
            this.panelProgress.Visible = false;
            this.progressBarEndLess.AutoProgress = false;
        }

        private void dgvReportCP_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvReportCP.AutoResizeRow(e.RowIndex);
        }

        private void toolBtnLoad_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab == this.tabPage811_2019)
                this.StartBackGroundLinkAbnWithCP_2019();
            else if (this.tabControl1.SelectedTab == this.tabPageNominalPowerCP)
            {
                this.StartBackGroundNominalPowerCP();
            }
            else
            {
                this.StartBackGroundLinkAbnWithCP();
                this.StartBackGroundLinkAbnNewAndOld();
            }
            //this.StartBackGroundLinkAbnWithCP();
        }
        /// <summary>
        /// isSimulationMode режим отображения сети; true = нормальная, false - оперативная
        /// </summary>
        private class SimulationMode
        {
            internal SimulationMode(bool isSimulationMode, DateTime dateTime)
            {
                this.IsSimulationMode = isSimulationMode;
                this.PeriodDateTime = dateTime;
            }

            internal bool IsSimulationMode;
            internal DateTime PeriodDateTime;
        }
        /// <summary>
        /// реестр объектов схемы для печати от begin до end
        /// </summary>
        private class ReestrObjectsSchemaForReport
        {
            internal ReestrObjectsSchemaForReport(int begin, int end, ElectricModel eModel)
            {
                this.Begin = begin;
                this.End = end;
                this.ElModel = eModel;
            }
            internal int Begin;
            internal int End;
            internal ElectricModel ElModel;
        }

        private void dgvReportCP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #region Расчет номинальной мощности уходящей с центров центров питания
        private void StartBackGroundNominalPowerCP()
        {
            this.panelProgress.Visible = true;
            this.progressBarEndLess.AutoProgress = true;
            this.panelProgress.Left = base.Width / 2 - this.panelProgress.Width / 2;
            this.panelProgress.Top = base.Height / 2 - this.panelProgress.Height / 2;
            this.splitContainer1.Enabled = false;
            this.tabControl1.Enabled = false;

            this.toolStrip.Enabled = false;
            this.dgvNominalPowerCP.DataSource = null;
            this.flag = false;
            // режим отображения сети
            bool isNormalSimulationMode = true;
            if (this.toolCmbTypeSchema.SelectedIndex == 0)
            {
                isNormalSimulationMode = false;
            }
            this.bgNominalPowerCP.RunWorkerAsync(new FormLinkAbnNewAndOld.SimulationMode(isNormalSimulationMode, this.dateTimePeriodKWT.Value));
        }
        private void bgNominalPowerCP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.flag = true;
            if (this.flag && this.flag0)
            {
                //this.StopBackGround();
                this.dgvNominalPowerCP.DataSource = this.bsNominalPowerCP;
                this.splitContainer1.Enabled = true;
                this.tabControl1.Enabled = true;

                this.toolStrip.Enabled = true;
                this.panelProgress.Visible = false;
                this.progressBarEndLess.AutoProgress = false;
            }
        }

        private void bgNominalPowerCP_DoWork(object sender, DoWorkEventArgs e)
        {
            References.SchemeTables.GetTransformerSchmObj(this.dtSchmTr, SqlSettings);

            this.dsSchemeReports1.tNominalPower.Clear();
            DataTable tNominalPower = this.dsSchemeReports1.tNominalPower;

            ModelN.ElectricModel electricModel = new ModelN.ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            //electricModel.LoadSchema(Convert.ToDateTime(e.Argument));
            electricModel.LoadSchema(((FormLinkAbnNewAndOld.SimulationMode)e.Argument).IsSimulationMode);
            // составим список центров питания
            var s1 = electricModel.Objects.Where(w => w.GetType().Equals(typeof(ModelN.ElectricSubstation)));
            var schmObjCp = s1.Where(w => ((ModelN.ElectricSubstation)w).TypeSubstation.Equals(ModelN.eTypeRectangleTool.CP));
            foreach (var itemCP in schmObjCp)
            {
                // Выдерним все ячейки центров питания
                var c1 = itemCP.ChildObjects.Where(w => w.GetType().Equals(typeof(ModelN.ElectricLine)));
                var schmObjCell = c1.Where(w => ((ModelN.ElectricLine)w).IsCell() == true);
                
                // и выбрать только отходящие надо - по малому вольтажу (не факт)
                foreach (var itemCell in schmObjCell)
                {
                    int idScmhObj = itemCell.Id;
                    ModelNCalc.TreeNodeObj treeNodeObj_ = electricModel.PoweringReportForDrawObject(idScmhObj, true);
                    // подчиненные трансформаторы
                    List<int> listTrans = new List<int>();
                    this.FillTreeNodeTrans(treeNodeObj_, listTrans);
                    // Мощность посчитаем
                    int SumPower = 0;
                    foreach (int idTr in listTrans)
                    {
                        DataRow[] array = dtSchmTr.Select("id = " + idTr.ToString());
                        if (array.Length != 0)
                        {
                            if (array[0]["Мощность"] != DBNull.Value && !string.IsNullOrEmpty(array[0]["Мощность"].ToString()))
                            {
                                SumPower += Convert.ToInt32(array[0]["Мощность"]);
                            }
                        }
                    }

                    DataRow dataRow = tNominalPower.NewRow();
                    dataRow["subCPName"] = electricModel.GetParamsElectricObjectById(itemCell.Id).ElectricLineName;
                    dataRow["PowerSetCP"] = SumPower;
                    tNominalPower.Rows.Add(dataRow);
                }

                //
            }
            // отправим в конечную таблицу значения количества счетчиков больше нуля
            this.bsNominalPowerCP.DataSource = tNominalPower;

        }
        /// <summary>
        /// Заполнить дерево трансформаторами
        /// </summary>
        private void FillTreeNodeTrans(ModelNCalc.TreeNodeObj treeNodeObj, List<int> listTrans)
        {
            if (treeNodeObj.Tag != null && treeNodeObj.Tag is ModelN.ElectricLine)
            {
                foreach (ModelN.ElectricRelation electricRelation in ((ModelN.ElectricLine)treeNodeObj.Tag).Relations)
                {
                    foreach (ModelN.ElectricObject electricObject in electricRelation.ChildObjects)
                    {
                        if (electricObject is ModelN.ElectricSwitch && ((ModelN.ElectricSwitch)electricObject).TypeSwitch == ModelN.TypeSwitch.TransformerTool && !listTrans.Contains(electricObject.Id))
                        {
                            listTrans.Add(electricObject.Id);
                        }
                    }
                }
            }
            foreach (var Obj in treeNodeObj.Nodes)
            {
                this.FillTreeNodeTrans(Obj, listTrans);
            }
        }
        #endregion
    }
}
