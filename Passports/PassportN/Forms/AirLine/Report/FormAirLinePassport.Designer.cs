using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Microsoft.Reporting.WinForms;
using Passport.Classes;
using Passport.Forms.Cable.Report;

namespace Passport.Forms.AirLine.Report
{
	public class FormAirLinePassport : FormBase
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
						this.NwjmcZfnmUw = (int)dataTable.Rows[0]["TypeCodeId"];
					}
				}
			}
		}

		public TensionType Voltage { get; set; }

		internal FormatReport Format
		{
			get
			{
				return this.formatReport_0;
			}
		}

		public FormAirLinePassport()
		{
			Class330.Mus9JxKz1CNxy();
			this.formatReport_0 = FormatReport.A4;
			this.NwjmcZfnmUw = -1;
			base..ctor();
			this.method_20();
			this.radioButton_1.CheckedChanged -= this.radioButton_1_CheckedChanged;
			this.radioButton_0.CheckedChanged -= this.radioButton_1_CheckedChanged;
			this.radioButton_0.Checked = true;
			this.radioButton_1.CheckedChanged += this.radioButton_1_CheckedChanged;
			this.radioButton_0.CheckedChanged += this.radioButton_1_CheckedChanged;
		}

		private void FormAirLinePassport_Load(object sender, EventArgs e)
		{
			this.method_0();
		}

		private void method_0()
		{
			if (this.radioButton_1.Checked)
			{
				this.method_1();
			}
			else if (this.radioButton_0.Checked)
			{
				this.method_18();
			}
			this.reportViewer_0.RefreshReport();
		}

		private void method_1()
		{
			this.reportViewer_0.Reset();
			if (this.Voltage == 229)
			{
				this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.AirLine.Report.ReportAirLinePassport(0.4kV).rdlc";
			}
			else
			{
				if (this.Voltage != 228)
				{
					if (this.Voltage != 227)
					{
						MessageBox.Show("Не удалось определить напржение линии.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
				}
				this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.AirLine.Report.ReportAirLinePassport.rdlc";
			}
			string string_ = string.Empty;
			string string_2 = string.Empty;
			string string_3 = string.Empty;
			string string_4 = string.Empty;
			this.reportViewer_0.LocalReport.DataSources.Clear();
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsMain", this.method_2()));
			List<ReportParameter> list = new List<ReportParameter>();
			list.Add(new ReportParameter("rpOrganisation", this.method_9()));
			this.reportViewer_0.LocalReport.SetParameters(list);
			this.NwjmcZfnmUw = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;Pole;", 1m);
			string_4 = " [Тип опоры], [Стойка], [Тип], [Пропитка] ";
			string_ = string.Format(" where [Стойка] = '{0}' ", this.method_5(";Param;Pole;Material;", "Дерево"));
			string_2 = " where t1.[Тип опоры] = t2.[Тип опоры] and  t1.[Стойка] = t2.[Стойка]  and  t1.[Тип] = t2.[Тип] and t1.[Пропитка] = t2.[Пропитка] ";
			string_3 = this.method_6(string_4, " COUNT(PoleNum) as PoleCount ", string_, string_2, true);
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsWoodenPole", this.method_7(string_3)));
			string_4 = " [Тип опоры], [Стойка], [Тип], [Тип фундамента] ";
			string_ = string.Format(" where [Стойка] = '{0}' ", this.method_5(";Param;Pole;Material;", "Металл"));
			string_2 = " where t1.[Тип опоры] = t2.[Тип опоры] and  t1.[Стойка] = t2.[Стойка]  and  t1.[Тип] = t2.[Тип] and t1.[Тип фундамента] = t2.[Тип фундамента] ";
			string_3 = this.method_6(string_4, " COUNT(PoleNum) as PoleCount ", string_, string_2, true);
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsMetallPole", this.method_7(string_3)));
			string_4 = " [Тип опоры], [Стойка], [Тип] ";
			string_ = string.Format(" where [Стойка] = '{0}' ", this.method_5(";Param;Pole;Material;", "Ж/Б"));
			string_2 = " where t1.[Тип опоры] = t2.[Тип опоры] and  t1.[Стойка] = t2.[Стойка]  and  t1.[Тип] = t2.[Тип]";
			string_3 = this.method_6(string_4, " COUNT(PoleNum) as PoleCount ", string_, string_2, true);
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsConcretePole", this.method_7(string_3)));
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			string text = string.Format("SELECT sp.[id]\r\n      ,sp.[idObjList]\r\n      ,ol.Name\r\n      ,sp.[idPoleFirst]\r\n      ,sp.[idPoleSecond]\r\n      ,sp.[NamePoleFirst]\r\n      ,sp.[NamePoleSecond]\r\n      ,sp.[CableMakeup]\r\n      ,sp.[Voltage]\r\n  FROM [vP_Spans] as sp \r\n  inner join tSchm_ObjList as ol on sp.idObjList = ol.id\r\n  where idPoleFirst in(select [idclutchFirst] as pylon from tP_CabSection where idObjList = {0}\r\n union select [idclutchsecond] as pylon from tP_CabSection where idObjList = {0}) and idPoleSecond in(select [idclutchFirst] as pylon from tP_CabSection where idObjList = {0}\r\n union select [idclutchsecond] as pylon from tP_CabSection where idObjList = {0}) and sp.Deleted=0 and ol.Deleted=0 and idObjList <> {0}", this.int_0);
			DataTable dataTable = sqlDataCommand.SelectSqlData(text);
			DataTable dtJointSuspension = new DataSetReportAirLinePassport().dtJointSuspension;
			List<int> list2 = new List<int>();
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				if (!list2.Contains((int)dataRow["id"]))
				{
					list2.Add((int)dataRow["id"]);
					DataRow dataRow2 = this.method_16(dataRow, dataTable, new List<int>());
					if (dataRow2 != dataRow)
					{
						if (list2.Contains((int)dataRow2["id"]))
						{
							continue;
						}
						list2.Add((int)dataRow2["id"]);
					}
					DataRow dataRow3 = this.method_17(dataRow, dataTable, new List<int>());
					list2.Add((int)dataRow3["id"]);
					DataSetReportAirLinePassport.dtJointSuspensionRow dtJointSuspensionRow = (DataSetReportAirLinePassport.dtJointSuspensionRow)dtJointSuspension.NewRow();
					dtJointSuspensionRow.Name = dataRow2["Name"].ToString();
					if (!dataRow2.IsNull("Voltage"))
					{
						dtJointSuspensionRow.String_0 = dataRow2["Voltage"].ToString();
					}
					dtJointSuspensionRow.PoleNum = string.Format("{0} - {1}", dataRow2["NamePoleFirst"].ToString(), dataRow3["NamePoleSecond"].ToString());
					if (!dataRow2.IsNull("CableMakeup"))
					{
						dtJointSuspensionRow.String_1 = dataRow2["CableMakeup"].ToString();
					}
					dtJointSuspension.Rows.Add(dtJointSuspensionRow);
				}
			}
			if (dtJointSuspension.Rows.Count == 0)
			{
				this.method_14(dtJointSuspension);
			}
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsJointSuspension", dtJointSuspension));
			if (this.Voltage == 229)
			{
				this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsPylonEquipment", this.method_12()));
				string_3 = "\r\nSELECT PoleNum,[Длина ответвления, м], [Число вводов], [Тип провода]\r\nFROM t1\r\nWHERE [Длина ответвления, м] != '' OR [Число вводов] != '' OR [Тип провода] != ''";
				this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsBranch", this.method_7(string_3)));
				this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsBranchNewVer", this.method_13()));
			}
			else if (this.Voltage == 228 || this.Voltage == 227)
			{
				string_4 = " [Тип], [Тип фундамента] ";
				string_ = "/*where [Тип] = '16'*/";
				string_2 = " where t1.[Тип фундамента] = t2.[Тип фундамента] /*AND t2.[Тип] = '16'*/";
				string_3 = this.method_6(string_4, " COUNT(PoleNum) as PoleCount ", string_, string_2, true);
				this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsBasement", this.method_7(string_3)));
			}
			string_4 = " [Тип изолятора], [Тип гирлянды], [Количество] ";
			string_ = "where /*[Тип гирлянды] != -1 and*/ [Тип гирлянды] != '' ";
			string_2 = "";
			string_3 = this.method_6(string_4, " COUNT([Количество]) as [Всего на линии] ", string_, string_2, false);
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsIsolator", this.method_15(this.method_7(string_3))));
			string_3 = "\r\nSELECT PoleNum,[Назначение], [Длина кабеля, м], [Марка кабеля], [Тип концевой муфты], [Тип соединительной муфты]\r\nFROM t1\r\nWHERE [Назначение] != '' OR [Длина кабеля, м] != '' OR [Марка кабеля] != '' OR [Тип концевой муфты] != '' OR [Тип соединительной муфты] != ''";
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsCableInsertion", this.method_7(string_3)));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsCrossing", this.method_10()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsTerrain", this.method_11()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsCountPole", this.method_3()));
		}

		private DataTable method_2()
		{
			using (DataTable dataTable = base.SelectSqlData("tSchm_ObjList", true, "WHERE id = " + this.int_0.ToString()))
			{
				if (dataTable != null && dataTable.Rows.Count > 0)
				{
					this.NwjmcZfnmUw = (int)dataTable.Rows[0]["TypeCodeId"];
				}
			}
			DataTable dataTable2 = new DataTable();
			dataTable2 = PassportData.GetEquipmentData(this.SqlSettings, this.NwjmcZfnmUw, ", Number", ", p.Number", "WHERE ol.id = " + this.int_0.ToString(), "", false);
			this.method_4(dataTable2);
			return dataTable2;
		}

		private DataTable method_3()
		{
			DataTable dataTable = base.SelectSqlData("tR_Classifier", true, " where ParentKey = ';SCM;Pole;' and deleted = '0' and isGroup = '0' ");
			string text = string.Empty;
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				if (text == string.Empty)
				{
					text += dataRow["id"];
				}
				else
				{
					text = text + "," + dataRow["id"];
				}
			}
			string text2 = string.Concat(new string[]
			{
				"select pvt.Id, pvt.[1] as Konc, pvt.[2] as Prom, pvt.[3] as Otv, pvt.[4] as Ugl\r\n from (select c_pole.Value, airLine.Id\r\n from tSchm_ObjList as airLine join\r\n(select idClutchFirst as idPylone, idObjList\r\nfrom tP_CabSection where Deleted = 0\r\nunion\r\nselect idClutchSecond as idPylone, idObjList\r\nfrom tP_CabSection where Deleted = 0) as sec on sec.idObjList = airLine.Id join\r\ntSchm_ObjList as pole on pole.id = sec.idPylone join\r\n tR_Classifier as c_pole on pole.TypeCodeId = c_pole.Id\r\n where airLine.Id = ",
				this.int_0.ToString(),
				" and pole.TypeCodeId in (",
				text,
				")\r\nand pole.deleted = '0') as sub \r\n pivot (Count(sub.Value) for sub.Value in ([1], [2], [3], [4])) as pvt"
			});
			return new SqlDataCommand(this.SqlSettings).SelectSqlData(text2);
		}

		private void method_4(DataTable dataTable_0)
		{
			foreach (object obj in dataTable_0.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj;
				dataColumn.ColumnName = dataColumn.ColumnName.Replace(" ", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace("-", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace("(", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace(")", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace(",", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace(".", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace("_", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace("Ё", "Е");
				dataColumn.ColumnName = dataColumn.ColumnName.Replace("ё", "е");
			}
		}

		private int method_5(string string_0, string string_1)
		{
			string cmdText = string.Format("select id from tP_ValueLists where ParentKey = '{0}' and Name = '{1}' and isGroup = '0' and deleted = '0'", string_0, string_1);
			int result;
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
					sqlCommand.CommandType = CommandType.Text;
					if (sqlCommand.ExecuteScalar() != DBNull.Value)
					{
						result = (int)sqlCommand.ExecuteScalar();
					}
					else
					{
						result = -1;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
					result = -1;
				}
				finally
				{
					sqlConnection.Close();
				}
			}
			return result;
		}

		private string method_6(string string_0, string string_1, string string_2, string string_3, bool bool_0)
		{
			return string.Concat(new string[]
			{
				"\r\nselect ",
				string_0,
				", ",
				string_1,
				bool_0 ? (", stuff((select ', ' + cast(t2.PoleNum as varchar(max)) /*as 'data()'*/ \r\nfrom t1 as t2 " + ((string_3 == "") ? "" : string_3) + "\r\nfor XML path('')), 1, 1, '') as PoleNum ") : "",
				"\r\nfrom t1 ",
				(string_2 == "") ? "" : string_2,
				"\r\ngroup by ",
				string_0
			});
		}

		private DataTable method_7(string string_0)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			string text = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdTypeValue", new string[]
			{
				";Passport;DataType;",
				"2"
			}).ToString();
			string text2 = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdTypeValue", new string[]
			{
				";Passport;DataType;",
				"3"
			}).ToString();
			string text3 = sqlDataCommand.CallSQLScalarFunction("dbo.fn_GetIdTypeValue", new string[]
			{
				";Passport;DateFormat;",
				"2"
			}).ToString();
			string text4 = string.Empty;
			using (DataTable dataTable = base.SelectSqlData("tr_Classifier", true, "WHERE ParentKey = ';SCM;Pole;' and isGroup = 0"))
			{
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (text4 != string.Empty)
					{
						text4 += ",";
					}
					text4 += dataRow["id"].ToString();
				}
				this.NwjmcZfnmUw = (int)dataTable.Rows[0]["id"];
			}
			string text5 = this.method_8(this.NwjmcZfnmUw, "");
			string text6 = this.method_8(this.NwjmcZfnmUw, "pvt");
			string text7 = string.Concat(new string[]
			{
				" ;WITH t1([Тип опоры], PoleNum, ",
				(text5 == "") ? "" : text5,
				") AS \r\n (SELECT PoleTypeName, PoleNum, ",
				(text6 == "") ? "" : text6,
				"\r\n FROM (SELECT DISTINCT ol.Name AS PoleNum, cl_ol.Name AS PoleTypeName, cl.Name AS ParamName, \r\n ISNULL(CASE WHEN cl.Type = ",
				text,
				" AND cl.idValueList != '107' and cl.Name != 'Стойка' /*and cl.id != '227'*/ \r\n THEN (SELECT Name FROM vP_GetValueList \r\n WHERE id = oc.Value AND ParentId = cl.idValueList AND TableName = cl.TableName) \r\n WHEN cl.Type = ",
				text2,
				" AND cl.Format = ",
				text3,
				"\r\n THEN ISNULL(CONVERT(varchar(10), oc.Value, 104), '') \r\n ELSE oc.value END, '') AS Value \r\n FROM dbo.tSchm_ObjList AS ol JOIN \r\n tR_Classifier as cl_ol on ol.TypeCodeId = cl_ol.Id and cl_ol.Deleted = 0 left join \r\n tP_Passport as p on p.idObjList = ol.id and p.Deleted = 0 and p.isActive = 1 left join \r\n tP_ObjectChar as oc on p.id = oc.idPassport left join \r\n tP_CharList as cl on oc.idObjChar = cl.id \r\n WHERE ol.id in (select [idclutchFirst] as pylon from tP_CabSection where idObjList = ",
				this.IdObjList.ToString(),
				" and deleted = '0'\r\nunion select [idclutchsecond] as pylon from tP_CabSection where idObjList = ",
				this.IdObjList.ToString(),
				" and deleted = '0')\r\n",
				(text4 != string.Empty) ? string.Format(" OR (ol.IdParent = {0} and ol.Deleted = 0 AND TypeCodeId in ({1})) ", this.IdObjList, text4) : "",
				") as sub \r\n",
				(text5 == "") ? "" : (" pivot(MAX(sub.Value) for sub.ParamName in (" + text5 + " )) as pvt) \r\n"),
				string_0
			});
			DataTable dataTable2 = new SqlDataCommand(this.SqlSettings).SelectSqlData(text7);
			this.method_14(dataTable2);
			this.method_4(dataTable2);
			return dataTable2;
		}

		private string method_8(int int_1, string string_0)
		{
			string result;
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					string commandText = string.Concat(new string[]
					{
						"SELECT STUFF((SELECT CAST(',' AS VARCHAR(MAX)) + CAST('",
						string_0,
						(string_0.Length > 0) ? "." : "",
						"' + QUOTENAME(child.[Name]) AS VARCHAR(MAX)) FROM [dbo].[tP_CharList] AS child JOIN [dbo].[tP_CharList] AS parent ON child.ParentId = parent.id JOIN [dbo].[tP_ObjClassParamList] AS ocpl ON parent.[ParentId] = ocpl.[idParamList] AND ocpl.Deleted = ((0))  WHERE ocpl.[idClassifier] = ",
						int_1.ToString(),
						" AND child.[isGroup] = 0 AND child.[Deleted] = 0 AND child.Name != '' GROUP BY child.[Name] ORDER BY MIN(child.[TabIndex]) FOR XML PATH('')), 1, 1, '')"
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
				catch
				{
					result = "";
				}
			}
			return result;
		}

		private string method_9()
		{
			DataTable dataTable = new DataTable("vAbnType");
			base.SelectSqlData(dataTable, true, string.Format(" where typeKontragent = {0} ", 1115), null, false, 0);
			if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Name"] != DBNull.Value)
			{
				return dataTable.Rows[0]["Name"].ToString();
			}
			return "";
		}

		private DataTable method_10()
		{
			string text = string.Empty;
			if (this.radioButton_1.Checked)
			{
				text = string.Concat(new string[]
				{
					"select cs.idObjList, val_cs.id as idCrossing, val_cs.Name as CrossingName, /*val_cs.SocrName as ShortCrossingName,*/ \r\n stuff((select ', ' + CAST(t2.Number as varchar(max)) \r\n from tP_CabSection as t2 \r\n where t2.idCrossing = val_cs.id and t2.Deleted = '0' and t2.idObjList = ",
					this.IdObjList.ToString(),
					"\r\n for xml path('')), 1, 1, '') as SpanNumbers, \r\n COUNT(cs.idCrossing) as CountSpans \r\n from tP_ValueLists as val_cs left join\r\n tP_CabSection as cs on cs.idCrossing = val_cs.Id and cs.Deleted = '0' \r\n where val_cs.ParentKey = ';Param;Crossing;' and val_cs.Deleted = '0' and val_cs.IsGroup = '0' \r\n and cs.idObjList = ",
					this.IdObjList.ToString(),
					"\r\n group by cs.idObjList, val_cs.id, val_cs.Name/*, val_cs.SocrName*/ \r\n order by val_cs.id"
				});
			}
			else if (this.radioButton_0.Checked)
			{
				text = string.Format("select cabSec.idObjList, [val].id as idCrossing, [val].Name as CrossingName, \r\nCOUNT(cabSec.id) as countSpans,\r\nSTUFF((select ', ' + Span \r\n        from (select sect.idCrossing, isnull(p1.Name + ' - ', '') + p2.Name as Span\r\n            from tP_CabSection as sect\r\n            left join tSchm_ObjList as p1 on p1.id = sect.idClutchFirst\r\n            left join tSchm_ObjList as p2 on p2.id = sect.idClutchSecond\r\n            where sect.idObjList = '{0}' and sect.Deleted = '0' \r\n            and sect.idCrossing is not null) as t2\r\n        where t2.idCrossing = [val].id\r\n        for xml path('')),1,1,'') as PylonNumbers\r\nfrom tP_ValueLists as [val]\r\nleft join tP_CabSection as cabSec on [val].id = cabSec.idCrossing\r\nand cabSec.idObjList = '{0}' and cabSec.Deleted = '0'\r\nwhere [val].ParentKey = ';Param;Crossing;' \r\nand [val].Deleted = '0' and [val].isGroup = '0'\r\ngroup by cabSec.idObjList, [val].id, [val].Name\r\norder by val.Name", this.int_0);
			}
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable.Rows.Count == 0)
			{
				DataRow dataRow = dataTable.NewRow();
				dataRow["CrossingName"] = string.Empty;
				dataTable.Rows.Add(dataRow);
			}
			return dataTable;
		}

		private DataTable method_11()
		{
			string text = string.Empty;
			if (this.radioButton_1.Checked)
			{
				text = string.Concat(new string[]
				{
					"select cs.idObjList, val_cs.id as idTerrain, val_cs.Name as TerrainName,  stuff((select ', ' + CAST(t2.Number as varchar(max))  from tP_CabSection as t2  where t2.idTerrain = val_cs.id and t2.Deleted = '0' and t2.idObjList = ",
					this.IdObjList.ToString(),
					" for xml path('')), 1, 1, '') as SpanNumbers,  Sum(cs.Length) as FullLength  from tP_ValueLists as val_cs left join  tP_CabSection as cs on cs.idTerrain = val_cs.Id and cs.Deleted = '0'   where val_cs.ParentKey = ';Param;Terrain;' and val_cs.Deleted = '0' and val_cs.IsGroup = '0'   and cs.idObjList = ",
					this.IdObjList.ToString(),
					" group by cs.idObjList, val_cs.id, val_cs.Name  order by val_cs.id"
				});
			}
			else if (this.radioButton_0.Checked)
			{
				text = string.Format("select cabSec.idObjList, [val].id as idTerrain, [val].Name as TerrainName, \r\nsum(cabSec.[Length]) as FullLength,\r\nSTUFF((select ', ' + Span \r\n        from (select sect.idTerrain, isnull(p1.Name + ' - ', '') + p2.Name as Span\r\n            from tP_CabSection as sect\r\n            left join tSchm_ObjList as p1 on p1.id = sect.idClutchFirst\r\n            left join tSchm_ObjList as p2 on p2.id = sect.idClutchSecond\r\n            where sect.idObjList = '{0}' and sect.Deleted = '0' \r\n            and sect.idTerrain is not null) as t2\r\n        where t2.idTerrain = [val].id\r\n        for xml path('')),1,1,'') as PylonNumbers\r\nfrom tP_ValueLists as [val]\r\nleft join tP_CabSection as cabSec on [val].id = cabSec.idTerrain\r\nand cabSec.idObjList = '{0}' and cabSec.Deleted = '0'\r\nwhere [val].ParentKey = ';Param;Terrain;' \r\nand [val].Deleted = '0' and [val].isGroup = '0'\r\ngroup by cabSec.idObjList, [val].id, [val].Name\r\norder by val.Name", this.int_0);
			}
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable.Rows.Count == 0)
			{
				DataRow dataRow = dataTable.NewRow();
				dataRow["TerrainName"] = string.Empty;
				dataTable.Rows.Add(dataRow);
			}
			return dataTable;
		}

		private DataTable method_12()
		{
			int typeCodeId = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;INLINE_OBJ;OTHER_OBJ;", 2m);
			int typeCodeId2 = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;INLINE_OBJ;OTHER_OBJ;", 1m);
			int typeCodeId3 = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;INLINE_OBJ;SWITCH;", 8m);
			int typeCodeId4 = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;INLINE_OBJ;SWITCH;", 14m);
			string text = string.Concat(new object[]
			{
				typeCodeId,
				",",
				typeCodeId2,
				",",
				typeCodeId3,
				",",
				typeCodeId4
			});
			string text2 = string.Concat(new string[]
			{
				";WITH tBase (PoleNum, TypeEquipment, Name) AS\r\n(SELECT DISTINCT pN.Name AS PoleNum, c_ol.Name as TypeEquipment, ol.Name AS Name\r\nFROM dbo.tSchm_ObjList AS ol JOIN\r\ntR_Classifier AS c_ol ON ol.TypeCodeId = c_ol.Id AND ol.Deleted = ((0))LEFT JOIN\r\ntSchm_ObjList AS pN ON pn.id = ol.idParentAddl LEFT JOIN\r\ndbo.tP_Passport AS p ON ol.Id = p.idObjList AND p.Deleted = ((0)) AND p.isActive = ((1))\r\nWHERE ol.idParent = ",
				this.IdObjList.ToString(),
				" AND ol.TypeCodeId in (",
				text,
				"))\r\nselect TypeEquipment, Name, Count(Name) as [Count],\r\nstuff((select ', ' + cast(t2.PoleNum as varchar(max))\r\nfrom tBase as t2\r\nwhere tBase.[Name] = t2.[Name] and  tBase.[TypeEquipment] = t2.[TypeEquipment]\r\nfor XML path('')), 1, 1, '') as PoleNum\r\nfrom tBase\r\ngroup by TypeEquipment, Name"
			});
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text2);
			this.method_14(dataTable);
			return dataTable;
		}

		private DataTable method_13()
		{
			string text = "select t1.id, T1.idAirLine, T1.idPole, T1.idObj, schm.Name as PoleName, T1.ObjName,\r\nT1.cableType + ISNULL(' - ' + T1.wireGauge, '') as cableType, T1.cableLength, T2.[Count]\r\nfrom vP_CabBranches as T1 left join\r\n(select id, idPole, COUNT(idPole) AS [Count] from vP_CabBranches group by idPole, id) as T2 ON T2.id = T1.id left join\r\ntSchm_ObjList as schm on schm.id = t1.idPole\r\nwhere T1.idAirLine = " + this.IdObjList.ToString();
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable.Rows.Count == 0)
			{
				dataTable.Reset();
				dataTable = new DataSetReportAirLinePassport.tBranchDataTable();
				dataTable.Rows.Add(dataTable.NewRow());
			}
			return dataTable;
		}

		private void method_14(DataTable dataTable_0)
		{
			if (dataTable_0.Rows.Count == 0)
			{
				DataRow dataRow = dataTable_0.NewRow();
				dataRow[0] = string.Empty;
				dataTable_0.Rows.Add(dataRow);
			}
		}

		private DataTable method_15(DataTable dataTable_0)
		{
			if (dataTable_0.Rows.Count < 0)
			{
				return dataTable_0;
			}
			int num = -1;
			string value = string.Empty;
			for (int i = 1; i < dataTable_0.Rows.Count; i++)
			{
				if (dataTable_0.Rows[0]["ТипГирлянды"].ToString() == dataTable_0.Rows[i]["ТипГирлянды"].ToString())
				{
					num--;
				}
				else
				{
					num++;
					value = dataTable_0.Rows[i]["ТипГирлянды"].ToString();
				}
			}
			if (num != 0)
			{
				for (int j = 0; j < ((num <= 0) ? (num * -1) : num); j++)
				{
					DataRow dataRow = dataTable_0.NewRow();
					dataRow["ТипГирлянды"] = value;
					dataTable_0.Rows.Add(dataRow);
				}
			}
			return dataTable_0;
		}

		private DataRow method_16(DataRow dataRow_0, DataTable dataTable_0, List<int> list_0)
		{
			int num = (int)dataRow_0["idPoleFirst"];
			DataRow dataRow = dataRow_0;
			if (list_0.Contains((int)dataRow["id"]))
			{
				return dataRow;
			}
			list_0.Add((int)dataRow["id"]);
			DataRow[] array = dataTable_0.Select(string.Format("idPoleSecond = {0} and idObjList={1}", num, (int)dataRow_0["idObjList"]));
			if (array.Length == 1)
			{
				dataRow = this.method_16(array[0], dataTable_0, list_0);
			}
			else if (array.Length > 1)
			{
				dataRow = this.method_16(array[0], dataTable_0, list_0);
			}
			return dataRow;
		}

		private DataRow method_17(DataRow dataRow_0, DataTable dataTable_0, List<int> list_0)
		{
			int num = (int)dataRow_0["idPoleSecond"];
			DataRow dataRow = dataRow_0;
			if (list_0.Contains((int)dataRow["id"]))
			{
				return dataRow;
			}
			list_0.Add((int)dataRow["id"]);
			DataRow[] array = dataTable_0.Select(string.Format("idPoleFirst = {0} and idObjList={1}", num, (int)dataRow_0["idObjList"]));
			if (array.Length == 1)
			{
				dataRow = this.method_17(array[0], dataTable_0, list_0);
			}
			else if (array.Length > 1)
			{
				dataRow = this.method_17(array[0], dataTable_0, list_0);
			}
			return dataRow;
		}

		private void method_18()
		{
			this.reportViewer_0.Reset();
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.AirLine.Report.ReportAirLinePassport(short_ver).rdlc";
			this.reportViewer_0.LocalReport.DataSources.Clear();
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsMain", this.method_2()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsCrossing", this.method_10()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsTerrain", this.method_11()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsRoad", this.method_19()));
			List<ReportParameter> list = new List<ReportParameter>();
			list.Add(new ReportParameter("company", this.method_9()));
			list.Add(new ReportParameter("datePassport", DateTime.Now.ToString("dd MMMM yyyy г.")));
			this.reportViewer_0.LocalReport.SetParameters(list);
		}

		private DataTable method_19()
		{
			string text = string.Format("select cabSec.idObjList, [val].id as idRoadType, [val].Name as RoadName, \r\ncabSec.wayCharacteristic as Characteristic,\r\nSTUFF((select ', ' + Span \r\n        from (select sect.idRoadType, isnull(p1.Name + ' - ', '') + p2.Name as Span\r\n            ,sect.wayCharacteristic\r\n            from tP_CabSection as sect\r\n            left join tSchm_ObjList as p1 on p1.id = sect.idClutchFirst\r\n            left join tSchm_ObjList as p2 on p2.id = sect.idClutchSecond\r\n            where sect.idObjList = '{0}' and sect.Deleted = '0' \r\n            and sect.idRoadType is not null) as t2\r\n        where t2.idRoadType = [val].id\r\n        and (t2.wayCharacteristic = cabSec.wayCharacteristic or cabSec.wayCharacteristic is null)\r\n        for xml path('')),1,1,'') as PylonNumbers\r\nfrom tP_ValueLists as [val]\r\nleft join tP_CabSection as cabSec on [val].id = cabSec.idRoadType\r\nand cabSec.idObjList = '{0}' and cabSec.Deleted = '0'\r\nwhere [val].ParentKey = ';Param;RoadType;' \r\nand [val].Deleted = '0' and [val].isGroup = '0'\r\ngroup by cabSec.idObjList, [val].id, [val].Name,\r\ncabSec.wayCharacteristic\r\norder by val.Name", this.int_0);
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable.Rows.Count == 0)
			{
				DataRow dataRow = dataTable.NewRow();
				dataRow["RoadName"] = string.Empty;
				dataTable.Rows.Add(dataRow);
			}
			return dataTable;
		}

		private void radioButton_1_CheckedChanged(object sender, EventArgs e)
		{
			this.method_0();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_20()
		{
			this.reportViewer_0 = new ReportViewer();
			this.panel_0 = new Panel();
			this.groupBox_0 = new GroupBox();
			this.radioButton_0 = new RadioButton();
			this.radioButton_1 = new RadioButton();
			this.splitter_0 = new Splitter();
			this.panel_0.SuspendLayout();
			this.groupBox_0.SuspendLayout();
			base.SuspendLayout();
			this.reportViewer_0.Dock = DockStyle.Fill;
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.AirLine.Report.ReportAirLinePassportA4.rdlc";
			this.reportViewer_0.Location = new Point(139, 0);
			this.reportViewer_0.Name = "rvGeneral";
			this.reportViewer_0.Size = new Size(612, 530);
			this.reportViewer_0.TabIndex = 0;
			this.panel_0.Controls.Add(this.groupBox_0);
			this.panel_0.Dock = DockStyle.Left;
			this.panel_0.Location = new Point(0, 0);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(139, 530);
			this.panel_0.TabIndex = 1;
			this.groupBox_0.Controls.Add(this.radioButton_0);
			this.groupBox_0.Controls.Add(this.radioButton_1);
			this.groupBox_0.Dock = DockStyle.Top;
			this.groupBox_0.Location = new Point(0, 0);
			this.groupBox_0.Name = "grpVerPassport";
			this.groupBox_0.Size = new Size(139, 70);
			this.groupBox_0.TabIndex = 0;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Версия паспорта";
			this.radioButton_0.AutoSize = true;
			this.radioButton_0.Location = new Point(12, 42);
			this.radioButton_0.Name = "rBtnShortVer";
			this.radioButton_0.Size = new Size(67, 17);
			this.radioButton_0.TabIndex = 1;
			this.radioButton_0.Text = "Краткая";
			this.radioButton_0.UseVisualStyleBackColor = true;
			this.radioButton_0.CheckedChanged += this.radioButton_1_CheckedChanged;
			this.radioButton_1.AutoSize = true;
			this.radioButton_1.Location = new Point(12, 19);
			this.radioButton_1.Name = "rBtnFullVer";
			this.radioButton_1.Size = new Size(63, 17);
			this.radioButton_1.TabIndex = 0;
			this.radioButton_1.Text = "Полная";
			this.radioButton_1.UseVisualStyleBackColor = true;
			this.radioButton_1.CheckedChanged += this.radioButton_1_CheckedChanged;
			this.splitter_0.Location = new Point(139, 0);
			this.splitter_0.Name = "splitter1";
			this.splitter_0.Size = new Size(3, 530);
			this.splitter_0.TabIndex = 2;
			this.splitter_0.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(751, 530);
			base.Controls.Add(this.splitter_0);
			base.Controls.Add(this.reportViewer_0);
			base.Controls.Add(this.panel_0);
			base.Name = "FormAirLinePassport";
			this.Text = "Паспорт воздушной линии";
			base.Load += this.FormAirLinePassport_Load;
			this.panel_0.ResumeLayout(false);
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			base.ResumeLayout(false);
		}

		private int int_0;

		private FormatReport formatReport_0;

		private int NwjmcZfnmUw;

		[CompilerGenerated]
		private TensionType tensionType_0;

		private IContainer icontainer_0;

		private ReportViewer reportViewer_0;

		private Panel panel_0;

		private GroupBox groupBox_0;

		private RadioButton radioButton_0;

		private RadioButton radioButton_1;

		private Splitter splitter_0;
	}
}
