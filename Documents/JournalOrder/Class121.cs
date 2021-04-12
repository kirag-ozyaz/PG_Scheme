using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DataSql;
using FormLbr.Classes;
using Microsoft.Office.Interop.Excel;

internal static class Class121
{
	internal static void smethod_0(int int_1, SQLSettings sqlsettings_1)
	{
		Class121.sqlsettings_0 = sqlsettings_1;
		Class121.int_0 = int_1;
		Class121.class469_0 = new Class469();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(Class121.sqlsettings_0);
		sqlDataCommand.SelectSqlData(Class121.class469_0.vJ_Order, true, "where id = " + Class121.int_0.ToString(), null, false, 0);
		sqlDataCommand.SelectSqlData(Class121.class469_0.vWorkerGroup, true, "", null, false, 0);
		sqlDataCommand.SelectSqlData(Class121.class469_0.tR_Classifier, true, " where parentkey = ';Other;JobTitle;' and isgroup = 0 and deleted = 0", null, false, 0);
		if (Class121.class469_0.vJ_Order.Rows.Count <= 0)
		{
			return;
		}
		DataRow dataRow = Class121.class469_0.vJ_Order.Rows[0];
		string text = "";
		string text2 = Class121.smethod_3();
		string filename = string.Concat(new object[]
		{
			text2,
			"наряд_",
			dataRow["num"],
			"_",
			Convert.ToDateTime(dataRow["dateBegin"]).Year.ToString(),
			"_",
			Environment.UserName,
			".xlsx"
		});
		Class121.application_0 = new ApplicationClass();
		string text3 = "";
		try
		{
			text3 = Class121.smethod_1(Class121.sqlsettings_0);
		}
		catch (Exception)
		{
		}
		try
		{
			if (string.IsNullOrEmpty(text3))
			{
				text3 = text2 + "\\шаблон.xlsx";
			}
			Class121.workbook_0 = Class121.application_0.Workbooks.Open(text3, 2, true, 5, "", "", true, XlPlatform.xlWindows, "", true, true, null, null, null, null);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.Source);
			return;
		}
		try
		{
			Class121.workbook_0.SaveAs(filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
		}
		catch (Exception ex2)
		{
			MessageBox.Show(ex2.Message, ex2.Source);
			Class121.workbook_0.Close(false, Type.Missing, Type.Missing);
			Class121.application_0.Quit();
			return;
		}
		Worksheet worksheet = (Worksheet)Class121.workbook_0.Worksheets.get_Item(1);
		((Worksheet)Class121.workbook_0.Worksheets[1]).Copy(Type.Missing, Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count]);
		text = text + "$A$1:$J" + 89.ToString() + ";";
		((Worksheet)Class121.workbook_0.Worksheets[2]).PageSetup.PrintArea = text.Remove(text.Length - 1);
		text = "";
		((Worksheet)Class121.workbook_0.Worksheets[2]).Copy(Type.Missing, Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count]);
		Class121.smethod_5((Worksheet)Class121.workbook_0.Worksheets[3]);
		Class121.smethod_6((Worksheet)Class121.workbook_0.Worksheets[4]);
		sqlDataCommand.SelectSqlData(Class121.class469_0.tJ_OrderInstruction, true, "where idOrder = " + Class121.int_0.ToString() + " order by rec_num", null, false, 0);
		if (Class121.class469_0.tJ_OrderInstruction.Rows.Count > 0)
		{
			Class121.smethod_7((Worksheet)Class121.workbook_0.Worksheets[3], 0);
		}
		sqlDataCommand.SelectSqlData(Class121.class469_0.tJ_OrderBrigade, true, "where idOrder = " + Class121.int_0.ToString(), null, false, 0);
		string text4 = "";
		foreach (object obj in Class121.class469_0.tJ_OrderBrigade.Rows)
		{
			DataRow dataRow2 = (DataRow)obj;
			text4 = text4 + dataRow2["idworker"].ToString() + ",";
		}
		if (text4.Length > 0)
		{
			text4 = text4.Remove(text4.Length - 1);
			sqlDataCommand.SelectSqlData(Class121.class469_0.vWorkerGroup, true, "where id in (" + text4 + ")", null, true, 0);
			foreach (DataRow dataRow3 in (from DataRow row in Class121.class469_0.vWorkerGroup.Rows
			group row by row["Id"] into g
			where g.Count<DataRow>() > 1
			select g).SelectMany((IGrouping<object, DataRow> g) => g.Skip(1)))
			{
				dataRow3.Delete();
			}
			Class121.class469_0.vWorkerGroup.AcceptChanges();
		}
		else
		{
			Class121.class469_0.vWorkerGroup.Clear();
		}
		if (Class121.class469_0.vWorkerGroup.Rows.Count > 0)
		{
			Class121.smethod_8((Worksheet)Class121.workbook_0.Worksheets[4], 0);
		}
		Class121.application_0.DisplayAlerts = false;
		((Worksheet)Class121.workbook_0.Worksheets[1]).Delete();
		((Worksheet)Class121.workbook_0.Worksheets[1]).Delete();
		Class121.application_0.DisplayAlerts = true;
		Worksheet worksheet2 = (Worksheet)Class121.workbook_0.Worksheets.Add(Type.Missing, Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count], Type.Missing, Type.Missing);
		worksheet2.Name = "Для двухсторонней печати";
		int num = 1;
		foreach (object obj2 in Class121.workbook_0.Worksheets)
		{
			Worksheet worksheet3 = (Worksheet)obj2;
			if (worksheet3.Index == worksheet2.Index)
			{
				break;
			}
			worksheet3.Activate();
			int num2;
			if (worksheet3.Name[worksheet3.Name.Length - 1] == '1')
			{
				num2 = worksheet3.UsedRange.Rows.Count;
				worksheet3.get_Range("A1:J" + num2.ToString(), Type.Missing).Copy(Type.Missing);
			}
			else
			{
				num2 = 89;
				worksheet3.get_Range("A1:T" + num2.ToString(), Type.Missing).Copy(Type.Missing);
			}
			worksheet2.Activate();
			Range range;
			if (worksheet3.Name[worksheet3.Name.Length - 1] == '1')
			{
				range = worksheet2.get_Range("A" + num.ToString(), Type.Missing);
				text = string.Concat(new string[]
				{
					text,
					"$A$",
					num.ToString(),
					":$J",
					(num + worksheet3.UsedRange.Rows.Count - 1).ToString(),
					";"
				});
			}
			else
			{
				range = worksheet2.get_Range("K" + num.ToString(), Type.Missing);
				text = string.Concat(new string[]
				{
					text,
					"$K$",
					num.ToString(),
					":$T",
					(num + 89 - 1).ToString(),
					";"
				});
			}
			range.PasteSpecial(XlPasteType.xlPasteColumnWidths, XlPasteSpecialOperation.xlPasteSpecialOperationNone, Type.Missing, Type.Missing);
			range.PasteSpecial(XlPasteType.xlPasteFormats, XlPasteSpecialOperation.xlPasteSpecialOperationNone, Type.Missing, Type.Missing);
			range.PasteSpecial(XlPasteType.xlPasteValuesAndNumberFormats, XlPasteSpecialOperation.xlPasteSpecialOperationNone, Type.Missing, Type.Missing);
			for (int i = 1; i <= num2; i++)
			{
				((Range)range.Rows[i, Type.Missing]).RowHeight = ((Range)worksheet3.Rows[i, Type.Missing]).RowHeight;
			}
			num = num + num2 + 1;
		}
		worksheet2.PageSetup.PrintArea = text.Remove(text.Length - 1);
		try
		{
			worksheet2.PageSetup.FitToPagesWide = 1;
			worksheet2.PageSetup.FitToPagesTall = 1;
			worksheet2.PageSetup.Zoom = false;
			worksheet2.PageSetup.LeftMargin = Class121.application_0.CentimetersToPoints(0.9);
			worksheet2.PageSetup.RightMargin = Class121.application_0.CentimetersToPoints(0.5);
			worksheet2.PageSetup.TopMargin = Class121.application_0.CentimetersToPoints(0.3);
			worksheet2.PageSetup.BottomMargin = Class121.application_0.CentimetersToPoints(0.3);
		}
		catch
		{
		}
		worksheet2.get_Range("A1", Type.Missing).Select();
		Class121.workbook_0.Save();
		Class121.application_0.Visible = true;
	}

	private static string smethod_1(SQLSettings sqlsettings_1)
	{
		System.Data.DataTable dataTable = new SqlDataCommand(sqlsettings_1).SelectSqlData(" SELECT doc.id, doc.FileName  FROM tR_DocTemplate AS doc  INNER JOIN [tR_Classifier] AS c ON doc.idTypeDoc = c.id  WHERE c.ParentKey = ';TypeDoc;tR_DocTemplate;' AND c.Deleted = ((0)) AND c.isGroup = ((0)) AND c.Value = 5 and doc.deleted = 0");
		if (dataTable.Rows.Count > 0)
		{
			string text;
			byte[] inputByteArray;
			Class121.smethod_2(Convert.ToInt32(dataTable.Rows[0]["id"]), out text, out inputByteArray, sqlsettings_1);
			string extension = new System.IO.FileInfo(text).Extension;
			if (!(extension == ".xlt") && !(extension == ".xltx"))
			{
				if (!(extension == ".xls") && !(extension == ".xlsx"))
				{
					return "";
				}
			}
			else
			{
				text = text.Replace(extension, extension.Replace("t", "s"));
			}
			string text2 = Class121.smethod_3();
			string newFileNameIsExists = FileBinary.GetNewFileNameIsExists(text2, text, true);
			new FileBinary(inputByteArray, newFileNameIsExists, DateTime.Now).SaveToDisk(text2);
			return text2 + "\\" + newFileNameIsExists;
		}
		return "";
	}

	private static void smethod_2(int int_1, out string string_0, out byte[] byte_0, SQLSettings sqlsettings_1)
	{
		string_0 = "";
		byte_0 = null;
		string cmdText = "SELECT FileName, FileData FROM tR_DocTemplate WHERE id = @idTemplate";
		using (SqlConnection sqlConnection = new SqlConnection(sqlsettings_1.GetConnectionString()))
		{
			SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
			sqlCommand.Parameters.Add("@idTemplate", SqlDbType.Int);
			sqlCommand.Parameters["@idTemplate"].Value = int_1;
			try
			{
				sqlConnection.Open();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				while (sqlDataReader.Read())
				{
					string_0 = (string)sqlDataReader.GetValue(0);
					byte_0 = (byte[])sqlDataReader.GetValue(1);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}
	}

	private static string smethod_3()
	{
		string str = "EIS\\Order";
		string text = Path.GetTempPath() + str + "\\";
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return text;
	}

	private static string GxCoaTweyMN(int int_1)
	{
		DataRow[] array = Class121.class469_0.vWorkerGroup.Select("id = " + int_1.ToString());
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

	private static string smethod_4(int int_1)
	{
		DataRow[] array = Class121.class469_0.tJ_OrderBrigade.Select("idWorker = " + int_1.ToString());
		if (array.Length != 0 && array[0]["idJobTitle"] != DBNull.Value)
		{
			DataRow[] array2 = Class121.class469_0.tR_Classifier.Select("id = " + array[0]["idJobTitle"].ToString());
			if (array2.Length != 0)
			{
				return " (" + array2[0]["Name"] + ") ";
			}
		}
		return "";
	}

	private static void smethod_5(Worksheet worksheet_0)
	{
		DataRow[] array = Class121.class469_0.vJ_Order.Select("id = " + Class121.int_0.ToString());
		if (array.Length == 0)
		{
			return;
		}
		DataRow dataRow = array[0];
		worksheet_0.Name = "Лист" + (Class121.workbook_0.Worksheets.Count - 2) / 2 + "-1";
		worksheet_0.get_Range("Подр", Type.Missing).set_Value(Type.Missing, dataRow["SrName"]);
		if (Convert.ToInt32(dataRow["num"]) >= 1)
		{
			worksheet_0.get_Range("Ном", Type.Missing).set_Value(Type.Missing, dataRow["num"].ToString() + "-э");
		}
		if (dataRow["headFio"] != DBNull.Value)
		{
			worksheet_0.get_Range("Ответст", Type.Missing).set_Value(Type.Missing, dataRow["headFio"].ToString() + " " + Class121.GxCoaTweyMN(Convert.ToInt32(dataRow["headWorker"])));
		}
		else
		{
			worksheet_0.get_Range("Ответст", Type.Missing).set_Value(Type.Missing, "не назначается");
		}
		worksheet_0.get_Range("Допуск", Type.Missing).set_Value(Type.Missing, dataRow["acceptFIO"].ToString() + " " + Class121.GxCoaTweyMN(Convert.ToInt32(dataRow["acceptWorker"])));
		worksheet_0.get_Range("Произв", Type.Missing).set_Value(Type.Missing, dataRow["makerFio"].ToString() + " " + Class121.GxCoaTweyMN(Convert.ToInt32(dataRow["makerWorker"])));
		if (dataRow["watchFIO"] != DBNull.Value)
		{
			worksheet_0.get_Range("Набл", Type.Missing).set_Value(Type.Missing, dataRow["watchFIO"].ToString() + " " + Class121.GxCoaTweyMN(Convert.ToInt32(dataRow["watchWorker"])));
		}
		else
		{
			worksheet_0.get_Range("Набл", Type.Missing).set_Value(Type.Missing, "не назначается");
		}
		SqlDataCommand sqlDataCommand = new SqlDataCommand(Class121.sqlsettings_0);
		sqlDataCommand.SelectSqlData(Class121.class469_0.tJ_OrderBrigade, true, "where idOrder = " + Class121.int_0.ToString(), null, false, 0);
		string text = "";
		foreach (object obj in Class121.class469_0.tJ_OrderBrigade.Rows)
		{
			DataRow dataRow2 = (DataRow)obj;
			text = text + dataRow2["idworker"].ToString() + ",";
		}
		if (text.Length > 0)
		{
			text = text.Remove(text.Length - 1);
			sqlDataCommand.SelectSqlData(Class121.class469_0.vR_Worker, true, "where id in (" + text + ")", null, false, 0);
			text = "";
			foreach (object obj2 in Class121.class469_0.vR_Worker.Rows)
			{
				DataRow dataRow3 = (DataRow)obj2;
				text = string.Concat(new string[]
				{
					text,
					dataRow3["FIO"].ToString(),
					Class121.smethod_4(Convert.ToInt32(dataRow3["id"])),
					" ",
					Class121.GxCoaTweyMN(Convert.ToInt32(dataRow3["id"])),
					", "
				});
			}
			worksheet_0.get_Range("Бригада", Type.Missing).set_Value(Type.Missing, text.Remove(text.Length - 2));
		}
		((Range)worksheet_0.Rows["13:13", Type.Missing]).EntireRow.AutoFit();
		((Range)worksheet_0.Rows["21:34", Type.Missing]).EntireRow.AutoFit();
		worksheet_0.get_Range("Поручается", Type.Missing).set_Value(Type.Missing, dataRow["Instruction"]);
		worksheet_0.get_Range("Дата_нач", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["datebegin"]).ToShortDateString());
		worksheet_0.get_Range("Дата_кон", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["dateend"]).ToShortDateString());
		worksheet_0.get_Range("Время_нач", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["datebegin"]).ToShortTimeString());
		worksheet_0.get_Range("Время_кон", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["dateend"]).ToShortTimeString());
		((Range)worksheet_0.get_Range("Указания", Type.Missing).Rows["1:1", Type.Missing]).RowHeight = (double)((Range)worksheet_0.get_Range("Указания", Type.Missing).Rows["1:1", Type.Missing]).RowHeight * (double)(dataRow["OtherInstruction"].ToString().Length / 90 + 1);
		worksheet_0.get_Range("Указания", Type.Missing).set_Value(Type.Missing, worksheet_0.get_Range("Указания", Type.Missing).get_Value(Type.Missing) + "  " + dataRow["OtherInstruction"]);
		worksheet_0.get_Range("Выдал", Type.Missing).set_Value(Type.Missing, dataRow["outPutFIO"] + " " + Class121.GxCoaTweyMN(Convert.ToInt32(dataRow["OutputWorker"])));
		worksheet_0.get_Range("Дата_Выдал", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["dateOutput"]).ToShortDateString());
		worksheet_0.get_Range("Время_Выдал", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["dateOutput"]).ToShortTimeString());
		worksheet_0.get_Range("Провел", Type.Missing).set_Value(Type.Missing, dataRow["outPutFIO"]);
		if (dataRow["extFIO"] != DBNull.Value)
		{
			worksheet_0.get_Range("Продлил", Type.Missing).set_Value(Type.Missing, dataRow["extFIO"]);
			if (dataRow["dateEndExt"] != DBNull.Value)
			{
				worksheet_0.get_Range("Дата_продлил", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["dateEndExt"]).ToShortDateString());
				worksheet_0.get_Range("Время_продлил", Type.Missing).set_Value(Type.Missing, Convert.ToDateTime(dataRow["dateEndExt"]).ToShortTimeString());
			}
		}
		if (dataRow["headfio"] != DBNull.Value)
		{
			worksheet_0.get_Range("Получил", Type.Missing).set_Value(Type.Missing, dataRow["headfio"]);
			return;
		}
		if (dataRow["makerFio"] != DBNull.Value)
		{
			worksheet_0.get_Range("Получил", Type.Missing).set_Value(Type.Missing, dataRow["makerFio"]);
			return;
		}
		if (dataRow["watchFIO"] != DBNull.Value)
		{
			worksheet_0.get_Range("Получил", Type.Missing).set_Value(Type.Missing, dataRow["watchFIO"]);
			return;
		}
		worksheet_0.get_Range("Получил", Type.Missing).set_Value(Type.Missing, "");
	}

	private static void smethod_6(Worksheet worksheet_0)
	{
		DataRow[] array = Class121.class469_0.vJ_Order.Select("id = " + Class121.int_0.ToString());
		if (array.Length == 0)
		{
			return;
		}
		DataRow dataRow = array[0];
		worksheet_0.Name = "Лист" + (Class121.workbook_0.Worksheets.Count - 2) / 2 + "-2";
		if (dataRow["headFIO"] != DBNull.Value)
		{
			worksheet_0.get_Range("Ответст2", Type.Missing).set_Value(Type.Missing, dataRow["headFIO"]);
			worksheet_0.get_Range("Ответст3", Type.Missing).set_Value(Type.Missing, dataRow["headFIO"]);
			worksheet_0.get_Range("Ответст4", Type.Missing).set_Value(Type.Missing, dataRow["headFIO"]);
			if (dataRow["headFIO"] != DBNull.Value)
			{
				worksheet_0.get_Range("Произв5", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
			}
			worksheet_0.get_Range("Произв2", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
		}
		else
		{
			worksheet_0.get_Range("Ответст2", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
		}
		worksheet_0.get_Range("Произв3", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
		worksheet_0.get_Range("Произв4", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
		try
		{
			worksheet_0.get_Range("Произв6", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
			worksheet_0.get_Range("Произв7", Type.Missing).set_Value(Type.Missing, dataRow["makerFIO"]);
		}
		catch
		{
		}
		if (dataRow["acceptFIO"].ToString() != "Опер. персонал")
		{
			worksheet_0.get_Range("ДОПУСК21", Type.Missing).set_Value(Type.Missing, dataRow["acceptFIO"]);
		}
	}

	private static void smethod_7(Worksheet worksheet_0, int int_1)
	{
		int num = 21;
		int num2 = 6;
		int num3 = 0;
		foreach (object obj in Class121.class469_0.tJ_OrderInstruction.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			num3++;
			if (num3 > int_1)
			{
				if (num > 22)
				{
					worksheet_0.Activate();
					worksheet_0.get_Range("Строка", Type.Missing).Select();
					((Range)Class121.application_0.Selection).Copy(Type.Missing);
					((Range)worksheet_0.Cells[num, 1]).Select();
					((Range)Class121.application_0.Selection).Insert(XlInsertShiftDirection.xlShiftDown, Type.Missing);
				}
				((Range)worksheet_0.Cells[num, 1]).set_Value(Type.Missing, dataRow["NameObj"]);
				((Range)worksheet_0.Cells[num, num2]).set_Value(Type.Missing, dataRow["Instruction"]);
				((Range)worksheet_0.Rows[num, Type.Missing]).AutoFit();
				num++;
			}
			if (worksheet_0.HPageBreaks.Count > 0)
			{
				((Range)worksheet_0.Cells[num - 1, 1]).set_Value(Type.Missing, "Смотри следующий бланк");
				((Range)worksheet_0.Cells[num - 1, num2]).set_Value(Type.Missing, "");
				((Range)worksheet_0.Rows[num - 1, Type.Missing]).AutoFit();
				((Range)worksheet_0.Rows[num, Type.Missing]).Delete(Type.Missing);
				if (worksheet_0.HPageBreaks.Count > 0)
				{
					((Range)worksheet_0.Rows[num - 1, Type.Missing]).Delete(Type.Missing);
					((Range)worksheet_0.Cells[num - 2, 1]).set_Value(Type.Missing, "Смотри следующий бланк");
					((Range)worksheet_0.Cells[num - 2, num2]).set_Value(Type.Missing, "");
					((Range)worksheet_0.Rows[num - 2, Type.Missing]).AutoFit();
					int_1 = num3 - 1;
				}
				else
				{
					int_1 = num3;
				}
				((Worksheet)Class121.workbook_0.Worksheets[1]).Copy(Type.Missing, Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count]);
				((Worksheet)Class121.workbook_0.Worksheets[2]).Copy(Type.Missing, Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count]);
				Class121.smethod_5((Worksheet)Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count - 1]);
				Class121.smethod_6((Worksheet)Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count]);
				Class121.smethod_7((Worksheet)Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count - 1], int_1 - 1);
				break;
			}
		}
	}

	private static void smethod_8(Worksheet worksheet_0, int int_1)
	{
		DataRow[] array = Class121.class469_0.vJ_Order.Select("id = " + Class121.int_0.ToString());
		if (array.Length == 0)
		{
			return;
		}
		DataRow dataRow = array[0];
		worksheet_0.Activate();
		if (int_1 < Class121.class469_0.vWorkerGroup.Rows.Count && dataRow["HeadFIO"] == DBNull.Value)
		{
			worksheet_0.get_Range("Произв2", Type.Missing).set_Value(Type.Missing, Class121.class469_0.vWorkerGroup.Rows[int_1]["FIO"].ToString() + Class121.smethod_4(Convert.ToInt32(Class121.class469_0.vWorkerGroup.Rows[int_1]["Id"])));
			int_1++;
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
				if (i + int_1 - 1 < Class121.class469_0.vWorkerGroup.Rows.Count)
				{
					worksheet_0.get_Range("бриг__" + (i + 1).ToString(), Type.Missing).set_Value(Type.Missing, Class121.class469_0.vWorkerGroup.Rows[int_1 + i - 1]["FIO"].ToString() + Class121.smethod_4(Convert.ToInt32(Class121.class469_0.vWorkerGroup.Rows[int_1 + i - 1]["Id"])));
					if (i + 1 <= num && int_1 + i == Class121.class469_0.vWorkerGroup.Rows.Count - 1)
					{
						worksheet_0.get_Range("бриг__" + (i + 2).ToString(), Type.Missing).set_Value(Type.Missing, Class121.class469_0.vWorkerGroup.Rows[int_1 + i]["FIO"].ToString() + Class121.smethod_4(Convert.ToInt32(Class121.class469_0.vWorkerGroup.Rows[int_1 + i]["Id"])));
					}
				}
			}
			else if (i + int_1 < Class121.class469_0.vWorkerGroup.Rows.Count)
			{
				worksheet_0.get_Range("бриг__" + (i + 1).ToString(), Type.Missing).set_Value(Type.Missing, Class121.class469_0.vWorkerGroup.Rows[int_1 + i]["FIO"].ToString() + Class121.smethod_4(Convert.ToInt32(Class121.class469_0.vWorkerGroup.Rows[int_1 + i]["Id"])));
			}
			if (i + int_1 >= Class121.class469_0.vWorkerGroup.Rows.Count)
			{
				break;
			}
			worksheet_0.get_Range("бриг" + (i + 1).ToString(), Type.Missing).set_Value(Type.Missing, Class121.class469_0.vWorkerGroup.Rows[int_1 + i]["FIO"].ToString() + Class121.smethod_4(Convert.ToInt32(Class121.class469_0.vWorkerGroup.Rows[int_1 + i]["Id"])));
			if (dataRow["HeadFIO"] != DBNull.Value)
			{
				worksheet_0.get_Range("бриг_" + (i + 1).ToString(), Type.Missing).set_Value(Type.Missing, Class121.class469_0.vWorkerGroup.Rows[int_1 + i]["FIO"].ToString() + Class121.smethod_4(Convert.ToInt32(Class121.class469_0.vWorkerGroup.Rows[int_1 + i]["Id"])));
			}
		}
		int_1 += i;
		if (int_1 < Class121.class469_0.vWorkerGroup.Rows.Count)
		{
			worksheet_0.get_Range("бриг" + i.ToString(), Type.Missing).set_Value(Type.Missing, "Смотри следующий бланк");
			if (dataRow["headfio"] != DBNull.Value)
			{
				worksheet_0.get_Range("бриг_" + i.ToString(), Type.Missing).set_Value(Type.Missing, "Смотри следующий бланк");
			}
			if (dataRow["headFIO"] == DBNull.Value)
			{
				worksheet_0.get_Range("бриг__" + (i + 1).ToString(), Type.Missing).set_Value(Type.Missing, "Смотри следующий бланк");
			}
			else
			{
				worksheet_0.get_Range("бриг__" + i.ToString(), Type.Missing).set_Value(Type.Missing, "Смотри следующий бланк");
			}
			if (Class121.workbook_0.Worksheets.Count == worksheet_0.Index)
			{
				((Worksheet)Class121.workbook_0.Worksheets[1]).Copy(Type.Missing, Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count]);
				((Worksheet)Class121.workbook_0.Worksheets[2]).Copy(Type.Missing, Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count]);
				Class121.smethod_5((Worksheet)Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count - 1]);
				Class121.smethod_6((Worksheet)Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count]);
				Class121.smethod_7((Worksheet)Class121.workbook_0.Worksheets[Class121.workbook_0.Worksheets.Count - 1], 100);
			}
			Class121.smethod_8((Worksheet)Class121.workbook_0.Worksheets[worksheet_0.Index + 2], int_1 - 1);
		}
	}

	static Class121()
	{
		// Note: this type is marked as 'beforefieldinit'.
		Class121.int_0 = -1;
	}

	private static Microsoft.Office.Interop.Excel.Application application_0;

	private static Workbook workbook_0;

	private static int int_0;

	private static Class469 class469_0;

	private static SQLSettings sqlsettings_0;
}
