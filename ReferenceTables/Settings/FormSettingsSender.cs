using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;
using FormLbr;
using System.ServiceProcess;

/// <summary>
/// сервисные настройки
/// планировщики, параметры отправки данных
/// </summary>
public partial class FormSettingsSender : FormBase
{
    private DataTable tblSettings;
    public FormSettingsSender()
    {

        this.InitializeComponent();
        this.tblSettings = new DataTable("tSettings");
        DataColumn dataColumn = new DataColumn("id", typeof(int));
        dataColumn.AutoIncrement = true;
        this.tblSettings.Columns.Add(dataColumn);
        this.tblSettings.Columns.Add("settings", typeof(string));
        this.tblSettings.Columns.Add("module", typeof(string));
        DataColumn[] primaryKey = new DataColumn[]
        {
                dataColumn
        };
        this.tblSettings.PrimaryKey = primaryKey;
    }

    private void FormSettingsSender_Load(object sender, EventArgs e)
    {
        // [IdGroup] = 10  - группа админов
        DataTable dataTable = new DataTable("tUserInGroup");
        dataTable.Columns.Add("idUser", typeof(int));
        dataTable.Columns.Add("IdGroup", typeof(int));
        base.SelectSqlData(dataTable, true, " left join [tUser] [user] on  [user].[IDUser] =  [tUserInGroup].iduser where[user].deleted = 0 and [tUserInGroup].[IdGroup] = 10 and [login] = SYSTEM_USER", null, false, 0);
        if (dataTable.Rows.Count == 0)
        {
            this.Close();
        }

        base.SelectSqlData(this.tblSettings, true, string.Format(" where Module = '{0}'", "FTP05"), null, false, 0);
        if (this.tblSettings.Rows.Count == 0)
        {
            DataRow dataRow = this.tblSettings.NewRow();
            dataRow["Settings"] = this.CreateXmlConfigSender().InnerXml;
            dataRow["Module"] = "FTP05";
            this.tblSettings.Rows.Add(dataRow);
        }
        else
            this.ApplyConfigSender();

        txtRemoteServer.Text = MachineName;
        txtServiceName.Text = ServiceName;

        //Делаем таймер доступным
        timerServiceRun.Enabled = true;
        //Запускаем таймер
        timerServiceRun.Start();
    }

