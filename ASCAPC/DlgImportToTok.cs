using DataSql;
using FormLbr;
using Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;


namespace ASCAPC
{
    public partial class DlgImportToTok : FormBase
    {
        //SQLSettings settingsTok5;
        LibraryTSQL.SqlDataCommand tSQL;

        public DlgImportToTok()
        {
            InitializeComponent();
            Text = "Импорт получасовок в базу данных TOK-5";

            //settingsTok5 = new SQLSettings("ulges-sql", "Tok_5", "WINDOWS", "", "");
            //this.SqlSettings = new SQLSettings(new SQLSettingsTok5());
            //settingsTok5 = new SQLSettings(new SQLSettingsTok5());
            //tSQL = new SqlDataCommand(settingsTok5);
            //tSQL.SqlSettings = this.SqlSettings;

            this.SqlSettings = new SQLSettings(new SQLSettingsTok5());
            tSQL = new LibraryTSQL.SqlDataCommand();
            tSQL.SqlSettings = this.SqlSettings;
            tSQL.SelectSqlData(this.datasetTOK5.OBJECTS, true);
            tSQL.SelectSqlData(this.datasetTOK5.NODES, true);
            //tSQL.SelectSqlData(this.datasetTOK5.KWH30, true);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbLoad80200_Click(object sender, EventArgs e)
        {
            rtLogger.Clear();
            rtLogger.AppendText($"Начало: {DateTime.Now}\r\n");
            Application.DoEvents();
            //string inn = "7303003290";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранные файлЫ
            foreach (String filename in openFileDialog1.FileNames)
            {
                rtLogger.AppendText($"Загружаемый файл {filename}\r\n");
                Application.DoEvents();
                try
                {
                    // читаем файл в строку
                    string fileText = System.IO.File.ReadAllText(filename);
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(filename);
                    // получим корневой элемент
                    XmlElement xRoot = xDoc.DocumentElement;
                    // обход всех узлов в корневом элементе
                    // перед обходом надо бы проверить версию формата файла
                    // текущий алгоритм version = 2
                    // основной корневой элемент это <message>
                    DateTime dayLoad = DateTime.Now; // дата, определяющая операционный период, за который предоставляется информация
                    DateTime timestamp; // timestamp является дата и время формирования данного документа
                    foreach (XmlNode xnode in xRoot)
                    {
                        // если узел - datetime
                        // найдем дату загрузки
                        if (xnode.Name == "datetime")
                        {
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "timestamp")
                                {
                                    string value = childnode.InnerText;
                                    timestamp = new DateTime(Convert.ToInt32(value.Substring(0, 4)), Convert.ToInt32(value.Substring(4, 2)), Convert.ToInt32(value.Substring(6, 2))
                                        , Convert.ToInt32(value.Substring(8, 2)), Convert.ToInt32(value.Substring(10, 2)), Convert.ToInt32(value.Substring(12, 2)));
                                }

                                if (childnode.Name == "day")
                                {
                                    string value = childnode.InnerText;
                                    dayLoad = new DateTime(Convert.ToInt32(value.Substring(0, 4)), Convert.ToInt32(value.Substring(4, 2)), Convert.ToInt32(value.Substring(6, 2)));
                                }
                            }
                        }
                        rtLogger.AppendText($"Дата загрузки : {dayLoad.ToString("yyyy-MM-dd")}\r\n");
                        Application.DoEvents();
                        // <area> содержит информацию о результатах измерений Потребителя
                        if (xnode.Name == "area")
                        {
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "measuringpoint")
                                {
                                    // ищем код объекта, у которого забираем измерения
                                    // для синхронизацией с общей базой
                                    if (childnode.Attributes.Count > 0)
                                    {
                                        XmlNode attrPointCode = childnode.Attributes.GetNamedItem("code");
                                        if (attrPointCode != null)
                                        {
                                            // Ищем код в базе данных
                                            string codeIdDB_XML = attrPointCode.Value;
                                            var codeIdDB = this.datasetTOK5.NODES.Where(w => w["XML80020_NODECODE"].ToString() == codeIdDB_XML);
                                            string attrPointName = childnode.Attributes.GetNamedItem("name").Value;
                                            int NODE_CODE;
                                            int OBJECT_CODE;
                                            if (codeIdDB.Count() > 0)
                                            {
                                                // нашли узел NODES, возьмем самый первый
                                                NODE_CODE = Convert.ToInt32(codeIdDB.First()["NODE_CODE"]);
                                                // найдем код OBJECTS
                                                OBJECT_CODE = Convert.ToInt32(codeIdDB.First()["OBJECT_CODE"]);
                                                //
                                                rtLogger.AppendText($"Грузим узел NODES {codeIdDB_XML} {attrPointName}\r\n");
                                                Application.DoEvents();
                                            }
                                            else
                                            {
                                                Log.Write(LogLevel.Error, "ASCAPC", "DlgImportToTok", "tsbLoad80200_Click", $"Не найден узел NODES {codeIdDB_XML} {attrPointName}");

                                                rtLogger.AppendText($"Не найден узел NODES {codeIdDB_XML} {attrPointName}\r\n");
                                                Application.DoEvents();
                                                continue;
                                            }
                                            // <measuringchannel> содержит информацию о результатах измерений по точкам измерений
                                            foreach (XmlNode childnode1 in childnode.ChildNodes)
                                            {
                                                if (childnode1.Name == "measuringchannel")
                                                {
                                                    // код измерительного канала = "02" активная отдача
                                                    XmlNode attrChannel = childnode1.Attributes.GetNamedItem("code");
                                                    if (attrChannel != null)
                                                    {
                                                        if (attrChannel.Value == "02")
                                                        {
                                                            foreach (XmlNode nodePeriod in childnode1.ChildNodes)
                                                            {
                                                                if (nodePeriod.Attributes.Count > 0)
                                                                {
                                                                    // получим время начала и конца измерения
                                                                    XmlNode attrStart = nodePeriod.Attributes.GetNamedItem("start");
                                                                    string start;
                                                                    if (attrStart != null)
                                                                        start = attrStart.Value;
                                                                    else
                                                                    {
                                                                        Log.Write(LogLevel.Error, "ASCAPC", "DlgImportToTok", "tsbLoad80200_Click", $"Отсутствует параметр start в файле {filename}");

                                                                        rtLogger.AppendText($"Отсутствует параметр start в файле \r\n");
                                                                        Application.DoEvents();

                                                                        continue;
                                                                    }
                                                                    XmlNode attrEnd = nodePeriod.Attributes.GetNamedItem("end");
                                                                    string end;
                                                                    if (attrEnd != null)
                                                                        end = attrEnd.Value;
                                                                    else
                                                                    {
                                                                        Log.Write(LogLevel.Error, "ASCAPC", "DlgImportToTok", "tsbLoad80200_Click", $"Отсутствует параметр end в файле {filename}");
                                                                        rtLogger.AppendText($"Отсутствует параметр end в файле \r\n");
                                                                        Application.DoEvents();
                                                                        continue;
                                                                    }
                                                                    // получим значение результата измерения
                                                                    string SAMPLE_VALUE = nodePeriod.InnerText;
                                                                    // ищем такую же запись в базе данных и обновляем
                                                                    // или вставляем новую
                                                                    end = $"{end.Substring(0, 2)}:{end.Substring(2, 2)}";
                                                                    string SAMPLE_DATE = "";
                                                                    if (end == "00:00") // если конец дня, то надо брать слдующий день
                                                                        SAMPLE_DATE = $"{dayLoad.AddDays(1).ToString("yyyy-MM-dd")} {end}";
                                                                    else
                                                                        SAMPLE_DATE = $"{dayLoad.ToString("yyyy-MM-dd")} {end}";
                                                                    string where = $" where  [OBJECT_CODE] = {OBJECT_CODE} and [NODE_CODE] = {NODE_CODE} " +
                                                                        $" and [SAMPLE_DATE] = '{SAMPLE_DATE}'";
                                                                    if (tSQL.SelectSqlData(this.datasetTOK5.KWH30, true, where))
                                                                    {
                                                                        if (this.datasetTOK5.KWH30.Count() == 0)
                                                                        {
                                                                            DataRow rowM = this.datasetTOK5.KWH30.NewRow();
                                                                            rowM["OBJECT_CODE"] = OBJECT_CODE;
                                                                            rowM["NODE_CODE"] = NODE_CODE;
                                                                            rowM["STATUS_CODE"] = 10;
                                                                            rowM["SAMPLE_DATE"] = Convert.ToDateTime(SAMPLE_DATE);
                                                                            rowM["SAMPLE_VALUE"] = SAMPLE_VALUE;

                                                                            this.datasetTOK5.KWH30.Rows.Add(rowM);

                                                                            tSQL.InsertSqlData(this.datasetTOK5.KWH30);
                                                                        }
                                                                        else
                                                                        {
                                                                            // поидее одна строка должна быть
                                                                            DataRow rowM = this.datasetTOK5.KWH30.First();
                                                                            rowM["SAMPLE_DATE"] = Convert.ToDateTime(SAMPLE_DATE);
                                                                            rowM["SAMPLE_VALUE"] = SAMPLE_VALUE;

                                                                            tSQL.UpdateSqlData(this.datasetTOK5.KWH30);
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                rtLogger.AppendText($"Окончание: {DateTime.Now}\r\n");
                Application.DoEvents();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tsbStruktFider_Click(object sender, EventArgs e)
        {
            ASCAPC.DlgStructFider frm = new ASCAPC.DlgStructFider();
            ((Form)frm).MdiParent = (Form)this.MdiParent;
            ((Form)frm).Show();
        }

        private void tsbUMZ_Click(object sender, EventArgs e)
        {
            LoadHalfHoursUMZ();
        }

        private void LoadHalfHoursUMZ()
        {
            //throw new NotImplementedException();
            rtLogger.Clear();
            rtLogger.AppendText($"Начало загрузки данных УМЗ: {DateTime.Now}\r\n");
            Application.DoEvents();
            if (openFileDialogUMZ.ShowDialog() == DialogResult.Cancel)
                return;
            foreach (String filename in openFileDialogUMZ.FileNames)
            {
                rtLogger.AppendText($"Загружаемый файл {filename}\r\n");
                Application.DoEvents();
                System.Data.DataTable dataTable = null;
                using (var document = SpreadsheetDocument.Open(filename, false))
                {
                    try
                    {
                        foreach (var sheet in document.WorkbookPart.Workbook.Sheets)
                        {
                            var relationshipId = ((DocumentFormat.OpenXml.Spreadsheet.Sheet)sheet).Id.Value;
                            var worksheetPart = (WorksheetPart)document.WorkbookPart.GetPartById(relationshipId);
                            var sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
                            //// читаем колонки A:G (7 колонок)
                            //// в начале надо найти объединеннеы колонки B:F, здесь находится дата сбора данных
                            //// Структура данных:
                            //// А - время сбора данных
                            //// B - яч4
                            //// C - яч.8
                            //// D - яч.31
                            //// E - яч.45
                            //// F - яч.50
                            //// G - итог
                            foreach (Row row in sheetData.Elements<Row>())
                            {
                                foreach (var cell in row.Elements<Cell>())
                                {
                                    // var value = cell.CellValue;
                                    var value = GetCellValue(cell, document.WorkbookPart);
                                    var value1 = GetCellValue(filename, ((Sheet)sheet).Name, cell.CellReference);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(String.Format("Возможно в документе \"{0}\" существуют проблемы с форматом файла !\n", filename), ex);
                    }
                }
            }
            rtLogger.AppendText($"Окончание загрузки данных УМЗ: {DateTime.Now}\r\n");
            Application.DoEvents();

        }
        // Retrieve the value of a cell, given a file name, sheet name, 
        // and address name.
        private static string GetCellValue(string fileName,
            string sheetName,
            string addressName)
        {
            string value = null;

            // Open the spreadsheet document for read-only access.
            using (SpreadsheetDocument document =
                SpreadsheetDocument.Open(fileName, false))
            {
                // Retrieve a reference to the workbook part.
                WorkbookPart wbPart = document.WorkbookPart;

                // Find the sheet with the supplied name, and then use that 
                // Sheet object to retrieve a reference to the first worksheet.
                Sheet theSheet = wbPart.Workbook.Descendants<Sheet>().
                  Where(s => s.Name == sheetName).FirstOrDefault();

                // Throw an exception if there is no sheet.
                if (theSheet == null)
                {
                    throw new ArgumentException("sheetName");
                }

                // Retrieve a reference to the worksheet part.
                WorksheetPart wsPart =
                    (WorksheetPart)(wbPart.GetPartById(theSheet.Id));

                // Use its Worksheet property to get a reference to the cell 
                // whose address matches the address you supplied.
                Cell theCell = wsPart.Worksheet.Descendants<Cell>().
                  Where(c => c.CellReference == addressName).FirstOrDefault();

                // If the cell does not exist, return an empty string.
                if (theCell != null)
                {
                    value = theCell.InnerText;

                    // If the cell represents an integer number, you are done. 
                    // For dates, this code returns the serialized value that 
                    // represents the date. The code handles strings and 
                    // Booleans individually. For shared strings, the code 
                    // looks up the corresponding value in the shared string 
                    // table. For Booleans, the code converts the value into 
                    // the words TRUE or FALSE.
                    if (theCell.DataType != null)
                    {
                        switch (theCell.DataType.Value)
                        {
                            case CellValues.SharedString:

                                // For shared strings, look up the value in the
                                // shared strings table.
                                var stringTable =
                                    wbPart.GetPartsOfType<SharedStringTablePart>()
                                    .FirstOrDefault();

                                // If the shared string table is missing, something 
                                // is wrong. Return the index that is in
                                // the cell. Otherwise, look up the correct text in 
                                // the table.
                                if (stringTable != null)
                                {
                                    value =
                                        stringTable.SharedStringTable
                                        .ElementAt(int.Parse(value)).InnerText;
                                }
                                break;

                            case CellValues.Boolean:
                                switch (value)
                                {
                                    case "0":
                                        value = "FALSE";
                                        break;
                                    default:
                                        value = "TRUE";
                                        break;
                                }
                                break;
                        }
                    }
                }
            }
            return value;
        }
        private static string GetCellValue(Cell cell, WorkbookPart wbPart)
        {
            var value = cell.InnerText;

            if (cell.DataType == null)
            {
                // StyleIndex == 30,31 - дата
                // StyleIndex == 29 - пустая строка
                // StyleIndex == 3,4 - время
                // StyleIndex == 5 - произвольный формат
                if (value != "" && cell.StyleIndex != null && cell.StyleIndex == 30)
                    return DateTime.FromOADate(Convert.ToDouble(value)).ToShortDateString();
                else if (value != "" && cell.StyleIndex != null && ",3,4,".IndexOf(cell.StyleIndex) >= 0)
                    return DateTime.FromOADate(Convert.ToDouble(value)).ToLongTimeString();
                else if (value != "" && cell.StyleIndex != null && ",5,".IndexOf(cell.StyleIndex) >= 0)
                    return "";
                else
                    return value;
            }
            switch (cell.DataType.Value)
            {
                case CellValues.SharedString:

                    var stringTable = wbPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();

                    if (stringTable != null)
                    {
                        value = stringTable.SharedStringTable.ElementAt(int.Parse(value)).InnerText;
                    }
                    break;

                case CellValues.Boolean:
                    switch (value)
                    {
                        case "0":
                            value = "FALSE";
                            break;
                        default:
                            value = "TRUE";
                            break;
                    }
                    break;
            }

            return value;
        }
    }
}
