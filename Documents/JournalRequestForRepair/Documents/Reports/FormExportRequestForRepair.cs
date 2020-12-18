using FormLbr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;
namespace Documents.JournalRequestForRepair
{
    /// <summary>
    /// Экспорт заявок на ремонт оборудования
    /// </summary>
    internal class FormExportRequestForRepair : FormBase
    {
        private bool isCrash;
        private Button buttonCreateHTML;
        private Button buttonHTML;
        private Button buttonCreateExcel;
        private Button buttonExcel;
        private Button buttonSendMail;
        private Button buttonFileMail;
        private Button button1;
        private static byte[] byte_0 = System.Text.Encoding.ASCII.GetBytes("jf8hSDJH");
        private DateTimePicker dateTimePickerHTMLEnd;
        private DateTimePicker dateTimePickerHTMLBeg;
        private DateTimePicker dateTimePickerExcel;
        private GroupBox groupBoxHTML;
        private GroupBox groupBox1;
        private GroupBox groupBoxMail;
        private IContainer components = null;
        private int numPort;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label label_11;
        private Label label_12;
        private Label label_13;
        private Label label_14;
        private Label label_15;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private OpenFileDialog openFileDialogMail;
        private RichTextBox textBoxBodyMail;
        private SaveFileDialog saveFileDialogHTML;
        private SaveFileDialog saveFileDialogExcel;
        private SplitContainer splitContainer1;
        private string stringHTML;
        private string stringExcel;
        private string stringRecipientAddress;
        private string stringRecipientName;
        private string stringFileNameMail;
        private string stringSubjectMail;
        private string stringBodyMail;
        private string stringSmtoServer;
        private string stringLogin;
        private string stringPassword;
        private string stringSenderAddress;
        private string stringSenderName;
        private TextBox textBoxHTML;
        private TextBox textBoxExcel;
        private TextBox textBoxSmtoServer;
        private TextBox textBoxPassword;
        private TextBox textBoxSubjectMail;
        private TextBox textBoxFileNameMail;
        private TextBox textBoxRecipientAddress;
        private TextBox textBoxSenderAddress;
        private TextBox textBoxLogin;
        private TextBox textBoxRecipientName;
        private TextBox textBoxSenderName;
        private TextBox textBoxSmtpPort;

        internal FormExportRequestForRepair()
        {
            this.stringHTML = "plan_rabota.html";
            this.stringExcel = "plan_rabota.xls";
            this.stringFileNameMail = "plan_rabota.xls";
            this.stringSubjectMail = "Плановые работы на ";
            this.stringBodyMail = "Создано автоматически. Ответа не требует.";
            this.stringSmtoServer = "domino";
            this.numPort = 0x19;
            this.stringLogin = "GEV";
            this.stringPassword = "u09gev";
            this.stringSenderAddress = "asu@ulges.ru";
            this.stringSenderName = "УльГЭС";
            this.stringRecipientAddress = "kirag.3@list.ru";
            this.stringRecipientName = "Alexandr";
            this.InitializeComponent();
        }

