using Documents.Properties;
using FormLbr;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

internal class Form13 : FormBase
{
    private Button button_0;
    private Button button_1;
    private DataGridView dataGridView_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
    private DataTable dataTable_0;
    private IContainer icontainer_0;
    private int int_0 = -1;
    private int int_1 = 1;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private Label label_4;
    private Label label_5;
    private Label label_6;
    private Label label_7;
    private const string string_0 = "TCContractWord";
    private TextBox textBox_0;
    private TextBox textBox_1;
    private TextBox textBox_2;
    private TextBox textBox_3;
    private TextBox textBox_4;
    private TextBox textBox_5;
    private TextBox textBox_6;
    private TextBox textBox_7;
    private ToolStrip toolStrip_0;
    private ToolStripButton toolStripButton_0;
    private ToolStripButton toolStripButton_1;
    private ToolStripButton toolStripButton_2;

    internal Form13()
    {
        this.method_0();
        this.dataTable_0 = new DataTable("tSettings");
        this.dataTable_0.Columns.Add(new DataColumn("id", typeof(int)));
        this.dataTable_0.Columns[0].AutoIncrement = true;
        this.dataTable_0.Columns.Add(new DataColumn("settings", typeof(string)));
        this.dataTable_0.Columns.Add(new DataColumn("module", typeof(string)));
        this.dataTable_0.PrimaryKey = new DataColumn[] { this.dataTable_0.Columns[0] };
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        XmlDocument document = new XmlDocument();
        XmlNode newChild = document.CreateElement("document");
        document.AppendChild(newChild);
        foreach (DataGridViewRow row in (IEnumerable) this.dataGridView_0.Rows)
        {
            XmlNode node2 = document.CreateElement("Row");
            XmlAttribute node = document.CreateAttribute("Id");
            node.Value = row.Cells[this.dataGridViewTextBoxColumn_8.Name].Value.ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("Face");
            node.Value = row.Cells[this.dataGridViewTextBoxColumn_0.Name].Value.ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("F_R");
            node.Value = row.Cells[this.dataGridViewTextBoxColumn_1.Name].Value.ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("I_R");
            node.Value = row.Cells[this.dataGridViewTextBoxColumn_2.Name].Value.ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("O_R");
            node.Value = row.Cells[this.dataGridViewTextBoxColumn_3.Name].Value.ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("F_I");
            node.Value = row.Cells[this.dataGridViewTextBoxColumn_4.Name].Value.ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("I_I");
            node.Value = row.Cells[this.dataGridViewTextBoxColumn_5.Name].Value.ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("O_I");
            node.Value = row.Cells[this.dataGridViewTextBoxColumn_6.Name].Value.ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("use");
            node.Value = row.Cells[this.dataGridViewTextBoxColumn_7.Name].Value.ToString();
            node2.Attributes.Append(node);
            newChild.AppendChild(node2);
        }
        if (this.dataTable_0.Rows.Count == 0)
        {
            DataRow row2 = this.dataTable_0.NewRow();
            row2["Settings"] = document.InnerXml;
            row2["Module"] = "TCContractWord";
            this.dataTable_0.Rows.Add(row2);
            base.InsertSqlData(this.dataTable_0);
        }
        else
        {
            this.dataTable_0.Rows[0]["Settings"] = document.InnerXml;
            this.dataTable_0.Rows[0]["Module"] = "TCContractWord";
            this.dataTable_0.Rows[0].EndEdit();
            base.UpdateSqlData(this.dataTable_0);
        }
        base.Close();
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void dataGridView_0_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
        if (this.dataGridView_0.CurrentRow != null)
        {
            DataGridViewRow row = this.dataGridView_0.Rows[e.RowIndex];
            this.textBox_0.Text = row.Cells[this.dataGridViewTextBoxColumn_0.Name].Value.ToString();
            this.textBox_1.Text = row.Cells[this.dataGridViewTextBoxColumn_1.Name].Value.ToString();
            this.textBox_6.Text = row.Cells[this.dataGridViewTextBoxColumn_4.Name].Value.ToString();
            this.textBox_2.Text = row.Cells[this.dataGridViewTextBoxColumn_2.Name].Value.ToString();
            this.textBox_5.Text = row.Cells[this.dataGridViewTextBoxColumn_5.Name].Value.ToString();
            this.textBox_3.Text = row.Cells[this.dataGridViewTextBoxColumn_3.Name].Value.ToString();
            this.textBox_4.Text = row.Cells[this.dataGridViewTextBoxColumn_6.Name].Value.ToString();
            this.textBox_7.Text = row.Cells[this.dataGridViewTextBoxColumn_7.Name].Value.ToString();
            this.int_0 = Convert.ToInt32(row.Cells[this.dataGridViewTextBoxColumn_8.Name].Value);
        }
        else
        {
            this.textBox_0.Text = this.textBox_1.Text = this.textBox_6.Text = this.textBox_2.Text = this.textBox_5.Text = this.textBox_3.Text = this.textBox_4.Text = this.textBox_7.Text = "";
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

    private void Form13_Load(object sender, EventArgs e)
    {
        base.SelectSqlData(this.dataTable_0, true, " where module = 'TCContractWord'", false);
        if ((this.dataTable_0.Rows.Count > 0) && (this.dataTable_0.Rows[0]["Settings"] != DBNull.Value))
        {
            try
            {
                XmlDocument document1 = new XmlDocument();
                document1.LoadXml(this.dataTable_0.Rows[0]["Settings"].ToString());
                XmlNode node = document1.SelectSingleNode("document");
                if (node != null)
                {
                    foreach (XmlNode node2 in node.SelectNodes("Row"))
                    {
                        object[] values = new object[] { node2.Attributes["Face"].Value, node2.Attributes["F_R"].Value, node2.Attributes["I_R"].Value, node2.Attributes["O_R"].Value, node2.Attributes["F_I"].Value, node2.Attributes["I_I"].Value, node2.Attributes["O_I"].Value, node2.Attributes["use"].Value, node2.Attributes["Id"].Value };
                        this.dataGridView_0.Rows.Add(values);
                        if (this.int_1 < (Convert.ToInt32(node2.Attributes["Id"].Value) + 1))
                        {
                            this.int_1 = Convert.ToInt32(node2.Attributes["Id"].Value) + 1;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }
    }

    private void method_0()
    {
        this.label_0 = new Label();
        this.textBox_0 = new TextBox();
        this.label_1 = new Label();
        this.textBox_1 = new TextBox();
        this.label_2 = new Label();
        this.textBox_2 = new TextBox();
        this.label_3 = new Label();
        this.textBox_3 = new TextBox();
        this.textBox_4 = new TextBox();
        this.label_4 = new Label();
        this.textBox_5 = new TextBox();
        this.label_5 = new Label();
        this.textBox_6 = new TextBox();
        this.label_6 = new Label();
        this.label_7 = new Label();
        this.textBox_7 = new TextBox();
        this.toolStrip_0 = new ToolStrip();
        this.toolStripButton_0 = new ToolStripButton();
        this.toolStripButton_1 = new ToolStripButton();
        this.toolStripButton_2 = new ToolStripButton();
        this.dataGridView_0 = new DataGridView();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.toolStrip_0.SuspendLayout();
        ((ISupportInitialize) this.dataGridView_0).BeginInit();
        base.SuspendLayout();
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 9);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(40, 13);
        this.label_0.TabIndex = 0;
        this.label_0.Text = "в лице";
        this.textBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_0.Location = new Point(15, 0x19);
        this.textBox_0.Name = "txtFace";
        this.textBox_0.Size = new Size(0xb6, 20);
        this.textBox_0.TabIndex = 1;
        this.label_1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(0xd8, 9);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x84, 13);
        this.label_1.TabIndex = 2;
        this.label_1.Text = "Фамилия (родительный)";
        this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.textBox_1.Location = new Point(0xd3, 0x19);
        this.textBox_1.Name = "txtF_R";
        this.textBox_1.Size = new Size(0x92, 20);
        this.textBox_1.TabIndex = 3;
        this.textBox_1.TextChanged += new EventHandler(this.textBox_1_TextChanged);
        this.label_2.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(0x171, 9);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x69, 13);
        this.label_2.TabIndex = 4;
        this.label_2.Text = "Имя (родительный)";
        this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.textBox_2.Location = new Point(0x16b, 0x19);
        this.textBox_2.Name = "txtI_R";
        this.textBox_2.Size = new Size(0x89, 20);
        this.textBox_2.TabIndex = 5;
        this.textBox_2.TextChanged += new EventHandler(this.textBox_2_TextChanged);
        this.label_3.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(0x1fd, 9);
        this.label_3.Name = "label4";
        this.label_3.Size = new Size(130, 13);
        this.label_3.TabIndex = 6;
        this.label_3.Text = "Отчество (родительный)";
        this.textBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.textBox_3.Location = new Point(0x1fa, 0x19);
        this.textBox_3.Name = "txtO_R";
        this.textBox_3.Size = new Size(0x89, 20);
        this.textBox_3.TabIndex = 7;
        this.textBox_3.TextChanged += new EventHandler(this.textBox_3_TextChanged);
        this.textBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.textBox_4.Location = new Point(0x1fa, 0x40);
        this.textBox_4.Name = "txtO_I";
        this.textBox_4.Size = new Size(0x89, 20);
        this.textBox_4.TabIndex = 13;
        this.label_4.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(0x1fd, 0x30);
        this.label_4.Name = "label5";
        this.label_4.Size = new Size(0x8a, 13);
        this.label_4.TabIndex = 12;
        this.label_4.Text = "Отчетсво (именительный)";
        this.textBox_5.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.textBox_5.Location = new Point(0x16b, 0x40);
        this.textBox_5.Name = "txtI_I";
        this.textBox_5.Size = new Size(0x89, 20);
        this.textBox_5.TabIndex = 11;
        this.label_5.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.label_5.AutoSize = true;
        this.label_5.Location = new Point(0x171, 0x30);
        this.label_5.Name = "label6";
        this.label_5.Size = new Size(0x71, 13);
        this.label_5.TabIndex = 10;
        this.label_5.Text = "Имя (именительный)";
        this.textBox_6.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.textBox_6.Location = new Point(0xd3, 0x40);
        this.textBox_6.Name = "txtF_I";
        this.textBox_6.Size = new Size(0x92, 20);
        this.textBox_6.TabIndex = 9;
        this.label_6.Anchor = AnchorStyles.Right | AnchorStyles.Top;
        this.label_6.AutoSize = true;
        this.label_6.Location = new Point(0xd9, 0x30);
        this.label_6.Name = "label7";
        this.label_6.Size = new Size(140, 13);
        this.label_6.TabIndex = 8;
        this.label_6.Text = "Фамилия (именительный)";
        this.label_7.AutoSize = true;
        this.label_7.Location = new Point(12, 0x5d);
        this.label_7.Name = "label8";
        this.label_7.Size = new Size(0x99, 13);
        this.label_7.TabIndex = 14;
        this.label_7.Text = "действующего на основании";
        this.textBox_7.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_7.Location = new Point(15, 0x6d);
        this.textBox_7.Name = "txtUse";
        this.textBox_7.Size = new Size(0x274, 20);
        this.textBox_7.TabIndex = 15;
        this.toolStrip_0.Dock = DockStyle.None;
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2 };
        this.toolStrip_0.Items.AddRange(toolStripItems);
        this.toolStrip_0.Location = new Point(15, 0x84);
        this.toolStrip_0.Name = "toolStrip1";
        this.toolStrip_0.Size = new Size(0x51, 0x19);
        this.toolStrip_0.TabIndex = 0x10;
        this.toolStrip_0.Text = "toolStrip1";
        this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_0.Image = Resources.ElementAdd;
        this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_0.Name = "toolBtnAdd";
        this.toolStripButton_0.Size = new Size(0x17, 0x16);
        this.toolStripButton_0.Text = "Добавить";
        this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
        this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_1.Image = Resources.ElementEdit;
        this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_1.Name = "toolBtnEdit";
        this.toolStripButton_1.Size = new Size(0x17, 0x16);
        this.toolStripButton_1.Text = "Редактировать";
        this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
        this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_2.Image = Resources.ElementDel;
        this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
        this.toolStripButton_2.Name = "toolBtnRemove";
        this.toolStripButton_2.Size = new Size(0x17, 0x16);
        this.toolStripButton_2.Text = "Удалить";
        this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
        this.dataGridView_0.AllowUserToAddRows = false;
        this.dataGridView_0.AllowUserToDeleteRows = false;
        this.dataGridView_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8 };
        this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
        this.dataGridView_0.Location = new Point(0, 160);
        this.dataGridView_0.Name = "dgv";
        this.dataGridView_0.ReadOnly = true;
        this.dataGridView_0.Size = new Size(0x28c, 0xed);
        this.dataGridView_0.TabIndex = 0x11;
        this.dataGridView_0.RowEnter += new DataGridViewCellEventHandler(this.dataGridView_0_RowEnter);
        this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_0.HeaderText = "в лице";
        this.dataGridViewTextBoxColumn_0.Name = "ColumnFace";
        this.dataGridViewTextBoxColumn_0.ReadOnly = true;
        this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_1.HeaderText = "Фамилия";
        this.dataGridViewTextBoxColumn_1.Name = "ColumnF_R";
        this.dataGridViewTextBoxColumn_1.ReadOnly = true;
        this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_2.HeaderText = "Имя";
        this.dataGridViewTextBoxColumn_2.Name = "ColumnI_R";
        this.dataGridViewTextBoxColumn_2.ReadOnly = true;
        this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_3.HeaderText = "Отчетсво";
        this.dataGridViewTextBoxColumn_3.Name = "ColumnO_R";
        this.dataGridViewTextBoxColumn_3.ReadOnly = true;
        this.dataGridViewTextBoxColumn_4.HeaderText = "Фамилия";
        this.dataGridViewTextBoxColumn_4.Name = "ColumnF_I";
        this.dataGridViewTextBoxColumn_4.ReadOnly = true;
        this.dataGridViewTextBoxColumn_4.Visible = false;
        this.dataGridViewTextBoxColumn_5.HeaderText = "Имя";
        this.dataGridViewTextBoxColumn_5.Name = "ColumnI_I";
        this.dataGridViewTextBoxColumn_5.ReadOnly = true;
        this.dataGridViewTextBoxColumn_5.Visible = false;
        this.dataGridViewTextBoxColumn_6.HeaderText = "Отчетсво";
        this.dataGridViewTextBoxColumn_6.Name = "ColumnO_I";
        this.dataGridViewTextBoxColumn_6.ReadOnly = true;
        this.dataGridViewTextBoxColumn_6.Visible = false;
        this.dataGridViewTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_7.HeaderText = "на основании";
        this.dataGridViewTextBoxColumn_7.Name = "ColumnUse";
        this.dataGridViewTextBoxColumn_7.ReadOnly = true;
        this.dataGridViewTextBoxColumn_8.HeaderText = "ID";
        this.dataGridViewTextBoxColumn_8.Name = "ColumnID";
        this.dataGridViewTextBoxColumn_8.ReadOnly = true;
        this.dataGridViewTextBoxColumn_8.Visible = false;
        this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.button_0.Location = new Point(12, 0x19c);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 0x12;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.button_1.Location = new Point(0x235, 0x19c);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 0x13;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x28c, 0x1bf);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.dataGridView_0);
        base.Controls.Add(this.toolStrip_0);
        base.Controls.Add(this.textBox_7);
        base.Controls.Add(this.label_7);
        base.Controls.Add(this.textBox_4);
        base.Controls.Add(this.label_4);
        base.Controls.Add(this.textBox_5);
        base.Controls.Add(this.label_5);
        base.Controls.Add(this.textBox_6);
        base.Controls.Add(this.label_6);
        base.Controls.Add(this.textBox_3);
        base.Controls.Add(this.label_3);
        base.Controls.Add(this.textBox_2);
        base.Controls.Add(this.label_2);
        base.Controls.Add(this.textBox_1);
        base.Controls.Add(this.label_1);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.label_0);
        base.Name = "FormContractSettingsWord";
        this.Text = "Настройки для шаблона";
        base.Load += new EventHandler(this.Form13_Load);
        this.toolStrip_0.ResumeLayout(false);
        this.toolStrip_0.PerformLayout();
        ((ISupportInitialize) this.dataGridView_0).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void textBox_1_TextChanged(object sender, EventArgs e)
    {
        this.textBox_6.Text = this.textBox_1.Text;
    }

    private void textBox_2_TextChanged(object sender, EventArgs e)
    {
        this.textBox_5.Text = this.textBox_2.Text;
    }

    private void textBox_3_TextChanged(object sender, EventArgs e)
    {
        this.textBox_4.Text = this.textBox_3.Text;
    }

    private void toolStripButton_0_Click(object sender, EventArgs e)
    {
        object[] values = new object[] { this.textBox_0.Text, this.textBox_1.Text, this.textBox_2.Text, this.textBox_3.Text, this.textBox_6.Text, this.textBox_5.Text, this.textBox_4.Text, this.textBox_7.Text, this.int_1 };
        this.dataGridView_0.Rows.Add(values);
        this.int_1++;
    }

    private void toolStripButton_1_Click(object sender, EventArgs e)
    {
        if (this.dataGridView_0.CurrentRow != null)
        {
            DataGridViewRow currentRow = this.dataGridView_0.CurrentRow;
            currentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value = this.textBox_0.Text;
            currentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value = this.textBox_1.Text;
            currentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value = this.textBox_6.Text;
            currentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value = this.textBox_2.Text;
            currentRow.Cells[this.dataGridViewTextBoxColumn_5.Name].Value = this.textBox_5.Text;
            currentRow.Cells[this.dataGridViewTextBoxColumn_3.Name].Value = this.textBox_3.Text;
            currentRow.Cells[this.dataGridViewTextBoxColumn_6.Name].Value = this.textBox_4.Text;
            currentRow.Cells[this.dataGridViewTextBoxColumn_7.Name].Value = this.textBox_7.Text;
            currentRow.Cells[this.dataGridViewTextBoxColumn_8.Name].Value = this.int_0;
        }
        else
        {
            MessageBox.Show("Не выбрана строка для редактирования");
        }
    }

    private void toolStripButton_2_Click(object sender, EventArgs e)
    {
        if (this.dataGridView_0.CurrentRow != null)
        {
            this.dataGridView_0.Rows.Remove(this.dataGridView_0.CurrentRow);
        }
        else
        {
            MessageBox.Show("Не выбрана строка для удаления");
        }
    }
}