    private void FormSettingsSender_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK || MessageBox.Show("Сохранить внесенные изменения?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            if (this.tblSettings.Rows.Count == 0)
            {
                DataRow dataRow = this.tblSettings.NewRow();
                dataRow["Settings"] = this.CreateXmlConfigSender().InnerXml;
                dataRow["Module"] = "FTP05";
                this.tblSettings.Rows.Add(dataRow);
            }
            this.tblSettings.Rows[0]["Settings"] = this.CreateXmlConfigSender().InnerXml;
            this.tblSettings.Rows[0].EndEdit();
            if (!base.InsertSqlData(this.tblSettings))
            {
                e.Cancel = true;
                return;
            }
            if (!base.UpdateSqlData(this.tblSettings))
            {
                e.Cancel = true;
                return;
            }
        }
        //Останавливаем таймер
        timerServiceRun.Stop();
        //Снова делаем таймер недоступным
        timerServiceRun.Enabled = false;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        base.Close();
    }
    /// <summary>
    /// Сохранить конфигурационные данные
    /// </summary>
    /// <returns></returns>
    private XmlDocument CreateXmlConfigSender()
    {
        XmlDocument xmlDocument = new XmlDocument();
        XmlNode xmlNode = xmlDocument.CreateElement("ReqForRepairFTP");
        xmlDocument.AppendChild(xmlNode);
        #region  Аварийные работы 
        XmlNode xmlNode2 = xmlDocument.CreateElement("FTP05");
        xmlNode.AppendChild(xmlNode2);
        XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("UseFTP");
        xmlAttribute.Value = this.chbUseFTP05.Checked.ToString();
        xmlNode2.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("FileName");
        xmlAttribute.Value = this.txtFTP05_FileName.Text;
        xmlNode2.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("PathName");
        xmlAttribute.Value = this.txtFTP05_PathName.Text;
        xmlNode2.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("FTPName");
        xmlAttribute.Value = this.txtFTP05_NameFTP.Text;
        xmlNode2.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("User");
        xmlAttribute.Value = this.txtFTP05_FTPUser.Text;
        xmlNode2.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Pwd");
        xmlAttribute.Value = this.txtFTP05_FTPPwd.Text;
        xmlNode2.Attributes.Append(xmlAttribute);
        if (this.chbFTP05_Proxy.Checked)
        {
            xmlAttribute = xmlDocument.CreateAttribute("Proxy");
            xmlAttribute.Value = this.txtFTP05_Proxy.Text;
            xmlNode2.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("ProxyUser");
            xmlAttribute.Value = this.txtFTP05_ProxyUser.Text;
            xmlNode2.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("ProxyPwd");
            xmlAttribute.Value = this.txtFTP05_ProxyPwd.Text;
            xmlNode2.Attributes.Append(xmlAttribute);
        }
        XmlNode xmlNode3 = xmlDocument.CreateElement("Shedule");
        xmlNode2.AppendChild(xmlNode3);
        xmlAttribute = xmlDocument.CreateAttribute("Start");
        xmlAttribute.Value = this.dtpFTP05_start.Value.ToString("dd.MM.yyyy HH:mm");
        xmlNode3.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Period");
        if (this.rbFTP05_hours.Checked)
        {
            xmlAttribute.Value = (this.numFTP05_hours.Value * 60m).ToString();
        }
        if (this.rbFTP05_days.Checked)
        {
            xmlAttribute.Value = (this.numFTP05_days.Value * 24m * 60m).ToString();
        }
        if (this.rbFTP05_weeks.Checked)
        {
            xmlAttribute.Value = (this.numFTP05_weeks.Value * 24m * 60m * 7m).ToString();
        }
        xmlNode3.Attributes.Append(xmlAttribute);
#endregion
        #region  Плановые работы 
        XmlNode xmlNodeFTP = xmlDocument.CreateElement("FTP");
        xmlNode.AppendChild(xmlNodeFTP);

        xmlAttribute = xmlDocument.CreateAttribute("UseFTP");
        xmlAttribute.Value = this.chbUseFTP.Checked.ToString();
        xmlNodeFTP.Attributes.Append(xmlAttribute);

        xmlAttribute = xmlDocument.CreateAttribute("FileName");
        xmlAttribute.Value = this.txtFTP_FileName.Text;
        xmlNodeFTP.Attributes.Append(xmlAttribute);

        xmlAttribute = xmlDocument.CreateAttribute("FileNameSESNO");
        xmlAttribute.Value = this.txtFTP_FileNameSESNO.Text;
        xmlNodeFTP.Attributes.Append(xmlAttribute);

        xmlAttribute = xmlDocument.CreateAttribute("PathName");
        xmlAttribute.Value = this.txtFTP_PathName.Text;
        xmlNodeFTP.Attributes.Append(xmlAttribute);

        xmlAttribute = xmlDocument.CreateAttribute("FTPName");
        xmlAttribute.Value = this.txtFTP_NameFTP.Text;
        xmlNodeFTP.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("User");
        xmlAttribute.Value = this.txtFTP_FTPUser.Text;
        xmlNodeFTP.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Pwd");
        xmlAttribute.Value = this.txtFTP_FTPPwd.Text;
        xmlNodeFTP.Attributes.Append(xmlAttribute);
        if (this.chbFTP_Proxy.Checked)
        {
            xmlAttribute = xmlDocument.CreateAttribute("Proxy");
            xmlAttribute.Value = this.txtFTP_Proxy.Text;
            xmlNodeFTP.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("ProxyUser");
            xmlAttribute.Value = this.txtFTP_ProxyUser.Text;
            xmlNodeFTP.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("ProxyPwd");
            xmlAttribute.Value = this.txtFTP_ProxyPwd.Text;
            xmlNodeFTP.Attributes.Append(xmlAttribute);
        }
        XmlNode xmlNode5 = xmlDocument.CreateElement("Shedule");
        xmlNodeFTP.AppendChild(xmlNode5);
        xmlAttribute = xmlDocument.CreateAttribute("Start");
        xmlAttribute.Value = this.dtpFTP_start.Value.ToString("dd.MM.yyyy HH:mm");
        xmlNode5.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Period");
        if (this.rbFTP_hours.Checked)
        {
            xmlAttribute.Value = (this.numFTP_hours.Value * 60m).ToString();
        }
        if (this.rbFTP_days.Checked)
        {
            xmlAttribute.Value = (this.numFTP_days.Value * 24m * 60m).ToString();
        }
        if (this.rbFTP_weeks.Checked)
        {
            xmlAttribute.Value = (this.numFTP_weeks.Value * 24m * 60m * 7m).ToString();
        }
        xmlNode5.Attributes.Append(xmlAttribute);
#endregion
        #region  Плановая почта 
        XmlNode xmlNode6 = xmlDocument.CreateElement("MailPlanned");
        xmlNode.AppendChild(xmlNode6);
        xmlAttribute = xmlDocument.CreateAttribute("useMail");
        xmlAttribute.Value = this.chkUseMailPlanned.Checked.ToString();
        xmlNode6.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("FileName");
        xmlAttribute.Value = this.txtFileNameReportHead.Text;
        xmlNode6.Attributes.Append(xmlAttribute);

        XmlNode xmlNode7 = xmlDocument.CreateElement("SMTP");
        xmlNode6.AppendChild(xmlNode7);
        xmlAttribute = xmlDocument.CreateAttribute("Name");
        xmlAttribute.Value = this.txtSMTPServerPlanned.Text;
        xmlNode7.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Port");
        xmlAttribute.Value = this.txtSMTPServerPortPlanned.Value.ToString();
        xmlNode7.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Login");
        xmlAttribute.Value = this.txtLoginSMTPPlanned.Text;
        xmlNode7.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Pwd");
        xmlAttribute.Value = this.txtPwdSMTPPlanned.Text;
        xmlNode7.Attributes.Append(xmlAttribute);

        XmlNode xmlNode8 = xmlDocument.CreateElement("Sender");
        xmlNode6.AppendChild(xmlNode8);
        xmlAttribute = xmlDocument.CreateAttribute("Address");
        xmlAttribute.Value = this.txtSenderAddressPlanned.Text;
        xmlNode8.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Name");
        xmlAttribute.Value = this.txtSenderNamePlanned.Text;
        xmlNode8.Attributes.Append(xmlAttribute);
        XmlNode xmlNode9 = xmlDocument.CreateElement("Recipients");
        xmlNode6.AppendChild(xmlNode9);
        for (int i = 0; i < this.dgvRecipients.Rows.Count - 1; i++)
        {
            XmlNode xmlNode10 = xmlDocument.CreateElement("Recipient");
            xmlNode9.AppendChild(xmlNode10);
            xmlAttribute = xmlDocument.CreateAttribute("Address");
            xmlAttribute.Value = this.dgvRecipients.Rows[i].Cells[this.addressRecipientDgvColumn.Name].Value.ToString();
            xmlNode10.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("Name");
            xmlAttribute.Value = this.dgvRecipients.Rows[i].Cells[this.nameRecipientDgvColumn.Name].Value.ToString();
            xmlNode10.Attributes.Append(xmlAttribute);
        }
        xmlAttribute = xmlDocument.CreateAttribute("Subject");
        xmlAttribute.Value = this.txtSubjectPlanned.Text;
        xmlNode6.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Body");
        xmlAttribute.Value = this.txtBodyPlanned.Text;
        xmlNode6.Attributes.Append(xmlAttribute);
        XmlNode xmlNode11 = xmlDocument.CreateElement("Shedule");
        xmlNode6.AppendChild(xmlNode11);
        xmlAttribute = xmlDocument.CreateAttribute("Start");
        xmlAttribute.Value = this.dtpMailPlanned_start.Value.ToString("dd.MM.yyyy HH:mm");
        xmlNode11.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Period");
        if (this.rbMailPlanned_hours.Checked)
        {
            xmlAttribute.Value = (this.numMailPlanned_hours.Value * 60m).ToString();
        }
        if (this.rbMailPlanned_days.Checked)
        {
            xmlAttribute.Value = (this.numMailPlanned_days.Value * 24m * 60m).ToString();
        }
        if (this.rbMailPlanned_weeks.Checked)
        {
            xmlAttribute.Value = (this.numMailPlanned_weeks.Value * 24m * 60m * 7m).ToString();
        }
        xmlNode11.Attributes.Append(xmlAttribute);
#endregion
        #region CURL
        XmlNode xmlNode12 = xmlDocument.CreateElement("PathCURL");
        xmlNode12.InnerText = this.txtCURL.Text;
        xmlNode.AppendChild(xmlNode12);
        #endregion
        #region RIC
        XmlNode xmlNodeRIC = xmlDocument.CreateElement("RIC");
        xmlNode.AppendChild(xmlNodeRIC);
        xmlAttribute = xmlDocument.CreateAttribute("SendRIC");
        xmlAttribute.Value = this.checkBoxSendRIC.Checked.ToString();
        xmlNodeRIC.Attributes.Append(xmlAttribute);
        #endregion 
        #region  Минэнерго
        XmlNode xmlNodeME = xmlDocument.CreateElement("MinEnergo");
        xmlNode.AppendChild(xmlNodeME);
        xmlAttribute = xmlDocument.CreateAttribute("SendME");
        xmlAttribute.Value = this.checkBoxSendME.Checked.ToString();
        xmlNodeME.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("URL");
        xmlAttribute.Value = this.txtNameURL.Text;
        xmlNodeME.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Login");
        xmlAttribute.Value = this.txtUserME.Text;
        xmlNodeME.Attributes.Append(xmlAttribute);

        xmlAttribute = xmlDocument.CreateAttribute("Pwd");
        // xmlAttribute.Value = SecureIt.Зашифровать(this.txtPwdME.Text);
        xmlAttribute.Value = this.txtPwdME.Text;
        xmlNodeME.Attributes.Append(xmlAttribute);

        xmlAttribute = xmlDocument.CreateAttribute("CreateAktDHV");
        xmlAttribute.Value = this.chkCreateAktDHV.Checked.ToString();
        xmlNodeME.Attributes.Append(xmlAttribute);

        xmlAttribute = xmlDocument.CreateAttribute("CreateAktDLV");
        xmlAttribute.Value = this.chkCreateAktDLV.Checked.ToString();
        xmlNodeME.Attributes.Append(xmlAttribute);

        xmlAttribute = xmlDocument.CreateAttribute("SendNullListAbonent");
        xmlAttribute.Value = this.chkSendNullListAbonent.Checked.ToString();
        xmlNodeME.Attributes.Append(xmlAttribute);

        xmlAttribute = xmlDocument.CreateAttribute("SendCorrectDamage");
        xmlAttribute.Value = this.chkSendCorrectDamage.Checked.ToString();
        xmlNodeME.Attributes.Append(xmlAttribute);
#endregion
        #region  Отчет руководителю 
        XmlNode xmlNodeHead = xmlDocument.CreateElement("MailHead");
        xmlNode.AppendChild(xmlNodeHead);
        xmlAttribute = xmlDocument.CreateAttribute("useMail");
        xmlAttribute.Value = this.chkSendReportHead.Checked.ToString();
        xmlNodeHead.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("FileName");
        xmlAttribute.Value = this.txtFileNameMailReportHead.Text;
        xmlNodeHead.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("OutFormatFile");
        xmlAttribute.Value = this.cmbOutFormatFile.SelectedItem.ToString();
        xmlNodeHead.Attributes.Append(xmlAttribute);



        XmlNode xmlNodeSMTP = xmlDocument.CreateElement("SMTP");
        xmlNodeHead.AppendChild(xmlNodeSMTP);
        xmlAttribute = xmlDocument.CreateAttribute("Name");
        xmlAttribute.Value = this.txtSMTPServer.Text;
        xmlNodeSMTP.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Port");
        xmlAttribute.Value = this.txtSMTPServerPort.Value.ToString();
        xmlNodeSMTP.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Login");
        xmlAttribute.Value = this.txtLoginSMTP.Text;
        xmlNodeSMTP.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Pwd");
        xmlAttribute.Value = this.txtPwdSMTP.Text;
        xmlNodeSMTP.Attributes.Append(xmlAttribute);

        XmlNode xmlNodeSender = xmlDocument.CreateElement("Sender");
        xmlNodeHead.AppendChild(xmlNodeSender);
        xmlAttribute = xmlDocument.CreateAttribute("Address");
        xmlAttribute.Value = this.txtSenderAddress.Text;
        xmlNodeSender.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Name");
        xmlAttribute.Value = this.txtSenderName.Text;
        xmlNodeSender.Attributes.Append(xmlAttribute);
        XmlNode xmlNodeRs = xmlDocument.CreateElement("Recipients");
        xmlNodeHead.AppendChild(xmlNodeRs);
        for (int i = 0; i < this.dgvRecipientsHead.Rows.Count - 1; i++)
        {
            XmlNode xmlNodeR = xmlDocument.CreateElement("Recipient");
            xmlNodeRs.AppendChild(xmlNodeR);
            xmlAttribute = xmlDocument.CreateAttribute("Address");
            xmlAttribute.Value = this.dgvRecipientsHead.Rows[i].Cells[this.addressDgvColumn.Name].Value.ToString();
            xmlNodeR.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("Name");
            xmlAttribute.Value = this.dgvRecipientsHead.Rows[i].Cells[this.nameDgvColumn.Name].Value.ToString();
            xmlNodeR.Attributes.Append(xmlAttribute);
        }
        xmlAttribute = xmlDocument.CreateAttribute("Subject");
        xmlAttribute.Value = this.txtSubject.Text;
        xmlNodeHead.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("Body");
        xmlAttribute.Value = this.txtBody.Text;
        xmlNodeHead.Attributes.Append(xmlAttribute);
        XmlNode xmlNodeShedule = xmlDocument.CreateElement("Shedule");
        xmlNodeHead.AppendChild(xmlNodeShedule);
        xmlAttribute = xmlDocument.CreateAttribute("Start");
        xmlAttribute.Value = this.dtpBeginMail.Value.ToString("dd.MM.yyyy HH:mm");
        xmlNodeShedule.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("PeriodToBeginDay");
        xmlAttribute.Value = this.txtPeriodToBeginDay.Text;
        xmlNodeShedule.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("TimeBegin");
        xmlAttribute.Value = this.dtpTimeBegin.Value.ToString("HH:mm");
        xmlNodeShedule.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("TimeEnd");
        xmlAttribute.Value = this.dtpTimeEnd.Value.ToString("HH:mm");
        xmlNodeShedule.Attributes.Append(xmlAttribute);

        xmlAttribute = xmlDocument.CreateAttribute("Period");
        if (this.rbMail_hours.Checked)
        {
            xmlAttribute.Value = (this.numMail_hours.Value * 60m).ToString();
        }
        if (this.rbMail_days.Checked)
        {
            xmlAttribute.Value = (this.numMail_day.Value * 24m * 60m).ToString();
        }
        if (this.rbMail_weeks.Checked)
        {
            xmlAttribute.Value = (this.numMail_weeks.Value * 24m * 60m * 7m).ToString();
        }
        xmlNodeShedule.Attributes.Append(xmlAttribute);
        #endregion
        #region Ульяновскэнерго
        XmlNode xmlNodePlannedUE = xmlDocument.CreateElement("MailPlannedUE");
        xmlNode.AppendChild(xmlNodePlannedUE);
        xmlAttribute = xmlDocument.CreateAttribute("useMailUE");
        xmlAttribute.Value = this.chkUseMailPlannedUE.Checked.ToString();
        xmlNodePlannedUE.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("FileNameUE");
        xmlAttribute.Value = this.txtFileNameReportPlannedUE.Text;
        xmlNodePlannedUE.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("OutFormatFileUE");
        xmlAttribute.Value = this.cmbOutFormatFileUE.SelectedItem.ToString();
        xmlNodePlannedUE.Attributes.Append(xmlAttribute);

        XmlNode xmlNodeSMTPUE = xmlDocument.CreateElement("SMTPUE");
        xmlNodePlannedUE.AppendChild(xmlNodeSMTPUE);
        xmlAttribute = xmlDocument.CreateAttribute("NameUE");
        xmlAttribute.Value = this.txtSMTPServerPlannedUE.Text;
        xmlNodeSMTPUE.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("PortUE");
        xmlAttribute.Value = this.txtSMTPServerPortPlannedUE.Value.ToString();
        xmlNodeSMTPUE.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("LoginUE");
        xmlAttribute.Value = this.txtLoginSMTPPlannedUE.Text;
        xmlNodeSMTPUE.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("PwdUE");
        xmlAttribute.Value = this.txtPwdSMTPPlannedUE.Text;
        xmlNodeSMTPUE.Attributes.Append(xmlAttribute);

        XmlNode xmlNodeSenderUE = xmlDocument.CreateElement("SenderUE");
        xmlNodePlannedUE.AppendChild(xmlNodeSenderUE);
        xmlAttribute = xmlDocument.CreateAttribute("AddressUE");
        xmlAttribute.Value = this.txtSenderAddressPlannedUE.Text;
        xmlNodeSenderUE.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("NameUE");
        xmlAttribute.Value = this.txtSenderNamePlannedUE.Text;
        xmlNodeSenderUE.Attributes.Append(xmlAttribute);
        XmlNode xmlNodeRecipientsUE = xmlDocument.CreateElement("RecipientsUE");
        xmlNodePlannedUE.AppendChild(xmlNodeRecipientsUE);
        for (int i = 0; i < this.dgvRecipientsUE.Rows.Count - 1; i++)
        {
            XmlNode xmlNode10 = xmlDocument.CreateElement("RecipientUE");
            xmlNodeRecipientsUE.AppendChild(xmlNode10);
            xmlAttribute = xmlDocument.CreateAttribute("AddressUE");
            xmlAttribute.Value = this.dgvRecipientsUE.Rows[i].Cells[this.addressRecipientDgvUEColumn.Name].Value.ToString();
            xmlNode10.Attributes.Append(xmlAttribute);
            xmlAttribute = xmlDocument.CreateAttribute("NameUE");
            xmlAttribute.Value = this.dgvRecipientsUE.Rows[i].Cells[this.nameRecipientDgvUEColumn.Name].Value.ToString();
            xmlNode10.Attributes.Append(xmlAttribute);
        }
        xmlAttribute = xmlDocument.CreateAttribute("SubjectUE");
        xmlAttribute.Value = this.txtSubjectPlannedUE.Text;
        xmlNodePlannedUE.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("BodyUE");
        xmlAttribute.Value = this.txtBodyPlannedUE.Text;
        xmlNodePlannedUE.Attributes.Append(xmlAttribute);
        XmlNode xmlNodeSheduleUE = xmlDocument.CreateElement("SheduleUE");
        xmlNodePlannedUE.AppendChild(xmlNodeSheduleUE);

        xmlAttribute = xmlDocument.CreateAttribute("StartUE");
        xmlAttribute.Value = this.dtpMailPlanned_startUE.Value.ToString("dd.MM.yyyy HH:mm");
        xmlNodeSheduleUE.Attributes.Append(xmlAttribute);

        xmlAttribute = xmlDocument.CreateAttribute("IntervalUE");
        xmlAttribute.Value = this.txtIntervalUE.Text;
        xmlNodeSheduleUE.Attributes.Append(xmlAttribute);

        xmlAttribute = xmlDocument.CreateAttribute("PeriodUE");
        if (this.rbMailPlanned_hoursUE.Checked)
        {
            xmlAttribute.Value = (this.numMailPlanned_hoursUE.Value * 60m).ToString();
        }
        if (this.rbMailPlanned_daysUE.Checked)
        {
            xmlAttribute.Value = (this.numMailPlanned_daysUE.Value * 24m * 60m).ToString();
        }
        if (this.rbMailPlanned_weeksUE.Checked)
        {
            xmlAttribute.Value = (this.numMailPlanned_weeksUE.Value * 24m * 60m * 7m).ToString();
        }
        xmlNodeSheduleUE.Attributes.Append(xmlAttribute);
        #endregion
        return xmlDocument;
    }
    /// <summary>
    /// Загрузить конфигурация
    /// </summary>
    private void ApplyConfigSender()
    {
        if (this.tblSettings.Rows.Count > 0 && this.tblSettings.Rows[0]["Settings"] != DBNull.Value)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(this.tblSettings.Rows[0]["Settings"].ToString());
            XmlNode xmlNodeForRepair = xmlDocument.SelectSingleNode("ReqForRepairFTP");
            if (xmlNodeForRepair != null)
            {
                XmlNode xmlNode = xmlNodeForRepair.SelectSingleNode("FTP05");
                if (xmlNode != null)
                {
                    XmlAttribute xmlAttribute = xmlNode.Attributes["UseFTP"];
                    if (xmlAttribute != null)
                    {
                        this.chbUseFTP05.Checked = Convert.ToBoolean(xmlAttribute.Value);
                    }
                    else
                    {
                        this.chbUseFTP05.Checked = false;
                    }
                    xmlAttribute = xmlNode.Attributes["FileName"];
                    if (xmlAttribute != null)
                    {
                        this.txtFTP05_FileName.Text = xmlAttribute.Value;
                    }
                    xmlAttribute = xmlNode.Attributes["PathName"];
                    if (xmlAttribute != null)
                    {
                        this.txtFTP05_PathName.Text = xmlAttribute.Value;
                    }
                    xmlAttribute = xmlNode.Attributes["FTPName"];
                    if (xmlAttribute != null)
                    {
                        this.txtFTP05_NameFTP.Text = xmlAttribute.Value;
                    }
                    xmlAttribute = xmlNode.Attributes["User"];
                    if (xmlAttribute != null)
                    {
                        this.txtFTP05_FTPUser.Text = xmlAttribute.Value;
                    }
                    xmlAttribute = xmlNode.Attributes["Pwd"];
                    if (xmlAttribute != null)
                    {
                        this.txtFTP05_FTPPwd.Text = xmlAttribute.Value;
                    }
                    xmlAttribute = xmlNode.Attributes["Proxy"];
                    if (xmlAttribute != null)
                    {
                        this.chbFTP05_Proxy.Checked = true;
                        this.txtFTP05_Proxy.Text = xmlAttribute.Value;
                        xmlAttribute = xmlNode.Attributes["ProxyUser"];
                        if (xmlAttribute != null)
                        {
                            this.txtFTP05_ProxyUser.Text = xmlAttribute.Value;
                        }
                        xmlAttribute = xmlNode.Attributes["ProxyPwd"];
                        if (xmlAttribute != null)
                        {
                            this.txtFTP05_ProxyPwd.Text = xmlAttribute.Value;
                        }
                    }
                    XmlNode xmlNode3 = xmlNode.SelectSingleNode("Shedule");
                    if (xmlNode3 != null)
                    {
                        xmlAttribute = xmlNode3.Attributes["Start"];
                        if (xmlAttribute != null)
                        {
                            this.dtpFTP05_start.Value = Convert.ToDateTime(xmlAttribute.Value);
                        }
                        xmlAttribute = xmlNode3.Attributes["Period"];
                        if (xmlAttribute != null)
                        {
                            int Period = Convert.ToInt32(xmlAttribute.Value);
                            if (Period == 0)
                            {
                                this.rbFTP05_hours.Checked = true;
                                this.numFTP05_hours.Value = 0m;
                            }
                            if (Period % 10080 == 0)
                            {
                                this.rbFTP05_weeks.Checked = true;
                                this.numFTP05_weeks.Value = Period / 10080;
                            }
                            else if (Period % 1440 == 0)
                            {
                                this.rbFTP05_days.Checked = true;
                                this.numFTP05_days.Value = Period / 1440;
                            }
                            else
                            {
                                this.rbFTP05_hours.Checked = true;
                                this.numFTP05_hours.Value = Period / 60;
                            }
                        }
                    }
                }
                XmlNode xmlNodeFTP = xmlNodeForRepair.SelectSingleNode("FTP");
                if (xmlNodeFTP != null)
                {
                    XmlAttribute xmlAttribute2 = xmlNodeFTP.Attributes["UseFTP"];
                    if (xmlAttribute2 != null)
                    {
                        this.chbUseFTP.Checked = Convert.ToBoolean(xmlAttribute2.Value);
                    }
                    else
                    {
                        this.chbUseFTP.Checked = false;
                    }
                    xmlAttribute2 = xmlNodeFTP.Attributes["FileName"];
                    if (xmlAttribute2 != null)
                    {
                        this.txtFTP_FileName.Text = xmlAttribute2.Value;
                    }
                    xmlAttribute2 = xmlNodeFTP.Attributes["FileNameSESNO"];
                    if (xmlAttribute2 != null)
                    {
                        this.txtFTP_FileNameSESNO.Text = xmlAttribute2.Value;
                    }
                    xmlAttribute2 = xmlNodeFTP.Attributes["PathName"];
                    if (xmlAttribute2 != null)
                    {
                        this.txtFTP_PathName.Text = xmlAttribute2.Value;
                    }
                    xmlAttribute2 = xmlNodeFTP.Attributes["FTPName"];
                    if (xmlAttribute2 != null)
                    {
                        this.txtFTP_NameFTP.Text = xmlAttribute2.Value;
                    }
                    xmlAttribute2 = xmlNodeFTP.Attributes["User"];
                    if (xmlAttribute2 != null)
                    {
                        this.txtFTP_FTPUser.Text = xmlAttribute2.Value;
                    }
                    xmlAttribute2 = xmlNodeFTP.Attributes["Pwd"];
                    if (xmlAttribute2 != null)
                    {
                        this.txtFTP_FTPPwd.Text = xmlAttribute2.Value;
                    }
                    xmlAttribute2 = xmlNodeFTP.Attributes["Proxy"];
                    if (xmlAttribute2 != null)
                    {
                        this.chbFTP_Proxy.Checked = true;
                        this.txtFTP_Proxy.Text = xmlAttribute2.Value;
                        xmlAttribute2 = xmlNodeFTP.Attributes["ProxyUser"];
                        if (xmlAttribute2 != null)
                        {
                            this.txtFTP_ProxyUser.Text = xmlAttribute2.Value;
                        }
                        xmlAttribute2 = xmlNodeFTP.Attributes["ProxyPwd"];
                        if (xmlAttribute2 != null)
                        {
                            this.txtFTP_ProxyPwd.Text = xmlAttribute2.Value;
                        }
                    }
                    XmlNode xmlNode5 = xmlNodeFTP.SelectSingleNode("Shedule");
                    if (xmlNode5 != null)
                    {
                        xmlAttribute2 = xmlNode5.Attributes["Start"];
                        if (xmlAttribute2 != null)
                        {
                            this.dtpFTP_start.Value = Convert.ToDateTime(xmlAttribute2.Value);
                        }
                        xmlAttribute2 = xmlNode5.Attributes["Period"];
                        if (xmlAttribute2 != null)
                        {
                            int Period = Convert.ToInt32(xmlAttribute2.Value);
                            if (Period == 0)
                            {
                                this.rbFTP_hours.Checked = true;
                                this.numFTP_hours.Value = 0m;
                            }
                            if (Period % 10080 == 0)
                            {
                                this.rbFTP_weeks.Checked = true;
                                this.numFTP_weeks.Value = Period / 10080;
                            }
                            else if (Period % 1440 == 0)
                            {
                                this.rbFTP_days.Checked = true;
                                this.numFTP_days.Value = Period / 1440;
                            }
                            else
                            {
                                this.rbFTP_hours.Checked = true;
                                this.numFTP_hours.Value = Period / 60;
                            }
                        }
                    }
                }
                XmlNode xmlNodeMail = xmlNodeForRepair.SelectSingleNode("MailPlanned");
                if (xmlNodeMail != null)
                {
                    XmlAttribute xmlAttribute3 = xmlNodeMail.Attributes["FileName"];
                    if (xmlAttribute3 != null)
                    {
                        this.txtFileNameReportHead.Text = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNodeMail.Attributes["Subject"];
                    if (xmlAttribute3 != null)
                    {
                        this.txtSubjectPlanned.Text = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNodeMail.Attributes["Body"];
                    if (xmlAttribute3 != null)
                    {
                        this.txtBodyPlanned.Text = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNodeMail.Attributes["useMail"];
                    if (xmlAttribute3 != null)
                    {
                        this.chkUseMailPlanned.Checked = Convert.ToBoolean(xmlAttribute3.Value);
                    }
                    else
                    {
                        this.chkUseMailPlanned.Checked = false;
                    }
                    XmlNode xmlNode7 = xmlNodeMail.SelectSingleNode("SMTP");
                    if (xmlNode7 != null)
                    {
                        xmlAttribute3 = xmlNode7.Attributes["Name"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtSMTPServerPlanned.Text = xmlAttribute3.Value;
                        }
                        xmlAttribute3 = xmlNode7.Attributes["Port"];
                        if (xmlAttribute3 != null && !string.IsNullOrEmpty(xmlAttribute3.Value))
                        {
                            this.txtSMTPServerPortPlanned.Value = Convert.ToInt32(xmlAttribute3.Value);
                        }
                        xmlAttribute3 = xmlNode7.Attributes["Login"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtLoginSMTPPlanned.Text = xmlAttribute3.Value;
                        }
                        xmlAttribute3 = xmlNode7.Attributes["Pwd"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtPwdSMTPPlanned.Text = xmlAttribute3.Value;
                        }
                    }
                    XmlNode xmlNode8 = xmlNodeMail.SelectSingleNode("Sender");
                    if (xmlNode8 != null)
                    {
                        xmlAttribute3 = xmlNode8.Attributes["Address"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtSenderAddressPlanned.Text = xmlAttribute3.Value;
                        }
                        xmlAttribute3 = xmlNode8.Attributes["Name"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtSenderNamePlanned.Text = xmlAttribute3.Value;
                        }
                    }
                    this.dgvRecipients.Rows.Clear();
                    XmlNode xmlNodeRs = xmlNodeMail.SelectSingleNode("Recipients");
                    if (xmlNodeRs != null)
                    {
                        foreach (XmlNode xmlNodeR in xmlNodeRs.SelectNodes("Recipient"))
                        {

                            string Address = "";
                            string name = "";
                            xmlAttribute3 = xmlNodeR.Attributes["Address"];
                            if (xmlAttribute3 != null)
                            {
                                Address = xmlAttribute3.Value;
                            }
                            xmlAttribute3 = xmlNodeR.Attributes["Name"];
                            if (xmlAttribute3 != null)
                            {
                                name = xmlAttribute3.Value;
                            }
                            this.dgvRecipients.Rows.Add(new object[]
                            {
                                    Address,
                                    name
                            });
                        }
                    }
                    XmlNode xmlNode11 = xmlNodeMail.SelectSingleNode("Shedule");
                    if (xmlNode11 != null)
                    {
                        xmlAttribute3 = xmlNode11.Attributes["Start"];
                        if (xmlAttribute3 != null)
                        {
                            this.dtpMailPlanned_start.Value = Convert.ToDateTime(xmlAttribute3.Value);
                        }
                        xmlAttribute3 = xmlNode11.Attributes["Period"];
                        if (xmlAttribute3 != null)
                        {
                            int Period = Convert.ToInt32(xmlAttribute3.Value);
                            if (Period == 0)
                            {
                                this.rbMailPlanned_hours.Checked = true;
                                this.numMailPlanned_hours.Value = 0m;
                            }
                            if (Period % 10080 == 0)
                            {
                                this.rbMailPlanned_weeks.Checked = true;
                                this.numMailPlanned_weeks.Value = Period / 10080;
                            }
                            else if (Period % 1440 == 0)
                            {
                                this.rbMailPlanned_days.Checked = true;
                                this.numMailPlanned_days.Value = Period / 1440;
                            }
                            else
                            {
                                this.rbMailPlanned_hours.Checked = true;
                                this.numMailPlanned_hours.Value = Period / 60;
                            }
                        }
                    }
                }
                xmlNode = xmlNodeForRepair.SelectSingleNode("PathCURL");
                if (xmlNode != null && !string.IsNullOrEmpty(xmlNode.InnerText))
                {
                    this.txtCURL.Text = xmlNode.InnerText;
                }
                XmlNode xmlNode1RIC = xmlNodeForRepair.SelectSingleNode("RIC");
                if (xmlNode1RIC != null)
                {
                    XmlAttribute xmlAttribute4 = xmlNode1RIC.Attributes["SendRIC"];
                    if (xmlAttribute4 != null)
                    {
                        this.checkBoxSendRIC.Checked = Convert.ToBoolean(xmlAttribute4.Value);
                    }
                }
                XmlNode xmlNodeME = xmlNodeForRepair.SelectSingleNode("MinEnergo");
                if (xmlNodeME != null)
                {
                    XmlAttribute xmlAttributeME = xmlNodeME.Attributes["SendME"];
                    if (xmlAttributeME != null)  this.checkBoxSendME.Checked = Convert.ToBoolean(xmlAttributeME.Value);
                    xmlAttributeME = xmlNodeME.Attributes["URL"];
                    if (xmlAttributeME != null) this.txtNameURL.Text = xmlAttributeME.Value;
                    xmlAttributeME = xmlNodeME.Attributes["Login"];
                    if (xmlAttributeME != null) this.txtUserME.Text = xmlAttributeME.Value;

                    // if (xmlAttributeME != null) this.txtPwdME.Text = SecureIt.Расшифровать(xmlNodeME.Attributes["Pwd"].Value.ToString());
                    if (xmlAttributeME != null) this.txtPwdME.Text = xmlNodeME.Attributes["Pwd"].Value.ToString();

                    xmlAttributeME = xmlNodeME.Attributes["CreateAktDHV"];
                    if (xmlAttributeME != null) this.chkCreateAktDHV.Checked = Convert.ToBoolean(xmlAttributeME.Value);
                    xmlAttributeME = xmlNodeME.Attributes["CreateAktDLV"];
                    if (xmlAttributeME != null) this.chkCreateAktDLV.Checked = Convert.ToBoolean(xmlAttributeME.Value);
                    xmlAttributeME = xmlNodeME.Attributes["SendNullListAbonent"];
                    if (xmlAttributeME != null) this.chkSendNullListAbonent.Checked = Convert.ToBoolean(xmlAttributeME.Value);
                   xmlAttributeME = xmlNodeME.Attributes["SendCorrectDamage"];
                    if (xmlAttributeME != null) this.chkSendCorrectDamage.Checked = Convert.ToBoolean(xmlAttributeME.Value);


                }
                XmlNode xmlNodeHead = xmlNodeForRepair.SelectSingleNode("MailHead");
                if (xmlNodeHead != null)
                {
                    XmlAttribute xmlAttribute3 = xmlNodeHead.Attributes["FileName"];
                    if (xmlAttribute3 != null)
                    {
                        this.txtFileNameMailReportHead.Text = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNodeHead.Attributes["OutFormatFile"];
                    if (xmlAttribute3 != null)
                    {
                        this.cmbOutFormatFile.SelectedItem = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNodeHead.Attributes["Subject"];
                    if (xmlAttribute3 != null)
                    {
                        this.txtSubject.Text = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNodeHead.Attributes["Body"];
                    if (xmlAttribute3 != null)
                    {
                        this.txtBody.Text = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNodeHead.Attributes["useMail"];
                    if (xmlAttribute3 != null)
                    {
                        this.chkSendReportHead.Checked = Convert.ToBoolean(xmlAttribute3.Value);
                    }
                    else
                    {
                        this.chkSendReportHead.Checked = false;
                    }
                        XmlNode xmlNodeSMTP = xmlNodeHead.SelectSingleNode("SMTP");
                        if (xmlNodeSMTP != null)
                        {
                        xmlAttribute3 = xmlNodeSMTP.Attributes["Name"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtSMTPServer.Text = xmlAttribute3.Value;
                        }
                        xmlAttribute3 = xmlNodeSMTP.Attributes["Port"];
                        if (xmlAttribute3 != null && !string.IsNullOrEmpty(xmlAttribute3.Value))
                        {
                            this.txtSMTPServerPort.Value = Convert.ToInt32(xmlAttribute3.Value);
                        }
                        xmlAttribute3 = xmlNodeSMTP.Attributes["Login"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtLoginSMTP.Text = xmlAttribute3.Value;
                        }
                        xmlAttribute3 = xmlNodeSMTP.Attributes["Pwd"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtPwdSMTP.Text = xmlAttribute3.Value;
                        }
                    }
                    XmlNode xmlNodeSender = xmlNodeHead.SelectSingleNode("Sender");
                    if (xmlNodeSender != null)
                    {
                        xmlAttribute3 = xmlNodeSender.Attributes["Address"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtSenderAddress.Text = xmlAttribute3.Value;
                        }
                        xmlAttribute3 = xmlNodeSender.Attributes["Name"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtSenderName.Text = xmlAttribute3.Value;
                        }
                    }
                    this.dgvRecipientsHead.Rows.Clear();
                    XmlNode xmlNodeRs = xmlNodeHead.SelectSingleNode("Recipients");
                    if (xmlNodeRs != null)
                    {
                        foreach (XmlNode xmlNodeR in xmlNodeRs.SelectNodes("Recipient"))
                        {

                            string Address = "";
                            string name = "";
                            xmlAttribute3 = xmlNodeR.Attributes["Address"];
                            if (xmlAttribute3 != null)
                            {
                                Address = xmlAttribute3.Value;
                            }
                            xmlAttribute3 = xmlNodeR.Attributes["Name"];
                            if (xmlAttribute3 != null)
                            {
                                name = xmlAttribute3.Value;
                            }
                            this.dgvRecipientsHead.Rows.Add(new object[]
                            {
                                        Address,
                                        name
                            });
                        }
                    }
                    XmlNode xmlNodeShedule = xmlNodeHead.SelectSingleNode("Shedule");
                    if (xmlNodeShedule != null)
                    {
                        xmlAttribute3 = xmlNodeShedule.Attributes["Start"];
                        if (xmlAttribute3 != null)
                        {
                            this.dtpBeginMail.Value = Convert.ToDateTime(xmlAttribute3.Value);
                        }
                        xmlAttribute3 = xmlNodeShedule.Attributes["TimeBegin"];
                        if (xmlAttribute3 != null)
                        {
                            this.dtpTimeBegin.Value = Convert.ToDateTime(xmlAttribute3.Value);
                        }
                        xmlAttribute3 = xmlNodeShedule.Attributes["TimeEnd"];
                        if (xmlAttribute3 != null)
                        {
                            this.dtpTimeEnd.Value = Convert.ToDateTime(xmlAttribute3.Value);
                        }
                        xmlAttribute3 = xmlNodeShedule.Attributes["PeriodToBeginDay"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtPeriodToBeginDay.Text = xmlAttribute3.Value;
                        }

                        xmlAttribute3 = xmlNodeShedule.Attributes["Period"];
                        if (xmlAttribute3 != null)
                        {
                            int Period = Convert.ToInt32(xmlAttribute3.Value);
                            if (Period == 0)
                            {
                                this.rbMail_hours.Checked = true;
                                this.numMail_hours.Value = 0m;
                            }
                            if (Period % 10080 == 0)
                            {
                                this.rbMail_weeks.Checked = true;
                                this.numMail_weeks.Value = Period / 10080;
                            }
                            else if (Period % 1440 == 0)
                            {
                                this.rbMail_days.Checked = true;
                                this.numMail_day.Value = Period / 1440;
                            }
                            else
                            {
                                this.rbMail_hours.Checked = true;
                                this.numMail_hours.Value = Period / 60;
                            }
                        }
                    }
                }
                XmlNode xmlNodeMailPlanned = xmlNodeForRepair.SelectSingleNode("MailPlannedUE");
                if (xmlNodeMailPlanned != null)
                {
                    XmlAttribute xmlAttribute3 = xmlNodeMailPlanned.Attributes["FileNameUE"];
                    if (xmlAttribute3 != null)
                    {
                        this.txtFileNameReportPlannedUE.Text = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNodeMailPlanned.Attributes["OutFormatFileUE"];
                    if (xmlAttribute3 != null)
                    {
                        this.cmbOutFormatFileUE.SelectedItem = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNodeMailPlanned.Attributes["SubjectUE"];
                    if (xmlAttribute3 != null)
                    {
                        this.txtSubjectPlannedUE.Text = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNodeMailPlanned.Attributes["BodyUE"];
                    if (xmlAttribute3 != null)
                    {
                        this.txtBodyPlannedUE.Text = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNodeMailPlanned.Attributes["useMailUE"];
                    if (xmlAttribute3 != null)
                    {
                        this.chkUseMailPlannedUE.Checked = Convert.ToBoolean(xmlAttribute3.Value);
                    }
                    else
                    {
                        this.chkUseMailPlannedUE.Checked = false;
                    }
                    XmlNode xmlNode7 = xmlNodeMailPlanned.SelectSingleNode("SMTPUE");
                    if (xmlNode7 != null)
                    {
                        xmlAttribute3 = xmlNode7.Attributes["NameUE"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtSMTPServerPlannedUE.Text = xmlAttribute3.Value;
                        }
                        xmlAttribute3 = xmlNode7.Attributes["PortUE"];
                        if (xmlAttribute3 != null && !string.IsNullOrEmpty(xmlAttribute3.Value))
                        {
                            this.txtSMTPServerPortPlannedUE.Value = Convert.ToInt32(xmlAttribute3.Value);
                        }
                        xmlAttribute3 = xmlNode7.Attributes["LoginUE"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtLoginSMTPPlannedUE.Text = xmlAttribute3.Value;
                        }
                        xmlAttribute3 = xmlNode7.Attributes["PwdUE"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtPwdSMTPPlannedUE.Text = xmlAttribute3.Value;
                        }
                    }
                    XmlNode xmlNode8 = xmlNodeMailPlanned.SelectSingleNode("SenderUE");
                    if (xmlNode8 != null)
                    {
                        xmlAttribute3 = xmlNode8.Attributes["AddressUE"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtSenderAddressPlannedUE.Text = xmlAttribute3.Value;
                        }
                        xmlAttribute3 = xmlNode8.Attributes["NameUE"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtSenderNamePlannedUE.Text = xmlAttribute3.Value;
                        }
                    }
                    this.dgvRecipientsUE.Rows.Clear();
                    XmlNode xmlNodeRs = xmlNodeMailPlanned.SelectSingleNode("RecipientsUE");
                    if (xmlNodeRs != null)
                    {
                        foreach (XmlNode xmlNodeR in xmlNodeRs.SelectNodes("RecipientUE"))
                        {

                            string Address = "";
                            string name = "";
                            xmlAttribute3 = xmlNodeR.Attributes["AddressUE"];
                            if (xmlAttribute3 != null)
                            {
                                Address = xmlAttribute3.Value;
                            }
                            xmlAttribute3 = xmlNodeR.Attributes["NameUE"];
                            if (xmlAttribute3 != null)
                            {
                                name = xmlAttribute3.Value;
                            }
                            this.dgvRecipientsUE.Rows.Add(new object[]
                            {
                                    Address,
                                    name
                            });
                        }
                    }
                    XmlNode xmlNodeSheduleUE = xmlNodeMailPlanned.SelectSingleNode("SheduleUE");
                    if (xmlNodeSheduleUE != null)
                    {
                        xmlAttribute3 = xmlNodeSheduleUE.Attributes["StartUE"];
                        if (xmlAttribute3 != null)
                        {
                            this.dtpMailPlanned_startUE.Value = Convert.ToDateTime(xmlAttribute3.Value);
                        }
                        xmlAttribute3 = xmlNodeSheduleUE.Attributes["IntervalUE"];
                        if (xmlAttribute3 != null)
                        {
                            this.txtIntervalUE.Text = xmlAttribute3.Value;
                        }
                        xmlAttribute3 = xmlNodeSheduleUE.Attributes["PeriodUE"];
                        if (xmlAttribute3 != null)
                        {
                            int Period = Convert.ToInt32(xmlAttribute3.Value);
                            if (Period == 0)
                            {
                                this.rbMailPlanned_hoursUE.Checked = true;
                                this.numMailPlanned_hoursUE.Value = 0m;
                            }
                            if (Period % 10080 == 0)
                            {
                                this.rbMailPlanned_weeksUE.Checked = true;
                                this.numMailPlanned_weeksUE.Value = Period / 10080;
                            }
                            else if (Period % 1440 == 0)
                            {
                                this.rbMailPlanned_daysUE.Checked = true;
                                this.numMailPlanned_daysUE.Value = Period / 1440;
                            }
                            else
                            {
                                this.rbMailPlanned_hoursUE.Checked = true;
                                this.numMailPlanned_hoursUE.Value = Period / 60;
                            }
                        }
                    }
                }
            }
        }
    }

    private void btnChoiceCURL_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "exe files (*.exe)|*.exe";
        openFileDialog.Multiselect = false;
        openFileDialog.FileName = this.txtCURL.Text;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            this.txtCURL.Text = openFileDialog.FileName;
        }
    }

    private void chbUseFTP05_CheckedChanged(object sender, EventArgs e)
    {
        this.txtFTP05_FTPPwd.Enabled = (this.txtFTP05_FTPUser.Enabled = (this.txtFTP05_FileName.Enabled = (this.txtFTP05_NameFTP.Enabled = (this.txtFTP05_Proxy.Enabled = (this.txtFTP05_ProxyPwd.Enabled = (this.txtFTP05_ProxyUser.Enabled = (this.chbFTP05_Proxy.Enabled = (this.btnFTP05_ChoiceFileName.Enabled = (this.txtFTP05_PathName.Enabled = (this.btnFTP05_ChoicePath.Enabled = (this.groupBoxSheduleFTP05.Enabled = this.chbUseFTP05.Checked)))))))))));
    }

    private void btnFTP05_ChoiceFileName_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "php files (*.php)|*.php";
        saveFileDialog.CheckFileExists = false;
        saveFileDialog.CheckPathExists = false;
        saveFileDialog.FileName = this.txtFTP05_FileName.Text;
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            this.txtFTP05_FileName.Text = Path.GetFileName(saveFileDialog.FileName);
        }
    }

    private void btnFTP05_ChoicePath_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.ShowNewFolderButton = false;
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            this.txtFTP05_PathName.Text = folderBrowserDialog.SelectedPath;
        }
    }

    private void rbFTP05_hours_CheckedChanged(object sender, EventArgs e)
    {
        this.numFTP05_hours.Enabled = this.rbFTP05_hours.Checked;
        this.numFTP05_days.Enabled = this.rbFTP05_days.Checked;
        this.numFTP05_weeks.Enabled = this.rbFTP05_weeks.Checked;
    }

    private void chbFTP05_Proxy_CheckedChanged(object sender, EventArgs e)
    {
        this.txtFTP05_Proxy.Enabled = (this.txtFTP05_ProxyPwd.Enabled = (this.txtFTP05_ProxyUser.Enabled = (this.chbFTP05_Proxy.Checked && this.chbUseFTP05.Checked)));
    }

    private void chbUseFTP_CheckedChanged(object sender, EventArgs e)
    {
        this.txtFTP_FTPPwd.Enabled = (this.txtFTP_FileNameSESNO.Enabled = (this.txtFTP_FTPUser.Enabled = (this.txtFTP_FileName.Enabled = (this.txtFTP_NameFTP.Enabled = (this.txtFTP_Proxy.Enabled = (this.txtFTP_ProxyPwd.Enabled = (this.txtFTP_ProxyUser.Enabled = (this.chbFTP_Proxy.Enabled = (this.btnFTP_ChoiceFileName.Enabled = (this.txtFTP_PathName.Enabled = (this.btnFTP_ChoicePath.Enabled = (this.groupBoxSheduleFTP.Enabled = this.chbUseFTP.Checked))))))))))));
    }

    private void btnFTP_ChoiceFileName_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "php files (*.php)|*.php";
        saveFileDialog.CheckFileExists = false;
        saveFileDialog.CheckPathExists = false;
        saveFileDialog.FileName = this.txtFTP_FileName.Text;
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            this.txtFTP_FileName.Text = Path.GetFileName(saveFileDialog.FileName);
        }
    }

    private void btnFTP_ChoicePath_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.ShowNewFolderButton = false;
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            this.txtFTP_PathName.Text = folderBrowserDialog.SelectedPath;
        }
    }

    private void chbFTP_Proxy_CheckedChanged(object sender, EventArgs e)
    {
        this.txtFTP_Proxy.Enabled = (this.txtFTP_ProxyPwd.Enabled = (this.txtFTP_ProxyUser.Enabled = (this.chbFTP_Proxy.Checked && this.chbUseFTP.Checked)));
    }

    private void rbFTP_hours_CheckedChanged(object sender, EventArgs e)
    {
        this.numFTP_hours.Enabled = this.rbFTP_hours.Checked;
        this.numFTP_days.Enabled = this.rbFTP_days.Checked;
        this.numFTP_weeks.Enabled = this.rbFTP_weeks.Checked;
    }

    private void chkUseMailPlanned_CheckedChanged(object sender, EventArgs e)
    {
        this.txtFileNameReportHead.Enabled = (this.btnChoiseFileMail.Enabled = (this.groupBoxSMTP.Enabled = (this.groupBoxSender.Enabled = (this.dgvRecipients.Enabled = (this.txtSubjectPlanned.Enabled = (this.txtBodyPlanned.Enabled = (this.groupBoxSheduleMailPlanned.Enabled = this.chkUseMailPlanned.Checked)))))));
    }

    private void btnChoiseFileMail_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "xls files (*.xls)|*.xls";
        saveFileDialog.CheckFileExists = false;
        saveFileDialog.OverwritePrompt = false;
        saveFileDialog.CheckPathExists = false;
        saveFileDialog.FileName = this.txtFileNameReportHead.Text;
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            this.txtFileNameReportHead.Text = saveFileDialog.FileName;
        }
    }

    private void rbMailPlanned_hours_CheckedChanged(object sender, EventArgs e)
    {
        this.numMailPlanned_hours.Enabled = this.rbMailPlanned_hours.Checked;
        this.numMailPlanned_days.Enabled = this.rbMailPlanned_days.Checked;
        this.numMailPlanned_weeks.Enabled = this.rbMailPlanned_weeks.Checked;
    }

    private void checkBoxSendME_CheckedChanged(object sender, EventArgs e)
    {
         this.txtNameURL.Enabled = this.checkBoxSendME.Checked;
         this.txtUserME.Enabled = this.checkBoxSendME.Checked;
         this.txtPwdME.Enabled = this.checkBoxSendME.Checked;
         
        this.chkCreateAktDHV.Enabled = this.checkBoxSendME.Checked;
        this.chkCreateAktDLV.Enabled = this.checkBoxSendME.Checked;
        this.chkSendNullListAbonent.Enabled = this.checkBoxSendME.Checked;
        this.chkSendCorrectDamage.Enabled = this.checkBoxSendME.Checked;



    }

    private void btnChoiseReportHead_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "xls files (*.xls)|*.xls";
        saveFileDialog.CheckFileExists = false;
        saveFileDialog.OverwritePrompt = false;
        saveFileDialog.CheckPathExists = false;
        saveFileDialog.FileName = this.txtFileNameMailReportHead.Text;
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            this.txtFileNameMailReportHead.Text = saveFileDialog.FileName;
        }
    }

    private void chkSendReportHead_CheckedChanged(object sender, EventArgs e)
    {
             
        this.txtFileNameMailReportHead.Enabled = (this.btnChoiseReportHead.Enabled = (this.groupBoxSMTPHead.Enabled = (this.groupBoxSenderHead.Enabled = (this.dgvRecipientsHead.Enabled = (this.txtSubject.Enabled = (this.txtBody.Enabled = (this.groupBoxSheduleMail.Enabled = (this.groupBoxCollectionStartingPoint.Enabled = this.chkSendReportHead.Checked))))))));
    }

    private void rbMail_CheckedChanged(object sender, EventArgs e)
    {
        this.numMail_hours.Enabled = this.rbMail_hours.Checked;
        this.numMail_day.Enabled = this.rbMail_days.Checked;
        this.numMail_weeks.Enabled = this.rbMail_weeks.Checked;
    }

    private void txtPeriodToBeginDay_KeyPress(object sender, KeyPressEventArgs e)
    {
        char number = e.KeyChar;
        if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
        {
            e.Handled = true;
        }
    }

    #region Контроль удаленной службы
    string MachineName = "ulges-app";
    string ServiceName = "EIS SchemeService";
    ///// <summary>
    ///// Проверка статуса службы
    ///// </summary>
    public void StatusService(string machineName, string serviceName)
    {
        bool flagStart = false;
        bool flagStop = false;
        bool flagRestart = false;
        string serviceStatus = "";
        ServiceController service = new ServiceController(serviceName, machineName);

        switch (service.Status)
        {
            case ServiceControllerStatus.Running:
                serviceStatus = "Служба запущена";
                flagStart = false;
                flagStop = true;
                flagRestart = true;
                break;
            case ServiceControllerStatus.Stopped:
                serviceStatus = "Служба остановлена";
                flagStart = true;
                flagStop = false;
                flagRestart = false;
                break;
            case ServiceControllerStatus.Paused:
                serviceStatus = "Служба приостановлена";
                flagStart = true;
                flagStop = true;
                flagRestart = true;
                break;
            case ServiceControllerStatus.StartPending:
                serviceStatus = "Служба запускается...";
                break;
            case ServiceControllerStatus.StopPending:
                serviceStatus = "Служба останавливается...";
                break;
            case ServiceControllerStatus.PausePending:
                serviceStatus = "Ожидается приостановка службы...";
                break;
            case ServiceControllerStatus.ContinuePending:
                serviceStatus = "Ожидается возобновление работы службы...";
                break;

            default:
                serviceStatus = "Неизвестное состояние";
                break;
        }

        tsbStart.Enabled = flagStart;
        tsbStop.Enabled = flagStop;
        tsbRestart.Enabled = flagRestart;
        this.serviceStatus.Text = serviceStatus;
    }
    /// <summary>
    /// Запуск службы
    /// </summary>
    /// <param name="machineName"></param>
    /// <param name="serviceName"></param>
    public void StartService(string machineName, string serviceName)
    {
        ServiceController service = new ServiceController(serviceName, machineName);
        // Проверяем не запущена ли служба
        if (service.Status != ServiceControllerStatus.Running)
        {
            // Запускаем службу
            service.Start();
            // В течении минуты ждём статус от службы
            service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(1));
            //MessageBox.Show("Служба была успешно запущена!");
        }
        else
        {
            //MessageBox.Show("Служба уже запущена!");
        }
    }

    /// <summary>
    /// Останавливаем службу
    /// </summary>
    /// <param name="serviceName"></param>
    public void StopService(string machineName, string serviceName)
    {
        ServiceController service = new ServiceController(serviceName, machineName);
        // Если служба не остановлена
        if (service.Status != ServiceControllerStatus.Stopped)
        {
            // Останавливаем службу
            service.Stop();
            service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMinutes(1));
            //MessageBox.Show("Служба была успешно остановлена!");
        }
        else
        {
            //MessageBox.Show("Служба уже остановлена!");
        }
    }

    /// <summary>
    /// Перезапуск службы
    /// </summary>
    /// <param name="serviceName"></param>
    public void RestartService(string machineName, string serviceName)
    {
        ServiceController service = new ServiceController(serviceName, machineName);
        TimeSpan timeout = TimeSpan.FromMinutes(1);
        if (service.Status != ServiceControllerStatus.Stopped)
        {
            //Console.WriteLine("Перезапуск службы. Останавливаем службу...");
            // Останавливаем службу
            service.Stop();
            service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            //Console.WriteLine("Служба была успешно остановлена!");
        }
        if (service.Status != ServiceControllerStatus.Running)
        {
            //Console.WriteLine("Перезапуск службы. Запускаем службу...");
            // Запускаем службу
            service.Start();
            service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            //Console.WriteLine("Служба была успешно запущена!");
        }
    }

    private void btnStartServices_Click(object sender, EventArgs e)
    {
        //
        //string machineName = "ulges-app";
        //var services = ServiceController.GetServices(machineName);
        //var service = services.First(s => s.ServiceName == "EIS SchemeService");
        //service.Stop();

        //service.Start();

        StartService(MachineName, ServiceName);
    }

    private void btnStopServices_Click(object sender, EventArgs e)
    {
        StopService(MachineName, ServiceName);
    }

    private void btnRestartServices_Click(object sender, EventArgs e)
    {
        RestartService(MachineName, ServiceName);
    }
