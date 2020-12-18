using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Constants;
using DailyReportN.DataSet;
using DataSql;

internal class LoadOldDamageLV
{
    private static DataTable dataTableClassifier;
    private static DataTable dataTableSChmObjList;
    private static DataTable dataTableDamageReason;
    private static DataTable dataTableWorker;
    private static DataTable dataTableCompiler;
    private static DataTable dataTableUser;
    private static DataTable dataTablePTSReasonDamage;

    internal static void Load(SQLSettings sqlsettingsIN, SQLSettings sqlsettingsOUT)
	{
		LoadOldDamageLV.dataTableDamageReason = null;
		LoadOldDamageLV.dataTableSChmObjList = null;
		LoadOldDamageLV.dataTableWorker = null;
		LoadOldDamageLV.dataTableCompiler = null;
		LoadOldDamageLV.dataTableUser = null;
		LoadOldDamageLV.dataTablePTSReasonDamage = null;
		LoadOldDamageLV.CreateTableClassifier(sqlsettingsIN);
		using (SqlConnection sqlConnectionOUT = new SqlConnection(sqlsettingsOUT.GetConnectionString()))
		{
			sqlConnectionOUT.Open();
			using (SqlConnection sqlConnectionIN = new SqlConnection(sqlsettingsIN.GetConnectionString()))
			{
				sqlConnectionIN.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.CommandTimeout = 0;
				sqlCommand.Connection = sqlConnectionOUT;
				sqlCommand.CommandText = "select * from [Низкое]";
				sqlCommand.CommandText += " where [Дата] < '20151012'";
				sqlCommand.CommandText += " order by [Дата]";
				DbDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();
				dbDataAdapter.Fill(dataTable);
				SqlCommand sqlCommand2 = new SqlCommand();
				sqlCommand2.Connection = sqlConnectionIN;
				int num = 0;
				foreach (DataRow dataRow in dataTable.Rows)
				{
					num++;
                    dsDamage ds = new dsDamage();
					DataRow dataRow2 = ds.tJ_Damage.NewRow();
					if (sqlsettingsOUT.DBName == "SR")
					{
						dataRow2["idDivision"] = 1405;
					}
					if (sqlsettingsOUT.DBName == "SR4")
					{
						dataRow2["idDivision"] = 1406;
					}
					dataRow2["TypeDoc"] = 1401;
					dataRow2["numRequest"] = dataRow["индекс"];
					DateTime? dateTime = null;
					if (dataRow["Дата"] != DBNull.Value)
					{
						dateTime = new DateTime?(Convert.ToDateTime(dataRow["Дата"]).Date);
						if (dataRow["Время1"] != DBNull.Value)
						{
							dateTime += Convert.ToDateTime(dataRow["Время1"]).TimeOfDay;
						}
						dataRow2["dateDoc"] = dateTime;
						dataRow2["dateOwner"] = dateTime;
						string text = LoadOldDamageLV.GetCompiler(sqlsettingsOUT, dateTime.Value);
						if (!string.IsNullOrEmpty(text))
						{
							int? idCompiler = LoadOldDamageLV.GetWorker(sqlsettingsIN, text);
							if (idCompiler != null)
							{
								dataRow2["idCompiler"] = idCompiler;
								int? idWorker = LoadOldDamageLV.GetUser(sqlsettingsIN, idCompiler.Value);
								if (idWorker != null)
								{
									dataRow2["idOwner"] = idWorker;
								}
							}
						}
					}
					string DefectLocation = "";
					int? idMAp = null;
					if (dataRow["Улица"] != DBNull.Value && dataRow["Дом"] != DBNull.Value)
					{
						string street = dataRow["Улица"].ToString();
						street = LoadOldDamageLV.GetReestrStreet(street);
						street = Regex.Replace(street, "[.]", "");
						if (!(street == "Л.Шевцовой"))
						{
						}
						DataTable dtKladrStreet = LoadOldDamageLV.CreateTableKladrStreet(sqlCommand2, string.Format("select * from tr_kladrstreet where KladrObjId = 24 and ((name + ' ' + socr)  = '{0}'\r\n                                                                                    or replace(name, '1-й', '1')+' ' + socr = '{0}' \r\n                                                                                    or replace(name, '2-й', '2')+' ' + socr = '{0}' \r\n                                                                                    or replace(name, '3-й', '3')+' ' + socr = '{0}' \r\n                                                                                    or replace(name, '5-й', '5')+' ' + socr = '{0}' \r\n                                                                                    or replace(name, '4-й', '4')+' ' + socr = '{0}') ", street));
						if (dtKladrStreet.Rows.Count > 0)
						{
							LoadOldDamageLV.CreateDefectLocation(sqlsettingsIN, dtKladrStreet, dataRow, out DefectLocation, out idMAp);
						}
						else
						{
							dtKladrStreet = LoadOldDamageLV.CreateTableKladrStreet(sqlCommand2, "select * from tr_kladrstreet where KladrObjId = 24 and name  = '" + street + "' and socr = 'ул'");
							if (dtKladrStreet.Rows.Count > 0)
							{
								LoadOldDamageLV.CreateDefectLocation(sqlsettingsIN, dtKladrStreet, dataRow, out DefectLocation, out idMAp);
							}
							else
							{
                                dtKladrStreet = LoadOldDamageLV.CreateTableKladrStreet(sqlCommand2, "select * from tr_kladrstreet where KladrObjId = 24 and name  = '" + street + "'");
								if (dtKladrStreet.Rows.Count > 0)
								{
									LoadOldDamageLV.CreateDefectLocation(sqlsettingsIN, dtKladrStreet, dataRow, out DefectLocation, out idMAp);
								}
								else
								{
									DefectLocation = dataRow["Улица"].ToString() + " " + dataRow["Дом"].ToString();
								}
							}
						}
					}
					else
					{
						if (dataRow["Улица"] != DBNull.Value)
						{
							DefectLocation = dataRow["Улица"].ToString();
						}
						if (dataRow["Дом"] != DBNull.Value)
						{
							DefectLocation = dataRow["Дом"].ToString();
						}
					}
					if (idMAp != null)
					{
						dataRow2["idMAp"] = idMAp;
					}
					if (!string.IsNullOrEmpty(DefectLocation))
					{
						dataRow2["DEfectLocation"] = DefectLocation;
					}
					if (dataRow["№ТП"] != DBNull.Value)
					{
						int? idSchmObj = LoadOldDamageLV.GetIdSchmObj(sqlsettingsIN, dataRow["№ТП"].ToString());
						if (idSchmObj != null)
						{
							dataRow2["idSchmObj"] = idSchmObj;
						}
						else if (dataRow2["DEfectLocation"] == DBNull.Value)
						{
							dataRow2["DEfectLocation"] = dataRow["№ТП"].ToString();
						}
						else
						{
							dataRow2["DEfectLocation"] = dataRow2["DEfectLocation"].ToString() + "\r\n" + dataRow["№ТП"].ToString();
						}
					}
					if (dataRow["Заявка"] != DBNull.Value)
					{
						int? idReason = LoadOldDamageLV.GetReason(sqlsettingsIN, dataRow["Заявка"].ToString());
						if (idReason != null)
						{
							dataRow2["idReason"] = idReason;
						}
						else if (dataRow2["DEfectLocation"] == DBNull.Value)
						{
							dataRow2["DEfectLocation"] = dataRow["Заявка"].ToString();
						}
						else
						{
							dataRow2["DEfectLocation"] = dataRow2["DEfectLocation"].ToString() + "\r\n" + dataRow["Заявка"].ToString();
						}
					}
					if (dataRow["ДатаИ"] != DBNull.Value)
					{
						DateTime d = Convert.ToDateTime(dataRow["ДатаИ"]).Date;
						if (dataRow["Время2"] != DBNull.Value)
						{
							d += Convert.ToDateTime(dataRow["Время2"]).TimeOfDay;
						}
						dataRow2["dateApply"] = dateTime;
						dataRow2["isApply"] = true;
					}
					if (dataRow["Флажок"] != DBNull.Value)
					{
						dataRow2["ComletedWorkText"] = dataRow["Флажок"];
					}
					if (dataRow["Исполнитель"] != DBNull.Value)
					{
						int? idWorkerApply = LoadOldDamageLV.GetWorker(sqlsettingsIN, dataRow["Исполнитель"].ToString());
						if (idWorkerApply != null)
						{
							dataRow2["idWorkerApply"] = idWorkerApply;
						}
					}
					if (dataRow["Код"] != DBNull.Value)
					{
						int? idREasonPTS = LoadOldDamageLV.GetREasonPTS(sqlsettingsIN, dataRow["Код"].ToString());
						if (idREasonPTS != null)
						{
							dataRow2["idREasonPTS"] = idREasonPTS;
						}
					}
					ds.tJ_Damage.Rows.Add(dataRow2);
					int idDamage = new SqlDataCommand(sqlsettingsIN).InsertSqlDataOneRow(ds.tJ_Damage);
					if (idDamage > 0 && dataRow["Причина"] != DBNull.Value && dataRow["Причина"].ToString() != "" && Convert.ToInt32(dataRow["Причина"]) > 0)
					{
						LoadOldDamageLV.AddRowsDamageCharacte(idDamage, Convert.ToInt32(dataRow["Причина"]), sqlsettingsIN);
					}
				}
			}
		}
	}

