using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FormLbr.Classes;
using System.Linq;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using ControlsLbr;
using SchemeModelN;
using SchemeModelN.Calculations;
using Library;
using Logger;
using System.Xml;

namespace Calculat
{
    public partial class FormReportObjLink : FormLbr.FormBase
    {
        //private bool flag;

        public FormReportObjLink()
        {
            InitializeComponent();
        }

        private void FormReportObjLink_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsDop1, dsDop1.tG_PeriodCalc, true);
            //            dtBegin.Value = new DateTime((int)dsDop1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsDop1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            //            dtEnd.Value = new DateTime((int)dsDop1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsDop1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
            dtBegin.Value = new DateTime(DateTime.Today.Year, 1, 1);
            //dtEnd.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month + 1, 1).AddDays(-1);
            dtEnd.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
#if !DEBUG
            this.grpLogger.Visible = false;
            this.rtLogger.Visible = false;
#endif
            this.chkSelectOneLink.Visible = false;
            base.LoadFormConfig(null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
#if DEBUG
            FillReport();
#else

            this.tsbExcel.Enabled = false;
            this.tsbExcel2.Enabled = false;
            this.tsbPrint.Enabled = false;
            this.dgv1.Enabled = false;
            this.groupBox1.Enabled = false;
            this.btnCancel.Enabled = false;
            this.btnOK.Enabled = false;

            //this.flag = false;

            this.backgroundWorker.RunWorkerAsync();
#endif
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Log.Write(LogLevel.Info, "FormReportObjLink", "FormReportObjLink", "FillReport", "Начало");
            FillReport();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
                this.tsbExcel.Enabled = true;
                this.tsbExcel2.Enabled = true;
                this.tsbPrint.Enabled = true;
                this.dgv1.Enabled = true;
                this.groupBox1.Enabled = true;
                this.btnCancel.Enabled = true;
                this.btnOK.Enabled = true;

            this.bs.DataMember = "tG_ReportMain_Link";
            this.bs.DataSource = this.dsDop1;

            base.SaveFormConfig(null);

        }
        /// <summary>
        /// ПривЯзка idSchmObj к центру питания и принадлежность к подстанции
        /// </summary>
        private class linkScmhObj
        {
            public string CPName;
            public string CellCPName;
            public string TPName;
            public string CellTPName;
            public int idSchmObj;
        }
 
