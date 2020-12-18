using Constants;
using DataSql;
using Documents.Forms.DailyReport.DataSets;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

internal class LoadOldDamageLV
{
    private static DataTable dataTable_0;
    private static DataTable dataTable_1;
    private static DataTable dataTable_2;
    private static DataTable dataTable_3;
    private static DataTable dataTable_4;
    private static DataTable dataTable_5;
    private static DataTable dataTable_6;

    internal static void Load(SQLSettings sqlsettings_0, SQLSettings sqlsettings_1)
    {
        dataTable_2 = null;
        dataTable_1 = null;
        dataTable_3 = null;
        dataTable_4 = null;
        dataTable_5 = null;
        dataTable_6 = null;
        smethod_2(sqlsettings_0);
        using (SqlConnection connection = new SqlConnection(sqlsettings_1.GetConnectionString()))
        {
            connection.Open();
            using (SqlConnection connection2 = new SqlConnection(sqlsettings_0.GetConnectionString()))
            {
                connection2.Open();
                SqlCommand selectCommand = new SqlCommand {
                    CommandTimeout = 0,
                    Connection = connection,
                    CommandText = "select * from [Низкое]"
                };
                selectCommand.CommandText = selectCommand.CommandText + " where [Дата] < '20151012'";
                selectCommand.CommandText = selectCommand.CommandText + " order by [Дата]";
                DataTable dataTable = new DataTable();
                new SqlDataAdapter(selectCommand).Fill(dataTable);
                SqlCommand command = new SqlCommand {
                    Connection = connection2
                };
                int num = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    num++;
                    DataSetDamage damage = new DataSetDamage();
                    DataRow row2 = damage.tJ_Damage.NewRow();
                    if (sqlsettings_1.DBName == "SR")
                    {
                        row2["idDivision"] = 0x57d;
                    }
                    if (sqlsettings_1.DBName == "SR4")
                    {
                        row2["idDivision"] = 0x57e;
                    }
                    row2["TypeDoc"] = 0x579;
                    row2["numRequest"] = row["индекс"];
                    DateTime? nullable = null;
                    if (row["Дата"] != DBNull.Value)
                    {
                        nullable = new DateTime?(Convert.ToDateTime(row["Дата"]).Date);
                        if (row["Время1"] != DBNull.Value)
                        {
                            DateTime? nullable3 = nullable;
                            TimeSpan timeOfDay = Convert.ToDateTime(row["Время1"]).TimeOfDay;
                            nullable = nullable3.HasValue ? new DateTime?(nullable3.GetValueOrDefault() + timeOfDay) : null;
                        }
                        row2["dateDoc"] = nullable;
                        row2["dateOwner"] = nullable;
                        string str2 = smethod_10(sqlsettings_1, nullable.Value);
                        if (!string.IsNullOrEmpty(str2))
                        {
                            int? nullable5 = smethod_9(sqlsettings_0, str2);
                            if (nullable5.HasValue)
                            {
                                row2["idCompiler"] = nullable5;
                                int? nullable6 = smethod_11(sqlsettings_0, nullable5.Value);
                                if (nullable6.HasValue)
                                {
                                    row2["idOwner"] = nullable6;
                                }
                            }
                        }
                    }
                    string str = "";
                    int? nullable2 = null;
                    if ((row["Улица"] != DBNull.Value) && (row["Дом"] != DBNull.Value))
                    {
                        string str3 = Regex.Replace(smethod_6(row["Улица"].ToString()), "[.]", "");
                        if (str3 == "Л.Шевцовой")
                        {
                        }
                        DataTable table2 = smethod_3(command, string.Format("select * from tr_kladrstreet where KladrObjId = 24 and ((name + ' ' + socr)  = '{0}'\r\n                                                                                    or replace(name, '1-й', '1')+' ' + socr = '{0}' \r\n                                                                                    or replace(name, '2-й', '2')+' ' + socr = '{0}' \r\n                                                                                    or replace(name, '3-й', '3')+' ' + socr = '{0}' \r\n                                                                                    or replace(name, '5-й', '5')+' ' + socr = '{0}' \r\n                                                                                    or replace(name, '4-й', '4')+' ' + socr = '{0}') ", str3));
                        if (table2.Rows.Count > 0)
                        {
                            smethod_5(sqlsettings_0, table2, row, out str, out nullable2);
                        }
                        else
                        {
                            table2 = smethod_3(command, "select * from tr_kladrstreet where KladrObjId = 24 and name  = '" + str3 + "' and socr = 'ул'");
                            if (table2.Rows.Count > 0)
                            {
                                smethod_5(sqlsettings_0, table2, row, out str, out nullable2);
                            }
                            else
                            {
                                table2 = smethod_3(command, "select * from tr_kladrstreet where KladrObjId = 24 and name  = '" + str3 + "'");
                                if (table2.Rows.Count > 0)
                                {
                                    smethod_5(sqlsettings_0, table2, row, out str, out nullable2);
                                }
                                else
                                {
                                    str = row["Улица"].ToString() + " " + row["Дом"].ToString();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (row["Улица"] != DBNull.Value)
                        {
                            str = row["Улица"].ToString();
                        }
                        if (row["Дом"] != DBNull.Value)
                        {
                            str = row["Дом"].ToString();
                        }
                    }
                    if (nullable2.HasValue)
                    {
                        row2["idMAp"] = nullable2;
                    }
                    if (!string.IsNullOrEmpty(str))
                    {
                        row2["DEfectLocation"] = str;
                    }
                    if (row["№ТП"] != DBNull.Value)
                    {
                        int? nullable7 = smethod_7(sqlsettings_0, row["№ТП"].ToString());
                        if (nullable7.HasValue)
                        {
                            row2["idSchmObj"] = nullable7;
                        }
                        else if (row2["DEfectLocation"] == DBNull.Value)
                        {
                            row2["DEfectLocation"] = row["№ТП"].ToString();
                        }
                        else
                        {
                            row2["DEfectLocation"] = row2["DEfectLocation"].ToString() + "\r\n" + row["№ТП"].ToString();
                        }
                    }
                    if (row["Заявка"] != DBNull.Value)
                    {
                        int? nullable8 = smethod_8(sqlsettings_0, row["Заявка"].ToString());
                        if (nullable8.HasValue)
                        {
                            row2["idReason"] = nullable8;
                        }
                        else if (row2["DEfectLocation"] == DBNull.Value)
                        {
                            row2["DEfectLocation"] = row["Заявка"].ToString();
                        }
                        else
                        {
                            row2["DEfectLocation"] = row2["DEfectLocation"].ToString() + "\r\n" + row["Заявка"].ToString();
                        }
                    }
                    if (row["ДатаИ"] != DBNull.Value)
                    {
                        DateTime date = Convert.ToDateTime(row["ДатаИ"]).Date;
                        if (row["Время2"] != DBNull.Value)
                        {
                            date += Convert.ToDateTime(row["Время2"]).TimeOfDay;
                        }
                        row2["dateApply"] = nullable;
                        row2["isApply"] = true;
                    }
                    if (row["Флажок"] != DBNull.Value)
                    {
                        row2["ComletedWorkText"] = row["Флажок"];
                    }
                    if (row["Исполнитель"] != DBNull.Value)
                    {
                        int? nullable9 = smethod_9(sqlsettings_0, row["Исполнитель"].ToString());
                        if (nullable9.HasValue)
                        {
                            row2["idWorkerApply"] = nullable9;
                        }
                    }
                    if (row["Код"] != DBNull.Value)
                    {
                        int? nullable10 = smethod_12(sqlsettings_0, row["Код"].ToString());
                        if (nullable10.HasValue)
                        {
                            row2["idREasonPTS"] = nullable10;
                        }
                    }
                    damage.tJ_Damage.Rows.Add(row2);
                    int num2 = new SqlDataCommand(sqlsettings_0).InsertSqlDataOneRow(damage.tJ_Damage);
                    if (((num2 > 0) && (row["Причина"] != DBNull.Value)) && ((row["Причина"].ToString() != "") && (Convert.ToInt32(row["Причина"]) > 0)))
                    {
                        smethod_1(num2, Convert.ToInt32(row["Причина"]), sqlsettings_0);
                    }
                }
            }
        }
    }

    private static void smethod_1(int int_0, int int_1, SQLSettings sqlsettings_0)
    {
        DataSetDamage damage = new DataSetDamage();
        DataRow row = damage.tJ_DamageCharacter.NewRow();
        row["idDamage"] = int_0;
        string str = int_1.ToString();
        if (str.Length > 0)
        {
            DataRow[] rowArray = dataTable_0.Select(string.Format("ParentKey = ';REportDaily;NatureDamage;LV;Code{0};'", str[0]));
            if (rowArray.Length != 0)
            {
                row["col1"] = rowArray[0]["id"];
            }
        }
        if (str.Length > 1)
        {
            DataRow[] rowArray2 = dataTable_0.Select(string.Format("ParentKey = ';REportDaily;NatureDamage;LV;Code{0};Code{1};'", str[0], str[1]));
            if (rowArray2.Length != 0)
            {
                row["col2"] = rowArray2[0]["id"];
            }
        }
        if (str.Length > 2)
        {
            DataRow[] rowArray3 = dataTable_0.Select(string.Format("ParentKey = ';REportDaily;NatureDamage;LV;Code{0};Code{1};Code{2};'", str[0], str[1], str[2]));
            if (rowArray3.Length != 0)
            {
                row["col3"] = rowArray3[0]["id"];
            }
        }
        damage.tJ_DamageCharacter.Rows.Add(row);
        new SqlDataCommand(sqlsettings_0).InsertSqlData(damage, damage.tJ_DamageCharacter);
    }

    private static string smethod_10(SQLSettings sqlsettings_0, DateTime dateTime_0)
    {
        if ((dataTable_4 == null) || (dataTable_4.Rows.Count == 0))
        {
            dataTable_4 = new SqlDataCommand(sqlsettings_0).SelectSqlData("select [Дата1], [составил] from СоставительНизкого");
        }
        DataRow[] rowArray = dataTable_4.Select(string.Format("[Дата1] = '{0:o}'", dateTime_0.Date));
        if (rowArray.Length != 0)
        {
            return rowArray[0]["составил"].ToString();
        }
        return null;
    }

    private static int? smethod_11(SQLSettings sqlsettings_0, int int_0)
    {
        if ((dataTable_5 == null) || (dataTable_5.Rows.Count == 0))
        {
            int? nullable = null;
            dataTable_5 = new SqlDataCommand(sqlsettings_0).SelectSqlData("tuser", true, " ", nullable);
        }
        DataRow[] rowArray = dataTable_5.Select("idWorker = " + int_0.ToString());
        if (rowArray.Length != 0)
        {
            return new int?(Convert.ToInt32(rowArray[0]["iduser"]));
        }
        return null;
    }

    private static int? smethod_12(SQLSettings sqlsettings_0, string string_0)
    {
        if ((dataTable_6 == null) || (dataTable_6.Rows.Count == 0))
        {
            int? nullable = null;
            dataTable_6 = new SqlDataCommand(sqlsettings_0).SelectSqlData("tr_classifier", true, "where parentKey like ';ReportDaily;PTS;ReasonDamage;LV;%' and isgroup = 0 and deleted = 0", nullable);
        }
        DataRow[] rowArray = dataTable_6.Select("value = " + string_0);
        if (rowArray.Length != 0)
        {
            return new int?(Convert.ToInt32(rowArray[0]["id"]));
        }
        return null;
    }

    private static void smethod_2(SQLSettings sqlsettings_0)
    {
        dataTable_0 = new SqlDataCommand(sqlsettings_0).SelectSqlData("tR_Classifier", true, "where  parentKey like ';REportDaily;NatureDamage;LV;%'", null);
    }

    private static DataTable smethod_3(SqlCommand sqlCommand_0, string string_0)
    {
        try
        {
            sqlCommand_0.CommandText = string_0;
            DataTable dataTable = new DataTable();
            new SqlDataAdapter(sqlCommand_0).Fill(dataTable);
            return dataTable;
        }
        catch
        {
            return smethod_3(sqlCommand_0, string_0);
        }
    }

    private static int smethod_4(SQLSettings sqlsettings_0, int int_0, int int_1, string string_0)
    {
        DataSetDamage damage = new DataSetDamage();
        SqlDataCommand command = new SqlDataCommand(sqlsettings_0);
        string str = string.IsNullOrEmpty(string_0) ? " and HousePrefix is null " : (" and HousePrefix = '" + string_0 + "'");
        command.SelectSqlData(damage.tMapObj, true, "where Street = " + int_0.ToString() + " and House = " + int_1.ToString() + str + " and IsHouse = 1 and Name is null", null, false, 0);
        if (damage.tMapObj.Rows.Count > 0)
        {
            return Convert.ToInt32(damage.tMapObj.Rows[0]["idMap"]);
        }
        DataRow row = damage.tMapObj.NewRow();
        row["Street"] = int_0;
        row["House"] = int_1;
        if (!string.IsNullOrEmpty(string_0))
        {
            row["HousePrefix"] = string_0;
        }
        row["IsHouse"] = true;
        row["Deleted"] = 0;
        damage.tMapObj.Rows.Add(row);
        damage.tMapObj.Rows[0].EndEdit();
        return command.InsertSqlDataOneRow(damage.tMapObj);
    }

    private static void smethod_5(SQLSettings sqlsettings_0, DataTable dataTable_7, DataRow dataRow_0, out string string_0, out int? nullable_0)
    {
        nullable_0 = 0;
        string_0 = "";
        string str = dataRow_0["Дом"].ToString();
        string str2 = "";
        if (string.IsNullOrEmpty(str))
        {
            string_0 = dataRow_0["Улица"].ToString();
        }
        else if (!char.IsDigit(str[0]))
        {
            string_0 = dataRow_0["Улица"].ToString() + " " + str;
        }
        else
        {
            int num2 = str.Length - 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    num2 = i - 1;
                    break;
                }
            }
            int num = Convert.ToInt32(str.Substring(0, num2 + 1));
            if (((str.Length - 1) > num2) && ((str.Length - num2) <= 3))
            {
                str2 = str.Substring(num2 + 1);
                nullable_0 = new int?(smethod_4(sqlsettings_0, Convert.ToInt32(dataTable_7.Rows[0]["id"]), num, str2));
            }
            else
            {
                nullable_0 = new int?(smethod_4(sqlsettings_0, Convert.ToInt32(dataTable_7.Rows[0]["id"]), num, ""));
                string_0 = str.Substring(num2 + 1);
            }
        }
    }

