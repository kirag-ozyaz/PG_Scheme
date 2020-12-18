using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DataSql;
using Microsoft.Office.Interop.Excel;
/// <summary>
/// Загрузка старых данных из *.xls (Дефекты)
/// </summary>
internal class LoadOldDefect
{
    private static System.Data.DataTable table;
    internal static void Load(SQLSettings sqlsettings)
	{
		LoadOldDefect.table = null;
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Excel Files(.xls)|*.xls|\r\n                Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm";
		openFileDialog.Multiselect = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			LoadOldDefect.GetTableWorkerGroup(sqlsettings);
			string[] fileNames = openFileDialog.FileNames;
			for (int i = 0; i < fileNames.Length; i++)
			{
				СollectionDataValues collect = LoadOldDefect.ReaderExcel(fileNames[i]);
				if (collect != null)
				{
					LoadOldDefect.Save(sqlsettings, collect);
				}
			}
		}
	}

	private static void Save(SQLSettings sqlsettings, СollectionDataValues collect)
	{
		foreach (string text in collect.Dictionary.Keys)
		{
			foreach (string text2 in collect.Dictionary[text])
			{
                DailyReportN.DataSet.dsDamage ds = new DailyReportN.DataSet.dsDamage();
				DataRow dataRow = ds.tJ_Damage.NewRow();
				dataRow["TypeDoc"] = 1403;
				dataRow["dateDoc"] = collect.DateTime;
				if (LoadOldDefect.table != null)
				{
					DataRow[] array = LoadOldDefect.table.Select("FIO like '%" + collect.FIO.Trim() + "%'");
					if (array.Length != 0)
					{
						dataRow["idCompiler"] = array[0]["id"];
						dataRow["idDivision"] = array[0]["idGRoup"];
					}
				}
				if (!(text == "1 СЕТЕВОЙ РАЙОН"))
				{
					if (!(text == "2 СЕТЕВОЙ РАЙОН"))
					{
						if (!(text == "3 СЕТЕВОЙ РАЙОН"))
						{
							if (!(text == "4 СЕТЕВОЙ РАЙОН"))
							{
								if (text == "ПРОИЗВОДСТВЕННАЯ ЛАБОРАТОРИЯ")
								{
									dataRow["isLaboratory"] = true;
								}
							}
							else
							{
								dataRow["idDivisionApply"] = 1434;
							}
						}
						else
						{
							dataRow["idDivisionApply"] = 1433;
						}
					}
					else
					{
						dataRow["idDivisionApply"] = 1432;
					}
				}
				else
				{
					dataRow["idDivisionApply"] = 1431;
				}
				dataRow["DivisionInstruction"] = text2.Trim();
				ds.tJ_Damage.Rows.Add(dataRow);
				SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings);
				int idDamage = sqlDataCommand.InsertSqlDataOneRow(ds.tJ_Damage);
				if (idDamage > 0)
				{
					sqlDataCommand.SelectSqlData(ds.tJ_Damage, true, "where id =" + idDamage.ToString(), null, false, 0);
					if (ds.tJ_Damage.Rows.Count > 0)
					{
						ds.tJ_Damage.Rows[0]["numRequest"] = ds.tJ_Damage.Rows[0]["numDoc"].ToString();
						ds.tJ_Damage.Rows[0].EndEdit();
						sqlDataCommand.UpdateSqlData(ds, ds.tJ_Damage);
					}
				}
			}
		}
	}

	private static СollectionDataValues ReaderExcel(string fileNames)
	{
		DateTime? dateTime = null;
		string str = "";
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		try
		{
			Microsoft.Office.Interop.Excel.Application application = new ApplicationClass();
			application.Visible = true;
			Workbook workbook = application.Workbooks.Open(fileNames, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
			try
			{
				Range usedRange = ((Worksheet)workbook.ActiveSheet).UsedRange;
				string value = (usedRange.Cells[7, 5] as Range).get_Value(Type.Missing).ToString();
				dateTime = new DateTime?(Convert.ToDateTime(value));
				string text = "";
				for (int i = 12; i <= usedRange.Rows.Count; i++)
				{
					if ((usedRange.Cells[i, 2] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 2] as Range).get_Value(Type.Missing).ToString()))
					{
						text = (usedRange.Cells[i, 2] as Range).get_Value(Type.Missing).ToString();
						if (text.ToUpper().Contains("РАПОРТ") && text.ToUpper().Contains("СОСТАВИЛ"))
						{
							if ((usedRange.Cells[i, 5] as Range).get_Value(Type.Missing) != null)
							{
								str = (usedRange.Cells[i, 5] as Range).get_Value(Type.Missing).ToString();
							}
							break;
						}
					}
					else if (!string.IsNullOrEmpty(text))
					{
						if (!dictionary.ContainsKey(text))
						{
							dictionary.Add(text, new List<string>());
						}
						if ((usedRange.Cells[i, 1] as Range).get_Value(Type.Missing) != null)
						{
							string text2 = (usedRange.Cells[i, 1] as Range).get_Value(Type.Missing).ToString();
							if (!string.IsNullOrEmpty(text2))
							{
                                if (text2.IndexOf(".") > 0)
                                {
                                    bool flag = true;
                                    for (int j = 0; j < text2.IndexOf("."); j++)
                                    {
                                        if (!char.IsDigit(text2[j]))
                                        {
                                            flag = false;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        dictionary[text].Add(text2.Substring(text2.IndexOf(".") + 1));
                                    }
                                    else if (dictionary[text].Count > 0)
                                    {
                                        List<string> list = dictionary[text];
                                        int index = dictionary[text].Count - 1;
                                        list[index] += text2;
                                    }
                                    else
                                    {
                                        dictionary[text].Add(text2);
                                    }
                                }
                                else if (dictionary[text].Count > 0)
                                {
                                    List<string> list = dictionary[text2];
                                    int index = dictionary[text2].Count - 1;
                                    list[index] += text2;
                                }
                                else
                                {
                                    dictionary[text].Add(text2);
                                }
                                //if (text2.IndexOf(".") > 0)
                                //{
                                //	bool flag = true;
                                //	int j = 0;
                                //	while (j < text2.IndexOf("."))
                                //	{
                                //		if (char.IsDigit(text2[j]))
                                //		{
                                //			j++;
                                //		}
                                //		else
                                //		{
                                //			flag = false;
                                //			IL_26F:
                                //			if (flag)
                                //			{
                                //				dictionary[text].Add(text2.Substring(text2.IndexOf(".") + 1));
                                //				goto IL_346;//continue;
                                //                                    }
                                //			if (dictionary[text].Count > 0)
                                //			{
                                //				List<string> list = dictionary[text];
                                //				int index = dictionary[text].Count - 1;
                                //				list[index] += text2;
                                //				goto IL_346;//continue;
                                //                                    }
                                //			dictionary[text].Add(text2);
                                //			goto IL_346; //continue;
                                //		}
                                //	}
                                //	goto IL_26F;
                                //}
                                //if (dictionary[text].Count > 0)
                                //{
                                //	List<string> list = dictionary[text];
                                //	int index = dictionary[text].Count - 1;
                                //	list[index] += text2;
                                //}
                                //else
                                //{
                                //	dictionary[text].Add(text2);
                                //}
                            }
						}
					}
					//IL_346:;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, fileNames);
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
		if (dateTime == null)
		{
			return null;
		}
		return new СollectionDataValues(dateTime.Value, str, dictionary);
	}

	private static void GetTableWorkerGroup(SQLSettings sqlsettings)
	{
		DataSet dataSet = new DataSet();
		LoadOldDefect.table = new System.Data.DataTable("vWorkerGroup");
		LoadOldDefect.table.Columns.Add("id", typeof(int));
		LoadOldDefect.table.Columns.Add("FIO", typeof(string));
		LoadOldDefect.table.Columns.Add("idGroup", typeof(int));
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings);
		dataSet.Tables.Add(LoadOldDefect.table);
		sqlDataCommand.SelectSqlData(LoadOldDefect.table, true, "where ParentKey like ';GroupWorker;DailyReport;%' and dateEnd is null order by fio ", null, false, 0);
	}

	//public Class224()
	//{
	//	//
		
	//}

	
}