        private void FillReport()
        {
#if DEBUG
            this.Cursor = Cursors.WaitCursor;
            rtLogger.Clear();
            rtLogger.AppendText($"Начало: {DateTime.Now}\r\n");
            rtLogger.AppendText($"Грузим расчеты: {DateTime.Now}\r\n");
            Application.DoEvents();
#else

            Log.Write(LogLevel.Info, "FormReportObjLink", "FormReportObjLink", "FillReport", "Грузим расчеты");
#endif

            dsDop1.tG_ReportMain_Link.Rows.Clear();
            // получаем данные по начислениям
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";

                strCmd = "select * from [fn_LegReportMain_Link-3](@DateBegin, @DateEnd) order by codeabonent";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsDop1, "tG_ReportMain_Link");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
#if DEBUG
            rtLogger.AppendText($"Грузим электрическую модель схемы: {DateTime.Now}\r\n");
            Application.DoEvents();
#else
            Log.Write(LogLevel.Info, "FormReportObjLink", "FormReportObjLink", "FillReport", "Грузим электрическую модель схемы");
#endif
            // теперь получаем данные по привязкам объектов
            ElectricModel electricModel = new ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            electricModel.LoadSchema(true);
#if DEBUG
            rtLogger.AppendText($"Заполняем привязки к схеме и центры питания: {DateTime.Now}\r\n");
            Application.DoEvents();
#else
            Log.Write(LogLevel.Info, "FormReportObjLink", "FormReportObjLink", "FillReport", "Заполняем привязки к схеме и центры питания");
#endif
            int? idSchmObj = null;
            int idAbnObj = 0;
            DateTime? dtPay = null;
            int row_number = 1;
            // список точек привязки к центрам питания
            Dictionary<int, linkScmhObj> listSchmPointCP = new Dictionary<int, linkScmhObj>();
            // список объектов абонентов с привязкой к объектам схемы
            Dictionary<int, linkScmhObj> listAbnObjScmhObjLink = new Dictionary<int, linkScmhObj>();
            //  общий объем по объекту, его надо воткнуть в строу где встречается первая запись с ненулевым объемом по счетчиком
            //  SizeKWT = объем счетчика
            int Quantity = 0;
            //////////// список объектов (для расчета количества привязок)
            //////////Dictionary<int, int> listIdAbnObj = dsDop1.tG_ReportMain_Link.AsEnumerable()
            //////////    .GroupBy(g => g.idAbnObj)
            //////////    .Select(s => new { s.Key, Count = s.Count() })
            //////////    .ToDictionary(d => d.Key, d => d.Count);
            // listIdAbnObjMitIdSchmObj - список объектов c последней привязкой (для заполнения пустых полей привязками) (v. 1)
            //var listIdAbnObjMitIdSchmObj = dsDop1.tG_ReportMain_Link
            //                .OrderBy(o => o.idAbnObj).ThenByDescending(t => t.idSchmObj)
            //                .GroupBy(x => x.idAbnObj)
            //                .SelectMany(g =>
            //                   g.Select((j, i) => new { j.idAbnObj, j.idSchmObj, idSchmObjNormal = g.First().idSchmObj, idRowGroup = i + 1 }))
            //                //.ToList()
            //                //.ToDictionary(d => d.idAbnObj, d =>  new {d.idSchmObj, d.idSchmObjNormal, d.idRowGroup });
            //                .ToDictionary(d => new { d.idAbnObj, d.idRowGroup }, d => new { d.idSchmObj, d.idSchmObjNormal, d.idRowGroup });
            //;
            // listIdAbnObjMitIdSchmObj - список объектов c последней привязкой (для заполнения пустых полей привязками) (v. 2)
            var list1 = dsDop1.tG_ReportMain_Link
                            .OrderBy(o => o.idAbnObj).ThenByDescending(t => t.idSchmObj)
                            .GroupBy(x => x.idAbnObj)
                            .SelectMany(g =>
                               g.Select((j, i) => new { j.idAbnObj, j.idSchmObj, idSchmObjNormal = g.First().idSchmObj, idRowGroup = i + 1 }))
                                 ;
            var listIdAbnObjMitIdSchmObj = list1.GroupBy(y => new { y.idAbnObj, y.idSchmObjNormal })
                .Select(s => new { s.Key.idSchmObjNormal, s.Key.idAbnObj, linksSchmObj =  s.Select(p => new {p.idSchmObj, p.idRowGroup }) })
                .ToDictionary(t => t.idAbnObj, t=> new { t.idSchmObjNormal, linksSchmObj = t.linksSchmObj.ToList()});
            // listIdAbnObjMitIdSchmObj - список объектов c последней привязкой (для заполнения пустых полей привязками) (v. 3)
            // Поле Normal определяет так называемое нормальное присоединение
            // надо сделать запрос так чтобы idSchmObjNormal определился из  g.First().idSchmObj 
            // либо если поле Normal заполнено true либо 1