    private static string smethod_6(string string_0)
    {
        string_0 = string_0.Replace("Л.Шевцовой", "Любови Шевцовой");
        string_0 = string_0.Replace("Б.Хмельницкого", "Богдана Хмельницкого");
        string_0 = string_0.Replace("1 Зап. пригоpод", "Западный Пригород 1-я");
        string_0 = string_0.Replace("1 Зап. Пригоpод", "Западный Пригород 1-я");
        string_0 = string_0.Replace("Халтурина спуск", "Спуск Халтурина");
        string_0 = string_0.Replace("Фруктовая 1", "Фруктовая");
        string_0 = string_0.Replace("У.Громовой", "Ульяны Громовой");
        string_0 = string_0.Replace("9-го Мая", "9 Мая");
        string_0 = string_0.Replace("З.Космодемьянской", "Зои Космодемьянской");
        string_0 = string_0.Replace("Л.Толстого", "Льва Толстого");
        string_0 = string_0.Replace("Матросова", "Александра Матросова");
        string_0 = string_0.Replace("Наб.р.симбирки", "Набережная реки Симбирки");
        string_0 = string_0.Replace("К.Маркса", "Карла Маркса");
        string_0 = string_0.Replace("Нариманова просп.", "Нариманова пр-кт");
        string_0 = string_0.Replace("Ново свияжск.пригород", "Новосвияжский Пригород");
        string_0 = string_0.Replace("Верхне Полевая", "Верхнеполевая");
        string_0 = string_0.Replace("Вр.Михайлова", "Врача Михайлова");
        string_0 = string_0.Replace("Д.Ульянова", "Дмитрия Ульянова");
        string_0 = string_0.Replace("Ж.Дивизии", "Железной Дивизии");
        string_0 = string_0.Replace("Зап. Бульвар", "Западный б-р");
        string_0 = string_0.Replace("Лазо", "Сергея Лазо");
        string_0 = string_0.Replace("Тюленина", "Сергея Тюленина");
        string_0 = string_0.Replace("Московское шоссе", "Московское ш");
        string_0 = string_0.Replace("К.Либкнехта", "Карла Либкнехта");
        string_0 = string_0.Replace("О.Кошевого", "Олега Кошевого");
        string_0 = string_0.Replace("Наб.р.свияги", "Набережная реки Свияги");
        string_0 = string_0.Replace("Минаева спуск", "Спуск Минаева");
        string_0 = string_0.Replace("Немировича Данченко", "Немировича-Данченко");
        string_0 = string_0.Replace("Р.Люксембург", "Розы Люксембург");
        string_0 = string_0.Replace("Старо-сельденская", "Старосельдинская");
        string_0 = string_0.Replace("Нижне-Полевая", "Нижнеполевая");
        string_0 = string_0.Replace("Полбина п-д", "Полбина проезд");
        string_0 = string_0.Replace("Нижне-Татарская", "Нижнетатарская");
        string_0 = string_0.Replace("Старо свияжск.пригород", "Старосвияжский Пригород");
        string_0 = string_0.Replace("П.Морозова", "Павлика Морозова");
        string_0 = string_0.Replace("проезд Аверьянова", "Героя России Аверьянова");
        string_0 = string_0.Replace("Проспект Гая", "Гая пр-кт");
        string_0 = string_0.Replace("С.Разина спуск", "Спуск Степана Разина");
        string_0 = string_0.Replace("2 Зап. Пригород", "Западный Пригород 2-я");
        string_0 = string_0.Replace("Прокофьева п.р.", "Прокофьева проезд");
        string_0 = string_0.Replace("С.Разина", "Степана Разина");
        return string_0;
    }

