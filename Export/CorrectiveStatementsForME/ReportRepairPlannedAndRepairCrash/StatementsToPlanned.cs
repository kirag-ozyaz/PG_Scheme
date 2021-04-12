using DataSql;
using Logger;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace StatementsForME
{
    /// <summary>
    /// отправка плановых и ремонтных работ в ульяновскэнерго
    /// </summary>
    public class StatementsToPlanned
    {
        public SQLSettings SqlSettings
        {
            get
            {
                return _sqlSettings;
            }
            set
            {
                if (value != null)
                {
                    _sqlSettings = value;
                    // считать надо конфигурационный файл
                    setting = new Settings();
                    setting.SqlSettings = this.SqlSettings;
                    setting.Parametr = "MailPlannedUE";

                    int sIntervalUE = Convert.ToInt32(setting.GetAttribute("IntervalUE", "int", "SheduleUE"));
                    if (sIntervalUE != 0)
                        Interval = sIntervalUE;
                    else
                        Interval = 1;
                    int sIntervalCrashUE = Convert.ToInt32(setting.GetAttribute("IntervalCrashUE", "int", "SheduleUE"));
                    if (sIntervalCrashUE != 0)
                        IntervalCrash = sIntervalCrashUE;
                    else
                        IntervalCrash = -1;
                    DataBeg = DateTime.Now.Date;
                    DataEnd = DateTime.Now.Date.AddDays(Interval).AddMilliseconds(-1);

                    IntervalShedule = Convert.ToInt32(setting.GetAttribute("PeriodUE", "int", "SheduleUE"));
                    StartShedule = Convert.ToDateTime(setting.GetAttribute("StartUE", "string", "SheduleUE"));

                }
            }
        }
        private SQLSettings _sqlSettings;

        public int Interval { get; set; } = 1;
        public int IntervalCrash { get; set; } = -1;

        public DateTime DataBeg { get; set; }
        public DateTime DataEnd { get; set; }

        private Settings setting { get; set; }
        public int IntervalShedule { get; set; }
        public DateTime StartShedule { get; set; }
        public string ReportMaket { get; set; } = "StatementsForME.ReportRepairPlannedAndRepairCrash.ReportrequestForRepairFullPeriodGroup1.rdlc";

        public DataTable LoadData(DateTime dateBeg, DateTime dateEnd, string query)
        {
            DataTable dt = new DataTable();
            // заберем плановые работы
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                sqlConnection.Open();
                using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
                {
                    try
                    {
                        string strSelect = Library.ResourceReader.GetStringAssembly(typeof(SendRequestToME).Assembly, query);
                        //strSelect += "";
                        using (SqlCommand sqlCommand = new SqlCommand(strSelect, sqlConnection))
                        {
                            sqlCommand.CommandTimeout = 0;
                            sqlCommand.Transaction = sqlTransaction;
                            if (DataBeg == null)
                                sqlCommand.Parameters.Add("dateBegin", SqlDbType.DateTime).Value = DBNull.Value;
                            else
                                sqlCommand.Parameters.Add("dateBegin", SqlDbType.DateTime).Value = dateBeg;
                            if (DataEnd == null)
                                sqlCommand.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = DBNull.Value;
                            else
                                sqlCommand.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = dateEnd;

                            //sqlCommand.Parameters.Add("periodToBeginDay", SqlDbType.Int).Value = DBNull.Value;
                            new SqlDataAdapter(sqlCommand).Fill(dt);
                        }

                        sqlTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();
                        Log.Write(LogLevel.Error, "StatementsToToPlanned", "ServiStatementsToPlanned", "LoadData MSSQL", ex.Message, null);
                    }
                }
            }
            return dt;
        }
        public DataTable LoadData(string query)
        {
            return LoadData(DataBeg, DataEnd, query);
        }
        public DataTable LoadData()
        {
            // основная база данных - эксплатцич
            DataTable dt = new DataTable();
            // плановые работы
            DataTable dtPlanned =  LoadData( "StatementsForME.ReportRepairPlannedAndRepairCrash.GetTableRepairPlanned.sql");
            dt.Merge(dtPlanned, false, MissingSchemaAction.Add);
            
            // аварийные работы
            // рассчитаем даты аварийных событий
            DateTime DataBegCrash = DataBeg.Date.AddDays(IntervalCrash);
            DateTime DataEndCrash = DataBeg.Date.AddMilliseconds(-1);
            DataTable dtCrash =  LoadData(DataBegCrash, DataEndCrash, "StatementsForME.ReportRepairPlannedAndRepairCrash.GetTableRepairCrash.sql");
            dt.Merge(dtCrash, false, MissingSchemaAction.Add);
            //DataTable result = dtPlanned.AsEnumerable().Union(dtCrash.AsEnumerable()).CopyToDataTable();

            DataTable dtAddResult = dt.Clone();
            foreach (DataRow row in dt.AsEnumerable())
            {
                // сделаем дату начала заявки согласно выбранному диапозону
                // но только для плановых работ
                if (!Convert.ToBoolean(row["Crash"]))
                    if (Convert.ToDateTime(row["dateTripBeg"]) < DataBeg)
                        row["dateTripBeg"] = DataBeg;

                DateTime dateTripBeg = Convert.ToDateTime(row["dateTripBeg"]).Date;
                DateTime dateTripEnd = Convert.ToDateTime(row["dateTripEnd"]).Date;
                // если диапозон между началом и концом больше, чем один день
                // то количество строк для работы должно быть равно количеству дней
                // 1. в текущей строке заменим дату конца в текущей строке, сделаем концом суток
                // 2. добавим дополнительное количество строк 
                // 3. в последней строке изменим время конца как в основной строке
                if (dateTripBeg != dateTripEnd)
                {
                    // запомним последнюю дату и время диапозона работ
                    var dateTripEndLast = row["dateTripEnd"];
                    // заменим дату конца в текущей строке, сделаем концом суток
                    row["dateTripEnd"] = dateTripBeg.AddDays(1).AddMilliseconds(-1);
                    //
                    bool isFillingLastRow = true; // статус для изменеия последней строки
                    //
                    for (int i = 1; i <= (dateTripEnd - dateTripBeg).TotalDays; i++)
                    {
                        // если дата начала работы дня больше даты окончания отчета, то прерываем цикл
                        if (dateTripBeg.AddDays(i) > DataEnd)
                        {
                            isFillingLastRow = false;
                            break;
                        }

                        DataRow desRow = dtAddResult.NewRow();
                        desRow.ItemArray = row.ItemArray.Clone() as object[];
                        desRow["dateTripBeg"] = dateTripBeg.AddDays(i);
                        desRow["dateTripEnd"] = dateTripBeg.AddDays(i + 1).AddMilliseconds(-1);
                        dtAddResult.Rows.Add(desRow);

                    }
                    if (isFillingLastRow)
                    {
                        DataRow rrr = dtAddResult.Rows[dtAddResult.Rows.Count - 1];
                        rrr["dateTripEnd"] = dateTripEndLast;
                    }
                }
            }
            dt.Merge(dtAddResult, false, MissingSchemaAction.Add);
            return dt;
        }


        #region блок отправки данных ульяновскэнерго
        /// <summary>
        /// отправка почты
        /// </summary>
        public void Send()
        {
            //Log.Write(LogLevel.Info, "StatementsForME", "StatementsToHead", "Send", "Начало", null);
            object useMail = setting.GetAttribute("useMailUE", "bool");
            if (!((bool)useMail)) return;
            // найти имя конечного файла
            object fileOut = setting.GetAttribute("FileNameUE");
            string outFormatFile = setting.GetAttribute("OutFormatFileUE").ToString();
            // получим данные и сформируем файл
            DataTable tableDamage = LoadData();
            //Log.Write(LogLevel.Info, "StatementsForME", "StatementsToHead", "Send", "fileMailOut = " + fileOut.ToString(), null);
            string fileMailOut = CreateExcel(tableDamage, Convert.ToString(fileOut), outFormatFile);
            if (!System.IO.File.Exists(fileMailOut))
            {
                Log.Write(LogLevel.Error, "StatementsPlanned", "StatementsPlanned", "Send - отправка данных", "Ошибка создания файла: файла нет!", null);
                return;
            }
            if (fileMailOut == "" || fileMailOut == null)
            {
                Log.Write(LogLevel.Error, "StatementsPlanned", "StatementsPlanned", "Send - отправка данных", "Ошибка создания файла: имя файла пустое!", null);
                return;
            }
            //Log.Write(LogLevel.Info, "StatementsForME", "StatementsToHead", "Send", "fileMailOut = " + fileMailOut.ToString(), null);
            List<string> listFileName = new List<string>();
            listFileName.Add(fileMailOut);

            // получить параметры из конфигурационного файла для отправки почты
            string subject = setting.GetAttribute("SubjectUE").ToString() + " " + DataEnd.ToShortDateString();
            string body = setting.GetAttribute("BodyUE").ToString();

            string smtpServer = setting.GetAttribute("NameUE", "string", "SMTPUE").ToString();
            int stmpPort = Convert.ToInt32(setting.GetAttribute("PortUE", "string", "SMTPUE"));
            string smtpLogin = setting.GetAttribute("LoginUE", "string", "SMTPUE").ToString();
            string smtpPassword = setting.GetAttribute("PwdUE", "string", "SMTPUE").ToString();

            string senderAddress = setting.GetAttribute("AddressUE", "string", "SenderUE").ToString();
            string senderName = setting.GetAttribute("NameUE", "string", "SenderUE").ToString();

            //  соберем отправителей 
            DataTable dtRecipient = setting.GetAttributeTable("RecipientsUE", "RecipientUE");

            List<Library.Recipient> listRecipient = new List<Library.Recipient>();
            foreach (DataRow row in dtRecipient.Rows)
            {
                listRecipient.Add(new Library.Recipient(row["AddressUE"].ToString(), row["NameUE"].ToString()));
            }
            //  отправить письмо 
            if (Library.Mail.Send(smtpServer, stmpPort, smtpLogin, smtpPassword, senderAddress, senderName, listRecipient, subject, body, listFileName, false))
            {
                //MessageBox.Show("Сообщение успешно отправлено");
                Log.Write(LogLevel.Info, "StatementsPlanned", "StatementsPlanned", "Send - отправка данных", "Успешная отправка сообщения", null);
            }
            else
            {
                //MessageBox.Show("Ошибка отправки сообщения!");
                Log.Write(LogLevel.Error, "StatementsPlanned", "StatementsPlanned", "Send - отправка данных", "Ошибка отправки сообщения", null);
            }

        }
        public void CreateExcel()
        {
            DataTable tableDamage = LoadData();
            // найти имя конечного файла
            string fileOut = setting.GetAttribute("FileName").ToString();
            string outFormatFile = setting.GetAttribute("OutFormatFile").ToString();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.RestoreDirectory = true;
            dlg.Filter = "PDF|*.pdf|Excel|*.xls|Word|*.doc";
            dlg.FileName = Path.GetFileName(fileOut);
            dlg.OverwritePrompt = true;
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = dlg.FileName;
            CreateExcel(tableDamage, filename, Path.GetExtension(filename).Substring(1));
        }
        /// <summary>
        /// создадим файл
        /// </summary>
        /// <param name="tableDamage"></param>
        /// <returns></returns>
        public string CreateExcel(DataTable tableDamage, string fileOut = "", string outFormatFile = null)
        {
            Library.Security security = new Library.Security();
            security.SqlSettings = SqlSettings;
            string CurrentUsers = security.GetCurrentUser();

            if (outFormatFile == null)
            {
                outFormatFile = Path.GetExtension(fileOut).Substring(1);
            }


            string typeOutFile = "";
            string typeFile = "";
            if (outFormatFile == null || outFormatFile.ToUpper() == "PDF")
            {
                typeOutFile = "PDF";
                typeFile = "PDF";
            }
            else if (outFormatFile == "Excel" || outFormatFile.ToUpper() == "XLS")
            {
                typeOutFile = "xls";
                typeFile = "Excel";
            }
            else if (outFormatFile == "Word" || outFormatFile.ToUpper() == "DOC")
            {
                typeOutFile = "doc";
                typeFile = "Word";
            }
            else
                return "";

            string temp_path = fileOut;
            try
            {

                Warning[] warnings;
                string deviceInfo =
                "<DeviceInfo>" +
                " <OutputFormat>" + typeOutFile + "</OutputFormat>" +
                " <PageWidth>9.5in</PageWidth>" +
                " <PageHeight>8.5in</PageHeight>" +
                " <MarginTop>0.05in</MarginTop>" +
                " <MarginLeft>0.05in</MarginLeft>" +
                " <MarginRight>0.05in</MarginRight>" +
                " <MarginBottom>0.05in</MarginBottom>" +
                "</DeviceInfo>";
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                // Setup the report viewer object and get the array of bytes
                ReportViewer viewer = new ReportViewer();
                viewer.ProcessingMode = ProcessingMode.Local;
                viewer.LocalReport.ReportEmbeddedResource = ReportMaket;

                viewer.LocalReport.SetParameters(new ReportParameter("DateBegin", DataBeg.ToLongDateString()));
                viewer.LocalReport.SetParameters(new ReportParameter("DateEnd", DataEnd.ToLongDateString()));


                viewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetRepairDaily", tableDamage));
                
                byte[] bytes = viewer.LocalReport.Render(typeFile, deviceInfo, out mimeType,
                                                          out encoding, out extension,
                                                          out streamIds, out warnings);

                // Prepare filename and save_path, and then write the Excel using FileStream.
                // какая-то хрень млять
                string fileName = "report_heads." + typeOutFile;
                temp_path = Path.Combine(System.IO.Path.GetTempPath(), fileName);
                if (fileOut != "")
                    temp_path = fileOut;

                try
                {
                    temp_path = Path.ChangeExtension(temp_path, typeOutFile);
                    FileStream fs = new FileStream(temp_path, FileMode.Create);
                    fs.Write(bytes, 0, bytes.Length);
                    fs.Close();
                }
                catch
                {
                    temp_path = Path.Combine(System.IO.Path.GetTempPath(), fileName);
                    FileStream fs = new FileStream(temp_path, FileMode.Create);
                    fs.Write(bytes, 0, bytes.Length);
                    fs.Close();
                }

            }
            catch
            {
                temp_path = "";
            }
            return temp_path;
        }
        #endregion

    }
}
