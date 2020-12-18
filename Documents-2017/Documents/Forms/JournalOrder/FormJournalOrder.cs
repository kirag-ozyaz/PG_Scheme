namespace Documents.Forms.JournalOrder
{
    using ControlsLbr.DataGridViewExcelFilter;
    using ControlsLbr.Scheme;
    using Documents.DataSets;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;
    using System.Xml;

    public class FormJournalOrder : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private CheckBox checkBox_0;
        private CheckBox checkBox_1;
        private CheckBox checkBox_2;
        private CheckBox checkBox_3;
        private CheckBox checkBox_4;
        private CheckedListBox checkedListBox_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
        private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_0;
        private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_0;
        private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_1;
        private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_2;
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
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataSetOrder dataSetOrder_0;
        private DateTime dateTime_0;
        private DateTime dateTime_1;
        private DateTime dateTime_2;
        private DateTime dateTime_3;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private IContainer icontainer_0;
        private ItemCheckEventArgs itemCheckEventArgs_0;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private List<int> list_0;
        private List<int> list_1;
        private List<int> list_2;
        private List<int> list_3;
        private Panel panel_0;
        private Panel panel_1;
        private Panel panel_2;
        private SplitContainer splitContainer_0;
        private SplitContainer splitContainer_1;
        private TabControl tabControl_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_10;
        private ToolStripButton toolStripButton_11;
        private ToolStripButton toolStripButton_12;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripButton toolStripButton_8;
        private ToolStripButton toolStripButton_9;
        private ToolStripDropDownButton toolStripDropDownButton_0;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripTextBox toolStripTextBox_0;
        private TreeViewSchmObjects treeViewSchmObjects_0;

        public FormJournalOrder()
        {
            this.dateTime_0 = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTime_1 = new DateTime(DateTime.Now.Year, 12, 0x1f);
            this.dateTime_2 = DateTime.Now.Date;
            this.dateTime_3 = DateTime.Now.Date;
            this.list_1 = new List<int>();
            this.list_2 = new List<int>();
            this.list_3 = new List<int>();
            this.method_9();
        }

        public FormJournalOrder(List<int> checkedSubstation)
        {
            this.dateTime_0 = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTime_1 = new DateTime(DateTime.Now.Year, 12, 0x1f);
            this.dateTime_2 = DateTime.Now.Date;
            this.dateTime_3 = DateTime.Now.Date;
            this.list_1 = new List<int>();
            this.list_2 = new List<int>();
            this.list_3 = new List<int>();
            this.method_9();
            this.list_0 = checkedSubstation;
        }

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            this.list_3 = new List<int>();
            XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
            if (node != null)
            {
                using (IEnumerator enumerator = node.SelectNodes("CheckDivision").GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        XmlAttribute attribute = ((XmlNode) enumerator.Current).Attributes["Id"];
                        if (attribute != null)
                        {
                            this.list_3.Add(Convert.ToInt32(attribute.Value));
                        }
                    }
                }
            }
        }

        private void checkBox_3_CheckedChanged(object sender, EventArgs e)
        {
            this.method_1();
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document = new XmlDocument();
            XmlNode newChild = document.CreateXmlDeclaration("1.0", "UTF-8", null);
            document.AppendChild(newChild);
            XmlNode node2 = document.CreateElement(base.Name);
            document.AppendChild(node2);
            foreach (object obj2 in this.checkedListBox_0.CheckedItems)
            {
                XmlNode node3 = document.CreateElement("CheckDivision");
                XmlAttribute node = document.CreateAttribute("Id");
                node.Value = ((Class295) obj2).Id.ToString();
                node3.Attributes.Append(node);
                node2.AppendChild(node3);
            }
            return document;
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
            {
                this.toolStripButton_1_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewFilterCheckBoxColumn_0.Name, e.RowIndex].Value))
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                if (this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_30.Name, e.RowIndex].Value != DBNull.Value)
                {
                    e.CellStyle.BackColor = Color.Gray;
                }
                else
                {
                    if (this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_31.Name, e.RowIndex].Value != DBNull.Value)
                    {
                        e.CellStyle.BackColor = Color.LawnGreen;
                    }
                    if ((this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_32.Name, e.RowIndex].Value != DBNull.Value) && (this.dataGridViewExcelFilter_0.Columns[e.ColumnIndex] == this.dataGridViewFilterTextBoxColumn_9))
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void dataGridViewExcelFilter_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
            {
                this.toolStripButton_1_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.RowIndex >= 0) && (Convert.ToInt32(this.dataGridViewExcelFilter_1[this.dataGridViewTextBoxColumn_35.Name, e.RowIndex].Value) == 1))
            {
                e.CellStyle.BackColor = Color.Gray;
            }
        }

        private void dateTimePicker_0_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker_1.MaxDate = this.dateTimePicker_0.Value;
        }

        private void dateTimePicker_1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker_0.MinDate = this.dateTimePicker_1.Value;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormJournalOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormJournalOrder_Load(object sender, EventArgs e)
        {
            base.LoadFormConfig(null);
            this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker_0.Value = new DateTime(DateTime.Now.Year, 12, 0x1f);
            this.method_0();
            this.treeViewSchmObjects_0.set_SqlSettings(this.get_SqlSettings());
            this.treeViewSchmObjects_0.Load(this.list_0);
            this.method_1();
            this.method_2();
        }

        private void method_0()
        {
            DataTable table = new DataTable("tR_Classifier");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            base.SelectSqlData(table, true, " where ((ParentKey = ';Other;DivisionOrder;' and isGRoup = 0)\r\n                                            or (ParentKey like ';Other;DivisionOrder;%;' and isGRoup = 1)) and deleted = 0 ", false);
            if (table.Rows.Count == 0)
            {
                this.toolStripDropDownButton_0.Visible = false;
                this.splitContainer_1.Panel2Collapsed = true;
            }
            else
            {
                this.toolStripButton_0.Visible = false;
                foreach (DataRow row in table.Rows)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.Click += new EventHandler(this.method_3);
                    item.Text = row["Name"].ToString();
                    item.Tag = row["id"];
                    this.toolStripDropDownButton_0.DropDownItems.Add(item);
                    bool isChecked = false;
                    if ((this.list_3 != null) && (this.list_3.Count != 0))
                    {
                        if (this.list_3.Contains(Convert.ToInt32(row["id"])))
                        {
                            isChecked = true;
                        }
                    }
                    else
                    {
                        isChecked = true;
                    }
                    this.checkedListBox_0.Items.Add(new Class295(Convert.ToInt32(row["id"]), row["Name"].ToString()), isChecked);
                }
            }
        }

        private void method_1()
        {
            this.Cursor = Cursors.WaitCursor;
            this.panel_0.Enabled = false;
            this.panel_1.Enabled = false;
            string str = "";
            int num = -1;
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_33.Name].Value);
            }
            string[] textArray1 = new string[] { " (datebegin >= '", this.dateTime_0.ToString("yyyyMMdd"), "' and datebegin <= '", this.dateTime_1.ToString("yyyyMMdd"), " 23:59:59') " };
            str = string.Concat(textArray1);
            string str2 = "";
            if ((!this.checkBox_3.Checked && !this.checkBox_2.Checked) && (!this.checkBox_1.Checked && !this.checkBox_0.Checked))
            {
                str2 = " id < 0 ";
            }
            else
            {
                if (this.checkBox_3.Checked)
                {
                    str2 = " (registered = 0)";
                }
                if (this.checkBox_2.Checked)
                {
                    if (string.IsNullOrEmpty(str2))
                    {
                        str2 = " (registered <> 0 and beginRes is null and dateclose is null) ";
                    }
                    else
                    {
                        str2 = str2 + " or (registered <> 0 and beginRes is null and dateclose is null) ";
                    }
                }
                if (this.checkBox_1.Checked)
                {
                    if (string.IsNullOrEmpty(str2))
                    {
                        str2 = " (beginRes is not null and dateClose is null) ";
                    }
                    else
                    {
                        str2 = str2 + " or (beginRes is not null and dateClose is null) ";
                    }
                }
                if (this.checkBox_0.Checked)
                {
                    if (string.IsNullOrEmpty(str2))
                    {
                        str2 = " (dateclose is not null) ";
                    }
                    else
                    {
                        str2 = str2 + " or (dateclose is not null)";
                    }
                }
            }
            if ((this.checkedListBox_0.CheckedItems.Count > 0) && (this.checkedListBox_0.CheckedItems.Count < this.checkedListBox_0.Items.Count))
            {
                string str3 = "";
                foreach (object obj2 in this.checkedListBox_0.CheckedItems)
                {
                    if (string.IsNullOrEmpty(str3))
                    {
                        str3 = ((Class295) obj2).Id.ToString();
                    }
                    else
                    {
                        str3 = str3 + "," + ((Class295) obj2).Id.ToString();
                    }
                }
                if (string.IsNullOrEmpty(str2))
                {
                    str2 = string.Format(" (idDivision in ({0})) ", str3);
                }
                else
                {
                    str2 = string.Format("({1}) and (idDivision in ({0})) ", str3, str2);
                }
            }
            if (string.IsNullOrEmpty(str2))
            {
                if (!string.IsNullOrEmpty(str))
                {
                    str2 = str;
                }
            }
            else if (!string.IsNullOrEmpty(str))
            {
                string[] textArray2 = new string[] { "(", str, ") and (", str2, ")" };
                str2 = string.Concat(textArray2);
            }
            this.list_1 = this.treeViewSchmObjects_0.GetListChecked();
            string str4 = "";
            if (this.list_1.Count > 0)
            {
                foreach (int num3 in this.list_1)
                {
                    str4 = str4 + num3.ToString() + ",";
                }
                str4 = str4.Remove(str4.Length - 1);
            }
            if (string.IsNullOrEmpty(str4))
            {
                str2 = " where " + str2;
                base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.vJ_Order, true, str2 + " order by num");
            }
            else
            {
                if (this.checkBox_4.Checked)
                {
                    string cmdText = string.Format("with sub (Id, FullName) AS\r\n                                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text]\r\n                                                    FROM tSchm_ObjList AS o\r\n                                                    LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id\r\n                                                    WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))),\r\n                                                    bus (Id, busName, subid, subname) AS\r\n                                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name\r\n                                                    FROM tSchm_ObjList AS o \r\n                                                    JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id\r\n                                                    join tSChm_ObjList sub on sub.id = o.idParent\r\n                                                    join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id\r\n                                                    WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))),\r\n                                                    \r\n                                                    cell\t(cellId, cellName, busId, busName, subId, subName) AS\r\n                                                    (SELECT  cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], \r\n                                                    \t\t bus.id,  ISNULL(cBus.SocrName + '-', '') + bus.Name [Text],\r\n                                                    \t\t sub.id,  ISNULL(cSub.SocrName + '-', '') + sub.Name [Text]\r\n                                                    FROM tSchm_ObjList AS bus\r\n                                                    JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%'\r\n                                                    JOIN tSchm_ObjList AS point ON bus.id = point.IdParent\r\n                                                    JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj\r\n                                                    JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id\r\n                                                    JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%'\r\n                                                    join tschm_objlist as sub on sub.id = bus.idparent\r\n                                                    JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id \r\n                                                    WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))\r\n                                                    \r\n                                                    select distinct vj_order.*  from vj_order\r\n                                                    \tinner join tL_OrderSchmObjList l on l.idOrder = vj_Order.id\r\n                                                    \tleft join cell on cell.cellid = l.idSchmObj\r\n                                                    \tleft join bus on bus.id = l.idSchmObj\r\n                                                    \tleft join sub on sub.id = l.idSchmObj\r\n                                                    where (l.idschmObj in ({0}) or isnull(cell.subId, ISNULL(bus.subid, sub.id)) in ({0}))\r\n                                                    and {1} ", str4, str2);
                    SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString());
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(cmdText, connection))
                        {
                            SqlDataAdapter adapter1 = new SqlDataAdapter {
                                SelectCommand = command
                            };
                            this.dataSetOrder_0.vJ_Order.Clear();
                            adapter1.Fill(this.dataSetOrder_0.vJ_Order);
                        }
                        goto Label_0444;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Source);
                        goto Label_0444;
                    }
                    finally
                    {
                        if (connection != null)
                        {
                            connection.Dispose();
                        }
                    }
                }
                base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.vJ_Order, true, (" inner join tL_OrderSchmObjList l on l.idOrder = vj_Order.id and l.idSchmObj in (" + str4 + ") where " + str2) + " order by num");
            }
        Label_0444:
            if (num > 0)
            {
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_33.Name, num.ToString(), false);
            }
            this.panel_0.Enabled = true;
            this.panel_1.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void method_2()
        {
            string[] textArray1 = new string[] { " (EvntDate >= '", this.dateTime_2.ToString("yyyyMMdd"), "' and EvntDate <= '", this.dateTime_3.ToString("yyyyMMdd"), " 23:59:59') " };
            string str = string.Concat(textArray1);
            if ((this.checkedListBox_0.CheckedItems.Count > 0) && (this.checkedListBox_0.CheckedItems.Count < this.checkedListBox_0.Items.Count))
            {
                string str3 = "";
                foreach (object obj2 in this.checkedListBox_0.CheckedItems)
                {
                    if (string.IsNullOrEmpty(str3))
                    {
                        str3 = ((Class295) obj2).Id.ToString();
                    }
                    else
                    {
                        str3 = str3 + "," + ((Class295) obj2).Id.ToString();
                    }
                }
                if (string.IsNullOrEmpty(str))
                {
                    str = string.Format(" (idDivision in ({0})) ", str3);
                }
                else
                {
                    str = string.Format("({1}) and (idDivision in ({0})) ", str3, str);
                }
            }
            this.list_2 = this.treeViewSchmObjects_0.GetListChecked();
            string str2 = "";
            if (this.list_2.Count > 0)
            {
                foreach (int num2 in this.list_2)
                {
                    str2 = str2 + num2.ToString() + ",";
                }
                str2 = str2.Remove(str2.Length - 1);
            }
            if (string.IsNullOrEmpty(str2))
            {
                str = " where " + str;
                base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.vJ_OrderEvents, true, str + " order by num");
            }
            else
            {
                if (this.checkBox_4.Checked)
                {
                    string cmdText = string.Format("with sub (Id, FullName) AS\r\n                                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text]\r\n                                                    FROM tSchm_ObjList AS o\r\n                                                    LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id\r\n                                                    WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))),\r\n                                                    bus (Id, busName, subid, subname) AS\r\n                                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name\r\n                                                    FROM tSchm_ObjList AS o \r\n                                                    JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id\r\n                                                    join tSChm_ObjList sub on sub.id = o.idParent\r\n                                                    join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id\r\n                                                    WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))),\r\n                                                    \r\n                                                    cell\t(cellId, cellName, busId, busName, subId, subName) AS\r\n                                                    (SELECT  cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], \r\n                                                    \t\t bus.id,  ISNULL(cBus.SocrName + '-', '') + bus.Name [Text],\r\n                                                    \t\t sub.id,  ISNULL(cSub.SocrName + '-', '') + sub.Name [Text]\r\n                                                    FROM tSchm_ObjList AS bus\r\n                                                    JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%'\r\n                                                    JOIN tSchm_ObjList AS point ON bus.id = point.IdParent\r\n                                                    JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj\r\n                                                    JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id\r\n                                                    JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%'\r\n                                                    join tschm_objlist as sub on sub.id = bus.idparent\r\n                                                    JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id \r\n                                                    WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))\r\n                                                    \r\n                                                    select distinct vj_orderEvents.*  from vj_orderEvents\r\n                                                    \tinner join tL_OrderSchmObjList l on l.idOrder = vj_orderEvents.id\r\n                                                    \tleft join cell on cell.cellid = l.idSchmObj\r\n                                                    \tleft join bus on bus.id = l.idSchmObj\r\n                                                    \tleft join sub on sub.id = l.idSchmObj\r\n                                                    where (l.idschmObj in ({0}) or isnull(cell.subId, ISNULL(bus.subid, sub.id)) in ({0}))\r\n                                                    and {1} ", str2, str);
                    SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString());
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(cmdText, connection))
                        {
                            SqlDataAdapter adapter1 = new SqlDataAdapter {
                                SelectCommand = command
                            };
                            this.dataSetOrder_0.vJ_OrderEvents.Clear();
                            adapter1.Fill(this.dataSetOrder_0.vJ_OrderEvents);
                        }
                        return;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Source);
                        return;
                    }
                    finally
                    {
                        if (connection != null)
                        {
                            connection.Dispose();
                        }
                    }
                }
                base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.vJ_OrderEvents, true, (" inner join tL_OrderSchmObjList l on l.idOrder = vj_OrderEvents.id and l.idSchmObj in (" + str2 + ") where " + str) + " order by num");
            }
        }

        private void method_3(object sender, EventArgs e)
        {
            Form19 form1 = new Form19();
            form1.method_1(new int?(Convert.ToInt32(((ToolStripMenuItem) sender).Tag)));
            form1.add_GoToSchema(new GoToSchemaEventHandler(this, (IntPtr) this.method_4));
            form1.set_SqlSettings(this.get_SqlSettings());
            form1.FormClosed += new FormClosedEventHandler(this.method_5);
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }

        private void method_4(object sender, GoToSchemaEventArgs e)
        {
            this.OnGoToSchema(e);
        }

        private void method_5(object sender, FormClosedEventArgs e)
        {
            this.method_1();
            this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_33.Name, ((Form19) sender).method_2().ToString(), false);
            this.method_2();
            this.dataGridViewExcelFilter_1.SearchGrid(this.dataGridViewTextBoxColumn_36.Name, ((Form19) sender).method_2().ToString(), false);
        }

        private void method_6(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void method_7(object sender, ItemCheckEventArgs e)
        {
            this.itemCheckEventArgs_0 = e;
            this.method_1();
        }

        private void method_8(TreeNode treeNode_0, List<int> list_4)
        {
            if ((treeNode_0.Level > 0) && list_4.Contains(Convert.ToInt32(treeNode_0.Tag)))
            {
                treeNode_0.Checked = true;
            }
            foreach (TreeNode node in treeNode_0.Nodes)
            {
                this.method_8(node, list_4);
            }
        }

        private void method_9()
        {
            this.icontainer_0 = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormJournalOrder));
            DataGridViewCellStyle style7 = new DataGridViewCellStyle();
            DataGridViewCellStyle style8 = new DataGridViewCellStyle();
            DataGridViewCellStyle style9 = new DataGridViewCellStyle();
            DataGridViewCellStyle style10 = new DataGridViewCellStyle();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterDateTimePickerColumn_0 = new DataGridViewFilterDateTimePickerColumn();
            this.dataGridViewFilterDateTimePickerColumn_1 = new DataGridViewFilterDateTimePickerColumn();
            this.dataGridViewFilterDateTimePickerColumn_2 = new DataGridViewFilterDateTimePickerColumn();
            this.dataGridViewFilterCheckBoxColumn_0 = new DataGridViewFilterCheckBoxColumn();
            this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetOrder_0 = new DataSetOrder();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_7 = new ToolStripButton();
            this.panel_0 = new Panel();
            this.checkBox_0 = new CheckBox();
            this.checkBox_1 = new CheckBox();
            this.checkBox_2 = new CheckBox();
            this.checkBox_3 = new CheckBox();
            this.panel_1 = new Panel();
            this.panel_2 = new Panel();
            this.splitContainer_1 = new SplitContainer();
            this.checkBox_4 = new CheckBox();
            this.treeViewSchmObjects_0 = new TreeViewSchmObjects();
            this.checkedListBox_0 = new CheckedListBox();
            this.label_2 = new Label();
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_8 = new ToolStripButton();
            this.toolStripButton_9 = new ToolStripButton();
            this.toolStripButton_10 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_11 = new ToolStripButton();
            this.toolStripButton_12 = new ToolStripButton();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_0 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.label_1 = new Label();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.tabPage_1 = new TabPage();
            this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewFilterTextBoxColumn_18 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_19 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_20 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_21 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_22 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_23 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_24 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.splitContainer_0 = new SplitContainer();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetOrder_0.BeginInit();
            this.toolStrip_0.SuspendLayout();
            this.panel_0.SuspendLayout();
            this.panel_1.SuspendLayout();
            this.panel_2.SuspendLayout();
            this.splitContainer_1.Panel1.SuspendLayout();
            this.splitContainer_1.Panel2.SuspendLayout();
            this.splitContainer_1.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.dataGridViewExcelFilter_1.BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            base.SuspendLayout();
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = style;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewFilterTextBoxColumn_9, this.dataGridViewFilterTextBoxColumn_10, this.dataGridViewFilterDateTimePickerColumn_0, this.dataGridViewFilterDateTimePickerColumn_1, this.dataGridViewFilterDateTimePickerColumn_2, this.dataGridViewFilterCheckBoxColumn_0, this.dataGridViewTextBoxColumn_26, this.dataGridViewFilterTextBoxColumn_11, this.dataGridViewTextBoxColumn_27, this.dataGridViewFilterTextBoxColumn_12, this.dataGridViewFilterTextBoxColumn_13, this.dataGridViewFilterTextBoxColumn_14, this.dataGridViewFilterTextBoxColumn_15, this.dataGridViewTextBoxColumn_28, this.dataGridViewTextBoxColumn_29, this.dataGridViewFilterTextBoxColumn_16,
                this.dataGridViewTextBoxColumn_30, this.dataGridViewFilterTextBoxColumn_17, this.dataGridViewTextBoxColumn_31, this.dataGridViewTextBoxColumn_32, this.dataGridViewTextBoxColumn_33
            };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(4, 0x3a);
            this.dataGridViewExcelFilter_0.Margin = new Padding(4, 4, 4, 4);
            this.dataGridViewExcelFilter_0.Name = "dgvOrder";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_0.RowTemplate.Height = 0x2c;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x3fd, 0x260);
            this.dataGridViewExcelFilter_0.TabIndex = 0;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "num";
            this.dataGridViewFilterTextBoxColumn_9.HeaderText = "№";
            this.dataGridViewFilterTextBoxColumn_9.Name = "numDgvColumn";
            this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_9.Width = 50;
            this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "srNum";
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewFilterTextBoxColumn_10.DefaultCellStyle = style2;
            this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Сетевой район";
            this.dataGridViewFilterTextBoxColumn_10.Name = "srNumDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_10.Width = 80;
            this.dataGridViewFilterDateTimePickerColumn_0.DataPropertyName = "dateOutput";
            style3.Format = "dd.MM.yyyy HH:mm:ss";
            this.dataGridViewFilterDateTimePickerColumn_0.DefaultCellStyle = style3;
            this.dataGridViewFilterDateTimePickerColumn_0.HeaderText = "Дата выдачи наряда";
            this.dataGridViewFilterDateTimePickerColumn_0.Name = "dateOutputDataGridViewTextBoxColumn";
            this.dataGridViewFilterDateTimePickerColumn_0.ReadOnly = true;
            this.dataGridViewFilterDateTimePickerColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewFilterDateTimePickerColumn_0.Width = 0x7d;
            this.dataGridViewFilterDateTimePickerColumn_1.DataPropertyName = "dateBegin";
            this.dataGridViewFilterDateTimePickerColumn_1.HeaderText = "Дата начала работ";
            this.dataGridViewFilterDateTimePickerColumn_1.Name = "dateBeginDataGridViewTextBoxColumn";
            this.dataGridViewFilterDateTimePickerColumn_1.ReadOnly = true;
            this.dataGridViewFilterDateTimePickerColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterDateTimePickerColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewFilterDateTimePickerColumn_1.Width = 80;
            this.dataGridViewFilterDateTimePickerColumn_2.DataPropertyName = "dateEnd";
            this.dataGridViewFilterDateTimePickerColumn_2.HeaderText = "Дата окончания работ";
            this.dataGridViewFilterDateTimePickerColumn_2.Name = "dateEndDataGridViewTextBoxColumn";
            this.dataGridViewFilterDateTimePickerColumn_2.ReadOnly = true;
            this.dataGridViewFilterDateTimePickerColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterDateTimePickerColumn_2.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewFilterDateTimePickerColumn_2.Width = 80;
            this.dataGridViewFilterCheckBoxColumn_0.DataPropertyName = "registered";
            this.dataGridViewFilterCheckBoxColumn_0.HeaderText = "Зарегистрирован";
            this.dataGridViewFilterCheckBoxColumn_0.Name = "registeredDgvColumn";
            this.dataGridViewFilterCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterCheckBoxColumn_0.set_SortMode(DataGridViewColumnSortMode.NotSortable);
            this.dataGridViewFilterCheckBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_26.DataPropertyName = "OutputMaker";
            style4.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_26.DefaultCellStyle = style4;
            this.dataGridViewTextBoxColumn_26.HeaderText = "Наряд выдал Производитель работ";
            this.dataGridViewTextBoxColumn_26.Name = "outputMakerDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_26.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "instruction";
            style5.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_11.DefaultCellStyle = style5;
            this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Содержание работ";
            this.dataGridViewFilterTextBoxColumn_11.Name = "instructionDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_27.DataPropertyName = "Resolution";
            style6.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_27.DefaultCellStyle = style6;
            this.dataGridViewTextBoxColumn_27.HeaderText = "Разрешение выдал";
            this.dataGridViewTextBoxColumn_27.Name = "resolutionDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_27.ReadOnly = true;
            this.dataGridViewTextBoxColumn_27.Width = 120;
            this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "srName";
            this.dataGridViewFilterTextBoxColumn_12.HeaderText = "Сетевой район (имя)";
            this.dataGridViewFilterTextBoxColumn_12.Name = "srNameDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_12.Visible = false;
            this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "headFio";
            this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Руководитель работ";
            this.dataGridViewFilterTextBoxColumn_13.Name = "headFioDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_13.Visible = false;
            this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "acceptFIO";
            this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Допускайщий";
            this.dataGridViewFilterTextBoxColumn_14.Name = "acceptFIODataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_14.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_14.Visible = false;
            this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "watchFIO";
            this.dataGridViewFilterTextBoxColumn_15.HeaderText = "Наблюдающий";
            this.dataGridViewFilterTextBoxColumn_15.Name = "watchFIODataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_15.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_15.Visible = false;
            this.dataGridViewTextBoxColumn_28.DataPropertyName = "makerFIO";
            this.dataGridViewTextBoxColumn_28.HeaderText = "Произовдитель работ";
            this.dataGridViewTextBoxColumn_28.Name = "makerFIODataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_28.ReadOnly = true;
            this.dataGridViewTextBoxColumn_28.Visible = false;
            this.dataGridViewTextBoxColumn_29.DataPropertyName = "otherInstruction";
            this.dataGridViewTextBoxColumn_29.HeaderText = "Отдельные указания";
            this.dataGridViewTextBoxColumn_29.Name = "otherInstructionDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_29.ReadOnly = true;
            this.dataGridViewTextBoxColumn_29.Visible = false;
            this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "outputFIO";
            this.dataGridViewFilterTextBoxColumn_16.HeaderText = "Наряд выдал";
            this.dataGridViewFilterTextBoxColumn_16.Name = "outputFIODataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_16.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_16.Visible = false;
            this.dataGridViewTextBoxColumn_30.DataPropertyName = "dateClose";
            this.dataGridViewTextBoxColumn_30.HeaderText = "Дата закрытия";
            this.dataGridViewTextBoxColumn_30.Name = "dateCloseDgvColumn";
            this.dataGridViewTextBoxColumn_30.ReadOnly = true;
            this.dataGridViewTextBoxColumn_30.Visible = false;
            this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "closeFIO";
            this.dataGridViewFilterTextBoxColumn_17.HeaderText = "Закрыл наряд";
            this.dataGridViewFilterTextBoxColumn_17.Name = "closeFIODataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_17.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_17.Visible = false;
            this.dataGridViewTextBoxColumn_31.DataPropertyName = "beginRes";
            this.dataGridViewTextBoxColumn_31.HeaderText = "beginRes";
            this.dataGridViewTextBoxColumn_31.Name = "beginResDgvColumn";
            this.dataGridViewTextBoxColumn_31.ReadOnly = true;
            this.dataGridViewTextBoxColumn_31.Visible = false;
            this.dataGridViewTextBoxColumn_32.DataPropertyName = "EndRes";
            this.dataGridViewTextBoxColumn_32.HeaderText = "EndRes";
            this.dataGridViewTextBoxColumn_32.Name = "EndResDgvColumn";
            this.dataGridViewTextBoxColumn_32.ReadOnly = true;
            this.dataGridViewTextBoxColumn_32.Visible = false;
            this.dataGridViewTextBoxColumn_33.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_33.HeaderText = "id";
            this.dataGridViewTextBoxColumn_33.Name = "idDgvColumn";
            this.dataGridViewTextBoxColumn_33.ReadOnly = true;
            this.dataGridViewTextBoxColumn_33.Visible = false;
            this.bindingSource_0.DataMember = "vJ_Order";
            this.bindingSource_0.DataSource = this.dataSetOrder_0;
            this.dataSetOrder_0.DataSetName = "DataSetOrder";
            this.dataSetOrder_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripDropDownButton_0, this.toolStripButton_1, this.toolStripButton_5, this.toolStripButton_2, this.toolStripSeparator_1, this.toolStripButton_6, this.toolStripSeparator_0, this.toolStripButton_3, this.toolStripButton_4, this.toolStripSeparator_2, this.toolStripButton_7 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStripOrder";
            this.toolStrip_0.Size = new Size(0x4c8, 0x19);
            this.toolStrip_0.TabIndex = 2;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.ElementAdd;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnAddOrder";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Создать наряд";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton_0.Image = Resources.ElementAdd;
            this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripDropDownButton_0.Name = "toolBtnAddOrderDivision";
            this.toolStripDropDownButton_0.Size = new Size(0x1d, 0x16);
            this.toolStripDropDownButton_0.Text = "Создать наряд";
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementEdit;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnEditOrder";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Редактировать";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.ElementInformation1;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnReadOrder";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Просмотр наряда";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementDel;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnDelOrder";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить наряд(ы)";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.refresh_16;
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "toolBtnRefresh";
            this.toolStripButton_6.Size = new Size(0x17, 0x16);
            this.toolStripButton_6.Text = "Обновить";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = (Image) manager.GetObject("toolBtnReport.Image");
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnReport";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "toolStripButton1";
            this.toolStripButton_3.Visible = false;
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.microsoftoffice2007excel_7581;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnReportExcel";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Печать наряда";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator3";
            this.toolStripSeparator_2.Size = new Size(6, 0x19);
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = Resources.Orderclose;
            this.toolStripButton_7.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_7.Name = "toolBtnOrderClose";
            this.toolStripButton_7.Size = new Size(0x17, 0x16);
            this.toolStripButton_7.Text = "Закрыть наряды";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
            this.panel_0.Controls.Add(this.checkBox_0);
            this.panel_0.Controls.Add(this.checkBox_1);
            this.panel_0.Controls.Add(this.checkBox_2);
            this.panel_0.Controls.Add(this.checkBox_3);
            this.panel_0.Dock = DockStyle.Top;
            this.panel_0.Location = new Point(4, 4);
            this.panel_0.Margin = new Padding(4, 4, 4, 4);
            this.panel_0.Name = "panelFilter";
            this.panel_0.Size = new Size(0x3fd, 0x36);
            this.panel_0.TabIndex = 3;
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.BackColor = Color.Gray;
            this.checkBox_0.Checked = true;
            this.checkBox_0.CheckState = CheckState.Checked;
            this.checkBox_0.Location = new Point(0x224, 11);
            this.checkBox_0.Margin = new Padding(4, 4, 4, 4);
            this.checkBox_0.Name = "checkBoxCloseOrder";
            this.checkBox_0.Size = new Size(0x61, 0x15);
            this.checkBox_0.TabIndex = 3;
            this.checkBox_0.Text = "Закрытые";
            this.checkBox_0.UseVisualStyleBackColor = false;
            this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_3_CheckedChanged);
            this.checkBox_1.AutoSize = true;
            this.checkBox_1.BackColor = Color.LawnGreen;
            this.checkBox_1.Checked = true;
            this.checkBox_1.CheckState = CheckState.Checked;
            this.checkBox_1.Location = new Point(0x199, 11);
            this.checkBox_1.Margin = new Padding(4, 4, 4, 4);
            this.checkBox_1.Name = "checkBoxCurrentOrder";
            this.checkBox_1.Size = new Size(0x7a, 0x15);
            this.checkBox_1.TabIndex = 2;
            this.checkBox_1.Text = "Действующие";
            this.checkBox_1.UseVisualStyleBackColor = false;
            this.checkBox_1.CheckedChanged += new EventHandler(this.checkBox_3_CheckedChanged);
            this.checkBox_2.AutoSize = true;
            this.checkBox_2.BackColor = Color.White;
            this.checkBox_2.Checked = true;
            this.checkBox_2.CheckState = CheckState.Checked;
            this.checkBox_2.Location = new Point(0xdd, 11);
            this.checkBox_2.Margin = new Padding(4, 4, 4, 4);
            this.checkBox_2.Name = "checkBoxRegistered";
            this.checkBox_2.Size = new Size(0xab, 0x15);
            this.checkBox_2.TabIndex = 1;
            this.checkBox_2.Text = "Зарегистрированные";
            this.checkBox_2.UseVisualStyleBackColor = false;
            this.checkBox_2.CheckedChanged += new EventHandler(this.checkBox_3_CheckedChanged);
            this.checkBox_3.AutoSize = true;
            this.checkBox_3.BackColor = Color.Yellow;
            this.checkBox_3.Checked = true;
            this.checkBox_3.CheckState = CheckState.Checked;
            this.checkBox_3.Location = new Point(0x10, 11);
            this.checkBox_3.Margin = new Padding(4, 4, 4, 4);
            this.checkBox_3.Name = "checkBoxNoRegistered";
            this.checkBox_3.Size = new Size(0xbb, 0x15);
            this.checkBox_3.TabIndex = 0;
            this.checkBox_3.Text = "Незарегистрированные";
            this.checkBox_3.UseVisualStyleBackColor = false;
            this.checkBox_3.CheckedChanged += new EventHandler(this.checkBox_3_CheckedChanged);
            this.panel_1.Controls.Add(this.panel_2);
            this.panel_1.Controls.Add(this.toolStrip_1);
            this.panel_1.Controls.Add(this.dateTimePicker_0);
            this.panel_1.Controls.Add(this.label_0);
            this.panel_1.Controls.Add(this.dateTimePicker_1);
            this.panel_1.Controls.Add(this.label_1);
            this.panel_1.Dock = DockStyle.Fill;
            this.panel_1.Location = new Point(0, 0);
            this.panel_1.Margin = new Padding(4, 4, 4, 4);
            this.panel_1.Name = "panelDateFilter";
            this.panel_1.Size = new Size(0xb6, 0x2bb);
            this.panel_1.TabIndex = 4;
            this.panel_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.panel_2.Controls.Add(this.splitContainer_1);
            this.panel_2.Location = new Point(0, 130);
            this.panel_2.Margin = new Padding(4, 4, 4, 4);
            this.panel_2.Name = "panelTree";
            this.panel_2.Size = new Size(0xb6, 0x238);
            this.panel_2.TabIndex = 10;
            this.splitContainer_1.Dock = DockStyle.Fill;
            this.splitContainer_1.FixedPanel = FixedPanel.Panel2;
            this.splitContainer_1.Location = new Point(0, 0);
            this.splitContainer_1.Margin = new Padding(4, 4, 4, 4);
            this.splitContainer_1.Name = "splitContainerFilter";
            this.splitContainer_1.Orientation = Orientation.Horizontal;
            this.splitContainer_1.Panel1.Controls.Add(this.checkBox_4);
            this.splitContainer_1.Panel1.Controls.Add(this.treeViewSchmObjects_0);
            this.splitContainer_1.Panel2.Controls.Add(this.checkedListBox_0);
            this.splitContainer_1.Panel2.Controls.Add(this.label_2);
            this.splitContainer_1.Size = new Size(0xb6, 0x238);
            this.splitContainer_1.SplitterDistance = 0x1cf;
            this.splitContainer_1.SplitterWidth = 5;
            this.splitContainer_1.TabIndex = 10;
            this.checkBox_4.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.checkBox_4.AutoSize = true;
            this.checkBox_4.Checked = true;
            this.checkBox_4.CheckState = CheckState.Checked;
            this.checkBox_4.Location = new Point(8, 0x1b7);
            this.checkBox_4.Margin = new Padding(4, 4, 4, 4);
            this.checkBox_4.Name = "checkBoxWhereSub";
            this.checkBox_4.Size = new Size(0xe5, 0x15);
            this.checkBox_4.TabIndex = 13;
            this.checkBox_4.Text = "Фильтровать по подстанциям";
            this.checkBox_4.UseVisualStyleBackColor = true;
            this.treeViewSchmObjects_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.treeViewSchmObjects_0.CheckBoxes = true;
            this.treeViewSchmObjects_0.Location = new Point(0, 0);
            this.treeViewSchmObjects_0.Margin = new Padding(4, 4, 4, 4);
            this.treeViewSchmObjects_0.Name = "treeViewSchmObjects";
            this.treeViewSchmObjects_0.Size = new Size(180, 0x1af);
            this.treeViewSchmObjects_0.set_SqlSettings(null);
            this.treeViewSchmObjects_0.TabIndex = 9;
            this.checkedListBox_0.Dock = DockStyle.Fill;
            this.checkedListBox_0.FormattingEnabled = true;
            this.checkedListBox_0.Location = new Point(0, 0x11);
            this.checkedListBox_0.Margin = new Padding(4, 4, 4, 4);
            this.checkedListBox_0.Name = "checkedListBoxDivision";
            this.checkedListBox_0.Size = new Size(0xb6, 0x53);
            this.checkedListBox_0.TabIndex = 1;
            this.label_2.AutoSize = true;
            this.label_2.Dock = DockStyle.Top;
            this.label_2.Location = new Point(0, 0);
            this.label_2.Margin = new Padding(4, 0, 4, 0);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(0x71, 0x11);
            this.label_2.TabIndex = 0;
            this.label_2.Text = "Подразделения";
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_8, this.toolStripButton_9, this.toolStripButton_10, this.toolStripTextBox_0, this.toolStripButton_11, this.toolStripButton_12 };
            this.toolStrip_1.Items.AddRange(itemArray2);
            this.toolStrip_1.Location = new Point(0, 0);
            this.toolStrip_1.Name = "toolStripFilter";
            this.toolStrip_1.Size = new Size(0xb6, 0x21);
            this.toolStrip_1.TabIndex = 10;
            this.toolStrip_1.Text = "toolStrip1";
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = Resources.filter;
            this.toolStripButton_8.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_8.Name = "toolBtnFilter";
            this.toolStripButton_8.Size = new Size(0x17, 30);
            this.toolStripButton_8.Text = "Применить фильтр";
            this.toolStripButton_8.Click += new EventHandler(this.toolStripButton_8_Click);
            this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_9.Image = Resources.filter_delete;
            this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_9.Name = "toolBtnFilterClear";
            this.toolStripButton_9.Size = new Size(0x17, 30);
            this.toolStripButton_9.Text = "Отменить фильтр";
            this.toolStripButton_9.Click += new EventHandler(this.toolStripButton_9_Click);
            this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_10.Image = Resources.Find;
            this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_10.Name = "toolBtnFind";
            this.toolStripButton_10.Size = new Size(0x17, 30);
            this.toolStripButton_10.Text = "Поиск";
            this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
            this.toolStripTextBox_0.Name = "toolTextBoxFind";
            this.toolStripTextBox_0.Size = new Size(0x47, 0x21);
            this.toolStripTextBox_0.KeyDown += new KeyEventHandler(this.toolStripTextBox_0_KeyDown);
            this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_11.Image = Resources.FindPrev;
            this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_11.Name = "toolBtnFindPrev";
            this.toolStripButton_11.Size = new Size(0x17, 30);
            this.toolStripButton_11.Text = "Поиск назад";
            this.toolStripButton_11.Click += new EventHandler(this.toolStripButton_11_Click);
            this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_12.Image = Resources.FindNext;
            this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_12.Name = "toolBtnFindNext";
            this.toolStripButton_12.Size = new Size(0x17, 30);
            this.toolStripButton_12.Text = "Поиск вперед";
            this.toolStripButton_12.Click += new EventHandler(this.toolStripButton_12_Click);
            this.dateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_0.Location = new Point(8, 0x62);
            this.dateTimePicker_0.Margin = new Padding(4, 4, 4, 4);
            this.dateTimePicker_0.Name = "dateTimePickerEnd";
            this.dateTimePicker_0.Size = new Size(0xa2, 0x16);
            this.dateTimePicker_0.TabIndex = 7;
            this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(4, 0x4f);
            this.label_0.Margin = new Padding(4, 0, 4, 0);
            this.label_0.Name = "label2";
            this.label_0.Size = new Size(0x31, 0x11);
            this.label_0.TabIndex = 6;
            this.label_0.Text = "Конец";
            this.dateTimePicker_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_1.Location = new Point(8, 50);
            this.dateTimePicker_1.Margin = new Padding(4, 4, 4, 4);
            this.dateTimePicker_1.Name = "dateTimePickerBegin";
            this.dateTimePicker_1.Size = new Size(0xa2, 0x16);
            this.dateTimePicker_1.TabIndex = 5;
            this.dateTimePicker_1.ValueChanged += new EventHandler(this.dateTimePicker_1_ValueChanged);
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(4, 0x1f);
            this.label_1.Margin = new Padding(4, 0, 4, 0);
            this.label_1.Name = "label1";
            this.label_1.Size = new Size(0x3a, 0x11);
            this.label_1.TabIndex = 4;
            this.label_1.Text = "Начало";
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Dock = DockStyle.Fill;
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Margin = new Padding(4, 4, 4, 4);
            this.tabControl_0.Name = "tabControlOrder";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x40d, 0x2bb);
            this.tabControl_0.TabIndex = 5;
            this.tabControl_0.SelectedIndexChanged += new EventHandler(this.tabControl_0_SelectedIndexChanged);
            this.tabPage_0.Controls.Add(this.dataGridViewExcelFilter_0);
            this.tabPage_0.Controls.Add(this.panel_0);
            this.tabPage_0.Location = new Point(4, 0x19);
            this.tabPage_0.Margin = new Padding(4, 4, 4, 4);
            this.tabPage_0.Name = "tabPageView";
            this.tabPage_0.Padding = new Padding(4, 4, 4, 4);
            this.tabPage_0.Size = new Size(0x405, 670);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Просмотр";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_1);
            this.tabPage_1.Location = new Point(4, 0x19);
            this.tabPage_1.Margin = new Padding(4, 4, 4, 4);
            this.tabPage_1.Name = "tabPageEvents";
            this.tabPage_1.Padding = new Padding(4, 4, 4, 4);
            this.tabPage_1.Size = new Size(0x3c8, 0x298);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "События";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewFilterTextBoxColumn_18, this.dataGridViewFilterTextBoxColumn_19, this.dataGridViewFilterTextBoxColumn_20, this.dataGridViewFilterTextBoxColumn_21, this.dataGridViewFilterTextBoxColumn_22, this.dataGridViewFilterTextBoxColumn_23, this.dataGridViewTextBoxColumn_34, this.dataGridViewFilterTextBoxColumn_24, this.dataGridViewTextBoxColumn_35, this.dataGridViewTextBoxColumn_36 };
            this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray2);
            this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
            this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_1.Location = new Point(4, 4);
            this.dataGridViewExcelFilter_1.Margin = new Padding(4, 4, 4, 4);
            this.dataGridViewExcelFilter_1.Name = "dgvEvents";
            this.dataGridViewExcelFilter_1.ReadOnly = true;
            this.dataGridViewExcelFilter_1.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_1.RowTemplate.Height = 0x2c;
            this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_1.Size = new Size(960, 0x290);
            this.dataGridViewExcelFilter_1.TabIndex = 0;
            this.dataGridViewExcelFilter_1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_1_CellDoubleClick);
            this.dataGridViewExcelFilter_1.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_1_CellFormatting);
            this.dataGridViewFilterTextBoxColumn_18.DataPropertyName = "num";
            this.dataGridViewFilterTextBoxColumn_18.HeaderText = "№ наряда";
            this.dataGridViewFilterTextBoxColumn_18.Name = "numDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_18.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_18.Width = 60;
            this.dataGridViewFilterTextBoxColumn_19.DataPropertyName = "srNum";
            this.dataGridViewFilterTextBoxColumn_19.HeaderText = "Сетевой район";
            this.dataGridViewFilterTextBoxColumn_19.Name = "srNumDgvColumn";
            this.dataGridViewFilterTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_19.Width = 50;
            this.dataGridViewFilterTextBoxColumn_20.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_20.DataPropertyName = "instruction";
            this.dataGridViewFilterTextBoxColumn_20.HeaderText = "Содержание работ";
            this.dataGridViewFilterTextBoxColumn_20.Name = "instructionDataGridViewTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_20.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_21.DataPropertyName = "acceptFIO";
            this.dataGridViewFilterTextBoxColumn_21.HeaderText = "Допускающий";
            this.dataGridViewFilterTextBoxColumn_21.Name = "acceptFIODataGridViewTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn_21.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_21.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_22.DataPropertyName = "makerFio";
            this.dataGridViewFilterTextBoxColumn_22.HeaderText = "Производитель";
            this.dataGridViewFilterTextBoxColumn_22.Name = "makerFioDataGridViewTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_22.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_23.DataPropertyName = "Evnt";
            this.dataGridViewFilterTextBoxColumn_23.HeaderText = "Состояние работ";
            this.dataGridViewFilterTextBoxColumn_23.Name = "evntDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_23.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_34.DataPropertyName = "EvntDate";
            this.dataGridViewTextBoxColumn_34.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_34.Name = "evntDateDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_34.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_24.DataPropertyName = "disp";
            this.dataGridViewFilterTextBoxColumn_24.HeaderText = "Диспетчер";
            this.dataGridViewFilterTextBoxColumn_24.Name = "dispDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_24.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_24.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_35.DataPropertyName = "closed";
            this.dataGridViewTextBoxColumn_35.HeaderText = "closed";
            this.dataGridViewTextBoxColumn_35.Name = "closedDgvColumn";
            this.dataGridViewTextBoxColumn_35.ReadOnly = true;
            this.dataGridViewTextBoxColumn_35.Visible = false;
            this.dataGridViewTextBoxColumn_36.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_36.HeaderText = "id";
            this.dataGridViewTextBoxColumn_36.Name = "idDgvColumnEvent";
            this.dataGridViewTextBoxColumn_36.ReadOnly = true;
            this.dataGridViewTextBoxColumn_36.Visible = false;
            this.bindingSource_1.DataMember = "vJ_OrderEvents";
            this.bindingSource_1.DataSource = this.dataSetOrder_0;
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Margin = new Padding(4, 4, 4, 4);
            this.splitContainer_0.Name = "splitContainer1";
            this.splitContainer_0.Panel1.Controls.Add(this.panel_1);
            this.splitContainer_0.Panel2.Controls.Add(this.tabControl_0);
            this.splitContainer_0.Size = new Size(0x4c8, 0x2bb);
            this.splitContainer_0.SplitterDistance = 0xb6;
            this.splitContainer_0.SplitterWidth = 5;
            this.splitContainer_0.TabIndex = 6;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "num";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№";
            this.dataGridViewFilterTextBoxColumn_0.Name = "dataGridViewFilterTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_0.Width = 50;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "OutputMaker";
            style7.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_0.DefaultCellStyle = style7;
            this.dataGridViewTextBoxColumn_0.HeaderText = "Наряд выдал Производитель работ";
            this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Resizable = DataGridViewTriState.False;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "srNum";
            style8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewFilterTextBoxColumn_1.DefaultCellStyle = style8;
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Сетевой район";
            this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn2";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.False;
            this.dataGridViewFilterTextBoxColumn_1.Width = 80;
            this.dataGridViewFilterTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "instruction";
            style9.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.DefaultCellStyle = style9;
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Содержание работ";
            this.dataGridViewFilterTextBoxColumn_2.Name = "dataGridViewFilterTextBoxColumn3";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "Resolution";
            style10.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_1.DefaultCellStyle = style10;
            this.dataGridViewTextBoxColumn_1.HeaderText = "Разрешение выдал";
            this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Width = 120;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "idSR";
            this.dataGridViewTextBoxColumn_2.HeaderText = "idSR";
            this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "srName";
            this.dataGridViewTextBoxColumn_3.HeaderText = "srName";
            this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "headworker";
            this.dataGridViewTextBoxColumn_4.HeaderText = "headworker";
            this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "headFio";
            this.dataGridViewTextBoxColumn_5.HeaderText = "headFio";
            this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "acceptworker";
            this.dataGridViewTextBoxColumn_6.HeaderText = "acceptworker";
            this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.Visible = false;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "acceptFIO";
            this.dataGridViewTextBoxColumn_7.HeaderText = "acceptFIO";
            this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.Visible = false;
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_8.HeaderText = "id";
            this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewTextBoxColumn_8.Visible = false;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "watchWorker";
            this.dataGridViewTextBoxColumn_9.HeaderText = "watchWorker";
            this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewTextBoxColumn_9.Visible = false;
            this.dataGridViewTextBoxColumn_10.DataPropertyName = "watchFIO";
            this.dataGridViewTextBoxColumn_10.HeaderText = "watchFIO";
            this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewTextBoxColumn_10.Visible = false;
            this.dataGridViewTextBoxColumn_11.DataPropertyName = "makerWorker";
            this.dataGridViewTextBoxColumn_11.HeaderText = "makerWorker";
            this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewTextBoxColumn_11.Visible = false;
            this.dataGridViewTextBoxColumn_12.DataPropertyName = "makerFIO";
            this.dataGridViewTextBoxColumn_12.HeaderText = "makerFIO";
            this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewTextBoxColumn_12.Visible = false;
            this.dataGridViewTextBoxColumn_13.DataPropertyName = "otherInstruction";
            this.dataGridViewTextBoxColumn_13.HeaderText = "otherInstruction";
            this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewTextBoxColumn_13.Visible = false;
            this.dataGridViewTextBoxColumn_14.DataPropertyName = "outputWorker";
            this.dataGridViewTextBoxColumn_14.HeaderText = "outputWorker";
            this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewTextBoxColumn_14.Visible = false;
            this.dataGridViewTextBoxColumn_15.DataPropertyName = "outputFIO";
            this.dataGridViewTextBoxColumn_15.HeaderText = "outputFIO";
            this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewTextBoxColumn_15.Visible = false;
            this.dataGridViewTextBoxColumn_16.DataPropertyName = "dateClose";
            this.dataGridViewTextBoxColumn_16.HeaderText = "dateClose";
            this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewTextBoxColumn_16.Visible = false;
            this.dataGridViewTextBoxColumn_17.DataPropertyName = "closeWorker";
            this.dataGridViewTextBoxColumn_17.HeaderText = "closeWorker";
            this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewTextBoxColumn_17.Visible = false;
            this.dataGridViewTextBoxColumn_18.DataPropertyName = "closeFIO";
            this.dataGridViewTextBoxColumn_18.HeaderText = "closeFIO";
            this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewTextBoxColumn_18.Visible = false;
            this.dataGridViewTextBoxColumn_19.DataPropertyName = "beginRes";
            this.dataGridViewTextBoxColumn_19.HeaderText = "beginRes";
            this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewTextBoxColumn_19.Visible = false;
            this.dataGridViewTextBoxColumn_20.DataPropertyName = "EndRes";
            this.dataGridViewTextBoxColumn_20.HeaderText = "EndRes";
            this.dataGridViewTextBoxColumn_20.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewTextBoxColumn_20.Visible = false;
            this.dataGridViewTextBoxColumn_21.DataPropertyName = "resWorkerId";
            this.dataGridViewTextBoxColumn_21.HeaderText = "resWorkerId";
            this.dataGridViewTextBoxColumn_21.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn_21.ReadOnly = true;
            this.dataGridViewTextBoxColumn_21.Visible = false;
            this.dataGridViewTextBoxColumn_22.DataPropertyName = "resWorker";
            this.dataGridViewTextBoxColumn_22.HeaderText = "resWorker";
            this.dataGridViewTextBoxColumn_22.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewTextBoxColumn_22.Visible = false;
            this.dataGridViewTextBoxColumn_23.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_23.HeaderText = "id";
            this.dataGridViewTextBoxColumn_23.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewTextBoxColumn_23.Visible = false;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "num";
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "№ наряда";
            this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn4";
            this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.Width = 60;
            this.dataGridViewFilterTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "instruction";
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Содержание работ";
            this.dataGridViewFilterTextBoxColumn_4.Name = "dataGridViewFilterTextBoxColumn5";
            this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "acceptFIO";
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Допускающий";
            this.dataGridViewFilterTextBoxColumn_5.Name = "dataGridViewFilterTextBoxColumn6";
            this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "makerFio";
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Производитель";
            this.dataGridViewFilterTextBoxColumn_6.Name = "dataGridViewFilterTextBoxColumn7";
            this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "Evnt";
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Состояние работ";
            this.dataGridViewFilterTextBoxColumn_7.Name = "dataGridViewFilterTextBoxColumn8";
            this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_24.DataPropertyName = "EvntDate";
            this.dataGridViewTextBoxColumn_24.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_24.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn_24.ReadOnly = true;
            this.dataGridViewTextBoxColumn_25.DataPropertyName = "closed";
            this.dataGridViewTextBoxColumn_25.HeaderText = "closed";
            this.dataGridViewTextBoxColumn_25.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn_25.ReadOnly = true;
            this.dataGridViewTextBoxColumn_25.Visible = false;
            this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "disp";
            this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Диспетчер";
            this.dataGridViewFilterTextBoxColumn_8.Name = "dataGridViewFilterTextBoxColumn9";
            this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x4c8, 0x2d4);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Margin = new Padding(4, 4, 4, 4);
            base.Name = "FormJournalOrder";
            this.Text = "Журнал нарядов";
            base.FormClosed += new FormClosedEventHandler(this.FormJournalOrder_FormClosed);
            base.Load += new EventHandler(this.FormJournalOrder_Load);
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetOrder_0.EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.panel_2.ResumeLayout(false);
            this.splitContainer_1.Panel1.ResumeLayout(false);
            this.splitContainer_1.Panel1.PerformLayout();
            this.splitContainer_1.Panel2.ResumeLayout(false);
            this.splitContainer_1.Panel2.PerformLayout();
            this.splitContainer_1.ResumeLayout(false);
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.tabPage_1.ResumeLayout(false);
            this.dataGridViewExcelFilter_1.EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime time = new DateTime(0x834, 1, 1);
            this.dateTimePicker_1.MaxDate = time;
            this.dateTimePicker_0.MaxDate = time;
            time = new DateTime(0x76c, 1, 1);
            this.dateTimePicker_1.MinDate = time;
            this.dateTimePicker_0.MinDate = time;
            this.treeViewSchmObjects_0.ClearTreeChecked();
            if (this.tabControl_0.SelectedTab == this.tabPage_0)
            {
                this.dateTimePicker_0.Value = this.dateTime_1;
                this.dateTimePicker_1.Value = this.dateTime_0;
                foreach (TreeNode node in this.treeViewSchmObjects_0.Nodes)
                {
                    this.method_8(node, this.list_1);
                }
            }
            else
            {
                this.dateTimePicker_0.Value = this.dateTime_3;
                this.dateTimePicker_1.Value = this.dateTime_2;
                foreach (TreeNode node2 in this.treeViewSchmObjects_0.Nodes)
                {
                    this.method_8(node2, this.list_2);
                }
            }
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            Form19 form1 = new Form19();
            form1.add_GoToSchema(new GoToSchemaEventHandler(this, (IntPtr) this.method_4));
            form1.set_SqlSettings(this.get_SqlSettings());
            form1.FormClosed += new FormClosedEventHandler(this.method_5);
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (this.tabControl_0.SelectedTab == this.tabPage_0)
            {
                if (this.dataGridViewExcelFilter_0.CurrentRow != null)
                {
                    Form19 form = new Form19(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_33.Name].Value), false);
                    form.add_GoToSchema(new GoToSchemaEventHandler(this, (IntPtr) this.method_4));
                    form.set_SqlSettings(this.get_SqlSettings());
                    form.FormClosed += new FormClosedEventHandler(this.method_5);
                    form.MdiParent = base.MdiParent;
                    try
                    {
                        form.Show();
                    }
                    catch
                    {
                    }
                }
            }
            else if (this.dataGridViewExcelFilter_1.CurrentRow != null)
            {
                Form19 form1 = new Form19(Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_36.Name].Value), false);
                form1.add_GoToSchema(new GoToSchemaEventHandler(this, (IntPtr) this.method_4));
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.FormClosed += new FormClosedEventHandler(this.method_5);
                form1.MdiParent = base.MdiParent;
                form1.Show();
            }
        }

        private void toolStripButton_10_Click(object sender, EventArgs e)
        {
            this.treeViewSchmObjects_0.Find(this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_11_Click(object sender, EventArgs e)
        {
            this.treeViewSchmObjects_0.FindPrev(this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_12_Click(object sender, EventArgs e)
        {
            this.treeViewSchmObjects_0.FindNext(this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if ((this.tabControl_0.SelectedTab == this.tabPage_0) && (this.dataGridViewExcelFilter_0.SelectedRows.Count > 0))
            {
                int num = 0;
                using (IEnumerator enumerator = this.dataGridViewExcelFilter_0.SelectedRows.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        if (!Convert.ToBoolean(((DataGridViewRow) enumerator.Current).Cells[this.dataGridViewFilterCheckBoxColumn_0.Name].Value))
                        {
                            num++;
                        }
                    }
                }
                if (num == 0)
                {
                    MessageBox.Show("В выбранном диапазоне нет незарегистрированных нарядов. Удалять можно только их.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (num == this.dataGridViewExcelFilter_0.SelectedRows.Count)
                {
                    if (MessageBox.Show("Удалить выбранные наряды?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in this.dataGridViewExcelFilter_0.SelectedRows)
                        {
                            base.DeleteSqlDataById(this.dataSetOrder_0.tJ_Order, Convert.ToInt32(row.Cells[this.dataGridViewTextBoxColumn_33.Name].Value));
                            this.dataGridViewExcelFilter_0.Rows.Remove(row);
                        }
                    }
                }
                else if (MessageBox.Show("Из выбранных нарядов, незарегистрированных - " + num.ToString() + ". Удалить их?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row2 in this.dataGridViewExcelFilter_0.SelectedRows)
                    {
                        if (!Convert.ToBoolean(row2.Cells[this.dataGridViewFilterCheckBoxColumn_0.Name].Value))
                        {
                            base.DeleteSqlDataById(this.dataSetOrder_0.tJ_Order, Convert.ToInt32(row2.Cells[this.dataGridViewTextBoxColumn_33.Name].Value));
                            this.dataGridViewExcelFilter_0.Rows.Remove(row2);
                        }
                    }
                }
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            if (this.tabControl_0.SelectedTab == this.tabPage_0)
            {
                if (this.dataGridViewExcelFilter_0.CurrentRow != null)
                {
                    Form22 form1 = new Form22(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_33.Name].Value));
                    form1.set_SqlSettings(this.get_SqlSettings());
                    form1.MdiParent = base.MdiParent;
                    form1.Show();
                }
            }
            else if (this.dataGridViewExcelFilter_1.CurrentRow != null)
            {
                Form22 form2 = new Form22(Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_36.Name].Value));
                form2.set_SqlSettings(this.get_SqlSettings());
                form2.MdiParent = base.MdiParent;
                form2.Show();
            }
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            this.toolStripButton_4.Enabled = false;
            if (this.tabControl_0.SelectedTab == this.tabPage_0)
            {
                if (this.dataGridViewExcelFilter_0.CurrentRow != null)
                {
                    Class35.smethod_0(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_33.Name].Value), this.get_SqlSettings());
                }
            }
            else if (this.dataGridViewExcelFilter_1.CurrentRow != null)
            {
                Class35.smethod_0(Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_36.Name].Value), this.get_SqlSettings());
            }
            this.toolStripButton_4.Enabled = true;
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            if (this.tabControl_0.SelectedTab == this.tabPage_0)
            {
                if (this.dataGridViewExcelFilter_0.CurrentRow != null)
                {
                    Form19 form1 = new Form19(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_33.Name].Value), true);
                    form1.add_GoToSchema(new GoToSchemaEventHandler(this, (IntPtr) this.method_4));
                    form1.set_SqlSettings(this.get_SqlSettings());
                    form1.MdiParent = base.MdiParent;
                    form1.Show();
                }
            }
            else if (this.dataGridViewExcelFilter_1.CurrentRow != null)
            {
                Form19 form2 = new Form19(Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_36.Name].Value), true);
                form2.add_GoToSchema(new GoToSchemaEventHandler(this, (IntPtr) this.method_4));
                form2.set_SqlSettings(this.get_SqlSettings());
                form2.MdiParent = base.MdiParent;
                form2.Show();
            }
        }

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            if (this.tabControl_0.SelectedTab == this.tabPage_0)
            {
                this.dateTimePicker_1.Value = this.dateTime_0;
                this.dateTimePicker_0.Value = this.dateTime_1;
                this.method_1();
            }
            else
            {
                this.dateTimePicker_1.Value = this.dateTime_2;
                this.dateTimePicker_0.Value = this.dateTime_3;
                this.method_2();
            }
        }

        private void toolStripButton_7_Click(object sender, EventArgs e)
        {
            Form20 form1 = new Form20();
            form1.set_SqlSettings(this.get_SqlSettings());
            form1.ShowDialog();
            this.method_1();
        }

        private void toolStripButton_8_Click(object sender, EventArgs e)
        {
            if (this.tabControl_0.SelectedTab == this.tabPage_0)
            {
                this.dateTime_0 = this.dateTimePicker_1.Value;
                this.dateTime_1 = this.dateTimePicker_0.Value;
                this.method_1();
            }
            else
            {
                this.dateTime_2 = this.dateTimePicker_1.Value;
                this.dateTime_3 = this.dateTimePicker_0.Value;
                this.method_2();
            }
        }

        private void toolStripButton_9_Click(object sender, EventArgs e)
        {
            this.treeViewSchmObjects_0.ClearTreeChecked();
            if (this.tabControl_0.SelectedTab == this.tabPage_0)
            {
                this.list_1 = new List<int>();
                this.method_1();
            }
            else
            {
                this.list_2 = new List<int>();
                this.method_2();
            }
        }

        private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (e.Modifiers)
                {
                    case Keys.None:
                        this.treeViewSchmObjects_0.FindNext(this.toolStripTextBox_0.Text);
                        break;

                    case Keys.Shift:
                        this.treeViewSchmObjects_0.FindPrev(this.toolStripTextBox_0.Text);
                        break;
                }
            }
        }

        private class Class295
        {
            [CompilerGenerated]
            private int int_0;
            [CompilerGenerated]
            private string string_0;

            internal Class295(int int_1, string string_1)
            {
                this.Id = int_1;
                this.Name = string_1;
            }

            public override string ToString()
            {
                return this.Name;
            }

            internal int Id
            {
                [CompilerGenerated]
                get
                {
                    return this.int_0;
                }
                [CompilerGenerated]
                set
                {
                    this.int_0 = value;
                }
            }

            internal string Name
            {
                [CompilerGenerated]
                get
                {
                    return this.string_0;
                }
                [CompilerGenerated]
                set
                {
                    this.string_0 = value;
                }
            }
        }
    }
}

