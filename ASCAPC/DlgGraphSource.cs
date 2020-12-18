using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using FormLbr;
using FormLbr.Classes;

namespace ASCAPC
{
    public partial class DlgGraphSource : FormBase
    {
        SQLSettings settingsTok5;
        SqlDataCommand commandTok5;
        /// <summary>
        /// Тип расчета (какими данными заполняем гриды)
        /// </summary>
        string calculationType;

        public DlgGraphSource()
        {
            InitializeComponent();

            IDC_RADIO_POWER.Checked = true;
            Text = "Поступления в сети МУП УльГЭС";

            //settingsTok5 = new SQLSettings("ulges-sql", "Tok_5", "WINDOWS", "", "");
            settingsTok5 = new SQLSettings(new SQLSettingsTok5());
            commandTok5 = new SqlDataCommand(settingsTok5);

            dateTimePicker1_ValueChanged(null, null);
        }

        private void CreateTabPage(string name, int tabIndex)
        {
            // 1. сначало грид
            ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgv = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter
            {
                ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                Dock = System.Windows.Forms.DockStyle.Fill,
                Name = "dgv" + tabIndex,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoGenerateColumns = false,
                NumbLineVisible = true,
                ReadOnly = true,
            };
            dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);

            DataGridViewRow row = dgv.RowTemplate;
            row.Height = 16;
            row.ReadOnly = true;
            row.Resizable = System.Windows.Forms.DataGridViewTriState.False;

            foreach (DataGridViewColumn dgvCol in dataGridView1.Columns)
                dgv.Columns.Add((DataGridViewColumn)dgvCol.Clone());

            // 2. теперь вкладку
            TabPage tabPage3 = new TabPage();
            tabPage3.Controls.Add(dgv);
            tabPage3.Name = "tabPage" + tabIndex;
            tabPage3.Text = name;
            tabPage3.Tag = tabIndex;
            tabPage3.UseVisualStyleBackColor = true;

            this.tabControl1.Controls.Add(tabPage3);

            // 3. Удалим первую вкладку
            tabControl1.Controls.Remove(this.tabPage1);

        }

