using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DataSql;
using FormLbr.Classes;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace JournalOrder
{
    /// версии печатных форм
    /// version = 1 - с 2015 по 2021
    /// version = 2 - с 2021
    internal static class ReportOrderToExcel
    {
        /// <summary>
        /// количество строк на второй странице
        /// </summary>
        private const int RowCountPage2 = 89;
        private static Microsoft.Office.Interop.Excel.Application xla;
        private static Workbook xlw;
        private static int Id;
        private static DataSet.DataSetOrder dataSetOrder;
        private static SQLSettings sqlSett;
        /// <summary>
        ////версия печатной формы
        /// </summary>
        private static int VersionPrintMaket = 1;

        internal static void Report(int id, SQLSettings sqlsett)
        {
            ReportOrderToExcel.sqlSett = sqlsett;
            ReportOrderToExcel.Id = id;
            ReportOrderToExcel.dataSetOrder = new DataSet.DataSetOrder();
            SqlDataCommand sqlDataCommand = new SqlDataCommand(ReportOrderToExcel.sqlSett);
            sqlDataCommand.SelectSqlData(ReportOrderToExcel.dataSetOrder.vJ_Order, true, "where id = " + ReportOrderToExcel.Id.ToString(), null, false, 0);
            sqlDataCommand.SelectSqlData(ReportOrderToExcel.dataSetOrder.vWorkerGroup, true, "", null, false, 0);
            sqlDataCommand.SelectSqlData(ReportOrderToExcel.dataSetOrder.tR_Classifier, true, " where parentkey = ';Other;JobTitle;' and isgroup = 0 and deleted = 0", null, false, 0);
            if (ReportOrderToExcel.dataSetOrder.vJ_Order.Rows.Count <= 0)
            {
                return;
            }
            DataRow dataRow = ReportOrderToExcel.dataSetOrder.vJ_Order.Rows[0];
            string PrintArea = "";
            string DirectoryCreateOutFile = ReportOrderToExcel.GetTempPathEISOrder();
            string filename = string.Concat(new object[]
            {
                DirectoryCreateOutFile,"наряд_",dataRow["num"],"_",Convert.ToDateTime(dataRow["dateBegin"]).Year.ToString(),"_",Environment.UserName,".xlsx"
            });
            ReportOrderToExcel.xla = new ApplicationClass();
            // получим полное имя выгружаемого (формируемого) файла
            // надо поиметь версию шаблона, чтобы взять нужный файл
            string FullFileName = "";
            try
            {
                TemplateProperty result = ReportOrderToExcel.GetCreateFileName(ReportOrderToExcel.sqlSett, Convert.ToDateTime(dataRow["dateOutput"]));
                FullFileName = result.OutFullFileName;
                VersionPrintMaket = result.Version;
            }
            catch (Exception)
            {
            }
            try
            {
                if (string.IsNullOrEmpty(FullFileName))
                {
                    FullFileName = DirectoryCreateOutFile + "\\шаблон.xlsx";
                }
                ReportOrderToExcel.xlw = ReportOrderToExcel.xla.Workbooks.Open(FullFileName, 2, true, 5, "", "", true, XlPlatform.xlWindows, "", true, true, null, null, null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return;
            }
            try
            {
                ReportOrderToExcel.xlw.SaveAs(filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, ex2.Source);
                ReportOrderToExcel.xlw.Close(false, Type.Missing, Type.Missing);
                ReportOrderToExcel.xla.Quit();
                return;
            }
            // лицевой лист
            Worksheet worksheet = (Worksheet)ReportOrderToExcel.xlw.Worksheets.get_Item(1);
            ((Worksheet)ReportOrderToExcel.xlw.Worksheets[1]).Copy(Type.Missing, ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count]);
            // оборотный лист
            PrintArea = PrintArea + "$A$1:$J" + RowCountPage2.ToString() + ";"; 
            ((Worksheet)ReportOrderToExcel.xlw.Worksheets[2]).PageSetup.PrintArea = PrintArea.Remove(PrintArea.Length - 1);

            PrintArea = "";
            ((Worksheet)ReportOrderToExcel.xlw.Worksheets[2]).Copy(Type.Missing, ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count]);
            ReportOrderToExcel.Edit_Sheet1((Worksheet)ReportOrderToExcel.xlw.Worksheets[3]);
            ReportOrderToExcel.Edit_Sheet2((Worksheet)ReportOrderToExcel.xlw.Worksheets[4]);

            sqlDataCommand.SelectSqlData(ReportOrderToExcel.dataSetOrder.tJ_OrderInstruction, true, "where idOrder = " + ReportOrderToExcel.Id.ToString() + " order by rec_num", null, false, 0);
            if (ReportOrderToExcel.dataSetOrder.tJ_OrderInstruction.Rows.Count > 0)
            {
                ReportOrderToExcel.Edit_tabl1((Worksheet)ReportOrderToExcel.xlw.Worksheets[3], 0);
            }

            sqlDataCommand.SelectSqlData(ReportOrderToExcel.dataSetOrder.tJ_OrderBrigade, true, "where idOrder = " + ReportOrderToExcel.Id.ToString(), null, false, 0);
            string strIdWorker = "";
            foreach (DataRow dataRow2 in ReportOrderToExcel.dataSetOrder.tJ_OrderBrigade.Rows)
            {
                strIdWorker = strIdWorker + dataRow2["idworker"].ToString() + ",";
            }
            if (strIdWorker.Length > 0)
            {
                strIdWorker = strIdWorker.Remove(strIdWorker.Length - 1);
                sqlDataCommand.SelectSqlData(ReportOrderToExcel.dataSetOrder.vWorkerGroup, true, "where id in (" + strIdWorker + ")", null, true, 0);
                foreach (DataRow dataRow3 in (from DataRow row in ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows
                                              group row by row["Id"] into g
                                              where g.Count<DataRow>() > 1
                                              select g).SelectMany((IGrouping<object, DataRow> g) => g.Skip(1)))
                {
                    dataRow3.Delete();
                }
                ReportOrderToExcel.dataSetOrder.vWorkerGroup.AcceptChanges();
            }
            else
            {
                ReportOrderToExcel.dataSetOrder.vWorkerGroup.Clear();
            }
            if (ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows.Count > 0)
            {
                ReportOrderToExcel.Edit_tabl2((Worksheet)ReportOrderToExcel.xlw.Worksheets[4], 0);
            }
            ReportOrderToExcel.xla.DisplayAlerts = false;
            ((Worksheet)ReportOrderToExcel.xlw.Worksheets[1]).Delete();
            ((Worksheet)ReportOrderToExcel.xlw.Worksheets[1]).Delete();
            ReportOrderToExcel.xla.DisplayAlerts = true;
            ///
            Worksheet worksheet2 = (Worksheet)ReportOrderToExcel.xlw.Worksheets.Add(Type.Missing, ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count], Type.Missing, Type.Missing);
            worksheet2.Name = "Для двухсторонней печати";
            int numRowBegin = 1; // номер начальной строки
            foreach (Worksheet worksheet3 in ReportOrderToExcel.xlw.Worksheets)
            {
                if (worksheet3.Index == worksheet2.Index)
                {
                    break;
                }
                worksheet3.Activate();
                int numRowEnd; // номер конечной строки
                if (worksheet3.Name[worksheet3.Name.Length - 1] == '1')
                {
                    // четная сторона печатной формы
                    numRowEnd = worksheet3.UsedRange.Rows.Count;
                    if (VersionPrintMaket == 2)
                        worksheet3.get_Range("A1:O" + numRowEnd.ToString(), Type.Missing).Copy(Type.Missing);
                    else
                        worksheet3.get_Range("A1:J" + numRowEnd.ToString(), Type.Missing).Copy(Type.Missing);
                }
                else
                {
                    // нечетная сторона печатной формы
                    numRowEnd = RowCountPage2; 
                    worksheet3.get_Range("A1:T" + numRowEnd.ToString(), Type.Missing).Copy(Type.Missing);
                }
                worksheet2.Activate();
                Range range;
                if (worksheet3.Name[worksheet3.Name.Length - 1] == '1')
                {
                    // берем диапозон печати лицевой стороны печатной формы (нечетные листы)
                    range = worksheet2.get_Range("A" + numRowBegin.ToString(), Type.Missing);
                    if (VersionPrintMaket == 2)
                    {
                        PrintArea = string.Concat(new string[]
                    {
                        PrintArea,"$A$",    numRowBegin.ToString(), ":$O",(numRowBegin + worksheet3.UsedRange.Rows.Count - 1).ToString(),";"
                    });
                    }

                    else
                    {
                        PrintArea = string.Concat(new string[]
                    {
                        PrintArea,"$A$",    numRowBegin.ToString(), ":$J",(numRowBegin + worksheet3.UsedRange.Rows.Count - 1).ToString(),";"
                    });
                    }
                }
                else
                {
                    // берем диапозон обратной стороны печатной формы (четные листы)
                    if (VersionPrintMaket == 2)
                    {
                        range = worksheet2.get_Range("P" + numRowBegin.ToString(), Type.Missing);
                        PrintArea = string.Concat(new string[]
                        {
                            PrintArea,"$P$",    numRowBegin.ToString(),":$Y",(numRowBegin + RowCountPage2 - 1).ToString(),";"
                        });
                    }
                    else
                    {
                        range = worksheet2.get_Range("K" + numRowBegin.ToString(), Type.Missing);
                        PrintArea = string.Concat(new string[]
                        {
                            PrintArea,"$K$",    numRowBegin.ToString(),":$T",(numRowBegin + RowCountPage2 - 1).ToString(),";"
                        });
                    }
                }
                range.PasteSpecial(XlPasteType.xlPasteColumnWidths, XlPasteSpecialOperation.xlPasteSpecialOperationNone, Type.Missing, Type.Missing);
                range.PasteSpecial(XlPasteType.xlPasteFormats, XlPasteSpecialOperation.xlPasteSpecialOperationNone, Type.Missing, Type.Missing);
                range.PasteSpecial(XlPasteType.xlPasteValuesAndNumberFormats, XlPasteSpecialOperation.xlPasteSpecialOperationNone, Type.Missing, Type.Missing);
                for (int i = 1; i <= numRowEnd; i++)
                {
                    ((Range)range.Rows[i, Type.Missing]).RowHeight = ((Range)worksheet3.Rows[i, Type.Missing]).RowHeight;
                }
                numRowBegin = numRowBegin + numRowEnd + 1;
            }
            worksheet2.PageSetup.PrintArea = PrintArea.Remove(PrintArea.Length - 1);
            try
            {
                worksheet2.PageSetup.FitToPagesWide = 1;
                worksheet2.PageSetup.FitToPagesTall = 1;
                worksheet2.PageSetup.Zoom = false;
                worksheet2.PageSetup.LeftMargin = ReportOrderToExcel.xla.CentimetersToPoints(0.9);
                worksheet2.PageSetup.RightMargin = ReportOrderToExcel.xla.CentimetersToPoints(0.5);
                worksheet2.PageSetup.TopMargin = ReportOrderToExcel.xla.CentimetersToPoints(0.3);
                worksheet2.PageSetup.BottomMargin = ReportOrderToExcel.xla.CentimetersToPoints(0.3);
            }
            catch
            {
            }
            worksheet2.get_Range("A1", Type.Missing).Select();
            ReportOrderToExcel.xlw.Save();
            ReportOrderToExcel.xla.Visible = true;
        }
        internal struct TemplateProperty
        {
            /// <summary>
            /// версия шаблна
            /// </summary>
            internal int Version;
            /// <summary>
            /// выходное полное имя формируемого файла
            /// </summary>
            internal string OutFullFileName;

        }
        /// <summary>
        /// получаем вполное имя выгружаемого файл (по входящей дате)
        /// </summary>
        /// version = 1 - с 2015 по 2021
        /// version = 2 - с 2021
        /// <returns></returns>
        private static TemplateProperty GetCreateFileName(SQLSettings sqlsett, DateTime date)
        {
            TemplateProperty result = new TemplateProperty();
            //date = new DateTime(2000, 02, 01);
            DateTime DateTemplateLast = new DateTime(2000, 01, 01);
            DateTime DateTemplateCurrent = DateTime.Today; // дата текущего  шаблона в цикле (надо брать предыдущий)
            System.Data.DataTable dataTable = new SqlDataCommand(sqlsett).SelectSqlData(" SELECT doc.id, doc.FileName, doc.DateIn  FROM tR_DocTemplate AS doc  INNER JOIN [tR_Classifier] AS c ON doc.idTypeDoc = c.id  WHERE c.ParentKey = ';TypeDoc;tR_DocTemplate;' AND c.Deleted = ((0)) AND c.isGroup = ((0)) AND c.Value = 5 and doc.deleted = 0");
            if (dataTable.Rows.Count == 0) return result;
            int IdLast = Convert.ToInt32(dataTable.Rows[0]["id"]);
            int version = 1;
            List<string> listFileName = new List<string>();
            foreach (DataRow row in dataTable.AsEnumerable())
            {
                DateTemplateCurrent = Convert.ToDateTime(row["DateIn"]);
                if (date >= DateTemplateLast && date < DateTemplateCurrent || date < DateTemplateLast)
                {
                    // если внутри диапозона, то берем последний шаблон
                    break;
                }
                IdLast = Convert.ToInt32(row["id"]);
                version = dataTable.Rows.IndexOf(row) + 1;
                DateTemplateLast = Convert.ToDateTime(row["DateIn"]);
            }

            string fileName;
            byte[] inputByteArray;
            ReportOrderToExcel.GetFileNameTemplate(IdLast, out fileName, out inputByteArray, sqlsett);
            string extension = new System.IO.FileInfo(fileName).Extension;
            if (!(extension == ".xlt") && !(extension == ".xltx"))
            {
                if (!(extension == ".xls") && !(extension == ".xlsx"))
                {
                    return result;
                }
            }
            else
            {
                fileName = fileName.Replace(extension, extension.Replace("t", "s"));
            }
            string path = ReportOrderToExcel.GetTempPathEISOrder();
            string newFileNameIsExists = FileBinary.GetNewFileNameIsExists(path, fileName, true);
            new FileBinary(inputByteArray, newFileNameIsExists, DateTime.Now).SaveToDisk(path);
            //return path + "\\" + newFileNameIsExists;
            result = new TemplateProperty { Version = version, OutFullFileName = path + "\\" + newFileNameIsExists };

            return result;
          
        }
        /// <summary>
        /// получаем полное имя выгружаемго файла (первую запись)
        /// </summary>
        /// <returns></returns>
        private static string GetCreateFileName(SQLSettings sqlsett)
        {
            System.Data.DataTable dataTable = new SqlDataCommand(sqlsett).SelectSqlData(" SELECT doc.id, doc.FileName  FROM tR_DocTemplate AS doc  INNER JOIN [tR_Classifier] AS c ON doc.idTypeDoc = c.id  WHERE c.ParentKey = ';TypeDoc;tR_DocTemplate;' AND c.Deleted = ((0)) AND c.isGroup = ((0)) AND c.Value = 5 and doc.deleted = 0");
            if (dataTable.Rows.Count > 0) // но забираем только одну строку
            {
                string fileName;
                byte[] inputByteArray;
                ReportOrderToExcel.GetFileNameTemplate(Convert.ToInt32(dataTable.Rows[0]["id"]), out fileName, out inputByteArray, sqlsett);
                string extension = new System.IO.FileInfo(fileName).Extension;
                if (!(extension == ".xlt") && !(extension == ".xltx"))
                {
                    if (!(extension == ".xls") && !(extension == ".xlsx"))
                    {
                        return "";
                    }
                }
                else
                {
                    fileName = fileName.Replace(extension, extension.Replace("t", "s"));
                }
                string path = ReportOrderToExcel.GetTempPathEISOrder();
                string newFileNameIsExists = FileBinary.GetNewFileNameIsExists(path, fileName, true);
                new FileBinary(inputByteArray, newFileNameIsExists, DateTime.Now).SaveToDisk(path);
                return path + "\\" + newFileNameIsExists;
            }
            else
                return "";
        }

        /// <summary>
        /// вернуть имя файлов их шаблонов
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fileName"></param>
        /// <param name="inputByteArray"></param>
        /// <param name="sqlsett"></param>
        private static void GetFileNameTemplate(int id, out string fileName, out byte[] inputByteArray, SQLSettings sqlsett)
        {
            fileName = "";
            inputByteArray = null;
            string cmdText = "SELECT FileName, FileData FROM tR_DocTemplate WHERE id = @idTemplate";
            using (SqlConnection sqlConnection = new SqlConnection(sqlsett.GetConnectionString()))
            {
                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                sqlCommand.Parameters.Add("@idTemplate", SqlDbType.Int);
                sqlCommand.Parameters["@idTemplate"].Value = id;
                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        fileName = (string)sqlDataReader.GetValue(0);
                        inputByteArray = (byte[])sqlDataReader.GetValue(1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
        }

        private static string GetTempPathEISOrder()
        {
            string str = "EIS\\Order";
            string patch = Path.GetTempPath() + str + "\\";
            if (!Directory.Exists(patch))
            {
                Directory.CreateDirectory(patch);
            }
            return patch;
        }

        private static string GetGroupElectricalWorker(int id)
        {
            DataRow[] array = ReportOrderToExcel.dataSetOrder.vWorkerGroup.Select("id = " + id.ToString());
            if (array.Length == 0)
            {
                return "";
            }
            if (array[0]["GroupElectrical"] == DBNull.Value)
            {
                return "";
            }
            switch (Convert.ToInt32(array[0]["GroupElectrical"]))
            {
                case 1:
                    return "I гр.";
                case 2:
                    return "II гр.";
                case 3:
                    return "III гр.";
                case 4:
                    return "IV гр.";
                case 5:
                    return "V гр.";
                default:
                    return "";
            }
        }

        private static string GetJobWorker(int id)
        {
            DataRow[] array = ReportOrderToExcel.dataSetOrder.tJ_OrderBrigade.Select("idWorker = " + id.ToString());
            if (array.Length != 0 && array[0]["idJobTitle"] != DBNull.Value)
            {
                DataRow[] array2 = ReportOrderToExcel.dataSetOrder.tR_Classifier.Select("id = " + array[0]["idJobTitle"].ToString());
                if (array2.Length != 0)
                {
                    return " (" + array2[0]["Name"] + ") ";
                }
            }
            return "";
        }

        private static void Edit_Sheet1(Worksheet active_sheet)
        {
            DataRow[] array = ReportOrderToExcel.dataSetOrder.vJ_Order.Select("id = " + ReportOrderToExcel.Id.ToString());
            if (array.Length == 0)
            {
                return;
            }
            DataRow dataRow = array[0];
            active_sheet.Name = "Лист" + (ReportOrderToExcel.xlw.Worksheets.Count - 2) / 2 + "-1";
            active_sheet.get_Range("Подр", Type.Missing).set_Value(Type.Missing, dataRow["SrName"]);
            if (Convert.ToInt32(dataRow["num"]) >= 1)
            {
                active_sheet.get_Range("Ном", Type.Missing).set_Value(Type.Missing, dataRow["num"].ToString() + "-э");
            }
            if (dataRow["headFio"] != DBNull.Value)
            {
                active_sheet.get_Range("Ответст", Type.Missing).set_Value(Type.Missing, dataRow["headFio"].ToString() + " " + ReportOrderToExcel.GetGroupElectricalWorker(Convert.ToInt32(dataRow["headWorker"])));
            }
            else
            {
                active_sheet.get_Range("Ответст", Type.Missing).set_Value(Type.Missing, "не назначается");
            }
            active_sheet.get_Range("Допуск", Type.Missing).set_Value(Type.Missing, dataRow["acceptFIO"].ToString() + " " + ReportOrderToExcel.GetGroupElectricalWorker(Convert.ToInt32(dataRow["acceptWorker"])));
            active_sheet.get_Range("Произв", Type.Missing).set_Value(Type.Missing, dataRow["makerFio"].ToString() + " " + ReportOrderToExcel.GetGroupElectricalWorker(Convert.ToInt32(dataRow["makerWorker"])));
            if (dataRow["watchFIO"] != DBNull.Value)
            {
                active_sheet.get_Range("Набл", Type.Missing).set_Value(Type.Missing, dataRow["watchFIO"].ToString() + " " + ReportOrderToExcel.GetGroupElectricalWorker(Convert.ToInt32(dataRow["watchWorker"])));
            }
            else
            {
                active_sheet.get_Range("Набл", Type.Missing).set_Value(Type.Missing, "не назначается");
            }
            SqlDataCommand sqlDataCommand = new SqlDataCommand(ReportOrderToExcel.sqlSett);
            sqlDataCommand.SelectSqlData(ReportOrderToExcel.dataSetOrder.tJ_OrderBrigade, true, "where idOrder = " + ReportOrderToExcel.Id.ToString(), null, false, 0);
            string text = "";
            foreach (DataRow dataRow2 in ReportOrderToExcel.dataSetOrder.tJ_OrderBrigade.Rows)
            {
                text = text + dataRow2["idworker"].ToString() + ",";
            }
            if (text.Length > 0)
            {
                text = text.Remove(text.Length - 1);
                sqlDataCommand.SelectSqlData(ReportOrderToExcel.dataSetOrder.vR_Worker, true, "where id in (" + text + ")", null, false, 0);
                text = "";
                foreach (DataRow dataRow3 in ReportOrderToExcel.dataSetOrder.vR_Worker.Rows)
                {
                    text = string.Concat(new string[]
                    {
                        text,
                        dataRow3["FIO"].ToString(),
                        ReportOrderToExcel.GetJobWorker(Convert.ToInt32(dataRow3["id"])),
                        " ",
                        ReportOrderToExcel.GetGroupElectricalWorker(Convert.ToInt32(dataRow3["id"])),
                        ", "
                    });
                }
                active_sheet.get_Range("Бригада", Type.Missing).set_Value(Type.Missing, text.Remove(text.Length - 2));
            }
            ((Range)active_sheet.Rows["13:13", Type.Missing]).EntireRow.AutoFit();
            ((Range)active_sheet.Rows["21:34", Type.Missing]).EntireRow.AutoFit();
            active_sheet.get_Range("Поручается", Type.Missing).set_Value(Type.Missing, dataRow["Instruction"]);
            active_sheet.get_Range("Дата_нач", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["datebegin"]).ToShortDateString());
            active_sheet.get_Range("Дата_кон", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["dateend"]).ToShortDateString());
            active_sheet.get_Range("Время_нач", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["datebegin"]).ToShortTimeString());
            active_sheet.get_Range("Время_кон", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["dateend"]).ToShortTimeString());
            ((Range)active_sheet.get_Range("Указания", Type.Missing).Rows["1:1", Type.Missing]).RowHeight = (double)((Range)active_sheet.get_Range("Указания", Type.Missing).Rows["1:1", Type.Missing]).RowHeight * (double)(dataRow["OtherInstruction"].ToString().Length / 90 + 1);
            active_sheet.get_Range("Указания", Type.Missing).set_Value(Type.Missing, active_sheet.get_Range("Указания", Type.Missing).get_Value(Type.Missing) + "  " + dataRow["OtherInstruction"]);
            active_sheet.get_Range("Выдал", Type.Missing).set_Value(Type.Missing, dataRow["outPutFIO"] + " " + ReportOrderToExcel.GetGroupElectricalWorker(Convert.ToInt32(dataRow["OutputWorker"])));
            active_sheet.get_Range("Дата_Выдал", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["dateOutput"]).ToShortDateString());
            active_sheet.get_Range("Время_Выдал", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["dateOutput"]).ToShortTimeString());
            active_sheet.get_Range("Провел", Type.Missing).set_Value(Type.Missing, dataRow["outPutFIO"]);
            if (dataRow["extFIO"] != DBNull.Value)
            {
                active_sheet.get_Range("Продлил", Type.Missing).set_Value(Type.Missing, dataRow["extFIO"]);
                if (dataRow["dateEndExt"] != DBNull.Value)
                {
                    active_sheet.get_Range("Дата_продлил", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["dateEndExt"]).ToShortDateString());
                    active_sheet.get_Range("Время_продлил", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["dateEndExt"]).ToShortTimeString());
                }
            }
            if (dataRow["headfio"] != DBNull.Value)
            {
                active_sheet.get_Range("Получил", Type.Missing).set_Value(Type.Missing, dataRow["headfio"]);
                return;
            }
            if (dataRow["makerFio"] != DBNull.Value)
            {
                active_sheet.get_Range("Получил", Type.Missing).set_Value(Type.Missing, dataRow["makerFio"]);
                return;
            }
            if (dataRow["watchFIO"] != DBNull.Value)
            {
                active_sheet.get_Range("Получил", Type.Missing).set_Value(Type.Missing, dataRow["watchFIO"]);
                return;
            }
            active_sheet.get_Range("Получил", Type.Missing).set_Value(Type.Missing, "");
        }

        private static void Edit_Sheet2(Worksheet active_sheet)
        {
            DataRow[] array = ReportOrderToExcel.dataSetOrder.vJ_Order.Select("id = " + ReportOrderToExcel.Id.ToString());
            if (array.Length == 0)
            {
                return;
            }
            DataRow dataRow = array[0];
            active_sheet.Name = "Лист" + (ReportOrderToExcel.xlw.Worksheets.Count - 2) / 2 + "-2";
            if (dataRow["headFIO"] != DBNull.Value)
            {
                active_sheet.get_Range("Ответст2", Type.Missing).set_Value(Type.Missing, dataRow["headFIO"]);
                active_sheet.get_Range("Ответст3", Type.Missing).set_Value(Type.Missing, dataRow["headFIO"]);
                active_sheet.get_Range("Ответст4", Type.Missing).set_Value(Type.Missing, dataRow["headFIO"]);
                if (dataRow["headFIO"] != DBNull.Value)
                {
                    active_sheet.get_Range("Произв5", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
                }
                active_sheet.get_Range("Произв2", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
            }
            else
            {
                active_sheet.get_Range("Ответст2", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
            }
            active_sheet.get_Range("Произв3", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
            active_sheet.get_Range("Произв4", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
            try
            {
                active_sheet.get_Range("Произв6", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
                active_sheet.get_Range("Произв7", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
            }
            catch
            {
            }
            if (dataRow["acceptFIO"].ToString() != "Опер. персонал")
            {
                active_sheet.get_Range("ДОПУСК21", Type.Missing).set_Value(Type.Missing, dataRow["acceptFIO"]);
            }
        }

        private static void Edit_tabl1(Worksheet active_sheet, int num_str)
        {
            int numRow = 21; //начало заполнения таблицы <Мероприятия по подготовке рабочих мест к выполнению работ>
            int numColumn2 = 6; // начало второй колонки
            int numColumn3 = 11; // начало третьей колонки (если есть вторая версия макета)
            int num3 = 0;
            foreach (DataRow dataRow in ReportOrderToExcel.dataSetOrder.tJ_OrderInstruction.Rows)
            {
                num3++;
                if (num3 > num_str)
                {
                    if (numRow > 22)
                    {
                        active_sheet.Activate();
                        active_sheet.get_Range("Строка", Type.Missing).Select();
                        ((Range)ReportOrderToExcel.xla.Selection).Copy(Type.Missing);
                        ((Range)active_sheet.Cells[numRow, 1]).Select();
                        ((Range)ReportOrderToExcel.xla.Selection).Insert(XlInsertShiftDirection.xlShiftDown, Type.Missing);
                    }
                    ((Range)active_sheet.Cells[numRow, 1]).set_Value(Type.Missing, dataRow["NameObj"]);
                    ((Range)active_sheet.Cells[numRow, numColumn2]).set_Value(Type.Missing, dataRow["Instruction"]);
                    if (VersionPrintMaket == 2)
                        ((Range)active_sheet.Cells[numRow, numColumn3]).set_Value(Type.Missing, dataRow["Isolated"]);
                    ((Range)active_sheet.Rows[numRow, Type.Missing]).AutoFit();
                    numRow++;
                }
                if (active_sheet.HPageBreaks.Count > 0)
                {
                    ((Range)active_sheet.Cells[numRow - 1, 1]).set_Value(Type.Missing, "Смотри следующий бланк");
                    ((Range)active_sheet.Cells[numRow - 1, numColumn2]).set_Value(Type.Missing, "");
                    if (VersionPrintMaket == 2)
                        ((Range)active_sheet.Cells[numRow - 1, numColumn3]).set_Value(Type.Missing, "");
                    ((Range)active_sheet.Rows[numRow - 1, Type.Missing]).AutoFit();
                    ((Range)active_sheet.Rows[numRow, Type.Missing]).Delete(Type.Missing);
                    if (active_sheet.HPageBreaks.Count > 0)
                    {
                        ((Range)active_sheet.Rows[numRow - 1, Type.Missing]).Delete(Type.Missing);
                        ((Range)active_sheet.Cells[numRow - 2, 1]).set_Value(Type.Missing, "Смотри следующий бланк");
                        ((Range)active_sheet.Cells[numRow - 2, numColumn2]).set_Value(Type.Missing, "");
                        if (VersionPrintMaket == 2)
                            ((Range)active_sheet.Cells[numRow - 2, numColumn3]).set_Value(Type.Missing, "");
                        ((Range)active_sheet.Rows[numRow - 2, Type.Missing]).AutoFit();
                        num_str = num3 - 1;
                    }
                    else
                    {
                        num_str = num3;
                    }
                    ((Worksheet)ReportOrderToExcel.xlw.Worksheets[1]).Copy(Type.Missing, ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count]);
                    ((Worksheet)ReportOrderToExcel.xlw.Worksheets[2]).Copy(Type.Missing, ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count]);
                    ReportOrderToExcel.Edit_Sheet1((Worksheet)ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count - 1]);
                    ReportOrderToExcel.Edit_Sheet2((Worksheet)ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count]);
                    ReportOrderToExcel.Edit_tabl1((Worksheet)ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count - 1], num_str - 1);
                    break;
                }
            }
        }

        private static void Edit_tabl2(Worksheet active_sheet, int num_str)
        {
            DataRow[] array = ReportOrderToExcel.dataSetOrder.vJ_Order.Select("id = " + ReportOrderToExcel.Id.ToString());
            if (array.Length == 0)
            {
                return;
            }
            DataRow dataRow = array[0];
            active_sheet.Activate();
            if (num_str < ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows.Count && dataRow["HeadFIO"] == DBNull.Value)
            {
                active_sheet.get_Range("Произв2", Type.Missing).set_Value(Type.Missing, ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows[num_str]["FIO"].ToString() + ReportOrderToExcel.GetJobWorker(Convert.ToInt32(ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows[num_str]["Id"])));
                num_str++;
            }
            int num = 8;
            if (dataRow["headFIO"] == DBNull.Value)
            {
                num = 7;
            }
            int i;
            for (i = 0; i < num; i++)
            {
                if (dataRow["headFIO"] == DBNull.Value)
                {
                    if (i + num_str - 1 < ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows.Count)
                    {
                        active_sheet.get_Range("бриг__" + (i + 1).ToString(), Type.Missing).set_Value(Type.Missing, ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows[num_str + i - 1]["FIO"].ToString() + ReportOrderToExcel.GetJobWorker(Convert.ToInt32(ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows[num_str + i - 1]["Id"])));
                        if (i + 1 <= num && num_str + i == ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows.Count - 1)
                        {
                            active_sheet.get_Range("бриг__" + (i + 2).ToString(), Type.Missing).set_Value(Type.Missing, ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows[num_str + i]["FIO"].ToString() + ReportOrderToExcel.GetJobWorker(Convert.ToInt32(ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows[num_str + i]["Id"])));
                        }
                    }
                }
                else if (i + num_str < ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows.Count)
                {
                    active_sheet.get_Range("бриг__" + (i + 1).ToString(), Type.Missing).set_Value(Type.Missing, ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows[num_str + i]["FIO"].ToString() + ReportOrderToExcel.GetJobWorker(Convert.ToInt32(ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows[num_str + i]["Id"])));
                }
                if (i + num_str >= ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows.Count)
                {
                    break;
                }
                active_sheet.get_Range("бриг" + (i + 1).ToString(), Type.Missing).set_Value(Type.Missing, ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows[num_str + i]["FIO"].ToString() + ReportOrderToExcel.GetJobWorker(Convert.ToInt32(ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows[num_str + i]["Id"])));
                if (dataRow["HeadFIO"] != DBNull.Value)
                {
                    active_sheet.get_Range("бриг_" + (i + 1).ToString(), Type.Missing).set_Value(Type.Missing, ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows[num_str + i]["FIO"].ToString() + ReportOrderToExcel.GetJobWorker(Convert.ToInt32(ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows[num_str + i]["Id"])));
                }
            }
            num_str += i;
            if (num_str < ReportOrderToExcel.dataSetOrder.vWorkerGroup.Rows.Count)
            {
                active_sheet.get_Range("бриг" + i.ToString(), Type.Missing).set_Value(Type.Missing, "Смотри следующий бланк");
                if (dataRow["headfio"] != DBNull.Value)
                {
                    active_sheet.get_Range("бриг_" + i.ToString(), Type.Missing).set_Value(Type.Missing, "Смотри следующий бланк");
                }
                if (dataRow["headFIO"] == DBNull.Value)
                {
                    active_sheet.get_Range("бриг__" + (i + 1).ToString(), Type.Missing).set_Value(Type.Missing, "Смотри следующий бланк");
                }
                else
                {
                    active_sheet.get_Range("бриг__" + i.ToString(), Type.Missing).set_Value(Type.Missing, "Смотри следующий бланк");
                }
                if (ReportOrderToExcel.xlw.Worksheets.Count == active_sheet.Index)
                {
                    ((Worksheet)ReportOrderToExcel.xlw.Worksheets[1]).Copy(Type.Missing, ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count]);
                    ((Worksheet)ReportOrderToExcel.xlw.Worksheets[2]).Copy(Type.Missing, ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count]);
                    ReportOrderToExcel.Edit_Sheet1((Worksheet)ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count - 1]);
                    ReportOrderToExcel.Edit_Sheet2((Worksheet)ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count]);
                    ReportOrderToExcel.Edit_tabl1((Worksheet)ReportOrderToExcel.xlw.Worksheets[ReportOrderToExcel.xlw.Worksheets.Count - 1], 100);
                }
                ReportOrderToExcel.Edit_tabl2((Worksheet)ReportOrderToExcel.xlw.Worksheets[active_sheet.Index + 2], num_str - 1);
            }
        }

        static ReportOrderToExcel()
        {
            ReportOrderToExcel.Id = -1;
        }


    }
}