        internal FormExportRequestForRepair(bool IsCrash = false)
        {
            this.stringHTML = "plan_rabota.html";
            this.stringExcel = "plan_rabota.xls";
            this.stringFileNameMail = "plan_rabota.xls";
            this.stringSubjectMail = "Плановые работы на ";
            this.stringBodyMail = "Создано автоматически. Ответа не требует.";
            this.stringSmtoServer = "domino";
            this.numPort = 0x19;
            this.stringLogin = "GEV";
            this.stringPassword = "u09gev";
            this.stringSenderAddress = "asu@ulges.ru";
            this.stringSenderName = "УльГЭС";
            this.stringRecipientAddress = "kirag.3@list.ru";
            this.stringRecipientName = "Alexandr";
            this.InitializeComponent();
            this.isCrash = IsCrash;
            if (IsCrash)
            {
                this.Text = "Экспорт аварийных заявок на ремонт оборудования";
            }
        }

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
            if (node != null)
            {
                XmlNode node2 = node.SelectSingleNode("ReportHTML");
                if (node2 != null)
                {
                    XmlAttribute attribute = node2.Attributes["FileName"];
                    if (attribute != null)
                    {
                        this.stringHTML = attribute.Value;
                    }
                }
                XmlNode node3 = node.SelectSingleNode("ReportExcel");
                if (node3 != null)
                {
                    XmlAttribute attribute2 = node3.Attributes["FileName"];
                    if (attribute2 != null)
                    {
                        this.stringExcel = attribute2.Value;
                    }
                }
                XmlNode node4 = node.SelectSingleNode("Mail");
                if (node4 != null)
                {
                    XmlAttribute attribute3 = node4.Attributes["FileName"];
                    if (attribute3 != null)
                    {
                        this.stringFileNameMail = attribute3.Value;
                    }
                    attribute3 = node4.Attributes["Subject"];
                    if (attribute3 != null)
                    {
                        this.stringSubjectMail = attribute3.Value;
                    }
                    attribute3 = node4.Attributes["Body"];
                    if (attribute3 != null)
                    {
                        this.stringBodyMail = attribute3.Value;
                    }
                    XmlNode node5 = node4.SelectSingleNode("SMTP");
                    if (node5 != null)
                    {
                        attribute3 = node5.Attributes["Name"];
                        if (attribute3 != null)
                        {
                            this.stringSmtoServer = attribute3.Value;
                        }
                        attribute3 = node5.Attributes["port"];
                        if (attribute3 != null)
                        {
                            this.numPort = Convert.ToInt32(attribute3.Value);
                        }
                        attribute3 = node5.Attributes["Login"];
                        if (attribute3 != null)
                        {
                            this.stringLogin = smethod_1(attribute3.Value);
                        }
                        attribute3 = node5.Attributes["Password"];
                        if (attribute3 != null)
                        {
                            this.stringPassword = smethod_1(attribute3.Value);
                        }
                    }
                    XmlNode node6 = node4.SelectSingleNode("Sender");
                    if (node6 != null)
                    {
                        attribute3 = node6.Attributes["Address"];
                        if (attribute3 != null)
                        {
                            this.stringSenderAddress = attribute3.Value;
                        }
                        attribute3 = node6.Attributes["Name"];
                        if (attribute3 != null)
                        {
                            this.stringSenderName = attribute3.Value;
                        }
                    }
                    XmlNode node7 = node4.SelectSingleNode("Recipient");
                    if (node7 != null)
                    {
                        attribute3 = node7.Attributes["Address"];
                        if (attribute3 != null)
                        {
                            this.stringRecipientAddress = attribute3.Value;
                        }
                        attribute3 = node7.Attributes["Name"];
                        if (attribute3 != null)
                        {
                            this.stringRecipientName = attribute3.Value;
                        }
                    }
                }
            }
        }

        private void buttonCreateHTML_Click(object sender, EventArgs e)
        {
            if (ExportRequestForRepair.smethod_5(this.SqlSettings, this.stringHTML, this.dateTimePickerHTMLBeg.Value, this.dateTimePickerHTMLEnd.Value))
            {
                MessageBox.Show("Файл " + this.stringHTML + " создан");
            }
        }

        private void buttonHTML_Click(object sender, EventArgs e)
        {
            this.saveFileDialogHTML.FileName = this.stringHTML;
            if (this.saveFileDialogHTML.ShowDialog() == DialogResult.OK)
            {
                this.textBoxHTML.Text = this.saveFileDialogHTML.FileName;
            }
        }

        private void buttonCreateExcel_Click(object sender, EventArgs e)
        {
            if (ExportRequestForRepair.smethod_7(this.SqlSettings, this.stringExcel, this.dateTimePickerExcel.Value, this.isCrash))
            {
                MessageBox.Show("Файл " + this.stringExcel + " создан");
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            this.saveFileDialogExcel.FileName = this.stringExcel;
            if (this.saveFileDialogExcel.ShowDialog() == DialogResult.OK)
            {
                this.textBoxExcel.Text = this.saveFileDialogExcel.FileName;
            }
        }

        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            List<RequestForRepair.StructMailAddress> list = new List<RequestForRepair.StructMailAddress>
            {
            new RequestForRepair.StructMailAddress(this.stringRecipientAddress, this.stringRecipientName)
            };
            List<string> list2 = new List<string>
            {
            this.stringFileNameMail
            };
            if (ExportRequestForRepair.SendMessage(this.stringSmtoServer, this.numPort, this.stringLogin, this.stringPassword, this.stringSenderAddress, this.stringSenderName, list, this.stringSubjectMail, this.stringBodyMail, list2, false))
            {
                MessageBox.Show("Сообщение успешно отправлено");
            }
        }

