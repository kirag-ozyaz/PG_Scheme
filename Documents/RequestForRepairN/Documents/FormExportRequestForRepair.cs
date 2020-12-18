using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using FormLbr;
/// <summary>
/// Экспорт аварийных заявок на ремонт оборудования
/// </summary>
internal partial class FormExportRequestForRepair : FormBase
{
    private static byte[] bytes = Encoding.ASCII.GetBytes("jf8hSDJH");
	private string fileNameHTML = "plan_rabota.html";
    private string fileNameExcel = "plan_rabota.xls";
    private string fileNameMail = "plan_rabota.xls";
    private string subject= "Плановые работы на ";
    private string body= "Создано автоматически. Ответа не требует.";
    private string smtpServer = "domino";
    private int stmpPort= 25;
    private string smtpLogin= "GEV";
    private string smtpPassword= "u09gev";
    private string senderAddress= "asu@ulges.ru";
    private string senderName= "УльГЭС";
    private string recipientAddress= "kirag.3@list.ru";
    private string recipientName= "Alexandr";
    private bool isCrash;
    

    internal FormExportRequestForRepair()
	{
		
		this.InitializeComponent();
	}

	internal FormExportRequestForRepair(bool IsCrash = false)
	{
			this.InitializeComponent();
		this.isCrash = IsCrash;
		if (IsCrash)
		{
			this.Text = "Экспорт аварийных заявок на ремонт оборудования";
		}
	}

	private void FormExportRequestForRepair_Load(object sender, EventArgs e)
	{
		base.LoadFormConfig(null);
		this.textBoxHTML.Text = this.fileNameHTML;
		this.textBoxExcel.Text = this.fileNameExcel;
		this.textBoxFileNameMail.Text = this.fileNameMail;
		this.textBoxSubjectMail.Text = this.subject;
		this.textBoxBodyMail.Text = this.body;
		this.textBoxSmtoServer.Text = this.smtpServer;
		this.textBoxSmtpPort.Text = this.stmpPort.ToString();
		this.textBoxLogin.Text = this.smtpLogin;
		this.textBoxPassword.Text = this.smtpPassword;
		this.textBoxSenderAddress.Text = this.senderAddress;
		this.textBoxSenderName.Text = this.senderName;
		this.textBoxRecipientAddress.Text = this.recipientAddress;
		this.textBoxRecipientName.Text = this.recipientName;
		this.dateTimePickerHTMLBeg.Value = DateTime.Now.Date;
		this.dateTimePickerHTMLEnd.Value = DateTime.Now.Date.AddDays(7.0);
		this.dateTimePickerExcel.Value = DateTime.Now.Date;
	}

	private void FormExportRequestForRepair_FormClosing(object sender, FormClosingEventArgs e)
	{
		base.SaveFormConfig(null);
	}

