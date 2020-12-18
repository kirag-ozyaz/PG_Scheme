namespace Documents.Forms.TechnologicalConnection.Acts
{
    using ControlsLbr;
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
    using Documents.Forms.TechnologicalConnection;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;
    using System.Windows.Forms;
    using System.Xml;

    public class FormActElectricalInspection : FormBase
    {
        private BindingSource bindingSource_0;
        private bool bool_0;
        private Button button_0;
        private Button button_1;
        private Button button_2;
        private static byte[] byte_0 = Encoding.ASCII.GetBytes("jf8hSDJH");
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private ComboBox comboBox_3;
        private ComboBox comboBox_4;
        private ComboBox comboBox_5;
        private ContextMenuStrip contextMenuStrip_0;
        private DataGridView dataGridView_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataSetTechConnection dataSetTechConnection_0;
        private DateTimePicker dateTimePicker_0;
        private Dictionary<string, FileWatcherArgsAddl> dictionary_0;
        private GroupBox groupBox_0;
        private GroupBox groupBox_1;
        private GroupBox groupBox_2;
        private GroupBox groupBox_3;
        private GroupBox groupBox_4;
        private GroupBox groupBox_5;
        private GroupBox groupBox_6;
        private GroupBox groupBox_7;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label label_11;
        private Label label_12;
        private Label label_13;
        private Label label_14;
        private Label label_15;
        private Label label_16;
        private Label label_17;
        private Label label_18;
        private Label label_19;
        private Label label_2;
        private Label label_20;
        private Label label_21;
        private Label label_22;
        private Label label_23;
        private Label label_24;
        private Label label_25;
        private Label label_26;
        private Label label_27;
        private Label label_28;
        private Label label_29;
        private Label label_3;
        private Label label_30;
        private Label label_31;
        private Label label_32;
        private Label label_33;
        private Label label_34;
        private Label label_35;
        private Label label_36;
        private Label label_37;
        private Label label_38;
        private Label label_39;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private NullableDateTimePicker nullableDateTimePicker_0;
        private SplitContainer splitContainer_0;
        private SplitContainer splitContainer_1;
        private string string_0;
        private TabControl tabControl_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TabPage tabPage_2;
        private TabPage tabPage_3;
        private TabPage tabPage_4;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_10;
        private TextBox textBox_11;
        private TextBox textBox_12;
        private TextBox textBox_13;
        private TextBox textBox_14;
        private TextBox textBox_15;
        private TextBox textBox_16;
        private TextBox textBox_17;
        private TextBox textBox_18;
        private TextBox textBox_19;
        private TextBox textBox_2;
        private TextBox textBox_20;
        private TextBox textBox_21;
        private TextBox textBox_22;
        private TextBox textBox_23;
        private TextBox textBox_24;
        private TextBox textBox_25;
        private TextBox textBox_26;
        private TextBox textBox_27;
        private TextBox textBox_28;
        private TextBox textBox_29;
        private TextBox textBox_3;
        private TextBox textBox_4;
        private TextBox textBox_5;
        private TextBox textBox_6;
        private TextBox textBox_7;
        private TextBox textBox_8;
        private TextBox textBox_9;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripDropDownButton toolStripDropDownButton_0;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripMenuItem toolStripMenuItem_1;
        private ToolStripMenuItem toolStripMenuItem_2;
        private ToolStripMenuItem toolStripMenuItem_3;
        private ToolStripMenuItem toolStripMenuItem_4;
        private ToolStripMenuItem toolStripMenuItem_5;
        private ToolStripMenuItem toolStripMenuItem_6;
        private ToolStripMenuItem toolStripMenuItem_7;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripSeparator toolStripSeparator_3;

        public FormActElectricalInspection()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = 0x4d6;
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_0 = "";
            this.method_22();
            this.method_0();
        }

        public FormActElectricalInspection(int idAct, int idTU = -1, int typeAct = 0x4d6)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = 0x4d6;
            this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
            this.string_0 = "";
            this.method_22();
            this.int_0 = idAct;
            this.int_1 = idTU;
            this.int_4 = typeAct;
            this.method_0();
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
                    XmlAttribute attribute = node2.Attributes["Subject"];
                    if (attribute != null)
                    {
                        this.textBox_10.Text = attribute.Value;
                    }
                    XmlNode node3 = node2.SelectSingleNode("SMTP");
                    if (node3 != null)
                    {
                        attribute = node3.Attributes["Name"];
                        if (attribute != null)
                        {
                            this.textBox_9.Text = attribute.Value;
                        }
                        attribute = node3.Attributes["Port"];
                        if (attribute != null)
                        {
                            this.textBox_8.Text = attribute.Value;
                        }
                        attribute = node3.Attributes["Login"];
                        if (attribute != null)
                        {
                            this.textBox_5.Text = attribute.Value;
                        }
                        attribute = node3.Attributes["Password"];
                        if (attribute != null)
                        {
                            this.textBox_6.Text = smethod_1(attribute.Value);
                        }
                        XmlNode node4 = node2.SelectSingleNode("Sender");
                        if (node4 != null)
                        {
                            attribute = node4.Attributes["Address"];
                            if (attribute != null)
                            {
                                this.textBox_4.Text = attribute.Value;
                            }
                            attribute = node4.Attributes["Name"];
                            if (attribute != null)
                            {
                                this.textBox_7.Text = attribute.Value;
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
                                            this.dataGridView_0.Rows[this.dataGridView_0.Rows.Count - 2].Cells[this.dataGridViewComboBoxColumn_0.Name].Value = Convert.ToInt32(obj2);
                                            this.dataGridView_0.Rows[this.dataGridView_0.Rows.Count - 2].Cells[this.dataGridViewTextBoxColumn_9.Name].Value = obj3;
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
            if (this.method_5())
            {
                bool flag = false;
                for (int i = 0; i < (this.dataGridView_0.Rows.Count - 1); i++)
                {
                    if (!Convert.ToBoolean(this.dataGridView_0.Rows[i].Cells[this.dataGridViewCheckBoxColumn_0.Name].Value))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag && (MessageBox.Show("Данные успешно сохранены.\r\nОтправить документ выбранным адресатам?", "Отправка почты", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.method_18(true);
                }
                base.Close();
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Пропустить адресатов, которым уже отправлено данное сообщение?", "Отправка почты", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Cancel)
            {
                bool flag = false;
                if (result == DialogResult.Yes)
                {
                    flag = true;
                }
                if (!this.bool_0 && (this.int_0 != -1))
                {
                    this.method_18(flag);
                }
                else if ((MessageBox.Show("Перед отправкой необходимо сохранить документа. Сохранить?", "Сохранение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) && this.method_5())
                {
                    this.method_18(flag);
                }
            }
        }

        public bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                FileStream stream1 = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                stream1.Write(byteArray, 0, byteArray.Length);
                stream1.Close();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
                exception.ToString();
            }
            return false;
        }

        private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void comboBox_0_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((this.comboBox_0.SelectedValue != null) && (this.comboBox_0.SelectedIndex != -1))
            {
                this.int_1 = Convert.ToInt32(this.comboBox_0.SelectedValue);
                this.method_3(this.int_1);
            }
            else
            {
                this.textBox_1.Text = this.textBox_2.Text = "";
                this.int_1 = -1;
            }
            this.bool_0 = true;
        }

        private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void comboBox_2_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox) sender;
            if ((box.SelectedIndex >= 0) && (box.SelectedValue != null))
            {
                DataTable table = base.SelectSqlData("tr_Worker", true, "where id = " + box.SelectedValue.ToString());
                if ((table.Rows.Count > 0) && (table.Rows[0]["JobTitle"] != DBNull.Value))
                {
                    DataTable table2 = base.SelectSqlData("tr_jobtitle", true, " where id = " + table.Rows[0]["JobTitle"].ToString());
                    if ((table2.Rows.Count > 0) && (table2.Rows[0]["Description"] != DBNull.Value))
                    {
                        this.textBox_18.Text = table2.Rows[0]["Description"].ToString();
                    }
                }
            }
        }

        private void comboBox_3_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox) sender;
            if ((box.SelectedIndex >= 0) && (box.SelectedValue != null))
            {
                DataTable table = base.SelectSqlData("tr_Worker", true, "where id = " + box.SelectedValue.ToString());
                if ((table.Rows.Count > 0) && (table.Rows[0]["JobTitle"] != DBNull.Value))
                {
                    DataTable table2 = base.SelectSqlData("tr_jobtitle", true, " where id = " + table.Rows[0]["JobTitle"].ToString());
                    if ((table2.Rows.Count > 0) && (table2.Rows[0]["Description"] != DBNull.Value))
                    {
                        this.textBox_19.Text = table2.Rows[0]["Description"].ToString();
                    }
                }
            }
        }

        private void comboBox_4_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox) sender;
            if ((box.SelectedIndex >= 0) && (box.SelectedValue != null))
            {
                DataTable table = base.SelectSqlData("tr_Worker", true, "where id = " + box.SelectedValue.ToString());
                if ((table.Rows.Count > 0) && (table.Rows[0]["JobTitle"] != DBNull.Value))
                {
                    DataTable table2 = base.SelectSqlData("tr_jobtitle", true, " where id = " + table.Rows[0]["JobTitle"].ToString());
                    if ((table2.Rows.Count > 0) && (table2.Rows[0]["Description"] != DBNull.Value))
                    {
                        this.textBox_20.Text = table2.Rows[0]["Description"].ToString();
                    }
                }
            }
        }

        private void comboBox_5_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox) sender;
            if ((box.SelectedIndex >= 0) && (box.SelectedValue != null))
            {
                DataTable table = base.SelectSqlData("tr_Worker", true, "where id = " + box.SelectedValue.ToString());
                if ((table.Rows.Count > 0) && (table.Rows[0]["JobTitle"] != DBNull.Value))
                {
                    DataTable table2 = base.SelectSqlData("tr_jobtitle", true, " where id = " + table.Rows[0]["JobTitle"].ToString());
                    if ((table2.Rows.Count > 0) && (table2.Rows[0]["Description"] != DBNull.Value))
                    {
                        this.textBox_21.Text = table2.Rows[0]["Description"].ToString();
                    }
                }
            }
        }

        private void comboBox_5_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document = new XmlDocument();
            XmlNode newChild = document.CreateElement(base.Name);
            document.AppendChild(newChild);
            XmlNode node2 = document.CreateElement("Mail");
            newChild.AppendChild(node2);
            XmlAttribute node = document.CreateAttribute("Subject");
            node.Value = this.textBox_10.Text;
            node2.Attributes.Append(node);
            XmlNode node3 = document.CreateElement("SMTP");
            node2.AppendChild(node3);
            node = document.CreateAttribute("Name");
            node.Value = this.textBox_9.Text;
            node3.Attributes.Append(node);
            node = document.CreateAttribute("Port");
            node.Value = this.textBox_8.Text;
            node3.Attributes.Append(node);
            node = document.CreateAttribute("Login");
            node.Value = this.textBox_5.Text;
            node3.Attributes.Append(node);
            node = document.CreateAttribute("Password");
            node.Value = smethod_0(this.textBox_6.Text);
            node3.Attributes.Append(node);
            XmlNode node4 = document.CreateElement("Sender");
            node2.AppendChild(node4);
            node = document.CreateAttribute("Address");
            node.Value = this.textBox_4.Text;
            node4.Attributes.Append(node);
            node = document.CreateAttribute("Name");
            node.Value = this.textBox_7.Text;
            node4.Attributes.Append(node);
            XmlNode node5 = document.CreateElement("Recipients");
            node2.AppendChild(node5);
            for (int i = 0; i < (this.dataGridView_0.Rows.Count - 1); i++)
            {
                XmlNode node6 = document.CreateElement("Recipient");
                node5.AppendChild(node6);
                node = document.CreateAttribute("Address");
                if (this.dataGridView_0[this.dataGridViewTextBoxColumn_9.Name, i].Value == null)
                {
                    node.Value = "";
                }
                else
                {
                    node.Value = this.dataGridView_0[this.dataGridViewTextBoxColumn_9.Name, i].Value.ToString();
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

        private void dataGridView_0_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
                e.Cancel = true;
                if (((e.ColumnIndex >= 0) && (e.ColumnIndex < ((DataGridView) sender).Columns.Count)) && ((e.RowIndex >= 0) && (e.RowIndex < ((DataGridView) sender).Rows.Count)))
                {
                    ((DataGridView) sender).Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = e.Exception.Message;
                }
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView_0_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                (e.Control as ComboBox).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                (e.Control as ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems;
                BindingSource dataSource = (BindingSource) (e.Control as ComboBox).DataSource;
                if (dataSource != null)
                {
                    dataSource.Filter = "";
                    string str = "";
                    foreach (DataGridViewRow row in (IEnumerable) this.dataGridView_0.Rows)
                    {
                        if (((this.dataGridView_0.CurrentCell == null) || (this.dataGridView_0.CurrentCell.RowIndex != row.Index)) && (row.Cells[this.dataGridViewComboBoxColumn_0.Name].Value != null))
                        {
                            str = str + row.Cells[this.dataGridViewComboBoxColumn_0.Name].Value.ToString() + ",";
                        }
                    }
                    if (str.Length > 0)
                    {
                        dataSource.Filter = "id not in (" + str.Remove(str.Length - 1) + ")";
                    }
                    if ((this.dataGridView_0.CurrentCell != null) && (this.dataGridView_0.CurrentCell.Value != null))
                    {
                        (e.Control as ComboBox).SelectedValue = this.dataGridView_0.CurrentCell.Value;
                    }
                }
                (e.Control as ComboBox).SelectedValueChanged -= new EventHandler(this.method_17);
                (e.Control as ComboBox).SelectedValueChanged += new EventHandler(this.method_17);
            }
        }

        private void dataGridView_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < e.RowCount; i++)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell) this.dataGridView_0[this.dataGridViewComboBoxColumn_0.Name, e.RowIndex + i];
                if (!string.IsNullOrEmpty(this.get_SqlSettings().get_ServerDB()))
                {
                    DataTable table = new DataTable("vR_worker");
                    table.Columns.Add(new DataColumn("id", typeof(int)));
                    table.Columns.Add(new DataColumn("fio", typeof(string)));
                    BindingSource source = new BindingSource {
                        DataSource = table
                    };
                    base.SelectSqlData(table, true, "where dateEnd is null order by fio", false);
                    cell.DisplayMember = "FIO";
                    cell.ValueMember = "id";
                    cell.DataSource = source;
                }
                this.bool_0 = true;
            }
        }

        private void dataGridView_0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.bool_0 = true;
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripMenuItem_4_Click(sender, e);
        }

        private void dataGridViewExcelFilter_0_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            string key = this.dataGridViewExcelFilter_0[e.ColumnIndex, e.RowIndex].Value.ToString() + Path.GetExtension(this.string_0);
            if (key != this.string_0)
            {
                if (this.dictionary_0.ContainsKey(this.string_0))
                {
                    FileWatcherArgsAddl addl = this.dictionary_0[this.string_0];
                    addl.set_OriginalName(key);
                    this.dictionary_0.Remove(this.string_0);
                    this.dictionary_0.Add(key, addl);
                    this.dataGridViewExcelFilter_0[e.ColumnIndex, e.RowIndex].Value = key;
                    this.bool_0 = true;
                }
                this.string_0 = null;
            }
        }

        private void dataGridViewExcelFilter_0_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (e.Button == MouseButtons.Right))
            {
                this.dataGridViewExcelFilter_0.ClearSelection();
                this.dataGridViewExcelFilter_0.Rows[e.RowIndex].Selected = true;
                this.dataGridViewExcelFilter_0.CurrentCell = this.dataGridViewExcelFilter_0[e.ColumnIndex, e.RowIndex];
                Rectangle rectangle = this.dataGridViewExcelFilter_0.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                this.contextMenuStrip_0.Show((Control) sender, (int) (rectangle.Left + e.X), (int) (rectangle.Top + e.Y));
            }
        }

        private void dataGridViewExcelFilter_0_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (((e.ColumnIndex == 1) && (e.RowIndex >= 0)) && !string.IsNullOrEmpty(this.string_0))
            {
                string key = e.FormattedValue + Path.GetExtension(this.string_0);
                if ((key != this.string_0) && this.dictionary_0.ContainsKey(key))
                {
                    MessageBox.Show("Файл с таким именем уже существует", "");
                    e.Cancel = true;
                }
            }
        }

        private void dataGridViewExcelFilter_0_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if ((((DataGridView) sender).RowCount > 0) && (this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value != null))
            {
                if (e.ColumnIndex == this.dataGridViewExcelFilter_0.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
                {
                    if (!string.IsNullOrEmpty(Path.GetFileName(this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString())))
                    {
                        e.Value = Path.GetFileName(this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString());
                    }
                    else
                    {
                        e.Value = this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString();
                    }
                }
                if (e.ColumnIndex == this.dataGridViewExcelFilter_0.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
                {
                    Icon icon = FileInfo.IconOfFile(this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString());
                    if (icon != null)
                    {
                        e.Value = icon.ToBitmap();
                    }
                }
            }
        }

        private void dateTimePicker_0_ValueChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormActElectricalInspection_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormActElectricalInspection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.bool_0)
            {
                switch (MessageBox.Show("Были внесены изменения. Сохранить документ?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                    {
                        if (!this.method_5())
                        {
                            e.Cancel = true;
                            return;
                        }
                        bool flag = false;
                        for (int i = 0; i < (this.dataGridView_0.Rows.Count - 1); i++)
                        {
                            if (!Convert.ToBoolean(this.dataGridView_0.Rows[i].Cells[this.dataGridViewCheckBoxColumn_0.Name].Value))
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (flag && (MessageBox.Show("Данные успешно сохранены.\r\nОтправить документ выбранным адресатам?", "Отправка почты", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            this.method_18(true);
                        }
                        break;
                    }
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void FormActElectricalInspection_Load(object sender, EventArgs e)
        {
            this.dateTimePicker_0.Value = DateTime.Now.Date;
            this.method_1();
            this.method_19();
            this.method_2();
            base.LoadFormConfig(null);
            using (IEnumerator enumerator = ((IEnumerable) this.dataGridView_0.Rows).GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ((DataGridViewRow) enumerator.Current).Cells[this.dataGridViewCheckBoxColumn_0.Name].Value = false;
                }
            }
            if (this.int_0 == -1)
            {
                DataRow row = this.dataSetTechConnection_0.tTC_Doc.NewRow();
                row["DateDoc"] = DateTime.Now.Date;
                row["TypeDoc"] = this.int_4;
                row["idParent"] = this.int_1;
                this.dataSetTechConnection_0.tTC_Doc.Rows.Add(row);
            }
            else
            {
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where id = " + this.int_0.ToString());
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_ElectricalInspection, true, "where id = " + this.int_0.ToString());
                if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows.Count > 0)
                {
                    if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["dateRecipient"] != DBNull.Value)
                    {
                        this.dateTimePicker_0.Value = Convert.ToDateTime(this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["dateRecipient"]);
                    }
                    if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["Mail"] != DBNull.Value)
                    {
                        try
                        {
                            XmlDocument document = new XmlDocument();
                            document.LoadXml(this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["Mail"].ToString());
                            this.ApplyConfig(document);
                        }
                        catch
                        {
                        }
                    }
                    this.method_20();
                }
                this.method_15(this.int_0);
            }
            this.bool_0 = false;
        }

        public void GetTepmlate(int idTemplate, out string fileName, out byte[] fileData)
        {
            fileName = "";
            fileData = null;
            string cmdText = "SELECT FileName, FileData FROM tR_DocTemplate WHERE id = @idTemplate";
            using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                command.Parameters.Add("@idTemplate", SqlDbType.Int);
                command.Parameters["@idTemplate"].Value = idTemplate;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        fileName = (string) reader.GetValue(0);
                        fileData = (byte[]) reader.GetValue(1);
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
            this.Text = (this.int_0 == -1) ? "Добавление акта осмотра электроустановки" : "Редактирование акта осмотра электроустановки";
        }

        private void method_1()
        {
            DataTable table = new DataTable("vWorkerGroup");
            table.Columns.Add(new DataColumn("id", typeof(int)));
            table.Columns.Add(new DataColumn("fio", typeof(string)));
            base.SelectSqlData(table, true, "where parentKey = ';GroupWorker;HeadRegion;' order by fio", false);
            DataRow row = table.NewRow();
            row["id"] = DBNull.Value;
            row["fio"] = "";
            table.Rows.InsertAt(row, 0);
            this.comboBox_1.DisplayMember = "FIO";
            this.comboBox_1.ValueMember = "id";
            this.comboBox_1.DataSource = table;
            table = new DataTable("vR_worker");
            table.Columns.Add(new DataColumn("id", typeof(int)));
            table.Columns.Add(new DataColumn("fio", typeof(string)));
            BindingSource source = new BindingSource {
                DataSource = table
            };
            base.SelectSqlData(table, true, "where dateEnd is null order by fio", false);
            this.dataGridViewComboBoxColumn_0.DisplayMember = "FIO";
            this.dataGridViewComboBoxColumn_0.ValueMember = "id";
            this.dataGridViewComboBoxColumn_0.DataSource = source;
        }

        private void method_10(bool bool_1 = false)
        {
            if (this.bindingSource_0.Current != null)
            {
                byte[] file;
                DataSetTechConnection.Class252 row = (DataSetTechConnection.Class252) ((DataRowView) this.bindingSource_0.Current).Row;
                string fileName = row.FileName;
                string str2 = this.method_14();
                string str3 = FileBinary.GetNewFileNameIsExists(str2, fileName, false);
                int? nullable = null;
                if (row["idTemplate"] != DBNull.Value)
                {
                    nullable = new int?(row.idTemplate);
                }
                DateTime dateChange = row.dateChange;
                if (row["File"] == DBNull.Value)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
                        {
                            connection.Open();
                            SqlDataReader reader = new SqlCommand("SELECT [File] FROM tTC_DocFile WHERE id = " + row["id"].ToString(), connection).ExecuteReader();
                            while (reader.Read())
                            {
                                row["File"] = reader["File"];
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Source);
                    }
                }
                try
                {
                    file = row.File;
                }
                catch
                {
                    MessageBox.Show("Нет содержимого файла");
                    return;
                }
                FileBinary binary = new FileBinary(file, str3, DateTime.Now);
                binary.SaveToDisk(str2);
                Process.Start(str2 + @"\" + binary.get_Name());
                if (bool_1)
                {
                    if (this.dictionary_0.ContainsKey(fileName))
                    {
                        if (this.dictionary_0[fileName].get_Watcher() == null)
                        {
                            FileWatcher watcher = new FileWatcher(str2, str3);
                            watcher.add_AnyChanged(new FileSystemEventHandler(this.method_11));
                            watcher.Start();
                            this.dictionary_0[fileName].set_Watcher(watcher);
                        }
                        else
                        {
                            this.dictionary_0[fileName].get_Watcher().remove_AnyChanged(new FileSystemEventHandler(this.method_11));
                            this.dictionary_0[fileName].get_Watcher().Stop();
                            FileWatcher watcher2 = new FileWatcher(str2, str3);
                            watcher2.add_AnyChanged(new FileSystemEventHandler(this.method_11));
                            watcher2.Start();
                            this.dictionary_0[fileName].set_Watcher(watcher2);
                        }
                        this.dictionary_0[fileName].set_TempName(str3);
                        this.dictionary_0[fileName].set_OpenState(1);
                    }
                    else
                    {
                        FileWatcher watcher3 = new FileWatcher(str2, str3);
                        watcher3.add_AnyChanged(new FileSystemEventHandler(this.method_11));
                        watcher3.Start();
                        FileWatcherArgsAddl addl = new FileWatcherArgsAddl(nullable, fileName, str3, watcher3, 1);
                        this.dictionary_0.Add(fileName, addl);
                    }
                }
            }
        }

        private void method_11(object sender, FileSystemEventArgs e)
        {
            Class292 class2 = new Class292 {
                fileSystemEventArgs_0 = e
            };
            class2.ienumerable_0 = this.dictionary_0.Where<KeyValuePair<string, FileWatcherArgsAddl>>(new Func<KeyValuePair<string, FileWatcherArgsAddl>, bool>(class2.method_0));
            if (class2.ienumerable_0.Count<KeyValuePair<string, FileWatcherArgsAddl>>() > 0)
            {
                FileBinary binary = new FileBinary(class2.fileSystemEventArgs_0.FullPath);
                EnumerableRowCollection<DataSetTechConnection.Class252> source = this.dataSetTechConnection_0.tTC_DocFile.Where<DataSetTechConnection.Class252>(new Func<DataSetTechConnection.Class252, bool>(class2.method_1));
                if (source.Count<DataSetTechConnection.Class252>() == 0)
                {
                    DataSetTechConnection.Class252 row = this.dataSetTechConnection_0.tTC_DocFile.method_5();
                    row.idDoc = this.int_0;
                    row.FileName = class2.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.get_OriginalName();
                    row.File = binary.get_ByteArray();
                    row.dateChange = binary.get_LastChanged();
                    row.idTemplate = class2.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.get_IdTemplate().Value;
                    this.dataSetTechConnection_0.tTC_DocFile.Rows.Add(row);
                }
                else
                {
                    source.First<DataSetTechConnection.Class252>().File = binary.get_ByteArray();
                    source.First<DataSetTechConnection.Class252>().dateChange = binary.get_LastChanged();
                    source.First<DataSetTechConnection.Class252>().EndEdit();
                    this.bool_0 = true;
                }
            }
            this.method_13();
        }

        private bool method_12(string string_1)
        {
            Class293 class2 = new Class293 {
                string_0 = string_1
            };
            return (this.dataSetTechConnection_0.tTC_DocFile.Where<DataSetTechConnection.Class252>(new Func<DataSetTechConnection.Class252, bool>(class2.method_0)).Count<DataSetTechConnection.Class252>() > 0);
        }

        private void method_13()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new Action(this.method_23));
            }
            else
            {
                this.bindingSource_0.ResetBindings(false);
            }
        }

        private string method_14()
        {
            string text = this.textBox_0.Text;
            if (string.IsNullOrEmpty(text))
            {
                text = "tmp";
            }
            string path = Path.GetTempPath() + @"\" + text + @"\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        private void method_15(int int_5)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
                {
                    connection.Open();
                    SqlDataReader reader = new SqlCommand("SELECT id, idDoc, FileName, dateChange, idTemplate FROM tTC_DocFile WHERE idDoc = " + int_5.ToString(), connection).ExecuteReader();
                    while (reader.Read())
                    {
                        DataSetTechConnection.Class252 row = this.dataSetTechConnection_0.tTC_DocFile.method_5();
                        row.Int32_0 = (int) reader["id"];
                        row.idDoc = (int) reader["idDoc"];
                        row.FileName = reader["FileName"].ToString();
                        if (reader["dateChange"] != DBNull.Value)
                        {
                            row.dateChange = (DateTime) reader["dateChange"];
                        }
                        int? nullable = null;
                        if (reader["idTemplate"] != DBNull.Value)
                        {
                            nullable = new int?(row.idTemplate = (int) reader["idTemplate"]);
                        }
                        this.dataSetTechConnection_0.tTC_DocFile.Rows.Add(row);
                        row.AcceptChanges();
                        FileWatcherArgsAddl addl = new FileWatcherArgsAddl(nullable, reader["FileName"].ToString(), null, 2);
                        this.dictionary_0.Add(reader["FileName"].ToString(), addl);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private bool method_16()
        {
            foreach (DataRow row in this.dataSetTechConnection_0.tTC_DocFile)
            {
                if (((row.RowState != DataRowState.Deleted) && (row.RowState != DataRowState.Detached)) && (Convert.ToInt32(row["idDoc"]) != this.int_0))
                {
                    row["idDoc"] = this.int_0;
                    row.EndEdit();
                }
            }
            if ((base.InsertSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocFile) && base.UpdateSqlDataOnlyChange(this.dataSetTechConnection_0.tTC_DocFile)) && base.DeleteSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_DocFile))
            {
                this.dataSetTechConnection_0.tTC_DocFile.AcceptChanges();
                return true;
            }
            return false;
        }

        private void method_17(object sender, EventArgs e)
        {
            if (((this.dataGridView_0.CurrentCell != null) && (((ComboBox) sender).SelectedValue != null)) && (((ComboBox) sender).SelectedValue.GetType() != typeof(DataRowView)))
            {
                DataTable table = base.SelectSqlData("tR_WorkerContact", true, "where Worker = " + Convert.ToInt32(((ComboBox) sender).SelectedValue).ToString() + " and Type = 44");
                if ((table.Rows.Count > 0) && (table.Rows[0]["Description"] != DBNull.Value))
                {
                    this.dataGridView_0[this.dataGridViewTextBoxColumn_9.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = table.Rows[0]["Description"].ToString();
                }
                else
                {
                    this.dataGridView_0[this.dataGridViewTextBoxColumn_9.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = "адрес не задан";
                }
                this.dataGridView_0[this.dataGridViewCheckBoxColumn_0.Name, this.dataGridView_0.CurrentCell.RowIndex].Value = false;
                this.bool_0 = true;
            }
        }

        private void method_18(bool bool_1 = false)
        {
            if (this.dataGridView_0.Rows.Count > 0)
            {
                string str = "Сформирован акт осмотра электроустановок №" + this.textBox_0.Text + " от " + Convert.ToDateTime(this.nullableDateTimePicker_0.get_Value()).ToString("dd.MM.yyyy");
                if (this.comboBox_0.SelectedValue != null)
                {
                    try
                    {
                        DataTable table = base.SelectSqlData("ttc_doc", true, "where id = " + this.comboBox_0.SelectedValue.ToString());
                        if (table.Rows.Count > 0)
                        {
                            string[] textArray1 = new string[] { str, " по техническим условиям №", table.Rows[0]["numdoc"].ToString(), " от ", Convert.ToDateTime(table.Rows[0]["datedoc"]).ToString("dd.MM.yyyy") };
                            str = string.Concat(textArray1);
                        }
                    }
                    catch
                    {
                    }
                }
                str = str + "\r\n\r\n Крайняя дата осмотра - " + this.dateTimePicker_0.Value.ToString("dd.MM.yyyy");
                for (int i = 0; i < (this.dataGridView_0.Rows.Count - 1); i++)
                {
                    if (!bool_1 || !Convert.ToBoolean(this.dataGridView_0[this.dataGridViewCheckBoxColumn_0.Name, i].Value))
                    {
                        List<Struct4> list = new List<Struct4> {
                            new Struct4(this.dataGridView_0[this.dataGridViewTextBoxColumn_9.Name, i].Value.ToString(), this.dataGridView_0[this.dataGridViewComboBoxColumn_0.Name, i].FormattedValue.ToString())
                        };
                        if (ExportRequestForRepair.smethod_13(this.textBox_9.Text, Convert.ToInt32(this.textBox_8.Text), this.textBox_5.Text, this.textBox_6.Text, this.textBox_4.Text, this.textBox_7.Text, list, this.textBox_10.Text, str, null, false))
                        {
                            this.dataGridView_0[this.dataGridViewCheckBoxColumn_0.Name, i].Value = true;
                        }
                        else
                        {
                            this.dataGridView_0[this.dataGridViewCheckBoxColumn_0.Name, i].Value = false;
                        }
                    }
                }
            }
            if (this.method_6())
            {
                this.bool_0 = false;
            }
        }

        private void method_19()
        {
            DataTable table = new DataTable("tR_Worker");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("F", typeof(string));
            table.Columns.Add("I", typeof(string));
            table.Columns.Add("O", typeof(string));
            table.Columns.Add("FIO", typeof(string), "F + ' ' + I + ' ' + O");
            this.comboBox_5.DisplayMember = "FIO";
            this.comboBox_5.ValueMember = "id";
            this.comboBox_5.DataSource = table;
            base.SelectSqlData(table, true, " where dateEnd is null order by F, I, O", false);
            this.comboBox_5.SelectedIndex = -1;
            table = new DataTable("tR_Worker");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("F", typeof(string));
            table.Columns.Add("I", typeof(string));
            table.Columns.Add("O", typeof(string));
            table.Columns.Add("FIO", typeof(string), "F + ' ' + I + ' ' + O");
            this.comboBox_4.DisplayMember = "FIO";
            this.comboBox_4.ValueMember = "id";
            this.comboBox_4.DataSource = table;
            base.SelectSqlData(table, true, " where dateEnd is null order by F, I, O", false);
            this.comboBox_4.SelectedIndex = -1;
            table = new DataTable("tR_Worker");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("F", typeof(string));
            table.Columns.Add("I", typeof(string));
            table.Columns.Add("O", typeof(string));
            table.Columns.Add("FIO", typeof(string), "F + ' ' + I + ' ' + O");
            this.comboBox_3.DisplayMember = "FIO";
            this.comboBox_3.ValueMember = "id";
            this.comboBox_3.DataSource = table;
            base.SelectSqlData(table, true, " where dateEnd is null order by F, I, O", false);
            this.comboBox_3.SelectedIndex = -1;
            table = new DataTable("tR_Worker");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("F", typeof(string));
            table.Columns.Add("I", typeof(string));
            table.Columns.Add("O", typeof(string));
            table.Columns.Add("FIO", typeof(string), "F + ' ' + I + ' ' + O");
            this.comboBox_2.DisplayMember = "FIO";
            this.comboBox_2.ValueMember = "id";
            this.comboBox_2.DataSource = table;
            base.SelectSqlData(table, true, " where dateEnd is null order by F, I, O", false);
            this.comboBox_2.SelectedIndex = -1;
        }

        private void method_2()
        {
            string[] textArray1 = new string[] { "select  d.id, d.numdoc, d.datedoc,  isnull(d.numdoc, '') + ' от ' + isnull(convert( varchar(10),d.Datedoc, 104), '') as numDatedoc  from ttc_doc d  where typeDoc = ", 0x463.ToString(), " and (id not in (select idparent from ttc_doc where typedoc = ", 0x4d6.ToString(), " and idParent is not null) or id in (select idParent from ttc_doc where id = ", this.IdAct.ToString(), " and idParent is not null)) " };
            string selectCommandText = string.Concat(textArray1) + " order by numDoc, dateDoc ";
            DataTable dataTable = new DataTable();
            SqlDataConnect connect = new SqlDataConnect();
            if (connect.OpenConnection(this.get_SqlSettings()))
            {
                try
                {
                    new SqlDataAdapter(selectCommandText, connect.get_Connection()).Fill(dataTable);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
            this.comboBox_0.SelectedValueChanged -= new EventHandler(this.comboBox_0_SelectedValueChanged);
            BindingSource source = new BindingSource {
                DataSource = dataTable,
                Sort = "numDoc, dateDoc"
            };
            this.comboBox_0.DataSource = source;
            this.comboBox_0.DisplayMember = "numDateDoc";
            this.comboBox_0.ValueMember = "id";
            this.comboBox_0.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            if (this.int_1 != -1)
            {
                this.comboBox_0.SelectedValue = this.int_1;
            }
            else
            {
                this.comboBox_0.SelectedIndex = -1;
            }
        }

        private void method_20()
        {
            if ((this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows.Count > 0) && (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["Officials"] != DBNull.Value))
            {
                try
                {
                    XmlDocument document1 = new XmlDocument();
                    document1.LoadXml(this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["Officials"].ToString());
                    XmlNode node = document1.SelectSingleNode("Official");
                    if (node != null)
                    {
                        XmlNode node2 = node.SelectSingleNode("Seti");
                        if (node2 != null)
                        {
                            XmlNode node4 = node2.SelectSingleNode("FIO1");
                            if (node4 != null)
                            {
                                XmlAttribute attribute = node4.Attributes["FIO"];
                                if (attribute != null)
                                {
                                    this.comboBox_5.Text = attribute.Value;
                                }
                                attribute = node4.Attributes["JobTitle"];
                                if (attribute != null)
                                {
                                    this.textBox_21.Text = attribute.Value;
                                }
                            }
                            XmlNode node5 = node2.SelectSingleNode("FIO2");
                            if (node5 != null)
                            {
                                XmlAttribute attribute2 = node5.Attributes["FIO"];
                                if (attribute2 != null)
                                {
                                    this.comboBox_4.Text = attribute2.Value;
                                }
                                attribute2 = node5.Attributes["JobTitle"];
                                if (attribute2 != null)
                                {
                                    this.textBox_20.Text = attribute2.Value;
                                }
                            }
                            XmlNode node6 = node2.SelectSingleNode("FIO3");
                            if (node6 != null)
                            {
                                XmlAttribute attribute3 = node6.Attributes["FIO"];
                                if (attribute3 != null)
                                {
                                    this.comboBox_3.Text = attribute3.Value;
                                }
                                attribute3 = node6.Attributes["JobTitle"];
                                if (attribute3 != null)
                                {
                                    this.textBox_19.Text = attribute3.Value;
                                }
                            }
                            XmlNode node7 = node2.SelectSingleNode("Official");
                            if (node7 != null)
                            {
                                XmlAttribute attribute4 = node7.Attributes["FIO"];
                                if (attribute4 != null)
                                {
                                    this.comboBox_2.Text = attribute4.Value;
                                }
                                attribute4 = node7.Attributes["JobTitle"];
                                if (attribute4 != null)
                                {
                                    this.textBox_18.Text = attribute4.Value;
                                }
                            }
                        }
                        XmlNode node3 = node.SelectSingleNode("Declarer");
                        if (node3 != null)
                        {
                            XmlNode node8 = node3.SelectSingleNode("FIO1");
                            if (node8 != null)
                            {
                                XmlAttribute attribute5 = node8.Attributes["FIO"];
                                if (attribute5 != null)
                                {
                                    this.textBox_28.Text = attribute5.Value;
                                }
                                attribute5 = node8.Attributes["JobTitle"];
                                if (attribute5 != null)
                                {
                                    this.textBox_29.Text = attribute5.Value;
                                }
                            }
                            node8 = node3.SelectSingleNode("FIO2");
                            if (node8 != null)
                            {
                                XmlAttribute attribute6 = node8.Attributes["FIO"];
                                if (attribute6 != null)
                                {
                                    this.textBox_26.Text = attribute6.Value;
                                }
                                attribute6 = node8.Attributes["JobTitle"];
                                if (attribute6 != null)
                                {
                                    this.textBox_27.Text = attribute6.Value;
                                }
                            }
                            node8 = node3.SelectSingleNode("FIO3");
                            if (node8 != null)
                            {
                                XmlAttribute attribute7 = node8.Attributes["FIO"];
                                if (attribute7 != null)
                                {
                                    this.textBox_24.Text = attribute7.Value;
                                }
                                attribute7 = node8.Attributes["JobTitle"];
                                if (attribute7 != null)
                                {
                                    this.textBox_25.Text = attribute7.Value;
                                }
                            }
                            node8 = node3.SelectSingleNode("FIO4");
                            if (node8 != null)
                            {
                                XmlAttribute attribute8 = node8.Attributes["FIO"];
                                if (attribute8 != null)
                                {
                                    this.textBox_22.Text = attribute8.Value;
                                }
                                attribute8 = node8.Attributes["JobTitle"];
                                if (attribute8 != null)
                                {
                                    this.textBox_23.Text = attribute8.Value;
                                }
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

        private XmlDocument method_21()
        {
            XmlDocument document1 = new XmlDocument();
            XmlNode newChild = document1.CreateElement("Official");
            document1.AppendChild(newChild);
            XmlNode node2 = document1.CreateElement("Seti");
            newChild.AppendChild(node2);
            XmlNode node3 = document1.CreateElement("FIO1");
            node2.AppendChild(node3);
            XmlAttribute node = document1.CreateAttribute("FIO");
            node.Value = this.comboBox_5.Text;
            node3.Attributes.Append(node);
            node = document1.CreateAttribute("JobTitle");
            node.Value = this.textBox_21.Text;
            node3.Attributes.Append(node);
            XmlNode node4 = document1.CreateElement("FIO2");
            node2.AppendChild(node4);
            node = document1.CreateAttribute("FIO");
            node.Value = this.comboBox_4.Text;
            node4.Attributes.Append(node);
            node = document1.CreateAttribute("JobTitle");
            node.Value = this.textBox_20.Text;
            node4.Attributes.Append(node);
            XmlNode node5 = document1.CreateElement("FIO3");
            node2.AppendChild(node5);
            node = document1.CreateAttribute("FIO");
            node.Value = this.comboBox_3.Text;
            node5.Attributes.Append(node);
            node = document1.CreateAttribute("JobTitle");
            node.Value = this.textBox_19.Text;
            node5.Attributes.Append(node);
            XmlNode node6 = document1.CreateElement("Official");
            node2.AppendChild(node6);
            node = document1.CreateAttribute("FIO");
            node.Value = this.comboBox_2.Text;
            node6.Attributes.Append(node);
            node = document1.CreateAttribute("JobTitle");
            node.Value = this.textBox_18.Text;
            node6.Attributes.Append(node);
            XmlNode node7 = document1.CreateElement("Declarer");
            newChild.AppendChild(node7);
            XmlNode node8 = document1.CreateElement("FIO1");
            node7.AppendChild(node8);
            node = document1.CreateAttribute("FIO");
            node.Value = this.textBox_28.Text;
            node8.Attributes.Append(node);
            node = document1.CreateAttribute("JobTitle");
            node.Value = this.textBox_29.Text;
            node8.Attributes.Append(node);
            node8 = document1.CreateElement("FIO2");
            node7.AppendChild(node8);
            node = document1.CreateAttribute("FIO");
            node.Value = this.textBox_26.Text;
            node8.Attributes.Append(node);
            node = document1.CreateAttribute("JobTitle");
            node.Value = this.textBox_27.Text;
            node8.Attributes.Append(node);
            node8 = document1.CreateElement("FIO3");
            node7.AppendChild(node8);
            node = document1.CreateAttribute("FIO");
            node.Value = this.textBox_24.Text;
            node8.Attributes.Append(node);
            node = document1.CreateAttribute("JobTitle");
            node.Value = this.textBox_25.Text;
            node8.Attributes.Append(node);
            node8 = document1.CreateElement("FIO4");
            node7.AppendChild(node8);
            node = document1.CreateAttribute("FIO");
            node.Value = this.textBox_22.Text;
            node8.Attributes.Append(node);
            node = document1.CreateAttribute("JobTitle");
            node.Value = this.textBox_23.Text;
            node8.Attributes.Append(node);
            return document1;
        }

        private void method_22()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.label_0 = new Label();
            this.textBox_0 = new TextBox();
            this.dataSetTechConnection_0 = new DataSetTechConnection();
            this.label_1 = new Label();
            this.nullableDateTimePicker_0 = new NullableDateTimePicker();
            this.label_2 = new Label();
            this.textBox_1 = new TextBox();
            this.label_3 = new Label();
            this.comboBox_0 = new ComboBox();
            this.textBox_2 = new TextBox();
            this.label_4 = new Label();
            this.textBox_3 = new TextBox();
            this.label_5 = new Label();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.textBox_12 = new TextBox();
            this.label_16 = new Label();
            this.textBox_11 = new TextBox();
            this.label_15 = new Label();
            this.comboBox_1 = new ComboBox();
            this.label_6 = new Label();
            this.tabPage_3 = new TabPage();
            this.textBox_15 = new TextBox();
            this.label_19 = new Label();
            this.textBox_16 = new TextBox();
            this.label_20 = new Label();
            this.textBox_17 = new TextBox();
            this.label_21 = new Label();
            this.textBox_13 = new TextBox();
            this.label_17 = new Label();
            this.textBox_14 = new TextBox();
            this.label_18 = new Label();
            this.tabPage_4 = new TabPage();
            this.splitContainer_1 = new SplitContainer();
            this.groupBox_0 = new GroupBox();
            this.textBox_18 = new TextBox();
            this.label_24 = new Label();
            this.comboBox_2 = new ComboBox();
            this.label_25 = new Label();
            this.groupBox_1 = new GroupBox();
            this.textBox_19 = new TextBox();
            this.label_26 = new Label();
            this.comboBox_3 = new ComboBox();
            this.label_27 = new Label();
            this.groupBox_2 = new GroupBox();
            this.textBox_20 = new TextBox();
            this.label_28 = new Label();
            this.comboBox_4 = new ComboBox();
            this.label_29 = new Label();
            this.groupBox_3 = new GroupBox();
            this.textBox_21 = new TextBox();
            this.label_30 = new Label();
            this.comboBox_5 = new ComboBox();
            this.label_31 = new Label();
            this.label_22 = new Label();
            this.groupBox_4 = new GroupBox();
            this.textBox_22 = new TextBox();
            this.textBox_23 = new TextBox();
            this.label_32 = new Label();
            this.label_33 = new Label();
            this.groupBox_5 = new GroupBox();
            this.textBox_24 = new TextBox();
            this.textBox_25 = new TextBox();
            this.label_34 = new Label();
            this.label_35 = new Label();
            this.groupBox_6 = new GroupBox();
            this.textBox_26 = new TextBox();
            this.textBox_27 = new TextBox();
            this.label_36 = new Label();
            this.label_37 = new Label();
            this.groupBox_7 = new GroupBox();
            this.textBox_28 = new TextBox();
            this.textBox_29 = new TextBox();
            this.label_38 = new Label();
            this.label_39 = new Label();
            this.label_23 = new Label();
            this.tabPage_1 = new TabPage();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.toolStrip_0 = new ToolStrip();
            this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_4 = new ToolStripButton();
            this.tabPage_2 = new TabPage();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_14 = new Label();
            this.button_2 = new Button();
            this.textBox_10 = new TextBox();
            this.label_13 = new Label();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.splitContainer_0 = new SplitContainer();
            this.textBox_4 = new TextBox();
            this.label_7 = new Label();
            this.textBox_5 = new TextBox();
            this.label_8 = new Label();
            this.textBox_6 = new TextBox();
            this.textBox_7 = new TextBox();
            this.label_9 = new Label();
            this.label_10 = new Label();
            this.textBox_8 = new TextBox();
            this.label_11 = new Label();
            this.textBox_9 = new TextBox();
            this.label_12 = new Label();
            this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.toolStripMenuItem_2 = new ToolStripMenuItem();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripMenuItem_3 = new ToolStripMenuItem();
            this.toolStripMenuItem_4 = new ToolStripMenuItem();
            this.toolStripMenuItem_5 = new ToolStripMenuItem();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolStripMenuItem_6 = new ToolStripMenuItem();
            this.toolStripMenuItem_7 = new ToolStripMenuItem();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataSetTechConnection_0.BeginInit();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.tabPage_3.SuspendLayout();
            this.tabPage_4.SuspendLayout();
            this.splitContainer_1.Panel1.SuspendLayout();
            this.splitContainer_1.Panel2.SuspendLayout();
            this.splitContainer_1.SuspendLayout();
            this.groupBox_0.SuspendLayout();
            this.groupBox_1.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            this.groupBox_3.SuspendLayout();
            this.groupBox_4.SuspendLayout();
            this.groupBox_5.SuspendLayout();
            this.groupBox_6.SuspendLayout();
            this.groupBox_7.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.toolStrip_0.SuspendLayout();
            this.tabPage_2.SuspendLayout();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.contextMenuStrip_0.SuspendLayout();
            base.SuspendLayout();
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 6);
            this.label_0.Name = "label2";
            this.label_0.Size = new Size(0x43, 13);
            this.label_0.TabIndex = 0x12;
            this.label_0.Text = "Номер акта";
            this.textBox_0.BackColor = SystemColors.Window;
            this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.numDoc", true));
            this.textBox_0.Location = new Point(8, 0x16);
            this.textBox_0.Name = "txtNumDoc";
            this.textBox_0.ReadOnly = true;
            this.textBox_0.Size = new Size(0xaf, 20);
            this.textBox_0.TabIndex = 0x13;
            this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(0xba, 6);
            this.label_1.Name = "label3";
            this.label_1.Size = new Size(0x3b, 13);
            this.label_1.TabIndex = 0x15;
            this.label_1.Text = "Дата акта";
            this.nullableDateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_Doc.dateDoc", true));
            this.nullableDateTimePicker_0.Location = new Point(0xbd, 0x16);
            this.nullableDateTimePicker_0.Name = "dateTimePickerDocOut";
            this.nullableDateTimePicker_0.Size = new Size(0x1b3, 20);
            this.nullableDateTimePicker_0.TabIndex = 20;
            this.nullableDateTimePicker_0.set_Value(new DateTime(0x7dd, 4, 0x1d, 14, 0x26, 3, 750));
            this.nullableDateTimePicker_0.ValueChanged += new EventHandler(this.nullableDateTimePicker_0_ValueChanged);
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(12, 0xf2);
            this.label_2.Name = "label5";
            this.label_2.Size = new Size(0x2d, 13);
            this.label_2.TabIndex = 0x1a;
            this.label_2.Text = "Объект";
            this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_1.BackColor = SystemColors.Window;
            this.textBox_1.Location = new Point(0x91, 0xef);
            this.textBox_1.Name = "txtAbnObj";
            this.textBox_1.ReadOnly = true;
            this.textBox_1.Size = new Size(0x1df, 20);
            this.textBox_1.TabIndex = 0x1b;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(12, 0xc0);
            this.label_3.Name = "labelNumDateIn";
            this.label_3.Size = new Size(0x5e, 13);
            this.label_3.TabIndex = 0x16;
            this.label_3.Text = "Номер и дата ТУ";
            this.comboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_Doc.IdParent", true));
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(0x91, 0xbd);
            this.comboBox_0.Name = "cmbNumDateIn";
            this.comboBox_0.Size = new Size(0x1df, 0x15);
            this.comboBox_0.TabIndex = 0x17;
            this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.comboBox_0.SelectedValueChanged += new EventHandler(this.comboBox_0_SelectedValueChanged);
            this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_2.BackColor = SystemColors.Window;
            this.textBox_2.Location = new Point(0x91, 0xd7);
            this.textBox_2.Name = "txtAbn";
            this.textBox_2.ReadOnly = true;
            this.textBox_2.Size = new Size(0x1df, 20);
            this.textBox_2.TabIndex = 0x19;
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(12, 0xda);
            this.label_4.Name = "label9";
            this.label_4.Size = new Size(0x31, 13);
            this.label_4.TabIndex = 0x18;
            this.label_4.Text = "Абонент";
            this.textBox_3.AcceptsReturn = true;
            this.textBox_3.AcceptsTab = true;
            this.textBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.textBox_3.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_Doc.Comment", true));
            this.textBox_3.Location = new Point(8, 0x116);
            this.textBox_3.Multiline = true;
            this.textBox_3.Name = "txtBody";
            this.textBox_3.Size = new Size(0x26b, 0x3d);
            this.textBox_3.TabIndex = 0x1d;
            this.textBox_3.TextChanged += new EventHandler(this.textBox_3_TextChanged);
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(12, 0x106);
            this.label_5.Name = "label7";
            this.label_5.Size = new Size(0x4d, 13);
            this.label_5.TabIndex = 0x1c;
            this.label_5.Text = "Комментарий";
            this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_0.Location = new Point(9, 0x180);
            this.button_0.Name = "buttonSave";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 30;
            this.button_0.Text = "Сохранить";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_1.Location = new Point(550, 0x180);
            this.button_1.Name = "buttonClose";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 0x1f;
            this.button_1.Text = "Закрыть";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.tabControl_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_3);
            this.tabControl_0.Controls.Add(this.tabPage_4);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Controls.Add(this.tabPage_2);
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Name = "tabControl";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x27e, 0x173);
            this.tabControl_0.TabIndex = 0x20;
            this.tabPage_0.Controls.Add(this.textBox_12);
            this.tabPage_0.Controls.Add(this.label_16);
            this.tabPage_0.Controls.Add(this.textBox_11);
            this.tabPage_0.Controls.Add(this.label_15);
            this.tabPage_0.Controls.Add(this.comboBox_1);
            this.tabPage_0.Controls.Add(this.label_6);
            this.tabPage_0.Controls.Add(this.textBox_0);
            this.tabPage_0.Controls.Add(this.nullableDateTimePicker_0);
            this.tabPage_0.Controls.Add(this.label_1);
            this.tabPage_0.Controls.Add(this.textBox_3);
            this.tabPage_0.Controls.Add(this.label_0);
            this.tabPage_0.Controls.Add(this.label_5);
            this.tabPage_0.Controls.Add(this.label_4);
            this.tabPage_0.Controls.Add(this.label_2);
            this.tabPage_0.Controls.Add(this.textBox_2);
            this.tabPage_0.Controls.Add(this.textBox_1);
            this.tabPage_0.Controls.Add(this.comboBox_0);
            this.tabPage_0.Controls.Add(this.label_3);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tabPageGeneral";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(630, 0x159);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Общие";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.textBox_12.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_12.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_ElectricalInspection.Electrical", true));
            this.textBox_12.Location = new Point(8, 0x84);
            this.textBox_12.Multiline = true;
            this.textBox_12.Name = "textBox1";
            this.textBox_12.Size = new Size(0x268, 0x33);
            this.textBox_12.TabIndex = 0x23;
            this.textBox_12.TextChanged += new EventHandler(this.textBox_12_TextChanged);
            this.label_16.AutoSize = true;
            this.label_16.Location = new Point(12, 0x74);
            this.label_16.Name = "label16";
            this.label_16.Size = new Size(0xae, 13);
            this.label_16.TabIndex = 0x22;
            this.label_16.Text = "Осмотренные электроустановки";
            this.textBox_11.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_11.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_ElectricalInspection.Declarer", true));
            this.textBox_11.Location = new Point(8, 0x5d);
            this.textBox_11.Name = "txtDeclarer";
            this.textBox_11.Size = new Size(0x268, 20);
            this.textBox_11.TabIndex = 0x21;
            this.textBox_11.TextChanged += new EventHandler(this.textBox_11_TextChanged);
            this.label_15.AutoSize = true;
            this.label_15.Location = new Point(11, 0x4d);
            this.label_15.Name = "label15";
            this.label_15.Size = new Size(0xeb, 13);
            this.label_15.TabIndex = 0x20;
            this.label_15.Text = "Заявитель (уполномоченный представитель)";
            this.comboBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSetTechConnection_0, "tTC_ElectricalInspection.idWorker", true));
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(0x63, 0x35);
            this.comboBox_1.Name = "cmbChiefSR";
            this.comboBox_1.Size = new Size(0x20d, 0x15);
            this.comboBox_1.TabIndex = 0x1f;
            this.comboBox_1.SelectedIndexChanged += new EventHandler(this.comboBox_1_SelectedIndexChanged);
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(12, 0x38);
            this.label_6.Name = "label1";
            this.label_6.Size = new Size(0x51, 13);
            this.label_6.TabIndex = 30;
            this.label_6.Text = "Акт составлен";
            this.tabPage_3.Controls.Add(this.textBox_15);
            this.tabPage_3.Controls.Add(this.label_19);
            this.tabPage_3.Controls.Add(this.textBox_16);
            this.tabPage_3.Controls.Add(this.label_20);
            this.tabPage_3.Controls.Add(this.textBox_17);
            this.tabPage_3.Controls.Add(this.label_21);
            this.tabPage_3.Controls.Add(this.textBox_13);
            this.tabPage_3.Controls.Add(this.label_17);
            this.tabPage_3.Controls.Add(this.textBox_14);
            this.tabPage_3.Controls.Add(this.label_18);
            this.tabPage_3.Location = new Point(4, 0x16);
            this.tabPage_3.Name = "tabPageSet";
            this.tabPage_3.Padding = new Padding(3);
            this.tabPage_3.Size = new Size(630, 0x159);
            this.tabPage_3.TabIndex = 3;
            this.tabPage_3.Text = "Установлено";
            this.tabPage_3.UseVisualStyleBackColor = true;
            this.textBox_15.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_15.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_ElectricalInspection.SetDocument", true));
            this.textBox_15.Location = new Point(8, 0x125);
            this.textBox_15.Multiline = true;
            this.textBox_15.Name = "txtSetDocument";
            this.textBox_15.Size = new Size(0x268, 0x31);
            this.textBox_15.TabIndex = 9;
            this.textBox_15.TextChanged += new EventHandler(this.textBox_14_TextChanged);
            this.label_19.AutoSize = true;
            this.label_19.Location = new Point(8, 0x115);
            this.label_19.Name = "label21";
            this.label_19.Size = new Size(0xea, 13);
            this.label_19.TabIndex = 8;
            this.label_19.Text = "Документы, рассмотренные в ходе осмотра";
            this.textBox_16.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_16.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_ElectricalInspection.SetReserveCP", true));
            this.textBox_16.Location = new Point(8, 0xdf);
            this.textBox_16.Multiline = true;
            this.textBox_16.Name = "txtSetReserveCP";
            this.textBox_16.Size = new Size(0x268, 0x31);
            this.textBox_16.TabIndex = 7;
            this.textBox_16.TextChanged += new EventHandler(this.textBox_14_TextChanged);
            this.label_20.AutoSize = true;
            this.label_20.Location = new Point(8, 0xcf);
            this.label_20.Name = "label20";
            this.label_20.Size = new Size(0xdf, 13);
            this.label_20.TabIndex = 6;
            this.label_20.Text = "Автономный резервный источник питания";
            this.textBox_17.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_17.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_ElectricalInspection.SerRZA", true));
            this.textBox_17.Location = new Point(8, 0x9c);
            this.textBox_17.Multiline = true;
            this.textBox_17.Name = "txtSetRZA";
            this.textBox_17.Size = new Size(0x268, 0x31);
            this.textBox_17.TabIndex = 5;
            this.textBox_17.TextChanged += new EventHandler(this.textBox_14_TextChanged);
            this.label_21.AutoSize = true;
            this.label_21.Location = new Point(8, 140);
            this.label_21.Name = "label19";
            this.label_21.Size = new Size(0x1b3, 13);
            this.label_21.TabIndex = 4;
            this.label_21.Text = "Устройства защиты, релейной защиты, противоаварийной и режимной автоматики";
            this.textBox_13.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_13.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_ElectricalInspection.SetMeterDevice", true));
            this.textBox_13.Location = new Point(8, 0x57);
            this.textBox_13.Multiline = true;
            this.textBox_13.Name = "txtSetMeterDevice";
            this.textBox_13.Size = new Size(0x268, 0x31);
            this.textBox_13.TabIndex = 3;
            this.textBox_13.TextChanged += new EventHandler(this.textBox_14_TextChanged);
            this.label_17.AutoSize = true;
            this.label_17.Location = new Point(8, 0x47);
            this.label_17.Name = "label18";
            this.label_17.Size = new Size(0xca, 13);
            this.label_17.TabIndex = 2;
            this.label_17.Text = "Хар-ки установленных приборов учета";
            this.textBox_14.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_14.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_0, "tTC_ElectricalInspection.SetElectrical", true));
            this.textBox_14.Location = new Point(8, 0x13);
            this.textBox_14.Multiline = true;
            this.textBox_14.Name = "txtSetElectrical";
            this.textBox_14.Size = new Size(0x268, 0x31);
            this.textBox_14.TabIndex = 1;
            this.textBox_14.TextChanged += new EventHandler(this.textBox_14_TextChanged);
            this.label_18.AutoSize = true;
            this.label_18.Location = new Point(8, 3);
            this.label_18.Name = "label17";
            this.label_18.Size = new Size(0x167, 13);
            this.label_18.TabIndex = 0;
            this.label_18.Text = "Перечень и хар-ки электрооборудования, предъявленного к осмотру";
            this.tabPage_4.Controls.Add(this.splitContainer_1);
            this.tabPage_4.Location = new Point(4, 0x16);
            this.tabPage_4.Name = "tabPageOfficials";
            this.tabPage_4.Size = new Size(630, 0x159);
            this.tabPage_4.TabIndex = 4;
            this.tabPage_4.Text = "Должностные лица";
            this.tabPage_4.UseVisualStyleBackColor = true;
            this.splitContainer_1.Dock = DockStyle.Fill;
            this.splitContainer_1.Location = new Point(0, 0);
            this.splitContainer_1.Name = "splitContainer2";
            this.splitContainer_1.Panel1.Controls.Add(this.groupBox_0);
            this.splitContainer_1.Panel1.Controls.Add(this.groupBox_1);
            this.splitContainer_1.Panel1.Controls.Add(this.groupBox_2);
            this.splitContainer_1.Panel1.Controls.Add(this.groupBox_3);
            this.splitContainer_1.Panel1.Controls.Add(this.label_22);
            this.splitContainer_1.Panel2.Controls.Add(this.groupBox_4);
            this.splitContainer_1.Panel2.Controls.Add(this.groupBox_5);
            this.splitContainer_1.Panel2.Controls.Add(this.groupBox_6);
            this.splitContainer_1.Panel2.Controls.Add(this.groupBox_7);
            this.splitContainer_1.Panel2.Controls.Add(this.label_23);
            this.splitContainer_1.Size = new Size(630, 0x159);
            this.splitContainer_1.SplitterDistance = 0x13b;
            this.splitContainer_1.TabIndex = 0;
            this.groupBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_0.Controls.Add(this.textBox_18);
            this.groupBox_0.Controls.Add(this.label_24);
            this.groupBox_0.Controls.Add(this.comboBox_2);
            this.groupBox_0.Controls.Add(this.label_25);
            this.groupBox_0.Location = new Point(3, 0xfd);
            this.groupBox_0.Name = "groupBoxSetOfficial";
            this.groupBox_0.Size = new Size(0x135, 0x45);
            this.groupBox_0.TabIndex = 4;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "Должностное лицо сетевой организации";
            this.textBox_18.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_18.Location = new Point(0x4d, 40);
            this.textBox_18.Name = "txtSetJobTitleOfficial";
            this.textBox_18.Size = new Size(0xe2, 20);
            this.textBox_18.TabIndex = 3;
            this.textBox_18.TextChanged += new EventHandler(this.textBox_29_TextChanged);
            this.label_24.AutoSize = true;
            this.label_24.Location = new Point(6, 0x2b);
            this.label_24.Name = "label30";
            this.label_24.Size = new Size(0x41, 13);
            this.label_24.TabIndex = 2;
            this.label_24.Text = "Должность";
            this.comboBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_2.FormattingEnabled = true;
            this.comboBox_2.Location = new Point(0x2e, 13);
            this.comboBox_2.Name = "cmbSetOfficial";
            this.comboBox_2.Size = new Size(0x101, 0x15);
            this.comboBox_2.TabIndex = 1;
            this.comboBox_2.SelectedValueChanged += new EventHandler(this.comboBox_2_SelectedValueChanged);
            this.comboBox_2.TextChanged += new EventHandler(this.comboBox_5_TextChanged);
            this.label_25.AutoSize = true;
            this.label_25.Location = new Point(6, 0x10);
            this.label_25.Name = "label31";
            this.label_25.Size = new Size(0x22, 13);
            this.label_25.TabIndex = 0;
            this.label_25.Text = "ФИО";
            this.groupBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_1.Controls.Add(this.textBox_19);
            this.groupBox_1.Controls.Add(this.label_26);
            this.groupBox_1.Controls.Add(this.comboBox_3);
            this.groupBox_1.Controls.Add(this.label_27);
            this.groupBox_1.Location = new Point(3, 0xb2);
            this.groupBox_1.Name = "groupBoxSet3";
            this.groupBox_1.Size = new Size(0x135, 0x45);
            this.groupBox_1.TabIndex = 3;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "3";
            this.textBox_19.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_19.Location = new Point(0x4d, 40);
            this.textBox_19.Name = "txtSetJobTitle3";
            this.textBox_19.Size = new Size(0xe2, 20);
            this.textBox_19.TabIndex = 3;
            this.textBox_19.TextChanged += new EventHandler(this.textBox_29_TextChanged);
            this.label_26.AutoSize = true;
            this.label_26.Location = new Point(6, 0x2b);
            this.label_26.Name = "label28";
            this.label_26.Size = new Size(0x41, 13);
            this.label_26.TabIndex = 2;
            this.label_26.Text = "Должность";
            this.comboBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_3.FormattingEnabled = true;
            this.comboBox_3.Location = new Point(0x2e, 13);
            this.comboBox_3.Name = "cmbSetFIO3";
            this.comboBox_3.Size = new Size(0x101, 0x15);
            this.comboBox_3.TabIndex = 1;
            this.comboBox_3.SelectedValueChanged += new EventHandler(this.comboBox_3_SelectedValueChanged);
            this.comboBox_3.TextChanged += new EventHandler(this.comboBox_5_TextChanged);
            this.label_27.AutoSize = true;
            this.label_27.Location = new Point(6, 0x10);
            this.label_27.Name = "label29";
            this.label_27.Size = new Size(0x22, 13);
            this.label_27.TabIndex = 0;
            this.label_27.Text = "ФИО";
            this.groupBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_2.Controls.Add(this.textBox_20);
            this.groupBox_2.Controls.Add(this.label_28);
            this.groupBox_2.Controls.Add(this.comboBox_4);
            this.groupBox_2.Controls.Add(this.label_29);
            this.groupBox_2.Location = new Point(3, 0x67);
            this.groupBox_2.Name = "groupBoxSet2";
            this.groupBox_2.Size = new Size(0x135, 0x45);
            this.groupBox_2.TabIndex = 2;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "2";
            this.textBox_20.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_20.Location = new Point(0x4d, 40);
            this.textBox_20.Name = "txtSetJobTitle2";
            this.textBox_20.Size = new Size(0xe2, 20);
            this.textBox_20.TabIndex = 3;
            this.textBox_20.TextChanged += new EventHandler(this.textBox_29_TextChanged);
            this.label_28.AutoSize = true;
            this.label_28.Location = new Point(6, 0x2b);
            this.label_28.Name = "label26";
            this.label_28.Size = new Size(0x41, 13);
            this.label_28.TabIndex = 2;
            this.label_28.Text = "Должность";
            this.comboBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_4.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_4.FormattingEnabled = true;
            this.comboBox_4.Location = new Point(0x2e, 13);
            this.comboBox_4.Name = "cmbSetFIO2";
            this.comboBox_4.Size = new Size(0x101, 0x15);
            this.comboBox_4.TabIndex = 1;
            this.comboBox_4.SelectedValueChanged += new EventHandler(this.comboBox_4_SelectedValueChanged);
            this.comboBox_4.TextChanged += new EventHandler(this.comboBox_5_TextChanged);
            this.label_29.AutoSize = true;
            this.label_29.Location = new Point(6, 0x10);
            this.label_29.Name = "label27";
            this.label_29.Size = new Size(0x22, 13);
            this.label_29.TabIndex = 0;
            this.label_29.Text = "ФИО";
            this.groupBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_3.Controls.Add(this.textBox_21);
            this.groupBox_3.Controls.Add(this.label_30);
            this.groupBox_3.Controls.Add(this.comboBox_5);
            this.groupBox_3.Controls.Add(this.label_31);
            this.groupBox_3.Location = new Point(3, 0x19);
            this.groupBox_3.Name = "groupBoxSet1";
            this.groupBox_3.Size = new Size(0x135, 0x48);
            this.groupBox_3.TabIndex = 1;
            this.groupBox_3.TabStop = false;
            this.groupBox_3.Text = "1";
            this.textBox_21.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_21.Location = new Point(0x4d, 40);
            this.textBox_21.Name = "txtSetJobTitle1";
            this.textBox_21.Size = new Size(0xe2, 20);
            this.textBox_21.TabIndex = 3;
            this.textBox_21.TextChanged += new EventHandler(this.textBox_29_TextChanged);
            this.label_30.AutoSize = true;
            this.label_30.Location = new Point(6, 0x2b);
            this.label_30.Name = "label25";
            this.label_30.Size = new Size(0x41, 13);
            this.label_30.TabIndex = 2;
            this.label_30.Text = "Должность";
            this.comboBox_5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_5.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_5.FormattingEnabled = true;
            this.comboBox_5.Location = new Point(0x2e, 13);
            this.comboBox_5.Name = "cmbSetFIO1";
            this.comboBox_5.Size = new Size(0x101, 0x15);
            this.comboBox_5.TabIndex = 1;
            this.comboBox_5.SelectedValueChanged += new EventHandler(this.comboBox_5_SelectedValueChanged);
            this.comboBox_5.TextChanged += new EventHandler(this.comboBox_5_TextChanged);
            this.label_31.AutoSize = true;
            this.label_31.Location = new Point(6, 0x10);
            this.label_31.Name = "label24";
            this.label_31.Size = new Size(0x22, 13);
            this.label_31.TabIndex = 0;
            this.label_31.Text = "ФИО";
            this.label_22.AutoSize = true;
            this.label_22.Location = new Point(8, 9);
            this.label_22.Name = "label22";
            this.label_22.Size = new Size(0x84, 13);
            this.label_22.TabIndex = 0;
            this.label_22.Text = "От сетевой организации";
            this.groupBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_4.Controls.Add(this.textBox_22);
            this.groupBox_4.Controls.Add(this.textBox_23);
            this.groupBox_4.Controls.Add(this.label_32);
            this.groupBox_4.Controls.Add(this.label_33);
            this.groupBox_4.Location = new Point(6, 0xfd);
            this.groupBox_4.Name = "groupBox1";
            this.groupBox_4.Size = new Size(0x135, 0x45);
            this.groupBox_4.TabIndex = 4;
            this.groupBox_4.TabStop = false;
            this.groupBox_4.Text = "Заявитель (уполномоченный представитель)";
            this.textBox_22.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_22.Location = new Point(0x2e, 14);
            this.textBox_22.Name = "txtDeclarerFIO4";
            this.textBox_22.Size = new Size(0x100, 20);
            this.textBox_22.TabIndex = 1;
            this.textBox_22.TextChanged += new EventHandler(this.textBox_29_TextChanged);
            this.textBox_23.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_23.Location = new Point(0x4d, 40);
            this.textBox_23.Name = "txtDeclarerJob4";
            this.textBox_23.Size = new Size(0xe2, 20);
            this.textBox_23.TabIndex = 3;
            this.textBox_23.TextChanged += new EventHandler(this.textBox_29_TextChanged);
            this.label_32.AutoSize = true;
            this.label_32.Location = new Point(6, 0x2b);
            this.label_32.Name = "label32";
            this.label_32.Size = new Size(0x41, 13);
            this.label_32.TabIndex = 2;
            this.label_32.Text = "Должность";
            this.label_33.AutoSize = true;
            this.label_33.Location = new Point(6, 0x10);
            this.label_33.Name = "label33";
            this.label_33.Size = new Size(0x22, 13);
            this.label_33.TabIndex = 0;
            this.label_33.Text = "ФИО";
            this.groupBox_5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_5.Controls.Add(this.textBox_24);
            this.groupBox_5.Controls.Add(this.textBox_25);
            this.groupBox_5.Controls.Add(this.label_34);
            this.groupBox_5.Controls.Add(this.label_35);
            this.groupBox_5.Location = new Point(6, 0xb2);
            this.groupBox_5.Name = "groupBox2";
            this.groupBox_5.Size = new Size(0x135, 0x45);
            this.groupBox_5.TabIndex = 3;
            this.groupBox_5.TabStop = false;
            this.groupBox_5.Text = "3";
            this.textBox_24.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_24.Location = new Point(0x2e, 14);
            this.textBox_24.Name = "txtDeclarerFIO3";
            this.textBox_24.Size = new Size(0x100, 20);
            this.textBox_24.TabIndex = 1;
            this.textBox_24.TextChanged += new EventHandler(this.textBox_29_TextChanged);
            this.textBox_25.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_25.Location = new Point(0x4d, 40);
            this.textBox_25.Name = "txtDeclarerJob3";
            this.textBox_25.Size = new Size(0xe2, 20);
            this.textBox_25.TabIndex = 3;
            this.textBox_25.TextChanged += new EventHandler(this.textBox_29_TextChanged);
            this.label_34.AutoSize = true;
            this.label_34.Location = new Point(6, 0x2b);
            this.label_34.Name = "label34";
            this.label_34.Size = new Size(0x41, 13);
            this.label_34.TabIndex = 2;
            this.label_34.Text = "Должность";
            this.label_35.AutoSize = true;
            this.label_35.Location = new Point(6, 0x10);
            this.label_35.Name = "label35";
            this.label_35.Size = new Size(0x22, 13);
            this.label_35.TabIndex = 0;
            this.label_35.Text = "ФИО";
            this.groupBox_6.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_6.Controls.Add(this.textBox_26);
            this.groupBox_6.Controls.Add(this.textBox_27);
            this.groupBox_6.Controls.Add(this.label_36);
            this.groupBox_6.Controls.Add(this.label_37);
            this.groupBox_6.Location = new Point(6, 0x67);
            this.groupBox_6.Name = "groupBox3";
            this.groupBox_6.Size = new Size(0x135, 0x45);
            this.groupBox_6.TabIndex = 2;
            this.groupBox_6.TabStop = false;
            this.groupBox_6.Text = "2";
            this.textBox_26.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_26.Location = new Point(0x2f, 14);
            this.textBox_26.Name = "txtDeclarerFIO2";
            this.textBox_26.Size = new Size(0x100, 20);
            this.textBox_26.TabIndex = 1;
            this.textBox_26.TextChanged += new EventHandler(this.textBox_29_TextChanged);
            this.textBox_27.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_27.Location = new Point(0x4d, 40);
            this.textBox_27.Name = "txtDeclarerJob2";
            this.textBox_27.Size = new Size(0xe2, 20);
            this.textBox_27.TabIndex = 3;
            this.textBox_27.TextChanged += new EventHandler(this.textBox_29_TextChanged);
            this.label_36.AutoSize = true;
            this.label_36.Location = new Point(6, 0x2b);
            this.label_36.Name = "label36";
            this.label_36.Size = new Size(0x41, 13);
            this.label_36.TabIndex = 2;
            this.label_36.Text = "Должность";
            this.label_37.AutoSize = true;
            this.label_37.Location = new Point(6, 0x10);
            this.label_37.Name = "label37";
            this.label_37.Size = new Size(0x22, 13);
            this.label_37.TabIndex = 0;
            this.label_37.Text = "ФИО";
            this.groupBox_7.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_7.Controls.Add(this.textBox_28);
            this.groupBox_7.Controls.Add(this.textBox_29);
            this.groupBox_7.Controls.Add(this.label_38);
            this.groupBox_7.Controls.Add(this.label_39);
            this.groupBox_7.Location = new Point(6, 0x19);
            this.groupBox_7.Name = "groupBox4";
            this.groupBox_7.Size = new Size(0x135, 0x48);
            this.groupBox_7.TabIndex = 1;
            this.groupBox_7.TabStop = false;
            this.groupBox_7.Text = "1";
            this.textBox_28.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_28.Location = new Point(0x2e, 14);
            this.textBox_28.Name = "txtDeclarerFIO1";
            this.textBox_28.Size = new Size(0x100, 20);
            this.textBox_28.TabIndex = 1;
            this.textBox_28.TextChanged += new EventHandler(this.textBox_29_TextChanged);
            this.textBox_29.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_29.Location = new Point(0x4d, 40);
            this.textBox_29.Name = "txtDeclarerJob1";
            this.textBox_29.Size = new Size(0xe2, 20);
            this.textBox_29.TabIndex = 3;
            this.textBox_29.TextChanged += new EventHandler(this.textBox_29_TextChanged);
            this.label_38.AutoSize = true;
            this.label_38.Location = new Point(6, 0x2b);
            this.label_38.Name = "label38";
            this.label_38.Size = new Size(0x41, 13);
            this.label_38.TabIndex = 2;
            this.label_38.Text = "Должность";
            this.label_39.AutoSize = true;
            this.label_39.Location = new Point(6, 0x10);
            this.label_39.Name = "label39";
            this.label_39.Size = new Size(0x22, 13);
            this.label_39.TabIndex = 0;
            this.label_39.Text = "ФИО";
            this.label_23.AutoSize = true;
            this.label_23.Location = new Point(12, 9);
            this.label_23.Name = "label23";
            this.label_23.Size = new Size(0x4c, 13);
            this.label_23.TabIndex = 0;
            this.label_23.Text = "От заявителя";
            this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_0);
            this.tabPage_1.Controls.Add(this.toolStrip_0);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPageFile";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(630, 0x159);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "Файлы";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToResizeColumns = false;
            this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewImageColumnNotNull_0, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewExcelFilter_0.Location = new Point(3, 0x1c);
            this.dataGridViewExcelFilter_0.Name = "dgvFile";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x270, 0x13a);
            this.dataGridViewExcelFilter_0.TabIndex = 8;
            this.dataGridViewExcelFilter_0.VirtualMode = true;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.CellEndEdit += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellEndEdit);
            this.dataGridViewExcelFilter_0.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridViewExcelFilter_0_CellMouseClick);
            this.dataGridViewExcelFilter_0.CellValidating += new DataGridViewCellValidatingEventHandler(this.dataGridViewExcelFilter_0_CellValidating);
            this.dataGridViewExcelFilter_0.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridViewExcelFilter_0_CellValueNeeded);
            style.NullValue = null;
            this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style;
            this.dataGridViewImageColumnNotNull_0.HeaderText = "";
            this.dataGridViewImageColumnNotNull_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumnNotNull_0.Name = "imageDgvColumn";
            this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
            this.dataGridViewImageColumnNotNull_0.Width = 30;
            this.dataGridViewFilterTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "FileName";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Файл";
            this.dataGridViewFilterTextBoxColumn_0.Name = "fileNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "id";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_1.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_1.Name = "idDoc";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_2.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_2.Name = "dateChangeDgvColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_3.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_3.Name = "idTemplateDgvColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.bindingSource_0.DataMember = "tTC_DocFile";
            this.bindingSource_0.DataSource = this.dataSetTechConnection_0;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripDropDownButton_0, this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripSeparator_1, this.toolStripButton_3, this.toolStripButton_4 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(3, 3);
            this.toolStrip_0.Name = "toolStripFile";
            this.toolStrip_0.Size = new Size(0x270, 0x19);
            this.toolStrip_0.TabIndex = 7;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripSeparator_0 };
            this.toolStripDropDownButton_0.DropDownItems.AddRange(itemArray2);
            this.toolStripDropDownButton_0.Image = Resources.ElementAdd;
            this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripDropDownButton_0.Name = "toolBtnAddFile";
            this.toolStripDropDownButton_0.Size = new Size(0x1d, 0x16);
            this.toolStripDropDownButton_0.Text = "Добавить файл";
            this.toolStripMenuItem_0.Name = "toolItemAddExistFile";
            this.toolStripMenuItem_0.Size = new Size(190, 0x16);
            this.toolStripMenuItem_0.Text = "Сущесвующий файл";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_2_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator2";
            this.toolStripSeparator_0.Size = new Size(0xbb, 6);
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.ElementEdit;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnEditFile";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Редактировать файл";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripMenuItem_3_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementInformation;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnOpenFile";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Открыть файл";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripMenuItem_4_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementDel;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnDelFile";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить файл";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripMenuItem_5_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator3";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.rename;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnRenameFile";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Переименовать";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripMenuItem_6_Click);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.save;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnSaveFile";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Сохранить файл на диск";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripMenuItem_7_Click);
            this.tabPage_2.Controls.Add(this.dateTimePicker_0);
            this.tabPage_2.Controls.Add(this.label_14);
            this.tabPage_2.Controls.Add(this.button_2);
            this.tabPage_2.Controls.Add(this.textBox_10);
            this.tabPage_2.Controls.Add(this.label_13);
            this.tabPage_2.Controls.Add(this.dataGridView_0);
            this.tabPage_2.Controls.Add(this.splitContainer_0);
            this.tabPage_2.Controls.Add(this.textBox_8);
            this.tabPage_2.Controls.Add(this.label_11);
            this.tabPage_2.Controls.Add(this.textBox_9);
            this.tabPage_2.Controls.Add(this.label_12);
            this.tabPage_2.Location = new Point(4, 0x16);
            this.tabPage_2.Name = "tabPagePost";
            this.tabPage_2.Padding = new Padding(3);
            this.tabPage_2.Size = new Size(630, 0x159);
            this.tabPage_2.TabIndex = 2;
            this.tabPage_2.Text = "Почта";
            this.tabPage_2.UseVisualStyleBackColor = true;
            this.dateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_0, "tTC_ElectricalInspection.DateRecipient", true));
            this.dateTimePicker_0.Location = new Point(0x19c, 0x139);
            this.dateTimePicker_0.Name = "dtpDateRecipient";
            this.dateTimePicker_0.Size = new Size(0xd1, 20);
            this.dateTimePicker_0.TabIndex = 15;
            this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.label_14.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.label_14.AutoSize = true;
            this.label_14.Location = new Point(370, 0x13f);
            this.label_14.Name = "label13";
            this.label_14.Size = new Size(0x24, 13);
            this.label_14.TabIndex = 14;
            this.label_14.Text = "Дата:";
            this.button_2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_2.Location = new Point(5, 0x13a);
            this.button_2.Name = "buttonSend";
            this.button_2.Size = new Size(0x4b, 0x17);
            this.button_2.TabIndex = 13;
            this.button_2.Text = "Отправить";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new EventHandler(this.button_2_Click);
            this.textBox_10.Location = new Point(0x59, 0x89);
            this.textBox_10.Name = "txtSubject";
            this.textBox_10.Size = new Size(0x152, 20);
            this.textBox_10.TabIndex = 12;
            this.textBox_10.Text = "Акт осмотра электроустановки";
            this.label_13.AutoSize = true;
            this.label_13.Location = new Point(8, 140);
            this.label_13.Name = "label12";
            this.label_13.Size = new Size(0x4b, 13);
            this.label_13.TabIndex = 11;
            this.label_13.Text = "Тема письма";
            this.dataGridView_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewComboBoxColumn_0, this.dataGridViewTextBoxColumn_9, this.dataGridViewCheckBoxColumn_0 };
            this.dataGridView_0.Columns.AddRange(columnArray2);
            this.dataGridView_0.Location = new Point(0, 0x9c);
            this.dataGridView_0.Name = "dgvRecipient";
            this.dataGridView_0.Size = new Size(630, 0x98);
            this.dataGridView_0.TabIndex = 10;
            this.dataGridView_0.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView_0_DataError);
            this.dataGridView_0.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dataGridView_0_EditingControlShowing);
            this.dataGridView_0.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridView_0_RowsAdded);
            this.dataGridView_0.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dataGridView_0_RowsRemoved);
            this.dataGridViewComboBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn_0.HeaderText = "Имя получателя";
            this.dataGridViewComboBoxColumn_0.Name = "fioRecipientDgvColumn";
            this.dataGridViewTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_9.HeaderText = "Адрес получателя";
            this.dataGridViewTextBoxColumn_9.Name = "mailDgvColumn";
            this.dataGridViewTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_0.HeaderText = "Отправлено";
            this.dataGridViewCheckBoxColumn_0.Name = "isSendDgvColumn";
            this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_0.Width = 70;
            this.splitContainer_0.IsSplitterFixed = true;
            this.splitContainer_0.Location = new Point(0, 0x2d);
            this.splitContainer_0.Name = "splitContainer1";
            this.splitContainer_0.Panel1.Controls.Add(this.textBox_4);
            this.splitContainer_0.Panel1.Controls.Add(this.label_7);
            this.splitContainer_0.Panel1.Controls.Add(this.textBox_5);
            this.splitContainer_0.Panel1.Controls.Add(this.label_8);
            this.splitContainer_0.Panel2.Controls.Add(this.textBox_6);
            this.splitContainer_0.Panel2.Controls.Add(this.textBox_7);
            this.splitContainer_0.Panel2.Controls.Add(this.label_9);
            this.splitContainer_0.Panel2.Controls.Add(this.label_10);
            this.splitContainer_0.Size = new Size(0x1ab, 0x57);
            this.splitContainer_0.SplitterDistance = 0xd3;
            this.splitContainer_0.SplitterWidth = 1;
            this.splitContainer_0.TabIndex = 9;
            this.textBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_4.Location = new Point(14, 0x37);
            this.textBox_4.Name = "textBoxSenderAddress";
            this.textBox_4.Size = new Size(0xc2, 20);
            this.textBox_4.TabIndex = 3;
            this.textBox_4.TextChanged += new EventHandler(this.textBox_4_TextChanged);
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(11, 0x27);
            this.label_7.Name = "label10";
            this.label_7.Size = new Size(0x69, 13);
            this.label_7.TabIndex = 2;
            this.label_7.Text = "Адрес отправителя";
            this.textBox_5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_5.Location = new Point(14, 0x10);
            this.textBox_5.Name = "textBoxLogin";
            this.textBox_5.Size = new Size(0xc2, 20);
            this.textBox_5.TabIndex = 1;
            this.textBox_5.TextChanged += new EventHandler(this.textBox_5_TextChanged);
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(11, 0);
            this.label_8.Name = "label8";
            this.label_8.Size = new Size(0x26, 13);
            this.label_8.TabIndex = 0;
            this.label_8.Text = "Логин";
            this.textBox_6.Location = new Point(6, 0x10);
            this.textBox_6.Name = "textBoxPassword";
            this.textBox_6.PasswordChar = '☻';
            this.textBox_6.Size = new Size(0xce, 20);
            this.textBox_6.TabIndex = 8;
            this.textBox_6.TextChanged += new EventHandler(this.textBox_6_TextChanged);
            this.textBox_7.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_7.Location = new Point(6, 0x37);
            this.textBox_7.Name = "textBoxSenderName";
            this.textBox_7.Size = new Size(0xcd, 20);
            this.textBox_7.TabIndex = 5;
            this.textBox_7.TextChanged += new EventHandler(this.textBox_7_TextChanged);
            this.label_9.AutoSize = true;
            this.label_9.Location = new Point(3, 0x27);
            this.label_9.Name = "label11";
            this.label_9.Size = new Size(0x60, 13);
            this.label_9.TabIndex = 4;
            this.label_9.Text = "Имя отправителя";
            this.label_10.AutoSize = true;
            this.label_10.Location = new Point(3, 0);
            this.label_10.Name = "label4";
            this.label_10.Size = new Size(0x2d, 13);
            this.label_10.TabIndex = 2;
            this.label_10.Text = "Пароль";
            this.textBox_8.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.textBox_8.Location = new Point(0x148, 0x13);
            this.textBox_8.Name = "textBoxSmtpPort";
            this.textBox_8.Size = new Size(0x60, 20);
            this.textBox_8.TabIndex = 8;
            this.textBox_8.Text = "25";
            this.textBox_8.TextChanged += new EventHandler(this.textBox_8_TextChanged);
            this.label_11.AutoSize = true;
            this.label_11.Location = new Point(0x147, 3);
            this.label_11.Name = "label6";
            this.label_11.Size = new Size(0x20, 13);
            this.label_11.TabIndex = 7;
            this.label_11.Text = "Порт";
            this.textBox_9.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_9.Location = new Point(11, 0x13);
            this.textBox_9.Name = "txtSmtpServer";
            this.textBox_9.Size = new Size(0x127, 20);
            this.textBox_9.TabIndex = 6;
            this.textBox_9.Text = "domino";
            this.textBox_9.TextChanged += new EventHandler(this.textBox_9_TextChanged);
            this.label_12.AutoSize = true;
            this.label_12.Location = new Point(8, 3);
            this.label_12.Name = "label14";
            this.label_12.Size = new Size(0x5e, 13);
            this.label_12.TabIndex = 5;
            this.label_12.Text = "Сервер отправки";
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripMenuItem_1, this.toolStripMenuItem_3, this.toolStripMenuItem_4, this.toolStripMenuItem_5, this.toolStripSeparator_3, this.toolStripMenuItem_6, this.toolStripMenuItem_7 };
            this.contextMenuStrip_0.Items.AddRange(itemArray3);
            this.contextMenuStrip_0.Name = "contextMenuFile";
            this.contextMenuStrip_0.Size = new Size(0xb1, 0x8e);
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripMenuItem_2, this.toolStripSeparator_2 };
            this.toolStripMenuItem_1.DropDownItems.AddRange(itemArray4);
            this.toolStripMenuItem_1.Image = Resources.ElementAdd;
            this.toolStripMenuItem_1.Name = "toolMenuItemAddFile";
            this.toolStripMenuItem_1.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_1.Text = "Добавить";
            this.toolStripMenuItem_2.Name = "toolMenuItemAddExistsFile";
            this.toolStripMenuItem_2.Size = new Size(0xc3, 0x16);
            this.toolStripMenuItem_2.Text = "Существующий файл";
            this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator5";
            this.toolStripSeparator_2.Size = new Size(0xc0, 6);
            this.toolStripMenuItem_3.Image = Resources.ElementEdit;
            this.toolStripMenuItem_3.Name = "toolMenuItemEditFile";
            this.toolStripMenuItem_3.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_3.Text = "Редактировать";
            this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripMenuItem_3_Click);
            this.toolStripMenuItem_4.Image = Resources.ElementInformation;
            this.toolStripMenuItem_4.Name = "toolMenuItemViewFile";
            this.toolStripMenuItem_4.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_4.Text = "Просмотр";
            this.toolStripMenuItem_4.Click += new EventHandler(this.toolStripMenuItem_4_Click);
            this.toolStripMenuItem_5.Image = Resources.ElementDel;
            this.toolStripMenuItem_5.Name = "toolMenuItemDelFile";
            this.toolStripMenuItem_5.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_5.Text = "Удалить";
            this.toolStripMenuItem_5.Click += new EventHandler(this.toolStripMenuItem_5_Click);
            this.toolStripSeparator_3.Name = "toolStripSeparator4";
            this.toolStripSeparator_3.Size = new Size(0xad, 6);
            this.toolStripMenuItem_6.Image = Resources.rename;
            this.toolStripMenuItem_6.Name = "toolMenuItemRenameFile";
            this.toolStripMenuItem_6.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_6.Text = "Переименовать";
            this.toolStripMenuItem_6.Click += new EventHandler(this.toolStripMenuItem_6_Click);
            this.toolStripMenuItem_7.Image = Resources.save;
            this.toolStripMenuItem_7.Name = "toolMenuItemSaveFile";
            this.toolStripMenuItem_7.Size = new Size(0xb0, 0x16);
            this.toolStripMenuItem_7.Text = "Сохранить на диск";
            this.toolStripMenuItem_7.Click += new EventHandler(this.toolStripMenuItem_7_Click);
            this.dataGridViewFilterTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "FileName";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Файл";
            this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_4.HeaderText = "id";
            this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_5.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_6.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_6.Visible = false;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_7.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn_7.Visible = false;
            this.dataGridViewTextBoxColumn_8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_8.HeaderText = "Адрес получателя";
            this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x27d, 0x1a3);
            base.Controls.Add(this.tabControl_0);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Name = "FormActElectricalInspection";
            this.Text = "Добавление/редактирование акта осмотра электроустановки";
            base.FormClosing += new FormClosingEventHandler(this.FormActElectricalInspection_FormClosing);
            base.FormClosed += new FormClosedEventHandler(this.FormActElectricalInspection_FormClosed);
            base.Load += new EventHandler(this.FormActElectricalInspection_Load);
            this.dataSetTechConnection_0.EndInit();
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.tabPage_0.PerformLayout();
            this.tabPage_3.ResumeLayout(false);
            this.tabPage_3.PerformLayout();
            this.tabPage_4.ResumeLayout(false);
            this.splitContainer_1.Panel1.ResumeLayout(false);
            this.splitContainer_1.Panel1.PerformLayout();
            this.splitContainer_1.Panel2.ResumeLayout(false);
            this.splitContainer_1.Panel2.PerformLayout();
            this.splitContainer_1.ResumeLayout(false);
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_2.PerformLayout();
            this.groupBox_3.ResumeLayout(false);
            this.groupBox_3.PerformLayout();
            this.groupBox_4.ResumeLayout(false);
            this.groupBox_4.PerformLayout();
            this.groupBox_5.ResumeLayout(false);
            this.groupBox_5.PerformLayout();
            this.groupBox_6.ResumeLayout(false);
            this.groupBox_6.PerformLayout();
            this.groupBox_7.ResumeLayout(false);
            this.groupBox_7.PerformLayout();
            this.tabPage_1.ResumeLayout(false);
            this.tabPage_1.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.tabPage_2.ResumeLayout(false);
            this.tabPage_2.PerformLayout();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.Panel2.PerformLayout();
            this.splitContainer_0.ResumeLayout(false);
            this.contextMenuStrip_0.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        [CompilerGenerated]
        private void method_23()
        {
            this.bindingSource_0.ResetBindings(false);
        }

        private void method_3(int int_5)
        {
            DataSetTechConnection.tTC_DocDataTable table = new DataSetTechConnection.tTC_DocDataTable();
            base.SelectSqlData(table, true, " where id = " + int_5.ToString(), false);
            if (table.Rows.Count <= 0)
            {
                this.int_3 = -1;
                this.int_2 = -1;
                this.textBox_2.Text = this.textBox_1.Text = "";
            }
            else
            {
                int num = Convert.ToInt32(table.Rows[0]["TypeDoc"]);
                int num2 = -1;
                switch (num)
                {
                    case 0x459:
                    case 0x4b3:
                        num2 = int_5;
                        break;

                    case 0x463:
                    {
                        DataSetTechConnection.vTC_TUDataTable table2 = new DataSetTechConnection.vTC_TUDataTable();
                        base.SelectSqlData(table2, true, " where id = " + int_5.ToString(), false);
                        if ((table2.Rows.Count > 0) && (table2.Rows[0]["idRequest"] != DBNull.Value))
                        {
                            num2 = Convert.ToInt32(table2.Rows[0]["idRequest"]);
                        }
                        break;
                    }
                }
                if (num2 != -1)
                {
                    DataSetTechConnection.tTC_DocDataTable table3 = new DataSetTechConnection.tTC_DocDataTable();
                    base.SelectSqlData(table3, true, " where id = " + num2.ToString(), false);
                    if ((table3.Rows.Count > 0) && (table3.Rows[0]["idParent"] != DBNull.Value))
                    {
                        num2 = Convert.ToInt32(table3.Rows[0]["idParent"]);
                    }
                    DataSetTechConnection.tTC_RequestDataTable table4 = new DataSetTechConnection.tTC_RequestDataTable();
                    base.SelectSqlData(table4, true, " where id = " + num2.ToString(), false);
                    if ((table4.Rows.Count > 0) && (table4.Rows[0]["idAbn"] != DBNull.Value))
                    {
                        this.int_2 = Convert.ToInt32(table4.Rows[0]["idAbn"]);
                        DataSetTechConnection.tAbnDataTable table5 = new DataSetTechConnection.tAbnDataTable();
                        base.SelectSqlData(table5, true, "where id = " + this.int_2.ToString(), false);
                        if (table5.Rows.Count > 0)
                        {
                            this.textBox_2.Text = table5.Rows[0]["name"].ToString();
                            int num3 = Convert.ToInt32(table5.Rows[0]["typeAbn"]);
                            if (table4.Rows[0]["idAbnObj"] != DBNull.Value)
                            {
                                this.int_3 = Convert.ToInt32(table4.Rows[0]["idAbnObj"]);
                                DataSetTechConnection.vAbnObjAddressDataTable table6 = new DataSetTechConnection.vAbnObjAddressDataTable();
                                DataColumn column = new DataColumn("AddressFL") {
                                    Expression = "street + ', д. ' + houseall + ', кв. ' + name"
                                };
                                table6.Columns.Add(column);
                                column = new DataColumn("AddressUL") {
                                    Expression = "street + ', д. ' + houseall"
                                };
                                table6.Columns.Add(column);
                                base.SelectSqlData(table6, true, "where id = " + this.int_3.ToString() + " order by name", false);
                                if (table6.Rows.Count > 0)
                                {
                                    if (((num3 != 0xce) && (num3 != 0xfd)) && (num3 != 0x40d))
                                    {
                                        this.textBox_1.Text = table6.Rows[0]["name"].ToString();
                                    }
                                    else
                                    {
                                        this.textBox_1.Text = table6.Rows[0]["AddressFL"].ToString();
                                    }
                                }
                                else
                                {
                                    this.textBox_1.Text = "";
                                }
                            }
                            else
                            {
                                this.textBox_1.Text = "";
                            }
                        }
                        else
                        {
                            this.textBox_2.Text = this.textBox_1.Text = "";
                        }
                    }
                }
                else
                {
                    this.int_3 = -1;
                    this.int_2 = -1;
                    this.textBox_2.Text = this.textBox_1.Text = "";
                }
            }
        }

        private void method_4(object object_0, object object_1)
        {
            if (object_0 != DBNull.Value)
            {
                object_0 = Convert.ToInt32(object_0);
                DataSetTechConnection.tAbnDataTable table = new DataSetTechConnection.tAbnDataTable();
                base.SelectSqlData(table, true, "where id = " + object_0.ToString(), false);
                if (table.Rows.Count > 0)
                {
                    this.textBox_2.Text = table.Rows[0]["name"].ToString();
                    int num = Convert.ToInt32(table.Rows[0]["typeAbn"]);
                    if (object_1 != DBNull.Value)
                    {
                        object_1 = Convert.ToInt32(object_1);
                        DataSetTechConnection.vAbnObjAddressDataTable table2 = new DataSetTechConnection.vAbnObjAddressDataTable();
                        DataColumn column = new DataColumn("AddressFL") {
                            Expression = "street + ', д. ' + houseall + ', кв. ' + name"
                        };
                        table2.Columns.Add(column);
                        column = new DataColumn("AddressUL") {
                            Expression = "street + ', д. ' + houseall"
                        };
                        table2.Columns.Add(column);
                        base.SelectSqlData(table2, true, "where id = " + object_1.ToString() + " order by name", false);
                        if (table2.Rows.Count > 0)
                        {
                            if (((num != 0xce) && (num != 0xfd)) && (num != 0x40d))
                            {
                                this.textBox_1.Text = table2.Rows[0]["name"].ToString();
                            }
                            else
                            {
                                this.textBox_1.Text = table2.Rows[0]["AddressFL"].ToString();
                            }
                        }
                        else
                        {
                            this.textBox_1.Text = "";
                        }
                    }
                    else
                    {
                        this.textBox_1.Text = "";
                    }
                }
                else
                {
                    this.textBox_2.Text = this.textBox_1.Text = "";
                }
            }
        }

        private bool method_5()
        {
            if (this.comboBox_0.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбрано техническое условие");
                return false;
            }
            this.dataSetTechConnection_0.tTC_Doc.Rows[0].EndEdit();
            if (this.int_0 == -1)
            {
                this.int_0 = base.InsertSqlDataOneRow(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc);
                if (this.int_0 == -1)
                {
                    return false;
                }
            }
            else if (!base.UpdateSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc))
            {
                return false;
            }
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where id = " + this.int_0.ToString());
            if (!this.method_6())
            {
                return false;
            }
            if (!this.method_16())
            {
                return false;
            }
            this.bool_0 = false;
            return true;
        }

        private bool method_6()
        {
            if (this.int_0 == -1)
            {
                return false;
            }
            if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows.Count == 0)
            {
                DataRow row = this.dataSetTechConnection_0.tTC_ElectricalInspection.NewRow();
                row["id"] = this.int_0;
                if (this.comboBox_1.SelectedIndex >= 0)
                {
                    row["idWorker"] = this.comboBox_1.SelectedValue;
                }
                row["DateRecipient"] = this.dateTimePicker_0.Value;
                XmlDocument document = this.CreateXmlConfig();
                if (document != null)
                {
                    row["Mail"] = document.InnerXml;
                }
                XmlDocument document2 = this.method_21();
                if (document2 != null)
                {
                    row["Officials"] = document2.InnerXml;
                }
                this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows.Add(row);
                if (!base.InsertSqlData(this.dataSetTechConnection_0.tTC_ElectricalInspection))
                {
                    return false;
                }
                this.dataSetTechConnection_0.tTC_ElectricalInspection.AcceptChanges();
            }
            else
            {
                this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["id"] = this.int_0;
                XmlDocument document3 = this.CreateXmlConfig();
                if (document3 != null)
                {
                    this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["Mail"] = document3.InnerXml;
                }
                XmlDocument document4 = this.method_21();
                if (document4 != null)
                {
                    this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["Officials"] = document4.InnerXml;
                }
                this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0].EndEdit();
                if (!base.UpdateSqlData(this.dataSetTechConnection_0.tTC_ElectricalInspection))
                {
                    return false;
                }
                this.dataSetTechConnection_0.tTC_ElectricalInspection.AcceptChanges();
            }
            return true;
        }

        private void method_7()
        {
            foreach (DataRow row in new SqlDataCommand(this.get_SqlSettings()).SelectSqlData(" SELECT doc.id, doc.FileName  FROM tR_DocTemplate AS doc  INNER JOIN [tR_Classifier] AS c ON doc.idTypeDoc = c.id  WHERE c.ParentKey = ';TypeDoc;tR_DocTemplate;' AND c.Deleted = ((0)) AND c.isGroup = ((0)) AND c.Value = 1 and doc.deleted = 0").Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem {
                    Text = row["FileName"].ToString(),
                    Tag = row["id"]
                };
                item.Click += new EventHandler(this.method_9);
                this.toolStripDropDownButton_0.DropDownItems.Add(item);
                ToolStripMenuItem item2 = new ToolStripMenuItem {
                    Text = row["FileName"].ToString(),
                    Tag = row["id"]
                };
                item2.Click += new EventHandler(this.method_9);
                this.toolStripMenuItem_1.DropDownItems.Add(item2);
            }
        }

        private string method_8(string string_1, int? nullable_0 = new int?(), byte[] byte_1 = null)
        {
            string fileName = Path.GetFileName(string_1);
            bool flag = true;
            while (this.dictionary_0.ContainsKey(fileName))
            {
                if (MessageBox.Show("Файл с именем " + fileName + " уже существует. Изменить имя файла на другое?", "Внимание.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    flag = false;
                    break;
                }
                FormNewFileName name = new FormNewFileName(fileName);
                if (name.ShowDialog() == DialogResult.OK)
                {
                    fileName = name.method_0();
                }
            }
            if (!flag)
            {
                return null;
            }
            FileWatcherArgsAddl addl = new FileWatcherArgsAddl(nullable_0, fileName, null, 2);
            this.dictionary_0.Add(fileName, addl);
            DataSetTechConnection.Class252 class2 = this.dataSetTechConnection_0.tTC_DocFile.method_5();
            class2.idDoc = -1;
            class2.FileName = fileName;
            if (byte_1 == null)
            {
                FileBinary binary = new FileBinary(string_1);
                class2.File = binary.get_ByteArray();
                class2.dateChange = binary.get_LastChanged();
            }
            else
            {
                class2.File = byte_1;
                class2.dateChange = DateTime.Now;
            }
            if (nullable_0.HasValue)
            {
                class2.idTemplate = nullable_0.Value;
            }
            this.dataSetTechConnection_0.tTC_DocFile.method_0(class2);
            return fileName;
        }

        private void method_9(object sender, EventArgs e)
        {
            string str;
            byte[] buffer;
            string str3;
            int tag = (int) ((ToolStripMenuItem) sender).Tag;
            this.GetTepmlate(tag, out str, out buffer);
            string extension = new FileInfo(str).Extension;
            uint num2 = Class227.smethod_0(extension);
            if (num2 <= 0x667e718c)
            {
                if (num2 <= 0x1df63c41)
                {
                    if (num2 == 0x1c03050e)
                    {
                        if (extension == ".xlsx")
                        {
                        }
                    }
                    else if ((num2 == 0x1df63c41) && (extension == ".xltx"))
                    {
                        goto Label_0100;
                    }
                }
                else if (num2 != 0x60538713)
                {
                    if ((num2 == 0x667e718c) && (extension == ".dotx"))
                    {
                        goto Label_013B;
                    }
                }
                else if (extension == ".docx")
                {
                }
                goto Label_0162;
            }
            if (num2 > 0xbdb3c702)
            {
                if (num2 == 0xc107d4f9)
                {
                    if (extension == ".doc")
                    {
                    }
                    goto Label_0162;
                }
                if ((num2 != 0xd207efbc) || (extension != ".dot"))
                {
                    goto Label_0162;
                }
                goto Label_013B;
            }
            if (num2 != 0xb8b3bf23)
            {
                if ((num2 != 0xbdb3c702) || (extension == ".xls"))
                {
                }
                goto Label_0162;
            }
            if (extension != ".xlt")
            {
                goto Label_0162;
            }
        Label_0100:
            str = str.Replace(extension, extension.Replace("t", "s"));
            goto Label_0162;
        Label_013B:
            str = str.Replace(extension, extension.Replace("t", "c"));
        Label_0162:
            str3 = this.method_14();
            string str4 = FileBinary.GetNewFileNameIsExists(str3, str, false);
            string str5 = this.method_8(str, new int?(tag), buffer);
            if (!string.IsNullOrEmpty(str5))
            {
                this.bool_0 = true;
                FileBinary binary = new FileBinary(buffer, str4, DateTime.Now);
                binary.SaveToDisk(str3);
                extension = new FileInfo(str).Extension;
                Process.Start(str3 + @"\" + binary.get_Name());
                if (this.dictionary_0.ContainsKey(str5))
                {
                    FileWatcher watcher = new FileWatcher(str3, binary.get_Name());
                    watcher.add_AnyChanged(new FileSystemEventHandler(this.method_11));
                    watcher.Start();
                    this.dictionary_0[str5].set_TempName(str4);
                    this.dictionary_0[str5].set_Watcher(watcher);
                    this.dictionary_0[str5].set_OpenState(1);
                }
                else
                {
                    MessageBox.Show("Что то пошло не так");
                }
            }
        }

        private void nullableDateTimePicker_0_ValueChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private static string smethod_0(string string_1)
        {
            if (string.IsNullOrEmpty(string_1))
            {
                return "";
            }
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(byte_0, byte_0), CryptoStreamMode.Write);
            StreamWriter writer1 = new StreamWriter(stream2);
            writer1.Write(string_1);
            writer1.Flush();
            stream2.FlushFinalBlock();
            writer1.Flush();
            return Convert.ToBase64String(stream.GetBuffer(), 0, (int) stream.Length);
        }

        private static string smethod_1(string string_1)
        {
            if (string.IsNullOrEmpty(string_1))
            {
                return "";
            }
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            return new StreamReader(new CryptoStream(new MemoryStream(Convert.FromBase64String(string_1)), provider.CreateDecryptor(byte_0, byte_0), CryptoStreamMode.Read)).ReadToEnd();
        }

        private void textBox_0_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void textBox_11_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void textBox_12_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void textBox_14_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void textBox_29_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void textBox_3_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void textBox_4_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void textBox_5_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void textBox_6_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void textBox_7_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void textBox_8_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void textBox_9_TextChanged(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

        private void toolStripMenuItem_2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Multiselect = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string str in dialog.FileNames)
                {
                    int? nullable = null;
                    if (!string.IsNullOrEmpty(this.method_8(str, nullable, null)))
                    {
                        this.bool_0 = true;
                    }
                }
            }
        }

        private void toolStripMenuItem_3_Click(object sender, EventArgs e)
        {
            this.method_10(true);
        }

        private void toolStripMenuItem_4_Click(object sender, EventArgs e)
        {
            this.method_10(false);
        }

        private void toolStripMenuItem_5_Click(object sender, EventArgs e)
        {
            if ((this.bindingSource_0.Current != null) && (MessageBox.Show("Вы действительно хотите удалить выбранный файл?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                DataSetTechConnection.Class252 row = (DataSetTechConnection.Class252) ((DataRowView) this.bindingSource_0.Current).Row;
                string fileName = row.FileName;
                if (this.dictionary_0.ContainsKey(fileName))
                {
                    if (this.dictionary_0[fileName].get_Watcher() != null)
                    {
                        this.dictionary_0[fileName].get_Watcher().remove_AnyChanged(new FileSystemEventHandler(this.method_11));
                        this.dictionary_0[fileName].get_Watcher().Stop();
                    }
                    this.dictionary_0.Remove(fileName);
                }
                row.Delete();
                this.bool_0 = true;
            }
        }

        private void toolStripMenuItem_6_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                this.string_0 = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_0.Name].Value.ToString();
                this.dataGridViewExcelFilter_0.CurrentCell = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_0.Name];
                this.dataGridViewExcelFilter_0.CurrentCell.Value = Path.GetFileNameWithoutExtension(this.string_0);
                this.dataGridViewExcelFilter_0.ReadOnly = false;
                this.dataGridViewFilterTextBoxColumn_0.ReadOnly = false;
                this.dataGridViewExcelFilter_0.BeginEdit(true);
            }
        }

        private void toolStripMenuItem_7_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                DataSetTechConnection.Class252 row = (DataSetTechConnection.Class252) ((DataRowView) this.bindingSource_0.Current).Row;
                if (row["File"] == DBNull.Value)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
                        {
                            connection.Open();
                            SqlDataReader reader = new SqlCommand("SELECT [File] FROM tTC_DocFile WHERE id = " + row["id"].ToString(), connection).ExecuteReader();
                            while (reader.Read())
                            {
                                row["File"] = reader["File"];
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Source);
                    }
                }
                byte[] file = row.File;
                SaveFileDialog dialog = new SaveFileDialog {
                    FileName = row.FileName
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.ByteArrayToFile(dialog.FileName, file);
                }
            }
        }

        public int IdAct
        {
            get
            {
                return this.int_0;
            }
        }

        [CompilerGenerated]
        private sealed class Class292
        {
            public FileSystemEventArgs fileSystemEventArgs_0;
            public IEnumerable<KeyValuePair<string, FileWatcherArgsAddl>> ienumerable_0;

            internal bool method_0(KeyValuePair<string, FileWatcherArgsAddl> keyValuePair_0)
            {
                return (keyValuePair_0.Value.get_TempName() == this.fileSystemEventArgs_0.Name);
            }

            internal bool method_1(DataSetTechConnection.Class252 class252_0)
            {
                return ((class252_0.RowState != DataRowState.Deleted) && (class252_0.FileName == this.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.get_OriginalName()));
            }
        }

        [CompilerGenerated]
        private sealed class Class293
        {
            public string string_0;

            internal bool method_0(DataSetTechConnection.Class252 class252_0)
            {
                return (class252_0.FileName == this.string_0);
            }
        }
    }
}

