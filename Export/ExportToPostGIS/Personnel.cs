using System.Linq;
using DataSql;
using ExportToPostGIS;
using LibraryTSQL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Personnel
{
    internal class Export
    {
        public SQLSettings SqlSettings { get; set; }
        public FormExportPersonnel FormParent { get; internal set; }
        /// <summary>
        /// статус записи данных
        /// </summary>
        public bool isSaveDate { get; set; } = false;
        public Export() { }
        public Export(bool isSaveDate)
        {
            this.isSaveDate = isSaveDate;
        }

        internal void Start()
        {
            //this.isSaveDate = false;
            DataSetPersonnel ds = new DataSetPersonnel();
            //throw new NotImplementedException();

            LibraryTSQL.SqlDataCommand cTSQL = new LibraryTSQL.SqlDataCommand();
            //DataSql.SqlDataCommand ddd = new DataSql.SqlDataCommand(SqlSettings);

            cTSQL.SqlSettings = this.SqlSettings;
            #region Должности=tR_JobTitle
            const string tR_JobTitleTemp = "k_tR_JobTitleTemp";
            const string tR_JobTitle = "k_tR_JobTitle";
            try
            {
                //cTSQL.SelectSqlData(ds, ds.tR_JobTitleTemp, false, "");
                //DataSql.SqlDataCommand ddd = new DataSql.SqlDataCommand(SqlSettings);
                //ddd.SelectSqlDataTableOther(ds, ds.tR_JobTitleTemp, "k_tR_JobTitleTemp", false, "");
                cTSQL.SelectSqlDataTableOther(ds, ds.tR_JobTitleTemp, tR_JobTitleTemp, false, "");
                AppendText("Должности. Импортируемые данные загружены" + "\r\n");

                //cTSQL.SelectSqlData(ds, ds.tR_JobTitle, false, "");
                cTSQL.SelectSqlDataTableOther(ds, ds.tR_JobTitle, tR_JobTitle, false, "");
                foreach (DataRow row in ds.tR_JobTitleTemp)
                {
                    if (row["GUIDJobTitle"] == DBNull.Value)
                    {
                        AppendText($"----->. {row["id"]} {row["Description"]} нет GUID" + "\r\n");
                        continue;
                    }
                    var res = ds.tR_JobTitle.Select("GUID = '" + row["GUIDJobTitle"] + "'");

                    if (res.Length == 0)
                    {
                        DataRow row1 = ds.tR_JobTitle.NewRow();
                        row1["Description"] = row["Description"];
                        row1["Code"] = row["Code"];
                        row1["RName"] = row["RName"];
                        row1["Razrjad"] = row["Razrjad"];
                        row1["Deleted"] = row["Deleted"];
                        row1["IDRRef"] = 0;
                        row1["Flag"] = 1;
                        row1["GUID"] = row["GUIDJobTitle"];
                        ds.tR_JobTitle.Rows.Add(row1);
                    }
                    else
                    { res[0]["Deleted"] = row["Deleted"]; }
                }

                if (isSaveDate)
                {
                    cTSQL.InsertSqlDataTableOther(ds, ds.tR_JobTitle, tR_JobTitle);
                    cTSQL.UpdateSqlDataTableOther(ds, ds.tR_JobTitle, tR_JobTitle);

                    AppendText("Должности. Изменения внесены" + "\r\n");
                }
            }
            catch (Exception ex)
            {
                if (FormParent != null)
                    MessageBox.Show(ex.Message + " Ошибка загрузки должностей", ex.Source);
            }
            Application.DoEvents();
            #endregion
            #region  Подразделения=Division
            const string tR_DivisionTemp = "k_tR_DivisionTemp";
            const string tR_Division = "k_tR_Division";
            try
            {
                //cTSQL.SelectSqlData(ds, ds.tR_DivisionTemp, false, "");
                //DataSql.SqlDataCommand ddd = new DataSql.SqlDataCommand(SqlSettings);
                //ddd.SelectSqlDataTableOther(ds, ds.tR_DivisionTemp, "k_tR_DivisionTemp", false, "");
                cTSQL.SelectSqlDataTableOther(ds, ds.tR_DivisionTemp, tR_DivisionTemp, false, "");

                AppendText("Подразделения. Импортируемые данные загружены" + "\r\n");

                //cTSQL.SelectSqlData(ds, ds.tR_Division, false, "");
                cTSQL.SelectSqlDataTableOther(ds, ds.tR_Division, tR_Division, false, "");
                foreach (DataRow row in ds.tR_DivisionTemp)
                {
                    AppendText($"... {string.Join(";", row.ItemArray.Select(c => c.ToString()).ToArray())}" + "\r\n");


                    if (row["GUIDDivision"] == DBNull.Value)
                    {
                        AppendText($"----->. {row["id"]} {row["Description"]} нет GUID" + "\r\n");
                        continue;
                    }
                    // найдем запись в действующей таблице
                    var res = ds.tR_Division.Select("GUID = '" + row["GUIDDivision"] + "'");
                    // надо найти первого родителя в дереве
                    // если код пустой, то родителя нет
                    DataRow[] resParent = null;
                    int? resParentID = null;
                    if (row["GUIDParent"] != DBNull.Value && row["GUIDParent"].ToString() != String.Empty)
                    {
                        // ищем в рабочей таблице
                        resParent = ds.tR_Division.Select("GUID = '" + row["GUIDParent"] + "'"); // родитель один всегда
                        if (resParent.Length == 0)
                        {
                            // если не нашли ищем в импортируемой таблице
                            resParent = ds.tR_DivisionTemp.Select("GUIDDivision = '" + row["GUIDParent"] + "'");
                            if (resParent.Length != 0)
                            {
                                // создадим родителя с пустой ссылкой родителя - потом найдем и обновим
                                DataRow row1 = ds.tR_Division.NewRow();
                                row1["Description"] = resParent[0]["Description"];
                                row1["Code"] = resParent[0]["Code"];
                                //row1["ParentCode"] = resParent[0]["ParentCode"];
                                //row1["ParentDescription"] = resParent[0]["ParentDescription"];
                                //if (resParent != null)  row1["ParentID"] = resParent[0]["id"];

                                row1["Deleted"] = resParent[0]["Deleted"];
                                row1["ParentIDRRef"] = 0;
                                row1["IDRRef"] = 0;
                                row1["Flag"] = 1;
                                row1["GUID"] = resParent[0]["GUIDDivision"];
                                ds.tR_Division.Rows.Add(row1);

                                resParentID = Convert.ToInt32(row1["id"].ToString());
                            }
                            else
                            {
                                if (resParent[0]["id"] != DBNull.Value)
                                    resParentID = Convert.ToInt32(resParent[0]["id"]);
                            }
                        }
                        else
                        {
                            if (resParent[0]["id"] != DBNull.Value)
                                resParentID = Convert.ToInt32(resParent[0]["id"]);
                        }
                    }

                    if (res.Length == 0)
                    {
                        DataRow row1 = ds.tR_Division.NewRow();
                        row1["Description"] = row["Description"];
                        row1["Code"] = row["Code"];
                        row1["ParentCode"] = row["ParentCode"];
                        row1["ParentDescription"] = row["ParentDescription"];
                        if (resParentID != null) row1["ParentID"] = resParentID;

                        row1["Deleted"] = row["Deleted"];
                        row1["ParentIDRRef"] = 0;
                        row1["IDRRef"] = 0;
                        row1["Flag"] = 1;
                        row1["GUID"] = row["GUIDDivision"];
                        ds.tR_Division.Rows.Add(row1);
                    }
                    else
                    {
                        res[0]["Description"] = row["Description"];
                        res[0]["Code"] = row["Code"];
                        res[0]["Deleted"] = row["Deleted"];
                        if (resParentID != null) res[0]["ParentID"] = resParentID;
                    }

                }
                AppendText("-----------------------------\r\n" +
                    "Подразделения. Результат перед внесением в базу" + "\r\n");

                foreach (var res in ds.tR_Division)
                {
                    AppendText($"... {string.Join(";", res.ItemArray.Select(c => c.ToString()).ToArray())}" + "\r\n");
                }
                if (isSaveDate)
                {
                    cTSQL.InsertSqlDataTableOther(ds, ds.tR_Division, tR_Division);
                    cTSQL.UpdateSqlDataTableOther(ds, ds.tR_Division, tR_Division);
                    AppendText("Подразделения. Изменения внесены" + "\r\n");
                }
            }
            catch (Exception ex)
            {
                if (FormParent != null)
                    MessageBox.Show(ex.Message + " Ошибка загрузки подразделений", ex.Source);
            }
            #endregion
            #region Сотрудники=tR_Worker
            const string  tR_WorkerTemp = "k_tR_WorkerTemp";
            const string tR_Worker = "k_tR_Worker";
            try
            {
                //cTSQL.SelectSqlData(ds, ds.tR_WorkerTemp, false, "");
                //DataSql.SqlDataCommand ddd = new DataSql.SqlDataCommand(SqlSettings);
                cTSQL.SelectSqlDataTableOther(ds, ds.tR_WorkerTemp, tR_WorkerTemp, false, "");
                AppendText("Сотрудники. Импортируемые данные загружены" + "\r\n");

                //cTSQL.SelectSqlData(ds, ds.tR_Worker, false, "");
                cTSQL.SelectSqlDataTableOther(ds, ds.tR_Worker, tR_Worker, false, "");
                foreach (DataRow row in ds.tR_WorkerTemp)
                {
                    if (row["GUIDWorker"] == DBNull.Value)
                    {
                        AppendText($"----->. {row["id"]} - {row["F"]} {row["I"]} {row["O"]} нет GUID" + "\r\n");
                        continue;
                    }
                    /* Поиск по:
                     1. Guid
                     2. ИНН и дата приема на работу (DateEnd)
                     3. Фамилия Имя и Отчетсво, дата рождения (Birthday) и дата приема на работу (DateEnd)
                     */
                    DateTime? DateBegin = null;
                    if (row["DateBegin"] != DBNull.Value) { DateBegin = Convert.ToDateTime(row["DateBegin"]); }
                    //DateBegin = Convert.ToDateTime(row["DateBegin"]);

                    var res = ds.tR_Worker.Select("GUID = '" + row["GUIDWorker"] + "'");
                    if (res.Length == 0)
                    {
                        res = ds.tR_Worker.Select("INN = '" + row["INN"] + "'" + " and DateBegin ='" + row["DateBegin"] + "'", "id desc");
                    }
                    if (res.Length == 0)
                    {
                        res = ds.tR_Worker.Select("F = '" + row["F"] + "' and I = '" + row["I"] + "' and O = '" + row["O"] + "'" + " and Birthday = '" + row["Birthday"] + "'" + " and DateBegin ='" + row["DateBegin"] + "'", "id desc");
                    }
                    DateTime? DateEnd = null;
                    if (row["DateEnd"] != DBNull.Value) { DateEnd = Convert.ToDateTime(row["DateEnd"]); }
                    if (DateEnd == null)
                    {
                        DateEnd = DateEnd > DateTime.Now ? null : DateEnd;
                    }
                    int? Division = null;
                    if (row["GUIDDivision"] != DBNull.Value)
                    {
                        var resDivision = ds.tR_Division.Select("GUID = '" + row["GUIDDivision"] + "'");
                        if (resDivision.Length != 0) { Division = Convert.ToInt32(resDivision[0]["id"]); }
                    }
                    int? DivisionCurrent = null;
                    if (row["GUIDDivisionCurrent"] != DBNull.Value)
                    {
                        var resDivision = ds.tR_Division.Select("GUID = '" + row["GUIDDivisionCurrent"] + "'");
                        if (resDivision.Length != 0) { DivisionCurrent = Convert.ToInt32(resDivision[0]["id"]); }
                    }

                    int? JobTitleCurrent = null;
                    if (row["GUIDJobTitle"] != DBNull.Value)
                    {
                        var resJobTitle = ds.tR_JobTitle.Select("GUID = '" + row["GUIDJobTitle"] + "'");
                        if (resJobTitle.Length != 0) { JobTitleCurrent = Convert.ToInt32(resJobTitle[0]["id"]); }
                    }
                    if (res.Length == 0)
                    {
                        DataRow row1 = ds.tR_Worker.NewRow();
                        row1["Code"] = row["Code"];
                        row1["F"] = row["F"];
                        row1["I"] = row["I"];
                        row1["O"] = row["O"];
                        row1["Birthday"] = row["Birthday"];
                        row1["Division"] = Division == null ? 0 : Division; 
                        row1["DivisionCurrent"] = DivisionCurrent == null ? 0 : DivisionCurrent;
                        row1["JobTitle"] = JobTitleCurrent == null ? 0 : JobTitleCurrent;
                        row1["DateBegin"] = row["DateBegin"];
                        //row1["DateEnd"] = DateEnd;
                        if (DateEnd == null)
                            row1["DateEnd"] = DBNull.Value;
                        else
                            row1["DateEnd"] = DateEnd;
                        row1["INN"] = row["INN"];
                        row1["IDRRef"] = 0;
                        row1["GUID"] = row["GUIDWorker"];
                        ds.tR_Worker.Rows.Add(row1);
                    }
                    else
                    {
                        res[0]["Division"] = Division == null ? 0 : Division;
                        res[0]["DivisionCurrent"] = DivisionCurrent == null ? 0 : DivisionCurrent;
                        res[0]["JobTitle"] = JobTitleCurrent == null ? 0 : JobTitleCurrent;
                        if (DateEnd == null)
                            res[0]["DateEnd"] = DBNull.Value;
                        else
                            res[0]["DateEnd"] = DateEnd;
                        res[0]["GUID"] = row["GUIDWorker"];
                    }
                }

                if (isSaveDate)
                {
                    cTSQL.InsertSqlDataTableOther(ds, ds.tR_Worker, tR_Worker);
                    cTSQL.UpdateSqlDataTableOther(ds, ds.tR_Worker, tR_Worker);

                    AppendText("Сотрудники. Изменения внесены" + "\r\n");
                }

            }
            catch (Exception ex)
            {
                if (FormParent != null)
                    MessageBox.Show(ex.Message + " Ошибка загрузки сотрудников", ex.Source);
            }

            #endregion
            #region Кадровые даннные=tR_WorkerContact 
            const string tR_WorkerContactTemp = "k_tR_WorkerContactTemp";
            const string tR_WorkerContact = "k_tR_WorkerContact";
            try
            {
                cTSQL.SelectSqlDataTableOther(ds, ds.tR_WorkerContactTemp, tR_WorkerContactTemp, false, "");
                AppendText("Кадровые даннные. Импортируемые данные загружены" + "\r\n");

                cTSQL.SelectSqlDataTableOther(ds, ds.tR_WorkerContact, tR_WorkerContact, false, " where KadrExport = 1 ");
                foreach (DataRow row in ds.tR_Worker)
                {
                    if (row["GUID"] == DBNull.Value)
                    {
                        AppendText($"----->. {row["id"]} - {row["F"]} {row["I"]} {row["O"]} нет GUID" + "\r\n");
                        continue;
                    }
                    DataRow[] res1 = ds.tR_WorkerContact.Select("GUID = '" + row["GUID"] + "'");
                    for (int i = 1; i < res1.Length; i++)
                    {
                        ds.tR_WorkerContact.Rows.Remove(res1[i]);
                    }
                    DataRow[] res2 = ds.tR_WorkerContactTemp.Select("GUIDWorker = '" + row["GUID"] + "'");
                    foreach (DataRow row2 in res2)
                    {
                        DataRow row1 = ds.tR_WorkerContact.NewRow();
                        row1["Worker"] = row2["id"];
                        row1["Description"] = row2["Description"];
                        row1["KadrExport"] = 1;
                        row1["Comment"] = row2["Comment"];
                        row1["GUID"] = row2["GUIDWorker"];
                        row1["Type"] = GetCodeType(Convert.ToInt32(row2["CodeType"]));
                        ds.tR_WorkerContact.Rows.Add(row1);
                    }
                }
                if (isSaveDate)
                {
                    cTSQL.InsertSqlDataTableOther(ds, ds.tR_WorkerContact, tR_WorkerContact);
                    //cTSQL.UpdateSqlDataTableOther(ds, ds.tR_WorkerContact, tR_WorkerContact);
                    cTSQL.DeleteSqlDataTableOther(ds, ds.tR_WorkerContact, tR_WorkerContact);

                    AppendText("Кадровые даннные. Изменения внесены" + "\r\n");
                }
            }
            catch (Exception ex)
            {
                if (FormParent != null)
                    MessageBox.Show(ex.Message + " Ошибка загрузки Кадровых даннных", ex.Source);
            }
            #endregion
            #region Состояние работников=tj_StatusWorker
            const string tJ_StatusWorkerTemp = "k_tj_StatusWorkerTemp";
            const string tJ_StatusWorker = "k_tj_StatusWorker";
            // 0.  загрузим состояния
            try
            {
                cTSQL.SelectSqlDataTableOther(ds, ds.tJ_StatusWorkerTemp, tJ_StatusWorkerTemp, false, "");
                AppendText("Кадровые даннные. Импортируемые данные загружены" + "\r\n");

                cTSQL.SelectSqlDataTableOther(ds, ds.tJ_StatusWorker, tJ_StatusWorker, false, "");
            }
            catch (Exception ex)
            {
                if (FormParent != null)
                    MessageBox.Show(ex.Message + " Ошибка загрузки статусов", ex.Source);
            }

            // 1. смена подразделения или должности
            try
            {
                // возьмем сотрудника из справочника
                foreach (DataRow row in ds.tR_Worker)
                {
                    string strWhereWorker = "";
                    string strWhereWorkerTemp = "";
                    // проверим наличие данных  сотрудника по GUID
                    if (row["GUIDWorker"] == DBNull.Value)
                    {
                        AppendText($"----->. {row["GUIDWorker"]} ({row["id"]}) - {row["F"]} {row["I"]} {row["O"]} нет GUID Worker" + "\r\n");
                        // проверим по полю Code (из старой базы данных)
                        if (row["CodeWorker"] == DBNull.Value)
                        {
                            AppendText($"----->. {row["id"]} - {row["F"]} {row["I"]} {row["O"]} нет Code Worker" + "\r\n");
                            continue;
                        }
                        else
                        {
                            strWhereWorker = "Code = '" + row["CodeWorker"] + "'";
                            strWhereWorkerTemp = "CodeWorker = '" + row["CodeWorker"] + "'";
                        }
                    }
                    else
                    { 
                        strWhereWorker = "GUID = '" + row["GUIDWorker"] + "'";
                        strWhereWorkerTemp = "GUIDWorker = '" + row["GUIDWorker"] + "'";
                    }
                    // если нашли сотрудника, то почистить у него все данные 
                    DataRow[] res1 = ds.tJ_StatusWorker.Select(strWhereWorker);
                    for (int i = 1; i < res1.Length; i++)
                    {
                        ds.tJ_StatusWorker.Rows.Remove(res1[i]);
                    }
                    DataRow[] res2 = ds.tJ_StatusWorkerTemp.Select(strWhereWorkerTemp);
                    foreach (DataRow row2 in res2)
                    {
                        // найдем подразделение
                        int? Division = null;
                        if (row2["GUIDDivision"] != DBNull.Value)
                        {
                            var resDivision = ds.tR_Division.Select("GUID = '" + row2["GUIDDivision"] + "'");
                            if (resDivision.Length != 0) { Division = Convert.ToInt32(resDivision[0]["id"]); }
                        }
                        else if (row2["CodeDivision"] != DBNull.Value)
                        {
                            var resDivision = ds.tR_Division.Select("Code = '" + row["CodeDivision"] + "'");
                            if (resDivision.Length != 0) { Division = Convert.ToInt32(resDivision[0]["id"]); }
                        }
                        else
                        {
                            AppendText($"Статус сотрудника. Подразделение {row2["GUIDDivision"]}/{row2["CodeDivision"]}  не обнаружено" + "\r\n");
                            continue;
                        }

                        // найдем должность
                        int? JobTitleCurrent = null;
                        if (row2["GUIDJobTitle"] != DBNull.Value)
                        {
                            var resJobTitle = ds.tR_JobTitle.Select("GUID = '" + row2["GUIDJobTitle"] + "'");
                            if (resJobTitle.Length != 0) { JobTitleCurrent = Convert.ToInt32(resJobTitle[0]["id"]); }
                        }
                        else if (row2["CodeJobTitle"] != DBNull.Value)
                        {
                            var resJobTitle = ds.tR_JobTitle.Select("Code = '" + row2["CodeJobTitle"] + "'");
                            if (resJobTitle.Length != 0) { JobTitleCurrent = Convert.ToInt32(resJobTitle[0]["id"]); }
                        }
                        else
                        {
                            AppendText($"Статус сотрудника. Должность {row2["GUIDJobTitle"]}/{row2["CodeJobTitle"]} не обнаружено" + "\r\n");
                            continue;
                        }

                        DataRow row1 = ds.tJ_StatusWorker.NewRow();
                        row1["Period"] = row2["Period"];
                        row1["Worker"] = row2["CodeWorker"];
                        row1["JobTitle"] = JobTitleCurrent;
                        row1["Division"] = Division;
                        row1["GUIDWorker"] = row2["GUIDWorker"];
                        row1["GUIDJobTitle"] = row2["GUIDJobTitle"]; ;
                        row1["GUIDDivision"] = row2["GUIDDivision"]; ;
                        row1["Status"] = GetPersonnelChanges(Convert.ToInt32(row2["Status"]));
                        ds.tJ_StatusWorker.Rows.Add(row1);
                    }

                    if (isSaveDate)
                    {
                        cTSQL.InsertSqlDataTableOther(ds, ds.tJ_StatusWorker, tJ_StatusWorker);
                        //cTSQL.UpdateSqlDataTableOther(ds, ds.tR_WorkerContact, tR_WorkerContact);
                        cTSQL.DeleteSqlDataTableOther(ds, ds.tJ_StatusWorker, tJ_StatusWorker);

                        AppendText("Кадровые даннные. Изменения внесены" + "\r\n");
                    }


                }
            }
            catch (Exception ex)
            {
                if (FormParent != null)
                    MessageBox.Show(ex.Message + " Ошибка загрузки изменения подразделений и должностей", ex.Source);
            }
            // 2. периоды работы.
            try
            {
            }
            catch (Exception ex)
            {
                if (FormParent != null)
                    MessageBox.Show(ex.Message + " Ошибка загрузки изменения периодов работы", ex.Source);
            }
            #endregion

        }

        private int GetCodeType(int v)
        {
            switch (v)
            {
                case 1: return 38;// Адрес для информирования физ. лица
                case 2: return 39;// Адрес по прописке физ. лица
                case 3: return 40;// Адрес проживания физ.лица
                case 4: return 41;// Адрес физ. лица за пределами РФ
                case 7: return 49;// Телефон физ. лица
                case 8: return 42;// контакт.телефон
                case 9: return 54;// юр.адр.орг.
                case 10: return 45;// тел.орг.
                case 11: return 53;// факт.адр.орг.
                case 12: return 44;// электр.почта
                case 13: return 43;// почт.адр.орг.
                case 14: return 51;// факс орг.
                case 15: return 50;// учр.адр.ин.орг.
                case 18: return 52;// факт.адр.контр.
                case 20: return 46;// тел.служ.
                case 21: return 47;// тел.служ. 2
                case 22: return 46;// тел.служ.на подр.
                case 23: return 47;// тел.служ.на подр.2
                case 24: return 48;// тел.служ.на подр.3
                case 25: return 38;// адрес для информ.физ.лица
                case 2352: return 2352;// образование
                default: return 0;
            };
        }
        private int GetWorkingPeriod(int Status)
        {
            switch (Status)
            {

                case 0: return 10;// работает
                case 1: return 11;// уволен
                case 2: return 12;// болеет
                case 3: return 13;// в командировке

                case 4: return 14;// в ежегод. отпуске
                case 5: return 15;// в уч. опл.отпуске
                case 6: return 16;// в уч. неопл.отпуске
                case 7: return 17;// в отпуске без сохр. зарпл.
                case 8: return 18;// в отпуске по берем.

                case 9: return 19;// в отп. по уходу за ребенком

                case 10: return 20;// отсутст.по невыясн.причине
                case 11: return 21;// время вынужд.прогула
                case 12: return 22;// время исполн.гос.об.
                case 13: return 23;// прогулы
                case 14: return 24;// доп.вых.дни
                case 15: return 25;// простаивает
                case 16: return 26;// травма
                case 17: return 27;// уход за больным реб.

                case 18: return 28;// уход за больным взрослым

                case 19: return 29;// карантин
                case 20: return 30;// протезиров
                case 21: return 31;// долечивание
                default: return 0;
            };
        }
        private int GetPersonnelChanges(int Status)
        {
            switch (Status)
            {
                case 0: return 5;// прием
                case 1: return 6;// перемещение
                case 2: return 7;// увольнение
                default: return 0;
            };
        }
        private void AppendText(string text, bool isConsole = false)
        {
            if (!isConsole)
            if (FormParent != null)
                {
                    FormParent.richTextBox1.AppendText(text);
                    Application.DoEvents();
                }
        }
    }

}