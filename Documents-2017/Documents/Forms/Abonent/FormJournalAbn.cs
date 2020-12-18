
    using ControlsLbr;
    using ControlsLbr.DataGridViewExcelFilter;
    using Documents.Properties;
    using FormLbr.Classes;
    using Legal.Forms;
    using Passport.Forms;
    using Prv.Forms.Abonent;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Xml;
    //using WeifenLuo.WinFormsUI.Docking;
namespace Documents.Forms.Abonent
{
    public class FormJournalAbn : WinFormsUI.Docking.DockContentBase
    {
        private BackgroundWorker backgroundWorker_0;
        private BindingSource bindingSource_0;
        private Button button_0;
        private CheckBox checkBox_0;
        private CheckBox checkBox_1;
        private CheckBox checkBox_2;
        private CheckBox checkBox_3;
        private CheckBox checkBox_4;
        private CheckBox checkBox_5;
        private CheckBox checkBox_6;
        private CheckBox checkBox_7;
        private CheckBox checkBox_8;
        private CheckBox checkBox_9;
        private CheckedListBox checkedListBox_0;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private ComboBox comboBox_3;
        private ContextMenuStrip contextMenuStrip_0;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_10;
        private DataColumn dataColumn_11;
        private DataColumn dataColumn_12;
        private DataColumn dataColumn_13;
        private DataColumn dataColumn_14;
        private DataColumn dataColumn_15;
        private DataColumn dataColumn_16;
        private DataColumn dataColumn_17;
        private DataColumn dataColumn_18;
        private DataColumn dataColumn_19;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_20;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataColumn dataColumn_6;
        private DataColumn dataColumn_7;
        private DataColumn dataColumn_8;
        private DataColumn dataColumn_9;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_0;
        private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_1;
        private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_14;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_15;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_16;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_17;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_18;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_19;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_20;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_21;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_22;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_23;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_24;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_25;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_26;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_27;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_28;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_29;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_30;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_31;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_32;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_33;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataSet dataSet_0;
        private DataTable dataTable_0;
        private GroupBox groupBox_0;
        private GroupBox groupBox_1;
        private GroupBox groupBox_2;
        private GroupBox groupBox_3;
        private GroupBox groupBox_4;
        private IContainer components;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label label_11;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private MultiColumnComboBox multiColumnComboBox_0;
        private RadioButton radioButton_0;
        private RadioButton radioButton_1;
        private SplitContainer splitContainer_0;
        private TabControl tabControl_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TabPage tabPage_2;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_2;
        private TextBox textBox_3;
        private TextBox textBox_4;
        private TextBox textBox_5;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripMenuItem toolStripMenuItem_1;
        private ToolStripMenuItem toolStripMenuItem_2;
        private ToolStripMenuItem toolStripMenuItem_3;
        private ToolStripMenuItem toolStripMenuItem_4;
        private ToolStripProgressBar toolStripProgressBar_0;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripTextBox toolStripTextBox_0;
        private ToolTip toolTip_0;

        public FormJournalAbn()
        {
            this.method_16();
        }

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            new List<int>();
            XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
            if (node != null)
            {
                XmlNode node2 = node.SelectSingleNode("AddColumn");
                if (node2 != null)
                {
                    XmlAttribute attribute2 = node2.Attributes["ColSub"];
                    if (attribute2 != null)
                    {
                        this.checkBox_7.Checked = Convert.ToBoolean(attribute2.Value);
                    }
                    attribute2 = node2.Attributes["ColBus"];
                    if (attribute2 != null)
                    {
                        this.checkBox_6.Checked = Convert.ToBoolean(attribute2.Value);
                    }
                    attribute2 = node2.Attributes["ColCell"];
                    if (attribute2 != null)
                    {
                        this.checkBox_5.Checked = Convert.ToBoolean(attribute2.Value);
                    }
                    attribute2 = node2.Attributes["ColSchmObj"];
                    if (attribute2 != null)
                    {
                        this.checkBox_4.Checked = Convert.ToBoolean(attribute2.Value);
                    }
                }
                XmlNode node3 = node.SelectSingleNode("TypeAbn");
                if (node3 != null)
                {
                    List<int> list = new List<int>();
                    foreach (XmlNode node4 in node3.SelectNodes("row"))
                    {
                        if (!string.IsNullOrEmpty(node4.InnerText))
                        {
                            list.Add(Convert.ToInt32(node4.InnerText));
                        }
                    }
                    for (int i = 0; i < this.checkedListBox_0.Items.Count; i++)
                    {
                        if (list.Contains(((Class201) this.checkedListBox_0.Items[i]).int_0))
                        {
                            this.checkedListBox_0.SetItemChecked(i, true);
                        }
                        else
                        {
                            this.checkedListBox_0.SetItemChecked(i, false);
                        }
                    }
                }
                XmlAttribute attribute = node.Attributes["IdKladrObj"];
                if (attribute != null)
                {
                    List<DataRow> list2 = new List<DataRow>();
                    this.method_2(Convert.ToInt32(attribute.Value), list2);
                    this.method_3(list2);
                }
            }
        }