            // параметр для формирования в гриде "матросски"
            int isFormatCellStatus = 0;
            foreach (DataRow row in dsDop1.tG_ReportMain_Link.Rows)
            {
                #region Блок для размазывания суммы начисления объекта по строкам
                //Application.DoEvents();
                // формируем в гриде "матросску"
                if (idAbnObj != Convert.ToInt32(row["idAbnObj"]))
                {
                    isFormatCellStatus = isFormatCellStatus == 1 ? 0 : 1;
                }
                row["isFormatCellStatus"] = isFormatCellStatus;

                if (idAbnObj == Convert.ToInt32(row["idAbnObj"]) && dtPay == Convert.ToDateTime(row["dtPay"]))
                {
                    row_number = row_number + 1;
                    // row["Quantity"] = 0;
                }
                else
                {
                    idAbnObj = Convert.ToInt32(row["idAbnObj"]);
                    dtPay = Convert.ToDateTime(row["dtPay"]);
                    Quantity = Convert.ToInt32(row["Quantity"]);
                    row_number = 1;
                }
                row["Quantity"] = 0;
                if (row["SizeKWT"] != DBNull.Value)
                    if (Convert.ToInt32(row["SizeKWT"]) != 0)
                    {
                        row["Quantity"] = Quantity;
                        Quantity = 0;
                    }
                // значение должны найти в любом случае
                // это количество записей (счетчиков и привязок) объектно
                // int countIdAbnObj = listIdAbnObj.Where(w => w.Key == Convert.ToInt32(row["idAbnObj"])).Select(s => s.Value).First();
                //int countIdAbnObj = listIdAbnObj[Convert.ToInt32(row["idAbnObj"])];
                int countIdAbnObj = listIdAbnObjMitIdSchmObj[idAbnObj].linksSchmObj.Count;
                if (row_number == countIdAbnObj)
                {
                    if (Quantity != 0)
                        row["Quantity"] = Quantity;
                }
                row["rowSubAbnObj"] = row_number;
                #endregion

                try
                {
                    if (row["idSchmObj"] != DBNull.Value  && (int)row["idSchmObj"] !=0)
                    {
                        idSchmObj = (int)row["idSchmObj"];

                        //var test = listSchmPointCP.Where(w=> w.Key==[(int)idSchmObj]);
                        var ElectricObject = electricModel.GetParamsElectricObjectById((int)idSchmObj);
                        //ElectricObject electricObjectById = electricModel.GetElectricObjectById((int)idSchmObj);
                        row["TP"] = ElectricObject.ElectricSubName;
                        if (ElectricObject.electricObject is SchemeModelN.ElectricLine)
                        {
                            row["TPCell"] = ElectricObject.electricLine.ToString();
                        }

                        //if (row["subid"] != DBNull.Value)
                        //{
                        //    var SubStation = electricModel.GetParamsElectricObjectById((int)row["subid"]);
                        //    row["TP"] = SubStation.ElectricSubName;
                        //}
                        // electricModel.GetParamsElectricObjectById(972609).electricObject is SchemeModelN.ElectricLine

                        // 0. Может сделать параллельную обработку
                        // 2. проверить пустые привязки за прошлые период у объектов
                        // 3. присоединить отчет (сводный)
                        if (ElectricObject.electricObject != null)
                        {
                            // 1. если привязка была, то ищем ее в списке
                            var centerPower = listSchmPointCP.Where(w => w.Key == ElectricObject.electricObject.Id);
                            if (centerPower != null && centerPower.Count() > 0)
                            {
                                row["CPName"] = centerPower.First().Value.CPName;
                                row["CellCPName"] = centerPower.First().Value.CellCPName;
                            }
                            else // 4. ищем центр питания по объекту схему
                            {
                                // 4.1. Проверим еще  способ получения центра питания
                                // соберем дерево объектов до верхушки
                                var treeNodeObj = electricModel.PoweringReportForDrawObject((int)idSchmObj, false);
                                // переменная для расчета основным способом
                                bool isSecondaryCalc = true;
                                if (treeNodeObj != null) isSecondaryCalc = false;
                                if (!isSecondaryCalc)
                                {
                                    // возьмем список веток у родителя дерева
                                    var LeafsList = treeNodeObj.GetRoot.LeafsList;
                                    if (LeafsList.Count() > 0)
                                    {
                                        // возьмем последний элемент в списке веток (это в том случае если не полная привязка)
                                        var firstElement = LeafsList.Last();
                                        if (firstElement.Tag != null && firstElement.Tag is ElectricObject)
                                        {
                                            /// Ячейка запитки от центра питания
                                            if (firstElement.Parent != null && firstElement.Parent.Tag != null && firstElement.Parent.Tag is ElectricObject)
                                            {
                                                row["CPName"] = ((SchemeModelN.ElectricObject)firstElement.Tag).Parent.FullName;
                                                row["CellCPName"] = firstElement.Parent.Tag;
                                            }
                                        }
                                    }
                                    // if (LeafsList.Count() > 1)  {  }
                                    // Если есть хотя бы одна ветка (LeafsList), значит есть центр питания
                                    // и следующее условие отрабатывать не надо
                                }
                                if (isSecondaryCalc)
                                {
                                    // var listNameCP = GetCellsCP(electricModel, (int)idSchmObj);
                                    // var ppp = electricModel.PoweringReportForDrawObject(ElectricObject.electricObject, true, true);
                                    // var ppp = electricModel.PoweringReportForDrawObject(ElectricObject.electricObject.Id, true);
                                    var listSchmObj = electricModel.GetCellCP((int)idSchmObj);
                                    if (listSchmObj != null)
                                        if (listSchmObj.Length > 0)
                                        {
                                            if (listSchmObj[0].ElectricSubName != null)
                                                row["CPName"] = listSchmObj[0].ElectricSubName;
                                            if (listSchmObj[0].electricLine != null)
                                                row["CellCPName"] = listSchmObj[0].electricLine.ToString();
                                        }
                                }
                                // добавляем в список привязки объекта схемы к центру питания
                                listSchmPointCP.Add(ElectricObject.electricObject.Id, new linkScmhObj { CPName = row["CPName"].ToString(), CellCPName = row["CellCPName"].ToString(), TPName = row["TP"].ToString(), CellTPName = row["TPCell"].ToString() });
                                // добавим в список привязку объекта абонента к объекту схемы
                                // один объект одна привязка
                                // хоть что-нибудь
                                var AbnObjScmhObjLink = listAbnObjScmhObjLink.Where(w => w.Key == idAbnObj);
                                if (AbnObjScmhObjLink == null || AbnObjScmhObjLink.Count() == 0)
                                    listAbnObjScmhObjLink.Add(idAbnObj, new linkScmhObj { idSchmObj = ElectricObject.electricObject.Id, TPName = row["TP"].ToString(), CellTPName = row["TPCell"].ToString(), CPName = row["CPName"].ToString(), CellCPName = row["CellCPName"].ToString() });
                            }
                        }
                    }
                    else // привязки к схеме нет
                    {
                        // если объект абонента есть, то можно найти привязку в схеме (если есть)
                        var linkSchmObj = listAbnObjScmhObjLink.Where(w => w.Key == idAbnObj);
                        if (linkSchmObj != null && linkSchmObj.Count() > 0)
                        {
                            row["CPName"] = linkSchmObj.First().Value.CPName;
                            row["CellCPName"] = linkSchmObj.First().Value.CellCPName;
                            row["TP"] = linkSchmObj.First().Value.TPName;
                            row["TPCell"] = linkSchmObj.First().Value.CellTPName;
                            row["idSchmObj"] = linkSchmObj.First().Value.idSchmObj;
                        }
                        //var linkSchmObj = listAbnObjScmhObjLink[idAbnObj];
                        //if (linkSchmObj != null)
                        //{
                        //    row["CPName"] = linkSchmObj.CPName;
                        //    row["CellCPName"] = linkSchmObj.CellCPName;
                        //    row["TP"] = linkSchmObj.TPName;
                        //    row["TPCell"] = linkSchmObj.CellTPName;
                        //    row["idSchmObj"] = linkSchmObj.idSchmObj;
                        //}
                    }
                    // заполним данные по псевдо-нормальной схеме, последняя привязка будет нормальной 
                    // исходим из того, что объект абонента привязан к одной подстанции
                    // на будущее может поставить в объекте признак нормально схемы
                    var linkNormal = listIdAbnObjMitIdSchmObj[idAbnObj]; // объект абонента всегда есть
                    // выберем привязку в строке 1 (она всегда одна)
                    int idSchmObjNormal = linkNormal.idSchmObjNormal;
                    row["idSchmObjNormal"] = idSchmObjNormal;
                    if (idSchmObjNormal != 0)
                    {
                        var centerPower = listSchmPointCP.Where(w => w.Key == idSchmObjNormal);
                        if (centerPower != null && centerPower.Count() > 0)
                        {
                            row["CPNameNormal"] = centerPower.First().Value.CPName;
                            row["CellCPNameNormal"] = centerPower.First().Value.CellCPName;
                            row["TPNormal"] = centerPower.First().Value.TPName;
                            row["TPCellNormal"] = centerPower.First().Value.CellTPName;
                        }
                        else
                        {
                            var ElectricObject = electricModel.GetParamsElectricObjectById(idSchmObjNormal);
                            row["TPNormal"] = ElectricObject.ElectricSubName;
                            if (ElectricObject.electricObject is SchemeModelN.ElectricLine)
                            {
                                row["TPCellNormal"] = ElectricObject.electricLine.ToString();
                            }
                            var treeNodeObj = electricModel.PoweringReportForDrawObject((int)idSchmObjNormal, false);
                            if (treeNodeObj != null)
                            {
                                // возьмем список веток у родителя дерева
                                var LeafsList = treeNodeObj.GetRoot.LeafsList;
                                if (LeafsList.Count() > 0)
                                {
                                    // возьмем последний элемент в списке веток (это в том случае если не полная привязка)
                                    var firstElement = LeafsList.Last();
                                    if (firstElement.Tag != null && firstElement.Tag is ElectricObject)
                                    {
                                        /// Ячейка запитки от центра питания
                                        if (firstElement.Parent != null && firstElement.Parent.Tag != null && firstElement.Parent.Tag is ElectricObject)
                                        {
                                            row["CPNameNormal"] = ((SchemeModelN.ElectricObject)firstElement.Tag).Parent.FullName;
                                            row["CellCPNameNormal"] = firstElement.Parent.Tag;
                                        }
                                    }
                                }
                            }
                            // добавляем в список привязки объекта схемы к центру питания
                            listSchmPointCP.Add(idSchmObjNormal, new linkScmhObj { CPName = row["CPNameNormal"].ToString(), CellCPName = row["CellCPNameNormal"].ToString(), TPName = row["TPNormal"].ToString(), CellTPName = row["TPCellNormal"].ToString() });
                        }
                    }
                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + ": " + idSchmObj.ToString(), "Ошибка", MessageBoxButtons.OK);
            }
        }
