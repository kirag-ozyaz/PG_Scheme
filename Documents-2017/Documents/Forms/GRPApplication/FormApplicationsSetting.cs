namespace Documents.Forms.GRPApplication
{
    using DataSql;
    using FormLbr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Xml;

    public class FormApplicationsSetting : FormBase
    {
        private Button button_0;
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private ComboBox comboBox_0;
        private Dictionary<string, Class190> dictionary_0 = new Dictionary<string, Class190>();
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private ListBox listBox_0;
        private Panel panel_0;
        private Panel panel_1;
        private Panel panel_2;
        private SplitContainer splitContainer_0;
        private const string string_0 = "RequestODS";
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_2;
        private TextBox textBox_3;
        private TextBox textBox_4;
        private TextBox textBox_5;
        private TextBox textBox_6;
        private TextBox textBox_7;
        private TextBox textBox_8;

        public FormApplicationsSetting()
        {
            this.method_0();
            base.set_PermissionsSql(false);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBox_0.SelectedIndex;
            this.dictionary_0.Remove(this.comboBox_0.Text);
            this.comboBox_0.Items.Remove(this.comboBox_0.SelectedItem);
            if (this.comboBox_0.Items.Count == 0)
            {
                this.button_3.Enabled = true;
                this.button_2.Enabled = false;
                this.panel_2.Enabled = false;
                this.comboBox_0.Select();
                this.comboBox_0.Focus();
            }
            else if (this.comboBox_0.Items.Count > selectedIndex)
            {
                this.comboBox_0.SelectedIndex = selectedIndex;
            }
            else
            {
                this.comboBox_0.SelectedIndex = this.comboBox_0.Items.Count - 1;
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (this.comboBox_0.Text != string.Empty)
            {
                Class190 class2 = new Class190 {
                    Name = this.comboBox_0.Text
                };
                this.dictionary_0.Add(this.comboBox_0.Text, class2);
                this.comboBox_0.SelectedIndex = this.comboBox_0.Items.Add(this.comboBox_0.Text);
            }
        }

        private void comboBox_0_Leave(object sender, EventArgs e)
        {
        }

        private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.button_2.Enabled = true;
            this.button_3.Enabled = false;
            this.panel_2.Enabled = true;
            Class190 dataSource = this.dictionary_0[this.comboBox_0.Text];
            this.textBox_3.DataBindings.Clear();
            this.textBox_2.DataBindings.Clear();
            this.textBox_1.DataBindings.Clear();
            this.textBox_0.DataBindings.Clear();
            this.textBox_3.DataBindings.Add("Text", dataSource, "Name", true);
            this.textBox_2.DataBindings.Add("Text", dataSource, "Abbreviation", true);
            this.textBox_1.DataBindings.Add("Text", dataSource, "Genitive", true);
            this.textBox_0.DataBindings.Add("Text", dataSource, "ManagerName", true);
        }

        private void comboBox_0_TextUpdate(object sender, EventArgs e)
        {
            this.button_3.Enabled = true;
            this.button_2.Enabled = false;
            this.panel_2.Enabled = false;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormApplicationsSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlElement element;
            if (base.DialogResult != DialogResult.OK)
            {
                return;
            }
            XmlDocument document = new XmlDocument();
            document.LoadXml("<ApplSet></ApplSet>");
            XmlNode node = document.SelectSingleNode("ApplSet");
            using (Dictionary<string, Class190>.ValueCollection.Enumerator enumerator = this.dictionary_0.Values.GetEnumerator())
            {
                Class190 current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    XmlElement newChild = document.CreateElement("NetArea");
                    newChild.SetAttribute("Name", current.Name);
                    newChild.SetAttribute("Genitive", current.Genitive);
                    newChild.SetAttribute("Abbreviation", current.Abbreviation);
                    if (current.ManagerName == string.Empty)
                    {
                        goto Label_00CA;
                    }
                    newChild.SetAttribute("ManagerName", current.ManagerName);
                    node.AppendChild(newChild);
                }
                goto Label_00FB;
            Label_00CA:
                e.Cancel = true;
                MessageBox.Show("Не введён ответственный от " + current.Name);
                return;
            }
        Label_00FB:
            element = document.CreateElement("Ratifying");
            element.SetAttribute("Post", this.textBox_8.Text);
            element.SetAttribute("Name", this.textBox_7.Text);
            node.AppendChild(element);
            element = document.CreateElement("Signer");
            element.SetAttribute("Post", this.textBox_6.Text);
            element.SetAttribute("Name", this.textBox_5.Text);
            node.AppendChild(element);
            element = document.CreateElement("Performer");
            element.SetAttribute("Name", this.textBox_4.Text);
            node.AppendChild(element);
            SqlConnection connection = new SqlConnection(SqlDataConnect.GetConnectionString(this.get_SqlSettings()));
            connection.Open();
            SqlDataReader reader = new SqlCommand("select top 1 * from tSettings where Module = 'RequestODS'", connection).ExecuteReader();
            if (reader.Read())
            {
                if (reader["Settings"].ToString() != document.InnerXml.ToString())
                {
                    reader.Close();
                    new SqlCommand(("update tSettings set Settings = '" + document.InnerXml.ToString() + "'") + " where id = " + reader["id"].ToString(), connection).ExecuteNonQuery();
                }
                else
                {
                    reader.Close();
                }
            }
            else
            {
                reader.Close();
                new SqlCommand("insert into tSettings (Settings, Module) values ('" + document.InnerXml.ToString() + "','RequestODS')", connection).ExecuteNonQuery();
            }
        }

        private void FormApplicationsSetting_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(SqlDataConnect.GetConnectionString(this.get_SqlSettings()));
            connection.Open();
            SqlDataReader reader = new SqlCommand("select top 1 * from tSettings where Module = 'RequestODS'", connection).ExecuteReader();
            if (reader.Read())
            {
                XmlDocument document1 = new XmlDocument();
                document1.LoadXml(reader["Settings"].ToString());
                XmlNode node = document1.SelectSingleNode("ApplSet");
                foreach (XmlNode node3 in node.SelectNodes("NetArea"))
                {
                    Class190 class2 = new Class190 {
                        Name = node3.Attributes["Name"].Value,
                        Abbreviation = node3.Attributes["Abbreviation"].Value,
                        Genitive = node3.Attributes["Genitive"].Value,
                        ManagerName = node3.Attributes["ManagerName"].Value
                    };
                    this.dictionary_0.Add(class2.Name, class2);
                    this.comboBox_0.Items.Add(class2.Name);
                }
                XmlNode node2 = node.SelectSingleNode("Ratifying");
                if (node2 != null)
                {
                    this.textBox_8.Text = node2.Attributes["Post"].Value;
                    this.textBox_7.Text = node2.Attributes["Name"].Value;
                }
                node2 = node.SelectSingleNode("Signer");
                if (node2 != null)
                {
                    this.textBox_6.Text = node2.Attributes["Post"].Value;
                    this.textBox_5.Text = node2.Attributes["Name"].Value;
                }
                node2 = node.SelectSingleNode("Performer");
                if (node2 != null)
                {
                    this.textBox_4.Text = node2.Attributes["Name"].Value;
                }
            }
            reader.Close();
            connection.Close();
            this.listBox_0.SelectedIndex = 0;
            if (this.comboBox_0.Items.Count == 0)
            {
                this.button_3.Enabled = true;
                this.button_2.Enabled = false;
                this.panel_2.Enabled = false;
                this.comboBox_0.Select();
                this.comboBox_0.Focus();
            }
            else
            {
                this.comboBox_0.SelectedIndex = 0;
            }
        }

        private void listBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.listBox_0.SelectedIndex)
            {
                case 0:
                    this.panel_0.Visible = true;
                    this.panel_1.Visible = false;
                    break;

                case 1:
                    this.panel_1.Visible = true;
                    this.panel_0.Visible = false;
                    break;
            }
        }

        private void method_0()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormApplicationsSetting));
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.splitContainer_0 = new SplitContainer();
            this.listBox_0 = new ListBox();
            this.panel_1 = new Panel();
            this.label_4 = new Label();
            this.label_5 = new Label();
            this.label_6 = new Label();
            this.label_7 = new Label();
            this.label_8 = new Label();
            this.textBox_4 = new TextBox();
            this.textBox_5 = new TextBox();
            this.textBox_6 = new TextBox();
            this.textBox_7 = new TextBox();
            this.textBox_8 = new TextBox();
            this.panel_0 = new Panel();
            this.panel_2 = new Panel();
            this.label_1 = new Label();
            this.label_2 = new Label();
            this.label_3 = new Label();
            this.label_0 = new Label();
            this.textBox_0 = new TextBox();
            this.textBox_1 = new TextBox();
            this.textBox_2 = new TextBox();
            this.textBox_3 = new TextBox();
            this.comboBox_0 = new ComboBox();
            this.button_2 = new Button();
            this.button_3 = new Button();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.panel_1.SuspendLayout();
            this.panel_0.SuspendLayout();
            this.panel_2.SuspendLayout();
            base.SuspendLayout();
            this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_0.DialogResult = DialogResult.Cancel;
            this.button_0.Location = new Point(0x13a, 170);
            this.button_0.Name = "buttonCancel";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 0;
            this.button_0.Text = "Отмена";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_1.DialogResult = DialogResult.OK;
            this.button_1.Location = new Point(0xe9, 170);
            this.button_1.Name = "buttonOK";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "OK";
            this.button_1.UseVisualStyleBackColor = true;
            this.splitContainer_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.splitContainer_0.Location = new Point(12, 12);
            this.splitContainer_0.Name = "splitContainer1";
            this.splitContainer_0.Panel1.Controls.Add(this.listBox_0);
            this.splitContainer_0.Panel2.Controls.Add(this.panel_1);
            this.splitContainer_0.Panel2.Controls.Add(this.panel_0);
            this.splitContainer_0.Size = new Size(0x179, 0x98);
            this.splitContainer_0.SplitterDistance = 0x5e;
            this.splitContainer_0.TabIndex = 1;
            this.listBox_0.Dock = DockStyle.Fill;
            this.listBox_0.FormattingEnabled = true;
            object[] items = new object[] { "Адресат заявки", "Печатная форма" };
            this.listBox_0.Items.AddRange(items);
            this.listBox_0.Location = new Point(0, 0);
            this.listBox_0.Name = "listBox1";
            this.listBox_0.Size = new Size(0x5e, 0x98);
            this.listBox_0.TabIndex = 0;
            this.listBox_0.SelectedIndexChanged += new EventHandler(this.listBox_0_SelectedIndexChanged);
            this.panel_1.Controls.Add(this.label_4);
            this.panel_1.Controls.Add(this.label_5);
            this.panel_1.Controls.Add(this.label_6);
            this.panel_1.Controls.Add(this.label_7);
            this.panel_1.Controls.Add(this.label_8);
            this.panel_1.Controls.Add(this.textBox_4);
            this.panel_1.Controls.Add(this.textBox_5);
            this.panel_1.Controls.Add(this.textBox_6);
            this.panel_1.Controls.Add(this.textBox_7);
            this.panel_1.Controls.Add(this.textBox_8);
            this.panel_1.Dock = DockStyle.Fill;
            this.panel_1.Location = new Point(0, 0);
            this.panel_1.Name = "panelPrintFormSetting";
            this.panel_1.Size = new Size(0x117, 0x98);
            this.panel_1.TabIndex = 1;
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(6, 110);
            this.label_4.Name = "label9";
            this.label_4.Size = new Size(0x4a, 13);
            this.label_4.TabIndex = 1;
            this.label_4.Text = "Исполнитель";
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(6, 0x54);
            this.label_5.Name = "label8";
            this.label_5.Size = new Size(0x7a, 13);
            this.label_5.TabIndex = 1;
            this.label_5.Text = "Имя подписывающего";
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(6, 0x3a);
            this.label_6.Name = "label7";
            this.label_6.Size = new Size(0x9e, 13);
            this.label_6.TabIndex = 1;
            this.label_6.Text = "Должность подписывающего";
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(6, 0x20);
            this.label_7.Name = "label6";
            this.label_7.Size = new Size(0x72, 13);
            this.label_7.TabIndex = 1;
            this.label_7.Text = "Имя утверждающего";
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(6, 8);
            this.label_8.Name = "label5";
            this.label_8.Size = new Size(150, 13);
            this.label_8.TabIndex = 1;
            this.label_8.Text = "Должность утверждающего";
            this.textBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.textBox_4.Location = new Point(170, 0x6b);
            this.textBox_4.Multiline = true;
            this.textBox_4.Name = "textBoxPerformer";
            this.textBox_4.Size = new Size(0x6a, 0x2a);
            this.textBox_4.TabIndex = 4;
            this.textBox_5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_5.Location = new Point(170, 0x51);
            this.textBox_5.Name = "textBoxSignerName";
            this.textBox_5.Size = new Size(0x6a, 20);
            this.textBox_5.TabIndex = 3;
            this.textBox_6.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_6.Location = new Point(170, 0x37);
            this.textBox_6.Name = "textBoxSignerPost";
            this.textBox_6.Size = new Size(0x6a, 20);
            this.textBox_6.TabIndex = 2;
            this.textBox_7.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_7.Location = new Point(170, 0x1d);
            this.textBox_7.Name = "textBoxRatifyingName";
            this.textBox_7.Size = new Size(0x6a, 20);
            this.textBox_7.TabIndex = 1;
            this.textBox_8.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_8.Location = new Point(170, 3);
            this.textBox_8.Name = "textBoxRatifyingPost";
            this.textBox_8.Size = new Size(0x6a, 20);
            this.textBox_8.TabIndex = 0;
            this.panel_0.Controls.Add(this.panel_2);
            this.panel_0.Controls.Add(this.comboBox_0);
            this.panel_0.Controls.Add(this.button_2);
            this.panel_0.Controls.Add(this.button_3);
            this.panel_0.Dock = DockStyle.Fill;
            this.panel_0.Location = new Point(0, 0);
            this.panel_0.Name = "panelAreas";
            this.panel_0.Size = new Size(0x117, 0x98);
            this.panel_0.TabIndex = 0;
            this.panel_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.panel_2.Controls.Add(this.label_1);
            this.panel_2.Controls.Add(this.label_2);
            this.panel_2.Controls.Add(this.label_3);
            this.panel_2.Controls.Add(this.label_0);
            this.panel_2.Controls.Add(this.textBox_0);
            this.panel_2.Controls.Add(this.textBox_1);
            this.panel_2.Controls.Add(this.textBox_2);
            this.panel_2.Controls.Add(this.textBox_3);
            this.panel_2.Location = new Point(3, 0x20);
            this.panel_2.Name = "panelSet";
            this.panel_2.Size = new Size(0x111, 0x75);
            this.panel_2.TabIndex = 2;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(3, 0x5d);
            this.label_1.Name = "label4";
            this.label_1.Size = new Size(0x56, 13);
            this.label_1.TabIndex = 1;
            this.label_1.Text = "Ответственный";
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(3, 0x43);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(100, 13);
            this.label_2.TabIndex = 1;
            this.label_2.Text = "Дательный падеж";
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(3, 0x29);
            this.label_3.Name = "label2";
            this.label_3.Size = new Size(0x4d, 13);
            this.label_3.TabIndex = 1;
            this.label_3.Text = "Сокращённое";
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(3, 15);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x53, 13);
            this.label_0.TabIndex = 1;
            this.label_0.Text = "Наименование";
            this.textBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.textBox_0.Location = new Point(0x77, 90);
            this.textBox_0.Name = "textBoxManagerName";
            this.textBox_0.Size = new Size(0x97, 20);
            this.textBox_0.TabIndex = 2;
            this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_1.Location = new Point(0x77, 0x40);
            this.textBox_1.Name = "textBoxGenitive";
            this.textBox_1.Size = new Size(0x97, 20);
            this.textBox_1.TabIndex = 1;
            this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_2.Location = new Point(0x77, 0x26);
            this.textBox_2.Name = "textBoxAbbreviation";
            this.textBox_2.Size = new Size(0x97, 20);
            this.textBox_2.TabIndex = 0;
            this.textBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_3.Enabled = false;
            this.textBox_3.Location = new Point(0x77, 12);
            this.textBox_3.Name = "textBoxName";
            this.textBox_3.Size = new Size(0x97, 20);
            this.textBox_3.TabIndex = 3;
            this.textBox_3.Leave += new EventHandler(this.textBox_3_Leave);
            this.comboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(0x24, 5);
            this.comboBox_0.Name = "comboBox1";
            this.comboBox_0.Size = new Size(0xed, 0x15);
            this.comboBox_0.TabIndex = 0;
            this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.comboBox_0.TextUpdate += new EventHandler(this.comboBox_0_TextUpdate);
            this.comboBox_0.Leave += new EventHandler(this.comboBox_0_Leave);
            this.button_2.Location = new Point(0x24, 3);
            this.button_2.Name = "buttonDelArea";
            this.button_2.Size = new Size(0x1b, 0x17);
            this.button_2.TabIndex = 0;
            this.button_2.Text = "-";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Visible = false;
            this.button_2.Click += new EventHandler(this.button_2_Click);
            this.button_3.Location = new Point(3, 3);
            this.button_3.Name = "buttonAddArea";
            this.button_3.Size = new Size(0x1b, 0x17);
            this.button_3.TabIndex = 0;
            this.button_3.Text = "+";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new EventHandler(this.button_3_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x191, 0xcd);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            this.MinimumSize = new Size(0x1a1, 0xf3);
            base.Name = "FormApplicationsSetting";
            this.Text = "Настройки";
            base.FormClosing += new FormClosingEventHandler(this.FormApplicationsSetting_FormClosing);
            base.Load += new EventHandler(this.FormApplicationsSetting_Load);
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.panel_0.ResumeLayout(false);
            this.panel_2.ResumeLayout(false);
            this.panel_2.PerformLayout();
            base.ResumeLayout(false);
        }

        private void textBox_3_Leave(object sender, EventArgs e)
        {
        }
    }
}