        private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
        {
            this.dataTable_0.Clear();
            SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString());
            try
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandTimeout = 0;
                        command.CommandText = e.Argument.ToString();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(this.dataTable_0);
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                finally
                {
                    connection.Close();
                }
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message, exception2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
        }

        private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.button_0.Enabled = true;
            this.dataGridViewExcelFilter_0.Enabled = true;
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.toolStripProgressBar_0.Visible = false;
            base.SaveFormConfig(null);
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            this.button_0.Enabled = false;
            this.dataGridViewExcelFilter_0.Enabled = false;
            this.dataGridViewExcelFilter_0.DataSource = null;
            this.toolStripProgressBar_0.Visible = true;
            this.method_8();
            this.backgroundWorker_0.RunWorkerAsync(this.method_9());
        }

        private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_0.SelectedIndex < 0)
            {
                this.comboBox_3.DataSource = null;
            }
            else
            {
                DataTable table = this.method_6();
                this.comboBox_3.SelectedIndex = -1;
                this.comboBox_3.DisplayMember = "namefull";
                this.comboBox_3.ValueMember = "id";
                this.comboBox_3.DataSource = table;
                base.SelectSqlData(table, true, " where KladrObjId = " + this.comboBox_0.SelectedValue.ToString() + " and deleted = 0 order by name, socr", false);
                this.comboBox_3.SelectedIndex = -1;
            }
        }

        private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_1.SelectedIndex < 0)
            {
                this.comboBox_0.DataSource = null;
                this.comboBox_3.DataSource = null;
            }
            else
            {
                DataTable table = this.method_5();
                this.comboBox_0.DisplayMember = "namefull";
                this.comboBox_0.ValueMember = "id";
                this.comboBox_0.DataSource = table;
                base.SelectSqlData(table, true, " where ParentId = " + this.comboBox_1.SelectedValue.ToString() + " and deleted = 0 order by name, socr", false);
                this.comboBox_0.SelectedIndex = -1;
                table = this.method_6();
                this.comboBox_3.SelectedIndex = -1;
                this.comboBox_3.DisplayMember = "namefull";
                this.comboBox_3.ValueMember = "id";
                this.comboBox_3.DataSource = table;
                base.SelectSqlData(table, true, " where KladrObjId = " + this.comboBox_1.SelectedValue.ToString() + " and deleted = 0 order by name, socr", false);
                this.comboBox_3.SelectedIndex = -1;
            }
        }

        private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_2.SelectedIndex < 0)
            {
                this.comboBox_1.DataSource = null;
            }
            else
            {
                DataTable table = this.method_5();
                this.comboBox_1.DisplayMember = "nameFull";
                this.comboBox_1.ValueMember = "id";
                this.comboBox_1.DataSource = table;
                base.SelectSqlData(table, true, " where ParentId = " + this.comboBox_2.SelectedValue.ToString() + " and deleted = 0 order by name, socr", false);
                this.comboBox_1.SelectedIndex = -1;
            }
        }

        private void contextMenuStrip_0_Opening(object sender, CancelEventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow == null)
            {
                return;
            }
            if (!Convert.ToBoolean(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterCheckBoxColumn_0.Name].Value))
            {
                switch (Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_23.Name].Value))
                {
                    case 0xce:
                    case 0xfd:
                        this.toolStripMenuItem_0.Enabled = true;
                        goto Label_00D2;

                    case 0xcf:
                    case 230:
                    case 0xe7:
                        this.toolStripMenuItem_0.Enabled = true;
                        goto Label_00D2;
                }
                this.toolStripMenuItem_0.Enabled = false;
            }
            else
            {
                this.toolStripMenuItem_0.Enabled = false;
            }
        Label_00D2:
            if (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_29.Name].Value == DBNull.Value)
            {
                this.toolStripMenuItem_1.Enabled = false;
                this.toolStripMenuItem_1.Tag = null;
            }
            else
            {
                this.toolStripMenuItem_1.Tag = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_29.Name].Value;
                this.toolStripMenuItem_1.Enabled = true;
            }
            if (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_30.Name].Value == DBNull.Value)
            {
                this.toolStripMenuItem_3.Enabled = false;
                this.toolStripMenuItem_3.Tag = null;
                this.toolStripMenuItem_4.Enabled = false;
                this.toolStripMenuItem_4.Tag = null;
            }
            else
            {
                this.toolStripMenuItem_3.Tag = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_30.Name].Value;
                this.toolStripMenuItem_3.Enabled = true;
                this.toolStripMenuItem_4.Tag = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_30.Name].Value;
                this.toolStripMenuItem_4.Enabled = true;
            }
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document = new XmlDocument();
            XmlNode newChild = document.CreateXmlDeclaration("1.0", "UTF-8", null);
            document.AppendChild(newChild);
            XmlNode node2 = document.CreateElement(base.Name);
            document.AppendChild(node2);
            XmlNode node3 = document.CreateElement("AddColumn");
            node2.AppendChild(node3);
            if (this.checkBox_7.Checked)
            {
                XmlAttribute attribute2 = document.CreateAttribute("ColSub");
                attribute2.Value = this.checkBox_7.Checked.ToString();
                node3.Attributes.Append(attribute2);
            }
            if (this.checkBox_6.Checked)
            {
                XmlAttribute attribute3 = document.CreateAttribute("ColBus");
                attribute3.Value = this.checkBox_6.Checked.ToString();
                node3.Attributes.Append(attribute3);
            }
            if (this.checkBox_5.Checked)
            {
                XmlAttribute attribute4 = document.CreateAttribute("ColCell");
                attribute4.Value = this.checkBox_5.Checked.ToString();
                node3.Attributes.Append(attribute4);
            }
            if (this.checkBox_4.Checked)
            {
                XmlAttribute attribute5 = document.CreateAttribute("ColSchmObj");
                attribute5.Value = this.checkBox_4.Checked.ToString();
                node3.Attributes.Append(attribute5);
            }
            XmlNode node4 = document.CreateElement("TypeAbn");
            node2.AppendChild(node4);
            foreach (object obj2 in this.checkedListBox_0.CheckedItems)
            {
                XmlNode node5 = document.CreateElement("row");
                node5.InnerText = ((Class201) obj2).int_0.ToString();
                node4.AppendChild(node5);
            }
            int num = 2;
            if (this.comboBox_0.SelectedIndex >= 0)
            {
                num = Convert.ToInt32(this.comboBox_0.SelectedValue);
            }
            else if (this.comboBox_1.SelectedIndex >= 0)
            {
                num = Convert.ToInt32(this.comboBox_1.SelectedValue);
            }
            else
            {
                num = Convert.ToInt32(this.comboBox_2.SelectedValue);
            }
            XmlAttribute node = document.CreateAttribute("IdKladrObj");
            node.Value = num.ToString();
            node2.Attributes.Append(node);
            return document;
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
            {
                if (Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewFilterCheckBoxColumn_0.Name, e.RowIndex].Value))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else
                {
                    switch (Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_23.Name, e.RowIndex].Value))
                    {
                        case 0xcf:
                            e.CellStyle.BackColor = Color.LightGray;
                            break;

                        case 230:
                            e.CellStyle.ForeColor = Color.Green;
                            break;

                        case 0xe7:
                            e.CellStyle.ForeColor = Color.Blue;
                            break;
                    }
                    if (!Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewFilterCheckBoxColumn_1.Name, e.RowIndex].Value))
                    {
                        DataGridViewColumn column = this.dataGridViewExcelFilter_0.Columns[e.ColumnIndex];
                        if (((column == this.dataGridViewFilterTextBoxColumn_16) || (column == this.dataGridViewFilterTextBoxColumn_17)) || (column == this.dataGridViewFilterTextBoxColumn_18))
                        {
                            e.CellStyle.BackColor = Color.LightYellow;
                        }
                    }
                    if (!Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewFilterCheckBoxColumn_2.Name, e.RowIndex].Value) && (this.dataGridViewExcelFilter_0.Columns[e.ColumnIndex] == this.dataGridViewFilterTextBoxColumn_19))
                    {
                        e.CellStyle.BackColor = Color.LightYellow;
                    }
                }
            }
        }

        private void dataGridViewExcelFilter_0_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && ((e.Button == MouseButtons.Right) && (e.Clicks == 1))) && (this.dataGridViewExcelFilter_0.CurrentRow != null))
            {
                DataGridViewRow currentRow = this.dataGridViewExcelFilter_0.CurrentRow;
                this.contextMenuStrip_0.Show(Cursor.Position);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormJournalAbn_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void FormJournalAbn_Load(object sender, EventArgs e)
        {
            this.method_0();
            base.LoadFormConfig(null);
        }

        private void method_0()
        {
            this.method_1();
            List<DataRow> list = new List<DataRow>();
            this.method_2(2, list);
            this.method_3(list);
            this.method_8();
        }

        private void method_1()
        {
            DataTable table = this.method_4();
            string[] textArray1 = new string[] { 0x2ab.ToString(), ",", 680.ToString(), ",", 0x266.ToString(), ",", 0x245.ToString() };
            string str = string.Concat(textArray1);
            base.SelectSqlData(table, true, string.Format(" where ParentKey = ';SKUEE;TypeAbn;' and id not in ({0}) and isGroup = 0 and deleted = 0 order by name", str), false);
            this.checkedListBox_0.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                this.checkedListBox_0.Items.Add(new Class201(Convert.ToInt32(row["id"]), row["name"].ToString()), true);
            }
        }

        private string method_10()
        {
            string str = "";
            if ((this.checkBox_4.Checked || this.checkBox_7.Checked) || (this.checkBox_6.Checked || this.checkBox_5.Checked))
            {
                str = str + "\r\n,link.idSchmObj ";
                if (this.checkBox_5.Checked)
                {
                    str = str + "\r\n,cell.CellName ";
                }
                if (this.checkBox_6.Checked)
                {
                    str = str + "\r\n,isnull(cell.BusName, bus.busname) as busname ";
                }
                if (this.checkBox_7.Checked)
                {
                    str = str + "\r\n,isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname ";
                }
                if (this.checkBox_4.Checked)
                {
                    str = str + "\r\n ,isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+\r\n\t\t\t                isnull('\\' + isnull(cell.BusName, bus.busname), '')+isnull('\\'+cell.CellName, '') as schmObjName ";
                }
                if (this.checkBox_4.Checked || this.checkBox_7.Checked)
                {
                    str = str + "\r\n, isnull(cell.subid, isnull(bus.subid, sub.id)) as IdSub ";
                }
            }
            if (this.checkBox_9.Checked)
            {
                str = str + "\r\n,meter.Name as PointTypeMeter";
            }
            if (this.checkBox_8.Checked)
            {
                str = str + "\r\n,pReg.Number as PointNumber";
            }
            return str;
        }

        private string method_11()
        {
            string str = "";
            if ((!this.checkBox_4.Checked && !this.checkBox_7.Checked) && (!this.checkBox_6.Checked && !this.checkBox_5.Checked))
            {
                return str;
            }
            str = str + ", cell\t(cellId, cellName, busId, busName, subId, subName, deleted) AS\r\n                            (SELECT  cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], \r\n\t\t                    bus.id,  ISNULL(cBus.SocrName + '-', '') + bus.Name [Text],\r\n\t\t                    sub.id,  ISNULL(cSub.SocrName + '-', '') + sub.Name [Text], \r\n\t\t                    case when cell.deleted = 0 and bus.deleted = 0 and sub.deleted = 0 then 0 else 1 end\r\n                         FROM tSchm_ObjList AS bus\r\n\t                            JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%'\r\n\t                            JOIN tSchm_ObjList AS point ON bus.id = point.IdParent\r\n\t                            JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj\r\n\t                            JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id\r\n\t                            JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%'\r\n\t                            join tschm_objlist as sub on sub.id = bus.idparent\r\n\t                            JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id \r\n                            WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))\r\n";
            if ((this.checkBox_4.Checked || this.checkBox_7.Checked) || this.checkBox_6.Checked)
            {
                str = str + ", bus (Id, busName, subid, subname, deleted) AS\r\n                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name, \r\n\t\t                                case when o.deleted = 0 and sub.deleted = 0 then 0 else 1 end\r\n                                     FROM tSchm_ObjList AS o \r\n\t                                    JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id\r\n\t                                    join tSChm_ObjList sub on sub.id = o.idParent\r\n\t                                    join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id\r\n                                     WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0)))\r\n";
            }
            if (!this.checkBox_4.Checked && !this.checkBox_7.Checked)
            {
                return str;
            }
            return (str + ", sub (Id, FullName, deleted) AS\r\n                                (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text], o.deleted\r\n                                 FROM tSchm_ObjList AS o\r\n                                    LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id\r\n                                 WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0)))\r\n");
        }

        private string method_12()
        {
            string str = "";
            if ((this.checkBox_4.Checked || this.checkBox_7.Checked) || (this.checkBox_6.Checked || this.checkBox_5.Checked))
            {
                str = str + " left join tl_SchmAbn link on link.idAbnObj = a.id\r\n" + " left join cell on cell.cellid = link.idSchmObj\r\n";
                if ((this.checkBox_4.Checked || this.checkBox_7.Checked) || this.checkBox_6.Checked)
                {
                    str = str + " left join bus on bus.id = link.idSChmObj\r\n";
                }
                if (this.checkBox_4.Checked || this.checkBox_7.Checked)
                {
                    str = str + " left join sub on sub.id = link.idSChmObj\r\n";
                }
            }
            if (((this.multiColumnComboBox_0.SelectedIndex >= 0) || this.checkBox_9.Checked) || (!string.IsNullOrEmpty(this.textBox_5.Text) || this.checkBox_8.Checked))
            {
                str = str + " left join tPoint p on p.idAbnObj = a.id\r\n";
                if (this.radioButton_1.Checked)
                {
                    str = str + " left join tPointReg pReg on pReg.id = (select top 1 id \r\n                                                                          from tPointReg\r\n                                                                          where idPoint = p.id and [type] in (245,247,248)\r\n                                                                          order by datebegin desc)\r\n";
                }
                else
                {
                    str = str + " left join tPointReg pReg on pReg.idPoint = p.id and pREg.[type] in (245,247,248)\r\n";
                }
                if (this.checkBox_9.Checked)
                {
                    str = str + " left join tR_MarkMeter meter on meter.id = pREg.idMark\r\n";
                }
            }
            return str;
        }

        private string method_13()
        {
            string str = "";
            if (!string.IsNullOrEmpty(this.textBox_1.Text))
            {
                str = str + string.Format(" where (a.codeAbonent = {0}) ", this.textBox_1.Text);
            }
            string str2 = "";
            if (!string.IsNullOrEmpty(this.textBox_0.Text))
            {
                if (this.checkBox_0.Checked)
                {
                    str2 = string.Format("(a.name = '{0}') ", this.textBox_0.Text);
                }
                else
                {
                    str2 = string.Format("(a.name like '%{0}%') ", this.textBox_0.Text);
                }
                str = this.method_14(str, str2);
            }
            if (this.checkedListBox_0.CheckedItems.Count > 0)
            {
                List<string> list = new List<string>();
                foreach (object obj2 in this.checkedListBox_0.CheckedItems)
                {
                    list.Add(((Class201) obj2).int_0.ToString());
                }
                str2 = string.Format("(a.TypeAbn in ({0})) ", string.Join(",", list.ToArray()));
                str = this.method_14(str, str2);
            }
            if (this.checkBox_2.Checked)
            {
                str2 = "(a.isActive = 1) ";
                str = this.method_14(str, str2);
            }
            if (!this.checkBox_1.Checked)
            {
                str2 = "(a.deleted = 0) ";
                str = this.method_14(str, str2);
            }
            if (!string.IsNullOrEmpty(this.textBox_2.Text))
            {
                if (this.checkBox_0.Checked)
                {
                    str2 = string.Format("(a.nameObj = '{0}') ", this.textBox_2.Text);
                }
                else
                {
                    str2 = string.Format("(a.nameObj like '%{0}%') ", this.textBox_2.Text);
                }
                str = this.method_14(str, str2);
            }
            if (this.comboBox_3.SelectedIndex < 0)
            {
                if (this.comboBox_0.SelectedIndex >= 0)
                {
                    str2 = string.Format("(a.KladrObjId = {0})", this.comboBox_0.SelectedValue);
                    str = this.method_14(str, str2);
                }
                else if (this.comboBox_1.SelectedIndex >= 0)
                {
                    if (this.method_15(Convert.ToInt32(this.comboBox_1.SelectedValue)) > 0)
                    {
                        str2 = string.Format("(a.KladrObjId = {0})", this.comboBox_1.SelectedValue);
                    }
                    else
                    {
                        str2 = string.Format("(a.KladrObjParent = {0})", this.comboBox_1.SelectedValue);
                    }
                    str = this.method_14(str, str2);
                }
            }
            else
            {
                str2 = string.Format("(a.idStreet = {0})", this.comboBox_3.SelectedValue);
                str = this.method_14(str, str2);
            }
            if (!string.IsNullOrEmpty(this.textBox_4.Text))
            {
                str2 = string.Format("(a.house = {0})", this.textBox_4.Text);
                str = this.method_14(str, str2);
            }
            if (!string.IsNullOrEmpty(this.textBox_3.Text))
            {
                if (this.checkBox_0.Checked)
                {
                    str2 = string.Format("(a.housePrefix = '{0}')", this.textBox_3.Text);
                }
                else
                {
                    str2 = string.Format("(a.housePrefix like '%{0}%')", this.textBox_3.Text);
                }
                str = this.method_14(str, str2);
            }
            if (this.checkBox_3.Checked)
            {
                str2 = "(a.TypeAbn not in (207,230,231) or activeObj.isActive = 1) ";
                str = this.method_14(str, str2);
            }
            if (this.multiColumnComboBox_0.SelectedIndex >= 0)
            {
                str2 = string.Format("(pREg.idMark = {0})", this.multiColumnComboBox_0.SelectedValue);
                str = this.method_14(str, str2);
            }
            if (string.IsNullOrEmpty(this.textBox_5.Text))
            {
                return str;
            }
            if (this.checkBox_0.Checked)
            {
                str2 = string.Format("(pReg.Number = '{0}')", this.textBox_5.Text);
            }
            else
            {
                str2 = string.Format("(pReg.Number like '%{0}%')", this.textBox_5.Text);
            }
            return this.method_14(str, str2);
        }

        private string method_14(string string_0, string string_1)
        {
            if (string.IsNullOrEmpty(string_0))
            {
                string_0 = " where " + string_1;
                return string_0;
            }
            string_0 = string_0 + "and " + string_1;
            return string_0;
        }

        private int method_15(int int_0)
        {
            int num2;
            SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString());
            try
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandTimeout = 0;
                        command.CommandText = "select count(*) from vAbnObj where KladrObjId = " + int_0.ToString();
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                finally
                {
                    connection.Close();
                }
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message, exception2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                num2 = 0;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
            return num2;
        }

        private void method_16()
        {
            this.components = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripProgressBar_0 = new ToolStripProgressBar();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_3 = new ToolStripButton();
            this.splitContainer_0 = new SplitContainer();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.groupBox_1 = new GroupBox();
            this.checkBox_3 = new CheckBox();
            this.label_8 = new Label();
            this.textBox_3 = new TextBox();
            this.textBox_4 = new TextBox();
            this.label_9 = new Label();
            this.comboBox_3 = new ComboBox();
            this.label_7 = new Label();
            this.label_4 = new Label();
            this.comboBox_0 = new ComboBox();
            this.comboBox_1 = new ComboBox();
            this.label_5 = new Label();
            this.comboBox_2 = new ComboBox();
            this.label_6 = new Label();
            this.textBox_2 = new TextBox();
            this.label_3 = new Label();
            this.groupBox_0 = new GroupBox();
            this.checkBox_1 = new CheckBox();
            this.checkBox_2 = new CheckBox();
            this.checkedListBox_0 = new CheckedListBox();
            this.label_0 = new Label();
            this.textBox_0 = new TextBox();
            this.label_1 = new Label();
            this.textBox_1 = new TextBox();
            this.label_2 = new Label();
            this.tabPage_1 = new TabPage();
            this.groupBox_3 = new GroupBox();
            this.label_11 = new Label();
            this.textBox_5 = new TextBox();
            this.multiColumnComboBox_0 = new MultiColumnComboBox();
            this.label_10 = new Label();
            this.radioButton_0 = new RadioButton();
            this.radioButton_1 = new RadioButton();
            this.tabPage_2 = new TabPage();
            this.groupBox_4 = new GroupBox();
            this.checkBox_8 = new CheckBox();
            this.checkBox_9 = new CheckBox();
            this.groupBox_2 = new GroupBox();
            this.checkBox_4 = new CheckBox();
            this.checkBox_5 = new CheckBox();
            this.checkBox_6 = new CheckBox();
            this.checkBox_7 = new CheckBox();
            this.checkBox_0 = new CheckBox();
            this.button_0 = new Button();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewFilterCheckBoxColumn_0 = new DataGridViewFilterCheckBoxColumn();
            this.dataGridViewFilterCheckBoxColumn_1 = new DataGridViewFilterCheckBoxColumn();
            this.dataGridViewFilterCheckBoxColumn_2 = new DataGridViewFilterCheckBoxColumn();
            this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_18 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_19 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_20 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_21 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_22 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_23 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_24 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_25 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_26 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_27 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_28 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_29 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_30 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_31 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_32 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_33 = new DataGridViewFilterTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.components);
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.dataColumn_4 = new DataColumn();
            this.dataColumn_5 = new DataColumn();
            this.dataColumn_6 = new DataColumn();
            this.dataColumn_7 = new DataColumn();
            this.dataColumn_8 = new DataColumn();
            this.dataColumn_9 = new DataColumn();
            this.dataColumn_10 = new DataColumn();
            this.dataColumn_11 = new DataColumn();
            this.dataColumn_12 = new DataColumn();
            this.dataColumn_13 = new DataColumn();
            this.dataColumn_14 = new DataColumn();
            this.dataColumn_15 = new DataColumn();
            this.dataColumn_16 = new DataColumn();
            this.dataColumn_17 = new DataColumn();
            this.dataColumn_18 = new DataColumn();
            this.dataColumn_19 = new DataColumn();
            this.dataColumn_20 = new DataColumn();
            this.backgroundWorker_0 = new BackgroundWorker();
            this.contextMenuStrip_0 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripMenuItem_2 = new ToolStripMenuItem();
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.toolStripMenuItem_3 = new ToolStripMenuItem();
            this.toolStripMenuItem_4 = new ToolStripMenuItem();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.toolTip_0 = new ToolTip(this.components);
            this.toolStrip_0.SuspendLayout();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.groupBox_1.SuspendLayout();
            this.groupBox_0.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.groupBox_3.SuspendLayout();
            this.tabPage_2.SuspendLayout();
            this.groupBox_4.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            this.contextMenuStrip_0.SuspendLayout();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripProgressBar_0, this.toolStripButton_0, this.toolStripTextBox_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripSeparator_0, this.toolStripButton_3 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStripMain";
            this.toolStrip_0.Size = new Size(0x43b, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripProgressBar_0.Alignment = ToolStripItemAlignment.Right;
            this.toolStripProgressBar_0.Name = "progressBar";
            this.toolStripProgressBar_0.Size = new Size(100, 0x16);
            this.toolStripProgressBar_0.Style = ProgressBarStyle.Marquee;
            this.toolStripProgressBar_0.Visible = false;
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.Find;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnFind";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Поиск";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripTextBox_0.Name = "toolTextFind";
            this.toolStripTextBox_0.Size = new Size(100, 0x19);
            this.toolStripTextBox_0.ToolTipText = "Текст для поиска";
            this.toolStripTextBox_0.KeyDown += new KeyEventHandler(this.toolStripTextBox_0_KeyDown);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.FindPrev;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnFindPrev";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Поиск назад";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.FindNext;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnFindNext";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Поиск вперед";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.microsoftoffice2007excel_7581;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "tooBtnExportToExcel";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Экспорт в Excel";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Name = "splitContainer1";
            this.splitContainer_0.Panel1.Controls.Add(this.tabControl_0);
            this.splitContainer_0.Panel1.Controls.Add(this.checkBox_0);
            this.splitContainer_0.Panel1.Controls.Add(this.button_0);
            this.splitContainer_0.Panel2.Controls.Add(this.dataGridViewExcelFilter_0);
            this.splitContainer_0.Size = new Size(0x43b, 0x283);
            this.splitContainer_0.SplitterDistance = 0x109;
            this.splitContainer_0.TabIndex = 1;
            this.tabControl_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Controls.Add(this.tabPage_2);
            this.tabControl_0.Location = new Point(4, 3);
            this.tabControl_0.Name = "tabControlFilter";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x103, 0x22f);
            this.tabControl_0.TabIndex = 0;
            this.tabControl_0.SelectedIndexChanged += new EventHandler(this.tabControl_0_SelectedIndexChanged);
            this.tabPage_0.AutoScroll = true;
            this.tabPage_0.Controls.Add(this.groupBox_1);
            this.tabPage_0.Controls.Add(this.groupBox_0);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tabPageFilter";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(0xfb, 0x215);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Фильтр";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.groupBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_1.Controls.Add(this.checkBox_3);
            this.groupBox_1.Controls.Add(this.label_8);
            this.groupBox_1.Controls.Add(this.textBox_3);
            this.groupBox_1.Controls.Add(this.textBox_4);
            this.groupBox_1.Controls.Add(this.label_9);
            this.groupBox_1.Controls.Add(this.comboBox_3);
            this.groupBox_1.Controls.Add(this.label_7);
            this.groupBox_1.Controls.Add(this.label_4);
            this.groupBox_1.Controls.Add(this.comboBox_0);
            this.groupBox_1.Controls.Add(this.comboBox_1);
            this.groupBox_1.Controls.Add(this.label_5);
            this.groupBox_1.Controls.Add(this.comboBox_2);
            this.groupBox_1.Controls.Add(this.label_6);
            this.groupBox_1.Controls.Add(this.textBox_2);
            this.groupBox_1.Controls.Add(this.label_3);
            this.groupBox_1.Location = new Point(0, 0xfd);
            this.groupBox_1.Name = "groupBoxAbnObj";
            this.groupBox_1.Size = new Size(0xfb, 0xce);
            this.groupBox_1.TabIndex = 1;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "Объект абонента";
            this.checkBox_3.AutoSize = true;
            this.checkBox_3.Checked = true;
            this.checkBox_3.CheckState = CheckState.Checked;
            this.checkBox_3.Location = new Point(9, 180);
            this.checkBox_3.Name = "chkActiveAbnObj";
            this.checkBox_3.Size = new Size(0x73, 0x11);
            this.checkBox_3.TabIndex = 0x1b;
            this.checkBox_3.Text = "Только активные";
            this.checkBox_3.UseVisualStyleBackColor = true;
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(0x6a, 0x9d);
            this.label_8.Name = "label7";
            this.label_8.Size = new Size(0x23, 13);
            this.label_8.TabIndex = 0x19;
            this.label_8.Text = "Преф";
            this.textBox_3.Location = new Point(0x93, 0x9a);
            this.textBox_3.Name = "txtHousePrefix";
            this.textBox_3.Size = new Size(0x26, 20);
            this.textBox_3.TabIndex = 0x1a;
            this.textBox_4.Location = new Point(0x30, 0x9a);
            this.textBox_4.Name = "txtHouse";
            this.textBox_4.Size = new Size(0x29, 20);
            this.textBox_4.TabIndex = 0x18;
            this.label_9.AutoSize = true;
            this.label_9.Location = new Point(5, 0x9d);
            this.label_9.Name = "label8";
            this.label_9.Size = new Size(30, 13);
            this.label_9.TabIndex = 0x17;
            this.label_9.Text = "Дом";
            this.comboBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_3.DisplayMember = "tR_KladrStreet.NameSocr";
            this.comboBox_3.FormattingEnabled = true;
            this.comboBox_3.Location = new Point(0x5c, 130);
            this.comboBox_3.Name = "cmbStreet";
            this.comboBox_3.Size = new Size(0x98, 0x15);
            this.comboBox_3.TabIndex = 0x16;
            this.comboBox_3.ValueMember = "tR_KladrStreet.Id";
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(6, 0x85);
            this.label_7.Name = "label6";
            this.label_7.Size = new Size(0x27, 13);
            this.label_7.TabIndex = 0x15;
            this.label_7.Text = "Улица";
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(6, 0x6a);
            this.label_4.Name = "label5";
            this.label_4.Size = new Size(0x3d, 13);
            this.label_4.TabIndex = 0x13;
            this.label_4.Text = "Нас. пункт";
            this.comboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_0.DisplayMember = "tR_KladrObj.NameSocr";
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(0x5c, 0x67);
            this.comboBox_0.Name = "cmbCity";
            this.comboBox_0.Size = new Size(0x98, 0x15);
            this.comboBox_0.TabIndex = 20;
            this.comboBox_0.ValueMember = "tR_KladrObj.Id";
            this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.comboBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_1.DisplayMember = "tR_KladrObj.NameSocr";
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(0x5c, 0x4b);
            this.comboBox_1.Name = "cmbRaionObl";
            this.comboBox_1.Size = new Size(0x98, 0x15);
            this.comboBox_1.TabIndex = 0x12;
            this.comboBox_1.ValueMember = "tR_KladrObj.Id";
            this.comboBox_1.SelectedIndexChanged += new EventHandler(this.comboBox_1_SelectedIndexChanged);
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(3, 0x4e);
            this.label_5.Name = "labelRaionObl";
            this.label_5.Size = new Size(0x48, 13);
            this.label_5.TabIndex = 0x11;
            this.label_5.Text = "Район/город";
            this.comboBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_2.DisplayMember = "tR_KladrObj.NameSocr";
            this.comboBox_2.FormattingEnabled = true;
            this.comboBox_2.Location = new Point(0x5c, 0x30);
            this.comboBox_2.Name = "cmbObl";
            this.comboBox_2.Size = new Size(0x98, 0x15);
            this.comboBox_2.TabIndex = 0x10;
            this.comboBox_2.ValueMember = "tR_KladrObj.Id";
            this.comboBox_2.SelectedIndexChanged += new EventHandler(this.comboBox_2_SelectedIndexChanged);
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(6, 0x33);
            this.label_6.Name = "labelObl";
            this.label_6.Size = new Size(50, 13);
            this.label_6.TabIndex = 15;
            this.label_6.Text = "Область";
            this.textBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_2.Location = new Point(0x5c, 0x16);
            this.textBox_2.Name = "txtNameAbnObj";
            this.textBox_2.Size = new Size(0x99, 20);
            this.textBox_2.TabIndex = 5;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(6, 0x19);
            this.label_3.Name = "label4";
            this.label_3.Size = new Size(0x53, 13);
            this.label_3.TabIndex = 4;
            this.label_3.Text = "Наименование";
            this.groupBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_0.Controls.Add(this.checkBox_1);
            this.groupBox_0.Controls.Add(this.checkBox_2);
            this.groupBox_0.Controls.Add(this.checkedListBox_0);
            this.groupBox_0.Controls.Add(this.label_0);
            this.groupBox_0.Controls.Add(this.textBox_0);
            this.groupBox_0.Controls.Add(this.label_1);
            this.groupBox_0.Controls.Add(this.textBox_1);
            this.groupBox_0.Controls.Add(this.label_2);
            this.groupBox_0.Location = new Point(0, 0);
            this.groupBox_0.Name = "groupBoxAbn";
            this.groupBox_0.Size = new Size(0xfb, 0xfd);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "Абонент";
            this.checkBox_1.AutoSize = true;
            this.checkBox_1.Location = new Point(9, 230);
            this.checkBox_1.Name = "chkShowDelAbn";
            this.checkBox_1.Size = new Size(0x84, 0x11);
            this.checkBox_1.TabIndex = 7;
            this.checkBox_1.Text = "Показать удаленных";
            this.checkBox_1.UseVisualStyleBackColor = true;
            this.checkBox_2.AutoSize = true;
            this.checkBox_2.Checked = true;
            this.checkBox_2.CheckState = CheckState.Checked;
            this.checkBox_2.Location = new Point(9, 0xcf);
            this.checkBox_2.Name = "chkActiveAbn";
            this.checkBox_2.Size = new Size(0x73, 0x11);
            this.checkBox_2.TabIndex = 6;
            this.checkBox_2.Text = "Только активные";
            this.checkBox_2.UseVisualStyleBackColor = true;
            this.checkedListBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.checkedListBox_0.CheckOnClick = true;
            this.checkedListBox_0.FormattingEnabled = true;
            this.checkedListBox_0.Location = new Point(6, 0x5c);
            this.checkedListBox_0.Name = "chkTypeAbn";
            this.checkedListBox_0.Size = new Size(0xef, 0x6d);
            this.checkedListBox_0.TabIndex = 5;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(6, 0x4c);
            this.label_0.Name = "label3";
            this.label_0.Size = new Size(0x4c, 13);
            this.label_0.TabIndex = 4;
            this.label_0.Text = "Тип абонента";
            this.textBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_0.Location = new Point(0x5c, 0x30);
            this.textBox_0.Name = "txtNameAbn";
            this.textBox_0.Size = new Size(0x99, 20);
            this.textBox_0.TabIndex = 3;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(6, 0x33);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0x53, 13);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "Наименование";
            this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_1.Location = new Point(0x5c, 0x16);
            this.textBox_1.Name = "txtCodeAbn";
            this.textBox_1.Size = new Size(0x99, 20);
            this.textBox_1.TabIndex = 1;
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(6, 0x19);
            this.label_2.Name = "label1";
            this.label_2.Size = new Size(0x1a, 13);
            this.label_2.TabIndex = 0;
            this.label_2.Text = "Код";
            this.tabPage_1.AutoScroll = true;
            this.tabPage_1.Controls.Add(this.groupBox_3);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPageFilterAdd";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(0xfb, 0x215);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "Расширенный фильтр";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.groupBox_3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_3.Controls.Add(this.label_11);
            this.groupBox_3.Controls.Add(this.textBox_5);
            this.groupBox_3.Controls.Add(this.multiColumnComboBox_0);
            this.groupBox_3.Controls.Add(this.label_10);
            this.groupBox_3.Controls.Add(this.radioButton_0);
            this.groupBox_3.Controls.Add(this.radioButton_1);
            this.groupBox_3.Location = new Point(0, 0);
            this.groupBox_3.Name = "groupBoxPoint";
            this.groupBox_3.Size = new Size(0xfb, 0x151);
            this.groupBox_3.TabIndex = 0;
            this.groupBox_3.TabStop = false;
            this.groupBox_3.Text = "Точка учета";
            this.label_11.AutoSize = true;
            this.label_11.Location = new Point(6, 0x48);
            this.label_11.Name = "label10";
            this.label_11.Size = new Size(0x59, 13);
            this.label_11.TabIndex = 6;
            this.label_11.Text = "Номер счетчика";
            this.textBox_5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox_5.Location = new Point(0x65, 0x45);
            this.textBox_5.Name = "txtPointNumber";
            this.textBox_5.Size = new Size(0x8f, 20);
            this.textBox_5.TabIndex = 5;
            this.textBox_5.TextChanged += new EventHandler(this.textBox_5_TextChanged);
            this.multiColumnComboBox_0.set_AutoComplete(true);
            this.multiColumnComboBox_0.set_AutoDropdown(true);
            this.multiColumnComboBox_0.set_BackColorEven(Color.White);
            this.multiColumnComboBox_0.set_BackColorOdd(Color.White);
            this.multiColumnComboBox_0.set_ColumnNames("");
            this.multiColumnComboBox_0.set_ColumnWidthDefault(0x4b);
            this.multiColumnComboBox_0.set_ColumnWidths("0;100;25;25;30;25");
            this.multiColumnComboBox_0.set_DrawMode(DrawMode.OwnerDrawVariable);
            this.multiColumnComboBox_0.FormattingEnabled = true;
            this.multiColumnComboBox_0.set_LinkedColumnIndex(0);
            this.multiColumnComboBox_0.set_LinkedTextBox(null);
            this.multiColumnComboBox_0.Location = new Point(0x65, 0x2a);
            this.multiColumnComboBox_0.Name = "cmbPointTypeMeter";
            this.multiColumnComboBox_0.Size = new Size(0x90, 0x15);
            this.multiColumnComboBox_0.TabIndex = 4;
            this.multiColumnComboBox_0.SelectedIndexChanged += new EventHandler(this.multiColumnComboBox_0_SelectedIndexChanged);
            this.label_10.AutoSize = true;
            this.label_10.Location = new Point(6, 0x2d);
            this.label_10.Name = "label9";
            this.label_10.Size = new Size(0x4a, 13);
            this.label_10.TabIndex = 2;
            this.label_10.Text = "Тип счетчика";
            this.radioButton_0.AutoSize = true;
            this.radioButton_0.Location = new Point(120, 0x13);
            this.radioButton_0.Name = "rbPointAll";
            this.radioButton_0.Size = new Size(0x2c, 0x11);
            this.radioButton_0.TabIndex = 1;
            this.radioButton_0.TabStop = true;
            this.radioButton_0.Text = "Все";
            this.toolTip_0.SetToolTip(this.radioButton_0, "Все счетчики, включая демонтированные");
            this.radioButton_0.UseVisualStyleBackColor = true;
            this.radioButton_1.AutoSize = true;
            this.radioButton_1.Checked = true;
            this.radioButton_1.Location = new Point(8, 0x13);
            this.radioButton_1.Name = "rbPointCurrent";
            this.radioButton_1.Size = new Size(0x61, 0x11);
            this.radioButton_1.TabIndex = 0;
            this.radioButton_1.TabStop = true;
            this.radioButton_1.Text = "Действующие";
            this.toolTip_0.SetToolTip(this.radioButton_1, "Счетчики, которые установлены в данный момент");
            this.radioButton_1.UseVisualStyleBackColor = true;
            this.tabPage_2.AutoScroll = true;
            this.tabPage_2.Controls.Add(this.groupBox_4);
            this.tabPage_2.Controls.Add(this.groupBox_2);
            this.tabPage_2.Location = new Point(4, 0x16);
            this.tabPage_2.Name = "tabPageAddColumn";
            this.tabPage_2.Padding = new Padding(3);
            this.tabPage_2.Size = new Size(0xfb, 0x215);
            this.tabPage_2.TabIndex = 2;
            this.tabPage_2.Text = "Доп столбцы";
            this.tabPage_2.UseVisualStyleBackColor = true;
            this.groupBox_4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_4.Controls.Add(this.checkBox_8);
            this.groupBox_4.Controls.Add(this.checkBox_9);
            this.groupBox_4.Location = new Point(0, 0x6f);
            this.groupBox_4.Name = "groupBoxPointAddColumn";
            this.groupBox_4.Size = new Size(0xfb, 100);
            this.groupBox_4.TabIndex = 1;
            this.groupBox_4.TabStop = false;
            this.groupBox_4.Text = "Точка учета";
            this.checkBox_8.AutoSize = true;
            this.checkBox_8.Location = new Point(8, 0x2a);
            this.checkBox_8.Name = "chkPointNumber";
            this.checkBox_8.Size = new Size(0x6c, 0x11);
            this.checkBox_8.TabIndex = 1;
            this.checkBox_8.Text = "Номер счетчика";
            this.checkBox_8.UseVisualStyleBackColor = true;
            this.checkBox_9.AutoSize = true;
            this.checkBox_9.Location = new Point(8, 0x13);
            this.checkBox_9.Name = "chkPointTypeMeter";
            this.checkBox_9.Size = new Size(0x5d, 0x11);
            this.checkBox_9.TabIndex = 0;
            this.checkBox_9.Text = "Тип счетчика";
            this.checkBox_9.UseVisualStyleBackColor = true;
            this.groupBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox_2.Controls.Add(this.checkBox_4);
            this.groupBox_2.Controls.Add(this.checkBox_5);
            this.groupBox_2.Controls.Add(this.checkBox_6);
            this.groupBox_2.Controls.Add(this.checkBox_7);
            this.groupBox_2.Location = new Point(0, 0);
            this.groupBox_2.Name = "groupBoxLinkSchm";
            this.groupBox_2.Size = new Size(0xfb, 0x73);
            this.groupBox_2.TabIndex = 0;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "Привязка к схеме";
            this.checkBox_4.AutoSize = true;
            this.checkBox_4.Location = new Point(8, 0x58);
            this.checkBox_4.Name = "chkSchmObjName";
            this.checkBox_4.Size = new Size(0xb7, 0x11);
            this.checkBox_4.TabIndex = 3;
            this.checkBox_4.Text = "Наименование объекта схемы";
            this.checkBox_4.UseVisualStyleBackColor = true;
            this.checkBox_5.AutoSize = true;
            this.checkBox_5.Location = new Point(8, 0x41);
            this.checkBox_5.Name = "chkCellName";
            this.checkBox_5.Size = new Size(0x3f, 0x11);
            this.checkBox_5.TabIndex = 2;
            this.checkBox_5.Text = "Ячейка";
            this.checkBox_5.UseVisualStyleBackColor = true;
            this.checkBox_6.AutoSize = true;
            this.checkBox_6.Location = new Point(8, 0x2a);
            this.checkBox_6.Name = "chkBusName";
            this.checkBox_6.Size = new Size(0x35, 0x11);
            this.checkBox_6.TabIndex = 1;
            this.checkBox_6.Text = "Шина";
            this.checkBox_6.UseVisualStyleBackColor = true;
            this.checkBox_7.AutoSize = true;
            this.checkBox_7.Location = new Point(8, 0x13);
            this.checkBox_7.Name = "chkSubName";
            this.checkBox_7.Size = new Size(110, 0x11);
            this.checkBox_7.TabIndex = 0;
            this.checkBox_7.Text = "Имя подстанции";
            this.checkBox_7.UseVisualStyleBackColor = true;
            this.checkBox_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Location = new Point(0x10, 0x235);
            this.checkBox_0.Name = "chkPrecision";
            this.checkBox_0.Size = new Size(0x86, 0x11);
            this.checkBox_0.TabIndex = 1;
            this.checkBox_0.Text = "Точное соответствие";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_0.Location = new Point(0x10, 0x260);
            this.button_0.Name = "buttonApplyFilter";
            this.button_0.Size = new Size(0xec, 0x17);
            this.button_0.TabIndex = 0;
            this.button_0.Text = "Применить";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = style;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewFilterCheckBoxColumn_0, this.dataGridViewFilterCheckBoxColumn_1, this.dataGridViewFilterCheckBoxColumn_2, this.dataGridViewFilterTextBoxColumn_16, this.dataGridViewFilterTextBoxColumn_17, this.dataGridViewFilterTextBoxColumn_18, this.dataGridViewFilterTextBoxColumn_19, this.dataGridViewFilterTextBoxColumn_20, this.dataGridViewFilterTextBoxColumn_21, this.dataGridViewFilterTextBoxColumn_22, this.dataGridViewFilterTextBoxColumn_23, this.dataGridViewFilterTextBoxColumn_24, this.dataGridViewFilterTextBoxColumn_25, this.dataGridViewFilterTextBoxColumn_26, this.dataGridViewFilterTextBoxColumn_27, this.dataGridViewFilterTextBoxColumn_28,
                this.dataGridViewFilterTextBoxColumn_29, this.dataGridViewFilterTextBoxColumn_30, this.dataGridViewFilterTextBoxColumn_31, this.dataGridViewFilterTextBoxColumn_32, this.dataGridViewFilterTextBoxColumn_33
            };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Window;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style2.ForeColor = SystemColors.ControlText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_0.DefaultCellStyle = style2;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_0.Name = "dgv";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.RowHeadersDefaultCellStyle = style3;
            this.dataGridViewExcelFilter_0.Size = new Size(0x32e, 0x283);
            this.dataGridViewExcelFilter_0.TabIndex = 0;
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dataGridViewExcelFilter_0.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridViewExcelFilter_0_CellMouseClick);
            this.dataGridViewFilterCheckBoxColumn_0.DataPropertyName = "deletedAbn";
            this.dataGridViewFilterCheckBoxColumn_0.HeaderText = "Абонент удален";
            this.dataGridViewFilterCheckBoxColumn_0.Name = "deletedAbnDgvColumn";
            this.dataGridViewFilterCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterCheckBoxColumn_0.set_SortMode(DataGridViewColumnSortMode.NotSortable);
            this.dataGridViewFilterCheckBoxColumn_0.Visible = false;
            this.dataGridViewFilterCheckBoxColumn_0.Width = 40;
            this.dataGridViewFilterCheckBoxColumn_1.DataPropertyName = "activeAbn";
            this.dataGridViewFilterCheckBoxColumn_1.HeaderText = "Активный абонент";
            this.dataGridViewFilterCheckBoxColumn_1.Name = "activeAbnDgvColumn";
            this.dataGridViewFilterCheckBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterCheckBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterCheckBoxColumn_1.set_SortMode(DataGridViewColumnSortMode.NotSortable);
            this.dataGridViewFilterCheckBoxColumn_1.Visible = false;
            this.dataGridViewFilterCheckBoxColumn_2.DataPropertyName = "objActive";
            this.dataGridViewFilterCheckBoxColumn_2.HeaderText = "Активный объект";
            this.dataGridViewFilterCheckBoxColumn_2.Name = "objActiveDgvColumn";
            this.dataGridViewFilterCheckBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterCheckBoxColumn_2.Visible = false;
            this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "CodeAbonent";
            this.dataGridViewFilterTextBoxColumn_16.HeaderText = "Код";
            this.dataGridViewFilterTextBoxColumn_16.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_16.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "NameAbn";
            this.dataGridViewFilterTextBoxColumn_17.HeaderText = "Абонент";
            this.dataGridViewFilterTextBoxColumn_17.Name = "nameAbnDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_17.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_18.DataPropertyName = "TypeAbnName";
            this.dataGridViewFilterTextBoxColumn_18.HeaderText = "Тип абонента";
            this.dataGridViewFilterTextBoxColumn_18.Name = "typeAbnNameDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_18.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_19.DataPropertyName = "nameAbnObj";
            this.dataGridViewFilterTextBoxColumn_19.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_19.Name = "nameAbnObjDgvColumn";
            this.dataGridViewFilterTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_20.DataPropertyName = "KladrObjName";
            this.dataGridViewFilterTextBoxColumn_20.HeaderText = "Нас. пункт";
            this.dataGridViewFilterTextBoxColumn_20.Name = "KladrObjNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_21.DataPropertyName = "StreetName";
            this.dataGridViewFilterTextBoxColumn_21.HeaderText = "Улица";
            this.dataGridViewFilterTextBoxColumn_21.Name = "StreetNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_21.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_22.DataPropertyName = "House";
            this.dataGridViewFilterTextBoxColumn_22.HeaderText = "Дом";
            this.dataGridViewFilterTextBoxColumn_22.Name = "houseDgvColumn";
            this.dataGridViewFilterTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_23.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_23.DataPropertyName = "TypeAbn";
            this.dataGridViewFilterTextBoxColumn_23.HeaderText = "TypeAbn";
            this.dataGridViewFilterTextBoxColumn_23.Name = "typeAbnDgvColumn";
            this.dataGridViewFilterTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_23.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_23.Visible = false;
            this.dataGridViewFilterTextBoxColumn_24.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_24.DataPropertyName = "idAbn";
            this.dataGridViewFilterTextBoxColumn_24.HeaderText = "idAbn";
            this.dataGridViewFilterTextBoxColumn_24.Name = "idAbnDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_24.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_24.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_24.Visible = false;
            this.dataGridViewFilterTextBoxColumn_25.DataPropertyName = "SubName";
            this.dataGridViewFilterTextBoxColumn_25.HeaderText = "Подстанция";
            this.dataGridViewFilterTextBoxColumn_25.Name = "subNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_25.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_26.DataPropertyName = "BusName";
            this.dataGridViewFilterTextBoxColumn_26.HeaderText = "Шина";
            this.dataGridViewFilterTextBoxColumn_26.Name = "busNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_26.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_27.DataPropertyName = "CellName";
            this.dataGridViewFilterTextBoxColumn_27.HeaderText = "Ячейка";
            this.dataGridViewFilterTextBoxColumn_27.Name = "cellNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_27.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_28.DataPropertyName = "SchmObjName";
            this.dataGridViewFilterTextBoxColumn_28.HeaderText = "Объект схемы";
            this.dataGridViewFilterTextBoxColumn_28.Name = "schmObjNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_28.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_29.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_29.DataPropertyName = "idSchmObj";
            this.dataGridViewFilterTextBoxColumn_29.HeaderText = "idSchmObj";
            this.dataGridViewFilterTextBoxColumn_29.Name = "idSchmObjDgvColumn";
            this.dataGridViewFilterTextBoxColumn_29.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_29.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_29.Visible = false;
            this.dataGridViewFilterTextBoxColumn_30.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_30.DataPropertyName = "IdSub";
            this.dataGridViewFilterTextBoxColumn_30.HeaderText = "IdSub";
            this.dataGridViewFilterTextBoxColumn_30.Name = "IdSubDgvColumn";
            this.dataGridViewFilterTextBoxColumn_30.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_30.Visible = false;
            this.dataGridViewFilterTextBoxColumn_31.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_31.DataPropertyName = "idAbnObj";
            this.dataGridViewFilterTextBoxColumn_31.HeaderText = "idAbnObj";
            this.dataGridViewFilterTextBoxColumn_31.Name = "idAbnObjDgvColumn";
            this.dataGridViewFilterTextBoxColumn_31.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_31.Visible = false;
            this.dataGridViewFilterTextBoxColumn_32.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_32.DataPropertyName = "PointTypeMeter";
            this.dataGridViewFilterTextBoxColumn_32.HeaderText = "Тип счетчика";
            this.dataGridViewFilterTextBoxColumn_32.Name = "pointTypeMeterDgvColumn";
            this.dataGridViewFilterTextBoxColumn_32.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_32.Visible = false;
            this.dataGridViewFilterTextBoxColumn_33.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_33.DataPropertyName = "PointNumber";
            this.dataGridViewFilterTextBoxColumn_33.HeaderText = "№ счетчика";
            this.dataGridViewFilterTextBoxColumn_33.Name = "pointNumberDgvColumn";
            this.dataGridViewFilterTextBoxColumn_33.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_33.Visible = false;
            this.bindingSource_0.DataMember = "TableFindAbn";
            this.bindingSource_0.DataSource = this.dataSet_0;
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_0 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { 
                this.dataColumn_0, this.dataColumn_1, this.dataColumn_2, this.dataColumn_3, this.dataColumn_4, this.dataColumn_5, this.dataColumn_6, this.dataColumn_7, this.dataColumn_8, this.dataColumn_9, this.dataColumn_10, this.dataColumn_11, this.dataColumn_12, this.dataColumn_13, this.dataColumn_14, this.dataColumn_15,
                this.dataColumn_16, this.dataColumn_17, this.dataColumn_18, this.dataColumn_19, this.dataColumn_20
            };
            this.dataTable_0.Columns.AddRange(columns);
            this.dataTable_0.TableName = "TableFindAbn";
            this.dataColumn_0.ColumnName = "idAbn";
            this.dataColumn_0.DataType = typeof(int);
            this.dataColumn_1.ColumnName = "CodeAbonent";
            this.dataColumn_1.DataType = typeof(int);
            this.dataColumn_2.ColumnName = "NameAbn";
            this.dataColumn_3.ColumnName = "TypeAbn";
            this.dataColumn_3.DataType = typeof(int);
            this.dataColumn_4.ColumnName = "TypeAbnName";
            this.dataColumn_5.ColumnName = "deletedAbn";
            this.dataColumn_5.DataType = typeof(bool);
            this.dataColumn_6.ColumnName = "activeAbn";
            this.dataColumn_6.DataType = typeof(bool);
            this.dataColumn_7.ColumnName = "nameAbnObj";
            this.dataColumn_8.ColumnName = "KladrObjName";
            this.dataColumn_9.ColumnName = "StreetName";
            this.dataColumn_10.ColumnName = "House";
            this.dataColumn_11.ColumnName = "objActive";
            this.dataColumn_11.DataType = typeof(bool);
            this.dataColumn_12.ColumnName = "SubName";
            this.dataColumn_13.ColumnName = "BusName";
            this.dataColumn_14.ColumnName = "CellName";
            this.dataColumn_15.ColumnName = "SchmObjName";
            this.dataColumn_16.ColumnName = "idSchmObj";
            this.dataColumn_17.ColumnName = "idAbnObj";
            this.dataColumn_17.DataType = typeof(int);
            this.dataColumn_18.ColumnName = "IdSub";
            this.dataColumn_18.DataType = typeof(int);
            this.dataColumn_19.ColumnName = "PointTypeMeter";
            this.dataColumn_20.ColumnName = "PointNumber";
            this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
            this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_2, this.toolStripMenuItem_4 };
            this.contextMenuStrip_0.Items.AddRange(itemArray2);
            this.contextMenuStrip_0.Name = "contextMenuDgv";
            this.contextMenuStrip_0.Size = new Size(190, 70);
            this.contextMenuStrip_0.Opening += new CancelEventHandler(this.contextMenuStrip_0_Opening);
            this.toolStripMenuItem_0.Image = Resources.Person;
            this.toolStripMenuItem_0.Name = "toolMenuShowAbn";
            this.toolStripMenuItem_0.Size = new Size(0xbd, 0x16);
            this.toolStripMenuItem_0.Text = "Открыть карточку";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripMenuItem_1, this.toolStripMenuItem_3 };
            this.toolStripMenuItem_2.DropDownItems.AddRange(itemArray3);
            this.toolStripMenuItem_2.Image = Resources.Scheme_Old;
            this.toolStripMenuItem_2.Name = "toolMenuSchema";
            this.toolStripMenuItem_2.Size = new Size(0xbd, 0x16);
            this.toolStripMenuItem_2.Text = "Схема";
            this.toolStripMenuItem_1.Name = "toolMenuGoToSchemaSchmObj";
            this.toolStripMenuItem_1.Size = new Size(0xc3, 0x16);
            this.toolStripMenuItem_1.Text = "Показать на схеме";
            this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
            this.toolStripMenuItem_3.Name = "toolMenuGoToSchemaSubstation";
            this.toolStripMenuItem_3.Size = new Size(0xc3, 0x16);
            this.toolStripMenuItem_3.Text = "Показать подстанцию";
            this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripMenuItem_3_Click);
            this.toolStripMenuItem_4.Name = "toolMenuItemPassportSubstation";
            this.toolStripMenuItem_4.Size = new Size(0xbd, 0x16);
            this.toolStripMenuItem_4.Text = "Паспорт подстанции";
            this.toolStripMenuItem_4.Click += new EventHandler(this.toolStripMenuItem_4_Click);
            this.dataGridViewFilterTextBoxColumn_0.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "CodeAbonent";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Код";
            this.dataGridViewFilterTextBoxColumn_0.Name = "dataGridViewFilterTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "NameAbn";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Абонент";
            this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn2";
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "TypeAbnName";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Тип абонента";
            this.dataGridViewFilterTextBoxColumn_2.Name = "dataGridViewFilterTextBoxColumn3";
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "nameAbnObj";
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn4";
            this.dataGridViewFilterTextBoxColumn_4.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "KladrObjName";
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Нас. пункт";
            this.dataGridViewFilterTextBoxColumn_4.Name = "dataGridViewFilterTextBoxColumn5";
            this.dataGridViewFilterTextBoxColumn_5.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "StreetName";
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Улица";
            this.dataGridViewFilterTextBoxColumn_5.Name = "dataGridViewFilterTextBoxColumn6";
            this.dataGridViewFilterTextBoxColumn_6.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "House";
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Дом";
            this.dataGridViewFilterTextBoxColumn_6.Name = "dataGridViewFilterTextBoxColumn7";
            this.dataGridViewFilterTextBoxColumn_7.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "SubName";
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Подстанция";
            this.dataGridViewFilterTextBoxColumn_7.Name = "dataGridViewFilterTextBoxColumn8";
            this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_7.Visible = false;
            this.dataGridViewFilterTextBoxColumn_8.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "BusName";
            this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Шина";
            this.dataGridViewFilterTextBoxColumn_8.Name = "dataGridViewFilterTextBoxColumn9";
            this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_8.Visible = false;
            this.dataGridViewFilterTextBoxColumn_9.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "CellName";
            this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Ячейка";
            this.dataGridViewFilterTextBoxColumn_9.Name = "dataGridViewFilterTextBoxColumn10";
            this.dataGridViewFilterTextBoxColumn_10.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "SchmObjName";
            this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Объект схемы";
            this.dataGridViewFilterTextBoxColumn_10.Name = "dataGridViewFilterTextBoxColumn11";
            this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "CellName";
            this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Ячейка";
            this.dataGridViewFilterTextBoxColumn_11.Name = "dataGridViewFilterTextBoxColumn12";
            this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "SchmObjName";
            this.dataGridViewFilterTextBoxColumn_12.HeaderText = "Объект схемы";
            this.dataGridViewFilterTextBoxColumn_12.Name = "dataGridViewFilterTextBoxColumn13";
            this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "idSchmObj";
            this.dataGridViewFilterTextBoxColumn_13.HeaderText = "idSchmObj";
            this.dataGridViewFilterTextBoxColumn_13.Name = "dataGridViewFilterTextBoxColumn14";
            this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_13.Visible = false;
            this.dataGridViewFilterTextBoxColumn_14.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "IdSub";
            this.dataGridViewFilterTextBoxColumn_14.HeaderText = "IdSub";
            this.dataGridViewFilterTextBoxColumn_14.Name = "dataGridViewFilterTextBoxColumn15";
            this.dataGridViewFilterTextBoxColumn_14.Visible = false;
            this.dataGridViewFilterTextBoxColumn_15.set_AllowUserVisibleColumn(false);
            this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "idAbnObj";
            this.dataGridViewFilterTextBoxColumn_15.HeaderText = "idAbnObj";
            this.dataGridViewFilterTextBoxColumn_15.Name = "dataGridViewFilterTextBoxColumn16";
            this.dataGridViewFilterTextBoxColumn_15.Visible = false;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "TypeAbn";
            this.dataGridViewTextBoxColumn_0.HeaderText = "TypeAbn";
            this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_1.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "idSchmObj";
            this.dataGridViewTextBoxColumn_2.HeaderText = "idSchmObj";
            this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_2.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x43b, 0x29c);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            base.Name = "FormJournalAbn";
            this.Text = "Журнал контрагентов";
            base.FormClosed += new FormClosedEventHandler(this.FormJournalAbn_FormClosed);
            base.Load += new EventHandler(this.FormJournalAbn_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.tabPage_1.ResumeLayout(false);
            this.groupBox_3.ResumeLayout(false);
            this.groupBox_3.PerformLayout();
            this.tabPage_2.ResumeLayout(false);
            this.groupBox_4.ResumeLayout(false);
            this.groupBox_4.PerformLayout();
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_2.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            this.contextMenuStrip_0.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_2(int int_0, List<DataRow> list_0)
        {
            DataTable table = this.method_5();
            base.SelectSqlData(table, true, " where id = " + int_0.ToString(), false);
            if (((table.Rows.Count != 0) && ((table.Rows[0]["PrimaryKey"] == DBNull.Value) || (table.Rows[0]["PrimaryKey"].ToString() != "Country"))) && (table.Rows[0]["ParentId"] != DBNull.Value))
            {
                list_0.Add(table.Rows[0]);
                this.method_2(Convert.ToInt32(table.Rows[0]["ParentId"]), list_0);
            }
        }

        private void method_3(List<DataRow> list_0)
        {
            DataTable table = this.method_5();
            switch (list_0.Count)
            {
                case 0:
                    this.comboBox_2.SelectedIndex = -1;
                    this.comboBox_2.DisplayMember = "namefull";
                    this.comboBox_2.ValueMember = "id";
                    this.comboBox_2.DataSource = table;
                    base.SelectSqlData(table, true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr", false);
                    this.comboBox_2.SelectedIndex = -1;
                    this.comboBox_2.SelectedIndex = 0;
                    return;

                case 1:
                    this.comboBox_2.SelectedIndex = -1;
                    this.comboBox_2.DisplayMember = "namefull";
                    this.comboBox_2.ValueMember = "id";
                    this.comboBox_2.DataSource = table;
                    base.SelectSqlData(table, true, " where ParentId = " + list_0[0]["ParentId"].ToString() + " and deleted = 0 order by name, socr", false);
                    this.comboBox_2.SelectedIndex = -1;
                    this.comboBox_2.SelectedValue = Convert.ToInt32(list_0[0]["Id"]);
                    return;

                case 2:
                    this.comboBox_2.SelectedIndex = -1;
                    this.comboBox_2.DisplayMember = "namefull";
                    this.comboBox_2.ValueMember = "id";
                    this.comboBox_2.DataSource = table;
                    base.SelectSqlData(table, true, " where ParentId = " + list_0[1]["ParentId"].ToString() + " and deleted = 0 order by name, socr", false);
                    this.comboBox_2.SelectedIndex = -1;
                    this.comboBox_2.SelectedValue = Convert.ToInt32(list_0[1]["Id"]);
                    this.comboBox_1.SelectedValue = Convert.ToInt32(list_0[0]["Id"]);
                    return;
            }
            this.comboBox_2.SelectedIndex = -1;
            this.comboBox_2.DisplayMember = "namefull";
            this.comboBox_2.ValueMember = "id";
            this.comboBox_2.DataSource = table;
            base.SelectSqlData(table, true, " where ParentId = " + list_0[2]["ParentId"].ToString() + " and deleted = 0 order by name, socr", false);
            this.comboBox_2.SelectedIndex = -1;
            this.comboBox_2.SelectedValue = Convert.ToInt32(list_0[2]["Id"]);
            this.comboBox_1.SelectedValue = Convert.ToInt32(list_0[1]["Id"]);
            this.comboBox_0.SelectedValue = Convert.ToInt32(list_0[0]["Id"]);
        }

        private DataTable method_4()
        {
            DataTable table1 = new DataTable("tR_Classifier");
            table1.Columns.Add("id", typeof(int));
            table1.Columns.Add("name", typeof(string));
            return table1;
        }

        private DataTable method_5()
        {
            DataTable table1 = new DataTable("tR_KladrObj");
            table1.Columns.Add("id", typeof(int));
            table1.Columns.Add("ParentId", typeof(int));
            table1.Columns.Add("name", typeof(string));
            table1.Columns.Add("socr", typeof(string));
            table1.Columns.Add("namefull", typeof(string), "name + ' ' + socr");
            table1.Columns.Add("primarykey", typeof(string));
            return table1;
        }

        private DataTable method_6()
        {
            DataTable table1 = new DataTable("tR_KladrStreet");
            table1.Columns.Add("id", typeof(int));
            table1.Columns.Add("KladrObjId", typeof(int));
            table1.Columns.Add("name", typeof(string));
            table1.Columns.Add("socr", typeof(string));
            table1.Columns.Add("namefull", typeof(string), "name + ' ' + socr");
            table1.Columns.Add("index", typeof(string));
            return table1;
        }

        private void method_7()
        {
            DataTable table = new DataTable("tR_MarkMeter");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("digit", typeof(int));
            table.Columns.Add("phaze", typeof(int));
            table.Columns.Add("voltage", typeof(int));
            table.Columns.Add("precision", typeof(decimal));
            base.SelectSqlData(table, true, " where deleted = 0 order by name, digit", false);
            this.multiColumnComboBox_0.DataSource = table;
            this.multiColumnComboBox_0.DisplayMember = "Name";
            this.multiColumnComboBox_0.ValueMember = "Id";
            this.multiColumnComboBox_0.SelectedIndex = -1;
        }

        private void method_8()
        {
            if ((!this.checkBox_4.Checked && !this.checkBox_7.Checked) && (!this.checkBox_6.Checked && !this.checkBox_5.Checked))
            {
                bool flag = false;
                this.dataGridViewFilterTextBoxColumn_25.Visible = false;
                this.dataGridViewFilterTextBoxColumn_25.set_AllowUserVisibleColumn(false);
                flag = false;
                this.dataGridViewFilterTextBoxColumn_26.Visible = false;
                this.dataGridViewFilterTextBoxColumn_26.set_AllowUserVisibleColumn(false);
                flag = false;
                this.dataGridViewFilterTextBoxColumn_27.Visible = false;
                this.dataGridViewFilterTextBoxColumn_27.set_AllowUserVisibleColumn(false);
                flag = false;
                this.dataGridViewFilterTextBoxColumn_28.Visible = false;
                this.dataGridViewFilterTextBoxColumn_28.set_AllowUserVisibleColumn(false);
                flag = false;
                this.dataGridViewFilterTextBoxColumn_29.Visible = false;
                this.dataGridViewFilterTextBoxColumn_29.set_AllowUserVisibleColumn(false);
            }
            else
            {
                if (this.checkBox_7.Checked && !this.dataGridViewFilterTextBoxColumn_25.get_AllowUserVisibleColumn())
                {
                    this.dataGridViewFilterTextBoxColumn_25.set_AllowUserVisibleColumn(true);
                    this.dataGridViewFilterTextBoxColumn_25.Visible = true;
                }
                if (this.checkBox_6.Checked && !this.dataGridViewFilterTextBoxColumn_26.get_AllowUserVisibleColumn())
                {
                    this.dataGridViewFilterTextBoxColumn_26.set_AllowUserVisibleColumn(true);
                    this.dataGridViewFilterTextBoxColumn_26.Visible = true;
                }
                if (this.checkBox_5.Checked && !this.dataGridViewFilterTextBoxColumn_27.get_AllowUserVisibleColumn())
                {
                    this.dataGridViewFilterTextBoxColumn_27.set_AllowUserVisibleColumn(true);
                    this.dataGridViewFilterTextBoxColumn_27.Visible = true;
                }
                if (this.checkBox_4.Checked && !this.dataGridViewFilterTextBoxColumn_28.get_AllowUserVisibleColumn())
                {
                    this.dataGridViewFilterTextBoxColumn_28.set_AllowUserVisibleColumn(true);
                    this.dataGridViewFilterTextBoxColumn_28.Visible = true;
                }
            }
            this.dataGridViewFilterTextBoxColumn_32.set_AllowUserVisibleColumn(this.dataGridViewFilterTextBoxColumn_32.Visible = this.checkBox_9.Checked);
            this.dataGridViewFilterTextBoxColumn_33.set_AllowUserVisibleColumn(this.dataGridViewFilterTextBoxColumn_33.Visible = this.checkBox_8.Checked);
        }

        private string method_9()
        {
            string[] textArray1 = new string[] { "with ActiveObj (idAbnObj,isActive) as\r\n                                        (select  abnObjDog.id,1 from  tAbnDoc_List lst \r\n\t\t\t\t\t\t                        inner JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id \r\n\t\t\t\t\t                            inner JOIN tG_Dog_Obj obj ON obj.idDog = dog.id\r\n\t\t\t\t\t\t                        inner JOIN tAbnObj AS abnobjDog ON abnobjDog.id = obj.idObj \r\n\t\t\t\t                         where  lst.deleted = 0 and lst.isActive <> 0 and dog.FlagBreak = 0 and obj.dateEnd is null\r\n\t\t\t\t                         group by abnObjDog.id) ", this.method_11(), " select a.idAbn, a.codeAbonent, a.name as nameAbn, a.typeAbn, \r\n\t                                 a.TypeAbnName, a.deleted as deletedAbn, a.isActive as activeAbn,\r\n                                     a.id as idAbnObj, a.nameObj as nameAbnObj, a.KladrObjName, a.streetname,\r\n                                     cast(a.house as varchar(10)) + isnull(a.houseprefix, '') as house,\r\n                                     case when a.TypeAbn in (207,230,231) then isnull(ActiveObj.isActive, 0) else 1 end as objActive ", this.method_10(), " from vAbnObj a \r\n                                   left join ActiveObj on ActiveObj.idAbnObj = a.id ", this.method_12() };
            return (string.Concat(textArray1) + "\r\n" + this.method_13());
        }

        private void multiColumnComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.multiColumnComboBox_0.SelectedIndex < 0)
            {
                this.checkBox_9.Checked = false;
            }
            else
            {
                this.checkBox_9.Checked = true;
            }
        }

        private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.tabControl_0.SelectedTab == this.tabPage_1) && (this.multiColumnComboBox_0.Items.Count == 0))
            {
                this.method_7();
            }
        }

        private void textBox_5_TextChanged(object sender, EventArgs e)
        {
            this.checkBox_8.Checked = !string.IsNullOrEmpty(this.textBox_5.Text);
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(1, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(3, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(2, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.ExportToExcel();
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            FormAbn abn;
            FormAbonent abonent;
            int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_23.Name].Value);
            if (num <= 0xcf)
            {
                if (num == 0xce)
                {
                    goto Label_0066;
                }
                if (num != 0xcf)
                {
                    return;
                }
                goto Label_00FF;
            }
            switch (num)
            {
                case 230:
                case 0xe7:
                    goto Label_00FF;

                case 0xfd:
                    break;

                default:
                    return;
            }
        Label_0066:
            abonent = new FormAbonent(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_16.Name].Value), Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_23.Name].Value));
            abonent.set_SqlSettings(this.get_SqlSettings());
            if (base.get_DockPanel() == null)
            {
                abonent.MdiParent = base.MdiParent;
            }
            else
            {
                abonent.MdiParent = base.get_DockPanel().FindForm().MdiParent;
            }
            abonent.Show();
            return;
        Label_00FF:
            abn = new FormAbn(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_16.Name].Value), Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_31.Name].Value));
            abn.set_SqlSettings(this.get_SqlSettings());
            if (base.get_DockPanel() == null)
            {
                abn.MdiParent = base.MdiParent;
            }
            else
            {
                abn.MdiParent = base.get_DockPanel().FindForm().MdiParent;
            }
            abn.Show();
        }

        private void toolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            if ((sender is ToolStripMenuItem) && (((ToolStripMenuItem) sender).Tag != null))
            {
                this.OnGoToSchema(new GoToSchemaEventArgs(Convert.ToInt32(((ToolStripMenuItem) sender).Tag)));
            }
        }

        private void toolStripMenuItem_3_Click(object sender, EventArgs e)
        {
            if ((sender is ToolStripMenuItem) && (((ToolStripMenuItem) sender).Tag != null))
            {
                this.OnGoToSchema(new GoToSchemaEventArgs(Convert.ToInt32(((ToolStripMenuItem) sender).Tag)));
            }
        }

        private void toolStripMenuItem_4_Click(object sender, EventArgs e)
        {
            FormDockPassport passport = new FormDockPassport(this.get_SqlSettings(), Convert.ToInt32(((ToolStripMenuItem) sender).Tag));
            if (base.get_DockPanel() == null)
            {
                passport.MdiParent = base.MdiParent;
                passport.Show();
            }
            else
            {
                passport.Show(base.get_DockPanel());
            }
        }

        private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Modifiers == Keys.None)
                {
                    this.dataGridViewExcelFilter_0.SearchGrid(2, this.toolStripTextBox_0.Text);
                }
                if (e.Modifiers == Keys.Shift)
                {
                    this.dataGridViewExcelFilter_0.SearchGrid(3, this.toolStripTextBox_0.Text);
                }
            }
        }
    }
}

