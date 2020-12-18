using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;
using FormLbr;

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
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private XmlDocument CreateXmlConfigSender()
    {
        XmlDocument xmlDocument = new XmlDocument();
        XmlNode xmlNode = xmlDocument.CreateElement("ReqForRepairFTP");
        xmlDocument.AppendChild(xmlNode);
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
        XmlNode xmlNodeFTP = xmlDocument.CreateElement("FTP");
        xmlNode.AppendChild(xmlNodeFTP);
        xmlAttribute = xmlDocument.CreateAttribute("UseFTP");
        xmlAttribute.Value = this.chbUseFTP.Checked.ToString();
        xmlNodeFTP.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("FileName");
        xmlAttribute.Value = this.txtFTP_FileName.Text;
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
        XmlNode xmlNode6 = xmlDocument.CreateElement("MailPlanned");
        xmlNode.AppendChild(xmlNode6);
        xmlAttribute = xmlDocument.CreateAttribute("useMail");
        xmlAttribute.Value = this.chkUseMailPlanned.Checked.ToString();
        xmlNode6.Attributes.Append(xmlAttribute);
        xmlAttribute = xmlDocument.CreateAttribute("FileName");
        xmlAttribute.Value = this.txtFileNameMailPlanned.Text;
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
        XmlNode xmlNode12 = xmlDocument.CreateElement("PathCURL");
        xmlNode12.InnerText = this.txtCURL.Text;
        xmlNode.AppendChild(xmlNode12);

        XmlNode xmlNode13 = xmlDocument.CreateElement("RIC");
        xmlNode.AppendChild(xmlNode13);
        xmlAttribute = xmlDocument.CreateAttribute("SendRIC");
        xmlAttribute.Value = this.checkBoxSendRIC.Checked.ToString();
        xmlNode13.Attributes.Append(xmlAttribute);

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

        return xmlDocument;
    }

    private void ApplyConfigSender()
    {
        if (this.tblSettings.Rows.Count > 0 && this.tblSettings.Rows[0]["Settings"] != DBNull.Value)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(this.tblSettings.Rows[0]["Settings"].ToString());
            XmlNode xmlNode = xmlDocument.SelectSingleNode("ReqForRepairFTP");
            if (xmlNode != null)
            {
                XmlNode xmlNode2 = xmlNode.SelectSingleNode("FTP05");
                if (xmlNode2 != null)
                {
                    XmlAttribute xmlAttribute = xmlNode2.Attributes["UseFTP"];
                    if (xmlAttribute != null)
                    {
                        this.chbUseFTP05.Checked = Convert.ToBoolean(xmlAttribute.Value);
                    }
                    else
                    {
                        this.chbUseFTP05.Checked = false;
                    }
                    xmlAttribute = xmlNode2.Attributes["FileName"];
                    if (xmlAttribute != null)
                    {
                        this.txtFTP05_FileName.Text = xmlAttribute.Value;
                    }
                    xmlAttribute = xmlNode2.Attributes["PathName"];
                    if (xmlAttribute != null)
                    {
                        this.txtFTP05_PathName.Text = xmlAttribute.Value;
                    }
                    xmlAttribute = xmlNode2.Attributes["FTPName"];
                    if (xmlAttribute != null)
                    {
                        this.txtFTP05_NameFTP.Text = xmlAttribute.Value;
                    }
                    xmlAttribute = xmlNode2.Attributes["User"];
                    if (xmlAttribute != null)
                    {
                        this.txtFTP05_FTPUser.Text = xmlAttribute.Value;
                    }
                    xmlAttribute = xmlNode2.Attributes["Pwd"];
                    if (xmlAttribute != null)
                    {
                        this.txtFTP05_FTPPwd.Text = xmlAttribute.Value;
                    }
                    xmlAttribute = xmlNode2.Attributes["Proxy"];
                    if (xmlAttribute != null)
                    {
                        this.chbFTP05_Proxy.Checked = true;
                        this.txtFTP05_Proxy.Text = xmlAttribute.Value;
                        xmlAttribute = xmlNode2.Attributes["ProxyUser"];
                        if (xmlAttribute != null)
                        {
                            this.txtFTP05_ProxyUser.Text = xmlAttribute.Value;
                        }
                        xmlAttribute = xmlNode2.Attributes["ProxyPwd"];
                        if (xmlAttribute != null)
                        {
                            this.txtFTP05_ProxyPwd.Text = xmlAttribute.Value;
                        }
                    }
                    XmlNode xmlNode3 = xmlNode2.SelectSingleNode("Shedule");
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
                XmlNode xmlNode4 = xmlNode.SelectSingleNode("FTP");
                if (xmlNode4 != null)
                {
                    XmlAttribute xmlAttribute2 = xmlNode4.Attributes["UseFTP"];
                    if (xmlAttribute2 != null)
                    {
                        this.chbUseFTP.Checked = Convert.ToBoolean(xmlAttribute2.Value);
                    }
                    else
                    {
                        this.chbUseFTP.Checked = false;
                    }
                    xmlAttribute2 = xmlNode4.Attributes["FileName"];
                    if (xmlAttribute2 != null)
                    {
                        this.txtFTP_FileName.Text = xmlAttribute2.Value;
                    }
                    xmlAttribute2 = xmlNode4.Attributes["PathName"];
                    if (xmlAttribute2 != null)
                    {
                        this.txtFTP_PathName.Text = xmlAttribute2.Value;
                    }
                    xmlAttribute2 = xmlNode4.Attributes["FTPName"];
                    if (xmlAttribute2 != null)
                    {
                        this.txtFTP_NameFTP.Text = xmlAttribute2.Value;
                    }
                    xmlAttribute2 = xmlNode4.Attributes["User"];
                    if (xmlAttribute2 != null)
                    {
                        this.txtFTP_FTPUser.Text = xmlAttribute2.Value;
                    }
                    xmlAttribute2 = xmlNode4.Attributes["Pwd"];
                    if (xmlAttribute2 != null)
                    {
                        this.txtFTP_FTPPwd.Text = xmlAttribute2.Value;
                    }
                    xmlAttribute2 = xmlNode4.Attributes["Proxy"];
                    if (xmlAttribute2 != null)
                    {
                        this.chbFTP_Proxy.Checked = true;
                        this.txtFTP_Proxy.Text = xmlAttribute2.Value;
                        xmlAttribute2 = xmlNode4.Attributes["ProxyUser"];
                        if (xmlAttribute2 != null)
                        {
                            this.txtFTP_ProxyUser.Text = xmlAttribute2.Value;
                        }
                        xmlAttribute2 = xmlNode4.Attributes["ProxyPwd"];
                        if (xmlAttribute2 != null)
                        {
                            this.txtFTP_ProxyPwd.Text = xmlAttribute2.Value;
                        }
                    }
                    XmlNode xmlNode5 = xmlNode4.SelectSingleNode("Shedule");
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
                XmlNode xmlNode6 = xmlNode.SelectSingleNode("MailPlanned");
                if (xmlNode6 != null)
                {
                    XmlAttribute xmlAttribute3 = xmlNode6.Attributes["FileName"];
                    if (xmlAttribute3 != null)
                    {
                        this.txtFileNameMailPlanned.Text = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNode6.Attributes["Subject"];
                    if (xmlAttribute3 != null)
                    {
                        this.txtSubjectPlanned.Text = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNode6.Attributes["Body"];
                    if (xmlAttribute3 != null)
                    {
                        this.txtBodyPlanned.Text = xmlAttribute3.Value;
                    }
                    xmlAttribute3 = xmlNode6.Attributes["useMail"];
                    if (xmlAttribute3 != null)
                    {
                        this.chkUseMailPlanned.Checked = Convert.ToBoolean(xmlAttribute3.Value);
                    }
                    else
                    {
                        this.chkUseMailPlanned.Checked = false;
                    }
                    XmlNode xmlNode7 = xmlNode6.SelectSingleNode("SMTP");
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
                    XmlNode xmlNode8 = xmlNode6.SelectSingleNode("Sender");
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
                    XmlNode xmlNode9 = xmlNode6.SelectSingleNode("Recipients");
                    if (xmlNode9 != null)
                    {
                        foreach (XmlNode xmlNode10 in xmlNode9.SelectNodes("Recipient"))
                        {

                            string Address = "";
                            string name = "";
                            xmlAttribute3 = xmlNode10.Attributes["Address"];
                            if (xmlAttribute3 != null)
                            {
                                Address = xmlAttribute3.Value;
                            }
                            xmlAttribute3 = xmlNode10.Attributes["Name"];
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
                    XmlNode xmlNode11 = xmlNode6.SelectSingleNode("Shedule");
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
                xmlNode2 = xmlNode.SelectSingleNode("PathCURL");
                if (xmlNode2 != null && !string.IsNullOrEmpty(xmlNode2.InnerText))
                {
                    this.txtCURL.Text = xmlNode2.InnerText;
                }
                XmlNode xmlNode12 = xmlNode.SelectSingleNode("RIC");
                if (xmlNode12 != null)
                {
                    XmlAttribute xmlAttribute4 = xmlNode12.Attributes["SendRIC"];
                    if (xmlAttribute4 != null)
                    {
                        this.checkBoxSendRIC.Checked = Convert.ToBoolean(xmlAttribute4.Value);
                    }
                }
                XmlNode xmlNodeME = xmlNode.SelectSingleNode("MinEnergo");
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
        this.txtFTP_FTPPwd.Enabled = (this.txtFTP_FTPUser.Enabled = (this.txtFTP_FileName.Enabled = (this.txtFTP_NameFTP.Enabled = (this.txtFTP_Proxy.Enabled = (this.txtFTP_ProxyPwd.Enabled = (this.txtFTP_ProxyUser.Enabled = (this.chbFTP_Proxy.Enabled = (this.btnFTP_ChoiceFileName.Enabled = (this.txtFTP_PathName.Enabled = (this.btnFTP_ChoicePath.Enabled = (this.groupBoxSheduleFTP.Enabled = this.chbUseFTP.Checked)))))))))));
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
        this.txtFileNameMailPlanned.Enabled = (this.btnChoiseFileMail.Enabled = (this.groupBoxSMTP.Enabled = (this.groupBoxSender.Enabled = (this.dgvRecipients.Enabled = (this.txtSubjectPlanned.Enabled = (this.txtBodyPlanned.Enabled = (this.groupBoxSheduleMailPlanned.Enabled = this.chkUseMailPlanned.Checked)))))));
    }

    private void btnChoiseFileMail_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "xls files (*.xls)|*.xls";
        saveFileDialog.CheckFileExists = false;
        saveFileDialog.OverwritePrompt = false;
        saveFileDialog.CheckPathExists = false;
        saveFileDialog.FileName = this.txtFileNameMailPlanned.Text;
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            this.txtFileNameMailPlanned.Text = saveFileDialog.FileName;
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
}