	protected override XmlDocument CreateXmlConfig()
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
		xmlDocument.AppendChild(newChild);
		XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
		xmlDocument.AppendChild(xmlNode);
		XmlNode xmlNode2 = xmlDocument.CreateElement("ReportHTML");
		xmlNode.AppendChild(xmlNode2);
		XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("FileName");
		xmlAttribute.Value = this.fileNameHTML;
		xmlNode2.Attributes.Append(xmlAttribute);
		XmlNode xmlNode3 = xmlDocument.CreateElement("ReportExcel");
		xmlNode.AppendChild(xmlNode3);
		xmlAttribute = xmlDocument.CreateAttribute("FileName");
		xmlAttribute.Value = this.fileNameExcel;
		xmlNode3.Attributes.Append(xmlAttribute);
		XmlNode xmlNode4 = xmlDocument.CreateElement("Mail");
		xmlNode.AppendChild(xmlNode4);
		xmlAttribute = xmlDocument.CreateAttribute("FileName");
		xmlAttribute.Value = this.fileNameMail;
		xmlNode4.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Subject");
		xmlAttribute.Value = this.subject;
		xmlNode4.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Body");
		xmlAttribute.Value = this.body;
		xmlNode4.Attributes.Append(xmlAttribute);
		XmlNode xmlNode5 = xmlDocument.CreateElement("SMTP");
		xmlNode4.AppendChild(xmlNode5);
		xmlAttribute = xmlDocument.CreateAttribute("Name");
		xmlAttribute.Value = this.smtpServer;
		xmlNode5.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("port");
		xmlAttribute.Value = this.stmpPort.ToString();
		xmlNode5.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Login");
		xmlAttribute.Value = FormExportRequestForRepair.Encrypt(this.smtpLogin);
		xmlNode5.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Password");
		xmlAttribute.Value = FormExportRequestForRepair.Encrypt(this.smtpPassword);
		xmlNode5.Attributes.Append(xmlAttribute);
		XmlNode xmlNode6 = xmlDocument.CreateElement("Sender");
		xmlNode4.AppendChild(xmlNode6);
		xmlAttribute = xmlDocument.CreateAttribute("Address");
		xmlAttribute.Value = this.senderAddress;
		xmlNode6.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Name");
		xmlAttribute.Value = this.senderName;
		xmlNode6.Attributes.Append(xmlAttribute);
		XmlNode xmlNode7 = xmlDocument.CreateElement("Recipient");
		xmlNode4.AppendChild(xmlNode7);
		xmlAttribute = xmlDocument.CreateAttribute("Address");
		xmlAttribute.Value = this.recipientAddress;
		xmlNode7.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Name");
		xmlAttribute.Value = this.recipientName;
		xmlNode7.Attributes.Append(xmlAttribute);
		return xmlDocument;
	}

	protected override void ApplyConfig(XmlDocument xmlDocument_0)
	{
		XmlNode xmlNode = xmlDocument_0.SelectSingleNode(base.Name);
		if (xmlNode != null)
		{
			XmlNode xmlNode2 = xmlNode.SelectSingleNode("ReportHTML");
			if (xmlNode2 != null)
			{
				XmlAttribute xmlAttribute = xmlNode2.Attributes["FileName"];
				if (xmlAttribute != null)
				{
					this.fileNameHTML = xmlAttribute.Value;
				}
			}
			XmlNode xmlNode3 = xmlNode.SelectSingleNode("ReportExcel");
			if (xmlNode3 != null)
			{
				XmlAttribute xmlAttribute2 = xmlNode3.Attributes["FileName"];
				if (xmlAttribute2 != null)
				{
					this.fileNameExcel = xmlAttribute2.Value;
				}
			}
			XmlNode xmlNode4 = xmlNode.SelectSingleNode("Mail");
			if (xmlNode4 != null)
			{
				XmlAttribute xmlAttribute3 = xmlNode4.Attributes["FileName"];
				if (xmlAttribute3 != null)
				{
					this.fileNameMail = xmlAttribute3.Value;
				}
				xmlAttribute3 = xmlNode4.Attributes["Subject"];
				if (xmlAttribute3 != null)
				{
					this.subject = xmlAttribute3.Value;
				}
				xmlAttribute3 = xmlNode4.Attributes["Body"];
				if (xmlAttribute3 != null)
				{
					this.body = xmlAttribute3.Value;
				}
				XmlNode xmlNode5 = xmlNode4.SelectSingleNode("SMTP");
				if (xmlNode5 != null)
				{
					xmlAttribute3 = xmlNode5.Attributes["Name"];
					if (xmlAttribute3 != null)
					{
						this.smtpServer = xmlAttribute3.Value;
					}
					xmlAttribute3 = xmlNode5.Attributes["port"];
					if (xmlAttribute3 != null)
					{
						this.stmpPort = Convert.ToInt32(xmlAttribute3.Value);
					}
					xmlAttribute3 = xmlNode5.Attributes["Login"];
					if (xmlAttribute3 != null)
					{
						this.smtpLogin = FormExportRequestForRepair.Decrypt(xmlAttribute3.Value);
					}
					xmlAttribute3 = xmlNode5.Attributes["Password"];
					if (xmlAttribute3 != null)
					{
						this.smtpPassword = FormExportRequestForRepair.Decrypt(xmlAttribute3.Value);
					}
				}
				XmlNode xmlNode6 = xmlNode4.SelectSingleNode("Sender");
				if (xmlNode6 != null)
				{
					xmlAttribute3 = xmlNode6.Attributes["Address"];
					if (xmlAttribute3 != null)
					{
						this.senderAddress = xmlAttribute3.Value;
					}
					xmlAttribute3 = xmlNode6.Attributes["Name"];
					if (xmlAttribute3 != null)
					{
						this.senderName = xmlAttribute3.Value;
					}
				}
				XmlNode xmlNode7 = xmlNode4.SelectSingleNode("Recipient");
				if (xmlNode7 != null)
				{
					xmlAttribute3 = xmlNode7.Attributes["Address"];
					if (xmlAttribute3 != null)
					{
						this.recipientAddress = xmlAttribute3.Value;
					}
					xmlAttribute3 = xmlNode7.Attributes["Name"];
					if (xmlAttribute3 != null)
					{
						this.recipientName = xmlAttribute3.Value;
					}
				}
			}
		}
	}

	private static string Encrypt(string originalString)
	{
		if (string.IsNullOrEmpty(originalString))
		{
			throw new ArgumentNullException("The string which needs to be encrypted can not be null.");
		}
		DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider();
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, descryptoServiceProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
		StreamWriter streamWriter = new StreamWriter(cryptoStream);
		streamWriter.Write(originalString);
		streamWriter.Flush();
		cryptoStream.FlushFinalBlock();
		streamWriter.Flush();
		return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
	}

	private static string Decrypt(string cryptedString)
	{
		if (string.IsNullOrEmpty(cryptedString))
		{
			throw new ArgumentNullException("The string which needs to be decrypted can not be null.");
		}
		DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider();
		return new StreamReader(new CryptoStream(new MemoryStream(Convert.FromBase64String(cryptedString)), descryptoServiceProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read)).ReadToEnd();
	}

	private void textBoxHTML_TextChanged(object sender, EventArgs e)
	{
		this.fileNameHTML = this.textBoxHTML.Text;
	}

	private void buttonHTML_Click(object sender, EventArgs e)
	{
		this.saveFileDialogHTML.FileName = this.fileNameHTML;
		if (this.saveFileDialogHTML.ShowDialog() == DialogResult.OK)
		{
			this.textBoxHTML.Text = this.saveFileDialogHTML.FileName;
		}
	}

	private void buttonCreateHTML_Click(object sender, EventArgs e)
	{
		if (ExportRequestForRepair.ToHTML(this.SqlSettings, this.fileNameHTML, this.dateTimePickerHTMLBeg.Value, this.dateTimePickerHTMLEnd.Value))
		{
			MessageBox.Show("Файл " + this.fileNameHTML + " создан");
		}
	}

	private void textBoxExcel_TextChanged(object sender, EventArgs e)
	{
		this.fileNameExcel = this.textBoxExcel.Text;
	}

	private void buttonExcel_Click(object sender, EventArgs e)
	{
		this.saveFileDialogXLS.FileName = this.fileNameExcel;
		if (this.saveFileDialogXLS.ShowDialog() == DialogResult.OK)
		{
			this.textBoxExcel.Text = this.saveFileDialogXLS.FileName;
		}
	}

	private void buttonCreateExcel2_Click(object sender, EventArgs e)
	{
		if (ExportRequestForRepair.ToExcel(this.SqlSettings, this.fileNameExcel, this.dateTimePickerExcel.Value, this.isCrash))
		{
			MessageBox.Show("Файл " + this.fileNameExcel + " создан");
		}
	}

	private void textBoxSmtoServer_TextChanged(object sender, EventArgs e)
	{
		this.smtpServer = this.textBoxSmtoServer.Text;
	}

	private void textBoxSmtpPort_KeyPress(object sender, KeyPressEventArgs e)
	{
		int num = 0;
		e.Handled = !int.TryParse(e.KeyChar.ToString(), out num);
	}

	private void textBoxSmtpPort_TextChanged(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.textBoxSmtpPort.Text))
		{
			this.stmpPort = 0;
			return;
		}
		this.stmpPort = Convert.ToInt32(this.textBoxSmtpPort.Text);
	}

	private void textBoxLogin_TextChanged(object sender, EventArgs e)
	{
		this.smtpLogin = this.textBoxLogin.Text;
	}

	private void textBoxPassword_TextChanged(object sender, EventArgs e)
	{
		this.smtpPassword = this.textBoxPassword.Text;
	}

	private void textBoxSenderAddress_TextChanged(object sender, EventArgs e)
	{
		this.senderAddress = this.textBoxSenderAddress.Text;
	}

	private void textBoxSenderName_TextChanged(object sender, EventArgs e)
	{
		this.senderName = this.textBoxSenderName.Text;
	}

	private void textBoxRecipientAddress_TextChanged(object sender, EventArgs e)
	{
		this.recipientAddress = this.textBoxRecipientAddress.Text;
	}

	private void textBoxRecipientName_TextChanged(object sender, EventArgs e)
	{
		this.recipientName = this.textBoxRecipientName.Text;
	}

	private void textBoxFileNameMail_TextChanged(object sender, EventArgs e)
	{
		this.fileNameMail = this.textBoxFileNameMail.Text;
	}

	private void textBoxSubjectMail_TextChanged(object sender, EventArgs e)
	{
		this.subject = this.textBoxSubjectMail.Text;
	}

	private void textBoxBodyMail_TextChanged(object sender, EventArgs e)
	{
		this.body = this.textBoxBodyMail.Text;
	}

	private void buttonFileMail_Click(object sender, EventArgs e)
	{
		this.openFileDialog.FileName = this.fileNameMail;
		if (this.openFileDialog.ShowDialog() == DialogResult.OK)
		{
			this.textBoxFileNameMail.Text = this.openFileDialog.FileName;
		}
	}

	private void buttonSendMail_Click(object sender, EventArgs e)
	{
		List<Library.Recipient> listRecipient = new List<Library.Recipient>();
		listRecipient.Add(new Library.Recipient(this.recipientAddress, this.recipientName));
		List<string> listFileName = new List<string>();
		listFileName.Add(this.fileNameMail);
        // SendToMail
        if (Library.Mail.Send(this.smtpServer, this.stmpPort, this.smtpLogin, this.smtpPassword, this.senderAddress, this.senderName, listRecipient, this.subject, this.body, listFileName, false))
        {
            MessageBox.Show("Сообщение успешно отправлено");
        }
    }

	private void button1_Click(object sender, EventArgs e)
	{
		string str1 = ".html";
		string str2 = "d:\\temp\\req\\";
		DateTime t = new DateTime(2014, 7, 4);
		while (t <= new DateTime(2014, 7, 13))
		{
			ExportRequestForRepair.ToHTML(this.SqlSettings, str2 + t.ToString("yyyyMMdd") + str1, t.AddDays(1.0), t.AddDays(9.0).AddSeconds(-1.0), this.isCrash);
			t = t.AddDays(1.0);
		}
	}
}
