using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using FormLbr;
using Microsoft.Office.Interop.Excel;

namespace Passport.Forms.PassportEE
{
	public class FormPassportEE : FormBase
	{
		public FormPassportEE()
		{
			this.method_17();
		}

		private void FormPassportEE_Load(object sender, EventArgs e)
		{
			try
			{
				this.cultureInfo_0 = Thread.CurrentThread.CurrentCulture;
				Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void FormPassportEE_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.method_0();
			Thread.CurrentThread.CurrentCulture = this.cultureInfo_0;
		}

		private void method_0()
		{
			this.workbook_0 = null;
			this.worksheet_0 = null;
			if (this.application_0 != null)
			{
				this.application_0.Quit();
			}
			this.label_2.Text = "Имя файла";
			this.method_16(false);
		}

		private Range method_1(Worksheet worksheet_1, string string_1, string string_2)
		{
			return ((Range)worksheet_1.Columns.get__Default(string_1, Type.Missing)).Find(string_2, Type.Missing, -4163, 2, 1, 1, false, Type.Missing, Type.Missing);
		}

		private void method_2(Range range_0)
		{
			this.application_0.ScreenUpdating = false;
			this.application_0.EnableEvents = false;
			range_0 = this.worksheet_0.get_Range("J" + range_0.Row, "M" + range_0.Row);
			this.application_0.Application.Run("modGlobalAddDeleteRange.AddRowRangeInSheet_Insert_N_Blocks", "ADD_RANGE_IN_TRANSFORMER_RANGE_TRANSFORMER_1", range_0, true, true, 1, range_0.get_Offset(0, -3).FormulaR1C1, "AW", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			this.application_0.ScreenUpdating = true;
			this.application_0.EnableEvents = true;
		}

		private void method_3(Workbook workbook_1)
		{
			this.worksheet_0 = (Worksheet)workbook_1.Worksheets.get__Default("Трансформаторы");
			this.worksheet_0.Activate();
			this.application_0.Visible = false;
			this.application_0.ScreenUpdating = false;
			this.application_0.EnableEvents = true;
			this.application_0.UserControl = false;
			DataTable transformer = GetData.GetTransformer();
			this.dataTable_0 = GetData.GetMaxPower();
			this.dataTable_1 = GetData.GetFactPower();
			IEnumerable<string> enumerable = transformer.AsEnumerable().GroupBy(new Func<DataRow, string>(FormPassportEE.<>c.<>9.method_0)).Select(new Func<IGrouping<string, DataRow>, string>(FormPassportEE.<>c.<>9.method_1));
			int num = 0;
			using (IEnumerator<string> enumerator = enumerable.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					FormPassportEE.Class142 @class = new FormPassportEE.Class142();
					@class.string_0 = enumerator.Current;
					Range range = this.method_1(this.worksheet_0, "H", @class.string_0);
					if (range != null)
					{
						EnumerableRowCollection<DataRow> enumerableRowCollection = transformer.AsEnumerable().Where(new Func<DataRow, bool>(@class.method_0));
						int num2 = 0;
						int int_ = Convert.ToInt32(this.worksheet_0.get_Range("E" + range.Row, Type.Missing).Value2);
						foreach (DataRow dataRow_ in enumerableRowCollection)
						{
							Range range2 = range.get_Offset(2 + num2 * 5, 2);
							this.method_2(range2);
							range2 = range2.get_Offset(-3, 3);
							this.string_0 = @class.string_0;
							this.int_0 = enumerableRowCollection.Count<DataRow>();
							this.method_6(range2, dataRow_, int_, this.int_0);
							num2++;
						}
					}
					Control control = this.label_0;
					int num3;
					num = (num3 = num + 1);
					control.Text = num3.ToString() + " из " + enumerable.Count<string>();
					Application.DoEvents();
				}
			}
			this.application_0.Visible = true;
			this.application_0.ScreenUpdating = true;
			this.application_0.EnableEvents = true;
			this.application_0.UserControl = true;
		}

		private void method_4(Range range_0, int int_1, int int_2)
		{
			bool screenUpdating = this.application_0.ScreenUpdating;
			bool enableEvents = this.application_0.EnableEvents;
			bool userControl = this.application_0.UserControl;
			Worksheet worksheet = (Worksheet)range_0.Parent;
			Workbook workbook = (Workbook)worksheet.Parent;
			Worksheet worksheet2 = (Worksheet)workbook.Worksheets.get__Default("Присоединенная мощность");
			int row = range_0.Row;
			int column = range_0.Column;
			int count = range_0.Columns.Count;
			int count2 = range_0.Rows.Count;
			this.application_0.ScreenUpdating = false;
			this.application_0.EnableEvents = false;
			worksheet.Unprotect("5b7b5b1b3b7b1");
			foreach (object obj in range_0)
			{
				Range range = (Range)obj;
				if (((Range)range.Cells.get__Default(1, 1)).Column == 11 && range.Row > 19 && range.Row < workbook.Names.Item("end_03", Type.Missing, Type.Missing).RefersToRange.Row)
				{
					if (((Range)range.Cells.get__Default(1, 1)).get_Value(Type.Missing).ToString() == "нет")
					{
						if (worksheet.get_Range("BA" + range.Row.ToString(), Type.Missing).get_Value(Type.Missing) == null || worksheet.get_Range("BA" + range.Row.ToString(), Type.Missing).get_Value(Type.Missing).ToString().Length == 0)
						{
							Range range2 = ((Range)worksheet2.Columns.get__Default("E", Type.Missing)).Cells.Find(int_1.ToString(), Type.Missing, -4163, 2, 1, 1, false, Type.Missing, Type.Missing);
							if (range2 != null)
							{
								FormPassportEE.Class143 @class = new FormPassportEE.Class143();
								@class.string_0 = worksheet2.get_Range("H" + range2.Row.ToString(), Type.Missing).Value2.ToString();
								@class.string_0 = @class.string_0.Remove(0, 3);
								if (range2.Value2.ToString() == int_1.ToString())
								{
									FormPassportEE.Class144 class2 = new FormPassportEE.Class144();
									class2.class143_0 = @class;
									class2.int_0 = Convert.ToInt32(worksheet.get_Range("I" + range.Row.ToString(), Type.Missing).Value2);
									EnumerableRowCollection<DataRow> source = this.dataTable_1.AsEnumerable().Where(new Func<DataRow, bool>(class2.method_0));
									double value = (source.Count<DataRow>() > 0) ? Math.Round((double)source.First<DataRow>().Field("tok") * 0.61661008749452029, 1) : 0.0;
									EnumerableRowCollection<DataRow> source2 = this.dataTable_0.AsEnumerable().Where(new Func<DataRow, bool>(class2.class143_0.method_0));
									double num = (source2.Count<DataRow>() > 0) ? (source2.First<DataRow>().Field("powerset") / (double)(int_2 * 1000)) : 0.0;
									int num2 = Convert.ToInt32(worksheet2.get_Range("AH" + range2.Row, Type.Missing).get_Value(Type.Missing));
									int count3 = workbook.Names.Item("ADD_RANGE_IN_Prs_Mosh_2", Type.Missing, Type.Missing).RefersToRange.Rows.Count;
									this.application_0.Application.Run("modGlobalAddDeleteRange.AddRowRangeInSheet_Insert", "ADD_RANGE_IN_Prs_Mosh_2", worksheet2.get_Range("K" + num2.ToString(), Type.Missing), false, true, false, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
									worksheet.Unprotect("5b7b5b1b3b7b1");
									worksheet2.Unprotect("5b7b5b1b3b7b1");
									this.application_0.Run("modGlobalAddDeleteRange.ConnectTwoRangeTwoSheets", worksheet.get_Range("BA" + range.Row.ToString(), Type.Missing), worksheet2.get_Range("BA" + num2.ToString(), Type.Missing), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
									string formula = string.Concat(new object[]
									{
										"=",
										worksheet.Name,
										"!I",
										range.Row
									});
									worksheet2.get_Range("I" + num2, Type.Missing).Formula = formula;
									Range range3 = worksheet2.get_Range("J" + (num2 + 1).ToString(), Type.Missing);
									formula = string.Concat(new string[]
									{
										"=",
										worksheet.Name,
										"!L",
										range.Row.ToString(),
										"&\" Марка:\"&",
										worksheet.Name,
										"!M",
										range.Row.ToString()
									});
									range3.Formula = formula;
									Range range4 = worksheet2.get_Range("K" + (num2 + 1).ToString(), Type.Missing);
									formula = string.Concat(new string[]
									{
										"=",
										worksheet.Name,
										"!R",
										range.Row.ToString(),
										"/1000"
									});
									range4.Formula = formula;
									worksheet2.get_Range("L" + (num2 + 1), Type.Missing).Value2 = Convert.ToDouble(value) / 1000.0;
									worksheet2.get_Range("M" + (num2 + 1), Type.Missing).Value2 = num;
									break;
								}
							}
						}
					}
					else
					{
						worksheet.Unprotect("5b7b5b1b3b7b1");
						this.application_0.Run("mod_03.DelleteRowSubstationForAllSheet", worksheet, worksheet2, "BA", range, "H", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
						worksheet.Protect("5b7b5b1b3b7b1", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
						worksheet2.Protect("5b7b5b1b3b7b1", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					}
				}
			}
			worksheet2.Protect("5b7b5b1b3b7b1", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			worksheet.Protect("5b7b5b1b3b7b1", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			worksheet.Activate();
			this.application_0.ScreenUpdating = screenUpdating;
			this.application_0.EnableEvents = enableEvents;
			GC.Collect();
		}

		private bool method_5(Workbook workbook_1, string string_1)
		{
			Name name = workbook_1.Names.Item(string_1, Type.Missing, Type.Missing);
			return name != null || name.RefersTo.ToString().Length <= 0 || string_1.IndexOf('#') <= 0;
		}

		private void method_6(Range range_0, DataRow dataRow_0, int int_1, int int_2)
		{
			range_0.get_Offset(0, -5).Value2 = "нет";
			this.method_4(range_0.get_Offset(0, -5), int_1, int_2);
			range_0.Select();
			range_0.set_Value(Type.Missing, 2);
			if (dataRow_0.Field("Наименование") != "")
			{
				range_0.get_Offset(0, -4).set_Value(Type.Missing, dataRow_0.Field("Наименование").Replace("-", ""));
			}
			if (dataRow_0.Field("Тип") != "")
			{
				range_0.get_Offset(0, -3).set_Value(Type.Missing, dataRow_0.Field("Тип"));
			}
			if (dataRow_0.Field("Мощность") != "")
			{
				range_0.get_Offset(0, 2).set_Value(Type.Missing, dataRow_0.Field("Мощность"));
			}
			if (dataRow_0.Field("Высокое напряжение") != "")
			{
				this.worksheet_0.get_Range("X" + (range_0.Row + 2).ToString(), Type.Missing).set_Value(Type.Missing, dataRow_0.Field("Высокое напряжение"));
			}
			if (dataRow_0.Field("Низкое напряжение") != "")
			{
				this.worksheet_0.get_Range("X" + (range_0.Row + 3).ToString(), Type.Missing).set_Value(Type.Missing, dataRow_0.Field("Низкое напряжение"));
			}
			if (dataRow_0.Field("Заводской номер") != "")
			{
				range_0.get_Offset(0, 19).set_Value(Type.Missing, dataRow_0.Field("Заводской номер"));
			}
			if (dataRow_0.Field("Завод-изготовитель") != "")
			{
				range_0.get_Offset(0, 20).set_Value(Type.Missing, dataRow_0.Field("Завод-изготовитель"));
			}
			if (dataRow_0.Field("Год изготовления") != "")
			{
				range_0.get_Offset(0, 21).set_Value(Type.Missing, dataRow_0.Field("Год изготовления"));
			}
			if (dataRow_0.Field("Дата ремонта") != "")
			{
				range_0.get_Offset(0, 23).set_Value(Type.Missing, dataRow_0.Field("Дата ремонта"));
			}
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			this.method_3(this.workbook_0);
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			this.method_7(this.worksheet_0);
		}

		private void method_7(Worksheet worksheet_1)
		{
			worksheet_1 = (Worksheet)this.workbook_0.Worksheets.get__Default("Оборудование");
			worksheet_1.Activate();
			this.application_0.Visible = false;
			this.application_0.ScreenUpdating = false;
			this.application_0.EnableEvents = true;
			this.application_0.UserControl = false;
			DataTable equipment = GetData.GetEquipment();
			IEnumerable<string> enumerable = equipment.AsEnumerable().GroupBy(new Func<DataRow, string>(FormPassportEE.<>c.<>9.method_2)).Select(new Func<IGrouping<string, DataRow>, string>(FormPassportEE.<>c.<>9.method_3));
			int num = 0;
			using (IEnumerator<string> enumerator = enumerable.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					FormPassportEE.Class145 @class = new FormPassportEE.Class145();
					@class.string_0 = enumerator.Current;
					Range range = this.method_1(worksheet_1, "H", @class.string_0);
					if (range != null)
					{
						EnumerableRowCollection<DataRow> enumerableRowCollection = equipment.AsEnumerable().Where(new Func<DataRow, bool>(@class.method_0));
						int num2 = 0;
						foreach (DataRow dataRow_ in enumerableRowCollection)
						{
							Range range_ = range.get_Offset(2 + num2, 2);
							this.method_9(range_);
							this.method_8(range_, dataRow_);
							num2++;
						}
					}
					Control control = this.label_0;
					int num3;
					num = (num3 = num + 1);
					control.Text = num3.ToString() + " из " + enumerable.Count<string>();
					Application.DoEvents();
				}
			}
			this.application_0.Visible = true;
			this.application_0.ScreenUpdating = true;
			this.application_0.EnableEvents = true;
			this.application_0.UserControl = true;
		}

		private void method_8(Range range_0, DataRow dataRow_0)
		{
			range_0.get_Offset(-1, 0).Value2 = dataRow_0.Field("equipment");
			if (range_0.get_Offset(-1, 0).Value2.ToString() == "выключатели")
			{
				range_0.get_Offset(-1, 1).Value2 = dataRow_0.Field("typeequipment");
			}
			range_0.get_Offset(-1, 2).Value2 = Math.Round(dataRow_0.Field("value"), 1);
			range_0.get_Offset(-1, 3).Value2 = dataRow_0.Field("count");
		}

		private void method_9(Range range_0)
		{
			if (((Range)range_0.Cells.get__Default(1, 1)).get_Value(Type.Missing).ToString() == "+ Добавить тип оборудование")
			{
				this.application_0.EnableEvents = false;
				this.application_0.Application.Run("modGlobalAddDeleteRange.AddRowRangeInSheet_Insert_N_Blocks", "ADD_RANGE_IN_OBOR_1", range_0, true, true, 1, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				this.application_0.EnableEvents = true;
			}
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			this.method_10(this.worksheet_0);
		}

		private void method_10(Worksheet worksheet_1)
		{
			worksheet_1 = (Worksheet)this.workbook_0.Worksheets.get__Default("П. Расположение");
			worksheet_1.Activate();
			this.application_0.Visible = false;
			this.application_0.ScreenUpdating = false;
			this.application_0.EnableEvents = true;
			this.application_0.UserControl = false;
			DataTable substation = GetData.GetSubstation();
			int num = 0;
			foreach (object obj in substation.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				Range range = this.method_1(worksheet_1, "F", dataRow["Наименование"].ToString());
				if (range != null)
				{
					range.get_Offset(0, 21).Value2 = "адрес";
					worksheet_1.get_Range("AB" + (range.Row + 1).ToString(), Type.Missing).Value2 = "город Ульяновск";
					worksheet_1.get_Range("AC" + (range.Row + 1).ToString(), Type.Missing).Value2 = "город Ульяновск";
					worksheet_1.get_Range("AE" + (range.Row + 1).ToString(), Type.Missing).Value2 = dataRow["Тип региона"].ToString();
					worksheet_1.get_Range("AF" + (range.Row + 1).ToString(), Type.Missing).Value2 = dataRow["Регион"].ToString();
					worksheet_1.get_Range("AG" + (range.Row + 1).ToString(), Type.Missing).Value2 = dataRow["Тип улицы"].ToString();
					worksheet_1.get_Range("AH" + (range.Row + 1).ToString(), Type.Missing).Value2 = dataRow["Улица"].ToString();
					worksheet_1.get_Range("AI" + (range.Row + 1).ToString(), Type.Missing).Value2 = dataRow["Дом"].ToString();
				}
				num++;
				Control control = this.label_0;
				int num2;
				num = (num2 = num + 1);
				control.Text = num2.ToString() + " из " + substation.Rows.Count;
				Application.DoEvents();
			}
			this.application_0.Visible = true;
			this.application_0.ScreenUpdating = true;
			this.application_0.EnableEvents = true;
			this.application_0.UserControl = true;
		}

		private void button_5_Click(object sender, EventArgs e)
		{
			this.worksheet_0 = (Worksheet)this.workbook_0.Worksheets.get__Default("Трансформаторы");
			this.worksheet_0.Activate();
			this.worksheet_0.Unprotect("5b7b5b1b3b7b1");
			Range range = this.worksheet_0.get_Range("L20", "L10002");
			for (int i = 20; i < 10005; i++)
			{
				this.worksheet_0.get_Range("L" + i, Type.Missing).Select();
				if (this.worksheet_0.get_Range("L" + i, Type.Missing).Value2.ToString() != "" && this.worksheet_0.get_Range("L" + i, Type.Missing).Value2 != null)
				{
					if (this.worksheet_0.get_Range("AL" + i, Type.Missing).Value2 != null && this.worksheet_0.get_Range("AL" + i, Type.Missing).Value2.ToString().LastIndexOf(".") > 0)
					{
						string text = this.worksheet_0.get_Range("AL" + i, Type.Missing).Value2.ToString();
						this.worksheet_0.get_Range("AL" + i, Type.Missing).Value2 = text.Remove(0, text.LastIndexOf(".") + 1);
					}
					if (this.worksheet_0.get_Range("AE" + i, Type.Missing).Value2 == null)
					{
						this.worksheet_0.get_Range("AE" + i, Type.Missing).Value2 = 0;
					}
					if (this.worksheet_0.get_Range("AF" + i, Type.Missing).Value2 == null)
					{
						this.worksheet_0.get_Range("AF" + i, Type.Missing).Value2 = 0;
					}
					if (this.worksheet_0.get_Range("AN" + i, Type.Missing).Value2 == null)
					{
						this.worksheet_0.get_Range("AN" + i, Type.Missing).Value2 = "нет";
					}
				}
			}
			this.worksheet_0.Protect("5b7b5b1b3b7b1", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
		}

		private void button_6_Click(object sender, EventArgs e)
		{
			this.worksheet_0 = (Worksheet)this.workbook_0.Worksheets.get__Default("Присоединенная мощность");
			this.worksheet_0.Activate();
			this.application_0.Visible = false;
			this.application_0.ScreenUpdating = false;
			this.application_0.EnableEvents = true;
			this.application_0.UserControl = false;
			DataTable connectedPower = GetData.GetConnectedPower();
			List<TransfContract> list = new List<TransfContract>();
			foreach (object obj in connectedPower.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				list.Add(new TransfContract(dataRow["Substation"].ToString(), dataRow["Dogovor"].ToString(), dataRow["dateBegin"].ToString(), dataRow["dateEnd"].ToString(), dataRow["Company"].ToString(), dataRow["MaxPower"].ToString(), ""));
			}
			IEnumerable<Class0<string>> enumerable = list.GroupBy(new Func<TransfContract, string>(FormPassportEE.<>c.<>9.method_4)).Select(new Func<IGrouping<string, TransfContract>, Class0<string>>(FormPassportEE.<>c.<>9.method_5));
			int num = enumerable.Count<Class0<string>>();
			int num2 = 0;
			using (IEnumerator<Class0<string>> enumerator2 = enumerable.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					FormPassportEE.Class146 @class = new FormPassportEE.Class146();
					@class.class0_0 = enumerator2.Current;
					Range range = this.method_1(this.worksheet_0, "H", @class.class0_0.Name);
					if (range != null)
					{
						foreach (TransfContract transfContract in list.Where(new Func<TransfContract, bool>(@class.method_0)))
						{
							for (int i = 0; i < 10; i++)
							{
								Range range2 = this.worksheet_0.get_Range("R" + (range.Row + i).ToString(), Type.Missing);
								if (range2.Value2 != null && range2.Value2.ToString() == "+ Добавить договор")
								{
									this.method_12(range2);
									this.worksheet_0.get_Range("R" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, transfContract.Number);
									this.worksheet_0.get_Range("S" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, transfContract.DateContract);
									this.worksheet_0.get_Range("T" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, transfContract.DateEndContract);
									this.worksheet_0.get_Range("U" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, transfContract.NameAbonent);
									this.worksheet_0.get_Range("V" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, transfContract.MaxPower);
									this.worksheet_0.get_Range("W" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, transfContract.Link);
									this.label_1.Text = "Подстанция: " + transfContract.NameSubstation + Environment.NewLine + transfContract.Number + Environment.NewLine + transfContract.DateContract + Environment.NewLine + transfContract.DateEndContract + Environment.NewLine + transfContract.NameAbonent + Environment.NewLine + transfContract.MaxPower + Environment.NewLine;
									Application.DoEvents();
									break;
								}
							}
						}
					}
					this.label_0.Text = ++num2 + " из " + num;
					Application.DoEvents();
				}
			}
			this.application_0.Visible = true;
			this.application_0.ScreenUpdating = true;
			this.application_0.EnableEvents = true;
			this.application_0.UserControl = true;
		}

		private DateTime method_11(string string_1)
		{
			return default(DateTime);
		}

		private void method_12(Range range_0)
		{
			if (((Range)range_0.Cells.get__Default(1, 1)).get_Value(Type.Missing).ToString() == "+ Добавить договор")
			{
				this.application_0.EnableEvents = false;
				this.application_0.Application.Run("modGlobalAddDeleteRange.AddRowRangeInSheet_Insert_N_Blocks", "ADD_RANGE_IN_Prs_Mosh_1", range_0, true, true, 1, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				this.application_0.EnableEvents = true;
			}
		}

		private void button_10_Click(object sender, EventArgs e)
		{
			this.application_0.Visible = false;
			this.application_0.ScreenUpdating = false;
			this.application_0.EnableEvents = true;
			this.application_0.UserControl = false;
			this.worksheet_0 = (Worksheet)this.workbook_0.Worksheets.get__Default("Трансформаторы");
			this.worksheet_0.Activate();
			for (int i = 20; i < 10005; i++)
			{
				if (this.worksheet_0.get_Range("J" + i, Type.Missing).Value2 is double)
				{
					this.worksheet_0.get_Range("AN" + i, Type.Missing).Value2 = "нет";
				}
				this.label_0.Text = i + " из 10005";
				Application.DoEvents();
			}
			this.application_0.Visible = true;
			this.application_0.ScreenUpdating = true;
			this.application_0.EnableEvents = true;
			this.application_0.UserControl = true;
		}

		private void button_11_Click(object sender, EventArgs e)
		{
			this.worksheet_0 = (Worksheet)this.workbook_0.Worksheets.get__Default("Трансформаторы");
			this.worksheet_0.Activate();
			for (int i = 20; i < this.worksheet_0.Cells.SpecialCells(11, Type.Missing).Row + 1; i++)
			{
				Range range = ((Worksheet)this.application_0.ActiveSheet).get_Range("M", Type.Missing);
				if (range.get_Value(Type.Missing).ToString() == "")
				{
					this.application_0.Run("mws_Substations.Delete_Substation", ((Worksheet)this.application_0.ActiveSheet).get_Range("D" + range.Row, Type.Missing), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				}
			}
		}

		private void button_12_Click(object sender, EventArgs e)
		{
			if (this.application_0 == null)
			{
				return;
			}
			this.application_0.Visible = false;
			this.application_0.ScreenUpdating = false;
			this.application_0.EnableEvents = true;
			this.application_0.UserControl = false;
			try
			{
				this.worksheet_0 = (Worksheet)this.workbook_0.Worksheets.get__Default("Подстанции");
				this.worksheet_0.Activate();
				this.application_0.Application.Run("modServiceModule.UNPROTECT_SHEET", this.workbook_0.ActiveSheet, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				int num = this.method_1(this.worksheet_0, "F", "+ Добавить подстанцию").Row - 1;
				int num2 = 0;
				for (int i = num; i > 19; i--)
				{
					try
					{
						Range range = ((Worksheet)this.application_0.ActiveSheet).get_Range("M" + i, Type.Missing);
						if (range == null || range.get_Value(Type.Missing) == null || range.get_Value(Type.Missing).ToString() != "хозяйственное ведение")
						{
							this.application_0.Run("mws_Substations.Delete_Substation", ((Worksheet)this.application_0.ActiveSheet).get_Range("D" + i, Type.Missing), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
							num2++;
						}
						this.label_0.Text = i + " из " + num;
						this.label_1.Text = "Удалено: " + num2.ToString();
						Application.DoEvents();
					}
					catch (Exception)
					{
					}
				}
				this.application_0.Application.Run("modServiceModule.PROTECT_SHEET", this.workbook_0.ActiveSheet, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				this.application_0.Visible = true;
				this.application_0.ScreenUpdating = true;
				this.application_0.EnableEvents = true;
				this.application_0.UserControl = true;
			}
			catch (Exception)
			{
			}
			finally
			{
				this.method_0();
			}
		}

		private void method_13(Range range_0)
		{
			this.application_0.Application.Run("modGlobalAddDeleteRange.DelRangeNRow", range_0, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
		}

		private void button_13_Click(object sender, EventArgs e)
		{
			if (this.application_0 == null)
			{
				return;
			}
			try
			{
				this.application_0.Visible = false;
				Worksheet worksheet = (Worksheet)this.workbook_0.Worksheets.get__Default("Подстанции");
				Range range = worksheet.get_Range("A1", Type.Missing);
				Range range2 = worksheet.get_Range("A1", Type.Missing);
				DataTable substation = GetData.GetSubstation();
				int num = 0;
				foreach (object obj in substation.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					worksheet = (Worksheet)this.workbook_0.Worksheets.get__Default("Подстанции");
					worksheet.Activate();
					GC.Collect();
					if (num == 0)
					{
						range2 = worksheet.get_Range("F20", "F40").Find("+ Добавить подстанцию", Type.Missing, Type.Missing, Type.Missing, Type.Missing, 1, Type.Missing, Type.Missing, Type.Missing);
					}
					else
					{
						Range range3 = worksheet.get_Range("F" + (range2.Row + 1), Type.Missing);
					}
					num++;
					this.application_0.Application.Run("mws_Substations.Add_Substation", range2, true, dataRow["Type"], 1, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					Thread.Sleep(1);
					worksheet = (Worksheet)this.workbook_0.Worksheets.get__Default("Подстанции");
					worksheet.Activate();
					this.application_0.Application.Run("modServiceModule.UNPROTECT_SHEET", this.workbook_0.ActiveSheet, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("F" + (range2.Row - 1), Type.Missing).Select();
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("F" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, dataRow["Наименование"]);
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("H" + (range2.Row - 1), Type.Missing).Select();
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("H" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, dataRow["Напряжение"]);
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("I" + (range2.Row - 1), Type.Missing).Select();
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("I" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, "");
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("K" + (range2.Row - 1), Type.Missing).Select();
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("K" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, dataRow["Инвентарный номер"]);
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("M" + (range2.Row - 1), Type.Missing).Select();
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("M" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, dataRow["Основание"]);
					this.method_15(worksheet.get_Range("P" + (range2.Row - 1), Type.Missing));
					worksheet = (Worksheet)this.workbook_0.Worksheets.get__Default("П. Расположение");
					worksheet.Activate();
					this.application_0.Application.Run("modServiceModule.UNPROTECT_SHEET", this.workbook_0.ActiveSheet, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("H" + (range2.Row - 1), Type.Missing).Select();
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("H" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, "Ульяновский муниципальный район");
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("I" + (range2.Row - 1), Type.Missing).Select();
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("I" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, "Ульяновский муниципальный район");
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("J" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, "73652000");
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("K" + (range2.Row - 1), Type.Missing).Select();
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("K" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, dataRow["Тип региона"]);
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("L" + (range2.Row - 1), Type.Missing).Select();
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("L" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, dataRow["Регион"]);
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("M" + (range2.Row - 1), Type.Missing).Select();
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("M" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, dataRow["Тип улицы"]);
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("N" + (range2.Row - 1), Type.Missing).Select();
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("N" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, dataRow["Улица"]);
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("O" + (range2.Row - 1), Type.Missing).Select();
					((Worksheet)this.workbook_0.ActiveSheet).get_Range("O" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, dataRow["Дом"]);
					this.application_0.Application.Run("modServiceModule.PROTECT_SHEET", this.workbook_0.ActiveSheet, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					this.label_0.Text = num + " из " + substation.Rows.Count;
					Application.DoEvents();
				}
				this.application_0.Visible = true;
			}
			catch (Exception)
			{
			}
			finally
			{
				this.method_0();
			}
		}

		private void button_14_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.application_0 != null)
				{
					this.application_0.Visible = false;
					this.application_0.ScreenUpdating = false;
					this.application_0.EnableEvents = true;
					this.application_0.UserControl = false;
					Worksheet worksheet = (Worksheet)this.workbook_0.Worksheets.get__Default("Трансформаторы");
					worksheet.Activate();
					Range range = worksheet.get_Range("H21", Type.Missing);
					Range range2 = worksheet.get_Range("A1", Type.Missing);
					DataTable transformer = GetData.GetTransformer();
					this.dataTable_0 = GetData.GetMaxPower();
					this.dataTable_1 = GetData.GetFactPower2014();
					IEnumerable<string> enumerable = transformer.AsEnumerable().GroupBy(new Func<DataRow, string>(FormPassportEE.<>c.<>9.method_6)).Select(new Func<IGrouping<string, DataRow>, string>(FormPassportEE.<>c.<>9.method_7));
					int num = 0;
					using (IEnumerator<string> enumerator = enumerable.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							FormPassportEE.Class147 @class = new FormPassportEE.Class147();
							@class.string_0 = enumerator.Current;
							Range range3 = this.method_1(worksheet, "H", @class.string_0);
							if (range3 != null)
							{
								EnumerableRowCollection<DataRow> enumerableRowCollection = transformer.AsEnumerable().Where(new Func<DataRow, bool>(@class.method_0));
								int num2 = 0;
								foreach (DataRow dataRow in enumerableRowCollection)
								{
									if (range2 == null || range2.get_Value(Type.Missing).ToString() != "+ Добавить трансформаторы")
									{
										range2 = range3.get_Offset(2 + num2 * 5, 2);
									}
									this.application_0.Application.Run("mws_Transformers.addTransformers", range2, false, true, (dataRow["Наименование"].ToString().IndexOf("ТСН") == -1) ? "нет" : "да", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
									Thread.Sleep(1);
									worksheet = (Worksheet)this.workbook_0.Worksheets.get__Default("Трансформаторы");
									worksheet.Activate();
									FormPassportEE.smethod_0(this.application_0, this.workbook_0, range2, dataRow);
									num2++;
								}
								range2 = null;
							}
							Control control = this.label_0;
							int num3;
							num = (num3 = num + 1);
							control.Text = num3.ToString() + " из " + enumerable.Count<string>();
							Application.DoEvents();
						}
					}
					this.application_0.Visible = true;
					this.application_0.ScreenUpdating = true;
					this.application_0.EnableEvents = true;
					this.application_0.UserControl = true;
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				this.method_0();
			}
		}

		private static void smethod_0(Application application_1, Workbook workbook_1, Range range_0, DataRow dataRow_0)
		{
			((Worksheet)workbook_1.Worksheets.get__Default("Трансформаторы")).Activate();
			application_1.Run("modServiceModule.UNPROTECT_SHEET", workbook_1.ActiveSheet, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			((Worksheet)workbook_1.ActiveSheet).get_Range("J" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow_0["Инвентарный номер"] != DBNull.Value) ? dataRow_0["Инвентарный номер"] : "");
			((Worksheet)workbook_1.ActiveSheet).get_Range("L" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow_0["Наименование"] != DBNull.Value) ? dataRow_0["Наименование"] : "");
			((Worksheet)workbook_1.ActiveSheet).get_Range("M" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow_0["Тип"] != DBNull.Value) ? dataRow_0["Тип"] : "");
			((Worksheet)workbook_1.ActiveSheet).get_Range("N" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow_0["Изоляция"] != DBNull.Value) ? dataRow_0["Изоляция"] : "");
			((Worksheet)workbook_1.ActiveSheet).get_Range("O" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, "3");
			((Worksheet)workbook_1.ActiveSheet).get_Range("P" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, "2");
			((Worksheet)workbook_1.ActiveSheet).get_Range("Q" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, "да");
			((Worksheet)workbook_1.ActiveSheet).get_Range("R" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow_0["Высокое напряжение"] != DBNull.Value) ? dataRow_0["Высокое напряжение"] : "");
			((Worksheet)workbook_1.ActiveSheet).get_Range("S" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow_0["Мощность"] != DBNull.Value) ? dataRow_0["Мощность"] : "");
			((Worksheet)workbook_1.ActiveSheet).get_Range("T" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow_0["Потери холостого хода"] != DBNull.Value) ? dataRow_0["Потери холостого хода"] : "");
			((Worksheet)workbook_1.ActiveSheet).get_Range("U" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, 0);
			((Worksheet)workbook_1.ActiveSheet).get_Range("V" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, 0);
			((Worksheet)workbook_1.ActiveSheet).get_Range("W" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, 0);
			((Worksheet)workbook_1.ActiveSheet).get_Range("AI" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow_0["Заводской номер"] != DBNull.Value) ? dataRow_0["Заводской номер"] : "");
			((Worksheet)workbook_1.ActiveSheet).get_Range("AJ" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow_0["Завод-изготовитель"] != DBNull.Value) ? dataRow_0["Завод-изготовитель"] : "");
			((Worksheet)workbook_1.ActiveSheet).get_Range("AK" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow_0["Год изготовления"] != DBNull.Value) ? dataRow_0["Год изготовления"] : "");
			((Worksheet)workbook_1.ActiveSheet).get_Range("AL" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow_0["Дата ввода в эксплуатацию"] != DBNull.Value) ? dataRow_0["Дата ввода в эксплуатацию"] : "");
			((Worksheet)workbook_1.ActiveSheet).get_Range("AM" + (range_0.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow_0["Дата ремонта"] != DBNull.Value) ? dataRow_0["Дата ремонта"] : "");
		}

		private void button_15_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.application_0 != null)
				{
					this.application_0.Visible = false;
					this.application_0.ScreenUpdating = false;
					this.application_0.EnableEvents = true;
					this.application_0.UserControl = false;
					Worksheet worksheet = (Worksheet)this.workbook_0.Worksheets.get__Default("Присоединенная мощность");
					Range range = worksheet.get_Range("A1", Type.Missing);
					Range range2 = worksheet.get_Range("A1", Type.Missing);
					DataTable connectedPower = GetData.GetConnectedPower();
					DataTable factPower = GetData.GetFactPower2014();
					IEnumerable<string> enumerable = connectedPower.AsEnumerable().GroupBy(new Func<DataRow, string>(FormPassportEE.<>c.<>9.method_8)).Select(new Func<IGrouping<string, DataRow>, string>(FormPassportEE.<>c.<>9.method_9));
					int num = 0;
					using (IEnumerator<string> enumerator = enumerable.GetEnumerator())
					{
						IL_862:
						while (enumerator.MoveNext())
						{
							FormPassportEE.Class148 @class = new FormPassportEE.Class148();
							@class.string_0 = enumerator.Current;
							worksheet = (Worksheet)this.workbook_0.Worksheets.get__Default("Присоединенная мощность");
							worksheet.Activate();
							Range range3 = null;
							for (int i = 1; i < 9000; i++)
							{
								range3 = worksheet.get_Range("H" + i, Type.Missing);
								if (range3 != null && range3.Value2 != null && range3.Value2.ToString() == @class.string_0)
								{
									range3 = worksheet.get_Range("H" + i, Type.Missing);
									IL_19B:
									if (range3 != null && range3.get_Value(Type.Missing) != null)
									{
										using (IEnumerator<DataRow> enumerator2 = factPower.AsEnumerable().Where(new Func<DataRow, bool>(@class.method_0)).GetEnumerator())
										{
											IL_376:
											while (enumerator2.MoveNext())
											{
												DataRow dataRow = enumerator2.Current;
												Range range4 = null;
												int j = range3.Row + 1;
												while (j < range3.Row + 20)
												{
													if (worksheet.get_Range("H" + j, Type.Missing) == null || worksheet.get_Range("H" + j, Type.Missing).Value2 == null || worksheet.get_Range("H" + j, Type.Missing).Value2.ToString().IndexOf("-") == -1)
													{
														if (!(worksheet.get_Range("J" + j, Type.Missing).Value2.ToString() == dataRow.Field("tr")))
														{
															j++;
															continue;
														}
														range4 = worksheet.get_Range("J" + j, Type.Missing);
													}
													IL_2D9:
													if (range4 != null)
													{
														worksheet.get_Range("L" + range4.Row, Type.Missing).set_Value(Type.Missing, (dataRow["tok"] != DBNull.Value) ? dataRow["tok"] : "");
														worksheet.get_Range("M" + range4.Row, Type.Missing).set_Value(Type.Missing, dataRow["M"].ToString().Replace('.', ','));
														goto IL_376;
													}
													goto IL_376;
												}
												goto IL_2D9;
											}
										}
										EnumerableRowCollection<DataRow> enumerableRowCollection = connectedPower.AsEnumerable().Where(new Func<DataRow, bool>(@class.method_1));
										int num2 = 0;
										foreach (DataRow dataRow2 in enumerableRowCollection)
										{
											if (num2 == 0 || range2 == null || range2.get_Value(Type.Missing).ToString() != "+ Добавить договор")
											{
												for (int k = range3.Row; k < range3.Row + 40; k++)
												{
													range = worksheet.get_Range("W" + k, Type.Missing);
													if (range != null && range.Value2 != null && range.Value2.ToString() == "+ Добавить договор")
													{
														range2 = range;
														break;
													}
												}
											}
											if (range2 != null && range2.Value2 != null && range2.Value2.ToString() == "+ Добавить договор")
											{
												this.application_0.Application.Run("TL_GADR_modMain.AddRowRangeInSheet_N_Blocks", "ADD_RANGE_IN_Prs_Mosh_1", range2, true, true, 1, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
												Thread.Sleep(1);
												this.application_0.Application.Run("modServiceModule.UNPROTECT_SHEET", this.workbook_0.ActiveSheet, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
												((Worksheet)this.workbook_0.ActiveSheet).get_Range("W" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow2["NUMDOGOVOR"] != DBNull.Value) ? dataRow2["NUMDOGOVOR"] : "");
												((Worksheet)this.workbook_0.ActiveSheet).get_Range("X" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow2["DATEDOGOVOR"] != DBNull.Value) ? dataRow2["DATEDOGOVOR"] : "");
												((Worksheet)this.workbook_0.ActiveSheet).get_Range("Z" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow2["NAMEABN"] != DBNull.Value) ? dataRow2["NAMEABN"] : "");
												((Worksheet)this.workbook_0.ActiveSheet).get_Range("AA" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow2["POWERSUM"] != DBNull.Value) ? dataRow2["POWERSUM"] : "");
												this.application_0.Application.Run("modServiceModule.PROTECT_SHEET", this.workbook_0.ActiveSheet, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
											}
										}
									}
									GC.Collect();
									Control control = this.label_0;
									int num3;
									num = (num3 = num + 1);
									control.Text = num3.ToString() + " из " + enumerable.Count<string>();
									Application.DoEvents();
									goto IL_862;
								}
							}
							goto IL_19B;
						}
					}
					this.application_0.Visible = true;
					this.application_0.ScreenUpdating = true;
					this.application_0.EnableEvents = true;
					this.application_0.UserControl = true;
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				this.method_0();
			}
		}

		private void button_16_Click(object sender, EventArgs e)
		{
			if (this.application_0 == null)
			{
				return;
			}
			try
			{
				this.application_0.Visible = false;
				this.application_0.ScreenUpdating = false;
				this.application_0.EnableEvents = true;
				this.application_0.UserControl = false;
				Worksheet worksheet = (Worksheet)this.workbook_0.Worksheets.get__Default("Оборудование");
				worksheet.Activate();
				Range range = worksheet.get_Range("A1", Type.Missing);
				Range range2 = worksheet.get_Range("A1", Type.Missing);
				DataTable equipment = GetData.GetEquipment();
				IEnumerable<string> enumerable = equipment.AsEnumerable().GroupBy(new Func<DataRow, string>(FormPassportEE.<>c.<>9.method_10)).Select(new Func<IGrouping<string, DataRow>, string>(FormPassportEE.<>c.<>9.method_11));
				int num = 0;
				using (IEnumerator<string> enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						FormPassportEE.Class149 @class = new FormPassportEE.Class149();
						@class.string_0 = enumerator.Current;
						Range range3 = this.method_1(worksheet, "H", @class.string_0);
						num++;
						if (range3 != null)
						{
							foreach (DataRow dataRow in equipment.AsEnumerable().Where(new Func<DataRow, bool>(@class.method_0)))
							{
								if (range2 == null || range2.get_Value(Type.Missing).ToString() != "+ Добавить тип оборудования")
								{
									range2 = worksheet.get_Range("J" + (range3.Row + 2), Type.Missing);
								}
								this.application_0.Application.Run("TL_GADR_modMain.AddRowRangeInSheet_N_Blocks", "ADD_RANGE_IN_OBOR_1", range2, true, true, 1, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
								Thread.Sleep(1);
								this.application_0.Application.Run("modServiceModule.UNPROTECT_SHEET", this.workbook_0.ActiveSheet, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
								((Worksheet)this.workbook_0.ActiveSheet).get_Range("J" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow["Equipment"] != DBNull.Value) ? dataRow["Equipment"] : "");
								if (worksheet.get_Range("J" + (range2.Row - 1), Type.Missing).get_Value(Type.Missing).ToString() == "выключатели")
								{
									((Worksheet)this.workbook_0.ActiveSheet).get_Range("K" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow["TypeEquipment"] != DBNull.Value) ? dataRow["TypeEquipment"] : "");
								}
								((Worksheet)this.workbook_0.ActiveSheet).get_Range("L" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow["Value"] != DBNull.Value) ? dataRow["Value"] : "");
								((Worksheet)this.workbook_0.ActiveSheet).get_Range("M" + (range2.Row - 1), Type.Missing).set_Value(Type.Missing, (dataRow["Count"] != DBNull.Value) ? dataRow["Count"] : "");
								this.application_0.Application.Run("modServiceModule.PROTECT_SHEET", this.workbook_0.ActiveSheet, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
							}
							range2 = null;
							GC.Collect();
							this.label_0.Text = num.ToString() + " из " + enumerable.Count<string>();
							Application.DoEvents();
						}
					}
				}
				this.application_0.Visible = true;
				this.application_0.ScreenUpdating = true;
				this.application_0.EnableEvents = true;
				this.application_0.UserControl = true;
			}
			catch (Exception)
			{
			}
			finally
			{
				this.method_0();
			}
		}

		private void button_17_Click(object sender, EventArgs e)
		{
			if (this.application_0 == null)
			{
				return;
			}
			try
			{
				List<Company> list = this.method_14();
				DataTable substationNames = GetData.GetSubstationNames();
				int num = 0;
				using (List<Company>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						FormPassportEE.Class150 @class = new FormPassportEE.Class150();
						@class.company_0 = enumerator.Current;
						if (@class.company_0.ShortName != "")
						{
							string[] array = substationNames.AsEnumerable().Where(new Func<DataRow, bool>(@class.method_0)).Select(new Func<DataRow, string>(FormPassportEE.<>c.<>9.method_12)).ToArray<string>();
							if (array != null)
							{
								num++;
								string[] array2 = array;
								int i = 0;
								IL_43E:
								while (i < array2.Length)
								{
									string b = array2[i];
									Worksheet worksheet = (Worksheet)this.workbook_0.Worksheets.get__Default("П. ГБП");
									worksheet.Activate();
									Range range = null;
									for (int j = 1; j < 9000; j++)
									{
										range = worksheet.get_Range("G" + j, Type.Missing);
										if (range != null && range.Value2 != null && range.Value2.ToString() == b)
										{
											range = worksheet.get_Range("G" + j, Type.Missing);
											IL_153:
											if (range != null)
											{
												Range range2 = worksheet.get_Range("I" + (range.Row + 1), "I" + (range.Row + 100)).Find("+ Добавить смежную организацию", Type.Missing, Type.Missing, Type.Missing, Type.Missing, 1, Type.Missing, Type.Missing, Type.Missing);
												if (range2 != null && range2.get_Value(Type.Missing).ToString() == "+ Добавить смежную организацию")
												{
													this.application_0.Run("TL_GADR_modMain.fncAddRowRangeSimple", "AddRow_BoundaryPoint_Org", range2, false, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
													this.application_0.Application.Run("modServiceModule.UNPROTECT_SHEET", this.workbook_0.ActiveSheet, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
													((Range)range2.get_Offset(-1, 0).Cells.get__Default(1, 1)).set_Value(Type.Missing, @class.company_0.FullNameOrg);
													this.application_0.Application.Run("modServiceModule.PROTECT_SHEET", this.workbook_0.ActiveSheet, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
												}
											}
											i++;
											goto IL_43E;
										}
									}
									goto IL_153;
								}
							}
						}
						GC.Collect();
						this.label_0.Text = num.ToString() + " из " + list.Count<Company>();
						Application.DoEvents();
					}
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				this.method_0();
			}
		}

		private List<Company> method_14()
		{
			Worksheet worksheet = (Worksheet)this.workbook_0.Worksheets.get__Default("REESTR_ORG");
			worksheet.Activate();
			int num = worksheet.UsedRange.Row + worksheet.UsedRange.Rows.Count - 1;
			object[,] array = (object[,])worksheet.get_Range("A1", "G" + num).get_Value(Type.Missing);
			List<Company> list = new List<Company>();
			for (int i = 2; i < num + 1; i++)
			{
				list.Add(new Company
				{
					Number = (double)array[i, 1],
					Region = array[i, 2].ToString(),
					Name = array[i, 3].ToString(),
					INN = array[i, 4].ToString(),
					KPP = array[i, 5].ToString(),
					Activity = array[i, 6].ToString(),
					RST_ORG_ID = array[i, 1].ToString()
				});
			}
			return list;
		}

		private void method_15(Range range_0)
		{
			((Worksheet)this.workbook_0.ActiveSheet).get_Range(range_0.get_Address(Type.Missing, Type.Missing, 1, Type.Missing, Type.Missing), Type.Missing).Select();
			this.application_0.Application.Run("modIHLCommandBar.SetValuNothing", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			Thread.Sleep(2);
		}

		private void button_19_Click(object sender, EventArgs e)
		{
			this.worksheet_0 = null;
			this.application_0 = null;
			base.Close();
		}

		private void button_18_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.method_16(true);
				try
				{
					FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
					this.label_2.Text = fileInfo.Name;
					this.application_0 = new ApplicationClass();
					Thread.Sleep(500);
					this.workbook_0 = this.application_0.Workbooks.Open(openFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					Thread.Sleep(200);
					this.application_0.Visible = true;
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					this.method_0();
					return;
				}
			}
			this.method_16(false);
		}

		private void method_16(bool bool_0)
		{
			this.button_12.Enabled = bool_0;
			this.button_13.Enabled = bool_0;
			this.button_14.Enabled = bool_0;
			this.button_15.Enabled = bool_0;
			this.button_16.Enabled = bool_0;
			this.button_17.Enabled = bool_0;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_17()
		{
			this.button_0 = new Button();
			this.label_0 = new Label();
			this.listBox_0 = new ListBox();
			this.button_1 = new Button();
			this.button_2 = new Button();
			this.button_3 = new Button();
			this.button_4 = new Button();
			this.button_5 = new Button();
			this.button_6 = new Button();
			this.label_1 = new Label();
			this.button_7 = new Button();
			this.button_8 = new Button();
			this.button_9 = new Button();
			this.richTextBox_0 = new RichTextBox();
			this.button_10 = new Button();
			this.button_11 = new Button();
			this.button_12 = new Button();
			this.button_13 = new Button();
			this.button_14 = new Button();
			this.button_15 = new Button();
			this.button_16 = new Button();
			this.button_17 = new Button();
			this.button_18 = new Button();
			this.label_2 = new Label();
			this.button_19 = new Button();
			base.SuspendLayout();
			this.button_0.Location = new Point(62, 260);
			this.button_0.Name = "button1";
			this.button_0.Size = new Size(25, 23);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Трансформаторы";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 193);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(0, 13);
			this.label_0.TabIndex = 1;
			this.listBox_0.FormattingEnabled = true;
			this.listBox_0.Location = new Point(12, 347);
			this.listBox_0.Name = "listBox1";
			this.listBox_0.Size = new Size(144, 30);
			this.listBox_0.TabIndex = 2;
			this.button_1.Location = new Point(93, 260);
			this.button_1.Name = "button2";
			this.button_1.Size = new Size(25, 23);
			this.button_1.TabIndex = 3;
			this.button_1.Text = "Оборудование";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.button_2.Location = new Point(124, 260);
			this.button_2.Name = "button3";
			this.button_2.Size = new Size(25, 23);
			this.button_2.TabIndex = 4;
			this.button_2.Text = "Расположение";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.button_3.Location = new Point(155, 260);
			this.button_3.Name = "button4";
			this.button_3.Size = new Size(25, 23);
			this.button_3.TabIndex = 5;
			this.button_3.Text = "Доп. оборуд.";
			this.button_3.UseVisualStyleBackColor = true;
			this.button_4.Location = new Point(62, 289);
			this.button_4.Name = "button5";
			this.button_4.Size = new Size(25, 23);
			this.button_4.TabIndex = 6;
			this.button_4.Text = "Доп. трансф.";
			this.button_4.UseVisualStyleBackColor = true;
			this.button_5.Location = new Point(93, 289);
			this.button_5.Name = "button6";
			this.button_5.Size = new Size(25, 23);
			this.button_5.TabIndex = 7;
			this.button_5.Text = "По умолчанию";
			this.button_5.UseVisualStyleBackColor = true;
			this.button_5.Click += this.button_5_Click;
			this.button_6.Location = new Point(124, 289);
			this.button_6.Name = "button7";
			this.button_6.Size = new Size(25, 23);
			this.button_6.TabIndex = 8;
			this.button_6.Text = "Пр. мощ. договор";
			this.button_6.UseVisualStyleBackColor = true;
			this.button_6.Click += this.button_6_Click;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(12, 216);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(0, 13);
			this.label_1.TabIndex = 9;
			this.button_7.Location = new Point(155, 289);
			this.button_7.Name = "button8";
			this.button_7.Size = new Size(25, 23);
			this.button_7.TabIndex = 10;
			this.button_7.Text = "Доп. выключатели";
			this.button_7.UseVisualStyleBackColor = true;
			this.button_8.Location = new Point(62, 318);
			this.button_8.Name = "button9";
			this.button_8.Size = new Size(25, 23);
			this.button_8.TabIndex = 11;
			this.button_8.Text = "Трансф. 0,4";
			this.button_8.UseVisualStyleBackColor = true;
			this.button_9.Location = new Point(93, 318);
			this.button_9.Name = "button10";
			this.button_9.Size = new Size(25, 23);
			this.button_9.TabIndex = 12;
			this.button_9.Text = "Трансф. пуст. \"В\"";
			this.button_9.UseVisualStyleBackColor = true;
			this.richTextBox_0.Location = new Point(12, 383);
			this.richTextBox_0.Name = "richTextBox1";
			this.richTextBox_0.Size = new Size(119, 33);
			this.richTextBox_0.TabIndex = 13;
			this.richTextBox_0.Text = "";
			this.button_10.Location = new Point(124, 318);
			this.button_10.Name = "button11";
			this.button_10.Size = new Size(25, 23);
			this.button_10.TabIndex = 14;
			this.button_10.Text = "Стоим. трансф.";
			this.button_10.UseVisualStyleBackColor = true;
			this.button_10.Click += this.button_10_Click;
			this.button_11.Location = new Point(155, 318);
			this.button_11.Name = "button12";
			this.button_11.Size = new Size(25, 23);
			this.button_11.TabIndex = 15;
			this.button_11.Text = "Удаление договора";
			this.button_11.UseVisualStyleBackColor = true;
			this.button_11.Click += this.button_11_Click;
			this.button_12.Enabled = false;
			this.button_12.Location = new Point(201, 143);
			this.button_12.Name = "button13";
			this.button_12.Size = new Size(181, 23);
			this.button_12.TabIndex = 16;
			this.button_12.Text = "Удаление подстанции (не хоз.)";
			this.button_12.UseVisualStyleBackColor = true;
			this.button_12.Click += this.button_12_Click;
			this.button_13.Enabled = false;
			this.button_13.Location = new Point(10, 85);
			this.button_13.Name = "button14";
			this.button_13.Size = new Size(185, 23);
			this.button_13.TabIndex = 17;
			this.button_13.Text = "Подстанции / расположение";
			this.button_13.UseVisualStyleBackColor = true;
			this.button_13.Click += this.button_13_Click;
			this.button_14.Enabled = false;
			this.button_14.Location = new Point(10, 114);
			this.button_14.Name = "button15";
			this.button_14.Size = new Size(185, 23);
			this.button_14.TabIndex = 18;
			this.button_14.Text = "Трансформаторы";
			this.button_14.UseVisualStyleBackColor = true;
			this.button_14.Click += this.button_14_Click;
			this.button_15.Enabled = false;
			this.button_15.Location = new Point(10, 143);
			this.button_15.Name = "button16";
			this.button_15.Size = new Size(185, 23);
			this.button_15.TabIndex = 19;
			this.button_15.Text = "Договор на тех. присоед.";
			this.button_15.UseVisualStyleBackColor = true;
			this.button_15.Click += this.button_15_Click;
			this.button_16.Enabled = false;
			this.button_16.Location = new Point(201, 85);
			this.button_16.Name = "button17";
			this.button_16.Size = new Size(181, 23);
			this.button_16.TabIndex = 20;
			this.button_16.Text = "Оборудование";
			this.button_16.UseVisualStyleBackColor = true;
			this.button_16.Click += this.button_16_Click;
			this.button_17.Enabled = false;
			this.button_17.Location = new Point(201, 114);
			this.button_17.Name = "button18";
			this.button_17.Size = new Size(181, 23);
			this.button_17.TabIndex = 21;
			this.button_17.Text = "Границы балансовой принадл.";
			this.button_17.UseVisualStyleBackColor = true;
			this.button_17.Click += this.button_17_Click;
			this.button_18.Location = new Point(12, 12);
			this.button_18.Name = "btnOpenFile";
			this.button_18.Size = new Size(103, 23);
			this.button_18.TabIndex = 22;
			this.button_18.Text = "Открыть файл";
			this.button_18.UseVisualStyleBackColor = true;
			this.button_18.Click += this.button_18_Click;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(12, 50);
			this.label_2.Name = "lbFileName";
			this.label_2.Size = new Size(64, 13);
			this.label_2.TabIndex = 23;
			this.label_2.Text = "Имя файла";
			this.button_19.Location = new Point(305, 212);
			this.button_19.Name = "btnClose";
			this.button_19.Size = new Size(75, 23);
			this.button_19.TabIndex = 24;
			this.button_19.Text = "Закрыть";
			this.button_19.UseVisualStyleBackColor = true;
			this.button_19.Click += this.button_19_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(394, 243);
			base.Controls.Add(this.button_19);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.button_18);
			base.Controls.Add(this.button_17);
			base.Controls.Add(this.button_16);
			base.Controls.Add(this.button_15);
			base.Controls.Add(this.button_14);
			base.Controls.Add(this.button_13);
			base.Controls.Add(this.button_12);
			base.Controls.Add(this.button_11);
			base.Controls.Add(this.button_10);
			base.Controls.Add(this.richTextBox_0);
			base.Controls.Add(this.button_9);
			base.Controls.Add(this.button_8);
			base.Controls.Add(this.button_7);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.button_6);
			base.Controls.Add(this.button_5);
			base.Controls.Add(this.button_4);
			base.Controls.Add(this.button_3);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.listBox_0);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.button_0);
			base.Name = "FormPassportEE";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Паспорт электросетевого оборудования";
			base.FormClosing += this.FormPassportEE_FormClosing;
			base.Load += this.FormPassportEE_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private CultureInfo cultureInfo_0;

		private Application application_0;

		private Workbook workbook_0;

		private Worksheet worksheet_0;

		private DataTable dataTable_0;

		private DataTable dataTable_1;

		private int int_0;

		private string string_0;

		private IContainer icontainer_0;

		private Button button_0;

		private Label label_0;

		private ListBox listBox_0;

		private Button button_1;

		private Button button_2;

		private Button button_3;

		private Button button_4;

		private Button button_5;

		private Button button_6;

		private Label label_1;

		private Button button_7;

		private Button button_8;

		private Button button_9;

		private RichTextBox richTextBox_0;

		private Button button_10;

		private Button button_11;

		private Button button_12;

		private Button button_13;

		private Button button_14;

		private Button button_15;

		private Button button_16;

		private Button button_17;

		private Button button_18;

		private Label label_2;

		private Button button_19;

		[CompilerGenerated]
		private sealed class Class142
		{
			internal bool method_0(DataRow dataRow_0)
			{
				return dataRow_0.Field("Расположение") == this.string_0;
			}

			public string string_0;
		}

		[CompilerGenerated]
		private sealed class Class143
		{
			internal bool method_0(DataRow dataRow_0)
			{
				return dataRow_0.Field("TP") == this.string_0;
			}

			public string string_0;
		}

		[CompilerGenerated]
		private sealed class Class144
		{
			internal bool method_0(DataRow dataRow_0)
			{
				return dataRow_0.Field("TP") == this.class143_0.string_0 && (int)dataRow_0.Field("tr") == this.int_0;
			}

			public int int_0;

			public FormPassportEE.Class143 class143_0;
		}

		[CompilerGenerated]
		private sealed class Class145
		{
			internal bool method_0(DataRow dataRow_0)
			{
				return dataRow_0.Field("tp") == this.string_0;
			}

			public string string_0;
		}

		[CompilerGenerated]
		private sealed class Class146
		{
			internal bool method_0(TransfContract transfContract_0)
			{
				return transfContract_0.NameSubstation == this.class0_0.Name;
			}

			public Class0<string> class0_0;
		}

		[CompilerGenerated]
		private sealed class Class147
		{
			internal bool method_0(DataRow dataRow_0)
			{
				return dataRow_0.Field("Расположение") == this.string_0;
			}

			public string string_0;
		}

		[CompilerGenerated]
		private sealed class Class148
		{
			internal bool method_0(DataRow dataRow_0)
			{
				return dataRow_0.Field("TP") == this.string_0;
			}

			internal bool method_1(DataRow dataRow_0)
			{
				return dataRow_0.Field("SUBNAME") == this.string_0;
			}

			public string string_0;
		}

		[CompilerGenerated]
		private sealed class Class149
		{
			internal bool method_0(DataRow dataRow_0)
			{
				return dataRow_0.Field("TP") == this.string_0;
			}

			public string string_0;
		}

		[CompilerGenerated]
		private sealed class Class150
		{
			internal bool method_0(DataRow dataRow_0)
			{
				return dataRow_0.Field("Name").IndexOf(this.company_0.ShortName) != -1;
			}

			public Company company_0;
		}
	}
}