#if DEBUG
            rtLogger.AppendText($"Окончание: {DateTime.Now}\r\n");
            Application.DoEvents();
            this.Cursor = Cursors.Default;

            this.bs.DataMember = "tG_ReportMain_Link";
            this.bs.DataSource = this.dsDop1;
#else
            Log.Write(LogLevel.Info, "FormReportObjLink", "FormReportObjLink", "FillReport", "Окончание");
#endif
            //
        }

        // Экспорт в Excel
        private void cmdExcel_Click(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                // добавляем книгу и лист
                xlApp = new Excel.ApplicationClass();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlApp.Visible = false;


                //int ColCount = dataGridView1.Columns.Count;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:E").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:E").Font.Size = 10;

                // шрифт для наименования отчета
                xlWorkSheet.get_Range("A1", "H2").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A1", "H2").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "H2").Font.Size = 12;

                // наименование отчета
                xlWorkSheet.get_Range("A1", "H1").Merge(misValue);
                xlWorkSheet.get_Range("A1", "H1").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "H1").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "H1").Value2 = "Ведомость по передаче электроэнергии по сетям МУП УльГЭС";

                xlWorkSheet.get_Range("A2", "H2").Merge(misValue);
                xlWorkSheet.get_Range("A2", "H2").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "H2").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "H2").Value2 = "за период с " + dtBegin.Value.Date.ToShortDateString() + " по " + dtEnd.Value.Date.ToShortDateString();

                int i = 0;
                int j = 0;
                int k = 4;

                k = k + 2;
                // заголовок таблицы

                xlWorkSheet.get_Range("A" + k, misValue).Value2 = "Код";
                xlWorkSheet.get_Range("B" + k, misValue).Value2 = "Потребитель";
                xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Объект";
                xlWorkSheet.get_Range("D" + k, misValue).Value2 = "Пит.центр";
                xlWorkSheet.get_Range("E" + k, misValue).Value2 = "Ячейка";
                xlWorkSheet.get_Range("F" + k, misValue).Value2 = "Подстанция";

                int n = 7;

                int count_month = 0;
                if (dtEnd.Value.Month > dtBegin.Value.Month)
                    count_month = dtEnd.Value.Month - dtBegin.Value.Month + 1;
                else
                    count_month = 12 - dtBegin.Value.Month + dtEnd.Value.Month + 1;

                for (i = 1; i <= count_month; i++)
                {
                    xlWorkSheet.Cells[k, n] = dtBegin.Value.Date.AddMonths(i).AddDays(-1);
                    n += 1;
                }

                // установим ширину столбцов
                xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 8;
                xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 40;
                xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 40;
                xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 40;
                xlWorkSheet.get_Range("E:E", misValue).ColumnWidth = 10;
                xlWorkSheet.get_Range("F:F", misValue).ColumnWidth = 20;

                // вывод данных в ячейки
                int m = dgv1.RowCount;
                int idObj = 0;
 //               int idSub = 0;
 //               int idSchm = 0;
                int first_col = dtBegin.Value.Month;
                int ncol = 0;
                int nrowsheet = k + 1;
                int[] total_sum = new int[count_month + 7];

                for (i = 0; i < m - 1; i++)
                {
                    if ((Int32)dgv1[8, i].Value != idObj) 
                        //& (Int32)dgv1[9, i].Value != idSchm & (Int32)dgv1[10, i].Value != idSub)
                    {
                        nrowsheet += 1;
                        idObj = (Int32)dgv1[8, i].Value;
//                        idSchm = (Int32)dgv1[9, i].Value;
//                        idSub = (Int32)dgv1[10, i].Value;

                        xlWorkSheet.Cells[nrowsheet, 1] = dgv1[0, i].Value;
                        xlWorkSheet.Cells[nrowsheet, 2] = dgv1[1, i].Value;
                        xlWorkSheet.Cells[nrowsheet, 3] = dgv1[2, i].Value;
                        xlWorkSheet.Cells[nrowsheet, 4] = dgv1[3, i].Value;
                        xlWorkSheet.Cells[nrowsheet, 5] = dgv1[4, i].Value;
                        xlWorkSheet.Cells[nrowsheet, 6] = dgv1[5, i].Value;
                    }
                    int mec = Convert.ToDateTime(dgv1[6, i].Value).Month;
                    if (mec < first_col)
                        ncol = (12 - first_col) + 7 + mec;
                    else
                        ncol = mec - first_col + 7;
                    xlWorkSheet.Cells[nrowsheet, ncol] = dgv1[7, i].Value;
                    //total_sum[ncol] = total_sum[ncol] + Convert.ToInt32(dgv1[7, i].Value);
                }

                //xlWorkSheet.Cells[nrowsheet + 1, 2] = "Итого";
                //for (i = 3; i < total_sum.Length; i++)
                //{
                //    xlWorkSheet.Cells[nrowsheet + 1, i] = total_sum[i];
                //}

                // форматирование данных
                xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "Общий";
                xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "Общий";
                //xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "### ##0";

                //xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[nrowsheet + 1, count_month + 3]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[nrowsheet + 1, count_month + 3]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                //k = nrowsheet + 3;
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).Merge(misValue);
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).VerticalAlignment = Excel.Constants.xlCenter;
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).HorizontalAlignment = Excel.Constants.xlCenter;
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).Value2 = "Начальник службы контроля и учета электрической энергии";

                xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                //xlWorkSheet.PageSetup.LeftMargin = 80;
                xlWorkSheet.PageSetup.RightMargin = 25;
                xlWorkSheet.PageSetup.BottomMargin = 25;
                xlWorkSheet.PageSetup.TopMargin = 25;

                this.Cursor = Cursors.Default;
                xlApp.Visible = true;
            }
            else
                MessageBox.Show("Нет данных для отчета ..");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(1).AddDays(-1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(-1).AddDays(-1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            FormReportObjLinkPrint frm = new FormReportObjLinkPrint()
            {
                SqlSettings = this.SqlSettings,
                MdiParent = base.MdiParent,
                FormParent = this

            };
            frm.TableReport = dsDop1.tG_ReportMain_Link;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.dgv1.ExportToExcel();
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            int CodeAbn = Convert.ToInt32(dgv1.CurrentRow.Cells["codeAbonent"].Value);
            if (dgv1.CurrentRow.Cells["TypeAbn"].Value.ToString() == "Потребитель ФЛ")
            {
                int AbnType = (int)Constants.AbnType.Private;

                Prv.Forms.Abonent.FormAbonent frm = new Prv.Forms.Abonent.FormAbonent(CodeAbn, AbnType);
                frm.SqlSettings = this.SqlSettings;
                frm.MdiParent = this.MdiParent;

                frm.Show();
            }
            else
            {
                int idObj = Convert.ToInt32(dgv1.CurrentRow.Cells["idAbnObj1"].Value);
                Legal.Forms.FormAbn frm = new Legal.Forms.FormAbn(CodeAbn, idObj);
                frm.SqlSettings = this.SqlSettings;
                frm.MdiParent = this.MdiParent;

                frm.Show();
            }
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            base.SaveFormConfig(null);
            this.Close();
        }
        private void FormReportObjLink_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }
        private void Dgv1_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
                // if (Convert.ToInt32(this.dgv1[this.idAbnObj1.Name, e.RowIndex].Value) % 2 == 0)
                if (Convert.ToInt32(this.dgv1[this.isFormatCellStatusDataGridViewTextBoxColumn.Name, e.RowIndex].Value) == 1)
                {
                    e.CellStyle.BackColor = Color.LightGray;
                }
        }
        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDocument.AppendChild(newChild);
            XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
            xmlDocument.AppendChild(xmlNode);

            return xmlDocument;
        }
        protected override void ApplyConfig(XmlDocument doc)
        {
            XmlNode xmlNode = doc.SelectSingleNode(base.Name);
            if (xmlNode == null)
            {
                return;
            }
        }
    }
}
