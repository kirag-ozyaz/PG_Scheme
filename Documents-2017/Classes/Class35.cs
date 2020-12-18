using DataSql;
using Documents.DataSets;
using FormLbr.Classes;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal static class Class35
{
    private static Application application_0;
    private static DataSetOrder dataSetOrder_0;
    private static int int_0 = -1;
    private const int int_1 = 0x2a;
    private const int int_2 = 0x59;
    private static SQLSettings sqlsettings_0;
    private const string string_0 = "Смотри следующий бланк";
    private const string string_1 = "A";
    private const string string_2 = "J";
    private const string string_3 = "K";
    private const string string_4 = "T";
    private static Workbook workbook_0;

    internal static void smethod_0(int int_3, SQLSettings sqlsettings_1)
    {
        sqlsettings_0 = sqlsettings_1;
        int_0 = int_3;
        dataSetOrder_0 = new DataSetOrder();
        SqlDataCommand command = new SqlDataCommand(sqlsettings_0);
        int? nullable = null;
        command.SelectSqlData(dataSetOrder_0.vJ_Order, true, "where id = " + int_0.ToString(), nullable, false, 0);
        nullable = null;
        command.SelectSqlData(dataSetOrder_0.vWorkerGroup, true, "", nullable, false, 0);
        nullable = null;
        command.SelectSqlData(dataSetOrder_0.tR_Classifier, true, " where parentkey = ';Other;JobTitle;' and isgroup = 0 and deleted = 0", nullable, false, 0);
        if (dataSetOrder_0.vJ_Order.Rows.Count > 0)
        {
            DataRow row = dataSetOrder_0.vJ_Order.Rows[0];
            string str2 = "";
            string str3 = smethod_3();
            object[] objArray1 = new object[] { str3, "наряд_", row["num"], "_", Convert.ToDateTime(row["dateBegin"]).Year.ToString(), "_", Environment.UserName, ".xlsx" };
            string str = string.Concat(objArray1);
            application_0 = new ApplicationClass();
            string str4 = "";
            try
            {
                str4 = smethod_1(sqlsettings_0);
            }
            catch (Exception)
            {
            }
            try
            {
                if (string.IsNullOrEmpty(str4))
                {
                    str4 = str3 + @"\шаблон.xlsx";
                }
                workbook_0 = application_0.get_Workbooks().Open(str4, 2, true, 5, "", "", true, (XlPlatform) 2, "", true, true, null, null, null, null);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
                return;
            }
            try
            {
                workbook_0.SaveAs(str, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 1, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message, exception2.Source);
                workbook_0.Close(false, Type.Missing, Type.Missing);
                application_0.Quit();
                return;
            }
            Worksheet worksheet1 = (Worksheet) workbook_0.get_Worksheets().get_Item(1);
            ((Worksheet) workbook_0.get_Worksheets().get__Default(1)).Copy(Type.Missing, workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count()));
            int num4 = 0x59;
            str2 = str2 + "$A$1:$J" + num4.ToString() + ";";
            ((Worksheet) workbook_0.get_Worksheets().get__Default(2)).get_PageSetup().set_PrintArea(str2.Remove(str2.Length - 1));
            str2 = "";
            ((Worksheet) workbook_0.get_Worksheets().get__Default(2)).Copy(Type.Missing, workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count()));
            smethod_6((Worksheet) workbook_0.get_Worksheets().get__Default(3));
            smethod_7((Worksheet) workbook_0.get_Worksheets().get__Default(4));
            nullable = null;
            command.SelectSqlData(dataSetOrder_0.tJ_OrderInstruction, true, "where idOrder = " + int_0.ToString() + " order by rec_num", nullable, false, 0);
            if (dataSetOrder_0.tJ_OrderInstruction.Rows.Count > 0)
            {
                smethod_8((Worksheet) workbook_0.get_Worksheets().get__Default(3), 0);
            }
            nullable = null;
            command.SelectSqlData(dataSetOrder_0.tJ_OrderBrigade, true, "where idOrder = " + int_0.ToString(), nullable, false, 0);
            string str5 = "";
            foreach (DataRow row2 in dataSetOrder_0.tJ_OrderBrigade.Rows)
            {
                str5 = str5 + row2["idworker"].ToString() + ",";
            }
            if (str5.Length > 0)
            {
                command.SelectSqlData(dataSetOrder_0.vWorkerGroup, true, "where id in (" + str5.Remove(str5.Length - 1) + ")", null, true, 0);
                using (IEnumerator<DataRow> enumerator2 = dataSetOrder_0.vWorkerGroup.Rows.Cast<DataRow>().GroupBy<DataRow, object>((<>c.<>9__12_0 ?? (<>c.<>9__12_0 = new Func<DataRow, object>(<>c.<>9.method_0)))).Where<IGrouping<object, DataRow>>((<>c.<>9__12_1 ?? (<>c.<>9__12_1 = new Func<IGrouping<object, DataRow>, bool>(<>c.<>9.method_1)))).SelectMany<IGrouping<object, DataRow>, DataRow>((<>c.<>9__12_2 ?? (<>c.<>9__12_2 = new Func<IGrouping<object, DataRow>, IEnumerable<DataRow>>(<>c.<>9.method_2)))).GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        enumerator2.Current.Delete();
                    }
                }
                dataSetOrder_0.vWorkerGroup.AcceptChanges();
            }
            else
            {
                dataSetOrder_0.vWorkerGroup.Clear();
            }
            if (dataSetOrder_0.vWorkerGroup.Rows.Count > 0)
            {
                smethod_9((Worksheet) workbook_0.get_Worksheets().get__Default(4), 0);
            }
            application_0.set_DisplayAlerts(false);
            ((Worksheet) workbook_0.get_Worksheets().get__Default(1)).Delete();
            ((Worksheet) workbook_0.get_Worksheets().get__Default(1)).Delete();
            application_0.set_DisplayAlerts(true);
            Worksheet worksheet = (Worksheet) workbook_0.get_Worksheets().Add(Type.Missing, workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count()), Type.Missing, Type.Missing);
            worksheet.set_Name("Для двухсторонней печати");
            int num3 = 1;
            foreach (Worksheet worksheet2 in workbook_0.get_Worksheets())
            {
                int num;
                Range range;
                if (worksheet2.get_Index() == worksheet.get_Index())
                {
                    break;
                }
                worksheet2.Activate();
                if (worksheet2.get_Name()[worksheet2.get_Name().Length - 1] == '1')
                {
                    num = worksheet2.get_UsedRange().get_Rows().get_Count();
                    worksheet2.get_Range("A1:J" + num.ToString(), Type.Missing).Copy(Type.Missing);
                }
                else
                {
                    num = 0x59;
                    worksheet2.get_Range("A1:T" + num.ToString(), Type.Missing).Copy(Type.Missing);
                }
                worksheet.Activate();
                if (worksheet2.get_Name()[worksheet2.get_Name().Length - 1] == '1')
                {
                    range = worksheet.get_Range("A" + num3.ToString(), Type.Missing);
                    string[] textArray1 = new string[6];
                    textArray1[0] = str2;
                    textArray1[1] = "$A$";
                    textArray1[2] = num3.ToString();
                    textArray1[3] = ":$J";
                    num4 = (num3 + worksheet2.get_UsedRange().get_Rows().get_Count()) - 1;
                    textArray1[4] = num4.ToString();
                    textArray1[5] = ";";
                    str2 = string.Concat(textArray1);
                }
                else
                {
                    range = worksheet.get_Range("K" + num3.ToString(), Type.Missing);
                    string[] textArray2 = new string[] { str2, "$K$", num3.ToString(), ":$T", ((num3 + 0x59) - 1).ToString(), ";" };
                    str2 = string.Concat(textArray2);
                }
                range.PasteSpecial(8, -4142, Type.Missing, Type.Missing);
                range.PasteSpecial(-4122, -4142, Type.Missing, Type.Missing);
                range.PasteSpecial(12, -4142, Type.Missing, Type.Missing);
                for (int i = 1; i <= num; i++)
                {
                    ((Range) range.get_Rows().get__Default(i, Type.Missing)).set_RowHeight(((Range) worksheet2.get_Rows().get__Default(i, Type.Missing)).get_RowHeight());
                }
                num3 = (num3 + num) + 1;
            }
            worksheet.get_PageSetup().set_PrintArea(str2.Remove(str2.Length - 1));
            try
            {
                worksheet.get_PageSetup().set_FitToPagesWide(1);
                worksheet.get_PageSetup().set_FitToPagesTall(1);
                worksheet.get_PageSetup().set_Zoom(false);
                worksheet.get_PageSetup().set_LeftMargin(application_0.CentimetersToPoints(0.9));
                worksheet.get_PageSetup().set_RightMargin(application_0.CentimetersToPoints(0.5));
                worksheet.get_PageSetup().set_TopMargin(application_0.CentimetersToPoints(0.3));
                worksheet.get_PageSetup().set_BottomMargin(application_0.CentimetersToPoints(0.3));
            }
            catch
            {
            }
            worksheet.get_Range("A1", Type.Missing).Select();
            workbook_0.Save();
            application_0.set_Visible(true);
        }
    }

    private static string smethod_1(SQLSettings sqlsettings_1)
    {
        string str;
        byte[] buffer;
        DataTable table = new SqlDataCommand(sqlsettings_1).SelectSqlData(" SELECT doc.id, doc.FileName  FROM tR_DocTemplate AS doc  INNER JOIN [tR_Classifier] AS c ON doc.idTypeDoc = c.id  WHERE c.ParentKey = ';TypeDoc;tR_DocTemplate;' AND c.Deleted = ((0)) AND c.isGroup = ((0)) AND c.Value = 5 and doc.deleted = 0");
        if (table.Rows.Count <= 0)
        {
            return "";
        }
        smethod_2(Convert.ToInt32(table.Rows[0]["id"]), out str, out buffer, sqlsettings_1);
        string extension = new FileInfo(str).Extension;
        if ((extension != ".xlt") && (extension != ".xltx"))
        {
            if ((extension != ".xls") && (extension != ".xlsx"))
            {
                return "";
            }
        }
        else
        {
            str = str.Replace(extension, extension.Replace("t", "s"));
        }
        string str3 = smethod_3();
        string str4 = FileBinary.GetNewFileNameIsExists(str3, str, true);
        new FileBinary(buffer, str4, DateTime.Now).SaveToDisk(str3);
        return (str3 + @"\" + str4);
    }

    private static void smethod_2(int int_3, out string string_5, out byte[] byte_0, SQLSettings sqlsettings_1)
    {
        string_5 = "";
        byte_0 = null;
        string cmdText = "SELECT FileName, FileData FROM tR_DocTemplate WHERE id = @idTemplate";
        using (SqlConnection connection = new SqlConnection(sqlsettings_1.GetConnectionString()))
        {
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.Parameters.Add("@idTemplate", SqlDbType.Int);
            command.Parameters["@idTemplate"].Value = int_3;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string_5 = (string) reader.GetValue(0);
                    byte_0 = (byte[]) reader.GetValue(1);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }
    }

    private static string smethod_3()
    {
        string str = @"EIS\Order";
        string path = Path.GetTempPath() + str + @"\";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        return path;
    }

    private static string smethod_4(int int_3)
    {
        DataRow[] rowArray = dataSetOrder_0.vWorkerGroup.Select("id = " + int_3.ToString());
        if (rowArray.Length != 0)
        {
            if (rowArray[0]["GroupElectrical"] == DBNull.Value)
            {
                return "";
            }
            switch (Convert.ToInt32(rowArray[0]["GroupElectrical"]))
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
            }
        }
        return "";
    }

    private static string smethod_5(int int_3)
    {
        DataRow[] rowArray = dataSetOrder_0.tJ_OrderBrigade.Select("idWorker = " + int_3.ToString());
        if ((rowArray.Length != 0) && (rowArray[0]["idJobTitle"] != DBNull.Value))
        {
            DataRow[] rowArray2 = dataSetOrder_0.tR_Classifier.Select("id = " + rowArray[0]["idJobTitle"].ToString());
            if (rowArray2.Length != 0)
            {
                return (" (" + rowArray2[0]["Name"] + ") ");
            }
        }
        return "";
    }

    private static void smethod_6(Worksheet worksheet_0)
    {
        DataRow[] rowArray = dataSetOrder_0.vJ_Order.Select("id = " + int_0.ToString());
        if (rowArray.Length != 0)
        {
            DataRow row = rowArray[0];
            worksheet_0.set_Name("Лист" + ((workbook_0.get_Worksheets().get_Count() - 2) / 2) + "-1");
            worksheet_0.get_Range("Подр", Type.Missing).set_Value(Type.Missing, row["SrName"]);
            if (Convert.ToInt32(row["num"]) >= 1)
            {
                worksheet_0.get_Range("Ном", Type.Missing).set_Value(Type.Missing, row["num"].ToString() + "-э");
            }
            if (row["headFio"] != DBNull.Value)
            {
                worksheet_0.get_Range("Ответст", Type.Missing).set_Value(Type.Missing, row["headFio"].ToString() + " " + smethod_4(Convert.ToInt32(row["headWorker"])));
            }
            else
            {
                worksheet_0.get_Range("Ответст", Type.Missing).set_Value(Type.Missing, "не назначается");
            }
            worksheet_0.get_Range("Допуск", Type.Missing).set_Value(Type.Missing, row["acceptFIO"].ToString() + " " + smethod_4(Convert.ToInt32(row["acceptWorker"])));
            worksheet_0.get_Range("Произв", Type.Missing).set_Value(Type.Missing, row["makerFio"].ToString() + " " + smethod_4(Convert.ToInt32(row["makerWorker"])));
            if (row["watchFIO"] != DBNull.Value)
            {
                worksheet_0.get_Range("Набл", Type.Missing).set_Value(Type.Missing, row["watchFIO"].ToString() + " " + smethod_4(Convert.ToInt32(row["watchWorker"])));
            }
            else
            {
                worksheet_0.get_Range("Набл", Type.Missing).set_Value(Type.Missing, "не назначается");
            }
            SqlDataCommand command = new SqlDataCommand(sqlsettings_0);
            int? nullable = null;
            command.SelectSqlData(dataSetOrder_0.tJ_OrderBrigade, true, "where idOrder = " + int_0.ToString(), nullable, false, 0);
            string str = "";
            foreach (DataRow row2 in dataSetOrder_0.tJ_OrderBrigade.Rows)
            {
                str = str + row2["idworker"].ToString() + ",";
            }
            if (str.Length > 0)
            {
                str = str.Remove(str.Length - 1);
                command.SelectSqlData(dataSetOrder_0.vR_Worker, true, "where id in (" + str + ")", null, false, 0);
                str = "";
                foreach (DataRow row3 in dataSetOrder_0.vR_Worker.Rows)
                {
                    string[] textArray1 = new string[] { str, row3["FIO"].ToString(), smethod_5(Convert.ToInt32(row3["id"])), " ", smethod_4(Convert.ToInt32(row3["id"])), ", " };
                    str = string.Concat(textArray1);
                }
                worksheet_0.get_Range("Бригада", Type.Missing).set_Value(Type.Missing, str.Remove(str.Length - 2));
            }
            ((Range) worksheet_0.get_Rows().get__Default("13:13", Type.Missing)).get_EntireRow().AutoFit();
            ((Range) worksheet_0.get_Rows().get__Default("21:34", Type.Missing)).get_EntireRow().AutoFit();
            worksheet_0.get_Range("Поручается", Type.Missing).set_Value(Type.Missing, row["Instruction"]);
            worksheet_0.get_Range("Дата_нач", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(row["datebegin"]).ToShortDateString());
            worksheet_0.get_Range("Дата_кон", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(row["dateend"]).ToShortDateString());
            worksheet_0.get_Range("Время_нач", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(row["datebegin"]).ToShortTimeString());
            worksheet_0.get_Range("Время_кон", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(row["dateend"]).ToShortTimeString());
            ((Range) worksheet_0.get_Range("Указания", Type.Missing).get_Rows().get__Default("1:1", Type.Missing)).set_RowHeight(((double) ((Range) worksheet_0.get_Range("Указания", Type.Missing).get_Rows().get__Default("1:1", Type.Missing)).get_RowHeight()) * ((row["OtherInstruction"].ToString().Length / 90) + 1));
            worksheet_0.get_Range("Указания", Type.Missing).set_Value(Type.Missing, worksheet_0.get_Range("Указания", Type.Missing).get_Value(Type.Missing) + "  " + row["OtherInstruction"]);
            worksheet_0.get_Range("Выдал", Type.Missing).set_Value(Type.Missing, row["outPutFIO"] + " " + smethod_4(Convert.ToInt32(row["OutputWorker"])));
            worksheet_0.get_Range("Дата_Выдал", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(row["dateOutput"]).ToShortDateString());
            worksheet_0.get_Range("Время_Выдал", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(row["dateOutput"]).ToShortTimeString());
            worksheet_0.get_Range("Провел", Type.Missing).set_Value(Type.Missing, row["outPutFIO"]);
            if (row["extFIO"] != DBNull.Value)
            {
                worksheet_0.get_Range("Продлил", Type.Missing).set_Value(Type.Missing, row["extFIO"]);
                if (row["dateEndExt"] != DBNull.Value)
                {
                    worksheet_0.get_Range("Дата_продлил", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(row["dateEndExt"]).ToShortDateString());
                    worksheet_0.get_Range("Время_продлил", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(row["dateEndExt"]).ToShortTimeString());
                }
            }
            if (row["headfio"] != DBNull.Value)
            {
                worksheet_0.get_Range("Получил", Type.Missing).set_Value(Type.Missing, row["headfio"]);
            }
            else if (row["makerFio"] != DBNull.Value)
            {
                worksheet_0.get_Range("Получил", Type.Missing).set_Value(Type.Missing, row["makerFio"]);
            }
            else if (row["watchFIO"] != DBNull.Value)
            {
                worksheet_0.get_Range("Получил", Type.Missing).set_Value(Type.Missing, row["watchFIO"]);
            }
            else
            {
                worksheet_0.get_Range("Получил", Type.Missing).set_Value(Type.Missing, "");
            }
        }
    }

    private static void smethod_7(Worksheet worksheet_0)
    {
        DataRow[] rowArray = dataSetOrder_0.vJ_Order.Select("id = " + int_0.ToString());
        if (rowArray.Length != 0)
        {
            DataRow row = rowArray[0];
            worksheet_0.set_Name("Лист" + ((workbook_0.get_Worksheets().get_Count() - 2) / 2) + "-2");
            if (row["headFIO"] != DBNull.Value)
            {
                worksheet_0.get_Range("Ответст2", Type.Missing).set_Value(Type.Missing, row["headFIO"]);
                worksheet_0.get_Range("Ответст3", Type.Missing).set_Value(Type.Missing, row["headFIO"]);
                worksheet_0.get_Range("Ответст4", Type.Missing).set_Value(Type.Missing, row["headFIO"]);
                if (row["headFIO"] != DBNull.Value)
                {
                    worksheet_0.get_Range("Произв5", Type.Missing).set_Value(Type.Missing, row["makerFIO"]);
                }
                worksheet_0.get_Range("Произв2", Type.Missing).set_Value(Type.Missing, row["makerFIO"]);
            }
            else
            {
                worksheet_0.get_Range("Ответст2", Type.Missing).set_Value(Type.Missing, row["makerFIO"]);
            }
            worksheet_0.get_Range("Произв3", Type.Missing).set_Value(Type.Missing, row["makerFIO"]);
            worksheet_0.get_Range("Произв4", Type.Missing).set_Value(Type.Missing, row["makerFIO"]);
            try
            {
                worksheet_0.get_Range("Произв6", Type.Missing).set_Value(Type.Missing, row["makerFIO"]);
                worksheet_0.get_Range("Произв7", Type.Missing).set_Value(Type.Missing, row["makerFIO"]);
            }
            catch
            {
            }
            if (row["acceptFIO"].ToString() != "Опер. персонал")
            {
                worksheet_0.get_Range("ДОПУСК21", Type.Missing).set_Value(Type.Missing, row["acceptFIO"]);
            }
        }
    }

    private static void smethod_8(Worksheet worksheet_0, int int_3)
    {
        int num = 0x15;
        int num2 = 6;
        int num3 = 0;
        using (IEnumerator enumerator = dataSetOrder_0.tJ_OrderInstruction.Rows.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                DataRow current = (DataRow) enumerator.Current;
                num3++;
                if (num3 > int_3)
                {
                    if (num > 0x16)
                    {
                        worksheet_0.Activate();
                        worksheet_0.get_Range("Строка", Type.Missing).Select();
                        ((Range) application_0.get_Selection()).Copy(Type.Missing);
                        ((Range) worksheet_0.get_Cells().get__Default(num, 1)).Select();
                        ((Range) application_0.get_Selection()).Insert((XlInsertShiftDirection) (-4121), Type.Missing);
                    }
                    ((Range) worksheet_0.get_Cells().get__Default(num, 1)).set_Value(Type.Missing, current["NameObj"]);
                    ((Range) worksheet_0.get_Cells().get__Default(num, num2)).set_Value(Type.Missing, current["Instruction"]);
                    ((Range) worksheet_0.get_Rows().get__Default(num, Type.Missing)).AutoFit();
                    num++;
                }
                if (worksheet_0.get_HPageBreaks().get_Count() > 0)
                {
                    goto Label_0162;
                }
            }
            return;
        Label_0162:
            ((Range) worksheet_0.get_Cells().get__Default(num - 1, 1)).set_Value(Type.Missing, "Смотри следующий бланк");
            ((Range) worksheet_0.get_Cells().get__Default(num - 1, num2)).set_Value(Type.Missing, "");
            ((Range) worksheet_0.get_Rows().get__Default(num - 1, Type.Missing)).AutoFit();
            ((Range) worksheet_0.get_Rows().get__Default(num, Type.Missing)).Delete(Type.Missing);
            if (worksheet_0.get_HPageBreaks().get_Count() > 0)
            {
                ((Range) worksheet_0.get_Rows().get__Default(num - 1, Type.Missing)).Delete(Type.Missing);
                ((Range) worksheet_0.get_Cells().get__Default(num - 2, 1)).set_Value(Type.Missing, "Смотри следующий бланк");
                ((Range) worksheet_0.get_Cells().get__Default(num - 2, num2)).set_Value(Type.Missing, "");
                ((Range) worksheet_0.get_Rows().get__Default(num - 2, Type.Missing)).AutoFit();
                int_3 = num3 - 1;
            }
            else
            {
                int_3 = num3;
            }
            ((Worksheet) workbook_0.get_Worksheets().get__Default(1)).Copy(Type.Missing, workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count()));
            ((Worksheet) workbook_0.get_Worksheets().get__Default(2)).Copy(Type.Missing, workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count()));
            smethod_6((Worksheet) workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count() - 1));
            smethod_7((Worksheet) workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count()));
            smethod_8((Worksheet) workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count() - 1), int_3 - 1);
        }
    }

    private static void smethod_9(Worksheet worksheet_0, int int_3)
    {
        int num = 1;
        DataRow[] rowArray = dataSetOrder_0.vJ_Order.Select("id = " + int_0.ToString());
        if (rowArray.Length != 0)
        {
            int num3;
            DataRow row = rowArray[0];
            worksheet_0.Activate();
            if ((int_3 < dataSetOrder_0.vWorkerGroup.Rows.Count) && (row["HeadFIO"] == DBNull.Value))
            {
                worksheet_0.get_Range("Произв2", Type.Missing).set_Value(Type.Missing, dataSetOrder_0.vWorkerGroup.Rows[int_3]["FIO"].ToString() + smethod_5(Convert.ToInt32(dataSetOrder_0.vWorkerGroup.Rows[int_3]["Id"])));
                int_3++;
            }
            int num2 = 8;
            if (row["headFIO"] == DBNull.Value)
            {
                num2 = 7;
            }
            num = 0;
            while (num < num2)
            {
                if (row["headFIO"] == DBNull.Value)
                {
                    if (((num + int_3) - 1) < dataSetOrder_0.vWorkerGroup.Rows.Count)
                    {
                        num3 = num + 1;
                        worksheet_0.get_Range("бриг__" + num3.ToString(), Type.Missing).set_Value(Type.Missing, dataSetOrder_0.vWorkerGroup.Rows[(int_3 + num) - 1]["FIO"].ToString() + smethod_5(Convert.ToInt32(dataSetOrder_0.vWorkerGroup.Rows[(int_3 + num) - 1]["Id"])));
                        if (((num + 1) <= num2) && ((int_3 + num) == (dataSetOrder_0.vWorkerGroup.Rows.Count - 1)))
                        {
                            num3 = num + 2;
                            worksheet_0.get_Range("бриг__" + num3.ToString(), Type.Missing).set_Value(Type.Missing, dataSetOrder_0.vWorkerGroup.Rows[int_3 + num]["FIO"].ToString() + smethod_5(Convert.ToInt32(dataSetOrder_0.vWorkerGroup.Rows[int_3 + num]["Id"])));
                        }
                    }
                }
                else if ((num + int_3) < dataSetOrder_0.vWorkerGroup.Rows.Count)
                {
                    num3 = num + 1;
                    worksheet_0.get_Range("бриг__" + num3.ToString(), Type.Missing).set_Value(Type.Missing, dataSetOrder_0.vWorkerGroup.Rows[int_3 + num]["FIO"].ToString() + smethod_5(Convert.ToInt32(dataSetOrder_0.vWorkerGroup.Rows[int_3 + num]["Id"])));
                }
                if ((num + int_3) >= dataSetOrder_0.vWorkerGroup.Rows.Count)
                {
                    break;
                }
                num3 = num + 1;
                worksheet_0.get_Range("бриг" + num3.ToString(), Type.Missing).set_Value(Type.Missing, dataSetOrder_0.vWorkerGroup.Rows[int_3 + num]["FIO"].ToString() + smethod_5(Convert.ToInt32(dataSetOrder_0.vWorkerGroup.Rows[int_3 + num]["Id"])));
                if (row["HeadFIO"] != DBNull.Value)
                {
                    num3 = num + 1;
                    worksheet_0.get_Range("бриг_" + num3.ToString(), Type.Missing).set_Value(Type.Missing, dataSetOrder_0.vWorkerGroup.Rows[int_3 + num]["FIO"].ToString() + smethod_5(Convert.ToInt32(dataSetOrder_0.vWorkerGroup.Rows[int_3 + num]["Id"])));
                }
                num++;
            }
            int_3 += num;
            if (int_3 < dataSetOrder_0.vWorkerGroup.Rows.Count)
            {
                worksheet_0.get_Range("бриг" + num.ToString(), Type.Missing).set_Value(Type.Missing, "Смотри следующий бланк");
                if (row["headfio"] != DBNull.Value)
                {
                    worksheet_0.get_Range("бриг_" + num.ToString(), Type.Missing).set_Value(Type.Missing, "Смотри следующий бланк");
                }
                if (row["headFIO"] == DBNull.Value)
                {
                    num3 = num + 1;
                    worksheet_0.get_Range("бриг__" + num3.ToString(), Type.Missing).set_Value(Type.Missing, "Смотри следующий бланк");
                }
                else
                {
                    worksheet_0.get_Range("бриг__" + num.ToString(), Type.Missing).set_Value(Type.Missing, "Смотри следующий бланк");
                }
                if (workbook_0.get_Worksheets().get_Count() == worksheet_0.get_Index())
                {
                    ((Worksheet) workbook_0.get_Worksheets().get__Default(1)).Copy(Type.Missing, workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count()));
                    ((Worksheet) workbook_0.get_Worksheets().get__Default(2)).Copy(Type.Missing, workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count()));
                    smethod_6((Worksheet) workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count() - 1));
                    smethod_7((Worksheet) workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count()));
                    smethod_8((Worksheet) workbook_0.get_Worksheets().get__Default(workbook_0.get_Worksheets().get_Count() - 1), 100);
                }
                smethod_9((Worksheet) workbook_0.get_Worksheets().get__Default(worksheet_0.get_Index() + 2), int_3 - 1);
            }
        }
    }

    [Serializable, CompilerGenerated]
    private sealed class <>c
    {
        public static readonly Class35.<>c <>9 = new Class35.<>c();
        public static Func<DataRow, object> <>9__12_0;
        public static Func<IGrouping<object, DataRow>, bool> <>9__12_1;
        public static Func<IGrouping<object, DataRow>, IEnumerable<DataRow>> <>9__12_2;

        internal object method_0(DataRow dataRow_0)
        {
            return dataRow_0["Id"];
        }

        internal bool method_1(IGrouping<object, DataRow> igrouping_0)
        {
            return (igrouping_0.Count<DataRow>() > 1);
        }

        internal IEnumerable<DataRow> method_2(IGrouping<object, DataRow> igrouping_0)
        {
            return igrouping_0.Skip<DataRow>(1);
        }
    }
}