        private void DlgGraphSource_Load(object sender, EventArgs e)
        {
            // сформируем вкладки
            DataTable table = commandTok5.SelectSqlData("CONFIG", false, "", null);

            foreach (DataRow row in table.Rows)
            {
                CreateTabPage(row["Name"].ToString(), (short)row["ID_CONFIG"]);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // номер записи в конфигурационной таблице CONFIG (вкладка на форме) 
            string iCurrConfig = Convert.ToInt32(tabControl1.SelectedTab.Tag).ToString();
            if (iCurrConfig == "") return;
            string sMonth = dateTimePicker1.Value.Month.ToString();
            string sYear = dateTimePicker1.Value.Year.ToString();

            // данные текущего месяца
            DataTable table = new DataSet.dsASCAPC.rptEnergyConsumptionDataTable();
            

            //// флаг указавающий использовать показания следующего месяца, если рассматриваем предыдущие периоды
            bool flagNext = false;
            DateTime dateNext = dateTimePicker1.Value.AddMonths(1); // дата следующего месяца
            DataTable tableNextMonth = new DataSet.dsASCAPC.rptEnergyConsumptionNextDataTable();

            //// флаг указавающий заполнение показаниями предыдущего месяца, если первый день текущего месяца пустой
            bool flagPrev = false;
            DateTime datePrev = dateTimePicker1.Value.AddMonths(-1); // дата предыдущего месяца
            DataTable tableMonthPrev = new DataSet.dsASCAPC.rptEnergyConsumptionPrevDataTable();

            calculationType = panel1.Controls.OfType<RadioButton>().Where(p => p.Checked).Select(r => r.Name).FirstOrDefault();
            switch (calculationType)
            {
                case ("IDC_RADIO_POWER"):
                    // Мощность (IDC_RADIO_POWER)
                    table = commandTok5.SelectSqlData(@"SELECT OBJECT_CODE, OBJECT_NAME, NODE_CODE, NODE_NAME, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20, D21, D22, D23, D24, D25, D26, D27, D28, D29, D30, D31 " +
                        "FROM dbo.fn_PowerPerDay_Pivot(" + sMonth + ", " + sYear + ") WHERE VIS" + iCurrConfig + " <> 0 ORDER BY OBJECT_NAME, NODE_NAME");
                    table.Columns.Add("Total", typeof(Double));
                    table.Columns.Add("Forecast", typeof(Double));
                    foreach (DataRow row in table.Rows)
                    {
                        // Переменная для суммирования нарастающим итогом
                        double sum = 0;
                        foreach (DataColumn col in table.Columns)
                        {
                            System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex(@"D([1-9]{1}$|[1-2]{1}[0-9]{1}$|30$|31$)");
                            if (rgx.Match(col.ToString()).Value != "")
                            {
                                if (row[col].ToString() != "")
                                {
                                    sum = sum + Convert.ToDouble(row[col]);
                                }
                            }
                        }
                        row["Total"] = sum;
                    }
                    break;
                case ("IDC_RADIO_SUMENERGY"):
                    // Сумм. энергия (IDC_RADIO_SUMENERGY)
                    table = commandTok5.SelectSqlData("SELECT OBJECT_CODE, OBJECT_NAME, NODE_CODE, NODE_NAME, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20, D21, D22, D23, D24, D25, D26, D27, D28, D29, D30, D31 FROM dbo.fn_PowerPerDay_Pivot(" + sMonth + ", " + sYear + ") WHERE VIS" + iCurrConfig + "<>0 ORDER BY OBJECT_NAME, NODE_NAME");
                    table.Columns.Add("Total", typeof(Double));
                    table.Columns.Add("Forecast", typeof(Double));
                    foreach (DataRow row in table.Rows)
                    {
                        // Переменная для суммирования нарастающим итогом
                        double sum = 0;
                        foreach (DataColumn col in table.Columns)
                        {
                            System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex(@"D([1-9]{1}$|[1-2]{1}[0-9]{1}$|30$|31$)");
                            if (rgx.Match(col.ToString()).Value != "")
                            {
                                if (row[col].ToString() != "")
                                {
                                    sum = sum + Convert.ToDouble(row[col]);
                                    row[col] = sum;
                                }
                            }
                        }
                        row["Total"] = sum;
                    }

                    break;
                case ("IDC_RADIO_COUNTER"):
                    // Счетчики (IDC_RADIO_COUNTER)
                    // 1. собираем показания счетчиков на начало дня
                    // 2. произвести расчет объема потребления, как разницу между показаниями
                    // для расчета последнего дня брать начальные показания следующего месяца (если они не в первый день, расчет по среднему)
                    // если в первый день начальные показания пустые, то берем предыдущий месяц
                    // делать проверку на текущий месяц
                    table = commandTok5.SelectSqlData("SELECT OBJECT_CODE, OBJECT_NAME, NODE_CODE, NODE_NAME, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20, D21, D22, D23, D24, D25, D26, D27, D28, D29, D30, D31 " +
                        "FROM dbo.fn_Counters_Pivot(" + sMonth + ", " + sYear + ") WHERE VIS" + iCurrConfig + "<>0  ORDER BY OBJECT_NAME, NODE_NAME");
                    table.Columns.Add("Total", typeof(Double));
                    table.Columns.Add("Forecast", typeof(Double));

                    //// выдерним следующий месяц
                    //// если расчитываем период меньше текущего 
                    ////// флаг указавающий заполнение показаниями учитывая первый день следующего месяца
                    if (new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1) < new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, 1))
                    {
                        flagNext = true;

                        string sMonthNext = dateNext.Month.ToString();
                        string sYearNext = dateNext.Year.ToString();
                        tableNextMonth = commandTok5.SelectSqlData("SELECT OBJECT_CODE, OBJECT_NAME, NODE_CODE, NODE_NAME, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20, D21, D22, D23, D24, D25, D26, D27, D28, D29, D30, D31 FROM dbo.fn_Counters_Pivot(" + sMonthNext + ", " + sYearNext + ") WHERE VIS" + iCurrConfig + "<>0 ORDER BY OBJECT_NAME, NODE_NAME");
                    }

                    foreach (DataRow row in table.Rows)
                    {

                        double ValBeg = 0; // ValBeg записывается в базу со времененем 00:00 (начало суток)
                        double ValEnd = 0; // надо найти объем в последнем числе диапозона -- как вариант из следующего месяца, либо по среднему
                        
                        int numberEmptyEnd = 0; // количество пустых дней в конце текущего  месяца
                        int numberEmptyBeg = 0; // количество пустых дней в начале текущего  месяца
                        int numberEmptyPrev = 0; // количество пустых дней в конце предыдущего месяца

                        for (int i = 1; i <= DateTime.DaysInMonth(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month); i++)
                        {
                            string col1 = "D" + i;
                            if (row[col1].ToString() != "")
                            {
                                numberEmptyEnd = 0;
                                if (ValBeg == 0)
                                    ValBeg = Convert.ToDouble(row[col1]);
                                ValEnd = Convert.ToDouble(row[col1]);
                            }
                            else
                            {
                                // считаем количество не заполненных последних дней
                                numberEmptyEnd = numberEmptyEnd + 1;
                                // если первое значение пустое, то ищем данные с предыдущего месяца
                                if (i == 1)
                                    flagPrev = true;

                                if (flagPrev || numberEmptyBeg == i)
                                    numberEmptyBeg = numberEmptyBeg + 1;
                            }
                        }
                        // 2. Найдем показания начала месяца (первого дня)
                        // найдем ValBeg (расчетный)
                        double ValEndPrev = 0; // первое не пустое значение показаний предыдущего месяца (если смотреть с конца месяца)
                        if (flagPrev)
                        {
                            // таблицу подгружаем один раз
                            if (tableMonthPrev.Rows.Count == 0 )
                            {
                                string sMonthPrev = datePrev.Month.ToString();
                                string sYearPrev = datePrev.Year.ToString();
                                tableMonthPrev = commandTok5.SelectSqlData("SELECT OBJECT_CODE, OBJECT_NAME, NODE_CODE, NODE_NAME, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20, D21, D22, D23, D24, D25, D26, D27, D28, D29, D30, D31 FROM dbo.fn_Counters_Pivot(" + sMonthPrev + ", " + sYearPrev + ") WHERE VIS" + iCurrConfig + "<>0 ORDER BY OBJECT_NAME, NODE_NAME");
                            }
                            // из выбранного массив будем брать только первую строку (индекс = 0)
                            DataRow[] rowFindPrevMonth = tableMonthPrev.Select("OBJECT_CODE = " + row["OBJECT_CODE"] + "AND NODE_CODE = " + row["NODE_CODE"]);
 
                            for (int i = DateTime.DaysInMonth(datePrev.Year, datePrev.Month); i >= 1; i--)
                            {
                                string col1 = "D" + i;
                                if (rowFindPrevMonth[0][col1].ToString() == "")
                                    numberEmptyPrev = numberEmptyPrev + 1;
                            }
                            ValEndPrev = Convert.ToDouble(rowFindPrevMonth[0]["D" + (DateTime.DaysInMonth(datePrev.Year, datePrev.Month) - numberEmptyPrev)]);

                            ValBeg = ValEndPrev + (numberEmptyPrev + 1) * (ValBeg - ValEndPrev) / (numberEmptyPrev + numberEmptyBeg + 1);
                        }

                        // 3. расчет для месяца отличного от текущего (дорасчет конца месяца по следующему месяцу) 
                        if (flagNext)
                        {
                            // из выбранного массив будем брать только первую строку (индекс = 0)
                            DataRow[] rowFindNextMonth = tableNextMonth.Select("OBJECT_CODE = " + row["OBJECT_CODE"] + "AND NODE_CODE = " + row["NODE_CODE"]);
                            double ValBegNext = 0; // первое не пустое значение показаний следующего месяца
                            int numberEmptyNext = 0; // количество пустых дней в начале следующего месяца
                            //Ищем первое значение 
                            for (int i = 1; i <= DateTime.DaysInMonth(dateNext.Year, dateNext.Month); i++)
                            {
                                string col1 = "D" + i;
                                // если первый день следующего месяца заполнен
                                if (rowFindNextMonth[0][col1].ToString() != "")
                                {
                                    ValBegNext = Convert.ToDouble(rowFindNextMonth[0][col1]);
                                    break;
                                }
                                else// если начало месяца не заполнено
                                    numberEmptyNext = numberEmptyNext + 1;
                            }
                            if (numberEmptyEnd != 0 || numberEmptyNext != 0) // если пустые значения есть
                                ValBegNext = (ValEnd + (numberEmptyEnd + 1) * (ValBegNext - ValEnd) / (numberEmptyEnd + numberEmptyNext + 1));

                            row["Total"] = ValBegNext - ValBeg;
                            row["Forecast"] = ValBegNext;
                        }
                        else // расчет для текущего месяца
                        {
                            // прогнозный объем (дорасчет)
                            row["Forecast"] = (ValEnd + (numberEmptyEnd + 1) * (ValEnd - ValBeg) / (DateTime.DaysInMonth(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month) - numberEmptyEnd - 1)) - ValBeg;
                            // итоговая сумма по фактическим данным
                            row["Total"] = ValEnd - ValBeg;
                        }
                    }
                    break;
                case ("IDC_RADIO_PEAKPOWER"):
                    commandTok5.CommandTimeout = 240;
                    // Пиковая мощность (IDC_RADIO_PEAKPOWER)
                    //Итоговая пиковая мощность по объектам
                    //DataTable tableObj = commandTok5.SelectSqlData("SELECT OBJECT_CODE, OBJECT_NAME, NODE_CODE, NODE_NAME, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20, D21, D22, D23, D24, D25, D26, D27, D28, D29, D30, D31 FROM dbo.fn_MaxPowerPerDayObj_Pivot(" + sMonth + ", " + sYear + ", " + iCurrConfig + ") ORDER BY OBJECT_NAME");

                    ////Итоговая пиковая мощность по конфигурации
                    //DataTable tableTotal = commandTok5.SelectSqlData("SELECT OBJECT_CODE, OBJECT_NAME, NODE_CODE, NODE_NAME, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20, D21, D22, D23, D24, D25, D26, D27, D28, D29, D30, D31 FROM dbo.fn_MaxPowerPerDayTotal_Pivot(" + sMonth + ", " + sYear + ", " + iCurrConfig + ") ORDER BY OBJECT_NAME");

                    DataTable tableDay = commandTok5.SelectSqlData("SELECT OBJECT_CODE, OBJECT_NAME, NODE_CODE, NODE_NAME, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20, D21, D22, D23, D24, D25, D26, D27, D28, D29, D30, D31 FROM dbo.fn_MaxPowerPerDay_Pivot(" + sMonth + ", " + sYear + ") WHERE VIS" + iCurrConfig + "<>0  ORDER BY OBJECT_NAME, NODE_NAME");

                    DataColumn dataColumn1 = new DataColumn()
                    {
                        ColumnName = "Total",
                        DataType = typeof(Double),
                        DefaultValue = 0
                    };
                    tableDay.Columns.Add(dataColumn1);
                    tableDay.Columns.Add("Forecast", typeof(Double));

                    foreach (DataRow row in tableDay.Rows)
                    {
                        table.ImportRow(row);
                        //table.Rows.Add(row.ItemArray);
                    }


                        break;
                default:
                    return;
            }

