using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExportToPostGIS.SmartCity
{
    public partial class FormIntegrationSmartCity : FormBase
    {
        private DateTimePicker dateTimePickerBegin;
        private DateTimePicker dateTimePickerEnd;
        private ToolStripLabel lInterval;
        private ToolStripTextBox tbInterval;

        private const int ODS_DIVISION = 920;
        private const int PL_DIVISION = 921;
        private const int NO_DIVISION = 1665;

        DateTime DataBeg;
        DateTime DataEnd;
        DateTime DataStartShedule;
        int Interval;

        SmartCity rpt;
        public FormIntegrationSmartCity()
        {
            InitializeComponent();
        }
        // Здесь тренируем подключение к ЦУГ
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SmartCity ss = new SmartCity();
            ss.SqlSettings = this.SqlSettings;
            ss.Integration();

        }
        string executorName = "Единый Диспетчер УльГЭС";
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //SmartCity ss = new SmartCity();
            //ss.SqlSettings = this.SqlSettings;
            //ss.Send();
            // 0.1 Токен получим 
            if (rpt.ACCESS_TOKEN == "")
            {
                Log.Write(LogLevel.Error, "SmartCityIntegration", "SmartCityIntegration", "Send", "Не удалось получить токен из ЦУГ", null);
                return;
            }

            // 0.2 Получить по реквизитам текущий ид организации (из ЦУГ)
            var OrganizationCurrent = rpt.GetDateWhere(rpt.ACCESS_TOKEN, new SmartCity.Organizations(), $"Organizations?Inn={rpt.INN}&Kpp={rpt.KPP}");
            int OrganizationCurrentID = OrganizationCurrent.data[0].id;
            string executorPhone = OrganizationCurrent.data[0].phone;
            
            // 0.3 Справочники (а может и не нужны они)
            // SmartCity.GetResultP<SmartCity.WorkKinds> WorkKinds = rpt.GetDate(rpt.ACCESS_TOKEN, new SmartCity.WorkKinds());
            string workKindCode = "Electricity"; // Code = "Electricity" // Энергетика
            // SmartCity.GetResultP<SmartCity.ShutdownCauses> ShutdownCauses1 = rpt.GetDateWhere(rpt.ACCESS_TOKEN, new SmartCity.ShutdownCauses(), $"ShutdownCauses?OrganizationId={OrganizationCurrentID}");
            string shutdownCauseCode = "PlanovyeRabotyNaSetyah";
            // Code = "PlanovyeRabotyNaSetyah" // плановые работы
            // "AvariinyeRabotyVSetyah" =  Аварийные работы в сетях
            //////////// Получим все заявки на отключение
            //////////string startDateQuery = rpt.DataBeg.ToString("yyyy-MM-ddTHH:mm:ss");
            //////////string endDateQuery = rpt.DataEnd.ToString("yyyy-MM-ddTHH:mm:ss");
            //////////var Shutdowns = rpt.GetDateWhere(rpt.ACCESS_TOKEN, new SmartCity.ShutdownsGetDTO(), $"Shutdowns?OrganizationId={OrganizationCurrentID}&StartDate={startDateQuery}&EndDate={endDateQuery}");
            #region Отправка данных основных
            // 1. Получилим данные из энергосхемы (плановые)
            // j.agreed = 1 and j.SendSite = 1 (утвержденные и отправленные на сайт)
            DataTable tableResultat = rpt.LoadDataPlanned();
            foreach (DataColumn col in tableResultat.Columns)
            {
                DataGridViewFilterTextBoxColumn columnDgv = new DataGridViewFilterTextBoxColumn();
                columnDgv.Name = col.ColumnName;
                columnDgv.HeaderText = col.ColumnName;
                columnDgv.DataPropertyName = col.ColumnName;

                dgvResultat.Columns.Add(columnDgv);

            }
            BindingSource bsResult = new BindingSource();
            bsResult.DataSource = tableResultat;
            dgvResultat.DataSource = bsResult;
            // 2. Сформируем json для передачи данных
            // Отправка данных (Shutdowns по одному документу - по одному интервалу во времени (tJ_RequestForRepairDaily))
            for (int i = 0; i < tableResultat.Rows.Count; i++)
            {
                // идентификатор документа заявки
                int IdDocument = Convert.ToInt32(tableResultat.Rows[i]["id"]);
                // идентификатор периодп в докумете заявке (зависит от IdDocument)
                int idDaily = Convert.ToInt32(tableResultat.Rows[i]["idDaily"]);
                // идентификатор записи события Daily в базе ЦУГ
                int idCMR = -1;
                // таблица отправленных данных (нужны текущие не удаленные {deleted = 0} и не завершенные {dateFactEnd is null})
                var tableSendCMR = dataSetSmartCity.tJ_RequestForRepairSendCMR;
                this.SelectSqlData(tableSendCMR, true, $" where idDaily = {idDaily} and deleted = 0 and dateFactEnd is null");
                // таблица данных в заявке
                var tableDaily = dataSetSmartCity.tJ_RequestForRepairDaily;
                this.SelectSqlData(tableDaily, true, $" where id = {idDaily}");

                if (tableSendCMR.Rows.Count > 0) // проверим наличие уже отправленных данных
                {
                    idCMR = (int)tableSendCMR.Rows[0]["idCMR"];
                    // если даты не совпадают в текущем idDaily, то старое помечаем на удаление  и создаем новое 
                    if (tableSendCMR.Rows[0]["dateBeg"] == DBNull.Value || tableSendCMR.Rows[0]["dateEnd"] == DBNull.Value ||
                        Convert.ToDateTime(tableSendCMR.Rows[0]["dateBeg"]) != Convert.ToDateTime(tableDaily.Rows[0]["dateBeg"]) ||
                                Convert.ToDateTime(tableSendCMR.Rows[0]["dateEnd"]) != Convert.ToDateTime(tableDaily.Rows[0]["dateEnd"]))
                    {
                        // в ЦУГ изменить дату фактического выполнения работы
                        DataRow dataRow2 = tableSendCMR.Rows[0];
                        dataRow2["deleted"] = true;
                        dataRow2["dateFactEnd"] = tableDaily.Rows[0]["dateBeg"];
                        dataRow2.EndEdit();

                        SmartCity.ShutdownPatchDTO damage = new SmartCity.ShutdownPatchDTO();
                        damage.completionDate = ((DateTime)dataRow2["dateFactEnd"]).ToString("yyyy-MM-ddTHH:mm:ss");
                        SmartCity.GetResultP<SmartCity.ShutdownPatchDTO> Result = rpt.PatchResult(rpt.ACCESS_TOKEN, damage, $"Shutdowns/{idCMR}");
                        if (Result.status != 1)
                        {
                            MessageBox.Show($"Ошибка отправки завершения работ в ЦУГ: {Result.result.body}");
                            Log.Write(LogLevel.Error, "SmartCityIntegration", "FormIntegrationSmartCity", "LoadData ЦУГ", $"Ошибка отправки завершения работ в ЦУГ: {Result.result.body}", null);
                        }

                        idCMR = -1;
                    }
                }
                if (idCMR == -1) // если отключение  уже отправили (ид ЦУГ давно получено), иначе  отправляем данные
                {
                    SmartCity.ShutdownPostDTO damage = new SmartCity.ShutdownPostDTO();
                    damage.organizationId = OrganizationCurrentID;
                    damage.workKindCode = workKindCode;
                    damage.shutdownCauseCode = shutdownCauseCode;
                    damage.executorName = executorName;
                    damage.executorPhone = executorPhone;
                    //damage.startDate = ((DateTime)tableResultat.Rows[i]["dateTripBeg"]).ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");// tableResultat.Rows[i]["dateTripBeg"].ToString();
                    //damage.endDate = ((DateTime)tableResultat.Rows[i]["dateTripEnd"]).ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");// tableResultat.Rows[i]["dateTripEnd"].ToString();

                    DateTime databeg = ((DateTime)tableResultat.Rows[i]["dateTripBeg"]);
                    DateTime dataend = ((DateTime)tableResultat.Rows[i]["dateTripEnd"]);
                    damage.startDate = databeg.ToString("yyyy-MM-ddTHH:mm:ss");
                    damage.endDate = dataend.ToString("yyyy-MM-ddTHH:mm:ss");

                    damage.comment = "Это тестовое отключение в рамках проверки интегарции программных систем ЦУГ и УльГЭ {idDaily=" + idDaily.ToString()+ "}";
                    // {}
                    //
                    SmartCity.GetResultP<SmartCity.ShutdownPostDTO> Result = rpt.PostResult(rpt.ACCESS_TOKEN, damage, $"Shutdowns");

                    // надо делать только обновление текущей записи в документе ремонтных работ
                    if (Result.status == 1) // получили id события
                    {
                        // id пришло  из ЦУГ
                        idCMR = Convert.ToInt32(Result.result.code);

                        if (idCMR > 0)
                        {
                            // занесем событие ЦУГ в таблицу tJ_RequestForRepairSendCMR
                            // в api ЦУГ есть только добавление событий
                            //if (tableSendCMR.Rows.Count == 0)
                            //{
                                DataRow dataRow2 = tableSendCMR.NewRow();
                                dataRow2["idRequest"] = IdDocument;
                                dataRow2["idDaily"] = idDaily;
                                dataRow2["idRequest"] = IdDocument;
                                dataRow2["idCMR"] = idCMR;
                                dataRow2["dateBeg"] = databeg;
                                dataRow2["dateEnd"] = dataend;

                                tableSendCMR.Rows.Add(dataRow2);
                                dataRow2.EndEdit();
                            //}
                            //else
                            //{
                            //    // должна быть одна строка
                            //    DataRow dataRow2 = tableSendCMR.Rows[0];
                            //    dataRow2["idRequest"] = IdDocument;
                            //    dataRow2["idDaily"] = idDaily;
                            //    dataRow2["idRequest"] = IdDocument;
                            //    dataRow2["idCMR"] = idCMR;
                            //    dataRow2.EndEdit();
                            //}
                            LibraryTSQL.SqlDataCommand cTSQL = new LibraryTSQL.SqlDataCommand(SqlSettings);
                            cTSQL.InsertSqlData(tableSendCMR);
                            cTSQL.UpdateSqlData(tableSendCMR);
                            ////cTSQL.DeleteSqlData(tableSendCMR);

                        }
                        else
                        {
                            MessageBox.Show($"Ошибка обработки данных из ЦУГ: {Result.result.body}");
                            Log.Write(LogLevel.Error, "SmartCityIntegration", "FormIntegrationSmartCity", "LoadData ЦУГ", $"Ошибка обработки данных из ЦУГ: {Result.result.body}", null);

                        }
                        // LibraryTSQL.SqlDataCommand cTSQL = new LibraryTSQL.SqlDataCommand(SqlSettings);
                        // cTSQL.UpdateSqlData(new DataTable("tJ_RequestForRepairDaily"), "[idCMR] = " + Result.result.code, " [id] = " + idDaily);
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка передачи данных: {Result.result.body}");
                        Log.Write(LogLevel.Error, "SmartCityIntegration", "FormIntegrationSmartCity", "LoadData ЦУГ", $"Ошибка передачи данных: {Result.result.body}", null);
                    }
                }
                else
                {
                    //  проверим фактически выполненнеы заявки
                    //                      если даты не совпадают сохраненнеы (Daily) с отправленными (Send)
                    //                      отпрвляем заново, а текщую запись помечаем на удаление
                    //                      dateBeg
                    //                      dateEnd
                }
                // отправить даннеы об адрессах отключения (вставка, обновление, удаление)
                // заполнить информацию в таблицу tJ_RequestForRepairSendCMR (???)
                // отправить данные о фактически выполненной работе через dateFactEnd из tJ_RequestForRepair
            }
            #endregion
            #region Корректировка данных
            // 1. проверяем данные не попавшие в основной запрос
            // сюда должны войти у которых 
            //                      1 - дата фактического выполнения работ пустая
            //                      2 - удаленные документы
            //                      3 - документы отмененные
            //                      4 - документы у которых периоды работ изменились (количество записей в таблице tJ_RequestForRepairSendCMR не соответствует количеству записей в таблице tJ_RequestForRepairDaily)
            //           Для документов 2,3,4 поставить выполнения работ равну началу работ
            //           Для документов 1 установить либо фактическую дату если заполнена, либо дату и время текущего периода
            // список отправленных отключений
            var listSendIdDaily = tableResultat.AsEnumerable().Select(s =>  s["idDaily"].ToString());

            // вытащим события Daily которые не удалены и у которых фактическое окончание работ пустое
            // и которые на текущий момент не отправллись
            var tableSendCMR1 = dataSetSmartCity.tJ_RequestForRepairSendCMR;
            this.SelectSqlData(tableSendCMR1, true, $" where idCMR not in ({string.Join(",", listSendIdDaily.ToArray())}) and deleted = 0 and dateFactEnd is null");
            foreach(var row in tableSendCMR1.AsEnumerable())
            {
                // dateFactEnd может быть текущей ???? заранее могут установить

            }


            #endregion
            #region Проверка данных в ЦУГ, которых у нас нет
            // Что с ними делать
            #endregion

        }

        private void FormIntegrationSmartCity_Load(object sender, EventArgs e)
        {
            rpt = new SmartCity();
            rpt.SqlSettings = this.SqlSettings;
            DataBeg = rpt.DataBeg;
            DataEnd = rpt.DataEnd;
            Interval = rpt.Interval;
            DataStartShedule = rpt.StartShedule;

            this.dateTimePickerBegin = new DateTimePicker();
            this.dateTimePickerBegin.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBegin.Value = DataBeg;
            this.dateTimePickerBegin.Width = 50;
            this.dateTimePickerBegin.ValueChanged += new System.EventHandler(dateTimePickerBegin_ValueChanged);
            this.toolStrip.Items.Insert(1, new ToolStripControlHost(this.dateTimePickerBegin));

            this.dateTimePickerEnd = new DateTimePicker();
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerEnd.Value = DataEnd;
            this.dateTimePickerEnd.Width = 50;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            this.toolStrip.Items.Insert(3, new ToolStripControlHost(this.dateTimePickerEnd));


            this.lInterval = new System.Windows.Forms.ToolStripLabel
            {
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                Name = "lInterval",
                Size = new System.Drawing.Size(60, 22),
                Text = "Интервал"
            };
            //this.tbInterval.TextChanged += new EventHandler(tbPeriodToBeginDay_TextChanged);
            this.tbInterval.ReadOnly = true;

            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lInterval,
            this.tbInterval});
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dateTimePickerBegin_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