	private static void AddRowsDamageCharacte(int idDamage, int CodeLevelClassifer, SQLSettings sqlsettings)
	{
		dsDamage ds = new dsDamage();
		DataRow dataRow = ds.tJ_DamageCharacter.NewRow();
		dataRow["idDamage"] = idDamage;
		string text = CodeLevelClassifer.ToString();
		if (text.Length > 0)
		{
			DataRow[] array = LoadOldDamageLV.dataTableClassifier.Select(string.Format("ParentKey = ';REportDaily;NatureDamage;LV;Code{0};'", text[0]));
			if (array.Length != 0)
			{
				dataRow["col1"] = array[0]["id"];
			}
		}
		if (text.Length > 1)
		{
			DataRow[] array2 = LoadOldDamageLV.dataTableClassifier.Select(string.Format("ParentKey = ';REportDaily;NatureDamage;LV;Code{0};Code{1};'", text[0], text[1]));
			if (array2.Length != 0)
			{
				dataRow["col2"] = array2[0]["id"];
			}
		}
		if (text.Length > 2)
		{
			DataRow[] array3 = LoadOldDamageLV.dataTableClassifier.Select(string.Format("ParentKey = ';REportDaily;NatureDamage;LV;Code{0};Code{1};Code{2};'", text[0], text[1], text[2]));
			if (array3.Length != 0)
			{
				dataRow["col3"] = array3[0]["id"];
			}
		}
		ds.tJ_DamageCharacter.Rows.Add(dataRow);
		new SqlDataCommand(sqlsettings).InsertSqlData(ds, ds.tJ_DamageCharacter);
	}

