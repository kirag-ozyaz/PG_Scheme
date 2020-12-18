using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using ControlsLbr.ReportViewerRus;
using DataSql;
using FormLbr;

/// <summary>
/// создание документа акта расследования
/// </summary>
internal class CreateActDetection
{
    private SQLSettings sqlsettings;
    private DataTable tableSchmAbnFull;
    internal DailyReportN.DataSet.dsDamage.tJ_DamageDataTable tJ_Damage;
    internal DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable tJ_DamageCharacter;

    internal System.Windows.Forms.Form Owner { get; set; }
    internal SQLSettings Sqlsettings { get => sqlsettings; set => sqlsettings = value; }

    private FormBase frmBase = new FormBase();
    // родительский документ
    private int IdDocument;
   

    #region создание документа акта расследования
    /// <summary>
    /// сохранение документа акта расследования
    /// </summary>
    internal bool CreateDocument()
    {
        if (Owner.GetType() == typeof(DailyReportN.JournalDamage.FormDamageHVAddEdit))
        {
            DailyReportN.JournalDamage.FormDamageHVAddEdit frm = (DailyReportN.JournalDamage.FormDamageHVAddEdit)Owner;
            tableSchmAbnFull = frm.tableSchmAbnFull;
            tJ_Damage = frm.dataSetDamage.tJ_Damage;
            tJ_DamageCharacter = frm.dataSetDamage.tJ_DamageCharacter;
            IdDocument = frm.IdDocument;
            sqlsettings = frm.SqlSettings;
        }
        else if (Owner.GetType() == typeof(DailyReportN.JournalDamage.FormDamageLVAddEdit))
        {
            DailyReportN.JournalDamage.FormDamageLVAddEdit frm = (DailyReportN.JournalDamage.FormDamageLVAddEdit)Owner;
            tableSchmAbnFull = frm.tableSchmAbnFull;
            tJ_Damage = frm.dataSetDamage.tJ_Damage;
            tJ_DamageCharacter = frm.dataSetDamage.tJ_DamageCharacter;
            IdDocument = frm.IdDocument;
            sqlsettings = frm.SqlSettings;
        }
        else
            return false;

        frmBase.SqlSettings = sqlsettings;

        DataTable dtSetting = References.SettingsTable.GetSettingMinEnergo(sqlsettings);
        if (dtSetting.Rows.Count == 0) { return false; } // настроек нет, документ не создаем
        if (Owner.GetType() == typeof(DailyReportN.JournalDamage.FormDamageHVAddEdit))
        {
            if ((bool)dtSetting.Rows[0]["CreateAktDHV"] != true) { return false; } // запрет создания акта ВН
        }
        else if (Owner.GetType() == typeof(DailyReportN.JournalDamage.FormDamageLVAddEdit))
        {
            if ((bool)dtSetting.Rows[0]["CreateAktDLV"] != true) { return false; } // запрет создания акта НН
        }
        else
            return false;
        // если список абонентов пустой, то не формируем акт
        // очистим/удалим уже готовые акты - если они были
        bool flgSend = true;

        if ((bool)dtSetting.Rows[0]["SendNullListAbonent"])
            if (tableSchmAbnFull.Rows.Count == 0)
                flgSend = false;

        // если список характера поврежедний содержит правильные типы, то акт формируем
        //else if (new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select chNameCol1.SocrName, doc.datedoc, dbo.fn_Schm_GetFullNameObjById(doc.idSchmObj),doc.* " +
        //    " from tj_Damage doc  left join tJ_DamageCharacter ch on ch.idDamage = doc.id" +
        //    "                    left join tr_classifier chNameCol1 on chNameCol1.id = ch.col1 " +
        //    " where doc.idParent = {0} and doc.TypeDoc = {1} and chNameCol1.SocrName is null " +
        //    " order by id desc", IdDocument, (int)eTypeDocuments.ActDetection)).Rows.Count == 0)

        // если есть разрешение на проверку заполнения краткого наименования характеристики
        // если есть хотя бы один правильный характер повреждения, то формируем

        if ((bool)dtSetting.Rows[0]["SendCorrectDamage"])
            if (new SqlDataCommand(sqlsettings).SelectSqlData("select clf.socrname from tr_classifier clf where id in (" + String.Join(Convert.ToString(','), tJ_DamageCharacter.Select(r => r.col1.ToString()).ToArray()) + ") and (clf.socrname is not null and clf.socrname <> '' and CHARINDEX(clf.socrname,';КЛ;ВЛ;КВЛ;ПС;ТП;РП;') > 0)").Rows.Count == 0)
                flgSend = false;

        // создаем акт расследования
        DailyReportN.DataSet.dsDamage.tJ_DamageDataTable table = new DailyReportN.DataSet.dsDamage.tJ_DamageDataTable();
       frmBase.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} ", IdDocument, (int)eTypeDocuments.ActDetection), null, false, 0);
        if (flgSend)
        {
            for (int i = 1; i < table.Rows.Count; i++) // убираем лишние строки
            {
                table.Rows[i].Delete();
            }
            if (table.Rows.Count > 0) // если акт в базе данных есть
            {
                int idActDetection = Convert.ToInt32(table.Rows[0]["id"]);
                //CreateReferenceTables.SetTableDamage(table.Rows[0], tJ_Damage, idActDetection, (int)eTypeDocuments.ActDetection, true, false);
                table.Rows[0]["Deleted"] = 0;
                table.Rows[0].EndEdit();
                if (!frmBase.UpdateSqlData(table))
                {
                    return false;
                }
                //int idActDetection = Convert.ToInt32(table.Rows[0]["id"]);
                //if (!InsertTableDamageCharacterAct(IdDocument, idActDetection, flgSend))
                //{
                //    return false;
                //}
                //if (!InsertTableDamageActDetection(IdDocument, idActDetection, flgSend))
                //{
                //    return false;
                //}
            }
            else
            {
                DataRow dataRow = table.NewRow();
                CreateReferenceTables.SetTableDamage(dataRow, tJ_Damage, IdDocument, (int)eTypeDocuments.ActDetection, true, false);
                table.Rows.Add(dataRow);
                int idActDetection = frmBase.InsertSqlDataOneRow(dataRow);
                if (idActDetection <= 0)
                {
                    return false;
                }
                if (!InsertTableDamageCharacterAct(IdDocument, idActDetection, flgSend))
                {
                    return false;
                }
                if (!InsertTableDamageActDetection(IdDocument, idActDetection, flgSend))
                {
                    return false;
                }
            }
        }
        else
        {
            // может пометить на удаление?
            foreach (DataRow row in table.Rows)
            {
                table.Rows[0]["Deleted"] = 1;
            }
            if (!frmBase.UpdateSqlData(table))
            {
                return false;
            }
        }