            double s1 = table.AsEnumerable().Sum(r => Convert.ToDouble(r["Total"]));
            IDC_STATIC_TOTAL1.Text = "Итого: " + s1.ToString("N2");
            ((DataGridView)(tabControl1.SelectedTab.Controls["dgv" + iCurrConfig])).DataSource = table;

            // зададим стиль чмсловых ячеек
            string formatNumberColumn = "N2";
            // переименуем колонкe Forecast (Прогноз)
            switch (calculationType)
            {
                case ("IDC_RADIO_COUNTER"):
                    formatNumberColumn = "N4";
                    if (flagNext)
                        ((DataGridView)(tabControl1.SelectedTab.Controls["dgv" + iCurrConfig])).Columns["Forecast"].HeaderText = "Показания след. месяца";
                    else
                        ((DataGridView)(tabControl1.SelectedTab.Controls["dgv" + iCurrConfig])).Columns["Forecast"].HeaderText = "Прогноз";
                    break;
                default:
                    ((DataGridView)(tabControl1.SelectedTab.Controls["dgv" + iCurrConfig])).Columns["Forecast"].HeaderText = "Прогноз";
                    break;
            }
            foreach (DataGridViewColumn col in ((DataGridView)(tabControl1.SelectedTab.Controls["dgv" + iCurrConfig])).Columns)
            {
                System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex(@"D([1-9]{1}$|[1-2]{1}[0-9]{1}$|30$|31$)");
                if (rgx.Match(col.DataPropertyName).Value != "")
                    ((DataGridView)(tabControl1.SelectedTab.Controls["dgv" + iCurrConfig])).Columns[col.Index].DefaultCellStyle.Format = formatNumberColumn;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (calculationType == "IDC_RADIO_COUNTER")
                if (e.RowIndex % 2 == 0)
                {
                    // тельняшка
                    e.CellStyle.BackColor = Color.FromArgb(204, 255, 255);
                    //else // пока оставим так
                    //    e.CellStyle.BackColor = Color.LightGray;
                }
            // если ячейка пустая
            if (Convert.ToString(e.Value) == "")
                e.CellStyle.BackColor = Color.FromArgb(215, 215, 215);
            //if (Convert.ToDouble(e.Value) < 0.0)
            //    e.CellStyle.ForeColor = Color.Red;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimeBegForecast.Value = new System.DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            dateTimeEndForecast.Value = new System.DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month,
                System.DateTime.DaysInMonth(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month));
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.dataGridView1.ExportToExcel();
        }
    }
}