#endregion

    private void timerServiceRun_Tick(object sender, EventArgs e)
    {
        StatusService(MachineName, ServiceName);
    }

    private void btnFTP_ChoiceFileNameSESNO_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "php files (*.php)|*.php";
        saveFileDialog.CheckFileExists = false;
        saveFileDialog.CheckPathExists = false;
        saveFileDialog.FileName = this.txtFTP_FileNameSESNO.Text;
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            this.txtFTP_FileNameSESNO.Text = Path.GetFileName(saveFileDialog.FileName);
        }
    }

    private void btnChoiseFileMailUE_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "xls files (*.xls)|*.xls";
        saveFileDialog.CheckFileExists = false;
        saveFileDialog.OverwritePrompt = false;
        saveFileDialog.CheckPathExists = false;
        saveFileDialog.FileName = this.txtFileNameReportPlannedUE.Text;
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            this.txtFileNameReportPlannedUE.Text = saveFileDialog.FileName;
        }
    }

    private void rbMailPlanned_hoursUE_CheckedChanged(object sender, EventArgs e)
    {
        this.numMailPlanned_hoursUE.Enabled = this.rbMailPlanned_hoursUE.Checked;
        this.numMailPlanned_daysUE.Enabled = this.rbMailPlanned_daysUE.Checked;
        this.numMailPlanned_weeksUE.Enabled = this.rbMailPlanned_weeksUE.Checked;
    }

    private void chkUseMailPlannedUE_CheckedChanged(object sender, EventArgs e)
    {
        this.txtFileNameReportPlannedUE.Enabled =
            (this.btnChoiseFileMailUE.Enabled =
            (this.groupBoxCollectionStartingPointUE.Enabled =
            (this.groupBoxSMTPUE.Enabled =
            (this.groupBoxSenderUE.Enabled = 
            (this.dgvRecipientsUE.Enabled = 
            (this.txtSubjectPlannedUE.Enabled = 
            (this.txtBodyPlannedUE.Enabled = 
            (this.groupBoxSheduleMailPlannedUE.Enabled = this.chkUseMailPlannedUE.Checked))))))));
    }
}