        return true;
    }
    /// <summary>
    /// поврежденное оборудование для акта расседования
    /// </summary>
    private bool InsertTableDamageCharacterAct(int? idDamage, int? idActDetection, bool flgSend)
    {
        // заполним характеристики повреждений/отключений
        DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable tableChAct = new DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable();
        frmBase.SelectSqlData(tableChAct, true, "where idDamage = " + idActDetection.ToString());
        // соберем данные у основного документа (родителя)
        DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable tableParent = new DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable();
        frmBase.SelectSqlData(tableParent, true, "where idDamage = " + idDamage.ToString());
        // убираем все строки повреждений у акта
        foreach (DataRow row in tableChAct.Rows)
        {
            row.Delete();
        }
        if (!frmBase.DeleteSqlData(tableChAct))
        {
            return false;
        }
        if (tableParent.Rows.Count > 0)
        {
            DataTable tblClassifierC = Reference.Tables.TableClassifier(null);
            // получим справочник уровни напряжений
            BindingSource bsVoltageLevels = new BindingSource();
            DataTable tableVoltageLevels = GetVoltageLevels();
            bsVoltageLevels.DataSource = tableVoltageLevels;
            // получим родительский документ
            System.Data.DataTable tableVoltageDamage = new SqlDataCommand(Sqlsettings).SelectSqlData("SELECT  Case TypeDoc when 1401 then 0.4 when 1402 then tJ_DamageHV.PowerV end Voltage FROM  tJ_Damage LEFT JOIN  tJ_DamageHV ON tJ_Damage.id = tJ_DamageHV.idDamage where id = " + idDamage.ToString());
            // получим уровень напряжения документа (хрень - маленькое облегчение пользователю)
            object idVoltageDamage = tableVoltageLevels.AsEnumerable()
                .Select(s => new {id = s["id"], Value = (decimal)s["Value"]})
                .Where(t => t.Value == (decimal)tableVoltageDamage.Rows[0]["Voltage"])
                .First().id;

            foreach (DataRow dataRow in tableParent.Rows)
            {
                DataRow dataRow2 = tableChAct.NewRow();
                dataRow2["idDamage"] = ((idActDetection == null) ? -1 : idActDetection);
                dataRow2["col1"] = dataRow["col1"];
                dataRow2["idSchmObj"] = dataRow["idSchmObj"];
                dataRow2["idLineSection"] = dataRow["idLineSection"];
                
                frmBase.SelectSqlData(tblClassifierC, true, "where id = " + dataRow["col1"], null, false, 0);
                string strCol1 = tblClassifierC.Rows[0]["socrname"].ToString();
                if (strCol1 == "КЛ")
                     dataRow2["idParameters"] = 2026;
                else if (strCol1 == "ВЛ")
                    dataRow2["idParameters"] = 2025;
                else if (strCol1 == "СЛ")
                    dataRow2["idParameters"] = 2024;
                else
                    dataRow2["idParameters"] = 2110;

                dataRow2["idCharacterParent"] = dataRow["id"];
                dataRow2["lengthOverLoad"] = 0;
                dataRow2["idNeutralState"] = 2037;
                dataRow2["nodeDetail"] = 2032;
                if (dataRow2["idSchmObj"] != DBNull.Value)
                {
                    // длина трассы
                    object LengthLine = this.GetLengthLine(Convert.ToInt32(dataRow2["idSChmObj"]));
                    if (!string.IsNullOrEmpty(LengthLine.ToString()))
                    {
                        dataRow2["LengthLine"] = LengthLine;
                    }
                    //
                    dataRow2["idMark"] = this.GetIdMark(Convert.ToInt32(dataRow2["idSChmObj"]));
                    // напряжение сети
                    object idVoltage = this.GetValueVoltage(Convert.ToInt32(dataRow2["idSChmObj"]));
                    if (idVoltage != DBNull.Value && idVoltage.ToString() != string.Empty && bsVoltageLevels.DataSource != null && bsVoltageLevels.DataSource is BindingSource && ((BindingSource)bsVoltageLevels.DataSource).DataSource is DataTable)
                    {
                        DataRow[] array = ((DataTable)((BindingSource)bsVoltageLevels.DataSource).DataSource).Select("Value = '" + idVoltage.ToString() + "' and ParentKey like ';VoltageLevels;%'");
                        if (array.Length != 0)
                        {
                            dataRow2["idVoltage"] = array[0]["id"];
                        }
                    }
                    // рабочее напряжение сети
                    object idVoltageSeti = this.GetValueVoltageSeti(Convert.ToInt32(dataRow2["idSChmObj"]));
                    if (idVoltageSeti != DBNull.Value && bsVoltageLevels.DataSource != null && bsVoltageLevels.DataSource is BindingSource && ((BindingSource)bsVoltageLevels.DataSource).DataSource is DataTable)
                    {
                        DataRow[] array2 = ((DataTable)((BindingSource)bsVoltageLevels.DataSource).DataSource).Select("Value = " + idVoltageSeti.ToString().Replace(',', '.') + " and ParentKey like ';VoltageLevels;%'");
                        if (array2.Length != 0)
                        {
                            dataRow2["idVoltageSeti"] = array2[0]["id"];
                        }
                    }
                    //
                    dataRow2["YearManufacture"] = this.GetYearManufacture(Convert.ToInt32(dataRow2["idSChmObj"]));
                    //
                    object YearBegEquipment = this.GetYearBegEquipment(Convert.ToInt32(dataRow2["idSChmObj"]));
                    DateTime dateTime;
                    if (DateTime.TryParse(YearBegEquipment.ToString(), out dateTime))
                    {
                        dataRow2["YearBegEquipment"] = dateTime.ToString("yyyy");
                    }
                    else
                    {
                        dataRow2["YearBegEquipment"] = ((YearBegEquipment.ToString() == string.Empty) ? DBNull.Value : YearBegEquipment);
                    }

                    dataRow2["LastDateTest"] = this.GetLastDateTest(Convert.ToInt32(dataRow2["idSChmObj"]));
                    dataRow2["timeRecovery"] = this.GetTimeRecovery(Convert.ToInt32(dataRow2["idSChmObj"]));
                }
                else
                {
                    dataRow2["idVoltage"]  = idVoltageDamage;
                    dataRow2["idVoltageSeti"] = idVoltageDamage;
                }
                tableChAct.Rows.Add(dataRow2);

                int id1 = frmBase.InsertSqlDataOneRow(dataRow2);
                if (id1 <= 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
    /// <summary>
    /// дополнительные параметры для акта расседования
    /// </summary>
    private bool InsertTableDamageActDetection(int? idDamage, int? idActDetection, bool flgSend)
    {
        DailyReportN.DataSet.dsDamage.tJ_DamageActDetectionDataTable tableActD = new DailyReportN.DataSet.dsDamage.tJ_DamageActDetectionDataTable();
        frmBase.SelectSqlData(tableActD, true, "where idDamage = " + idActDetection.ToString());
        // соберем данные у основного документа (родителя)
        //DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable tableParent = new DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable();
        //frmBase.SelectSqlData(tableParent, true, "where idDamage = " + idDamage.ToString());
        // убираем все строки повреждений у акта
        foreach (DataRow row in tableActD.Rows)
        {
            row.Delete();
        }
        if (!frmBase.DeleteSqlData(tableActD))
        {
            return false;
        }
        //
        DataTable tblClassifier = Reference.Tables.TableClassifier(null);
        frmBase.SelectSqlData(tblClassifier, true, string.Format(" where (ParentKey in ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}',  '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}') or ParentKey like '{14}%') and isgroup = 0 and deleted = 0", new object[]
        {
                        ";NetworkAreas;",
                        ";ReportDaily;ActDetection;SignCrash;",
                        ";ReportDaily;ActDetection;TypeEquipment;",
                        ";ReportDaily;ActDetection;ReasonCrashEquipment;",
                        ";ReportDaily;ActDetection;ReasonCrash;",
                        ";ReportDaily;ActDetection;StatusBeforeCrash;",
                        ";ReportDaily;ActDetection;StatusCurrentCrash;",
                        ";ReportDaily;ActDetection;Defection;",
                        ";ReportDaily;ActDetection;NPA;",
                        ";ReportDaily;ActDetection;ReasonBeginCrash;",
                        ";ReportDaily;ActDetection;Damage;",
                        ";ReportDaily;ActDetection;Fault;",
                        ";ReportDaily;ActDetection;NoCrashMeasure;",
                        ";ReportDaily;ActDetection;Equipment;Params;",
                        ";VoltageLevels;",
                        ";ReportDaily;ActDetection;Equipment;NodeDetail;",
                        ";ReportDaily;ActDetection;Equipment;NeutralState;",
                        ";ReportDaily;ActDetection;Equipment;Material;",
                        ";ReportDaily;ActDetection;Equipment;ClauseWork;",
                        ";ReportDaily;ActDetection;Equipment;ChrDamage;",
                        ";ReportDaily;ActDetection;Equipment;ReasonDamage;"
        }), null, false, 0);

        DataRow dataRow2 = tableActD.NewRow();
        dataRow2["idDamage"] = ((idActDetection == null) ? -1 : idActDetection);

        DataTable dataTableAbn = Reference.Tables.CreateTableAbnType();
        frmBase.SelectSqlData(dataTableAbn, true, string.Format("where typeKontragent = {0} and deleted = 0 order by name", 1115), null, false, 0);
        if (dataTableAbn.Rows.Count > 0)
        {
            dataRow2["idOrg"] = dataTableAbn.Rows[0]["idAbn"];
        }

        if (tblClassifier.Rows.Count > 0)
        {
            string idSignCrash = "";
            string idTypeEquipment = "";
            string idReasonCrashEquipment = "";

            if (tJ_DamageCharacter.Rows.Count > 0)
            {
                DataTable tblClassifierC = Reference.Tables.TableClassifier(null);
                frmBase.SelectSqlData(tblClassifierC, true, "where id = " + (int)tJ_DamageCharacter.Rows[0]["col1"], null, false, 0);

                string strCol1 = tblClassifierC.Rows[0]["socrname"].ToString();
                if (strCol1 == "КЛ")
                    idReasonCrashEquipment = "4.12";
                else if (";ПС;ВЛ;ТП;РП;".IndexOf(strCol1)> 0)
                    idReasonCrashEquipment = "4.13";

                if ((int)tJ_Damage.Rows[0]["TypeDoc"] == (int)eTypeDocuments.DamageHV)
                {
                    idSignCrash = "2.03";
                    if (";КЛ;ВЛ;".IndexOf(strCol1) > 0)
                        idTypeEquipment = "3.311";
                    else if (";ПС;ТП;РП;".IndexOf(strCol1) > 0)
                        idTypeEquipment = "3.313";
                }
                else if ((int)tJ_Damage.Rows[0]["TypeDoc"] == (int)eTypeDocuments.DamageLV)
                {
                    idSignCrash = "2.11";
                    if (";КЛ;ВЛ;".IndexOf(strCol1) > 0)
                        idTypeEquipment = "3.321";
                    else if (";ПС;ТП;РП;".IndexOf(strCol1) > 0)
                        idTypeEquipment = "3.322";
                }
            }

            dataRow2["idSignCrash"] = tblClassifier.Select("Value = "+ idSignCrash)[0]["id"]; // учетные признаки аварии
            dataRow2["idTypeEquipment"] = tblClassifier.Select("Value = " + idTypeEquipment)[0]["id"]; // вид оборудования
            dataRow2["idReasonCrashEquipment"] = tblClassifier.Select("Value = "+ idReasonCrashEquipment + " and ParentKey = ';ReportDaily;ActDetection;ReasonCrashEquipment;'")[0]["id"]; // технические причины
            dataRow2["idReasonBeginCrash"] = tblClassifier.Select("Value = " + idReasonCrashEquipment + " and ParentKey = ';ReportDaily;ActDetection;ReasonBeginCrash;'")[0]["id"]; // причины возникновения аварии и ее развития

            dataRow2["idStatusBeforeCrash"] = tblClassifier.Select("Value = 2.01")[0]["id"]; // описание состояния и режима работы до аварии
            dataRow2["idStatusCurrentCrash"] = tblClassifier.Select("Value = 2.201")[0]["id"]; // описание состояния и режима работы во время аварии
            dataRow2["idReasonCrash"] = tblClassifier.Select("Value = 3.4085")[0]["id"]; //организационные причины
        }
        dataRow2["idClassifierDamage"] = 2010; // перечень и описание повреждения оборудования
        dataRow2["idFault"] = 2020; // описание выявленных недостатков

        tableActD.Rows.Add(dataRow2);
        if (!frmBase.InsertSqlData(tableActD))
        {
            return false;
        }
        return true;
    }
    #endregion
    #region Паспортные данные - получение параметров объектов (кабельные линии (546), вл (547), ВЛЗ (983))
    // 
    internal static string GetDeclineYears(int year)
    {
        switch (year % 10)
        {
            case 1:
                return "год";
            case 2:
            case 3:
            case 4:
                return "года";
            default:
                return "лет";
        }
    }
    /// <summary>
    /// вернуть идентификатор (id) характеристики паспорта по parentkey
    /// (пока подстанции)
    /// </summary>
    /// <param name="idObjList"></param>
    /// <param name="valueParentKey"></param>
    /// <returns></returns>
    internal object GetIdParamPassport(int idObjList, string valueParentKey = ";SubstationType;")
    {
        object resultat = DBNull.Value;
        DataTable dataTable4 = (new SqlDataCommand(sqlsettings).SelectSqlData(string.Format("select valueList.id from tP_Passport pas" +
            " LEFT JOIN dbo.tP_ObjectChar objChar ON pas.id = objChar.idPassport" +
            " LEFT JOIN dbo.tP_CharList charlist ON objChar.idObjChar = charlist.id" +
            " left join dbo.tP_ValueLists valueList ON   Cast(valueList.id as varchar(max)) = objChar.Value AND valueList.ParentId = charlist.idValueList" +
            " where  pas.idobjlist = {0} and valueList.parentkey = '{1}'", idObjList, valueParentKey)));
        if (dataTable4.Rows.Count > 0 && dataTable4.Rows[0]["id"] != DBNull.Value)
        {
            resultat = (int)dataTable4.Rows[0]["id"]; 
            // уровни напряжения используюся из разных классификаторов
            // tR_Classifier и tP_ValueLists
            // вернуть надо не id, а value
            if ( valueParentKey == ";Param;Cable;Voltage;")
            {
                DataTable dataTable5 = (new SqlDataCommand(sqlsettings).SelectSqlData(string.Format("select c.Value from tP_ValueLists v  left join tR_Classifier c on v.name = cast(cast(c.value as float) as varchar) where  v.ParentKey = ';Param;Cable;Voltage;' and c.ParentKey like ';VoltageLevels;%' " +
                    " and v.id = {0}", resultat)));
                if (dataTable5.Rows.Count > 0 && dataTable5.Rows[0]["Value"] != DBNull.Value)
                {
                    resultat = dataTable5.Rows[0]["Value"];
                }
            }
        }

        return resultat;
    }

    /// <summary>
    /// возвращаем параметр (наименование) паспорта объекта через vP_PassportDataReports
    /// </summary>
    /// <param name="idSChmObj"></param>
    /// <returns></returns>
    internal object GetValueParamPassport(int idSChmObj, string valuePassport)
    {
        DataTable dataTable2 = frmBase.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like '{1}'", idSChmObj, valuePassport));
        if (dataTable2.Rows.Count > 0 && dataTable2.Rows[0]["CharValue"] != DBNull.Value)
        {
            return dataTable2.Rows[0]["CharValue"];
        }

        return DBNull.Value;
    }

    internal decimal GetLengthLine(int idSChmObj)
    {
        decimal LengthLine = 0;
        DataTable dataTable = new DataTable("tSchm_ObjList");
        dataTable.Columns.Add("typeCodeId", typeof(int));

        frmBase.SqlSettings = Sqlsettings;
        frmBase.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        {
            DataTable dtPassport = frmBase.SelectSqlData("tP_Passport", true, string.Format("where idObjList = {0} and [isActive] = '1' and deleted = '0' order by Date desc", idSChmObj));
            // паспорт есть
            if (dtPassport.Rows.Count > 0)
            {
                // можно [vP_Spans]
                string str = "SELECT isnull(sum(sec.Length),0) Length " +
                    "  FROM vP_Spans sec" +
                    $"  where sec.idObjList = {idSChmObj} and sec.deleted = 0 " +
                    "  and sec.Length is not null";
                DataTable dtCabSection = (new SqlDataCommand(sqlsettings).SelectSqlData(str));
                dtCabSection.TableName = "tP_CabSection";
                LengthLine = (decimal)dtCabSection.Rows[0]["Length"];

                if (LengthLine == 0)
                {
                    if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
                    {
                        // LengthLine =  GetValueParamPassport(idSChmObj, "Длина трассы");
                        decimal.TryParse(GetValueParamPassport(idSChmObj, "Длина трассы").ToString(), out LengthLine);
                    }
                    else if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 547 || Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 983)
                    {
                        // LengthLine =  GetValueParamPassport(idSChmObj, "Протяженность линии");
                        decimal.TryParse(GetValueParamPassport(idSChmObj, "Протяженность линии").ToString(), out LengthLine);
                    }
                }
            }
        }
        return LengthLine;
    }
    /// <summary>
    /// конструктивное напряжение
    /// </summary>
    internal object GetValueVoltage(int idSChmObj)
    {
        DataTable dataTable = new DataTable("tSchm_ObjList");
        dataTable.Columns.Add("typeCodeId", typeof(int));
        frmBase.SqlSettings = Sqlsettings;
        frmBase.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        {
            if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
            {
                return GetValueParamPassport(idSChmObj, "Напряжение");
            }
            else if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 547 || Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 983)
            {
                return GetValueParamPassport(idSChmObj, "Напряжение");
            }
            else
            {
                // как соединитьнапряжения из двух классификаторов (костыль нужен)
               return  GetIdParamPassport(idSChmObj,";Param;Cable;Voltage;");
            }
        }
        return DBNull.Value;
    }
    /// <summary>
    /// напряжение сети
    /// </summary>
    internal object GetValueVoltageSeti(int idSChmObj)
    {
        DataTable dataTable = new DataTable("tSchm_ObjList");
        dataTable.Columns.Add("typeCodeId", typeof(int));
        frmBase.SqlSettings = Sqlsettings;
        frmBase.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value && Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
        {
            return GetValueParamPassport(idSChmObj, "Рабочее напряжение");
        }
        return DBNull.Value;
    }
    /// <summary>
    /// вернуть id напряжения из справочника классификатор
    /// </summary>
    /// <param name="Voltage"></param>
    /// <returns></returns>
    internal int GetIdVoltage(string Voltage)
    {
        double VoltageRes = Convert.ToDouble(Voltage.Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
        int result = -1;
        DataTable tblClassifier = Reference.Tables.TableClassifier(null);
        frmBase.SqlSettings = Sqlsettings;
        frmBase.SelectSqlData(tblClassifier, true, string.Format(" where (ParentKey like ('{0}')) and Value = '{1}' and isgroup = 0 and deleted = 0", new object[]
        {";VoltageLevels;%",VoltageRes}), null, false, 0);
        if (tblClassifier.Rows.Count > 0)
            result = Convert.ToInt32(tblClassifier.Rows[0]["id"]);
        return result;
    }
    internal object GetYearBegEquipment(int idSChmObj)
    {
        DataTable dataTable = new DataTable("tSchm_ObjList");
        dataTable.Columns.Add("typeCodeId", typeof(int));
        frmBase.SqlSettings = Sqlsettings;
        frmBase.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        {
            if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
            {
                //DataTable dataTable2 = frmBase.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Год ввода в эксплуатацию'", idSChmObj));
                //if (dataTable2.Rows.Count > 0 && dataTable2.Rows[0]["CharValue"] != DBNull.Value)
                //{
                //    return dataTable2.Rows[0]["CharValue"];
                //}
                return GetValueParamPassport(idSChmObj, "Год ввода в эксплуатацию");
            }
            else if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 547 || Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 983)
            {
                string where = string.Format("where idObj = {0} and ([CharName] like 'Год ввода в эксплуатацию'\r\nor [CharName] like 'Дата ввода в эксплуатацию') and [CharValue] is not null and [CharValue] <> ''", idSChmObj);
                DataTable dataTable3 = frmBase.SelectSqlData("vP_PassportDataReports", true, where);
                if (dataTable3.Rows.Count > 0 && dataTable3.Rows[0]["CharValue"] != DBNull.Value)
                {
                    return dataTable3.Rows[0]["CharValue"];
                }
            }
            else
            {
                return GetValueParamPassport(idSChmObj, "Год ввода в эксплуатацию");
            }
        }
        return DBNull.Value;
    }
    /// <summary>
    /// Изготовитель
    /// </summary>
    /// <param name="idSChmObj"></param>
    /// <returns></returns>
    internal object GetManufacture(int idSChmObj)
    {
        DataTable dataTable = new DataTable("tSchm_ObjList");
        dataTable.Columns.Add("typeCodeId", typeof(int));
        frmBase.SqlSettings = Sqlsettings;
        frmBase.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        {
            return GetValueParamPassport(idSChmObj, "Изготовитель");
        }
        return DBNull.Value;
    }
    /// <summary>
    /// Заводской номер
    /// </summary>
    /// <param name="idSChmObj"></param>
    /// <returns></returns>
    internal object GetFactoryNumber(int idSChmObj)
    {
        DataTable dataTable = new DataTable("tSchm_ObjList");
        dataTable.Columns.Add("typeCodeId", typeof(int));
        frmBase.SqlSettings = Sqlsettings;
        frmBase.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        {
            return GetValueParamPassport(idSChmObj, "Зав.№");
        }
        return DBNull.Value;
    }

    internal object GetYearManufacture(int idSChmObj)
    {
        DataTable dataTable = new DataTable("tSchm_ObjList");
        dataTable.Columns.Add("typeCodeId", typeof(int));
        frmBase.SqlSettings = Sqlsettings;
        frmBase.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        {
            if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
            {
                return GetValueParamPassport(idSChmObj, "Год прокладки");
            }
            else if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 547 || Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 983)
            {
                return GetValueParamPassport(idSChmObj, "Год постройки");
            }
            else
            {
                return GetValueParamPassport(idSChmObj, "Год изготовления");
            }
            
        }
        return DBNull.Value;
    }

    private int GetIdEquipment(int idSChmObj, int typeCodeId = -1)
    {
        int idEquipment = -1;
        DataTable dtPassport = frmBase.SelectSqlData("tP_Passport", true, string.Format("where idObjList = {0} and [isActive] = '1' and deleted = '0' order by Date desc", idSChmObj));
        // паспорт есть
        if (dtPassport.Rows.Count > 0 && dtPassport.Rows[0]["idEquipment"] != DBNull.Value)
        {
            // если паспорт не привязан к справочнику кабелей
            if (Convert.ToInt32(dtPassport.Rows[0]["idEquipment"]) == -1)
            {

                string ParametrMarkaPassport = "";
                if (typeCodeId == 546 || typeCodeId == -1)
                    ParametrMarkaPassport = "Марка кабеля";
                else if (typeCodeId == 547 || typeCodeId == 983)
                    ParametrMarkaPassport = "Марка провода";


                // Проверяем наличие секций в паспорте
                // и вернем параметры секцию с наименьшим сечением
                string str = String.Format("	SELECT TOP 1 l.Name CableMakeup,   " +
                    "   s.Voltage as Voltage " +
                    "   , s.Wires as Wires, s.CrossSection as CrossSection" +
                    "    FROM tP_CabSection AS s" +
                    "    JOIN tP_ValueLists AS l ON s.CableMakeup = l.id" +
                    "    WHERE s.idObjList = {0}" +
                    "            AND s.id = (SELECT TOP 1 id" +
                    "                        FROM tP_CabSection" +
                    "                        WHERE Deleted = (0) AND idObjList = s.idObjList" +
                    "                        GROUP BY id, CrossSection" +
                    //"                        HAVING MIN(Length) > 9" +
                    "                        ORDER BY CrossSection)", idSChmObj);

                DataTable dtSchmMarkCable = new DataTable("tR_Cable");
                References.SchemeTables.GetTableMarkCable(dtSchmMarkCable, sqlsettings);

                string CableMakeup = "";
                int Wires = 0;
                decimal CrossSection = 0;
                int idVoltage = -1;

                DataTable dtCabSection = (new SqlDataCommand(sqlsettings).SelectSqlData(str));
                dtCabSection.TableName = "tP_CabSection";

                if (dtCabSection.Rows.Count > 0)
                {
                    // надо найти кабель  в  справочнике кабелей
                    DataRow row = dtCabSection.Rows[0];

                    //var res1 = dtSchmMarkCable.AsEnumerable().Where(w => (string)w["CableMakeup"] == (string)row["CableMakeup"]);
                    //var res2 = res1.Where(w => (int)w["Wires"] == (int)row["Wires"]);
                    //var res3 = res2.Where(w => (decimal)w["CrossSection"] == (decimal)row["CrossSection"]);
                    //var res4 = res3.Where(w => (int)w["IdVoltage"] == GetIdVoltage(row["Voltage"].ToString()));

                    //var res5 = res4.Select(s => (int)s["id"]);

                    CableMakeup = (string)row["CableMakeup"];
                    Wires = (int)row["Wires"];
                    CrossSection = (decimal)row["CrossSection"];
                    idVoltage = GetIdVoltage(row["Voltage"].ToString());
                }
                else// участков кабеля нет, считаем по лицевой части (общие параметры)
                {


                    CableMakeup = GetValueParamPassport(idSChmObj, ParametrMarkaPassport).ToString();
                    int.TryParse(GetValueParamPassport(idSChmObj, "Количество жил").ToString(), out Wires);
                    decimal.TryParse(GetValueParamPassport(idSChmObj, "Сечение").ToString(), out CrossSection);
                    int.TryParse(GetValueParamPassport(idSChmObj, "Напряжение").ToString(), out idVoltage);
                }
                if (CableMakeup.ToString() == string.Empty || Wires == 0 || CrossSection == 0 || idVoltage == -1)
                    return idEquipment;

                var resEquipment = dtSchmMarkCable.AsEnumerable().Where(w => (string)w["CableMakeup"] == CableMakeup && (int)w["Wires"] == Wires && (decimal)w["CrossSection"] == CrossSection && (int)w["idVoltage"] == idVoltage).Select(s => (int)s["id"]);

                if (resEquipment.Count() != 0)
                {
                    //  добавить idEquipment в паспорт 
                    idEquipment = (int)resEquipment.First();
                }
                else
                {
                    // надо создать элемент в справочнике марок кабеля
                    if (idVoltage != -1)
                    {
                        DataRow row1 = dtSchmMarkCable.NewRow();
                        row1["CableMakeup"] = CableMakeup;
                        row1["Wires"] = Wires;
                        row1["CrossSection"] = CrossSection;
                        row1["idVoltage"] = idVoltage;
                        dtSchmMarkCable.Rows.Add(row1);
                        LibraryTSQL.cTSQL _cTSQL = new LibraryTSQL.cTSQL();
                        _cTSQL.SqlSettings = this.Sqlsettings;
                        idEquipment = _cTSQL.InsertSqlDataOneRowN(row1, false);
                        // idEquipment = frmBase.InsertSqlDataOneRow(row1);
                    }
                }
            }
            else
                idEquipment = (int)dtPassport.Rows[0]["idEquipment"];
        }
        //else
        //{
        //    return GetIdParamPassport(idSChmObj, ";Param;Cable;Makeup;");
        //}
        // полное имя марки кабеля по наименьшему сечению и общей длине наименьшего сечения
        //string Name = Passport.Classes.SchmObj.GetMinCabSectionString(Sqlsettings, idSChmObj);
        return idEquipment;
    }

    internal object GetIdMark(int idSChmObj)
    {
        DataTable dataTable = new DataTable("tSchm_ObjList");
        dataTable.Columns.Add("typeCodeId", typeof(int));
        frmBase.SqlSettings = Sqlsettings;
        frmBase.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        // ";SCM;PS;"
        if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        {
            int TypeCodeId = Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]);
            if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
            {
                return GetIdEquipment(idSChmObj, TypeCodeId);
            }
            else if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 547 || Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 983)
            {
                return GetIdEquipment(idSChmObj, TypeCodeId);
            }
            else
            {
                //// если подстанция
                return GetIdParamPassport(idSChmObj);
            }
        }
        return DBNull.Value;
    }
    /// <summary>
    /// последняя дата испытаний
    /// </summary>
    /// <param name="idSChmObj"></param>
    /// <returns></returns>
    internal object GetLastDateTest(int idSChmObj)
    {
        DataTable dataTable = (new SqlDataCommand(sqlsettings).SelectSqlData(string.Format("select obj.typeCodeId TypeCodeId, trc.parentkey ParentKey from tSchm_ObjList obj left join tR_Classifier trc on obj.typecodeid = trc.id where obj.id = {0}", idSChmObj)));
        if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        {
            if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
            {
                DataTable dataTable4 = new DataTable("tP_CabTesting");
                dataTable4.Columns.Add("date", typeof(DateTime));
                string str = "";
                if (tJ_Damage.Rows.Count > 0 && tJ_Damage.Rows[0]["datedoc"] != DBNull.Value)
                {
                    str = " and [date] < '" + Convert.ToDateTime(tJ_Damage.Rows[0]["datedoc"]).ToString("yyyyMMdd") + "'";
                }
                frmBase.SqlSettings = Sqlsettings;
                frmBase.SelectSqlData(dataTable4, true, " where idObjList = " + idSChmObj.ToString() + str + " and deleted = 0 order by [date] desc", null, false, 0);
                if (dataTable4.Rows.Count > 0)
                {
                    return dataTable4.Rows[0]["Date"];
                }
            }
            else if (Convert.ToString(dataTable.Rows[0]["ParentKey"]) == ";SCM;PS;")
            {

                int TypeDoc = 2082;
                string str = String.Format("SELECT  (select isnull(MAX(X), doc.datedoc) FROM(select test.dateIsol union all select test.dateTrans union all select test.date) T(X)) as [DateDoc] FROM tP_DocList doc left join tP_SubstationTest test on  test.idDocList = doc.id   where doc.typedoc = {1} and idobjlist = {0}", idSChmObj, TypeDoc);

                if (tJ_Damage.Rows.Count > 0 && tJ_Damage.Rows[0]["datedoc"] != DBNull.Value)
                {
                    str += " and [DateDoc] < '" + Convert.ToDateTime(tJ_Damage.Rows[0]["datedoc"]).ToString("yyyyMMdd") + "'";
                }

                DataTable dataTable4 = (new SqlDataCommand(sqlsettings).SelectSqlData(str));
                if (dataTable4.Rows.Count > 0)
                {
                    return dataTable4.Rows[0]["DateDoc"];
                }
            }
        }
        return DBNull.Value;
    }
    /// <summary>
    /// дата восcтановленения
    /// </summary>
    /// <param name="idSChmObj"></param>
    /// <returns></returns>
    internal object GetTimeRecovery(int idSChmObj)
    {
        DataTable dataTable = new DataTable("tP_CabOperation");
        dataTable.Columns.Add("datecommissioning", typeof(DateTime));
        string str = "";
        if (tJ_Damage.Rows.Count > 0 && tJ_Damage.Rows[0]["datedoc"] != DBNull.Value)
        {
            str = " and [datecommissioning] > '" + Convert.ToDateTime(tJ_Damage.Rows[0]["datedoc"]).ToString("yyyyMMdd") + "'";
        }
        frmBase.SqlSettings = Sqlsettings;
        frmBase.SelectSqlData(dataTable, true, " where idObjList = " + idSChmObj.ToString() + str + " and deleted = 0 order by [datecommissioning]", null, false, 0);
        if (dataTable.Rows.Count > 0)
        {
            return dataTable.Rows[0]["datecommissioning"];
        }
        return DBNull.Value;
    }
    /// <summary>
    /// параметр прокладки кабеля
    /// </summary>
    /// <param name="idSChmObj"></param>
    /// <returns></returns>
    internal object GetParameterLayingCable(int idSChmObj)
    {
        DataTable dataTable = new DataTable("tSchm_ObjList");
        dataTable.Columns.Add("typeCodeId", typeof(int));
        frmBase.SqlSettings = Sqlsettings;
        frmBase.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString());
        if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
        { return 2026; } // кабельная линия, проложенная в земле
        else if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 547 || Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 983)
        { return 2025; } // воздушная линия, проложенная на опорах
        return 2110; // пусто

    }
    #endregion
    internal DataTable GetVoltageLevels()
    {
        DataTable table = Reference.Tables.TableClassifier(null);
        frmBase.SqlSettings = Sqlsettings;
        frmBase.SelectSqlData(table, true, string.Format(" where ParentKey like '{0}%' and isgroup = 0 and deleted = 0 order by value", new object[]
        {";VoltageLevels;"   }), null, false, 0);
        return table;
    }

  
}
