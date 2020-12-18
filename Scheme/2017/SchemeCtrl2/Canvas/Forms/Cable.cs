using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataSql;

namespace SchemeCtrl2.Canvas.Forms
{
	public static class Cable
	{
		public static void InsertPassportCable(SQLSettings settings, int Cod, int idObjList)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(settings);
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			Cable.smethod_7(settings, idObjList, Cod);
			Cable.smethod_6(settings, idObjList, Cod);
			string string_ = "SELECT * FROM [ULGES-SQL].[Kab].[dbo].[Паспорт Кабеля] WHERE [Код] = " + Cod.ToString();
			dataTable = Cable.smethod_10(settings, string_);
			if (dataTable.Rows.Count == 0)
			{
				return;
			}
			DataRow dataRow = dataTable.Rows[0];
			int idOldPassport = int.Parse(dataRow["Код"].ToString());
			DateTime now = DateTime.Now;
			string number = dataRow["Type_Cabl"].ToString();
			string state = "";
			string name = (dataRow["Имя"] == DBNull.Value) ? "" : dataRow["Имя"].ToString();
			int region = Cable.smethod_11(dataRow["Num_Depart"].ToString());
			string sector = (dataRow["MontagUch"] == DBNull.Value) ? "" : dataRow["MontagUch"].ToString();
			int balance = (int)sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetIdValueList", new string[]
			{
				dataRow["Прин"].ToString()
			});
			string inventoryNumber = sqlDataCommand.CallSQLScalarFunction("dbo.fn_PI_GetOldCableInvNumber", new string[]
			{
				dataRow["Код"].ToString()
			}).ToString();
			int yearLaying = (dataRow["ГП"] == DBNull.Value) ? 1900 : int.Parse(dataRow["ГП"].ToString());
			int yearExpl = (dataRow["ГЭ"] == DBNull.Value) ? 1900 : int.Parse(dataRow["ГЭ"].ToString());
			int yearRebuild = 1900;
			decimal isummer = 0.0m;
			decimal iwinter = 0.0m;
			decimal voltage = (dataRow["U"] == DBNull.Value) ? 0.0m : decimal.Parse(dataRow["U"].ToString());
			int buyer = (int)sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetIdAbn", new string[]
			{
				dataRow["Zakazchik"].ToString()
			});
			int trest = (int)sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetIdAbn", new string[]
			{
				dataRow["MontagTrest"].ToString()
			});
			int smu = (int)sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetIdAbn", new string[]
			{
				dataRow["MontagSMU"].ToString()
			});
			int idPassportCable = Cable.InsertPassportCable(idOldPassport, settings, idObjList, now, number, state, name, region, sector, balance, inventoryNumber, yearLaying, yearExpl, yearRebuild, isummer, iwinter, voltage, buyer, trest, smu, -1, -1);
			int num = Cable.InsertVirtualClutch(settings, "01", idObjList);
			string_ = "SELECT * FROM [ULGES-SQL].[Kab].[dbo].[Муфты] WHERE [Код] = " + Cod.ToString() + " ORDER BY UchN";
			dataTable2 = Cable.smethod_10(settings, string_);
			int idClutch_ = num;
			for (int i = 1; i < dataTable2.Rows.Count; i++)
			{
				try
				{
					int makeup = (int)sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetIdValueList", new string[]
					{
						dataTable2.Rows[i]["KMarka"].ToString()
					});
					decimal voltage2 = 0.0m;
					decimal.TryParse(dataTable2.Rows[i]["UNom"].ToString(), out voltage2);
					int wires = 0;
					int.TryParse(dataTable2.Rows[i]["KSech1"].ToString(), out wires);
					decimal crossSection = 0.0m;
					decimal.TryParse(dataTable2.Rows[i]["KSech2"].ToString(), out crossSection);
					decimal length = 0.0m;
					decimal.TryParse(dataTable2.Rows[i]["ДВ"].ToString(), out length);
					string conditions = dataTable2.Rows[i]["KUsl"].ToString();
					int count = 0;
					int.TryParse(dataTable2.Rows[i]["KKol"].ToString(), out count);
					DateTime dateTime = default(DateTime);
					if (DateTime.TryParse(dataTable2.Rows[i]["KData"].ToString(), out dateTime))
					{
						int year = dateTime.Year;
					}
					string comment = dataTable2.Rows[i]["KUslPr"].ToString();
					if (i + 1 < dataTable2.Rows.Count)
					{
						int idOldPassport2 = int.Parse(dataTable2.Rows[i]["ID"].ToString());
						string nameClutch = dataTable2.Rows[i]["Муфта"].ToString();
						DateTime now2 = DateTime.Now;
						int.Parse(dataTable2.Rows[i]["UchN"].ToString());
						int type = (int)sqlDataCommand.CallSQLScalarFunction("dbo.fn_P_GetIdValueList", new string[]
						{
							dataTable2.Rows[i]["Тип"].ToString()
						});
						string house = dataTable2.Rows[i]["Дом"].ToString();
						string adressAddl = dataTable2.Rows[i]["Улица"].ToString();
						DateTime dateMount = DateTime.Parse("1900-01-01 00:00:01");
						DateTime.TryParse(dataTable2.Rows[i]["ДатаМ"].ToString(), out dateMount);
						decimal occurrenceDepth = 0.0m;
						decimal.TryParse(dataTable2.Rows[i]["ГЗ"].ToString(), out occurrenceDepth);
						string cableWeight = dataTable2.Rows[i]["МКМ"].ToString();
						string installationSiteEnd = dataTable2.Rows[i]["MestoKVTP"].ToString();
						string installationMade = dataTable2.Rows[i]["ФИО1"].ToString();
						string madeBinding = dataTable2.Rows[i]["ФИО2"].ToString();
						int num2 = Cable.InsertPassportClutch(settings, idOldPassport2, idObjList, dataTable2, idPassportCable, nameClutch, now, sector, type, -1, house, adressAddl, -1, dateMount, occurrenceDepth, cableWeight, installationSiteEnd, installationMade, madeBinding);
						Cable.tP_CabSectionAddRow(settings, idObjList, idClutch_, num2, i, makeup, voltage2, wires, crossSection, length, conditions, count, yearLaying, comment, false);
						idClutch_ = num2;
					}
					else
					{
						int idClutch_2 = Cable.InsertVirtualClutch(settings, "02", idObjList);
						Cable.tP_CabSectionAddRow(settings, idObjList, idClutch_, idClutch_2, i, makeup, voltage2, wires, crossSection, length, conditions, count, yearLaying, comment, false);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		public static int InsertPassportCable(int idOldPassport, SQLSettings settings, int idObjList, DateTime date, string number, string state, string name, int region, string sector, int balance, string inventoryNumber, int yearLaying, int yearExpl, int yearRebuild, decimal Isummer, decimal Iwinter, decimal voltage, int buyer, int trest, int smu, int owner, int service)
		{
			int num = Cable.smethod_3(settings, idObjList, date, true, false, idOldPassport);
			if (num <= 0)
			{
				throw new Exception("Inserting passport cable aborted");
			}
			string string_ = string.Format("UPDATE tSchm_ObjList SET Name = '{0}' WHERE id = {1}", name, idObjList);
			Cable.smethod_9(settings, string_);
			Cable.smethod_5(settings, num, new List<Parameter>
			{
				new Parameter(179, number),
				new Parameter(141, state),
				new Parameter(51, region.ToString()),
				new Parameter(140, sector.ToString()),
				new Parameter(53, balance.ToString()),
				new Parameter(54, inventoryNumber),
				new Parameter(52, yearLaying.ToString()),
				new Parameter(55, yearExpl.ToString()),
				new Parameter(56, yearRebuild.ToString()),
				new Parameter(57, Isummer.ToString()),
				new Parameter(58, Iwinter.ToString()),
				new Parameter(59, voltage.ToString()),
				new Parameter(49, buyer.ToString()),
				new Parameter(138, trest.ToString()),
				new Parameter(139, smu.ToString()),
				new Parameter(142, owner.ToString()),
				new Parameter(143, service.ToString())
			}, false);
			return num;
		}

		public static int InsertPassportClutch(SQLSettings settings, int idOldPassport, int idCable, DataTable table, int idPassportCable, string nameClutch, DateTime date, string sector, int type, int street, string house, string adressAddl, int mount, DateTime dateMount, decimal occurrenceDepth, string cableWeight, string installationSiteEnd, string installationMade, string madeBinding)
		{
			int num = Cable.smethod_0(settings, nameClutch, idCable, table);
			if (num <= 0)
			{
				throw new Exception("Inserting clutch is aborted.");
			}
			int num2 = Cable.smethod_4(settings, num, idCable, date, true, false, idOldPassport);
			if (num2 <= 0)
			{
				throw new Exception("Inserting passport clutch is aborted.");
			}
			Cable.smethod_5(settings, num2, new List<Parameter>
			{
				new Parameter(35, sector.ToString()),
				new Parameter(36, type.ToString()),
				new Parameter(145, street.ToString()),
				new Parameter(177, house.ToString()),
				new Parameter(178, adressAddl.ToString()),
				new Parameter(38, mount.ToString()),
				new Parameter(37, dateMount.ToString()),
				new Parameter(40, occurrenceDepth.ToString()),
				new Parameter(41, cableWeight.ToString()),
				new Parameter(144, installationSiteEnd.ToString()),
				new Parameter(42, installationMade.ToString()),
				new Parameter(43, madeBinding.ToString())
			}, false);
			return num;
		}

		public static int InsertVirtualClutch(SQLSettings settings, string name, int idCable)
		{
			string string_ = string.Format("INSERT INTO [tSchm_ObjList]([Name] ,[TypeCodeId],[IdParent],[Deleted],[idParentAddl]) VALUES ('{0}',{1},{2},((0)),{2})", name, 926, idCable);
			return Cable.smethod_8(settings, string_, "tSchm_ObjList");
		}

		private static int smethod_0(SQLSettings sqlsettings_0, string string_0, int int_0, DataTable dataTable_0)
		{
			string string_ = string.Format("INSERT INTO [tSchm_ObjList]([Name],[TypeCodeId],[IdParent] ,[Deleted],[idParentAddl])VALUES ('{0}', 612, {1}, ((0)), {1})", new object[]
			{
				Cable.smethod_1(sqlsettings_0, int_0, string_0, dataTable_0),
				int_0.ToString()
			});
			return Cable.smethod_8(sqlsettings_0, string_, "tSchm_ObjList");
		}

		private static string smethod_1(SQLSettings sqlsettings_0, int int_0, string string_0, DataTable dataTable_0)
		{
			string text = "";
			DataRow[] array = dataTable_0.Select("Муфта = '" + string_0 + "'");
			if (array.Length == 1)
			{
				return string_0;
			}
			if (array.Length == 0)
			{
				throw new Exception("Не найдена муфта");
			}
			for (int i = 1; i < array.Length + 1; i++)
			{
				text = string_0 + "/" + i.ToString();
				if (!Cable.smethod_2(sqlsettings_0, int_0, text))
				{
					return text;
				}
			}
			return text;
		}

		private static bool smethod_2(SQLSettings sqlsettings_0, int int_0, string string_0)
		{
			return (int)new SqlDataCommand(sqlsettings_0).CallSQLScalarFunction("dbo.fn_P_ExistsNameClutch", new string[]
			{
				int_0.ToString(),
				string_0
			}) > 0;
		}

		private static int smethod_3(SQLSettings sqlsettings_0, int int_0, DateTime dateTime_0, bool bool_0, bool bool_1, int int_1)
		{
			string string_ = string.Format("INSERT INTO [tP_Passport] ([idObjList],[idEquipment] ,[Number],[Date],[DateIn],[Deleted],[isActive],[idOldPassport]) VALUES ({0},-1,{1},CONVERT(DATETIME,'{2}'),GetDate(),((0)),((1)),{3})", new object[]
			{
				int_0,
				0,
				string.Concat(new string[]
				{
					dateTime_0.Year.ToString(),
					"/",
					dateTime_0.Month.ToString(),
					"/",
					dateTime_0.Day.ToString()
				}),
				int_1
			});
			return Cable.smethod_8(sqlsettings_0, string_, "tP_Passport");
		}

		private static int smethod_4(SQLSettings sqlsettings_0, int int_0, int int_1, DateTime dateTime_0, bool bool_0, bool bool_1, int int_2)
		{
			string string_ = string.Format("INSERT INTO [tP_Passport] ([ParentId],[idObjList],[idEquipment] ,[Number],[Date],[DateIn],[Deleted],[isActive],[idOldPassport]) VALUES ({0},{1},-1,{2},CONVERT(SMALLDATETIME,'{3}'),GetDate(),((0)),((1)),{4})", new object[]
			{
				int_1,
				int_0,
				0,
				string.Concat(new string[]
				{
					dateTime_0.Year.ToString(),
					"/",
					dateTime_0.Month.ToString(),
					"/",
					dateTime_0.Day.ToString()
				}),
				int_2
			});
			return Cable.smethod_8(sqlsettings_0, string_, "tP_Passport");
		}

		private static bool smethod_5(SQLSettings sqlsettings_0, int int_0, List<Parameter> list_0, bool bool_0)
		{
			foreach (Parameter parameter in list_0)
			{
				string string_ = string.Format("INSERT INTO [tP_ObjectChar] ([idPassport],[idObjChar],[Value],[Deleted]) VALUES({0},{1},'{2}', ((0)))", new object[]
				{
					int_0,
					parameter.IdParameter,
					parameter.Value
				});
				Cable.smethod_8(sqlsettings_0, string_, "tP_ObjectChar");
			}
			return true;
		}

		public static int tP_CabSectionAddRow(SQLSettings settings, int idObjList, int idClutch_1, int idClutch_2, int numberSection, int makeup, decimal voltage, int wires, decimal crossSection, decimal length, string conditions, int count, int yearLaying, string comment, bool deleted)
		{
			string string_ = string.Format("INSERT INTO [tP_CabSection]([idObjList],[idClutchFirst],[idClutchSecond],[Number],[CableMakeup] ,[Voltage],[Wires],[CrossSection],[Length],[Conditions],[Count],[YearLaying],[Comment],[Deleted]) VALUES({0},{1},{2},{3},{4},CAST(REPLACE('{5}', ',', '.') AS NUMERIC(18,2)),{6},CAST(REPLACE('{7}', ',', '.') AS NUMERIC(18,2)),CAST(REPLACE('{8}', ',', '.')AS NUMERIC(18,3)),'{9}',{10},{11},'{12}',((0)))", new object[]
			{
				idObjList,
				idClutch_1,
				idClutch_2,
				numberSection,
				makeup,
				voltage.ToString(),
				wires,
				crossSection.ToString(),
				length.ToString(),
				conditions,
				count,
				yearLaying,
				comment
			});
			return Cable.smethod_8(settings, string_, "tP_CabSection");
		}

		private static int smethod_6(SQLSettings sqlsettings_0, int int_0, int int_1)
		{
			string string_ = string.Format("INSERT INTO [tP_CabOperation] ([idObjList],[DateDecommissioning],[DateCommissioning] ,[Reason],[Deleted]) (SELECT {0},[date_pwr_off],[date_pwr_on],CASE WHEN [reason] = 1 THEN 400 WHEN [reason] = 2 THEN 401 WHEN [reason] = 3 THEN 402 WHEN [reason] = 4 THEN 403 WHEN [reason] = 11 THEN 404 WHEN [reason] = 12 THEN 405 ELSE -1 END AS reason ,((0)) FROM [ULGES-SQL].[Kab].[dbo].[tblRepairs]AS t WHERE t.code = {1} )", int_0, int_1);
			return Cable.smethod_8(sqlsettings_0, string_, "tP_CabOperation");
		}

		private static int smethod_7(SQLSettings sqlsettings_0, int int_0, int int_1)
		{
			string string_ = string.Format("INSERT INTO tP_CabTesting (idObjList, Date, Reason, Voltage, Duration, Conclusion, Deleted) (SELECT {0},[Дата],r.id,[ИН],[ПИ],[Зак],((0)) FROM [ULGES-SQL].[Kab].[dbo].[Испытания кабеля] AS t LEFT JOIN tP_ValueLists AS r ON t.[Причина] = r.Name collate Cyrillic_General_CI_AS AND r.ParentId = 389 WHERE t.[Код] = {1})", int_0, int_1);
			return Cable.smethod_8(sqlsettings_0, string_, "tP_CabTesting");
		}

		private static int smethod_8(SQLSettings sqlsettings_0, string string_0, string string_1)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			int result = -1;
			try
			{
				sqlDataConnect.OpenConnection(sqlsettings_0);
				SqlTransaction sqlTransaction = sqlDataConnect.Connection.BeginTransaction();
				SqlCommand sqlCommand = new SqlCommand(string_0, sqlDataConnect.Connection);
				sqlCommand.Transaction = sqlTransaction;
				sqlCommand.ExecuteNonQuery();
				sqlCommand.CommandText = "select IDENT_CURRENT('" + string_1 + "')";
				result = Convert.ToInt32(sqlCommand.ExecuteScalar());
				sqlTransaction.Commit();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
			return result;
		}

		private static void smethod_9(SQLSettings sqlsettings_0, string string_0)
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			try
			{
				sqlDataConnect.OpenConnection(sqlsettings_0);
				new SqlCommand(string_0, sqlDataConnect.Connection).ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
		}

		private static DataTable smethod_10(SQLSettings sqlsettings_0, string string_0)
		{
			DataTable dataTable = new DataTable();
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			try
			{
				sqlDataConnect.OpenConnection(sqlsettings_0);
				new SqlDataAdapter(new SqlCommand(string_0, sqlDataConnect.Connection)).Fill(dataTable);
				return dataTable;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
			return dataTable;
		}

		private static int smethod_11(string string_0)
		{
			if (string_0 == "1")
			{
				return 756;
			}
			if (string_0 == "2")
			{
				return 757;
			}
			if (string_0 == "3")
			{
				return 758;
			}
			if (!(string_0 == "4") && !(string_0 == "5"))
			{
				return -1;
			}
			return 759;
		}
	}
}
