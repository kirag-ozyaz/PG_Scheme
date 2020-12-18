using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Microsoft.Reporting.WinForms;
using Passport.Classes;
using Passport.DataSets;
using Passport.Forms.Cable.Report.DataSet;
using Passport.Forms.Substation.Report.DataSet;
using SchemeModel;
using SchemeModel.Calculations;

namespace Passport.Forms.Cable.Report
{
	public class FormGeneralPassport : FormBase
	{
		public int IdObjList
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
				using (DataTable dataTable = base.SelectSqlData("tSchm_ObjList", true, "WHERE id = " + this.int_0.ToString()))
				{
					if (dataTable != null && dataTable.Rows.Count > 0)
					{
						this.int_1 = (int)dataTable.Rows[0]["TypeCodeId"];
					}
				}
			}
		}

		public FormGeneralPassport.FormatReport Format
		{
			get
			{
				return this.formatReport_0;
			}
			set
			{
				this.formatReport_0 = value;
			}
		}

		public TensionType TensionType { get; set; }

		public FormGeneralPassport()
		{
			this.method_51();
		}

		public FormGeneralPassport(int idObjList)
		{
			this.method_51();
			this.int_0 = idObjList;
			if (this.formatReport_0 != FormGeneralPassport.FormatReport.A3)
			{
				this.radioButton_0.Checked = true;
			}
		}

		private void FormGeneralPassport_Load(object sender, EventArgs e)
		{
			DataTable dataTable = base.SelectSqlData("tSchm_ObjList", true, "WHERE id = " + this.int_0.ToString());
			if (dataTable != null && dataTable.Rows.Count > 0)
			{
				this.int_1 = (int)dataTable.Rows[0]["TypeCodeId"];
			}
			this.equipmentType_0 = this.method_4(this.int_0);
			this.method_0();
			for (int i = 0; i < 1; i++)
			{
				this.dsDocuments_0.tP_CurrentCarrying.Rows.Add(new object[]
				{
					"",
					"",
					""
				});
			}
			this.dsDocuments_0.tP_Report.Rows.Add(new object[]
			{
				"",
				"",
				"",
				"",
				"",
				""
			});
			this.reportViewer_0.RefreshReport();
		}

		private void method_0()
		{
			EquipmentType equipmentType = this.equipmentType_0;
			if (equipmentType <= 546)
			{
				if (equipmentType == -1)
				{
					return;
				}
				switch (equipmentType)
				{
				case 535:
				case 536:
				case 537:
				case 538:
					break;
				default:
					if (equipmentType != 546)
					{
						return;
					}
					this.method_1();
					return;
				}
			}
			else if (equipmentType == 547 || equipmentType == 556 || equipmentType != 1034)
			{
				return;
			}
			this.method_2();
		}

		private void method_1()
		{
			this.Text = "Паспорт кабельной линии";
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.Cable.Report.ReportCableLinePassport" + this.formatReport_0.ToString() + ".rdlc";
			this.checkedListBox_0.Items.Clear();
			this.checkedListBox_0.Items.Add("Все", true);
			this.checkedListBox_0.Items.Add("Титульный лист", true);
			this.checkedListBox_0.Items.Add("Характеристика линии", true);
			this.checkedListBox_0.Items.Add("Муфты соединительные и концевые", true);
			this.checkedListBox_0.Items.Add("Характеристики трассы кабельной линии", true);
			this.checkedListBox_0.Items.Add("Схема трассы кабельной линии", true);
			this.checkedListBox_0.Items.Add("Характеристики токоведущих жил и изоляции линии", true);
			this.checkedListBox_0.Items.Add("Повреждение", true);
			this.checkedListBox_0.Items.Add("Данные об испытаниях", true);
			this.checkedListBox_0.Items.Add("Данные о ремонтах кабельных линий", true);
			this.tableLayoutPanel_0.RowStyles[2] = new RowStyle(SizeType.Absolute, 0f);
			string value = (this.TensionType == 229) ? "Low" : "Middle";
			this.reportViewer_0.LocalReport.SetParameters(new ReportParameter("tension", value));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsClutch", this.bindingSource_0));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsClutch2", this.bindingSource_3));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsCondition", this.bindingSource_10));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsDamage", this.bindingSource_4));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsDamage2", this.bindingSource_5));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsMain", this.bindingSource_8));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsPhaza", this.bindingSource_6));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsRepair", this.bindingSource_2));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsReport", this.bindingSource_7));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsTesting", this.bindingSource_1));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsCabSectionMakeup", this.bindingSource_9));
			this.reportViewer_0.LocalReport.SetParameters(new ReportParameter("kontragent", this.method_3()));
			this.reportViewer_0.ResetPageSettings();
			this.reportViewer_0.RefreshReport();
		}

		private void method_2()
		{
			this.Text = "Паспорт подстанции";
			this.radioButton_0.Checked = true;
			this.groupBox_0.Enabled = false;
			this.checkBox_0.Enabled = false;
			this.tableLayoutPanel_0.RowStyles[3] = new RowStyle(SizeType.Absolute, 0f);
			this.tableLayoutPanel_0.RowStyles[4] = new RowStyle(SizeType.Absolute, 0f);
			if (this.radioButton_3.Checked)
			{
				this.method_17();
				return;
			}
			this.method_35();
		}

		private string method_3()
		{
			DataTable dataTable = new DataTable("vAbnType");
			base.SelectSqlData(dataTable, true, string.Format("where typeKontragent = '{0}' and deleted = '0'", Convert.ToInt32(1115)), false);
			if (dataTable.Rows.Count > 0)
			{
				return dataTable.Rows[0]["Name"].ToString();
			}
			return string.Empty;
		}

		private EquipmentType method_4(int int_2)
		{
			DataTable dataTable = base.SelectSqlData("tSchm_ObjList", true, string.Format("WHERE id = {0}", int_2));
			if (dataTable.Rows.Count <= 0)
			{
				return -1;
			}
			return (int)dataTable.Rows[0]["TypeCodeId"];
		}

		private void method_5(ItemCheckEventArgs itemCheckEventArgs_0)
		{
			if (itemCheckEventArgs_0.Index == 1)
			{
				this.method_6(itemCheckEventArgs_0.NewValue);
			}
			if (itemCheckEventArgs_0.Index == 2)
			{
				this.method_7(itemCheckEventArgs_0.NewValue);
			}
			if (itemCheckEventArgs_0.Index == 3)
			{
				this.method_8(itemCheckEventArgs_0.NewValue);
			}
			if (itemCheckEventArgs_0.Index == 8)
			{
				this.method_9(itemCheckEventArgs_0.NewValue);
			}
			if (itemCheckEventArgs_0.Index == 9)
			{
				this.method_10(itemCheckEventArgs_0.NewValue);
			}
			if (itemCheckEventArgs_0.Index == 7)
			{
				this.method_11(itemCheckEventArgs_0.NewValue);
			}
		}

		private void method_6(CheckState checkState_0)
		{
			this.dataSetReportCableLine_0.tCableLinePassport.Rows.Clear();
			if (checkState_0 == CheckState.Checked)
			{
				DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, this.int_1, "where ol.id = " + this.int_0.ToString(), true);
				this.method_31(equipmentData);
				foreach (object obj in equipmentData.Rows)
				{
					DataRow row = (DataRow)obj;
					this.dataSetReportCableLine_0.tCableLinePassport.ImportRow(row);
				}
				this.bindingSource_8.ResetBindings(false);
			}
		}

		private void method_7(CheckState checkState_0)
		{
			this.dsDocuments_0.dtCondition.Rows.Clear();
			this.dsDocuments_0.dtCabSectionMakeups.Rows.Clear();
			if (checkState_0 == CheckState.Checked)
			{
				string text = "SELECT DISTINCT sect.idObjList, sect.Number, sect.Conditions as idCondition, c.Name as Condition\r\nFROM tP_CabSection sect LEFT JOIN\r\ntP_ValueLists as c on c.Id = sect.Conditions\r\nWHERE (sect.Conditions IS NOT NULL) AND (sect.Conditions <> '')\r\nAND sect.deleted = '0' AND sect.idObjList = " + this.int_0.ToString();
				DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
				string text2 = "";
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					text2 = string.Concat(new string[]
					{
						text2,
						", ",
						dataRow["Number"].ToString(),
						" - ",
						dataRow["Condition"].ToString()
					});
				}
				text2 = ((text2.Length > 0) ? text2.Remove(0, 2) : "");
				this.dsDocuments_0.dtCondition.Rows.Add(new object[]
				{
					text2
				});
				if (this.dataSetReportCableLine_0.tCableLinePassport.Rows.Count == 1 && this.dataSetReportCableLine_0.tCableLinePassport.Rows[0]["Сечение"].ToString().Length > 0)
				{
					string text3 = "";
					string text4 = "";
					int num = Convert.ToString(this.dataSetReportCableLine_0.tCableLinePassport.Rows[0]["Сечение"]).LastIndexOf('х');
					if (num == -1)
					{
						num = Convert.ToString(this.dataSetReportCableLine_0.tCableLinePassport.Rows[0]["Сечение"]).LastIndexOf('x');
					}
					string str = Convert.ToString(this.dataSetReportCableLine_0.tCableLinePassport.Rows[0]["Сечение"]).Substring(num + 1);
					base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vP_PRG_CableMakeup, true, "WHERE idObjList = " + this.int_0.ToString() + " AND CrossSection != " + str);
					for (int i = 0; i < this.dsDocuments_0.vP_PRG_CableMakeup.Rows.Count; i++)
					{
						if (i == 0)
						{
							text3 += this.dsDocuments_0.vP_PRG_CableMakeup.Rows[i]["CableMakeup"].ToString();
						}
						else
						{
							text4 = text4 + ", " + this.dsDocuments_0.vP_PRG_CableMakeup.Rows[i]["CableMakeup"].ToString();
						}
					}
					text4 = ((text4.Length > 0) ? text4.Remove(0, 2) : "");
					this.dsDocuments_0.dtCabSectionMakeups.Rows.Add(new object[]
					{
						text3,
						text4
					});
				}
			}
			this.reportViewer_0.LocalReport.SetParameters(new ReportParameter("cableCount", this.method_12(checkState_0)));
			this.reportViewer_0.LocalReport.SetParameters(new ReportParameter("limitI", this.method_13(checkState_0)));
		}

		private void method_8(CheckState checkState_0)
		{
			this.dsDocuments_0.fn_PRGCableClutches.Rows.Clear();
			if (checkState_0 == CheckState.Checked)
			{
				base.CallSQLTableValuedFunction(this.dsDocuments_0, this.dsDocuments_0.fn_PRGCableClutches, "", new string[]
				{
					this.int_0.ToString(),
					"1",
					"65"
				});
				return;
			}
			for (int i = 1; i < 66; i++)
			{
				this.dsDocuments_0.fn_PRGCableClutches.method_1(i, -1, -1, "", "", "", "", "", "");
			}
		}

		private void method_9(CheckState checkState_0)
		{
			this.dsDocuments_0.fn_PRGCableTesting.Rows.Clear();
			if (checkState_0 == CheckState.Checked)
			{
				base.CallSQLTableValuedFunction(this.dsDocuments_0, this.dsDocuments_0.fn_PRGCableTesting, "", new string[]
				{
					this.int_0.ToString(),
					"1",
					"38"
				});
				return;
			}
			for (int i = 1; i < 39; i++)
			{
				this.dsDocuments_0.fn_PRGCableTesting.method_1(i, -1, -1, "", "", "", "", "");
			}
		}

		private void method_10(CheckState checkState_0)
		{
			this.dsDocuments_0.fn_PRGCableRepair.Rows.Clear();
			if (checkState_0 == CheckState.Checked)
			{
				base.CallSQLTableValuedFunction(this.dsDocuments_0, this.dsDocuments_0.fn_PRGCableRepair, "", new string[]
				{
					this.int_0.ToString(),
					"1",
					"34"
				});
				return;
			}
			for (int i = 1; i < 35; i++)
			{
				this.dsDocuments_0.fn_PRGCableRepair.method_1(i, -1, -1, "", "", "", "", "");
			}
		}

		private void method_11(CheckState checkState_0)
		{
			this.dsDocuments_0.fn_PRGCableDamage.Rows.Clear();
			if (checkState_0 == CheckState.Checked)
			{
				base.CallSQLTableValuedFunction(this.dsDocuments_0, this.dsDocuments_0.fn_PRGCableDamage, "", new string[]
				{
					this.int_0.ToString(),
					"1",
					"71"
				});
				return;
			}
			for (int i = 1; i < 72; i++)
			{
				this.dsDocuments_0.fn_PRGCableDamage.method_1(i, -1, -1, "", "", "", "");
			}
		}

		private string method_12(CheckState checkState_0)
		{
			string text = string.Empty;
			if (checkState_0 == CheckState.Unchecked)
			{
				return text;
			}
			string text2 = "SELECT idObjList, Number, [Count]\r\nfrom tP_CabSection\r\nwhere [Count] != '0' and [Count] is not null\r\nAND deleted = '0' AND idObjList = " + this.int_0.ToString();
			foreach (object obj in new SqlDataCommand(this.SqlSettings).SelectSqlData(text2).Rows)
			{
				DataRow dataRow = (DataRow)obj;
				text = string.Concat(new string[]
				{
					text,
					", ",
					dataRow["Number"].ToString(),
					" - ",
					dataRow["Count"].ToString()
				});
			}
			if (!string.IsNullOrEmpty(text))
			{
				text = text.Remove(0, 2);
			}
			return text;
		}

		private string method_13(CheckState checkState_0)
		{
			double num = 0.0;
			if (checkState_0 == CheckState.Unchecked)
			{
				return string.Empty;
			}
			foreach (DataRow dataRow in this.dataSetReportCableLine_0.tCableLinePassport.Rows)
			{
				if (dataRow["idEquipment"] != DBNull.Value)
				{
					if (Convert.ToInt32(dataRow["idEquipment"]) != -1)
					{
						num = this.method_15(Convert.ToInt32(dataRow["idEquipment"]));
						continue;
					}
				}
				int num2 = Convert.ToString(dataRow["Сечение"]).LastIndexOf('x');
				if (num2 == -1)
				{
					num2 = Convert.ToString(dataRow["Сечение"]).LastIndexOf('х');
				}
				string string_ = Convert.ToString(dataRow["Сечение"]).Substring(num2 + 1);
				string string_2 = string.Empty;
				try
				{
					string_2 = Convert.ToString(dataRow["Сечение"]).Remove(num2 + 1);
				}
				catch
				{
					string_2 = string.Empty;
				}
				string string_3 = this.method_16(Convert.ToString(dataRow["Рабочее_напряжение"]));
				num = this.method_14(Convert.ToString(dataRow["Марка_кабеля"]), string_, string_2, string_3);
			}
			DataTable dataTable = new DataTable("vP_CabSections");
			base.SelectSqlData(dataTable, true, "where deleted = '0' and idObjlist = " + this.int_0.ToString(), false);
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow2 = (DataRow)obj;
				double num3;
				if (dataRow2["idEquipment"] != DBNull.Value)
				{
					if (Convert.ToInt32(dataRow2["idEquipment"]) != -1)
					{
						num3 = this.method_15(Convert.ToInt32(dataRow2["idEquipment"]));
						if (num3 != 0.0 && num3 < num)
						{
							num = num3;
							continue;
						}
						continue;
					}
				}
				string string_4 = this.method_16(Convert.ToString(dataRow2["Voltage"]));
				num3 = this.method_14(Convert.ToString(dataRow2["Makeup"]), Convert.ToString(dataRow2["CrossSection"]), Convert.ToString(dataRow2["Wires"]), string_4);
				if (num3 != 0.0 && num3 < num)
				{
					num = num3;
				}
			}
			if (num == 0.0)
			{
				return string.Empty;
			}
			return num.ToString();
		}

		private double method_14(string string_1, string string_2, string string_3, string string_4)
		{
			if (!string.IsNullOrEmpty(string_1) && !string.IsNullOrEmpty(string_2))
			{
				double result = 0.0;
				string text = "where CableMakeup = '" + string_1.Trim() + "'\r\n";
				text = text + "and CrossSection = '" + string_2.Replace(',', '.').Trim() + "'\r\n";
				if (string_3 != string.Empty)
				{
					text = text + "and wires = '" + string_3.Trim() + "'\r\n";
				}
				if (string_4 != string.Empty)
				{
					text = text + "and VoltageValue = '" + string_4.Replace(',', '.').Trim() + "'";
				}
				string cmdText = "select Amperage from vR_Cable\r\n" + text;
				using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
				{
					try
					{
						sqlConnection.Open();
						result = Convert.ToDouble(new SqlCommand(cmdText, sqlConnection)
						{
							CommandType = CommandType.Text
						}.ExecuteScalar());
						sqlConnection.Close();
					}
					catch
					{
						result = 0.0;
						sqlConnection.Close();
					}
				}
				return result;
			}
			return 0.0;
		}

		private double method_15(int int_2)
		{
			double result = -1.0;
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				string cmdText = "select Amperage from vR_Cable where id = " + int_2.ToString();
				try
				{
					sqlConnection.Open();
					result = Convert.ToDouble(new SqlCommand(cmdText, sqlConnection)
					{
						CommandType = CommandType.Text
					}.ExecuteScalar());
					sqlConnection.Close();
				}
				catch
				{
					result = -1.0;
					sqlConnection.Close();
				}
			}
			return result;
		}

		private string method_16(string string_1)
		{
			string empty = string.Empty;
			if (string.IsNullOrEmpty(string_1))
			{
				return empty;
			}
			string pattern = "[0-9](,[0-9])*(\\.[0-9]+)?";
			MatchCollection matchCollection = Regex.Matches(string_1, pattern);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (object obj in matchCollection)
			{
				Match match = (Match)obj;
				stringBuilder.Append(match.Value);
			}
			return stringBuilder.ToString();
		}

		private void method_17()
		{
			this.checkedListBox_0.Items.Clear();
			this.checkedListBox_0.Items.Add("Нижний колонтитул", false);
			this.reportViewer_0.LocalReport.DataSources.Clear();
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.Substation.Report.ReportCompleteTransfSubstPassport.rdlc";
			DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, this.int_1, "where ol.id = " + this.int_0.ToString(), true);
			this.method_31(equipmentData);
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsMain", equipmentData));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsEquipment", this.method_18()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsEmpty1", this.method_32(10)));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsSubstTest", this.method_27()));
			this.reportViewer_0.LocalReport.SetParameters(new ReportParameter("company", this.method_3()));
			this.reportViewer_0.LocalReport.SetParameters(new ReportParameter("voltage", this.method_28()));
			this.reportViewer_0.ResetPageSettings();
			this.reportViewer_0.RefreshReport();
		}

		private DataTable method_18()
		{
			this.dataSetReportSubstation_0.dtEquipment.Clear();
			this.string_0 = this.method_34();
			this.method_19();
			this.method_20();
			this.method_21();
			this.method_22();
			this.method_23();
			this.method_24();
			this.method_25();
			this.method_26();
			this.method_47(this.dataSetReportSubstation_0.dtEquipment, 12, this.dataSetReportSubstation_0.dtEquipment.Rows.Count);
			int num = -1;
			foreach (object obj in this.dataSetReportSubstation_0.dtEquipment.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				if (!(dataRow["typeCodeId"] is int))
				{
					dataRow["typeCodeId"] = num;
					num--;
				}
			}
			return this.dataSetReportSubstation_0.dtEquipment;
		}

		private void method_19()
		{
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 556);
			stringBuilder.Remove(0, 1);
			string where = string.Format("where ol.deleted = '0' and ol.typeCodeId in ({0}) and (ol.idParentAddl = '{1}' ", stringBuilder, this.IdObjList) + (string.IsNullOrEmpty(this.string_0) ? "" : string.Format(" or ol.id in ({0})", this.string_0)) + ")";
			DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(556), ", typeCodeId, typeName", ", ol.typeCodeId, c_ol.Name as typeName", where, "", false);
			this.method_31(equipmentData);
			equipmentData.Columns.Add("Номинальное_напряжение", typeof(string));
			equipmentData.Columns.Add("GroupName", typeof(string));
			foreach (object obj in equipmentData.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				dataRow["Номинальное_напряжение"] = (string.IsNullOrEmpty(dataRow["Высокое_напряжение"].ToString()) ? "" : (dataRow["Высокое_напряжение"] + "/")) + dataRow["Низкое_напряжение"];
				dataRow["GroupName"] = "Трансформатор";
			}
			this.method_29(this.dataSetReportSubstation_0.dtEquipment, equipmentData);
		}

		private void method_20()
		{
			if (this.string_0 == string.Empty)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 558);
			stringBuilder.Append("," + 554);
			stringBuilder.Append("," + 553);
			stringBuilder.Append("," + 559);
			stringBuilder.Append("," + 552);
			stringBuilder.Append("," + 4);
			stringBuilder.Remove(0, 1);
			if (this.string_0 != string.Empty)
			{
				DataTable dataTable = new DataTable();
				string where = string.Format("where ol.id in ({0}) and ol.typeCodeId in ({1})", this.string_0, stringBuilder);
				dataTable = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(558), ", typeCodeId, typeName", ", ol.typeCodeId, c_ol.Name as typeName", where, "", false);
				this.method_31(dataTable);
				this.method_30(dataTable, "Разъединитель");
				this.method_29(this.dataSetReportSubstation_0.dtEquipment, dataTable);
			}
		}

		private void method_21()
		{
			if (this.string_0 == string.Empty)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 908);
			stringBuilder.Append("," + 600);
			stringBuilder.Remove(0, 1);
			if (string.IsNullOrEmpty(this.string_0))
			{
				return;
			}
			string where = string.Format("where ol.id in ({0}) and ol.typeCodeId in ({1})", this.string_0, stringBuilder);
			DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(908), ", typeCodeId, typeName", ", ol.typeCodeId, c_ol.Name as typeName", where, "", false);
			this.method_31(equipmentData);
			this.method_30(equipmentData, "Предохранитель");
			this.method_29(this.dataSetReportSubstation_0.dtEquipment, equipmentData);
		}

		private void method_22()
		{
			if (this.string_0 == string.Empty)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 1212);
			stringBuilder.Append("," + 1213);
			stringBuilder.Remove(0, 1);
			if (string.IsNullOrEmpty(this.string_0))
			{
				return;
			}
			string where = string.Format("where ol.id in ({0}) and ol.typeCodeId in ({1})", this.string_0, stringBuilder);
			DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(1212), ", typeCodeId, typeName", ", ol.typeCodeId, c_ol.Name as typeName", where, "", false);
			this.method_31(equipmentData);
			this.method_30(equipmentData, "Разрядник");
			this.method_29(this.dataSetReportSubstation_0.dtEquipment, equipmentData);
		}

		private void method_23()
		{
			if (this.string_0 == string.Empty)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 1277);
			stringBuilder.Remove(0, 1);
			if (string.IsNullOrEmpty(this.string_0))
			{
				return;
			}
			string where = string.Format("where ol.id in ({0}) and ol.typeCodeId in ({1})", this.string_0, stringBuilder);
			DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(1277), ", typeCodeId, typeName", ", ol.typeCodeId, c_ol.Name as typeName", where, "", false);
			this.method_31(equipmentData);
			this.method_30(equipmentData, "Счетчик");
			this.method_29(this.dataSetReportSubstation_0.dtEquipment, equipmentData);
		}

		private void method_24()
		{
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 976);
			stringBuilder.Remove(0, 1);
			string where = string.Format("where ol.deleted = '0' and ol.typeCodeId in ({0}) and (ol.idParentAddl = '{1}' ", stringBuilder, this.IdObjList) + (string.IsNullOrEmpty(this.string_0) ? "" : string.Format(" or ol.id in ({0})", this.string_0)) + ")";
			DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(976), ", typeCodeId, typeName", ", ol.typeCodeId, c_ol.Name as typeName", where, "", false);
			this.method_31(equipmentData);
			equipmentData.Columns.Add("Номинальное_напряжение", typeof(string));
			this.method_30(equipmentData, "Трансформатор тока");
			foreach (object obj in equipmentData.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				dataRow["Номинальное_напряжение"] = (string.IsNullOrEmpty(dataRow["Высокое_напряжение"].ToString()) ? "" : (dataRow["Высокое_напряжение"] + "/")) + dataRow["Низкое_напряжение"];
			}
			this.method_29(this.dataSetReportSubstation_0.dtEquipment, equipmentData);
		}

		private void method_25()
		{
			if (this.string_0 == string.Empty)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 975);
			stringBuilder.Remove(0, 1);
			string where = string.Format("where ol.id in ({0}) and ol.typeCodeId in ({1})", this.string_0, stringBuilder);
			DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(975), ", typeCodeId, typeName", ", ol.typeCodeId, c_ol.Name as typeName", where, "", false);
			this.method_31(equipmentData);
			this.method_30(equipmentData, "Рубильник");
			this.method_29(this.dataSetReportSubstation_0.dtEquipment, equipmentData);
		}

		private void method_26()
		{
			if (this.string_0 == string.Empty)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 903);
			stringBuilder.Remove(0, 1);
			string where = string.Format("where ol.id in ({0}) and ol.typeCodeId in ({1})", this.string_0, stringBuilder);
			DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(903), ", typeCodeId, typeName", ", ol.typeCodeId, c_ol.Name as typeName", where, "", false);
			this.method_31(equipmentData);
			this.method_30(equipmentData, "Автоматический выключатель");
			this.method_29(this.dataSetReportSubstation_0.dtEquipment, equipmentData);
		}

		private DataTable method_27()
		{
			DataTable dataTable = new DataTable("vP_SubstationTest");
			base.SelectSqlData(dataTable, true, "where deleted = '0' and idObjList = " + this.int_0.ToString(), false);
			this.method_47(dataTable, 15, dataTable.Rows.Count);
			return dataTable;
		}

		private string method_28()
		{
			string result;
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand(string.Concat(new string[]
					{
						"select cast(MIN(c_ol.Value) as decimal(5, 2)) as V\r\nfrom tSchm_ObjList as ol join\r\ntR_Classifier as c_ol on ol.TypeCodeId = c_ol.Id\r\nwhere IdParent = '",
						this.int_0.ToString(),
						"' and TypeCodeId in (select id\r\nfrom tR_Classifier\r\nwhere ParentKey like ';SCM;Bus;%' and IsGroup = '0' and Deleted = '0')\r\nUNION\r\nselect cast(MAX(c_ol.Value) as decimal(5, 2)) as V\r\nfrom tSchm_ObjList as ol join\r\ntR_Classifier as c_ol on ol.TypeCodeId = c_ol.Id\r\nwhere IdParent = '",
						this.int_0.ToString(),
						"' and TypeCodeId in (select id\r\nfrom tR_Classifier\r\nwhere ParentKey like ';SCM;Bus;%' and IsGroup = '0' and Deleted = '0')\r\border by V desc"
					}), sqlConnection);
					sqlCommand.CommandType = CommandType.Text;
					DataTable dataTable = new DataTable();
					new SqlDataAdapter(sqlCommand).Fill(dataTable);
					string text = string.Empty;
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						if (Math.Truncate(Convert.ToDecimal(dataRow[0])) - Convert.ToDecimal(dataRow[0]) == 0m)
						{
							text = text + "/" + Math.Truncate(Convert.ToDecimal(dataRow[0]));
						}
						else
						{
							text = text + "/" + dataRow[0];
						}
					}
					if (!string.IsNullOrEmpty(text))
					{
						text = text.Remove(0, 1);
					}
					result = text;
				}
				catch
				{
					sqlConnection.Close();
					result = string.Empty;
				}
				finally
				{
					sqlConnection.Close();
				}
			}
			return result;
		}

		private void method_29(DataTable dataTable_0, DataTable dataTable_1)
		{
			foreach (object obj in dataTable_1.Rows)
			{
				DataRow row = (DataRow)obj;
				dataTable_0.ImportRow(row);
			}
		}

		private void method_30(DataTable dataTable_0, string string_1)
		{
			dataTable_0.Columns.Add("GroupName", typeof(string));
			foreach (object obj in dataTable_0.Rows)
			{
				((DataRow)obj)["GroupName"] = string_1;
			}
		}

		private void method_31(DataTable dataTable_0)
		{
			foreach (object obj in dataTable_0.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj;
				dataColumn.ColumnName = dataColumn.ColumnName.Trim().Replace(" ", "_");
				dataColumn.ColumnName = dataColumn.ColumnName.Trim().Replace("-", "__");
			}
		}

		private DataTable method_32(int int_2)
		{
			DataTable dataTable = new DataSetReportSubstation.dtEmptyDataTable();
			if (int_2 > 0)
			{
				this.method_46(dataTable, int_2);
			}
			return dataTable;
		}

		private string method_33(int int_2, string string_1)
		{
			string result;
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					string commandText = string.Concat(new string[]
					{
						"SELECT STUFF((SELECT CAST(',' AS VARCHAR(MAX)) + CAST('",
						string_1,
						(string_1.Length > 0) ? "." : "",
						"' + QUOTENAME(child.[Name]) AS VARCHAR(MAX))\r\nFROM [tP_CharList] AS child JOIN\r\n[tP_CharList] AS parent ON child.ParentId = parent.id JOIN\r\n[tP_ObjClassParamList] AS ocpl ON parent.[ParentId] = ocpl.[idParamList] AND ocpl.Deleted = '0'\r\n WHERE ocpl.[idClassifier] = ",
						int_2.ToString(),
						" AND child.[isGroup] = 0 AND child.[Deleted] = '0'\r\nAND child.Name != '' GROUP BY child.[Name] ORDER BY MIN(child.[TabIndex]) FOR XML PATH('')), 1, 1, '')"
					});
					sqlConnection.Open();
					string text = new SqlCommand
					{
						Connection = sqlConnection,
						CommandType = CommandType.Text,
						CommandText = commandText
					}.ExecuteScalar().ToString();
					sqlConnection.Close();
					result = text;
				}
				catch (Exception)
				{
					result = "";
				}
			}
			return result;
		}

		private string method_34()
		{
			string result;
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					result = Convert.ToString(new SqlCommand("select STUFF((select ',' + cast(ol.id as nvarchar(max))\r\nfrom tSchm_ObjList as cell\r\njoin tR_Classifier as c on c.Id = cell.TypeCodeId and c.ParentKey like ';SCM;Cell;%'\r\njoin tSchm_Relation as rel on cell.id = rel.Edge\r\njoin tSchm_ObjList as ol on rel.id = ol.IdParent\r\nwhere cell.Deleted = 0 and cell.IdParent = '" + this.IdObjList.ToString() + "'\r\nfor xml path('')), 1, 1, '') as idList", sqlConnection)
					{
						CommandType = CommandType.Text
					}.ExecuteScalar());
				}
				catch
				{
					result = string.Empty;
				}
				finally
				{
					sqlConnection.Close();
				}
			}
			return result;
		}

		private void method_35()
		{
			this.checkedListBox_0.Items.Clear();
			this.reportViewer_0.LocalReport.DataSources.Clear();
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.Substation.Report.ReportClosedTransfSubstPassport.rdlc";
			this.string_0 = this.method_34();
			DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, this.int_1, "where ol.id = " + this.int_0.ToString(), false);
			this.method_31(equipmentData);
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsMain", equipmentData));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsNumberEntries", this.method_43()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsTransform", this.method_36()));
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			dataTable = this.method_37();
			dataTable2 = this.method_38();
			this.method_47(dataTable, dataTable2.Rows.Count, dataTable.Rows.Count);
			this.method_47(dataTable2, dataTable.Rows.Count, dataTable2.Rows.Count);
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsTransI", dataTable));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsProtector", dataTable2));
			dataTable = this.method_39();
			dataTable2 = this.method_40();
			this.method_47(dataTable, dataTable2.Rows.Count, dataTable.Rows.Count);
			this.method_47(dataTable2, dataTable.Rows.Count, dataTable2.Rows.Count);
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsSwitch", dataTable));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsDischarger", dataTable2));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsHVSplitDevice", this.method_41()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsLVSplitDevice", this.method_42()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsRepair", this.method_32(95)));
			this.reportViewer_0.LocalReport.SetParameters(new ReportParameter("company", this.method_3()));
			this.reportViewer_0.ResetPageSettings();
			this.reportViewer_0.RefreshReport();
		}

		private DataTable method_36()
		{
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 556);
			stringBuilder.Remove(0, 1);
			string where = string.Format("where ol.deleted = '0' and ol.typeCodeId in ({0}) and (ol.idParentAddl = '{1}' ", stringBuilder, this.IdObjList) + (string.IsNullOrEmpty(this.string_0) ? "" : string.Format(" or ol.id in ({0})", this.string_0)) + ")";
			DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(556), ", pt.typeCodeId", ", ol.typeCodeId", where, "", false);
			if (equipmentData.Rows.Count == 0)
			{
				return this.method_32(9);
			}
			this.method_31(equipmentData);
			equipmentData.Columns.Add("Номинальное_напряжение", typeof(string));
			foreach (object obj in equipmentData.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				dataRow["Номинальное_напряжение"] = (string.IsNullOrEmpty(dataRow["Низкое_напряжение"].ToString()) ? "" : (dataRow["Низкое_напряжение"] + "/")) + dataRow["Высокое_напряжение"];
			}
			this.method_47(equipmentData, 9, equipmentData.Rows.Count);
			return equipmentData;
		}

		private DataTable method_37()
		{
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 976);
			stringBuilder.Remove(0, 1);
			string where = string.Format("where ol.deleted = '0' and ol.typeCodeId in ({0}) and (ol.idParentAddl = '{1}' ", stringBuilder, this.IdObjList) + (string.IsNullOrEmpty(this.string_0) ? "" : string.Format(" or ol.id in ({0})", this.string_0)) + ")";
			DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(976), ", pt.typeCodeId", ", ol.typeCodeId", where, "", false);
			this.method_31(equipmentData);
			equipmentData.Columns.Add("Номинальное_напряжение", typeof(string));
			foreach (object obj in equipmentData.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				dataRow["Номинальное_напряжение"] = (string.IsNullOrEmpty(dataRow["Низкое_напряжение"].ToString()) ? "" : (dataRow["Низкое_напряжение"] + "/")) + dataRow["Высокое_напряжение"];
			}
			this.method_47(equipmentData, 9, equipmentData.Rows.Count);
			return equipmentData;
		}

		private DataTable method_38()
		{
			DataSetReportSubstation.dtEquipmentDataTable dtEquipmentDataTable = new DataSetReportSubstation.dtEquipmentDataTable();
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 908);
			stringBuilder.Remove(0, 1);
			if (this.string_0 != string.Empty)
			{
				string where = string.Format("where ol.id in ({0}) and ol.typeCodeId in ({1})", this.string_0, stringBuilder);
				DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(908), ", pt.typeCodeId", ", ol.typeCodeId", where, "", false);
				this.method_31(equipmentData);
				this.method_29(dtEquipmentDataTable, equipmentData);
			}
			this.method_47(dtEquipmentDataTable, 9, dtEquipmentDataTable.Rows.Count);
			return dtEquipmentDataTable;
		}

		private DataTable method_39()
		{
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 558);
			stringBuilder.Append("," + 554);
			stringBuilder.Append("," + 552);
			stringBuilder.Append("," + 553);
			stringBuilder.Append("," + 559);
			stringBuilder.Append("," + 903);
			stringBuilder.Append("," + 975);
			stringBuilder.Append("," + 4);
			stringBuilder.Remove(0, 1);
			DataSetReportSubstation.dtEquipmentDataTable dtEquipmentDataTable = new DataSetReportSubstation.dtEquipmentDataTable();
			if (this.string_0 != string.Empty)
			{
				string where = string.Format("where ol.id in ({0}) and ol.typeCodeId in ({1})", this.string_0, stringBuilder);
				DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(558), ", pt.typeCodeId", ", ol.typeCodeId", where, "", false);
				this.method_31(equipmentData);
				this.method_29(dtEquipmentDataTable, equipmentData);
			}
			this.method_47(dtEquipmentDataTable, 9, dtEquipmentDataTable.Rows.Count);
			return dtEquipmentDataTable;
		}

		private DataTable method_40()
		{
			DataSetReportSubstation.dtEquipmentDataTable dtEquipmentDataTable = new DataSetReportSubstation.dtEquipmentDataTable();
			StringBuilder stringBuilder = new StringBuilder(200);
			stringBuilder.Append("," + 1212);
			stringBuilder.Append("," + 1213);
			stringBuilder.Remove(0, 1);
			if (this.string_0 != string.Empty)
			{
				string where = string.Format("where ol.id in ({0}) and ol.typeCodeId in ({1})", this.string_0, stringBuilder);
				DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(1212), ", pt.typeCodeId", ", ol.typeCodeId", where, "", false);
				this.method_31(equipmentData);
				this.method_29(dtEquipmentDataTable, equipmentData);
			}
			this.method_47(dtEquipmentDataTable, 9, dtEquipmentDataTable.Rows.Count);
			return dtEquipmentDataTable;
		}

		private DataTable method_41()
		{
			DataSetReportSubstation.dtEquipmentDataTable dtEquipmentDataTable = new DataSetReportSubstation.dtEquipmentDataTable();
			string where = string.Format("LEFT JOIN dbo.vP_BusCells AS sw ON ol.id = sw.Id\r\nWHERE sw.idSwitchGear in (select ol_sw.id\r\nfrom tSchm_ObjList as ol_sw join\r\ntR_Classifier as c on ol_sw.TypeCodeId = c.id and c.ParentKey = ';SCM;SwGear;'\r\nwhere c.Value > '0.4' and c.Deleted = '0' and c.IsGroup = '0'\r\nand ol_sw.idParent = '{0}' and ol_sw.deleted = '0')", this.int_0);
			DataTable dataTable = new DataTable();
			dataTable = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(675), ", ParentFullName AS Шина, typeCodeId", ", sw.ParentName, sw.ParentFullName, ol.typeCodeId", where, "ORDER BY ParentName, ParentFullName", true);
			this.method_31(dataTable);
			this.method_29(dtEquipmentDataTable, dataTable);
			this.method_47(dtEquipmentDataTable, 47, dtEquipmentDataTable.Rows.Count);
			int num = -1;
			foreach (object obj in dtEquipmentDataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				if (dataRow["typeCodeId"] == DBNull.Value)
				{
					dataRow["typeCodeId"] = num;
					num--;
				}
			}
			return dtEquipmentDataTable;
		}

		private DataTable method_42()
		{
			DataSetReportSubstation.dtEquipmentDataTable dtEquipmentDataTable = new DataSetReportSubstation.dtEquipmentDataTable();
			string where = string.Format("LEFT JOIN dbo.vP_BusCells AS sw ON ol.id = sw.Id\r\nWHERE sw.idSwitchGear in (select ol_sw.id\r\nfrom tSchm_ObjList as ol_sw join\r\ntR_Classifier as c on ol_sw.TypeCodeId = c.id and c.ParentKey = ';SCM;SwGear;'\r\nwhere c.Value <= '0.4' and c.Deleted = '0' and c.IsGroup = '0'\r\nand ol_sw.idParent = '{0}' and ol_sw.deleted = '0')", this.int_0);
			DataTable dataTable = new DataTable();
			dataTable = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(675), ", ParentFullName AS Шина", ", sw.ParentName, sw.ParentFullName", where, "ORDER BY ParentName, ParentFullName", true);
			this.method_31(dataTable);
			this.method_29(dtEquipmentDataTable, dataTable);
			this.method_47(dtEquipmentDataTable, 50, dtEquipmentDataTable.Rows.Count);
			int num = -1;
			foreach (object obj in dtEquipmentDataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				if (dataRow["typeCodeId"] == DBNull.Value)
				{
					dataRow["typeCodeId"] = num;
					num--;
				}
			}
			return dtEquipmentDataTable;
		}

		private DataTable method_43()
		{
			DataSetReportSubstation.dtNumberOfEntriesDataTable dtNumberOfEntriesDataTable = new DataSetReportSubstation.dtNumberOfEntriesDataTable();
			DataSetReportSubstation.dtNumberOfEntriesRow dtNumberOfEntriesRow = dtNumberOfEntriesDataTable.NewdtNumberOfEntriesRow();
			ElectricModel electricModel = new ElectricModel();
			electricModel.SqlSettings = this.SqlSettings;
			electricModel.LoadSchema(true);
			foreach (ElectricObject electricObject in electricModel.GetElectricObjectById(this.int_0).ChildObjects.Where(new Func<ElectricObject, bool>(FormGeneralPassport.<>c.<>9.method_0)))
			{
				ElectricBus electricBus = (ElectricBus)electricObject;
				foreach (TreeNodeObj treeNodeObj in electricModel.PoweringReportForDrawObject(electricBus, false).Nodes)
				{
					foreach (TreeNodeObj treeNodeObj2 in treeNodeObj.Nodes)
					{
						if (treeNodeObj2.Tag.GetType() == typeof(ElectricLine) && !(treeNodeObj2.Tag as ElectricLine).IsCell())
						{
							int num = (int)this.method_44(electricBus.Id);
							int id = (treeNodeObj2.Tag as ElectricLine).Id;
							if (num == 1)
							{
								int num2 = this.method_45(id);
								if (num2 != 546)
								{
									if (num2 != 547)
									{
										if (num2 == 983)
										{
											if (dtNumberOfEntriesRow["CountAirLineLV"] == DBNull.Value)
											{
												dtNumberOfEntriesRow.CountAirLineLV = 1;
											}
											else
											{
												dtNumberOfEntriesRow.CountAirLineLV++;
											}
										}
									}
									else if (dtNumberOfEntriesRow["CountAirLineLV"] == DBNull.Value)
									{
										dtNumberOfEntriesRow.CountAirLineLV = 1;
									}
									else
									{
										dtNumberOfEntriesRow.CountAirLineLV++;
									}
								}
								else if (dtNumberOfEntriesRow["CountCableLineLV"] == DBNull.Value)
								{
									dtNumberOfEntriesRow.CountCableLineLV = 1;
								}
								else
								{
									dtNumberOfEntriesRow.CountCableLineLV++;
								}
							}
							else
							{
								int num3 = this.method_45(id);
								if (num3 != 546)
								{
									if (num3 != 547)
									{
										if (num3 == 983)
										{
											if (dtNumberOfEntriesRow["CountAirLineHV"] == DBNull.Value)
											{
												dtNumberOfEntriesRow.CountAirLineHV = 1;
											}
											else
											{
												dtNumberOfEntriesRow.CountAirLineHV++;
											}
										}
									}
									else if (dtNumberOfEntriesRow["CountAirLineHV"] == DBNull.Value)
									{
										dtNumberOfEntriesRow.CountAirLineHV = 1;
									}
									else
									{
										dtNumberOfEntriesRow.CountAirLineHV++;
									}
								}
								else if (dtNumberOfEntriesRow["CountCableLineHV"] == DBNull.Value)
								{
									dtNumberOfEntriesRow.CountCableLineHV = 1;
								}
								else
								{
									dtNumberOfEntriesRow.CountCableLineHV++;
								}
							}
						}
					}
				}
			}
			dtNumberOfEntriesDataTable.AdddtNumberOfEntriesRow(dtNumberOfEntriesRow);
			return dtNumberOfEntriesDataTable;
		}

		private FormGeneralPassport.Enum6 method_44(int int_2)
		{
			string text = "select c.Value from tR_Classifier as c join\r\ntSchm_ObjList as ol on ol.typeCodeId = c.id\r\nwhere ol.id = " + int_2.ToString();
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable.Rows.Count == 0)
			{
				return FormGeneralPassport.Enum6.const_0;
			}
			if (Convert.ToDouble(dataTable.Rows[0]["Value"]) > 0.4)
			{
				return FormGeneralPassport.Enum6.const_3;
			}
			return FormGeneralPassport.Enum6.const_1;
		}

		private int method_45(int int_2)
		{
			string text = "select c.id from tR_Classifier as c join\r\ntSchm_ObjList as ol on ol.typeCodeId = c.id\r\nwhere ol.id = " + int_2.ToString();
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable.Rows.Count == 0)
			{
				return -1;
			}
			return Convert.ToInt32(dataTable.Rows[0]["id"]);
		}

		private void method_46(DataTable dataTable_0, int int_2)
		{
			this.method_47(dataTable_0, int_2, 0);
		}

		private void method_47(DataTable dataTable_0, int int_2, int int_3)
		{
			if (int_2 < 1)
			{
				return;
			}
			if (int_3 < 0)
			{
				return;
			}
			if (int_3 >= int_2)
			{
				return;
			}
			foreach (object obj in dataTable_0.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj;
				dataColumn.AllowDBNull = true;
				dataColumn.Unique = false;
			}
			int num = int_2 - int_3;
			for (int i = 0; i < num; i++)
			{
				dataTable_0.Rows.Add(dataTable_0.NewRow());
			}
		}

		private void checkedListBox_0_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (this.bool_0 && e.Index == 0)
			{
				EquipmentType equipmentType = this.equipmentType_0;
				if (equipmentType <= 546)
				{
					if (equipmentType == -1)
					{
						goto IL_D9;
					}
					switch (equipmentType)
					{
					case 535:
					case 536:
					case 537:
					case 538:
						break;
					default:
						if (equipmentType != 546)
						{
							goto IL_D9;
						}
						for (int i = 1; i < this.checkedListBox_0.Items.Count; i++)
						{
							this.checkedListBox_0.SetItemCheckState(i, e.NewValue);
						}
						goto IL_D9;
					}
				}
				else if (equipmentType == 547 || equipmentType == 556 || equipmentType != 1034)
				{
					goto IL_D9;
				}
				this.bool_1 = (e.NewValue == CheckState.Unchecked);
				this.reportViewer_0.LocalReport.SetParameters(new ReportParameter("footer", this.bool_1.ToString()));
			}
			else
			{
				this.method_5(e);
			}
			IL_D9:
			if (this.bool_0)
			{
				this.reportViewer_0.RefreshReport();
			}
		}

		private bool method_48(CheckedListBox checkedListBox_1)
		{
			for (int i = 2; i < checkedListBox_1.Items.Count; i++)
			{
				if (checkedListBox_1.GetItemCheckState(i - 1) != checkedListBox_1.GetItemCheckState(i))
				{
					return false;
				}
			}
			return true;
		}

		private void FormGeneralPassport_Shown(object sender, EventArgs e)
		{
			this.bool_0 = true;
			this.reportViewer_0.RefreshReport();
		}

		private void method_49()
		{
			this.formatReport_0 = (this.radioButton_1.Checked ? FormGeneralPassport.FormatReport.A3 : FormGeneralPassport.FormatReport.A4);
			EquipmentType equipmentType = this.equipmentType_0;
			if (equipmentType <= 546)
			{
				if (equipmentType != -1)
				{
					switch (equipmentType)
					{
					case 535:
					case 536:
					case 537:
					case 538:
						break;
					default:
						if (equipmentType == 546)
						{
							this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.Cable.Report.ReportCableLinePassport" + this.formatReport_0.ToString() + (this.checkBox_0.Checked ? "(ShortVer)" : "") + ".rdlc";
						}
						break;
					}
				}
			}
			else if (equipmentType == 547 || equipmentType == 556 || equipmentType != 1034)
			{
			}
			this.reportViewer_0.ResetPageSettings();
			this.reportViewer_0.RefreshReport();
		}

		private void radioButton_0_CheckedChanged(object sender, EventArgs e)
		{
			this.method_49();
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void checkBox_0_CheckedChanged(object sender, EventArgs e)
		{
			this.method_49();
		}

		private void method_50()
		{
			if (this.radioButton_3.Checked)
			{
				this.method_17();
				return;
			}
			this.method_35();
		}

		private void radioButton_3_CheckedChanged(object sender, EventArgs e)
		{
			EquipmentType equipmentType = this.equipmentType_0;
			if (equipmentType <= 546)
			{
				if (equipmentType == -1)
				{
					return;
				}
				switch (equipmentType)
				{
				case 535:
				case 536:
				case 537:
				case 538:
					break;
				default:
					return;
				}
			}
			else if (equipmentType == 547 || equipmentType == 556 || equipmentType != 1034)
			{
				return;
			}
			this.method_50();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_51()
		{
			this.icontainer_0 = new Container();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dsDocuments_0 = new dsDocuments();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.bindingSource_2 = new BindingSource(this.icontainer_0);
			this.bindingSource_3 = new BindingSource(this.icontainer_0);
			this.bindingSource_5 = new BindingSource(this.icontainer_0);
			this.bindingSource_6 = new BindingSource(this.icontainer_0);
			this.bindingSource_7 = new BindingSource(this.icontainer_0);
			this.bindingSource_4 = new BindingSource(this.icontainer_0);
			this.bindingSource_8 = new BindingSource(this.icontainer_0);
			this.dataSetReportCableLine_0 = new DataSetReportCableLine();
			this.bindingSource_10 = new BindingSource(this.icontainer_0);
			this.bindingSource_9 = new BindingSource(this.icontainer_0);
			this.reportViewer_0 = new ReportViewer();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.button_0 = new Button();
			this.checkedListBox_0 = new CheckedListBox();
			this.label_0 = new Label();
			this.groupBox_0 = new GroupBox();
			this.label_1 = new Label();
			this.radioButton_0 = new RadioButton();
			this.radioButton_1 = new RadioButton();
			this.checkBox_0 = new CheckBox();
			this.groupBox_1 = new GroupBox();
			this.radioButton_2 = new RadioButton();
			this.radioButton_3 = new RadioButton();
			this.dataSetReportSubstation_0 = new DataSetReportSubstation();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dsDocuments_0).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
			((ISupportInitialize)this.bindingSource_3).BeginInit();
			((ISupportInitialize)this.bindingSource_5).BeginInit();
			((ISupportInitialize)this.bindingSource_6).BeginInit();
			((ISupportInitialize)this.bindingSource_7).BeginInit();
			((ISupportInitialize)this.bindingSource_4).BeginInit();
			((ISupportInitialize)this.bindingSource_8).BeginInit();
			((ISupportInitialize)this.dataSetReportCableLine_0).BeginInit();
			((ISupportInitialize)this.bindingSource_10).BeginInit();
			((ISupportInitialize)this.bindingSource_9).BeginInit();
			this.tableLayoutPanel_0.SuspendLayout();
			this.groupBox_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			((ISupportInitialize)this.dataSetReportSubstation_0).BeginInit();
			base.SuspendLayout();
			this.bindingSource_0.DataMember = "fn_PRGCableClutches";
			this.bindingSource_0.DataSource = this.dsDocuments_0;
			this.bindingSource_0.Filter = "RowNum > 0 AND RowNum < 25";
			this.dsDocuments_0.DataSetName = "dsDocuments";
			this.dsDocuments_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.bindingSource_1.DataMember = "fn_PRGCableTesting";
			this.bindingSource_1.DataSource = this.dsDocuments_0;
			this.bindingSource_2.DataMember = "fn_PRGCableRepair";
			this.bindingSource_2.DataSource = this.dsDocuments_0;
			this.bindingSource_3.DataMember = "fn_PRGCableClutches";
			this.bindingSource_3.DataSource = this.dsDocuments_0;
			this.bindingSource_3.Filter = "RowNum > 24";
			this.bindingSource_5.DataMember = "fn_PRGCableDamage";
			this.bindingSource_5.DataSource = this.dsDocuments_0;
			this.bindingSource_5.Filter = "RowNum > 30";
			this.bindingSource_6.DataMember = "tP_CurrentCarrying";
			this.bindingSource_6.DataSource = this.dsDocuments_0;
			this.bindingSource_7.DataMember = "tP_Report";
			this.bindingSource_7.DataSource = this.dsDocuments_0;
			this.bindingSource_4.DataMember = "fn_PRGCableDamage";
			this.bindingSource_4.DataSource = this.dsDocuments_0;
			this.bindingSource_4.Filter = "RowNum > 0 AND RowNum < 31";
			this.bindingSource_8.DataMember = "tCableLinePassport";
			this.bindingSource_8.DataSource = this.dataSetReportCableLine_0;
			this.dataSetReportCableLine_0.DataSetName = "DataSetReportCableLine";
			this.dataSetReportCableLine_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.bindingSource_10.DataMember = "dtCondition";
			this.bindingSource_10.DataSource = this.dsDocuments_0;
			this.bindingSource_9.DataMember = "dtCabSectionMakeups";
			this.bindingSource_9.DataSource = this.dsDocuments_0;
			this.reportViewer_0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.reportViewer_0.Dock = DockStyle.Fill;
			this.reportViewer_0.DocumentMapWidth = 21;
			this.reportViewer_0.Location = new Point(201, 3);
			this.reportViewer_0.Name = "rvGeneral";
			this.tableLayoutPanel_0.SetRowSpan(this.reportViewer_0, 5);
			this.reportViewer_0.ShowParameterPrompts = false;
			this.reportViewer_0.Size = new Size(917, 663);
			this.reportViewer_0.TabIndex = 0;
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 198f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Controls.Add(this.reportViewer_0, 1, 0);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 5);
			this.tableLayoutPanel_0.Controls.Add(this.checkedListBox_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.label_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.groupBox_0, 0, 3);
			this.tableLayoutPanel_0.Controls.Add(this.checkBox_0, 0, 4);
			this.tableLayoutPanel_0.Controls.Add(this.groupBox_1, 0, 2);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 6;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 45f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 49f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 30f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 43f));
			this.tableLayoutPanel_0.Size = new Size(1121, 712);
			this.tableLayoutPanel_0.TabIndex = 1;
			this.button_0.Dock = DockStyle.Right;
			this.button_0.Location = new Point(1015, 676);
			this.button_0.Margin = new Padding(3, 7, 20, 10);
			this.button_0.Name = "btnClose";
			this.button_0.Size = new Size(86, 26);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.checkedListBox_0.CheckOnClick = true;
			this.checkedListBox_0.Dock = DockStyle.Fill;
			this.checkedListBox_0.FormattingEnabled = true;
			this.checkedListBox_0.Location = new Point(3, 23);
			this.checkedListBox_0.Name = "chlbFillParagraf";
			this.checkedListBox_0.Size = new Size(192, 519);
			this.checkedListBox_0.TabIndex = 2;
			this.checkedListBox_0.ItemCheck += this.checkedListBox_0_ItemCheck;
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Fill;
			this.label_0.Location = new Point(3, 0);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(192, 20);
			this.label_0.TabIndex = 3;
			this.label_0.Text = "Наполнение";
			this.label_0.TextAlign = ContentAlignment.MiddleCenter;
			this.groupBox_0.Controls.Add(this.label_1);
			this.groupBox_0.Controls.Add(this.radioButton_0);
			this.groupBox_0.Controls.Add(this.radioButton_1);
			this.groupBox_0.Dock = DockStyle.Fill;
			this.groupBox_0.Location = new Point(3, 593);
			this.groupBox_0.Name = "gbPrintFormat";
			this.groupBox_0.Size = new Size(192, 43);
			this.groupBox_0.TabIndex = 4;
			this.groupBox_0.TabStop = false;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(19, 18);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(49, 13);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "Формат";
			this.radioButton_0.AutoSize = true;
			this.radioButton_0.Location = new Point(139, 16);
			this.radioButton_0.Name = "rbA4";
			this.radioButton_0.Size = new Size(38, 17);
			this.radioButton_0.TabIndex = 1;
			this.radioButton_0.Text = "A4";
			this.radioButton_0.UseVisualStyleBackColor = true;
			this.radioButton_0.CheckedChanged += this.radioButton_0_CheckedChanged;
			this.radioButton_1.AutoSize = true;
			this.radioButton_1.Checked = true;
			this.radioButton_1.Location = new Point(84, 16);
			this.radioButton_1.Name = "rbA3";
			this.radioButton_1.Size = new Size(38, 17);
			this.radioButton_1.TabIndex = 0;
			this.radioButton_1.TabStop = true;
			this.radioButton_1.Text = "A3";
			this.radioButton_1.UseVisualStyleBackColor = true;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Dock = DockStyle.Fill;
			this.checkBox_0.Location = new Point(3, 642);
			this.checkBox_0.Name = "chbShortVer";
			this.checkBox_0.Padding = new Padding(15, 0, 0, 0);
			this.checkBox_0.Size = new Size(192, 24);
			this.checkBox_0.TabIndex = 5;
			this.checkBox_0.Text = "Краткая версия";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
			this.groupBox_1.Controls.Add(this.radioButton_2);
			this.groupBox_1.Controls.Add(this.radioButton_3);
			this.groupBox_1.Location = new Point(3, 548);
			this.groupBox_1.Name = "gbTransType";
			this.groupBox_1.Size = new Size(192, 39);
			this.groupBox_1.TabIndex = 6;
			this.groupBox_1.TabStop = false;
			this.radioButton_2.AutoSize = true;
			this.radioButton_2.Location = new Point(84, 16);
			this.radioButton_2.Name = "rBtnZTP";
			this.radioButton_2.Size = new Size(47, 17);
			this.radioButton_2.TabIndex = 1;
			this.radioButton_2.Text = "ЗТП";
			this.radioButton_2.UseVisualStyleBackColor = true;
			this.radioButton_3.AutoSize = true;
			this.radioButton_3.Checked = true;
			this.radioButton_3.Location = new Point(22, 16);
			this.radioButton_3.Name = "rBtnKTP";
			this.radioButton_3.Size = new Size(47, 17);
			this.radioButton_3.TabIndex = 0;
			this.radioButton_3.TabStop = true;
			this.radioButton_3.Text = "КТП";
			this.radioButton_3.UseVisualStyleBackColor = true;
			this.radioButton_3.CheckedChanged += this.radioButton_3_CheckedChanged;
			this.dataSetReportSubstation_0.DataSetName = "DataSetReportSubstation";
			this.dataSetReportSubstation_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(1121, 712);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormGeneralPassport";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "FormGeneralPassport";
			base.Load += this.FormGeneralPassport_Load;
			base.Shown += this.FormGeneralPassport_Shown;
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dsDocuments_0).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			((ISupportInitialize)this.bindingSource_3).EndInit();
			((ISupportInitialize)this.bindingSource_5).EndInit();
			((ISupportInitialize)this.bindingSource_6).EndInit();
			((ISupportInitialize)this.bindingSource_7).EndInit();
			((ISupportInitialize)this.bindingSource_4).EndInit();
			((ISupportInitialize)this.bindingSource_8).EndInit();
			((ISupportInitialize)this.dataSetReportCableLine_0).EndInit();
			((ISupportInitialize)this.bindingSource_10).EndInit();
			((ISupportInitialize)this.bindingSource_9).EndInit();
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			((ISupportInitialize)this.dataSetReportSubstation_0).EndInit();
			base.ResumeLayout(false);
		}

		private int int_0;

		private int int_1 = -1;

		private bool bool_0;

		private string string_0 = string.Empty;

		private FormGeneralPassport.FormatReport formatReport_0;

		private EquipmentType equipmentType_0;

		[CompilerGenerated]
		private TensionType tensionType_0;

		private bool bool_1 = true;

		private IContainer icontainer_0;

		private ReportViewer reportViewer_0;

		private dsDocuments dsDocuments_0;

		private BindingSource bindingSource_0;

		private BindingSource bindingSource_1;

		private BindingSource bindingSource_2;

		private BindingSource bindingSource_3;

		private BindingSource bindingSource_4;

		private BindingSource bindingSource_5;

		private BindingSource bindingSource_6;

		private BindingSource bindingSource_7;

		private BindingSource bindingSource_8;

		private BindingSource bindingSource_9;

		private BindingSource bindingSource_10;

		private TableLayoutPanel tableLayoutPanel_0;

		private Button button_0;

		private CheckedListBox checkedListBox_0;

		private Label label_0;

		private GroupBox groupBox_0;

		private Label label_1;

		private RadioButton radioButton_0;

		private RadioButton radioButton_1;

		private DataSetReportCableLine dataSetReportCableLine_0;

		private CheckBox checkBox_0;

		private DataSetReportSubstation dataSetReportSubstation_0;

		private GroupBox groupBox_1;

		private RadioButton radioButton_2;

		private RadioButton radioButton_3;

		public enum FormatReport
		{
			A3,
			A4
		}

		private enum Enum6
		{
			const_0,
			const_1,
			const_2,
			const_3
		}
	}
}
