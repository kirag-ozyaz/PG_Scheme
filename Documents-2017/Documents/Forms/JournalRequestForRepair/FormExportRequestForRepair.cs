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
        private bool bool_0;
        private Button button_0;
        private Button buttonHTML;
        private Button button_2;
        private Button button_3;
        private Button button_4;
        private Button button_5;
        private Button button_6;
        private static byte[] byte_0 = System.Text.Encoding.ASCII.GetBytes("jf8hSDJH");
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private DateTimePicker dateTimePicker_2;
        private GroupBox groupBox_0;
        private GroupBox groupBox_1;
        private GroupBox groupBox_2;
        private IContainer icontainer_0 = null;
        private int int_0;
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
        private OpenFileDialog openFileDialog_0;
        private RichTextBox richTextBox_0;
        private SaveFileDialog saveFileDialog_0;
        private SaveFileDialog saveFileDialog_1;
        private SplitContainer splitContainer_0;
        private string string_0;
        private string string_1;
        private string string_10;
        private string string_11;
        private string string_2;
        private string string_3;
        private string string_4;
        private string string_5;
        private string string_6;
        private string string_7;
        private string string_8;
        private string string_9;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_10;
        private TextBox textBox_11;
        private TextBox textBox_2;
        private TextBox textBox_3;
        private TextBox textBox_4;
        private TextBox textBox_5;
        private TextBox textBox_6;
        private TextBox textBox_7;
        private TextBox textBox_8;
        private TextBox textBox_9;

        internal FormExportRequestForRepair()
        {
            this.string_0 = "plan_rabota.html";
            this.string_1 = "plan_rabota.xls";
            this.string_2 = "plan_rabota.xls";
            this.string_3 = "Плановые работы на ";
            this.string_4 = "Создано автоматически. Ответа не требует.";
            this.string_5 = "domino";
            this.int_0 = 0x19;
            this.string_6 = "GEV";
            this.string_7 = "u09gev";
            this.string_8 = "asu@ulges.ru";
            this.string_9 = "УльГЭС";
            this.string_10 = "kirag.3@list.ru";
            this.string_11 = "Alexandr";
            this.method_0();
        }

        internal FormExportRequestForRepair(bool bool_1 = false)
        {
            this.string_0 = "plan_rabota.html";
            this.string_1 = "plan_rabota.xls";
            this.string_2 = "plan_rabota.xls";
            this.string_3 = "Плановые работы на ";
            this.string_4 = "Создано автоматически. Ответа не требует.";
            this.string_5 = "domino";
            this.int_0 = 0x19;
            this.string_6 = "GEV";
            this.string_7 = "u09gev";
            this.string_8 = "asu@ulges.ru";
            this.string_9 = "УльГЭС";
            this.string_10 = "kirag.3@list.ru";
            this.string_11 = "Alexandr";
            this.method_0();
            this.bool_0 = bool_1;
            if (bool_1)
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
                        this.string_0 = attribute.Value;
                    }
                }
                XmlNode node3 = node.SelectSingleNode("ReportExcel");
                if (node3 != null)
                {
                    XmlAttribute attribute2 = node3.Attributes["FileName"];
                    if (attribute2 != null)
                    {
                        this.string_1 = attribute2.Value;
                    }
                }
                XmlNode node4 = node.SelectSingleNode("Mail");
                if (node4 != null)
                {
                    XmlAttribute attribute3 = node4.Attributes["FileName"];
                    if (attribute3 != null)
                    {
                        this.string_2 = attribute3.Value;
                    }
                    attribute3 = node4.Attributes["Subject"];
                    if (attribute3 != null)
                    {
                        this.string_3 = attribute3.Value;
                    }
                    attribute3 = node4.Attributes["Body"];
                    if (attribute3 != null)
                    {
                        this.string_4 = attribute3.Value;
                    }
                    XmlNode node5 = node4.SelectSingleNode("SMTP");
                    if (node5 != null)
                    {
                        attribute3 = node5.Attributes["Name"];
                        if (attribute3 != null)
                        {
                            this.string_5 = attribute3.Value;
                        }
                        attribute3 = node5.Attributes["port"];
                        if (attribute3 != null)
                        {
                            this.int_0 = Convert.ToInt32(attribute3.Value);
                        }
                        attribute3 = node5.Attributes["Login"];
                        if (attribute3 != null)
                        {
                            this.string_6 = smethod_1(attribute3.Value);
                        }
                        attribute3 = node5.Attributes["Password"];
                        if (attribute3 != null)
                        {
                            this.string_7 = smethod_1(attribute3.Value);
                        }
                    }
                    XmlNode node6 = node4.SelectSingleNode("Sender");
                    if (node6 != null)
                    {
                        attribute3 = node6.Attributes["Address"];
                        if (attribute3 != null)
                        {
                            this.string_8 = attribute3.Value;
                        }
                        attribute3 = node6.Attributes["Name"];
                        if (attribute3 != null)
                        {
                            this.string_9 = attribute3.Value;
                        }
                    }
                    XmlNode node7 = node4.SelectSingleNode("Recipient");
                    if (node7 != null)
                    {
                        attribute3 = node7.Attributes["Address"];
                        if (attribute3 != null)
                        {
                            this.string_10 = attribute3.Value;
                        }
                        attribute3 = node7.Attributes["Name"];
                        if (attribute3 != null)
                        {
                            this.string_11 = attribute3.Value;
                        }
                    }
                }
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (ExportRequestForRepair.smethod_5(this.SqlSettings, this.string_0, this.dateTimePicker_1.Value, this.dateTimePicker_0.Value))
            {
                MessageBox.Show("Файл " + this.string_0 + " создан");
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            this.saveFileDialog_0.FileName = this.string_0;
            if (this.saveFileDialog_0.ShowDialog() == DialogResult.OK)
            {
                this.textBox_0.Text = this.saveFileDialog_0.FileName;
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (ExportRequestForRepair.smethod_7(this.SqlSettings, this.string_1, this.dateTimePicker_2.Value, this.bool_0))
            {
                MessageBox.Show("Файл " + this.string_1 + " создан");
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            this.saveFileDialog_1.FileName = this.string_1;
            if (this.saveFileDialog_1.ShowDialog() == DialogResult.OK)
            {
                this.textBox_1.Text = this.saveFileDialog_1.FileName;
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            List<Struct4> list = new List<Struct4> {
            new Struct4(this.string_10, this.string_11)
        };
            List<string> list2 = new List<string> {
            this.string_2
        };
            if (ExportRequestForRepair.smethod_13(this.string_5, this.int_0, this.string_6, this.string_7, this.string_8, this.string_9, list, this.string_3, this.string_4, list2, false))
            {
                MessageBox.Show("Сообщение успешно отправлено");
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            this.openFileDialog_0.FileName = this.string_2;
            if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
            {
                this.textBox_3.Text = this.openFileDialog_0.FileName;
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            string str = ".html";
            string str2 = @"d:\temp\req\";
            for (DateTime time = new DateTime(0x7de, 7, 4); time <= new DateTime(0x7de, 7, 13); time = time.AddDays(1.0))
            {
                string introduced4 = str2 + time.ToString("yyyyMMdd") + str;
                DateTime introduced5 = time.AddDays(1.0);
                ExportRequestForRepair.smethod_4(this.SqlSettings, introduced4, introduced5, time.AddDays(9.0).AddSeconds(-1.0), this.bool_0);
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
            node.Value = this.string_0;
            node3.Attributes.Append(node);
            XmlNode node4 = document1.CreateElement("ReportExcel");
            node2.AppendChild(node4);
            node = document1.CreateAttribute("FileName");
            node.Value = this.string_1;
            node4.Attributes.Append(node);
            XmlNode node5 = document1.CreateElement("Mail");
            node2.AppendChild(node5);
            node = document1.CreateAttribute("FileName");
            node.Value = this.string_2;
            node5.Attributes.Append(node);
            node = document1.CreateAttribute("Subject");
            node.Value = this.string_3;
            node5.Attributes.Append(node);
            node = document1.CreateAttribute("Body");
            node.Value = this.string_4;
            node5.Attributes.Append(node);
            XmlNode node6 = document1.CreateElement("SMTP");
            node5.AppendChild(node6);
            node = document1.CreateAttribute("Name");
            node.Value = this.string_5;
            node6.Attributes.Append(node);
            node = document1.CreateAttribute("port");
            node.Value = this.int_0.ToString();
            node6.Attributes.Append(node);
            node = document1.CreateAttribute("Login");
            node.Value = smethod_0(this.string_6);
            node6.Attributes.Append(node);
            node = document1.CreateAttribute("Password");
            node.Value = smethod_0(this.string_7);
            node6.Attributes.Append(node);
            XmlNode node7 = document1.CreateElement("Sender");
            node5.AppendChild(node7);
            node = document1.CreateAttribute("Address");
            node.Value = this.string_8;
            node7.Attributes.Append(node);
            node = document1.CreateAttribute("Name");
            node.Value = this.string_9;
            node7.Attributes.Append(node);
            XmlNode node8 = document1.CreateElement("Recipient");
            node5.AppendChild(node8);
            node = document1.CreateAttribute("Address");
            node.Value = this.string_10;
            node8.Attributes.Append(node);
            node = document1.CreateAttribute("Name");
            node.Value = this.string_11;
            node8.Attributes.Append(node);
            return document1;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form42_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void Form42_Load(object sender, EventArgs e)
        {
            base.LoadFormConfig(null);
            this.textBox_0.Text = this.string_0;
            this.textBox_1.Text = this.string_1;
            this.textBox_3.Text = this.string_2;
            this.textBox_2.Text = this.string_3;
            this.richTextBox_0.Text = this.string_4;
            this.textBox_10.Text = this.string_5;
            this.textBox_9.Text = this.int_0.ToString();
            this.textBox_6.Text = this.string_6;
            this.textBox_11.Text = this.string_7;
            this.textBox_5.Text = this.string_8;
            this.textBox_8.Text = this.string_9;
            this.textBox_4.Text = this.string_10;
            this.textBox_7.Text = this.string_11;
            this.dateTimePicker_1.Value = DateTime.Now.Date;
            this.dateTimePicker_0.Value = DateTime.Now.Date.AddDays(7.0);
            this.dateTimePicker_2.Value = DateTime.Now.Date;
        }

        private void method_0()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormExportRequestForRepair));
            this.groupBox_0 = new GroupBox();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_1 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.label_2 = new Label();
            this.button_0 = new Button();
            this.buttonHTML = new Button();
            this.textBox_0 = new TextBox();
            this.label_0 = new Label();
            this.saveFileDialog_0 = new SaveFileDialog();
            this.groupBox_1 = new GroupBox();
            this.dateTimePicker_2 = new DateTimePicker();
            this.label_3 = new Label();
            this.button_2 = new Button();
            this.button_3 = new Button();
            this.textBox_1 = new TextBox();
            this.label_4 = new Label();
            this.saveFileDialog_1 = new SaveFileDialog();
            this.groupBox_2 = new GroupBox();
            this.button_4 = new Button();
            this.richTextBox_0 = new RichTextBox();
            this.label_5 = new Label();
            this.textBox_2 = new TextBox();
            this.label_6 = new Label();
            this.button_5 = new Button();
            this.textBox_3 = new TextBox();
            this.label_7 = new Label();
            this.splitContainer_0 = new SplitContainer();
            this.textBox_4 = new TextBox();
            this.label_8 = new Label();
            this.textBox_5 = new TextBox();
            this.label_9 = new Label();
            this.textBox_6 = new TextBox();
            this.label_10 = new Label();
            this.textBox_11 = new TextBox();
            this.textBox_7 = new TextBox();
            this.label_11 = new Label();
            this.textBox_8 = new TextBox();
            this.label_12 = new Label();
            this.label_13 = new Label();
            this.textBox_9 = new TextBox();
            this.label_14 = new Label();
            this.textBox_10 = new TextBox();
            this.label_15 = new Label();
            this.openFileDialog_0 = new OpenFileDialog();
            this.button_6 = new Button();
            this.groupBox_0.SuspendLayout();
            this.groupBox_1.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            base.SuspendLayout();
            this.groupBox_0.Controls.Add(this.dateTimePicker_0);
            this.groupBox_0.Controls.Add(this.label_1);
            this.groupBox_0.Controls.Add(this.dateTimePicker_1);
            this.groupBox_0.Controls.Add(this.label_2);
            this.groupBox_0.Controls.Add(this.button_0);
            this.groupBox_0.Controls.Add(this.buttonHTML);
            this.groupBox_0.Controls.Add(this.textBox_0);
            this.groupBox_0.Controls.Add(this.label_0);
            this.groupBox_0.Location = new Point(1, 2);
            this.groupBox_0.Name = "groupBoxHTML";
            this.groupBox_0.Size = new Size(0x137, 0x86);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "HTML";
            this.dateTimePicker_0.Location = new Point(0xae, 0x21);
            this.dateTimePicker_0.Name = "dateTimePickerHTMLEnd";
            this.dateTimePicker_0.Size = new Size(0x83, 20);
            this.dateTimePicker_0.TabIndex = 7;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(0xab, 0x10);
            this.label_1.Name = "label3";
            this.label_1.Size = new Size(0x13, 13);
            this.label_1.TabIndex = 6;
            this.label_1.Text = "до";
            this.dateTimePicker_1.Location = new Point(14, 0x21);
            this.dateTimePicker_1.Name = "dateTimePickerHTMLBeg";
            this.dateTimePicker_1.Size = new Size(0x8d, 20);
            this.dateTimePicker_1.TabIndex = 5;
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(11, 0x10);
            this.label_2.Name = "label2";
            this.label_2.Size = new Size(0x2f, 13);
            this.label_2.TabIndex = 4;
            this.label_2.Text = "Дата от";
            this.button_0.Location = new Point(11, 0x69);
            this.button_0.Name = "buttonCreateHTML";
            this.button_0.Size = new Size(0x65, 0x17);
            this.button_0.TabIndex = 3;
            this.button_0.Text = "Сформировать";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.buttonHTML.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.buttonHTML.Location = new Point(0x119, 0x4e);
            this.buttonHTML.Name = "buttonHTML";
            this.buttonHTML.Size = new Size(0x1a, 0x17);
            this.buttonHTML.TabIndex = 2;
            this.buttonHTML.Text = "...";
            this.buttonHTML.UseVisualStyleBackColor = true;
            this.buttonHTML.Click += new EventHandler(this.button_1_Click);
            this.textBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_0.Location = new Point(11, 0x4f);
            this.textBox_0.Name = "textBoxHTML";
            this.textBox_0.Size = new Size(0x112, 20);
            this.textBox_0.TabIndex = 1;
            this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(11, 0x3f);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x40, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Имя файла";
            this.saveFileDialog_0.Filter = "HTML Files (*.html)|*.html";
            this.groupBox_1.Controls.Add(this.dateTimePicker_2);
            this.groupBox_1.Controls.Add(this.label_3);
            this.groupBox_1.Controls.Add(this.button_2);
            this.groupBox_1.Controls.Add(this.button_3);
            this.groupBox_1.Controls.Add(this.textBox_1);
            this.groupBox_1.Controls.Add(this.label_4);
            this.groupBox_1.Location = new Point(1, 0xe2);
            this.groupBox_1.Name = "groupBox1";
            this.groupBox_1.Size = new Size(0x137, 0x86);
            this.groupBox_1.TabIndex = 1;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "Excel";
            this.dateTimePicker_2.Location = new Point(14, 0x21);
            this.dateTimePicker_2.Name = "dateTimePickerExcel";
            this.dateTimePicker_2.Size = new Size(0x8d, 20);
            this.dateTimePicker_2.TabIndex = 5;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(11, 0x10);
            this.label_3.Name = "label5";
            this.label_3.Size = new Size(0x21, 13);
            this.label_3.TabIndex = 4;
            this.label_3.Text = "Дата";
            this.button_2.Location = new Point(11, 0x69);
            this.button_2.Name = "buttonCreateExcel";
            this.button_2.Size = new Size(0x65, 0x17);
            this.button_2.TabIndex = 3;
            this.button_2.Text = "Сформировать";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new EventHandler(this.button_2_Click);
            this.button_3.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.button_3.Location = new Point(0x119, 0x4d);
            this.button_3.Name = "buttonExcel";
            this.button_3.Size = new Size(0x1a, 0x17);
            this.button_3.TabIndex = 2;
            this.button_3.Text = "...";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new EventHandler(this.button_3_Click);
            this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_1.Location = new Point(11, 0x4f);
            this.textBox_1.Name = "textBoxExcel";
            this.textBox_1.Size = new Size(0x112, 20);
            this.textBox_1.TabIndex = 1;
            this.textBox_1.TextChanged += new EventHandler(this.textBox_1_TextChanged);
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(11, 0x3f);
            this.label_4.Name = "label6";
            this.label_4.Size = new Size(0x40, 13);
            this.label_4.TabIndex = 0;
            this.label_4.Text = "Имя файла";
            this.saveFileDialog_1.Filter = "Excel Files (*.xls)|*.xls";
            this.groupBox_2.Controls.Add(this.button_4);
            this.groupBox_2.Controls.Add(this.richTextBox_0);
            this.groupBox_2.Controls.Add(this.label_5);
            this.groupBox_2.Controls.Add(this.textBox_2);
            this.groupBox_2.Controls.Add(this.label_6);
            this.groupBox_2.Controls.Add(this.button_5);
            this.groupBox_2.Controls.Add(this.textBox_3);
            this.groupBox_2.Controls.Add(this.label_7);
            this.groupBox_2.Controls.Add(this.splitContainer_0);
            this.groupBox_2.Controls.Add(this.textBox_9);
            this.groupBox_2.Controls.Add(this.label_14);
            this.groupBox_2.Controls.Add(this.textBox_10);
            this.groupBox_2.Controls.Add(this.label_15);
            this.groupBox_2.Location = new Point(0x13a, 2);
            this.groupBox_2.Name = "groupBoxMail";
            this.groupBox_2.Size = new Size(0x1ac, 360);
            this.groupBox_2.TabIndex = 2;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "Почта";
            this.button_4.Location = new Point(14, 0x14e);
            this.button_4.Name = "buttonSendMail";
            this.button_4.Size = new Size(0x4b, 0x17);
            this.button_4.TabIndex = 12;
            this.button_4.Text = "Отправить";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new EventHandler(this.button_4_Click);
            this.richTextBox_0.Location = new Point(14, 0x116);
            this.richTextBox_0.Name = "textBoxBodyMail";
            this.richTextBox_0.Size = new Size(0x199, 50);
            this.richTextBox_0.TabIndex = 11;
            this.richTextBox_0.Text = "";
            this.richTextBox_0.TextChanged += new EventHandler(this.richTextBox_0_TextChanged);
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(11, 0x107);
            this.label_5.Name = "label16";
            this.label_5.Size = new Size(0x4e, 13);
            this.label_5.TabIndex = 10;
            this.label_5.Text = "Текст письма";
            this.textBox_2.Location = new Point(14, 240);
            this.textBox_2.Name = "textBoxSubjectMail";
            this.textBox_2.Size = new Size(0x199, 20);
            this.textBox_2.TabIndex = 9;
            this.textBox_2.TextChanged += new EventHandler(this.textBox_2_TextChanged);
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(11, 0xe0);
            this.label_6.Name = "label15";
            this.label_6.Size = new Size(0x4b, 13);
            this.label_6.TabIndex = 8;
            this.label_6.Text = "Тема письма";
            this.button_5.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.button_5.Location = new Point(0x18e, 0xc6);
            this.button_5.Name = "buttonFileMail";
            this.button_5.Size = new Size(0x1a, 0x17);
            this.button_5.TabIndex = 7;
            this.button_5.Text = "...";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new EventHandler(this.button_5_Click);
            this.textBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_3.Location = new Point(14, 0xc9);
            this.textBox_3.Name = "textBoxFileNameMail";
            this.textBox_3.Size = new Size(0x180, 20);
            this.textBox_3.TabIndex = 6;
            this.textBox_3.TextChanged += new EventHandler(this.textBox_3_TextChanged);
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(11, 0xb9);
            this.label_7.Name = "label14";
            this.label_7.Size = new Size(0x40, 13);
            this.label_7.TabIndex = 5;
            this.label_7.Text = "Имя файла";
            this.splitContainer_0.IsSplitterFixed = true;
            this.splitContainer_0.Location = new Point(0, 0x3a);
            this.splitContainer_0.Name = "splitContainer1";
            this.splitContainer_0.Panel1.Controls.Add(this.textBox_4);
            this.splitContainer_0.Panel1.Controls.Add(this.label_8);
            this.splitContainer_0.Panel1.Controls.Add(this.textBox_5);
            this.splitContainer_0.Panel1.Controls.Add(this.label_9);
            this.splitContainer_0.Panel1.Controls.Add(this.textBox_6);
            this.splitContainer_0.Panel1.Controls.Add(this.label_10);
            this.splitContainer_0.Panel2.Controls.Add(this.textBox_11);
            this.splitContainer_0.Panel2.Controls.Add(this.textBox_7);
            this.splitContainer_0.Panel2.Controls.Add(this.label_11);
            this.splitContainer_0.Panel2.Controls.Add(this.textBox_8);
            this.splitContainer_0.Panel2.Controls.Add(this.label_12);
            this.splitContainer_0.Panel2.Controls.Add(this.label_13);
            this.splitContainer_0.Size = new Size(0x1ab, 0x7c);
            this.splitContainer_0.SplitterDistance = 0xd3;
            this.splitContainer_0.SplitterWidth = 1;
            this.splitContainer_0.TabIndex = 4;
            this.textBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_4.Location = new Point(14, 0x5e);
            this.textBox_4.Name = "textBoxRecipientAddress";
            this.textBox_4.Size = new Size(0xc2, 20);
            this.textBox_4.TabIndex = 5;
            this.textBox_4.TextChanged += new EventHandler(this.textBox_4_TextChanged);
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(11, 0x4e);
            this.label_8.Name = "label12";
            this.label_8.Size = new Size(0x62, 13);
            this.label_8.TabIndex = 4;
            this.label_8.Text = "Адрес получателя";
            this.textBox_5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_5.Location = new Point(14, 0x37);
            this.textBox_5.Name = "textBoxSenderAddress";
            this.textBox_5.Size = new Size(0xc2, 20);
            this.textBox_5.TabIndex = 3;
            this.textBox_5.TextChanged += new EventHandler(this.textBox_5_TextChanged);
            this.label_9.AutoSize = true;
            this.label_9.Location = new Point(11, 0x27);
            this.label_9.Name = "label10";
            this.label_9.Size = new Size(0x69, 13);
            this.label_9.TabIndex = 2;
            this.label_9.Text = "Адрес отправителя";
            this.textBox_6.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_6.Location = new Point(14, 0x10);
            this.textBox_6.Name = "textBoxLogin";
            this.textBox_6.Size = new Size(0xc2, 20);
            this.textBox_6.TabIndex = 1;
            this.textBox_6.TextChanged += new EventHandler(this.textBox_6_TextChanged);
            this.label_10.AutoSize = true;
            this.label_10.Location = new Point(11, 0);
            this.label_10.Name = "label8";
            this.label_10.Size = new Size(0x26, 13);
            this.label_10.TabIndex = 0;
            this.label_10.Text = "Логин";
            this.textBox_11.Location = new Point(6, 0x10);
            this.textBox_11.Name = "textBoxPassword";
            this.textBox_11.PasswordChar = '☻';
            this.textBox_11.Size = new Size(0xce, 20);
            this.textBox_11.TabIndex = 8;
            this.textBox_11.TextChanged += new EventHandler(this.textBox_11_TextChanged);
            this.textBox_7.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_7.Location = new Point(6, 0x5e);
            this.textBox_7.Name = "textBoxRecipientName";
            this.textBox_7.Size = new Size(0xcd, 20);
            this.textBox_7.TabIndex = 7;
            this.textBox_7.TextChanged += new EventHandler(this.textBox_7_TextChanged);
            this.label_11.AutoSize = true;
            this.label_11.Location = new Point(3, 0x4e);
            this.label_11.Name = "label13";
            this.label_11.Size = new Size(0x59, 13);
            this.label_11.TabIndex = 6;
            this.label_11.Text = "Имя получателя";
            this.textBox_8.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_8.Location = new Point(6, 0x37);
            this.textBox_8.Name = "textBoxSenderName";
            this.textBox_8.Size = new Size(0xcd, 20);
            this.textBox_8.TabIndex = 5;
            this.textBox_8.TextChanged += new EventHandler(this.textBox_8_TextChanged);
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
            this.textBox_9.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_9.Location = new Point(0x148, 0x20);
            this.textBox_9.Name = "textBoxSmtpPort";
            this.textBox_9.Size = new Size(0x60, 20);
            this.textBox_9.TabIndex = 3;
            this.textBox_9.TextChanged += new EventHandler(this.textBox_9_TextChanged);
            this.textBox_9.KeyPress += new KeyPressEventHandler(this.textBox_9_KeyPress);
            this.label_14.AutoSize = true;
            this.label_14.Location = new Point(0x147, 0x10);
            this.label_14.Name = "label7";
            this.label_14.Size = new Size(0x20, 13);
            this.label_14.TabIndex = 2;
            this.label_14.Text = "Порт";
            this.textBox_10.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_10.Location = new Point(11, 0x20);
            this.textBox_10.Name = "textBoxSmtoServer";
            this.textBox_10.Size = new Size(0x127, 20);
            this.textBox_10.TabIndex = 1;
            this.textBox_10.TextChanged += new EventHandler(this.textBox_10_TextChanged);
            this.label_15.AutoSize = true;
            this.label_15.Location = new Point(8, 0x10);
            this.label_15.Name = "label4";
            this.label_15.Size = new Size(0x5e, 13);
            this.label_15.TabIndex = 0;
            this.label_15.Text = "Сервер отправки";
            this.button_6.Location = new Point(12, 0x97);
            this.button_6.Name = "button1";
            this.button_6.Size = new Size(0x65, 0x17);
            this.button_6.TabIndex = 3;
            this.button_6.Text = "button1";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Visible = false;
            this.button_6.Click += new EventHandler(this.button_6_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x2e8, 0x170);
            base.Controls.Add(this.button_6);
            base.Controls.Add(this.groupBox_2);
            base.Controls.Add(this.groupBox_1);
            base.Controls.Add(this.groupBox_0);
            base.Icon = (Icon)manager.GetObject("$this.Icon");
            this.MinimumSize = new Size(760, 0x196);
            base.Name = "FormExportRequestForRepair";
            this.Text = "Экспорт заявок на ремонт оборудования";
            base.FormClosing += new FormClosingEventHandler(this.Form42_FormClosing);
            base.Load += new EventHandler(this.Form42_Load);
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_2.PerformLayout();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.Panel2.PerformLayout();
            this.splitContainer_0.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void richTextBox_0_TextChanged(object sender, EventArgs e)
        {
            this.string_4 = this.richTextBox_0.Text;
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

        private void textBox_0_TextChanged(object sender, EventArgs e)
        {
            this.string_0 = this.textBox_0.Text;
        }

        private void textBox_1_TextChanged(object sender, EventArgs e)
        {
            this.string_1 = this.textBox_1.Text;
        }

        private void textBox_10_TextChanged(object sender, EventArgs e)
        {
            this.string_5 = this.textBox_10.Text;
        }

        private void textBox_11_TextChanged(object sender, EventArgs e)
        {
            this.string_7 = this.textBox_11.Text;
        }

        private void textBox_2_TextChanged(object sender, EventArgs e)
        {
            this.string_3 = this.textBox_2.Text;
        }

        private void textBox_3_TextChanged(object sender, EventArgs e)
        {
            this.string_2 = this.textBox_3.Text;
        }

        private void textBox_4_TextChanged(object sender, EventArgs e)
        {
            this.string_10 = this.textBox_4.Text;
        }

        private void textBox_5_TextChanged(object sender, EventArgs e)
        {
            this.string_8 = this.textBox_5.Text;
        }

        private void textBox_6_TextChanged(object sender, EventArgs e)
        {
            this.string_6 = this.textBox_6.Text;
        }

        private void textBox_7_TextChanged(object sender, EventArgs e)
        {
            this.string_11 = this.textBox_7.Text;
        }

        private void textBox_8_TextChanged(object sender, EventArgs e)
        {
            this.string_9 = this.textBox_8.Text;
        }

        private void textBox_9_KeyPress(object sender, KeyPressEventArgs e)
        {
            int result = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out result);
        }

        private void textBox_9_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox_9.Text))
            {
                this.int_0 = 0;
            }
            else
            {
                this.int_0 = Convert.ToInt32(this.textBox_9.Text);
            }
        }
    }

}