    private static int? smethod_7(SQLSettings sqlsettings_0, string string_0)
    {
        if ((dataTable_1 == null) || (dataTable_1.Rows.Count == 0))
        {
            SqlDataCommand command = new SqlDataCommand(sqlsettings_0);
            string str = "";
            foreach (SchmTypeSubstation substation in Enum.GetValues(typeof(SchmTypeSubstation)))
            {
                if (string.IsNullOrEmpty(str))
                {
                    int num = (int)substation;
                    str = num.ToString();
                }
                else
                {
                    str = str + "," + ((int) substation).ToString();
                }
            }
            int? nullable = null;
            dataTable_1 = command.SelectSqlData("tSChm_ObjList", true, " where typeCodeId in (" + str + ") and deleted = 0 ", nullable);
        }
        DataRow[] rowArray = dataTable_1.Select("name = '" + string_0 + "'");
        if (rowArray.Length != 0)
        {
            return new int?(Convert.ToInt32(rowArray[0]["id"]));
        }
        return null;
    }

    private static int? smethod_8(SQLSettings sqlsettings_0, string string_0)
    {
        if ((dataTable_2 == null) || (dataTable_2.Rows.Count == 0))
        {
            int? nullable = null;
            dataTable_2 = new SqlDataCommand(sqlsettings_0).SelectSqlData("tR_Classifier", true, " where ParentKey = ';ReportDaily;DamageReason;LV;' and isgroup = 0 and deleted = 0 order by name", nullable);
        }
        DataRow[] rowArray = dataTable_2.Select("name = '" + string_0.Replace("'", "''") + "'");
        if (rowArray.Length != 0)
        {
            return new int?(Convert.ToInt32(rowArray[0]["id"]));
        }
        return null;
    }

    private static int? smethod_9(SQLSettings sqlsettings_0, string string_0)
    {
        if ((dataTable_3 == null) || (dataTable_3.Rows.Count == 0))
        {
            int? nullable = null;
            dataTable_3 = new SqlDataCommand(sqlsettings_0).SelectSqlData("vR_Worker", true, " order by dateEnd", nullable);
        }
        DataRow[] rowArray = dataTable_3.Select("fio = '" + string_0 + "'");
        if (rowArray.Length != 0)
        {
            return new int?(Convert.ToInt32(rowArray[0]["id"]));
        }
        return null;
    }
}

