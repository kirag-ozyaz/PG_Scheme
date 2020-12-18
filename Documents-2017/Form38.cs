using Documents.DataSets;
using FormLbr;
using FormLbr.Classes;
using MarkupConverter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;

internal class Form38 : FormBase
{
    private Button button_0;
    private Button button_1;
    private static byte[] byte_0 = Encoding.ASCII.GetBytes("jf8hSDJH");
    private CheckBox checkBox_0;
    private DataGridView dataGridView_0;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataSetGES dataSetGES_0;
    private IContainer icontainer_0;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private Label label_4;
    private Label label_5;
    private Label label_6;
    private int? nullable_0;
    private object object_0;
    private SplitContainer splitContainer_0;
    private TextBox textBox_0;
    private TextBox textBox_1;
    private TextBox textBox_2;
    private TextBox textBox_3;
    private TextBox textBox_4;
    private TextBox textBox_5;
    private TextBox textBox_6;

    internal Form38(int? nullable_1 = new int?())
    {
        this.method_6();
        this.nullable_0 = nullable_1;
    }

    protected override void ApplyConfig(XmlDocument xmlDocument_0)
    {
        this.dataGridView_0.Rows.Clear();
        XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
        if (node != null)
        {
            XmlNode node2 = node.SelectSingleNode("Mail");
            if (node2 != null)
            {
                XmlNode node3 = node2.SelectSingleNode("SMTP");
                if (node3 != null)
                {
                    XmlAttribute attribute = node3.Attributes["Name"];
                    if (attribute != null)
                    {
                        this.textBox_6.Text = attribute.Value;
                    }
                    attribute = node3.Attributes["Port"];
                    if (attribute != null)
                    {
                        this.textBox_5.Text = attribute.Value;
                    }
                    attribute = node3.Attributes["Login"];
                    if (attribute != null)
                    {
                        this.textBox_2.Text = attribute.Value;
                    }
                    attribute = node3.Attributes["Password"];
                    if (attribute != null)
                    {
                        this.textBox_3.Text = smethod_1(attribute.Value);
                    }
                    XmlNode node4 = node2.SelectSingleNode("Sender");
                    if (node4 != null)
                    {
                        attribute = node4.Attributes["Address"];
                        if (attribute != null)
                        {
                            this.textBox_1.Text = attribute.Value;
                        }
                        attribute = node4.Attributes["Name"];
                        if (attribute != null)
                        {
                            this.textBox_4.Text = attribute.Value;
                        }
                        XmlNode node5 = node2.SelectSingleNode("Recipients");
                        if (node5 != null)
                        {
                            XmlNodeList list = node5.SelectNodes("Recipient");
                            if (list != null)
                            {
                                using (IEnumerator enumerator = list.GetEnumerator())
                                {
                                    while (enumerator.MoveNext())
                                    {
                                        object obj2 = -1;
                                        object obj3 = "";
                                        XmlNode current = (XmlNode) enumerator.Current;
                                        attribute = current.Attributes["Address"];
                                        if (attribute != null)
                                        {
                                            obj3 = attribute.Value;
                                        }
                                        attribute = current.Attributes["Name"];
                                        if (attribute != null)
                                        {
                                            obj2 = attribute.Value;
                                        }
                                        bool flag = false;
                                        attribute = current.Attributes["IsSend"];
                                        if (attribute != null)
                                        {
                                            flag = Convert.ToBoolean(attribute.Value);
                                        }
                                        this.dataGridView_0.Rows.Add(1);
                                        if (!((DataGridViewComboBoxCell) this.dataGridView_0.Rows[this.dataGridView_0.Rows.Count - 2].Cells[this.dataGridViewComboBoxColumn_0.Name]).Items.Contains(obj2))
                                        {
                                            ((DataGridViewComboBoxCell) this.dataGridView_0.Rows[this.dataGridView_0.Rows.Count - 2].Cells[this.dataGridViewComboBoxColumn_0.Name]).Items.Add(obj2);
                                        }
                                        this.dataGridView_0.Rows[this.dataGridView_0.Rows.Count - 2].Cells[this.dataGridViewComboBoxColumn_0.Name].Value = obj2;
                                        this.dataGridView_0.Rows[this.dataGridView_0.Rows.Count - 2].Cells[this.dataGridViewTextBoxColumn_0.Name].Value = obj3;
                                        this.dataGridView_0.Rows[this.dataGridView_0.Rows.Count - 2].Cells[this.dataGridViewCheckBoxColumn_0.Name].Value = flag;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        if (this.method_3(false))
        {
            if (this.nullable_0.HasValue)
            {
                DataSetGES.tJ_RequestDataTable table = new DataSetGES.tJ_RequestDataTable();
                base.SelectSqlData(table, true, " where id = " + this.nullable_0.ToString(), false);
                if (table.Rows.Count > 0)
                {
                    DataTable table2 = new DataTable("tUser");
                    table2.Columns.Add("Login", typeof(string));
                    table2.Columns.Add("name", typeof(string));
                    base.SelectSqlData(table2, true, " where [Login] = SYSTEM_USER ", false);
                    string str = "неопределено";
                    if (table2.Rows.Count > 0)
                    {
                        if (table2.Rows[0]["name"] != DBNull.Value)
                        {
                            str = table2.Rows[0]["name"].ToString();
                        }
                        else
                        {
                            str = table2.Rows[0]["login"].ToString();
                        }
                    }
                    table.Rows[0]["dateSendMail"] = DateTime.Now;
                    table.Rows[0]["fioSendMail"] = str;
                    table.Rows[0].EndEdit();
                    base.UpdateSqlData(table);
                }
            }
            base.DialogResult = DialogResult.OK;
            base.Close();
        }
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    protected override XmlDocument CreateXmlConfig()
    {
        XmlDocument document = new XmlDocument();
        XmlNode newChild = document.CreateElement(base.Name);
        document.AppendChild(newChild);
        XmlNode node2 = document.CreateElement("Mail");
        newChild.AppendChild(node2);
        XmlAttribute node = document.CreateAttribute("Subject");
        node.Value = this.textBox_0.Text;
        node2.Attributes.Append(node);
        XmlNode node3 = document.CreateElement("SMTP");
        node2.AppendChild(node3);
        node = document.CreateAttribute("Name");
        node.Value = this.textBox_6.Text;
        node3.Attributes.Append(node);
        node = document.CreateAttribute("Port");
        node.Value = this.textBox_5.Text;
        node3.Attributes.Append(node);
        node = document.CreateAttribute("Login");
        node.Value = this.textBox_2.Text;
        node3.Attributes.Append(node);
        node = document.CreateAttribute("Password");
        node.Value = smethod_0(this.textBox_3.Text);
        node3.Attributes.Append(node);
        XmlNode node4 = document.CreateElement("Sender");
        node2.AppendChild(node4);
        node = document.CreateAttribute("Address");
        node.Value = this.textBox_1.Text;
        node4.Attributes.Append(node);
        node = document.CreateAttribute("Name");
        node.Value = this.textBox_4.Text;
        node4.Attributes.Append(node);
        XmlNode node5 = document.CreateElement("Recipients");
        node2.AppendChild(node5);
        for (int i = 0; i < (this.dataGridView_0.Rows.Count - 1); i++)
        {
            XmlNode node6 = document.CreateElement("Recipient");
            node5.AppendChild(node6);
            node = document.CreateAttribute("Address");
            if (this.dataGridView_0[this.dataGridViewTextBoxColumn_0.Name, i].Value == null)
            {
                node.Value = "";
            }
            else
            {
                node.Value = this.dataGridView_0[this.dataGridViewTextBoxColumn_0.Name, i].Value.ToString();
            }
            node6.Attributes.Append(node);
            node = document.CreateAttribute("Name");
            node.Value = this.dataGridView_0[this.dataGridViewComboBoxColumn_0.Name, i].Value.ToString();
            node6.Attributes.Append(node);
            node = document.CreateAttribute("IsSend");
            if ((this.dataGridView_0[this.dataGridViewCheckBoxColumn_0.Name, i].Value != null) && Convert.ToBoolean(this.dataGridView_0[this.dataGridViewCheckBoxColumn_0.Name, i].Value))
            {
                bool flag = true;
                node.Value = flag.ToString();
            }
            else
            {
                node.Value = false.ToString();
            }
            node6.Attributes.Append(node);
        }
        return document;
    }

    private void dataGridView_0_CellValidated(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == this.dataGridView_0.Columns[this.dataGridViewComboBoxColumn_0.Name].Index)
        {
            (this.dataGridView_0.CurrentCell as DataGridViewComboBoxCell).Value = this.object_0;
        }
    }

    private void dataGridView_0_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
    {
        if (e.ColumnIndex == this.dataGridView_0.Columns[this.dataGridViewComboBoxColumn_0.Name].Index)
        {
            DataGridViewComboBoxCell currentCell = this.dataGridView_0.CurrentCell as DataGridViewComboBoxCell;
            if (currentCell != null)
            {
                if (!currentCell.Items.Contains(e.FormattedValue))
                {
                    currentCell.Items.Insert(0, e.FormattedValue);
                    if (this.dataGridView_0.IsCurrentCellDirty)
                    {
                        this.dataGridView_0.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    }
                    currentCell.Value = e.FormattedValue;
                    this.object_0 = e.FormattedValue;
                }
                else
                {
                    this.object_0 = e.FormattedValue;
                }
            }
        }
    }

    private void dataGridView_0_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
        if (e.Control is ComboBox)
        {
            (e.Control as ComboBox).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            (e.Control as ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems;
            if ((e.Control as ComboBox).DropDownStyle != ComboBoxStyle.DropDown)
            {
                (e.Control as ComboBox).DropDownStyle = ComboBoxStyle.DropDown;
            }
            (e.Control as ComboBox).SelectedValueChanged -= new EventHandler(this.method_2);
            (e.Control as ComboBox).SelectedValueChanged += new EventHandler(this.method_2);
            (e.Control as ComboBox).SelectedIndexChanged -= new EventHandler(this.method_2);
            (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(this.method_2);
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form38_FormClosing(object sender, FormClosingEventArgs e)
    {
        base.SaveFormConfig(null);
    }

    private void Form38_Load(object sender, EventArgs e)
    {
        this.method_1();
        base.LoadFormConfig(null);
        if (this.nullable_0.HasValue)
        {
            this.textBox_0.Text = this.textBox_0.Text + this.nullable_0.ToString();
        }
    }

    internal int? method_0()
    {
        return this.nullable_0;
    }

    private void method_1()
    {
        DataTable table = new DataTable("vR_worker");
        table.Columns.Add(new DataColumn("id", typeof(int)));
        table.Columns.Add(new DataColumn("fio", typeof(string)));
        new BindingSource().DataSource = table;
        base.SelectSqlData(table, true, "where dateEnd is null order by fio", false);
        foreach (DataRow row in table.Rows)
        {
            this.dataGridViewComboBoxColumn_0.Items.Add(row["fio"].ToString());
        }
    }

    private void method_2(object sender, EventArgs e)
    {
        if ((this.dataGridView_0.CurrentCell != null) && (((ComboBox) sender).SelectedItem != null))
        {
            DataTable table = base.SelectSqlData("tR_WorkerContact", true, " left join  vr_worker v on tr_workercontact.worker = v.id where v.fio = '" + ((ComboBox) sender).SelectedItem.ToString() + "' and tr_workercontact.Type = 44");
            if ((table.Rows.Count > 0) && (table.Rows[0]["Description"] != DBNull.Value))
            {
                this.dataGridView_0[this.dataGridViewTextBoxColumn_0.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = table.Rows[0]["Description"].ToString();
            }
            else
            {
                this.dataGridView_0[this.dataGridViewTextBoxColumn_0.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = "адрес не задан";
            }
            this.dataGridView_0[this.dataGridViewCheckBoxColumn_0.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = false;
        }
    }

    private bool method_3(bool bool_0 = false)
    {
        try
        {
            if ((this.dataGridView_0.Rows.Count > 0) && this.nullable_0.HasValue)
            {
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_Request, true, " where id = " + this.nullable_0.ToString());
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_Request, true, " where id = " + this.nullable_0.ToString());
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestDoc, true, "where idRequest = " + this.nullable_0.ToString());
                if (this.dataSetGES_0.vJ_Request.Rows.Count <= 0)
                {
                    return false;
                }
                string str = ((("<b>Постановщик:</b> " + this.dataSetGES_0.vJ_Request.Rows[0]["nameUserTask"].ToString() + "<br>") + "<b>Дата:</b> " + Convert.ToDateTime(this.dataSetGES_0.vJ_Request.Rows[0]["dateTask"]).ToString() + "<br>") + "<b>Модуль:</b> " + this.dataSetGES_0.vJ_Request.Rows[0]["nameModul"].ToString() + "<br>") + "<b>Кому:</b> " + this.dataSetGES_0.vJ_Request.Rows[0]["nameuserWhom"].ToString() + "<br>";
                if (this.dataSetGES_0.tJ_Request.Rows[0]["TextTaskBin"] != DBNull.Value)
                {
                    str = str + "<b>Текст задачи:</b><br> " + RtfToHtmlConverter.ConvertRtfToHtml(smethod_2((byte[]) this.dataSetGES_0.tJ_Request.Rows[0]["TextTaskBin"]));
                }
                else
                {
                    str = str + "<b>Текст задачи:</b><br> " + this.dataSetGES_0.vJ_Request.Rows[0]["TextTask"].ToString() + "<br><br><br>";
                }
                if (this.dataSetGES_0.vJ_Request.Rows[0]["nameUserPerfom"] != DBNull.Value)
                {
                    str = str + "<b>Исполнитель:</b> " + this.dataSetGES_0.vJ_Request.Rows[0]["nameUserPerfom"].ToString() + "<br>";
                    if (this.dataSetGES_0.vJ_Request.Rows[0]["datePerfom"] != DBNull.Value)
                    {
                        str = str + "<b>Дата:</b> " + Convert.ToDateTime(this.dataSetGES_0.vJ_Request.Rows[0]["datePerfom"]).ToString() + "<br>";
                    }
                    if (this.dataSetGES_0.vJ_Request.Rows[0]["Comment"] != DBNull.Value)
                    {
                        str = str + "<b>Резюме:</b><br> " + this.dataSetGES_0.vJ_Request.Rows[0]["Comment"].ToString();
                    }
                }
                List<string> list = this.method_5(this.dataSetGES_0.tJ_RequestDoc);
                bool flag = true;
                for (int i = 0; i < (this.dataGridView_0.Rows.Count - 1); i++)
                {
                    if (!bool_0 || !Convert.ToBoolean(this.dataGridView_0[this.dataGridViewCheckBoxColumn_0.Name, i].Value))
                    {
                        List<Struct4> list2 = new List<Struct4> {
                            new Struct4(this.dataGridView_0[this.dataGridViewTextBoxColumn_0.Name, i].Value.ToString(), this.dataGridView_0[this.dataGridViewComboBoxColumn_0.Name, i].FormattedValue.ToString())
                        };
                        if (ExportRequestForRepair.smethod_13(this.textBox_6.Text, Convert.ToInt32(this.textBox_5.Text), this.textBox_2.Text, this.textBox_3.Text, this.textBox_1.Text, this.textBox_4.Text, list2, this.textBox_0.Text, str, list, this.checkBox_0.Checked))
                        {
                            this.dataGridView_0[this.dataGridViewCheckBoxColumn_0.Name, i].Value = true;
                        }
                        else
                        {
                            this.dataGridView_0[this.dataGridViewCheckBoxColumn_0.Name, i].Value = false;
                            flag = false;
                        }
                    }
                }
                return flag;
            }
            return false;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, exception.Source);
            return false;
        }
    }

    private string method_4()
    {
        string name = base.Name;
        if (string.IsNullOrEmpty(name))
        {
            name = "tmp";
        }
        string path = Path.GetTempPath() + @"\" + name + @"\";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        return path;
    }

    private List<string> method_5(DataTable dataTable_0)
    {
        List<string> list = new List<string>();
        foreach (DataRow row in dataTable_0.Rows)
        {
            byte[] buffer;
            string fileName = Path.GetFileName(row["FileName"].ToString());
            string str2 = this.method_4();
            string str3 = FileBinary.GetNewFileNameIsExists(str2, fileName, false);
            try
            {
                buffer = (byte[]) row["document"];
            }
            catch
            {
                MessageBox.Show("Нет содержимого файла");
                continue;
            }
            FileBinary binary = new FileBinary(buffer, str3, DateTime.Now);
            binary.SaveToDisk(str2);
            list.Add(str2 + @"\" + binary.get_Name());
        }
        return list;
    }

    private void method_6()
    {
        ComponentResourceManager manager = new ComponentResourceManager(typeof(Form38));
        this.button_0 = new Button();
        this.textBox_0 = new TextBox();
        this.label_0 = new Label();
        this.dataGridView_0 = new DataGridView();
        this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
        this.splitContainer_0 = new SplitContainer();
        this.textBox_1 = new TextBox();
        this.label_1 = new Label();
        this.textBox_2 = new TextBox();
        this.label_2 = new Label();
        this.textBox_3 = new TextBox();
        this.textBox_4 = new TextBox();
        this.label_3 = new Label();
        this.label_4 = new Label();
        this.textBox_5 = new TextBox();
        this.label_5 = new Label();
        this.textBox_6 = new TextBox();
        this.label_6 = new Label();
        this.button_1 = new Button();
        this.dataSetGES_0 = new DataSetGES();
        this.checkBox_0 = new CheckBox();
        ((ISupportInitialize) this.dataGridView_0).BeginInit();
        this.splitContainer_0.Panel1.SuspendLayout();
        this.splitContainer_0.Panel2.SuspendLayout();
        this.splitContainer_0.SuspendLayout();
        this.dataSetGES_0.BeginInit();
        base.SuspendLayout();
        this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.button_0.Location = new Point(15, 0x16a);
        this.button_0.Name = "buttonSend";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 0x18;
        this.button_0.Text = "Отправить";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.textBox_0.Location = new Point(0x61, 0x90);
        this.textBox_0.Name = "txtSubject";
        this.textBox_0.Size = new Size(0x152, 20);
        this.textBox_0.TabIndex = 0x17;
        this.textBox_0.Text = "Энергосхема: Задача №";
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 0x93);
        this.label_0.Name = "label12";
        this.label_0.Size = new Size(0x4b, 13);
        this.label_0.TabIndex = 0x16;
        this.label_0.Text = "Тема письма";
        this.dataGridView_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewComboBoxColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewCheckBoxColumn_0 };
        this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
        this.dataGridView_0.Location = new Point(12, 170);
        this.dataGridView_0.Name = "dgvRecipient";
        this.dataGridView_0.Size = new Size(760, 180);
        this.dataGridView_0.TabIndex = 0x15;
        this.dataGridView_0.CellValidated += new DataGridViewCellEventHandler(this.dataGridView_0_CellValidated);
        this.dataGridView_0.CellValidating += new DataGridViewCellValidatingEventHandler(this.dataGridView_0_CellValidating);
        this.dataGridView_0.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dataGridView_0_EditingControlShowing);
        this.dataGridViewComboBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewComboBoxColumn_0.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
        this.dataGridViewComboBoxColumn_0.HeaderText = "Имя получателя";
        this.dataGridViewComboBoxColumn_0.Name = "fioRecipientDgvColumn";
        this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_0.HeaderText = "Адрес получателя";
        this.dataGridViewTextBoxColumn_0.Name = "mailDgvColumn";
        this.dataGridViewCheckBoxColumn_0.HeaderText = "Отправлено";
        this.dataGridViewCheckBoxColumn_0.Name = "isSendDgvColumn";
        this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
        this.dataGridViewCheckBoxColumn_0.Visible = false;
        this.dataGridViewCheckBoxColumn_0.Width = 70;
        this.splitContainer_0.IsSplitterFixed = true;
        this.splitContainer_0.Location = new Point(12, 0x33);
        this.splitContainer_0.Name = "splitContainer1";
        this.splitContainer_0.Panel1.Controls.Add(this.textBox_1);
        this.splitContainer_0.Panel1.Controls.Add(this.label_1);
        this.splitContainer_0.Panel1.Controls.Add(this.textBox_2);
        this.splitContainer_0.Panel1.Controls.Add(this.label_2);
        this.splitContainer_0.Panel2.Controls.Add(this.textBox_3);
        this.splitContainer_0.Panel2.Controls.Add(this.textBox_4);
        this.splitContainer_0.Panel2.Controls.Add(this.label_3);
        this.splitContainer_0.Panel2.Controls.Add(this.label_4);
        this.splitContainer_0.Size = new Size(0x1ab, 0x57);
        this.splitContainer_0.SplitterDistance = 0xd3;
        this.splitContainer_0.SplitterWidth = 1;
        this.splitContainer_0.TabIndex = 20;
        this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_1.Location = new Point(14, 0x37);
        this.textBox_1.Name = "textBoxSenderAddress";
        this.textBox_1.Size = new Size(0xc2, 20);
        this.textBox_1.TabIndex = 3;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(11, 0x27);
        this.label_1.Name = "label10";
        this.label_1.Size = new Size(0x69, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Адрес отправителя";
        this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_2.Location = new Point(14, 0x10);
        this.textBox_2.Name = "textBoxLogin";
        this.textBox_2.Size = new Size(0xc2, 20);
        this.textBox_2.TabIndex = 1;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(11, 0);
        this.label_2.Name = "label8";
        this.label_2.Size = new Size(0x26, 13);
        this.label_2.TabIndex = 0;
        this.label_2.Text = "Логин";
        this.textBox_3.Location = new Point(6, 0x10);
        this.textBox_3.Name = "textBoxPassword";
        this.textBox_3.PasswordChar = '☻';
        this.textBox_3.Size = new Size(0xce, 20);
        this.textBox_3.TabIndex = 8;
        this.textBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_4.Location = new Point(6, 0x37);
        this.textBox_4.Name = "textBoxSenderName";
        this.textBox_4.Size = new Size(0xcd, 20);
        this.textBox_4.TabIndex = 5;
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(3, 0x27);
        this.label_3.Name = "label11";
        this.label_3.Size = new Size(0x60, 13);
        this.label_3.TabIndex = 4;
        this.label_3.Text = "Имя отправителя";
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(3, 0);
        this.label_4.Name = "label4";
        this.label_4.Size = new Size(0x2d, 13);
        this.label_4.TabIndex = 2;
        this.label_4.Text = "Пароль";
        this.textBox_5.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.textBox_5.Location = new Point(0xf4, 0x19);
        this.textBox_5.Name = "textBoxSmtpPort";
        this.textBox_5.Size = new Size(0x7b, 20);
        this.textBox_5.TabIndex = 0x13;
        this.textBox_5.Text = "25";
        this.label_5.AutoSize = true;
        this.label_5.Location = new Point(0xf4, 9);
        this.label_5.Name = "label6";
        this.label_5.Size = new Size(0x20, 13);
        this.label_5.TabIndex = 0x12;
        this.label_5.Text = "Порт";
        this.textBox_6.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_6.Location = new Point(12, 0x19);
        this.textBox_6.Name = "txtSmtpServer";
        this.textBox_6.Size = new Size(0xe2, 20);
        this.textBox_6.TabIndex = 0x11;
        this.textBox_6.Text = "domino";
        this.label_6.AutoSize = true;
        this.label_6.Location = new Point(12, 9);
        this.label_6.Name = "label14";
        this.label_6.Size = new Size(0x5e, 13);
        this.label_6.TabIndex = 0x10;
        this.label_6.Text = "Сервер отправки";
        this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0x2af, 0x16a);
        this.button_1.Name = "buttonClose";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 0x19;
        this.button_1.Text = "Закрыть";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        this.dataSetGES_0.DataSetName = "DataSetGES";
        this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.checkBox_0.AutoSize = true;
        this.checkBox_0.Checked = true;
        this.checkBox_0.CheckState = CheckState.Checked;
        this.checkBox_0.Location = new Point(0x175, 0x1b);
        this.checkBox_0.Name = "checkBoxSSL";
        this.checkBox_0.Size = new Size(0x2e, 0x11);
        this.checkBox_0.TabIndex = 0x1a;
        this.checkBox_0.Text = "SSL";
        this.checkBox_0.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x306, 0x187);
        base.Controls.Add(this.checkBox_0);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_0);
        base.Controls.Add(this.dataGridView_0);
        base.Controls.Add(this.splitContainer_0);
        base.Controls.Add(this.textBox_5);
        base.Controls.Add(this.label_5);
        base.Controls.Add(this.textBox_6);
        base.Controls.Add(this.label_6);
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Name = "FormSendMailRequest";
        this.Text = "Отправка задачи почтой";
        base.FormClosing += new FormClosingEventHandler(this.Form38_FormClosing);
        base.Load += new EventHandler(this.Form38_Load);
        ((ISupportInitialize) this.dataGridView_0).EndInit();
        this.splitContainer_0.Panel1.ResumeLayout(false);
        this.splitContainer_0.Panel1.PerformLayout();
        this.splitContainer_0.Panel2.ResumeLayout(false);
        this.splitContainer_0.Panel2.PerformLayout();
        this.splitContainer_0.ResumeLayout(false);
        this.dataSetGES_0.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private static string smethod_0(string string_0)
    {
        if (string.IsNullOrEmpty(string_0))
        {
            return "";
        }
        DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
        MemoryStream stream = new MemoryStream();
        CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(byte_0, byte_0), CryptoStreamMode.Write);
        StreamWriter writer1 = new StreamWriter(stream2);
        writer1.Write(string_0);
        writer1.Flush();
        stream2.FlushFinalBlock();
        writer1.Flush();
        return Convert.ToBase64String(stream.GetBuffer(), 0, (int) stream.Length);
    }

    private static string smethod_1(string string_0)
    {
        if (string.IsNullOrEmpty(string_0))
        {
            throw new ArgumentNullException("The string which needs to be decrypted can not be null.");
        }
        DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
        return new StreamReader(new CryptoStream(new MemoryStream(Convert.FromBase64String(string_0)), provider.CreateDecryptor(byte_0, byte_0), CryptoStreamMode.Read)).ReadToEnd();
    }

    private static string smethod_2(byte[] byte_1)
    {
        char[] dst = new char[byte_1.Length / 2];
        Buffer.BlockCopy(byte_1, 0, dst, 0, byte_1.Length);
        return new string(dst);
    }
}