        private void buttonFileMail_Click(object sender, EventArgs e)
        {
            this.openFileDialogMail.FileName = this.stringFileNameMail;
            if (this.openFileDialogMail.ShowDialog() == DialogResult.OK)
            {
                this.textBoxFileNameMail.Text = this.openFileDialogMail.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = ".html";
            string str2 = @"d:\temp\req\";
            for (DateTime time = new DateTime(0x7de, 7, 4); time <= new DateTime(0x7de, 7, 13); time = time.AddDays(1.0))
            {
                string introduced4 = str2 + time.ToString("yyyyMMdd") + str;
                DateTime introduced5 = time.AddDays(1.0);
                ExportRequestForRepair.smethod_4(this.SqlSettings, introduced4, introduced5, time.AddDays(9.0).AddSeconds(-1.0), this.isCrash);
            }
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document1 = new XmlDocument();
            XmlNode newChild = document1.CreateXmlDeclaration("1.0", "UTF-8", null);
            document1.AppendChild(newChild);
            XmlNode node2 = document1.CreateElement(base.Name);
            document1.AppendChild(node2);
            XmlNode node3 = document1.CreateElement("ReportHTML");
            node2.AppendChild(node3);
            XmlAttribute node = document1.CreateAttribute("FileName");
            node.Value = this.stringHTML;
            node3.Attributes.Append(node);
            XmlNode node4 = document1.CreateElement("ReportExcel");
            node2.AppendChild(node4);
            node = document1.CreateAttribute("FileName");
            node.Value = this.stringExcel;
            node4.Attributes.Append(node);
            XmlNode node5 = document1.CreateElement("Mail");
            node2.AppendChild(node5);
            node = document1.CreateAttribute("FileName");
            node.Value = this.stringFileNameMail;
            node5.Attributes.Append(node);
            node = document1.CreateAttribute("Subject");
            node.Value = this.stringSubjectMail;
            node5.Attributes.Append(node);
            node = document1.CreateAttribute("Body");
            node.Value = this.stringBodyMail;
            node5.Attributes.Append(node);
            XmlNode node6 = document1.CreateElement("SMTP");
            node5.AppendChild(node6);
            node = document1.CreateAttribute("Name");
            node.Value = this.stringSmtoServer;
            node6.Attributes.Append(node);
            node = document1.CreateAttribute("port");
            node.Value = this.numPort.ToString();
            node6.Attributes.Append(node);
            node = document1.CreateAttribute("Login");
            node.Value = smethod_0(this.stringLogin);
            node6.Attributes.Append(node);
            node = document1.CreateAttribute("Password");
            node.Value = smethod_0(this.stringPassword);
            node6.Attributes.Append(node);
            XmlNode node7 = document1.CreateElement("Sender");
            node5.AppendChild(node7);
            node = document1.CreateAttribute("Address");
            node.Value = this.stringSenderAddress;
            node7.Attributes.Append(node);
            node = document1.CreateAttribute("Name");
            node.Value = this.stringSenderName;
            node7.Attributes.Append(node);
            XmlNode node8 = document1.CreateElement("Recipient");
            node5.AppendChild(node8);
            node = document1.CreateAttribute("Address");
            node.Value = this.stringRecipientAddress;
            node8.Attributes.Append(node);
            node = document1.CreateAttribute("Name");
            node.Value = this.stringRecipientName;
            node8.Attributes.Append(node);
            return document1;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormExportRequestForRepair_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormExportRequestForRepair_Load(object sender, EventArgs e)
        {
            base.LoadFormConfig(null);
            this.textBoxHTML.Text = this.stringHTML;
            this.textBoxExcel.Text = this.stringExcel;
            this.textBoxFileNameMail.Text = this.stringFileNameMail;
            this.textBoxSubjectMail.Text = this.stringSubjectMail;
            this.textBoxBodyMail.Text = this.stringBodyMail;
            this.textBoxSmtoServer.Text = this.stringSmtoServer;
            this.textBoxSmtpPort.Text = this.numPort.ToString();
            this.textBoxLogin.Text = this.stringLogin;
            this.textBoxPassword.Text = this.stringPassword;
            this.textBoxSenderAddress.Text = this.stringSenderAddress;
            this.textBoxSenderName.Text = this.stringSenderName;
            this.textBoxRecipientAddress.Text = this.stringRecipientAddress;
            this.textBoxRecipientName.Text = this.stringRecipientName;
            this.dateTimePickerHTMLBeg.Value = DateTime.Now.Date;
            this.dateTimePickerHTMLEnd.Value = DateTime.Now.Date.AddDays(7.0);
            this.dateTimePickerExcel.Value = DateTime.Now.Date;
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormExportRequestForRepair));
            this.groupBoxHTML = new GroupBox();
            this.dateTimePickerHTMLEnd = new DateTimePicker();
            this.label_1 = new Label();
            this.dateTimePickerHTMLBeg = new DateTimePicker();
            this.label_2 = new Label();
            this.buttonCreateHTML = new Button();
            this.buttonHTML = new Button();
            this.textBoxHTML = new TextBox();
            this.label_0 = new Label();
            this.saveFileDialogHTML = new SaveFileDialog();
            this.groupBox1 = new GroupBox();
            this.dateTimePickerExcel = new DateTimePicker();
            this.label_3 = new Label();
            this.buttonCreateExcel = new Button();
            this.buttonExcel = new Button();
            this.textBoxExcel = new TextBox();
            this.label_4 = new Label();
            this.saveFileDialogExcel = new SaveFileDialog();
            this.groupBoxMail = new GroupBox();
            this.buttonSendMail = new Button();
            this.textBoxBodyMail = new RichTextBox();
            this.label_5 = new Label();
            this.textBoxSubjectMail = new TextBox();
            this.label_6 = new Label();
            this.buttonFileMail = new Button();
            this.textBoxFileNameMail = new TextBox();
            this.label_7 = new Label();
            this.splitContainer1 = new SplitContainer();
            this.textBoxRecipientAddress = new TextBox();
            this.label_8 = new Label();
            this.textBoxSenderAddress = new TextBox();
            this.label_9 = new Label();
            this.textBoxLogin = new TextBox();
            this.label_10 = new Label();
            this.textBoxPassword = new TextBox();
            this.textBoxRecipientName = new TextBox();
            this.label_11 = new Label();
            this.textBoxSenderName = new TextBox();
            this.label_12 = new Label();
            this.label_13 = new Label();
            this.textBoxSmtpPort = new TextBox();
            this.label_14 = new Label();
            this.textBoxSmtoServer = new TextBox();
            this.label_15 = new Label();
            this.openFileDialogMail = new OpenFileDialog();
            this.button1 = new Button();
            this.groupBoxHTML.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMail.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            base.SuspendLayout();
            this.groupBoxHTML.Controls.Add(this.dateTimePickerHTMLEnd);
            this.groupBoxHTML.Controls.Add(this.label_1);
            this.groupBoxHTML.Controls.Add(this.dateTimePickerHTMLBeg);
            this.groupBoxHTML.Controls.Add(this.label_2);
            this.groupBoxHTML.Controls.Add(this.buttonCreateHTML);
            this.groupBoxHTML.Controls.Add(this.buttonHTML);
            this.groupBoxHTML.Controls.Add(this.textBoxHTML);
            this.groupBoxHTML.Controls.Add(this.label_0);
            this.groupBoxHTML.Location = new Point(1, 2);
            this.groupBoxHTML.Name = "groupBoxHTML";
            this.groupBoxHTML.Size = new Size(0x137, 0x86);
            this.groupBoxHTML.TabIndex = 0;
            this.groupBoxHTML.TabStop = false;
            this.groupBoxHTML.Text = "HTML";
            this.dateTimePickerHTMLEnd.Location = new Point(0xae, 0x21);
            this.dateTimePickerHTMLEnd.Name = "dateTimePickerHTMLEnd";
            this.dateTimePickerHTMLEnd.Size = new Size(0x83, 20);
            this.dateTimePickerHTMLEnd.TabIndex = 7;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(0xab, 0x10);
            this.label_1.Name = "label3";
            this.label_1.Size = new Size(0x13, 13);
            this.label_1.TabIndex = 6;
            this.label_1.Text = "до";
            this.dateTimePickerHTMLBeg.Location = new Point(14, 0x21);
            this.dateTimePickerHTMLBeg.Name = "dateTimePickerHTMLBeg";
            this.dateTimePickerHTMLBeg.Size = new Size(0x8d, 20);
            this.dateTimePickerHTMLBeg.TabIndex = 5;
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(11, 0x10);
            this.label_2.Name = "label2";
            this.label_2.Size = new Size(0x2f, 13);
            this.label_2.TabIndex = 4;
            this.label_2.Text = "Дата от";
            this.buttonCreateHTML.Location = new Point(11, 0x69);
            this.buttonCreateHTML.Name = "buttonCreateHTML";
            this.buttonCreateHTML.Size = new Size(0x65, 0x17);
            this.buttonCreateHTML.TabIndex = 3;
            this.buttonCreateHTML.Text = "Сформировать";
            this.buttonCreateHTML.UseVisualStyleBackColor = true;
            this.buttonCreateHTML.Click += new EventHandler(this.buttonCreateHTML_Click);
            this.buttonHTML.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.buttonHTML.Location = new Point(0x119, 0x4e);
            this.buttonHTML.Name = "buttonHTML";
            this.buttonHTML.Size = new Size(0x1a, 0x17);
            this.buttonHTML.TabIndex = 2;
            this.buttonHTML.Text = "...";
            this.buttonHTML.UseVisualStyleBackColor = true;
            this.buttonHTML.Click += new EventHandler(this.buttonHTML_Click);
            this.textBoxHTML.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBoxHTML.Location = new Point(11, 0x4f);
            this.textBoxHTML.Name = "textBoxHTML";
            this.textBoxHTML.Size = new Size(0x112, 20);
            this.textBoxHTML.TabIndex = 1;
            this.textBoxHTML.TextChanged += new EventHandler(this.textBoxHTML_TextChanged);
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(11, 0x3f);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x40, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Имя файла";
            this.saveFileDialogHTML.Filter = "HTML Files (*.html)|*.html";
            this.groupBox1.Controls.Add(this.dateTimePickerExcel);
            this.groupBox1.Controls.Add(this.label_3);
            this.groupBox1.Controls.Add(this.buttonCreateExcel);
            this.groupBox1.Controls.Add(this.buttonExcel);
            this.groupBox1.Controls.Add(this.textBoxExcel);
            this.groupBox1.Controls.Add(this.label_4);
            this.groupBox1.Location = new Point(1, 0xe2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x137, 0x86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel";
            this.dateTimePickerExcel.Location = new Point(14, 0x21);
            this.dateTimePickerExcel.Name = "dateTimePickerExcel";
            this.dateTimePickerExcel.Size = new Size(0x8d, 20);
            this.dateTimePickerExcel.TabIndex = 5;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(11, 0x10);
            this.label_3.Name = "label5";
            this.label_3.Size = new Size(0x21, 13);
            this.label_3.TabIndex = 4;
            this.label_3.Text = "Дата";
            this.buttonCreateExcel.Location = new Point(11, 0x69);
            this.buttonCreateExcel.Name = "buttonCreateExcel";
            this.buttonCreateExcel.Size = new Size(0x65, 0x17);
            this.buttonCreateExcel.TabIndex = 3;
            this.buttonCreateExcel.Text = "Сформировать";
            this.buttonCreateExcel.UseVisualStyleBackColor = true;
            this.buttonCreateExcel.Click += new EventHandler(this.buttonCreateExcel_Click);
            this.buttonExcel.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.buttonExcel.Location = new Point(0x119, 0x4d);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new Size(0x1a, 0x17);
            this.buttonExcel.TabIndex = 2;
            this.buttonExcel.Text = "...";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new EventHandler(this.buttonExcel_Click);
            this.textBoxExcel.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBoxExcel.Location = new Point(11, 0x4f);
            this.textBoxExcel.Name = "textBoxExcel";
            this.textBoxExcel.Size = new Size(0x112, 20);
            this.textBoxExcel.TabIndex = 1;
            this.textBoxExcel.TextChanged += new EventHandler(this.textBoxExcel_TextChanged);
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(11, 0x3f);
            this.label_4.Name = "label6";
            this.label_4.Size = new Size(0x40, 13);
            this.label_4.TabIndex = 0;
            this.label_4.Text = "Имя файла";
            this.saveFileDialogExcel.Filter = "Excel Files (*.xls)|*.xls";
            this.groupBoxMail.Controls.Add(this.buttonSendMail);
            this.groupBoxMail.Controls.Add(this.textBoxBodyMail);
            this.groupBoxMail.Controls.Add(this.label_5);
            this.groupBoxMail.Controls.Add(this.textBoxSubjectMail);
            this.groupBoxMail.Controls.Add(this.label_6);
            this.groupBoxMail.Controls.Add(this.buttonFileMail);
            this.groupBoxMail.Controls.Add(this.textBoxFileNameMail);
            this.groupBoxMail.Controls.Add(this.label_7);
            this.groupBoxMail.Controls.Add(this.splitContainer1);
            this.groupBoxMail.Controls.Add(this.textBoxSmtpPort);
            this.groupBoxMail.Controls.Add(this.label_14);
            this.groupBoxMail.Controls.Add(this.textBoxSmtoServer);
            this.groupBoxMail.Controls.Add(this.label_15);
            this.groupBoxMail.Location = new Point(0x13a, 2);
            this.groupBoxMail.Name = "groupBoxMail";
            this.groupBoxMail.Size = new Size(0x1ac, 360);
            this.groupBoxMail.TabIndex = 2;
            this.groupBoxMail.TabStop = false;
            this.groupBoxMail.Text = "Почта";
            this.buttonSendMail.Location = new Point(14, 0x14e);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new Size(0x4b, 0x17);
            this.buttonSendMail.TabIndex = 12;
            this.buttonSendMail.Text = "Отправить";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new EventHandler(this.buttonSendMail_Click);
            this.textBoxBodyMail.Location = new Point(14, 0x116);
            this.textBoxBodyMail.Name = "textBoxBodyMail";
            this.textBoxBodyMail.Size = new Size(0x199, 50);
            this.textBoxBodyMail.TabIndex = 11;
            this.textBoxBodyMail.Text = "";
            this.textBoxBodyMail.TextChanged += new EventHandler(this.textBoxBodyMail_TextChanged);
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(11, 0x107);
            this.label_5.Name = "label16";
            this.label_5.Size = new Size(0x4e, 13);
            this.label_5.TabIndex = 10;
            this.label_5.Text = "Текст письма";
            this.textBoxSubjectMail.Location = new Point(14, 240);
            this.textBoxSubjectMail.Name = "textBoxSubjectMail";
            this.textBoxSubjectMail.Size = new Size(0x199, 20);
            this.textBoxSubjectMail.TabIndex = 9;
            this.textBoxSubjectMail.TextChanged += new EventHandler(this.textBoxSubjectMail_TextChanged);
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(11, 0xe0);
            this.label_6.Name = "label15";
            this.label_6.Size = new Size(0x4b, 13);
            this.label_6.TabIndex = 8;
            this.label_6.Text = "Тема письма";
            this.buttonFileMail.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.buttonFileMail.Location = new Point(0x18e, 0xc6);
            this.buttonFileMail.Name = "buttonFileMail";
            this.buttonFileMail.Size = new Size(0x1a, 0x17);
            this.buttonFileMail.TabIndex = 7;
            this.buttonFileMail.Text = "...";
            this.buttonFileMail.UseVisualStyleBackColor = true;
            this.buttonFileMail.Click += new EventHandler(this.buttonFileMail_Click);
            this.textBoxFileNameMail.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBoxFileNameMail.Location = new Point(14, 0xc9);
            this.textBoxFileNameMail.Name = "textBoxFileNameMail";
            this.textBoxFileNameMail.Size = new Size(0x180, 20);
            this.textBoxFileNameMail.TabIndex = 6;
            this.textBoxFileNameMail.TextChanged += new EventHandler(this.textBoxFileNameMail_TextChanged);
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(11, 0xb9);
            this.label_7.Name = "label14";
            this.label_7.Size = new Size(0x40, 13);
            this.label_7.TabIndex = 5;
            this.label_7.Text = "Имя файла";
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new Point(0, 0x3a);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.textBoxRecipientAddress);
            this.splitContainer1.Panel1.Controls.Add(this.label_8);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSenderAddress);
            this.splitContainer1.Panel1.Controls.Add(this.label_9);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLogin);
            this.splitContainer1.Panel1.Controls.Add(this.label_10);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPassword);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxRecipientName);
            this.splitContainer1.Panel2.Controls.Add(this.label_11);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSenderName);
            this.splitContainer1.Panel2.Controls.Add(this.label_12);
            this.splitContainer1.Panel2.Controls.Add(this.label_13);
            this.splitContainer1.Size = new Size(0x1ab, 0x7c);
            this.splitContainer1.SplitterDistance = 0xd3;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 4;
            this.textBoxRecipientAddress.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBoxRecipientAddress.Location = new Point(14, 0x5e);
            this.textBoxRecipientAddress.Name = "textBoxRecipientAddress";
            this.textBoxRecipientAddress.Size = new Size(0xc2, 20);
            this.textBoxRecipientAddress.TabIndex = 5;
            this.textBoxRecipientAddress.TextChanged += new EventHandler(this.textBoxRecipientAddress_TextChanged);
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(11, 0x4e);
            this.label_8.Name = "label12";
            this.label_8.Size = new Size(0x62, 13);
            this.label_8.TabIndex = 4;
            this.label_8.Text = "Адрес получателя";
            this.textBoxSenderAddress.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBoxSenderAddress.Location = new Point(14, 0x37);
            this.textBoxSenderAddress.Name = "textBoxSenderAddress";
            this.textBoxSenderAddress.Size = new Size(0xc2, 20);
            this.textBoxSenderAddress.TabIndex = 3;
            this.textBoxSenderAddress.TextChanged += new EventHandler(this.textBoxSenderAddress_TextChanged);
            this.label_9.AutoSize = true;
            this.label_9.Location = new Point(11, 0x27);
            this.label_9.Name = "label10";
            this.label_9.Size = new Size(0x69, 13);
            this.label_9.TabIndex = 2;
            this.label_9.Text = "Адрес отправителя";
            this.textBoxLogin.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBoxLogin.Location = new Point(14, 0x10);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new Size(0xc2, 20);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.TextChanged += new EventHandler(this.textBoxLogin_TextChanged);
            this.label_10.AutoSize = true;
            this.label_10.Location = new Point(11, 0);
            this.label_10.Name = "label8";
            this.label_10.Size = new Size(0x26, 13);
            this.label_10.TabIndex = 0;
            this.label_10.Text = "Логин";
            this.textBoxPassword.Location = new Point(6, 0x10);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '☻';
            this.textBoxPassword.Size = new Size(0xce, 20);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.TextChanged += new EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxRecipientName.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBoxRecipientName.Location = new Point(6, 0x5e);
            this.textBoxRecipientName.Name = "textBoxRecipientName";
            this.textBoxRecipientName.Size = new Size(0xcd, 20);
            this.textBoxRecipientName.TabIndex = 7;
            this.textBoxRecipientName.TextChanged += new EventHandler(this.textBoxRecipientName_TextChanged);
            this.label_11.AutoSize = true;
            this.label_11.Location = new Point(3, 0x4e);
            this.label_11.Name = "label13";
            this.label_11.Size = new Size(0x59, 13);
            this.label_11.TabIndex = 6;
            this.label_11.Text = "Имя получателя";
            this.textBoxSenderName.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBoxSenderName.Location = new Point(6, 0x37);
            this.textBoxSenderName.Name = "textBoxSenderName";
            this.textBoxSenderName.Size = new Size(0xcd, 20);
            this.textBoxSenderName.TabIndex = 5;
            this.textBoxSenderName.TextChanged += new EventHandler(this.textBoxSenderName_TextChanged);
            this.label_12.AutoSize = true;
            this.label_12.Location = new Point(3, 0x27);
            this.label_12.Name = "label11";
            this.label_12.Size = new Size(0x60, 13);
            this.label_12.TabIndex = 4;
            this.label_12.Text = "Имя отправителя";
            this.label_13.AutoSize = true;
            this.label_13.Location = new Point(3, 0);
            this.label_13.Name = "label9";
            this.label_13.Size = new Size(0x2d, 13);
            this.label_13.TabIndex = 2;
            this.label_13.Text = "Пароль";
            this.textBoxSmtpPort.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBoxSmtpPort.Location = new Point(0x148, 0x20);
            this.textBoxSmtpPort.Name = "textBoxSmtpPort";
            this.textBoxSmtpPort.Size = new Size(0x60, 20);
            this.textBoxSmtpPort.TabIndex = 3;
            this.textBoxSmtpPort.TextChanged += new EventHandler(this.textBoxSmtpPort_TextChanged);
            this.textBoxSmtpPort.KeyPress += new KeyPressEventHandler(this.textBoxSmtpPort_KeyPress);
            this.label_14.AutoSize = true;
            this.label_14.Location = new Point(0x147, 0x10);
            this.label_14.Name = "label7";
            this.label_14.Size = new Size(0x20, 13);
            this.label_14.TabIndex = 2;
            this.label_14.Text = "Порт";
            this.textBoxSmtoServer.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBoxSmtoServer.Location = new Point(11, 0x20);
            this.textBoxSmtoServer.Name = "textBoxSmtoServer";
            this.textBoxSmtoServer.Size = new Size(0x127, 20);
            this.textBoxSmtoServer.TabIndex = 1;
            this.textBoxSmtoServer.TextChanged += new EventHandler(this.textBoxSmtoServer_TextChanged);
            this.label_15.AutoSize = true;
            this.label_15.Location = new Point(8, 0x10);
            this.label_15.Name = "label4";
            this.label_15.Size = new Size(0x5e, 13);
            this.label_15.TabIndex = 0;
            this.label_15.Text = "Сервер отправки";
            this.button1.Location = new Point(12, 0x97);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x65, 0x17);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x2e8, 0x170);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.groupBoxMail);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.groupBoxHTML);
            //base.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MinimumSize = new Size(760, 0x196);
            base.Name = "FormExportRequestForRepair";
            this.Text = "Экспорт заявок на ремонт оборудования";
            base.FormClosing += new FormClosingEventHandler(this.FormExportRequestForRepair_FormClosing);
            base.Load += new EventHandler(this.FormExportRequestForRepair_Load);
            this.groupBoxHTML.ResumeLayout(false);
            this.groupBoxHTML.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMail.ResumeLayout(false);
            this.groupBoxMail.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void textBoxBodyMail_TextChanged(object sender, EventArgs e)
        {
            this.stringBodyMail = this.textBoxBodyMail.Text;
        }

        private static string smethod_0(string string_12)
        {
            if (string.IsNullOrEmpty(string_12))
            {
                throw new ArgumentNullException("The string which needs to be encrypted can not be null.");
            }
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(byte_0, byte_0), CryptoStreamMode.Write);
            StreamWriter writer1 = new StreamWriter(stream2);
            writer1.Write(string_12);
            writer1.Flush();
            stream2.FlushFinalBlock();
            writer1.Flush();
            return Convert.ToBase64String(stream.GetBuffer(), 0, (int)stream.Length);
        }

        private static string smethod_1(string string_12)
        {
            if (string.IsNullOrEmpty(string_12))
            {
                throw new ArgumentNullException("The string which needs to be decrypted can not be null.");
            }
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            return new StreamReader(new CryptoStream(new MemoryStream(Convert.FromBase64String(string_12)), provider.CreateDecryptor(byte_0, byte_0), CryptoStreamMode.Read)).ReadToEnd();
        }

        private void textBoxHTML_TextChanged(object sender, EventArgs e)
        {
            this.stringHTML = this.textBoxHTML.Text;
        }

        private void textBoxExcel_TextChanged(object sender, EventArgs e)
        {
            this.stringExcel = this.textBoxExcel.Text;
        }

        private void textBoxSmtoServer_TextChanged(object sender, EventArgs e)
        {
            this.stringSmtoServer = this.textBoxSmtoServer.Text;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            this.stringPassword = this.textBoxPassword.Text;
        }

        private void textBoxSubjectMail_TextChanged(object sender, EventArgs e)
        {
            this.stringSubjectMail = this.textBoxSubjectMail.Text;
        }

        private void textBoxFileNameMail_TextChanged(object sender, EventArgs e)
        {
            this.stringFileNameMail = this.textBoxFileNameMail.Text;
        }

        private void textBoxRecipientAddress_TextChanged(object sender, EventArgs e)
        {
            this.stringRecipientAddress = this.textBoxRecipientAddress.Text;
        }

        private void textBoxSenderAddress_TextChanged(object sender, EventArgs e)
        {
            this.stringSenderAddress = this.textBoxSenderAddress.Text;
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            this.stringLogin = this.textBoxLogin.Text;
        }

        private void textBoxRecipientName_TextChanged(object sender, EventArgs e)
        {
            this.stringRecipientName = this.textBoxRecipientName.Text;
        }

        private void textBoxSenderName_TextChanged(object sender, EventArgs e)
        {
            this.stringSenderName = this.textBoxSenderName.Text;
        }

        private void textBoxSmtpPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            int result = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out result);
        }

        private void textBoxSmtpPort_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxSmtpPort.Text))
            {
                this.numPort = 0;
            }
            else
            {
                this.numPort = Convert.ToInt32(this.textBoxSmtpPort.Text);
            }
        }
    }

}