using DataSql;
using Logger;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace StatementsForME
{
    /// <summary>
    /// блок отправки данных руководителю
    /// </summary>
    public partial class StatementsToHead
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
                    setting.Parametr = "MailHead";

                    string sTimeBegin = Convert.ToString(setting.GetAttribute("TimeBegin", "string", "Shedule"));
                    if (sTimeBegin != "") TimeBeg = Convert.ToDateTime(sTimeBegin).TimeOfDay;

                    string sTimeEnd = Convert.ToString(setting.GetAttribute("TimeEnd", "string", "Shedule"));
                    if (sTimeEnd != "") TimeEnd = Convert.ToDateTime(sTimeEnd).TimeOfDay;

                    int sPeriodToBeginDay = Convert.ToInt32(setting.GetAttribute("PeriodToBeginDay", "int", "Shedule"));
                    if (sPeriodToBeginDay != 0) periodToBeginDay = sPeriodToBeginDay;

                    DataBeg = DateTime.Now.Date.AddDays(-periodToBeginDay);
                    DataEnd = DateTime.Now.Date;

                    IntervalShedule = Convert.ToInt32(setting.GetAttribute("Period", "int", "Shedule"));
                    StartShedule = Convert.ToDateTime(setting.GetAttribute("Start", "string", "Shedule"));

                    connectionStringMySQL = string.Format("Server= {0} ; Port= {1} ; Database={2}; Uid={3}; Pwd={4}; CharSet=utf8; Allow Zero DateTime = false; Convert Zero Datetime = true;", ServerMySQL, 3306, DatabaseMySQL, UserIdMySQL, PasswordMySQL);

    		}
            }
        }

        private SQLSettings _sqlSettings;
        private int periodToBeginDay = 1;

        public TimeSpan TimeBeg { get; set; } = new TimeSpan(17, 00, 0);
        public TimeSpan TimeEnd { get; set; } = new TimeSpan(06, 00, 0);
        public DateTime DataBeg { get; set; }
        public DateTime DataEnd { get; set; }
        private Settings setting { get; set; }
        public  int IntervalShedule { get; set; }
        public DateTime StartShedule { get; set; }

        string connectionStringMySQL;
        string ServerMySQL = "192.168.1.135";
        string UserIdMySQL = "root";
        string PasswordMySQL = "312jDSK-98";
        string DatabaseMySQL = "repa";


        #region блок отправки данных руководителю
        /// <summary>
        /// отправка почты (используется текущая дата - Now)
        /// </summary>
        public void Send()
        {
            //Log.Write(LogLevel.Info, "StatementsForME", "StatementsToHead", "Send", "Начало", null);
            object useMail = setting.GetAttribute("useMail", "bool");
            if (!((bool)useMail)) return;
            // найти имя конечного файла
            object fileOut = setting.GetAttribute("FileName");
            string outFormatFile = setting.GetAttribute("OutFormatFile").ToString();
            // получим данные и сформируем файл
            DataTable tableDamage = LoadData();
            //Log.Write(LogLevel.Info, "StatementsForME", "StatementsToHead", "Send", "fileMailOut = " + fileOut.ToString(), null);
            string fileMailOut = CreateExcel(tableDamage, Convert.ToString(fileOut), outFormatFile);
            if  (!System.IO.File.Exists(fileMailOut))
            {
                Log.Write(LogLevel.Error, "StatementsForME", "StatementsToHead", "Send - отправка данных", "Ошибка создания файла: файла нет!", null);
                return;
            }
            if (fileMailOut == "" || fileMailOut == null)
            {
                Log.Write(LogLevel.Error, "StatementsForME", "StatementsToHead", "Send - отправка данных", "Ошибка создания файла: имя файла пустое!", null);
                return;
            }
            //Log.Write(LogLevel.Info, "StatementsForME", "StatementsToHead", "Send", "fileMailOut = " + fileMailOut.ToString(), null);
            List<string> listFileName = new List<string>();
            listFileName.Add(fileMailOut);

            // получить параметры из конфигурационного файла для отправки почты
            string subject = setting.GetAttribute("Subject").ToString() + " " + DataEnd.ToShortDateString();
            string body = setting.GetAttribute("Body").ToString();

            string smtpServer = setting.GetAttribute("Name", "string", "SMTP").ToString();
            int stmpPort = Convert.ToInt32(setting.GetAttribute("Port", "string", "SMTP"));
            string smtpLogin = setting.GetAttribute("Login", "string", "SMTP").ToString();
            string smtpPassword = setting.GetAttribute("Pwd", "string", "SMTP").ToString();

            string senderAddress = setting.GetAttribute("Address", "string", "Sender").ToString();
            string senderName = setting.GetAttribute("Name", "string", "Sender").ToString();

            //  соберем отправителей 
            DataTable dtRecipient = setting.GetAttributeTable("Recipients", "Recipient");

            List<Library.Recipient> listRecipient = new List<Library.Recipient>();
            foreach (DataRow row in dtRecipient.Rows)
            {
                listRecipient.Add(new Library.Recipient(row["Address"].ToString(), row["Name"].ToString()));
            }
            //  отправить письмо 
            if (Library.Mail.Send(smtpServer, stmpPort, smtpLogin, smtpPassword, senderAddress, senderName, listRecipient, subject, body, listFileName, false))
            {
                //MessageBox.Show("Сообщение успешно отправлено");
                Log.Write(LogLevel.Info, "StatementsForME", "StatementsToHead", "Send - отправка данных", "Успешная отправка сообщения", null);
            }
            else
            {
                //MessageBox.Show("Ошибка отправки сообщения!");
                Log.Write(LogLevel.Error, "StatementsForME", "StatementsToHead", "Send - отправка данных", "Ошибка отправки сообщения", null);
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
                return "" ;

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
                viewer.LocalReport.ReportEmbeddedResource = "StatementsForME.ReportsForHeads.ReportToManager.rdlc";
                string dateReport = DataEnd.ToString("dd.MM.yyyy");
                string Period = "( c " + DataBeg.ToLongDateString() + " " + TimeBeg.Hours.ToString("D2") + ":" + TimeBeg.Minutes.ToString("D2") + " по " + DataEnd.ToLongDateString() + " " + TimeEnd.Hours.ToString("D2") + ":" + TimeEnd.Minutes.ToString("D2") + " " + ")";

                viewer.LocalReport.SetParameters(new ReportParameter("dateReport", dateReport));
                viewer.LocalReport.SetParameters(new ReportParameter("User", GetCurrentUser()));
                viewer.LocalReport.SetParameters(new ReportParameter("dateEnd", DataEnd.ToLongDateString()));
                viewer.LocalReport.SetParameters(new ReportParameter("Period", Period));

                viewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetReportToManager", tableDamage));

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
        /// <summary>
        /// получим текущего пользователя
        /// </summary>
        /// <returns></returns>
        public string GetCurrentUser()
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                sqlConnection.Open();
                using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand sqlCommand2 = new SqlCommand("select isnull(w.fio, u.name) as name from tuser u\r\n\t                                left join vr_worker w on u.idWorker = w.id\r\n                                    where login = SYSTEM_USER", sqlConnection))
                        {
                            sqlCommand2.CommandTimeout = 0;
                            sqlCommand2.Transaction = sqlTransaction;
                            DbDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCommand2);
                            DataTable dataTable = new DataTable();
                            dbDataAdapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["name"] != DBNull.Value)
                            {
                                return dataTable.Rows[0]["name"].ToString();
                            }
                        }
                        sqlTransaction.Commit();
                    }
                    catch //(Exception ex)
                    {
                        sqlTransaction.Rollback();
                    }
                }

            }
            return string.Empty;
        }
        public DataTable LoadData(DateTime? dataBeg = null, DateTime? dataEnd = null, string timeBeg = "", string timeEnd = "")
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                sqlConnection.Open();
                using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
                {
                    try
                    {
                        string strSelect = Library.ResourceReader.GetStringAssembly(typeof(SendRequestToME).Assembly, "StatementsForME.ReportsForHeads.GetTableDamageToManager.sql");

                        using (SqlCommand sqlCommand = new SqlCommand(strSelect, sqlConnection))
                        {
                            sqlCommand.CommandTimeout = 0;
                            sqlCommand.Transaction = sqlTransaction;
                            if (dataBeg == null)
                                sqlCommand.Parameters.Add("dataBeg", SqlDbType.DateTime).Value = DBNull.Value;
                            else
                                sqlCommand.Parameters.Add("dataBeg", SqlDbType.DateTime).Value = dataBeg;
                            if (dataEnd == null)
                                sqlCommand.Parameters.Add("dataEnd", SqlDbType.DateTime).Value = DBNull.Value;
                            else
                                sqlCommand.Parameters.Add("dataEnd", SqlDbType.DateTime).Value = dataEnd;

                            sqlCommand.Parameters.Add("timeBeg", SqlDbType.VarChar).Value = timeBeg;
                            sqlCommand.Parameters.Add("timeEnd", SqlDbType.VarChar).Value = timeEnd;
                            sqlCommand.Parameters.Add("periodToBeginDay", SqlDbType.Int).Value = DBNull.Value;
                            new SqlDataAdapter(sqlCommand).Fill(dt);
                        }

                        sqlTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();
                        //MessageBox.Show(ex.Message, ex.Source);
                        Log.Write(LogLevel.Error, "StatementsToHead", "ServiStatementsToHeadceScheme", "LoadData("+ dataBeg + ","+ dataEnd + ", "+ timeBeg + ","+ timeEnd + ")", ex.Message, null);
                    }
                }
            }
            return dt;
        }
        public DataTable LoadData()
        {
            // основная база данных
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                sqlConnection.Open();
                using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
                {
                    try
                    {
                        string strSelect = Library.ResourceReader.GetStringAssembly(typeof(SendRequestToME).Assembly, "StatementsForME.ReportsForHeads.GetTableDamageToManager.sql");

                        using (SqlCommand sqlCommand = new SqlCommand(strSelect, sqlConnection))
                        {
                            sqlCommand.CommandTimeout = 0;
                            sqlCommand.Transaction = sqlTransaction;
                            if (DataBeg == null)
                                sqlCommand.Parameters.Add("dataBeg", SqlDbType.DateTime).Value = DBNull.Value;
                            else
                                sqlCommand.Parameters.Add("dataBeg", SqlDbType.DateTime).Value = DataBeg;
                            if (DataEnd == null)
                                sqlCommand.Parameters.Add("dataEnd", SqlDbType.DateTime).Value = DBNull.Value;
                            else
                                sqlCommand.Parameters.Add("dataEnd", SqlDbType.DateTime).Value = DataEnd;

                            sqlCommand.Parameters.Add("timeBeg", SqlDbType.VarChar).Value = TimeBeg.ToString();
                            sqlCommand.Parameters.Add("timeEnd", SqlDbType.VarChar).Value = TimeEnd.ToString();
                            sqlCommand.Parameters.Add("periodToBeginDay", SqlDbType.Int).Value = DBNull.Value;
                            new SqlDataAdapter(sqlCommand).Fill(dt);
                        }

                        sqlTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();
                        Log.Write(LogLevel.Error, "StatementsToHead", "ServiStatementsToHeadceScheme", "LoadData MSSQL", ex.Message, null);
                        //MessageBox.Show(ex.Message, ex.Source);
                    }
                }
            }
            // база уличного освещения
            DataTable dtMySQL = new DataTable();
            MySqlConnection mySqlConnection = new MySqlConnection(connectionStringMySQL);

            try
            {
                mySqlConnection.Open();
                string strSelect = Library.ResourceReader.GetStringAssembly(typeof(SendRequestToME).Assembly, "StatementsForME.ReportsForHeads.GetTableDamageToManagerUO.sql");
                using (MySqlDataAdapter daMySql = new MySqlDataAdapter())
                {
                    MySqlCommand cmd = new MySqlCommand(strSelect, mySqlConnection);
                    if (DataBeg == null)
                        cmd.Parameters.Add("dataBeg", MySqlDbType.Date).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("dataBeg", MySqlDbType.Date).Value = DataBeg;
                    if (DataEnd == null)
                        cmd.Parameters.Add("dataEnd", MySqlDbType.Date).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("dataEnd", MySqlDbType.Date).Value = DataEnd;

                    cmd.Parameters.Add("timeBeg", MySqlDbType.VarChar).Value = TimeBeg.ToString();
                    cmd.Parameters.Add("timeEnd", MySqlDbType.VarChar).Value = TimeEnd.ToString();
                    //cmd.Parameters.Add("periodToBeginDay", MySqlDbType.Int32).Value = DBNull.Value;

                    daMySql.SelectCommand = cmd;

                    daMySql.Fill(dtMySQL);
                    
                }
            }
            catch (Exception ex)
            {
                Log.Write(LogLevel.Error, "StatementsToHead", "ServiStatementsToHeadceScheme", "LoadData MySQL", ex.Message, null);
            }

            try
            {
                dt.Merge(dtMySQL, true);
            }
            catch (Exception ex)
            {
                Log.Write(LogLevel.Error, "StatementsToHead", "ServiStatementsToHeadceScheme", "Объединение таблиц", ex.Message, null);
            }

            return dt;
        }
    }
}
