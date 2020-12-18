using DataSql;
using DailyReport.DataSets;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
/// <summary>
/// Загрузка старых данных из *.xls (Дефекты)
/// m0005d9
/// </summary>
internal class ImportOldDefectExcel
{
    private static System.Data.DataTable table;

    internal static void Load(SQLSettings sqlsettings)
    {
        table = null;
        OpenFileDialog dialog = new OpenFileDialog
        {
            Filter = "Excel Files(.xls)|*.xls|\r\n                Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm",
            Multiselect = true
        };
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            GetTableWorkerGroup(sqlsettings);
            string[] fileNames = dialog.FileNames;
            for (int i = 0; i < fileNames.Length; i++)
            {
                СollectionDataValues class2 = ReaderExcel(fileNames[i]);
                if (class2 != null)
                {
                    Save(sqlsettings, class2);
                }
            }
        }
    }

    private static void Save(SQLSettings sqlsettings, СollectionDataValues collect)
    {
        foreach (string str in collect.dictionary_0.Keys)
        {
            foreach (string str2 in collect.dictionary_0[str])
            {
                dsDamage damage = new dsDamage();
                DataRow row = damage.tJ_Damage.NewRow();
                row["TypeDoc"] = 0x57b;
                row["dateDoc"] = collect.dateTime;
                if (table != null)
                {
                    DataRow[] rowArray = table.Select("FIO like '%" + collect.string_0.Trim() + "%'");
                    if (rowArray.Length != 0)
                    {
                        row["idCompiler"] = rowArray[0]["id"];
                        row["idDivision"] = rowArray[0]["idGRoup"];
                    }
                }
                switch (str)
                {
                    case "1 СЕТЕВОЙ РАЙОН":
                        row["idDivisionApply"] = 0x597;
                        break;

                    case "2 СЕТЕВОЙ РАЙОН":
                        row["idDivisionApply"] = 0x598;
                        break;

                    case "3 СЕТЕВОЙ РАЙОН":
                        row["idDivisionApply"] = 0x599;
                        break;

                    case "4 СЕТЕВОЙ РАЙОН":
                        row["idDivisionApply"] = 0x59a;
                        break;

                    case "ПРОИЗВОДСТВЕННАЯ ЛАБОРАТОРИЯ":
                        row["isLaboratory"] = true;
                        break;
                }
                row["DivisionInstruction"] = str2.Trim();
                damage.tJ_Damage.Rows.Add(row);
                SqlDataCommand command = new SqlDataCommand(sqlsettings);
                int num = command.InsertSqlDataOneRow(damage.tJ_Damage);
                if (num > 0)
                {
                    int? nullable = null;
                    command.SelectSqlData(damage.tJ_Damage, true, "where id =" + num.ToString(), nullable, false, 0);
                    if (damage.tJ_Damage.Rows.Count > 0)
                    {
                        damage.tJ_Damage.Rows[0]["numRequest"] = damage.tJ_Damage.Rows[0]["numDoc"].ToString();
                        damage.tJ_Damage.Rows[0].EndEdit();
                        command.UpdateSqlData(damage, damage.tJ_Damage);
                    }
                }
            }
        }
    }

    private static СollectionDataValues ReaderExcel(string string_0)
    {
        DateTime? dateTime = null;
        string str = "";
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
        try
        {
            Microsoft.Office.Interop.Excel.Application application = new ApplicationClass();
            application.Visible = (true);
            Workbook workbook = application.Workbooks.Open(string_0, 0, false, 5, "", "", false, (XlPlatform)2, "", true, false, 0, true, false, false);
            try
            {
                Range range = ((Worksheet)workbook.ActiveSheet).UsedRange;
                dateTime = new DateTime?(Convert.ToDateTime((range.Cells[7, 5] as Range).get_Value(Type.Missing).ToString()));
                string str3 = "";
                int num = 12;
                while (num <= range.Rows.Count)
                {
                    List<string> list;
                    int num3;
                    if (((range.Cells[num, 2] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[num, 2] as Range).get_Value(Type.Missing).ToString()))
                    {
                        str3 = (range.Cells[num, 2] as Range).get_Value(Type.Missing).ToString();
                        if (!str3.ToUpper().Contains("РАПОРТ") || !str3.ToUpper().Contains("СОСТАВИЛ"))
                        {
                            goto Label_0346;
                        }
                        goto Label_0361;
                    }
                    if (string.IsNullOrEmpty(str3))
                    {
                        goto Label_0346;
                    }
                    if (!dictionary.ContainsKey(str3))
                    {
                        dictionary.Add(str3, new List<string>());
                    }
                    if ((range.Cells[num, 1] as Range).get_Value(Type.Missing) == null)
                    {
                        goto Label_0346;
                    }
                    string str4 = (range.Cells[num, 1] as Range).get_Value(Type.Missing).ToString();
                    if (string.IsNullOrEmpty(str4))
                    {
                        goto Label_0346;
                    }
                    if (str4.IndexOf(".") <= 0)
                    {
                        goto Label_02F1;
                    }
                    bool flag = true;
                    for (int i = 0; i < str4.IndexOf("."); i++)
                    {
                        if (!char.IsDigit(str4[i]))
                        {
                            goto Label_026C;
                        }
                    }
                    goto Label_026F;
                    Label_026C:
                    flag = false;
                    Label_026F:
                    if (flag)
                    {
                        dictionary[str3].Add(str4.Substring(str4.IndexOf(".") + 1));
                    }
                    else if (dictionary[str3].Count > 0)
                    {
                        list = dictionary[str3];
                        num3 = dictionary[str3].Count - 1;
                        list[num3] = list[num3] + str4;
                    }
                    else
                    {
                        dictionary[str3].Add(str4);
                    }
                    goto Label_0346;
                    Label_02F1:
                    if (dictionary[str3].Count > 0)
                    {
                        list = dictionary[str3];
                        num3 = dictionary[str3].Count - 1;
                        list[num3] = list[num3] + str4;
                    }
                    else
                    {
                        dictionary[str3].Add(str4);
                    }
                    Label_0346:
                    num++;
                }
                goto Label_03ED;
                Label_0361:
                if ((range.Cells[num, 5] as Range).get_Value(Type.Missing) != null)
                {
                    str = (range.Cells[num, 5] as Range).get_Value(Type.Missing).ToString();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message, string_0);
            }
            finally
            {
                workbook.Close(Type.Missing, Type.Missing, Type.Missing);
                application.Quit();
            }
        }
        catch
        {
        }
        Label_03ED:
        if (!dateTime.HasValue)
        {
            return null;
        }
        return new СollectionDataValues(dateTime.Value, str, dictionary);
    }

    private static void GetTableWorkerGroup(SQLSettings sqlsettings)
    {
        DataSet set = new DataSet();
        table = new System.Data.DataTable("vWorkerGroup");
        table.Columns.Add("id", typeof(int));
        table.Columns.Add("FIO", typeof(string));
        table.Columns.Add("idGroup", typeof(int));
        set.Tables.Add(table);
        new SqlDataCommand(sqlsettings).SelectSqlData(table, true, "where ParentKey like ';GroupWorker;DailyReport;%' and dateEnd is null order by fio ", null, false, 0);
    }

    //  private static СollectionDataValues ReaderExcel1(string A_0)
    //{
    //    DateTime? dateTime = null;
    //    string a_ = "";
    //    Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
    //    try
    //    {
    //        Microsoft.Office.Interop.Excel.Application application = new ApplicationClass();
    //        application.Visible = true;
    //        Workbook workbook = application.Workbooks.Open(A_0, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
    //        try
    //        {
    //            Range usedRange = ((Worksheet)workbook.ActiveSheet).UsedRange;
    //            string value = (usedRange.Cells[7, 5] as Range).get_Value(Type.Missing).ToString();
    //            dateTime = new DateTime?(Convert.ToDateTime(value));
    //            string text = "";
    //            for (int i = 12; i <= usedRange.Rows.Count; i++)
    //            {
    //                if ((usedRange.Cells[i, 2] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 2] as Range).get_Value(Type.Missing).ToString()))
    //                {
    //                    text = (usedRange.Cells[i, 2] as Range).get_Value(Type.Missing).ToString();
    //                    if (text.ToUpper().Contains("РАПОРТ") && text.ToUpper().Contains("СОСТАВИЛ"))
    //                    {
    //                        if ((usedRange.Cells[i, 5] as Range).get_Value(Type.Missing) != null)
    //                        {
    //                            a_ = (usedRange.Cells[i, 5] as Range).get_Value(Type.Missing).ToString();
    //                            break;
    //                        }
    //                        break;
    //                    }
    //                }
    //                else if (!string.IsNullOrEmpty(text))
    //                {
    //                    if (!dictionary.ContainsKey(text))
    //                    {
    //                        dictionary.Add(text, new List<string>());
    //                    }
    //                    if ((usedRange.Cells[i, 1] as Range).get_Value(Type.Missing) != null)
    //                    {
    //                        string text2 = (usedRange.Cells[i, 1] as Range).get_Value(Type.Missing).ToString();
    //                        if (!string.IsNullOrEmpty(text2))
    //                        {
    //                            if (text2.IndexOf(".") > 0)
    //                            {
    //                                bool flag = true;
    //                                int j = 0;
    //                                while (j < text2.IndexOf("."))
    //                                {
    //                                    if (!char.IsDigit(text2[j]))
    //                                    {
    //                                        IL_2BB:
    //                                        if (dictionary[text].Count > 0)
    //                                        {
    //                                            List<string> list = dictionary[text];
    //                                            int index = dictionary[text].Count - 1;
    //                                            list[index] += text2;
    //                                            goto IL_3BF;
    //                                        }
    //                                        dictionary[text].Add(text2);
    //                                        goto IL_3BF;
    //                                    }
    //                                    else
    //                                    {
    //                                        j++;
    //                                    }
    //                                }
    //                                if (!flag)
    //                                {
    //                                    goto IL_2BB;
    //                                }
    //                                dictionary[text].Add(text2.Substring(text2.IndexOf(".") + 1));
    //                            }
    //                            else if (dictionary[text].Count > 0)
    //                            {
    //                                List<string> list = dictionary[text];
    //                                int index = dictionary[text].Count - 1;
    //                                list[index] += text2;
    //                            }
    //                            else
    //                            {
    //                                dictionary[text].Add(text2);
    //                            }
    //                        }
    //                    }
    //                }
    //                IL_3BF:;
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            MessageBox.Show(e.Message, A_0);
    //        }
    //        finally
    //        {
    //            workbook.Close(Type.Missing, Type.Missing, Type.Missing);
    //            application.Quit();
    //        }
    //    }
    //    //catch (object arg_416_0)
    //    catch
    //    {
    //    }
    //    if (!dateTime.HasValue)
    //    {
    //        return null;
    //    }
    //    return new СollectionDataValues(dateTime.Value, a_, dictionary);
    //}
}
internal class СollectionDataValues
{
    internal DateTime dateTime = DateTime.Now;
    internal Dictionary<string, List<string>> dictionary_0 = new Dictionary<string, List<string>>();
    internal string string_0 = "";

    internal СollectionDataValues(DateTime dateTime_1, string string_1, Dictionary<string, List<string>> dictionary_1)
    {
        this.dateTime = dateTime_1;
        this.string_0 = string_1;
        this.dictionary_0 = dictionary_1;
    }
}