using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ExcelMacrosRun
{
	public class Substation : IDisposable
	{
		public string PasswordSheet
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		public Substation(string fileName)
		{
			Class330.Mus9JxKz1CNxy();
			this.string_0 = "aq1sw2de3";
			this.string_1 = "";
			base..ctor();
			this.application_0 = new ApplicationClass();
			this.application_0.ScreenUpdating = true;
			this.application_0.Visible = true;
			this.workbook_0 = this.application_0.Workbooks.Open("C:\\Users\\yura\\Desktop\\PASSPORT.EE.STATIONS.20141003.BKP._(v3.0.1).xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
		}

		public Substation(Application app)
		{
			Class330.Mus9JxKz1CNxy();
			this.string_0 = "aq1sw2de3";
			this.string_1 = "";
			base..ctor();
			this.application_0 = app;
			app.ScreenUpdating = true;
			app.Visible = true;
		}

		public void AddSubstation(Range rngTarget, bool blnImportMod = false, string strTypeSubstationImport = "", int lngCountRowImport = 0)
		{
			int num = rngTarget.Row;
			int column = rngTarget.Column;
			Worksheet worksheet = (Worksheet)rngTarget.Parent;
			Workbook workbook = (Workbook)worksheet.Parent;
			Worksheet worksheet2 = (Worksheet)workbook.Sheets.get__Default("Подстанции");
			Worksheet worksheet3 = (Worksheet)workbook.Sheets.get__Default("П. Расположение");
			Worksheet worksheet4 = (Worksheet)workbook.Sheets.get__Default("П. ГБП");
			Worksheet worksheet5 = (Worksheet)workbook.Sheets.get__Default("Трансформаторы");
			Worksheet worksheet6 = (Worksheet)workbook.Sheets.get__Default("Обмотки тр.");
			Worksheet worksheet7 = (Worksheet)workbook.Sheets.get__Default("Оборудование");
			Worksheet worksheet8 = (Worksheet)workbook.Sheets.get__Default("Пр. ОФ");
			Worksheet worksheet9 = (Worksheet)workbook.Sheets.get__Default("Присоединенная мощность");
			if (!blnImportMod)
			{
				this.application_0.ScreenUpdating = false;
				this.application_0.EnableEvents = false;
				this.application_0.Calculation = -4135;
			}
			foreach (string text in new string[]
			{
				"ADD_RANGE_IN_SUBSTATION_ROW_SUBSTATION_1",
				"SUBSTATION_LIST_TYPE_SUBSTATION",
				"ADD_RANGE_IN_SUBSTATION_RANGE_GBP_1",
				"Add_SubstationLoc",
				"ADD_RANGE_IN_TRANSFORMER_RANGE_SUBSTATION_1",
				"Add_Transformer",
				"AddRow_TransformerWinding_Sabstation",
				"Add_TransformerWinding_Substation",
				"ADD_RANGE_IN_OBOR_SUB_1",
				"Add_Oborud",
				"OtherFixedAssets_Add_Sabstation",
				"OtherFixedAssets_AddPoint_Sabstation",
				"ADD_RANGE_IN_Prs_Mosh_SUB_1",
				"Add_PrsMosh",
				"BoundaryPoint_AddPoint_Sabstation",
				"AddRow_BoundaryPoint_Sabstation",
				"AddRngNPrsMoshSUBDistributed_1"
			})
			{
				if (workbook.Names.Item(text, Type.Missing, Type.Missing) == null)
				{
					MessageBox.Show("Отсутствует лист \"" + text + "\".", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}
			int num2 = ((Range)workbook.Names.Item("Add_SubstationLoc", Type.Missing, Type.Missing).RefersToRange.Cells.get__Default(1, 1)).Row;
			int num3 = ((Range)workbook.Names.Item("BoundaryPoint_AddPoint_Sabstation", Type.Missing, Type.Missing).RefersToRange.Cells.get__Default(1, 1)).Row;
			int num4 = ((Range)workbook.Names.Item("Add_Transformer", Type.Missing, Type.Missing).RefersToRange.Cells.get__Default(1, 1)).Row;
			int num5 = ((Range)workbook.Names.Item("Add_TransformerWinding_Substation", Type.Missing, Type.Missing).RefersToRange.Cells.get__Default(1, 1)).Row;
			int num6 = ((Range)workbook.Names.Item("Add_Oborud", Type.Missing, Type.Missing).RefersToRange.Cells.get__Default(1, 1)).Row;
			int num7 = ((Range)workbook.Names.Item("OtherFixedAssets_AddPoint_Sabstation", Type.Missing, Type.Missing).RefersToRange.Cells.get__Default(1, 1)).Row;
			int num8 = ((Range)workbook.Names.Item("Add_PrsMosh", Type.Missing, Type.Missing).RefersToRange.Cells.get__Default(1, 1)).Row;
			if (blnImportMod && (lngCountRowImport == 0 || strTypeSubstationImport == ""))
			{
				return;
			}
			int num9;
			if (!blnImportMod)
			{
				num9 = this.fncAddRowRangeSimpleList("ADD_RANGE_IN_SUBSTATION_ROW_SUBSTATION_1", rngTarget, "SUBSTATION_LIST_TYPE_SUBSTATION", "Тип подстанции", false, true, false, "G");
			}
			else
			{
				this.method_1("ADD_RANGE_IN_SUBSTATION_ROW_SUBSTATION_1", rngTarget, lngCountRowImport, false, true, strTypeSubstationImport, "G");
				num9 = lngCountRowImport;
			}
			if (num9 == 0)
			{
				return;
			}
			string text2 = this.string_1;
			this.method_0("ADD_RANGE_IN_SUBSTATION_RANGE_GBP_1", workbook.Names.Item("Add_SubstationLoc", Type.Missing, Type.Missing).RefersToRange, false, false, false, true, num9);
			this.method_0("AddRow_BoundaryPoint_Sabstation", workbook.Names.Item("BoundaryPoint_AddPoint_Sabstation", Type.Missing, Type.Missing).RefersToRange, false, false, false, true, num9);
			this.method_0("ADD_RANGE_IN_TRANSFORMER_RANGE_SUBSTATION_1", workbook.Names.Item("Add_Transformer", Type.Missing, Type.Missing).RefersToRange, false, false, false, true, num9);
			this.method_0("AddRow_TransformerWinding_Sabstation", workbook.Names.Item("Add_TransformerWinding_Substation", Type.Missing, Type.Missing).RefersToRange, false, false, false, true, num9);
			this.method_0("ADD_RANGE_IN_OBOR_SUB_1", workbook.Names.Item("Add_Oborud", Type.Missing, Type.Missing).RefersToRange, false, false, false, true, num9);
			this.method_0("OtherFixedAssets_Add_Sabstation", workbook.Names.Item("OtherFixedAssets_AddPoint_Sabstation", Type.Missing, Type.Missing).RefersToRange, false, false, false, true, num9);
			if (text2 == "распределительный пункт")
			{
				this.method_0("AddRngNPrsMoshSUBDistributed_1", workbook.Names.Item("Add_PrsMosh", Type.Missing, Type.Missing).RefersToRange, false, false, false, true, num9);
			}
			else
			{
				this.method_0("ADD_RANGE_IN_Prs_Mosh_SUB_1", workbook.Names.Item("Add_PrsMosh", Type.Missing, Type.Missing).RefersToRange, false, false, false, true, num9);
			}
			worksheet2.Unprotect(this.string_0);
			worksheet3.Unprotect(this.string_0);
			worksheet4.Unprotect(this.string_0);
			worksheet5.Unprotect(this.string_0);
			worksheet6.Unprotect(this.string_0);
			worksheet7.Unprotect(this.string_0);
			worksheet8.Unprotect(this.string_0);
			worksheet9.Unprotect(this.string_0);
			int count = workbook.Names.Item("ADD_RANGE_IN_SUBSTATION_ROW_SUBSTATION_1", Type.Missing, Type.Missing).RefersToRange.Rows.Count;
			int count2 = workbook.Names.Item("ADD_RANGE_IN_SUBSTATION_RANGE_GBP_1", Type.Missing, Type.Missing).RefersToRange.Rows.Count;
			int count3 = workbook.Names.Item("AddRow_BoundaryPoint_Sabstation", Type.Missing, Type.Missing).RefersToRange.Rows.Count;
			int count4 = workbook.Names.Item("ADD_RANGE_IN_TRANSFORMER_RANGE_SUBSTATION_1", Type.Missing, Type.Missing).RefersToRange.Rows.Count;
			int count5 = workbook.Names.Item("AddRow_TransformerWinding_Sabstation", Type.Missing, Type.Missing).RefersToRange.Rows.Count;
			int count6 = workbook.Names.Item("ADD_RANGE_IN_OBOR_SUB_1", Type.Missing, Type.Missing).RefersToRange.Rows.Count;
			int count7 = workbook.Names.Item("OtherFixedAssets_Add_Sabstation", Type.Missing, Type.Missing).RefersToRange.Rows.Count;
			int count8;
			if (text2 == "распределительный пункт")
			{
				count8 = workbook.Names.Item("AddRngNPrsMoshSUBDistributed_1", Type.Missing, Type.Missing).RefersToRange.Rows.Count;
			}
			else
			{
				count8 = workbook.Names.Item("ADD_RANGE_IN_Prs_Mosh_SUB_1", Type.Missing, Type.Missing).RefersToRange.Rows.Count;
			}
			this.application_0.ScreenUpdating = false;
			this.application_0.EnableEvents = false;
			int num10 = num;
			while (num9 * count + num - 1 < num)
			{
				worksheet.get_Range("CA" + num10.ToString(), Type.Missing).Formula = "=///" + worksheet3.Name + "///!" + worksheet3.get_Range("CA" + num2.ToString(), Type.Missing).get_Address(0, 0, 1, Type.Missing, Type.Missing);
				worksheet.get_Range("CB" + num10.ToString(), Type.Missing).Formula = "=///" + worksheet4.Name + "///!" + worksheet3.get_Range("CA" + num3, Type.Missing).get_Address(0, 0, 1, Type.Missing, Type.Missing);
				worksheet.get_Range("CC" + num10.ToString(), Type.Missing).Formula = "=///" + worksheet5.Name + "///!" + worksheet5.get_Range("CA" + num4, Type.Missing).get_Address(0, 0, 1, Type.Missing, Type.Missing);
				worksheet.get_Range("CD" + num10.ToString(), Type.Missing).Formula = "=///" + worksheet6.Name + "///!" + worksheet6.get_Range("CA" + num5, Type.Missing).get_Address(0, 0, 1, Type.Missing, Type.Missing);
				worksheet.get_Range("CE" + num10.ToString(), Type.Missing).Formula = "=///" + worksheet7.Name + "///!" + worksheet7.get_Range("CA" + num6, Type.Missing).get_Address(0, 0, 1, Type.Missing, Type.Missing);
				worksheet.get_Range("CF" + num10.ToString(), Type.Missing).Formula = "=///" + worksheet8.Name + "///!" + worksheet8.get_Range("CA" + num7, Type.Missing).get_Address(0, 0, 1, Type.Missing, Type.Missing);
				worksheet.get_Range("CG" + num10.ToString(), Type.Missing).Formula = "=///" + worksheet9.Name + "///!" + worksheet9.get_Range("CA" + num8, Type.Missing).get_Address(0, 0, 1, Type.Missing, Type.Missing);
				worksheet3.get_Range("E" + num2, Type.Missing).NumberFormat = "general";
				worksheet3.get_Range("E" + num2, Type.Missing).Formula = "=///" + worksheet.Name + "///!E" + num10.ToString();
				worksheet3.get_Range("F" + num2, Type.Missing).Formula = string.Concat(new object[]
				{
					"=IF(",
					worksheet.Name,
					"!F",
					num10,
					"=\"\",\"\",",
					worksheet.Name,
					"!F",
					num10,
					")"
				});
				worksheet4.get_Range("E" + num3, Type.Missing).NumberFormat = "general";
				worksheet4.get_Range("E" + num3, Type.Missing).Formula = string.Concat(new object[]
				{
					"=///",
					worksheet.Name,
					"///!E",
					num10
				});
				worksheet4.get_Range("F" + num3, Type.Missing).Formula = string.Concat(new object[]
				{
					"=IF(",
					worksheet.Name,
					"!F",
					num10,
					"=\"\",\"\",",
					worksheet.Name,
					"!F",
					num10,
					")"
				});
				worksheet5.get_Range("E" + num4, Type.Missing).NumberFormat = "general";
				worksheet5.get_Range("E" + num4, Type.Missing).Formula = string.Concat(new object[]
				{
					"=///",
					worksheet.Name,
					"///!E",
					num10
				});
				worksheet5.get_Range("F" + num4, Type.Missing).Formula = string.Concat(new object[]
				{
					"=IF(",
					worksheet.Name,
					"!F",
					num10,
					"=\"\",\"\",",
					worksheet.Name,
					"!F",
					num10,
					")"
				});
				worksheet5.get_Range("DA" + (num4 + count4 - 1), Type.Missing).NumberFormat = "general";
				worksheet5.get_Range("DA" + (num4 + count4 - 1), Type.Missing).Formula = "=///" + worksheet9.Name + "///!" + worksheet9.get_Range("CA" + num8, Type.Missing).get_Address(0, 0, 1, Type.Missing, Type.Missing);
				worksheet5.get_Range("DB" + (num4 + count4 - 1), Type.Missing).NumberFormat = "general";
				worksheet5.get_Range("DB" + (num4 + count4 - 1), Type.Missing).Formula = "=///" + worksheet9.Name + "///!" + worksheet9.get_Range("CA" + (num8 + count8 - 1), Type.Missing).get_Address(0, 0, 1, Type.Missing, Type.Missing);
				worksheet5.get_Range("DC" + (num4 + count4 - 1), Type.Missing).NumberFormat = "general";
				worksheet5.get_Range("DC" + (num4 + count4 - 1), Type.Missing).set_Value(Type.Missing, text2);
				worksheet5.get_Range("DE" + (num4 + count4 - 1), Type.Missing).NumberFormat = "general";
				worksheet5.get_Range("DE" + (num4 + count4 - 1), Type.Missing).Formula = "=///" + worksheet6.Name + "///!" + worksheet6.get_Range("CA" + num5, Type.Missing).get_Address(0, 0, 1, Type.Missing, Type.Missing);
				worksheet5.get_Range("DF" + (num4 + count4 - 1), Type.Missing).NumberFormat = "general";
				worksheet5.get_Range("DF" + (num4 + count4 - 1), Type.Missing).Formula = "=///" + worksheet6.Name + "///!" + worksheet6.get_Range("CA" + (num5 + count5 - 1), Type.Missing).get_Address(0, 0, 1, Type.Missing, Type.Missing);
				worksheet5.get_Range("DH" + (num4 + count4 - 1), Type.Missing).NumberFormat = "general";
				worksheet5.get_Range("DH" + (num4 + count4 - 1), Type.Missing).Formula = string.Concat(new object[]
				{
					"=///",
					worksheet.Name,
					"///!H",
					num10
				});
				worksheet6.get_Range("E" + num5, Type.Missing).NumberFormat = "general";
				worksheet6.get_Range("E" + num5, Type.Missing).Formula = string.Concat(new object[]
				{
					"=///",
					worksheet.Name,
					"///!E",
					num10
				});
				worksheet6.get_Range("F" + num5, Type.Missing).Formula = string.Concat(new object[]
				{
					"=IF(",
					worksheet.Name,
					"!F",
					num10,
					"=\"\",\"\",",
					worksheet.Name,
					"!F",
					num10,
					")"
				});
				worksheet7.get_Range("E" + num6, Type.Missing).NumberFormat = "general";
				worksheet7.get_Range("E" + num6, Type.Missing).Formula = string.Concat(new object[]
				{
					"=///",
					worksheet.Name,
					"///!E",
					num10
				});
				worksheet7.get_Range("F" + num6, Type.Missing).Formula = string.Concat(new object[]
				{
					"=IF(",
					worksheet.Name,
					"!F",
					num10,
					"=\"\",\"\",",
					worksheet.Name,
					"!F",
					num10,
					")"
				});
				worksheet8.get_Range("E" + num7, Type.Missing).NumberFormat = "general";
				worksheet8.get_Range("E" + num7, Type.Missing).Formula = string.Concat(new object[]
				{
					"=///",
					worksheet.Name,
					"///!E",
					num10
				});
				worksheet8.get_Range("F" + num7, Type.Missing).Formula = string.Concat(new object[]
				{
					"=IF(",
					worksheet.Name,
					"!F",
					num10,
					"=\"\",\"\",",
					worksheet.Name,
					"!F",
					num10,
					")"
				});
				worksheet9.get_Range("E" + num8, Type.Missing).NumberFormat = "general";
				worksheet9.get_Range("E" + num8, Type.Missing).Formula = string.Concat(new object[]
				{
					"=///",
					worksheet.Name,
					"///!E",
					num10
				});
				worksheet9.get_Range("F" + num8, Type.Missing).Formula = string.Concat(new object[]
				{
					"=IF(",
					worksheet.Name,
					"!F",
					num10,
					"=\"\",\"\",",
					worksheet.Name,
					"!F",
					num10,
					")"
				});
				num2 += count2;
				num3 += count3;
				num4 += count4;
				num5 += count5;
				num6 += count6;
				num7 += count7;
				num8 += count8;
				num++;
			}
			worksheet.Activate();
			if (!blnImportMod)
			{
				worksheet2.Protect(this.string_0, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				worksheet3.Protect(this.string_0, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				worksheet4.Protect(this.string_0, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				worksheet5.Protect(this.string_0, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				worksheet6.Protect(this.string_0, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				worksheet7.Protect(this.string_0, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				worksheet8.Protect(this.string_0, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				worksheet9.Protect(this.string_0, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				this.application_0.EnableEvents = true;
				this.application_0.ScreenUpdating = true;
				this.application_0.Calculation = -4135;
			}
		}

		private int method_0(string string_2, Range range_0, bool bool_0 = true, bool bool_1 = true, bool bool_2 = false, bool bool_3 = false, int int_0 = 1)
		{
			if (int_0 > 0)
			{
				this.method_2(string_2, range_0, bool_0, bool_1, int_0, "0", "");
			}
			else
			{
				range_0.get_Offset(0, -1).Select();
			}
			return int_0;
		}

		private void method_1(string string_2, Range range_0, int int_0, bool bool_0 = true, bool bool_1 = true, string string_3 = "", string string_4 = "")
		{
			if (int_0 > 0 && string_3.Length > 0)
			{
				this.string_1 = string_3;
				this.method_2(string_2, range_0, bool_0, bool_1, int_0, string_3, string_4);
				return;
			}
			range_0.get_Offset(0, -1).Select();
		}

		public int fncAddRowRangeSimpleList(string strRowRamgeName, Range rngTarget, string strNameListRange, string strParamName, bool PrtoectSheet = true, bool StandartReNumber = true, bool strAdd_Row_Then_Insert = false, string strColumnInsertValue = "")
		{
			this.method_2(strRowRamgeName, rngTarget, PrtoectSheet, StandartReNumber, 1, strParamName, strColumnInsertValue);
			return 1;
		}

		private void method_2(string string_2, Range range_0, bool bool_0 = true, bool bool_1 = true, int int_0 = 1, string string_3 = "0", string string_4 = "")
		{
			Worksheet worksheet = (Worksheet)range_0.Parent;
			Workbook workbook = (Workbook)worksheet.Parent;
			Worksheet worksheet2 = (Worksheet)workbook.Sheets.get__Default(this.method_5(workbook));
			bool screenUpdating = true;
			bool enableEvents = true;
			try
			{
				worksheet.Unprotect(this.string_0);
				screenUpdating = this.application_0.ScreenUpdating;
				enableEvents = this.application_0.EnableEvents;
				this.application_0.ScreenUpdating = false;
				this.application_0.EnableEvents = false;
				int row = ((Range)range_0.Cells.get__Default(1, 1)).Row;
				int count = worksheet2.get_Range(string_2, Type.Missing).Rows.Count;
				int num = count * int_0;
				worksheet.get_Range(range_0.Row + ":" + (range_0.Row + num - 1), Type.Missing).Insert(-4121, Type.Missing);
				worksheet2.Activate();
				worksheet2.get_Range(string_2, Type.Missing).Copy(Type.Missing);
				worksheet.Activate();
				worksheet.get_Range(string.Concat(new object[]
				{
					"A",
					range_0.Row - num,
					":A",
					range_0.Row - 1
				}), Type.Missing).Select();
				((Worksheet)this.application_0.ActiveSheet).Paste(Type.Missing, Type.Missing);
				range_0.get_Offset(-num, -1).Select();
				if (!string.IsNullOrEmpty(string_4))
				{
					int num2 = 0;
					while (num / count - 1 > num2)
					{
						worksheet.get_Range(string_4 + row + num2 * count, Type.Missing).set_Value(Type.Missing, string_3);
						num2++;
					}
				}
				if (bool_1)
				{
					this.method_3((Range)this.application_0.Selection);
				}
				if (bool_0)
				{
					worksheet.Protect(this.string_0, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				}
				this.application_0.ScreenUpdating = screenUpdating;
				this.application_0.EnableEvents = enableEvents;
			}
			catch (Exception)
			{
				worksheet.Protect(this.string_0, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				this.application_0.ScreenUpdating = screenUpdating;
				this.application_0.EnableEvents = enableEvents;
			}
		}

		private string method_3(Range range_0)
		{
			string arg = "";
			int num = 0;
			if (range_0 == null)
			{
				return "";
			}
			range_0.get_Offset(-1, 0).Select();
			Range range = (Range)this.application_0.Selection;
			int num2 = 0;
			string text3;
			if (range_0.Columns.Count != range.Columns.Count)
			{
				string text = ((Range)range.Cells.get__Default(1, 1)).Formula.ToString();
				string text2 = ((Range)range.Cells.get__Default(1, 1)).get_Value(Type.Missing).ToString();
				if (text.Length == 0)
				{
					return "";
				}
				string value = ".";
				while (text2.Substring(text2.Length - num2).IndexOf(value) == 0)
				{
					num2++;
					if (text2.Length <= num2)
					{
						text3 = this.method_4(ref range_0, ref range, out text2, ref arg, ref num, ref num2);
						if (!string.IsNullOrEmpty(text3))
						{
							return text3;
						}
					}
				}
				num = Convert.ToInt32(text2.Substring(text2.Length - num2 + 1, text2.Length - num2 + 1));
				arg = text.Substring(1, text.Length - num2);
				range_0.Select();
				((Range)this.application_0.Selection).NumberFormat = "General";
				((Range)range_0.Cells.get__Default(1, 1)).set_Value(Type.Missing, arg + (num + 1));
				text3 = arg + ((Range)range_0.Cells.get__Default(1, 1)).get_Value(Type.Missing);
			}
			else
			{
				string text2;
				text3 = this.method_4(ref range_0, ref range, out text2, ref arg, ref num, ref num2);
			}
			return text3;
		}

		private string method_4(ref Range range_0, ref Range range_1, out string string_2, ref string string_3, ref int int_0, ref int int_1)
		{
			string_2 = ((Range)range_1.Cells.get__Default(1, 1)).get_Value(Type.Missing).ToString();
			if (string_2.Length == 0)
			{
				return "";
			}
			int_1 = 0;
			while (string_2.Substring(string_2.Length - int_1).IndexOf(".") == 0)
			{
				int_1++;
				if (string_2.Length <= int_1)
				{
					return this.method_4(ref range_0, ref range_1, out string_2, ref string_3, ref int_0, ref int_1);
				}
			}
			int_0 = Convert.ToInt32(string_2.Substring(string_2.Length - int_1 + 1, int_1));
			string_3 = string_2.Substring(1, string_2.Length - int_1);
			range_0.Select();
			((Range)this.application_0.Selection).NumberFormat = "@";
			((Range)range_0.Cells.get__Default(1, 1)).set_Value(Type.Missing, string_3 + (int_0 + 1));
			string result = string_3 + ((Range)range_0.Cells.get__Default(1, 1)).get_Value(Type.Missing);
			range_1 = range_1.get_Offset(1, 0);
			range_0 = range_0.get_Offset(1, 0);
			return result;
		}

		private object method_5(Workbook workbook_1)
		{
			string text = workbook_1.Names.Item("GADR_NameSheetWithBlocksAdd", Type.Missing, Type.Missing).RefersToRange.get_Value(Type.Missing).ToString();
			if (text.Replace(" ", "").Length < 0)
			{
				throw new Exception("in procedure GetDeleteSymbol of VBA Document Tl_modGADR.");
			}
			return text;
		}

		public void Dispose()
		{
			this.workbook_0 = null;
			this.application_0 = null;
		}

		private string string_0;

		private string string_1;

		private Workbook workbook_0;

		private Application application_0;
	}
}