	private static void CreateTableClassifier(SQLSettings sqlsettings)
	{
		dataTableClassifier = new SqlDataCommand(sqlsettings).SelectSqlData("tR_Classifier", true, "where  parentKey like ';REportDaily;NatureDamage;LV;%'", null);
	}

	private static DataTable CreateTableKladrStreet(SqlCommand sqlCommand, string CommandTextSQL)
	{
		DataTable result;
		try
		{
			sqlCommand.CommandText = CommandTextSQL;
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			result = dataTable;
		}
		catch
		{
			result = LoadOldDamageLV.CreateTableKladrStreet(sqlCommand, CommandTextSQL);
		}
		return result;
	}

	private static int AddRowsMapObj(SQLSettings sqlsettings, int Street, int House, string HousePrefix)
	{
        dsDamage ds = new dsDamage();
        SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings);
		string text = string.IsNullOrEmpty(HousePrefix) ? " and HousePrefix is null " : (" and HousePrefix = '" + HousePrefix + "'");
		sqlDataCommand.SelectSqlData(ds.tMapObj, true, string.Concat(new string[]
		{
			"where Street = ",
			Street.ToString(),
			" and House = ",
			House.ToString(),
			text,
			" and IsHouse = 1 and Name is null"
		}), null, false, 0);
		if (ds.tMapObj.Rows.Count > 0)
		{
			return Convert.ToInt32(ds.tMapObj.Rows[0]["idMap"]);
		}
		DataRow dataRow = ds.tMapObj.NewRow();
		dataRow["Street"] = Street;
		dataRow["House"] = House;
		if (!string.IsNullOrEmpty(HousePrefix))
		{
			dataRow["HousePrefix"] = HousePrefix;
		}
		dataRow["IsHouse"] = true;
		dataRow["Deleted"] = 0;
		ds.tMapObj.Rows.Add(dataRow);
		ds.tMapObj.Rows[0].EndEdit();
		return sqlDataCommand.InsertSqlDataOneRow(ds.tMapObj);
	}

	private static void CreateDefectLocation(SQLSettings sqlsettings, DataTable dtKladrStreet, DataRow dataRow, out string DefectLocation, out int? idMAp)
	{
		idMAp = null;
		DefectLocation = "";
		string textHouse = dataRow["Дом"].ToString();
		if (string.IsNullOrEmpty(textHouse))
		{
			DefectLocation = dataRow["Улица"].ToString();
			return;
		}
		if (!char.IsDigit(textHouse[0]))
		{
			DefectLocation = dataRow["Улица"].ToString() + " " + textHouse;
			return;
		}
		int num = textHouse.Length - 1;
;
        for (int i = 0; i < textHouse.Length; i++)
        {
            if (!char.IsDigit(textHouse[i]))
            {
                num = i - 1;
                break;
            }
        }
        int House = Convert.ToInt32(textHouse.Substring(0, num + 1));
        if (textHouse.Length - 1 > num && textHouse.Length - num <= 3)
        {
            string HousePrefix = textHouse.Substring(num + 1);
            idMAp = new int?(LoadOldDamageLV.AddRowsMapObj(sqlsettings, Convert.ToInt32(dtKladrStreet.Rows[0]["id"]), House, HousePrefix));
        }
        else
        {
            idMAp = new int?(LoadOldDamageLV.AddRowsMapObj(sqlsettings, Convert.ToInt32(dtKladrStreet.Rows[0]["id"]), House, ""));
            DefectLocation = textHouse.Substring(num + 1);
        }
    }

    private static string GetReestrStreet(string strStreetReplace)
	{
		strStreetReplace = strStreetReplace.Replace("Л.Шевцовой", "Любови Шевцовой");
		strStreetReplace = strStreetReplace.Replace("Б.Хмельницкого", "Богдана Хмельницкого");
		strStreetReplace = strStreetReplace.Replace("1 Зап. пригоpод", "Западный Пригород 1-я");
		strStreetReplace = strStreetReplace.Replace("1 Зап. Пригоpод", "Западный Пригород 1-я");
		strStreetReplace = strStreetReplace.Replace("Халтурина спуск", "Спуск Халтурина");
		strStreetReplace = strStreetReplace.Replace("Фруктовая 1", "Фруктовая");
		strStreetReplace = strStreetReplace.Replace("У.Громовой", "Ульяны Громовой");
		strStreetReplace = strStreetReplace.Replace("9-го Мая", "9 Мая");
		strStreetReplace = strStreetReplace.Replace("З.Космодемьянской", "Зои Космодемьянской");
		strStreetReplace = strStreetReplace.Replace("Л.Толстого", "Льва Толстого");
		strStreetReplace = strStreetReplace.Replace("Матросова", "Александра Матросова");
		strStreetReplace = strStreetReplace.Replace("Наб.р.симбирки", "Набережная реки Симбирки");
		strStreetReplace = strStreetReplace.Replace("К.Маркса", "Карла Маркса");
		strStreetReplace = strStreetReplace.Replace("Нариманова просп.", "Нариманова пр-кт");
		strStreetReplace = strStreetReplace.Replace("Ново свияжск.пригород", "Новосвияжский Пригород");
		strStreetReplace = strStreetReplace.Replace("Верхне Полевая", "Верхнеполевая");
		strStreetReplace = strStreetReplace.Replace("Вр.Михайлова", "Врача Михайлова");
		strStreetReplace = strStreetReplace.Replace("Д.Ульянова", "Дмитрия Ульянова");
		strStreetReplace = strStreetReplace.Replace("Ж.Дивизии", "Железной Дивизии");
		strStreetReplace = strStreetReplace.Replace("Зап. Бульвар", "Западный б-р");
		strStreetReplace = strStreetReplace.Replace("Лазо", "Сергея Лазо");
		strStreetReplace = strStreetReplace.Replace("Тюленина", "Сергея Тюленина");
		strStreetReplace = strStreetReplace.Replace("Московское шоссе", "Московское ш");
		strStreetReplace = strStreetReplace.Replace("К.Либкнехта", "Карла Либкнехта");
		strStreetReplace = strStreetReplace.Replace("О.Кошевого", "Олега Кошевого");
		strStreetReplace = strStreetReplace.Replace("Наб.р.свияги", "Набережная реки Свияги");
		strStreetReplace = strStreetReplace.Replace("Минаева спуск", "Спуск Минаева");
		strStreetReplace = strStreetReplace.Replace("Немировича Данченко", "Немировича-Данченко");
		strStreetReplace = strStreetReplace.Replace("Р.Люксембург", "Розы Люксембург");
		strStreetReplace = strStreetReplace.Replace("Старо-сельденская", "Старосельдинская");
		strStreetReplace = strStreetReplace.Replace("Нижне-Полевая", "Нижнеполевая");
		strStreetReplace = strStreetReplace.Replace("Полбина п-д", "Полбина проезд");
		strStreetReplace = strStreetReplace.Replace("Нижне-Татарская", "Нижнетатарская");
		strStreetReplace = strStreetReplace.Replace("Старо свияжск.пригород", "Старосвияжский Пригород");
		strStreetReplace = strStreetReplace.Replace("П.Морозова", "Павлика Морозова");
		strStreetReplace = strStreetReplace.Replace("проезд Аверьянова", "Героя России Аверьянова");
		strStreetReplace = strStreetReplace.Replace("Проспект Гая", "Гая пр-кт");
		strStreetReplace = strStreetReplace.Replace("С.Разина спуск", "Спуск Степана Разина");
		strStreetReplace = strStreetReplace.Replace("2 Зап. Пригород", "Западный Пригород 2-я");
		strStreetReplace = strStreetReplace.Replace("Прокофьева п.р.", "Прокофьева проезд");
		strStreetReplace = strStreetReplace.Replace("С.Разина", "Степана Разина");
		return strStreetReplace;
	}

	private static int? GetIdSchmObj(SQLSettings sqlsettings, string name)
	{
		if (LoadOldDamageLV.dataTableSChmObjList == null || LoadOldDamageLV.dataTableSChmObjList.Rows.Count == 0)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings);
			string listTypeCodeId = "";
			foreach (SchmTypeSubstation schmTypeSubstation in Enum.GetValues(typeof(SchmTypeSubstation)))
			{
				if (string.IsNullOrEmpty(listTypeCodeId))
				{
					int num = (int)schmTypeSubstation;
					listTypeCodeId = num.ToString();
				}
				else
				{
					string str = listTypeCodeId;
					string str2 = ",";
					int num = (int)schmTypeSubstation;
					listTypeCodeId = str + str2 + num.ToString();
				}
			}
			LoadOldDamageLV.dataTableSChmObjList = sqlDataCommand.SelectSqlData("tSChm_ObjList", true, " where typeCodeId in (" + listTypeCodeId + ") and deleted = 0 ", null);
		}
		DataRow[] array = LoadOldDamageLV.dataTableSChmObjList.Select("name = '" + name + "'");
		if (array.Length != 0)
		{
			return new int?(Convert.ToInt32(array[0]["id"]));
		}
		return null;
	}

	private static int? GetReason(SQLSettings sqlsettings, string name)
	{
		if (LoadOldDamageLV.dataTableDamageReason == null || LoadOldDamageLV.dataTableDamageReason.Rows.Count == 0)
		{
			LoadOldDamageLV.dataTableDamageReason = new SqlDataCommand(sqlsettings).SelectSqlData("tR_Classifier", true, " where ParentKey = ';ReportDaily;DamageReason;LV;' and isgroup = 0 and deleted = 0 order by name", null);
		}
		DataRow[] array = LoadOldDamageLV.dataTableDamageReason.Select("name = '" + name.Replace("'", "''") + "'");
		if (array.Length != 0)
		{
			return new int?(Convert.ToInt32(array[0]["id"]));
		}
		return null;
	}

	private static int? GetWorker(SQLSettings sqlsettings, string fio)
	{
		if (LoadOldDamageLV.dataTableWorker == null || LoadOldDamageLV.dataTableWorker.Rows.Count == 0)
		{
			LoadOldDamageLV.dataTableWorker = new SqlDataCommand(sqlsettings).SelectSqlData("vR_Worker", true, " order by dateEnd", null);
		}
		DataRow[] array = LoadOldDamageLV.dataTableWorker.Select("fio = '" + fio + "'");
		if (array.Length != 0)
		{
			return new int?(Convert.ToInt32(array[0]["id"]));
		}
		return null;
	}

	private static string GetCompiler(SQLSettings sqlsettings, DateTime dateTime)
	{
		if (LoadOldDamageLV.dataTableCompiler == null || LoadOldDamageLV.dataTableCompiler.Rows.Count == 0)
		{
			LoadOldDamageLV.dataTableCompiler = new SqlDataCommand(sqlsettings).SelectSqlData("select [Дата1], [составил] from СоставительНизкого");
		}
		DataRow[] array = LoadOldDamageLV.dataTableCompiler.Select(string.Format("[Дата1] = '{0:o}'", dateTime.Date));
		if (array.Length != 0)
		{
			return array[0]["составил"].ToString();
		}
		return null;
	}

	private static int? GetUser(SQLSettings sqlsettings, int idWorker)
	{
		if (LoadOldDamageLV.dataTableUser == null || LoadOldDamageLV.dataTableUser.Rows.Count == 0)
		{
			LoadOldDamageLV.dataTableUser = new SqlDataCommand(sqlsettings).SelectSqlData("tuser", true, " ", null);
		}
		DataRow[] array = LoadOldDamageLV.dataTableUser.Select("idWorker = " + idWorker.ToString());
		if (array.Length != 0)
		{
			return new int?(Convert.ToInt32(array[0]["iduser"]));
		}
		return null;
	}

	private static int? GetREasonPTS(SQLSettings sqlsettings, string idREasonPTS)
	{
		if (LoadOldDamageLV.dataTablePTSReasonDamage == null || LoadOldDamageLV.dataTablePTSReasonDamage.Rows.Count == 0)
		{
			LoadOldDamageLV.dataTablePTSReasonDamage = new SqlDataCommand(sqlsettings).SelectSqlData("tr_classifier", true, "where parentKey like ';ReportDaily;PTS;ReasonDamage;LV;%' and isgroup = 0 and deleted = 0", null);
		}
		DataRow[] array = LoadOldDamageLV.dataTablePTSReasonDamage.Select("value = " + idREasonPTS);
		if (array.Length != 0)
		{
			return new int?(Convert.ToInt32(array[0]["id"]));
		}
		return null;
	}
}
